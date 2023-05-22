---
title: Enable Copilot features in Customer Service
description: Learn how to enable the various Copilot features in Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to
ms.date: 05/22/2023 
ms.custom: bap-template 
ms.collection: 
---

# Enable and manage Copilot (Preview) features in Customer Service

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Copilot provides real-time AI assistance that helps agents automate time consuming tasks to handle cases efficiently and resolve issues faster so that they can deliver value to customers.

Enable the Copilot features for agents to use Copilot to: 
- Respond to questions.
- Compose an email. 
- Draft a chat response. 
- Summarize a case.

## Regional availability and supported languages

The Copilot features are available in the United States only and supported in English only.

## Prerequisites

- You have the System Administrator role.
- [Knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#setup-overview) and [Integrated search](add-search-provider.md) are configured in your environment.

### Opt-in to continue with Copilot setup

 Before you enable a Copilot feature, review the terms and conditions and provide your consent to use Copilot. To opt in, go to either the **Copilot help pane (preview)** or **Summaries (preview)** pages in Customer Service admin center and then select **Opt in** to continue with the setup.

## Enable Copilot to respond to questions, compose an email, or a chat response

Perform the following steps to enable the Copilot features:

1. In Customer Service admin center select **Productivity** in **Agent Experience**.
2. In **Productivity**, select **Manage** in **Copilot help pane (preview)**.
1. Select the following options: 
    - **Make Copilot available to agents**: To display the **Ask a question** tab on the **Copilot help pane (preview)** when agents login. Agents can ask questions conversationally, and the Copilot answers the questions based on the internal and external knowledge base sources and trusted domains.
    - **For customer chat**: To display the one-click response generation button on both the conversation panel for a conversation and on the Ask a question tab on the Copilot help pane. Copilot understands the context and drafts the response based on the knowledge resources configured for your organization.
    - **For email**:  To display the **Write an email** tab on the **Copilot help pane (preview)**. Copilot helps agents create email responses based on the context of the case.
1. Copilot automatically refreshes your knowledge base and displays the date and time of when it was last updated. You can also select **Update knowledge base** to manually update the knowledge base.
1. You can add up to five web trusted web domains for Copilot to search when generating responses. Select **Add web address** in **Web resources** to add trusted external domains. To limit the content you want Copilot to use, specify up to two levels, represented by back slashes (/) after the .com part of the URL. 

## Enable summarization of cases

Copilot case summaries help agents understand the context of a case, enabling them to resolve customer issues efficiently. Agents get a concise summary of the case with key information such as the case title, customer, case subject, product, priority, case type, and case description.

To allow Copilot to summarize cases, perform the following steps:

1. In Customer Service admin center select **Productivity** in Agent Experience.
2. In **Productivity**, select **Manage**  in **Summaries (preview)**.
1. Select **Make case summaries available to agents** to display a summary of the case on the Case page. 

Perform the steps in [display case summary on custom case forms](copilot-powerapps-settings.md) for the Copilot case summary to be displayed on custom case forms.

## Record feedback

In the corresponding Copilot configuration pages, you can select **Record transcripts of agent interaction with Copilot, agent actions, and agent feedback on AI suggestions** to record and understand how agents are interacting with Copilot and how Copilot is performing in a support organization. Agents can also share feedback about Copilot actions, that helps Copilot perform better. You can use the data to analyze knowledge sources, and also build usage reports.

## Make Copilot available to agents

For agents to be able to use the Copilot help pane and Copilot case summaries, you need to enable the Copilot features in agent experience profiles.

1. Go to **Agent experience profiles** in **Agent experience** > **Workspaces**.
1. Select the required agent experience profile.
1. In the **Productivity Pane**, select **Turn On** for **Copilot (preview)**.

 For more information, see: [Add users to agent experience profiles](../app-profile-manager/add-profile-default.md) and [Assign users, templates, configure productivity pane, channels](../app-profile-manager/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels)

## Assign roles and privileges

Out of the box, users with the Customer Service Representative role only can use the Copilot features. Therefore, make sure that users with custom roles have the following privileges: 
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

More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges)


## Next steps

[Display Copilot case summary on custom case forms](copilot-powerapps-settings.md)
