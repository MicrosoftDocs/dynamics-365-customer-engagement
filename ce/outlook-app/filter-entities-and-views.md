---
title: "Filter tables and views that appear in Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom:
description: Filter tables and views that appear in Dynamics 365 App for Outlook  
ms.date: 05/20/2021
ms.reviewer: jimholtz
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: Dynamics 365 apps
ms.assetid: 09736e14-e744-48ca-a755-1b05bb55340e
caps.latest.revision: 39
author: sidhartg
ms.author: sidhartg
search.audienceType: 
  - admin
  - customizer
  - enduser
---
# Filter tables and views that appear in Dynamics 365 App for Outlook  

Modularize business logic by exposing only the relevant set of tables to your users and help them get to the information they need faster. An app maker can customize Dynamics 365 App for Outlook to show tables that are required for your organization's needs. 

Use the Power Apps app designer, to control which tables appear in the App for Outlook’s **Quick Create** menu and the **Regarding** lookup. 

Follow these steps to set which tables and views appear in App for Outlook:

1. Sign in to [Power Apps](https://make.powerapps.com).
2. On the left navigation pane, select **Apps**.
3. From the list of apps select **Dynamics 365 App for Outlook** and then select **Edit**.

   > [!div class="mx-imgBorder"]
   > ![Select Dynamics 365 App for Outlook and then select edit.](media/edit-apps-outlook.png)

4. In the app designer, **Add** > **Entities** and then select the table you want to add and complete the addition by including all assets.

   > [!div class="mx-imgBorder"]
   > ![Select tables to enabled on the My Apps page.](media/AddEntities_2.png "Dynamics 365 apps My Apps page")

   > [!div class="mx-imgBorder"]
   > ![Select table that you want to enable.](media/AddEntities_3.png "Dynamics 365 apps My Apps page")
   
5. Review the list of Views that are available for the table and deselect the ones you don't want to be available in Dynamics 365 App for Outlook. In Dynamics 365 App for Outlook **Regarding** lookup,  you can filter results based on a table and further, on one of the views defined for that table.

 
   > [!div class="mx-imgBorder"]
   > ![Review the list of views.](media/ViewEntities_4.png "Dynamics 365 apps My Apps page")

5.  When you're done, select **Save** and then **Publish**.

> [!NOTE]
> - You can also remove tables from Dynamics 365 App for Outlook.
> - A table must have activities enabled for it to appear in the **Set Regarding** lookup. For more information, see [Enable activities to use Set Regarding lookup in App for Outlook](enable-a-custom-entity-to-appear-in-the-regarding-lookup.md).



[!INCLUDE[footer-include](../includes/footer-banner.md)]
