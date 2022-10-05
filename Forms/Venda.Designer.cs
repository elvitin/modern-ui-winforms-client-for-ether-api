using AppEngSoft.CustomControls;

namespace AppEngSoft.Forms
{
  partial class Venda
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
      this.LabGrid = new System.Windows.Forms.DataGridView();
      this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TlpActions = new System.Windows.Forms.TableLayoutPanel();
      this.BtnExcluir = new AppEngSoft.CustomControls.KpmButton();
      this.BtnEditar = new AppEngSoft.CustomControls.KpmButton();
      this.BtnNovo = new AppEngSoft.CustomControls.KpmButton();
      this.BtnProcurar = new AppEngSoft.CustomControls.KpmButton();
      ((System.ComponentModel.ISupportInitialize)(this.LabGrid)).BeginInit();
      this.TlpActions.SuspendLayout();
      this.SuspendLayout();
      // 
      // LabGrid
      // 
      this.LabGrid.AllowUserToAddRows = false;
      this.LabGrid.AllowUserToDeleteRows = false;
      this.LabGrid.AllowUserToOrderColumns = true;
      this.LabGrid.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.LabGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.LabGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.LabGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.LabGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.LabGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.LabGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.LabGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.LabGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.LabGrid.ColumnHeadersHeight = 50;
      this.LabGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Email});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.LabGrid.DefaultCellStyle = dataGridViewCellStyle3;
      this.LabGrid.EnableHeadersVisualStyles = false;
      this.LabGrid.GridColor = System.Drawing.SystemColors.HotTrack;
      this.LabGrid.Location = new System.Drawing.Point(0, 0);
      this.LabGrid.Margin = new System.Windows.Forms.Padding(0);
      this.LabGrid.Name = "LabGrid";
      this.LabGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.LabGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.LabGrid.RowHeadersWidth = 51;
      this.LabGrid.RowTemplate.Height = 50;
      this.LabGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.LabGrid.Size = new System.Drawing.Size(902, 543);
      this.LabGrid.TabIndex = 0;
      // 
      // ID
      // 
      this.ID.HeaderText = "ID";
      this.ID.MinimumWidth = 6;
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      // 
      // Nome
      // 
      this.Nome.HeaderText = "Cliente";
      this.Nome.MinimumWidth = 6;
      this.Nome.Name = "Nome";
      this.Nome.ReadOnly = true;
      // 
      // Email
      // 
      this.Email.HeaderText = "Email";
      this.Email.MinimumWidth = 6;
      this.Email.Name = "Email";
      this.Email.ReadOnly = true;
      // 
      // TlpActions
      // 
      this.TlpActions.ColumnCount = 4;
      this.TlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TlpActions.Controls.Add(this.BtnExcluir, 2, 0);
      this.TlpActions.Controls.Add(this.BtnEditar, 1, 0);
      this.TlpActions.Controls.Add(this.BtnNovo, 3, 0);
      this.TlpActions.Controls.Add(this.BtnProcurar, 0, 0);
      this.TlpActions.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.TlpActions.Location = new System.Drawing.Point(0, 563);
      this.TlpActions.Margin = new System.Windows.Forms.Padding(0);
      this.TlpActions.Name = "TlpActions";
      this.TlpActions.RowCount = 1;
      this.TlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpActions.Size = new System.Drawing.Size(902, 40);
      this.TlpActions.TabIndex = 7;
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
      this.BtnExcluir.Location = new System.Drawing.Point(460, 0);
      this.BtnExcluir.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
      this.BtnExcluir.MaximumSize = new System.Drawing.Size(0, 40);
      this.BtnExcluir.Name = "BtnExcluir";
      this.BtnExcluir.Size = new System.Drawing.Size(205, 40);
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
      this.BtnEditar.Location = new System.Drawing.Point(235, 0);
      this.BtnEditar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
      this.BtnEditar.MaximumSize = new System.Drawing.Size(0, 40);
      this.BtnEditar.Name = "BtnEditar";
      this.BtnEditar.Size = new System.Drawing.Size(205, 40);
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
      this.BtnNovo.Location = new System.Drawing.Point(685, 0);
      this.BtnNovo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
      this.BtnNovo.MaximumSize = new System.Drawing.Size(0, 40);
      this.BtnNovo.Name = "BtnNovo";
      this.BtnNovo.Size = new System.Drawing.Size(207, 40);
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
      this.BtnProcurar.Location = new System.Drawing.Point(10, 0);
      this.BtnProcurar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
      this.BtnProcurar.MaximumSize = new System.Drawing.Size(0, 40);
      this.BtnProcurar.Name = "BtnProcurar";
      this.BtnProcurar.Size = new System.Drawing.Size(205, 40);
      this.BtnProcurar.TabIndex = 6;
      this.BtnProcurar.Text = "Procurar";
      this.BtnProcurar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.BtnProcurar.UseVisualStyleBackColor = false;
      // 
      // Venda
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.ClientSize = new System.Drawing.Size(902, 603);
      this.Controls.Add(this.TlpActions);
      this.Controls.Add(this.LabGrid);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Venda";
      this.Text = "Venda";
      ((System.ComponentModel.ISupportInitialize)(this.LabGrid)).EndInit();
      this.TlpActions.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DataGridView LabGrid;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn Nome;
    private DataGridViewTextBoxColumn Email;
    private TableLayoutPanel TlpActions;
    private KpmButton BtnExcluir;
    private KpmButton BtnEditar;
    private KpmButton BtnNovo;
    private KpmButton BtnProcurar;
  }
}