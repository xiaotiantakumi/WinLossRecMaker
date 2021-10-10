namespace WinLossRecMaker
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
            this._conversionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._num1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._num2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._chkInvalid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._num2)).BeginInit();
            this.SuspendLayout();
            // 
            // _conversionText
            // 
            this._conversionText.Location = new System.Drawing.Point(12, 56);
            this._conversionText.Multiline = true;
            this._conversionText.Name = "_conversionText";
            this._conversionText.Size = new System.Drawing.Size(291, 56);
            this._conversionText.TabIndex = 0;
            this._conversionText.Text = "$勝$敗";
            this._conversionText.TextChanged += new System.EventHandler(this.RelatedTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "変換記号は$です。\r\n3個以上設定できません。\r\n";
            // 
            // _num1
            // 
            this._num1.Location = new System.Drawing.Point(13, 147);
            this._num1.Name = "_num1";
            this._num1.Size = new System.Drawing.Size(76, 27);
            this._num1.TabIndex = 3;
            this._num1.ValueChanged += new System.EventHandler(this.RelatedTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "変換記号1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "変換記号2";
            // 
            // _num2
            // 
            this._num2.Location = new System.Drawing.Point(12, 206);
            this._num2.Name = "_num2";
            this._num2.Size = new System.Drawing.Size(76, 27);
            this._num2.TabIndex = 5;
            this._num2.ValueChanged += new System.EventHandler(this.RelatedTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "直近の変更を取り消したい場合は\r\n【back】ボタンを押してください";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "対応キー：1 or 矢印↑ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "対応キー：2 or 矢印→ ";
            // 
            // _chkInvalid
            // 
            this._chkInvalid.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkInvalid.Location = new System.Drawing.Point(13, 310);
            this._chkInvalid.Name = "_chkInvalid";
            this._chkInvalid.Size = new System.Drawing.Size(290, 30);
            this._chkInvalid.TabIndex = 10;
            this._chkInvalid.Text = "キー入力を無効化";
            this._chkInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._chkInvalid.UseVisualStyleBackColor = true;
            this._chkInvalid.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 352);
            this.Controls.Add(this._chkInvalid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._conversionText);
            this.Name = "Form1";
            this.Text = "勝敗Rec";
            ((System.ComponentModel.ISupportInitialize)(this._num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _num2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.CheckBox _chkInvalid;
        private System.Windows.Forms.TextBox _conversionText;
    }
}

