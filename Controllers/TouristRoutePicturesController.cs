using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tourist.Dtos;
using Tourist.Services;

namespace Tourist.Controllers
{
    [Route("api/touristRoutes/{touristRouteId}/pictures")]
    [ApiController]
    public class TouristRoutePicturesController : ControllerBase
    {
        private readonly ITouristRouteRepository _repository;
        private readonly IMapper _mapper;

        public TouristRoutePicturesController(ITouristRouteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPicturesForTouristRoute(Guid touristRouteId)
        {
            if(!_repository.CheckIfTheRouteExists(touristRouteId))
            {
                return NotFound("旅游路线不存在");
            }
            var pictures = _repository.GetPictureByTouristRouteId(touristRouteId);
            if(pictures == null || pictures.Count() <= 0)
            {
                return NotFound("照片不存在");
            }
            
            return Ok(_mapper.Map<IEnumerable<TouristRoutePictureDto>>(pictures));

        }
    }
}
