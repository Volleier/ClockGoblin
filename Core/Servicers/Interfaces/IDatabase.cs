using Core.Librarys.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
