---
title: Enable Copilot features in Customer Service (preview)
description: Learn how to enable the various Copilot features in Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to
ms.date: 06/29/2023
ms.custom: bap-template 
ms.collection:
---

# Manage Copilot features in Customer Service (preview)

[This article is prerelease documentation and is subject to change.]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

Copilot in Customer Service provides real-time AI assistance that helps agents automate time-consuming tasks to handle cases efficiently and resolve issues faster so that they can deliver value to customers.

Enable the Copilot features for agents to use Copilot to:
- Respond to questions
- Compose an email
- Draft a chat response
- Summarize a case and conversation

## Prerequisites

- You have the System Administrator role.
- [Knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#setup-overview) is configured in your environment. 
- Your knowledge article parameters are as follows:
   - Updated with the latest version
   - The state is set to Published
   - The locale is set to English

## Region availability and supported languages

Copilot AI features are available by default to only those customers with environments that have United States as their geography for data processing and storage. See: [Region availability of analytics and insights](cs-region-availability-service-limits.md#region-availability-of-analytics-and-insights).

For enabling the Copilot features outside the United States, see [Copilot data movement across geographies](copilot-data-movement.md).

To learn about supported languages for Copilot, see [Language support for AI-based analytics and insights in Customer Service](cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service).

### Enable public preview for geographies outside of United States

1. Enable [cross geo support](cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service) based on your location.
1. Go to [Power Platform admin center](https://admin.powerplatform.microsoft.com/) and select **Environments**.
1. Select the environment you'd like to enable the copilot features in and then copy the value of the **Organization ID**.
1. Email a request to `d365_csaipreview@microsoft.com` with your **Organization ID** to enable the preview. 

## Opt in to continue with Copilot setup

Before you enable a Copilot feature, review the terms and conditions, and then provide your consent to use Copilot. To opt in, go to either the **Copilot help pane (preview)** or **Summaries** pages in Customer Service admin center, and then select **Opt in** to continue with the setup.

## Enable Copilot summaries

Copilot case and conversation summaries help you to quickly understand the context of a case and resolve customer issues more efficiently.

### Enable case summaries

Case summaries help agents understand the context of a case, enabling them to resolve customer issues efficiently. Agents get a concise summary of the case with the case title, customer, case subject, product, priority, case type, and case description.
 
1. In Customer Service admin center, select **Make Copilot available to agents** in **Copilot help pane (preview)** for Copilot case summaries to be available.
1. Use one of the following navigation options: 
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**
1. Select **Manage** in **Summaries**.
1. Select **Make case summaries available to agents** to display a summary of the case on the **Case** page. 

Perform the steps in [Display case summary on custom case forms](copilot-powerapps-settings.md) for the Copilot case summary to be displayed on custom case forms.

### Enable conversation summaries

Conversation summaries enable agents to collaborate effectively with other agents and contacts, by enabling agents to easily recap an ongoing chat or a transcribed voice conversation.

For Copilot to automatically trigger a conversation summary for a live conversation, select the following options in the **Summaries** page:
   - **When an agent joins a conversation**: Generates a summary when an agent joins a conversation. A summary is also generated when the primary agent invites a collaborator and a second agent joins the conversation or when the primary agent transfers a conversation.
   - **When a conversation ends**: Generates a summary when the conversation ends. 
      - Select **Allow agents to create case with a button in the summary** to allow agents to see the **Create case** button in the conversation summary. A new case is created when the agent selects **Create case**.
   - **On demand, by selecting a button to summarize the conversation**: Generate a summary at any point in the conversation, whenever the agent selects the copilot **Summarize conversation**.

## Enable Copilot help pane

Perform the following steps to enable the Copilot features:

1. In Customer Service admin center, use one of the following navigation options: 
      - **Agent Experience** > **Productivity** > **Copilot help pane (preview)**
      - **Operations** > **Insights** > **Copilot help pane (preview)**
1. Select **Manage** in **Copilot help pane (preview)**. The Copilot help pane (preview) page appears. You can select the Copilot features you'd like to enable for agents on this page.

  :::image type="content" source="media/copilot-admin-email-mini.png" alt-text="Ask a question in Copilot pane." lightbox="media/copilot-admin-email.png":::

### Features supported with different knowledge sources

The following table summarizes the Copilot features supported for a configured knowledge source.

| Feature|Knowledge base | External web resources |
|-------|----------|---------|--------|
|Ask a question |✔|X|
|Write an email | ✔|✔|
|Draft a response |✔|✔|

### Enable ask a question

Select **Make Copilot available to agents** in the **Copilot help pane (preview)** page. The **Ask a question** tab on the **Copilot help pane (preview)** appears when agents sign in. Agents can ask questions conversationally, and Copilot answers the questions based on the internal and external knowledge base sources and trusted domains.

### Enable draft a response

Select **For customer chat** in the **Copilot help pane (preview)** page. The one-click response generation button appears on both the conversation panel for a conversation and on the **Ask a question** tab on the Copilot help pane. Copilot understands the context and drafts the response based on the knowledge resources configured for your organization.

### Enable write an email

Select **For email** in the **Copilot help pane (preview)** page. The **Write an email** tab appears on **Copilot help pane (preview)**. Copilot helps agents create email responses based on the context of the case.

### Add trusted webpages as sources

You can select **Add web address** in **Web resources** to add trusted domains. You can add up to five trusted web domains for Copilot to search and generate responses from. To limit the content you want Copilot to use, specify up to two levels, represented by forward slash (/) after the .com part of the URL.

> [!NOTE]
> - By default, the knowledge base content is refreshed every week.
> - Web domains are used by Copilot to only draft emails and chat replies.

### Set up filters

Filters enable Copilot to generate responses based on a specific set of topics. You can set up filters for ask a question and draft a response features by sending an email a request to d365_csaipreview@microsoft.com. See: [Apply filters](use-copilot-features.md#apply-filters).

## Record feedback

In the **Summaries** and **Copilot help pane** configuration pages, you can select **Record transcripts of agent interaction with Copilot, agent actions, and agent feedback on AI suggestions** to record and understand how agents are interacting with Copilot and how Copilot is performing in a support organization. Agents can also share feedback about Copilot actions, which helps Copilot perform better. You can use the data to analyze knowledge sources, and also build usage reports.

## Make Copilot available to agents

For agents to be able to use the copilot help pane and copilot summaries in Customer Service workspace, you need to enable the copilot features in [agent experience profiles](../app-profile-manager/add-profile-default.md). For Customer Service Hub, when you enable the feature, it will be available to all the agents.

1. Go to [**Agent experience profiles**](../app-profile-manager/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels) in **Agent experience** > **Workspaces**.
1. Select the required agent experience profile.
1. In the **Productivity Pane**, select **Turn On** for **Copilot (preview)**.
1. In **Copilot AI features**, select the required features such as **Ask a question**, **Scan customer conversation and suggest a response**, **Write an email**, **Case summary**, **Live conversation summary** depending on the features you want to enable for that profile.  

## Assign roles and privileges

Out of the box, users with the Customer Service Representative role only can use the copilot features. Therefore, make sure that users with custom roles have the following privileges: 

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


More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges)

## Data sharing for copilot features

You can enable data sharing for Dynamics 365 copilot features in the Power Platform admin center. This allows Microsoft to capture and manually review customer data including, but not limited to, users’ natural language inputs, outputs, and related telemetry to build, improve, and/or validate Microsoft’s features, services, machine learning models, and related systems for Dynamics 365 and Power Platform Copilot AI features. We don't use customer data to train Azure OpenAI Service foundation models. 

More information: [Tenant settings](/power-platform/admin/tenant-settings) and [FAQ for optional data sharing for Copilot AI features in Dynamics 365 and Power Platform](/power-platform/faqs-copilot-data-sharing)

### Next steps

[Display Copilot case summary on custom case forms](copilot-powerapps-settings.md)  
[Use Copilot features](use-copilot-features.md)  
[Responsible AI FAQ for copilot features](faq-copilot-for-customer-service.md)  
