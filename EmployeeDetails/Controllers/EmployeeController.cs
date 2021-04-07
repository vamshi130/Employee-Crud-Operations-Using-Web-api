using DataAccessEmployees;
using DataModelsEmployee.EmployeeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeDetails.Controllers
{
    //[Authorize]
    public class EmployeeController : ApiController
    {
        IEmployeeRepo repo = new Employee();
        [HttpGet]
        public HttpResponseMessage GetEmployee()
        {
            var organlist = repo.GetALL();

            //var OrganList = db.organs.ToList();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, organlist);
            return response;
        }

        [HttpPost]
        public HttpResponseMessage PostCreateEmployee(Organisation model)
        {
            repo.Create(model);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "added");
            return response;

        }
        public HttpResponseMessage GetByEmployeeID(int id)
        {
            var data = repo.GetBYID(id);
            var response = Request.CreateResponse(HttpStatusCode.OK, data);
            return response;
        }
        [HttpPut]
        public HttpResponseMessage EditEmployee(Organisation organ)
        {
            repo.Edit(organ);
            var response = Request.CreateResponse(HttpStatusCode.OK, "eddited");
            return response;
        }
        [HttpDelete]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            var obj = repo.Delete(id);
            var response = Request.CreateResponse(HttpStatusCode.OK, obj);
            return response;
        }

    }
}
