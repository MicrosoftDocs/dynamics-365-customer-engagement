---
title: "Use CrmServiceClient constructors to connect to Dynamics 365 (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "You can create an instance of the CrmServiceClient class, and then use one of the constructors to connect to Dynamics 365 Customer Engagement"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 74862506-a955-4846-a148-ac266f65592f
caps.latest.revision: 27
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Use CrmServiceClient constructors to connect to Dynamics 365

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

To connect to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement, you create an instance of the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> class, and then use one of the constructors to connect. All the calls to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] using the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> class are thread safe.  
  
 Apart from the constructors mentioned in this topic, you can also use connection strings with <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> to connect to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Use connection strings in XRM tooling to connect to Dynamics 365](use-connection-strings-xrm-tooling-connect.md)  
  
<a name="orgServiceproxy"></a>

## Connect to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] using OrganizationServiceProxy

 Use the following constructor to connect to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] using the user-provided <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> instance.  
  
```csharp
CrmServiceClient crmSvc = new CrmServiceClient(<orgServiceProxy>);  
```  
  
<a name="orgWebProxyClient"></a>

## Connect to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] using OrganizationWebProxyClient

 Use the following constructor to connect to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] using the user-provided <xref:Microsoft.Xrm.Sdk.WebServiceClient.OrganizationWebProxyClient> instance. This constructor is introduced in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)].  
  
```csharp
CrmServiceClient crmSvc = new CrmServiceClient(<orgWebProxyClient>);  
```  
  
<a name="Office365"></a>

## Connect to [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] (Office 365)

 Use the following constructor to connect to your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] instance in [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)].  
  
```csharp  
CrmServiceClient crmSvc = new CrmServiceClient("<UserName>", CrmServiceClient.MakeSecureString("<Password>"), "<CrmRegion>", "<OrgName>", useUniqueInstance:false, useSsl:false, <orgDetail>, isOffice365:true);  
```  
  
 Valid values for the `<CrmRegion>` parameter are:  `NorthAmerica`, `EMEA`, `APAC`, `SouthAmerica`,  `Oceania`, `JPN`, `CAN`, `IND`, and `NorthAmerica2`. If you set this to `String.Empty`, it will search servers in all the regions for the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] organization. For the `<OrgName>` parameter, you can specify either the unique or friendly name.  
  
 The following parameters are optional:  `useUniqueInstance`, `useSsl`, and `orgDetail`.  
  
<a name="Office365oAuth"></a>

## Connect to [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] (Office 365) using OAuth
 
 Use the following constructor to use OAuth protocol to connect to your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] instance in [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)]. The OAuth support is introduced in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)].  
  
```csharp  
CrmServiceClient crmSvc = new CrmServiceClient("<UserName>", CrmServiceClient.MakeSecureString("<Password>"), "<CrmRegion>", "<OrgName>", useUniqueInstance:false, <orgDetail>,  
                  <userIdentifier>, <clientId>, <redirectUri>, <tokenCachePath>, <externalOrgWebProxyClient>, PromptBehavior.Auto);  
```  
  
 This constructor uses [Microsoft Azure Active Directory Authentication Library (ADAL)](https://azure.microsoft.com/en-us/documentation/articles/active-directory-authentication-libraries/) to authenticate users. If the user credentials (user name and password) aren’t specified, ADAL prompts the user to provide the credentials depending on the `PromptBehavior` parameter (optional) specified in the constructor. ADAL authenticates the credentials using the OAuth protocol, obtains the access and refresh tokens from [!INCLUDE[pn_azure_active_directory](../../includes/pn-azure-active-directory.md)], and then uses the access token to make requests to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].  
  
 Valid values for the `<CrmRegion>` parameter are: `NorthAmerica`, `EMEA`, `APAC`, `SouthAmerica`, `Oceania`, `JPN`, `CAN`, `IND`, and `NorthAmerica2`. If you set this to **String.Empty**, it will search servers in all the regions for the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] organization. For the `<OrgName>` parameter, you can specify either the unique or friendly name.  
  
<a name="ActiveDirectory"></a>

## Connect to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] on-premises (Active Directory)

 [!INCLUDE[cc_sdk_onpremises_note](../../includes/cc-sdk-onpremises-note.md)] Use the following constructor to connect to an on-premises instance with [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] authentication.  
  
```csharp  
CrmServiceClient crmSvc = new CrmServiceClient(new System.Net.NetworkCredential("<UserName>", "<Password>", “<Domain>”), AuthenticationType.AD, "<Server>", "<Port>", "<OrgName>", useUniqueInstance:false, useSsl:false, <orgDetail>);  
  
```  
  
 This will run an [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] authentication based on the specified domain. For the `<Server>` parameter, specify the host name of your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server, for example: `crmtest`. For the `<OrgName>` parameter, you can specify either the unique or friendly name.  
  
 The following parameters are optional: `useUniqueInstance`, `useSsl`, and `orgDetail`.  
  
