using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        //Hem iki parametreli hem de tek parametreli constructor çalışacak.
        //Bunu yapmamızı sağlayan kod parçacığı => this()
        public Result(bool success, string message):this(success)
        {
            //Getter readonlydir. Readonly'ler constructor da set edilebilir.
            Message = message;
        }
        //overloading
        public Result(bool success)
        {
            //Getter readonlydir. Readonly'ler constructor da set edilebilir.
            
            Success = success;
        }



        public bool Success { get; }

        public string Message { get; }
    }
}
