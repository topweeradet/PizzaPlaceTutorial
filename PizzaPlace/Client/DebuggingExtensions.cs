using System.Text.Json;

namespace PizzaPlace.Client
{
    public static class DebuggingExtensions
    {
        private static JsonSerializerOptions option = new JsonSerializerOptions { WriteIndented = true };

        public static string ToJson(this object obj)
        {
#if DEBUG
            return JsonSerializer.Serialize(obj, option);
#endif
        }
    }
}
