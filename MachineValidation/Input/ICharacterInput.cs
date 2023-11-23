using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineValidation.Input
{

    public interface ICharacterInput
    {
        Image<Rgba32> BackgroundImage { get; set; }

        int FontSize { get; }

    }

  
}
