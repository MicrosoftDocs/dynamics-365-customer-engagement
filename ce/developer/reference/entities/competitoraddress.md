---
title: "Competitor Address (CompetitorAddress) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Competitor Address (CompetitorAddress) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Competitor Address (CompetitorAddress) table/entity reference (Microsoft Dynamics 365)

Additional addresses for a competitor. The first two addresses are stored in the competitor object.

## Messages

The following table lists the messages for the Competitor Address (CompetitorAddress) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|

## Properties

The following table lists selected properties for the Competitor Address (CompetitorAddress) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Competitor Address** |
| **DisplayCollectionName** | **Competitor Addresses** |
| **SchemaName** | `CompetitorAddress` |
| **CollectionSchemaName** | `CompetitorAddresses` |
| **EntitySetName** | `competitoraddresses`|
| **LogicalName** | `competitoraddress` |
| **LogicalCollectionName** | `competitoraddresses` |
| **PrimaryIdAttribute** | `competitoraddressid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AddressNumber](#BKMK_AddressNumber)
- [AddressTypeCode](#BKMK_AddressTypeCode)
- [City](#BKMK_City)
- [CompetitorAddressId](#BKMK_CompetitorAddressId)
- [Country](#BKMK_Country)
- [County](#BKMK_County)
- [Fax](#BKMK_Fax)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Latitude](#BKMK_Latitude)
- [Line1](#BKMK_Line1)
- [Line2](#BKMK_Line2)
- [Line3](#BKMK_Line3)
- [Longitude](#BKMK_Longitude)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ParentId](#BKMK_ParentId)
- [PostalCode](#BKMK_PostalCode)
- [PostOfficeBox](#BKMK_PostOfficeBox)
- [ShippingMethodCode](#BKMK_ShippingMethodCode)
- [StateOrProvince](#BKMK_StateOrProvince)
- [Telephone1](#BKMK_Telephone1)
- [Telephone2](#BKMK_Telephone2)
- [Telephone3](#BKMK_Telephone3)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UPSZone](#BKMK_UPSZone)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [UTCOffset](#BKMK_UTCOffset)

### <a name="BKMK_AddressNumber"></a> AddressNumber

|Property|Value|
|---|---|
|Description|**Information about which competitor address is applicable.**|
|DisplayName|**Address Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`addressnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_AddressTypeCode"></a> AddressTypeCode

|Property|Value|
|---|---|
|Description|**Type of address for the competitor, such as primary address.**|
|DisplayName|**Address Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`addresstypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`competitoraddress_addresstypecode`|

#### AddressTypeCode Choices/Options

|Value|Label|
|---|---|

### <a name="BKMK_City"></a> City

|Property|Value|
|---|---|
|Description|**City name in the competitor address.**|
|DisplayName|**City**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_CompetitorAddressId"></a> CompetitorAddressId

|Property|Value|
|---|---|
|Description|**Unique identifier of the competitor address.**|
|DisplayName|**Competitor Address**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`competitoraddressid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_Country"></a> Country

|Property|Value|
|---|---|
|Description|**Country/region name in the competitor address.**|
|DisplayName|**Country/Region**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_County"></a> County

|Property|Value|
|---|---|
|Description|**County name in the competitor address.**|
|DisplayName|**County**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`county`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Fax"></a> Fax

|Property|Value|
|---|---|
|Description|**Fax number for the competitor address.**|
|DisplayName|**Fax**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`fax`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_Latitude"></a> Latitude

|Property|Value|
|---|---|
|Description|**Latitude for the competitor address.**|
|DisplayName|**Latitude**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_Line1"></a> Line1

|Property|Value|
|---|---|
|Description|**First line for entering address information.**|
|DisplayName|**Street 1**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`line1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Line2"></a> Line2

|Property|Value|
|---|---|
|Description|**Second line for entering address information.**|
|DisplayName|**Street 2**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`line2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Line3"></a> Line3

|Property|Value|
|---|---|
|Description|**Third line for entering address information.**|
|DisplayName|**Street 3**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`line3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_Longitude"></a> Longitude

|Property|Value|
|---|---|
|Description|**Longitude for the address for the competitor.**|
|DisplayName|**Longitude**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Name used to identify the competitor address.**|
|DisplayName|**Address Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ParentId"></a> ParentId

|Property|Value|
|---|---|
|Description|**Unique identifier of the parent object with which the competitor address is associated.**|
|DisplayName|**Parent**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`parentid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|competitor|

### <a name="BKMK_PostalCode"></a> PostalCode

|Property|Value|
|---|---|
|Description|**ZIP Code or postal code in the competitor address.**|
|DisplayName|**ZIP/Postal Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_PostOfficeBox"></a> PostOfficeBox

|Property|Value|
|---|---|
|Description|**Post office box number in the competitor address.**|
|DisplayName|**Post Office Box**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`postofficebox`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_ShippingMethodCode"></a> ShippingMethodCode

