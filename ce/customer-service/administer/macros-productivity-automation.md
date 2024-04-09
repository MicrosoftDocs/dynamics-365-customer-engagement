---
title: Productivity automation 
description: Learn about productivity automation macros in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: 
ms.topic: conceptual 
ms.collection: 
ms.date: 04/08/2024
ms.custom: bap-template 
---


# Productivity automation

 Productivity automation macros allow you to automate tasks such as opening and updating records and views, resolving cases, searching the knowledge base, record cloning, setting focus to another agent script, opening email templates, auto filling form fields, setting and retrieving variables and values in the session context. As an administrator, you can use the productivity automation actions any number of times across different macros to automate and perform model-driven app operations.

## Open a new form to create a record

This action is used to open a new form to create a record. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to open.<br> This is a mandatory field. |  
   | Entity form ID | Specify the form ID.<br> This is an optional field. |
   | Attribute Name | Specify the attribute logical name. You need to provide the attribute name to prepopulate the field with a value.| 
   | Attribute Value | Specify the attribute value. You need to provide the attribute value to prepopulate the attribute field. |

> [!NOTE]
> This macro requires a specific pattern to set lookup values. You will need to pass the related record id, record type, and record name as separate attributes for a single lookup.

### Examples
  

   | Scenarios | Description | Steps|
   |-----------------|-----------------------------|---------------------------------|
   | Create a new task from an existing case | Create a macro to open a task from the case.| <ol><li> Add the **Open a new form to create a record** action with the following attributes:<ul><li>The Subject field is populated using a data parameter that retrieves the case number.<br>**Attribute Name**: subject, **Attribute Value**: Follow up task regrading `$(anchor.ticketnumber)`</li><li>The Description field is populated with a combination of a text string and the customer email address retrieved using a oData query.<br>**Attribute Name**: Description, **Attribute Value**: Review customer email: `{$odata.contact.emailaddress1.?$filter=contactid eq '{anchor._customerid_value}'}`</li><li> The Regarding field is populated with the customer record.<ul><li>**Attribute Name**: regardingobjectid, **Attribute Value**: `${anchor.incidentid}`</li><li> **Attribute Name**: regardingobjectidtype, **Attribute Value**: `incident`</li><li>**Attribute Name**: regardingobjectidname, **Attribute Value**: `${anchor.title}`</li></ul> </li></ul><li> Add the **Save the record** action.  </li></ol> | 
   | Create a new case from a conversation | Create a macro to open a case from a conversation.|<ol><li> Add the **Open a new form to create a record** action with the following attributes:<ul><li>The Subject field is populated using a data parameter that retrieves the conversation.<br>**Attribute Name**: subject, **Attribute Value**: Follow up with `$(customerName)`</li><li>The Description field will be populated with a combination of a text string and the customer email address retrieved via oData query.<br>**Attribute Name**: Description, **Attribute Value**: Review customer email: `{$odata.contact.emailaddress1.?$filter=contactid eq '{customerRecordid}'}`</li><li> The Regarding field is populated with the customer record.<ul></li><li>**Attribute Name**: regardingobjectid, **Attribute Value**: `${customerRecordid}`</li><li> **Attribute Name**: regardingobjectidtype, **Attribute Valye**: `${customerEntityName}`</li><li>**Attribute Name**: regardingobjectidname, **Attribute Value**: `${customerName}`</li></ul><li> Add the **Save the record** action. </li></ol> | 

## Open an existing record

This action is used to open an existing record form. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to open. <br> This is a mandatory field. | 
   | Entity record ID| Specify the entity record ID. <br>This is a mandatory field.| 
   | Entity form ID | Specify the form ID. <br>This is an optional field. |

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   | Open a product record from an existing case | Macro opens the product record from an existing case. | Add the **Open an existing record** action that reads the product id from the case, with the following attributes: <ul><li>**Entity logical name**: `product`</li><li>**Entity record ID**: `${anchor._productid_value}` </li></ul> |
    | Open a a customer record from a conversation |  Macro opens a customer record from an ongoing conversation.| Add the **Ope an existing case** action that reads passing the customer id from the conversation, with the following attributes:<ul><li>**Entity record ID**: `${customerEntityName}` </li><li>**Entity logical name**: `${customerRecordid}`</li></ul> |

## Autofill form fields

