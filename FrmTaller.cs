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

        public LogicaNegocio.Variable objVariable = new LogicaNegocio.Variable();

        private string _logErrores = string.Empty;

        public FrmTaller()
        {
            InitializeComponent();


        }

        private void btnListas_Click(object sender, EventArgs e)
        {

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
                var referencia = "Prueba Referencia ";
                var resultado = objVariable.ObtenerContador(ref referencia);
                MessageBox.Show("Valor de Referencia: " + referencia); 
                MessageBox.Show("Se obtiene contador de clase: " + resultado);
                var resultadoEstatico = LogicaNegocio.VariableEstatica.ObtenerContador();
                MessageBox.Show("Se obtiene contador de clase Estatica: " + resultadoEstatico);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw ex;
            }


        }
    }
}
