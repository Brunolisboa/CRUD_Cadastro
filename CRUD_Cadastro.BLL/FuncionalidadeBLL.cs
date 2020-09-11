using CRUD_Cadastro.DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace CRUD_Cadastro.BLL
{
    public class FuncionalidadeBLL
    {
        public List<FuncionalidadeDTO> ConsultarFuncionalidade()
        {
            try { return new FuncionalidadeDAL().ConsultaFuncionalidade(); } catch (Exception ex) { throw ex; }
        }
        public int InsereFuncionalidade(FuncionalidadeDTO funcio)
        {
            try { return new FuncionalidadeDAL().InsereFuncionalidade(funcio); } catch (Exception ex) { throw ex; }
        }
        public int EditaFuncionalidade(FuncionalidadeDTO funcio)
        {
            try { return new FuncionalidadeDAL().EditaFuncionalidade(funcio); } catch (Exception ex) { throw ex; }
        }
        public int DeletarFuncionalidade(FuncionalidadeDTO funcio)
        {
            try { return new FuncionalidadeDAL().DeletarFuncionalidade(funcio); } catch (Exception ex) { throw ex; }
        }
    }
}
