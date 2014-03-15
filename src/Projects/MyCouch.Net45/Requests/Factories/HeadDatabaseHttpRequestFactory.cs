﻿using System.Net.Http;
using MyCouch.Net;

namespace MyCouch.Requests.Factories
{
    public class HeadDatabaseHttpRequestFactory : HttpRequestFactoryBase
    {
        public HeadDatabaseHttpRequestFactory(IConnection connection) : base(connection) { }

        public virtual HttpRequest Create(HeadDatabaseRequest request)
        {
            var httpRequest = CreateFor<HeadDatabaseRequest>(HttpMethod.Head, GenerateRequestUrl());

            return httpRequest;
        }

        protected virtual string GenerateRequestUrl()
        {
            return Connection.Address.ToString();
        }
    }
}