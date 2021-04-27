---
title: "Customize the track regarding card in Dynamics 365 App for Outlook (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
ms.date: 01/09/2018
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
# Customize the track regarding card 

As an admin, you may want to change the form a user see when they track an email or appointment using [**Track without Regarding**](user/track-without-set-regarding.md) or [**Set Regarding**](user/track-message-or-appointment.md). For example, you might want to replace  **Mobile Phone** with **Company Name** on the contact card.

To change the fields that appear, follow these steps:

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

5. Drag **Company Name** above **Mobile Phone**.


   > [!div class="mx-imgBorder"]
   > ![Edit the form and drag company name above mobile phone](media/maker-edit-contact-form.png)

  > [!NOTE]
  > Only the first three fields appear in the track regarding card. Although, a related sub-grid can be added to the quick view form, but it doesn't render within the **Track Regarding** card.

7. Select **Save** > **Publish** and then close the form editor.
8. On the solution page, **Publish All Customizations** and then close the solutions page.

   > [!div class="mx-imgBorder"]
   > ![Publish customizations](media/maker-publish-customizations.png)



















![Initial contact card](media/initial-contact-card.png "Initial contact card")

To change the fields that appear, follow these steps:

1. In your app, go to **Settings** > **Customizations** > **Customize the System**.
2. Expand **Entities** and choose an entity such as **Contact**.
3. Expand the entity and select **Forms**, then select the **App for Outlook Contact Card** form.

   ![Contact entity form](media/contact-entity-form.png)

4. Drag **Company Name** above **Business Phone**.

   ![Drag field in form](media/drag-fields-in-form.png "Drag field in form")

   ![After dragging field](media/after-dragging-fields.png "After dragging field")

   > [!NOTE]
   > The first three fields appear in the track regarding card.

5. Select **Save**, **Publish**, and then close the form editor.
6. On the solution page, **Publish All Customizations**. 
7. Close the solutions page.

After completing the above, right-click in the track regarding card, and then choose **Reload**. It will take a few minutes for the synchronization to complete and the change to appear.

![After customizing card](media/after-customizing-card.png "After customizing card")</br>
The company name now appears after the contact name in the Contact card.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
