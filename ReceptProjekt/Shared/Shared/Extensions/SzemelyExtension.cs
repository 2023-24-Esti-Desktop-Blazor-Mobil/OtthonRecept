using Shared.Dtos;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
   public static class SzemelyExtension
    {
        public static SzemelyDto ToDto(this Szemely szemely)
        {
            return new SzemelyDto
            {
                Id = szemely.Id,
                FirstName = szemely.FirstName,
                LastName = szemely.LastName,
                Age = szemely.Age,
                KepzettsegId = szemely.KepzettsegId,
                Kepzettseg = szemely.Kepzettseg,
            };
        }

        public static Szemely ToModel(this SzemelyDto szemelydto)
        {
            return new Szemely
            {
                Id = szemelydto.Id,
                FirstName = szemelydto.FirstName,
                LastName = szemelydto.LastName,
                Age = szemelydto.Age,
                KepzettsegId = szemelydto.KepzettsegId,
                Kepzettseg = szemelydto.Kepzettseg,
            };
        }

    }
}
