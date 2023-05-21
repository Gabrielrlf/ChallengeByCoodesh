using AutoMapper;
using ChallengeCoodesh_BACK.Application.Services;
using ChallengeCoodesh_BACK.Domain.Entities.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly FileService _fileService;
        private readonly FileUploaderService _fileUploaderService;

        public HomeController(FileService fileService, FileUploaderService fileUploaderService, IMapper mapper)
        {
            _fileService = fileService ?? throw new ArgumentException("This dependency is null", nameof(fileService));
            _fileUploaderService = fileUploaderService ?? throw new ArgumentException("This dependency is null", nameof(fileUploaderService));
            _mapper = mapper ?? throw new ArgumentException("This dependency is null", nameof(mapper));

        }

        [HttpPost, Route("/Save")]
        public IActionResult Save([FromBody] string fileTxt)
        {
            var textString = _fileService.Base64ToString(fileTxt);
            var objectList = _fileService.SerializerFile(textString);
            _fileUploaderService.Save(objectList);


            return Ok();
        }
    }
}
