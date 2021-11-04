
namespace Vsite.CSharp.KvadratnaJednadžba.GUI
{
    partial class Form1
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
            this.resultDisplay1 = new Vsite.CSharp.KvadratnaJednadžba.GUI.ResultDisplay();
            this.functionPanel1 = new Vsite.CSharp.KvadratnaJednadžba.GUI.FunctionPanel();
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.Location = new System.Drawing.Point(0, 0);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.Size = new System.Drawing.Size(363, 360);
            this.resultDisplay1.TabIndex = 0;
            // 
            // functionPanel1
            // 
            this.functionPanel1.Location = new System.Drawing.Point(338, 12);
            this.functionPanel1.Name = "functionPanel1";
            this.functionPanel1.Size = new System.Drawing.Size(355, 364);
            this.functionPanel1.TabIndex = 1;
            this.functionPanel1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.functionPanel1);
            this.Controls.Add(this.resultDisplay1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay1;
        private FunctionPanel functionPanel1;
    }
}

