---
title: "Device and app management with Microsoft Intune | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/21/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Manage Field Service Mobile with Microsoft Intune

## Prerequisites

- Field Service Mobile v12.1+ for iOS and Android
- No Field Service Mobile Configurator (Woodford) requirements 


## What is Mobile Application Management (MAM)?

Mobile Application Management (MAM) is software that enables IT administrators to apply and enforce corporate policies on mobile apps. One MAM option for IT administrators is [Microsoft Intune](https://docs.microsoft.com/en-us/intune/apps/app-management) that offers a suite of features that let you publish, push, configure, secure, monitor, and update mobile apps including Field Service Mobile, which you will find in a [list of Microsoft apps that are commonly used with Intune](https://aka.ms/mamenabledapps).

## Why is MAM important to Field Service organizations?

MAM is important to field service organizations whose technicians use Field Service Mobile primarily because:

1. Technicians are "on the go" traveling to multiple different locations and there is a need to protect sensitive company data.
2. Many field service organizations have a Bring-Your-Own-Device (BYOD) policy which means the field service mobile app needs management amond many different kinds of devices alongside personal apps. 

With an Intune enabled Field Service Mobile app, IT administrators can:
- Add and assign your Field Service Mobile app to user groups and devices, including users in specific groups, devices in specific groups, and more.
- Configure the Field Service Mobile app to start or run with specific settings enabled, and update your existing app when already on the device.
- See reports and track app usage.
- Limit the sharing of corporate data among apps by restricting data leakage through “Cut/Copy/Paste/Save As”
- Provide encryption at rest

## Get started

To get started follow the instructions for [adding and assigning an app with Intune](https://docs.microsoft.com/en-us/intune/apps/quickstart-add-assign-app)

## Additional notes
- MAM with Intune for Field Service Mobile will work with or without MDM device enrollment

### See also

[What is Microsoft Intune app management?](https://docs.microsoft.com/en-us/intune/apps/app-management)
