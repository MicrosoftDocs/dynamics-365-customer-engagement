---
title: Enable session restore to automatically reload browser sessions and tabs (preview)
description: Learn how to enable session restore to automatically reload sessions and tabs in Customer Service workspace.
author: lalexms 
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to 
ms.date: 10/02/2024 
ms.custom: bap-template 
---

# Enable session restore for automtically reload browser sessions (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note.md)]

# Enable session restore

By default, when a browser is refreshed or reconnected in the Customer Service workspace app, only the home page reloads. Service representatives must manually reopen all their sessions and application tabs. This includes calls, cases, chats, messages, and more. Common reasons a browser might close include browser memory issues, microphone or headset problems, network instability, or accidental browser closures.

As an administrator, you can enable session restore, which automatically restores sessions when the browser refreshes. Session restore ensures that service representatives can promptly resume their work without having to manually reconstruct their workspaces. Key entities, such as cases, accounts, and their associated application tabs are reopened, and focus restores to the last session or application tab in view. After the presence is loaded, conversations, including calls and chats, are reinstated.

## Session restore functionality

Keep in mind the following functionalities before you enable the session restore feature. 

- The order of session tabs might change.
- When there are multiple browser sessions or tabs, the system restores only the latest updated browser tab or session.
- Cross-browser restoration, such as from Edge to Chrome, isn't supported.
- While the productivity pane state and focus are restored, the system doesn't restore the state of the productivity tools.
- The system restore Chats, calls, and other session types after presence is reestablished, with a slight delay when compared to other sessions.

## Enable session restore for service representatives

1. In the site map of Customer Service admin center or Contact Center admin center, select **Miscellaneous**.
1. Select **Manage** in **New and upcoming features**.
1. Select the **Session restore** check box, and then select **Save**.

### Related information
[Overview of Customer Service workspace](..implement/csw-overview.md)  
[Overview of the productivity pane](../use/csw-productivity-pane.md)  
