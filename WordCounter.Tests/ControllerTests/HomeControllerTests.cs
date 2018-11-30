using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]

    public void index_ReturnCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      ActionResult IndexView = controller.Index();

      Assert.IsInstanceOfType(IndexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnCorrectActonType_RedirectToActionResult()
    {
      //Arrange
      RepeatCounterController controller = new RepeatCounterController();

      //Act
      IActionResult view = controller.Create("word", "sentence");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectCorrectAction_Index()
    {
      //Arrange
      RepeatCounterController controller = new RepeatCounterController();
      RedirectToActionResult actionResult = controller.Create("word", "sentence") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
    }
  }
