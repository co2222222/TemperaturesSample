namespace TemperaturesSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSamples = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSamples
            // 
            this.txtSamples.Location = new System.Drawing.Point(21, 51);
            this.txtSamples.Multiline = true;
            this.txtSamples.Name = "txtSamples";
            this.txtSamples.Size = new System.Drawing.Size(316, 178);
            this.txtSamples.TabIndex = 0;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(452, 59);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(78, 20);
            this.txtFahrenheit.TabIndex = 1;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(452, 88);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(78, 20);
            this.txtCelsius.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sample conversions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please type a temperature to convert:";
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(536, 59);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(36, 20);
            this.btnFtoC.TabIndex = 7;
            this.btnFtoC.Text = ">";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(536, 88);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(36, 20);
            this.btnCtoF.TabIndex = 8;
            this.btnCtoF.Text = ">";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "SampleClass";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.btnFtoC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtSamples);
            this.Name = "Form1";
            this.Text = "Temperature Conversions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSamples;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Button button1;
    }
}

