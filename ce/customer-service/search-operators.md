---
title: Search operators used in knowledge management in Dynamics 365 Customer Service | Microsoft Docs
description: See how you can effectively search knowledge articles in the Customer Service Hub.
ms.date: 02/25/2022
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

# Search operators

Knowledge management search control uses Dataverse search to search for knowledge articles. More information: [What is Dataverse search?](/power-platform/admin/configure-relevance-search-organization).

This topic describes the search operators and the search query that you can use along with your search terms to get the results you want.

## Search operators

### Default: Knowledge search logic option
Option in settings. 3.	One option that a knowledge search customer can leverage:
Knowledge search logic: Set search mode as all.

Admin> by default> Knowledge search logic: Set search mode as all.
Query:
searchmode= any | all (optional)
Specifies whether any or all the search terms must be matched to count the document as a match. The default is 'any'.

If the Knowledge search logic: Set search mode as all setting is ON, searching by the Boolean operators And and Or is redundant in the search text query as By default, Search mode=any in Dataverse search.

However, users can use the And or the OR operator to search as well to search on the knowledge search bar in CSH.

### Boolean Operators

#### AND operator

Search on a combination of terms using the + operator, which performs an AND search and shows results containing all the individual terms separated by +. For example, alpine + paul returns the contact record Paul Cannon related to the account record Alpine Ski House.

screenshot

Query: AND operator; denoted by +

#### OR operator

Similarly, the OR operator can be indicated by separating terms with a vertical bar (|). For example, searching for alpine | paul returns records with reference to either term.

screenshot

Query syntax: OR operator; denoted by |

#### NOT operator

Use the NOT operator with a hyphen (-) before a keyword to indicate that it should be excluded from results.
For example, when you search for evaluation, all rows matching the term evaluation will appear in results.

screenshot

However, searching for evaluation + -agreed will match all rows that contain the term evaluation but not the term agreed.

Query syntax: NOT operator; denoted by -

## Wildcards

Use wildcards for operators such as begins-with and ends-with. Using an asterisk (*) at the beginning or end of a keyword makes the asterisk a placeholder for zero or more characters. For example, searching on *win will show results for all records associated with a keyword that ends with win.

screenshot

Query syntax: Trailing wildcard are supported. For example, "Alp*" searches for "alpine".

## Exact matches

Use double quotation marks around a keyword to perform an exact match. Search ignores common used words such as the, an, and a. To improve matching, use double quotation marks and force an exact match for your search. For example, searching on "Call back for resolution (sample)" will match the exact keywords.

screenshot

Query syntax: A query enclosed in quotation marks " ".

### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)

[Set up a search provider in Customer Service Hub](set-up-search-providers.md)

[Add a knowledge article subgrid to a form](add-knowledge-base-search-control-forms.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
