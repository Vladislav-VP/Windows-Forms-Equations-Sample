namespace EquationsSample
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudDelta = new System.Windows.Forms.NumericUpDown();
            this.lbDelta = new System.Windows.Forms.Label();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.listBResult = new System.Windows.Forms.ListBox();
            this.chGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btEvaluate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbAccuracy = new System.Windows.Forms.Label();
            this.nudAccuracy = new System.Windows.Forms.NumericUpDown();
            this.btWriteToTable = new System.Windows.Forms.Button();
            this.btPlot = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(15, 109);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(20, 20);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(15, 141);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(20, 20);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "B";
            // 
            // nudA
            // 
            this.nudA.DecimalPlaces = 1;
            this.nudA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudA.Location = new System.Drawing.Point(132, 107);
            this.nudA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(69, 26);
            this.nudA.TabIndex = 2;
            // 
            // nudB
            // 
            this.nudB.DecimalPlaces = 1;
            this.nudB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudB.Location = new System.Drawing.Point(132, 139);
            this.nudB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(69, 26);
            this.nudB.TabIndex = 3;
            // 
            // nudDelta
            // 
            this.nudDelta.DecimalPlaces = 1;
            this.nudDelta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDelta.Location = new System.Drawing.Point(132, 171);
            this.nudDelta.Name = "nudDelta";
            this.nudDelta.Size = new System.Drawing.Size(69, 26);
            this.nudDelta.TabIndex = 4;
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.Location = new System.Drawing.Point(15, 173);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(62, 20);
            this.lbDelta.TabIndex = 5;
            this.lbDelta.Text = "Delta X";
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(63, 32);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(46, 20);
            this.lbInput.TabIndex = 6;
            this.lbInput.Text = "Input";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(466, 32);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(58, 20);
            this.lbOutput.TabIndex = 7;
            this.lbOutput.Text = "Output";
            // 
            // listBResult
            // 
            this.listBResult.FormattingEnabled = true;
            this.listBResult.ItemHeight = 20;
            this.listBResult.Location = new System.Drawing.Point(291, 107);
            this.listBResult.Name = "listBResult";
            this.listBResult.Size = new System.Drawing.Size(202, 204);
            this.listBResult.TabIndex = 8;
            // 
            // chGraphic
            // 
            chartArea4.Name = "ChartArea1";
            this.chGraphic.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chGraphic.Legends.Add(legend4);
            this.chGraphic.Location = new System.Drawing.Point(499, 107);
            this.chGraphic.Name = "chGraphic";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chGraphic.Series.Add(series4);
            this.chGraphic.Size = new System.Drawing.Size(293, 204);
            this.chGraphic.TabIndex = 9;
            this.chGraphic.Text = "chart1";
            // 
            // btEvaluate
            // 
            this.btEvaluate.Location = new System.Drawing.Point(594, 317);
            this.btEvaluate.Name = "btEvaluate";
            this.btEvaluate.Size = new System.Drawing.Size(198, 36);
            this.btEvaluate.TabIndex = 10;
            this.btEvaluate.Text = "Solve";
            this.btEvaluate.UseVisualStyleBackColor = true;
            this.btEvaluate.Click += new System.EventHandler(this.btEvaluate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 102);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(23, 22);
            this.btSave.Text = "&Сохранить";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(466, 66);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 20);
            this.lbResult.TabIndex = 13;
            this.lbResult.Text = "X = ";
            // 
            // lbAccuracy
            // 
            this.lbAccuracy.AutoSize = true;
            this.lbAccuracy.Location = new System.Drawing.Point(15, 205);
            this.lbAccuracy.Name = "lbAccuracy";
            this.lbAccuracy.Size = new System.Drawing.Size(74, 20);
            this.lbAccuracy.TabIndex = 14;
            this.lbAccuracy.Text = "Accuracy";
            // 
            // nudAccuracy
            // 
            this.nudAccuracy.DecimalPlaces = 3;
            this.nudAccuracy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudAccuracy.Location = new System.Drawing.Point(132, 203);
            this.nudAccuracy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudAccuracy.Name = "nudAccuracy";
            this.nudAccuracy.Size = new System.Drawing.Size(69, 26);
            this.nudAccuracy.TabIndex = 15;
            this.nudAccuracy.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // btWriteToTable
            // 
            this.btWriteToTable.Location = new System.Drawing.Point(594, 359);
            this.btWriteToTable.Name = "btWriteToTable";
            this.btWriteToTable.Size = new System.Drawing.Size(197, 36);
            this.btWriteToTable.TabIndex = 16;
            this.btWriteToTable.Text = "Write to table";
            this.btWriteToTable.UseVisualStyleBackColor = true;
            this.btWriteToTable.Click += new System.EventHandler(this.btWriteToTable_Click);
            // 
            // btPlot
            // 
            this.btPlot.Location = new System.Drawing.Point(594, 401);
            this.btPlot.Name = "btPlot";
            this.btPlot.Size = new System.Drawing.Size(197, 36);
            this.btPlot.TabIndex = 17;
            this.btPlot.Text = "Plot";
            this.btPlot.UseVisualStyleBackColor = true;
            this.btPlot.Click += new System.EventHandler(this.btPlot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 455);
            this.Controls.Add(this.btPlot);
            this.Controls.Add(this.btWriteToTable);
            this.Controls.Add(this.nudAccuracy);
            this.Controls.Add(this.lbAccuracy);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEvaluate);
            this.Controls.Add(this.chGraphic);
            this.Controls.Add(this.listBResult);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.lbDelta);
            this.Controls.Add(this.nudDelta);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(820, 470);
            this.Name = "Form1";
            this.Text = "Lab 1";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudDelta;
        private System.Windows.Forms.Label lbDelta;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.ListBox listBResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGraphic;
        private System.Windows.Forms.Button btEvaluate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbAccuracy;
        private System.Windows.Forms.NumericUpDown nudAccuracy;
        private System.Windows.Forms.Button btWriteToTable;
        private System.Windows.Forms.Button btPlot;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

