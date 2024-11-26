---
title: Microsoft.CIFramework (JavaScript API Reference) for Channel Integration Framework 2.0
description: Includes reference information about the Microsoft.CIFramework JavaScript methods for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 02/07/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Microsoft.CIFramework methods (JavaScript API reference) for Dynamics 365 Channel Integration Framework 2.0

Microsoft CIFramework provides methods to use JavaScript API to manage the communication panel (widget), notification, application tab, sessions, records, and forms in the Dynamics 365 model-driven app.

> [!Important]
> - The APIs are supported only from the active channel providers configured in your organization.
> - The [CIFInitDone event handler](../../../v1/develop/reference/events/cifinitdone.md) must be invoked before calling the other APIs.
> - The time-out limit for the APIs is 100 seconds. If the APIs don't run within 100 seconds, they must be run again with changed parameters or scope.

## Communication panel management APIs

The communication panel is where you as an agent interact with the customer. Partner widgets built using Channel Integration Framework 2.0 are loaded in this panel. The widget in this version is displayed to the left of the session panel and supports Docked, Minimized, and Hidden modes.

Use the following APIs to manage the state of the communication panel (widget).

| Methods | Description |
|---------|-------------|
| [setWidth](../../../v1/develop/reference/microsoft-ciframework/setWidth.md) | [!INCLUDE[setWidth-description](../../../v1/develop/reference/microsoft-ciframework/Includes/setWidth-description.md)] |
| [getWidth](../../../v1/develop/reference/microsoft-ciframework/getWidth.md) | [!INCLUDE[getWidth-description](../../../v1/develop/reference/microsoft-ciframework/Includes/getWidth-description.md)] |
| [setMode](../../../v1/develop/reference/microsoft-ciframework/setMode.md) | [!INCLUDE[setMode-description](../../../v1/develop/reference/microsoft-ciframework/Includes/setMode-description.md)] |
| [getMode](../../../v1/develop/reference/microsoft-ciframework/getMode.md) | [!INCLUDE[getMode-description](../../../v1/develop/reference/microsoft-ciframework/Includes/setMode-description.md)] |

## CRUD operations APIs

Use the following APIs to perform CRUD operations on entity records.

| Methods | Description |
|---------|-------------|
| [createRecord](../../../v1/develop/reference/microsoft-ciframework/createRecord.md)| [!INCLUDE[createRecord-description](../../../v1/develop/reference/microsoft-ciframework/Includes/createRecord-description.md)] |
| [retrieveRecord](../../../v1/develop/reference/microsoft-ciframework/retrieveRecord.md) | [!INCLUDE[retrieveRecord-description](../../../v1/develop/reference/microsoft-ciframework/Includes/retrieveRecord-description.md)] |
| [updateRecord](../../../v1/develop/reference/microsoft-ciframework/updateRecord.md) | [!INCLUDE[updateRecord-description](../../../v1/develop/reference/microsoft-ciframework/Includes/updateRecord-description.md)] |
| [deleteRecord](../../../v1/develop/reference/microsoft-ciframework/deleteRecord.md) | [!INCLUDE[deleteRecord-description](../../../v1/develop/reference/microsoft-ciframework/Includes/deleteRecord-description.md)] |

## Notification management APIs

Use the following APIs to display or cancel notifications about incoming conversations.

| Methods | Description |
|---------|-------------|
| [notifyEvent](microsoft-ciframework/notifyevent.md)| Displays a notification that can be used to inform agent about an incoming conversation. |
| [cancelEvent](microsoft-ciframework/cancelEvent.md)| Hides or cancels a notification based on the cancellation token, as specified in the `notifyEvent` method. |

## Application tab management APIs

Use the following APIs to create and manage the state of an application tab.

| Methods | Description |
|---------|-------------|
| [createTab](microsoft-ciframework/createtab.md) | Creates a tab in a focused session and returns the unique identifier of the created tab. |
| [getTabs](microsoft-ciframework/gettabs.md) | Returns an array of tab identifiers associated with template name or template tags for tabs in the session in focus, if the session belongs to the channel provider.|
| [focusTab](microsoft-ciframework/focustab.md) | Sets the focus on a tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.|
| [getFocusedTab](microsoft-ciframework/getfocusedtab.md) | Returns the tab identifier in a focused session, if the session belongs to the provider.|
| [refreshTab](microsoft-ciframework/refreshtab.md) | Refreshes the tab. |
| [setTabTitle](microsoft-ciframework/settabtitle.md) | Sets the title of the tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.|
| [closeTab](microsoft-ciframework/closeTab.md) | Closes the specified tab in the current session. |

## Session management APIs

Use the following APIs to manage sessions in a multisession provider environment.

