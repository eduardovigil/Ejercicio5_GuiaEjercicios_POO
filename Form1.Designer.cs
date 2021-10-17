namespace Ejercicio5_GuiaEjercicios_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.btningresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa \"San Benito Vista\"";
            // 
            // dgvinfo
            // 
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Location = new System.Drawing.Point(15, 290);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.Size = new System.Drawing.Size(553, 148);
            this.dgvinfo.TabIndex = 1;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.Khaki;
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(404, 145);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(164, 40);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar Cliente";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono del cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Direccion del cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Correo del cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Edad del cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Metodo de pago:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(182, 90);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(203, 20);
            this.txtnombre.TabIndex = 12;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(182, 115);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(203, 20);
            this.txttelefono.TabIndex = 13;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(182, 141);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(203, 20);
            this.txtdireccion.TabIndex = 14;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(182, 172);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(203, 20);
            this.txtcorreo.TabIndex = 15;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(182, 198);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(203, 20);
            this.txtedad.TabIndex = 16;
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.Location = new System.Drawing.Point(404, 81);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(164, 42);
            this.btnmenu.TabIndex = 18;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(404, 198);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(164, 40);
            this.btneliminar.TabIndex = 19;
            this.btneliminar.Text = "Eliminar Cliente";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.dgvinfo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

