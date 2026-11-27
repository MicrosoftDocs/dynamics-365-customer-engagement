---
title: Set up Customer Knowledge Management Agent
description: Customer Knowledge Management Agent setup turns resolved cases into draft knowledge articles. Configure connections, scope fields, and defaults to get started.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.date: 11/27/2026
ms.custom: bap-template
---

# Set up Customer Knowledge Management Agent

Customer Knowledge Management Agent helps organizations create and maintain knowledge articles by using information from supported data sources. Use the agent to automate knowledge creation and updates based on your organization’s requirements.

> [!NOTE]
> If you're using the classic experience, go to [Manage Customer Knowledge Management Agent (classic experience)](admin-km-agent.md).

## Prerequisites

- You're using the default case or conversation tables, or a custom Dynamics table for your cases.
- [Dynamics 365 knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management) is configured.
- You enabled Copilot to access Dynamics 365 knowledge base. You can use the internal knowledge base resources only for generating responses. Learn more in Configure knowledge sources.
- You [set up pay-as-you-go](setup-pay-as-you-go.md#set-up-pay-as-you-go).

## Enable Customer Knowledge Management Agent

Before you enable the Customer Knowledge Management Agent, you need to set up the following prerequisites.

### Prerequisite: Set up flow connections for Dataverse and Copilot Studio integration

When you go to the Customer Knowledge Management Agent page in Copilot Service admin center, a **Prerequisites** section appears at the top of the page that shows whether connection references are set up. You need to configure connection references for Customer Knowledge Management Agent flow to integrate with Microsoft services. These connections link flow to essential data sources such as Microsoft Dataverse and Copilot Studio.

1. In Copilot Service admin center, go to **Support experience** > **Knowledge**.
1. Select **Manage** for **Customer Knowledge Management Agent**. The **Customer Knowledge Management Agent** page appears.
1. In the **Prerequisites** section, for **Step 1: Connection References**, select **Set up connections**.
1. In the **Configure Connections** dialog box, select **Update connection references to use your connector** to update connection references.
1. In **Step 2: Power Automate Flows**, select **Enable**.
1. When all tiles show **Ready**, select **Publish** in **Step 3: Copilot Studio Agent** to complete the setup.

If you have issues configuring connection references from the **Customer Knowledge Management Agent** page, you can do a manual setup. Follow the steps provided in [Connection references for Customer Knowledge Management Agent flow](admin-km-agent-connections.md#set-up-connection-references-for-customer-knowledge-management-agent).

Turn on the **Customer Knowledge Management Agent** toggle. In the **Turn on Knowledge Agent** dialog box that appears, select **Turn on and Save**. When you enable the agent, previously active plans start running. For first-time setup, the system creates a basic plan that you can customize and run as a quick start experience.

If you turn off the agent, all active automation plans are paused. You can turn the agent back on at any time.

When Customer Knowledge Management Agent is enabled for the first time, the knowledge base is indexed, which takes about 15 minutes. Plan creation and activation aren't available until indexing completes. You can leave the page while indexing continues in the background.

## Configure default article generation settings

Use default settings to prepopulate common values when you create a plan. Default settings help ensure consistency across plans and reduce manual configuration.

- **Article template**: Select the default template used for new plans. Templates determine the structure and format of generated knowledge articles.
- **Output language**: Select the language in which generated knowledge articles are created by default.

## Manage knowledge automation plan

Learn more in [Create and manage knowledge article automation plans](create-manage-article-automation-plan.md#create-and-manage-knowledge-article-automation-plans).

## Manage scope fields

Scope fields determine which knowledge article fields administrators can use to categorize knowledge sets and define a plan's scope. You can use custom Dataverse fields as scope fields for the following types: **Boolean (Yes/No)**, **text/string**, **choice/enum**, and **lookup**. Date/time fields aren't supported.

1. Select **Manage scope**.
1. In the **Manage scope** dialog box, from the **Knowledge article fields** dropdown list, select a field, and then select **Add**.
1. Repeat the previous step for every field that you want to make available in plan scope conditions.
To remove a field, select **Delete**.
1. Select **Save**.

When you save scope-field changes, the system reindexes the knowledge base to apply them. Reindexing can take about 15 minutes, depending on the size of the knowledge base. After you save the fields, create or edit a plan to configure conditions that use them.

After you set up the scope fields, use them to define the plan scope in plan settings. Learn more in [Create and manage knowledge article automation plans](create-manage-article-automation-plan.md#create-and-manage-knowledge-article-automation-plans).

## Enable AI-assisted knowledge authoring

Enable AI-assisted knowledge authoring in Customer Knowledge Management Agent so customer service representatives can use Copilot to turn case details and resolution information into draft knowledge articles. Copilot can create knowledge content during case handling or after a case is resolved, helping organizations capture valuable troubleshooting and resolution information.

1. On the **Customer Knowledge Management Agent** page, in the **AI-assisted knowledge authoring** section, select **Let customer service representatives use Copilot to propose new knowledge based on case information during or after case resolution** and save your changes.

When you enable this setting, representatives can use Copilot to generate draft knowledge articles from case details and resolution information. Optionally, you can enable **In the case resolution step, keep the option to propose a knowledge article selected by default**, so that Copilot generates a draft knowledge article based on the case information after the case is resolved. Representatives can clear the selection if they don't want a knowledge article draft to be created for a specific case.

## Set the default compliance state for created articles

To set the default compliance state for articles created by Customer Knowledge Management Agent, select your default compliance status in the **Compliance** section, from the available options, such as **Compliant**, **Non Compliant**, and **Pending**. For example, to maintain compliance, set the default state to **Pending** and have knowledge reviewers mark the articles as compliant before publishing.

You can't publish articles with the **Non Compliant** status. They will be saved as drafts.

> [!NOTE]
> Customer Knowledge Management Agent removes personal data from the case data before drafting articles. However, the agent might not detect all instances of sensitive information.

## Configure user experience data collection

Configure how user interaction data is collected to help measure the impact of AI-powered experiences and support reporting. In the **User experience data** section, enable **Record user interactions with AI, including user actions and their feedback on AI suggestions**.

> [!NOTE]
> User experience data is collected only when this setting is enabled. Review your organization's data collection and privacy requirements before you turn on this setting.

## Related information

[Review knowledge articles created by the Customer Knowledge Management Agent](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent)  
[Use knowledge insights for Customer Knowledge Management Agent](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent)