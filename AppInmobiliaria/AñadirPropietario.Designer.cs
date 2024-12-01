namespace Presentation
{
    partial class AñadirPropietario
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
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            cancelarButton = new MaterialSkin.Controls.MaterialButton();
            finalizarButton = new MaterialSkin.Controls.MaterialButton();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            telefonoPropietario = new MaterialSkin.Controls.MaterialTextBox2();
            nombrePropietario = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(cancelarButton);
            materialCard2.Controls.Add(finalizarButton);
            materialCard2.Controls.Add(materialTextBox22);
            materialCard2.Controls.Add(materialTextBox21);
            materialCard2.Controls.Add(telefonoPropietario);
            materialCard2.Controls.Add(nombrePropietario);
            materialCard2.Controls.Add(label1);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.Font = new Font("Segoe UI", 20F);
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(0, 0);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(743, 275);
            materialCard2.TabIndex = 2;
            // 
            // cancelarButton
            // 
            cancelarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelarButton.Depth = 0;
            cancelarButton.HighEmphasis = true;
            cancelarButton.Icon = null;
            cancelarButton.Location = new Point(616, 224);
            cancelarButton.Margin = new Padding(4, 6, 4, 6);
            cancelarButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.NoAccentTextColor = Color.Empty;
            cancelarButton.Size = new Size(96, 36);
            cancelarButton.TabIndex = 6;
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
            finalizarButton.Location = new Point(501, 224);
            finalizarButton.Margin = new Padding(4, 6, 4, 6);
            finalizarButton.MouseState = MaterialSkin.MouseState.HOVER;
            finalizarButton.Name = "finalizarButton";
            finalizarButton.NoAccentTextColor = Color.Empty;
            finalizarButton.Size = new Size(94, 36);
            finalizarButton.TabIndex = 5;
            finalizarButton.Text = "Finalizar";
            finalizarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            finalizarButton.UseAccentColor = false;
            finalizarButton.UseVisualStyleBackColor = true;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.Hint = "Cédula";
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(392, 162);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(318, 48);
            materialTextBox22.TabIndex = 4;
            materialTextBox22.TabStop = false;
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Correo electrónico";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(37, 162);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(318, 48);
            materialTextBox21.TabIndex = 3;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
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
            telefonoPropietario.Location = new Point(392, 95);
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
            nombrePropietario.Location = new Point(37, 95);
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
            label1.Location = new Point(239, 29);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 0;
            label1.Text = "Datos del propietario";
            // 
            // AñadirPropietario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 275);
            Controls.Add(materialCard2);
            Name = "AñadirPropietario";
            Text = "AñadirPropietario";
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 telefonoPropietario;
        private MaterialSkin.Controls.MaterialTextBox2 nombrePropietario;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton cancelarButton;
        private MaterialSkin.Controls.MaterialButton finalizarButton;
    }
}