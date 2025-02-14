using Core.Librarys.SQLite;

namespace Core.Servicers.Interfaces
{
    public interface IDatabase
    {
        CGDbContext GetReaderContext();
        //void CloseReader();
        CGDbContext GetWriterContext();
        void CloseWriter();
    }
}
