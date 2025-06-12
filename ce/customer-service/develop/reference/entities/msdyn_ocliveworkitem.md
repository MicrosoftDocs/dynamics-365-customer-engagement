---
title: "Conversation (msdyn_ocliveworkitem) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Conversation (msdyn_ocliveworkitem) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Conversation (msdyn_ocliveworkitem) table/entity reference (Microsoft Dynamics 365 Customer Service)

Tracks the interaction between the agents and customer

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Conversation (msdyn_ocliveworkitem) table extends the [Microsoft Dynamics 365 Conversation (msdyn_ocliveworkitem) table](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_channel](#BKMK_msdyn_channel)
- [RegardingObjectId](#BKMK_RegardingObjectId)

### <a name="BKMK_msdyn_channel"></a> msdyn_channel

Changes from [msdyn_channel (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_channel)

#### msdyn_channel Choices/Options

|Value|Label|
|---|---|
|19241000|**Microsoft Teams**|
|192300000|**WhatsApp**|
|192310000|**LINE**|
|192320000|**WeChat**|
|192330000|**Facebook**|
|192340000|**SMS**|
|192350001|**Twitter**|
|192350002|**Custom**|
|192360000|**Live chat**|
|192370000|**Voice**|
|192380000|**Video**|
|192390000|**Co-browse**|
|192400000|**Screen sharing**|
|192450000|**Apple Messages for Business**|
|192450001|**Google's Business Messages**|

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_msdyn_ocliveworkitems](#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)
- [msdyn_bookingrule_msdyn_ocliveworkitems](#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)
- [msdyn_resourceterritory_msdyn_ocliveworkitems](#BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems)
- [msdyn_systemuserschedulersetting_msdyn_ocliveworkitems](#BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems)
- [msdyn_timegroup_msdyn_ocliveworkitems](#BKMK_msdyn_timegroup_msdyn_ocliveworkitems)
- [msdyn_timegroupdetail_msdyn_ocliveworkitems](#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)

### <a name="BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems"></a> msdyn_bookingalertstatus_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_msdyn_ocliveworkitems](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_bookingrule_msdyn_ocliveworkitems"></a> msdyn_bookingrule_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_msdyn_ocliveworkitems](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems"></a> msdyn_resourceterritory_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_msdyn_ocliveworkitems](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems"></a> msdyn_systemuserschedulersetting_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_msdyn_ocliveworkitems](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroup_msdyn_ocliveworkitems"></a> msdyn_timegroup_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_msdyn_ocliveworkitems](msdyn_timegroup.md#BKMK_msdyn_timegroup_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems"></a> msdyn_timegroupdetail_msdyn_ocliveworkitems

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_msdyn_ocliveworkitems](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse)
- [msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid)

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse"></a> msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse

Many-To-One Relationship: [msdyn_chatquestionnaireresponse msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse](msdyn_chatquestionnaireresponse.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponse`|
|ReferencingAttribute|`msdyn_ocliveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_chatquestionnaireresponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_customengagementctx msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid](msdyn_customengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_customengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_facebookengagementctx msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid](msdyn_facebookengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_facebookengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_facebookengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_lineengagementctx msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid](msdyn_lineengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_lineengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_lineengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_livechatengagementctx msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid](msdyn_livechatengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_ocapplemessagesforbusinessengagementctx msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocapplemessagesforbusinessengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesengagementctx msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_smsengagementctx msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid](msdyn_smsengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_smsengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_teamschannelengagementctx msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid](msdyn_teamschannelengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamschannelengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_teamschannelengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_twitterengagementctx msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid](msdyn_twitterengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_twitterengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_twitterengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_wechatengagementctx msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid](msdyn_wechatengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wechatengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_wechatengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_whatsappengagementctx msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid](msdyn_whatsappengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_whatsappengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_whatsappengagementctx_liveworkitemid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

