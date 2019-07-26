using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>().ForMember(x => x.Venue, y => y.MapFrom(m => m.Location.VenueName));

            CreateMap<Talk, TalkModel>().ReverseMap().ForMember(x => x.Camp, opt => opt.Ignore())
                .ForMember(x => x.Speaker, opt => opt.Ignore());

            CreateMap<Speaker, SpeakerModel>().ReverseMap();
        }
    }
}