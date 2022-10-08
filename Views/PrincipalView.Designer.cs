namespace AppEngSoft.Views
{
  partial class PrincipalView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalView));
      this.PanelMenu = new System.Windows.Forms.Panel();
      this.BtnVendedores = new System.Windows.Forms.Button();
      this.BtnCliente = new System.Windows.Forms.Button();
      this.BtnProduto = new System.Windows.Forms.Button();
      this.BtnVenda = new System.Windows.Forms.Button();
      this.PanelPerfil = new System.Windows.Forms.Panel();
      this.TlpPerfil = new System.Windows.Forms.TableLayoutPanel();
      this.CircularPicBoxPerfil = new KpmUiKit.CommonControls.KpmCircularPictureBox();
      this.LinkLabelPerfil = new System.Windows.Forms.LinkLabel();
      this.PanelHeader = new System.Windows.Forms.Panel();
      this.TlpPrincipalAcoes = new System.Windows.Forms.TableLayoutPanel();
      this.BtnMinimize = new System.Windows.Forms.Button();
      this.BtnMaximizeRestore = new System.Windows.Forms.Button();
      this.BtnClose = new System.Windows.Forms.Button();
      this.BtnCloseChildForm = new System.Windows.Forms.Button();
      this.LabelHeader = new System.Windows.Forms.Label();
      this.PanelDesktop = new System.Windows.Forms.Panel();
      this.PanelMenu.SuspendLayout();
      this.PanelPerfil.SuspendLayout();
      this.TlpPerfil.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CircularPicBoxPerfil)).BeginInit();
      this.PanelHeader.SuspendLayout();
      this.TlpPrincipalAcoes.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelMenu
      // 
      this.PanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.PanelMenu.AutoSize = true;
      this.PanelMenu.BackColor = System.Drawing.Color.White;
      this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PanelMenu.Controls.Add(this.BtnVendedores);
      this.PanelMenu.Controls.Add(this.BtnCliente);
      this.PanelMenu.Controls.Add(this.BtnProduto);
      this.PanelMenu.Controls.Add(this.BtnVenda);
      this.PanelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.PanelMenu.Location = new System.Drawing.Point(0, 260);
      this.PanelMenu.Margin = new System.Windows.Forms.Padding(0);
      this.PanelMenu.Name = "PanelMenu";
      this.PanelMenu.Size = new System.Drawing.Size(239, 440);
      this.PanelMenu.TabIndex = 0;
      // 
      // BtnVendedores
      // 
      this.BtnVendedores.Dock = System.Windows.Forms.DockStyle.Top;
      this.BtnVendedores.FlatAppearance.BorderSize = 0;
      this.BtnVendedores.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.BtnVendedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.BtnVendedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
      this.BtnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnVendedores.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnVendedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.BtnVendedores.Image = global::AppEngSoft.Properties.Resources.icons8_supplier_48;
      this.BtnVendedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnVendedores.Location = new System.Drawing.Point(0, 180);
      this.BtnVendedores.Margin = new System.Windows.Forms.Padding(0);
      this.BtnVendedores.Name = "BtnVendedores";
      this.BtnVendedores.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
      this.BtnVendedores.Size = new System.Drawing.Size(235, 60);
      this.BtnVendedores.TabIndex = 5;
      this.BtnVendedores.Text = " Vendedores";
      this.BtnVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnVendedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BtnVendedores.UseVisualStyleBackColor = true;
      this.BtnVendedores.Click += new System.EventHandler(this.BtnVendedores_Click);
      // 
      // BtnCliente
      // 
      this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
      this.BtnCliente.FlatAppearance.BorderSize = 0;
      this.BtnCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.BtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
      this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnCliente.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.BtnCliente.Image = global::AppEngSoft.Properties.Resources.icons8_customer_48;
      this.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnCliente.Location = new System.Drawing.Point(0, 120);
      this.BtnCliente.Margin = new System.Windows.Forms.Padding(0);
      this.BtnCliente.Name = "BtnCliente";
      this.BtnCliente.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
      this.BtnCliente.Size = new System.Drawing.Size(235, 60);
      this.BtnCliente.TabIndex = 3;
      this.BtnCliente.Text = " Cliente";
      this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BtnCliente.UseVisualStyleBackColor = true;
      this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
      // 
      // BtnProduto
      // 
      this.BtnProduto.Dock = System.Windows.Forms.DockStyle.Top;
      this.BtnProduto.FlatAppearance.BorderSize = 0;
      this.BtnProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.BtnProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.BtnProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
      this.BtnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnProduto.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.BtnProduto.Image = global::AppEngSoft.Properties.Resources.icons8_product_48;
      this.BtnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnProduto.Location = new System.Drawing.Point(0, 60);
      this.BtnProduto.Margin = new System.Windows.Forms.Padding(0);
      this.BtnProduto.Name = "BtnProduto";
      this.BtnProduto.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
      this.BtnProduto.Size = new System.Drawing.Size(235, 60);
      this.BtnProduto.TabIndex = 2;
      this.BtnProduto.Text = " Produto";
      this.BtnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BtnProduto.UseVisualStyleBackColor = true;
      this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
      // 
      // BtnVenda
      // 
      this.BtnVenda.Dock = System.Windows.Forms.DockStyle.Top;
      this.BtnVenda.FlatAppearance.BorderSize = 0;
      this.BtnVenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.BtnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.BtnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
      this.BtnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnVenda.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.BtnVenda.Image = global::AppEngSoft.Properties.Resources.icons8_shopping_cart_48;
      this.BtnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnVenda.Location = new System.Drawing.Point(0, 0);
      this.BtnVenda.Margin = new System.Windows.Forms.Padding(0);
      this.BtnVenda.Name = "BtnVenda";
      this.BtnVenda.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
      this.BtnVenda.Size = new System.Drawing.Size(235, 60);
      this.BtnVenda.TabIndex = 1;
      this.BtnVenda.Tag = "";
      this.BtnVenda.Text = " Venda";
      this.BtnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BtnVenda.UseVisualStyleBackColor = true;
      // 
      // PanelPerfil
      // 
      this.PanelPerfil.BackColor = System.Drawing.Color.White;
      this.PanelPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PanelPerfil.Controls.Add(this.TlpPerfil);
      this.PanelPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.PanelPerfil.Location = new System.Drawing.Point(0, 0);
      this.PanelPerfil.Margin = new System.Windows.Forms.Padding(0);
      this.PanelPerfil.Name = "PanelPerfil";
      this.PanelPerfil.Size = new System.Drawing.Size(239, 262);
      this.PanelPerfil.TabIndex = 0;
      // 
      // TlpPerfil
      // 
      this.TlpPerfil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.TlpPerfil.ColumnCount = 1;
      this.TlpPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpPerfil.Controls.Add(this.CircularPicBoxPerfil, 0, 0);
      this.TlpPerfil.Controls.Add(this.LinkLabelPerfil, 0, 1);
      this.TlpPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TlpPerfil.Location = new System.Drawing.Point(0, 0);
      this.TlpPerfil.Margin = new System.Windows.Forms.Padding(0);
      this.TlpPerfil.Name = "TlpPerfil";
      this.TlpPerfil.RowCount = 2;
      this.TlpPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.TlpPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.TlpPerfil.Size = new System.Drawing.Size(235, 258);
      this.TlpPerfil.TabIndex = 5;
      // 
      // CircularPicBoxPerfil
      // 
      this.CircularPicBoxPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
      this.CircularPicBoxPerfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      this.CircularPicBoxPerfil.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      this.CircularPicBoxPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
      this.CircularPicBoxPerfil.BorderSize = 0;
      this.CircularPicBoxPerfil.Dock = System.Windows.Forms.DockStyle.Top;
      this.CircularPicBoxPerfil.GradientAngle = 0F;
      this.CircularPicBoxPerfil.Image = global::AppEngSoft.Properties.Resources.victor_profile;
      this.CircularPicBoxPerfil.Location = new System.Drawing.Point(30, 20);
      this.CircularPicBoxPerfil.Margin = new System.Windows.Forms.Padding(30, 20, 30, 0);
      this.CircularPicBoxPerfil.Name = "CircularPicBoxPerfil";
      this.CircularPicBoxPerfil.Size = new System.Drawing.Size(175, 175);
      this.CircularPicBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.CircularPicBoxPerfil.TabIndex = 0;
      this.CircularPicBoxPerfil.TabStop = false;
      this.CircularPicBoxPerfil.Click += new System.EventHandler(this.CircularPicBoxPerfil_Click);
      // 
      // LinkLabelPerfil
      // 
      this.LinkLabelPerfil.AutoSize = true;
      this.LinkLabelPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LinkLabelPerfil.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.LinkLabelPerfil.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
      this.LinkLabelPerfil.Location = new System.Drawing.Point(0, 195);
      this.LinkLabelPerfil.Margin = new System.Windows.Forms.Padding(0);
      this.LinkLabelPerfil.Name = "LinkLabelPerfil";
      this.LinkLabelPerfil.Size = new System.Drawing.Size(235, 63);
      this.LinkLabelPerfil.TabIndex = 1;
      this.LinkLabelPerfil.TabStop = true;
      this.LinkLabelPerfil.Text = "Victor Rodrigues";
      this.LinkLabelPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.LinkLabelPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPerfil_LinkClicked);
      // 
      // PanelHeader
      // 
      this.PanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PanelHeader.BackColor = System.Drawing.Color.White;
      this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PanelHeader.Controls.Add(this.TlpPrincipalAcoes);
      this.PanelHeader.Controls.Add(this.BtnCloseChildForm);
      this.PanelHeader.Controls.Add(this.LabelHeader);
      this.PanelHeader.Location = new System.Drawing.Point(232, 0);
      this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
      this.PanelHeader.Name = "PanelHeader";
      this.PanelHeader.Size = new System.Drawing.Size(1178, 80);
      this.PanelHeader.TabIndex = 0;
      // 
      // TlpPrincipalAcoes
      // 
      this.TlpPrincipalAcoes.AutoSize = true;
      this.TlpPrincipalAcoes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.TlpPrincipalAcoes.ColumnCount = 3;
      this.TlpPrincipalAcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.TlpPrincipalAcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.TlpPrincipalAcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
      this.TlpPrincipalAcoes.Controls.Add(this.BtnMinimize, 0, 0);
      this.TlpPrincipalAcoes.Controls.Add(this.BtnMaximizeRestore, 1, 0);
      this.TlpPrincipalAcoes.Controls.Add(this.BtnClose, 2, 0);
      this.TlpPrincipalAcoes.Dock = System.Windows.Forms.DockStyle.Right;
      this.TlpPrincipalAcoes.Location = new System.Drawing.Point(1056, 0);
      this.TlpPrincipalAcoes.Margin = new System.Windows.Forms.Padding(0);
      this.TlpPrincipalAcoes.Name = "TlpPrincipalAcoes";
      this.TlpPrincipalAcoes.Padding = new System.Windows.Forms.Padding(2);
      this.TlpPrincipalAcoes.RowCount = 1;
      this.TlpPrincipalAcoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpPrincipalAcoes.Size = new System.Drawing.Size(118, 76);
      this.TlpPrincipalAcoes.TabIndex = 0;
      // 
      // BtnMinimize
      // 
      this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnMinimize.AutoSize = true;
      this.BtnMinimize.FlatAppearance.BorderSize = 0;
      this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnMinimize.Image = global::AppEngSoft.Properties.Resources.icons8_minimize_window_32;
      this.BtnMinimize.Location = new System.Drawing.Point(2, 2);
      this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
      this.BtnMinimize.Name = "BtnMinimize";
      this.BtnMinimize.Size = new System.Drawing.Size(37, 38);
      this.BtnMinimize.TabIndex = 4;
      this.BtnMinimize.UseVisualStyleBackColor = true;
      this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
      // 
      // BtnMaximizeRestore
      // 
      this.BtnMaximizeRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnMaximizeRestore.AutoSize = true;
      this.BtnMaximizeRestore.FlatAppearance.BorderSize = 0;
      this.BtnMaximizeRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnMaximizeRestore.Image = global::AppEngSoft.Properties.Resources.icons8_maximize_button_32;
      this.BtnMaximizeRestore.Location = new System.Drawing.Point(39, 2);
      this.BtnMaximizeRestore.Margin = new System.Windows.Forms.Padding(0);
      this.BtnMaximizeRestore.Name = "BtnMaximizeRestore";
      this.BtnMaximizeRestore.Size = new System.Drawing.Size(37, 38);
      this.BtnMaximizeRestore.TabIndex = 3;
      this.BtnMaximizeRestore.UseVisualStyleBackColor = true;
      this.BtnMaximizeRestore.Click += new System.EventHandler(this.BtnMaximizeRestore_Click);
      // 
      // BtnClose
      // 
      this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnClose.AutoSize = true;
      this.BtnClose.FlatAppearance.BorderSize = 0;
      this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnClose.Image = global::AppEngSoft.Properties.Resources.icons8_close_32;
      this.BtnClose.Location = new System.Drawing.Point(78, 2);
      this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(38, 38);
      this.BtnClose.TabIndex = 2;
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // BtnCloseChildForm
      // 
      this.BtnCloseChildForm.AutoSize = true;
      this.BtnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
      this.BtnCloseChildForm.FlatAppearance.BorderSize = 0;
      this.BtnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseChildForm.Image")));
      this.BtnCloseChildForm.Location = new System.Drawing.Point(0, 0);
      this.BtnCloseChildForm.Name = "BtnCloseChildForm";
      this.BtnCloseChildForm.Size = new System.Drawing.Size(63, 76);
      this.BtnCloseChildForm.TabIndex = 1;
      this.BtnCloseChildForm.UseVisualStyleBackColor = true;
      this.BtnCloseChildForm.Visible = false;
      this.BtnCloseChildForm.Click += new System.EventHandler(this.BtnCloseChildForm_Click);
      // 
      // LabelHeader
      // 
      this.LabelHeader.BackColor = System.Drawing.Color.White;
      this.LabelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.LabelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.LabelHeader.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.LabelHeader.Location = new System.Drawing.Point(0, 0);
      this.LabelHeader.Margin = new System.Windows.Forms.Padding(0);
      this.LabelHeader.Name = "LabelHeader";
      this.LabelHeader.Size = new System.Drawing.Size(1174, 76);
      this.LabelHeader.TabIndex = 0;
      this.LabelHeader.Text = "Ether ERP";
      this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.LabelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelHeader_MouseDown);
      // 
      // PanelDesktop
      // 
      this.PanelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.PanelDesktop.ForeColor = System.Drawing.Color.IndianRed;
      this.PanelDesktop.Location = new System.Drawing.Point(239, 80);
      this.PanelDesktop.Margin = new System.Windows.Forms.Padding(0);
      this.PanelDesktop.Name = "PanelDesktop";
      this.PanelDesktop.Padding = new System.Windows.Forms.Padding(20);
      this.PanelDesktop.Size = new System.Drawing.Size(1171, 620);
      this.PanelDesktop.TabIndex = 2;
      // 
      // PrincipalView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(1410, 700);
      this.ControlBox = false;
      this.Controls.Add(this.PanelDesktop);
      this.Controls.Add(this.PanelPerfil);
      this.Controls.Add(this.PanelMenu);
      this.Controls.Add(this.PanelHeader);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MinimumSize = new System.Drawing.Size(1410, 700);
      this.Name = "PrincipalView";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Ether Solutions";
      this.PanelMenu.ResumeLayout(false);
      this.PanelPerfil.ResumeLayout(false);
      this.TlpPerfil.ResumeLayout(false);
      this.TlpPerfil.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CircularPicBoxPerfil)).EndInit();
      this.PanelHeader.ResumeLayout(false);
      this.PanelHeader.PerformLayout();
      this.TlpPrincipalAcoes.ResumeLayout(false);
      this.TlpPrincipalAcoes.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Panel PanelMenu;
    private Button BtnVenda;
    private Panel PanelPerfil;
    private Button BtnVendedores;
    private Button BtnCliente;
    private Button BtnProduto;
    private Panel PanelHeader;
    private Label LabelHeader;
    private Panel PanelDesktop;
    private Button BtnCloseChildForm;
    private Button BtnClose;
    private Button BtnMinimize;
    private Button BtnMaximizeRestore;
    private TableLayoutPanel TlpPrincipalAcoes;
    private KpmUiKit.CommonControls.KpmCircularPictureBox CircularPicBoxPerfil;
    private LinkLabel LinkLabelPerfil;
    private TableLayoutPanel TlpPerfil;
  }
}