---
title: Manage integrated search providers
description: Learn how to provision, add, and manage integrated search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 04/06/2023
ms.custom: bap-template
---

# Manage integrated search providers (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

With integrated search providers, you can configure external data providers such as enterprise websites based on the site map protocol. The articles from the external providers will be ingested into Microsoft Dataverse, so that agents can view a consolidated list of knowledge article search results and experience a single ranking of articles across search providers.

As administrators, you can set up a data refresh schedule to specify the refresh frequency of the ingestion service. The ingestion service captures new or updated articles along with any data that might have been missed during ingestion.

## Prerequisites

- If your website is registered using Azure Active Directory, you must use OAuth. Provide the **Resource Id**, **Tenant Id**, **Client Id**, and the **Client secret** generated from the AAD Application registration page. More information: [Apply authentication for search providers (preview)](apply-authentication-provider.md#apply-authentication-for-search-providers-preview)

- If you're a first time user, you must:

1. Provision integrated search providers
1. Enable the **Integrated Search API trigger flow**

### Provision integrated search providers

You must provision the integrated search provider from Customer Service admin center.
1. On the Customer Service admin center site map, go to **Knowledge** > **Integrated Search providers (Preview)** > **Manage**.
1. On the **Integrated search providers** page, select **Set up integrated search**.

If integrated search isn't enabled in your geographical region, contact Microsoft Support to provision the feature.

### Enable the Integrated Search API trigger flow

You must turn on the **Integrated Search API trigger** flow.

1. Go to [make.powerapps.com](https://make.powerapps.com).
1. Go to **Solutions** > **Default Solution** > **Cloud flows** and turn on the **Integrated Search API trigger flow** flow.
:::image type="content" source="media/int-search-turn-on.jpg" alt-text="Turn on Integrated search API trigger flow":::

You can now add integrated search providers.

## Add integrated search providers

1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The **Knowledge** page appears.
2.	In the **Integrated search providers (Preview)** section, select **Manage**.
3.	Select **New**. The **Add an integrated search provider** dialog appears.
4.	In the **Provider info** section, do the following:
    1. **Search provider name**: Enter the name of the search provider.
    1. **Description**: Enter the description of the search provider.
    The **Data source** and **Owner** are auto filled.
    1. Select the authorization check box.
    1. Select **Next** to go the next section, or select **Save as draft**, if you still need to provide information for the section.
1.	In the **Authentication and testing** section, enter the following information:
    1. **Root URL**: Provide the root URL of the website along with the protocol.
    1. **Site map URL**: Provide the site map URL of the source website. To get the site map URL, for example, type https://www.contoso.com/robots.txt in the address bar.
        > [!NOTE]
        > - The site map that you provide must have the **lastmod** tag within the article **url** tag.
        > - The site map and the site index files must have content-type as either application/xml or text/xml.
        > - You must provide static websites only for data ingestion. Websites that return scripts to load content aren't supported for data ingestion.
    1. **Language filter for ingestion**: Select the languages you want to specifically map for the ingestion from the dropdown list. Select **Reset** to clear the language selection. By default, all languages are considered for ingestion. If you apply language filters, you must maintain the mapping for language code.
    1. **Authentication type**: Select **None** or **OAuth** from the dropdown list. If you select **OAuth**, provide the **Resource Id**, **Tenant Id**, **Client Id**, and the **Client secret** generated on the AAD Application registration page. More information: [Apply authentication for search providers (preview)](apply-authentication-provider.md#apply-authentication-for-search-providers-preview).
    1. Select **Test connection**.
        
        Test connection uses the credentials provided to see whether the connection is successful. You get a confirmation message that states whether the test connection has passed or failed. In case of an error message, check and correct the details provided.
    1. Select **Next** to go the next section, or select **Save as draft**, if you still need to provide information for the section.
1.	In the **Knowledge article schema** section, select from either the **Field Mapping** or **JSON Schema** configuration options. You won't be able to change the configuration method after you've saved it. For details on knowledge article schema mapping, go to [Configure knowledge article schema mapping (preview)](int-data-mapping.md#configure-knowledge-article-schema-mapping-preview).
1.	In the **Refresh Schedule** section, specify the refresh intervals:
    1. **Refresh frequency**: Select a value from the dropdown list. Your selection specifies the frequency at which newly created or updated articles are ingested from the external search provider. If you want to pause ingestion, select **No refresh**.
    1. **Lookback period**: Select a value from the dropdown list. Your selection specifies the additional time period for which the articles would be ingested that might have been missed during ingestion.
        
        For example, if you set the refresh frequency at 15 minutes and lookback period at 2 hours, your data is refreshed for the last 2 hours and 15 minutes, in every 15 minutes.
    1. Select **Next** to go the next section, or select **Save as draft**, if you still need to provide information for the section.
1.	In the **Summary** section, review your search provider setup and make changes, if any, to the **Search provider name**, **URL**, **Authentication type**, **Refresh frequency**, and **Lookback period**.

1. Select **Save and close**. Your newly added search provider now appears on the **Knowledge** > **All integrated search providers** page. The status of the search provider will be **Inactive** with status reason as **Validated**.

1. Optionally, select **Save as draft**, if you still need to provide information for any of the sections. The status of the search provider will appear as **Inactive** with status reason as **Draft**.

> [!NOTE]
> - For public preview, data ingestion is limited to 100,000 articles per ingestion run.
> - A unique combination of root URL, site map URL, and language filters only are allowed.

## Run ingestion for search providers

Depending on the status of your search provider, you can either run a custom or a trial ingestion.

If your search provider is in **Inactive** with status reason as **Validated**, you can perform a trial ingestion, by performing the following steps:

1. Select the search provider from the **Knowledge** > **All integrated search providers** page.
1. Select **Run Ingestion**.
1. On the **Run Ingestion** dialog, select the **Trial Ingestion** option, and then specify the number of articles to be from the **No of records** dropdown list.

If your search provider is in **Active** with status reason as **Ingestion Ready**, you can perform a custom ingestion, by performing the following steps:

1. Select the search provider from the **Knowledge** > **All integrated search providers** page.
1. Select **Run Ingestion**.
1. On the **Run Ingestion** dialog, select the **Custom Ingestion** option, and then specify the date range to pick up updated articles to run ingestion.



activate: write it as , u have to activate the search provider will be **Inactive** with status reason as **Validated**.

## Edit search providers

When you edit a search provider, your changes will appear in the subsequent ingestion run.

1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The Knowledge page appears.
1. In the **Integrated search providers (Preview)** section, select **Manage**.
1. Select the **Active integrated search providers** or the **Inactive integrated search providers** from the dropdown list, and then select the search provider that you want to make changes to.
1. Select **Edit**.
1. On the **Search provider details** page, select the specific tab where you want to make your changes and select **Save and Close** after you have made your changes.

## Deactivate search providers

When you deactivate a search provider, the ingestion of newly created or updated articles from the search provider stops and the articles that have already been ingested won't appear in the search results.

> [!NOTE]
> If you have a custom layer on Knowledge Articles Quick find view, you will need to add msdyn_integratedsearchproviderid in View columns and Find columns for articles to stop appearing in the search results.

1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The **Knowledge** page appears.
2. In the **Integrated search providers (Preview)** section, select **Manage**.
3. From the **Active search providers** list, select the active search provider that you want to deactivate and then select **Deactivate**.
4. On the confirmation dialog, select **Deactivate**.
The search provider that you deactivated is added to the **Inactive search providers** list.

## Activate search providers

When you activate a search provider, the ingestion of newly created or updated articles from the search provider is initiated and articles starts appearing in the search results.

1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The **Knowledge** page appears.
1. In the **Integrated search providers (Preview)** section, select **Manage**.
1. From the **Inactive search providers** list, select the inactive search provider that you want to
activate and then select **Activate**.
1. On the confirmation dialog, select **Activate**. The search provider that you activated is added to the
**Active search providers** list.

## Configure search providers as search filters

Configure search providers as filters to search knowledge articles only from selected data providers. The filter works only if you have Dataverse Search enabled.

To configure search providers as search filters for knowledge articles:

1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The Knowledge page appears.

    In the **Filters** section, ensure that the **Enable search filters** toggle is switched to **Yes**.
1. From the **Select filter type** dropdown list, select **Integrated Search Dataprovider Id**, and then select **Add**.
1. From the **Lookup Records** dialog, select the **Search** icon.
1. Select the search provider, and then select **Add**. The search provider gets added to your filters. 
1. Optionally, to set predetermined search providers that'll appear for agents by default, switch the **Set as preselected filter** toggle to **Yes**.

If you select a deactivated data search provider, it might appear on the **Filter by** dropdown list, but you won't see any search results from the selected data provider.

## Next Steps

 [View and use insights for search providers](view-and-use-insights.md)

 [Search knowledge articles](search-knowledge-articles-csh.md#search-knowledge-articles)