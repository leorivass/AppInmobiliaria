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
            cedulaPropietario = new MaterialSkin.Controls.MaterialTextBox2();
            correoPropietario = new MaterialSkin.Controls.MaterialTextBox2();
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
            materialCard2.Controls.Add(cedulaPropietario);
            materialCard2.Controls.Add(correoPropietario);
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
            finalizarButton.Click += finalizarButton_Click;
            // 
            // cedulaPropietario
            // 
            cedulaPropietario.AnimateReadOnly = false;
            cedulaPropietario.BackgroundImageLayout = ImageLayout.None;
            cedulaPropietario.CharacterCasing = CharacterCasing.Normal;
            cedulaPropietario.Depth = 0;
            cedulaPropietario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cedulaPropietario.HideSelection = true;
            cedulaPropietario.Hint = "Cédula";
            cedulaPropietario.LeadingIcon = null;
            cedulaPropietario.Location = new Point(392, 162);
            cedulaPropietario.MaxLength = 32767;
            cedulaPropietario.MouseState = MaterialSkin.MouseState.OUT;
            cedulaPropietario.Name = "cedulaPropietario";
            cedulaPropietario.PasswordChar = '\0';
            cedulaPropietario.PrefixSuffixText = null;
            cedulaPropietario.ReadOnly = false;
            cedulaPropietario.RightToLeft = RightToLeft.No;
            cedulaPropietario.SelectedText = "";
            cedulaPropietario.SelectionLength = 0;
            cedulaPropietario.SelectionStart = 0;
            cedulaPropietario.ShortcutsEnabled = true;
            cedulaPropietario.Size = new Size(318, 48);
            cedulaPropietario.TabIndex = 4;
            cedulaPropietario.TabStop = false;
            cedulaPropietario.TextAlign = HorizontalAlignment.Left;
            cedulaPropietario.TrailingIcon = null;
            cedulaPropietario.UseSystemPasswordChar = false;
            cedulaPropietario.TextChanged += cedulaPropietario_TextChanged;
            // 
            // correoPropietario
            // 
            correoPropietario.AnimateReadOnly = false;
            correoPropietario.BackgroundImageLayout = ImageLayout.None;
            correoPropietario.CharacterCasing = CharacterCasing.Normal;
            correoPropietario.Depth = 0;
            correoPropietario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            correoPropietario.HideSelection = true;
            correoPropietario.Hint = "Correo electrónico";
            correoPropietario.LeadingIcon = null;
            correoPropietario.Location = new Point(37, 162);
            correoPropietario.MaxLength = 32767;
            correoPropietario.MouseState = MaterialSkin.MouseState.OUT;
            correoPropietario.Name = "correoPropietario";
            correoPropietario.PasswordChar = '\0';
            correoPropietario.PrefixSuffixText = null;
            correoPropietario.ReadOnly = false;
            correoPropietario.RightToLeft = RightToLeft.No;
            correoPropietario.SelectedText = "";
            correoPropietario.SelectionLength = 0;
            correoPropietario.SelectionStart = 0;
            correoPropietario.ShortcutsEnabled = true;
            correoPropietario.Size = new Size(318, 48);
            correoPropietario.TabIndex = 3;
            correoPropietario.TabStop = false;
            correoPropietario.TextAlign = HorizontalAlignment.Left;
            correoPropietario.TrailingIcon = null;
            correoPropietario.UseSystemPasswordChar = false;
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
            telefonoPropietario.TextChanged += telefonoPropietario_TextChanged;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Propietario";
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 telefonoPropietario;
        private MaterialSkin.Controls.MaterialTextBox2 nombrePropietario;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton cancelarButton;
        private MaterialSkin.Controls.MaterialButton finalizarButton;
        private MaterialSkin.Controls.MaterialTextBox2 cedulaPropietario;
        private MaterialSkin.Controls.MaterialTextBox2 correoPropietario;
    }
}