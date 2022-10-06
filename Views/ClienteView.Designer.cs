namespace AppEngSoft.Views
{
  partial class ClienteView
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
      this.DgvClientes = new System.Windows.Forms.DataGridView();
      this.PanelCliente = new System.Windows.Forms.Panel();
      this.PanelLista = new System.Windows.Forms.Panel();
      this.TxtBoxProcurar = new AppEngSoft.CustomControls.KpmTextBox();
      this.TlpActionsLista = new System.Windows.Forms.TableLayoutPanel();
      this.BtnExcluir = new AppEngSoft.CustomControls.KpmButton();
      this.BtnEditar = new AppEngSoft.CustomControls.KpmButton();
      this.BtnNovo = new AppEngSoft.CustomControls.KpmButton();
      this.BtnProcurar = new AppEngSoft.CustomControls.KpmButton();
      this.PanelDetalhes = new System.Windows.Forms.Panel();
      this.TxtBoxFone = new AppEngSoft.CustomControls.KpmTextBox();
      this.TxtBoxNome = new AppEngSoft.CustomControls.KpmTextBox();
      this.TxtBoxEmail = new AppEngSoft.CustomControls.KpmTextBox();
      this.TxtBoxID = new AppEngSoft.CustomControls.KpmTextBox();
      this.TlpActionsDetalhes = new System.Windows.Forms.TableLayoutPanel();
      this.BtnSalvar = new AppEngSoft.CustomControls.KpmButton();
      this.BtnCancelar = new AppEngSoft.CustomControls.KpmButton();
      ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
      this.PanelCliente.SuspendLayout();
      this.PanelLista.SuspendLayout();
      this.TlpActionsLista.SuspendLayout();
      this.PanelDetalhes.SuspendLayout();
      this.TlpActionsDetalhes.SuspendLayout();
      this.SuspendLayout();
      // 
      // DgvClientes
      // 
      this.DgvClientes.AllowUserToAddRows = false;
      this.DgvClientes.AllowUserToDeleteRows = false;
      this.DgvClientes.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.DgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.DgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.DgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.DgvClientes.ColumnHeadersHeight = 50;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.DgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
      this.DgvClientes.EnableHeadersVisualStyles = false;
      this.DgvClientes.GridColor = System.Drawing.SystemColors.HotTrack;
      this.DgvClientes.Location = new System.Drawing.Point(0, 0);
      this.DgvClientes.Margin = new System.Windows.Forms.Padding(0);
      this.DgvClientes.MultiSelect = false;
      this.DgvClientes.Name = "DgvClientes";
      this.DgvClientes.ReadOnly = true;
      this.DgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.DgvClientes.RowHeadersWidth = 51;
      this.DgvClientes.RowTemplate.Height = 50;
      this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DgvClientes.Size = new System.Drawing.Size(1125, 370);
      this.DgvClientes.TabIndex = 1;
      // 
      // PanelCliente
      // 
      this.PanelCliente.Controls.Add(this.PanelLista);
      this.PanelCliente.Controls.Add(this.PanelDetalhes);
      this.PanelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelCliente.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PanelCliente.Location = new System.Drawing.Point(0, 0);
      this.PanelCliente.Margin = new System.Windows.Forms.Padding(0);
      this.PanelCliente.Name = "PanelCliente";
      this.PanelCliente.Size = new System.Drawing.Size(1179, 1002);
      this.PanelCliente.TabIndex = 2;
      // 
      // PanelLista
      // 
      this.PanelLista.Controls.Add(this.TxtBoxProcurar);
      this.PanelLista.Controls.Add(this.TlpActionsLista);
      this.PanelLista.Controls.Add(this.DgvClientes);
      this.PanelLista.Location = new System.Drawing.Point(0, 475);
      this.PanelLista.Margin = new System.Windows.Forms.Padding(0);
      this.PanelLista.Name = "PanelLista";
      this.PanelLista.Size = new System.Drawing.Size(1125, 475);
      this.PanelLista.TabIndex = 3;
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
      this.TxtBoxProcurar.Location = new System.Drawing.Point(11, 383);
      this.TxtBoxProcurar.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxProcurar.Multiline = false;
      this.TxtBoxProcurar.Name = "TxtBoxProcurar";
      this.TxtBoxProcurar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.TxtBoxProcurar.PasswordChar = false;
      this.TxtBoxProcurar.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(165)))));
      this.TxtBoxProcurar.PlaceHolderText = "";
      this.TxtBoxProcurar.Size = new System.Drawing.Size(1103, 37);
      this.TxtBoxProcurar.TabIndex = 9;
      this.TxtBoxProcurar.Texts = "";
      this.TxtBoxProcurar.UnderlinedStyle = false;
      // 
      // TlpActionsLista
      // 
      this.TlpActionsLista.ColumnCount = 4;
      this.TlpActionsLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsLista.Controls.Add(this.BtnExcluir, 2, 0);
      this.TlpActionsLista.Controls.Add(this.BtnEditar, 1, 0);
      this.TlpActionsLista.Controls.Add(this.BtnNovo, 3, 0);
      this.TlpActionsLista.Controls.Add(this.BtnProcurar, 0, 0);
      this.TlpActionsLista.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.TlpActionsLista.Location = new System.Drawing.Point(0, 437);
      this.TlpActionsLista.Margin = new System.Windows.Forms.Padding(0);
      this.TlpActionsLista.Name = "TlpActionsLista";
      this.TlpActionsLista.RowCount = 1;
      this.TlpActionsLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpActionsLista.Size = new System.Drawing.Size(1125, 38);
      this.TlpActionsLista.TabIndex = 8;
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
      this.BtnExcluir.Location = new System.Drawing.Point(573, 0);
      this.BtnExcluir.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
      this.BtnExcluir.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnExcluir.Name = "BtnExcluir";
      this.BtnExcluir.Size = new System.Drawing.Size(259, 38);
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
      this.BtnEditar.Location = new System.Drawing.Point(292, 0);
      this.BtnEditar.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
      this.BtnEditar.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnEditar.Name = "BtnEditar";
      this.BtnEditar.Size = new System.Drawing.Size(259, 38);
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
      this.BtnNovo.Location = new System.Drawing.Point(854, 0);
      this.BtnNovo.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
      this.BtnNovo.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnNovo.Name = "BtnNovo";
      this.BtnNovo.Size = new System.Drawing.Size(260, 38);
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
      this.BtnProcurar.Size = new System.Drawing.Size(259, 38);
      this.BtnProcurar.TabIndex = 6;
      this.BtnProcurar.Text = "Procurar";
      this.BtnProcurar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnProcurar.UseVisualStyleBackColor = false;
      // 
      // PanelDetalhes
      // 
      this.PanelDetalhes.Controls.Add(this.TxtBoxFone);
      this.PanelDetalhes.Controls.Add(this.TxtBoxNome);
      this.PanelDetalhes.Controls.Add(this.TxtBoxEmail);
      this.PanelDetalhes.Controls.Add(this.TxtBoxID);
      this.PanelDetalhes.Controls.Add(this.TlpActionsDetalhes);
      this.PanelDetalhes.Location = new System.Drawing.Point(0, 0);
      this.PanelDetalhes.Margin = new System.Windows.Forms.Padding(0);
      this.PanelDetalhes.Name = "PanelDetalhes";
      this.PanelDetalhes.Size = new System.Drawing.Size(1125, 475);
      this.PanelDetalhes.TabIndex = 2;
      // 
      // TxtBoxFone
      // 
      this.TxtBoxFone.BackColor = System.Drawing.SystemColors.Window;
      this.TxtBoxFone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.TxtBoxFone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.TxtBoxFone.BorderRadius = 5;
      this.TxtBoxFone.BorderSize = 1;
      this.TxtBoxFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TxtBoxFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.TxtBoxFone.Location = new System.Drawing.Point(45, 166);
      this.TxtBoxFone.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxFone.Multiline = false;
      this.TxtBoxFone.Name = "TxtBoxFone";
      this.TxtBoxFone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.TxtBoxFone.PasswordChar = false;
      this.TxtBoxFone.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(165)))));
      this.TxtBoxFone.PlaceHolderText = "Fone";
      this.TxtBoxFone.Size = new System.Drawing.Size(312, 35);
      this.TxtBoxFone.TabIndex = 14;
      this.TxtBoxFone.Texts = "";
      this.TxtBoxFone.UnderlinedStyle = false;
      // 
      // TxtBoxNome
      // 
      this.TxtBoxNome.BackColor = System.Drawing.SystemColors.Window;
      this.TxtBoxNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.TxtBoxNome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.TxtBoxNome.BorderRadius = 5;
      this.TxtBoxNome.BorderSize = 1;
      this.TxtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TxtBoxNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.TxtBoxNome.Location = new System.Drawing.Point(45, 102);
      this.TxtBoxNome.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxNome.Multiline = false;
      this.TxtBoxNome.Name = "TxtBoxNome";
      this.TxtBoxNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.TxtBoxNome.PasswordChar = false;
      this.TxtBoxNome.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(165)))));
      this.TxtBoxNome.PlaceHolderText = "Nome";
      this.TxtBoxNome.Size = new System.Drawing.Size(312, 35);
      this.TxtBoxNome.TabIndex = 13;
      this.TxtBoxNome.Texts = "";
      this.TxtBoxNome.UnderlinedStyle = false;
      // 
      // TxtBoxEmail
      // 
      this.TxtBoxEmail.BackColor = System.Drawing.SystemColors.Window;
      this.TxtBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.TxtBoxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.TxtBoxEmail.BorderRadius = 5;
      this.TxtBoxEmail.BorderSize = 1;
      this.TxtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TxtBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.TxtBoxEmail.Location = new System.Drawing.Point(45, 229);
      this.TxtBoxEmail.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxEmail.Multiline = false;
      this.TxtBoxEmail.Name = "TxtBoxEmail";
      this.TxtBoxEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.TxtBoxEmail.PasswordChar = false;
      this.TxtBoxEmail.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(165)))));
      this.TxtBoxEmail.PlaceHolderText = "Email";
      this.TxtBoxEmail.Size = new System.Drawing.Size(312, 35);
      this.TxtBoxEmail.TabIndex = 11;
      this.TxtBoxEmail.Texts = "";
      this.TxtBoxEmail.UnderlinedStyle = false;
      // 
      // TxtBoxID
      // 
      this.TxtBoxID.BackColor = System.Drawing.SystemColors.Window;
      this.TxtBoxID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
      this.TxtBoxID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.TxtBoxID.BorderRadius = 5;
      this.TxtBoxID.BorderSize = 1;
      this.TxtBoxID.Enabled = false;
      this.TxtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TxtBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.TxtBoxID.Location = new System.Drawing.Point(45, 35);
      this.TxtBoxID.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBoxID.Multiline = false;
      this.TxtBoxID.Name = "TxtBoxID";
      this.TxtBoxID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.TxtBoxID.PasswordChar = false;
      this.TxtBoxID.PlaceHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(165)))));
      this.TxtBoxID.PlaceHolderText = "ID";
      this.TxtBoxID.Size = new System.Drawing.Size(312, 35);
      this.TxtBoxID.TabIndex = 10;
      this.TxtBoxID.Texts = "";
      this.TxtBoxID.UnderlinedStyle = false;
      // 
      // TlpActionsDetalhes
      // 
      this.TlpActionsDetalhes.ColumnCount = 2;
      this.TlpActionsDetalhes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsDetalhes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActionsDetalhes.Controls.Add(this.BtnSalvar, 1, 0);
      this.TlpActionsDetalhes.Controls.Add(this.BtnCancelar, 0, 0);
      this.TlpActionsDetalhes.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.TlpActionsDetalhes.Location = new System.Drawing.Point(0, 437);
      this.TlpActionsDetalhes.Margin = new System.Windows.Forms.Padding(0);
      this.TlpActionsDetalhes.Name = "TlpActionsDetalhes";
      this.TlpActionsDetalhes.RowCount = 1;
      this.TlpActionsDetalhes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpActionsDetalhes.Size = new System.Drawing.Size(1125, 38);
      this.TlpActionsDetalhes.TabIndex = 9;
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
      this.BtnSalvar.Location = new System.Drawing.Point(707, 0);
      this.BtnSalvar.Margin = new System.Windows.Forms.Padding(145, 0, 145, 0);
      this.BtnSalvar.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnSalvar.Name = "BtnSalvar";
      this.BtnSalvar.Size = new System.Drawing.Size(273, 38);
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
      this.BtnCancelar.Location = new System.Drawing.Point(145, 0);
      this.BtnCancelar.Margin = new System.Windows.Forms.Padding(145, 0, 145, 0);
      this.BtnCancelar.MaximumSize = new System.Drawing.Size(0, 38);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Size = new System.Drawing.Size(272, 38);
      this.BtnCancelar.TabIndex = 6;
      this.BtnCancelar.Text = "Cancelar";
      this.BtnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnCancelar.UseVisualStyleBackColor = false;
      // 
      // ClienteView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.ClientSize = new System.Drawing.Size(1179, 1002);
      this.ControlBox = false;
      this.Controls.Add(this.PanelCliente);
      this.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "ClienteView";
      this.Text = "ClienteView";
      ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
      this.PanelCliente.ResumeLayout(false);
      this.PanelLista.ResumeLayout(false);
      this.TlpActionsLista.ResumeLayout(false);
      this.PanelDetalhes.ResumeLayout(false);
      this.TlpActionsDetalhes.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private DataGridView DgvClientes;
    private Panel PanelCliente;
    private Panel PanelLista;
    private Panel PanelDetalhes;
    private TableLayoutPanel TlpActionsLista;
    private CustomControls.KpmButton BtnExcluir;
    private CustomControls.KpmButton BtnEditar;
    private CustomControls.KpmButton BtnNovo;
    private CustomControls.KpmButton BtnProcurar;
    private CustomControls.KpmTextBox TxtBoxProcurar;
        private TableLayoutPanel TlpActionsDetalhes;
        private CustomControls.KpmButton BtnSalvar;
        private CustomControls.KpmButton BtnCancelar;
        private CustomControls.KpmTextBox TxtBoxFone;
        private CustomControls.KpmTextBox TxtBoxNome;
        private CustomControls.KpmTextBox TxtBoxEmail;
        private CustomControls.KpmTextBox TxtBoxID;
    }
}