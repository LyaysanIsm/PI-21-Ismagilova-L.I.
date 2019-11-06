namespace WindowsFormsAirplane
{
    partial class FormAirplaneConfig
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
            this.pictureBoxAirplane = new System.Windows.Forms.PictureBox();
            this.groupBoxAirplane = new System.Windows.Forms.GroupBox();
            this.labelFighter = new System.Windows.Forms.Label();
            this.labelAirplane = new System.Windows.Forms.Label();
            this.panelAirplane = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirplane)).BeginInit();
            this.groupBoxAirplane.SuspendLayout();
            this.panelAirplane.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAirplane
            // 
            this.pictureBoxAirplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAirplane.Location = new System.Drawing.Point(29, 31);
            this.pictureBoxAirplane.Name = "pictureBoxAirplane";
            this.pictureBoxAirplane.Size = new System.Drawing.Size(110, 79);
            this.pictureBoxAirplane.TabIndex = 0;
            this.pictureBoxAirplane.TabStop = false;
            // 
            // groupBoxAirplane
            // 
            this.groupBoxAirplane.Controls.Add(this.labelFighter);
            this.groupBoxAirplane.Controls.Add(this.labelAirplane);
            this.groupBoxAirplane.Location = new System.Drawing.Point(12, 30);
            this.groupBoxAirplane.Name = "groupBoxAirplane";
            this.groupBoxAirplane.Size = new System.Drawing.Size(133, 121);
            this.groupBoxAirplane.TabIndex = 1;
            this.groupBoxAirplane.TabStop = false;
            this.groupBoxAirplane.Text = "Тип самолета";
            // 
            // labelFighter
            // 
            this.labelFighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFighter.Location = new System.Drawing.Point(29, 68);
            this.labelFighter.Name = "labelFighter";
            this.labelFighter.Size = new System.Drawing.Size(76, 25);
            this.labelFighter.TabIndex = 1;
            this.labelFighter.Text = "Истребитель";
            this.labelFighter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFighter_MouseDown);
            // 
            // labelAirplane
            // 
            this.labelAirplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirplane.Location = new System.Drawing.Point(29, 24);
            this.labelAirplane.Name = "labelAirplane";
            this.labelAirplane.Size = new System.Drawing.Size(76, 25);
            this.labelAirplane.TabIndex = 0;
            this.labelAirplane.Text = "Самолет";
            this.labelAirplane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAirplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirplane_MouseDown);
            // 
            // panelAirplane
            // 
            this.panelAirplane.AllowDrop = true;
            this.panelAirplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAirplane.Controls.Add(this.labelDopColor);
            this.panelAirplane.Controls.Add(this.labelBaseColor);
            this.panelAirplane.Controls.Add(this.pictureBoxAirplane);
            this.panelAirplane.Location = new System.Drawing.Point(166, 12);
            this.panelAirplane.Name = "panelAirplane";
            this.panelAirplane.Size = new System.Drawing.Size(164, 250);
            this.panelAirplane.TabIndex = 2;
            this.panelAirplane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAirplane_DragDrop);
            this.panelAirplane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAirplane_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(29, 173);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(111, 30);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseColor.Location = new System.Drawing.Point(28, 123);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(111, 33);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(60, 131);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(31, 27);
            this.panelOrange.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(60, 98);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(31, 27);
            this.panelYellow.TabIndex = 5;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(9, 131);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(31, 27);
            this.panelGray.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(9, 98);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(31, 27);
            this.panelRed.TabIndex = 4;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(60, 65);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(31, 27);
            this.panelBlue.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(9, 65);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(31, 27);
            this.panelGreen.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(60, 31);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(31, 27);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(9, 31);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(31, 27);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 168);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(78, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(67, 207);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(347, 44);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(104, 172);
            this.groupBoxColor.TabIndex = 6;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // FormAirplaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 268);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelAirplane);
            this.Controls.Add(this.groupBoxAirplane);
            this.Name = "FormAirplaneConfig";
            this.Text = "Выбор самолета";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirplane)).EndInit();
            this.groupBoxAirplane.ResumeLayout(false);
            this.panelAirplane.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirplane;
        private System.Windows.Forms.GroupBox groupBoxAirplane;
        private System.Windows.Forms.Label labelFighter;
        private System.Windows.Forms.Label labelAirplane;
        private System.Windows.Forms.Panel panelAirplane;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxColor;
    }
}