---
title: "Resource preferences in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn about resource preferences in Dynamics 365 Field Service
ms.date: 02/23/2023
ms.topic: conceptual
author: ryanchen8
ms.author: chenryan
search.app: 
  - D365CE
  - D365FS
---

# Resource preferences in Dynamics 365 Field Service

Resource preferences allow dispatchers to give preference to specific resources over others. Use resource preferences, for example, if a particular resource is familiar with a site they visited often. Or, if a person has a nut allergy and you want to make sure they don't get scheduled to service a peanut processing facility.

To add, change, or remove resource preferences, open a resource requirement and go to the **Related** > **Resource Preferences** tab.

<!--update all screenshots from SA-->

> [!div class="mx-imgBorder"]
> ![Screenshot of a list of resource preferences on a requirement.](./media/scheduling-resource-preference.png)

For each resource added as a resource preference, you can define a **Preference Type**.

## Preferred

The [schedule assistant](schedule-assistant.md) lists preferred resources first if they match all requirements and filters. It also shows a heart icon next to their name.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board, showing the heart icon next to a preferred resource.](./media/scheduling-resource-preference-preferred.png)

## Restricted

The [schedule assistant](schedule-assistant.md) won't show restricted resources and exclude them from the results, even if they match all other criteria.

Instead, the Restricted Resources filter lists the excluded resources. Dispatchers can override the filter settings as needed.

> [!div class="mx-imgBorder"]
> ![Screenshot highlighting restricted resources in the filter view.](./media/scheduling-resource-preference-restricted.png)

## Must choose from

The [schedule assistant](schedule-assistant.md) lists only resources that have a *Must choose from* type of resource preference on the requirement, given they meet all other criteria too.

> [!div class="mx-imgBorder"]
> ![Screenshot of a "Must choose from" resource](./media/scheduling-resource-preference-must-choose-from.png)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
