﻿using Redis_API.Models;
using StackExchange.Redis;
using System.Text.Json;

namespace Redis_API.Data
{
    public class RedisPlatformRepo : IPlatformRepo 
    {
        private readonly IConnectionMultiplexer _redis;

        public RedisPlatformRepo(IConnectionMultiplexer redis)
        {
            _redis = redis;
        }
        public void CreatePlatform(Platform platform)
        {
            if (platform == null) 
            {
                throw new ArgumentNullException(nameof(platform));
            }
            var db = _redis.GetDatabase();

            var serialPlatform = JsonSerializer.Serialize(platform);
            
            db.StringSet(platform.Id, serialPlatform);
             
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new NotImplementedException();
        }

        public Platform? GetPlatformById(string id)
        {
            var db = _redis.GetDatabase();

            var platform = db.StringGet(id);

            if (!string.IsNullOrEmpty(platform)) 
            {
                return JsonSerializer.Deserialize<Platform>(platform);
            }
            return null;

        }
    }
}
 