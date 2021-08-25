---
title: "App profile manager JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager methods and properties to manage tabs and sessions in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: App profile manager JavaScript API reference


[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

## Introduction

The app profile manager JavaScript API reference includes methods and properties to manage tabs and sessions in Customer Service workspace.

## Prerequisite

You must have App Profile user or Productivity tools user security roles to use the app profile manager APIs.

## Session management

The following methods and properties allow you to manage sessions in Customer Service workspace.

| Method | Description |
|---------|-------------|
| [getFocusedSession](microsoft-apm/getFocusedSession.md) | Returns the session object of the session that is in focus. |
| [getAllSessions](microsoft-apm/getAllSessions.md) | Returns the unique identifier of all sessions. |
| [getSession](microsoft-apm/getSession.md) | Returns the session object for a given session ID.  |
| [createSession](microsoft-apm/createSession.md) | Creates a session based on a session template and returns the unique identifier of the session. |
| [canCreateSession](microsoft-apm/canCreateSession.md) | Returns a Boolean value indicating whether a new session can be created.|
| [close](microsoft-apm/close.md) | Closes a session.|
| [focus](microsoft-apm/focus.md) | Sets the focus on a session. |
| [requestFocus](microsoft-apm/requestFocus.md) | Shows a notification indicator on a given session if the session is not focused.|



| Property | Description |
|------------|-------------|
| [sessionId](microsoft-apm/sessionId.md) | The ID of a given session. |
| [isDefault](microsoft-apm/isDefault.md) | Boolean value indicating if a given session is the Home session.|
| [canClose](microsoft-apm/canCloseSession.md) | Boolean value indicating whether a given session can be closed. |
| [title](microsoft-apm/sessiontitle.md) | The text label of a given session. |


## Tab management

The following methods and properties allow you to manage tabs in Customer Service workspace.

| Method | Description |
|---------|-------------|
| [getFocusedTab](microsoft-apm/getFocusedTab.md) | Returns the tab object of the tab that is in focus. |
| [getAllTabs](microsoft-apm/getAllTabs.md) | Returns the unique identifier of all tabs for a given session. |
| [getTab](microsoft-apm/getTab.md) | Returns the tab object of a given tab ID.  |
| [createTab](microsoft-apm/createTab.md) | Creates a tab in a focused session and returns the unique identifier of the created tab. |
| [canCreateTab](microsoft-apm/canCreateTab.md) | Returns a Boolean value indicating whether a new tab can be created for a given session. |
| [closeTab](microsoft-apm/closeTab.md) | Closes the tab object for a given tab ID. |
| [focusTab](microsoft-apm/focusTab.md) | Sets the focus on the tab object for a given tab ID. |
| [refreshTab](microsoft-apm/refreshTab.md) | Refreshes the tab object for a given tab ID.   |


| Property | Description |
|------------|-------------|
| [tabId](microsoft-apm/tabId.md) | The ID of a given tab. |
| [canClose](microsoft-apm/canCloseTab.md) | Boolean value indicating whether a given tab can be closed. |
| [title](microsoft-apm/tabtitle.md) | The text label of a given tab. |



## Context management

The following method allows you to manage the session context in Customer Service workspace.

| Method | Description |
|---------|-------------|
| [updateContext](microsoft-apm/updateContext.md) | Sets the automation dictionary and enables providers to add, modify, and remove values of slugs; the updated values are then available for future macro invocations. |



[!INCLUDE[footer-include](../../includes/footer-banner.md)]
