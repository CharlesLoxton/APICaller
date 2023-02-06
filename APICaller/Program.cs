using APICaller;
using System.Text;

Console.WriteLine("Hello, World!");

var api = new APIRequests();

//var response1 = api.AddClient("TestClient1", "63fdsf87sd8f7sd8");
//var response2 = api.AddClient("TestClient2", "53fdsf87sd8f7sd8");

//This makes two Update calls to the api at the same time, the one with the smallest payload will execute first
var response1 = api.UpdateClient("17", "TestClient3", "123", "sfdudshfsdfsd7fs");
var response2 = api.UpdateClient("17", "TestClient4", "123", "dfdfdsfsdfsd");

// Wait for both requests to complete
await Task.WhenAll(response1, response2);

// Write out the responses
Console.WriteLine("First request response: " + await response1.Result.Content.ReadAsStringAsync());
Console.WriteLine("Second request response: " + await response2.Result.Content.ReadAsStringAsync());

Console.WriteLine("Both requests completed");
Console.ReadLine();