namespace OdontoFriend
{
    partial class frmPrincipal1
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
            this.tbPrincipal = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetTabPage1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTotal = new MetroSet_UI.Controls.MetroSetLabel();
            this.styleManager = new MetroSet_UI.StyleManager();
            this.lvPacientes = new System.Windows.Forms.ListView();
            this.cmdEliminar = new MetroSet_UI.Controls.MetroSetButton();
            this.cmdNuevo = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetTabPage2 = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetSwitch1 = new MetroSet_UI.Controls.MetroSetSwitch();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.tbPrincipal.SuspendLayout();
            this.metroSetTabPage1.SuspendLayout();
            this.metroSetTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrincipal.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbPrincipal.AnimateTime = 200;
            this.tbPrincipal.Controls.Add(this.metroSetTabPage1);
            this.tbPrincipal.Controls.Add(this.metroSetTabPage2);
            this.tbPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPrincipal.ItemSize = new System.Drawing.Size(100, 38);
            this.tbPrincipal.Location = new System.Drawing.Point(0, 80);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 1;
            this.tbPrincipal.Size = new System.Drawing.Size(1000, 520);
            this.tbPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbPrincipal.Speed = 20;
            this.tbPrincipal.Style = MetroSet_UI.Design.Style.Light;
            this.tbPrincipal.StyleManager = this.styleManager;
            this.tbPrincipal.TabIndex = 0;
            this.tbPrincipal.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.tbPrincipal.ThemeAuthor = null;
            this.tbPrincipal.ThemeName = null;
            this.tbPrincipal.UseAnimation = true;
            // 
            // metroSetTabPage1
            // 
            this.metroSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage1.Controls.Add(this.txtFiltro);
            this.metroSetTabPage1.Controls.Add(this.lblTotal);
            this.metroSetTabPage1.Controls.Add(this.lvPacientes);
            this.metroSetTabPage1.Controls.Add(this.cmdEliminar);
            this.metroSetTabPage1.Controls.Add(this.cmdNuevo);
            this.metroSetTabPage1.ImageIndex = 0;
            this.metroSetTabPage1.ImageKey = null;
            this.metroSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage1.Name = "metroSetTabPage1";
            this.metroSetTabPage1.Size = new System.Drawing.Size(992, 474);
            this.metroSetTabPage1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage1.StyleManager = this.styleManager;
            this.metroSetTabPage1.TabIndex = 0;
            this.metroSetTabPage1.Text = "Paciente";
            this.metroSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetTabPage1.ThemeName = "MetroLite";
            this.metroSetTabPage1.ToolTipText = null;
            // 
            // txtFiltro
            // 
            this.txtFiltro.ForeColor = System.Drawing.Color.Silver;
            this.txtFiltro.Location = new System.Drawing.Point(232, 26);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(254, 27);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.Text = "filtrar...";
            this.txtFiltro.Enter += new System.EventHandler(this.txtFiltro_Enter);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress_1);
            this.txtFiltro.Leave += new System.EventHandler(this.txtFiltro_Leave);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(816, 45);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(176, 23);
            this.lblTotal.Style = MetroSet_UI.Design.Style.Light;
            this.lblTotal.StyleManager = this.styleManager;
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: 650";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.ThemeAuthor = null;
            this.lblTotal.ThemeName = null;
            // 
            // styleManager
            // 
            this.styleManager.CustomTheme = "C:\\Users\\istrficek\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager.MetroForm = this;
            this.styleManager.Style = MetroSet_UI.Design.Style.Light;
            this.styleManager.ThemeAuthor = null;
            this.styleManager.ThemeName = null;
            // 
            // lvPacientes
            // 
            this.lvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPacientes.HideSelection = false;
            this.lvPacientes.Location = new System.Drawing.Point(3, 71);
            this.lvPacientes.Name = "lvPacientes";
            this.lvPacientes.Size = new System.Drawing.Size(989, 403);
            this.lvPacientes.TabIndex = 2;
            this.lvPacientes.UseCompatibleStateImageBehavior = false;
            this.lvPacientes.View = System.Windows.Forms.View.Details;
            this.lvPacientes.DoubleClick += new System.EventHandler(this.lvPacientes_DoubleClick);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmdEliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmdEliminar.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdEliminar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmdEliminar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmdEliminar.HoverTextColor = System.Drawing.Color.White;
            this.cmdEliminar.Location = new System.Drawing.Point(100, 14);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmdEliminar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmdEliminar.NormalTextColor = System.Drawing.Color.White;
            this.cmdEliminar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmdEliminar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmdEliminar.PressTextColor = System.Drawing.Color.White;
            this.cmdEliminar.Size = new System.Drawing.Size(91, 51);
            this.cmdEliminar.Style = MetroSet_UI.Design.Style.Light;
            this.cmdEliminar.StyleManager = this.styleManager;
            this.cmdEliminar.TabIndex = 1;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.ThemeAuthor = null;
            this.cmdEliminar.ThemeName = null;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmdNuevo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmdNuevo.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdNuevo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmdNuevo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cmdNuevo.HoverTextColor = System.Drawing.Color.White;
            this.cmdNuevo.Location = new System.Drawing.Point(3, 14);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmdNuevo.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmdNuevo.NormalTextColor = System.Drawing.Color.White;
            this.cmdNuevo.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmdNuevo.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cmdNuevo.PressTextColor = System.Drawing.Color.White;
            this.cmdNuevo.Size = new System.Drawing.Size(91, 51);
            this.cmdNuevo.Style = MetroSet_UI.Design.Style.Light;
            this.cmdNuevo.StyleManager = this.styleManager;
            this.cmdNuevo.TabIndex = 0;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.ThemeAuthor = null;
            this.cmdNuevo.ThemeName = null;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // metroSetTabPage2
            // 
            this.metroSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage2.Controls.Add(this.metroSetSwitch1);
            this.metroSetTabPage2.ImageIndex = 0;
            this.metroSetTabPage2.ImageKey = null;
            this.metroSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage2.Name = "metroSetTabPage2";
            this.metroSetTabPage2.Size = new System.Drawing.Size(992, 474);
            this.metroSetTabPage2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage2.StyleManager = this.styleManager;
            this.metroSetTabPage2.TabIndex = 1;
            this.metroSetTabPage2.Text = "Configuración";
            this.metroSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetTabPage2.ThemeName = "MetroLite";
            this.metroSetTabPage2.ToolTipText = null;
            // 
            // metroSetSwitch1
            // 
            this.metroSetSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetSwitch1.BackgroundColor = System.Drawing.Color.Empty;
            this.metroSetSwitch1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.metroSetSwitch1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetSwitch1.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetSwitch1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetSwitch1.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetSwitch1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetSwitch1.Location = new System.Drawing.Point(70, 33);
            this.metroSetSwitch1.Name = "metroSetSwitch1";
            this.metroSetSwitch1.Size = new System.Drawing.Size(58, 22);
            this.metroSetSwitch1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetSwitch1.StyleManager = this.styleManager;
            this.metroSetSwitch1.Switched = false;
            this.metroSetSwitch1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.metroSetSwitch1.TabIndex = 0;
            this.metroSetSwitch1.Text = "metroSetSwitch1";
            this.metroSetSwitch1.ThemeAuthor = "Narwin";
            this.metroSetSwitch1.ThemeName = "MetroLite";
            this.metroSetSwitch1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetSwitch1.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.metroSetSwitch1_SwitchedChanged);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(896, 4);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = this.styleManager;
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = null;
            this.metroSetControlBox1.ThemeName = null;
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Location = new System.Drawing.Point(418, 39);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(75, 23);
            this.metroSetButton1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetButton1.StyleManager = this.styleManager;
            this.metroSetButton1.TabIndex = 2;
            this.metroSetButton1.Text = "metroSetButton1";
            this.metroSetButton1.ThemeAuthor = null;
            this.metroSetButton1.ThemeName = null;
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // frmPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.tbPrincipal);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmPrincipal1";
            this.StyleManager = this.styleManager;
            this.Text = "OdontoFriend";
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.Load += new System.EventHandler(this.frmPrincipal1_Load);
            this.SizeChanged += new System.EventHandler(this.frmPrincipal1_SizeChanged);
            this.tbPrincipal.ResumeLayout(false);
            this.metroSetTabPage1.ResumeLayout(false);
            this.metroSetTabPage1.PerformLayout();
            this.metroSetTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl tbPrincipal;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage2;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.ListView lvPacientes;
        private MetroSet_UI.Controls.MetroSetButton cmdEliminar;
        private MetroSet_UI.Controls.MetroSetButton cmdNuevo;
        private MetroSet_UI.Controls.MetroSetLabel lblTotal;
        private System.Windows.Forms.TextBox txtFiltro;
        private MetroSet_UI.StyleManager styleManager;
        private MetroSet_UI.Controls.MetroSetSwitch metroSetSwitch1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
    }
}