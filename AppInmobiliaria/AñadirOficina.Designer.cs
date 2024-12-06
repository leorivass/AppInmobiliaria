namespace Presentation
{
    partial class AñadirOficina
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
            telefonoOficina = new MaterialSkin.Controls.MaterialTextBox2();
            ubicacionOficina = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            cancelarButton = new MaterialSkin.Controls.MaterialButton();
            finalizarButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // telefonoOficina
            // 
            telefonoOficina.AnimateReadOnly = false;
            telefonoOficina.BackgroundImageLayout = ImageLayout.None;
            telefonoOficina.CharacterCasing = CharacterCasing.Normal;
            telefonoOficina.Depth = 0;
            telefonoOficina.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            telefonoOficina.HideSelection = true;
            telefonoOficina.Hint = "Teléfono";
            telefonoOficina.LeadingIcon = null;
            telefonoOficina.Location = new Point(395, 101);
            telefonoOficina.MaxLength = 32767;
            telefonoOficina.MouseState = MaterialSkin.MouseState.OUT;
            telefonoOficina.Name = "telefonoOficina";
            telefonoOficina.PasswordChar = '\0';
            telefonoOficina.PrefixSuffixText = null;
            telefonoOficina.ReadOnly = false;
            telefonoOficina.RightToLeft = RightToLeft.No;
            telefonoOficina.SelectedText = "";
            telefonoOficina.SelectionLength = 0;
            telefonoOficina.SelectionStart = 0;
            telefonoOficina.ShortcutsEnabled = true;
            telefonoOficina.Size = new Size(318, 48);
            telefonoOficina.TabIndex = 6;
            telefonoOficina.TabStop = false;
            telefonoOficina.TextAlign = HorizontalAlignment.Left;
            telefonoOficina.TrailingIcon = null;
            telefonoOficina.UseSystemPasswordChar = false;
            telefonoOficina.TextChanged += telefonoOficina_TextChanged;
            // 
            // ubicacionOficina
            // 
            ubicacionOficina.AnimateReadOnly = false;
            ubicacionOficina.BackgroundImageLayout = ImageLayout.None;
            ubicacionOficina.CharacterCasing = CharacterCasing.Normal;
            ubicacionOficina.Depth = 0;
            ubicacionOficina.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ubicacionOficina.HideSelection = true;
            ubicacionOficina.Hint = "Ubicación";
            ubicacionOficina.LeadingIcon = null;
            ubicacionOficina.Location = new Point(29, 101);
            ubicacionOficina.MaxLength = 32767;
            ubicacionOficina.MouseState = MaterialSkin.MouseState.OUT;
            ubicacionOficina.Name = "ubicacionOficina";
            ubicacionOficina.PasswordChar = '\0';
            ubicacionOficina.PrefixSuffixText = null;
            ubicacionOficina.ReadOnly = false;
            ubicacionOficina.RightToLeft = RightToLeft.No;
            ubicacionOficina.SelectedText = "";
            ubicacionOficina.SelectionLength = 0;
            ubicacionOficina.SelectionStart = 0;
            ubicacionOficina.ShortcutsEnabled = true;
            ubicacionOficina.Size = new Size(318, 48);
            ubicacionOficina.TabIndex = 5;
            ubicacionOficina.TabStop = false;
            ubicacionOficina.TextAlign = HorizontalAlignment.Left;
            ubicacionOficina.TrailingIcon = null;
            ubicacionOficina.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20F);
            label1.Location = new Point(255, 34);
            label1.Name = "label1";
            label1.Size = new Size(242, 37);
            label1.TabIndex = 9;
            label1.Text = "Datos de la oficina";
            // 
            // cancelarButton
            // 
            cancelarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelarButton.Cursor = Cursors.Hand;
            cancelarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelarButton.Depth = 0;
            cancelarButton.HighEmphasis = true;
            cancelarButton.Icon = null;
            cancelarButton.Location = new Point(617, 176);
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
            finalizarButton.Location = new Point(504, 176);
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
            finalizarButton.Click += finalizarButton_Click;
            // 
            // AñadirOficina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 225);
            Controls.Add(cancelarButton);
            Controls.Add(finalizarButton);
            Controls.Add(label1);
            Controls.Add(telefonoOficina);
            Controls.Add(ubicacionOficina);
            Name = "AñadirOficina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Oficina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 telefonoOficina;
        private MaterialSkin.Controls.MaterialTextBox2 ubicacionOficina;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton cancelarButton;
        private MaterialSkin.Controls.MaterialButton finalizarButton;
    }
}