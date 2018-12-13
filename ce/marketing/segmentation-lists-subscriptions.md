---
title: "Create segments and lists to establish target markets (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to create segments and lists that you can use to target customer journeys and manage subscriptions in Dynamics 365 for Marketing"
keywords: "segment; marketing list; subscription; Customer Insights"
ms.date: 09/17/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 Version 9.x
ms.assetid: 2ff81085-af7a-455b-857a-0aa0ade61416
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Working with segments

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

You can define your various target groups by setting up segments and lists. Each list or segment represents a collection of contacts that you can use to target a customer journey. You'll also use marketing lists in your subscription center to enable contacts to manually opt-in or opt-out of various types of newsletters and other marketing communications.

## Segments in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

A market segment is the collection of contacts that you target in a marketing campaign. In some cases, you'll simply target all the contacts you have, but in most cases, you'll choose who you want to target based on demographic or firmographic data and other considerations. For example, if you're opening a new store in San Francisco, you'll probably promote the opening-day event at that store only to contacts who live near San Francisco. Or if you're running a sale on dresses, you might only send related marketing email messages to your contacts who are female. Decisions like these will typically also affect the way you communicate with the segment in terms of which channels you'll choose, what kind of graphics you'll pick, which kinds of arguments you make, and more.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses segments to target customer journeys. Most customer journeys start with a segment tile, which establishes the collection of contacts who will experience that journey. You can combine multiple segments here.

### Types of segments

Segments can be dynamic, static, or compound.

- *Dynamic segments* are set up by using logical expressions, such as "all contacts from New York" or "all contacts who like The Mets." Membership in dynamic segments changes constantly to reflect new or removed contacts and updated contact information.
- *Static segments* establish a static list of contacts who are selected on a per-contact basis rather than created logically based on field values. Marketers and salespeople might create and populate a static list based on private knowledge or offline interactions.
- *Compound segments* combine existing (live) segments using logical operators.

Segments can also be based either on profiles or interactions.

- *Profile segments* query the _profile_ records stored in the customer-interaction database. Profiles records are synced between your Dynamics 365 database and the customer-interaction database and include the entities you normally work with in the Dynamics 365 UI, such as contacts, accounts, leads, and any other entities that you [choose to sync](marketing-settings.md#matching-strategy).
- *Interaction segments* query the _interaction_ records stored in the customer-interaction database. Each of these records is generated automatically and related to a specific contact record. Interaction records are accessed to generate various insights displays in the Dynamics 365 UI, but they _aren't_ synced to the Dynamics 365 database. They are generated in response to contact interactions such as opening an email, clicking an email link, submitting a form, or registering for an event.

### Segments are synced with the customer-insights services

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] works together with a set of external customer-insights services that operate using their own, external, customer-interaction database to provide advanced segment definitions and customer analytics. The integration is seamless and results in powerful combined functionality when the two systems work together. Your contact records and marketing lists are continuously synchronized between the two systems, which lets the customer-insights services apply their powerful data processing and analytical tools to your contacts, and combine these with information from other types of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] records and information from other systems.

> [!IMPORTANT]
> The customer-insights services process changes to segment membership asynchronously, which means you can't predict the order in which changes are processed. In some cases, such as when processing very large databases, it can take up to six hours for a given segment to get updated. You therefore can't rely on any one segment being processed before or after a specific other segment, so be careful when orchestrating related campaigns and/or using  [suppression segments](customer-journeys-create-automated-campaigns.md#suppression-segment).

### Segments must be live before you can use them

When you first create a new segment, it is in a _draft_ state, which means that it is unlocked, so you can work with its definition and other settings, but you won't be able to use it in customer journeys or compound segments. When you are ready to use your segment, you must open it and select **Go Live** from the command bar, which enables it and moves to the _live_ state.

> [!IMPORTANT]
> While you are designing your segment, you can select the **Get estimated segment size** link to get an *estimate* for the number of contacts that will be included in the segment. This is only an estimate, and can be somewhat different from your actual segment size. You must go live with the segment to view its exact size and membership.

If you need to edit a segment after it has gone live, open it and then select **Stop** from the command bar to put it back into the draft state.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Go live with publishable entities and track their status](go-live.md)

## View, create, and manage your segments

To work with your segments, go to **Marketing** &gt; **Customers** &gt; **Segments**. This opens a standard list view, which you can use to search, sort, filter, create, and delete your segments. Open any segment to view its details, or select **New** to create a new one.

![The General tab for segments](media/segment-general.png "The General tab for segments")

Segment records provide several tabs for describing, defining, and reviewing the segment. Tabs are shown as a set of headings under the header, which shows the name of the segment. Select any of these headings to go to the relevant tab. Each tab is described briefly in the following subsections.

### The General tab

The **General** tab provides general information about the segment, including:

- **Name**: Enter a name that will make the segment easy for you and others to identify while working in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].
- **Segment Type**: Set the segment to dynamic, static, or compound. This setting controls which types of settings you'll see for populating the list on the **Definition** tab.
- **Status reason**: Shows whether the segment is draft or live. Only live segments are available for use in customer journeys and compound segments.

### The Definition tab

Use the **Definition** tab to establish membership of the segment. For dynamic segments, you'll get a query builder here. For static segments, you'll select specific contacts one at a time. For compound segments, you'll create logic for combining existing segments here. For more information about how to build your segment definition using this tab, see the following topics:

- [Design profile-based dynamic segments](segments-profile.md)
- [Use the explore view](segments-explorer.md)
- [Design interaction-based dynamic segments](segments-interaction.md)
- [Define a static segment](segments-static.md)
- [Combine segments into a compound segment](segments-compound.md)

### The Related tab

This is actually a drop-down list that you can use to find other types of records (such as customer journeys) that use or reference the current segment. When you choose an entity name here, a new tab named for that entity opens, showing a list of all found records. The **Related** tab remains available, and you can still use it to find other types of records that reference the current segment.

## Set up marketing lists for use with subscription centers

Subscription lists enable contacts to add or remove themselves from a static marketing list, which you can then use to create a segment that targets members of that list, for example to deliver a monthly newsletter.

To set up a subscription list, you must use the [!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)] app to create the static marketing list and mark it as a subscription list. Then you'll be able to set up a segment tile in a customer journey to use that list as a target segment. Lists marked as subscription lists are also available for use on your subscription centers, but static segments are not.

For details about how to create marketing lists and use them in subscription centers and segment tiles, see [Set up subscription lists and subscription centers](set-up-subscription-center.md).

### See also

[Create a segment](create-segment.md)  
[Set up subscription lists and subscription centers](set-up-subscription-center.md)  
[Go live with publishable entities and track their status](go-live.md)
