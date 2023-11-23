using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineValidation.Output
{
    public interface ISliderOutput
    {
        int Top { get; }
        int Left { get; }

        Image<Rgba32> BackgroundImage { get; }

        Image<Rgba32> SliderImage { get; }
    }
}
