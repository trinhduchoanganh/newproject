namespace ShopBack.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}