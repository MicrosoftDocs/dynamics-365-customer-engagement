---
title: "Add a custom entity to quick create in Dynamics 365 App for Outlook  (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
ms.custom: 
ms.date: 01/09/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps 
  - Dynamics 365 for Customer Engagement apps Version 9.x
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
# Add a custom entity to quick create  

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Follow these steps to enable a custom entity to appear in Quick create.

![Custom entity in Quick create](media/custom-entity-quick-create.png) 

1. In [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], go to **Settings** > **Customizations** > **Customize the System**.
2. Choose the custom entity. Under **Data Services**, enable **Allow quick create**. Under **Outlook & Mobile**, enable **Enable for mobile**.

   ![Enable entity settings for quick create display](media/settings-enabled.png "Enable entity settings for quick create display")
3. Verify the custom entity has a quick create form. Chose **Forms** and browse for form type **Quick Create**. Create a quick create form if needed.

   ![Quick create form](media/quick-create-form.png "Quick create form")
4. Verify the custom entity is added to the app designer. Choose **Apps**, and then open **App for Outlook**.

   ![Apps for Outlook in Apps](media/apps-for-outlook-in-apps.png)
5. In the app designer, choose **Entities** and browse to find your custom entity.

   ![Custom entity in app designer](media/custom-entity-app-designer.png)

## Enable a custom entity to appear in the Regarding lookup

1. In [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], go to **Settings** > **Customizations** > **Customize the System**.
2. Choose the custom entity. Under **Communication & Collaboration**, enable **Activities**, and then choose **Save** > **Publish** on the **Home** tab.

   ![Communication and collaboration activity enabled](media/communication-collaboration-activities.png "Communication and collaboration activity enabled")
   
    > [!NOTE]
   > To add a custom entity, see [Filter entities and views that appear in Dynamics 365 App for Outlook](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/outlook-app/deploy-dynamics-365-app-for-outlook#filter-entities-and-views-that-appear-in-dynamics-365-app-for-outlook).
