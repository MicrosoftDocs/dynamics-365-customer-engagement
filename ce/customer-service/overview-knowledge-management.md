---
title: Overview of knowledge management
description: Learn about knowledge management in Dynamics 365 Customer Service.
ms.date: 11/07/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom:
  - dyn365-customerservice
---

# Overview of knowledge management

Knowledge management plays a vital role in delivering world-class customer care. It provides team members in an organization the ability to author, categorize, deliver, analyze, and share information through a knowledge base.

## Benefits of knowledge management

* Primary service providers, such as agents, can look up information in a knowledge base to resolve customer queries right away, thereby increasing their productivity.
* With access to rich, high-quality knowledge resources across consistent and contextual Omnichannel experiences, agents can resolve issues faster, reducing their average call handling time.
* Customers can use knowledge management search capabilities across channels to solve issues themselves, reducing support tickets and driving customer satisfaction.

    :::image type="content" source="media/km-benefits.png" alt-text="Diagram that illustrates the benefits of knowledge management":::

## Features of knowledge management

Depending on your role in your organization, here’s how you can leverage the features of knowledge management to help your organization grow.

## Create knowledge articles

### Create and design knowledge articles
As a knowledge author, you can:
   - Create rich and well-formatted content for emails or knowledge articles using the new rich text editor. More information: [Use the rich text editor to create knowledge articles and emails](customer-service-hub-user-guide-knowledge-article.md#use-the-rich-text-editor-to-create-knowledge-articles-and-emails)
   - Review knowledge articles for accuracy before they’re published or made available to others. More information: [Review knowledge articles](review-ka.md#review-knowledge-articles)
   - Use templates to create knowledge articles quickly, with prepopulated fields in the selected template. Templates also help knowledge managers and authors maintain consistency in branding, language, and structure. More information: [Create a knowledge article template](create-templates-knowledge-article.md#create-a-knowledge-article-template)
   - Set up a default knowledge article authoring language. More information: [Configure a default knowledge article authoring language for your organization](set-knowledge-article-authoring-language.md#configure-a-default-knowledge-article-authoring-language-for-your-organization)
   
### Manage the lifecycle of knowledge articles
As a knowledge author, you can:
  - Create major and minor versions of a knowledge article, and keep your articles up to date with the latest information while keeping track of changes throughout the lifecycle of your products and services. More information: [Create and manage article versions](ka-versions.md#create-and-manage-article-versions)
  - Create a translation for a knowledge article record in multiple languages. More information: [Create a knowledge article translation](work-knowledge-articles.md#create-a-knowledge-article-translation)
  - Publish articles as soon as they're approved, or schedule them for later publication. You can also set expiration dates on articles. More information: [Publish knowledge articles](publish-ka.md#publish-knowledge-articles)
  
    :::image type="content" source="media/create- knowledge.png" alt-text="Create and manage knowledge articles life cycle":::

### Create and manage categories for your knowledge articles
As an administrator, you can create hierarchical, categorical data to help group records. Categories are useful for reporting, sorting, segmenting, and categorization of records. More information: [Create and manage categories](create-manage-categories.md#create-and-manage-categories).

### Integrate knowledge management with a Power Virtual Agents bot 
As an administrator, you can integrate a Power Virtual Agents bot with knowledge management to make it easier to use customized conversations in your bot. This helps free up your agents' time so they can focus on complex issues that need human intervention, as the bot helps answer questions, perform actions, and solve issues that are simple in nature. More information: [Integrate knowledge management in Dynamics 365 with Power Virtual Agents bots](integrate-KM-with-PVA.md#integrate-knowledge-management-in-dynamics-365-with-power-virtual-agents-bots)

## Search knowledge articles

### Search knowledge articles through different channels
- As an agent, you can use either the **Smart assist** or the **Knowledge search pane** to search articles in Customer Service workspace. **Smart assist** provides you with knowledge article suggestions about your case that helps you resolve customer issues quickly. For more information on **Knowledge search pane**, see: [Use the knowledge search pane to search articles](csw-search-knowledge-articles.md#use-the-knowledge-search-pane-to-search-articles)
- As a customizer, you can set up knowledge base search control on a standard or custom form to help make it easy for users in your organization to find knowledge articles. More information: [Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-forms)
- As an administrator, you can configure how you want the knowledge base search control to appear for your entities on the app side pane of Customer Service workspace and Omnichannel for Customer Service. Configuring a record type will specify the information that your agents will see while they interact with customers. More information: [Configure knowledge search control on app side pane for an entity record](configure-knowledge-search-control-productivity-pane.md#configure-knowledge-search-control-on-app-side-pane-for-an-entity-record)

### Search multiple knowledge providers
As an administrator, you can use search providers to federate the search of files, documents, or articles from data sources outside of your organization. More information: [Set up external knowledge search providers](set-up-search-providers.md#set-up-external-knowledge-search-providers)

### Set up search logic and search filters
As an administrator, you can:
  - Set up a knowledge search logic for your knowledge articles to help agents find only the articles they need. More information: [Set up knowledge search logic](set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-search-logic).
  - Create filters to help your agents more quickly find what they’re looking for. More information: [Customize search filters for knowledge articles](enable-knowledge-article-search-filters.md)

## Perform knowledge self-service 

### Search the knowledge base on portals
Having a knowledge base on the portal makes it a customer self-service portal, where you can access and search for knowledge articles through simple queries. This helps resolve issues and makes information easily accessible. You can search for your knowledge articles by selecting **Knowledge Base** from your portal. More information: [Search the knowledge base on portals](knowledge-base-search-methods.md#search-the-knowledge-base-on-portals)

## Analyze and report

### Track and analyze knowledge article statistics

As an administrator, you can:
  - Track how many times an article is used, viewed, and sent to customers. Use this information to proactively create knowledge based on search insights across customers and agents. 
  - Use the knowledge search analytics dashboard to provide supervisors and knowledge workers with valuable insights into how your support agents are finding and using knowledge articles. More information: [Manage Knowledge analytics](enable-knowledge-search-insights.md#manage-knowledge-analytics)

    :::image type="content" source="media/knowledge-article-insights-dashboard.png" alt-text="Screenshot of the knowledge search analytics dashboard":::
  
As a supervisor, you can identify searches that have low success or return no results through the Knowledge search analytics dashboard to help identify knowledge gaps, improve search results, and surface the most relevant articles. More information: [Introduction to knowledge analytics](knowledge-search-analytics-cs.md#introduction-to-knowledge-analytics)
  
### See also  

[Configure origins allowlist for knowledge articles](configure-knowledge-article-origin-allow-list.md#configure-origins-allowlist-for-knowledge-articles)

[Search and share knowledge articles](oc-search-knowledge-articles.md)

[Search for knowledge articles in Customer Service workspace](csw-search-knowledge-articles.md#search-for-knowledge-articles-in-customer-service-workspace)

[Create a knowledge article using a template](create-knowledge-article-using-template.md#create-a-knowledge-article-using-a-template)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
