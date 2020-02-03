namespace Lab9
{
    partial class Lab9
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
            this.updateMonthBtn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.outDateLbl = new System.Windows.Forms.Label();
            this.monthLbl = new System.Windows.Forms.Label();
            this.dayLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.inMonthTxt = new System.Windows.Forms.TextBox();
            this.inDayTxt = new System.Windows.Forms.TextBox();
            this.inYearTxt = new System.Windows.Forms.TextBox();
            this.updateDayBtn = new System.Windows.Forms.Button();
            this.updateYearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateMonthBtn
            // 
            this.updateMonthBtn.AutoSize = true;
            this.updateMonthBtn.Location = new System.Drawing.Point(367, 131);
            this.updateMonthBtn.Name = "updateMonthBtn";
            this.updateMonthBtn.Size = new System.Drawing.Size(170, 35);
            this.updateMonthBtn.TabIndex = 0;
            this.updateMonthBtn.Text = "Update Month";
            this.updateMonthBtn.UseVisualStyleBackColor = true;
            this.updateMonthBtn.Click += new System.EventHandler(this.updateMonthBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(188, 67);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(63, 25);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "Date:";
            // 
            // outDateLbl
            // 
            this.outDateLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outDateLbl.Location = new System.Drawing.Point(257, 66);
            this.outDateLbl.Name = "outDateLbl";
            this.outDateLbl.Size = new System.Drawing.Size(187, 31);
            this.outDateLbl.TabIndex = 2;
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Location = new System.Drawing.Point(109, 136);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(78, 25);
            this.monthLbl.TabIndex = 3;
            this.monthLbl.Text = "Month:";
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Location = new System.Drawing.Point(131, 204);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(56, 25);
            this.dayLbl.TabIndex = 4;
            this.dayLbl.Text = "Day:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(123, 272);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(64, 25);
            this.yearLbl.TabIndex = 5;
            this.yearLbl.Text = "Year:";
            // 
            // inMonthTxt
            // 
            this.inMonthTxt.Location = new System.Drawing.Point(193, 133);
            this.inMonthTxt.Name = "inMonthTxt";
            this.inMonthTxt.Size = new System.Drawing.Size(168, 31);
            this.inMonthTxt.TabIndex = 6;
            // 
            // inDayTxt
            // 
            this.inDayTxt.Location = new System.Drawing.Point(193, 201);
            this.inDayTxt.Name = "inDayTxt";
            this.inDayTxt.Size = new System.Drawing.Size(168, 31);
            this.inDayTxt.TabIndex = 7;
            // 
            // inYearTxt
            // 
            this.inYearTxt.Location = new System.Drawing.Point(193, 269);
            this.inYearTxt.Name = "inYearTxt";
            this.inYearTxt.Size = new System.Drawing.Size(168, 31);
            this.inYearTxt.TabIndex = 8;
            // 
            // updateDayBtn
            // 
            this.updateDayBtn.AutoSize = true;
            this.updateDayBtn.Location = new System.Drawing.Point(367, 199);
            this.updateDayBtn.Name = "updateDayBtn";
            this.updateDayBtn.Size = new System.Drawing.Size(170, 35);
            this.updateDayBtn.TabIndex = 9;
            this.updateDayBtn.Text = "Update Day";
            this.updateDayBtn.UseVisualStyleBackColor = true;
            this.updateDayBtn.Click += new System.EventHandler(this.updateDayBtn_Click);
            // 
            // updateYearBtn
            // 
            this.updateYearBtn.AutoSize = true;
            this.updateYearBtn.Location = new System.Drawing.Point(367, 267);
            this.updateYearBtn.Name = "updateYearBtn";
            this.updateYearBtn.Size = new System.Drawing.Size(170, 35);
            this.updateYearBtn.TabIndex = 10;
            this.updateYearBtn.Text = "Update Year";
            this.updateYearBtn.UseVisualStyleBackColor = true;
            this.updateYearBtn.Click += new System.EventHandler(this.updateYearBtn_Click);
            // 
            // Lab9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 400);
            this.Controls.Add(this.updateYearBtn);
            this.Controls.Add(this.updateDayBtn);
            this.Controls.Add(this.inYearTxt);
            this.Controls.Add(this.inDayTxt);
            this.Controls.Add(this.inMonthTxt);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.dayLbl);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.outDateLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.updateMonthBtn);
            this.Name = "Lab9";
            this.Text = "Lab 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateMonthBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label outDateLbl;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.TextBox inMonthTxt;
        private System.Windows.Forms.TextBox inDayTxt;
        private System.Windows.Forms.TextBox inYearTxt;
        private System.Windows.Forms.Button updateDayBtn;
        private System.Windows.Forms.Button updateYearBtn;
    }
}

