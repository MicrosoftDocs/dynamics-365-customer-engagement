---
title: Step 5:\ Assign phone numbers to sellers for the Sales Hub dialer
description: Learn how to assign dedicated phone numbers to sellers in Dynamics 365 Sales Hub using User Management or the phone number setup flow.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Step 5: Assign phone numbers to sellers for the Sales Hub dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

After phone numbers are synced to Dynamics 365, assign a dedicated number to each seller. You can use either the User Management page or the phone number setup flow.

> [!NOTE]
> Only geographic numbers can be assigned as direct calling numbers for sellers. Toll-free numbers can't be used for direct calling.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Assign via User Management

1. In **Copilot Service Admin Center**, go to **User Management** in the site map.
1. Under **Users**, select **Manage**.
1. Select the user to whom you want to assign a phone number.
1. On the user page, select the **Omnichannel** tab.
1. In the **Omnichannel Phone** field, select the phone number to assign, then save.

## Assign via the phone number setup flow

1. In **Copilot Service Admin Center**, go to **Channels** in the site map.
1. Under **Phone numbers**, select **Manage**.
1. If a phone number is ready for setup, a **Setup** banner appears at the top of the page. Select **Setup**.
1. In the dialog, select **Assign to user**.
1. Select the target user on the **Users** page.
1. On the user page, select the **Omnichannel** tab.
1. In the **Omnichannel Phone** field, select the phone number, then save.

Repeat for each seller who needs a dedicated number.

## Related content

- [Enable and configure the Sales Hub dialer](configure-sales-hub-dialer.md)
- [Understand call routing](sales-hub-dialer-call-routing.md)
