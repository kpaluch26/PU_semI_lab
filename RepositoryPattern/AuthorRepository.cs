using Microsoft.EntityFrameworkCore;
using Model;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class AuthorRepository
    {
        private readonly Database db;

        public AuthorRepository(Database db)
        {
            this.db = db;
        }

        public bool AddRateToAuthor(int index, int rate)
        {
            var author = db.Authors.Where(x => x.Id == index).Single();

            if(author != null)
            {
                db.AuthorsRate.Add(new AuthorRate
                {
                    Type = RateType.AuthorRate,
                    Author = author,
                    FkAuthor = author.Id,
                    Date = DateTime.Now,
                    Value = (short)rate
                });

                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CreateNewAuthor(AuthorDTO author)
        {
            db.Authors.Add(new Author
            {
                FirstName = author.FirstName,
                SecondName = author.SecondName
            });
            db.SaveChanges();
            return true;
        }

        public bool DeleteAuthor(int index)
        {
            var author = db.Authors.Where(x => x.Id == index).Single();

            if(author.Books.Any())
            {
                db.Authors.Remove(author);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<AuthorDTO> GetAuthors(PaginationDTO pagination)
        {
            return db.Authors
                .Include(b => b.Rates)
                .Include(b => b.Books)
                .Skip(pagination.Page * pagination.Count)
                .Take(pagination.Count)
                .ToList()
                .Select(b => new AuthorDTO
                {
                    Id = b.Id,
                    FirstName = b.FirstName,
                    SecondName = b.SecondName,
                    AvarageRate = b.Rates.Count > 0 ? Math.Round(b.Rates.Average(r => r.Value), 2) : 0,
                    RatesCount = b.Rates.Count,                    
                    Books = b.Books.Select(a => new AuthorBooksDTO
                    {
                        Id = a.Id,
                        Title = a.Title
                    }).ToList()
                }).ToList();
        }

        public AuthorDTO EditAuthor(int index, AuthorRequestDTO _authorRequestDTO)
        {
            var author = db.Authors.Include(x => x.Books).Where(x => x.Id == index).Single();
            {
                author.FirstName = _authorRequestDTO.FirstName;
                author.SecondName = _authorRequestDTO.SecondName;
            };
            if (_authorRequestDTO.BooksId == null)
            {
                author.Books = new List<Book>();
            }
            else
            {
                author.Books = db.Books.Where(a => _authorRequestDTO.BooksId.Contains(a.Id)).ToList();
            }
            db.Authors.Update(author);
            db.SaveChanges();

            return new AuthorDTO
            {
                Id = author.Id,
                Books = author.Books.Select(a => new AuthorBooksDTO
                {
                    Id = a.Id,
                    Title = a.Title,
                }).ToList(),
                AvarageRate = (author.Rates.Count() > 0 ? author.Rates.Average(r => r.Value) : 0),
                RatesCount = (author.Rates.Count() > 0 ? author.Rates.Count() : 0),
                FirstName = author.FirstName,
                SecondName = author.SecondName
            };

        }

        public AuthorDTO GetAuthor(int id)
        {
            return db.Authors
                .Include(b => b.Rates)
                .Include(b => b.Books)
                .Select(b => new AuthorDTO
                {
                    Id = b.Id,
                    FirstName = b.FirstName,
                    SecondName = b.SecondName,
                    AvarageRate = b.Rates.Count > 0 ? Math.Round(b.Rates.Average(r => r.Value), 2) : 0,
                    RatesCount = b.Rates.Count,
                    Books = b.Books.Select(a => new AuthorBooksDTO
                    {
                        Id = a.Id,
                        Title = a.Title
                    }).ToList()
                }).Where(b => b.Id == id).Single();
        }
    }
}
