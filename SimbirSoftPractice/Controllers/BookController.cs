using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimbirSoftPractice.Entites;
using SimbirSoftPractice.Models;
using SimbirSoftPractice.Repositories;
using SimbirSoftPractice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
    }
}
