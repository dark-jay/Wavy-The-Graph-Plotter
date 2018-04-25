namespace Test_of_Wavy
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCanvas.Location = new System.Drawing.Point(12, 63);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(659, 466);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(90, 14);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(503, 31);
            this.txtInput.TabIndex = 1;
            // 
            // btnPlot
            // 
            this.btnPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlot.Location = new System.Drawing.Point(599, 12);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(72, 33);
            this.btnPlot.TabIndex = 2;
            this.btnPlot.Text = "Plott";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 538);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Wavy - The Graph Plotter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Button btnClear;
    }
}

