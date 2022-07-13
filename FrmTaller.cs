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

        private const string SEPARADOR = "--";

        private List<Modelo.Persona> personas = new List<Modelo.Persona>();

        public FrmTaller()
        {
            InitializeComponent();
        }

        private void LimpiarTextoPersonas()
        {
            TxtPersonas.Text = String.Empty;
        }

        private void AsignarTextPersonasLista()
        {
            try
            {
                foreach (var item in personas)
                {
                    TxtPersonas.Text += item.Identificación + " ";
                    TxtPersonas.Text += item.FechaTransaccion.ToString() + " ";
                    TxtPersonas.Text += item.Nombre + " " + item.PrimerApellido + " " + item.SegundoApellido;
                    TxtPersonas.Text += item.MontoTransaccion.ToString();
                    TxtPersonas.Text += item.Mensaje;
                    TxtPersonas.Text += "\n";

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AgregarEventoPersonas(decimal montoRetirar, string mensaje)
        {
            try
            {
                LimpiarTextoPersonas();
                DateTime fechaTransaccion = DateTime.Now;
                // Crear instancia de persona y asignarle valores.
                Modelo.Persona objPersona = new Modelo.Persona
                {
                    Identificación = TxtIdentificacion.Text,
                    Nombre = txtNombre.Text,
                    PrimerApellido = txtApellido1.Text,
                    SegundoApellido = TxtApellido2.Text,
                    FechaTransaccion = fechaTransaccion,
                    MontoTransaccion = montoRetirar,
                    Mensaje = mensaje
                };

                // Agregar ese objeto Persona a la lista de personas.
                personas.Add(objPersona);
                AsignarTextPersonasLista();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                // Agregamos a la persona 
                AgregarEventoPersonas(dineroRetirar, referencia);
                RefrescarSaldo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void BtnArray_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = LlamarPrueba();
                string mensaje = string.Empty;

                for (int i = 0; i < resultado.Length; i++)
                {
                    mensaje += SEPARADOR + resultado[i];

                }
                TxtResultadoArray.Text = mensaje;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string[] LlamarPrueba()
        {
            try
            {
                return LogicaNegocio.Lista.ListaArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> resultadoList = LlamarPruebaList();
                string mensaje = string.Empty;

                foreach (var item in resultadoList)
                {
                    mensaje += SEPARADOR + item.ToString();
                }
                TxtResultadoList.Text = mensaje;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> LlamarPruebaList()
        {
            try
            {
                return LogicaNegocio.Lista.ListEjemplo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
