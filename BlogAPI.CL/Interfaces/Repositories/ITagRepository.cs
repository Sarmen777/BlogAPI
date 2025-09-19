using BlogAPI.CL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.CL.Interfaces.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
        Tag GetByName(string name);
    }
}
