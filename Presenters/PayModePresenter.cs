using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
      private IPayModeView view;
      private IPayModeRepository repository;
      private BindingSource payModeBindingSource;
      private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        { 
            this.payModeBindingSource = new BindingSource();    

            this.view = view;
            this.repository = repository;
           
            this.view.SearchEvent += SearchPayMode;
            this.view.AddnNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvente += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            LoadAllPayModelist();

            this.view.Show();
        }

        private void LoadAllPayModelist()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            // Se crea un objeto de la clase PayModeModel se asigno los datos
            // De las cajas de texto de la vista
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                { 
                 repository.Edit(payMode);
                 view.Message = "Pay mode edited successfully";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "Pay mode added successfully";
                }
                view.IsSuccessful = true;
                LoadAllPayModelist();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción se configura IsSuccessful en false
                // y la propiedad Message de la vista se asigna el mensaje de la excepción
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName ="";
            view.PayModeObservation = "";
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                // Se recupera el objeto de la fila seleccionada de dataviewgrid
                var payMode = (PayModeModel)payModeBindingSource.Current;

                // Se invoca el metodo Delete del repositorio pasandole el ID del Pay Mode
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted succesfully";
                LoadAllPayModelist();
            }
            catch (Exception ex) 
            { 
                view.IsSuccessful= false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            // Se obtiene el objeto de datagridview que se encuentra seleccionado
            var payMode = (PayModeModel)payModeBindingSource.Current;

            // Se cambia el contenido de las cajas de texto por el objeto recuperado
            // del datagridview
            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;

            // Se establece el modo como edición
            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}
