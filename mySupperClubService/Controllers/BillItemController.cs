using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using mySupperClubService.DataObjects;
using mySupperClubService.Models;

namespace mySupperClubService.Controllers
{
    public class BillItemController : TableController<BillItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            mySupperClubContext context = new mySupperClubContext();
            DomainManager = new EntityDomainManager<BillItem>(context, Request);
        }

        // GET tables/BillItems
        public IQueryable<BillItem> GetAllBillItems()
        {
            return Query();
        }

        // GET tables/BillItems/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<BillItem> GetBillItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/BillItems/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<BillItem> PatchBillItem(string id, Delta<BillItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/BillItems
        public async Task<IHttpActionResult> PostBillItem(BillItem item)
        {
            BillItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/BillItems/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteBillItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}