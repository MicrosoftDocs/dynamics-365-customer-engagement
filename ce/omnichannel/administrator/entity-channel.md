---	
title: Entity records routing using entity records channel | MicrosoftDocs	
description: Learn how you can route cases automatically using entity records channel in the Omnichannel Administration app.		
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
ms.assetid: 5e6285ee-4b79-473d-b920-d1fab636c82e	
ms.custom: 	
---	
# Preview: Entity records routing

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview
 
<<<<<<< HEAD
In Omnichannel Administration, **Entity Records** channel helps you to automatically route cases and other entity records to agents based on the agent's capacity and availability.
=======
In Omnichannel for Administrator, **Entity Records** channel helps you to automatically route cases and other entity records to agents based on the agent's capacity and availability.

> [!Note]
> Only case entity record is supported in this release. To learn about the support for other entity records routing, see [Unified routing for entity records](https://docs.microsoft.com/en-us/dynamics365-release-plan/2019wave2/dynamics365-customer-service/unified-routing-queues).
>>>>>>> 4c9cd9f49bfd32b1dacbbac975fffb89f4dfc869

### Automatic distribution of cases

Today, case routing in Dynamics 365 Customer Service enables organizations to route cases to the manual queues, and then these cases are either manually assigned by supervisors or manually picked by agents.

With unified routing for entity records, organizations can route cases and other entity records to omnichannel queues. The cases and other entity records routed to omnichannel queues are automatically distributed and assigned to best available agents based on their availability and capacity.

### Unified Routing and Queues

Cases and other entity records can be routed to omnichannel queues along with work items that originate from other channels such as Chat and SMS. 

This allows organizations to tightly define the work profile that their agents are supposed to handle, and organizations can automate the work flow assignment across channels and assign the work items based on agents capacity and availability.

<<<<<<< HEAD
=======
## Prerequisites

To configure entity records channel for case routing and automatic distribution, ensure:

- You are on the latest version of Omnichannel for Customer Service.
- You've installed the **Routing Rules - Preview** solution. To learn more, see [Install Routing Rules - preview solution](../../customer-service/install-routing-rules-preview-solution.md).

>>>>>>> 4c9cd9f49bfd32b1dacbbac975fffb89f4dfc869
## Configure entity records channel

To setup the **Entity Record** channel for cases, follow the steps:

| Step | Description |
|---------------|----------------------------|--------------------------------------------------------------------------------------------|
| [Step 1: Create queues](#step-1-create-queues) | Create a new omnichannel queue or continue using an existing omnichannel queue. |
| [Step 2: Create workstream](#step-2-create-entity-records-channel) | Create a entity records channel and define how these records will be distributed. |
| [Step 3: Create routing rules](#step-3-create-routing-rules) | Create routing rules to route cases to the appropriate queues. |

## Step 1: Create queues

Create a new omnichannel queue or use an existing omnichannel queue. To learn more, see [Create a queue](queues-omnichannel.md#create-a-new-queue).

> [!Note]
> If you enable the option - **Automatically move records to the owner's default queue when a record is created or assigned**, in the case entity customization, then the case entity record won't be automatically distributed to the agents. You must clear the checkbox to automatically distribute the case records. <br><br> ![Automatic record movement to the agent's default queue](../media/route-owner-queue.png "Automatic record movement to the agent's default queue")

## Step 2: Create entity records channel

Create a entity records channel to route entity records and define how these records will be distributed.

1. Sign in to the Omnichannel Administration app.

2. Select **Entity Records** under **Channels** in the sitemap.

3. Select **+ New** in the **Active Entities** page.

4. Specify the following in the **New Entity** page.

    | Tab | Field | Description | Value |
    |--------|---------------------|----------------|----------------------|
    | Basic Details | Name | Specify a name to the entity record channel. | Lead entity channel  <br> **Note:** This is an example value.|
    | Basic Details | Entity | Select an entity from the drop-down list. | Lead (lead) |

5. Select **Save** to save the entity record channel. After you save, in the **Work distribution** section, a workstream that was created automatically appears.

> [!Note]
> If you require more workstreams, create entity records workstream, and define how these records will be distributed. To learn more, see [Entity record workstream](set-up-entity-workstream.md).

## Step 3: Create routing rules

After enabling entity record channel, create routing rules to route cases to appropriate queues.

> [!Note]
> To create routing rules for cases, you must install the **Routing Rules - Preview** solution. To learn more, see [Install Routing Rules - preview solution](../../customer-service/install-routing-rules-preview-solution.md).

1. Sign in to the Omnichannel Administration app.

2. Select **Entity Records** under **Channels** in the sitemap.

3. Select the record you created for routing the cases from the **Active Entities** view.

    > [!div class=mx-imgBorder] 
    > ![Select a case workstream](../media/case-entity-channel1.png "Case workstream")

4. Select the **Routing Rules** tab in the entity records channel.

    > [!div class=mx-imgBorder] 
    > ![Select the routing rule items tab](../media/case-routing-rule1.png "Routing rule items")

5. Select **+ New** in the **All Routing Rule Sets** page.

6. Specify a name in the **New Routing Rule Set** page, and then select **Save** to save the rule. Once you save the record, you can see the **Rule Items** section in the page.

7. Select **+ Add New Rule Item** in the **Rule Items** section. A **New Rule Item** page appears. 

    > [!div class=mx-imgBorder] 
    > ![Add New Rule Item](../media/case-ws-rr2.png "Add New Rule Item")

8. Specify the following on the **New Rule Item** page.

    | Tab | Field | value | Description |
    |------------------|----------------------------|----------------------------------|--------------------------------------------|
    | General | Name | Product - Credit card | Specify a name to the rule item. |
    | General | Description | This rule item is used to for pushing high priority cases to the agents. | Specify a description for you to identify the purpose of the rule item. |

9. Select **+ Add v** in the **Rule Criteria** section, and then select **+ Add row**.

    a. Select a rule from the list for the first box. For example, **Subject**.

    b. Select a condition from the list. For example, **Contains**.

    c. Select a value for the rule from the list. For example, **Credit card**.

10. Select **Queue** for the **Route to** field. 

11. Select an omnichannel queue for the **Add to Queue** field.

    The steps 9 to 11 indicate if the **Subject** of a case is **Credit card**, then route the case to the selected omnichannel queue.

    > [!div class=mx-imgBorder] 
    > ![New Rule Item values](../media/case-ws-rr-rule-item2.png "New Rule Item values")

    > [!Note]
    > You must select an omnichannel queue for automatic work distribution in the **Add to Queue** field to automatically assign entity records to agents.

12. Select **Save** to save the rule item.

### See also 	

[Understand and create workstreams](work-streams-introduction.md)

[Entity record workstreams](set-up-entity-workstream.md)

[Work with queues](queues-omnichannel.md)

[Walkthrough: Create multiple workstreams for entity records routing](multiple-ws-entity-record-routing.md)
