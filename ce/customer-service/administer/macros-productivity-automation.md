---
title: Productivity automation 
description: Learn about productivity automation macros in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: 
ms.topic: conceptual #Required; don't change.
ms.collection: 
ms.date: 04/04/2024
ms.custom: bap-template #Required; don't change.
---


# Productivity automation

 Productivity automation macros allow you to automate tasks such as opening and updating records, opening views, resolving cases, searching the knowledge base, record cloning, setting focus to another agent script, opening email templates, auto filling form fields, setting and retrieving variables and values in the session context. As an administrator, you can use the actions any number of times across different macros to automate and perform model-driven app operations.

## Open a new form to create a record

This action is used to open a new form to create a record. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to open.<br> This is a mandatory field. |  
   | Entity form ID | Specify the form ID.<br> This is an optional field. |
   | Attribute Name | Specify the attribute logical name. You need to provide the attribute name to prepopulate the field with a value.| 
   | Attribute Value | Specify the attribute value. You need to provide the attribute value to prepopulate the attribute field. |

> [!NOTE]
> This macro requires a specific pattern to set lookup values. You will need to pass the related record id, related record type, and related record name as separate attributes for a single lookup.

### Examples
  


   | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   | Create a new task from an existing case | <ul><li>subject field will be populated using a data parameter retrieving the case number</li><li> the regarding field will be populated with the customer record</li><li>the description field will be populated with a combination of a text string and the customer email address retrieved via oData query</li><li> The macro will also save the record.</li></ul>  | <ul><li>Attribute Name - 1: subject, Value: Follow up task regrading `$(anchor.ticketnumber)`</li><li> Attribute Name - 2: description, Value: Review customer email: `{$odata.contact.emailaddress1.?$filter=contactid eq '{anchor._customerid_value}'}`</li><li>Attribute Name - 3: regardingobjectid, Value: `${anchor.incidentid}`</li><li> Attribute Name - 4: regardingobjectidtype, Value: `incident`</li><li>Attribute Name - 5: regardingobjectidname, Value: `${anchor.title}`</li></ul> |
   | Create a new case from a conversation | <ul><li>The subject field will be populated using a data parameter retrieving the conversation</li><li> the regarding field will be populated with the customer record</li><li>the description field will be populated with a combination of a text string and the customer email address retrieved via oData query</li><li> The macro will also save the record.</li></ul>  | <ul><li>Attribute Name - 1: subject, Value: Follow up with `$(customerName)`</li><li> Attribute Name - 2: description, Value: Review customer email: `{$odata.contact.emailaddress1.?$filter=contactid eq '{customerRecordid}'}`</li><li>Attribute Name - 3: regardingobjectid, Value: `${customerRecordid}`</li><li> Attribute Name - 4: regardingobjectidtype, Value: `${customerEntityName}`</li><li>Attribute Name - 5: regardingobjectidname, Value: `${customerName}`</li></ul> |

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
   | Open a product record from an existing case | open the customer record from a conversation passing the customer id using data parameters. | <ul><li>Entity logical name: `product`</li><li>Entity record ID: `${anchor._productid_value}` </li></ul> |
    | Open a a customer record from a conversation | open the product record from an existing case passing the product id using data parameters. | <ul><li>Entity record ID: `${customerEntityName}` </li><li>Entity logical name: `${customerRecordid}`</li></ul> |

## Autofill form fields

This action is used for updating the form fields.The macro doesn't automatically save the new values in Dataverse until the form triggers the auto-save if enabled. You can use another macro action to save the record. Alternatively, you can use the "Update existing record" macro based on your business requirements. This action applies to the form in focused tab and has the same entity type as mentioned in action.  


   | Field | Description | 
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name | Specify the logical name of the entity that you want to update. <br> This is a mandatory field. | 

> [!NOTE]
> This macro requires a specific pattern to set lookup values. You will need to pass the related record id, related record type, and related record name as separate attributes for a single lookup.

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   |Open a task form and populating form fields from case |  open a task form with empty values, then populating the form with fields based on values from the anchor tab using data parameters.  | <ol><li>Add a new action: Open a new form to create a record with **Entity logical name** set to `task`.</li><<li>Add a new step: Autofill form fields<ul><li>Entity logical name: `task`</li><li>Attribute Name -1 : subject, Value: Follow up task regarding `${anchor.ticketnumber}`</li><li>Attribute Name - 2: regrdingobjectid, Value: `{{"id":"${anchor.incidentid}","name":"${anchor.title}","entitytype":"incident"}}`</li></ul></li></ol> |
    | open a task form with empty values, then populating the form with fields based on values from the customer using data parameters. | <ol><li>Add a new action: Open a new form to create a record with **Entity logical name** set to `task`.</li><<li>Add a new step: Autofill form fields<ul><li>Entity logical name: `task`</li><li>Attribute Name -1 : subject, Value: Follow up with `${customerName}`</li><li>Attribute Name - 2: regrdingobjectid, Value: `{{"id":"${customerRecordid}","name":"${customerName}","entitytype":"${xustomerEntityName}"}}`</li></ul></li></ol>|

