---
title: Create productivity automation macros 
description: Learn about how to use productivity automation macros in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: 
ms.topic: conceptual 
ms.collection: 
ms.date: 07/29/2024
ms.custom: bap-template 
---

# Create productivity automation macros

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

 You can automate the following tasks with productivity automation macros: 

- open and update records
- open views
- resolve cases
- search knowledge base
- clone records
- set focus to another agent script
- open email templates
- auto fill form fields
- set and retrieve variables and values in the session context

 You can use the productivity automation actions any number of times across different macros to automate and perform model-driven app operations.

The following sections describe the different productivity automation actions that you can use to create macros.

## Open a new form to create a record

Opens a new form to create a record. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to open. |  
   | Entity form ID | Specify the form ID.|
   | Attribute Name | Specify the attribute logical name. You need to provide the attribute name for the application to populate the field with a value.| 
   | Attribute Value | Specify the attribute value. You need to provide the attribute value for the application to populate the attribute field. |

> [!NOTE]
> This action requires a specific pattern to set lookup values. You must pass the related record id, record type, and record name as separate attributes for a single lookup.

### Example 1: Create a new task from an existing case
  
Perform the following steps to create a macro to open a task from the case:

 1. Add the **Open a new form to create a record** action that creates a task with the following attributes:
    - Subject: Case number retrieved using a data parameter.
       - **Attribute Name**: subject
       - **Attribute Value**: Follow up task regrading `$(anchor.ticketnumber)`
    - Description: Combination of a text string and the customer email address retrieved using an oData query.
       - **Attribute Name**: Description
       - **Attribute Value**: Review customer email: `{$odata.contact.emailaddress1.?$filter=contactid eq '{anchor._customerid_value}'}`
    - Regarding: Customer record.
       - **Attribute Name**: regardingobjectid
       - **Attribute Value**: `${anchor.incidentid}`
       - **Attribute Name**: regardingobjectidtype
       - **Attribute Value**: `incident`
       - **Attribute Name**: regardingobjectidname 
       - **Attribute Value**: `${anchor.title}`
2. Add the **Save the record** action. 
 
### Example 2: Create a new case from a conversation  

Perform the following steps to create a macro to open a case from a conversation:
1. Add the **Open a new form to create a record** action with the following attributes:
    - Subject: Conversation retrieved using a data parameter.
      - **Attribute Name**: subject
      - **Attribute Value**: Follow up with `$(customerName)`
    - Description: Combination of a text string and the customer email address retrieved via oData query.
      - **Attribute Name**: Description
      -  **Attribute Value**: Review customer email: `{$odata.contact.emailaddress1.?$filter=contactid eq '{customerRecordid}'}`
   - Regarding: Customer record.
      - **Attribute Name**: regardingobjectid
      -  **Attribute Value**: `${customerRecordid}`
      - **Attribute Name**: regardingobjectidtype
      - **Attribute Value**: `${customerEntityName}`
      - **Attribute Name**: regardingobjectidname
      - **Attribute Value**: `${customerName}`
2. Add the **Save the record** action.

## Open an existing record

Opens an existing record form. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to open.| 
   | Entity record ID| Specify the entity record ID. | 
   | Entity form ID | Specify the form ID. |

### Example 1: Open the product record from an existing case

To create a macro to open the product record from an existing case, add the **Open an existing record** action that reads the product ID from the case, with the following attributes: 
   - **Entity logical name**: `product`
   - **Entity record ID**: `${anchor._productid_value}` 
 
### Example 2: Open the customer record from a conversation 

To create a macro to open a customer record from an ongoing conversation, add the **Open an existing record** action that reads the customer ID from the conversation, with the following attributes:
  - **Entity record ID**: `${customerEntityName}` 
  - **Entity logical name**: `${customerRecordid}`

## Autofill form fields

Updates form fields. The macro action doesn't automatically save new values in Dataverse until the form triggers the autosave. You can use another macro action to save the record. Alternatively, you can use the **Update existing record** macro based on your business requirements. This action applies to the form in focused tab and has the same entity type mentioned in action.  


   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity logical name | Specify the logical name of the entity that you want to update. | 

> [!NOTE]
> This macro requires a specific pattern to set lookup values. You will need to pass the related record ID, record type, and record name as separate attributes for a single lookup.

### Example 1: Open a task form and populate form fields from case

Perform the following steps to create a macro that opens the task form and then populates the form with values from the anchor tab:
1. Add the **Open a new form to create a record** action that opens a task record, with the following parameters:
    - **Entity logical name**:`task`.
