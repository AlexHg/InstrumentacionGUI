using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumentacionGUI
{
	public partial class ControlLed_tab : UserControl
	{
		private static ControlLed_tab _instance;
		public static ControlLed_tab Instance
		{
			get
			{
				if (_instance == null)
					_instance = new ControlLed_tab();
				return _instance;
			}
		}
		public ControlLed_tab()
		{
			InitializeComponent();
		}

		private void ControlLed_tab_Load(object sender, EventArgs e)
		{

		}
	}
}
