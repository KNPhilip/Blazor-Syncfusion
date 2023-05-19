using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSyncfusion.Shared.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longtitude { get; set; }
    }
}