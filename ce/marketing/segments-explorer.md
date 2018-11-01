---
title: "Design dynamic profile segments in explore view (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to use the explore view to construct segment clauses in Dynamics 365 for Marketing"
keywords: "segment; compound segment"
ms.date: 09/17/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 Version 9.x
ms.assetid: 71b263c7-98ac-4640-9fc8-83d177430397
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Use the explore view for designing dynamic profile segments

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

The **Explore** view provides a graphical map of the path you're creating when you are adding a query clause for a dynamic profile segment. It isn't available when you are working with an interaction segment. The **Explore** view provides an alternative to the [standard method for adding query clauses](segments-profile.md) to a dynamic profile segment, but the results are the same as when using the standard method. The explorer can sometimes help you visualize the database structure as you work. You are free to choose the method you prefer.

To use the explorer, select the **Explore** button when you want to add a clause to group on the **Definition** or **Flow** tab.

![The segment explorer](media/segment-explorer-example1.png "The segment explorer")

The map at the top of the explorer shows the entities that are available for use when creating segments. The map is updated as you build your query group to indicate which paths are still valid. It uses the following colors and line weights to indicate this:

- **Turquoise circle**: marks the target entity—all paths must end here (currently, always **Contact**).
- **Green circle**: marks the currently selected entity. The attributes belonging to this entity are listed below the map. Use the drop-down lists and input fields here to build a query that finds the records you want from the selected entity. After setting up a row, select **+** on the right side to add that expression to the query.
- **Blue circles**: mark entities that are not yet used, but are still available.
- **Gray circles**: mark entities that are no longer selectable because of settings you've already made for the current path.
- **Blue, bold lines**: mark paths that are not yet used, but are still available.
- **Gray, bold lines**: mark paths that are already part of the query.
- **Gray, thin lines**: mark paths that are no longer available because of settings you've already made.

Close the **Explore** view by selecting **OK**. Your resulting query is then shown in the **Designer**, just as though you had created it there.

For example, you might build a path as follows:

1. Start with the **Marketing List** entity to find a marketing list named **subscribers**.
1. Continue to the **Accounts** entity to find the accounts from that list, and find only companies working in the insurance industry.
1. End at the **Contacts** entity to find the contacts from those accounts, and find only contacts living in California.

Because the path ends with contacts, the result is a list of contacts who live in California and work for insurance companies that are on the **subscribers** list. (Many segment groups that you create will probably query the **Contacts** entity only, but even groups such as these might employ complex logic that combines multiple AND and OR clauses.)

The following image shows this example query midway through construction, where we're adding the account criterion. Note how the map colors indicate where you are, where you've been, and what you can (and can't) do next.

![The segment explorer map, showing progress](media/segment-explorer-example2.png "The segment explorer map, showing progress")

> [!NOTE]
> On adding the final **Contacts** entity to the expression we've been describing in this example, you'll be asked to choose which of the available paths to use.
> 
> ![The multiple-paths dialog](media/segment-explorer-multiple-paths.png "The multiple-paths dialog")
> 
> The correct one is **contact\_account\_accountid\__\<suffix\>_**, which establishes how the contact entity relates to the account entity.

### See also

[Working with segments](segmentation-lists-subscriptions.md)