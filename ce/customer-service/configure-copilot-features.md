---
title: "Configure Copilot features in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Configure Copilot features."
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to
ms.date: 05/19/2023 
ms.custom: bap-template 

---

# Configure Copilot features

Copilot provides real-time AI powered assistance that helps agents resolve issues faster, handle cases more efficiently, and automate time-consuming tasks so that they can focus on delivering high-quality service to their customers.

When you enable the Copilot features, agents can use Copilot to assist them with: 
- Responding to questions
- Composing an email 
- Drafting a chat response 
- Summarizing a case or a conversation 

## Regional availability and supported languages

The Copilot features are available only in the United States and supported only in English.

## Prerequisites

- You have the System Administrator role.
- Knowledge management is configured in your environment. For more information, see: [Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#setup-overview) and [Integrated search providers](add-search-provider.md).
- 
 
### Opt-in to continue with Copilot setup

 Before you enable a Copilot feature, review the terms and conditions and  provide your consent to use Copilot. You can navigate the corresponding setup pages for the Copilot features in  Customer Service admin center and then select **Opt in** to continue with the setup.

   :::image type="content" source="media/copilot-opt-in-mini.png" alt-text="enable Copilot for customer summary" lightbox="media/copilot-opt-in.png":::

## Enable Copilot to respond to questions, compose an email, or a chat response

Perform the following steps to enable the Copilot features:

1.	In Customer Service admin center select **Productivity** in Agent Experience.
2.	In **Productivity**, select **Manage** in **Copilot help pane (preview)**.
1. Select the following options: 
    - **Make Copilot available to agents**: To display the **Ask a question** tab on the **Copilot help pane (preview)** when agents login. Agents can ask questions conversationally, and the Copilot answers them based on the configured internal and external knowledge base sources and trusted domains. 
    - **For customer chat**: To display the draft a response button on both the conversation panel and the productivity panel. Copilot understands the context and drafts the response based on the knowledge resources configured for your organization.
    - **For email**:  To display the **Write an email** tab on the **Copilot help pane (preview)**. Copilot helps agents create email responses based on the context of the case.
1. Copilot automatically refreshes your knowledge base and displays the date and time of when it was last updated. You can also use the **Update knowledge base** option to manually update the knowledge base.
1. You can add up to five web trusted web domains for Copilot to search when generating responses. Select **Add web address** in **Web resources** to add trusted external domains. To limit the content you want Copilot to use, specify up to two levels – represented by back slashes (/) after the .com part of the address. 

   :::image type="content" source="media/copilot-admin-email-mini.png" alt-text="enable Copilot for customer summary" lightbox="media/copilot-admin-email.png":::

## Enable summarization of cases

Copilot case summaries are designed to help support agents quickly understand the context of a case, enabling them to resolve customer issues more efficiently. Agents get a concise summary of the case with key information such as the case title, customer, case subject, product, priority, case type, and case description. 

To allow Copilot to summarize cases and conversations, perform the following steps:

1.	In Customer Service admin center select **Productivity** in Agent Experience.
2.	In **Productivity**, select **Manage**  in **Copilot help pane (preview)**.
1. Select **Make case summaries available to agents** to display a summary of the case on the Case page. 

   :::image type="content" source="media/copilot-admin-summary-mini.png" alt-text="enable Copilot for customer summary" lightbox="media/copilot-admin-summary.png":::

Perform the steps in [display case summary on custom case forms](copilot-powerapps-settings.md) to ensure that the Copilot case summary is displayed in custom forms.

## Record feedback

In the corresponding Copilot configuration pages, you can select **Record transcripts of agent interaction with Copilot, agent actions, and agent feedback on AI suggestions** to record how agents are interacting with Copilot and understand its impact. Agents can share feedback about Copilot actions. This helps Copilot perform better. You can use the data to analyze knowledge sources, and also build usage reports.

## Enable Copilot in agent experience profiles

You can use agent experience profiles to control which agents get access to the Copilot help pane. To enable the Copilot features for an agent experience profile, perform the following steps:

1. Go to **Agent experience profiles** in **Agent experience** > **Workspaces**.
1. Select the required agent experience profile.
1. In the **Productivity Pane**, select **Turn On** for **Copilot (preview)**.

 For more information, see: [Add users to agent experience profiles](../app-profile-manager/add-profile-default.md) and [Assign users, templates, configure productivity pane, channels](../app-profile-manager/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels)

## Assign roles and privileges

Only users with the Customer Service Representative role can use the Copilot capabilities. If users have using custom roles, ensure that they have the following privileges. More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges)

- prvCreatemsdyn_copilotinteraction 
- prvAppendmsdyn_copilotinteraction 
- prvCreatemsdyn_copilotinteractiondata 
- prvWritemsdyn_copilottranscriptdata 
- prvAppendTomsdyn_copilottranscriptdata 
- prvReadmsdyn_copilottranscript 
- prvCreatemsdyn_copilottranscript 
- prvWritemsdyn_copilottranscript 
- prvAppendTomsdyn_copilottranscript 
- prvReadmsdyn_copilottranscriptdata 
- prvCreatemsdyn_copilottranscriptdata 
- prvWritemsdyn_copilottranscriptdata 
- prvAppendmsdyn_copilottranscriptdata 
- prvReadmsdyn_agentcopilotsetting 
- prvReadmsdyn_copilotsummarizationsetting 
- prvIntelligenceUsage 

