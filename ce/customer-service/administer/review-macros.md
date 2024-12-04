---
title: Review macro run history
description: Review macro run history to identify causes of failure and view exact action step at which failure occurred.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: conceptual
ms.collection:
ms.date: 05/06/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:04/10/2024
  - ai-gen-desc
---

# Review macro run history

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

You can view the macro run history, which shows how many times a macro ran, along with the success or fail status. When you select a macro that failed, you can view the exact action step at which the failure occurred, allowing you to identify why the failures occurred.

## View macro run history

Consider the following agent script step that fails.

 :::image type="content" source="../media/agent-script-failure.png" alt-text="Agent script failing.":::

To view the run history for the macro that failed, follow these steps:

1. Go to Customer Service admin center, select **Productivity** > **Agent scripts**.  
1. On the Agent scripts page, select the required agent script.
1. In the list of **Agent scripts steps**, open the required target **agent script step**. 
1. In the Target macro, select the macro. 
1. Select **View history**. Each record in the list represents a macro run. 
1. Open the macro that failed and identify the step that failed.  
 
In certain scenarios, a step fails because a previous step has set values incorrectly or has missing values. Select a step from the macro history to review your macro actions, attribute names, and attribute values.

 :::image type="content" source="../media/macro-history-log.png" alt-text="View the run history for a macro.":::

### Review session context variables 
 
You can review the macro run history to validate if the session context variables are configured correctly in the macro design. You can also validate if the session context variable is correct and returning the expected value using the [Microsoft.Apm APIs](../develop/microsoft-apm.md). 
 
1. Open Customer Service workspace.
2. Open a session that triggers a macro run. For example, open a case from the **Home** session. 
3. Press the F12 key to open the developer tools window. 
4. In the console window, specify the following command and press Enter: `Microsoft.Apm.getFocusedSession().resolveSlug("{anchor.title")`
5. Replace the session variable based on your preference. Remove the $ sign typically used in the macro designer. 

Review the results in the browser console. 
 
## Use lookups and session context 

You can use multiple patterns to configure lookup based on the macros you want to use. You can review the patterns from the following examples and replace the session context variable based on your requirement.  

- For macros that populate form fields, such as **Autofill form** fields, you can use the following patterns:
  - lookup fields:
       - Attribute name:  `regardingobjectid ` 
       - Attribute value:  `[{"id": "${anchor.incidentid}","name": "${anchor.title}","entitytype": "incident"}]  `
  - activity party fields: 
      - Attribute name:  `to `
     - Attribute value: `[ {"id":"${anchor._customerid_value}","type":"${anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}","name":"${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}"}, {"id":"${anchor._cr27b_secondarycontact_value}","type":"contact","name":"${anchor._cr27b_secondarycontact_value@OData.Community.Display.V1.FormattedValue}"}] `
- For macros that open forms by prepopulating the field such as **Open a new form to create a record**, you can use the following patterns for lookup: 

  - Attribute name: `regardingobjectid `
  - Attribute value: `${anchor.incidentid}` 
  - Attribute name: `regardingobjectidtype `
  - Attribute value: `incident` 
  - Attribute name: `regardingobjectidname` 
  - Attribute value:`${anchor.title} `
- For macros that updates records such as **Updating an existing record**, you can use the following pattern for lookups: 
  - Attribute name: `regardingobjectid_incident@odata.bind `
  - Attribute value: `/incidents(${anchor.incidentid}) `

## Macro run reports

Macro runs are logged in the [msdyn_macrosession](../develop/reference/entities/msdyn_macrosession.md) table. You can use this table to create reports that capture metrics such as macro usage in a given time frame or success and failure rate.

