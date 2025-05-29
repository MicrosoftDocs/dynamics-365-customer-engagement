---
title: Create workflows and scripts for the mobile app
description: Learn about workflows and scripts for the Field Service mobile app.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 08/28/2024
author: JonBaker007
ms.author: jobaker
---

<!-- Check the sentence in line 28. It isn't complete. -->


# Create workflows and scripts for the mobile app

Administrators can use tools like Power Automate flows, classic background workflows, JavaScript, or business rules to automate business processes. Some processes work when the Dynamics 365 Field Service mobile app runs [offline first](work-offline.md) and others require internet connectivity.

## Power Automate flows and classic Dataverse workflows

Workflows and flows are commonly used to automate tasks based on triggers and conditions. We recommend [using Power Automate to build flows](/power-automate/flow-types) and consider replacing existing workflows with flows. There are several advantages for flows. For more information, see [Comparison of workflows and flow](/power-automate/replace-workflows-with-flows).

Workflows and flows require an internet connection. When the app is running in offline-first mode with an internet connection, saving a record triggers the workflow or flow. Results are downloaded with the next data sync.

## Business rules

Business rules and recommendations apply logic without writing code or creating plug-ins. For more information, see [Create a business rule for a table](/power-apps/maker/data-platform/data-platform-create-business-rule).

## Custom process actions

Actions open a broad set of options to compose business logic. [Use custom process actions](/power-apps/maker/data-platform/actions) to perform several operations in sequence.

Actions require an internet connection.

## JavaScript web resources

You can add [JavaScript web resources](/power-apps/developer/model-driven-apps/script-jscript-web-resources) to mobile forms and include them in offline profiles.

JavaScript web resources run with or without internet connection.

See [Mobile offline capabilities and limitations](/power-apps/mobile/offline-capabilities) for potential limitations regarding your planned code.

## Debugging the mobile app

You can debug custom code using the Windows or Android application:

- Debug JavaScript with the [Windows application](/power-apps/developer/model-driven-apps/clientapi/debug-javascript-code#debug-javascript-in-the-windows-desktop-app).
- Debug JavaScript with the [Android application](/power-apps/developer/model-driven-apps/clientapi/debug-javascript-code#debug-javascript-in-mobile-apps).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
