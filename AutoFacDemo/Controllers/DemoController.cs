using AutoFac.Bll;
using AutoFac.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Controllers
{
    public class DemoController : BaseController<IDemoService>
    {
        public string SayHello() 
        {
            return this.Service.SayHello();
        }
    }
}