---
title: "msdyn_productinventory Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_productinventory entity."
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
# msdyn_productinventory Entity Reference

Inventory Record

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_productinventories<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_productinventories(*msdyn_productinventoryid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_productinventories(*msdyn_productinventoryid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_productinventories<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_productinventories(*msdyn_productinventoryid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_productinventories(*msdyn_productinventoryid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_productinventories|
|DisplayCollectionName|Product Inventory|
|DisplayName|Product Inventory|
|EntitySetName|msdyn_productinventories|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_productinventories|
|LogicalName|msdyn_productinventory|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_productinventoryid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_productinventory|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Bin](#BKMK_msdyn_Bin)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_productinventoryId](#BKMK_msdyn_productinventoryId)
- [msdyn_QtyAllocated](#BKMK_msdyn_QtyAllocated)
- [msdyn_QtyAvailable](#BKMK_msdyn_QtyAvailable)
- [msdyn_QtyOnHand](#BKMK_msdyn_QtyOnHand)
- [msdyn_QtyOnOrder](#BKMK_msdyn_QtyOnOrder)
- [msdyn_ReorderPoint](#BKMK_msdyn_ReorderPoint)
- [msdyn_Row](#BKMK_msdyn_Row)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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


### <a name="BKMK_msdyn_Bin"></a> msdyn_Bin

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Bin|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bin|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_internalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


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


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|--------|-----|
|Description|Unique identifier for Product/Service associated with Product Inventory.|
|DisplayName|Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_product|
|RequiredLevel|ApplicationRequired|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_msdyn_productinventoryId"></a> msdyn_productinventoryId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Product Inventory|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_productinventoryid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_QtyAllocated"></a> msdyn_QtyAllocated

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Quantity Allocated|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_qtyallocated|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_QtyAvailable"></a> msdyn_QtyAvailable

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Quantity Available|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_qtyavailable|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_QtyOnHand"></a> msdyn_QtyOnHand

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Quantity On Hand|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_qtyonhand|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_QtyOnOrder"></a> msdyn_QtyOnOrder

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Quantity On Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_qtyonorder|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_ReorderPoint"></a> msdyn_ReorderPoint

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Reorder Point|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_reorderpoint|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Row"></a> msdyn_Row

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Row|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_row|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|--------|-----|
|Description|Unique identifier for Unit associated with Product Inventory.|
|DisplayName|Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unit|
|RequiredLevel|ApplicationRequired|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

|Property|Value|
|--------|-----|
|Description|Unique identifier for Warehouse associated with Product Inventory.|
|DisplayName|Warehouse|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_warehouse|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_warehouse|
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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Product Inventory|
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
|Description|Reason for the status of the Product Inventory|
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
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_WarehouseName](#BKMK_msdyn_WarehouseName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
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


### <a name="BKMK_msdyn_ProductName"></a> msdyn_ProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_productname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_UnitName"></a> msdyn_UnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_unitname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WarehouseName"></a> msdyn_WarehouseName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_warehousename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|None|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Added by**: Active Solution Solution

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

- [msdyn_productinventory_ActivityPointers](#BKMK_msdyn_productinventory_ActivityPointers)
- [msdyn_productinventory_msdyn_bookingalerts](#BKMK_msdyn_productinventory_msdyn_bookingalerts)
- [msdyn_productinventory_msdyn_approvals](#BKMK_msdyn_productinventory_msdyn_approvals)
- [msdyn_productinventory_SyncErrors](#BKMK_msdyn_productinventory_SyncErrors)
- [msdyn_productinventory_DuplicateMatchingRecord](#BKMK_msdyn_productinventory_DuplicateMatchingRecord)
- [msdyn_productinventory_DuplicateBaseRecord](#BKMK_msdyn_productinventory_DuplicateBaseRecord)
- [msdyn_productinventory_AsyncOperations](#BKMK_msdyn_productinventory_AsyncOperations)
- [msdyn_productinventory_MailboxTrackingFolders](#BKMK_msdyn_productinventory_MailboxTrackingFolders)
- [msdyn_productinventory_ProcessSession](#BKMK_msdyn_productinventory_ProcessSession)
- [msdyn_productinventory_BulkDeleteFailures](#BKMK_msdyn_productinventory_BulkDeleteFailures)
- [msdyn_productinventory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses)
- [msdyn_productinventory_Appointments](#BKMK_msdyn_productinventory_Appointments)
- [msdyn_productinventory_Emails](#BKMK_msdyn_productinventory_Emails)
- [msdyn_productinventory_Faxes](#BKMK_msdyn_productinventory_Faxes)
- [msdyn_productinventory_Letters](#BKMK_msdyn_productinventory_Letters)
- [msdyn_productinventory_PhoneCalls](#BKMK_msdyn_productinventory_PhoneCalls)
- [msdyn_productinventory_Tasks](#BKMK_msdyn_productinventory_Tasks)
- [msdyn_productinventory_RecurringAppointmentMasters](#BKMK_msdyn_productinventory_RecurringAppointmentMasters)
- [msdyn_productinventory_SocialActivities](#BKMK_msdyn_productinventory_SocialActivities)
- [msdyn_productinventory_connections1](#BKMK_msdyn_productinventory_connections1)
- [msdyn_productinventory_connections2](#BKMK_msdyn_productinventory_connections2)
- [msdyn_productinventory_Annotations](#BKMK_msdyn_productinventory_Annotations)
- [msdyn_productinventory_ServiceAppointments](#BKMK_msdyn_productinventory_ServiceAppointments)


### <a name="BKMK_msdyn_productinventory_ActivityPointers"></a> msdyn_productinventory_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_productinventory_ActivityPointers](activitypointer.md#BKMK_msdyn_productinventory_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_msdyn_bookingalerts"></a> msdyn_productinventory_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_productinventory_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_productinventory_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_msdyn_approvals"></a> msdyn_productinventory_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_productinventory_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_productinventory_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_SyncErrors"></a> msdyn_productinventory_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_productinventory_SyncErrors](syncerror.md#BKMK_msdyn_productinventory_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_DuplicateMatchingRecord"></a> msdyn_productinventory_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_productinventory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_productinventory_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_DuplicateBaseRecord"></a> msdyn_productinventory_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_productinventory_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_productinventory_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_AsyncOperations"></a> msdyn_productinventory_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_productinventory_AsyncOperations](asyncoperation.md#BKMK_msdyn_productinventory_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_MailboxTrackingFolders"></a> msdyn_productinventory_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_productinventory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_productinventory_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_ProcessSession"></a> msdyn_productinventory_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_productinventory_ProcessSession](processsession.md#BKMK_msdyn_productinventory_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_BulkDeleteFailures"></a> msdyn_productinventory_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_productinventory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_productinventory_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses"></a> msdyn_productinventory_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_productinventory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_Appointments"></a> msdyn_productinventory_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_productinventory_Appointments](appointment.md#BKMK_msdyn_productinventory_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_Emails"></a> msdyn_productinventory_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_productinventory_Emails](email.md#BKMK_msdyn_productinventory_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_Faxes"></a> msdyn_productinventory_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_productinventory_Faxes](fax.md#BKMK_msdyn_productinventory_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_Letters"></a> msdyn_productinventory_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_productinventory_Letters](letter.md#BKMK_msdyn_productinventory_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_PhoneCalls"></a> msdyn_productinventory_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_productinventory_PhoneCalls](phonecall.md#BKMK_msdyn_productinventory_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_Tasks"></a> msdyn_productinventory_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_productinventory_Tasks](task.md#BKMK_msdyn_productinventory_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_RecurringAppointmentMasters"></a> msdyn_productinventory_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_productinventory_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_productinventory_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_SocialActivities"></a> msdyn_productinventory_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_productinventory_SocialActivities](socialactivity.md#BKMK_msdyn_productinventory_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_connections1"></a> msdyn_productinventory_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_productinventory_connections1](connection.md#BKMK_msdyn_productinventory_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_connections2"></a> msdyn_productinventory_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_productinventory_connections2](connection.md#BKMK_msdyn_productinventory_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_Annotations"></a> msdyn_productinventory_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_productinventory_Annotations](annotation.md#BKMK_msdyn_productinventory_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_productinventory_ServiceAppointments"></a> msdyn_productinventory_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_productinventory_ServiceAppointments](serviceappointment.md#BKMK_msdyn_productinventory_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_productinventory_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_productinventory_createdby](#BKMK_lk_msdyn_productinventory_createdby)
- [lk_msdyn_productinventory_createdonbehalfby](#BKMK_lk_msdyn_productinventory_createdonbehalfby)
- [lk_msdyn_productinventory_modifiedby](#BKMK_lk_msdyn_productinventory_modifiedby)
- [lk_msdyn_productinventory_modifiedonbehalfby](#BKMK_lk_msdyn_productinventory_modifiedonbehalfby)
- [organization_msdyn_productinventory](#BKMK_organization_msdyn_productinventory)
- [msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse)
- [msdyn_product_msdyn_productinventory_Product](#BKMK_msdyn_product_msdyn_productinventory_Product)
- [msdyn_uom_msdyn_productinventory_Unit](#BKMK_msdyn_uom_msdyn_productinventory_Unit)


### <a name="BKMK_lk_msdyn_productinventory_createdby"></a> lk_msdyn_productinventory_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_productinventory_createdby](systemuser.md#BKMK_lk_msdyn_productinventory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_productinventory_createdonbehalfby"></a> lk_msdyn_productinventory_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_productinventory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_productinventory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_productinventory_modifiedby"></a> lk_msdyn_productinventory_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_productinventory_modifiedby](systemuser.md#BKMK_lk_msdyn_productinventory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_productinventory_modifiedonbehalfby"></a> lk_msdyn_productinventory_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_productinventory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_productinventory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_productinventory"></a> organization_msdyn_productinventory

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_productinventory](organization.md#BKMK_organization_msdyn_productinventory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_productinventory_Warehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_productinventory_Product"></a> msdyn_product_msdyn_productinventory_Product

**Added by**: Product Management Solution

See product Entity [msdyn_product_msdyn_productinventory_Product](product.md#BKMK_msdyn_product_msdyn_productinventory_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_productinventory_Unit"></a> msdyn_uom_msdyn_productinventory_Unit

**Added by**: Product Management Solution

See uom Entity [msdyn_uom_msdyn_productinventory_Unit](uom.md#BKMK_msdyn_uom_msdyn_productinventory_Unit) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_productinventory?text=msdyn_productinventory EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]