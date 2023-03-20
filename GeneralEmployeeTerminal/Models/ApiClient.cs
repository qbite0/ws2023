using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeneralEmployeeTerminal.Models {
    internal class ApiClient {
        const string API_URL = "https://localhost:7287";

        public static async Task<bool> IsEmployeeExistsAsync(Guid id) {
            using (var client = new HttpClient()) {
                var response = await client.GetAsync($"{API_URL}/api/Employee/{id}");
                return response.IsSuccessStatusCode;
            }
        }

        public static async Task<Ticket[]> GetTickets() {
            using (var client = new HttpClient()) {
                var response = await client.GetAsync($"{API_URL}/api/Tickets");
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsAsync<Ticket[]>();
            }
        }
    }
}
