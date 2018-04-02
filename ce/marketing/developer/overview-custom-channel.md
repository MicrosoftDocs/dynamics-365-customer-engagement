---
title: "Overview of custom channel (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "A custom channel contains custom entities, workflow or plug-in containing your custom logic, and couple of web resources that help surface the custom channel as a “tile” in the customer journey designer."
ms.custom: ""
ms.date: 04/01/2018
ms.service: "crm-online"
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bb49dbc4-a893-496c-bbba-252763a9d82a
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Overview of custom channel

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

A custom channel contains custom entities, workflow or plug-in containing your custom logic, and couple of web resources that help surface the custom channel as a “tile” in the customer journey designer. All these components are bundled into a solution that can be imported into a Customer Engagement instance to enable custom channel.

The following illustration provides a high-level overview of the operation flow for a custom channel:  

![Custom channel flow](../media/marketing-custom-channel-flow.png) 

1. When a contact record, which has the compliance field set to allow using custom channels, goes through a customer journey, an instance (record) of the **Custom Channel Activity** (**msdyncrm_customerjourneycustomchannelactivity**) entity is automatically created. For example, for a segment of 50 contacts with 40 contacts enabled for custom channel, the customer journey would generate 40 records of the **Custom Channel Activity** entity. For information about the compliance field, see [Define the Tile XML file](configure-tile-custom-channel.md#define-the-tile-xml-file).
2. On creation of the entity instance, the custom business logic present in a partner-developed plug-in or workflow is triggered, and interacts with the external service to execute custom operations. For example, send a message to the external service and receive a response from the external service.
3. Activity execution feedback is processed through a custom action, **CustomChannelActivity CreateInteraction**, and the interactions are sent to Dynamics 365 for Customer Insights to enable analytics and triggers on the interactions. For example, one message could generate 3 interactions: sent, delivered, opened.
  
  
### See also 

[Workflows overview](../../customize/workflow-processes.md)

[Write plug-ins to extend business processes](../../developer/write-plugin-extend-business-processes.md)

[Web resources for Customer Engagement](../../developer/web-resources.md) 

[Dynamics 365 for Customer Insights](../../customer-insights/getstart.md)   