using FleaMarket.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FleaMarket.Models.ViewModels
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Du måste ange en titel")]
        [Display(Name = "Titel")]
        public string Title { get; set; } = null!;


        [Required(ErrorMessage = "Du måste ange ett pris")]
        [Display(Name = "Pris")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Du måste ange vilken marknad.")]
        [Display(Name = "Marknad")]
        public string SelectMarket { get; set; } = null!;

        [Required(ErrorMessage = "Du måste ange vilket bordsnummer du har")]
        [Display(Name = "Bordsnummer")]
        public int TableNumber { get; set; }

        [Display(Name = "Kategori")]
        public string? Category { get; set; }


        [Display(Name = "Brand")]
        public string? Brand { get; set; }
        public DateTime TimeAdded { get; set; } = DateTime.Now;

        public string UserId { get; set; } = null!;

        public static implicit operator ProductEntity(AddProductViewModel viewModel)
        {
            return new ProductEntity
            {
                Title = viewModel.Title,
                Price = viewModel.Price,
                SelectMarket = viewModel.SelectMarket,
                TableNumber = viewModel.TableNumber,
                Category = viewModel.Category,
                Brand = viewModel.Brand,
                UserId = viewModel.UserId
            };
        }
    }
}
