namespace Presentation
{
    partial class adminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            panel16 = new Panel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            eliminarPropietarioButton = new MaterialSkin.Controls.MaterialButton();
            propietariosGridView = new DataGridView();
            añadirPropietarioButton = new MaterialSkin.Controls.MaterialButton();
            panel11 = new Panel();
            pictureBox8 = new PictureBox();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            panel13 = new Panel();
            tabPage2 = new TabPage();
            inmueblesLayoutPanel = new FlowLayoutPanel();
            panel4 = new Panel();
            panel3 = new Panel();
            refreshButton = new PictureBox();
            añadirInmuebleButton = new PictureBox();
            oficinaComboBox = new ComboBox();
            label43 = new Label();
            filtroComboBox = new ComboBox();
            label49 = new Label();
            materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            tabPage3 = new TabPage();
            panel15 = new Panel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            eliminarOficinaButton = new MaterialSkin.Controls.MaterialButton();
            oficinasGridView = new DataGridView();
            añadirOficinaButton = new MaterialSkin.Controls.MaterialButton();
            panel14 = new Panel();
            panel12 = new Panel();
            pictureBox9 = new PictureBox();
            materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)propietariosGridView).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)refreshButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)añadirInmuebleButton).BeginInit();
            tabPage3.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)oficinasGridView).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(0, 0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1032, 732);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel16);
            tabPage1.Controls.Add(panel11);
            tabPage1.Controls.Add(panel13);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1024, 704);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Propietarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            panel16.Controls.Add(materialButton2);
            panel16.Controls.Add(eliminarPropietarioButton);
            panel16.Controls.Add(propietariosGridView);
            panel16.Controls.Add(añadirPropietarioButton);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(0, 100);
            panel16.Name = "panel16";
            panel16.Size = new Size(1024, 528);
            panel16.TabIndex = 6;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Cursor = Cursors.Hand;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(766, 488);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(71, 36);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "Editar";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // eliminarPropietarioButton
            // 
            eliminarPropietarioButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            eliminarPropietarioButton.Cursor = Cursors.Hand;
            eliminarPropietarioButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            eliminarPropietarioButton.Depth = 0;
            eliminarPropietarioButton.HighEmphasis = true;
            eliminarPropietarioButton.Icon = null;
            eliminarPropietarioButton.Location = new Point(927, 488);
            eliminarPropietarioButton.Margin = new Padding(4, 6, 4, 6);
            eliminarPropietarioButton.MouseState = MaterialSkin.MouseState.HOVER;
            eliminarPropietarioButton.Name = "eliminarPropietarioButton";
            eliminarPropietarioButton.NoAccentTextColor = Color.Empty;
            eliminarPropietarioButton.Size = new Size(88, 36);
            eliminarPropietarioButton.TabIndex = 1;
            eliminarPropietarioButton.Text = "Eliminar";
            eliminarPropietarioButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            eliminarPropietarioButton.UseAccentColor = false;
            eliminarPropietarioButton.UseVisualStyleBackColor = true;
            eliminarPropietarioButton.Click += eliminarPropietarioButton_Click;
            // 
            // propietariosGridView
            // 
            propietariosGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            propietariosGridView.Location = new Point(8, 6);
            propietariosGridView.Name = "propietariosGridView";
            propietariosGridView.Size = new Size(1008, 473);
            propietariosGridView.TabIndex = 0;
            // 
            // añadirPropietarioButton
            // 
            añadirPropietarioButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            añadirPropietarioButton.Cursor = Cursors.Hand;
            añadirPropietarioButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            añadirPropietarioButton.Depth = 0;
            añadirPropietarioButton.HighEmphasis = true;
            añadirPropietarioButton.Icon = null;
            añadirPropietarioButton.Location = new Point(845, 488);
            añadirPropietarioButton.Margin = new Padding(4, 6, 4, 6);
            añadirPropietarioButton.MouseState = MaterialSkin.MouseState.HOVER;
            añadirPropietarioButton.Name = "añadirPropietarioButton";
            añadirPropietarioButton.NoAccentTextColor = Color.Empty;
            añadirPropietarioButton.Size = new Size(74, 36);
            añadirPropietarioButton.TabIndex = 2;
            añadirPropietarioButton.Text = "Añadir";
            añadirPropietarioButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            añadirPropietarioButton.UseAccentColor = false;
            añadirPropietarioButton.UseVisualStyleBackColor = true;
            añadirPropietarioButton.Click += añadirPropietarioButton_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.RoyalBlue;
            panel11.Controls.Add(pictureBox8);
            panel11.Controls.Add(materialTabSelector1);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1024, 100);
            panel11.TabIndex = 4;
            // 
            // pictureBox8
            // 
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(79, 52);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(43, 40);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(240, 52);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(543, 48);
            materialTabSelector1.TabIndex = 1;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // panel13
            // 
            panel13.BackColor = Color.RoyalBlue;
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(0, 628);
            panel13.Name = "panel13";
            panel13.Size = new Size(1024, 76);
            panel13.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(inmueblesLayoutPanel);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1024, 704);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inmuebles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // inmueblesLayoutPanel
            // 
            inmueblesLayoutPanel.AutoScroll = true;
            inmueblesLayoutPanel.Dock = DockStyle.Fill;
            inmueblesLayoutPanel.Location = new Point(0, 100);
            inmueblesLayoutPanel.Name = "inmueblesLayoutPanel";
            inmueblesLayoutPanel.Size = new Size(1024, 504);
            inmueblesLayoutPanel.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 604);
            panel4.Name = "panel4";
            panel4.Size = new Size(1024, 100);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(añadirInmuebleButton);
            panel3.Controls.Add(oficinaComboBox);
            panel3.Controls.Add(label43);
            panel3.Controls.Add(filtroComboBox);
            panel3.Controls.Add(label49);
            panel3.Controls.Add(materialTabSelector3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1024, 100);
            panel3.TabIndex = 1;
            // 
            // refreshButton
            // 
            refreshButton.Cursor = Cursors.Hand;
            refreshButton.Image = (Image)resources.GetObject("refreshButton.Image");
            refreshButton.Location = new Point(46, 57);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(43, 40);
            refreshButton.SizeMode = PictureBoxSizeMode.StretchImage;
            refreshButton.TabIndex = 9;
            refreshButton.TabStop = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // añadirInmuebleButton
            // 
            añadirInmuebleButton.Cursor = Cursors.Hand;
            añadirInmuebleButton.Image = (Image)resources.GetObject("añadirInmuebleButton.Image");
            añadirInmuebleButton.Location = new Point(146, 57);
            añadirInmuebleButton.Name = "añadirInmuebleButton";
            añadirInmuebleButton.Size = new Size(43, 40);
            añadirInmuebleButton.SizeMode = PictureBoxSizeMode.StretchImage;
            añadirInmuebleButton.TabIndex = 5;
            añadirInmuebleButton.TabStop = false;
            añadirInmuebleButton.Click += añadirInmuebleButton_Click;
            // 
            // oficinaComboBox
            // 
            oficinaComboBox.Cursor = Cursors.Hand;
            oficinaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            oficinaComboBox.DropDownWidth = 202;
            oficinaComboBox.FlatStyle = FlatStyle.Flat;
            oficinaComboBox.Font = new Font("Microsoft Sans Serif", 9F);
            oficinaComboBox.FormattingEnabled = true;
            oficinaComboBox.Items.AddRange(new object[] { "Local", "Casa", "Piso", "Villa" });
            oficinaComboBox.Location = new Point(804, 71);
            oficinaComboBox.Name = "oficinaComboBox";
            oficinaComboBox.Size = new Size(88, 23);
            oficinaComboBox.TabIndex = 8;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label43.Location = new Point(815, 51);
            label43.Name = "label43";
            label43.Size = new Size(61, 18);
            label43.TabIndex = 7;
            label43.Text = "Oficina";
            // 
            // filtroComboBox
            // 
            filtroComboBox.Cursor = Cursors.Hand;
            filtroComboBox.FlatStyle = FlatStyle.Flat;
            filtroComboBox.Font = new Font("Microsoft Sans Serif", 9F);
            filtroComboBox.FormattingEnabled = true;
            filtroComboBox.Items.AddRange(new object[] { "Casa", "Villa", "Piso", "Local" });
            filtroComboBox.Location = new Point(916, 71);
            filtroComboBox.Name = "filtroComboBox";
            filtroComboBox.Size = new Size(88, 23);
            filtroComboBox.TabIndex = 2;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label49.Location = new Point(916, 51);
            label49.Name = "label49";
            label49.Size = new Size(82, 18);
            label49.TabIndex = 6;
            label49.Text = "Filtrar por";
            // 
            // materialTabSelector3
            // 
            materialTabSelector3.BaseTabControl = materialTabControl1;
            materialTabSelector3.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector3.Depth = 0;
            materialTabSelector3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector3.Location = new Point(240, 52);
            materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector3.Name = "materialTabSelector3";
            materialTabSelector3.Size = new Size(543, 48);
            materialTabSelector3.TabIndex = 1;
            materialTabSelector3.Text = "materialTabSelector1";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel15);
            tabPage3.Controls.Add(panel14);
            tabPage3.Controls.Add(panel12);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1024, 704);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Oficinas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            panel15.Controls.Add(materialButton1);
            panel15.Controls.Add(eliminarOficinaButton);
            panel15.Controls.Add(oficinasGridView);
            panel15.Controls.Add(añadirOficinaButton);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(0, 100);
            panel15.Name = "panel15";
            panel15.Size = new Size(1024, 545);
            panel15.TabIndex = 7;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(763, 488);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(71, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Editar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // eliminarOficinaButton
            // 
            eliminarOficinaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            eliminarOficinaButton.Cursor = Cursors.Hand;
            eliminarOficinaButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            eliminarOficinaButton.Depth = 0;
            eliminarOficinaButton.HighEmphasis = true;
            eliminarOficinaButton.Icon = null;
            eliminarOficinaButton.Location = new Point(927, 488);
            eliminarOficinaButton.Margin = new Padding(4, 6, 4, 6);
            eliminarOficinaButton.MouseState = MaterialSkin.MouseState.HOVER;
            eliminarOficinaButton.Name = "eliminarOficinaButton";
            eliminarOficinaButton.NoAccentTextColor = Color.Empty;
            eliminarOficinaButton.Size = new Size(88, 36);
            eliminarOficinaButton.TabIndex = 1;
            eliminarOficinaButton.Text = "Eliminar";
            eliminarOficinaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            eliminarOficinaButton.UseAccentColor = false;
            eliminarOficinaButton.UseVisualStyleBackColor = true;
            eliminarOficinaButton.Click += eliminarOficinaButton_Click;
            // 
            // oficinasGridView
            // 
            oficinasGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            oficinasGridView.Location = new Point(8, 6);
            oficinasGridView.Name = "oficinasGridView";
            oficinasGridView.Size = new Size(1008, 473);
            oficinasGridView.TabIndex = 0;
            // 
            // añadirOficinaButton
            // 
            añadirOficinaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            añadirOficinaButton.Cursor = Cursors.Hand;
            añadirOficinaButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            añadirOficinaButton.Depth = 0;
            añadirOficinaButton.HighEmphasis = true;
            añadirOficinaButton.Icon = null;
            añadirOficinaButton.Location = new Point(845, 488);
            añadirOficinaButton.Margin = new Padding(4, 6, 4, 6);
            añadirOficinaButton.MouseState = MaterialSkin.MouseState.HOVER;
            añadirOficinaButton.Name = "añadirOficinaButton";
            añadirOficinaButton.NoAccentTextColor = Color.Empty;
            añadirOficinaButton.Size = new Size(74, 36);
            añadirOficinaButton.TabIndex = 2;
            añadirOficinaButton.Text = "Añadir";
            añadirOficinaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            añadirOficinaButton.UseAccentColor = false;
            añadirOficinaButton.UseVisualStyleBackColor = true;
            añadirOficinaButton.Click += añadirOficinaButton_Click;
            // 
            // panel14
            // 
            panel14.BackColor = Color.RoyalBlue;
            panel14.Dock = DockStyle.Bottom;
            panel14.Location = new Point(0, 645);
            panel14.Name = "panel14";
            panel14.Size = new Size(1024, 59);
            panel14.TabIndex = 4;
            panel14.Paint += panel14_Paint;
            // 
            // panel12
            // 
            panel12.BackColor = Color.RoyalBlue;
            panel12.Controls.Add(pictureBox9);
            panel12.Controls.Add(materialTabSelector2);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(1024, 100);
            panel12.TabIndex = 2;
            // 
            // pictureBox9
            // 
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(79, 52);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 40);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // materialTabSelector2
            // 
            materialTabSelector2.BaseTabControl = materialTabControl1;
            materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector2.Depth = 0;
            materialTabSelector2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector2.Location = new Point(240, 52);
            materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector2.Name = "materialTabSelector2";
            materialTabSelector2.Size = new Size(543, 48);
            materialTabSelector2.TabIndex = 1;
            materialTabSelector2.Text = "materialTabSelector1";
            // 
            // adminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 732);
            Controls.Add(materialTabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "adminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Principal";
            Load += AdminMainPage_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)propietariosGridView).EndInit();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)refreshButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)añadirInmuebleButton).EndInit();
            tabPage3.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)oficinasGridView).EndInit();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel4;
        private Panel panel3;
        private TabPage tabPage3;
        private FlowLayoutPanel inmueblesLayoutPanel;
        private Panel panel13;
        private Panel panel11;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private Panel panel14;
        private Panel panel12;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private ComboBox filtroComboBox;
        private PictureBox añadirInmuebleButton;
        private Panel panel16;
        private MaterialSkin.Controls.MaterialButton añadirPropietarioButton;
        private MaterialSkin.Controls.MaterialButton eliminarPropietarioButton;
        private DataGridView propietariosGridView;
        private Panel panel15;
        private MaterialSkin.Controls.MaterialButton eliminarOficinaButton;
        private DataGridView oficinasGridView;
        private MaterialSkin.Controls.MaterialButton añadirOficinaButton;
        private Label label49;
        private ComboBox oficinaComboBox;
        private Label label43;
        private PictureBox refreshButton;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}