// <snippetupdateanddelete2>


 // Delete the account record only if the row version matches.
 EntityReference accountToDelete = new EntityReference("account", _accountId);
 accountToDelete.RowVersion = _accountRowVersion;

 DeleteRequest request = new DeleteRequest()
 {
     Target = accountToDelete,
     ConcurrencyBehavior = ConcurrencyBehavior.IfRowVersionMatches
 };
 
 _serviceProxy.Execute(request);

// </snippetupdateanddelete2>