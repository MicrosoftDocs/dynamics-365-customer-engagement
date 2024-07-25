---
title: Use session connector macros
description: Learn how to use session connector to create macros.
author: gandhamm
ms.author: mgandham
ms.topic: conceptual 
ms.collection: 
ms.date: 05/06/2024
ms.custom: bap-template 
---

# Use session connector macros

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

You can use session connector actions to perform session-related operations. Session connector macros enable you to add actions such as getting the ID, refreshing a tab, passing the tab ID, setting focus to a tab based on the tab ID, opening a tab template, and refreshing session context.

You can use the actions any number of times across different macros to automate and perform operations related to a session in Customer Service workspace.

## Get the current tab 

This action gets the details of the current tab in Customer Service. The action retrieves the Tab ID that could be used in the **Refresh tab** and **Focus tab** actions.

## Refresh the tab

Refreshes a tab in the Customer Service workspace session. This action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Tab ID | Specify the ID of the tab that you want to refresh. <br> This is a mandatory field.| 

### Example: Resolve a case, get tab ID, and refresh the tab

Perform the following steps to create a macro to resolve a case, get the ID, and then refresh the tab. Add the following actions to the macro:

1. **Resolve case** with the following attributes: 
    - **Incident ID**: `${anchor.incidentid}`
    - **Billable time**: 0
    - **Resolution**: `Case ${anchor.ticketnumber} resolved via macros`
1. **Get the current tab** to get the current tab and store the tab id as a dynamic value.
1. **Refresh the tab** to set the tab ID to the dynamic value obtained in the previous step with the **Tab ID** set to `Tab ID`.
 
## Focus on the tab

Enables you to focus on a tab in the Customer Service workspace session. This action contains the following field.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Tab ID | Specify the identifier of the tab that you want to give focus to. <br> This is a mandatory field.|

### Example: Create a task from a case, then set focus back to the case form

Perform the following steps to create a macro that creates a task from a case and sets focus back to the case form. Add the following actions to the macro:
1. **Get the current tab** to copy the Tab ID of the case.
1. **Open a new form to create a record** to create a new task from the case. 
1. **Save the record** 
1. **Focus on the tab** with Tab ID set to `Tab ID`. This sets the focus back to the original case tab.


#### Open application tab

Opens the specified application in a new tab with the attributes you define. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Page type | Specify  the application type to be opened. More information: [Page types](application-tab-templates.md#page-types).  |
   | Application Template ID  | Specify the ID of the application template.|
   | Attribute Name | Specify the attribute logical name you want to update.| 
   | Attribute Value | Specify the attribute value that is updated for the above-mentioned attribute. | 

### Example: Open a tab template based on the tab template unique name

To create a macro that opens a tab template passing the tab template's unique name as a parameter and open a tab template based on the tab template's unique name, Add the **Open application tab** action with the following attributes: 
 - **Page type**: `Entity Record`
 - **Application Template ID** : bde86e2f-6bd1-48a9-baf9-dae720aa9f45

 
## Refresh the session context

Refreshes the session context in Customer Service workspace for entity sessions. For example, if you launch an entity session for a case record, the session context variables are defined when the session starts. However, if you update the case title, the session context isn't updated. Therefore, macros use the cached information. You can add the **Refresh the session context** step after starting the macro run to use the latest information.

### Example: Update the case title and then create a task with the updated case title 

Perform the following steps to create a macro that updates the case title and then creates a task using the new updated case title:
1. Add the **Update an existing record** productivity action with the following attributes:
    - **Entity record ID**: `#{anchor.incidentid}`
    - **Entity logical name**: `incident`
    - **Attribute Name**: title
    - **Attribute Value**: `[Backlog]${anchor.title}`
1. Add the **Refresh the session context** action to refresh the session context cache after the case title is updated.
1. Add the **Open a new form to create a record** action with the following attributes:
      - **Entity logical name**: `task`
      - **Attribute Name**: subject
      - **Attribute Value**: Task regarding case: `${anchor.title}`

## Set session context 

Creates a variable in the session context. Use the action to create your own session variables to validate conditions or track how agents navigate through agent scripts. 

   | Field | Description | 
   |-----------------|-----------------------------|
   | Attribute Name | Specify the name of the session context variable.  | 
   | Attribute Value | Specify the value of the session context variable. | 

### Example: Create a session context variable to track the agent script path 

Perform the following tasks to add a workflow that creates a session context variable when a user switches from one agent script to another and then, uses the session variable context for further macro runs:
1. Add **Set focus to an agent script** with the **Agent Script Unique Name** attribute set to `new_agentscript_highpriority`.
1. Add the **Set session context** action with the following attributes:
    - **Attribute Name**: `firstProcess`
    - **Attribute Value**: High priority cases
1. Add the **Autofill form** action with the following attributes:
     - **Entity logical name**: `incident`
     - **Attribute Name**: description
     - **Attribute Value**: `{firstProcess}`

## Next steps

[Flow connector](macro-flow-connector.md)