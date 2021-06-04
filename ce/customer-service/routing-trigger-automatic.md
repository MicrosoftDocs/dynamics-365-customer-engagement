---
title: "Automatically route records using Flow | MicrosoftDocs"
description: "Learn how to set up custom flow to automatically route records using Power Automate."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 06/04/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Automatically route records in Customer Service using Flow

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Set up custom flow to automatically route records

As an administrator, you can also route records automatically using Power Automate. You can set up a custom flow to automatically route records based on conditions, such as when a record is created or updated. Let's see how to set up a custom flow for the create condition.

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

5. Specify the following values in the **When a row is added, modified or deleted** trigger.

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
    > [!div class=mx-imgBorder] 
    > ![Select Perform an unbound action](media/route-trigger4.png "Select Perform an unbound action")

7. Select **Perform an unbound action** from the **Actions** list. The **Perform an unbound action** dialog box appears.

    > [!div class=mx-imgBorder] 
    > ![Enter custom value](media/route-trigger5.png "Specify Action name")

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
> - If **Route Case** is set to **Yes**, the record is routed upon creation.
> - If **Route Case** is set to **No**, the record is not routed upon creation.
> - By default, for all of the cases created from user interface, the **Route Case** field is set to **No**. So, routing for these cases is not triggered.
> - You can also build a custom flow to automatically trigger routing for cases using any other field per your business scenario, as explained in this topic.

### See also

[Overview of routing](overview-unified-routing.md)  
[Set up routing for records](set-up-record-routing.md)   
[Manually route records](routing-trigger.md#manually-route-records)  
[Sample code to trigger routing for non-case records](trigger-routing-non-case-records.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
