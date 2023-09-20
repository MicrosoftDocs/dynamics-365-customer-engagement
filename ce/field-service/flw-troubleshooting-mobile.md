---
title: Dynamics 365 Field Service Mobile (preview) troubleshooting
description: Learn how to troubleshoot issues in Dynamics 365 Field Service Mobile (preview).
ms.date: 09/14/2023
ms.topic: troubleshooting
author: andrea-orimoto
ms.author: andreo
ms.reviewer: mhart
ms.custom: bap-template
---

# Dynamics 365 Field Service Mobile (preview) troubleshooting

[!INCLUDE[public-preview-banner](../includes/public-preview-banner.md)]

This article lists common issues with the [Field Service Mobile (preview)](mobile-powerapp-newux-overview.md) app and steps to resolve them.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## The mobile app shows an error on start due to permission/privilege issues

### Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview).

### Symptoms

The Field Service Mobile app fails to launch with the following error: `Principal user (Id=<GUID>, …) is missing 'prvReadmsdyn_Mobile' privilege (Id=<GUID>) on OTC=<INT> for entity 'msdyn_mobilesource' …`

### Resolution

The new user experience for Field Service Mobile (preview) requires a few additional privileges added to the security roles which the user belongs to.
Review [Troubleshooting custom security roles](flw-troubleshooting-mobile-custom-security-role-tsg.md) to resolve this issue.

## The mobile app shows error on start due to missing files in the solution

### Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview).

### Symptoms

Some required source records are missing. These records should be created when installing the solution. In rare cases, these records don't get created successfully or corrupted. In some cases, the records were deleted by users.

### Resolution

To resolve the issue, recreate the missing records. For more information, see [these steps](flw-troubleshooting-mobile-missing-files-tsg.md).

## Not possible to enable the new experience because the settings area doesn't show

### Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview).

### Symptoms

Admins enable the new experience in the new settings area that the default Field Service Mobile app module adds to the navigation. Custom app modules don't have the new settings area enabled by default.

### Resolution

Enable the settings are in the navigation of your custom app module. For more information, follow [these steps](flw-troubleshooting-mobile-missing-files-tsg.md).

## The new experience doesn't show after enabling it in settings

### Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview).

### Symptoms

The mobile app doesn't load the new experience, even if it has been [enabled in the settings](mobile-powerapp-newux-overview.md#enable-the-preview-features).

### Resolution

The new experience (preview) currently doesn't support users or app modules with offline enabled. 
Verify and update the following cases:

1. The user uof the mobile app must not be part of the Mobile Offline Profile.
2. The app module itself should not be set up for offline. In the app designer, open the **Field Service Mobile** app. Go to **Settings** > **Features** and set the **Offline setup from the app designer** toggle to **No**. For more information, see [Set up mobile offline](/power-apps/mobile/setup-mobile-offline#enable-your-app-for-offline-use-preview).