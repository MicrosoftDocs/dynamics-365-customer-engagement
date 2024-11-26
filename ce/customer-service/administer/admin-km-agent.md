---
title: Manage customer knowledge management agent (preview)
description: Learn how to manage the customer knowledge management agent to autonomously create knowledge articles from cases and related communications.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection: 
ms.date: 11/26/2024
ms.custom: bap-template
---

# Manage customer knowledge management agent (preview)

[This article is prerelease documentation and is subject to change.]

Customer knowledge management agent lets you autonomously turn cases and case-related conversations, emails, and notes into knowledge articles that can support your contact center operations. 

## Prerequisites

- You are using the out-of-the-box case entities.
- You have configured [Dynamics 365 knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management).
- You’ve enabled Dynamics 365 knowledge base to be indexed by Copilot. You can utilize the internal knowledge base resources only for generating responses. Learn more in [Configure knowledge sources](copilot-enable-help-pane.md#configure-knowledge-sources).
- You’ve [configured connection references for customer knowledge management agent flow (preview)](admin-km-agent-connections.md#configure-connection-references-for-customer-knowledge-management-agent-flow-preview).

## Enable customer knowledge management agent

> [!NOTE]
> By enabling this feature, you understand that your organization may be billed for its use in the future.

In Customer Service admin center, go to **Agent experience** > **Knowledge** > **Customer knowledge management agent (preview)**, and then select **Manage**. The **Customer knowledge management agent (preview)** page appears.

Select from the following options as required for customer knowledge management agent.

## Enable real-time knowledge creation

Real-time creation is triggered when an customer service representative (service representative) resolves a case. It determines whether a new knowledge article is needed by comparing the content of the case with the existing knowledge articles in Dynamics 365 knowledge base. If an article is needed, the customer knowledge management agent creates the article using the case content.  

In the **Real-time creation** section of the **Customer knowledge management agent (preview)** page, select the **Let Copilot use information from current case to create knowledge articles** option.

### Control which cases real-time creation should create articles from 

You can create multiple rules to control which conditions must be met for a resolved case to be processed by Customer Knowledge management agent in real time. For example, you may limit this process to cases owned by a certain user, or any other fields on the case.  

1. On the **Customer knowledge management agent (preview)** page, **Real-time creation** section, select **Manage rules**.
1. In the **Manage rules** dialog, select **New** to add a new rule.
1. In the **New knowledge creation rules** dialog, enter a rule name, condition name, and then add your conditions.
1. Close the **New knowledge creation rules** dialog and select **Save** on the **Customer Knowledge Management Agent** settings page.

### Control which case attributes are used to create knowledge articles in real-time  

Customer knowledge management agent uses Case Title, Case Description, Product, Subject, Email Content, Conversation Summary, and Case Notes. You can remap all except Email Content and Conversation summaries to your own record types and data fields.  
 
1. On the **Customer knowledge management agent(preview)** page, **Real-time creation** section, select **Manage attributes**. The **Manage data** page appears. 
You can map which record types and data fields are used for each element. You can choose to include and exclude data.
1. Select**Save and Close**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.

## Enable historical knowledge creation

Historical creation looks at all the cases that meet the conditions specified, determines if new articles are needed by comparing the content of the cases with the existing Dynamics 365 knowledge base. If a new article is needed, it creates new articles by using the content of one or more historical cases that meet the configured conditions.  

1. On the **Customer knowledge management agent (preview)** page, **Creation from historical cases** section, select the **Let copilot use information from historical cases to create knowledge articles** option.
1. Select **Manage rules** to configure the conditions for the harvest.
1. On the **Default rule** dialog, enter a rule name, condition name, and then add your conditions to filter historical articles.
1. Select **Save**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.
1. Select **Start** on the **Creation from historical cases** section. 
Once you create start, you see that the article creation is in progress. You can see the creation process log by selecting **View creation process log** link.

Creation from historical cases is a long-running process, which can't be stopped once it has started. The process can create articles from a maximum of 100,000 cases and runs until 100,000 cases have been processed. We recommend you to perform historical knowledge creation in batches. 

## Set the default compliance state of created articles

You can control the default compliance state of the articles created by customer knowledge management agent. For example, if you want to have a business process to have knowledge reviewers ensure that articles are compliant, you can set the default state of articles to pending, and request that reviewers set them to compliant before publishing.  

To set the default compliance state of articles created by customer knowledge management agent, on the **Customer knowledge management agent (preview)** page, **Compliance** section, select your default compliance state from the available options.

Articles with the **Non Compliant** status can't be published.

> [!NOTE]
> Customer Knowledge Management agent scrubs case data of personally identifiable information (PII) before drafting articles, but might not detect all instances of sensitive information.

## Auto publish articles

You can control whether articles created by customer knowledge management agent are automatically published and who can use these auto-published articles. Note that the default compliance state of created articles must be compliant to auto-publish.  

To set the auto-publishing of articles created by customer knowledge management agent, on the **Customer knowledge management agent (preview)** page, **Auto publishing** section, select the **Automatically publish compliant articles as soon as they’re created** option.

- Select **Internal target audiences**, if you want articles to be available to your service representatives and Copilot internally. 
- Select **Internal and external target audiences**, if you want these articles to be published to external portals.

## Setup the optional agent review draft experience

If you’re not configuring customer knowledge management agent to automatically publish articles, you can optionally configure an agent review experience where service representatives can review and publish articles.

To enable this agent editor: 

- Configure customer knowledge management agent to not automatically publish articles.
- Enable in-app notifications for agents to be notified when their cases are considered for publishing.
- Ensure your service representatives have the permission to edit articles.
- Make sure your cases have Timeline and Timeline highlights enabled.

Service representatives can see whether they have knowledge articles to review by opening a resolved case, navigating to the Timeline Highlights, and selecting the next suggested action to review the autonomously drafted article.

Learn more in [Review knowledge articles created by the customer knowledge management agent](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent).

## Use knowledge insights for customer knowledge management agent

You can get analytics reports on customer knowledge management agent as well as collect analytics data for your own custom reporting. Learn more in [Use knowledge insights for customer knowledge management agent (preview)](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent-preview).

## Related links

[Use knowledge insights for customer knowledge management agent (preview)](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent-preview)




