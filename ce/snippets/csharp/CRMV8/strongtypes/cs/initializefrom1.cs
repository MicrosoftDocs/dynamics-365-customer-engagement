// <snippetinitializefrom1>



 #region Initialize Account from Account
 Console.WriteLine();
 Console.WriteLine("  Initializing new Account from the initial Account");

 // Create the request object
 InitializeFromRequest initialize = new InitializeFromRequest();

 // Set the properties of the request object
 initialize.TargetEntityName = Account.EntityLogicalName.ToString();

 // Create the EntityMoniker
 initialize.EntityMoniker = _initialAccount.ToEntityReference();

 // Execute the request
 InitializeFromResponse initialized = 
     (InitializeFromResponse)_serviceProxy.Execute(initialize);

 if (initialized.Entity != null)
     Console.WriteLine("  New Account initialized successfully");

 Console.WriteLine();
 #endregion

 #region Initialize Opportunity from Lead
 Console.WriteLine("  Initializing an Opportunity from the initial Lead");

 // Create the request object
 initialize.TargetEntityName = Opportunity.EntityLogicalName.ToString();

 // Create the EntityMoniker
 initialize.EntityMoniker = _initialLead.ToEntityReference();

 // Execute the request
 initialized =
     (InitializeFromResponse)_serviceProxy.Execute(initialize);

 if (initialized.Entity != null &&
     initialized.Entity.LogicalName == Opportunity.EntityLogicalName)
 {
     var opportunity = (Opportunity)initialized.Entity;
     Console.WriteLine("  New Opportunity initialized successfully (Name={0})",
         opportunity.Name);
 }
 #endregion

// </snippetinitializefrom1>