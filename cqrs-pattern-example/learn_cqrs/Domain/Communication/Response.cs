using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Communication
{
    public class Response<T>
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }
        public T Data { get; protected set; }

        public Response(bool success, string message, T data )
        {
            Success = success;
            Message = message ?? string.Empty;
            Data = data;
        }
        /// <summary>
        /// Produce a failure response
        /// </summary>
        /// <param name="message"></param>
        public Response(string message) : this(false, message, default(T))
        {
        }
        /// <summary>
        /// Produce a success response
        /// </summary>
        /// <param name="data"></param>
        public Response(T data) : this(true, string.Empty, data)
        {
        }
    }
}
