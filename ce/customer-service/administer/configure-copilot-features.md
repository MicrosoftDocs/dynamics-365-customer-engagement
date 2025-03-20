---
title: Enable Copilot features in Customer Service
description: Learn how to enable the various Copilot features in Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.date: 03/14/2025
ms.custom: bap-template 
ms.collection: bap-ai-copilot
---

# Manage Copilot features in Customer Service 

Copilot in Customer Service provides real-time AI assistance that helps agents automate time-consuming tasks to handle cases efficiently and resolve issues faster so that they can deliver value to customers.

When you enable the Copilot features, agents can do the following actions in the Customer Service workspace app: 
- Respond to questions
- Compose an email
- Draft a chat response
- Summarize a case and conversation

However, for agents to use these features in Customer Service Hub and custom apps, you must perform the steps in [Enable Copilot features](copilot-powerapps-settings.md#enable-copilot-features-for-custom-apps). 

> [!NOTE]
> Summarize conversations is available for use in Customer Service workspace only.


## License requirements

- Dynamics 365 Customer Service Enterprise license for summarize cases, ask a question, draft emails, and copilot analytics features.
- Customer Service add-in (Chat, Digital Messaging, or Voice) license for draft a chat response and summarize conversations features.

## Prerequisites

You must have the System Administrator role.

## Region availability and data movement

The option to enable Copilot AI features is available by default to customers with environments that have United States, Australia, India, and United Kingdom as their geography for data processing and storage. For Europe, data movement for copilot features is enabled by default. For all other regions, [enable data movement across regions](/power-platform/admin/geographical-availability-copilot) in the Power Platform admin center app before you can opt in to use Copilot.

  :::image type="content" source="../media/ppac-enable-gen-ai.png" alt-text="Screenshot of the power platform admin center generative ai features.":::

The respond to questions, compose an email, and summarize cases and conversations features are generally available in the North America region only. These features are in preview in the rest of the supported regions. Learn more in [Region availability](cs-region-availability-service-limits.md#region-availability-of-analytics-and-insights).

### Understand cross region data movement for Copilot features

Copilot feature performance is based on the regional availability of the Azure OpenAI services. The following table describes the scenarios in which you must [enable data movement across regions](/power-platform/admin/geographical-availability-copilot) in the Power Platform admin center app before you can opt in to use Copilot.

|Scenario| Requires enabling data movement |
|----------------|------------------|
| Azure OpenAI capacity is available in the same region as your tenant. | No |
| Azure OpenAI capacity is available outside of your tenant. | Yes |
| Azure OpenAI capacity is available in your tenant region, but has fallback to external regions. | Optional. However, if you don't enable data movement, you might have performance issues, such as throttling or unavailability due to capacity constraints.  |

> [!NOTE]
> Data movement across regions is enabled by default in Power Platform admin center.

## Supported languages

Learn about supported languages for Copilot in [Language support for AI-based analytics and insights in Customer Service](cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service).


## Data sharing for copilot features

You can enable data sharing for Dynamics 365 copilot features in the Power Platform admin center app. Data sharing allows Microsoft to capture and manually review customer data, including, but not limited to, users' natural language inputs, outputs, and related telemetry to build, improve, and/or validate Microsoft's features, services, machine learning models, and related systems for Dynamics 365 and Power Platform Copilot AI features. We don't use customer data to train Azure OpenAI Service foundation models.

Learn more in [Tenant settings](/power-platform/admin/tenant-settings) and [FAQ for optional data sharing for Copilot AI features in Dynamics 365 and Power Platform](/power-platform/faqs-copilot-data-sharing).

## Opt in to continue with Copilot setup

In Customer Service admin center, on the [**Copilot for questions and emails**](/dynamics365/contact-center/administer/copilot-enable-help-pane) or [**Summaries**](/dynamics365/contact-center/administer/copilot-enable-summary) pages, the application displays the following message and links:

- An error message to enable data movement across regions if you're in a region where Copilot features aren't available by default or if you want to opt out of using Copilot.
- A link to the Power Platform admin center app to enable data movement across regions.
- The data movement status.
- A link to review the terms and conditions. You can select **Opt in** to continue with the setup.  

  :::image type="content" source="../media/copilot-enable-opt-in-mini.png" alt-text="Screenshot of the Copilot Help Pane page." lightbox="../media/copilot-enable-opt-in.png":::

## Opt out of using Copilot features

In Customer Service admin center, opt out from the Copilot features on the **Copilot for questions and emails** or **Summaries** page. When you opt out, the application erases the training data. If you want to use the features again, you must consent to the terms of use and opt in.

## Make Copilot available to agents

For agents to be able to use the Copilot features in Customer Service workspace, you need to enable the Copilot features in [agent experience profiles](add-profile-default.md). By default, agents added to the out-of-the-box agent experience profiles can use the Copilot features.

If you want to limit the features that agents can use, you can create a custom agent experience profile and enable the required features. You can then [assign the custom profile to the agents](add-profile-default.md).

For Customer Service Hub, when you enable the feature, it's available to all the agents.

To add the Copilot features to an agent experience profile, perform the following steps:

1. Go to [**Agent experience profiles**](create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels) using one of the following navigation options:
   - **Agent experience** > **Workspaces**
   - **Copilot for questions and emails* > **Agent access** > **agent experience profiles**
1. Select the required agent experience profile.
1. On the **Productivity Pane**, turn on the **Copilot help pane** toggle so that agents can use the Copilot features such suggest a response, ask a question, and write an email on the productivity pane.

   :::image type="content" source="../media/copilot-help-pane-enable-mini.png" alt-text="Screenshot of the Productivity panel in agent experience profile." lightbox="../media/copilot-help-pane-enable.png":::|

1.  In the **Copilot AI features** section, select **Edit**, and then select the required features that you want to enable for that profile, such as **Ask a question**, **Scan customer conversation and suggest a response**, **Write an email**, **Case summary**, **Live conversation summary**.  

    :::image type="content" source="../media/copilot-agent-experience-mini.png" alt-text="Screenshot of Copilot AI features section in Copilot." lightbox="../media/copilot-agent-experience.png":::|

    > [!NOTE]
    > You must turn on the **Copilot help pane** toggle to enable the **Ask a question**, **Scan customer conversation and suggest a response**, **Write an email** features.

## Record agent interactions with Copilot

In the **Summaries** and **Copilot help pane** configuration pages, you can select **Record transcripts of agent interaction with Copilot, agent actions, and agent feedback on AI suggestions** to record and understand how agents are interacting with Copilot and how Copilot is performing in a support organization. Agents can also share feedback about Copilot actions, which helps Copilot perform better. You can also [download](../develop/download-copilot-transcript-data.md) and use the data to analyze knowledge sources, and build usage reports.


## Assign roles and privileges

Out of the box, users with the Customer Service Representative role only can use the copilot features. Therefore, make sure that users with custom roles have the following privileges: 

|Table | Name | Create | Read | Write | Append | Append To |
|------|------|--------|------|-------|--------|-----------|
|Copilot interaction | msdyn_copilotinteraction | Yes | Yes | Not applicable | Yes | Not applicable |
|Copilot interaction data | msdyn_copilotinteractiondata | Yes | Yes | Yes | Not applicable | Yes |
|Agent Preference For Copilot | msdyn_copilotagentpreference | Yes | Yes | Yes | Not applicable | Not applicable |
|AI Model | msdyn_aimodel | Not applicable | Yes | Not applicable | Not applicable | Not applicable |
|AI Template | msdyn_aitemplate | Not applicable | Yes | Not applicable | Not applicable | Not applicable |
|ConversationInsight | msdyn_conversationinsight | Not applicable | Yes | Not applicable | Not applicable | Not applicable |
|Copilot Transcript Data | msdyn_copilottranscriptdata | Yes | Yes | Yes | Yes | Not applicable |
|App profile | msdyn_appconfiguration | Not applicable | Yes | Not applicable | Not applicable | Not applicable |
|Pane tool configuration | msdyn_panetoolconfiguration | Not applicable | Yes | Not applicable | Not applicable | Not applicable |
|Productivity pane configuration | msdyn_paneconfiguration | Not applicable | Yes | Not applicable | Not applicable | Not applicable |
|Pane tab configuration | msdyn_panetabconfiguration | Not applicable | Yes | Not applicable | Not applicable | Not applicable |
|Organization Setting | organizationsetting | Not applicable | Yes | Not applicable | Not applicable | Not applicable |


> [!NOTE]
> Make sure that your users have **Miscellaneous privileges** > **prvIntelligenceUsage** assigned to the required custom security roles to access the Copilot case summary. Learn more in [Security roles and privileges](/power-platform/admin/security-roles-privileges).
 

## Next steps

[Enable Copilot case and conversation summaries](/dynamics365/contact-center/administer/copilot-enable-summary)  
[Enable Copilot help pane](/dynamics365/contact-center/administer/copilot-enable-help-pane)  
[Display Copilot case summary on custom case forms](copilot-powerapps-settings.md)  

### Related information
 
[Use Copilot features](../use/use-copilot-features.md)  
[Responsible AI FAQ for copilot features](../implement/faq-responsible-ai-copilot.md)  
[FAQ for Copilot in Customer Service](faq-copilot-features.md)  
