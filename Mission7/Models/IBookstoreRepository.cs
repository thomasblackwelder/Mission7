using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public interface IBookstoreRepository
    {
        // an IQueryable of type Books that we will refer to as "books" with only a get - so we can only READ data from it 
        IQueryable<Book> Books { get; }
    }
}
