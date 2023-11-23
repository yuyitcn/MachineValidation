using MachineValidation.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineValidation.Input
{
    public class SliderInput : ISliderInput
    {
        private int x; private int y;
        public int X { get {

                if (x < 1) { 
                
                    x = new Random().Next(50, BackgroundImage.Width -50);

                }

                return x;

            } set { x = value; } } 

        public int Y { get {

                if (y < 1) {

                    y = new Random().Next(50, BackgroundImage.Height - 50);

                }
                return y;

            } set { y = value; } }

        public Image<Rgba32> BackgroundImage { get; set; }

        public SliderInput(Image<Rgba32> backgroundImage)
        {
            BackgroundImage = backgroundImage;
        }

        public Image<Rgba32> HoleImage { get; set; } = Image.Load<Rgba32>(Resources.hole);
        public Image<Rgba32> SliderImage { get; set; } = Image.Load<Rgba32>(Resources.slider);
        /// <summary>
        /// 滑动图片大小
        /// </summary>
        public Size SliderSize { get; set; } = new Size(50, 50);
    }
}
