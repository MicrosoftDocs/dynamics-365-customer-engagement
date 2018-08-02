---
title: "Step 2: Create a workflow or plug-in to implement your custom logic (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Partners can create a workflow or plug-in to implement their custom logic for a custom channel in Dynamics 365 for Marketing."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 30a97860-1369-400b-8931-5d070daea4f9
author: KumarVivek
ms.author: kvivek
manager: kvivek
---
# Step 2: Create a workflow or plug-in to implement your custom logic

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Partners can create a workflow or plug-in to implement their custom logic. For information about creating a workflow or plug-in, see:
- [Workflows overview](../../customize/workflow-processes.md) and [Automate your business processes in Customer Engagement](../../developer/automate-business-processes-customer-engagement.md)
- [Write plug-ins to extend business processes](../../developer/write-plugin-extend-business-processes.md)

The workflow or the plug-in should be configured to:

1. Execute on the creation of an instance of the **Custom Channel Activity** (**msdyncrm_customerjourneycustomchannelactivity**) entity. An instance of this entity is created whenever a contact, which has the compliance field set to allow use of custom channels, goes through the customer journey. For information about the compliance field, see [Define the Tile XML file](configure-tile-custom-channel.md#define-the-tile-xml-file).
2. Interact with the external service to perform the required operations. For example, in case of a Special custom channel, your custom code should be able to send messages using the external service provider and receive responses or feedback, if any.
3. Call the **Custom Channel Activity Create Interaction** action to send the customer journey feedback to Dynamics 365 for Customer Insights for further processing.
 
> [!div class="nextstepaction"]
> [Step 3: Configure the tile for custom channel](configure-tile-custom-channel.md)  
