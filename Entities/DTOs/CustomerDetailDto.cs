using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CustomerDetailDto : IDto
    {
        
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }

    }
}
