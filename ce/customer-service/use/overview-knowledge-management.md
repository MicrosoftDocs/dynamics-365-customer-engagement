---
title: Overview of knowledge management
description: Learn about knowledge management in Dynamics 365 Customer Service.
ms.date: 06/28/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom:
  - dyn365-customerservice
---

# Overview of knowledge management

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

Knowledge management plays a vital role in delivering world-class customer care. With knowledge management, team members in an organization can author, categorize, deliver, analyze, and share information through a knowledge base.

## Benefits of knowledge management

- Primary service providers, such as agents, can look up information in a knowledge base to resolve customer queries right away, and increase their productivity.
- With access to rich, high-quality knowledge resources across consistent and contextual Omnichannel experiences, agents can resolve issues faster and reduce their average call handling time.
- Customers can use knowledge management search capabilities across channels to resolve issues for themselves. The results are fewer support tickets and higher customer satisfaction.

:::image type="content" source="../media/km-benefits.png" alt-text="Diagram that illustrates the benefits of knowledge management.":::

## Features of knowledge management

This section explains how different roles in your organization can use the features of knowledge management to help the organization grow.

### Create knowledge articles

#### Create and design knowledge articles

As a **knowledge author**, you can:

- Create rich, well-formatted content for emails or knowledge articles by using the new rich text editor. More information: [Use the rich text editor to create knowledge articles and emails](customer-service-hub-user-guide-knowledge-article.md#use-the-rich-text-editor-to-create-knowledge-articles-and-emails)
- Review knowledge articles for accuracy before they are published or made available to others. More information: [Review knowledge articles](review-ka.md#review-knowledge-articles)
- Quickly create knowledge articles by using templates that include prepopulated fields. Templates also help knowledge managers and authors maintain consistent branding, language, and structure. More information: [Create a knowledge article template](create-templates-knowledge-article.md#create-a-knowledge-article-template)
- Set up a default knowledge article authoring language. More information: [Configure a default knowledge article authoring language for your organization](set-knowledge-article-authoring-language.md#configure-a-default-knowledge-article-authoring-language-for-your-organization)

As an **administrator**, you can:

- Enable a setting so that agents can propose knowledge drafts after they resolve a case. More information: [Use Copilot to generate knowledge drafts from cases (preview)](use-copilot-knowledge-from-cases.md#use-copilot-to-generate-knowledge-drafts-from-cases-preview)
- Configure third-party sources, such as enterprise websites that are based on the site map protocol. Knowledge articles are ingested into Dataverse and are available for agents to search. Therefore, your agents can view and sort search results from any search providers that you add. More information: [Manage integrated search providers](../administer/add-search-provider.md#manage-integrated-search-providers)

#### Manage the lifecycle of knowledge articles

As a **knowledge author**, you can:

- Create major and minor versions of a knowledge article, and keep your articles up to date with the latest information while you track changes throughout the lifecycle of your products and services. More information: [Create and manage article versions](ka-versions.md#create-and-manage-article-versions)
- Create translations for a knowledge article record in multiple languages. More information: [Create a knowledge article translation](../administer/work-knowledge-articles.md#create-a-knowledge-article-translation)
- Publish articles as soon as they are approved, or schedule them for later publication. You can also set expiration dates on articles. More information: [Publish knowledge articles](publish-ka.md#publish-knowledge-articles)

:::image type="content" source="../media/create- knowledge.png" alt-text="Screenshot that illustrates the functionality for creating and managing the lifecycle of knowledge articles.":::

#### Create and manage categories for your knowledge articles

As an **administrator**, you can create hierarchical, categorical data to help group records. Categories are useful for reporting, sorting, segmenting, and categorizing records. More information: [Create and manage categories](../administer/create-manage-categories.md#create-and-manage-categories)

### Search knowledge articles

#### Search knowledge articles through different channels

As an **agent**, you can use either smart assist or the **Knowledge search** pane to search articles in Customer Service workspace. Smart assist suggests knowledge articles that are related to your case and that can help you quickly resolve customer issues. Fore more information about the **Knowledge search** pane, go to, [Search knowledge articles](../csw-search-knowledge-articles.md).

As a **customizer**, you can set up the knowledge base search control on a standard or custom form to help users in your organization easily find knowledge articles. More information: [Add the Knowledge Base Search control to forms](../administer/add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-forms)

As an **administrator**, you can configure how the knowledge base search control appears for your entities in the app side pane of Customer Service workspace and Omnichannel for Customer Service. By configuring a record type, you can specify the information that is shown to your agents while they interact with customers. More information: [Configure knowledge search control on app side pane for an entity record](../administer/configure-knowledge-search-control-productivity-pane.md#configure-knowledge-search-control-on-app-side-pane-for-an-entity-record)

#### Search multiple knowledge providers

As an **administrator**, you can use search providers to federate the search of files, documents, or articles from data sources outside your organization. More information: [Set up external search providers](../administer/set-up-search-providers.md#set-up-external-search-providers)

#### Set up search logic and search filters

As an **administrator**, you can:

- Set up knowledge search logic for your knowledge articles to help agents find only the articles that they need. More information: [Set up knowledge search logic](../administer/set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-search-logic).
- Create filters to help your agents more quickly find what they are looking for. More information: [Customize knowledge article search filters](../administer/enable-knowledge-article-search-filters.md)

### Perform knowledge self-service

#### Search the knowledge base on portals

When a portal includes a knowledge base, it becomes a customer self-service portal. As a user in any role, you can then access and search for knowledge articles through simple queries. This setup helps you resolve issues and makes information easily accessible. To search for your knowledge articles, select **Knowledge Base** in your portal. More information: [Search the knowledge base on portals](knowledge-base-search-methods.md#search-the-knowledge-base-on-portals)

#### Integrate knowledge management with a Copilot Studio bot

As an **administrator**, you can integrate a Copilot Studio bot with knowledge management to make it easier to use customized conversations in your bot. The bot can then answer simple questions, perform simple actions, and resolve simple issues. Therefore, your agents have more time to focus on complex issues that require human intervention. More information: [Integrate knowledge management in Dynamics 365 with Copilot Studio bots](../administer/integrate-KM-with-PVA.md)

### Analyze and report

#### Track and analyze knowledge article statistics

As an **administrator**, you can:

- Track how many times an article is used, viewed, and sent to customers. You can then use this information to proactively create knowledge articles based on search insights across customers and agents. 
- Use the knowledge search analytics dashboard to give supervisors and knowledge workers valuable insights into how your support agents find and use knowledge articles. More information: [Manage Knowledge analytics](../administer/enable-knowledge-search-insights.md#manage-knowledge-analytics)

:::image type="content" source="../media/knowledge-article-insights-dashboard.png" alt-text="Screenshot of the knowledge search analytics dashboard":::

As a **supervisor**, you can use the knowledge search analytics dashboard to identify searches that have low success or return no results. In this way, you can help identify knowledge gaps, improve search results, and surface the most relevant articles. More information: [Introduction to knowledge analytics](knowledge-search-analytics-cs.md#introduction-to-knowledge-analytics)

### Provide feedback

As an **agent**, you can use knowledge article rating to easily provide feedback about knowledge articles. Knowledge managers can capture and review this feedback to improve and maintain a relevant knowledge base. More information: [Submit ratings and feedback for knowledge articles](submit-feedback.md#submit-ratings-and-feedback-for-knowledge-articles)

## Related information

[Search knowledge articles](search-knowledge-articles-csh.md)

[Configure origins allowlist for knowledge articles](../administer/configure-knowledge-article-origin-allow-list.md#configure-origins-allowlist-for-knowledge-articles)

[Create a knowledge article using a template](../develop/create-knowledge-article-using-template.md#create-a-knowledge-article-using-a-template)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
