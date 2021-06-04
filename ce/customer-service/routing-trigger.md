---
title: "Route records using unified routing | MicrosoftDocs"
description: "Learn how to manually route records using  basic routing for records."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 06/04/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Route records in Customer Service using unified routing

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

After you set up and enable a record for routing, you can manually start the routing for the records using the save and route button on the record forms. As an administrator, you can also route these records automatically using Power Automate. 

## Manually route records

After you enable a record for routing, you see the **Save & Route** option on the form ribbon on the command bar and **Apply Routing rules** on the record view ribbon on the command bar. You can use these commands to route the record.

1. Sign in to your model-driven app.

2. Select a routed record. <br> For example, in this procedure, **Leads** is enabled for routing, and hence, you can see the button in the Leads form command bar.

3. Select **Leads** in the site map, and you can view the **Apply Routing rules**  in the entity view ribbon command bar. Selecting the **Apply Routing rules** button also routes the record.

4. Select a lead record from the **My Open Leads** view.

5. Select **Save & Route** the command bar. The **Route Case** dialog box appears.

6. Select **Route**. The record is routed based on the active routing rule set.

    > [!div class=mx-imgBorder] 
    > ![Manual trigger](media/manual-trigger.png "Manual trigger")

## Automatically route records using Flow

You can set up a custom flow to automatically route records based on conditions, such as when a record is created or updated. Let's see how to set up a custom flow for the create condition.

To enable automatic trigger to route the records:

1. Sign in to Power Automate and select the environment for which you want to update the Flow.

2. Select **My flows** in the site map. Then, select **New flow** and under **Build your own from blank** option, select **Automated cloud flow**.
    The **Build an automated cloud flow** dialog box appears.

3. Select **Skip**. A list of all connectors and triggers is displayed.
    > [!div class=mx-imgBorder]
    > ![List of all connectors and triggers](media/route-trigger1.png "List of all connectors and triggers.")

4. Select **Microsoft Dataverse**, and in the corresponding list of triggers that appears, select **When a row is added, modified or deleted**.

    > [!div class=mx-imgBorder]
    > ![Select When a row is added, modified or deleted trigger](media/route-trigger2.png "Select When a row is added, modified or deleted trigger")

5. Specify the following values in the **When a record is created, updated or deleted** trigger.

<!--
The UI is self-explanatory. The table details are not required.
    | Field | Description | Example Value |
    |-----------------|----------------------------|-----------------------------|
    | Change type | Specify the condition to fire the trigger. That is, when you select a trigger condition, based on this state, the record is routed automatically. <br> <br> The list of possible values are: <ul> <li>Create</li> <li>Create or Delete</li> <li>Create or Update</li> <li>Create or Update or Delete</li> <li>Delete</li> <li>Update</li> <li>Update or Delete</li>| Create |
    | Table name | Specify the entity collection name for which you want to fire the trigger. |  Leads |
    | Scope | Specify where this trigger must be applied. | Organization |
-->

   > [!div class=mx-imgBorder]
   > ![Specify the trigger conditions](media/route-trigger3.png "Specify the trigger conditions")

6. Select **New step**. The **Choose an operation** dialog box appears.

7. Select **Perform an unbound action** from the list. The **Perform an unbound action** dialog box appears.

    > [!div class=mx-imgBorder] 
    > ![Select perform an unbound action](media/route-trigger4.png "Select perform an unbound action")

8. Enter **msdyn_ApplyRoutingRuleEntityRecord** in the **Action Name** field as a custom value.

9. Enter the entity collection name and unique identifier of the record in the specified format against the **Target** field:

    Format: `<entity collection name>(unique identifier of the entity)`
    Example: leads(Lead)

    > [!Note]
    > 1. Open your browser and go to `https://<org_name>/api/data/v9.0/EntityDefinitions(LogicalName='<entityname>')`
    > For example: `https://contoso.dynamics.com/api/data/v9.0/EntityDefinitions(LogicalName='lead')`.
    > 2. Search for `LogicalCollectionName`, and you can view the entity collection name for a particular entity.
    > For example: `"LogicalCollectionName":"leads"`
    > Here, `leads` is the entity collection name.
    
    > [!div class=mx-imgBorder] 
    > ![Select Perform an unbound action example](media/route-trigger4.png "Select Perform an unbound action example")


10. Select **Save**.

Now, based on the flow that is defined, whenever a record, say lead, is created, the flow applies the **ApplyRoutingRuleRecord** action on the record. Similarly, you can create a custom Flow based on your business scenarios.

> [!Note]
> - For case record, an out-of-the-box trigger is shipped to route the cases automatically. The routing is based on the **Route Case** field value in the case record. 
> - If **Route Case** is set to **Yes**, the record will be routed upon creation.
> - If **Route Case** is set to No, the record will not be routed upon creation.
> - By default, for all the cases created from user interface, the **Route Case** field is set to **No**. Hence, the routing for these is not triggered.
> - You can also build a custom flow to automatically trigger routing for cases using any other field per your business scenario, as explained in this topic.

### See also

[Overview of routing](overview-unified-routing.md)  
[Set up routing for records](set-up-record-routing.md)  
[Sample code to trigger routing for non-case records](trigger-routing-non-case-records.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
