---
title: "Create segments and lists to establish target markets in Dynamics 365 for Marketing | Microsoft Docs"
description: "How to create segments and lists that you can use to target customer journeys and manage subscriptions in Dynamics 365 for Marketing"
keywords: "segment; marketing list; subscription; Customer Insights"
author: kamaybac
ms.author: kamaybac
manager: sakudes
applies_to: 
- Dynamics 365 (online)
- Dynamics 365 Version 9.x
ms.date: 10/20/2017
ms.service: crm-online
ms.topic: article
ms.assetid: 2ff81085-af7a-455b-857a-0aa0ade61416
ms.reviewer: renwe
---
# Market segmentation, marketing lists, and subscription lists

This topic explains how to define your various target groups by setting up segments and lists. Each list or segment represents a collection of contacts that you can use to target a customer journey. You'll also use marketing lists in your subscription center to enable contacts to manually opt-in or opt-out of various types of newsletters and other marketing communications.

## Segments in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

A market segment is the collection of contacts that you target in a marketing campaign. In some cases, you'll simply target all the contacts you have, but in most cases, you'll choose who you want to target based on demographic or firmographic data and other considerations. For example, if you're opening a new store in San Francisco, you'll probably promote the opening-day event at that store only to contacts who live near San Francisco. Or if you are running a sale on dresses, you might only send related marketing email messages to your contacts who are female. Decisions like these will typically also affect the way you communicate with the segment in terms of which channels you'll choose, what kind of graphics you'll pick, which kinds of arguments you make, and more.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses segments in two important ways:

- **Customer journeys**: Most customer journeys start with a segment tile, which establishes the collection of contacts who will experience that journey. You can combine multiple segments here.
- **Subscription lists**: Subscription lists are static lists that contacts can add themselves to (or remove themselves from) by using a subscription center.

Segments can be dynamic, static, or compound.

- *Dynamics segments* are set up by using logical expressions, such as "all contacts from New York" or "all contacts who like The Mets." Membership in dynamic segments changes constantly to reflect new or removed contacts and updated contact information.
- *Static segments* establish a static list of contacts that are selected on a per-contact basis rather than created logically based on field values. Marketing and sales people might create and populate a static list based on private knowledge or offline interactions. Contacts can add or remove themselves from static segments by using a subscription center, which provides a list of available mailing lists (each of which is a static segment). In [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you'll base your static segments on lists created by using the marketing lists feature; more on this later.
- *Compound segments* combine static and dynamic criteria. They contain all contacts who match the dynamic criteria, plus all contacts added explicitly (as to a static list).

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] works together with another product called *[!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)]* to provide advanced segment definitions and customer analytics. The integration is seamless and results in powerful combined functionality when the two systems work together. Your contact records and marketing lists are continuously synchronized between the two systems, which lets [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] apply its powerful data processing and analytical tools to your contacts, and combine these with information from other types of [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] records and information from other systems. You can also access [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] directly to make use of its additional analytical tools and other features. For more information, see the [Customer Insights online help](https://docs.microsoft.com/dynamics365/customer-insights/deploy/overview).

## View, create, and manage your segments

To work with your segments, go to **Marketing** &gt; **Customers** &gt; **Segments**. This opens a standard list view, which you can use to search, sort, filter, create, and delete your segments. Open any segment to view its details.

![The General tab for segments](media/segment-general.png "The General tab for segments")

Segment records provide several tabs for describing, defining, and reviewing the segment. Tabs are shown as a set of headings under the header, which shows the name of the segment. Select any of these headings to go to the relevant tab. Each tab is described briefly in the following subsections.

### The General tab

The **General** tab provides general information about the segment, including:

- **Name**: Enter a name that will make the segment easy for you and others to identify while working in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)].
- **Segment Type**: Set the segment to dynamic, marketing list, or compound. Dynamics segments are populated logically, based on a query you create on the **Definition** tab. Marketing lists (also called "static lists") are populated by choosing individual members, and are also used to create subscription lists on subscription centers, where contacts can add or remove themselves. Compound segments combine static and dynamic criteria.
- **Activation Status**: Enable or disable the segment. Only enabled segments are available for use elsewhere in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. You might disable a segment if you don't need it anymore, or to keep people from using it until you have finished developing it.

### The Definition tab

Use the **Definition** tab to establish membership of the segment. For dynamic segments, you'll get a query builder here. For marketing lists, you'll be able to choose from lists created in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] and synchronized to [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)].

### The Members tab

The **Members** tab shows all the contacts who are members of the current list as a result of the query set up on the **Definition** tab.

### The [!INCLUDE[pn-insights](../includes/pn-insights.md)] tab

Provides analytics for your segment.

### The Related tab

This is actually a drop-down list that you can use to find other types of records (such as customer journeys) that use or reference the current segment. When you choose an entity name here, a new tab named for that entity opens, showing a list of all found records. The **Related** tab remains available, and you can still use it to find other types of records that reference the current segment.

## Set up marketing lists for use with static segments and subscription centers

As mentioned earlier in this topic, static segments are populated by adding contacts explicitly, one at a time, rather than by establishing logical rules (such as "all contacts from North Carolina"). This is especially important for creating lists for use in subscription centers, where contacts can add or remove themselves from each subscription list. But you could also create and populate static lists for other uses.

Use the marketing lists feature to set up a static list, which the system will automatically synchronize with [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)]. After you've set up the marketing list, you'll be able to use it to create your static or compound segments for use in customer journeys.

To set up a marketing list:

1. Go to **Marketing** &gt; **Customers** &gt; **Marketing Lists**.

1. Use the standard list controls to find and select an existing marketing list, or select **New** to create a new one.

1. Make the following settings:

    - **Name**: Identifies the mailing list within [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. Choose a name that you and others will recognize.
    - **Subscription**: Set to True if you are planning to use the current list as a subscription list for a subscription center. Later, when you're setting up a subscription center, you'll only be able to add lists where Subscription is True. Set this to False if you're creating a static list for use with customer journeys only.
    - **List Type**: When creating lists for use in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you'll almost always set this to Static. (Other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps can also use dynamic marketing lists, but [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] for this to provide more power and flexibility.)
    - **Targeted At**: When creating lists for use in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you'll almost always set this to Contact. (Other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps can also use marketing lists of leads or accounts, but those aren't useful in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].)

    Other settings are available, but optional. Fill them out if you'd like to provide more information about the list.

1. Select **Save** to save your list.