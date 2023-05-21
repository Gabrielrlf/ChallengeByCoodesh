using ChallengeCoodesh_BACK.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Dtos
{
    public class FileUploaderDto : EntityDto
    {
        //Type Transaction
        [Required]
        public TypeTransaction TypeTransaction { get; set; }
        //Name of Product
        [Required]
        public string ProductDescription { get; set; }
        //Value of Product
        [Required]
        public decimal ValueProduct { get; set; }
        //Seller Name
        [Required]
        public string SellerName { get; set; }
    }
}