|Property|Value|
|---|---|
|Description|**Method of shipment for the competitor.**|
|DisplayName|**Shipping Method**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`shippingmethodcode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`competitoraddress_shippingmethodcode`|

#### ShippingMethodCode Choices/Options

|Value|Label|
|---|---|

### <a name="BKMK_StateOrProvince"></a> StateOrProvince

|Property|Value|
|---|---|
|Description|**State or province in the competitor address.**|
|DisplayName|**State/Province**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Telephone1"></a> Telephone1

|Property|Value|
|---|---|
|Description|**First telephone number for the competitor address.**|
|DisplayName|**Main Phone**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`telephone1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Telephone2"></a> Telephone2

|Property|Value|
|---|---|
|Description|**Second telephone number for the competitor address.**|
|DisplayName|**Phone 2**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`telephone2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_Telephone3"></a> Telephone3

|Property|Value|
|---|---|
|Description|**Third telephone number for the competitor address.**|
|DisplayName|**Phone 3**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`telephone3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UPSZone"></a> UPSZone

|Property|Value|
|---|---|
|Description|**United Parcel Service (UPS) zone for the address of the competitor.**|
|DisplayName|**UPS Zone**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`upszone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCOffset"></a> UTCOffset

|Property|Value|
|---|---|
|Description|**UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.**|
|DisplayName|**UTC Offset**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcoffset`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [Composite](#BKMK_Composite)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_Composite"></a> Composite

|Property|Value|
|---|---|
|Description|**Shows the complete address.**|
|DisplayName|**Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`composite`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the competitor address.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the competitor address was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the competitor address.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the competitor address.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the competitor address was last modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who last modified the competitor address.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [competitor_addresses](#BKMK_competitor_addresses)
- [lk_competitoraddress_createdonbehalfby](#BKMK_lk_competitoraddress_createdonbehalfby)
- [lk_competitoraddress_modifiedonbehalfby](#BKMK_lk_competitoraddress_modifiedonbehalfby)
- [lk_competitoraddressbase_createdby](#BKMK_lk_competitoraddressbase_createdby)
- [lk_competitoraddressbase_modifiedby](#BKMK_lk_competitoraddressbase_modifiedby)

### <a name="BKMK_competitor_addresses"></a> competitor_addresses

One-To-Many Relationship: [competitor competitor_addresses](competitor.md#BKMK_competitor_addresses)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`parentid`|
|ReferencingEntityNavigationPropertyName|`parentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_competitoraddress_createdonbehalfby"></a> lk_competitoraddress_createdonbehalfby

One-To-Many Relationship: [systemuser lk_competitoraddress_createdonbehalfby](systemuser.md#BKMK_lk_competitoraddress_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_competitoraddress_modifiedonbehalfby"></a> lk_competitoraddress_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_competitoraddress_modifiedonbehalfby](systemuser.md#BKMK_lk_competitoraddress_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_competitoraddressbase_createdby"></a> lk_competitoraddressbase_createdby

One-To-Many Relationship: [systemuser lk_competitoraddressbase_createdby](systemuser.md#BKMK_lk_competitoraddressbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_competitoraddressbase_modifiedby"></a> lk_competitoraddressbase_modifiedby

One-To-Many Relationship: [systemuser lk_competitoraddressbase_modifiedby](systemuser.md#BKMK_lk_competitoraddressbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [competitoraddress_AsyncOperations](#BKMK_competitoraddress_AsyncOperations)
- [competitoraddress_BulkDeleteFailures](#BKMK_competitoraddress_BulkDeleteFailures)
- [competitoraddress_MailboxTrackingFolders](#BKMK_competitoraddress_MailboxTrackingFolders)
- [competitoraddress_PrincipalObjectAttributeAccesses](#BKMK_competitoraddress_PrincipalObjectAttributeAccesses)
- [CompetitorAddress_SyncErrors](#BKMK_CompetitorAddress_SyncErrors)

### <a name="BKMK_competitoraddress_AsyncOperations"></a> competitoraddress_AsyncOperations

Many-To-One Relationship: [asyncoperation competitoraddress_AsyncOperations](asyncoperation.md#BKMK_competitoraddress_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`competitoraddress_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_competitoraddress_BulkDeleteFailures"></a> competitoraddress_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure competitoraddress_BulkDeleteFailures](bulkdeletefailure.md#BKMK_competitoraddress_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`competitoraddress_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_competitoraddress_MailboxTrackingFolders"></a> competitoraddress_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder competitoraddress_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_competitoraddress_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`competitoraddress_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_competitoraddress_PrincipalObjectAttributeAccesses"></a> competitoraddress_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess competitoraddress_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_competitoraddress_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`competitoraddress_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CompetitorAddress_SyncErrors"></a> CompetitorAddress_SyncErrors

Many-To-One Relationship: [syncerror CompetitorAddress_SyncErrors](syncerror.md#BKMK_CompetitorAddress_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`CompetitorAddress_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

