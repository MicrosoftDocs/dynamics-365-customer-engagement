---
title: Configure custom presence
description: Learn to configure custom presence in Omnichannel for Customer Service.
ms.date: 03/03/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---
# Configure and manage custom presence

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The presence status indicates a customer service representative's (service representative or representative) availability to take up work items. A presence status consists of two elements:

- **Base status**: The base presence status that indicates a service representative's status. The work distribution system distributes work items to representatives according to the base statuses that you select as allowed presences at the time of creating a workstream. The base statuses are as follows:
  - Available
  - Busy
  - Busy-DND
  - Away
  - Offline

  You can select base statuses only in **Allowed Presences** when you're [creating a workstream](create-workstreams.md).

- **Presence text**: The text that is associated with a specific base status. This is the text that is visible to representatives.

You must specify a [default presence](users-user-profiles.md#manage-users-using-the-classic-experience) to representatives that is set when they sign in for work. If no default presence is defined, the application sets "Available" as the default.

## Out-of-the-box presence statuses

Omnichannel for Customer Service provides the following presence statuses out of the box:

- Available
- Away
- Busy
- Busy - DND
- Inactive
- Offline

The inactive presence isn't available for manual selection by the representatives. If the missed notifications feature is enabled, the representatives' status is changed to inactive when they don't respond to the incoming conversation request notification.

> [!div class=mx-imgBorder]
> ![Presence view.](../media/oc-presence-view.png)

> [!NOTE]
> You can't edit or delete these out-of-the-box base presence statuses.

## Create custom presence status

In addition to the out-of-box presence statuses, admins can configure custom presence statuses for representatives that must be mapped to a base presence. For example, if the representatives on your team want to attend a training, you can create a custom **Away – In Training** presence status. When you map a custom presence to a base presence, make sure that the configurations are logically viable. For example, if you map an available custom presence to offline base status, the application treats it as offline while the visual effect would be available.

1. In the site map of Customer Service admin center or Contact Center admin center, in **Agent experience**, select **Productivity**.
   
1. Select **Manage** for **Custom Presence**.

1. On the command bar, select **New** to create a presence record.

1. On the **Summary** tab, provide the following information:

    1. **Name**: Enter a name for the custom presence status.
    2. **Presence Text**: Enter presence text that should be associated with the new custom entity.
    3. **Base Status**: Select the most applicable base status in the list.
    4. **Description**: Enter a brief description of the custom presence record.

1. Select **Save**.

> [!div class=mx-imgBorder]
> ![custom presence.](../media/oc-custom-presence-example.png)

### Related information

[Manage presence in Omnichannel for Customer Service](../use/oc-manage-presence-status.md)  
[Manage a user in Omnichannel for Customer Service](users-user-profiles.md)  
[Understand and create workstreams](create-workstreams.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Presence API](../../channel-integration-framework/v2/develop/reference/microsoft-ciframework-v2.md#presence-apis)  
[User presence isn't loading](../troubleshoot-omnichannel-customer-service.md#user-presence-isnt-loading-or-user-is-shown-as-unknown)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
