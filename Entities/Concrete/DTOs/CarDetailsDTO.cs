﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CarDetailsDTO : IDto
    {

        public string BrandName { get; set; }

        public string ColorName { get; set; }

        public decimal DailyPrice { get; set; }

        public int ModelYear { get; set; }

        public string Description { get; set; }
    }
}
