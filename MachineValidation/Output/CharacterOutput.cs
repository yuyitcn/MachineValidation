using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineValidation.Output
{
    public class CharacterOutput : ICharacterOutput
    {
        public Image<Rgba32> BackgroundImage { get; set; }

        public string Text { get; set; }

        public List<Point> Points { get; set; }
    }
}
