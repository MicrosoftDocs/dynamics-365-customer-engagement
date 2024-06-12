---
title: Add preferred resources for a requirement
description: Learn about how you can restrict the resources that are matched to a requirement in Dynamics 365 Field Service.
ms.date: 06/11/2024
ms.topic: conceptual
author: ryanchen8
ms.author: chenryan
ms.custom: bap-template
---

# Add preferred resources for a requirement

Add preferred resources to a requirement to apply restrictions on resource matches when scheduling with the schedule assistant or Resource Scheduling Optimization. The **Preference Type** determines how the resources match. You can add, change, or remove preferred resources.

1. In Field Service, select the **Service** area. Under **Scheduling**, select **Resource Requirements**.

1. Open a resource requirement, and select **Related** > **Resource Preferences**.

1. For each resource, define a **Preference Type**:

   - **Preferred**: The [schedule assistant](schedule-assistant.md) displays preferred resources first in the Gantt view if they match all other requirements and filters. It also shows a heart icon next to their name.

   - **Restricted**: The [schedule assistant](schedule-assistant.md) filters out any resources that are marked as restricted. The filter can be removed using the filter panel.

   - **Must choose from**: The [schedule assistant](schedule-assistant.md) filters results to only these resources. If none of the resources are available, schedule assistant doesn't return any results. The filter can be removed using the filter panel.

1. Select **Save & Close**.

## Use preferred resources with Resource Scheduling Optimization

To consider preferred resources for [Resource Scheduling Optimization](./rso-overview.md), add the **Maximize Preferred Resources** objective to the optimization goal. Resource scheduling optimization attempts to match **Preferred** resources, always selects **Must choose from** resources, and never selects **Restricted** resources.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
