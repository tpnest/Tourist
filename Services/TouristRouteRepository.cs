using System.Text.RegularExpressions;
using Tourist.Database;
using Tourist.Models;

namespace Tourist.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {
        private readonly AppDbContext _context;

        public TouristRouteRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool CheckIfTheRouteExists(Guid touristRouteId)
        {
          return  _context.TouristRoutes.Any(t => t.Id == touristRouteId);
        }

        public TouristRoutePicture GetPicture(Guid touristRouteId,int pictureId)
        {
            return _context.TouristRoutePictures.Where(p => p.Id == pictureId && p.TouristRouteId == touristRouteId).FirstOrDefault();
        }

        public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId)
        {
            return _context.TouristRoutePictures
                .Where(p => p.TouristRouteId == touristRouteId)
                .ToList();
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _context.TouristRoutes.FirstOrDefault(t => t.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes(string keyword,float largeThan,float lessThan)
        {

            IQueryable<TouristRoute> routes = _context.TouristRoutes;
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim();
                routes = routes.Where(r => r.Title.Contains(keyword));
            }
            
            if (largeThan > 0 && lessThan > 0)
            {
                routes = routes.Where(r => r.DiscountPresent >= largeThan && r.DiscountPresent <= lessThan);
            }
            if(largeThan >0 && lessThan == 0)
            {
                routes = routes.Where(r => r.DiscountPresent >= largeThan);
            }
            if (largeThan == 0 && lessThan > 0)
            {
                routes = routes.Where(r => r.DiscountPresent <= lessThan);
            }

            return routes.ToList();
        }

        public  void CreateTouristRoute(TouristRoute touristRoute)
        {
            if(touristRoute == null)
            {
                throw new ArgumentNullException(nameof(touristRoute));
            }
             _context.Add(touristRoute);
        }

        public  bool Save()
        {
            return ( _context.SaveChanges() > 0);
        }
    }
}
