namespace CapaPresentacionPizzza
{
    partial class IUAdminPizzeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUAdminPizzeria));
            this.rbAdiciones = new System.Windows.Forms.RadioButton();
            this.rbPizzas = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lnCambiarC = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbGraficar = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAdiciones
            // 
            this.rbAdiciones.AutoSize = true;
            this.rbAdiciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdiciones.ForeColor = System.Drawing.Color.LightGray;
            this.rbAdiciones.Location = new System.Drawing.Point(350, 120);
            this.rbAdiciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAdiciones.Name = "rbAdiciones";
            this.rbAdiciones.Size = new System.Drawing.Size(124, 27);
            this.rbAdiciones.TabIndex = 0;
            this.rbAdiciones.TabStop = true;
            this.rbAdiciones.Text = "adiciones";
            this.rbAdiciones.UseVisualStyleBackColor = true;
            this.rbAdiciones.CheckedChanged += new System.EventHandler(this.rbAdiciones_CheckedChanged);
            // 
            // rbPizzas
            // 
            this.rbPizzas.AutoSize = true;
            this.rbPizzas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPizzas.ForeColor = System.Drawing.Color.LightGray;
            this.rbPizzas.Location = new System.Drawing.Point(174, 120);
            this.rbPizzas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPizzas.Name = "rbPizzas";
            this.rbPizzas.Size = new System.Drawing.Size(86, 27);
            this.rbPizzas.TabIndex = 1;
            this.rbPizzas.TabStop = true;
            this.rbPizzas.Text = "Pizzas";
            this.rbPizzas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(424, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(174, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lnCambiarC
            // 
            this.lnCambiarC.AutoSize = true;
            this.lnCambiarC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnCambiarC.LinkColor = System.Drawing.Color.OrangeRed;
            this.lnCambiarC.Location = new System.Drawing.Point(428, 303);
            this.lnCambiarC.Name = "lnCambiarC";
            this.lnCambiarC.Size = new System.Drawing.Size(217, 23);
            this.lnCambiarC.TabIndex = 4;
            this.lnCambiarC.TabStop = true;
            this.lnCambiarC.Text = "Cambiar Contraseña";
            this.lnCambiarC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnCambiarC_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 364);
            this.panel1.TabIndex = 5;
            // 
            // rbGraficar
            // 
            this.rbGraficar.AutoSize = true;
            this.rbGraficar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGraficar.ForeColor = System.Drawing.Color.LightGray;
            this.rbGraficar.Location = new System.Drawing.Point(521, 120);
            this.rbGraficar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGraficar.Name = "rbGraficar";
            this.rbGraficar.Size = new System.Drawing.Size(104, 27);
            this.rbGraficar.TabIndex = 13;
            this.rbGraficar.TabStop = true;
            this.rbGraficar.Text = "Grafica";
            this.rbGraficar.UseVisualStyleBackColor = true;
            this.rbGraficar.CheckedChanged += new System.EventHandler(this.rbGraficar_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(655, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // IUAdminPizzeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(696, 364);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rbGraficar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnCambiarC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbPizzas);
            this.Controls.Add(this.rbAdiciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IUAdminPizzeria";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPizzeria";
            this.Load += new System.EventHandler(this.AdminPizzeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAdiciones;
        private System.Windows.Forms.RadioButton rbPizzas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel lnCambiarC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbGraficar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}