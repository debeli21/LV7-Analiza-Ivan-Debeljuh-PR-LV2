namespace LV7_analiza
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name1 = new System.Windows.Forms.TextBox();
            this.tb_name2 = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_newPlayers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_playerturn = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player O:";
            // 
            // tb_name1
            // 
            this.tb_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_name1.Location = new System.Drawing.Point(110, 23);
            this.tb_name1.MaxLength = 15;
            this.tb_name1.Name = "tb_name1";
            this.tb_name1.Size = new System.Drawing.Size(135, 26);
            this.tb_name1.TabIndex = 2;
            // 
            // tb_name2
            // 
            this.tb_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_name2.Location = new System.Drawing.Point(110, 54);
            this.tb_name2.MaxLength = 15;
            this.tb_name2.Name = "tb_name2";
            this.tb_name2.Size = new System.Drawing.Size(135, 26);
            this.tb_name2.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_start.Location = new System.Drawing.Point(297, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(85, 33);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_newPlayers
            // 
            this.btn_newPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_newPlayers.Location = new System.Drawing.Point(288, 51);
            this.btn_newPlayers.Name = "btn_newPlayers";
            this.btn_newPlayers.Size = new System.Drawing.Size(104, 33);
            this.btn_newPlayers.TabIndex = 5;
            this.btn_newPlayers.Text = "New players";
            this.btn_newPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newPlayers.UseVisualStyleBackColor = true;
            this.btn_newPlayers.Click += new System.EventHandler(this.btn_newPlayers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 390);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // lbl_playerturn
            // 
            this.lbl_playerturn.AutoSize = true;
            this.lbl_playerturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_playerturn.Location = new System.Drawing.Point(106, 93);
            this.lbl_playerturn.Name = "lbl_playerturn";
            this.lbl_playerturn.Size = new System.Drawing.Size(139, 25);
            this.lbl_playerturn.TabIndex = 7;
            this.lbl_playerturn.Text = "_name_ plays.";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_result.Location = new System.Drawing.Point(12, 527);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 25);
            this.lbl_result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 607);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_playerturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_newPlayers);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_name2);
            this.Controls.Add(this.tb_name1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_newPlayers;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_playerturn;
        public System.Windows.Forms.TextBox tb_name1;
        public System.Windows.Forms.TextBox tb_name2;
        public System.Windows.Forms.Label lbl_result;
    }
}

