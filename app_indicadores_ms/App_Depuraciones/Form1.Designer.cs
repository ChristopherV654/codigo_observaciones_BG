namespace App_Depuraciones_MS_BG
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
            this.btnMSBG = new System.Windows.Forms.Button();
            this.pbAvance = new System.Windows.Forms.ProgressBar();
            this.lblprogreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMSBG
            // 
            this.btnMSBG.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMSBG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMSBG.Location = new System.Drawing.Point(42, 31);
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
            this.pbAvance.Size = new System.Drawing.Size(231, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(307, 158);
            this.Controls.Add(this.btnMSBG);
            this.Controls.Add(this.lblprogreso);
            this.Controls.Add(this.pbAvance);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Proceso cambios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMSBG;
        private System.Windows.Forms.ProgressBar pbAvance;
        private System.Windows.Forms.Label lblprogreso;
    }
}

