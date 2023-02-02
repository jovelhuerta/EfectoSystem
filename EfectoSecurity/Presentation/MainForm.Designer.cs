namespace Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktopHeader = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.btnHistoryEntradas = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMedios = new System.Windows.Forms.Panel();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.btnHistPlanes = new System.Windows.Forms.Button();
            this.btnCheckCliente = new System.Windows.Forms.Button();
            this.btnAllClientes = new System.Windows.Forms.Button();
            this.btnPacients = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelMenuHeader = new System.Windows.Forms.Panel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.linkProfile = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnSideMenu = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlanEntrenador = new System.Windows.Forms.Button();
            this.PanelClientArea.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktopHeader.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelEmpleados.SuspendLayout();
            this.panelMedios.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelMenuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideMenu)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelClientArea
            // 
            this.PanelClientArea.Controls.Add(this.panelDesktop);
            this.PanelClientArea.Controls.Add(this.panelDesktopHeader);
            this.PanelClientArea.Controls.Add(this.panelSideMenu);
            this.PanelClientArea.Controls.Add(this.panelTitleBar);
            this.PanelClientArea.Size = new System.Drawing.Size(1198, 598);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.MenuText;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(968, 528);
            this.panelDesktop.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktopHeader
            // 
            this.panelDesktopHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(139)))), ((int)(((byte)(9)))));
            this.panelDesktopHeader.Controls.Add(this.lblCaption);
            this.panelDesktopHeader.Controls.Add(this.btnChildFormClose);
            this.panelDesktopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktopHeader.Location = new System.Drawing.Point(230, 40);
            this.panelDesktopHeader.Name = "panelDesktopHeader";
            this.panelDesktopHeader.Size = new System.Drawing.Size(968, 30);
            this.panelDesktopHeader.TabIndex = 6;
            // 
            // lblCaption
            // 
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(30, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(424, 30);
            this.lblCaption.TabIndex = 18;
            this.lblCaption.Text = "Child Form Title";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChildFormClose
            // 
            this.btnChildFormClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChildFormClose.FlatAppearance.BorderSize = 0;
            this.btnChildFormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnChildFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormClose.Image = ((System.Drawing.Image)(resources.GetObject("btnChildFormClose.Image")));
            this.btnChildFormClose.Location = new System.Drawing.Point(0, 0);
            this.btnChildFormClose.Name = "btnChildFormClose";
            this.btnChildFormClose.Size = new System.Drawing.Size(30, 30);
            this.btnChildFormClose.TabIndex = 19;
            this.btnChildFormClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChildFormClose.UseVisualStyleBackColor = true;
            this.btnChildFormClose.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.panelSideMenu.Controls.Add(this.panelEmpleados);
            this.panelSideMenu.Controls.Add(this.btnEmpleados);
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.panelMedios);
            this.panelSideMenu.Controls.Add(this.btnHistory);
            this.panelSideMenu.Controls.Add(this.panelClientes);
            this.panelSideMenu.Controls.Add(this.btnPacients);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Controls.Add(this.panelMenuHeader);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 40);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(230, 558);
            this.panelSideMenu.TabIndex = 5;
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.Controls.Add(this.btnHistoryEntradas);
            this.panelEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpleados.Location = new System.Drawing.Point(0, 629);
            this.panelEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(213, 52);
            this.panelEmpleados.TabIndex = 35;
            // 
            // btnHistoryEntradas
            // 
            this.btnHistoryEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistoryEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoryEntradas.FlatAppearance.BorderSize = 0;
            this.btnHistoryEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryEntradas.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoryEntradas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistoryEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryEntradas.Location = new System.Drawing.Point(0, 0);
            this.btnHistoryEntradas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistoryEntradas.Name = "btnHistoryEntradas";
            this.btnHistoryEntradas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistoryEntradas.Size = new System.Drawing.Size(213, 43);
            this.btnHistoryEntradas.TabIndex = 33;
            this.btnHistoryEntradas.Text = "   Historial Entradas";
            this.btnHistoryEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistoryEntradas.UseVisualStyleBackColor = true;
            this.btnHistoryEntradas.Click += new System.EventHandler(this.btnHistoryEntradas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 568);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(213, 61);
            this.btnEmpleados.TabIndex = 34;
            this.btnEmpleados.Text = "    Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 681);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(213, 45);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "  Cerrar sesión";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMedios
            // 
            this.panelMedios.Controls.Add(this.btnPlanEntrenador);
            this.panelMedios.Controls.Add(this.btnHorarios);
            this.panelMedios.Controls.Add(this.btnPlanes);
            this.panelMedios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedios.Location = new System.Drawing.Point(0, 434);
            this.panelMedios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMedios.Name = "panelMedios";
            this.panelMedios.Size = new System.Drawing.Size(213, 134);
            this.panelMedios.TabIndex = 30;
            // 
            // btnHorarios
            // 
            this.btnHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarios.Location = new System.Drawing.Point(0, 43);
            this.btnHorarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHorarios.Size = new System.Drawing.Size(213, 43);
            this.btnHorarios.TabIndex = 34;
            this.btnHorarios.Text = "   Horarios";
            this.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanes.FlatAppearance.BorderSize = 0;
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanes.Location = new System.Drawing.Point(0, 0);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlanes.Size = new System.Drawing.Size(213, 43);
            this.btnPlanes.TabIndex = 32;
            this.btnPlanes.Text = "   Planes";
            this.btnPlanes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 373);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(213, 61);
            this.btnHistory.TabIndex = 29;
            this.btnHistory.Text = "  Configuracion";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.btnHistPlanes);
            this.panelClientes.Controls.Add(this.btnCheckCliente);
            this.panelClientes.Controls.Add(this.btnAllClientes);
            this.panelClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientes.Location = new System.Drawing.Point(0, 227);
            this.panelClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(213, 146);
            this.panelClientes.TabIndex = 26;
            // 
            // btnHistPlanes
            // 
            this.btnHistPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistPlanes.FlatAppearance.BorderSize = 0;
            this.btnHistPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistPlanes.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistPlanes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistPlanes.Location = new System.Drawing.Point(0, 93);
            this.btnHistPlanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistPlanes.Name = "btnHistPlanes";
            this.btnHistPlanes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistPlanes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHistPlanes.Size = new System.Drawing.Size(213, 48);
            this.btnHistPlanes.TabIndex = 24;
            this.btnHistPlanes.Text = "   Historial Planes";
            this.btnHistPlanes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistPlanes.UseVisualStyleBackColor = true;
            this.btnHistPlanes.Click += new System.EventHandler(this.btnHistPlanes_Click);
            // 
            // btnCheckCliente
            // 
            this.btnCheckCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckCliente.FlatAppearance.BorderSize = 0;
            this.btnCheckCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckCliente.Location = new System.Drawing.Point(0, 45);
            this.btnCheckCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckCliente.Name = "btnCheckCliente";
            this.btnCheckCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCheckCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCheckCliente.Size = new System.Drawing.Size(213, 48);
            this.btnCheckCliente.TabIndex = 23;
            this.btnCheckCliente.Text = "   Registrar Entrada";
            this.btnCheckCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckCliente.UseVisualStyleBackColor = true;
            this.btnCheckCliente.Click += new System.EventHandler(this.btnCheckCliente_Click);
            // 
            // btnAllClientes
            // 
            this.btnAllClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllClientes.FlatAppearance.BorderSize = 0;
            this.btnAllClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAllClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllClientes.Location = new System.Drawing.Point(0, 0);
            this.btnAllClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAllClientes.Name = "btnAllClientes";
            this.btnAllClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAllClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAllClientes.Size = new System.Drawing.Size(213, 45);
            this.btnAllClientes.TabIndex = 22;
            this.btnAllClientes.Text = "   Todos los Clientes";
            this.btnAllClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllClientes.UseVisualStyleBackColor = true;
            this.btnAllClientes.Click += new System.EventHandler(this.btnAllClientes_Click);
            // 
            // btnPacients
            // 
            this.btnPacients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacients.FlatAppearance.BorderSize = 0;
            this.btnPacients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacients.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacients.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPacients.Image = ((System.Drawing.Image)(resources.GetObject("btnPacients.Image")));
            this.btnPacients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacients.Location = new System.Drawing.Point(0, 169);
            this.btnPacients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPacients.Name = "btnPacients";
            this.btnPacients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPacients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPacients.Size = new System.Drawing.Size(213, 58);
            this.btnPacients.TabIndex = 21;
            this.btnPacients.Text = "   Clientes";
            this.btnPacients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacients.UseVisualStyleBackColor = true;
            this.btnPacients.Click += new System.EventHandler(this.btnPacients_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 115);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(213, 54);
            this.btnUsers.TabIndex = 20;
            this.btnUsers.Text = "   Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelMenuHeader
            // 
            this.panelMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(63)))));
            this.panelMenuHeader.Controls.Add(this.lblLastName);
            this.panelMenuHeader.Controls.Add(this.linkProfile);
            this.panelMenuHeader.Controls.Add(this.pictureBoxPhoto);
            this.panelMenuHeader.Controls.Add(this.btnSideMenu);
            this.panelMenuHeader.Controls.Add(this.lblPosition);
            this.panelMenuHeader.Controls.Add(this.lblName);
            this.panelMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHeader.Name = "panelMenuHeader";
            this.panelMenuHeader.Size = new System.Drawing.Size(213, 115);
            this.panelMenuHeader.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLastName.Location = new System.Drawing.Point(8, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 16);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "LastName";
            // 
            // linkProfile
            // 
            this.linkProfile.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkProfile.AutoSize = true;
            this.linkProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkProfile.LinkColor = System.Drawing.Color.Beige;
            this.linkProfile.Location = new System.Drawing.Point(70, 53);
            this.linkProfile.Name = "linkProfile";
            this.linkProfile.Size = new System.Drawing.Size(70, 17);
            this.linkProfile.TabIndex = 16;
            this.linkProfile.TabStop = true;
            this.linkProfile.Text = "My Profile";
            this.linkProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProfile_LinkClicked);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto.Image = global::Presentation.Properties.Resources.Efecto_Security;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(6, 11);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 13;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPhoto_Paint);
            // 
            // btnSideMenu
            // 
            this.btnSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSideMenu.Image")));
            this.btnSideMenu.Location = new System.Drawing.Point(171, 5);
            this.btnSideMenu.Name = "btnSideMenu";
            this.btnSideMenu.Size = new System.Drawing.Size(32, 32);
            this.btnSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSideMenu.TabIndex = 12;
            this.btnSideMenu.TabStop = false;
            this.btnSideMenu.Visible = false;
            this.btnSideMenu.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPosition.Location = new System.Drawing.Point(70, 37);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(55, 16);
            this.lblPosition.TabIndex = 15;
            this.lblPosition.Text = "Position";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(72, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(91)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.pictureBox2);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1198, 40);
            this.panelTitleBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Project Efecto Gym";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Presentation.Properties.Resources.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(1093, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Presentation.Properties.Resources.btnMaximize;
            this.btnMaximize.Location = new System.Drawing.Point(1128, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Presentation.Properties.Resources.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1163, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlanEntrenador
            // 
            this.btnPlanEntrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanEntrenador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanEntrenador.FlatAppearance.BorderSize = 0;
            this.btnPlanEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanEntrenador.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanEntrenador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlanEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanEntrenador.Location = new System.Drawing.Point(0, 86);
            this.btnPlanEntrenador.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlanEntrenador.Name = "btnPlanEntrenador";
            this.btnPlanEntrenador.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlanEntrenador.Size = new System.Drawing.Size(213, 43);
            this.btnPlanEntrenador.TabIndex = 33;
            this.btnPlanEntrenador.Text = "   Planes Entrenador";
            this.btnPlanEntrenador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanEntrenador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanEntrenador.UseVisualStyleBackColor = true;
            this.btnPlanEntrenador.Click += new System.EventHandler(this.btnPlanEntrenador_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelClientArea.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktopHeader.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelEmpleados.ResumeLayout(false);
            this.panelMedios.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelMenuHeader.ResumeLayout(false);
            this.panelMenuHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideMenu)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktopHeader;
        internal System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.Panel panelSideMenu;
        internal System.Windows.Forms.Button btnPacients;
        internal System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panelMenuHeader;
        internal System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.LinkLabel linkProfile;
        internal System.Windows.Forms.PictureBox pictureBoxPhoto;
        internal System.Windows.Forms.PictureBox btnSideMenu;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelTitleBar;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Panel panelMedios;
        internal System.Windows.Forms.Button btnHorarios;
        internal System.Windows.Forms.Button btnPlanes;
        internal System.Windows.Forms.Button btnHistory;
        internal System.Windows.Forms.Button btnCheckCliente;
        internal System.Windows.Forms.Button btnAllClientes;
        internal System.Windows.Forms.Button btnEmpleados;
        internal System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelEmpleados;
        internal System.Windows.Forms.Button btnHistoryEntradas;
        internal System.Windows.Forms.Button btnHistPlanes;
        internal System.Windows.Forms.Button btnPlanEntrenador;
    }
}

