using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterControllerTest
  {
    [TestMethod]

    public void New_ReturnCorrectView_True()
    {
      //Arrange
      RepeatCounterController controller = new RepeatCounterController();

      //Act
      ActionResult newView = controller.New();

      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    // [TestMethod]
    // public void Create_ReturnsCorrectActionType_ViewResult()
    // {
    //     //Arrange
    //     ReapeatCounterController controller = new ReapeatCounterController();
    //
    //     //Act
    //     IActionResult view = controller.Output("cat","my cat");
    //
    //     //Assert
    //     Assert.IsInstanceOfType(view, typeof(ViewResult));
    //     var viewResult = view as ViewResult;
    //
    //     Assert.IsInstanceOfType(viewResult.Model, typeof(ReapeatCounter));
    //     var model = viewResult.Model as ReapeatCounter;
    //
    //     Assert.AreEqual(model.GetWord(), "cat");
    //     Assert.AreEqual(model.GetSentence(), "my cat");
    //
    // }
  }
}
