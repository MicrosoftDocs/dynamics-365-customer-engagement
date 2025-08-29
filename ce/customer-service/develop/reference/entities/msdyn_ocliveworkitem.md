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


## Messages

The following table lists the messages for the Conversation (msdyn_ocliveworkitem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `CCaaS_AcceptCall`<br />Event: False |**CCaaS_AcceptCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_AcceptPhoneCall`<br />Event: False |**CCaaS_AcceptPhoneCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_BargeInToCall`<br />Event: False |**CCaaS_BargeInToCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_CloseExternalSession`<br />Event: False |**CCaaS_CloseExternalSession action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_EndCall`<br />Event: False |**CCaaS_EndCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_EndPhoneCall`<br />Event: False |**CCaaS_EndPhoneCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_ExternalCallReject`<br />Event: False |**CCaaS_ExternalCallReject action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_ExternalCallTransfer`<br />Event: False |**CCaaS_ExternalCallTransfer action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_GetCallState`<br />Event: False |**CCaaS_GetCallState action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_HoldCall`<br />Event: False |**CCaaS_HoldCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_InitiateExternalTransfer`<br />Event: False |**CCaaS_InitiateExternalTransfer action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_PauseRecordingAndTranscription`<br />Event: False |**CCaaS_PauseRecordingAndTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_RejectExternalTransfer`<br />Event: False |**CCaaS_RejectExternalTransfer action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_ResumeRecordingAndTranscription`<br />Event: False |**CCaaS_ResumeRecordingAndTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_StartRecordingAndTranscription`<br />Event: False |**CCaaS_StartRecordingAndTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_StartTranscription`<br />Event: False |**CCaaS_StartTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_StopTranscription`<br />Event: False |**CCaaS_StopTranscription action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `CCaaS_UnholdCall`<br />Event: False |**CCaaS_UnholdCall action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|


## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_channel](#BKMK_msdyn_channel)
- [msdyn_routableobjectid](#BKMK_msdyn_routableobjectid)
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
|192440000|**Voice call**|
|192450000|**Apple Messages for Business**|
|192450001|**Google's Business Messages**|

### <a name="BKMK_msdyn_routableobjectid"></a> msdyn_routableobjectid

Changes from [msdyn_routableobjectid (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_routableobjectid)

|Property|Value|
|---|---|
|Targets|msdyn_ocvoicemail|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dynamics 365)](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_bookingalertstatus, msdyn_bookingrule, msdyn_resourceterritory, msdyn_systemuserschedulersetting, msdyn_timegroup, msdyn_timegroupdetail|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_bookingalertstatus_msdyn_ocliveworkitems](#BKMK_msdyn_bookingalertstatus_msdyn_ocliveworkitems)
- [msdyn_bookingrule_msdyn_ocliveworkitems](#BKMK_msdyn_bookingrule_msdyn_ocliveworkitems)
- [msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid](#BKMK_msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid)
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

### <a name="BKMK_msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid"></a> msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid](msdyn_ocvoicemail.md#BKMK_msdyn_ocliveworkitem_msdyn_ocvoicemail_msdyn_routableobjectid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_routableobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_routableobjectid_msdyn_ocvoicemail_msdyn_ocliveworkitem_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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
- [msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgooglebusinessmessagesengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid)
- [msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail)
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

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_ocgatekeeperengagementctx msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid](msdyn_ocgatekeeperengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocgatekeeperengagementctx_liveworkitemid`|
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

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid

Many-To-One Relationship: [msdyn_ocphonecallengagementctx msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid](msdyn_ocphonecallengagementctx.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonecallengagementctx`|
|ReferencingAttribute|`msdyn_liveworkitemid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocphonecallengagementctx_liveworkitemid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail"></a> msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail](msdyn_ocvoicemail.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`msdyn_missedconversationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocliveworkitem_msdyn_ocvoicemail`|
|IsCustomizable|`True`|
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

