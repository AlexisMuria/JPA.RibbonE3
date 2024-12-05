namespace JPA.RibbonE3
{
    partial class TaskPaneControl
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
            this.Btn_configuración = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_PáginaInicial = new RJCodeAdvance.RJControls.RJTextBox();
            this.Btn_PáginaFinal = new RJCodeAdvance.RJControls.RJTextBox();
            this.Btn_NúmeroCopias = new RJCodeAdvance.RJControls.RJTextBox();
            this.Checkbox_CopiasAutorizadas = new MaterialSkin.Controls.MaterialCheckbox();
            this.Checkbox_Pdf = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Btn_Imprimir = new RJCodeAdvance.RJControls.RJButton();
            this.Btn_Preliminar = new RJCodeAdvance.RJControls.RJButton();
            this.Btn_Propiedades = new RJCodeAdvance.RJControls.RJButton();
            this.CB_Bandejas = new RJCodeAdvance.RJControls.RJComboBox();
            this.CB_Impresoras = new RJCodeAdvance.RJControls.RJComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_configuración
            // 
            this.Btn_configuración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_configuración.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Btn_configuración.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.Btn_configuración.IconColor = System.Drawing.Color.DimGray;
            this.Btn_configuración.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_configuración.IconSize = 35;
            this.Btn_configuración.Location = new System.Drawing.Point(345, 2);
            this.Btn_configuración.Name = "Btn_configuración";
            this.Btn_configuración.Size = new System.Drawing.Size(43, 40);
            this.Btn_configuración.TabIndex = 21;
            this.Btn_configuración.UseVisualStyleBackColor = true;
            this.Btn_configuración.Click += new System.EventHandler(this.Btn_configuración_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_PáginaInicial);
            this.groupBox1.Controls.Add(this.Btn_PáginaFinal);
            this.groupBox1.Controls.Add(this.Btn_NúmeroCopias);
            this.groupBox1.Controls.Add(this.Checkbox_CopiasAutorizadas);
            this.groupBox1.Controls.Add(this.Checkbox_Pdf);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(5, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 184);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Impresión";
            // 
            // Btn_PáginaInicial
            // 
            this.Btn_PáginaInicial.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_PáginaInicial.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_PáginaInicial.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.Btn_PáginaInicial.BorderRadius = 0;
            this.Btn_PáginaInicial.BorderSize = 2;
            this.Btn_PáginaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PáginaInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_PáginaInicial.Location = new System.Drawing.Point(7, 54);
            this.Btn_PáginaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PáginaInicial.Multiline = false;
            this.Btn_PáginaInicial.Name = "Btn_PáginaInicial";
            this.Btn_PáginaInicial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Btn_PáginaInicial.PasswordChar = false;
            this.Btn_PáginaInicial.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Btn_PáginaInicial.PlaceholderText = "";
            this.Btn_PáginaInicial.Size = new System.Drawing.Size(91, 31);
            this.Btn_PáginaInicial.TabIndex = 16;
            this.Btn_PáginaInicial.Texts = "";
            this.Btn_PáginaInicial.UnderlinedStyle = false;
            // 
            // Btn_PáginaFinal
            // 
            this.Btn_PáginaFinal.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_PáginaFinal.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_PáginaFinal.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.Btn_PáginaFinal.BorderRadius = 0;
            this.Btn_PáginaFinal.BorderSize = 2;
            this.Btn_PáginaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PáginaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_PáginaFinal.Location = new System.Drawing.Point(131, 54);
            this.Btn_PáginaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PáginaFinal.Multiline = false;
            this.Btn_PáginaFinal.Name = "Btn_PáginaFinal";
            this.Btn_PáginaFinal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Btn_PáginaFinal.PasswordChar = false;
            this.Btn_PáginaFinal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Btn_PáginaFinal.PlaceholderText = "";
            this.Btn_PáginaFinal.Size = new System.Drawing.Size(91, 31);
            this.Btn_PáginaFinal.TabIndex = 15;
            this.Btn_PáginaFinal.Texts = "";
            this.Btn_PáginaFinal.UnderlinedStyle = false;
            // 
            // Btn_NúmeroCopias
            // 
            this.Btn_NúmeroCopias.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_NúmeroCopias.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_NúmeroCopias.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.Btn_NúmeroCopias.BorderRadius = 0;
            this.Btn_NúmeroCopias.BorderSize = 2;
            this.Btn_NúmeroCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NúmeroCopias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_NúmeroCopias.Location = new System.Drawing.Point(244, 54);
            this.Btn_NúmeroCopias.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_NúmeroCopias.Multiline = false;
            this.Btn_NúmeroCopias.Name = "Btn_NúmeroCopias";
            this.Btn_NúmeroCopias.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Btn_NúmeroCopias.PasswordChar = false;
            this.Btn_NúmeroCopias.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Btn_NúmeroCopias.PlaceholderText = "";
            this.Btn_NúmeroCopias.Size = new System.Drawing.Size(91, 31);
            this.Btn_NúmeroCopias.TabIndex = 14;
            this.Btn_NúmeroCopias.Texts = "";
            this.Btn_NúmeroCopias.UnderlinedStyle = false;
            // 
            // Checkbox_CopiasAutorizadas
            // 
            this.Checkbox_CopiasAutorizadas.AutoSize = true;
            this.Checkbox_CopiasAutorizadas.Depth = 0;
            this.Checkbox_CopiasAutorizadas.Location = new System.Drawing.Point(7, 126);
            this.Checkbox_CopiasAutorizadas.Margin = new System.Windows.Forms.Padding(0);
            this.Checkbox_CopiasAutorizadas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Checkbox_CopiasAutorizadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.Checkbox_CopiasAutorizadas.Name = "Checkbox_CopiasAutorizadas";
            this.Checkbox_CopiasAutorizadas.Ripple = true;
            this.Checkbox_CopiasAutorizadas.Size = new System.Drawing.Size(253, 37);
            this.Checkbox_CopiasAutorizadas.TabIndex = 13;
            this.Checkbox_CopiasAutorizadas.Text = "Control de Copias Autorizadas ";
            this.Checkbox_CopiasAutorizadas.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Pdf
            // 
            this.Checkbox_Pdf.AutoSize = true;
            this.Checkbox_Pdf.Depth = 0;
            this.Checkbox_Pdf.Location = new System.Drawing.Point(7, 89);
            this.Checkbox_Pdf.Margin = new System.Windows.Forms.Padding(0);
            this.Checkbox_Pdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Checkbox_Pdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.Checkbox_Pdf.Name = "Checkbox_Pdf";
            this.Checkbox_Pdf.Ripple = true;
            this.Checkbox_Pdf.Size = new System.Drawing.Size(263, 37);
            this.Checkbox_Pdf.TabIndex = 12;
            this.Checkbox_Pdf.Text = "Crear PDF despúes de impresión";
            this.Checkbox_Pdf.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.Yellow;
            this.materialLabel5.Location = new System.Drawing.Point(241, 30);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(114, 20);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Número Copias:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.Yellow;
            this.materialLabel3.Location = new System.Drawing.Point(6, 30);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(101, 20);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Página inicial:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.materialLabel4.Location = new System.Drawing.Point(128, 30);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(94, 20);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Página Final:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.materialLabel2.Location = new System.Drawing.Point(3, 91);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 20);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Bandejas:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.materialLabel1.Location = new System.Drawing.Point(3, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 20);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Impresoras:";
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Imprimir.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Imprimir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Imprimir.BorderRadius = 0;
            this.Btn_Imprimir.BorderSize = 0;
            this.Btn_Imprimir.FlatAppearance.BorderSize = 0;
            this.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Imprimir.ForeColor = System.Drawing.Color.White;
            this.Btn_Imprimir.Location = new System.Drawing.Point(266, 378);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(122, 34);
            this.Btn_Imprimir.TabIndex = 17;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.TextColor = System.Drawing.Color.White;
            this.Btn_Imprimir.UseVisualStyleBackColor = false;
            // 
            // Btn_Preliminar
            // 
            this.Btn_Preliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Preliminar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Preliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Preliminar.BorderRadius = 0;
            this.Btn_Preliminar.BorderSize = 0;
            this.Btn_Preliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Preliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Preliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Preliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Preliminar.Location = new System.Drawing.Point(136, 378);
            this.Btn_Preliminar.Name = "Btn_Preliminar";
            this.Btn_Preliminar.Size = new System.Drawing.Size(122, 34);
            this.Btn_Preliminar.TabIndex = 16;
            this.Btn_Preliminar.Text = "Vista Preliminar";
            this.Btn_Preliminar.TextColor = System.Drawing.Color.White;
            this.Btn_Preliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Propiedades
            // 
            this.Btn_Propiedades.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Propiedades.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Propiedades.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Propiedades.BorderRadius = 0;
            this.Btn_Propiedades.BorderSize = 0;
            this.Btn_Propiedades.FlatAppearance.BorderSize = 0;
            this.Btn_Propiedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Propiedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Propiedades.ForeColor = System.Drawing.Color.White;
            this.Btn_Propiedades.Location = new System.Drawing.Point(5, 378);
            this.Btn_Propiedades.Name = "Btn_Propiedades";
            this.Btn_Propiedades.Size = new System.Drawing.Size(122, 34);
            this.Btn_Propiedades.TabIndex = 15;
            this.Btn_Propiedades.Text = "Propiedades";
            this.Btn_Propiedades.TextColor = System.Drawing.Color.White;
            this.Btn_Propiedades.UseVisualStyleBackColor = false;
            // 
            // CB_Bandejas
            // 
            this.CB_Bandejas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CB_Bandejas.BorderColor = System.Drawing.Color.DimGray;
            this.CB_Bandejas.BorderSize = 2;
            this.CB_Bandejas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Bandejas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CB_Bandejas.ForeColor = System.Drawing.Color.DimGray;
            this.CB_Bandejas.IconColor = System.Drawing.Color.RoyalBlue;
            this.CB_Bandejas.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Bandejas.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Bandejas.Location = new System.Drawing.Point(5, 114);
            this.CB_Bandejas.MinimumSize = new System.Drawing.Size(200, 30);
            this.CB_Bandejas.Name = "CB_Bandejas";
            this.CB_Bandejas.Padding = new System.Windows.Forms.Padding(2);
            this.CB_Bandejas.Size = new System.Drawing.Size(383, 30);
            this.CB_Bandejas.TabIndex = 14;
            this.CB_Bandejas.Texts = "";
            // 
            // CB_Impresoras
            // 
            this.CB_Impresoras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CB_Impresoras.BorderColor = System.Drawing.Color.DimGray;
            this.CB_Impresoras.BorderSize = 2;
            this.CB_Impresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CB_Impresoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CB_Impresoras.ForeColor = System.Drawing.Color.DimGray;
            this.CB_Impresoras.IconColor = System.Drawing.Color.RoyalBlue;
            this.CB_Impresoras.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CB_Impresoras.ListTextColor = System.Drawing.Color.DimGray;
            this.CB_Impresoras.Location = new System.Drawing.Point(6, 48);
            this.CB_Impresoras.MinimumSize = new System.Drawing.Size(200, 30);
            this.CB_Impresoras.Name = "CB_Impresoras";
            this.CB_Impresoras.Padding = new System.Windows.Forms.Padding(2);
            this.CB_Impresoras.Size = new System.Drawing.Size(382, 30);
            this.CB_Impresoras.TabIndex = 13;
            this.CB_Impresoras.Texts = "";
            // 
            // TaskPaneControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.Btn_configuración);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Preliminar);
            this.Controls.Add(this.Btn_Propiedades);
            this.Controls.Add(this.CB_Bandejas);
            this.Controls.Add(this.CB_Impresoras);
            this.Name = "TaskPaneControl";
            this.Size = new System.Drawing.Size(395, 421);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton Btn_configuración;
        private System.Windows.Forms.GroupBox groupBox1;
        private RJCodeAdvance.RJControls.RJTextBox Btn_PáginaInicial;
        private RJCodeAdvance.RJControls.RJTextBox Btn_PáginaFinal;
        private RJCodeAdvance.RJControls.RJTextBox Btn_NúmeroCopias;
        private MaterialSkin.Controls.MaterialCheckbox Checkbox_CopiasAutorizadas;
        private MaterialSkin.Controls.MaterialCheckbox Checkbox_Pdf;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private RJCodeAdvance.RJControls.RJButton Btn_Imprimir;
        private RJCodeAdvance.RJControls.RJButton Btn_Preliminar;
        private RJCodeAdvance.RJControls.RJButton Btn_Propiedades;
        private RJCodeAdvance.RJControls.RJComboBox CB_Bandejas;
        private RJCodeAdvance.RJControls.RJComboBox CB_Impresoras;
    }
}