using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Compass {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void OnCustomTickmarkText(DevExpress.XtraGauges.Core.Model.CustomTickmarkTextEventArgs ea) {
            string text = ea.Text;
            switch(ea.Text) {
                case "360": text = "-N-"; break;
                case "270": text = "-W-"; break;
                case "180": text = "-S-"; break;
                case "90": text = "-E-"; break;
            }
            ea.Result = text;
        }

		float ToAngle(int angle) {
            if(angle > 0) angle = angle % 360;
            else angle = 360 - Math.Abs(angle) % 360;
            return (float)angle;
        }

		private void trackBarControl1_EditValueChanged(object sender, EventArgs e) {
			this.arcScaleComponent1.Value = ToAngle(trackBarControl1.Value);

		}
    }
}