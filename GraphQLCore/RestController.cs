using GraphQLSample;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GraphQLCore
{
    public class RestController : Controller
    {
        private Repository _repository;

        public RestController(Repository repository)
        {
            _repository = repository;
        }

        [Route("GetAccountDetails")]
        public ActionResult GetAccountDetails()
        {
            var Result = _repository.GetAccountDetails();
            return Ok(Result);
        }

        [Route("GetBranchDetails")]
        public ActionResult GetBranchDetails()
        {
            var Result = _repository.GetBranchDetails();
            return Ok(Result);
        }

        [Route("GetAccountByAccountId")]
        public ActionResult GetAccountByAccountId(int Id)
        {
            var Result = _repository.GetAccountByAccountId(Id);
            return Ok(Result);
        }

        [Route("GetBranchByBranchId")]
        public ActionResult GetBranchByBranchId(int Id)
        {
            var Result = _repository.GetBranchByBranchId(Id);
            return Ok(Result);
        }
    }
}
