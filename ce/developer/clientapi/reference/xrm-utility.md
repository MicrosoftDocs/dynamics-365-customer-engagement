---
title: "Xrm.Utility (Client API reference)| MicrosoftDocs"
ms.date: 11/10/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: c044f7b8-7803-45fb-b99c-df01800c3b2a
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Xrm.Utility (Client API reference)

[!INCLUDE[](../../../includes/cc_applies_to_update_9_0_0.md)]

Provides a container for useful methods.

## Methods 

|                                   Method                                    |                                                                    Description                                                                     |
|-----------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------|
|       [closeProgressIndicator](xrm-utility/closeProgressIndicator.md)       |       [!INCLUDE[./xrm-utility/includes/closeProgressIndicator-description.md](./xrm-utility/includes/closeProgressIndicator-description.md)]       |
|  [getAllowedStatusTransitions](xrm-utility/getAllowedStatusTransitions.md)  |  [!INCLUDE[./xrm-utility/includes/getAllowedStatusTransitions-description.md](./xrm-utility/includes/getAllowedStatusTransitions-description.md)]  |
|            [getEntityMetadata](xrm-utility/getEntityMetadata.md)            |            [!INCLUDE[./xrm-utility/includes/getEntityMetadata-description.md](./xrm-utility/includes/getEntityMetadata-description.md)]            |
|             [getGlobalContext](xrm-utility/getGlobalContext.md)             |             [!INCLUDE[./xrm-utility/includes/getGlobalContext-description.md](./xrm-utility/includes/getGlobalContext-description.md)]             |
| [getLearningPathAttributeName](xrm-utility/getLearningPathAttributeName.md) | [!INCLUDE[./xrm-utility/includes/getLearningPathAttributeName-description.md](./xrm-utility/includes/getLearningPathAttributeName-description.md)] |
|            [getResourceString](xrm-utility/getResourceString.md)            |            [!INCLUDE[./xrm-utility/includes/getResourceString-description.md](./xrm-utility/includes/getResourceString-description.md)]            |
|          [invokeProcessAction](xrm-utility/invokeProcessAction.md)          |          [!INCLUDE[./xrm-utility/includes/invokeProcessAction-description.md](./xrm-utility/includes/invokeProcessAction-description.md)]          |
|                [lookupObjects](xrm-utility/lookupObjects.md)                |                [!INCLUDE[./xrm-utility/includes/lookupObjects-description.md](./xrm-utility/includes/lookupObjects-description.md)]                |
|            [refreshParentGrid](xrm-utility/refreshParentGrid.md)            |            [!INCLUDE[./xrm-utility/includes/refreshParentGrid-description.md](./xrm-utility/includes/refreshParentGrid-description.md)]            |
|        [showProgressIndicator](xrm-utility/showProgressIndicator.md)        |        [!INCLUDE[./xrm-utility/includes/showProgressIndicator-description.md](./xrm-utility/includes/showProgressIndicator-description.md)]        |

## Deprecated methods

The following table lists the new methods you should use instead of the deprecated methods in the **Xrm.Utility** namespace. These methods were deprecated in [!INCLUDE[pn_crm_9_0_0_online](../../../includes/pn-crm-9-0-0-online.md)].

|Deprecated Method |New method to be used | 
|-------------|-------------|
|Xrm.Utility.alertDialog|Xrm.Navigation.[openAlertDialog](Xrm-Navigation/openAlertDialog.md)|
|Xrm.Utility.confirmDialog|Xrm.Navigation.[openConfirmDialog](Xrm-Navigation/openConfirmDialog.md)|
|Xrm.Utility.getBarcodeValue|Xrm.Device.[getBarcodeValue](Xrm-Device/getBarcodeValue.md)|
|Xrm.Utility.getCurrentPosition|Xrm.Device.[getCurrentPosition](Xrm-Device/getCurrentPosition.md)|
|Xrm.Utility.openEntityForm|Xrm.Navigation.[openForm](Xrm-Navigation/openForm.md)|
|Xrm.Utility.openQuickCreate|Xrm.Navigation.[openForm](Xrm-Navigation/openForm.md)|
|Xrm.Utility.openWebResource|Xrm.Navigation.[openWebResource](Xrm-Navigation/openWebResource.md)|

More information: [Deprecated client APIs](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming#some-client-apis-are-deprecated)

### Related topics

[Client API execution context](../clientapi-execution-context.md)

[Client API Xrm object](../clientapi-xrm.md)

[Client API reference](../reference.md)

