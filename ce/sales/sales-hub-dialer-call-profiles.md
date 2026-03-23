---
title: "Step 4: Configure inbound and outbound profiles for the Sales Hub Dialer"
description: Learn how to create inbound and outbound call profiles that control call routing, consult/transfer behavior, and outgoing call settings for the Sales Hub Dialer.
ms.date: 03/23/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Step 4: Configure inbound and outbound profiles for the Sales Hub Dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Inbound profiles define how incoming calls are routed to sellers — including consult and transfer behavior, language settings, and capacity configuration. Outbound profiles control how sellers place outgoing calls. Default profiles are assigned to all users automatically and serve as a fallback.

Create custom profiles only when you need different behaviors for specific groups, such as customized consult/transfer settings or language-specific greetings for geographic segments.

This article covers quick steps to create inbound and outbound profiles for the Sales Hub Dialer. For detailed documentation, refer to the following articles:

- [Create inbound profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles#create-inbound-profiles)
- [Create outbound profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles#create-outbound-profiles)
- [Default profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles#default-profiles)

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Create an inbound profile

1. Open the Sales Hub app, and select **Change area** > **Sales Hub Dialer settings**.
1. Select **Outbound and inbound profiles**, select **New profile**.
1. On the **Profile Settings** tab, enter a **Profile Name**, set **Profile Type** to **Inbound**, and select **Next**.
1. On the **Inbound Info** tab, set **Queue** to **Default voice queue** and **Capacity** to **Default voice inbound** (or your custom capacity profile), then select **Next**.
1. On the **Inbound Behaviors** tab, configure the **Language**, **Consult**, and **Transfer** settings. To enable consult and transfer with Teams users or external phone numbers, turn on the corresponding options. Select **Next**.
1. On the **Summary** page, verify the settings and select **Save and Close**.

## Create an outbound profile

Follow the same steps as for an inbound profile, but set **Profile Type** to **Outbound** in step 4.

> [!NOTE]
> The number assigned to an outbound profile will be the default number and this number CANNOT be assigned to another seller. 


## Ensure profile consistency

For call routing to work correctly with custom profiles, ensure consistency across all three configuration areas:

- The seller must be assigned to the capacity profile under its **Users** tab.
- The same seller must be assigned to the inbound profile, outbound profile, or both under its **Phone number** tab.
- The same capacity profile must be linked to the inbound and outbound profile.

This consistency is not required for default profiles, which serve as an automatic fallback for all users.

## When to create additional profiles

- **Customized call handling** — If different consult and transfer settings are needed for different business units.
- **Geographic segmentation** — If different groups of sellers require language-specific greetings or regional settings.

## Next step

> [!div class="nextstepaction"]
> [Assign phone numbers to sellers](sales-hub-dialer-assign-numbers.md)

## Related information

- [Enable and configure the Sales Hub Dialer](configure-sales-hub-dialer.md)
- [Configure outbound and inbound profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles)
