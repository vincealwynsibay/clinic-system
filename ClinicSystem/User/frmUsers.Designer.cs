namespace ClinicSystem
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.grdUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.BorderRadius = 6;
            this.btnDeleteUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(22)))), ((int)(((byte)(86)))));
            this.btnDeleteUser.Font = new System.Drawing.Font("IBM Plex Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = global::ClinicSystem.Properties.Resources.Frame_1_;
            this.btnDeleteUser.Location = new System.Drawing.Point(821, 478);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(149, 46);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "DELETE";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnEditUser.BorderRadius = 6;
            this.btnEditUser.BorderThickness = 2;
            this.btnEditUser.FillColor = System.Drawing.Color.White;
            this.btnEditUser.Font = new System.Drawing.Font("IBM Plex Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnEditUser.Image = global::ClinicSystem.Properties.Resources.edit2;
            this.btnEditUser.Location = new System.Drawing.Point(650, 478);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(149, 46);
            this.btnEditUser.TabIndex = 8;
            this.btnEditUser.Text = "EDIT";
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BorderRadius = 6;
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnAddUser.Font = new System.Drawing.Font("IBM Plex Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::ClinicSystem.Properties.Resources.icnAddUser;
            this.btnAddUser.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnAddUser.Location = new System.Drawing.Point(771, 11);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(199, 51);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // grdUsers
            // 
            this.grdUsers.AllowUserToAddRows = false;
            this.grdUsers.AllowUserToDeleteRows = false;
            this.grdUsers.AllowUserToOrderColumns = true;
            this.grdUsers.AllowUserToResizeColumns = false;
            this.grdUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.grdUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("IBM Plex Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdUsers.ColumnHeadersHeight = 50;
            this.grdUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.role,
            this.fullname,
            this.controls});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("IBM Plex Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.grdUsers.Location = new System.Drawing.Point(12, 92);
            this.grdUsers.Name = "grdUsers";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdUsers.RowHeadersVisible = false;
            this.grdUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.grdUsers.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdUsers.RowTemplate.Height = 35;
            this.grdUsers.RowTemplate.ReadOnly = true;
            this.grdUsers.Size = new System.Drawing.Size(958, 348);
            this.grdUsers.TabIndex = 10;
            this.grdUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.grdUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.grdUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.grdUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdUsers.ThemeStyle.HeaderStyle.Height = 50;
            this.grdUsers.ThemeStyle.ReadOnly = false;
            this.grdUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IBM Plex Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.grdUsers.ThemeStyle.RowsStyle.Height = 35;
            this.grdUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            // 
            // role
            // 
            this.role.HeaderText = "role";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            // 
            // fullname
            // 
            this.fullname.HeaderText = "fullname";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            // 
            // controls
            // 
            this.controls.HeaderText = "";
            this.controls.MinimumWidth = 6;
            this.controls.Name = "controls";
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("IBM Plex Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = global::ClinicSystem.Properties.Resources.search;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(12, 18);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties8;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.txtSearch.PlaceholderText = "Enter text";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(469, 44);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Enter text";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 80;
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragEndTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 857);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grdUsers);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnEditUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2DataGridView grdUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn controls;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}