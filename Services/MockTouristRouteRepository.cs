//using Tourist.Models;

//namespace Tourist.Services
//{
//    /// <summary>
//    /// Mock数据
//    /// </summary>
//    public class MockTouristRouteRepository : ITouristRouteRepository
//    {
//        private List<TouristRoute> _routes;
//        public MockTouristRouteRepository()
//        {
//            if (_routes == null)
//            {
//                InitializeTouristRoutes();
//            }
//        }

//        private void InitializeTouristRoutes()
//        {
//            _routes = new List<TouristRoute>()
//            {
//                new TouristRoute
//                {
//                    Id = Guid.NewGuid(),
//                    Title = "巴山大峡谷",
//                    Description  = "欢迎来到巴山大峡谷",
//                    OriginalPrice = 89.8M,
//                    Features = "<p>吃住行游购娱</p>",
//                    Fees = "<p>交通费用自理</p>",
//                    Notes = "<p>注意安全</p>"
//                },
//                 new TouristRoute
//                {
//                    Id = Guid.NewGuid(),
//                    Title = "黄山",
//                    Description  = "欢迎来到黄山",
//                    OriginalPrice = 89.8M,
//                    Features = "<p>吃住行游购娱</p>",
//                    Fees = "<p>交通费用自理</p>",
//                    Notes = "<p>注意安全</p>"
//                },
//                  new TouristRoute
//                {
//                    Id = Guid.NewGuid(),
//                    Title = "黄果树瀑布",
//                    Description  = "欢迎来到黄果树瀑布",
//                    OriginalPrice = 89.8M,
//                    Features = "<p>吃住行游购娱</p>",
//                    Fees = "<p>交通费用自理</p>",
//                    Notes = "<p>注意安全</p>"
//                },
//            };
//        }

//        public TouristRoute? GetTouristRoute(Guid touristRouteId)
//        {
//            return _routes.FirstOrDefault(r => r.Id == touristRouteId);
//        }

//        public IEnumerable<TouristRoute> GetTouristRoutes()
//        {
//            return _routes.ToList();
//        }

//        public bool CheckIfTheRouteExists(Guid touristRouteId)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<TouristRoutePicture> GetPictureByTouristRouteId(Guid touristRouteId)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId)
//        {
//            throw new NotImplementedException();
//        }

//        public TouristRoutePicture GetPicture(int pictureId)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
