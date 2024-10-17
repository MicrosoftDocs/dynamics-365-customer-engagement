---
title: Manage the Field Service mobile app with Intune
description: Learn how to get the Field Service mobile app set up with Microsoft Intune.
ms.topic: conceptual
ms.subservice: field-service-mobile
ms.date: 08/28/2024
author: JonBaker007
ms.author: jobaker
---

# Manage the Field Service mobile app with Intune

Mobile application management enables administrators to apply and enforce policies on mobile apps. One mobile application management option is [Microsoft Intune](/mem/intune/apps/app-management). It offers a suite of features that lets you publish, push, configure, secure, monitor, and update mobile apps - including the Dynamics 365 Field Service mobile app.

Mobile application management is important to field service organizations whose technicians use the mobile apps because they frequently travel to multiple locations, and protecting sensitive company data is critical. Many organizations have a bring-your-own-device policy, which means the Field Service mobile app needs management among many different kinds of devices and apps for personal use.

With an Intune-enabled Field Service mobile app, IT administrators can:

- Add and assign the mobile app to user groups and devices, including users in specific groups, devices in specific groups, and more.
- See reports and track app usage.
- Limit sharing of corporate data among apps by restricting data leakage through cut, copy, paste, and save-as.
- Provide encryption at rest.

## Get started

Intune is a separate Microsoft service that isn't included with Field Service. Refer to the documentation on [What is Microsoft Intune app management?](/mem/intune/apps/app-management) and [Adding and assigning an app with Intune](/mem/intune/apps/quickstart-add-assign-app) to get started.

A configuration can be set up through the [Device Management portal](https://devicemanagement.microsoft.com/). Each supported platform (iOS, Android, and Windows) requires a separate configuration.

Specific configurations like prefill of URL or username aren't available for the [Field Service mobile app](overview.md).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
