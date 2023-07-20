---
title: Get intelligent insights to improve sales
description: Seller insights provide sellers with valuable insights and workflows for customer engagement.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: overview 
ms.collection: get-started 
ms.date: 06/09/2023
ms.custom: bap-template 
---

# Get intelligent insights to improve sales (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Seller insights provide sellers with valuable insights and workflows for customer engagement. Therefore, sellers can efficiently engage with customers, save time on information gathering, and increase productivity by focusing on tasks that matter.

Seller insights are generated based on data from custom insights models. These models are imported into Dataverse and used to generate contextual and intelligent insights. Based on these insights, sellers can assign tasks, create activities, and establish connections with other sellers. For example, if there is risk from an account that isn't well engaged, the following suggestions might be displayed for the account:

- Engagement is low as number of activities are going down.
- Customer didn't respond to the last email since 3 weeks.
- Negative intent detected in last call. Check call summary.

## How can I use the seller insights feature?

Depending on your role, you can use the seller insights feature in the following ways:

- **System administrator or a similar role**:

    - Import your custom insights model, and map the attributes with the `msdyn_salessuggestion` entity attributes. For more information, go to [Import an insights model into Dataverse](import-insights-model-into-dataverse.md).
    - Enable the seller insights feature. For more information, go to [Enable seller insights](enable-seller-insights.md).
    - Configure who can use the seller insights feature. For more information, go to [Manage access to view insights](manage-access-view-insights.md).
    - Configure assignment rules to automatically assign insights to sellers. For more information, go to [Configure assignment rules to automatically assign insights](configure-assignment-rule-auto-assign-insights.md).

- **Sales manager, seller, or any other similar role**:

    - View insights on records.
    - Perform actions based on insights. These actions include connecting a sequence, creating an activity, assigning an insight to a seller, reassigning an insight to yourself, and declining or closing an insight.

    For more information, go to [View and work on seller insights](view-understand-insights.md).
