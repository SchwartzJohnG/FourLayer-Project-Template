using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Template.Models;
using Template.Services.Models;

namespace Template.App_Start {
    public class AutoMapperConfig {

        public static void RegisterMaps() {
            Mapper.CreateMap<ApplicationUserDTO, ApplicationUser>();
            Mapper.CreateMap<ApplicationUser, ApplicationUserDTO>();
        }
    }
}