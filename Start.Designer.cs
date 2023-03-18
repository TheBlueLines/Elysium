namespace Elysium
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            title = new Label();
            Servers = new ListBox();
            New = new Button();
            Rename = new Button();
            Remove = new Button();
            Dashboard = new Button();
            info = new Label();
            Remote = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(800, 150);
            title.TabIndex = 0;
            title.Text = "Elysium";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // Servers
            // 
            Servers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Servers.BorderStyle = BorderStyle.FixedSingle;
            Servers.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Servers.FormattingEnabled = true;
            Servers.ItemHeight = 37;
            Servers.Location = new Point(12, 177);
            Servers.Name = "Servers";
            Servers.Size = new Size(193, 261);
            Servers.TabIndex = 1;
            Servers.SelectedIndexChanged += Servers_SelectedIndexChanged;
            // 
            // New
            // 
            New.Enabled = false;
            New.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            New.Location = new Point(211, 164);
            New.Name = "New";
            New.Size = new Size(200, 50);
            New.TabIndex = 2;
            New.Text = "New Server";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Rename
            // 
            Rename.Enabled = false;
            Rename.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Rename.Location = new Point(211, 276);
            Rename.Name = "Rename";
            Rename.Size = new Size(200, 50);
            Rename.TabIndex = 3;
            Rename.Text = "Rename Server";
            Rename.UseVisualStyleBackColor = true;
            Rename.Click += Rename_Click;
            // 
            // Remove
            // 
            Remove.Enabled = false;
            Remove.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Remove.Location = new Point(211, 220);
            Remove.Name = "Remove";
            Remove.Size = new Size(200, 50);
            Remove.TabIndex = 4;
            Remove.Text = "Delete Server";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // Dashboard
            // 
            Dashboard.Enabled = false;
            Dashboard.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Dashboard.Location = new Point(211, 332);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(200, 50);
            Dashboard.TabIndex = 5;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = true;
            Dashboard.Click += Dashboard_Click;
            // 
            // info
            // 
            info.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            info.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            info.Location = new Point(417, 177);
            info.Name = "info";
            info.Size = new Size(371, 261);
            info.TabIndex = 6;
            info.Text = "Loading...";
            info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Remote
            // 
            Remote.Enabled = false;
            Remote.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Remote.Location = new Point(211, 388);
            Remote.Name = "Remote";
            Remote.Size = new Size(200, 50);
            Remote.TabIndex = 7;
            Remote.Text = "Remote";
            Remote.UseVisualStyleBackColor = true;
            Remote.Click += Remote_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Remote);
            Controls.Add(info);
            Controls.Add(Dashboard);
            Controls.Add(Remove);
            Controls.Add(Rename);
            Controls.Add(New);
            Controls.Add(Servers);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Start";
            Text = "Elysium";
            FormClosing += Start_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private ListBox Servers;
        private Button New;
        private Button Rename;
        private Button Remove;
        private Button Dashboard;
        private Label info;
        private Button Remote;
    }
}