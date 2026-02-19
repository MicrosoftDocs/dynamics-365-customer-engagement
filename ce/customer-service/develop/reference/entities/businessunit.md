---
title: "Business Unit (BusinessUnit) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Business Unit (BusinessUnit) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Business Unit (BusinessUnit) table/entity reference (Microsoft Dynamics 365 Customer Service)

Business, division, or department in the Microsoft Dynamics 365 database.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Business Unit (BusinessUnit) table extends the [Microsoft Dynamics 365 Business Unit (BusinessUnit) table](/dynamics365/developer/reference/entities/businessunit).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [business_unit_msdyn_actual](#BKMK_business_unit_msdyn_actual)
- [business_unit_msdyn_amsbuild](#BKMK_business_unit_msdyn_amsbuild)
- [business_unit_msdyn_amsmodel](#BKMK_business_unit_msdyn_amsmodel)
- [business_unit_msdyn_amsprofile](#BKMK_business_unit_msdyn_amsprofile)
- [business_unit_msdyn_amsprofilesettings](#BKMK_business_unit_msdyn_amsprofilesettings)
- [business_unit_msdyn_amstag](#BKMK_business_unit_msdyn_amstag)
- [business_unit_msdyn_azurenotificationhub](#BKMK_business_unit_msdyn_azurenotificationhub)
- [business_unit_msdyn_bookableresourceassociation](#BKMK_business_unit_msdyn_bookableresourceassociation)
- [business_unit_msdyn_bookingalertstatus](#BKMK_business_unit_msdyn_bookingalertstatus)
- [business_unit_msdyn_bookingchange](#BKMK_business_unit_msdyn_bookingchange)
- [business_unit_msdyn_bookingrule](#BKMK_business_unit_msdyn_bookingrule)
- [business_unit_msdyn_bookingsetupmetadata](#BKMK_business_unit_msdyn_bookingsetupmetadata)
- [business_unit_msdyn_businessclosure](#BKMK_business_unit_msdyn_businessclosure)
- [business_unit_msdyn_channel](#BKMK_business_unit_msdyn_channel)
- [business_unit_msdyn_channelinstancesecret](#BKMK_business_unit_msdyn_channelinstancesecret)
- [business_unit_msdyn_chatansweroption](#BKMK_business_unit_msdyn_chatansweroption)
- [business_unit_msdyn_chatquestionnaireresponse](#BKMK_business_unit_msdyn_chatquestionnaireresponse)
- [business_unit_msdyn_chatquestionnaireresponseitem](#BKMK_business_unit_msdyn_chatquestionnaireresponseitem)
- [business_unit_msdyn_chatwidgetlanguage](#BKMK_business_unit_msdyn_chatwidgetlanguage)
- [business_unit_msdyn_clientextension](#BKMK_business_unit_msdyn_clientextension)
- [business_unit_msdyn_configuration](#BKMK_business_unit_msdyn_configuration)
- [business_unit_msdyn_conversation_attribute](#BKMK_business_unit_msdyn_conversation_attribute)
- [business_unit_msdyn_customengagementctx](#BKMK_business_unit_msdyn_customengagementctx)
- [business_unit_msdyn_facebookengagementctx](#BKMK_business_unit_msdyn_facebookengagementctx)
- [business_unit_msdyn_lineengagementctx](#BKMK_business_unit_msdyn_lineengagementctx)
- [business_unit_msdyn_livechatconfig](#BKMK_business_unit_msdyn_livechatconfig)
- [business_unit_msdyn_livechatengagementctx](#BKMK_business_unit_msdyn_livechatengagementctx)
- [business_unit_msdyn_livechatwidgetlocation](#BKMK_business_unit_msdyn_livechatwidgetlocation)
- [business_unit_msdyn_ocapplebusinessaccount](#BKMK_business_unit_msdyn_ocapplebusinessaccount)
- [business_unit_msdyn_ocapplemessagesforbusinessengagementctx](#BKMK_business_unit_msdyn_ocapplemessagesforbusinessengagementctx)
- [business_unit_msdyn_ocapplepay](#BKMK_business_unit_msdyn_ocapplepay)
- [business_unit_msdyn_occarrier](#BKMK_business_unit_msdyn_occarrier)
- [business_unit_msdyn_occommunicationprovidersetting](#BKMK_business_unit_msdyn_occommunicationprovidersetting)
- [business_unit_msdyn_occommunicationprovidersettingentry](#BKMK_business_unit_msdyn_occommunicationprovidersettingentry)
- [business_unit_msdyn_occustommessagingchannel](#BKMK_business_unit_msdyn_occustommessagingchannel)
- [business_unit_msdyn_occustomneuralvoice](#BKMK_business_unit_msdyn_occustomneuralvoice)
- [business_unit_msdyn_ocexternalsecuritysetting](#BKMK_business_unit_msdyn_ocexternalsecuritysetting)
- [business_unit_msdyn_ocfbapplication](#BKMK_business_unit_msdyn_ocfbapplication)
- [business_unit_msdyn_ocfbpage](#BKMK_business_unit_msdyn_ocfbpage)
- [business_unit_msdyn_ocgatekeeperengagementctx](#BKMK_business_unit_msdyn_ocgatekeeperengagementctx)
- [business_unit_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_business_unit_msdyn_ocgooglebusinessmessagesagentaccount)
- [business_unit_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_business_unit_msdyn_ocgooglebusinessmessagesengagementctx)
- [business_unit_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_business_unit_msdyn_ocgooglebusinessmessagespartneraccount)
- [business_unit_msdyn_oclinechannelconfig](#BKMK_business_unit_msdyn_oclinechannelconfig)
- [business_unit_msdyn_ocoutboundconfiguration](#BKMK_business_unit_msdyn_ocoutboundconfiguration)
- [business_unit_msdyn_ocphonecallengagementctx](#BKMK_business_unit_msdyn_ocphonecallengagementctx)
- [business_unit_msdyn_ocphonemusic](#BKMK_business_unit_msdyn_ocphonemusic)
- [business_unit_msdyn_ocphonenumber](#BKMK_business_unit_msdyn_ocphonenumber)
- [business_unit_msdyn_ocsmssettingsecret](#BKMK_business_unit_msdyn_ocsmssettingsecret)
- [business_unit_msdyn_octeamschannelconfig](#BKMK_business_unit_msdyn_octeamschannelconfig)
- [business_unit_msdyn_octwitterapplication](#BKMK_business_unit_msdyn_octwitterapplication)
- [business_unit_msdyn_octwitterhandle](#BKMK_business_unit_msdyn_octwitterhandle)
- [business_unit_msdyn_octwitterhandleprovisioningstatus](#BKMK_business_unit_msdyn_octwitterhandleprovisioningstatus)
- [business_unit_msdyn_octwitterhandlesecret](#BKMK_business_unit_msdyn_octwitterhandlesecret)
- [business_unit_msdyn_ocvoice](#BKMK_business_unit_msdyn_ocvoice)
- [business_unit_msdyn_ocvoicechannellanguagesetting](#BKMK_business_unit_msdyn_ocvoicechannellanguagesetting)
- [business_unit_msdyn_ocvoicechannelsetting](#BKMK_business_unit_msdyn_ocvoicechannelsetting)
- [business_unit_msdyn_ocwechatchannelconfig](#BKMK_business_unit_msdyn_ocwechatchannelconfig)
- [business_unit_msdyn_ocwhatsappchannelaccount](#BKMK_business_unit_msdyn_ocwhatsappchannelaccount)
- [business_unit_msdyn_ocwhatsappchannelnumber](#BKMK_business_unit_msdyn_ocwhatsappchannelnumber)
- [business_unit_msdyn_optimizationrequest](#BKMK_business_unit_msdyn_optimizationrequest)
- [business_unit_msdyn_priority](#BKMK_business_unit_msdyn_priority)
- [business_unit_msdyn_proactive_delivery](#BKMK_business_unit_msdyn_proactive_delivery)
- [business_unit_msdyn_proactive_delivery_attribute](#BKMK_business_unit_msdyn_proactive_delivery_attribute)
- [business_unit_msdyn_proactive_delivery_batch](#BKMK_business_unit_msdyn_proactive_delivery_batch)
- [business_unit_msdyn_proactive_eng_config_characteristic](#BKMK_business_unit_msdyn_proactive_eng_config_characteristic)
- [business_unit_msdyn_proactive_engagement_config](#BKMK_business_unit_msdyn_proactive_engagement_config)
- [business_unit_msdyn_proactive_engagement_config_attribute](#BKMK_business_unit_msdyn_proactive_engagement_config_attribute)
- [business_unit_msdyn_proactive_engagement_config_status](#BKMK_business_unit_msdyn_proactive_engagement_config_status)
- [business_unit_msdyn_proactive_engagement_message_template](#BKMK_business_unit_msdyn_proactive_engagement_message_template)
- [business_unit_msdyn_proactive_engagement_planner_config](#BKMK_business_unit_msdyn_proactive_engagement_planner_config)
- [business_unit_msdyn_questionsequence](#BKMK_business_unit_msdyn_questionsequence)
- [business_unit_msdyn_requirementchange](#BKMK_business_unit_msdyn_requirementchange)
- [business_unit_msdyn_requirementcharacteristic](#BKMK_business_unit_msdyn_requirementcharacteristic)
- [business_unit_msdyn_requirementdependency](#BKMK_business_unit_msdyn_requirementdependency)
- [business_unit_msdyn_requirementgroup](#BKMK_business_unit_msdyn_requirementgroup)
- [business_unit_msdyn_requirementorganizationunit](#BKMK_business_unit_msdyn_requirementorganizationunit)
- [business_unit_msdyn_requirementrelationship](#BKMK_business_unit_msdyn_requirementrelationship)
- [business_unit_msdyn_requirementresourcecategory](#BKMK_business_unit_msdyn_requirementresourcecategory)
- [business_unit_msdyn_requirementresourcepreference](#BKMK_business_unit_msdyn_requirementresourcepreference)
- [business_unit_msdyn_requirementstatus](#BKMK_business_unit_msdyn_requirementstatus)
- [business_unit_msdyn_resourcerequirement](#BKMK_business_unit_msdyn_resourcerequirement)
- [business_unit_msdyn_resourcerequirementdetail](#BKMK_business_unit_msdyn_resourcerequirementdetail)
- [business_unit_msdyn_resourceterritory](#BKMK_business_unit_msdyn_resourceterritory)
- [business_unit_msdyn_scenario](#BKMK_business_unit_msdyn_scenario)
- [business_unit_msdyn_scheduleboardsetting](#BKMK_business_unit_msdyn_scheduleboardsetting)
- [business_unit_msdyn_schedulingfeatureflag](#BKMK_business_unit_msdyn_schedulingfeatureflag)
- [business_unit_msdyn_schedulingscope](#BKMK_business_unit_msdyn_schedulingscope)
- [business_unit_msdyn_smsengagementctx](#BKMK_business_unit_msdyn_smsengagementctx)
- [business_unit_msdyn_smsnumber](#BKMK_business_unit_msdyn_smsnumber)
- [business_unit_msdyn_surveyquestion](#BKMK_business_unit_msdyn_surveyquestion)
- [business_unit_msdyn_systemuserschedulersetting](#BKMK_business_unit_msdyn_systemuserschedulersetting)
- [business_unit_msdyn_teamschannelengagementctx](#BKMK_business_unit_msdyn_teamschannelengagementctx)
- [business_unit_msdyn_timegroup](#BKMK_business_unit_msdyn_timegroup)
- [business_unit_msdyn_timegroupdetail](#BKMK_business_unit_msdyn_timegroupdetail)
- [business_unit_msdyn_transactionorigin](#BKMK_business_unit_msdyn_transactionorigin)
- [business_unit_msdyn_twitterengagementctx](#BKMK_business_unit_msdyn_twitterengagementctx)
- [business_unit_msdyn_voicechannelorganizationsetting](#BKMK_business_unit_msdyn_voicechannelorganizationsetting)
- [business_unit_msdyn_webengagementruleset](#BKMK_business_unit_msdyn_webengagementruleset)
- [business_unit_msdyn_webengagementrulesetconfig](#BKMK_business_unit_msdyn_webengagementrulesetconfig)
- [business_unit_msdyn_webengagementrulesetrevision](#BKMK_business_unit_msdyn_webengagementrulesetrevision)
- [business_unit_msdyn_webengagementsitearea](#BKMK_business_unit_msdyn_webengagementsitearea)
- [business_unit_msdyn_wechatengagementctx](#BKMK_business_unit_msdyn_wechatengagementctx)
- [business_unit_msdyn_whatsappengagementctx](#BKMK_business_unit_msdyn_whatsappengagementctx)
- [business_unit_msdyn_workhourtemplate](#BKMK_business_unit_msdyn_workhourtemplate)
- [msdyn_bookingalert_businessunit_owningbusinessunit](#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit)
- [msdyn_ocoutboundmessage_businessunit_owningbusinessunit](#BKMK_msdyn_ocoutboundmessage_businessunit_owningbusinessunit)
- [msdyn_ocvoicemail_businessunit_owningbusinessunit](#BKMK_msdyn_ocvoicemail_businessunit_owningbusinessunit)

### <a name="BKMK_business_unit_msdyn_actual"></a> business_unit_msdyn_actual

Many-To-One Relationship: [msdyn_actual business_unit_msdyn_actual](msdyn_actual.md#BKMK_business_unit_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_amsbuild"></a> business_unit_msdyn_amsbuild

Many-To-One Relationship: [msdyn_amsbuild business_unit_msdyn_amsbuild](msdyn_amsbuild.md#BKMK_business_unit_msdyn_amsbuild)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsbuild`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_amsbuild`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_amsmodel"></a> business_unit_msdyn_amsmodel

Many-To-One Relationship: [msdyn_amsmodel business_unit_msdyn_amsmodel](msdyn_amsmodel.md#BKMK_business_unit_msdyn_amsmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsmodel`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_amsmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_amsprofile"></a> business_unit_msdyn_amsprofile

Many-To-One Relationship: [msdyn_amsprofile business_unit_msdyn_amsprofile](msdyn_amsprofile.md#BKMK_business_unit_msdyn_amsprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsprofile`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_amsprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_amsprofilesettings"></a> business_unit_msdyn_amsprofilesettings

Many-To-One Relationship: [msdyn_amsprofilesettings business_unit_msdyn_amsprofilesettings](msdyn_amsprofilesettings.md#BKMK_business_unit_msdyn_amsprofilesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsprofilesettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_amsprofilesettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_amstag"></a> business_unit_msdyn_amstag

Many-To-One Relationship: [msdyn_amstag business_unit_msdyn_amstag](msdyn_amstag.md#BKMK_business_unit_msdyn_amstag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amstag`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_amstag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_azurenotificationhub"></a> business_unit_msdyn_azurenotificationhub

Many-To-One Relationship: [msdyn_azurenotificationhub business_unit_msdyn_azurenotificationhub](msdyn_azurenotificationhub.md#BKMK_business_unit_msdyn_azurenotificationhub)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_azurenotificationhub`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_azurenotificationhub`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookableresourceassociation"></a> business_unit_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation business_unit_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_business_unit_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookableresourceassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingalertstatus"></a> business_unit_msdyn_bookingalertstatus

Many-To-One Relationship: [msdyn_bookingalertstatus business_unit_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_business_unit_msdyn_bookingalertstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingalertstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingchange"></a> business_unit_msdyn_bookingchange

Many-To-One Relationship: [msdyn_bookingchange business_unit_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_business_unit_msdyn_bookingchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingrule"></a> business_unit_msdyn_bookingrule

Many-To-One Relationship: [msdyn_bookingrule business_unit_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_business_unit_msdyn_bookingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookingsetupmetadata"></a> business_unit_msdyn_bookingsetupmetadata

Many-To-One Relationship: [msdyn_bookingsetupmetadata business_unit_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_business_unit_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookingsetupmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_businessclosure"></a> business_unit_msdyn_businessclosure

Many-To-One Relationship: [msdyn_businessclosure business_unit_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_business_unit_msdyn_businessclosure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_businessclosure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channel"></a> business_unit_msdyn_channel

Many-To-One Relationship: [msdyn_channel business_unit_msdyn_channel](msdyn_channel.md#BKMK_business_unit_msdyn_channel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channel`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channelinstancesecret"></a> business_unit_msdyn_channelinstancesecret

Many-To-One Relationship: [msdyn_channelinstancesecret business_unit_msdyn_channelinstancesecret](msdyn_channelinstancesecret.md#BKMK_business_unit_msdyn_channelinstancesecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstancesecret`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channelinstancesecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_chatansweroption"></a> business_unit_msdyn_chatansweroption

Many-To-One Relationship: [msdyn_chatansweroption business_unit_msdyn_chatansweroption](msdyn_chatansweroption.md#BKMK_business_unit_msdyn_chatansweroption)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatansweroption`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_chatansweroption`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_chatquestionnaireresponse"></a> business_unit_msdyn_chatquestionnaireresponse

Many-To-One Relationship: [msdyn_chatquestionnaireresponse business_unit_msdyn_chatquestionnaireresponse](msdyn_chatquestionnaireresponse.md#BKMK_business_unit_msdyn_chatquestionnaireresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponse`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_chatquestionnaireresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_chatquestionnaireresponseitem"></a> business_unit_msdyn_chatquestionnaireresponseitem

Many-To-One Relationship: [msdyn_chatquestionnaireresponseitem business_unit_msdyn_chatquestionnaireresponseitem](msdyn_chatquestionnaireresponseitem.md#BKMK_business_unit_msdyn_chatquestionnaireresponseitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponseitem`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_chatquestionnaireresponseitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_chatwidgetlanguage"></a> business_unit_msdyn_chatwidgetlanguage

Many-To-One Relationship: [msdyn_chatwidgetlanguage business_unit_msdyn_chatwidgetlanguage](msdyn_chatwidgetlanguage.md#BKMK_business_unit_msdyn_chatwidgetlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatwidgetlanguage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_chatwidgetlanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_clientextension"></a> business_unit_msdyn_clientextension

Many-To-One Relationship: [msdyn_clientextension business_unit_msdyn_clientextension](msdyn_clientextension.md#BKMK_business_unit_msdyn_clientextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_clientextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_configuration"></a> business_unit_msdyn_configuration

Many-To-One Relationship: [msdyn_configuration business_unit_msdyn_configuration](msdyn_configuration.md#BKMK_business_unit_msdyn_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversation_attribute"></a> business_unit_msdyn_conversation_attribute

Many-To-One Relationship: [msdyn_conversation_attribute business_unit_msdyn_conversation_attribute](msdyn_conversation_attribute.md#BKMK_business_unit_msdyn_conversation_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversation_attribute`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversation_attribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_customengagementctx"></a> business_unit_msdyn_customengagementctx

Many-To-One Relationship: [msdyn_customengagementctx business_unit_msdyn_customengagementctx](msdyn_customengagementctx.md#BKMK_business_unit_msdyn_customengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_customengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_facebookengagementctx"></a> business_unit_msdyn_facebookengagementctx

Many-To-One Relationship: [msdyn_facebookengagementctx business_unit_msdyn_facebookengagementctx](msdyn_facebookengagementctx.md#BKMK_business_unit_msdyn_facebookengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_facebookengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_facebookengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_lineengagementctx"></a> business_unit_msdyn_lineengagementctx

Many-To-One Relationship: [msdyn_lineengagementctx business_unit_msdyn_lineengagementctx](msdyn_lineengagementctx.md#BKMK_business_unit_msdyn_lineengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_lineengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_lineengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_livechatconfig"></a> business_unit_msdyn_livechatconfig

Many-To-One Relationship: [msdyn_livechatconfig business_unit_msdyn_livechatconfig](msdyn_livechatconfig.md#BKMK_business_unit_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_livechatconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_livechatengagementctx"></a> business_unit_msdyn_livechatengagementctx

Many-To-One Relationship: [msdyn_livechatengagementctx business_unit_msdyn_livechatengagementctx](msdyn_livechatengagementctx.md#BKMK_business_unit_msdyn_livechatengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_livechatengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_livechatwidgetlocation"></a> business_unit_msdyn_livechatwidgetlocation

Many-To-One Relationship: [msdyn_livechatwidgetlocation business_unit_msdyn_livechatwidgetlocation](msdyn_livechatwidgetlocation.md#BKMK_business_unit_msdyn_livechatwidgetlocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatwidgetlocation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_livechatwidgetlocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocapplebusinessaccount"></a> business_unit_msdyn_ocapplebusinessaccount

Many-To-One Relationship: [msdyn_ocapplebusinessaccount business_unit_msdyn_ocapplebusinessaccount](msdyn_ocapplebusinessaccount.md#BKMK_business_unit_msdyn_ocapplebusinessaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplebusinessaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocapplebusinessaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocapplemessagesforbusinessengagementctx"></a> business_unit_msdyn_ocapplemessagesforbusinessengagementctx

Many-To-One Relationship: [msdyn_ocapplemessagesforbusinessengagementctx business_unit_msdyn_ocapplemessagesforbusinessengagementctx](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_business_unit_msdyn_ocapplemessagesforbusinessengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocapplemessagesforbusinessengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocapplepay"></a> business_unit_msdyn_ocapplepay

Many-To-One Relationship: [msdyn_ocapplepay business_unit_msdyn_ocapplepay](msdyn_ocapplepay.md#BKMK_business_unit_msdyn_ocapplepay)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplepay`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocapplepay`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_occarrier"></a> business_unit_msdyn_occarrier

Many-To-One Relationship: [msdyn_occarrier business_unit_msdyn_occarrier](msdyn_occarrier.md#BKMK_business_unit_msdyn_occarrier)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occarrier`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_occarrier`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_occommunicationprovidersetting"></a> business_unit_msdyn_occommunicationprovidersetting

Many-To-One Relationship: [msdyn_occommunicationprovidersetting business_unit_msdyn_occommunicationprovidersetting](msdyn_occommunicationprovidersetting.md#BKMK_business_unit_msdyn_occommunicationprovidersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occommunicationprovidersetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_occommunicationprovidersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_occommunicationprovidersettingentry"></a> business_unit_msdyn_occommunicationprovidersettingentry

Many-To-One Relationship: [msdyn_occommunicationprovidersettingentry business_unit_msdyn_occommunicationprovidersettingentry](msdyn_occommunicationprovidersettingentry.md#BKMK_business_unit_msdyn_occommunicationprovidersettingentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occommunicationprovidersettingentry`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_occommunicationprovidersettingentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_occustommessagingchannel"></a> business_unit_msdyn_occustommessagingchannel

Many-To-One Relationship: [msdyn_occustommessagingchannel business_unit_msdyn_occustommessagingchannel](msdyn_occustommessagingchannel.md#BKMK_business_unit_msdyn_occustommessagingchannel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_occustommessagingchannel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_occustomneuralvoice"></a> business_unit_msdyn_occustomneuralvoice

Many-To-One Relationship: [msdyn_occustomneuralvoice business_unit_msdyn_occustomneuralvoice](msdyn_occustomneuralvoice.md#BKMK_business_unit_msdyn_occustomneuralvoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustomneuralvoice`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_occustomneuralvoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocexternalsecuritysetting"></a> business_unit_msdyn_ocexternalsecuritysetting

Many-To-One Relationship: [msdyn_ocexternalsecuritysetting business_unit_msdyn_ocexternalsecuritysetting](msdyn_ocexternalsecuritysetting.md#BKMK_business_unit_msdyn_ocexternalsecuritysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalsecuritysetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocexternalsecuritysetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocfbapplication"></a> business_unit_msdyn_ocfbapplication

Many-To-One Relationship: [msdyn_ocfbapplication business_unit_msdyn_ocfbapplication](msdyn_ocfbapplication.md#BKMK_business_unit_msdyn_ocfbapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocfbapplication`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocfbapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocfbpage"></a> business_unit_msdyn_ocfbpage

Many-To-One Relationship: [msdyn_ocfbpage business_unit_msdyn_ocfbpage](msdyn_ocfbpage.md#BKMK_business_unit_msdyn_ocfbpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocfbpage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocfbpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocgatekeeperengagementctx"></a> business_unit_msdyn_ocgatekeeperengagementctx

Many-To-One Relationship: [msdyn_ocgatekeeperengagementctx business_unit_msdyn_ocgatekeeperengagementctx](msdyn_ocgatekeeperengagementctx.md#BKMK_business_unit_msdyn_ocgatekeeperengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocgatekeeperengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocgooglebusinessmessagesagentaccount"></a> business_unit_msdyn_ocgooglebusinessmessagesagentaccount

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesagentaccount business_unit_msdyn_ocgooglebusinessmessagesagentaccount](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_business_unit_msdyn_ocgooglebusinessmessagesagentaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocgooglebusinessmessagesagentaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocgooglebusinessmessagesengagementctx"></a> business_unit_msdyn_ocgooglebusinessmessagesengagementctx

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesengagementctx business_unit_msdyn_ocgooglebusinessmessagesengagementctx](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_business_unit_msdyn_ocgooglebusinessmessagesengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocgooglebusinessmessagesengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocgooglebusinessmessagespartneraccount"></a> business_unit_msdyn_ocgooglebusinessmessagespartneraccount

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagespartneraccount business_unit_msdyn_ocgooglebusinessmessagespartneraccount](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_business_unit_msdyn_ocgooglebusinessmessagespartneraccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocgooglebusinessmessagespartneraccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_oclinechannelconfig"></a> business_unit_msdyn_oclinechannelconfig

Many-To-One Relationship: [msdyn_oclinechannelconfig business_unit_msdyn_oclinechannelconfig](msdyn_oclinechannelconfig.md#BKMK_business_unit_msdyn_oclinechannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclinechannelconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_oclinechannelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocoutboundconfiguration"></a> business_unit_msdyn_ocoutboundconfiguration

Many-To-One Relationship: [msdyn_ocoutboundconfiguration business_unit_msdyn_ocoutboundconfiguration](msdyn_ocoutboundconfiguration.md#BKMK_business_unit_msdyn_ocoutboundconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocoutboundconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocphonecallengagementctx"></a> business_unit_msdyn_ocphonecallengagementctx

Many-To-One Relationship: [msdyn_ocphonecallengagementctx business_unit_msdyn_ocphonecallengagementctx](msdyn_ocphonecallengagementctx.md#BKMK_business_unit_msdyn_ocphonecallengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonecallengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocphonecallengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocphonemusic"></a> business_unit_msdyn_ocphonemusic

Many-To-One Relationship: [msdyn_ocphonemusic business_unit_msdyn_ocphonemusic](msdyn_ocphonemusic.md#BKMK_business_unit_msdyn_ocphonemusic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonemusic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocphonemusic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocphonenumber"></a> business_unit_msdyn_ocphonenumber

Many-To-One Relationship: [msdyn_ocphonenumber business_unit_msdyn_ocphonenumber](msdyn_ocphonenumber.md#BKMK_business_unit_msdyn_ocphonenumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonenumber`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocphonenumber`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsmssettingsecret"></a> business_unit_msdyn_ocsmssettingsecret

Many-To-One Relationship: [msdyn_ocsmssettingsecret business_unit_msdyn_ocsmssettingsecret](msdyn_ocsmssettingsecret.md#BKMK_business_unit_msdyn_ocsmssettingsecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsmssettingsecret`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsmssettingsecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_octeamschannelconfig"></a> business_unit_msdyn_octeamschannelconfig

Many-To-One Relationship: [msdyn_octeamschannelconfig business_unit_msdyn_octeamschannelconfig](msdyn_octeamschannelconfig.md#BKMK_business_unit_msdyn_octeamschannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octeamschannelconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_octeamschannelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_octwitterapplication"></a> business_unit_msdyn_octwitterapplication

Many-To-One Relationship: [msdyn_octwitterapplication business_unit_msdyn_octwitterapplication](msdyn_octwitterapplication.md#BKMK_business_unit_msdyn_octwitterapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterapplication`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_octwitterapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_octwitterhandle"></a> business_unit_msdyn_octwitterhandle

Many-To-One Relationship: [msdyn_octwitterhandle business_unit_msdyn_octwitterhandle](msdyn_octwitterhandle.md#BKMK_business_unit_msdyn_octwitterhandle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_octwitterhandle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_octwitterhandleprovisioningstatus"></a> business_unit_msdyn_octwitterhandleprovisioningstatus

Many-To-One Relationship: [msdyn_octwitterhandleprovisioningstatus business_unit_msdyn_octwitterhandleprovisioningstatus](msdyn_octwitterhandleprovisioningstatus.md#BKMK_business_unit_msdyn_octwitterhandleprovisioningstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandleprovisioningstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_octwitterhandleprovisioningstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_octwitterhandlesecret"></a> business_unit_msdyn_octwitterhandlesecret

Many-To-One Relationship: [msdyn_octwitterhandlesecret business_unit_msdyn_octwitterhandlesecret](msdyn_octwitterhandlesecret.md#BKMK_business_unit_msdyn_octwitterhandlesecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandlesecret`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_octwitterhandlesecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocvoice"></a> business_unit_msdyn_ocvoice

Many-To-One Relationship: [msdyn_ocvoice business_unit_msdyn_ocvoice](msdyn_ocvoice.md#BKMK_business_unit_msdyn_ocvoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoice`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocvoice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocvoicechannellanguagesetting"></a> business_unit_msdyn_ocvoicechannellanguagesetting

Many-To-One Relationship: [msdyn_ocvoicechannellanguagesetting business_unit_msdyn_ocvoicechannellanguagesetting](msdyn_ocvoicechannellanguagesetting.md#BKMK_business_unit_msdyn_ocvoicechannellanguagesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocvoicechannellanguagesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocvoicechannelsetting"></a> business_unit_msdyn_ocvoicechannelsetting

Many-To-One Relationship: [msdyn_ocvoicechannelsetting business_unit_msdyn_ocvoicechannelsetting](msdyn_ocvoicechannelsetting.md#BKMK_business_unit_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannelsetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocvoicechannelsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocwechatchannelconfig"></a> business_unit_msdyn_ocwechatchannelconfig

Many-To-One Relationship: [msdyn_ocwechatchannelconfig business_unit_msdyn_ocwechatchannelconfig](msdyn_ocwechatchannelconfig.md#BKMK_business_unit_msdyn_ocwechatchannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwechatchannelconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocwechatchannelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocwhatsappchannelaccount"></a> business_unit_msdyn_ocwhatsappchannelaccount

Many-To-One Relationship: [msdyn_ocwhatsappchannelaccount business_unit_msdyn_ocwhatsappchannelaccount](msdyn_ocwhatsappchannelaccount.md#BKMK_business_unit_msdyn_ocwhatsappchannelaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocwhatsappchannelaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocwhatsappchannelnumber"></a> business_unit_msdyn_ocwhatsappchannelnumber

Many-To-One Relationship: [msdyn_ocwhatsappchannelnumber business_unit_msdyn_ocwhatsappchannelnumber](msdyn_ocwhatsappchannelnumber.md#BKMK_business_unit_msdyn_ocwhatsappchannelnumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocwhatsappchannelnumber`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_optimizationrequest"></a> business_unit_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest business_unit_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_business_unit_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_optimizationrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_priority"></a> business_unit_msdyn_priority

Many-To-One Relationship: [msdyn_priority business_unit_msdyn_priority](msdyn_priority.md#BKMK_business_unit_msdyn_priority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_priority`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_delivery"></a> business_unit_msdyn_proactive_delivery

Many-To-One Relationship: [msdyn_proactive_delivery business_unit_msdyn_proactive_delivery](msdyn_proactive_delivery.md#BKMK_business_unit_msdyn_proactive_delivery)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_delivery`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_delivery_attribute"></a> business_unit_msdyn_proactive_delivery_attribute

Many-To-One Relationship: [msdyn_proactive_delivery_attribute business_unit_msdyn_proactive_delivery_attribute](msdyn_proactive_delivery_attribute.md#BKMK_business_unit_msdyn_proactive_delivery_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery_attribute`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_delivery_attribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_delivery_batch"></a> business_unit_msdyn_proactive_delivery_batch

Many-To-One Relationship: [msdyn_proactive_delivery_batch business_unit_msdyn_proactive_delivery_batch](msdyn_proactive_delivery_batch.md#BKMK_business_unit_msdyn_proactive_delivery_batch)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery_batch`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_delivery_batch`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_eng_config_characteristic"></a> business_unit_msdyn_proactive_eng_config_characteristic

Many-To-One Relationship: [msdyn_proactive_eng_config_characteristic business_unit_msdyn_proactive_eng_config_characteristic](msdyn_proactive_eng_config_characteristic.md#BKMK_business_unit_msdyn_proactive_eng_config_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_eng_config_characteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_engagement_config"></a> business_unit_msdyn_proactive_engagement_config

Many-To-One Relationship: [msdyn_proactive_engagement_config business_unit_msdyn_proactive_engagement_config](msdyn_proactive_engagement_config.md#BKMK_business_unit_msdyn_proactive_engagement_config)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_engagement_config`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_engagement_config_attribute"></a> business_unit_msdyn_proactive_engagement_config_attribute

Many-To-One Relationship: [msdyn_proactive_engagement_config_attribute business_unit_msdyn_proactive_engagement_config_attribute](msdyn_proactive_engagement_config_attribute.md#BKMK_business_unit_msdyn_proactive_engagement_config_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config_attribute`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_engagement_config_attribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_engagement_config_status"></a> business_unit_msdyn_proactive_engagement_config_status

Many-To-One Relationship: [msdyn_proactive_engagement_config_status business_unit_msdyn_proactive_engagement_config_status](msdyn_proactive_engagement_config_status.md#BKMK_business_unit_msdyn_proactive_engagement_config_status)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config_status`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_engagement_config_status`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_engagement_message_template"></a> business_unit_msdyn_proactive_engagement_message_template

Many-To-One Relationship: [msdyn_proactive_engagement_message_template business_unit_msdyn_proactive_engagement_message_template](msdyn_proactive_engagement_message_template.md#BKMK_business_unit_msdyn_proactive_engagement_message_template)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_message_template`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_engagement_message_template`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_proactive_engagement_planner_config"></a> business_unit_msdyn_proactive_engagement_planner_config

Many-To-One Relationship: [msdyn_proactive_engagement_planner_config business_unit_msdyn_proactive_engagement_planner_config](msdyn_proactive_engagement_planner_config.md#BKMK_business_unit_msdyn_proactive_engagement_planner_config)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_planner_config`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_proactive_engagement_planner_config`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_questionsequence"></a> business_unit_msdyn_questionsequence

Many-To-One Relationship: [msdyn_questionsequence business_unit_msdyn_questionsequence](msdyn_questionsequence.md#BKMK_business_unit_msdyn_questionsequence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_questionsequence`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_questionsequence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementchange"></a> business_unit_msdyn_requirementchange

Many-To-One Relationship: [msdyn_requirementchange business_unit_msdyn_requirementchange](msdyn_requirementchange.md#BKMK_business_unit_msdyn_requirementchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementcharacteristic"></a> business_unit_msdyn_requirementcharacteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic business_unit_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_business_unit_msdyn_requirementcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementdependency"></a> business_unit_msdyn_requirementdependency

Many-To-One Relationship: [msdyn_requirementdependency business_unit_msdyn_requirementdependency](msdyn_requirementdependency.md#BKMK_business_unit_msdyn_requirementdependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementdependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementgroup"></a> business_unit_msdyn_requirementgroup

Many-To-One Relationship: [msdyn_requirementgroup business_unit_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_business_unit_msdyn_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementorganizationunit"></a> business_unit_msdyn_requirementorganizationunit

Many-To-One Relationship: [msdyn_requirementorganizationunit business_unit_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_business_unit_msdyn_requirementorganizationunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementorganizationunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementrelationship"></a> business_unit_msdyn_requirementrelationship

Many-To-One Relationship: [msdyn_requirementrelationship business_unit_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_business_unit_msdyn_requirementrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementrelationship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementresourcecategory"></a> business_unit_msdyn_requirementresourcecategory

Many-To-One Relationship: [msdyn_requirementresourcecategory business_unit_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_business_unit_msdyn_requirementresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementresourcepreference"></a> business_unit_msdyn_requirementresourcepreference

Many-To-One Relationship: [msdyn_requirementresourcepreference business_unit_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_business_unit_msdyn_requirementresourcepreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementresourcepreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_requirementstatus"></a> business_unit_msdyn_requirementstatus

Many-To-One Relationship: [msdyn_requirementstatus business_unit_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_business_unit_msdyn_requirementstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_requirementstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_resourcerequirement"></a> business_unit_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement business_unit_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_business_unit_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_resourcerequirementdetail"></a> business_unit_msdyn_resourcerequirementdetail

Many-To-One Relationship: [msdyn_resourcerequirementdetail business_unit_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_business_unit_msdyn_resourcerequirementdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_resourcerequirementdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_resourceterritory"></a> business_unit_msdyn_resourceterritory

Many-To-One Relationship: [msdyn_resourceterritory business_unit_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_business_unit_msdyn_resourceterritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_resourceterritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_scenario"></a> business_unit_msdyn_scenario

Many-To-One Relationship: [msdyn_scenario business_unit_msdyn_scenario](msdyn_scenario.md#BKMK_business_unit_msdyn_scenario)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scenario`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_scenario`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_scheduleboardsetting"></a> business_unit_msdyn_scheduleboardsetting

Many-To-One Relationship: [msdyn_scheduleboardsetting business_unit_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_business_unit_msdyn_scheduleboardsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_scheduleboardsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_schedulingfeatureflag"></a> business_unit_msdyn_schedulingfeatureflag

Many-To-One Relationship: [msdyn_schedulingfeatureflag business_unit_msdyn_schedulingfeatureflag](msdyn_schedulingfeatureflag.md#BKMK_business_unit_msdyn_schedulingfeatureflag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_schedulingfeatureflag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_schedulingscope"></a> business_unit_msdyn_schedulingscope

Many-To-One Relationship: [msdyn_schedulingscope business_unit_msdyn_schedulingscope](msdyn_schedulingscope.md#BKMK_business_unit_msdyn_schedulingscope)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_schedulingscope`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_smsengagementctx"></a> business_unit_msdyn_smsengagementctx

Many-To-One Relationship: [msdyn_smsengagementctx business_unit_msdyn_smsengagementctx](msdyn_smsengagementctx.md#BKMK_business_unit_msdyn_smsengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_smsengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_smsnumber"></a> business_unit_msdyn_smsnumber

Many-To-One Relationship: [msdyn_smsnumber business_unit_msdyn_smsnumber](msdyn_smsnumber.md#BKMK_business_unit_msdyn_smsnumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsnumber`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_smsnumber`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_surveyquestion"></a> business_unit_msdyn_surveyquestion

Many-To-One Relationship: [msdyn_surveyquestion business_unit_msdyn_surveyquestion](msdyn_surveyquestion.md#BKMK_business_unit_msdyn_surveyquestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_surveyquestion`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_surveyquestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_systemuserschedulersetting"></a> business_unit_msdyn_systemuserschedulersetting

Many-To-One Relationship: [msdyn_systemuserschedulersetting business_unit_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_business_unit_msdyn_systemuserschedulersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_systemuserschedulersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_teamschannelengagementctx"></a> business_unit_msdyn_teamschannelengagementctx

Many-To-One Relationship: [msdyn_teamschannelengagementctx business_unit_msdyn_teamschannelengagementctx](msdyn_teamschannelengagementctx.md#BKMK_business_unit_msdyn_teamschannelengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamschannelengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_teamschannelengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timegroup"></a> business_unit_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup business_unit_msdyn_timegroup](msdyn_timegroup.md#BKMK_business_unit_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timegroupdetail"></a> business_unit_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail business_unit_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_business_unit_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timegroupdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_transactionorigin"></a> business_unit_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin business_unit_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_business_unit_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_transactionorigin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_twitterengagementctx"></a> business_unit_msdyn_twitterengagementctx

Many-To-One Relationship: [msdyn_twitterengagementctx business_unit_msdyn_twitterengagementctx](msdyn_twitterengagementctx.md#BKMK_business_unit_msdyn_twitterengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_twitterengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_twitterengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_voicechannelorganizationsetting"></a> business_unit_msdyn_voicechannelorganizationsetting

Many-To-One Relationship: [msdyn_voicechannelorganizationsetting business_unit_msdyn_voicechannelorganizationsetting](msdyn_voicechannelorganizationsetting.md#BKMK_business_unit_msdyn_voicechannelorganizationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_voicechannelorganizationsetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_voicechannelorganizationsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_webengagementruleset"></a> business_unit_msdyn_webengagementruleset

Many-To-One Relationship: [msdyn_webengagementruleset business_unit_msdyn_webengagementruleset](msdyn_webengagementruleset.md#BKMK_business_unit_msdyn_webengagementruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementruleset`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_webengagementruleset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_webengagementrulesetconfig"></a> business_unit_msdyn_webengagementrulesetconfig

Many-To-One Relationship: [msdyn_webengagementrulesetconfig business_unit_msdyn_webengagementrulesetconfig](msdyn_webengagementrulesetconfig.md#BKMK_business_unit_msdyn_webengagementrulesetconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementrulesetconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_webengagementrulesetconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_webengagementrulesetrevision"></a> business_unit_msdyn_webengagementrulesetrevision

Many-To-One Relationship: [msdyn_webengagementrulesetrevision business_unit_msdyn_webengagementrulesetrevision](msdyn_webengagementrulesetrevision.md#BKMK_business_unit_msdyn_webengagementrulesetrevision)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementrulesetrevision`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_webengagementrulesetrevision`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_webengagementsitearea"></a> business_unit_msdyn_webengagementsitearea

Many-To-One Relationship: [msdyn_webengagementsitearea business_unit_msdyn_webengagementsitearea](msdyn_webengagementsitearea.md#BKMK_business_unit_msdyn_webengagementsitearea)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementsitearea`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_webengagementsitearea`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_wechatengagementctx"></a> business_unit_msdyn_wechatengagementctx

Many-To-One Relationship: [msdyn_wechatengagementctx business_unit_msdyn_wechatengagementctx](msdyn_wechatengagementctx.md#BKMK_business_unit_msdyn_wechatengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wechatengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_wechatengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_whatsappengagementctx"></a> business_unit_msdyn_whatsappengagementctx

Many-To-One Relationship: [msdyn_whatsappengagementctx business_unit_msdyn_whatsappengagementctx](msdyn_whatsappengagementctx.md#BKMK_business_unit_msdyn_whatsappengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_whatsappengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_whatsappengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workhourtemplate"></a> business_unit_msdyn_workhourtemplate

Many-To-One Relationship: [msdyn_workhourtemplate business_unit_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_business_unit_msdyn_workhourtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workhourtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_businessunit_owningbusinessunit"></a> msdyn_bookingalert_businessunit_owningbusinessunit

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_businessunit_owningbusinessunit](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_businessunit_owningbusinessunit"></a> msdyn_ocoutboundmessage_businessunit_owningbusinessunit

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_businessunit_owningbusinessunit](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicemail_businessunit_owningbusinessunit"></a> msdyn_ocvoicemail_businessunit_owningbusinessunit

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_businessunit_owningbusinessunit](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicemail_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.businessunit?displayProperty=fullName>
