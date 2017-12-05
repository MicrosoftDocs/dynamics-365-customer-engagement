---
title: "Walkthrough: Multi-tenant server-to-server authentication (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This walkthrough describes the steps to create a multi-tenant web application that can connect to a December 2016 Update for Dynamics 365 (online) tenant using the Visual Studio 2015 MVC web application template"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9d09f7e8-c1fc-45c8-9755-ac17785f0818
caps.latest.revision: 8
author: "JimDaly"
ms.author: "jdaly"
---
# Walkthrough: Multi-tenant server-to-server authentication

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This walkthrough will describe the steps to create a multi-tenant web application that can connect to a [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] tenant using the [!INCLUDE[pn_microsoft_visual_studio_2015](../includes/pn-microsoft-visual-studio-2015.md)] MVC web application template.  
  
<a name="bkmk_Requirements"></a>   
## Requirements  
  
- [!INCLUDE[pn_visual_studio_2015](../includes/pn-visual-studio-2015.md)] with web developer tools installed  
  
-   A [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] tenant associated with your [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] (Azure AD) tenant.  
  
-   A second [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] tenant associated with a different Azure AD tenant.  This tenant represents a subscriber to your application. This can be a trial [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] subscription.  
  
<a name="bkmk_goal"></a>   
## Goal of this walkthrough  
 When you complete this walkthrough you will have an MVC web application which will use the [WhoAmIRequest Class](http://msdn.microsoft.com/en-us/0daeeabf-e8ec-4df1-a320-7aadef191d4c) to retrieve data about the user the application uses to connect to the [!INCLUDE[pn_dyn_365_online](../includes/pn-crm-online.md)] Customer Engagement tenant.  
  
 When you run the app successfully you will see a **Sign in** command in the top right corner.  
  
 ![The sign in command in the app](media/mvc-s2s-walkthrough-app-sign-in.PNG "The sign in command in the app")  
  
 Click the **Sign in** command and you will be directed to Azure AD for your credentials.  
  
 After you sign in, you will see there is a **WhoAmI** command.  
  
 ![The WhoAmI command](media/mvc-s2s-walkthrough-app-whoami.png "The WhoAmI command")  
  
 Click **WhoAmI**, and you should see the following:  
  
 ![Results of a WhoAmI request](media/mvc-s2s-walkthrough-app-whoami-results.PNG "Results of a WhoAmI request")  
  
 When you query your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] tenant you will see that the results returned from the WhoAmI message refer to  a specific application user account you have configured for the web application to use rather than the user account you are currently using.  
  
