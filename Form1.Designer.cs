
namespace rock_paper_scissors
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
            this.label1 = new System.Windows.Forms.Label();
            this.comBox_List = new System.Windows.Forms.ComboBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.listBox_Rezal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ваш выбор";
            // 
            // comBox_List
            // 
            this.comBox_List.FormattingEnabled = true;
            this.comBox_List.Location = new System.Drawing.Point(97, 13);
            this.comBox_List.Name = "comBox_List";
            this.comBox_List.Size = new System.Drawing.Size(156, 24);
            this.comBox_List.TabIndex = 1;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(15, 53);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(238, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Камень Ножницы Бумага";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // listBox_Rezal
            // 
            this.listBox_Rezal.Enabled = false;
            this.listBox_Rezal.FormattingEnabled = true;
            this.listBox_Rezal.ItemHeight = 16;
            this.listBox_Rezal.Location = new System.Drawing.Point(15, 93);
            this.listBox_Rezal.Name = "listBox_Rezal";
            this.listBox_Rezal.Size = new System.Drawing.Size(238, 52);
            this.listBox_Rezal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.listBox_Rezal);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.comBox_List);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBox_List;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ListBox listBox_Rezal;
    }
}

