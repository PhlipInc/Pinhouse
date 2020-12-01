namespace Pinhouse
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.employeeList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.newEmployee = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.employeePage = new System.Windows.Forms.TabPage();
            this.eLastNameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.eStateCombo = new System.Windows.Forms.ComboBox();
            this.eZipCodeMasked = new System.Windows.Forms.MaskedTextBox();
            this.eCityBox = new System.Windows.Forms.TextBox();
            this.ePhoneMasked = new System.Windows.Forms.MaskedTextBox();
            this.eDobMasked = new System.Windows.Forms.MaskedTextBox();
            this.eStreetBox = new System.Windows.Forms.TextBox();
            this.eFirstNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.schedulePage = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.stopSundayKind = new System.Windows.Forms.ComboBox();
            this.stopSundayTime = new System.Windows.Forms.MaskedTextBox();
            this.stopSaturdayKind = new System.Windows.Forms.ComboBox();
            this.stopSaturdayTime = new System.Windows.Forms.MaskedTextBox();
            this.stopFridayKind = new System.Windows.Forms.ComboBox();
            this.stopFridayTime = new System.Windows.Forms.MaskedTextBox();
            this.stopThursdayKind = new System.Windows.Forms.ComboBox();
            this.stopThursdayTime = new System.Windows.Forms.MaskedTextBox();
            this.stopWednesdayKind = new System.Windows.Forms.ComboBox();
            this.stopWednesdayTime = new System.Windows.Forms.MaskedTextBox();
            this.stopTuesdayKind = new System.Windows.Forms.ComboBox();
            this.stopTuesdayTime = new System.Windows.Forms.MaskedTextBox();
            this.stopMondayKind = new System.Windows.Forms.ComboBox();
            this.stopMondayTime = new System.Windows.Forms.MaskedTextBox();
            this.saveScheduleButton = new System.Windows.Forms.Button();
            this.startSundayKind = new System.Windows.Forms.ComboBox();
            this.startSundayTime = new System.Windows.Forms.MaskedTextBox();
            this.startSaturdayKind = new System.Windows.Forms.ComboBox();
            this.startSaturdayTime = new System.Windows.Forms.MaskedTextBox();
            this.startFridayKind = new System.Windows.Forms.ComboBox();
            this.startFridayTime = new System.Windows.Forms.MaskedTextBox();
            this.startThursdayKind = new System.Windows.Forms.ComboBox();
            this.startThursdayTime = new System.Windows.Forms.MaskedTextBox();
            this.startWednesdayKind = new System.Windows.Forms.ComboBox();
            this.startWednesdayTime = new System.Windows.Forms.MaskedTextBox();
            this.startTuesdayKind = new System.Windows.Forms.ComboBox();
            this.startTuesdayTime = new System.Windows.Forms.MaskedTextBox();
            this.startMondayKind = new System.Windows.Forms.ComboBox();
            this.startMondayTime = new System.Windows.Forms.MaskedTextBox();
            this.sundaLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.scheduledEmployeeList = new System.Windows.Forms.ListBox();
            this.customerPage = new System.Windows.Forms.TabPage();
            this.cPrintButton = new System.Windows.Forms.Button();
            this.cSaveCustomer = new System.Windows.Forms.Button();
            this.cTimeCombo = new System.Windows.Forms.ComboBox();
            this.cTimeMasked = new System.Windows.Forms.MaskedTextBox();
            this.cStartEndLabel = new System.Windows.Forms.Label();
            this.cDateMasked = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cLastNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cFirstNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.newCustomer = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.employeePage.SuspendLayout();
            this.schedulePage.SuspendLayout();
            this.customerPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.BackColor = System.Drawing.Color.Silver;
            this.employeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeList.FormattingEnabled = true;
            this.employeeList.ItemHeight = 20;
            this.employeeList.Location = new System.Drawing.Point(0, 0);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(268, 575);
            this.employeeList.TabIndex = 0;
            this.employeeList.TabStop = false;
            this.employeeList.SelectedIndexChanged += new System.EventHandler(this.employeeSelected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.employeeList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 575);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.deleteEmployee);
            this.panel2.Controls.Add(this.newEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 47);
            this.panel2.TabIndex = 2;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Location = new System.Drawing.Point(137, 7);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(118, 32);
            this.deleteEmployee.TabIndex = 1;
            this.deleteEmployee.TabStop = false;
            this.deleteEmployee.Text = "Delete";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // newEmployee
            // 
            this.newEmployee.Location = new System.Drawing.Point(12, 7);
            this.newEmployee.Name = "newEmployee";
            this.newEmployee.Size = new System.Drawing.Size(93, 32);
            this.newEmployee.TabIndex = 0;
            this.newEmployee.TabStop = false;
            this.newEmployee.Text = "New";
            this.newEmployee.UseVisualStyleBackColor = true;
            this.newEmployee.Click += new System.EventHandler(this.newEmployee_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.employeePage);
            this.tabControl1.Controls.Add(this.schedulePage);
            this.tabControl1.Controls.Add(this.customerPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 615);
            this.tabControl1.TabIndex = 22;
            // 
            // employeePage
            // 
            this.employeePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeePage.BackgroundImage")));
            this.employeePage.Controls.Add(this.eLastNameBox);
            this.employeePage.Controls.Add(this.label9);
            this.employeePage.Controls.Add(this.eStateCombo);
            this.employeePage.Controls.Add(this.eZipCodeMasked);
            this.employeePage.Controls.Add(this.eCityBox);
            this.employeePage.Controls.Add(this.ePhoneMasked);
            this.employeePage.Controls.Add(this.eDobMasked);
            this.employeePage.Controls.Add(this.eStreetBox);
            this.employeePage.Controls.Add(this.eFirstNameBox);
            this.employeePage.Controls.Add(this.label3);
            this.employeePage.Controls.Add(this.label8);
            this.employeePage.Controls.Add(this.saveEmployee);
            this.employeePage.Controls.Add(this.label1);
            this.employeePage.Controls.Add(this.label7);
            this.employeePage.Controls.Add(this.label2);
            this.employeePage.Controls.Add(this.label6);
            this.employeePage.Controls.Add(this.label4);
            this.employeePage.Controls.Add(this.panel1);
            this.employeePage.Location = new System.Drawing.Point(4, 30);
            this.employeePage.Name = "employeePage";
            this.employeePage.Padding = new System.Windows.Forms.Padding(3);
            this.employeePage.Size = new System.Drawing.Size(1187, 581);
            this.employeePage.TabIndex = 0;
            this.employeePage.Text = "Employees";
            this.employeePage.UseVisualStyleBackColor = true;
            // 
            // eLastNameBox
            // 
            this.eLastNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eLastNameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.eLastNameBox.Location = new System.Drawing.Point(534, 111);
            this.eLastNameBox.MaximumSize = new System.Drawing.Size(368, 29);
            this.eLastNameBox.Name = "eLastNameBox";
            this.eLastNameBox.Size = new System.Drawing.Size(368, 29);
            this.eLastNameBox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(442, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 39;
            this.label9.Text = "Last Name:";
            // 
            // eStateCombo
            // 
            this.eStateCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eStateCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.eStateCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.eStateCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.eStateCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.eStateCombo.FormattingEnabled = true;
            this.eStateCombo.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.eStateCombo.Location = new System.Drawing.Point(534, 340);
            this.eStateCombo.MaximumSize = new System.Drawing.Size(368, 0);
            this.eStateCombo.Name = "eStateCombo";
            this.eStateCombo.Size = new System.Drawing.Size(368, 29);
            this.eStateCombo.TabIndex = 33;
            // 
            // eZipCodeMasked
            // 
            this.eZipCodeMasked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eZipCodeMasked.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.eZipCodeMasked.Location = new System.Drawing.Point(534, 385);
            this.eZipCodeMasked.Mask = "00000";
            this.eZipCodeMasked.MaximumSize = new System.Drawing.Size(368, 29);
            this.eZipCodeMasked.Name = "eZipCodeMasked";
            this.eZipCodeMasked.Size = new System.Drawing.Size(368, 29);
            this.eZipCodeMasked.TabIndex = 35;
            // 
            // eCityBox
            // 
            this.eCityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eCityBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.eCityBox.Location = new System.Drawing.Point(534, 295);
            this.eCityBox.MaximumSize = new System.Drawing.Size(368, 29);
            this.eCityBox.Name = "eCityBox";
            this.eCityBox.Size = new System.Drawing.Size(368, 29);
            this.eCityBox.TabIndex = 31;
            // 
            // ePhoneMasked
            // 
            this.ePhoneMasked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ePhoneMasked.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ePhoneMasked.Location = new System.Drawing.Point(534, 202);
            this.ePhoneMasked.Mask = "(999) 000-0000";
            this.ePhoneMasked.MaximumSize = new System.Drawing.Size(368, 29);
            this.ePhoneMasked.Name = "ePhoneMasked";
            this.ePhoneMasked.Size = new System.Drawing.Size(368, 29);
            this.ePhoneMasked.TabIndex = 27;
            // 
            // eDobMasked
            // 
            this.eDobMasked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eDobMasked.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.eDobMasked.Location = new System.Drawing.Point(534, 157);
            this.eDobMasked.Mask = "00/00/0000";
            this.eDobMasked.MaximumSize = new System.Drawing.Size(368, 29);
            this.eDobMasked.Name = "eDobMasked";
            this.eDobMasked.Size = new System.Drawing.Size(368, 29);
            this.eDobMasked.TabIndex = 25;
            this.eDobMasked.ValidatingType = typeof(System.DateTime);
            // 
            // eStreetBox
            // 
            this.eStreetBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eStreetBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.eStreetBox.Location = new System.Drawing.Point(534, 247);
            this.eStreetBox.MaximumSize = new System.Drawing.Size(368, 29);
            this.eStreetBox.Name = "eStreetBox";
            this.eStreetBox.Size = new System.Drawing.Size(368, 29);
            this.eStreetBox.TabIndex = 29;
            // 
            // eFirstNameBox
            // 
            this.eFirstNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eFirstNameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.eFirstNameBox.Location = new System.Drawing.Point(534, 65);
            this.eFirstNameBox.MaximumSize = new System.Drawing.Size(368, 29);
            this.eFirstNameBox.Name = "eFirstNameBox";
            this.eFirstNameBox.Size = new System.Drawing.Size(368, 29);
            this.eFirstNameBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(417, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(455, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Zip Code:";
            // 
            // saveEmployee
            // 
            this.saveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEmployee.Location = new System.Drawing.Point(534, 466);
            this.saveEmployee.Name = "saveEmployee";
            this.saveEmployee.Size = new System.Drawing.Size(368, 44);
            this.saveEmployee.TabIndex = 22;
            this.saveEmployee.TabStop = false;
            this.saveEmployee.Text = "Save";
            this.saveEmployee.UseVisualStyleBackColor = true;
            this.saveEmployee.Click += new System.EventHandler(this.eSaveEmployee_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(442, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(482, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "State:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(485, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "DOB:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(491, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "City:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(477, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Street:";
            // 
            // schedulePage
            // 
            this.schedulePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("schedulePage.BackgroundImage")));
            this.schedulePage.Controls.Add(this.button1);
            this.schedulePage.Controls.Add(this.label13);
            this.schedulePage.Controls.Add(this.label12);
            this.schedulePage.Controls.Add(this.stopSundayKind);
            this.schedulePage.Controls.Add(this.stopSundayTime);
            this.schedulePage.Controls.Add(this.stopSaturdayKind);
            this.schedulePage.Controls.Add(this.stopSaturdayTime);
            this.schedulePage.Controls.Add(this.stopFridayKind);
            this.schedulePage.Controls.Add(this.stopFridayTime);
            this.schedulePage.Controls.Add(this.stopThursdayKind);
            this.schedulePage.Controls.Add(this.stopThursdayTime);
            this.schedulePage.Controls.Add(this.stopWednesdayKind);
            this.schedulePage.Controls.Add(this.stopWednesdayTime);
            this.schedulePage.Controls.Add(this.stopTuesdayKind);
            this.schedulePage.Controls.Add(this.stopTuesdayTime);
            this.schedulePage.Controls.Add(this.stopMondayKind);
            this.schedulePage.Controls.Add(this.stopMondayTime);
            this.schedulePage.Controls.Add(this.saveScheduleButton);
            this.schedulePage.Controls.Add(this.startSundayKind);
            this.schedulePage.Controls.Add(this.startSundayTime);
            this.schedulePage.Controls.Add(this.startSaturdayKind);
            this.schedulePage.Controls.Add(this.startSaturdayTime);
            this.schedulePage.Controls.Add(this.startFridayKind);
            this.schedulePage.Controls.Add(this.startFridayTime);
            this.schedulePage.Controls.Add(this.startThursdayKind);
            this.schedulePage.Controls.Add(this.startThursdayTime);
            this.schedulePage.Controls.Add(this.startWednesdayKind);
            this.schedulePage.Controls.Add(this.startWednesdayTime);
            this.schedulePage.Controls.Add(this.startTuesdayKind);
            this.schedulePage.Controls.Add(this.startTuesdayTime);
            this.schedulePage.Controls.Add(this.startMondayKind);
            this.schedulePage.Controls.Add(this.startMondayTime);
            this.schedulePage.Controls.Add(this.sundaLabel);
            this.schedulePage.Controls.Add(this.saturdayLabel);
            this.schedulePage.Controls.Add(this.fridayLabel);
            this.schedulePage.Controls.Add(this.thursdayLabel);
            this.schedulePage.Controls.Add(this.wednesdayLabel);
            this.schedulePage.Controls.Add(this.tuesdayLabel);
            this.schedulePage.Controls.Add(this.mondayLabel);
            this.schedulePage.Controls.Add(this.scheduledEmployeeList);
            this.schedulePage.Location = new System.Drawing.Point(4, 30);
            this.schedulePage.Name = "schedulePage";
            this.schedulePage.Size = new System.Drawing.Size(1187, 581);
            this.schedulePage.TabIndex = 2;
            this.schedulePage.Text = "Schedule";
            this.schedulePage.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 21);
            this.label13.TabIndex = 82;
            this.label13.Text = "Stop Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 81;
            this.label12.Text = "Start Time:";
            // 
            // stopSundayKind
            // 
            this.stopSundayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopSundayKind.FormattingEnabled = true;
            this.stopSundayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.stopSundayKind.Location = new System.Drawing.Point(1082, 183);
            this.stopSundayKind.Name = "stopSundayKind";
            this.stopSundayKind.Size = new System.Drawing.Size(50, 29);
            this.stopSundayKind.TabIndex = 80;
            // 
            // stopSundayTime
            // 
            this.stopSundayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopSundayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopSundayTime.Location = new System.Drawing.Point(1032, 183);
            this.stopSundayTime.Mask = "90:00";
            this.stopSundayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.stopSundayTime.Name = "stopSundayTime";
            this.stopSundayTime.Size = new System.Drawing.Size(50, 29);
            this.stopSundayTime.TabIndex = 79;
            this.stopSundayTime.ValidatingType = typeof(System.DateTime);
            // 
            // stopSaturdayKind
            // 
            this.stopSaturdayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopSaturdayKind.FormattingEnabled = true;
            this.stopSaturdayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.stopSaturdayKind.Location = new System.Drawing.Point(964, 183);
            this.stopSaturdayKind.Name = "stopSaturdayKind";
            this.stopSaturdayKind.Size = new System.Drawing.Size(50, 29);
            this.stopSaturdayKind.TabIndex = 78;
            // 
            // stopSaturdayTime
            // 
            this.stopSaturdayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopSaturdayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopSaturdayTime.Location = new System.Drawing.Point(914, 183);
            this.stopSaturdayTime.Mask = "90:00";
            this.stopSaturdayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.stopSaturdayTime.Name = "stopSaturdayTime";
            this.stopSaturdayTime.Size = new System.Drawing.Size(50, 29);
            this.stopSaturdayTime.TabIndex = 77;
            this.stopSaturdayTime.ValidatingType = typeof(System.DateTime);
            // 
            // stopFridayKind
            // 
            this.stopFridayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopFridayKind.FormattingEnabled = true;
            this.stopFridayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.stopFridayKind.Location = new System.Drawing.Point(846, 183);
            this.stopFridayKind.Name = "stopFridayKind";
            this.stopFridayKind.Size = new System.Drawing.Size(50, 29);
            this.stopFridayKind.TabIndex = 76;
            // 
            // stopFridayTime
            // 
            this.stopFridayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopFridayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopFridayTime.Location = new System.Drawing.Point(796, 183);
            this.stopFridayTime.Mask = "90:00";
            this.stopFridayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.stopFridayTime.Name = "stopFridayTime";
            this.stopFridayTime.Size = new System.Drawing.Size(50, 29);
            this.stopFridayTime.TabIndex = 75;
            this.stopFridayTime.ValidatingType = typeof(System.DateTime);
            // 
            // stopThursdayKind
            // 
            this.stopThursdayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopThursdayKind.FormattingEnabled = true;
            this.stopThursdayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.stopThursdayKind.Location = new System.Drawing.Point(728, 183);
            this.stopThursdayKind.Name = "stopThursdayKind";
            this.stopThursdayKind.Size = new System.Drawing.Size(50, 29);
            this.stopThursdayKind.TabIndex = 74;
            // 
            // stopThursdayTime
            // 
            this.stopThursdayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopThursdayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopThursdayTime.Location = new System.Drawing.Point(678, 183);
            this.stopThursdayTime.Mask = "90:00";
            this.stopThursdayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.stopThursdayTime.Name = "stopThursdayTime";
            this.stopThursdayTime.Size = new System.Drawing.Size(50, 29);
            this.stopThursdayTime.TabIndex = 73;
            this.stopThursdayTime.ValidatingType = typeof(System.DateTime);
            // 
            // stopWednesdayKind
            // 
            this.stopWednesdayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopWednesdayKind.FormattingEnabled = true;
            this.stopWednesdayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.stopWednesdayKind.Location = new System.Drawing.Point(610, 183);
            this.stopWednesdayKind.Name = "stopWednesdayKind";
            this.stopWednesdayKind.Size = new System.Drawing.Size(50, 29);
            this.stopWednesdayKind.TabIndex = 72;
            // 
            // stopWednesdayTime
            // 
            this.stopWednesdayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopWednesdayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopWednesdayTime.Location = new System.Drawing.Point(560, 183);
            this.stopWednesdayTime.Mask = "90:00";
            this.stopWednesdayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.stopWednesdayTime.Name = "stopWednesdayTime";
            this.stopWednesdayTime.Size = new System.Drawing.Size(50, 29);
            this.stopWednesdayTime.TabIndex = 71;
            this.stopWednesdayTime.ValidatingType = typeof(System.DateTime);
            // 
            // stopTuesdayKind
            // 
            this.stopTuesdayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopTuesdayKind.FormattingEnabled = true;
            this.stopTuesdayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.stopTuesdayKind.Location = new System.Drawing.Point(492, 183);
            this.stopTuesdayKind.Name = "stopTuesdayKind";
            this.stopTuesdayKind.Size = new System.Drawing.Size(50, 29);
            this.stopTuesdayKind.TabIndex = 70;
            // 
            // stopTuesdayTime
            // 
            this.stopTuesdayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopTuesdayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopTuesdayTime.Location = new System.Drawing.Point(442, 183);
            this.stopTuesdayTime.Mask = "90:00";
            this.stopTuesdayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.stopTuesdayTime.Name = "stopTuesdayTime";
            this.stopTuesdayTime.Size = new System.Drawing.Size(50, 29);
            this.stopTuesdayTime.TabIndex = 69;
            this.stopTuesdayTime.ValidatingType = typeof(System.DateTime);
            // 
            // stopMondayKind
            // 
            this.stopMondayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopMondayKind.FormattingEnabled = true;
            this.stopMondayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.stopMondayKind.Location = new System.Drawing.Point(374, 183);
            this.stopMondayKind.Name = "stopMondayKind";
            this.stopMondayKind.Size = new System.Drawing.Size(50, 29);
            this.stopMondayKind.TabIndex = 68;
            // 
            // stopMondayTime
            // 
            this.stopMondayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopMondayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopMondayTime.Location = new System.Drawing.Point(324, 183);
            this.stopMondayTime.Mask = "90:00";
            this.stopMondayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.stopMondayTime.Name = "stopMondayTime";
            this.stopMondayTime.Size = new System.Drawing.Size(50, 29);
            this.stopMondayTime.TabIndex = 67;
            this.stopMondayTime.ValidatingType = typeof(System.DateTime);
            // 
            // saveScheduleButton
            // 
            this.saveScheduleButton.Location = new System.Drawing.Point(595, 343);
            this.saveScheduleButton.Name = "saveScheduleButton";
            this.saveScheduleButton.Size = new System.Drawing.Size(218, 40);
            this.saveScheduleButton.TabIndex = 66;
            this.saveScheduleButton.Text = "SAVE";
            this.saveScheduleButton.UseVisualStyleBackColor = true;
            this.saveScheduleButton.Click += new System.EventHandler(this.saveScheduleButton_Click);
            // 
            // startSundayKind
            // 
            this.startSundayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startSundayKind.FormattingEnabled = true;
            this.startSundayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startSundayKind.Location = new System.Drawing.Point(1082, 148);
            this.startSundayKind.Name = "startSundayKind";
            this.startSundayKind.Size = new System.Drawing.Size(50, 29);
            this.startSundayKind.TabIndex = 65;
            // 
            // startSundayTime
            // 
            this.startSundayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startSundayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startSundayTime.Location = new System.Drawing.Point(1032, 148);
            this.startSundayTime.Mask = "90:00";
            this.startSundayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.startSundayTime.Name = "startSundayTime";
            this.startSundayTime.Size = new System.Drawing.Size(50, 29);
            this.startSundayTime.TabIndex = 64;
            this.startSundayTime.ValidatingType = typeof(System.DateTime);
            // 
            // startSaturdayKind
            // 
            this.startSaturdayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startSaturdayKind.FormattingEnabled = true;
            this.startSaturdayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startSaturdayKind.Location = new System.Drawing.Point(964, 148);
            this.startSaturdayKind.Name = "startSaturdayKind";
            this.startSaturdayKind.Size = new System.Drawing.Size(50, 29);
            this.startSaturdayKind.TabIndex = 63;
            // 
            // startSaturdayTime
            // 
            this.startSaturdayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startSaturdayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startSaturdayTime.Location = new System.Drawing.Point(914, 148);
            this.startSaturdayTime.Mask = "90:00";
            this.startSaturdayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.startSaturdayTime.Name = "startSaturdayTime";
            this.startSaturdayTime.Size = new System.Drawing.Size(50, 29);
            this.startSaturdayTime.TabIndex = 62;
            this.startSaturdayTime.ValidatingType = typeof(System.DateTime);
            // 
            // startFridayKind
            // 
            this.startFridayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startFridayKind.FormattingEnabled = true;
            this.startFridayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startFridayKind.Location = new System.Drawing.Point(846, 148);
            this.startFridayKind.Name = "startFridayKind";
            this.startFridayKind.Size = new System.Drawing.Size(50, 29);
            this.startFridayKind.TabIndex = 61;
            // 
            // startFridayTime
            // 
            this.startFridayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startFridayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startFridayTime.Location = new System.Drawing.Point(796, 148);
            this.startFridayTime.Mask = "90:00";
            this.startFridayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.startFridayTime.Name = "startFridayTime";
            this.startFridayTime.Size = new System.Drawing.Size(50, 29);
            this.startFridayTime.TabIndex = 60;
            this.startFridayTime.ValidatingType = typeof(System.DateTime);
            // 
            // startThursdayKind
            // 
            this.startThursdayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startThursdayKind.FormattingEnabled = true;
            this.startThursdayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startThursdayKind.Location = new System.Drawing.Point(728, 148);
            this.startThursdayKind.Name = "startThursdayKind";
            this.startThursdayKind.Size = new System.Drawing.Size(50, 29);
            this.startThursdayKind.TabIndex = 59;
            // 
            // startThursdayTime
            // 
            this.startThursdayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startThursdayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startThursdayTime.Location = new System.Drawing.Point(678, 148);
            this.startThursdayTime.Mask = "90:00";
            this.startThursdayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.startThursdayTime.Name = "startThursdayTime";
            this.startThursdayTime.Size = new System.Drawing.Size(50, 29);
            this.startThursdayTime.TabIndex = 58;
            this.startThursdayTime.ValidatingType = typeof(System.DateTime);
            // 
            // startWednesdayKind
            // 
            this.startWednesdayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startWednesdayKind.FormattingEnabled = true;
            this.startWednesdayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startWednesdayKind.Location = new System.Drawing.Point(610, 148);
            this.startWednesdayKind.Name = "startWednesdayKind";
            this.startWednesdayKind.Size = new System.Drawing.Size(50, 29);
            this.startWednesdayKind.TabIndex = 57;
            // 
            // startWednesdayTime
            // 
            this.startWednesdayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startWednesdayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startWednesdayTime.Location = new System.Drawing.Point(560, 148);
            this.startWednesdayTime.Mask = "90:00";
            this.startWednesdayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.startWednesdayTime.Name = "startWednesdayTime";
            this.startWednesdayTime.Size = new System.Drawing.Size(50, 29);
            this.startWednesdayTime.TabIndex = 56;
            this.startWednesdayTime.ValidatingType = typeof(System.DateTime);
            // 
            // startTuesdayKind
            // 
            this.startTuesdayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startTuesdayKind.FormattingEnabled = true;
            this.startTuesdayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startTuesdayKind.Location = new System.Drawing.Point(492, 148);
            this.startTuesdayKind.Name = "startTuesdayKind";
            this.startTuesdayKind.Size = new System.Drawing.Size(50, 29);
            this.startTuesdayKind.TabIndex = 55;
            // 
            // startTuesdayTime
            // 
            this.startTuesdayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTuesdayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startTuesdayTime.Location = new System.Drawing.Point(442, 148);
            this.startTuesdayTime.Mask = "90:00";
            this.startTuesdayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.startTuesdayTime.Name = "startTuesdayTime";
            this.startTuesdayTime.Size = new System.Drawing.Size(50, 29);
            this.startTuesdayTime.TabIndex = 54;
            this.startTuesdayTime.ValidatingType = typeof(System.DateTime);
            // 
            // startMondayKind
            // 
            this.startMondayKind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startMondayKind.FormattingEnabled = true;
            this.startMondayKind.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startMondayKind.Location = new System.Drawing.Point(374, 148);
            this.startMondayKind.Name = "startMondayKind";
            this.startMondayKind.Size = new System.Drawing.Size(50, 29);
            this.startMondayKind.TabIndex = 53;
            // 
            // startMondayTime
            // 
            this.startMondayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startMondayTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startMondayTime.Location = new System.Drawing.Point(324, 148);
            this.startMondayTime.Mask = "90:00";
            this.startMondayTime.MaximumSize = new System.Drawing.Size(368, 29);
            this.startMondayTime.Name = "startMondayTime";
            this.startMondayTime.Size = new System.Drawing.Size(50, 29);
            this.startMondayTime.TabIndex = 52;
            this.startMondayTime.ValidatingType = typeof(System.DateTime);
            // 
            // sundaLabel
            // 
            this.sundaLabel.AutoSize = true;
            this.sundaLabel.Location = new System.Drawing.Point(1051, 104);
            this.sundaLabel.Name = "sundaLabel";
            this.sundaLabel.Size = new System.Drawing.Size(62, 21);
            this.sundaLabel.TabIndex = 7;
            this.sundaLabel.Text = "Sunday";
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Location = new System.Drawing.Point(927, 104);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(72, 21);
            this.saturdayLabel.TabIndex = 6;
            this.saturdayLabel.Text = "Saturday";
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Location = new System.Drawing.Point(820, 104);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(53, 21);
            this.fridayLabel.TabIndex = 5;
            this.fridayLabel.Text = "Friday";
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.Location = new System.Drawing.Point(691, 104);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(74, 21);
            this.thursdayLabel.TabIndex = 4;
            this.thursdayLabel.Text = "Thursday";
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.Location = new System.Drawing.Point(565, 104);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(90, 21);
            this.wednesdayLabel.TabIndex = 3;
            this.wednesdayLabel.Text = "Wednesday";
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Location = new System.Drawing.Point(461, 104);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(67, 21);
            this.tuesdayLabel.TabIndex = 2;
            this.tuesdayLabel.Text = "Tuesday";
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Location = new System.Drawing.Point(341, 104);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(67, 21);
            this.mondayLabel.TabIndex = 1;
            this.mondayLabel.Text = "Monday";
            // 
            // scheduledEmployeeList
            // 
            this.scheduledEmployeeList.BackColor = System.Drawing.Color.Silver;
            this.scheduledEmployeeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduledEmployeeList.FormattingEnabled = true;
            this.scheduledEmployeeList.ItemHeight = 21;
            this.scheduledEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.scheduledEmployeeList.Name = "scheduledEmployeeList";
            this.scheduledEmployeeList.Size = new System.Drawing.Size(229, 581);
            this.scheduledEmployeeList.TabIndex = 0;
            this.scheduledEmployeeList.SelectedValueChanged += new System.EventHandler(this.scheduledEmployeeList_SelectedValueChanged);
            // 
            // customerPage
            // 
            this.customerPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerPage.BackgroundImage")));
            this.customerPage.Controls.Add(this.cPrintButton);
            this.customerPage.Controls.Add(this.cSaveCustomer);
            this.customerPage.Controls.Add(this.cTimeCombo);
            this.customerPage.Controls.Add(this.cTimeMasked);
            this.customerPage.Controls.Add(this.cStartEndLabel);
            this.customerPage.Controls.Add(this.cDateMasked);
            this.customerPage.Controls.Add(this.label11);
            this.customerPage.Controls.Add(this.cLastNameBox);
            this.customerPage.Controls.Add(this.label5);
            this.customerPage.Controls.Add(this.cFirstNameBox);
            this.customerPage.Controls.Add(this.label10);
            this.customerPage.Controls.Add(this.panel3);
            this.customerPage.Location = new System.Drawing.Point(4, 30);
            this.customerPage.Name = "customerPage";
            this.customerPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerPage.Size = new System.Drawing.Size(1187, 581);
            this.customerPage.TabIndex = 1;
            this.customerPage.Text = "Customers";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // cPrintButton
            // 
            this.cPrintButton.Location = new System.Drawing.Point(1014, 535);
            this.cPrintButton.Name = "cPrintButton";
            this.cPrintButton.Size = new System.Drawing.Size(165, 38);
            this.cPrintButton.TabIndex = 53;
            this.cPrintButton.Text = "Print Customers";
            this.cPrintButton.UseVisualStyleBackColor = true;
            this.cPrintButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cSaveCustomer
            // 
            this.cSaveCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cSaveCustomer.Location = new System.Drawing.Point(576, 368);
            this.cSaveCustomer.Name = "cSaveCustomer";
            this.cSaveCustomer.Size = new System.Drawing.Size(368, 38);
            this.cSaveCustomer.TabIndex = 52;
            this.cSaveCustomer.Text = "Save";
            this.cSaveCustomer.UseVisualStyleBackColor = true;
            this.cSaveCustomer.Click += new System.EventHandler(this.cSaveCustomer_Click);
            // 
            // cTimeCombo
            // 
            this.cTimeCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cTimeCombo.FormattingEnabled = true;
            this.cTimeCombo.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cTimeCombo.Location = new System.Drawing.Point(764, 306);
            this.cTimeCombo.Name = "cTimeCombo";
            this.cTimeCombo.Size = new System.Drawing.Size(57, 29);
            this.cTimeCombo.TabIndex = 51;
            // 
            // cTimeMasked
            // 
            this.cTimeMasked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTimeMasked.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cTimeMasked.Location = new System.Drawing.Point(689, 306);
            this.cTimeMasked.Mask = "90:00";
            this.cTimeMasked.MaximumSize = new System.Drawing.Size(368, 29);
            this.cTimeMasked.Name = "cTimeMasked";
            this.cTimeMasked.Size = new System.Drawing.Size(69, 29);
            this.cTimeMasked.TabIndex = 49;
            this.cTimeMasked.ValidatingType = typeof(System.DateTime);
            // 
            // cStartEndLabel
            // 
            this.cStartEndLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cStartEndLabel.AutoSize = true;
            this.cStartEndLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cStartEndLabel.Location = new System.Drawing.Point(524, 309);
            this.cStartEndLabel.Name = "cStartEndLabel";
            this.cStartEndLabel.Size = new System.Drawing.Size(47, 21);
            this.cStartEndLabel.TabIndex = 50;
            this.cStartEndLabel.Text = "Time:";
            // 
            // cDateMasked
            // 
            this.cDateMasked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cDateMasked.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cDateMasked.Location = new System.Drawing.Point(576, 248);
            this.cDateMasked.Mask = "00/00/0000";
            this.cDateMasked.MaximumSize = new System.Drawing.Size(368, 29);
            this.cDateMasked.Name = "cDateMasked";
            this.cDateMasked.Size = new System.Drawing.Size(368, 29);
            this.cDateMasked.TabIndex = 45;
            this.cDateMasked.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.Location = new System.Drawing.Point(526, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 21);
            this.label11.TabIndex = 46;
            this.label11.Text = "Date:";
            // 
            // cLastNameBox
            // 
            this.cLastNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cLastNameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cLastNameBox.Location = new System.Drawing.Point(576, 196);
            this.cLastNameBox.MaximumSize = new System.Drawing.Size(368, 29);
            this.cLastNameBox.Name = "cLastNameBox";
            this.cLastNameBox.Size = new System.Drawing.Size(368, 29);
            this.cLastNameBox.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(484, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Last Name:";
            // 
            // cFirstNameBox
            // 
            this.cFirstNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cFirstNameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cFirstNameBox.Location = new System.Drawing.Point(576, 150);
            this.cFirstNameBox.MaximumSize = new System.Drawing.Size(368, 29);
            this.cFirstNameBox.Name = "cFirstNameBox";
            this.cFirstNameBox.Size = new System.Drawing.Size(368, 29);
            this.cFirstNameBox.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(484, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 42;
            this.label10.Text = "First Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customerList);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 575);
            this.panel3.TabIndex = 3;
            // 
            // customerList
            // 
            this.customerList.BackColor = System.Drawing.Color.Silver;
            this.customerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.customerList.FormattingEnabled = true;
            this.customerList.ItemHeight = 21;
            this.customerList.Location = new System.Drawing.Point(0, 0);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(281, 519);
            this.customerList.TabIndex = 1;
            this.customerList.SelectedValueChanged += new System.EventHandler(this.customerSelected);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deleteCustomer);
            this.panel4.Controls.Add(this.newCustomer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 519);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 56);
            this.panel4.TabIndex = 0;
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.deleteCustomer.Location = new System.Drawing.Point(163, 10);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(111, 35);
            this.deleteCustomer.TabIndex = 2;
            this.deleteCustomer.TabStop = false;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // newCustomer
            // 
            this.newCustomer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newCustomer.Location = new System.Drawing.Point(5, 10);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(106, 35);
            this.newCustomer.TabIndex = 1;
            this.newCustomer.TabStop = false;
            this.newCustomer.Text = "New";
            this.newCustomer.UseVisualStyleBackColor = true;
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1032, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 83;
            this.button1.Text = "Print Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1195, 615);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1211, 654);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pinhouse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.employeePage.ResumeLayout(false);
            this.employeePage.PerformLayout();
            this.schedulePage.ResumeLayout(false);
            this.schedulePage.PerformLayout();
            this.customerPage.ResumeLayout(false);
            this.customerPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox employeeList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newEmployee;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeePage;
        private System.Windows.Forms.TextBox eLastNameBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox eStateCombo;
        private System.Windows.Forms.MaskedTextBox eZipCodeMasked;
        private System.Windows.Forms.TextBox eCityBox;
        private System.Windows.Forms.MaskedTextBox ePhoneMasked;
        private System.Windows.Forms.MaskedTextBox eDobMasked;
        private System.Windows.Forms.TextBox eStreetBox;
        private System.Windows.Forms.TextBox eFirstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage customerPage;
        private System.Windows.Forms.TextBox cLastNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cFirstNameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox customerList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button newCustomer;
        private System.Windows.Forms.MaskedTextBox cDateMasked;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox cTimeMasked;
        private System.Windows.Forms.Label cStartEndLabel;
        private System.Windows.Forms.ComboBox cTimeCombo;
        private System.Windows.Forms.Button cSaveCustomer;
        private System.Windows.Forms.Button cPrintButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TabPage schedulePage;
        private System.Windows.Forms.ListBox scheduledEmployeeList;
        private System.Windows.Forms.Label sundaLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.ComboBox startMondayKind;
        private System.Windows.Forms.MaskedTextBox startMondayTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox stopSundayKind;
        private System.Windows.Forms.MaskedTextBox stopSundayTime;
        private System.Windows.Forms.ComboBox stopSaturdayKind;
        private System.Windows.Forms.MaskedTextBox stopSaturdayTime;
        private System.Windows.Forms.ComboBox stopFridayKind;
        private System.Windows.Forms.MaskedTextBox stopFridayTime;
        private System.Windows.Forms.ComboBox stopThursdayKind;
        private System.Windows.Forms.MaskedTextBox stopThursdayTime;
        private System.Windows.Forms.ComboBox stopWednesdayKind;
        private System.Windows.Forms.MaskedTextBox stopWednesdayTime;
        private System.Windows.Forms.ComboBox stopTuesdayKind;
        private System.Windows.Forms.MaskedTextBox stopTuesdayTime;
        private System.Windows.Forms.ComboBox stopMondayKind;
        private System.Windows.Forms.MaskedTextBox stopMondayTime;
        private System.Windows.Forms.Button saveScheduleButton;
        private System.Windows.Forms.ComboBox startSundayKind;
        private System.Windows.Forms.MaskedTextBox startSundayTime;
        private System.Windows.Forms.ComboBox startSaturdayKind;
        private System.Windows.Forms.MaskedTextBox startSaturdayTime;
        private System.Windows.Forms.ComboBox startFridayKind;
        private System.Windows.Forms.MaskedTextBox startFridayTime;
        private System.Windows.Forms.ComboBox startThursdayKind;
        private System.Windows.Forms.MaskedTextBox startThursdayTime;
        private System.Windows.Forms.ComboBox startWednesdayKind;
        private System.Windows.Forms.MaskedTextBox startWednesdayTime;
        private System.Windows.Forms.ComboBox startTuesdayKind;
        private System.Windows.Forms.MaskedTextBox startTuesdayTime;
        private System.Windows.Forms.Button button1;
    }
}

