---
title: "Microsoft.Apm (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the APIs of multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Microsoft.Apm methods (JavaScript API reference)

Provides methods to use the JavaScript API to manage the app tabs in a session. The APIs can be used in the app tab management in the multi-session apps.

## Session management APIs

The following APIs allow you to manage sessions with Customer Service workspace.

| Methods | Description |
|---------|-------------|
| [getFocusedSession](microsoft-apm/getFocusedSession.md) | Returns the session object of the session that is in focus. |
| [getAllSessions](microsoft-apm/getAllSessions.md) | Returns the unique identifier of all sessions. |
| [getSession](microsoft-apm/getSession.md) | Returns the session object for a given session ID.  |
| [createSession](microsoft-apm/createSession.md) | Creates a session based on a session template and returns the unique identifier of the session. |
| [canCreateSession](microsoft-apm/canCreateSession.md) | Returns a Boolean value indicating if a new session can be created.|
| [close](microsoft-apm/close.md) | Closes a session.|
| [focus](microsoft-apm/focus.md) | Sets the focus on a session. |
| [requestFocus](microsoft-apm/requestFocus.md) | Shows a notification indicator on a given session if the session is not focused.|

| Properties | Description |
|------------|-------------|
| [sessionId](microsoft-apm/sessionId.md) | The ID of a given session. |
| [isDefault](microsoft-apm/isDefault.md) | Boolean value indicating if a given session is the Home session.|
| [canClose](microsoft-apm/canCloseSession.md) | Boolean value indicating if a given session can be closed. |
| [title](microsoft-apm/sessiontitle.md) | The text label of a given session. |

## Tab management APIs

The following APIs allow you to manage sessions with Customer Service workspace.

| Methods | Description |
|---------|-------------|
| [getFocusedTab](microsoft-apm/getFocusedTab.md) |Returns the tab object of the tab that is in focus. |
| [getAllTabs](microsoft-apm/getAllTabs.md) |Returns the unique identifier of all tabs for a given session. |
| [getTab](microsoft-apm/getTab.md) |Returns the tab object for a given tab ID.  |
| [createTab](microsoft-apm/createTab.md) |Creates a tab in a focused Session and returns the unique identifier of the created tab. |
| [canCreateTab](microsoft-apm/canCreateTab.md) |Returns a boolean value indicating if a new tab can be created for a given session. |
| [closeTab](microsoft-apm/closeTab.md) | Closes the tab object for a given tab ID. |
| [focusTab](microsoft-apm/focusTab.md) |Sets the focus on the tab object for a given tab ID. |
| [refreshTab](microsoft-apm/refreshTab.md) |Refreshes the tab object for a given tab ID.   |

| Properties | Description |
|------------|-------------|
| [tabId](microsoft-apm/tabId.md) | The ID of a given tab. |
| [canClose](microsoft-apm/canCloseTab.md) | Boolean value indicating if a given tab can be closed. |
| [title](microsoft-apm/tabtitle.md) | The text label of a given tab. |

## Context management APIs

The following APIs allow you to manage the session context with Customer Service workspace.

| Methods | Description |
|---------|-------------|
| [updateContext](microsoft-apm/updateContext.md) | Sets the automation dictionary and enables providers to add, modify, and remove values of slugs; the updated values are subsequently available for future macro invocations. |

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
