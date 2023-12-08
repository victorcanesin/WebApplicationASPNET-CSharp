using Dapper;
using IBM.Data.Informix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class PaisRepository
    {
        public PaisRepository() { }

        public IEnumerable<Pais> obterTodosPaises()
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                return connection.Query<Pais>(
                 @"select pais.pais_codigo paisid, pais.pais_descricao paisDescricao, pais.pais_sigla paisSigla
                from tbl_geral_pais pais ");
                // where cidade_codigo = ? ", new { id = 42});            // exemplo where
            }
        }


        public Pais obterPais(int codigoPais)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                return connection.QueryFirst<Pais>(
                @"select pais.pais_codigo paisid, pais.pais_descricao paisDescricao, pais.pais_sigla paisSigla
                from tbl_geral_pais pais
                where pais_codigo = ? ", new { id = codigoPais });            // exemplo where
            }
        }

        public void incluirPais(Pais pais)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Pais>(
                @"INSERT INTO tbl_geral_pais (pais_codigo, pais_descricao, pais_sigla)
                 values
                 (?, ?, ?)",
                 new
                 {
                     pais.paisId,
                     pais.paisDescricao,
                     pais.paisSigla
                 });
            }
        }

        public void alterarPais(Pais pais)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Cidade>(
                $@"UPDATE tbl_geral_pais SET pais_descricao=?, pais_sigla=?
                WHERE pais_codigo={pais.paisId} ",
                 new
                 {
                     pais.paisDescricao,
                     pais.paisSigla
                 });
            }
        }

        public void excluirPais(int codigoPais)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Pais>(
                @"DELETE FROM tbl_geral_pais WHERE pais_codigo = ?",
                 new
                 {
                     pais_codigo = codigoPais
                 });

            }

        }
    }
}