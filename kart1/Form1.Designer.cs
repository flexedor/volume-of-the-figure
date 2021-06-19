namespace kart1
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
            this.Title = new System.Windows.Forms.Label();
            this.stronaA = new System.Windows.Forms.TextBox();
            this.wys = new System.Windows.Forms.TextBox();
            this.stronaB = new System.Windows.Forms.TextBox();
            this.znalezć = new System.Windows.Forms.Button();
            this.StronaC = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(529, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(207, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "bryla - objętość";
            // 
            // stronaA
            // 
            this.stronaA.Location = new System.Drawing.Point(72, 63);
            this.stronaA.Name = "stronaA";
            this.stronaA.Size = new System.Drawing.Size(189, 22);
            this.stronaA.TabIndex = 1;
            this.stronaA.Text = "strona A";
            this.stronaA.TextChanged += new System.EventHandler(this.stronaA_TextChanged);
            // 
            // wys
            // 
            this.wys.Location = new System.Drawing.Point(72, 222);
            this.wys.Name = "wys";
            this.wys.Size = new System.Drawing.Size(189, 22);
            this.wys.TabIndex = 2;
            this.wys.Text = "Wysokość";
            this.wys.TextChanged += new System.EventHandler(this.wys_TextChanged);
            // 
            // stronaB
            // 
            this.stronaB.Location = new System.Drawing.Point(72, 119);
            this.stronaB.Name = "stronaB";
            this.stronaB.Size = new System.Drawing.Size(189, 22);
            this.stronaB.TabIndex = 3;
            this.stronaB.Text = "strona B";
            this.stronaB.TextChanged += new System.EventHandler(this.stronaB_TextChanged);
            // 
            // znalezć
            // 
            this.znalezć.Location = new System.Drawing.Point(186, 280);
            this.znalezć.Name = "znalezć";
            this.znalezć.Size = new System.Drawing.Size(75, 23);
            this.znalezć.TabIndex = 4;
            this.znalezć.Text = "count";
            this.znalezć.UseVisualStyleBackColor = true;
            this.znalezć.Click += new System.EventHandler(this.znalezć_Click);
            // 
            // StronaC
            // 
            this.StronaC.Location = new System.Drawing.Point(72, 172);
            this.StronaC.Name = "StronaC";
            this.StronaC.Size = new System.Drawing.Size(189, 22);
            this.StronaC.TabIndex = 6;
            this.StronaC.Text = "strona C";
            this.StronaC.TextChanged += new System.EventHandler(this.StronaC_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "odpow";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StronaC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.znalezć);
            this.Controls.Add(this.stronaB);
            this.Controls.Add(this.wys);
            this.Controls.Add(this.stronaA);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox stronaA;
        private System.Windows.Forms.TextBox wys;
        private System.Windows.Forms.TextBox stronaB;
        private System.Windows.Forms.Button znalezć;
        private System.Windows.Forms.TextBox StronaC;
        private System.Windows.Forms.TextBox textBox2;
    }
}

