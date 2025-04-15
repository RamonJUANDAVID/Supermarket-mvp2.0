namespace Supermarket_mvp.Views
{
    partial class ProductView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProductList;
        private System.Windows.Forms.TabPage tabProductDetail;
        private System.Windows.Forms.DataGridView DgProducts;

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblObservation;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtObservation;

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProductList = new System.Windows.Forms.TabPage();
            this.tabProductDetail = new System.Windows.Forms.TabPage();

            this.DgProducts = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();

            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();

            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblObservation = new System.Windows.Forms.Label();

            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtObservation = new System.Windows.Forms.TextBox();

            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProductList);
            this.tabControl1.Controls.Add(this.tabProductDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // tabProductList
            // 
            this.tabProductList.Controls.Add(this.DgProducts);
            this.tabProductList.Controls.Add(this.lblSearch);
            this.tabProductList.Controls.Add(this.TxtSearch);
            this.tabProductList.Controls.Add(this.BtnSearch);
            this.tabProductList.Controls.Add(this.BtnNew);
            this.tabProductList.Controls.Add(this.BtnEdit);
            this.tabProductList.Controls.Add(this.BtnDelete);
            this.tabProductList.Text = "Lista de productos";

            // 
            // dgvProducts
            // 
            this.DgProducts.Location = new System.Drawing.Point(20, 70);
            this.DgProducts.Size = new System.Drawing.Size(600, 250);
            this.DgProducts.ReadOnly = true;
            this.DgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 
            // lblSearch
            // 
            this.lblSearch.Text = "Buscar:";
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            // 
            // txtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(80, 20);
            this.TxtSearch.Size = new System.Drawing.Size(200, 20);
            // 
            // btnSearch
            // 
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.Location = new System.Drawing.Point(300, 18);
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            // 
            // btnNew
            // 
            this.BtnNew.Text = "Nuevo";
            this.BtnNew.Location = new System.Drawing.Point(500, 18);
            // 
            // btnEdit
            // 
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.Location = new System.Drawing.Point(580, 18);
            // 
            // btnDelete
            // 
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.Location = new System.Drawing.Point(660, 18);
            // 
            // tabProductDetail
            // 
            this.tabProductDetail.Controls.Add(this.lblId);
            this.tabProductDetail.Controls.Add(this.TxtId);
            this.tabProductDetail.Controls.Add(this.lblName);
            this.tabProductDetail.Controls.Add(this.TxtName);
            this.tabProductDetail.Controls.Add(this.lblObservation);
            this.tabProductDetail.Controls.Add(this.TxtObservation);
            this.tabProductDetail.Controls.Add(this.BtnSave);
            this.tabProductDetail.Controls.Add(this.BtnCancel);
            this.tabProductDetail.Text = "Detalle de producto";

            // 
            // lblId
            // 
            this.lblId.Text = "ID:";
            this.lblId.Location = new System.Drawing.Point(20, 30);
            // 
            // txtId
            // 
            this.TxtId.Location = new System.Drawing.Point(120, 30);
            this.TxtId.ReadOnly = true;
            // 
            // lblName
            // 
            this.lblName.Text = "Nombre:";
            this.lblName.Location = new System.Drawing.Point(20, 70);
            // 
            // txtName
            // 
            this.TxtName.Location = new System.Drawing.Point(120, 70);
            this.TxtName.Size = new System.Drawing.Size(200, 20);
            // 
            // lblObservation
            // 
            this.lblObservation.Text = "Observación:";
            this.lblObservation.Location = new System.Drawing.Point(20, 110);
            // 
            // txtObservation
            // 
            this.TxtObservation.Location = new System.Drawing.Point(120, 110);
            this.TxtObservation.Size = new System.Drawing.Size(300, 80);
            this.TxtObservation.Multiline = true;
            // 
            // btnSave
            // 
            this.BtnSave.Text = "Guardar";
            this.BtnSave.Location = new System.Drawing.Point(120, 210);
            // 
            // btnCancel
            // 
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.Location = new System.Drawing.Point(220, 210);

            // 
            // ProductView
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Text = "Gestión de Productos";
        }
    }
}
