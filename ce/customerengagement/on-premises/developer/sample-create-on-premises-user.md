---
title: "Sample: Create an on-premises user (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: 
description: "The sample shows how to create a new system user in Active Directory and Customer Engagement."
ms.date: 1/23/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d3ea30ab-e55e-4aa7-8406-3441c71903a2
caps.latest.revision: 16
author: KumarVivek
ms.author: kvivek
manager: KumarVivek
search.audienceType: 
  - developer

---
# Sample: Create an on-premises user

This sample shows how to programmatically create a new system user in Dynamics 365 Customer Engagement and Active Directory.

## Requirements  

The sample applies to on-premises and IFD deployments only. You must have administrator permissions in Customer Engagement and the Active Directory domain to run the sample successfully.

To build the sample, you will need to add the [Helper-Code](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/WorkwithSolutions/WorkwithSolutions/Helper-Code) and [Login-UX](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/WorkwithSolutions/WorkwithSolutions/Login-UX) code to your project.

The sample does not delete the new user after the program terminates. This must be done manually in Customer Engagement and then in AD.
  
## Demonstrates  

 This sample shows how to create a user in Active Directory and then in Customer Engagement using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method. 
The new system user is created in the same domain and business unit as the logged on user executing the program.
  
## Example


```csharp
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;

namespace PowerApps.Samples
{
    public partial class SampleProgram
    {
        static String _domain = String.Empty;
        static String _userName = "dparker";
        static String _firstName = "Darren";
        static String _lastName = "Parker";

        [STAThread] // Required to support the interactive login experience
        static void Main(string[] args)
        {
            CrmServiceClient service = null;
            try
            {
                service = SampleHelpers.Connect("Connect");
                if (service.IsReady)
                {
                    // Create any entity records that the demonstration code requires
                    SetUpSample(service);

                    #region Demonstrate

                    // Retrieve the default business unit needed to create the user.
                    QueryExpression businessUnitQuery = new QueryExpression
                    {
                        EntityName = BusinessUnit.EntityLogicalName,
                        ColumnSet = new ColumnSet("businessunitid"),
                        Criteria =
                        {
                            Conditions =
                    {
                        new ConditionExpression("parentbusinessunitid",
                            ConditionOperator.Null)
                    }
                        }
                    };

                    BusinessUnit defaultBusinessUnit = service.RetrieveMultiple(
                        businessUnitQuery).Entities[0].ToEntity<BusinessUnit>();

                    //Create a new system user.
                    SystemUser user = new SystemUser
                    {
                        DomainName = _domain + _userName,
                        FirstName = _firstName,
                        LastName = _lastName,
                        BusinessUnitId = new EntityReference
                        {
                            LogicalName = BusinessUnit.EntityLogicalName,
                            Name = BusinessUnit.EntityLogicalName,
                            Id = defaultBusinessUnit.Id
                        }
                    };

                    Guid userId = service.Create(user);

                    Console.WriteLine("Created a system user {0} for '{1}, {2}'", userId, _lastName, _firstName);
                    #endregion Demonstrate
                }
                else
                {
                    const string UNABLE_TO_LOGIN_ERROR = "Unable to Login to Dataverse";
                    if (service.LastCrmError.Equals(UNABLE_TO_LOGIN_ERROR))
                    {
                        Console.WriteLine("Check the connection string values in cds/App.config.");
                        throw new Exception(service.LastCrmError);
                    }
                    else
                    {
                        throw service.LastCrmException;
                    }
                }
            }
            catch (Exception ex)
            {
                SampleHelpers.HandleException(ex);
            }

            finally
            {
                if (service != null)
                    service.Dispose();

                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }

        }
    }
}
```
  
<a name="complete_sample"></a>   
### Supporting methods  

