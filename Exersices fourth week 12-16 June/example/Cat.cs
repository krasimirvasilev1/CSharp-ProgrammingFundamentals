using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace example
{
    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string SayHello()
        {
            return $"Hi, I am {Name}! and i am {Age} years old";
        }

        WebClient paca = new WebClient();
    }
}
