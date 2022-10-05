namespace AppEngSoft.CustomControls
{
  partial class KpmTextBox
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.TxtBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // TxtBox
      // 
      this.TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.TxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TxtBox.Location = new System.Drawing.Point(10, 7);
      this.TxtBox.Margin = new System.Windows.Forms.Padding(0);
      this.TxtBox.Name = "TxtBox";
      this.TxtBox.Size = new System.Drawing.Size(230, 18);
      this.TxtBox.TabIndex = 0;
      this.TxtBox.Click += new System.EventHandler(this.TxtBox_Click);
      this.TxtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
      this.TxtBox.Enter += new System.EventHandler(this.TxtBox_Enter);
      this.TxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_KeyPress);
      this.TxtBox.Leave += new System.EventHandler(this.TxtBox_Leave);
      this.TxtBox.MouseEnter += new System.EventHandler(this.TxtBox_MouseEnter);
      this.TxtBox.MouseLeave += new System.EventHandler(this.TxtBox_MouseLeave);
      // 
      // KpmTextBox
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.Controls.Add(this.TxtBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "KpmTextBox";
      this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
      this.Size = new System.Drawing.Size(250, 30);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox TxtBox;
  }
}
