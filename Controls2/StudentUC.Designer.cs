namespace Controls2
{
    partial class StudentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noLbl = new System.Windows.Forms.Label();
            this.fullnameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noLbl
            // 
            this.noLbl.AutoSize = true;
            this.noLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLbl.Location = new System.Drawing.Point(81, 47);
            this.noLbl.Name = "noLbl";
            this.noLbl.Size = new System.Drawing.Size(99, 32);
            this.noLbl.TabIndex = 0;
            this.noLbl.Text = "label1";
            this.noLbl.Click += new System.EventHandler(this.noLbl_Click);
            // 
            // fullnameLbl
            // 
            this.fullnameLbl.AutoSize = true;
            this.fullnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLbl.Location = new System.Drawing.Point(233, 47);
            this.fullnameLbl.Name = "fullnameLbl";
            this.fullnameLbl.Size = new System.Drawing.Size(99, 32);
            this.fullnameLbl.TabIndex = 1;
            this.fullnameLbl.Text = "label2";
            this.fullnameLbl.Click += new System.EventHandler(this.fullnameLbl_Click);
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.Location = new System.Drawing.Point(457, 47);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(99, 32);
            this.ageLbl.TabIndex = 2;
            this.ageLbl.Text = "label3";
            this.ageLbl.Click += new System.EventHandler(this.ageLbl_Click);
            // 
            // StudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.fullnameLbl);
            this.Controls.Add(this.noLbl);
            this.Name = "StudentUC";
            this.Size = new System.Drawing.Size(1050, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noLbl;
        private System.Windows.Forms.Label fullnameLbl;
        private System.Windows.Forms.Label ageLbl;
    }
}
