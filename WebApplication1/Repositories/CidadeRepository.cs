using Dapper;
using IBM.Data.Informix;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class CidadeRepository
    {
        public CidadeRepository() { }

        public IEnumerable<Cidade> obterTodasCidades()
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                return connection.Query<Cidade>(
                 @"select cdd.cidade_codigo cidadeId, cdd.cidade_descricao descricao, cdd.cidade_ddd ddd, cdd.codmun_codigo codigoIBGE,
                cdd.estado_codigo estadoId, cidade_aliq_iss cidadeAliqIss, cidade_km cidadeKm
                from tbl_geral_cidade cdd ");
                // where cidade_codigo = ? ", new { id = 42});            // exemplo where
            }
        }


        public Cidade obterCidade(int codigoCidade)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                return connection.QueryFirst<Cidade>(
                @"select cdd.cidade_codigo cidadeId, cdd.cidade_descricao descricao, cdd.cidade_ddd ddd, cdd.codmun_codigo codigoIBGE,
                cdd.estado_codigo estadoId, cidade_aliq_iss cidadeAliqIss, cidade_km cidadeKm
                from tbl_geral_cidade cdd 
                where cidade_codigo = ? ", new { id = codigoCidade });            // exemplo where
            }            
        }

        public void incluirCidade(Cidade cidade)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Cidade>(
                @"INSERT INTO tbl_geral_cidade (cidade_codigo, cidade_descricao, cidade_ddd, codmun_codigo, estado_codigo, cidade_aliq_iss, cidade_km)
                 values
                 (?, ?, ?, ?, ?, ?, ?)",
                 new
                 {
                     cidade_codigo = cidade.cidadeId,
                     cidade_descricao = cidade.descricao,
                     cidade_ddd = cidade.ddd,
                     codmun_codigo = cidade.codigoIbge,
                     estado_codigo = cidade.estadoID,
                     cidade_aliq_iss = cidade.cidadeAliqIss,
                     cidade_km = cidade.cidadeKm
                 });
            }
        }

        public void alterarCidade(Cidade cidade)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Cidade>(
                $@"UPDATE tbl_geral_cidade SET cidade_descricao=?, cidade_ddd=?, codmun_codigo=?, estado_codigo=?, cidade_aliq_iss=?, cidade_km=?
                WHERE cidade_codigo={cidade.cidadeId} ",
                 new
                 {                     
                     cidade_descricao = cidade.descricao,
                     cidade_ddd = cidade.ddd,
                     codmun_codigo = cidade.codigoIbge,
                     estado_codigo = cidade.estadoID,
                     cidade_aliq_iss = cidade.cidadeAliqIss,
                     cidade_km = cidade.cidadeKm
                     
                 });
            }
        }

        public void excluirCidade(int codigoCidade)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Cidade>(
                @"DELETE FROM tbl_geral_cidade WHERE cidade_codigo = ?",
                 new
                 {
                     cidade_codigo = codigoCidade
                 });

            }

        }
    }
}