This action is used for updating the form fields.The macro doesn't automatically save the new values in Dataverse until the form triggers the auto-save if enabled. You can use another macro action to save the record. Alternatively, you can use the "Update existing record" macro based on your business requirements. This action applies to the form in focused tab and has the same entity type as mentioned in action.  


   | Field | Description | 
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name | Specify the logical name of the entity that you want to update. <br> This is a mandatory field. | 

> [!NOTE]
> This macro requires a specific pattern to set lookup values. You will need to pass the related record id, record type, and record name as separate attributes for a single lookup.

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Open a task form and populate form fields from case | Macro opens the task form and then populates the form with values from the anchor tab.  | <ol><li>Add the **Open a new form to create a record** action that opens a task record, with the following parameters:<br> **Entity logical name**:`task`.</li><li>Add the **Autofill form fields** that populates the new task record with values from the case form that's the anchor tab, with the following attributes: <ul><li>**Entity logical name**: `task`</li><li>**Attribute Name**: subject, **Attribute Value**: Follow up task regarding `${anchor.ticketnumber}`</li><li>**Attribute Name**: regrdingobjectid, **Attribute Value**: `{{"id":"${anchor.incidentid}","name":"${anchor.title}","entitytype":"incident"}}`</li></ul></li></ol> |
   |Open a task form and populate form fields from a conversation | Macro opens the task form and then populates the form with values from the conversation using data parameters. |<ol><li>Add the **Open a new form to create a record** action that opens a task record, with the following parameters:<br> **Entity logical name**:`task`.</li><li>Add the **Autofill form fields** that populates the new task record with values from the conversation, with the following attributes: <ul><li>**Entity logical name**: `task`</li><li>**Attribute Name**: subject, **Attribute Value**: Follow up task regarding `${anchor.customerName}`</li><li>**Attribute Name**: regrdingobjectid, **Attribute Value**: `"${customerName}","entitytype":"${xustomerEntityName}"}}`</li></ul></li></ol> |


#### Update an existing record

This action is used to update an existing record. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to update. <br> This is a mandatory field. | 
   | Entity record ID| Specify the entity record ID. <br>This is a mandatory field.| 
   | Attribute Name | Specify the attribute logical name you want to update.|
   | Attribute Value | Specify the attribute value that will be updated for the above-mentioned attribute. |

> [!NOTE]
> This macro requires a specific pattern to set lookup values. You will need to pass the related record id, record type, and record name as separate attributes for a single lookup.

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   | Open a task form, create the task, then update the record. | Macro opens the task form and creates a new form and then updates the task form from an existing record.| <ol><li>Add the **Open a new form to create a record** action that opens a task record, with the following parameters:<br> **Entity logical name**:`task`.</li><li>Add the **Save the record** action.</li><li>Add the **Update an existing record** that populates the new task record with record id and logical name from the dynamics content (obtained after the save record action) and the regarding object based on values from the anchor tab, with the following attributes: <ul><li>**Entity record ID**: `Entity record ID`</li><li>**Entity logical name**: `Entity logical name`</li><li>**Attribute Name**: regardingobjectid_incident@odata.bind, **Attribute Value**: `/incidents{${anchor.incidentid}}`</li></ul></li></li><li> Add the **Refresh the tab** session action to refresh the task form as the update record macro performs a back-end operation and doesn't automatically refresh the tab.</li></ol> 


> [!CAUTION]
> This macro causes the form to refresh after the **Save the record action** and the **Refresh the tab** action. This is for illustration purposes. We recommend that you design your macros in such a way to reduce form loading. 
  

## Resolve a case

This action is used to resolve a case. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|--------------------------|
   | Billable time |  Specify the time that is billable. <br> This is a mandatory field. | 
   | Incident ID| Specify the ID of the case that you want to close. <br>This is a mandatory field.| 
   | Resolution | Specify the reason to resolve the case. <br> This is a mandatory field. | 


### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |resolve a case |  resolve the case passing billable time as a numeric value, resolution can be a string, Incident ID will be the record id that needs to be resolved. When resolving a case via macro, the tab is not automatically refreshed, so additional steps are recommended for a better user experience | <ol><li>New step: Resolve case with the following attributes:<ul><li>Incident ID: `${anchor.incidentid}`</li><li>Billable time: 0</li><li>Resolution: `Case${anchor.ticketnumber}` resolved via macros</li></ul></li><li>New step: Get the current tab</li><li>New step: Refresh the tab with Tab ID set to `Tab ID`</li><ol> |

