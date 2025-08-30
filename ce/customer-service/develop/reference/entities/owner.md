---
title: "Owner table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Owner table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Owner table/entity reference (Microsoft Dynamics 365 Customer Service)

Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Owner table extends the [Microsoft Dynamics 365 Owner table](/dynamics365/developer/reference/entities/owner).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_bookingalert_owner_ownerid](#BKMK_msdyn_bookingalert_owner_ownerid)
- [msdyn_ocoutboundmessage_owner_ownerid](#BKMK_msdyn_ocoutboundmessage_owner_ownerid)
- [msdyn_ocvoicemail_owner_ownerid](#BKMK_msdyn_ocvoicemail_owner_ownerid)
- [owner_msdyn_actual](#BKMK_owner_msdyn_actual)
- [owner_msdyn_amsbuild](#BKMK_owner_msdyn_amsbuild)
- [owner_msdyn_amsmodel](#BKMK_owner_msdyn_amsmodel)
- [owner_msdyn_amsprofile](#BKMK_owner_msdyn_amsprofile)
- [owner_msdyn_amsprofilesettings](#BKMK_owner_msdyn_amsprofilesettings)
- [owner_msdyn_amstag](#BKMK_owner_msdyn_amstag)
- [owner_msdyn_azurenotificationhub](#BKMK_owner_msdyn_azurenotificationhub)
- [owner_msdyn_bookableresourceassociation](#BKMK_owner_msdyn_bookableresourceassociation)
- [owner_msdyn_bookingalertstatus](#BKMK_owner_msdyn_bookingalertstatus)
- [owner_msdyn_bookingchange](#BKMK_owner_msdyn_bookingchange)
- [owner_msdyn_bookingrule](#BKMK_owner_msdyn_bookingrule)
- [owner_msdyn_bookingsetupmetadata](#BKMK_owner_msdyn_bookingsetupmetadata)
- [owner_msdyn_businessclosure](#BKMK_owner_msdyn_businessclosure)
- [owner_msdyn_channel](#BKMK_owner_msdyn_channel)
- [owner_msdyn_channelinstancesecret](#BKMK_owner_msdyn_channelinstancesecret)
- [owner_msdyn_chatansweroption](#BKMK_owner_msdyn_chatansweroption)
- [owner_msdyn_chatquestionnaireresponse](#BKMK_owner_msdyn_chatquestionnaireresponse)
- [owner_msdyn_chatquestionnaireresponseitem](#BKMK_owner_msdyn_chatquestionnaireresponseitem)
- [owner_msdyn_chatwidgetlanguage](#BKMK_owner_msdyn_chatwidgetlanguage)
- [owner_msdyn_clientextension](#BKMK_owner_msdyn_clientextension)
- [owner_msdyn_configuration](#BKMK_owner_msdyn_configuration)
- [owner_msdyn_conversation_attribute](#BKMK_owner_msdyn_conversation_attribute)
- [owner_msdyn_customengagementctx](#BKMK_owner_msdyn_customengagementctx)
- [owner_msdyn_facebookengagementctx](#BKMK_owner_msdyn_facebookengagementctx)
- [owner_msdyn_lineengagementctx](#BKMK_owner_msdyn_lineengagementctx)
- [owner_msdyn_livechatconfig](#BKMK_owner_msdyn_livechatconfig)
- [owner_msdyn_livechatengagementctx](#BKMK_owner_msdyn_livechatengagementctx)
- [owner_msdyn_livechatwidgetlocation](#BKMK_owner_msdyn_livechatwidgetlocation)
- [owner_msdyn_ocapplebusinessaccount](#BKMK_owner_msdyn_ocapplebusinessaccount)
- [owner_msdyn_ocapplemessagesforbusinessengagementctx](#BKMK_owner_msdyn_ocapplemessagesforbusinessengagementctx)
- [owner_msdyn_ocapplepay](#BKMK_owner_msdyn_ocapplepay)
- [owner_msdyn_occarrier](#BKMK_owner_msdyn_occarrier)
- [owner_msdyn_occommunicationprovidersetting](#BKMK_owner_msdyn_occommunicationprovidersetting)
- [owner_msdyn_occommunicationprovidersettingentry](#BKMK_owner_msdyn_occommunicationprovidersettingentry)
- [owner_msdyn_occustommessagingchannel](#BKMK_owner_msdyn_occustommessagingchannel)
- [owner_msdyn_ocexternalsecuritysetting](#BKMK_owner_msdyn_ocexternalsecuritysetting)
- [owner_msdyn_ocfbapplication](#BKMK_owner_msdyn_ocfbapplication)
- [owner_msdyn_ocfbpage](#BKMK_owner_msdyn_ocfbpage)
- [owner_msdyn_ocgatekeeperengagementctx](#BKMK_owner_msdyn_ocgatekeeperengagementctx)
- [owner_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_owner_msdyn_ocgooglebusinessmessagesagentaccount)
- [owner_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_owner_msdyn_ocgooglebusinessmessagesengagementctx)
- [owner_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_owner_msdyn_ocgooglebusinessmessagespartneraccount)
- [owner_msdyn_oclinechannelconfig](#BKMK_owner_msdyn_oclinechannelconfig)
- [owner_msdyn_ocoutboundconfiguration](#BKMK_owner_msdyn_ocoutboundconfiguration)
- [owner_msdyn_ocphonecallengagementctx](#BKMK_owner_msdyn_ocphonecallengagementctx)
- [owner_msdyn_ocphonemusic](#BKMK_owner_msdyn_ocphonemusic)
- [owner_msdyn_ocphonenumber](#BKMK_owner_msdyn_ocphonenumber)
- [owner_msdyn_ocsmssettingsecret](#BKMK_owner_msdyn_ocsmssettingsecret)
- [owner_msdyn_octeamschannelconfig](#BKMK_owner_msdyn_octeamschannelconfig)
- [owner_msdyn_octwitterapplication](#BKMK_owner_msdyn_octwitterapplication)
- [owner_msdyn_octwitterhandle](#BKMK_owner_msdyn_octwitterhandle)
- [owner_msdyn_octwitterhandleprovisioningstatus](#BKMK_owner_msdyn_octwitterhandleprovisioningstatus)
- [owner_msdyn_octwitterhandlesecret](#BKMK_owner_msdyn_octwitterhandlesecret)
- [owner_msdyn_ocvoice](#BKMK_owner_msdyn_ocvoice)
- [owner_msdyn_ocvoicechannellanguagesetting](#BKMK_owner_msdyn_ocvoicechannellanguagesetting)
- [owner_msdyn_ocvoicechannelsetting](#BKMK_owner_msdyn_ocvoicechannelsetting)
- [owner_msdyn_ocwechatchannelconfig](#BKMK_owner_msdyn_ocwechatchannelconfig)
- [owner_msdyn_ocwhatsappchannelaccount](#BKMK_owner_msdyn_ocwhatsappchannelaccount)
- [owner_msdyn_ocwhatsappchannelnumber](#BKMK_owner_msdyn_ocwhatsappchannelnumber)
- [owner_msdyn_optimizationrequest](#BKMK_owner_msdyn_optimizationrequest)
- [owner_msdyn_priority](#BKMK_owner_msdyn_priority)
- [owner_msdyn_proactive_delivery](#BKMK_owner_msdyn_proactive_delivery)
- [owner_msdyn_proactive_delivery_attribute](#BKMK_owner_msdyn_proactive_delivery_attribute)
- [owner_msdyn_proactive_eng_config_characteristic](#BKMK_owner_msdyn_proactive_eng_config_characteristic)
- [owner_msdyn_proactive_engagement_config](#BKMK_owner_msdyn_proactive_engagement_config)
- [owner_msdyn_proactive_engagement_config_attribute](#BKMK_owner_msdyn_proactive_engagement_config_attribute)
- [owner_msdyn_proactive_engagement_config_status](#BKMK_owner_msdyn_proactive_engagement_config_status)
- [owner_msdyn_questionsequence](#BKMK_owner_msdyn_questionsequence)
- [owner_msdyn_requirementchange](#BKMK_owner_msdyn_requirementchange)
- [owner_msdyn_requirementcharacteristic](#BKMK_owner_msdyn_requirementcharacteristic)
- [owner_msdyn_requirementdependency](#BKMK_owner_msdyn_requirementdependency)
- [owner_msdyn_requirementgroup](#BKMK_owner_msdyn_requirementgroup)
- [owner_msdyn_requirementorganizationunit](#BKMK_owner_msdyn_requirementorganizationunit)
- [owner_msdyn_requirementrelationship](#BKMK_owner_msdyn_requirementrelationship)
- [owner_msdyn_requirementresourcecategory](#BKMK_owner_msdyn_requirementresourcecategory)
- [owner_msdyn_requirementresourcepreference](#BKMK_owner_msdyn_requirementresourcepreference)
- [owner_msdyn_requirementstatus](#BKMK_owner_msdyn_requirementstatus)
- [owner_msdyn_resourcerequirement](#BKMK_owner_msdyn_resourcerequirement)
- [owner_msdyn_resourcerequirementdetail](#BKMK_owner_msdyn_resourcerequirementdetail)
- [owner_msdyn_resourceterritory](#BKMK_owner_msdyn_resourceterritory)
- [owner_msdyn_scenario](#BKMK_owner_msdyn_scenario)
- [owner_msdyn_scheduleboardsetting](#BKMK_owner_msdyn_scheduleboardsetting)
- [owner_msdyn_schedulingfeatureflag](#BKMK_owner_msdyn_schedulingfeatureflag)
- [owner_msdyn_schedulingscope](#BKMK_owner_msdyn_schedulingscope)
- [owner_msdyn_smsengagementctx](#BKMK_owner_msdyn_smsengagementctx)
- [owner_msdyn_smsnumber](#BKMK_owner_msdyn_smsnumber)
- [owner_msdyn_surveyquestion](#BKMK_owner_msdyn_surveyquestion)
- [owner_msdyn_systemuserschedulersetting](#BKMK_owner_msdyn_systemuserschedulersetting)
- [owner_msdyn_teamschannelengagementctx](#BKMK_owner_msdyn_teamschannelengagementctx)
- [owner_msdyn_timegroup](#BKMK_owner_msdyn_timegroup)
- [owner_msdyn_timegroupdetail](#BKMK_owner_msdyn_timegroupdetail)
- [owner_msdyn_transactionorigin](#BKMK_owner_msdyn_transactionorigin)
- [owner_msdyn_twitterengagementctx](#BKMK_owner_msdyn_twitterengagementctx)
- [owner_msdyn_voicechannelorganizationsetting](#BKMK_owner_msdyn_voicechannelorganizationsetting)
- [owner_msdyn_webengagementruleset](#BKMK_owner_msdyn_webengagementruleset)
- [owner_msdyn_webengagementrulesetconfig](#BKMK_owner_msdyn_webengagementrulesetconfig)
- [owner_msdyn_webengagementrulesetrevision](#BKMK_owner_msdyn_webengagementrulesetrevision)
- [owner_msdyn_webengagementsitearea](#BKMK_owner_msdyn_webengagementsitearea)
- [owner_msdyn_wechatengagementctx](#BKMK_owner_msdyn_wechatengagementctx)
- [owner_msdyn_whatsappengagementctx](#BKMK_owner_msdyn_whatsappengagementctx)
- [owner_msdyn_workhourtemplate](#BKMK_owner_msdyn_workhourtemplate)

### <a name="BKMK_msdyn_bookingalert_owner_ownerid"></a> msdyn_bookingalert_owner_ownerid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_owner_ownerid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_owner_ownerid"></a> msdyn_ocoutboundmessage_owner_ownerid

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_owner_ownerid](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_owner_ownerid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicemail_owner_ownerid"></a> msdyn_ocvoicemail_owner_ownerid

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_owner_ownerid](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicemail_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_actual"></a> owner_msdyn_actual

Many-To-One Relationship: [msdyn_actual owner_msdyn_actual](msdyn_actual.md#BKMK_owner_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_amsbuild"></a> owner_msdyn_amsbuild

Many-To-One Relationship: [msdyn_amsbuild owner_msdyn_amsbuild](msdyn_amsbuild.md#BKMK_owner_msdyn_amsbuild)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsbuild`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_amsbuild`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_amsmodel"></a> owner_msdyn_amsmodel

Many-To-One Relationship: [msdyn_amsmodel owner_msdyn_amsmodel](msdyn_amsmodel.md#BKMK_owner_msdyn_amsmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsmodel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_amsmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_amsprofile"></a> owner_msdyn_amsprofile

Many-To-One Relationship: [msdyn_amsprofile owner_msdyn_amsprofile](msdyn_amsprofile.md#BKMK_owner_msdyn_amsprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_amsprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_amsprofilesettings"></a> owner_msdyn_amsprofilesettings

Many-To-One Relationship: [msdyn_amsprofilesettings owner_msdyn_amsprofilesettings](msdyn_amsprofilesettings.md#BKMK_owner_msdyn_amsprofilesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amsprofilesettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_amsprofilesettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_amstag"></a> owner_msdyn_amstag

Many-To-One Relationship: [msdyn_amstag owner_msdyn_amstag](msdyn_amstag.md#BKMK_owner_msdyn_amstag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_amstag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_amstag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_azurenotificationhub"></a> owner_msdyn_azurenotificationhub

Many-To-One Relationship: [msdyn_azurenotificationhub owner_msdyn_azurenotificationhub](msdyn_azurenotificationhub.md#BKMK_owner_msdyn_azurenotificationhub)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_azurenotificationhub`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_azurenotificationhub`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookableresourceassociation"></a> owner_msdyn_bookableresourceassociation

Many-To-One Relationship: [msdyn_bookableresourceassociation owner_msdyn_bookableresourceassociation](msdyn_bookableresourceassociation.md#BKMK_owner_msdyn_bookableresourceassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourceassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookableresourceassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingalertstatus"></a> owner_msdyn_bookingalertstatus

Many-To-One Relationship: [msdyn_bookingalertstatus owner_msdyn_bookingalertstatus](msdyn_bookingalertstatus.md#BKMK_owner_msdyn_bookingalertstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalertstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingalertstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingchange"></a> owner_msdyn_bookingchange

Many-To-One Relationship: [msdyn_bookingchange owner_msdyn_bookingchange](msdyn_bookingchange.md#BKMK_owner_msdyn_bookingchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingchange`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingrule"></a> owner_msdyn_bookingrule

Many-To-One Relationship: [msdyn_bookingrule owner_msdyn_bookingrule](msdyn_bookingrule.md#BKMK_owner_msdyn_bookingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookingsetupmetadata"></a> owner_msdyn_bookingsetupmetadata

Many-To-One Relationship: [msdyn_bookingsetupmetadata owner_msdyn_bookingsetupmetadata](msdyn_bookingsetupmetadata.md#BKMK_owner_msdyn_bookingsetupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingsetupmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingsetupmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_businessclosure"></a> owner_msdyn_businessclosure

Many-To-One Relationship: [msdyn_businessclosure owner_msdyn_businessclosure](msdyn_businessclosure.md#BKMK_owner_msdyn_businessclosure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_businessclosure`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_businessclosure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channel"></a> owner_msdyn_channel

Many-To-One Relationship: [msdyn_channel owner_msdyn_channel](msdyn_channel.md#BKMK_owner_msdyn_channel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channelinstancesecret"></a> owner_msdyn_channelinstancesecret

Many-To-One Relationship: [msdyn_channelinstancesecret owner_msdyn_channelinstancesecret](msdyn_channelinstancesecret.md#BKMK_owner_msdyn_channelinstancesecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstancesecret`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channelinstancesecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_chatansweroption"></a> owner_msdyn_chatansweroption

Many-To-One Relationship: [msdyn_chatansweroption owner_msdyn_chatansweroption](msdyn_chatansweroption.md#BKMK_owner_msdyn_chatansweroption)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatansweroption`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_chatansweroption`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_chatquestionnaireresponse"></a> owner_msdyn_chatquestionnaireresponse

Many-To-One Relationship: [msdyn_chatquestionnaireresponse owner_msdyn_chatquestionnaireresponse](msdyn_chatquestionnaireresponse.md#BKMK_owner_msdyn_chatquestionnaireresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_chatquestionnaireresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_chatquestionnaireresponseitem"></a> owner_msdyn_chatquestionnaireresponseitem

Many-To-One Relationship: [msdyn_chatquestionnaireresponseitem owner_msdyn_chatquestionnaireresponseitem](msdyn_chatquestionnaireresponseitem.md#BKMK_owner_msdyn_chatquestionnaireresponseitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatquestionnaireresponseitem`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_chatquestionnaireresponseitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_chatwidgetlanguage"></a> owner_msdyn_chatwidgetlanguage

Many-To-One Relationship: [msdyn_chatwidgetlanguage owner_msdyn_chatwidgetlanguage](msdyn_chatwidgetlanguage.md#BKMK_owner_msdyn_chatwidgetlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_chatwidgetlanguage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_chatwidgetlanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_clientextension"></a> owner_msdyn_clientextension

Many-To-One Relationship: [msdyn_clientextension owner_msdyn_clientextension](msdyn_clientextension.md#BKMK_owner_msdyn_clientextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_clientextension`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_clientextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_configuration"></a> owner_msdyn_configuration

Many-To-One Relationship: [msdyn_configuration owner_msdyn_configuration](msdyn_configuration.md#BKMK_owner_msdyn_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_configuration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversation_attribute"></a> owner_msdyn_conversation_attribute

Many-To-One Relationship: [msdyn_conversation_attribute owner_msdyn_conversation_attribute](msdyn_conversation_attribute.md#BKMK_owner_msdyn_conversation_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversation_attribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversation_attribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_customengagementctx"></a> owner_msdyn_customengagementctx

Many-To-One Relationship: [msdyn_customengagementctx owner_msdyn_customengagementctx](msdyn_customengagementctx.md#BKMK_owner_msdyn_customengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_customengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_facebookengagementctx"></a> owner_msdyn_facebookengagementctx

Many-To-One Relationship: [msdyn_facebookengagementctx owner_msdyn_facebookengagementctx](msdyn_facebookengagementctx.md#BKMK_owner_msdyn_facebookengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_facebookengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_facebookengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_lineengagementctx"></a> owner_msdyn_lineengagementctx

Many-To-One Relationship: [msdyn_lineengagementctx owner_msdyn_lineengagementctx](msdyn_lineengagementctx.md#BKMK_owner_msdyn_lineengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_lineengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_lineengagementctx`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_livechatconfig"></a> owner_msdyn_livechatconfig

Many-To-One Relationship: [msdyn_livechatconfig owner_msdyn_livechatconfig](msdyn_livechatconfig.md#BKMK_owner_msdyn_livechatconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_livechatconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_livechatengagementctx"></a> owner_msdyn_livechatengagementctx

Many-To-One Relationship: [msdyn_livechatengagementctx owner_msdyn_livechatengagementctx](msdyn_livechatengagementctx.md#BKMK_owner_msdyn_livechatengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_livechatengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_livechatwidgetlocation"></a> owner_msdyn_livechatwidgetlocation

Many-To-One Relationship: [msdyn_livechatwidgetlocation owner_msdyn_livechatwidgetlocation](msdyn_livechatwidgetlocation.md#BKMK_owner_msdyn_livechatwidgetlocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_livechatwidgetlocation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_livechatwidgetlocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocapplebusinessaccount"></a> owner_msdyn_ocapplebusinessaccount

Many-To-One Relationship: [msdyn_ocapplebusinessaccount owner_msdyn_ocapplebusinessaccount](msdyn_ocapplebusinessaccount.md#BKMK_owner_msdyn_ocapplebusinessaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplebusinessaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocapplebusinessaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocapplemessagesforbusinessengagementctx"></a> owner_msdyn_ocapplemessagesforbusinessengagementctx

Many-To-One Relationship: [msdyn_ocapplemessagesforbusinessengagementctx owner_msdyn_ocapplemessagesforbusinessengagementctx](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_owner_msdyn_ocapplemessagesforbusinessengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocapplemessagesforbusinessengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocapplepay"></a> owner_msdyn_ocapplepay

Many-To-One Relationship: [msdyn_ocapplepay owner_msdyn_ocapplepay](msdyn_ocapplepay.md#BKMK_owner_msdyn_ocapplepay)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocapplepay`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocapplepay`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_occarrier"></a> owner_msdyn_occarrier

Many-To-One Relationship: [msdyn_occarrier owner_msdyn_occarrier](msdyn_occarrier.md#BKMK_owner_msdyn_occarrier)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occarrier`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_occarrier`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_occommunicationprovidersetting"></a> owner_msdyn_occommunicationprovidersetting

Many-To-One Relationship: [msdyn_occommunicationprovidersetting owner_msdyn_occommunicationprovidersetting](msdyn_occommunicationprovidersetting.md#BKMK_owner_msdyn_occommunicationprovidersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occommunicationprovidersetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_occommunicationprovidersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_occommunicationprovidersettingentry"></a> owner_msdyn_occommunicationprovidersettingentry

Many-To-One Relationship: [msdyn_occommunicationprovidersettingentry owner_msdyn_occommunicationprovidersettingentry](msdyn_occommunicationprovidersettingentry.md#BKMK_owner_msdyn_occommunicationprovidersettingentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occommunicationprovidersettingentry`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_occommunicationprovidersettingentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_occustommessagingchannel"></a> owner_msdyn_occustommessagingchannel

Many-To-One Relationship: [msdyn_occustommessagingchannel owner_msdyn_occustommessagingchannel](msdyn_occustommessagingchannel.md#BKMK_owner_msdyn_occustommessagingchannel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occustommessagingchannel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_occustommessagingchannel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocexternalsecuritysetting"></a> owner_msdyn_ocexternalsecuritysetting

Many-To-One Relationship: [msdyn_ocexternalsecuritysetting owner_msdyn_ocexternalsecuritysetting](msdyn_ocexternalsecuritysetting.md#BKMK_owner_msdyn_ocexternalsecuritysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalsecuritysetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocexternalsecuritysetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocfbapplication"></a> owner_msdyn_ocfbapplication

Many-To-One Relationship: [msdyn_ocfbapplication owner_msdyn_ocfbapplication](msdyn_ocfbapplication.md#BKMK_owner_msdyn_ocfbapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocfbapplication`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocfbapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocfbpage"></a> owner_msdyn_ocfbpage

Many-To-One Relationship: [msdyn_ocfbpage owner_msdyn_ocfbpage](msdyn_ocfbpage.md#BKMK_owner_msdyn_ocfbpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocfbpage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocfbpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocgatekeeperengagementctx"></a> owner_msdyn_ocgatekeeperengagementctx

Many-To-One Relationship: [msdyn_ocgatekeeperengagementctx owner_msdyn_ocgatekeeperengagementctx](msdyn_ocgatekeeperengagementctx.md#BKMK_owner_msdyn_ocgatekeeperengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocgatekeeperengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocgooglebusinessmessagesagentaccount"></a> owner_msdyn_ocgooglebusinessmessagesagentaccount

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesagentaccount owner_msdyn_ocgooglebusinessmessagesagentaccount](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_owner_msdyn_ocgooglebusinessmessagesagentaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocgooglebusinessmessagesagentaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocgooglebusinessmessagesengagementctx"></a> owner_msdyn_ocgooglebusinessmessagesengagementctx

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagesengagementctx owner_msdyn_ocgooglebusinessmessagesengagementctx](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_owner_msdyn_ocgooglebusinessmessagesengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocgooglebusinessmessagesengagementctx`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocgooglebusinessmessagespartneraccount"></a> owner_msdyn_ocgooglebusinessmessagespartneraccount

Many-To-One Relationship: [msdyn_ocgooglebusinessmessagespartneraccount owner_msdyn_ocgooglebusinessmessagespartneraccount](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_owner_msdyn_ocgooglebusinessmessagespartneraccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocgooglebusinessmessagespartneraccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_oclinechannelconfig"></a> owner_msdyn_oclinechannelconfig

Many-To-One Relationship: [msdyn_oclinechannelconfig owner_msdyn_oclinechannelconfig](msdyn_oclinechannelconfig.md#BKMK_owner_msdyn_oclinechannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclinechannelconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_oclinechannelconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocoutboundconfiguration"></a> owner_msdyn_ocoutboundconfiguration

Many-To-One Relationship: [msdyn_ocoutboundconfiguration owner_msdyn_ocoutboundconfiguration](msdyn_ocoutboundconfiguration.md#BKMK_owner_msdyn_ocoutboundconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocoutboundconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocphonecallengagementctx"></a> owner_msdyn_ocphonecallengagementctx

Many-To-One Relationship: [msdyn_ocphonecallengagementctx owner_msdyn_ocphonecallengagementctx](msdyn_ocphonecallengagementctx.md#BKMK_owner_msdyn_ocphonecallengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonecallengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocphonecallengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocphonemusic"></a> owner_msdyn_ocphonemusic

Many-To-One Relationship: [msdyn_ocphonemusic owner_msdyn_ocphonemusic](msdyn_ocphonemusic.md#BKMK_owner_msdyn_ocphonemusic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonemusic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocphonemusic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocphonenumber"></a> owner_msdyn_ocphonenumber

Many-To-One Relationship: [msdyn_ocphonenumber owner_msdyn_ocphonenumber](msdyn_ocphonenumber.md#BKMK_owner_msdyn_ocphonenumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocphonenumber`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocphonenumber`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsmssettingsecret"></a> owner_msdyn_ocsmssettingsecret

Many-To-One Relationship: [msdyn_ocsmssettingsecret owner_msdyn_ocsmssettingsecret](msdyn_ocsmssettingsecret.md#BKMK_owner_msdyn_ocsmssettingsecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsmssettingsecret`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsmssettingsecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_octeamschannelconfig"></a> owner_msdyn_octeamschannelconfig

Many-To-One Relationship: [msdyn_octeamschannelconfig owner_msdyn_octeamschannelconfig](msdyn_octeamschannelconfig.md#BKMK_owner_msdyn_octeamschannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octeamschannelconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_octeamschannelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_octwitterapplication"></a> owner_msdyn_octwitterapplication

Many-To-One Relationship: [msdyn_octwitterapplication owner_msdyn_octwitterapplication](msdyn_octwitterapplication.md#BKMK_owner_msdyn_octwitterapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterapplication`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_octwitterapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_octwitterhandle"></a> owner_msdyn_octwitterhandle

Many-To-One Relationship: [msdyn_octwitterhandle owner_msdyn_octwitterhandle](msdyn_octwitterhandle.md#BKMK_owner_msdyn_octwitterhandle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_octwitterhandle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_octwitterhandleprovisioningstatus"></a> owner_msdyn_octwitterhandleprovisioningstatus

Many-To-One Relationship: [msdyn_octwitterhandleprovisioningstatus owner_msdyn_octwitterhandleprovisioningstatus](msdyn_octwitterhandleprovisioningstatus.md#BKMK_owner_msdyn_octwitterhandleprovisioningstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandleprovisioningstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_octwitterhandleprovisioningstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_octwitterhandlesecret"></a> owner_msdyn_octwitterhandlesecret

Many-To-One Relationship: [msdyn_octwitterhandlesecret owner_msdyn_octwitterhandlesecret](msdyn_octwitterhandlesecret.md#BKMK_owner_msdyn_octwitterhandlesecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octwitterhandlesecret`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_octwitterhandlesecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocvoice"></a> owner_msdyn_ocvoice

Many-To-One Relationship: [msdyn_ocvoice owner_msdyn_ocvoice](msdyn_ocvoice.md#BKMK_owner_msdyn_ocvoice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocvoice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocvoicechannellanguagesetting"></a> owner_msdyn_ocvoicechannellanguagesetting

Many-To-One Relationship: [msdyn_ocvoicechannellanguagesetting owner_msdyn_ocvoicechannellanguagesetting](msdyn_ocvoicechannellanguagesetting.md#BKMK_owner_msdyn_ocvoicechannellanguagesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocvoicechannellanguagesetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocvoicechannelsetting"></a> owner_msdyn_ocvoicechannelsetting

Many-To-One Relationship: [msdyn_ocvoicechannelsetting owner_msdyn_ocvoicechannelsetting](msdyn_ocvoicechannelsetting.md#BKMK_owner_msdyn_ocvoicechannelsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannelsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocvoicechannelsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocwechatchannelconfig"></a> owner_msdyn_ocwechatchannelconfig

Many-To-One Relationship: [msdyn_ocwechatchannelconfig owner_msdyn_ocwechatchannelconfig](msdyn_ocwechatchannelconfig.md#BKMK_owner_msdyn_ocwechatchannelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwechatchannelconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocwechatchannelconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocwhatsappchannelaccount"></a> owner_msdyn_ocwhatsappchannelaccount

Many-To-One Relationship: [msdyn_ocwhatsappchannelaccount owner_msdyn_ocwhatsappchannelaccount](msdyn_ocwhatsappchannelaccount.md#BKMK_owner_msdyn_ocwhatsappchannelaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocwhatsappchannelaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocwhatsappchannelnumber"></a> owner_msdyn_ocwhatsappchannelnumber

Many-To-One Relationship: [msdyn_ocwhatsappchannelnumber owner_msdyn_ocwhatsappchannelnumber](msdyn_ocwhatsappchannelnumber.md#BKMK_owner_msdyn_ocwhatsappchannelnumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocwhatsappchannelnumber`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_optimizationrequest"></a> owner_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest owner_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_owner_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_optimizationrequest`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_priority"></a> owner_msdyn_priority

Many-To-One Relationship: [msdyn_priority owner_msdyn_priority](msdyn_priority.md#BKMK_owner_msdyn_priority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_priority`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_priority`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_proactive_delivery"></a> owner_msdyn_proactive_delivery

Many-To-One Relationship: [msdyn_proactive_delivery owner_msdyn_proactive_delivery](msdyn_proactive_delivery.md#BKMK_owner_msdyn_proactive_delivery)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_proactive_delivery`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_proactive_delivery_attribute"></a> owner_msdyn_proactive_delivery_attribute

Many-To-One Relationship: [msdyn_proactive_delivery_attribute owner_msdyn_proactive_delivery_attribute](msdyn_proactive_delivery_attribute.md#BKMK_owner_msdyn_proactive_delivery_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery_attribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_proactive_delivery_attribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_proactive_eng_config_characteristic"></a> owner_msdyn_proactive_eng_config_characteristic

Many-To-One Relationship: [msdyn_proactive_eng_config_characteristic owner_msdyn_proactive_eng_config_characteristic](msdyn_proactive_eng_config_characteristic.md#BKMK_owner_msdyn_proactive_eng_config_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_proactive_eng_config_characteristic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_proactive_engagement_config"></a> owner_msdyn_proactive_engagement_config

Many-To-One Relationship: [msdyn_proactive_engagement_config owner_msdyn_proactive_engagement_config](msdyn_proactive_engagement_config.md#BKMK_owner_msdyn_proactive_engagement_config)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_proactive_engagement_config`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_proactive_engagement_config_attribute"></a> owner_msdyn_proactive_engagement_config_attribute

Many-To-One Relationship: [msdyn_proactive_engagement_config_attribute owner_msdyn_proactive_engagement_config_attribute](msdyn_proactive_engagement_config_attribute.md#BKMK_owner_msdyn_proactive_engagement_config_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config_attribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_proactive_engagement_config_attribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_proactive_engagement_config_status"></a> owner_msdyn_proactive_engagement_config_status

Many-To-One Relationship: [msdyn_proactive_engagement_config_status owner_msdyn_proactive_engagement_config_status](msdyn_proactive_engagement_config_status.md#BKMK_owner_msdyn_proactive_engagement_config_status)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config_status`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_proactive_engagement_config_status`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_questionsequence"></a> owner_msdyn_questionsequence

Many-To-One Relationship: [msdyn_questionsequence owner_msdyn_questionsequence](msdyn_questionsequence.md#BKMK_owner_msdyn_questionsequence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_questionsequence`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_questionsequence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementchange"></a> owner_msdyn_requirementchange

Many-To-One Relationship: [msdyn_requirementchange owner_msdyn_requirementchange](msdyn_requirementchange.md#BKMK_owner_msdyn_requirementchange)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementchange`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementchange`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementcharacteristic"></a> owner_msdyn_requirementcharacteristic

Many-To-One Relationship: [msdyn_requirementcharacteristic owner_msdyn_requirementcharacteristic](msdyn_requirementcharacteristic.md#BKMK_owner_msdyn_requirementcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementdependency"></a> owner_msdyn_requirementdependency

Many-To-One Relationship: [msdyn_requirementdependency owner_msdyn_requirementdependency](msdyn_requirementdependency.md#BKMK_owner_msdyn_requirementdependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementdependency`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementdependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementgroup"></a> owner_msdyn_requirementgroup

Many-To-One Relationship: [msdyn_requirementgroup owner_msdyn_requirementgroup](msdyn_requirementgroup.md#BKMK_owner_msdyn_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementgroup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementorganizationunit"></a> owner_msdyn_requirementorganizationunit

Many-To-One Relationship: [msdyn_requirementorganizationunit owner_msdyn_requirementorganizationunit](msdyn_requirementorganizationunit.md#BKMK_owner_msdyn_requirementorganizationunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementorganizationunit`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementorganizationunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementrelationship"></a> owner_msdyn_requirementrelationship

Many-To-One Relationship: [msdyn_requirementrelationship owner_msdyn_requirementrelationship](msdyn_requirementrelationship.md#BKMK_owner_msdyn_requirementrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementrelationship`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementrelationship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementresourcecategory"></a> owner_msdyn_requirementresourcecategory

Many-To-One Relationship: [msdyn_requirementresourcecategory owner_msdyn_requirementresourcecategory](msdyn_requirementresourcecategory.md#BKMK_owner_msdyn_requirementresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcecategory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementresourcepreference"></a> owner_msdyn_requirementresourcepreference

Many-To-One Relationship: [msdyn_requirementresourcepreference owner_msdyn_requirementresourcepreference](msdyn_requirementresourcepreference.md#BKMK_owner_msdyn_requirementresourcepreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementresourcepreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_requirementstatus"></a> owner_msdyn_requirementstatus

Many-To-One Relationship: [msdyn_requirementstatus owner_msdyn_requirementstatus](msdyn_requirementstatus.md#BKMK_owner_msdyn_requirementstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_requirementstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resourcerequirement"></a> owner_msdyn_resourcerequirement

Many-To-One Relationship: [msdyn_resourcerequirement owner_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_owner_msdyn_resourcerequirement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resourcerequirement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resourcerequirementdetail"></a> owner_msdyn_resourcerequirementdetail

Many-To-One Relationship: [msdyn_resourcerequirementdetail owner_msdyn_resourcerequirementdetail](msdyn_resourcerequirementdetail.md#BKMK_owner_msdyn_resourcerequirementdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirementdetail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resourcerequirementdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resourceterritory"></a> owner_msdyn_resourceterritory

Many-To-One Relationship: [msdyn_resourceterritory owner_msdyn_resourceterritory](msdyn_resourceterritory.md#BKMK_owner_msdyn_resourceterritory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourceterritory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resourceterritory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_scenario"></a> owner_msdyn_scenario

Many-To-One Relationship: [msdyn_scenario owner_msdyn_scenario](msdyn_scenario.md#BKMK_owner_msdyn_scenario)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scenario`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_scenario`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_scheduleboardsetting"></a> owner_msdyn_scheduleboardsetting

Many-To-One Relationship: [msdyn_scheduleboardsetting owner_msdyn_scheduleboardsetting](msdyn_scheduleboardsetting.md#BKMK_owner_msdyn_scheduleboardsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scheduleboardsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_scheduleboardsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_schedulingfeatureflag"></a> owner_msdyn_schedulingfeatureflag

Many-To-One Relationship: [msdyn_schedulingfeatureflag owner_msdyn_schedulingfeatureflag](msdyn_schedulingfeatureflag.md#BKMK_owner_msdyn_schedulingfeatureflag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingfeatureflag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_schedulingfeatureflag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_schedulingscope"></a> owner_msdyn_schedulingscope

Many-To-One Relationship: [msdyn_schedulingscope owner_msdyn_schedulingscope](msdyn_schedulingscope.md#BKMK_owner_msdyn_schedulingscope)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_schedulingscope`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_schedulingscope`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_smsengagementctx"></a> owner_msdyn_smsengagementctx

Many-To-One Relationship: [msdyn_smsengagementctx owner_msdyn_smsengagementctx](msdyn_smsengagementctx.md#BKMK_owner_msdyn_smsengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_smsengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_smsnumber"></a> owner_msdyn_smsnumber

Many-To-One Relationship: [msdyn_smsnumber owner_msdyn_smsnumber](msdyn_smsnumber.md#BKMK_owner_msdyn_smsnumber)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsnumber`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_smsnumber`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_surveyquestion"></a> owner_msdyn_surveyquestion

Many-To-One Relationship: [msdyn_surveyquestion owner_msdyn_surveyquestion](msdyn_surveyquestion.md#BKMK_owner_msdyn_surveyquestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_surveyquestion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_surveyquestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_systemuserschedulersetting"></a> owner_msdyn_systemuserschedulersetting

Many-To-One Relationship: [msdyn_systemuserschedulersetting owner_msdyn_systemuserschedulersetting](msdyn_systemuserschedulersetting.md#BKMK_owner_msdyn_systemuserschedulersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_systemuserschedulersetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_systemuserschedulersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_teamschannelengagementctx"></a> owner_msdyn_teamschannelengagementctx

Many-To-One Relationship: [msdyn_teamschannelengagementctx owner_msdyn_teamschannelengagementctx](msdyn_teamschannelengagementctx.md#BKMK_owner_msdyn_teamschannelengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamschannelengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_teamschannelengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timegroup"></a> owner_msdyn_timegroup

Many-To-One Relationship: [msdyn_timegroup owner_msdyn_timegroup](msdyn_timegroup.md#BKMK_owner_msdyn_timegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timegroupdetail"></a> owner_msdyn_timegroupdetail

Many-To-One Relationship: [msdyn_timegroupdetail owner_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_owner_msdyn_timegroupdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timegroupdetail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timegroupdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_transactionorigin"></a> owner_msdyn_transactionorigin

Many-To-One Relationship: [msdyn_transactionorigin owner_msdyn_transactionorigin](msdyn_transactionorigin.md#BKMK_owner_msdyn_transactionorigin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transactionorigin`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_transactionorigin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_twitterengagementctx"></a> owner_msdyn_twitterengagementctx

Many-To-One Relationship: [msdyn_twitterengagementctx owner_msdyn_twitterengagementctx](msdyn_twitterengagementctx.md#BKMK_owner_msdyn_twitterengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_twitterengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_twitterengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_voicechannelorganizationsetting"></a> owner_msdyn_voicechannelorganizationsetting

Many-To-One Relationship: [msdyn_voicechannelorganizationsetting owner_msdyn_voicechannelorganizationsetting](msdyn_voicechannelorganizationsetting.md#BKMK_owner_msdyn_voicechannelorganizationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_voicechannelorganizationsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_voicechannelorganizationsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_webengagementruleset"></a> owner_msdyn_webengagementruleset

Many-To-One Relationship: [msdyn_webengagementruleset owner_msdyn_webengagementruleset](msdyn_webengagementruleset.md#BKMK_owner_msdyn_webengagementruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementruleset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_webengagementruleset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_webengagementrulesetconfig"></a> owner_msdyn_webengagementrulesetconfig

Many-To-One Relationship: [msdyn_webengagementrulesetconfig owner_msdyn_webengagementrulesetconfig](msdyn_webengagementrulesetconfig.md#BKMK_owner_msdyn_webengagementrulesetconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementrulesetconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_webengagementrulesetconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_webengagementrulesetrevision"></a> owner_msdyn_webengagementrulesetrevision

Many-To-One Relationship: [msdyn_webengagementrulesetrevision owner_msdyn_webengagementrulesetrevision](msdyn_webengagementrulesetrevision.md#BKMK_owner_msdyn_webengagementrulesetrevision)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementrulesetrevision`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_webengagementrulesetrevision`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_webengagementsitearea"></a> owner_msdyn_webengagementsitearea

Many-To-One Relationship: [msdyn_webengagementsitearea owner_msdyn_webengagementsitearea](msdyn_webengagementsitearea.md#BKMK_owner_msdyn_webengagementsitearea)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_webengagementsitearea`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_webengagementsitearea`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_wechatengagementctx"></a> owner_msdyn_wechatengagementctx

Many-To-One Relationship: [msdyn_wechatengagementctx owner_msdyn_wechatengagementctx](msdyn_wechatengagementctx.md#BKMK_owner_msdyn_wechatengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wechatengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_wechatengagementctx`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_whatsappengagementctx"></a> owner_msdyn_whatsappengagementctx

Many-To-One Relationship: [msdyn_whatsappengagementctx owner_msdyn_whatsappengagementctx](msdyn_whatsappengagementctx.md#BKMK_owner_msdyn_whatsappengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_whatsappengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_whatsappengagementctx`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workhourtemplate"></a> owner_msdyn_workhourtemplate

Many-To-One Relationship: [msdyn_workhourtemplate owner_msdyn_workhourtemplate](msdyn_workhourtemplate.md#BKMK_owner_msdyn_workhourtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workhourtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workhourtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

