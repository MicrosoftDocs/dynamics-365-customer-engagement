---
title: Setup autonomous case management (preview)
description: Learn how to set up autonomous case management agents to help customer support teams efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 03/04/2025
ms.custom: bap-template
---


# Setup autonomous case creation and update (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The autonomous case management agent streamlines case creation, reducing manual effort and minimizing data entry errors.

Autonomous case management agents streamline the creation and maintenance of cases as follows: 

- From conversations. The agent analyses the live chat conversation, predicts and populates the relevant field values, and updates case details as the conversation progresses. 
- From emails. [Automatic record creation and update(ARC) rules](automatically-create-update-records.md#activities-and-entities-supported-by-rules-for-creating-or-updating-records-automatically) create cases from emails. After a case is created using these rules, the agent updates the fields in the case based on ongoing email interactions with customers. 

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- Administrators must have the CSR Manager or System Administrator role.
- Customer Service Representatives must have the Omnichannel Agent and Customer Service Representative role.
- Enable [AI form fill assistance](/power-platform/admin/settings-features#ai-form-fill-assistance) in Power Platform admin center.
- [Automatic record creation and update (ARC) rules](../administer/set-up-rules-to-automatically-create-or-update-records.md) are set up to create case records from emails.
- [Provision the live chat channel](/dynamics365/contact-center/implement/provision-channels) and make sure that [authentication settings are configured](../administer/create-chat-auth-setting.md). 
- [Workstreams](../administer/create-workstreams.md) and [queues](../administer/queues-omnichannel.md) are set up.
-  [Enable data movement across regions](/power-platform/admin/geographical-availability-copilot) in the Power Platform admin center.

## Set up a pay-as-you-go plan

The autonomous case management agent uses the Data Entry Agent in the background.

The [Power Platform pay-as-you-go](/power-platform/admin/pay-as-you-go-overview) plan mandates the usage of an Azure subscription the system charges when the agent runs. To [set up pay-as-you-go billing for an environment](/power-platform/admin/pay-as-you-go-set-up?tabs=new), you need an active Azure subscription that you can link to that environment.

To keep track of the cost, you can [view usage and billing information](/power-platform/admin/pay-as-you-go-usage-costs).


## Configure autonomous case creation and update

In Customer Service admin center, perform the following steps:

1. In **Customer support**, select **Case settings**.
2. On the **Case settings** page, select **Manage** for **Case Management Agent**.
3. In the **Case Management Agent** page, select **Case creation and update with autonomous AI assistance (preview)**.
4. In the page that appears, select the channels that AI can use to create or update cases. You can select **Live chat** and **Email**.
5. In the **Default list of fields for AI prediction**, specify the fields the agent must fill in the case form using information from the chat or email conversation.  
   - For a conversation, the agent evaluates the conversation and then creates a case only if there’s enough context in the conversation to predict the default fields.  
   - New cases are created from emails based on the ARC rules configured. The case management agent populates the fields in the case created by ARC if there’s enough context available in the email. Fields populated when the case is created aren't overwritten by the agent.
6. Optionally, in **Rules for case update with AI assistance**, specify the fields the agent must update from an ongoing conversation or incoming email after creating a case. If you don't specify update rules, the agent updates the fields you added in the previous step.
7. Select the checkbox in the **Agent experience data** section if you want the application to save the agent interactions in Dataverse. You can then use this information to build reports.

> [!NOTE]
> We recommend that you enable audit history and ensure service representatives have the required access to the case and related entities that the AI agent updates. Learn more in [Manage Dataverse auditing]/power-platform/admin/manage-dataverse-auditing).

## Enable service representatives to use autonomous case management agents

For agents to use the case management agents in Customer Service workspace, enable the autonomous case creation and update, case follow-up, and closure in **agent experience profiles**.

By default, service representatives added to the out-of-the-box agent experience profiles can use the autonomous case management agent.

1. Go to **Agent experience profiles** using one of the following navigation options:
   - **Agent experience** > **Workspaces**
   - In **Case Management Agent**, you can select **Agent experience profiles** **Case creation and update with autonomous AI assistance** > **Agent access** > **Agent experience profiles**
   - **Customer Support** > **Case settings** > **Case Management agent** > **Case follow-up and closure > Agent access > agent experience profiles**
2. Select the required agent experience profile.
3. In the **Copilot AI features** section:
   - Select **Edit** and then enable the required features:  
     - **Autonomous case creation and update from conversations**  
     - **Autonomous case follow-up and closure**


## Example 

When a customer initiates a live chat conversation with the service representative, the AI agent must create a case only if it can predict the values of **Issue description** and **Contact** fields.

For the agent to execute this scenario, specify the following in the **Case creation and update with autonomous AI assistance (preview)** page:
 
- **Channel**: Chat  
- **Default list of fields for AI prediction**: Issue description, Contact  

In the case created by the AI agent, for an ongoing conversation, if the service representative selects **Update from conversation** the AI agent must update the **Issue description** and **Contact** fields, if there are any updates. Additionally, the **Product**, **Priority**, and **Serial number** fields should also be updated if the case category is set to **product defect**. 

For the agent to execute this scenario, in addition to the **Issue description** and **Contact** fields set in **Default list of fields for AI prediction** specify the following in the **Case creation and update with autonomous AI assistance (preview)** page:

- Select **Create** for **Case update rules**. 
- In the **New rule** page, specify the **Rule name** and the following:
  - In **Define conditions**, select **Add** and then specify the following:
    - **Select a field:** Case category  
    - **Operator:** Equals  
    - **Value:** Product defect  
  - Specify fields for AI prediction when this condition is met:  
    - **Product**, **Priority**, **Serial number**



## Next steps

 [Use autonomous case management agents (preview)](../use/use-case-creation-agent.md)