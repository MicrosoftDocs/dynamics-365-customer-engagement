' <snippetinitializefrom1>



 '					#Region "Initialize Account from Account"
 Console.WriteLine()
 Console.WriteLine("  Initializing new Account from the initial Account")

 ' Create the request object
 Dim initialize As New InitializeFromRequest()

 ' Set the properties of the request object
 initialize.TargetEntityName = Account.EntityLogicalName.ToString()

 ' Create the EntityMoniker
 initialize.EntityMoniker = _initialAccount.ToEntityReference()

 ' Execute the request
 Dim initialized As InitializeFromResponse =
     CType(_serviceProxy.Execute(initialize), InitializeFromResponse)

 If initialized.Entity IsNot Nothing Then
     Console.WriteLine("  New Account initialized successfully")
 End If

 Console.WriteLine()
 '					#End Region

 '					#Region "Initialize Opportunity from Lead"
 Console.WriteLine("  Initializing an Opportunity from the initial Lead")

 ' Create the request object
 initialize.TargetEntityName = Opportunity.EntityLogicalName.ToString()

 ' Create the EntityMoniker
 initialize.EntityMoniker = _initialLead.ToEntityReference()

 ' Execute the request
 initialized = CType(_serviceProxy.Execute(initialize), InitializeFromResponse)

 If initialized.Entity IsNot Nothing AndAlso
     initialized.Entity.LogicalName = Opportunity.EntityLogicalName Then
     Dim opportunity = CType(initialized.Entity, Opportunity)
     Console.WriteLine("  New Opportunity initialized successfully (Name={0})",
                       opportunity.Name)
 End If
 '					#End Region

' </snippetinitializefrom1>