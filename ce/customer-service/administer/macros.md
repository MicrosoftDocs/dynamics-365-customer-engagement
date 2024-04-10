---
title: Configure macros to improve agent productivity
description: "This topic provides information about the different macros that can be made available to agents and how to configure them in app profile manager."
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 06/16/2023
ms.topic: how-to
ms.custom: bap-template
---

# Configure macros to improve agent productivity

In the customer service industry, agents have to click often to perform simple tasks, such as open a form, fill, and save it, and many repetitive and monotonous actions, such as greeting and verifying a customer, sending acknowledgment mail, and taking notes. These clicks and repetitive tasks can lead to human errors when agents copy and paste the data across different operations.

Macros are a set of sequential actions that are performed by a user. They enable users to perform daily operations efficiently in a fast and process-compliant manner. You can reuse macros with different sessions based on the context parameters that are specific to the session.


## Prerequisites

- Make sure that you have the **Productivity tools administrator**  or **System Administrator** security role to design macros.

- Make sure that agents and supervisors are assigned the **Productivity tools user** or **Customer Service representative** security role to execute macros.

More information: [Assign roles and enable users](../implement/add-users-assign-roles.md)

## Create a Macro

Perform the following steps to create a macro in Customer Service admin center:
1. Go to **Productivity** in **Agent experience**. 
2.  Select **Manage** for **Macros**. 
3. Select **New**. In the **Macros** page, specify a name and description for the macro. The first step for the macro is always **Start macro execution**.

### Trigger macros

A macro can be triggered as follows:

- Agents can run [macros](../use/oc-agent-scripts.md#macro) from the **Productivity** pane in the Customer Service workspace app.
- Through an [API](../develop/reference/methods/runMacro.md)

For more information on agent experience profiles, session templates, agent script, agent script steps and macros, download the Customer Service workspace in a day training.


## Predefined automation actions

In Customer Service, macros provide three connectors:

- [Productivity automation](macros-productivity-automation.md): Provides actions to perform model-driven app operations. Productivity automation macros allow you to automate tasks such as opening and updating records, opening views, resolving cases, searching the knowledge base, record cloning, setting focus to another agent script, opening email templates, auto filling form fields, setting and retrieving variables and values in the session context.

- [Session connector](macros-session-action.md): Provides actions to perform session-related operations. Session connector macros enables you to add actions such as getting the ID of a tab, refreshing a tab, passing the tab id, setting focus to a tab based on the tab id, opening a tab template, and refreshing session context.

- [Omnichannel connector](macros-omnichannel-action.md): Provides actions to perform Omnichannel for Customer Service&ndash;related operations.  Omnichannel connector macros allow you to link and unlink records to conversations.

- Flow connector: Allows you to execute a Power Automate flow.

## Pass session context variables to macros

In a macro, you can pass dynamic values such as customer name or customer id as parameters during the macro execution. The information is stored in the session context as a key value pair. A session context variable is also known as a [slug](automation-dictionary-keys.md#slugs). 
 

### Records 

When you open a case as a session, the case is the "anchor tab" or the first tab of the session. The session context is populated with the attributes and values from the case record and is stored in the browser memory. For example, if a case is open as the anchor tab, the session context variables are populated as follows:  

`${anchor.incidentid} : 6194b723-7e5f-eb11-a812-000d3a1a658a `
`${anchor.ticketnumber} : CAS-47732-V4V6K6 `
`${anchor.title} : A Mineral Build Up in Water Supply` 
`${anchor.createdon} : 2022-12-14T23:03:24Z `
`${anchor.prioritycode} : 2` 
`${anchor.prioritycode@OData.Community.Display.V1.FormattedValue} : Normal` 
`${anchor._customerid_value} : f5973462-768e-eb11-b1ac-000d3ae92b46 `
`${anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname} : contact `
`${anchor._customerid_value@OData.Community.Display.V1.FormattedValue} : Claudia Mazzanti `


> [!NOTE]
> The session context is populated with values from the anchor tab only.

You can also retrieve a value from a related record using an oData query. For example, you can use the following oData query to retrieve the email address from the customer record on a case: 
 
`${$odata.contact.emailaddress1.?$filter=contactid eq '{anchor._customerid_value}'} `

### Conversations 

When an agent accepts an incoming call or chat, the session context is populated with the conversation attributes from the channel provider and stored in the browser cache. For example, the session context variables are populated as follows for an incoming chat conversation:  

`${Email} : claudiamazzanti@crmdemo.dynamics.com `

`${LiveWorkItemId} : 57e4323e-a93f-4c30-b8e8-b075ab5d71cc `
`${customerEntityName} : contact `
`${customerName} : Claudia Mazzanti `
`${customerRecordId} : f5973462-768e-eb11-b1ac-000d3ae92b46 `
`${queueId} : 6b189e87-e09b-eb11-b1ac-000d3af4e3f9 `

`${visitorLanguage} : en-us `

 

You can also retrieve a value from a related record using oData query. For example, you can retrieve the email address from the customer record on a case as follows:

`${$odata.contact.emailaddress1.?$filter=contactid eq '{customerRecordId}'} `


### Additional tabs 

When an agent opens an entity record, the session context is populated with attributes from the record in the anchor tab. Records open in the additional tabs of the same session aren't used in the session context. However, you can access the name of the entity and the entity record id as fillows: 
 
`${Session.CurrentTab.entityId} : 0e8642d7-c2ae-ea11-a812-000d3a1b14a2 `
`${Session.CurrentTab.entityName} : account `
With the entity id, you can retrieve other values in the record through the following oData query: 
 
`${$odata.account.name.?$filter=accountid eq '{Session.CurrentTab.entityId}'}`

## Next Steps
[Use Productivity automation to create macros](macros-productivity-automation.md)  
[Use session connector to create macros](macros-session-action.md)  
[Use omnichannel connector to create macros](macros-omnichannel-action.md)    
[Flow connector](macro-flow-connector.md)  
    


### See also

[Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md)  
[Agent scripts](agent-scripts.md)  
[Smart Assist](smart-assist.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
