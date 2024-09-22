namespace ClinicSystem
{
    partial class frmDoctors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctors));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.grdDoctors = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDoctor = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEditDoctor = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDoctors
            // 
            this.grdDoctors.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grdDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdDoctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDoctors.ColumnHeadersHeight = 40;
            this.grdDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.middlenam,
            this.lastname,
            this.gender,
            this.birthdate,
            this.email,
            this.mobileno,
            this.address});
            this.grdDoctors.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grdDoctors.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdDoctors.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdDoctors.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grdDoctors.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdDoctors.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grdDoctors.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grdDoctors.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grdDoctors.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grdDoctors.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdDoctors.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.grdDoctors.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grdDoctors.CurrentTheme.Name = null;
            this.grdDoctors.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdDoctors.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdDoctors.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdDoctors.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grdDoctors.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDoctors.EnableHeadersVisualStyles = false;
            this.grdDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grdDoctors.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grdDoctors.HeaderBgColor = System.Drawing.Color.Empty;
            this.grdDoctors.HeaderForeColor = System.Drawing.Color.White;
            this.grdDoctors.Location = new System.Drawing.Point(57, 207);
            this.grdDoctors.MultiSelect = false;
            this.grdDoctors.Name = "grdDoctors";
            this.grdDoctors.ReadOnly = true;
            this.grdDoctors.RowHeadersVisible = false;
            this.grdDoctors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdDoctors.RowTemplate.Height = 40;
            this.grdDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDoctors.Size = new System.Drawing.Size(1103, 495);
            this.grdDoctors.TabIndex = 1;
            this.grdDoctors.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.grdDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctors_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // middlenam
            // 
            this.middlenam.HeaderText = "Middle Name";
            this.middlenam.MinimumWidth = 6;
            this.middlenam.Name = "middlenam";
            this.middlenam.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // birthdate
            // 
            this.birthdate.HeaderText = "Birthdate";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // mobileno
            // 
            this.mobileno.HeaderText = "Contact Number";
            this.mobileno.MinimumWidth = 6;
            this.mobileno.Name = "mobileno";
            this.mobileno.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.AllowAnimations = true;
            this.btnAddDoctor.AllowMouseEffects = true;
            this.btnAddDoctor.AllowToggling = false;
            this.btnAddDoctor.AnimationSpeed = 200;
            this.btnAddDoctor.AutoGenerateColors = false;
            this.btnAddDoctor.AutoRoundBorders = false;
            this.btnAddDoctor.AutoSizeLeftIcon = true;
            this.btnAddDoctor.AutoSizeRightIcon = true;
            this.btnAddDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDoctor.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDoctor.BackgroundImage")));
            this.btnAddDoctor.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDoctor.ButtonText = "Add Doctor";
            this.btnAddDoctor.ButtonTextMarginLeft = 0;
            this.btnAddDoctor.ColorContrastOnClick = 45;
            this.btnAddDoctor.ColorContrastOnHover = 45;
            this.btnAddDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddDoctor.CustomizableEdges = borderEdges1;
            this.btnAddDoctor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDoctor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddDoctor.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddDoctor.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddDoctor.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDoctor.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.IconLeft = null;
            this.btnAddDoctor.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDoctor.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddDoctor.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddDoctor.IconMarginLeft = 11;
            this.btnAddDoctor.IconPadding = 10;
            this.btnAddDoctor.IconRight = null;
            this.btnAddDoctor.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDoctor.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddDoctor.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddDoctor.IconSize = 25;
            this.btnAddDoctor.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddDoctor.IdleBorderRadius = 0;
            this.btnAddDoctor.IdleBorderThickness = 0;
            this.btnAddDoctor.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddDoctor.IdleIconLeftImage = null;
            this.btnAddDoctor.IdleIconRightImage = null;
            this.btnAddDoctor.IndicateFocus = false;
            this.btnAddDoctor.Location = new System.Drawing.Point(1010, 111);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddDoctor.OnDisabledState.BorderRadius = 1;
            this.btnAddDoctor.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDoctor.OnDisabledState.BorderThickness = 1;
            this.btnAddDoctor.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddDoctor.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddDoctor.OnDisabledState.IconLeftImage = null;
            this.btnAddDoctor.OnDisabledState.IconRightImage = null;
            this.btnAddDoctor.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddDoctor.onHoverState.BorderRadius = 1;
            this.btnAddDoctor.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDoctor.onHoverState.BorderThickness = 1;
            this.btnAddDoctor.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddDoctor.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.onHoverState.IconLeftImage = null;
            this.btnAddDoctor.onHoverState.IconRightImage = null;
            this.btnAddDoctor.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDoctor.OnIdleState.BorderRadius = 1;
            this.btnAddDoctor.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDoctor.OnIdleState.BorderThickness = 1;
            this.btnAddDoctor.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDoctor.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.OnIdleState.IconLeftImage = null;
            this.btnAddDoctor.OnIdleState.IconRightImage = null;
            this.btnAddDoctor.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddDoctor.OnPressedState.BorderRadius = 1;
            this.btnAddDoctor.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDoctor.OnPressedState.BorderThickness = 1;
            this.btnAddDoctor.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddDoctor.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.OnPressedState.IconLeftImage = null;
            this.btnAddDoctor.OnPressedState.IconRightImage = null;
            this.btnAddDoctor.Size = new System.Drawing.Size(150, 39);
            this.btnAddDoctor.TabIndex = 2;
            this.btnAddDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDoctor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDoctor.TextMarginLeft = 0;
            this.btnAddDoctor.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddDoctor.UseDefaultRadiusAndThickness = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.AllowAnimations = true;
            this.btnEditDoctor.AllowMouseEffects = true;
            this.btnEditDoctor.AllowToggling = false;
            this.btnEditDoctor.AnimationSpeed = 200;
            this.btnEditDoctor.AutoGenerateColors = false;
            this.btnEditDoctor.AutoRoundBorders = false;
            this.btnEditDoctor.AutoSizeLeftIcon = true;
            this.btnEditDoctor.AutoSizeRightIcon = true;
            this.btnEditDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDoctor.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnEditDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditDoctor.BackgroundImage")));
            this.btnEditDoctor.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditDoctor.ButtonText = "Edit";
            this.btnEditDoctor.ButtonTextMarginLeft = 0;
            this.btnEditDoctor.ColorContrastOnClick = 45;
            this.btnEditDoctor.ColorContrastOnHover = 45;
            this.btnEditDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEditDoctor.CustomizableEdges = borderEdges2;
            this.btnEditDoctor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditDoctor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEditDoctor.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEditDoctor.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEditDoctor.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnEditDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditDoctor.ForeColor = System.Drawing.Color.White;
            this.btnEditDoctor.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDoctor.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditDoctor.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEditDoctor.IconMarginLeft = 11;
            this.btnEditDoctor.IconPadding = 10;
            this.btnEditDoctor.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditDoctor.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditDoctor.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEditDoctor.IconSize = 25;
            this.btnEditDoctor.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEditDoctor.IdleBorderRadius = 1;
            this.btnEditDoctor.IdleBorderThickness = 1;
            this.btnEditDoctor.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnEditDoctor.IdleIconLeftImage = null;
            this.btnEditDoctor.IdleIconRightImage = null;
            this.btnEditDoctor.IndicateFocus = false;
            this.btnEditDoctor.Location = new System.Drawing.Point(1010, 751);
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEditDoctor.OnDisabledState.BorderRadius = 1;
            this.btnEditDoctor.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditDoctor.OnDisabledState.BorderThickness = 1;
            this.btnEditDoctor.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEditDoctor.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEditDoctor.OnDisabledState.IconLeftImage = null;
            this.btnEditDoctor.OnDisabledState.IconRightImage = null;
            this.btnEditDoctor.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEditDoctor.onHoverState.BorderRadius = 1;
            this.btnEditDoctor.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditDoctor.onHoverState.BorderThickness = 1;
            this.btnEditDoctor.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEditDoctor.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEditDoctor.onHoverState.IconLeftImage = null;
            this.btnEditDoctor.onHoverState.IconRightImage = null;
            this.btnEditDoctor.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEditDoctor.OnIdleState.BorderRadius = 1;
            this.btnEditDoctor.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditDoctor.OnIdleState.BorderThickness = 1;
            this.btnEditDoctor.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEditDoctor.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEditDoctor.OnIdleState.IconLeftImage = null;
            this.btnEditDoctor.OnIdleState.IconRightImage = null;
            this.btnEditDoctor.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEditDoctor.OnPressedState.BorderRadius = 1;
            this.btnEditDoctor.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEditDoctor.OnPressedState.BorderThickness = 1;
            this.btnEditDoctor.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEditDoctor.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEditDoctor.OnPressedState.IconLeftImage = null;
            this.btnEditDoctor.OnPressedState.IconRightImage = null;
            this.btnEditDoctor.Size = new System.Drawing.Size(150, 39);
            this.btnEditDoctor.TabIndex = 3;
            this.btnEditDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditDoctor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditDoctor.TextMarginLeft = 0;
            this.btnEditDoctor.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEditDoctor.UseDefaultRadiusAndThickness = true;
            this.btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // frmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 967);
            this.Controls.Add(this.btnEditDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.grdDoctors);
            this.Name = "frmDoctors";
            this.Text = "frmDoctors";
            this.Load += new System.EventHandler(this.frmDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView grdDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenam;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDoctor;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnEditDoctor;
    }
}