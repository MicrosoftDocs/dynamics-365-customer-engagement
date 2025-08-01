---
title: Configure the ability for users to join existing connected chats
description: Learn how to configure the ability for users to join existing connected chats.
ms.date: 07/17/2025
ms.topic: how-to
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
ms.reviewer: shjais 
---

# Configure the ability for users to join chats

Configure the ability for users to join existing connected chats.

## Turn on join chat

As an administrator, you can enable users to view and easily join chats that are connected to records they have write access to, even if they weren't originally part of those chats. You can configure the ability for users to join connected chats at a record-type level. This functionality can help you tailor the user experience for your business processes.

> [!NOTE]
> The join chat feature only works for connected chats, and it's on by default only for the case record type. For other record types, you must enable it.

The ability for users to join existing chats is especially useful for the following scenarios:

- **Opportunity or lead transfers**: If a new seller has onboarded to an opportunity or a lead that was previously handled by another seller, they can join existing connected chats to better understand the context and continue to collaborate with their relevant colleagues.
- **Sales manager scenario**: A subject-matter expert can read and participate in the relevant conversations.

**To turn on the join chat capability for a record type**:

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png) in the lower-left corner, and then select **App Settings**.

2. Under **General Settings**, select **Chat and collaborate**.

3. Under **Connect chats to Dynamics 365 records**, select the record type (for example, Lead).

4. In the settings panel, turn on the **Join chat** toggle.

    :::image type="content" source="media/lead-configure-join-chat.png" alt-text="Settings page for turning the join chat feature on or off.":::

4. Select **Save**.

## Related information

[Enable or disable Microsoft Teams chat in Sales Hub](enable-teams-chat.md)   
[Join an existing connected chat](join-chat.md)