| Methods | Description |
|---------|-------------|
| [canCreateSession](microsoft-ciframework/cancreatesession.md) | Allows you to check if a new session can be created. |
| [createSession](microsoft-ciframework/createsession.md) | Creates a session based on the session template defined as part of the template and returns the unique identifier of the session that was created. |
| [getSession](microsoft-ciframework/getsession.md) | Returns an object containing the unique identifier of the session, context, and the value of `isFocused` parameter, if the session belongs to the channel provider. |
| [getFocusedSession](microsoft-ciframework/getfocusedsession.md) | Returns the unique identifier of the session that is in focus, if it belongs to the channel provider else returns null. |
| [getAllSessions](microsoft-ciframework/getallsessions.md) | Returns the array of session identifiers for a channel provider. |
| [setSessionTitle](microsoft-ciframework/setsessiontitle.md) | Sets the session title, if the session belongs to the channel provider. |
| [requestFocusSession](microsoft-ciframework/requestfocussession.md) | Sets the focus on the session whose session identifier is passed as a parameter, if the session belongs to the channel provider. |

## Channel analytics APIs

Use the following APIs to track event analytics.

| Methods | Description |
|---------|-------------|
| [logAnalyticsEvent](microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events.|

## Session indicator APIs

Use the following APIs to indicate a key performance indicator (KPI) breach and to update the number of new activities in a particular session.

| Methods | Description |
|---------|-------------|
| [notifyKpiBreach](microsoft-ciframework/notifyKPIBreach.md) | This method is used to indicate a KPI breach. When this method is used, a red circle appears on the display image of the contact when a KPI breach has occurred.|
| [notifyNewActivity](microsoft-ciframework/notifyNewActivity.md) | This method is used to update the number of new activities in a particular session.|

## Presence APIs

Use these APIs to set and retrieve the Omnichannel agent presence programmatically. You can use these methods when a blended agent is working on a third-party application with omnichannel, and you want to synchronize the presence states between different applications to ensure that agent capacity is optimally utilized.

| Methods | Description |
|---------|-------------|
| [setPresence​](microsoft-ciframework/setPresence.md) | Allows presence to be set programmatically for the agent in the client session​. |
| [getPresence​](microsoft-ciframework/getPresence.md) | Allows presence to be returned programmatically for the agent in the client session​. |

## Miscellaneous methods

| Methods | Description |
|---------|-------------|
| [getEntityMetadata](../../../v1/develop/reference/microsoft-ciframework/getEntityMetadata.md) | [!INCLUDE[getEntityMetadata-description](../../../v1/develop/reference/microsoft-ciframework/Includes/getEntityMetadata-description.md)] |
| [setClickToAct](../../../v1/develop/reference/microsoft-ciframework/setClickToAct.md) | [!INCLUDE[setClickToAct-description](../../../v1/develop/reference/microsoft-ciframework/Includes/setClickToAct-description.md)] |
| [getClickToAct](../../../v1/develop/reference/microsoft-ciframework/getClickToAct.md) | [!INCLUDE[getClickToAct-description](../../../v1/develop/reference/microsoft-ciframework/Includes/getClickToAct-description.md)] |
| [searchAndOpenRecords](../../../v1/develop/reference/microsoft-ciframework/searchAndOpenRecords.md) | [!INCLUDE[searchAndOpenRecords-description](../../../v1/develop/reference/microsoft-ciframework/Includes/searchAndOpenRecords-description.md)] |
| [getEnvironment](../../../v1/develop/reference/microsoft-ciframework/getEnvironment.md) | [!INCLUDE[getEnvironment-description](../../../v1/develop/reference/microsoft-ciframework/Includes/getEnvironment-description.md)] |
| [openForm](../../../v1/develop/reference/microsoft-ciframework/openForm.md) | [!INCLUDE[openForm-description](../../../v1/develop/reference/microsoft-ciframework/Includes/openForm-description.md)] |
| [renderSearchPage](../../../v1/develop/reference/microsoft-ciframework/renderSearchPage.md)| [!INCLUDE[openForm-description](../../../v1/develop/reference/microsoft-ciframework/Includes/renderSearchPage-description.md)] |
| [addHandler](../../../v1/develop/reference/microsoft-ciframework/addHandler.md) | [!INCLUDE[addHandler-description](../../../v1/develop/reference/microsoft-ciframework/Includes/addHandler-description.md)] |
| [removeHandler](../../../v1/develop/reference/microsoft-ciframework/removeHandler.md) | [!INCLUDE[removeHandler-description](../../../v1/develop/reference/microsoft-ciframework/Includes/removeHandler-description.md)] |
| [raiseEvent](../../../v1/develop/reference/microsoft-ciframework/raiseEvent.md) | [!INCLUDE[raiseEvent-description](../../../v1/develop/reference/microsoft-ciframework/Includes/raiseEvent-description.md)] |
| [updateContext](microsoft-ciframework/updateContext.md) | This method allows you to set the automation dictionary. |
| [updateConversation](microsoft-ciframework/updateConversation.md) | This method allows you to update a conversation record. |

### See also

[What's new in Dynamics 365 Channel Integration Framework](../../../whats-new-channel-integration-framework.md)  
[System requirements for Dynamics 365 Channel Integration Framework 2.0](../../administer/system-requirements-channel-integration-framework-v2.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
