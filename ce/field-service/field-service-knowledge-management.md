---
title: Create knowledge articles
description: Learn how to create, link, and publish knowledge articles in Dynamics 365 Field Service.
ms.date: 10/09/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.custom: bap-template
---

# Create knowledge articles

Write a knowledge article to share information with technicians. Add images and videos to your articles to explain things better and make the articles engaging. You can author, edit, search, publish, and translate the knowledge articles

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles** and select **New** or **New From Template**.
   :::image type="content" source="media/knowledge-article-new.png" alt-text="Screenshot of a list of knowledge articles in Field Service with callouts on controls.":::

1. On the **Content** tab, **Article Content** section, fill in the following details:  
  
   - **Title**: Type a descriptive title that communicates the subject and purpose of the article in a concise manner.  
   - **Keywords**: Type or select keywords for the article. These keywords are used to search the knowledge base for articles. Separate keywords with commas.
   - **Description**: Type or select a short description of the article. The description appears in the search results and is used for search engine optimization.

1. In the **CONTENT** section, add the content for your knowledge article. Add text, pictures, and videos to the knowledge article. Learn more about the [text editor](/dynamics365/customer-service/use/customer-service-hub-user-guide-knowledge-article#designer).

1. **Save** the knowledge article.
1. Determine the next step:
    - Mark it for review: Select **Status Reason** and select **Needs review**. You can **Assign** it to the reviewer or **Share** the link with a group of reviewers.
    - [Translate the article](field-service-km-translate.md).
    - [Publish the article](field-service-km-publish.md).
    - [Link the article to an entity](#link-knowledge-articles-to-related-entities)
    - **Save & Close**.

## Link knowledge articles to related entities

Create relationships between knowledge articles and other records, like incident types, products, or customer assets. When any of these records are added to a work order, the system automatically links the related knowledge articles.

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles**.

1. Select an article. On the **Summary** tab, in the **Related Information** section, select the target entity icon for the relationship. For example, customer asset.

1. Select the vertical ellipsis &vellip; and choose **Add Existing Customer Asset**.

   :::image type="content" source="media/knowledge-article-associate-asset.jpg" alt-text="Screenshot of a Field Service knowledge article, showing the related information.":::

1. Choose which record in the target entity to link to the article.

1. Select **Save & Close**

> [!TIP]
> You can also link knowledge articles without configured relationship to incidents, assets, or products. On a target record, go to the **Linked Articles** tab and select **New Linked Article**.

## Link a knowledge article to a work order

1. In Field Service, go to **Service** > **Work Orders**.

1. Select the work order and then select the **Reference** tab.

1. To add an existing knowledge article to the work order:

   - Select **Add existing article** and search for the specific article.
   - Select the link icon for the article and then select **Done**. The article appears on the Work order's Reference tab.

1. To add a new knowledge article to the work order:

   - Select **New article** and create the knowledge article.
   - Select **Save & Close**. The article is created and appears on the Work order's Reference tab.

:::image type="content" source="media/knowledge-article-associate-wo.svg" alt-text="Screenshot of a Field Service work order, showing the related knowledge article.":::

## Next steps

- [Create a work order](create-work-order.md)
- [Create work order templates with incident types](configure-incident-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
