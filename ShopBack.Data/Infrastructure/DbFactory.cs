namespace ShopBack.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopBackDbContext dbContext;

        public ShopBackDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopBackDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}