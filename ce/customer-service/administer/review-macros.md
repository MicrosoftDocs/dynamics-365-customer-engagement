---
title: Review macro execution history
description: Review macro execution history to identify causes of failure and view exact action step at which failure occurred.
author: gandhamm
ms.author: mgandham
ms.topic: conceptual
ms.collection:
ms.date: 04/08/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:04/10/2024
  - ai-gen-desc
---

# Review macro execution history

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../../includes/cc-omnichannel-administration-deprecation-note.md)]

Macros offer a log of executions that you can review and identify causes of failure. As an administrator, you can view the macro run history, which shows how many times a macro has been run, along with the success or fail status. When you select a macro that failed, you can view the exact action step at which the failure occurred.

**View macro run history**

Consider the following agent script step that fails to execute:
    :::image type="content" source="../media/  agent-script-failure.png" alt-text="Agent script failing.":::
To view the run history for the macro that failed, follow these steps:

1. Go to Customer Service admin center, select **Productivity** > **Agent scripts**.  
1. On the Agent scripts page, select the required agent script.
1. In the list of **Agent scripts steps**, open the required target **agent script step**. 
1. In the Target macro, select the macro. 
1. Select **View history**. Each record in the list represents a macro execution. 
1. Open the macro execution that failed and identify the step that failed.  
 
In certain scenarios, a step fails because a previous step incorrectly set values or has missing values. Review your macro actions, attributes names and attribute values from the clicking on a step from the macro history log:

   :::image type="content" source="../media/macro-history-log.png" alt-text="View the run history for a macro.":::

### Review session context variables 
 
As an administrator, you can review the macro execution history to validate if the session context variables are configured correctly in the macro design. You can also validate if the session context variable is correct and returning the expected value using the [Microsoft.Apm APIs](../develop/microsoft-apm). 
 
1. Open Customer Service workspace.
2. Open a session that executes a macro. For example, open a case from the Home session. 
3. Press the F12 key to open the developer tools window. 
4. In the console window, specify the following command and press Enter: `Microsoft.Apm.getFocusedSession().resolveSlug("{anchor.title")`. 

5. Replace the session variable based on your preference. Remove the $ sign typically used in the macro designer. 

Review the results in the browser console. 
 
## Working with lookups and session context 

Configuring lookup values have different patterns based on the macro being utilized. You can review the patterns from the examples below and replace the session context variable based on your requirement.  


- For macros that populate form fields, such as **Autofill form** fields, you can use the following patterns:
  - lookup fields:
       - Attribute name:  `regardingobjectid ` 
       - Attribute value:  `[{"id": "${anchor.incidentid}","name": "${anchor.title}","entitytype": "incident"}]  `
  - activity party fields: 
      - Attribute name:  `to `
     - Attribute value: `[ {"id":"${anchor._customerid_value}","type":"${anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}","name":"${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}"}, {"id":"${anchor._cr27b_secondarycontact_value}","type":"contact","name":"${anchor._cr27b_secondarycontact_value@OData.Community.Display.V1.FormattedValue}"}] `
- For macros that open forms by pre-populating the field such as **Open a new form to create a record**, you can use the following patterns for lookup: 

  - Attribute name: `regardingobjectid `
  - Attribute value: `${anchor.incidentid}` 
  - Attribute name: `regardingobjectidtype `
  - Attribute value: `incident` 
  - Attribute name: `regardingobjectidname` 
  - Attribute value:`${anchor.title} `
- For macros that updates records such as **Updating an existing record**, you can use the following pattern for lookups: 
  - Attribute name: `regardingobjectid_incident@odata.bind `
  - Attribute value: `/incidents(${anchor.incidentid}) `

## Reporting 

Macros execution is logged in a table in Dataverse that is utilized for troubleshooting purposes. If your organization needs to create reports to capture metrics such as usage of each macro by user in a given time frame or success/failure rate, you can create reports based on the following table: [msdyn_macrosession](../develop/reference/entities/msdyn_macrosession.md)  
