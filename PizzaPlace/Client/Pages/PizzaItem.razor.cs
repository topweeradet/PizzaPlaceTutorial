using Microsoft.AspNetCore.Components;
using PizzaPlace.Shared;

namespace PizzaPlace.Client.Pages
{
    public partial class PizzaItem
    {
        [Parameter]
        public Pizza Pizza { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Pizza> Selected { get; set; }

        private string SpicinessImage(Spiciness spiciness)
        {
            string iconString = "fa-solid fa-pepper-hot";

            switch (spiciness)
            {
                case Spiciness.Spicy:
                    return $"<i class={iconString}></i>";
                case Spiciness.Hot:
                    return $"<i class={iconString}></i><i class={iconString}></i>";
                default:
                    return "<i></i>";
            }
        }
    }
}
