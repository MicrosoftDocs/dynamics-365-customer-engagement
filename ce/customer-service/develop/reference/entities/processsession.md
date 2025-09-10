---
title: "Process Session (ProcessSession) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Process Session (ProcessSession) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Process Session (ProcessSession) table/entity reference (Microsoft Dynamics 365 Customer Service)

Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Process Session (ProcessSession) table extends the [Microsoft Dynamics 365 Process Session (ProcessSession) table](/dynamics365/developer/reference/entities/processsession).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/processsession#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_amsbuild, msdyn_amsmodel, msdyn_amsprofile, msdyn_amsprofilesettings, msdyn_amstag, msdyn_azurenotificationhub, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_channel, msdyn_channelinstancesecret, msdyn_chatansweroption, msdyn_chatquestionnaireresponse, msdyn_chatquestionnaireresponseitem, msdyn_chatwidgetlanguage, msdyn_clientextension, msdyn_configuration, msdyn_customengagementctx, msdyn_facebookengagementctx, msdyn_lineengagementctx, msdyn_livechatconfig, msdyn_livechatengagementctx, msdyn_livechatwidgetlocation, msdyn_localizedsurveyquestion, msdyn_ocapplebusinessaccount, msdyn_ocapplemessagesforbusinessengagementctx, msdyn_ocapplepay, msdyn_occarrier, msdyn_occommunicationprovidersetting, msdyn_occommunicationprovidersettingentry, msdyn_occustommessagingchannel, msdyn_ocexternalsecuritysetting, msdyn_ocfbapplication, msdyn_ocfbpage, msdyn_ocgatekeeperengagementctx, msdyn_ocgooglebusinessmessagesagentaccount, msdyn_ocgooglebusinessmessagesengagementctx, msdyn_ocgooglebusinessmessagespartneraccount, msdyn_oclinechannelconfig, msdyn_ocoutboundconfiguration, msdyn_ocoutboundmessage, msdyn_ocphonecallengagementctx, msdyn_ocphonemusic, msdyn_ocphonenumber, msdyn_ocsmschannelsetting, msdyn_ocsmssettingsecret, msdyn_octeamschannelconfig, msdyn_octwitterapplication, msdyn_octwitterhandle, msdyn_octwitterhandleprovisioningstatus, msdyn_octwitterhandlesecret, msdyn_ocvoice, msdyn_ocvoicechannellanguagesetting, msdyn_ocvoicechannelsetting, msdyn_ocvoicemail, msdyn_ocwechatchannelconfig, msdyn_ocwhatsappchannelaccount, msdyn_ocwhatsappchannelnumber, msdyn_organizationalunit, msdyn_priority, msdyn_proactive_eng_config_characteristic, msdyn_proactive_engagement_config, msdyn_proactive_engagement_config_attribute, msdyn_proactive_engagement_config_status, msdyn_questionsequence, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scenario, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_smsengagementctx, msdyn_smsnumber, msdyn_surveyquestion, msdyn_systemuserschedulersetting, msdyn_teamschannelengagementctx, msdyn_teamsengagementctx, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_twitterengagementctx, msdyn_voicechannelorganizationsetting, msdyn_webengagementruleset, msdyn_webengagementrulesetconfig, msdyn_webengagementrulesetrevision, msdyn_webengagementsitearea, msdyn_wechatengagementctx, msdyn_whatsappengagementctx, msdyn_workhourtemplate, msdyn_workstreamhmmigrationstatus|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_ProcessSession](#BKMK_msdyn_actual_ProcessSession)
- [msdyn_amsbuild_ProcessSession](#BKMK_msdyn_amsbuild_ProcessSession)
- [msdyn_amsmodel_ProcessSession](#BKMK_msdyn_amsmodel_ProcessSession)
- [msdyn_amsprofile_ProcessSession](#BKMK_msdyn_amsprofile_ProcessSession)
- [msdyn_amsprofilesettings_ProcessSession](#BKMK_msdyn_amsprofilesettings_ProcessSession)
- [msdyn_amstag_ProcessSession](#BKMK_msdyn_amstag_ProcessSession)
- [msdyn_azurenotificationhub_ProcessSession](#BKMK_msdyn_azurenotificationhub_ProcessSession)
- [msdyn_bookableresourceassociation_ProcessSession](#BKMK_msdyn_bookableresourceassociation_ProcessSession)
- [msdyn_bookingalert_ProcessSession](#BKMK_msdyn_bookingalert_ProcessSession)
- [msdyn_bookingalertstatus_ProcessSession](#BKMK_msdyn_bookingalertstatus_ProcessSession)
- [msdyn_bookingchange_ProcessSession](#BKMK_msdyn_bookingchange_ProcessSession)
- [msdyn_bookingrule_ProcessSession](#BKMK_msdyn_bookingrule_ProcessSession)
- [msdyn_bookingsetupmetadata_ProcessSession](#BKMK_msdyn_bookingsetupmetadata_ProcessSession)
- [msdyn_businessclosure_ProcessSession](#BKMK_msdyn_businessclosure_ProcessSession)
- [msdyn_channel_ProcessSession](#BKMK_msdyn_channel_ProcessSession)
- [msdyn_channelinstancesecret_ProcessSession](#BKMK_msdyn_channelinstancesecret_ProcessSession)
- [msdyn_chatansweroption_ProcessSession](#BKMK_msdyn_chatansweroption_ProcessSession)
- [msdyn_chatquestionnaireresponse_ProcessSession](#BKMK_msdyn_chatquestionnaireresponse_ProcessSession)
- [msdyn_chatquestionnaireresponseitem_ProcessSession](#BKMK_msdyn_chatquestionnaireresponseitem_ProcessSession)
- [msdyn_chatwidgetlanguage_ProcessSession](#BKMK_msdyn_chatwidgetlanguage_ProcessSession)
- [msdyn_clientextension_ProcessSession](#BKMK_msdyn_clientextension_ProcessSession)
- [msdyn_configuration_ProcessSession](#BKMK_msdyn_configuration_ProcessSession)
- [msdyn_customengagementctx_ProcessSession](#BKMK_msdyn_customengagementctx_ProcessSession)
- [msdyn_facebookengagementctx_ProcessSession](#BKMK_msdyn_facebookengagementctx_ProcessSession)
- [msdyn_lineengagementctx_ProcessSession](#BKMK_msdyn_lineengagementctx_ProcessSession)
- [msdyn_livechatconfig_ProcessSession](#BKMK_msdyn_livechatconfig_ProcessSession)
- [msdyn_livechatengagementctx_ProcessSession](#BKMK_msdyn_livechatengagementctx_ProcessSession)
- [msdyn_livechatwidgetlocation_ProcessSession](#BKMK_msdyn_livechatwidgetlocation_ProcessSession)
- [msdyn_localizedsurveyquestion_ProcessSession](#BKMK_msdyn_localizedsurveyquestion_ProcessSession)
- [msdyn_ocapplebusinessaccount_ProcessSession](#BKMK_msdyn_ocapplebusinessaccount_ProcessSession)
- [msdyn_ocapplemessagesforbusinessengagementctx_ProcessSession](#BKMK_msdyn_ocapplemessagesforbusinessengagementctx_ProcessSession)
- [msdyn_ocapplepay_ProcessSession](#BKMK_msdyn_ocapplepay_ProcessSession)
- [msdyn_occarrier_ProcessSession](#BKMK_msdyn_occarrier_ProcessSession)
- [msdyn_occommunicationprovidersetting_ProcessSession](#BKMK_msdyn_occommunicationprovidersetting_ProcessSession)
- [msdyn_occommunicationprovidersettingentry_ProcessSession](#BKMK_msdyn_occommunicationprovidersettingentry_ProcessSession)
- [msdyn_occustommessagingchannel_ProcessSession](#BKMK_msdyn_occustommessagingchannel_ProcessSession)
- [msdyn_ocexternalsecuritysetting_ProcessSession](#BKMK_msdyn_ocexternalsecuritysetting_ProcessSession)
- [msdyn_ocfbapplication_ProcessSession](#BKMK_msdyn_ocfbapplication_ProcessSession)
- [msdyn_ocfbpage_ProcessSession](#BKMK_msdyn_ocfbpage_ProcessSession)
- [msdyn_ocgatekeeperengagementctx_ProcessSession](#BKMK_msdyn_ocgatekeeperengagementctx_ProcessSession)
- [msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession)
- [msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession)
- [msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession)
- [msdyn_oclinechannelconfig_ProcessSession](#BKMK_msdyn_oclinechannelconfig_ProcessSession)
- [msdyn_ocoutboundconfiguration_ProcessSession](#BKMK_msdyn_ocoutboundconfiguration_ProcessSession)
- [msdyn_ocoutboundmessage_ProcessSession](#BKMK_msdyn_ocoutboundmessage_ProcessSession)
- [msdyn_ocphonecallengagementctx_ProcessSession](#BKMK_msdyn_ocphonecallengagementctx_ProcessSession)
- [msdyn_ocphonemusic_ProcessSession](#BKMK_msdyn_ocphonemusic_ProcessSession)
- [msdyn_ocphonenumber_ProcessSession](#BKMK_msdyn_ocphonenumber_ProcessSession)
- [msdyn_ocsmschannelsetting_ProcessSession](#BKMK_msdyn_ocsmschannelsetting_ProcessSession)
- [msdyn_ocsmssettingsecret_ProcessSession](#BKMK_msdyn_ocsmssettingsecret_ProcessSession)
- [msdyn_octeamschannelconfig_ProcessSession](#BKMK_msdyn_octeamschannelconfig_ProcessSession)
- [msdyn_octwitterapplication_ProcessSession](#BKMK_msdyn_octwitterapplication_ProcessSession)
- [msdyn_octwitterhandle_ProcessSession](#BKMK_msdyn_octwitterhandle_ProcessSession)
- [msdyn_octwitterhandleprovisioningstatus_ProcessSession](#BKMK_msdyn_octwitterhandleprovisioningstatus_ProcessSession)
- [msdyn_octwitterhandlesecret_ProcessSession](#BKMK_msdyn_octwitterhandlesecret_ProcessSession)
- [msdyn_ocvoice_ProcessSession](#BKMK_msdyn_ocvoice_ProcessSession)
- [msdyn_ocvoicechannellanguagesetting_ProcessSession](#BKMK_msdyn_ocvoicechannellanguagesetting_ProcessSession)
- [msdyn_ocvoicechannelsetting_ProcessSession](#BKMK_msdyn_ocvoicechannelsetting_ProcessSession)
- [msdyn_ocvoicemail_ProcessSession](#BKMK_msdyn_ocvoicemail_ProcessSession)
- [msdyn_ocwechatchannelconfig_ProcessSession](#BKMK_msdyn_ocwechatchannelconfig_ProcessSession)
- [msdyn_ocwhatsappchannelaccount_ProcessSession](#BKMK_msdyn_ocwhatsappchannelaccount_ProcessSession)
- [msdyn_ocwhatsappchannelnumber_ProcessSession](#BKMK_msdyn_ocwhatsappchannelnumber_ProcessSession)
- [msdyn_organizationalunit_ProcessSession](#BKMK_msdyn_organizationalunit_ProcessSession)
- [msdyn_priority_ProcessSession](#BKMK_msdyn_priority_ProcessSession)
- [msdyn_proactive_eng_config_characteristic_ProcessSession](#BKMK_msdyn_proactive_eng_config_characteristic_ProcessSession)
- [msdyn_proactive_engagement_config_attribute_ProcessSession](#BKMK_msdyn_proactive_engagement_config_attribute_ProcessSession)
- [msdyn_proactive_engagement_config_ProcessSession](#BKMK_msdyn_proactive_engagement_config_ProcessSession)
- [msdyn_proactive_engagement_config_status_ProcessSession](#BKMK_msdyn_proactive_engagement_config_status_ProcessSession)
- [msdyn_questionsequence_ProcessSession](#BKMK_msdyn_questionsequence_ProcessSession)
- [msdyn_requirementchange_ProcessSession](#BKMK_msdyn_requirementchange_ProcessSession)
- [msdyn_requirementcharacteristic_ProcessSession](#BKMK_msdyn_requirementcharacteristic_ProcessSession)
- [msdyn_requirementdependency_ProcessSession](#BKMK_msdyn_requirementdependency_ProcessSession)
- [msdyn_requirementgroup_ProcessSession](#BKMK_msdyn_requirementgroup_ProcessSession)
- [msdyn_requirementorganizationunit_ProcessSession](#BKMK_msdyn_requirementorganizationunit_ProcessSession)
- [msdyn_requirementrelationship_ProcessSession](#BKMK_msdyn_requirementrelationship_ProcessSession)
- [msdyn_requirementresourcecategory_ProcessSession](#BKMK_msdyn_requirementresourcecategory_ProcessSession)
- [msdyn_requirementresourcepreference_ProcessSession](#BKMK_msdyn_requirementresourcepreference_ProcessSession)
- [msdyn_requirementstatus_ProcessSession](#BKMK_msdyn_requirementstatus_ProcessSession)
- [msdyn_resourcerequirement_ProcessSession](#BKMK_msdyn_resourcerequirement_ProcessSession)
- [msdyn_resourcerequirementdetail_ProcessSession](#BKMK_msdyn_resourcerequirementdetail_ProcessSession)
- [msdyn_resourceterritory_ProcessSession](#BKMK_msdyn_resourceterritory_ProcessSession)
- [msdyn_scenario_ProcessSession](#BKMK_msdyn_scenario_ProcessSession)
- [msdyn_scheduleboardsetting_ProcessSession](#BKMK_msdyn_scheduleboardsetting_ProcessSession)
- [msdyn_schedulingfeatureflag_ProcessSession](#BKMK_msdyn_schedulingfeatureflag_ProcessSession)
- [msdyn_schedulingparameter_ProcessSession](#BKMK_msdyn_schedulingparameter_ProcessSession)
- [msdyn_schedulingscope_ProcessSession](#BKMK_msdyn_schedulingscope_ProcessSession)
- [msdyn_smsengagementctx_ProcessSession](#BKMK_msdyn_smsengagementctx_ProcessSession)
- [msdyn_smsnumber_ProcessSession](#BKMK_msdyn_smsnumber_ProcessSession)
- [msdyn_surveyquestion_ProcessSession](#BKMK_msdyn_surveyquestion_ProcessSession)
- [msdyn_systemuserschedulersetting_ProcessSession](#BKMK_msdyn_systemuserschedulersetting_ProcessSession)
- [msdyn_teamschannelengagementctx_ProcessSession](#BKMK_msdyn_teamschannelengagementctx_ProcessSession)
- [msdyn_timegroup_ProcessSession](#BKMK_msdyn_timegroup_ProcessSession)
- [msdyn_timegroupdetail_ProcessSession](#BKMK_msdyn_timegroupdetail_ProcessSession)
- [msdyn_transactionorigin_ProcessSession](#BKMK_msdyn_transactionorigin_ProcessSession)
- [msdyn_twitterengagementctx_ProcessSession](#BKMK_msdyn_twitterengagementctx_ProcessSession)
- [msdyn_voicechannelorganizationsetting_ProcessSession](#BKMK_msdyn_voicechannelorganizationsetting_ProcessSession)
- [msdyn_webengagementruleset_ProcessSession](#BKMK_msdyn_webengagementruleset_ProcessSession)
- [msdyn_webengagementrulesetconfig_ProcessSession](#BKMK_msdyn_webengagementrulesetconfig_ProcessSession)
- [msdyn_webengagementrulesetrevision_ProcessSession](#BKMK_msdyn_webengagementrulesetrevision_ProcessSession)
- [msdyn_webengagementsitearea_ProcessSession](#BKMK_msdyn_webengagementsitearea_ProcessSession)
- [msdyn_wechatengagementctx_ProcessSession](#BKMK_msdyn_wechatengagementctx_ProcessSession)
- [msdyn_whatsappengagementctx_ProcessSession](#BKMK_msdyn_whatsappengagementctx_ProcessSession)
- [msdyn_workhourtemplate_ProcessSession](#BKMK_msdyn_workhourtemplate_ProcessSession)

### <a name="BKMK_msdyn_actual_ProcessSession"></a> msdyn_actual_ProcessSession

One-To-Many Relationship: [msdyn_actual msdyn_actual_ProcessSession](msdyn_actual.md#BKMK_msdyn_actual_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsbuild_ProcessSession"></a> msdyn_amsbuild_ProcessSession

One-To-Many Relationship: [msdyn_amsbuild msdyn_amsbuild_ProcessSession](msdyn_amsbuild.md#BKMK_msdyn_amsbuild_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsbuild`|
|ReferencedAttribute|`msdyn_amsbuildid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsbuild`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsmodel_ProcessSession"></a> msdyn_amsmodel_ProcessSession

One-To-Many Relationship: [msdyn_amsmodel msdyn_amsmodel_ProcessSession](msdyn_amsmodel.md#BKMK_msdyn_amsmodel_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsmodel`|
|ReferencedAttribute|`msdyn_amsmodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsprofile_ProcessSession"></a> msdyn_amsprofile_ProcessSession

One-To-Many Relationship: [msdyn_amsprofile msdyn_amsprofile_ProcessSession](msdyn_amsprofile.md#BKMK_msdyn_amsprofile_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsprofile`|
|ReferencedAttribute|`msdyn_amsprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsprofilesettings_ProcessSession"></a> msdyn_amsprofilesettings_ProcessSession

One-To-Many Relationship: [msdyn_amsprofilesettings msdyn_amsprofilesettings_ProcessSession](msdyn_amsprofilesettings.md#BKMK_msdyn_amsprofilesettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsprofilesettings`|
|ReferencedAttribute|`msdyn_amsprofilesettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsprofilesettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amstag_ProcessSession"></a> msdyn_amstag_ProcessSession

One-To-Many Relationship: [msdyn_amstag msdyn_amstag_ProcessSession](msdyn_amstag.md#BKMK_msdyn_amstag_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amstag`|
|ReferencedAttribute|`msdyn_amstagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amstag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_azurenotificationhub_ProcessSession"></a> msdyn_azurenotificationhub_ProcessSession

One-To-Many Relationship: [msdyn_azurenotificationhub msdyn_azurenotificationhub_ProcessSession](msdyn_azurenotificationhub.md#BKMK_msdyn_azurenotificationhub_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_azurenotificationhub`|
|ReferencedAttribute|`msdyn_azurenotificationhubid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_azurenotificationhub`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_ProcessSession"></a> msdyn_bookableresourceassociation_ProcessSession

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_ProcessSession](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_ProcessSession"></a> msdyn_bookingalert_ProcessSession

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_ProcessSession](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_ProcessSession"></a> msdyn_bookingalertstatus_ProcessSession

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_ProcessSession](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_ProcessSession"></a> msdyn_bookingchange_ProcessSession

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_ProcessSession](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_ProcessSession"></a> msdyn_bookingrule_ProcessSession

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_ProcessSession](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_ProcessSession"></a> msdyn_bookingsetupmetadata_ProcessSession

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_ProcessSession](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_ProcessSession"></a> msdyn_businessclosure_ProcessSession

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_ProcessSession](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channel_ProcessSession"></a> msdyn_channel_ProcessSession

One-To-Many Relationship: [msdyn_channel msdyn_channel_ProcessSession](msdyn_channel.md#BKMK_msdyn_channel_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channel`|
|ReferencedAttribute|`msdyn_channelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_channel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channelinstancesecret_ProcessSession"></a> msdyn_channelinstancesecret_ProcessSession

One-To-Many Relationship: [msdyn_channelinstancesecret msdyn_channelinstancesecret_ProcessSession](msdyn_channelinstancesecret.md#BKMK_msdyn_channelinstancesecret_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelinstancesecret`|
|ReferencedAttribute|`msdyn_channelinstancesecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_channelinstancesecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatansweroption_ProcessSession"></a> msdyn_chatansweroption_ProcessSession

One-To-Many Relationship: [msdyn_chatansweroption msdyn_chatansweroption_ProcessSession](msdyn_chatansweroption.md#BKMK_msdyn_chatansweroption_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatansweroption`|
|ReferencedAttribute|`msdyn_chatansweroptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatansweroption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatquestionnaireresponse_ProcessSession"></a> msdyn_chatquestionnaireresponse_ProcessSession

One-To-Many Relationship: [msdyn_chatquestionnaireresponse msdyn_chatquestionnaireresponse_ProcessSession](msdyn_chatquestionnaireresponse.md#BKMK_msdyn_chatquestionnaireresponse_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatquestionnaireresponse`|
|ReferencedAttribute|`msdyn_chatquestionnaireresponseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatquestionnaireresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatquestionnaireresponseitem_ProcessSession"></a> msdyn_chatquestionnaireresponseitem_ProcessSession

One-To-Many Relationship: [msdyn_chatquestionnaireresponseitem msdyn_chatquestionnaireresponseitem_ProcessSession](msdyn_chatquestionnaireresponseitem.md#BKMK_msdyn_chatquestionnaireresponseitem_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatquestionnaireresponseitem`|
|ReferencedAttribute|`msdyn_chatquestionnaireresponseitemid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatquestionnaireresponseitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatwidgetlanguage_ProcessSession"></a> msdyn_chatwidgetlanguage_ProcessSession

One-To-Many Relationship: [msdyn_chatwidgetlanguage msdyn_chatwidgetlanguage_ProcessSession](msdyn_chatwidgetlanguage.md#BKMK_msdyn_chatwidgetlanguage_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatwidgetlanguage`|
|ReferencedAttribute|`msdyn_chatwidgetlanguageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatwidgetlanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_ProcessSession"></a> msdyn_clientextension_ProcessSession

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_ProcessSession](msdyn_clientextension.md#BKMK_msdyn_clientextension_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_ProcessSession"></a> msdyn_configuration_ProcessSession

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_ProcessSession](msdyn_configuration.md#BKMK_msdyn_configuration_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customengagementctx_ProcessSession"></a> msdyn_customengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_customengagementctx msdyn_customengagementctx_ProcessSession](msdyn_customengagementctx.md#BKMK_msdyn_customengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customengagementctx`|
|ReferencedAttribute|`msdyn_customengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_facebookengagementctx_ProcessSession"></a> msdyn_facebookengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_facebookengagementctx msdyn_facebookengagementctx_ProcessSession](msdyn_facebookengagementctx.md#BKMK_msdyn_facebookengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_facebookengagementctx`|
|ReferencedAttribute|`msdyn_facebookengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_facebookengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_lineengagementctx_ProcessSession"></a> msdyn_lineengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_lineengagementctx msdyn_lineengagementctx_ProcessSession](msdyn_lineengagementctx.md#BKMK_msdyn_lineengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_lineengagementctx`|
|ReferencedAttribute|`msdyn_lineengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_lineengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatconfig_ProcessSession"></a> msdyn_livechatconfig_ProcessSession

One-To-Many Relationship: [msdyn_livechatconfig msdyn_livechatconfig_ProcessSession](msdyn_livechatconfig.md#BKMK_msdyn_livechatconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatconfig`|
|ReferencedAttribute|`msdyn_livechatconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatengagementctx_ProcessSession"></a> msdyn_livechatengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_livechatengagementctx msdyn_livechatengagementctx_ProcessSession](msdyn_livechatengagementctx.md#BKMK_msdyn_livechatengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatengagementctx`|
|ReferencedAttribute|`msdyn_livechatengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatwidgetlocation_ProcessSession"></a> msdyn_livechatwidgetlocation_ProcessSession

One-To-Many Relationship: [msdyn_livechatwidgetlocation msdyn_livechatwidgetlocation_ProcessSession](msdyn_livechatwidgetlocation.md#BKMK_msdyn_livechatwidgetlocation_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatwidgetlocation`|
|ReferencedAttribute|`msdyn_livechatwidgetlocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatwidgetlocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_localizedsurveyquestion_ProcessSession"></a> msdyn_localizedsurveyquestion_ProcessSession

One-To-Many Relationship: [msdyn_localizedsurveyquestion msdyn_localizedsurveyquestion_ProcessSession](msdyn_localizedsurveyquestion.md#BKMK_msdyn_localizedsurveyquestion_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_localizedsurveyquestion`|
|ReferencedAttribute|`msdyn_localizedsurveyquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_localizedsurveyquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplebusinessaccount_ProcessSession"></a> msdyn_ocapplebusinessaccount_ProcessSession

One-To-Many Relationship: [msdyn_ocapplebusinessaccount msdyn_ocapplebusinessaccount_ProcessSession](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_ocapplebusinessaccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplebusinessaccount`|
|ReferencedAttribute|`msdyn_ocapplebusinessaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplebusinessaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplemessagesforbusinessengagementctx_ProcessSession"></a> msdyn_ocapplemessagesforbusinessengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_ocapplemessagesforbusinessengagementctx msdyn_ocapplemessagesforbusinessengagementctx_ProcessSession](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_msdyn_ocapplemessagesforbusinessengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencedAttribute|`msdyn_ocapplemessagesforbusinessengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplemessagesforbusinessengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplepay_ProcessSession"></a> msdyn_ocapplepay_ProcessSession

One-To-Many Relationship: [msdyn_ocapplepay msdyn_ocapplepay_ProcessSession](msdyn_ocapplepay.md#BKMK_msdyn_ocapplepay_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplepay`|
|ReferencedAttribute|`msdyn_ocapplepayid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplepay`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occarrier_ProcessSession"></a> msdyn_occarrier_ProcessSession

One-To-Many Relationship: [msdyn_occarrier msdyn_occarrier_ProcessSession](msdyn_occarrier.md#BKMK_msdyn_occarrier_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occarrier`|
|ReferencedAttribute|`msdyn_occarrierid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occarrier`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_ProcessSession"></a> msdyn_occommunicationprovidersetting_ProcessSession

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_occommunicationprovidersetting_ProcessSession](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_occommunicationprovidersetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occommunicationprovidersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occommunicationprovidersettingentry_ProcessSession"></a> msdyn_occommunicationprovidersettingentry_ProcessSession

One-To-Many Relationship: [msdyn_occommunicationprovidersettingentry msdyn_occommunicationprovidersettingentry_ProcessSession](msdyn_occommunicationprovidersettingentry.md#BKMK_msdyn_occommunicationprovidersettingentry_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersettingentry`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingentryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occommunicationprovidersettingentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occustommessagingchannel_ProcessSession"></a> msdyn_occustommessagingchannel_ProcessSession

One-To-Many Relationship: [msdyn_occustommessagingchannel msdyn_occustommessagingchannel_ProcessSession](msdyn_occustommessagingchannel.md#BKMK_msdyn_occustommessagingchannel_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occustommessagingchannel`|
|ReferencedAttribute|`msdyn_occustommessagingchannelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occustommessagingchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocexternalsecuritysetting_ProcessSession"></a> msdyn_ocexternalsecuritysetting_ProcessSession

One-To-Many Relationship: [msdyn_ocexternalsecuritysetting msdyn_ocexternalsecuritysetting_ProcessSession](msdyn_ocexternalsecuritysetting.md#BKMK_msdyn_ocexternalsecuritysetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocexternalsecuritysetting`|
|ReferencedAttribute|`msdyn_ocexternalsecuritysettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocexternalsecuritysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocfbapplication_ProcessSession"></a> msdyn_ocfbapplication_ProcessSession

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_ocfbapplication_ProcessSession](msdyn_ocfbapplication.md#BKMK_msdyn_ocfbapplication_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocfbapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocfbpage_ProcessSession"></a> msdyn_ocfbpage_ProcessSession

One-To-Many Relationship: [msdyn_ocfbpage msdyn_ocfbpage_ProcessSession](msdyn_ocfbpage.md#BKMK_msdyn_ocfbpage_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbpage`|
|ReferencedAttribute|`msdyn_ocfbpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocfbpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_ProcessSession"></a> msdyn_ocgatekeeperengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_ocgatekeeperengagementctx msdyn_ocgatekeeperengagementctx_ProcessSession](msdyn_ocgatekeeperengagementctx.md#BKMK_msdyn_ocgatekeeperengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencedAttribute|`msdyn_ocgatekeeperengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgatekeeperengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession"></a> msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesagentaccount msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesagentaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagesagentaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession"></a> msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesengagementctx msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagesengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession"></a> msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagespartneraccount msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagespartneraccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagespartneraccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclinechannelconfig_ProcessSession"></a> msdyn_oclinechannelconfig_ProcessSession

One-To-Many Relationship: [msdyn_oclinechannelconfig msdyn_oclinechannelconfig_ProcessSession](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclinechannelconfig`|
|ReferencedAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_oclinechannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_ProcessSession"></a> msdyn_ocoutboundconfiguration_ProcessSession

One-To-Many Relationship: [msdyn_ocoutboundconfiguration msdyn_ocoutboundconfiguration_ProcessSession](msdyn_ocoutboundconfiguration.md#BKMK_msdyn_ocoutboundconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundconfiguration`|
|ReferencedAttribute|`msdyn_ocoutboundconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_ProcessSession"></a> msdyn_ocoutboundmessage_ProcessSession

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_ProcessSession](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonecallengagementctx_ProcessSession"></a> msdyn_ocphonecallengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_ocphonecallengagementctx msdyn_ocphonecallengagementctx_ProcessSession](msdyn_ocphonecallengagementctx.md#BKMK_msdyn_ocphonecallengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonecallengagementctx`|
|ReferencedAttribute|`msdyn_ocphonecallengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonecallengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonemusic_ProcessSession"></a> msdyn_ocphonemusic_ProcessSession

One-To-Many Relationship: [msdyn_ocphonemusic msdyn_ocphonemusic_ProcessSession](msdyn_ocphonemusic.md#BKMK_msdyn_ocphonemusic_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonemusic`|
|ReferencedAttribute|`msdyn_ocphonemusicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonemusic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonenumber_ProcessSession"></a> msdyn_ocphonenumber_ProcessSession

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_ocphonenumber_ProcessSession](msdyn_ocphonenumber.md#BKMK_msdyn_ocphonenumber_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsmschannelsetting_ProcessSession"></a> msdyn_ocsmschannelsetting_ProcessSession

One-To-Many Relationship: [msdyn_ocsmschannelsetting msdyn_ocsmschannelsetting_ProcessSession](msdyn_ocsmschannelsetting.md#BKMK_msdyn_ocsmschannelsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsmschannelsetting`|
|ReferencedAttribute|`msdyn_ocsmschannelsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsmschannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsmssettingsecret_ProcessSession"></a> msdyn_ocsmssettingsecret_ProcessSession

One-To-Many Relationship: [msdyn_ocsmssettingsecret msdyn_ocsmssettingsecret_ProcessSession](msdyn_ocsmssettingsecret.md#BKMK_msdyn_ocsmssettingsecret_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsmssettingsecret`|
|ReferencedAttribute|`msdyn_ocsmssettingsecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsmssettingsecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octeamschannelconfig_ProcessSession"></a> msdyn_octeamschannelconfig_ProcessSession

One-To-Many Relationship: [msdyn_octeamschannelconfig msdyn_octeamschannelconfig_ProcessSession](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octeamschannelconfig`|
|ReferencedAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octeamschannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterapplication_ProcessSession"></a> msdyn_octwitterapplication_ProcessSession

One-To-Many Relationship: [msdyn_octwitterapplication msdyn_octwitterapplication_ProcessSession](msdyn_octwitterapplication.md#BKMK_msdyn_octwitterapplication_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterapplication`|
|ReferencedAttribute|`msdyn_octwitterapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandle_ProcessSession"></a> msdyn_octwitterhandle_ProcessSession

One-To-Many Relationship: [msdyn_octwitterhandle msdyn_octwitterhandle_ProcessSession](msdyn_octwitterhandle.md#BKMK_msdyn_octwitterhandle_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandle`|
|ReferencedAttribute|`msdyn_octwitterhandleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandle`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandleprovisioningstatus_ProcessSession"></a> msdyn_octwitterhandleprovisioningstatus_ProcessSession

One-To-Many Relationship: [msdyn_octwitterhandleprovisioningstatus msdyn_octwitterhandleprovisioningstatus_ProcessSession](msdyn_octwitterhandleprovisioningstatus.md#BKMK_msdyn_octwitterhandleprovisioningstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandleprovisioningstatus`|
|ReferencedAttribute|`msdyn_octwitterhandleprovisioningstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandleprovisioningstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandlesecret_ProcessSession"></a> msdyn_octwitterhandlesecret_ProcessSession

One-To-Many Relationship: [msdyn_octwitterhandlesecret msdyn_octwitterhandlesecret_ProcessSession](msdyn_octwitterhandlesecret.md#BKMK_msdyn_octwitterhandlesecret_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandlesecret`|
|ReferencedAttribute|`msdyn_octwitterhandlesecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandlesecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoice_ProcessSession"></a> msdyn_ocvoice_ProcessSession

One-To-Many Relationship: [msdyn_ocvoice msdyn_ocvoice_ProcessSession](msdyn_ocvoice.md#BKMK_msdyn_ocvoice_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoice`|
|ReferencedAttribute|`msdyn_ocvoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicechannellanguagesetting_ProcessSession"></a> msdyn_ocvoicechannellanguagesetting_ProcessSession

One-To-Many Relationship: [msdyn_ocvoicechannellanguagesetting msdyn_ocvoicechannellanguagesetting_ProcessSession](msdyn_ocvoicechannellanguagesetting.md#BKMK_msdyn_ocvoicechannellanguagesetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencedAttribute|`msdyn_ocvoicechannellanguagesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicechannellanguagesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_ProcessSession"></a> msdyn_ocvoicechannelsetting_ProcessSession

One-To-Many Relationship: [msdyn_ocvoicechannelsetting msdyn_ocvoicechannelsetting_ProcessSession](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_ocvoicechannelsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannelsetting`|
|ReferencedAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicechannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_ProcessSession"></a> msdyn_ocvoicemail_ProcessSession

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_ProcessSession](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwechatchannelconfig_ProcessSession"></a> msdyn_ocwechatchannelconfig_ProcessSession

One-To-Many Relationship: [msdyn_ocwechatchannelconfig msdyn_ocwechatchannelconfig_ProcessSession](msdyn_ocwechatchannelconfig.md#BKMK_msdyn_ocwechatchannelconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwechatchannelconfig`|
|ReferencedAttribute|`msdyn_ocwechatchannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwechatchannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelaccount_ProcessSession"></a> msdyn_ocwhatsappchannelaccount_ProcessSession

One-To-Many Relationship: [msdyn_ocwhatsappchannelaccount msdyn_ocwhatsappchannelaccount_ProcessSession](msdyn_ocwhatsappchannelaccount.md#BKMK_msdyn_ocwhatsappchannelaccount_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwhatsappchannelaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelnumber_ProcessSession"></a> msdyn_ocwhatsappchannelnumber_ProcessSession

One-To-Many Relationship: [msdyn_ocwhatsappchannelnumber msdyn_ocwhatsappchannelnumber_ProcessSession](msdyn_ocwhatsappchannelnumber.md#BKMK_msdyn_ocwhatsappchannelnumber_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelnumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwhatsappchannelnumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_ProcessSession"></a> msdyn_organizationalunit_ProcessSession

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_ProcessSession](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_ProcessSession"></a> msdyn_priority_ProcessSession

One-To-Many Relationship: [msdyn_priority msdyn_priority_ProcessSession](msdyn_priority.md#BKMK_msdyn_priority_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_eng_config_characteristic_ProcessSession"></a> msdyn_proactive_eng_config_characteristic_ProcessSession

One-To-Many Relationship: [msdyn_proactive_eng_config_characteristic msdyn_proactive_eng_config_characteristic_ProcessSession](msdyn_proactive_eng_config_characteristic.md#BKMK_msdyn_proactive_eng_config_characteristic_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencedAttribute|`msdyn_proactive_eng_config_characteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_eng_config_characteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_attribute_ProcessSession"></a> msdyn_proactive_engagement_config_attribute_ProcessSession

One-To-Many Relationship: [msdyn_proactive_engagement_config_attribute msdyn_proactive_engagement_config_attribute_ProcessSession](msdyn_proactive_engagement_config_attribute.md#BKMK_msdyn_proactive_engagement_config_attribute_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config_attribute`|
|ReferencedAttribute|`msdyn_proactive_engagement_config_attributeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config_attribute`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_ProcessSession"></a> msdyn_proactive_engagement_config_ProcessSession

One-To-Many Relationship: [msdyn_proactive_engagement_config msdyn_proactive_engagement_config_ProcessSession](msdyn_proactive_engagement_config.md#BKMK_msdyn_proactive_engagement_config_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config`|
|ReferencedAttribute|`msdyn_proactive_engagement_configid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_status_ProcessSession"></a> msdyn_proactive_engagement_config_status_ProcessSession

One-To-Many Relationship: [msdyn_proactive_engagement_config_status msdyn_proactive_engagement_config_status_ProcessSession](msdyn_proactive_engagement_config_status.md#BKMK_msdyn_proactive_engagement_config_status_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config_status`|
|ReferencedAttribute|`msdyn_proactive_engagement_config_statusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config_status`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_questionsequence_ProcessSession"></a> msdyn_questionsequence_ProcessSession

One-To-Many Relationship: [msdyn_questionsequence msdyn_questionsequence_ProcessSession](msdyn_questionsequence.md#BKMK_msdyn_questionsequence_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_questionsequence`|
|ReferencedAttribute|`msdyn_questionsequenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_questionsequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_ProcessSession"></a> msdyn_requirementchange_ProcessSession

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_ProcessSession](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_ProcessSession"></a> msdyn_requirementcharacteristic_ProcessSession

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_ProcessSession](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_ProcessSession"></a> msdyn_requirementdependency_ProcessSession

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_ProcessSession](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_ProcessSession"></a> msdyn_requirementgroup_ProcessSession

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_ProcessSession](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_ProcessSession"></a> msdyn_requirementorganizationunit_ProcessSession

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_ProcessSession](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_ProcessSession"></a> msdyn_requirementrelationship_ProcessSession

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_ProcessSession](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_ProcessSession"></a> msdyn_requirementresourcecategory_ProcessSession

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_ProcessSession](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_ProcessSession"></a> msdyn_requirementresourcepreference_ProcessSession

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_ProcessSession](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_ProcessSession"></a> msdyn_requirementstatus_ProcessSession

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_ProcessSession](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_ProcessSession"></a> msdyn_resourcerequirement_ProcessSession

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_ProcessSession](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_ProcessSession"></a> msdyn_resourcerequirementdetail_ProcessSession

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_ProcessSession](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_ProcessSession"></a> msdyn_resourceterritory_ProcessSession

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_ProcessSession](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scenario_ProcessSession"></a> msdyn_scenario_ProcessSession

One-To-Many Relationship: [msdyn_scenario msdyn_scenario_ProcessSession](msdyn_scenario.md#BKMK_msdyn_scenario_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scenario`|
|ReferencedAttribute|`msdyn_scenarioid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scenario`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_ProcessSession"></a> msdyn_scheduleboardsetting_ProcessSession

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_ProcessSession](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_ProcessSession"></a> msdyn_schedulingfeatureflag_ProcessSession

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_ProcessSession](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_ProcessSession"></a> msdyn_schedulingparameter_ProcessSession

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_ProcessSession](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_ProcessSession"></a> msdyn_schedulingscope_ProcessSession

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_ProcessSession](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_smsengagementctx_ProcessSession"></a> msdyn_smsengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_smsengagementctx msdyn_smsengagementctx_ProcessSession](msdyn_smsengagementctx.md#BKMK_msdyn_smsengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_smsengagementctx`|
|ReferencedAttribute|`msdyn_smsengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_smsengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_smsnumber_ProcessSession"></a> msdyn_smsnumber_ProcessSession

One-To-Many Relationship: [msdyn_smsnumber msdyn_smsnumber_ProcessSession](msdyn_smsnumber.md#BKMK_msdyn_smsnumber_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_smsnumber`|
|ReferencedAttribute|`msdyn_smsnumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_smsnumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_surveyquestion_ProcessSession"></a> msdyn_surveyquestion_ProcessSession

One-To-Many Relationship: [msdyn_surveyquestion msdyn_surveyquestion_ProcessSession](msdyn_surveyquestion.md#BKMK_msdyn_surveyquestion_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_surveyquestion`|
|ReferencedAttribute|`msdyn_surveyquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_surveyquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_ProcessSession"></a> msdyn_systemuserschedulersetting_ProcessSession

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_ProcessSession](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_teamschannelengagementctx_ProcessSession"></a> msdyn_teamschannelengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_teamschannelengagementctx msdyn_teamschannelengagementctx_ProcessSession](msdyn_teamschannelengagementctx.md#BKMK_msdyn_teamschannelengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_teamschannelengagementctx`|
|ReferencedAttribute|`msdyn_teamschannelengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_teamschannelengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_ProcessSession"></a> msdyn_timegroup_ProcessSession

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_ProcessSession](msdyn_timegroup.md#BKMK_msdyn_timegroup_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_ProcessSession"></a> msdyn_timegroupdetail_ProcessSession

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_ProcessSession](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_ProcessSession"></a> msdyn_transactionorigin_ProcessSession

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_ProcessSession](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_twitterengagementctx_ProcessSession"></a> msdyn_twitterengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_twitterengagementctx msdyn_twitterengagementctx_ProcessSession](msdyn_twitterengagementctx.md#BKMK_msdyn_twitterengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_twitterengagementctx`|
|ReferencedAttribute|`msdyn_twitterengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_twitterengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_ProcessSession"></a> msdyn_voicechannelorganizationsetting_ProcessSession

One-To-Many Relationship: [msdyn_voicechannelorganizationsetting msdyn_voicechannelorganizationsetting_ProcessSession](msdyn_voicechannelorganizationsetting.md#BKMK_msdyn_voicechannelorganizationsetting_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_voicechannelorganizationsetting`|
|ReferencedAttribute|`msdyn_voicechannelorganizationsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_voicechannelorganizationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementruleset_ProcessSession"></a> msdyn_webengagementruleset_ProcessSession

One-To-Many Relationship: [msdyn_webengagementruleset msdyn_webengagementruleset_ProcessSession](msdyn_webengagementruleset.md#BKMK_msdyn_webengagementruleset_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementruleset`|
|ReferencedAttribute|`msdyn_webengagementrulesetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementruleset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementrulesetconfig_ProcessSession"></a> msdyn_webengagementrulesetconfig_ProcessSession

One-To-Many Relationship: [msdyn_webengagementrulesetconfig msdyn_webengagementrulesetconfig_ProcessSession](msdyn_webengagementrulesetconfig.md#BKMK_msdyn_webengagementrulesetconfig_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementrulesetconfig`|
|ReferencedAttribute|`msdyn_webengagementrulesetconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementrulesetconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementrulesetrevision_ProcessSession"></a> msdyn_webengagementrulesetrevision_ProcessSession

One-To-Many Relationship: [msdyn_webengagementrulesetrevision msdyn_webengagementrulesetrevision_ProcessSession](msdyn_webengagementrulesetrevision.md#BKMK_msdyn_webengagementrulesetrevision_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementrulesetrevision`|
|ReferencedAttribute|`msdyn_webengagementrulesetrevisionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementrulesetrevision`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementsitearea_ProcessSession"></a> msdyn_webengagementsitearea_ProcessSession

One-To-Many Relationship: [msdyn_webengagementsitearea msdyn_webengagementsitearea_ProcessSession](msdyn_webengagementsitearea.md#BKMK_msdyn_webengagementsitearea_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementsitearea`|
|ReferencedAttribute|`msdyn_webengagementsiteareaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementsitearea`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_wechatengagementctx_ProcessSession"></a> msdyn_wechatengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_wechatengagementctx msdyn_wechatengagementctx_ProcessSession](msdyn_wechatengagementctx.md#BKMK_msdyn_wechatengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_wechatengagementctx`|
|ReferencedAttribute|`msdyn_wechatengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_wechatengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_whatsappengagementctx_ProcessSession"></a> msdyn_whatsappengagementctx_ProcessSession

One-To-Many Relationship: [msdyn_whatsappengagementctx msdyn_whatsappengagementctx_ProcessSession](msdyn_whatsappengagementctx.md#BKMK_msdyn_whatsappengagementctx_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_whatsappengagementctx`|
|ReferencedAttribute|`msdyn_whatsappengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_whatsappengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_ProcessSession"></a> msdyn_workhourtemplate_ProcessSession

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_ProcessSession](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.processsession?displayProperty=fullName>
