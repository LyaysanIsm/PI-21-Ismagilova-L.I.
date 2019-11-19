using System;

namespace WindowsFormsAirplane
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakePlane = new System.Windows.Forms.PictureBox();
            this.buttonTakeAirplane = new System.Windows.Forms.Button();
            this.headingplace = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.heading = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.levels = new System.Windows.Forms.Label();
            this.buttonSetAirplane = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 25);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(689, 424);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxTakePlane);
            this.groupBox.Controls.Add(this.buttonTakeAirplane);
            this.groupBox.Controls.Add(this.headingplace);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.heading);
            this.groupBox.Location = new System.Drawing.Point(696, 238);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(95, 200);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // pictureBoxTakePlane
            // 
            this.pictureBoxTakePlane.Location = new System.Drawing.Point(3, 103);
            this.pictureBoxTakePlane.Name = "pictureBoxTakePlane";
            this.pictureBoxTakePlane.Size = new System.Drawing.Size(89, 91);
            this.pictureBoxTakePlane.TabIndex = 4;
            this.pictureBoxTakePlane.TabStop = false;
            // 
            // buttonTakeAirplane
            // 
            this.buttonTakeAirplane.Location = new System.Drawing.Point(13, 58);
            this.buttonTakeAirplane.Name = "buttonTakeAirplane";
            this.buttonTakeAirplane.Size = new System.Drawing.Size(67, 27);
            this.buttonTakeAirplane.TabIndex = 3;
            this.buttonTakeAirplane.Text = "Забрать";
            this.buttonTakeAirplane.UseVisualStyleBackColor = true;
            this.buttonTakeAirplane.Click += new System.EventHandler(this.buttonTakeAirplane_Click_);
            // 
            // headingplace
            // 
            this.headingplace.AutoSize = true;
            this.headingplace.Location = new System.Drawing.Point(10, 23);
            this.headingplace.Name = "headingplace";
            this.headingplace.Size = new System.Drawing.Size(42, 13);
            this.headingplace.TabIndex = 2;
            this.headingplace.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(63, 19);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Location = new System.Drawing.Point(0, 3);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(95, 13);
            this.heading.TabIndex = 0;
            this.heading.Text = "Забрать самолет";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(699, 25);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(86, 43);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // levels
            // 
            this.levels.AutoSize = true;
            this.levels.Location = new System.Drawing.Point(721, 9);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(45, 13);
            this.levels.TabIndex = 5;
            this.levels.Text = "Уровни";
            // 
            // buttonSetAirplane
            // 
            this.buttonSetAirplane.Location = new System.Drawing.Point(709, 120);
            this.buttonSetAirplane.Name = "buttonSetAirplane";
            this.buttonSetAirplane.Size = new System.Drawing.Size(67, 77);
            this.buttonSetAirplane.TabIndex = 6;
            this.buttonSetAirplane.Text = "Добавить самолет";
            this.buttonSetAirplane.UseVisualStyleBackColor = true;
            this.buttonSetAirplane.UseWaitCursor = true;
            this.buttonSetAirplane.Click += new System.EventHandler(this.buttonSetAirplane_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSetAirplane);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.PictureBox pictureBoxTakePlane;
        private System.Windows.Forms.Button buttonTakeAirplane;
        private System.Windows.Forms.Label headingplace;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Label levels;
        private System.Windows.Forms.Button buttonSetAirplane;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}