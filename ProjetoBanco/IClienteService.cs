using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBanco;

public interface IClienteService
{
    void CriarConta();
    Cliente BuscarCliente();
    void ExibirClientes();
}