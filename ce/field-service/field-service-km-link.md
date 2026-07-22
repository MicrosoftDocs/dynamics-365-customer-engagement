---
title: Link knowledge articles
description: Learn how to link and unlink knowledge articles to records such as assets or products in Dynamics 365 Field Service.
ms.date: 12/19/2025
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.custom: bap-template
---

# Link knowledge articles

You can associate and dissociate a knowledge article with a record.

## Link knowledge articles to related entities

Create relationships between knowledge articles and other records, like incident types, products, or customer assets. When a user adds any of these records to a work order, the system automatically links the related knowledge articles. For an example, use asset.

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles**.

1. Open an article, and then select the **Summary** tab. In the **Related Information** section, select the related entity icon. In this example, select **Customer asset**.

1. Select **More commands** (**&vellip;**) and then **Add Existing Customer Asset**.

   :::image type="content" source="media/knowledge-article-associate-asset.jpg" alt-text="Screenshot of a Field Service knowledge article, showing the related information.":::

1. Search for and select the asset to link to the article, and then select **Add**. To remove, select the **&vellip;** next to the asset and select **Remove**.

<!--- I can't save and close on a published article. --->

1. Close the article.

## Link related entities to knowledge articles

You can link knowledge articles to incidents, assets, or products even if you didn't configure a relationship between these entities.

1. On a related entity, go to the **Linked Articles** section.
   - For a customer asset, select the **Summary** tab.
   - For an incident type, select the **Details** tab.
   - For a product, select the **Additional Details** tab.
1. In the **Linked Articles** section, select **Add Existing Article** and [search for the specific article](field-service-km-search.md).
1. Select the **Link** icon for the article. The icon changes and **Linked to Customer Asset** appears. To unlink, select the icon.

   :::image type="content" source="media/knowledge-article-link-unlink.png" alt-text="Screenshot of a knowledge article search, showing the link icon.":::

1. Add other articles or select **Done**.

1. Select **Save & Close**.

## Link a knowledge article to a work order

1. In Field Service, go to **Service** > **Work Orders**.

1. Select the work order and then select the **Reference** tab.

1. To add an existing knowledge article to the work order:
   - Select **Add existing article** and [search for the specific article](field-service-km-search.md).
   - Select the **Link** icon for the article. The icon changes and **Linked to** appears. To unlink, select the icon.
     :::image type="content" source="media/knowledge-article-associate-wo.svg" alt-text="Screenshot of a Field Service work order, showing the related knowledge article.":::
   - Add other articles or select **Done**. The article appears on the work order's Reference tab.

1. To add a new knowledge article to the work order:
   - Select **New article** and create the knowledge article.
   - Select **Save & Close**. The article is created and linked to the work order.

1. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
