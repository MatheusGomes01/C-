using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SalesWebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            /*
             MVC: 
             Model -- > estrutura dos dados e suas tranformacoes (domain model)
              **Tambem chamado de "o sistema"
              **Composto de Entities e Services (relacionados as entities)
                ** Repositories (objetos que acessam dados persistentes)
             Controllers --> receber e tratar as interacoes do usuario com o sistema
             Views --> Definir a estrutura e comportamento das telas

            Entity Framework:
            Principais Classe :
            DbContext --> um objeto DbContext encapsula uma sessao com o banco de dados para um 
            determinado modelo de dados (representado por DbSet's).
                **É usado para consultar e salvar entidades no bando de dados
                ** Define quais entidades fatao parte do modelo de dados do sistema
                ** Pode Definir várias configurações
                ** É uma opcao dos padroes Unity of Work e Repository
                    ** Unity of woek --> matem uma lista de objetos afetados por uma tansação e coordena
                    escrita de mudancas e trata possiveis problemas de concorrencia
                    **Repository --> define um objeto capas de realizar operacoes de acesso a dados
                    (consultas, salvar, atualizar, deletar) para um entidade.
            DbSet<TEntity> --> representa a coleção de entidades de um dado tipo em um contexto. Tipicamente
            corresponde a uma tabela do bd
             */
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
