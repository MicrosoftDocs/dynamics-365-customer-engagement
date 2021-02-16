---
title: "Dynamics 365 App for Outlook Overview (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
ms.date: 12/16/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Overview of Dynamics 365 App for Outlook

Use [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] to tap the power of Dynamics 365 apps while you’re using [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] on the desktop, web, or phone. When [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] is installed, depending on which version of  the app you have installed, you'll see a Dynamics 365 apps pane or window next to a selected [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] email message, or when you're composing an email message or setting up a meeting or appointment.

> [!IMPORTANT]
> The latest release of [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] works with customer engagement apps in Dynamics 365 (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation), [Dynamics 365 Customer Engagement (on-premises), version 9](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/overview), and [Microsoft Dataverse](https://docs.microsoft.com/powerapps/maker/common-data-service/data-platform-intro).

For more information on how to deploy and customize the app and how to use it, see:

-   [Deploy Dynamics 365 App for Outlook](deploy-dynamics-365-app-for-outlook.md)
  
-   [Customize Dynamics 365 App for Outlook](customize-the-track-regarding-card.md) 

-   [Dynamics 365 App for Outlook User Guide](dynamics-365-app-outlook-user-s-guide.md)


## What Dynamics 365 App for Outlook offers  
 With [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], you can:  
  
- View information about Dynamics 365 contacts and leads while you’re working in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)]. You can view this info in the context of an email message, meeting, or appointment. For example, view phone numbers, company name, last and next activities, and recent records from Dynamics 365.  
  
- Link email messages, meetings, and appointments to a Dynamics 365 record with a single click. For example, link an email message to a specific account, opportunity, or case. [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] also supports custom entities.  
  
- Open Dynamics 365 records directly to find or enter more detailed information.  
  
- Add a phone call, task, or appointment activity to Dynamics 365.  
  
- Create a new Dynamics 365 record for any entity (record type).  
  
- Add email templates, knowledge articles, and sales literature when you create an email message or set up a meeting.  
  
- Track [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] contacts in Dynamics 365.  


## What's new in Dynamics 365 App for Outlook

Dynamics 365 apps that work with Dynamics 365 App for Outlook have been significantly redesigned and includes enhancements such as:

- Unified Interface. [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] is built on the Unified Interface framework, which uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation. Much of Dynamics 365 functionality is now included.
- Global search or multi-entity search. Use global search to search for a keyword in multiple entities at the same time. Global search uses the quick find view for the various entities to search for records.
- Forms. View and edit forms the same as what you see in the mobile experience. 
- Dashboards. View and edit dashboards the same as what you see in the mobile experience.
- Insights. Use Relationship assistant to get insights into your customers.

For more information on what's new, see [What's new with Dynamics 365 App for Outlook](whats-new.md).


## Known issues and FAQs

### Dynamics 365 App for Outlook add-in error

Some users might experience add-in error with the following symptoms:

You try to use the add-in by selecting Dynamics 365 App for Outlook, and the pane appears. After about 30 seconds, a yellow error section is displayed at the at the top of
    the pane. The error could be any of the following:

- ADD-IN ERROR This add-in could not be started. Close this dialog
        to ignore the problem or click "Restart" to try again.

- ADD-IN ERROR This add-in is not responding. Close this warning
        dialog to keep it running or click "Restart" to try again.

- ADD-IN ERROR This add-in seems to be having problems. Click
        "Restart" to try starting it again.

- ADD-IN ERROR Sorry, we had to rest because this add-in wasn't
        responding.

Sometimes, selecting **Restart** causes the error again.

**Solutions**

Here are some of the ways in which you can address this issue:

-  Add/update the below registry keys for the users experiencing the
    add-in error.

    - **\[**HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Microsoft\\Office\\16.0\\Wef**\]  
 **AlertInterval**=dword:00000000**

    - **\[**HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Office\\16.0\\Wef**\]  
 **AlertInterval**=dword:00000000**

    Additional information on the registry keys can be found
[When debugging with the Microsoft Edge DevTools, the add-in crashes or reloads](https://docs.microsoft.com/office/dev/add-ins/concepts/browsers-used-by-office-web-add-ins#when-debugging-with-the-microsoft-edge-devtools-the-add-in-crashes-or-reloads).

    If the registry key doesn't work, one of the below are the only solutions for the add-in error.

-  Users experiencing add-in error can use Outlook Web App in Microsoft
    Edge or Google Chrome browsers to access Dynamics 365 App for
    Outlook.

-  Alternatively, users can update their Outlook client to the latest
    CR2 monthly enterprise channel or current channel.

### Users with custom security role can't access Dynamics 365 App for Outlook
Users who are assigned a custom security role may not be able to access [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)]. We are working on a fix for this issue. In the meantime, for more information, see:
 - [Support article](https://support.microsoft.com/help/4078135/sorry-something-went-wrong-while-initializing-the-app-when-accessing-t)
 - [Configure Outlook or Exchange folder-level tracking](https://docs.microsoft.com/power-platform/admin/configure-outlook-exchange-folder-level-tracking)
 - [Set an option to automatically track incoming Outlook email in Dynamics 365 for Outlook](https://docs.microsoft.com/dynamics365/outlook-addin/user-guide/set-option-automatically-track-incoming-outlook-email)

### Delegated users cannot track emails
Delegated users cannot track emails using [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)]. Try using folder-level tracking or automatic tracking for delegated users.  

### Other known issues
For other known issues with this version of [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], see the [Dynamics 365 apps Readme](../admin/readme-9.md). 

For more information on FAQs, see [Frequently Asked Questions about Dynamics 365 App for Outlook](faq.md).


### See also
[Deploy Dynamics 365 App for Outlook](deploy-dynamics-365-app-for-outlook.md)<br />
[Dynamics 365 App for Outlook User Guide](dynamics-365-app-outlook-user-s-guide.md)


 


[!INCLUDE[footer-include](../includes/footer-banner.md)]