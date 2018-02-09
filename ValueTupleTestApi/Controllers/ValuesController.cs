using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Examples;
using Swashbuckle.Swagger.Annotations;

namespace ValueTupleTestApi.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [SwaggerOperation("GetAll")]
        public (int id, string name, string prefix) Get()
        {
            var c = new Country();
            var returnData = c.ReturnAllData();
            return (returnData.id, returnData.name, returnData.prefix);
        }

        // GET api/values/5
        //[SwaggerOperation("GetById", Tags = new string[] { "Tag1"})]
        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<Country>))]
        //[SwaggerResponse(HttpStatusCode.BadRequest, Type = typeof(ErrorResource))]
        //[SwaggerResponseExample(HttpStatusCode.OK, typeof(CountryExamples))]
        //[SwaggerResponseRemoveDefaults]

        //[SwaggerRequestExample(typeof(Country), typeof(CountryExamples))]

        public HttpResponseMessage PostCountry([FromBody]Country country)
        {
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }

        [Route("GetDataReturn")]
        public HttpResponseMessage GetData()
        {
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
    }
}
