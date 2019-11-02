using BusinessServices;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Entities;

namespace OdontoFriend
{
    public partial class frmDatosPaciente : Form
    {
        private bool isEdit;
        private Paciente paciente;
        public frmDatosPaciente(bool IsEdit, Entities.Paciente paciente)
        {
            this.isEdit = IsEdit;
            this.paciente = paciente;
            InitializeComponent();
        }

        private void frmDatosPaciente_Load(object sender, EventArgs e)
        {
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
            cmbSexo.SelectedIndex = !string.IsNullOrEmpty(paciente.Sexo) ? (paciente.Sexo == "M" ? 1 : 2): 0;
            txtFecNac.Text = paciente.FechaNacimientoString;
            
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
            pbAlertNombre.Visible = string.IsNullOrEmpty(txtNombre.Text);
            pbAlertApellido.Visible = string.IsNullOrEmpty(txtApellido.Text);
            pbAlertDNI.Visible = string.IsNullOrEmpty(txtDNI.Text);
            pbAlertTelefono.Visible = string.IsNullOrEmpty(txtTelefono.Text);
            pbAlertFechaDeNacimiento.Visible = string.IsNullOrEmpty(txtFecNac.Text);
            pbAlertDomicilio.Visible = string.IsNullOrEmpty(txtDomicilio.Text);
            pbAlertLocalidad.Visible = string.IsNullOrEmpty(txtLocalidad.Text);
            pbAlertSexo.Visible = cmbSexo.SelectedIndex == 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
