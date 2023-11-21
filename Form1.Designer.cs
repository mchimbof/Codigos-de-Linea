
namespace Code_Linea
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grafico_linea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblcodigo_linea = new System.Windows.Forms.Label();
            this.rbt_polarz = new System.Windows.Forms.RadioButton();
            this.rbtn_bipolar = new System.Windows.Forms.RadioButton();
            this.rbtn_aminrz = new System.Windows.Forms.RadioButton();
            this.rbtn_aminrzinv = new System.Windows.Forms.RadioButton();
            this.rbtn_manchesterdiferencial = new System.Windows.Forms.RadioButton();
            this.rbtn_amirz = new System.Windows.Forms.RadioButton();
            this.rbtn_amirzinv = new System.Windows.Forms.RadioButton();
            this.rbtn_unipolarz = new System.Windows.Forms.RadioButton();
            this.rbtn_manchester = new System.Windows.Forms.RadioButton();
            this.rbtn_cmi = new System.Windows.Forms.RadioButton();
            this.rbtn_diferencial = new System.Windows.Forms.RadioButton();
            this.rbtn_miller = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_linea)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(91, 28);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(132, 21);
            this.txtcodigo.TabIndex = 1;
            // 
            // grafico
            // 
            this.grafico.BorderlineColor = System.Drawing.Color.Gray;
            this.grafico.BorderSkin.BorderWidth = 2;
            chartArea13.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.grafico.Legends.Add(legend13);
            this.grafico.Location = new System.Drawing.Point(1, 146);
            this.grafico.Name = "grafico";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.MidnightBlue;
            series13.IsVisibleInLegend = false;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.grafico.Series.Add(series13);
            this.grafico.Size = new System.Drawing.Size(805, 182);
            this.grafico.TabIndex = 2;
            this.grafico.Text = "chart1";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(40, 122);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(83, 17);
            this.lblcodigo.TabIndex = 3;
            this.lblcodigo.Text = "Codigo: N/A";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(91, 55);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(132, 23);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo:";
            // 
            // grafico_linea
            // 
            this.grafico_linea.BorderlineColor = System.Drawing.Color.Gray;
            this.grafico_linea.BorderSkin.BorderWidth = 2;
            chartArea14.Name = "ChartArea1";
            this.grafico_linea.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.grafico_linea.Legends.Add(legend14);
            this.grafico_linea.Location = new System.Drawing.Point(1, 368);
            this.grafico_linea.Name = "grafico_linea";
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.MidnightBlue;
            series14.IsVisibleInLegend = false;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.grafico_linea.Series.Add(series14);
            this.grafico_linea.Size = new System.Drawing.Size(805, 223);
            this.grafico_linea.TabIndex = 8;
            this.grafico_linea.Text = "chart1";
            // 
            // lblcodigo_linea
            // 
            this.lblcodigo_linea.AutoSize = true;
            this.lblcodigo_linea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo_linea.Location = new System.Drawing.Point(40, 348);
            this.lblcodigo_linea.Name = "lblcodigo_linea";
            this.lblcodigo_linea.Size = new System.Drawing.Size(142, 17);
            this.lblcodigo_linea.TabIndex = 9;
            this.lblcodigo_linea.Text = "Codigo de Linea: N/A";
            // 
            // rbt_polarz
            // 
            this.rbt_polarz.AutoSize = true;
            this.rbt_polarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_polarz.Location = new System.Drawing.Point(16, 12);
            this.rbt_polarz.Name = "rbt_polarz";
            this.rbt_polarz.Size = new System.Drawing.Size(73, 19);
            this.rbt_polarz.TabIndex = 23;
            this.rbt_polarz.TabStop = true;
            this.rbt_polarz.Text = "Polar RZ";
            this.rbt_polarz.UseVisualStyleBackColor = true;
            this.rbt_polarz.CheckedChanged += new System.EventHandler(this.rbt_polarz_CheckedChanged);
            // 
            // rbtn_bipolar
            // 
            this.rbtn_bipolar.AutoSize = true;
            this.rbtn_bipolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_bipolar.Location = new System.Drawing.Point(16, 35);
            this.rbtn_bipolar.Name = "rbtn_bipolar";
            this.rbtn_bipolar.Size = new System.Drawing.Size(83, 19);
            this.rbtn_bipolar.TabIndex = 24;
            this.rbtn_bipolar.TabStop = true;
            this.rbtn_bipolar.Text = "Bipolar RZ";
            this.rbtn_bipolar.UseVisualStyleBackColor = true;
            this.rbtn_bipolar.CheckedChanged += new System.EventHandler(this.rbtn_bipolar_CheckedChanged);
            // 
            // rbtn_aminrz
            // 
            this.rbtn_aminrz.AutoSize = true;
            this.rbtn_aminrz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_aminrz.Location = new System.Drawing.Point(121, 12);
            this.rbtn_aminrz.Name = "rbtn_aminrz";
            this.rbtn_aminrz.Size = new System.Drawing.Size(74, 19);
            this.rbtn_aminrz.TabIndex = 25;
            this.rbtn_aminrz.TabStop = true;
            this.rbtn_aminrz.Text = "Ami NRZ";
            this.rbtn_aminrz.UseVisualStyleBackColor = true;
            this.rbtn_aminrz.CheckedChanged += new System.EventHandler(this.rbtn_aminrz_CheckedChanged);
            // 
            // rbtn_aminrzinv
            // 
            this.rbtn_aminrzinv.AutoSize = true;
            this.rbtn_aminrzinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_aminrzinv.Location = new System.Drawing.Point(121, 37);
            this.rbtn_aminrzinv.Name = "rbtn_aminrzinv";
            this.rbtn_aminrzinv.Size = new System.Drawing.Size(92, 19);
            this.rbtn_aminrzinv.TabIndex = 26;
            this.rbtn_aminrzinv.TabStop = true;
            this.rbtn_aminrzinv.Text = "Ami NRZ Inv";
            this.rbtn_aminrzinv.UseVisualStyleBackColor = true;
            this.rbtn_aminrzinv.CheckedChanged += new System.EventHandler(this.rbtn_aminrzinv_CheckedChanged);
            // 
            // rbtn_manchesterdiferencial
            // 
            this.rbtn_manchesterdiferencial.AutoSize = true;
            this.rbtn_manchesterdiferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_manchesterdiferencial.Location = new System.Drawing.Point(121, 81);
            this.rbtn_manchesterdiferencial.Name = "rbtn_manchesterdiferencial";
            this.rbtn_manchesterdiferencial.Size = new System.Drawing.Size(152, 19);
            this.rbtn_manchesterdiferencial.TabIndex = 27;
            this.rbtn_manchesterdiferencial.TabStop = true;
            this.rbtn_manchesterdiferencial.Text = "Manchester Diferencial";
            this.rbtn_manchesterdiferencial.UseVisualStyleBackColor = true;
            this.rbtn_manchesterdiferencial.CheckedChanged += new System.EventHandler(this.rbtn_manchesterdiferencial_CheckedChanged);
            // 
            // rbtn_amirz
            // 
            this.rbtn_amirz.AutoSize = true;
            this.rbtn_amirz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_amirz.Location = new System.Drawing.Point(16, 58);
            this.rbtn_amirz.Name = "rbtn_amirz";
            this.rbtn_amirz.Size = new System.Drawing.Size(65, 19);
            this.rbtn_amirz.TabIndex = 28;
            this.rbtn_amirz.TabStop = true;
            this.rbtn_amirz.Text = "Ami RZ";
            this.rbtn_amirz.UseVisualStyleBackColor = true;
            this.rbtn_amirz.CheckedChanged += new System.EventHandler(this.rbtn_amirz_CheckedChanged);
            // 
            // rbtn_amirzinv
            // 
            this.rbtn_amirzinv.AutoSize = true;
            this.rbtn_amirzinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_amirzinv.Location = new System.Drawing.Point(16, 80);
            this.rbtn_amirzinv.Name = "rbtn_amirzinv";
            this.rbtn_amirzinv.Size = new System.Drawing.Size(83, 19);
            this.rbtn_amirzinv.TabIndex = 29;
            this.rbtn_amirzinv.TabStop = true;
            this.rbtn_amirzinv.Text = "Ami RZ Inv";
            this.rbtn_amirzinv.UseVisualStyleBackColor = true;
            this.rbtn_amirzinv.CheckedChanged += new System.EventHandler(this.rbtn_amirzinv_CheckedChanged);
            // 
            // rbtn_unipolarz
            // 
            this.rbtn_unipolarz.AutoSize = true;
            this.rbtn_unipolarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_unipolarz.Location = new System.Drawing.Point(292, 35);
            this.rbtn_unipolarz.Name = "rbtn_unipolarz";
            this.rbtn_unipolarz.Size = new System.Drawing.Size(91, 19);
            this.rbtn_unipolarz.TabIndex = 30;
            this.rbtn_unipolarz.TabStop = true;
            this.rbtn_unipolarz.Text = "Unipolar RZ";
            this.rbtn_unipolarz.UseVisualStyleBackColor = true;
            this.rbtn_unipolarz.CheckedChanged += new System.EventHandler(this.rbtn_unipolarz_CheckedChanged);
            // 
            // rbtn_manchester
            // 
            this.rbtn_manchester.AutoSize = true;
            this.rbtn_manchester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_manchester.Location = new System.Drawing.Point(121, 58);
            this.rbtn_manchester.Name = "rbtn_manchester";
            this.rbtn_manchester.Size = new System.Drawing.Size(90, 19);
            this.rbtn_manchester.TabIndex = 31;
            this.rbtn_manchester.TabStop = true;
            this.rbtn_manchester.Text = "Manchester";
            this.rbtn_manchester.UseVisualStyleBackColor = true;
            this.rbtn_manchester.CheckedChanged += new System.EventHandler(this.rbtn_manchester_CheckedChanged);
            // 
            // rbtn_cmi
            // 
            this.rbtn_cmi.AutoSize = true;
            this.rbtn_cmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_cmi.Location = new System.Drawing.Point(292, 12);
            this.rbtn_cmi.Name = "rbtn_cmi";
            this.rbtn_cmi.Size = new System.Drawing.Size(47, 19);
            this.rbtn_cmi.TabIndex = 32;
            this.rbtn_cmi.TabStop = true;
            this.rbtn_cmi.Text = "CMI";
            this.rbtn_cmi.UseVisualStyleBackColor = true;
            this.rbtn_cmi.CheckedChanged += new System.EventHandler(this.rbtn_cmi_CheckedChanged);
            // 
            // rbtn_diferencial
            // 
            this.rbtn_diferencial.AutoSize = true;
            this.rbtn_diferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_diferencial.Location = new System.Drawing.Point(292, 80);
            this.rbtn_diferencial.Name = "rbtn_diferencial";
            this.rbtn_diferencial.Size = new System.Drawing.Size(84, 19);
            this.rbtn_diferencial.TabIndex = 33;
            this.rbtn_diferencial.TabStop = true;
            this.rbtn_diferencial.Text = "Diferencial";
            this.rbtn_diferencial.UseVisualStyleBackColor = true;
            this.rbtn_diferencial.CheckedChanged += new System.EventHandler(this.rbtn_diferencial_CheckedChanged);
            // 
            // rbtn_miller
            // 
            this.rbtn_miller.AutoSize = true;
            this.rbtn_miller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_miller.Location = new System.Drawing.Point(292, 58);
            this.rbtn_miller.Name = "rbtn_miller";
            this.rbtn_miller.Size = new System.Drawing.Size(56, 19);
            this.rbtn_miller.TabIndex = 34;
            this.rbtn_miller.TabStop = true;
            this.rbtn_miller.Text = "Miller";
            this.rbtn_miller.UseVisualStyleBackColor = true;
            this.rbtn_miller.CheckedChanged += new System.EventHandler(this.rbtn_miller_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbt_polarz);
            this.panel1.Controls.Add(this.rbtn_miller);
            this.panel1.Controls.Add(this.rbtn_bipolar);
            this.panel1.Controls.Add(this.rbtn_diferencial);
            this.panel1.Controls.Add(this.rbtn_amirz);
            this.panel1.Controls.Add(this.rbtn_cmi);
            this.panel1.Controls.Add(this.rbtn_amirzinv);
            this.panel1.Controls.Add(this.rbtn_manchesterdiferencial);
            this.panel1.Controls.Add(this.rbtn_manchester);
            this.panel1.Controls.Add(this.rbtn_unipolarz);
            this.panel1.Controls.Add(this.rbtn_aminrz);
            this.panel1.Controls.Add(this.rbtn_aminrzinv);
            this.panel1.Location = new System.Drawing.Point(261, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 110);
            this.panel1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcodigo_linea);
            this.Controls.Add(this.grafico_linea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.txtcodigo);
            this.Name = "Form1";
            this.Text = "Codigo de Linea";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_linea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_linea;
        private System.Windows.Forms.Label lblcodigo_linea;
        private System.Windows.Forms.RadioButton rbt_polarz;
        private System.Windows.Forms.RadioButton rbtn_bipolar;
        private System.Windows.Forms.RadioButton rbtn_aminrz;
        private System.Windows.Forms.RadioButton rbtn_aminrzinv;
        private System.Windows.Forms.RadioButton rbtn_manchesterdiferencial;
        private System.Windows.Forms.RadioButton rbtn_amirz;
        private System.Windows.Forms.RadioButton rbtn_amirzinv;
        private System.Windows.Forms.RadioButton rbtn_unipolarz;
        private System.Windows.Forms.RadioButton rbtn_manchester;
        private System.Windows.Forms.RadioButton rbtn_cmi;
        private System.Windows.Forms.RadioButton rbtn_diferencial;
        private System.Windows.Forms.RadioButton rbtn_miller;
        private System.Windows.Forms.Panel panel1;
    }
}

