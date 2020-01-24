---
title: "Agent scripts in the Omnichannel Administration app | MicrosoftDocs"
description: "Learn about agent scripts and how to configure them in the Omnichannel Administration app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 01/31/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Guide agents with scripts

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview of agent scripts

In the customer service industry, agents need to deal with continuous updates both in the product and processes. Even after rigorous training of agents, recurrent human errors and delays in service delivery occur due to a lack of guidance in real-time customer scenarios. These issues lead to lower productivity and thus impact customer satisfaction levels. To avoid errors and ensure adherence to processes, agents need guidance.

Agent scripts provide guidance to agents about what to do when they get a customer issue. The scripts ensure that only accurate, company-endorsed information is being shared, while also safeguarding the organization in regard to legal-compliance issues. Agent scripts help organizations to be unified, accurate, and effective while also being faster and more efficient in terms of customer handling.

The agent scripts reduce the human errors involved in the process as the agents know the next actions they need to perform while interacting with a customer, which enables them to adhere to business process. The option, in turn, leads the agents to provide a quick resolution to the issue (low average handling time) and improve customer satisfaction.

## Value propositions

- Minimization of human errors.

- Adherence to business processes.

- Lower Average Handling Time.

- Improved customer satisfaction.

## Prerequisites

- Install Dynamics 365 Productivity Tools solution.

- Ensure you have the **Productivity tools administrator** security role. To learn more, see [Assign roles and enable users](add-users-assign-roles.md).

- Ensure agents and supervisors are assigned **Productivity tools user** security role. To learn more, see [Assign roles and enable users](add-users-assign-roles.md).

## Walkthrough to enable agent script

