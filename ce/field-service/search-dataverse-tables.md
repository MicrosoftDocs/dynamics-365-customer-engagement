---
title: Use Dataverse search to find information
description: Learn work with the advanced Dataverse search to find relevant information in Dynamics 365 Field Service.
ms.date: 01/25/2023
ms.reviewer: mhart
ms.topic: conceptual
author: lmasieri
ms.author: lmasieri
search.app: 
  - D365CE
  - D365FS
---

# Use Dataverse search to find information (Preview)

Dynamics 365 Field Service stores data as tables in Microsoft Dataverse. You can configure Dataverse search to surface the tables that are relevant to your organization.

> [!NOTE]
> This feature is currently in preview. For more information about enabling features  in preview, see [Install preview features for Dynamics 365 Field Service](field-service-preview.md).

## Enable Dataverse search

Dataverse search is automatically enabled when you update the Field Service solution to the latest version.

If you want to revert to the classic search experience, disable the Dataverse search feature in the Power Platform admin center.

For more information, see [Enable Dataverse search](/power-platform/admin/configure-relevance-search-organization#enable-dataverse-search#enable-dataverse-search) and set the feature to **Off**.

## Configure search index

With Dataverse search enabled, some [Field Services entities are automatically added](#entities-indexed-by-default) to the search index.

You can add or remove tables from the index. While there's no limit on the number of tables in the index, a limit applies to the number of fields you can add.

For example, add the *Work Order* table to the search index to quickly find work orders related to an account you are searching for.

To add or remove tables from the search index, see [Select tables for Dataverse search](/power-platform/admin/configure-relevance-search-organization#select-tables-for-dataverse-search)

### Entities indexed by default

The following tables or entities in Field Service are indexed by default:

- Account
- Case
- Contact
- Lead
- Product

## Filter search results

When searching in Field Service, you can add filters to the search results. For example, you search for an account name and want to see only the work orders that are in progress. Add the work order status field as a filter.

Fields and filters are defined by a table's Quick Find View. For detailed instructions how define the fields that are available as filters, see [Select searchable fields and filters for each table](/power-platform/admin/configure-relevance-search-organization#select-searchable-fields-and-filters-for-each-table).

## Next steps

- [Create a work order to coordinate and schedule resources and activities](create-work-order.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
