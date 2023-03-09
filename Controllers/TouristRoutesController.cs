using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Tourist.Dtos;
using Tourist.Models;
using Tourist.Services;

namespace Tourist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private readonly ITouristRouteRepository _repository;
        private readonly IMapper _mapper;
        public TouristRoutesController(ITouristRouteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [HttpHead]
        public IActionResult GetTouristRoutes(
            [FromQuery] string? keyword,
            float largeThan,
            float lessThan)
        {
            var touristRouteFromRepo = _repository.GetTouristRoutes(keyword, largeThan, lessThan);
            if (touristRouteFromRepo == null || touristRouteFromRepo.Count() <= 0)
            {
                return NotFound("没有旅游路线");
            }
            var touristRoutesDto = _mapper.Map<IEnumerable<TouristRouteDto>>(touristRouteFromRepo);
            return Ok(touristRoutesDto);
        }

        [HttpGet("{touristRouteId}", Name = "GetTouristRouteById")]
        public IActionResult GetTouristRouteById(Guid touristRouteId)
        {
            var touristRouteFromRepo = _repository.GetTouristRoute(touristRouteId);
            if (touristRouteFromRepo == null)
            {
                return NotFound($"没有找到Id为：{touristRouteId}的路线");
            }
            var touristRouteDto = _mapper.Map<TouristRouteDto>(touristRouteFromRepo);
            return Ok(touristRouteDto);
        }

        [HttpPost]
        public IActionResult CreateTouristRoute([FromBody] TouristRouteCreateDto routeCreateDto)
        {
            var touristRouteModel = _mapper.Map<TouristRoute>(routeCreateDto);

            _repository.CreateTouristRoute(touristRouteModel);
            bool isSuccess = _repository.Save();

            var touristRouteReturn = _mapper.Map<TouristRouteDto>(touristRouteModel);

            if (isSuccess)
            {
                return CreatedAtRoute(
                    "GetTouristRouteById",
                    new { touristRouteId = touristRouteReturn.Id },
                    touristRouteReturn);
            }
            else
            {
                return Problem("创建失败");
            }

        }

        [HttpPut("{touristRouteId}")]
        public IActionResult UpdateTouristRoute(Guid touristRouteId, TouristRouteUpdateDto touristRouteUpdateDto)
        {
            if (!_repository.CheckIfTheRouteExists(touristRouteId))
            {
                return NotFound("旅游路线不存在");
            }

            var touristRoute = _repository.GetTouristRoute(touristRouteId);

            _mapper.Map(touristRouteUpdateDto, touristRoute);

            bool isSuccess = _repository.Save();

            if (isSuccess)
            {
                return NoContent();
            }
            return Problem("更新失败！");

        }

        [HttpPatch("{touristRouteId}")]
        public IActionResult PartiallyUpdateTouristRoute(
            [FromRoute] Guid touristRouteId,
            [FromBody] JsonPatchDocument<TouristRouteUpdateDto> jsonPatch)
        {
            if (!_repository.CheckIfTheRouteExists(touristRouteId))
            {
                return NotFound("旅游路线不存在");
            }

            var routeFromRepo = _repository.GetTouristRoute(touristRouteId);
            var routeToPatch = _mapper.Map<TouristRouteUpdateDto>(routeFromRepo);

            // 验证数据
            jsonPatch.ApplyTo(routeToPatch,ModelState);
            if (!TryValidateModel(routeToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(routeToPatch, routeFromRepo);
            _repository.Save();

            return Ok(routeToPatch);
        }
    }
}