```csharp
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.DirectoryServices;
using System.Threading;

namespace PowerApps.Samples
{
    public partial class SampleProgram
    {
        private static bool prompt = true;
        /// <summary>
        /// Function to set up the sample.
        /// </summary>
        /// <param name="service">Specifies the service to connect to.</param>
        /// 
        private static void SetUpSample(CrmServiceClient service)
        {
            // Check that the current version is greater than the minimum version
            if (!SampleHelpers.CheckVersion(service, new Version("9.0.0.0")))
            {
                //The environment version is lower than version 7.1.0.0
                return;
            }

            CreateRequiredRecords(service);
        }

        private static void CleanUpSample(CrmServiceClient service)
        {
            DeleteRequiredRecords(service, prompt);
        }

        /// <summary>
        /// This method creates any entity records that this sample requires.
        /// Creates the email activity.
        /// </summary>
        public static void CreateRequiredRecords(CrmServiceClient service)
        {
            // Obtain the current user's information.
            WhoAmIRequest who = new WhoAmIRequest();
            WhoAmIResponse whoResp = (WhoAmIResponse)service.Execute(who);
            Guid currentUserId = whoResp.UserId;

            SystemUser currentUser =
                service.Retrieve(SystemUser.EntityLogicalName,
                currentUserId,
                new ColumnSet("domainname")).ToEntity<SystemUser>();

            // Extract the domain and create the LDAP object.
            String[] userPath = currentUser.DomainName.Split(new char[] { '\\' });
            if (userPath.Length > 1)
                _domain = userPath[0] + "\\";
            else
                _domain = String.Empty;

            SystemUser existingUser = SystemUserProvider.GetUserIdIfExist(service,
                _domain, _userName, _firstName, _lastName);

            if (existingUser != null)
                throw new Exception("User already exist!");

            // Set up an Active Directory account in the current domain for this sample.
            String ldapPath = String.Empty;
            Boolean accountSetup = CreateADAccount(_userName,
                _firstName, _lastName, service, ref ldapPath);
            if (accountSetup)
                Console.WriteLine("An AD account created for '{0}, {1}'", _lastName, _firstName);
            else
                Console.WriteLine("AD account already exist for '{0}, {1}'", _lastName, _firstName);
        }


        /// <summary>
        /// Deletes the custom entity record that was created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the entity created in this sample.</param>
        /// </summary>
        public static void DeleteRequiredRecords(CrmServiceClient service, bool prompt)
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
                Console.WriteLine("You will have to manually delete the new user in Active Directory.");
            }
        }

        /// <summary>
        /// Helper method to create an active directory account
        /// </summary>
        /// <param name="userName">The username field as set in Dynamics 365 Customer Engagement</param>
        /// <param name="firstName">The first name of the system user to be retrieved</param>
        /// <param name="lastName">The last name of the system user to be retrieved</param>
        /// <param name="service">The client service object to your environment</param>
        /// <param name="ldapPath">The LDAP path for your network - you can either call
        /// ConsolePromptForLDAPPath() to prompt the user or provide a value in code</param>
        /// <returns>Return true if new account is created or return false if account already exist.</returns>
        public static Boolean CreateADAccount(String userName,
            String firstName,
            String lastName,
            CrmServiceClient service,
            ref String ldapPath)
        {
            // Check to make sure this is not Microsoft Dynamics 365 online.
            if (service.OrganizationServiceProxy.ServiceConfiguration.AuthenticationType == AuthenticationProviderType.OnlineFederation)
                throw new Exception(String.Format("To run this sample, {0} {1} must be an active system user " +
                    "\nin your Microsoft Dynamics 365 online organization.", firstName, lastName));

            if (String.IsNullOrEmpty(ldapPath))
                ldapPath = ConsolePromptForLDAPPath();

            // Create an Active Directory user account if it doesn't exist already.
            if (String.IsNullOrEmpty(ldapPath))
                throw new ArgumentException("Required argument ldapPath was not provided.");

            DirectoryEntry directoryEntry;
            if (service.OrganizationServiceProxy.ClientCredentials.Windows != null)
            {
                string LUser = service.OrganizationServiceProxy.ClientCredentials.Windows.ClientCredential.UserName;
                string LPwd = service.OrganizationServiceProxy.ClientCredentials.Windows.ClientCredential.Password;
                directoryEntry = new DirectoryEntry(ldapPath, LUser, LPwd);
            }
            else
            {
                directoryEntry = new DirectoryEntry(ldapPath);
            }

            DirectoryEntry userADAccount = null;

            // Search AD to see if the user already exists.
            DirectorySearcher search = new DirectorySearcher(directoryEntry);
            search.Filter = String.Format("(sAMAccountName={0})", userName);
            search.PropertiesToLoad.Add("samaccountname");
            search.PropertiesToLoad.Add("givenname");
            search.PropertiesToLoad.Add("sn");
            search.PropertiesToLoad.Add("cn");
            SearchResult result = search.FindOne();
            Boolean accountCreated = false;
            if (result == null)
            {
                // Create the Active Directory account. 
                userADAccount = directoryEntry.Children.Add("CN= " + userName, "user");
                userADAccount.Properties["samAccountName"].Value = userName;
                userADAccount.Properties["givenName"].Value = firstName;
                userADAccount.Properties["sn"].Value = lastName;
                userADAccount.CommitChanges();
                accountCreated = true;
            }
            else
            {
                // Use the existing AD account.
                userADAccount = result.GetDirectoryEntry();
                accountCreated = false;
            }

            // Set the password for the account.
            String password = "pass@word1";
            userADAccount.Invoke("SetPassword", new object[] { password });
            userADAccount.CommitChanges();
            directoryEntry.Close();
            userADAccount.Close();

            // Enable the newly created Active Directory account.
            userADAccount.Properties["userAccountControl"].Value =
                (int)userADAccount.Properties["userAccountControl"].Value & ~0x2;
            userADAccount.CommitChanges();

            // Wait 10 seconds for the AD account to propagate.
            Thread.Sleep(10000);
            return accountCreated;
        }

        /// <summary>
        /// Helper method to prompt the user for the LDAP path for the network
        /// </summary>
        /// <returns>The LDAP path for your network</returns>
        public static String ConsolePromptForLDAPPath()
        {
            // Prompt for the LDAP path.
            Console.WriteLine("An Active Directory connection is required. Please enter an");
            Console.WriteLine("LDAP path for your network in the format 'LDAP://server/DC=subdomain,DC=domain,DC=com': ");
            String ldapPath = Console.ReadLine();

            return ldapPath;
        }
    }
}
```
  
### See also  
 [User and Team Entities](user-team-entities.md)   
 [Sample: Disable a User](sample-disable-user.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]