namespace ClinicSystem.Diagnosis
{
    partial class frmDiagnosisAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiagnosisAdd));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties33 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties34 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties35 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties36 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties37 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties38 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties39 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties40 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblEditDetails = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lblComment = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtComment = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblDiagnosis = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtDiagnosis = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblEditDetails);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1006, 100);
            this.bunifuPanel1.TabIndex = 95;
            // 
            // lblEditDetails
            // 
            this.lblEditDetails.AllowParentOverrides = false;
            this.lblEditDetails.AutoEllipsis = false;
            this.lblEditDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEditDetails.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblEditDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblEditDetails.ForeColor = System.Drawing.Color.White;
            this.lblEditDetails.Location = new System.Drawing.Point(411, 32);
            this.lblEditDetails.Margin = new System.Windows.Forms.Padding(2);
            this.lblEditDetails.Name = "lblEditDetails";
            this.lblEditDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEditDetails.Size = new System.Drawing.Size(185, 37);
            this.lblEditDetails.TabIndex = 39;
            this.lblEditDetails.Text = "Add Diagnosis";
            this.lblEditDetails.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEditDetails.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnCancel
            // 
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(224, 557);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(262, 37);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblComment
            // 
            this.lblComment.AllowParentOverrides = false;
            this.lblComment.AutoEllipsis = false;
            this.lblComment.CursorType = null;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblComment.Location = new System.Drawing.Point(224, 367);
            this.lblComment.Margin = new System.Windows.Forms.Padding(2);
            this.lblComment.Name = "lblComment";
            this.lblComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblComment.Size = new System.Drawing.Size(54, 15);
            this.lblComment.TabIndex = 107;
            this.lblComment.Text = "Comment";
            this.lblComment.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblComment.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtComment
            // 
            this.txtComment.AcceptsReturn = false;
            this.txtComment.AcceptsTab = false;
            this.txtComment.AnimationSpeed = 200;
            this.txtComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtComment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtComment.AutoSizeHeight = true;
            this.txtComment.BackColor = System.Drawing.Color.Transparent;
            this.txtComment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtComment.BackgroundImage")));
            this.txtComment.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtComment.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtComment.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.txtComment.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtComment.BorderRadius = 1;
            this.txtComment.BorderThickness = 1;
            this.txtComment.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtComment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtComment.DefaultText = "";
            this.txtComment.FillColor = System.Drawing.Color.White;
            this.txtComment.HideSelection = true;
            this.txtComment.IconLeft = null;
            this.txtComment.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.IconPadding = 10;
            this.txtComment.IconRight = null;
            this.txtComment.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(224, 394);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2);
            this.txtComment.MaxLength = 32767;
            this.txtComment.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtComment.Modified = false;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            stateProperties33.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            stateProperties33.FillColor = System.Drawing.Color.Empty;
            stateProperties33.ForeColor = System.Drawing.Color.Empty;
            stateProperties33.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtComment.OnActiveState = stateProperties33;
            stateProperties34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties34.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtComment.OnDisabledState = stateProperties34;
            stateProperties35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            stateProperties35.FillColor = System.Drawing.Color.Empty;
            stateProperties35.ForeColor = System.Drawing.Color.Empty;
            stateProperties35.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtComment.OnHoverState = stateProperties35;
            stateProperties36.BorderColor = System.Drawing.Color.Silver;
            stateProperties36.FillColor = System.Drawing.Color.White;
            stateProperties36.ForeColor = System.Drawing.Color.Empty;
            stateProperties36.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtComment.OnIdleState = stateProperties36;
            this.txtComment.Padding = new System.Windows.Forms.Padding(2);
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtComment.PlaceholderText = "Enter text";
            this.txtComment.ReadOnly = false;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.ShortcutsEnabled = true;
            this.txtComment.Size = new System.Drawing.Size(559, 116);
            this.txtComment.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtComment.TabIndex = 106;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComment.TextMarginBottom = 0;
            this.txtComment.TextMarginLeft = 3;
            this.txtComment.TextMarginTop = 1;
            this.txtComment.TextPlaceholder = "Enter text";
            this.txtComment.UseSystemPasswordChar = false;
            this.txtComment.WordWrap = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(521, 557);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 37);
            this.btnAdd.TabIndex = 105;
            this.btnAdd.Text = "Add Diagnosis";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AllowParentOverrides = false;
            this.lblDiagnosis.AutoEllipsis = false;
            this.lblDiagnosis.CursorType = null;
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiagnosis.Location = new System.Drawing.Point(224, 205);
            this.lblDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiagnosis.Size = new System.Drawing.Size(51, 15);
            this.lblDiagnosis.TabIndex = 104;
            this.lblDiagnosis.Text = "Diagnosis";
            this.lblDiagnosis.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDiagnosis.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.AcceptsReturn = false;
            this.txtDiagnosis.AcceptsTab = false;
            this.txtDiagnosis.AnimationSpeed = 200;
            this.txtDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDiagnosis.AutoSizeHeight = true;
            this.txtDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.txtDiagnosis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDiagnosis.BackgroundImage")));
            this.txtDiagnosis.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtDiagnosis.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDiagnosis.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.txtDiagnosis.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDiagnosis.BorderRadius = 1;
            this.txtDiagnosis.BorderThickness = 1;
            this.txtDiagnosis.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtDiagnosis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosis.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtDiagnosis.DefaultText = "";
            this.txtDiagnosis.FillColor = System.Drawing.Color.White;
            this.txtDiagnosis.HideSelection = true;
            this.txtDiagnosis.IconLeft = null;
            this.txtDiagnosis.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosis.IconPadding = 10;
            this.txtDiagnosis.IconRight = null;
            this.txtDiagnosis.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosis.Lines = new string[0];
            this.txtDiagnosis.Location = new System.Drawing.Point(224, 232);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiagnosis.MaxLength = 32767;
            this.txtDiagnosis.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDiagnosis.Modified = false;
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            stateProperties37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            stateProperties37.FillColor = System.Drawing.Color.Empty;
            stateProperties37.ForeColor = System.Drawing.Color.Empty;
            stateProperties37.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiagnosis.OnActiveState = stateProperties37;
            stateProperties38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties38.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDiagnosis.OnDisabledState = stateProperties38;
            stateProperties39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            stateProperties39.FillColor = System.Drawing.Color.Empty;
            stateProperties39.ForeColor = System.Drawing.Color.Empty;
            stateProperties39.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiagnosis.OnHoverState = stateProperties39;
            stateProperties40.BorderColor = System.Drawing.Color.Silver;
            stateProperties40.FillColor = System.Drawing.Color.White;
            stateProperties40.ForeColor = System.Drawing.Color.Empty;
            stateProperties40.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiagnosis.OnIdleState = stateProperties40;
            this.txtDiagnosis.Padding = new System.Windows.Forms.Padding(2);
            this.txtDiagnosis.PasswordChar = '\0';
            this.txtDiagnosis.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiagnosis.PlaceholderText = "Enter text";
            this.txtDiagnosis.ReadOnly = false;
            this.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiagnosis.SelectedText = "";
            this.txtDiagnosis.SelectionLength = 0;
            this.txtDiagnosis.SelectionStart = 0;
            this.txtDiagnosis.ShortcutsEnabled = true;
            this.txtDiagnosis.Size = new System.Drawing.Size(559, 116);
            this.txtDiagnosis.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDiagnosis.TabIndex = 103;
            this.txtDiagnosis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiagnosis.TextMarginBottom = 0;
            this.txtDiagnosis.TextMarginLeft = 3;
            this.txtDiagnosis.TextMarginTop = 1;
            this.txtDiagnosis.TextPlaceholder = "Enter text";
            this.txtDiagnosis.UseSystemPasswordChar = false;
            this.txtDiagnosis.WordWrap = true;
            // 
            // frmDiagnosisAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 829);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiagnosisAdd";
            this.Text = "frmDiagnosisAdd";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblEditDetails;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Bunifu.UI.WinForms.BunifuLabel lblComment;
        private Bunifu.UI.WinForms.BunifuTextBox txtComment;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Bunifu.UI.WinForms.BunifuLabel lblDiagnosis;
        private Bunifu.UI.WinForms.BunifuTextBox txtDiagnosis;
    }
}