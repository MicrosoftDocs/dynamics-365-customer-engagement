---
title: "Microsoft.CIFramework (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0 | MicrosoftDocs"
description: "Includes reference information about the Microsoft.CIFramework JavaScript API Reference for Dynamics 365 Channel Integration Framework 1.0."
ms.date: 03/14/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Microsoft.CIFramework methods (Dynamics 365 Channel Integration Framework 1.0 JavaScript API reference)

Microsoft CIFramework provides methods to use JavaScript API to manage the communication panel, records, and forms in the Dynamics 365 model-driven app.

> [!Important]
> - The [CIFInitDone event handler](events/cifinitdone.md) must be invoked before calling the other APIs.
> - The time-out limit for the APIs is 10 seconds. If the APIs don't run within 10 seconds, they must be run again with changed parameters or scope.

## Communication panel management APIs

The communication panel is where you, as an agent, interact with the customer. Partner widgets built using Channel Integration Framework 1.0 are loaded in this panel. The widget in this version is displayed to the right of the screen, and supports Docked and Minimized modes.

Use the following APIs to manage the state of the communication panel (widget).

| Methods | Description |
|---------|-------------|
| [setWidth](microsoft-ciframework/setWidth.md) | [!INCLUDE[setWidth-description](microsoft-ciframework/includes/setWidth-description.md)] |
| [getWidth](microsoft-ciframework/getWidth.md) | [!INCLUDE[getWidth-description](microsoft-ciframework/includes/getWidth-description.md)] |
| [setMode](microsoft-ciframework/setMode.md) | [!INCLUDE[setMode-description](microsoft-ciframework/includes/setMode-description.md)] |
| [getMode](microsoft-ciframework/getMode.md) | [!INCLUDE[getMode-description](microsoft-ciframework/includes/setMode-description.md)] |

## CRUD operations APIs

Use the following APIs to perform CRUD operations on entity records.

| Methods | Description |
|---------|-------------|
| [createRecord](microsoft-ciframework/createRecord.md)| [!INCLUDE[createRecord-description](microsoft-ciframework/includes/createRecord-description.md)] |
| [retrieveRecord](microsoft-ciframework/retrieveRecord.md) | [!INCLUDE[retrieveRecord-description](microsoft-ciframework/includes/retrieveRecord-description.md)] |
| [updateRecord](microsoft-ciframework/updateRecord.md) | [!INCLUDE[updateRecord-description](microsoft-ciframework/includes/updateRecord-description.md)] |
| [deleteRecord](microsoft-ciframework/deleteRecord.md) | [!INCLUDE[deleteRecord-description](microsoft-ciframework/includes/deleteRecord-description.md)] |

## Miscellaneous methods

| Methods | Description |
|---------|-------------|
| [getEntityMetadata](microsoft-ciframework/getEntityMetadata.md) | [!INCLUDE[getEntityMetadata-description](microsoft-ciframework/includes/getEntityMetadata-description.md)] |
| [setClickToAct](microsoft-ciframework/setClickToAct.md) | [!INCLUDE[setClickToAct-description](microsoft-ciframework/includes/setClickToAct-description.md)] |
| [getClickToAct](microsoft-ciframework/getClickToAct.md) | [!INCLUDE[getClickToAct-description](microsoft-ciframework/includes/getClickToAct-description.md)] |
| [searchAndOpenRecords](microsoft-ciframework/searchAndOpenRecords.md) | [!INCLUDE[searchAndOpenRecords-description](microsoft-ciframework/includes/searchAndOpenRecords-description.md)] |
| [getEnvironment](microsoft-ciframework/getEnvironment.md) | [!INCLUDE[getEnvironment-description](microsoft-ciframework/includes/getEnvironment-description.md)] |
| [openForm](microsoft-ciframework/openForm.md) | [!INCLUDE[openForm-description](microsoft-ciframework/includes/openForm-description.md)] |
| [renderSearchPage](microsoft-ciframework/renderSearchPage.md)| [!INCLUDE[openForm-description](microsoft-ciframework/includes/renderSearchPage-description.md)] |
| [addHandler](microsoft-ciframework/addHandler.md) | [!INCLUDE[addHandler-description](microsoft-ciframework/includes/addHandler-description.md)] |
| [removeHandler](microsoft-ciframework/removeHandler.md) | [!INCLUDE[removeHandler-description](microsoft-ciframework/includes/removeHandler-description.md)] |
| [raiseEvent](microsoft-ciframework/raiseEvent.md) | [!INCLUDE[raiseEvent-description](microsoft-ciframework/includes/raiseEvent-description.md)] |
| [updateContext](microsoft-ciframework/updateContext.md) | This method allows you to set the automation dictionary. |

### See also

[What's new in Dynamics 365 Channel Integration Framework](../whats-new-channel-integration-framework.md)  
[System requirements of Dynamics 365 Channel Integration Framework 1.0](../system-requirements-channel-integration-framework.md)  

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
