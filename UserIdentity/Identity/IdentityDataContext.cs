using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserIdentity.Identity
{
    public class IdentityDataContext:IdentityDbContext<AplicationUser>
    {
        public IdentityDataContext():base("identityConnection")
        {

        }
    }
}