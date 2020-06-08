using System;
using System.ComponentModel.DataAnnotations;
using MvcClients.Attributes;

namespace MvcClients.Models
{
	public class Client
	{
		public int Id { get; set; }

		[Display(Name="Civilité")]
		public string Civilite  { get; set; }

		[Required(ErrorMessage = "Le champ 'Nom' est requis")]
		public string Nom { get; set; }

		[Required(ErrorMessage = "Le champ 'Prénom' est requis")]
		[Display(Name = "Prénom")]
		public string Prenom { get; set; }

		[Required(ErrorMessage = "Le champ 'Date de naissance' est requis")]
		[Display(Name = "Date de naissance")]
		[DataType(DataType.Date), BirthDate(MinimumAge = 18)]
		public DateTime DateNaissance { get; set; }

		[Required(ErrorMessage = "Le champ 'Code Postal' est requis")]
		[Display(Name = "Code Postal")]
		[DataType(DataType.PostalCode)]
		public int CodePostale { get; set; }

		public string Adresse { get; set; }
		
		[Required(ErrorMessage = "Le champ 'Pays' est requis")]
		public string Pays { get; set; }

		[Display(Name = "Mail")]
		[DataType(DataType.EmailAddress)]
		[EmailAddress(ErrorMessage = "Adresse mail non valide (ex: jean@exemple.fr)")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Le champ 'Téléphone' est requis")]
		[Display(Name = "Téléphone"), PhoneNumber]
		public string Telephone { get; set; }

		[Required(ErrorMessage = "Le champ 'Ville' est requis")]
		[Display(Name="Ville/Commune")]
		public string Ville { get; set; }


	}
}
