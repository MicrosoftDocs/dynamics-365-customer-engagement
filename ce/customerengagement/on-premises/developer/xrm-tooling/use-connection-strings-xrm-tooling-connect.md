---
title: "Use connection strings in XRM tooling to connect to Dynamics 365 Customer Engagement (on-premises) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "XRM tooling enables you to connect to your Dynamics 365 Customer Engagement (on-premises) instance by using connection strings"
ms.custom: 
ms.date: 10/04/2019
ms.reviewer: pehecke
ms.prod: dynamicscrm-2016 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: a98b2fce-df49-4b60-91f4-a4446aa61cd3
caps.latest.revision: 21
ms.author: nabuthuk
author: Nkrb
manager: kvivek
search.audienceType: 
  - developer

---
# Use connection strings in XRM tooling to connect to Dynamics 365 Customer Engagement (on-premises)

With Dynamics 365 Customer Engagement (on-premises), XRM tooling enables you to connect to your instance by using connection strings. This is similar to the concept of connection strings used with **SQL Server**. Connection strings have native support in configuration files, including the ability to encrypt the configuration sections for maximum security. This enables you to configure  Dynamics 365 Customer Engagement (on-premises) connections at deployment time, and not hard code in your application to connect to your instance.  


> [!NOTE]
> The connection string documentation that is applicable to Dataverse users is now available in the Power Apps documentation at: [Use connection strings in XRM tooling to connect to Dataverse](/powerapps/developer/common-data-service/xrm-tooling/use-connection-strings-xrm-tooling-connect)
>
> [!INCLUDE[cc-cdsnote-2-topic](../includes/cc-cdsnote-2-topic.md)] 

## Create a connection string

 You specify the connection string in the `app.config` or `web.config` file for your project, as shown in the following example.  

```xml  
<connectionStrings>  
    <add name="MyCRMServer" connectionString="AuthType=AD;Url=https://contoso:8080/Test;" />  
</connectionStrings>  
```  

> [!IMPORTANT]
> If you add any sensitive information to the `app.config` or `web.config` file, for example an account password, be sure to take appropriate security precautions to protect the information.  

 After creating the connection string, you use it to create a <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> object.  

```csharp  
//Use the connection string named "MyCRMServer"  
//from the configuration file  
CrmServiceClient crmSvc = new CrmServiceClient(ConfigurationManager.ConnectionStrings["MyCRMServer"].ConnectionString);  
```  

> [!NOTE]
> You’ll have to use the following `using` directive in your code to reference the `System.Configuration` namespace to access the connection string in your code: `using System.Configuration;`  

 After creating a <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> object, you can use the object to perform actions in Dynamics 365 Customer Engagement (on-premises). More information: [Use XRM Tooling to execute actions](/powerapps/developer/common-data-service/xrm-tooling/use-xrm-tooling-execute-actions)  

<a name="Parameters"></a>

## Connection string parameters

 The connection string contains a series of name=value pair separated by semi colons. The following table lists supported parameters, which can be entered in any order.  


