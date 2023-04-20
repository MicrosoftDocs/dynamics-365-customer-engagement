---
title: Choose preferred resources for requirements
description: Learn about how you can restrict the resources that will be matched to a requirement in Dynamics 365 Field Service.
ms.date: 02/23/2023
ms.topic: conceptual
author: ryanchen8
ms.author: chenryan
---

# Choose preferred resources for requirements

Adding preferred resources to a requirement applies restrictions on which resources will be matched to a requirement when scheduling with the schedule assistant or when using Resource Scheduling Optimization.

To add, change, or remove preferred resources, open a resource requirement and go to the **Related** > **Resource Preferences** tab.

For each resource added you can define a **Preference Type**.

## Preferred

The [schedule assistant](schedule-assistant.md) displays preferred resources first in the Gantt view if they match all other requirements and filters. It also shows a heart icon next to their name.

## Restricted

The [schedule assistant](schedule-assistant.md) will filter out any resources that have been marked as restricted. The filter can be removed using the filter panel.

## Must choose from

The [schedule assistant](schedule-assistant.md) will filter results to only these resources. If none of the resources are available, schedule assistant won't return any results. The filter can be removed using the filter panel.

## Using preferred resources with Resource Scheduling Optimization

For [Resource Scheduling Optimization](./rso-overview.md) to consider preferred resources, add the **Maximize Preferred Resources** objective to the optimization goal. Resource scheduling optimization will attempt to match **Preferred** resources, always select **Must choose from** resources, and never select **Restricted** resources.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
