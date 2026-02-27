---
title: Step 3:\ Set up capacity profiles for the Sales Hub Dialer
description: Learn how to configure capacity profiles that define how many concurrent calls sellers can handle in the Sales Hub Dialer.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Step 3: Set up capacity profiles for the Sales Hub Dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Capacity profiles define how many concurrent calls a seller can handle. The following default profiles are automatically assigned to all users:
 
- **Default voice inbound** 
- **Default voice outbound**

For detailed reference, see [Create and manage capacity profiles](/dynamics365/customer-service/administer/capacity-profiles).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Default capacity profiles

All users are automatically assigned to the default capacity profiles. The default capacity is set to **1**, which means a seller who is already on a call won't receive notifications for new incoming calls.

> [!TIP]
> To allow sellers to receive new call notifications while on a call, increase the capacity. A value of **5** is recommended to avoid blocking seller capacity.

## Create a custom capacity profile

Create a custom capacity profile when you need different concurrency limits for specific groups of sellers.

1. Open the Sales Hub app, and select **Change area** > **Sales Hub Dialer settings**.
1. Select **Users** and then select any user.
1. Open the **Omnichannel** tab, and under **Capacity profiles**, select **New capacity profile**.
1. Enter the profile name and set the desired capacity for voice calls.
1. Select the **Users** tab and add the sellers who should be assigned to this profile.

> [!NOTE]
> Explicit user assignment is only required for custom profiles. All users are automatically assigned the default profiles.

## Next step

> [!div class="nextstepaction"]
> [Configure inbound and outbound profiles](sales-hub-dialer-call-profiles.md)

## Related information

- [Enable and configure the Sales Hub Dialer](configure-sales-hub-dialer.md)
- [Create and manage capacity profiles](/dynamics365/customer-service/administer/capacity-profiles)
