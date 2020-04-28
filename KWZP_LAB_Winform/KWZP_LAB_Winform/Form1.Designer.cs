namespace KWZP_LAB_Winform
{
    partial class lbl1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Enabled = false;
            this.btn1.Location = new System.Drawing.Point(122, 150);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(172, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "CHANGE ME";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(155, 113);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(97, 17);
            this.chk1.TabIndex = 1;
            this.chk1.Text = "wl/wyl przycisk";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(118, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Laboratorium KWZP 2020";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(122, 70);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(172, 20);
            this.txt1.TabIndex = 3;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // lbl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 217);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.btn1);
            this.Name = "lbl1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
    }
}

