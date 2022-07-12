namespace TallerGrupoMongeUNI
{
    partial class FrmTaller
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
            this.btnListas = new System.Windows.Forms.Button();
            this.btnVariable = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListas
            // 
            this.btnListas.Location = new System.Drawing.Point(138, 42);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(75, 23);
            this.btnListas.TabIndex = 0;
            this.btnListas.Text = "Listas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnVariable
            // 
            this.btnVariable.Location = new System.Drawing.Point(42, 42);
            this.btnVariable.Name = "btnVariable";
            this.btnVariable.Size = new System.Drawing.Size(75, 23);
            this.btnVariable.TabIndex = 1;
            this.btnVariable.Text = "Variables";
            this.btnVariable.UseVisualStyleBackColor = true;
            this.btnVariable.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(26, 308);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 2;
            // 
            // FrmTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 347);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnVariable);
            this.Controls.Add(this.btnListas);
            this.Name = "FrmTaller";
            this.Text = "FrmTaller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button btnVariable;
        private System.Windows.Forms.Label lblError;
    }
}