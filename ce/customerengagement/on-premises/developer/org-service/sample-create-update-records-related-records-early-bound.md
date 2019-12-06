---
title: "Sample: Create and update records with related records (early bound) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to create and update a record and related records in one call by using the IOrganizationService.Entity) and IOrganizationService. Entity) methods"
keywords: 
ms.date: 12/15/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 72eeafd8-8dd5-40af-9e3d-575534d60f61
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: "pehecke"
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - sample for creating and updating records with related records (early bound)
  - early-bound class samples, creating and updating records with related records (early bound) sample
  - creating and updating records with related records (early bound) sample, early-bound class samples
  - samples for early-bound classes, creating and updating records with related records (early bound) sample
caps.latest.revision: 21
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Create and update records with related records (early bound)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the Sample: [Work with early bound entity classes in code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/EarlyBound).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create and update a record and related records in one call by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> and<xref:Microsoft.Xrm.Sdk.IOrganizationService>. <xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> methods.  
  
## Example  
```csharp
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;


namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// Shows how to create and use compound Create and Update statements.
    /// If you want to run this sample repeatedly, you have the option to 
    /// delete all the records created at the end of execution.
    /// </summary>
    public class CompoundCreateUpdate
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;
        private IOrganizationService _service;

        // Define the IDs needed for this sample.
        public Guid _accountId;
        public Guid[] _letterIds;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Creates an account and some associated letters with a nested operation.
        /// Updates those records with a nested operation.
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

                    //Define the account for which we will add letters                
                    Account accountToCreate = new Account
                    {
                        Name = "Example Account"
                    };

                    //Define the IDs of the related letters we will create
                    _letterIds = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

                    //This acts as a container for each letter we create. Note that we haven't
                    //define the relationship between the letter and account yet.
                    EntityCollection relatedLettersToCreate = new EntityCollection
                    {
                        EntityName = Letter.EntityLogicalName,
                        Entities =
                        {
                            new Letter{Subject = "Letter 1", ActivityId = _letterIds[0]},
                            new Letter{Subject = "Letter 2", ActivityId = _letterIds[1]},
                            new Letter{Subject = "Letter 3", ActivityId = _letterIds[2]}
                        }
                    };

                    //Creates the reference between which relationship between Letter and
                    //Account we would like to use.
                    Relationship letterRelationship = new Relationship("Account_Letters");

                    //Adds the letters to the account under the specified relationship
                    accountToCreate.RelatedEntities.Add(letterRelationship, relatedLettersToCreate);

                    //Passes the Account (which contains the letters)
                    _accountId = _service.Create(accountToCreate);

                    Console.WriteLine("An account and {0} letters were created.", _letterIds.Length);


                    //Now we run through many of the same steps as the above "Create" example
                    Account accountToUpdate = new Account
                    {
                        Name = "Example Account - Updated",
                        AccountId = _accountId
                    };

                    EntityCollection relatedLettersToUpdate = new EntityCollection
                    {
                        EntityName = Letter.EntityLogicalName,
                        Entities =
                        {
                            new Letter{Subject = "Letter 1 - Updated", ActivityId = _letterIds[0]},
                            new Letter{Subject = "Letter 2 - Updated", ActivityId = _letterIds[1]},
                            new Letter{Subject = "Letter 3 - Updated", ActivityId = _letterIds[2]}
                        }
                    };

                    accountToUpdate.RelatedEntities.Add(letterRelationship, relatedLettersToUpdate);

                    //This will update the account as well as all of the related letters
                    _service.Update(accountToUpdate);
                    Console.WriteLine("An account and {0} letters were updated.", _letterIds.Length);


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
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                foreach (Guid letterId in _letterIds)
                {
                    _service.Delete(Letter.EntityLogicalName, letterId);
                }
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

                CompoundCreateUpdate app = new CompoundCreateUpdate();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
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
 [Sample: Assign a Record to a New Owner](sample-assign-record-new-owner.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
