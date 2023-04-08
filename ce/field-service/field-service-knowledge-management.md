---
title: Share information through knowledge articles (contains video)
description: Learn about knowledge management and knowledge articles in Dynamics 365 Field Service.
ms.date: 03/18/2023
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---

# Share information through knowledge articles

When technicians in the field work on assigned jobs, they need access to relevant information to solve the problems they encounter.

Knowledge management in Dynamics 365 Field Service associates relevant knowledge articles with work orders, incidents, products, and customer assets.

Access to knowledge articles help improve the fix rate and guide technicians through procedures.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWxBzW]

## Create knowledge articles

Write a knowledge article to share information with technicians.

For more information on knowledge articles, see:

- [Create and manage knowledge articles](../customer-service/customer-service-hub-user-guide-knowledge-article.md)
- [Create templates for knowledge articles](../customer-service/create-templates-knowledge-article.md)
- [Set up a search provider](../customer-service/set-up-search-providers.md)

:::image type="content" source="media/knowledge-article-new.png" alt-text="Screenshot of a list of knowledge articles in Field Service with callouts on controls.":::

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles** and select **New** or **New From Template**.

1. Add text, pictures, and videos to the knowledge article.

1. **Save and publish** the knowledge article.

## Link knowledge articles to related entities

Create relationships between knowledge articles and other records, like incident types, products, or customer assets. When any of these records are added to a work order, the system automatically links the related knowledge articles.

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles**.

1. Select an article. On the **Summary** tab, in the **Related Information** section, select the target entity for the relationship.

1. Select the vertical ellipsis &vellip; and choose **Add Existing Customer Asset**.

   :::image type="content" source="media/knowledge-article-associate-asset.jpg" alt-text="Screenshot of a Field Service knowledge article, showing the related information.":::

1. Choose which record in the target entity to link to the article.

1. Select **Save & Close**

> [!TIP]
> You can also link knowledge articles without configured relationship to incidents, assets, or products. On a target record, go to the **Linked Articles** tab and select **New Linked Article**.

## View work order and knowledge articles on the mobile app

Technicians find the knowledge articles on work orders in the Field Service mobile app.  Knowledge articles are available while the device has internet connectivity. They aren't available while in the [offline mode](mobile-power-app-system-offline.md).

> [!div class="mx-imgBorder"]
> ![Device renders of the Field Service mobile app, showing the relevant knowledge articles being viewable from a work order.](./media/mobile-2020-knowledge-mgmt.png)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