<a name="IFD"></a> 
  
## Connect to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Internet-facing deployment (IFD) 
 
 Use the following constructor to connect to a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] IFD instance.  
  
```csharp
CrmServiceClient crmSvc = new CrmServiceClient(new System.Net.NetworkCredential("<UserName>", "<Password>", “<Domain>”), AuthenticationType.IFD, "<Server>", "<Port>", "<OrgName>", useUniqueInstance:false, useSsl:false, <orgDetail>);  
  
```  
  
 This will run a claims-based authentication based on the specified local domain. This is useful for customers that use [!INCLUDE[pn_adfs_short](../../includes/pn-adfs-short.md)], and have configured their [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server as claims, where the user population lives in the same [!INCLUDE[pn_adfs_short](../../includes/pn-adfs-short.md)] domain as the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server. For the `<Server>` parameter, specify the host name of your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server, for example, `crmtest`. For the `<OrgName>` parameter, you can specify either the unique or friendly name.  
  
 The following parameters are optional: `useUniqueInstance`,  `useSsl`, and `orgDetail`.  
  
<a name="OPoAuth"></a> 

## Connect to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Internet-facing deployment (IFD) using OAuth

 Use the following constructor to use the OAuth protocol in [!INCLUDE[pn_adfs_windows_server_2012R2_long](../../includes/pn-adfs-windows-server-2012r2-long.md)] to connect to a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] IFD instance. For this constructor to work, the computer where [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] is installed must have been configured to use [!INCLUDE[pn_adfs_short](../../includes/pn-adfs-short.md)] 2.2 as the security token service (STS). The OAuth support for connecting to a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] IFD instance is introduced in [!INCLUDE[pn_crm_2016_shortest](../../includes/pn-crm-2016-shortest.md)].  
  
```csharp
CrmServiceClient crmSvc = new CrmServiceClient("<UserName>", CrmServiceClient.MakeSecureString("<Password>"), "<HomeRealm>", "<HostName>", "<Port>", "<OrgName>", useSsl:true, useUniqueInstance:false,   
                        <orgDetail>, <userIdentifier>, <clientId>, <redirectUri>, <tokenCachePath>, externalOrgWebProxyClient, PromptBehavior.Auto);  
  
```  
  
 The `clientId` and `redirectUri` values for the application supporting OAuth should be registered in the IFD server.  
  
 If the user credentials (user name and password) aren’t specified, ADAL prompts the user to provide the credentials depending on the `PromptBehavior` parameter (optional) specified in the constructor. ADAL authenticates the user using the security token from [!INCLUDE[pn_adfs_short](../../includes/pn-adfs-short.md)], and uses the token to perform actions in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].  
  
<a name="ClaimsBased"></a>
   
## Connect to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] (claims-based)
  
 Use the following constructor to use claims-based authentication.  
  
```  
CrmServiceClient crmSvc = new CrmServiceClient(new System.Net.NetworkCredential("<UserName>", "<Password>", “<Domain>”, "<HomeRealm>"),"<Server>", "<Port>", "<OrgName>");    
```  
  
 This will run a claims-based authentication against the specified Home realm. This is useful for customers that use [!INCLUDE[pn_adfs_short](../../includes/pn-adfs-short.md)], and have configured their [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server as claims, where the user population lives in the same [!INCLUDE[pn_adfs_short](../../includes/pn-adfs-short.md)] domain as the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server. For the `<Server>` parameter, specify the host name of your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server, for example, `crmtest`. For the `<OrgName>` parameter, you can specify either the unique or friendly name.  
  
<a name="Determine"></a>

## Determine your connection status
 
 To determine if the connection request was successful, check the value of the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>.<xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient.IsReady> property. If **true**, the connection is successful, and you are ready to work. Otherwise, check the values of the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>. <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient.LastCrmError> and <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>.<xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient.LastCrmException> properties for the cause of the connection failure.  
  
### See also

 [Use connection strings in XRM tooling to connect to Dynamics 365](use-connection-strings-xrm-tooling-connect.md)   
 [Use XRM Tooling Windows PowerShell Cmdlets to connect to Dynamics 365](use-powershell-cmdlets-xrm-tooling-connect.md)   
 [Use XRM Tooling API to execute actions in Dynamics 365](use-xrm-tooling-execute-actions.md)   
 [Sample: Quick Start for Dynamics 365](../sample-quick-start.md)   
 <xref:Microsoft.Xrm.Tooling.Connector.AuthenticationType>   
 [Build windows client applications using the XRM tools](../build-windows-client-applications-xrm-tools.md)
