---
title: "Design dynamic profile segments in the standard view (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to use the standard view to construct segments in Dynamics 365 for Marketing"
keywords: segment; compound segment
ms.date: 09/17/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 6620a363-8996-4d94-bbbe-fb5bffaf1ceb
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

# Design profile-based dynamic segments

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

The segmentation tool always works in one of two modes, which enable it to create either of the following two types of segments:

- **Profile segments** query the _profile_ records stored in the customer-interaction database. Profiles records are synced between your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] database and the customer-interaction database and include the entities you normally work with in the [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] UI, such as contacts, accounts, leads, and any other entities that you [choose to sync](marketing-settings.md#dci-sync).

- **Interaction segments** query the _interaction_ records stored in the customer-interaction database. Each of these records is generated automatically and related to a specific contact record. Interaction records are accessed to generate various insights displays in the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] UI, but they _aren't_ synced to the [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] database. They are generated in response to contact interactions such as opening an email, clicking an email link, submitting a form, or registering for an event.

This topic describes how to work with profile segments. For more about interaction segments, see [Design interaction-based dynamic segments](segments-interaction.md).

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Working with segments](segmentation-lists-subscriptions.md)

## Set up a new dynamic segment

To create a dynamic segment, set its **Segment type** to **Dynamic** on the **General** tab. Then use the **Definition** tab to build your dynamic segment by combing _groups_ of _logical expressions_, each of which results in a set of contacts. Each group establishes a _path_ through one or more entities that must end at the **Contact** entity (the order matters).

> [!NOTE]
> Your dynamic-segment queries can reference fields of all data types _other than multiple option set_. The **Designer** and **Explorer** won't show data fields of this type.

## Define a segment group

Each group in your segment must result in a list of contacts, which are selected by the logic defined in that group. Each group must therefore establish a path through various entities, each linked through relations, and which ends with the contact entity. A simple query group might query the contact entity alone, but a more complex one could pass through several entities.

> [!NOTE]
> While you are designing your segment, you can select the **Get estimated segment size** link to get an *estimate* for the number of contacts that will be included in the segment. This is only an estimate, and can be somewhat different from your actual segment size. You must go live with the segment to view its exact size and membership.

### Example: Define a simple segment based on contacts

A simple segment group uses the contact entity only. When you create this type of segment definition, set up a query with clauses that test various field values from your contact records and combine the various clauses using the logical operators AND and OR. For an example, see the tutorial [Create a dynamic segment](create-segment.md).

### Example: Define a more complex segment based on opportunities

Here's an example of how to define a segment that starts by finding a collection of opportunities and, as usual, ends by finding the contacts that belong to that segment. In this example, we'll find contacts associated with opportunities with an estimated revenue over $10,000 and then build a relation to the contacts entity.

1. If your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] instance isn't already set up to sync opportunities with the customer-insights services, talk to your admin about setting this up. If you are the admin, then see [Choose entities to sync with the customer-insights services](marketing-settings.md#dci-sync) for instructions.

1. Go to **Marketing** > **Customers** > **Segments** and select **+ New** from the command bar. A new segment record opens with the **Definition** > **Designer** tab showing.  
    ![Close the default group](media/segment-opportunity-close-group.png "Close the default group")

    Do the following:

    - Enter a **Name** for the segment at the top of the page.
    - Select the close button to remove the default contact group from the **Designer** area. Many of your segments will probably start and end with the contact entity, but for this example we will start with opportunities instead.

1. When default contact group closes, it's replaced by a **Select a profile or relationship** drop-down list. Select **Opportunity** from here. (If you don't see the **Opportunity** entity listed here, then you probably need to set up syncing for this entity as described in the first step of this procedure; note that it can take up to half an hour for a new entity to appear in this list after the first sync.)  
    ![Select the waitlist-item entity](media/segment-opportunity-choose-entity.png "Select the waitlist-item entity")

1. Complete the row to create the logical expression:  
    **Opportunity | Est. Revenue | &ge; | 10000**.  
    ![Start with the opportunity entity](media/segment-example-opportunity1.png "Start with the opportunity entity")

1. Select **+And** to add a new clause to the group. Now you must choose the relation between the opportunity entity and the contact entity, which is where we need to end up. Choose **Opportunity -> Contact (Contact)** and leave it set it to match **All&#42;**.
    ![Set the relation from opportunity to contact](media/segment-example-opportunity2.png "Set the relation from opportunity to contact")

1. Select **+And** to add a final clause to the group, which must end with the contact entity. Set the new clause to use the **Contact** entity and leave it set it to match **All&#42;** to find all contacts associated with the selected opportunities.  
    ![Finish the path to the contact entity](media/segment-example-opportunity3.png "Finish the path to the contact entity")

1. Select **Save** and then **Go live** on the command bar.

1. Your segment is now live and will now find contacts associated with opportunities valued over $10,000.

## Combine segment groups

A simple segment might have just one group, but you can create and combine as many groups as needed. As a result, you can create highly sophisticated queries.

You combine groups, working first group to last, by using the following operators:

- **Union**: combines all members of a group with the results of the previous group.
- **Exclude**: removes members of a group from the results of the previous group.
- **Intersect**: removes all members from the previous group that are not also members of the current group.

When you're working on the **Designer** tab, use the **+ Add Group** button to add a group and choose its operator.

The **Flow** tab provides another view of how your groups are combined. Here, you get a Sankey diagram of how your groups are combined, and how contacts flow into and out of the segment as a result of the operation from each group.

![Sankey diagram on the Flow tab](media/segment-sankey-example.png "Sankey diagram on the Flow tab")

You can also add new groups while working on the **Flow** tab, which provides the same **Explore** view described previously for defining the group.

### See also

[Working with segments](segmentation-lists-subscriptions.md)