2. Add the **Autofill form fields** that populates the new task record with values from the case form that's the anchor tab, with the following attributes: 
    - **Entity logical name**: `task`
    - **Attribute Name**: subject
    - **Attribute Value**: Follow up task regarding `${anchor.ticketnumber}`
    - **Attribute Name**: regrdingobjectid
    - **Attribute Value**: `{{"id":"${anchor.incidentid}","name":"${anchor.title}","entitytype":"incident"}}`

### Example 2: Open a task form and populate form fields from a conversation

Perform the following steps to create a macro that opens the task form and then populates the form with values from the conversation using data parameters:
1. Add the **Open a new form to create a record** action that opens a task record, with the following parameters:
    - **Entity logical name**:`task`.
2. Add the **Autofill form fields** that populates the new task record with values from the conversation, with the following attributes: 
   - **Entity logical name**: `task`
   - **Attribute Name**: subject
   - **Attribute Value**: Follow up task regarding `${anchor.customerName}`
   - **Attribute Name**: regrdingobjectid
   - **Attribute Value**: `"${customerName}","entitytype":"${customerEntityName}"}}`

#### Update an existing record

Updates an existing record. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to update. <br> This field is mandatory. | 
   | Entity record ID| Specify the entity record ID. <br>This field is mandatory.| 
   | Attribute Name | Specify the attribute logical name you want to update.|
   | Attribute Value | Specify the attribute value that's updated for the above-mentioned attribute. |

> [!NOTE]
> This macro requires a specific pattern to set lookup values. You will need to pass the related record ID, record type, and record name as separate attributes for a single lookup.

### Example 1: Open a task form, create the task, then update the record

Perform the following steps to create a macro that opens the task form and creates a new form and then updates the task form from an existing record:
 
1. Add the **Open a new form to create a record** action that opens a task record, with the following parameters:
     - **Entity logical name**:`task`
1. Add the **Save the record** action.
1. Add the **Update an existing record** that populates the new task record with record ID and logical name from the dynamics content (obtained after the save record action) and the regarding object based on values from the anchor tab, with the following attributes: 
   - **Entity record ID**: `Entity record ID`
   - **Entity logical name**: `Entity logical name`
   - **Attribute Name**: regardingobjectid_incident@odata.bind
   - **Attribute Value**: `/incidents{${anchor.incidentid}}`
1. Add the **Refresh the tab** session action to refresh the task form as the update record macro performs a back-end operation and doesn't automatically refresh the tab.

> [!CAUTION]
> In the example, the form refreshes after the **Save the record action** and the **Refresh the tab** actions. We recommend that you design your macros in such a way to reduce form loading. 
  

## Resolve a case

Use the action to resolve a case. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Billable time |  Specify the time that is billable. <br> This field is mandatory. | 
   | Incident ID| Specify the ID of the case that you want to close. <br>This field is mandatory.| 
   | Resolution | Specify the reason to resolve the case. <br>This field is mandatory. | 


### Example: Macro to resolve a case

Perform the following steps to create a macro that resolves a case. When agents resolve a case using macro, the tab isn't automatically refreshed, so more steps are recommended for a better user experience.

1. Add the **Action to resolve case** action to pass the billable time as a numeric value and the Incident ID is the record ID that needs to be resolved, with the following attributes:
  - **Incident ID**: `${anchor.incidentid}`
  - **Billable time**: 0
  - **Resolution**: `Case${anchor.ticketnumber}` resolved via macros
1. Add the **Get the current tab** session connector.
1. Add the **Refresh the tab** session action to refresh the tab with the following attributes:
    -**Tab ID**: Tab ID

## Open an email form with predefined template

This action is used to open an email with a predefined template. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name | Specify the logical name of the entity to which email is being sent. <br>This field is mandatory.| 
   | Entity record ID | Specify the record ID of the entity record to which email is being sent.<br>This field is mandatory.| 
   | Email recipients | Specify the display name of the record to which email is being sent. <br>This field is mandatory.| 
   | Template ID | Specify the email template ID of the type of entity to which email is being sent and that must be displayed in the email. <br>This field is mandatory.|

> [!NOTE]
> The **Email recipients** field requires a parameter but doesn't automatically map to a user in the form. We recommend that you use the **autofill form fields** macro to populate the values accordingly. 

### Example 1: Open an email template from a case

Perform the following steps to create a macro that opens an email template of category case:
1. Add the **Open an email form with predefined template** action that adds the template based on the template ID and populates the email form with **To** and **Regarding** fields. The attributes are as follows:
   - **Template Id**: Specify the ID of the required email template.
   - **Entity Record ID**: `${anchor.incidentid}`
   - **Email recipients**: `${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}`
   - **Entity Logical Name**: `incident` 
