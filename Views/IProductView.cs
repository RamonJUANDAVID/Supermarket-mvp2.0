using System;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    internal interface IProductView
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        string ProductObservation { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductListBindingSource(BindingSource productList);
        void Show();
    }
}
