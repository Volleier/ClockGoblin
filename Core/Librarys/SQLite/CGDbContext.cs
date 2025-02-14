using Core.Models;
using Core.Models.Db;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;

namespace Core.Librarys.SQLite
{
    public class CGDbContext : DbContext
    {
        /// <summary>
        /// 每日数据
        /// </summary>
        public DbSet<DailyLogModel> DailyLog { get; set; }
        /// <summary>
        /// 时段数据
        /// </summary>
        public DbSet<HoursLogModel> HoursLog { get; set; }
        public DbSet<AppModel> App { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public DbSet<CategoryModel> Categorys { get; set; }
        /// <summary>
        /// 网站
        /// </summary>
        public DbSet<WebSiteModel> WebSites { get; set; }
        /// <summary>
        /// 网站分类
        /// </summary>
        public DbSet<WebSiteCategoryModel> WebSiteCategories { get; set; }
        /// <summary>
        /// 网页浏览记录（每小时）
        /// </summary>
        public DbSet<WebBrowseLogModel> WebBrowserLogs { get; set; }
        /// <summary>
        /// 网页链接
        /// </summary>
        public DbSet<WebUrlModel> WebUrls { get; set; }

        private static string _dbFilePath = Path.Combine(FileHelper.GetRootDirectory(), "Data", "data.db");
        public CGDbContext()
       : base(new SQLiteConnection()
       {
           ConnectionString = $"Data Source={_dbFilePath}",
           BusyTimeout = 60
       }, true)
        {
            DbConfiguration.SetConfiguration(new SQLiteConfiguration());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var model = modelBuilder.Build(Database.Connection);
            new SQLiteBuilder(model).SelfCheck();
        }

        public void SelfCheck()
        {
            Database.ExecuteSqlCommand("select count(*) from sqlite_master where type='table' and name='tai'");
        }
    }
}