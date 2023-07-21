---
title: Manage integrated search providers
description: Learn how to provision, add, refresh, edit, and deactivate integrated search providers and configure them as search filters.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 07/03/2023
ms.custom: bap-template
---

# Manage integrated search providers

With integrated search providers in Dynamics 365 Customer Service, you can configure third-party sources, such as enterprise websites that are based on the site map protocol. Articles are ingested into Dataverse and refreshed on the schedule you specify.

## Prerequisites

If you're a first-time user, you must provision integrated search providers. Make sure that you have the following privileges:

- At the Basic level: **prvReadconnector**
- At the Global level:

- Basic level: **prvReadconnector**
- Global level:
  - **prvReadWorkflow**
  - **prvWriteWorkflow**
  - **prvCreatemsdyn_knowledgeconfiguration**
  - **prvReadmsdyn_knowledgeconfiguration**
  - **prvWritemsdyn_knowledgeconfiguration**
  - **prvDeletemsdyn_knowledgeconfiguration**

[Learn more about security roles and privileges](/power-platform/admin/security-roles-privileges#security-roles-and-the-legacy-ui).

## Provision integrated search providers

1. Sign in to the Dynamics 365 Customer Service admin center.
1. Go to **Knowledge** > **Integrated Search providers (Preview)** > **Manage**.
1. On the **Integrated search providers** page, select **Set up integrated search**.

If you aren't able to provision the integrated search provider, you'll need to enable the Integrated Search API trigger flow.

If integrated search isn't enabled in your geographical region, contact Microsoft Support to provision the feature.

## Enable the Integrated Search API trigger flow

> [!NOTE]
> To turn on the **Integrated Search API trigger** flow, you must have the **prvReadWorkflow** Global-level privileges.

[!INCLUDE [Lightbox tip](~/../shared-content/shared/lightbox-tip.md)]

1. Sign in to [make.powerapps.com](https://make.powerapps.com).
1. Go to **Solutions** > **Default Solution** > **Cloud flows** and turn on **Integrated Search API trigger flow**.

    :::image type="content" source="media/int-search-turn-on.jpg" alt-text="Screenshot of enabling the Integrated Search API trigger flow." lightbox="media/int-search-turn-on.jpg":::

## Add integrated search providers

1. In the Customer Service admin center, under **Experiences**, select **Knowledge**.
1. On the **Knowledge** page, in the **Integrated search providers** section, select **Manage**.
1. Select **New**.
1. In the **Provider info** section:

    - **Search provider name**: Enter the name of the search provider.
    - **Description**: Enter the description of the search provider.
    - Select the authorization check box.

1. Select **Next**.

1. In the **Authentication and testing** section:

    - **Root URL**: Enter the root URL of the search provider website, including the protocol.
    - **Site map URL**: Enter the site map URL of the website. To get the site map URL, enter the root URL followed by `/robots.txt` in the address bar, and then search the file for "sitemapindex." For example, type https://www.contoso.com/robots.txt in the address bar.

        > [!NOTE]
        >
        > - The site map that you provide must have the **lastmod** tag within the article **url** tag.
        > - The site map and the site index files must have content-type as either application/xml or text/xml.
        > - You must provide static websites only for data ingestion. Websites that return scripts to load content aren't supported for data ingestion.
        > - A unique combination of root URL, site map URL, and language filters only are allowed.

    - **Language filter for ingestion**: Select the languages you want to map for the ingestion. Select **Reset** to clear your selection. By default, all languages are considered for ingestion. If you apply language filters, you must maintain the mapping for language code.

1. Select **Next**.

1. In the **Knowledge article schema** section, select either **Field Mapping** or **JSON Schema**.

    You can't change the configuration method after you save it. [Learn more about knowledge article schema mapping](int-data-mapping.md#configure-knowledge-article-schema-mapping).

1. In the **Refresh Schedule** section, specify the refresh intervals:

    - **Refresh frequency**: Select a value from the list to specify the frequency at which new or updated articles are ingested from the search provider. To pause ingestion, select **No refresh**.
    - **Lookback period**: Select a value from the list to specify an additional period over which articles should be ingested that might have been missed during the initial ingestion.

        For example, if you set the refresh frequency at 15 minutes and lookback period at 2 hours, your data is refreshed for the last 2 hours and 15 minutes, every 15 minutes.

1. Select **Next**.

1. In the **Summary** section, review the information you entered and make any changes you need to.

1. Select **Save and close**.

    The new search provider appears on the **Knowledge** > **All integrated search providers** page. Its status is **Inactive** with status reason **Validated**.  

    If you need to add further information, select **Save as draft**. The status is **Inactive** with status reason **Draft**.

## Run ingestion for search providers

Depending on the search provider's status, run either a time-range based or a trial ingestion. When you start a trial ingestion, you can spot and correct any errors. View the status of your ingestion on the **Insights** tab in the **Crawl failures** column.

You can't run ingestion for search providers that are **Inactive** with status reason **Draft**.

### Trial ingestion

If your search provider is **Inactive** with status reason **Validated**, you can run a trial ingestion.

1. On the **Knowledge** > **All integrated search providers** page, select the search provider.
1. Select **Run Ingestion**.
1. Select **Trial Ingestion**.
1. Specify the number of articles to ingest from the **No of records** list. The maximum number of articles you can select is 1,000.

Check the **Insights** tab for errors. If you don't see any and you want to run a time-range based ingestion, [activate the search provider](#activate-search-providers) first.

### Time-range based ingestion

If your search provider is **Active** with status reason **Ingestion Ready**, initiate a time-range based ingestion.

1. On the **Knowledge** > **All integrated search providers** page, select the search provider.
1. Select **Run Ingestion**.
1. Select **Time-range based ingestion**.
1. Specify the date range from which to pick up updated articles for the ingestion. The date range has to be 60 days from the **From** date.

## Activate search providers

When you activate a search provider, new and updated articles start ingesting from the provider, and articles start appearing in the search results.

1. In the Customer Service admin center, under **Experiences**, select **Knowledge**.
1. On the **Knowledge** page, in the **Integrated search providers** section, select **Manage**.
1. From the **Inactive search providers** list, select a search provider, and then select **Activate**.
1. Select **Activate** again to confirm you want to activate the search provider.

## Edit search providers

When you edit a search provider, your changes take effect with the next ingestion.

1. In the Customer Service admin center, under **Experiences**, select **Knowledge**.
1. On the **Knowledge** page, in the **Integrated search providers** section, select **Manage**.
1. Select **Active integrated search providers** or **Inactive integrated search providers** from the **All integrated search providers** list, and then select the search provider that you want to make changes to.
1. Select **Edit**.
1. On the **Search provider details** page, select the tab where you want to make changes.
1. Edit the information as needed.
1. Select **Save and Close**.

## Deactivate search providers

When you deactivate a search provider, ingestion of new and updated articles from the search provider stops. Articles that have already been ingested no longer appear in search results.

1. In the Customer Service admin center, under **Experiences**, select **Knowledge**.
1. On the **Knowledge** page, in the **Integrated search providers** section, select **Manage**.
1. From the **Active search providers** list, select a search provider.
1. Select **Deactivate**.
1. Select **Deactivate** again to confirm you want to deactivate the search provider.

## Configure search providers as search filters

Configure search providers as filters to search knowledge articles only from selected data providers. The filter works only if you have Dataverse Search enabled.

> [!NOTE]
> If you have a custom layer on the Knowledge Articles Quick Find view, add `msdyn_integratedsearchproviderid` in **View columns** and **Find columns** to stop articles from appearing in search results.

1. In the Customer Service admin center, under **Experiences**, select **Knowledge**.
1. In the **Filters** section, make sure that **Enable search filters** is set to **Yes**.
1. From the **Select filter type** list, select **Integrated Search Dataprovider Id**, and then select **Add**.
1. Select the **Search** icon.
1. Select the search provider, and then select **Add**.
1. Optionally, to set predetermined search providers to appear for agents by default, switch **Set as preselected filter** to **Yes**.

If you select a deactivated data search provider, it might appear on the **Filter by** list, but no search results from the selected provider are returned.

## Next steps

 [View and use insights for search providers](view-and-use-insights.md)  
 [Search knowledge articles](search-knowledge-articles-csh.md#search-knowledge-articles)
