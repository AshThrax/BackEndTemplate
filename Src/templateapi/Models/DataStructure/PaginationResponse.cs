using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace templateapi.Models.DataStructure
{
    public class PaginationResponse
    {
        public List<T> Data {get;set;}
        public int Page {get;set;}
        public int PageSize {get;set;}
        
    }
}