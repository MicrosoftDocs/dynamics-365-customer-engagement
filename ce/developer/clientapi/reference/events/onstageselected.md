---
title: "OnStageSelected Event (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 89123cde-7c66-4c7d-94e4-e287285019f8
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# OnStageSelected Event (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

This event occurs when a stage of a business process flow control is selected. You can’t cancel the stage selection using code in a handler for this event.

You can use the getEventArgs function to retrieve an object that has the following methods:

getStage: Returns a stage object representing the selected stage. More information: Stage methods.

## Methods supported for this event
- **formContext.data.process**.[addOnStageSelected](../formcontext-data-process/processmanager/addOnStageSelected.md) method to add event handlers for this event.
- **formContext.data.process**.[removeOnStageSelected](../formcontext-data-process/processmanager/addOnStageSelected.md) method to remove event handlers for this event. 



