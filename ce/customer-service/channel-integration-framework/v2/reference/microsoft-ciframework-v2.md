---
title: "Microsoft.CIFramework (JavaScript API Reference) for Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information about the Microsoft.CIFramework JavaScript methods for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 11/18/2022
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
> - The [CIFInitDone event handler](events/cifinitdone.md) must be invoked before calling the other APIs.
> - The time-out limit for the APIs is 10 seconds. If the APIs don't run within 10 seconds, they must be run again with changed parameters or scope.

## Communication panel management APIs

The communication panel is where you as an agent interact with the customer. Partner widgets built using Channel Integration Framework 2.0 are loaded in this panel. The widget in this version is displayed to the left of the session panel and supports Docked, Minimized, and Hidden modes.

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

## Notification management APIs

Use the following APIs to display or cancel notifications about incoming conversations.

| Methods | Description |
|---------|-------------|
| [notifyEvent](microsoft-ciframework/notifyEvent.md)| Displays a notification that can be used to inform agent about an incoming conversation. |
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
| [requestFocusSession](microsoft-ciframework/requestFocusSession.md) | Sets the focus on the session whose session identifier is passed as a parameter, if the session belongs to the channel provider. |

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
| [updateConversation](microsoft-ciframework/updateConversation.md) | This method allows you to update a conversation record. |

### See also

[What's new in Dynamics 365 Channel Integration Framework](../../whats-new-channel-integration-framework.md)  
[System requirements for Dynamics 365 Channel Integration Framework 2.0](../system-requirements-channel-integration-framework-v2.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
