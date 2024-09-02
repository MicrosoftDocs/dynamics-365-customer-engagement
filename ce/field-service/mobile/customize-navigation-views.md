---
title: Edit the navigation and views on the mobile app
description: Change the navigation, forms, and views in the Dynamics 365 Field Service mobile app.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 08/28/2024
author: JonBaker007
ms.author: jobaker
---

# Edit the navigation and views on the mobile app

The Field Service Mobile app module is a model-driven app, which you can edit in Power Apps so it matches your business scenario.

To change things like the navigation, form, or views, [you need permissions to sign in to Power Apps and permissions to edit model-driven apps](/power-apps/maker/canvas-apps/sign-in-to-power-apps). Usually, the environment maker, system administrator, or system customizer security role have the permissions to create or edit apps.

## Edit the navigation

In [Power Apps](https://make.powerapps.com/), open the environment with [the app you want to edit](/power-apps/maker/model-driven-apps/create-model-driven-app).

In the app designer in Power Apps, you find the current navigation structure with groups of pages. You can [edit the navigation and add or remove groups and pages](/power-apps/maker/model-driven-apps/app-navigation).

## Edit mobile views

For every table in the navigation, you can choose the views available on mobile app. For more information, see [Understand model-driven app views](/power-apps/maker/model-driven-apps/create-edit-views). Configuring views for the new user experience works the same way as for the Unified Interface experience. However, you can't change the bookings [view in the new experience](customize-booking-calendar.md).

You can also [customize views with code](/power-apps/developer/model-driven-apps/customize-entity-views) or [customize the booking calendar](customize-booking-calendar.md).

## Next steps

- [Overview of the model-driven app designer](/power-apps/maker/model-driven-apps/app-designer-overview)
- [Understand model-driven app components](/power-apps/maker/model-driven-apps/model-driven-app-components)
- [Model-driven apps developer guide](/power-apps/developer/model-driven-apps/)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
