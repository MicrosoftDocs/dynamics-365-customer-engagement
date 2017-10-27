// <snippetkbsearch>


using System;
using System.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to use ConditionOperation.FreeText.
    /// </summary>
    /// <param name="serverConfig">Contains server connection information.</param>
    /// <param name="promptforDelete">When True, the user will be prompted to delete all
    /// created entities.</param>
    public class KBSearch
    {
        #region Class Level Members

        private Guid _article1Id;
        private Guid _article2Id;
        private Guid _article3Id;
        private Guid _articleTemplate = new Guid("C3F93721-91B6-475A-ACD0-0A68AA1CB842");
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first creates three KB Articles records,
        /// submits them and approves them. The search using the FreeText operator
        /// is then executed. 
        /// Finally, if prompted, it will unapprove and delete them.
        /// Note: With the FreeText operator, you can find the articles containing the search words 
        /// and inflectional words. For example, if your search word is "rain", you will find the articles that 
        /// contain the search word "rain", but, also, the articles that contain the inflectional words, 
        /// such "raining" or "rained".
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>

        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();
                    
                    // Create the query using FreeText operator
                    QueryExpression userQuery = new QueryExpression
                    {
                        EntityName = KbArticle.EntityLogicalName,
                        ColumnSet = new ColumnSet("title"),
                        Criteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression
                                    ("title", ConditionOperator.FreeText, "Rain or Thunder")
                            }
                        }                        
                    };

                    // Run the query as a query expression.
                    EntityCollection entitiesFound =
                        _serviceProxy.RetrieveMultiple(userQuery);

                    // Show the results
                    Console.WriteLine("Searching KB article with Title 'Rain' or 'Thunder'.");
                    Console.WriteLine("-------------------------------------------------");
                    if (entitiesFound.Entities.Count > 0)
                    {
                        foreach (Entity entityFound in entitiesFound.Entities)
                        {
                            Console.WriteLine("  Title: " + ((KbArticle)entityFound).Title +
                                ", Id: " + ((KbArticle)entityFound).Id.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("There were no KB articles with that criteria.");
                    }

                    Console.WriteLine();

                    DeleteRequiredRecords(promptforDelete);
                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        #region Public methods

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            #region Create KB records

            // Use a built-in CRM KB Article Template (required field)
            // Template Standard KB Article: C3F93721-91B6-475A-ACD0-0A68AA1CB842
            
            // Get the Guid for the Default Subject (required field)
            var query = new QueryExpression("subject")
            {
                ColumnSet = new ColumnSet("title"),
                EntityName = Subject.EntityLogicalName
            };

            Entity defaultSubject = _serviceProxy.RetrieveMultiple(query).Entities.Where
                (x => String.Equals((string)x["title"], "Default Subject", 
                StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

            if (defaultSubject == null)
            {
                Console.WriteLine
                    ("There is no a Default Subject record. Cannot create KB article.");
                return;
            }
            
            // Create kbarticle1
            KbArticle article1 = new KbArticle();
            article1.SubjectId = new EntityReference
                (Subject.EntityLogicalName, defaultSubject.Id);
            article1.Title = "Raining";
            // ArticleXml field is required to be able to Publish an article
            article1.ArticleXml =
                @"<articledata>
                    <section id='0'>
                        <content>
                            <![CDATA[This is the Summary for Test1]]>
                        </content>
                    </section>
                    <section id='1'>
                        <content>
                            <![CDATA[This is the Additional Comments for Test1]]>
                        </content>
                    </section>
                </articledata>";
            article1.KbArticleTemplateId = new EntityReference
                (KbArticleTemplate.EntityLogicalName, _articleTemplate);
            _article1Id = _serviceProxy.Create(article1);
            Console.WriteLine("KB article 1 has been Created. Title: " + article1.Title +
                ". Id: " + _article1Id);

            // Create kbarticle2
            KbArticle article2 = new KbArticle();
            article2.SubjectId = new EntityReference
                (Subject.EntityLogicalName, defaultSubject.Id);
            article2.Title = "Snowing";
            article2.ArticleXml =
                @"<articledata>
                    <section id='0'>
                        <content>
                            <![CDATA[This is the Summary for Test2]]>
                        </content>
                    </section>
                    <section id='1'>
                        <content>
                            <![CDATA[This is the Additional Comments for Test2]]>
                        </content>
                    </section>
                </articledata>";
            article2.KbArticleTemplateId = new EntityReference
                (KbArticleTemplate.EntityLogicalName, _articleTemplate);
            _article2Id = _serviceProxy.Create(article2);
            Console.WriteLine("KB article 2 has been Created. Title: " + article2.Title +
                ". Id: " + _article2Id);

            // Create kbarticle3
            KbArticle article3 = new KbArticle();
            article3.SubjectId = new EntityReference
                (Subject.EntityLogicalName, defaultSubject.Id);
            article3.Title = "Thundering";
            // ArticleXml field is required to be able to Publish an article
            article3.ArticleXml =
                @"<articledata>
                    <section id='0'>
                        <content>
                            <![CDATA[This is the Summary for Test3]]>
                        </content>
                    </section>
                    <section id='1'>
                        <content>
                            <![CDATA[This is the Additional Comments for Test3]]>
                        </content>
                    </section>
                </articledata>";
            article3.KbArticleTemplateId = new EntityReference
                (KbArticleTemplate.EntityLogicalName, _articleTemplate);
            _article3Id = _serviceProxy.Create(article3);
            Console.WriteLine("KB article 3 has been Created. Title: " + article3.Title +
                ". Id: " + _article3Id);

            Console.WriteLine();
            #endregion

            #region Submit KB records

            // Change state from Draft to Unapproved (Submit) 
            // to be able to Publish
            _serviceProxy.Execute(new SetStateRequest
            {
                EntityMoniker = new EntityReference
                    (KbArticle.EntityLogicalName, _article1Id),
                State = new OptionSetValue((int)KbArticleState.Unapproved),
                Status = new OptionSetValue((int)kbarticle_statuscode.Unapproved)
            });
            Console.WriteLine("KB Article 1 has been Submitted.");

            _serviceProxy.Execute(new SetStateRequest
            {
                EntityMoniker = new EntityReference
                    (KbArticle.EntityLogicalName, _article2Id),
                State = new OptionSetValue((int)KbArticleState.Unapproved),
                Status = new OptionSetValue((int)kbarticle_statuscode.Unapproved)
            });
            Console.WriteLine("KB Article 2 has been Submitted.");

            _serviceProxy.Execute(new SetStateRequest
            {
                EntityMoniker = new EntityReference
                    (KbArticle.EntityLogicalName, _article3Id),
                State = new OptionSetValue((int)KbArticleState.Unapproved),
                Status = new OptionSetValue((int)kbarticle_statuscode.Unapproved)
            });
            Console.WriteLine("KB Article 3 has been Submitted.");
            Console.WriteLine();

            #endregion

            #region Publish KB records
            
            // Publish KB Article records
            _serviceProxy.Execute(new SetStateRequest
            {
                EntityMoniker = new EntityReference
                    (KbArticle.EntityLogicalName, _article1Id),
                State = new OptionSetValue((int)KbArticleState.Published),
                Status = new OptionSetValue((int)kbarticle_statuscode.Published)
            });
            Console.WriteLine("KB Article 1 has been Published.");

            _serviceProxy.Execute(new SetStateRequest
            {
                EntityMoniker = new EntityReference
                    (KbArticle.EntityLogicalName, _article2Id),
                State = new OptionSetValue((int)KbArticleState.Published),
                Status = new OptionSetValue((int)kbarticle_statuscode.Published)
            });
            Console.WriteLine("KB Article 2 has been Published.");

            _serviceProxy.Execute(new SetStateRequest
            {
                EntityMoniker = new EntityReference
                    (KbArticle.EntityLogicalName, _article3Id),
                State = new OptionSetValue((int)KbArticleState.Published),
                Status = new OptionSetValue((int)kbarticle_statuscode.Published)
            });
            Console.WriteLine("KB Article 3 has been Published.");
            Console.WriteLine();

            #endregion

            #region Ensure availability of the data

            // Wait 10 seconds to ensure that data will be available
            // Full-text indexing
            Console.WriteLine("Waiting 10 seconds to ensure indexing has completed on the new records.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(10000);

            #endregion
            
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool toBeDeleted = true;

            if (prompt)
            {
                // Ask the user if the created entities should be deleted.
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                if (answer.StartsWith("y") ||
                    answer.StartsWith("Y") ||
                    answer == String.Empty)
                {
                    toBeDeleted = true;
                }
                else
                {
                    toBeDeleted = false;
                }
            }

            if (toBeDeleted)
            {
                // Delete the KB articles.
                // First, we need to unpublish them
                _serviceProxy.Execute(new SetStateRequest
                {
                    EntityMoniker = new EntityReference
                        (KbArticle.EntityLogicalName, _article1Id),
                    State = new OptionSetValue((int)KbArticleState.Unapproved),
                    Status = new OptionSetValue((int)kbarticle_statuscode.Unapproved)
                });
                Console.WriteLine("KB Article 1 has been Unpublished.");

                _serviceProxy.Execute(new SetStateRequest
                {
                    EntityMoniker = new EntityReference
                        (KbArticle.EntityLogicalName, _article2Id),
                    State = new OptionSetValue((int)KbArticleState.Unapproved),
                    Status = new OptionSetValue((int)kbarticle_statuscode.Unapproved)
                });
                Console.WriteLine("KB Article 2 has been Unpublished.");

                _serviceProxy.Execute(new SetStateRequest
                {
                    EntityMoniker = new EntityReference
                        (KbArticle.EntityLogicalName, _article3Id),
                    State = new OptionSetValue((int)KbArticleState.Unapproved),
                    Status = new OptionSetValue((int)kbarticle_statuscode.Unapproved)
                });
                Console.WriteLine("KB Article 3 has been Unpublished.");
                Console.WriteLine();

                // Now, we can delete them
                _serviceProxy.Delete(KbArticle.EntityLogicalName, _article1Id);
                Console.WriteLine("KB Article 1 has been Deleted.");
                _serviceProxy.Delete(KbArticle.EntityLogicalName, _article2Id);
                Console.WriteLine("KB Article 2 has been Deleted.");
                _serviceProxy.Delete(KbArticle.EntityLogicalName, _article3Id);
                Console.WriteLine("KB Article 3 has been Deleted.");
                Console.WriteLine();
            }
        }
        #endregion Public Methods

        #endregion How To Sample Code

        #region Main method

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

                KBSearch app = new KBSearch();
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

        #endregion Main method
    }
}

// </snippetkbsearch>