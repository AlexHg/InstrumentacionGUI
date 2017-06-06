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
	public partial class Config_tab : UserControl
	{
		private static Config_tab _instance;
		public static Config_tab Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Config_tab();
				return _instance;
			}
		}
		public Config_tab()
		{
			InitializeComponent();
		}

		private void Config_tab_Load(object sender, EventArgs e)
		{

		}
	}
}
