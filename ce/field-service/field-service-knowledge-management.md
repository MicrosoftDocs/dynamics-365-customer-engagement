---
title: Create knowledge articles
description: Learn how to create, review, and publish knowledge articles in Dynamics 365 Field Service.
ms.date: 10/16/2024
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.custom: bap-template
---

# Create knowledge articles

Write a knowledge article to share information with technicians. Add images and videos to your articles to explain things better and make the articles engaging. You can author, edit, search, publish, and translate the knowledge articles.

After creating a knowledge article, you can have the article reviewed or schedule it for publication. An article isn't available to dispatchers and technicians until the article is published.

## Create a knowledge article

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles** and select **New** or **New From Template**.
   :::image type="content" source="media/knowledge-article-new.png" alt-text="Screenshot of a list of knowledge articles in Field Service with callouts on controls.":::

1. On the **Content** tab, **Article Content** section, fill in the following details:  
  
   - **Title**: Type a descriptive title that communicates the subject and purpose of the article in a concise manner.  
   - **Keywords**: Type or select keywords for the article. These keywords are used to search the knowledge base for articles. Separate keywords with commas.
   - **Description**: Type or select a short description of the article. The description appears in the search results and is used for search engine optimization.

1. In the **CONTENT** section, add the content for your knowledge article. Add text, pictures, and videos to the knowledge article. Learn more about the [text editor](/dynamics365/customer-service/use/customer-service-hub-user-guide-knowledge-article#designer).

1. **Save** the knowledge article.

## Review knowledge articles

To ensure that the content you create is accurate, have someone review it. You can mark an article for review or directly assign it to a specific person or queue.

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles**.
1. Open the article.
1. Change the **Status Reason** to **Needs review**.
   :::image type="content" source="media/knowledge-article-review.png" alt-text="Screenshot of a knowledge article in Field Service highlighting Status Reason.":::

1. Reviewers can change the **Status Reason** to **In review** when reviewing the article.
1. Reviewers work with the author to update the article.
1. When the reviewer is satisfied with the article, on the command bar, select the vertical ellipsis &vellip; > **Approve**.

## Publish knowledge articles

After the content in the article is complete, publish the article to make it available to your technicians. You can publish the article immediately or schedule it for a later time.

1. In Field Service, go to **Settings** > **Knowledge management** > **Knowledge articles**.
1. Open the article.
1. On the command bar, select the vertical ellipsis &vellip; > **Publish**.
   :::image type="content" source="media/knowledge-article-publish.png" alt-text="Screenshot of a Field Service knowledge article, showing the Publish pane.":::

1. Enter the following information:
   - **Publish**: Select whether you want to publish the knowledge article now or in the future. To publish the article in the future, in the **Publish On** field, select a date and time.
   - **Published Status**: Select what status the article should be in after it's published. By default, **Published** is selected.
   - **Expiration Date**: Select a date and time when you want the published article to expire, if any. Expired articles are no longer available in searches. If you set an expiration date, select the state and status the knowledge article should be set to after it expires.
   - **Publish Approved related translations with Article**: Select **Yes** if you want to publish all related translated articles with the article.

1. Select **Publish**. The **Status Reason** changes to **Published**.

## Next steps

- [Translate the article](field-service-km-translate.md).
- [Link the article to an entity](field-service-km-link.md).
- [Create a work order](create-work-order.md)
- [Create work order templates with incident types](configure-incident-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
