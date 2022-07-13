using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TallerGrupoMongeUNI
{
    public partial class FrmTaller : Form
    {

        public LogicaNegocio.Cajero _objVariable = new LogicaNegocio.Cajero();

        private string _logErrores = string.Empty;

        public FrmTaller()
        {
            InitializeComponent();
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    var pruebaError = 0;
                    var resultadoOperacion = 5 / pruebaError;
                }
                catch (DivideByZeroException ex)
                {
                    _logErrores = _logErrores + "/ " + ex.Message;
                    lblError.Text = _logErrores;
                }
                var dineroRetirar = Convert.ToDecimal(txtMontoRetirar.Text);
                var referencia = string.Empty;
                var resultadoDinero = _objVariable.RetirarDinero(dineroRetirar, ref referencia);
                TxtMensajeInformativo.Text = referencia;
                RefrescarSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw ex;
            }


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                RefrescarSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefrescarSaldo()
        {
            txtConsultaDinero.Text = _objVariable.DineroActual.ToString();
        }


    }
}
