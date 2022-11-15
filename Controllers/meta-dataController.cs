using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Contracts;

namespace WebApi2.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class meta_dataController : ControllerBase
    {
        private readonly IUserService userContract;

        public meta_dataController(IUserService userContract)
        {
            this.userContract = userContract;
        }
        // meta data
        [HttpGet]
        [Route("[Action]/{key}")]
        public IResult ref_Set(int key)
        {

            return Results.Ok(userContract.GetMetadata(key));
        }
    }
}
