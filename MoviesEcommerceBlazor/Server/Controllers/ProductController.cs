using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviesEcommerceBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "Inferno (2016)",
            Description = "In this third globe-trotting screen adventure of Dan Brown's indefatigable iconologist Prof. Robert Langdon (Tom Hanks)-and another partnering for the star and director Ron Howard-a demented entrepreneur (Ben Foster) has decided to combat global overpopulation by unleashing a killer virus, and Langdon must unravel the madman's skein of Dante-themed clues to in order to find the doomsday weapon. Potent thriller co-stars Felicity Jones, Sidse Babett Knudsen, Irrfan Khan, Omar Sy. 4K Ultra HD includes bonus DVD on 2 Discs. Directed by Ron Howard. 2016 / color / 122 min / PG-13 / widescreen.",
            ImageUrl = "https://aentcdn.azureedge.net/graphics/items/sdimages/c/300/8/7/0/1/3471078.jpg?ae=2309403150",
            Price = 9.99m
        },
        new Product
        {
            Id = 2,
            Title = "Dog (2022)",
            Description = "Still struggling with his physical and emotional battle scars, but desperate for reinstatement, ex-Army Ranger Jackson Briggs (Channing Tatum, who co-directed) would do anything to prove himself. So, he agreed to drive another troubled veteran--Belgian Malinois service dog Lulu--from Oregon to Arizona for the funeral of her handler. The mutual wariness gives way to a warm bond during this comically calamitous road trip. Ethan Suplee, Q’orianka Kilcher, Emmy Raver-Lampman, Bill Burr co-star. 101 min. Widescreen; Soundtrack: English.",
            ImageUrl = "https://mediacdn.aent-m.com/prod-img/300/50/4075150-2823623.jpg?ae=2309403150",
            Price = 8.99m
        },
        new Product
        {
            Id = 3,
            Title = "The Northman (2022)",
            Description = "As a boy, the Viking prince Amleth bore witness to the slaying of his father Aurvandill (Ethan Hawke) by his treacherous uncle Fjölnir (Claes Bang), who'd desired his mother Gudrún (Nicole Kidman). Having fled for his life, he swore he'd have vengeance--and the day came that Amleth (Alexander Skarsgård), grown into a formidable barbarian, returned to claim it. Robert Eggers' brooding, brutal take on the mythos that inspired Hamlet co-stars Anya Taylor-Joy, Willem Defoe, Björk. 136 min. Widescreen; Soundtrack: English.",
            ImageUrl = "https://mediacdn.aent-m.com/prod-img/300/00/4085200-2835918.jpg?ae=2309403150",
            Price = 11.99m
        },
    };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduktet()
        {
            return Ok(Products);
        }

    }
}
 