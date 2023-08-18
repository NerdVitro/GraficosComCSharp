using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charts
{
	public partial class Form1 : Form
	{
		Random rnd = new Random();
		bool[] appearance = { false, false };
		uint[] c = { 1, 1 };

		public Form1()
		{
			InitializeComponent();
		}

		private void F1Load(object sender, EventArgs e)
		{
			for (byte j = 0; j < 8; j++)
				chart1.Series["Series" + c[0].ToString()].Points.AddXY(j, 2 ^ j);
			groupBox1.Text = "Apariencia";
			label1.Text = "Título";
			button1.Text = "Mostrar";
			label2.Text = "Leyendas";
			button2.Text = "Mostrar";
			label3.Text = "Tipo";
			comboBox1.Items.Add("Splines");
			comboBox1.Items.Add("Columnas");
			comboBox1.Items.Add("Área");
			comboBox1.Items.Add("Donas");
			comboBox1.Items.Add("Radar");
			comboBox1.Items.Add("Piramide");
			groupBox2.Text = "Datos";
			label4.Text = "Series";
			button3.Text = "Cambiar";
			label5.Text = "Áreas";
			button4.Text = "-";
			button5.Text = "+";
			button6.Text = "-";
			button7.Text = "+";
		}

		private void B1C(object sender, EventArgs e)
		{
			appearance[0] = !appearance[0];
			chart1.Titles["Title1"].Visible = appearance[0];
			if (appearance[0])
				button1.Text = "Ocultar";
			else
				button1.Text = "Mostrar";
		}

		private void B2C(object sender, EventArgs e)
		{
			appearance[1] = !appearance[1];
			chart1.Legends["Legend1"].Enabled = appearance[1];
			if (appearance[1])
				button2.Text = "Ocultar";
			else
				button2.Text = "Mostrar";
		}

		private void CB1SIC(object sender, EventArgs e)
		{
			for (uint i = 1; i <= c[0]; i++)
			{
				switch (comboBox1.SelectedIndex)
				{
					case 0:
						chart1.Series["Series" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
						break;
					case 1:
						chart1.Series["Series" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
						break;
					case 2:
						chart1.Series["Series" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
						break;
					case 3:
						chart1.Series["Series" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
						break;
					case 4:
						chart1.Series["Series" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
						break;
					case 5:
						chart1.Series["Series" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
						break;
					default:
						chart1.Series["Series" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
						break;
				}
			}
		}

		private void B3C(object sender, EventArgs e)
		{
			for (uint i = 1; i <= c[0]; i++)
			{
				chart1.Series["Series" + i.ToString()].Points.Clear();
				for (byte j = 0; j < 8; j++)
					chart1.Series["Series" + i.ToString()].Points.AddXY(j, rnd.Next(16));
			}
		}

		private void B4C(object sender, EventArgs e)
		{
			if (c[0] > 0)
			{
				chart1.Series.Remove(chart1.Series["Series" + c[0].ToString()]);
				c[0]--;
			}
		}

		private void B5C(object sender, EventArgs e)
		{
			c[0]++;
			chart1.Series.Add("Series" + c[0].ToString());
			chart1.Series["Series" + c[0].ToString()].ChartArea = "ChartArea" + c[1].ToString();
			chart1.Series["Series" + c[0].ToString()].Points.AddXY(0, 0);
		}

		private void B6C(object sender, EventArgs e)
		{
			if (c[1] > 0)
			{
				chart1.ChartAreas.Remove(chart1.ChartAreas["ChartArea" + c[1].ToString()]);
				c[1]--;
			}
		}

		private void B7C(object sender, EventArgs e)
		{
			c[1]++;
			chart1.ChartAreas.Add("ChartArea" + c[1].ToString());
			chart1.ChartAreas["ChartArea" + c[1].ToString()].BackColor = System.Drawing.Color.Transparent;
			chart1.ChartAreas["ChartArea" + c[1].ToString()].AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
			chart1.ChartAreas["ChartArea" + c[1].ToString()].AxisX.LineColor = System.Drawing.Color.White;
			chart1.ChartAreas["ChartArea" + c[1].ToString()].AxisX.MajorGrid.Enabled = false;
			chart1.ChartAreas["ChartArea" + c[1].ToString()].AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
			chart1.ChartAreas["ChartArea" + c[1].ToString()].AxisY.LineColor = System.Drawing.Color.White;
			chart1.ChartAreas["ChartArea" + c[1].ToString()].AxisY.MajorGrid.Enabled = false;
		}
	}
}
