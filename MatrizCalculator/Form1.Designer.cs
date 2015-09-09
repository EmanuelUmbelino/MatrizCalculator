namespace MatrizCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.M1L = new System.Windows.Forms.NumericUpDown();
            this.M1C = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.M2C = new System.Windows.Forms.NumericUpDown();
            this.M2L = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.M3L = new System.Windows.Forms.TextBox();
            this.M3C = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.M1L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2L)).BeginInit();
            this.SuspendLayout();
            // 
            // M1L
            // 
            this.M1L.Location = new System.Drawing.Point(27, 66);
            this.M1L.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M1L.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M1L.Name = "M1L";
            this.M1L.Size = new System.Drawing.Size(41, 20);
            this.M1L.TabIndex = 0;
            this.M1L.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M1L.ValueChanged += new System.EventHandler(this.ChangeLengthA);
            // 
            // M1C
            // 
            this.M1C.Location = new System.Drawing.Point(84, 66);
            this.M1C.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M1C.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M1C.Name = "M1C";
            this.M1C.Size = new System.Drawing.Size(41, 20);
            this.M1C.TabIndex = 1;
            this.M1C.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M1C.ValueChanged += new System.EventHandler(this.ChangeLengthA);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Linhas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Colunas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "MATRIZ A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "MATRIZ B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Colunas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Linhas";
            // 
            // M2C
            // 
            this.M2C.Location = new System.Drawing.Point(547, 66);
            this.M2C.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M2C.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M2C.Name = "M2C";
            this.M2C.Size = new System.Drawing.Size(41, 20);
            this.M2C.TabIndex = 6;
            this.M2C.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M2C.ValueChanged += new System.EventHandler(this.ChangeLengthB);
            // 
            // M2L
            // 
            this.M2L.Location = new System.Drawing.Point(490, 66);
            this.M2L.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M2L.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M2L.Name = "M2L";
            this.M2L.Size = new System.Drawing.Size(41, 20);
            this.M2L.TabIndex = 5;
            this.M2L.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M2L.ValueChanged += new System.EventHandler(this.ChangeLengthB);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(961, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "MATRIZ C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(948, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Linhas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1007, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Colunas";
            // 
            // M3L
            // 
            this.M3L.Location = new System.Drawing.Point(942, 66);
            this.M3L.Name = "M3L";
            this.M3L.ReadOnly = true;
            this.M3L.Size = new System.Drawing.Size(44, 20);
            this.M3L.TabIndex = 20;
            // 
            // M3C
            // 
            this.M3C.Location = new System.Drawing.Point(1008, 66);
            this.M3C.Name = "M3C";
            this.M3C.ReadOnly = true;
            this.M3C.Size = new System.Drawing.Size(44, 20);
            this.M3C.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeOperation);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeOperation);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 33);
            this.button3.TabIndex = 24;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChangeOperation);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 539);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 33);
            this.button4.TabIndex = 25;
            this.button4.Text = "Deter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(765, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 33);
            this.button5.TabIndex = 26;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Solution);
            // 
            // Operation
            // 
            this.Operation.Location = new System.Drawing.Point(268, 65);
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Size = new System.Drawing.Size(20, 20);
            this.Operation.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Operation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 584);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.M3C);
            this.Controls.Add(this.M3L);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.M2C);
            this.Controls.Add(this.M2L);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.M1C);
            this.Controls.Add(this.M1L);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.M1L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown M1L;
        private System.Windows.Forms.NumericUpDown M1C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown M2C;
        private System.Windows.Forms.NumericUpDown M2L;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox M3L;
        private System.Windows.Forms.TextBox M3C;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.Label label10;
    }
}

