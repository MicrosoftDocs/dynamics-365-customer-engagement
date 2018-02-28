---
title: "Configure core marketing functionality (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Use the marketing settings to configure landing pages, email marketing, and Customer Insights in Dynamics 365 for Marketing"
keywords: "administration; landing page; Customer Insights"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4b69ec65-17f9-4a51-a1f2-abdeca4533aa
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Marketing settings

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The **Marketing settings** section contains pages that let you configure the core marketing functionality for landing pages, email marketing, and [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)].

To find these settings, open **Settings** > **Advanced settings** and choose one of the pages under the **Marketing settings** heading in the leftmost column. You can also access these same settings by finding the **Marketing settings** section in the rightmost column and choosing the icons there.

See the remaining sections of this topic for information about how to work with each page in the **Marketing settings** section.

<a name="config-mkt-pages"></a>

## Configure landing pages

Use the **Settings** > **Advanced settings** > **Marketing settings** > **Landing pages** page to set up a privacy banner, set hosting defaults, and configure defaults for how data submitted through a landing page form is matched to existing contact or lead records.

When you first arrive at **Settings** > **Advanced settings** > **Marketing settings** > **Landing pages**, you'll see a list of all existing marketing-page configuration sets. This is a standard list page, where you can view, sort, search, and filter the list to find a specific record, and use the command bar buttons provided to add or remove a record. Select any configuration set in the list to open, view, and edit it.

![The Marketing Page Configuration page](media/marketing-page-config.png "The Marketing Page Configuration page")

### Set the default (active) configuration set

You can set up as many configuration sets as you want, but only one can be active at a time. To change the active configuration set, find and open the set you want to activate in the landing-page configuration list, and then set its **Default** field to **Yes**; the existing default configuration will lose its default status.

There must always be exactly one landing-page configuration that is set as the default.

### Set up a privacy banner for landing pages

We recommend that you include a privacy banner on all your landing pages. This will let your customers know that you take their privacy seriously and might also be required in some jurisdictions. Use the following settings in the **Privacy banner** section to create and enable your privacy banner:

- **Insert privacy banner**: Choose **Yes** to enable this feature; choose **No** to disable it. When the privacy banner is enabled, the text and link defined in the other settings in this section will be added to each new marketing page that you create. The banner will also be added to any existing page that you open for editing; however, it won't be added to pages that are already published because these are read-only.
- **Privacy banner text**: Enter a summary of your privacy policy here.
- **Privacy policy link URL**: We recommend that you provide a detailed privacy policy somewhere on your own organization's website. If you have such a page, enter its full URL here.
- **Privacy policy link text**: This text is placed under the **Privacy banner text**, and creates a link to the **Privacy policy link URL** you specified. Enter a short string of text that tells users what to expect, such as "Click here to read our complete privacy policy."


### Configure how incoming form data is matched to existing records

Most of your landing pages will include an input form that visitors can use to sign up for an offer, event, or mailing list by entering their name, email address, and other information. When a visitor submits a form, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] accepts the submitted values and checks to see whether it should update an existing record or create a new one.

The **Contact creation context capture** and **Lead creation context capture** sections show where various types of information about the marketing context are stored when a submission results in a new contact or lead record. Here you can see which fields in the contact or lead entity store each type of context information.

Use the **Default matching strategy** section to set defaults for which types of entities your landing pages will create and update (leads and/or contacts), and how incoming values are matched against existing records to decide whether to create a new record or update an existing one. These defaults will be applied to each new landing page that you create, and they are saved with the page, so you can overrule them at the page level by changing them there. Changing these settings won't affect any existing pages. The following settings are available:

- **Update contacts/leads:** When a landing page submission is received, this setting establishes which types of records it can create or update: leads, contacts, or both.
- **Default contact matching strategy:** Shows the name of the field-matching strategy that you have set up to match incoming data against existing contact records. If a match is found according to this strategy, it will update that record. If no match is found, it will create a new contact. You can choose from among existing strategies here, or select **New** to create a new one. See the next section for information about how to set up your field-matching strategies.
- **Default lead matching strategy:** Same as the **Default contact matching strategy** setting, but for lead records.

### Set matching strategies for leads and contacts

Matching strategies define how page submissions are matched to existing contacts or leads when deciding whether to update an existing record or to create a new one.

For example, a simple contact-matching strategy might be based on email address alone. When a submission is received, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] will check whether any existing contact has the submitted email address. If a match is found, the submission is used to update that contact; if no match is found, a new contact is created with the received values.

To view or set a matching strategy, open your marketing page configuration, and then select **Default contact matching strategy** or **Default lead matching strategy**. For more information about how to create and edit matching strategies, see [Matching strategy](#matching-strategy).

### Set portal defaults

Settings on the **Portal defaults** tab control how your marketing pages are hosted in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. The following settings are available:

- **Website**: Identifies the portal website where all new marketing pages will be published while the current configuration record is active. This defaults to the event portal that was provisioned for you when you signed up for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], but you can choose another if you have one. If you change this, pages that you've already published will remain on their current portal, but new pages will go to the new portal.
- **Page language**: Sets the default language to use in the portal.
- **Container page**: Sets the container page used for marketing pages.

<a name="dci-sync"></a>

## Choose entities to sync with Customer Insights

[!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] is an [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)]-based service that provides analytical tools for working with customer records. It helps you to better understand your customers, and enables you to set up subscription lists and target segments for use in email-marketing campaigns.

