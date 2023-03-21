---
title: Use Dataverse search to find information
description: Learn how to work with the advanced Dataverse search to find relevant information in Dynamics 365 Field Service.
ms.date: 03/08/2023
ms.reviewer: mhart
ms.topic: conceptual
author: lmasieri
ms.author: lmasieri
search.app: 
  - D365CE
  - D365FS
---

# Use Dataverse search to find information (preview)

Dynamics 365 Field Service stores data as tables in Microsoft Dataverse. You can configure Dataverse search to surface the tables that are relevant to your organization.

> [!NOTE]
> This feature is currently in preview. For more information about enabling features in preview, see [Dynamics 365 release schedule and early access](/dynamics365/get-started/release-schedule).

## Enable Dataverse search

Dataverse search indexes fields within tables in your environment to return results when searching for keywords. [Enable Dataverse search](/power-platform/admin/configure-relevance-search-organization#enable-dataverse-search#enable-dataverse-search) to take advantage of the Dataverse search feature.

To revert to the classic search experience, disable the Dataverse search feature in the Power Platform admin center and set the feature to **Off**.

## Configure search index

With Dataverse search enabled, some [Field Services tables are automatically added](#tables-indexed-by-default) to the search index.

You can add or remove tables from the index. While there's no limit on the number of tables in the index, a limit applies to the number of columns you can add. The maximum number of columns shows when you configure the tables to be indexed for Dataverse search. By default, Field Services uses approximately one third the available column capacity.

For example, add the *Work Order* table and the *Service Account* column to the search index to quickly find work orders related to a specific service account.

To add or remove tables from the search index, see [Select tables for Dataverse search](/power-platform/admin/configure-relevance-search-organization#select-tables-for-dataverse-search)

### Tables indexed by default

The following tables are indexed by default:

- account
- bookablereourcebooking
- contact
- incident
- invoice
- msdyn_agreement
- msdyn_customerasset
- msdyn_purchaseorder
- msdyn_workorder

Each of these tables has several commonly used fields indexed. For example, *msdyn_customerasset* indexes *msdyn_name*, *msdyn_product*, and *msdyn_functionallocation*. To customize which fields are indexed for Dataverse search, edit the table's Quick Find View and add the fields to the **Find by...** section.

## Filter search results

When searching in Field Service, users can refine search results using [personalized facets and filters](/power-apps/user/facets-and-filters). For more information about search options, see [Search for tables and rows by using Dataverse search](/power-apps/user/relevance-search).

Administrators defined fields and filters for each table in a table's Quick Find View. For more information, see [Select searchable fields and filters for each table](/power-platform/admin/configure-relevance-search-organization#select-searchable-fields-and-filters-for-each-table).

## Next steps

- [Create a work order to coordinate and schedule resources and activities](create-work-order.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
