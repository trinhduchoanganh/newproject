using System;

namespace ShopBack.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopBackDbContext Init();
    }
}