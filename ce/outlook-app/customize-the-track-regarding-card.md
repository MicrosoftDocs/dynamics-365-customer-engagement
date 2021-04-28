---
title: "Customize the track regarding contact card in Dynamics 365 App for Outlook (Dynamics 365 apps) | MicrosoftDocs"
ms.custom:
description: How to modify the App for Outlook Contact Card form.
ms.date: 04/28/2021
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
# Customize the track regarding contact card 

An app maker can modify the contact card a user sees when they track an email or appointment using [**Set Regarding**](user/track-message-or-appointment.md). 

To modify the contact card an app maker, needs to modify the **App for Outlook Contact Card** form.

In the example below, the **App for Outlook Contact Card** form has three columns titled **Job Title**, **Business Phone**, and **Mobile Phone**. These are the same columns that a user sees on the contact card.

   > [!div class="mx-imgBorder"]
   > ![Contact card example](media/sample-contact-card-columns.png)

If you wanted to modify the **Mobile Phone** column and replace it with the **Company Name** column, then you need to update the **App for Outlook Contact Card** and update the columns that appear.

   > [!div class="mx-imgBorder"]
   > ![Contact card before customization](media/before-cust.png)

To modify columns that appear on the contact card, follow these steps:

1. Sign in to [Power Apps](https://make.powerapps.com).

 
2. On the left nav, select **Data** to expand it and then select **Tables**.  

   > [!div class="mx-imgBorder"]
   > ![Go to Tables in maker portal](media/maker-data-tables.png)
   
  
3. Select a table such as **Contact** and then select the **Forms** tab.

   > [!div class="mx-imgBorder"]
   > ![Select the forms tab](media/maker-form-tab.png)

4. Select the **App for Outlook Contact Card** form.

   > [!div class="mx-imgBorder"]
   > ![Select the App for Outlook Contact Card form](media/maker-outlook-contact-card.png)

5. Drag **Company Name** above **Mobile Phone**. It's important to note, that only the first three columns appear in the track regarding contact card. Although, a related sub-grid can be added to the quick view form, but it doesn't render within the **Track Regarding** contact card.


   > [!div class="mx-imgBorder"]
   > ![Edit the form and drag company name above mobile phone](media/maker-edit-contact-form.png)


7. Select **Save** > **Publish** and then close the form editor.
8. On the solutions page, select **Publish All Customizations** and then close the solutions page.

   > [!div class="mx-imgBorder"]
   > ![Publish customizations](media/maker-publish-customizations.png)


After completing the above, right-click in the track regarding card, and then choose **Refresh**. It will take a few minutes for the synchronization to complete and the changes to appear. Once synchronization is complete, the company name now appears at the bottom instead of the mobile phone number.

   > [!div class="mx-imgBorder"]
   > ![Contact row after customization](media/after-cust.png)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
