---
title: "Agent scripts to configure | MicrosoftDocs"
description: "Learn about agent scripts and how to configure them."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.service: dynamics-365-customerservice
ms.topic: article
---

# Guide agents with scripts

## Introduction

In the customer service industry, agents need to deal with continuous updates both to products and processes. Even after agents have been rigorously trained, recurrent human errors and delays in service delivery occur due to a lack of guidance in real-time customer scenarios. These issues lead to lower productivity and thus negatively affect customer satisfaction levels. To avoid errors and ensure that processes are adhered to, agents need guidance.

Agent scripts provide guidance to agents about what to do when they get a customer issue. The scripts ensure that only accurate, company-endorsed information is being shared, while also safeguarding the organization in regard to issues of legal compliance. Agent scripts help organizations to be unified, accurate, and effective while also being faster and more efficient in terms of customer handling.

Agent scripts reduce the human errors involved in the process, because agents know which actions they need to perform next while they interact with a customer, which enables them to adhere to business process. This, in turn, leads agents to provide quick resolutions for the issue (low average handling time) and improve customer satisfaction.

## Value propositions

- Minimization of human errors.

- Adherence to business processes.

- Lower average handling time.

- Improved customer satisfaction.

## Prerequisites

- Ensure that you have the **Productivity tools administrator** security role. To learn more, see [Assign roles and enable users](../customer-service/add-users-assign-roles.md).

- Ensure that agents and supervisors are assigned the **Productivity tools user** security role. To learn more, see Assign roles and enable users.

## Create agent scripts

Create agent scripts in the Omnichannel admin center, Omnichannel Administration, or Customer Service Hub app. The following procedure is an example of an agent script for a chat session. You can modify the procedure for other types of sessions your agents are likely to come across.

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), and go to the app profile manager page.
2. In the left pane, under **Productivity**, select **Agent scripts**. The Unified Interface page opens on a new tab.

3. On the page that appears, select **New**.

4. On the **New Agent script** page, specify the following:

    | Field | Description | Value |
    |------------|------------------------------|-------------------|
    | Name | A name for the agent script. | Chat session script |
    | Unique Name | A unique identifier in the <*prefix*>_<*name*> format.<br>**Important:** The following are required for the unique name:<br><ul><li> The prefix can only be alphanumeric and its length must be between 3 to 8 characters.</li> <li>An underscore must be there between the prefix and name.</li></ul> |Contoso_script|
    | Language | A language from the list. The languages that are enabled in Microsoft Dataverse appear in the list. | English |
    | Description | Description for the agent script. | This agent script is used for chat sessions. |

5. Select **Save**. The **Agent script steps** appears.

6. In the **Agent script steps** section, select **New Agent script step**. **Quick Create: Agent script step** appears.

