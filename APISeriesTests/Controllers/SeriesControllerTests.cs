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

namespace APISeries.Controllers.Tests
{

    [ClassInitialize]

    [TestClass()]
    public class SeriesControllerTests
    {
        [TestMethod()]
        public void SeriesControllerTest()
        {
            var builder = new DbContextOptionsBuilder<SeriesDbContext>().UseNpgsql("Server=localhost;port=5432;Database=SeriesDB; uid=postgres;password=postgres;");
            SeriesDbContext _context = new SeriesDbContext(builder.Options);
        }

        [TestMethod()]
        public void GetSeriesTest()
        {

        }

        [TestMethod()]
        public void GetSerieTest()
        {

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