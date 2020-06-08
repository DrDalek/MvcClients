using System.ComponentModel.DataAnnotations;

namespace MvcClients.Attributes
{
	public class PhoneNumberAttribute : ValidationAttribute
	{

		public PhoneNumberAttribute()
		{
			ErrorMessage = "Numéro de téléphone incorrect (ex: 0612345678)";
		}

		public override bool IsValid(object value)
		{
			var numeroTel = value as string;
			if (!string.IsNullOrEmpty(numeroTel))
			{
				return numeroTel.StartsWith("0") && numeroTel.Length == 10;
			}
			return true;
		}
	}
}
