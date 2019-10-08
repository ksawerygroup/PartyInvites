using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
	// kontrola poprawności i potwierdzenie przybycia
	public class GuestResponse
	{
		[Required(ErrorMessage = "Proszę podać swoje imię")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Proszę podać adres e-mail")]// walidacja adresu e-mail
		[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy adres e-mail")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Proszę podać numer telefonu")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Proszę określić czy weźniesz udział.")]
		public bool? WillAttend { get; set; }
	}
}