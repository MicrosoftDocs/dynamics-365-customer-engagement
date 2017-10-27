// <snippettwowaylistener1>


 ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.Http;

 Console.Write("Enter your Azure service namespace: ");
 string serviceNamespace = Console.ReadLine();

 // The service namespace issuer name to use.  If one hasn't been setup
 // explicitly it will be the default issuer name listed on the service
 // namespace.
 Console.Write("Enter your service namespace issuer name: ");
 string issuerName = Console.ReadLine();

 // Issuer secret is the Windows Azure Service Bus namespace current management key.
 Console.Write("Enter your service namespace issuer key: ");
 string issuerKey = Console.ReadLine();

 // Input the same path that was specified in the Service Bus Configuration dialog
 // when registering the Azure-aware plug-in with the Plug-in Registration tool.
 Console.Write("Enter your endpoint path: ");
 string servicePath = Console.ReadLine();

 // Leverage the Azure API to create the correct URI.
 Uri address = ServiceBusEnvironment.CreateServiceUri(
     Uri.UriSchemeHttps,
     serviceNamespace,
     servicePath);

 Console.WriteLine("The service address is: " + address);

 // Create the shared secret credentials object for the endpoint matching the 
 // Azure access control services issuer 
 var sharedSecretServiceBusCredential = new TransportClientEndpointBehavior()
 {
     TokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName, issuerKey)
 };

 // Using an HTTP binding instead of a SOAP binding for this endpoint.
 WS2007HttpRelayBinding binding = new WS2007HttpRelayBinding();
 binding.Security.Mode = EndToEndSecurityMode.Transport;

 // Create the service host for Azure to post messages to.
 ServiceHost host = new ServiceHost(typeof(TwoWayEndpoint));
 host.AddServiceEndpoint(typeof(ITwoWayServiceEndpointPlugin), binding, address);

 // Create the ServiceRegistrySettings behavior for the endpoint.
 var serviceRegistrySettings = new ServiceRegistrySettings(DiscoveryType.Public);

 // Add the service bus credentials to all endpoints specified in configuration.

 foreach (var endpoint in host.Description.Endpoints)
 {
     endpoint.Behaviors.Add(serviceRegistrySettings);
     endpoint.Behaviors.Add(sharedSecretServiceBusCredential);
 }

 // Begin listening for messages posted to Azure.
 host.Open();

 Console.WriteLine(Environment.NewLine + "Listening for messages from Azure" +
     Environment.NewLine + "Press [Enter] to exit");

 // Keep the listener open until Enter is pressed.
 Console.ReadLine();

 Console.Write("Closing the service host...");
 host.Close();
 Console.WriteLine(" done.");

// </snippettwowaylistener1>