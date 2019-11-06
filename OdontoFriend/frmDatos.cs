using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessServices;
using Entities;
using MetroSet_UI.Forms;

namespace OdontoFriend
{
    public partial class frmDatos : MetroSetForm
    {
        private bool isEdit;
        private Paciente paciente;
        public frmDatos(bool IsEdit, Entities.Paciente paciente)
        {
            this.isEdit = IsEdit;
            this.paciente = paciente;
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            tcPrincipal.SelectedIndex = 0;
            if (isEdit)
            {
                Text = string.Format("Editar {0} {1}", paciente.Nombre, paciente.Apellido);
                llenarCampos();
            }
            else
            {
                Text = "Nuevo Usuario";
                inicializarCampos();
            }
        }

        private void inicializarCampos()
        {
            Business business = new Business();
            var obrasSociales = business.GetAllObraSocial();
            obrasSociales.Insert(0, new ObraSocial() { IdObraSocial = -1, Codigo = "", Nombre = "Seleccione una opción" });
            obrasSociales.OrderBy(os => os.IdObraSocial);
            cmbObraSocial.DataSource = obrasSociales;
            cmbObraSocial.DisplayMember = "Nombre";
            cmbObraSocial.SelectedIndex = 0;
            cmbGravado.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
        }

        private void llenarCampos()
        {
            Business business = new Business();

            txtNombre.Text = paciente.Nombre;
            txtApellido.Text = paciente.Apellido;
            txtDNI.Text = paciente.DNI;
            txtDomicilio.Text = paciente.Domicilio;
            txtTelefono.Text = paciente.Telefono;
            txtLocalidad.Text = paciente.Localidad;
            cmbSexo.SelectedIndex = !string.IsNullOrEmpty(paciente.Sexo) ? (paciente.Sexo == "M" ? 1 : 2) : 0;
            dtFechaNacimiento.Value = paciente.FechaNacimiento.HasValue ? paciente.FechaNacimiento.Value : new DateTime();

            var obrasSociales = business.GetObraSocial(paciente.IdPaciente);
            obrasSociales.Insert(0, new ObraSocial() { IdObraSocial = -1, Codigo = "", Nombre = "Seleccione una opción" });
            obrasSociales.OrderBy(os => os.IdObraSocial);
            cmbObraSocial.DataSource = obrasSociales;
            cmbObraSocial.DisplayMember = "Nombre";
            cmbObraSocial.SelectedIndex = 0;

            var contactoEmergencia = obtenerContactoEmergencia(paciente.IdPaciente);

            txtNombreEmergencia.Text = contactoEmergencia.Nombre;
            txtParentezco.Text = contactoEmergencia.Parentesco;
            txtTelefonoEmergencia.Text = contactoEmergencia.Telefono;

            activarDesactivarAlerts();
        }

        private ContactoEmergencia obtenerContactoEmergencia(int idPaciente)
        {
            Business business = new Business();
            return business.ObtenerContactoEmergencia(idPaciente);
        }

        private void activarDesactivarAlerts()
        {
            txtNombre.BorderColor = string.IsNullOrEmpty(txtNombre.Text) ? Color.Red: Color.FromArgb(155,155,155);
            txtApellido.BorderColor = string.IsNullOrEmpty(txtApellido.Text) ? Color.Red : Color.FromArgb(155, 155, 155);
            txtDNI.BorderColor = string.IsNullOrEmpty(txtDNI.Text) ? Color.Red : Color.FromArgb(155, 155, 155);
            txtTelefono.BorderColor = string.IsNullOrEmpty(txtTelefono.Text) ? Color.Red : Color.FromArgb(155, 155, 155);            
            txtDomicilio.BorderColor = string.IsNullOrEmpty(txtDomicilio.Text) ? Color.Red : Color.FromArgb(155, 155, 155);
            txtLocalidad.BorderColor = string.IsNullOrEmpty(txtLocalidad.Text) ? Color.Red : Color.FromArgb(155, 155, 155);
            cmbSexo.BorderColor = cmbSexo.SelectedIndex == 0 ? Color.Red : Color.FromArgb(155, 155, 155);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObraSocial os = (ObraSocial)cmbObraSocial.SelectedItem;
            var noEsObraSocial = os.Nombre == "Particular" || os.IdObraSocial == -1;
            bloquearCamposDeObraSocial(noEsObraSocial);

            if (!noEsObraSocial)
            {
                txtAfiliado.Text = os.Afiliado;
                txtEmpresa.Text = os.Empresa;
                txtAsociadoTitular.Text = os.AsociadoTitular;
                txtPlan.Text = os.Plan;
                cmbGravado.SelectedIndex = os.Gravado ? 1 : 2;
            }
        }

        private void bloquearCamposDeObraSocial(bool bloquear)
        {
            txtPlan.ReadOnly = bloquear;
            txtAfiliado.ReadOnly = bloquear;
            txtAsociadoTitular.ReadOnly = bloquear;
            txtEmpresa.ReadOnly = bloquear;

            if (bloquear)
            {
                txtPlan.Text = string.Empty;
                txtAfiliado.Text = string.Empty;
                txtAsociadoTitular.Text = string.Empty;
                txtEmpresa.Text = string.Empty;
            }
        }
    }
}