<a name="bkmk_VerifyAADTenant"></a>   
## Verify Azure AD tenant  
 Before you begin, connect to your [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)][https://portal.office.com](https://portal.office.com) and in the **Admin centers** drop-down, verify that you see both [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and **Azure AD**.  
  
 ![Admin Centers with Azure Active Directory and Dynamics 365](media/admin-centers-with-aad-crm.png "Admin Centers with Azure Active Directory and Dynamics 365")  
  
 If your Azure AD subscription is not associated with a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] subscription, you will not be able to grant privileges for your application to access [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data.  
  
 If you do not see this option, see [Register your free Azure Active Directory subscription](https://support.office.com/article/Register-your-free-Azure-Active-Directory-subscription-d104fb44-1c42-4541-89a6-1f67be22e4ad) for information about how to register to get your Azure AD subscription.  
  
 If you already have an Azure subscription but it isn’t associated with your [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] account, see [Associate your Office 365 account with Azure AD](https://msdn.microsoft.com/office/office365/howto/setup-development-environment) to create and manage apps.  
  
<a name="bkmk_createMVCWebApp"></a>   
## Create an MVC web application  
 Using [!INCLUDE[pn_visual_studio_2015](../includes/pn-visual-studio-2015.md)], you can create a new MVC web application and register it with your Azure AD tenant.  
  
1.  Open [!INCLUDE[pn_visual_studio_2015](../includes/pn-visual-studio-2015.md)].  
  
2.  Make sure that the [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] you are signed in as is the same one with access to the Azure AD tenant you want to use to register your application.  
  
3.  Click **New Project** and select **.NET Framework 4.6.1** and the **ASP.NET Web Application** template.  
  
     Click **OK**, and in the New ASP.NET project dialog select **MVC**.  
  
4.  Click the **Change Authentication** button, and in the dialog select **Work And School Accounts**.  
  
5.  In the drop-down, select **Cloud – Multiple Organizations**.  
  
 ![ASP.NET  MVC Change Authentication Dialog](media/mvc-change-authentication-dialog.png "ASP.NET  MVC Change Authentication Dialog")  
  
6.  Click **OK** and complete initializing the project.  
  
    > [!NOTE]
    >  Creating a [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] project this way will register the application with your Azure AD tenant and add the following keys to the Web.Config appSettings:  
  
    ```xml  
    <add key="ida:ClientId" value="baee6b74-3c39-4c04-bfa5-4414f3dd1c26" />  
    <add key="ida:AADInstance" value="https://login.microsoftonline.com/" />  
    <add key="ida:ClientSecret" value="HyPjzuRCbIl/7VUJ2+vG/+Gia6t1+5y4dvtKAcyztL4=" />  
  
    ```  
  
<a name="bkmk_RegisterAppOnAAD"></a>   
## Register your application on Azure AD  
 If you have followed the steps in [Create an MVC web application](#bkmk_createMVCWebApp), you should find that the web application project you created in [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] is already registered in your Azure AD applications. But there is one more step that you must perform within the Azure AD portal.  
  
1.  Go to [https://portal.azure.com](https://portal.azure.com) and select **Azure Active Directory**.  
  
2.  Click **App registrations** and look for the application you created using [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)]. In the **General** area, verify the properties:  
  
 ![Application registration data in Azure Active Directory](media/app-registration-data.png "Application registration data in Azure Active Directory")  
  
3.  Verify that the **Application ID** property matches the `ClientId` value added in your Web.Config appSettings.  
  
4.  The **Home page URL** value should match SSL URL property in your [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] project and should direct to a localhost URL, i.e. https://localhost:44392/.  
  
    > [!NOTE]
    >  You will need to change this later when you actually publish your application. But you need to have this set to the correct localhost value for debugging.  
  
5.  You need to give your application privileges to access [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data. In the **API Access** area click **Required permissions**. You should see that it already has permissions for Windows [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)].  
  
6.  Click **Add**, then **Select an API**. In the list, select [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and then click the **Select** button.  
  
7.  In **Select permissions**, select **Access Dynamics 365 as organization users**. Then click the **Select** button.  
  
8.  Click **Done** to add these permissions. When you are done you should see the permissions applied:  
  
 ![Dynamics 365 permissions applied to application in Azure Active Directory](media/crm-permissions-applied-app-aad.png "Dynamics 365 permissions applied to application in Azure Active Directory")  
  
9. In the **API Access** area, confirm that a **Key** value has been added. The **Key** value is not visible in the Azure portal after the application has been created, but this value was added to your Web.Config appSettings as the `ClientSecret`.  
  
<a name="bkmk_CreateApplicationUser"></a>   
## Create an application user  
 Using steps in [Manually create a Dynamics 365 application user](use-multi-tenant-server-server-authentication.md#bkmk_ManuallyCreateUser), create an application user with the **Application Id** value from your application registration which is also the same as the `ClientId` value in the Web.Config.  
  
<a name="bkmk_AddAssemblies"></a>   
## Add Assemblies  
 Add the following [!INCLUDE[tn_nuget](../includes/tn-nuget.md)] packages to your project  
  
|Package|Version|  
|-------------|-------------|  
|Microsoft.CrmSdk.CoreAssemblies|Latest version|  
|Microsoft.IdentityModel.Clients.ActiveDirectory|2.22.302111727|  
|Microsoft.IdentityModel.Tokens|5.0.0|  
|Microsoft.Azure.ActiveDirectory.GraphClient|2.1.0|  
  
> [!NOTE]
>  Do not update the `Microsoft.IdentityModel.Clients.ActiveDirectory` assemblies to the latest version. Version 3.x of these assemblies changed an interface that the `Microsoft.CrmSdk.CoreAssemblies` depends on.  
  
 For information about managing [!INCLUDE[tn_nuget](../includes/tn-nuget.md)] packages, see [NuGet Documentation: Managing NuGet Packages Using the UI](https://docs.nuget.org/ndocs/tools/package-manager-ui)  
  
<a name="bkmk_ApplyCodeChanges"></a>   
## Apply code changes to the MVC template  
 The following code changes will provide basic functionality to use the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]`WhoAmI` message and verify that the application user account identity is being used by the application.  
  
<a name="bkmk_WebConfig"></a>   
### Web.config  
 Add the following keys to the appSettings.  
  
```xml  
<add key="ida:OrganizationHostName" value="https://{0}.crm.dynamics.com" />   
```  
  
 The ida:OrganizationHostName string will have the subscriber’s [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] online organization name added at the placeholder so that the correct service will be accessed.  
  
```xml  
<add key="owin:appStartup" value="<your app namespace>.Startup" />  
```  
  
 The owin:appStartup string ensures that the OWIN middleware uses the `Startup` class in this project. Otherwise you will get the following error:  
  
```ms-dos
- No assembly found containing an OwinStartupAttribute.  
- No assembly found containing a Startup or [AssemblyName].Startup class.  
```  
  
 More information: [ASP.NET: OWIN Startup Class Detection](https://www.asp.net/aspnet/overview/owin-and-katana/owin-startup-class-detection)  
  
<a name="bkmk_HomeController"></a>

### Controllers/HomeController.cs

 Add the `AllowAnonymous` decorator to the `Index` action. This allows access to the default page without authentication.  
  
```csharp  
using System.Web.Mvc;  
  
namespace SampleApp.Controllers  
{  
    [Authorize]  
    public class HomeController : Controller  
    {  
        [AllowAnonymous]  
        public ActionResult Index()  
        {  
            return View();  
        }  
  
        public ActionResult About()  
        {  
            ViewBag.Message = "Your application description page.";  
  
            return View();  
        }  
  
        public ActionResult Contact()  
        {  
            ViewBag.Message = "Your contact page.";  
  
            return View();  
        }  
    }  
}  
  
```  
  
> [!NOTE]
>  In your web application or service, it is not expected that you will allow anonymous access. Anonymous access is used here for simplicity. Controlling access to your application is out of scope for this walkthrough.  
  
<a name="bkmk_ViewsSharedLayout"></a>   
### Views/Shared/_Layout.cshtml  
 In order to display the command link **WhoAmI** for authenticated users, you need to edit this file.  
  
 Locate the `div` element with the class `navbar-collapse collapse` and edit it to include the code below:  
  
```html  
<div class="navbar-collapse collapse">  
    <ul class="nav navbar-nav">  
     <li>@Html.ActionLink("Home", "Index", "Home")</li>  
     <li>@Html.ActionLink("About", "About", "Home")</li>  
     <li>@Html.ActionLink("Contact", "Contact", "Home")</li>  
     @if (Request.IsAuthenticated)  
     {  
         <li>@Html.ActionLink("WhoAmI", "Index", "CrmSdk")</li>  
     }  
    </ul>  
  
    @Html.Partial("_LoginPartial")  
   </div>  
  
```  
  
<a name="bkmk_AppStartStartupAuth"></a>   
### App_Start/Startup.Auth.cs  
 The following changes will invoke the consent framework when a new tenant logs into the application:  
  
```csharp  
public partial class Startup  
 {  
  private static string clientId = ConfigurationManager.AppSettings["ida:ClientId"];  
  private string appKey = ConfigurationManager.AppSettings["ida:ClientSecret"];  
  //Not used     
  //private string graphResourceID = "https://graph.windows.net";      
  private static string aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];  
  private string authority = aadInstance + "common";  
  private ApplicationDbContext db = new ApplicationDbContext();  
  
  //Added  
  private string OrganizationHostName = ConfigurationManager.AppSettings["ida:OrganizationHostName"];  
  
  public void ConfigureAuth(IAppBuilder app)  
  {  
  
   app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);  
  
   app.UseCookieAuthentication(new CookieAuthenticationOptions { });  
  
   app.UseOpenIdConnectAuthentication(  
       new OpenIdConnectAuthenticationOptions  
       {  
        ClientId = clientId,  
        Authority = authority,  
        TokenValidationParameters = new System.IdentityModel.Tokens.TokenValidationParameters  
        {  
         /*  
         instead of using the default validation   
         (validating against a single issuer value, as we do in line of business apps),   
         we inject our own multitenant validation logic  
         */  
         ValidateIssuer = false,  
        },  
        Notifications = new OpenIdConnectAuthenticationNotifications()  
        {  
         SecurityTokenValidated = (context) =>  
                  {  
                   return Task.FromResult(0);  
                  },  
         AuthorizationCodeReceived = (context) =>  
                  {  
                   var code = context.Code;  
  
                   ClientCredential credential = new ClientCredential(clientId, appKey);  
                   string tenantID = context  
                    .AuthenticationTicket  
                    .Identity  
                    .FindFirst("http://schemas.microsoft.com/identity/claims/tenantid")  
                    .Value;  
  
                   /* Not used  
                  string signedInUserID = context  
                     .AuthenticationTicket  
                     .Identity  
                     .FindFirst(ClaimTypes.NameIdentifier)  
                     .Value;    
                     */  
  
                   //Added  
                   var resource = string.Format(OrganizationHostName, '*');  
                   //Added  
                   Uri returnUri = new Uri(  
                    HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path)  
                    );  
  
                   /* Changed below  
                    AuthenticationContext authContext =   
                    new AuthenticationContext(  
                     aadInstance + tenantID,   
                     new ADALTokenCache(signedInUserID)  
                     );  
                    */  
                   //Changed version  
                   AuthenticationContext authContext =  
                   new AuthenticationContext(aadInstance + tenantID);  
  
                   /* Changed below  
                   AuthenticationResult result = authContext.AcquireTokenByAuthorizationCode(  
                       code,   
                       new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path)),   
                       credential,   
                       graphResourceID);  
                   */  
                   //Changed version  
                   AuthenticationResult result = authContext.AcquireTokenByAuthorizationCode(  
                       code,  
                       new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path)),  
                       credential,  
                       resource);  
  
                   return Task.FromResult(0);  
                  },  
         AuthenticationFailed = (context) =>  
                  {  
                   context.OwinContext.Response.Redirect("/Home/Error");  
                   context.HandleResponse(); // Suppress the exception  
                   return Task.FromResult(0);  
                  }  
        }  
       });  
  
  }  
 }  
  
```  
  
<a name="bkmk_AddControllersCrmSdkController"></a>   
### Add Controllers/CrmSdkController  
 Add the following CrmSdkController.cs to the Controllers folder. This code will execute the `WhoAmI` message  
  
1.  Right click the Controllers folder and select **Add** > **Controller…**  
  
2.  In the **Add Scaffold** dialog, select **MVC5 Controller – Empty**  
  
3.  Click **Add**  
  
4.  Paste the following code substituting `<Your app namespace>` with the namespace of your app.  
  
```csharp  
using Microsoft.IdentityModel.Clients.ActiveDirectory;   
using Microsoft.Xrm.Sdk;   
using Microsoft.Xrm.Sdk.WebServiceClient;   
using System; using System.Configuration;   
using System.Linq;   
using System.Security.Claims;   
using System.Web.Mvc;  
  
namespace <Your app namespace>  
{  
 [Authorize]  
 public class CrmSdkController : Controller  
    {  
  
  private string clientId =   
   ConfigurationManager.AppSettings["ida:ClientId"];  
  private string authority =   
   ConfigurationManager.AppSettings["ida:AADInstance"] + "common";  
  private string aadInstance =   
   ConfigurationManager.AppSettings["ida:AADInstance"];  
  private string OrganizationHostName =   
   ConfigurationManager.AppSettings["ida:OrganizationHostName"];  
  private string appKey =   
   ConfigurationManager.AppSettings["ida:ClientSecret"];  
  
  // GET: CrmSdk  
  public ActionResult Index()  
  {  
   string tenantID = ClaimsPrincipal  
    .Current  
    .FindFirst("http://schemas.microsoft.com/identity/claims/tenantid")  
    .Value;  
   // Clean organization name from user logged  
   string organizationName = User.Identity.Name.Substring(  
    User.Identity.Name.IndexOf('@') + 1,   
    User.Identity.Name.IndexOf('.') - (User.Identity.Name.IndexOf('@') + 1)  
    );  
   //string crmResourceId = "https://[orgname].crm.microsoftonline.com";  
   var resource = string.Format(OrganizationHostName, organizationName);  
   // Request a token using application credentials  
   ClientCredential clientcred = new ClientCredential(clientId, appKey);  
   AuthenticationContext authenticationContext =   
    new AuthenticationContext(aadInstance + tenantID);  
   AuthenticationResult authenticationResult =   
    authenticationContext.AcquireToken(resource, clientcred);  
   var requestedToken = authenticationResult.AccessToken;  
   // Invoke SDK using using the requested token  
   using (var sdkService =  
    new OrganizationWebProxyClient(  
     GetServiceUrl(organizationName), false)  
     )  
   {  
    sdkService.HeaderToken = requestedToken;  
    OrganizationRequest request = new OrganizationRequest() {  
     RequestName = "WhoAmI"  
    };  
    OrganizationResponse response = sdkService.Execute(request);  
    return View((object)string.Join(",", response.Results.ToList()));  
   }  
  }  
  
  private Uri GetServiceUrl(string organizationName)  
  {  
   var organizationUrl = new Uri(  
    string.Format(OrganizationHostName, organizationName)  
    );  
   return new Uri(  
    organizationUrl +   
    @"/xrmservices/2011/organization.svc/web?SdkClientVersion=8.2"  
);  
  }  
 }  
}  
  
```  
  
<a name="bkmk_ViewsCrmSdk"></a>   
### Views/CrmSdk  
 Add a new view named Index.  
  
1.  Right click the CrmSdk folder and select **Add** > **View…**  
  
2.  In the **Add View** dialog, set the following values:  
  
 ![MVC Add View Dialog](media/mvc-add-view-dialog.PNG "MVC Add View Dialog")  
  
3.  Click **Add**  
  
4.  Replace the generated code with the following:  
  
    ```html  
    @model string  
    @{  
     ViewBag.Title = "SDK Connect";  
    }  
  
    <h2>@ViewBag.Title.</h2>  
  
    <p>Connected and executed sdk command WhoAmI.</p>  
  
    <p>Value: @Model</p>  
  
    ```  
  
<a name="bkmk_DebugApp"></a>   
## Debug the app  
 When you press F5 to debug the application you may get error that the certificate accessing localhost using SSL is not trusted. The following are some links to resolve this issue with [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)]and IIS Express:  
  
-   [http://stackoverflow.com/questions/20036984/how-do-i-fix-a-missing-iis-express-ssl-certificate](http://stackoverflow.com/questions/20036984/how-do-i-fix-a-missing-iis-express-ssl-certificate)  
  
-   [https://blogs.msdn.microsoft.com/robert_mcmurray/2013/11/15/how-to-trust-the-iis-express-self-signed-certificate/](https://blogs.msdn.microsoft.com/robert_mcmurray/2013/11/15/how-to-trust-the-iis-express-self-signed-certificate/)  
  
> [!NOTE]
>  For this step, you can simply use the [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] associated with your Azure AD tenant and the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] tenant that it is associated with. This isn’t actually demonstrating a multi-tenant scenario. We will do that in the next step. This step is just to verify that the code works before introducing the additional complexity of testing the actual multi-tenant functionality.  
  
 Refer to the steps described in [Goal of this walkthrough](#bkmk_goal) to test the application.  
  
 At this point you can verify that the application user account was used. An easy way to check this is by using the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Web API. Type in the following URL into a separate tab or window, substituting the `UserId` value from the application.  
  
```
[Organization URI]/api/data/v9.0/systemusers(<UserId value>)?$select=fullname  
```  
  
 The  JSON response should look like the following. Notice that the fullname value will be to the application user you created in the [Create an application user](#bkmk_CreateApplicationUser) step, rather than the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user you used to sign into the application.  
  
```json  
{  
    "@odata.context": "[Organization Uri]/api/data/v9.0/$metadata#systemusers(fullname)/$entity",  
    "@odata.etag": "W/\"603849\"",  
    "fullname": "S2S User",  
    "systemuserid": "31914b34-be8d-e611-80d8-00155d892ddc",  
    "ownerid": "31914b34-be8d-e611-80d8-00155d892ddc"  
}  
  
```  
  
<a name="bkmk_ConfigureTestSubscriber"></a>   
## Configure test subscriber  
 Now that you have verified that the application works, it time to test connectivity to a different [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] tenant.  Using a different [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] organization you will need to perform the following steps.  
  
<a name="bkmk_GiveConsentFromSubscriber"></a>   
### Give consent from the subscribing tenant  
 To give consent, perform the following steps while logged in as the Azure AD admin:  
  
1.  While you are debugging your application, open a separate InPrivate or incognito window.  
  
2.  In the address field of the window type the URL for your app, i.e. `https://localhost:44392/`  
  
3.  Click the **Sign in** button  and you will be prompted to grant consent.  
  
 ![Azure Active Directory consent form](media/mvc-s2s-walkthrough-app-grant-consent.PNG "Azure Active Directory consent form")  
  
 After you grant consent you will return to the app, but you won’t be able to use it yet. If you click **WhoAmI** at this point you can expect the following exception:  
  
```
System.ServiceModel.Security.MessageSecurityException  
HResult=-2146233087  
  Message=The HTTP request is unauthorized with client authentication scheme 'Anonymous'. The authentication header received from the server was 'Bearer authorization_uri=https://login.windows.net/4baaeaaf-2771-4583-99eb-7c7e39aa1e74/oauth2/authorize, resource_id=https://<org name>.crm.dynamics.com/'.  
InnerException.Message =The remote server returned an error: (401) Unauthorized.  
```  
  
 By granting consent, the application from your Azure AD tenant will be added to the applications in the subscriber’s active directory tenant.  
  
<a name="bkmk_CreateSubscriberSecurityRole"></a>

### Create a custom security role in the subscriber tenant

 The application user  you will need to create must be associated with a custom security role which defines their privileges. For this manual testing step, you should first manually create a custom security role. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a security role](../admin/create-edit-security-role.md)  
  
> [!NOTE]
>  The application user cannot be associated with one of the default [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)] security roles. You must create a custom security role to associate with the application user.  
  
<a name="bkmk_CreateSubscriberUser"></a>

### Create the subscriber application user

 For the purposes of this walkthrough, we will manually create the application user to verify connectivity from a different tenant. When you deploy to actual subscribers, you will want to automate this. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Prepare a method to deploy the application user](use-multi-tenant-server-server-authentication.md#bkmk_PrepareMethodToDeployAppUser)  
  
 You create the application user  manually using the same values you used for your development organization in [Create an application user](#bkmk_CreateApplicationUser). The exception is that you must have completed the step to grant consent first. When you save the user, the **Application ID URI** and **Azure AD Object ID** values will be set. You will not be able to save the user if you haven’t granted consent first.  
  
 Finally, associate the application user  with the custom security role you added in the previous step.  
  
<a name="bkmk_TestSubscriber"></a>

### Test the subscriber connection

 Repeat the steps in [Debug the app](#bkmk_DebugApp) except use the credentials for a user from the other [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] tenant.  
  
### See also  
 [Use Multi-Tenant Server-to-server authentication](use-multi-tenant-server-server-authentication.md)   
 [Use Single-Tenant Server-to-server authentication](use-single-tenant-server-server-authentication.md)   
 [Build web applications using Server-to-Server (S2S) authentication](build-web-applications-server-server-s2s-authentication.md)   
 [Connect to Dynamics 365](connect-customer-engagement.md)
