﻿using System;
namespace PlatformService.Dtos
{
	public class PlatformReadDto
	{
        public PlatformReadDto(int id, string name, string publisher, string cost)
        {
            Id = id;
            Name = name;
            Publisher = publisher;
            Cost = cost;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Cost { get; set; }
    }
}

