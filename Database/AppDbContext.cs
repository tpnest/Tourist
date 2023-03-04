using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json;
using Tourist.Models;

namespace Tourist.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*
             * 生成种子数据
             */
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/TouristRouteMokeData.json";
            var touristRouteJson = File.ReadAllText(path);
            IList<TouristRoute> touristRoutes = JsonConvert.DeserializeObject<IList<TouristRoute>>(touristRouteJson);
            modelBuilder.Entity<TouristRoute>().HasData(touristRoutes);


            var picPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/TouristRoutePictureMockData.json";
            var touristRoutePicJson = File.ReadAllText(picPath);
            IList<TouristRoutePicture> touristRoutePictures = JsonConvert.DeserializeObject<IList<TouristRoutePicture>>(touristRoutePicJson);
            modelBuilder.Entity<TouristRoutePicture>().HasData(touristRoutePictures);

        }
    }
}
