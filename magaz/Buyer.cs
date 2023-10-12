using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    internal class Buyer
    {
        private string name;
        private string email;
        public Buyer(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public string Name => name;

        public string Email => email;
    }
}
