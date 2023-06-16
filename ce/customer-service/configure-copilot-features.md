---
title: Enable Copilot features in Customer Service
description: Learn how to enable the various Copilot features in Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to
ms.date: 06/16/2023 
ms.custom: bap-template 
ms.collection:
---

# Manage Copilot features in Customer Service (Preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Copilot in Customer Service provides real-time AI assistance that helps agents automate time consuming tasks to handle cases efficiently and resolve issues faster so that they can deliver value to customers.

Enable the Copilot features for agents to use Copilot to:
- Respond to questions
- Compose an email
- Draft a chat response
- Summarize a case and conversation

## Region availability and supported languages

For region availability of Copilot, see [Region availability of analytics and insights](cs-region-availability-service-limits.md#region-availability-of-analytics-and-insights).

For enabling the copilot features outside the United States, see [Copilot data movement across geographies](copilot-data-movement.md).

To learn about supported languages for Copilot, see [Language support for AI-based analytics and insights in Customer Service](cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service).

## Prerequisites

You have the System Administrator role.

## Opt-in to continue with Copilot setup

Before you enable a copilot feature, review the terms and conditions and provide your consent to use Copilot. To opt in, go to either the **Copilot help pane (preview)** or **Summaries (preview)** pages in Customer Service admin center, and then select **Opt in** to continue with the setup.

## Enable copilot features

Perform the following steps to enable the copilot features:

1. In Customer Service admin center, use one of the following navigation options:
      - **Agent Experience** > **Productivity** > **Copilot help pane (preview)**
      - **Operations** > **Insights** > **Copilot help pane (preview)**
1. Select **Manage** in **Copilot help pane (preview)**.
1. Select the following options: 
    - **Make Copilot available to agents**: Will display the **Ask a question** tab on the **Copilot help pane (preview)** when agents sign in. Agents can ask questions conversationally, and Copilot answers the questions based on the internal and external knowledge base sources and trusted domains.
    - **For customer chat**: Will display the one-click response generation button on both the conversation panel for a conversation and on the **Ask a question** tab on the Copilot help pane. Copilot understands the context and drafts the response based on the knowledge resources configured for your organization.
    - **For email**: Will display the **Write an email** tab on the **Copilot help pane (preview)**. Copilot helps agents create email responses based on the context of the case.
1. **Knowledge sources**: Select one of the following options that Copilot will use to generate responses.<br>
    - **Knowledge base**: Copilot generates responses using the internal knowledge base as the source. [Knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#setup-overview) should be configured. Knowledge articles should have the following parameters:
       - The version is up to date.
       - The state is set to **Published**
       - The locale is set to **English**
      By default, the knowledge base content is refreshed every week.
    - **SharePoint**: Copilot generates responses using the content uploaded to SharePoint as the source. Supported files include: .doc, .docx, .pdf, .ppt, .pptx, .txt. You can add multiple SharePoint URLs. The SharePoint sites must belong to the same tenant as the current organization.<br>
    If you don't have a SharePoint site configured, the **SharePoint** option is disabled. You can select **Manage SharePoint providers** to add your SharePoint URL. See: [Set up a search provider](set-up-search-providers.md#set-up-a-search-provider). Make sure that your SearchPoint site is a part of the same tenant as the current organization.
1. Select **Add web address** in **Web resources** to add trusted domains. You can add up to five trusted web domains for Copilot to search and generate responses from. To limit the content you want Copilot to use, specify up to two levels, represented by forward slash (/) after the .com part of the URL.
> [!NOTE]
> Web domains are used by Copilot to draft emails and chat replies only.

:::image type="content" source="media/copilot-admin-email-mini.png" alt-text="Ask a question in Copilot pane." lightbox="media/copilot-admin-email.png":::

### Features supported with different knowledge sources

The following table summarizes the copilot features supported for a configured knowledge source.

| Feature|Knowledge base | SharePoint | External web resources |
|-------|----------|---------|--------|
|Ask a question |✔|✔|X|
|Write an email | ✔|✔|✔|
|Draft a response |✔|✔|✔|


### How Copilot uses knowledge sources

Based on the knowledge source you select, the Copilot responses vary.

For example, an agent asks a question about an espresso issue in the coffee machine, SmartBrew 3000. The following table summarizes the interaction between an agent and Copilot, based on the option enabled.

|Knowledge base | SharePoint|
|----------------|--------------|
|When th agent asks a question, the application triggers an API to search the internal knowledge base, retrieves and summarizes the relevant knowledge articles. Copilot uses the summary to generate a response. |  When the agent asks a question, the application searches for the keywords in each of the configured sites, and retrieves the top three results, which are then made into snippets. Copilot generates the response based on these snippets.<br><b>NOTE</b><br> We recommend the following:<br>- Ensure that the keywords you search with are as precise as possible. If the keywords you've used aren't present in the SharePoint documents, then Copilot can't generate responses.<br> - When you ask follow up turn by turn questions, Copilot might not generate the responses that you're expecting.|
|:::image type="content" source="media/copilot-km-mini.png" alt-text="Copilot internal km" lightbox="media/copilot-km-main.png":::|:::image type="content" source="media/copilot-sharepoint-mini.png" alt-text="Sharepoint copilot responses" lightbox="media/copilot-sharepoint-main.png":::|

## Enable summarization of cases and conversations

Copilot generated case and conversation summaries enhance agent collaboration and productivity as follows:

- Case summaries help agents understand the context of a case, enabling them to resolve customer issues efficiently. Agents get a concise summary of the case with the case title, customer, case subject, product, priority, case type, and case description.
- Conversation summaries enable agents to collaborate effectively with other agents and contacts, by enabling agents to easily recap an ongoing chat or a transcribed voice conversation. 

> [!IMPORTANT]
> You must select **Make Copilot available to agents** in **Copilot help pane (preview)**  for Copilot case summaries to be available.

1. In Customer Service admin center, use one of the following navigation options: 
    - **Agent Experience** > **Productivity** > **Summaries (preview)**
    - **Operations** > **Insights** > **Summaries (preview)**
1. Select **Manage**  in **Summaries (preview)**.
1. Select **Make case summaries available to agents** to display a summary of the case on the Case page. 
1. For Copilot to automatically trigger a conversation summary, select the following options:
   - **When an agent joins a conversation**: Will generates a summary when an agent joins the conversation. This is applicable to transferred conversation or when an agent invites a collaborator to join the conversation.
   - **When a conversation ends**: Will generate a summary when the conversation ends. 
      - Select **Allow agents to create case with a button in the summary** to allow agents to see the **Create case** button in the conversation summary. A new case is created when the agent selects **Create case**.
   -  **On demand, by selecting an button to summarize the conversation** : Will generates a summary at any point in the conversation, whenever the agent selects the copilot **Summarize conversation**.

Perform the steps in [Display case summary on custom case forms](copilot-powerapps-settings.md) for the Copilot case summary to be displayed on custom case forms.

## Record feedback

In the corresponding Copilot configuration pages, you can select **Record transcripts of agent interaction with Copilot, agent actions, and agent feedback on AI suggestions** to record and understand how agents are interacting with Copilot and how Copilot is performing in a support organization. Agents can also share feedback about Copilot actions, which helps Copilot perform better. You can use the data to analyze knowledge sources, and also build usage reports.

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
- prvReadmsdyn_conversationinsight

> [!IMPORTANT]
> For the Copilot case summary to be displayed, you must add the prvReadmsdyn_conversationinsight privilege to the out-of-the-box Customer Service Representative role.


More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges)

### Next steps

[Display Copilot case summary on custom case forms](copilot-powerapps-settings.md)  
[Use Copilot features](use-copilot-features.md)  

