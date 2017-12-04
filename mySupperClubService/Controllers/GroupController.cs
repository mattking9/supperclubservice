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
    public class GroupController : TableController<Group>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            mySupperClubContext context = new mySupperClubContext();
            DomainManager = new EntityDomainManager<Group>(context, Request);
        }

        // GET tables/groups
        public IQueryable<Group> GetAllGroups()
        {
            return Query();
        }

        // GET tables/groups/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Group> GetGroup(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/groups/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Group> PatchGroup(string id, Delta<Group> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/groups
        public async Task<IHttpActionResult> PostGroup(Group item)
        {
            Group current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/groups/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteGroup(string id)
        {
            return DeleteAsync(id);
        }
    }
}