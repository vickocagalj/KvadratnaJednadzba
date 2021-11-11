
namespace Vsite.CSharp.KvadratnaJednadžba.GUI
{
    partial class ResultDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownb = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDowna = new System.Windows.Forms.NumericUpDown();
            this.a = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Discriminant = new System.Windows.Forms.TextBox();
            this.textBoxRoots = new System.Windows.Forms.GroupBox();
            this.Roots2 = new System.Windows.Forms.TextBox();
            this.Roots1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowna)).BeginInit();
            this.textBoxRoots.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDowna);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coefficients";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDownc
            // 
            this.numericUpDownc.DecimalPlaces = 2;
            this.numericUpDownc.Location = new System.Drawing.Point(42, 86);
            this.numericUpDownc.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownc.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownc.Name = "numericUpDownc";
            this.numericUpDownc.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownc.TabIndex = 5;
            this.numericUpDownc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownc.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "&c:";
            // 
            // numericUpDownb
            // 
            this.numericUpDownb.DecimalPlaces = 2;
            this.numericUpDownb.Location = new System.Drawing.Point(42, 59);
            this.numericUpDownb.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownb.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownb.Name = "numericUpDownb";
            this.numericUpDownb.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownb.TabIndex = 3;
            this.numericUpDownb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownb.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "&b:";
            // 
            // numericUpDowna
            // 
            this.numericUpDowna.DecimalPlaces = 2;
            this.numericUpDowna.Location = new System.Drawing.Point(42, 31);
            this.numericUpDowna.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDowna.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDowna.Name = "numericUpDowna";
            this.numericUpDowna.Size = new System.Drawing.Size(120, 22);
            this.numericUpDowna.TabIndex = 1;
            this.numericUpDowna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDowna.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.SystemColors.Control;
            this.a.Location = new System.Drawing.Point(16, 31);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(19, 16);
            this.a.TabIndex = 0;
            this.a.Text = "&a:";
            this.a.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Discriminant:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Discriminant
            // 
            this.Discriminant.Location = new System.Drawing.Point(108, 194);
            this.Discriminant.Name = "Discriminant";
            this.Discriminant.ReadOnly = true;
            this.Discriminant.Size = new System.Drawing.Size(125, 22);
            this.Discriminant.TabIndex = 2;
            this.Discriminant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxRoots
            // 
            this.textBoxRoots.Controls.Add(this.Roots2);
            this.textBoxRoots.Controls.Add(this.Roots1);
            this.textBoxRoots.Location = new System.Drawing.Point(21, 250);
            this.textBoxRoots.Name = "textBoxRoots";
            this.textBoxRoots.Size = new System.Drawing.Size(200, 100);
            this.textBoxRoots.TabIndex = 3;
            this.textBoxRoots.TabStop = false;
            this.textBoxRoots.Text = "Roots";
            // 
            // Roots2
            // 
            this.Roots2.Location = new System.Drawing.Point(9, 49);
            this.Roots2.Name = "Roots2";
            this.Roots2.ReadOnly = true;
            this.Roots2.Size = new System.Drawing.Size(182, 22);
            this.Roots2.TabIndex = 4;
            this.Roots2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Roots1
            // 
            this.Roots1.Location = new System.Drawing.Point(9, 21);
            this.Roots1.Name = "Roots1";
            this.Roots1.ReadOnly = true;
            this.Roots1.Size = new System.Drawing.Size(182, 22);
            this.Roots1.TabIndex = 3;
            this.Roots1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxRoots);
            this.Controls.Add(this.Discriminant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultDisplay";
            this.Size = new System.Drawing.Size(603, 360);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowna)).EndInit();
            this.textBoxRoots.ResumeLayout(false);
            this.textBoxRoots.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.NumericUpDown numericUpDowna;
        private System.Windows.Forms.NumericUpDown numericUpDownc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Discriminant;
        private System.Windows.Forms.GroupBox textBoxRoots;
        private System.Windows.Forms.TextBox Roots2;
        private System.Windows.Forms.TextBox Roots1;
    }
}
