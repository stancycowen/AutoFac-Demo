using AutoFac.Dal;
using AutoFac.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Bll
{
    public class DemoService : IDemoService
    {
        public string SayHello() 
        {
            return new DemoDal().SayHello();
        }
    }
}
