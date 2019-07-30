---
title: "Manage session templates in Omnichannel Administrator app | MicrosoftDocs"
description: "Learn about managing session templates in Omnichannel Administrator app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 08/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 17BE0284-BFDA-420C-8D84-CAE84D0D9270
ms.custom: 
---

# Manage session templates

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)] 

## Overview

Session template in Omnichannel for administrator app is a combination of attributes and application tab information that are reusable.

As an agent, when a you accept a chat or SMS incoming conversation request, a session is started. The **Customer Summary** application which is defined as **Anchor Tab** is opened in the application tab panel and it is not closable. Simultaneously, the communication panel is expanded for you to exchange messages with the customer. 

Session templates are used to define the aforementioned session experience such as, 

- which application must be opened as an anchor tab in the application tab panel;
- what are the additional application tabs that must be opened when a session is started;
- what must be default mode of the communication panel when a session is started.

Omnichannel provides out-of-the-box session templates that you can use or create new session templates.

- **Chat for Dynamics 365:** This session template is used for any incoming conversation from the Chat channel.
- **SMS for Dynamics 365:** This session template is used for any incoming conversation from the SMS channel.
- **Case:** This session template is used for a case request.

## Create a session template

To create a session, follow these steps:

1. Sign in to the Omnichannel Administrator app.

2. Select **Sessions** under **Templates** in the sitemap.

3. Select **+ New** in the **Active Session Templates** page.

4. Specify the following in the **New Session Templates** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | Specify the name of the session. This name wouldn't be visible for the agents at the run-time. | Chat session |
    | General | Title | Provide the title of the session that you want the agents to see at the run-time. | {customerName} |
    | General | Communication panel mode | Select the default mode of the panel when a session is started. Choose one of the following: <br><br> <ul><li> **Docked:** The panel will be in expanded mode. </li> <li> **Minimized:** The panel will be in minimized mode. <li> **Hidden:** The panel will be hidden and will not be shown. </ul> <br> **Note:** For an entity routing session, that is, for a case session, the communication panel mode is hidden. | Docked |
    | General | Description | Provide a description for your reference. | The session template is used for a conversation request from Chat channel. |
    | General | Anchor tab | Select an application from the list. By default, the application is opened by default when the session is started, and this application is not closable. | Customer summary |

5. Select **Save** to save the session template. After you save, the **Additional tabs** option appears in the page. 

6. Select **Add Existing Application Tab Template** to add additional application tabs that you want to be opened when a session is started. Agents can't close this application tabs. The **Lookup Records** pane appears.

7. Select the application tab names in the search box and select the search icon. A list of record appears. Select the application tab and select **Add**.

8. Select **Save** to save the changes.

## See also

- [Manage application tab templates](application-tab-templates.md)
- [Manage notification templates](notification-templates.md)
