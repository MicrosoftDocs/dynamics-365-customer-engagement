---
title: "Agent scripts in the Omnichannel Administration app | MicrosoftDocs"
description: "Learn about agent scripts and how to configure them in the Omnichannel Administration app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 01/24/2020
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

[Step 3: Add agent script control to a form](#step-3-add-agent-script-control-to-a-form)

## Step 1: Create agent scripts

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

## Step 3: Add agent script control to a form

After you create an agent script, you must add the agent script field to the form where you want agents to see it.

1. Sign in to the Omnichannel Administration app, and then on the command bar select **Settings** ![Settings](../media/settings-gear.png "Settings") > **Advanced  Settings**.

2. Select **Settings** > **Customizations** > **Customize the System**. **Solution Explorer** opens in a new window.

3. Expand **Entities** and select the entity for which you want to add the field. In this procedure, we will add to the **Customer Summary** form in the **Conversation** entity.

4. Expand **Conversation** > **Forms** > **Customer Summary**. The **Customer Summary** form opens in a new window.

5. Select the **INSERT** tab from the command bar, and then select **Section** > **One Column** in the command bar.

    > [!div class=mx-imgBorder] 
    > ![Add section](../media/agent-script-control5.png "Add section")

6. Select the section, and then select **Change Properties** from the command bar. The **Section Properties** dialog appears.

7. Specify **Agent script** as the value for both the **Name** and **Label** fields.

8. Select the **Show the label of this section on the Form**  check box, and then select **OK**.

    > [!div class=mx-imgBorder] 
    > ![Add name and show label](../media/agent-script-control8.png "Add name and show label")

9. Select a field of type **Text** from **Field Explorer**. For example, the **Title** field is of type **Text**. If you hover the cursor on a field, you can view the type.

    > [!div class=mx-imgBorder] 
    > ![Add field of type Text](../media/agent-script-control9.png "Add field of type Text")

10. Drag and drop the **Title** field to the section you added in the earlier step.

11. Select the **Title** field in the **Agent script** section, and then select **Change Properties** from the command bar. The **Field Properties** dialog appears.

12. Clear the **Display the label on the form** check box in the **Display** tab.

    > [!div class=mx-imgBorder] 
    > ![Clear display label](../media/agent-script-control12.png "Clear display label")

13. Select the **Controls** tab in the **Field Properties** dialog, and then select **Add Control**.

    > [!div class=mx-imgBorder] 
    > ![Add agent script control](../media/agent-script-control13.png "Add agent script control")

14. Select **Agent script control** in the **Add Control** dialog, and then select **Add**.

15. Choose the **Web** radio button for the **Agent script control** option, and then select **OK**.

    > [!div class=mx-imgBorder] 
    > ![Choose web option](../media/agent-script-control15.png "Choose web option")

16. Select **Save** to save the changes.

17. Select **Publish** to publish the customizations.

## See also

[Agent script](../agent/agent-oc/oc-agent-scripts.md)

[Macros](macros.md)

[Smart Assist](smart-assist.md)
