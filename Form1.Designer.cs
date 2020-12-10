
namespace Elysium_MC_Server_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.path = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Start = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.properties = new System.Windows.Forms.Button();
            this.plugins = new System.Windows.Forms.Button();
            this.RunArgument = new System.Windows.Forms.Button();
            this.Scripts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.path.Location = new System.Drawing.Point(218, 12);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(300, 26);
            this.path.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.Location = new System.Drawing.Point(524, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 26);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(12, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 26);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.go.Location = new System.Drawing.Point(12, 120);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(587, 44);
            this.go.TabIndex = 3;
            this.go.Text = "Start Minecraft Server";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // properties
            // 
            this.properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.properties.Location = new System.Drawing.Point(12, 44);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(290, 32);
            this.properties.TabIndex = 4;
            this.properties.Text = "Server Properties";
            this.properties.UseVisualStyleBackColor = true;
            this.properties.Click += new System.EventHandler(this.properties_Click);
            // 
            // plugins
            // 
            this.plugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plugins.Location = new System.Drawing.Point(309, 44);
            this.plugins.Name = "plugins";
            this.plugins.Size = new System.Drawing.Size(290, 32);
            this.plugins.TabIndex = 5;
            this.plugins.Text = "Plugins";
            this.plugins.UseVisualStyleBackColor = true;
            this.plugins.Click += new System.EventHandler(this.plugins_Click);
            // 
            // RunArgument
            // 
            this.RunArgument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RunArgument.Location = new System.Drawing.Point(12, 82);
            this.RunArgument.Name = "RunArgument";
            this.RunArgument.Size = new System.Drawing.Size(290, 32);
            this.RunArgument.TabIndex = 6;
            this.RunArgument.Text = "Server Run Arguments";
            this.RunArgument.UseVisualStyleBackColor = true;
            this.RunArgument.Click += new System.EventHandler(this.RunArgument_Click);
            // 
            // Scripts
            // 
            this.Scripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Scripts.Location = new System.Drawing.Point(309, 82);
            this.Scripts.Name = "Scripts";
            this.Scripts.Size = new System.Drawing.Size(290, 32);
            this.Scripts.TabIndex = 7;
            this.Scripts.Text = "Scripts";
            this.Scripts.UseVisualStyleBackColor = true;
            this.Scripts.Click += new System.EventHandler(this.Scripts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 175);
            this.Controls.Add(this.Scripts);
            this.Controls.Add(this.RunArgument);
            this.Controls.Add(this.plugins);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.go);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Elysium: Minecraft Server Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button properties;
        private System.Windows.Forms.Button plugins;
        private System.Windows.Forms.Button RunArgument;
        private System.Windows.Forms.Button Scripts;
    }
}

