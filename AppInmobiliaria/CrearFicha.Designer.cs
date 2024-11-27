namespace Presentation
{
    partial class CrearFicha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearFicha));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            cancelar = new MaterialSkin.Controls.MaterialButton();
            continuar = new MaterialSkin.Controls.MaterialButton();
            tipoLocal = new MaterialSkin.Controls.MaterialComboBox();
            direccion = new MaterialSkin.Controls.MaterialTextBox2();
            precioAlquiler = new MaterialSkin.Controls.MaterialTextBox2();
            area = new MaterialSkin.Controls.MaterialTextBox2();
            precioVenta = new MaterialSkin.Controls.MaterialTextBox2();
            label2 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            telefonoPropietario = new MaterialSkin.Controls.MaterialTextBox2();
            nombrePropietario = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            subirImagen = new MaterialSkin.Controls.MaterialButton();
            materialCard8 = new MaterialSkin.Controls.MaterialCard();
            pictureBox12 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 721);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(materialCard3);
            panel3.Controls.Add(materialCard2);
            panel3.Controls.Add(materialCard1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 621);
            panel3.TabIndex = 2;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(cancelar);
            materialCard3.Controls.Add(continuar);
            materialCard3.Controls.Add(tipoLocal);
            materialCard3.Controls.Add(direccion);
            materialCard3.Controls.Add(precioAlquiler);
            materialCard3.Controls.Add(area);
            materialCard3.Controls.Add(precioVenta);
            materialCard3.Controls.Add(label2);
            materialCard3.Depth = 0;
            materialCard3.Font = new Font("Segoe UI", 20F);
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(23, 329);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(738, 278);
            materialCard3.TabIndex = 2;
            // 
            // cancelar
            // 
            cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelar.Depth = 0;
            cancelar.HighEmphasis = true;
            cancelar.Icon = null;
            cancelar.Location = new Point(507, 225);
            cancelar.Margin = new Padding(4, 6, 4, 6);
            cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            cancelar.Name = "cancelar";
            cancelar.NoAccentTextColor = Color.Empty;
            cancelar.Size = new Size(96, 36);
            cancelar.TabIndex = 23;
            cancelar.Text = "Cancelar";
            cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelar.UseAccentColor = false;
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // continuar
            // 
            continuar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            continuar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            continuar.Depth = 0;
            continuar.HighEmphasis = true;
            continuar.Icon = null;
            continuar.Location = new Point(375, 225);
            continuar.Margin = new Padding(4, 6, 4, 6);
            continuar.MouseState = MaterialSkin.MouseState.HOVER;
            continuar.Name = "continuar";
            continuar.NoAccentTextColor = Color.Empty;
            continuar.Size = new Size(104, 36);
            continuar.TabIndex = 22;
            continuar.Text = "Continuar";
            continuar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            continuar.UseAccentColor = false;
            continuar.UseVisualStyleBackColor = true;
            // 
            // tipoLocal
            // 
            tipoLocal.AutoResize = false;
            tipoLocal.BackColor = Color.FromArgb(255, 255, 255);
            tipoLocal.Depth = 0;
            tipoLocal.DrawMode = DrawMode.OwnerDrawVariable;
            tipoLocal.DropDownHeight = 174;
            tipoLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoLocal.DropDownWidth = 121;
            tipoLocal.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            tipoLocal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            tipoLocal.FormattingEnabled = true;
            tipoLocal.IntegralHeight = false;
            tipoLocal.ItemHeight = 43;
            tipoLocal.Items.AddRange(new object[] { "Vivienda", "Local" });
            tipoLocal.Location = new Point(37, 212);
            tipoLocal.MaxDropDownItems = 4;
            tipoLocal.MouseState = MaterialSkin.MouseState.OUT;
            tipoLocal.Name = "tipoLocal";
            tipoLocal.Size = new Size(146, 49);
            tipoLocal.StartIndex = 0;
            tipoLocal.TabIndex = 5;
            // 
            // direccion
            // 
            direccion.AnimateReadOnly = false;
            direccion.BackgroundImageLayout = ImageLayout.None;
            direccion.CharacterCasing = CharacterCasing.Normal;
            direccion.Depth = 0;
            direccion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            direccion.HideSelection = true;
            direccion.Hint = "Direccion";
            direccion.LeadingIcon = null;
            direccion.Location = new Point(380, 145);
            direccion.MaxLength = 32767;
            direccion.MouseState = MaterialSkin.MouseState.OUT;
            direccion.Name = "direccion";
            direccion.PasswordChar = '\0';
            direccion.PrefixSuffixText = null;
            direccion.ReadOnly = false;
            direccion.RightToLeft = RightToLeft.No;
            direccion.SelectedText = "";
            direccion.SelectionLength = 0;
            direccion.SelectionStart = 0;
            direccion.ShortcutsEnabled = true;
            direccion.Size = new Size(318, 48);
            direccion.TabIndex = 4;
            direccion.TabStop = false;
            direccion.TextAlign = HorizontalAlignment.Left;
            direccion.TrailingIcon = null;
            direccion.UseSystemPasswordChar = false;
            // 
            // precioAlquiler
            // 
            precioAlquiler.AnimateReadOnly = false;
            precioAlquiler.BackgroundImageLayout = ImageLayout.None;
            precioAlquiler.CharacterCasing = CharacterCasing.Normal;
            precioAlquiler.Depth = 0;
            precioAlquiler.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            precioAlquiler.HideSelection = true;
            precioAlquiler.Hint = "Precio de Alquiler";
            precioAlquiler.LeadingIcon = null;
            precioAlquiler.Location = new Point(380, 78);
            precioAlquiler.MaxLength = 32767;
            precioAlquiler.MouseState = MaterialSkin.MouseState.OUT;
            precioAlquiler.Name = "precioAlquiler";
            precioAlquiler.PasswordChar = '\0';
            precioAlquiler.PrefixSuffixText = null;
            precioAlquiler.ReadOnly = false;
            precioAlquiler.RightToLeft = RightToLeft.No;
            precioAlquiler.SelectedText = "";
            precioAlquiler.SelectionLength = 0;
            precioAlquiler.SelectionStart = 0;
            precioAlquiler.ShortcutsEnabled = true;
            precioAlquiler.Size = new Size(318, 48);
            precioAlquiler.TabIndex = 3;
            precioAlquiler.TabStop = false;
            precioAlquiler.TextAlign = HorizontalAlignment.Left;
            precioAlquiler.TrailingIcon = null;
            precioAlquiler.UseSystemPasswordChar = false;
            // 
            // area
            // 
            area.AnimateReadOnly = false;
            area.BackgroundImageLayout = ImageLayout.None;
            area.CharacterCasing = CharacterCasing.Normal;
            area.Depth = 0;
            area.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            area.HideSelection = true;
            area.Hint = "Área (m²)";
            area.LeadingIcon = null;
            area.Location = new Point(37, 145);
            area.MaxLength = 32767;
            area.MouseState = MaterialSkin.MouseState.OUT;
            area.Name = "area";
            area.PasswordChar = '\0';
            area.PrefixSuffixText = null;
            area.ReadOnly = false;
            area.RightToLeft = RightToLeft.No;
            area.SelectedText = "";
            area.SelectionLength = 0;
            area.SelectionStart = 0;
            area.ShortcutsEnabled = true;
            area.Size = new Size(318, 48);
            area.TabIndex = 2;
            area.TabStop = false;
            area.TextAlign = HorizontalAlignment.Left;
            area.TrailingIcon = null;
            area.UseSystemPasswordChar = false;
            // 
            // precioVenta
            // 
            precioVenta.AnimateReadOnly = false;
            precioVenta.BackgroundImageLayout = ImageLayout.None;
            precioVenta.CharacterCasing = CharacterCasing.Normal;
            precioVenta.Depth = 0;
            precioVenta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            precioVenta.HideSelection = true;
            precioVenta.Hint = "Precio de venta";
            precioVenta.LeadingIcon = null;
            precioVenta.Location = new Point(37, 78);
            precioVenta.MaxLength = 32767;
            precioVenta.MouseState = MaterialSkin.MouseState.OUT;
            precioVenta.Name = "precioVenta";
            precioVenta.PasswordChar = '\0';
            precioVenta.PrefixSuffixText = null;
            precioVenta.ReadOnly = false;
            precioVenta.RightToLeft = RightToLeft.No;
            precioVenta.SelectedText = "";
            precioVenta.SelectionLength = 0;
            precioVenta.SelectionStart = 0;
            precioVenta.ShortcutsEnabled = true;
            precioVenta.Size = new Size(318, 48);
            precioVenta.TabIndex = 1;
            precioVenta.TabStop = false;
            precioVenta.TextAlign = HorizontalAlignment.Left;
            precioVenta.TrailingIcon = null;
            precioVenta.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 20F);
            label2.Location = new Point(244, 14);
            label2.Name = "label2";
            label2.Size = new Size(253, 37);
            label2.TabIndex = 0;
            label2.Text = "Datos del inmueble";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(telefonoPropietario);
            materialCard2.Controls.Add(nombrePropietario);
            materialCard2.Controls.Add(label1);
            materialCard2.Depth = 0;
            materialCard2.Font = new Font("Segoe UI", 20F);
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(23, 53);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(420, 248);
            materialCard2.TabIndex = 1;
            // 
            // telefonoPropietario
            // 
            telefonoPropietario.AnimateReadOnly = false;
            telefonoPropietario.BackgroundImageLayout = ImageLayout.None;
            telefonoPropietario.CharacterCasing = CharacterCasing.Normal;
            telefonoPropietario.Depth = 0;
            telefonoPropietario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            telefonoPropietario.HideSelection = true;
            telefonoPropietario.Hint = "Teléfono";
            telefonoPropietario.LeadingIcon = null;
            telefonoPropietario.Location = new Point(57, 162);
            telefonoPropietario.MaxLength = 32767;
            telefonoPropietario.MouseState = MaterialSkin.MouseState.OUT;
            telefonoPropietario.Name = "telefonoPropietario";
            telefonoPropietario.PasswordChar = '\0';
            telefonoPropietario.PrefixSuffixText = null;
            telefonoPropietario.ReadOnly = false;
            telefonoPropietario.RightToLeft = RightToLeft.No;
            telefonoPropietario.SelectedText = "";
            telefonoPropietario.SelectionLength = 0;
            telefonoPropietario.SelectionStart = 0;
            telefonoPropietario.ShortcutsEnabled = true;
            telefonoPropietario.Size = new Size(318, 48);
            telefonoPropietario.TabIndex = 2;
            telefonoPropietario.TabStop = false;
            telefonoPropietario.TextAlign = HorizontalAlignment.Left;
            telefonoPropietario.TrailingIcon = null;
            telefonoPropietario.UseSystemPasswordChar = false;
            // 
            // nombrePropietario
            // 
            nombrePropietario.AnimateReadOnly = false;
            nombrePropietario.BackgroundImageLayout = ImageLayout.None;
            nombrePropietario.CharacterCasing = CharacterCasing.Normal;
            nombrePropietario.Depth = 0;
            nombrePropietario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nombrePropietario.HideSelection = true;
            nombrePropietario.Hint = "Nombre";
            nombrePropietario.LeadingIcon = null;
            nombrePropietario.Location = new Point(57, 95);
            nombrePropietario.MaxLength = 32767;
            nombrePropietario.MouseState = MaterialSkin.MouseState.OUT;
            nombrePropietario.Name = "nombrePropietario";
            nombrePropietario.PasswordChar = '\0';
            nombrePropietario.PrefixSuffixText = null;
            nombrePropietario.ReadOnly = false;
            nombrePropietario.RightToLeft = RightToLeft.No;
            nombrePropietario.SelectedText = "";
            nombrePropietario.SelectionLength = 0;
            nombrePropietario.SelectionStart = 0;
            nombrePropietario.ShortcutsEnabled = true;
            nombrePropietario.Size = new Size(318, 48);
            nombrePropietario.TabIndex = 1;
            nombrePropietario.TabStop = false;
            nombrePropietario.TextAlign = HorizontalAlignment.Left;
            nombrePropietario.TrailingIcon = null;
            nombrePropietario.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20F);
            label1.Location = new Point(80, 28);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 0;
            label1.Text = "Datos del propietario";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(subirImagen);
            materialCard1.Controls.Add(materialCard8);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(476, 17);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(285, 284);
            materialCard1.TabIndex = 0;
            // 
            // subirImagen
            // 
            subirImagen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            subirImagen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            subirImagen.Depth = 0;
            subirImagen.HighEmphasis = true;
            subirImagen.Icon = null;
            subirImagen.Location = new Point(82, 239);
            subirImagen.Margin = new Padding(4, 6, 4, 6);
            subirImagen.MouseState = MaterialSkin.MouseState.HOVER;
            subirImagen.Name = "subirImagen";
            subirImagen.NoAccentTextColor = Color.Empty;
            subirImagen.Size = new Size(122, 36);
            subirImagen.TabIndex = 21;
            subirImagen.Text = "subir Imagen";
            subirImagen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            subirImagen.UseAccentColor = false;
            subirImagen.UseVisualStyleBackColor = true;
            // 
            // materialCard8
            // 
            materialCard8.BackColor = Color.FromArgb(255, 255, 255);
            materialCard8.Controls.Add(pictureBox12);
            materialCard8.Depth = 0;
            materialCard8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard8.Location = new Point(28, 28);
            materialCard8.Margin = new Padding(14);
            materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard8.Name = "materialCard8";
            materialCard8.Padding = new Padding(14);
            materialCard8.Size = new Size(234, 202);
            materialCard8.TabIndex = 2;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(2, 0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(232, 202);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 4;
            pictureBox12.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 30F);
            label3.Location = new Point(23, 24);
            label3.Name = "label3";
            label3.Size = new Size(205, 54);
            label3.TabIndex = 0;
            label3.Text = "Oficina de";
            // 
            // CrearFicha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 821);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CrearFicha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearFicha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private PictureBox pictureBox12;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton subirImagen;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 telefonoPropietario;
        private MaterialSkin.Controls.MaterialTextBox2 nombrePropietario;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox2 area;
        private MaterialSkin.Controls.MaterialTextBox2 precioVenta;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 direccion;
        private MaterialSkin.Controls.MaterialTextBox2 precioAlquiler;
        private MaterialSkin.Controls.MaterialComboBox tipoLocal;
        private MaterialSkin.Controls.MaterialButton cancelar;
        private MaterialSkin.Controls.MaterialButton continuar;
        private Label label3;
    }
}