---
title: Configure macros to improve agent productivity
description: This article provides information about the different macros that can be made available to agents and how to configure them in app profile manager.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 05/23/2024
ms.topic: how-to
ms.custom: bap-template
---

# Configure macros to improve agent productivity

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

In the customer service industry, agents have to click often to perform simple tasks, such as open a form, fill, and save it, and many repetitive and monotonous actions, such as greeting and verifying a customer, sending acknowledgment mail, and taking notes. These clicks and repetitive tasks can lead to human errors when agents copy and paste the data across different operations.

Macros are a set of sequential actions that a user performs. They enable users to perform daily operations efficiently in a fast and process-compliant manner. You can reuse macros with different sessions based on the context parameters that are specific to the session.

## Prerequisites

- Make sure that you have the **Productivity tools administrator**  or **System Administrator** security role to design macros.

- Make sure that agents and supervisors are assigned the **Productivity tools user** or **Customer Service representative** security role.

More information: [Assign roles and enable users](../implement/add-users-assign-roles.md)

## Create macros

Perform the following steps to create a macro in Customer Service admin center:
1. Go to **Productivity** in **Agent experience**. 
2. Select **Manage** for **Macros**. 
3. Select **New**. 
1. In the **Macros** page, specify a name and description for the macro.

Make sure you always begin the creation of any macro with the **Start macro execution** step.

### Trigger macros

The following actions can trigger a macro:

- Agents can run [macros](../use/oc-agent-scripts.md#macro) from the **Productivity** pane in the Customer Service workspace app.
- An [API](../develop/reference/methods/runMacro.md) call


## Predefined automation actions

You can use the following predefined automation actions to create macros:

- [Productivity automation](macros-productivity-automation.md): Provides actions to perform model-driven app operations. You can use these actions to automate the following tasks:
- open and update records
- open views
- resolve cases
- search knowledge base
- clone records
- set focus to another agent script
- open email templates
- auto fill form fields
- set and retrieve variables and values in the session context

- [Session connector](macros-session-action.md): Provides actions to perform session-related operations. You can use these actions to get the ID of a tab, refresh a tab, pass the tab ID, set focus to a tab based on the tab ID, open a tab template, and refresh session context.

- [Omnichannel connector](macros-omnichannel-action.md): Provides actions to perform Omnichannel for Customer Service&ndash;related operations. Omnichannel connector macros allow you to link and unlink records to conversations.

- [Flow connector](macro-flow-connector.md): Allows you to trigger a Power Automate flow.

## Pass session context variables to macros

In a macro, you can pass dynamic values such as customer name or customer ID as parameters to the macro. The information is stored in the session context as a key-value pair. A session context variable is also known as a [slug](automation-dictionary-keys.md#slugs). 

When an agent opens a case, conversation, or another tab in the session, the session context is populated as follows:
 
- **Case**: The case is the anchor tab or the first tab of the session. The session context is populated with the attributes and values from the case record and is stored in the browser memory. Examples of session context variables populated from the case record as follows:  

   `${anchor.incidentid}`: 6194b723-7e5f-eb11-a812-000d3a1a658a  
   `${anchor.ticketnumber}`: CAS-47732-V4V6K6  
   `${anchor.title}`: A Mineral Build Up in Water Supply  
   `${anchor.createdon}`: 2022-12-14T23:03:24Z  
   `${anchor.prioritycode}`: 2  
   `${anchor.prioritycode@OData.Community.Display.V1.FormattedValue}`: Normal   
   `${anchor._customerid_value}`: f5973462-768e-eb11-b1ac-000d3ae92b46   
   `${anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}`: contact   
   `${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}`: Claudia Mazzanti   

  > [!NOTE]
  > The session context is populated with values from the anchor tab only.

 You can also retrieve a value from a related record using an oData query. For example, you can use the following oData query to retrieve the email address from the customer record on a case: `${$odata.contact.emailaddress1.?$filter=contactid eq '{anchor._customerid_value}'} `.

- **Conversations**: The session context is populated with the conversation attributes from the channel provider and is stored in the browser cache. For example, the session context variables are populated as follows for an incoming chat conversation:  

   `${Email}` : claudiamazzanti@crmdemo.dynamics.com 
   `${LiveWorkItemId}` : 57e4323e-a93f-4c30-b8e8-b075ab5d71cc  
   `${customerEntityName}` : contact  
   `${customerName}` : Claudia Mazzanti  
   `${customerRecordId}` : f5973462-768e-eb11-b1ac-000d3ae92b46  
   `${queueId}`: 6b189e87-e09b-eb11-b1ac-000d3af4e3f9  
   `${visitorLanguage}` : en-us  

 You can also retrieve a value from a related record using oData query. For example, you can retrieve the email address from the customer record on a case with this query,`${$odata.contact.emailaddress1.?$filter=contactid eq '{customerRecordId}'} `.

- **Additional tabs**: Records open in the additional tabs of the same session aren't used in the session context. However, you can access the name of the entity and the entity record ID as follows: 
 
    `${Session.CurrentTab.entityId}` : 11bb11bb-cc22-dd33-ee44-55ff55ff55ff 
    `${Session.CurrentTab.entityName}` : account 
  With the entity ID, you can retrieve other values in the record through the following oData query `${$odata.account.name.?$filter=accountid eq '{Session.CurrentTab.entityId}'}`

## Next Steps
[Use Productivity automation to create macros](macros-productivity-automation.md)  
[Use session connector to create macros](macros-session-action.md)  
[Use omnichannel connector to create macros](macros-omnichannel-action.md)    
[Flow connector](macro-flow-connector.md)  
    
### Related information

[Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md)  
[Agent scripts](agent-scripts.md)  
[Smart Assist](smart-assist.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
