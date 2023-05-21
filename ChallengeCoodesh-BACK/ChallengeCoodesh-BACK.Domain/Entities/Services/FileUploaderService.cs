using ChallengeCoodesh_BACK.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Domain.Entities.Services
{
    public class FileUploaderService
    {
        private readonly IRepository<FileUploader> _fileUploaderRepository;

        public FileUploaderService(IRepository<FileUploader> fileUploaderRepository)
        {
            _fileUploaderRepository = fileUploaderRepository ?? throw new ArgumentException("This dependency is null", nameof(fileUploaderRepository));
        }

        public IEnumerable<FileUploader> GetAll()
        => _fileUploaderRepository.GetAll();

        public void Save(List<FileUploader> fileList)
        {
            fileList.ForEach(file =>
            {
                try
                {
                    _fileUploaderRepository.Save(file);
                }
                catch (Exception e)
                {
                    throw new Exception($"{e} - {file.ProductDescription}");
                }
            });
        }

    }
}
