namespace Presentation
{
    partial class PropertyCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            titulo = new Label();
            codigo = new Label();
            precio_alquiler = new Label();
            precio_venta = new Label();
            label2 = new Label();
            label1 = new Label();
            imagen_inmueble = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen_inmueble).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(titulo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 47);
            panel1.TabIndex = 2;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            titulo.Location = new Point(82, 12);
            titulo.Name = "titulo";
            titulo.Size = new Size(64, 25);
            titulo.TabIndex = 3;
            titulo.Text = "Local";
            // 
            // codigo
            // 
            codigo.AutoSize = true;
            codigo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            codigo.ForeColor = Color.Red;
            codigo.Location = new Point(83, 289);
            codigo.Name = "codigo";
            codigo.Size = new Size(63, 13);
            codigo.TabIndex = 11;
            codigo.Text = "Ref. 0000";
            // 
            // precio_alquiler
            // 
            precio_alquiler.AutoSize = true;
            precio_alquiler.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precio_alquiler.Location = new Point(83, 262);
            precio_alquiler.Name = "precio_alquiler";
            precio_alquiler.Size = new Size(87, 20);
            precio_alquiler.TabIndex = 10;
            precio_alquiler.Text = "RD$80000";
            // 
            // precio_venta
            // 
            precio_venta.AutoSize = true;
            precio_venta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precio_venta.Location = new Point(72, 234);
            precio_venta.Name = "precio_venta";
            precio_venta.Size = new Size(114, 20);
            precio_venta.TabIndex = 9;
            precio_venta.Text = "RD$15000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 262);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Alquiler:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 234);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 7;
            label1.Text = "Venta:";
            // 
            // imagen_inmueble
            // 
            imagen_inmueble.Location = new Point(0, 47);
            imagen_inmueble.Name = "imagen_inmueble";
            imagen_inmueble.Size = new Size(228, 176);
            imagen_inmueble.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen_inmueble.TabIndex = 12;
            imagen_inmueble.TabStop = false;
            // 
            // PropertyCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(imagen_inmueble);
            Controls.Add(codigo);
            Controls.Add(precio_alquiler);
            Controls.Add(precio_venta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(14);
            Name = "PropertyCard";
            Padding = new Padding(14);
            Size = new Size(226, 307);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagen_inmueble).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label titulo;
        private Label codigo;
        private Label precio_alquiler;
        private Label precio_venta;
        private Label label2;
        private Label label1;
        private PictureBox imagen_inmueble;
    }
}
