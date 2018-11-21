using System;
using System.Collections.Generic;
using Bogus;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace FunctionApp2
{
    public class MyRedis
    {
        private ConnectionMultiplexer _connectionMultiplexer;
        private IDatabase _cache;
        private object _lock = new object();
        private string _cacheConnection = "xxx";

        private IDatabase Cache
        {
            get
            {
                if (_cache == null)
                {
                    Init();
                }

                return _cache;
            }
        }

        private void Init()
        {
            if (_connectionMultiplexer != null) return;
            {
                lock (_lock)
                {
                    if (_connectionMultiplexer != null) return;
                    {
                        //var redisConfig = ConfigurationOptions.Parse(_cacheConnection);
                        //redisConfig.AllowAdmin = true;
                        _connectionMultiplexer = ConnectionMultiplexer.Connect(_cacheConnection);
                        _cache = _connectionMultiplexer.GetDatabase();
                    }
                }
            }
        }

        public async System.Threading.Tasks.Task QueryAsync()
        {
            var value = await Cache.StringGetAsync("performance");
            var docval = JsonConvert.DeserializeObject<List<PerformanceDocument>>(value);
        }

        public async System.Threading.Tasks.Task CreateAsync()
        {
            var testMaterial = new Faker<TaskMaterial>();
            var testContact = new Faker<ContactInformation>();
            var testDrive = new Faker<DriveDetail>();
            var testTasks = new Faker<PerformanceTask>()
                .RuleFor(task => task.DriveDetails, f => testDrive.Generate(5))
                .RuleFor(task => task.ContactInformation, f => testContact.Generate(5))
                .RuleFor(task => task.TaskMaterials, f => testMaterial.Generate(5));
            var testDoc = new Faker<PerformanceDocument>()
                .RuleFor(doc => doc.Tasks, f => testTasks.Generate(15));

            var docs = testDoc.Generate(3600);
            try
            {
                var strValue = JsonConvert.SerializeObject(docs);
                await Cache.StringSetAsync("performance", strValue);
            }
            catch (Exception exc)
            {

            }
        }
    }
}
