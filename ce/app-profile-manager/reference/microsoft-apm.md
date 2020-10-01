---
title: "Microsoft.Apm (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the APIs of multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/05/2020
ms.service: 
   "dynamics-365-customerservice"
ms.topic: reference
---

# Microsoft.Apm methods (JavaScript API reference)

Provides methods to use JavaScript API to manage the app tabs in a session for the multi-session apps, which are Omnichannel for Customer Service and Customer Service workspace.

## Session management APIs

These APIs allow you to manage sessions in a multi-session apps.

| Methods | Description |
|---------|-------------|
| [createTab](microsoft-apm/createTab.md) | Creates a new app tab in the session that is currently in focus and returns the unique identifier (ID) of the app tab that was created. |
| [refreshTab](microsoft-apm/refreshTab.md) | Refreshes an app tab whose unique identifier (ID) is passed as a parameter.  |
| [focusTab](microsoft-apm/focusTab.md) | Sets the focus on the app tab whose unique identifier (ID) is passed as a parameter. |
| [closeTab](microsoft-apm/closeTab.md) | Closes the app tab whose unique identifier is passed as a parameter. |
