﻿using System.Net;

namespace ServiceFabric.Utils.Shared
{
    /// <summary>
    /// Strongly typed version of the JSON message generated by <see cref="ApiHttpResponseMessage"/>
    /// </summary>
    /// <typeparam name="TMessageType">Type of the inner message property</typeparam>
    public class ApiResponseMessage<TMessageType>
    {

        public ApiResponseMessage()
        {
        }

        public ApiResponseMessage(HttpStatusCode code, TMessageType message, string info)
        {
            Code = code;
            Message = message;
            Info = info;
        }

        public HttpStatusCode Code { get; set; }

        public TMessageType Message { get; set; }

        public string Info { get; set; }
    }
}