---
title: "msdyn_rmareceiptproduct Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_rmareceiptproduct entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# msdyn_rmareceiptproduct Entity Reference

Specify RMA receipt product.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_rmareceiptproducts(*msdyn_rmareceiptproductid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_rmareceiptproducts|
|DisplayCollectionName|RMA Receipt Products|
|DisplayName|RMA Receipt Product|
|EntitySetName|msdyn_rmareceiptproducts|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_rmareceiptproducts|
|LogicalName|msdyn_rmareceiptproduct|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_rmareceiptproductid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_rmareceiptproduct|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_RMA](#BKMK_msdyn_RMA)
- [msdyn_RMAProduct](#BKMK_msdyn_RMAProduct)
- [msdyn_RMAReceipt](#BKMK_msdyn_RMAReceipt)
- [msdyn_rmareceiptproductId](#BKMK_msdyn_rmareceiptproductId)
- [msdyn_RTV](#BKMK_msdyn_RTV)
- [msdyn_RTVProduct](#BKMK_msdyn_RTVProduct)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Shows the sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|--------|-----|
|Description|Enter the quantity received.|
|DisplayName|Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quantity|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|ApplicationRequired|
|Type|Double|


### <a name="BKMK_msdyn_RMA"></a> msdyn_RMA

|Property|Value|
|--------|-----|
|Description|RMA this product relates to|
|DisplayName|RMA|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rma|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_rma|
|Type|Lookup|


### <a name="BKMK_msdyn_RMAProduct"></a> msdyn_RMAProduct

|Property|Value|
|--------|-----|
|Description|RMA Product this product relates to|
|DisplayName|RMA Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rmaproduct|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_rmaproduct|
|Type|Lookup|


### <a name="BKMK_msdyn_RMAReceipt"></a> msdyn_RMAReceipt

|Property|Value|
|--------|-----|
|Description|RMA Receipt this product relates to|
|DisplayName|RMA Receipt|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rmareceipt|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_rmareceipt|
|Type|Lookup|


### <a name="BKMK_msdyn_rmareceiptproductId"></a> msdyn_rmareceiptproductId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|RMA Receipt Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_rmareceiptproductid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_RTV"></a> msdyn_RTV

|Property|Value|
|--------|-----|
|Description|RTV this product relates to (if Product Action is RTV)|
|DisplayName|RTV|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rtv|
|RequiredLevel|None|
|Targets|msdyn_rtv|
|Type|Lookup|


### <a name="BKMK_msdyn_RTVProduct"></a> msdyn_RTVProduct

|Property|Value|
|--------|-----|
|Description|RTV Product this product relates to (if Product Action is RTV)|
|DisplayName|RTV Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rtvproduct|
|RequiredLevel|None|
|Targets|msdyn_rtvproduct|
|Type|Lookup|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the RMA Receipt Product|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the RMA Receipt Product|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Shows the time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_RMAName](#BKMK_msdyn_RMAName)
- [msdyn_RMAProductName](#BKMK_msdyn_RMAProductName)
- [msdyn_RMAReceiptName](#BKMK_msdyn_RMAReceiptName)
- [msdyn_RTVName](#BKMK_msdyn_RTVName)
- [msdyn_RTVProductName](#BKMK_msdyn_RTVProductName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_RMAName"></a> msdyn_RMAName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_rmaname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RMAProductName"></a> msdyn_RMAProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_rmaproductname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RMAReceiptName"></a> msdyn_RMAReceiptName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_rmareceiptname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RTVName"></a> msdyn_RTVName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_rtvname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RTVProductName"></a> msdyn_RTVProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_rtvproductname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_rmareceiptproduct_ActivityPointers](#BKMK_msdyn_rmareceiptproduct_ActivityPointers)
- [msdyn_rmareceiptproduct_msdyn_bookingalerts](#BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts)
- [msdyn_rmareceiptproduct_msdyn_approvals](#BKMK_msdyn_rmareceiptproduct_msdyn_approvals)
- [msdyn_rmareceiptproduct_SyncErrors](#BKMK_msdyn_rmareceiptproduct_SyncErrors)
- [msdyn_rmareceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord)
- [msdyn_rmareceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord)
- [msdyn_rmareceiptproduct_AsyncOperations](#BKMK_msdyn_rmareceiptproduct_AsyncOperations)
- [msdyn_rmareceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders)
- [msdyn_rmareceiptproduct_ProcessSession](#BKMK_msdyn_rmareceiptproduct_ProcessSession)
- [msdyn_rmareceiptproduct_BulkDeleteFailures](#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures)
- [msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rmareceiptproduct_Appointments](#BKMK_msdyn_rmareceiptproduct_Appointments)
- [msdyn_rmareceiptproduct_Emails](#BKMK_msdyn_rmareceiptproduct_Emails)
- [msdyn_rmareceiptproduct_Faxes](#BKMK_msdyn_rmareceiptproduct_Faxes)
- [msdyn_rmareceiptproduct_Letters](#BKMK_msdyn_rmareceiptproduct_Letters)
- [msdyn_rmareceiptproduct_PhoneCalls](#BKMK_msdyn_rmareceiptproduct_PhoneCalls)
- [msdyn_rmareceiptproduct_Tasks](#BKMK_msdyn_rmareceiptproduct_Tasks)
- [msdyn_rmareceiptproduct_RecurringAppointmentMasters](#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters)
- [msdyn_rmareceiptproduct_SocialActivities](#BKMK_msdyn_rmareceiptproduct_SocialActivities)
- [msdyn_rmareceiptproduct_connections1](#BKMK_msdyn_rmareceiptproduct_connections1)
- [msdyn_rmareceiptproduct_connections2](#BKMK_msdyn_rmareceiptproduct_connections2)
- [msdyn_rmareceiptproduct_Annotations](#BKMK_msdyn_rmareceiptproduct_Annotations)
- [msdyn_rmareceiptproduct_ServiceAppointments](#BKMK_msdyn_rmareceiptproduct_ServiceAppointments)
- [msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct)


### <a name="BKMK_msdyn_rmareceiptproduct_ActivityPointers"></a> msdyn_rmareceiptproduct_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_rmareceiptproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_rmareceiptproduct_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts"></a> msdyn_rmareceiptproduct_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_rmareceiptproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_rmareceiptproduct_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_msdyn_approvals"></a> msdyn_rmareceiptproduct_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_rmareceiptproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_rmareceiptproduct_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_SyncErrors"></a> msdyn_rmareceiptproduct_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_rmareceiptproduct_SyncErrors](syncerror.md#BKMK_msdyn_rmareceiptproduct_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord"></a> msdyn_rmareceiptproduct_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_rmareceiptproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord"></a> msdyn_rmareceiptproduct_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_rmareceiptproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_AsyncOperations"></a> msdyn_rmareceiptproduct_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_rmareceiptproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_rmareceiptproduct_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders"></a> msdyn_rmareceiptproduct_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_rmareceiptproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_ProcessSession"></a> msdyn_rmareceiptproduct_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_rmareceiptproduct_ProcessSession](processsession.md#BKMK_msdyn_rmareceiptproduct_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures"></a> msdyn_rmareceiptproduct_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_rmareceiptproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_Appointments"></a> msdyn_rmareceiptproduct_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_rmareceiptproduct_Appointments](appointment.md#BKMK_msdyn_rmareceiptproduct_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_Emails"></a> msdyn_rmareceiptproduct_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_rmareceiptproduct_Emails](email.md#BKMK_msdyn_rmareceiptproduct_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_Faxes"></a> msdyn_rmareceiptproduct_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_rmareceiptproduct_Faxes](fax.md#BKMK_msdyn_rmareceiptproduct_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_Letters"></a> msdyn_rmareceiptproduct_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_rmareceiptproduct_Letters](letter.md#BKMK_msdyn_rmareceiptproduct_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_PhoneCalls"></a> msdyn_rmareceiptproduct_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_rmareceiptproduct_PhoneCalls](phonecall.md#BKMK_msdyn_rmareceiptproduct_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_Tasks"></a> msdyn_rmareceiptproduct_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_rmareceiptproduct_Tasks](task.md#BKMK_msdyn_rmareceiptproduct_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters"></a> msdyn_rmareceiptproduct_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_rmareceiptproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_rmareceiptproduct_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_SocialActivities"></a> msdyn_rmareceiptproduct_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_rmareceiptproduct_SocialActivities](socialactivity.md#BKMK_msdyn_rmareceiptproduct_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_connections1"></a> msdyn_rmareceiptproduct_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_rmareceiptproduct_connections1](connection.md#BKMK_msdyn_rmareceiptproduct_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_connections2"></a> msdyn_rmareceiptproduct_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_rmareceiptproduct_connections2](connection.md#BKMK_msdyn_rmareceiptproduct_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_rmareceiptproduct_Annotations"></a> msdyn_rmareceiptproduct_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_rmareceiptproduct_Annotations](annotation.md#BKMK_msdyn_rmareceiptproduct_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_rmareceiptproduct_ServiceAppointments"></a> msdyn_rmareceiptproduct_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_rmareceiptproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_rmareceiptproduct_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_rmareceiptproduct_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct"></a> msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct

Same as msdyn_inventoryjournal entity [msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|msdyn_rmareceiptproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_rmareceiptproduct_msdyn_inventoryjournal_RMAReceiptProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_rmareceiptproduct_createdby](#BKMK_lk_msdyn_rmareceiptproduct_createdby)
- [lk_msdyn_rmareceiptproduct_createdonbehalfby](#BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby)
- [lk_msdyn_rmareceiptproduct_modifiedby](#BKMK_lk_msdyn_rmareceiptproduct_modifiedby)
- [lk_msdyn_rmareceiptproduct_modifiedonbehalfby](#BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby)
- [user_msdyn_rmareceiptproduct](#BKMK_user_msdyn_rmareceiptproduct)
- [team_msdyn_rmareceiptproduct](#BKMK_team_msdyn_rmareceiptproduct)
- [business_unit_msdyn_rmareceiptproduct](#BKMK_business_unit_msdyn_rmareceiptproduct)
- [msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA)
- [msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct](#BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct)
- [msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt](#BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt)
- [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV)
- [msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct](#BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct)


### <a name="BKMK_lk_msdyn_rmareceiptproduct_createdby"></a> lk_msdyn_rmareceiptproduct_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_rmareceiptproduct_createdby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby"></a> lk_msdyn_rmareceiptproduct_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_rmareceiptproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmareceiptproduct_modifiedby"></a> lk_msdyn_rmareceiptproduct_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_rmareceiptproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby"></a> lk_msdyn_rmareceiptproduct_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_rmareceiptproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_rmareceiptproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_rmareceiptproduct"></a> user_msdyn_rmareceiptproduct

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_rmareceiptproduct](systemuser.md#BKMK_user_msdyn_rmareceiptproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_rmareceiptproduct"></a> team_msdyn_rmareceiptproduct

**Added by**: System Solution Solution

See team Entity [team_msdyn_rmareceiptproduct](team.md#BKMK_team_msdyn_rmareceiptproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_rmareceiptproduct"></a> business_unit_msdyn_rmareceiptproduct

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_rmareceiptproduct](businessunit.md#BKMK_business_unit_msdyn_rmareceiptproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA"></a> msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA

See msdyn_rma Entity [msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA](msdyn_rma.md#BKMK_msdyn_msdyn_rma_msdyn_rmareceiptproduct_RMA) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct"></a> msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct

See msdyn_rmaproduct Entity [msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_rmaproduct_msdyn_rmareceiptproduct_RMAProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt"></a> msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt

See msdyn_rmareceipt Entity [msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt](msdyn_rmareceipt.md#BKMK_msdyn_msdyn_rmareceipt_msdyn_rmareceiptproduct_RMAReceipt) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV"></a> msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV

See msdyn_rtv Entity [msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV](msdyn_rtv.md#BKMK_msdyn_msdyn_rtv_msdyn_rmareceiptproduct_RTV) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct"></a> msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct

See msdyn_rtvproduct Entity [msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_rtvproduct_msdyn_rmareceiptproduct_RTVProduct) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_rmareceiptproduct?text=msdyn_rmareceiptproduct EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]