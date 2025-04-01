---
title: Set up frontline workers in your organization
description: Learn how to set up frontline workers through the Dynamics 365 Field Service get started page.
ms.author: jacoh
author: jasonccohen
ms.date: 07/09/2024
ms.topic: how-to
ms.custom: bap-template
---

# Set up frontline workers in your organization

Frontline workers in Dynamics 365 Field Service are people in your organization who are primarily scheduled for onsite jobs and who use the Dynamics 365 Field Service mobile app for their work. Set up frontline workers to ensure they can immediately engage on work order. Technically, frontline workers are a *bookable resource* record in Field Service.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=78a4ad09-8320-4895-a69f-100cbf46ac14]

On the [**Get started** page](field-service-get-started.md), admins can use a single form to set up frontline workers in their organizations to quickly get up and running.

## Prerequisites

- Your organization's admin must have a Microsoft 365 [administrator account](/microsoft-365/admin/add-users/about-admin-roles).
- Each frontline worker must have a Field Service license assigned through the [Microsoft 365 admin center](https://admin.microsoft.com). [Learn how to assign licenses](/microsoft-365/admin/manage/assign-licenses-to-users).

## Set up frontline workers

1. In Field Service, change to the **Service** area and go to **Get started**.

1. In the **Set up your frontline workers** section, select **Set Up**.

1. In the **Quick Set Up: Frontline Workers** form fill in the following details:

   - **Users**: Choose users to create as frontline workers. When you choose more than one user, they all get the same properties assigned as defined in the following sections.
   - **Characteristics**: Choose [skills and qualifications](set-up-characteristics.md) for your frontline workers.
   - **Territories**: Choose which [territories](set-up-territories.md) your frontline workers belong to.
   - **Time Zone**: Select the default time zone for the frontline workers.
   - **Security Role** choose the [security role](/power-platform/admin/security-roles-privileges) for your frontline workers. You can add multiple security roles, including custom security roles.
   - **Field Security Profile** choose the [column-level security profile to control access](/power-platform/admin/field-level-security) for your frontline workers. You can add multiple field security profiles, including custom field security profiles.
   - **Mobile Offline Profile** sets the [default mobile offline profile](mobile/best-practices-limitations-offline-profile.md) your frontline workers. Only published mobile offline profiles show in the list.

1. Select the checkbox to send an email to newly created frontline workers with a link to download the mobile app. If you can't send an email to frontline workers, get your email address approved by your admin. For more information, see [Add and approve email addresses](frontline-worker-set-up-email-approval.md).

1. Select **Save and close** to create the frontline workers as bookable resources.

## View and update the details of individual frontline workers

Frontline workers are stored in the *bookable resource* table. You can view and update the details for each resource.

1. In Field Service, change to the **Resources** ares and go to **Resource** > **Resources**.

1. View or update the resource properties as needed. For more information, see [Set up bookable resources](set-up-bookable-resources.md).

## Next steps

- [Create a work order](create-work-order.md)
- [Download the mobile app and get started](mobile/download-mobile-app.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
