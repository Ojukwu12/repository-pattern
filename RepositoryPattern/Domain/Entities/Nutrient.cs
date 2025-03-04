﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Nutrient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }
        public double Percentage { get; set; }
        public int NutritionId { get; set; }
        public Nutrition Nutrition { get; set; }
    }
}
