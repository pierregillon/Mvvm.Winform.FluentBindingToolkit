using Mvvm.Winform.FluentBindingToolkit.Controls;

namespace Examples
{
    partial class MainForm
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
            this.btnNoBinding = new Mvvm.Winform.FluentBindingToolkit.Controls.CommandButton();
            this.btnShowSimpleForm = new Mvvm.Winform.FluentBindingToolkit.Controls.CommandButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSimpleFormToolStripMenuItem = new CommandToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNoBinding
            // 
            this.btnNoBinding.Enabled = false;
            this.btnNoBinding.Location = new System.Drawing.Point(0, 27);
            this.btnNoBinding.Name = "btnNoBinding";
            this.btnNoBinding.Size = new System.Drawing.Size(109, 23);
            this.btnNoBinding.TabIndex = 1;
            this.btnNoBinding.Text = "Not binded button";
            this.btnNoBinding.UseVisualStyleBackColor = true;
            // 
            // btnShowSimpleForm
            // 
            this.btnShowSimpleForm.Enabled = false;
            this.btnShowSimpleForm.Location = new System.Drawing.Point(0, 56);
            this.btnShowSimpleForm.Name = "btnShowSimpleForm";
            this.btnShowSimpleForm.Size = new System.Drawing.Size(109, 23);
            this.btnShowSimpleForm.TabIndex = 0;
            this.btnShowSimpleForm.Text = "Show simple form";
            this.btnShowSimpleForm.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSimpleFormToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ToolStripMenuItem.Text = "Commands";
            // 
            // showSimpleFormToolStripMenuItem
            // 
            this.showSimpleFormToolStripMenuItem.Name = "showSimpleFormToolStripMenuItem";
            this.showSimpleFormToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showSimpleFormToolStripMenuItem.Text = "Show simple form";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnNoBinding);
            this.Controls.Add(this.btnShowSimpleForm);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mvvm.Winform.FluentBindingToolkit.Controls.CommandButton btnShowSimpleForm;
        private Mvvm.Winform.FluentBindingToolkit.Controls.CommandButton btnNoBinding;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private CommandToolStripMenuItem showSimpleFormToolStripMenuItem;
    }
}