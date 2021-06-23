---
title: "Microsoft 365 Groups in Dynamics 365 for Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 3f170665-f0eb-4af7-a177-67bce539419f
caps.latest.revision: 15
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser

---
# Microsoft 365 Groups in Dynamics 365 Customer Engagement (on-premises) FAQs

The following are frequently asked questions and known issues for [!INCLUDE[pn_office_365_groups](../includes/pn-office-365-groups.md)].  
  
## Where is the Microsoft 365 Groups data stored?  
 The [!INCLUDE[pn_office_365_groups](../includes/pn-office-365-groups.md)] data is stored in [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)], not [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
## Why can't I create Microsoft 365 Groups using bulk import?  
 [!INCLUDE[pn_office_365_groups](../includes/pn-office-365-groups.md)] will only be automatically created if your system administrator has turned on auto-create for the record type that you're attempting to bulk import. In addition, to ensure performance and stability for others, [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] won't create groups if you try to import a large number of records at once. We recommend a maximum of 20 records at a time if you need groups to be auto-created. If you import more than this, we can't guarantee that a group is created. If a group wasn't created due to a large bulk-import, you can manually create a group by navigating to that record's groups page.  
  
## Why don't I see all of my group's meetings in Dynamics 365 Customer Engagement (on-premises)?  
 At this time we're unable to show meetings that someone from outside of your company has set up and has invited your group to attend. We are working on a solution to this issue, but in the meantime you can use the **Open Calendar** link to check your group's calendar in [!INCLUDE[pn_microsoft_outlook_web_app](../includes/pn-microsoft-outlook-web-app.md)] (Outlook Online).  
  
## Why do I get a RetrieveOfficeSettings: 1 error when I navigate to the Microsoft 365 Groups page?  
 This is a known issue. Refresh the page and the error message will go away.  
  
## Why do I get a (500) Internal Server Error when I navigate to the Microsoft 365 Groups page?  
 This is a generic error which could have multiple causes. One common case is that the user who is attempting to view the group doesn't have a valid [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] license.  
  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]