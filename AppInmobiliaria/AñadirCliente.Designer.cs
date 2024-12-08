namespace Presentation
{
    partial class AñadirCliente
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
            cancelarButton = new MaterialSkin.Controls.MaterialButton();
            finalizarButton = new MaterialSkin.Controls.MaterialButton();
            cedulaCliente = new MaterialSkin.Controls.MaterialTextBox2();
            correoCliente = new MaterialSkin.Controls.MaterialTextBox2();
            telefonoCliente = new MaterialSkin.Controls.MaterialTextBox2();
            nombreCliente = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelarButton.Depth = 0;
            cancelarButton.HighEmphasis = true;
            cancelarButton.Icon = null;
            cancelarButton.Location = new Point(630, 229);
            cancelarButton.Margin = new Padding(4, 6, 4, 6);
            cancelarButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.NoAccentTextColor = Color.Empty;
            cancelarButton.Size = new Size(96, 36);
            cancelarButton.TabIndex = 13;
            cancelarButton.Text = "Cancelar";
            cancelarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelarButton.UseAccentColor = false;
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // finalizarButton
            // 
            finalizarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            finalizarButton.Cursor = Cursors.Hand;
            finalizarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            finalizarButton.Depth = 0;
            finalizarButton.HighEmphasis = true;
            finalizarButton.Icon = null;
            finalizarButton.Location = new Point(515, 229);
            finalizarButton.Margin = new Padding(4, 6, 4, 6);
            finalizarButton.MouseState = MaterialSkin.MouseState.HOVER;
            finalizarButton.Name = "finalizarButton";
            finalizarButton.NoAccentTextColor = Color.Empty;
            finalizarButton.Size = new Size(94, 36);
            finalizarButton.TabIndex = 12;
            finalizarButton.Text = "Finalizar";
            finalizarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            finalizarButton.UseAccentColor = false;
            finalizarButton.UseVisualStyleBackColor = true;
            finalizarButton.Click += finalizarButton_Click;
            // 
            // cedulaCliente
            // 
            cedulaCliente.AnimateReadOnly = false;
            cedulaCliente.BackgroundImageLayout = ImageLayout.None;
            cedulaCliente.CharacterCasing = CharacterCasing.Normal;
            cedulaCliente.Depth = 0;
            cedulaCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cedulaCliente.HideSelection = true;
            cedulaCliente.Hint = "Cédula";
            cedulaCliente.LeadingIcon = null;
            cedulaCliente.Location = new Point(406, 167);
            cedulaCliente.MaxLength = 32767;
            cedulaCliente.MouseState = MaterialSkin.MouseState.OUT;
            cedulaCliente.Name = "cedulaCliente";
            cedulaCliente.PasswordChar = '\0';
            cedulaCliente.PrefixSuffixText = null;
            cedulaCliente.ReadOnly = false;
            cedulaCliente.RightToLeft = RightToLeft.No;
            cedulaCliente.SelectedText = "";
            cedulaCliente.SelectionLength = 0;
            cedulaCliente.SelectionStart = 0;
            cedulaCliente.ShortcutsEnabled = true;
            cedulaCliente.Size = new Size(318, 48);
            cedulaCliente.TabIndex = 11;
            cedulaCliente.TabStop = false;
            cedulaCliente.TextAlign = HorizontalAlignment.Left;
            cedulaCliente.TrailingIcon = null;
            cedulaCliente.UseSystemPasswordChar = false;
            cedulaCliente.TextChanged += cedulaCliente_TextChanged;
            // 
            // correoCliente
            // 
            correoCliente.AnimateReadOnly = false;
            correoCliente.BackgroundImageLayout = ImageLayout.None;
            correoCliente.CharacterCasing = CharacterCasing.Normal;
            correoCliente.Depth = 0;
            correoCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            correoCliente.HideSelection = true;
            correoCliente.Hint = "Correo electrónico";
            correoCliente.LeadingIcon = null;
            correoCliente.Location = new Point(51, 167);
            correoCliente.MaxLength = 32767;
            correoCliente.MouseState = MaterialSkin.MouseState.OUT;
            correoCliente.Name = "correoCliente";
            correoCliente.PasswordChar = '\0';
            correoCliente.PrefixSuffixText = null;
            correoCliente.ReadOnly = false;
            correoCliente.RightToLeft = RightToLeft.No;
            correoCliente.SelectedText = "";
            correoCliente.SelectionLength = 0;
            correoCliente.SelectionStart = 0;
            correoCliente.ShortcutsEnabled = true;
            correoCliente.Size = new Size(318, 48);
            correoCliente.TabIndex = 10;
            correoCliente.TabStop = false;
            correoCliente.TextAlign = HorizontalAlignment.Left;
            correoCliente.TrailingIcon = null;
            correoCliente.UseSystemPasswordChar = false;
            // 
            // telefonoCliente
            // 
            telefonoCliente.AnimateReadOnly = false;
            telefonoCliente.BackgroundImageLayout = ImageLayout.None;
            telefonoCliente.CharacterCasing = CharacterCasing.Normal;
            telefonoCliente.Depth = 0;
            telefonoCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            telefonoCliente.HideSelection = true;
            telefonoCliente.Hint = "Teléfono";
            telefonoCliente.LeadingIcon = null;
            telefonoCliente.Location = new Point(406, 100);
            telefonoCliente.MaxLength = 32767;
            telefonoCliente.MouseState = MaterialSkin.MouseState.OUT;
            telefonoCliente.Name = "telefonoCliente";
            telefonoCliente.PasswordChar = '\0';
            telefonoCliente.PrefixSuffixText = null;
            telefonoCliente.ReadOnly = false;
            telefonoCliente.RightToLeft = RightToLeft.No;
            telefonoCliente.SelectedText = "";
            telefonoCliente.SelectionLength = 0;
            telefonoCliente.SelectionStart = 0;
            telefonoCliente.ShortcutsEnabled = true;
            telefonoCliente.Size = new Size(318, 48);
            telefonoCliente.TabIndex = 9;
            telefonoCliente.TabStop = false;
            telefonoCliente.TextAlign = HorizontalAlignment.Left;
            telefonoCliente.TrailingIcon = null;
            telefonoCliente.UseSystemPasswordChar = false;
            telefonoCliente.TextChanged += telefonoCliente_TextChanged;
            // 
            // nombreCliente
            // 
            nombreCliente.AnimateReadOnly = false;
            nombreCliente.BackgroundImageLayout = ImageLayout.None;
            nombreCliente.CharacterCasing = CharacterCasing.Normal;
            nombreCliente.Depth = 0;
            nombreCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nombreCliente.HideSelection = true;
            nombreCliente.Hint = "Nombre";
            nombreCliente.LeadingIcon = null;
            nombreCliente.Location = new Point(51, 100);
            nombreCliente.MaxLength = 32767;
            nombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            nombreCliente.Name = "nombreCliente";
            nombreCliente.PasswordChar = '\0';
            nombreCliente.PrefixSuffixText = null;
            nombreCliente.ReadOnly = false;
            nombreCliente.RightToLeft = RightToLeft.No;
            nombreCliente.SelectedText = "";
            nombreCliente.SelectionLength = 0;
            nombreCliente.SelectionStart = 0;
            nombreCliente.ShortcutsEnabled = true;
            nombreCliente.Size = new Size(318, 48);
            nombreCliente.TabIndex = 8;
            nombreCliente.TabStop = false;
            nombreCliente.TextAlign = HorizontalAlignment.Left;
            nombreCliente.TrailingIcon = null;
            nombreCliente.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20F);
            label1.Location = new Point(253, 34);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 7;
            label1.Text = "Datos del Cliente";
            // 
            // AñadirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 298);
            Controls.Add(cancelarButton);
            Controls.Add(finalizarButton);
            Controls.Add(cedulaCliente);
            Controls.Add(correoCliente);
            Controls.Add(telefonoCliente);
            Controls.Add(nombreCliente);
            Controls.Add(label1);
            Name = "AñadirCliente";
            Text = "AñadirCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton cancelarButton;
        private MaterialSkin.Controls.MaterialButton finalizarButton;
        private MaterialSkin.Controls.MaterialTextBox2 cedulaCliente;
        private MaterialSkin.Controls.MaterialTextBox2 correoCliente;
        private MaterialSkin.Controls.MaterialTextBox2 telefonoCliente;
        private MaterialSkin.Controls.MaterialTextBox2 nombreCliente;
        private Label label1;
    }
}