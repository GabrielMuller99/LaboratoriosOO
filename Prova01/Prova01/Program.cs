using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    class Program
    {
        static void Main(string[] args)
        {
            Bairro bairroBob = new Bairro("Bairro Jardim das Oliveiras");
            Bairro bairroTestolfo = new Bairro("Bairro Operarios");
            Bairro bairroBelo = new Bairro("Bairro Monges Unidos");
            Bairro bairroF = new Bairro("Copacabana");

            Estado estadoBob = new Estado("Distrito Federal", "DF");
            Estado estadoTestolfo = new Estado("Goiás", "GO");
            Estado estadoBelo = new Estado("Minas Gerais", "MG");
            Estado estadoF = new Estado("Rio de Janeiro", "RJ");

            Cidade cidadeBob = new Cidade("Brasília", estadoBob);
            Cidade cidadeTestolfo = new Cidade("Rio Verde", estadoTestolfo);
            Cidade cidadeBelo = new Cidade("Belo Horizonte", estadoBelo);
            Cidade cidadeF = new Cidade("Rio de Janeiro", estadoF);

            Endereco enderecoBob = new Endereco(23, "Rua das Classes", bairroBob, cidadeBob);
            Endereco enderecoTestolfo = new Endereco(4, "Avenida Abstrata", bairroTestolfo, cidadeTestolfo);
            Endereco enderecoBelo = new Endereco(26, "Vale das Heranças", bairroBelo, cidadeBelo);
            Endereco enderecoF = new Endereco(45, "Edifício Gaveta", bairroF, cidadeF);

            PessoaFisica bobnelson = new PessoaFisica(100, "Bob Nelson", "111.222.333-99", enderecoBob, false, "bobNelson@gmail.com");
            PessoaFisica testolfo = new PessoaFisica(200, "Testolfo", "444.555.666-11", enderecoTestolfo, true, "testolfoRocha26@gmail.com");
            PessoaFisica beloteste = new PessoaFisica(200, "Belo Teste", "999.888.777-72", enderecoBelo, true, "Testebelo@gmail.com");
            PessoaJuridica livrosassociados = new PessoaJuridica(300, "Livros Associados", "99.8888.7777-77", enderecoF, "faleconosco@associados.com");

            Livro domcasmurro = new Livro(100, "Dom Casmurro", EnumGenero.Ficção, "Machado de Assis", "Universal", livrosassociados, 19.99f, 31.99f, 0);
            Livro unity = new Livro(150, "Unity: design e desenvolvimento de jogos", EnumGenero.Games, "William Pereira Alves", "Universal", livrosassociados, 24.35f, 58.99f, 0);
            Caderno caderno100 = new Caderno(170, 100, livrosassociados, 10.99f, 25.99f, 0);

            Cadastro cadastro = new Cadastro();
            Estoque estoque = new Estoque();

            cadastro.AdicionarCliente(bobnelson);
            cadastro.AdicionarCliente(testolfo);
            cadastro.AdicionarCliente(beloteste);
            cadastro.AdicionarFornecedor(livrosassociados);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadLine();

            estoque.EntradaLivro(domcasmurro, 20);
            estoque.EntradaLivro(unity, 10);
            estoque.EntradaCaderno(caderno100, 50);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadLine();

            estoque.VenderCaderno(caderno100, 5, bobnelson);
            estoque.VenderCaderno(caderno100, 10, testolfo);
            estoque.VenderCaderno(caderno100, 20, beloteste);
            estoque.VenderCaderno(caderno100, 20, bobnelson);
            estoque.VenderCaderno(caderno100, 15, bobnelson);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadLine();

            estoque.VenderLivro(domcasmurro, 2, bobnelson);
            estoque.VenderLivro(domcasmurro, 3, testolfo);
            estoque.VenderLivro(domcasmurro, 1, beloteste);
            estoque.VenderLivro(unity, 2, bobnelson);
            estoque.VenderLivro(unity, 4, testolfo);
            estoque.VenderLivro(unity, 4, beloteste);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadLine();

            cadastro.relacionarClientes();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadLine();

            cadastro.relacionarFornecedores();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadLine();

            cadastro.RemoverCliente(bobnelson);
            cadastro.RemoverCliente(testolfo);
            cadastro.RemoverCliente(beloteste);
            cadastro.RemoverFornecedor(livrosassociados);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
