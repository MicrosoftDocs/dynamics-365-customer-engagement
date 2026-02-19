---
title: Step 3:\ Set up capacity profiles for the Sales Hub dialer
description: Learn how to configure capacity profiles that define how many concurrent calls sellers can handle in the Sales Hub dialer.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Step 3: Set up capacity profiles for the Sales Hub dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Capacity profiles define how many concurrent calls a seller can handle. Dynamics 365 ships two default profiles — **Default voice inbound** and **Default voice outbound** — that are automatically assigned to all users.

For detailed reference, see [Create and manage capacity profiles](/dynamics365/customer-service/administer/capacity-profiles).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Default capacity profiles

All users are automatically assigned to the default capacity profiles. The default capacity is set to **1**, which means a seller who is already on a call won't receive notifications for new incoming calls.

> [!TIP]
> To allow sellers to receive new call notifications while on a call, increase the capacity. A value of **5** is recommended to avoid blocking agent capacity.

## Create a custom capacity profile

Create a custom capacity profile when you need different concurrency limits for specific groups of sellers.

1. In **Copilot Service Admin Center**, go to **User Management** in the site map.
1. Under **Capacity Profile**, select **Manage**.
1. Select **Create New**.
1. Enter the desired configuration and save the profile.
1. On the new profile, go to the **Users** section and add the sellers who should use this profile.

> [!NOTE]
> Explicit user assignment is only required for custom profiles. All users automatically belong to the default profiles.

## Next step

> [!div class="nextstepaction"]
> [Configure inbound and outbound profiles](sales-hub-dialer-call-profiles.md)

## Related content

- [Enable and configure the Sales Hub dialer](sales-hub-dialer-admin-howto.md)
- [Create and manage capacity profiles](/dynamics365/customer-service/administer/capacity-profiles)
