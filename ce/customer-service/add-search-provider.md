---
title: Set up and manage integrated search providers
description: Learn how to set up, edit, deactivate, and activate integrated search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.service: dynamics-365 
ms.topic: how-to
ms.date: 12/22/2022
ms.custom: bap-template
---

# Set up and manage integrated search providers

With integrated search providers, you can configure external data providers such as enterprise websites based on the site map protocol. After configuring, the articles from the external providers will be ingested into Microsoft Dataverse, so that agents can view a consolidated list of knowledge article search results and experience a single ranking of articles across search providers.

As administrators, you will also be able to set up a data refresh schedule to specify the refresh frequency of the
ingestion service. The ingestion service will capture newly or updated articles along with any data that might have been missed during syncing and ingestion.

## Prerequisites
- You must prepare the metadata mapping schema file with your article properties to be able to validate the knowledge article schema. More information: Develop metadata mapping schema
- If your website is registered using Azure Active Directory, you’ll need to use OAuth, and provide the **Resource Id**, **Tenant Id**, **Client Id**, and the **Client secret** generated from the AAD Application registration page. More information: Apply authentication

## Add integrated search providers

You must add your search providers using the **Integrated search providers** option from the Customer Service admin center app.

1. In the Customer Service admin center site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
2.	In the **Integrated search providers** section, select **Manage**.
3.	Select **New**.
4.	On the **Add an integrated search provider** page, do the following:
    1. In the **Provider info** section, enter the following information:
        1. **Search provider name**: Enter the name of the search provider.
        1. **Description**: Enter the description of the search provider.
        The **Data source** and **Owner** are auto filled.
        1. Select the authorization check box.
        1. Select **Next**.
    1.	In the **Authentication** section, enter the following information:
        1. **URL**: Provide the root URL of the website along with the protocol (http:// or https://)
        1. **Sitemap URL**: Provide the sitemap URL of the source website.
        1. **Authentication type**: Select **None** or **OAuth** from the dropdown list. If you select **OAuth**, provide the **Resource Id**, **Tenant Id**, **Client Id**, and the **Client secret** generated on the AAD Application registration page. More information: Apply authentication.
        1. Select **Test connection**. You will get a confirmation message that states whether the test connection has passed or failed. In case of an error message, check and correct the details provided.
        1. Select **Next**.
    1.	In the **Knowledge article schema** section, validate the knowledge article schema by copying and pasting your article properties and schema JSON in the field provided to you. More information: Develop metadata mapping schema for knowledge articles. Refer to Appendix: Sample metadata mapping template an example.
       1. Select **Validate json**. You will get a message to denote whether the JSON validation has passed or failed. In case of an error, the error message will state the parameter with the incorrect value.
       1. Select **Next**.
    1.	In the **Refresh schedule** section, specify the refresh intervals:
        1. **Refresh frequency**: Select between **15 mnts** and **7 days** from the dropdown. Your selection specifies the frequency at which newly created or updated articles will be ingested from the external search provider.
        1. **Lookback period**: Select between 2hrs and 8hrs from the dropdown list. Your selection specifies the additional time period for which the articles would be ingested that might have been missed during syncing and ingestion.
        
            For example, if you set the **Refresh frequency** at 15mnts and **Lookback period** at 2hrs, your data will be refreshed for the last 2hrs and 15mnts, in every 15mnts. 
        1.	Select **Next**.
    1.	In the **Completion** section, review your search provider setup and make changes, if any, to the **Search provider name**, **URL**, **Authentication type**, **Refresh frequency**, **Lookback period**.
    1.	Select **Save and close**.

In case of an error, save will fail and you will see a notification. You need to correct the error and try saving the search provider again.

## Edit search providers

After you have added the search providers, you can also make changes, if required. Perform the following steps if you want to edit search providers.

1. In the Customer Service admin center site map, select **Knowledge** in **Agent experience**. The Knowledge page appears.
1. In the **Integrated search providers** section, select **Manage**.
1. Select the active or inactive search provider that you want to make changes to from the dropdown list and then select **Edit**.
1. On the **Search provider details** page, select the specific tab where you want to make your changes and select **Save and Close** after you have made your changes.

## Deactivate search providers

When you deactivate a search provider, the ingestion of newly created or updated articles from the search provider will stop and the articles that have already been ingested will no longer appear in the search results.

> [!NOTE]
> If you have a custom layer on Knowledge Articles Quick find view, you will need to add msdyn_integratedsearchproviderid in View columns and Find columns for articles to stop appearing in the search results.

Perform the following steps if you want to deactivate search providers.
1. In the Customer Service admin center site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
2. In the **Integrated search providers** section, select **Manage**.
3. From the **Active search providers** list, select the active search provider that you want to deactivate and then select **Deactivate**.
4. On the confirmation dialog, select **Deactivate**.
The search provider that you deactivated moves to the **Inactive search providers** list.

## Activate search providers

When you activate a search provider, the ingestion of newly created or updated articles from the search provider will be initiated and articles from the search provider will start appearing in the search results.

Perform the following steps if you want to deactivate search providers.
1. In the Customer Service admin center site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
2. In the **Integrated search providers** section, select **Manage**.
3. From the **Inactive search providers** list, select the inactive search provider that you want to
activate and then select **Activate**.
On the confirmation dialog, select **Activate**. The search provider that you activated moves to the
**Active search providers** list.

## Next steps

If you want to understand how your agents can view search results for your keywords across your configured search providers, go to [Search knowledge articles](search-knowledge-articles-csh.md#search-knowledge-articles).