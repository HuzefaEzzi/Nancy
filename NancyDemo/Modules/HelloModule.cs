using ConsoleApp1.Models;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyDemo
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/", parameters => "Hello World");

            Get("/nancy",
                parameters =>
                {
                    Person data = new Person()
                    {
                        Name = "Peter",
                        Email= "p@p.com",
                        Age = 30
                    };
                    return View["index.cshtml", data];
                });
        }
    }
}
