using Tourist.Models;

namespace Tourist.Services
{
    public interface ITouristRouteRepository
    {
        /// <summary>
        /// 获得所有旅游路线
        /// </summary>
        /// <returns></returns>
        IEnumerable<TouristRoute> GetTouristRoutes();

        /// <summary>
        /// 获得单个旅游路线
        /// </summary>
        /// <param name="touristRouteId"></param>
        /// <returns></returns>
        TouristRoute GetTouristRoute(Guid touristRouteId);
    }
}
