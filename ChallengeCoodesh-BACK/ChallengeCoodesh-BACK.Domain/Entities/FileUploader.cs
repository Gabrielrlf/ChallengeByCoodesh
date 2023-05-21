using ChallengeCoodesh_BACK.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Domain.Entities
{
    public class FileUploader : Entity
    {
        public FileUploader(TypeTransaction typeTransaction, DateTime createdDate, string productDescription, decimal valueProduct, string sellerName)
        {
            ValidationNames(productDescription, sellerName);
            TypeTransaction = typeTransaction;
            ProductDescription = productDescription;
            ValueProduct = valueProduct;
            SellerName = sellerName;
            CreatedDate = createdDate;
        }

        //Type Transaction
        public TypeTransaction TypeTransaction { get; set; }
        //Name of Product
        public string ProductDescription { get; private set; }
        //Created date transaction
        public DateTime CreatedDate{ get; private set; }
        //Value of Product
        public decimal ValueProduct { get; set; }
        //Seller Name
        public string SellerName { get; set; }
        private void ValidationNames(string productDescription, string SellerName)
        {
            if (string.IsNullOrEmpty(productDescription) || string.IsNullOrEmpty(SellerName))
                throw new InvalidOperationException("Product Name or Seller Name is required!");
        }
    }
}
