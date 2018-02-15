namespace CarDealership.Forms
{
    partial class ManagerScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChPwdButton = new System.Windows.Forms.Button();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RemoveEmployeeButton = new System.Windows.Forms.Button();
            this.AddMechanicButton = new System.Windows.Forms.Button();
            this.AddSellerButton = new System.Windows.Forms.Button();
            this.employeesManagerView1 = new CarDealership.Controls.EmployeesManagerView();
            this.CarsTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RemoveCarButton = new System.Windows.Forms.Button();
            this.GoToOrderButton = new System.Windows.Forms.Button();
            this.AddCarsButton = new System.Windows.Forms.Button();
            this.CarDetailsButton = new System.Windows.Forms.Button();
            this.carsView1 = new CarDealership.Controls.CarsView();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ArchivizeAllButton = new System.Windows.Forms.Button();
            this.ArchivizeButton = new System.Windows.Forms.Button();
            this.OrderCancelButton = new System.Windows.Forms.Button();
            this.OrderReassignButton = new System.Windows.Forms.Button();
            this.OrderNotesButton = new System.Windows.Forms.Button();
            this.ordersView1 = new CarDealership.Controls.OrdersView();
            this.ArchiveTab = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.ArchiveCustomerDetailsButton = new System.Windows.Forms.Button();
            this.ArchiveEmployeeDetailsButton = new System.Windows.Forms.Button();
            this.DealReportButton = new System.Windows.Forms.Button();
            this.EmpReportButton = new System.Windows.Forms.Button();
            this.ArchiveDetailsButton = new System.Windows.Forms.Button();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.modelsDataSet = new CarDealership.ModelsDataSet();
            this.ModelCheckBox = new System.Windows.Forms.CheckBox();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersDataSet = new CarDealership.SellersDataSet();
            this.EmployeeCheckBox = new System.Windows.Forms.CheckBox();
            this.DealershipCheckBox = new System.Windows.Forms.CheckBox();
            this.DealershipComboBox = new System.Windows.Forms.ComboBox();
            this.dealershipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealershipsDataSet = new CarDealership.DealershipsDataSet();
            this.archiveView1 = new CarDealership.Controls.ArchiveView();
            this.CustTab = new System.Windows.Forms.TabPage();
            this.customersView1 = new CarDealership.Controls.CustomersView();
            this.modelsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealershipsTableAdapter = new CarDealership.DealershipsDataSetTableAdapters.DealershipsTableAdapter();
            this.employeesTableAdapter = new CarDealership.SellersDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new CarDealership.SellersDataSetTableAdapters.TableAdapterManager();
            this.modelsTableAdapter = new CarDealership.ModelsDataSetTableAdapters.ModelsTableAdapter();
            this.tableAdapterManager1 = new CarDealership.ModelsDataSetTableAdapters.TableAdapterManager();
            this.OrderCustomerDetailsButton = new System.Windows.Forms.Button();
            this.OrderEmployeeDetailsButton = new System.Windows.Forms.Button();
            this.OrderCarDetailsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CarsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.ArchiveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipsDataSet)).BeginInit();
            this.CustTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTab);
            this.tabControl1.Controls.Add(this.EmployeesTab);
            this.tabControl1.Controls.Add(this.CarsTab);
            this.tabControl1.Controls.Add(this.OrdersTab);
            this.tabControl1.Controls.Add(this.ArchiveTab);
            this.tabControl1.Controls.Add(this.CustTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 451);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.LogoutButton);
            this.HomeTab.Controls.Add(this.ExitButton);
            this.HomeTab.Controls.Add(this.ChPwdButton);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(823, 425);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(162, 392);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(150, 25);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(6, 392);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 25);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChPwdButton
            // 
            this.ChPwdButton.Location = new System.Drawing.Point(6, 361);
            this.ChPwdButton.Name = "ChPwdButton";
            this.ChPwdButton.Size = new System.Drawing.Size(306, 25);
            this.ChPwdButton.TabIndex = 0;
            this.ChPwdButton.Text = "Change Password...";
            this.ChPwdButton.UseVisualStyleBackColor = true;
            this.ChPwdButton.Click += new System.EventHandler(this.ChPwdButton_Click);
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.splitContainer1);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesTab.Size = new System.Drawing.Size(823, 425);
            this.EmployeesTab.TabIndex = 1;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.RemoveEmployeeButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddMechanicButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddSellerButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel2.Controls.Add(this.employeesManagerView1);
            this.splitContainer1.Size = new System.Drawing.Size(817, 419);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 0;
            // 
            // RemoveEmployeeButton
            // 
            this.RemoveEmployeeButton.Location = new System.Drawing.Point(12, 82);
            this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            this.RemoveEmployeeButton.Size = new System.Drawing.Size(150, 25);
            this.RemoveEmployeeButton.TabIndex = 2;
            this.RemoveEmployeeButton.Text = "Remove";
            this.RemoveEmployeeButton.UseVisualStyleBackColor = true;
            this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // AddMechanicButton
            // 
            this.AddMechanicButton.Location = new System.Drawing.Point(12, 51);
            this.AddMechanicButton.Name = "AddMechanicButton";
            this.AddMechanicButton.Size = new System.Drawing.Size(150, 25);
            this.AddMechanicButton.TabIndex = 1;
            this.AddMechanicButton.Text = "Add Mechanic...";
            this.AddMechanicButton.UseVisualStyleBackColor = true;
            this.AddMechanicButton.Click += new System.EventHandler(this.AddMechanicButton_Click);
            // 
            // AddSellerButton
            // 
            this.AddSellerButton.Location = new System.Drawing.Point(12, 20);
            this.AddSellerButton.Name = "AddSellerButton";
            this.AddSellerButton.Size = new System.Drawing.Size(150, 25);
            this.AddSellerButton.TabIndex = 0;
            this.AddSellerButton.Text = "Add Seller...";
            this.AddSellerButton.UseVisualStyleBackColor = true;
            this.AddSellerButton.Click += new System.EventHandler(this.AddSellerButton_Click);
            // 
            // employeesManagerView1
            // 
            this.employeesManagerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesManagerView1.Location = new System.Drawing.Point(0, 0);
            this.employeesManagerView1.Name = "employeesManagerView1";
            this.employeesManagerView1.Size = new System.Drawing.Size(638, 419);
            this.employeesManagerView1.TabIndex = 0;
            // 
            // CarsTab
            // 
            this.CarsTab.Controls.Add(this.splitContainer2);
            this.CarsTab.Location = new System.Drawing.Point(4, 22);
            this.CarsTab.Name = "CarsTab";
            this.CarsTab.Size = new System.Drawing.Size(823, 425);
            this.CarsTab.TabIndex = 2;
            this.CarsTab.Text = "Cars";
            this.CarsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.RemoveCarButton);
            this.splitContainer2.Panel1.Controls.Add(this.GoToOrderButton);
            this.splitContainer2.Panel1.Controls.Add(this.AddCarsButton);
            this.splitContainer2.Panel1.Controls.Add(this.CarDetailsButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.carsView1);
            this.splitContainer2.Size = new System.Drawing.Size(823, 425);
            this.splitContainer2.SplitterDistance = 175;
            this.splitContainer2.TabIndex = 0;
            // 
            // RemoveCarButton
            // 
            this.RemoveCarButton.Location = new System.Drawing.Point(12, 113);
            this.RemoveCarButton.Name = "RemoveCarButton";
            this.RemoveCarButton.Size = new System.Drawing.Size(150, 25);
            this.RemoveCarButton.TabIndex = 3;
            this.RemoveCarButton.Text = "Remove";
            this.RemoveCarButton.UseVisualStyleBackColor = true;
            this.RemoveCarButton.Click += new System.EventHandler(this.RemoveCarButton_Click);
            // 
            // GoToOrderButton
            // 
            this.GoToOrderButton.Location = new System.Drawing.Point(12, 82);
            this.GoToOrderButton.Name = "GoToOrderButton";
            this.GoToOrderButton.Size = new System.Drawing.Size(150, 25);
            this.GoToOrderButton.TabIndex = 2;
            this.GoToOrderButton.Text = "Go to Order";
            this.GoToOrderButton.UseVisualStyleBackColor = true;
            this.GoToOrderButton.Click += new System.EventHandler(this.GoToOrderButton_Click);
            // 
            // AddCarsButton
            // 
            this.AddCarsButton.Location = new System.Drawing.Point(12, 20);
            this.AddCarsButton.Name = "AddCarsButton";
            this.AddCarsButton.Size = new System.Drawing.Size(150, 25);
            this.AddCarsButton.TabIndex = 1;
            this.AddCarsButton.Text = "Add Cars...";
            this.AddCarsButton.UseVisualStyleBackColor = true;
            this.AddCarsButton.Click += new System.EventHandler(this.AddCarsButton_Click);
            // 
            // CarDetailsButton
            // 
            this.CarDetailsButton.Location = new System.Drawing.Point(12, 51);
            this.CarDetailsButton.Name = "CarDetailsButton";
            this.CarDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.CarDetailsButton.TabIndex = 0;
            this.CarDetailsButton.Text = "Details...";
            this.CarDetailsButton.UseVisualStyleBackColor = true;
            this.CarDetailsButton.Click += new System.EventHandler(this.CarDetailsButton_Click);
            // 
            // carsView1
            // 
            this.carsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsView1.Location = new System.Drawing.Point(0, 0);
            this.carsView1.Name = "carsView1";
            this.carsView1.Size = new System.Drawing.Size(644, 425);
            this.carsView1.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.splitContainer3);
            this.OrdersTab.Location = new System.Drawing.Point(4, 22);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTab.Size = new System.Drawing.Size(823, 425);
            this.OrdersTab.TabIndex = 3;
            this.OrdersTab.Text = "Orders";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.OrderCarDetailsButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderEmployeeDetailsButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderCustomerDetailsButton);
            this.splitContainer3.Panel1.Controls.Add(this.ArchivizeAllButton);
            this.splitContainer3.Panel1.Controls.Add(this.ArchivizeButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderCancelButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderReassignButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderNotesButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ordersView1);
            this.splitContainer3.Size = new System.Drawing.Size(817, 419);
            this.splitContainer3.SplitterDistance = 175;
            this.splitContainer3.TabIndex = 0;
            // 
            // ArchivizeAllButton
            // 
            this.ArchivizeAllButton.Location = new System.Drawing.Point(12, 162);
            this.ArchivizeAllButton.Name = "ArchivizeAllButton";
            this.ArchivizeAllButton.Size = new System.Drawing.Size(150, 25);
            this.ArchivizeAllButton.TabIndex = 4;
            this.ArchivizeAllButton.Text = "Archivize All";
            this.ArchivizeAllButton.UseVisualStyleBackColor = true;
            this.ArchivizeAllButton.Click += new System.EventHandler(this.ArchivizeAllButton_Click);
            // 
            // ArchivizeButton
            // 
            this.ArchivizeButton.Location = new System.Drawing.Point(12, 131);
            this.ArchivizeButton.Name = "ArchivizeButton";
            this.ArchivizeButton.Size = new System.Drawing.Size(150, 25);
            this.ArchivizeButton.TabIndex = 3;
            this.ArchivizeButton.Text = "Archivize";
            this.ArchivizeButton.UseVisualStyleBackColor = true;
            this.ArchivizeButton.Click += new System.EventHandler(this.ArchivizeButton_Click);
            // 
            // OrderCancelButton
            // 
            this.OrderCancelButton.Location = new System.Drawing.Point(12, 82);
            this.OrderCancelButton.Name = "OrderCancelButton";
            this.OrderCancelButton.Size = new System.Drawing.Size(150, 25);
            this.OrderCancelButton.TabIndex = 2;
            this.OrderCancelButton.Text = "Cancel";
            this.OrderCancelButton.UseVisualStyleBackColor = true;
            this.OrderCancelButton.Click += new System.EventHandler(this.OrderCancelButton_Click);
            // 
            // OrderReassignButton
            // 
            this.OrderReassignButton.Location = new System.Drawing.Point(12, 51);
            this.OrderReassignButton.Name = "OrderReassignButton";
            this.OrderReassignButton.Size = new System.Drawing.Size(150, 25);
            this.OrderReassignButton.TabIndex = 1;
            this.OrderReassignButton.Text = "Reassign...";
            this.OrderReassignButton.UseVisualStyleBackColor = true;
            this.OrderReassignButton.Click += new System.EventHandler(this.OrderReassignButton_Click);
            // 
            // OrderNotesButton
            // 
            this.OrderNotesButton.Location = new System.Drawing.Point(12, 20);
            this.OrderNotesButton.Name = "OrderNotesButton";
            this.OrderNotesButton.Size = new System.Drawing.Size(150, 25);
            this.OrderNotesButton.TabIndex = 0;
            this.OrderNotesButton.Text = "Notes...";
            this.OrderNotesButton.UseVisualStyleBackColor = true;
            this.OrderNotesButton.Click += new System.EventHandler(this.OrderNotesButton_Click);
            // 
            // ordersView1
            // 
            this.ordersView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersView1.Location = new System.Drawing.Point(0, 0);
            this.ordersView1.Name = "ordersView1";
            this.ordersView1.Size = new System.Drawing.Size(638, 419);
            this.ordersView1.TabIndex = 0;
            // 
            // ArchiveTab
            // 
            this.ArchiveTab.Controls.Add(this.splitContainer4);
            this.ArchiveTab.Location = new System.Drawing.Point(4, 22);
            this.ArchiveTab.Name = "ArchiveTab";
            this.ArchiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.ArchiveTab.Size = new System.Drawing.Size(823, 425);
            this.ArchiveTab.TabIndex = 4;
            this.ArchiveTab.Text = "Archive";
            this.ArchiveTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.Controls.Add(this.ArchiveCustomerDetailsButton);
            this.splitContainer4.Panel1.Controls.Add(this.ArchiveEmployeeDetailsButton);
            this.splitContainer4.Panel1.Controls.Add(this.DealReportButton);
            this.splitContainer4.Panel1.Controls.Add(this.EmpReportButton);
            this.splitContainer4.Panel1.Controls.Add(this.ArchiveDetailsButton);
            this.splitContainer4.Panel1.Controls.Add(this.ModelComboBox);
            this.splitContainer4.Panel1.Controls.Add(this.ModelCheckBox);
            this.splitContainer4.Panel1.Controls.Add(this.EmployeeComboBox);
            this.splitContainer4.Panel1.Controls.Add(this.EmployeeCheckBox);
            this.splitContainer4.Panel1.Controls.Add(this.DealershipCheckBox);
            this.splitContainer4.Panel1.Controls.Add(this.DealershipComboBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.archiveView1);
            this.splitContainer4.Size = new System.Drawing.Size(817, 419);
            this.splitContainer4.SplitterDistance = 175;
            this.splitContainer4.TabIndex = 0;
            // 
            // ArchiveCustomerDetailsButton
            // 
            this.ArchiveCustomerDetailsButton.Location = new System.Drawing.Point(12, 346);
            this.ArchiveCustomerDetailsButton.Name = "ArchiveCustomerDetailsButton";
            this.ArchiveCustomerDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.ArchiveCustomerDetailsButton.TabIndex = 11;
            this.ArchiveCustomerDetailsButton.Text = "Customer detials";
            this.ArchiveCustomerDetailsButton.UseVisualStyleBackColor = true;
            this.ArchiveCustomerDetailsButton.Click += new System.EventHandler(this.ArchiveCustomerDetailsButton_Click);
            // 
            // ArchiveEmployeeDetailsButton
            // 
            this.ArchiveEmployeeDetailsButton.Location = new System.Drawing.Point(12, 315);
            this.ArchiveEmployeeDetailsButton.Name = "ArchiveEmployeeDetailsButton";
            this.ArchiveEmployeeDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.ArchiveEmployeeDetailsButton.TabIndex = 10;
            this.ArchiveEmployeeDetailsButton.Text = "Employee details";
            this.ArchiveEmployeeDetailsButton.UseVisualStyleBackColor = true;
            this.ArchiveEmployeeDetailsButton.Click += new System.EventHandler(this.ArchiveEmployeeDetailsButton_Click);
            // 
            // DealReportButton
            // 
            this.DealReportButton.Location = new System.Drawing.Point(12, 219);
            this.DealReportButton.Name = "DealReportButton";
            this.DealReportButton.Size = new System.Drawing.Size(150, 25);
            this.DealReportButton.TabIndex = 9;
            this.DealReportButton.Text = "Dealership report...";
            this.DealReportButton.UseVisualStyleBackColor = true;
            this.DealReportButton.Click += new System.EventHandler(this.DealReportButton_Click);
            // 
            // EmpReportButton
            // 
            this.EmpReportButton.Enabled = false;
            this.EmpReportButton.Location = new System.Drawing.Point(12, 250);
            this.EmpReportButton.Name = "EmpReportButton";
            this.EmpReportButton.Size = new System.Drawing.Size(150, 25);
            this.EmpReportButton.TabIndex = 8;
            this.EmpReportButton.Text = "Employee report...";
            this.EmpReportButton.UseVisualStyleBackColor = true;
            this.EmpReportButton.Click += new System.EventHandler(this.EmpReportButton_Click);
            // 
            // ArchiveDetailsButton
            // 
            this.ArchiveDetailsButton.Location = new System.Drawing.Point(12, 188);
            this.ArchiveDetailsButton.Name = "ArchiveDetailsButton";
            this.ArchiveDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.ArchiveDetailsButton.TabIndex = 7;
            this.ArchiveDetailsButton.Text = "Details...";
            this.ArchiveDetailsButton.UseVisualStyleBackColor = true;
            this.ArchiveDetailsButton.Click += new System.EventHandler(this.ArchiveDetailsButton_Click);
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.DataSource = this.modelsDataSet;
            this.ModelComboBox.DisplayMember = "Models.NAME";
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(5, 141);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(167, 21);
            this.ModelComboBox.TabIndex = 6;
            this.ModelComboBox.ValueMember = "Models.MODEL_ID";
            this.ModelComboBox.SelectedIndexChanged += new System.EventHandler(this.ModelComboBox_SelectedIndexChanged);
            // 
            // modelsDataSet
            // 
            this.modelsDataSet.DataSetName = "ModelsDataSet";
            this.modelsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ModelCheckBox
            // 
            this.ModelCheckBox.AutoSize = true;
            this.ModelCheckBox.Location = new System.Drawing.Point(5, 118);
            this.ModelCheckBox.Name = "ModelCheckBox";
            this.ModelCheckBox.Size = new System.Drawing.Size(77, 17);
            this.ModelCheckBox.TabIndex = 5;
            this.ModelCheckBox.Text = "Model filter";
            this.ModelCheckBox.UseVisualStyleBackColor = true;
            this.ModelCheckBox.CheckedChanged += new System.EventHandler(this.ModelCheckBox_CheckedChanged);
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.DataSource = this.employeesBindingSource;
            this.EmployeeComboBox.DisplayMember = "NAME";
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(5, 91);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(167, 21);
            this.EmployeeComboBox.TabIndex = 4;
            this.EmployeeComboBox.ValueMember = "EMPLOYEE_ID";
            this.EmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeComboBox_SelectedIndexChanged);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sellersDataSetBindingSource;
            // 
            // sellersDataSetBindingSource
            // 
            this.sellersDataSetBindingSource.DataSource = this.sellersDataSet;
            this.sellersDataSetBindingSource.Position = 0;
            // 
            // sellersDataSet
            // 
            this.sellersDataSet.DataSetName = "SellersDataSet";
            this.sellersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeCheckBox
            // 
            this.EmployeeCheckBox.AutoSize = true;
            this.EmployeeCheckBox.Location = new System.Drawing.Point(5, 68);
            this.EmployeeCheckBox.Name = "EmployeeCheckBox";
            this.EmployeeCheckBox.Size = new System.Drawing.Size(94, 17);
            this.EmployeeCheckBox.TabIndex = 3;
            this.EmployeeCheckBox.Text = "Employee filter";
            this.EmployeeCheckBox.UseVisualStyleBackColor = true;
            this.EmployeeCheckBox.CheckedChanged += new System.EventHandler(this.EmployeeCheckBox_CheckedChanged);
            // 
            // DealershipCheckBox
            // 
            this.DealershipCheckBox.AutoSize = true;
            this.DealershipCheckBox.Checked = true;
            this.DealershipCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DealershipCheckBox.Location = new System.Drawing.Point(5, 18);
            this.DealershipCheckBox.Name = "DealershipCheckBox";
            this.DealershipCheckBox.Size = new System.Drawing.Size(98, 17);
            this.DealershipCheckBox.TabIndex = 2;
            this.DealershipCheckBox.Text = "Dealership filter";
            this.DealershipCheckBox.UseVisualStyleBackColor = true;
            this.DealershipCheckBox.CheckedChanged += new System.EventHandler(this.DealershipCheckBox_CheckedChanged);
            // 
            // DealershipComboBox
            // 
            this.DealershipComboBox.DataSource = this.dealershipsBindingSource;
            this.DealershipComboBox.DisplayMember = "CITY";
            this.DealershipComboBox.FormattingEnabled = true;
            this.DealershipComboBox.Location = new System.Drawing.Point(5, 41);
            this.DealershipComboBox.Name = "DealershipComboBox";
            this.DealershipComboBox.Size = new System.Drawing.Size(167, 21);
            this.DealershipComboBox.TabIndex = 1;
            this.DealershipComboBox.ValueMember = "DEALERSHIP_ID";
            this.DealershipComboBox.SelectedIndexChanged += new System.EventHandler(this.DealershipComboBox_SelectedIndexChanged);
            // 
            // dealershipsBindingSource
            // 
            this.dealershipsBindingSource.DataMember = "Dealerships";
            this.dealershipsBindingSource.DataSource = this.dealershipsDataSet;
            // 
            // dealershipsDataSet
            // 
            this.dealershipsDataSet.DataSetName = "DealershipsDataSet";
            this.dealershipsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archiveView1
            // 
            this.archiveView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archiveView1.Location = new System.Drawing.Point(0, 0);
            this.archiveView1.Name = "archiveView1";
            this.archiveView1.Size = new System.Drawing.Size(638, 419);
            this.archiveView1.TabIndex = 0;
            // 
            // CustTab
            // 
            this.CustTab.Controls.Add(this.customersView1);
            this.CustTab.Location = new System.Drawing.Point(4, 22);
            this.CustTab.Name = "CustTab";
            this.CustTab.Size = new System.Drawing.Size(823, 425);
            this.CustTab.TabIndex = 5;
            this.CustTab.Text = "Local Customers";
            this.CustTab.UseVisualStyleBackColor = true;
            // 
            // customersView1
            // 
            this.customersView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersView1.Location = new System.Drawing.Point(0, 0);
            this.customersView1.Name = "customersView1";
            this.customersView1.Size = new System.Drawing.Size(823, 425);
            this.customersView1.TabIndex = 0;
            // 
            // modelsDataSetBindingSource
            // 
            this.modelsDataSetBindingSource.DataSource = this.modelsDataSet;
            this.modelsDataSetBindingSource.Position = 0;
            // 
            // dealershipsTableAdapter
            // 
            this.dealershipsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarDealership.SellersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ModelsTableAdapter = this.modelsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = CarDealership.ModelsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OrderCustomerDetailsButton
            // 
            this.OrderCustomerDetailsButton.Location = new System.Drawing.Point(12, 222);
            this.OrderCustomerDetailsButton.Name = "OrderCustomerDetailsButton";
            this.OrderCustomerDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.OrderCustomerDetailsButton.TabIndex = 5;
            this.OrderCustomerDetailsButton.Text = "Customer details";
            this.OrderCustomerDetailsButton.UseVisualStyleBackColor = true;
            this.OrderCustomerDetailsButton.Click += new System.EventHandler(this.OrderCustomerDetailsButton_Click);
            // 
            // OrderEmployeeDetailsButton
            // 
            this.OrderEmployeeDetailsButton.Location = new System.Drawing.Point(12, 253);
            this.OrderEmployeeDetailsButton.Name = "OrderEmployeeDetailsButton";
            this.OrderEmployeeDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.OrderEmployeeDetailsButton.TabIndex = 6;
            this.OrderEmployeeDetailsButton.Text = "Employee details";
            this.OrderEmployeeDetailsButton.UseVisualStyleBackColor = true;
            this.OrderEmployeeDetailsButton.Click += new System.EventHandler(this.OrderEmployeeDetailsButton_Click);
            // 
            // OrderCarDetailsButton
            // 
            this.OrderCarDetailsButton.Location = new System.Drawing.Point(12, 284);
            this.OrderCarDetailsButton.Name = "OrderCarDetailsButton";
            this.OrderCarDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.OrderCarDetailsButton.TabIndex = 7;
            this.OrderCarDetailsButton.Text = "Car details";
            this.OrderCarDetailsButton.UseVisualStyleBackColor = true;
            this.OrderCarDetailsButton.Click += new System.EventHandler(this.OrderCarDetailsButton_Click);
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerScreen";
            this.Text = "Car Dealership Manager";
            this.tabControl1.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.EmployeesTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CarsTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.OrdersTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ArchiveTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipsDataSet)).EndInit();
            this.CustTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage EmployeesTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.EmployeesManagerView employeesManagerView1;
        private System.Windows.Forms.TabPage CarsTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.CarsView carsView1;
        private System.Windows.Forms.Button CarDetailsButton;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Controls.OrdersView ordersView1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ChPwdButton;
        private System.Windows.Forms.Button AddCarsButton;
        private System.Windows.Forms.Button GoToOrderButton;
        private System.Windows.Forms.Button AddSellerButton;
        private System.Windows.Forms.Button AddMechanicButton;
        private System.Windows.Forms.Button RemoveCarButton;
        private System.Windows.Forms.Button OrderCancelButton;
        private System.Windows.Forms.Button OrderReassignButton;
        private System.Windows.Forms.Button OrderNotesButton;
        private System.Windows.Forms.TabPage ArchiveTab;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private ModelsDataSet modelsDataSet;
        private System.Windows.Forms.CheckBox ModelCheckBox;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.CheckBox EmployeeCheckBox;
        private System.Windows.Forms.CheckBox DealershipCheckBox;
        private System.Windows.Forms.ComboBox DealershipComboBox;
        private System.Windows.Forms.BindingSource modelsDataSetBindingSource;
        private DealershipsDataSet dealershipsDataSet;
        private System.Windows.Forms.BindingSource dealershipsBindingSource;
        private DealershipsDataSetTableAdapters.DealershipsTableAdapter dealershipsTableAdapter;
        private System.Windows.Forms.BindingSource sellersDataSetBindingSource;
        private SellersDataSet sellersDataSet;
        private SellersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private SellersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private ModelsDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private ModelsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Controls.ArchiveView archiveView1;
        private System.Windows.Forms.Button ArchivizeButton;
        private System.Windows.Forms.Button ArchivizeAllButton;
        private System.Windows.Forms.Button ArchiveDetailsButton;
        private System.Windows.Forms.Button RemoveEmployeeButton;
        private System.Windows.Forms.Button EmpReportButton;
        private System.Windows.Forms.Button DealReportButton;
        private System.Windows.Forms.TabPage CustTab;
        private Controls.CustomersView customersView1;
        private System.Windows.Forms.Button ArchiveCustomerDetailsButton;
        private System.Windows.Forms.Button ArchiveEmployeeDetailsButton;
        private System.Windows.Forms.Button OrderCarDetailsButton;
        private System.Windows.Forms.Button OrderEmployeeDetailsButton;
        private System.Windows.Forms.Button OrderCustomerDetailsButton;
    }
}