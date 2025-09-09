---
title: "Provisioning State (msdyn_ocprovisioningstate) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Provisioning State (msdyn_ocprovisioningstate) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Provisioning State (msdyn_ocprovisioningstate) table/entity reference (Microsoft Dynamics 365 Customer Service)

Provisioning state

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Provisioning State (msdyn_ocprovisioningstate) table extends the [Microsoft Dynamics 365 Provisioning State (msdyn_ocprovisioningstate) table](/dynamics365/developer/reference/entities/msdyn_ocprovisioningstate).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_AutomatedCallingStatus](#BKMK_msdyn_AutomatedCallingStatus)
- [msdyn_communicationprovidersettingid](#BKMK_msdyn_communicationprovidersettingid)
- [msdyn_exceptiondetails](#BKMK_msdyn_exceptiondetails)
- [msdyn_gatekeeperstatus](#BKMK_msdyn_gatekeeperstatus)
- [msdyn_gatekeeperstatusreason](#BKMK_msdyn_gatekeeperstatusreason)
- [msdyn_ocfbapplicationid](#BKMK_msdyn_ocfbapplicationid)
- [msdyn_ocfbpageid](#BKMK_msdyn_ocfbpageid)
- [msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfigid)
- [msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfigid)
- [msdyn_ocwhatsappchannelaccountId](#BKMK_msdyn_ocwhatsappchannelaccountId)
- [msdyn_phonenumberid](#BKMK_msdyn_phonenumberid)
- [msdyn_voicechannelsettingid](#BKMK_msdyn_voicechannelsettingid)

### <a name="BKMK_msdyn_AutomatedCallingStatus"></a> msdyn_AutomatedCallingStatus

|Property|Value|
|---|---|
|Description|**Automated Calling Status for Heavy Metal Migration Automated Calling feature.**|
|DisplayName|**Automated Calling Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_automatedcallingstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_ocprovisioningstate_msdyn_automatedcallingstatus`|

#### msdyn_AutomatedCallingStatus Choices/Options

|Value|Label|
|---|---|
|0|**NotTested**|
|1|**Success**|
|2|**Failure**|
|3|**InProgress**|

### <a name="BKMK_msdyn_communicationprovidersettingid"></a> msdyn_communicationprovidersettingid

|Property|Value|
|---|---|
|Description|**Related Communication Provider Settings**|
|DisplayName|**CommunicationProviderSettings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_communicationprovidersettingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_occommunicationprovidersetting|

### <a name="BKMK_msdyn_exceptiondetails"></a> msdyn_exceptiondetails

|Property|Value|
|---|---|
|Description|**Exception Details during channel provisioning**|
|DisplayName|**Error Message (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_exceptiondetails`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8192|

### <a name="BKMK_msdyn_gatekeeperstatus"></a> msdyn_gatekeeperstatus

|Property|Value|
|---|---|
|Description|**Provisioning Status for GateKeeper**|
|DisplayName|**GateKeeper Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gatekeeperstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocprovisioningstate_msdyn_gatekeeperstatus`|

#### msdyn_gatekeeperstatus Choices/Options

|Value|Label|
|---|---|
|715240000|**Active**|
|715240001|**Inactive**|

### <a name="BKMK_msdyn_gatekeeperstatusreason"></a> msdyn_gatekeeperstatusreason

|Property|Value|
|---|---|
|Description|**Provisioning Status Reason for GateKeeper**|
|DisplayName|**GateKeeper Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gatekeeperstatusreason`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocprovisioningstate_msdyn_gatekeeperstatusreason`|

#### msdyn_gatekeeperstatusreason Choices/Options

|Value|Label|
|---|---|
|0|**Running**|
|1|**Error**|
|2|**Deprovisioned**|

### <a name="BKMK_msdyn_ocfbapplicationid"></a> msdyn_ocfbapplicationid

|Property|Value|
|---|---|
|Description|**Related Facebook application**|
|DisplayName|**Facebook Application**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfbapplicationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocfbapplication|

### <a name="BKMK_msdyn_ocfbpageid"></a> msdyn_ocfbpageid

|Property|Value|
|---|---|
|Description|**Related Facebook page**|
|DisplayName|**Facebook Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfbpageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocfbpage|

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

### <a name="BKMK_msdyn_ocwhatsappchannelaccountId"></a> msdyn_ocwhatsappchannelaccountId

|Property|Value|
|---|---|
|Description|**Related WhatsApp Account**|
|DisplayName|**WhatsApp Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocwhatsappchannelaccountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocwhatsappchannelaccount|

### <a name="BKMK_msdyn_phonenumberid"></a> msdyn_phonenumberid

|Property|Value|
|---|---|
|Description|**Related Phone Number**|
|DisplayName|**Phone Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumberid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocphonenumber|

### <a name="BKMK_msdyn_voicechannelsettingid"></a> msdyn_voicechannelsettingid

|Property|Value|
|---|---|
|Description||
|DisplayName|**voicechannelsettingsid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_voicechannelsettingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocvoicechannelsetting|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_statuscode"></a> statuscode

Changes from [statuscode (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocprovisioningstate#BKMK_statuscode)

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350005|Label: Deprovisioning|
|192350006|Label: Deprovisioned<br />State: 1|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid](#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid)
- [msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate](#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate)
- [msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate](#BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate)
- [msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid](#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid)
- [msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid](#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid)
- [msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid)
- [msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid)
- [msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId](#BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId)

### <a name="BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid"></a> msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`msdyn_communicationprovidersettingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_communicationprovidersettingid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate"></a> msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate](msdyn_ocfbapplication.md#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`msdyn_ocfbapplicationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocfbapplicationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate"></a> msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate

One-To-Many Relationship: [msdyn_ocfbpage msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate](msdyn_ocfbpage.md#BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbpage`|
|ReferencedAttribute|`msdyn_ocfbpageid`|
|ReferencingAttribute|`msdyn_ocfbpageid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocfbpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid"></a> msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid](msdyn_ocphonenumber.md#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencingEntityNavigationPropertyName|`msdyn_phonenumberid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid"></a> msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid

One-To-Many Relationship: [msdyn_ocvoicechannelsetting msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannelsetting`|
|ReferencedAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencingAttribute|`msdyn_voicechannelsettingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_voicechannelsettingid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid"></a> msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid

One-To-Many Relationship: [msdyn_oclinechannelconfig msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclinechannelconfig`|
|ReferencedAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_oclinechannelconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid"></a> msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid

One-To-Many Relationship: [msdyn_octeamschannelconfig msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octeamschannelconfig`|
|ReferencedAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_octeamschannelconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId"></a> msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId

One-To-Many Relationship: [msdyn_ocwhatsappchannelaccount msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId](msdyn_ocwhatsappchannelaccount.md#BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelaccountid`|
|ReferencingAttribute|`msdyn_ocwhatsappchannelaccountid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocwhatsappchannelaccountId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

