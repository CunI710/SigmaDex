using AutoMapper;
using Core.Models.BaseModels;
using Core.Models.Query.Requests.Sigma;
using Core.Models.Query.Requests.Sigmatype;
using Core.Models.Query.Responses;
using Core.Models.Query.Responses.Sigma;
using DataAccess.Entities;

namespace SigmaDex.Profiles {
    public class MappingProfile : Profile {
        public MappingProfile() {
            CreateMap<SigmaCreateRequest, Sigma>();
            CreateMap<SigmaUpdateRequest, Sigma>();

            CreateMap<Sigma, SigmaExampleResponse>()
                .ForMember(s=>s.Types,o=>o.MapFrom(ts=>ts.Types.Select(t=>t.Name)));
            CreateMap<Sigma, SigmaInfoResponse>();

            CreateMap<SigmaEntity, Sigma>();
            CreateMap<Sigma, SigmaEntity>();


            CreateMap<SigmaTypeCreateRequest, SigmaType>();

            CreateMap<SigmaType, SigmaTypeExampleResponse>();
            CreateMap<SigmaType, SigmaTypeInfoResponse>();

            CreateMap<SigmaTypeEntity, SigmaType>();
            CreateMap<SigmaType, SigmaTypeEntity>();

        }
    }
}
