using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace templateapi.ExtensionMethods
{
    public static class RepositoryInjection
    {
        /// <summary>
        /// add dependency injection For repository
        /// </summary>
        /// <param name="services"></param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public static iServiceCollection AddTemplateRepository(this iServiceCollection services, string templateId)
        {
            return services;
        }
    }
}