---
title: Adding PowerApps components in Customer Service workspace 
description: Learn about adding the applicable PowerApps components to Case Management forms.
author: gandhamm 
ms.author: v-slaik
ms.reviewer: neeranelli 
ms.topic: how-to 
ms.date: 09/12/2024
ms.custom: bap-template 
---

# Adding PowerApp components to Case Management forms

You can use a collection of PowerApp components to customize your case management forms and add the additional functionalities that agents can use when handling cases in the Customer Service workspace.

> [!NOTE]
> The functionality of a PowerApps component is applicable to the availability of that feature in your Customer Service workspace app.

To view and use the default components available on the enhanced full case form, see [Enable enhanced case forms for multisession apps](case-enh-config.md).

The table below shows all the PowerApps components, along with other details, which are available for customizing your forms in the Customer Service workspace.

|Number|Component   | Description   | Entity   |  Additional actions| Additional information|
|------ |----------|-----------|----------|-----------|
| 1|**status reason transitions** | Allows agents to enter and update case status. | Available for all entities.| Not Applicable. | [Define status reason transitions for case management](define-status-reason-transitions-case-management.md)|
| 2| **Customer 360** | Displays the customer details for a case. | Available for all entities. | Applicable. | [Customer 360](add-display-components-to-case-form.md)| 
| 3| **Recent records** |  Displays the related customer records for a case. | Available for all entities. | Applicable. | [Customer 360](add-display-components-to-case-form.md) |
| 4| **AI suggestions** |  AI suggestions about similar cases that were previously resolved successfully help agents find the right solutions quickly, increase their productivity, and provide better and faster service. | Available for all entities.| Applicable. | [Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md) |
| 5| **case handling time widget** | Displays the case handling time widget on a case form. | Available for all entities.| Applicable. | [Configure case handling time widget to case forms](add-case-handling-time.md)| |


### Related information

[Add components to a form](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form).