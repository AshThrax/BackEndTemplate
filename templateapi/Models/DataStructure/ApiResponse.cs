using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace templateapi.Models.DataStructure
{
    public class ApiResponse<T>
    {
        public T? Data {get; set;}
        public string Message {get; set;}= string.Empty;
        public bool Succes {get; set;} = false;
        public ErrorType errorType{get; set;} = ErrorType.Good;
    }
}