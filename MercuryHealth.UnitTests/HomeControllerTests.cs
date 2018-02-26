using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MercuryHealth.Web.Controllers;
using System.Web.Mvc;
using MercuryHealth.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.QualityTools.Testing.Fakes;
using MercuryHealth.Web.Models.Fakes;
using System.Web.Mvc.Fakes;

namespace MercuryHealth.UnitTest
{
    [TestClass]
    public class HomeControlerTests
    {
        [TestMethod]
        [TestCategory("Unit Tests")]
        public void HomeIndex()
        {
            var homeController = new HomeController();
            ViewResult result = homeController.Index() as ViewResult;
            var viewName = result.ViewName;

            // checking that homecontroller.index goes to the page
            Assert.AreEqual("", viewName);

        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        public void HomeAbout()
        {
            var homeController = new HomeController();
            ViewResult result = homeController.About() as ViewResult;
            var viewName = result.ViewName;

            // checking that homecontroller.index goes to the page
            Assert.AreEqual("", viewName);

        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        public void HomeContact()
        {
            var homeController = new HomeController();
            ViewResult result = homeController.Contact() as ViewResult;
            var viewName = result.ViewName;

            // checking that homecontroller.index goes to the page
            Assert.AreEqual("", viewName);

        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        public void HomeExercises()
        {
            var homeController = new HomeController();
            ViewResult result = homeController.Contact() as ViewResult;
            var viewName = result.ViewName;

            // checking that homecontroller.index goes to the page
            Assert.AreEqual("", viewName);

        }


        [TestMethod]
        [TestCategory("Unit Tests")]
        public void HomeNutrition()
        {
            var homeController = new HomeController();
            ViewResult result = homeController.Contact() as ViewResult;
            var viewName = result.ViewName;

            // checking that homecontroller.index goes to the page
            Assert.AreEqual("", viewName);

        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        public void HomeRegister()
        {
            var homeController = new HomeController();
            ViewResult result = homeController.Contact() as ViewResult;
            var viewName = result.ViewName;

            // checking that homecontroller.index goes to the page
            Assert.AreEqual("", viewName);

        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        public void HomeLogin()
        {
            var homeController = new HomeController();
            ViewResult result = homeController.Contact() as ViewResult;
            var viewName = result.ViewName;

            // checking that homecontroller.index goes to the page
            Assert.AreEqual("", viewName);

        }

        [TestMethod]
        [TestCategory("Unit Tests")]
        public void HomeMyMetrics()
        {
            var homeController = new HomeController();
            ViewResult result = homeController.Contact() as ViewResult;
            var viewName = result.ViewName;

            // checking that homecontroller.index goes to the page
            Assert.AreEqual("", viewName);

        }

    }
}
