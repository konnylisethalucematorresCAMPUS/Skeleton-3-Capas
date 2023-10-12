using API.Dtos;
using API.Dtos.Cita;
using API.Dtos.Generic;
using AutoMapper;
using Core.Entities;

namespace API.Profiles;
    public class MappingProfile : Profile{
        public MappingProfile(){

            CreateMap<RolDto, Rol>()
                .ReverseMap();
            CreateMap<UsuarioDto, Usuario>()
                .ReverseMap();
                
            //TODO: Ejemplo
            CreateMap<CitaGetDto, Cita >()
                 .ReverseMap();
            CreateMap<CitaPutDto, Cita >()
                 .ReverseMap();
            CreateMap<CitaPostDto, Cita >()
                 .ReverseMap();

            CreateMap<TratamientoMedicoDto, TratamientoMedico >()
                 .ReverseMap();

            // CreateMap<NombreDto2, NombreEntidad2>()
            //     .ReverseMap();

        }
    }
