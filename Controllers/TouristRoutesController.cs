using AutoMapper;
using Microsoft.AspNetCore.Http;
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
            var touristRouteFromRepo = _repository.GetTouristRoutes(keyword,largeThan,lessThan);
            if (touristRouteFromRepo == null || touristRouteFromRepo.Count() <= 0)
            {
                return NotFound("没有旅游路线");
            }
            var touristRoutesDto = _mapper.Map<IEnumerable<TouristRouteDto>>(touristRouteFromRepo);
            return Ok(touristRoutesDto);
        }

        [HttpGet("{touristRouteId}",Name = "GetTouristRouteById")]
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
            bool isSuccess =  _repository.Save();

            var touristRouteReturn = _mapper.Map<TouristRouteDto>(touristRouteModel);

            if(isSuccess)
            {
                return CreatedAtRoute(
                    "GetTouristRouteById",
                    new {touristRouteId = touristRouteReturn.Id},
                    touristRouteReturn);
            }
            else
            {
                return Problem("创建失败");
            }

        }
    }
}
