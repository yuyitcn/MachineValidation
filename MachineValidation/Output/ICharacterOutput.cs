using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineValidation.Output
{
    public interface ICharacterOutput
    {

        Image<Rgba32> BackgroundImage { get; }

        string Text { get; }

        List<Point> Points { get; }
    }
}
