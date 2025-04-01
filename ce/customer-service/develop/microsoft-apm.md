---
title: "App profile manager JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager methods and properties to manage tabs and sessions in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 04/23/2024
ms.topic: reference
---

# App profile manager JavaScript API Reference

The app profile manager JavaScript API Reference includes methods and properties to manage tabs and sessions in Customer Service workspace.

## Prerequisite

You must have App Profile user or Productivity tools user security roles to use the app profile manager APIs. More information: [Security roles](../administer/security-roles.md)

## Session management

The following methods and properties allow you to manage sessions in Customer Service workspace.

| Method | Description |
|--------|-------------|
| [getFocusedSession](../develop/reference/methods/getFocusedSession.md) | Returns the session object of the session that is in focus. |
| [getAllSessions](../develop/reference/methods/getAllSessions.md) | Returns the unique identifier of all sessions. |
| [getSession](../develop/reference/methods/getSession.md) | Returns the session object for the specified session ID.  |
| [createSession](../develop/reference/methods/createSession.md) | Creates a session based on a session template and returns the unique identifier of the session. |
| [canCreateSession](../develop/reference/methods/canCreateSession.md) | Returns a Boolean value indicating whether a new session can be created.|
| [close](../develop/reference/methods/close.md) | Closes a session.|
| [focus](../develop/reference/methods/focus.md) | Sets the focus on a session. |
| [requestFocus](../develop/reference/methods/requestFocus.md) | Shows a notification indicator on a given session if the session is not in focus.|
|||

| Property | Description |
|----------|-------------|
| [sessionId](../develop/reference/properties/sessionId.md) | The ID of a given session. |
| [isDefault](../develop/reference/properties/isDefault.md) | Boolean value indicating if a session is the Home session.|
| [canClose]( ../develop/reference/properties/canCloseSession.md) | Boolean value indicating whether a session can be closed. |
| [title](../develop/reference/properties/sessiontitle.md) | The text label of a session. |
|||

## Tab management

The following methods and properties allow you to manage tabs in Customer Service workspace.

| Method | Description |
|--------|-------------|
| [getFocusedTab](../develop/reference/methods/getFocusedTab.md) | Returns the tab object of the tab that is in focus. |
| [getAllTabs](../develop/reference/methods/getAllTabs.md) | Returns the unique identifier of all tabs for a session. |
| [getTab](../develop/reference/methods/getTab.md) | Returns the tab object of the specified tab ID.  |
| [createTab](../develop/reference/methods/createTab.md) | Creates a tab in a focused session and returns the unique identifier of the tab. |
| [canCreateTab](../develop/reference/methods/canCreateTab.md) | Returns a Boolean value indicating whether a new tab can be created for a session. |
| [closeTab](../develop/reference/methods/closeTab.md) | Closes the tab object for a tab ID. |
| [focusTab](../develop/reference/methods/focusTab.md) | Sets the focus on the tab object for a tab ID. |
| [refreshTab](../develop/reference/methods/refreshTab.md) | Refreshes the tab object for a tab ID.   |
|||

| Property | Description |
|----------|-------------|
| [tabId](../develop/reference/properties/tabId.md) | The ID of a tab. |
| [canClose](../develop/reference/properties/canCloseTab.md) | Boolean value indicating whether a tab can be closed. |
| [title](../develop/reference/properties/tabtitle.md) | The text label of a tab. |
|||


## Context management

The following method allows you to manage the session context in Customer Service workspace.

| Method | Description |
|--------|-------------|
| [updateContext](../develop/reference/properties/updateContext.md) | Sets the automation dictionary and enables providers to add, modify, and remove values of slugs; the updated values are then available for invoking macros in the future. |
|||

## Client-side events

| Event | Description |
|--------|-------------|
| [ON_SESSION_SWITCH](../develop/reference/events/on_session_switch.md) | Invoked when the session is switched. |
| [ON_SESSION_CLOSED](../develop/reference/events/on_session_closed.md) | Invoked when a session is closed. |

### Related information

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
