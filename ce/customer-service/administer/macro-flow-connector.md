---
title: Use flow connectors
description: Learn how to use flow connector to create macros.
author: gandhamm
ms.author: mgandham
ms.topic: conceptual 
ms.collection: 
ms.date: 05/06/2024
ms.custom: bap-template 
---
# Use flow connectors

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

Flow connectors allow you to trigger Power Automate flows. You can use the actions any number of times across different macros to automate and perform operations related to Omnichannel for Customer Service and Customer Service workspace.

## Power Automate flow permissions

When you use Power Automate flows, make sure that there's a valid connection and agents have adequate permissions to run the flow. See: [Manage owners and users in your Microsoft list flows with Power Automate](/sharepoint/dev/business-apps/power-automate/guidance/manage-list-flows).  
 

> [!NOTE]
> - The **Run Flow** macro doesn't return an output parameter as a dynamic value that can be used in the macro. 
> - You must log in to the flow for each macro run. 

## Run Flow

This action triggers Power Automate flows using macros in agent scripts and has the following fields.

| Field                | Description                             | 
|----------------------|-----------------------------------------|
| Entity logical name | Specify the logical name of the entity that you want to link. Any Microsoft Dataverse entity, such as Account, can be used based on business needs. | 
| Entity record id     | Specify the entity record ID of the entity that you want to link. IDs or slugs, such as `{customerRecordId}`, can be used. While this field is labeled as entity record id, any value to be processed can be passed. While the field is required, values don't have to be functional unless required for the flow logic. | 
| Select flow      | Specify the required Power Automate flow. Requires instant cloud flows with *When a record is selected* flow triggers. Existing flows with proper permissions are displayed in the drop-down list. | 

### Example: Trigger a Power Platform flow

Perform the following steps to create a macro that passes the contact information from a case to a Power Automate flow. The flow retrieves the contact's city and passes it to MSN Weather. Once the weather data is retrieved, the flow creates a task with the name of the city and weather in Fahrenheit. 

1. Add the **run flow** action with the following attributes: 
    - **Entity logical name**:`Contact`
    - **Entity record id**: `${anchor._customerid_value}`
    - **SelectFlow**: Weather flow
1. Add the **When a record is selected** flow definition with the following attributes:
     - **Environment**: Default
     - **Table Name**: Contact
1. Add **Get current weather** with the **Location** set to `Address 1: City` and **Units** set to `Imperial`.
1. Add a new row with the following attributes:
    - **Table name**: Tasks
    - **Subject**: The current temperature today in `Address 1: City` is `Temperature` F.
 
## Use the condition control to implement logic 

You can use the **Condition** control to implement logic in macros. You can select the **Condition** control from the group Built-in category.

  :::image type="content" source="../media/built-in-condition.png" alt-text="Screenshot of Condition.":::
 
### Example: Check if priority of the case is high 
 
The following example is a macro that uses the Condition control to check if the priority of the case is high. If true, the macro updates the **Escalated** field to **Yes**. If **False**, the macro updates the description of the case.

  :::image type="content" source="../media/built-in-mini.png" alt-text="Screenshot of case priority example." lightbox="../media/built-in.png":::

