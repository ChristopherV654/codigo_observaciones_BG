namespace App_Depuraciones
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
            this.btnhonda = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnkia = new System.Windows.Forms.Button();
            this.btnMSBG = new System.Windows.Forms.Button();
            this.pbAvance = new System.Windows.Forms.ProgressBar();
            this.lblprogreso = new System.Windows.Forms.Label();
            this.buttonQMotors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhonda
            // 
            this.btnhonda.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnhonda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhonda.Location = new System.Drawing.Point(189, 38);
            this.btnhonda.Name = "btnhonda";
            this.btnhonda.Size = new System.Drawing.Size(163, 36);
            this.btnhonda.TabIndex = 1;
            this.btnhonda.Text = "Actualizar Información Honda";
            this.btnhonda.UseVisualStyleBackColor = false;
            this.btnhonda.Click += new System.EventHandler(this.btnhonda_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(367, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Actualizar Información Hyudai";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnHyundai_Click);
            // 
            // btnkia
            // 
            this.btnkia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnkia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkia.Location = new System.Drawing.Point(42, 38);
            this.btnkia.Name = "btnkia";
            this.btnkia.Size = new System.Drawing.Size(141, 36);
            this.btnkia.TabIndex = 3;
            this.btnkia.Text = "Actualizar Información KIA";
            this.btnkia.UseVisualStyleBackColor = false;
            this.btnkia.Click += new System.EventHandler(this.btnkia_Click);
            // 
            // btnMSBG
            // 
            this.btnMSBG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMSBG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMSBG.Location = new System.Drawing.Point(547, 38);
            this.btnMSBG.Name = "btnMSBG";
            this.btnMSBG.Size = new System.Drawing.Size(231, 36);
            this.btnMSBG.TabIndex = 4;
            this.btnMSBG.Text = "Actualizar Información MS Banco Guayaquil";
            this.btnMSBG.UseVisualStyleBackColor = false;
            this.btnMSBG.Click += new System.EventHandler(this.btnMSBG_Click);
            // 
            // pbAvance
            // 
            this.pbAvance.Location = new System.Drawing.Point(42, 95);
            this.pbAvance.Name = "pbAvance";
            this.pbAvance.Size = new System.Drawing.Size(943, 23);
            this.pbAvance.TabIndex = 5;
            // 
            // lblprogreso
            // 
            this.lblprogreso.AutoSize = true;
            this.lblprogreso.Location = new System.Drawing.Point(39, 124);
            this.lblprogreso.Name = "lblprogreso";
            this.lblprogreso.Size = new System.Drawing.Size(69, 13);
            this.lblprogreso.TabIndex = 6;
            this.lblprogreso.Text = "Progreso 0/0";
            // 
            // buttonQMotors
            // 
            this.buttonQMotors.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonQMotors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonQMotors.Location = new System.Drawing.Point(801, 38);
            this.buttonQMotors.Name = "buttonQMotors";
            this.buttonQMotors.Size = new System.Drawing.Size(184, 36);
            this.buttonQMotors.TabIndex = 7;
            this.buttonQMotors.Text = "Actualizar Información Quito Motors";
            this.buttonQMotors.UseVisualStyleBackColor = false;
            this.buttonQMotors.Click += new System.EventHandler(this.buttonQMotors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1023, 147);
            this.Controls.Add(this.buttonQMotors);
            this.Controls.Add(this.btnMSBG);
            this.Controls.Add(this.lblprogreso);
            this.Controls.Add(this.pbAvance);
            this.Controls.Add(this.btnkia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnhonda);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Proceso cambios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnhonda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnkia;
        private System.Windows.Forms.Button btnMSBG;
        private System.Windows.Forms.ProgressBar pbAvance;
        private System.Windows.Forms.Label lblprogreso;
        private System.Windows.Forms.Button buttonQMotors;
    }
}

