---
title: Set-up Case Management Agent for case creation and update (preview)
description: Learn how to set up autonomous Case Management Agent to help customer support teams efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 03/31/2025
ms.custom: bap-template
---


# Set-up Case Management Agent to create and update cases (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Case Management Agent automates case creation and thereby reduces manual effort and data entry errors.

The agent creates and updates cases as follows: 

- From conversations: The agent analyzes chat; predicts and populates the relevant field values; and updates case details during the conversation.
- From emails: [Automatic record creation and update rules](automatically-create-update-records.md) create cases from emails. After a case is created using these rules, the agent updates the case fields based on the ongoing email interactions with customers.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- Administrators must have the CSR Manager or System Administrator role.
- Customer service representatives (service representatives or representatives) must have the Omnichannel Agent and Customer Service Representative role.
- Enable [AI form fill assistance](/power-platform/admin/settings-features#ai-form-fill-assistance) in the Power Platform admin center application.
- [Automatic record creation and update rules](automatically-create-update-records.md) are set up to create case records from emails.
- [Provision the chat channel](/dynamics365/contact-center/implement/provision-channels) and make sure that [authentication settings are configured](create-chat-auth-settings.md). 
- [Workstreams](create-workstreams.md) and [queues](queues-omnichannel.md) are set up.
-  [Enable data movement across regions](/power-platform/admin/geographical-availability-copilot) in the Power Platform admin center application.


## Configure autonomous case creation and update

In Customer Service admin center, follow these steps:

1. In **Customer support**, select **Case settings**.
2. On the **Case settings** page, select **Manage** for **Case Management Agent**.
3. On the **Case Management Agent** page, select **Case creation and update with autonomous AI assistance (preview)**.
4. In the page that appears, select the channels that AI can use to create or update cases. You can select **Chat** and **Email**. 
1. On the **Default list of fields for AI prediction**, specify the fields the agent must fill in the case form using information from the chat or email conversation.  
   - For a conversation, the agent evaluates the conversation and then creates a case only if there’s enough context in the conversation to predict the default fields.  
   - New cases are created from emails based on the automatic record creation rules configured. The Case Management Agent populates the fields in the case created by the record creation rules if there’s enough context available in the email. Fields populated when the case is created aren't overwritten by the agent.
1. Optionally, in **Rules for case update with AI assistance**, specify the fields the agent must update from an ongoing conversation or incoming email after creating a case. If you don't specify update rules, the agent updates the fields you added in the previous step.

> [!NOTE]
> We recommend that you enable audit history and ensure service representatives have the required access to the case and related entities that the AI agent updates. Learn more in [Manage Dataverse auditing](/power-platform/admin/manage-dataverse-auditing).

## Enable service representatives to use autonomous Case Management Agent

For service representatives to use the Case Management Agent in Customer Service workspace, enable the autonomous case creation and update, case follow-up, and closure in **agent experience profiles**.

By default, service representatives added to the out-of-the-box agent experience profiles can use the autonomous Case Management Agent.

1. Go to **Agent experience profiles** using one of the following navigation options:
   - **Agent experience** > **Workspaces**
   - In **Case Management Agent**, you can select **Agent experience profiles** **Case creation and update with autonomous AI assistance** > **Agent access** > **Agent experience profiles**
   - **Customer Support** > **Case settings** > **Case Management Agent** > **Case follow-up and closure > Agent access > agent experience profiles**
2. Select the required agent experience profile.
3. In the **Copilot AI features** section:
   - Select **Edit** and then enable the required features:  
     - **Autonomous case creation and update from conversations**  
     - **Autonomous case follow-up and closure**


## Example 

When a customer initiates a chat conversation with the service representative, the AI agent creates a case only if it can predict the values of **Issue description** and **Contact** fields.

For the agent to execute this scenario, specify the following in the **Case creation and update with autonomous AI assistance (preview)** page:
 
- **Channel**: Chat  
- **Default list of fields for AI prediction**: Issue description, Contact  

For an ongoing conversation, if the service representative selects **Update from conversation** the AI agent must update the **Issue description** and **Contact** fields, if there are any updates. Additionally, the **Product**, **Priority**, and **Serial number** fields should also be updated if the case category is set to **product defect**. 

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
