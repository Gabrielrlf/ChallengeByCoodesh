using ChallengeCoodesh_BACK.Domain.Entities;
using ChallengeCoodesh_BACK.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Infra.Repositories
{
    public class FileUploaderRepository : Repository<FileUploader>
    {
        public FileUploaderRepository(EntitiesDbContext entitiesDbContext) : base(entitiesDbContext)
        {}

        public override IEnumerable<FileUploader> GetAll()
        {
            return base.GetAll();
        }
   
    }
}
