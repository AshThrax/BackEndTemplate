using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace templateapi.Shared
{
    public static class ErrorMananger
    {
        public static ApiResponse<T> Error(Exception exception)
        {
            switch(exception)
            {
                case ArgumentNullException:
                    return new ApiReponse<T>{
                            Data=null,
                            ErrorType=,
                            Message=exception.Message,
                            Success=false
                            };
                            } ;
                case NullReferenceException:
                    return new ApiReponse<T>{
                            Data=null,
                            ErrorType=,
                            Message=exception.Message,
                            Success=false
                            };
                default :
                    return new ServiceReponse<T>{
                            Data=null,
                            ErrorType=,
                            Message=exception.Message,
                            Success=false
                            };
                            
            }
        }

        public static string Error()
        {

        }
    }
}