namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductsList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductsDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtObservation = new TextBox();
            TxtName = new TextBox();
            TxtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductsDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 35);
            label1.Name = "label1";
            label1.Size = new Size(143, 31);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnClose);
            tabPageProductsList.Controls.Add(BtnDelete);
            tabPageProductsList.Controls.Add(BtnEdit);
            tabPageProductsList.Controls.Add(BtnNew);
            tabPageProductsList.Controls.Add(DgProduct);
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(792, 292);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(608, 237);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(150, 47);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(608, 167);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(150, 64);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(608, 110);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(150, 51);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(608, 56);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(150, 48);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(12, 56);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowHeadersWidth = 51;
            DgProduct.Size = new Size(590, 229);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small1;
            BtnSearch.Location = new Point(551, 6);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(51, 44);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(12, 23);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = " Data to search";
            TxtSearch.Size = new Size(533, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 3);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(BtnCancel);
            tabPageProductsDetail.Controls.Add(BtnSave);
            tabPageProductsDetail.Controls.Add(TxtObservation);
            tabPageProductsDetail.Controls.Add(TxtName);
            tabPageProductsDetail.Controls.Add(TxtId);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 29);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(792, 292);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(126, 216);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(98, 51);
            BtnCancel.TabIndex = 8;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(16, 216);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 51);
            BtnSave.TabIndex = 7;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtObservation
            // 
            TxtObservation.Location = new Point(16, 129);
            TxtObservation.Multiline = true;
            TxtObservation.Name = "TxtObservation";
            TxtObservation.PlaceholderText = "Product Observation";
            TxtObservation.Size = new Size(270, 69);
            TxtObservation.TabIndex = 6;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(16, 76);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Product Name";
            TxtName.Size = new Size(270, 27);
            TxtName.TabIndex = 5;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(16, 23);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(125, 27);
            TxtId.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 106);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 2;
            label5.Text = "Product Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 53);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private TabPage tabPageProductsDetail;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtObservation;
        private TextBox TxtName;
        private TextBox TxtId;
        private Label label5;
        private Label label4;
    }
}