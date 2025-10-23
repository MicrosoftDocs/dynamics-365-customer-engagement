---
title: Manage scripts
description: Follow the steps mentioned in the article to create and configure scripts that can be used by representatives when they are interacting with customers.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 04/14/2025
ms.topic: how-to
---

# Guide representatives with scripts

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

In the customer service industry, customer service representatives (service representatives or representatives) need to deal with continuous updates both to products and processes. Even after they have been rigorously trained, recurrent human errors and delays in service delivery occur due to a lack of guidance in real-time customer scenarios. These issues lead to lower productivity and thus negatively affect customer satisfaction levels. To avoid errors and ensure that processes are adhered to, representatives need guidance.

Scripts provide guidance to representatives about what to do when they get a customer issue. The scripts ensure that only accurate, company-endorsed information is being shared, while also safeguarding the organization in regard to issues of legal compliance. Scripts help organizations to be unified, accurate, and effective while also being faster and more efficient in terms of customer handling.

Scripts reduce the human errors involved, because representatives know which actions they need to perform next while they interact with a customer, enabling representatives to adhere to the business process. This, in turn, leads representatives to provide quick resolutions for the issue (low average handling time) and improve customer satisfaction.

## Value propositions

- Minimization of human errors
- Adherence to business processes
- Lower average handling time
- Improved customer satisfaction

## Prerequisites

- Make sure that you have the **Productivity tools administrator** security role. To learn more, see [Assign roles and enable users](../implement/add-users-assign-roles.md).

- Make sure that representatives and supervisors are assigned the **Productivity tools user** security role. To learn more, see Assign roles and enable users.

## Create scripts

Create scripts in the admin center by following these steps:

1. In the site map of Copilot Service admin center, select **Productivity** in **Support experience**. 
1. On the **Productivity** page, select **Manage** for **Scripts**. 
1. On the **Scripts** page, select **New**.

The following procedure is an example of a script for a chat session. You can modify the procedure for other types of sessions your representatives are likely to come across.

1. On the **New Script** page, specify the following:

    | Field | Description | Value |
    |------------|------------------------------|-------------------|
    | Name | A name for the script. | Chat session script |
    | Unique Name | A unique identifier in the <*prefix*>_<*name*> format.<br>**Important:** The following are required for the unique name:<br><ul><li> The prefix can only be alphanumeric and its length must be between 3 to 8 characters.</li> <li>An underscore must be there between the prefix and name.</li></ul> |Contoso_script|
    | Language | A language from the list. The languages that are enabled in Microsoft Dataverse appear in the list. | English |
    | Description | Description for the script. | This script is used for chat sessions. |

2. Select **Save**. The **Script steps** appears.

3. In the **Script steps** section, select **New Script step**. The **Quick Create: Script step** page appears.

