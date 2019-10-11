// <snippettransactioncurrencyexchangerate1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 // using the service context makes retrieving entities easier
 using (_context = new ServiceContext(_serviceProxy))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     String currentOrganizatoinUniqueName = GetCurrentOrganizationName(serverConfig);

     CreateRequiredRecords();

     RetrieveExchangeRateRequest request = new RetrieveExchangeRateRequest()
     {
         TransactionCurrencyId = _currency.Id
     };
     RetrieveExchangeRateResponse response = 
         (RetrieveExchangeRateResponse)_serviceProxy.Execute(request);
     Console.WriteLine("  Retrieved exchange rate for created currency");

     // get the base currency for the current org
     var baseCurrencyName = 
         (from currency in _context.TransactionCurrencySet
          join org in _context.OrganizationSet 
          on currency.Id equals org.BaseCurrencyId.Id
          where org.Name == currentOrganizatoinUniqueName
          select currency.CurrencyName).FirstOrDefault();
     Console.WriteLine("  This organization's base currency is {0}",
         baseCurrencyName);

     Console.WriteLine(
         "  The conversion from {0} -> {1} is {2}",
         _currency.CurrencyName,
         baseCurrencyName,
         response.ExchangeRate);

     DeleteRequiredRecords(promptforDelete);
 }

// </snippettransactioncurrencyexchangerate1>