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
    public class EventController : TableController<Event>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            mySupperClubContext context = new mySupperClubContext();
            DomainManager = new EntityDomainManager<Event>(context, Request);
        }

        // GET tables/Events
        public IQueryable<Event> GetAllEvents()
        {
            return Query();
        }

        // GET tables/Events/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Event> GetEvent(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Events/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Event> PatchEvent(string id, Delta<Event> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Events
        public async Task<IHttpActionResult> PostEvent(Event item)
        {
            Event current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Events/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteEvent(string id)
        {
            return DeleteAsync(id);
        }
    }
}