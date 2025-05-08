---
title: Link and unlink knowledge articles in Dynamics 365 Customer Service
description: Link or unlink knowledge articles to records easily, enhancing case management, and accessibility in your system.
ms.topic: how-to
ms.date: 05/06/2025
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType:
  - admin
  - customizer
  - enduser
ms.custom:
  - dyn365-customerservice
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:04/09/2025
---

# Link and unlink knowledge articles

## Link and unlink the knowledge article to a record

You can associate and dissociate a knowledge article with a record. By default, the articles aren't linked to the case. When you select to link the article to the case, the link icon changes, and **Linked to Case** is displayed for the article.

:::image type="content" source="../media/csw-link-unlink-km.png" alt-text="Link or unlink an article to a case":::


## Linked knowledge articles subgrid

The linked knowledge article subgrid is available for an entity, such as a case or account, only if your system administrator added the subgrid to the entity form. The knowledge article subgrid displays the knowledge articles linked with the entity. Some of the options available are as follows:

- Add a knowledge article
- Select and edit an article's content
- Sort
- Perform bulk operations
 
You can also edit a knowledge article by double-clicking it in the linked articles list.

To link the knowledge article to an entity, you need to do the following steps. For the sake of this example, let us consider the entity as Accounts.

1. In the site map of Customer Service Hub, go to **Customers** > **Accounts**.

2. Select any active account from the list of accounts.

3. On the **Summary** tab, scroll down to the **Linked Knowledge Articles** subgrid.

  > [!NOTE]
  > The name of the subgrid can vary depending on the customizations your organization makes.

4. Select **More commands** (⁝), and then select **Add Existing Knowledge Article**.

   > [!div class=mx-imgBorder]
   > ![Add an existing knowledge article.](../media/add-existing-knowledge-article.png "Add an existing knowledge article")

5. Search for the knowledge article that you want to link, and select **Link.**

   > [!div class=mx-imgBorder]
   > ![Search for a knowledge article to link to an entity.](../media/search-related-article.png "Search for a related knowledge article to link to an entity")

6. Select **Done**. The article appears in the **Linked Knowledge Articles** subgrid.

### Related information

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)  
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
