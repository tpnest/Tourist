using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tourist.Dtos;
using Tourist.Models;
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
            if (!_repository.CheckIfTheRouteExists(touristRouteId))
            {
                return NotFound("旅游路线不存在");
            }
            var pictures = _repository.GetPicturesByTouristRouteId(touristRouteId);
            if (pictures == null || pictures.Count() <= 0)
            {
                return NotFound("照片不存在");
            }

            return Ok(_mapper.Map<IEnumerable<TouristRoutePictureDto>>(pictures));
        }

        [HttpGet("{pictureId}", Name = "GetPicture")]
        public IActionResult GetPicture(Guid touristRouteId, int pictureId)
        {
            if (!_repository.CheckIfTheRouteExists(touristRouteId))
            {
                return NotFound("旅游路线不存在");
            }

            var picture = _repository.GetPicture(touristRouteId, pictureId);
            if (picture == null)
            {
                return NotFound("图片不存在");
            }

            return Ok(_mapper.Map<TouristRoutePictureDto>(picture));
        }

        [HttpPost]
        public IActionResult CreatePicture(
            [FromRoute] Guid touristRouteId,
            [FromBody] TouristRoutePictureCreateDto touristRoutePictureCreateDto)
        {
            if (!_repository.CheckIfTheRouteExists(touristRouteId))
            {
                return NotFound("旅游路线不存在");
            }

            var pictureModel = _mapper.Map<TouristRoutePicture>(touristRoutePictureCreateDto);
            _repository.CreateTouristRoutePicture(touristRouteId, pictureModel);
            bool isSuccess = _repository.Save();

            var pictureReturn = _mapper.Map<TouristRoutePictureDto>(pictureModel);
            if (isSuccess)
            {
                return CreatedAtRoute("GetPicture",
                    new
                    {
                        touristRouteId = pictureReturn.TouristRouteId,
                        pictureId = pictureReturn.Id
                    },
                    pictureReturn);
            }
            return Problem("图片创建失败");
        }
    }
}
