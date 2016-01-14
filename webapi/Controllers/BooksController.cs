using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.Models;

namespace webapi.Controllers
{
    public class BooksController : ApiController
    {
        
            //Dane przykładowe
            Book[] Books = new Book[] 
        {
            new Book{ Id = 1, Title = "Ogniem i mieczem", Price = 39.99M }, 
            new Book{ Id = 2, Title = "W pustyni i w puszczy", Price = 34.99M }, 
            new Book{ Id = 3, Title = "Władca pierścieni",  Price = 49.99M },
            new Book{ Id = 4, Title = "Harry Potter",  Price = 79.99M },
            new Book{ Id = 5, Title = "Jak zjeść i nie przytyć?",  Price = 266.99M },
            new Book{ Id = 6, Title = "Biografia Andrzeja Gołoty",  Price = 15.99M }
        };

            //Zwraca całą tablicę
            //URL: /api/books/
            public IEnumerable<Book> GetAllBooks()
            {
                return Books;
            }

            //Zwraca książkę o podanym id
            //URL: /api/books/id
            public IHttpActionResult GetBook(int id)
            {
                var product = Books.FirstOrDefault((p) => p.Id == id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
        
    }
}
