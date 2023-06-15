using AutoMapper;
using MyOwnBlog.Models;
using MyOwnBlog.ViewModels.Account;

namespace MyOwnBlog
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //CreateMap<RegisterViewModel, User>()
            //    .ForMember(x => x.Email, opt => opt.MapFrom(c => c.Email))
            //    .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.LastName));
            //CreateMap<LoginViewModel, User>();

            //CreateMap<UserEditViewModel, User>();
            //CreateMap<User, UserEditViewModel>().ForMember(x => x.UserId, opt => opt.MapFrom(c => c.Id));

            //CreateMap<UserWithFriendExt, User>();
            //CreateMap<User, UserWithFriendExt>();
        }
    }
}
