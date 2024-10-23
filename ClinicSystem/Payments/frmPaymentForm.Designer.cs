namespace ClinicSystem
{
    partial class frmPaymentForm
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
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
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("IBM Plex Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnCancel.Location = new System.Drawing.Point(42, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 45);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Cancel";
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 6;
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnPay.Font = new System.Drawing.Font("IBM Plex Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::ClinicSystem.Properties.Resources.icnAddUser;
            this.btnPay.Location = new System.Drawing.Point(291, 213);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(220, 45);
            this.btnPay.TabIndex = 100;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("IBM Plex Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(42, 104);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(54, 19);
            this.bunifuLabel2.TabIndex = 103;
            this.bunifuLabel2.Text = "Amount";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtAmount
            // 
            this.txtAmount.AcceptsReturn = false;
            this.txtAmount.AcceptsTab = false;
            this.txtAmount.AnimationSpeed = 200;
            this.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAmount.AutoSizeHeight = true;
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtAmount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.txtAmount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.txtAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.txtAmount.BorderRadius = 8;
            this.txtAmount.BorderThickness = 1;
            this.txtAmount.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultFont = new System.Drawing.Font("IBM Plex Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.DefaultText = "";
            this.txtAmount.FillColor = System.Drawing.Color.White;
            this.txtAmount.HideSelection = true;
            this.txtAmount.IconLeft = null;
            this.txtAmount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.IconPadding = 10;
            this.txtAmount.IconRight = null;
            this.txtAmount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(42, 129);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAmount.Modified = false;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAmount.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnIdleState = stateProperties12;
            this.txtAmount.Padding = new System.Windows.Forms.Padding(3);
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.txtAmount.PlaceholderText = "0.0";
            this.txtAmount.ReadOnly = false;
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(469, 45);
            this.txtAmount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAmount.TabIndex = 102;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmount.TextMarginBottom = 0;
            this.txtAmount.TextMarginLeft = 3;
            this.txtAmount.TextMarginTop = 1;
            this.txtAmount.TextPlaceholder = "0.0";
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.WordWrap = true;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("IBM Plex Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel9.Location = new System.Drawing.Point(42, 30);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(126, 39);
            this.bunifuLabel9.TabIndex = 104;
            this.bunifuLabel9.Text = "Payment";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 309);
            this.Controls.Add(this.bunifuLabel9);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentForm";
            this.Text = "frmPaymentForm";
            this.Load += new System.EventHandler(this.frmPaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox txtAmount;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
    }
}