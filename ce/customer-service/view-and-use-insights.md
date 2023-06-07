---
title: View and use insights for search providers
description: Learn how you can view and use insights for your search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi 
ms.service: dynamics-365
ms.topic: how-to 
ms.date: 05/02/2023
ms.custom: bap-template 
---

# View and use insights for search providers

After you configure your search providers, you can view the insights for each provider in the Customer Service admin center app. In the **Search provider details** dialog box, the **Insights** tab includes **Ingestion ID**, **Status**, **Crawl failures**, **Recognized**, **Created**, **Updated**, and **Failed** columns that show data for the search provider.

## View insights

1. In Customer Service admin center, in the site map, go to **Knowledge** \> **Integrated search providers (Preview)** \> **Manage**.
1. In the dropdown list, select either **Active integrated search providers** or **Inactive integrated search providers**, and then select the search provider that you want to view.
1. In the **Search provider details** dialog box, select the **Insights** tab to view the ingestion metrics for the selected search provider.

A maximum of 100 ingestion IDs are shown. The data on the **Insights** tab is updated every 30 minutes.

## Use insights

The **Failed** column on the **Insights** tab shows the articles that failed. The count of failed articles can help you review the ingestion success status.

To view the failed articles, select the ingestion ID. The **Error type** column indicates whether the failure was a crawl error that occurred before ingestion or an ingestion run error.

## See also

[Troubleshoot issues with integrated search providers](int-search-troubleshoot.md)
