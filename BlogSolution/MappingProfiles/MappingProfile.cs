using AutoMapper;
using BlogAPI.CL.DomainModels;
using BlogAPI.SharedLayer;

namespace BlogAPI.PL.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Blog, BlogDto>().ReverseMap();
            CreateMap<Blog, CreateBlogDto>().ReverseMap();
            CreateMap<Blog, UpdateBlogDto>().ReverseMap();

            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<Post, CreatePostDto>().ReverseMap();
            CreateMap<Post, UpdatePostDto>().ReverseMap();

            CreateMap<Tag, TagDto>().ReverseMap();
            CreateMap<Tag, CreateTagDto>().ReverseMap();
            CreateMap<Tag, UpdateTagDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();

            CreateMap<UserProfile, UserProfileDto>().ReverseMap();
            CreateMap<UserProfile, CreateUserProfileDto>().ReverseMap();
            CreateMap<UserProfile, UpdateUserProfileDto>().ReverseMap();
        }
    }
}
