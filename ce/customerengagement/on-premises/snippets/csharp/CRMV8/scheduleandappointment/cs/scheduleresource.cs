// <snippetscheduleresource>


using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to schedule a resource.
    /// </summary>
    public class ScheduleResource
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _vanId;
        public Guid _groupId;
        public Guid _specId;
        public Guid _plumberServiceId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// Schedule a resource.        
        /// Optionally delete any entity records that were created for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Create the van required resource object.
                    RequiredResource vanReq = new RequiredResource
                    {
                        ResourceId = _vanId,
                        ResourceSpecId = _specId
                    };

                    // Create the appointment request.
                    AppointmentRequest appointmentReq = new AppointmentRequest
                    {
                        RequiredResources = new RequiredResource[] { vanReq },
                        Direction = SearchDirection.Backward,
                        Duration = 60,
                        NumberOfResults = 10,
                        ServiceId = _plumberServiceId,
                        // The search window describes the time when the resource can be scheduled.
                        // It must be set.
                        SearchWindowStart = DateTime.Now.ToUniversalTime(),
                        SearchWindowEnd = DateTime.Now.AddDays(7).ToUniversalTime(),
                        UserTimeZoneCode = 1
                    };

                    // Verify whether there are openings available to schedule the appointment using this resource              
                    SearchRequest search = new SearchRequest
                    {
                        AppointmentRequest = appointmentReq
                    };
                    SearchResponse searched = (SearchResponse)_serviceProxy.Execute(search);

                    if (searched.SearchResults.Proposals.Length > 0)
                    {
                        Console.WriteLine("Openings are available to schedule the resource.");
                    }

                    DeleteRequiredRecords(promptForDelete);
                }
            }
            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        /// <summary>
        /// This method creates any entity records that this sample requires.        
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Get the current user's information.
            WhoAmIRequest userRequest = new WhoAmIRequest();
            WhoAmIResponse userResponse = (WhoAmIResponse)_serviceProxy.Execute(userRequest);

            // Create the van resource.
            Equipment van = new Equipment
            {
                Name = "Van 1",
                TimeZoneCode = 1,
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName, userResponse.BusinessUnitId)
            };

            _vanId = _serviceProxy.Create(van);

            Console.WriteLine("Created a sample equipment: {0}.", van.Name);

            // Create the contraints for creating the plumber resource group
            System.Text.StringBuilder builder = new System.Text.StringBuilder("<Constraints>");
            builder.Append("<Constraint>");
            builder.Append("<Expression>");
            builder.Append("<Body>resource[\"Id\"] == ");
            builder.Append(userResponse.UserId.ToString("B"));
            builder.Append(" || resource[\"Id\"] == ");
            builder.Append(_vanId.ToString("B"));
            builder.Append("</Body>");
            builder.Append("<Parameters>");
            builder.Append("<Parameter name=\"resource\" />");
            builder.Append("</Parameters>");
            builder.Append("</Expression>");
            builder.Append("</Constraint>");
            builder.Append("</Constraints>");

            // Define an anonymous type to define the possible constraint based group type code values.
            var ConstraintBasedGroupTypeCode = new
            {
                Static = 0,
                Dynamic = 1,
                Implicit = 2
            };
            // Create the plumber resource group.
            ConstraintBasedGroup group = new ConstraintBasedGroup
            {
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName, userResponse.BusinessUnitId),
                Name = "Plumber with Van 1",
                Constraints = builder.ToString(),
                GroupTypeCode = new OptionSetValue(ConstraintBasedGroupTypeCode.Static),
            };

            _groupId = _serviceProxy.Create(group);

            Console.WriteLine("Created a sample resource group: {0}.", group.Name);

            // Create the resource specification.
            ResourceSpec spec = new ResourceSpec
            {
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName, userResponse.BusinessUnitId),
                ObjectiveExpression = @"
					<Expression>
						<Body>udf ""Random""(factory,resource,appointment,request,leftoffset,rightoffset)</Body>
						<Parameters>
							<Parameter name=""factory"" />
							<Parameter name=""resource"" />
							<Parameter name=""appointment"" />
							<Parameter name=""request"" />
							<Parameter name=""leftoffset"" />
							<Parameter name=""rightoffset"" />
						</Parameters>
						<Properties EvaluationInterval=""P0D"" evaluationcost=""0"" />
					</Expression>",
                RequiredCount = 1,
                Name = "Test Spec",
                GroupObjectId = _groupId
            };
            _specId = _serviceProxy.Create(spec);

            // Create the plumber required resource object.
            RequiredResource plumberReq = new RequiredResource
            {
                ResourceId = userResponse.UserId,   // assume current user is the plumber
                ResourceSpecId = _specId
            };


            // Create the service for the equipment.
            Service plumberService = new Service
            {
                Name = "Plumber 1",
                Duration = 60,
                InitialStatusCode = new OptionSetValue(1),
                Granularity = "FREQ=MINUTELY;INTERVAL=15;",
                ResourceSpecId = new EntityReference(ResourceSpec.EntityLogicalName, _specId)
            };

            _plumberServiceId = _serviceProxy.Create(plumberService);

            Console.WriteLine("Created a sample service for the equipment: {0}.", plumberService.Name);
        }


        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Service.EntityLogicalName, _plumberServiceId);
                _serviceProxy.Delete(Equipment.EntityLogicalName, _vanId);
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How To Sample Code

        #region Main
        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                ScheduleResource app = new ScheduleResource();
                app.Run(config, true);
            }

            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe
                        = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {

                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }

        }
        #endregion Main
    }
}

// </snippetscheduleresource>