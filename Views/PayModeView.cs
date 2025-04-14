using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Buscar llame al metodo SearchEvent cuando se haga click en el botón BtnSearch
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s,e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Agregar, llame al evento AddnNewEvent cuando se haga click en el botón BtnNew
            BtnNew.Click += delegate { 
                AddnNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Edit Pay Mode"; // Cambia el titulo de 
                                                                // pestaña
                };
               
            BtnEdit.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDelete.Click += delegate { 
                var result = MessageBox.Show(
                    "Are you sure you want to delete the select Pay Mode",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

              };
            BtnSave.Click += delegate { 
            SaveEvente?.Invoke(this, EventArgs.Empty); 
                if (isSuccessful) //Si grabar fue existoso
                {
                    tabControl1.TabPages.Remove(tabPagePayModeDetail);
                    tabControl1.TabPages.Add(tabPagePayModeList);

                }
                MessageBox.Show(message);

            };
            BtnCancel.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty); 
            
                tabControl1.TabPages.Remove(tabPagePayModeDetail);
                tabControl1.TabPages.Add(tabPagePayModeList);

            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddnNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvente;
        public event EventHandler CancelEvent;

        public void SetPayModeListBildingSource(BindingSource payModelist)
        {
            DgPayMode.DataSource = payModelist;
        }
        private static PayModeView instance;
        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
                return instance;
        }
        
        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }
        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
       public string Message
        {
            get { return message; }
            set { message = value; }
        }
       
        }
    
    }

