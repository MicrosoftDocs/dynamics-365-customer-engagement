---
title: Enable Copilot features in Customer Service (preview)
description: Learn how to enable the various Copilot features in Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to
ms.date: 09/26/2023
ms.custom: bap-template 
ms.collection:
---

# Manage Copilot features in Customer Service 


Copilot in Customer Service provides real-time AI assistance that helps agents automate time-consuming tasks to handle cases efficiently and resolve issues faster so that they can deliver value to customers.

Enable the Copilot features for agents to use Copilot to:
- Respond to questions
- Compose an email
- Draft a chat response
- Summarize a case and conversation

## License requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Customer Service Enterprise for summarize cases, ask a question, draft emails, and copilot analytics</li><li>Customer Service add-in (Chat, Digital Messaging, or Voice) for draft a chat response and summarize conversations</li></ul> |

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
1. Select the environment in which you'd like to enable the copilot features, and then copy the value of the **Organization ID**.
1. Email a request to `d365_csaipreview@microsoft.com` with your **Organization ID** to enable the preview. 

## Opt in to continue with Copilot setup

Before you enable a Copilot feature, review the terms and conditions, and then provide your consent to use Copilot. To opt in, go to  the [**Copilot help pane (preview)**](copilot-enable-help-pane.md) or [**Summaries**](copilot-enable-summary.md) pages in Customer Service admin center, and then select **Opt in** to continue with the setup.

## Record feedback

In the **Summaries** and **Copilot help pane** configuration pages, you can select **Record transcripts of agent interaction with Copilot, agent actions, and agent feedback on AI suggestions** to record and understand how agents are interacting with Copilot and how Copilot is performing in a support organization. Agents can also share feedback about Copilot actions, which helps Copilot perform better. You can use the data to analyze knowledge sources, and also build usage reports.

## Make Copilot available to agents

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

For agents to be able to use the copilot help pane and copilot summaries in Customer Service workspace, you need to enable the copilot features in [agent experience profiles](../app-profile-manager/add-profile-default.md). For Customer Service Hub, when you enable the feature, it will be available to all the agents.

1. Go to [**Agent experience profiles**](../app-profile-manager/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels) in **Agent experience** > **Workspaces**.
1. Select the required agent experience profile.
1. In the **Productivity Pane**, select **Turn On** for **Copilot (preview)**.
1. In **Copilot AI features**, select the required features **Ask a question**, **Scan customer conversation and suggest a response**, **Write an email**, **Case summary**, **Live conversation summary**, you want to enable for that profile.  

## Assign roles and privileges

Out of the box, users with the Customer Service Representative role only can use the copilot features. Therefore, make sure that users with custom roles have the following privileges: 

- prvCreatemsdyn_copilotinteraction 
- prvAppendmsdyn_copilotinteraction 
- prvCreatemsdyn_copilotinteractiondata  
- prvReadmsdyn_copilotagentpreference
- prvCreatemsdyn_copilotagentpreference
- prvWritemsdyn_copilotagentpreference
- prvReadmsdyn_agentcopilotsetting 
- prvReadmsdyn_copilotsummarizationsetting 
- prvReadmsdyn_conversationinsight
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
- prvIntelligenceUsage

More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges)

## Data sharing for copilot features

You can enable data sharing for Dynamics 365 copilot features in the Power Platform admin center. This allows Microsoft to capture and manually review customer data including, but not limited to, users’ natural language inputs, outputs, and related telemetry to build, improve, and/or validate Microsoft’s features, services, machine learning models, and related systems for Dynamics 365 and Power Platform Copilot AI features. We don't use customer data to train Azure OpenAI Service foundation models. 

More information: [Tenant settings](/power-platform/admin/tenant-settings) and [FAQ for optional data sharing for Copilot AI features in Dynamics 365 and Power Platform](/power-platform/faqs-copilot-data-sharing)

### Next steps

[Display Copilot case summary on custom case forms](copilot-powerapps-settings.md)  
[Use Copilot features](use-copilot-features.md)  
[Responsible AI FAQ for copilot features](faq-copilot-for-customer-service.md)  
