---
title: Manage Copilot features in Customer Service
description: Learn how to enable Copilot features in Dynamics 365 Customer Service to help customer service representatives handle cases more efficiently and resolve issues faster.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.date: 03/31/2026
ms.update-cycle: 180-days
ms.custom: bap-template 
ms.collection: bap-ai-copilot
---

# Manage Copilot features in Customer Service 

Copilot in Customer Service provides real-time AI assistance for customer service representatives (service representatives or representatives). It helps automate time-consuming tasks so representatives can handle cases efficiently, resolve issues faster, and deliver more value to customers.

When you turn on Copilot features, service representatives can respond to questions, compose emails, draft chat responses, and summarize case and conversation details in the Copilot Service workspace app.

However, for service representatives to use these features in Customer Service Hub and custom apps, you must perform the steps in [Enable Copilot features](copilot-powerapps-settings.md#enable-copilot-features-for-custom-apps). 

> [!NOTE]
> Summarize conversations is available for use in Copilot Service workspace only.

## Prerequisites

- You must have the System Administrator role.
- Specific licensing requirements apply when you use the feature with product environments. Learn more in [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

## Region availability and data movement

The option to enable Copilot AI features is available "in region"<sup>**1**</sup> by default to customers with environments that have United States, Australia, India, United Kingdom, and government cloud regions (GCC, GCC High) as their geography for data processing and storage. For Europe, data movement for Copilot features is enabled by default. For all other regions, [enable data movement across regions](/power-platform/admin/geographical-availability-copilot) in the Power Platform admin center app before you can opt in to use Copilot.

<sup>**1**</sup> In region means within the geographical region of your Power Platform or Dynamics 365 environment.

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


## Data sharing for Copilot features

You can turn on data sharing for Dynamics 365 Copilot features in the Power Platform admin center app. Data sharing allows Microsoft to capture and manually review customer data. This data includes users' natural language inputs, outputs, and related telemetry. Microsoft uses this data to build, improve, and validate features, services, machine learning models, and related systems for Dynamics 365 and Power Platform Copilot AI features. We don't use customer data to train Azure OpenAI foundation models.

Learn more in [Tenant settings](/power-platform/admin/tenant-settings) and [FAQ for optional data sharing for Copilot AI features in Dynamics 365 and Power Platform](/power-platform/faqs-copilot-data-sharing).

## Opt in to continue with Copilot setup

In Copilot Service admin center, on the [**Copilot settings**](/dynamics365/contact-center/administer/copilot-enable-help-pane) or [**Summaries**](/dynamics365/contact-center/administer/copilot-enable-summary) page, the application displays the following message and links:

- An error message to allow data movement across regions if you're in a region where Copilot features aren't available by default or if you want to opt out of using Copilot.
- A link to the Power Platform admin center app to allow data movement across regions.
- The data movement status.
- A link to review the terms and conditions. You can select **Opt in** to continue with the setup.  

  :::image type="content" source="../media/copilot-enable-opt-in-mini.png" alt-text="Screenshot of the Copilot Help Pane page." lightbox="../media/copilot-enable-opt-in.png":::

## Opt out of Copilot features

In Copilot Service admin center, opt out of Copilot features on the **Copilot settings** or **Summaries** page. Navigate to these pages using one of the following navigation options:

- **Support experience** > **Productivity** > **Copilot settings**
- **Operations** > **Insights** > **Summaries**

When you opt out, the application erases the training data. If you want to use the features again, you must consent to the terms of use and opt in.

## Make Copilot available to representatives

In order for representatives to be able to use the Copilot features in Copilot Service workspace, you need to enable the Copilot features in [Add users to experience profiles](add-profile-default.md). By default, representatives added to the out-of-the-box experience profiles can use the Copilot features.

If you want to limit the features that representatives can use, you can create a custom experience profile and enable the required features. You can then [assign the custom profile to the representatives](add-profile-default.md).

For Customer Service Hub, when you enable the feature, it's available to all the representatives.

## Configure Copilot features for representatives

To configure Copilot features for representatives, perform the following steps:

1. In Copilot Service admin center, in **Support experience**, select **Productivity**.
1. For **Copilot settings**, select **Manage**.
1. Select the checkbox to turn on the Copilot experiences you want representatives to use:
   - **Copilot immersive**
   - **Copilot side pane**

### Configure Customer Support agent settings

To manage how Copilot behaves for your representatives, configure the **Customer Support** agent.

Perform the following steps.

1. In Copilot Service admin center, in the **Agents within Copilot** section, select **Settings** next to **Customer Support**. The **Customer Support** page appears.
1. Configure the required Copilot features for representatives across the available tabs:
   - **Overview**
   - **Immersive settings**
   - **Email settings**
   - **Prompts**
   - **User access**

Learn more about the Customer Support agent and how to configure the settings on each of the tabs in [Enable features in Copilot](/dynamics365/contact-center/administer/copilot-enable-help-pane).

## Configure Admin Management agent settings

The Admin Management (preview) agent is an optional Copilot agent that provides administrators with a centralized way to manage administrative prompts, control user access, and connect tools and knowledge through Copilot Studio.

To configure Admin Management agent, perform the following steps.

1. In Copilot Service admin center, in the **Agents within Copilot** section, select **Settings** next to **Admin Management**. The **Admin Management** page displays.
1. Configure the required Copilot features for administrators across the available tabs:
   - **Overview**
   - **Prompts**
   - **User access**

To manage tools and knowledge associated with this agent, use the links to **Copilot Studio** provided on the **Overview** tab. Learn more in [Enable features in Copilot](/dynamics365/contact-center/administer/copilot-enable-help-pane).

## Let representatives use Copilot to translate responses

On the **Copilot settings** page, in the **Translation using Copilot** section, you can select **Let representatives translate responses using Copilot** to allow your representatives to choose from the languages that your organization added to Dynamics 365.

## Record representative interactions with Copilot

On the **Copilot settings** page, in the **Support experience data** section, you can select **Record transcripts of representative interactions with Copilot** to understand usage patterns and improve Copilot performance. 

You can also [download](../develop/download-copilot-transcript-data.md) and use the data to analyze knowledge sources, and build usage reports.

## Assign roles and privileges

Out of the box, users with the Customer Service Representative role only can use the Copilot features. Therefore, make sure that users with custom roles have the following privileges: 

|Table | Name | Create | Read | Write | Append | Append To |
|------|------|--------|------|-------|--------|-----------|
|Copilot event | msdyn_copilotevent | Yes | Yes | Yes | Not applicable | Not applicable |
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
> - Make sure that your users have **Miscellaneous privileges** > **prvIntelligenceUsage** assigned to the required custom security roles to access the Copilot case summary. Learn more in [Security roles and privileges](/power-platform/admin/security-roles-privileges).
> - For custom CSR roles, make sure the role has the following permissions and corresponding access levels:
>    - Read and Write have access level set to Basic.
>        - `<RolePrivilege name="prvReadmsdyn_copilotevent" level="Basic" />`  
>        - `<RolePrivilege name="prvWritemsdyn_copilotevent" level="Basic" />`  
>    - Create has access level set to Global: `<RolePrivilege name="prvCreatemsdyn_copilotevent" level="Global" />`  
> - For custom CSR Manager roles, make sure that all the permissions have access level set to Global:
>      - `<RolePrivilege name="prvReadmsdyn_copilotevent" level="Global" />`   
>      - `<RolePrivilege name="prvCreatemsdyn_copilotevent" level="Global" />`   
>      - `<RolePrivilege name="prvWritemsdyn_copilotevent" level="Global" />`  


## Next steps

[Enable Copilot case and conversation summaries](/dynamics365/contact-center/administer/copilot-enable-summary)  
[Enable features in Copilot pane](/dynamics365/contact-center/administer/copilot-enable-help-pane)  
[Configure Copilot features for custom case forms and custom apps](copilot-powerapps-settings.md)  

### Related information
 
[Draft a chat response](../use/use-copilot-features.md)  
[Responsible AI FAQ for Copilot in Customer Service](../implement/faq-responsible-ai-copilot.md)  
[FAQ for Copilot in Customer Service](faq-copilot-features.md)  
