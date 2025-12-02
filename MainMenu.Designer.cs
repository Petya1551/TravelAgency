namespace TravelAgency
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            headerPanel = new Panel();
            themeBtn = new Button();
            queriesBtn = new Button();
            logoPictureBox = new PictureBox();
            logoTextLabel = new Label();
            menuPanel = new Panel();
            registerBtn = new Button();
            accountBtn = new Button();
            deleteOrderBtn = new Button();
            updateOrderBtn = new Button();
            deleteTourBtn = new Button();
            updateTourBtn = new Button();
            addTour = new Button();
            newOrderBtn = new Button();
            excursionBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            backgroundTimer = new System.Windows.Forms.Timer(components);
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.MidnightBlue;
            headerPanel.Controls.Add(themeBtn);
            headerPanel.Controls.Add(queriesBtn);
            headerPanel.Controls.Add(logoPictureBox);
            headerPanel.Controls.Add(logoTextLabel);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(884, 83);
            headerPanel.TabIndex = 0;
            // 
            // themeBtn
            // 
            themeBtn.BackColor = Color.MidnightBlue;
            themeBtn.Cursor = Cursors.Hand;
            themeBtn.FlatStyle = FlatStyle.Flat;
            themeBtn.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            themeBtn.ForeColor = Color.AliceBlue;
            themeBtn.Location = new Point(841, -10);
            themeBtn.Name = "themeBtn";
            themeBtn.Size = new Size(46, 105);
            themeBtn.TabIndex = 7;
            themeBtn.Text = "☾";
            themeBtn.UseVisualStyleBackColor = false;
            themeBtn.Click += themeBtn_Click;
            // 
            // queriesBtn
            // 
            queriesBtn.BackColor = Color.MidnightBlue;
            queriesBtn.Cursor = Cursors.Hand;
            queriesBtn.FlatStyle = FlatStyle.Flat;
            queriesBtn.Font = new Font("Verdana", 12F, FontStyle.Bold);
            queriesBtn.ForeColor = Color.AliceBlue;
            queriesBtn.Location = new Point(685, -13);
            queriesBtn.Name = "queriesBtn";
            queriesBtn.Size = new Size(158, 108);
            queriesBtn.TabIndex = 6;
            queriesBtn.Text = "Queries";
            queriesBtn.UseVisualStyleBackColor = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Cursor = Cursors.Hand;
            logoPictureBox.Image = Properties.Resources.logoImageIcon;
            logoPictureBox.Location = new Point(17, 5);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(66, 74);
            logoPictureBox.TabIndex = 5;
            logoPictureBox.TabStop = false;
            // 
            // logoTextLabel
            // 
            logoTextLabel.Cursor = Cursors.Hand;
            logoTextLabel.Font = new Font("Sylfaen", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            logoTextLabel.ForeColor = Color.Honeydew;
            logoTextLabel.Location = new Point(82, 13);
            logoTextLabel.Name = "logoTextLabel";
            logoTextLabel.Size = new Size(174, 64);
            logoTextLabel.TabIndex = 4;
            logoTextLabel.Text = "Your Journey, Our Passion";
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Navy;
            menuPanel.Controls.Add(registerBtn);
            menuPanel.Controls.Add(accountBtn);
            menuPanel.Controls.Add(deleteOrderBtn);
            menuPanel.Controls.Add(updateOrderBtn);
            menuPanel.Controls.Add(deleteTourBtn);
            menuPanel.Controls.Add(updateTourBtn);
            menuPanel.Controls.Add(addTour);
            menuPanel.Controls.Add(newOrderBtn);
            menuPanel.Controls.Add(excursionBtn);
            menuPanel.ForeColor = SystemColors.ControlText;
            menuPanel.Location = new Point(0, 89);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(188, 504);
            menuPanel.TabIndex = 1;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.MidnightBlue;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.AliceBlue;
            registerBtn.Location = new Point(-5, 9);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(199, 56);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // accountBtn
            // 
            accountBtn.BackColor = Color.MidnightBlue;
            accountBtn.Cursor = Cursors.Hand;
            accountBtn.FlatStyle = FlatStyle.Flat;
            accountBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountBtn.ForeColor = Color.AliceBlue;
            accountBtn.Location = new Point(-5, 64);
            accountBtn.Name = "accountBtn";
            accountBtn.Size = new Size(199, 56);
            accountBtn.TabIndex = 7;
            accountBtn.Text = "Account";
            accountBtn.UseVisualStyleBackColor = false;
            // 
            // deleteOrderBtn
            // 
            deleteOrderBtn.BackColor = Color.MidnightBlue;
            deleteOrderBtn.Cursor = Cursors.Hand;
            deleteOrderBtn.FlatStyle = FlatStyle.Flat;
            deleteOrderBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteOrderBtn.ForeColor = Color.AliceBlue;
            deleteOrderBtn.Location = new Point(-5, 447);
            deleteOrderBtn.Name = "deleteOrderBtn";
            deleteOrderBtn.Size = new Size(199, 56);
            deleteOrderBtn.TabIndex = 11;
            deleteOrderBtn.Text = "Delete Order";
            deleteOrderBtn.UseVisualStyleBackColor = false;
            // 
            // updateOrderBtn
            // 
            updateOrderBtn.BackColor = Color.MidnightBlue;
            updateOrderBtn.Cursor = Cursors.Hand;
            updateOrderBtn.FlatStyle = FlatStyle.Flat;
            updateOrderBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateOrderBtn.ForeColor = Color.AliceBlue;
            updateOrderBtn.Location = new Point(-5, 392);
            updateOrderBtn.Name = "updateOrderBtn";
            updateOrderBtn.Size = new Size(199, 56);
            updateOrderBtn.TabIndex = 10;
            updateOrderBtn.Text = "Update Order";
            updateOrderBtn.UseVisualStyleBackColor = false;
            // 
            // deleteTourBtn
            // 
            deleteTourBtn.BackColor = Color.MidnightBlue;
            deleteTourBtn.Cursor = Cursors.Hand;
            deleteTourBtn.FlatStyle = FlatStyle.Flat;
            deleteTourBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteTourBtn.ForeColor = Color.AliceBlue;
            deleteTourBtn.Location = new Point(-5, 282);
            deleteTourBtn.Name = "deleteTourBtn";
            deleteTourBtn.Size = new Size(199, 56);
            deleteTourBtn.TabIndex = 9;
            deleteTourBtn.Text = "Delete Tour";
            deleteTourBtn.UseVisualStyleBackColor = false;
            // 
            // updateTourBtn
            // 
            updateTourBtn.BackColor = Color.MidnightBlue;
            updateTourBtn.Cursor = Cursors.Hand;
            updateTourBtn.FlatStyle = FlatStyle.Flat;
            updateTourBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateTourBtn.ForeColor = Color.AliceBlue;
            updateTourBtn.Location = new Point(-5, 227);
            updateTourBtn.Name = "updateTourBtn";
            updateTourBtn.Size = new Size(199, 56);
            updateTourBtn.TabIndex = 8;
            updateTourBtn.Text = "Update Tour";
            updateTourBtn.UseVisualStyleBackColor = false;
            // 
            // addTour
            // 
            addTour.BackColor = Color.MidnightBlue;
            addTour.Cursor = Cursors.Hand;
            addTour.FlatStyle = FlatStyle.Flat;
            addTour.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTour.ForeColor = Color.AliceBlue;
            addTour.Location = new Point(-5, 172);
            addTour.Name = "addTour";
            addTour.Size = new Size(199, 56);
            addTour.TabIndex = 5;
            addTour.Text = "Add Tour";
            addTour.UseVisualStyleBackColor = false;
            addTour.Click += addTour_Click;
            // 
            // newOrderBtn
            // 
            newOrderBtn.BackColor = Color.MidnightBlue;
            newOrderBtn.Cursor = Cursors.Hand;
            newOrderBtn.FlatStyle = FlatStyle.Flat;
            newOrderBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newOrderBtn.ForeColor = Color.AliceBlue;
            newOrderBtn.Location = new Point(-3, 337);
            newOrderBtn.Name = "newOrderBtn";
            newOrderBtn.Size = new Size(197, 56);
            newOrderBtn.TabIndex = 4;
            newOrderBtn.Text = "New Order";
            newOrderBtn.UseVisualStyleBackColor = false;
            // 
            // excursionBtn
            // 
            excursionBtn.BackColor = Color.MidnightBlue;
            excursionBtn.Cursor = Cursors.Hand;
            excursionBtn.FlatStyle = FlatStyle.Flat;
            excursionBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            excursionBtn.ForeColor = Color.AliceBlue;
            excursionBtn.Location = new Point(-3, 118);
            excursionBtn.Name = "excursionBtn";
            excursionBtn.Size = new Size(197, 56);
            excursionBtn.TabIndex = 2;
            excursionBtn.Text = "Excursions";
            excursionBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Location = new Point(0, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 18);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image7;
            pictureBox1.Location = new Point(188, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 509);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // backgroundTimer
            // 
            backgroundTimer.Interval = 5000;
            backgroundTimer.Tick += backgroundTimer_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 591);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Agency";
            Load += MainMenu_Load;
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Panel menuPanel;
        private Button excursionBtn;
        private Panel panel1;
        private Button clientsBtn;
        private Button newOrderBtn;
        private Button addTour;
        private Button registerBtn;
        private Button updateTourBtn;
        private Button accountBtn;
        private Button deleteTourBtn;
        private Button updateOrderBtn;
        private Button deleteOrderBtn;
        private Label logoTextLabel;
        private PictureBox pictureBox1;
        private PictureBox logoPictureBox;
        private Button queriesBtn;
        private Button themeBtn;
        private System.Windows.Forms.Timer backgroundTimer;
    }
}