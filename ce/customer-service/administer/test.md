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
- Transcription is enabled for the channels that support voice conversations. For more information, see [Enable transcription for voice channels](voice-channel-configure-transcripts.md#enable-call-recording-and-transcription-for-voice).
-  We recommend that you enable audit history and make sure service representatives have the required access to the case and related entities that the AI agent updates. Learn more in [Manage Dataverse auditing](/power-platform/admin/manage-dataverse-auditing).

### Update field and option set descriptions in Power Apps

To help the AI agent make better predictions when filling lookup fields, we recommend adding descriptive information to your lookup records. Perform the following steps in Power Apps:

- For the AI agent to understand the context of each field, add meaningful field descriptions in your table columns. This helps the AI better interpret what the data represents during predictions. For example, for the **Account Number** column in the Account table, add a description like: "This is an account number, and account numbers start with ACC."
-  Define what each choice value represents to enable the AI agent make smarter, more relevant suggestions when creating or updating records—reducing manual errors and improving efficiency. Do the following:
  - For the required lookup entity, add a new optional text field on to contain a description of a record.
  - For each choice value in the lookup field, add a description that explains its meaning and usage.
  - Update the **Quick Find** view of the lookup entity to include the new description field as a column.
  - Save and publish the changes.

## Configure autonomous case updates

In Copilot Service admin center, do the following steps for the AI agent to predict and update case fields autonomously based on an ongoing conversation or an incoming email. 

> [!NOTE]
> - If you don’t configure update rules, the AI agent won’t update case fields automatically.
> - The AI agent can predict and update fields of the following data types:
>   - Lookup fields. Upto 50 options are supported for each lookup field.
>   - Boolean
>   - Integer
>   - Choice
>   - Option Set
>   - Currency
>   - Multiple Lines of Text
>   - Single line of text
>   - Email

1. In **Customer support**, select **Case settings**.
2. On the **Case settings** page, select **Manage** for **Case Management Agent**.
3. On the **Case Management Agent** page, select **Case creation and update with autonomous AI assistance (preview)**.
1. In the page that appears, in **Case update by AI agent (any channel)**, select **Create** to define a rule that sets the conditions for the agent to predict and update case fields based on an ongoing conversation or an incoming email. Specify the following:
   - A unique name for the rule. 
   - Define the conditions under which the AI agent should apply the rule. If not defined, the rule is applied to all cases.
   - On the **Default list of fields for AI prediction**, specify the fields the agent must fill in the case form using information from the chat or email conversation.  
   - In **Rules for case update with AI assistance**, specify the fields the agent must update from an ongoing conversation or incoming email after creating a case.
   - Select **Save**.
1. The system runs the case update rules in the order they're listed. You can select the arrow buttons to reorder the rules as needed.
1. Select **Activate** to activate the rules.

## Configure autonomous case creation
   
1. To enable the AI agent to autonomously create cases for all the provisioned channels in the environment, select the **Make Case Processing Agent available for case creation from conversations** in the **Case creation and update (preview)** > **Case creation by AI agent (from chats and calls)**.
1. In **Fields for AI prediction**, specify the fields the agent must fill in the case form using information from the conversation.  

## Configure AI-assisted case creation for service representatives

Select the channels from which customer service representatives can create cases with AI assistance. When enabled, the AI agent analyzes the conversation or email and suggests case details. Agents can review and confirm these AI-generated suggestions before the case is created.

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
- **Fields for AI prediction**: Issue description, Contact  

For an ongoing conversation, the AI agent must update the **Issue description** and **Contact** fields, if there are any updates. Additionally, the **Product**, **Priority**, and **Serial number** fields should also be updated if the case category is set to **product defect**. 

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
