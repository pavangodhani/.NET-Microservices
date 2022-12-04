using System;
using PlatformService.DomainModels;

namespace PlatformService.Data
{
	public interface IPlatformRepo
	{
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();

        Platform GetPlatformById(int id);

        void CreatePlatform(Platform plat);
    }
}

