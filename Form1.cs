using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.claseObjeto_PlanillaDeEmpleados
{
    public partial class fmrPlanilla : Form
    {
        public fmrPlanilla()
        {
            InitializeComponent();
        }

        private void fmrPlanilla_Load(object sender, EventArgs e)
        {
            mostrarFecha();
            mostrarMesActual();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Capturando los datos
            string empleado = txtEmpleado.Text;
            string cargo = cboCargo.Text;
            DateTime fechaIngreso = dtFechaIngreso.Value;
            int años = int.Parse(txtAños.Text);

            // Objeto de la clase planilla
            Planilla objp = new Planilla();
            objp.empleado = empleado;
            objp.cargo = cargo;
            objp.fechaIngreso = fechaIngreso;
            objp.años = años;

            // Realizando la impresion de valores
            txtMes.Text = objp.mesConsultado();
            lblSueldoBasico.Text = objp.DeterminaBasico().ToString("S/0.00");
            lblGratificacion.Text = objp.determinaGratificacion().ToString("S/0.00");
            lblComision.Text = objp.determinaComision().ToString("S/0.00");
            lblAfp.Text = objp.determinarDescuentoAFP().ToString("S/0.00");
            lblCooperativa.Text = objp.determinaDescuentoCooperativa().ToString("S/0.00");
            lblSeguroSocial.Text = objp.determinaAportacionSeguro().ToString("S/0.00");

            lblTotalIngresos.Text = objp.calculaTotalIngresos().ToString("S/0.00");
            lblTotalDescuentos.Text = objp.calculaTotalDescuentos().ToString("S/0.00");
            lblTotalAportaciones.Text = objp.calculaTotalAportaciones().ToString("S/0.00");

            lblTotalNeto.Text = objp.determinaNeto().ToString("S/0.00");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            dtFechaIngreso.Value = DateTime.Now;
            cboCargo.Text = "Humano Seleccione";
            txtMes.Clear();
            txtAños.Clear();

            lblSueldoBasico.Text = (0).ToString("S/0.00");
            lblGratificacion.Text = (0).ToString("S/0.00");
            lblComision.Text = (0).ToString("S/0.00");
            lblAfp.Text = (0).ToString("S/0.00");
            lblCooperativa.Text = (0).ToString("S/0.00");
            lblSeguroSocial.Text = (0).ToString("S/0.00");

            lblTotalAportaciones.Text = (0).ToString("S/0.00");
            lblTotalDescuentos.Text = (0).ToString("S/0.00");
            lblTotalIngresos.Text = (0).ToString("S/0.00");
            lblTotalNeto.Text = (0).ToString("S/0.00");

            txtEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Humano estas seguro de salir del formulario?", "Planilla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
                this.Close();
        }
        /* Implementacion de metodos
           1. mostrar la fecha actual  */
        void mostrarFecha()
        {
            lblFechaConsulta.Text = DateTime.Now.ToShortDateString();
        }
        void mostrarMesActual()
        {
            txtMes.Text = DateTime.Now.Month.ToString();
        }

        private void dtFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            txtAños.Text = (DateTime.Now.Year - dtFechaIngreso.Value.Year).ToString();
        }
    }
}
