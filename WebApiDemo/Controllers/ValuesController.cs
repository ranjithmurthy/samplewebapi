using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
  
    public class ValuesController : ApiController
    {
        static Dictionary<int,string> Employees = new Dictionary<int,string>()
        {
            
        {1, "Ranjith"},
        {2, "Rohith"},
        {3, "Varsha"},
        {4, "Ritesh"},
        {5, "Rakesh"},
        {6, "Vinod"},
        {7, "NotFound"},
       
    };

          
      

        // GET api/values

        public Dictionary<int, string> Get()
        {
            return Employees;
        }

        // GET api/values/5
        public string Get(int id)
        {
            var item = Employees.Where(x => x.Key == id);
            return item.FirstOrDefault().Value;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            int count = Employees.Count;
            Employees.Add(count,value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
       

            Employees[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            if(Employees.ContainsKey(id))
            {
                //var item=Employees.Where(x => x.Key == id).FirstOrDefault();
                Employees.Remove(id);
            }
        }
    }
}
