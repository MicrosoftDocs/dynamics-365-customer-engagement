---
title: "Verify Service Principal Name for Microsoft Dynamics 365 for Customer Engagement service accounts | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 943ca5a3-afdd-4fd4-8462-a0fdcdbd58f9
caps.latest.revision: 10
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Verify Service Principal Name for Microsoft Dynamics 365 for Customer Engagement service accounts
The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] services are described below. For information on permissions for service accounts, see [Minimum permissions required for Microsoft Dynamics CRM Setup and services](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699825(v=crm.8)).  
  
-   **Application Service**. This service runs the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Web application that is used to connect users to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data.  
  
-   **Deployment Web Service**. Manages the deployment by using the methods described in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)], such as create an organization or remove a Deployment Administrator role from a user.  
  
-   **Sandbox Processing Service**. Enables an isolated environment to allow for the execution of custom code, such as plug-ins. This isolated environment reduces the possibility of custom code affecting the operation of the organizations in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
  
-   **Asynchronous Processing Service**. Processes queued asynchronous events, such as bulk e-mail or data import.  
  
-   **Microsoft Dynamics 365 for Customer Engagement VSS Writer Service**. Provides the interface to back up and restore [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases through the Windows Server Volume Shadow Copy Service (VSS) infrastructure.  
  
-   **Microsoft Dynamics 365 for Customer Engagement Monitoring Service**. Provides diagnostic services for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] services.  
  
> [!IMPORTANT]
>  -   We strongly recommend that you select a low-privilege domain account that is dedicated to running these services and is not used for any other purpose. Additionally, the user account that is used to run a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service cannot be a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user. This domain account must be a member of the Domain Users group. Additionally, if the Asynchronous Service and Sandbox Processing Service roles are installed, such as in a Full Server or a Back End Server installation, the domain account must a member of the Performance Log Users security group.  
> -   If you select to run the ASP.NET service under a domain user account that is not a domain administrator or a local administrator, you must set a local security policy after you install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] for the ASP.NET service to work correctly. Also, depending on the password policies that you have implemented for your organization, the password for the user may expire. For more information, see the Microsoft Knowledge Base article 329290, [How to use the ASP.NET utility to encrypt credentials and session state connection strings](https://go.microsoft.com/fwlink/p/?linkid=53266).  
> -   The service account may need an SPN for the URL used to access the Web site that is associated with it.  
  
 You use the setspn.exe command-line tool to read, modify, and delete the Service Principal Names (SPN) directory property for an [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] service account. Setspn is included with [!INCLUDE[pn_ms_Windows_Server_long](../includes/pn-ms-windows-server-long.md)]. Notice that you must have **Validated write to service principal name** permissions to complete operations using setspn. For more information about setspn, see [Setspn](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc731241(v=ws.10)).



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]