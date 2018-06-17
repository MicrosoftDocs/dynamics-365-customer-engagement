// <snippetonewaylistener>


using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

using Microsoft.Xrm.Sdk;
using Microsoft.ServiceBus;

namespace Microsoft.Crm.Sdk.Samples
{
    [ServiceBehavior]
    class RemoteService : IServiceEndpointPlugin
    {
        #region IServiceEndpointPlugin Member

        public void Execute(RemoteExecutionContext context)
        {
            Utility.Print(context);
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.Http;

            Console.Write("Your Service Namespace: ");
            string serviceNamespace = Console.ReadLine();
            Console.Write("Your Issuer Name: ");
            string issuerName = Console.ReadLine();

            // The issuer secret is the Service Bus namespace management key.
            Console.Write("Your Issuer Secret: ");
            string issuerSecret = Console.ReadLine();

            // Create the service URI based on the service namespace.
            Uri address = ServiceBusEnvironment.CreateServiceUri(Uri.UriSchemeHttps, serviceNamespace, "RemoteService");
            Console.WriteLine("Service address: " + address);

            // Create the credentials object for the endpoint.
            TransportClientEndpointBehavior sharedSecretServiceBusCredential = new TransportClientEndpointBehavior() 
            {
                TokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName, issuerSecret)
            };
            
            // Create the binding object.
            WS2007HttpRelayBinding binding = new WS2007HttpRelayBinding();
            binding.Security.Mode = EndToEndSecurityMode.Transport;

            // Create the service host reading the configuration.
            ServiceHost host = new ServiceHost(typeof(RemoteService));
            host.AddServiceEndpoint(typeof(IServiceEndpointPlugin), binding, address);

            // Create the ServiceRegistrySettings behavior for the endpoint.
            IEndpointBehavior serviceRegistrySettings = new ServiceRegistrySettings(DiscoveryType.Public);

            // Add the Service Bus credentials to all endpoints specified in configuration.
            foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
            {
                endpoint.Behaviors.Add(serviceRegistrySettings);
                endpoint.Behaviors.Add(sharedSecretServiceBusCredential);
            }

            // Open the service.
            host.Open();

            Console.WriteLine("Press [Enter] to exit");
            Console.ReadLine();

            // Close the service.
            Console.Write("Closing the service host...");
            host.Close();
            Console.WriteLine(" done.");
        }
    }

    internal static class Utility
    {
        public static void Print(RemoteExecutionContext context)
        {
            Console.WriteLine("----------");
            if (context == null)
            {
                Console.WriteLine("Context is null.");
                return;
            }

            Console.WriteLine("UserId: {0}", context.UserId);
            Console.WriteLine("OrganizationId: {0}", context.OrganizationId);
            Console.WriteLine("OrganizationName: {0}", context.OrganizationName);
            Console.WriteLine("MessageName: {0}", context.MessageName);
            Console.WriteLine("Stage: {0}", context.Stage);
            Console.WriteLine("Mode: {0}", context.Mode);
            Console.WriteLine("PrimaryEntityName: {0}", context.PrimaryEntityName);
            Console.WriteLine("SecondaryEntityName: {0}", context.SecondaryEntityName);

            Console.WriteLine("BusinessUnitId: {0}", context.BusinessUnitId);
            Console.WriteLine("CorrelationId: {0}", context.CorrelationId);
            Console.WriteLine("Depth: {0}", context.Depth);
            Console.WriteLine("InitiatingUserId: {0}", context.InitiatingUserId);
            Console.WriteLine("IsExecutingOffline: {0}", context.IsExecutingOffline);
            Console.WriteLine("IsInTransaction: {0}", context.IsInTransaction);
            Console.WriteLine("IsolationMode: {0}", context.IsolationMode);
            Console.WriteLine("Mode: {0}", context.Mode);
            Console.WriteLine("OperationCreatedOn: {0}", context.OperationCreatedOn.ToString());
            Console.WriteLine("OperationId: {0}", context.OperationId);
            Console.WriteLine("PrimaryEntityId: {0}", context.PrimaryEntityId);
            Console.WriteLine("OwningExtension LogicalName: {0}", context.OwningExtension.LogicalName);
            Console.WriteLine("OwningExtension Name: {0}", context.OwningExtension.Name);
            Console.WriteLine("OwningExtension Id: {0}", context.OwningExtension.Id);
            Console.WriteLine("SharedVariables: {0}", (context.SharedVariables == null ? "NULL" :
                SerializeParameterCollection(context.SharedVariables)));
            Console.WriteLine("InputParameters: {0}", (context.InputParameters == null ? "NULL" :
                SerializeParameterCollection(context.InputParameters)));
            Console.WriteLine("OutputParameters: {0}", (context.OutputParameters == null ? "NULL" :
                SerializeParameterCollection(context.OutputParameters)));
            Console.WriteLine("PreEntityImages: {0}", (context.PreEntityImages == null ? "NULL" :
                SerializeEntityImageCollection(context.PreEntityImages)));
            Console.WriteLine("PostEntityImages: {0}", (context.PostEntityImages == null ? "NULL" :
                SerializeEntityImageCollection(context.PostEntityImages)));
            Console.WriteLine("----------");
        }

        #region Private methods.
        private static string SerializeEntity(Entity e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append(" LogicalName: " + e.LogicalName);
            sb.Append(Environment.NewLine);
            sb.Append(" EntityId: " + e.Id);
            sb.Append(Environment.NewLine);
            sb.Append(" Attributes: [");
            foreach (KeyValuePair<string, object> parameter in e.Attributes)
            {
                sb.Append(parameter.Key + ": " + parameter.Value + "; ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        private static string SerializeParameterCollection(ParameterCollection parameterCollection)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, object> parameter in parameterCollection)
            {
                if (parameter.Value != null && parameter.Value.GetType() == typeof(Entity))
                {
                    Entity e = (Entity)parameter.Value;
                    sb.Append(parameter.Key + ": " + SerializeEntity(e));
                }
                else
                {
                    sb.Append(parameter.Key + ": " + parameter.Value + "; ");
                }
            }
            return sb.ToString();
        }

        private static string SerializeEntityImageCollection(EntityImageCollection entityImageCollection)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, Entity> entityImage in entityImageCollection)
            {
                sb.Append(Environment.NewLine);
                sb.Append(entityImage.Key + ": " + SerializeEntity(entityImage.Value));
            }
            return sb.ToString();
        }
        #endregion
    }
}

// </snippetonewaylistener>