4. Specify the following fields in the quick-create form.
 
    | Field | Description | Example Value |
    |--------------------|------------------------------|-------------------------------------------|
    | Name | Provide a name for the script step; this appears for the representative at runtime. You can use slugs for specifying the name of the step. To learn more, see [Slugs](automation-dictionary-keys.md#slugs-for-productivity-tools-macros-and-scripts). | Example 1: Greet the customer. <br><br> Example 2: Hi {customer}  |
    |Unique Name |A unique identifier in the <*prefix*>_<*name*> format.<br>**Important:** The following are required for the unique name:<br><ul><li> The prefix can only be alphanumeric and its length must be between 3 to 8 characters.</li> <li>An underscore must be there between the prefix and name.</li></ul>| Greet_script|
    |Owner|By default, the signed in user is displayed as the owner.| Clay Roddy |
    |Script | The script for which the script step is being created.| Chat session script|
    | Order | Specify the order number based on which step is displayed to the representative. | 1 |
    | Action Type | Select an action type from the list: <ul> <li> Text instruction </li> <li> Macro </li> <li> Script </li> |
    | Description | Describe the step briefly for your reference. | This step opens a draft email to send the customer links to knowledge articles. <br><br> **Note:** <br> This field appears only when you select the **Action Type** value as **Target Macro** or **Target script**. |
    | Text instruction | Specify the text instructions the representative needs to follow and execute. This is a text field. Additionally, you can pass parameter values by using the slugs and OData queries. More information: [Pass parameter values](automation-dictionary-keys.md)<br><br> **Note:** <br> This field appears only if you select the **Text** value for the **Action Type** field. | Greet the customer with the welcome message from the quick reply repository. |
    | Target macro | Type the name of the configured macro in the text box, and then select the macro from the lookup results. <br><br> **Note:** <br> This field appears only if you select the **Macro** value for the **Action Type** field. | Email |
    | Target script | Type the name of the configured script in the text box, and then select the script from the lookup results. <br><br> **Note:** <br> This field appears only if you select the **Script** value for the **Action Type** field. | Close the session |

8. Select **Save and Close** to add, save, and close the quick-create form.

9.  Select **Save** to save the changes.

    > [!div class=mx-imgBorder] 
    > ![Script.](../../app-profile-manager/media/agent-script.png "Script")

The script is now configured.

## Associate a script with a session template

After you configure the script and add the field to a form, you need to associate the script with a session template so that the script loads for representatives based on the type of session they've opened.

1. In the site map of the admin app, select **Session templates** in **Workspaces**.

2. Select a template from the list for which you want to associate the template. For example, select the **Chat - Default Session** template.

3. Select the **Scripts** tab.

4. In the **Scripts** section, select **Add Existing script**. The **Lookup Records** pane appears.

5. In the **Look for Records** box, select the search icon. Select the script from the list, and then select **Add**.

    > [!div class=mx-imgBorder] 
    > ![Associate a script.](../media/associate-agent-script.png "Associate a script")

6. Select **Save**.

The script is associated with the session template.

## Set the default script for representatives

As an administrator, you can set different default scripts for representatives who handle different services, customers, or products. You need a way to show these representatives a script that's appropriate for the context of the conversation between them and the customer. With the script expression builder, you can define the conditions that define which script a representative is shown by default in the agent app.

Based on these conditions, when a representative accepts an incoming conversation, the script control selects a script from the different scripts that were made available for that particular session type and shows the script to the representative. In addition, representatives can manually select a script from the list of available scripts if they need to switch between different scripts.

### Enable and build the expression

You can build the expression in the **Scripts** tab in the sessions template.

1. In the site map, select **Session templates** in **Workspaces**.
 
2. Go to the **Scripts** tab.

3. Set the **Enable build expression** toggle to **Yes**, and then select **Build Expression** to define the expression. The **Expression builder** page is displayed.

    > [!div class=mx-imgBorder] 
    > ![Build expression.](../media/agent-script-build-expression.png "Build expression")

4. Select the **Condition** step, and then create the condition.

5. In the **If true** step, select **Add an action**. The **Condition** step is displayed. To learn about conditions, see [Use the automation dictionary to pass context data parameters](#use-the-automation-dictionary-to-pass-context-data-parameters).

6. Select the **Customer Service** tab, and then select **Set default script**.

    > [!div class=mx-imgBorder] 
    > ![Set default script.](../media/agent-script-build-expression2.png "Set default script")

7. Select a script from the **Script** list.

    > [!div class=mx-imgBorder] 
    > ![Select default script.](../media/agent-script-set-default.png "Select default script")

8. Follow steps 4 through 7 for the **If false** step.

9. Select **Save and close** to save the expression and close the builder.

Now, you've built the expression.

## Use the automation dictionary to pass context data parameters

As an administrator, you need to configure the condition by using the automation dictionary based on the evaluation of the condition. A script is set as default, and this script is displayed to the representative at runtime.

The automation dictionary provides you certain data parameter keys that you can use to build your condition. These parameter keys are resolved and replaced by contextual values at runtime.

To learn about the slugs for productivity tools, see [Slugs](automation-dictionary-keys.md#slugs-for-productivity-tools-macros-and-scripts).

To learn more, see [Use the automation dictionary to pass data parameter keys](automation-dictionary-keys.md#pass-data-parameter-in-macros-and-scripts).

### Related information

[Scripts](../use/oc-agent-scripts.md)  
[Macros](macros.md)  
[Smart assist](smart-assist.md)  
[Session templates](session-templates.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
