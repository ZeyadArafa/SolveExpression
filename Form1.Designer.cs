namespace SolveExpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butCheckValidity = new System.Windows.Forms.Button();
            this.textExpression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labValidityOuput = new System.Windows.Forms.Label();
            this.butCheckBalance = new System.Windows.Forms.Button();
            this.butSplitExpression = new System.Windows.Forms.Button();
            this.butSolution = new System.Windows.Forms.Button();
            this.butPostfix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCheckValidity
            // 
            this.butCheckValidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCheckValidity.Location = new System.Drawing.Point(17, 187);
            this.butCheckValidity.Name = "butCheckValidity";
            this.butCheckValidity.Size = new System.Drawing.Size(137, 34);
            this.butCheckValidity.TabIndex = 0;
            this.butCheckValidity.Text = "Check Validity";
            this.butCheckValidity.UseVisualStyleBackColor = true;
            this.butCheckValidity.Click += new System.EventHandler(this.butCheckValidity_Click);
            // 
            // textExpression
            // 
            this.textExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExpression.Location = new System.Drawing.Point(150, 19);
            this.textExpression.Name = "textExpression";
            this.textExpression.Size = new System.Drawing.Size(647, 30);
            this.textExpression.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expression";
            // 
            // labValidityOuput
            // 
            this.labValidityOuput.AutoSize = true;
            this.labValidityOuput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labValidityOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValidityOuput.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labValidityOuput.Location = new System.Drawing.Point(152, 76);
            this.labValidityOuput.Name = "labValidityOuput";
            this.labValidityOuput.Size = new System.Drawing.Size(22, 26);
            this.labValidityOuput.TabIndex = 3;
            this.labValidityOuput.Text = "0";
            // 
            // butCheckBalance
            // 
            this.butCheckBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCheckBalance.Location = new System.Drawing.Point(179, 188);
            this.butCheckBalance.Name = "butCheckBalance";
            this.butCheckBalance.Size = new System.Drawing.Size(137, 34);
            this.butCheckBalance.TabIndex = 4;
            this.butCheckBalance.Text = "Check Balance";
            this.butCheckBalance.UseVisualStyleBackColor = true;
            this.butCheckBalance.Click += new System.EventHandler(this.butCheckBalance_Click);
            // 
            // butSplitExpression
            // 
            this.butSplitExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSplitExpression.Location = new System.Drawing.Point(346, 187);
            this.butSplitExpression.Name = "butSplitExpression";
            this.butSplitExpression.Size = new System.Drawing.Size(137, 34);
            this.butSplitExpression.TabIndex = 5;
            this.butSplitExpression.Text = "Split Expression";
            this.butSplitExpression.UseVisualStyleBackColor = true;
            this.butSplitExpression.Click += new System.EventHandler(this.butSplitExpression_Click);
            // 
            // butSolution
            // 
            this.butSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSolution.Location = new System.Drawing.Point(660, 187);
            this.butSolution.Name = "butSolution";
            this.butSolution.Size = new System.Drawing.Size(137, 34);
            this.butSolution.TabIndex = 6;
            this.butSolution.Text = "Solution";
            this.butSolution.UseVisualStyleBackColor = true;
            this.butSolution.Click += new System.EventHandler(this.butSolution_Click);
            // 
            // butPostfix
            // 
            this.butPostfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPostfix.Image = ((System.Drawing.Image)(resources.GetObject("butPostfix.Image")));
            this.butPostfix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPostfix.Location = new System.Drawing.Point(508, 187);
            this.butPostfix.Name = "butPostfix";
            this.butPostfix.Size = new System.Drawing.Size(137, 34);
            this.butPostfix.TabIndex = 7;
            this.butPostfix.Text = "Postfix";
            this.butPostfix.UseVisualStyleBackColor = true;
            this.butPostfix.Click += new System.EventHandler(this.butPostfix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 253);
            this.Controls.Add(this.butPostfix);
            this.Controls.Add(this.butSolution);
            this.Controls.Add(this.butSplitExpression);
            this.Controls.Add(this.butCheckBalance);
            this.Controls.Add(this.labValidityOuput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textExpression);
            this.Controls.Add(this.butCheckValidity);
            this.Name = "Form1";
            this.Text = "Solve Mathematical Expression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCheckValidity;
        private System.Windows.Forms.TextBox textExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labValidityOuput;
        private System.Windows.Forms.Button butCheckBalance;
        private System.Windows.Forms.Button butSplitExpression;
        private System.Windows.Forms.Button butSolution;
        private System.Windows.Forms.Button butPostfix;
    }
}

