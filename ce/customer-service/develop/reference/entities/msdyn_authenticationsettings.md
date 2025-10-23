---
title: "Authentication Settings (msdyn_authenticationsettings) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Authentication Settings (msdyn_authenticationsettings) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Authentication Settings (msdyn_authenticationsettings) table/entity reference (Microsoft Dynamics 365 Customer Service)

Stores the settings for user authentication

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Authentication Settings (msdyn_authenticationsettings) table extends the [Microsoft Dynamics 365 Authentication Settings (msdyn_authenticationsettings) table](/dynamics365/developer/reference/entities/msdyn_authenticationsettings).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_authserviceconfigsetid](#BKMK_msdyn_authserviceconfigsetid)
- [msdyn_authservicescopeid](#BKMK_msdyn_authservicescopeid)
- [msdyn_mappedaccountidfield](#BKMK_msdyn_mappedaccountidfield)
- [msdyn_mappedcontactidfield](#BKMK_msdyn_mappedcontactidfield)

### <a name="BKMK_msdyn_authserviceconfigsetid"></a> msdyn_authserviceconfigsetid

|Property|Value|
|---|---|
|Description|**Config Set ID for Gatekeeper authentication service**|
|DisplayName|**Config Set ID for Gatekeeper authentication service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_authserviceconfigsetid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_authservicescopeid"></a> msdyn_authservicescopeid

|Property|Value|
|---|---|
|Description|**Scope ID for Gatekeeper authentication service**|
|DisplayName|**Scope ID for Gatekeeper authentication service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_authservicescopeid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_mappedaccountidfield"></a> msdyn_mappedaccountidfield

|Property|Value|
|---|---|
|Description|**An account attribute that will be sent as the person id for Gatekeeper**|
|DisplayName|**Mapped account id field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mappedaccountidfield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_mappedcontactidfield"></a> msdyn_mappedcontactidfield

|Property|Value|
|---|---|
|Description|**A contact attribute that will be sent as the person id for Gatekeeper**|
|DisplayName|**Mapped contact field**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mappedcontactidfield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_msdyn_ocauthchanneltype"></a> msdyn_ocauthchanneltype

Changes from [msdyn_ocauthchanneltype (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_authenticationsettings#BKMK_msdyn_ocauthchanneltype)

#### msdyn_ocauthchanneltype Choices/Options

|Value|Label|
|---|---|
|192360000|**Live chat**|
|192440000|**Voice**|
|192450000|**Apple Messages For Business**|

## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_authenticationsettings_msdyn_ocapplebusinessaccount](#BKMK_msdyn_authenticationsettings_msdyn_ocapplebusinessaccount)
- [msdyn_authenticationsettings_msdyn_ocvoicechannelsetting](#BKMK_msdyn_authenticationsettings_msdyn_ocvoicechannelsetting)
- [msdyn_authenticationsettingsv2_msdyn_ocapplebusinessaccount](#BKMK_msdyn_authenticationsettingsv2_msdyn_ocapplebusinessaccount)
- [msdyn_msdyn_authsettings_msdyn_livechatconfig](#BKMK_msdyn_msdyn_authsettings_msdyn_livechatconfig)

### <a name="BKMK_msdyn_authenticationsettings_msdyn_ocapplebusinessaccount"></a> msdyn_authenticationsettings_msdyn_ocapplebusinessaccount

Many-To-One Relationship: [msdyn_ocapplebusinessaccount msdyn_authenticationsettings_msdyn_ocapplebusinessaccount](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_authenticationsettings_msdyn_ocapplebusinessaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplebusinessaccount`|
|ReferencingAttribute|`msdyn_businessauthsettingsid`|
|ReferencedEntityNavigationPropertyName|`msdyn_authenticationsettings_msdyn_ocapplebusinessaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_authenticationsettings_msdyn_ocvoicechannelsetting"></a> msdyn_authenticationsettings_msdyn_ocvoicechannelsetting

Many-To-One Relationship: [msdyn_ocvoicechannelsetting msdyn_authenticationsettings_msdyn_ocvoicechannelsetting](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_authenticationsettings_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannelsetting`|
|ReferencingAttribute|`msdyn_voiceauthenticationsettingsid`|
|ReferencedEntityNavigationPropertyName|`msdyn_authenticationsettings_msdyn_ocvoicechannelsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_authenticationsettingsv2_msdyn_ocapplebusinessaccount"></a> msdyn_authenticationsettingsv2_msdyn_ocapplebusinessaccount

Many-To-One Relationship: [msdyn_ocapplebusinessaccount msdyn_authenticationsettingsv2_msdyn_ocapplebusinessaccount](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_authenticationsettingsv2_msdyn_ocapplebusinessaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplebusinessaccount`|
|ReferencingAttribute|`msdyn_v2businessauthsettingsid`|
|ReferencedEntityNavigationPropertyName|`msdyn_authenticationsettingsv2_msdyn_ocapplebusinessaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_authsettings_msdyn_livechatconfig"></a> msdyn_msdyn_authsettings_msdyn_livechatconfig

Many-To-One Relationship: [msdyn_livechatconfig msdyn_msdyn_authsettings_msdyn_livechatconfig](msdyn_livechatconfig.md#BKMK_msdyn_msdyn_authsettings_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatconfig`|
|ReferencingAttribute|`msdyn_authsettingsid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_authsettings_msdyn_livechatconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

