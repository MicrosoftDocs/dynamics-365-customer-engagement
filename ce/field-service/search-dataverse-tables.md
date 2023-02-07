---
title: Use Dataverse search to find information
description: Learn work with the advanced Dataverse search to find relevant information in Dynamics 365 Field Service.
ms.date: 03/08/2023
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

Dataverse search indexes tables in your environment to return results when searching for keywords. You have to [enable Dataverse search](/power-platform/admin/configure-relevance-search-organization#enable-dataverse-search#enable-dataverse-search) after updating Field Service to the latest version.

To revert to the classic search experience, disable the Dataverse search feature in the Power Platform admin center and set the feature to **Off**.

## Configure search index

With Dataverse search enabled, some [Field Services tables are automatically added](#tables-indexed-by-default) to the search index.

You can add or remove tables from the index. While there's no limit on the number of tables in the index, a limit applies to the number of columns you can add. The maximum number of columns shows when you configure the tables to be indexed for Dataverse search. By default, Field Services uses approximately one third the available column capacity.

For example, add the *Work Order* table and the *Account* column to the search index to quickly find work orders related to an account you are searching for.

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

## Filter search results

When searching in Field Service, users can refine search results using [personalized facets and filters](/power-apps/user/facets-and-filters). For more information about search options, see [Search for tables and rows by using Dataverse search](/power-apps/user/relevance-search).

Fields and filters for each table are defined by admnistrators in a table's Quick Find View. For detailed instructions how define the fields that are available as filters, see [Select searchable fields and filters for each table](/power-platform/admin/configure-relevance-search-organization#select-searchable-fields-and-filters-for-each-table).

## Next steps

- [Create a work order to coordinate and schedule resources and activities](create-work-order.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
