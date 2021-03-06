﻿namespace Ventana_Juego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            this.bucle = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblMovimientos = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.rel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cajacomodin = new System.Windows.Forms.GroupBox();
            this.comodin = new System.Windows.Forms.Label();
            this.gift = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.canvas = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.cajacomodin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gift)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje :";
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.Location = new System.Drawing.Point(151, 67);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(24, 25);
            this.puntos.TabIndex = 2;
            this.puntos.Text = "0";
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Tick += new System.EventHandler(this.bucle_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movimientos :";
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientos.Location = new System.Drawing.Point(151, 27);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(24, 25);
            this.lblMovimientos.TabIndex = 2;
            this.lblMovimientos.Text = "0";
            // 
            // reloj
            // 
            this.reloj.Interval = 1000;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // rel
            // 
            this.rel.AutoSize = true;
            this.rel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rel.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rel.Location = new System.Drawing.Point(91, 54);
            this.rel.Name = "rel";
            this.rel.Size = new System.Drawing.Size(13, 14);
            this.rel.TabIndex = 26;
            this.rel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.puntos);
            this.groupBox1.Controls.Add(this.lblMovimientos);
            this.groupBox1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 110);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcadores";
            // 
            // cajacomodin
            // 
            this.cajacomodin.Controls.Add(this.comodin);
            this.cajacomodin.Controls.Add(this.gift);
            this.cajacomodin.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajacomodin.Location = new System.Drawing.Point(311, 440);
            this.cajacomodin.Name = "cajacomodin";
            this.cajacomodin.Size = new System.Drawing.Size(257, 110);
            this.cajacomodin.TabIndex = 30;
            this.cajacomodin.TabStop = false;
            this.cajacomodin.Text = "Comodínes";
            this.cajacomodin.Visible = false;
            // 
            // comodin
            // 
            this.comodin.AutoSize = true;
            this.comodin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comodin.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comodin.Location = new System.Drawing.Point(120, 52);
            this.comodin.Name = "comodin";
            this.comodin.Size = new System.Drawing.Size(13, 14);
            this.comodin.TabIndex = 31;
            this.comodin.Text = "0";
            this.comodin.Visible = false;
            // 
            // gift
            // 
            this.gift.Image = global::Ventana_Juego.Properties.Resources.Gift_50px;
            this.gift.Location = new System.Drawing.Point(3, 16);
            this.gift.Margin = new System.Windows.Forms.Padding(0);
            this.gift.Name = "gift";
            this.gift.Size = new System.Drawing.Size(249, 86);
            this.gift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gift.TabIndex = 27;
            this.gift.TabStop = false;
            this.gift.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rel);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(612, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 110);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cronómetro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ventana_Juego.Properties.Resources.Stopwatch2_48px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 40);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 400);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(824, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cajacomodin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cajacomodin.ResumeLayout(false);
            this.cajacomodin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gift)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Timer bucle;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMovimientos;
        private System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label rel;
        private System.Windows.Forms.PictureBox gift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cajacomodin;
        private System.Windows.Forms.Label comodin;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

