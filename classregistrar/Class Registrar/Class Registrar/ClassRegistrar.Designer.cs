namespace Class_Registrar
{
    partial class ClassRegistrar
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassRegistrar));
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddDirInput = new System.Windows.Forms.TextBox();
            this.DeleteDirInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddFileDesc = new System.Windows.Forms.TextBox();
            this.CheckLabel1 = new System.Windows.Forms.Label();
            this.CheckLabel2 = new System.Windows.Forms.Label();
            this.CheckLabel3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.Color.Green;
            this.AddButton.Location = new System.Drawing.Point(535, 45);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(118, 46);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteButton.Location = new System.Drawing.Point(535, 103);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(118, 43);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddDirInput
            // 
            this.AddDirInput.Location = new System.Drawing.Point(110, 45);
            this.AddDirInput.Name = "AddDirInput";
            this.AddDirInput.Size = new System.Drawing.Size(419, 20);
            this.AddDirInput.TabIndex = 4;
            this.AddDirInput.Text = "HKEY_CLASSES_ROOT\\";
            this.AddDirInput.TextChanged += new System.EventHandler(this.AddDirInput_TextChanged);
            // 
            // DeleteDirInput
            // 
            this.DeleteDirInput.Location = new System.Drawing.Point(110, 103);
            this.DeleteDirInput.Name = "DeleteDirInput";
            this.DeleteDirInput.Size = new System.Drawing.Size(419, 20);
            this.DeleteDirInput.TabIndex = 6;
            this.DeleteDirInput.Text = "HKEY_CLASSES_ROOT\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registry (e.g. .ext)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Registry (e.g. .ext)";
            // 
            // AddFileDesc
            // 
            this.AddFileDesc.Location = new System.Drawing.Point(110, 69);
            this.AddFileDesc.Name = "AddFileDesc";
            this.AddFileDesc.Size = new System.Drawing.Size(419, 20);
            this.AddFileDesc.TabIndex = 11;
            this.AddFileDesc.Text = "File description";
            this.AddFileDesc.TextChanged += new System.EventHandler(this.AddFileDesc_TextChanged);
            // 
            // CheckLabel1
            // 
            this.CheckLabel1.AutoSize = true;
            this.CheckLabel1.Location = new System.Drawing.Point(158, 118);
            this.CheckLabel1.Name = "CheckLabel1";
            this.CheckLabel1.Size = new System.Drawing.Size(0, 13);
            this.CheckLabel1.TabIndex = 13;
            // 
            // CheckLabel2
            // 
            this.CheckLabel2.AutoSize = true;
            this.CheckLabel2.Location = new System.Drawing.Point(324, 118);
            this.CheckLabel2.Name = "CheckLabel2";
            this.CheckLabel2.Size = new System.Drawing.Size(0, 13);
            this.CheckLabel2.TabIndex = 14;
            // 
            // CheckLabel3
            // 
            this.CheckLabel3.AutoSize = true;
            this.CheckLabel3.Location = new System.Drawing.Point(440, 118);
            this.CheckLabel3.Name = "CheckLabel3";
            this.CheckLabel3.Size = new System.Drawing.Size(0, 13);
            this.CheckLabel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Registry should be HKEY_CLASSES_ROOT\\.ext, File description should be My Filedesc" +
    ",";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Icon dir. is optional and should be dir\\icon.ico";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(168, 133);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 18;
            // 
            // ClassRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(679, 160);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckLabel3);
            this.Controls.Add(this.CheckLabel2);
            this.Controls.Add(this.CheckLabel1);
            this.Controls.Add(this.AddFileDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteDirInput);
            this.Controls.Add(this.AddDirInput);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassRegistrar";
            this.Text = "Class Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox AddDirInput;
        private System.Windows.Forms.TextBox DeleteDirInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddFileDesc;
        private System.Windows.Forms.Label CheckLabel1;
        private System.Windows.Forms.Label CheckLabel2;
        private System.Windows.Forms.Label CheckLabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label output;
    }
}

