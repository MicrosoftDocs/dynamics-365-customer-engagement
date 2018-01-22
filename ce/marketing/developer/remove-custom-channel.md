---
title: "Remove custom channel (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Provides information on how to uninstall/remove custom channel from your Dynamics 365 instance."
ms.custom: ""
ms.date: 01/10/2018
ms.service: "crm-online"
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9b170052-5300-4d69-af80-c81247c2fdab
author: "KumarVivek"
ms.author: "kvivek"
robots: noindex,nofollow
manager: "amyla"
---
# Remove custom channel

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[Pre-release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This step is typically performed by administrators of your Dynamics 365 instance.

To remove a custom channel app from your Dynamics 365 instance, you will first have to ensure that none of the components of the custom channel app are in use. This implies that before removing a custom channel app, you will have to remove the custom tile from your customer journeys, or delete the customer journeys containing the custom tile altogether. This includes journeys in any state: draft, live or even past journeys in stopped/expired state. 

This is because the custom channel app is a [managed solution](../../developer/introduction-solutions.md#unmanaged-and-managed-solutions), and the solution component [dependency tracking](../../developer/dependency-tracking-solution-components.md) feature in Dynamics 365 for Customer Engagement *prevents* you from deleting a managed solution if any of the managed solution component is used by other components in a customization.

After you have taken care of the dependencies, delete the managed solution to remove the custom channel app from your Dynamics 365 instance. More information: [Uninstall or delete a solution](../../developer/uninstall-delete-solution.md)

If there are any customer journeys that still use one or more components of the custom channel app solution, you will receive the following error on deleting the custom channel app solution:

![](../media/error-delete-solution.png)

Review your customer journey records to identify the ones still using the custom tile, remove the custom tile from the customer journey or the customer journey record itself, and then retry deleting the custom channel app solution.
<!--
> [!NOTE]
> Any insights on customer journeys with a custom channel and custom messages will no longer be available after the custom channel is removed. Any interactions related to custom channel would still remain on contact’s timelines, and scores would remain unchanged. If a lead scoring model was based on custom channel interactions, the model can’t be edited further.-->

### See also 

[Configure and use custom channel](configure-use-custom-channel.md)

[Introduction to solutions](../../developer/introduction-solutions.md)

[Work with solutions](../../developer/work-solutions.md)