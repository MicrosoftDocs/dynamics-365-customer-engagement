//<snippetCreateUpdateEntityMetadata>

using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Diagnostics;
using System.Xml.Linq;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    public class CreateUpdateEntityMetadata
    {
        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        private const String _customEntityName = "new_bankaccount";

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create a custom entity.
        /// Update the custom entity.
        /// Optionally delete the custom entity.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();


                    // Create the custom entity.
                    CreateEntityRequest createrequest = new CreateEntityRequest
                    {

                        //Define the entity
                        Entity = new EntityMetadata
                        {
                            SchemaName = _customEntityName,
                            DisplayName = new Label("Bank Account", 1033),
                            DisplayCollectionName = new Label("Bank Accounts", 1033),
                            Description = new Label("An entity to store information about customer bank accounts", 1033),
                            OwnershipType = OwnershipTypes.UserOwned,
                            IsActivity = false,

                        },

                        // Define the primary attribute for the entity
                        PrimaryAttribute = new StringAttributeMetadata
                        {
                            SchemaName = "new_accountname",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            MaxLength = 100,
                            FormatName = StringFormatName.Text,
                            DisplayName = new Label("Account Name", 1033),
                            Description = new Label("The primary attribute for the Bank Account entity.", 1033)
                        }

                    };
                    _serviceProxy.Execute(createrequest);
                    Console.WriteLine("The Bank Account custom entity has been created.");


                    // Add some attributes to the Bank Account entity
                    CreateAttributeRequest createBankNameAttributeRequest = new CreateAttributeRequest
                    {
                        EntityName = _customEntityName,
                        Attribute = new StringAttributeMetadata
                        {
                            SchemaName = "new_bankname",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            MaxLength = 100,
                            FormatName = StringFormatName.Text,
                            DisplayName = new Label("Bank Name", 1033),
                            Description = new Label("The name of the bank.", 1033)
                        }
                    };

                    _serviceProxy.Execute(createBankNameAttributeRequest);
                    Console.WriteLine("\nA Bank Name attribute has been added to the Bank Account entity.");

                    CreateAttributeRequest createBalanceAttributeRequest = new CreateAttributeRequest
                    {
                        EntityName = _customEntityName,
                        Attribute = new MoneyAttributeMetadata
                        {
                            SchemaName = "new_balance",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            PrecisionSource = 2,
                            DisplayName = new Label("Balance", 1033),
                            Description = new Label("Account Balance at the last known date", 1033),

                        }
                    };

                    _serviceProxy.Execute(createBalanceAttributeRequest);
                    Console.WriteLine("A Balance attribute has been added to the Bank Account entity.");

                    CreateAttributeRequest createCheckedDateRequest = new CreateAttributeRequest
                    {
                        EntityName = _customEntityName,
                        Attribute = new DateTimeAttributeMetadata
                        {
                            SchemaName = "new_checkeddate",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            Format = DateTimeFormat.DateOnly,
                            DisplayName = new Label("Date", 1033),
                            Description = new Label("The date the account balance was last confirmed", 1033)

                        }
                    };

                    _serviceProxy.Execute(createCheckedDateRequest);
                    Console.WriteLine("A date attribute has been added to the Bank Account entity.");


                    //Create a customer lookup attribute to link the bank account with an account or a contact record.
                    CreateCustomerRelationshipsRequest createCustomerReq = new CreateCustomerRelationshipsRequest
                    {
                        Lookup = new LookupAttributeMetadata
                        {
                            Description = new Label("The owner of the bank account", 1033),
                            DisplayName = new Label("Account owner", 1033),
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.ApplicationRequired),
                            SchemaName = "new_customerid"
                        },
                        OneToManyRelationships = new OneToManyRelationshipMetadata[]
                        {
                            new OneToManyRelationshipMetadata()
                            {
                                ReferencedEntity = "account",
                                ReferencingEntity = _customEntityName,
                                SchemaName = "new_bankaccount_customer_account",
                            },
                            new OneToManyRelationshipMetadata()
                            {
                                ReferencedEntity = "contact",
                                ReferencingEntity = _customEntityName,
                                SchemaName = "new_bankaccount_customer_contact",
                            }
                        },
                    };
                    _serviceProxy.Execute(createCustomerReq);
                    Console.WriteLine("A customer lookup attribute has been added to the Bank Account entity \nto link it with the Account or Contact entity.");


                    //Create a lookup attribute to link the bank account with a contact record.
                    CreateOneToManyRequest req = new CreateOneToManyRequest()
                    {
                        Lookup = new LookupAttributeMetadata()
                        {
                            Description = new Label("The referral (lead) from the bank account owner", 1033),
                            DisplayName = new Label("Referral", 1033),
                            LogicalName = "new_parent_leadid",
                            SchemaName = "New_Parent_leadId",
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.Recommended)
                        },
                        OneToManyRelationship = new OneToManyRelationshipMetadata()
                        {
                            AssociatedMenuConfiguration = new AssociatedMenuConfiguration()
                            {
                                Behavior = AssociatedMenuBehavior.UseCollectionName,
                                Group = AssociatedMenuGroup.Details,
                                Label = new Label("Bank Accounts", 1033),
                                Order = 10000
                            },
                            CascadeConfiguration = new CascadeConfiguration()
                            {
                                Assign = CascadeType.Cascade,
                                Delete = CascadeType.Cascade,
                                Merge = CascadeType.Cascade,
                                Reparent = CascadeType.Cascade,
                                Share = CascadeType.Cascade,
                                Unshare = CascadeType.Cascade
                            },
                            ReferencedEntity = "lead",
                            ReferencedAttribute = "leadid",
                            ReferencingEntity = _customEntityName,
                            SchemaName = "new_lead_new_bankaccount"
                        }
                    };
                    _serviceProxy.Execute(req);
                    Console.WriteLine("A lookup attribute has been added to the Bank Account entity \nto link it with the Lead entity.");

                    //Create an Image attribute for the custom entity
                    // Only one Image attribute can be added to an entity that doesn't already have one.
                    CreateAttributeRequest createEntityImageRequest = new CreateAttributeRequest
                    {
                        EntityName = _customEntityName,
                        Attribute = new ImageAttributeMetadata
                        {
                            SchemaName = "EntityImage", //The name is always EntityImage
                            RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                            DisplayName = new Label("Image", 1033),
                            Description = new Label("An image to represent the bank account.", 1033)

                        }
                    };

                    _serviceProxy.Execute(createEntityImageRequest);
                    Console.WriteLine("An image attribute has been added to the Bank Account entity.");


                    RetrieveEntityRequest retrieveBankAccountEntityRequest = new RetrieveEntityRequest
                    {
                        EntityFilters = EntityFilters.Entity,
                        LogicalName = _customEntityName
                    };
                    RetrieveEntityResponse retrieveBankAccountEntityResponse = (RetrieveEntityResponse)_serviceProxy.Execute(retrieveBankAccountEntityRequest);
                    EntityMetadata BankAccountEntity = retrieveBankAccountEntityResponse.EntityMetadata;

                    // Disable Mail merge
                    BankAccountEntity.IsMailMergeEnabled = new BooleanManagedProperty(false);
                    // Enable Notes
                    UpdateEntityRequest updateBankAccountRequest = new UpdateEntityRequest
                    {
                        Entity = BankAccountEntity,
                        HasNotes = true
                    };



                    _serviceProxy.Execute(updateBankAccountRequest);

                    Console.WriteLine("\nThe Bank Account entity has been updated");


                    //Update the entity form so the new fields are visible
                    UpdateEntityForm(_customEntityName);

                    // Customizations must be published after an entity is updated.
                    PublishAllXmlRequest publishRequest = new PublishAllXmlRequest();
                    _serviceProxy.Execute(publishRequest);
                    Console.WriteLine("\nCustomizations were published.");

                    //Provides option to view the entity in the default solution
                    ShowEntityInBrowser(promptForDelete, BankAccountEntity);
                    //Provides option to view the entity form with the fields added
                    ShowEntityFormInBrowser(promptForDelete, BankAccountEntity);

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
        /// Deletes the custom entity that was created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteEntity = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want the Bank Account custom entity deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteEntity = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteEntity)
            {
                DeleteEntityRequest request = new DeleteEntityRequest()
                {
                    LogicalName = _customEntityName,
                };
                _serviceProxy.Execute(request);
                Console.WriteLine("The custom entity has been deleted.");
            }
        }

        public void ShowEntityInBrowser(bool prompt, EntityMetadata BankAccountEntity)
        {

            if (prompt)
            {

                Console.WriteLine("\nDo you want to view the Bank Account custom entity in the default solution? (y/n)");
                String answer = Console.ReadLine();
                if (answer.StartsWith("y") || answer.StartsWith("Y"))
                {

                    try
                    {
                        String webServiceURL = _serviceProxy.EndpointSwitch.PrimaryEndpoint.AbsoluteUri;
                        String entityInDefaultSolutionUrl = webServiceURL.Replace("XRMServices/2011/Organization.svc",
                         String.Format("tools/solution/edit.aspx?def_category=9801&def_type={0}&id=%7bFD140AAF-4DF4-11DD-BD17-0019B9312238%7d", BankAccountEntity.ObjectTypeCode));

                        ProcessStartInfo browserProcess = new ProcessStartInfo("iexplore.exe");
                        browserProcess.Arguments = entityInDefaultSolutionUrl;
                        Process.Start(browserProcess);

                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("\nThere was a problem opening Internet Explorer.");
                    }

                }

            }


        }

        public void ShowEntityFormInBrowser(bool prompt, EntityMetadata BankAccountEntity)
        {
            if (prompt)
            {
                Console.WriteLine("\nDo you want to view the form for this entity? (y/n)");
                String viewFormAnswer = Console.ReadLine();
                if (viewFormAnswer.StartsWith("y") || viewFormAnswer.StartsWith("Y"))
                {
                    try
                    {
                        String webServiceURL = _serviceProxy.EndpointSwitch.PrimaryEndpoint.AbsoluteUri;
                        String entityInDefaultSolutionUrl = webServiceURL.Replace("XRMServices/2011/Organization.svc",
                         String.Format("main.aspx?etn={0}&pagetype=entityrecord", BankAccountEntity.LogicalName));

                        ProcessStartInfo browserProcess = new ProcessStartInfo("iexplore.exe");
                        browserProcess.Arguments = entityInDefaultSolutionUrl;
                        Process.Start(browserProcess);

                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("\nThere was a problem opening Internet Explorer.");
                    }
                }
            }
        }
        /// <summary>
        /// Updates the formXml to add a new tab containing the fields added by this sample.
        /// <param name="entityLogicalName">The logical name of the new_bankaccount entity used in this sample</param>
        /// </summary>
        public void UpdateEntityForm(String entityLogicalName)
        {

            QueryExpression qe = new QueryExpression("systemform");
            qe.Criteria.AddCondition("type", ConditionOperator.Equal, 2); //main form
            qe.Criteria.AddCondition("objecttypecode", ConditionOperator.Equal, entityLogicalName); //for new_bankaccount entity
            qe.ColumnSet.AddColumn("formxml");
            //Retrieve the first main entity form for this entity
            SystemForm bankAccountMainForm = (SystemForm)_serviceProxy.RetrieveMultiple(qe).Entities[0];

            XDocument bankAccountFormXml = XDocument.Parse(bankAccountMainForm.FormXml);
            //Set the showImage attribute so the entity image will be displayed
            bankAccountFormXml.Root.SetAttributeValue("showImage", true);

            // Definition of a custom tab containing the custom attributes created in this sample
            String formTabXmlString = @"<tab name=""custom_attributes""
       id=""{824792c4-ea85-1504-40e2-b780b26dc6ab}""
       IsUserDefined=""0""
       locklevel=""0""
       showlabel=""true""
       expanded=""true"">
   <labels>
    <label description=""Custom Attributes""
           languagecode=""1033"" />
   </labels>
   <columns>
    <column width=""100%"">
     <sections>
      <section name=""custom_section""
               showlabel=""false""
               showbar=""false""
               locklevel=""0""
               id=""{9bda81ec-e41b-7a4d-08b4-4536c5862ce1}""
               IsUserDefined=""0""
               layout=""varwidth""
               columns=""1""
               labelwidth=""115""
               celllabelalignment=""Left""
               celllabelposition=""Left"">
       <labels>
        <label description=""Section""
               languagecode=""1033"" />
       </labels>
       <rows>
        <row>
         <cell id=""{99FF4728-D8D7-47D3-B046-7BEFCBFB4319}""
               showlabel=""true""
               locklevel=""0"">
          <labels>
           <label description=""Account Owner""
                  languagecode=""1033"" />
          </labels>
          <control id=""new_customerid""
                   classid=""{270BD3DB-D9AF-4782-9025-509E298DEC0A}""
                   datafieldname=""new_customerid""
                   disabled=""false"" />
          </cell>
        </row>        
        <row>
         <cell id=""{6e5975d3-64b5-14eb-00e4-064e3dd298b9}""
               showlabel=""true""
               locklevel=""0"">
          <labels>
           <label description=""Bank Name""
                  languagecode=""1033"" />
          </labels>
          <control id=""new_bankname""
                   classid=""{4273EDBD-AC1D-40d3-9FB2-095C621B552D}""
                   datafieldname=""new_bankname""
                   disabled=""false"" />
         </cell>
        </row>
        <row>
         <cell id=""{3b436dba-6156-42e9-697b-e275d373505b}""
               showlabel=""true""
               locklevel=""0"">
          <labels>
           <label description=""Balance""
                  languagecode=""1033"" />
          </labels>
          <control id=""new_balance""
                   classid=""{533B9E00-756B-4312-95A0-DC888637AC78}""
                   datafieldname=""new_balance""
                   disabled=""false"" />
         </cell>
        </row>
        <row>
         <cell id=""{0e9a3d8a-bd69-71ad-4ca4-2dcd10858719}""
               showlabel=""true""
               locklevel=""0"">
          <labels>
           <label description=""Date""
                  languagecode=""1033"" />
          </labels>
          <control id=""new_checkeddate""
                   classid=""{5B773807-9FB2-42db-97C3-7A91EFF8ADFF}""
                   datafieldname=""new_checkeddate""
                   disabled=""false"" />
         </cell>
        </row>
        <row>
         <cell id=""{04b95931-78c7-6913-a005-922d20e521b7}""
               showlabel=""true""
               locklevel=""0"">
          <labels>
           <label description=""Referral""
                  languagecode=""1033"" />
          </labels>
          <control id=""new_parent_leadid""
                   classid=""{270BD3DB-D9AF-4782-9025-509E298DEC0A}""
                   datafieldname=""new_parent_leadid""
                   disabled=""false"" />
         </cell>
        </row>
       </rows>
      </section>
     </sections>
    </column>
   </columns>
  </tab>";

            XDocument formTabXml = XDocument.Parse(formTabXmlString);

            //Adding this tab to the tabs element
            bankAccountFormXml.Root.Element("tabs").Add(formTabXml.Root);
            //Updateing the entity form definition
            bankAccountMainForm.FormXml = bankAccountFormXml.ToString();
            //saving the bank account form
            _serviceProxy.Update(bankAccountMainForm);

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

                CreateUpdateEntityMetadata app = new CreateUpdateEntityMetadata();
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

//</snippetCreateUpdateEntityMetadata>