|             Parameter name              |                                                                                                                                                                                                                                                                                                                                                                                                                              Description                                                                                                                                                                                                                                                                                                                                                                                                                              |
|-----------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `ServiceUri`, `Service Uri`, `Url`, or `Server` | Specifies the URL to the Dynamics 365 Server. The URL can use http or https protocol, and the port is optional. The default port is 80 for the http protocol and 443 for the https protocol. The server URL is typically in the format of https://crm-server:port/organization-name for Dynamics 365 Customer Engagement (on-premises).<br /><br /> The organization-name is required. You can specify either the friendly or the unique name of the organization to connect to.<br /><br /> Example: https://contoso/test, https://contoso:5555/test, https://contoso/test, or https://10.10.10.2/test. |
|                ` Domain`                  |                                                                                                                                                                                                                                                                                                                                                                                                        Specifies the domain that will verify user credentials.                                                                                                                                                                                                                                                                                                                                                                                                        |
| `UserName`, `User Name`, `UserId`, or `User Id` |                                                                                                                                                                                                                                                                                                                                                                                               Specifies the user's identification name associated with the credentials.                                                                                                                                                                                                                                                                                                                                                                                               |
|                `Password`                 |                                                                                                                                                                                                                                                                                                                                                                                               Specifies the password for the user name associated with the credentials.                                                                                                                                                                                                                                                                                                                                                                                               |
|     `HomeRealmUri` or `Home Realm Uri`      |                                                                                                                                                                                                                                                                                                                                                                                                                     Specifies the Home Realm Uri.                                                                                                                                                                                                                                                                                                                                                                                                                     |
|     `AuthenticationType` or `AuthType`      |                                                                                                                                                Specifies the authentication type to connect to Dynamics 365 Customer Engagement (on-premises). Valid values are: `AD`, `IFD` (AD FS enabled), `OAuth`, or `Office365`.<br /><br /> -   `AD` and `IFD` are permitted for Dynamics 365 Customer Engagement (on-premises) instances only.<br />-   `OAuth`, `Certificate`, and `ClientSecret` are permitted for Dynamics 365 Customer Engagement (on-premises) and Dataverse instances. For on-premises, ADFS 3.x+ and App\Client Id registration with ADFS is required for `OAuth`, `Certificate` and `ClientSecret` types.<br />-   `Office365` is permitted for Dataverse instances only.                                                                                                                                                |
|           `RequireNewInstance`            |                                                                                                                                                                                                                                                                                                         Specifies whether to reuse an existing connection if recalled while the connection is still active. Default value is `false` that indicates the existing connection be reused. If set to `true`, will force the system to create a unique connection.                                                                                                                                                                                                                                                                                                         |
|    `ClientId`, `AppId` or `ApplicationId`     |                                                                                                                                                                                                                                           Specifies the `ClientID` assigned when you registered your application in [!INCLUDE[pn_microsoft_azure_active_directory](../../includes/pn-microsoft-azure-active-directory.md)] or [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../../includes/pn-active-dir-fed-svcs-ad-fs.md)].                                                                                                                                                                                                                                           |
|         `RedirectUri` or `ReplyUrl`         |                                                                                                                                                                                                                                                Specifies the redirect URI of the application you registered in [!INCLUDE[pn_microsoft_azure_active_directory](../../includes/pn-microsoft-azure-active-directory.md)] or [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../../includes/pn-active-dir-fed-svcs-ad-fs.md)].<br /><br /> This parameter is applicable only when the authentication type is specified as `OAuth`.                                                                                                                                                                                                                                                |
|           `TokenCacheStorePath`           |                                                                                                                                                                                                                                                                       Specifies the full path to the location where the user token cache should be stored. The running process should have access to the specified path. It is the processes responsibility to set and configure this path.<br /><br /> This parameter is applicable only when the authentication type is specified as `OAuth`.                                                                                                                                                                                                                                                                       |
|               `LoginPrompt`               |                                                                                                                                                Specifies whether the user is prompted for credentials if the credentials are not supplied. Valid values are:<br /><br /> -   `Always`: Always prompts the user to specify credentials.<br />-   `Auto`: Allows the user to select in the login control interface whether to display the prompt or not.<br />-   `Never`: Does not prompt the user to specify credentials. If using a connection method does not have a user interface, you should use this value.<br /><br /> This parameter is applicable only when the authentication type is specified as `OAuth`.                                                                                                                                                 |
|               `SkipDiscovery`               |                                                                                                                                                Specifies whether to call instance discovery to determine the connection uri for a given instance.  As of NuGet release Microsoft.CrmSdk.XrmTooling.CoreAssembly Version 9.0.2.7, default = `true`.  Older versions default to `false`.  <br/>Note: If set to `true`, it is important that the user provide the correct and accurate URI for the target instance.                                                                                                                                                 |
|               `Thumbprint` or `CertificateThumbprint`               |                                                                                                                                                Specifies the thumbprint of the certificate to be utilized during an S2S connection. When set, AppID is required and UserID and Password values are ignored.                                                                                                         |
|               `StoreName` or `CertificateStoreName`               |                                                                                                                                                Specifies the store name where the certificate identified by thumbprint can be found. When set, Thumbprint is required.                                                                                                         |

> [!NOTE]
> <b>When using the `OAuth` AuthType\AuthenticationType</b><br/>
> For development and prototyping purposes we have provided the following AppId or ClientId and Redirect URI for use in OAuth Flows.<br/>
> For production use, you should create an AppId or ClientId that is specific to your tenant in the Azure Management portal.<br/>
> Sample AppId or ClientId = 51f81489-12ee-4a9e-aaae-a2591f45987d<br/>
> Sample RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97<br/>

<a name="Examples"></a>

