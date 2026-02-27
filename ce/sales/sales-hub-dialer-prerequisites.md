---
title: Prerequisites for the Sales Hub Dialer
description: Learn about required admin roles, licenses, voice channel provisioning, and seller roles needed to enable the Sales Hub Dialer.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Prerequisites for the Sales Hub Dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Before you enable the Sales Hub Dialer, verify that your environment meets the following requirements.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Admin roles

Ensure you have both of the following role combinations to configure voice channel:

- **License Administrator** role, **Teams Administrator** or **Teams Telephony Administrator** role, and **TeamsResourceAccount.Read.All** Graph permission.
- **System Administrator** or **Omnichannel Administrator** role in Dynamics 365.

## Entitlements

Verify that you have the following entitlements in the [Microsoft 365 admin center](https://admin.cloud.microsoft/):

- [Teams Phone](/microsoftteams/teams-phone-licensing) with a Teams Calling Plan, Teams Direct Routing, or Teams Operator Connect [PSTN connectivity](/microsoftteams/pstn-connectivity) option.
- [Dynamics 365 Contact Center](https://www.microsoft.com/dynamics-365/products/contact-center) or Dynamics 365 Customer Service.
- [Microsoft Teams Phone Resource Account](/microsoftteams/teams-add-on-licensing/virtual-user).
- Dynamics 365 Sales

Check the exact licensing requirements in the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544).  

## Seller roles

Each seller who will make or receive calls must have all of the following security roles:

- **Basic User:** Basic access and navigation in Dynamics 365 apps.
- **Omnichannel Agent:** Required to make and receive calls.
- **Salesperson:** Required to access the Sales Hub app.

Learn more about assigning security roles in [Power Platform documentation](/power-platform/admin/assign-security-roles)

## Next step

> [!div class="nextstepaction"]
> [Sync Teams phone numbers to Dynamics 365](sales-hub-dialer-sync-numbers.md)

## Related information

- [Enable and configure the Sales Hub Dialer](configure-sales-hub-dialer.md)
