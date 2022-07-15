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
            this.GPBXPractica = new System.Windows.Forms.GroupBox();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtPersonas = new System.Windows.Forms.TextBox();
            this.LblApellido2 = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.btnGeneric = new System.Windows.Forms.Button();
            this.btnGenerico = new System.Windows.Forms.Button();
            this.BtnLinkedList = new System.Windows.Forms.Button();
            this.GPBXPractica.SuspendLayout();
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
            this.btnRetirarDinero.Location = new System.Drawing.Point(260, 15);
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
            this.lblError.Location = new System.Drawing.Point(11, 166);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(17, 15);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "**";
            // 
            // txtMontoRetirar
            // 
            this.txtMontoRetirar.Location = new System.Drawing.Point(356, 15);
            this.txtMontoRetirar.Name = "txtMontoRetirar";
            this.txtMontoRetirar.Size = new System.Drawing.Size(100, 23);
            this.txtMontoRetirar.TabIndex = 0;
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
            this.TxtMensajeInformativo.Location = new System.Drawing.Point(11, 86);
            this.TxtMensajeInformativo.Multiline = true;
            this.TxtMensajeInformativo.Name = "TxtMensajeInformativo";
            this.TxtMensajeInformativo.Size = new System.Drawing.Size(399, 62);
            this.TxtMensajeInformativo.TabIndex = 1;
            this.TxtMensajeInformativo.Text = "BIP BOP, ";
            // 
            // LblTituloMensaje
            // 
            this.LblTituloMensaje.AutoSize = true;
            this.LblTituloMensaje.Location = new System.Drawing.Point(11, 66);
            this.LblTituloMensaje.Name = "LblTituloMensaje";
            this.LblTituloMensaje.Size = new System.Drawing.Size(91, 15);
            this.LblTituloMensaje.TabIndex = 6;
            this.LblTituloMensaje.Text = "Mensaje Cajero:";
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(12, 184);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(90, 23);
            this.BtnArray.TabIndex = 7;
            this.BtnArray.Text = "Ejemplo Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // TxtResultadoArray
            // 
            this.TxtResultadoArray.Location = new System.Drawing.Point(108, 184);
            this.TxtResultadoArray.Multiline = true;
            this.TxtResultadoArray.Name = "TxtResultadoArray";
            this.TxtResultadoArray.Size = new System.Drawing.Size(302, 23);
            this.TxtResultadoArray.TabIndex = 2;
            // 
            // TxtResultadoList
            // 
            this.TxtResultadoList.Location = new System.Drawing.Point(108, 222);
            this.TxtResultadoList.Multiline = true;
            this.TxtResultadoList.Name = "TxtResultadoList";
            this.TxtResultadoList.Size = new System.Drawing.Size(302, 23);
            this.TxtResultadoList.TabIndex = 3;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(12, 222);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(90, 23);
            this.BtnList.TabIndex = 9;
            this.BtnList.Text = "Ejemplo List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // GPBXPractica
            // 
            this.GPBXPractica.Controls.Add(this.TxtApellido2);
            this.GPBXPractica.Controls.Add(this.txtApellido1);
            this.GPBXPractica.Controls.Add(this.txtNombre);
            this.GPBXPractica.Controls.Add(this.TxtIdentificacion);
            this.GPBXPractica.Controls.Add(this.TxtPersonas);
            this.GPBXPractica.Controls.Add(this.LblApellido2);
            this.GPBXPractica.Controls.Add(this.LblApellido);
            this.GPBXPractica.Controls.Add(this.LblNombre);
            this.GPBXPractica.Controls.Add(this.txtMontoRetirar);
            this.GPBXPractica.Controls.Add(this.LblIdentificacion);
            this.GPBXPractica.Controls.Add(this.btnRetirarDinero);
            this.GPBXPractica.Location = new System.Drawing.Point(14, 298);
            this.GPBXPractica.Name = "GPBXPractica";
            this.GPBXPractica.Size = new System.Drawing.Size(573, 272);
            this.GPBXPractica.TabIndex = 11;
            this.GPBXPractica.TabStop = false;
            this.GPBXPractica.Text = "Practica # 3";
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Location = new System.Drawing.Point(102, 89);
            this.TxtApellido2.Multiline = true;
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(138, 23);
            this.TxtApellido2.TabIndex = 7;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(102, 64);
            this.txtApellido1.Multiline = true;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(138, 23);
            this.txtApellido1.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 39);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(102, 15);
            this.TxtIdentificacion.Multiline = true;
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(138, 23);
            this.TxtIdentificacion.TabIndex = 4;
            // 
            // TxtPersonas
            // 
            this.TxtPersonas.Location = new System.Drawing.Point(15, 172);
            this.TxtPersonas.Multiline = true;
            this.TxtPersonas.Name = "TxtPersonas";
            this.TxtPersonas.Size = new System.Drawing.Size(561, 136);
            this.TxtPersonas.TabIndex = 8;
            // 
            // LblApellido2
            // 
            this.LblApellido2.AutoSize = true;
            this.LblApellido2.Location = new System.Drawing.Point(33, 97);
            this.LblApellido2.Name = "LblApellido2";
            this.LblApellido2.Size = new System.Drawing.Size(63, 15);
            this.LblApellido2.TabIndex = 3;
            this.LblApellido2.Text = "Apellido 2:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(33, 72);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(63, 15);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido 1:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(42, 47);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(54, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.AutoSize = true;
            this.LblIdentificacion.Location = new System.Drawing.Point(14, 23);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(82, 15);
            this.LblIdentificacion.TabIndex = 0;
            this.LblIdentificacion.Text = "Identificación:";
            // 
            // btnGeneric
            // 
            this.btnGeneric.Location = new System.Drawing.Point(437, 184);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Size = new System.Drawing.Size(120, 23);
            this.btnGeneric.TabIndex = 12;
            this.btnGeneric.Text = "Ejemplo Object";
            this.btnGeneric.UseVisualStyleBackColor = true;
            this.btnGeneric.Click += new System.EventHandler(this.btnGeneric_Click);
            // 
            // btnGenerico
            // 
            this.btnGenerico.Location = new System.Drawing.Point(437, 222);
            this.btnGenerico.Name = "btnGenerico";
            this.btnGenerico.Size = new System.Drawing.Size(120, 23);
            this.btnGenerico.TabIndex = 13;
            this.btnGenerico.Text = "Ejemplo Generic";
            this.btnGenerico.UseVisualStyleBackColor = true;
            this.btnGenerico.Click += new System.EventHandler(this.btnGenerico_Click);
            // 
            // BtnLinkedList
            // 
            this.BtnLinkedList.Location = new System.Drawing.Point(14, 260);
            this.BtnLinkedList.Name = "BtnLinkedList";
            this.BtnLinkedList.Size = new System.Drawing.Size(120, 23);
            this.BtnLinkedList.TabIndex = 14;
            this.BtnLinkedList.Text = "Ejemplo LinkedList";
            this.BtnLinkedList.UseVisualStyleBackColor = true;
            this.BtnLinkedList.Click += new System.EventHandler(this.BtnLinkedList_Click);
            // 
            // FrmTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 591);
            this.Controls.Add(this.BtnLinkedList);
            this.Controls.Add(this.btnGenerico);
            this.Controls.Add(this.btnGeneric);
            this.Controls.Add(this.GPBXPractica);
            this.Controls.Add(this.TxtResultadoList);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtResultadoArray);
            this.Controls.Add(this.BtnArray);
            this.Controls.Add(this.LblTituloMensaje);
            this.Controls.Add(this.TxtMensajeInformativo);
            this.Controls.Add(this.txtConsultaDinero);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FrmTaller";
            this.Text = "Cajero";
            this.GPBXPractica.ResumeLayout(false);
            this.GPBXPractica.PerformLayout();
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
        private System.Windows.Forms.GroupBox GPBXPractica;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtPersonas;
        private System.Windows.Forms.Label LblApellido2;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.Button btnGeneric;
        private System.Windows.Forms.Button btnGenerico;
        private System.Windows.Forms.Button BtnLinkedList;
    }
}