namespace DataLayer1.UnitOfWork
{
    public interface IUnitOfWork
    {
        int Compelte();
        void StartDatabase();
    }
}