[Step 1: Create agent scripts](#step-1-create-agent-scripts)

[Step 2: Associate agent script with session template](#step-2-associate-agent-script-with-session-template)

[Step 3: Enable productivity pane](#step-3-enable-productivity-pane)

## Step 1: Create agent scripts

First, you need to create agent scripts in the Omnichannel Administration app.

1. Sign in to the Omnichannel Administration app.

2. Select **Agent Scripts** under **Agent Experience**.

3. Select **+ New** in the **Active Agent scripts** page.

4. Specify the following in the **New Agent script** page.

    | Field | Description | Value |
    |------------|------------------------------|-------------------|
    | Name | Provide a name to the agent script. | Chat session script |
    | Language | Select a language from the list. The languages that are enabled in the Common Data Service platform appear in the list. | English |
    | Description | Describe the agent script. | This agent script is used for chat sessions. |

5. Select **Save**. After you save, the **Agent script steps** appears.

6. Select **+ New Agent script step** in the **Agent script steps** section. The **Quick Create: Agent script step** appears.

7. Specify the following in the quick create form.

    | Field | Description | Example Value |
    |--------------------|------------------------------|-------------------------------------------|
    | Name | Provide a name to the agent script step; this appears for the agent at runtime. | Greet customer. |
    | Order | Specify the order number based on which step is displayed to the agent. | 1 |
    | Action Type | Select an action type from the list: <ul> <li> Text instruction </li> <li> Macro </li> <li> Script </li> |
    | Description | Describe the step briefly for your reference. | This step opens a draft email to send knowledge article links to customer. <br><br> **Note:** <br> This field appears only when you select the **Action Type** value as **Target Macro** or **Target script**. |
    | Text instruction | Specify the text instructions the agent needs to follow and execute. This is a text field. Additonally, you can pass parameter values using the Slugs and OData queries. To learn more see, [Pass parameter values](automation-dictionary-keys.md)<br><br> **Note:** <br> This field appears only if you select the **Text** value for the **Action Type** field. | Greet the customer with welcome message from the quick reply repository. |
    | Target macro | Type the name of the configured macro in the text box and select the macro from the lookup results. <br><br> **Note:** <br> This field appears only if you select the **Macro** value for the **Action Type** field. | Email |
    | Target script | Type the name of the configured script in the text box and select the script from the lookup results. <br><br> **Note:** <br> This field appears only if you select the **Script** value for the **Action Type** field. | Close session |

    > [!div class=mx-imgBorder] 
    > ![Quick create: Agent script - Text](../media/create-agent-script2.png "Quick create: Agent script text step")

8. Select **Save and Close** to add, save, and close the quick create form.

9. Select **Save** to save the changes.

    > [!div class=mx-imgBorder] 
    > ![Agent script](../media/create-agent-script1.png "Agent script")

Now, the agent script is configured.

## Step 2: Associate agent script with session template

After you configure the agent script and add the field to a form, you need to associate the agent script with a session template so that, based on the session type, the agent script loads to the agents.

1. Sign in to the Omnichannel Administration app.

2. Select **Sessions** under **Templates**.

3. Select a template from the list for which you want to associate the template. For example, select the **Chat - Default Session** template.

4. Select the **Agent scripts** tab.

5. Select **Add Existing Agent script** in the **Agent scripts** section. The **Lookup Records** pane appears.

6. Select the search icon in the **Look for Records** box. Select the agent script from the list and select **Add**.

    > [!div class=mx-imgBorder] 
    > ![Associate agent script](../media/associate-agent-script.png "Associate agent script")

7. Select **Save**.

The agent script is associated with the session template.

## Step 3: Enable productivity pane

After you've created the agent script, you need to enable the productivity pane to display the script to the agents in the Omnichannel for Customer app.

To enable productivity pane, see [Enable productivity pane to provide guidance to agents](productivity-pane.md).

After you've enabled the productivity pane, users can see the agent scripts on the productivity pane in the Omnichannel for Customer Service app.

> [!Note]
> - If you don't create agent script and enable the productivity pane, then users wouldn't see the pane in the Omnichannel for Customer Service app. 
>
> - It is recommended to remove the agent script control If you've customized a form to add the agent script field so agents can see it.
>
> - If you don't remove the agent script control, then agents will see the agent script control in the form and also in the productivity pane.

## Set default agent script for agents

As an administrator, you can set default agent script for your agents who are handling different service, customers, or products.

When your agents are serving different services, customers or products, you need way to show a script that is more appropriate according to the context of the customer and the agent. With agent script expression builder, you can define the conditions based on which the agents are shown a script as default in the Omnichannel for Customer Service app.

When the agent accepts an incoming conversation, based on the conditions, the agent script control selects a script from the different scripts that is made available for that particular session type, and shows the script to the agent.

In addition, agent can manually select a script from the list of available agent scripts to switch between different scripts.

### Enable and build the expression

You can build the expression in the **Agent scripts** tab that is present in the sessions template.

1. Sign in to Omnichannel Administration.

2. Select **Sessions** under **Agent Experience**.

3. Select the **Agent scripts** tab.

4. Set the **Enable build expression** toggle to **Yes**, and then select the **Build Expression** button to define the expression. The **Expression builder** page is displayed.

    > [!div class=mx-imgBorder] 
    > ![Build expression](../media/agent-script-build-expression.png "Build expression")

5. Select the **Condition** step, and then create the condition. 

6. Select the **Add an action** button in the **If true** step. The **Condition** step is displayed. To learn about the conditions, see [Use automation dictionary to pass macro context data parameters](#use-automation-dictionary-to-pass-context-data-parameters)

7. Select the **Customer Service** tab, and then select the **Set default agent script** action.

    > [!div class=mx-imgBorder] 
    > ![Set default agent script](../media/agent-script-build-expression2.png "Set default agent script")

8. Select a script from the **Agent script** list.

    > [!div class=mx-imgBorder] 
    > ![Set default agent script](../media/agent-script-set-default.png "Set default agent script")

9. Similarly, follow the Steps 5-8 for the **If false** step.

10. Select **Save and close** to save the expression and close the builder. 

Now, you've built the expression.

## Use automation dictionary to pass context data parameters

As an administrator, you need to configure the condition using the automation dictionary based on the evaluation of the condition, a script is set as default, and the same is displayed to the agent at the run time. 

The automation dictionary provides you certain data parameters keys that you can used an build your condition. 

These parameter keys are resolved and replaced by the contextual values at the run time.

To learn about the slugs for productivity tools, see [Slugs](automation-dictionary-keys.md#slugs-for-productivity-tools-macros-and-agent-scripts).

To learn more, see [Use automation dictionary to pass data parameter keys](automation-dictionary-keys.md#pass-data-parameter-in-macros-and-agent-scripts).

## See also

[Agent script](../agent/agent-oc/oc-agent-scripts.md)

[Macros](macros.md)

[Smart Assist](smart-assist.md)

[Session templates](session-templates.md)