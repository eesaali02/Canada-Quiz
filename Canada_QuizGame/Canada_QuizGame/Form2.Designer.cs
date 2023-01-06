namespace Canada_QuizGame
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btn5050 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQ7 = new System.Windows.Forms.Label();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.lblQ5 = new System.Windows.Forms.Label();
            this.lblQ6 = new System.Windows.Forms.Label();
            this.lblQ1points = new System.Windows.Forms.Label();
            this.lblQ2points = new System.Windows.Forms.Label();
            this.lblQ3points = new System.Windows.Forms.Label();
            this.lblQ4points = new System.Windows.Forms.Label();
            this.lblQ5points = new System.Windows.Forms.Label();
            this.lblQ6points = new System.Windows.Forms.Label();
            this.lblQ7points = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(78, 101);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(286, 26);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Questions Placeholder";
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.MistyRose;
            this.btnOption1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption1.Location = new System.Drawing.Point(78, 202);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(265, 105);
            this.btnOption1.TabIndex = 1;
            this.btnOption1.Tag = "1";
            this.btnOption1.Text = "button1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.MistyRose;
            this.btnOption4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption4.Location = new System.Drawing.Point(349, 421);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(265, 105);
            this.btnOption4.TabIndex = 2;
            this.btnOption4.Tag = "4";
            this.btnOption4.Text = "button1";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.MistyRose;
            this.btnOption3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption3.Location = new System.Drawing.Point(78, 421);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(265, 105);
            this.btnOption3.TabIndex = 3;
            this.btnOption3.Tag = "3";
            this.btnOption3.Text = "button1";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.MistyRose;
            this.btnOption2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption2.Location = new System.Drawing.Point(349, 202);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(265, 105);
            this.btnOption2.TabIndex = 4;
            this.btnOption2.Tag = "2";
            this.btnOption2.Text = "button1";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.MistyRose;
            this.btnHint.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHint.Location = new System.Drawing.Point(349, 532);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(265, 49);
            this.btnHint.TabIndex = 5;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btn5050
            // 
            this.btn5050.BackColor = System.Drawing.Color.MistyRose;
            this.btn5050.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5050.Location = new System.Drawing.Point(78, 532);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(265, 49);
            this.btn5050.TabIndex = 6;
            this.btn5050.Text = "50:50";
            this.btn5050.UseVisualStyleBackColor = false;
            this.btn5050.Click += new System.EventHandler(this.btn5050_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(712, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerName.Location = new System.Drawing.Point(818, 57);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(228, 26);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "name placeholder";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(818, 146);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(25, 26);
            this.lblPoints.TabIndex = 9;
            this.lblPoints.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(712, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(868, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Q.No Points";
            // 
            // lblQ7
            // 
            this.lblQ7.AutoSize = true;
            this.lblQ7.BackColor = System.Drawing.Color.White;
            this.lblQ7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ7.Location = new System.Drawing.Point(913, 279);
            this.lblQ7.Name = "lblQ7";
            this.lblQ7.Size = new System.Drawing.Size(75, 43);
            this.lblQ7.TabIndex = 18;
            this.lblQ7.Text = "Q.7";
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.BackColor = System.Drawing.Color.White;
            this.lblQ1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ1.Location = new System.Drawing.Point(913, 523);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(75, 43);
            this.lblQ1.TabIndex = 19;
            this.lblQ1.Text = "Q.1";
            this.lblQ1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.BackColor = System.Drawing.Color.White;
            this.lblQ2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ2.Location = new System.Drawing.Point(913, 485);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(75, 43);
            this.lblQ2.TabIndex = 20;
            this.lblQ2.Text = "Q.2";
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.BackColor = System.Drawing.Color.White;
            this.lblQ3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ3.Location = new System.Drawing.Point(913, 447);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(75, 43);
            this.lblQ3.TabIndex = 21;
            this.lblQ3.Text = "Q.3";
            // 
            // lblQ4
            // 
            this.lblQ4.AutoSize = true;
            this.lblQ4.BackColor = System.Drawing.Color.White;
            this.lblQ4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ4.Location = new System.Drawing.Point(913, 405);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(75, 43);
            this.lblQ4.TabIndex = 22;
            this.lblQ4.Text = "Q.4";
            // 
            // lblQ5
            // 
            this.lblQ5.AutoSize = true;
            this.lblQ5.BackColor = System.Drawing.Color.White;
            this.lblQ5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ5.Location = new System.Drawing.Point(913, 362);
            this.lblQ5.Name = "lblQ5";
            this.lblQ5.Size = new System.Drawing.Size(75, 43);
            this.lblQ5.TabIndex = 23;
            this.lblQ5.Text = "Q.5";
            // 
            // lblQ6
            // 
            this.lblQ6.AutoSize = true;
            this.lblQ6.BackColor = System.Drawing.Color.White;
            this.lblQ6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ6.Location = new System.Drawing.Point(913, 322);
            this.lblQ6.Name = "lblQ6";
            this.lblQ6.Size = new System.Drawing.Size(75, 43);
            this.lblQ6.TabIndex = 24;
            this.lblQ6.Text = "Q.6";
            // 
            // lblQ1points
            // 
            this.lblQ1points.AutoSize = true;
            this.lblQ1points.BackColor = System.Drawing.Color.White;
            this.lblQ1points.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ1points.Location = new System.Drawing.Point(988, 523);
            this.lblQ1points.Name = "lblQ1points";
            this.lblQ1points.Size = new System.Drawing.Size(39, 43);
            this.lblQ1points.TabIndex = 25;
            this.lblQ1points.Text = "0";
            // 
            // lblQ2points
            // 
            this.lblQ2points.AutoSize = true;
            this.lblQ2points.BackColor = System.Drawing.Color.White;
            this.lblQ2points.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ2points.Location = new System.Drawing.Point(988, 480);
            this.lblQ2points.Name = "lblQ2points";
            this.lblQ2points.Size = new System.Drawing.Size(39, 43);
            this.lblQ2points.TabIndex = 26;
            this.lblQ2points.Text = "0";
            // 
            // lblQ3points
            // 
            this.lblQ3points.AutoSize = true;
            this.lblQ3points.BackColor = System.Drawing.Color.White;
            this.lblQ3points.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ3points.Location = new System.Drawing.Point(988, 444);
            this.lblQ3points.Name = "lblQ3points";
            this.lblQ3points.Size = new System.Drawing.Size(39, 43);
            this.lblQ3points.TabIndex = 27;
            this.lblQ3points.Text = "0";
            // 
            // lblQ4points
            // 
            this.lblQ4points.AutoSize = true;
            this.lblQ4points.BackColor = System.Drawing.Color.White;
            this.lblQ4points.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ4points.Location = new System.Drawing.Point(988, 406);
            this.lblQ4points.Name = "lblQ4points";
            this.lblQ4points.Size = new System.Drawing.Size(39, 43);
            this.lblQ4points.TabIndex = 28;
            this.lblQ4points.Text = "0";
            // 
            // lblQ5points
            // 
            this.lblQ5points.AutoSize = true;
            this.lblQ5points.BackColor = System.Drawing.Color.White;
            this.lblQ5points.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ5points.Location = new System.Drawing.Point(988, 365);
            this.lblQ5points.Name = "lblQ5points";
            this.lblQ5points.Size = new System.Drawing.Size(39, 43);
            this.lblQ5points.TabIndex = 29;
            this.lblQ5points.Text = "0";
            this.lblQ5points.Click += new System.EventHandler(this.lblQ5points_Click);
            // 
            // lblQ6points
            // 
            this.lblQ6points.AutoSize = true;
            this.lblQ6points.BackColor = System.Drawing.Color.White;
            this.lblQ6points.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ6points.Location = new System.Drawing.Point(988, 322);
            this.lblQ6points.Name = "lblQ6points";
            this.lblQ6points.Size = new System.Drawing.Size(39, 43);
            this.lblQ6points.TabIndex = 30;
            this.lblQ6points.Text = "0";
            // 
            // lblQ7points
            // 
            this.lblQ7points.AutoSize = true;
            this.lblQ7points.BackColor = System.Drawing.Color.White;
            this.lblQ7points.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQ7points.Location = new System.Drawing.Point(988, 279);
            this.lblQ7points.Name = "lblQ7points";
            this.lblQ7points.Size = new System.Drawing.Size(39, 43);
            this.lblQ7points.TabIndex = 31;
            this.lblQ7points.Text = "0";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(105, 609);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(139, 25);
            this.lblHint.TabIndex = 32;
            this.lblHint.Text = "hint placeholder";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Silver;
            this.lblTimer.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(309, 338);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(71, 44);
            this.lblTimer.TabIndex = 33;
            this.lblTimer.Text = "00";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1194, 681);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblQ7points);
            this.Controls.Add(this.lblQ6points);
            this.Controls.Add(this.lblQ5points);
            this.Controls.Add(this.lblQ4points);
            this.Controls.Add(this.lblQ3points);
            this.Controls.Add(this.lblQ2points);
            this.Controls.Add(this.lblQ1points);
            this.Controls.Add(this.lblQ6);
            this.Controls.Add(this.lblQ5);
            this.Controls.Add(this.lblQ4);
            this.Controls.Add(this.lblQ3);
            this.Controls.Add(this.lblQ2);
            this.Controls.Add(this.lblQ1);
            this.Controls.Add(this.lblQ7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn5050);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.CheckAnswer);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQuestion;
        private Button btnOption1;
        private Button btnOption4;
        private Button btnOption3;
        private Button btnOption2;
        private Button btnHint;
        private Button btn5050;
        private Label label1;
        private Label lblPlayerName;
        private Label lblPoints;
        private Label label3;
        private Label label2;
        private Label lblQ7;
        private Label lblQ1;
        private Label lblQ2;
        private Label lblQ3;
        private Label lblQ4;
        private Label lblQ5;
        private Label lblQ6;
        private Label lblQ1points;
        private Label lblQ2points;
        private Label lblQ3points;
        private Label lblQ4points;
        private Label lblQ5points;
        private Label lblQ6points;
        private Label lblQ7points;
        private Label lblHint;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
    }
}