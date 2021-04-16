---
title: "Track your Outlook contacts using App for Outlook (Dynamics 365 apps) | MicrosoftDocs"
description: Track your Outlook contacts using App for Outlook.
ms.custom: 
ms.date: 04/15/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
caps.latest.revision: 1
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

# Track contacts

Access your Outlook contacts and Dynamics 365 contacts and see which contacts are tracked. You can also link a Outlook contact to an account in your Dynamics 365 app.

To use this add-in option your admin must enable your Dynamics 365 mailbox for appointments, contacts, and tasks.


   > [!div class="mx-imgBorder"] 
   > ![Select add-in](../media/all-contacts.png)  
 
Legend
1. **Outlook Contacts**: View all your Outlook contacts. The same contacts are displayed in the default contacts view your Dynamics 365 app.
2. **Dynamics 365 Contacts**: View all your Dynamics 365 app contacts.
3. **Tracked**: See whether a contact is tracked or not, or whether the tracking status is pending.
4. **Company**: If the contact is tracked, select to open the row in your app.


## Access contacts

To access your contacts, from the Outlook navigation pane, select More ![Outlook navigation options](../media/outlook-nav-options.png) and then select **Add-ins**.

   > [!div class="mx-imgBorder"] 
   > ![Select add-in](../media/access-add-in.png)  


### View contact card

In the contacts list, select **Dynamics 365 Contacts** and then select the checkbox next to a contact's name. The contact details appear on the right side of the screen.

   > [!div class="mx-imgBorder"] 
   > ![View contact details](../media/view-contact-details.png)  


## Link Outlook contacts to an account 

You can link and track a single or multiple contacts from Outlook to a account row in your Dynamics 365 app. 

   > [!div class="mx-imgBorder"] 
   > ![Demo of how to link a Outlook contact to a row in your app.](../media/link-outlook-contact-3.gif) 

Depending on the server-side synchronization filters, the active contacts which a user owns in the Dynamics 365 app should be synchronized with Outlook after the mailbox is configured. For more information, see [Choose the records to synchronize between customer engagement apps and Exchange](/power-platform/admin/choose-records-synchronize-dynamics-365-outlook-exchange.md),

Follow the steps below to link and track your Outlook contacts to a row in your app.

1. From **Outlook Contacts**, select a contact(s) that is not already tracked.
2. On the command bar, select **Link**.
 
   > [!div class="mx-imgBorder"] 
   > ![Link an Outlook contact](../media/link-outlook-contact.png) 
 
3. Chosse the account row that you want to link the contact(s) with and then select elect **Link**.

   > [!div class="mx-imgBorder"] 
   > ![Choose a contact in your app to link to](../media/link-outlook-contact-2.png) 

4.  To avoid issues, until the linking is complete before you navigate away from the page. 

## Track Outlook contacts without linking to an account

You can track a single or multiple contacts from Outlook in your Dynamics 365 app without linking it to an account row.

1. From **Outlook Contacts**, select a contact(s) that is not already tracked.
2. On the command bar, select **Track**.

   > [!div class="mx-imgBorder"] 
   > ![Demo of how to track a Outlook contact in your app.](../media/track-without-linking.gif) 
   
3. To avoid issues, until the tracking is complete before you navigate away from the page. 

## Untrack a contact

You can also untrack a contact and choose to delete the contact's information from your Dynamics 365 app or keep the record by stop tracking it.

1. From **Outlook Contacts**, select a contact(s) that you want to stop tracking
2. On the command bar, select **Untrack**.
3. Then select one of the following:
    - **Untrack & Delete**: Delete the contact record from your app.
    - **Untrack & Keep**: Kepp the contact record in your app but stop tracking it.

   > [!div class="mx-imgBorder"] 
   > ![Untrack a contact](../media/untrack-contact.png) 
