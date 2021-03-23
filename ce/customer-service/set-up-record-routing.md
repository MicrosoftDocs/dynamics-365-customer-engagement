---
title: "Set up record routing | MicrosoftDocs"
description: "Learn how to set up record routing in Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Set up record routing

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can configure settings for record routing in Customer Service Hub, Omnichannel admin center, or Omnichannel Administration.

## Prerequisites

To route entity records, you must enable the entity for routing using entity records channel configuration. To learn more [Entity records routing](entity-channel.md#step-2-enable-entity-for-activities-and-queues).

For configuring unified routing for entities, the following prerequisites must be met:

- The toggle for unified routing is set to yes in the **Service Configuration Settings** section of Customer Service Hub.
- The entities that you want to configure routing for should also be enabled in your environment. More information: [Enable entities for routing](entity-channel.md#enable-entities).

## Configure record routing in Customer Service Hub

You can configure record routing for entities in Customer Service Hub and Omnichannel admin center.

Perform the following steps to configure record routing:

1. In Customer Service Hub, on the site map, select **Record routing** under **Unified routing**. If you are using Omnichannel admin center, on the site map, select **Record routing** under **General settings**. 
2. On the **Record routing** page, select **Add**.
3. In the **Add a record type** dialog box, select an entity from the **Record type** list, and select **Add**. The entity is added and listed on the **Record routing** page.
4. To configure routing for the entity, do the following steps:
   1. Configure workstreams.
   2. Configure intake rules.

### Create workstreams for record routing

To configure a workstream for the entity record, perform the steps in [Create workstreams in Omnichannel admin center](create-workstreams.md).

### Configure intake rules

Intake rules for an entity record help determine the workstream to be picked up to assign an incoming work item.
Perform the following steps to configure the intake rules:

1. Select the workstream that you configured for routing records, such as the case.
2. In the **Intake rules** area, select **Create rule**.
3. On the Create intake rule dialog box, enter a name, and define the conditions for the rule.
   >![Intake rule](media/ur-intake-rule.png "Intake rule")
4. Select **Create**.

A workstream that has the required intake rule and route to queues is as follows.
>![Workstream for a case record](media/ur-record-routing-workstream.png "Workstream for a case record")


## Create entity record workstream in Omnichannel Administration

This section describes how to create a workstream for an entity that has been enabled for routing.

1. Sign in to the Omnichannel Administration app.

2. Select **Work Streams** under **Channels** in the sitemap.

3. Select **New** in the **Active Work Streams** page.

4. Specify the following in the **New Work Stream** page.

    | Tab | Field | Value | Description | 
    |---------------------|-----------------------------|-------------------------------------------|-------------------------------------------------|
    | Work Distribution | Name | Case Work stream | Provide a name to the work stream. <br> **Note:** The value provided is an example.  |
    | Work Distribution | Channel | Entity Records | Select the **Entity Records** channel from the list.|
    | Work Distribution | Entity | Case | Select an entity from the drop-down menu. <br> If you want to create a entity, select **+ New**. To learn more, see [Enable entity for routing](entity-channel.md#step-3-enable-entity-for-routing). |
    | Work Distribution | Capacity | 50 |Specify the units of capacity that are required to process a conversation for the work stream in the text box. <br> **Note:** <ul><li> The value provided is an example. </li></ul> |
    | Work Distribution | Work distribution mode | Push | Select **Push** when you want to automatically route the cases to the agents. <br><br> Select **Pick** when you want the agents to explicitly pick a conversation from the **Open work items** in agent dashboard. |
    | Work Distribution | Allowed presences | Allowed, Busy | Set the allowed presence status <br><br> Select the option and type a presence status in the search box. Select a status from the list. <br> **Note:** <ul><li> The value provided is an example. </li></ul>|

    > [!div class=mx-imgBorder] 
    > ![Specify values for the fields](media/case-ws3.png "New case work stream")

5. Select **Save** to save the work stream.

> [!Note]
> When you enable an entity for routing, the Omnichannel Administration app creates a default work stream for each entity. If you create a new work stream or update the default work stream according to your business scenario, you need to update the work stream information in **Entity Records distribution Flow**. To learn more, see [Update entity records work distribution flow](multiple-ws-entity-record-routing.md#update-entity-records-work-distribution-flow).

### Upgrade path for preview users

If you are upgrading from preview release to the latest version, then earlier configured workstreams will be obsolete. You need to create a new entity records channel and then redefine the workstreams. To learn more, see [Entity records routing](entity-channel.md).

### See also

[Entity records routing](entity-channel.md)  
[Understand and create work streams](work-streams-introduction.md)  
[Create multiple work streams for entity records routing](multiple-ws-entity-record-routing.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]