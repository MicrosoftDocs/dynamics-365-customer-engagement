---
title: Enable customer knowledge management agent
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection: 
ms.date: 11/06/2024
ms.custom: bap-template
---

# Enable Customer Knowledge Management Agent

Customer knowledge management agent lets you autonomously turn cases and case-related conversations, emails, and notes, into knowledge articles that can support your contact center operations. 

## Prerequisites
- You have Pay-As-You-Go set up in Power Platform Admin Center.
- You are using the out-of-the-box case entities.
- You have configured [Dynamics 365 knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management).
- You’ve enabled Dynamics 365 Knowledge Base to be indexed by Copilot 
- You’ve configured Microsoft Copilot Studio and DV Connections to support the Customer Knowledge Management Agent.


## Enable real-time knowledge creation

Real-time creation triggers when an agent resolves a case. It determines whether a new knowledge article is needed by comparing the content of the case with the existing knowledge articles in Dynamics Knowledge Base. If an article is needed, it will create the article using the case content.  

1. In Customer Service admin center, go to **Agent experience** > **Knowledge** > **Customer Knowledge Management Agent**, and then select **Manage**. The **Knowledge Harvesting (preview)** page appears.
1. In the **Real-time creation** section, select the **Let Copilot use information from current case to create knowledge articles** option.

## How do I control which cases real-time creation should create articles from 

You can create multiple rules to control which conditions must be met for a resolved case to be processed by Customer Knowledge Management Agent in real time. For example, you may limit this process to cases owned by a certain user, or any other fields on the case.  

1. On the **Knowledge Harvesting (preview)** page, **Real-time creation** section, select **Manage rules**.
1. In the **Manage rules** dialog, select **New** to add a new rule.
1. In the **New knowledge creation rules** dialog, enter a rule name, condition name, and then add your conditions.
1. Close the **New knowledge creation rules** dialog and select **Save** on the **Customer Knowledge Management Agent** settings page.

## How do I control which case attributes are used to create knowledge articles in real-time  

Customer knowledge management agent uses Case Title, Case Description, Product, Subject, Email Content, Conversation Summary, and Case Notes. You can remap all except Email Content and Conversation summaries to your own record types and data fields.  
 
1. On the **Knowledge Harvesting (preview)** page, **Real-time creation** section, select **Manage attributes**. The **Manage data** page appears. 
You can map which record types and data fields are used for each element. You can choose to include and exclude data.
1. Select**Save and Close**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.

## How do I enable historical knowledge creation

Historical creation is triggered by the administrator. Historical creation looks at all the cases that meet the conditions specified, determines if new articles are needed by comparing the content of the cases with the existing Dynamics 365 Knowledge Base. If a new article is needed, it will create new articles using the content of one or more historical cases that meet the conditions configured.  

1. On the **Knowledge Harvesting (preview)** page, **Creation from historial cases** section, select the **Let copilot use information from historical cases to create knowledge articles** option.
1. Select **Manage rules** to configure the conditions for the harvest.
1. On the Default rule dialog, enter a rule name, condition name, and then add your conditions to filter historical articles.
1. Select **Save**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.
1. Select **Start** on the **Creation from historial cases** section. 
Once you create start, you see that the creation is in progress. You can see the creation process log by selecting **View creation process log** link.

Creation from historical cases is a long-running process. The process can create articles from a maximum of 100,000 cases. The process will run in daily batches batch until 100,000 cases have been processed. 

## How do I set the default compliance state of created articles?

You can control the default compliance state of articles created by Customer Knowledge Management Agent. For example, if you would like to have a business process to have knowledge reviewers ensure articles are compliant, you can set the default state of articles to pending, and request that reviewers set them to compliant before publishing.  

To set the default compliance state of articles created by Customer Knowledge Management Agent, on the **Knowledge Harvesting (preview)** page, **Compliance** section, select your default compliance state from the options.

Articles with the Non Compliant can't be published.  



## Next steps


