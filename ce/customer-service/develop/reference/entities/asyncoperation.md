---
title: "System Job (AsyncOperation) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the System Job (AsyncOperation) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# System Job (AsyncOperation) table/entity reference (Microsoft Dynamics 365 Customer Service)

Process whose execution can proceed independently or in the background.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service System Job (AsyncOperation) table extends the [Microsoft Dynamics 365 System Job (AsyncOperation) table](/dynamics365/developer/reference/entities/asyncoperation).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/asyncoperation#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_amsbuild, msdyn_amsmodel, msdyn_amsprofile, msdyn_amsprofilesettings, msdyn_amstag, msdyn_azurenotificationhub, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_channel, msdyn_channelinstancesecret, msdyn_chatansweroption, msdyn_chatquestionnaireresponse, msdyn_chatquestionnaireresponseitem, msdyn_chatwidgetlanguage, msdyn_clientextension, msdyn_configuration, msdyn_customengagementctx, msdyn_facebookengagementctx, msdyn_lineengagementctx, msdyn_livechatconfig, msdyn_livechatengagementctx, msdyn_livechatwidgetlocation, msdyn_localizedsurveyquestion, msdyn_ocapplebusinessaccount, msdyn_ocapplemessagesforbusinessengagementctx, msdyn_ocapplepay, msdyn_occarrier, msdyn_occommunicationprovidersetting, msdyn_occommunicationprovidersettingentry, msdyn_occustommessagingchannel, msdyn_occustomneuralvoice, msdyn_ocexternalsecuritysetting, msdyn_ocfbapplication, msdyn_ocfbpage, msdyn_ocgatekeeperengagementctx, msdyn_ocgooglebusinessmessagesagentaccount, msdyn_ocgooglebusinessmessagesengagementctx, msdyn_ocgooglebusinessmessagespartneraccount, msdyn_oclinechannelconfig, msdyn_ocoutboundconfiguration, msdyn_ocoutboundmessage, msdyn_ocphonecallengagementctx, msdyn_ocphonemusic, msdyn_ocphonenumber, msdyn_ocsmschannelsetting, msdyn_ocsmssettingsecret, msdyn_octeamschannelconfig, msdyn_octwitterapplication, msdyn_octwitterhandle, msdyn_octwitterhandleprovisioningstatus, msdyn_octwitterhandlesecret, msdyn_ocvoice, msdyn_ocvoicechannellanguagesetting, msdyn_ocvoicechannelsetting, msdyn_ocvoicemail, msdyn_ocwechatchannelconfig, msdyn_ocwhatsappchannelaccount, msdyn_ocwhatsappchannelnumber, msdyn_organizationalunit, msdyn_priority, msdyn_proactive_delivery_batch, msdyn_proactive_eng_config_characteristic, msdyn_proactive_engagement_config, msdyn_proactive_engagement_config_attribute, msdyn_proactive_engagement_config_status, msdyn_proactive_engagement_message_template, msdyn_proactive_engagement_planner_config, msdyn_questionsequence, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scenario, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_smsengagementctx, msdyn_smsnumber, msdyn_surveyquestion, msdyn_systemuserschedulersetting, msdyn_teamschannelengagementctx, msdyn_teamsengagementctx, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_twitterengagementctx, msdyn_voicechannelorganizationsetting, msdyn_webengagementruleset, msdyn_webengagementrulesetconfig, msdyn_webengagementrulesetrevision, msdyn_webengagementsitearea, msdyn_wechatengagementctx, msdyn_whatsappengagementctx, msdyn_workhourtemplate, msdyn_workstreamhmmigrationstatus|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_AsyncOperations](#BKMK_msdyn_actual_AsyncOperations)
- [msdyn_amsbuild_AsyncOperations](#BKMK_msdyn_amsbuild_AsyncOperations)
- [msdyn_amsmodel_AsyncOperations](#BKMK_msdyn_amsmodel_AsyncOperations)
- [msdyn_amsprofile_AsyncOperations](#BKMK_msdyn_amsprofile_AsyncOperations)
- [msdyn_amsprofilesettings_AsyncOperations](#BKMK_msdyn_amsprofilesettings_AsyncOperations)
- [msdyn_amstag_AsyncOperations](#BKMK_msdyn_amstag_AsyncOperations)
- [msdyn_azurenotificationhub_AsyncOperations](#BKMK_msdyn_azurenotificationhub_AsyncOperations)
- [msdyn_bookableresourceassociation_AsyncOperations](#BKMK_msdyn_bookableresourceassociation_AsyncOperations)
- [msdyn_bookingalert_AsyncOperations](#BKMK_msdyn_bookingalert_AsyncOperations)
- [msdyn_bookingalertstatus_AsyncOperations](#BKMK_msdyn_bookingalertstatus_AsyncOperations)
- [msdyn_bookingchange_AsyncOperations](#BKMK_msdyn_bookingchange_AsyncOperations)
- [msdyn_bookingrule_AsyncOperations](#BKMK_msdyn_bookingrule_AsyncOperations)
- [msdyn_bookingsetupmetadata_AsyncOperations](#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)
- [msdyn_businessclosure_AsyncOperations](#BKMK_msdyn_businessclosure_AsyncOperations)
- [msdyn_channel_AsyncOperations](#BKMK_msdyn_channel_AsyncOperations)
- [msdyn_channelinstancesecret_AsyncOperations](#BKMK_msdyn_channelinstancesecret_AsyncOperations)
- [msdyn_chatansweroption_AsyncOperations](#BKMK_msdyn_chatansweroption_AsyncOperations)
- [msdyn_chatquestionnaireresponse_AsyncOperations](#BKMK_msdyn_chatquestionnaireresponse_AsyncOperations)
- [msdyn_chatquestionnaireresponseitem_AsyncOperations](#BKMK_msdyn_chatquestionnaireresponseitem_AsyncOperations)
- [msdyn_chatwidgetlanguage_AsyncOperations](#BKMK_msdyn_chatwidgetlanguage_AsyncOperations)
- [msdyn_clientextension_AsyncOperations](#BKMK_msdyn_clientextension_AsyncOperations)
- [msdyn_configuration_AsyncOperations](#BKMK_msdyn_configuration_AsyncOperations)
- [msdyn_customengagementctx_AsyncOperations](#BKMK_msdyn_customengagementctx_AsyncOperations)
- [msdyn_facebookengagementctx_AsyncOperations](#BKMK_msdyn_facebookengagementctx_AsyncOperations)
- [msdyn_lineengagementctx_AsyncOperations](#BKMK_msdyn_lineengagementctx_AsyncOperations)
- [msdyn_livechatconfig_AsyncOperations](#BKMK_msdyn_livechatconfig_AsyncOperations)
- [msdyn_livechatengagementctx_AsyncOperations](#BKMK_msdyn_livechatengagementctx_AsyncOperations)
- [msdyn_livechatwidgetlocation_AsyncOperations](#BKMK_msdyn_livechatwidgetlocation_AsyncOperations)
- [msdyn_localizedsurveyquestion_AsyncOperations](#BKMK_msdyn_localizedsurveyquestion_AsyncOperations)
- [msdyn_ocapplebusinessaccount_AsyncOperations](#BKMK_msdyn_ocapplebusinessaccount_AsyncOperations)
- [msdyn_ocapplemessagesforbusinessengagementctx_AsyncOperations](#BKMK_msdyn_ocapplemessagesforbusinessengagementctx_AsyncOperations)
- [msdyn_ocapplepay_AsyncOperations](#BKMK_msdyn_ocapplepay_AsyncOperations)
- [msdyn_occarrier_AsyncOperations](#BKMK_msdyn_occarrier_AsyncOperations)
- [msdyn_occommunicationprovidersetting_AsyncOperations](#BKMK_msdyn_occommunicationprovidersetting_AsyncOperations)
- [msdyn_occommunicationprovidersettingentry_AsyncOperations](#BKMK_msdyn_occommunicationprovidersettingentry_AsyncOperations)
- [msdyn_occustommessagingchannel_AsyncOperations](#BKMK_msdyn_occustommessagingchannel_AsyncOperations)
- [msdyn_occustomneuralvoice_AsyncOperations](#BKMK_msdyn_occustomneuralvoice_AsyncOperations)
- [msdyn_ocexternalsecuritysetting_AsyncOperations](#BKMK_msdyn_ocexternalsecuritysetting_AsyncOperations)
- [msdyn_ocfbapplication_AsyncOperations](#BKMK_msdyn_ocfbapplication_AsyncOperations)
- [msdyn_ocfbpage_AsyncOperations](#BKMK_msdyn_ocfbpage_AsyncOperations)
- [msdyn_ocgatekeeperengagementctx_AsyncOperations](#BKMK_msdyn_ocgatekeeperengagementctx_AsyncOperations)
- [msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations)
- [msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations)
- [msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations)
- [msdyn_oclinechannelconfig_AsyncOperations](#BKMK_msdyn_oclinechannelconfig_AsyncOperations)
- [msdyn_ocoutboundconfiguration_AsyncOperations](#BKMK_msdyn_ocoutboundconfiguration_AsyncOperations)
- [msdyn_ocoutboundmessage_AsyncOperations](#BKMK_msdyn_ocoutboundmessage_AsyncOperations)
- [msdyn_ocphonecallengagementctx_AsyncOperations](#BKMK_msdyn_ocphonecallengagementctx_AsyncOperations)
- [msdyn_ocphonemusic_AsyncOperations](#BKMK_msdyn_ocphonemusic_AsyncOperations)
- [msdyn_ocphonenumber_AsyncOperations](#BKMK_msdyn_ocphonenumber_AsyncOperations)
- [msdyn_ocsmschannelsetting_AsyncOperations](#BKMK_msdyn_ocsmschannelsetting_AsyncOperations)
- [msdyn_ocsmssettingsecret_AsyncOperations](#BKMK_msdyn_ocsmssettingsecret_AsyncOperations)
- [msdyn_octeamschannelconfig_AsyncOperations](#BKMK_msdyn_octeamschannelconfig_AsyncOperations)
- [msdyn_octwitterapplication_AsyncOperations](#BKMK_msdyn_octwitterapplication_AsyncOperations)
- [msdyn_octwitterhandle_AsyncOperations](#BKMK_msdyn_octwitterhandle_AsyncOperations)
- [msdyn_octwitterhandleprovisioningstatus_AsyncOperations](#BKMK_msdyn_octwitterhandleprovisioningstatus_AsyncOperations)
- [msdyn_octwitterhandlesecret_AsyncOperations](#BKMK_msdyn_octwitterhandlesecret_AsyncOperations)
- [msdyn_ocvoice_AsyncOperations](#BKMK_msdyn_ocvoice_AsyncOperations)
- [msdyn_ocvoicechannellanguagesetting_AsyncOperations](#BKMK_msdyn_ocvoicechannellanguagesetting_AsyncOperations)
- [msdyn_ocvoicechannelsetting_AsyncOperations](#BKMK_msdyn_ocvoicechannelsetting_AsyncOperations)
- [msdyn_ocvoicemail_AsyncOperations](#BKMK_msdyn_ocvoicemail_AsyncOperations)
- [msdyn_ocwechatchannelconfig_AsyncOperations](#BKMK_msdyn_ocwechatchannelconfig_AsyncOperations)
- [msdyn_ocwhatsappchannelaccount_AsyncOperations](#BKMK_msdyn_ocwhatsappchannelaccount_AsyncOperations)
- [msdyn_ocwhatsappchannelnumber_AsyncOperations](#BKMK_msdyn_ocwhatsappchannelnumber_AsyncOperations)
- [msdyn_organizationalunit_AsyncOperations](#BKMK_msdyn_organizationalunit_AsyncOperations)
- [msdyn_priority_AsyncOperations](#BKMK_msdyn_priority_AsyncOperations)
- [msdyn_proactive_delivery_batch_AsyncOperations](#BKMK_msdyn_proactive_delivery_batch_AsyncOperations)
- [msdyn_proactive_eng_config_characteristic_AsyncOperations](#BKMK_msdyn_proactive_eng_config_characteristic_AsyncOperations)
- [msdyn_proactive_engagement_config_AsyncOperations](#BKMK_msdyn_proactive_engagement_config_AsyncOperations)
- [msdyn_proactive_engagement_config_attribute_AsyncOperations](#BKMK_msdyn_proactive_engagement_config_attribute_AsyncOperations)
- [msdyn_proactive_engagement_config_status_AsyncOperations](#BKMK_msdyn_proactive_engagement_config_status_AsyncOperations)
- [msdyn_proactive_engagement_message_template_AsyncOperations](#BKMK_msdyn_proactive_engagement_message_template_AsyncOperations)
- [msdyn_proactive_engagement_planner_config_AsyncOperations](#BKMK_msdyn_proactive_engagement_planner_config_AsyncOperations)
- [msdyn_questionsequence_AsyncOperations](#BKMK_msdyn_questionsequence_AsyncOperations)
- [msdyn_requirementchange_AsyncOperations](#BKMK_msdyn_requirementchange_AsyncOperations)
- [msdyn_requirementcharacteristic_AsyncOperations](#BKMK_msdyn_requirementcharacteristic_AsyncOperations)
- [msdyn_requirementdependency_AsyncOperations](#BKMK_msdyn_requirementdependency_AsyncOperations)
- [msdyn_requirementgroup_AsyncOperations](#BKMK_msdyn_requirementgroup_AsyncOperations)
- [msdyn_requirementorganizationunit_AsyncOperations](#BKMK_msdyn_requirementorganizationunit_AsyncOperations)
- [msdyn_requirementrelationship_AsyncOperations](#BKMK_msdyn_requirementrelationship_AsyncOperations)
- [msdyn_requirementresourcecategory_AsyncOperations](#BKMK_msdyn_requirementresourcecategory_AsyncOperations)
- [msdyn_requirementresourcepreference_AsyncOperations](#BKMK_msdyn_requirementresourcepreference_AsyncOperations)
- [msdyn_requirementstatus_AsyncOperations](#BKMK_msdyn_requirementstatus_AsyncOperations)
- [msdyn_resourcerequirement_AsyncOperations](#BKMK_msdyn_resourcerequirement_AsyncOperations)
- [msdyn_resourcerequirementdetail_AsyncOperations](#BKMK_msdyn_resourcerequirementdetail_AsyncOperations)
- [msdyn_resourceterritory_AsyncOperations](#BKMK_msdyn_resourceterritory_AsyncOperations)
- [msdyn_scenario_AsyncOperations](#BKMK_msdyn_scenario_AsyncOperations)
- [msdyn_scheduleboardsetting_AsyncOperations](#BKMK_msdyn_scheduleboardsetting_AsyncOperations)
- [msdyn_schedulingfeatureflag_AsyncOperations](#BKMK_msdyn_schedulingfeatureflag_AsyncOperations)
- [msdyn_schedulingparameter_AsyncOperations](#BKMK_msdyn_schedulingparameter_AsyncOperations)
- [msdyn_schedulingscope_AsyncOperations](#BKMK_msdyn_schedulingscope_AsyncOperations)
- [msdyn_smsengagementctx_AsyncOperations](#BKMK_msdyn_smsengagementctx_AsyncOperations)
- [msdyn_smsnumber_AsyncOperations](#BKMK_msdyn_smsnumber_AsyncOperations)
- [msdyn_surveyquestion_AsyncOperations](#BKMK_msdyn_surveyquestion_AsyncOperations)
- [msdyn_systemuserschedulersetting_AsyncOperations](#BKMK_msdyn_systemuserschedulersetting_AsyncOperations)
- [msdyn_teamschannelengagementctx_AsyncOperations](#BKMK_msdyn_teamschannelengagementctx_AsyncOperations)
- [msdyn_timegroup_AsyncOperations](#BKMK_msdyn_timegroup_AsyncOperations)
- [msdyn_timegroupdetail_AsyncOperations](#BKMK_msdyn_timegroupdetail_AsyncOperations)
- [msdyn_transactionorigin_AsyncOperations](#BKMK_msdyn_transactionorigin_AsyncOperations)
- [msdyn_twitterengagementctx_AsyncOperations](#BKMK_msdyn_twitterengagementctx_AsyncOperations)
- [msdyn_voicechannelorganizationsetting_AsyncOperations](#BKMK_msdyn_voicechannelorganizationsetting_AsyncOperations)
- [msdyn_webengagementruleset_AsyncOperations](#BKMK_msdyn_webengagementruleset_AsyncOperations)
- [msdyn_webengagementrulesetconfig_AsyncOperations](#BKMK_msdyn_webengagementrulesetconfig_AsyncOperations)
- [msdyn_webengagementrulesetrevision_AsyncOperations](#BKMK_msdyn_webengagementrulesetrevision_AsyncOperations)
- [msdyn_webengagementsitearea_AsyncOperations](#BKMK_msdyn_webengagementsitearea_AsyncOperations)
- [msdyn_wechatengagementctx_AsyncOperations](#BKMK_msdyn_wechatengagementctx_AsyncOperations)
- [msdyn_whatsappengagementctx_AsyncOperations](#BKMK_msdyn_whatsappengagementctx_AsyncOperations)
- [msdyn_workhourtemplate_AsyncOperations](#BKMK_msdyn_workhourtemplate_AsyncOperations)

### <a name="BKMK_msdyn_actual_AsyncOperations"></a> msdyn_actual_AsyncOperations

One-To-Many Relationship: [msdyn_actual msdyn_actual_AsyncOperations](msdyn_actual.md#BKMK_msdyn_actual_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsbuild_AsyncOperations"></a> msdyn_amsbuild_AsyncOperations

One-To-Many Relationship: [msdyn_amsbuild msdyn_amsbuild_AsyncOperations](msdyn_amsbuild.md#BKMK_msdyn_amsbuild_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsbuild`|
|ReferencedAttribute|`msdyn_amsbuildid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsbuild`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsmodel_AsyncOperations"></a> msdyn_amsmodel_AsyncOperations

One-To-Many Relationship: [msdyn_amsmodel msdyn_amsmodel_AsyncOperations](msdyn_amsmodel.md#BKMK_msdyn_amsmodel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsmodel`|
|ReferencedAttribute|`msdyn_amsmodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsprofile_AsyncOperations"></a> msdyn_amsprofile_AsyncOperations

One-To-Many Relationship: [msdyn_amsprofile msdyn_amsprofile_AsyncOperations](msdyn_amsprofile.md#BKMK_msdyn_amsprofile_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsprofile`|
|ReferencedAttribute|`msdyn_amsprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsprofilesettings_AsyncOperations"></a> msdyn_amsprofilesettings_AsyncOperations

One-To-Many Relationship: [msdyn_amsprofilesettings msdyn_amsprofilesettings_AsyncOperations](msdyn_amsprofilesettings.md#BKMK_msdyn_amsprofilesettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsprofilesettings`|
|ReferencedAttribute|`msdyn_amsprofilesettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsprofilesettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amstag_AsyncOperations"></a> msdyn_amstag_AsyncOperations

One-To-Many Relationship: [msdyn_amstag msdyn_amstag_AsyncOperations](msdyn_amstag.md#BKMK_msdyn_amstag_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amstag`|
|ReferencedAttribute|`msdyn_amstagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amstag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_azurenotificationhub_AsyncOperations"></a> msdyn_azurenotificationhub_AsyncOperations

One-To-Many Relationship: [msdyn_azurenotificationhub msdyn_azurenotificationhub_AsyncOperations](msdyn_azurenotificationhub.md#BKMK_msdyn_azurenotificationhub_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_azurenotificationhub`|
|ReferencedAttribute|`msdyn_azurenotificationhubid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_azurenotificationhub`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_AsyncOperations"></a> msdyn_bookableresourceassociation_AsyncOperations

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_AsyncOperations](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_AsyncOperations"></a> msdyn_bookingalert_AsyncOperations

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_AsyncOperations](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_AsyncOperations"></a> msdyn_bookingalertstatus_AsyncOperations

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_AsyncOperations](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_AsyncOperations"></a> msdyn_bookingchange_AsyncOperations

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_AsyncOperations](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_AsyncOperations"></a> msdyn_bookingrule_AsyncOperations

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_AsyncOperations](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_AsyncOperations"></a> msdyn_bookingsetupmetadata_AsyncOperations

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_AsyncOperations](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_AsyncOperations"></a> msdyn_businessclosure_AsyncOperations

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_AsyncOperations](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channel_AsyncOperations"></a> msdyn_channel_AsyncOperations

One-To-Many Relationship: [msdyn_channel msdyn_channel_AsyncOperations](msdyn_channel.md#BKMK_msdyn_channel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channel`|
|ReferencedAttribute|`msdyn_channelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_channel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channelinstancesecret_AsyncOperations"></a> msdyn_channelinstancesecret_AsyncOperations

One-To-Many Relationship: [msdyn_channelinstancesecret msdyn_channelinstancesecret_AsyncOperations](msdyn_channelinstancesecret.md#BKMK_msdyn_channelinstancesecret_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelinstancesecret`|
|ReferencedAttribute|`msdyn_channelinstancesecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_channelinstancesecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatansweroption_AsyncOperations"></a> msdyn_chatansweroption_AsyncOperations

One-To-Many Relationship: [msdyn_chatansweroption msdyn_chatansweroption_AsyncOperations](msdyn_chatansweroption.md#BKMK_msdyn_chatansweroption_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatansweroption`|
|ReferencedAttribute|`msdyn_chatansweroptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatansweroption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatquestionnaireresponse_AsyncOperations"></a> msdyn_chatquestionnaireresponse_AsyncOperations

One-To-Many Relationship: [msdyn_chatquestionnaireresponse msdyn_chatquestionnaireresponse_AsyncOperations](msdyn_chatquestionnaireresponse.md#BKMK_msdyn_chatquestionnaireresponse_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatquestionnaireresponse`|
|ReferencedAttribute|`msdyn_chatquestionnaireresponseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatquestionnaireresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatquestionnaireresponseitem_AsyncOperations"></a> msdyn_chatquestionnaireresponseitem_AsyncOperations

One-To-Many Relationship: [msdyn_chatquestionnaireresponseitem msdyn_chatquestionnaireresponseitem_AsyncOperations](msdyn_chatquestionnaireresponseitem.md#BKMK_msdyn_chatquestionnaireresponseitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatquestionnaireresponseitem`|
|ReferencedAttribute|`msdyn_chatquestionnaireresponseitemid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatquestionnaireresponseitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatwidgetlanguage_AsyncOperations"></a> msdyn_chatwidgetlanguage_AsyncOperations

One-To-Many Relationship: [msdyn_chatwidgetlanguage msdyn_chatwidgetlanguage_AsyncOperations](msdyn_chatwidgetlanguage.md#BKMK_msdyn_chatwidgetlanguage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatwidgetlanguage`|
|ReferencedAttribute|`msdyn_chatwidgetlanguageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatwidgetlanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_AsyncOperations"></a> msdyn_clientextension_AsyncOperations

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_AsyncOperations](msdyn_clientextension.md#BKMK_msdyn_clientextension_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_AsyncOperations"></a> msdyn_configuration_AsyncOperations

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_AsyncOperations](msdyn_configuration.md#BKMK_msdyn_configuration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customengagementctx_AsyncOperations"></a> msdyn_customengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_customengagementctx msdyn_customengagementctx_AsyncOperations](msdyn_customengagementctx.md#BKMK_msdyn_customengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customengagementctx`|
|ReferencedAttribute|`msdyn_customengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_facebookengagementctx_AsyncOperations"></a> msdyn_facebookengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_facebookengagementctx msdyn_facebookengagementctx_AsyncOperations](msdyn_facebookengagementctx.md#BKMK_msdyn_facebookengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_facebookengagementctx`|
|ReferencedAttribute|`msdyn_facebookengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_facebookengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_lineengagementctx_AsyncOperations"></a> msdyn_lineengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_lineengagementctx msdyn_lineengagementctx_AsyncOperations](msdyn_lineengagementctx.md#BKMK_msdyn_lineengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_lineengagementctx`|
|ReferencedAttribute|`msdyn_lineengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_lineengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatconfig_AsyncOperations"></a> msdyn_livechatconfig_AsyncOperations

One-To-Many Relationship: [msdyn_livechatconfig msdyn_livechatconfig_AsyncOperations](msdyn_livechatconfig.md#BKMK_msdyn_livechatconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatconfig`|
|ReferencedAttribute|`msdyn_livechatconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatengagementctx_AsyncOperations"></a> msdyn_livechatengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_livechatengagementctx msdyn_livechatengagementctx_AsyncOperations](msdyn_livechatengagementctx.md#BKMK_msdyn_livechatengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatengagementctx`|
|ReferencedAttribute|`msdyn_livechatengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatwidgetlocation_AsyncOperations"></a> msdyn_livechatwidgetlocation_AsyncOperations

One-To-Many Relationship: [msdyn_livechatwidgetlocation msdyn_livechatwidgetlocation_AsyncOperations](msdyn_livechatwidgetlocation.md#BKMK_msdyn_livechatwidgetlocation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatwidgetlocation`|
|ReferencedAttribute|`msdyn_livechatwidgetlocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatwidgetlocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_localizedsurveyquestion_AsyncOperations"></a> msdyn_localizedsurveyquestion_AsyncOperations

One-To-Many Relationship: [msdyn_localizedsurveyquestion msdyn_localizedsurveyquestion_AsyncOperations](msdyn_localizedsurveyquestion.md#BKMK_msdyn_localizedsurveyquestion_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_localizedsurveyquestion`|
|ReferencedAttribute|`msdyn_localizedsurveyquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_localizedsurveyquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplebusinessaccount_AsyncOperations"></a> msdyn_ocapplebusinessaccount_AsyncOperations

One-To-Many Relationship: [msdyn_ocapplebusinessaccount msdyn_ocapplebusinessaccount_AsyncOperations](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_ocapplebusinessaccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplebusinessaccount`|
|ReferencedAttribute|`msdyn_ocapplebusinessaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplebusinessaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplemessagesforbusinessengagementctx_AsyncOperations"></a> msdyn_ocapplemessagesforbusinessengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_ocapplemessagesforbusinessengagementctx msdyn_ocapplemessagesforbusinessengagementctx_AsyncOperations](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_msdyn_ocapplemessagesforbusinessengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencedAttribute|`msdyn_ocapplemessagesforbusinessengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplemessagesforbusinessengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplepay_AsyncOperations"></a> msdyn_ocapplepay_AsyncOperations

One-To-Many Relationship: [msdyn_ocapplepay msdyn_ocapplepay_AsyncOperations](msdyn_ocapplepay.md#BKMK_msdyn_ocapplepay_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplepay`|
|ReferencedAttribute|`msdyn_ocapplepayid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplepay`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occarrier_AsyncOperations"></a> msdyn_occarrier_AsyncOperations

One-To-Many Relationship: [msdyn_occarrier msdyn_occarrier_AsyncOperations](msdyn_occarrier.md#BKMK_msdyn_occarrier_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occarrier`|
|ReferencedAttribute|`msdyn_occarrierid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occarrier`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_AsyncOperations"></a> msdyn_occommunicationprovidersetting_AsyncOperations

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_occommunicationprovidersetting_AsyncOperations](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_occommunicationprovidersetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occommunicationprovidersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occommunicationprovidersettingentry_AsyncOperations"></a> msdyn_occommunicationprovidersettingentry_AsyncOperations

One-To-Many Relationship: [msdyn_occommunicationprovidersettingentry msdyn_occommunicationprovidersettingentry_AsyncOperations](msdyn_occommunicationprovidersettingentry.md#BKMK_msdyn_occommunicationprovidersettingentry_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersettingentry`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingentryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occommunicationprovidersettingentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occustommessagingchannel_AsyncOperations"></a> msdyn_occustommessagingchannel_AsyncOperations

One-To-Many Relationship: [msdyn_occustommessagingchannel msdyn_occustommessagingchannel_AsyncOperations](msdyn_occustommessagingchannel.md#BKMK_msdyn_occustommessagingchannel_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occustommessagingchannel`|
|ReferencedAttribute|`msdyn_occustommessagingchannelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occustommessagingchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occustomneuralvoice_AsyncOperations"></a> msdyn_occustomneuralvoice_AsyncOperations

One-To-Many Relationship: [msdyn_occustomneuralvoice msdyn_occustomneuralvoice_AsyncOperations](msdyn_occustomneuralvoice.md#BKMK_msdyn_occustomneuralvoice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occustomneuralvoice`|
|ReferencedAttribute|`msdyn_occustomneuralvoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occustomneuralvoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocexternalsecuritysetting_AsyncOperations"></a> msdyn_ocexternalsecuritysetting_AsyncOperations

One-To-Many Relationship: [msdyn_ocexternalsecuritysetting msdyn_ocexternalsecuritysetting_AsyncOperations](msdyn_ocexternalsecuritysetting.md#BKMK_msdyn_ocexternalsecuritysetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocexternalsecuritysetting`|
|ReferencedAttribute|`msdyn_ocexternalsecuritysettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocexternalsecuritysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocfbapplication_AsyncOperations"></a> msdyn_ocfbapplication_AsyncOperations

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_ocfbapplication_AsyncOperations](msdyn_ocfbapplication.md#BKMK_msdyn_ocfbapplication_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocfbapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocfbpage_AsyncOperations"></a> msdyn_ocfbpage_AsyncOperations

One-To-Many Relationship: [msdyn_ocfbpage msdyn_ocfbpage_AsyncOperations](msdyn_ocfbpage.md#BKMK_msdyn_ocfbpage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbpage`|
|ReferencedAttribute|`msdyn_ocfbpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocfbpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_AsyncOperations"></a> msdyn_ocgatekeeperengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_ocgatekeeperengagementctx msdyn_ocgatekeeperengagementctx_AsyncOperations](msdyn_ocgatekeeperengagementctx.md#BKMK_msdyn_ocgatekeeperengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencedAttribute|`msdyn_ocgatekeeperengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgatekeeperengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations"></a> msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesagentaccount msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesagentaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagesagentaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations"></a> msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesengagementctx msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagesengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations"></a> msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagespartneraccount msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagespartneraccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagespartneraccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclinechannelconfig_AsyncOperations"></a> msdyn_oclinechannelconfig_AsyncOperations

One-To-Many Relationship: [msdyn_oclinechannelconfig msdyn_oclinechannelconfig_AsyncOperations](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclinechannelconfig`|
|ReferencedAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_oclinechannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_AsyncOperations"></a> msdyn_ocoutboundconfiguration_AsyncOperations

One-To-Many Relationship: [msdyn_ocoutboundconfiguration msdyn_ocoutboundconfiguration_AsyncOperations](msdyn_ocoutboundconfiguration.md#BKMK_msdyn_ocoutboundconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundconfiguration`|
|ReferencedAttribute|`msdyn_ocoutboundconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_AsyncOperations"></a> msdyn_ocoutboundmessage_AsyncOperations

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_AsyncOperations](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonecallengagementctx_AsyncOperations"></a> msdyn_ocphonecallengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_ocphonecallengagementctx msdyn_ocphonecallengagementctx_AsyncOperations](msdyn_ocphonecallengagementctx.md#BKMK_msdyn_ocphonecallengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonecallengagementctx`|
|ReferencedAttribute|`msdyn_ocphonecallengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonecallengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonemusic_AsyncOperations"></a> msdyn_ocphonemusic_AsyncOperations

One-To-Many Relationship: [msdyn_ocphonemusic msdyn_ocphonemusic_AsyncOperations](msdyn_ocphonemusic.md#BKMK_msdyn_ocphonemusic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonemusic`|
|ReferencedAttribute|`msdyn_ocphonemusicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonemusic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonenumber_AsyncOperations"></a> msdyn_ocphonenumber_AsyncOperations

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_ocphonenumber_AsyncOperations](msdyn_ocphonenumber.md#BKMK_msdyn_ocphonenumber_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsmschannelsetting_AsyncOperations"></a> msdyn_ocsmschannelsetting_AsyncOperations

One-To-Many Relationship: [msdyn_ocsmschannelsetting msdyn_ocsmschannelsetting_AsyncOperations](msdyn_ocsmschannelsetting.md#BKMK_msdyn_ocsmschannelsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsmschannelsetting`|
|ReferencedAttribute|`msdyn_ocsmschannelsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsmschannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsmssettingsecret_AsyncOperations"></a> msdyn_ocsmssettingsecret_AsyncOperations

One-To-Many Relationship: [msdyn_ocsmssettingsecret msdyn_ocsmssettingsecret_AsyncOperations](msdyn_ocsmssettingsecret.md#BKMK_msdyn_ocsmssettingsecret_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsmssettingsecret`|
|ReferencedAttribute|`msdyn_ocsmssettingsecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsmssettingsecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octeamschannelconfig_AsyncOperations"></a> msdyn_octeamschannelconfig_AsyncOperations

One-To-Many Relationship: [msdyn_octeamschannelconfig msdyn_octeamschannelconfig_AsyncOperations](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octeamschannelconfig`|
|ReferencedAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octeamschannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterapplication_AsyncOperations"></a> msdyn_octwitterapplication_AsyncOperations

One-To-Many Relationship: [msdyn_octwitterapplication msdyn_octwitterapplication_AsyncOperations](msdyn_octwitterapplication.md#BKMK_msdyn_octwitterapplication_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterapplication`|
|ReferencedAttribute|`msdyn_octwitterapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandle_AsyncOperations"></a> msdyn_octwitterhandle_AsyncOperations

One-To-Many Relationship: [msdyn_octwitterhandle msdyn_octwitterhandle_AsyncOperations](msdyn_octwitterhandle.md#BKMK_msdyn_octwitterhandle_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandle`|
|ReferencedAttribute|`msdyn_octwitterhandleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandle`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandleprovisioningstatus_AsyncOperations"></a> msdyn_octwitterhandleprovisioningstatus_AsyncOperations

One-To-Many Relationship: [msdyn_octwitterhandleprovisioningstatus msdyn_octwitterhandleprovisioningstatus_AsyncOperations](msdyn_octwitterhandleprovisioningstatus.md#BKMK_msdyn_octwitterhandleprovisioningstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandleprovisioningstatus`|
|ReferencedAttribute|`msdyn_octwitterhandleprovisioningstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandleprovisioningstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandlesecret_AsyncOperations"></a> msdyn_octwitterhandlesecret_AsyncOperations

One-To-Many Relationship: [msdyn_octwitterhandlesecret msdyn_octwitterhandlesecret_AsyncOperations](msdyn_octwitterhandlesecret.md#BKMK_msdyn_octwitterhandlesecret_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandlesecret`|
|ReferencedAttribute|`msdyn_octwitterhandlesecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandlesecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoice_AsyncOperations"></a> msdyn_ocvoice_AsyncOperations

One-To-Many Relationship: [msdyn_ocvoice msdyn_ocvoice_AsyncOperations](msdyn_ocvoice.md#BKMK_msdyn_ocvoice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoice`|
|ReferencedAttribute|`msdyn_ocvoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicechannellanguagesetting_AsyncOperations"></a> msdyn_ocvoicechannellanguagesetting_AsyncOperations

One-To-Many Relationship: [msdyn_ocvoicechannellanguagesetting msdyn_ocvoicechannellanguagesetting_AsyncOperations](msdyn_ocvoicechannellanguagesetting.md#BKMK_msdyn_ocvoicechannellanguagesetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencedAttribute|`msdyn_ocvoicechannellanguagesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicechannellanguagesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_AsyncOperations"></a> msdyn_ocvoicechannelsetting_AsyncOperations

One-To-Many Relationship: [msdyn_ocvoicechannelsetting msdyn_ocvoicechannelsetting_AsyncOperations](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_ocvoicechannelsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannelsetting`|
|ReferencedAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicechannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_AsyncOperations"></a> msdyn_ocvoicemail_AsyncOperations

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_AsyncOperations](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwechatchannelconfig_AsyncOperations"></a> msdyn_ocwechatchannelconfig_AsyncOperations

One-To-Many Relationship: [msdyn_ocwechatchannelconfig msdyn_ocwechatchannelconfig_AsyncOperations](msdyn_ocwechatchannelconfig.md#BKMK_msdyn_ocwechatchannelconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwechatchannelconfig`|
|ReferencedAttribute|`msdyn_ocwechatchannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwechatchannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelaccount_AsyncOperations"></a> msdyn_ocwhatsappchannelaccount_AsyncOperations

One-To-Many Relationship: [msdyn_ocwhatsappchannelaccount msdyn_ocwhatsappchannelaccount_AsyncOperations](msdyn_ocwhatsappchannelaccount.md#BKMK_msdyn_ocwhatsappchannelaccount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwhatsappchannelaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelnumber_AsyncOperations"></a> msdyn_ocwhatsappchannelnumber_AsyncOperations

One-To-Many Relationship: [msdyn_ocwhatsappchannelnumber msdyn_ocwhatsappchannelnumber_AsyncOperations](msdyn_ocwhatsappchannelnumber.md#BKMK_msdyn_ocwhatsappchannelnumber_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelnumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwhatsappchannelnumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_AsyncOperations"></a> msdyn_organizationalunit_AsyncOperations

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_AsyncOperations](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_AsyncOperations"></a> msdyn_priority_AsyncOperations

One-To-Many Relationship: [msdyn_priority msdyn_priority_AsyncOperations](msdyn_priority.md#BKMK_msdyn_priority_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_delivery_batch_AsyncOperations"></a> msdyn_proactive_delivery_batch_AsyncOperations

One-To-Many Relationship: [msdyn_proactive_delivery_batch msdyn_proactive_delivery_batch_AsyncOperations](msdyn_proactive_delivery_batch.md#BKMK_msdyn_proactive_delivery_batch_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_delivery_batch`|
|ReferencedAttribute|`msdyn_proactive_delivery_batchid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_delivery_batch`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_eng_config_characteristic_AsyncOperations"></a> msdyn_proactive_eng_config_characteristic_AsyncOperations

One-To-Many Relationship: [msdyn_proactive_eng_config_characteristic msdyn_proactive_eng_config_characteristic_AsyncOperations](msdyn_proactive_eng_config_characteristic.md#BKMK_msdyn_proactive_eng_config_characteristic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencedAttribute|`msdyn_proactive_eng_config_characteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_eng_config_characteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_AsyncOperations"></a> msdyn_proactive_engagement_config_AsyncOperations

One-To-Many Relationship: [msdyn_proactive_engagement_config msdyn_proactive_engagement_config_AsyncOperations](msdyn_proactive_engagement_config.md#BKMK_msdyn_proactive_engagement_config_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config`|
|ReferencedAttribute|`msdyn_proactive_engagement_configid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_attribute_AsyncOperations"></a> msdyn_proactive_engagement_config_attribute_AsyncOperations

One-To-Many Relationship: [msdyn_proactive_engagement_config_attribute msdyn_proactive_engagement_config_attribute_AsyncOperations](msdyn_proactive_engagement_config_attribute.md#BKMK_msdyn_proactive_engagement_config_attribute_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config_attribute`|
|ReferencedAttribute|`msdyn_proactive_engagement_config_attributeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config_attribute`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_status_AsyncOperations"></a> msdyn_proactive_engagement_config_status_AsyncOperations

One-To-Many Relationship: [msdyn_proactive_engagement_config_status msdyn_proactive_engagement_config_status_AsyncOperations](msdyn_proactive_engagement_config_status.md#BKMK_msdyn_proactive_engagement_config_status_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config_status`|
|ReferencedAttribute|`msdyn_proactive_engagement_config_statusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config_status`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_message_template_AsyncOperations"></a> msdyn_proactive_engagement_message_template_AsyncOperations

One-To-Many Relationship: [msdyn_proactive_engagement_message_template msdyn_proactive_engagement_message_template_AsyncOperations](msdyn_proactive_engagement_message_template.md#BKMK_msdyn_proactive_engagement_message_template_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_message_template`|
|ReferencedAttribute|`msdyn_proactive_engagement_message_templateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_message_template`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_AsyncOperations"></a> msdyn_proactive_engagement_planner_config_AsyncOperations

One-To-Many Relationship: [msdyn_proactive_engagement_planner_config msdyn_proactive_engagement_planner_config_AsyncOperations](msdyn_proactive_engagement_planner_config.md#BKMK_msdyn_proactive_engagement_planner_config_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_planner_config`|
|ReferencedAttribute|`msdyn_proactive_engagement_planner_configid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_planner_config`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_questionsequence_AsyncOperations"></a> msdyn_questionsequence_AsyncOperations

One-To-Many Relationship: [msdyn_questionsequence msdyn_questionsequence_AsyncOperations](msdyn_questionsequence.md#BKMK_msdyn_questionsequence_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_questionsequence`|
|ReferencedAttribute|`msdyn_questionsequenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_questionsequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_AsyncOperations"></a> msdyn_requirementchange_AsyncOperations

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_AsyncOperations](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_AsyncOperations"></a> msdyn_requirementcharacteristic_AsyncOperations

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_AsyncOperations](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_AsyncOperations"></a> msdyn_requirementdependency_AsyncOperations

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_AsyncOperations](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_AsyncOperations"></a> msdyn_requirementgroup_AsyncOperations

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_AsyncOperations](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_AsyncOperations"></a> msdyn_requirementorganizationunit_AsyncOperations

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_AsyncOperations](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_AsyncOperations"></a> msdyn_requirementrelationship_AsyncOperations

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_AsyncOperations](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_AsyncOperations"></a> msdyn_requirementresourcecategory_AsyncOperations

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_AsyncOperations](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_AsyncOperations"></a> msdyn_requirementresourcepreference_AsyncOperations

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_AsyncOperations](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_AsyncOperations"></a> msdyn_requirementstatus_AsyncOperations

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_AsyncOperations](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_AsyncOperations"></a> msdyn_resourcerequirement_AsyncOperations

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_AsyncOperations](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_AsyncOperations"></a> msdyn_resourcerequirementdetail_AsyncOperations

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_AsyncOperations](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_AsyncOperations"></a> msdyn_resourceterritory_AsyncOperations

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_AsyncOperations](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scenario_AsyncOperations"></a> msdyn_scenario_AsyncOperations

One-To-Many Relationship: [msdyn_scenario msdyn_scenario_AsyncOperations](msdyn_scenario.md#BKMK_msdyn_scenario_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scenario`|
|ReferencedAttribute|`msdyn_scenarioid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scenario`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_AsyncOperations"></a> msdyn_scheduleboardsetting_AsyncOperations

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_AsyncOperations](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_AsyncOperations"></a> msdyn_schedulingfeatureflag_AsyncOperations

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_AsyncOperations](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_AsyncOperations"></a> msdyn_schedulingparameter_AsyncOperations

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_AsyncOperations](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_AsyncOperations"></a> msdyn_schedulingscope_AsyncOperations

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_AsyncOperations](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_smsengagementctx_AsyncOperations"></a> msdyn_smsengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_smsengagementctx msdyn_smsengagementctx_AsyncOperations](msdyn_smsengagementctx.md#BKMK_msdyn_smsengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_smsengagementctx`|
|ReferencedAttribute|`msdyn_smsengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_smsengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_smsnumber_AsyncOperations"></a> msdyn_smsnumber_AsyncOperations

One-To-Many Relationship: [msdyn_smsnumber msdyn_smsnumber_AsyncOperations](msdyn_smsnumber.md#BKMK_msdyn_smsnumber_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_smsnumber`|
|ReferencedAttribute|`msdyn_smsnumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_smsnumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_surveyquestion_AsyncOperations"></a> msdyn_surveyquestion_AsyncOperations

One-To-Many Relationship: [msdyn_surveyquestion msdyn_surveyquestion_AsyncOperations](msdyn_surveyquestion.md#BKMK_msdyn_surveyquestion_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_surveyquestion`|
|ReferencedAttribute|`msdyn_surveyquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_surveyquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_AsyncOperations"></a> msdyn_systemuserschedulersetting_AsyncOperations

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_AsyncOperations](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_teamschannelengagementctx_AsyncOperations"></a> msdyn_teamschannelengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_teamschannelengagementctx msdyn_teamschannelengagementctx_AsyncOperations](msdyn_teamschannelengagementctx.md#BKMK_msdyn_teamschannelengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_teamschannelengagementctx`|
|ReferencedAttribute|`msdyn_teamschannelengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_teamschannelengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_AsyncOperations"></a> msdyn_timegroup_AsyncOperations

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_AsyncOperations](msdyn_timegroup.md#BKMK_msdyn_timegroup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_AsyncOperations"></a> msdyn_timegroupdetail_AsyncOperations

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_AsyncOperations](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_AsyncOperations"></a> msdyn_transactionorigin_AsyncOperations

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_AsyncOperations](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_twitterengagementctx_AsyncOperations"></a> msdyn_twitterengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_twitterengagementctx msdyn_twitterengagementctx_AsyncOperations](msdyn_twitterengagementctx.md#BKMK_msdyn_twitterengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_twitterengagementctx`|
|ReferencedAttribute|`msdyn_twitterengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_twitterengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_AsyncOperations"></a> msdyn_voicechannelorganizationsetting_AsyncOperations

One-To-Many Relationship: [msdyn_voicechannelorganizationsetting msdyn_voicechannelorganizationsetting_AsyncOperations](msdyn_voicechannelorganizationsetting.md#BKMK_msdyn_voicechannelorganizationsetting_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_voicechannelorganizationsetting`|
|ReferencedAttribute|`msdyn_voicechannelorganizationsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_voicechannelorganizationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementruleset_AsyncOperations"></a> msdyn_webengagementruleset_AsyncOperations

One-To-Many Relationship: [msdyn_webengagementruleset msdyn_webengagementruleset_AsyncOperations](msdyn_webengagementruleset.md#BKMK_msdyn_webengagementruleset_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementruleset`|
|ReferencedAttribute|`msdyn_webengagementrulesetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementruleset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementrulesetconfig_AsyncOperations"></a> msdyn_webengagementrulesetconfig_AsyncOperations

One-To-Many Relationship: [msdyn_webengagementrulesetconfig msdyn_webengagementrulesetconfig_AsyncOperations](msdyn_webengagementrulesetconfig.md#BKMK_msdyn_webengagementrulesetconfig_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementrulesetconfig`|
|ReferencedAttribute|`msdyn_webengagementrulesetconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementrulesetconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementrulesetrevision_AsyncOperations"></a> msdyn_webengagementrulesetrevision_AsyncOperations

One-To-Many Relationship: [msdyn_webengagementrulesetrevision msdyn_webengagementrulesetrevision_AsyncOperations](msdyn_webengagementrulesetrevision.md#BKMK_msdyn_webengagementrulesetrevision_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementrulesetrevision`|
|ReferencedAttribute|`msdyn_webengagementrulesetrevisionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementrulesetrevision`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementsitearea_AsyncOperations"></a> msdyn_webengagementsitearea_AsyncOperations

One-To-Many Relationship: [msdyn_webengagementsitearea msdyn_webengagementsitearea_AsyncOperations](msdyn_webengagementsitearea.md#BKMK_msdyn_webengagementsitearea_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementsitearea`|
|ReferencedAttribute|`msdyn_webengagementsiteareaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementsitearea`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_wechatengagementctx_AsyncOperations"></a> msdyn_wechatengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_wechatengagementctx msdyn_wechatengagementctx_AsyncOperations](msdyn_wechatengagementctx.md#BKMK_msdyn_wechatengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_wechatengagementctx`|
|ReferencedAttribute|`msdyn_wechatengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_wechatengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_whatsappengagementctx_AsyncOperations"></a> msdyn_whatsappengagementctx_AsyncOperations

One-To-Many Relationship: [msdyn_whatsappengagementctx msdyn_whatsappengagementctx_AsyncOperations](msdyn_whatsappengagementctx.md#BKMK_msdyn_whatsappengagementctx_AsyncOperations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_whatsappengagementctx`|
|ReferencedAttribute|`msdyn_whatsappengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_whatsappengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_AsyncOperations"></a> msdyn_workhourtemplate_AsyncOperations

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_AsyncOperations](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_AsyncOperations)

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
<xref:Microsoft.Dynamics.CRM.asyncoperation?displayProperty=fullName>
