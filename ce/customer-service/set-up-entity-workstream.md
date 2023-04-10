---
title: "Set up workstream for records in Omnichannel Administration | MicrosoftDocs"
description: "Perform the steps mentioned in the topic to set up record workstream in Omnichannel for Customer Service."
ms.date: 04/04/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Create workstreams for record routing in Omnichannel Administration

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
>
> - Support for the Omnichannel Administration app ended on April 30, 2022. We recommend that you use the Omnichannel admin center or Customer Service admin center app to configure the latest features, such as unified routing and voice channel. For more information about the deprecation announcement, see [Omnichannel Administration app is deprecated](../customer-service/deprecations-customer-service.md#omnichannel-administration-app-is-deprecated).
> - You can no longer configure record routing in the Omnichannel Administration app because it will not work as expected. If you have existing workstreams for routing records, you'll need to recreate them in the Customer Service admin center or Omnichannel admin center app. More information: [Migrate workstreams for routing records](migrate-workstreams.md#migrate-workstreams-for-routing-records)

## Create a record workstream

To route records, as a first step, you need to enable entity for routing using entity records channel configuration. To learn more [Entity records routing](entity-channel.md).

This topic describes how to create a work stream for an entity that has been enabled for routing.

1. Sign in to the Omnichannel Administration app.

2. Select **Work Streams** under **Channels** in the site map.

3. Select **New** in the **Active Work Streams** page.

4. Specify the following in the **New Work Stream** page.

    | Tab | Field | Value | Description |
    |---------------------|-----------------------------|-------------------------------------------|-------------------------------------------------|
    | Work Distribution | Name | Case Work stream | Provide a name to the work stream. <br> **Note:** The value provided is an example.  |
    | Work Distribution | Channel | Entity Records | Select the **Entity Records** channel from the list.|
    | Work Distribution | Entity | Case | Select an entity from the drop-down menu. <br> If you want to create a entity, select **+ New**. To learn more, see [Enable entity for routing](enable-entities-for-queues.md). |
    | Work Distribution | Capacity | 50 |Specify the units of capacity that are required to process a conversation for the work stream in the text box. <br> **Note:** <ul><li> The value provided is an example. </li></ul> |
    | Work Distribution | Work distribution mode | Push | Select **Push** when you want to automatically route the cases to the agents. <br><br> Select **Pick** when you want the agents to explicitly pick a conversation from the **Open work items** in agent dashboard. |
    | Work Distribution | Allowed presences | Allowed, Busy | Set the allowed presence status <br><br> Select the option and type a presence status in the search box. Select a status from the list. <br> **Note:** <ul><li> The value provided is an example. </li></ul>|

    > [!div class=mx-imgBorder] 
    > ![Specify values for the fields.](media/case-ws3.png "New case work stream")

5. Select **Save** to save the work stream.

> [!Note]
> When you enable an entity for routing, the Omnichannel Administration app creates a default workstream for the entity. If you create a new work stream or update the default work stream according to your business scenario, you need to update the work stream information in **Entity Records distribution Flow**. To learn more, see [Update entity records work distribution flow](multiple-ws-entity-record-routing.md#update-entity-records-work-distribution-flow).

## Upgrade path for preview users

If you are upgrading to the latest version from a preview version, then earlier configured work streams will be obsolete. You need to create a new entity records channel and then redefine the workstreams.

## See also

[Entity records routing](entity-channel.md)

[Understand and create work streams](work-streams-introduction.md)

[Create multiple work streams for entity records routing](multiple-ws-entity-record-routing.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
