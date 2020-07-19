---
title: "OneNote in Dynamics 365 Customer Engagement (on-premises)FAQs (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0a4e298a-868c-4b58-8f47-696090533b3b
caps.latest.revision: 14
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser

---
# OneNote in Dynamics 365 Customer Engagement (on-premises) FAQs

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Take notes by using OneNote](/powerapps/user/onenote)

## Why do OneNote files show a folder icon?  
 This is a known issue. Select the file name to open the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] as expected.  
  
## Why aren't my OneNote notebooks showing up in the OneDrive documents area?  
 [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebooks saved to the [!INCLUDE[pn_office_365_groups](../includes/pn-office-365-groups.md)] OneDrive won't be shown in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
## Error message: We can't find the notebook
I get this error message:
 
    We can't find the notebook. The [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook might have been removed or moved to another location. Check the notebook location or contact your administrator to update the location record stored in Dynamics 365 Customer Engagement (on-premises). (Error: 0x80060729)  
  
1. To fix the issue, go to **Settings** > **Document Management** > **Document Location Records**.  
  
2. Go to the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] view and search for the document location record that is regarding your account.  
  
3. Open that document location record, and then change the corresponding URL to match your notebook location.  
  
## Can I edit a OneNote file from with Dynamics 365 Customer Engagement (on-premises)?  
 No. This can be done only from the OneNote app that opens when you select the OneNote link.  
  
## I can't access my Dynamics 365 Customer Engagement (on-premises) OneNote notebook.  
 Don't delete any [!INCLUDE[pn_onenote](../includes/pn-onenote.md)].onetoc2 or .one file types in the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] section in Dynamics 365 Customer Engagement (on-premises). If you do, you won't be able to access your Dynamics 365 Customer Engagement (on-premises) OneNote notebook.  
  
## Are section groups supported in Dynamics 365 Customer Engagement (on-premises)?  
 Sections groups that keep related sections together in OneNote aren't supported in Dynamics 365 Customer Engagement (on-premises).  
  
## Can I rename a section in OneNote Online?  
 No. You can only rename a section in the desktop version of [!INCLUDE[pn_onenote](../includes/pn-onenote.md)]. If you rename a section in [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] Online, you won't see the updated section name in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
## Why do I see records that should be in the OneNote tab?  
 This happens if you deleted all of the sections in the notebook. It's recommended that you have at least one section in your [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook. To fix the issue do this:  
  
1. Go to the record where you see the issue. For example, from the main menu select, **Sales** > **Accounts** > select an account record.  
  
2. From the main menu select the drop down menu next to the record name, and then select **Documents**.  
  
3. Select **Open in SharePoint** and then create a new section using the desktop version of [!INCLUDE[pn_onenote](../includes/pn-onenote.md)].  
  
## Error message: File cannot be found
I get this error message: 

    File cannot be found. (Error: 0x80060706)  

In an on-premises deployment, you can get this error when opening the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] tab in an entity enabled for [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] if you turned off **CreateSPFoldersUsingNameandGuid** using the OrgDBOrgSettings tool.  Set this option to **True**. See: [OrgDBOrgSettings tool for Dynamics CRM](https://support.microsoft.com/kb/2691237).  

Note that [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] requires [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] folders to include the GUID.  

## I get this error message: List does not support this operation. (Error: 0x80060715)  

On subsequent clicks in [!INCLUDE[pn_onenote](../includes/pn-onenote.md)], this error message appears: **No sections to display. Note that sections in a section group aren't supported.** To fix this issue, set the file path length to less than 70 characters.  

## Changing the name of a OneNote file in [!INCLUDE[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)] can create a conflict

Consider this scenario:

User A opens a OneNote note in Dynamics 365 Customer Engagement (on-premises) and adds content (For example: **Sales** > **Accounts** > <account> > **Summary** > Timeline section > **+** > OneNote). User A, or a second user, User B, changes the name of the OneNote file in a document grid (For example: **Sales** > **Accounts** > <account> > **Related** > **Documents**). User A opens the note using Timeline (For example: **Sales** > **Accounts** > <account> > **Summary** > Timeline section > **+** > **OneNote**). User A should see the renamed note with the existing content. Instead, a new note is opened.


