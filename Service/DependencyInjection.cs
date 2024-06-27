
using System;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories;
using Repository.Repositories.Interface;
using Service.Helpers;
using Service.Services;
using Service.Services.Interface;

namespace Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation(config =>
            { config.DisableDataAnnotationsValidation = true; });

            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IStudentService, StudentService>();
            //services.AddScoped<IValidator<CountryCreateDto>, CountryCreateDtoValidator>();
            return services;
        }
    }
}