1. Add the **autofill form fields** action to populate the To and Regarding fields. The attributes are as follows: 
     - **Entity logical name**: `Email`
     - **Attribute Name**: to
     - **Attribute Value**: `[{"id":"${anchor._customerid_value}","entitytype":"contact","name":"${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}"}]`
     - **Attribute Name**: regardingobjectid
     -  **Attribute Value**: `[{"id":"${anchor.incidentid}"},"name":"${anchor.title}","entitytype":"incident"}]`

### Example 2: Open an email template from a conversation

Perform the following steps to create a macro that opens an email template of category contact:
1. Add the **Open an email form with predefined template** action that adds the template based on the template ID and populates the email form with **To** and **Regarding** fields. The attributes are as follows:
   - **Template Id**: Specify the ID of the required email template.
   - **Entity Record ID**: `${customerRecordId}`
   - **Email recipients**: `${customerName}`
   - **Entity Logical Name**: `${customerEntityName}` 
1. Add the **autofill form fields** action to populate the To and Regarding fields. The attributes are as follows: 
    - **Entity logical name**: `Email`
    - **Attribute Name**: to
    - **Attribute Value**: `[{"id":"${customerRecordId}", "entitytype":"contact","name":"${customerName}"}]`
    - **Attribute Name**: regardingobjectid
    - **Attribute Value**: `[{"id":"${customerRecordId}"},"entitytype":"contact","name": "${customerName}"}]`|

### Example 3: Open an email template with multiple recipients

Perform the following steps to create a macro that opens an email template of category case, and sets multiple recipients in the To field of the email:

1. Add the **Open an email form with predefined template** action that adds the template based on the template ID and populates the email form with **To** and **Regarding** fields. The attributes are as follows:
   - **Template Id**: Specify the ID of the required email template.
   - **Entity Record ID**: `${customerRecordId}`
   - **Email recipients**: `${customerName}`
   - **Entity Logical Name**: `${customerEntityName}` 
1. Add the **autofill form fields** action to populate the To and Regarding fields. The To field must be populated with the customer's email id and a custom field, **Secondary contact**. The attributes are as follows: 
   - **Entity logical name**: `phonecall`
   - **Attribute Name**: subject
   - **Attribute Value**: Follow-up task regarding case `${anchor.ticketnumber}`
   - **Attribute Name**: to
   - **Attribute Value**: `[{"id":"${anchor._customerid_value}","type":"${anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}","name":"${anchor._customerid_value@OData.Community.Display.V1.FormattedValue}", {"id":"${anchor._cr27b_secondarycontact_value}","type":"contact","name":"${anchor._cr27b_secondarycontact_value@OData.Community.Display.V1.FormattedValue}"}]`
   - **Attribute Name**: regardingobjectid
   - **Attribute Value**: `[{"id":"${anchor.incidentid}"},"name":"${anchor.title}","entitytype":"incident"}]`

## Search the knowledge base for the populated phrase

The macro searches for knowledge articles based on the populated phrase. The action contains the following field.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Search string |  Provide the phrase based on which you want to search for knowledge articles. You can provide the context data. For example, the context data parameter can be a case title. | 
   |Tab Label| Specify the tab label.|

### Example: Search an article based on a string

Perform the following steps to create a macro that performs a search based on a phrase:

1. Add the **Search the knowledge base for the populated phrase** action that picks up the case title as the search phrase. The following are the attributes: 
   - **Tab Label**: Searching for `${anchor.title}`
   - **Search string**: `${anchor.title}`

## Open knowledge base article

Opens a knowledge base article. The action contains the following field.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity record ID  | Specify the entity ID of the knowledge base article that you want to open. <br>This field is mandatory.|  

### Example: Open a knowledge base article passing a GUID

Perform the following steps to create a macro that opens a knowledge base article based on the knowledge article ID. | Add the **Open knowledge base article** action to open the knowledge article and is used by Knowledge Base Authors for article revision. The attributes are as follows:<br> **Entity record ID**: Specify the knowledge base article's entity ID.|

## Open a record grid

This action is used to open a record grid. The action contains the following fields.

   | Field | Description |
   |-----------------|-----------------------------|
   | Entity logical name |  Specify the logical name of the entity for which you want to open the grid. <br>This field is mandatory. | 
   | View ID| Specify the ID of the view that you want to open.<br>This field is mandatory. | 
   | View type | Specify the view type. <br>This field is mandatory. | 
  

### Example 1: Open a list of products

