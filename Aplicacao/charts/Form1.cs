using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charts
{
	public partial class Form1 : Form
	{
        readonly Random Randomizador = new Random();
        readonly bool[] appearance = { false, false };
        readonly uint[] uintValoresXY = { 1, 1 };

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (byte j = 0; j < 8; j++)
			{
				chart1.Series["Series" + uintValoresXY[0].ToString()].Points.AddXY(j, 2 ^ j);
			}

			CbbTipo.Items.Add("Splines");
			CbbTipo.Items.Add("Columnas");
			CbbTipo.Items.Add("Área");
			CbbTipo.Items.Add("Donas");
			CbbTipo.Items.Add("Radar");
			CbbTipo.Items.Add("Piramide");

            label5.Visible = false;
            BtnAreasMenos.Visible = false;
			BtnAreasMais.Visible = false;

            CbbTipo.SelectedIndex = 1;
		}

		private void BtnMostrarTitulo_Click(object sender, EventArgs e)
		{
			appearance[0] = !appearance[0];
			chart1.Titles["Title1"].Visible = appearance[0];
			if (appearance[0])
				BtnMostrarTitulo.Text = "Ocultar";
			else
				BtnMostrarTitulo.Text = "Mostrar";
		}

		private void BtnMostarLeyendas_Click(object sender, EventArgs e)
		{
			appearance[1] = !appearance[1];
			chart1.Legends["Legend1"].Enabled = appearance[1];
			if (appearance[1])
				BtnMostarLeyendas.Text = "Ocultar";
			else
				BtnMostarLeyendas.Text = "Mostrar";
		}

		private void CbbTipo_SelectedIndexChanged(object sender, EventArgs e)
		{
			for (uint i = 1; i <= uintValoresXY[0]; i++)
			{
				switch (CbbTipo.SelectedIndex)
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

		private void BtnCambiar_Click(object sender, EventArgs e)
		{
			for (uint i = 1; i <= uintValoresXY[0]; i++)
			{
				chart1.Series["Series" + i.ToString()].Points.Clear();
				for (byte j = 0; j < 8; j++)
					chart1.Series["Series" + i.ToString()].Points.AddXY(j, Randomizador.Next(16));
			}
		}

		private void BtnDatosMenos_Click(object sender, EventArgs e)
		{
			if (uintValoresXY[0] > 0)
			{
				chart1.Series.Remove(chart1.Series["Series" + uintValoresXY[0].ToString()]);
				uintValoresXY[0]--;
			}
		}

		private void BtnDatosMais_Click(object sender, EventArgs e)
		{
			uintValoresXY[0]++;
			chart1.Series.Add("Series" + uintValoresXY[0].ToString());
			chart1.Series["Series" + uintValoresXY[0].ToString()].ChartArea = "ChartArea" + uintValoresXY[1].ToString();
			chart1.Series["Series" + uintValoresXY[0].ToString()].Points.AddXY(0, 0);
		}

		private void BtnAreasMenos_Click(object sender, EventArgs e)
		{
			if (uintValoresXY[1] > 0)
			{
				chart1.ChartAreas.Remove(chart1.ChartAreas["ChartArea" + uintValoresXY[1].ToString()]);
				uintValoresXY[1]--;
			}
		}

		private void BtnAreasMais_Click(object sender, EventArgs e)
		{
			uintValoresXY[1]++;
			chart1.ChartAreas.Add("ChartArea" + uintValoresXY[1].ToString());
			chart1.ChartAreas["ChartArea" + uintValoresXY[1].ToString()].BackColor = System.Drawing.Color.Transparent;
			chart1.ChartAreas["ChartArea" + uintValoresXY[1].ToString()].AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
			chart1.ChartAreas["ChartArea" + uintValoresXY[1].ToString()].AxisX.LineColor = System.Drawing.Color.White;
			chart1.ChartAreas["ChartArea" + uintValoresXY[1].ToString()].AxisX.MajorGrid.Enabled = false;
			chart1.ChartAreas["ChartArea" + uintValoresXY[1].ToString()].AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
			chart1.ChartAreas["ChartArea" + uintValoresXY[1].ToString()].AxisY.LineColor = System.Drawing.Color.White;
			chart1.ChartAreas["ChartArea" + uintValoresXY[1].ToString()].AxisY.MajorGrid.Enabled = false;
		}
	}
}
