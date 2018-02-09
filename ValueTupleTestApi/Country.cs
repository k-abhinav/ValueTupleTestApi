using System;
using System.Collections.Generic;
using System.Linq;

namespace ValueTupleTestApi
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }

        internal (int id, string name, string prefix) ReturnAllData()
        {
            var c = new CountryExamples();
            var d = (List<Country>)c.GetExamples();
            var item = d.FirstOrDefault();
            return (item.Id, item.Name, item.Prefix);
        }
    }

    internal class ErrorResource
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
    }
}