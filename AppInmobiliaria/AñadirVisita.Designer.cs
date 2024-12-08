namespace Presentation
{
    partial class AñadirVisita
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
            comentarioVisita = new MaterialSkin.Controls.MaterialTextBox2();
            idInmueble = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            clienteComboBox = new MaterialSkin.Controls.MaterialComboBox();
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
            cancelarButton.Location = new Point(622, 225);
            cancelarButton.Margin = new Padding(4, 6, 4, 6);
            cancelarButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelarButton.Name = "cancelarButton";
            cancelarButton.NoAccentTextColor = Color.Empty;
            cancelarButton.Size = new Size(96, 36);
            cancelarButton.TabIndex = 20;
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
            finalizarButton.Location = new Point(509, 225);
            finalizarButton.Margin = new Padding(4, 6, 4, 6);
            finalizarButton.MouseState = MaterialSkin.MouseState.HOVER;
            finalizarButton.Name = "finalizarButton";
            finalizarButton.NoAccentTextColor = Color.Empty;
            finalizarButton.Size = new Size(94, 36);
            finalizarButton.TabIndex = 19;
            finalizarButton.Text = "Finalizar";
            finalizarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            finalizarButton.UseAccentColor = false;
            finalizarButton.UseVisualStyleBackColor = true;
            finalizarButton.Click += finalizarButton_Click;
            // 
            // comentarioVisita
            // 
            comentarioVisita.AnimateReadOnly = false;
            comentarioVisita.BackgroundImageLayout = ImageLayout.None;
            comentarioVisita.CharacterCasing = CharacterCasing.Normal;
            comentarioVisita.Depth = 0;
            comentarioVisita.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            comentarioVisita.HideSelection = true;
            comentarioVisita.Hint = "Comentario";
            comentarioVisita.LeadingIcon = null;
            comentarioVisita.Location = new Point(45, 159);
            comentarioVisita.MaxLength = 32767;
            comentarioVisita.MouseState = MaterialSkin.MouseState.OUT;
            comentarioVisita.Name = "comentarioVisita";
            comentarioVisita.PasswordChar = '\0';
            comentarioVisita.PrefixSuffixText = null;
            comentarioVisita.ReadOnly = false;
            comentarioVisita.RightToLeft = RightToLeft.No;
            comentarioVisita.SelectedText = "";
            comentarioVisita.SelectionLength = 0;
            comentarioVisita.SelectionStart = 0;
            comentarioVisita.ShortcutsEnabled = true;
            comentarioVisita.Size = new Size(673, 48);
            comentarioVisita.TabIndex = 17;
            comentarioVisita.TabStop = false;
            comentarioVisita.TextAlign = HorizontalAlignment.Left;
            comentarioVisita.TrailingIcon = null;
            comentarioVisita.UseSystemPasswordChar = false;
            // 
            // idInmueble
            // 
            idInmueble.AccessibleRole = AccessibleRole.None;
            idInmueble.AnimateReadOnly = false;
            idInmueble.BackgroundImageLayout = ImageLayout.None;
            idInmueble.CharacterCasing = CharacterCasing.Normal;
            idInmueble.Depth = 0;
            idInmueble.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            idInmueble.HideSelection = true;
            idInmueble.Hint = "ID del Inmueble";
            idInmueble.LeadingIcon = null;
            idInmueble.Location = new Point(45, 92);
            idInmueble.MaxLength = 32767;
            idInmueble.MouseState = MaterialSkin.MouseState.OUT;
            idInmueble.Name = "idInmueble";
            idInmueble.PasswordChar = '\0';
            idInmueble.PrefixSuffixText = null;
            idInmueble.ReadOnly = false;
            idInmueble.RightToLeft = RightToLeft.No;
            idInmueble.SelectedText = "";
            idInmueble.SelectionLength = 0;
            idInmueble.SelectionStart = 0;
            idInmueble.ShortcutsEnabled = true;
            idInmueble.Size = new Size(318, 48);
            idInmueble.TabIndex = 15;
            idInmueble.TabStop = false;
            idInmueble.TextAlign = HorizontalAlignment.Left;
            idInmueble.TrailingIcon = null;
            idInmueble.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20F);
            label1.Location = new Point(270, 27);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 14;
            label1.Text = "Datos de la visita";
            // 
            // clienteComboBox
            // 
            clienteComboBox.AutoResize = false;
            clienteComboBox.BackColor = Color.FromArgb(255, 255, 255);
            clienteComboBox.Depth = 0;
            clienteComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            clienteComboBox.DropDownHeight = 174;
            clienteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clienteComboBox.DropDownWidth = 121;
            clienteComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            clienteComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            clienteComboBox.FormattingEnabled = true;
            clienteComboBox.Hint = "Seleccione el cliente";
            clienteComboBox.IntegralHeight = false;
            clienteComboBox.ItemHeight = 43;
            clienteComboBox.Location = new Point(400, 92);
            clienteComboBox.MaxDropDownItems = 4;
            clienteComboBox.MouseState = MaterialSkin.MouseState.OUT;
            clienteComboBox.Name = "clienteComboBox";
            clienteComboBox.Size = new Size(318, 49);
            clienteComboBox.StartIndex = 0;
            clienteComboBox.TabIndex = 21;
            // 
            // AñadirVisita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 281);
            Controls.Add(clienteComboBox);
            Controls.Add(cancelarButton);
            Controls.Add(finalizarButton);
            Controls.Add(comentarioVisita);
            Controls.Add(idInmueble);
            Controls.Add(label1);
            Name = "AñadirVisita";
            Text = "AñadirVisita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton cancelarButton;
        private MaterialSkin.Controls.MaterialButton finalizarButton;
        private MaterialSkin.Controls.MaterialTextBox2 comentarioVisita;
        private MaterialSkin.Controls.MaterialTextBox2 idInmueble;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox clienteComboBox;
    }
}