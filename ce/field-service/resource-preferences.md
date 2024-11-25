---
title: Add preferred resources for a requirement
description: Learn how you can restrict the resources that are matched to a requirement in Dynamics 365 Field Service.
ms.date: 06/11/2024
ms.topic: conceptual
author: ryanchen8
ms.author: chenryan
ms.custom: bap-template
---

# Add preferred resources for a requirement

Add preferred resources to a requirement to apply restrictions on resource matches when you use the schedule assistant or Resource Scheduling Optimization for scheduling. The **Preference Type** field determines how the resources are matched. You can add, change, or remove preferred resources.

1. In Dynamics 365 Field Service, select the **Service** area.
1. Under **Scheduling**, select **Resource Requirements**.
1. Open a resource requirement, and select **Related** > **Resource Preferences**.
1. For each resource, define a preference type:

    - *Preferred*: The [schedule assistant](schedule-assistant.md) shows preferred resources first in the Gantt view if they match all other requirements and filters. It also shows a heart icon next to the name of each preferred resource.
    - *Restricted*: The [schedule assistant](schedule-assistant.md) filters out any resources that are marked as restricted. The filter can be removed by using the filter pane.
    - *Must choose from*: The [schedule assistant](schedule-assistant.md) filters results so that they include only these resources. If none of the resources are available, the schedule assistant doesn't return any results. The filter can be removed by using the filter pane.

1. Select **Save & Close**.

## Use preferred resources with Resource Scheduling Optimization

If you want [Resource Scheduling Optimization](./rso-overview.md) to consider preferred resources, add the *Maximize Preferred Resources* objective to the optimization goal. Resource Scheduling Optimization then tries to match *Preferred* resources, it always selects *Must choose from* resources, and it never selects *Restricted* resources.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
