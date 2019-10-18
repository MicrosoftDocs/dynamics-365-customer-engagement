---	
title: "Set up entity work stream | MicrosoftDocs "	
description: "Learn how to set up entity work stream in the Omnichannel for Customer Service."
author: kabala123	
ms.author: kabala	
manager: shujoshi	
applies_to: 	
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice	
ms.topic: article	
ms.assetid: 62703F93-3484-4D3E-B682-A9601619567F	
ms.custom: 	
---	

# Create workstream for entity record routing

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Create entity record workstream

This topic describes how to create a workstream that is used to route the case and other entity records.

1. Sign in to the Omnichannel Administration app.

2. Select **Work Streams** under **Channels** in the sitemap.

3. Select **+ New** in the **Active Work Streams** page.

4. Specify the following in the **New Work Stream** page.

    | Tab | Field | Value | Description | 
    |---------------------|-----------------------------|-------------------------------------------|-------------------------------------------------|
    | Work Distribution | Name | Case Workstream | Provide a name to the workstream. <br> **Note:** The value provided is an example.  |
    | Work Distribution | Channel | Entity Records | Select the **Entity Records** channel from the list.|
    | Work Distribution | Entity | Case | Select an entity from the drop-down menu. <br> If you want to create a entity, select **+ New**. To learn more, see [Enable entity for routing](entity-channel.md#step-2-enable-entity-for-routing). |
    | Work Distribution | Capacity | 50 |Specify the units of capacity that are required to process a conversation for the workstream in the text box. <br> **Note:** <ul><li> The value provided is an example. </li></ul> |
    | Work Distribution | Work distribution mode | Push | Select **Push** when you want to automatically route the cases to the agents. <br><br> Select **Pick** when you want the agents to explicitly pick a conversation from the **Open work items** in agent dashboard. |
    | Work Distribution | Allowed presences | Allowed, Busy | Set the allowed presence status <br><br> Select the option and type a presence status in the search box. Select a status from the list. <br> **Note:** <ul><li> The value provided is an example. </li></ul>|

    > [!div class=mx-imgBorder] 
    > ![Specify values for the fields](../media/case-ws3.png "New case workstream")

5. Select **Save** to save the workstream.

> [!Note]
> When you enable an entity for routing, the Omnichannel Administrator app creates a default workstream for each entity. If you are create a new workstream or update the default workstream according to your business scenario, you need to update these workstream in **Entity Records distribution Flow**.

## Upgrade path for preview users

If you are already using the Entity Records feature and after upgrade from preview release to the latest version, the **Entity** field in the **Work Stream** page will be empty. 

First, you need to create a new Entity Record and remove the automatically created default work stream in the Entity Record. Go to the already existing workstream and update the **Entity** field.

Follow the steps to update the **Entity** field.

1. Create Entity Record. To create a entity record, see [Entity records routing](entity-channel.md).
 
2. Remove the default workstream in Entity Record that you created.

3. Go to already existing workstream where you want to update the field.

4. Update the workstream with the creted entity record channel configuration, then and select **Save**.

> [!Note]
> After you update the workstream, you don't need to update the Flow as the Flow is automatically updated as you save the workstream.


## See also

[Entity records routing](entity-channel.md)

[Understand and create workstreams](work-streams-introduction.md)

[Create multiple workstreams for entity records routing](multiple-ws-entity-record-routing.md)
