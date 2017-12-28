---
title: "Remove custom channel (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Provides information on how to uninstall/remove custom channel from your Dynamics 365 instance."
ms.custom: ""
ms.date: 01/05/2017
ms.service: "crm-online"
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9b170052-5300-4d69-af80-c81247c2fdab
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Remove custom channel

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[Pre-release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This step is typically performed by administrators of your Dynamics 365 instance.

The custom channel app is a [managed solution](../../developer/introduction-solutions.md#unmanaged-and-managed-solutions) that is installed in your Dynamics 365 instance. To remove the custom channel app, you will have to delete the managed solution for the custom channel app. More information: [Uninstall or delete a solution](../../developer/uninstall-delete-solution.md)

However, the solution component [dependency tracking](../../developer/dependency-tracking-solution-components.md) feature in Dynamics 365 for Customer Engagement *prevents* you from deleting a managed solution if any of the managed solution component is used by other components in a customization.

Hence, if you want to remove a custom channel app (solution) from your Dynamics 365 instance, you will first have to ensure that none of the components of the custom channel app are in use. This implies that before removing a custom channel app, you will have to remove the custom tile from your customer journeys, or delete the customer journeys containing the custom tile altogether. This includes journeys in any state: draft, live or even past journeys in stopped/expired state. The messages associated with the custom tile will automatically be deleted from the system once the custom channel app is removed.

### See also 

[Configure and use custom channel](configure-use-custom-channel.md)

[Introduction to solutions](../../developer/introduction-solutions.md)

[Work with solutions](../../developer/work-solutions.md)