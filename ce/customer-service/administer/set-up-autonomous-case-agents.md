---
title: Set up Case Management Agent for case creation and update 
description: Learn how to set up autonomous Case Management Agent to help customer support teams efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/23/2025
ms.custom: bap-template
---


# Set up Case Management Agent to create and update cases

Case Management Agent streamlines the case management process, reducing manual effort and data entry errors.

You can use the creation and update feature of Case Management Agent to do the following actions:

- Create cases autonomously from conversations in voice, live chat, and other digital messaging channels. The agent identifies key details and creates cases automatically.
- Predict and update case fields autonomously in the following scenarios:
     - When the AI agent creates a case autonomously from a conversation
     - When a customer service representative (service representative or representative) manually creates a case from an email or conversation
     - When a case is created from an incoming email using automatic record creation and update rules

## Prerequisites

- Administrators must have the CSR Manager or System Administrator role.

- Enable [AI form fill assistance](/power-platform/admin/settings-features#ai-form-fill-assistance) in the Power Platform admin center application.
- [Automatically create or update records](automatically-create-update-records.md) are set up to create case records from emails.
- The following configurations are set up if you want to create a case from conversations:
    - [Provision channels in Dynamics 365 Contact Center](/dynamics365/contact-center/implement/provision-channels).
    - Make sure you [configure authenticated chat](create-chat-auth-settings.md). Case Management Agent can create and update cases from authenticated chats only.
    - [Create and manage workstreams](create-workstreams.md) and [Create and manage queues for unified routing](queues-omnichannel.md) are set up.
-  [Move data across regions for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot) in the Power Platform admin center application.
- Case Management Agent uses the Data Entry Agent in the background. The Power Platform [Pay-as-you-go plan](/power-platform/admin/pay-as-you-go-overview) mandates the usage of an Azure subscription the system charges when the agent runs. Make sure you [Set up consumption-based billing](setup-pay-as-you-go.md).
- Transcription is enabled for the channels that support voice conversations. For more information, see [Enable transcription for voice channels](voice-channel-configure-transcripts.md#enable-call-recording-and-transcription-for-voice).
- We recommend that you enable audit history and make sure service representatives have the required access to the case and related entities that the AI agent updates. Learn more in [Manage Dataverse auditing](/power-platform/admin/manage-dataverse-auditing).
- For customers to provide the details that the AI agent can use, you can configure [preconversation survey](configure-pre-chat-survey.md).
- Make sure the service representatives working on the case and accepting conversations have read privileges on the `msdyn_entityattributepredictionrules` table.
- For the AI agent to predict case fields from emails autonomously, do the steps in [Configure global settings for Case Management Agent](case-management-global-settings.md).

### Update field and lookup descriptions in Power Apps

To help the AI agent make better predictions for lookup fields, add descriptive information to your lookup records. Do the following steps in Power Apps:

- Add meaningful field descriptions in your table columns to help the AI understand the context. For example, in the **Account Number** column of the **Account** table, add a description like: "This is an account number. Account numbers start with ACC."
-  Do the following steps to improve the AI agent's prediction accuracy with lookup fields:
    - For the required lookup entity, add a new optional text field to contain a description of the record if a description field doesn't already exist.
    - Add the meaning and usage for the description fields in the lookup records.
    - Update the **Quick Find** view of the lookup entity to include the new description field as a column. 
    - Save and publish the changes.
    
  For example, consider case categories like "Billing" and "Account Issues". When a customer writes "I can't access my account to pay my bill," it fits both categories. By adding clear descriptions to each lookup record, the AI agent can make more accurate predictions. If you include descriptions to the "Billing" category such as "Questions about charges and invoices, payment processing issues, refund requests," and  "Login problems and password resets, profile updates and settings, account access difficulties" to "Account issues", the AI agent categorizes the customer's message as "Account Issues" because the primary problem relates to account access rather than billing.
   > [!NOTE]
   > The Subject entity includes a description field by default, but we recommend not using these descriptions for lookup predictions because subject lookup views are read-only.

**Best practices for lookup descriptions**

We recommend that you follow these guidelines when you are adding descriptions for lookup fields:

- Use simple, direct language and keep the descriptions under two or three sentences to ensure clarity. Don't add unnecessary information or domain jargon.
- Include typical scenarios, keywords, and phrases that users might use when describing their issue. This helps the AI agent to make semantic connections between user input and the correct record.
- Distinguish between similar records by specifying what makes each record unique, preventing confusion and improving prediction accuracy.
- Don’t repeat the record name unless it adds clarity. Specify what the name doesn't convey about the record's intended use and scope.
- Use labeled sections like "Use when:" or "Not for:" to provide clear boundaries and usage guidelines for the AI agent.
- Provide synonyms, related terms, and specific examples. Avoid terms such as "general" or "miscellaneous" that lack meaningful context.
- Avoid overly generic descriptions, excessive detail, unexplained abbreviations, and assumptions about internal business logic that the AI agent can't access or understand.

## Configure autonomous case updates

In Copilot Service admin center, configure the AI agent to predict and update case fields after a conversation ends or when processing an incoming email. The rules you specify in this section apply to all channels unless you explicitly configure them to apply to specific channels.

> [!NOTE]
> The AI agent can predict and update fields of the following data types:
> - Lookup fields. Upto 50 options are supported for each lookup field.
> - Boolean
> - Integer
> - Choice
> - Option Set
> - Currency
> - Multiple Lines of Text
> - Single line of text
> - Email

1. In **Customer support**, select **Case settings**.
2. On the **Case settings** page, select **Manage** for **Case Management Agent**.
3. On the **Case Management Agent** page, select **Case creation and update with autonomous AI assistance**.
1. In the page that appears, in **Case update by AI agent (any channel)**, select **Create**. Specify the following information:
   - A unique name for the rule. 
   - Conditions for the AI agent to apply the rule. If no conditions are defined, the rule applies to all channels.
   - Fields in **Fields for AI prediction** that the agent predicts and updates when the conversation ends or from an incoming email. If you don't specify update rules, the AI agent doesn't autonomously update any fields.
   - Select **Save**.   
  
 For example, if you only specify **Issue description** and **Contact** fields in the **Fields for AI prediction** section, the AI agent updates these fields when the conversation ends or from an incoming email. If you also specify a condition such as live chat status equals Active, then the rule applies only for live chat conversations that are active.

1. The system runs case update rules in the order they're listed. You can select the arrow buttons to reorder the rules as needed.
1. Select **Activate** to activate the rules.
1. Select **Allow AI agent to override human edits during autonomous updates** for the AI agent to automatically overwrite fields. During autonomous case update, the AI agent overwrites fields that were previously edited by service representatives. 

## Configure autonomous case creation

The following actions trigger the case creation process of Case Management Agent:

- The service representative accepts an incoming conversation request.
- The service representative ends the conversation.

To allow the AI agent to autonomously create cases across all provisioned messaging and voice channels, perform the following steps:

1. Go to **Case creation and update** > **Case creation by AI agent (from chats and calls)** and select **Make Case Processing Agent available for case creation from conversations**.
1. In **Fields for AI prediction**, specify the fields the agent predicts and populates in the case form using information from the conversation. The AI agent populates only those fields that have sufficient context available.

##  Run simulations to evaluate field prediction accuracy in Case Management Agent

Use the simulation capability in Case Management Agent to validate how well AI‑powered field prediction performs on your organization’s historical data or sample email or chat inputs. Simulation helps administrators assess prediction quality before enabling the feature in production, ensuring confidence in the output.

> [!NOTE]
> - Simulations run the same field prediction pipeline that Case Management Agent uses in live cases. As predictions are generated in bulk, simulations consume Copilot or AI credits in the same way as regular field predictions. You must ensure that Pay‑as‑you‑go billing is configured for your environment. Learn more in [Set up consumption-based billing](setup-pay-as-you-go.md).
> - Simulation results are calculated based on your organization’s historical field values. If historical data contains inaccurate or inconsistent entries, simulation accuracy may appear lower even when the AI prediction is correct.

Before you run a simulation, ensure the following:

- [Field descriptions and best practices](#update-field-and-lookup-descriptions-in-power-apps) are configured in [Power Apps](https://make.powerapps.com/). Accurate field descriptions help the AI agent understand each field’s meaning and improve prediction quality.
- Field prediction rules (fields to be predicted) are already defined in Case Management Agent settings. Learn more in [Configure autonomous case updates](#configure-autonomous-case-updates) and [Configure autonomous case creation](#configure-autonomous-case-creation).

### Set up a simulation

1. In **Customer support**, select **Case settings**.
1. On the **Case settings** page, select **Manage** for **Case Management Agent**.
1. On the **Case Management Agent** page, select **Case creation and update**.
1. On the **Case creation and update** page, select **Go to simulation**. The **Case creation and update simulation** page appears.
1. On the **Simulation setup** tab, provide the following information:
  1. Provide a simulation name. For example: Surface product cases, Refund category evaluation, or Email‑based sample test.
  1. Select a data source from the dropdown. 
  You can run simulations using one of two data sources:

#### **Organization records**

Select this option to test field prediction against existing cases.
  
  1. Select **Organization records**. 
  1. In the **Conditions** section, use the condition builder to state conditions that must pass to continue with the simulation.
  1. Select **Save conditions**. A list or records appear in the **Selected records** section. You can select upto 100 records. 
  1. Select **Run simulation**. It uses emails and conversation threads from the relevant cases to generate the prediction. Your role must have access to this content. 

#### **Excel file**

Select this option to test predictions on the email body, chat transcripts, or any sample text.
  
  1. Select **Excel file**.
  1. Select **Upload**. The maximum file size is 1 MB and you can upload an excel with a maximum of 100 rows.

Irrespective of the number of columns or column name, as shown below, all inputs are consolidated into a single string before being passed to the Case Management Agent for prediction.

Excel sample 1:

|Email  |
|---------|
|Subject: Login Issue <br> Hello Support Team, <br>I’m unable to log in to my account despite using the correct credentials. Please help resolve this issue. <br> Thanks, John Doe. <br> Mobile: +91 xxxxx xxxx    |
|Subject: Password Reset Help <br> Hello Customer Support, <br>I’m not receiving the password reset email. Could you please assist? Regards, John Doe. <br>Mobile: +91 xxxxx xxxx |

Excel sample 2:


|Email subject  | Email body  |Sent  |
|---------|---------|---------|
|Login Issue | Hello Support Team, <br>I’m unable to log in to my account despite using the correct credentials. Please help resolve this issue. <br>Thanks, John Doe. <br>Mobile: +91 xxxxx xxxx |  6/1/26 8pm    |
|Password Reset Help |  Hello Customer Support, I’m not receiving the password reset email. Could you please assist?<br> Regards, John Doe. <br> Mobile: +91 xxxxx xxxx  | 6/1/26 8pm |



### View a simulation report

1. On the **Case creation and update simulation** page, go to the **Simulation report** tab.
  A new entry appears with the details such as, simulation name, run date and time, and current status.
1. Select **Download results** to export an Excel report.
1. If you update your field descriptions or modify prediction rules, you can rerun a simulation by selecting **Re-run**. This reprocesses the same set of records without the need to select or upload again.

When you download an excel report, it shows the following for each record:
- Record ID
- Predicted field values
- If multiple fields are selected for prediction, each field appears in a separate column.

#### Best practices for data sources

- Start with small record sets (20–30 cases) to validate your field descriptions.
- Run multiple simulations focusing on:
  - Different product lines
  - Different categories
  - Different languages or regions
- Refine field descriptions whenever prediction errors show recurring patterns.
- Use excel upload testing to evaluate chat transcripts or new email templates before launching new workflows. 

## Configure AI-assisted case creation for service representatives

Select the channels from which service representatives can create cases with AI assistance. You can select **Email** or **Conversation(chats and calls)**. When a service representative creates a case from a conversation or an email, the AI agent analyzes the conversation or email and predicts and populates the fields available on the case form. Service representatives can then review the predicted values and make any necessary changes before saving the case.

## Enable service representatives to use autonomous Case Management Agent

For service representatives to use Case Management Agent in Copilot Service workspace, allow the autonomous case creation and update, case follow-up, and closure in **agent experience profiles**.

By default, service representatives added to the out-of-the-box experience profiles can use the autonomous Case Management Agent.

1. Go to **Experience profiles** using one of the following navigation options:
   - **Support experience** > **Workspaces**
   -  Select **Manage** for **Case Management Agent**, and then select **agent experience profiles** in **Case creation and update** > **Representative access**.
2. Select the required experience profile.
3. In the **Copilot AI features** section do the following actions:
     - Select **From conversations** in **Autonomous case creation and update**.
     - In **Form fill assistance for cases** select **During case creation from conversation** and **During case creation from email** to indicate which channels the AI agent can assist service representatives in creating cases.
  
## Record representative interactions with the AI agent

In **Agent experience data from Representative experience data**, you can select **Record transcripts of representative interactions with AI, including representative actions, and their feedback on AI suggestions** to record and understand how representatives are interacting with the AI agent and how the agent is performing in a support organization. Representatives can also share feedback about AI agent actions, which helps Copilot perform better. You can also download and use the data to analyze knowledge sources, and build usage reports.

### Example

When a customer initiates a chat conversation with the service representative, the AI agent creates a case if there is enough context to update at least one of the **Issue description** or **Contact** fields.

For the agent to run this scenario, specify the following in the **Case creation and update** page:
 
- **Channel**: Chat  
- **Fields for AI prediction**: Issue description, Contact  

When the conversation ends, the AI agent must update the **Issue description** and **Contact** fields, if there are any updates. The **Product**, **Priority**, and **Serial number** fields should also be updated if the case category is set to **product defect**. 

For the agent to run this scenario, in addition to the **Issue description** and **Contact** fields set in **Fields for AI prediction**, specify the following in the **Case update by AI agent (any channel)** section:

- Select **Create** for **Case update rules**. 
- In the **New rule** page, specify the **Rule name** and the following:
  - In **Define conditions**, select **Add** and then specify the following:
    - **Select a field:** Case category  
    - **Operator:** Equals  
    - **Value:** Product defect  
  - Specify fields for AI prediction when this condition is met:  
    - **Product**, **Priority**, **Serial number**

## Next steps

[Use Case Management Agent to create and update cases](../use/use-case-creation-agent.md)  
