namespace BotanicalReferenceStandardsEditor
{
    partial class MainForm
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.searchTab = new System.Windows.Forms.TabControl();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.editSuccessLabel = new System.Windows.Forms.Label();
            this.removeSuccessLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.resultFailedLabel = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
            this.commonHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botanicalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.providerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.catalogHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lotHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pureHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.receivedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expireHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTermLabel = new System.Windows.Forms.Label();
            this.searchBoxLabel = new System.Windows.Forms.Label();
            this.searchStyleBox = new System.Windows.Forms.ComboBox();
            this.addPage = new System.Windows.Forms.TabPage();
            this.barCodeLabel = new System.Windows.Forms.Label();
            this.barCodeText = new System.Windows.Forms.TextBox();
            this.blankLabel = new System.Windows.Forms.Label();
            this.addSuccessLabel = new System.Windows.Forms.Label();
            this.providerText = new System.Windows.Forms.TextBox();
            this.providerLabel = new System.Windows.Forms.Label();
            this.purityText = new System.Windows.Forms.TextBox();
            this.purityLabel = new System.Windows.Forms.Label();
            this.catalogLabel = new System.Windows.Forms.Label();
            this.lotLabel = new System.Windows.Forms.Label();
            this.locationText = new System.Windows.Forms.TextBox();
            this.receivedText = new System.Windows.Forms.TextBox();
            this.partLabel = new System.Windows.Forms.Label();
            this.expireText = new System.Windows.Forms.TextBox();
            this.partText = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.receiveOnLabel = new System.Windows.Forms.Label();
            this.expireLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.botanicalLabel = new System.Windows.Forms.Label();
            this.commonLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.amountText = new System.Windows.Forms.TextBox();
            this.lotText = new System.Windows.Forms.TextBox();
            this.catalogText = new System.Windows.Forms.TextBox();
            this.botanicalText = new System.Windows.Forms.TextBox();
            this.commonText = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.searchTab.SuspendLayout();
            this.searchPage.SuspendLayout();
            this.addPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(125, 49);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(117, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.Tag = "";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(167, 84);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(197, 422);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchTab
            // 
            this.searchTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTab.Controls.Add(this.searchPage);
            this.searchTab.Controls.Add(this.addPage);
            this.searchTab.Location = new System.Drawing.Point(12, 12);
            this.searchTab.Name = "searchTab";
            this.searchTab.SelectedIndex = 0;
            this.searchTab.Size = new System.Drawing.Size(260, 408);
            this.searchTab.TabIndex = 3;
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.editSuccessLabel);
            this.searchPage.Controls.Add(this.removeSuccessLabel);
            this.searchPage.Controls.Add(this.editButton);
            this.searchPage.Controls.Add(this.removeButton);
            this.searchPage.Controls.Add(this.resultFailedLabel);
            this.searchPage.Controls.Add(this.resultListView);
            this.searchPage.Controls.Add(this.searchTermLabel);
            this.searchPage.Controls.Add(this.searchBoxLabel);
            this.searchPage.Controls.Add(this.searchStyleBox);
            this.searchPage.Controls.Add(this.searchBox);
            this.searchPage.Controls.Add(this.searchButton);
            this.searchPage.Location = new System.Drawing.Point(4, 22);
            this.searchPage.Name = "searchPage";
            this.searchPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPage.Size = new System.Drawing.Size(252, 382);
            this.searchPage.TabIndex = 0;
            this.searchPage.Text = "Search Reference";
            this.searchPage.UseVisualStyleBackColor = true;
            // 
            // editSuccessLabel
            // 
            this.editSuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSuccessLabel.AutoSize = true;
            this.editSuccessLabel.Location = new System.Drawing.Point(94, 358);
            this.editSuccessLabel.Name = "editSuccessLabel";
            this.editSuccessLabel.Size = new System.Drawing.Size(0, 13);
            this.editSuccessLabel.TabIndex = 10;
            // 
            // removeSuccessLabel
            // 
            this.removeSuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSuccessLabel.AutoSize = true;
            this.removeSuccessLabel.Location = new System.Drawing.Point(82, 358);
            this.removeSuccessLabel.Name = "removeSuccessLabel";
            this.removeSuccessLabel.Size = new System.Drawing.Size(0, 13);
            this.removeSuccessLabel.TabIndex = 9;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(86, 327);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(167, 327);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // resultFailedLabel
            // 
            this.resultFailedLabel.AutoSize = true;
            this.resultFailedLabel.Location = new System.Drawing.Point(78, 89);
            this.resultFailedLabel.Name = "resultFailedLabel";
            this.resultFailedLabel.Size = new System.Drawing.Size(0, 13);
            this.resultFailedLabel.TabIndex = 6;
            // 
            // resultListView
            // 
            this.resultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.commonHeader,
            this.botanicalHeader,
            this.partHeader,
            this.providerHeader,
            this.catalogHeader,
            this.lotHeader,
            this.amountHeader,
            this.pureHeader,
            this.receivedHeader,
            this.expireHeader,
            this.locationHeader,
            this.barCodeHeader});
            this.resultListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultListView.FullRowSelect = true;
            this.resultListView.GridLines = true;
            this.resultListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.resultListView.Location = new System.Drawing.Point(7, 123);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(235, 198);
            this.resultListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.resultListView.TabIndex = 5;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            this.resultListView.SelectedIndexChanged += new System.EventHandler(this.resultListView_SelectedIndexChanged);
            // 
            // commonHeader
            // 
            this.commonHeader.Text = "Common Name";
            this.commonHeader.Width = 85;
            // 
            // botanicalHeader
            // 
            this.botanicalHeader.Text = "Botanical Name";
            this.botanicalHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.botanicalHeader.Width = 90;
            // 
            // partHeader
            // 
            this.partHeader.Text = "Plant Part";
            this.partHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partHeader.Width = 65;
            // 
            // providerHeader
            // 
            this.providerHeader.Text = "Supplier";
            this.providerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // catalogHeader
            // 
            this.catalogHeader.Text = "Catalog Number";
            this.catalogHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.catalogHeader.Width = 90;
            // 
            // lotHeader
            // 
            this.lotHeader.Text = "Lot Number";
            this.lotHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lotHeader.Width = 70;
            // 
            // amountHeader
            // 
            this.amountHeader.Text = "Quantity";
            this.amountHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountHeader.Width = 55;
            // 
            // pureHeader
            // 
            this.pureHeader.Text = "Purity";
            this.pureHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // receivedHeader
            // 
            this.receivedHeader.Text = "Received Date";
            this.receivedHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.receivedHeader.Width = 90;
            // 
            // expireHeader
            // 
            this.expireHeader.Text = "Expiration Date";
            this.expireHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expireHeader.Width = 90;
            // 
            // locationHeader
            // 
            this.locationHeader.Text = "Location";
            this.locationHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // barCodeHeader
            // 
            this.barCodeHeader.Text = "Barcode";
            this.barCodeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchTermLabel
            // 
            this.searchTermLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTermLabel.AutoSize = true;
            this.searchTermLabel.Location = new System.Drawing.Point(48, 52);
            this.searchTermLabel.Name = "searchTermLabel";
            this.searchTermLabel.Size = new System.Drawing.Size(71, 13);
            this.searchTermLabel.TabIndex = 4;
            this.searchTermLabel.Text = "Search Term:";
            // 
            // searchBoxLabel
            // 
            this.searchBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBoxLabel.AutoSize = true;
            this.searchBoxLabel.Location = new System.Drawing.Point(61, 25);
            this.searchBoxLabel.Name = "searchBoxLabel";
            this.searchBoxLabel.Size = new System.Drawing.Size(58, 13);
            this.searchBoxLabel.TabIndex = 3;
            this.searchBoxLabel.Text = "Search by:";
            // 
            // searchStyleBox
            // 
            this.searchStyleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStyleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchStyleBox.FormattingEnabled = true;
            this.searchStyleBox.Items.AddRange(new object[] {
            "Common Name",
            "Botanical Name",
            "Plant Part",
            "Supplier",
            "Catalog Number",
            "Lot Number",
            "Received Date",
            "Expiration Date",
            "Location",
            "Barcode"});
            this.searchStyleBox.Location = new System.Drawing.Point(125, 22);
            this.searchStyleBox.Name = "searchStyleBox";
            this.searchStyleBox.Size = new System.Drawing.Size(117, 21);
            this.searchStyleBox.TabIndex = 0;
            this.searchStyleBox.SelectedIndexChanged += new System.EventHandler(this.searchStyleBox_SelectedIndexChanged);
            // 
            // addPage
            // 
            this.addPage.BackColor = System.Drawing.Color.White;
            this.addPage.Controls.Add(this.barCodeLabel);
            this.addPage.Controls.Add(this.barCodeText);
            this.addPage.Controls.Add(this.blankLabel);
            this.addPage.Controls.Add(this.addSuccessLabel);
            this.addPage.Controls.Add(this.providerText);
            this.addPage.Controls.Add(this.providerLabel);
            this.addPage.Controls.Add(this.purityText);
            this.addPage.Controls.Add(this.purityLabel);
            this.addPage.Controls.Add(this.catalogLabel);
            this.addPage.Controls.Add(this.lotLabel);
            this.addPage.Controls.Add(this.locationText);
            this.addPage.Controls.Add(this.receivedText);
            this.addPage.Controls.Add(this.partLabel);
            this.addPage.Controls.Add(this.expireText);
            this.addPage.Controls.Add(this.partText);
            this.addPage.Controls.Add(this.locationLabel);
            this.addPage.Controls.Add(this.receiveOnLabel);
            this.addPage.Controls.Add(this.expireLabel);
            this.addPage.Controls.Add(this.amountLabel);
            this.addPage.Controls.Add(this.botanicalLabel);
            this.addPage.Controls.Add(this.commonLabel);
            this.addPage.Controls.Add(this.addButton);
            this.addPage.Controls.Add(this.amountText);
            this.addPage.Controls.Add(this.lotText);
            this.addPage.Controls.Add(this.catalogText);
            this.addPage.Controls.Add(this.botanicalText);
            this.addPage.Controls.Add(this.commonText);
            this.addPage.Location = new System.Drawing.Point(4, 22);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(252, 382);
            this.addPage.TabIndex = 1;
            this.addPage.Text = "Add Reference";
            // 
            // barCodeLabel
            // 
            this.barCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.barCodeLabel.AutoSize = true;
            this.barCodeLabel.Location = new System.Drawing.Point(90, 328);
            this.barCodeLabel.Name = "barCodeLabel";
            this.barCodeLabel.Size = new System.Drawing.Size(50, 13);
            this.barCodeLabel.TabIndex = 26;
            this.barCodeLabel.Text = "Barcode:";
            // 
            // barCodeText
            // 
            this.barCodeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.barCodeText.Location = new System.Drawing.Point(146, 325);
            this.barCodeText.Name = "barCodeText";
            this.barCodeText.Size = new System.Drawing.Size(100, 20);
            this.barCodeText.TabIndex = 11;
            // 
            // blankLabel
            // 
            this.blankLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.blankLabel.AutoSize = true;
            this.blankLabel.Location = new System.Drawing.Point(73, 13);
            this.blankLabel.Name = "blankLabel";
            this.blankLabel.Size = new System.Drawing.Size(173, 13);
            this.blankLabel.TabIndex = 24;
            this.blankLabel.Text = "Leave entry blank if unsure or N/A.";
            // 
            // addSuccessLabel
            // 
            this.addSuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addSuccessLabel.AutoSize = true;
            this.addSuccessLabel.Location = new System.Drawing.Point(3, 358);
            this.addSuccessLabel.Name = "addSuccessLabel";
            this.addSuccessLabel.Size = new System.Drawing.Size(0, 13);
            this.addSuccessLabel.TabIndex = 23;
            // 
            // providerText
            // 
            this.providerText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.providerText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.providerText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.providerText.Location = new System.Drawing.Point(146, 117);
            this.providerText.Name = "providerText";
            this.providerText.Size = new System.Drawing.Size(100, 20);
            this.providerText.TabIndex = 3;
            // 
            // providerLabel
            // 
            this.providerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(89, 120);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(48, 13);
            this.providerLabel.TabIndex = 21;
            this.providerLabel.Text = "Supplier:";
            // 
            // purityText
            // 
            this.purityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.purityText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.purityText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.purityText.Location = new System.Drawing.Point(146, 221);
            this.purityText.Name = "purityText";
            this.purityText.Size = new System.Drawing.Size(100, 20);
            this.purityText.TabIndex = 7;
            // 
            // purityLabel
            // 
            this.purityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.purityLabel.AutoSize = true;
            this.purityLabel.Location = new System.Drawing.Point(104, 224);
            this.purityLabel.Name = "purityLabel";
            this.purityLabel.Size = new System.Drawing.Size(36, 13);
            this.purityLabel.TabIndex = 19;
            this.purityLabel.Text = "Purity:";
            // 
            // catalogLabel
            // 
            this.catalogLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.catalogLabel.AutoSize = true;
            this.catalogLabel.Location = new System.Drawing.Point(54, 146);
            this.catalogLabel.Name = "catalogLabel";
            this.catalogLabel.Size = new System.Drawing.Size(86, 13);
            this.catalogLabel.TabIndex = 18;
            this.catalogLabel.Text = "Catalog Number:";
            // 
            // lotLabel
            // 
            this.lotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lotLabel.AutoSize = true;
            this.lotLabel.Location = new System.Drawing.Point(75, 172);
            this.lotLabel.Name = "lotLabel";
            this.lotLabel.Size = new System.Drawing.Size(65, 13);
            this.lotLabel.TabIndex = 17;
            this.lotLabel.Text = "Lot Number:";
            // 
            // locationText
            // 
            this.locationText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.locationText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.locationText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.locationText.Location = new System.Drawing.Point(146, 299);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(100, 20);
            this.locationText.TabIndex = 10;
            // 
            // receivedText
            // 
            this.receivedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.receivedText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.receivedText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.receivedText.Location = new System.Drawing.Point(146, 247);
            this.receivedText.Name = "receivedText";
            this.receivedText.Size = new System.Drawing.Size(100, 20);
            this.receivedText.TabIndex = 8;
            // 
            // partLabel
            // 
            this.partLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.partLabel.AutoSize = true;
            this.partLabel.Location = new System.Drawing.Point(84, 94);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(56, 13);
            this.partLabel.TabIndex = 14;
            this.partLabel.Text = "Plant Part:";
            // 
            // expireText
            // 
            this.expireText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.expireText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.expireText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.expireText.Location = new System.Drawing.Point(146, 273);
            this.expireText.Name = "expireText";
            this.expireText.Size = new System.Drawing.Size(100, 20);
            this.expireText.TabIndex = 9;
            // 
            // partText
            // 
            this.partText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.partText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.partText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.partText.Location = new System.Drawing.Point(146, 91);
            this.partText.Name = "partText";
            this.partText.Size = new System.Drawing.Size(100, 20);
            this.partText.TabIndex = 2;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(89, 302);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 11;
            this.locationLabel.Text = "Location:";
            // 
            // receiveOnLabel
            // 
            this.receiveOnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.receiveOnLabel.AutoSize = true;
            this.receiveOnLabel.Location = new System.Drawing.Point(69, 250);
            this.receiveOnLabel.Name = "receiveOnLabel";
            this.receiveOnLabel.Size = new System.Drawing.Size(71, 13);
            this.receiveOnLabel.TabIndex = 10;
            this.receiveOnLabel.Text = "Received on:";
            // 
            // expireLabel
            // 
            this.expireLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.expireLabel.AutoSize = true;
            this.expireLabel.Location = new System.Drawing.Point(82, 276);
            this.expireLabel.Name = "expireLabel";
            this.expireLabel.Size = new System.Drawing.Size(58, 13);
            this.expireLabel.TabIndex = 9;
            this.expireLabel.Text = "Expires by:";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(91, 198);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(49, 13);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Quantity:";
            // 
            // botanicalLabel
            // 
            this.botanicalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.botanicalLabel.AutoSize = true;
            this.botanicalLabel.Location = new System.Drawing.Point(55, 69);
            this.botanicalLabel.Name = "botanicalLabel";
            this.botanicalLabel.Size = new System.Drawing.Size(85, 13);
            this.botanicalLabel.TabIndex = 7;
            this.botanicalLabel.Text = "Botanical Name:";
            // 
            // commonLabel
            // 
            this.commonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.commonLabel.AutoSize = true;
            this.commonLabel.Location = new System.Drawing.Point(58, 43);
            this.commonLabel.Name = "commonLabel";
            this.commonLabel.Size = new System.Drawing.Size(82, 13);
            this.commonLabel.TabIndex = 6;
            this.commonLabel.Text = "Common Name:";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addButton.Location = new System.Drawing.Point(171, 353);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // amountText
            // 
            this.amountText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.amountText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.amountText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.amountText.Location = new System.Drawing.Point(146, 195);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(100, 20);
            this.amountText.TabIndex = 6;
            // 
            // lotText
            // 
            this.lotText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lotText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lotText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.lotText.Location = new System.Drawing.Point(146, 169);
            this.lotText.Name = "lotText";
            this.lotText.Size = new System.Drawing.Size(100, 20);
            this.lotText.TabIndex = 5;
            // 
            // catalogText
            // 
            this.catalogText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.catalogText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.catalogText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.catalogText.Location = new System.Drawing.Point(146, 143);
            this.catalogText.Name = "catalogText";
            this.catalogText.Size = new System.Drawing.Size(100, 20);
            this.catalogText.TabIndex = 4;
            // 
            // botanicalText
            // 
            this.botanicalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.botanicalText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.botanicalText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.botanicalText.Location = new System.Drawing.Point(146, 66);
            this.botanicalText.Name = "botanicalText";
            this.botanicalText.Size = new System.Drawing.Size(100, 20);
            this.botanicalText.TabIndex = 1;
            // 
            // commonText
            // 
            this.commonText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.commonText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.commonText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.commonText.Location = new System.Drawing.Point(146, 40);
            this.commonText.Name = "commonText";
            this.commonText.Size = new System.Drawing.Size(100, 20);
            this.commonText.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 474);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.searchTab);
            this.Controls.Add(this.closeButton);
            this.MaximumSize = new System.Drawing.Size(944, 512);
            this.MinimumSize = new System.Drawing.Size(300, 512);
            this.Name = "MainForm";
            this.Text = "Reference Standard Log";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.searchTab.ResumeLayout(false);
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TabControl searchTab;
        private System.Windows.Forms.TabPage searchPage;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.TextBox lotText;
        private System.Windows.Forms.TextBox catalogText;
        private System.Windows.Forms.TextBox botanicalText;
        private System.Windows.Forms.TextBox commonText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox searchStyleBox;
        private System.Windows.Forms.Label searchTermLabel;
        private System.Windows.Forms.Label searchBoxLabel;
        private System.Windows.Forms.Label receiveOnLabel;
        private System.Windows.Forms.Label expireLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label botanicalLabel;
        private System.Windows.Forms.Label commonLabel;
        private System.Windows.Forms.TextBox partText;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label catalogLabel;
        private System.Windows.Forms.Label lotLabel;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.TextBox receivedText;
        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.TextBox expireText;
        private System.Windows.Forms.TextBox purityText;
        private System.Windows.Forms.Label purityLabel;
        private System.Windows.Forms.TextBox providerText;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.Label addSuccessLabel;
        private System.Windows.Forms.ColumnHeader commonHeader;
        private System.Windows.Forms.ColumnHeader botanicalHeader;
        private System.Windows.Forms.ColumnHeader catalogHeader;
        private System.Windows.Forms.ColumnHeader lotHeader;
        private System.Windows.Forms.ColumnHeader amountHeader;
        private System.Windows.Forms.ColumnHeader partHeader;
        private System.Windows.Forms.ColumnHeader providerHeader;
        private System.Windows.Forms.Label resultFailedLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ColumnHeader pureHeader;
        private System.Windows.Forms.ColumnHeader receivedHeader;
        private System.Windows.Forms.ColumnHeader expireHeader;
        private System.Windows.Forms.ColumnHeader locationHeader;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label blankLabel;
        private System.Windows.Forms.TextBox barCodeText;
        private System.Windows.Forms.Label barCodeLabel;
        private System.Windows.Forms.ColumnHeader barCodeHeader;
        private System.Windows.Forms.Label removeSuccessLabel;
        private System.Windows.Forms.Label editSuccessLabel;
    }
}

