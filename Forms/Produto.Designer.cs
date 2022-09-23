namespace FlatUI.Forms
{
  partial class Produto
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
      this.ProdutoBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // ProdutoBtn
      // 
      resources.ApplyResources(this.ProdutoBtn, "ProdutoBtn");
      this.ProdutoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(133)))), ((int)(((byte)(111)))));
      this.ProdutoBtn.FlatAppearance.BorderSize = 0;
      this.ProdutoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
      this.ProdutoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(209)))), ((int)(((byte)(174)))));
      this.ProdutoBtn.ForeColor = System.Drawing.SystemColors.Window;
      this.ProdutoBtn.Image = global::FlatUI.Properties.Resources.shopping_list;
      this.ProdutoBtn.Name = "ProdutoBtn";
      this.ProdutoBtn.UseVisualStyleBackColor = false;
      this.ProdutoBtn.UseWaitCursor = true;
      this.ProdutoBtn.Click += new System.EventHandler(this.ProdutoBtn_Click);
      // 
      // Produto
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.ProdutoBtn);
      this.ForeColor = System.Drawing.Color.White;
      this.Name = "Produto";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Button ProdutoBtn;
    }
}