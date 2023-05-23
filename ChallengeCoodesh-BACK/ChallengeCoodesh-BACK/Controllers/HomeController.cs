using AutoMapper;
using ChallengeCoodesh_BACK.Application.Services;
using ChallengeCoodesh_BACK.Domain.Entities.Services;
using ChallengeCoodesh_BACK.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        /// <summary>
        /// This bellow method transformed a txt file and save a transaction receive.
        /// </summary>
        /// <param name="fileTxt"></param>
        /// <returns></returns>

        [HttpPost, Route("/Save")]
        public IActionResult Save([FromBody] string fileTxt)
        {
            try
            {


                var textString = _fileService.Base64ToString(fileTxt);
                var objectList = _fileService.SerializerFile(textString);
                _fileUploaderService.Save(objectList);

                return Created("Sucess", HttpStatusCode.Created);
            }
            catch (Exception e)
            {
                return BadRequest($"Application error: {e.Message}");
            }
        }

        /// <summary>
        /// return a list transaction.
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("/GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_fileUploaderService.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest($"Application error: {e.Message}");
            }
        }
    }
}
