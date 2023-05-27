namespace MyApp_HiepBui
{
    partial class Form_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();

            this.pnMain = new System.Windows.Forms.Panel();

            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userControlWareHousecs2 = new MyApp_HiepBui.IF_Layer.UserControlWareHousecs();

            this.frmCustomers1 = new MyApp_HiepBui.IF_Layer.frmCustomers();
            this.userControlWareHousecs2 = new MyApp_HiepBui.IF_Layer.UserControlWareHousecs();
            this.userControlWareHousecs1 = new MyApp_HiepBui.IF_Layer.UserControlWareHousecs();
            this.addNewOrder1 = new MyApp_HiepBui.IF_Layer.AddNewOrder();

            this.addNewOrder2 = new MyApp_HiepBui.IF_Layer.AddNewOrder();

            this.userControl_Employee1 = new MyApp_HiepBui.IF_Layer.UserControl_Employee();

            this.statusStrip1.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 743);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1387, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 

            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel1.Text = "Ready";
            // 

            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1362, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 743);
            this.panel1.TabIndex = 4;
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.userControl_Employee1);
            this.pnMain.Controls.Add(this.userControlWareHousecs2);
            this.pnMain.Controls.Add(this.frmCustomers1);
            this.pnMain.Controls.Add(this.menuStrip1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1362, 742);
            this.pnMain.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(189)))), ((int)(((byte)(220)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuWarehouse,
            this.mnuOrders,
            this.mnuEmployees,
            this.mnuCustomers,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mnuSystem.Image = ((System.Drawing.Image)(resources.GetObject("mnuSystem.Image")));
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(90, 24);
            this.mnuSystem.Text = "&System";
            this.mnuSystem.Click += new System.EventHandler(this.mnuSystem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.accountToolStripMenuItem.Text = "&Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.versionToolStripMenuItem.Text = "&Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // mnuWarehouse
            // 
            this.mnuWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("mnuWarehouse.Image")));
            this.mnuWarehouse.Name = "mnuWarehouse";
            this.mnuWarehouse.Size = new System.Drawing.Size(117, 24);
            this.mnuWarehouse.Text = "&Warehouse";
            this.mnuWarehouse.Click += new System.EventHandler(this.mnuWarehouse_Click);
            // 
            // mnuOrders
            // 
            this.mnuOrders.Image = ((System.Drawing.Image)(resources.GetObject("mnuOrders.Image")));
            this.mnuOrders.Name = "mnuOrders";
            this.mnuOrders.Size = new System.Drawing.Size(86, 24);
            this.mnuOrders.Text = "&Orders";
            this.mnuOrders.Click += new System.EventHandler(this.mnuOrders_Click);
            // 
            // mnuEmployees
            // 
            this.mnuEmployees.Image = ((System.Drawing.Image)(resources.GetObject("mnuEmployees.Image")));
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Size = new System.Drawing.Size(114, 24);
            this.mnuEmployees.Text = "&Employees";
            this.mnuEmployees.Click += new System.EventHandler(this.mnuEmployees_Click);
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.Image = ((System.Drawing.Image)(resources.GetObject("mnuCustomers.Image")));
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(114, 24);
            this.mnuCustomers.Text = "&Customers";
            this.mnuCustomers.Click += new System.EventHandler(this.mnuCustomers_Click_1);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(70, 24);
            this.mnuHelp.Text = "&Help";
            // 
            // toolStripStatusLabel1
            // 

            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.frmCustomers1);
            this.pnMain.Controls.Add(this.addNewOrder2);
            this.pnMain.Controls.Add(this.menuStrip1);
            this.pnMain.Controls.Add(this.userControlWareHousecs2);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1362, 743);
            this.pnMain.TabIndex = 6;

            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 20);
            this.toolStripStatusLabel1.Text = "Ready";

            // 
            // frmCustomers1
            // 
            this.frmCustomers1.AutoSize = true;
            this.frmCustomers1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmCustomers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmCustomers1.Location = new System.Drawing.Point(0, 28);
            this.frmCustomers1.Margin = new System.Windows.Forms.Padding(4);
            this.frmCustomers1.Name = "frmCustomers1";
            this.frmCustomers1.Size = new System.Drawing.Size(1362, 715);
            this.frmCustomers1.TabIndex = 2;
            this.frmCustomers1.Load += new System.EventHandler(this.frmCustomers1_Load);
            // 
            // userControlWareHousecs2
            // 
            this.userControlWareHousecs2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.userControlWareHousecs2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlWareHousecs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlWareHousecs2.Location = new System.Drawing.Point(0, 0);
            this.userControlWareHousecs2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlWareHousecs2.Name = "userControlWareHousecs2";
            this.userControlWareHousecs2.Size = new System.Drawing.Size(1362, 743);
            this.userControlWareHousecs2.TabIndex = 3;
            // 
            // userControlWareHousecs1
            // 
            this.userControlWareHousecs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlWareHousecs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlWareHousecs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlWareHousecs1.Location = new System.Drawing.Point(0, 0);
            this.userControlWareHousecs1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlWareHousecs1.Name = "userControlWareHousecs1";
            this.userControlWareHousecs1.Size = new System.Drawing.Size(1387, 743);
            this.userControlWareHousecs1.TabIndex = 2;
            // 
            // addNewOrder1
            // 
            this.addNewOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.addNewOrder1.Enabled = false;
            this.addNewOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewOrder1.Location = new System.Drawing.Point(1096, 552);
            this.addNewOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.addNewOrder1.Name = "addNewOrder1";
            this.addNewOrder1.Size = new System.Drawing.Size(235, 216);
            this.addNewOrder1.TabIndex = 0;
            // 

            // addNewOrder2
            // 
            this.addNewOrder2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.addNewOrder2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNewOrder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewOrder2.Location = new System.Drawing.Point(0, 28);
            this.addNewOrder2.Margin = new System.Windows.Forms.Padding(4);
            this.addNewOrder2.Name = "addNewOrder2";
            this.addNewOrder2.Size = new System.Drawing.Size(1362, 715);
            this.addNewOrder2.TabIndex = 0;

            // userControl_Employee1
            // 
            this.userControl_Employee1.Location = new System.Drawing.Point(0, 32);
            this.userControl_Employee1.Name = "userControl_Employee1";
            this.userControl_Employee1.Size = new System.Drawing.Size(1387, 724);
            this.userControl_Employee1.TabIndex = 4;

            // 
            // Form_Menu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1387, 768);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlWareHousecs1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.addNewOrder1);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H4 Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Programm_FormClosed);
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuWarehouse;
        private System.Windows.Forms.ToolStripMenuItem mnuOrders;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Panel pnMain;
        private IF_Layer.frmCustomers frmCustomers1;
        private IF_Layer.UserControlWareHousecs userControlWareHousecs1;
        private IF_Layer.AddNewOrder addNewOrder1;
        private IF_Layer.UserControlWareHousecs userControlWareHousecs2;

        private IF_Layer.AddNewOrder addNewOrder2;

        private IF_Layer.UserControl_Employee userControl_Employee1;

    }
}