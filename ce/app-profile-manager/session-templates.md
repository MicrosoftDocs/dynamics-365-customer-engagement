---
title: "Manage session templates in Customer Service workspace and Omnichannel Administration app | MicrosoftDocs"
description: "Learn about managing session templates in Customer Service workspace and Omnichannel Administration app"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.service: "dynamics-365-customerservice"
ms.topic: article
---

# Manage session templates

## Introduction

A session template is a combination of attributes and application tab information that can be reused.

In Omnichannel for Customer Service app, when an agent accepts an incoming conversation request from a customer, a session is started. The system opens the **Customer Summary** application that you (an administrator) defined as an **Anchor Tab** in the application tab panel. The **Anchor Tab** can't be closed. Simultaneously, the system expands the communication panel for you to exchange messages with the customer.  

Session templates are used to define the aforementioned session experience, such as:

- which application must be opened as an anchor tab in the application tab panel;
- what are the additional application tabs that must be opened when a session is started;
- what must be the default mode of the communication panel when a session is started.

You can create session templates in the Omnichannel Administration app or use the out-of-the-box templates. In your environment, as an administrator, you can create multiple session templates.

  > [!Note]
  > You can't customize the out-of-the-box session templates; instead, you'll need to create your own custom templates.

The out-of-the-box session template for using in Customer Service workspace is Case entity session - default template.

The following out-of-the-box session templates are of the generic type and are for use in the Omnichannel for Customer Service app:

- Case entity session - default template
- Chat session - default
- Custom messaging session - default
- Entity records session - default
- Facebook session - default
- LINE session - default
- SMS session - default
- Teams session - default
- Twitter session - default
- WeChat session - default
- WhatsApp session - default
  
## Create a session template

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), and go to the app profile manager page.
2. In the left pane, select **Session templates** under Customer Service workspace or Omnichannel Administration. The Unified Interface page opens on a new tab.

3. Select **New** on the **Active Session Templates** page.

4. Specify the following on the **New Session Templates** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | Specify the name of the session. This name won't be visible to the agents at the runtime. | Chat session |
    | General | Unique Name | A unique identifier in the <*prefix*>_<*name*> format. <br>**IMPORTANT**<br> The following are required for the unique name: <ul><li>The prefix can only be alphanumeric and its length must be between 3 to 8 characters.</li><li> An underscore must be there between the prefix and name.</li></ul><br> You can select the light bulb icon, and then select **Apply** to verify whether the name you've entered meets the requirements. | msdyn_chat_custom |
    | General | Type | Select one of the following:<br> <ul><li> **Entity:** If you select entity, the **Entity** field is displayed.</li><li>**Generic:** Select when the template is  required to be assigned to any channel. </li>| Entity|
    | General | Entity | Select an entity from the list.<br> **Note:** The option is displayed only when **Type** is entity. | Case |
    | General | Title | Provide the title of the session that you want agents to see at the runtime. | {customerName} |
    | General | Communication panel mode | Select the default mode of the panel when a session is started. Choose one of the following: <br> <ul><li> **Docked**: The panel will be in expanded mode. </li> <li> **Minimized**: The panel will be in minimized mode. <li> **Hidden**: The panel will be hidden. </ul> <br> **Note**: For an entity routing session—that is, for a case session—the communication panel mode is hidden. | Docked |
    | General | Description | Provide a description for your reference. | The session template is used for a conversation request from Chat channel. |
    | General | Owner | Search and select an owner. By default, the user who is creating the template is set as the owner | Alan Steiner |
    | General | Anchor tab | Select an application from the list. The application is opened by default when the session starts and can't be closed. <br> **Note:** The anchor tab option is displayed only when **Type** is generic. | Customer summary |

5. Select **Save**. After you save, the **Additional tabs** option appears on the page.

6. Select **Add Existing Application Tab Template** to add additional application tabs that you want to be opened when a session is started. Agents can't close this application tab. The **Lookup Records** pane appears.

7. Type the application tab names in the search box and select the search icon. A list of records appears. Select the application tab and select **Add**. The application tab is added to the session.

8. Select the **Agent scripts** tab, and set the **Enable build expression** toggle to **Yes** to define the expression to set an agent script as default for a particular session template.

9. Build the expression, and then select **Save and close**. To learn more, see [Set default agent script for agents](agent-scripts.md#set-the-default-agent-script-for-agents).

  > [!Note]
  > Step 8 and 9 are optional, and applicable only when you've configured agent scripts. To learn more, see [Agent scripts](agent-scripts.md).

10. Select **Save**.

   > [!div class=mx-imgBorder]
   > ![Session template](media/session-template1.png "Session template")

The session template is configured. Now, you must associate the session template with a work stream. To learn more, see [Associate templates with work streams](associate-templates.md).

### See also

[Manage application tab templates](application-tab-templates.md)  
[Manage notification templates](notification-templates.md)  
[Associate templates with work streams](associate-templates.md)  
