---
title: Prerequisites for the Sales Hub dialer
description: Learn about required admin roles, licenses, voice channel provisioning, and seller roles needed to enable the Sales Hub dialer.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Prerequisites for the Sales Hub dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Before you enable the Sales Hub dialer, verify that your environment meets the following requirements.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Admin roles

Ensure you have both of the following role combinations:

- **License Administrator** role and **Teams Administrator** role in Microsoft 365.
- **System Administrator** or **Omnichannel Administrator** role in Dynamics 365.

## Licenses

Verify the following licenses are assigned in the [Microsoft 365 admin center](https://admin.cloud.microsoft/):

- [Teams Phone license](/microsoftteams/teams-phone-licensing) with a Teams Calling Plan, Teams Direct Routing, or Teams Operator Connect [PSTN connectivity](/microsoftteams/pstn-connectivity) option.
- [Dynamics 365 Contact Center](https://www.microsoft.com/dynamics-365/products/contact-center) or Dynamics 365 Customer Service Premium license.
- [Microsoft Teams Phone Resource Account](/microsoftteams/teams-add-on-licensing/virtual-user) license.

## Voice channel provisioning

With the Dynamics 365 Contact Center license in place, [provision](/dynamics365/contact-center/implement/provision-channels#set-up-channels) and [configure](/dynamics365/customer-service/administer/voice-channel-install) the voice channel in your environment.

## Seller roles

Each seller who will make or receive calls must have all of the following security roles:

- **Basic User:** Basic access and navigation in Dynamics 365 apps.
- **Omnichannel Agent:** Required to make and receive calls.
- **Salesperson:** Required to access the Sales Hub app.

To assign roles, go to **Power Platform admin center** > **Environments** > select your environment > **Settings** > **Users + permissions** > **Users**, then assign the required roles.

## Next step

> [!div class="nextstepaction"]
> [Sync Teams phone numbers to Dynamics 365](sales-hub-dialer-sync-numbers.md)

## Related content

- [Enable and configure the Sales Hub dialer](configure-sales-hub-dialer.md)
