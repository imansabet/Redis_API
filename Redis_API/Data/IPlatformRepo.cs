﻿using Redis_API.Models;

namespace Redis_API.Data
{
    public interface IPlatformRepo
    {
        void CreatePlatform(Platform platform);
        Platform? GetPlatformById(string id);
        IEnumerable<Platform?>? GetAllPlatforms();
    }
}
