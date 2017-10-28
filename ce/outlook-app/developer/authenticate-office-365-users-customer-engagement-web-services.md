---
title: "Authenticate Office 365 users with Customer Engagement web services (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This topic applies to customers who access Dynamics 365 (online) Customer Engagement through the Microsoft Online Services environment. It discusses how Dynamics 365 (online) web service authentication with managed domain and federated identity providers works"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bdd3b0f8-bdd7-4604-941e-7308f4c2d83c
caps.latest.revision: 49
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Authenticate Office 365 users with Customer Engagement web services
This topic applies to customers who access [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement through the 
[!INCLUDE[pn_ms_online_services_environment](../includes/pn-ms-online-services-environment.md)]. There are multiple 
[!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] identity providers that must be accounted for when you develop an application that connects to the Organization or 
Discovery web services. These providers can be identified as managed domain, federated, and [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)]. 
This topic focuses on [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] web service authentication with managed domain and federated identity providers, 
although the same classes and code shown here also work with all supported identity providers and [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] 
deployment types.  
  
<a name="bkmk_simplified"></a>   
## Use the simplified authentication classes  
 You can use the  <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> and [DiscoveryServiceProxy]
(https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.discoveryserviceproxy) classes when authenticating with the web services.  
For more information about using these proxy classes see [Authentication by using the client proxy classes](active-directory-claims-based-authentication.md#bkmk_clientproxy).  
  
 Another authentication approach uses the [CrmConnection](https://msdn.microsoft.com/library/microsoft.xrm.client.crmconnection.aspx) class. 
With just a few lines of code, your application can authenticate with the web services and start calling web methods. For more information about the 
[CrmConnection](https://msdn.microsoft.com/library/microsoft.xrm.client.crmconnection.aspx) class, see 
[Simplified connection to Microsoft Dynamics CRM](https://msdn.microsoft.com/library/gg695810.aspx). 
Sample code is available in the [Sample: Simplified connection quick start using Microsoft Dynamics CRM](https://msdn.microsoft.com/library/jj602970\(v=crm.7\).aspx) topic.  
  
```csharp  
CrmConnection connection = CrmConnection.Parse (connectionString);  
using ( OrganizationService orgService = new OrganizationService(connection)) { }  
```  
  
 Another authentication approach is to use the helper source code provided in the SDK. The `ServerConnection` helper class, shown in the 
[Helper Code: ServerConnection Class](org-service/helper-code-serverconnection-class.md) topic, provides `GetOrganizationProxy` and `GetProxy` methods for authentication. 
If you look at the source code for `ServerConnection`, you will see that `GetOrganizationProxy` actually calls `GetProxy`.  
  
```csharp  
using ( OrganizationServiceProxy orgServiceProxy = ServerConnection.GetOrganizationProxy(serverConfig) ) { }  
```  
  
 You must create these organization or discovery service proxy objects in a `using` statement to correctly dispose of the service proxy, 
or call `Dispose` directly. For sample code that uses the `GetOrganizationProxy` helper code method, see [Sample: Quick Start](sample-quick-start.md).  
  
 The complete list of authentication classes available in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)] is shown in the [Authentication Classes](active-directory-claims-based-authentication.md#bkmk_classes) section.  
  
<a name="bkmk_migration"></a>   
## Authenticate Microsoft account users with Office 365  
 Your application needs to support those [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] users whose organization is transitioned from the 
[!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] identity provider to the [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] identity 
provider. In this scenario, users may provide their [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] sign-in credentials when they authenticate with the 
[!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] identity provider of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
 To do this, pass the populated credentials in the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> constructor or the [AuthenticationCredentials)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.iservicemanagement`1.authenticate\(microsoft.xrm.sdk.client.authenticationcredentials\)) method of the `IServiceManagement` class. The credential values are populated as follows:  
  
```csharp  
  
AuthenticationCredentials.ClientCredentials = <Microsoft account sign-in credentials>  
AuthenticationCredentials.SupportingCredentials.ClientCredentials = <device credentials>  
``` 

 If your code checks the identity provider type to determine how to authenticate, then additional code is required. See the `GetCredentials` method in the next section for sample code that supports transitioned [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] users.  
  
 For more information about this transition, see [Dynamics 365 (online) Integration with Office 365](online-integration-office-365.md).  
  
<a name="bkmk_deep"></a>   
## Authentication deep dive  
 The previous discussion introduced two simple approaches that can be used to authenticate a user with the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] 
web services. The following information shows how to authenticate a user by using the 
[IServiceManagement\`1](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.iservicemanagement`1) class and includes the source code to the `GetProxy` method. 
To see the complete sample that contains the following examples, see [Sample: Authenticate Office 365 Users](sample-authenticate-users-web-services.md). 
You will notice that authentication at this level takes a lot more code.  
  
 The following sample code demonstrates the classes and methods that you can use in your application to authenticate an 
[!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]/MOS user using the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] web services.  
  
 [!code-csharp[AuthenticateWithNoHelp#AuthenticateWithNoHelp3](../snippets/csharp/CRMV8/authenticatewithnohelp/cs/authenticatewithnohelp3.cs#authenticatewithnohelp3)]  
  
 [!code-vb[AuthenticateWithNoHelpVB#AuthenticateWithNoHelp3](../snippets/visualbasic/CRMV8/authenticatewithnohelpvb/vb/authenticatewithnohelp3.vb#authenticatewithnohelp3)]  
  
 The code creates an [IServiceManagement\`1](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.iservicemanagement`1) object for the Organization service. An object of type <xref:Microsoft.Xrm.Sdk.Client.AuthenticationCredentials> is used to contain the user’s sign-in credentials. The `IServiceManagement` object and user credentials are then passed to `GetProxy` to obtain the web service proxy reference.  
  
 [!code-csharp[AuthenticateWithNoHelp#AuthenticateWithNoHelp2](../snippets/csharp/CRMV8/authenticatewithnohelp/cs/authenticatewithnohelp2.cs#authenticatewithnohelp2)]  
  
 [!code-vb[AuthenticateWithNoHelpVB#AuthenticateWithNoHelp2](../snippets/visualbasic/CRMV8/authenticatewithnohelpvb/vb/authenticatewithnohelp2.vb#authenticatewithnohelp2)]  
  
 The `AuthenticationCredentials` object is configured according to the subscribed identity for the signed-in user. Notice that user credentials for all types of identity 
providers are shown. The default case handles [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)]/MOS managed domain, online users whose identities are federated 
in the cloud, and transitioned [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] users. Now let’s take a look at what `GetProxy` actually does.  
  
 [!code-csharp[AuthenticateWithNoHelp#AuthenticateWithNoHelp4](../snippets/csharp/CRMV8/authenticatewithnohelp/cs/authenticatewithnohelp4.cs#authenticatewithnohelp4)]  
  
 [!code-vb[AuthenticateWithNoHelpVB#AuthenticateWithNoHelp4](../snippets/visualbasic/CRMV8/authenticatewithnohelpvb/vb/authenticatewithnohelp4.vb#authenticatewithnohelp4)]  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

For all deployments other than on-premises 
([!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], without claims), the [AuthenticationCredentials)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.client.iservicemanagement`1.authenticate\(microsoft.xrm.sdk.client.authenticationcredentials\)) method is invoked and 
then the service proxy is instantiated. Notice that the authentication credentials returned from `Authenticate` contain the security token response that is used in the service 
proxy constructor. The generic `GetProxy` method shown previously can be used to obtain an object reference to either 
<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> or 
<xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy>.  
  
### See also  
 [Connect with Microsoft Office 365 and Dynamics 365 (online)](connect-microsoft-office-365.md)
 [Sample: Authenticate Office 365 Users](sample-authenticate-users-web-services.md)   
 [Helper Code: ServerConnection Class](org-service/helper-code-serverconnection-class.md)   
 [Active Directory and Claims-Based Authentication](active-directory-claims-based-authentication.md)   
 [Use connection strings in XRM tooling to connect to Dynamics 365](xrm-tooling/use-connection-strings-xrm-tooling-connect.md)
