
namespace Contact_Tracing_Application
{
    partial class formView
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.bttnView = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "CONTACT TRACING FORM";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 47);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(316, 257);
            this.txtResponse.TabIndex = 14;
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSubmit.ForeColor = System.Drawing.Color.White;
            this.bttnSubmit.Location = new System.Drawing.Point(219, 310);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(109, 23);
            this.bttnSubmit.TabIndex = 15;
            this.bttnSubmit.Text = "Submit Response";
            this.bttnSubmit.UseVisualStyleBackColor = false;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click);
            // 
            // bttnView
            // 
            this.bttnView.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnView.ForeColor = System.Drawing.Color.White;
            this.bttnView.Location = new System.Drawing.Point(104, 310);
            this.bttnView.Name = "bttnView";
            this.bttnView.Size = new System.Drawing.Size(109, 23);
            this.bttnView.TabIndex = 16;
            this.bttnView.Text = "View Response";
            this.bttnView.UseVisualStyleBackColor = false;
            this.bttnView.Click += new System.EventHandler(this.bttnView_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // formView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(340, 342);
            this.Controls.Add(this.bttnView);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.label6);
            this.Name = "formView";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button bttnSubmit;
        private System.Windows.Forms.Button bttnView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}