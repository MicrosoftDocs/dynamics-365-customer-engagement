---
title: Manage Customer Knowledge Management Agent (preview)
description: Learn how to manage the Customer Knowledge Management Agent to autonomously create knowledge articles from cases and related communications.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection: 
ms.date: 03/28/2025
ms.custom: bap-template
---

# Manage Customer Knowledge Management Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Customer Knowledge Management Agent lets you autonomously turn cases and case-related conversations, emails, and notes into knowledge articles that can support your contact center operations. 

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- You are using the out-of-the-box case entities.
- [Dynamics 365 knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management) is configured.
- You’ve enabled Dynamics 365 knowledge base to be indexed by Copilot. You can utilize the internal knowledge base resources only for generating responses. Learn more in [Configure knowledge sources](copilot-enable-help-pane.md#configure-knowledge-sources).
- You’ve [configured connection references for Customer Knowledge Management Agent flow (preview)](admin-km-agent-connections.md#configure-connection-references-for-customer-knowledge-management-agent-flow-preview).
- [Set up a pay-as-you-go plan](setup-pay-as-you-go.md#set-up-a-pay-as-you-go-plan).

## Enable Customer Knowledge Management Agent

In Customer Service admin center, go to **Agent experience** > **Knowledge** > **Customer Knowledge Management Agent (preview)**, and then select **Manage**. The **Customer Knowledge Management Agent (preview)** page appears.

Select from the following options as required for Customer Knowledge Management Agent.

## Enable real-time knowledge creation

In the **Real-time creation** section, select the **Let Copilot use information from current case to create knowledge articles** option.

Real-time knowledge creation is triggered when a customer service representative (service representative) resolves a case. It determines whether a new knowledge article is needed by comparing the content of the case with the existing knowledge articles in Dynamics 365 knowledge base. If an article is needed, the Customer Knowledge Management Agent creates the article using the case content.  

### Control which cases real-time creation should create articles from 

You can create multiple rules to control which conditions must be met for a resolved case to be processed by Customer Knowledge Management Agent in real time. For example, you may limit this process to cases owned by a certain user, or any other fields on the case.  

1. In the **Real-time creation** section, select **Manage rules**.
1. In the **Manage rules** dialog, select **New** to add a new rule.
1. In the **New knowledge creation rules** dialog, enter a rule name, condition name, and then add your conditions.
1. Select **Save**.

### Control which case attributes are used to create knowledge articles in real-time  

Customer Knowledge Management Agent uses **Case Title**, **Case Description**, **Product**, **Subject**, **Email Content**, **Conversation Summary**, and **Case Notes** to create an article. You can remap all the fields except **Email Content** and **Conversation Summary** to your own record types and data fields.  
 
1. In the **Real-time creation** section, select **Manage attributes**. The **Manage data** page appears. 
You can map which record types and data fields are used for each element. You can choose to include and exclude data.
1. Select**Save and Close**.
1. Select **Save** on the **Customer Knowledge Management Agent (preview)** settings page.

## Enable historical knowledge creation

When enabled, the agent looks at all the cases that meet the conditions specified and determines if new articles are needed by comparing the content of the cases with the existing Dynamics 365 knowledge base. If a new article is needed, it creates a new article by using the content of one or more historical cases that meet the configured conditions.  

1. In the **Creation from historical cases** section, select the **Let copilot use information from historical cases to create knowledge articles** option.
1. Select **Manage rules** to configure the conditions for the harvest.
1. On the **Default rule** dialog, enter a rule name, condition name, and then add your conditions to filter historical articles.
1. Select **Save**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.
1. Select **Start** on the **Creation from historical cases** section. 
Once you select start, you see that the article creation is in progress. You can see the creation process log by selecting the **View creation process log** link.

Creation from historical cases is a long-running process, which can't be stopped once it starts. The process can create articles from a maximum of 100,000 cases and runs until all the 100,000 cases have been processed. We recommend you perform historical knowledge creation in batches. 

## Set the default compliance state of created articles

You can control the default compliance state of the articles created by Customer Knowledge Management Agent. For example, to ensure articles are compliant, set their default state to **Pending** and ask the knowledge reviewers to mark them as compliant before publishing.  

To set the default compliance state of articles created by Customer Knowledge Management Agent, on the **Customer Knowledge Management Agent (preview)** page, **Compliance** section, select your default compliance state from the available options.

Articles with the **Non Compliant** status can't be published.

> [!NOTE]
> Customer Knowledge Management Agent removes personally identifiable information (PII) from the case data before drafting articles. However, the agent might not detect all instances of sensitive information.

## Auto publish articles

You can control whether the AI agent can automatically publish articles that comply with **Compliance Status** you've set. You can also select the target audience that can view the published articles.

To set the auto-publishing of articles created by Customer Knowledge Management Agent, on the **Customer Knowledge Management Agent (preview)** page, **Auto publishing** section, select the **Automatically publish compliant articles as soon as they’re created** option.

- Select **Internal target audiences**, if you want articles to be available to your service representatives and Copilot internally. 
- Select **Internal and external target audiences**, if you want these articles to be published to external portals.

## Setup the agent review draft experience

If you’re not configuring the AI agent to automatically publish articles, you can configure an agent review experience where service representatives can review and publish articles.

To enable this editor: 

- Enable in-app notifications for service representatives to be notified when their cases are considered for publishing.
- Ensure your service representatives have the permission to edit articles.
- Make sure your cases have **Timeline** and **Timeline highlights** enabled.

Service representatives can see whether they have knowledge articles to review by opening a resolved case. Learn more in [Review knowledge articles created by the Customer Knowledge Management Agent (preview)](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent-preview).

## Use knowledge insights for Customer Knowledge Management Agent

You can get analytics reports on Customer Knowledge Management Agent as well as collect analytics data for your own custom reporting. Learn more in [Use knowledge insights for Customer Knowledge Management Agent (preview)](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent-preview).

## Related links

[Use knowledge insights for Customer Knowledge Management Agent (preview)](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent-preview)




