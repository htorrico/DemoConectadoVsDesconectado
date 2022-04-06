
namespace DemoConectadoVsDesconectado
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvJefes = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJefes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Llenar DatTable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listar Conectado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(92, 240);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(460, 150);
            this.dgvEmpleados.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Mostrar Empleados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvJefes
            // 
            this.dgvJefes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJefes.Location = new System.Drawing.Point(92, 497);
            this.dgvJefes.Name = "dgvJefes";
            this.dgvJefes.RowHeadersWidth = 51;
            this.dgvJefes.RowTemplate.Height = 24;
            this.dgvJefes.Size = new System.Drawing.Size(460, 150);
            this.dgvJefes.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "Mostrar Jefes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvJefes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJefes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvJefes;
        private System.Windows.Forms.Button button4;
    }
}

