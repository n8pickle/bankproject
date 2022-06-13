using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Domain;
using Services;

namespace Controllers;

/*
    This Route attribute can only be used on a class that inherets one of the Controller classes from the AspNetCore.Mvc package
    The Route attribute will decide what the url is that you call when you are making a request to your endpoint.
    For example right here we are saying we will call "host:port/api/Transaction" the [Controller] inside the route string is
    a special pattern matching that takes whatever is in the name of the class minus the "Controller" part.
*/
[Route("api/[Controller]")]
public class TransactionController : Controller {

    private ITransactionService _transService;

    /*
        This is the constructor. To function properly we need to have access to the ITransactionService
        So here we are passing it in. Check out the Program.cs and look at the addTransient Method. 
        ITransactionService holds all of the methods we will call in the controller
    */
    public TransactionController(ITransactionService transService) {
        _transService = transService;
    }

    /*
        Below is a pattern used to organize each level of file. The controller is the first layer then the Service then the Repository.
        This design pattern follows the MVC pattern, which is to help the code adhere to SOLID principles. (please google if you aren't sure what that is)
        The Controller is in charge of recieving http requests. That is it's main function adhering to the Single Responsibility principle from SOLID.
        In some controllers you will see people transform what they call a request object into a data-transfer object. What that means is you will simply
        change the structure of the object
        i.e.
        transRO = TransactionRequestObject: {
            Id int: 1
            Type string: "ACH"
            Amount string: "$100.00"
        }
        
        transformed to:

        transDto = TransactionDto: {
            transId int: transRO.Id
            transType string: "ACH"
            amnt decimal: decimal.TryParse(transRO.Amount)
        }
    */

    //CRUD - CREATE, READ, UPDATE, DELETE
    
    // Create api's
    [HttpPost]
    [Route("transaction")]
    public async Task<IActionResult> CreateTransaction([FromBody]Transaction trans) {
        // surround all the code in the controller in Try/Catch. This is good practice for getting errors
        try {
            // Always use await when calling Async functions
            await _transService.CreateTransaction(trans);
            //This is returning an 200 status code even though it should probably be 201
            return new OkObjectResult("");
        } catch (Exception e) {
            Console.WriteLine($"Request failed with Stack Trace: {e} \n\n");
            // BadRequest should only ever get used if the data sent is bad, but we are going to use it anyway here.
            return new BadRequestObjectResult("There was an error with your request data");
        }
    }

    // Read api's

}