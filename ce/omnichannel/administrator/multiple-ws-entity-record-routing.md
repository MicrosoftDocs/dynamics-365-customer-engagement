---	
title: "Create multiple workstreams for entity records routing | MicrosoftDocs"	
description: "This walkthrough demonstrates how you can route entity record automatically using Entity Records channel in the Omnichannel Administration app."	
author: kabala123	
ms.author: kabala	
manager: shujoshi	
applies_to: 	
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice	
ms.topic: article	
ms.assetid: 3DBB1579-ECD2-43E6-B994-6D83A7C2C8F1
ms.custom: 	
---

# Create multiple workstreams for entity records routing

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

You can setup multiple workstreams for same entity records if you want to distribute the entity records to different workstreams based on certain conditions. 

For example, you want high priority cases to be pushed to agents and demand more capacity than low priority cases, which can be picked by agents. You can achieve it by configuring multiple workstreams.

This walkthrough demonstrates how to set up two workstreams, one each for high priority cases and low priority cases and to distribute the cases appropriately.


### In this section

[Step 1: Create workstream](#step-1-create-workstream)

[Step 2: Create routing rules](#step-3-create-routing-rules)

[Step 3: Update Entity Record Distribution Flow](#step-3-update-entity-records-distribution-flow)

## Step 1: Create workstream

Create entity records workstream to define how records will be distributed. In this walkthrough, let us create two workstreams - **High Priority Cases** and **Low Priority Cases**.

To learn more, see [Entity record workstreams](set-up-entity-workstream.md).

## Step 2: Create routing rules

To learn more, see [Create routing rules](entity-channel.md#step-4-create-routing-rules).

## Step 3: Update entity records distribution flow

If you are creating or editing an entity record workstream, you must update **Entity records Distribution Flow**. The Omnichannel application automatically creates this flow out-of-the-box for distributing entity records. 

**Entity records Distribution Flow** contains the following components.

| Component | Modification recommendation |
|-----------------------------------|-----------------------------------|
| When the record is created | Do not modify. |
| Initialization | Do not modify. |
| Omnichannel Work Distribution | You can see the list of entity records for which work streams were created in the Omnichannel Administrator app. |
| \<Entity Record\> | Select to view the components under the Entity record. |
| Work Stream Initialization - \<Entity Record\> | Do not modify. |
| Entity record - \<Entity Record\> | Do not modify. |
| Work Stream Selection for Routing (\<Entity Record\> ) | Update the condition and workstreams Id. |
| Invoke Omnichannel | Do not modify. |

> [!Important]
> Ensure that **Entity Records Distribution Flow** is closed before you update the workstream. Assume, you've made certain updates to the Flow, and while the Flow is still in the open in the browser, you update the workstream. In this case, after you save the workstream, the Flow will be reset to its earlier state causing to loose the changes you made.

> [!Warning]
> We recommend you update only the **Work Stream Selection for Routing** component in **Entity Records Distribution Flow**. If you update any other component step in the flow, the entity routing might fail. 

### Update entity records work distribution flow

1. Sign in to the Omnichannel Administrator app.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select the workstream for which you want to update the flow.

4. Select **Flow** menu in the command bar, and then select **See your flows**. Microsoft Flow opens in a new browser window.

5. Select **Solutions** in the sitemap, and then select **Default Solution** from the list.

    > [!div class=mx-imgBorder] 
    > ![Select default solution](../media/case-work-distribution-flow1.png "Select default solution")

6. Select the **All** button in the menu and select **Flow** to filter the flows.

    > [!div class=mx-imgBorder] 
    > ![Select the All button and filter flow](../media/case-work-distribution-flow2.png "Filter flow")

7. Select **Entity Record Distribution Flow** from the list.

    > [!div class=mx-imgBorder] 
    > ![Select Cases Work Distribution Flow](../media/case-work-distribution-flow3.png "Select Cases Work Distribution Flow")

8. Select the **Edit** button from the command bar at the top. The flow appears in a new tab.

9. Select the flow component that shows the warning icon. Select an existing connection to resolve the warning. The flow component uses the current user credentials and resolves the warning.

    ![Resolve flow warning](../media/flow-error1.png "Resolve flow warning")

10. Select the **Omnichannel Work Distribution** section, and then select **< Entity Record > Distribution flow** > **Work Stream Selection for Routing** section.

    > [!div class=mx-imgBorder] 
    > ![Select workstream](../media/case-work-distribution-flow5.png "Select workstream")

11. Remove the **Select Default Work Stream - < Entity Record >** section by selecting the ellipses, and then by selecting **Delete**.

12. Select **Add an action** in the  **Work Stream Selection for routing entity- < Entity Record >** section.

13. Select **Conditions** under the **Actions** tab.  

14. Select the **Choose a value** box to add a rule. A flyout control appears. Type in the search box to look up the attributes of the Case record that is being routed. For example, **Priority**. The rule appears in the list, and when you select the rule, it is added to the field. 

    > [!div class=mx-imgBorder] 
    > ![Add rule](../media/case-work-distribution-flow7.png "Add rule")

15. Select a condition from the list. For example, **is equal to**.

16. Type the rule value in the field. For example, **1**.

    > [!div class=mx-imgBorder] 
    > ![Set condition and value](../media/case-work-distribution-flow8.png "Set condition and value")

17. Select **Add an action** button under the **If yes** section. The **Choose an action** component appears. Now, type **Set Variable** in the **Search connectors and actions** box and the action appears in the list. Select it and the **Set Variable** action appears.

    > [!div class=mx-imgBorder] 
    > ![Add Set Variable Action](../media/flow-select-variable.png "Add Set Variable Action")

18. Select the **LiveWorkStreamId** from the Name drop-down list.

19. Select the **Value** field search box to add a variable. A flyout control appears. Type the name of the workstream you created in the search box. For example, **High Priority Cases** is one of the case workstream that you created to route high priority cases. The value appears in the list, and when you select the value, it is added to the field. 

    > [!Note]
    > If you update the name of the workstream in Omnichannel Administration app, then you must perform step 19. Otherwise, the cases won't be automatically distributed to the agents.

    > [!div class=mx-imgBorder] 
    > ![Set the If yes variable value](../media/case-work-distribution-flow9.png "Set variable value")

20. Select **Add an action** button under the **If yes** section. The **Choose an action** component appears. Now, type **Set Variable** in the **Search connectors and actions** box and the action appears in the list. Select it and the **Set Variable** action appears.

21. Select the **LiveWorkStreamId** from the Name drop-down list.

22. Select the **Value** field search box to add a variable. A flyout control appears. Type the name of the workstream you created in the search box. For example, **Low Priority Cases** is one of the case workstream that you created to route low priority cases. The value appears in the list, and when you select the value, it is added to the field.

    > [!Note]
    > - If you update the name of the workstream in Omnichannel Administration app, then you must perform step 22. Otherwise, the cases won't be automatically distributed to the agents.
    >
    > - Adding multiple workstreams in the conditions are optional. If your business process requires multiple workstream conditions, you can create it.

    > [!div class=mx-imgBorder] 
    > ![Set the If no variable value](../media/case-work-distribution-flow10.png "Set variable value")

23. Select **Save** to save **Entity Record Distribution Flow**.

    > [!div class=mx-imgBorder] 
    > ![Workstream selection](../media/case-work-distribution-flow11.png "Workstream selection")

## Troubleshoot

- [Entity routing configuration fails](../troubleshoot-omnichannel-customer-service.md#entity-routing-configuration-fails)

- [Entity routing does not route records](../troubleshoot-omnichannel-customer-service.md#entity-routing-does-not-route-records)

## See also

[Route trigger for entity records](routing-trigger.md)

[Entity records routing](entity-channel.md)

[Understand and create workstreams](work-streams-introduction.md)

[Entity record workstreams](set-up-entity-workstream.md)

[Work with queues](queues-omnichannel.md)
