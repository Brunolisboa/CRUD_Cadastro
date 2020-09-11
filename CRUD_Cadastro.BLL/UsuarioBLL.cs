using CRUD_Cadastro.DAL;
using CRUD_Cadastro.DTO;
using System;
using System.Collections.Generic;

namespace CRUD_Cadastro.BLL
{
    public class UsuarioBLL
    {
        public List<Usuario> ConsultarUsuario() 
        {
            try { return new UsuarioDAL().ConsultarUsuario(); } catch (Exception ex) { throw ex; }
        }
        public int InsereUsuario(Usuario USU) 
        {
            try { return new UsuarioDAL().InsereUsuario(USU); } catch (Exception ex) { throw ex; }
        }
        public int EditarUsuario(Usuario USU) 
        {
            try { return new UsuarioDAL().EditarUsuario(USU); } catch (Exception ex) { throw ex; }
        }
        public int DeletarUsuario(Usuario USU) 
        {
            try { return new UsuarioDAL().DeletaUsuario(USU); } catch (Exception ex) { throw ex; }
        }
    }
}
