namespace FinalProjectAssignment
{
    partial class Room
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
            this.A1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnBookingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassRoomTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A4 = new System.Windows.Forms.Button();
            this.A5 = new System.Windows.Forms.Button();
            this.A6 = new System.Windows.Forms.Button();
            this.A7 = new System.Windows.Forms.Button();
            this.A8 = new System.Windows.Forms.Button();
            this.A9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameBooking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumRoom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelBusyRoom = new System.Windows.Forms.Label();
            this.labelEmptyRoom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtClassroomTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(72, 63);
            this.A1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(161, 64);
            this.A1.TabIndex = 0;
            this.A1.Text = "A1";
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "จองห้องเรียน";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBookingName,
            this.ColumnNumRoom,
            this.Column1,
            this.Column2,
            this.ColumnClassRoomTime});
            this.dataGridView2.Location = new System.Drawing.Point(1008, 137);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(544, 674);
            this.dataGridView2.TabIndex = 2;
            // 
            // ColumnBookingName
            // 
            this.ColumnBookingName.HeaderText = "ชื่อผู้จอง";
            this.ColumnBookingName.Name = "ColumnBookingName";
            this.ColumnBookingName.ReadOnly = true;
            // 
            // ColumnNumRoom
            // 
            this.ColumnNumRoom.HeaderText = "เลขที่ห้องเรียน";
            this.ColumnNumRoom.Name = "ColumnNumRoom";
            this.ColumnNumRoom.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "เวลาจองห้องเรียน";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "วันที่จองห้องเรียน";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ColumnClassRoomTime
            // 
            this.ColumnClassRoomTime.HeaderText = "เวลาใช้ห้องเรียน";
            this.ColumnClassRoomTime.Name = "ColumnClassRoomTime";
            this.ColumnClassRoomTime.ReadOnly = true;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(275, 63);
            this.A2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(161, 64);
            this.A2.TabIndex = 3;
            this.A2.Text = "A2";
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(473, 63);
            this.A3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(161, 64);
            this.A3.TabIndex = 4;
            this.A3.Text = "A3";
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // A4
            // 
            this.A4.Location = new System.Drawing.Point(72, 164);
            this.A4.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(161, 64);
            this.A4.TabIndex = 5;
            this.A4.Text = "A4";
            this.A4.UseVisualStyleBackColor = true;
            this.A4.Click += new System.EventHandler(this.A4_Click);
            // 
            // A5
            // 
            this.A5.Location = new System.Drawing.Point(275, 164);
            this.A5.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(161, 64);
            this.A5.TabIndex = 6;
            this.A5.Text = "A5";
            this.A5.UseVisualStyleBackColor = true;
            this.A5.Click += new System.EventHandler(this.A5_Click);
            // 
            // A6
            // 
            this.A6.Location = new System.Drawing.Point(473, 164);
            this.A6.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(161, 64);
            this.A6.TabIndex = 7;
            this.A6.Text = "A6";
            this.A6.UseVisualStyleBackColor = true;
            this.A6.Click += new System.EventHandler(this.A6_Click);
            // 
            // A7
            // 
            this.A7.Location = new System.Drawing.Point(72, 271);
            this.A7.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(161, 64);
            this.A7.TabIndex = 8;
            this.A7.Text = "A7";
            this.A7.UseVisualStyleBackColor = true;
            this.A7.Click += new System.EventHandler(this.A7_Click);
            // 
            // A8
            // 
            this.A8.Location = new System.Drawing.Point(275, 271);
            this.A8.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(161, 64);
            this.A8.TabIndex = 9;
            this.A8.Text = "A8";
            this.A8.UseVisualStyleBackColor = true;
            this.A8.Click += new System.EventHandler(this.A8_Click);
            // 
            // A9
            // 
            this.A9.Location = new System.Drawing.Point(473, 271);
            this.A9.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(161, 64);
            this.A9.TabIndex = 10;
            this.A9.Text = "A9";
            this.A9.UseVisualStyleBackColor = true;
            this.A9.Click += new System.EventHandler(this.A9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.A1);
            this.groupBox1.Controls.Add(this.A9);
            this.groupBox1.Controls.Add(this.A2);
            this.groupBox1.Controls.Add(this.A8);
            this.groupBox1.Controls.Add(this.A3);
            this.groupBox1.Controls.Add(this.A7);
            this.groupBox1.Controls.Add(this.A4);
            this.groupBox1.Controls.Add(this.A6);
            this.groupBox1.Controls.Add(this.A5);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(55, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Size = new System.Drawing.Size(683, 363);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลขที่ห้องเรียน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 546);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "ชื่อผู้จอง";
            // 
            // txtNameBooking
            // 
            this.txtNameBooking.Location = new System.Drawing.Point(208, 541);
            this.txtNameBooking.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtNameBooking.Name = "txtNameBooking";
            this.txtNameBooking.Size = new System.Drawing.Size(208, 33);
            this.txtNameBooking.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 609);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "เลขที่ห้องเรียน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 780);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "เวลาใช้ห้องเรียน";
            // 
            // txtNumRoom
            // 
            this.txtNumRoom.Location = new System.Drawing.Point(208, 604);
            this.txtNumRoom.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtNumRoom.Name = "txtNumRoom";
            this.txtNumRoom.Size = new System.Drawing.Size(208, 33);
            this.txtNumRoom.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelBusyRoom);
            this.groupBox2.Controls.Add(this.labelEmptyRoom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(745, 137);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox2.Size = new System.Drawing.Size(252, 363);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ห้อง";
            // 
            // labelBusyRoom
            // 
            this.labelBusyRoom.AutoSize = true;
            this.labelBusyRoom.BackColor = System.Drawing.Color.Red;
            this.labelBusyRoom.Location = new System.Drawing.Point(175, 225);
            this.labelBusyRoom.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelBusyRoom.Name = "labelBusyRoom";
            this.labelBusyRoom.Size = new System.Drawing.Size(26, 29);
            this.labelBusyRoom.TabIndex = 3;
            this.labelBusyRoom.Text = "0";
            // 
            // labelEmptyRoom
            // 
            this.labelEmptyRoom.AutoSize = true;
            this.labelEmptyRoom.BackColor = System.Drawing.Color.Lime;
            this.labelEmptyRoom.Location = new System.Drawing.Point(175, 96);
            this.labelEmptyRoom.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelEmptyRoom.Name = "labelEmptyRoom";
            this.labelEmptyRoom.Size = new System.Drawing.Size(26, 29);
            this.labelEmptyRoom.TabIndex = 2;
            this.labelEmptyRoom.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "ห้องไม่ว่าง";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "ห้องว่าง";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1427, 61);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(124, 50);
            this.buttonExit.TabIndex = 40;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1568, 35);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.BackColor = System.Drawing.Color.Lime;
            this.buttonAddRoom.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddRoom.ForeColor = System.Drawing.Color.White;
            this.buttonAddRoom.Location = new System.Drawing.Point(436, 719);
            this.buttonAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(209, 89);
            this.buttonAddRoom.TabIndex = 42;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 659);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 33);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(56, 663);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "เวลาจองห้องเรียน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(57, 721);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "วันที่จองห้องเรียน";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(208, 717);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(208, 33);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // txtClassroomTime
            // 
            this.txtClassroomTime.Location = new System.Drawing.Point(208, 775);
            this.txtClassroomTime.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtClassroomTime.Name = "txtClassroomTime";
            this.txtClassroomTime.Size = new System.Drawing.Size(208, 33);
            this.txtClassroomTime.TabIndex = 48;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 833);
            this.Controls.Add(this.txtClassroomTime);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNumRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button A1;
        private Label label1;
        private DataGridView dataGridView2;
        private Button A2;
        private Button A3;
        private Button A4;
        private Button A5;
        private Button A6;
        private Button A7;
        private Button A8;
        private Button A9;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNameBooking;
        private Label label3;
        private Label label5;
        private TextBox txtNumRoom;
        private GroupBox groupBox2;
        private Label labelBusyRoom;
        private Label labelEmptyRoom;
        private Label label7;
        private Label label6;
        private Button buttonExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Button buttonAddRoom;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn ColumnBookingName;
        private DataGridViewTextBoxColumn ColumnNumRoom;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn ColumnClassRoomTime;
        private Label label4;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private TextBox txtClassroomTime;
    }
}