namespace Ventana_Juego
{
    partial class Menu_Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Juego));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnJugar = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.recordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Image = global::Login.Properties.Resources.Menu_24px;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.ShortcutKeyDisplayString = "F10";
            this.opcionesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.ToolTipText = "Opciones";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporte1ToolStripMenuItem,
            this.reporte2ToolStripMenuItem,
            this.reporte3ToolStripMenuItem,
            this.reporte4ToolStripMenuItem});
            this.recordsToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsToolStripMenuItem.Image = global::Login.Properties.Resources.Trophy_48px;
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.ShortcutKeyDisplayString = "F11";
            this.recordsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.ToolTipText = "Records";
            // 
            // reporte1ToolStripMenuItem
            // 
            this.reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            this.reporte1ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.reporte1ToolStripMenuItem.Text = "Records Top 10";
            this.reporte1ToolStripMenuItem.Click += new System.EventHandler(this.reporte1ToolStripMenuItem_Click);
            // 
            // reporte2ToolStripMenuItem
            // 
            this.reporte2ToolStripMenuItem.Name = "reporte2ToolStripMenuItem";
            this.reporte2ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.reporte2ToolStripMenuItem.Text = "Modo más jugado";
            this.reporte2ToolStripMenuItem.Click += new System.EventHandler(this.reporte2ToolStripMenuItem_Click);
            // 
            // reporte3ToolStripMenuItem
            // 
            this.reporte3ToolStripMenuItem.Name = "reporte3ToolStripMenuItem";
            this.reporte3ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.reporte3ToolStripMenuItem.Text = "Ultimo nivel superado";
            // 
            // reporte4ToolStripMenuItem
            // 
            this.reporte4ToolStripMenuItem.Name = "reporte4ToolStripMenuItem";
            this.reporte4ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.reporte4ToolStripMenuItem.Text = "Inicios de Sesion";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Modo 2";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Modo 1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 114);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Modo 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar modo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(413, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo 3";
            this.groupBox2.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 54);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(132, 24);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Sin obstaculos";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(107, 24);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Obstaculos";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnJugar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnJugar.Image = global::Login.Properties.Resources.Joystick_48px;
            this.btnJugar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugar.Location = new System.Drawing.Point(186, 280);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(439, 52);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.toolTip1.SetToolTip(this.btnJugar, "Jugar");
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(784, 23);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Login.Properties.Resources.Delete_64px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(688, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 39);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Cerrar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Juego";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Juego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Juego_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte4ToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}