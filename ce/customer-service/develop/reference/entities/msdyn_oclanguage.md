---
title: "Language (msdyn_oclanguage) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Language (msdyn_oclanguage) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Language (msdyn_oclanguage) table/entity reference (Microsoft Dynamics 365 Customer Service)



> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Language (msdyn_oclanguage) table extends the [Microsoft Dynamics 365 Language (msdyn_oclanguage) table](/dynamics365/developer/reference/entities/msdyn_oclanguage).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage)
- [msdyn_msdyn_oclanguage_msdyn_ocapplebusinessaccount_ocwidgetlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocapplebusinessaccount_ocwidgetlanguage)
- [msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage)
- [msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage)
- [msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage)
- [msdyn_msdyn_oclanguage_msdyn_oclinechannelconfig_lineaccountlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_oclinechannelconfig_lineaccountlanguage)
- [msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale)
- [msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage)
- [msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage)
- [msdyn_msdyn_oclanguage_msdyn_octwitterhandle_twitterhandlelanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_octwitterhandle_twitterhandlelanguage)
- [msdyn_msdyn_oclanguage_msdyn_ocvoicechannellanguagesetting_languageid](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocvoicechannellanguagesetting_languageid)
- [msdyn_msdyn_oclanguage_msdyn_ocwechatchannelconfig_wechataccountlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocwechatchannelconfig_wechataccountlanguage)
- [msdyn_msdyn_oclanguage_msdyn_ocwhatsappchannelnumber_whatsappnumberlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_ocwhatsappchannelnumber_whatsappnumberlanguage)
- [msdyn_msdyn_oclanguage_msdyn_smsnumber_SMSnumberlanguage](#BKMK_msdyn_msdyn_oclanguage_msdyn_smsnumber_SMSnumberlanguage)
- [msdyn_oclanguage_msdyn_ocvoice_languageid](#BKMK_msdyn_oclanguage_msdyn_ocvoice_languageid)
- [msdyn_ocoutboundmessage_occustomerlocale](#BKMK_msdyn_ocoutboundmessage_occustomerlocale)

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage"></a> msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage

Many-To-One Relationship: [msdyn_livechatconfig msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage](msdyn_livechatconfig.md#BKMK_msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatconfig`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_livechatconfig_ocWidgetLanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocapplebusinessaccount_ocwidgetlanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocapplebusinessaccount_ocwidgetlanguage

Many-To-One Relationship: [msdyn_ocapplebusinessaccount msdyn_msdyn_oclanguage_msdyn_ocapplebusinessaccount_ocwidgetlanguage](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocapplebusinessaccount_ocwidgetlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplebusinessaccount`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_ocapplebusinessaccount_ocwidgetlanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage"></a> msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage

Many-To-One Relationship: [msdyn_occustommessagingchannel msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage](msdyn_occustommessagingchannel.md#BKMK_msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_occustommessagingchannel_custommessagingchannellanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage

Many-To-One Relationship: [msdyn_ocfbpage msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage](msdyn_ocfbpage.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocfbpage`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_ocfbpage_facebookpagelanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesagentaccount msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_ocgooglebusinessmessagesagentaccount_ocwidgetlanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_oclinechannelconfig_lineaccountlanguage"></a> msdyn_msdyn_oclanguage_msdyn_oclinechannelconfig_lineaccountlanguage

Many-To-One Relationship: [msdyn_oclinechannelconfig msdyn_msdyn_oclanguage_msdyn_oclinechannelconfig_lineaccountlanguage](msdyn_oclinechannelconfig.md#BKMK_msdyn_msdyn_oclanguage_msdyn_oclinechannelconfig_lineaccountlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclinechannelconfig`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_oclinechannelconfig_lineaccountlanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale"></a> msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale

Many-To-One Relationship: [msdyn_ocoutboundconfiguration msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale](msdyn_ocoutboundconfiguration.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundconfiguration`|
|ReferencingAttribute|`msdyn_defaultlocale`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_ocoutboundconfiguration_defaultlocale`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage

Many-To-One Relationship: [msdyn_ocsmschannelsetting msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage](msdyn_ocsmschannelsetting.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsmschannelsetting`|
|ReferencingAttribute|`msdyn_language`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_ocsmschannelsetting_ocsmschannelsettinglanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage"></a> msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage

Many-To-One Relationship: [msdyn_octeamschannelconfig msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage](msdyn_octeamschannelconfig.md#BKMK_msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octeamschannelconfig`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_octeamschannelconfig_teamsaccountlanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_octwitterhandle_twitterhandlelanguage"></a> msdyn_msdyn_oclanguage_msdyn_octwitterhandle_twitterhandlelanguage

Many-To-One Relationship: [msdyn_octwitterhandle msdyn_msdyn_oclanguage_msdyn_octwitterhandle_twitterhandlelanguage](msdyn_octwitterhandle.md#BKMK_msdyn_msdyn_oclanguage_msdyn_octwitterhandle_twitterhandlelanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandle`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_octwitterhandle_twitterhandlelanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocvoicechannellanguagesetting_languageid"></a> msdyn_msdyn_oclanguage_msdyn_ocvoicechannellanguagesetting_languageid

Many-To-One Relationship: [msdyn_ocvoicechannellanguagesetting msdyn_msdyn_oclanguage_msdyn_ocvoicechannellanguagesetting_languageid](msdyn_ocvoicechannellanguagesetting.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocvoicechannellanguagesetting_languageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencingAttribute|`msdyn_languageid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_ocvoicechannellanguagesetting_languageid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocwechatchannelconfig_wechataccountlanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocwechatchannelconfig_wechataccountlanguage

Many-To-One Relationship: [msdyn_ocwechatchannelconfig msdyn_msdyn_oclanguage_msdyn_ocwechatchannelconfig_wechataccountlanguage](msdyn_ocwechatchannelconfig.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocwechatchannelconfig_wechataccountlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwechatchannelconfig`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_ocwechatchannelconfig_wechataccountlanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_ocwhatsappchannelnumber_whatsappnumberlanguage"></a> msdyn_msdyn_oclanguage_msdyn_ocwhatsappchannelnumber_whatsappnumberlanguage

Many-To-One Relationship: [msdyn_ocwhatsappchannelnumber msdyn_msdyn_oclanguage_msdyn_ocwhatsappchannelnumber_whatsappnumberlanguage](msdyn_ocwhatsappchannelnumber.md#BKMK_msdyn_msdyn_oclanguage_msdyn_ocwhatsappchannelnumber_whatsappnumberlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_ocwhatsappchannelnumber_whatsappnumberlanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_oclanguage_msdyn_smsnumber_SMSnumberlanguage"></a> msdyn_msdyn_oclanguage_msdyn_smsnumber_SMSnumberlanguage

Many-To-One Relationship: [msdyn_smsnumber msdyn_msdyn_oclanguage_msdyn_smsnumber_SMSnumberlanguage](msdyn_smsnumber.md#BKMK_msdyn_msdyn_oclanguage_msdyn_smsnumber_SMSnumberlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsnumber`|
|ReferencingAttribute|`msdyn_ocwidgetlanguage`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_oclanguage_msdyn_smsnumber_SMSnumberlanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_oclanguage_msdyn_ocvoice_languageid"></a> msdyn_oclanguage_msdyn_ocvoice_languageid

Many-To-One Relationship: [msdyn_ocvoice msdyn_oclanguage_msdyn_ocvoice_languageid](msdyn_ocvoice.md#BKMK_msdyn_oclanguage_msdyn_ocvoice_languageid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoice`|
|ReferencingAttribute|`msdyn_languageid`|
|ReferencedEntityNavigationPropertyName|`msdyn_oclanguage_msdyn_ocvoice_languageid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_occustomerlocale"></a> msdyn_ocoutboundmessage_occustomerlocale

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_occustomerlocale](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_occustomerlocale)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`msdyn_occustomerlocale`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_occustomerlocale`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

