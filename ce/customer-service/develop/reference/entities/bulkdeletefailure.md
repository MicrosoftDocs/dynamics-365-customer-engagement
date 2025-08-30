---
title: "Bulk Delete Failure (BulkDeleteFailure) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Bulk Delete Failure (BulkDeleteFailure) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Bulk Delete Failure (BulkDeleteFailure) table/entity reference (Microsoft Dynamics 365 Customer Service)

Record that was not deleted during a bulk deletion job.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Bulk Delete Failure (BulkDeleteFailure) table extends the [Microsoft Dynamics 365 Bulk Delete Failure (BulkDeleteFailure) table](/dynamics365/developer/reference/entities/bulkdeletefailure).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/bulkdeletefailure#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_amsbuild, msdyn_amsmodel, msdyn_amsprofile, msdyn_amsprofilesettings, msdyn_amstag, msdyn_azurenotificationhub, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_channel, msdyn_channelinstancesecret, msdyn_chatansweroption, msdyn_chatquestionnaireresponse, msdyn_chatquestionnaireresponseitem, msdyn_chatwidgetlanguage, msdyn_clientextension, msdyn_configuration, msdyn_customengagementctx, msdyn_facebookengagementctx, msdyn_lineengagementctx, msdyn_livechatconfig, msdyn_livechatengagementctx, msdyn_livechatwidgetlocation, msdyn_localizedsurveyquestion, msdyn_ocapplebusinessaccount, msdyn_ocapplemessagesforbusinessengagementctx, msdyn_ocapplepay, msdyn_occarrier, msdyn_occommunicationprovidersetting, msdyn_occommunicationprovidersettingentry, msdyn_occustommessagingchannel, msdyn_ocexternalsecuritysetting, msdyn_ocfbapplication, msdyn_ocfbpage, msdyn_ocgatekeeperengagementctx, msdyn_ocgooglebusinessmessagesagentaccount, msdyn_ocgooglebusinessmessagesengagementctx, msdyn_ocgooglebusinessmessagespartneraccount, msdyn_oclinechannelconfig, msdyn_ocoutboundconfiguration, msdyn_ocoutboundmessage, msdyn_ocphonecallengagementctx, msdyn_ocphonemusic, msdyn_ocphonenumber, msdyn_ocsmschannelsetting, msdyn_ocsmssettingsecret, msdyn_octeamschannelconfig, msdyn_octwitterapplication, msdyn_octwitterhandle, msdyn_octwitterhandleprovisioningstatus, msdyn_octwitterhandlesecret, msdyn_ocvoice, msdyn_ocvoicechannellanguagesetting, msdyn_ocvoicechannelsetting, msdyn_ocvoicemail, msdyn_ocwechatchannelconfig, msdyn_ocwhatsappchannelaccount, msdyn_ocwhatsappchannelnumber, msdyn_organizationalunit, msdyn_priority, msdyn_proactive_eng_config_characteristic, msdyn_proactive_engagement_config, msdyn_proactive_engagement_config_attribute, msdyn_proactive_engagement_config_status, msdyn_questionsequence, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scenario, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_smsengagementctx, msdyn_smsnumber, msdyn_surveyquestion, msdyn_systemuserschedulersetting, msdyn_teamschannelengagementctx, msdyn_teamsengagementctx, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_twitterengagementctx, msdyn_voicechannelorganizationsetting, msdyn_webengagementruleset, msdyn_webengagementrulesetconfig, msdyn_webengagementrulesetrevision, msdyn_webengagementsitearea, msdyn_wechatengagementctx, msdyn_whatsappengagementctx, msdyn_workhourtemplate, msdyn_workstreamhmmigrationstatus|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_BulkDeleteFailures](#BKMK_msdyn_actual_BulkDeleteFailures)
- [msdyn_amsbuild_BulkDeleteFailures](#BKMK_msdyn_amsbuild_BulkDeleteFailures)
- [msdyn_amsmodel_BulkDeleteFailures](#BKMK_msdyn_amsmodel_BulkDeleteFailures)
- [msdyn_amsprofile_BulkDeleteFailures](#BKMK_msdyn_amsprofile_BulkDeleteFailures)
- [msdyn_amsprofilesettings_BulkDeleteFailures](#BKMK_msdyn_amsprofilesettings_BulkDeleteFailures)
- [msdyn_amstag_BulkDeleteFailures](#BKMK_msdyn_amstag_BulkDeleteFailures)
- [msdyn_azurenotificationhub_BulkDeleteFailures](#BKMK_msdyn_azurenotificationhub_BulkDeleteFailures)
- [msdyn_bookableresourceassociation_BulkDeleteFailures](#BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures)
- [msdyn_bookingalert_BulkDeleteFailures](#BKMK_msdyn_bookingalert_BulkDeleteFailures)
- [msdyn_bookingalertstatus_BulkDeleteFailures](#BKMK_msdyn_bookingalertstatus_BulkDeleteFailures)
- [msdyn_bookingchange_BulkDeleteFailures](#BKMK_msdyn_bookingchange_BulkDeleteFailures)
- [msdyn_bookingrule_BulkDeleteFailures](#BKMK_msdyn_bookingrule_BulkDeleteFailures)
- [msdyn_bookingsetupmetadata_BulkDeleteFailures](#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)
- [msdyn_businessclosure_BulkDeleteFailures](#BKMK_msdyn_businessclosure_BulkDeleteFailures)
- [msdyn_channel_BulkDeleteFailures](#BKMK_msdyn_channel_BulkDeleteFailures)
- [msdyn_channelinstancesecret_BulkDeleteFailures](#BKMK_msdyn_channelinstancesecret_BulkDeleteFailures)
- [msdyn_chatansweroption_BulkDeleteFailures](#BKMK_msdyn_chatansweroption_BulkDeleteFailures)
- [msdyn_chatquestionnaireresponse_BulkDeleteFailures](#BKMK_msdyn_chatquestionnaireresponse_BulkDeleteFailures)
- [msdyn_chatquestionnaireresponseitem_BulkDeleteFailures](#BKMK_msdyn_chatquestionnaireresponseitem_BulkDeleteFailures)
- [msdyn_chatwidgetlanguage_BulkDeleteFailures](#BKMK_msdyn_chatwidgetlanguage_BulkDeleteFailures)
- [msdyn_clientextension_BulkDeleteFailures](#BKMK_msdyn_clientextension_BulkDeleteFailures)
- [msdyn_configuration_BulkDeleteFailures](#BKMK_msdyn_configuration_BulkDeleteFailures)
- [msdyn_customengagementctx_BulkDeleteFailures](#BKMK_msdyn_customengagementctx_BulkDeleteFailures)
- [msdyn_facebookengagementctx_BulkDeleteFailures](#BKMK_msdyn_facebookengagementctx_BulkDeleteFailures)
- [msdyn_lineengagementctx_BulkDeleteFailures](#BKMK_msdyn_lineengagementctx_BulkDeleteFailures)
- [msdyn_livechatconfig_BulkDeleteFailures](#BKMK_msdyn_livechatconfig_BulkDeleteFailures)
- [msdyn_livechatengagementctx_BulkDeleteFailures](#BKMK_msdyn_livechatengagementctx_BulkDeleteFailures)
- [msdyn_livechatwidgetlocation_BulkDeleteFailures](#BKMK_msdyn_livechatwidgetlocation_BulkDeleteFailures)
- [msdyn_localizedsurveyquestion_BulkDeleteFailures](#BKMK_msdyn_localizedsurveyquestion_BulkDeleteFailures)
- [msdyn_ocapplebusinessaccount_BulkDeleteFailures](#BKMK_msdyn_ocapplebusinessaccount_BulkDeleteFailures)
- [msdyn_ocapplemessagesforbusinessengagementctx_BulkDeleteFailures](#BKMK_msdyn_ocapplemessagesforbusinessengagementctx_BulkDeleteFailures)
- [msdyn_ocapplepay_BulkDeleteFailures](#BKMK_msdyn_ocapplepay_BulkDeleteFailures)
- [msdyn_occarrier_BulkDeleteFailures](#BKMK_msdyn_occarrier_BulkDeleteFailures)
- [msdyn_occommunicationprovidersetting_BulkDeleteFailures](#BKMK_msdyn_occommunicationprovidersetting_BulkDeleteFailures)
- [msdyn_occommunicationprovidersettingentry_BulkDeleteFailures](#BKMK_msdyn_occommunicationprovidersettingentry_BulkDeleteFailures)
- [msdyn_occustommessagingchannel_BulkDeleteFailures](#BKMK_msdyn_occustommessagingchannel_BulkDeleteFailures)
- [msdyn_ocexternalsecuritysetting_BulkDeleteFailures](#BKMK_msdyn_ocexternalsecuritysetting_BulkDeleteFailures)
- [msdyn_ocfbapplication_BulkDeleteFailures](#BKMK_msdyn_ocfbapplication_BulkDeleteFailures)
- [msdyn_ocfbpage_BulkDeleteFailures](#BKMK_msdyn_ocfbpage_BulkDeleteFailures)
- [msdyn_ocgatekeeperengagementctx_BulkDeleteFailures](#BKMK_msdyn_ocgatekeeperengagementctx_BulkDeleteFailures)
- [msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures)
- [msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures)
- [msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures)
- [msdyn_oclinechannelconfig_BulkDeleteFailures](#BKMK_msdyn_oclinechannelconfig_BulkDeleteFailures)
- [msdyn_ocoutboundconfiguration_BulkDeleteFailures](#BKMK_msdyn_ocoutboundconfiguration_BulkDeleteFailures)
- [msdyn_ocoutboundmessage_BulkDeleteFailures](#BKMK_msdyn_ocoutboundmessage_BulkDeleteFailures)
- [msdyn_ocphonecallengagementctx_BulkDeleteFailures](#BKMK_msdyn_ocphonecallengagementctx_BulkDeleteFailures)
- [msdyn_ocphonemusic_BulkDeleteFailures](#BKMK_msdyn_ocphonemusic_BulkDeleteFailures)
- [msdyn_ocphonenumber_BulkDeleteFailures](#BKMK_msdyn_ocphonenumber_BulkDeleteFailures)
- [msdyn_ocsmschannelsetting_BulkDeleteFailures](#BKMK_msdyn_ocsmschannelsetting_BulkDeleteFailures)
- [msdyn_ocsmssettingsecret_BulkDeleteFailures](#BKMK_msdyn_ocsmssettingsecret_BulkDeleteFailures)
- [msdyn_octeamschannelconfig_BulkDeleteFailures](#BKMK_msdyn_octeamschannelconfig_BulkDeleteFailures)
- [msdyn_octwitterapplication_BulkDeleteFailures](#BKMK_msdyn_octwitterapplication_BulkDeleteFailures)
- [msdyn_octwitterhandle_BulkDeleteFailures](#BKMK_msdyn_octwitterhandle_BulkDeleteFailures)
- [msdyn_octwitterhandleprovisioningstatus_BulkDeleteFailures](#BKMK_msdyn_octwitterhandleprovisioningstatus_BulkDeleteFailures)
- [msdyn_octwitterhandlesecret_BulkDeleteFailures](#BKMK_msdyn_octwitterhandlesecret_BulkDeleteFailures)
- [msdyn_ocvoice_BulkDeleteFailures](#BKMK_msdyn_ocvoice_BulkDeleteFailures)
- [msdyn_ocvoicechannellanguagesetting_BulkDeleteFailures](#BKMK_msdyn_ocvoicechannellanguagesetting_BulkDeleteFailures)
- [msdyn_ocvoicechannelsetting_BulkDeleteFailures](#BKMK_msdyn_ocvoicechannelsetting_BulkDeleteFailures)
- [msdyn_ocvoicemail_BulkDeleteFailures](#BKMK_msdyn_ocvoicemail_BulkDeleteFailures)
- [msdyn_ocwechatchannelconfig_BulkDeleteFailures](#BKMK_msdyn_ocwechatchannelconfig_BulkDeleteFailures)
- [msdyn_ocwhatsappchannelaccount_BulkDeleteFailures](#BKMK_msdyn_ocwhatsappchannelaccount_BulkDeleteFailures)
- [msdyn_ocwhatsappchannelnumber_BulkDeleteFailures](#BKMK_msdyn_ocwhatsappchannelnumber_BulkDeleteFailures)
- [msdyn_organizationalunit_BulkDeleteFailures](#BKMK_msdyn_organizationalunit_BulkDeleteFailures)
- [msdyn_priority_BulkDeleteFailures](#BKMK_msdyn_priority_BulkDeleteFailures)
- [msdyn_proactive_eng_config_characteristic_BulkDeleteFailures](#BKMK_msdyn_proactive_eng_config_characteristic_BulkDeleteFailures)
- [msdyn_proactive_engagement_config_attribute_BulkDeleteFailures](#BKMK_msdyn_proactive_engagement_config_attribute_BulkDeleteFailures)
- [msdyn_proactive_engagement_config_BulkDeleteFailures](#BKMK_msdyn_proactive_engagement_config_BulkDeleteFailures)
- [msdyn_proactive_engagement_config_status_BulkDeleteFailures](#BKMK_msdyn_proactive_engagement_config_status_BulkDeleteFailures)
- [msdyn_questionsequence_BulkDeleteFailures](#BKMK_msdyn_questionsequence_BulkDeleteFailures)
- [msdyn_requirementchange_BulkDeleteFailures](#BKMK_msdyn_requirementchange_BulkDeleteFailures)
- [msdyn_requirementcharacteristic_BulkDeleteFailures](#BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures)
- [msdyn_requirementdependency_BulkDeleteFailures](#BKMK_msdyn_requirementdependency_BulkDeleteFailures)
- [msdyn_requirementgroup_BulkDeleteFailures](#BKMK_msdyn_requirementgroup_BulkDeleteFailures)
- [msdyn_requirementorganizationunit_BulkDeleteFailures](#BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures)
- [msdyn_requirementrelationship_BulkDeleteFailures](#BKMK_msdyn_requirementrelationship_BulkDeleteFailures)
- [msdyn_requirementresourcecategory_BulkDeleteFailures](#BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures)
- [msdyn_requirementresourcepreference_BulkDeleteFailures](#BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures)
- [msdyn_requirementstatus_BulkDeleteFailures](#BKMK_msdyn_requirementstatus_BulkDeleteFailures)
- [msdyn_resourcerequirement_BulkDeleteFailures](#BKMK_msdyn_resourcerequirement_BulkDeleteFailures)
- [msdyn_resourcerequirementdetail_BulkDeleteFailures](#BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures)
- [msdyn_resourceterritory_BulkDeleteFailures](#BKMK_msdyn_resourceterritory_BulkDeleteFailures)
- [msdyn_scenario_BulkDeleteFailures](#BKMK_msdyn_scenario_BulkDeleteFailures)
- [msdyn_scheduleboardsetting_BulkDeleteFailures](#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)
- [msdyn_schedulingfeatureflag_BulkDeleteFailures](#BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures)
- [msdyn_schedulingparameter_BulkDeleteFailures](#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)
- [msdyn_schedulingscope_BulkDeleteFailures](#BKMK_msdyn_schedulingscope_BulkDeleteFailures)
- [msdyn_smsengagementctx_BulkDeleteFailures](#BKMK_msdyn_smsengagementctx_BulkDeleteFailures)
- [msdyn_smsnumber_BulkDeleteFailures](#BKMK_msdyn_smsnumber_BulkDeleteFailures)
- [msdyn_surveyquestion_BulkDeleteFailures](#BKMK_msdyn_surveyquestion_BulkDeleteFailures)
- [msdyn_systemuserschedulersetting_BulkDeleteFailures](#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures)
- [msdyn_teamschannelengagementctx_BulkDeleteFailures](#BKMK_msdyn_teamschannelengagementctx_BulkDeleteFailures)
- [msdyn_timegroup_BulkDeleteFailures](#BKMK_msdyn_timegroup_BulkDeleteFailures)
- [msdyn_timegroupdetail_BulkDeleteFailures](#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)
- [msdyn_transactionorigin_BulkDeleteFailures](#BKMK_msdyn_transactionorigin_BulkDeleteFailures)
- [msdyn_twitterengagementctx_BulkDeleteFailures](#BKMK_msdyn_twitterengagementctx_BulkDeleteFailures)
- [msdyn_voicechannelorganizationsetting_BulkDeleteFailures](#BKMK_msdyn_voicechannelorganizationsetting_BulkDeleteFailures)
- [msdyn_webengagementruleset_BulkDeleteFailures](#BKMK_msdyn_webengagementruleset_BulkDeleteFailures)
- [msdyn_webengagementrulesetconfig_BulkDeleteFailures](#BKMK_msdyn_webengagementrulesetconfig_BulkDeleteFailures)
- [msdyn_webengagementrulesetrevision_BulkDeleteFailures](#BKMK_msdyn_webengagementrulesetrevision_BulkDeleteFailures)
- [msdyn_webengagementsitearea_BulkDeleteFailures](#BKMK_msdyn_webengagementsitearea_BulkDeleteFailures)
- [msdyn_wechatengagementctx_BulkDeleteFailures](#BKMK_msdyn_wechatengagementctx_BulkDeleteFailures)
- [msdyn_whatsappengagementctx_BulkDeleteFailures](#BKMK_msdyn_whatsappengagementctx_BulkDeleteFailures)
- [msdyn_workhourtemplate_BulkDeleteFailures](#BKMK_msdyn_workhourtemplate_BulkDeleteFailures)

### <a name="BKMK_msdyn_actual_BulkDeleteFailures"></a> msdyn_actual_BulkDeleteFailures

One-To-Many Relationship: [msdyn_actual msdyn_actual_BulkDeleteFailures](msdyn_actual.md#BKMK_msdyn_actual_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsbuild_BulkDeleteFailures"></a> msdyn_amsbuild_BulkDeleteFailures

One-To-Many Relationship: [msdyn_amsbuild msdyn_amsbuild_BulkDeleteFailures](msdyn_amsbuild.md#BKMK_msdyn_amsbuild_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsbuild`|
|ReferencedAttribute|`msdyn_amsbuildid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsbuild`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsmodel_BulkDeleteFailures"></a> msdyn_amsmodel_BulkDeleteFailures

One-To-Many Relationship: [msdyn_amsmodel msdyn_amsmodel_BulkDeleteFailures](msdyn_amsmodel.md#BKMK_msdyn_amsmodel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsmodel`|
|ReferencedAttribute|`msdyn_amsmodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsprofile_BulkDeleteFailures"></a> msdyn_amsprofile_BulkDeleteFailures

One-To-Many Relationship: [msdyn_amsprofile msdyn_amsprofile_BulkDeleteFailures](msdyn_amsprofile.md#BKMK_msdyn_amsprofile_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsprofile`|
|ReferencedAttribute|`msdyn_amsprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsprofilesettings_BulkDeleteFailures"></a> msdyn_amsprofilesettings_BulkDeleteFailures

One-To-Many Relationship: [msdyn_amsprofilesettings msdyn_amsprofilesettings_BulkDeleteFailures](msdyn_amsprofilesettings.md#BKMK_msdyn_amsprofilesettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsprofilesettings`|
|ReferencedAttribute|`msdyn_amsprofilesettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amsprofilesettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amstag_BulkDeleteFailures"></a> msdyn_amstag_BulkDeleteFailures

One-To-Many Relationship: [msdyn_amstag msdyn_amstag_BulkDeleteFailures](msdyn_amstag.md#BKMK_msdyn_amstag_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amstag`|
|ReferencedAttribute|`msdyn_amstagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_amstag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_azurenotificationhub_BulkDeleteFailures"></a> msdyn_azurenotificationhub_BulkDeleteFailures

One-To-Many Relationship: [msdyn_azurenotificationhub msdyn_azurenotificationhub_BulkDeleteFailures](msdyn_azurenotificationhub.md#BKMK_msdyn_azurenotificationhub_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_azurenotificationhub`|
|ReferencedAttribute|`msdyn_azurenotificationhubid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_azurenotificationhub`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures"></a> msdyn_bookableresourceassociation_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_BulkDeleteFailures](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_BulkDeleteFailures"></a> msdyn_bookingalert_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_BulkDeleteFailures](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_BulkDeleteFailures"></a> msdyn_bookingalertstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_BulkDeleteFailures](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_BulkDeleteFailures"></a> msdyn_bookingchange_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_BulkDeleteFailures](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_BulkDeleteFailures"></a> msdyn_bookingrule_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_BulkDeleteFailures](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures"></a> msdyn_bookingsetupmetadata_BulkDeleteFailures

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_BulkDeleteFailures](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_BulkDeleteFailures"></a> msdyn_businessclosure_BulkDeleteFailures

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_BulkDeleteFailures](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channel_BulkDeleteFailures"></a> msdyn_channel_BulkDeleteFailures

One-To-Many Relationship: [msdyn_channel msdyn_channel_BulkDeleteFailures](msdyn_channel.md#BKMK_msdyn_channel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channel`|
|ReferencedAttribute|`msdyn_channelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_channel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channelinstancesecret_BulkDeleteFailures"></a> msdyn_channelinstancesecret_BulkDeleteFailures

One-To-Many Relationship: [msdyn_channelinstancesecret msdyn_channelinstancesecret_BulkDeleteFailures](msdyn_channelinstancesecret.md#BKMK_msdyn_channelinstancesecret_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelinstancesecret`|
|ReferencedAttribute|`msdyn_channelinstancesecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_channelinstancesecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatansweroption_BulkDeleteFailures"></a> msdyn_chatansweroption_BulkDeleteFailures

One-To-Many Relationship: [msdyn_chatansweroption msdyn_chatansweroption_BulkDeleteFailures](msdyn_chatansweroption.md#BKMK_msdyn_chatansweroption_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatansweroption`|
|ReferencedAttribute|`msdyn_chatansweroptionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatansweroption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatquestionnaireresponse_BulkDeleteFailures"></a> msdyn_chatquestionnaireresponse_BulkDeleteFailures

One-To-Many Relationship: [msdyn_chatquestionnaireresponse msdyn_chatquestionnaireresponse_BulkDeleteFailures](msdyn_chatquestionnaireresponse.md#BKMK_msdyn_chatquestionnaireresponse_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatquestionnaireresponse`|
|ReferencedAttribute|`msdyn_chatquestionnaireresponseid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatquestionnaireresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatquestionnaireresponseitem_BulkDeleteFailures"></a> msdyn_chatquestionnaireresponseitem_BulkDeleteFailures

One-To-Many Relationship: [msdyn_chatquestionnaireresponseitem msdyn_chatquestionnaireresponseitem_BulkDeleteFailures](msdyn_chatquestionnaireresponseitem.md#BKMK_msdyn_chatquestionnaireresponseitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatquestionnaireresponseitem`|
|ReferencedAttribute|`msdyn_chatquestionnaireresponseitemid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatquestionnaireresponseitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatwidgetlanguage_BulkDeleteFailures"></a> msdyn_chatwidgetlanguage_BulkDeleteFailures

One-To-Many Relationship: [msdyn_chatwidgetlanguage msdyn_chatwidgetlanguage_BulkDeleteFailures](msdyn_chatwidgetlanguage.md#BKMK_msdyn_chatwidgetlanguage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatwidgetlanguage`|
|ReferencedAttribute|`msdyn_chatwidgetlanguageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_chatwidgetlanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_BulkDeleteFailures"></a> msdyn_clientextension_BulkDeleteFailures

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_BulkDeleteFailures](msdyn_clientextension.md#BKMK_msdyn_clientextension_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_BulkDeleteFailures"></a> msdyn_configuration_BulkDeleteFailures

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_BulkDeleteFailures](msdyn_configuration.md#BKMK_msdyn_configuration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customengagementctx_BulkDeleteFailures"></a> msdyn_customengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_customengagementctx msdyn_customengagementctx_BulkDeleteFailures](msdyn_customengagementctx.md#BKMK_msdyn_customengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customengagementctx`|
|ReferencedAttribute|`msdyn_customengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_customengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_facebookengagementctx_BulkDeleteFailures"></a> msdyn_facebookengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_facebookengagementctx msdyn_facebookengagementctx_BulkDeleteFailures](msdyn_facebookengagementctx.md#BKMK_msdyn_facebookengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_facebookengagementctx`|
|ReferencedAttribute|`msdyn_facebookengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_facebookengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_lineengagementctx_BulkDeleteFailures"></a> msdyn_lineengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_lineengagementctx msdyn_lineengagementctx_BulkDeleteFailures](msdyn_lineengagementctx.md#BKMK_msdyn_lineengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_lineengagementctx`|
|ReferencedAttribute|`msdyn_lineengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_lineengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatconfig_BulkDeleteFailures"></a> msdyn_livechatconfig_BulkDeleteFailures

One-To-Many Relationship: [msdyn_livechatconfig msdyn_livechatconfig_BulkDeleteFailures](msdyn_livechatconfig.md#BKMK_msdyn_livechatconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatconfig`|
|ReferencedAttribute|`msdyn_livechatconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatengagementctx_BulkDeleteFailures"></a> msdyn_livechatengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_livechatengagementctx msdyn_livechatengagementctx_BulkDeleteFailures](msdyn_livechatengagementctx.md#BKMK_msdyn_livechatengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatengagementctx`|
|ReferencedAttribute|`msdyn_livechatengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatwidgetlocation_BulkDeleteFailures"></a> msdyn_livechatwidgetlocation_BulkDeleteFailures

One-To-Many Relationship: [msdyn_livechatwidgetlocation msdyn_livechatwidgetlocation_BulkDeleteFailures](msdyn_livechatwidgetlocation.md#BKMK_msdyn_livechatwidgetlocation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatwidgetlocation`|
|ReferencedAttribute|`msdyn_livechatwidgetlocationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_livechatwidgetlocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_localizedsurveyquestion_BulkDeleteFailures"></a> msdyn_localizedsurveyquestion_BulkDeleteFailures

One-To-Many Relationship: [msdyn_localizedsurveyquestion msdyn_localizedsurveyquestion_BulkDeleteFailures](msdyn_localizedsurveyquestion.md#BKMK_msdyn_localizedsurveyquestion_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_localizedsurveyquestion`|
|ReferencedAttribute|`msdyn_localizedsurveyquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_localizedsurveyquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplebusinessaccount_BulkDeleteFailures"></a> msdyn_ocapplebusinessaccount_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocapplebusinessaccount msdyn_ocapplebusinessaccount_BulkDeleteFailures](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_ocapplebusinessaccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplebusinessaccount`|
|ReferencedAttribute|`msdyn_ocapplebusinessaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplebusinessaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplemessagesforbusinessengagementctx_BulkDeleteFailures"></a> msdyn_ocapplemessagesforbusinessengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocapplemessagesforbusinessengagementctx msdyn_ocapplemessagesforbusinessengagementctx_BulkDeleteFailures](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_msdyn_ocapplemessagesforbusinessengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencedAttribute|`msdyn_ocapplemessagesforbusinessengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplemessagesforbusinessengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplepay_BulkDeleteFailures"></a> msdyn_ocapplepay_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocapplepay msdyn_ocapplepay_BulkDeleteFailures](msdyn_ocapplepay.md#BKMK_msdyn_ocapplepay_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplepay`|
|ReferencedAttribute|`msdyn_ocapplepayid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocapplepay`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occarrier_BulkDeleteFailures"></a> msdyn_occarrier_BulkDeleteFailures

One-To-Many Relationship: [msdyn_occarrier msdyn_occarrier_BulkDeleteFailures](msdyn_occarrier.md#BKMK_msdyn_occarrier_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occarrier`|
|ReferencedAttribute|`msdyn_occarrierid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occarrier`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_BulkDeleteFailures"></a> msdyn_occommunicationprovidersetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_occommunicationprovidersetting_BulkDeleteFailures](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_occommunicationprovidersetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occommunicationprovidersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occommunicationprovidersettingentry_BulkDeleteFailures"></a> msdyn_occommunicationprovidersettingentry_BulkDeleteFailures

One-To-Many Relationship: [msdyn_occommunicationprovidersettingentry msdyn_occommunicationprovidersettingentry_BulkDeleteFailures](msdyn_occommunicationprovidersettingentry.md#BKMK_msdyn_occommunicationprovidersettingentry_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersettingentry`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingentryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occommunicationprovidersettingentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occustommessagingchannel_BulkDeleteFailures"></a> msdyn_occustommessagingchannel_BulkDeleteFailures

One-To-Many Relationship: [msdyn_occustommessagingchannel msdyn_occustommessagingchannel_BulkDeleteFailures](msdyn_occustommessagingchannel.md#BKMK_msdyn_occustommessagingchannel_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occustommessagingchannel`|
|ReferencedAttribute|`msdyn_occustommessagingchannelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_occustommessagingchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocexternalsecuritysetting_BulkDeleteFailures"></a> msdyn_ocexternalsecuritysetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocexternalsecuritysetting msdyn_ocexternalsecuritysetting_BulkDeleteFailures](msdyn_ocexternalsecuritysetting.md#BKMK_msdyn_ocexternalsecuritysetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocexternalsecuritysetting`|
|ReferencedAttribute|`msdyn_ocexternalsecuritysettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocexternalsecuritysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocfbapplication_BulkDeleteFailures"></a> msdyn_ocfbapplication_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_ocfbapplication_BulkDeleteFailures](msdyn_ocfbapplication.md#BKMK_msdyn_ocfbapplication_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocfbapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocfbpage_BulkDeleteFailures"></a> msdyn_ocfbpage_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocfbpage msdyn_ocfbpage_BulkDeleteFailures](msdyn_ocfbpage.md#BKMK_msdyn_ocfbpage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbpage`|
|ReferencedAttribute|`msdyn_ocfbpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocfbpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_BulkDeleteFailures"></a> msdyn_ocgatekeeperengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocgatekeeperengagementctx msdyn_ocgatekeeperengagementctx_BulkDeleteFailures](msdyn_ocgatekeeperengagementctx.md#BKMK_msdyn_ocgatekeeperengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencedAttribute|`msdyn_ocgatekeeperengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgatekeeperengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures"></a> msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesagentaccount msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesagentaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagesagentaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures"></a> msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesengagementctx msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagesengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures"></a> msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagespartneraccount msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagespartneraccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocgooglebusinessmessagespartneraccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclinechannelconfig_BulkDeleteFailures"></a> msdyn_oclinechannelconfig_BulkDeleteFailures

One-To-Many Relationship: [msdyn_oclinechannelconfig msdyn_oclinechannelconfig_BulkDeleteFailures](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclinechannelconfig`|
|ReferencedAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_oclinechannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_BulkDeleteFailures"></a> msdyn_ocoutboundconfiguration_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocoutboundconfiguration msdyn_ocoutboundconfiguration_BulkDeleteFailures](msdyn_ocoutboundconfiguration.md#BKMK_msdyn_ocoutboundconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundconfiguration`|
|ReferencedAttribute|`msdyn_ocoutboundconfigurationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_BulkDeleteFailures"></a> msdyn_ocoutboundmessage_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_BulkDeleteFailures](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonecallengagementctx_BulkDeleteFailures"></a> msdyn_ocphonecallengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocphonecallengagementctx msdyn_ocphonecallengagementctx_BulkDeleteFailures](msdyn_ocphonecallengagementctx.md#BKMK_msdyn_ocphonecallengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonecallengagementctx`|
|ReferencedAttribute|`msdyn_ocphonecallengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonecallengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonemusic_BulkDeleteFailures"></a> msdyn_ocphonemusic_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocphonemusic msdyn_ocphonemusic_BulkDeleteFailures](msdyn_ocphonemusic.md#BKMK_msdyn_ocphonemusic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonemusic`|
|ReferencedAttribute|`msdyn_ocphonemusicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonemusic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonenumber_BulkDeleteFailures"></a> msdyn_ocphonenumber_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_ocphonenumber_BulkDeleteFailures](msdyn_ocphonenumber.md#BKMK_msdyn_ocphonenumber_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocphonenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsmschannelsetting_BulkDeleteFailures"></a> msdyn_ocsmschannelsetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocsmschannelsetting msdyn_ocsmschannelsetting_BulkDeleteFailures](msdyn_ocsmschannelsetting.md#BKMK_msdyn_ocsmschannelsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsmschannelsetting`|
|ReferencedAttribute|`msdyn_ocsmschannelsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsmschannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsmssettingsecret_BulkDeleteFailures"></a> msdyn_ocsmssettingsecret_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocsmssettingsecret msdyn_ocsmssettingsecret_BulkDeleteFailures](msdyn_ocsmssettingsecret.md#BKMK_msdyn_ocsmssettingsecret_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsmssettingsecret`|
|ReferencedAttribute|`msdyn_ocsmssettingsecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsmssettingsecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octeamschannelconfig_BulkDeleteFailures"></a> msdyn_octeamschannelconfig_BulkDeleteFailures

One-To-Many Relationship: [msdyn_octeamschannelconfig msdyn_octeamschannelconfig_BulkDeleteFailures](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octeamschannelconfig`|
|ReferencedAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octeamschannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterapplication_BulkDeleteFailures"></a> msdyn_octwitterapplication_BulkDeleteFailures

One-To-Many Relationship: [msdyn_octwitterapplication msdyn_octwitterapplication_BulkDeleteFailures](msdyn_octwitterapplication.md#BKMK_msdyn_octwitterapplication_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterapplication`|
|ReferencedAttribute|`msdyn_octwitterapplicationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandle_BulkDeleteFailures"></a> msdyn_octwitterhandle_BulkDeleteFailures

One-To-Many Relationship: [msdyn_octwitterhandle msdyn_octwitterhandle_BulkDeleteFailures](msdyn_octwitterhandle.md#BKMK_msdyn_octwitterhandle_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandle`|
|ReferencedAttribute|`msdyn_octwitterhandleid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandle`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandleprovisioningstatus_BulkDeleteFailures"></a> msdyn_octwitterhandleprovisioningstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_octwitterhandleprovisioningstatus msdyn_octwitterhandleprovisioningstatus_BulkDeleteFailures](msdyn_octwitterhandleprovisioningstatus.md#BKMK_msdyn_octwitterhandleprovisioningstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandleprovisioningstatus`|
|ReferencedAttribute|`msdyn_octwitterhandleprovisioningstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandleprovisioningstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandlesecret_BulkDeleteFailures"></a> msdyn_octwitterhandlesecret_BulkDeleteFailures

One-To-Many Relationship: [msdyn_octwitterhandlesecret msdyn_octwitterhandlesecret_BulkDeleteFailures](msdyn_octwitterhandlesecret.md#BKMK_msdyn_octwitterhandlesecret_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandlesecret`|
|ReferencedAttribute|`msdyn_octwitterhandlesecretid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_octwitterhandlesecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoice_BulkDeleteFailures"></a> msdyn_ocvoice_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocvoice msdyn_ocvoice_BulkDeleteFailures](msdyn_ocvoice.md#BKMK_msdyn_ocvoice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoice`|
|ReferencedAttribute|`msdyn_ocvoiceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicechannellanguagesetting_BulkDeleteFailures"></a> msdyn_ocvoicechannellanguagesetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocvoicechannellanguagesetting msdyn_ocvoicechannellanguagesetting_BulkDeleteFailures](msdyn_ocvoicechannellanguagesetting.md#BKMK_msdyn_ocvoicechannellanguagesetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencedAttribute|`msdyn_ocvoicechannellanguagesettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicechannellanguagesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_BulkDeleteFailures"></a> msdyn_ocvoicechannelsetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocvoicechannelsetting msdyn_ocvoicechannelsetting_BulkDeleteFailures](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_ocvoicechannelsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannelsetting`|
|ReferencedAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicechannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_BulkDeleteFailures"></a> msdyn_ocvoicemail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_BulkDeleteFailures](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwechatchannelconfig_BulkDeleteFailures"></a> msdyn_ocwechatchannelconfig_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocwechatchannelconfig msdyn_ocwechatchannelconfig_BulkDeleteFailures](msdyn_ocwechatchannelconfig.md#BKMK_msdyn_ocwechatchannelconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwechatchannelconfig`|
|ReferencedAttribute|`msdyn_ocwechatchannelconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwechatchannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelaccount_BulkDeleteFailures"></a> msdyn_ocwhatsappchannelaccount_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocwhatsappchannelaccount msdyn_ocwhatsappchannelaccount_BulkDeleteFailures](msdyn_ocwhatsappchannelaccount.md#BKMK_msdyn_ocwhatsappchannelaccount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwhatsappchannelaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelnumber_BulkDeleteFailures"></a> msdyn_ocwhatsappchannelnumber_BulkDeleteFailures

One-To-Many Relationship: [msdyn_ocwhatsappchannelnumber msdyn_ocwhatsappchannelnumber_BulkDeleteFailures](msdyn_ocwhatsappchannelnumber.md#BKMK_msdyn_ocwhatsappchannelnumber_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelnumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocwhatsappchannelnumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_BulkDeleteFailures"></a> msdyn_organizationalunit_BulkDeleteFailures

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_BulkDeleteFailures](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_BulkDeleteFailures"></a> msdyn_priority_BulkDeleteFailures

One-To-Many Relationship: [msdyn_priority msdyn_priority_BulkDeleteFailures](msdyn_priority.md#BKMK_msdyn_priority_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_eng_config_characteristic_BulkDeleteFailures"></a> msdyn_proactive_eng_config_characteristic_BulkDeleteFailures

One-To-Many Relationship: [msdyn_proactive_eng_config_characteristic msdyn_proactive_eng_config_characteristic_BulkDeleteFailures](msdyn_proactive_eng_config_characteristic.md#BKMK_msdyn_proactive_eng_config_characteristic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencedAttribute|`msdyn_proactive_eng_config_characteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_eng_config_characteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_attribute_BulkDeleteFailures"></a> msdyn_proactive_engagement_config_attribute_BulkDeleteFailures

One-To-Many Relationship: [msdyn_proactive_engagement_config_attribute msdyn_proactive_engagement_config_attribute_BulkDeleteFailures](msdyn_proactive_engagement_config_attribute.md#BKMK_msdyn_proactive_engagement_config_attribute_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config_attribute`|
|ReferencedAttribute|`msdyn_proactive_engagement_config_attributeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config_attribute`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_BulkDeleteFailures"></a> msdyn_proactive_engagement_config_BulkDeleteFailures

One-To-Many Relationship: [msdyn_proactive_engagement_config msdyn_proactive_engagement_config_BulkDeleteFailures](msdyn_proactive_engagement_config.md#BKMK_msdyn_proactive_engagement_config_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config`|
|ReferencedAttribute|`msdyn_proactive_engagement_configid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_status_BulkDeleteFailures"></a> msdyn_proactive_engagement_config_status_BulkDeleteFailures

One-To-Many Relationship: [msdyn_proactive_engagement_config_status msdyn_proactive_engagement_config_status_BulkDeleteFailures](msdyn_proactive_engagement_config_status.md#BKMK_msdyn_proactive_engagement_config_status_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config_status`|
|ReferencedAttribute|`msdyn_proactive_engagement_config_statusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_proactive_engagement_config_status`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_questionsequence_BulkDeleteFailures"></a> msdyn_questionsequence_BulkDeleteFailures

One-To-Many Relationship: [msdyn_questionsequence msdyn_questionsequence_BulkDeleteFailures](msdyn_questionsequence.md#BKMK_msdyn_questionsequence_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_questionsequence`|
|ReferencedAttribute|`msdyn_questionsequenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_questionsequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_BulkDeleteFailures"></a> msdyn_requirementchange_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_BulkDeleteFailures](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures"></a> msdyn_requirementcharacteristic_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_BulkDeleteFailures](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_BulkDeleteFailures"></a> msdyn_requirementdependency_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_BulkDeleteFailures](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_BulkDeleteFailures"></a> msdyn_requirementgroup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_BulkDeleteFailures](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures"></a> msdyn_requirementorganizationunit_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_BulkDeleteFailures](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_BulkDeleteFailures"></a> msdyn_requirementrelationship_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_BulkDeleteFailures](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures"></a> msdyn_requirementresourcecategory_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_BulkDeleteFailures](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures"></a> msdyn_requirementresourcepreference_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_BulkDeleteFailures](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_BulkDeleteFailures"></a> msdyn_requirementstatus_BulkDeleteFailures

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_BulkDeleteFailures](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_BulkDeleteFailures"></a> msdyn_resourcerequirement_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_BulkDeleteFailures](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures"></a> msdyn_resourcerequirementdetail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_BulkDeleteFailures](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_BulkDeleteFailures"></a> msdyn_resourceterritory_BulkDeleteFailures

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_BulkDeleteFailures](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scenario_BulkDeleteFailures"></a> msdyn_scenario_BulkDeleteFailures

One-To-Many Relationship: [msdyn_scenario msdyn_scenario_BulkDeleteFailures](msdyn_scenario.md#BKMK_msdyn_scenario_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scenario`|
|ReferencedAttribute|`msdyn_scenarioid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scenario`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures"></a> msdyn_scheduleboardsetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_BulkDeleteFailures](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures"></a> msdyn_schedulingfeatureflag_BulkDeleteFailures

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_BulkDeleteFailures](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_BulkDeleteFailures"></a> msdyn_schedulingparameter_BulkDeleteFailures

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_BulkDeleteFailures](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_BulkDeleteFailures"></a> msdyn_schedulingscope_BulkDeleteFailures

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_BulkDeleteFailures](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_smsengagementctx_BulkDeleteFailures"></a> msdyn_smsengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_smsengagementctx msdyn_smsengagementctx_BulkDeleteFailures](msdyn_smsengagementctx.md#BKMK_msdyn_smsengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_smsengagementctx`|
|ReferencedAttribute|`msdyn_smsengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_smsengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_smsnumber_BulkDeleteFailures"></a> msdyn_smsnumber_BulkDeleteFailures

One-To-Many Relationship: [msdyn_smsnumber msdyn_smsnumber_BulkDeleteFailures](msdyn_smsnumber.md#BKMK_msdyn_smsnumber_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_smsnumber`|
|ReferencedAttribute|`msdyn_smsnumberid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_smsnumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_surveyquestion_BulkDeleteFailures"></a> msdyn_surveyquestion_BulkDeleteFailures

One-To-Many Relationship: [msdyn_surveyquestion msdyn_surveyquestion_BulkDeleteFailures](msdyn_surveyquestion.md#BKMK_msdyn_surveyquestion_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_surveyquestion`|
|ReferencedAttribute|`msdyn_surveyquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_surveyquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures"></a> msdyn_systemuserschedulersetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_BulkDeleteFailures](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_teamschannelengagementctx_BulkDeleteFailures"></a> msdyn_teamschannelengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_teamschannelengagementctx msdyn_teamschannelengagementctx_BulkDeleteFailures](msdyn_teamschannelengagementctx.md#BKMK_msdyn_teamschannelengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_teamschannelengagementctx`|
|ReferencedAttribute|`msdyn_teamschannelengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_teamschannelengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_BulkDeleteFailures"></a> msdyn_timegroup_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_BulkDeleteFailures](msdyn_timegroup.md#BKMK_msdyn_timegroup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_BulkDeleteFailures"></a> msdyn_timegroupdetail_BulkDeleteFailures

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_BulkDeleteFailures](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_BulkDeleteFailures"></a> msdyn_transactionorigin_BulkDeleteFailures

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_BulkDeleteFailures](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_twitterengagementctx_BulkDeleteFailures"></a> msdyn_twitterengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_twitterengagementctx msdyn_twitterengagementctx_BulkDeleteFailures](msdyn_twitterengagementctx.md#BKMK_msdyn_twitterengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_twitterengagementctx`|
|ReferencedAttribute|`msdyn_twitterengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_twitterengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_BulkDeleteFailures"></a> msdyn_voicechannelorganizationsetting_BulkDeleteFailures

One-To-Many Relationship: [msdyn_voicechannelorganizationsetting msdyn_voicechannelorganizationsetting_BulkDeleteFailures](msdyn_voicechannelorganizationsetting.md#BKMK_msdyn_voicechannelorganizationsetting_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_voicechannelorganizationsetting`|
|ReferencedAttribute|`msdyn_voicechannelorganizationsettingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_voicechannelorganizationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementruleset_BulkDeleteFailures"></a> msdyn_webengagementruleset_BulkDeleteFailures

One-To-Many Relationship: [msdyn_webengagementruleset msdyn_webengagementruleset_BulkDeleteFailures](msdyn_webengagementruleset.md#BKMK_msdyn_webengagementruleset_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementruleset`|
|ReferencedAttribute|`msdyn_webengagementrulesetid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementruleset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementrulesetconfig_BulkDeleteFailures"></a> msdyn_webengagementrulesetconfig_BulkDeleteFailures

One-To-Many Relationship: [msdyn_webengagementrulesetconfig msdyn_webengagementrulesetconfig_BulkDeleteFailures](msdyn_webengagementrulesetconfig.md#BKMK_msdyn_webengagementrulesetconfig_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementrulesetconfig`|
|ReferencedAttribute|`msdyn_webengagementrulesetconfigid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementrulesetconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementrulesetrevision_BulkDeleteFailures"></a> msdyn_webengagementrulesetrevision_BulkDeleteFailures

One-To-Many Relationship: [msdyn_webengagementrulesetrevision msdyn_webengagementrulesetrevision_BulkDeleteFailures](msdyn_webengagementrulesetrevision.md#BKMK_msdyn_webengagementrulesetrevision_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementrulesetrevision`|
|ReferencedAttribute|`msdyn_webengagementrulesetrevisionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementrulesetrevision`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementsitearea_BulkDeleteFailures"></a> msdyn_webengagementsitearea_BulkDeleteFailures

One-To-Many Relationship: [msdyn_webengagementsitearea msdyn_webengagementsitearea_BulkDeleteFailures](msdyn_webengagementsitearea.md#BKMK_msdyn_webengagementsitearea_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementsitearea`|
|ReferencedAttribute|`msdyn_webengagementsiteareaid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_webengagementsitearea`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_wechatengagementctx_BulkDeleteFailures"></a> msdyn_wechatengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_wechatengagementctx msdyn_wechatengagementctx_BulkDeleteFailures](msdyn_wechatengagementctx.md#BKMK_msdyn_wechatengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_wechatengagementctx`|
|ReferencedAttribute|`msdyn_wechatengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_wechatengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_whatsappengagementctx_BulkDeleteFailures"></a> msdyn_whatsappengagementctx_BulkDeleteFailures

One-To-Many Relationship: [msdyn_whatsappengagementctx msdyn_whatsappengagementctx_BulkDeleteFailures](msdyn_whatsappengagementctx.md#BKMK_msdyn_whatsappengagementctx_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_whatsappengagementctx`|
|ReferencedAttribute|`msdyn_whatsappengagementctxid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_whatsappengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_BulkDeleteFailures"></a> msdyn_workhourtemplate_BulkDeleteFailures

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_BulkDeleteFailures](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.bulkdeletefailure?displayProperty=fullName>
