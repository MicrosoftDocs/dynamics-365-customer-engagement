---
title: "formContext.data.process (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about working with processes in Customer Engagement using client API."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 32e8d1d0-4093-4588-a517-2930eec34dce
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# formContext.data.process (Client API reference)

[!INCLUDE[](../../../includes/cc_applies_to_update_9_0_0.md)]

> [!NOTE]
> ![This section is under construction. Check back soon!](../../../media/under_construction.png "Coming soon") [!INCLUDE[cc-under-construction](../../../includes/cc-under-construction.md)]

Provides events, methods, and objects to interact with the business process flow data in a form.

## Process methods 

A process contains the data for a business process flow. Use the methods to access properties of the process.
|Name | Description |
|--|--|
|[getId](formcontext-data-process/process/getId.md)|[!INCLUDE[formcontext-data-process/process/includes/getId-description.md](formcontext-data-process/process/includes/getId-description.md)]|
|[getName](formcontext-data-process/process/getName.md)|[!INCLUDE[formcontext-data-process/process/includes/getName-description.md](formcontext-data-process/process/includes/getName-description.md)]|
|[getStages](formcontext-data-process/process/getStages.md)|[!INCLUDE[formcontext-data-process/process/includes/getStages-description.md](formcontext-data-process/process/includes/getStages-description.md)]|
|[isRendered](formcontext-data-process/process/isRendered.md)|[!INCLUDE[formcontext-data-process/process/includes/isRendered-description.md](formcontext-data-process/process/includes/isRendered-description.md)]|

## Stage methods 

A stage contains the data for a stage in a business process flow. Use the methods to access properties of the stage.
|Name | Description|
|--|--|
|[getCategory](formcontext-data-process/stage/getCategory.md)|[!INCLUDE[formcontext-data-process/stage/includes/getCategory-description.md](formcontext-data-process/stage/includes/getCategory-description.md)]|
|[getEntityName](formcontext-data-process/stage/getEntityName.md)|[!INCLUDE[formcontext-data-process/stage/includes/getEntityName-description.md](formcontext-data-process/stage/includes/getEntityName-description.md)]|
|[getId](formcontext-data-process/stage/getId.md)|[!INCLUDE[formcontext-data-process/stage/includes/getId-description.md](formcontext-data-process/stage/includes/getId-description.md)]|
|[getName](formcontext-data-process/stage/getName.md)|[!INCLUDE[formcontext-data-process/stage/includes/getName-description.md](formcontext-data-process/stage/includes/getName-description.md)]|
|[getName](formcontext-data-process/stage/getName.md)|[!INCLUDE[formcontext-data-process/stage/includes/getName-description.md](formcontext-data-process/stage/includes/getName-description.md)]|
|[getStatus](formcontext-data-process/stage/getStatus.md)|[!INCLUDE[formcontext-data-process/stage/includes/getStatus-description.md](formcontext-data-process/stage/includes/getStatus-description.md)]|
|[getSteps](formcontext-data-process/stage/getSteps.md)|[!INCLUDE[formcontext-data-process/stage/includes/getSteps-description.md](formcontext-data-process/stage/includes/getSteps-description.md)]|

## Step methods

A step contains the data for a step in a stage in a business process flow. Use the methods to access properties of the step.

|Name | Description|
|--|--|
|[getAttribute](formcontext-data-process/step/getAttribute.md)|[!INCLUDE[formcontext-data-process/step/includes/getAttribute-description.md](formcontext-data-process/step/includes/getAttribute-description.md)]|
|[getName](formcontext-data-process/step/getName.md)|[!INCLUDE[formcontext-data-process/step/includes/getName-description.md](formcontext-data-process/step/includes/getName-description.md)]|
|[getProgress](formcontext-data-process/step/getProgress.md)|[!INCLUDE[formcontext-data-process/step/includes/getProgress-description.md](formcontext-data-process/step/includes/getProgress-description.md)]|
|[isRequired](formcontext-data-process/step/isRequired.md)|[!INCLUDE[formcontext-data-process/step/includes/isRequired-description.md](formcontext-data-process/step/includes/isRequired-description.md)]|
|[setProgress](formcontext-data-process/step/setProgress.md)|[!INCLUDE[formcontext-data-process/step/includes/setProgress-description.md](formcontext-data-process/step/includes/setProgress-description.md)]|


### Related topics

[Understand Xrm object model](../understand-clientapi-object-model.md)

[Controls (Client API reference)](controls.md)