## Connection string examples

 The following examples show how you can use connection strings for connecting to Dynamics 365 Customer Engagement (on-premises) and IFD deployments. The connection string examples for Dataverse instances is now available in the Power Apps documentation at: [Use connection strings in XRM tooling to connect to Dataverse](/powerapps/developer/common-data-service/xrm-tooling/use-connection-strings-xrm-tooling-connect)  

### Integrated on-premises authentication  

```xml
<add name="MyCRMServer"
connectionString="AuthType=AD;
Url=https://contoso:8080/Test;" />  
```  

### Named account using on-premises authentication  

```xml  
<add name="MyCRMServer"
connectionString="AuthType=AD;
Url=https://contoso:8080/Test;
Domain=CONTOSO;
Username=jsmith;
Password=passcode" />  
```  

### OAuth using named account in Dynamics 365 Customer Engagement (on-premises) with UX to prompt for authentication  

Create a new connection using a UserID or Password via oAuth.

> [!NOTE]
> OAuth is the preferred auth type for connecting to Dynamics 365 Customer Engagement (on-premises) when using an interactive flow.  This auth type fully supports the features of Azure Active Directory Conditional Access and Multi-Factor authentication.

```xml
<add name="MyCRMServer"
 connectionString="
  AuthType=OAuth;
  Username=jsmith;
  Password=passcode;
  Url=https://contoso:8080/Test;
  AppId=51f81489-12ee-4a9e-aaae-a2591f45987d;
  RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;
  TokenCacheStorePath=c:\MyTokenCache;
  LoginPrompt=Auto"/>  
```  

### OAuth using current logged in user with fall back UX to prompt for authentication

Create a new connection using the current logged in user via oAuth.

> [!NOTE]
> OAuth is the preferred auth type for connecting to Dynamics 365 Customer Engagement (on-premises) when using a interactive flow.  This auth type fully supports the features of Azure Active Directory Conditional Access and Multi-Factor authentication.
> To learn more about the `Integrated Security` parameter, see the topic [here](https://docs.microsoft.com/dotnet/framework/data/adonet/connection-string-syntax#windows-authentication).


```xml
<add name="MyCRMServer"
 connectionString="
  AuthType=OAuth;
  Username=jsmith;
  Integrated Security=true;
  Url=https://contoso:8080/Test;
  AppId=51f81489-12ee-4a9e-aaae-a2591f45987d;
  RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;
  TokenCacheStorePath=c:\MyTokenCache;
  LoginPrompt=Auto"/>  
```  

### Certificate based authentication

Create a new connection to Dynamics 365 Customer Engagement (on-premises) using a Application or Client Id and a Certificate.
```xml
<add name="MyCRMServer" 
  connectionString="
  AuthType=Certificate;
  url=https://contoso:8080/Test;
  thumbprint={CertThumbPrintId};
  ClientId={AppId};
  />
```

### ClientId or Client Secret based authentication

Create a new connection to Dynamics 365 Customer Engagement (on-premises) using a Application or Client Id and a Client Secret.
```xml
<add name="MyCRMServer" 
  connectionString="
  AuthType=ClientSecret;
  url=https://contoso:8080/Test;
  ClientId={AppId};
  ClientSecret={ClientSecret}
  />
```


### IFD using a named account with delegation to a sub realm  

```xml
<add name="MyCRMServer"
connectionString="AuthType=IFD;Url=https://contoso:8080/Test;
 HomeRealmUri=https://server-1.server.com/adfs/services/trust/mex/;
Domain=CONTOSO; 
Username=jsmith; 
Password=passcode" />  
```  

<a name="ConnectionStatus"></a>

## Determine your connection status

 To determine if the connection request was successful, check the value of the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>.<xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient.IsReady> property. If **true**, the connection is successful, and you are ready to work. Otherwise, check the values of the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>.<xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient.LastCrmError> and <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>.<xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient.LastCrmException> properties for the cause of the connection failure.  

### See also

 [Build Windows client applications using the XRM tools](../build-windows-client-applications-xrm-tools.md)<br />
 [Use CrmServiceClient constructors to connect to Dynamics 365 Customer Engagement (on-premises) and Dataverse](/powerapps/developer/common-data-service/xrm-tooling/use-crmserviceclient-constructors-connect)<br />
 [Use XRM Tooling to execute actions](/powerapps/developer/common-data-service/xrm-tooling/use-xrm-tooling-execute-actions)<br />
 <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
