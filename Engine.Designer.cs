namespace Elysium
{
    partial class Engine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engine));
            this.engines = new System.Windows.Forms.ListBox();
            this.versions = new System.Windows.Forms.ListBox();
            this.builds = new System.Windows.Forms.ListBox();
            this.go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // engines
            // 
            this.engines.Enabled = false;
            this.engines.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.engines.FormattingEnabled = true;
            this.engines.ItemHeight = 37;
            this.engines.Location = new System.Drawing.Point(12, 12);
            this.engines.Name = "engines";
            this.engines.Size = new System.Drawing.Size(200, 374);
            this.engines.TabIndex = 0;
            this.engines.SelectedIndexChanged += new System.EventHandler(this.engines_SelectedIndexChanged);
            // 
            // versions
            // 
            this.versions.Enabled = false;
            this.versions.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versions.FormattingEnabled = true;
            this.versions.ItemHeight = 37;
            this.versions.Location = new System.Drawing.Point(218, 12);
            this.versions.Name = "versions";
            this.versions.Size = new System.Drawing.Size(200, 374);
            this.versions.TabIndex = 1;
            this.versions.SelectedIndexChanged += new System.EventHandler(this.versions_SelectedIndexChanged);
            // 
            // builds
            // 
            this.builds.Enabled = false;
            this.builds.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.builds.FormattingEnabled = true;
            this.builds.ItemHeight = 37;
            this.builds.Location = new System.Drawing.Point(424, 12);
            this.builds.Name = "builds";
            this.builds.Size = new System.Drawing.Size(200, 374);
            this.builds.TabIndex = 2;
            this.builds.SelectedIndexChanged += new System.EventHandler(this.builds_SelectedIndexChanged);
            // 
            // go
            // 
            this.go.Enabled = false;
            this.go.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.go.Location = new System.Drawing.Point(12, 392);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(612, 46);
            this.go.TabIndex = 3;
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // Engine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 451);
            this.Controls.Add(this.go);
            this.Controls.Add(this.builds);
            this.Controls.Add(this.versions);
            this.Controls.Add(this.engines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Engine";
            this.Text = "Engine";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox engines;
        private ListBox versions;
        private ListBox builds;
        private Button go;
    }
}