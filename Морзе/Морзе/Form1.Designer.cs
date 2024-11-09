
namespace Морзе
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ControlBox = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.maximize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.morze_translate = new System.Windows.Forms.Label();
            this.translate_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.writebox = new System.Windows.Forms.TextBox();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.Color.Black;
            this.ControlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlBox.Controls.Add(this.minimize_btn);
            this.ControlBox.Controls.Add(this.maximize_btn);
            this.ControlBox.Controls.Add(this.exit_btn);
            this.ControlBox.Controls.Add(this.pictureBox1);
            this.ControlBox.Controls.Add(this.label1);
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBox.Location = new System.Drawing.Point(0, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(800, 25);
            this.ControlBox.TabIndex = 10;
            this.ControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseDown);
            this.ControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseMove);
            this.ControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Black;
            this.minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(738, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(20, 23);
            this.minimize_btn.TabIndex = 13;
            this.minimize_btn.Text = "-";
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            this.minimize_btn.MouseEnter += new System.EventHandler(this.minimize_btn_MouseEnter);
            this.minimize_btn.MouseLeave += new System.EventHandler(this.minimize_btn_MouseLeave);
            // 
            // maximize_btn
            // 
            this.maximize_btn.BackColor = System.Drawing.Color.Black;
            this.maximize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximize_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_btn.ForeColor = System.Drawing.Color.White;
            this.maximize_btn.Location = new System.Drawing.Point(758, 0);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(20, 23);
            this.maximize_btn.TabIndex = 12;
            this.maximize_btn.Text = "O";
            this.maximize_btn.UseVisualStyleBackColor = false;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            this.maximize_btn.MouseEnter += new System.EventHandler(this.maximize_btn_MouseEnter);
            this.maximize_btn.MouseLeave += new System.EventHandler(this.maximize_btn_MouseLeave);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Black;
            this.exit_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(778, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(20, 23);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseEnter += new System.EventHandler(this.exit_btn_MouseEnter);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Морзе.Properties.Resources._260403__1_;
            this.pictureBox1.Location = new System.Drawing.Point(163, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Morze translater";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 46);
            this.label2.TabIndex = 11;
            this.label2.Text = "Write text:";
            // 
            // morze_translate
            // 
            this.morze_translate.AutoSize = true;
            this.morze_translate.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.morze_translate.ForeColor = System.Drawing.Color.White;
            this.morze_translate.Location = new System.Drawing.Point(36, 265);
            this.morze_translate.Name = "morze_translate";
            this.morze_translate.Size = new System.Drawing.Size(132, 28);
            this.morze_translate.TabIndex = 11;
            this.morze_translate.Text = "                    ";
            // 
            // translate_btn
            // 
            this.translate_btn.BackColor = System.Drawing.Color.Black;
            this.translate_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.translate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translate_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translate_btn.ForeColor = System.Drawing.Color.White;
            this.translate_btn.Location = new System.Drawing.Point(393, 77);
            this.translate_btn.Name = "translate_btn";
            this.translate_btn.Size = new System.Drawing.Size(301, 171);
            this.translate_btn.TabIndex = 14;
            this.translate_btn.Text = "Translate";
            this.translate_btn.UseVisualStyleBackColor = false;
            this.translate_btn.Click += new System.EventHandler(this.translate_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Morze translate:";
            // 
            // writebox
            // 
            this.writebox.BackColor = System.Drawing.Color.Black;
            this.writebox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writebox.ForeColor = System.Drawing.Color.White;
            this.writebox.Location = new System.Drawing.Point(32, 131);
            this.writebox.Name = "writebox";
            this.writebox.Size = new System.Drawing.Size(172, 34);
            this.writebox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.writebox);
            this.Controls.Add(this.translate_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.morze_translate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Morze translater";
            this.ControlBox.ResumeLayout(false);
            this.ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button maximize_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label morze_translate;
        private System.Windows.Forms.Button translate_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox writebox;
    }
}

