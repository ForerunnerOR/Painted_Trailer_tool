namespace Painted_Trailer_Tool
{
    partial class frmMain
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
            this.lblModName = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.lblExtraOptions = new System.Windows.Forms.Label();
            this.ckbETS1Trailers = new System.Windows.Forms.CheckBox();
            this.ckbSchwTrailers = new System.Windows.Forms.CheckBox();
            this.clrPaintColor = new System.Windows.Forms.ColorDialog();
            this.ckbOverrideTrailer = new System.Windows.Forms.CheckBox();
            this.lblOverrideTrailer = new System.Windows.Forms.Label();
            this.cmbOverrideTrailer = new System.Windows.Forms.ComboBox();
            this.btnBuildMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(12, 9);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(73, 13);
            this.lblModName.TabIndex = 0;
            this.lblModName.Text = "Name of mod:";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(15, 26);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(170, 20);
            this.txtModName.TabIndex = 1;
            // 
            // lblExtraOptions
            // 
            this.lblExtraOptions.AutoSize = true;
            this.lblExtraOptions.Location = new System.Drawing.Point(12, 54);
            this.lblExtraOptions.Name = "lblExtraOptions";
            this.lblExtraOptions.Size = new System.Drawing.Size(73, 13);
            this.lblExtraOptions.TabIndex = 2;
            this.lblExtraOptions.Text = "Extra Options:";
            // 
            // ckbETS1Trailers
            // 
            this.ckbETS1Trailers.AutoSize = true;
            this.ckbETS1Trailers.Location = new System.Drawing.Point(15, 70);
            this.ckbETS1Trailers.Name = "ckbETS1Trailers";
            this.ckbETS1Trailers.Size = new System.Drawing.Size(90, 17);
            this.ckbETS1Trailers.TabIndex = 3;
            this.ckbETS1Trailers.Text = "ETS1 Trailers";
            this.ckbETS1Trailers.UseVisualStyleBackColor = true;
            // 
            // ckbSchwTrailers
            // 
            this.ckbSchwTrailers.AutoSize = true;
            this.ckbSchwTrailers.Location = new System.Drawing.Point(15, 93);
            this.ckbSchwTrailers.Name = "ckbSchwTrailers";
            this.ckbSchwTrailers.Size = new System.Drawing.Size(131, 17);
            this.ckbSchwTrailers.TabIndex = 4;
            this.ckbSchwTrailers.Text = "Schwarzmuller Trailers";
            this.ckbSchwTrailers.UseVisualStyleBackColor = true;
            // 
            // ckbOverrideTrailer
            // 
            this.ckbOverrideTrailer.AutoSize = true;
            this.ckbOverrideTrailer.Location = new System.Drawing.Point(15, 116);
            this.ckbOverrideTrailer.Name = "ckbOverrideTrailer";
            this.ckbOverrideTrailer.Size = new System.Drawing.Size(120, 17);
            this.ckbOverrideTrailer.TabIndex = 5;
            this.ckbOverrideTrailer.Text = "Use Override Trailer";
            this.ckbOverrideTrailer.UseVisualStyleBackColor = true;
            // 
            // lblOverrideTrailer
            // 
            this.lblOverrideTrailer.AutoSize = true;
            this.lblOverrideTrailer.Location = new System.Drawing.Point(12, 146);
            this.lblOverrideTrailer.Name = "lblOverrideTrailer";
            this.lblOverrideTrailer.Size = new System.Drawing.Size(82, 13);
            this.lblOverrideTrailer.TabIndex = 6;
            this.lblOverrideTrailer.Text = "Override Trailer:";
            // 
            // cmbOverrideTrailer
            // 
            this.cmbOverrideTrailer.FormattingEnabled = true;
            this.cmbOverrideTrailer.Location = new System.Drawing.Point(15, 163);
            this.cmbOverrideTrailer.Name = "cmbOverrideTrailer";
            this.cmbOverrideTrailer.Size = new System.Drawing.Size(170, 21);
            this.cmbOverrideTrailer.TabIndex = 7;
            // 
            // btnBuildMod
            // 
            this.btnBuildMod.Location = new System.Drawing.Point(225, 26);
            this.btnBuildMod.Name = "btnBuildMod";
            this.btnBuildMod.Size = new System.Drawing.Size(135, 158);
            this.btnBuildMod.TabIndex = 8;
            this.btnBuildMod.Text = "Build Trailer Mod";
            this.btnBuildMod.UseVisualStyleBackColor = true;
            this.btnBuildMod.Click += new System.EventHandler(this.btnBuildMod_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 196);
            this.Controls.Add(this.btnBuildMod);
            this.Controls.Add(this.cmbOverrideTrailer);
            this.Controls.Add(this.lblOverrideTrailer);
            this.Controls.Add(this.ckbOverrideTrailer);
            this.Controls.Add(this.ckbSchwTrailers);
            this.Controls.Add(this.ckbETS1Trailers);
            this.Controls.Add(this.lblExtraOptions);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.lblModName);
            this.MaximumSize = new System.Drawing.Size(402, 235);
            this.MinimumSize = new System.Drawing.Size(402, 235);
            this.Name = "frmMain";
            this.Text = "Painted Trailer Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label lblExtraOptions;
        private System.Windows.Forms.CheckBox ckbETS1Trailers;
        private System.Windows.Forms.CheckBox ckbSchwTrailers;
        public System.Windows.Forms.ColorDialog clrPaintColor;
        private System.Windows.Forms.CheckBox ckbOverrideTrailer;
        private System.Windows.Forms.Label lblOverrideTrailer;
        private System.Windows.Forms.ComboBox cmbOverrideTrailer;
        private System.Windows.Forms.Button btnBuildMod;
    }
}

