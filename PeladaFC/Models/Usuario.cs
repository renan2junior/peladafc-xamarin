using System;
namespace PeladaFC
{
	public class Usuario
	{

		public string Id { get; set;}
		public string Email { get; set;}
		public string Mensalista { get; set;}
		public string Nome { get; set; }
		public string Telefone { get; set;}
		public Time Time { get; set; }
		public TipoUsuario Tipo_usuario { get; set; }

		public Usuario()
		{
		}
	}
}