7. Specify the following in the quick-create form.

    | Field | Description | Example Value |
    |--------------------|------------------------------|-------------------------------------------|
    | Name | Provide a name for the agent script step; this appears for the agent at runtime. You can use slugs for specifying the name of the step. To learn more, see [Slugs](automation-dictionary-keys.md#slugs-for-productivity-tools-macros-and-agent-scripts). | Example 1: Greet the customer. <br><br> Example 2: Hi {customer}  |
    |Unique Name |A unique identifier in the <*prefix*>_<*name*> format.<br>**Important:** The following are required for the unique name:<br><ul><li> The prefix can only be alphanumeric and its length must be between 3 to 8 characters.</li> <li>An underscore must be there between the prefix and name.</li></ul>| Greet_script|
    |Owner|By default, the signed in user is displayed as the owner.| Clay Roddy |
    |Agent script | The agent script for which the script step is being created.| Chat session script|
    | Order | Specify the order number based on which step is displayed to the agent. | 1 |
    | Action Type | Select an action type from the list: <ul> <li> Text instruction </li> <li> Macro </li> <li> Script </li> |
    | Description | Describe the step briefly for your reference. | This step opens a draft email to send the customer links to knowledge articles. <br><br> **Note:** <br> This field appears only when you select the **Action Type** value as **Target Macro** or **Target script**. |
    | Text instruction | Specify the text instructions the agent needs to follow and execute. This is a text field. Additionally, you can pass parameter values by using the slugs and OData queries. More information: [Pass parameter values](automation-dictionary-keys.md)<br><br> **Note:** <br> This field appears only if you select the **Text** value for the **Action Type** field. | Greet the customer with the welcome message from the quick reply repository. |
    | Target macro | Type the name of the configured macro in the text box, and then select the macro from the lookup results. <br><br> **Note:** <br> This field appears only if you select the **Macro** value for the **Action Type** field. | Email |
    | Target script | Type the name of the configured script in the text box, and then select the script from the lookup results. <br><br> **Note:** <br> This field appears only if you select the **Script** value for the **Action Type** field. | Close the session |

8. Select **Save and Close** to add, save, and close the quick-create form.

9.  Select **Save** to save the changes.

    > [!div class=mx-imgBorder] 
    > ![Agent script](media/agent-script.png "Agent script")

The agent script is now configured.

## Associate an agent script with a session template

After you configure the agent script and add the field to a form, you need to associate the agent script with a session template so that the agent script will load for agents based on the type of session they've opened.

1. In the site map of Omnichannel admin center, select **Agent experience** under **Advanced settings**, and then select **Manage** for **Session templates**. If you are using the Omnichannel Administration app, under **Agent Experience**, select **Sessions**.

2. Select a template from the list for which you want to associate the template. For example, select the **Chat - Default Session** template.

3. Select the **Agent scripts** tab.

4. In the **Agent scripts** section, select **Add Existing Agent script**. The **Lookup Records** pane appears.

5. In the **Look for Records** box, select the search icon. Select the agent script from the list, and then select **Add**.

    > [!div class=mx-imgBorder] 
    > ![Associate an agent script](../customer-service/media/associate-agent-script.png "Associate an agent script")

6. Select **Save**.

The agent script is associated with the session template.

## Set the default agent script for agents

As an administrator, you can set different default agent scripts for agents who handle different services, customers, or products. You need a way to show these agents a script that's appropriate for the context of the conversation between them and the customer. With the agent script expression builder, you can define the conditions that define which script an agent is shown by default in Omnichannel for Customer Service.

Based on these conditions, when an agent accepts an incoming conversation, the agent script control selects a script from the different scripts that were made available for that particular session type and shows the script to the agent. In addition, agents can manually select a script from the list of available agent scripts if they need to switch between different scripts.

### Enable and build the expression

You can build the expression in the **Agent scripts** tab in the sessions template.

1. In the site map of Omnichannel admin center, select **Agent experience** under **Advanced settings**, and then select **Manage** for **Session templates**. If you are using the Omnichannel Administration app, under **Agent Experience**, select **Sessions**.

2. Go to the **Agent scripts** tab.

3. Set the **Enable build expression** toggle to **Yes**, and then select **Build Expression** to define the expression. The **Expression builder** page is displayed.

    > [!div class=mx-imgBorder] 
    > ![Build expression](../customer-service/media/agent-script-build-expression.png "Build expression")

4. Select the **Condition** step, and then create the condition.

5. In the **If true** step, select **Add an action**. The **Condition** step is displayed. To learn about conditions, see [Use the automation dictionary to pass context data parameters](#use-the-automation-dictionary-to-pass-context-data-parameters).

6. Select the **Customer Service** tab, and then select **Set default agent script**.

    > [!div class=mx-imgBorder] 
    > ![Set default agent script](../customer-service/media/agent-script-build-expression2.png "Set default agent script")

7. Select a script from the **Agent script** list.

    > [!div class=mx-imgBorder] 
    > ![Set default agent script](../customer-service/media/agent-script-set-default.png "Set default agent script")

8. Follow steps 4 through 7 for the **If false** step.

9. Select **Save and close** to save the expression and close the builder.

Now, you've built the expression.

## Use the automation dictionary to pass context data parameters

As an administrator, you need to configure the condition by using the automation dictionary based on the evaluation of the condition. A script is set as default, and this script is displayed to the agent at runtime.

The automation dictionary provides you certain data parameter keys that you can use to build your condition. These parameter keys are resolved and replaced by contextual values at runtime.

To learn about the slugs for productivity tools, see [Slugs](automation-dictionary-keys.md#slugs-for-productivity-tools-macros-and-agent-scripts).

To learn more, see [Use the automation dictionary to pass data parameter keys](automation-dictionary-keys.md#pass-data-parameter-in-macros-and-agent-scripts).

### See also

[Agent scripts](../customer-service/oc-agent-scripts.md)  
[Macros](macros.md)  
[Smart assist](smart-assist.md)  
[Session templates](session-templates.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]