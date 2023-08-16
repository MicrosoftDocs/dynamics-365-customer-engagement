---
title: "Operating Dynamics 365 Customer Engagement (on-premises) (on-premises), version 9.x | Microsoft Docs"
description: Learn how to operate Dynamics 365 Customer Engagement (on-premises)
ms.custom: 
ms.date: 08/14/2023
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 605bb886-116a-4275-83fe-e9fdc83d2f2f
caps.latest.revision: 24
author: Mattp123
ms.author: matp
---
# Operating Dynamics 365 Customer Engagement (on-premises) (on-premises)

As you administer [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you’ll want to guarantee availability for your users by monitoring server status and performance, troubleshooting issues, and planning for disaster recovery.  
  
 Ongoing maintenance of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] includes operations such as updating, customizing, monitoring, and relocating or reconfiguring [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and required or optional technologies such as [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] and [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)].  
  
> [!CAUTION]
>  Operations that require intensive database transactions cannot be run concurrently. This includes the following operations:  
>   
> -   Language pack provisioning  
> -   Importing a solution  
> -   Publishing customizations  
> -   Database updates ([!INCLUDE[pn_crm_op_edition](../includes/pn-crm-op-edition.md)] only)  
> -   Solution update operations ([!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] only)  

::: moniker range="op-9-1"

## Known issues operating Dynamics 365 Customer Engagement (on-premises)

### Plugin failure or Dynamics 365 API call to sandbox service failure

If there is a plugin failure on a plugin registered on [sandbox mode](../developer/register-deploy-plugins.md),  the following exception might be logged:

    Message: System.ServiceModel.Security.SecurityNegotiationException: A call to SSPI failed, see inner exception. ---> System.Security.Authentication.AuthenticationException: A call to SSPI failed, see inner exception. ---> System.ComponentModel.Win32Exception: The target principal name is incorrect
   --- End of inner exception stack trace ---
   at System.Net.Security.NegoState.StartSendAuthResetSignal(LazyAsyncResult lazyResult, Byte[] message, Exception exception)
   at System.Net.Security.NegoState.StartSendBlob(Byte[] message, LazyAsyncResult lazyResult)

Event Viewer might record this event when the issue occurs:

    The Kerberos client received a KRB_AP_ERR_MODIFIED error from the server SVC.[REDACTED - Sandbox Service Account]. The target name used was host/[REDACTED Destination Server]. This indicates that the target server failed to decrypt the ticket provided by the client. This can occur when the target server principal name (SPN) is registered on an account other than the account the target service is using. Ensure that the target SPN is only registered on the account used by the server. This error can also happen if the target service account password is different than what is configured on the Kerberos Key Distribution Center for that target service. Ensure that the service on the server and the KDC are both configured to use the same password. If the server name isn't fully qualified, and the target domain ([REDACTED CX DOMAIN]) is different from the client domain ([REDACTED CX DOMAIN]), check if there are identically named server accounts in these two domains, or use the fully qualified name to identify the server

This issue occurs when there are two or more Windows servers running the Dynamics 365 Customer Engagement full server role in the deployment. This issue only occurs with Dynamics 365 Customer Engagement (on-premises), version 9.1.

To work around this issue, do one of the following.

- Split full server roles (recommended):
   - If you have multiple servers running the full server role deployed in a server farm, separate the roles by deploying as front end and back end within the farm. More information: [Install Dynamics 365 Server Front End Server and Back End Server roles](install-dynamics-365-front-back-end-server-roles.md)
- Configure the following service accounts to use the same password (not recommended):
     - IIS application pool identity account(w3wp)
     - Asynchronous Processing Service account

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
