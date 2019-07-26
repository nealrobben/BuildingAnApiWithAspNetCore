using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>().ForMember(x => x.Venue, y => y.MapFrom(m => m.Location.VenueName));

            CreateMap<Talk, TalkModel>();
        }
    }
}