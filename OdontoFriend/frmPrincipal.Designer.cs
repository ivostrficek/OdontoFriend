namespace OdontoFriend
{
    partial class frmPrincipal
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
            this.lvPacientes = new System.Windows.Forms.ListView();
            this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Domicilio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdEditar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPacientes
            // 
            this.lvPacientes.AllowColumnReorder = true;
            this.lvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Domicilio,
            this.Notificacion});
            this.lvPacientes.HideSelection = false;
            this.lvPacientes.Location = new System.Drawing.Point(12, 94);
            this.lvPacientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvPacientes.MultiSelect = false;
            this.lvPacientes.Name = "lvPacientes";
            this.lvPacientes.Size = new System.Drawing.Size(950, 442);
            this.lvPacientes.TabIndex = 0;
            this.lvPacientes.UseCompatibleStateImageBehavior = false;
            this.lvPacientes.View = System.Windows.Forms.View.Details;
            this.lvPacientes.DoubleClick += new System.EventHandler(this.lvPacientes_DoubleClick);
            // 
            // DNI
            // 
            this.DNI.Text = "DNI";
            this.DNI.Width = 122;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 215;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 215;
            // 
            // Domicilio
            // 
            this.Domicilio.Text = "Domicilio";
            this.Domicilio.Width = 182;
            // 
            // Notificacion
            // 
            this.Notificacion.Text = "Notificación";
            this.Notificacion.Width = 153;
            // 
            // cmdEditar
            // 
            this.cmdEditar.Location = new System.Drawing.Point(12, 12);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(121, 76);
            this.cmdEditar.TabIndex = 1;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.UseVisualStyleBackColor = true;
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(139, 12);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(121, 76);
            this.cmdNuevo.TabIndex = 2;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(438, 39);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(98, 23);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(542, 36);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(285, 31);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(860, 65);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 23);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label2";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(266, 12);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(121, 76);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.lvPacientes);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmPrincipal";
            this.Text = "OdontoFriend";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPacientes;
        private System.Windows.Forms.ColumnHeader DNI;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Domicilio;
        private System.Windows.Forms.ColumnHeader Notificacion;
        private System.Windows.Forms.Button cmdEditar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdEliminar;
    }
}

