---
title: Learn which search operators can be used for knowledge management in Dynamics 365 Customer Service | Microsoft Docs
description: Use search operators to search for knowledge articles in the Customer Service Hub.
ms.date: 03/28/2022
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

# Understand knowledge search

## Introduction

Setting up a comprehensive knowledge base is the key to increased customer satisfaction and improved productivity. A knowledge base is created to help agents with solutions to the most common customer issues, so that they can assist customers quickly.

This topic describes how various search methods work in a knowledge base, and how a customer service rep can view accurate search results based on the client, application, or keyword they use to search the knowledge base.

See the following section to learn the types of search mechanisms available.

Knowledge management search control uses Dataverse search to search for knowledge articles. More information: [What is Dataverse search?](/power-platform/admin/configure-relevance-search-organization).

This topic describes the search operators and the search query that you can use for your search terms to get the knowledge articles you want.

## Boolean operators

 By default, if you have Dataverse search enabled along with the **Knowledge search logic** option in **Settings**, the search mode will be set to "all". This ensures that all the search words must match to consider an article as a match.

- Query: searchmode= all

### AND operator

Use the AND operator when you need to search with a combination of words. The search results will show articles that contain  all the individual terms separated by (+). For example, **delivery + order** returns the article **Delivery Never Arrived** which has **product** and **order** in the article content.

:::image type="content" source="media/and-operator.png" alt-text="AND operator":::

- Query: AND operator; denoted by +

### OR operator

Use the OR operator to search for either of terms. Search terms separated by a vertical bar ( | ). For example, searching for **delivery | order** returns records with reference to either term.

:::image type="content" source="media/or-operator.png" alt-text="OR operator":::

Query syntax: OR operator; denoted by |

### NOT operator

Use the NOT operator with a hyphen (-) before a keyword to indicate that it should be excluded from the search results.
For example, when you search for **product**, all rows matching the term product will appear in the search results.

:::image type="content" source="media/not-operator.png" alt-text="NOT operator":::

However, searching for **product + -order** will match all rows that contain the term product but not the term order.

- Query syntax: NOT operator; denoted by -

## Wildcards

Use wildcards as placeholders for one or more text characters. Use an asterisk (*) at the beginning or end of a keyword. For example, searching on **pro (asterisk)** will show results for all records associated with a keyword that starts with pro. For example, "Pro*" searches for "Product", "Products" and "Procedure".

:::image type="content" source="media/wildcard-search.png" alt-text="Wildcard search":::

- Query syntax: Search term with asterisk at the beginning or end of a keyword.

## Exact matches

Use double quotation marks around a keyword to perform an exact match. For example, searching on "Order Shipping time" will match the exact keywords in an knowledge article. The search ignores commonly used words such as a, an, and the.

:::image type="content" source="media/exact matches.png" alt-text="Exact matches":::

- Query syntax: Search term with double quotation marks around it.

### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)

[Set up a search provider in Customer Service Hub](set-up-search-providers.md)

[Add a knowledge article subgrid to a form](add-knowledge-base-search-control-forms.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
