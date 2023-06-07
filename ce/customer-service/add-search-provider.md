---
title: Manage integrated search providers
description: Learn how to provision, add, and manage integrated search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 05/02/2023
ms.custom: bap-template
---

# Manage integrated search providers

With integrated search providers, you can configure external data providers, such as enterprise websites, based on the site map protocol. The articles from the external data providers are ingested into Dataverse. Agents can then view a consolidated list of knowledge article search results and experience a single ranking of articles across search providers.

As an administrator, you can set up a data refresh schedule to specify the refresh frequency of the ingestion service. The ingestion service captures new or updated articles together with any data that was missed during ingestion.

## Prerequisites

If you're a first-time user, you must provision integrated search providers. Make sure that you have the following privileges:

- At the Basic level: **prvReadconnector**
- At the Global level:

    - **prvReadWorkflow**
    - **prvWriteWorkflow**
    - **prvCreatemsdyn\_knowledgeconfiguration**
    - **prvReadmsdyn\_knowledgeconfiguration**
    - **prvWritemsdyn\_knowledgeconfiguration**
    - **prvDeletemsdyn\_knowledgeconfiguration**

[Learn more about security roles and privileges.](/power-platform/admin/security-roles-privileges#security-roles-and-the-legacy-ui)

### Provision integrated search providers

You must provision integrated search providers from Customer Service admin center.

1. In Customer Service admin center, in the site map, go to **Knowledge** \> **Integrated Search providers (Preview)** \> **Manage**.
1. On the **Integrated search providers** page, select **Set up integrated search**.

If you can't provision integrated search providers, you must [enable the Integrated Search API trigger flow](#enable-the-integrated-search-api-trigger-flow).

If integrated search isn't enabled in your geographical region, contact Microsoft Support to provision the feature.

### Enable the Integrated Search API trigger flow

> [!NOTE]
> To turn on the **Integrated Search API trigger** flow, you must have the **prvReadWorkflow** Global-level privileges.

1. Open the [Power Apps maker portal](https://make.powerapps.com).
1. Go to **Solutions** \> **Default Solution** \> **Cloud flows**, and turn on the **Integrated Search API trigger flow** flow.

:::image type="content" source="media/int-search-turn-on.jpg" alt-text="Screenshot that shows Integrated search API trigger flow being turned on.":::

You can now add integrated search providers.

## Add integrated search providers

1. In Customer Service admin center, in the site map, in **Experiences**, select **Knowledge**. The **Knowledge** page appears.
1. In the **Integrated search providers** section, select **Manage**.
1. Select **New**. The **Add an integrated search provider** dialog box appears.
1. In the **Provider info** section, follow these steps:

    1. In the **Search provider name** field, enter the name of the search provider.
    1. In the **Description** field, enter a description of the search provider.

        The **Data source** and **Owner** fields are automatically set.

    1. Select the authorization checkbox.
    1. Select **Next**.

1. In the **Authentication and testing** section, follow these steps:

    1. In the **Root URL** field, provide the root URL of the website. Include the protocol.
    1. In the **Site map URL** field, provide the URL of the site map for the source website. To get the site map URL, enter, for example, `https://www.contoso.com/robots.txt` in the address bar.

        > [!NOTE]
        > - The site map that you provide must have the `lastmod` tag inside the article `url` tag.
        > - In the site map and the site index files, `content-type` must be set to either `application/xml` or `text/xml`.
        > - You must provide only static websites for data ingestion. Websites that return scripts to load content aren't supported for data ingestion.

    1. Set language filters for ingestion. In the dropdown list, select the languages that you want to map for ingestion. By default, all languages are considered for ingestion. To clear the language selection, select **Reset**. If you apply language filters, you must maintain the mapping for the language code.
    1. Select **Next**.

    > [!IMPORTANT]
    > The combination of a root URL, a site map URL, and language filters must be unique.

1. In the **Knowledge article schema** section, select either **Field Mapping** or **JSON Schema** as the configuration method. You can't change the configuration method after you save it. [Learn more about knowledge article schema mapping.](int-data-mapping.md#configure-knowledge-article-schema-mapping)
1. In the **Refresh Schedule** section, follow these steps to specify the refresh intervals:

    1. In the **Refresh frequency** field, select how often new or updated articles should be ingested from the external search provider. To pause ingestion, select **No refresh**.
    1. In the **Lookback period** field, select the additional period to ingest any articles that were missed during ingestion.

        For example, if you specify a refresh frequency of 15 minutes and a lookback period of two hours, your data is refreshed for the last two hours and 15 minutes, at 15-minute intervals.

    1. Select **Next**.

1. In the **Summary** section, review your search provider setup, and make any required changes to the **Search provider name**, **Root URL**, **Authentication type**, **Refresh frequency**, and **Lookback period** values.
1. Select **Save and close**. Your new search provider now appears on the **All integrated search providers** page (**Knowledge** \> **All integrated search providers**). At this point, the status of the search provider is **Inactive**, and the status reason is **Validated**.
1. (Optional) Select **Save as draft** if you must still provide information for any section. In this case, the status of the search provider remains **Inactive**, but the status reason is changed to **Draft**.
1. Run a trial ingestion or a time-range-based ingestion for your search providers, as described in the next section.

## Run ingestion for search providers

Depending on the status of your search provider, you can run either a time-range-based ingestion or a trial ingestion. If you initiate a trial ingestion, you can fix any errors that occur when you add an integrated search provider. You can view the status of your ingestion in the **Crawl failures** column on the **Insights** tab.

> [!NOTE]
> You can't run ingestion for search providers that have a status of **Inactive** and a status reason of **Draft**.

### Trial ingestion

If your search provider has a status of **Inactive** and a status reason of **Validated**, you can initiate a trial ingestion by following these steps:

1. On the **All integrated search providers** page (**Knowledge** \> **All integrated search providers**), select the search provider.
1. Select **Run Ingestion**. The **Run Ingestion** dialog box appears.
1. Select the **Trial Ingestion** option.
1. In the **No of records** field, specify the number of articles to select. The maximum number of articles that you can select for the ingestion is 1,000.

If errors occur during the ingestion, you can view them on the **Insights** tab. If no errors are shown after the trial ingestion, and you want to run a time-range-based ingestion, you must [activate the search provider](#activate-search-providers).

### Time-range based ingestion

If your search provider has a status of **Active** and a status reason of **Ingestion Ready**, you can initiate a time-range based ingestion by following these steps:

1. On the **All integrated search providers** page (**Knowledge** \> **All integrated search providers**), select the search provider.
1. Select **Run Ingestion**. The **Run Ingestion** dialog box appears.
1. Select the **Time-range based ingestion** option.
1. Specify the date range to pick up updated articles for the ingestion. The date range must be 60 days from the **From** date.

## Activate search providers

When you activate a search provider, the ingestion of new or updated articles from the search provider is initiated, and articles start to appear in the search results.

1. In Customer Service admin center, in the site map, in **Experiences**, select **Knowledge**. The **Knowledge** page appears.
1. In the **Integrated search providers (Preview)** section, select **Manage**.
1. In the **Inactive search providers** list, select the inactive search provider that you want to activate.
1. Select **Activate**. A confirmation message box appears.
1. Select **Activate**. The search provider is activated and added to the **Active search providers** list.

## Edit search providers

When you edit a search provider, your changes will appear in the next ingestion run.

1. In Customer Service admin center, in the site map, in **Experiences**, select **Knowledge**. The **Knowledge** page appears.
1. In the **Integrated search providers (Preview)** section, select **Manage**.
1. In the **All integrated search providers** dropdown list, select either **Active integrated search providers** or **Inactive integrated search providers**, and then select the search provider that you want to edit.
1. Select **Edit**. The **Search provider details** page appears.
1. Select the tab where you want to make your changes, and make those changes.
1. When you've finished, select **Save and Close**.

## Deactivate search providers

When you deactivate a search provider, the ingestion of new or updated articles from the search provider stops, and articles that have already been ingested don't appear in the search results.

1. In Customer Service admin center, in the site map, in **Experiences**, select **Knowledge**. The **Knowledge** page appears.
1. In the **Integrated search providers (Preview)** section, select **Manage**.
1. In the **Active search providers** list, select the active search provider that you want to deactivate.
1. Select **Deactivate**. A confirmation message box appears.
1. Select **Deactivate**. The search provider is deactivated and added to the **Inactive search providers** list.

## Configure search providers as search filters

By configuring search providers as filters, you can search for knowledge articles from selected data providers only. The filters work only if you've enabled Dataverse Search.

> [!NOTE]
> If you have a custom layer on the **Knowledge Articles Quick find** view, you must add *msdyn\_integratedsearchproviderid* in **View columns** and **Find columns** to make articles stop appearing in the search results.

To configure search providers as search filters for knowledge articles, follow these steps:

1. In Customer Service admin center, in the site map, in **Experiences**, select **Knowledge**. The **Knowledge** page appears.
1. In the **Filters** section, make sure that the **Enable search filters** toggle is set to **Yes**.
1. In the **Select filter type** dropdown list, select **Integrated Search Dataprovider Id**.
1. Select **Add**. The **Lookup Records** dialog box appears.
1. Select the **Search** button.
1. Select the search provider, and then select **Add**. The search provider is added to your filters.

    > [!NOTE]
    > If you select a deactivated data search provider, it might appear on the **Filter by** dropdown list, but no search results from the selected data provider will be shown.

1. (Optional) If you want the search provider to appear for agents by default, set the **Set as preselected filter** toggle to **Yes**.

## Next steps

[View and use insights for search providers](view-and-use-insights.md)

[Search knowledge articles](search-knowledge-articles-csh.md#search-knowledge-articles)
