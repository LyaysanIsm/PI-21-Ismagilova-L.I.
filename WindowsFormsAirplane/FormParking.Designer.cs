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
            this.button_Airplane = new System.Windows.Forms.Button();
            this.button_Fighter = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakePlane = new System.Windows.Forms.PictureBox();
            this.buttonTakeAirplane = new System.Windows.Forms.Button();
            this.headingplace = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(689, 449);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // button_Airplane
            // 
            this.button_Airplane.Location = new System.Drawing.Point(696, 12);
            this.button_Airplane.Name = "button_Airplane";
            this.button_Airplane.Size = new System.Drawing.Size(92, 53);
            this.button_Airplane.TabIndex = 1;
            this.button_Airplane.Text = "Припарковать самолет";
            this.button_Airplane.UseVisualStyleBackColor = true;
            this.button_Airplane.Click += new System.EventHandler(this.button_Airplane_Click);
            // 
            // button_Fighter
            // 
            this.button_Fighter.Location = new System.Drawing.Point(696, 71);
            this.button_Fighter.Name = "button_Fighter";
            this.button_Fighter.Size = new System.Drawing.Size(92, 53);
            this.button_Fighter.TabIndex = 2;
            this.button_Fighter.Text = "Припарковать истребитель";
            this.button_Fighter.UseVisualStyleBackColor = true;
            this.button_Fighter.Click += new System.EventHandler(this.button_Fighter_Click);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button_Fighter);
            this.Controls.Add(this.button_Airplane);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button button_Airplane;
        private System.Windows.Forms.Button button_Fighter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.PictureBox pictureBoxTakePlane;
        private System.Windows.Forms.Button buttonTakeAirplane;
        private System.Windows.Forms.Label headingplace;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
    }
}