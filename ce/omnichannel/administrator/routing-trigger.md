---	
title: Route trigger for entity records | MicrosoftDocs	
description: Learn how to route entity records automatically.		
author: kabala123	
ms.author: kabala	
manager: shujoshi	
applies_to: 	
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice	
ms.topic: article	
ms.assetid:	F3FBCEC3-B854-447B-9D33-159B3DDE6D2C
ms.custom: 	
---	
# Route trigger for entity records

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

If your organization doesn't want to route all the entity records upon creation of entity records, as an administrator, you can define a trigger on when and which entity records can be routed automatically.

There are two types of triggers:

- Manual trigger - Save & Route
- Automatic trigger - Route trigger Flow

## Manual trigger

When ever you enable a entity for routing, you can view the **Save & Route** button in the ribbon command bar. Use this button to route the entity records manually.

To save a entity record and route it to a queue in a single click, use the **Save & Route** button.

1. Sign in to Omnichannel for Customer Service app.

2. Select a entity record from the entity views. <br> For example, select **Leads** in the sitemap, and then select a lead record from the **My Open Leads** view.

3. Make the changes as required, and on the command bar, select **Save & Route**. The **Route Case** dialog box appears. 

4. Select **Route**.  

The entity record will be routed based on the active routing rule set.

## Automatic trigger

To enable automatic trigger to route the entity records, you need to create a Flow.

1. Sign in to Microsoft Flow.

2. Select the environment for which you want to update the Flow.

3. Select **My Flows** in the sitemap.

4. Select **+ New** and select the **Automated-from blank** option. Select **Skip** in the **Build an automated flow** dialog.

5. Type **Common Data Service**, and select it from the list. The Common Data Service connector enables you to connect to the Common Data Service environment.

6. Type **When a record is created, updated or deleted** in the search box, and select it from the list. **When a record is created, updated or deleted** is the trigger condition step. 

    > [!div class=mx-imgBorder] 
    > ![Select Common Data Service and When a record is created, updated or deleted trigger](../media/route-trigger1.png "Select Common Data Service and When a record is created, updated or deleted trigger")

7. Specify the following in the **When a record is created, updated or deleted** trigger.

    | Field | Description | Example Value |
    |-----------------|----------------------------|-----------------------------|
    | Trigger condition| Specify the condition to fire the trigger. That is, when you select a trigger condition, based on this state, the entity record will be routed automatically. <br> <br> The list of possible values are: <ul> <li>Create</li> <li>Create or Delete</li> <li>Create or Update</li> <li>Create or Update or Delete</li> <li>Delete</li> <li>Update</li> <li>Update or Delete</li>| Create |
    | The entity name | Specify the entity collection name for which you want to fire the trigger. |  Leads |
    | Scope | Specify where this trigger must be applied. | Organization |

    > [!div class=mx-imgBorder] 
    > ![Specify the trigger condition](../media/route-trigger2.png "Specify the trigger condition")

8. Select **+ New step**. The **Choose an action** step appears.

9. Type **Perform an unbound action** in the search box, and select the action from the list. The **Perform an unbound action** step appears.

    > [!div class=mx-imgBorder] 
    > ![Select Perform an unbound action](../media/route-trigger3.png "Select Perform an unbound action")

10. Type **msdyn_ApplyRoutingRuleEntityRecord** in the **Action Name** field.

11. Type the entity collection name and unique identifier of the entity in the specified format against the **Target** field:

    Format: `<entity collection name>(unique identifier of the entity)`
    Example: leads(Lead)

    > [!div class=mx-imgBorder] 
    > ![Select Perform an unbound action](../media/route-trigger4.png "Select Perform an unbound action")

12. Select **Save** to save the Flow.

Whenever a first entity record, say lead, is created, the Flow applies the **ApplyRoutingRuleRecord** action on the entity record.

## See also

[Entity records routing](entity-channel.md)

[Walkthrough: Create multiple workstreams for entity records routing](multiple-ws-entity-record-routing.md)
