using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private readonly IProductView view;
        private readonly IProductRepository repository;
        private readonly BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBindingSource(productBindingSource);

            LoadAllProductList();
            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var model = new ProductModel();
            model.Id = Convert.ToInt32(view.ProductId);
            model.Name = view.ProductName;
            model.Observation = view.ProductObservation;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Producto editado correctamente";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Producto agregado correctamente";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductObservation = "";
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;
                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Producto eliminado correctamente";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error al eliminar: " + ex.Message;
            }
        }

        private void LoadSelectedProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;
            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductObservation = product.Observation;
            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue)
                productList = repository.GetAll();
            else
                productList = repository.GetByValue(this.view.SearchValue);

            productBindingSource.DataSource = productList;
        }
    }
}
