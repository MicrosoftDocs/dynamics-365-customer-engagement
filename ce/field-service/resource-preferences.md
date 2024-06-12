---
title: Preferred resources for requirements
description: Learn about how you can restrict the resources that are matched to a requirement in Dynamics 365 Field Service.
ms.date: 06/11/2024
ms.topic: conceptual
author: ryanchen8
ms.author: chenryan
ms.custom: bap-template
---

# Preferred resources for requirements

Adding preferred resources to a requirement applies restrictions on which resources are matched to a requirement when scheduling with the schedule assistant or when using Resource Scheduling Optimization.

To add, change, or remove preferred resources, open a resource requirement, and go to the **Related** > **Resource Preferences** tab.

For each resource added, define a **Preference Type**:

- **Preferred**: The [schedule assistant](schedule-assistant.md) displays preferred resources first in the Gantt view if they match all other requirements and filters. It also shows a heart icon next to their name.

- **Restricted**: The [schedule assistant](schedule-assistant.md) filters out any resources that are marked as restricted. The filter can be removed using the filter panel.

- **Must choose from**: The [schedule assistant](schedule-assistant.md) filters results to only these resources. If none of the resources are available, schedule assistant doesn't return any results. The filter can be removed using the filter panel.

## Preferred resources with Resource Scheduling Optimization

For [Resource Scheduling Optimization](./rso-overview.md) to consider preferred resources, add the **Maximize Preferred Resources** objective to the optimization goal. Resource scheduling optimization attempts to match **Preferred** resources, always selects **Must choose from** resources, and never selects **Restricted** resources.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
