namespace FormRegistro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.cbJavaScript = new System.Windows.Forms.CheckBox();
            this.cbCMasMas = new System.Windows.Forms.CheckBox();
            this.cbCSharp = new System.Windows.Forms.CheckBox();
            this.lbPaises = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.lblDireccion);
            this.gbDetalles.Controls.Add(this.lblEdad);
            this.gbDetalles.Controls.Add(this.nudEdad);
            this.gbDetalles.Controls.Add(this.tbDireccion);
            this.gbDetalles.Controls.Add(this.lblNombre);
            this.gbDetalles.Controls.Add(this.tbNombre);
            this.gbDetalles.Location = new System.Drawing.Point(12, 12);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(242, 163);
            this.gbDetalles.TabIndex = 0;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles del usuario";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 54);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 82);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(116, 80);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 23);
            this.nudEdad.TabIndex = 1;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(116, 51);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 23);
            this.tbDireccion.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(116, 22);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 23);
            this.tbNombre.TabIndex = 1;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBinario);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(309, 12);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(139, 116);
            this.gbGenero.TabIndex = 4;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(27, 75);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            this.rbNoBinario.CheckedChanged += new System.EventHandler(this.rbNoBinario_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(27, 46);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(27, 21);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.cbJavaScript);
            this.gbCursos.Controls.Add(this.cbCMasMas);
            this.gbCursos.Controls.Add(this.cbCSharp);
            this.gbCursos.Location = new System.Drawing.Point(309, 138);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(139, 116);
            this.gbCursos.TabIndex = 5;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // cbJavaScript
            // 
            this.cbJavaScript.AutoSize = true;
            this.cbJavaScript.Location = new System.Drawing.Point(17, 74);
            this.cbJavaScript.Name = "cbJavaScript";
            this.cbJavaScript.Size = new System.Drawing.Size(78, 19);
            this.cbJavaScript.TabIndex = 2;
            this.cbJavaScript.Text = "JavaScript";
            this.cbJavaScript.UseVisualStyleBackColor = true;
            this.cbJavaScript.CheckedChanged += new System.EventHandler(this.cbJavaScript_CheckedChanged);
            // 
            // cbCMasMas
            // 
            this.cbCMasMas.AutoSize = true;
            this.cbCMasMas.Location = new System.Drawing.Point(17, 49);
            this.cbCMasMas.Name = "cbCMasMas";
            this.cbCMasMas.Size = new System.Drawing.Size(50, 19);
            this.cbCMasMas.TabIndex = 1;
            this.cbCMasMas.Text = "C++";
            this.cbCMasMas.UseVisualStyleBackColor = true;
            this.cbCMasMas.CheckedChanged += new System.EventHandler(this.cbCMasMas_CheckedChanged);
            // 
            // cbCSharp
            // 
            this.cbCSharp.AutoSize = true;
            this.cbCSharp.Location = new System.Drawing.Point(17, 27);
            this.cbCSharp.Name = "cbCSharp";
            this.cbCSharp.Size = new System.Drawing.Size(41, 19);
            this.cbCSharp.TabIndex = 0;
            this.cbCSharp.Text = "C#";
            this.cbCSharp.UseVisualStyleBackColor = true;
            this.cbCSharp.CheckedChanged += new System.EventHandler(this.cbCSharp_CheckedChanged);
            // 
            // lbPaises
            // 
            this.lbPaises.FormattingEnabled = true;
            this.lbPaises.ItemHeight = 15;
            this.lbPaises.Location = new System.Drawing.Point(12, 208);
            this.lbPaises.Name = "lbPaises";
            this.lbPaises.Size = new System.Drawing.Size(242, 94);
            this.lbPaises.TabIndex = 6;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 188);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(326, 260);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(122, 42);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 314);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lbPaises);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbDetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDetalles.ResumeLayout(false);
            this.gbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.CheckBox cbJavaScript;
        private System.Windows.Forms.CheckBox cbCMasMas;
        private System.Windows.Forms.CheckBox cbCSharp;
        private System.Windows.Forms.ListBox lbPaises;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}
