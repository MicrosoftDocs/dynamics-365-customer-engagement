---
title: View and use insights for search providers
description: Learn how to view ingestion insights about your search providers in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to 
ms.date: 06/21/2024
ms.custom: bap-template 
---

# View and use insights for search providers

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

After you add search providers to Customer Service, you can use the **Insights** tab in the Customer Service admin center or Contact Center admin center to monitor ingestion. The tab displays the following details for the search provider: **Ingestion ID**, **Status**, **Crawl failures**, **Recognized**, **Created**, **Updated**, and **Failed**.

## View insights

1. In the site map of Customer Service admin center or Contact Center admin center, go to **Knowledge > Integrated search providers > Manage**.
1. Select **Active integrated search providers** or **Inactive integrated search providers** in the list, and then select a search provider.
1. Select the **Insights** tab.

The tab shows up to 100 ingestion IDs. The data is refreshed every 30 minutes.

## Use insights

The **Failed** column shows articles that weren't ingested. To view the failed articles, select the ingestion ID.

The **Error type** column indicates whether the failure was a crawl error before ingestion or an ingestion run error.

### Related information

[Troubleshoot issues with integrated search providers](../int-search-troubleshoot.md#troubleshoot-issues-with-integrated-search-providers)
