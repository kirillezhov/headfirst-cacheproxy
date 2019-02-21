using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CacheProxy.Models;

namespace CacheProxy
{
    //Real Subject
    class BookStore : IBook
    {
        PageContext db;

        public BookStore()
        {
            db = new PageContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Page GetPage(int number)
        {
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }
    }
}
