---
title: Link knowledge articles
description: Learn how to link and unlink knowledge articles to records in Dynamics 365 Field Service.
ms.date: 10/16/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.custom: bap-template
---

# Link knowledge articles

You can associate and dissociate a knowledge article with a record.

## Link knowledge articles to related entities

Create relationships between knowledge articles and other records, like incident types, products, or customer assets. When any of these records are added to a work order, the system automatically links the related knowledge articles. This example uses customer asset.

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles**.

1. Select an article, and then the **Summary** tab. In the **Related Information** section, select the **Customer asset** icon for the relationship.

1. Select the **More commands** (**&vellip;**) and then **Add Existing Customer Asset**.

   :::image type="content" source="media/knowledge-article-associate-asset.jpg" alt-text="Screenshot of a Field Service knowledge article, showing the related information.":::

1. Search for and select the asset to link to the article, and then select **Add**.

1. Select **Save & Close**.

## Link related entities to knowledge articles

You can also link knowledge articles without a configured relationship to incidents, assets, or products.

1. On a related entity, navigate to the **Linked Articles** section.
   - For Customer asset, select the **Summary** tab.
   - For Incident type, select the **Details** tab.
   - For Product, select the **Additional Details** tab.
1. Select **Add Existing Knowledge Article**. Search for the specific article.
1. Select **Save & Close**.

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

## Search for knowledge articles

When linking a knowledge article to a work order, customer asset, incident type, or product, you have several options to help you find the articles you want to link.

:::image type="content" source="media/knowledge-article-search.png" alt-text="Screenshot that shows a search for a knowledge article.":::

1. Filters the list of results
1. Sorts the list of results
1. Search box
1. Unlinks the article
1. Marks the article as a favorite
1. Confirmation that the record is linked
1. Rating
1. The number of times the article is viewed
1. Links the article
1. The article ID

[!INCLUDE[footer-include](../includes/footer-banner.md)]
