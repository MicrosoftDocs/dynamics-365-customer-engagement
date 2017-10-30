---
title: "Simple Web API quick-start sample (C#) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample demonstrates how to authenticate with a Dynamics 365 Server and then call a basic Web API operation, theWhoAmI Function"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 96bd4e85-1877-4716-8036-9ddb0ac3767d
caps.latest.revision: 14
author: "JimDaly"
ms.author: "jdaly"
---
# Simple Web API quick-start sample (C#)
This sample demonstrates how to authenticate with   a [!INCLUDE[pn_microsoftcrm_server](../../includes/pn-microsoftcrm-server.md)] and then call a basic Web API operation, the <xref href="Microsoft.Dynamics.CRM.WhoAmI?text=WhoAmI Function" />. Unlike other Web API samples, this sample doesn't depend on other nonstandard helper libraries or additional source files. All of its source code is in a single file, Program.cs to help make logic flow and the authentication process easier to understand.  The sample will work with online, on-premise and internet-facing deployments (IFDs).  
  
## Requirements  
 This sample has the following requirements:  
  
-   To open and build the solution, [!INCLUDE[pn_microsoft_visual_studio_2015](../../includes/pn-microsoft-visual-studio-2015.md)] or later is required.  Free versions of this product are available for download: [Visual Studio Express](https://www.visualstudio.com/vs/visual-studio-express/) or [Visual Studio Community](https://www.visualstudio.com/vs/community/).  
  
-   An internet or network connection to connect to your online or on-premise [!INCLUDE[pn_crm_2016_server](../../includes/pn-crm-2016-server.md)], respectively.  
  
-   A user account on your [!INCLUDE[pn_crm_2016_server](../../includes/pn-crm-2016-server.md)] (online or on-premise).  
  
-   If [!INCLUDE[pn_dyn_365_online](../../includes/pn-crm-online.md)] is used, then the sample application must be registered Azure Active Directory, as described in [Walkthrough: Register a Dynamics 365 app with Azure Active Directory](../walkthrough-register-dynamics-365-app-azure-active-directory.md) .  
  
-   If [!INCLUDE[pn_crm_op_edition](../../includes/pn-crm-op-edition.md)] with Internet-facing deployment (IFD) is used, then the sample application must be registered with your Active Directory tenant, as described in  [Walkthrough: Register a Dynamics 365 app with Active Directory](../walkthrough-register-app-active-directory.md) .  
  
> [!IMPORTANT]
>  By design, initially the solution will not build successfully. The source code must be edited at the lines indicated by `//TODO` comments to supply user account and/or application registration information.  
  
## Demonstrates  
 This simple sample demonstrates two basic concepts required for development using the  Web API:   authentication against a [!INCLUDE[pn_crm_2016_server](../../includes/pn-crm-2016-server.md)] and forming basic Web API calls using the HTTP protocol.  
  
 Authentication is required before a client application can access any [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] resource. This process can be nontrivial for two reasons: different authentication mechanisms are required for the different deployment types, and web-based authentication mechanisms typically involve multiple programmatic steps. Windows integrated authentication, required for on-premise deployments, is relatively straightforward, and only requires a username and password. Thereafter, the program subsequently acts as an agent of the authenticated user.  
  
 In contrast, online and IFD deployments require the registration of client application beforehand,  and then uses a multi-step OAuth authentication process. The  registration process for [!INCLUDE[pn_dyn_365_online](../../includes/pn-crm-online.md)] is described in the  article [Walkthrough: Register a Dynamics 365 app with Azure Active Directory](../walkthrough-register-dynamics-365-app-azure-active-directory.md).   The  registration process for [!INCLUDE[pn_crm_op_edition](../../includes/pn-crm-op-edition.md)] with Internet-facing deployment (IFD) is described in the  article [Walkthrough: Register a Dynamics 365 app with Active Directory](../walkthrough-register-app-active-directory.md).  Each subsequent Web API request must be authenticated with OAuth. Luckily much of the complexity of OAuth authentication can be simplified through the use of Active Directory Authentication Libraries ([ADAL](https://docs.microsoft.com/en-us/azure/active-directory/active-directory-authentication-libraries)) for .NET clients, which is added to the sample as the NuGet package [Microsoft.IdentityModel.Clients.ActiveDirectory](https://www.nuget.org/packages/Microsoft.IdentityModel.Clients.ActiveDirectory/). OAuth authorization is further encapsulated in this sample with the inclusion of the   `OAuthMessageHandler` class, which adds the required OAuth authorization header to message requests. In future samples, supporting authentication functionality is separated into the [Web API Helper Library](https://msdn.microsoft.com/en-us/library/mt770381.aspx). For more information, see [Authenticate users in Dynamics 365](../authenticate-users.md).  
  
 The [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Web API is a REST API based on the [OData specification](http://www.odata.org/documentation/), so it supports standardized HTTP requests against entities, and calling functions and actions. This sample demonstrates invoking the <xref href="Microsoft.Dynamics.CRM.WhoAmI?text=WhoAmI Function" /> function with a GET request, then using the information provided by this function in the resulting HTTP response. Several standard libraries are leveraged by this sample to assist in this invocation:  
  
-   The .NET Framework classes from the [System.Net](https://msdn.microsoft.com/library/system.net\(v=vs.110\).aspx) and [System.Net.Http](https://msdn.microsoft.com/library/system.net.http\(v=vs.110\).aspx) namespaces are used for HTTP communication.  
  
-   Because C# lacks native support for JSON, the open source [Json.NET framework](http://www.newtonsoft.com/json/help/html/Introduction.htm) is included with its [NuGet package](https://www.nuget.org/packages/Newtonsoft.Json).  
  
-   Asynchronous programming is supported by the [System.Threading.Tasks](https://msdn.microsoft.com/library/system.threading.tasks.task\(v=vs.110\).aspx) namespace. Because of potential delays, web access typically employs asynchronous mechanisms. For more information, see [Asynchronous Programming with Async and Await](https://msdn.microsoft.com/en-us/library/hh191443\(v=vs.120\).aspx).  
  
<a name="bkmk_runSample"></a>   
## Run this sample  
 First go to [Simple Web API quick-start sample (C#)](https://code.msdn.microsoft.com/Simple-Web-API-quick-start-e0ba3d6b), download the sample archive file, Simple Web API quick-start sample (CS.zip), and extract its contents into a local folder. This folder should contain the following files:  
  
|File|Purpose/Description|  
|----------|--------------------------|  
|Program.cs|Contains the source code for this sample.|  
|SimpleWebApi.sln <br />SimpleWebApi.csproj <br />packages.config <br />AssemblyInfo.cs <br />App.config|The standard [!INCLUDE[pn_microsoft_visual_studio_2015](../../includes/pn-microsoft-visual-studio-2015.md)] solution, project, NuGet package configuration, assembly information, and  application configuration files for this sample.|  
  
 Next, use the following procedure to run this sample.  
  
1.  Locate and double-click on the solution file, SimpleWebApi.sln, to load the solution into [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)].  
  
2.  In the **Solution Explorer**, double-click on the file **Program.cs** to open it in the editor.  
  
3.  Locate the `//TODO` comments within the `Main` method, add the required connection string values and uncomment the associated lines.  
  
4.  Build the **SimpleWebApi** solution.  This should automatically download and install all the required NuGet packages that are either missing or need to be updated.  
  
5.  Run the **SimpleWebApi** project from within [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)].  All sample solutions are configured to run in debug mode by default.  
  
6.  The behavior depends on the deployment type.  
  
    -   For on-line and IFD deployments, the console application will open a new window to enter your user credentials and password.  
  
    -   For on-premise deployments, the console application will prompt you for a password for the supplied [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] account.  
  
     Supply this information and press `Enter`.  
  
<a name="bkmk_codeListing"></a>   
## Code listing  
 The most current source for this file  is found in sample download package.  
  
 `Program.cs`  
  
```csharp  
  
namespace Microsoft.Crm.Sdk.Samples  
{  
    /// <summary>  
    /// A basic Web API client application for Dynamics 365 (CRM). This sample authenticates   
    /// the user and then calls the WhoAmI Web API function.   
    /// </summary>  
    /// <remarks>   
    /// Prerequisites:   
    ///   -  To run this application, you must have a CRM Online or on-premise account.   
    ///   -  For CRM Online or Internet-facing deployments (IFD), the application must be registered    
    ///      with Azure Active Directory as described in this article:   
    ///      https://msdn.microsoft.com/en-us/library/dn531010.aspx  
    ///     
    /// The WhoAmI Web API function is documented here:   
    ///    https://msdn.microsoft.com/en-us/library/mt607925.aspx  
    /// </remarks>  
    static class SimpleWebApi  
    {  
        //TODO: Uncomment then substitute your correct Dynamics 365 organization service   
        // address for either CRM Online or on-premise (end with a forward-slash).  
        //private static string serviceUrl = "https://mydomain.crm.dynamics.com/myorg/";   // CRM Online  
        //private static string serviceUrl = "https://<organization name>.<domain name>/";   // CRM IFD  
        //private statics string serviceUrl = "http://myserver/myorg/";        // CRM on-premises  
  
        //TODO: For an on-premises deployment, set your organization credentials here. (If  
        // online or IFD, you can you can disregard or set to null.)  
        private static string userAccount = "<user-account>";  //CRM user account  
        private static string domain = "<server-domain>";  //CRM server domain  
  
        //TODO: For CRM Online or IFD deployments, substitute your app registration values    
        // here. (If on-premise, you can disregard or set to null.)  
        private static string clientId = "<app-reg-guid>";     //e.g. "e5cf0024-a66a-4f16-85ce-99ba97a24bb2"  
        private static string redirectUrl = "<redirect-URL>";  //e.g. "http://localhost/SdkSample"  
  
        static public void Main(string[] args)  
        {  
            //One message handler for OAuth authentication, and the other for Windows integrated   
            // authentication.  (Assumes that HTTPS protocol only used for CRM Online.)  
            HttpMessageHandler messageHandler;  
            if (serviceUrl.StartsWith("https://"))  
            {  
                messageHandler = new OAuthMessageHandler(serviceUrl, clientId, redirectUrl,  
                         new HttpClientHandler());  
            }  
            else  
            {  
                //Prompt for user account password required for on-premise credentials.  (Better  
                // approach is to use the SecureString class here.)  
                Console.Write("Please enter the password for account {0}: ", userAccount);  
                string password = Console.ReadLine().Trim();  
                NetworkCredential credentials = new NetworkCredential(userAccount, password, domain);  
                messageHandler = new HttpClientHandler() { Credentials = credentials };  
            }  
            try  
            {  
                //Create an HTTP client to send a request message to the CRM Web service.  
                using (HttpClient httpClient = new HttpClient(messageHandler))  
                {  
                    //Specify the Web API address of the service and the period of time each request   
                    // has to execute.  
                    httpClient.BaseAddress = new Uri(serviceUrl);  
                    httpClient.Timeout = new TimeSpan(0, 2, 0);  //2 minutes  
  
                    //Send the WhoAmI request to the Web API using a GET request.   
                    var response = httpClient.GetAsync("api/data/v8.1/WhoAmI",  
                            HttpCompletionOption.ResponseHeadersRead).Result;  
                    if (response.IsSuccessStatusCode)  
                    {  
                        //Get the response content and parse it.  
                        JObject body = JObject.Parse(response.Content.ReadAsStringAsync().Result);  
                        Guid userId = (Guid)body["UserId"];  
                        Console.WriteLine("Your system user ID is: {0}", userId);  
                    }  
                    else  
                    {  
                        Console.WriteLine("The request failed with a status of '{0}'",  
                               response.ReasonPhrase);  
                    }  
                }  
            }  
            catch (Exception ex)  
            {  
                DisplayException(ex);  
                throw;  
            }  
            finally  
            {  
                Console.WriteLine("Press <Enter> to exit the program.");  
                Console.ReadLine();  
            }  
        }  
  
        /// <summary> Displays exception information to the console. </summary>  
        /// <param name="ex">The exception to output</param>  
        private static void DisplayException(Exception ex)  
        {  
            Console.WriteLine("The application terminated with an error.");  
            Console.WriteLine(ex.Message);  
            while (ex.InnerException != null)  
            {  
                Console.WriteLine("\t* {0}", ex.InnerException.Message);  
                ex = ex.InnerException;  
            }  
        }  
    }  
  
    /// <summary>  
    ///Custom HTTP message handler that uses OAuth authentication thru ADAL.  
    /// </summary>  
    class OAuthMessageHandler : DelegatingHandler  
    {  
        private AuthenticationHeaderValue authHeader;  
  
        public OAuthMessageHandler(string serviceUrl, string clientId, string redirectUrl,  
                HttpMessageHandler innerHandler)  
            : base(innerHandler)  
        {  
            // Obtain the Azure Active Directory Authentication Library (ADAL) authentication context.  
            AuthenticationParameters ap = AuthenticationParameters.CreateFromResourceUrlAsync(  
                    new Uri(serviceUrl + "api/data/")).Result;  
            AuthenticationContext authContext = new AuthenticationContext(ap.Authority, false);  
            //Note that an Azure AD access token has finite lifetime, default expiration is 60 minutes.  
            AuthenticationResult authResult = authContext.AcquireToken(serviceUrl, clientId, new Uri(redirectUrl));  
            authHeader = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);  
        }  
  
        protected override Task<HttpResponseMessage> SendAsync(  
                 HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)  
        {  
            request.Headers.Authorization = authHeader;  
            return base.SendAsync(request, cancellationToken);  
        }  
    }  
}  
  
```  
  
### See also  
 [Web API Reference](/dynamics365/customer-engagement/web-api/about?view=dynamics-ce-odata-9  
 [Web API Samples](web-api-samples.md)   
 [Use the Dynamics 365 Web API Helper Library (C#)](use-microsoft-dynamics-365-web-api-helper-library-csharp.md)   
 [Authenticate users in Dynamics 365](authenticate-users.md)
