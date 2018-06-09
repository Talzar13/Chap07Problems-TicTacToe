namespace Chap07Problems_TicTacToe
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.gbxSquares = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxSquares.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(148, 556);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 23);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(48, 521);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(300, 32);
            this.lblResult.TabIndex = 10;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl0
            // 
            this.lbl0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl0.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl0.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl0.Location = new System.Drawing.Point(121, 16);
            this.lbl0.Margin = new System.Windows.Forms.Padding(0);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(100, 100);
            this.lbl0.TabIndex = 0;
            this.lbl0.Text = "0";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl1.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl1.Location = new System.Drawing.Point(236, 16);
            this.lbl1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 100);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "1";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl2.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl2.Location = new System.Drawing.Point(336, 16);
            this.lbl2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 100);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "2";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl3.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl3.Location = new System.Drawing.Point(445, 16);
            this.lbl3.Margin = new System.Windows.Forms.Padding(0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 100);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "3";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl4.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl4.Location = new System.Drawing.Point(236, 173);
            this.lbl4.Margin = new System.Windows.Forms.Padding(0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 100);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "4";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl5.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl5.Location = new System.Drawing.Point(350, 173);
            this.lbl5.Margin = new System.Windows.Forms.Padding(0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(100, 100);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "5";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            this.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl6.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl6.Location = new System.Drawing.Point(472, 173);
            this.lbl6.Margin = new System.Windows.Forms.Padding(0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(100, 100);
            this.lbl6.TabIndex = 6;
            this.lbl6.Text = "6";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl7
            // 
            this.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl7.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl7.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl7.Location = new System.Drawing.Point(587, 173);
            this.lbl7.Margin = new System.Windows.Forms.Padding(0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(100, 100);
            this.lbl7.TabIndex = 7;
            this.lbl7.Text = "7";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl8.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl8.Font = new System.Drawing.Font("Consolas", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl8.Location = new System.Drawing.Point(587, 294);
            this.lbl8.Margin = new System.Windows.Forms.Padding(0);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(100, 100);
            this.lbl8.TabIndex = 8;
            this.lbl8.Text = "8";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxSquares
            // 
            this.gbxSquares.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSquares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxSquares.Controls.Add(this.lbl0);
            this.gbxSquares.Controls.Add(this.lbl3);
            this.gbxSquares.Controls.Add(this.lbl6);
            this.gbxSquares.Controls.Add(this.lbl8);
            this.gbxSquares.Controls.Add(this.lbl5);
            this.gbxSquares.Controls.Add(this.lbl2);
            this.gbxSquares.Controls.Add(this.lbl7);
            this.gbxSquares.Controls.Add(this.lbl4);
            this.gbxSquares.Controls.Add(this.lbl1);
            this.gbxSquares.Location = new System.Drawing.Point(12, 12);
            this.gbxSquares.Name = "gbxSquares";
            this.gbxSquares.Size = new System.Drawing.Size(777, 479);
            this.gbxSquares.TabIndex = 11;
            this.gbxSquares.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(372, 555);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 617);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbxSquares);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnNewGame);
            this.Name = "Form1";
            this.Text = "Automatic Tic Tac Toe";
            this.gbxSquares.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        public System.Windows.Forms.GroupBox gbxSquares;
        private System.Windows.Forms.Button btnClear;
    }
}

