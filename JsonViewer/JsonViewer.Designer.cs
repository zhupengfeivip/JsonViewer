namespace EPocalipse.Json.Viewer
{
    partial class JsonViewer
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonViewer));
            this.spcViewer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtJson = new EPocalipse.Json.Viewer.TextEditorControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxQuoteName = new System.Windows.Forms.CheckBox();
            this.numIndentation = new System.Windows.Forms.NumericUpDown();
            this.cbxIndented = new System.Windows.Forms.CheckBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.lbxHistory = new System.Windows.Forms.ListBox();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.btnExpanded = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.tvJson = new System.Windows.Forms.TreeView();
            this.mnuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyKey = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyValue = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnCloseFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.pnlVisualizer = new System.Windows.Forms.Panel();
            this.mnuVisualizerPnl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShowOnRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowOnBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.cbVisualizers = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageTreeView = new System.Windows.Forms.TabPage();
            this.pageTextView = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.btnStripToCurly = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStripToSqr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.removenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSpecialCharsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblError = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.spcViewer)).BeginInit();
            this.spcViewer.Panel1.SuspendLayout();
            this.spcViewer.Panel2.SuspendLayout();
            this.spcViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndentation)).BeginInit();
            this.mnuTree.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.mnuVisualizerPnl.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageTreeView.SuspendLayout();
            this.pageTextView.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcViewer
            // 
            this.spcViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcViewer.Location = new System.Drawing.Point(3, 3);
            this.spcViewer.Name = "spcViewer";
            // 
            // spcViewer.Panel1
            // 
            this.spcViewer.Panel1.Controls.Add(this.splitContainer1);
            this.spcViewer.Panel1.Controls.Add(this.pnlFind);
            // 
            // spcViewer.Panel2
            // 
            this.spcViewer.Panel2.Controls.Add(this.pnlVisualizer);
            this.spcViewer.Panel2.Controls.Add(this.cbVisualizers);
            this.spcViewer.Size = new System.Drawing.Size(778, 526);
            this.spcViewer.SplitterDistance = 621;
            this.spcViewer.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtJson);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvJson);
            this.splitContainer1.Size = new System.Drawing.Size(621, 496);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 7;
            // 
            // txtJson
            // 
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.IsReadOnly = false;
            this.txtJson.Location = new System.Drawing.Point(0, 0);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(238, 496);
            this.txtJson.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxQuoteName);
            this.panel1.Controls.Add(this.numIndentation);
            this.panel1.Controls.Add(this.cbxIndented);
            this.panel1.Controls.Add(this.btnFormat);
            this.panel1.Controls.Add(this.lbxHistory);
            this.panel1.Controls.Add(this.btnCollapseAll);
            this.panel1.Controls.Add(this.btnExpanded);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnPaste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(238, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 496);
            this.panel1.TabIndex = 0;
            // 
            // cbxQuoteName
            // 
            this.cbxQuoteName.AutoSize = true;
            this.cbxQuoteName.Checked = true;
            this.cbxQuoteName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxQuoteName.Location = new System.Drawing.Point(9, 243);
            this.cbxQuoteName.Name = "cbxQuoteName";
            this.cbxQuoteName.Size = new System.Drawing.Size(72, 16);
            this.cbxQuoteName.TabIndex = 8;
            this.cbxQuoteName.Text = "name引号";
            this.cbxQuoteName.UseVisualStyleBackColor = true;
            // 
            // numIndentation
            // 
            this.numIndentation.Location = new System.Drawing.Point(14, 37);
            this.numIndentation.Name = "numIndentation";
            this.numIndentation.Size = new System.Drawing.Size(57, 21);
            this.numIndentation.TabIndex = 7;
            this.numIndentation.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cbxIndented
            // 
            this.cbxIndented.AutoSize = true;
            this.cbxIndented.Checked = true;
            this.cbxIndented.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIndented.Location = new System.Drawing.Point(14, 15);
            this.cbxIndented.Name = "cbxIndented";
            this.cbxIndented.Size = new System.Drawing.Size(48, 16);
            this.cbxIndented.TabIndex = 6;
            this.cbxIndented.Text = "缩进";
            this.cbxIndented.UseVisualStyleBackColor = true;
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(14, 91);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(75, 23);
            this.btnFormat.TabIndex = 5;
            this.btnFormat.Text = "格式化";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // lbxHistory
            // 
            this.lbxHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxHistory.FormattingEnabled = true;
            this.lbxHistory.ItemHeight = 12;
            this.lbxHistory.Location = new System.Drawing.Point(0, 276);
            this.lbxHistory.Name = "lbxHistory";
            this.lbxHistory.Size = new System.Drawing.Size(103, 220);
            this.lbxHistory.TabIndex = 4;
            this.lbxHistory.DoubleClick += new System.EventHandler(this.lbxHistory_DoubleClick);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Location = new System.Drawing.Point(14, 207);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(75, 23);
            this.btnCollapseAll.TabIndex = 3;
            this.btnCollapseAll.Text = "折叠";
            this.btnCollapseAll.UseVisualStyleBackColor = true;
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // btnExpanded
            // 
            this.btnExpanded.Location = new System.Drawing.Point(14, 178);
            this.btnExpanded.Name = "btnExpanded";
            this.btnExpanded.Size = new System.Drawing.Size(75, 23);
            this.btnExpanded.TabIndex = 2;
            this.btnExpanded.Text = "展开";
            this.btnExpanded.UseVisualStyleBackColor = true;
            this.btnExpanded.Click += new System.EventHandler(this.btnExpanded_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(14, 120);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(14, 149);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 0;
            this.btnPaste.Text = "粘贴";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // tvJson
            // 
            this.tvJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvJson.ContextMenuStrip = this.mnuTree;
            this.tvJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvJson.HideSelection = false;
            this.tvJson.ImageIndex = 0;
            this.tvJson.ImageList = this.imgList;
            this.tvJson.Location = new System.Drawing.Point(0, 0);
            this.tvJson.Name = "tvJson";
            this.tvJson.SelectedImageIndex = 0;
            this.tvJson.Size = new System.Drawing.Size(276, 496);
            this.tvJson.TabIndex = 3;
            this.tvJson.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvJson_BeforeExpand);
            this.tvJson.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvJson_AfterSelect);
            this.tvJson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JsonViewer_KeyDown);
            this.tvJson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvJson_MouseDown);
            // 
            // mnuTree
            // 
            this.mnuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFind,
            this.mnuExpandAll,
            this.toolStripMenuItem1,
            this.mnuCopy,
            this.mnuCopyKey,
            this.mnuCopyValue});
            this.mnuTree.Name = "mnuTree";
            this.mnuTree.Size = new System.Drawing.Size(143, 120);
            this.mnuTree.Opening += new System.ComponentModel.CancelEventHandler(this.mnuTree_Opening);
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(142, 22);
            this.mnuFind.Text = "&Find";
            this.mnuFind.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // mnuExpandAll
            // 
            this.mnuExpandAll.Name = "mnuExpandAll";
            this.mnuExpandAll.Size = new System.Drawing.Size(142, 22);
            this.mnuExpandAll.Text = "Expand &All";
            this.mnuExpandAll.Click += new System.EventHandler(this.expandallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(142, 22);
            this.mnuCopy.Text = "&Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuCopyKey
            // 
            this.mnuCopyKey.Name = "mnuCopyKey";
            this.mnuCopyKey.Size = new System.Drawing.Size(142, 22);
            this.mnuCopyKey.Text = "Copy &Key";
            this.mnuCopyKey.Click += new System.EventHandler(this.mnuCopyKey_Click);
            // 
            // mnuCopyValue
            // 
            this.mnuCopyValue.Name = "mnuCopyValue";
            this.mnuCopyValue.Size = new System.Drawing.Size(142, 22);
            this.mnuCopyValue.Text = "Copy &Value";
            this.mnuCopyValue.Click += new System.EventHandler(this.mnuCopyValue_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.White;
            this.imgList.Images.SetKeyName(0, "obj.bmp");
            this.imgList.Images.SetKeyName(1, "array.bmp");
            this.imgList.Images.SetKeyName(2, "prop.bmp");
            // 
            // pnlFind
            // 
            this.pnlFind.Controls.Add(this.btnCloseFind);
            this.pnlFind.Controls.Add(this.txtFind);
            this.pnlFind.Controls.Add(this.lblFind);
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFind.Location = new System.Drawing.Point(0, 496);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(621, 30);
            this.pnlFind.TabIndex = 6;
            // 
            // btnCloseFind
            // 
            this.btnCloseFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseFind.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseFind.BackgroundImage")));
            this.btnCloseFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseFind.FlatAppearance.BorderSize = 0;
            this.btnCloseFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFind.Location = new System.Drawing.Point(594, 6);
            this.btnCloseFind.Name = "btnCloseFind";
            this.btnCloseFind.Size = new System.Drawing.Size(16, 15);
            this.btnCloseFind.TabIndex = 2;
            this.btnCloseFind.UseVisualStyleBackColor = false;
            this.btnCloseFind.Click += new System.EventHandler(this.btnCloseFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Location = new System.Drawing.Point(32, 6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(548, 21);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(3, 8);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(29, 12);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "&Find";
            // 
            // pnlVisualizer
            // 
            this.pnlVisualizer.ContextMenuStrip = this.mnuVisualizerPnl;
            this.pnlVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVisualizer.Location = new System.Drawing.Point(0, 20);
            this.pnlVisualizer.Name = "pnlVisualizer";
            this.pnlVisualizer.Size = new System.Drawing.Size(153, 506);
            this.pnlVisualizer.TabIndex = 6;
            // 
            // mnuVisualizerPnl
            // 
            this.mnuVisualizerPnl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowOnRight,
            this.mnuShowOnBottom});
            this.mnuVisualizerPnl.Name = "mnuVisualizerPnl";
            this.mnuVisualizerPnl.Size = new System.Drawing.Size(120, 48);
            // 
            // mnuShowOnRight
            // 
            this.mnuShowOnRight.Checked = true;
            this.mnuShowOnRight.CheckOnClick = true;
            this.mnuShowOnRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuShowOnRight.Name = "mnuShowOnRight";
            this.mnuShowOnRight.Size = new System.Drawing.Size(119, 22);
            this.mnuShowOnRight.Text = "&Right";
            this.mnuShowOnRight.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // mnuShowOnBottom
            // 
            this.mnuShowOnBottom.CheckOnClick = true;
            this.mnuShowOnBottom.Name = "mnuShowOnBottom";
            this.mnuShowOnBottom.Size = new System.Drawing.Size(119, 22);
            this.mnuShowOnBottom.Text = "&Bottom";
            this.mnuShowOnBottom.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // cbVisualizers
            // 
            this.cbVisualizers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbVisualizers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisualizers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbVisualizers.FormattingEnabled = true;
            this.cbVisualizers.Location = new System.Drawing.Point(0, 0);
            this.cbVisualizers.Name = "cbVisualizers";
            this.cbVisualizers.Size = new System.Drawing.Size(153, 20);
            this.cbVisualizers.Sorted = true;
            this.cbVisualizers.TabIndex = 7;
            this.cbVisualizers.SelectedIndexChanged += new System.EventHandler(this.cbVisualizers_SelectedIndexChanged);
            this.cbVisualizers.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbVisualizers_Format);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageTreeView);
            this.tabControl.Controls.Add(this.pageTextView);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(792, 558);
            this.tabControl.TabIndex = 6;
            // 
            // pageTreeView
            // 
            this.pageTreeView.Controls.Add(this.spcViewer);
            this.pageTreeView.Location = new System.Drawing.Point(4, 22);
            this.pageTreeView.Name = "pageTreeView";
            this.pageTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.pageTreeView.Size = new System.Drawing.Size(784, 532);
            this.pageTreeView.TabIndex = 0;
            this.pageTreeView.Text = "Viewer";
            this.pageTreeView.UseVisualStyleBackColor = true;
            // 
            // pageTextView
            // 
            this.pageTextView.Controls.Add(this.toolStrip1);
            this.pageTextView.Controls.Add(this.lblError);
            this.pageTextView.Location = new System.Drawing.Point(4, 22);
            this.pageTextView.Name = "pageTextView";
            this.pageTextView.Padding = new System.Windows.Forms.Padding(3);
            this.pageTextView.Size = new System.Drawing.Size(784, 532);
            this.pageTextView.TabIndex = 1;
            this.pageTextView.Text = "Text";
            this.pageTextView.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnStrip,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStrip
            // 
            this.btnStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStripToCurly,
            this.btnStripToSqr});
            this.btnStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnStrip.Image")));
            this.btnStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStrip.Name = "btnStrip";
            this.btnStrip.Size = new System.Drawing.Size(79, 22);
            this.btnStrip.Text = "Strip to {}";
            this.btnStrip.ButtonClick += new System.EventHandler(this.btnStripToCurly_Click);
            // 
            // btnStripToCurly
            // 
            this.btnStripToCurly.Name = "btnStripToCurly";
            this.btnStripToCurly.Size = new System.Drawing.Size(131, 22);
            this.btnStripToCurly.Text = "Strip to {}";
            this.btnStripToCurly.Click += new System.EventHandler(this.btnStripToCurly_Click);
            // 
            // btnStripToSqr
            // 
            this.btnStripToSqr.Name = "btnStripToSqr";
            this.btnStripToSqr.Size = new System.Drawing.Size(131, 22);
            this.btnStripToSqr.Text = "Strip to []";
            this.btnStripToSqr.Click += new System.EventHandler(this.btnStripToSqr_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removenToolStripMenuItem,
            this.removeSpecialCharsToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(152, 22);
            this.toolStripSplitButton1.Text = "Remove new lines (\\n)";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.removeNewLineMenuItem_Click);
            // 
            // removenToolStripMenuItem
            // 
            this.removenToolStripMenuItem.Name = "removenToolStripMenuItem";
            this.removenToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.removenToolStripMenuItem.Text = "Remove new lines (\\n)";
            this.removenToolStripMenuItem.Click += new System.EventHandler(this.removeNewLineMenuItem_Click);
            // 
            // removeSpecialCharsToolStripMenuItem
            // 
            this.removeSpecialCharsToolStripMenuItem.Name = "removeSpecialCharsToolStripMenuItem";
            this.removeSpecialCharsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.removeSpecialCharsToolStripMenuItem.Text = "Remove special chars (\\)";
            this.removeSpecialCharsToolStripMenuItem.Click += new System.EventHandler(this.removeSpecialCharsToolStripMenuItem_Click);
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblError.LinkColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 507);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(778, 22);
            this.lblError.TabIndex = 5;
            this.lblError.TabStop = true;
            this.lblError.Text = "aa";
            this.lblError.VisitedLinkColor = System.Drawing.Color.Red;
            this.lblError.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblError_LinkClicked);
            // 
            // JsonViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "JsonViewer";
            this.Size = new System.Drawing.Size(792, 558);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JsonViewer_KeyDown);
            this.spcViewer.Panel1.ResumeLayout(false);
            this.spcViewer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcViewer)).EndInit();
            this.spcViewer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndentation)).EndInit();
            this.mnuTree.ResumeLayout(false);
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            this.mnuVisualizerPnl.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.pageTreeView.ResumeLayout(false);
            this.pageTextView.ResumeLayout(false);
            this.pageTextView.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcViewer;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TreeView tvJson;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageTreeView;
        private System.Windows.Forms.TabPage pageTextView;
        private System.Windows.Forms.LinkLabel lblError;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnStrip;
        private System.Windows.Forms.ToolStripMenuItem btnStripToCurly;
        private System.Windows.Forms.ToolStripMenuItem btnStripToSqr;
        private System.Windows.Forms.Panel pnlVisualizer;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnCloseFind;
        private System.Windows.Forms.ContextMenuStrip mnuTree;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuExpandAll;
        private System.Windows.Forms.ContextMenuStrip mnuVisualizerPnl;
        private System.Windows.Forms.ToolStripMenuItem mnuShowOnRight;
        private System.Windows.Forms.ToolStripMenuItem mnuShowOnBottom;
        private System.Windows.Forms.ComboBox cbVisualizers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyValue;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem removenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSpecialCharsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.Button btnExpanded;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ListBox lbxHistory;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyKey;
        private TextEditorControl txtJson;
        private System.Windows.Forms.CheckBox cbxIndented;
        private System.Windows.Forms.NumericUpDown numIndentation;
        private System.Windows.Forms.CheckBox cbxQuoteName;
    }
}
