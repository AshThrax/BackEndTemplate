using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace templateapi.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        /// <summary>
        /// Configuration for DbContext 
        /// </summary>
        /// <param name="model"></param>
        protected override void OnModelCreating (ModelBuilder model)
        {
            
        }
    }
}