## Open an email form with predefined template

This action is used to open an email with a predefined template. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity. <br> This is a mandatory field. | 
   | Entity record ID| Specify the entity record ID. <br>This is a mandatory field.| 
   | Email recipients | Specify the recipients to whom you want the mail to be sent. <br> This is a mandatory field. | 
   | Template ID | Specify the ID of the template that must displayed in the email. <br> This is a mandatory field. | 


> [!NOTE]
> Due to a known product limitation, the Email recipients field requires a parameter but it doesn't automatically map to a user in the form. For this reason, the recommendation is to use the autofill form fields macro to populate the values accordingly. 

### Examples

   | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Open an email template from a case |  The macro opens the template based on the template id and populate the email form with To and Regarding fields.  | <ol><li>New step: Open an email form with predefined template with the following attributes:<ul><li>Template Id</li><li>Entity Record ID: `${anchor.incidentid}`</li><li>Email recipients: `${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}`</li><li>Entity Logical Name: `incident` </li></ul></li><li>New step: Autofill form fields with the following attributes: <ul<li>Entity logical name: `Email`</li><li>Attribute Name 1: to Value: `[{"id":"${anchor._customerid_value}","entitytype":"contact","name":"${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}"}]`</li><li>Attribute Name- 2: regardingobjectid, Value: `[{"id":"${anchor.incidentid}"},"name":"${anchor.title}","entitytype":"incident"}]`</li></ul></li></ol> |
   |Open an email template from an Omnichannel conversation | The macro opens the template based on the template id and populate the email form with To and Regarding fields.  | <ol><li>New step: Open an email form with predefined template with the following attributes:<ul><li>Template Id</li><li>Entity Record ID: `${customerRecordId}`</li><li>Email recipients: `${customerName}`</li><li>Entity Logical Name: `${customerEntityName}` </li></ul></li><li>New step: Autofill form fields with the following attributes: <ul<li>Entity logical name: `Email`</li><li>Attribute Name 1: to Value: `[{"id":"${customerRecordId}", "entitytype":"contact","name":"${customerName}"}]`</li><li>Attribute Name- 2: regardingobjectid, Value: `[{"id":"${customerRecordId}"},"entitytype":"contact","name": "${customerName}"}]`</li></ul></li></ol> |
    |Open an email template from a case with multiple recipients |   The macro opens the template based on the template id and populate the email form with To and Regarding field. The email form needs to populate the To field with the customer and a custom field named "Secondary contact".  
This macro illustrates the process to set multiple recipients in the To field. | <ol><li>New step: Open a new fowm to create a record</li><li>New step: Autofill form fields with the following attributes:<ul><li>Entity logical name: `phonecall`</li><li>Attribute Name 1: subject Value: Follow-up task regarding case `${anchor.ticketnumber}`</li><li> Attribute Name 2: to Value: `[{"id":"${anchor._customerid_value}","type":"${anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}","name":"${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}", {"id":"${anchor._cr27b_secondarycontact_value}","type":"contact","name":"${anchor._cr27b_secondarycontact_value@OData.Community.Display.V1.FormattedValue}"}]`</li><li>Attribute Name- 3: regardingobjectid, Value: `[{"id":"${anchor.incidentid}"},"name":"${anchor.title}","entitytype":"incident"}]`</li></ul></li></ol> |

## Search the knowledge base for the populated phrase

This action is used for searching knowledge articles based on the populated phrase. The action contains the following field.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Search string |  Provide the phrase based on which you want to search for knowledge articles. You can provide the context data. For example, the context data parameter can be a case title. | 
   |Tab Label| Specify the tab label.|

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Search an article based on a string |  a macro to perform a search based on phrase passing the case title via data parameter.| New step: Search the knowledge base for the populated phrase with the following attributes: <ul><li>Tab Level: `Searching for ${anchor.title}`</li><li>Search string : `${anchor.title}`</li></ul> |

## Open knowledge base article

