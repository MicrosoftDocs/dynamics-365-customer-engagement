---
title: "Active Directory and claims-based authentication (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn how claims based authentication works using a security token service(STS) server and how Active Directory authentication works"
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: dc81b2ec-c4db-44b9-8fe6-db108b196a96
caps.latest.revision: 85
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Active Directory and claims-based authentication

Claims-based authentication provides an industry standard security protocol to authenticate a user on a host computer. Claims-based authentication is a set of WS-* standards describing the use of a Security Assertion Markup Language (SAML) token in either passive mode (when WS-Federation is used with the [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] web application) or active mode (where WS-Trust in used with [!INCLUDE[pn_WCF_long](../includes/pn-wcf-long.md)] clients). This authentication works together with WCF to provide secure user authentication and a communication channel with a Dynamics 365 Server. All Dynamics 365 Customer Engagement (on-premises) edition support claims-based authentication.

 Claims-based authentication requires the availability of a security token service (STS) running on a server. An STS server can be based on [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] Federation Services (AD FS) V2, or any platform that provides the official STS protocol. More information: [TechNet: Configure IFD for Dynamics 365 Customer Engagement (on-premises)](https://technet.microsoft.com/library/dn609803.aspx).   

<a name="bkmk_scenarios"></a>

## Supported authentication scenarios 

 Dynamics 365 Customer Engagement (on-premises) support the following authentication scenarios for each deployment type.  

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

|                                                 Deployment                                                 |                                                  Authentication model                                                   |
|------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------|
|           [!INCLUDE[pn-crm-onprem](../includes/pn-crm-onprem.md)]          |           Claims-based or [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] authentication            |
| [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Internet-facing deployment (IFD) |           Claims-based or [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] authentication            |

### How claims-based authentication works  
 A request to authenticate a user is sent from [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] or a custom application to the STS server. The STS server determines whether the user should be authenticated, and if so, issues a signed and encrypted SAML token that contains user authentication information. The token has a finite life span and may have to be periodically refreshed depending on how long your application is using the token. This is discussed in more detail later in this topic.  

### How Active Directory authentication works  
 A request to authenticate a user is sent from Dynamics 365 Customer Engagement (on-premises) or a custom application to [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. The WCF stack manages the authentication process for Organization Service calls from an application, whereas [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] manages authentication for a web application.  

<a name="bkmk_unsupported"></a>   

## Unsupported authentication scenarios

 Use of client certificates is not supported. If you configure the Dynamics 365 Customer Engagement website to require IIS client certificates, you will get authentication failures for any applications that were built using the SDK.  

 For more information about additional unsupported programming methods see [Unsupported Customizations](supported-extensions.md#Unsupported).  

<a name="bkmk_classes"></a> 

## Authentication classes

 The following table lists the primary authentication classes available in the SDK, describes when to use them, and provides links to additional relevant documentation.

> [!TIP]
> Depending on your application scenario, the best method to authenticate a .NET client application with any deployment of Dynamics 365 Customer Engagement (on-premises) is to use the new XRM Tooling classes. For more info see [Build Windows client applications using the XRM tools](build-windows-client-applications-xrm-tools.md).

|                                                     Classes                                                     |                                                                                                                                                                                                          Usage                                                                                                                                                                                                           |                                                                                                                                                                   Related Documentation                                                                                                                                                                   |
|-----------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  <xref:Microsoft.Xrm.Sdk.Client.IServiceConfiguration`1>, <xref:Microsoft.Xrm.Sdk.Client.IServiceManagement`1>  |                                                                                  All deployment types: on-premises/IFD, online ([!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] and [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]/MOS<sup>\*</sup>)<br /><br /> Best choice for multi-threaded applications                                                                                  | [Authenticate Office 365 Users with Dynamics 365 Customer Engagement Web Services](authenticate-office-365-users-customer-engagement-web-services.md)<br /><br /> [Sample: Authenticate Users with Dynamics 365 Customer Engagement Web Services](sample-authenticate-users-web-services.md)<br /><br /> [Improve service channel allocation performance](best-practices-sdk.md#caching) |
| <xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy>, <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> |                                                                                                              All deployment types: on-premises/IFD, online ([!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] and [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]/MOS<sup>\*</sup>)                                                                                                              |                    [Authentication by Using the Client Proxy Classes](active-directory-claims-based-authentication.md#bkmk_clientproxy)<br /><br /> [Sample: Access the Discovery Service](/powerapps/developer/common-data-service/org-service/discovery-service#example)<br /><br /> [Improve service channel allocation performance](best-practices-sdk.md#caching)                    |
|        [CrmConnection Class](https://msdn.microsoft.com/library/microsoft.xrm.client.crmconnection.aspx)        |                                                                                                              All deployment types: on-premises/IFD, online ([!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] and [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]/MOS<sup>\*</sup>)                                                                                                              |                                             [Sample: Simplified Connection Quick Start using Customer Engagement (on-premises)](xrm-tooling/sample-simplified-connection-quick-start.md)                                             |

 <sup>*</sup> [!INCLUDE[pn_ms_online_services_environment](../includes/pn-ms-online-services-environment.md)]  

<a name="bkmk_clientproxy"></a>   
## Authentication by using the client proxy classes  
 One way to authenticate with the Dynamics 365 Customer Engagement (on-premises) web services is by using the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> and <xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy> classes in the applications that you write. The four-parameter constructor of these classes supports [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] deployment. These proxy classes automatically handle claims or [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] authentication and also manage resource limits on the WCF channel endpoint.  

 The following code shows how to instantiate the organization service proxy:  

```csharp  
using (OrganizationServiceProxy _serviceProxy = new OrganizationServiceProxy(organizationUri, homeRealmUri, userCredentials, deviceCredentials))  
```  

 The following code shows how to instantiate the discovery service proxy:  

```csharp  
using (DiscoveryServiceProxy _discProxy = new DiscoveryServiceProxy(organizationUri, homeRealmUri, userCredentials, deviceCredentials))  
```  

 It is important to properly dispose of the service proxy instance in your application before the application terminates. The `using` statement makes sure that the service proxy is correctly disposed by automatically calling `Dispose` on the service proxy when it goes out of scope. However, for improved application performance, it is a best practice to keep the service proxy instance available in your application for the entire application session instead of disposing it and allocating it again somewhere else in the application code when needed. The reason being that creating and authenticating a service channel is an expensive operation (in time). In this case, when you are done with the service proxy instance, you must directly call the **Dispose** method on the proxy before the application terminates.  

 The device credentials of the registered computing device are only used when authenticating with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] through the [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] identity provider. For sample code that shows how to populate the proxy constructor parameters, see [Sample: Access the Discovery Service](/powerapps/developer/common-data-service/org-service/discovery-service#example).  

> [!IMPORTANT]
>  For an on-premises or an Internet-facing deployment (IFD) installation of [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], the client proxy classes use claims-based authentication if an STS server is available. Otherwise, [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] authentication is used.  

 If you want to use Dynamics 365 Customer Engagement (on-premises) early-bound entity types in your code, you must add the following line of code after the organization service proxy is instantiated, but before you make web service method calls:  

```csharp  
_serviceProxy.EnableProxyTypes()  
```  

> [!IMPORTANT]
>  WCF supports a feature where it can interactively prompt the user for logon credentials when it is necessary. This feature is enabled by setting the [SupportInteractive](https://msdn.microsoft.com/library/system.servicemodel.description.clientcredentials.supportinteractive.aspx) property of the `ClientCredentials` class. These credentials are used in the `userCredentials` parameter shown in the previous code snippet.  
> 
>  When making SDK calls to the Dynamics 365 Customer Engagement (on-premises) web services, the ownership of the operation and entity data changes performed by the SDK call can be changed by this WCF feature independent of your code.  
> 
> Dynamics 365 Customer Engagement (on-premises) handle supplied credentials in web service calls as follows:  
> 
> - If credentials are not supplied in the web service call, the WCF stack determines which credentials to use. In that case, the `SupportInteractive` property value is automatically set to `false`.  
>   -   If credentials are explicitly supplied by your code, the current `SupportInteractive` value is passed to the WCF channel factory. `SupportInteractive` is set to `true` by default unless you explicitly change it.  
>   -   If `SupportInteractive` is set to `true` and the provided credentials fail, a WCF dialog box may be displayed. Any credentials entered by the user into the dialog box will be used instead of those supplied in the web service calls that your application invokes.  

<a name="bkmk_faults"></a>   
## Handling channel exceptions and faults  
 Your code should catch the following exceptions and faults. See the C# samples in the developer documentation for a list of additional exceptions to catch:  

- [System.TimeoutException](https://msdn.microsoft.com/library/system.timeoutexception.aspx)  

- [FaultException](https://msdn.microsoft.com/library/system.servicemodel.faultexception.aspx) \<<xref:Microsoft.Xrm.Sdk.OrganizationServiceFault>>  

- [FaultException](https://msdn.microsoft.com/library/system.servicemodel.faultexception.aspx) \<<xref:Microsoft.Xrm.Sdk.DiscoveryServiceFault>>  

  For more information, see the [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)] [WCF documentation](https://msdn.microsoft.com/library/ms789039.aspx) about how to handle WCF faults and exceptions.  

<a name="bkmk_saml"></a>   
## Additional information about the security (SAML) token  
 The SAML token used during user authentication is described below.  

### Contents of the SAML token  
 The XML-based SAML 2.0 token contains an identity that defines one or more claims about a user. This token is passed between an identity provider (STS) server and Dynamics 365 Customer Engagement (on-premises) for claims-based authentication. The claims in the identity have been defined as follows.  


|             Claim              |                                                                                                                                                                                                                     Use                                                                                                                                                                                                                      |
|--------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Universal Principal Name (UPN) |                                                                                                                                                       Contains the user’s ID in domain\alias format on the target Dynamics 365 Server.                                                                                                                                                        |
|              Name              | If the authenticated user is also a Deployment Administrator in Dynamics 365 Customer Engagement (on-premises), this claim contains the deployment administrator’s ID in domain\alias format on the target Dynamics 365 Server. [!INCLUDE[pn_Windows_Identity_Foundation](../includes/pn-windows-identity-foundation.md)] maps the `Name` claim to the `Identity.name` property. |
|        Any other claims        |                                                                                                                                                                                   Not used by Dynamics 365 Customer Engagement (on-premises).                                                                                                                                                                                   |

### Supported security token types  
 [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] support two types of SAML tokens:  

- **Web application** - The Dynamics 365 Customer Engagement (on-premises) web application receives a bearer token from STS. This token is missing some required information so a Transport Layer Security (TLS) or Secure Sockets Layer (SSL)-based URL (https://) is used for security protection when you access the WCF endpoint.  

- **SDK** - A custom application receives an active token with a proof key that contains the required information.  

### Lifecycle of the security token  
 A [SecurityToken](https://msdn.microsoft.com/library/system.identitymodel.tokens.securitytoken.aspx) has a life span identified by its `ValidFrom` and `ValidTo` properties. Your application design should consider the possibility that the token could expire, resulting in an [ExpiredSecurityTokenException](https://msdn.microsoft.com/library/system.servicemodel.security.expiredsecuritytokenexception\(VS.85\).aspx) being thrown by the Dynamics 365 Customer Engagement (on-premises) web services when the next message request from your application is processed.  

### See also  
 [Walkthrough: Register a Dynamics 365 Customer Engagement (on-premises) with Active Directory](walkthrough-register-app-active-directory.md)   
 [Connect with Microsoft Office 365 and Dynamics 365 Customer Engagement (on-premises)](connect-microsoft-office-365.md)   
 [Implement Single Sign-on from an ASPX Webpage or IFRAME](implement-single-sign-aspx-webpage-iframe.md)   
 [Sample: Authenticate Users with Dynamics 365 Customer Engagement Web Services](sample-authenticate-users-web-services.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]