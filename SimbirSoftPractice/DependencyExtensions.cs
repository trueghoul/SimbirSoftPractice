using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimbirSoftPractice.MapperProfiles;
using SimbirSoftPractice.Services;
using SimbirSoftPractice.Repositories;

namespace SimbirSoftPractice
{
    public static class DependencyExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IBookService, BookService>();

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();

            services.AddAutoMapper(typeof(PersonProfile));

            return services;
        }
    }
}
