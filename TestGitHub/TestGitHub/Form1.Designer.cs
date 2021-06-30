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
            this.BackColor = Color.Purple;
            this.ResumeLayout(false);
            this.PerformLayout();



            ///                 panel
            this.panel = new Panel();
            this.panel.BackColor = Color.Blue;
            this.panel.BorderStyle = BorderStyle.FixedSingle;
            this.panel.BackColor = Color.White;
            this.panel.Size = new System.Drawing.Size(400, 200);
            this.panel.Location = new System.Drawing.Point(this.Width / 2 - (this.panel.Width / 2), this.Height / 2 - (this.panel.Height / 2));
            ///                 panel               END



            ///                 label
            this.label = new Label();
            this.label.ForeColor = Color.Red;
            this.label.BackColor = Color.Black;
            this.label.Size = new System.Drawing.Size(75, 35);
            this.label.Location = new System.Drawing.Point(this.panel.Width / 2 - (this.label.Width / 2), this.panel.Height / 2 - (this.label.Height / 2));
            this.label.Font = new System.Drawing.Font("Times New Roman", 20);
            this.panel.Controls.Add(label);
            ///                 label               END



            ///                 button
            this.button = new Button();
            this.button.BackColor = Color.Blue;
            this.button.ForeColor = Color.Red;
            this.button.Text = "Settings";
            this.button.Size = new Size(60, 60);
            this.button.Location = new Point(this.Width - 60, 0);
            this.button.Click += Button_Click;
            ///                 button              END


            this.Controls.Add(panel);
            this.Controls.Add(button);
        }


        private void Button_Click(object sender, System.EventArgs e)
        {
            settings.ShowDialog();
        }

        #endregion
        private Label label;
        private Panel panel;
        private Button button;
        Settings settings = new Settings();
    }
}

