---
title: "Best practices for server-side sync in Dynamics 365 Customer Engagement (on-premises)"
description: "Consider the following best practices when planning and deploying server-side synchronization in Dynamics 365 Customer Engagement (on-premises)."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: eccee121-cfad-4195-8fbf-681ea2595635
caps.latest.revision: 24
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin

---
# Best practices for server-side synchronization 

Consider the following when planning and deploying server-side synchronization.  
  
## Best practices for configuring server-side synchronization  
  
<a name="BKMK_OneAccount"></a>   

### If you want to use one set of credentials to process emails with Outlook or Exchange  
 Using one account to process email to all mailboxes is easier to maintain but requires using an account that has access to all mailboxes in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]. The account must have impersonation rights on [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]. If that single account is compromised, all mailboxes using that account are compromised. Use the following settings in your email server profile (**Settings** > **Email Configuration** > **Email Server Profiles** to use a single account for email processing.  
  
|Settings|Recommendation|  
|--------------|--------------------|  
|**Incoming Connection**||  
|Authenticate Using|Credentials Specified in Email Server Profile|  
|User Name|The administrator’s user name|  
|Password|The administrator’s password|  
|Use Impersonation|Yes|  
|Use same settings for Outgoing|Yes|  
  
 Delegation (Use Impersonation = No) is not supported for syncing Appointments, Contacts, and Tasks.  
  
<a name="BKMK_EachUser"></a>   
### If you want to use individual credentials to process emails with Outlook or Exchange  
 An alternative to a single account to process emails is using individual accounts. This method requires more maintenance effort but does not focus security on a single account. If you want each user account to synchronize with [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] and you’re not using the [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)] email server profile, use the following settings (**Settings** > **Email Configuration** > **Email Server Profiles**).  
  
|Settings|Recommendation|  
|--------------|--------------------|  
|**Incoming Connection**||  
|Authenticate Using|Credentials Specified by a User or Queue|  
|Use Impersonation|No|  
|Use same settings for Outgoing|Yes|  
  
 Set the following in each user mailbox.  
  
|Settings|Recommendation|  
|--------------|--------------------|  
|**Credentials**||  
|Allow to Use Credentials for Email Processing|Yes|  
|User Name|The user name for the mailbox|  
|Password|The password for the mailbox|  
  
### See also  
[Server-side synchronization](../admin/server-side-synchronization.md) 
[Troubleshooting server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
