---
title: "Functional Location (msdyn_FunctionalLocation) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Functional Location (msdyn_FunctionalLocation) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Functional Location (msdyn_FunctionalLocation) table/entity reference (Microsoft Dynamics 365 Field Service)



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Functional Location (msdyn_FunctionalLocation) table extends the [Microsoft Dynamics 365 Functional Location (msdyn_FunctionalLocation) table](/dynamics365/developer/reference/entities/msdyn_functionallocation).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_Address1](#BKMK_msdyn_Address1)
- [msdyn_Address2](#BKMK_msdyn_Address2)
- [msdyn_Address3](#BKMK_msdyn_Address3)
- [msdyn_AddressName](#BKMK_msdyn_AddressName)
- [msdyn_City](#BKMK_msdyn_City)
- [msdyn_Country](#BKMK_msdyn_Country)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_PostalCode](#BKMK_msdyn_PostalCode)
- [msdyn_StateOrProvince](#BKMK_msdyn_StateOrProvince)

### <a name="BKMK_msdyn_Address1"></a> msdyn_Address1

|Property|Value|
|---|---|
|Description||
|DisplayName|**Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_address1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_Address2"></a> msdyn_Address2

|Property|Value|
|---|---|
|Description|**Street 2**|
|DisplayName|**Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_address2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_Address3"></a> msdyn_Address3

|Property|Value|
|---|---|
|Description|**Street 3**|
|DisplayName|**Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_address3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_AddressName"></a> msdyn_AddressName

|Property|Value|
|---|---|
|Description|**Address Name**|
|DisplayName|**Address Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addressname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_City"></a> msdyn_City

|Property|Value|
|---|---|
|Description|**City**|
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_msdyn_Country"></a> msdyn_Country

|Property|Value|
|---|---|
|Description|**Country/Region**|
|DisplayName|**Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|---|---|
|Description|**Latitude**|
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|---|---|
|Description|**Longitude**|
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_msdyn_PostalCode"></a> msdyn_PostalCode

|Property|Value|
|---|---|
|Description|**Postal Code**|
|DisplayName|**Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_msdyn_StateOrProvince"></a> msdyn_StateOrProvince

|Property|Value|
|---|---|
|Description|**State Or Province**|
|DisplayName|**State Or Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

Changes from [msdyn_Name (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_functionallocation#BKMK_msdyn_Name)

|Property|Value|
|---|---|
|RequiredLevel|ApplicationRequired|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_functionallocation_msdyn_nottoexceed_location](#BKMK_msdyn_functionallocation_msdyn_nottoexceed_location)
- [msdyn_msdyn_functionallocation_incident_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_incident_FunctionalLocation)
- [msdyn_msdyn_functionallocation_msdyn_agreementbookingincident_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_msdyn_agreementbookingincident_FunctionalLocation)
- [msdyn_msdyn_functionallocation_msdyn_tradecoverage_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_msdyn_tradecoverage_FunctionalLocation)
- [msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation)
- [msdyn_msdyn_functionallocation_msdyn_workorderincident_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_msdyn_workorderincident_FunctionalLocation)

### <a name="BKMK_msdyn_functionallocation_msdyn_nottoexceed_location"></a> msdyn_functionallocation_msdyn_nottoexceed_location

Many-To-One Relationship: [msdyn_nottoexceed msdyn_functionallocation_msdyn_nottoexceed_location](msdyn_nottoexceed.md#BKMK_msdyn_functionallocation_msdyn_nottoexceed_location)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`msdyn_location`|
|ReferencedEntityNavigationPropertyName|`msdyn_functionallocation_msdyn_nottoexceed_location`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_functionallocation_incident_FunctionalLocation"></a> msdyn_msdyn_functionallocation_incident_FunctionalLocation

Many-To-One Relationship: [incident msdyn_msdyn_functionallocation_incident_FunctionalLocation](incident.md#BKMK_msdyn_msdyn_functionallocation_incident_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_functionallocation_incident_FunctionalLocation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_functionallocation_msdyn_agreementbookingincident_FunctionalLocation"></a> msdyn_msdyn_functionallocation_msdyn_agreementbookingincident_FunctionalLocation

Many-To-One Relationship: [msdyn_agreementbookingincident msdyn_msdyn_functionallocation_msdyn_agreementbookingincident_FunctionalLocation](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_functionallocation_msdyn_agreementbookingincident_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_functionallocation_msdyn_agreementbookingincident_FunctionalLocation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_functionallocation_msdyn_tradecoverage_FunctionalLocation"></a> msdyn_msdyn_functionallocation_msdyn_tradecoverage_FunctionalLocation

Many-To-One Relationship: [msdyn_tradecoverage msdyn_msdyn_functionallocation_msdyn_tradecoverage_FunctionalLocation](msdyn_tradecoverage.md#BKMK_msdyn_msdyn_functionallocation_msdyn_tradecoverage_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_tradecoverage`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_functionallocation_msdyn_tradecoverage_FunctionalLocation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation"></a> msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation

Many-To-One Relationship: [msdyn_workorder msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation](msdyn_workorder.md#BKMK_msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_functionallocation_msdyn_workorderincident_FunctionalLocation"></a> msdyn_msdyn_functionallocation_msdyn_workorderincident_FunctionalLocation

Many-To-One Relationship: [msdyn_workorderincident msdyn_msdyn_functionallocation_msdyn_workorderincident_FunctionalLocation](msdyn_workorderincident.md#BKMK_msdyn_msdyn_functionallocation_msdyn_workorderincident_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_functionallocation_msdyn_workorderincident_FunctionalLocation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Customized relationships

### Customized Many-to-One relationships

#### <a name="BKMK_msdyn_FunctionalLocation_FunctionalLocationTyp"></a> msdyn_FunctionalLocation_FunctionalLocationTyp

Changes from [msdyn_FunctionalLocation_FunctionalLocationTyp (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_functionallocation#BKMK_msdyn_FunctionalLocation_FunctionalLocationTyp)

|Property|Value|
|---|---|
|CascadeConfiguration|Delete: `Restrict`|


### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

