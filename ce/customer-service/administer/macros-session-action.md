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

You can use session connector actions to perform session-related operations. Session connector macros enables you to add actions such as getting the ID of a tab, refreshing a tab, passing the tab id, setting focus to a tab based on the tab id, opening a tab template, and refreshing session context.

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to a session in Customer Service workspace.

## Get the current tab 

This action gets the details of the current tab in Omnichannel for Customer Service. The action retrieves the Tab ID that could be used in the **Refresh tab** and **Focus tab** actions.

## Refresh the tab

This action refreshes a tab in the Customer Service workspace session. This action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Tab ID | Specify the ID of the tab that you want to refresh. <br> This is a mandatory field.| 

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   | Resolve a case, the get the ID of the tab and then refresh the tab. | The following example is a macro to resolve the case. When resolving a case via macro, the tab is not automatically refreshed. The macro action to get the current tab will store the tab id as a dynamic value can be utilized as parameter for the refresh tab action.| <ol><li> New step: Resolve case with the following attributes: <ul><li>Incident ID: `${anchor.incidentid}`</li><li>Billable time: 0 </li></li>Resolution: `Case ${anchor.ticketnumber} resolved via macros`</li></ul></li><li>New step: Get the current tab</li><li>New step: Refresh the tab with Tab ID set to `Tab ID`</li></ol> |
 
## Focus on the tab

This action focuses on a tab in the Customer Service workspace session. This action contains the following field.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Tab ID | Specify the identifier of the tab that you want to give focus to. <br> This is a mandatory field.|

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   | Create a task from a case, then set focus back to the case form  | The following example is a macro to create a task from a case. However, before opening the form, the ID of the tab is captured. Once the task is created, the tab ID of the case tab is passed as a parameter to the set focus macro.| <ol><li> New step: Get the current tab</li><li>New step: Open a new form to create a record</li><li>New step: Save the record</li><li>New step: Focus on the tab with Tab ID set to `Tab ID`</li></ol> |


#### Open application tab

This action opens the specified application in a new tab with the attributes that you define. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Page type | Specify  the application type to be opened. More information: [Page types](application-tab-templates.md#page-types) <br> This is a mandatory field.  |
   | Application Template ID  | Specify the ID of the application template. <br> This is a mandatory field. |
   | Attribute Name | Specify the attribute logical name you want to update.| 
   | Attribute Value | Specify the attribute value that will be updated for the above-mentioned attribute. | 

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |  Open a tab template based on the tab template unique name. | The following example is a macro to open a tab template passing the tab template unique name as a parameter. Passing unique name is recommended because the unique name of the tab template doesn't change when using solutions to move components from different environments.  | <ul><li> New step: Open application tab with the following attributes: </li><ul><li>Page type: `Entity Record`</li><li>Application Template ID: `new_tabtemplate_customer`</li></ul> |
   | Open a tab template based on the tab template ID | The following example is a macro to open a tab template passing the tab template ID as a parameter.  | <ul><li> New step: Open application tab with the following attributes: </li><ul><li>Page type: `Entity Record`</li><li>Application Template ID</li></ul> |

## Refresh the session context

This action refreshes the session context in Customer Service workspace for entity sessions. For example, if you launch an entity session for a case record, the session context variables will be defined when the session starts. However, if you update the case title, the session context will not be updated. Therefore, macros will use the cached information. You can add the **Refresh the session context** step after starting the macro run to use the latest information.


 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |  Update the case title, then create a task using the updated case title  | The following example is a macro to update the title of a case, then create a task using the new updated case title. However, the session context is created in the cache when the session is initiated. After the case title is updated, the session context cache is outdated. The refresh session context macro will help in this situations. | <ol><li> New step: Update an existing record with the following attributes: </li><ul><li>Entity record ID: `#{anchor.incidentid}`</li><li>Entity logical name: `incident`</li><li>Attribute Name -1: title, Value: `[Backlog]${anchor.title}`</li></ul></li><li>New step: Open a new form to create a record with the following attributes:<ul><li>Entity logical name: `task`</li><li>Attribute Name -1: subject, Value: Task regarding case: `${anchor.title}`</li></ul></li></ol>|

## Set session context 

This action creates a variable in the session context. This is useful when you want to create your own session variables for validating conditions or tracking the navigation of the agent through the agent scripts. 

   | Field | Description | 
   |-----------------|-----------------------------|
   | Attribute Name | Specify the name of the session context variable. This is a mandatory field. | 
   | Attribute Value | Specify the value of the session context variable. This is a mandatory field. | 

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Create a session context variable to track the agent script pathing | The following example is a macro to create a session context variable when an user switches from one agent script to another. Then, uses this session variable context for further macro execution. | <ol><li> New step: Set focus to an agent script with following attributes:<ul>Agent Script Unique Name: `new_agentscript_highpriority`</ul></li><li>New step: Set session context with the following attributes:<ul><li>Attribute Name : `firstProcess`</li><li>Attribute Value: High priority cases</li></ul></li><li>New step: Autofill form with the following attributes:<ul><li>Entity logical name: `incident`</li><li>Attribute Name -1: description, Value : `{firstProcess}`</li></ul></li></ol> |


## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
