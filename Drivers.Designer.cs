﻿namespace app_drivers
{
    partial class Drivers
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLotes = new System.Windows.Forms.Button();
            this.btnCamion = new System.Windows.Forms.Button();
            this.panelName = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.btnLotes);
            this.panelMenu.Controls.Add(this.btnCamion);
            this.panelMenu.Controls.Add(this.panelName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 681);
            this.panelMenu.TabIndex = 2;
            // 
            // btnLotes
            // 
            this.btnLotes.BackColor = System.Drawing.Color.Transparent;
            this.btnLotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLotes.FlatAppearance.BorderSize = 0;
            this.btnLotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLotes.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotes.Image = global::app_drivers.Properties.Resources.lot;
            this.btnLotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLotes.Location = new System.Drawing.Point(0, 140);
            this.btnLotes.Margin = new System.Windows.Forms.Padding(0);
            this.btnLotes.Name = "btnLotes";
            this.btnLotes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLotes.Size = new System.Drawing.Size(230, 40);
            this.btnLotes.TabIndex = 5;
            this.btnLotes.Text = " Lotes";
            this.btnLotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLotes.UseVisualStyleBackColor = false;
            this.btnLotes.Click += new System.EventHandler(this.btnLotes_Click);
            // 
            // btnCamion
            // 
            this.btnCamion.BackColor = System.Drawing.Color.Transparent;
            this.btnCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCamion.FlatAppearance.BorderSize = 0;
            this.btnCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamion.Image = global::app_drivers.Properties.Resources.truck;
            this.btnCamion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamion.Location = new System.Drawing.Point(0, 100);
            this.btnCamion.Margin = new System.Windows.Forms.Padding(0);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCamion.Size = new System.Drawing.Size(230, 40);
            this.btnCamion.TabIndex = 2;
            this.btnCamion.Text = "Mi camión";
            this.btnCamion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCamion.UseVisualStyleBackColor = false;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.pictureBox1);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Margin = new System.Windows.Forms.Padding(0);
            this.panelName.Name = "panelName";
            this.panelName.Padding = new System.Windows.Forms.Padding(20, 10, 0, 20);
            this.panelName.Size = new System.Drawing.Size(230, 100);
            this.panelName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::app_drivers.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(230, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 60);
            this.panel3.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1034, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inicio";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Drivers";
            this.Text = "Aplicación camionero";
            this.panelMenu.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLotes;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCamion;
    }
}

