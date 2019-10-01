' <snippettransactioncurrencyexchangerate1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' using the service context makes retrieving entities easier
     _context = New ServiceContext(_serviceProxy)
     Using _context
         ' This statement is required to enable early-bound type support.
         _serviceProxy.EnableProxyTypes()

         Dim currentOrganizatoinUniqueName As String = GetCurrentOrganizationUniqueName(serverConfig)

         CreateRequiredRecords()

         Dim request As New RetrieveExchangeRateRequest() With
             {
                 .TransactionCurrencyId = _currency.Id
             }
         Dim response As RetrieveExchangeRateResponse =
             CType(_serviceProxy.Execute(request), 
                 RetrieveExchangeRateResponse)
         Console.WriteLine("  Retrieved exchange rate for created currency")

         ' get the base currency for the current org
         Dim baseCurrencyName = ( _
             From currency In _context.TransactionCurrencySet _
             Join org In _context.OrganizationSet On currency.Id Equals org.BaseCurrencyId.Id _
             Where org.Name.Equals(serverConfig.OrganizationName) _
             Select currency.CurrencyName).First()
         Console.WriteLine("  This organization's base currency is {0}", baseCurrencyName)

         Console.WriteLine("  The conversion from {0} -> {1} is {2}",
                           _currency.CurrencyName, baseCurrencyName, response.ExchangeRate)

         DeleteRequiredRecords(promptforDelete)
     End Using
 End Using

' </snippettransactioncurrencyexchangerate1>