---
title: Buy a Dynamics 365 Field Service license
description: Learn how to purchase licenses for Dynamics 365 Field Service.
ms.date: 10/10/2023
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.custom: bap-template
---

# Buy a Dynamics 365 Field Service license

Purchase a Dynamics 365 Field Service subscription. To purchase licenses, you need a [Microsoft 365 administrator account](https://www.microsoft.com/microsoft-365/business/office-365-administration).

Try out Dynamics 365 Field Service before purchasing a subscription with [a free 30-day trial](trial-signup.md). You don't have to have administrator privileges to sign up for the trial.

## Available Field Service license types

There are two types of licenses for Field Service:

- The standard Dynamics 365 Field Service license that includes all core features and capabilities.
- The Dynamics 365 Field Service Contractor license that includes a subset of the core features and capabilities at a lower price point.


|Feature area |Dynamics 365 Field Service  |Dynamics 365 Field Service Contractor  |
|---------|---------|---------|
|Access the app from the web, mobile, and through Microsoft 365 integrations   |  Yes       | Yes        |
|AI assistance from Copilot in Field Service for work order creation, scheduling, summarization, and work order updates    |  Yes       |  No       |
|Access to Dynamics 365 Guides and Remote Assist    | Yes        | 2D Guides in the Field Service mobile app       |
|Technician performance analysis     | Yes        | No        |
|Vendor and contractor management   | Yes        | Limited ~        |
|Planned maintenance agreements    | Yes        | No        |
|Returns processing    | Yes        | No        |
|Capture leads and opportunities      | Yes        |  No       |
|Manage quotes    | Yes        | No        |
|Scheduling and resource dispatching    | Yes        | Limited ~~        |

~ Contractors are limited to managing their own staff.

~~ Contractors can create bookings manually but don't have access to schedule optimization with the schedule board.

For pricing information, see [Field Service pricing](https://dynamics.microsoft.com/field-service/pricing/). For detailed licensing information, see [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/?LinkId=2090495).

## Buy a Field Service license

1. Log into the [Microsoft 365 admin center](https://admin.microsoft.com/AdminPortal/Home) using your organization's admin account.

   If you can't access the Microsoft 365 admin center, contact your Dynamics 365 administrator.

1. Under **Subscriptions**, search for and buy Dynamics 365 Field Service licenses for each user.

## Field Service and mixed reality apps

> [!IMPORTANT]
> We're releasing the updates to the Field Service license on December 1, 2023. Familiarize with the information until the changes are available in your region.

With Field Service version [XXX](tbd.md) in the 2023 release wave 2, the Field Service license also includes Dynamics 365 Guides and Dynamics 365 Remote Assist at no extra cost. No action is required to assign the new licenses to existing users. However, the system doesn't install the applications automatically. For more information about installing the mixed reality apps, see [Collaborate in mixed reality with Field Service and Remote Assist](remote-assist-hololens.md) and [Integrate Guides with Field Service](mixed-reality-guides-integration.md).

The update automatically adds security roles for Guides and Remote Assist to users with default Field Service security roles. Admins can disable that setting to stop the automated role assignment for new users. For more information, see [Mixed Reality settings](configure-default-settings.md#mixed-reality-settings).

## Next steps

- [Install Field Service](install-field-service.md)
- [Get started](field-service-get-started.md)
- [Set up Dynamics 365 Guides](mixed-reality-guides-integration.md)
- [Set up Dynamics 365 Remote Assist](remote-assist-hololens.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
