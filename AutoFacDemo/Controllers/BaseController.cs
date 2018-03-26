using AutoFac.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacDemo.Controllers
{
    public class BaseController<TService> : System.Web.Mvc.Controller where TService : IDependency
    {
        private TService _Service;

        protected TService Service
        {
            get
            {

                if (this._Service != null)
                {
                    return this._Service;
                }
                else
                {
                    return DependencyResolver.Current.GetService<TService>();
                }
            }

        }

        public BaseController()
        {
        }

        public BaseController(TService service)
        {
            this._Service = service;
        }
    }
}