namespace NumerosPrimos
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtLimite = new Guna.UI.WinForms.GunaTextBox();
            this.btnMostrarPrimos = new Guna.UI.WinForms.GunaButton();
            this.listBoxPrimos = new System.Windows.Forms.ListBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnLimpiar = new Guna.UI.WinForms.GunaButton();
            this.btnSalir = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // txtLimite
            // 
            this.txtLimite.BackColor = System.Drawing.Color.Transparent;
            this.txtLimite.BaseColor = System.Drawing.Color.White;
            this.txtLimite.BorderColor = System.Drawing.Color.Silver;
            this.txtLimite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLimite.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLimite.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLimite.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLimite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLimite.Location = new System.Drawing.Point(230, 175);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.PasswordChar = '\0';
            this.txtLimite.Radius = 5;
            this.txtLimite.Size = new System.Drawing.Size(57, 30);
            this.txtLimite.TabIndex = 0;
            this.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMostrarPrimos
            // 
            this.btnMostrarPrimos.AnimationHoverSpeed = 0.07F;
            this.btnMostrarPrimos.AnimationSpeed = 0.03F;
            this.btnMostrarPrimos.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarPrimos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMostrarPrimos.BorderColor = System.Drawing.Color.Black;
            this.btnMostrarPrimos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMostrarPrimos.FocusedColor = System.Drawing.Color.Empty;
            this.btnMostrarPrimos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarPrimos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarPrimos.Image = null;
            this.btnMostrarPrimos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMostrarPrimos.Location = new System.Drawing.Point(186, 221);
            this.btnMostrarPrimos.Name = "btnMostrarPrimos";
            this.btnMostrarPrimos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMostrarPrimos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMostrarPrimos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMostrarPrimos.OnHoverImage = null;
            this.btnMostrarPrimos.OnPressedColor = System.Drawing.Color.Black;
            this.btnMostrarPrimos.Radius = 5;
            this.btnMostrarPrimos.Size = new System.Drawing.Size(143, 42);
            this.btnMostrarPrimos.TabIndex = 1;
            this.btnMostrarPrimos.Text = "Mostrar Numeros Primos";
            this.btnMostrarPrimos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMostrarPrimos.Click += new System.EventHandler(this.btnMostrarPrimos_Click);
            // 
            // listBoxPrimos
            // 
            this.listBoxPrimos.BackColor = System.Drawing.Color.White;
            this.listBoxPrimos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPrimos.ForeColor = System.Drawing.Color.Black;
            this.listBoxPrimos.FormattingEnabled = true;
            this.listBoxPrimos.Location = new System.Drawing.Point(12, 47);
            this.listBoxPrimos.Name = "listBoxPrimos";
            this.listBoxPrimos.Size = new System.Drawing.Size(58, 377);
            this.listBoxPrimos.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(139, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(233, 32);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "NUMEROS PRIMOS";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AnimationHoverSpeed = 0.07F;
            this.btnLimpiar.AnimationSpeed = 0.03F;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiar.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = null;
            this.btnLimpiar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiar.Location = new System.Drawing.Point(186, 269);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLimpiar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiar.OnHoverImage = null;
            this.btnLimpiar.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiar.Radius = 5;
            this.btnLimpiar.Size = new System.Drawing.Size(143, 42);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AnimationHoverSpeed = 0.07F;
            this.btnSalir.AnimationSpeed = 0.03F;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSalir.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalir.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = null;
            this.btnSalir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalir.Location = new System.Drawing.Point(186, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSalir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalir.OnHoverImage = null;
            this.btnSalir.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalir.Radius = 5;
            this.btnSalir.Size = new System.Drawing.Size(143, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(131, 403);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(257, 21);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Create by: Yael Moises May Caamal";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.listBoxPrimos);
            this.Controls.Add(this.btnMostrarPrimos);
            this.Controls.Add(this.txtLimite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeros Primos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtLimite;
        private Guna.UI.WinForms.GunaButton btnMostrarPrimos;
        private System.Windows.Forms.ListBox listBoxPrimos;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnSalir;
        private Guna.UI.WinForms.GunaButton btnLimpiar;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}

