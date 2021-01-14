using System;
using System.Net.Http;

namespace RegisterEmployee.Helper
{
    public class EmployeeAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4532/");
            return client;
        }
    }
}
