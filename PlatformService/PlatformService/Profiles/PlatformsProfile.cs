﻿using System;
using AutoMapper;
using PlatformService.DomainModels;
using PlatformService.Dtos;

namespace PlatformService.Profiles
{
	public class PlatformsProfile : Profile
	{
		public PlatformsProfile()
		{
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
			//CreateMap<PlatformReadDto, PlatformPublishedDto>();
        }
	}
}

