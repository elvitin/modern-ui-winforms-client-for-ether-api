namespace FlatUI.Forms
{
  partial class Cliente
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
      this.PanelCliente = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // PanelCliente
      // 
      this.PanelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelCliente.Location = new System.Drawing.Point(0, 0);
      this.PanelCliente.Name = "PanelCliente";
      this.PanelCliente.Size = new System.Drawing.Size(994, 475);
      this.PanelCliente.TabIndex = 0;
      // 
      // Cliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(994, 475);
      this.Controls.Add(this.PanelCliente);
      this.Name = "Cliente";
      this.Text = "Cliente";
      this.ResumeLayout(false);

    }

        #endregion

        private Panel PanelCliente;
    }
}