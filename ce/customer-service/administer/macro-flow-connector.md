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

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to Omnichannel for Customer Service and Customer Service workspace.

   :::image type="content" source="../media/macro-flow-connector.png" alt-text="Macro actions for flow connector.":::

#### Run Flow

This action triggers Power Automate flows using macros in agent scripts. This action contains the following fields.

| Field                | Description                             | 
|----------------------|-----------------------------------------|
| Entity logical name | Specify the logical name of the entity that you want to link. This is a mandatory field. Any Microsoft Dataverse entity, such as Account, can be used based on business needs. | 
| Entity record id     | Specify the entity record ID of the entity that you want to link. This is a mandatory field. Ids or slugs, such as {customerRecordId}, can be used. While this field is labeled as entity record id, any value to be processed can be passed. While the field is required, values do not have to be functional unless required for the flow logic. | 
| Select flow         | Specify or select the Power Automate flow to be run by this action. Requires instant cloud flows with *When a record is selected* flow triggers. Existing flows with proper permissions will be detected and displayed in the drop-down list. |   

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |  Executing a flow that uses a Power Platform connector | The following example is a macro that passes the contact record from a case to a Flow. The flow captures the city of the contact and passes to MSN Weather to retrieve the weather. Once the weather is retrieved, Flow proceeds creating a task in Dataverse with the name of the city and weather in Fahrenheit. | <ol><li>Create macro with run flow action with the following attributes: <ul><li>Entity logical name:`Contact`</li><li>Entity record id: `${anchor._customerid_value}`</li><li> SelectFlow: Weatherflow</li></ul></li><li>Flow with the following steps:<ul><li>When a record is selected</li><li>Get current weather</li><li>Add a new row</li></ul></li></ol> |
  
## Power Automate flow permissions

Referenced flows require valid connection and run permissions for the orgnanization tenant and agents that run the flow from within agent scripts. For more information: https://learn.microsoft.com/en-us/sharepoint/dev/business-apps/power-automate/guidance/manage-list-flows  
 
 
### Limitations with Run Flow macro 
 
1. The Run Flow macro does not return a output parameter as a dynamics value to be used in the macro designer. 
1. The "Login to flow" dialog will be displayed requesting user to confirm the process on every macro execution. 

## Using the condition control to implement logic 

The built-in control Condition allows you to implement logic when designing macros. You can select the Condition control from the group Built-in category: 
 
   :::image type="content" source="../media/built-in.png" alt-text="Condition connector.":::

### Example: Check if priority of the case is high 
 
The following example is a macro that checks if the priority of the case is high. If true, then update the Escalated field to Yes. If false, update the description of the case. 

  :::image type="content" source="media/built-in-mini.png" alt-text="Screenshot of Condition." lightbox="media/built-in.png":::


