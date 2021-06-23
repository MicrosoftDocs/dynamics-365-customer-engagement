---
title: "Configure Exchange folder-level tracking rules (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn how to configure Exchange folder-level tracking rules"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 4cd28905-1af7-42aa-a9d8-27c271dfcb8c
caps.latest.revision: 17
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Configure Exchange folder-level tracking rules

Configure folder-level tracking rules to map a [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] inbox folder to a Dynamics 365 Customer Engagement (on-premises) record so that all the emails in the [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder get automatically tracked against the mapped record in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Folder-level tracking of emails will work only if:  

- The folder-level tracking feature is enabled for your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance. You can enable folder-level tracking by using the web client or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure folder-level tracking](../admin/configure-outlook-exchange-folder-level-tracking.md)  

- The folder that you are tracking is under the **Inbox** folder in [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]. Emails in the folders that are not under the **Inbox** folder won’t be tracked.  

<a name="Create"></a>   
## Create and manage folder-level tracking rules  
 Use the [MailboxTrackingFolder Entity](entities/mailboxtrackingfolder.md) to programmatically configure and manage your folder-level tracking rules. To set up a tracking rule, use the following attributes.  


|                                   Attribute                                   |                                                                                                                                                                                                                Description                                                                                                                                                                                                                 |
|-------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  [ExchangeFolderId](entities/mailboxtrackingfolder.md#BKMK_ExchangeFolderId)  | Specify the [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder ID that you want to map. You can use the [!INCLUDE[pn_Exchange_Web_Services_EWS](../includes/pn-exchange-web-services-ews.md)] to retrieve the ID of a folder under your Inbox folder. For more information, see [MSDN: How to: Work with folders by using EWS in Exchange](/exchange/client-developer/exchange-web-services/how-to-work-with-folders-by-using-ews-in-exchange). This is a required attribute. |
|         [MailboxId](entities/mailboxtrackingfolder.md#BKMK_MailboxId)         |                                                                                                                                         Specify the mailbox ID in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] that you want to create the rule for. This is a required attribute.                                                                                                                                          |
| [RegardingObjectId](entities/mailboxtrackingfolder.md#BKMK_RegardingObjectId) |                                                                                                       Set the regarding object in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] that you want the specified [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder to be mapped to. This is an optional attribute.                                                                                                       |

 The following sample code shows how you can create a folder-level tracking rule.  

```csharp  
// Create a folder-level tracking rule  
MailboxTrackingFolder newTrackingFolder = new MailboxTrackingFolder();  

// Set the required attributes  
newTrackingFolder.ExchangeFolderId = "123456"; // Sample value. Retrieve this value using Exchange Web Services (EWS)  
newTrackingFolder.MailboxId = new EntityReference(Mailbox.EntityLogicalName, _mailboxId);  

// Set the optional attributes  
newTrackingFolder.RegardingObjectId = new EntityReference(Account.EntityLogicalName, _accountId);  
newTrackingFolder.RegardingObjectId.Name = _accountName;  
newTrackingFolder.ExchangeFolderName = "Sample Exchange Folder";  

// Execute the request to create the rule   
_folderTrackingId = _serviceProxy.Create(newTrackingFolder);  
Console.WriteLine("Created folder-level tracking rule for '{0}'.\n", _mailboxName);  
```  

 You can create a maximum of 25 folder-level tracking rules per mailbox. The folder ID of the [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder can’t be validated at the time of creating the mapping using SDK. However, as soon as you create a mapping rule, and if the folder ID is invalid, it will show up in the UI in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to indicate that the mapping is invalid.  

 Any manual changes done to the regarding object in the tracked activity records, created in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] as a result of the folder-level tracking rule, will be overridden the next time server-side synchronization occurs. For example, if you have set up a mapping between the `Adventure Works` folder and the `Adventure Works` account, all the emails in the `Adventure Works`[!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder will be tracked as activities in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] with the regarding set to the `Adventure Works` account record. If you change the regarding of some activities to any other record, it will automatically be overridden the next time server-side synchronization occurs.  

<a name="Retrieve"></a>   
## Retrieve folder-level tracking rules for a mailbox  
 You can retrieve all the folder-level tracking rules for a mailbox by using the <xref:Microsoft.Crm.Sdk.Messages.RetrieveMailboxTrackingFoldersRequest> message. Pass the mailbox ID for which you want to retrieve the rules in the <xref:Microsoft.Crm.Sdk.Messages.RetrieveMailboxTrackingFoldersRequest>.<xref:Microsoft.Crm.Sdk.Messages.RetrieveMailboxTrackingFoldersRequest.MailboxId> property, and execute the message.  

 The following sample code shows how you can retrieve folder-level tracking rules for a mailbox.  

```csharp  
// Retrieve the folder mapping rules for a mailbox  
RetrieveMailboxTrackingFoldersRequest req = new RetrieveMailboxTrackingFoldersRequest  
{  
    MailboxId = _mailboxId.ToString()  
};  

RetrieveMailboxTrackingFoldersResponse resp = (RetrieveMailboxTrackingFoldersResponse_serviceProxy.Execute(req);  
Console.WriteLine("Retrieved folder-level tracking rules for {0}:", _mailboxName);  
int n = 1;  
foreach (var folderMapping in resp.MailboxTrackingFolderMappings)  
{  
    Console.WriteLine("\tRule {0}: '{1}' is mapped to '{2}'.",   
        n, folderMapping.ExchangeFolderName, folderMapping.RegardingObjectName);  
    n++;  
}  
```  

### See also  
 <xref href="Microsoft.Dynamics.CRM.RetrieveMailboxTrackingFolders?text=RetrieveMailboxTrackingFolders Function" /><br />
 [MailboxTrackingFolder Entity](entities/mailboxtrackingfolder.md)<br />
 [Mailbox Entity](entities/mailbox.md)<br />
 [Configure folder-level tracking](../admin/configure-outlook-exchange-folder-level-tracking.md)<br />
 [Server-side Synchronization Entities](server-side-synchronization-entities.md)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]