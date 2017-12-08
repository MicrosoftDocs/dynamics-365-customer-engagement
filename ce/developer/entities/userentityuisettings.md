---
title: "UserEntityUISettings Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the UserEntityUISettings entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# UserEntityUISettings Entity Reference

Stores user settings for entity views.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/userentityuisettingsset<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/userentityuisettingsset(*userentityuisettingsid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/userentityuisettingsset(*userentityuisettingsid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/userentityuisettingsset<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/userentityuisettingsset(*userentityuisettingsid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|UserEntityUISettingses|
|DisplayCollectionName|User Entity UI Settings|
|DisplayName|User Entity UI Settings|
|EntitySetName|userentityuisettingsset|
|IsBPFEntity|False|
|LogicalCollectionName|userentityuisettingses|
|LogicalName|userentityuisettings|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|userentityuisettingsid|
|PrimaryNameAttribute||
|SchemaName|UserEntityUISettings|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [InsertIntoEmailMRUXml](#BKMK_InsertIntoEmailMRUXml)
- [LastViewedFormXml](#BKMK_LastViewedFormXml)
- [LookupMRUXml](#BKMK_LookupMRUXml)
- [MRUXml](#BKMK_MRUXml)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [ReadingPaneXml](#BKMK_ReadingPaneXml)
- [RecentlyViewedXml](#BKMK_RecentlyViewedXml)
- [ShowInAddressBook](#BKMK_ShowInAddressBook)
- [TabOrderXml](#BKMK_TabOrderXml)
- [UserEntityUISettingsId](#BKMK_UserEntityUISettingsId)


### <a name="BKMK_InsertIntoEmailMRUXml"></a> InsertIntoEmailMRUXml

|Property|Value|
|--------|-----|
|Description|Describes which entities are most recently inserted into email for this entity|
|DisplayName|Most Recently Inserted Into Email Xml|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|insertintoemailmruxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_LastViewedFormXml"></a> LastViewedFormXml

|Property|Value|
|--------|-----|
|Description|Describes which forms are most recently viewed for this entity.|
|DisplayName|Last Viewed Form Xml|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|lastviewedformxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_LookupMRUXml"></a> LookupMRUXml

|Property|Value|
|--------|-----|
|Description|List of most recently used lookup references for this entity|
|DisplayName|Most Recently Used Xml|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|lookupmruxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_MRUXml"></a> MRUXml

|Property|Value|
|--------|-----|
|Description|Describes which tabs are most recently used for this entity|
|DisplayName|Most Recently Used Xml|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mruxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Object Type Code|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|objecttypecode|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the settings.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Type of the owner of the saved view, such as user, team, or business unit.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_ReadingPaneXml"></a> ReadingPaneXml

|Property|Value|
|--------|-----|
|Description|Describes the reading pane formatting of this entity|
|DisplayName|Conditional formatting|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|readingpanexml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_RecentlyViewedXml"></a> RecentlyViewedXml

|Property|Value|
|--------|-----|
|Description|Describes which objects are most recently viewed for this entity|
|DisplayName|Most Recently Viewed Objects|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recentlyviewedxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_ShowInAddressBook"></a> ShowInAddressBook

|Property|Value|
|--------|-----|
|Description|Determines whether a record type is exposed in the Outlook Address Book|
|DisplayName|Show In Address Book|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|showinaddressbook|
|RequiredLevel|None|
|Type|Boolean|

#### ShowInAddressBook Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_TabOrderXml"></a> TabOrderXml

|Property|Value|
|--------|-----|
|Description|Describes the tab ordering for this entity|
|DisplayName|Tab Order Xml|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|taborderxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_UserEntityUISettingsId"></a> UserEntityUISettingsId

|Property|Value|
|--------|-----|
|Description|Unique identifier user entity|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|userentityuisettingsid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner of the saved view.|
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
|Description|Unique identifier of the business unit that owns this.|
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
|Description|Unique identifier of the team who owns this saved view.|
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
|Description|Unique identifier of the user who owns this saved view.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
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


### <a name="BKMK_userentityinstancedata_userentityuisettings"></a> userentityinstancedata_userentityuisettings

Same as userentityinstancedata entity [userentityinstancedata_userentityuisettings](userentityinstancedata.md#BKMK_userentityinstancedata_userentityuisettings) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_userentityuisettings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [team_userentityuisettings](#BKMK_team_userentityuisettings)
- [userentityuisettings_businessunit](#BKMK_userentityuisettings_businessunit)
- [userentityuisettings_owning_user](#BKMK_userentityuisettings_owning_user)


### <a name="BKMK_team_userentityuisettings"></a> team_userentityuisettings

See team Entity [team_userentityuisettings](team.md#BKMK_team_userentityuisettings) One-To-Many relationship.

### <a name="BKMK_userentityuisettings_businessunit"></a> userentityuisettings_businessunit

See businessunit Entity [userentityuisettings_businessunit](businessunit.md#BKMK_userentityuisettings_businessunit) One-To-Many relationship.

### <a name="BKMK_userentityuisettings_owning_user"></a> userentityuisettings_owning_user

See systemuser Entity [userentityuisettings_owning_user](systemuser.md#BKMK_userentityuisettings_owning_user) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.userentityuisettings?text=userentityuisettings EntityType" />