using Microsoft.AspNetCore.Builder;

namespace Alura.ListaLeitura.App {
    internal class RouteBuider {
        private IApplicationBuilder app;

        public RouteBuider(IApplicationBuilder app) {
            this.app = app;
        }
    }
}