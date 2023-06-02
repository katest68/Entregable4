using ServicioAPI.Model;
using System.Text.Json;

namespace ServicioAPI.Util
{
    public class ApiCliente
    {
        public HttpClient Cliente{get; set;}

        public ApiCliente(HttpClient cliente){
            this.Cliente=cliente;
        }

        public async Task<User>? GetUser(string id){
            var response = await this.Cliente.GetAsync($"https://jsonplaceholder.typicode.com/users/{id}");

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<User>(content);
        }

    }
    
}