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
    public partial class frmPrincipal1 : MetroSetForm
    {
        private List<Paciente> listaPacientes = new List<Paciente>();
        public frmPrincipal1()
        {
            InitializeComponent();
            Bitmap bmp = OdontoFriend.Properties.Resources.teeth_icon;
            Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void frmPrincipal1_Load(object sender, EventArgs e)
        {
            recargarLista(null);
            tbPrincipal.SelectedIndex = 0;
        }

        private void recargarLista(string filtro)
        {
            lvPacientes.Clear();
            lvPacientes.Columns.Add(new ColumnHeader() { Text = "DNI", Width = 122 });
            lvPacientes.Columns.Add(new ColumnHeader() { Text = "Nombre", Width = 215 });
            lvPacientes.Columns.Add(new ColumnHeader() { Text = "Apellido", Width = 215 });
            lvPacientes.Columns.Add(new ColumnHeader() { Text = "Domicilio", Width = 182 });
            lvPacientes.Columns.Add(new ColumnHeader() { Text = "Info", Width = 153 });
            lvPacientes.MultiSelect = false;
            lvPacientes.FullRowSelect = true;
            lvPacientes.GridLines = true;

            Business business = new Business();

            if (string.IsNullOrEmpty(filtro))
                listaPacientes = business.GetPacientes();
            else
                listaPacientes = business.GetPacientes(filtro);

            foreach (var p in listaPacientes)
            {
                var missingData = p.MissingData();
                var newItem = new ListViewItem();
                newItem.Text = p.DNI;
                newItem.SubItems.Add(p.Nombre);
                newItem.SubItems.Add(p.Apellido);
                newItem.SubItems.Add(p.Domicilio);
                newItem.SubItems.Add(missingData ? "Faltan datos" : "");
                newItem.SubItems.Add(p.IdPaciente.ToString());
                newItem.BackColor = missingData ? Color.Salmon : Color.LightGreen;
                lvPacientes.Items.Add(newItem);
            }

            setearTotal(listaPacientes.Count());
            rezizeLista();

        }

        private void setearTotal(int total)
        {
            lblTotal.Text = string.Format("Total: {0}", total.ToString());
        }

        private void eliminarPaciente()
        {
            if (lvPacientes.SelectedItems.Count == 0)
                MessageBox.Show("Selecciona un paciente kpo");
            else
            {
                Business business = new Business();
                business.DeletePaciente(listaPacientes.Where(p => p.IdPaciente == int.Parse(lvPacientes.SelectedItems[0].SubItems[5].Text)).FirstOrDefault());
                recargarLista(txtFiltro.Text);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            frmDatosPaciente frm = new frmDatosPaciente(false, null);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
                recargarLista(txtFiltro.Text);
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            eliminarPaciente();
        }

        private void editarPaciente(Paciente paciente)
        {
            frmDatosPaciente frm = new frmDatosPaciente(true, paciente);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
                recargarLista(txtFiltro.Text);
        }

        private void lvPacientes_DoubleClick(object sender, EventArgs e)
        {
            if (lvPacientes.SelectedItems.Count == 1)
                editarPaciente(listaPacientes.Where(p => p.IdPaciente == int.Parse(lvPacientes.SelectedItems[0].SubItems[5].Text)).FirstOrDefault());
        }

        private void txtFiltro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                recargarLista(txtFiltro.Text);
        }

        private void frmPrincipal1_SizeChanged(object sender, EventArgs e)
        {
            rezizeLista();
        }

        private void rezizeLista()
        {
            if (lvPacientes.Columns.Count > 0)
            {
                var columnsQty = lvPacientes.Columns.Count;
                var columnWidth = Width / columnsQty;

                foreach (ColumnHeader column in lvPacientes.Columns)
                {
                    column.Width = columnWidth;
                }
            }
        }

        private void txtFiltro_Enter(object sender, EventArgs e)
        {
            if (txtFiltro.Text == "filtrar...")
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.Black;
            }
        }

        private void txtFiltro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                txtFiltro.Text = "filtrar...";
                txtFiltro.ForeColor = Color.Silver;
            }                
        }

        private void metroSetSwitch1_SwitchedChanged(object sender)
        {
            if (styleManager.Style == MetroSet_UI.Design.Style.Light)
            {
                styleManager.Style = MetroSet_UI.Design.Style.Dark;
            }
            else
            {
                styleManager.Style = MetroSet_UI.Design.Style.Light;
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            frmDatos frm = new frmDatos();
            frm.ShowDialog();
        }
    }
}
