---
title: "Field Sharing (PrincipalObjectAttributeAccess) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Field Sharing (PrincipalObjectAttributeAccess) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Field Sharing (PrincipalObjectAttributeAccess) table/entity reference (Microsoft Dynamics 365 Customer Service)

Defines CRM security principals (users and teams) access rights to secured field for an entity instance.

> [!NOTE]
> The Microsoft Dynamics 365 Customer Service Field Sharing (PrincipalObjectAttributeAccess) table extends the [Microsoft Dynamics 365 Field Sharing (PrincipalObjectAttributeAccess) table](/dynamics365/developer/reference/entities/principalobjectattributeaccess).



## Customized columns/attributes

Microsoft Dynamics 365 Customer Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/principalobjectattributeaccess#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|msdyn_actual, msdyn_amsbuild, msdyn_amsmodel, msdyn_amsprofile, msdyn_amsprofilesettings, msdyn_amstag, msdyn_azurenotificationhub, msdyn_bookableresourceassociation, msdyn_bookingalert, msdyn_bookingalertstatus, msdyn_bookingchange, msdyn_bookingrule, msdyn_bookingsetupmetadata, msdyn_businessclosure, msdyn_channel, msdyn_channelinstancesecret, msdyn_chatansweroption, msdyn_chatquestionnaireresponse, msdyn_chatquestionnaireresponseitem, msdyn_chatwidgetlanguage, msdyn_clientextension, msdyn_configuration, msdyn_customengagementctx, msdyn_facebookengagementctx, msdyn_lineengagementctx, msdyn_livechatconfig, msdyn_livechatengagementctx, msdyn_livechatwidgetlocation, msdyn_localizedsurveyquestion, msdyn_ocapplebusinessaccount, msdyn_ocapplemessagesforbusinessengagementctx, msdyn_ocapplepay, msdyn_occarrier, msdyn_occommunicationprovidersetting, msdyn_occommunicationprovidersettingentry, msdyn_occustommessagingchannel, msdyn_occustomneuralvoice, msdyn_ocexternalsecuritysetting, msdyn_ocfbapplication, msdyn_ocfbpage, msdyn_ocgatekeeperengagementctx, msdyn_ocgooglebusinessmessagesagentaccount, msdyn_ocgooglebusinessmessagesengagementctx, msdyn_ocgooglebusinessmessagespartneraccount, msdyn_oclinechannelconfig, msdyn_ocoutboundconfiguration, msdyn_ocoutboundmessage, msdyn_ocphonecallengagementctx, msdyn_ocphonemusic, msdyn_ocphonenumber, msdyn_ocsmschannelsetting, msdyn_ocsmssettingsecret, msdyn_octeamschannelconfig, msdyn_octwitterapplication, msdyn_octwitterhandle, msdyn_octwitterhandleprovisioningstatus, msdyn_octwitterhandlesecret, msdyn_ocvoice, msdyn_ocvoicechannellanguagesetting, msdyn_ocvoicechannelsetting, msdyn_ocvoicemail, msdyn_ocwechatchannelconfig, msdyn_ocwhatsappchannelaccount, msdyn_ocwhatsappchannelnumber, msdyn_organizationalunit, msdyn_priority, msdyn_proactive_delivery_batch, msdyn_proactive_eng_config_characteristic, msdyn_proactive_engagement_config, msdyn_proactive_engagement_config_attribute, msdyn_proactive_engagement_config_status, msdyn_proactive_engagement_message_template, msdyn_proactive_engagement_planner_config, msdyn_questionsequence, msdyn_requirementchange, msdyn_requirementcharacteristic, msdyn_requirementdependency, msdyn_requirementgroup, msdyn_requirementorganizationunit, msdyn_requirementrelationship, msdyn_requirementresourcecategory, msdyn_requirementresourcepreference, msdyn_requirementstatus, msdyn_resourcerequirement, msdyn_resourcerequirementdetail, msdyn_resourceterritory, msdyn_scenario, msdyn_scheduleboardsetting, msdyn_schedulingfeatureflag, msdyn_schedulingparameter, msdyn_schedulingscope, msdyn_smsengagementctx, msdyn_smsnumber, msdyn_surveyquestion, msdyn_systemuserschedulersetting, msdyn_teamschannelengagementctx, msdyn_teamsengagementctx, msdyn_timegroup, msdyn_timegroupdetail, msdyn_transactionorigin, msdyn_twitterengagementctx, msdyn_voicechannelorganizationsetting, msdyn_webengagementruleset, msdyn_webengagementrulesetconfig, msdyn_webengagementrulesetrevision, msdyn_webengagementsitearea, msdyn_wechatengagementctx, msdyn_whatsappengagementctx, msdyn_workhourtemplate, msdyn_workstreamhmmigrationstatus|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdyn_actual_PrincipalObjectAttributeAccesses](#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses)
- [msdyn_amsbuild_PrincipalObjectAttributeAccesses](#BKMK_msdyn_amsbuild_PrincipalObjectAttributeAccesses)
- [msdyn_amsmodel_PrincipalObjectAttributeAccesses](#BKMK_msdyn_amsmodel_PrincipalObjectAttributeAccesses)
- [msdyn_amsprofile_PrincipalObjectAttributeAccesses](#BKMK_msdyn_amsprofile_PrincipalObjectAttributeAccesses)
- [msdyn_amsprofilesettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_amsprofilesettings_PrincipalObjectAttributeAccesses)
- [msdyn_amstag_PrincipalObjectAttributeAccesses](#BKMK_msdyn_amstag_PrincipalObjectAttributeAccesses)
- [msdyn_azurenotificationhub_PrincipalObjectAttributeAccesses](#BKMK_msdyn_azurenotificationhub_PrincipalObjectAttributeAccesses)
- [msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalert_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses)
- [msdyn_bookingchange_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses)
- [msdyn_bookingrule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses)
- [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)
- [msdyn_businessclosure_PrincipalObjectAttributeAccesses](#BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses)
- [msdyn_channel_PrincipalObjectAttributeAccesses](#BKMK_msdyn_channel_PrincipalObjectAttributeAccesses)
- [msdyn_channelinstancesecret_PrincipalObjectAttributeAccesses](#BKMK_msdyn_channelinstancesecret_PrincipalObjectAttributeAccesses)
- [msdyn_chatansweroption_PrincipalObjectAttributeAccesses](#BKMK_msdyn_chatansweroption_PrincipalObjectAttributeAccesses)
- [msdyn_chatquestionnaireresponse_PrincipalObjectAttributeAccesses](#BKMK_msdyn_chatquestionnaireresponse_PrincipalObjectAttributeAccesses)
- [msdyn_chatquestionnaireresponseitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_chatquestionnaireresponseitem_PrincipalObjectAttributeAccesses)
- [msdyn_chatwidgetlanguage_PrincipalObjectAttributeAccesses](#BKMK_msdyn_chatwidgetlanguage_PrincipalObjectAttributeAccesses)
- [msdyn_clientextension_PrincipalObjectAttributeAccesses](#BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses)
- [msdyn_configuration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses)
- [msdyn_customengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_customengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_facebookengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_facebookengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_lineengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_lineengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_livechatconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_livechatconfig_PrincipalObjectAttributeAccesses)
- [msdyn_livechatengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_livechatengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_livechatwidgetlocation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_livechatwidgetlocation_PrincipalObjectAttributeAccesses)
- [msdyn_localizedsurveyquestion_PrincipalObjectAttributeAccesses](#BKMK_msdyn_localizedsurveyquestion_PrincipalObjectAttributeAccesses)
- [msdyn_ocapplebusinessaccount_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocapplebusinessaccount_PrincipalObjectAttributeAccesses)
- [msdyn_ocapplemessagesforbusinessengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocapplemessagesforbusinessengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_ocapplepay_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocapplepay_PrincipalObjectAttributeAccesses)
- [msdyn_occarrier_PrincipalObjectAttributeAccesses](#BKMK_msdyn_occarrier_PrincipalObjectAttributeAccesses)
- [msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses)
- [msdyn_occommunicationprovidersettingentry_PrincipalObjectAttributeAccesses](#BKMK_msdyn_occommunicationprovidersettingentry_PrincipalObjectAttributeAccesses)
- [msdyn_occustommessagingchannel_PrincipalObjectAttributeAccesses](#BKMK_msdyn_occustommessagingchannel_PrincipalObjectAttributeAccesses)
- [msdyn_occustomneuralvoice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_occustomneuralvoice_PrincipalObjectAttributeAccesses)
- [msdyn_ocexternalsecuritysetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocexternalsecuritysetting_PrincipalObjectAttributeAccesses)
- [msdyn_ocfbapplication_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocfbapplication_PrincipalObjectAttributeAccesses)
- [msdyn_ocfbpage_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocfbpage_PrincipalObjectAttributeAccesses)
- [msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses)
- [msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses)
- [msdyn_oclinechannelconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_oclinechannelconfig_PrincipalObjectAttributeAccesses)
- [msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses)
- [msdyn_ocphonecallengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocphonecallengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_ocphonemusic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocphonemusic_PrincipalObjectAttributeAccesses)
- [msdyn_ocphonenumber_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocphonenumber_PrincipalObjectAttributeAccesses)
- [msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses)
- [msdyn_ocsmssettingsecret_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocsmssettingsecret_PrincipalObjectAttributeAccesses)
- [msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses)
- [msdyn_octwitterapplication_PrincipalObjectAttributeAccesses](#BKMK_msdyn_octwitterapplication_PrincipalObjectAttributeAccesses)
- [msdyn_octwitterhandle_PrincipalObjectAttributeAccesses](#BKMK_msdyn_octwitterhandle_PrincipalObjectAttributeAccesses)
- [msdyn_octwitterhandleprovisioningstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_octwitterhandleprovisioningstatus_PrincipalObjectAttributeAccesses)
- [msdyn_octwitterhandlesecret_PrincipalObjectAttributeAccesses](#BKMK_msdyn_octwitterhandlesecret_PrincipalObjectAttributeAccesses)
- [msdyn_ocvoice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocvoice_PrincipalObjectAttributeAccesses)
- [msdyn_ocvoicechannellanguagesetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocvoicechannellanguagesetting_PrincipalObjectAttributeAccesses)
- [msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses)
- [msdyn_ocvoicemail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocvoicemail_PrincipalObjectAttributeAccesses)
- [msdyn_ocwechatchannelconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocwechatchannelconfig_PrincipalObjectAttributeAccesses)
- [msdyn_ocwhatsappchannelaccount_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocwhatsappchannelaccount_PrincipalObjectAttributeAccesses)
- [msdyn_ocwhatsappchannelnumber_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocwhatsappchannelnumber_PrincipalObjectAttributeAccesses)
- [msdyn_organizationalunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses)
- [msdyn_priority_PrincipalObjectAttributeAccesses](#BKMK_msdyn_priority_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_delivery_batch_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_delivery_batch_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_eng_config_characteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_eng_config_characteristic_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_engagement_config_attribute_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_engagement_config_attribute_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_engagement_config_status_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_engagement_config_status_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_engagement_message_template_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_engagement_message_template_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses)
- [msdyn_questionsequence_PrincipalObjectAttributeAccesses](#BKMK_msdyn_questionsequence_PrincipalObjectAttributeAccesses)
- [msdyn_requirementchange_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses)
- [msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_requirementdependency_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses)
- [msdyn_requirementgroup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses)
- [msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses)
- [msdyn_requirementrelationship_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses)
- [msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses)
- [msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses)
- [msdyn_requirementstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequirement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses)
- [msdyn_resourceterritory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses)
- [msdyn_scenario_PrincipalObjectAttributeAccesses](#BKMK_msdyn_scenario_PrincipalObjectAttributeAccesses)
- [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingscope_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingscope_PrincipalObjectAttributeAccesses)
- [msdyn_smsengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_smsengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_smsnumber_PrincipalObjectAttributeAccesses](#BKMK_msdyn_smsnumber_PrincipalObjectAttributeAccesses)
- [msdyn_surveyquestion_PrincipalObjectAttributeAccesses](#BKMK_msdyn_surveyquestion_PrincipalObjectAttributeAccesses)
- [msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses)
- [msdyn_teamschannelengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_teamschannelengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_timegroup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses)
- [msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)
- [msdyn_transactionorigin_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses)
- [msdyn_twitterengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_twitterengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses)
- [msdyn_webengagementruleset_PrincipalObjectAttributeAccesses](#BKMK_msdyn_webengagementruleset_PrincipalObjectAttributeAccesses)
- [msdyn_webengagementrulesetconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_webengagementrulesetconfig_PrincipalObjectAttributeAccesses)
- [msdyn_webengagementrulesetrevision_PrincipalObjectAttributeAccesses](#BKMK_msdyn_webengagementrulesetrevision_PrincipalObjectAttributeAccesses)
- [msdyn_webengagementsitearea_PrincipalObjectAttributeAccesses](#BKMK_msdyn_webengagementsitearea_PrincipalObjectAttributeAccesses)
- [msdyn_wechatengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wechatengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_whatsappengagementctx_PrincipalObjectAttributeAccesses](#BKMK_msdyn_whatsappengagementctx_PrincipalObjectAttributeAccesses)
- [msdyn_workhourtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses)

### <a name="BKMK_msdyn_actual_PrincipalObjectAttributeAccesses"></a> msdyn_actual_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_actual msdyn_actual_PrincipalObjectAttributeAccesses](msdyn_actual.md#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_actual`|
|ReferencedAttribute|`msdyn_actualid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_actual`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsbuild_PrincipalObjectAttributeAccesses"></a> msdyn_amsbuild_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_amsbuild msdyn_amsbuild_PrincipalObjectAttributeAccesses](msdyn_amsbuild.md#BKMK_msdyn_amsbuild_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsbuild`|
|ReferencedAttribute|`msdyn_amsbuildid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_amsbuild`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsmodel_PrincipalObjectAttributeAccesses"></a> msdyn_amsmodel_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_amsmodel msdyn_amsmodel_PrincipalObjectAttributeAccesses](msdyn_amsmodel.md#BKMK_msdyn_amsmodel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsmodel`|
|ReferencedAttribute|`msdyn_amsmodelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_amsmodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsprofile_PrincipalObjectAttributeAccesses"></a> msdyn_amsprofile_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_amsprofile msdyn_amsprofile_PrincipalObjectAttributeAccesses](msdyn_amsprofile.md#BKMK_msdyn_amsprofile_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsprofile`|
|ReferencedAttribute|`msdyn_amsprofileid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_amsprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amsprofilesettings_PrincipalObjectAttributeAccesses"></a> msdyn_amsprofilesettings_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_amsprofilesettings msdyn_amsprofilesettings_PrincipalObjectAttributeAccesses](msdyn_amsprofilesettings.md#BKMK_msdyn_amsprofilesettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amsprofilesettings`|
|ReferencedAttribute|`msdyn_amsprofilesettingsid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_amsprofilesettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_amstag_PrincipalObjectAttributeAccesses"></a> msdyn_amstag_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_amstag msdyn_amstag_PrincipalObjectAttributeAccesses](msdyn_amstag.md#BKMK_msdyn_amstag_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_amstag`|
|ReferencedAttribute|`msdyn_amstagid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_amstag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_azurenotificationhub_PrincipalObjectAttributeAccesses"></a> msdyn_azurenotificationhub_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_azurenotificationhub msdyn_azurenotificationhub_PrincipalObjectAttributeAccesses](msdyn_azurenotificationhub.md#BKMK_msdyn_azurenotificationhub_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_azurenotificationhub`|
|ReferencedAttribute|`msdyn_azurenotificationhubid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_azurenotificationhub`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses"></a> msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookableresourceassociation msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses](msdyn_bookableresourceassociation.md#BKMK_msdyn_bookableresourceassociation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookableresourceassociation`|
|ReferencedAttribute|`msdyn_bookableresourceassociationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookableresourceassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalert_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingalert msdyn_bookingalert_PrincipalObjectAttributeAccesses](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingalertstatus msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingalertstatus`|
|ReferencedAttribute|`msdyn_bookingalertstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingalertstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses"></a> msdyn_bookingchange_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingchange msdyn_bookingchange_PrincipalObjectAttributeAccesses](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingchange`|
|ReferencedAttribute|`msdyn_bookingchangeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses"></a> msdyn_bookingrule_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingrule msdyn_bookingrule_PrincipalObjectAttributeAccesses](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingrule`|
|ReferencedAttribute|`msdyn_bookingruleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses"></a> msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_bookingsetupmetadata msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_bookingsetupmetadata`|
|ReferencedAttribute|`msdyn_bookingsetupmetadataid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_bookingsetupmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses"></a> msdyn_businessclosure_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_businessclosure msdyn_businessclosure_PrincipalObjectAttributeAccesses](msdyn_businessclosure.md#BKMK_msdyn_businessclosure_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_businessclosure`|
|ReferencedAttribute|`msdyn_businessclosureid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_businessclosure`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channel_PrincipalObjectAttributeAccesses"></a> msdyn_channel_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_channel msdyn_channel_PrincipalObjectAttributeAccesses](msdyn_channel.md#BKMK_msdyn_channel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channel`|
|ReferencedAttribute|`msdyn_channelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_channel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_channelinstancesecret_PrincipalObjectAttributeAccesses"></a> msdyn_channelinstancesecret_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_channelinstancesecret msdyn_channelinstancesecret_PrincipalObjectAttributeAccesses](msdyn_channelinstancesecret.md#BKMK_msdyn_channelinstancesecret_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_channelinstancesecret`|
|ReferencedAttribute|`msdyn_channelinstancesecretid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_channelinstancesecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatansweroption_PrincipalObjectAttributeAccesses"></a> msdyn_chatansweroption_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_chatansweroption msdyn_chatansweroption_PrincipalObjectAttributeAccesses](msdyn_chatansweroption.md#BKMK_msdyn_chatansweroption_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatansweroption`|
|ReferencedAttribute|`msdyn_chatansweroptionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_chatansweroption`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatquestionnaireresponse_PrincipalObjectAttributeAccesses"></a> msdyn_chatquestionnaireresponse_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_chatquestionnaireresponse msdyn_chatquestionnaireresponse_PrincipalObjectAttributeAccesses](msdyn_chatquestionnaireresponse.md#BKMK_msdyn_chatquestionnaireresponse_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatquestionnaireresponse`|
|ReferencedAttribute|`msdyn_chatquestionnaireresponseid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_chatquestionnaireresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatquestionnaireresponseitem_PrincipalObjectAttributeAccesses"></a> msdyn_chatquestionnaireresponseitem_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_chatquestionnaireresponseitem msdyn_chatquestionnaireresponseitem_PrincipalObjectAttributeAccesses](msdyn_chatquestionnaireresponseitem.md#BKMK_msdyn_chatquestionnaireresponseitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatquestionnaireresponseitem`|
|ReferencedAttribute|`msdyn_chatquestionnaireresponseitemid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_chatquestionnaireresponseitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_chatwidgetlanguage_PrincipalObjectAttributeAccesses"></a> msdyn_chatwidgetlanguage_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_chatwidgetlanguage msdyn_chatwidgetlanguage_PrincipalObjectAttributeAccesses](msdyn_chatwidgetlanguage.md#BKMK_msdyn_chatwidgetlanguage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_chatwidgetlanguage`|
|ReferencedAttribute|`msdyn_chatwidgetlanguageid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_chatwidgetlanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses"></a> msdyn_clientextension_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_clientextension msdyn_clientextension_PrincipalObjectAttributeAccesses](msdyn_clientextension.md#BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_clientextension`|
|ReferencedAttribute|`msdyn_clientextensionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_clientextension`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses"></a> msdyn_configuration_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_configuration msdyn_configuration_PrincipalObjectAttributeAccesses](msdyn_configuration.md#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_configuration`|
|ReferencedAttribute|`msdyn_configurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_configuration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_customengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_customengagementctx msdyn_customengagementctx_PrincipalObjectAttributeAccesses](msdyn_customengagementctx.md#BKMK_msdyn_customengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customengagementctx`|
|ReferencedAttribute|`msdyn_customengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_customengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_facebookengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_facebookengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_facebookengagementctx msdyn_facebookengagementctx_PrincipalObjectAttributeAccesses](msdyn_facebookengagementctx.md#BKMK_msdyn_facebookengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_facebookengagementctx`|
|ReferencedAttribute|`msdyn_facebookengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_facebookengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_lineengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_lineengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_lineengagementctx msdyn_lineengagementctx_PrincipalObjectAttributeAccesses](msdyn_lineengagementctx.md#BKMK_msdyn_lineengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_lineengagementctx`|
|ReferencedAttribute|`msdyn_lineengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_lineengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatconfig_PrincipalObjectAttributeAccesses"></a> msdyn_livechatconfig_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_livechatconfig msdyn_livechatconfig_PrincipalObjectAttributeAccesses](msdyn_livechatconfig.md#BKMK_msdyn_livechatconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatconfig`|
|ReferencedAttribute|`msdyn_livechatconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_livechatconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_livechatengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_livechatengagementctx msdyn_livechatengagementctx_PrincipalObjectAttributeAccesses](msdyn_livechatengagementctx.md#BKMK_msdyn_livechatengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatengagementctx`|
|ReferencedAttribute|`msdyn_livechatengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_livechatengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_livechatwidgetlocation_PrincipalObjectAttributeAccesses"></a> msdyn_livechatwidgetlocation_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_livechatwidgetlocation msdyn_livechatwidgetlocation_PrincipalObjectAttributeAccesses](msdyn_livechatwidgetlocation.md#BKMK_msdyn_livechatwidgetlocation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_livechatwidgetlocation`|
|ReferencedAttribute|`msdyn_livechatwidgetlocationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_livechatwidgetlocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_localizedsurveyquestion_PrincipalObjectAttributeAccesses"></a> msdyn_localizedsurveyquestion_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_localizedsurveyquestion msdyn_localizedsurveyquestion_PrincipalObjectAttributeAccesses](msdyn_localizedsurveyquestion.md#BKMK_msdyn_localizedsurveyquestion_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_localizedsurveyquestion`|
|ReferencedAttribute|`msdyn_localizedsurveyquestionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_localizedsurveyquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplebusinessaccount_PrincipalObjectAttributeAccesses"></a> msdyn_ocapplebusinessaccount_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocapplebusinessaccount msdyn_ocapplebusinessaccount_PrincipalObjectAttributeAccesses](msdyn_ocapplebusinessaccount.md#BKMK_msdyn_ocapplebusinessaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplebusinessaccount`|
|ReferencedAttribute|`msdyn_ocapplebusinessaccountid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocapplebusinessaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplemessagesforbusinessengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_ocapplemessagesforbusinessengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocapplemessagesforbusinessengagementctx msdyn_ocapplemessagesforbusinessengagementctx_PrincipalObjectAttributeAccesses](msdyn_ocapplemessagesforbusinessengagementctx.md#BKMK_msdyn_ocapplemessagesforbusinessengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplemessagesforbusinessengagementctx`|
|ReferencedAttribute|`msdyn_ocapplemessagesforbusinessengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocapplemessagesforbusinessengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocapplepay_PrincipalObjectAttributeAccesses"></a> msdyn_ocapplepay_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocapplepay msdyn_ocapplepay_PrincipalObjectAttributeAccesses](msdyn_ocapplepay.md#BKMK_msdyn_ocapplepay_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocapplepay`|
|ReferencedAttribute|`msdyn_ocapplepayid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocapplepay`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occarrier_PrincipalObjectAttributeAccesses"></a> msdyn_occarrier_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_occarrier msdyn_occarrier_PrincipalObjectAttributeAccesses](msdyn_occarrier.md#BKMK_msdyn_occarrier_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occarrier`|
|ReferencedAttribute|`msdyn_occarrierid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_occarrier`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses"></a> msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_occommunicationprovidersetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_occommunicationprovidersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occommunicationprovidersettingentry_PrincipalObjectAttributeAccesses"></a> msdyn_occommunicationprovidersettingentry_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_occommunicationprovidersettingentry msdyn_occommunicationprovidersettingentry_PrincipalObjectAttributeAccesses](msdyn_occommunicationprovidersettingentry.md#BKMK_msdyn_occommunicationprovidersettingentry_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersettingentry`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingentryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_occommunicationprovidersettingentry`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occustommessagingchannel_PrincipalObjectAttributeAccesses"></a> msdyn_occustommessagingchannel_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_occustommessagingchannel msdyn_occustommessagingchannel_PrincipalObjectAttributeAccesses](msdyn_occustommessagingchannel.md#BKMK_msdyn_occustommessagingchannel_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occustommessagingchannel`|
|ReferencedAttribute|`msdyn_occustommessagingchannelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_occustommessagingchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_occustomneuralvoice_PrincipalObjectAttributeAccesses"></a> msdyn_occustomneuralvoice_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_occustomneuralvoice msdyn_occustomneuralvoice_PrincipalObjectAttributeAccesses](msdyn_occustomneuralvoice.md#BKMK_msdyn_occustomneuralvoice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occustomneuralvoice`|
|ReferencedAttribute|`msdyn_occustomneuralvoiceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_occustomneuralvoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocexternalsecuritysetting_PrincipalObjectAttributeAccesses"></a> msdyn_ocexternalsecuritysetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocexternalsecuritysetting msdyn_ocexternalsecuritysetting_PrincipalObjectAttributeAccesses](msdyn_ocexternalsecuritysetting.md#BKMK_msdyn_ocexternalsecuritysetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocexternalsecuritysetting`|
|ReferencedAttribute|`msdyn_ocexternalsecuritysettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocexternalsecuritysetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocfbapplication_PrincipalObjectAttributeAccesses"></a> msdyn_ocfbapplication_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_ocfbapplication_PrincipalObjectAttributeAccesses](msdyn_ocfbapplication.md#BKMK_msdyn_ocfbapplication_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocfbapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocfbpage_PrincipalObjectAttributeAccesses"></a> msdyn_ocfbpage_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocfbpage msdyn_ocfbpage_PrincipalObjectAttributeAccesses](msdyn_ocfbpage.md#BKMK_msdyn_ocfbpage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbpage`|
|ReferencedAttribute|`msdyn_ocfbpageid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocfbpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocgatekeeperengagementctx msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses](msdyn_ocgatekeeperengagementctx.md#BKMK_msdyn_ocgatekeeperengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgatekeeperengagementctx`|
|ReferencedAttribute|`msdyn_ocgatekeeperengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocgatekeeperengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses"></a> msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesagentaccount msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses](msdyn_ocgooglebusinessmessagesagentaccount.md#BKMK_msdyn_ocgooglebusinessmessagesagentaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesagentaccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesagentaccountid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocgooglebusinessmessagesagentaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagesengagementctx msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses](msdyn_ocgooglebusinessmessagesengagementctx.md#BKMK_msdyn_ocgooglebusinessmessagesengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagesengagementctx`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagesengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocgooglebusinessmessagesengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses"></a> msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocgooglebusinessmessagespartneraccount msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses](msdyn_ocgooglebusinessmessagespartneraccount.md#BKMK_msdyn_ocgooglebusinessmessagespartneraccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocgooglebusinessmessagespartneraccount`|
|ReferencedAttribute|`msdyn_ocgooglebusinessmessagespartneraccountid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocgooglebusinessmessagespartneraccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclinechannelconfig_PrincipalObjectAttributeAccesses"></a> msdyn_oclinechannelconfig_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_oclinechannelconfig msdyn_oclinechannelconfig_PrincipalObjectAttributeAccesses](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclinechannelconfig`|
|ReferencedAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_oclinechannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocoutboundconfiguration msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses](msdyn_ocoutboundconfiguration.md#BKMK_msdyn_ocoutboundconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundconfiguration`|
|ReferencedAttribute|`msdyn_ocoutboundconfigurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocoutboundconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses"></a> msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonecallengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_ocphonecallengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocphonecallengagementctx msdyn_ocphonecallengagementctx_PrincipalObjectAttributeAccesses](msdyn_ocphonecallengagementctx.md#BKMK_msdyn_ocphonecallengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonecallengagementctx`|
|ReferencedAttribute|`msdyn_ocphonecallengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocphonecallengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonemusic_PrincipalObjectAttributeAccesses"></a> msdyn_ocphonemusic_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocphonemusic msdyn_ocphonemusic_PrincipalObjectAttributeAccesses](msdyn_ocphonemusic.md#BKMK_msdyn_ocphonemusic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonemusic`|
|ReferencedAttribute|`msdyn_ocphonemusicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocphonemusic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocphonenumber_PrincipalObjectAttributeAccesses"></a> msdyn_ocphonenumber_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_ocphonenumber_PrincipalObjectAttributeAccesses](msdyn_ocphonenumber.md#BKMK_msdyn_ocphonenumber_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocphonenumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses"></a> msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocsmschannelsetting msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses](msdyn_ocsmschannelsetting.md#BKMK_msdyn_ocsmschannelsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsmschannelsetting`|
|ReferencedAttribute|`msdyn_ocsmschannelsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocsmschannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsmssettingsecret_PrincipalObjectAttributeAccesses"></a> msdyn_ocsmssettingsecret_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocsmssettingsecret msdyn_ocsmssettingsecret_PrincipalObjectAttributeAccesses](msdyn_ocsmssettingsecret.md#BKMK_msdyn_ocsmssettingsecret_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsmssettingsecret`|
|ReferencedAttribute|`msdyn_ocsmssettingsecretid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocsmssettingsecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses"></a> msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_octeamschannelconfig msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octeamschannelconfig`|
|ReferencedAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_octeamschannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterapplication_PrincipalObjectAttributeAccesses"></a> msdyn_octwitterapplication_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_octwitterapplication msdyn_octwitterapplication_PrincipalObjectAttributeAccesses](msdyn_octwitterapplication.md#BKMK_msdyn_octwitterapplication_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterapplication`|
|ReferencedAttribute|`msdyn_octwitterapplicationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_octwitterapplication`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandle_PrincipalObjectAttributeAccesses"></a> msdyn_octwitterhandle_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_octwitterhandle msdyn_octwitterhandle_PrincipalObjectAttributeAccesses](msdyn_octwitterhandle.md#BKMK_msdyn_octwitterhandle_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandle`|
|ReferencedAttribute|`msdyn_octwitterhandleid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_octwitterhandle`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandleprovisioningstatus_PrincipalObjectAttributeAccesses"></a> msdyn_octwitterhandleprovisioningstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_octwitterhandleprovisioningstatus msdyn_octwitterhandleprovisioningstatus_PrincipalObjectAttributeAccesses](msdyn_octwitterhandleprovisioningstatus.md#BKMK_msdyn_octwitterhandleprovisioningstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandleprovisioningstatus`|
|ReferencedAttribute|`msdyn_octwitterhandleprovisioningstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_octwitterhandleprovisioningstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octwitterhandlesecret_PrincipalObjectAttributeAccesses"></a> msdyn_octwitterhandlesecret_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_octwitterhandlesecret msdyn_octwitterhandlesecret_PrincipalObjectAttributeAccesses](msdyn_octwitterhandlesecret.md#BKMK_msdyn_octwitterhandlesecret_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octwitterhandlesecret`|
|ReferencedAttribute|`msdyn_octwitterhandlesecretid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_octwitterhandlesecret`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoice_PrincipalObjectAttributeAccesses"></a> msdyn_ocvoice_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocvoice msdyn_ocvoice_PrincipalObjectAttributeAccesses](msdyn_ocvoice.md#BKMK_msdyn_ocvoice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoice`|
|ReferencedAttribute|`msdyn_ocvoiceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocvoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicechannellanguagesetting_PrincipalObjectAttributeAccesses"></a> msdyn_ocvoicechannellanguagesetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocvoicechannellanguagesetting msdyn_ocvoicechannellanguagesetting_PrincipalObjectAttributeAccesses](msdyn_ocvoicechannellanguagesetting.md#BKMK_msdyn_ocvoicechannellanguagesetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannellanguagesetting`|
|ReferencedAttribute|`msdyn_ocvoicechannellanguagesettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocvoicechannellanguagesetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses"></a> msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocvoicechannelsetting msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_ocvoicechannelsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannelsetting`|
|ReferencedAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocvoicechannelsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_PrincipalObjectAttributeAccesses"></a> msdyn_ocvoicemail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_PrincipalObjectAttributeAccesses](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwechatchannelconfig_PrincipalObjectAttributeAccesses"></a> msdyn_ocwechatchannelconfig_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocwechatchannelconfig msdyn_ocwechatchannelconfig_PrincipalObjectAttributeAccesses](msdyn_ocwechatchannelconfig.md#BKMK_msdyn_ocwechatchannelconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwechatchannelconfig`|
|ReferencedAttribute|`msdyn_ocwechatchannelconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocwechatchannelconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelaccount_PrincipalObjectAttributeAccesses"></a> msdyn_ocwhatsappchannelaccount_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocwhatsappchannelaccount msdyn_ocwhatsappchannelaccount_PrincipalObjectAttributeAccesses](msdyn_ocwhatsappchannelaccount.md#BKMK_msdyn_ocwhatsappchannelaccount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelaccountid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocwhatsappchannelaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelnumber_PrincipalObjectAttributeAccesses"></a> msdyn_ocwhatsappchannelnumber_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_ocwhatsappchannelnumber msdyn_ocwhatsappchannelnumber_PrincipalObjectAttributeAccesses](msdyn_ocwhatsappchannelnumber.md#BKMK_msdyn_ocwhatsappchannelnumber_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelnumber`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelnumberid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocwhatsappchannelnumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses"></a> msdyn_organizationalunit_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_organizationalunit msdyn_organizationalunit_PrincipalObjectAttributeAccesses](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_organizationalunit`|
|ReferencedAttribute|`msdyn_organizationalunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_organizationalunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_priority_PrincipalObjectAttributeAccesses"></a> msdyn_priority_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_priority msdyn_priority_PrincipalObjectAttributeAccesses](msdyn_priority.md#BKMK_msdyn_priority_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_delivery_batch_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_delivery_batch_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_proactive_delivery_batch msdyn_proactive_delivery_batch_PrincipalObjectAttributeAccesses](msdyn_proactive_delivery_batch.md#BKMK_msdyn_proactive_delivery_batch_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_delivery_batch`|
|ReferencedAttribute|`msdyn_proactive_delivery_batchid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_proactive_delivery_batch`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_eng_config_characteristic_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_eng_config_characteristic_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_proactive_eng_config_characteristic msdyn_proactive_eng_config_characteristic_PrincipalObjectAttributeAccesses](msdyn_proactive_eng_config_characteristic.md#BKMK_msdyn_proactive_eng_config_characteristic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencedAttribute|`msdyn_proactive_eng_config_characteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_proactive_eng_config_characteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_attribute_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_engagement_config_attribute_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_proactive_engagement_config_attribute msdyn_proactive_engagement_config_attribute_PrincipalObjectAttributeAccesses](msdyn_proactive_engagement_config_attribute.md#BKMK_msdyn_proactive_engagement_config_attribute_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config_attribute`|
|ReferencedAttribute|`msdyn_proactive_engagement_config_attributeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_proactive_engagement_config_attribute`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_proactive_engagement_config msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses](msdyn_proactive_engagement_config.md#BKMK_msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config`|
|ReferencedAttribute|`msdyn_proactive_engagement_configid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_proactive_engagement_config`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_status_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_engagement_config_status_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_proactive_engagement_config_status msdyn_proactive_engagement_config_status_PrincipalObjectAttributeAccesses](msdyn_proactive_engagement_config_status.md#BKMK_msdyn_proactive_engagement_config_status_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_config_status`|
|ReferencedAttribute|`msdyn_proactive_engagement_config_statusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_proactive_engagement_config_status`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_message_template_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_engagement_message_template_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_proactive_engagement_message_template msdyn_proactive_engagement_message_template_PrincipalObjectAttributeAccesses](msdyn_proactive_engagement_message_template.md#BKMK_msdyn_proactive_engagement_message_template_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_message_template`|
|ReferencedAttribute|`msdyn_proactive_engagement_message_templateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_proactive_engagement_message_template`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_proactive_engagement_planner_config msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses](msdyn_proactive_engagement_planner_config.md#BKMK_msdyn_proactive_engagement_planner_config_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_proactive_engagement_planner_config`|
|ReferencedAttribute|`msdyn_proactive_engagement_planner_configid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_proactive_engagement_planner_config`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_questionsequence_PrincipalObjectAttributeAccesses"></a> msdyn_questionsequence_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_questionsequence msdyn_questionsequence_PrincipalObjectAttributeAccesses](msdyn_questionsequence.md#BKMK_msdyn_questionsequence_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_questionsequence`|
|ReferencedAttribute|`msdyn_questionsequenceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_questionsequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses"></a> msdyn_requirementchange_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementchange msdyn_requirementchange_PrincipalObjectAttributeAccesses](msdyn_requirementchange.md#BKMK_msdyn_requirementchange_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementchange`|
|ReferencedAttribute|`msdyn_requirementchangeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementchange`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementcharacteristic msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementcharacteristic`|
|ReferencedAttribute|`msdyn_requirementcharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementcharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses"></a> msdyn_requirementdependency_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementdependency msdyn_requirementdependency_PrincipalObjectAttributeAccesses](msdyn_requirementdependency.md#BKMK_msdyn_requirementdependency_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementdependency`|
|ReferencedAttribute|`msdyn_requirementdependencyid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementdependency`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses"></a> msdyn_requirementgroup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementgroup msdyn_requirementgroup_PrincipalObjectAttributeAccesses](msdyn_requirementgroup.md#BKMK_msdyn_requirementgroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementgroup`|
|ReferencedAttribute|`msdyn_requirementgroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses"></a> msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementorganizationunit msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementorganizationunit`|
|ReferencedAttribute|`msdyn_requirementorganizationunitid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementorganizationunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses"></a> msdyn_requirementrelationship_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementrelationship msdyn_requirementrelationship_PrincipalObjectAttributeAccesses](msdyn_requirementrelationship.md#BKMK_msdyn_requirementrelationship_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementrelationship`|
|ReferencedAttribute|`msdyn_requirementrelationshipid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementrelationship`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses"></a> msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementresourcecategory msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcecategory`|
|ReferencedAttribute|`msdyn_requirementresourcecategoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses"></a> msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementresourcepreference msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementresourcepreference`|
|ReferencedAttribute|`msdyn_requirementresourcepreferenceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementresourcepreference`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses"></a> msdyn_requirementstatus_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_requirementstatus msdyn_requirementstatus_PrincipalObjectAttributeAccesses](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_requirementstatus`|
|ReferencedAttribute|`msdyn_requirementstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_requirementstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequirement_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourcerequirement msdyn_resourcerequirement_PrincipalObjectAttributeAccesses](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirement`|
|ReferencedAttribute|`msdyn_resourcerequirementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourcerequirementdetail msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcerequirementdetail`|
|ReferencedAttribute|`msdyn_resourcerequirementdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourcerequirementdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses"></a> msdyn_resourceterritory_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_resourceterritory msdyn_resourceterritory_PrincipalObjectAttributeAccesses](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourceterritory`|
|ReferencedAttribute|`msdyn_resourceterritoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_resourceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scenario_PrincipalObjectAttributeAccesses"></a> msdyn_scenario_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_scenario msdyn_scenario_PrincipalObjectAttributeAccesses](msdyn_scenario.md#BKMK_msdyn_scenario_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scenario`|
|ReferencedAttribute|`msdyn_scenarioid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_scenario`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses"></a> msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_scheduleboardsetting msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scheduleboardsetting`|
|ReferencedAttribute|`msdyn_scheduleboardsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_scheduleboardsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_schedulingfeatureflag msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses](msdyn_schedulingfeatureflag.md#BKMK_msdyn_schedulingfeatureflag_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingfeatureflag`|
|ReferencedAttribute|`msdyn_schedulingfeatureflagid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_schedulingfeatureflag`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingparameter_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_schedulingparameter msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingparameter`|
|ReferencedAttribute|`msdyn_schedulingparameterid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_schedulingparameter`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingscope_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingscope_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingscope_PrincipalObjectAttributeAccesses](msdyn_schedulingscope.md#BKMK_msdyn_schedulingscope_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_schedulingscope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_smsengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_smsengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_smsengagementctx msdyn_smsengagementctx_PrincipalObjectAttributeAccesses](msdyn_smsengagementctx.md#BKMK_msdyn_smsengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_smsengagementctx`|
|ReferencedAttribute|`msdyn_smsengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_smsengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_smsnumber_PrincipalObjectAttributeAccesses"></a> msdyn_smsnumber_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_smsnumber msdyn_smsnumber_PrincipalObjectAttributeAccesses](msdyn_smsnumber.md#BKMK_msdyn_smsnumber_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_smsnumber`|
|ReferencedAttribute|`msdyn_smsnumberid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_smsnumber`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_surveyquestion_PrincipalObjectAttributeAccesses"></a> msdyn_surveyquestion_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_surveyquestion msdyn_surveyquestion_PrincipalObjectAttributeAccesses](msdyn_surveyquestion.md#BKMK_msdyn_surveyquestion_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_surveyquestion`|
|ReferencedAttribute|`msdyn_surveyquestionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_surveyquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses"></a> msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_systemuserschedulersetting msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_systemuserschedulersetting`|
|ReferencedAttribute|`msdyn_systemuserschedulersettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_systemuserschedulersetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_teamschannelengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_teamschannelengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_teamschannelengagementctx msdyn_teamschannelengagementctx_PrincipalObjectAttributeAccesses](msdyn_teamschannelengagementctx.md#BKMK_msdyn_teamschannelengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_teamschannelengagementctx`|
|ReferencedAttribute|`msdyn_teamschannelengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_teamschannelengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses"></a> msdyn_timegroup_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timegroup msdyn_timegroup_PrincipalObjectAttributeAccesses](msdyn_timegroup.md#BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroup`|
|ReferencedAttribute|`msdyn_timegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses"></a> msdyn_timegroupdetail_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_timegroupdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses"></a> msdyn_transactionorigin_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_transactionorigin msdyn_transactionorigin_PrincipalObjectAttributeAccesses](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transactionorigin`|
|ReferencedAttribute|`msdyn_transactionoriginid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transactionorigin`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_twitterengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_twitterengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_twitterengagementctx msdyn_twitterengagementctx_PrincipalObjectAttributeAccesses](msdyn_twitterengagementctx.md#BKMK_msdyn_twitterengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_twitterengagementctx`|
|ReferencedAttribute|`msdyn_twitterengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_twitterengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses"></a> msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_voicechannelorganizationsetting msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses](msdyn_voicechannelorganizationsetting.md#BKMK_msdyn_voicechannelorganizationsetting_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_voicechannelorganizationsetting`|
|ReferencedAttribute|`msdyn_voicechannelorganizationsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_voicechannelorganizationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementruleset_PrincipalObjectAttributeAccesses"></a> msdyn_webengagementruleset_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_webengagementruleset msdyn_webengagementruleset_PrincipalObjectAttributeAccesses](msdyn_webengagementruleset.md#BKMK_msdyn_webengagementruleset_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementruleset`|
|ReferencedAttribute|`msdyn_webengagementrulesetid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_webengagementruleset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementrulesetconfig_PrincipalObjectAttributeAccesses"></a> msdyn_webengagementrulesetconfig_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_webengagementrulesetconfig msdyn_webengagementrulesetconfig_PrincipalObjectAttributeAccesses](msdyn_webengagementrulesetconfig.md#BKMK_msdyn_webengagementrulesetconfig_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementrulesetconfig`|
|ReferencedAttribute|`msdyn_webengagementrulesetconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_webengagementrulesetconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementrulesetrevision_PrincipalObjectAttributeAccesses"></a> msdyn_webengagementrulesetrevision_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_webengagementrulesetrevision msdyn_webengagementrulesetrevision_PrincipalObjectAttributeAccesses](msdyn_webengagementrulesetrevision.md#BKMK_msdyn_webengagementrulesetrevision_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementrulesetrevision`|
|ReferencedAttribute|`msdyn_webengagementrulesetrevisionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_webengagementrulesetrevision`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_webengagementsitearea_PrincipalObjectAttributeAccesses"></a> msdyn_webengagementsitearea_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_webengagementsitearea msdyn_webengagementsitearea_PrincipalObjectAttributeAccesses](msdyn_webengagementsitearea.md#BKMK_msdyn_webengagementsitearea_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_webengagementsitearea`|
|ReferencedAttribute|`msdyn_webengagementsiteareaid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_webengagementsitearea`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_wechatengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_wechatengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_wechatengagementctx msdyn_wechatengagementctx_PrincipalObjectAttributeAccesses](msdyn_wechatengagementctx.md#BKMK_msdyn_wechatengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_wechatengagementctx`|
|ReferencedAttribute|`msdyn_wechatengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_wechatengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_whatsappengagementctx_PrincipalObjectAttributeAccesses"></a> msdyn_whatsappengagementctx_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_whatsappengagementctx msdyn_whatsappengagementctx_PrincipalObjectAttributeAccesses](msdyn_whatsappengagementctx.md#BKMK_msdyn_whatsappengagementctx_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_whatsappengagementctx`|
|ReferencedAttribute|`msdyn_whatsappengagementctxid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_whatsappengagementctx`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses"></a> msdyn_workhourtemplate_PrincipalObjectAttributeAccesses

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_workhourtemplate_PrincipalObjectAttributeAccesses](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.principalobjectattributeaccess?displayProperty=fullName>
