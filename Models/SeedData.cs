using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcClients.Data;

namespace MvcClients.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new MvcClientsContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<MvcClientsContext>>()))
			{
				if (context.Client.Any())
				{
					return; //DB déjà rempli
				}

				context.Client.AddRange(
					new Client
					{
						Civilite = "Mr",
						Nom = "Dujardin",
						Prenom = "Jean",
						DateNaissance = new DateTime(1972, 06, 19),
						Adresse = "4 rue de la bastille",
						CodePostale = 75000,
						Ville = "Paris",
						Pays = "France",
						Mail = "jean.dujardin@live.fr",
						Telephone = "0612345678"
					},
					new Client
					{
						Civilite = "Mme",
						Nom = "Lamy",
						Prenom = "Alexandra",
						DateNaissance = new DateTime(1971, 10, 14),
						Adresse = "4 avenue Jean Jaures",
						CodePostale = 78000,
						Ville = "Versailles",
						Pays = "France",
						Mail = "lamy.alx@gmail.com",
						Telephone = "0612345678"
					}
				);
				context.SaveChanges();
			}
		}
	}
}
