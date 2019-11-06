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
using MetroSet_UI.Forms;
using Entities;

namespace OdontoFriend
{
    public partial class frmObraSocial : MetroSetForm
    {
        private bool isEdit;
        private BindingList<Plan> planes = new BindingList<Plan>();
        //private List<Plan> planes = new List<Plan>();
        public frmObraSocial(bool isEdit = false)
        {
            InitializeComponent();
            this.isEdit = isEdit;
        }

        private void frmObraSocial_Load(object sender, EventArgs e)
        {
            lbPlanes.DataSource = planes;
            lbPlanes.DisplayMember = "Nombre";
            if (isEdit)
                cargarListaObraSocial();
            else
                cmbObrasSociales.Enabled = false;
        }

        public void cargarListaObraSocial()
        {
            Business business = new Business();
            var listaObraSocial = business.GetAllObraSocial();
            listaObraSocial.Insert(0,new ObraSocial() { Nombre = "Seleccione una obra social de la lista"});
            cmbObrasSociales.DataSource = listaObraSocial;
            cmbObrasSociales.DisplayMember = "Nombre";
            cmbObrasSociales.SelectedIndex = 0;
        }

        private void cmbObrasSociales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbObrasSociales.SelectedIndex > 0)
            {
                cargarDatos((ObraSocial)cmbObrasSociales.Items[cmbObrasSociales.SelectedIndex]);
            }
        }

        private void cargarDatos(ObraSocial os)
        {
            Business business = new Business();
            txtNombre.Text = os.Nombre;
            txtCodigo.Text = os.Codigo;
            planes.Clear();
            foreach(var plan in business.GetPlanes(os.IdObraSocial))
            {
                planes.Add(plan);
            }            
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cmdGuardarPlan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlan.Text))
                planes.Add(new Plan() { Habilitado = true, IdObraSocial = -1, IdPlan = planes.Count(), Nombre = txtPlan.Text });

            txtPlan.Text = string.Empty;
                
        }

        private void cmdEliminarPlan_Click(object sender, EventArgs e)
        {
            if(lbPlanes.SelectedItems.Count > 0)
            {
                planes.RemoveAt(lbPlanes.SelectedIndex);
                txtPlan.Text = string.Empty;
            }
        }

        private void lbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPlanes.SelectedItems.Count > 0)
            {
                txtPlan.Text = ((Plan)(lbPlanes.SelectedItem)).Nombre;
            }
        }
    }
}
