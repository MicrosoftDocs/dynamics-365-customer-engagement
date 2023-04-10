---
title: View and use insights for search providers
description: Learn how you can view and use insights of your search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi 
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 04/10/2023
ms.custom: bap-template 
---

# View and use insights for search providers

After you have configured your search providers, you can view the insights for your search provider in the Customer Service admin center. The Insights tab provides the **Ingestion ID**, **Status**, **Recognized**, **Created**, **Updated**, and **Failed** details of the search provider.

## View insights

1. In the Customer Service admin center site map, go to **Knowledge > Integrated search providers (Preview) > Manage**.
1. Select the **Active integrated search providers** or the **Inactive integrated search providers** from the dropdown list, and then select the search provider that you want to view.
1. On the **Search provider details** dialog, select the **Insights** tab.
The  ingestion metrics for that search provider are displayed.

You can see up to a maximum of 100 ingestion IDs. The data on the **Insights** tab is refreshed every 30min.

## Use insights

You can view the failed articles in the **Failed** column. The failed articles count helps you review the ingestion success status.

To view the failed articles, select the ingestion ID.

## See Also

[Troubleshoot issues with integrated search providers](int-search-troubleshoot.md#troubleshoot-issues-with-integrated-search-providers)