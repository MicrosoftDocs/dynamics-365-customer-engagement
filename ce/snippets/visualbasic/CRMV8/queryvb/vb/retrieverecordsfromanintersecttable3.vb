' <snippetretrieverecordsfromanintersecttable3>


 '					#Region "Retrieve records from an intersect table via LINQ"

 ' Obtain the Organization Context.
 Dim context As New OrganizationServiceContext(_serviceProxy)

 ' Create Linq Query.
 Dim roles = ( _
     From r In context.CreateQuery(Of Role)() _
     Join s In context.CreateQuery(Of SystemUserRoles)() _
     On r.RoleId Equals s.RoleId _
     Where s.SystemUserId.Equals(_userId) _
     Order By r.RoleId _
     Select r.Name)

 ' Display results.
 For Each role In roles
     Console.WriteLine("Linq Retrieved: {0}", role)
 Next role

 '					#End Region

' </snippetretrieverecordsfromanintersecttable3>