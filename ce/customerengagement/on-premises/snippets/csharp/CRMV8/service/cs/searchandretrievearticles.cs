// <snippetsearchandretrievearticles>


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
    /// Demonstrates how to search by body, keyword and title, and retrieve articles by
    /// topic incident subject and topic incident product.
    /// </summary>
    /// <param name="serverConfig">Contains server connection information.</param>
    /// <param name="promptforDelete">When True, the user will be prompted to delete all
    /// created entities.</param>
    public class SearchAndRetrieveArticles
    {
        #region Class Level Members

        private OrganizationServiceProxy _serviceProxy;
        private ServiceContext _context;

        private KbArticle[] _articles = new KbArticle[3];
        private Guid _subjectId;        
        private Incident _incident;
        private Account _account;
        private Product _product;
        private UoM _uom;
        private UoMSchedule _uomSchedule;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first creates sample articles and publishes them, then searches
        /// for the articles by body, keyword and title. Finally, it retrieves the 
        /// articles by top incident subject and top incident product.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                // Using the ServiceContext class makes the queries easier
                using (_context = new ServiceContext(_serviceProxy))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    CreateRequiredRecords();

                    #region Search Knowledge base by Body

                    // Create the request
                    SearchByBodyKbArticleRequest searchByBodyRequest = 
                        new SearchByBodyKbArticleRequest()
                    {
                        SubjectId = _subjectId,
                        UseInflection = true, // allows for a different tense or 
                        // inflection to be substituted for the search text
                        SearchText = "contained", // will also match on 'contains'
                        QueryExpression = new QueryExpression()
                        {
                            ColumnSet = new ColumnSet("articlexml"),
                            EntityName = KbArticle.EntityLogicalName
                        }
                    };

                    // Execute the request
                    Console.WriteLine("  Searching for published article with 'contained' in the body");

                    SearchByBodyKbArticleResponse seachByBodyResponse =
                        (SearchByBodyKbArticleResponse)_context.Execute(searchByBodyRequest);

                    // Check success
                    var retrievedArticleBodies = seachByBodyResponse.EntityCollection.Entities
                        .Select((entity) => ((KbArticle)entity).ArticleXml);

                    if (retrievedArticleBodies.Count() == 0)
                        throw new Exception("No articles found");

                    Console.WriteLine("  Results of search (article bodies found):");
                    foreach (var body in retrievedArticleBodies)
                        Console.WriteLine(body);

                    #endregion

                    #region Search knowledge base by Keyword

                    // Create the request
                    SearchByKeywordsKbArticleRequest searchByKeywordRequest = 
                        new SearchByKeywordsKbArticleRequest()
                    {
                        SubjectId = _subjectId,
                        UseInflection = true,
                        SearchText = "Search",
                        QueryExpression = new QueryExpression()
                        {
                            ColumnSet = new ColumnSet("keywords"),
                            EntityName = KbArticle.EntityLogicalName
                        }
                    };

                    // Execute the request
                    Console.WriteLine();
                    Console.WriteLine("  Searching for published article with 'search' as a keyword");
                    var searchByKeywordResponse =
                        (SearchByKeywordsKbArticleResponse)_context.Execute(searchByKeywordRequest);

                    // Check success
                    var retrievedArticleKeywords = searchByKeywordResponse.EntityCollection.Entities
                        .Select((entity) => (KbArticle)entity);

                    if (retrievedArticleKeywords.Count() == 0)
                        throw new Exception("No articles found");

                    Console.WriteLine("  Results of search (keywords found):");
                    foreach (var article in retrievedArticleKeywords)
                        Console.WriteLine(article.KeyWords);

                    #endregion

                    #region Search knowledge base by Title

                    // create the request
                    SearchByTitleKbArticleRequest searchByTitleRequest = 
                        new SearchByTitleKbArticleRequest()
                    {
                        SubjectId = _subjectId,
                        UseInflection = false,
                        SearchText = "code",
                        QueryExpression = new QueryExpression()
                        {
                            ColumnSet = new ColumnSet("title"),
                            EntityName = KbArticle.EntityLogicalName
                        }
                    };

                    // execute the request
                    Console.WriteLine();
                    Console.WriteLine("  Searching for published articles with 'code' in the title");
                    var searchByTitleResponse = (SearchByTitleKbArticleResponse)
                        _context.Execute(searchByTitleRequest);

                    // check success
                    var retrievedArticles = searchByTitleResponse.EntityCollection.Entities
                        .Select((entity) => (KbArticle)entity);
                    Console.WriteLine("  Results of search (titles found):");
                    foreach (var article in retrievedArticles)
                        Console.WriteLine(article.Title);

                    #endregion

                    #region Retrieve by top incident subject

                    // create the request
                    var retrieveByTopIncidentSubjectRequest = 
                        new RetrieveByTopIncidentSubjectKbArticleRequest()
                    {
                        SubjectId = _subjectId
                    };

                    // execute request
                    Console.WriteLine();
                    Console.WriteLine("  Searching for the top articles in subject 'Default Subject'");
                    var retrieveByTopIncidentSubjectResponse = (RetrieveByTopIncidentSubjectKbArticleResponse)
                        _context.Execute(retrieveByTopIncidentSubjectRequest);

                    // check success
                    var articles = retrieveByTopIncidentSubjectResponse.EntityCollection.Entities.Select(
                        (entity) => (KbArticle)entity);
                    Console.WriteLine("  Top articles in subject 'Default Subject':");
                    foreach (var article in articles)
                        Console.WriteLine(article.Title);

                    #endregion

                    #region Retrieve by top incident product

                    // create the request
                    var retrieveByTopIncidentProductRequest = 
                        new RetrieveByTopIncidentProductKbArticleRequest()
                    {
                        ProductId = _product.Id
                    };

                    // execute request
                    Console.WriteLine();
                    Console.WriteLine("  Searching for the top articles for product 'Sample Product'");
                    var retrieveByTopIncidentProductResponse = (RetrieveByTopIncidentProductKbArticleResponse)
                        _context.Execute(retrieveByTopIncidentProductRequest);

                    // check success
                    articles = retrieveByTopIncidentProductResponse.EntityCollection.Entities.Select(
                        (entity) => (KbArticle)entity);
                    Console.WriteLine("  Top articles for product 'Sample Product':");
                    foreach (var article in articles)
                        Console.WriteLine(article.Title);

                    #endregion

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
            #region create kb articles

            Console.WriteLine("  Creating KB Articles");

            _subjectId = (
                          from subject in _context.SubjectSet
                          where subject.Title == "Default Subject"
                          select subject.Id
                         ).First();

            var kbArticleTemplateId = (               
                                       from articleTemplate in _context.KbArticleTemplateSet
                                       where articleTemplate.Title == "Standard KB Article"
                                       select articleTemplate.Id
                                      ).FirstOrDefault();

            if (kbArticleTemplateId != Guid.Empty)
            {
                // create a KB article
                _articles[0] = new KbArticle()
                {
                    // set the article properties
                    Title = "Searching the knowledge base",
                    ArticleXml = @"
                <articledata>
                    <section id='0'>
                        <content><![CDATA[This is a sample article about searching the knowledge base.]]></content>
                    </section>
                    <section id='1'>
                        <content><![CDATA[Knowledge bases contain information useful for various people.]]></content>
                    </section>
                </articledata>",
                    // use the built-in "Standard KB Article" template
                    KbArticleTemplateId = new EntityReference(KbArticleTemplate.EntityLogicalName,
                        kbArticleTemplateId),
                    // use the default subject
                    SubjectId = new EntityReference(Subject.EntityLogicalName, _subjectId),
                    KeyWords = "Searching Knowledge base"
                };
                _context.AddObject(_articles[0]);

                _articles[1] = new KbArticle()
                {
                    Title = "What's in a knowledge base",
                    ArticleXml = @"
                            <articledata>
                                <section id='0'>
                                    <content><![CDATA[This is a sample article about what would be in a knowledge base.]]></content>
                                </section>
                                <section id='1'>
                                    <content><![CDATA[This section contains more information.]]></content>
                                </section>
                            </articledata>",
                    KbArticleTemplateId = new EntityReference(KbArticleTemplate.EntityLogicalName,
                       kbArticleTemplateId),
                    SubjectId = new EntityReference(Subject.EntityLogicalName, _subjectId),
                    KeyWords = "Knowledge base"
                };
                _context.AddObject(_articles[1]);

                _articles[2] = new KbArticle()
                {
                    Title = "Searching the knowledge base from code",
                    ArticleXml = @"
                            <articledata>
                                <section id='0'>
                                    <content><![CDATA[This article covers searching the knowledge base from code.]]></content>
                                </section>
                                <section id='1'>
                                    <content><![CDATA[This section contains more information.]]></content>
                                </section>
                            </articledata>",
                    KbArticleTemplateId = new EntityReference(KbArticleTemplate.EntityLogicalName,
                       kbArticleTemplateId),
                    SubjectId = new EntityReference(Subject.EntityLogicalName, _subjectId),
                    KeyWords = "Knowledge base code"
                };
                _context.AddObject(_articles[2]);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Standard Article Templates are missing");
            }
            #endregion

            #region Submit the articles

            Console.WriteLine("  Submitting the articles");

            foreach (var article in _articles)
            {
                _context.Execute(new SetStateRequest
                {
                    EntityMoniker = article.ToEntityReference(),
                    State = new OptionSetValue((int)KbArticleState.Unapproved),
                    Status = new OptionSetValue((int)kbarticle_statuscode.Unapproved)
                });
            }

            #endregion

            #region Approve and Publish the article

            Console.WriteLine("  Publishing articles");

            foreach (var article in _articles)
            {
                _context.Execute(new SetStateRequest
                {
                    EntityMoniker = article.ToEntityReference(),
                    State = new OptionSetValue((int)KbArticleState.Published),
                    Status = new OptionSetValue((int)kbarticle_statuscode.Published)
                });
            }

            #endregion

            #region Waiting for publishing to finish

            // Wait 20 seconds to ensure that data will be available
            // Full-text indexing
            Console.WriteLine("  Waiting 20 seconds to ensure indexing has completed on the new records.");
            System.Threading.Thread.Sleep(20000);
            Console.WriteLine();

            #endregion

            #region Add cases to KbArticles

            // Create UoM
            _uomSchedule = new UoMSchedule()
            {
                Name = "Sample unit group",
                BaseUoMName = "Sample base unit"
            };
            _context.AddObject(_uomSchedule);
            _context.SaveChanges();

            _uom = (from uom in _context.UoMSet
                    where uom.Name == _uomSchedule.BaseUoMName
                    select uom).First();

            Console.WriteLine("  Creating an account and incidents for the KB articles");
            var whoami = (WhoAmIResponse)_context.Execute(new WhoAmIRequest());

            _account = new Account()
            {
                Name = "Coho Winery",
            };
            _context.AddObject(_account);
            _context.SaveChanges();

            _product = new Product()
            {
                Name = "Sample Product",
                ProductNumber = "0",
                ProductStructure = new OptionSetValue(1),
                DefaultUoMScheduleId = _uomSchedule.ToEntityReference(),
                DefaultUoMId = _uom.ToEntityReference()
            };
            
            _context.AddObject(_product);
            _context.SaveChanges();

            // Publish Product
            SetStateRequest publishRequest = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Product.EntityLogicalName, _product.Id),
                State = new OptionSetValue((int)ProductState.Active),
                Status = new OptionSetValue(1)
            };
            _context.Execute(publishRequest);

            _incident = new Incident()
            {
                Title = "A sample incident",
                OwnerId = new EntityReference(SystemUser.EntityLogicalName, whoami.UserId),
                KbArticleId = _articles[0].ToEntityReference(),
                CustomerId = _account.ToEntityReference(),
                SubjectId = new EntityReference(Subject.EntityLogicalName, _subjectId),
                ProductId = _product.ToEntityReference()
            };
            _context.AddObject(_incident);
            _context.SaveChanges();

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
                #region Delete incidents, accounts and units of measure

                _serviceProxy.Delete(Incident.EntityLogicalName, _incident.Id);

                _serviceProxy.Delete(Product.EntityLogicalName, _product.Id);

                _serviceProxy.Delete(Account.EntityLogicalName, _account.Id);

                _serviceProxy.Delete(UoMSchedule.EntityLogicalName, _uomSchedule.Id);

                #endregion

                #region Unpublish articles

                foreach (var article in _articles)
                {
                    _serviceProxy.Execute(new SetStateRequest
                    {
                        EntityMoniker = article.ToEntityReference(),
                        Status = new OptionSetValue((int)kbarticle_statuscode.Unapproved),
                        State = new OptionSetValue((int)KbArticleState.Unapproved)
                    });
                }

                #endregion

                #region Delete articles

                foreach (var article in _articles)
                    _serviceProxy.Delete(KbArticle.EntityLogicalName, article.Id);
                
                #endregion

                Console.WriteLine("Entity records have been deleted.");
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

                SearchAndRetrieveArticles app = new SearchAndRetrieveArticles();
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

// </snippetsearchandretrievearticles>