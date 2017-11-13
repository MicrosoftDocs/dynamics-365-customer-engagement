---
title: "Client API grid context in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f884d7d4-31e6-4080-acd9-493e81e6b278
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Client API grid context

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The grid context object provides a reference to the grid or a subgrid on a form against which the current code is executed.

To get the **gridContext** object, you use the [formContext](clientapi-form-context.md) object to get an instance of the grid control. For example, when you know the name of a subgrid control (say **Contacts** subgrid in the default account form), you can access it using the following code:

`var gridContext = formContext.getControl("Contacts");`
 
For more information about methods and events available for grids and subgrids, see [Grids and subgrids](reference/grids.md).

## Related topics

[Client API form context](clientapi-form-context.md)

[Understand the Client API object model](understand-clientapi-object-model.md)

 

