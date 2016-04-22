namespace lab1
{
    partial class GraphProg
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1CoordX = new System.Windows.Forms.Label();
            this.FirstCoordX = new System.Windows.Forms.TextBox();
            this.SecondCoordX = new System.Windows.Forms.TextBox();
            this.FirstCoordY = new System.Windows.Forms.TextBox();
            this.SecondCoordY = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listShapes = new System.Windows.Forms.ListBox();
            this.label1CoordY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 554);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1CoordY);
            this.groupBox2.Controls.Add(this.label1CoordX);
            this.groupBox2.Controls.Add(this.FirstCoordX);
            this.groupBox2.Controls.Add(this.SecondCoordX);
            this.groupBox2.Controls.Add(this.FirstCoordY);
            this.groupBox2.Controls.Add(this.SecondCoordY);
            this.groupBox2.Controls.Add(this.buttonDraw);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(514, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 289);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "0";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1CoordX
            // 
            this.label1CoordX.AutoSize = true;
            this.label1CoordX.Location = new System.Drawing.Point(61, 17);
            this.label1CoordX.Name = "label1CoordX";
            this.label1CoordX.Size = new System.Drawing.Size(16, 32);
            this.label1CoordX.TabIndex = 9;
            this.label1CoordX.Text = "X\r\n\r";
            this.label1CoordX.Click += new System.EventHandler(this.label1Coord_Click);
            // 
            // FirstCoordX
            // 
            this.FirstCoordX.Location = new System.Drawing.Point(43, 52);
            this.FirstCoordX.Name = "FirstCoordX";
            this.FirstCoordX.Size = new System.Drawing.Size(64, 22);
            this.FirstCoordX.TabIndex = 2;
            // 
            // SecondCoordX
            // 
            this.SecondCoordX.Location = new System.Drawing.Point(43, 91);
            this.SecondCoordX.Name = "SecondCoordX";
            this.SecondCoordX.Size = new System.Drawing.Size(64, 22);
            this.SecondCoordX.TabIndex = 4;
            // 
            // FirstCoordY
            // 
            this.FirstCoordY.Location = new System.Drawing.Point(117, 52);
            this.FirstCoordY.Name = "FirstCoordY";
            this.FirstCoordY.Size = new System.Drawing.Size(64, 22);
            this.FirstCoordY.TabIndex = 3;
            // 
            // SecondCoordY
            // 
            this.SecondCoordY.Location = new System.Drawing.Point(117, 91);
            this.SecondCoordY.Name = "SecondCoordY";
            this.SecondCoordY.Size = new System.Drawing.Size(64, 22);
            this.SecondCoordY.TabIndex = 5;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(24, 227);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(154, 36);
            this.buttonDraw.TabIndex = 6;
            this.buttonDraw.Text = "Нарисовать фигуру";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listShapes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(514, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 250);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список фигур ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите фигуру для \r\nрисования:";
            // 
            // listShapes
            // 
            this.listShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listShapes.FormattingEnabled = true;
            this.listShapes.ItemHeight = 16;
            this.listShapes.Location = new System.Drawing.Point(20, 72);
            this.listShapes.Name = "listShapes";
            this.listShapes.Size = new System.Drawing.Size(161, 164);
            this.listShapes.TabIndex = 0;
            this.listShapes.SelectedIndexChanged += new System.EventHandler(this.listShapes_SelectedIndexChanged);
            // 
            // label1CoordY
            // 
            this.label1CoordY.AutoSize = true;
            this.label1CoordY.Location = new System.Drawing.Point(140, 17);
            this.label1CoordY.Name = "label1CoordY";
            this.label1CoordY.Size = new System.Drawing.Size(17, 16);
            this.label1CoordY.TabIndex = 12;
            this.label1CoordY.Text = "Y";
            // 
            // GraphProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Name = "GraphProg";
            this.Text = "Графика";
            this.Load += new System.EventHandler(this.GraphProg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1CoordX;
        private System.Windows.Forms.TextBox FirstCoordX;
        private System.Windows.Forms.TextBox SecondCoordX;
        private System.Windows.Forms.TextBox FirstCoordY;
        private System.Windows.Forms.TextBox SecondCoordY;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listShapes;
        private System.Windows.Forms.Label label1CoordY;
    }
}

