---
title: "Manage session templates in Dynamics 365 Channel Integration Framework version 2.0 | MicrosoftDocs"
description: "Learn about managing session templates in Dynamics 365 Channel Integration Framework version 2.0."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 12/31/2019
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage session templates

## Overview

Session templates in the Dynamics 365 Channel Integration Framework app are a combination of attributes and application tab information that are reusable.

When an agent accepts an incoming conversation request, a session is started. The system opens an application that you (an administrator) defined as **Anchor Tab** in the application tab panel. The **Anchor Tab** is not closable. Simultaneously, the system expands the communication panel for you to exchange messages with the customer. 

Session templates are used to define a session experience like the one just described, such as: 

- Which application must be opened as an anchor tab in the application tab panel.
- What additional application tabs must be opened when a session is started.
- What the default mode of the communication panel will be when a session is started.

Dynamics 365 Channel Integration Framework provides out-of-the-box session templates that you can use, or you can create new ones. As an administrator, you can create multiple session templates in your environment.

- **Chat - Default Session**: This session template is used for any incoming conversation from the Chat channel.
- **SMS - Default Session**: This session template is used for any incoming conversation from the SMS channel.
- **Entity routing - Default Session**: This session template is used for a case and other entity record requests.

A session template is the place where, as an administrator, you need to define the anchor tab and additional application tabs that must open when a session starts.

## Create a session template

To create a session, follow these steps:

1. Sign in to the Dynamics 365 Channel Integration Framework app.

2. Select **Sessions** under **Templates** in the sitemap.

3. Select **+ New** on the **Active Session Templates** page.

4. Specify the following on the **New Session Templates** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | Specify the name of the session. This name won't be visible to agents at runtime. | Chat session |
    | General | Title | Provide the title of the session that you want agents to see at runtime. | {customerName} |
    | General | Communication panel mode | Select the default mode of the panel when a session is started. Choose one of the following: <br> <ul><li> **Docked**: The panel will be in expanded mode. </li> <li> **Minimized**: The panel will be in minimized mode. <li> **Hidden**: The panel will be hidden. </ul> <br> **Note**: For an entity session such as case, lead, and so on, the communication panel mode is hidden. | Docked |
    | General | Description | Provide a description for your reference. | The session template is used for a conversation request from the Chat channel. |
    | General | Anchor tab | Select an application from the list. By default, the application opens when the session starts, and this application is not closable. | Knowledge article search |

5. Select **Save** to save the session template. After you save, the **Additional tabs** option appears on the page. 

6. Select **Add Existing Application Tab Template** to add additional application tabs that you want to be opened when a session starts. Agents can't close this application tab. The **Lookup Records** pane appears.

7. Type the application tab names in the search box and select the **Search** icon. A list of records appears. Select the application tab and select **Add**. The application tab is added to the session.

8. Select **Save** to save the changes.

## See also

[Manage application tab templates](application-tab-templates-cif.md)

[Manage notification templates](notification-templates-cif.md)

[Use automation dictionary to pass data parameter keys](automation-dictionary-keys-cif.md)
