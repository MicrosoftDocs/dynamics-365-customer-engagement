---	
title: "Set up entity work stream | MicrosoftDocs "	
description: "Learn how to set up entity work stream in the Omnichannel for Customer Service"	
keywords: Create entity channel; Omnichannel for Customer Service; Omnichannel Administration
author: kabala123	
ms.author: kabala	
manager: shujoshi	
applies_to: 	
<<<<<<< HEAD
ms.date: 10/25/2019
=======
ms.date: 09/18/2019
>>>>>>> 4c9cd9f49bfd32b1dacbbac975fffb89f4dfc869
ms.service: dynamics-365-customerservice	
ms.topic: article	
ms.assetid: 62703F93-3484-4D3E-B682-A9601619567F	
ms.custom: 	
---	

# Preview - Entity record workstreams

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
    | Work Distribution | Entity | Case | Select an entity from the drop-down menu. <br> If you want to create a entity, select **+ New**. To learn more, see [Create entity records channel](entity-channel.md#step-2-create-entity-records-channel). |
    | Work Distribution | Capacity | 50 |Specify the units of capacity that are required to process a conversation for the workstream in the text box. <br> **Note:** <ul><li> The value provided is an example. </li></ul> |
    | Work Distribution | Auto-close after inactivity | 5 minutes | Set time after which a conversation is moved from the **Waiting** state to the **Closed** state because of inactivity. <br> **Note:** <ul><li> The value provided is an example. </li></ul> |
    | Work Distribution | Work distribution mode | Push | Select **Push** when you want to automatically route the cases to the agents. <br><br> Select **Pick** when you want the agents to explicitly pick a conversation from the **Open work items** in agent dashboard. |
    | Work Distribution | Allowed presences | Allowed, Busy | Set the allowed presence status <br><br> Select the option and type a presence status in the search box. Select a status from the list. <br> **Note:** <ul><li> The value provided is an example. </li></ul>|

    > [!div class=mx-imgBorder] 
    > ![Specify values for the fields](../media/case-ws3.png "New case workstream")

5. Select **Save** to save the workstream.

## See also

[Entity records routing](entity-channel.md)

[Understand and create workstreams](work-streams-introduction.md)

[Walkthrough: Create multiple workstreams for entity records routing](multiple-ws-entity-record-routing.md)
