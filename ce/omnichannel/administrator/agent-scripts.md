---
title: "Agent scripts in the Omnichannel Administrator app | MicrosoftDocs"
description: "Learn about what is agent scripts and how to configure in the Omnichannel Administrator app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 223AAEFE-1228-4CE2-94C0-1118925D1B8C
ms.custom: 
---

# Preview: Guide agents with scripts

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview of agent scripts

In the customer service industry, agents need to deal with continuous updates both in the product and processes. Even after providing rigorous training to the agents, there are recurrent human errors and delays in service delivery due to a lack of guidance in real-time customer scenarios. These issues lead to lower productivity and thus impacts customer satisfaction levels. To avoid the errors and ensure the adherence of processes, agents need guidance.

Agent scripts provide guidance to agents about what they should to doing when they get a customer issue. It ensures that only accurate, company-endorsed information is being shared, while also safeguarding the organization in regard to legal-compliance issues. Agent scripts help organizations to be unified, accurate, and effective while being faster and more-efficient in terms of customer handling.

## Value propositions

- Minimization of human errors

- Adherence to business processes

- Lower Average Handling Time

- Improved customer satisfaction

## Prerequisites

## Create agent scripts

1. Sign in to the Omnichannel Administrator app.

2. Select **Agent Scripts** under **Agent Experience**.

3. Select **+ New** in the **Active Agent scripts** page.

4. Specify the following in the **New Agent script** page.

    | Field | Description | Value |
    |------------|------------------------------|-------------------|
    | Name | Provide a name to the agent script. | Chat session script |
    | Language | Select a language from the list. The languages that are enables in the Common Data Service platform appears in the list. | English |
    | Description | Described the agent script. | This agent script is used for chat sessions. |

5. Select **Save**. After you save, the **Agent script steps** appears.

6. Select **+ New Agent script step** in the **Agent script steps** section. The **Quick Create: Agent script step** appears.

7. Specify the following in the quick create form.

    | Field | Description | Example Value |
    |--------------------|------------------------------|-------------------------------------------|
    | Name | Provide a name to the agent script step and this appears for the agent at the run-time. | Greet customer. |
    | Order | Specify the order number based on which the step are displayed to the agent. | 1 |
    | Action Type | Select an action type from the list. There are three types of action types. <ul> <li> Text instruction </li> <li> Macro </li> <li> Script </li> |
    | Description | Describe the step briefly for your reference. | This step is to greet the customer.|
    | Text instruction | Specify the text instructions that agent needs to follow and execute. This is a text field. <br><br> **Note:** <br> This field appears only if you select **Text instruction** value for the **Action Type** field. | Greet the customer with welcome message from the quick reply repository. |
    | Target macro | Type the name of the macro in the text box and select the macro from the lookup results. <br><br> **Note:** <br> This field appears only if you select **Macro** value for the **Action Type** field. | Email |
    | Target script | Type the name of the script in the text box and select the script from the lookup results. <br><br> **Note:** <br> This field appears only if you select **Script** value for the **Action Type** field. | Close session |

8. Select **Save and Close** to add, save, and close the quick create form.

9. Select **Save** to save the changes.

## Add agent script control to a form

After you create agent script, you must add the agent script field to the form where you want to show it for the agents.

1. Sign in to the Common Data Service platform.

2. Select **Settings** > **Customizations** > **Customize the System**. **Solution Explorer** opens in a new window.

3. Expand **Entities** and select the entity for which you want to add the field. In this procedure, let us add to the **Customer Summary** form in the **Conversation** entity.

4. Expand **Conversation** > **Forms** > **Customer Summary**. The **Customer Summary** form opens in a new window.

5. Select **INSERT** tab from the command bar, and then select **Section** > **One Column** in the command bar.

    > [!div class=mx-imgBorder] 
    > ![Add section](../media/agent-script-control5.png "Add section")

6. Select the section, and then select **Change Properties** from the command bar. The **Section Properties** dialog appears.

7. Specify **Agent script** as the value for both **Name** and **Label** field.

8. Select the **Show the label of this section on the Form**  check box, and then select **OK**.

    > [!div class=mx-imgBorder] 
    > ![Add name and show label](../media/agent-script-control8.png "Add name and show label")

9. Select a field of type **Text** from **Field Explorer**. For example, the **Title** field is of type **Text**. If you hover the cursor on a field, you can view the type.

    > [!div class=mx-imgBorder] 
    > ![Add field of type Text](../media/agent-script-control9.png "Add field of type Text")

10. Drag and drop the **Title** field to the section you added in earlier step.

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

