using System;
using System.ComponentModel.DataAnnotations;

namespace MvcClients.Attributes
{
	public class BirthDateAttribute : ValidationAttribute
	{

		public int MinimumAge { get; set; }

		public override bool IsValid(object value)
		{
			
			var dateNaissance = (DateTime) value;

			//No DateTime was input
			var isEmpty = dateNaissance == DateTime.MinValue;
			if (!isEmpty)
			{
				var ageActuelSpan = DateTime.Now - dateNaissance;
				//ageValid représente l'age minimum
				var ageValidDate = new DateTime(DateTime.Now.Year - MinimumAge, 
					DateTime.Now.Month, DateTime.Now.Day);

				var ageActuelIsValid = ageActuelSpan > (DateTime.Now - ageValidDate);
				if (!ageActuelIsValid)
				{
					ErrorMessage = "Age minimum : " + MinimumAge + " ans";	
				}
				return ageActuelIsValid;
			}

			ErrorMessage = "Veuillez saisir une date de naissance";
			return true;
		}
	}
}
