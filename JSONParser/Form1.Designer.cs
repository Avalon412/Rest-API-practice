
namespace JSONParser
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
            this.txtJSON = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnDeserialise = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJSON
            // 
            this.txtJSON.Location = new System.Drawing.Point(12, 12);
            this.txtJSON.Multiline = true;
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJSON.Size = new System.Drawing.Size(710, 166);
            this.txtJSON.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 216);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(710, 166);
            this.txtOutput.TabIndex = 1;
            // 
            // btnDeserialise
            // 
            this.btnDeserialise.Location = new System.Drawing.Point(12, 184);
            this.btnDeserialise.Name = "btnDeserialise";
            this.btnDeserialise.Size = new System.Drawing.Size(127, 26);
            this.btnDeserialise.TabIndex = 2;
            this.btnDeserialise.Text = "Deserialise";
            this.btnDeserialise.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 26);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Debug";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 394);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeserialise);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtJSON);
            this.Name = "Form1";
            this.Text = "C# JSON Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJSON;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnDeserialise;
        private System.Windows.Forms.Button btnClear;
    }
}

