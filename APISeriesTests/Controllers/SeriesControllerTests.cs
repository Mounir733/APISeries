using Microsoft.VisualStudio.TestTools.UnitTesting;
using APISeries.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using APISeries.Models.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace APISeries.Controllers.Tests
{
    

    [TestClass()]

    public class SeriesControllerTests
    {

        SeriesController seriesController;
       /* [ClassInitialize]
        public void Initialize()
        {
            var builder = new DbContextOptionsBuilder<SeriesDbContext>().UseNpgsql("Server=localhost;port=5432;Database=SeriesDB; uid=postgres;password=postgres;");
            SeriesDbContext _context = new SeriesDbContext(builder.Options);
            SeriesController controller = new SeriesController(_context);
        }*/

        [TestMethod()]
        public void SeriesControllerTest()
        {
            


        }

        [TestMethod()]
        public void GetSeriesTest()
        {

            var builder = new DbContextOptionsBuilder<SeriesDbContext>().UseNpgsql("Server=localhost;port=5432;Database=SeriesDB; uid=postgres;password=postgres;");
            SeriesDbContext _context = new SeriesDbContext(builder.Options);
            SeriesController seriesController = new SeriesController(_context);

            var result = seriesController.GetSeries().Result.Value;
            Serie serie1 = new Serie(1, "Scrubs", "J.D. est un jeune médecin qui débute sa carrière dans l'hôpital du Sacré-Coeur. Il vit avec son meilleur ami Turk, qui lui est chirurgien dans le même hôpital. Très vite, Turk tombe amoureux d'une infirmière Carla. Elliot entre dans la bande. C'est une étudiante en médecine quelque peu surprenante. Le service de médecine est dirigé par l'excentrique Docteur Cox alors que l'hôpital est géré par le diabolique Docteur Kelso. A cela viennent s'ajouter plein de personnages hors du commun : Todd le chirurgien obsédé, Ted l'avocat dépressif, le concierge qui trouve toujours un moyen d'embêter JD... Une belle galerie de personnage !", 9, 184, 2001, "ABC (US)");
            Serie serie2 = new Serie(2, "James May's 20th Century", "The world in 1999 would have been unrecognisable to anyone from 1900. James May takes a look at some of the greatest developments of the 20th century, and reveals how they shaped the times we live in now.", 1, 6, 2007, "BBC Two");
            Serie serie3 = new Serie(3, "True Blood", "Ayant trouvé un substitut pour se nourrir sans tuer (du sang synthétique), les vampires vivent désormais parmi les humains. Sookie, une serveuse capable de lire dans les esprits, tombe sous le charme de Bill, un mystérieux vampire. Une rencontre qui bouleverse la vie de la jeune femme...", 7, 81, 2008, "HBO");

            List<Serie> listeSeriesRecuperees = new List<Serie> { serie1, serie2, serie3 };

            CollectionAssert.AreEqual(result.Where(s => s.Serieid <= 3).ToList(), listeSeriesRecuperees);


        }

        [TestMethod()]
        public void GetSerieTest()
        {
            var builder = new DbContextOptionsBuilder<SeriesDbContext>().UseNpgsql("Server=localhost;port=5432;Database=SeriesDB; uid=postgres;password=postgres;");
            SeriesDbContext _context = new SeriesDbContext(builder.Options);
            SeriesController seriesController = new SeriesController(_context);

            var result = seriesController.GetSerie(2).Result.Value;

            Serie serie2 = new Serie(2, "James May's 20th Century", "The world in 1999 would have been unrecognisable to anyone from 1900. James May takes a look at some of the greatest developments of the 20th century, and reveals how they shaped the times we live in now.", 1, 6, 2007, "BBC Two");


            //List<Serie> listeSeriesRecuperees = new List<Serie> { serie2, };

           // Assert.IsInstanceOfType(result, typeof(ActionResult<Serie>), "Pas une serie"); // Test du type de retour
            Assert.AreEqual(result, serie2);
        }

        [TestMethod()]
        public void GetSerieTest_NotFound()
        {
            var builder = new DbContextOptionsBuilder<SeriesDbContext>().UseNpgsql("Server=localhost;port=5432;Database=SeriesDB; uid=postgres;password=postgres;");
            SeriesDbContext _context = new SeriesDbContext(builder.Options);
            SeriesController seriesController = new SeriesController(_context);

            var result = seriesController.GetSerie(1000).Result.Value;

            Serie serie2 = new Serie(2, "James May's 20th Century", "The world in 1999 would have been unrecognisable to anyone from 1900. James May takes a look at some of the greatest developments of the 20th century, and reveals how they shaped the times we live in now.", 1, 6, 2007, "BBC Two");


            //List<Serie> listeSeriesRecuperees = new List<Serie> { serie2, };

            // Assert.IsInstanceOfType(result, typeof(ActionResult<Serie>), "Pas une serie"); // Test du type de retour
            Assert.AreNotEqual(result, serie2);
        }

        [TestMethod()]
        public void PutSerieTest()
        {

        }

        [TestMethod()]
        public void PostSerieTest()
        {

        }

        [TestMethod()]
        public void DeleteSerieTest()
        {

            
        }
    }
}