#### Update an existing record

This action is used to update an existing record. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to update. <br> This is a mandatory field. | 
   | Entity record ID| Specify the entity record ID. <br>This is a mandatory field.| 
   | Attribute Name | Specify the attribute logical name you want to update.|
   | Attribute Value | Specify the attribute value that will be updated for the above-mentioned attribute. |

> [!NOTE]
> This macro requires a specific pattern to set lookup values. You will need to pass the related record id, related record type, and related record name as separate attributes for a single lookup.

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   | Open a task form, create the task, then update the record. |  open a task form with a basic subject, then updating the record passing the record id and logical name from the dynamics content (obtained after the save record action) and the correct regarding object based on values from the anchor tab using data parameters. The update record macro performs a back-end operation and it doesn't automatically refresh the tab. For that reason, adding a macro step to refresh the tab.  | <ol><li>Add a new action: Open a new form to create a record with **Entity logical name** set to `task`.</li><li>Add a step to save the record</li><li>Add a new step: Update an existing record<ul><li>Entity record ID: `Entity recird ID`</li><li>Entity logical name: `Entity logical name`</li><li>Attribute Name -1 : regardingobjectid_incident@odata.bind, Value: `/incidents{${anchor.incidentid}}`</li></ul></li></ol> |

> [!NOTE]
> This macro will cause the form to refresh after the "Save the record" action and after the "Refresh the tab" action but it was provided for illustration purposes to get familiar with specific patterns for lookups, how to use dynamics content, and differences between macros to open form, autofill form fields and update fields from the back-end. Design your macros to reduce form loading. 
  

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
   |resolve a case |  resolve the case passing billable time as a numeric value, resolution can be a string, Incident ID will be the record id that needs to be resolved. When resolving a case via macro, the tab is not automatically refreshed, so additional steps are recommended for a better user experience | <ul><li>Add a new action: Open a new form to create a record with **Entity logical name** set to `task`.</li><li>Add a step to save the record</li><li>Add a new step: Update an existing record<li>Entity record ID: `Entity recird ID`</li><li>Entity logical name: `Entity logical name`</li><li>Attribute Name -1 : regardingobjectid_incident@odata.bind, Value: `/incidents{${anchor.incidentid}}`</li></ul> |

#### Open a record grid

This action is used to open a record grid. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name |  Specify the logical name of the entity for which you want to open the grid. <br> This is a mandatory field. | incident |
   | View ID| Specify the ID of the view that you want to open.<br> This is a mandatory field. | |
   | View type | Specify the view type. <br>This is a mandatory field. | |
   |||

#### Search the knowledge base for the populated phrase

This action is used for searching knowledge articles based on the populated phrase. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Search string |  Provide the phrase based on which you want to search for knowledge articles. You can provide the context data. For example, the context data parameter can be a case title. |  |
   |Tab Label| Specify the tab label.|

#### Do a relevance search based on the phrase

This action is used for searching knowledge articles based on the populated phrase. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Search string |  Provide the phrase based on which you want to do a relevance search. You can provide the context data. For example, the context data parameter can be a case title. <br> This is a mandatory field.  |  |



#### Set Agent Script focus

This action is used to set the focus on an agent script that needs to run next. The agent script will be set in focus in the **Agent scripts** dropdown on the app side pane. For example, if the agent needs to process a refund complaint. The agent will use different scripts to greet, initiate a complaint request, and process the refund. You can define macros that will set the focus on the agent scripts that need to be run for each stage of the refund process. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Agent Script Unique Name   |  Specify the agent script that needs to be in focus.  |  The unique name of the agent script.  |

#### Open an email form with predefined template

This action is used to open an email with a predefined template. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name |  Specify the logical name of the entity. <br> This is a mandatory field. | incident |
   | Entity record ID| Specify the entity record ID. <br>This is a mandatory field.| |
   | Email recipients | Specify the recipients to whom you want the mail to be sent. <br> This is a mandatory field. | |
   | Template ID | Specify the ID of the template that must displayed in the email. <br> This is a mandatory field. | |




#### Clone current record

This action is used for cloning an existing record that is open in the current tab. The action only copies the fields and does not save the record. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Record title | Specify the title of the record that you want to clone. <br> This is a mandatory field. | |

#### Open knowledge base article

This action is used to open the knowledge base article. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity record ID  | Specify the entity ID of the knowledge base article that you want to open. <br> This is a mandatory field.|  |

#### Save the record

This action saves the record after you've entered data in all the mandatory fields. The action fails if the mandatory fields aren't entered or are left blank.

#### Clone input record

This action clones an existing record. The action only copies the fields and does not save the record. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name | Specify the logical name of the entity that you want to clone. <br> This is a mandatory field. |
   | Entity record ID | Specify the ID of the entity record. <br> This is a mandatory field.|
   |Record title| Specify the record title.
