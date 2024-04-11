---
title: Flow connector
description: Learn about using flow connector to create macros
author: gandhamm
ms.author: mgandham
ms.topic: conceptual 
ms.collection: 
ms.date: 04/08/2024
ms.custom: bap-template 
---
# Flow connector

Flow connectors allow you to execute Power Automate flows. As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to Omnichannel for Customer Service and Customer Service workspace.


## Run Flow

This action triggers Power Automate flows using macros in agent scripts. This action contains the following fields.

| Field                | Description                             | 
|----------------------|-----------------------------------------|
| Entity logical name | Specify the logical name of the entity that you want to link. This is a mandatory field. Any Microsoft Dataverse entity, such as Account, can be used based on business needs. | 
| Entity record id     | Specify the entity record ID of the entity that you want to link. This is a mandatory field. Ids or slugs, such as {customerRecordId}, can be used. While this field is labeled as entity record id, any value to be processed can be passed. While the field is required, values do not have to be functional unless required for the flow logic. | 
| Select flow      | Specify or select the Power Automate flow to be run by this action. Requires instant cloud flows with *When a record is selected* flow triggers. Existing flows with proper permissions will be detected and displayed in the drop-down list. | 

### Example: Execute a flow that uses a Power Platform connector 

Perform the following steps to create a macro that passes the contact record from a case to a Power Automate flow. The flow captures the city of the contact and passes to MSN Weather to retrieve the weather. Once the weather is retrieved, the flow creates a task in Dataverse with the name of the city and weather in Fahrenheit. 

1. Add the **run flow** action with the following attributes: 
    - **Entity logical name**:`Contact`
    - **Entity record id**: `${anchor._customerid_value}`
    - **SelectFlow**: Weatherflow
1. Add the **When a record is selected** flow definition with the following attributes:
     - **Environment**: Default
     - **Table Name**: Contact
1. Add **Get current weather** with the **Location** set to `Address 1: City` and **Units** set to `Imperial`.
1. Add a new row with the following attributes:
    - **Table name**: Tasks
    - **Subject**: The current temperature today in `Address 1: City` is `Temperature` F.
  
## Power Automate flow permissions

When using Power Automate flows, make sure that there's a valid connection and agents that run the flow from within agent scripts have run permissions for the flow. For more information: [Manage owners and users in your Microsoft list flows with Power Automate](/sharepoint/dev/business-apps/power-automate/guidance/manage-list-flows).  
 
 
## Use the condition control to implement logic 

The built-in control condition allows you to implement logic when designing macros. You can select the Condition control from the group Built-in category.

  :::image type="content" source="../media/built-in-condition.png" alt-text="Screenshot of Condition.":::
 

### Example: Check if priority of the case is high 
 
The following example is a macro that checks if the priority of the case is high. If true, the macro updates the **Escalated** field is set to **Yes**. If **False**, the macro updates the description of the case. 

  :::image type="content" source="../media/built-in-mini.png" alt-text="Screenshot of case priority example." lightbox="../media/built-in.png":::

### Limitations with Run Flow macro 
 
- The Run Flow macro doesn't return an output parameter as a dynamic value that can be used in the macro. 
- You must login to the flow for every macro execution. 
