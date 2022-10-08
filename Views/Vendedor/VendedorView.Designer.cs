namespace AppEngSoft.Views.Vendedor
{
  partial class VendedorView
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.PanelVendedor = new System.Windows.Forms.Panel();
      this.PanelLista = new System.Windows.Forms.Panel();
      this.DgvVendedores = new System.Windows.Forms.DataGridView();
      this.TlpActionsLista = new System.Windows.Forms.TableLayoutPanel();
      this.BtnExcluir = new AppEngSoft.CustomControls.KpmButton();
      this.BtnEditar = new AppEngSoft.CustomControls.KpmButton();
      this.BtnNovo = new AppEngSoft.CustomControls.KpmButton();
      this.BtnProcurar = new AppEngSoft.CustomControls.KpmButton();
      this.TxtBoxProcurar = new AppEngSoft.CustomControls.KpmTextBox();
      this.PanelDetalhes = new System.Windows.Forms.Panel();
      this.TlpVendedor = new System.Windows.Forms.TableLayoutPanel();
      this.TxtBoxVendedorID = new AppEngSoft.CustomControls.KpmTextBox();
      this.TxtBoxVendedorNome = new AppEngSoft.CustomControls.KpmTextBox();
      this.TlpActionsDetalhes = new System.Windows.Forms.TableLayoutPanel();
      this.BtnSalvar = new AppEngSoft.CustomControls.KpmButton();
      this.BtnCancelar = new AppEngSoft.CustomControls.KpmButton();
      this.PanelVendedor.SuspendLayout();
      this.PanelLista.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DgvVendedores)).BeginInit();
      this.TlpActionsLista.SuspendLayout();
      this.PanelDetalhes.SuspendLayout();
      this.TlpVendedor.SuspendLayout();
      this.TlpActionsDetalhes.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelVendedor
      // 
      this.PanelVendedor.BackColor = System.Drawing.Color.MediumPurple;
      this.PanelVendedor.Controls.Add(this.PanelLista);
      this.PanelVendedor.Controls.Add(this.PanelDetalhes);
      this.PanelVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelVendedor.Location = new System.Drawing.Point(0, 0);
      this.PanelVendedor.Margin = new System.Windows.Forms.Padding(0);
      this.PanelVendedor.Name = "PanelVendedor";
      this.PanelVendedor.Size = new System.Drawing.Size(1940, 1100);
      this.PanelVendedor.TabIndex = 0;
      // 
      // PanelLista
      // 
      this.PanelLista.BackColor = System.Drawing.Color.Lime;
      this.PanelLista.Controls.Add(this.DgvVendedores);
      this.PanelLista.Controls.Add(this.TlpActionsLista);
      this.PanelLista.Controls.Add(this.TxtBoxProcurar);
      this.PanelLista.Dock = System.Windows.Forms.DockStyle.Right;
      this.PanelLista.Location = new System.Drawing.Point(970, 0);
      this.PanelLista.Margin = new System.Windows.Forms.Padding(0);
      this.PanelLista.Name = "PanelLista";
      this.PanelLista.Size = new System.Drawing.Size(970, 1100);
      this.PanelLista.TabIndex = 1;
      // 
      // DgvVendedores
      // 
      this.DgvVendedores.AllowUserToAddRows = false;
      this.DgvVendedores.AllowUserToDeleteRows = false;
      this.DgvVendedores.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.DgvVendedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.DgvVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DgvVendedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.DgvVendedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DgvVendedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.DgvVendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DgvVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.DgvVendedores.ColumnHeadersHeight = 50;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.DgvVendedores.DefaultCellStyle = dataGridViewCellStyle3;
      this.DgvVendedores.EnableHeadersVisualStyles = false;
      this.DgvVendedores.GridColor = System.Drawing.SystemColors.HotTrack;
      this.DgvVendedores.Location = new System.Drawing.Point(0, 0);
      this.DgvVendedores.Margin = new System.Windows.Forms.Padding(0);
      this.DgvVendedores.MultiSelect = false;
      this.DgvVendedores.Name = "DgvVendedores";
      this.DgvVendedores.ReadOnly = true;
      this.DgvVendedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DgvVendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.DgvVendedores.RowHeadersWidth = 51;
      this.DgvVendedores.RowTemplate.Height = 50;
      this.DgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DgvVendedores.Size = new System.Drawing.Size(970, 996);
      this.DgvVendedores.TabIndex = 11;
      // 
      // TlpActionsLista
      // 
      this.TlpActionsLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TlpActionsLista.ColumnCount = 4;
      this.TlpActionsLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsLista.Controls.Add(this.BtnExcluir, 2, 0);
      this.TlpActionsLista.Controls.Add(this.BtnEditar, 1, 0);
      this.TlpActionsLista.Controls.Add(this.BtnNovo, 3, 0);
      this.TlpActionsLista.Controls.Add(this.BtnProcurar, 0, 0);
      this.TlpActionsLista.Location = new System.Drawing.Point(0, 1062);
      this.TlpActionsLista.Margin = new System.Windows.Forms.Padding(0);
      this.TlpActionsLista.Name = "TlpActionsLista";
      this.TlpActionsLista.RowCount = 1;
      this.TlpActionsLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpActionsLista.Size = new System.Drawing.Size(970, 38);
      this.TlpActionsLista.TabIndex = 9;
      // 
      // BtnExcluir
      // 
      this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnExcluir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnExcluir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnExcluir.BorderRadius = 10;
      this.BtnExcluir.BorderSize = 0;
      this.BtnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BtnExcluir.FlatAppearance.BorderSize = 0;
      this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(174)))));
      this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnExcluir.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnExcluir.Location = new System.Drawing.Point(495, 0);
      this.BtnExcluir.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
      this.BtnExcluir.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnExcluir.Name = "BtnExcluir";
      this.BtnExcluir.Size = new System.Drawing.Size(220, 38);
      this.BtnExcluir.TabIndex = 5;
      this.BtnExcluir.Text = "Excluir";
      this.BtnExcluir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnExcluir.UseVisualStyleBackColor = false;
      // 
      // BtnEditar
      // 
      this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnEditar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnEditar.BorderRadius = 10;
      this.BtnEditar.BorderSize = 0;
      this.BtnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BtnEditar.FlatAppearance.BorderSize = 0;
      this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(174)))));
      this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnEditar.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnEditar.Location = new System.Drawing.Point(253, 0);
      this.BtnEditar.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
      this.BtnEditar.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnEditar.Name = "BtnEditar";
      this.BtnEditar.Size = new System.Drawing.Size(220, 38);
      this.BtnEditar.TabIndex = 4;
      this.BtnEditar.Text = "Editar";
      this.BtnEditar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnEditar.UseVisualStyleBackColor = false;
      // 
      // BtnNovo
      // 
      this.BtnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnNovo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnNovo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnNovo.BorderRadius = 10;
      this.BtnNovo.BorderSize = 0;
      this.BtnNovo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BtnNovo.FlatAppearance.BorderSize = 0;
      this.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(174)))));
      this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnNovo.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnNovo.Location = new System.Drawing.Point(737, 0);
      this.BtnNovo.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
      this.BtnNovo.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnNovo.Name = "BtnNovo";
      this.BtnNovo.Size = new System.Drawing.Size(222, 38);
      this.BtnNovo.TabIndex = 3;
      this.BtnNovo.Text = "Novo";
      this.BtnNovo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnNovo.UseVisualStyleBackColor = false;
      // 
      // BtnProcurar
      // 
      this.BtnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnProcurar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnProcurar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnProcurar.BorderRadius = 10;
      this.BtnProcurar.BorderSize = 0;
      this.BtnProcurar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BtnProcurar.FlatAppearance.BorderSize = 0;
      this.BtnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      this.BtnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(174)))));
      this.BtnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnProcurar.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnProcurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnProcurar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnProcurar.Location = new System.Drawing.Point(11, 0);
      this.BtnProcurar.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
      this.BtnProcurar.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnProcurar.Name = "BtnProcurar";
      this.BtnProcurar.Size = new System.Drawing.Size(220, 38);
      this.BtnProcurar.TabIndex = 6;
      this.BtnProcurar.Text = "Procurar";
      this.BtnProcurar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnProcurar.UseVisualStyleBackColor = false;
      // 
      // TxtBoxProcurar
      // 
      this.TxtBoxProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TxtBoxProcurar.BackColor = System.Drawing.SystemColors.Window;
      this.TxtBoxProcurar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.TxtBoxProcurar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.TxtBoxProcurar.BorderRadius = 5;
      this.TxtBoxProcurar.BorderSize = 1;
      this.TxtBoxProcurar.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TxtBoxProcurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.TxtBoxProcurar.Location = new System.Drawing.Point(11, 1010);
      this.TxtBoxProcurar.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxProcurar.Multiline = false;
      this.TxtBoxProcurar.Name = "TxtBoxProcurar";
      this.TxtBoxProcurar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.TxtBoxProcurar.PasswordChar = false;
      this.TxtBoxProcurar.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(165)))));
      this.TxtBoxProcurar.PlaceHolderText = "Buscar por ID ou Nome";
      this.TxtBoxProcurar.Size = new System.Drawing.Size(948, 37);
      this.TxtBoxProcurar.TabIndex = 10;
      this.TxtBoxProcurar.Texts = "";
      this.TxtBoxProcurar.UnderlinedStyle = false;
      // 
      // PanelDetalhes
      // 
      this.PanelDetalhes.BackColor = System.Drawing.Color.Aqua;
      this.PanelDetalhes.Controls.Add(this.TlpVendedor);
      this.PanelDetalhes.Controls.Add(this.TlpActionsDetalhes);
      this.PanelDetalhes.Dock = System.Windows.Forms.DockStyle.Left;
      this.PanelDetalhes.Location = new System.Drawing.Point(0, 0);
      this.PanelDetalhes.Margin = new System.Windows.Forms.Padding(0);
      this.PanelDetalhes.Name = "PanelDetalhes";
      this.PanelDetalhes.Size = new System.Drawing.Size(970, 1100);
      this.PanelDetalhes.TabIndex = 0;
      // 
      // TlpVendedor
      // 
      this.TlpVendedor.ColumnCount = 1;
      this.TlpVendedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpVendedor.Controls.Add(this.TxtBoxVendedorID, 0, 0);
      this.TlpVendedor.Controls.Add(this.TxtBoxVendedorNome, 0, 1);
      this.TlpVendedor.Location = new System.Drawing.Point(37, 26);
      this.TlpVendedor.Margin = new System.Windows.Forms.Padding(0);
      this.TlpVendedor.Name = "TlpVendedor";
      this.TlpVendedor.RowCount = 2;
      this.TlpVendedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpVendedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpVendedor.Size = new System.Drawing.Size(325, 162);
      this.TlpVendedor.TabIndex = 28;
      // 
      // TxtBoxVendedorID
      // 
      this.TxtBoxVendedorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.TxtBoxVendedorID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.TxtBoxVendedorID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.TxtBoxVendedorID.BorderRadius = 5;
      this.TxtBoxVendedorID.BorderSize = 1;
      this.TxtBoxVendedorID.Enabled = false;
      this.TxtBoxVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TxtBoxVendedorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.TxtBoxVendedorID.Location = new System.Drawing.Point(0, 0);
      this.TxtBoxVendedorID.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxVendedorID.Multiline = false;
      this.TxtBoxVendedorID.Name = "TxtBoxVendedorID";
      this.TxtBoxVendedorID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.TxtBoxVendedorID.PasswordChar = false;
      this.TxtBoxVendedorID.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(165)))));
      this.TxtBoxVendedorID.PlaceHolderText = "ID";
      this.TxtBoxVendedorID.Size = new System.Drawing.Size(325, 35);
      this.TxtBoxVendedorID.TabIndex = 10;
      this.TxtBoxVendedorID.Texts = "";
      this.TxtBoxVendedorID.UnderlinedStyle = false;
      // 
      // TxtBoxVendedorNome
      // 
      this.TxtBoxVendedorNome.BackColor = System.Drawing.SystemColors.Window;
      this.TxtBoxVendedorNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.TxtBoxVendedorNome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.TxtBoxVendedorNome.BorderRadius = 5;
      this.TxtBoxVendedorNome.BorderSize = 1;
      this.TxtBoxVendedorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TxtBoxVendedorNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.TxtBoxVendedorNome.Location = new System.Drawing.Point(0, 81);
      this.TxtBoxVendedorNome.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxVendedorNome.Multiline = false;
      this.TxtBoxVendedorNome.Name = "TxtBoxVendedorNome";
      this.TxtBoxVendedorNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.TxtBoxVendedorNome.PasswordChar = false;
      this.TxtBoxVendedorNome.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(165)))));
      this.TxtBoxVendedorNome.PlaceHolderText = "Nome";
      this.TxtBoxVendedorNome.Size = new System.Drawing.Size(325, 35);
      this.TxtBoxVendedorNome.TabIndex = 13;
      this.TxtBoxVendedorNome.Texts = "";
      this.TxtBoxVendedorNome.UnderlinedStyle = false;
      // 
      // TlpActionsDetalhes
      // 
      this.TlpActionsDetalhes.ColumnCount = 2;
      this.TlpActionsDetalhes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsDetalhes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsDetalhes.Controls.Add(this.BtnSalvar, 1, 0);
      this.TlpActionsDetalhes.Controls.Add(this.BtnCancelar, 0, 0);
      this.TlpActionsDetalhes.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.TlpActionsDetalhes.Location = new System.Drawing.Point(0, 1062);
      this.TlpActionsDetalhes.Margin = new System.Windows.Forms.Padding(0);
      this.TlpActionsDetalhes.Name = "TlpActionsDetalhes";
      this.TlpActionsDetalhes.RowCount = 1;
      this.TlpActionsDetalhes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpActionsDetalhes.Size = new System.Drawing.Size(970, 38);
      this.TlpActionsDetalhes.TabIndex = 10;
      // 
      // BtnSalvar
      // 
      this.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnSalvar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnSalvar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnSalvar.BorderRadius = 10;
      this.BtnSalvar.BorderSize = 0;
      this.BtnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BtnSalvar.FlatAppearance.BorderSize = 0;
      this.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(174)))));
      this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnSalvar.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnSalvar.Location = new System.Drawing.Point(585, 0);
      this.BtnSalvar.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
      this.BtnSalvar.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnSalvar.Name = "BtnSalvar";
      this.BtnSalvar.Size = new System.Drawing.Size(285, 38);
      this.BtnSalvar.TabIndex = 4;
      this.BtnSalvar.Text = "Salvar";
      this.BtnSalvar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnSalvar.UseVisualStyleBackColor = false;
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.BtnCancelar.BorderRadius = 10;
      this.BtnCancelar.BorderSize = 0;
      this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BtnCancelar.FlatAppearance.BorderSize = 0;
      this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(174)))));
      this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnCancelar.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnCancelar.Location = new System.Drawing.Point(100, 0);
      this.BtnCancelar.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
      this.BtnCancelar.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Size = new System.Drawing.Size(285, 38);
      this.BtnCancelar.TabIndex = 6;
      this.BtnCancelar.Text = "Cancelar";
      this.BtnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnCancelar.UseVisualStyleBackColor = false;
      // 
      // VendedorView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1940, 1100);
      this.Controls.Add(this.PanelVendedor);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "VendedorView";
      this.Tag = "Vendedor";
      this.Text = "VendedorView";
      this.PanelVendedor.ResumeLayout(false);
      this.PanelLista.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DgvVendedores)).EndInit();
      this.TlpActionsLista.ResumeLayout(false);
      this.PanelDetalhes.ResumeLayout(false);
      this.TlpVendedor.ResumeLayout(false);
      this.TlpActionsDetalhes.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private Panel PanelVendedor;
        private Panel PanelLista;
        private Panel PanelDetalhes;
        private TableLayoutPanel TlpActionsLista;
        private CustomControls.KpmButton BtnExcluir;
        private CustomControls.KpmButton BtnEditar;
        private CustomControls.KpmButton BtnNovo;
        private CustomControls.KpmButton BtnProcurar;
        private CustomControls.KpmTextBox TxtBoxProcurar;
        private DataGridView DgvVendedores;
    private TableLayoutPanel TlpActionsDetalhes;
    private CustomControls.KpmButton BtnSalvar;
    private CustomControls.KpmButton BtnCancelar;
    private TableLayoutPanel TlpVendedor;
    private CustomControls.KpmTextBox TxtBoxVendedorID;
    private CustomControls.KpmTextBox TxtBoxVendedorNome;
  }
}