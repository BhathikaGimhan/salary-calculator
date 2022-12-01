namespace salary_Cal
{
    partial class Frm_Cal
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
            this.lableUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.WorkH = new System.Windows.Forms.TextBox();
            this.Leave = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.TextBox();
            this.EmpolyeeName = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.OT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lableUserName
            // 
            this.lableUserName.AutoSize = true;
            this.lableUserName.Location = new System.Drawing.Point(12, 9);
            this.lableUserName.Name = "lableUserName";
            this.lableUserName.Size = new System.Drawing.Size(0, 15);
            this.lableUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee\'s Monthly sallary Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Work Hover :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Leave :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pay Rate :";
            // 
            // DropDown
            // 
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Items.AddRange(new object[] {
            "Executive",
            "None Executive",
            "Casual Workers"});
            this.DropDown.Location = new System.Drawing.Point(202, 140);
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(354, 23);
            this.DropDown.TabIndex = 7;
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedIndexChanged);
            // 
            // WorkH
            // 
            this.WorkH.Location = new System.Drawing.Point(202, 190);
            this.WorkH.Name = "WorkH";
            this.WorkH.Size = new System.Drawing.Size(354, 23);
            this.WorkH.TabIndex = 8;
            // 
            // Leave
            // 
            this.Leave.Location = new System.Drawing.Point(202, 240);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(354, 23);
            this.Leave.TabIndex = 9;
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(202, 297);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(354, 23);
            this.Rate.TabIndex = 10;
            // 
            // EmpolyeeName
            // 
            this.EmpolyeeName.Location = new System.Drawing.Point(202, 94);
            this.EmpolyeeName.Name = "EmpolyeeName";
            this.EmpolyeeName.Size = new System.Drawing.Size(354, 23);
            this.EmpolyeeName.TabIndex = 11;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(421, 399);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(135, 23);
            this.Enter.TabIndex = 12;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Over Time  :";
            // 
            // OT
            // 
            this.OT.Location = new System.Drawing.Point(202, 348);
            this.OT.Name = "OT";
            this.OT.Size = new System.Drawing.Size(354, 23);
            this.OT.TabIndex = 14;
            // 
            // Frm_Cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.OT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.EmpolyeeName);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.WorkH);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lableUserName);
            this.Name = "Frm_Cal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cal";
            this.Load += new System.EventHandler(this.Frm_Cal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lableUserName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox DropDown;
        private TextBox WorkH;
        private TextBox Leave;
        private TextBox Rate;
        private TextBox EmpolyeeName;
        private Button Enter;
        private Label label7;
        private TextBox OT;
    }
}