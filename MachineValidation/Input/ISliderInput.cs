using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineValidation.Input
{
    public interface ISliderInput
    {
        int X { get; }
        int Y { get; }
        Image<Rgba32> BackgroundImage { get; }

        Image<Rgba32> HoleImage { get; }

        Image<Rgba32> SliderImage { get; }

        Size SliderSize { get; }

    }

   
}
