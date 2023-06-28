---
title: "Limitations when customizing Dynamics 365 App for Outlook (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
ms.date: 05/20/2021
description: When customizing the app you make run into these limitations.
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
# Limitations when customizing Dynamics 365 App for Outlook

This topic covers limitations when customizing Dynamics 365 App for Outlook.

## Business process flows

Business process flows are not supported in Dynamics 365 App for Outlook. When customizing the app, you should not explicitly select any business process flows.

## Customizing App for Outlook sitemap

System customizers have access to the Sitemap Designer using the App Designer for Dynamics 365 App for Outlook. It's one of the App Modules in version 9.x. The Dynamics 365 App for Outlook default landing page is a dashboard that is configured in the App Module. If you are unable to view the Dynamics 365 App for Outlook landing page when you open App for Outlook, follow the steps below.

1. Sign in to [Power Apps](https://make.powerapps.com).
2. On the left nav, select **Solutions**.
3. Select the **Default Solution** > **More Commands** > **Edit**.

   > [!div class="mx-imgBorder"]
   > ![Edit the default solution.](media/edit-solution.png)

4. Select **All** and then select **Dashboard**.

   > [!div class="mx-imgBorder"]
   > ![Sort by dashboard.](media/sort-by-dashboard.png)

5. Select **App for Outlook Dashboard** and then on the command bar select **Enable security roles**.

   > [!div class="mx-imgBorder"]
   > ![Select App for OUtlook Dashbaord and then select enable security roles.](media/enable-security-role.png)


6. On the **Assign Security Role: App for Outlook Dashboard** dialog, select **Display to everyone** and **Enable for fallback**.

   > [!div class="mx-imgBorder"]
   > ![Assign security role scren.](media/assign-security-roles-screen.png)

7. When you're done, select **OK**. 


This issue is also seen when the sitemap for App for Outlook has been modified. For example, the sitemap for App for Outlook has an alternate dashboard in the **Default Dashboard** field. To resolve this issue, do the following:

1. Sign in to [Power Apps](https://make.powerapps.com).
2. On the left navigation pane, select **Apps**.
3. From the list of apps select **Dynamics 365 App for Outlook** and then select **Edit**.

   > [!div class="mx-imgBorder"]
   > ![Select Dynamics 365 App for Outlook and then select edit.](media/edit-apps-outlook.png)

4. Select **Open the Site Map Designer** 

   > [!div class="mx-imgBorder"]
   > ![Edit Dynamics 365 App for Outlook sitemap designer.](media/edit-site-map.png)

5. Select **Dashboards** and make sure that the App for Outlook sitemap has **Dashboard** as the first sub area and that the **Default Dashboard** is **App for Outlook Dashboard**.

   > [!div class="mx-imgBorder"]
   > ![Dynamics 365 App for Outlook sitemap designer page with default dashboard.](media/default-dashboard.png)




[!INCLUDE[footer-include](../includes/footer-banner.md)]
