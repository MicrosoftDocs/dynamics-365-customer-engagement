---
title: Manage the Field Service mobile app with Intune
description: Learn how to get the Field Service mobile app set up with Microsoft Intune.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 09/22/2025
author: JonBaker007
ms.author: jobaker
---

# Manage the Field Service mobile app with Intune

Mobile application management enables administrators to apply and enforce policies on mobile apps. One mobile application management option is [Microsoft Intune](/mem/intune/apps/app-management). It offers features that let you publish, push, configure, secure, monitor, and update mobile apps.

Mobile application management is important to field service organizations because technicians often travel to different locations, and protecting sensitive company data is critical. Many organizations have a bring-your-own-device policy, so the Field Service mobile app needs management across different types of devices and personal apps.

With an Intune-enabled Field Service mobile app, IT administrators can:

- Add and assign the mobile app to user groups and devices, including users in specific groups, devices in specific groups, and more.
- See reports and track app usage.
- Limit sharing of corporate data among apps by restricting data leakage through cut, copy, paste, and save as.
- Provide encryption at rest.

## Get started

Intune is a separate Microsoft service that isn't included with Field Service. Go to  [What is Microsoft Intune app management?](/intune/intune-service/apps/app-management) and [Add and assign an app with Intune](/intune/intune-service/apps/quickstart-add-assign-app) to get started.

Set up a configuration through the [Device Management portal](https://devicemanagement.microsoft.com/). Each supported platform (iOS, Android, and Windows) needs a separate configuration.

Specific configurations like prefill of URL or username aren't available for the [Field Service mobile app](overview.md).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
