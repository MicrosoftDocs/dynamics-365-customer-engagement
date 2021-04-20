---
title: "Queue Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the Queue entity."
ms.date: 04/01/2021
ms.service: "crm-online"
ms.topic: "reference"
author: "mh-jaya"
ms.author: "v-jmh"
manager: "shujoshi"
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---
# Queue Entity Reference

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

A list of records that require action, such as accounts, activities, and cases.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|AddPrincipalToQueue|<xref href="Microsoft.Dynamics.CRM.AddPrincipalToQueue?text=AddPrincipalToQueue Action" />|<xref:Microsoft.Crm.Sdk.Messages.AddPrincipalToQueueRequest>|
|Assign|PATCH [*org URI*]/api/data/v9.0/queues(*queueid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/queues<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/queues(*queueid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/queues(*queueid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/queues<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RetrieveUserQueues|<xref href="Microsoft.Dynamics.CRM.RetrieveUserQueues?text=RetrieveUserQueues Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUserQueuesRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/queues(*queueid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/queues(*queueid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Queues|
|DisplayCollectionName|Queues|
|DisplayName|Queue|
|EntitySetName|queues|
|IsBPFEntity|False|
|LogicalCollectionName|queues|
|LogicalName|queue|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|queueid|
|PrimaryNameAttribute|name|
|SchemaName|Queue|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BusinessUnitId](#BKMK_BusinessUnitId)
- [Description](#BKMK_Description)
- [EMailAddress](#BKMK_EMailAddress)
- [EmailRouterAccessApproval](#BKMK_EmailRouterAccessApproval)
- [EntityImage](#BKMK_EntityImage)
- [IgnoreUnsolicitedEmail](#BKMK_IgnoreUnsolicitedEmail)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IncomingEmailDeliveryMethod](#BKMK_IncomingEmailDeliveryMethod)
- [IncomingEmailFilteringMethod](#BKMK_IncomingEmailFilteringMethod)
- [msdyn_assignmentinputcontractid](#BKMK_msdyn_assignmentinputcontractid)
- [msdyn_assignmentstrategy](#BKMK_msdyn_assignmentstrategy)
- [msdyn_isdefaultqueue](#BKMK_msdyn_isdefaultqueue)
- [msdyn_isomnichannelqueue](#BKMK_msdyn_isomnichannelqueue)
- [msdyn_operatinghourid](#BKMK_msdyn_operatinghourid)
- [msdyn_priority](#BKMK_msdyn_priority)
- [msdyn_queuetype](#BKMK_msdyn_queuetype)
- [Name](#BKMK_Name)
- [OutgoingEmailDeliveryMethod](#BKMK_OutgoingEmailDeliveryMethod)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PrimaryUserId](#BKMK_PrimaryUserId)
- [QueueId](#BKMK_QueueId)
- [QueueViewType](#BKMK_QueueViewType)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)


### <a name="BKMK_BusinessUnitId"></a> BusinessUnitId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit with which the queue is associated.|
|DisplayName|Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitid|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the queue.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_EMailAddress"></a> EMailAddress

|Property|Value|
|--------|-----|
|Description|Email address that is associated with the queue.|
|DisplayName|Incoming Email|
|FormatName|Email|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailaddress|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EmailRouterAccessApproval"></a> EmailRouterAccessApproval

|Property|Value|
|--------|-----|
|Description|Shows the status of the primary email address.|
|DisplayName|Primary Email Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailrouteraccessapproval|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### EmailRouterAccessApproval Options

|Value|Label|
|-----|-----|
|0|Empty|
|1|Approved|
|2|Pending Approval|
|3|Rejected|



### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|--------|-----|
|Description|The default image for the entity.|
|DisplayName|Entity Image|
|IsPrimaryImage|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_IgnoreUnsolicitedEmail"></a> IgnoreUnsolicitedEmail

|Property|Value|
|--------|-----|
|Description|Information that specifies whether a queue is to ignore unsolicited email (deprecated).|
|DisplayName|Convert To Email Activities|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ignoreunsolicitedemail|
|RequiredLevel|None|
|Type|Boolean|

#### IgnoreUnsolicitedEmail Options

|Value|Label|
|-----|-----|
|1|Only specific Emails|
|0|All incoming Emails|

**DefaultValue**: False



### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IncomingEmailDeliveryMethod"></a> IncomingEmailDeliveryMethod

|Property|Value|
|--------|-----|
|Description|Incoming email delivery method for the queue.|
|DisplayName|Incoming Email Delivery Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|incomingemaildeliverymethod|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### IncomingEmailDeliveryMethod Options

|Value|Label|
|-----|-----|
|0|None|
|2|Server-Side Synchronization or Email Router|
|3|Forward Mailbox|



### <a name="BKMK_IncomingEmailFilteringMethod"></a> IncomingEmailFilteringMethod

|Property|Value|
|--------|-----|
|Description|Convert Incoming Email To Activities|
|DisplayName|Convert Incoming Email To Activities|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|incomingemailfilteringmethod|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### IncomingEmailFilteringMethod Options

|Value|Label|
|-----|-----|
|0|All email messages|
|1|Email messages in response to Dynamics 365 email|
|2|Email messages from Dynamics 365 Leads, Contacts and Accounts|
|3|Email messages from Dynamics 365 records that are email enabled|
|4|No email messages|



### <a name="BKMK_msdyn_assignmentinputcontractid"></a> msdyn_assignmentinputcontractid

**Added by**: Dynamics 365 UR OmnichanelBase Dependency Solution

|Property|Value|
|--------|-----|
|Description|Link assignment input contract with queue.|
|DisplayName|Assignment Input Contract Id|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_assignmentinputcontractid|
|RequiredLevel|None|
|Targets|msdyn_decisioncontract|
|Type|Lookup|


### <a name="BKMK_msdyn_assignmentstrategy"></a> msdyn_assignmentstrategy

**Added by**: Dynamics 365 UR OmnichanelBase Dependency Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Assignment Strategy|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_assignmentstrategy|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_assignmentstrategy Options

|Value|Label|
|-----|-----|
|192350000|Omnichannel Assignment|
|192350001|Round Robin|
|192350002|Custom Assignment Configuration|



### <a name="BKMK_msdyn_isdefaultqueue"></a> msdyn_isdefaultqueue

**Added by**: Omnichannel – Base Solution

|Property|Value|
|--------|-----|
|Description|Shows whether the queue is set as default or not.|
|DisplayName|Is Default Queue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isdefaultqueue|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_isdefaultqueue Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_isomnichannelqueue"></a> msdyn_isomnichannelqueue

**Added by**: Omnichannel – Base Solution

|Property|Value|
|--------|-----|
|Description|Shows whether the queue is used as Omnichannel queue for work distribution.|
|DisplayName|Is Omnichannel queue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isomnichannelqueue|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_isomnichannelqueue Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_operatinghourid"></a> msdyn_operatinghourid

**Added by**: Omnichannel - Base Patch Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for Operating hour associated with Queue|
|DisplayName|Operating Hours|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_operatinghourid|
|RequiredLevel|None|
|Targets|msdyn_operatinghour|
|Type|Lookup|


### <a name="BKMK_msdyn_priority"></a> msdyn_priority

**Added by**: Omnichannel – Base Solution

|Property|Value|
|--------|-----|
|Description|Priority of the queue to indicate conversation assignment order to the agent.|
|DisplayName|Priority|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_priority|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_queuetype"></a> msdyn_queuetype

**Added by**: Omnichannel - Base Patch Solution

|Property|Value|
|--------|-----|
|Description|Defines the type of channels handled by this queue|
|DisplayName|Queue type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_queuetype|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_queuetype Options

|Value|Label|
|-----|-----|
|192350000|Messaging|
|192350001|Entity|



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the queue.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_OutgoingEmailDeliveryMethod"></a> OutgoingEmailDeliveryMethod

|Property|Value|
|--------|-----|
|Description|Outgoing email delivery method for the queue.|
|DisplayName|Outgoing Email Delivery Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|outgoingemaildeliverymethod|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### OutgoingEmailDeliveryMethod Options

|Value|Label|
|-----|-----|
|0|None|
|2|Server-Side Synchronization or Email Router|



### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the queue.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PrimaryUserId"></a> PrimaryUserId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the owner of the queue.|
|DisplayName|Owner (deprecated)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primaryuserid|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_QueueId"></a> QueueId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the queue.|
|DisplayName|Queue|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|queueid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_QueueViewType"></a> QueueViewType

|Property|Value|
|--------|-----|
|Description|Select whether the queue is public or private. A public queue can be viewed by all. A private queue can be viewed only by the members added to the queue.|
|DisplayName|Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|queueviewtype|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### QueueViewType Options

|Value|Label|
|-----|-----|
|0|Public|
|1|Private|



### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the queue.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the queue.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|SystemRequired|
|Type|Status|

#### StatusCode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the queue.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AllowEmailCredentials](#BKMK_AllowEmailCredentials)
- [BusinessUnitIdName](#BKMK_BusinessUnitIdName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [DefaultMailbox](#BKMK_DefaultMailbox)
- [DefaultMailboxName](#BKMK_DefaultMailboxName)
- [EmailPassword](#BKMK_EmailPassword)
- [EmailUsername](#BKMK_EmailUsername)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsEmailAddressApprovedByO365Admin](#BKMK_IsEmailAddressApprovedByO365Admin)
- [IsFaxQueue](#BKMK_IsFaxQueue)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_assignmentinputcontractidName](#BKMK_msdyn_assignmentinputcontractidName)
- [msdyn_operatinghouridName](#BKMK_msdyn_operatinghouridName)
- [NumberOfItems](#BKMK_NumberOfItems)
- [NumberOfMembers](#BKMK_NumberOfMembers)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PrimaryUserIdName](#BKMK_PrimaryUserIdName)
- [PrimaryUserIdYomiName](#BKMK_PrimaryUserIdYomiName)
- [QueueTypeCode](#BKMK_QueueTypeCode)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AllowEmailCredentials"></a> AllowEmailCredentials

|Property|Value|
|--------|-----|
|Description|This attribute is no longer used. The data is now in the Mailbox.AllowEmailConnectorToUseCredentials attribute.|
|DisplayName|Allow to Use Credentials for Email Processing (Obsolete)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|allowemailcredentials|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowEmailCredentials Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_BusinessUnitIdName"></a> BusinessUnitIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|businessunitidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the queue record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the queue was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the queue.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DefaultMailbox"></a> DefaultMailbox

|Property|Value|
|--------|-----|
|Description|Select the mailbox associated with this queue.|
|DisplayName|Mailbox|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultmailbox|
|RequiredLevel|None|
|Targets|mailbox|
|Type|Lookup|


### <a name="BKMK_DefaultMailboxName"></a> DefaultMailboxName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultmailboxname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EmailPassword"></a> EmailPassword

|Property|Value|
|--------|-----|
|Description|This attribute is no longer used. The data is now in the Mailbox.Password attribute.|
|DisplayName|Password (Obsolete)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailpassword|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EmailUsername"></a> EmailUsername

|Property|Value|
|--------|-----|
|Description|This attribute is no longer used. The data is now in the Mailbox.UserName attribute.|
|DisplayName|User Name (Obsolete)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|emailusername|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Entity Image Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|--------|-----|
|Description|Exchange rate for the currency associated with the queue with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_IsEmailAddressApprovedByO365Admin"></a> IsEmailAddressApprovedByO365Admin

|Property|Value|
|--------|-----|
|Description|Shows the status of approval of the email address by O365 Admin.|
|DisplayName|Email Address O365 Admin Approval Status|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isemailaddressapprovedbyo365admin|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsEmailAddressApprovedByO365Admin Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsFaxQueue"></a> IsFaxQueue

|Property|Value|
|--------|-----|
|Description|Indication of whether a queue is the fax delivery queue.|
|DisplayName|Fax Queue|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isfaxqueue|
|RequiredLevel|None|
|Type|Boolean|

#### IsFaxQueue Options

|Value|Label|
|-----|-----|
|1|Fax Queue|
|0|Non-fax Queue|

**DefaultValue**: False



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the queue.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the queue was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the queue.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_assignmentinputcontractidName"></a> msdyn_assignmentinputcontractidName

**Added by**: Dynamics 365 UR OmnichanelBase Dependency Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_assignmentinputcontractidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_operatinghouridName"></a> msdyn_operatinghouridName

**Added by**: Omnichannel - Base Patch Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_operatinghouridname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_NumberOfItems"></a> NumberOfItems

|Property|Value|
|--------|-----|
|Description|Number of Queue items associated with the queue.|
|DisplayName|Queue Items|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|numberofitems|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_NumberOfMembers"></a> NumberOfMembers

|Property|Value|
|--------|-----|
|Description|Number of Members associated with the queue.|
|DisplayName|No. of Members|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|numberofmembers|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the queue.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the queue.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier of the team who owns the queue.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns the queue.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_PrimaryUserIdName"></a> PrimaryUserIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primaryuseridname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PrimaryUserIdYomiName"></a> PrimaryUserIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|primaryuseridyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_QueueTypeCode"></a> QueueTypeCode

|Property|Value|
|--------|-----|
|Description|Type of queue that is automatically assigned when a user or queue is created. The type can be public, private, or work in process.|
|DisplayName|Queue Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|queuetypecode|
|RequiredLevel|None|
|Type|Picklist|

#### QueueTypeCode Options

|Value|Label|
|-----|-----|
|1|Default Value|



### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the queue.|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|



### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)