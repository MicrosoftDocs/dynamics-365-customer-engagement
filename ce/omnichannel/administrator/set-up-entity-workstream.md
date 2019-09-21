---	
title: "Set up entity work stream | MicrosoftDocs "	
description: "Learn how to set up entity work stream in the Omnichannel for Customer Service"	
keywords: Create entity channel; Omnichannel for Customer Service; Omnichannel Administration
author: kabala123	
ms.author: kabala	
manager: shujoshi	
applies_to: 	
ms.date: 09/18/2019
ms.service: dynamics-365-customerservice	
ms.topic: article	
ms.assetid: 62703F93-3484-4D3E-B682-A9601619567F	
ms.custom: 	
---	

# Preview - Entity record workstreams

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Create entity record workstream

This topic describes how to create a workstream that is used to route the case entity record.

> [!NOTE]
> In the August 2019 update release, by default, entity records workstream routes and distributes only the **Case** entity record. Support for other entity records will be available in the future release, and you can select the entity record you want to route.

1. Sign in to the Omnichannel Administration app.

2. Select **Entity Records** under **Channels** in the sitemap.

3. Select **+ New** in the **Entity Records Workstreams** page.

    > [!div class=mx-imgBorder] 
    > ![Create new Cases workstream](../media/case-ws1.png "Create new workstream")

4. Specify the following in the **New Work Stream** page.

    | Tab | Field | Value | Description | 
    |---------------------|-----------------------------|-------------------------------------------|-------------------------------------------------|
    | Work Distribution | Name | Case Workstream | Provide a name to the workstream. <br> **Note:** <ul><li> If you update the name of the workstream, you must update **Cases Work Distribution flow** by navigating to Microsoft Flow.</li> <li> The value provided is an example. </li></ul>  |
    | Work Distribution | Channel | Entity Records | Select the **Entity Records** channel from the list. <br> **Note:** <ul> <li> In the August 2019 update release, by default, entity records workstream routes and distributes only the **Case** entity record. Support for other entity records will be available in the future release, and you can select the entity record you want to route. </li> </ul>|
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
