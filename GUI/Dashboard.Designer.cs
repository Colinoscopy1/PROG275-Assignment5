
namespace GUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblMessages = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.lblNewTicketPriority = new System.Windows.Forms.Label();
            this.cmbNewTicketPriority = new System.Windows.Forms.ComboBox();
            this.lblNewTicketAssignedTo = new System.Windows.Forms.Label();
            this.cmbNewTicketAssignedTo = new System.Windows.Forms.ComboBox();
            this.lblNewTicketStatus = new System.Windows.Forms.Label();
            this.cmbNewTicketStatus = new System.Windows.Forms.ComboBox();
            this.lblNewTicketType = new System.Windows.Forms.Label();
            this.cmbNewTicketType = new System.Windows.Forms.ComboBox();
            this.lblNewTicketDescription = new System.Windows.Forms.Label();
            this.txtNewTicketDescription = new System.Windows.Forms.TextBox();
            this.lblCreateNewTicket = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageToSend = new System.Windows.Forms.TextBox();
            this.lstDMs = new System.Windows.Forms.ListBox();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabMyTickets = new System.Windows.Forms.TabPage();
            this.lblMyTicketPriority = new System.Windows.Forms.Label();
            this.cmbMyTicketPriority = new System.Windows.Forms.ComboBox();
            this.btnUpdateMyTicket = new System.Windows.Forms.Button();
            this.txtMyTicketAssignedTo = new System.Windows.Forms.Label();
            this.cmbMyTicketAssignedTo = new System.Windows.Forms.ComboBox();
            this.lblMyTicketStatus = new System.Windows.Forms.Label();
            this.cmbMyTicketStatus = new System.Windows.Forms.ComboBox();
            this.lblMyTicketType = new System.Windows.Forms.Label();
            this.cmbMyTicketType = new System.Windows.Forms.ComboBox();
            this.lblMyTicketNotes = new System.Windows.Forms.Label();
            this.txtMyTicketNotes = new System.Windows.Forms.TextBox();
            this.lblMyTicketDescription = new System.Windows.Forms.Label();
            this.txtMyTicketDescription = new System.Windows.Forms.TextBox();
            this.dgvMyTickets = new System.Windows.Forms.DataGridView();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShowPending = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblFilters = new System.Windows.Forms.Label();
            this.lblTicketPriority = new System.Windows.Forms.Label();
            this.cmbTicketPriority = new System.Windows.Forms.ComboBox();
            this.btnUpdateTIcket = new System.Windows.Forms.Button();
            this.lblTicketAssignedTo = new System.Windows.Forms.Label();
            this.cmbTicketAssignedTo = new System.Windows.Forms.ComboBox();
            this.lblTicketStatus = new System.Windows.Forms.Label();
            this.cmbTicketStatus = new System.Windows.Forms.ComboBox();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.cmbTicketType = new System.Windows.Forms.ComboBox();
            this.lblTicketNotes = new System.Windows.Forms.Label();
            this.txtTicketNotes = new System.Windows.Forms.TextBox();
            this.lblTicketDescription = new System.Windows.Forms.Label();
            this.txtTicketDescription = new System.Windows.Forms.TextBox();
            this.dgvAllTickets = new System.Windows.Forms.DataGridView();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnOpenCreateUserForm = new System.Windows.Forms.Button();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabMyTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTickets)).BeginInit();
            this.tabTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabMyTickets);
            this.tabControl1.Controls.Add(this.tabTickets);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 544);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.lblMessages);
            this.tabDashboard.Controls.Add(this.btnCreateTicket);
            this.tabDashboard.Controls.Add(this.lblNewTicketPriority);
            this.tabDashboard.Controls.Add(this.cmbNewTicketPriority);
            this.tabDashboard.Controls.Add(this.lblNewTicketAssignedTo);
            this.tabDashboard.Controls.Add(this.cmbNewTicketAssignedTo);
            this.tabDashboard.Controls.Add(this.lblNewTicketStatus);
            this.tabDashboard.Controls.Add(this.cmbNewTicketStatus);
            this.tabDashboard.Controls.Add(this.lblNewTicketType);
            this.tabDashboard.Controls.Add(this.cmbNewTicketType);
            this.tabDashboard.Controls.Add(this.lblNewTicketDescription);
            this.tabDashboard.Controls.Add(this.txtNewTicketDescription);
            this.tabDashboard.Controls.Add(this.lblCreateNewTicket);
            this.tabDashboard.Controls.Add(this.btnSend);
            this.tabDashboard.Controls.Add(this.txtMessageToSend);
            this.tabDashboard.Controls.Add(this.lstDMs);
            this.tabDashboard.Controls.Add(this.lstMessages);
            this.tabDashboard.Controls.Add(this.lblWelcome);
            this.tabDashboard.Location = new System.Drawing.Point(4, 24);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(1066, 516);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessages.Location = new System.Drawing.Point(569, 179);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(140, 28);
            this.lblMessages.TabIndex = 40;
            this.lblMessages.Text = "Your Messages";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(24, 390);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(396, 34);
            this.btnCreateTicket.TabIndex = 39;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // lblNewTicketPriority
            // 
            this.lblNewTicketPriority.AutoSize = true;
            this.lblNewTicketPriority.Location = new System.Drawing.Point(225, 299);
            this.lblNewTicketPriority.Name = "lblNewTicketPriority";
            this.lblNewTicketPriority.Size = new System.Drawing.Size(45, 15);
            this.lblNewTicketPriority.TabIndex = 38;
            this.lblNewTicketPriority.Text = "Priority";
            // 
            // cmbNewTicketPriority
            // 
            this.cmbNewTicketPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewTicketPriority.FormattingEnabled = true;
            this.cmbNewTicketPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "Moderate",
            "High",
            "Severe"});
            this.cmbNewTicketPriority.Location = new System.Drawing.Point(225, 317);
            this.cmbNewTicketPriority.Name = "cmbNewTicketPriority";
            this.cmbNewTicketPriority.Size = new System.Drawing.Size(195, 23);
            this.cmbNewTicketPriority.TabIndex = 37;
            // 
            // lblNewTicketAssignedTo
            // 
            this.lblNewTicketAssignedTo.AutoSize = true;
            this.lblNewTicketAssignedTo.Location = new System.Drawing.Point(225, 343);
            this.lblNewTicketAssignedTo.Name = "lblNewTicketAssignedTo";
            this.lblNewTicketAssignedTo.Size = new System.Drawing.Size(70, 15);
            this.lblNewTicketAssignedTo.TabIndex = 36;
            this.lblNewTicketAssignedTo.Text = "Assigned To";
            // 
            // cmbNewTicketAssignedTo
            // 
            this.cmbNewTicketAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewTicketAssignedTo.FormattingEnabled = true;
            this.cmbNewTicketAssignedTo.Location = new System.Drawing.Point(225, 361);
            this.cmbNewTicketAssignedTo.Name = "cmbNewTicketAssignedTo";
            this.cmbNewTicketAssignedTo.Size = new System.Drawing.Size(195, 23);
            this.cmbNewTicketAssignedTo.TabIndex = 35;
            // 
            // lblNewTicketStatus
            // 
            this.lblNewTicketStatus.AutoSize = true;
            this.lblNewTicketStatus.Location = new System.Drawing.Point(225, 255);
            this.lblNewTicketStatus.Name = "lblNewTicketStatus";
            this.lblNewTicketStatus.Size = new System.Drawing.Size(39, 15);
            this.lblNewTicketStatus.TabIndex = 34;
            this.lblNewTicketStatus.Text = "Status";
            // 
            // cmbNewTicketStatus
            // 
            this.cmbNewTicketStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewTicketStatus.FormattingEnabled = true;
            this.cmbNewTicketStatus.Items.AddRange(new object[] {
            "Pending",
            "Assigned",
            "Accepted",
            "Completed"});
            this.cmbNewTicketStatus.Location = new System.Drawing.Point(225, 273);
            this.cmbNewTicketStatus.Name = "cmbNewTicketStatus";
            this.cmbNewTicketStatus.Size = new System.Drawing.Size(195, 23);
            this.cmbNewTicketStatus.TabIndex = 33;
            // 
            // lblNewTicketType
            // 
            this.lblNewTicketType.AutoSize = true;
            this.lblNewTicketType.Location = new System.Drawing.Point(225, 211);
            this.lblNewTicketType.Name = "lblNewTicketType";
            this.lblNewTicketType.Size = new System.Drawing.Size(31, 15);
            this.lblNewTicketType.TabIndex = 32;
            this.lblNewTicketType.Text = "Type";
            // 
            // cmbNewTicketType
            // 
            this.cmbNewTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewTicketType.FormattingEnabled = true;
            this.cmbNewTicketType.Items.AddRange(new object[] {
            "Networking",
            "Software",
            "Updates",
            "Hardware",
            "Misc."});
            this.cmbNewTicketType.Location = new System.Drawing.Point(225, 229);
            this.cmbNewTicketType.Name = "cmbNewTicketType";
            this.cmbNewTicketType.Size = new System.Drawing.Size(195, 23);
            this.cmbNewTicketType.TabIndex = 31;
            // 
            // lblNewTicketDescription
            // 
            this.lblNewTicketDescription.AutoSize = true;
            this.lblNewTicketDescription.Location = new System.Drawing.Point(24, 206);
            this.lblNewTicketDescription.Name = "lblNewTicketDescription";
            this.lblNewTicketDescription.Size = new System.Drawing.Size(67, 15);
            this.lblNewTicketDescription.TabIndex = 28;
            this.lblNewTicketDescription.Text = "Description";
            // 
            // txtNewTicketDescription
            // 
            this.txtNewTicketDescription.Location = new System.Drawing.Point(24, 224);
            this.txtNewTicketDescription.Multiline = true;
            this.txtNewTicketDescription.Name = "txtNewTicketDescription";
            this.txtNewTicketDescription.Size = new System.Drawing.Size(195, 160);
            this.txtNewTicketDescription.TabIndex = 27;
            // 
            // lblCreateNewTicket
            // 
            this.lblCreateNewTicket.AutoSize = true;
            this.lblCreateNewTicket.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateNewTicket.Location = new System.Drawing.Point(24, 161);
            this.lblCreateNewTicket.Name = "lblCreateNewTicket";
            this.lblCreateNewTicket.Size = new System.Drawing.Size(188, 28);
            this.lblCreateNewTicket.TabIndex = 5;
            this.lblCreateNewTicket.Text = "Create a New Ticket ";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(942, 401);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(101, 24);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageToSend
            // 
            this.txtMessageToSend.Location = new System.Drawing.Point(754, 401);
            this.txtMessageToSend.Name = "txtMessageToSend";
            this.txtMessageToSend.Size = new System.Drawing.Size(182, 23);
            this.txtMessageToSend.TabIndex = 3;
            // 
            // lstDMs
            // 
            this.lstDMs.FormattingEnabled = true;
            this.lstDMs.ItemHeight = 15;
            this.lstDMs.Location = new System.Drawing.Point(569, 210);
            this.lstDMs.Name = "lstDMs";
            this.lstDMs.Size = new System.Drawing.Size(179, 214);
            this.lstDMs.TabIndex = 2;
            this.lstDMs.SelectedIndexChanged += new System.EventHandler(this.lstDMs_SelectedIndexChanged);
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 15;
            this.lstMessages.Location = new System.Drawing.Point(754, 210);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(289, 184);
            this.lstMessages.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(24, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(125, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // tabMyTickets
            // 
            this.tabMyTickets.Controls.Add(this.lblMyTicketPriority);
            this.tabMyTickets.Controls.Add(this.cmbMyTicketPriority);
            this.tabMyTickets.Controls.Add(this.btnUpdateMyTicket);
            this.tabMyTickets.Controls.Add(this.txtMyTicketAssignedTo);
            this.tabMyTickets.Controls.Add(this.cmbMyTicketAssignedTo);
            this.tabMyTickets.Controls.Add(this.lblMyTicketStatus);
            this.tabMyTickets.Controls.Add(this.cmbMyTicketStatus);
            this.tabMyTickets.Controls.Add(this.lblMyTicketType);
            this.tabMyTickets.Controls.Add(this.cmbMyTicketType);
            this.tabMyTickets.Controls.Add(this.lblMyTicketNotes);
            this.tabMyTickets.Controls.Add(this.txtMyTicketNotes);
            this.tabMyTickets.Controls.Add(this.lblMyTicketDescription);
            this.tabMyTickets.Controls.Add(this.txtMyTicketDescription);
            this.tabMyTickets.Controls.Add(this.dgvMyTickets);
            this.tabMyTickets.Location = new System.Drawing.Point(4, 24);
            this.tabMyTickets.Name = "tabMyTickets";
            this.tabMyTickets.Size = new System.Drawing.Size(1066, 516);
            this.tabMyTickets.TabIndex = 2;
            this.tabMyTickets.Text = "My Tickets";
            this.tabMyTickets.UseVisualStyleBackColor = true;
            // 
            // lblMyTicketPriority
            // 
            this.lblMyTicketPriority.AutoSize = true;
            this.lblMyTicketPriority.Location = new System.Drawing.Point(865, 366);
            this.lblMyTicketPriority.Name = "lblMyTicketPriority";
            this.lblMyTicketPriority.Size = new System.Drawing.Size(45, 15);
            this.lblMyTicketPriority.TabIndex = 26;
            this.lblMyTicketPriority.Text = "Priority";
            // 
            // cmbMyTicketPriority
            // 
            this.cmbMyTicketPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMyTicketPriority.FormattingEnabled = true;
            this.cmbMyTicketPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "Moderate",
            "High",
            "Severe"});
            this.cmbMyTicketPriority.Location = new System.Drawing.Point(865, 384);
            this.cmbMyTicketPriority.Name = "cmbMyTicketPriority";
            this.cmbMyTicketPriority.Size = new System.Drawing.Size(195, 23);
            this.cmbMyTicketPriority.TabIndex = 25;
            // 
            // btnUpdateMyTicket
            // 
            this.btnUpdateMyTicket.Location = new System.Drawing.Point(900, 464);
            this.btnUpdateMyTicket.Name = "btnUpdateMyTicket";
            this.btnUpdateMyTicket.Size = new System.Drawing.Size(124, 37);
            this.btnUpdateMyTicket.TabIndex = 24;
            this.btnUpdateMyTicket.Text = "Update Ticket";
            this.btnUpdateMyTicket.UseVisualStyleBackColor = true;
            this.btnUpdateMyTicket.Click += new System.EventHandler(this.btnUpdateMyTicket_Click);
            // 
            // txtMyTicketAssignedTo
            // 
            this.txtMyTicketAssignedTo.AutoSize = true;
            this.txtMyTicketAssignedTo.Location = new System.Drawing.Point(865, 410);
            this.txtMyTicketAssignedTo.Name = "txtMyTicketAssignedTo";
            this.txtMyTicketAssignedTo.Size = new System.Drawing.Size(70, 15);
            this.txtMyTicketAssignedTo.TabIndex = 23;
            this.txtMyTicketAssignedTo.Text = "Assigned To";
            // 
            // cmbMyTicketAssignedTo
            // 
            this.cmbMyTicketAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMyTicketAssignedTo.FormattingEnabled = true;
            this.cmbMyTicketAssignedTo.Location = new System.Drawing.Point(865, 428);
            this.cmbMyTicketAssignedTo.Name = "cmbMyTicketAssignedTo";
            this.cmbMyTicketAssignedTo.Size = new System.Drawing.Size(195, 23);
            this.cmbMyTicketAssignedTo.TabIndex = 22;
            // 
            // lblMyTicketStatus
            // 
            this.lblMyTicketStatus.AutoSize = true;
            this.lblMyTicketStatus.Location = new System.Drawing.Point(865, 322);
            this.lblMyTicketStatus.Name = "lblMyTicketStatus";
            this.lblMyTicketStatus.Size = new System.Drawing.Size(39, 15);
            this.lblMyTicketStatus.TabIndex = 21;
            this.lblMyTicketStatus.Text = "Status";
            // 
            // cmbMyTicketStatus
            // 
            this.cmbMyTicketStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMyTicketStatus.FormattingEnabled = true;
            this.cmbMyTicketStatus.Items.AddRange(new object[] {
            "Pending",
            "Assigned",
            "Accepted",
            "Completed"});
            this.cmbMyTicketStatus.Location = new System.Drawing.Point(865, 340);
            this.cmbMyTicketStatus.Name = "cmbMyTicketStatus";
            this.cmbMyTicketStatus.Size = new System.Drawing.Size(195, 23);
            this.cmbMyTicketStatus.TabIndex = 20;
            // 
            // lblMyTicketType
            // 
            this.lblMyTicketType.AutoSize = true;
            this.lblMyTicketType.Location = new System.Drawing.Point(865, 278);
            this.lblMyTicketType.Name = "lblMyTicketType";
            this.lblMyTicketType.Size = new System.Drawing.Size(31, 15);
            this.lblMyTicketType.TabIndex = 19;
            this.lblMyTicketType.Text = "Type";
            // 
            // cmbMyTicketType
            // 
            this.cmbMyTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMyTicketType.FormattingEnabled = true;
            this.cmbMyTicketType.Items.AddRange(new object[] {
            "Networking",
            "Software",
            "Updates",
            "Hardware",
            "Misc."});
            this.cmbMyTicketType.Location = new System.Drawing.Point(865, 296);
            this.cmbMyTicketType.Name = "cmbMyTicketType";
            this.cmbMyTicketType.Size = new System.Drawing.Size(195, 23);
            this.cmbMyTicketType.TabIndex = 18;
            // 
            // lblMyTicketNotes
            // 
            this.lblMyTicketNotes.AutoSize = true;
            this.lblMyTicketNotes.Location = new System.Drawing.Point(865, 140);
            this.lblMyTicketNotes.Name = "lblMyTicketNotes";
            this.lblMyTicketNotes.Size = new System.Drawing.Size(38, 15);
            this.lblMyTicketNotes.TabIndex = 17;
            this.lblMyTicketNotes.Text = "Notes";
            // 
            // txtMyTicketNotes
            // 
            this.txtMyTicketNotes.Location = new System.Drawing.Point(865, 158);
            this.txtMyTicketNotes.Multiline = true;
            this.txtMyTicketNotes.Name = "txtMyTicketNotes";
            this.txtMyTicketNotes.Size = new System.Drawing.Size(195, 117);
            this.txtMyTicketNotes.TabIndex = 16;
            // 
            // lblMyTicketDescription
            // 
            this.lblMyTicketDescription.AutoSize = true;
            this.lblMyTicketDescription.Location = new System.Drawing.Point(865, 3);
            this.lblMyTicketDescription.Name = "lblMyTicketDescription";
            this.lblMyTicketDescription.Size = new System.Drawing.Size(67, 15);
            this.lblMyTicketDescription.TabIndex = 15;
            this.lblMyTicketDescription.Text = "Description";
            // 
            // txtMyTicketDescription
            // 
            this.txtMyTicketDescription.Location = new System.Drawing.Point(865, 21);
            this.txtMyTicketDescription.Multiline = true;
            this.txtMyTicketDescription.Name = "txtMyTicketDescription";
            this.txtMyTicketDescription.Size = new System.Drawing.Size(195, 116);
            this.txtMyTicketDescription.TabIndex = 14;
            // 
            // dgvMyTickets
            // 
            this.dgvMyTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyTickets.Location = new System.Drawing.Point(3, 3);
            this.dgvMyTickets.Name = "dgvMyTickets";
            this.dgvMyTickets.RowTemplate.Height = 25;
            this.dgvMyTickets.Size = new System.Drawing.Size(856, 510);
            this.dgvMyTickets.TabIndex = 0;
            this.dgvMyTickets.SelectionChanged += new System.EventHandler(this.dgvMyTickets_SelectionChanged);
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.btnShow);
            this.tabTickets.Controls.Add(this.btnShowPending);
            this.tabTickets.Controls.Add(this.btnShowAll);
            this.tabTickets.Controls.Add(this.lblFilters);
            this.tabTickets.Controls.Add(this.lblTicketPriority);
            this.tabTickets.Controls.Add(this.cmbTicketPriority);
            this.tabTickets.Controls.Add(this.btnUpdateTIcket);
            this.tabTickets.Controls.Add(this.lblTicketAssignedTo);
            this.tabTickets.Controls.Add(this.cmbTicketAssignedTo);
            this.tabTickets.Controls.Add(this.lblTicketStatus);
            this.tabTickets.Controls.Add(this.cmbTicketStatus);
            this.tabTickets.Controls.Add(this.lblTicketType);
            this.tabTickets.Controls.Add(this.cmbTicketType);
            this.tabTickets.Controls.Add(this.lblTicketNotes);
            this.tabTickets.Controls.Add(this.txtTicketNotes);
            this.tabTickets.Controls.Add(this.lblTicketDescription);
            this.tabTickets.Controls.Add(this.txtTicketDescription);
            this.tabTickets.Controls.Add(this.dgvAllTickets);
            this.tabTickets.Location = new System.Drawing.Point(4, 24);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(1066, 516);
            this.tabTickets.TabIndex = 1;
            this.tabTickets.Text = "All Tickets";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(295, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(115, 23);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show Completed";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowPending
            // 
            this.btnShowPending.Location = new System.Drawing.Point(174, 8);
            this.btnShowPending.Name = "btnShowPending";
            this.btnShowPending.Size = new System.Drawing.Size(115, 23);
            this.btnShowPending.TabIndex = 16;
            this.btnShowPending.Text = "Show Pending";
            this.btnShowPending.UseVisualStyleBackColor = true;
            this.btnShowPending.Click += new System.EventHandler(this.btnShowPending_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(53, 8);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(115, 23);
            this.btnShowAll.TabIndex = 15;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Location = new System.Drawing.Point(6, 12);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(41, 15);
            this.lblFilters.TabIndex = 14;
            this.lblFilters.Text = "Filters:";
            // 
            // lblTicketPriority
            // 
            this.lblTicketPriority.AutoSize = true;
            this.lblTicketPriority.Location = new System.Drawing.Point(865, 366);
            this.lblTicketPriority.Name = "lblTicketPriority";
            this.lblTicketPriority.Size = new System.Drawing.Size(45, 15);
            this.lblTicketPriority.TabIndex = 13;
            this.lblTicketPriority.Text = "Priority";
            // 
            // cmbTicketPriority
            // 
            this.cmbTicketPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketPriority.FormattingEnabled = true;
            this.cmbTicketPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "Moderate",
            "High",
            "Severe"});
            this.cmbTicketPriority.Location = new System.Drawing.Point(865, 384);
            this.cmbTicketPriority.Name = "cmbTicketPriority";
            this.cmbTicketPriority.Size = new System.Drawing.Size(195, 23);
            this.cmbTicketPriority.TabIndex = 12;
            // 
            // btnUpdateTIcket
            // 
            this.btnUpdateTIcket.Location = new System.Drawing.Point(900, 464);
            this.btnUpdateTIcket.Name = "btnUpdateTIcket";
            this.btnUpdateTIcket.Size = new System.Drawing.Size(124, 37);
            this.btnUpdateTIcket.TabIndex = 11;
            this.btnUpdateTIcket.Text = "Update Ticket";
            this.btnUpdateTIcket.UseVisualStyleBackColor = true;
            this.btnUpdateTIcket.Click += new System.EventHandler(this.btnUpdateTIcket_Click);
            // 
            // lblTicketAssignedTo
            // 
            this.lblTicketAssignedTo.AutoSize = true;
            this.lblTicketAssignedTo.Location = new System.Drawing.Point(865, 410);
            this.lblTicketAssignedTo.Name = "lblTicketAssignedTo";
            this.lblTicketAssignedTo.Size = new System.Drawing.Size(70, 15);
            this.lblTicketAssignedTo.TabIndex = 10;
            this.lblTicketAssignedTo.Text = "Assigned To";
            // 
            // cmbTicketAssignedTo
            // 
            this.cmbTicketAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketAssignedTo.FormattingEnabled = true;
            this.cmbTicketAssignedTo.Location = new System.Drawing.Point(865, 428);
            this.cmbTicketAssignedTo.Name = "cmbTicketAssignedTo";
            this.cmbTicketAssignedTo.Size = new System.Drawing.Size(195, 23);
            this.cmbTicketAssignedTo.TabIndex = 9;
            // 
            // lblTicketStatus
            // 
            this.lblTicketStatus.AutoSize = true;
            this.lblTicketStatus.Location = new System.Drawing.Point(865, 322);
            this.lblTicketStatus.Name = "lblTicketStatus";
            this.lblTicketStatus.Size = new System.Drawing.Size(39, 15);
            this.lblTicketStatus.TabIndex = 8;
            this.lblTicketStatus.Text = "Status";
            // 
            // cmbTicketStatus
            // 
            this.cmbTicketStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketStatus.FormattingEnabled = true;
            this.cmbTicketStatus.Items.AddRange(new object[] {
            "Pending",
            "Assigned",
            "Accepted",
            "Completed"});
            this.cmbTicketStatus.Location = new System.Drawing.Point(865, 340);
            this.cmbTicketStatus.Name = "cmbTicketStatus";
            this.cmbTicketStatus.Size = new System.Drawing.Size(195, 23);
            this.cmbTicketStatus.TabIndex = 7;
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.Location = new System.Drawing.Point(865, 278);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(31, 15);
            this.lblTicketType.TabIndex = 6;
            this.lblTicketType.Text = "Type";
            // 
            // cmbTicketType
            // 
            this.cmbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketType.FormattingEnabled = true;
            this.cmbTicketType.Items.AddRange(new object[] {
            "Networking",
            "Software",
            "Updates",
            "Hardware",
            "Misc."});
            this.cmbTicketType.Location = new System.Drawing.Point(865, 296);
            this.cmbTicketType.Name = "cmbTicketType";
            this.cmbTicketType.Size = new System.Drawing.Size(195, 23);
            this.cmbTicketType.TabIndex = 5;
            // 
            // lblTicketNotes
            // 
            this.lblTicketNotes.AutoSize = true;
            this.lblTicketNotes.Location = new System.Drawing.Point(865, 140);
            this.lblTicketNotes.Name = "lblTicketNotes";
            this.lblTicketNotes.Size = new System.Drawing.Size(38, 15);
            this.lblTicketNotes.TabIndex = 4;
            this.lblTicketNotes.Text = "Notes";
            // 
            // txtTicketNotes
            // 
            this.txtTicketNotes.Location = new System.Drawing.Point(865, 158);
            this.txtTicketNotes.Multiline = true;
            this.txtTicketNotes.Name = "txtTicketNotes";
            this.txtTicketNotes.Size = new System.Drawing.Size(195, 117);
            this.txtTicketNotes.TabIndex = 3;
            // 
            // lblTicketDescription
            // 
            this.lblTicketDescription.AutoSize = true;
            this.lblTicketDescription.Location = new System.Drawing.Point(865, 3);
            this.lblTicketDescription.Name = "lblTicketDescription";
            this.lblTicketDescription.Size = new System.Drawing.Size(67, 15);
            this.lblTicketDescription.TabIndex = 2;
            this.lblTicketDescription.Text = "Description";
            // 
            // txtTicketDescription
            // 
            this.txtTicketDescription.Location = new System.Drawing.Point(865, 21);
            this.txtTicketDescription.Multiline = true;
            this.txtTicketDescription.Name = "txtTicketDescription";
            this.txtTicketDescription.Size = new System.Drawing.Size(195, 116);
            this.txtTicketDescription.TabIndex = 1;
            // 
            // dgvAllTickets
            // 
            this.dgvAllTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTickets.Location = new System.Drawing.Point(3, 37);
            this.dgvAllTickets.Name = "dgvAllTickets";
            this.dgvAllTickets.RowTemplate.Height = 25;
            this.dgvAllTickets.Size = new System.Drawing.Size(856, 476);
            this.dgvAllTickets.TabIndex = 0;
            this.dgvAllTickets.SelectionChanged += new System.EventHandler(this.dgvAllTickets_SelectionChanged);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Location = new System.Drawing.Point(928, 9);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(80, 15);
            this.lblLoggedInAs.TabIndex = 1;
            this.lblLoggedInAs.Text = "Logged in as: ";
            // 
            // btnOpenCreateUserForm
            // 
            this.btnOpenCreateUserForm.Location = new System.Drawing.Point(923, 31);
            this.btnOpenCreateUserForm.Name = "btnOpenCreateUserForm";
            this.btnOpenCreateUserForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCreateUserForm.TabIndex = 2;
            this.btnOpenCreateUserForm.Text = "Create User";
            this.btnOpenCreateUserForm.UseVisualStyleBackColor = true;
            this.btnOpenCreateUserForm.Click += new System.EventHandler(this.btnOpenCreateUserForm_Click);
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Location = new System.Drawing.Point(1005, 9);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(38, 15);
            this.lblLoggedInUser.TabIndex = 3;
            this.lblLoggedInUser.Text = "label1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1004, 31);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 592);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.btnOpenCreateUserForm);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Helpdesk Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabMyTickets.ResumeLayout(false);
            this.tabMyTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTickets)).EndInit();
            this.tabTickets.ResumeLayout(false);
            this.tabTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabMyTickets;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnOpenCreateUserForm;
        private System.Windows.Forms.DataGridView dgvMyTickets;
        private System.Windows.Forms.DataGridView dgvAllTickets;
        private System.Windows.Forms.Label lblTicketNotes;
        private System.Windows.Forms.TextBox txtTicketNotes;
        private System.Windows.Forms.Label lblTicketDescription;
        private System.Windows.Forms.TextBox txtTicketDescription;
        private System.Windows.Forms.Label lblTicketStatus;
        private System.Windows.Forms.ComboBox cmbTicketStatus;
        private System.Windows.Forms.Label lblTicketType;
        private System.Windows.Forms.ComboBox cmbTicketType;
        private System.Windows.Forms.Button btnUpdateTIcket;
        private System.Windows.Forms.Label lblTicketAssignedTo;
        private System.Windows.Forms.ComboBox cmbTicketAssignedTo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMyTicketPriority;
        private System.Windows.Forms.ComboBox cmbMyTicketPriority;
        private System.Windows.Forms.Button btnUpdateMyTicket;
        private System.Windows.Forms.Label txtMyTicketAssignedTo;
        private System.Windows.Forms.ComboBox cmbMyTicketAssignedTo;
        private System.Windows.Forms.Label lblMyTicketStatus;
        private System.Windows.Forms.ComboBox cmbMyTicketStatus;
        private System.Windows.Forms.Label lblMyTicketType;
        private System.Windows.Forms.ComboBox cmbMyTicketType;
        private System.Windows.Forms.Label lblMyTicketNotes;
        private System.Windows.Forms.TextBox txtMyTicketNotes;
        private System.Windows.Forms.Label lblMyTicketDescription;
        private System.Windows.Forms.TextBox txtMyTicketDescription;
        private System.Windows.Forms.Label lblTicketPriority;
        private System.Windows.Forms.ComboBox cmbTicketPriority;
        private System.Windows.Forms.Label lblNewTicketPriority;
        private System.Windows.Forms.ComboBox cmbNewTicketPriority;
        private System.Windows.Forms.Label lblNewTicketAssignedTo;
        private System.Windows.Forms.ComboBox cmbNewTicketAssignedTo;
        private System.Windows.Forms.Label lblNewTicketStatus;
        private System.Windows.Forms.ComboBox cmbNewTicketStatus;
        private System.Windows.Forms.Label lblNewTicketType;
        private System.Windows.Forms.ComboBox cmbNewTicketType;
        private System.Windows.Forms.Label lblNewTicketDescription;
        private System.Windows.Forms.TextBox txtNewTicketDescription;
        private System.Windows.Forms.Label lblCreateNewTicket;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageToSend;
        private System.Windows.Forms.ListBox lstDMs;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShowPending;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblFilters;
    }
}

