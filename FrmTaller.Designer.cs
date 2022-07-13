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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRetirarDinero = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtMontoRetirar = new System.Windows.Forms.TextBox();
            this.txtConsultaDinero = new System.Windows.Forms.TextBox();
            this.TxtMensajeInformativo = new System.Windows.Forms.TextBox();
            this.LblTituloMensaje = new System.Windows.Forms.Label();
            this.BtnArray = new System.Windows.Forms.Button();
            this.TxtResultadoArray = new System.Windows.Forms.TextBox();
            this.TxtResultadoList = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 29);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRetirarDinero
            // 
            this.btnRetirarDinero.Location = new System.Drawing.Point(12, 58);
            this.btnRetirarDinero.Name = "btnRetirarDinero";
            this.btnRetirarDinero.Size = new System.Drawing.Size(90, 23);
            this.btnRetirarDinero.TabIndex = 1;
            this.btnRetirarDinero.Text = "RetirarDinero";
            this.btnRetirarDinero.UseVisualStyleBackColor = true;
            this.btnRetirarDinero.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 202);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(17, 15);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "**";
            // 
            // txtMontoRetirar
            // 
            this.txtMontoRetirar.Location = new System.Drawing.Point(108, 58);
            this.txtMontoRetirar.Name = "txtMontoRetirar";
            this.txtMontoRetirar.Size = new System.Drawing.Size(100, 23);
            this.txtMontoRetirar.TabIndex = 3;
            this.txtMontoRetirar.Text = "0";
            // 
            // txtConsultaDinero
            // 
            this.txtConsultaDinero.Location = new System.Drawing.Point(108, 29);
            this.txtConsultaDinero.Name = "txtConsultaDinero";
            this.txtConsultaDinero.ReadOnly = true;
            this.txtConsultaDinero.Size = new System.Drawing.Size(100, 23);
            this.txtConsultaDinero.TabIndex = 4;
            this.txtConsultaDinero.Text = "0";
            // 
            // TxtMensajeInformativo
            // 
            this.TxtMensajeInformativo.Location = new System.Drawing.Point(12, 122);
            this.TxtMensajeInformativo.Multiline = true;
            this.TxtMensajeInformativo.Name = "TxtMensajeInformativo";
            this.TxtMensajeInformativo.Size = new System.Drawing.Size(399, 62);
            this.TxtMensajeInformativo.TabIndex = 5;
            this.TxtMensajeInformativo.Text = "BIP BOP, ";
            // 
            // LblTituloMensaje
            // 
            this.LblTituloMensaje.AutoSize = true;
            this.LblTituloMensaje.Location = new System.Drawing.Point(12, 102);
            this.LblTituloMensaje.Name = "LblTituloMensaje";
            this.LblTituloMensaje.Size = new System.Drawing.Size(91, 15);
            this.LblTituloMensaje.TabIndex = 6;
            this.LblTituloMensaje.Text = "Mensaje Cajero:";
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(13, 220);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(90, 23);
            this.BtnArray.TabIndex = 7;
            this.BtnArray.Text = "Ejemplo Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // TxtResultadoArray
            // 
            this.TxtResultadoArray.Location = new System.Drawing.Point(109, 220);
            this.TxtResultadoArray.Multiline = true;
            this.TxtResultadoArray.Name = "TxtResultadoArray";
            this.TxtResultadoArray.Size = new System.Drawing.Size(302, 23);
            this.TxtResultadoArray.TabIndex = 8;
            // 
            // TxtResultadoList
            // 
            this.TxtResultadoList.Location = new System.Drawing.Point(109, 258);
            this.TxtResultadoList.Multiline = true;
            this.TxtResultadoList.Name = "TxtResultadoList";
            this.TxtResultadoList.Size = new System.Drawing.Size(302, 23);
            this.TxtResultadoList.TabIndex = 10;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(13, 258);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(90, 23);
            this.BtnList.TabIndex = 9;
            this.BtnList.Text = "Ejemplo List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // FrmTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 358);
            this.Controls.Add(this.TxtResultadoList);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtResultadoArray);
            this.Controls.Add(this.BtnArray);
            this.Controls.Add(this.LblTituloMensaje);
            this.Controls.Add(this.TxtMensajeInformativo);
            this.Controls.Add(this.txtConsultaDinero);
            this.Controls.Add(this.txtMontoRetirar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRetirarDinero);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FrmTaller";
            this.Text = "Cajero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRetirarDinero;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtMontoRetirar;
        private System.Windows.Forms.TextBox txtConsultaDinero;
        private System.Windows.Forms.TextBox TxtMensajeInformativo;
        private System.Windows.Forms.Label LblTituloMensaje;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.TextBox TxtResultadoArray;
        private System.Windows.Forms.TextBox TxtResultadoList;
        private System.Windows.Forms.Button BtnList;
    }
}