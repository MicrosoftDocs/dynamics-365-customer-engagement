---
title: Get intelligent insights to improve sales
description: Seller insights provides sellers with valuable insights and workflows for customer engagement. 
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: overview 
ms.collection: get-started 
ms.date: 06/09/2023
ms.custom: bap-template 
---

# Get intelligent insights to improve seller effectiveness (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Seller insights provides sellers with valuable insights and workflows for customer engagement. These insights enable sellers to engage with customers efficiently, save time on information gathering, and increase productivity by focusing on tasks that matter.

Seller insights are generated based on data from custom insight models. These models are imported into Microsoft Dataverse to generate contextual and intelligent insights. Based on these insights, sellers can assign tasks, create activities, or establish connections with other sellers. For example, there is a risk with an account that is not engaged. The suggestions displayed for this account are:
- Engagement is low as number of activities are going down.
- Customer did not respond to the last email since 3 weeks.
- Negative intent detected in last call. Check call summary.

## How can I use the seller insights feature?

Depending on your role, you can use the seller insights feature as described in the following list:  

-	**System administrator or similar role**:
    -	Import your custom insights model and map the attributes with the **msdyn_salessuggestion** entity attributes. More information: [Import insights model into Dataverse](import-insights-model-into-dataverse.md)
    -	Enable the seller insights feature. More information: [Enable seller insights](enable-seller-insights.md)
    -	Configure who can use the seller insights feature. More information: [Manage access to view insights](manage-access-view-insights.md)
    -	Configure assignment rules to auto assign insights to sellers. More information: [Configure assignment rule to auto assign insights](configure-assignment-rule-auto-assign-insights.md)
-	**Sales manager, seller, or any other similar role**:  
    -	View insights on records.  
    -	Perform actions based on insights such as connecting a sequence, creating an activity, assigning to a seller, reassigning to self, and declining or closing.  
    More information: [View and work on seller insights](view-understand-insights.md)
    

