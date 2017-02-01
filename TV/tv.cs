using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class Television
    {
        #region Properties
        public string Resolution { get; set; }
        public double RefreshRate { get; set; }
        public double ScreenSize { get; set; }
        public string[] MyProperty { get; set; }
        public enum InputPort { HDMI, DVI, DisplayPort, SCART }
        #endregion


        public Television(string Resolution)
        {
        this.Resolution = Resolution;
        }
        public void ViewProperties()
        {
           foreach (var props = this.GetType().GetProperties())
        }

    }
}