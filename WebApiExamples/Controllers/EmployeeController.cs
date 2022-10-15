﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExamples.Models;
using System.Threading;

namespace WebApiExamples.Controllers
{
    public class EmployeeController : ApiController
    {
        [BasicAuthentication]
        public HttpResponseMessage GetEmployees()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            var EmpList = new EmployeeBL().GetEmployees();
            switch (username.ToLower())
            {
                case "maleuser":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(e => e.Gender.ToLower() == "male").ToList());
                case "femaleuser":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(e => e.Gender.ToLower() == "female").ToList());
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