The analytical and data-crunching capabilities of [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] are very powerful, but also resource-intensive, so the solution maximizes performance by synchronizing the relevant customer and account data between [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)].

Use the **Settings** > **Advanced settings** > **Marketing settings** > **[!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] Sync** page to choose which database entities from [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to replicate to [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)]. For optimal performance and functionality, choose only the entities you need—no more and no less.

> [!IMPORTANT]
> Once you add a new entity to [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)], it will continue to sync and  consume storage space there and can't be removed again. You should only add those entities you are sure you will need.

Select the check box for each entity you want to sync. If you can't see the entity you want, try using the search field to find it.

<a name="matching-strategy"></a>

## Set matching strategies

Use the **Settings** > **Advanced settings** > **Marketing settings** > **Matching strategy** page to set up various strategies for matching incoming landing-page submissions to existing leads and contacts. These are the strategies  you can choose when setting up marketing pages and the marketing-page defaults.

The first page you see shows a list of existing strategies. From here, you can choose an existing strategy to view, edit or delete it, or choose **+ New** on the command bar to create a new one.

![Setting the matching strategy](media/marketing-page-matching.png "Setting the matching strategy")

Describe your strategy by entering a **Name** and **Description**. Set the **Target** field to the type of entity your strategy applies to (lead or contact).

The input field under the **Target** setting specifies which contact or lead fields to consider when looking for a match. The matching record must have identical values for *all* the fields shown here, so the more fields you use, the narrower your search will be. Often the email address alone is enough to use as a unique identifier, but you might use additional fields (such as first and last name) if you think some of your contacts might share an email address, or if you want tighter control (at the risk of creating extra contact or lead records that refer to the same person). Enter a comma-separated list of fields to consider, and include square brackets around the list and quotes around each field name, such as:

> `["emailaddress1", "msdyncrm_marketingpageid"]`

<a name="default-marketing-settings"></a>

## Default marketing settings

Use the **Settings** > **Advanced Settings** > **Marketing settings** > **Default marketing settings** page to establish collections of settings that establish various defaults used throughout the app. You can store as many settings sets as you want, but only the one marked as **Default** is active. 

Choose an existing configuration to edit or delete it, or choose **+ New** from the command bar to create a new one.

### The General tab

Make the following settings here:

- **Name**: The name of the default-settings set, as shown on the list page.
- **Owner**: The user that owns the set.
- **Default**: Set to **Yes** to activate the current default-settings set on your site.

### The Marketing email tab

Use the **Marketing email** tab to set defaults that apply to your marketing email messages. You will always be able to override these defaults for individual messages, but it will be more convenient for users if you set the defaults to their most-used values. The following settings are available:

- **Default content settings**: Choose a default content-settings record for providing dynamic values for the preview feature of the marketing-email designer. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use content settings to set up repositories of standard and required values for email messages](#use-content-settings-to-set-up-repositories-of-standard-and-required-values-for-email-messages)
- **Default contact**: Choose a default contact record for providing dynamic values for the preview feature of the marketing-email designer.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Check your work with previews and test sends](#check-your-work-with-previews-and-test-sends)

### The Customer journey tab

Use the **Customer journey** tab to choose the default timezone that you will use when starting and stopping your customer journeys

## Data protection tools

Use the **Settings** > **Advanced Settings** > **Marketing settings** > **Data protection tools** page to enable data-privacy features of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. These currently focus on helping organizations comply with the GDPR regulations in the European Union. For more information about GDPR, including how to use the settings here, see [Data protection and GDPR ](data-protection.md).

<a name="marketing-configuration"></a>

## Enable Litmus inbox previews

The  [inbox preview feature](prepare-marketing-emails.md#inbox-preview) provides pixel-perfect renderings of how your email messages will look on specific client and platform combinations. The feature is provided by a [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] partner called Litmus Software, Inc. ([litmus.com](https://litmus.com/)), and is optional. To use the feature, you must enable it for your site as described in this section.

In a future version of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], we expect to provide settings to enable Litmus previews somewhere under **Settings** > **Advanced Settings** > **Marketing settings**, but for the current version you must use the [!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)] app to enable the feature.

To enable Litmus previews:

1. Go to the custom app by choosing **[!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)]** from the app-selector menu.  
    ![The app-selector menu](media/nav-apps-custom-ill.png "The app-selector menu")

1. The custom app opens. Select the **Advanced find** button ![The Advanced find button](media/advanced-find-button.png "The Advanced find button") in the navigation bar at the top of the page.

1. The **Advanced find** window opens. Open the **Look for** drop-down list and select **Marketing configurations**. Then select the **Results** button.  
    ![The advanced find window](media/find-marketing-configurations.png "The advanced find window")

1. The **Advanced find** window updates to show your marketing configurations. There should be just one, called **Default Marketing Configuration**. Select it from the list.

1. Another pop-up window opens showing your default marketing configuration. Set **Enable Litmus integration** to **Yes** to enable the feature here. (Set it to **No** to disable it if needed.)

1. Select the save icon in the bottom-right corner of the window to save your setting (it should also auto save after a few seconds).


### See also

[Create and deploy marketing pages](create-deploy-marketing-pages.md)  
[Check your work with previews and test sends](prepare-marketing-emails.md#check-your-work-by-using-previews-and-test-sends)
