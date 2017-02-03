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
            this.btnShowSimpleForm = new Mvvm.Winform.FluentBindingToolkit.Controls.CommandButton();
            this.btnNoBinding = new Mvvm.Winform.FluentBindingToolkit.Controls.CommandButton();
            this.SuspendLayout();
            // 
            // btnShowSimpleForm
            // 
            this.btnShowSimpleForm.Location = new System.Drawing.Point(1, 41);
            this.btnShowSimpleForm.Name = "btnShowSimpleForm";
            this.btnShowSimpleForm.Size = new System.Drawing.Size(109, 23);
            this.btnShowSimpleForm.TabIndex = 0;
            this.btnShowSimpleForm.Text = "Show simple form";
            this.btnShowSimpleForm.UseVisualStyleBackColor = true;
            // 
            // btnNoBinding
            // 
            this.btnNoBinding.Location = new System.Drawing.Point(1, 12);
            this.btnNoBinding.Name = "btnNoBinding";
            this.btnNoBinding.Size = new System.Drawing.Size(109, 23);
            this.btnNoBinding.TabIndex = 1;
            this.btnNoBinding.Text = "Not binded button";
            this.btnNoBinding.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnNoBinding);
            this.Controls.Add(this.btnShowSimpleForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Mvvm.Winform.FluentBindingToolkit.Controls.CommandButton btnShowSimpleForm;
        private Mvvm.Winform.FluentBindingToolkit.Controls.CommandButton btnNoBinding;
    }
}