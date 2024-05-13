namespace GameofLife
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
            this.Settings = new System.Windows.Forms.Panel();
            this.Screen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.S_speed = new System.Windows.Forms.HScrollBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Settings.Controls.Add(this.checkBox1);
            this.Settings.Controls.Add(this.S_speed);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(251, 450);
            this.Settings.TabIndex = 0;
            // 
            // Screen
            // 
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(251, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(549, 450);
            this.Screen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Скорость";
            // 
            // S_speed
            // 
            this.S_speed.Dock = System.Windows.Forms.DockStyle.Top;
            this.S_speed.Location = new System.Drawing.Point(0, 32);
            this.S_speed.Name = "S_speed";
            this.S_speed.Size = new System.Drawing.Size(251, 31);
            this.S_speed.TabIndex = 2;
            this.S_speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.S_speed_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox1.Location = new System.Drawing.Point(0, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(251, 53);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Пауза";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.Settings);
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.HScrollBar S_speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

