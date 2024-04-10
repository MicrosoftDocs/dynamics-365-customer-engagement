---
title: Session connector
description: Learn about using Session connector to create macros
author: gandhamm
ms.author: mgandham
ms.topic: conceptual 
ms.collection: 
ms.date: 04/08/2024
ms.custom: bap-template 
---

# Session connector

You can use session connector actions to perform session-related operations. Session connector macros enable you to add actions such as getting the ID, refreshing a tab, passing the tab id, setting focus to a tab based on the tab id, opening a tab template, and refreshing session context.

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to a session in Customer Service workspace.

## Get the current tab 

This action gets the details of the current tab in Customer Service. The action retrieves the Tab ID that could be used in the **Refresh tab** and **Focus tab** actions.

## Refresh the tab

This action refreshes a tab in the Customer Service workspace session. This action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Tab ID | Specify the ID of the tab that you want to refresh. <br> This is a mandatory field.| 

### Examples

| Scenarios | Attribute |
|-----------|-----------|
| Create a macro to resolve a case, get the ID, and then refresh the tab. | <ol><li> Add the **Resolve case** productivity action with the following attributes: <ul><li>**Incident ID**: `${anchor.incidentid}`</li><li>**Billable time**: 0</li><li>**Resolution**: `Case ${anchor.ticketnumber} resolved via macros`</li></ul></li><li> Add the **Get the current tab** action to get the current tab and store the tab id as a dynamic value.</li><li>Add the **Refresh the tab** action to set the Tab ID to the dynamic value obtained in the previous step. The following are the attributes: <br> **Tab ID**: `Tab ID`</li></ol> |
 
## Focus on the tab

This action focuses on a tab in the Customer Service workspace session. This action contains the following field.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Tab ID | Specify the identifier of the tab that you want to give focus to. <br> This is a mandatory field.|

### Examples

   | Scenarios | Attribute|
   |-----------------|---------------------------------|
   | Create a macro that creates a task from a case and sets focus back to the case form  | <ol><li> Add the **Get the current tab** action. This action copies the Tab ID of the case.</li><li>Add the **Open a new form to create a record** productivity action to create a new task from the case. </li><li>Add the **Save the record** productivity action</li><li> Add the **Focus on the tab** action with Tab ID set to `Tab ID`. This sets the focus back to the original tab, that is the case.</li></ol> |


#### Open application tab

This action opens the specified application in a new tab with the attributes that you define. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Page type | Specify  the application type to be opened. More information: [Page types](application-tab-templates.md#page-types) <br> This is a mandatory field.  |
   | Application Template ID  | Specify the ID of the application template. <br> This is a mandatory field. |
   | Attribute Name | Specify the attribute logical name you want to update.| 
   | Attribute Value | Specify the attribute value that will be updated for the above-mentioned attribute. | 

### Examples

 | Scenarios | Attribute|
   |-----------------|---------------------------------|
   | Create a macro that opens a tab template passing the tab template's unique name as a parameter and open a tab template based on the tab template's unique name.  | Add the **Open application tab** action with the following attributes: <ul><li>**Page type**: `Entity Record`</li><li>**Application Template ID** :`new_tabtemplate_customer`</li></ul> |


> [!NOTE]
> We recommend you use the unique name because it doesn't change when you use solutions to move components from different environments. 

## Refresh the session context

This action refreshes the session context in Customer Service workspace for entity sessions. For example, if you launch an entity session for a case record, the session context variables will be defined when the session starts. However, if you update the case title, the session context will not be updated. Therefore, macros will use the cached information. You can add the **Refresh the session context** step after starting the macro run to use the latest information.


 | Scenarios | Attribute|
   |-----------------|---------------------------------|
   |Create a macro that updates the case title and then creates a task using the new updated case title.| <ol><li> Add the **Update an existing record** productivity action with the following attributes: </li><ul><li>**Entity record ID**: `#{anchor.incidentid}`</li><li>**Entity logical name**: `incident`</li><li>**Attribute Name**: title, **Attribute Value**: `[Backlog]${anchor.title}`</li></ul></li><li>Add the **Refresh the session context** action to refresh the session context cache after the case title is updated.</li><li> Add the **Open a new form to create a record** action with the following attributes:<ul><li>**Entity logical name**: `task`</li><li>**Attribute Name**: subject, **Attribute Value**: Task regarding case: `${anchor.title}`</li></ul></li></ol>|

## Set session context 

This action creates a variable in the session context. This is useful when you want to create your own session variables for validating conditions or tracking the navigation of the agent through the agent scripts. 

   | Field | Description | 
   |-----------------|-----------------------------|
   | Attribute Name | Specify the name of the session context variable. This is a mandatory field. | 
   | Attribute Value | Specify the value of the session context variable. This is a mandatory field. | 

### Examples

   | Scenarios | Attribute|
   |-----------------|---------------------------------|
   |Create a macro that creates a session context variable when a user switches from one agent script to another and then, uses this session variable context for further macro execution. | <ol><li> Add the **Set focus to an agent script** with following attributes:<ul>**Agent Script Unique Name**: `new_agentscript_highpriority`</ul></li><li> Add the **Set session context** action with the following attributes:<ul><li>**Attribute Name**: `firstProcess`</li><li>**Attribute Value**: High priority cases</li></ul></li><li>Add the **Autofill form** action with the following attributes:<ul><li>**Entity logical name**: `incident`</li><li>**Attribute Name**: description, **Attribute Value**: `{firstProcess}`</li></ul></li></ol> |


## Next steps

[Flow connector](macro-flow-connector.md)