---
title: Route records automatically using custom flow
description: Learn how to route records automatically by setting up custom flow in Dynamics 365 Customer Service and Omnichannel for Customer Service.
ms.date: 09/27/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Route records automatically using custom flow

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Set up custom flow to automatically route records

As an administrator, you can route records automatically using Power Automate. Set up a custom flow to automatically route records based on certain conditions, such as when a record is created or updated. Let's see how to set up a custom flow for the create condition.

> [!NOTE]
> By default, for all of the cases created from the user interface, the **Route Case** field is set to **No**. So, routing for these cases is not triggered. <br>
> For case records, an out-of-the-box trigger is shipped to route the cases automatically. The routing is based on the **Route Case** field value in the case record.
> When a case record is created, it is either routed or not routed based on the **Route Case** field value of **Yes** or **No**.

To enable automatic routing of records:

1. Sign in to Power Automate and select the environment for which you want to create the flow.

1. Select **My flows** on the site map, then select **New flow**. Under the **Build your own from blank** option, select **Automated cloud flow**.
    The **Build an automated cloud flow** dialog appears.

1. Select **Skip**. A list of all connectors and triggers appears.

1. Select **Microsoft Dataverse**. In the corresponding list of triggers that appears, select **When a row is added, modified or deleted**.

1. Specify the following values for the **Change type**, **Table name**, and **Scope** fields.
 
    - **Change type**: Create
 
    - **Table name**: Email Messages

    - **Scope**: Organization

1. Select **New step**. The **Choose an operation** dialog appears.

1. Select **Perform an unbound action** from the **Actions** list. The **Perform an unbound action** dialog appears.

1. Enter **msdyn_ApplyRoutingRuleEntityRecord** in the **Action Name** field as a custom value.

1. In the **Target** field, select the entity collection name and unique identifier of the record as a parameter as follows.

    `<entity collection name>(<unique_identifier_of_the_entity>)`, such as **emails(`<EmailMessage>`)**

    To get the entity collection name for a particular entity:
    1. Open your browser and go to `https://<org_name>/api/data/v9.0/EntityDefinitions(LogicalName='<entityname>')`.
    For example: `https://contoso.dynamics.com/api/data/v9.0/EntityDefinitions(LogicalName='email')`.
    1. Search for `LogicalCollectionName` to view the entity collection name for a particular entity. <br>
    For example: `"LogicalCollectionName":"emails"`.<br>
    Here, `emails` is the entity collection name.

1. Select **Save**.

Now, based on the flow that is defined, whenever a record, in this example, an email, is created, the flow applies the **msdyn_ApplyRoutingRuleEntityRecord** action to the record. Similarly, you can create a custom flow based on your business scenarios. 

You can also perform other actions in the flow, such as filtering out certain records that you don't want to route and performing data transformation.


### Related information

[Overview of routing](overview-unified-routing.md)  
[Set up routing for records](set-up-record-routing.md)  
[Manually route records](../use/routing-trigger.md)  
[Sample code to trigger routing for non-case records](../develop/trigger-routing-non-case-records.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]  
