namespace Elysium
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Title = new System.Windows.Forms.Label();
            this.Software = new System.Windows.Forms.Button();
            this.Plugins = new System.Windows.Forms.Button();
            this.Skript = new System.Windows.Forms.Button();
            this.Properties = new System.Windows.Forms.Button();
            this.Files = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.engine = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.command = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(800, 60);
            this.Title.TabIndex = 0;
            this.Title.Text = "Server";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Software
            // 
            this.Software.Enabled = false;
            this.Software.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Software.Location = new System.Drawing.Point(12, 108);
            this.Software.Name = "Software";
            this.Software.Size = new System.Drawing.Size(250, 50);
            this.Software.TabIndex = 1;
            this.Software.Text = "Server Software";
            this.Software.UseVisualStyleBackColor = true;
            this.Software.Click += new System.EventHandler(this.Software_Click);
            // 
            // Plugins
            // 
            this.Plugins.Enabled = false;
            this.Plugins.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Plugins.Location = new System.Drawing.Point(12, 164);
            this.Plugins.Name = "Plugins";
            this.Plugins.Size = new System.Drawing.Size(250, 50);
            this.Plugins.TabIndex = 2;
            this.Plugins.Text = "Plugins";
            this.Plugins.UseVisualStyleBackColor = true;
            this.Plugins.Click += new System.EventHandler(this.Plugins_Click);
            // 
            // Skript
            // 
            this.Skript.Enabled = false;
            this.Skript.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Skript.Location = new System.Drawing.Point(12, 220);
            this.Skript.Name = "Skript";
            this.Skript.Size = new System.Drawing.Size(250, 50);
            this.Skript.TabIndex = 3;
            this.Skript.Text = "Skript";
            this.Skript.UseVisualStyleBackColor = true;
            this.Skript.Click += new System.EventHandler(this.Skript_Click);
            // 
            // Properties
            // 
            this.Properties.Enabled = false;
            this.Properties.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Properties.Location = new System.Drawing.Point(12, 276);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(250, 50);
            this.Properties.TabIndex = 4;
            this.Properties.Text = "Properties";
            this.Properties.UseVisualStyleBackColor = true;
            this.Properties.Click += new System.EventHandler(this.Properties_Click);
            // 
            // Files
            // 
            this.Files.Enabled = false;
            this.Files.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Files.Location = new System.Drawing.Point(12, 332);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(250, 50);
            this.Files.TabIndex = 5;
            this.Files.Text = "File Manager";
            this.Files.UseVisualStyleBackColor = true;
            this.Files.Click += new System.EventHandler(this.Files_Click);
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start.Location = new System.Drawing.Point(12, 388);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(250, 50);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // engine
            // 
            this.engine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.engine.Location = new System.Drawing.Point(12, 65);
            this.engine.Name = "engine";
            this.engine.Size = new System.Drawing.Size(250, 40);
            this.engine.TabIndex = 7;
            this.engine.Text = "Engine: Empty";
            this.engine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log.Location = new System.Drawing.Point(268, 63);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(520, 326);
            this.log.TabIndex = 8;
            this.log.Text = "";
            // 
            // command
            // 
            this.command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.command.Enabled = false;
            this.command.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.command.Location = new System.Drawing.Point(268, 395);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(434, 43);
            this.command.TabIndex = 9;
            this.command.TextChanged += new System.EventHandler(this.command_TextChanged);
            this.command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.command_KeyPress);
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send.Enabled = false;
            this.send.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.send.Location = new System.Drawing.Point(708, 395);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(80, 43);
            this.send.TabIndex = 10;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.send);
            this.Controls.Add(this.command);
            this.Controls.Add(this.log);
            this.Controls.Add(this.engine);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.Properties);
            this.Controls.Add(this.Skript);
            this.Controls.Add(this.Plugins);
            this.Controls.Add(this.Software);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Button Software;
        private Button Plugins;
        private Button Skript;
        private Button Properties;
        private Button Files;
        private Button Start;
        private Label engine;
        private RichTextBox log;
        private TextBox command;
        private Button send;
    }
}