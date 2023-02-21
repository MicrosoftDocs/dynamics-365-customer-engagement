---
title: View and use insights for search providers
description: Learn how you can view and use insights of your search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi 
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 02/21/2023
ms.custom: bap-template 
---

# View and use insights for search providers (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

After you have configured your search providers, you can view the insights for your search provider in the Customer Service admin center. The Insights tab provides the **Ingestion ID**, **Status**, **Recognized**, **Created**, **Updated**, and **Failed** details of the search provider.

## View insights

1. In the Customer Service admin center site map, go to **Knowledge > All search providers** and select the search provider that you want to view.
1. On the **Search provider details** dialog, select the **Insights** tab.
The search provider details will be displayed.

You can see up to a maximum of 100 ingestion IDs. Data displayed will be from the last 24hrs. The **Insights** tab is auto-refreshed every 30min.

## Use insights

You can view the failed articles in the **Failed** column. Having the failed articles count will help you review the ingestion success status. You can retry the failed articles to ensure successful data ingestion.

1. Select the article count to view the failed articles.
1. Select **Retry** for individual articles or select **Retry all** to run all the articles together.