using ChallengeCoodesh_BACK.Application.Services;
using ChallengeCoodesh_BACK.Domain.Entities;
using ChallengeCoodesh_BACK.Domain.Entities.Services;
using ChallengeCoodesh_BACK.Domain.Interfaces;
using ChallengeCoodesh_BACK.Infra.Context;
using ChallengeCoodesh_BACK.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Application
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddDbContext<EntitiesDbContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IRepository<FileUploader>), typeof(FileUploaderRepository));
            services.AddScoped(typeof(FileUploaderService));
            services.AddSingleton(typeof(FileService));

        }
    }
}
