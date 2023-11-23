using MachineValidation.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineValidation.Input
{
    public class CharacterInput : ICharacterInput
    {
        public Image<Rgba32> BackgroundImage { get; set; }

        public CharacterInput(Image<Rgba32> backgroundImage)
        {
            BackgroundImage = backgroundImage;
        }

        public int FontSize { get; set; } = 20;
    }
}