using AutoMapper;
using ChallengeCoodesh_BACK.Domain.Entities;
using ChallengeCoodesh_BACK.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.AutoMapper
{
    public class FileMapping : Profile
    {
        public FileMapping()
        {
            CreateMap<FileUploader, FileUploaderDto>();
        }
    }
}
