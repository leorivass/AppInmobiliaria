namespace Presentation
{
    partial class AñadirInmueble
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
            panel3 = new Panel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            oficinaComboBox = new MaterialSkin.Controls.MaterialComboBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pictureBox1 = new PictureBox();
            subirImagenButton = new MaterialSkin.Controls.MaterialButton();
            cancelarButton = new MaterialSkin.Controls.MaterialButton();
            continuarButton = new MaterialSkin.Controls.MaterialButton();
            propietarioComboBox = new MaterialSkin.Controls.MaterialComboBox();
            tipoLocalComboBox = new MaterialSkin.Controls.MaterialComboBox();
            direccion = new MaterialSkin.Controls.MaterialTextBox2();
            precioAlquiler = new MaterialSkin.Controls.MaterialTextBox2();
            area = new MaterialSkin.Controls.MaterialTextBox2();
            precioVenta = new MaterialSkin.Controls.MaterialTextBox2();
            label2 = new Label();
            panel3.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(materialCard3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(833, 342);
            panel3.TabIndex = 2;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(oficinaComboBox);
            materialCard3.Controls.Add(materialCard1);
            materialCard3.Controls.Add(subirImagenButton);
            materialCard3.Controls.Add(cancelarButton);
            materialCard3.Controls.Add(continuarButton);
            materialCard3.Controls.Add(propietarioComboBox);
            materialCard3.Controls.Add(tipoLocalComboBox);
            materialCard3.Controls.Add(direccion);
            materialCard3.Controls.Add(precioAlquiler);
            materialCard3.Controls.Add(area);
            materialCard3.Controls.Add(precioVenta);
            materialCard3.Controls.Add(label2);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Fill;
            materialCard3.Font = new Font("Segoe UI", 20F);
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(0, 0);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(833, 342);
            materialCard3.TabIndex = 2;
            // 
            // oficinaComboBox
            // 
            oficinaComboBox.AutoResize = false;
            oficinaComboBox.BackColor = Color.FromArgb(255, 255, 255);
            oficinaComboBox.Depth = 0;
            oficinaComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            oficinaComboBox.DropDownHeight = 174;
            oficinaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            oficinaComboBox.DropDownWidth = 121;
            oficinaComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            oficinaComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            oficinaComboBox.FormattingEnabled = true;
            oficinaComboBox.Hint = "Oficina";
            oficinaComboBox.IntegralHeight = false;
            oficinaComboBox.ItemHeight = 43;
            oficinaComboBox.Location = new Point(26, 276);
            oficinaComboBox.MaxDropDownItems = 4;
            oficinaComboBox.MouseState = MaterialSkin.MouseState.OUT;
            oficinaComboBox.Name = "oficinaComboBox";
            oficinaComboBox.Size = new Size(251, 49);
            oficinaComboBox.StartIndex = 0;
            oficinaComboBox.TabIndex = 12;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(590, 77);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(220, 180);
            materialCard1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // subirImagenButton
            // 
            subirImagenButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            subirImagenButton.Cursor = Cursors.Hand;
            subirImagenButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            subirImagenButton.Depth = 0;
            subirImagenButton.HighEmphasis = true;
            subirImagenButton.Icon = null;
            subirImagenButton.Location = new Point(637, 276);
            subirImagenButton.Margin = new Padding(4, 6, 4, 6);
            subirImagenButton.MouseState = MaterialSkin.MouseState.HOVER;
            subirImagenButton.Name = "subirImagenButton";
            subirImagenButton.NoAccentTextColor = Color.Empty;
            subirImagenButton.Size = new Size(122, 36);
            subirImagenButton.TabIndex = 10;
            subirImagenButton.Text = "Subir imagen";
            subirImagenButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            subirImagenButton.UseAccentColor = false;
            subirImagenButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            cancelarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelarButton.Depth = 0;
            cancelarButton.HighEmphasis = true;
            cancelarButton.Icon = null;
            cancelarButton.Location = new Point(467, 286);
            cancelarButton.Margin = new Padding(4, 6, 4, 6);
            cancelarButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.NoAccentTextColor = Color.Empty;
            cancelarButton.Size = new Size(96, 36);
            cancelarButton.TabIndex = 9;
            cancelarButton.Text = "Cancelar";
            cancelarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelarButton.UseAccentColor = false;
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // continuarButton
            // 
            continuarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            continuarButton.Cursor = Cursors.Hand;
            continuarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            continuarButton.Depth = 0;
            continuarButton.HighEmphasis = true;
            continuarButton.Icon = null;
            continuarButton.Location = new Point(312, 286);
            continuarButton.Margin = new Padding(4, 6, 4, 6);
            continuarButton.MouseState = MaterialSkin.MouseState.HOVER;
            continuarButton.Name = "continuarButton";
            continuarButton.NoAccentTextColor = Color.Empty;
            continuarButton.Size = new Size(104, 36);
            continuarButton.TabIndex = 8;
            continuarButton.Text = "Continuar";
            continuarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            continuarButton.UseAccentColor = false;
            continuarButton.UseVisualStyleBackColor = true;
            // 
            // propietarioComboBox
            // 
            propietarioComboBox.AutoResize = false;
            propietarioComboBox.BackColor = Color.FromArgb(255, 255, 255);
            propietarioComboBox.Depth = 0;
            propietarioComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            propietarioComboBox.DropDownHeight = 174;
            propietarioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            propietarioComboBox.DropDownWidth = 250;
            propietarioComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            propietarioComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            propietarioComboBox.FormattingEnabled = true;
            propietarioComboBox.Hint = "Seleccionar propietario";
            propietarioComboBox.IntegralHeight = false;
            propietarioComboBox.ItemHeight = 43;
            propietarioComboBox.Location = new Point(26, 77);
            propietarioComboBox.MaxDropDownItems = 4;
            propietarioComboBox.MouseState = MaterialSkin.MouseState.OUT;
            propietarioComboBox.Name = "propietarioComboBox";
            propietarioComboBox.Size = new Size(251, 49);
            propietarioComboBox.StartIndex = 0;
            propietarioComboBox.TabIndex = 6;
            // 
            // tipoLocalComboBox
            // 
            tipoLocalComboBox.AutoResize = false;
            tipoLocalComboBox.BackColor = Color.FromArgb(255, 255, 255);
            tipoLocalComboBox.Depth = 0;
            tipoLocalComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            tipoLocalComboBox.DropDownHeight = 174;
            tipoLocalComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoLocalComboBox.DropDownWidth = 121;
            tipoLocalComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            tipoLocalComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            tipoLocalComboBox.FormattingEnabled = true;
            tipoLocalComboBox.Hint = "Tipo de vivienda";
            tipoLocalComboBox.IntegralHeight = false;
            tipoLocalComboBox.ItemHeight = 43;
            tipoLocalComboBox.Items.AddRange(new object[] { "Vivienda", "Local" });
            tipoLocalComboBox.Location = new Point(312, 77);
            tipoLocalComboBox.MaxDropDownItems = 4;
            tipoLocalComboBox.MouseState = MaterialSkin.MouseState.OUT;
            tipoLocalComboBox.Name = "tipoLocalComboBox";
            tipoLocalComboBox.Size = new Size(251, 49);
            tipoLocalComboBox.StartIndex = 0;
            tipoLocalComboBox.TabIndex = 5;
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
            direccion.Location = new Point(312, 145);
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
            direccion.Size = new Size(251, 48);
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
            precioAlquiler.Location = new Point(26, 212);
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
            precioAlquiler.Size = new Size(251, 48);
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
            area.Location = new Point(312, 212);
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
            area.Size = new Size(251, 48);
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
            precioVenta.Location = new Point(26, 145);
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
            precioVenta.Size = new Size(251, 48);
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
            label2.Location = new Point(312, 14);
            label2.Name = "label2";
            label2.Size = new Size(253, 37);
            label2.TabIndex = 0;
            label2.Text = "Datos del inmueble";
            // 
            // AñadirInmueble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 342);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AñadirInmueble";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Inmueble";
            panel3.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox2 area;
        private MaterialSkin.Controls.MaterialTextBox2 precioVenta;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 direccion;
        private MaterialSkin.Controls.MaterialTextBox2 precioAlquiler;
        private MaterialSkin.Controls.MaterialComboBox tipoLocalComboBox;
        private MaterialSkin.Controls.MaterialComboBox propietarioComboBox;
        private MaterialSkin.Controls.MaterialButton subirImagenButton;
        private MaterialSkin.Controls.MaterialButton cancelarButton;
        private MaterialSkin.Controls.MaterialButton continuarButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialComboBox oficinaComboBox;
    }
}