---
title: "Microsoft Dynamics 365 Customer Engagement queue EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b1ed7e9e-4a92-4ad4-b85e-ca8f4a522cc8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API queue entitytype."
---
# queue EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/queue.md](./descriptions/queue.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]queues </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Queue</td></tr>
<tr><td><b>Primary Key:</b></td><td>queueid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The queue entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the queue was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the queue.<br />|
|emailaddress|Edm.String|**Display Name**: Incoming Email<br />**Description**: Email address that is associated with the queue.<br />|
|emailrouteraccessapproval|Edm.Int32|**Display Name**: Primary Email Status<br />**Description**: Shows the status of the primary email address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Empty</td></tr><tr><td>1</td><td>Approved</td></tr><tr><td>2</td><td>Pending Approval</td></tr><tr><td>3</td><td>Rejected</td></tr><tbody></table>|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the queue with respect to the base currency.<br />Read-only<br />|
|ignoreunsolicitedemail|Edm.Boolean|**Display Name**: Convert To Email Activities<br />**Description**: Information that specifies whether a queue is to ignore unsolicited email (deprecated).<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Only specific Emails</td></tr><tr><td>0</td><td>All incoming Emails</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|incomingemaildeliverymethod|Edm.Int32|**Display Name**: Incoming Email Delivery Method<br />**Description**: Incoming email delivery method for the queue.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>2</td><td>Server-Side Synchronization or Email Router</td></tr><tr><td>3</td><td>Forward Mailbox</td></tr><tbody></table>|
|incomingemailfilteringmethod|Edm.Int32|**Display Name**: Convert Incoming Email To Activities<br />**Description**: Convert Incoming Email To Activities<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>All email messages</td></tr><tr><td>1</td><td>Email messages in response to Dynamics 365 email</td></tr><tr><td>2</td><td>Email messages from Dynamics 365 Leads, Contacts and Accounts</td></tr><tr><td>3</td><td>Email messages from Dynamics 365 records that are email enabled</td></tr><tbody></table>|
|isemailaddressapprovedbyo365admin|Edm.Boolean|**Display Name**: Email Address O365 Admin Approval Status<br />**Description**: Shows the status of approval of the email address by O365 Admin.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the queue was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the queue.<br />|
|numberofitems|Edm.Int32|**Display Name**: Queue Items<br />**Description**: Number of Queue items associated with the queue.<br />Read-only<br />|
|numberofmembers|Edm.Int32|**Display Name**: No. of Members<br />**Description**: Number of Members associated with the queue.<br />Read-only<br />|
|outgoingemaildeliverymethod|Edm.Int32|**Display Name**: Outgoing Email Delivery Method<br />**Description**: Outgoing email delivery method for the queue.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>2</td><td>Server-Side Synchronization or Email Router</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|queueid|Edm.Guid|**Display Name**: Queue<br />**Description**: Unique identifier of the queue.<br />|
|queuetypecode|Edm.Int32|**Display Name**: Queue Type<br />**Description**: Type of queue that is automatically assigned when a user or queue is created. The type can be public, private, or work in process.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|queueviewtype|Edm.Int32|**Display Name**: Type<br />**Description**: Select whether the queue is public or private. A public queue can be viewed by all. A private queue can be viewed only by the members added to the queue.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Public</td></tr><tr><td>1</td><td>Private</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the queue.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the queue.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>2</td><td>Inactive</td></tr><tr><td>1</td><td>Active</td></tr><tbody></table>|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the queue.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the queue record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the queue.|
|_defaultmailbox_value|defaultmailbox<br />|Select the mailbox associated with this queue.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the queue.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the queue.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the queue.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the queue.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the queue.|
|_owningteam_value||Unique identifier of the team who owns the queue.|
|_owninguser_value||Unique identifier of the user who owns the queue.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the queue.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid|[businessunit EntityType](businessunit.md)|business_unit_queues|
|createdby|[systemuser EntityType](systemuser.md)|lk_queuebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_queue_createdonbehalfby|
|defaultmailbox|[mailbox EntityType](mailbox.md)|queue_defaultmailbox_mailbox|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_queuebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_queue_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_queues|
|ownerid|[principal EntityType](principal.md)|owner_queues|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_queues2|
|primaryuserid|[systemuser EntityType](systemuser.md)|queue_primary_user|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Queue|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|mailbox_regarding_queue|[mailbox EntityType](mailbox.md)|regardingobjectid_queue|  
|msdyn_queue_msdyn_responseaction_Queuetonotify|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_Queuetonotify|  
|queue_activity_parties|[activityparty EntityType](activityparty.md)|partyid_queue|  
|Queue_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_queue|  
|Queue_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_queue|  
|Queue_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_queue|  
|Queue_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_queue|  
|Queue_Email_EmailSender|[email EntityType](email.md)|emailsender_queue|  
|queue_entries|[queueitem EntityType](queueitem.md)|queueid|  
|queue_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_queue|  
|queue_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_queue|  
|Queue_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_queue_syncerror|  
|queue_system_user|[systemuser EntityType](systemuser.md)|queueid|  
|queue_team|[team EntityType](team.md)|queueid|  
|queuemembership_association|[systemuser EntityType](systemuser.md)|queuemembership_association|  

## Operations
The following operations can be used with the queue entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddPrincipalToQueue Action](../actions/addprincipaltoqueue.md)|Entity|[!INCLUDE[../actions/descriptions/addprincipaltoqueue.md](../actions/descriptions/addprincipaltoqueue.md)]|  
|[AddToQueue Action](../actions/addtoqueue.md)|Entity|[!INCLUDE[../actions/descriptions/addtoqueue.md](../actions/descriptions/addtoqueue.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RetrieveUserQueues Function](../functions/retrieveuserqueues.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveuserqueues.md](../functions/descriptions/retrieveuserqueues.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/queue.md](./remarks/queue.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />