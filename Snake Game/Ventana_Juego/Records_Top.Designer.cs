namespace Ventana_Juego
{
    partial class Records_Top
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
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chbUsarFecha = new System.Windows.Forms.CheckBox();
            this.txtTop10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Items.AddRange(new object[] {
            "Puntuacion",
            "Tiempo",
            "Movimientos"});
            this.cbTipo.Location = new System.Drawing.Point(12, 40);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 0;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(140, 14);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 1;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(140, 40);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.movimientos,
            this.modo,
            this.nivel,
            this.puntos,
            this.tiempo,
            this.fecha});
            this.dataGridView1.Location = new System.Drawing.Point(13, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 362);
            this.dataGridView1.TabIndex = 2;
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "Id_user";
            this.id_user.HeaderText = "Usuario";
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // movimientos
            // 
            this.movimientos.DataPropertyName = "Movimientos";
            this.movimientos.HeaderText = "Movimientos";
            this.movimientos.Name = "movimientos";
            this.movimientos.ReadOnly = true;
            // 
            // modo
            // 
            this.modo.DataPropertyName = "Modo";
            this.modo.HeaderText = "Modo";
            this.modo.Name = "modo";
            this.modo.ReadOnly = true;
            // 
            // nivel
            // 
            this.nivel.DataPropertyName = "Nivel";
            this.nivel.HeaderText = "Nivel";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            // 
            // puntos
            // 
            this.puntos.DataPropertyName = "Puntos";
            this.puntos.HeaderText = "Puntos";
            this.puntos.Name = "puntos";
            this.puntos.ReadOnly = true;
            // 
            // tiempo
            // 
            this.tiempo.DataPropertyName = "Tiempo";
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(433, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 50);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chbUsarFecha
            // 
            this.chbUsarFecha.AutoSize = true;
            this.chbUsarFecha.Checked = true;
            this.chbUsarFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUsarFecha.Location = new System.Drawing.Point(346, 15);
            this.chbUsarFecha.Name = "chbUsarFecha";
            this.chbUsarFecha.Size = new System.Drawing.Size(81, 17);
            this.chbUsarFecha.TabIndex = 4;
            this.chbUsarFecha.Text = "Usar Fecha";
            this.chbUsarFecha.UseVisualStyleBackColor = true;
            // 
            // txtTop10
            // 
            this.txtTop10.Location = new System.Drawing.Point(12, 13);
            this.txtTop10.Name = "txtTop10";
            this.txtTop10.ReadOnly = true;
            this.txtTop10.Size = new System.Drawing.Size(121, 20);
            this.txtTop10.TabIndex = 5;
            this.txtTop10.Text = "Top 10";
            // 
            // Records_Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTop10);
            this.Controls.Add(this.chbUsarFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cbTipo);
            this.Name = "Records_Top";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Records";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn movimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn modo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chbUsarFecha;
        private System.Windows.Forms.TextBox txtTop10;
    }
}