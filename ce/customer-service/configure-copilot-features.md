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

Agents can use the following Copilot features to assist them to: 
- Respond to questions
- Compose an email 
- Draft a chat response 
- Summarize a case 

## Regional availability and supported languages

The Copilot features are available only in the United States and supported only in English.

## Prerequisites

You have the System Administrator role.
 
### Opt-in to continue with Copilot setup

 Before you enable a Copilot feature, review the terms and conditions and  provide your consent to use the Copilot features. You can navigate the corresponding setup pages for the Copilot features in  Customer Service admin center and Opt in to continue with the setup.

   :::image type="content" source="media/copilot-opt-in-mini.png" alt-text="enable Copilot for customer summary" lightbox="media/copilot-opt-in.png":::

## Enable Copilot to respond to questions, compose an email, or a chat response

Perform the following steps to enable the Copilot features:

1.	In Customer Service admin center select **Productivity** in Agent Experience.
2.	In **Productivity**, select **Manage**  in **Copilot help pane (preview)**.
1. Select the following options: 
    - **Make Copilot available to agents**: To display the **Ask a question** tab on the productivity pane when agents login. Agents can ask questions conversationally, and the Copilot answers them based on the configured internal and external knowledge base sources and trusted domains. For more information to setup internal and external knowledge bases, see: [Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#setup-overview) and [Integrated search providers](add-search-provider.md).
    - **For customer chat**: To display the draft a response button on both the conversation panel and the productivity panel. Copilot understands the context and drafts the response based on the knowledge resources configured for your organization.
    - **For email**:  To display the **Write an email** tab on the productivity pane. Copilot helps agents create email responses based on the context of the case.
1. Copilot automatically refreshes your knowledge base and displays the date and time of when it was last updated. You can also use the **Update knowledge base** option to manually update the knowledge base.
1. You can add up to five web trusted web domains for Copilot to search when generating responses. Select **Add web address** in **Web resources** to add trusted external domains. To limit the content you want Copilot to use, specify up to two levels – represented by back slashes (/) after the .com part of the address. 

   :::image type="content" source="media/copilot-admin-email-mini.png" alt-text="enable Copilot for customer summary" lightbox="media/copilot-admin-email.png":::

### Enable Copilot in agent experience profiles

You can use agent experience profiles to control which agents get access to the Copilot help pane. To enable the Copilot features for an agent experience profile, perform the following steps:

1. Go to **Agent experience profiles** in **Agent experience** > **Workspaces**.
1. Select the required agent experience profile.
1. In the **Productivity Pane**, select **Turn On** for **Copilot (preview)**.

 For more information, see: [Add users to agent experience profiles](../app-profile-manager/add-profile-default.md) and [Assign users, templates, configure productivity pane, channels](../app-profile-manager/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels)

## Enable summarization of conversations

Copilot case summaries are designed to help support agents quickly understand the context of a case, enabling them to resolve customer issues more efficiently. Agents get a concise summary of the case, which includes key information such as the case title, customer, case subject, product, priority, case type, and case description.

To allow Copilot to summarize conversations, perform the following steps:

1.	In Customer Service admin center select **Productivity** in Agent Experience.
2.	In **Productivity**, select **Manage**  in **Copilot help pane (preview)**.
1. Select **Make case summaries available to agents** to display a summary of the case to on the Case page. 
1. Select the following options to define when you want the conversations to be summarized:
   - **When an agent joins the conversation**: To display the conversation summary when an agent has joined the conversation. This is applicable to conversations escalated to a human agent from a bot, transferred conversations, or when the agent invites a collaborator.
   - **When the conversation ends**: To display the summary when the conversation ends.
   - **Allow agents to create a case with a button in the summary**: To display the **Create Case** button in the summary generated when an agent ends the conversation.
   - **On demand, by selecting a button to summarize the conversation**: To display the conversation summary when an agent selects the summarize button on the conversation.
  
   > [!NOTE]
   > The conversation summary generated by Copilot might vary from the conversation summary generated by the existing AI model. For more information, see: [Set up auto-summarization for conversations](cs-enable-AI-generated-summary.md)

   :::image type="content" source="media/copilot-admin-summary-mini.png" alt-text="enable Copilot for customer summary" lightbox="media/copilot-admin-summary.png":::

### Record feedback

In the corresponding Copilot configuration pages, you can select **Record transcripts of agent interaction with Copilot, agent actions, and agent feedback on AI suggestions** to record how agents are interacting with Copilot and understand its impact. Agents can share feedback about Copilot actions. This helps Copilot perform better. You can use the data to analyze knowledge sources, and also build usage reports. 
