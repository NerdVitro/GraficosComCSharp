namespace charts
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnMostrarTitulo = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBoxApariencia = new System.Windows.Forms.GroupBox();
            this.CbbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMostarLeyendas = new System.Windows.Forms.Button();
            this.GroupBoxDatos = new System.Windows.Forms.GroupBox();
            this.BtnDatosMenos = new System.Windows.Forms.Button();
            this.BtnDatosMais = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAreasMais = new System.Windows.Forms.Button();
            this.BtnAreasMenos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.GroupBoxApariencia.SuspendLayout();
            this.GroupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMostrarTitulo
            // 
            this.BtnMostrarTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMostrarTitulo.Location = new System.Drawing.Point(8, 50);
            this.BtnMostrarTitulo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BtnMostrarTitulo.Name = "BtnMostrarTitulo";
            this.BtnMostrarTitulo.Size = new System.Drawing.Size(99, 32);
            this.BtnMostrarTitulo.TabIndex = 1;
            this.BtnMostrarTitulo.Text = "Mostrar";
            this.BtnMostrarTitulo.UseVisualStyleBackColor = true;
            this.BtnMostrarTitulo.Click += new System.EventHandler(this.BtnMostrarTitulo_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(17, 17);
            this.chart1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(564, 407);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title2.ForeColor = System.Drawing.Color.WhiteSmoke;
            title2.Name = "Title1";
            title2.Text = "Graficas";
            title2.Visible = false;
            this.chart1.Titles.Add(title2);
            // 
            // GroupBoxApariencia
            // 
            this.GroupBoxApariencia.Controls.Add(this.CbbTipo);
            this.GroupBoxApariencia.Controls.Add(this.label2);
            this.GroupBoxApariencia.Controls.Add(this.label3);
            this.GroupBoxApariencia.Controls.Add(this.label1);
            this.GroupBoxApariencia.Controls.Add(this.BtnMostarLeyendas);
            this.GroupBoxApariencia.Controls.Add(this.BtnMostrarTitulo);
            this.GroupBoxApariencia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBoxApariencia.Location = new System.Drawing.Point(588, 17);
            this.GroupBoxApariencia.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.GroupBoxApariencia.Name = "GroupBoxApariencia";
            this.GroupBoxApariencia.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.GroupBoxApariencia.Size = new System.Drawing.Size(118, 212);
            this.GroupBoxApariencia.TabIndex = 3;
            this.GroupBoxApariencia.TabStop = false;
            this.GroupBoxApariencia.Text = "Apariencia";
            // 
            // CbbTipo
            // 
            this.CbbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbTipo.FormattingEnabled = true;
            this.CbbTipo.Location = new System.Drawing.Point(9, 168);
            this.CbbTipo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.CbbTipo.Name = "CbbTipo";
            this.CbbTipo.Size = new System.Drawing.Size(97, 24);
            this.CbbTipo.TabIndex = 9;
            this.CbbTipo.SelectedIndexChanged += new System.EventHandler(this.CbbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leyendas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Título";
            // 
            // BtnMostarLeyendas
            // 
            this.BtnMostarLeyendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostarLeyendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostarLeyendas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMostarLeyendas.Location = new System.Drawing.Point(8, 108);
            this.BtnMostarLeyendas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BtnMostarLeyendas.Name = "BtnMostarLeyendas";
            this.BtnMostarLeyendas.Size = new System.Drawing.Size(99, 32);
            this.BtnMostarLeyendas.TabIndex = 2;
            this.BtnMostarLeyendas.Text = "Mostrar";
            this.BtnMostarLeyendas.UseVisualStyleBackColor = true;
            this.BtnMostarLeyendas.Click += new System.EventHandler(this.BtnMostarLeyendas_Click);
            // 
            // GroupBoxDatos
            // 
            this.GroupBoxDatos.Controls.Add(this.BtnAreasMenos);
            this.GroupBoxDatos.Controls.Add(this.BtnAreasMais);
            this.GroupBoxDatos.Controls.Add(this.BtnDatosMenos);
            this.GroupBoxDatos.Controls.Add(this.BtnDatosMais);
            this.GroupBoxDatos.Controls.Add(this.label5);
            this.GroupBoxDatos.Controls.Add(this.label4);
            this.GroupBoxDatos.Controls.Add(this.BtnCambiar);
            this.GroupBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBoxDatos.Location = new System.Drawing.Point(588, 238);
            this.GroupBoxDatos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.GroupBoxDatos.Name = "GroupBoxDatos";
            this.GroupBoxDatos.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.GroupBoxDatos.Size = new System.Drawing.Size(118, 186);
            this.GroupBoxDatos.TabIndex = 4;
            this.GroupBoxDatos.TabStop = false;
            this.GroupBoxDatos.Text = "Datos";
            // 
            // BtnDatosMenos
            // 
            this.BtnDatosMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDatosMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDatosMenos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDatosMenos.Location = new System.Drawing.Point(8, 84);
            this.BtnDatosMenos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BtnDatosMenos.Name = "BtnDatosMenos";
            this.BtnDatosMenos.Size = new System.Drawing.Size(48, 32);
            this.BtnDatosMenos.TabIndex = 11;
            this.BtnDatosMenos.Text = "-";
            this.BtnDatosMenos.UseVisualStyleBackColor = true;
            this.BtnDatosMenos.Click += new System.EventHandler(this.BtnDatosMenos_Click);
            // 
            // BtnDatosMais
            // 
            this.BtnDatosMais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDatosMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDatosMais.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDatosMais.Location = new System.Drawing.Point(65, 84);
            this.BtnDatosMais.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BtnDatosMais.Name = "BtnDatosMais";
            this.BtnDatosMais.Size = new System.Drawing.Size(42, 32);
            this.BtnDatosMais.TabIndex = 10;
            this.BtnDatosMais.Text = "+";
            this.BtnDatosMais.UseVisualStyleBackColor = true;
            this.BtnDatosMais.Click += new System.EventHandler(this.BtnDatosMais_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Series";
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCambiar.Location = new System.Drawing.Point(8, 44);
            this.BtnCambiar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(99, 32);
            this.BtnCambiar.TabIndex = 6;
            this.BtnCambiar.Text = "Cambiar";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Áreas";
            // 
            // BtnAreasMais
            // 
            this.BtnAreasMais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAreasMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAreasMais.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAreasMais.Location = new System.Drawing.Point(65, 144);
            this.BtnAreasMais.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BtnAreasMais.Name = "BtnAreasMais";
            this.BtnAreasMais.Size = new System.Drawing.Size(42, 32);
            this.BtnAreasMais.TabIndex = 12;
            this.BtnAreasMais.Text = "+";
            this.BtnAreasMais.UseVisualStyleBackColor = true;
            this.BtnAreasMais.Click += new System.EventHandler(this.BtnAreasMais_Click);
            // 
            // BtnAreasMenos
            // 
            this.BtnAreasMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAreasMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAreasMenos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAreasMenos.Location = new System.Drawing.Point(8, 144);
            this.BtnAreasMenos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BtnAreasMenos.Name = "BtnAreasMenos";
            this.BtnAreasMenos.Size = new System.Drawing.Size(48, 32);
            this.BtnAreasMenos.TabIndex = 13;
            this.BtnAreasMenos.Text = "-";
            this.BtnAreasMenos.UseVisualStyleBackColor = true;
            this.BtnAreasMenos.Click += new System.EventHandler(this.BtnAreasMenos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(721, 436);
            this.Controls.Add(this.GroupBoxDatos);
            this.Controls.Add(this.GroupBoxApariencia);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MinimumSize = new System.Drawing.Size(737, 475);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficos em C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.GroupBoxApariencia.ResumeLayout(false);
            this.GroupBoxApariencia.PerformLayout();
            this.GroupBoxDatos.ResumeLayout(false);
            this.GroupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button BtnMostrarTitulo;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.GroupBox GroupBoxApariencia;
		private System.Windows.Forms.Button BtnMostarLeyendas;
		private System.Windows.Forms.GroupBox GroupBoxDatos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BtnCambiar;
		private System.Windows.Forms.ComboBox CbbTipo;
		private System.Windows.Forms.Button BtnDatosMenos;
		private System.Windows.Forms.Button BtnDatosMais;
        private System.Windows.Forms.Button BtnAreasMenos;
        private System.Windows.Forms.Button BtnAreasMais;
        private System.Windows.Forms.Label label5;
    }
}

