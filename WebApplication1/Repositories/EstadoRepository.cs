using Dapper;
using IBM.Data.Informix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class EstadoRepository
    {

        public IEnumerable<Estado> obterTodosEstados()
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                return connection.Query<Estado>(
                @"select uf.estado_codigo estadoID, uf.estado_descricao estadoDescricao, uf.estado_sigla estadoSigla, uf.estado_aliq_icms estadoAliqIcms,
                uf.pais_codigo paisId, uf.estado_sit_cfo estadoSitCfo
                from tbl_geral_estado uf ");
                // where uf.codigo_estado = ? ", new { id = 42});            // exemplo where
            }
        }


        public Estado obterEstado(int codigoEstado)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                return connection.QueryFirst<Estado>(
                @"select uf.estado_codigo estadoID, uf.estado_descricao estadoDescricao, uf.estado_sigla estadoSigla, uf.estado_aliq_icms estadoAliqIcms,
                uf.pais_codigo paisId, uf.estado_sit_cfo estadoSitCfo
                from tbl_geral_estado uf
                where estado_codigo = ? ", new { id = codigoEstado });            // exemplo where
            }
        }

        public void incluirEstado(Estado estado)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Estado>(
                @"INSERT INTO tbl_geral_estado (estado_codigo, estado_descricao, estado_sigla, estado_aliq_icms, pais_codigo, estado_sit_cfo)
                 values
                 (?, ?, ?, ?, ?, ?)",
                 new
                 {
                     estado_codigo = estado.estadoId,
                     estado_descricao = estado.estadoDescricao,
                     estado_sigla = estado.estadoSigla,
                     estado_aliq_icms = estado.estadoAliqIcms,
                     pais_codigo= estado.paisID,
                     estado_sit_cfo =estado.estadoSitCfo
                 });
            }
        }

        public void alterarEstado(Estado estado)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Estado>(
              $@"update tbl_geral_estado  set estado_descricao=?, estado_sigla=?, estado_aliq_icms=?, pais_codigo=?, estado_sit_cfo=?
                where estado_codigo = {estado.estadoId}",
                new
                {
                    estado_descricao = estado.estadoDescricao,
                    estado_sigla = estado.estadoSigla,
                    estado_aliq_icms = estado.estadoAliqIcms,
                    pais_codigo = estado.paisID,
                    estado_sit_cfo = estado.estadoSitCfo
                });
            }
        }

        public void excluirEstado(int codigoEstado)
        {
            using (var connection = new IfxConnection(LoginRepository.connectionString))
            {
                connection.Open();

                connection.Query<Estado>(
                @"DELETE FROM tbl_geral_estado WHERE estado_codigo = ?",
                 new
                 {
                     estado_codigo = codigoEstado
                 });

            }

        }
    }
}