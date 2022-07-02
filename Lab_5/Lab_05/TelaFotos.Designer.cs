
namespace Lab_04
{
    partial class TelaFotos
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.pbxFoto1 = new System.Windows.Forms.PictureBox();
            this.pbxFoto2 = new System.Windows.Forms.PictureBox();
            this.openFileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn1.Location = new System.Drawing.Point(101, 316);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(368, 316);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Buscar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(618, 316);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Buscar";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbxFoto.Location = new System.Drawing.Point(22, 24);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(188, 168);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 3;
            this.pbxFoto.TabStop = false;
            // 
            // pbxFoto1
            // 
            this.pbxFoto1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxFoto1.Location = new System.Drawing.Point(287, 24);
            this.pbxFoto1.Name = "pbxFoto1";
            this.pbxFoto1.Size = new System.Drawing.Size(176, 168);
            this.pbxFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto1.TabIndex = 4;
            this.pbxFoto1.TabStop = false;
            // 
            // pbxFoto2
            // 
            this.pbxFoto2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbxFoto2.Location = new System.Drawing.Point(528, 24);
            this.pbxFoto2.Name = "pbxFoto2";
            this.pbxFoto2.Size = new System.Drawing.Size(175, 168);
            this.pbxFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto2.TabIndex = 5;
            this.pbxFoto2.TabStop = false;
            // 
            // openFileDialogFoto
            // 
            this.openFileDialogFoto.FileName = "openFileDialogFoto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pbxFoto2);
            this.panel1.Controls.Add(this.pbxFoto);
            this.panel1.Controls.Add(this.pbxFoto1);
            this.panel1.Location = new System.Drawing.Point(36, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 215);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolha uma Imagem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TelaFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel1);
            this.Name = "TelaFotos";
            this.Text = "Fotos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.PictureBox pbxFoto1;
        private System.Windows.Forms.PictureBox pbxFoto2;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}