This action is used to open the knowledge base article. The action contains the following field.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity record ID  | Specify the entity ID of the knowledge base article that you want to open. <br> This is a mandatory field.|  

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Open a knowledge base article passing a GUID |   a macro to open a knowledge base article based on the knowledge article ID. This macro opens the form of the knowledge article typically used by Knowledge Base Authors for article revision. | New step: Open knowledge base article with the Entity record ID.|

## Open a record grid

This action is used to open a record grid. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity for which you want to open the grid. <br> This is a mandatory field. | 
   | View ID| Specify the ID of the view that you want to open.<br> This is a mandatory field. | 
   | View type | Specify the view type. <br>This is a mandatory field. | 
  

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Open a specific list of incidents| a macro to open a list of incidents passing the view ID and specifying the view type (personal saved views). | New step: Open a record grid with the following attributes: <ul><li>Entity logical name: `incident`</li><li>View type</li><li>View ID</li></ul>|


## Do a relevance search based on the phrase

This action is used for searching knowledge articles based on the populated phrase. The action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Search string |  Provide the phrase based on which you want to do a relevance search. You can provide the context data. For example, the context data parameter can be a case title. <br> This is a mandatory field.  |  

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Search for cases with same case title| a macro to pass the case title from the anchor tab as the parameter for the relevance search. | New step: Do a search based on the phrase with the following attributes: <ul><li>Search string: `${anchor.title}`</li></ul>|

## Clone current record

This action is used for cloning an existing record that is open in the current tab. The action only copies the fields and does not save the record. The action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Record title | Specify the title of the record that you want to clone. <br> This is a mandatory field. | 

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Create a child case using clone current record | The following example is a macro to open clone a case record but setting the parent case so it becomes a child case and setting the ticket number as null to be created when the save record action is executed. | New step: Clone current record with the following attributes: <ul><li>Record title: Child case of `${anchor.ticketnumber}`</li><li>New step: Autofill form fields with the following attributes: <ul><li>Entity logical name: `incident`</li><li>Attribute Name-1: parentcaseid Value: `[{"id": "${anchor.incidentid}","name":"${anchor.title}","entitytype":"incident"}]`</li><li>Attribute Name - 2: ticketnumber Value: `---`</li></ul></li></ul>|

#### Clone input record

This action clones an existing record. The action only copies the fields and does not save the record. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   |Record title| Specify the record title.|
   | Entity record ID | Specify the ID of the entity record. <br> This is a mandatory field.|
   | Entity logical name | Specify the logical name of the entity that you want to clone. <br> This is a mandatory field. |
 
 
### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Create a child case using clone input record | The following example is a macro to open clone a case record but setting the parent case so it becomes a child case and setting the ticketnumber as null to be created when the save record action is executed. | New step: Clone input record with the following attributes: <ul><li>Entity record ID: `${anchor.incidentid}`</li><li>Entity logical name: `incident`</li><li>Record title: Child case of `${anchor.title}`</li><li>New step: Autofill form fields with the following attributes: <ul><li>Entity logical name: `Entity logical name`</li><li>Attribute Name-1: parentcaseid Value: `[{"id": "${anchor.incidentid}","name":"${anchor.title}","entitytype":"incident"}]`</li><li>Attribute Name - 2: ticketnumber Value: `---`</li></ul></li></ul>|

## Set Agent Script focus

This action is used to set the focus on an agent script that needs to run next. The agent script will be set in focus in the **Agent scripts** dropdown on the app side pane. For example, if the agent needs to process a refund complaint. The agent will use different scripts to greet, initiate a complaint request, and process the refund. You can define macros that will set the focus on the agent scripts that need to be run for each stage of the refund process. The action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Agent Script Unique Name   |  Specify the agent script that needs to be in focus.  | 

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Update the priority of a case and set focus to another agent script | The following example is a macro to update the priority of a case to high and then switch to another agent script. | New step: Update an existing record with the following attributes: <ul><li>Entity record ID: `${anchor.incidentid}`</li><li>Entity logical name: `incident`</li><li>Attribute Name 1: prioritycode Value: 1</li></ul><li>New step: Set focus to an agent script: <ul><li>Agent Script Unique Name: `new_agentscript_highpriority`</li></ul></li><li>New step: Get the current tab</li><li>New step: Refresh the tab</li></ul>|


## Save the record

This action saves the record after you've entered data in all the mandatory fields. The action fails if the mandatory fields aren't entered or are left blank.

