using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Repositories;
using BlogAPI.CL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.SL
{
    public class TagService : Service<Tag>, ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository) : base(tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public Tag GetByName(string name) => _tagRepository.GetByName(name);
    }
}
