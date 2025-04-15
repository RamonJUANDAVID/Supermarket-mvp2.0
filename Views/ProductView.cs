using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView
    {
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.SelectedIndex = 1;
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.SelectedIndex = 1;
            };
            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful) tabControl1.SelectedIndex = 0;
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.SelectedIndex = 0;
            };
        }

        public int ProductId { get => Convert.ToInt32(TxtId.Text); set => TxtId.Text = value.ToString(); }
        public string ProductName { get => TxtName.Text; set => TxtName.Text = value; }
        public string ProductObservation { get => TxtObservation.Text; set => TxtObservation.Text = value; }

        public string SearchValue { get => TxtSearch.Text; set => TxtSearch.Text = value; }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBindingSource(BindingSource productList)
        {
            DgProduct.DataSource = productList;
        }

        private static ProductView instance;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;

                instance.BringToFront();
            }
            return instance;
        }
    }
}
