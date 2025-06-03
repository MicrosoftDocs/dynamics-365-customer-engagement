---
title: "Custom messaging account (msdyn_ocbotchannelregistration) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Custom messaging account (msdyn_ocbotchannelregistration) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Custom messaging account (msdyn_ocbotchannelregistration) table/entity reference (Microsoft Dynamics 365 Customer Service)

Bot channel registration used for channel integration

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Custom messaging account (msdyn_ocbotchannelregistration) table extends the [Microsoft Dynamics 365 Custom messaging account (msdyn_ocbotchannelregistration) table](/dynamics365/developer/reference/entities/msdyn_ocbotchannelregistration).


## Messages

The following table lists the messages for the Custom messaging account (msdyn_ocbotchannelregistration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `msdyn_RetrieveCustomMessagingApplicationSecret`<br />Event: True |**msdyn_RetrieveCustomMessagingApplicationSecret action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Custom messaging account (msdyn_ocbotchannelregistration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Custom messaging account** |
| **DisplayCollectionName** | **Custom messaging accounts** |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_communicationprovidersettingid](#BKMK_msdyn_communicationprovidersettingid)
- [msdyn_iscustommessagingbcr](#BKMK_msdyn_iscustommessagingbcr)
- [msdyn_iscustommessagingcreated](#BKMK_msdyn_iscustommessagingcreated)
- [msdyn_lastvalidateddate](#BKMK_msdyn_lastvalidateddate)
- [msdyn_messagingendpoint](#BKMK_msdyn_messagingendpoint)
- [msdyn_msappsecret](#BKMK_msdyn_msappsecret)
- [msdyn_ocfbapplicationid](#BKMK_msdyn_ocfbapplicationid)
- [msdyn_ocgbmagentaccount](#BKMK_msdyn_ocgbmagentaccount)
- [msdyn_ocgbmpartneraccount](#BKMK_msdyn_ocgbmpartneraccount)
- [msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfigid)
- [msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfigid)
- [msdyn_securemsappsecret](#BKMK_msdyn_securemsappsecret)
- [msdyn_validationstatus](#BKMK_msdyn_validationstatus)

### <a name="BKMK_msdyn_communicationprovidersettingid"></a> msdyn_communicationprovidersettingid

|Property|Value|
|---|---|
|Description|**Unique identifier for Communication Provider Setting associated with Bot Channel Registration.**|
|DisplayName|**Communication provider setting id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_communicationprovidersettingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_occommunicationprovidersetting|

### <a name="BKMK_msdyn_iscustommessagingbcr"></a> msdyn_iscustommessagingbcr

|Property|Value|
|---|---|
|Description|**Flag to indicate if BCR entity is related to Custom Messaging**|
|DisplayName|**Is Custom Messaging BCR**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscustommessagingbcr`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocbotchannelregistration_msdyn_iscustommessagingbcr`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_iscustommessagingcreated"></a> msdyn_iscustommessagingcreated

|Property|Value|
|---|---|
|Description|**Flag to indicate if the record is newly created**|
|DisplayName|**Is Custom Messaging Created**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscustommessagingcreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocbotchannelregistration_msdyn_iscustommessagingcreated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_lastvalidateddate"></a> msdyn_lastvalidateddate

|Property|Value|
|---|---|
|Description|**Microsoft app Id and secret last validated date.**|
|DisplayName|**Last validated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastvalidateddate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_messagingendpoint"></a> msdyn_messagingendpoint

|Property|Value|
|---|---|
|Description|**Messaging Endpoint (URL)**|
|DisplayName|**Messaging Endpoint (URL)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_messagingendpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_msappsecret"></a> msdyn_msappsecret

|Property|Value|
|---|---|
|Description|**Bot channel registration client secret**|
|DisplayName|**Client secret**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_msappsecret`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocfbapplicationid"></a> msdyn_ocfbapplicationid

|Property|Value|
|---|---|
|Description|**Related Facebook application**|
|DisplayName|**Facebook application**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfbapplicationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocfbapplication|

### <a name="BKMK_msdyn_ocgbmagentaccount"></a> msdyn_ocgbmagentaccount

|Property|Value|
|---|---|
|Description|**Google's Business Messages agent account id for the BCR**|
|DisplayName|**Google's Business Messages agent account id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgbmagentaccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocgooglebusinessmessagesagentaccount|

### <a name="BKMK_msdyn_ocgbmpartneraccount"></a> msdyn_ocgbmpartneraccount

|Property|Value|
|---|---|
|Description|**Google's Business Messages partner account id of the BCR**|
|DisplayName|**Google's Business Messages partner account id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocgbmpartneraccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocgooglebusinessmessagespartneraccount|

### <a name="BKMK_msdyn_oclinechannelconfigid"></a> msdyn_oclinechannelconfigid

|Property|Value|
|---|---|
|Description|**Related Line Channel**|
|DisplayName|**Line Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_oclinechannelconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_oclinechannelconfig|

### <a name="BKMK_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfigid

|Property|Value|
|---|---|
|Description|**Related Teams Channel**|
|DisplayName|**Teams Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_octeamschannelconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_octeamschannelconfig|

### <a name="BKMK_msdyn_securemsappsecret"></a> msdyn_securemsappsecret

|Property|Value|
|---|---|
|Description|**Bot channel registration secure client secret**|
|DisplayName|**Secure Client secret**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securemsappsecret`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_validationstatus"></a> msdyn_validationstatus

|Property|Value|
|---|---|
|Description|**Microsoft app ID and secert Validation status**|
|DisplayName|**Validation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validationstatus`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider](#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider)
- [msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration](#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration)
- [msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount](#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount)
- [msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount](#BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount)
- [msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid)
- [msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid)

### <a name="BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider"></a> msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocbotchannelregistration_communicationprovider)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`msdyn_communicationprovidersettingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_communicationprovidersettingid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration"></a> msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration](msdyn_ocfbapplication.md#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocbotchannelregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`msdyn_ocfbapplicationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocfbapplicationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount"></a> msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagespartneraccount msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_msdyn_msdyn_ocgbmpartneraccount_msdyn_ocbotchannelregistration_ocgbmpartneraccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagespartneraccountid`|
|ReferencingAttribute|`msdyn_ocgbmpartneraccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocgbmpartneraccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount"></a> msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesagentaccount msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_msdyn_msdyn_ocgooglebusinessmessagesagentaccount_msdyn_ocbotchannelregistration_ocgbmagentaccount)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesagentaccountid`|
|ReferencingAttribute|`msdyn_ocgbmagentaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocgbmagentaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid"></a> msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid

One-To-Many Relationship: [msdyn_oclinechannelconfig msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_msdyn_ocbotchannelregistration_msdyn_oclinechannelconfigid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclinechannelconfig`|
|ReferencedAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_oclinechannelconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid

One-To-Many Relationship: [msdyn_octeamschannelconfig msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_msdyn_ocbotchannelregistration_msdyn_octeamschannelconfigid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octeamschannelconfig`|
|ReferencedAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_octeamschannelconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration"></a> msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration

Many-To-One Relationship: [msdyn_occustommessagingchannel msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration](msdyn_occustommessagingchannel.md#BKMK_msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`msdyn_custombotchannelregistration`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocbotchannelregistration_msdyn_occustommessagingchannel_custombotchannelregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

