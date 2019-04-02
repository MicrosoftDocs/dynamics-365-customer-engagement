---
title: "View the profile card for a contact or user (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 04/02/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: dd02756b-f2ec-40d8-8b46-3d164b7a9fc7
caps.latest.revision: 01
author: mkaur
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# View the profile card for a contact or user

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use the profile card to get quick information about a contact or user. When you select a contact or user field in Dynamics 365 for Customer Engagement apps, you can find information related to them on their profile card. For more information about profile cards, see [Profile cards in Office 365](https://support.office.com/en-us/article/Profile-cards-in-Office-365-e80f931f-5fc4-4a59-ba6e-c1e35a85b501).

> [!NOTE]
>  - The profile card experience is available in the Unified Interface of Dynamics 365 Customer Engagemnt apps.
>  - It is available for the  **Contact** and **User** entity. For information, see [Enable the profile card (for admins)](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/enable-profile-card).

## View a contact's profile

1.	Navigate to **Sales Hub** > **Activities**.
2.	Select an existing activity or create a new one.
3.	Hover over the **Call To** field when it has a contact record. 

 > [!div class="mx-imgBorder"]
 > ![Call To field](media/callto.png "Call to field")

You can view details of the contact inline which includes the contact picture, name, title and account.

4. To view more details, select **Show more** to expand the contact's profile.

 > [!div class="mx-imgBorder"]
 > ![View profile card details](media/Viewprofilecard.png "View profile card details")
   
 ## View a user's profile
 
1.	Navigate to **Sales Hub** > **Accounts**.
2.	Select an account record.
3.	Hover over the owner field when it has a user record. You can view the details of the user inline.

 > [!div class="mx-imgBorder"]
 > ![View profile card details for a user](media/Userprofilecard.png "View profile card details for a user")
 
 4.	To view more details like emails and shared files with the user, select **Show more** to expand the contact's profile.
 
  > [!div class="mx-imgBorder"]
 > ![Expand profile card detail](media/expandprofilecard.png "Expand profile card details")
 
 ## FAQs
 
### Where can I see profile cards in Dynamics 365?
Profile cards in Dynamics 365 can be seen in Unified Interface on contact and user records. You only view them when they are in a lookup currently.

### Where is information shown in the Profile card coming from?
The information shown on the contact Profile card is fetched from Common Data Service (and not Microsoft Exchange). So, the contact details are coming from Dynamics 365.

The information shown on the user Profile card is fetched from Office 365 (Azure Active Dictory). For more information, see [Profile cards in Office 365 (admin section)](https://support.office.com/en-us/article/Profile-cards-in-Office-365-e80f931f-5fc4-4a59-ba6e-c1e35a85b501).

### How can I customize the fields shown on the profile card?
Currently, the list of fields displayed on the profile card are not open for customization.

### Why is the **Start chat** option on the Profile card disabled (greyed out)?
The ‘Start chat’ and the ‘Send Email’ options on the Profile card will open your default IM and email apps, respectively. ‘Start chat’ option is enabled if the person you are trying to contact in the same Azure AD environment as you or in a federated one.

### Can I see profile cards in Dynamics 365 on the tablet app?
Profile cards in Dynamics 365 are only enabled for browsers on a desktop/PC currently, as they are activated on hover.

### What will happen to the Skype presence integration in Unified Interface?
When you have enabled both Skype presence and the Profile card integration in Dynamics 365, you will see the Profile card displayed in a lookup. All other areas referencing Skype card integration will not be affected.

 
 
 
