---
title: Provision, add, and manage integrated search providers
description: Learn how to provision, add, and manage integrated search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.service: dynamics-365 
ms.topic: how-to
ms.date: 02/15/2023
ms.custom: bap-template
---

# Provision, add, and manage integrated search providers (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

With integrated search providers, you can configure external data providers such as enterprise websites based on the site map protocol. After configuring, the articles from the external providers will be ingested into Microsoft Dataverse, so that agents can view a consolidated list of knowledge article search results and experience a single ranking of articles across search providers.

As administrators, you will also be able to set up a data refresh schedule to specify the refresh frequency of the
ingestion service. The ingestion service will capture newly or updated articles along with any data that might have been missed during syncing and ingestion.

## Prerequisites
- You must prepare the metadata mapping schema file with your article properties to be able to validate the knowledge article schema. More information: [Develop metadata mapping schema for knowledge articles (preview)](int-search-metadata-schema.md#develop-metadata-mapping-schema-for-knowledge-articles-preview)

- If your website is registered using Azure Active Directory, you’ll need to use OAuth, and provide the **Resource Id**, **Tenant Id**, **Client Id**, and the **Client secret** generated from the AAD Application registration page. More information: [Apply authentication (preview)](apply-authentication-provider.md#apply-authentication-preview)

## Provision integrated search providers
If you are a first time user, you'll need to enable the integrated search provider provisioning from the Customer Service admin center.
1. On the Customer Service admin center site map, go to **Knowledge** > **Integrated Search providers** > **Manage**.
1. On the **Integrated search providers** page, select **Set up integrated search**.
You'll see a status message, "Integrated search is provisioning. It will take few minutes to complete."

After the provisioning is complete, you can add an integrated search provider by performing the steps provided below.

## Add integrated search providers

1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The **Knowledge** page appears.
2.	In the **Integrated search providers (Preview)** section, select **Manage**.
3.	Select **New**. The **Add an integrated search provider** dialog appears.
4.	In the **Provider info** section, do the following:
    1. **Search provider name**: Enter the name of the search provider.
    1. **Description**: Enter the description of the search provider.
    The **Data source** and **Owner** are auto filled.
    1. Select the authorization check box.
    1. Select **Next**.
1.	In the **Authentication and testing** section, enter the following information:
    1. **Root URL**: Provide the root URL of the website along with the protocol (http:// or https://)
    1. **Site map URL**: Provide the sitemap URL of the source website.
    1. **Languages mapped**: Select the languages you want to specifically map for the ingestion from the dropdown list, and then select **Reset**. By default, all languages are considered for ingestion.
    1. **Authentication type**: Select **None** or **OAuth** from the dropdown list. If you select **OAuth**, provide the **Resource Id**, **Tenant Id**, **Client Id**, and the **Client secret** generated on the AAD Application registration page. More information: Apply authentication.
    1. Select **Test connection**. You will get a confirmation message that states whether the test connection has passed or failed. In case of an error message, check and correct the details provided.
    1. Select **Next**.
1.	In the **Knowledge article schema** section, select from either the **Field Mapping** or **JSON Schema** configuration options. You won't be able to change the configuration method after you have saved it. For details on knowledge article schema mapping, go to [Configure knowledge article schema mapping (preview)](int-data-mapping.md#configure-knowledge-article-schema-mapping-preview).
1.	In the **Refresh Schedule** section, specify the refresh intervals:
    1. **Refresh frequency**:
        1. Select between **15min** to **7days** from the dropdown list. Your selection specifies the frequency at which newly created or updated articles will be ingested from the external search provider. If you want to pause ingestion, select **No refresh**.
    1. **Lookback period**:
        1. Select between **2h** to **8h** from the dropdown list. Your selection specifies the additional time period for which the articles would be ingested that might have been missed during syncing and ingestion.
        
            For example, if you set the **Refresh frequency** at 15min and **Lookback period** at 2h, your data will be refreshed for the last 2h and 15min, in every 15min.
        1. Select **Next**.
1.	In the **Summary** section, review your search provider setup and make changes, if any, to the **Search provider name**, **URL**, **Authentication type**, **Refresh frequency**, and **Lookback period**.
    1. Select **Add provider**.
    1. Select **Save and close**.

Your newly added search provider will now appear on the **Knowledge > All search providers** page in the Customer Service admin center.

In case of an error, save will fail and you will see a notification. You need to correct the error and try saving the search provider again.

## Edit search providers

After you have added the search providers, you can also make changes, if required. Perform the following steps if you want to edit search providers.

1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The Knowledge page appears.
1. In the **Integrated search providers** section, select **Manage**.
1. Select the active or inactive search provider that you want to make changes to from the dropdown list and then select **Edit**.
1. On the **Search provider details** page, select the specific tab where you want to make your changes and select **Save and Close** after you have made your changes.

## Deactivate search providers

When you deactivate a search provider, the ingestion of newly created or updated articles from the search provider will stop and the articles that have already been ingested will no longer appear in the search results.

> [!NOTE]
> If you have a custom layer on Knowledge Articles Quick find view, you will need to add msdyn_integratedsearchproviderid in View columns and Find columns for articles to stop appearing in the search results.

Perform the following steps if you want to deactivate search providers.
1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The **Knowledge** page appears.
2. In the **Integrated search providers** section, select **Manage**.
3. From the **Active search providers** list, select the active search provider that you want to deactivate and then select **Deactivate**.
4. On the confirmation dialog, select **Deactivate**.
The search provider that you deactivated moves to the **Inactive search providers** list.

## Activate search providers

When you activate a search provider, the ingestion of newly created or updated articles from the search provider will be initiated and articles from the search provider will start appearing in the search results.

Perform the following steps if you want to deactivate search providers.
1. In the Customer Service admin center site map, select **Knowledge** in **Experiences**. The **Knowledge** page appears.
2. In the **Integrated search providers** section, select **Manage**.
3. From the **Inactive search providers** list, select the inactive search provider that you want to
activate and then select **Activate**.
On the confirmation dialog, select **Activate**. The search provider that you activated moves to the
**Active search providers** list.

## Next steps

After the configuration is done, you can use the insights data to understand whether the data ingestion has been successful and the details of the ingested articles. For more information on insights, go to [View and use insights for search providers](view-and-use-insights.md).

If you want to understand how your agents can view search results for your keywords across your configured search providers, go to [Search knowledge articles](search-knowledge-articles-csh.md#search-knowledge-articles).