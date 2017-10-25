---
title: "Configure core marketing functionality in Dynamics 365 for Marketing | Microsoft Docs"
description: "Use the marketing settings to configure landing pages, email marketing, and Customer Insights in Dynamics 365 for Marketing"
keywords: "administration; landing page; Customer Insights"
author: kamaybac
ms.author: kamaybac
manager: sakudes
applies_to: 
- Dynamics 365 (online)
- Dynamics 365 Version 9.x
ms.date: 10/20/2017
ms.service: crm-online
ms.topic: article
ms.assetid: 4b69ec65-17f9-4a51-a1f2-abdeca4533aa
ms.reviewer: renwe
---
# Marketing settings

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The **Marketing Settings** page lets you configure the core marketing functionality for landing pages, email marketing, and [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)].

To find these settings, open **Advanced Settings** and choose one of the pages under the **Marketing Settings** heading in the leftmost column. You can also access these same settings by finding the **Marketing Settings** section in the rightmost column and choosing the icons there.

See the remaining sections of this topic for information about how to work with each page in the **Marketing Settings** section.

## Landing pages settings

Use the **Settings** > **Marketing Settings** > **Landing Page** page to set up a privacy banner, set hosting defaults, and configure defaults for how data submitted through a landing page form is matched to existing contact or lead records.

When you first arrive at **Settings** > **Marketing Settings** > **Landing Page**, you'll see a list of all existing landing-page configuration sets. This is a standard list page, where you can view, sort, search, and filter the list to find a specific record, and use the command bar buttons provided to add or remove a record. Select any configuration set in the list to open, view, and edit it.

![The Marketing Page Configuration page](media/marketing-page-config.png "The Marketing Page Configuration page")

### Set the default (active) configuration set

You can set up as many configuration sets as you want, but only one can be active at a time. To change the active configuration set, find and open the set you want to activate in the landing-page configuration list, and then set its **Default** field to **Yes**; the existing default configuration will lose its default status.

There must always be exactly one landing-page configuration that is set as the default.

### Set up a privacy banner for landing pages

We recommend that you include a privacy banner on all your landing pages. This will let your customers know that you take their privacy seriously and may also be required in some jurisdictions. Use the following settings in the **Privacy Banner** section to create and enable your privacy banner:

- **Include privacy banner**: Choose **Yes** to enable this feature; choose **No** to disable it. When the privacy banner is enabled, the text and link defined in the other settings in this section will be added to each new marketing page that you create. The banner will also be added to any existing page that you open for editing; however, it won't be added to pages that are already published because these are read-only.
- **Privacy banner text**: Enter a summary of your privacy policy here.
- **Privacy policy URL**: We recommend that you provide a detailed privacy policy somewhere on your own organization's website. If you have such a page, enter its full URL here.
- **Privacy policy link text**: This text is placed under the **Privacy banner text**, and creates a link to the **Privacy policy URL** you specified. Enter a short string of text that tells users what to expect, such as "Click here to read our complete privacy policy."

### Set hosting defaults

Settings in the **Hosting Defaults** section control how your landing pages are hosted in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. The following settings are available:

- **Portal**: Identifies the portal website where all new marketing pages will be published while the current configuration record is active. This defaults to the portal that was provisioned for you when you signed up for [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], but you can choose another if you have one. If you change this, pages that you've already published will remain on their current portal, but new pages will go to the new portal.
- **Default Language**: Sets the default language to use in the portal.

### Configure how incoming form data is matched to existing records

Most of your landing pages will include an input form that visitors can use to sign up for an offer, event, or mailing list by entering their name, email address, and other information. When a visitor submits a form, [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] accepts the submitted values and checks to see whether it should update an existing record or create a new one.

The **Contact Creation Context Capture** and **Lead Creation Context Capture** sections show where various types of information about the marketing context are stored when a submission results in a new contact or lead record. Here you can see which fields in the contact or lead entity store each type of context information.

Use the **Default Matching Strategy** section to set defaults for which types of entities your landing pages will create and update (leads and/or contacts), and how incoming values are matched against existing records to decide whether to create a new record or update an existing one. These defaults will be applied to each new landing page that you create, and they are saved with the page, so you can overrule them at the page level by changing them there. Changing these settings won't affect any existing pages. The following settings are available:

- **Update Contacts/Leads:** When a landing page submission is received, this setting establishes which types of records it can create or update: leads, contacts, or both.
- **Default contact matching strategy:** Shows the name of the field-matching strategy that you have set up to match incoming data against existing contact records. If a match is found according to this strategy, it will update that record. If no match is found, it will create a new contact. You can choose from among existing strategies here, or select **New** to create a new one. See the next section for information about how to set up your field-matching strategies.
- **Default lead matching strategy:** Same as the **Default contact matching strategy** setting, but for lead records.

### Set matching strategies for leads and contacts

Matching strategies define how page submissions are matched to existing contacts or leads when deciding whether to update an existing record or to create a new one.

For example, a simple contact-matching strategy might be based on email address alone. When a submission is received, [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] will check whether any existing contact has the submitted email address. If a match is found, the submission is used to update that contact; if no match is found, a new contact is created with the received values.

To view or set a matching strategy, open your marketing page configuration, and then select **Default contact matching strategy** or **Default lead matching strategy**.

![Setting the matching strategy](media/marketing-page-matching.png "Setting the matching strategy")

Describe your strategy by entering a **Name** and **Description**. The **Target** field is read-only and tells which type of entity your strategy applies to (lead or contact).

The input field under the **Target** setting specifies which contact or lead fields to consider when looking for a match. The matching record must have identical values for *all* the fields shown here, so the more fields you use, the narrower your search will be. Often the email address alone is enough to use as a unique identifier, but you might use additional fields (such as first and last name) if you think some of your contacts might share an email address, or if you want tighter control (at the risk of creating extra contact or lead records that refer to the same person). Enter a comma-separated list of fields to consider, and include square brackets around the list and quotes around each field name, such as:

> `["emailaddress1", "msdyncrm_marketingpageid"]`

## Email

Use the **Settings** > **Marketing Settings** > **Email** page to set a few optional defaults that apply to your marketing email messages. You will always be able to override these defaults for individual messages, but it will be more convenient for users if you set the defaults to their most-used values. The following settings are available:

- **Default Test Contact**: Choose a default contact record for providing dynamic values for the preview feature of the marketing-email designer.
- **Default Content Settings**: Choose a default content-settings record for providing dynamic values for the preview feature of the marketing-email designer. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use content settings to set up repositories of standard and required values for email messages](#use-content-settings-to-set-up-repositories-of-standard-and-required-values-for-email-messages)

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Check your work with previews and test sends](#check-your-work-with-previews-and-test-sends)

## Customer Insights sync

[!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] is an [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)]-based service that provides analytical tools for working with customer records. It helps you to better understand your customers, and enables you to set up subscription lists and target segments for use in email-marketing campaigns.

The analytical and data-crunching capabilities of [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] are very powerful, but also resource-intensive, so the solution maximizes performance by synchronizing the relevant customer and account data between [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)].

Use the **Settings** > **Marketing Settings** > **[!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] Sync** page to choose which database entities from [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] to replicate to [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)]. For optimal performance and functionality, choose only the entities you need—no more and no less.

Select the check box for each entity you want to sync. If you can't see the entity you want, try using the search field to find it.
