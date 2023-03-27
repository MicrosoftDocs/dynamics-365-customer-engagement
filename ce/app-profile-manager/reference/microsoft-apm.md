---
title: "App profile manager JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager methods and properties to manage tabs and sessions in Customer Service workspace."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 02/12/2023
ms.topic: reference
---

# App profile manager JavaScript API Reference

The app profile manager JavaScript API Reference includes methods and properties to manage tabs and sessions in Customer Service workspace.

## Prerequisite

You must have App Profile user or Productivity tools user security roles to use the app profile manager APIs. More information: [Security roles](../security-roles.md)

## Session management

The following methods and properties allow you to manage sessions in Customer Service workspace.

| Method | Description |
|--------|-------------|
| [getFocusedSession](microsoft-apm/getFocusedSession.md) | Returns the session object of the session that is in focus. |
| [getAllSessions](microsoft-apm/getAllSessions.md) | Returns the unique identifier of all sessions. |
| [getSession](microsoft-apm/getSession.md) | Returns the session object for the specified session ID.  |
| [createSession](microsoft-apm/createSession.md) | Creates a session based on a session template and returns the unique identifier of the session. |
| [canCreateSession](microsoft-apm/canCreateSession.md) | Returns a Boolean value indicating whether a new session can be created.|
| [close](microsoft-apm/close.md) | Closes a session.|
| [focus](microsoft-apm/focus.md) | Sets the focus on a session. |
| [requestFocus](microsoft-apm/requestFocus.md) | Shows a notification indicator on a given session if the session is not in focus.|
|||

| Property | Description |
|----------|-------------|
| [sessionId](microsoft-apm/sessionId.md) | The ID of a given session. |
| [isDefault](microsoft-apm/isDefault.md) | Boolean value indicating if a session is the Home session.|
| [canClose](microsoft-apm/canCloseSession.md) | Boolean value indicating whether a session can be closed. |
| [title](microsoft-apm/sessiontitle.md) | The text label of a session. |
|||

## Tab management

The following methods and properties allow you to manage tabs in Customer Service workspace.

| Method | Description |
|--------|-------------|
| [getFocusedTab](microsoft-apm/getFocusedTab.md) | Returns the tab object of the tab that is in focus. |
| [getAllTabs](microsoft-apm/getAllTabs.md) | Returns the unique identifier of all tabs for a session. |
| [getTab](microsoft-apm/getTab.md) | Returns the tab object of the specified tab ID.  |
| [createTab](microsoft-apm/createTab.md) | Creates a tab in a focused session and returns the unique identifier of the tab. |
| [canCreateTab](microsoft-apm/canCreateTab.md) | Returns a Boolean value indicating whether a new tab can be created for a session. |
| [closeTab](microsoft-apm/closeTab.md) | Closes the tab object for a tab ID. |
| [focusTab](microsoft-apm/focusTab.md) | Sets the focus on the tab object for a tab ID. |
| [refreshTab](microsoft-apm/refreshTab.md) | Refreshes the tab object for a tab ID.   |
|||

| Property | Description |
|----------|-------------|
| [tabId](microsoft-apm/tabId.md) | The ID of a tab. |
| [canClose](microsoft-apm/canCloseTab.md) | Boolean value indicating whether a tab can be closed. |
| [title](microsoft-apm/tabtitle.md) | The text label of a tab. |
|||


## Context management

The following method allows you to manage the session context in Customer Service workspace.

| Method | Description |
|--------|-------------|
| [updateContext](microsoft-apm/updateContext.md) | Sets the automation dictionary and enables providers to add, modify, and remove values of slugs; the updated values are then available for invoking macros in the future. |
|||
### See also

[App profile manager](../app-profile-manager.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
