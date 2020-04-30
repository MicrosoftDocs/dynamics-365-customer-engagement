---
title: "Set up entity work stream | MicrosoftDocs"
description: "Learn how to set up entity work stream in the Omnichannel for Customer Service."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Create workstream for entity record routing

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Create entity record workstream

To route entity records, as a first step, you need to enable entity for routing using entity records channel configuration. To learn more [Entity records routing](entity-channel.md).

This topic describes how to create a workstream for an entity that has been enabled for routing.

1. Sign in to the Omnichannel Administration app.

2. Select **Work Streams** under **Channels** in the sitemap.

3. Select **+ New** in the **Active Work Streams** page.

4. Specify the following in the **New Work Stream** page.

    | Tab | Field | Value | Description | 
    |---------------------|-----------------------------|-------------------------------------------|-------------------------------------------------|
    | Work Distribution | Name | Case Workstream | Provide a name to the workstream. <br> **Note:** The value provided is an example.  |
    | Work Distribution | Channel | Entity Records | Select the **Entity Records** channel from the list.|
    | Work Distribution | Entity | Case | Select an entity from the drop-down menu. <br> If you want to create a entity, select **+ New**. To learn more, see [Enable entity for routing](entity-channel.md#step-3-enable-entity-for-routing). |
    | Work Distribution | Capacity | 50 |Specify the units of capacity that are required to process a conversation for the workstream in the text box. <br> **Note:** <ul><li> The value provided is an example. </li></ul> |
    | Work Distribution | Work distribution mode | Push | Select **Push** when you want to automatically route the cases to the agents. <br><br> Select **Pick** when you want the agents to explicitly pick a conversation from the **Open work items** in agent dashboard. |
    | Work Distribution | Allowed presences | Allowed, Busy | Set the allowed presence status <br><br> Select the option and type a presence status in the search box. Select a status from the list. <br> **Note:** <ul><li> The value provided is an example. </li></ul>|

    > [!div class=mx-imgBorder] 
    > ![Specify values for the fields](../media/case-ws3.png "New case workstream")

5. Select **Save** to save the workstream.

> [!Note]
> When you enable an entity for routing, the Omnichannel Administration app creates a default workstream for each entity. If you create a new workstream or update the default workstream according to your business scenario, you need to update these workstream information in **Entity Records distribution Flow**. To learn more, see [Update entity records work distribution flow](multiple-ws-entity-record-routing.md#update-entity-records-work-distribution-flow).

## Upgrade path for preview users

If you are upgrading from preview release to the latest version, then earlier configured workstreams will be obsolete. You need to create a new entity records channel and then redefine the workstreams. To learn more, see [Entity records routing](entity-channel.md).

## See also

[Entity records routing](entity-channel.md)

[Understand and create workstreams](work-streams-introduction.md)

[Create multiple workstreams for entity records routing](multiple-ws-entity-record-routing.md)
