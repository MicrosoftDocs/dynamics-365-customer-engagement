---	
title: "Automate case routing using entity records channel | MicrosoftDocs"	
description: "This walkthrough demonstrates how you can route entity record automatically using Entity Records channel in the Omnichannel for Administrator app."	
author: kabala123	
ms.author: kabala	
manager: shujoshi	
applies_to: 	
ms.date: 08/16/2019
ms.service: dynamics-365-customerservice	
ms.topic: article	
ms.assetid: 3DBB1579-ECD2-43E6-B994-6D83A7C2C8F1
ms.custom: 	
---

# Walkthrough: Automate entity record routing

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

This walkthrough demonstrates how you can create Omnichannel queues, multiple entity record workstreams, routing rules, and update work distribution flow to, automatically distribute entity records to the agent's based on the capacity and availability.

### In this section

[Step 1: Create queues](#step-1-create-queues)

[Step 2: Create works stream for case routing](#step-2-create-workstream-for-case-routing)4

[Step 3: Create routing rules](#step-3-create-routing-rules)

[Step 4: Update Cases Work Distribution Flow](#step-4-update-cases-work-distribution-flow)

## Step 1: Create queues

You must create a queue or enable existing queue to, automatically route the cases to the queue. To learn more, see [Create a queue](queues-omnichannel.md#create-a-new-queue).

## Step 2: Create workstream for case routing

You must create workstreams, to automatically route the cases to the agents. You can create multiple workstreams, too. In this walkthrough, let us create two workstreams - **High Priority Cases** and **Low Priority Cases**.

To learn more, see [Create cases entity workstream](set-up-entity-workstream.md).

## Step 3: Create routing rules

After creating the workstream for the cases, you must create the routing rules. 

> [!Note]
> To create routing rules for cases, you must install the **Routing Rules - Preview** solution. To learn more, see [Link to the topic will be added here]().

1. Sign in to the Omnichannel for Administrator app.

2. Select **Entity Records** under **Channels** in the sitemap.

3. Select the workstream you created for routing the cases from the **Entity Record Workstreams** view.

    > [!div class=mx-imgBorder] 
    > ![Select a case workstream](../media/case-entity-channel.png "Case workstream")

4. Select the **Routing Rules** tab in the workstream.

    > [!div class=mx-imgBorder] 
    > ![Select the routing rule items tab](../media/case-routing-rule.png "Routing rule items")

5. Select **+ New** in the **All Routing Rule Sets** page.

6. Specify a name in the **New Routing Rule Set** page, and then select **Save** to save the rule. Once you save the record, you can see the **Rule Items** section in the page.

7. Select **+ Add New Rule Item** in the **Rule Items** section. A **New Rule Item** page appears. 

    > [!div class=mx-imgBorder] 
    > ![Add New Rule Item](../media/case-ws-rr2.png "Add New Rule Item")

8. Specify the following on the **New Rule Item** page.

    | Tab | Field | value | Description |
    |------------------|----------------------------|----------------------------------|--------------------------------------------|
    | General | Name | Push cases | Specify a name to the rule item. |
    | General | Description | This rule item is used to for pushing high priority cases to the agents. | Specify a description for you to identify the purpose of the rule item. |

9. Select **+ Add v** in the **Rule Criteria** section, and then select **+ Add row**.

    a. Select a rule from the list for the first box. For example, **Priority**.

    b. Select a condition from the list. For example, **Equals**.

    c. Select a value for the rule from the list. For example, **High**.

10. Select **Queue** for the **Route to** field. 

11. Select an omnichannel queue for the **Add to Queue** field.

    The steps 9 to 11 indicate if the **Priority** of a case is **High**, then route the case to the selected omnichannel queue.

    > [!div class=mx-imgBorder] 
    > ![New Rule Item values](../media/case-ws-rr-rule-item1.png "New Rule Item values")

    > [!Note]
    > You must select an omnichannel queue for automatic work distribution in the **Add to Queue** field to automatically assign entity records to agents.

12. Select **Save** to save the rule item.

## Step 4: Update cases work distribution flow

After creating the routing rules for the cases workstream, you must update **Cases Work Distribution Flow**. The Omnichannel application creates **Cases Work Distribution Flow** when you enable an entity records channel.

**Cases Work Distribution Flow** contains the following components.

| Component | Modification recommendation |
|-----------------------------------|-----------------------------------|
| When the record is created | No need to modify; however, you can extend it for custom scenarios. |
| Initialization | Do not modify. |
| Workstream Initialization | Do not modify. |
| Current record | Do not modify. |
| Work Stream Selection - Set LiveWorkStreamId to route this record to | Update the condition and workstreams Id. |
| Invoke Omnichannel | Do not modify. |

### Update work distribution flow

1. Sign in to Microsoft Flow.

2. Select **Solutions** in the sitemap, and then select **Default Solution** from the list.

    > [!div class=mx-imgBorder] 
    > ![Select default solution](../media/case-work-distribution-flow1.png "Select default solution")

3. Select the **All** button in the menu and select **Flow** to filter the flows.

    > [!div class=mx-imgBorder] 
    > ![Select the All button and filter flow](../media/case-work-distribution-flow2.png "Filter flow")

4. Select **Case Work Distribution Flow** from the list.

    > [!div class=mx-imgBorder] 
    > ![Select Cases Work Distribution Flow](../media/case-work-distribution-flow3.png "Select Cases Work Distribution Flow")

5. Select the **Edit** button from the command bar at the top. The flow appears in a new tab.

    > [!div class=mx-imgBorder] 
    > ![Select the Edit button](../media/case-work-distribution-flow4.png "Edit the Cases Work Distribution Flow")

6. Select the flow component that shows the warning icon, and select **+ Add new connection** to resolve the warning. The flow component uses the current user credentials and resolves the warning.

    ![Resolve flow warning](../media/flow-error1.png "Resolve flow warning")

7. Select the **Work Stream Selection - Set LiveWorkStreamId to route this record to** section, and then select **Condition 4**.

    > [!div class=mx-imgBorder] 
    > ![Select workstream](../media/case-work-distribution-flow5.png "Select workstream")

8. Select the search box to add a rule. A flyout control appears. Type a rule name in the search box. For example, **Priority**. The rule appears in the list, and when you select the rule, it is added to the field. 

    > [!div class=mx-imgBorder] 
    > ![Add rule](../media/case-work-distribution-flow7.png "Add rule")

9. Select a condition from the list. For example, **is equal to**.

10. Type the rule value in the field. For example, **1**.

    > [!div class=mx-imgBorder] 
    > ![Set condition and value](../media/case-work-distribution-flow8.png "Set condition and value")

11. Select the **Set variable 4** option under the **If yes** section.

12. Select the **Value** field search box to add a variable. A flyout control appears. Type the name of the workstream you created in the search box. For example, **High Priority Cases** is one of the case workstream that you created to route high priority cases. The value appears in the list, and when you select the value, it is added to the field. 

    > [!Note]
    > If you update the name of the workstream, then you must perform step 12. Otherwise, the cases won't be automatically distributed to the agents.

    > [!div class=mx-imgBorder] 
    > ![Set the If yes variable value](../media/case-work-distribution-flow9.png "Set variable value")

13. Select the **Set variable 5** option under the **If no** section.

14. Select the **Value** field search box to add a variable. A flyout control appears. Type the name of the workstream you created in the search box. For example, **Low Priority Cases** is one of the case workstream that you created to route low priority cases. The value appears in the list, and when you select the value, it is added to the field.

    > [!Note]
    > - If you update the name of the workstream, then you must perform step 14. Otherwise, the cases won't be automatically distributed to the agents.
    >
    > - Adding multiple workstreams is the conditions are optional. If your business process requires multiple workstream conditions, you can create it.

    > [!div class=mx-imgBorder] 
    > ![Set the If no variable value](../media/case-work-distribution-flow10.png "Set variable value")

15. Select **Save** to save **Cases Work Distribution Flow**.

    > [!div class=mx-imgBorder] 
    > ![Workstream selection](../media/case-work-distribution-flow11.png "Workstream selection")

## See also

[Entity records routing](entity-channel.md)

[Understand and create workstreams](work-streams-introduction.md)

[Cases entity workstreams](set-up-entity-workstream.md)

[Work with queues](queues-omnichannel.md)