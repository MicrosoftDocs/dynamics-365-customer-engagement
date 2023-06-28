---
title: Schedule work with multiple requirements using requirement groups
description: Learn about multi-resource scheduling with requirement groups in Dynamics 365 Field Service.
ms.date: 02/16/2023
ms.topic: how-to
ms.custom: bap-template
author: clearab
ms.author: anclear
---

# Schedule work with multiple requirements using requirement group

[!INCLUDE[multi-resource](../shared/urs/multi-resource-scheduling.md)]

## Requirement groups for field service scenarios

Requirement group templates are designed to work with [incident types](configure-incident-types.md). By associating a requirement group template to an incident type, a work order can automatically add requirement groups.

1. In Field Service, open the **Settings** area. Under **General**, select **Incident Types**.

1. Select an incident type, open the Related > Requirement Groups tab, and Select **New Incident Type Requirement Group**.

   > [!NOTE]
   > Incident types with characteristics can't relate to requirement group templates. Associate the characteristics with requirements in the group instead.

1. Enter a **Name** and choose a **Requirement Group Template** to associate the template with the incident type.

   :::image type="content" source="media/requirement-group-incident-type.png" alt-text="Screenshot of an incident type requirement group form in Field Service.":::

1. After saving the record, [add the incident type to a work order](configure-incident-types.md#add-an-incident-type-to-a-work-order).

You're now all set to book the work order.

> [!NOTE]
> When requirement groups perform onsite work, the schedule assistant looks for groups of resources that can arrive at the same time, not resources that can begin traveling at the same time.
  
## Next steps

- [Schedule a work order](schedule-work-order.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
