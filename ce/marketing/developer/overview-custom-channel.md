---
title: "Overview of custom channel (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "A custom channel contains custom entities, workflow or plug-in containing your custom logic, and couple of web resources that help surface the custom channel as a “tile” in the customer journey designer."
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Overview of custom channel

A custom channel contains custom entities, workflows or plug-ins containing your custom logic, and a couple of web resources that help surface the custom channel as a “tile” in the customer journey designer. All these components are bundled into a solution that can be imported into a Dynamics 365 Marketing instance to enable a custom channel.

The following illustration provides a high-level overview of the operation flow for a custom channel:  

![Custom channel flow](../media/marketing-custom-channel-flow.png) 

1. When a contact record, which has the compliance field set to allow using custom channels, goes through a customer journey, an instance (record) of the **Custom Channel Activity** (**msdyncrm_customerjourneycustomchannelactivity**) entity is automatically created. For example, for a segment of 50 contacts with 40 contacts enabled for custom channel, the customer journey would generate 40 records of the **Custom Channel Activity** entity. For information about the compliance field, see [Define the Tile XML file](configure-tile-custom-channel.md#define-the-tile-xml-file).
2. On creation of the entity instance, the custom business logic present in a partner-developed plug-in or workflow is triggered, and interacts with the external service to execute custom operations. For example, send a message to the external service and receive a response from the external service.
3. Activity execution feedback is processed through a custom action, **CustomChannelActivity CreateInteraction**, and the interactions are sent to the marketing-insights service to enable analytics and triggers on the interactions. For example, one message could generate three interactions: sent, delivered, opened.
  
## See also 

[Workflows overview](../../customerengagement/on-premises/customize/workflow-processes.md)  
[Write plug-ins to extend business processes](/powerapps/developer/common-data-service/plug-ins)  
[Web resources in model-driven apps](/powerapps/developer/model-driven-apps/web-resources)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]