using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineValidation.Output
{
    public class SliderOutput : ISliderOutput
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public Image<Rgba32> BackgroundImage { get; set; }

        public Image<Rgba32> SliderImage { get; set; }
    }
}
