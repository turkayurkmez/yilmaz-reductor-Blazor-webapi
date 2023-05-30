namespace ProjectTracking.DataAcess.Repository
{
    public interface IRepository<T>
    {
        IList<T> GetEntities();
    }
}
