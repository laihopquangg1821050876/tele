namespace TELESForm2
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Danhmuc = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Them = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Sua = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Xoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Refresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuImageButton4);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.Sua);
            this.panel1.Controls.Add(this.Xoa);
            this.panel1.Controls.Add(this.Them);
            this.panel1.Controls.Add(this.Danhmuc);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.bunifuDataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 450);
            this.panel2.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(99, 20);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Tên danh mục ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Danhmuc
            // 
            this.Danhmuc.AcceptsReturn = false;
            this.Danhmuc.AcceptsTab = false;
            this.Danhmuc.AnimationSpeed = 200;
            this.Danhmuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Danhmuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Danhmuc.BackColor = System.Drawing.Color.Transparent;
            this.Danhmuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Danhmuc.BackgroundImage")));
            this.Danhmuc.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Danhmuc.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Danhmuc.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Danhmuc.BorderColorIdle = System.Drawing.Color.Silver;
            this.Danhmuc.BorderRadius = 1;
            this.Danhmuc.BorderThickness = 1;
            this.Danhmuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Danhmuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Danhmuc.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Danhmuc.DefaultText = "";
            this.Danhmuc.FillColor = System.Drawing.Color.White;
            this.Danhmuc.HideSelection = true;
            this.Danhmuc.IconLeft = null;
            this.Danhmuc.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Danhmuc.IconPadding = 10;
            this.Danhmuc.IconRight = null;
            this.Danhmuc.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Danhmuc.Lines = new string[0];
            this.Danhmuc.Location = new System.Drawing.Point(12, 38);
            this.Danhmuc.MaxLength = 32767;
            this.Danhmuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.Danhmuc.Modified = false;
            this.Danhmuc.Multiline = false;
            this.Danhmuc.Name = "Danhmuc";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Danhmuc.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Danhmuc.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Danhmuc.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Danhmuc.OnIdleState = stateProperties8;
            this.Danhmuc.Padding = new System.Windows.Forms.Padding(3);
            this.Danhmuc.PasswordChar = '\0';
            this.Danhmuc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Danhmuc.PlaceholderText = "Danh mục ";
            this.Danhmuc.ReadOnly = false;
            this.Danhmuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Danhmuc.SelectedText = "";
            this.Danhmuc.SelectionLength = 0;
            this.Danhmuc.SelectionStart = 0;
            this.Danhmuc.ShortcutsEnabled = true;
            this.Danhmuc.Size = new System.Drawing.Size(181, 38);
            this.Danhmuc.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Danhmuc.TabIndex = 0;
            this.Danhmuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Danhmuc.TextMarginBottom = 0;
            this.Danhmuc.TextMarginLeft = 3;
            this.Danhmuc.TextMarginTop = 0;
            this.Danhmuc.TextPlaceholder = "Danh mục ";
            this.Danhmuc.UseSystemPasswordChar = false;
            this.Danhmuc.WordWrap = true;
            // 
            // Them
            // 
            this.Them.AllowAnimations = true;
            this.Them.AllowMouseEffects = true;
            this.Them.AllowToggling = false;
            this.Them.AnimationSpeed = 200;
            this.Them.AutoGenerateColors = false;
            this.Them.AutoRoundBorders = false;
            this.Them.AutoSizeLeftIcon = true;
            this.Them.AutoSizeRightIcon = true;
            this.Them.BackColor = System.Drawing.Color.Transparent;
            this.Them.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Them.BackgroundImage")));
            this.Them.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Them.ButtonText = "       Thêm ";
            this.Them.ButtonTextMarginLeft = 0;
            this.Them.ColorContrastOnClick = 45;
            this.Them.ColorContrastOnHover = 45;
            this.Them.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Them.CustomizableEdges = borderEdges5;
            this.Them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Them.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Them.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Them.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Them.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.ForeColor = System.Drawing.Color.White;
            this.Them.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Them.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Them.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Them.IconMarginLeft = 11;
            this.Them.IconPadding = 10;
            this.Them.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Them.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Them.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Them.IconSize = 25;
            this.Them.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Them.IdleBorderRadius = 1;
            this.Them.IdleBorderThickness = 1;
            this.Them.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Them.IdleIconLeftImage = null;
            this.Them.IdleIconRightImage = null;
            this.Them.IndicateFocus = false;
            this.Them.Location = new System.Drawing.Point(12, 97);
            this.Them.Name = "Them";
            this.Them.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Them.OnDisabledState.BorderRadius = 1;
            this.Them.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Them.OnDisabledState.BorderThickness = 1;
            this.Them.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Them.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Them.OnDisabledState.IconLeftImage = null;
            this.Them.OnDisabledState.IconRightImage = null;
            this.Them.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Them.onHoverState.BorderRadius = 1;
            this.Them.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Them.onHoverState.BorderThickness = 1;
            this.Them.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Them.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Them.onHoverState.IconLeftImage = null;
            this.Them.onHoverState.IconRightImage = null;
            this.Them.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Them.OnIdleState.BorderRadius = 1;
            this.Them.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Them.OnIdleState.BorderThickness = 1;
            this.Them.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Them.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Them.OnIdleState.IconLeftImage = null;
            this.Them.OnIdleState.IconRightImage = null;
            this.Them.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Them.OnPressedState.BorderRadius = 1;
            this.Them.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Them.OnPressedState.BorderThickness = 1;
            this.Them.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Them.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Them.OnPressedState.IconLeftImage = null;
            this.Them.OnPressedState.IconRightImage = null;
            this.Them.Size = new System.Drawing.Size(80, 24);
            this.Them.TabIndex = 0;
            this.Them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Them.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Them.TextMarginLeft = 0;
            this.Them.TextPadding = new System.Windows.Forms.Padding(0);
            this.Them.UseDefaultRadiusAndThickness = true;
            this.Them.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // Sua
            // 
            this.Sua.AllowAnimations = true;
            this.Sua.AllowMouseEffects = true;
            this.Sua.AllowToggling = false;
            this.Sua.AnimationSpeed = 200;
            this.Sua.AutoGenerateColors = false;
            this.Sua.AutoRoundBorders = false;
            this.Sua.AutoSizeLeftIcon = true;
            this.Sua.AutoSizeRightIcon = true;
            this.Sua.BackColor = System.Drawing.Color.Transparent;
            this.Sua.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sua.BackgroundImage")));
            this.Sua.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Sua.ButtonText = "  Sửa";
            this.Sua.ButtonTextMarginLeft = 0;
            this.Sua.ColorContrastOnClick = 45;
            this.Sua.ColorContrastOnHover = 45;
            this.Sua.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.Sua.CustomizableEdges = borderEdges6;
            this.Sua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Sua.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Sua.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Sua.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Sua.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Sua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.ForeColor = System.Drawing.Color.White;
            this.Sua.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sua.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Sua.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Sua.IconMarginLeft = 11;
            this.Sua.IconPadding = 10;
            this.Sua.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sua.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Sua.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Sua.IconSize = 25;
            this.Sua.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Sua.IdleBorderRadius = 1;
            this.Sua.IdleBorderThickness = 1;
            this.Sua.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Sua.IdleIconLeftImage = null;
            this.Sua.IdleIconRightImage = null;
            this.Sua.IndicateFocus = false;
            this.Sua.Location = new System.Drawing.Point(113, 97);
            this.Sua.Name = "Sua";
            this.Sua.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Sua.OnDisabledState.BorderRadius = 1;
            this.Sua.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Sua.OnDisabledState.BorderThickness = 1;
            this.Sua.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Sua.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Sua.OnDisabledState.IconLeftImage = null;
            this.Sua.OnDisabledState.IconRightImage = null;
            this.Sua.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Sua.onHoverState.BorderRadius = 1;
            this.Sua.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Sua.onHoverState.BorderThickness = 1;
            this.Sua.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Sua.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Sua.onHoverState.IconLeftImage = null;
            this.Sua.onHoverState.IconRightImage = null;
            this.Sua.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Sua.OnIdleState.BorderRadius = 1;
            this.Sua.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Sua.OnIdleState.BorderThickness = 1;
            this.Sua.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Sua.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Sua.OnIdleState.IconLeftImage = null;
            this.Sua.OnIdleState.IconRightImage = null;
            this.Sua.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Sua.OnPressedState.BorderRadius = 1;
            this.Sua.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Sua.OnPressedState.BorderThickness = 1;
            this.Sua.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Sua.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Sua.OnPressedState.IconLeftImage = null;
            this.Sua.OnPressedState.IconRightImage = null;
            this.Sua.Size = new System.Drawing.Size(80, 24);
            this.Sua.TabIndex = 0;
            this.Sua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sua.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sua.TextMarginLeft = 0;
            this.Sua.TextPadding = new System.Windows.Forms.Padding(0);
            this.Sua.UseDefaultRadiusAndThickness = true;
            // 
            // Xoa
            // 
            this.Xoa.AllowAnimations = true;
            this.Xoa.AllowMouseEffects = true;
            this.Xoa.AllowToggling = false;
            this.Xoa.AnimationSpeed = 200;
            this.Xoa.AutoGenerateColors = false;
            this.Xoa.AutoRoundBorders = false;
            this.Xoa.AutoSizeLeftIcon = true;
            this.Xoa.AutoSizeRightIcon = true;
            this.Xoa.BackColor = System.Drawing.Color.Transparent;
            this.Xoa.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Xoa.BackgroundImage")));
            this.Xoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Xoa.ButtonText = "    Xóa ";
            this.Xoa.ButtonTextMarginLeft = 0;
            this.Xoa.ColorContrastOnClick = 45;
            this.Xoa.ColorContrastOnHover = 45;
            this.Xoa.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.Xoa.CustomizableEdges = borderEdges7;
            this.Xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Xoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Xoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Xoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Xoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.Color.White;
            this.Xoa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xoa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Xoa.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Xoa.IconMarginLeft = 11;
            this.Xoa.IconPadding = 10;
            this.Xoa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Xoa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Xoa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Xoa.IconSize = 25;
            this.Xoa.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Xoa.IdleBorderRadius = 1;
            this.Xoa.IdleBorderThickness = 1;
            this.Xoa.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Xoa.IdleIconLeftImage = null;
            this.Xoa.IdleIconRightImage = null;
            this.Xoa.IndicateFocus = false;
            this.Xoa.Location = new System.Drawing.Point(12, 127);
            this.Xoa.Name = "Xoa";
            this.Xoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Xoa.OnDisabledState.BorderRadius = 1;
            this.Xoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Xoa.OnDisabledState.BorderThickness = 1;
            this.Xoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Xoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Xoa.OnDisabledState.IconLeftImage = null;
            this.Xoa.OnDisabledState.IconRightImage = null;
            this.Xoa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Xoa.onHoverState.BorderRadius = 1;
            this.Xoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Xoa.onHoverState.BorderThickness = 1;
            this.Xoa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Xoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Xoa.onHoverState.IconLeftImage = null;
            this.Xoa.onHoverState.IconRightImage = null;
            this.Xoa.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Xoa.OnIdleState.BorderRadius = 1;
            this.Xoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Xoa.OnIdleState.BorderThickness = 1;
            this.Xoa.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Xoa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Xoa.OnIdleState.IconLeftImage = null;
            this.Xoa.OnIdleState.IconRightImage = null;
            this.Xoa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Xoa.OnPressedState.BorderRadius = 1;
            this.Xoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Xoa.OnPressedState.BorderThickness = 1;
            this.Xoa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Xoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Xoa.OnPressedState.IconLeftImage = null;
            this.Xoa.OnPressedState.IconRightImage = null;
            this.Xoa.Size = new System.Drawing.Size(80, 24);
            this.Xoa.TabIndex = 0;
            this.Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Xoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Xoa.TextMarginLeft = 0;
            this.Xoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.Xoa.UseDefaultRadiusAndThickness = true;
            this.Xoa.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // Refresh
            // 
            this.Refresh.AllowAnimations = true;
            this.Refresh.AllowMouseEffects = true;
            this.Refresh.AllowToggling = false;
            this.Refresh.AnimationSpeed = 200;
            this.Refresh.AutoGenerateColors = false;
            this.Refresh.AutoRoundBorders = false;
            this.Refresh.AutoSizeLeftIcon = true;
            this.Refresh.AutoSizeRightIcon = true;
            this.Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Refresh.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh.BackgroundImage")));
            this.Refresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Refresh.ButtonText = "        Refresh";
            this.Refresh.ButtonTextMarginLeft = 0;
            this.Refresh.ColorContrastOnClick = 45;
            this.Refresh.ColorContrastOnHover = 45;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.Refresh.CustomizableEdges = borderEdges8;
            this.Refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Refresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Refresh.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Refresh.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Refresh.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refresh.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Refresh.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Refresh.IconMarginLeft = 11;
            this.Refresh.IconPadding = 10;
            this.Refresh.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refresh.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Refresh.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Refresh.IconSize = 25;
            this.Refresh.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.IdleBorderRadius = 1;
            this.Refresh.IdleBorderThickness = 1;
            this.Refresh.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.IdleIconLeftImage = null;
            this.Refresh.IdleIconRightImage = null;
            this.Refresh.IndicateFocus = false;
            this.Refresh.Location = new System.Drawing.Point(113, 127);
            this.Refresh.Name = "Refresh";
            this.Refresh.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Refresh.OnDisabledState.BorderRadius = 1;
            this.Refresh.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Refresh.OnDisabledState.BorderThickness = 1;
            this.Refresh.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Refresh.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Refresh.OnDisabledState.IconLeftImage = null;
            this.Refresh.OnDisabledState.IconRightImage = null;
            this.Refresh.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Refresh.onHoverState.BorderRadius = 1;
            this.Refresh.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Refresh.onHoverState.BorderThickness = 1;
            this.Refresh.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Refresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Refresh.onHoverState.IconLeftImage = null;
            this.Refresh.onHoverState.IconRightImage = null;
            this.Refresh.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.OnIdleState.BorderRadius = 1;
            this.Refresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Refresh.OnIdleState.BorderThickness = 1;
            this.Refresh.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Refresh.OnIdleState.IconLeftImage = null;
            this.Refresh.OnIdleState.IconRightImage = null;
            this.Refresh.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Refresh.OnPressedState.BorderRadius = 1;
            this.Refresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Refresh.OnPressedState.BorderThickness = 1;
            this.Refresh.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Refresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Refresh.OnPressedState.IconLeftImage = null;
            this.Refresh.OnPressedState.IconRightImage = null;
            this.Refresh.Size = new System.Drawing.Size(80, 24);
            this.Refresh.TabIndex = 0;
            this.Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Refresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Refresh.TextMarginLeft = 0;
            this.Refresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.Refresh.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(-16, -16);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 97);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 40;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(-16, -16);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(113, 97);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 40;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 40;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(-16, -16);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(12, 127);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton3.TabIndex = 0;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 40;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click_1);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.ActiveImage = null;
            this.bunifuImageButton4.AllowAnimations = true;
            this.bunifuImageButton4.AllowBuffering = false;
            this.bunifuImageButton4.AllowToggling = false;
            this.bunifuImageButton4.AllowZooming = true;
            this.bunifuImageButton4.AllowZoomingOnFocus = false;
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ErrorImage")));
            this.bunifuImageButton4.FadeWhenInactive = false;
            this.bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.ImageLocation = null;
            this.bunifuImageButton4.ImageMargin = 40;
            this.bunifuImageButton4.ImageSize = new System.Drawing.Size(-16, -16);
            this.bunifuImageButton4.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.bunifuImageButton4.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.InitialImage")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(113, 127);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Rotation = 0;
            this.bunifuImageButton4.ShowActiveImage = true;
            this.bunifuImageButton4.ShowCursorChanges = true;
            this.bunifuImageButton4.ShowImageBorders = true;
            this.bunifuImageButton4.ShowSizeMarkers = false;
            this.bunifuImageButton4.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton4.TabIndex = 0;
            this.bunifuImageButton4.ToolTipText = "";
            this.bunifuImageButton4.WaitOnLoad = false;
            this.bunifuImageButton4.Zoom = 40;
            this.bunifuImageButton4.ZoomSpeed = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click_1);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDanhMuc});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(580, 121);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.FillWeight = 81.21828F;
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 80;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDanhMuc.FillWeight = 118.7817F;
            this.TenDanhMuc.HeaderText = "Tên danh mục ";
            this.TenDanhMuc.Name = "TenDanhMuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Sua;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Them;
        private Bunifu.UI.WinForms.BunifuTextBox Danhmuc;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Refresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Xoa;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
    }
}

