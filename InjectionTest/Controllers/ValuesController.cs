using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InjectionTest.Test;

namespace InjectionTest.Controllers {
    public class ValuesController : ApiController{
        private ISample sample;
        public ValuesController( ISample sample ){
            this.sample = sample;
        }
        // GET api/values
        public IEnumerable<string> Get(){
            return sample.GetValues();
        }

        // GET api/values/5
        public string Get( int id ) {
            return "value";
        }

        // POST api/values
        public void Post( [FromBody]string value ) {
        }

        // PUT api/values/5
        public void Put( int id, [FromBody]string value ) {
        }

        // DELETE api/values/5
        public void Delete( int id ) {
        }
    }
}
