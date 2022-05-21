﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; }

        public bool Message { get; }

        public Result(bool success, string message) : this(success)
        {
            Message = Message;
        }

        public Result(bool success)
        {
            Success = success;
        }



    }
}
