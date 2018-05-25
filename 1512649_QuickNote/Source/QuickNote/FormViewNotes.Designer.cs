namespace QuickNote
{
    partial class FormViewNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewNotes));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatitisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button_NewNote = new System.Windows.Forms.Button();
            this.button_Statistics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox_Tags = new System.Windows.Forms.ListBox();
            this.listBox_Notes = new System.Windows.Forms.ListBox();
            this.txtBox_Tags = new System.Windows.Forms.TextBox();
            this.txtBox_Content = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteToolStripMenuItem,
            this.viewNotesToolStripMenuItem,
            this.viewStatitisticsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 92);
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.noteToolStripMenuItem.Text = "Note (Window + N)";
            this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
            // 
            // viewNotesToolStripMenuItem
            // 
            this.viewNotesToolStripMenuItem.Name = "viewNotesToolStripMenuItem";
            this.viewNotesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewNotesToolStripMenuItem.Text = "View notes";
            this.viewNotesToolStripMenuItem.Click += new System.EventHandler(this.viewNotesToolStripMenuItem_Click);
            // 
            // viewStatitisticsToolStripMenuItem
            // 
            this.viewStatitisticsToolStripMenuItem.Name = "viewStatitisticsToolStripMenuItem";
            this.viewStatitisticsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewStatitisticsToolStripMenuItem.Text = "View statitistics";
            this.viewStatitisticsToolStripMenuItem.Click += new System.EventHandler(this.viewStatitisticsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Quick Note";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // button_NewNote
            // 
            this.button_NewNote.FlatAppearance.BorderSize = 3;
            this.button_NewNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_NewNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button_NewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewNote.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewNote.ForeColor = System.Drawing.Color.White;
            this.button_NewNote.Location = new System.Drawing.Point(542, 14);
            this.button_NewNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_NewNote.Name = "button_NewNote";
            this.button_NewNote.Size = new System.Drawing.Size(160, 57);
            this.button_NewNote.TabIndex = 3;
            this.button_NewNote.Text = "New note";
            this.button_NewNote.UseVisualStyleBackColor = true;
            this.button_NewNote.Click += new System.EventHandler(this.button_NewNote_Click);
            // 
            // button_Statistics
            // 
            this.button_Statistics.FlatAppearance.BorderSize = 3;
            this.button_Statistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_Statistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Statistics.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Statistics.ForeColor = System.Drawing.Color.White;
            this.button_Statistics.Location = new System.Drawing.Point(730, 14);
            this.button_Statistics.Name = "button_Statistics";
            this.button_Statistics.Size = new System.Drawing.Size(160, 57);
            this.button_Statistics.TabIndex = 4;
            this.button_Statistics.Text = "Statistics";
            this.button_Statistics.UseVisualStyleBackColor = true;
            this.button_Statistics.Click += new System.EventHandler(this.button_Statistics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "TAGS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 90);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // listBox_Tags
            // 
            this.listBox_Tags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listBox_Tags.ForeColor = System.Drawing.Color.White;
            this.listBox_Tags.FormattingEnabled = true;
            this.listBox_Tags.ItemHeight = 20;
            this.listBox_Tags.Location = new System.Drawing.Point(10, 162);
            this.listBox_Tags.Name = "listBox_Tags";
            this.listBox_Tags.Size = new System.Drawing.Size(170, 404);
            this.listBox_Tags.TabIndex = 8;
            this.listBox_Tags.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox_Notes
            // 
            this.listBox_Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listBox_Notes.ForeColor = System.Drawing.Color.White;
            this.listBox_Notes.FormattingEnabled = true;
            this.listBox_Notes.ItemHeight = 20;
            this.listBox_Notes.Location = new System.Drawing.Point(186, 162);
            this.listBox_Notes.Name = "listBox_Notes";
            this.listBox_Notes.Size = new System.Drawing.Size(300, 404);
            this.listBox_Notes.TabIndex = 9;
            this.listBox_Notes.SelectedIndexChanged += new System.EventHandler(this.listBox_Notes_SelectedIndexChanged);
            // 
            // txtBox_Tags
            // 
            this.txtBox_Tags.AutoCompleteCustomSource.AddRange(new string[] {
            "All Notes",
            "Digimon",
            "Digital",
            "Data"});
            this.txtBox_Tags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBox_Tags.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBox_Tags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBox_Tags.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Tags.ForeColor = System.Drawing.Color.White;
            this.txtBox_Tags.Location = new System.Drawing.Point(542, 162);
            this.txtBox_Tags.Name = "txtBox_Tags";
            this.txtBox_Tags.Size = new System.Drawing.Size(430, 26);
            this.txtBox_Tags.TabIndex = 10;
            // 
            // txtBox_Content
            // 
            this.txtBox_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtBox_Content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Content.ForeColor = System.Drawing.Color.White;
            this.txtBox_Content.Location = new System.Drawing.Point(542, 211);
            this.txtBox_Content.Multiline = true;
            this.txtBox_Content.Name = "txtBox_Content";
            this.txtBox_Content.Size = new System.Drawing.Size(430, 355);
            this.txtBox_Content.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(504, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(535, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "FULL CONTENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 84);
            this.label4.TabIndex = 15;
            this.label4.Text = "DIGINOTE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(504, 211);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // button_edit
            // 
            this.button_edit.FlatAppearance.BorderSize = 3;
            this.button_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(842, 99);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(130, 57);
            this.button_edit.TabIndex = 17;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // FormViewNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtBox_Content);
            this.Controls.Add(this.txtBox_Tags);
            this.Controls.Add(this.listBox_Notes);
            this.Controls.Add(this.listBox_Tags);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Statistics);
            this.Controls.Add(this.button_NewNote);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormViewNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewNotes_FormClosing);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatitisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button_NewNote;
        private System.Windows.Forms.Button button_Statistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox_Tags;
        private System.Windows.Forms.ListBox listBox_Notes;
        private System.Windows.Forms.TextBox txtBox_Tags;
        private System.Windows.Forms.TextBox txtBox_Content;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_edit;
    }
}

