namespace IntersectionLine
{
    partial class TestIntersectionLine
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.sRedX = new System.Windows.Forms.NumericUpDown();
            this.eRedX = new System.Windows.Forms.NumericUpDown();
            this.sBlueX = new System.Windows.Forms.NumericUpDown();
            this.eBlueX = new System.Windows.Forms.NumericUpDown();
            this.eBlueY = new System.Windows.Forms.NumericUpDown();
            this.sBlueY = new System.Windows.Forms.NumericUpDown();
            this.eRedY = new System.Windows.Forms.NumericUpDown();
            this.sRedY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkIntersectionLine = new System.Windows.Forms.Button();
            this.checkMsgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBlueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBlueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBlueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBlueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRedY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(403, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(384, 441);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // sRedX
            // 
            this.sRedX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sRedX.Location = new System.Drawing.Point(193, 26);
            this.sRedX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sRedX.Name = "sRedX";
            this.sRedX.Size = new System.Drawing.Size(52, 20);
            this.sRedX.TabIndex = 1;
            this.sRedX.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // eRedX
            // 
            this.eRedX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.eRedX.Location = new System.Drawing.Point(193, 56);
            this.eRedX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.eRedX.Name = "eRedX";
            this.eRedX.Size = new System.Drawing.Size(52, 20);
            this.eRedX.TabIndex = 2;
            this.eRedX.Value = new decimal(new int[] {
            280,
            0,
            0,
            0});
            // 
            // sBlueX
            // 
            this.sBlueX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sBlueX.Location = new System.Drawing.Point(193, 91);
            this.sBlueX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sBlueX.Name = "sBlueX";
            this.sBlueX.Size = new System.Drawing.Size(52, 20);
            this.sBlueX.TabIndex = 3;
            this.sBlueX.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // eBlueX
            // 
            this.eBlueX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.eBlueX.Location = new System.Drawing.Point(193, 124);
            this.eBlueX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.eBlueX.Name = "eBlueX";
            this.eBlueX.Size = new System.Drawing.Size(52, 20);
            this.eBlueX.TabIndex = 4;
            this.eBlueX.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
            // 
            // eBlueY
            // 
            this.eBlueY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.eBlueY.Location = new System.Drawing.Point(262, 124);
            this.eBlueY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.eBlueY.Name = "eBlueY";
            this.eBlueY.Size = new System.Drawing.Size(52, 20);
            this.eBlueY.TabIndex = 8;
            this.eBlueY.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // sBlueY
            // 
            this.sBlueY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sBlueY.Location = new System.Drawing.Point(262, 91);
            this.sBlueY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sBlueY.Name = "sBlueY";
            this.sBlueY.Size = new System.Drawing.Size(52, 20);
            this.sBlueY.TabIndex = 7;
            this.sBlueY.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // eRedY
            // 
            this.eRedY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.eRedY.Location = new System.Drawing.Point(262, 56);
            this.eRedY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.eRedY.Name = "eRedY";
            this.eRedY.Size = new System.Drawing.Size(52, 20);
            this.eRedY.TabIndex = 6;
            this.eRedY.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // sRedY
            // 
            this.sRedY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sRedY.Location = new System.Drawing.Point(262, 26);
            this.sRedY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sRedY.Name = "sRedY";
            this.sRedY.Size = new System.Drawing.Size(52, 20);
            this.sRedY.TabIndex = 5;
            this.sRedY.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Начало красного отрезка  X;Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Конец красного отрезка  X;Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Начало синего отрезка  X;Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Конец синего отрезка  X;Y";
            // 
            // checkIntersectionLine
            // 
            this.checkIntersectionLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkIntersectionLine.ForeColor = System.Drawing.Color.Blue;
            this.checkIntersectionLine.Location = new System.Drawing.Point(29, 253);
            this.checkIntersectionLine.Name = "checkIntersectionLine";
            this.checkIntersectionLine.Size = new System.Drawing.Size(340, 34);
            this.checkIntersectionLine.TabIndex = 13;
            this.checkIntersectionLine.Text = "Проверить пересечение";
            this.checkIntersectionLine.UseVisualStyleBackColor = true;
            this.checkIntersectionLine.Click += new System.EventHandler(this.chekIntersectionLine_Click);
            // 
            // checkMsgLabel
            // 
            this.checkMsgLabel.AutoSize = true;
            this.checkMsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.checkMsgLabel.Location = new System.Drawing.Point(57, 193);
            this.checkMsgLabel.Name = "checkMsgLabel";
            this.checkMsgLabel.Size = new System.Drawing.Size(271, 25);
            this.checkMsgLabel.TabIndex = 14;
            this.checkMsgLabel.Text = "Отрезки пересекаются!";
            this.checkMsgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TestIntersectionLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.checkMsgLabel);
            this.Controls.Add(this.checkIntersectionLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eBlueY);
            this.Controls.Add(this.sBlueY);
            this.Controls.Add(this.eRedY);
            this.Controls.Add(this.sRedY);
            this.Controls.Add(this.eBlueX);
            this.Controls.Add(this.sBlueX);
            this.Controls.Add(this.eRedX);
            this.Controls.Add(this.sRedX);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestIntersectionLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка пересечения отрезков";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBlueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBlueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBlueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBlueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRedY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown sRedX;
        private System.Windows.Forms.NumericUpDown eRedX;
        private System.Windows.Forms.NumericUpDown sBlueX;
        private System.Windows.Forms.NumericUpDown eBlueX;
        private System.Windows.Forms.NumericUpDown eBlueY;
        private System.Windows.Forms.NumericUpDown sBlueY;
        private System.Windows.Forms.NumericUpDown eRedY;
        private System.Windows.Forms.NumericUpDown sRedY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkIntersectionLine;
        private System.Windows.Forms.Label checkMsgLabel;
    }
}

