using System;
using PlatformService.DomainModels;

namespace PlatformService.Data
{
	public interface IPlatformRepo
	{
        IEnumerable<Platform> GetAllPlatforms();

        Platform? GetPlatformById(string id);

        string CreatePlatform(Platform plat);
    }
}

