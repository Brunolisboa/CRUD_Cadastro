using CRUD_Cadastro.DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace CRUD_Cadastro.BLL
{
    public class PerfilBLL
    {
        public List<PerfilDTO> ConsultarPerfil()
        {
            try { return new PerfilDAL().ConsultarPerfil(); } catch (Exception ex) { throw ex; }
        }
        public int InserePerfil(PerfilDTO PERF)
        {
            try { return new PerfilDAL().InserePerfil(PERF); } catch (Exception ex) { throw ex; }
        }
        public int EditaPerfil(PerfilDTO PERF)
        {
            try { return new PerfilDAL().EditaPerfil(PERF); } catch (Exception ex) { throw ex; }
        }
        public int DeletarPerfil(PerfilDTO PERF)
        {
            try { return new PerfilDAL().DeletarPerfil(PERF); } catch (Exception ex) { throw ex; }
        }
    }
}
