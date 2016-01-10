using Checkout;
using Checkout.ApiServices.SharedModels;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    [TestFixture(Category = "CardsApi")]
    public class DrinkApiTests
    {
        APIClient CheckoutClient;

        [SetUp]
        public void Init()
        { CheckoutClient = new APIClient(); }

        [Test]
        public void CreateDrink()
        {
            var response = CheckoutClient.DrinkService.CreateDrink("Pepsi");
        }

        [Test]
        public void GetDrink()
        {
            var drink = CheckoutClient.DrinkService.CreateDrink("Pepsi");
            var response = CheckoutClient.DrinkService.GetDrink("Pepsi");
            Assert.NotNull(response);
            Assert.IsTrue(response.HttpStatusCode == System.Net.HttpStatusCode.OK);
        }

        [Test]
        public void GetDrinkList()
        {
            var drink1 = CheckoutClient.DrinkService.CreateDrink("Pepsi");
            var drink2 = CheckoutClient.DrinkService.CreateDrink("Cola");
            var response = CheckoutClient.DrinkService.GetDrinkList();

            Assert.NotNull(response);
            Assert.IsTrue(response.HttpStatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(response.Model.Count() == 2);
        }

        [Test]
        public void UpdateDrink()
        {
            var drink = CheckoutClient.DrinkService.CreateDrink("Pepsi");
            var updateDrink = CheckoutClient.DrinkService.UpdateDrink("Pepsi", 2);
            var response = CheckoutClient.DrinkService.GetDrink("Pepsi");

            Assert.NotNull(response);
            Assert.IsTrue(response.HttpStatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(response.Model.Quantity == 2);
        }

        [Test]
        public void DeleteDrink()
        {
            var drink = CheckoutClient.DrinkService.CreateDrink("Pepsi");
            var deleteDrink = CheckoutClient.DrinkService.DeleteDrink("Pepsi");
            var response = CheckoutClient.DrinkService.GetDrinkList();

            Assert.NotNull(response);
            Assert.IsTrue(response.HttpStatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(response.Model.Count() == 0);
        }

    }
}
