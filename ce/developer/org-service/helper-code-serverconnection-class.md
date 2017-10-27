---
title: "Helper code: ServerConnection class (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The ServerConnection class demonstrates how to establish a connection to the Dynamics 365 web services for the purpose of invoking web methods"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 84056850-972d-4209-a293-acd5a5503fbf
caps.latest.revision: 41
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Helper code: ServerConnection class
The primary purpose of the `ServerConnection` class is to show how to connect to the [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement web services to invoke web methods. In addition, applications must typically perform other tasks such as obtaining server and organization information, obtaining user login credentials, creating a service proxy, and refreshing the WCF connection security token. The `ServerConnection` class provides this needed functionality.  
  
> [!CAUTION]
>  The `ServerConnection` class is used by most samples that ship with the [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)]. The class is updated periodically with new functionality. Do not simply reuse the helper code for authentication in your applications. It is code that the [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)] uses to provide the optimum experience when you run our Console application samples included in the SDK. It contains all the key elements of authentication and demonstrates their use, but it may not represent the best solution for your application. It is sample code that you can use as a basis for designing an authentication management system that fits the requirements of your application. Refer to the topic [Use connection strings in XRM tooling to connect to Dynamics 365](../xrm-tooling/use-connection-strings-xrm-tooling-connect.md) for an alternate method for authenticating with the web services.  
  
 The file is present in code samples' folder that you download.
 
 Path: ```<download-directory>\<sample name>\C#\CrmServiceHelpers.cs```.
 
 For example, if you download the **Work with attribute metadata** sample to D drive, you can find the sample in the following folder path.

 Path: ```D:\Work with attribute metadata\CrmServiceHelpers.cs```
  
 Use the class source code in the CrmServiceHelpers files as a basis for your own classes or use the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> class for just the basic functionality of setting up a service connection.  
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 The `ServerConnection` class demonstrates how to establish a connection to the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] web services for the purpose of invoking web methods. Before a connection can be created, information about the server, organization, and user must first be obtained. This information is gathered in either of two ways: by interactively prompting the user in the console window, or by loading saved server configuration information from the local disk. The server connection information is persisted to a file named Credentials.xml located at `C:\Users\<username>\AppData\Roaming\CrmServer`.  
  
 For each server configuration saved in the Credentials.xml file, the user’s logon password is stored as a generic credential in the Windows Credential Manager. The credential naming format is Microsoft_CRMSDK:\<*server*>:\<*organization*>:\<*userID*>.  
  
 Useful code for authentication can be found in the `GetProxy` and `GetOrganizationProxy` methods. Also, the code that creates and reads a user’s password in the [!INCLUDE[pn_Windows_Credential_Manager](../../includes/pn-windows-credential-manager.md)] may be of interest.  
  
## Example  
 [!code-csharp[HelperCode#crmservicehelper](../../snippets/csharp/CRMV8/helpercode/cs/crmservicehelper.cs#crmservicehelper)]  
  
 [!code-vb[HelperCodeVB#crmservicehelper](../../snippets/visualbasic/CRMV8/helpercodevb/vb/crmservicehelper.vb#crmservicehelper)]  
  
### See also  
 [Use the Sample and Helper Code](use-sample-helper-code.md)  
 [Sample: Quick start for Dynamics 365 Customer Engagement](../sample-quick-start.md)   
 [Access the Web Services in Dynamics 365](../authenticate-users.md)
