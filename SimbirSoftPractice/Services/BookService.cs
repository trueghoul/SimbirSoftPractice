using AutoMapper;
using SimbirSoftPractice.Entites;
using SimbirSoftPractice.Models;
using SimbirSoftPractice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimbirSoftPractice.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
    }
}
