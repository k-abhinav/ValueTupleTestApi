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
                new Country { Prefix = "AA", Name = "Test Country" },
                new Country { Prefix = "BB", Name = "And another" }
            };
        }
    }
}