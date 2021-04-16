---
title: "Authenticate Office 365 users with Customer Engagement web services (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This topic applies to customers who access Dynamics 365 Customer Engagement (on-premises) Customer Engagement through the Microsoft Online Services environment. It discusses how Dynamics 365 Customer Engagement (on-premises) web service authentication with managed domain and federated identity providers works"
ms.custom: 
ms.date: 02/03/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: bdd3b0f8-bdd7-4604-941e-7308f4c2d83c
caps.latest.revision: 49
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Authenticate Office 365 users with Customer Engagement web services

This topic applies to customers who access Dynamics 365 Customer Engagement (on-premises) through the 
[!INCLUDE[pn_ms_online_services_environment](../includes/pn-ms-online-services-environment.md)]. There are multiple 
Dynamics 365 Customer Engagement (on-premises) identity providers that must be accounted for when you develop an application that connects to the Organization or 
Discovery web services. These providers can be identified as managed domain, federated, and [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)]. 
This topic focuses on Dynamics 365 Customer Engagement (on-premises) web service authentication with managed domain and federated identity providers, 
although the same classes and code shown here also work with all supported identity providers and Dynamics 365 Customer Engagement (on-premises) deployment types.  
  
<a name="bkmk_simplified"></a>
   
## Use the simplified authentication classes 

 You can use the  <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> and <xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy> classes when authenticating with the web services.  
For more information about using these proxy classes see [Authentication by using the client proxy classes](active-directory-claims-based-authentication.md#bkmk_clientproxy). 

 > [!NOTE]
> The sample helper code containing the `ServerConnection` class is no longer maintained and will be removed some time in the future. Instead, use one of the supported authentication APIs in the SDK assemblies such as <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>.

 Another authentication approach is to use the helper source code provided in the SDK. The `ServerConnection` helper class, shown in 
[Helper Code: ServerConnection Class](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/samples-from-msdn/QuickStart/SDK%20Helper%20Code/CrmServiceHelpers.cs), provides `GetOrganizationProxy` and `GetProxy` methods for authentication. 
If you look at the source code for `ServerConnection`, you will see that `GetOrganizationProxy` actually calls `GetProxy`.  
  
```csharp  
using ( OrganizationServiceProxy orgServiceProxy = ServerConnection.GetOrganizationProxy(serverConfig) ) { }  
```  
  
 You must create these organization or discovery service proxy objects in a `using` statement to correctly dispose of the service proxy, 
or call `Dispose` directly. For sample code that uses the `GetOrganizationProxy` helper code method, see [Sample: Quick Start](sample-quick-start.md).  
  
 The complete list of authentication classes available in the SDK assemblies are shown in the [Authentication Classes](active-directory-claims-based-authentication.md#bkmk_classes) section.  
  
<a name="bkmk_migration"></a>

## Authenticate Microsoft account users with Office 365

 Your application needs to support those Dynamics 365 Customer Engagement (on-premises) users whose organization is transitioned from the 
[!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] identity provider to the [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] identity 
provider. In this scenario, users may provide their [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] sign-in credentials when they authenticate with the 
[!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] identity provider of Dynamics 365 Customer Engagement (on-premises).  
  
 To do this, pass the populated credentials in the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> constructor or the <xref:Microsoft.Xrm.Sdk.Client.AuthenticationCredentials> method of the `IServiceManagement` class. The credential values are populated as follows:  
  
```csharp  
AuthenticationCredentials.ClientCredentials = <Microsoft account sign-in credentials>  
AuthenticationCredentials.SupportingCredentials.ClientCredentials = <device credentials>  
``` 

 If your code checks the identity provider type to determine how to authenticate, then additional code is required. See the `GetCredentials` method in the next section for sample code that supports transitioned [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] users.  
  
 For more information about this transition, see [Dynamics 365 Customer Engagement (on-premises) Integration with Office 365](online-integration-office-365.md).  
  
<a name="bkmk_deep"></a> 
  
## Authentication deep dive  

 The previous discussion introduced two simple approaches that can be used to authenticate a user with the Dynamics 365 Customer Engagement (on-premises) web services. The following information shows how to authenticate a user by using the <xref:Microsoft.Xrm.Sdk.Client.IServiceManagement`1>
 class and includes the source code to the `GetProxy` method. 
To see the complete sample that contains the following examples, see [Sample: Authenticate Office 365 Users](sample-authenticate-users-web-services.md). You will notice that authentication at this level takes a lot more code.  
  
 The following sample code demonstrates the classes and methods that you can use in your application to authenticate an 
[!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]/MOS user using the Dynamics 365 Customer Engagement (on-premises) web services.  
  
 [!code-csharp[AuthenticateWithNoHelp#AuthenticateWithNoHelp3](../snippets/csharp/CRMV8/authenticatewithnohelp/cs/authenticatewithnohelp3.cs#authenticatewithnohelp3)]  

  
 The code creates an <xref:Microsoft.Xrm.Sdk.Client.IServiceManagement`1> object for the Organization service. An object of type <xref:Microsoft.Xrm.Sdk.Client.AuthenticationCredentials> is used to contain the user’s sign-in credentials. The `IServiceManagement` object and user credentials are then passed to `GetProxy` to obtain the web service proxy reference.  
  
 [!code-csharp[AuthenticateWithNoHelp#AuthenticateWithNoHelp2](../snippets/csharp/CRMV8/authenticatewithnohelp/cs/authenticatewithnohelp2.cs#authenticatewithnohelp2)]  

  
 The <xref:Microsoft.Xrm.Sdk.Client.AuthenticationCredentials> object is configured according to the subscribed identity for the signed-in user. Notice that user credentials for all types of identity 
providers are shown. The default case handles [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)]/MOS managed domain, online users whose identities are federated 
in the cloud, and transitioned [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] users. Now let’s take a look at what `GetProxy` actually does.  
  
 [!code-csharp[AuthenticateWithNoHelp#AuthenticateWithNoHelp4](../snippets/csharp/CRMV8/authenticatewithnohelp/cs/authenticatewithnohelp4.cs#authenticatewithnohelp4)]  

  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

For all deployments other than on-premises 
([!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], without claims), the <xref:Microsoft.Xrm.Sdk.Client.IServiceManagement`1.Authenticate(Microsoft.Xrm.Sdk.Client.AuthenticationCredentials)> method is invoked and 
then the service proxy is instantiated. Notice that the authentication credentials returned from `Authenticate` contain the security token response that is used in the service 
proxy constructor. The generic `GetProxy` method shown previously can be used to obtain an object reference to either 
<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> or 
<xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy>.  
  
### See also 
 
 [Connect with Microsoft Office 365 and Dynamics 365 Customer Engagement (on-premises)](connect-microsoft-office-365.md)
 [Sample: Authenticate Office 365 Users](sample-authenticate-users-web-services.md)   
 [Helper Code: ServerConnection Class](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/samples-from-msdn/QuickStart/SDK%20Helper%20Code/CrmServiceHelpers.cs)   
 [Active Directory and Claims-Based Authentication](active-directory-claims-based-authentication.md)   
 [Use connection strings in XRM tooling to connect to Dynamics 365 Customer Engagement (on-premises)](xrm-tooling/use-connection-strings-xrm-tooling-connect.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]