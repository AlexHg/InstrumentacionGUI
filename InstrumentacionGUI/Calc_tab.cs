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
	public partial class Calc_tab : UserControl
	{
		private static Calc_tab _instance;
		public static Calc_tab Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Calc_tab();
				return _instance;
			}
		}
		public Calc_tab()
		{
			InitializeComponent();
		}

		private void Calc_tab_Load(object sender, EventArgs e)
		{

		}

		private void Valor2_OnValueChanged(object sender, EventArgs e)
		{

		}
	}
}
