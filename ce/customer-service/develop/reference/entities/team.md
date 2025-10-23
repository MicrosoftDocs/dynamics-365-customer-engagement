---
title: "Team table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Team table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Team table/entity reference (Microsoft Dynamics 365 Customer Service)

Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Team table extends the [Microsoft Dynamics 365 Team table](/dynamics365/developer/reference/entities/team).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_team_owningteam](#BKMK_msdyn_bookingalert_team_owningteam)
- [msdyn_ocoutboundmessage_team_owningteam](#BKMK_msdyn_ocoutboundmessage_team_owningteam)
- [msdyn_ocvoicemail_team_owningteam](#BKMK_msdyn_ocvoicemail_team_owningteam)
- [team_msdyn_actual](#BKMK_team_msdyn_actual)
- [team_msdyn_amsbuild](#BKMK_team_msdyn_amsbuild)
- [team_msdyn_amsmodel](#BKMK_team_msdyn_amsmodel)
- [team_msdyn_amsprofile](#BKMK_team_msdyn_amsprofile)
- [team_msdyn_amsprofilesettings](#BKMK_team_msdyn_amsprofilesettings)
- [team_msdyn_amstag](#BKMK_team_msdyn_amstag)
- [team_msdyn_azurenotificationhub](#BKMK_team_msdyn_azurenotificationhub)
- [team_msdyn_bookableresourceassociation](#BKMK_team_msdyn_bookableresourceassociation)
- [team_msdyn_bookingalertstatus](#BKMK_team_msdyn_bookingalertstatus)
- [team_msdyn_bookingchange](#BKMK_team_msdyn_bookingchange)
- [team_msdyn_bookingrule](#BKMK_team_msdyn_bookingrule)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [team_msdyn_businessclosure](#BKMK_team_msdyn_businessclosure)
- [team_msdyn_channel](#BKMK_team_msdyn_channel)
- [team_msdyn_channelinstancesecret](#BKMK_team_msdyn_channelinstancesecret)
- [team_msdyn_chatansweroption](#BKMK_team_msdyn_chatansweroption)
- [team_msdyn_chatquestionnaireresponse](#BKMK_team_msdyn_chatquestionnaireresponse)
- [team_msdyn_chatquestionnaireresponseitem](#BKMK_team_msdyn_chatquestionnaireresponseitem)
- [team_msdyn_chatwidgetlanguage](#BKMK_team_msdyn_chatwidgetlanguage)
- [team_msdyn_clientextension](#BKMK_team_msdyn_clientextension)
- [team_msdyn_configuration](#BKMK_team_msdyn_configuration)
- [team_msdyn_conversation_attribute](#BKMK_team_msdyn_conversation_attribute)
- [team_msdyn_customengagementctx](#BKMK_team_msdyn_customengagementctx)
- [team_msdyn_facebookengagementctx](#BKMK_team_msdyn_facebookengagementctx)
- [team_msdyn_lineengagementctx](#BKMK_team_msdyn_lineengagementctx)
- [team_msdyn_livechatconfig](#BKMK_team_msdyn_livechatconfig)
- [team_msdyn_livechatengagementctx](#BKMK_team_msdyn_livechatengagementctx)
- [team_msdyn_livechatwidgetlocation](#BKMK_team_msdyn_livechatwidgetlocation)
- [team_msdyn_ocapplebusinessaccount](#BKMK_team_msdyn_ocapplebusinessaccount)
- [team_msdyn_ocapplemessagesforbusinessengagementctx](#BKMK_team_msdyn_ocapplemessagesforbusinessengagementctx)
- [team_msdyn_ocapplepay](#BKMK_team_msdyn_ocapplepay)
- [team_msdyn_occarrier](#BKMK_team_msdyn_occarrier)
- [team_msdyn_occommunicationprovidersetting](#BKMK_team_msdyn_occommunicationprovidersetting)
- [team_msdyn_occommunicationprovidersettingentry](#BKMK_team_msdyn_occommunicationprovidersettingentry)
- [team_msdyn_occustommessagingchannel](#BKMK_team_msdyn_occustommessagingchannel)
- [team_msdyn_ocexternalsecuritysetting](#BKMK_team_msdyn_ocexternalsecuritysetting)
- [team_msdyn_ocfbapplication](#BKMK_team_msdyn_ocfbapplication)
- [team_msdyn_ocfbpage](#BKMK_team_msdyn_ocfbpage)
- [team_msdyn_ocgatekeeperengagementctx](#BKMK_team_msdyn_ocgatekeeperengagementctx)
- [team_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_team_msdyn_ocgooglebusinessmessagesagentaccount)
- [team_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_team_msdyn_ocgooglebusinessmessagesengagementctx)
- [team_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_team_msdyn_ocgooglebusinessmessagespartneraccount)
- [team_msdyn_oclinechannelconfig](#BKMK_team_msdyn_oclinechannelconfig)
- [team_msdyn_ocoutboundconfiguration](#BKMK_team_msdyn_ocoutboundconfiguration)
- [team_msdyn_ocphonecallengagementctx](#BKMK_team_msdyn_ocphonecallengagementctx)
- [team_msdyn_ocphonemusic](#BKMK_team_msdyn_ocphonemusic)
- [team_msdyn_ocphonenumber](#BKMK_team_msdyn_ocphonenumber)
- [team_msdyn_ocsmssettingsecret](#BKMK_team_msdyn_ocsmssettingsecret)
- [team_msdyn_octeamschannelconfig](#BKMK_team_msdyn_octeamschannelconfig)
- [team_msdyn_octwitterapplication](#BKMK_team_msdyn_octwitterapplication)
- [team_msdyn_octwitterhandle](#BKMK_team_msdyn_octwitterhandle)
- [team_msdyn_octwitterhandleprovisioningstatus](#BKMK_team_msdyn_octwitterhandleprovisioningstatus)
- [team_msdyn_octwitterhandlesecret](#BKMK_team_msdyn_octwitterhandlesecret)
- [team_msdyn_ocvoice](#BKMK_team_msdyn_ocvoice)
- [team_msdyn_ocvoicechannellanguagesetting](#BKMK_team_msdyn_ocvoicechannellanguagesetting)
- [team_msdyn_ocvoicechannelsetting](#BKMK_team_msdyn_ocvoicechannelsetting)
- [team_msdyn_ocwechatchannelconfig](#BKMK_team_msdyn_ocwechatchannelconfig)
- [team_msdyn_ocwhatsappchannelaccount](#BKMK_team_msdyn_ocwhatsappchannelaccount)
- [team_msdyn_ocwhatsappchannelnumber](#BKMK_team_msdyn_ocwhatsappchannelnumber)
- [team_msdyn_optimizationrequest](#BKMK_team_msdyn_optimizationrequest)
- [team_msdyn_priority](#BKMK_team_msdyn_priority)
- [team_msdyn_proactive_delivery](#BKMK_team_msdyn_proactive_delivery)
- [team_msdyn_proactive_delivery_attribute](#BKMK_team_msdyn_proactive_delivery_attribute)
- [team_msdyn_proactive_eng_config_characteristic](#BKMK_team_msdyn_proactive_eng_config_characteristic)
- [team_msdyn_proactive_engagement_config](#BKMK_team_msdyn_proactive_engagement_config)
- [team_msdyn_proactive_engagement_config_attribute](#BKMK_team_msdyn_proactive_engagement_config_attribute)
- [team_msdyn_proactive_engagement_config_status](#BKMK_team_msdyn_proactive_engagement_config_status)
- [team_msdyn_questionsequence](#BKMK_team_msdyn_questionsequence)
- [team_msdyn_requirementchange](#BKMK_team_msdyn_requirementchange)
- [team_msdyn_requirementcharacteristic](#BKMK_team_msdyn_requirementcharacteristic)
- [team_msdyn_requirementdependency](#BKMK_team_msdyn_requirementdependency)
- [team_msdyn_requirementgroup](#BKMK_team_msdyn_requirementgroup)
- [team_msdyn_requirementorganizationunit](#BKMK_team_msdyn_requirementorganizationunit)
- [team_msdyn_requirementrelationship](#BKMK_team_msdyn_requirementrelationship)
- [team_msdyn_requirementresourcecategory](#BKMK_team_msdyn_requirementresourcecategory)
- [team_msdyn_requirementresourcepreference](#BKMK_team_msdyn_requirementresourcepreference)
- [team_msdyn_requirementstatus](#BKMK_team_msdyn_requirementstatus)
- [team_msdyn_resourcerequirement](#BKMK_team_msdyn_resourcerequirement)
- [team_msdyn_resourcerequirementdetail](#BKMK_team_msdyn_resourcerequirementdetail)
- [team_msdyn_resourceterritory](#BKMK_team_msdyn_resourceterritory)
- [team_msdyn_scenario](#BKMK_team_msdyn_scenario)
- [team_msdyn_scheduleboardsetting](#BKMK_team_msdyn_scheduleboardsetting)
- [team_msdyn_schedulingfeatureflag](#BKMK_team_msdyn_schedulingfeatureflag)
- [team_msdyn_schedulingscope](#BKMK_team_msdyn_schedulingscope)
- [team_msdyn_smsengagementctx](#BKMK_team_msdyn_smsengagementctx)
- [team_msdyn_smsnumber](#BKMK_team_msdyn_smsnumber)
- [team_msdyn_surveyquestion](#BKMK_team_msdyn_surveyquestion)
- [team_msdyn_systemuserschedulersetting](#BKMK_team_msdyn_systemuserschedulersetting)
- [team_msdyn_teamschannelengagementctx](#BKMK_team_msdyn_teamschannelengagementctx)
- [team_msdyn_timegroup](#BKMK_team_msdyn_timegroup)
- [team_msdyn_timegroupdetail](#BKMK_team_msdyn_timegroupdetail)
- [team_msdyn_transactionorigin](#BKMK_team_msdyn_transactionorigin)
- [team_msdyn_twitterengagementctx](#BKMK_team_msdyn_twitterengagementctx)
- [team_msdyn_voicechannelorganizationsetting](#BKMK_team_msdyn_voicechannelorganizationsetting)
- [team_msdyn_webengagementruleset](#BKMK_team_msdyn_webengagementruleset)
- [team_msdyn_webengagementrulesetconfig](#BKMK_team_msdyn_webengagementrulesetconfig)
- [team_msdyn_webengagementrulesetrevision](#BKMK_team_msdyn_webengagementrulesetrevision)
- [team_msdyn_webengagementsitearea](#BKMK_team_msdyn_webengagementsitearea)
- [team_msdyn_wechatengagementctx](#BKMK_team_msdyn_wechatengagementctx)
- [team_msdyn_whatsappengagementctx](#BKMK_team_msdyn_whatsappengagementctx)
- [team_msdyn_workhourtemplate](#BKMK_team_msdyn_workhourtemplate)

### <a name="BKMK_msdyn_bookingalert_team_owningteam"></a> msdyn_bookingalert_team_owningteam

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_team_owningteam](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_team_owningteam"></a> msdyn_ocoutboundmessage_team_owningteam

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_team_owningteam](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_team_owningteam`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicemail_team_owningteam"></a> msdyn_ocvoicemail_team_owningteam

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_team_owningteam](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicemail_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_actual"></a> team_msdyn_actual

Many-To-One Relationship: [msdyn_actual team_msdyn_actual](msdyn_actual.md#BKMK_team_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_amsbuild"></a> team_msdyn_amsbuild

Many-To-One Relationship: [msdyn_amsbuild team_msdyn_amsbuild](msdyn_amsbuild.md#BKMK_team_msdyn_amsbuild)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsbuild`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_amsbuild`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_amsmodel"></a> team_msdyn_amsmodel

Many-To-One Relationship: [msdyn_amsmodel team_msdyn_amsmodel](msdyn_amsmodel.md#BKMK_team_msdyn_amsmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsmodel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_amsmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_amsprofile"></a> team_msdyn_amsprofile

Many-To-One Relationship: [msdyn_amsprofile team_msdyn_amsprofile](msdyn_amsprofile.md#BKMK_team_msdyn_amsprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_amsprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_amsprofilesettings"></a> team_msdyn_amsprofilesettings

Many-To-One Relationship: [msdyn_amsprofilesettings team_msdyn_amsprofilesettings](msdyn_amsprofilesettings.md#BKMK_team_msdyn_amsprofilesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsprofilesettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_amsprofilesettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_amstag"></a> team_msdyn_amstag

Many-To-One Relationship: [msdyn_amstag team_msdyn_amstag](msdyn_amstag.md#BKMK_team_msdyn_amstag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amstag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_amstag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_azurenotificationhub"></a> team_msdyn_azurenotificationhub

Many-To-One Relationship: [msdyn_azurenotificationhub team_msdyn_azurenotificationhub](msdyn_azurenotificationhub.md#BKMK_team_msdyn_azurenotificationhub)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_azurenotificationhub`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_azurenotificationhub`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookableresourceassociation"></a> team_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation team_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_team_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookableresourceassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingalertstatus"></a> team_msdyn_bookingalertstatus

Many-To-One Relationship: [msdyn_bookingalertstatus team_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_team_msdyn_bookingalertstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingalertstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingchange"></a> team_msdyn_bookingchange

Many-To-One Relationship: [msdyn_bookingchange team_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_team_msdyn_bookingchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingrule"></a> team_msdyn_bookingrule

Many-To-One Relationship: [msdyn_bookingrule team_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_team_msdyn_bookingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookingsetupmetadata"></a> team_msdyn_bookingsetupmetadata

Many-To-One Relationship: [msdyn_bookingsetupmetadata team_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_team_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingsetupmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_businessclosure"></a> team_msdyn_businessclosure

Many-To-One Relationship: [msdyn_businessclosure team_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_team_msdyn_businessclosure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_businessclosure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channel"></a> team_msdyn_channel

Many-To-One Relationship: [msdyn_channel team_msdyn_channel](msdyn_channel.md#BKMK_team_msdyn_channel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channelinstancesecret"></a> team_msdyn_channelinstancesecret

Many-To-One Relationship: [msdyn_channelinstancesecret team_msdyn_channelinstancesecret](msdyn_channelinstancesecret.md#BKMK_team_msdyn_channelinstancesecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstancesecret`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channelinstancesecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_chatansweroption"></a> team_msdyn_chatansweroption

Many-To-One Relationship: [msdyn_chatansweroption team_msdyn_chatansweroption](msdyn_chatansweroption.md#BKMK_team_msdyn_chatansweroption)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatansweroption`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_chatansweroption`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_chatquestionnaireresponse"></a> team_msdyn_chatquestionnaireresponse

Many-To-One Relationship: [msdyn_chatquestionnaireresponse team_msdyn_chatquestionnaireresponse](msdyn_chatquestionnaireresponse.md#BKMK_team_msdyn_chatquestionnaireresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_chatquestionnaireresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_chatquestionnaireresponseitem"></a> team_msdyn_chatquestionnaireresponseitem

Many-To-One Relationship: [msdyn_chatquestionnaireresponseitem team_msdyn_chatquestionnaireresponseitem](msdyn_chatquestionnaireresponseitem.md#BKMK_team_msdyn_chatquestionnaireresponseitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponseitem`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_chatquestionnaireresponseitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_chatwidgetlanguage"></a> team_msdyn_chatwidgetlanguage

Many-To-One Relationship: [msdyn_chatwidgetlanguage team_msdyn_chatwidgetlanguage](msdyn_chatwidgetlanguage.md#BKMK_team_msdyn_chatwidgetlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatwidgetlanguage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_chatwidgetlanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_clientextension"></a> team_msdyn_clientextension

Many-To-One Relationship: [msdyn_clientextension team_msdyn_clientextension](msdyn_clientextension.md#BKMK_team_msdyn_clientextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_clientextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_configuration"></a> team_msdyn_configuration

Many-To-One Relationship: [msdyn_configuration team_msdyn_configuration](msdyn_configuration.md#BKMK_team_msdyn_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversation_attribute"></a> team_msdyn_conversation_attribute

Many-To-One Relationship: [msdyn_conversation_attribute team_msdyn_conversation_attribute](msdyn_conversation_attribute.md#BKMK_team_msdyn_conversation_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversation_attribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversation_attribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_customengagementctx"></a> team_msdyn_customengagementctx

Many-To-One Relationship: [msdyn_customengagementctx team_msdyn_customengagementctx](msdyn_customengagementctx.md#BKMK_team_msdyn_customengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_customengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_facebookengagementctx"></a> team_msdyn_facebookengagementctx

Many-To-One Relationship: [msdyn_facebookengagementctx team_msdyn_facebookengagementctx](msdyn_facebookengagementctx.md#BKMK_team_msdyn_facebookengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_facebookengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_facebookengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_lineengagementctx"></a> team_msdyn_lineengagementctx

Many-To-One Relationship: [msdyn_lineengagementctx team_msdyn_lineengagementctx](msdyn_lineengagementctx.md#BKMK_team_msdyn_lineengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_lineengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_lineengagementctx`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_livechatconfig"></a> team_msdyn_livechatconfig

Many-To-One Relationship: [msdyn_livechatconfig team_msdyn_livechatconfig](msdyn_livechatconfig.md#BKMK_team_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_livechatconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_livechatengagementctx"></a> team_msdyn_livechatengagementctx

Many-To-One Relationship: [msdyn_livechatengagementctx team_msdyn_livechatengagementctx](msdyn_livechatengagementctx.md#BKMK_team_msdyn_livechatengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_livechatengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_livechatwidgetlocation"></a> team_msdyn_livechatwidgetlocation

Many-To-One Relationship: [msdyn_livechatwidgetlocation team_msdyn_livechatwidgetlocation](msdyn_livechatwidgetlocation.md#BKMK_team_msdyn_livechatwidgetlocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatwidgetlocation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_livechatwidgetlocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocapplebusinessaccount"></a> team_msdyn_ocapplebusinessaccount

Many-To-One Relationship: [msdyn_ocapplebusinessaccount team_msdyn_ocapplebusinessaccount](msdyn_ocapplebusinessaccount.md#BKMK_team_msdyn_ocapplebusinessaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplebusinessaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocapplebusinessaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocapplemessagesforbusinessengagementctx"></a> team_msdyn_ocapplemessagesforbusinessengagementctx

Many-To-One Relationship: [msdyn_ocapplemessagesforbusinessengagementctx team_msdyn_ocapplemessagesforbusinessengagementctx](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_team_msdyn_ocapplemessagesforbusinessengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocapplemessagesforbusinessengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocapplepay"></a> team_msdyn_ocapplepay

Many-To-One Relationship: [msdyn_ocapplepay team_msdyn_ocapplepay](msdyn_ocapplepay.md#BKMK_team_msdyn_ocapplepay)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplepay`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocapplepay`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_occarrier"></a> team_msdyn_occarrier

Many-To-One Relationship: [msdyn_occarrier team_msdyn_occarrier](msdyn_occarrier.md#BKMK_team_msdyn_occarrier)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occarrier`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_occarrier`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_occommunicationprovidersetting"></a> team_msdyn_occommunicationprovidersetting

Many-To-One Relationship: [msdyn_occommunicationprovidersetting team_msdyn_occommunicationprovidersetting](msdyn_occommunicationprovidersetting.md#BKMK_team_msdyn_occommunicationprovidersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occommunicationprovidersetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_occommunicationprovidersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_occommunicationprovidersettingentry"></a> team_msdyn_occommunicationprovidersettingentry

Many-To-One Relationship: [msdyn_occommunicationprovidersettingentry team_msdyn_occommunicationprovidersettingentry](msdyn_occommunicationprovidersettingentry.md#BKMK_team_msdyn_occommunicationprovidersettingentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occommunicationprovidersettingentry`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_occommunicationprovidersettingentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_occustommessagingchannel"></a> team_msdyn_occustommessagingchannel

Many-To-One Relationship: [msdyn_occustommessagingchannel team_msdyn_occustommessagingchannel](msdyn_occustommessagingchannel.md#BKMK_team_msdyn_occustommessagingchannel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_occustommessagingchannel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocexternalsecuritysetting"></a> team_msdyn_ocexternalsecuritysetting

Many-To-One Relationship: [msdyn_ocexternalsecuritysetting team_msdyn_ocexternalsecuritysetting](msdyn_ocexternalsecuritysetting.md#BKMK_team_msdyn_ocexternalsecuritysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalsecuritysetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocexternalsecuritysetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocfbapplication"></a> team_msdyn_ocfbapplication

Many-To-One Relationship: [msdyn_ocfbapplication team_msdyn_ocfbapplication](msdyn_ocfbapplication.md#BKMK_team_msdyn_ocfbapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocfbapplication`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocfbapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocfbpage"></a> team_msdyn_ocfbpage

Many-To-One Relationship: [msdyn_ocfbpage team_msdyn_ocfbpage](msdyn_ocfbpage.md#BKMK_team_msdyn_ocfbpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocfbpage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocfbpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocgatekeeperengagementctx"></a> team_msdyn_ocgatekeeperengagementctx

Many-To-One Relationship: [msdyn_ocgatekeeperengagementctx team_msdyn_ocgatekeeperengagementctx](msdyn_ocgatekeeperengagementctx.md#BKMK_team_msdyn_ocgatekeeperengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocgatekeeperengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocgooglebusinessmessagesagentaccount"></a> team_msdyn_ocgooglebusinessmessagesagentaccount

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesagentaccount team_msdyn_ocgooglebusinessmessagesagentaccount](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_team_msdyn_ocgooglebusinessmessagesagentaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocgooglebusinessmessagesagentaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocgooglebusinessmessagesengagementctx"></a> team_msdyn_ocgooglebusinessmessagesengagementctx

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesengagementctx team_msdyn_ocgooglebusinessmessagesengagementctx](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_team_msdyn_ocgooglebusinessmessagesengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocgooglebusinessmessagesengagementctx`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocgooglebusinessmessagespartneraccount"></a> team_msdyn_ocgooglebusinessmessagespartneraccount

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagespartneraccount team_msdyn_ocgooglebusinessmessagespartneraccount](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_team_msdyn_ocgooglebusinessmessagespartneraccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocgooglebusinessmessagespartneraccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_oclinechannelconfig"></a> team_msdyn_oclinechannelconfig

Many-To-One Relationship: [msdyn_oclinechannelconfig team_msdyn_oclinechannelconfig](msdyn_oclinechannelconfig.md#BKMK_team_msdyn_oclinechannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclinechannelconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_oclinechannelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocoutboundconfiguration"></a> team_msdyn_ocoutboundconfiguration

Many-To-One Relationship: [msdyn_ocoutboundconfiguration team_msdyn_ocoutboundconfiguration](msdyn_ocoutboundconfiguration.md#BKMK_team_msdyn_ocoutboundconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocoutboundconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocphonecallengagementctx"></a> team_msdyn_ocphonecallengagementctx

Many-To-One Relationship: [msdyn_ocphonecallengagementctx team_msdyn_ocphonecallengagementctx](msdyn_ocphonecallengagementctx.md#BKMK_team_msdyn_ocphonecallengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonecallengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocphonecallengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocphonemusic"></a> team_msdyn_ocphonemusic

Many-To-One Relationship: [msdyn_ocphonemusic team_msdyn_ocphonemusic](msdyn_ocphonemusic.md#BKMK_team_msdyn_ocphonemusic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonemusic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocphonemusic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocphonenumber"></a> team_msdyn_ocphonenumber

Many-To-One Relationship: [msdyn_ocphonenumber team_msdyn_ocphonenumber](msdyn_ocphonenumber.md#BKMK_team_msdyn_ocphonenumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonenumber`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocphonenumber`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsmssettingsecret"></a> team_msdyn_ocsmssettingsecret

Many-To-One Relationship: [msdyn_ocsmssettingsecret team_msdyn_ocsmssettingsecret](msdyn_ocsmssettingsecret.md#BKMK_team_msdyn_ocsmssettingsecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsmssettingsecret`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsmssettingsecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_octeamschannelconfig"></a> team_msdyn_octeamschannelconfig

Many-To-One Relationship: [msdyn_octeamschannelconfig team_msdyn_octeamschannelconfig](msdyn_octeamschannelconfig.md#BKMK_team_msdyn_octeamschannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octeamschannelconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_octeamschannelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_octwitterapplication"></a> team_msdyn_octwitterapplication

Many-To-One Relationship: [msdyn_octwitterapplication team_msdyn_octwitterapplication](msdyn_octwitterapplication.md#BKMK_team_msdyn_octwitterapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterapplication`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_octwitterapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_octwitterhandle"></a> team_msdyn_octwitterhandle

Many-To-One Relationship: [msdyn_octwitterhandle team_msdyn_octwitterhandle](msdyn_octwitterhandle.md#BKMK_team_msdyn_octwitterhandle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_octwitterhandle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_octwitterhandleprovisioningstatus"></a> team_msdyn_octwitterhandleprovisioningstatus

Many-To-One Relationship: [msdyn_octwitterhandleprovisioningstatus team_msdyn_octwitterhandleprovisioningstatus](msdyn_octwitterhandleprovisioningstatus.md#BKMK_team_msdyn_octwitterhandleprovisioningstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandleprovisioningstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_octwitterhandleprovisioningstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_octwitterhandlesecret"></a> team_msdyn_octwitterhandlesecret

Many-To-One Relationship: [msdyn_octwitterhandlesecret team_msdyn_octwitterhandlesecret](msdyn_octwitterhandlesecret.md#BKMK_team_msdyn_octwitterhandlesecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandlesecret`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_octwitterhandlesecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocvoice"></a> team_msdyn_ocvoice

Many-To-One Relationship: [msdyn_ocvoice team_msdyn_ocvoice](msdyn_ocvoice.md#BKMK_team_msdyn_ocvoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocvoice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocvoicechannellanguagesetting"></a> team_msdyn_ocvoicechannellanguagesetting

Many-To-One Relationship: [msdyn_ocvoicechannellanguagesetting team_msdyn_ocvoicechannellanguagesetting](msdyn_ocvoicechannellanguagesetting.md#BKMK_team_msdyn_ocvoicechannellanguagesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocvoicechannellanguagesetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocvoicechannelsetting"></a> team_msdyn_ocvoicechannelsetting

Many-To-One Relationship: [msdyn_ocvoicechannelsetting team_msdyn_ocvoicechannelsetting](msdyn_ocvoicechannelsetting.md#BKMK_team_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannelsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocvoicechannelsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocwechatchannelconfig"></a> team_msdyn_ocwechatchannelconfig

Many-To-One Relationship: [msdyn_ocwechatchannelconfig team_msdyn_ocwechatchannelconfig](msdyn_ocwechatchannelconfig.md#BKMK_team_msdyn_ocwechatchannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwechatchannelconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocwechatchannelconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocwhatsappchannelaccount"></a> team_msdyn_ocwhatsappchannelaccount

Many-To-One Relationship: [msdyn_ocwhatsappchannelaccount team_msdyn_ocwhatsappchannelaccount](msdyn_ocwhatsappchannelaccount.md#BKMK_team_msdyn_ocwhatsappchannelaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocwhatsappchannelaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocwhatsappchannelnumber"></a> team_msdyn_ocwhatsappchannelnumber

Many-To-One Relationship: [msdyn_ocwhatsappchannelnumber team_msdyn_ocwhatsappchannelnumber](msdyn_ocwhatsappchannelnumber.md#BKMK_team_msdyn_ocwhatsappchannelnumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocwhatsappchannelnumber`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_optimizationrequest"></a> team_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest team_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_team_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_optimizationrequest`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_priority"></a> team_msdyn_priority

Many-To-One Relationship: [msdyn_priority team_msdyn_priority](msdyn_priority.md#BKMK_team_msdyn_priority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_priority`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_proactive_delivery"></a> team_msdyn_proactive_delivery

Many-To-One Relationship: [msdyn_proactive_delivery team_msdyn_proactive_delivery](msdyn_proactive_delivery.md#BKMK_team_msdyn_proactive_delivery)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_proactive_delivery`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_proactive_delivery_attribute"></a> team_msdyn_proactive_delivery_attribute

Many-To-One Relationship: [msdyn_proactive_delivery_attribute team_msdyn_proactive_delivery_attribute](msdyn_proactive_delivery_attribute.md#BKMK_team_msdyn_proactive_delivery_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery_attribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_proactive_delivery_attribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_proactive_eng_config_characteristic"></a> team_msdyn_proactive_eng_config_characteristic

Many-To-One Relationship: [msdyn_proactive_eng_config_characteristic team_msdyn_proactive_eng_config_characteristic](msdyn_proactive_eng_config_characteristic.md#BKMK_team_msdyn_proactive_eng_config_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_proactive_eng_config_characteristic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_proactive_engagement_config"></a> team_msdyn_proactive_engagement_config

Many-To-One Relationship: [msdyn_proactive_engagement_config team_msdyn_proactive_engagement_config](msdyn_proactive_engagement_config.md#BKMK_team_msdyn_proactive_engagement_config)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_proactive_engagement_config`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_proactive_engagement_config_attribute"></a> team_msdyn_proactive_engagement_config_attribute

Many-To-One Relationship: [msdyn_proactive_engagement_config_attribute team_msdyn_proactive_engagement_config_attribute](msdyn_proactive_engagement_config_attribute.md#BKMK_team_msdyn_proactive_engagement_config_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config_attribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_proactive_engagement_config_attribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_proactive_engagement_config_status"></a> team_msdyn_proactive_engagement_config_status

Many-To-One Relationship: [msdyn_proactive_engagement_config_status team_msdyn_proactive_engagement_config_status](msdyn_proactive_engagement_config_status.md#BKMK_team_msdyn_proactive_engagement_config_status)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config_status`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_proactive_engagement_config_status`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_questionsequence"></a> team_msdyn_questionsequence

Many-To-One Relationship: [msdyn_questionsequence team_msdyn_questionsequence](msdyn_questionsequence.md#BKMK_team_msdyn_questionsequence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_questionsequence`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_questionsequence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementchange"></a> team_msdyn_requirementchange

Many-To-One Relationship: [msdyn_requirementchange team_msdyn_requirementchange](msdyn_requirementchange.md#BKMK_team_msdyn_requirementchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementcharacteristic"></a> team_msdyn_requirementcharacteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic team_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_team_msdyn_requirementcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementdependency"></a> team_msdyn_requirementdependency

Many-To-One Relationship: [msdyn_requirementdependency team_msdyn_requirementdependency](msdyn_requirementdependency.md#BKMK_team_msdyn_requirementdependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementdependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementgroup"></a> team_msdyn_requirementgroup

Many-To-One Relationship: [msdyn_requirementgroup team_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_team_msdyn_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementorganizationunit"></a> team_msdyn_requirementorganizationunit

Many-To-One Relationship: [msdyn_requirementorganizationunit team_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_team_msdyn_requirementorganizationunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementorganizationunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementrelationship"></a> team_msdyn_requirementrelationship

Many-To-One Relationship: [msdyn_requirementrelationship team_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_team_msdyn_requirementrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementrelationship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementresourcecategory"></a> team_msdyn_requirementresourcecategory

Many-To-One Relationship: [msdyn_requirementresourcecategory team_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_team_msdyn_requirementresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementresourcepreference"></a> team_msdyn_requirementresourcepreference

Many-To-One Relationship: [msdyn_requirementresourcepreference team_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_team_msdyn_requirementresourcepreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementresourcepreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_requirementstatus"></a> team_msdyn_requirementstatus

Many-To-One Relationship: [msdyn_requirementstatus team_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_team_msdyn_requirementstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_requirementstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resourcerequirement"></a> team_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement team_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_team_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resourcerequirementdetail"></a> team_msdyn_resourcerequirementdetail

Many-To-One Relationship: [msdyn_resourcerequirementdetail team_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_team_msdyn_resourcerequirementdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resourcerequirementdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resourceterritory"></a> team_msdyn_resourceterritory

Many-To-One Relationship: [msdyn_resourceterritory team_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_team_msdyn_resourceterritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resourceterritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_scenario"></a> team_msdyn_scenario

Many-To-One Relationship: [msdyn_scenario team_msdyn_scenario](msdyn_scenario.md#BKMK_team_msdyn_scenario)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scenario`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_scenario`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_scheduleboardsetting"></a> team_msdyn_scheduleboardsetting

Many-To-One Relationship: [msdyn_scheduleboardsetting team_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_team_msdyn_scheduleboardsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_scheduleboardsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_schedulingfeatureflag"></a> team_msdyn_schedulingfeatureflag

Many-To-One Relationship: [msdyn_schedulingfeatureflag team_msdyn_schedulingfeatureflag](msdyn_schedulingfeatureflag.md#BKMK_team_msdyn_schedulingfeatureflag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_schedulingfeatureflag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_schedulingscope"></a> team_msdyn_schedulingscope

Many-To-One Relationship: [msdyn_schedulingscope team_msdyn_schedulingscope](msdyn_schedulingscope.md#BKMK_team_msdyn_schedulingscope)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_schedulingscope`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_smsengagementctx"></a> team_msdyn_smsengagementctx

Many-To-One Relationship: [msdyn_smsengagementctx team_msdyn_smsengagementctx](msdyn_smsengagementctx.md#BKMK_team_msdyn_smsengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_smsengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_smsnumber"></a> team_msdyn_smsnumber

Many-To-One Relationship: [msdyn_smsnumber team_msdyn_smsnumber](msdyn_smsnumber.md#BKMK_team_msdyn_smsnumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsnumber`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_smsnumber`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_surveyquestion"></a> team_msdyn_surveyquestion

Many-To-One Relationship: [msdyn_surveyquestion team_msdyn_surveyquestion](msdyn_surveyquestion.md#BKMK_team_msdyn_surveyquestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_surveyquestion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_surveyquestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_systemuserschedulersetting"></a> team_msdyn_systemuserschedulersetting

Many-To-One Relationship: [msdyn_systemuserschedulersetting team_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_team_msdyn_systemuserschedulersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_systemuserschedulersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_teamschannelengagementctx"></a> team_msdyn_teamschannelengagementctx

Many-To-One Relationship: [msdyn_teamschannelengagementctx team_msdyn_teamschannelengagementctx](msdyn_teamschannelengagementctx.md#BKMK_team_msdyn_teamschannelengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamschannelengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_teamschannelengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timegroup"></a> team_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup team_msdyn_timegroup](msdyn_timegroup.md#BKMK_team_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timegroupdetail"></a> team_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail team_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_team_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timegroupdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_transactionorigin"></a> team_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin team_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_team_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_transactionorigin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_twitterengagementctx"></a> team_msdyn_twitterengagementctx

Many-To-One Relationship: [msdyn_twitterengagementctx team_msdyn_twitterengagementctx](msdyn_twitterengagementctx.md#BKMK_team_msdyn_twitterengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_twitterengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_twitterengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_voicechannelorganizationsetting"></a> team_msdyn_voicechannelorganizationsetting

Many-To-One Relationship: [msdyn_voicechannelorganizationsetting team_msdyn_voicechannelorganizationsetting](msdyn_voicechannelorganizationsetting.md#BKMK_team_msdyn_voicechannelorganizationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_voicechannelorganizationsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_voicechannelorganizationsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_webengagementruleset"></a> team_msdyn_webengagementruleset

Many-To-One Relationship: [msdyn_webengagementruleset team_msdyn_webengagementruleset](msdyn_webengagementruleset.md#BKMK_team_msdyn_webengagementruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementruleset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_webengagementruleset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_webengagementrulesetconfig"></a> team_msdyn_webengagementrulesetconfig

Many-To-One Relationship: [msdyn_webengagementrulesetconfig team_msdyn_webengagementrulesetconfig](msdyn_webengagementrulesetconfig.md#BKMK_team_msdyn_webengagementrulesetconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementrulesetconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_webengagementrulesetconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_webengagementrulesetrevision"></a> team_msdyn_webengagementrulesetrevision

Many-To-One Relationship: [msdyn_webengagementrulesetrevision team_msdyn_webengagementrulesetrevision](msdyn_webengagementrulesetrevision.md#BKMK_team_msdyn_webengagementrulesetrevision)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementrulesetrevision`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_webengagementrulesetrevision`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_webengagementsitearea"></a> team_msdyn_webengagementsitearea

Many-To-One Relationship: [msdyn_webengagementsitearea team_msdyn_webengagementsitearea](msdyn_webengagementsitearea.md#BKMK_team_msdyn_webengagementsitearea)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementsitearea`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_webengagementsitearea`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_wechatengagementctx"></a> team_msdyn_wechatengagementctx

Many-To-One Relationship: [msdyn_wechatengagementctx team_msdyn_wechatengagementctx](msdyn_wechatengagementctx.md#BKMK_team_msdyn_wechatengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wechatengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_wechatengagementctx`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_whatsappengagementctx"></a> team_msdyn_whatsappengagementctx

Many-To-One Relationship: [msdyn_whatsappengagementctx team_msdyn_whatsappengagementctx](msdyn_whatsappengagementctx.md#BKMK_team_msdyn_whatsappengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_whatsappengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_whatsappengagementctx`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workhourtemplate"></a> team_msdyn_workhourtemplate

Many-To-One Relationship: [msdyn_workhourtemplate team_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_team_msdyn_workhourtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workhourtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.team?displayProperty=fullName>
