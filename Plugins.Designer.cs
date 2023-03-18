namespace Elysium
{
    partial class Plugins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plugins));
            search = new TextBox();
            pluginList = new ListBox();
            buildList = new ListBox();
            go = new Button();
            artifactList = new ListBox();
            SuspendLayout();
            // 
            // search
            // 
            search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            search.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            search.Location = new Point(12, 12);
            search.Name = "search";
            search.Size = new Size(1212, 40);
            search.TabIndex = 0;
            // 
            // pluginList
            // 
            pluginList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pluginList.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            pluginList.FormattingEnabled = true;
            pluginList.ItemHeight = 37;
            pluginList.Location = new Point(12, 58);
            pluginList.Name = "pluginList";
            pluginList.Size = new Size(400, 374);
            pluginList.TabIndex = 1;
            pluginList.SelectedIndexChanged += pluginList_SelectedIndexChanged;
            // 
            // buildList
            // 
            buildList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buildList.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buildList.FormattingEnabled = true;
            buildList.ItemHeight = 37;
            buildList.Location = new Point(418, 58);
            buildList.Name = "buildList";
            buildList.Size = new Size(400, 374);
            buildList.TabIndex = 2;
            buildList.SelectedIndexChanged += buildList_SelectedIndexChanged;
            // 
            // go
            // 
            go.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            go.Enabled = false;
            go.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            go.Location = new Point(12, 438);
            go.Name = "go";
            go.Size = new Size(1212, 46);
            go.TabIndex = 4;
            go.UseVisualStyleBackColor = true;
            go.Click += go_Click;
            // 
            // artifactList
            // 
            artifactList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artifactList.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            artifactList.FormattingEnabled = true;
            artifactList.ItemHeight = 37;
            artifactList.Location = new Point(824, 58);
            artifactList.Name = "artifactList";
            artifactList.Size = new Size(400, 374);
            artifactList.TabIndex = 5;
            artifactList.SelectedIndexChanged += artifactList_SelectedIndexChanged;
            // 
            // Plugins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 497);
            Controls.Add(artifactList);
            Controls.Add(go);
            Controls.Add(buildList);
            Controls.Add(pluginList);
            Controls.Add(search);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Plugins";
            Text = "Plugins";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox search;
        private ListBox pluginList;
        private ListBox buildList;
        private Button go;
        private ListBox artifactList;
    }
}