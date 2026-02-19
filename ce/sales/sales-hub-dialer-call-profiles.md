---
title: Step 4:\ Configure inbound and outbound profiles for the Sales Hub dialer
description: Learn how to create inbound and outbound call profiles that control call routing, consult/transfer behavior, and outgoing call settings for the Sales Hub dialer.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Step 4: Configure inbound and outbound profiles for the Sales Hub dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Inbound profiles define how incoming calls are routed to sellers — including consult and transfer behavior, language settings, and capacity configuration. Outbound profiles control how sellers place outgoing calls. Default profiles are assigned to all users automatically and serve as a fallback.

Create custom profiles only when you need different behaviors for specific groups, such as customized consult/transfer settings or language-specific greetings for geographic segments.

For detailed reference, see:

- [Create inbound profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles#create-inbound-profiles)
- [Create outbound profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles#create-outbound-profiles)
- [Default profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles#default-profiles)

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Create an inbound profile

1. In **Copilot Service Admin Center**, go to **Productivity** in the site map.
1. Under **Outbound and inbound profiles**, select **Manage**.
1. Select **New Profile**.
1. On the **Profile Settings** tab, enter a **Profile Name**, set **Profile Type** to **Inbound**, and select **Next**.
1. On the **Inbound Info** tab, set **Queue** to **Default voice queue** and **Capacity** to **Default voice inbound** (or your custom capacity profile), then select **Next**.
1. On the **Inbound Behaviors** tab, configure the **Language**, **Consult**, and **Transfer** settings. To enable consult and transfer with Teams users or external phone numbers, turn on the corresponding options. Select **Next**.
1. On the **Summary** page, select **Save and Close**.

## Create an outbound profile

Follow the same steps as for an inbound profile, but set **Profile Type** to **Outbound** in step 4.

## Ensure profile consistency

> [!IMPORTANT]
> For call routing to work correctly with custom profiles, ensure consistency across all three configuration areas:
>
> - The seller must be assigned to the capacity profile under its **Users** tab.
> - The same seller must be assigned to the inbound or outbound profile under its **Phone number** tab.
> - The same capacity profile must be linked to the inbound or outbound profile.
>
> This consistency is not required for default profiles, which serve as an automatic fallback for all users.

## When to create additional profiles

- **Customized call handling** — If different consult and transfer settings are needed for different business units.
- **Geographic segmentation** — If different groups of sellers require language-specific greetings or regional settings.

## Next step

> [!div class="nextstepaction"]
> [Assign phone numbers to sellers](sales-hub-dialer-assign-numbers.md)

## Related content

- [Enable and configure the Sales Hub dialer](configure-sales-hub-dialer.md)
- [Configure outbound and inbound profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles)
