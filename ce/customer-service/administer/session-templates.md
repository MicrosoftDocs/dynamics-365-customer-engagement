---
title: Manage session templates
description: Learn about managing session templates in Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 05/23/2024
ms.topic: how-to
ms.custom: bap-template
---

# Manage session templates

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

A session template is a combination of attributes and application tab information that can be reused.

In the Customer Service workspace app, when an agent accepts an incoming conversation request from a customer, a session is started. The system opens the **Active Conversation** application that you (an administrator) defined as an **Anchor Tab** in the application tab panel. The **Anchor Tab** can't be closed. Simultaneously, the system expands the communication panel for you to exchange messages with the customer.  

Session templates are used to define the aforementioned session experience, such as:

- which application must be opened as an anchor tab in the application tab panel;
- what are the additional application tabs that must be opened when a session is started;
- what must be the default mode of the communication panel when a session is started.

You can create session templates in Customer Service admin center or use the out-of-the-box templates. In your environment, as an administrator, you can create multiple session templates.

  > [!NOTE]
  > You can't customize the out-of-the-box session templates; instead, you'll need to create your own custom templates.
  > Channel Integration Framework must be enabled to load generic session templates with the [createsession](../develop/reference/methods/createSession.md) API.

The out-of-the-box session template for using in Customer Service workspace is Case entity session - default template.

The following out-of-the-box session templates are generic and are for use in the Customer Service workspace app:

- Case entity session - default template
- Chat session - default
- Voice call session - default
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

1. In the site map of Customer Service admin center, select **Workspaces** in **Agent experience**.

1. On the **Workspaces** page, select **Manage** for **Session templates**.

1. Select **New** on the **Active Session Templates** page.

1. Specify the following on the **New Session Templates** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | Specify the name of the session. This name won't be visible to the agents at the runtime. | Chat session |
    | General | Unique Name | A unique identifier in the <*prefix*>_<*name*> format. <br>**IMPORTANT**<br> The following are required for the unique name: <ul><li>The prefix can be alphanumeric only and its length must be between 3 to 8 characters.</li><li> An underscore must be there between the prefix and name.</li></ul><br> You can select the light bulb icon, and then select **Apply** to verify whether the name you've entered meets the requirements. | msdyn_chat_custom |
    | General | Type | Select one of the following:<br> <ul><li> **Entity:** If you select entity, the **Entity** field is displayed.</li><li>**Generic:** Select when the template is  required to be assigned to any channel. </li>| Entity|
    | General | Entity | Select an entity from the list.<br> **Note:** The option is displayed only when **Type** is entity. | Case |
    | General | Title | Provide the title of the session that you want agents to see at the runtime. | {customerName} |
    | General | Communication panel mode | Select the default mode of the panel when a session is started. Choose one of the following: <br> <ul><li> **Docked**: The panel will be in expanded mode. </li> <li> **Minimized**: The panel will be in minimized mode. <li> **Hidden**: The panel will be hidden. </ul> <br> **Note**: For an entity routing session—that is, for a case session—the communication panel mode is hidden. | Docked |
    | General | Session Icon| Select an icon to represent the channel from which the conversation is initiated so that your agent can visually identify the channel.<br> **Note**:<ul><li>Is available for generic type of templates only.</li><li>A web resource file for the icon must be deployed.</li> <li> You can use a web resource file only and not slugs to customize the session icon.</li><li>GIF files aren't supported.</li> </ul> | WhatsApp.ico|
    | General | Description | Provide a description for your reference. | The session template is used for a conversation request from Chat channel. |
    | General |Apply session title to anchor tab | Apply the customized session title to anchor tab title. | Yes. |
    | General | Owner | Search and select an owner. By default, the user who is creating the template is set as the owner | Alan Steiner |
    | General | Anchor tab | Select an application from the list. The application is opened by default when the session starts and can't be closed. <br> **Note:** The anchor tab option is displayed only when **Type** is generic. | Customer summary |

1. Select **Save**.

### Associate application tabs, agents scripts with session templates<a name="associate-app-tabs"></a>

You can associate application tabs that need to open when a session is started. Agents can't close these application tabs. You can also associate agents scripts; however, you must first configure the agent scripts. More information: [Agent scripts](agent-scripts.md)

1. Go to the session template that you want to modify.

1. In the **Additional Tab** section, Select **Add Existing Application Tab Template**. The **Lookup Records** pane appears.

1. Type the application tab names in the search box and select the search icon. A list of records appears. Select the application tabs, and then select **Add**. The application tabs are added to the session template.

1. Select the **Agent scripts** tab, and set the **Enable build expression** toggle to **Yes** to define the expression to set an agent script as default for a particular session template.

1. Build the expression, and then select **Save and close**. To learn more, see [Set default agent script for agents](agent-scripts.md#set-the-default-agent-script-for-agents).

1. Select **Save**.

  :::image type="content" source="../media/session-template1.PNG" alt-text="Session template":::

The session template is configured. Now, you must associate the session template with a workstream. To learn more, see [Associate templates with workstreams](associate-templates.md).

### Related information

[Get started with Customer Service admin center](../implement/cs-admin-center.md)  
[Manage application tab templates](application-tab-templates.md)  
[Manage notification templates](notification-templates.md)  
[Associate templates with workstreams](associate-templates.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
