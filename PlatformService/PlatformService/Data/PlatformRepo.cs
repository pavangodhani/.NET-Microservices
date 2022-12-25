using System;
using Microsoft.EntityFrameworkCore;
using PlatformService.DomainModels;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _dbContext;

        public PlatformRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string CreatePlatform(Platform? platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }
            platform.Id = Guid.NewGuid().ToString();
            _dbContext.Platforms.Add(platform);
            _dbContext.SaveChanges();
            return platform.Id;
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _dbContext.Platforms.ToList();
        }

        public Platform? GetPlatformById(string id)
        {
            return _dbContext.Platforms.FirstOrDefault(p => p.Id == id);
        }
    }
}

