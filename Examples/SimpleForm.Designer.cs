namespace Examples
{
    partial class SimpleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.labelFormattedFirstName = new System.Windows.Forms.Label();
            this.numYearsOld = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumberInLetters = new System.Windows.Forms.Label();
            this.saveButton = new Mvvm.Winform.BindingToolkit.Controls.CommandButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGenderChoosen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYearsOld)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name :";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(73, 12);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(172, 20);
            this.txtbxFirstName.TabIndex = 1;
            // 
            // labelFormattedFirstName
            // 
            this.labelFormattedFirstName.AutoSize = true;
            this.labelFormattedFirstName.Location = new System.Drawing.Point(70, 62);
            this.labelFormattedFirstName.Name = "labelFormattedFirstName";
            this.labelFormattedFirstName.Size = new System.Drawing.Size(91, 13);
            this.labelFormattedFirstName.TabIndex = 3;
            this.labelFormattedFirstName.Text = "Your name is : {0}";
            // 
            // numYearsOld
            // 
            this.numYearsOld.Location = new System.Drawing.Point(73, 39);
            this.numYearsOld.Name = "numYearsOld";
            this.numYearsOld.Size = new System.Drawing.Size(120, 20);
            this.numYearsOld.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Years old :";
            // 
            // labelNumberInLetters
            // 
            this.labelNumberInLetters.AutoSize = true;
            this.labelNumberInLetters.Location = new System.Drawing.Point(199, 41);
            this.labelNumberInLetters.Name = "labelNumberInLetters";
            this.labelNumberInLetters.Size = new System.Drawing.Size(29, 13);
            this.labelNumberInLetters.TabIndex = 6;
            this.labelNumberInLetters.Text = "Zero";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(192, 238);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(73, 79);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 7;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(127, 79);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 8;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender :";
            // 
            // labelGenderChoosen
            // 
            this.labelGenderChoosen.AutoSize = true;
            this.labelGenderChoosen.Location = new System.Drawing.Point(70, 99);
            this.labelGenderChoosen.Name = "labelGenderChoosen";
            this.labelGenderChoosen.Size = new System.Drawing.Size(92, 13);
            this.labelGenderChoosen.TabIndex = 10;
            this.labelGenderChoosen.Text = "Gender choosen !";
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelGenderChoosen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.labelNumberInLetters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numYearsOld);
            this.Controls.Add(this.labelFormattedFirstName);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.label1);
            this.Name = "SimpleForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numYearsOld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private Mvvm.Winform.BindingToolkit.Controls.CommandButton saveButton;
        private System.Windows.Forms.Label labelFormattedFirstName;
        private System.Windows.Forms.NumericUpDown numYearsOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumberInLetters;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGenderChoosen;
    }
}

