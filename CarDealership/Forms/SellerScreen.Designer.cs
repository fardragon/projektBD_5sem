namespace CarDealership.Forms
{
    partial class SellerScreen
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
            this.CarsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CarDetailsButton = new System.Windows.Forms.Button();
            this.AddCarToOrderButton = new System.Windows.Forms.Button();
            this.ShowOrderedCarsCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DealerShipSelector1 = new System.Windows.Forms.NumericUpDown();
            this.carsView1 = new CarDealership.Controls.CarsView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGV_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dealership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.ChPwdButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerToOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.customersView1 = new CarDealership.Controls.CustomersView();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.DiscountsButton = new System.Windows.Forms.Button();
            this.orderNotesButton = new System.Windows.Forms.Button();
            this.OrderCancelButton = new System.Windows.Forms.Button();
            this.OrderCompleteButton = new System.Windows.Forms.Button();
            this.OrderInstallButton = new System.Windows.Forms.Button();
            this.OrderCustomerDetailsButton = new System.Windows.Forms.Button();
            this.OrderCarDetailsButton = new System.Windows.Forms.Button();
            this.ordersView1 = new CarDealership.Controls.OrdersView();
            this.NewOrderTab = new System.Windows.Forms.TabPage();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CarTextBox = new System.Windows.Forms.TextBox();
            this.CarSelectButton = new System.Windows.Forms.Button();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.CustomerSelectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NewOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CarsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealerShipSelector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.CustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.NewOrderTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarsTab
            // 
            this.CarsTab.Controls.Add(this.splitContainer1);
            this.CarsTab.Controls.Add(this.dataGridView1);
            this.CarsTab.Location = new System.Drawing.Point(4, 22);
            this.CarsTab.Name = "CarsTab";
            this.CarsTab.Size = new System.Drawing.Size(726, 410);
            this.CarsTab.TabIndex = 2;
            this.CarsTab.Text = "Cars";
            this.CarsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.CarDetailsButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddCarToOrderButton);
            this.splitContainer1.Panel1.Controls.Add(this.ShowOrderedCarsCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.DealerShipSelector1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.carsView1);
            this.splitContainer1.Size = new System.Drawing.Size(726, 410);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 1;
            // 
            // CarDetailsButton
            // 
            this.CarDetailsButton.Location = new System.Drawing.Point(12, 62);
            this.CarDetailsButton.Name = "CarDetailsButton";
            this.CarDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.CarDetailsButton.TabIndex = 4;
            this.CarDetailsButton.Text = "Details...";
            this.CarDetailsButton.UseVisualStyleBackColor = true;
            this.CarDetailsButton.Click += new System.EventHandler(this.CarDetailsButton_Click);
            // 
            // AddCarToOrderButton
            // 
            this.AddCarToOrderButton.Location = new System.Drawing.Point(12, 93);
            this.AddCarToOrderButton.Name = "AddCarToOrderButton";
            this.AddCarToOrderButton.Size = new System.Drawing.Size(150, 25);
            this.AddCarToOrderButton.TabIndex = 3;
            this.AddCarToOrderButton.Text = "To Order";
            this.AddCarToOrderButton.UseVisualStyleBackColor = true;
            this.AddCarToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // ShowOrderedCarsCheckBox
            // 
            this.ShowOrderedCarsCheckBox.AutoSize = true;
            this.ShowOrderedCarsCheckBox.Location = new System.Drawing.Point(6, 39);
            this.ShowOrderedCarsCheckBox.Name = "ShowOrderedCarsCheckBox";
            this.ShowOrderedCarsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowOrderedCarsCheckBox.Size = new System.Drawing.Size(121, 17);
            this.ShowOrderedCarsCheckBox.TabIndex = 2;
            this.ShowOrderedCarsCheckBox.Text = ":Show Ordered Cars";
            this.ShowOrderedCarsCheckBox.UseVisualStyleBackColor = true;
            this.ShowOrderedCarsCheckBox.CheckedChanged += new System.EventHandler(this.ShowOrderedCarsCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dealership ID";
            // 
            // DealerShipSelector1
            // 
            this.DealerShipSelector1.Location = new System.Drawing.Point(80, 13);
            this.DealerShipSelector1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DealerShipSelector1.Name = "DealerShipSelector1";
            this.DealerShipSelector1.Size = new System.Drawing.Size(92, 20);
            this.DealerShipSelector1.TabIndex = 0;
            this.DealerShipSelector1.ThousandsSeparator = true;
            this.DealerShipSelector1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DealerShipSelector1.ValueChanged += new System.EventHandler(this.DealerShipSelector1_ValueChanged);
            // 
            // carsView1
            // 
            this.carsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsView1.Location = new System.Drawing.Point(0, 0);
            this.carsView1.Name = "carsView1";
            this.carsView1.Size = new System.Drawing.Size(547, 410);
            this.carsView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_ID,
            this.DGV_Name,
            this.DGV_Surname,
            this.DGV_Role,
            this.DGV_Dealership});
            this.dataGridView1.Location = new System.Drawing.Point(545, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // DGV_ID
            // 
            this.DGV_ID.HeaderText = "ID";
            this.DGV_ID.Name = "DGV_ID";
            this.DGV_ID.ReadOnly = true;
            // 
            // DGV_Name
            // 
            this.DGV_Name.HeaderText = "Name";
            this.DGV_Name.Name = "DGV_Name";
            this.DGV_Name.ReadOnly = true;
            // 
            // DGV_Surname
            // 
            this.DGV_Surname.HeaderText = "Surname";
            this.DGV_Surname.Name = "DGV_Surname";
            this.DGV_Surname.ReadOnly = true;
            this.DGV_Surname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DGV_Role
            // 
            this.DGV_Role.HeaderText = "Role";
            this.DGV_Role.Name = "DGV_Role";
            this.DGV_Role.ReadOnly = true;
            // 
            // DGV_Dealership
            // 
            this.DGV_Dealership.HeaderText = "Dealership";
            this.DGV_Dealership.Name = "DGV_Dealership";
            this.DGV_Dealership.ReadOnly = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.HomeTab);
            this.tabControl.Controls.Add(this.CarsTab);
            this.tabControl.Controls.Add(this.CustomersTab);
            this.tabControl.Controls.Add(this.OrdersTab);
            this.tabControl.Controls.Add(this.NewOrderTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(734, 436);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.ChPwdButton);
            this.HomeTab.Controls.Add(this.ExitButton);
            this.HomeTab.Controls.Add(this.LogoutButton);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(726, 410);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // ChPwdButton
            // 
            this.ChPwdButton.Location = new System.Drawing.Point(8, 348);
            this.ChPwdButton.Name = "ChPwdButton";
            this.ChPwdButton.Size = new System.Drawing.Size(304, 23);
            this.ChPwdButton.TabIndex = 2;
            this.ChPwdButton.Text = "Change Password...";
            this.ChPwdButton.UseVisualStyleBackColor = true;
            this.ChPwdButton.Click += new System.EventHandler(this.ChPwdButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(8, 377);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 25);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(162, 377);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(150, 25);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.splitContainer2);
            this.CustomersTab.Location = new System.Drawing.Point(4, 22);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(726, 410);
            this.CustomersTab.TabIndex = 3;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.EditCustomerButton);
            this.splitContainer2.Panel1.Controls.Add(this.NewCustomerButton);
            this.splitContainer2.Panel1.Controls.Add(this.AddCustomerToOrderButton);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.CityTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.NameTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.FilterButton);
            this.splitContainer2.Panel1.Controls.Add(this.ResetButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.customersView1);
            this.splitContainer2.Size = new System.Drawing.Size(720, 404);
            this.splitContainer2.SplitterDistance = 175;
            this.splitContainer2.TabIndex = 0;
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.Location = new System.Drawing.Point(12, 103);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(150, 25);
            this.EditCustomerButton.TabIndex = 8;
            this.EditCustomerButton.Text = "Edit Customer...";
            this.EditCustomerButton.UseVisualStyleBackColor = true;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Location = new System.Drawing.Point(12, 134);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(150, 25);
            this.NewCustomerButton.TabIndex = 7;
            this.NewCustomerButton.Text = "New Customer...";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // AddCustomerToOrderButton
            // 
            this.AddCustomerToOrderButton.Location = new System.Drawing.Point(12, 165);
            this.AddCustomerToOrderButton.Name = "AddCustomerToOrderButton";
            this.AddCustomerToOrderButton.Size = new System.Drawing.Size(150, 25);
            this.AddCustomerToOrderButton.TabIndex = 6;
            this.AddCustomerToOrderButton.Text = "To Order";
            this.AddCustomerToOrderButton.UseVisualStyleBackColor = true;
            this.AddCustomerToOrderButton.Click += new System.EventHandler(this.AddCustomerToOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(52, 43);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(110, 20);
            this.CityTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(52, 16);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(110, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(87, 74);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 25);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 74);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 25);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // customersView1
            // 
            this.customersView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersView1.Location = new System.Drawing.Point(0, 0);
            this.customersView1.Name = "customersView1";
            this.customersView1.Size = new System.Drawing.Size(541, 404);
            this.customersView1.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.splitContainer3);
            this.OrdersTab.Location = new System.Drawing.Point(4, 22);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(726, 410);
            this.OrdersTab.TabIndex = 5;
            this.OrdersTab.Text = "Orders";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Panel1.Controls.Add(this.DiscountsButton);
            this.splitContainer3.Panel1.Controls.Add(this.orderNotesButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderCancelButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderCompleteButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderInstallButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderCustomerDetailsButton);
            this.splitContainer3.Panel1.Controls.Add(this.OrderCarDetailsButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ordersView1);
            this.splitContainer3.Size = new System.Drawing.Size(726, 410);
            this.splitContainer3.SplitterDistance = 175;
            this.splitContainer3.TabIndex = 0;
            // 
            // DiscountsButton
            // 
            this.DiscountsButton.Location = new System.Drawing.Point(12, 182);
            this.DiscountsButton.Name = "DiscountsButton";
            this.DiscountsButton.Size = new System.Drawing.Size(150, 25);
            this.DiscountsButton.TabIndex = 6;
            this.DiscountsButton.Text = "Discounts...";
            this.DiscountsButton.UseVisualStyleBackColor = true;
            this.DiscountsButton.Click += new System.EventHandler(this.DiscountsButton_Click);
            // 
            // orderNotesButton
            // 
            this.orderNotesButton.Location = new System.Drawing.Point(12, 82);
            this.orderNotesButton.Name = "orderNotesButton";
            this.orderNotesButton.Size = new System.Drawing.Size(150, 25);
            this.orderNotesButton.TabIndex = 5;
            this.orderNotesButton.Text = "Notes...";
            this.orderNotesButton.UseVisualStyleBackColor = true;
            this.orderNotesButton.Click += new System.EventHandler(this.orderNotesButton_Click);
            // 
            // OrderCancelButton
            // 
            this.OrderCancelButton.Location = new System.Drawing.Point(12, 275);
            this.OrderCancelButton.Name = "OrderCancelButton";
            this.OrderCancelButton.Size = new System.Drawing.Size(150, 25);
            this.OrderCancelButton.TabIndex = 4;
            this.OrderCancelButton.Text = "Cancel";
            this.OrderCancelButton.UseVisualStyleBackColor = true;
            this.OrderCancelButton.Click += new System.EventHandler(this.OrderCancelButton_Click);
            // 
            // OrderCompleteButton
            // 
            this.OrderCompleteButton.Location = new System.Drawing.Point(12, 244);
            this.OrderCompleteButton.Name = "OrderCompleteButton";
            this.OrderCompleteButton.Size = new System.Drawing.Size(150, 25);
            this.OrderCompleteButton.TabIndex = 3;
            this.OrderCompleteButton.Text = "Complete";
            this.OrderCompleteButton.UseVisualStyleBackColor = true;
            this.OrderCompleteButton.Click += new System.EventHandler(this.OrderCompleteButton_Click);
            // 
            // OrderInstallButton
            // 
            this.OrderInstallButton.Location = new System.Drawing.Point(12, 213);
            this.OrderInstallButton.Name = "OrderInstallButton";
            this.OrderInstallButton.Size = new System.Drawing.Size(150, 25);
            this.OrderInstallButton.TabIndex = 2;
            this.OrderInstallButton.Text = "Install Accessories...";
            this.OrderInstallButton.UseVisualStyleBackColor = true;
            this.OrderInstallButton.Click += new System.EventHandler(this.OrderInstallButton_Click);
            // 
            // OrderCustomerDetailsButton
            // 
            this.OrderCustomerDetailsButton.Location = new System.Drawing.Point(12, 51);
            this.OrderCustomerDetailsButton.Name = "OrderCustomerDetailsButton";
            this.OrderCustomerDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.OrderCustomerDetailsButton.TabIndex = 1;
            this.OrderCustomerDetailsButton.Text = "Customer Details";
            this.OrderCustomerDetailsButton.UseVisualStyleBackColor = true;
            this.OrderCustomerDetailsButton.Click += new System.EventHandler(this.OrderCustomerDetailsButton_Click);
            // 
            // OrderCarDetailsButton
            // 
            this.OrderCarDetailsButton.Location = new System.Drawing.Point(12, 20);
            this.OrderCarDetailsButton.Name = "OrderCarDetailsButton";
            this.OrderCarDetailsButton.Size = new System.Drawing.Size(150, 25);
            this.OrderCarDetailsButton.TabIndex = 0;
            this.OrderCarDetailsButton.Text = "Car Details...";
            this.OrderCarDetailsButton.UseVisualStyleBackColor = true;
            this.OrderCarDetailsButton.Click += new System.EventHandler(this.OrderCarDetailsButton_Click);
            // 
            // ordersView1
            // 
            this.ordersView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersView1.Location = new System.Drawing.Point(0, 0);
            this.ordersView1.Name = "ordersView1";
            this.ordersView1.Size = new System.Drawing.Size(547, 410);
            this.ordersView1.TabIndex = 0;
            // 
            // NewOrderTab
            // 
            this.NewOrderTab.BackColor = System.Drawing.Color.DarkGray;
            this.NewOrderTab.Controls.Add(this.PlaceOrderButton);
            this.NewOrderTab.Controls.Add(this.label5);
            this.NewOrderTab.Controls.Add(this.CarTextBox);
            this.NewOrderTab.Controls.Add(this.CarSelectButton);
            this.NewOrderTab.Controls.Add(this.CustomerTextBox);
            this.NewOrderTab.Controls.Add(this.CustomerSelectButton);
            this.NewOrderTab.Controls.Add(this.label4);
            this.NewOrderTab.Location = new System.Drawing.Point(4, 22);
            this.NewOrderTab.Name = "NewOrderTab";
            this.NewOrderTab.Size = new System.Drawing.Size(726, 410);
            this.NewOrderTab.TabIndex = 4;
            this.NewOrderTab.Text = "New Order";
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(528, 192);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(150, 25);
            this.PlaceOrderButton.TabIndex = 6;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Car:";
            // 
            // CarTextBox
            // 
            this.CarTextBox.Location = new System.Drawing.Point(71, 153);
            this.CarTextBox.Name = "CarTextBox";
            this.CarTextBox.ReadOnly = true;
            this.CarTextBox.Size = new System.Drawing.Size(607, 20);
            this.CarTextBox.TabIndex = 4;
            // 
            // CarSelectButton
            // 
            this.CarSelectButton.Location = new System.Drawing.Point(11, 151);
            this.CarSelectButton.Name = "CarSelectButton";
            this.CarSelectButton.Size = new System.Drawing.Size(54, 23);
            this.CarSelectButton.TabIndex = 3;
            this.CarSelectButton.Text = ">";
            this.CarSelectButton.UseVisualStyleBackColor = true;
            this.CarSelectButton.Click += new System.EventHandler(this.CarSelectButton_Click);
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Location = new System.Drawing.Point(71, 73);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.ReadOnly = true;
            this.CustomerTextBox.Size = new System.Drawing.Size(607, 20);
            this.CustomerTextBox.TabIndex = 2;
            // 
            // CustomerSelectButton
            // 
            this.CustomerSelectButton.Location = new System.Drawing.Point(11, 71);
            this.CustomerSelectButton.Name = "CustomerSelectButton";
            this.CustomerSelectButton.Size = new System.Drawing.Size(54, 23);
            this.CustomerSelectButton.TabIndex = 1;
            this.CustomerSelectButton.Text = ">";
            this.CustomerSelectButton.UseVisualStyleBackColor = true;
            this.CustomerSelectButton.Click += new System.EventHandler(this.CustomerSelectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer:";
            // 
            // SellerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 436);
            this.Controls.Add(this.tabControl);
            this.Name = "SellerScreen";
            this.Text = "Car Dealership Seller";
            this.CarsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DealerShipSelector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.CustomersTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.OrdersTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.NewOrderTab.ResumeLayout(false);
            this.NewOrderTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CarsTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dealership;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.NumericUpDown DealerShipSelector1;
        private System.Windows.Forms.Label label1;
        private Controls.CarsView carsView1;
        private System.Windows.Forms.TabPage CustomersTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.CustomersView customersView1;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage NewOrderTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CarTextBox;
        private System.Windows.Forms.Button CarSelectButton;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.Button CustomerSelectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShowOrderedCarsCheckBox;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.Button AddCarToOrderButton;
        private System.Windows.Forms.Button AddCustomerToOrderButton;
        private System.Windows.Forms.Button CarDetailsButton;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Controls.OrdersView ordersView1;
        private System.Windows.Forms.Button OrderCustomerDetailsButton;
        private System.Windows.Forms.Button OrderCarDetailsButton;
        private System.Windows.Forms.Button OrderCancelButton;
        private System.Windows.Forms.Button OrderCompleteButton;
        private System.Windows.Forms.Button OrderInstallButton;
        private System.Windows.Forms.Button ChPwdButton;
        private System.Windows.Forms.Button orderNotesButton;
        private System.Windows.Forms.Button DiscountsButton;
        private System.Windows.Forms.ToolTip NewOrderToolTip;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button EditCustomerButton;
    }
}