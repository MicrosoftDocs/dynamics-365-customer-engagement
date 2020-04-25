---
title: "Device and app management with Microsoft Intune | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 02/03/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Manage Field Service Mobile with Microsoft Intune

Mobile Application Management (MAM) is software that enables IT administrators to apply and enforce corporate policies on mobile apps. One MAM option for IT administrators is [Microsoft Intune](https://docs.microsoft.com/intune/apps/app-management), which offers a suite of features that lets you publish, push, configure, secure, monitor, and update mobile apps - including Field Service Mobile.

MAM is important to field service organizations whose technicians use Field Service Mobile primarily because:

1. Technicians frequently travel to multiple locations, and protecting sensitive company data is critical.
2. Many field service organizations have a bring-your-own-device (BYOD) policy, which means the Field Service Mobile app needs management among many different kinds of devices and apps for personal use. 

With an Intune-enabled Field Service Mobile app, IT administrators can:
- Add and assign the Field Service Mobile app to user groups and devices, including users in specific groups, devices in specific groups, and more.
- Configure the Field Service Mobile app to open with specific settings enabled, and update the app when already installed on the device.
- See reports and track app usage.
- Limit sharing of corporate data among apps by restricting data leakage through “Cut/Copy/Paste/Save As.”
- Provide encryption at rest.

## Prerequisites

- Field Service Mobile v12.1+ for iOS and Android
- No Field Service Mobile Configurator (Woodford) requirements 


## Get started
To get started with Intune, follow the instructions for [adding and assigning an app with Intune](https://docs.microsoft.com/intune/apps/quickstart-add-assign-app).

## Additional notes
- MAM with Intune for Field Service Mobile will work with or without MDM device enrollment.

### See also

- [What is Microsoft Intune app management?](https://docs.microsoft.com/intune/apps/app-management)
