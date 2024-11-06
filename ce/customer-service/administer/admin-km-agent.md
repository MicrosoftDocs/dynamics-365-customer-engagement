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

## How do I control whether created articles are auto-published?

You can control whether articles created by Customer Knowledge Management Agent are automatically published and who can use these auto-published articles. Note that the default compliance state of created articles must be compliant to auto-publish.  

To set the auto-publishing of articles created by Customer Knowledge Management Agent, on the **Knowledge Harvesting (preview)** page, **Auto publishing** section, select the **Automatically publish compliant articles as soon as they’re created** option.

- Select **Internal target audiences**, if you want articles to only be available to your agents and Copilot internally. 
- Select **Internal and external target audiences**, if you want these articles to be published to external portals.   

## How do I setup the optional agent review draft experience?  

If you’re not configuring Customer Knowledge Management Agent to automatically publish articles, you can optionally configure a lightweight agent review experience where customer support agents can review (and if configured) publish articles.

To enable this lightweight agent editor, 

1. Configure Customer Knowledge Management Agent to NOT automatically publish articles.
1. Ensure your agents have permission to edit articles (for editing and publishing).
1. Make sure your cases have Timeline and Timeline Highlights enabled.

Agents can see whether they have knowledge to review by opening a resolved case, navigating to the timeline highlights, and clicking on the suggested next action to review the autonomously drafted article.

## How do I get analytics on Customer Knowledge Management Agent? 

You can get analytics reports on Customer Knowledge Management Agent as well as collect analytics data for your own custom reporting.  

## How do I enable out of the box analytics reports? 

If you have knowledge analytics enabled and you enable real-time or historical creation, you will get Customer Knowledge Management Agent insights reports.  

## How do I enable interaction data for my own reporting? 

To enable collection of interaction data for your own reporting:  

1. On the **Knowledge Harvesting (preview)** page, **User experience data** section, select the **Record user interactions with AI, including user actions and their feedback on AI suggestions** option.

## How do agents work with Customer Knowledge Management Agent agent review experience? 

If your administrator has configured it, you can review knowledge articles created by the Customer Knowledge Management Agent. When you resolve a case, the Customer Knowledge Management Agent may create a new article based on the content of your case if it determines that it can fill a knowledge gap.  

1. For a resolved case, go to the case timeline.
1. Expand the timeline highlights.
1. Select the **Suggested actions** tab.
1. Select **Review draft**.
1. In the **Review knowledge draft (preview)** dialog that opens, you can review and edit the article and make any rich text edits you’d like.
1. Optionally, you can use Copilot to make changes to the article automatically by typing what you want in **Revise with instructions.** and then selecting **Re-generate**. For example, you could instruct it to make the content more concise, and then select **Re-generate**
1. Once done, you can Select **Mark as reviewed**. Or, if you have the permissions, you can select **Split** and publish the article.  

## Related links


