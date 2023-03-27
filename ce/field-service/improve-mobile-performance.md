---
title: "Performance considerations when customizing the Field Service (Dynamics 365) mobile app - Dynamics 365 Field Service | MicrosoftDocs"
description: Learn about you can improve the Field Service mobile app performance.
ms.date: 03/08/2023
ms.subservice: field-service-mobile
ms.topic: article
author: JonBaker007
ms.author: jobaker
search.app: 
  - D365CE
  - D365FS
---

# Performance considerations when customizing the Field Service (Dynamics 365) mobile app

In this article, we list a few ways you can improve the performance of Field Service (Dynamics 365) mobile.

The foundation of the Field Service (Dynamics 365) mobile app is a model-driven app. Thus, general [guidelines and best practices for performant apps](/power-apps/mobile/power-apps-mobile-canvas-app-restarts#best-practices-for-building-performant-apps) and [performance consideration for model-driven apps](/power-apps/maker/model-driven-apps/design-performant-forms) apply too.

## Remove Console.log from production code

Logging data to the console can increase memory pressure, as the console prevents items from being cleaned up. It's also best not to log data to the console during production, as this can unintentionally print sensitive data that is observable by the end user. This includes `console.log`, `console.warn`, and `console.error`.

## If not using QuickNotes, remove QuickNotes WebResource

The QuickNotes control bundle exists twice within Field Service: once as a PCF control and once as a web resource. If QuickNotes control (or any other control) won't be used, remove the control's `bundle.js` (if present) from the web resources in the form properties. This will prevent downloading the control code when not necessary.

The bundle can be removed by going to the booking and work order form for the bookable resource booking entity, opening **Form Properties**, and removing the `cc_MscrmControls.FieldControls.QuickNotesControl/bundle.js` item from the **Events** tab.

## Minifying Office UI imports in PCF controls

If using the `@fluentui/react` library for interactive UI components, it's possible to import more modules than intended based on how the import is defined. By being specific about the path that you are importing components from, you can dramatically reduce the size of your components (resulting in less data needing to be downloaded).

For example:

```
import { Button } from '@fluentui/react'
should be written as: 
import { Button } from '@fluentui/react/lib/Button';
```

## Use connected forms to minimize navigation across different entities

Field Service supports the ability to display fields from different entities within the same form, which can prevent having to jump between different forms. Minimizing navigation means avoiding load times when transitioning from one entity to another and can avoid any possible memory leaks and issues found when jumping between entities. Form components have a lower peak memory value when navigated to, in comparison to scenarios that use quick-find navigation instead.

For more information, see documentation on how to implement this customization: [Customize Field Service solution](/dynamics365/field-service/mobile-power-app-configure#edit-the-booking-and-work-order-form)

## Remove unused controls from the app

If app users are not using certain controls in the mobile app, consider removing them to reduce memory usage. Having unnecessary controls in the form increases the memory consumption of the app, leading to performance degradation. For example, the timeline control is included by default on several tables and forms. If your scenario doesn't leverage the timeline, consider removing it to reduce memory consumption.
