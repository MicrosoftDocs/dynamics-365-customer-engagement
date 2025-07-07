---
title: Set up Case Management Agent for case creation and update (preview)
description: Learn how to set up autonomous Case Management Agent to help customer support teams efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 05/26/2025
ms.custom: bap-template
---


# Set up Case Management Agent to create and update cases (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Case Management Agent allows autonomous case creation and updates, reducing manual effort and data entry errors.

You can use the case management agent to do the following actions:

- Create a case autonomously from a conversation. For voice, live chat, and other digital messaging channels, the agent picks up on key details and creates a case.
- Predict and update the case fields autonomously in the following scenarios:
    - When a case is created autonomously by the agent from a conversation.
    - When a case is created by the customer service representative from an email or a conversation.
    - When a case is created from an incoming email using the [Automatic record creation and update rules](automatically-create-update-records.md).

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- Administrators must have the CSR Manager or System Administrator role.
- Customer service representatives (service representatives or representatives) must have the Omnichannel Agent and Customer Service Representative role.
- Enable [AI form fill assistance](/power-platform/admin/settings-features#ai-form-fill-assistance) in the Power Platform admin center application.
- [Automatically create or update records](automatically-create-update-records.md) are set up to create case records from emails.
- [Provision channels in Dynamics 365 Contact Center](/dynamics365/contact-center/implement/provision-channels) and make sure you [configure authentication settings](create-chat-auth-settings.md). 
- [Create and manage workstreams](create-workstreams.md) and [Create and manage queues for unified routing](queues-omnichannel.md) are set up.
-  [Move data across regions for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot) in the Power Platform admin center application.
- The Autonomous Case Management agent uses the Data Entry Agent in the background. The Power Platform [Pay-as-you-go plan](/power-platform/admin/pay-as-you-go-overview) mandates the usage of an Azure subscription the system charges when the agent runs. Make sure you [Set up consumption-based billing](setup-pay-as-you-go.md).


## Configure autonomous case updates

1. In **Customer support**, select **Case settings**.
2. On the **Case settings** page, select **Manage** for **Case Management Agent**.
3. On the **Case Management Agent** page, select


In Copilot Service admin center, follow these steps:

1. In **Customer support**, select **Case settings**.
2. On the **Case settings** page, select **Manage** for **Case Management Agent**.
3. On the **Case Management Agent** page, select **Case creation and update with autonomous AI assistance (preview)**.
4. In the page that appears, select the channels that AI can use to create or update cases. You can select **Chat** and **Email**. 
1. On the **Default list of fields for AI prediction**, specify the fields the agent must fill in the case form using information from the chat or email conversation.  
   - For a conversation, the agent evaluates the conversation and then creates a case only if there’s enough context in the conversation to predict the default fields.  
   - New cases are created from emails based on the automatic record creation rules configured. The Case Management Agent populates the fields in the case created by the record creation rules if there’s enough context available in the email. Fields populated during case creation remains unchanged by the agent.
1. Optionally, in **Rules for case update with AI assistance**, specify the fields the agent must update from an ongoing conversation or incoming email after creating a case. If you don't specify update rules, the agent updates the fields you added in the previous step.

> [!NOTE]
> We recommend that you enable audit history and make sure service representatives have the required access to the case and related entities that the AI agent updates. Learn more in [Manage Dataverse auditing](/power-platform/admin/manage-dataverse-auditing).

## Enable service representatives to use autonomous Case Management Agent

For service representatives to use the Case Management Agent in Copilot Service workspace, allow the autonomous case creation and update, case follow-up, and closure in **agent experience profiles**.

By default, service representatives added to the out-of-the-box experience profiles can use the autonomous Case Management Agent.

1. Go to **Experience profiles** using one of the following navigation options:
   - **Support experience** > **Workspaces**
   -  Select **Manage** for **Case Management Agent**, and then select **agent experience profiles** in **Case creation and update with autonomous AI assistance** > **Agent access**.
   - **Customer Support** > **Case settings** > **Case Management Agent** > **Case follow-up and closure** > **Agent access** > **agent experience profiles**
2. Select the required experience profile.
3. In the **Copilot AI features** section:
   - Select **Edit** and then enable the required features:  
     - **Autonomous case creation and update from conversations**  
     - **Autonomous case follow-up and closure**


## Example 

When a customer initiates a chat conversation with the service representative, the AI agent creates a case only if it can predict the values of **Issue description** and **Contact** fields.

For the agent to run this scenario, specify the following in the **Case creation and update with autonomous AI assistance (preview)** page:
 
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

 [Use Case Management Agent to create and update cases (preview](../use/use-case-creation-agent.md)
