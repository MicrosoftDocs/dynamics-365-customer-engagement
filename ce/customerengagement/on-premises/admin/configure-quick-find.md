---
title: "Configure Quick Find in Dynamics 365 Customer Engagement (on-premises)"
description: "Tailor the Quick Find functionality by selecting record return limits, an indexing method, and which entities are included."
ms.custom: 
ms.reviewer: 

ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 13aa0eb0-537f-432e-ac26-706ebd511dbd
author: sericks007
ms.author: sericks
search.audienceType: 
  - admin
---

# Configure Quick Find options

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

The Quick Find search feature provides quick results to users who enter simple
queries to commonly searched entities. You can tailor the Quick Find
functionality by selecting record return limits, an indexing method, and which
entities are included.

## Choose the method used for Quick Find indexing

By default, Customer Engagement (on-premises) uses the same search functionality as in
previous releases, which is based mostly on string matches.

System administrators have the option to use full-text indexing for Quick Find.
We recommend you enable full-text indexing for Quick Find because it can provide
a better search experience by improving query performance. Full-text search also
uses more sophisticated indexing methods that include support for
linguistic-based searches and superior relevance ranking.

> [!Note]
> Full-text indexing for Quick Find is only available for on-premises environments.

While the previous search method (standard indexing) returns results based on
literal matches, full-text indexing returns linguistic-based matches. For
example the term *service* can return similar words like *servicing* and
*serviced*. More information: [Full-Text Search (SQL
Server)](/sql/relational-databases/search/full-text-search)

To find information, standard indexing often requires users to add wildcards to
search strings. This results in poor performance for large data sets, due to the
required full table scans instead of using an index. Full-text indexing doesn’t
use wildcards, which leads to improved query and system performance. Notice
that, although users can include wildcards in search strings, wildcards are
ignored.

## What system administrators should consider before enabling or disabling full-text indexing?

Changes made to how and when Microsoft Dynamics 365 data is indexed are not
initiated until a certain time of day, typically during the late evening. Before
you enable or disable full-text indexing, consider the following:

-   Because indexing is a maintenance job that runs one time every day, it can
    take up to 24 hours for the system to enable or disable full-text search, or
    add and remove find columns.

-   When customizers add an item for Quick Find, such as a find column, the
    column data won’t appear in Quick Find search results until the next
    maintenance job completes. These items can still be discoverable through
    Quick Find searches, but will use the previous search method. Any columns
    that have not finished indexing for full-text will continue to use the
    standard indexing method for Quick Find searches. When indexing for a column
    completes, Quick Find will use full-text search. When full-text search for
    Quick Find is enabled, columns newly added to a Quick Find view will not
    have any indexing until the next maintenance job completes. This may cause
    poor Quick Find performance.

-   Advanced Find search is not affected when you enable full-text indexing for
    Quick Find. Advanced Find will continue to use the same standard indexing
    that was available in previous releases of Microsoft Dynamics 365.

-   Because full-text indexing for Quick Find uses SQL Server full-text
    indexing, certain queries made up of mostly or entirely common words
    (stopwords such as on, or, for, and, like) may not return expected results.
    SQL Server database administrators can create a custom stoplist or choose
    not to use a stoplist by dropping the system stoplist (not recommended).
    More information: [TechNet: Configure and Manage Stopwords and Stoplists for
    Full-Text Search](/sql/relational-databases/search/configure-and-manage-stopwords-and-stoplists-for-full-text-search)

## For Customer Engagement (on-premises) administrators

When you enable full-text indexing for a database with a large number of
columns, the size of the transaction log of the organization database may
increase. We recommend you monitor and consider shrinking the transaction log.
More information: [Manage the Size of the Transaction Log
File](/sql/relational-databases/logs/manage-the-size-of-the-transaction-log-file)

The aspects of resource consumption for full-text indexing are different from
standard indexing, which may lead to SQL Server performance issues. Performance
can especially be affected during the initial full-text indexing for all Quick
Find text fields. More information: [Improve the Performance of Full-Text
Indexes \> Common Causes of Performance
Issues](/sql/relational-databases/search/improve-the-performance-of-full-text-indexes)

Index creation is a background process, so for large amounts of data serviced by
busy SQL Servers, it can take several hours to multiple days for the full-text
indexes to fully complete.

## Enable or disable full-text indexing for Quick Find

Before you enable or disable full-text indexing for Quick Find, review the
preceding **What system administrators should consider before enabling or
disabling full-text indexing** section.

1.  Go to **Settings** \> **Administration** \> **System Settings** \> **General** tab.

2.  Select **Yes** or **No** next to **Enable full-text search for Quick Find**.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
