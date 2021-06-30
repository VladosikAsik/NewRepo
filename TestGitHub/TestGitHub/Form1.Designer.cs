using System.Drawing;
using System.Windows.Forms;

namespace TestGitHub
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();



            ///                 label
            this.label = new Label();
            this.label.BackColor = Color.White;
            this.label.Size = new System.Drawing.Size(75, 35);
            this.label.Location = new System.Drawing.Point(this.Width / 2 - (this.label.Width / 2), this.Height / 2 - (this.label.Height / 2));
            this.label.Font = new System.Drawing.Font("Times New Roman", 20);
            ///                 label               END



            ///                 panel
            this.panel = new Panel();
            this.panel.BorderStyle = BorderStyle.FixedSingle;
            this.panel.BackColor = Color.White;
            this.panel.Size = new System.Drawing.Size(400, 200);
            this.panel.Location = new System.Drawing.Point(this.Width / 2 - (this.panel.Width / 2), this.Height / 2 - (this.panel.Height / 2));
            ///                 panel               END


            this.Controls.Add(label);
            this.Controls.Add(panel);
        }

        #endregion
        private Label label;
        private Panel panel;
    }
}

