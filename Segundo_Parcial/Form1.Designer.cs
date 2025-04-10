namespace Segundo_Parcial
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
            this.button1 = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cmbnombrelibro = new System.Windows.Forms.ComboBox();
            this.cmbnombrelector = new System.Windows.Forms.ComboBox();
            this.txtnombreautor = new System.Windows.Forms.TextBox();
            this.txtidlibro = new System.Windows.Forms.TextBox();
            this.txtidlector = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelfecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlibrosprestados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 55);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(1062, 498);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(154, 55);
            this.btncerrar.TabIndex = 34;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(685, 498);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(154, 55);
            this.btnactualizar.TabIndex = 33;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 355);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(521, 498);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(154, 55);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // cmbnombrelibro
            // 
            this.cmbnombrelibro.FormattingEnabled = true;
            this.cmbnombrelibro.Location = new System.Drawing.Point(277, 199);
            this.cmbnombrelibro.Name = "cmbnombrelibro";
            this.cmbnombrelibro.Size = new System.Drawing.Size(154, 24);
            this.cmbnombrelibro.TabIndex = 30;
            this.cmbnombrelibro.SelectedIndexChanged += new System.EventHandler(this.cmbnombrelibro_SelectedIndexChanged);
            // 
            // cmbnombrelector
            // 
            this.cmbnombrelector.FormattingEnabled = true;
            this.cmbnombrelector.Location = new System.Drawing.Point(277, 86);
            this.cmbnombrelector.Name = "cmbnombrelector";
            this.cmbnombrelector.Size = new System.Drawing.Size(154, 24);
            this.cmbnombrelector.TabIndex = 29;
            this.cmbnombrelector.SelectedIndexChanged += new System.EventHandler(this.cmbnombrelector_SelectedIndexChanged);
            // 
            // txtnombreautor
            // 
            this.txtnombreautor.Location = new System.Drawing.Point(277, 317);
            this.txtnombreautor.Name = "txtnombreautor";
            this.txtnombreautor.ReadOnly = true;
            this.txtnombreautor.Size = new System.Drawing.Size(154, 22);
            this.txtnombreautor.TabIndex = 28;
            // 
            // txtidlibro
            // 
            this.txtidlibro.Location = new System.Drawing.Point(277, 256);
            this.txtidlibro.Name = "txtidlibro";
            this.txtidlibro.ReadOnly = true;
            this.txtidlibro.Size = new System.Drawing.Size(154, 22);
            this.txtidlibro.TabIndex = 27;
            // 
            // txtidlector
            // 
            this.txtidlector.Location = new System.Drawing.Point(277, 142);
            this.txtidlector.Name = "txtidlector";
            this.txtidlector.ReadOnly = true;
            this.txtidlector.Size = new System.Drawing.Size(154, 22);
            this.txtidlector.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombre de autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Numero de identificacion libro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nombre del libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Numero de identificacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre del lector:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Prestamos:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(162, 383);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 36;
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.Location = new System.Drawing.Point(20, 372);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(137, 18);
            this.labelfecha.TabIndex = 37;
            this.labelfecha.Text = "Ingrese La fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Libros prestados:";
            // 
            // txtlibrosprestados
            // 
            this.txtlibrosprestados.Location = new System.Drawing.Point(873, 608);
            this.txtlibrosprestados.Name = "txtlibrosprestados";
            this.txtlibrosprestados.ReadOnly = true;
            this.txtlibrosprestados.Size = new System.Drawing.Size(122, 22);
            this.txtlibrosprestados.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 693);
            this.Controls.Add(this.txtlibrosprestados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cmbnombrelibro);
            this.Controls.Add(this.cmbnombrelector);
            this.Controls.Add(this.txtnombreautor);
            this.Controls.Add(this.txtidlibro);
            this.Controls.Add(this.txtidlector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ComboBox cmbnombrelibro;
        private System.Windows.Forms.ComboBox cmbnombrelector;
        private System.Windows.Forms.TextBox txtnombreautor;
        private System.Windows.Forms.TextBox txtidlibro;
        private System.Windows.Forms.TextBox txtidlector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlibrosprestados;
    }
}

