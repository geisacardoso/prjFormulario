
namespace prjFormulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPersonalizarCor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPersonalizarFonte = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnPersonalizarCor
            // 
            this.btnPersonalizarCor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonalizarCor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonalizarCor.Location = new System.Drawing.Point(12, 106);
            this.btnPersonalizarCor.Name = "btnPersonalizarCor";
            this.btnPersonalizarCor.Size = new System.Drawing.Size(345, 30);
            this.btnPersonalizarCor.TabIndex = 0;
            this.btnPersonalizarCor.Text = "Cor";
            this.btnPersonalizarCor.UseVisualStyleBackColor = false;
            this.btnPersonalizarCor.Click += new System.EventHandler(this.btnPersonalizarCor_Click);
            // 
            // btnPersonalizarFonte
            // 
            this.btnPersonalizarFonte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonalizarFonte.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonalizarFonte.Location = new System.Drawing.Point(12, 161);
            this.btnPersonalizarFonte.Name = "btnPersonalizarFonte";
            this.btnPersonalizarFonte.Size = new System.Drawing.Size(345, 29);
            this.btnPersonalizarFonte.TabIndex = 1;
            this.btnPersonalizarFonte.Text = "Fonte";
            this.btnPersonalizarFonte.UseVisualStyleBackColor = false;
            this.btnPersonalizarFonte.Click += new System.EventHandler(this.btnPersonalizarFonte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnPersonalizarFonte);
            this.Controls.Add(this.btnPersonalizarCor);
            this.Name = "Form1";
            this.Text = "Exercício Personalizar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonalizarCor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnPersonalizarFonte;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

