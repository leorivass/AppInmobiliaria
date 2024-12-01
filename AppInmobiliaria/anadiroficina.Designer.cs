namespace Presentation
{
    partial class anadiroficina
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
            telefonoPropietario = new MaterialSkin.Controls.MaterialTextBox2();
            nombrePropietario = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            cancelarButton = new MaterialSkin.Controls.MaterialButton();
            finalizarButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
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
            telefonoPropietario.Location = new Point(408, 101);
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
            telefonoPropietario.TabIndex = 6;
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
            nombrePropietario.Location = new Point(53, 101);
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
            nombrePropietario.TabIndex = 5;
            nombrePropietario.TabStop = false;
            nombrePropietario.TextAlign = HorizontalAlignment.Left;
            nombrePropietario.TrailingIcon = null;
            nombrePropietario.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20F);
            label1.Location = new Point(251, 41);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 9;
            label1.Text = "Informacion Oficina";
            label1.Click += label1_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelarButton.Depth = 0;
            cancelarButton.HighEmphasis = true;
            cancelarButton.Icon = null;
            cancelarButton.Location = new Point(630, 176);
            cancelarButton.Margin = new Padding(4, 6, 4, 6);
            cancelarButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.NoAccentTextColor = Color.Empty;
            cancelarButton.Size = new Size(96, 36);
            cancelarButton.TabIndex = 11;
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
            finalizarButton.Location = new Point(515, 176);
            finalizarButton.Margin = new Padding(4, 6, 4, 6);
            finalizarButton.MouseState = MaterialSkin.MouseState.HOVER;
            finalizarButton.Name = "finalizarButton";
            finalizarButton.NoAccentTextColor = Color.Empty;
            finalizarButton.Size = new Size(94, 36);
            finalizarButton.TabIndex = 10;
            finalizarButton.Text = "Finalizar";
            finalizarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            finalizarButton.UseAccentColor = false;
            finalizarButton.UseVisualStyleBackColor = true;
            // 
            // anadiroficina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 225);
            Controls.Add(cancelarButton);
            Controls.Add(finalizarButton);
            Controls.Add(label1);
            Controls.Add(telefonoPropietario);
            Controls.Add(nombrePropietario);
            Name = "anadiroficina";
            Text = "Añadir Oficina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 telefonoPropietario;
        private MaterialSkin.Controls.MaterialTextBox2 nombrePropietario;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton cancelarButton;
        private MaterialSkin.Controls.MaterialButton finalizarButton;
    }
}