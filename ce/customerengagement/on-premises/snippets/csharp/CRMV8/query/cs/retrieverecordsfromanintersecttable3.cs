// <snippetretrieverecordsfromanintersecttable3>


 #region Retrieve records from an intersect table via LINQ

 // Obtain the Organization Context.
 OrganizationServiceContext context = new OrganizationServiceContext(_serviceProxy);

 // Create Linq Query.
 var roles = (from r in context.CreateQuery<Role>()
              join s in context.CreateQuery<SystemUserRoles>() on r.RoleId equals s.RoleId
              where s.SystemUserId == _userId
              orderby r.RoleId
              select r.Name);

 // Display results.
 foreach (var role in roles)
 {
     Console.WriteLine("Linq Retrieved: {0}", role);
 }

 #endregion

// </snippetretrieverecordsfromanintersecttable3>