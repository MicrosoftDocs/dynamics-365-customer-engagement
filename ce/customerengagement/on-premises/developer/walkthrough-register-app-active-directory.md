---
title: "Walkthrough: Register a Dynamics 365 Customer Engagement app with Active Directory (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This walkthrough describes how to register an application with Azure Active Directory so that it can connect to the Dynamics 365 Server, authenticate using OAuth, and access the web services"
ms.custom: 
ms.date: 03/29/2019
ms.prod: crm-2016
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - mobile, modern
  - register, registration
  - app
ms.assetid: dd48aa30-7b05-4b15-a039-ff6522da8613
caps.latest.revision: 57
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Walkthrough: Register a Dynamics 365 Customer Engagement app with Active Directory

This walkthrough describes how to register a desktop client or mobile application so that it can connect to and authenticate with the Dynamics 365 Server and access the Web services. Once registered, an application can access the Web services using HTTP requests through the server’s SOAP or Web API endpoints.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 

## Prerequisites  
 For an on-premises or Internet-facing deployment (IFD):  
  
- A [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)] with [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)].  
  
- You must have administrator access to the server hosting the Dynamics 365 Customer Engagement (on-premises) deployment services role and the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server.  
  
- The on-premises server must be configured to use claims authentication.  
  
- The redirect URL for your application. Instructions for finding that URL are provided in the section named [Obtain the redirect URL](walkthrough-register-app-active-directory.md#bkmk_redirect).  
  
<a name="bkmk_redirect"></a>   
## Obtain the redirect URI  
 One method to obtain the redirect URI for a native client [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] application is to execute the following line of code in a debug session of your application and examine the returned URI value. In a WinJS debug session, select the `RawUri` property.  
  
```csharp  
string redirectUri = WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString();  
```  
  
```vb  
Dim redirectUri As String = WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString()  
```  
  
```javascript  
Windows.Security.Authentication.Web.WebAuthenticationBroker.getCurrentApplicationCallbackUri()  
```  
  
 The `WebAuthenticationBroker` class can be found in the `Windows.Security.Authentication.Web` namespace. Use the string value returned from the method call when you register the app. 
 
 <!--The C# line of code is shown in the topic [Sample: Windows 8 desktop modern OData app](sample-windows-8-desktop-modern-odata-app.md).  -->
  
 For a non-[!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] native client application such as a console application, use any valid URI value. In this case, the URI doesn’t need to actually exist but it must be unique in the tenant.  
  
<a name="bkmk_ifd"></a>   
## App registration for Dynamics 365 Customer Engagement (on-premises) (IFD)  
 **Scenario**: A customer or other person registers a custom application to access organization data on a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] server provided by an ISV or Partner.  
  
#### The ISV or Partner performs the following tasks:  
  
1. Configures the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] on-premises (IFD) server and [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server using [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] commands that are provided later in this section.  
  
2. Provides the client ID and server address URL information to the customer.  
  
#### The customer or other person performs the following tasks:  
  
1.  Configures the external application by entering the client ID and server address URL in the app as instructed.  
  
### Dynamics 365 Server setup  
 To configure the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] server to enable federated claims, follow these steps.  
  
##### Configure claims settings  
  
1. Log on as administrator on the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] server that hosts the deployment service role and open a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command window.  
  
2. Add the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)][!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] snap-in (Microsoft.Crm.PowerShell.dll). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Administer the deployment using Windows PowerShell](https://technet.microsoft.com/library/dn531202.aspx)  
  
   ```powershell  
   Add-PSSnapin Microsoft.Crm.PowerShell  
   ```  
  
3. Enter the following [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] commands.  
  
   ```powershell  
  
   $ClaimsSettings = Get-CrmSetting -SettingType OAuthClaimsSettings  
   $ClaimsSettings.Enabled = $true  
   Set-CrmSetting -Setting $ClaimsSettings  
  
   ```  
  
<a name="bkmk_adfs"></a>   
### AD FS server setup  
 To register the external application with [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)], follow these steps.  
  
##### Register the application in Active Directory  
  
1. Log on to the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server as administrator and open a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command window.  
  
2. Enter the following command.  
  
   ```powershell  
   Add-AdfsClient -ClientId <CLIENT_ID> -Name <APP_NAME> -RedirectUri <REDIRECT_URI>  
   ```  
  
    Where <CLIENT_ID> is a unique number, <APP_NAME> is a name for the application, and <REDIRECT_URI> is any valid URI that [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] is to redirect to after authentication has completed. It is recommended that the client ID be a GUID. You can generate a GUID in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] by opening the **Tools** menu and clicking **Create GUID**.  
  
### See also  
 [Adding, Updating, and Removing an Application](https://msdn.microsoft.com/library/dn132599.aspx)   
 [Authenticate Users with Dynamics 365 Customer Engagement (on-premises)](authenticate-users.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]