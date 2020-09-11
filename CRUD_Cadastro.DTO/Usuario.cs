namespace CRUD_Cadastro.DTO
{
    public class Usuario
    {
        public int Id_Nome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Id_Perfil { get; set; }
    }
}