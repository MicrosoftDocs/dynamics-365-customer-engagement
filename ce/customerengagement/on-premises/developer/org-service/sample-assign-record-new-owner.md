---
title: "Sample: Assign a record to a new owner (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to assign an account to another user by using the AssignRequest message"
keywords: 
ms.date: 12/15/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: b8a256a4-e858-44bc-aff7-26b4d670fc61
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: "pehecke"
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - samples for early-bound classes, assigning records to new owners sample
  - assigning records to new owners sample, early-bound class samples
  - early-bound class samples, assigning records to new owners sample
  - sample for assigning records to new owners
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Assign a record to a new owner

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the Sample: [Work with early bound entity classes in code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/EarlyBound).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
 This sample code requires that you have administrator rights to create a new user. [!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]  
 
> [!NOTE]
> This sample uses the `IOrganization.Update` method rather than the `AssignRequest` because there is an effort to remove specialized messages. More information: [Perform speciliazed operations using update](perform-specialized-operations-using-update.md)

## Example  
 This sample shows how to assign an account to another user by using the [IOrganizationService.Update](https://docs.microsoft.com/en-us/dotnet/api/microsoft.xrm.sdk.iorganizationservice.update?view=dynamics-general-ce-9) message.  
  
```csharp
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages; 
using Microsoft.Xrm.Sdk.Client;  

namespace Microsoft.Crm.Sdk.Samples
{
	/// <summary>
	/// This Sample shows how to assign an account to another user.
    /// </summary>
    /// <remarks>
    /// Note: This sample expects another user to be present in 
    /// the current business unit other than the current credentials.
    /// </remarks>
    
	
	public class Assign
	{
        #region Class Level Members
        

        // Define the IDs needed for this sample.
        private Guid _accountId;   
        private Guid _myUserId;
        private Guid _otherUserId;



        // Declare the service proxy referring the CRUD
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        #endregion Class Level Members
        
        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Retrieves new owner's details and creates an account record.
        /// Assign the account to new owner.
        /// Optionally delete any entity records that were created for this sample.
        // </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    _service = (IOrganizationService)_serviceProxy;

                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();
                    
		    // Retrieve the account record created
                    Entity accountRecord = _service.Retrieve("account", _accountId, new ColumnSet(true));
                    
		    //Updated the ownerid attribute to the user who want to own the record
                    accountRecord["ownerid"] = new EntityReference(SystemUser.EntityLogicalName, _otherUserId);

                    // Execute the Request
                   _service.Update(accountRecord);

                    Console.WriteLine("The account is owned by new owner.");

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
        /// Retrieves the user details.
        /// Create an account record.
        /// </summary>
        public void CreateRequiredRecords()
        {
            WhoAmIRequest userRequest = new WhoAmIRequest();
            WhoAmIResponse user = (WhoAmIResponse)_service.Execute(userRequest);

            // Current user.
            _myUserId = user.UserId;

            // Query to retrieve other users.
            QueryExpression querySystemUser = new QueryExpression
            {
                EntityName = SystemUser.EntityLogicalName,
                ColumnSet = new ColumnSet(new String[] { "systemuserid", "fullname" }),
                Criteria = new FilterExpression()
            };

            querySystemUser.Criteria.AddCondition("businessunitid", 
                ConditionOperator.Equal, user.BusinessUnitId);
            querySystemUser.Criteria.AddCondition("systemuserid", 
                ConditionOperator.NotEqual, _myUserId);
            // Excluding SYSTEM user.
            querySystemUser.Criteria.AddCondition("lastname", 
                ConditionOperator.NotEqual, "SYSTEM");
            // Excluding INTEGRATION user.
            querySystemUser.Criteria.AddCondition("lastname", 
                ConditionOperator.NotEqual, "INTEGRATION");

            DataCollection<Entity> otherUsers = _service.RetrieveMultiple(
                querySystemUser).Entities;

            int count = _service.RetrieveMultiple(querySystemUser).Entities.Count;
            if ( count > 0)
            {
                _otherUserId = (Guid)otherUsers[count-1].Attributes["systemuserid"];

                Console.WriteLine("Retrieved new owner {0} for assignment.",
                    otherUsers[count - 1].Attributes["fullname"]);
            }
            else
            {
                throw new FaultException(
                    "No other user found in the current business unit for assignment.");
            }

            // Create an Account record 
            Account newAccount = new Account
            {
                Name = "Example Account"
            };

            _accountId = _service.Create(newAccount);
            Console.WriteLine("Created {0}", newAccount.Name);

            return;
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
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _service.Delete(Account.EntityLogicalName, _accountId);
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

                Assign app = new Assign();
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
```
  
### See also  
 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 [Sample: Serialize and Deserialize an Entity Instance](sample-serialize-deserialize-entity-instance.md)     
 [Entity ownership](../introduction-entities.md#entity-ownership)   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 [Sample: CrmServiceHelper Class](helper-code-serverconnection-class.md)
