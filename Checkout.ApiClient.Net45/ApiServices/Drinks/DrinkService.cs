using Checkout.ApiServices.Drinks.ResponseModels;
using Checkout.ApiServices.SharedModels;
using System.Collections.Generic;

namespace Checkout.ApiServices.Drinks
{
    public class DrinkService
    {

        public HttpResponse<string> CreateDrink(string drinkName)
        {
            var createDrinkUri = string.Format(ApiUrls.Drink, drinkName);
            return new ApiHttpClient().PostRequest<string>(createDrinkUri, AppSettings.SecretKey);
        }

        public HttpResponse<DrinkRecord> GetDrink(string drinkName)
        {
            var getDrinkUri = string.Format(ApiUrls.Drink, drinkName);
            return new ApiHttpClient().GetRequest<DrinkRecord>(getDrinkUri, AppSettings.SecretKey);
        }

        public HttpResponse<OkResponse> UpdateDrink(string drinkName, int drinkQuantity)
        {
            var updateDrinkUri = string.Format(ApiUrls.Drink, drinkName);
            return new ApiHttpClient().PutRequest<OkResponse>(updateDrinkUri, AppSettings.SecretKey, drinkQuantity);
        }

        public HttpResponse<OkResponse> DeleteDrink(string drinkName)
        {
            var deleteDrinkUri = string.Format(ApiUrls.Drink, drinkName);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteDrinkUri, AppSettings.SecretKey);
        }

        public HttpResponse<IEnumerable<DrinkRecord>> GetDrinkList()
        {
            var getDrinkListUri = string.Format(ApiUrls.Drink, "");
            return new ApiHttpClient().GetRequest<IEnumerable<DrinkRecord>>(getDrinkListUri, AppSettings.SecretKey);
        }

    }
}