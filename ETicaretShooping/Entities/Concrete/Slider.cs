using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Slider
    {
        public Slider()
        {
            SliderImage = new List<SliderImage>();
        }
        [Key]
        public int SliderId { get; set; }
        [NotMapped]
        public IEnumerable<IFormFile> SliderImg { get; set; }
        public virtual List<SliderImage> SliderImage { get; set; }
    }
}
