namespace Listas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomA = new System.Windows.Forms.TextBox();
            this.CantH = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Primero = new System.Windows.Forms.Button();
            this.Anterior = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Ultimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Asignaturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Horas";
            // 
            // NomA
            // 
            this.NomA.Location = new System.Drawing.Point(388, 122);
            this.NomA.Name = "NomA";
            this.NomA.Size = new System.Drawing.Size(317, 27);
            this.NomA.TabIndex = 3;
            // 
            // CantH
            // 
            this.CantH.Location = new System.Drawing.Point(388, 155);
            this.CantH.Name = "CantH";
            this.CantH.Size = new System.Drawing.Size(180, 27);
            this.CantH.TabIndex = 4;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(205, 257);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(94, 29);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Insertar";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(585, 257);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 29);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Eliminar";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Primero
            // 
            this.Primero.Location = new System.Drawing.Point(83, 344);
            this.Primero.Name = "Primero";
            this.Primero.Size = new System.Drawing.Size(94, 29);
            this.Primero.TabIndex = 7;
            this.Primero.Text = "Primero";
            this.Primero.UseVisualStyleBackColor = true;
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(282, 344);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(94, 29);
            this.Anterior.TabIndex = 8;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(484, 343);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(94, 29);
            this.Siguiente.TabIndex = 9;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            // 
            // Ultimo
            // 
            this.Ultimo.Location = new System.Drawing.Point(662, 344);
            this.Ultimo.Name = "Ultimo";
            this.Ultimo.Size = new System.Drawing.Size(94, 29);
            this.Ultimo.TabIndex = 10;
            this.Ultimo.Text = "Ultimo";
            this.Ultimo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ultimo);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.Primero);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.CantH);
            this.Controls.Add(this.NomA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NomA;
        private TextBox CantH;
        private Button Insert;
        private Button Delete;
        private Button Primero;
        private Button Anterior;
        private Button Siguiente;
        private Button Ultimo;
    }
}