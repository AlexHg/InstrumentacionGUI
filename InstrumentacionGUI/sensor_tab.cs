using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace InstrumentacionGUI
{
	public partial class Sensor_tab : UserControl
	{
		private static Sensor_tab _instance;
		public static Sensor_tab Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Sensor_tab();
				return _instance;
			}
		}
		private int lenArr = 0;
		public Sensor_tab()
		{
			InitializeComponent();
			CanalUno();
		}

		private void Sensor_tab_Load(object sender, EventArgs e)
		{

		}
		public void CanalUno()
		{

			cartesianChart1.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Canal 1",
					Values = new ChartValues<double> {0}
				}
			};

			cartesianChart1.AxisX.Add(new Axis
			{
				Title = "Time",
				//Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
			});

			cartesianChart1.AxisY.Add(new Axis
			{
				Title = "Volts",
				//LabelFormatter = value => value.ToString("C")
			});

			cartesianChart1.LegendLocation = LegendLocation.Right;

			cartesianChart1.DataClick += CartesianChart1OnDataClick;
		}

		private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
		{
			//MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
			Random rnd = new Random();
			double randomval = rnd.Next(1, 13);
			cartesianChart1.Series[0].Values.Add(randomval);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			lenArr++;
			Random rnd = new Random();
			double randomval = rnd.Next(1, 13);
			cartesianChart1.Series[0].Values.Add(randomval);
			if (lenArr > 30)
			{
				cartesianChart1.Series[0].Values.RemoveAt(0);
			}
		}

		private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{
			CanalUno();
		}
	}
}
