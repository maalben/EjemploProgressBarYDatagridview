﻿namespace EjemploProgressBarYDatagridview
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnusogroupbox = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Uso de DatagridView";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnusogroupbox
            // 
            this.btnusogroupbox.Location = new System.Drawing.Point(54, 131);
            this.btnusogroupbox.Name = "btnusogroupbox";
            this.btnusogroupbox.Size = new System.Drawing.Size(281, 39);
            this.btnusogroupbox.TabIndex = 2;
            this.btnusogroupbox.Text = "Uso de GroupBox";
            this.btnusogroupbox.UseVisualStyleBackColor = true;
            this.btnusogroupbox.Click += new System.EventHandler(this.btnusogroupbox_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(137, 192);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(112, 46);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 250);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnusogroupbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnusogroupbox;
        private System.Windows.Forms.Button btnsalir;
    }
}