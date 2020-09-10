---
title: "Overview of the security roles for app profile manager | MicrosoftDocs"
description: "Overview of the security roles for app profile manager."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 09/07/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Roles and privileges associated with app profile manager

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - This feature is a preview, which means that it is made available to you before general availability so you can test and evaluate the preview and provide feedback to Microsoft.
> - This preview may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, this preview is not meant to be used with any "live" or production Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Any use of "live" data is at your sole risk and it is your sole responsibility to notify your end users that they should not include sensitive information with their use of the Preview.
> - This preview, and any support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty. This preview is subject to the [Preview Terms](../legal/supp-dynamics365-preview.md).

## Introduction

The following roles are available with the app profile manager:

- App profile manager administrator
- App profile user

If your organization uses custom roles, and you want a user with the custom role to manage app profiles, then you can either assign the App profile manager administrator role or manually add the privileges pertaining to the App profile manager administrator role to the custom role.

## Roles for Customer Service workspace

By default, the privileges pertaining to the App profile user role have been added to the Customer Service Representative role out of the box. You need to manually provide the App profile manger administrator role to the user who'll create app profiles, templates, productivity tools, and channel provider configurations.

## Roles for Omnichannel for Customer Service

Out of the box, for the **Omnichannel administrator** role, the privileges pertaining to the **App profile manager administrator** role have been added, and for the **Omnichannel agent** and **Omnichannel supervisor** roles, the privileges pertaining to the **App profile user** role have been added.

### See also

[An overview of app profile manager](overview.md)
