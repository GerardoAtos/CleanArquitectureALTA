using Alta.DTOs;
using Alta.Entities.POCOs;

namespace Alta.Profiles
{
    public class MongoProfile : ProfileBase
    {
        public MongoProfile()
        {
            CreateMap<HeartBeatInitiate, HeartBeatInitiateDTO>().ReverseMap();
            CreateMap<HeartBeatConfirm, HeartBeatConfirmDTO>().ReverseMap();
            CreateMap<CreateLineInventory, CreateLineInventoryDTO>().ReverseMap();
            CreateMap<LoadDetail, LoadDetailDTO>().ReverseMap();
            CreateMap<LoadError, LoadErrorDTO>().ReverseMap();
            CreateMap<MovementConfirm, MovementConfirmDTO>().ReverseMap();
            CreateMap<RequestInitiate, RequestInitiateDTO>().ReverseMap();
        }
    }
}
