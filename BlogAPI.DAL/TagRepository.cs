using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.DAL
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(BlogContext context) : base(context) { }

        public Tag GetByName(string name)
        {
            return _dbSet.FirstOrDefault(t => t.Name == name);
        }
    }
}
