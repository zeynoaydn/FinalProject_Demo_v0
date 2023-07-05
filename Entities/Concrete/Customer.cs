using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public char CustomerId { get; set; }
        public char ContactName { get; set; }
        public char CompanyName { get; set; }
        public char City { get; set; }
    }
}
