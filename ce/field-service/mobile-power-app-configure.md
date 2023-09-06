---
title: "Edit Sitemap entities (tables) on the home screen | MicrosoftDocs"
description: Learn about how to change the sitemap, forms, and views in the Field Service (Dynamics 365) mobile app.
ms.date: 11/09/2021
ms.topic: article
ms.subservice: field-service-mobile
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: Andrea-Orimoto
ms.author: andreo
---

# Edit Sitemap entities (tables) on the home screen

Sign in to Dynamics 365 as a system administrator.

To see your list of apps, go to:

`https://[YOUR-ENVIRONMENT-NAME].crm.dynamics.com/main.aspx?forceUCI=1&pagetype=apps`

Find the Field Service Mobile app and **Open In App Designer**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365, showing the list of apps and showing the option to open Field Service Mobile in the App Designer.](./media/editappmodule.png)

From the app designer, you will see the current Sitemap. The out of the box sitemap will contain groups of pages, including "My Work", "Customers" and "Assets". You can modify this to add or remove groups and pages as needed for your business scenario. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the App Designer in Power Apps, showing the Field Service Mobile site map option.](./media/editappmodule_sitemap.png)

You can even create entirely new groups with more subareas to display different entities.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps, showing Field Service Mobile in the App Designer, and showing add new group or page.](./media/editappmodule_sitemap_new.png)

> [!Note]
> For every entity you display in the sitemap, you can choose the views available on mobile in the App Designer.




## Edit mobile views

- [Create and edit public or system model-driven app views](/powerapps/maker/model-driven-apps/create-edit-views-app-designer) 

- [Customize entity views](/powerapps/developer/model-driven-apps/customize-entity-views)

- [Customize Booking Calendar](/dynamics365/field-service/mobile-powerapp-customize-booking-calendar)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
