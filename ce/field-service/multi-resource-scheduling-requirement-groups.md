---
title: Schedule work with multiple requirements using requirement groups
description: Learn about multi-resource scheduling with requirement groups in Dynamics 365 Field Service.
ms.date: 11/19/2025
ms.topic: how-to
ms.custom: bap-template
author: mkelleher-msft
ms.author: mkelleher
---

# Schedule work with multiple requirements using requirement group

[!INCLUDE[multi-resource](../shared/urs/multi-resource-scheduling.md)]

## Requirement groups for field service scenarios

Requirement group templates work with [incident types](configure-incident-types.md). When you associate a requirement group template with an incident type, you automatically add requirement groups to work orders. Requirement groups can affect how quickly you can create work orders and work order incidents. The number of requirements in a requirement group determines the level of impact.

1. In Field Service, open the **Settings** area. Under **Work Orders**, select **Incident Types**.

1. Select an incident type, open the **Related** > **Requirement Groups** tab, and select **New Incident Type Requirement Group**.

   > [!NOTE]
   > Incident types with characteristics can't relate to requirement group templates. Instead, associate the characteristics with requirements in the group.

1. Enter a **Name** and choose a **Requirement Group Template** to associate the template with the incident type. Then select **Save and Close**.

   :::image type="content" source="media/requirement-group-incident-type.png" alt-text="Screenshot of an incident type requirement group form in Field Service.":::

1. After saving the record, [add the incident type to a work order](configure-incident-types.md#add-an-incident-type-to-a-work-order).

You can now book the work order.

> [!NOTE]
> When requirement groups perform onsite work, the schedule assistant looks for groups of resources that can arrive at the same time, not resources that can begin traveling at the same time.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
