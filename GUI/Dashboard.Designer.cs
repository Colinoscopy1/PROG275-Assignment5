
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
            this.tabMyTickets = new System.Windows.Forms.TabPage();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnOpenCreateUserForm = new System.Windows.Forms.Button();
            this.dgvMyTickets = new System.Windows.Forms.DataGridView();
            this.dgvAllTickets = new System.Windows.Forms.DataGridView();
            this.txtTicketDescription = new System.Windows.Forms.TextBox();
            this.lblTicketDescription = new System.Windows.Forms.Label();
            this.lblTicketNotes = new System.Windows.Forms.Label();
            this.txtTicketNotes = new System.Windows.Forms.TextBox();
            this.cmbTicketType = new System.Windows.Forms.ComboBox();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.lblTicketStatus = new System.Windows.Forms.Label();
            this.cmbTicketStatus = new System.Windows.Forms.ComboBox();
            this.lblTicketAssignedTo = new System.Windows.Forms.Label();
            this.cmbTicketAssignedTo = new System.Windows.Forms.ComboBox();
            this.btnUpdateTIcket = new System.Windows.Forms.Button();
            this.lblTicketPriority = new System.Windows.Forms.Label();
            this.cmbTicketPriority = new System.Windows.Forms.ComboBox();
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.lstDMs = new System.Windows.Forms.ListBox();
            this.txtMessageToSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblCreateNewTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.lblMessages = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabMyTickets.SuspendLayout();
            this.tabTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTickets)).BeginInit();
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
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.lblMessages);
            this.tabDashboard.Controls.Add(this.btnCreateTicket);
            this.tabDashboard.Controls.Add(this.label1);
            this.tabDashboard.Controls.Add(this.comboBox1);
            this.tabDashboard.Controls.Add(this.label2);
            this.tabDashboard.Controls.Add(this.comboBox2);
            this.tabDashboard.Controls.Add(this.label3);
            this.tabDashboard.Controls.Add(this.comboBox3);
            this.tabDashboard.Controls.Add(this.label4);
            this.tabDashboard.Controls.Add(this.comboBox4);
            this.tabDashboard.Controls.Add(this.label6);
            this.tabDashboard.Controls.Add(this.textBox2);
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
            // tabTickets
            // 
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
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Location = new System.Drawing.Point(929, 18);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(80, 15);
            this.lblLoggedInAs.TabIndex = 1;
            this.lblLoggedInAs.Text = "Logged in as: ";
            // 
            // btnOpenCreateUserForm
            // 
            this.btnOpenCreateUserForm.Location = new System.Drawing.Point(800, 14);
            this.btnOpenCreateUserForm.Name = "btnOpenCreateUserForm";
            this.btnOpenCreateUserForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCreateUserForm.TabIndex = 2;
            this.btnOpenCreateUserForm.Text = "Create User";
            this.btnOpenCreateUserForm.UseVisualStyleBackColor = true;
            this.btnOpenCreateUserForm.Click += new System.EventHandler(this.btnOpenCreateUserForm_Click);
            // 
            // dgvMyTickets
            // 
            this.dgvMyTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyTickets.Location = new System.Drawing.Point(3, 3);
            this.dgvMyTickets.Name = "dgvMyTickets";
            this.dgvMyTickets.RowTemplate.Height = 25;
            this.dgvMyTickets.Size = new System.Drawing.Size(856, 510);
            this.dgvMyTickets.TabIndex = 0;
            // 
            // dgvAllTickets
            // 
            this.dgvAllTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTickets.Location = new System.Drawing.Point(3, 3);
            this.dgvAllTickets.Name = "dgvAllTickets";
            this.dgvAllTickets.RowTemplate.Height = 25;
            this.dgvAllTickets.Size = new System.Drawing.Size(856, 510);
            this.dgvAllTickets.TabIndex = 0;
            // 
            // txtTicketDescription
            // 
            this.txtTicketDescription.Location = new System.Drawing.Point(865, 21);
            this.txtTicketDescription.Multiline = true;
            this.txtTicketDescription.Name = "txtTicketDescription";
            this.txtTicketDescription.ReadOnly = true;
            this.txtTicketDescription.Size = new System.Drawing.Size(195, 116);
            this.txtTicketDescription.TabIndex = 1;
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
            // cmbTicketType
            // 
            this.cmbTicketType.FormattingEnabled = true;
            this.cmbTicketType.Location = new System.Drawing.Point(865, 296);
            this.cmbTicketType.Name = "cmbTicketType";
            this.cmbTicketType.Size = new System.Drawing.Size(195, 23);
            this.cmbTicketType.TabIndex = 5;
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
            this.cmbTicketStatus.FormattingEnabled = true;
            this.cmbTicketStatus.Location = new System.Drawing.Point(865, 340);
            this.cmbTicketStatus.Name = "cmbTicketStatus";
            this.cmbTicketStatus.Size = new System.Drawing.Size(195, 23);
            this.cmbTicketStatus.TabIndex = 7;
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
            this.cmbTicketAssignedTo.FormattingEnabled = true;
            this.cmbTicketAssignedTo.Location = new System.Drawing.Point(865, 428);
            this.cmbTicketAssignedTo.Name = "cmbTicketAssignedTo";
            this.cmbTicketAssignedTo.Size = new System.Drawing.Size(195, 23);
            this.cmbTicketAssignedTo.TabIndex = 9;
            // 
            // btnUpdateTIcket
            // 
            this.btnUpdateTIcket.Location = new System.Drawing.Point(900, 464);
            this.btnUpdateTIcket.Name = "btnUpdateTIcket";
            this.btnUpdateTIcket.Size = new System.Drawing.Size(124, 37);
            this.btnUpdateTIcket.TabIndex = 11;
            this.btnUpdateTIcket.Text = "Update Ticket";
            this.btnUpdateTIcket.UseVisualStyleBackColor = true;
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
            this.cmbTicketPriority.FormattingEnabled = true;
            this.cmbTicketPriority.Location = new System.Drawing.Point(865, 384);
            this.cmbTicketPriority.Name = "cmbTicketPriority";
            this.cmbTicketPriority.Size = new System.Drawing.Size(195, 23);
            this.cmbTicketPriority.TabIndex = 12;
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
            this.cmbMyTicketPriority.FormattingEnabled = true;
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
            this.cmbMyTicketStatus.FormattingEnabled = true;
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
            this.cmbMyTicketType.FormattingEnabled = true;
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
            this.txtMyTicketDescription.ReadOnly = true;
            this.txtMyTicketDescription.Size = new System.Drawing.Size(195, 116);
            this.txtMyTicketDescription.TabIndex = 14;
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
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 15;
            this.lstMessages.Location = new System.Drawing.Point(780, 225);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(263, 169);
            this.lstMessages.TabIndex = 1;
            // 
            // lstDMs
            // 
            this.lstDMs.FormattingEnabled = true;
            this.lstDMs.ItemHeight = 15;
            this.lstDMs.Location = new System.Drawing.Point(627, 225);
            this.lstDMs.Name = "lstDMs";
            this.lstDMs.Size = new System.Drawing.Size(147, 199);
            this.lstDMs.TabIndex = 2;
            // 
            // txtMessageToSend
            // 
            this.txtMessageToSend.Location = new System.Drawing.Point(780, 401);
            this.txtMessageToSend.Name = "txtMessageToSend";
            this.txtMessageToSend.Size = new System.Drawing.Size(182, 23);
            this.txtMessageToSend.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(968, 401);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Priority";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 23);
            this.comboBox1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Assigned To";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(225, 361);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 23);
            this.comboBox2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Status";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(225, 273);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(195, 23);
            this.comboBox3.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Type";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(225, 229);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(195, 23);
            this.comboBox4.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 224);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 160);
            this.textBox2.TabIndex = 27;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(24, 390);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(396, 34);
            this.btnCreateTicket.TabIndex = 39;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessages.Location = new System.Drawing.Point(627, 182);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(140, 28);
            this.lblMessages.TabIndex = 40;
            this.lblMessages.Text = "Your Messages";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 592);
            this.Controls.Add(this.btnOpenCreateUserForm);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Helpdesk Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabMyTickets.ResumeLayout(false);
            this.tabMyTickets.PerformLayout();
            this.tabTickets.ResumeLayout(false);
            this.tabTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTickets)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCreateNewTicket;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageToSend;
        private System.Windows.Forms.ListBox lstDMs;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button btnCreateTicket;
    }
}

