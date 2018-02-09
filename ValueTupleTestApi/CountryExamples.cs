using Swashbuckle.Examples;
using System.Collections.Generic;

namespace ValueTupleTestApi
{
    public class CountryExamples : IExamplesProvider
    {
        public object GetExamples()
        {
            return new List<Country>
            {
                new Country { Id = 123, Prefix = "AA", Name = "Test Country" },
                new Country { Id = 321, Prefix = "BB", Name = "And another" }
            };
        }
    }
}