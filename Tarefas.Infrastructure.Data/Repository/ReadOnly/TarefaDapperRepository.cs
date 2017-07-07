using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Domain.Entities;
using Tarefas.Domain.Interfaces.Repository.ReadOnly;
using Tarefas.Infrastructure.Data.Context;

namespace Tarefas.Infrastructure.Data.Repository.ReadOnly
{
    public class TarefaDapperRepository : BaseDapperRepository, ITarefaDapperRepository
    {
        public TarefaDapperRepository(TarefasDapperContext tarefasDapperContext) : base(tarefasDapperContext)
        {
        }

        public async Task<Tarefa> BuscarPorId(Guid id)
        {
            throw new NotImplementedException();


            /*
             
            using (IDbConnection conexao = dapperContext.DapperConnection)
            {
                string sql = @"
                            SELECT pdv.dt_inicio_emissao AS Data
                                  ,pdv.empresa AS Empresa
                                  ,pdv.num_coo AS NumeroCupom
                                  ,ee.ecf AS NumeroECF
                                  ,pdv.vlr_tot_liquido AS ValorTotal
                            FROM pos_doc_venda pdv (NOLOCK) 
                            INNER JOIN empresa_ecf ee (NOLOCK) ON (ee.numeroserie = pdv.num_fabric AND ee.empresa = pdv.empresa) 
                            WHERE pdv.validado = 0 
	                              AND pdv.ind_cancel = 'N' 
	                              AND pdv.empresa IN @empresas 
	                              AND pdv.dt_inicio_emissao BETWEEN @dtInicial AND @dtFinal
	                              AND NOT EXISTS 
			                            (SELECT m.identificador     
			                            FROM movimento m (NOLOCK)     
			                            WHERE m.documento = pdv.num_coo      
			                            AND m.ecf = ee.ecf     
			                            AND m.serie = 'CF'      
			                            AND m.empresa = pdv.empresa     
			                            AND m.pos = 1                 
			                            AND (ISNULL(pdv.num_cro, 0) = m.reinicio OR pdv.num_cro IS NULL)) 
                            ORDER BY pdv.dt_inicio_emissao, pdv.empresa, pdv.num_coo, ee.ecf ";

                var cuponsFiscais = await conexao.QueryAsync<CuponsFiscais>(sql, new
                {
                    dtInicial = dataInicial,
                    dtFinal = dataFinal,
                    empresas = empresas
                });
                                
                return cuponsFiscais;
            }             
             
             
             
             
             */


        }

        public async Task<IEnumerable<Tarefa>> BuscarTarefasAtivas()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tarefa>> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
