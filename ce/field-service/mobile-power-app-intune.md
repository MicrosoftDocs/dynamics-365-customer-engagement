---
title: "Manage Field Service (Dynamics 365) mobile app with Microsoft Intune | MicrosoftDocs"
description: Learn how to get the Field Service (Dynamics 365) mobile app set up with Microsoft Intune.
ms.date: 07/06/2020
ms.topic: article
ms.subservice: field-service-mobile
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: JonBaker007
ms.author: jobaker
---

# Manage Field Service (Dynamics 365) mobile app with Microsoft Intune

Mobile application management is software that enables IT administrators to apply and enforce corporate policies on mobile apps. One mobile application management option for IT administrators is [Microsoft Intune](/intune/apps/app-management), which offers a suite of features that lets you publish, push, configure, secure, monitor, and update mobile apps - including the Field Service (Dynamics 365) mobile app.

Mobile application management is important to field service organizations whose technicians use the Field Service (Dynamics 365) mobile app primarily because:

1. Technicians frequently travel to multiple locations, and protecting sensitive company data is critical.
2. Many field service organizations have a bring-your-own-device policy, which means the Field Service (Dynamics 365) mobile app needs management among many different kinds of devices and apps for personal use.

With an Intune-enabled Field Service (Dynamics 365) mobile app, IT administrators can:

- Add and assign the Field Service (Dynamics 365) mobile app to user groups and devices, including users in specific groups, devices in specific groups, and more.
- See reports and track app usage.
- Limit sharing of corporate data among apps by restricting data leakage through cut, copy, paste, and save-as.
- Provide encryption at rest.


## Get started

Intune is a separate Microsoft product that is not included with Field Service. Refer to the documentation on [What is Microsoft Intune app management?](/intune/apps/app-management) and [Adding and assigning an app with Intune](/intune/apps/quickstart-add-assign-app) to get started.

A configuration can be set up through the [Device Management portal](https://devicemanagement.microsoft.com/). Each supported platform (iOS, Android, and Windows) requires a separate configuration.

## Additional notes

- Specific configurations like prefill of URL or username are not available for the [Field Service (Dynamics 365) mobile](mobile-power-app-overview.md).
- Standard mobile application management capabilities for Field Service (Dynamics 365) mobile app will work with or without MDM device enrollment in Intune.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
