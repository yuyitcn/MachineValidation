using Microsoft.VisualStudio.TestTools.UnitTesting;
using MachineValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using MachineValidation.Input;

namespace MachineValidation.Tests
{
    [TestClass()]
    public class MachineValidationTests
    {
        [TestMethod()]
        public void GetRandomStringTest()
        {

            var m =  MachineValidation.CreateCharacter(new CharacterInput(Image.Load<Rgba32>("1.png")) { FontSize = 35});

            m.BackgroundImage.SaveAsJpeg("CharacterTest.png");

            var n = MachineValidation.CreateSlider(new  SliderInput(Image.Load<Rgba32>("1.png")));

            n.BackgroundImage.SaveAsJpeg("SliderTest.png");

            Assert.Fail();
        }
    }
}