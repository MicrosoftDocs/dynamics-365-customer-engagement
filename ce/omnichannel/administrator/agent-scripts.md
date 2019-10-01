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

In the contact center industry, agents need to deal with continuous updates both in the product and processes. Even after providing rigorous training to the agents, there are recurrent human errors and delays in service delivery due to a lack of guidance in real-time customer scenarios. These issues lead to lower productivity and thus impacts customer satisfaction levels. To avoid the errors and ensure the adherence of processes, agents need guidance.

Agent scripts provide guidance to agents about what they should to doing when they get a customer issue. It ensures that only accurate, company-endorsed information is being shared, while also safeguarding the organization in regard to legal-compliance issues. Agent scripts help organizations to be unified, accurate, and effective while being faster and more-efficient in terms of customer handling.

## Value propositions

- Minimization of human errors

- Adherence to business processes

- Lower Average Handling Time

- Improved customer satisfaction

## Prerequistes

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
    | Target macro | Type the name of the macro in the text box and select a macro from the lookup results. <br><br> **Note:** <br> This field appears only if you select **Macro** value for the **Action Type** field. | Email |
    | Target script | Type the name of the script in the text box and select a script from the lookup results. <br><br> **Note:** <br> This field appears only if you select **Script** value for the **Action Type** field. | Close session |

8. Select **Save and Close** to add, save, and close the quick create form.

9. Select **Save** to save the changes.
