namespace Dictionary_WF_
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.split = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addb = new System.Windows.Forms.Button();
            this.editb = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.view = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.Contenctext = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.TabPage();
            this.editpanel = new System.Windows.Forms.TableLayoutPanel();
            this.edittext = new System.Windows.Forms.TextBox();
            this.editContent = new System.Windows.Forms.RichTextBox();
            this.editpictures = new System.Windows.Forms.PictureBox();
            this.editpic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.view.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.edit.SuspendLayout();
            this.editpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editpictures)).BeginInit();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.split.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.split.Panel1MinSize = 260;
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.tabControl1);
            this.split.Size = new System.Drawing.Size(829, 461);
            this.split.SplitterDistance = 271;
            this.split.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.addb, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.editb, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.list, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(268, 461);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // addb
            // 
            this.addb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addb.Location = new System.Drawing.Point(3, 424);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(128, 34);
            this.addb.TabIndex = 1;
            this.addb.Text = "Додати";
            this.addb.UseVisualStyleBackColor = true;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // editb
            // 
            this.editb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editb.Enabled = false;
            this.editb.Location = new System.Drawing.Point(137, 424);
            this.editb.Name = "editb";
            this.editb.Size = new System.Drawing.Size(128, 34);
            this.editb.TabIndex = 2;
            this.editb.Text = "Редагувати";
            this.editb.UseVisualStyleBackColor = true;
            this.editb.Click += new System.EventHandler(this.editb_Click);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.search, 2);
            this.search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search.Location = new System.Drawing.Point(3, 3);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(262, 34);
            this.search.TabIndex = 4;
            this.search.Text = "Пошук";
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            this.search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.search_MouseDown);
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.BackColor = System.Drawing.SystemColors.Menu;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.list, 2);
            this.list.FormattingEnabled = true;
            this.list.IntegralHeight = false;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(3, 43);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(262, 375);
            this.list.Sorted = true;
            this.list.TabIndex = 5;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.view);
            this.tabControl1.Controls.Add(this.edit);
            this.tabControl1.Location = new System.Drawing.Point(-1, -38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 499);
            this.tabControl1.TabIndex = 3;
            // 
            // view
            // 
            this.view.Controls.Add(this.tableLayoutPanel1);
            this.view.Location = new System.Drawing.Point(4, 29);
            this.view.Name = "view";
            this.view.Padding = new System.Windows.Forms.Padding(3);
            this.view.Size = new System.Drawing.Size(547, 466);
            this.view.TabIndex = 0;
            this.view.Text = "tabPage1";
            this.view.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picturebox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Contenctext, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 445);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // picturebox
            // 
            this.picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebox.BackColor = System.Drawing.SystemColors.Window;
            this.picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturebox.Location = new System.Drawing.Point(285, 10);
            this.picturebox.Margin = new System.Windows.Forms.Padding(10);
            this.picturebox.Name = "picturebox";
            this.picturebox.Padding = new System.Windows.Forms.Padding(10);
            this.picturebox.Size = new System.Drawing.Size(256, 142);
            this.picturebox.TabIndex = 1;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.picturebox_Click);
            // 
            // Contenctext
            // 
            this.Contenctext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenctext.BackColor = System.Drawing.SystemColors.Window;
            this.Contenctext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.Contenctext, 2);
            this.Contenctext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contenctext.Location = new System.Drawing.Point(3, 165);
            this.Contenctext.Name = "Contenctext";
            this.Contenctext.ReadOnly = true;
            this.Contenctext.Size = new System.Drawing.Size(545, 277);
            this.Contenctext.TabIndex = 0;
            this.Contenctext.Text = "";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(269, 162);
            this.title.TabIndex = 0;
            this.title.Text = "Словник";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit
            // 
            this.edit.Controls.Add(this.editpanel);
            this.edit.Location = new System.Drawing.Point(4, 22);
            this.edit.Name = "edit";
            this.edit.Padding = new System.Windows.Forms.Padding(3);
            this.edit.Size = new System.Drawing.Size(547, 471);
            this.edit.TabIndex = 1;
            this.edit.Text = "tabPage2";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // editpanel
            // 
            this.editpanel.ColumnCount = 2;
            this.editpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.editpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.editpanel.Controls.Add(this.edittext, 0, 0);
            this.editpanel.Controls.Add(this.editContent, 0, 2);
            this.editpanel.Controls.Add(this.editpictures, 1, 0);
            this.editpanel.Controls.Add(this.editpic, 0, 1);
            this.editpanel.Location = new System.Drawing.Point(0, 7);
            this.editpanel.Name = "editpanel";
            this.editpanel.RowCount = 3;
            this.editpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01057F));
            this.editpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.02748F));
            this.editpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.96194F));
            this.editpanel.Size = new System.Drawing.Size(551, 456);
            this.editpanel.TabIndex = 0;
            // 
            // edittext
            // 
            this.edittext.Location = new System.Drawing.Point(3, 3);
            this.edittext.Multiline = true;
            this.edittext.Name = "edittext";
            this.edittext.Size = new System.Drawing.Size(214, 62);
            this.edittext.TabIndex = 0;
            this.edittext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editContent
            // 
            this.editpanel.SetColumnSpan(this.editContent, 2);
            this.editContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editContent.Location = new System.Drawing.Point(3, 157);
            this.editContent.Name = "editContent";
            this.editContent.Size = new System.Drawing.Size(545, 296);
            this.editContent.TabIndex = 2;
            this.editContent.Text = "";
            // 
            // editpictures
            // 
            this.editpictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editpictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editpictures.Location = new System.Drawing.Point(223, 3);
            this.editpictures.Name = "editpictures";
            this.editpanel.SetRowSpan(this.editpictures, 2);
            this.editpictures.Size = new System.Drawing.Size(325, 148);
            this.editpictures.TabIndex = 3;
            this.editpictures.TabStop = false;
            // 
            // editpic
            // 
            this.editpic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editpic.Location = new System.Drawing.Point(3, 71);
            this.editpic.Name = "editpic";
            this.editpic.Size = new System.Drawing.Size(214, 80);
            this.editpic.TabIndex = 1;
            this.editpic.Text = "Завантажити зображення";
            this.editpic.UseVisualStyleBackColor = true;
            this.editpic.Click += new System.EventHandler(this.editpic_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(829, 461);
            this.Controls.Add(this.split);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Main";
            this.Text = "Словник";
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.view.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.edit.ResumeLayout(false);
            this.editpanel.ResumeLayout(false);
            this.editpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editpictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.RichTextBox Contenctext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button editb;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage view;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabPage edit;
        private System.Windows.Forms.TableLayoutPanel editpanel;
        private System.Windows.Forms.TextBox edittext;
        private System.Windows.Forms.Button editpic;
        private System.Windows.Forms.RichTextBox editContent;
        private System.Windows.Forms.PictureBox editpictures;
        private System.Windows.Forms.ListBox list;
    }
}