To create a macro that opens a list of products, add the **Open a record grid** action to open the user's default view, as the view type and id aren't specified. Specify the following attributes:  **Entity logical name**: `incident`.

### Example 2: Open a list of incidents

To create a macro that opens a list of incidents, add the **Open a record grid** action to open the specified view type. The following are the attributes: 
   - **Entity logical name**: `incident`
   - **View type**: Specify the view type.
   - **View ID**: Specify the ID of the view you want the incidents to open in


## Do a relevance search based on the phrase

Searches knowledge articles based on the populated phrase. The action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Search string |  Provide the phrase based on which you want to do a relevance search. You can provide the context data. For example, the context data parameter can be a case title. <br>This field is mandatory..  |  

### Example 1: Search for cases with same case title

To create a macro that uses a case title to search for similar cases, add the **Do a relevance search based on the phrase** action to use the case title from the anchor tab as the parameter for the relevance search with **Search string** set to `${anchor.title}`

## Clone current record

Clones an existing record that's open in the current tab. The action only copies the fields and doesn't save the record. The action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Record title | Specify the title of the record that you want to clone. <br>This field is mandatory. | 

### Example: Create a child case using clone current record 

Perform the following steps to create a macro that creates a clone of the existing case and makes it the parent case. The original case is set as a child case:
 1. Add the **Clone current record** action that clones the original case, and then sets the cloned case as the parent. The original case is set as the child case. Set the **Record title** attribute to Child case of `${anchor.ticketnumber}`.
 1. Add the **Autofill form fields** that populates the child case with the attributes specified. The ticket number is set when the record is saved. The following are the attributes: 
    - **Entity logical name**: `incident`
    - **Attribute Name**: parentcaseid
    - **Attribute Value**: `[{"id": "${anchor.incidentid}","name":"${anchor.title}","entitytype":"incident"}]`
    - **Attribute Name**: ticketnumber
    - **Attribute Value**: 
1. Add the **Save the record** action to generate and set the ticket number for the child case.</li></ol>|

#### Clone input record

Clones an existing record. The action only copies the fields and doesn't save the record. The action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   |Record title| Specify the record title.|
   | Entity record ID | Specify the ID of the entity record. <br>This field is mandatory.|
   | Entity logical name | Specify the logical name of the entity that you want to clone. <br>This field is mandatory. |
 
 
### Example: Create a child case using clone input record

Perform the following steps to create a macro to clone an existing case. The existing case is set as the parent case and the cloned case is set as the child case.
1. Add the **Clone current record** action that clones the original case, and then sets the cloned case as the child. The original case is set as the parent case. The following are the attributes:
   - **Entity record ID**:`${anchor.incidentid}`
   - **Entity logical name**: `incident`
   - **Record title**: Child case of `${anchor.title}`
1. Add the **Autofill form fields** that populates the child case with the specified attributes. The ticketnumber is set when the record is saves. The following are the attributes: 
   - **Entity logical name**: `Entity logical name`
   - **Attribute Name**: parentcaseid
   - **Attribute Value**: `[{"id": "${anchor.incidentid}","name":"${anchor.title}","entitytype":"incident"}]`
   - **Attribute Name**: ticketnumber
   - **Attribute Value**:  
1. Add the **Save the record** action to generate and set the ticketnumber for the child case.</li></ol>

## Set Agent Script focus

Sets the focus on an agent script that needs to run next. The agent script is set in focus in the **Agent scripts** dropdown on the app side pane. For example, if the agent needs to process a refund complaint. The agent uses different scripts to greet, initiate a complaint request, and process the refund. You can define macros that set the focus on the agent scripts that need to be run for each stage of the refund process. The agent script in focus must be associated with the session template. The action contains the following field.

   | Field | Description |
   |-----------------|-----------------------------|
   | Agent Script Unique Name   |  Specify the agent script that needs to be in focus.  | 

### Example: Update the priority of a case and set focus to another agent script

Perform the following steps to create a macro that updates the priority of a case to high and then switches to another agent script.

1. Add the **Update an existing record** action with the following attributes:
    - **Entity record ID**: `${anchor.incidentid}`
    - **Entity logical name**: `incident`
    - **Attribute Name**: priority code
    -  **Attribute Value**: 1
1. Add the **Set Agent Script focus** action with **Agent Script Unique Name** set to `new_agentscript_highpriority`.
1. Add the **Get the current tab** session connector.</li><li> Add the **Refresh tab** session connector.

## Save the record

Saves the record after you entered data in all the mandatory fields. The action fails if the mandatory fields aren't entered or are left blank.

## Next Steps

[Use session connector to create macros](macros-session-action.md)
