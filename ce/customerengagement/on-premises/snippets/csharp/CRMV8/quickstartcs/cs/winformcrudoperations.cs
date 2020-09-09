// <snippetwinformcrudoperations>


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

// These namespaces are found in the Microsoft.Xrm.Client.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This Windows Forms application sample uses the CrmConnection class found in the
    /// Microsoft.Xrm.Client namespace to connect to and authenticate with the 
    /// organization web service.
    /// 
    /// Next, the sample demonstrates how to do basic entity operations like create,
    /// retrieve, update, and delete on account entity.
    ///
    /// Prior to running this sample you must edit the app.config file to add your Microsoft
    /// CRM server and user logon information. Several examples are provided in the file.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the database
    /// records created by this program.
    /// 
    /// No helper code from CrmServiceHelpers.cs is used in this sample.</remarks>
    /// <see cref="https://msdn.microsoft.com/library/gg695810.aspx"/>
    
    public partial class WinCRUDOperations : Form
    {
        #region Class Level Members

        private Guid _accountId;
        private OrganizationService _orgService;
        private bool _strexit = true;

        #endregion Class Level Members

        /// <summary>
        /// Initialize the form controls.
        /// </summary>
        public WinCRUDOperations()
        {
            InitializeComponent();
            
            // Read the server configurations from app.config.
            GetServiceConfiguration();

            //Show the form.
            this.Show();
        }

        #region Public Methods

        /// <summary>
        /// The Run() method first connects to the organization service. Afterwards,
        /// basic create, retrieve, update, and delete entity operations are performed.
        /// </summary>
        /// <param name="connectionString">Provides service connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(String connectionString, bool promptforDelete)
        {
            try
            {
                // Establish a connection to the organization web service.
                Print("Connecting to the server ...");
                Microsoft.Xrm.Client.CrmConnection connection = CrmConnection.Parse(connectionString);

                // Obtain an organization service proxy.
                // The using statement assures that the service proxy will be properly disposed.
                using (_orgService = new OrganizationService(connection))
                {
                    Print("connected");
                    Print("Authenticating the user ...");

                    // Create any entity records this sample requires.
                    CreateRequiredRecords();

                    // Obtain information about the logged on user from the web service.
                    Guid userid = ((WhoAmIResponse)_orgService.Execute(new WhoAmIRequest())).UserId;
                    SystemUser systemUser = (SystemUser)_orgService.Retrieve("systemuser", userid,
                        new ColumnSet(new string[] { "firstname", "lastname" }));
                    Println("Logged on user is " + systemUser.FirstName + " " + systemUser.LastName + ".");

                    // Retrieve the version of Microsoft Dynamics CRM.
                    RetrieveVersionRequest versionRequest = new RetrieveVersionRequest();
                    RetrieveVersionResponse versionResponse =
                        (RetrieveVersionResponse)_orgService.Execute(versionRequest);
                    Println("Microsoft Dynamics CRM version " + versionResponse.Version + ".");

                    // Instantiate an account object. Note the use of option set enumerations defined in OptionSets.cs.
                    // Refer to the Entity Metadata topic in the SDK documentation to determine which attributes must
                    // be set for each entity.
                    Account account = new Account { Name = "Fourth Coffee" };
                    account.AccountCategoryCode = new OptionSetValue((int)AccountAccountCategoryCode.PreferredCustomer);
                    account.CustomerTypeCode = new OptionSetValue((int)AccountCustomerTypeCode.Investor);

                    // Create an account record named Fourth Coffee.
                    _accountId = _orgService.Create(account);

                    Println(account.LogicalName + " " + account.Name + " created, ");

                    // Retrieve several attributes from the new account.
                    ColumnSet cols = new ColumnSet(
                        new String[] { "name", "address1_postalcode", "lastusedincampaign" });

                    Account retrievedAccount = (Account)_orgService.Retrieve("account", _accountId, cols);
                    Print("retrieved, ");

                    // Update the postal code attribute.
                    retrievedAccount.Address1_PostalCode = "98052";

                    // The address 2 postal code was set accidentally, so set it to null.
                    retrievedAccount.Address2_PostalCode = null;

                    // Shows use of a Money value.
                    retrievedAccount.Revenue = new Money(5000000);

                    // Shows use of a Boolean value.
                    retrievedAccount.CreditOnHold = false;

                    // Update the account record.
                    _orgService.Update(retrievedAccount);
                    Print("and updated.");

                    // Delete any entity records this sample created.
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

        /// <summary>
        /// Creates any entity records this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // For this sample, all required entities are created in the Run() method.
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Println("");
                DialogResult dialogResult = MessageBox.Show("Do you want the created entity records deleted?", 
                    "Delete Records", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes || dialogResult == DialogResult.Cancel)
                {
                    deleteRecords = true;
                }
                else
                    deleteRecords = false;
            }

            if (deleteRecords)
            {
                _orgService.Delete(Account.EntityLogicalName, _accountId);
                Println("Entity records have been deleted.");
            }
        }

        /// <summary>
        /// Displays a message string in the form with newline.
        /// </summary>
        public void Println(string _sPrintlntext)
        {
            if (lblOutMsg.Text != string.Empty)
                lblOutMsg.Text = lblOutMsg.Text + "\n" + _sPrintlntext;
            else
                lblOutMsg.Text = _sPrintlntext;

            lblOutMsg.Update();
        }

        /// <summary>
        /// Displays a message string in the form.   
        /// </summary>
        public void Print(string _sPrintlntext)
        {
            lblOutMsg.Text = lblOutMsg.Text + _sPrintlntext;
            lblOutMsg.Update();
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Gets web service connection information from the app.config file.
        /// If there is more than one available, providing an option to the user to select
        /// the desired connection configuration by name.
        /// </summary>
        /// <returns>A string containing web service connection configuration information.</returns>
        private String GetServiceConfiguration()
        {
            // Get available connection strings from app.config.
            int count = ConfigurationManager.ConnectionStrings.Count;

            // Create a filter list of connection strings so that we have a list of valid
            // connection strings for Microsoft Dynamics CRM only.
            List<KeyValuePair<String, String>> filteredConnectionStrings =
                new List<KeyValuePair<String, String>>();

            for (int a = 0; a < count; a++)
            {
                if (isValidConnectionString(ConfigurationManager.ConnectionStrings[a].ConnectionString))
                    filteredConnectionStrings.Add
                        (new KeyValuePair<string, string>
                            (ConfigurationManager.ConnectionStrings[a].Name,
                            ConfigurationManager.ConnectionStrings[a].ConnectionString));
            }

            // No valid connections strings found. Write out an error message.
            if (filteredConnectionStrings.Count == 0)
            {
                Println("An app.config file containing at least one valid Microsoft Dynamics CRM " +
                    "server connection configuration must exist in the run-time folder.");
                Println("\nThere are several commented out example server connection configurations in " +
                    "the provided app.config file. Uncomment one or more of them, modify the configuration according " +
                    "to your Microsoft Dynamics CRM installation, and then re-run the sample.");

                // Disable the Connect button.
                btnConnect.Enabled = false;
                return null;
            }

            // If at least one valid connection string is found, display the list of valid connection strings.
            else
            {
                _strexit = false;           
                for (int i = 0; i < filteredConnectionStrings.Count; i++)
                {
                    cbxServerList.Items.Add(filteredConnectionStrings[i].Key);                
                    
                }                
                cbxServerList.SelectedIndex = 0;   
            }

            // Return a non-null which in this case is the first string in the list. 
            return ConfigurationManager.ConnectionStrings[0].ConnectionString;
        }


        /// <summary>
        /// Verifies if a connection string is valid for Microsoft Dynamics CRM.
        /// </summary>
        /// <returns>True for a valid string, otherwise False.</returns>
        private static Boolean isValidConnectionString(String connectionString)
        {
            // At a minimum, a connection string must contain one of these arguments.
            if (connectionString.Contains("Url=") ||
                connectionString.Contains("Server=") ||
                connectionString.Contains("ServiceUri="))
                return true;

            return false;
        }


        /// <summary>
        /// Let the user choose which connection string to use.
        /// Gets the user selected  web service connection  from the app.config file.      
        /// </summary>
        /// <returns></returns>      
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString =
                    ConfigurationManager.ConnectionStrings[cbxServerList.SelectedItem.ToString()].ConnectionString;

                lblOutMsg.Text = string.Empty;

                if ( connectionString != null) Run(connectionString, true);
            }

            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Println("The application terminated with an error.");
                Println("Timestamp: " + ex.Detail.Timestamp);
                Println("Code: " + ex.Detail.ErrorCode);
                Println("Message: " + ex.Detail.Message);
                Println("Trace: " + ex.Detail.TraceText);
                Println("Inner Fault: {0}" + (null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault"));
            }
            catch (System.TimeoutException ex)
            {
                Println("The application terminated with an error.");
                Println("Message: " + ex.Message);
                Println("Stack Trace: " + ex.StackTrace);
                Println("Inner Fault: " + (null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message));
            }
            catch (System.Exception ex)
            {
                Println("The application terminated with an error.");
                Println(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Println(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Println("Timestamp: " + fe.Detail.Timestamp);
                        Println("Code: " + fe.Detail.ErrorCode);
                        Println("Message: " + fe.Detail.Message);
                        Println("Trace: " + fe.Detail.TraceText);
                        Println("Inner Fault: " + (null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault"));
                    }
                }
            }

            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Println("Choose [Exit] to quit the application.");
            }
        }


        /// <summary>
        /// Quit the application.   
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dispose();
        }

        #endregion Private Methods             
    }
}

// </snippetwinformcrudoperations>