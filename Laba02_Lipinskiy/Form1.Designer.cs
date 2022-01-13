
namespace Laba02_Lipinskiy
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
            this.button_clean = new System.Windows.Forms.Button();
            this.button_XOR = new System.Windows.Forms.Button();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_C_2 = new System.Windows.Forms.Label();
            this.label_Key_2 = new System.Windows.Forms.Label();
            this.label_P_2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_C_10 = new System.Windows.Forms.Label();
            this.label_Key_10 = new System.Windows.Forms.Label();
            this.label_P_10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_C_16 = new System.Windows.Forms.Label();
            this.label_Key_16 = new System.Windows.Forms.Label();
            this.label_P_16 = new System.Windows.Forms.Label();
            this.textBox_C2 = new System.Windows.Forms.TextBox();
            this.textBox_Key2 = new System.Windows.Forms.TextBox();
            this.textBox_P2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.button_clean.Location = new System.Drawing.Point(125, 166);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(119, 40);
            this.button_clean.TabIndex = 7;
            this.button_clean.Text = "Прибрати";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_XOR
            // 
            this.button_XOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.button_XOR.Location = new System.Drawing.Point(607, 67);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(79, 42);
            this.button_XOR.TabIndex = 6;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // textBox_C
            // 
            this.textBox_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox_C.Location = new System.Drawing.Point(125, 123);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.ReadOnly = true;
            this.textBox_C.Size = new System.Drawing.Size(119, 28);
            this.textBox_C.TabIndex = 5;
            this.textBox_C.TabStop = false;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox_Key.Location = new System.Drawing.Point(125, 83);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(119, 28);
            this.textBox_Key.TabIndex = 4;
            // 
            // textBox_P
            // 
            this.textBox_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox_P.Location = new System.Drawing.Point(125, 45);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(119, 28);
            this.textBox_P.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(47, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "C =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "P =";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_C_2);
            this.groupBox1.Controls.Add(this.label_Key_2);
            this.groupBox1.Controls.Add(this.label_P_2);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 149);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "У 2-му форматі";
            // 
            // label_C_2
            // 
            this.label_C_2.AutoSize = true;
            this.label_C_2.Location = new System.Drawing.Point(7, 118);
            this.label_C_2.Name = "label_C_2";
            this.label_C_2.Size = new System.Drawing.Size(20, 17);
            this.label_C_2.TabIndex = 2;
            this.label_C_2.Text = "   ";
            // 
            // label_Key_2
            // 
            this.label_Key_2.AutoSize = true;
            this.label_Key_2.Location = new System.Drawing.Point(7, 78);
            this.label_Key_2.Name = "label_Key_2";
            this.label_Key_2.Size = new System.Drawing.Size(16, 17);
            this.label_Key_2.TabIndex = 1;
            this.label_Key_2.Text = "  ";
            // 
            // label_P_2
            // 
            this.label_P_2.AutoSize = true;
            this.label_P_2.Location = new System.Drawing.Point(7, 43);
            this.label_P_2.Name = "label_P_2";
            this.label_P_2.Size = new System.Drawing.Size(20, 17);
            this.label_P_2.TabIndex = 0;
            this.label_P_2.Text = "   ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_C_10);
            this.groupBox2.Controls.Add(this.label_Key_10);
            this.groupBox2.Controls.Add(this.label_P_10);
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 149);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "У 10-му форматі";
            // 
            // label_C_10
            // 
            this.label_C_10.AutoSize = true;
            this.label_C_10.Location = new System.Drawing.Point(7, 118);
            this.label_C_10.Name = "label_C_10";
            this.label_C_10.Size = new System.Drawing.Size(20, 17);
            this.label_C_10.TabIndex = 2;
            this.label_C_10.Text = "   ";
            // 
            // label_Key_10
            // 
            this.label_Key_10.AutoSize = true;
            this.label_Key_10.Location = new System.Drawing.Point(7, 78);
            this.label_Key_10.Name = "label_Key_10";
            this.label_Key_10.Size = new System.Drawing.Size(20, 17);
            this.label_Key_10.TabIndex = 1;
            this.label_Key_10.Text = "   ";
            // 
            // label_P_10
            // 
            this.label_P_10.AutoSize = true;
            this.label_P_10.Location = new System.Drawing.Point(7, 41);
            this.label_P_10.Name = "label_P_10";
            this.label_P_10.Size = new System.Drawing.Size(20, 17);
            this.label_P_10.TabIndex = 0;
            this.label_P_10.Text = "   ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_C_16);
            this.groupBox3.Controls.Add(this.label_Key_16);
            this.groupBox3.Controls.Add(this.label_P_16);
            this.groupBox3.Location = new System.Drawing.Point(486, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 149);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "У 16-му форматі";
            // 
            // label_C_16
            // 
            this.label_C_16.AutoSize = true;
            this.label_C_16.Location = new System.Drawing.Point(7, 118);
            this.label_C_16.Name = "label_C_16";
            this.label_C_16.Size = new System.Drawing.Size(20, 17);
            this.label_C_16.TabIndex = 2;
            this.label_C_16.Text = "   ";
            // 
            // label_Key_16
            // 
            this.label_Key_16.AutoSize = true;
            this.label_Key_16.Location = new System.Drawing.Point(7, 78);
            this.label_Key_16.Name = "label_Key_16";
            this.label_Key_16.Size = new System.Drawing.Size(20, 17);
            this.label_Key_16.TabIndex = 1;
            this.label_Key_16.Text = "   ";
            // 
            // label_P_16
            // 
            this.label_P_16.AutoSize = true;
            this.label_P_16.Location = new System.Drawing.Point(7, 41);
            this.label_P_16.Name = "label_P_16";
            this.label_P_16.Size = new System.Drawing.Size(20, 17);
            this.label_P_16.TabIndex = 0;
            this.label_P_16.Text = "   ";
            // 
            // textBox_C2
            // 
            this.textBox_C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox_C2.Location = new System.Drawing.Point(706, 42);
            this.textBox_C2.Name = "textBox_C2";
            this.textBox_C2.ReadOnly = true;
            this.textBox_C2.Size = new System.Drawing.Size(119, 28);
            this.textBox_C2.TabIndex = 11;
            this.textBox_C2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Key2
            // 
            this.textBox_Key2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox_Key2.Location = new System.Drawing.Point(706, 83);
            this.textBox_Key2.Name = "textBox_Key2";
            this.textBox_Key2.ReadOnly = true;
            this.textBox_Key2.Size = new System.Drawing.Size(119, 28);
            this.textBox_Key2.TabIndex = 12;
            this.textBox_Key2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_P2
            // 
            this.textBox_P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox_P2.Location = new System.Drawing.Point(706, 125);
            this.textBox_P2.Name = "textBox_P2";
            this.textBox_P2.ReadOnly = true;
            this.textBox_P2.Size = new System.Drawing.Size(119, 28);
            this.textBox_P2.TabIndex = 13;
            this.textBox_P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(859, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "= C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(859, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "= Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(859, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "= P";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 228);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_P2);
            this.Controls.Add(this.textBox_Key2);
            this.Controls.Add(this.textBox_C2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_XOR);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XOR шифратор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_C_2;
        private System.Windows.Forms.Label label_Key_2;
        private System.Windows.Forms.Label label_P_2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_C_10;
        private System.Windows.Forms.Label label_Key_10;
        private System.Windows.Forms.Label label_P_10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_C_16;
        private System.Windows.Forms.Label label_Key_16;
        private System.Windows.Forms.Label label_P_16;
        private System.Windows.Forms.TextBox textBox_C2;
        private System.Windows.Forms.TextBox textBox_Key2;
        private System.Windows.Forms.TextBox textBox_P2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

