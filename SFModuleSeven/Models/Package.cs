using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleSeven.Models
{
    internal class Package
    {
        public double Weight { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public string? Description { get; set; }

        public bool IsBrittle { get; set; }

        public Package(double weight, double height, double width, bool isBrittle, string? description = null)
        {
            Weight = weight;

            Height = height;

            Width = width;

            Description = description;

            IsBrittle = isBrittle;
        }
    }
}
