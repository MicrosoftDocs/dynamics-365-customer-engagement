---
title: Review macros
description: Learn about reviewing macros
author: gandhamm
ms.author: mgandham
ms.topic: conceptual 
ms.collection: 
ms.date: 04/08/2024
ms.custom: bap-template 
---
# Review macros

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to Omnichannel for Customer Service and Customer Service workspace.

   :::image type="content" source="../media/macro-flow-connector.png" alt-text="Macro actions for flow connector.":::

## View macro run history

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../../includes/cc-omnichannel-administration-deprecation-note.md)]

As an administrator, you can view the macro run history, which shows how many times a macro has been run, along with the success or fail status. When you select a macro that failed, you can view the exact action step at which the failure occurred.

1. Consider the following agent script step that fails to execute:
    :::image type="content" source="../media/  agent-script-failure.png" alt-text="Agent script failing.":::
1. Go to Customer Service admin center, then go to **Productivity**, then open **Agent scripts**. 
1. Open the target Agent script based on the image above. Example: High Priority. 
1. In the list of Agent scripts steps, open the target agent script step. Example: Create task. 
1. In the Target macro, click the macro record to open the macro in the designer. 
1. Click View history. Each record in the list represents a macro execution. 
1. Open the macro execution that failed. 

Identify the step that failed.  
 
In certain scenarios, a step fails because a previous step incorrectly set values or has missing values. Review your macro actions, attributes names and attribute values from the clicking on a step from the macro history log:

   :::image type="content" source="../media/macro-history-log.png" alt-text="View the run history for a macro.":::

## Reviewing session context variables 
 
As an administrator, you can review the macro execution history to validate if the session context variables were configured correctly in the macro design. However, another approach to validate if the session context variable is correct and returning the expected value is to use the Microsoft.Apm APIs. 
 
1. Open Customer Service workspace 
2. Launch a session that the macro will be executed. Example: Open a case from the Home session. 
3. Press the F12 key to open the developer tools window. 
4. In the console window, type the following command and press Enter: `Microsoft.Apm.getFocusedSession().resolveSlug("{anchor.title")`. 

5. Replace the session variable based on your preference. Remove the $ sign typically used in the macro designer. 

Review the results in the browser console. 
 
## Working with lookups and session context 
 
Due to product limitations, setting lookup values have different patterns based on the macro being utilized. You can review the patterns from the examples below and replace the session context variable based on your requirements.  
 
For macros that sets values on a form field such as Autofill form fields, you can use the following pattern for lookup fields. 
 
Attribute name:  `regardingobjectid `
Attribute value:  `[{"id": "${anchor.incidentid}","name": "${anchor.title}","entitytype": "incident"}]  `

For macros that sets values on a form field such as Autofill form fields, you can use the following patterns for activity party fields. 
 
Attribute name:  `to `
Attribute value: `[ {"id":"${anchor._customerid_value}","type":"${anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}","name":"${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}"}, {"id":"${anchor._cr27b_secondarycontact_value}","type":"contact","name":"${anchor._cr27b_secondarycontact_value@OData.Community.Display.V1.FormattedValue}"}] `

 

For macros that open forms by pre-populating the field such as Open a new form to create a record, you can use the following patterns for lookup: 

 

Attribute name 1: `regardingobjectid `
Attribute value 1: `${anchor.incidentid}` 
Attribute name 2: `regardingobjectidtype `
Attribute value 2: `incident` 
Attribute name 3: `regardingobjectidname` 
Attribute value 3:`${anchor.title} `
 
For macros that updates records such as Updating an existing record, you can use the following pattern for lookups: 


Attribute name 1: `regardingobjectid_incident@odata.bind `

Attribute value 1: `/incidents(${anchor.incidentid}) `

## Reporting 

Macros execution is logged in a table in Dataverse that is utilized for troubleshooting purposes. If your organization needs to create reports to capture metrics such as usage of each macro by user in a given timeframe or success/failure rate, you can create reports based on the following table: [msdyn_macrosession](../develop/reference/entities/msdyn_macrosession.md)  
