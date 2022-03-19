using PizzaPlace.Shared;
using System.Net.Http.Json;

namespace PizzaPlace.Client.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient httpClient;

        public OrderService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async ValueTask PlaceOrder(ShoppingBasket shoppingBasket)
        {
            await httpClient.PostAsJsonAsync("/orders", shoppingBasket);
        }
    }
}
