---
title: "Organization table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Organization table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Organization table/entity reference (Microsoft Dynamics 365)

Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.

> [!NOTE]
> The Microsoft Dynamics 365 Organization table extends the [Microsoft Dataverse Organization table](/power-apps/developer/data-platform/reference/entities/organization).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AreSalesAddressSuggestionsEnabled](#BKMK_AreSalesAddressSuggestionsEnabled)
- [DefaultTeamsChatTitleRecordName](#BKMK_DefaultTeamsChatTitleRecordName)
- [EmailTemplateDefaultView](#BKMK_EmailTemplateDefaultView)
- [EnableCalendarImportExport](#BKMK_EnableCalendarImportExport)
- [EnableEmailTemplateViews](#BKMK_EnableEmailTemplateViews)
- [EnableSensitivityLabelsForTeamsCollab](#BKMK_EnableSensitivityLabelsForTeamsCollab)
- [EnhancedOQOIAddProductsSettings](#BKMK_EnhancedOQOIAddProductsSettings)
- [IsEmbedTeamsCollabEnabled](#BKMK_IsEmbedTeamsCollabEnabled)
- [IsSalesMobilePreviewEnabled](#BKMK_IsSalesMobilePreviewEnabled)
- [SalesMobileQuickCreateDisabled](#BKMK_SalesMobileQuickCreateDisabled)
- [SalesMobileUseUCIFormsForCreate](#BKMK_SalesMobileUseUCIFormsForCreate)
- [SalesMobileUseUCIFormsForView](#BKMK_SalesMobileUseUCIFormsForView)
- [SchedulingEngine](#BKMK_SchedulingEngine)
- [SkipSelectRecordDialog](#BKMK_SkipSelectRecordDialog)

### <a name="BKMK_AreSalesAddressSuggestionsEnabled"></a> AreSalesAddressSuggestionsEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether Address Suggestions has been enabled for the organization**|
|DisplayName|**Indicates whether Address Suggestions has been enabled for the organization**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`aresalesaddresssuggestionsenabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_DefaultTeamsChatTitleRecordName"></a> DefaultTeamsChatTitleRecordName

|Property|Value|
|---|---|
|Description|**Indicates whether the default teams linked chat title is the record name**|
|DisplayName|**Indicates whether the default teams linked chat title is the record name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultteamschattitlerecordname`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_EmailTemplateDefaultView"></a> EmailTemplateDefaultView

|Property|Value|
|---|---|
|Description|**Indicates the selected default view in the enhanced insert e-mail template experience..**|
|DisplayName|**Select the default view in the enhanced insert e-mail template experience.**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`emailtemplatedefaultview`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`templatedefaultview`|

#### EmailTemplateDefaultView Choices/Options

|Value|Label|
|---|---|
|1|**Tiles View**|
|2|**Grid View**|
|3|**List View**|

### <a name="BKMK_EnableCalendarImportExport"></a> EnableCalendarImportExport

|Property|Value|
|---|---|
|Description|**Indicates whether to Allow calendar export import with SLA.**|
|DisplayName|**Allow calendar export import with SLA**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`enablecalendarimportexport`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_EnableEmailTemplateViews"></a> EnableEmailTemplateViews

|Property|Value|
|---|---|
|Description|**Indicates whether to Allow email template views in Enhanced Email Template.**|
|DisplayName|**Allow email template views in Enhanced Email Template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`enableemailtemplateviews`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_EnableSensitivityLabelsForTeamsCollab"></a> EnableSensitivityLabelsForTeamsCollab

|Property|Value|
|---|---|
|Description|**Indicates whether privacy and sensitivity attributes for new team creation has been enabled**|
|DisplayName|**Indicates whether privacy and sensitivity attributes for new team creation has been enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`enablesensitivitylabelsforteamscollab`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_EnhancedOQOIAddProductsSettings"></a> EnhancedOQOIAddProductsSettings

|Property|Value|
|---|---|
|Description|**JSON string containing settings for enhanced add products experience in Sales**|
|DisplayName|**Enhanced Add Products Settings**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`enhancedoqoiaddproductssettings`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_IsEmbedTeamsCollabEnabled"></a> IsEmbedTeamsCollabEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether embed Teams collaboration has been enabled for the organization**|
|DisplayName|**Indicates whether embed Teams collaboration has been enabled for the organization**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isembedteamscollabenabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_IsSalesMobilePreviewEnabled"></a> IsSalesMobilePreviewEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether Sales Mobile Preview has been enabled for the organization**|
|DisplayName|**Indicates whether Sales Mobile Preview has been enabled for the organization**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`issalesmobilepreviewenabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_SalesMobileQuickCreateDisabled"></a> SalesMobileQuickCreateDisabled

|Property|Value|
|---|---|
|Description|**Disable the option to quick create new records and activities in the Sales mobile application**|
|DisplayName|**Disable the option to quick create new records and activities in the Sales mobile application**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesmobilequickcreatedisabled`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_SalesMobileUseUCIFormsForCreate"></a> SalesMobileUseUCIFormsForCreate

|Property|Value|
|---|---|
|Description|**Indicates whether Sales Mobile should use UCI forms for create**|
|DisplayName|**Indicates whether Sales Mobile should use UCI forms for create**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesmobileuseuciformsforcreate`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_SalesMobileUseUCIFormsForView"></a> SalesMobileUseUCIFormsForView

|Property|Value|
|---|---|
|Description|**Indicates whether Sales Mobile should use UCI forms for view**|
|DisplayName|**Indicates whether Sales Mobile should use UCI forms for view**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`salesmobileuseuciformsforview`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_SchedulingEngine"></a> SchedulingEngine

|Property|Value|
|---|---|
|Description|**Scheduling engine for Appointments and Service Activities**|
|DisplayName|**Scheduling engine for Appointments and Service Activities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`schedulingengine`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`organization_schedulingengine`|

#### SchedulingEngine Choices/Options

|Value|Label|
|---|---|
|0|**(Default) Scheduling Engine**|

### <a name="BKMK_SkipSelectRecordDialog"></a> SkipSelectRecordDialog

|Property|Value|
|---|---|
|Description|**Indicates whether to Allow select record dialog in Enhanced Email Template.**|
|DisplayName|**Allow select record dialog in Enhanced Email Template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`skipselectrecorddialog`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`organization_featureenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [dynamicproperty_organization](#BKMK_dynamicproperty_organization)
- [DynamicPropertyAssociation_organization](#BKMK_DynamicPropertyAssociation_organization)
- [DynamicPropertyOptionSetItem_organization](#BKMK_DynamicPropertyOptionSetItem_organization)
- [entitlementchannel_organization](#BKMK_entitlementchannel_organization)
- [entitlementtemplate_organization](#BKMK_entitlementtemplate_organization)
- [entitlementtemplatechannel_organization](#BKMK_entitlementtemplatechannel_organization)
- [organization_competitors](#BKMK_organization_competitors)
- [organization_constraint_based_groups](#BKMK_organization_constraint_based_groups)
- [organization_contract_templates](#BKMK_organization_contract_templates)
- [organization_discount_types](#BKMK_organization_discount_types)
- [organization_equipment](#BKMK_organization_equipment)
- [organization_leadtoopportunitysalesprocess](#BKMK_organization_leadtoopportunitysalesprocess)
- [organization_marketingformdisplayattributes](#BKMK_organization_marketingformdisplayattributes)
- [organization_msdyn_accountkpiitem](#BKMK_organization_msdyn_accountkpiitem)
- [organization_msdyn_activityanalysiscleanupstate](#BKMK_organization_msdyn_activityanalysiscleanupstate)
- [organization_msdyn_activityanalysisconfig](#BKMK_organization_msdyn_activityanalysisconfig)
- [organization_msdyn_adaptivecardconfiguration](#BKMK_organization_msdyn_adaptivecardconfiguration)
- [organization_msdyn_agentcopilotsetting](#BKMK_organization_msdyn_agentcopilotsetting)
- [organization_msdyn_agentresourceforecasting](#BKMK_organization_msdyn_agentresourceforecasting)
- [organization_msdyn_appcopilotconfiguration](#BKMK_organization_msdyn_appcopilotconfiguration)
- [organization_msdyn_attributeinfluencestatistics](#BKMK_organization_msdyn_attributeinfluencestatistics)
- [organization_msdyn_cannedmessage](#BKMK_organization_msdyn_cannedmessage)
- [organization_msdyn_caseenrichment](#BKMK_organization_msdyn_caseenrichment)
- [organization_msdyn_casefollowupandclosureconfiguration](#BKMK_organization_msdyn_casefollowupandclosureconfiguration)
- [organization_msdyn_casesuggestionrequestpayload](#BKMK_organization_msdyn_casesuggestionrequestpayload)
- [organization_msdyn_casetopic](#BKMK_organization_msdyn_casetopic)
- [organization_msdyn_casetopic_incident](#BKMK_organization_msdyn_casetopic_incident)
- [organization_msdyn_casetopicsetting](#BKMK_organization_msdyn_casetopicsetting)
- [organization_msdyn_casetopicsummary](#BKMK_organization_msdyn_casetopicsummary)
- [organization_msdyn_channelcapability](#BKMK_organization_msdyn_channelcapability)
- [organization_msdyn_ciprovider](#BKMK_organization_msdyn_ciprovider)
- [organization_msdyn_contactkpiitem](#BKMK_organization_msdyn_contactkpiitem)
- [organization_msdyn_conversationsummaryinteraction](#BKMK_organization_msdyn_conversationsummaryinteraction)
- [organization_msdyn_conversationsummarysetting](#BKMK_organization_msdyn_conversationsummarysetting)
- [organization_msdyn_conversationtopic](#BKMK_organization_msdyn_conversationtopic)
- [organization_msdyn_conversationtopic_conversation](#BKMK_organization_msdyn_conversationtopic_conversation)
- [organization_msdyn_conversationtopicsetting](#BKMK_organization_msdyn_conversationtopicsetting)
- [organization_msdyn_conversationtopicsummary](#BKMK_organization_msdyn_conversationtopicsummary)
- [organization_msdyn_copilotinteraction](#BKMK_organization_msdyn_copilotinteraction)
- [organization_msdyn_copilotsummarizationsetting](#BKMK_organization_msdyn_copilotsummarizationsetting)
- [organization_msdyn_cskeyvalueconfig](#BKMK_organization_msdyn_cskeyvalueconfig)
- [organization_msdyn_customeremailcommunication](#BKMK_organization_msdyn_customeremailcommunication)
- [organization_msdyn_customerfeedbacksurvey](#BKMK_organization_msdyn_customerfeedbacksurvey)
- [organization_msdyn_customerfeedbacksurveyinvite](#BKMK_organization_msdyn_customerfeedbacksurveyinvite)
- [organization_msdyn_customerfeedbacksurveyresponse](#BKMK_organization_msdyn_customerfeedbacksurveyresponse)
- [organization_msdyn_dailyaccountkpiitem](#BKMK_organization_msdyn_dailyaccountkpiitem)
- [organization_msdyn_dailycontactkpiitem](#BKMK_organization_msdyn_dailycontactkpiitem)
- [organization_msdyn_dailyleadkpiitem](#BKMK_organization_msdyn_dailyleadkpiitem)
- [organization_msdyn_dailyopportunitykpiitem](#BKMK_organization_msdyn_dailyopportunitykpiitem)
- [organization_msdyn_dataanalyticsreport_copilot](#BKMK_organization_msdyn_dataanalyticsreport_copilot)
- [organization_msdyn_dataanalyticsreport_csrmanager](#BKMK_organization_msdyn_dataanalyticsreport_csrmanager)
- [organization_msdyn_dataanalyticsreport_email](#BKMK_organization_msdyn_dataanalyticsreport_email)
- [organization_msdyn_dataanalyticsreport_forecast](#BKMK_organization_msdyn_dataanalyticsreport_forecast)
- [organization_msdyn_dataanalyticsreport_ksinsights](#BKMK_organization_msdyn_dataanalyticsreport_ksinsights)
- [organization_msdyn_dataanalyticsreport_mc](#BKMK_organization_msdyn_dataanalyticsreport_mc)
- [organization_msdyn_dataanalyticsreport_oc](#BKMK_organization_msdyn_dataanalyticsreport_oc)
- [organization_msdyn_dataanalyticsreport_oc_rt](#BKMK_organization_msdyn_dataanalyticsreport_oc_rt)
- [organization_msdyn_dataanalyticsreport_sareporting](#BKMK_organization_msdyn_dataanalyticsreport_sareporting)
- [organization_msdyn_dataanalyticsreport_sutreporting](#BKMK_organization_msdyn_dataanalyticsreport_sutreporting)
- [organization_msdyn_dataanalyticsreport_ur_recordrouting_rt](#BKMK_organization_msdyn_dataanalyticsreport_ur_recordrouting_rt)
- [organization_msdyn_databaseversion](#BKMK_organization_msdyn_databaseversion)
- [organization_msdyn_datahygienesettinginfo](#BKMK_organization_msdyn_datahygienesettinginfo)
- [organization_msdyn_datainsightsandanalyticsfeature](#BKMK_organization_msdyn_datainsightsandanalyticsfeature)
- [organization_msdyn_derivedinsightsrelatedentity](#BKMK_organization_msdyn_derivedinsightsrelatedentity)
- [organization_msdyn_digitalsellingactivetask](#BKMK_organization_msdyn_digitalsellingactivetask)
- [organization_msdyn_digitalsellingcompletedtask](#BKMK_organization_msdyn_digitalsellingcompletedtask)
- [organization_msdyn_distributedlock](#BKMK_organization_msdyn_distributedlock)
- [organization_msdyn_duplicatedetectionpluginrun](#BKMK_organization_msdyn_duplicatedetectionpluginrun)
- [organization_msdyn_entityderivedinsight](#BKMK_organization_msdyn_entityderivedinsight)
- [organization_msdyn_forecastingcache](#BKMK_organization_msdyn_forecastingcache)
- [organization_msdyn_forecastpredictionstatus](#BKMK_organization_msdyn_forecastpredictionstatus)
- [organization_msdyn_forecastsettingsandsummary](#BKMK_organization_msdyn_forecastsettingsandsummary)
- [organization_msdyn_inboxcardconfiguration](#BKMK_organization_msdyn_inboxcardconfiguration)
- [organization_msdyn_inboxconfiguration](#BKMK_organization_msdyn_inboxconfiguration)
- [organization_msdyn_inboxentityconfig](#BKMK_organization_msdyn_inboxentityconfig)
- [organization_msdyn_iottocaseprocess](#BKMK_organization_msdyn_iottocaseprocess)
- [organization_msdyn_kbenrichment](#BKMK_organization_msdyn_kbenrichment)
- [organization_msdyn_kbkeywordsdescsuggestionsetting](#BKMK_organization_msdyn_kbkeywordsdescsuggestionsetting)
- [organization_msdyn_leadhygienesetting](#BKMK_organization_msdyn_leadhygienesetting)
- [organization_msdyn_leadkpiitem](#BKMK_organization_msdyn_leadkpiitem)
- [organization_msdyn_linkedentityattributevalidity](#BKMK_organization_msdyn_linkedentityattributevalidity)
- [organization_msdyn_maskingrule](#BKMK_organization_msdyn_maskingrule)
- [organization_msdyn_mostcontacted](#BKMK_organization_msdyn_mostcontacted)
- [organization_msdyn_mostcontactedby](#BKMK_organization_msdyn_mostcontactedby)
- [organization_msdyn_nextaction](#BKMK_organization_msdyn_nextaction)
- [organization_msdyn_occhannelconfiguration](#BKMK_organization_msdyn_occhannelconfiguration)
- [organization_msdyn_occhannelstateconfiguration](#BKMK_organization_msdyn_occhannelstateconfiguration)
- [organization_msdyn_oclocalizationdata](#BKMK_organization_msdyn_oclocalizationdata)
- [organization_msdyn_ocsystemmessage](#BKMK_organization_msdyn_ocsystemmessage)
- [organization_msdyn_octag](#BKMK_organization_msdyn_octag)
- [organization_msdyn_odosfeaturemetadata](#BKMK_organization_msdyn_odosfeaturemetadata)
- [organization_msdyn_odosmetadata](#BKMK_organization_msdyn_odosmetadata)
- [organization_msdyn_omnichannelconfiguration](#BKMK_organization_msdyn_omnichannelconfiguration)
- [organization_msdyn_opportunitykpiitem](#BKMK_organization_msdyn_opportunitykpiitem)
- [organization_msdyn_paneconfiguration](#BKMK_organization_msdyn_paneconfiguration)
- [organization_msdyn_panetabconfiguration](#BKMK_organization_msdyn_panetabconfiguration)
- [organization_msdyn_panetoolconfiguration](#BKMK_organization_msdyn_panetoolconfiguration)
- [organization_msdyn_personasecurityrolemapping](#BKMK_organization_msdyn_personasecurityrolemapping)
- [organization_msdyn_postconfig](#BKMK_organization_msdyn_postconfig)
- [organization_msdyn_postruleconfig](#BKMK_organization_msdyn_postruleconfig)
- [organization_msdyn_predictivemodelscore](#BKMK_organization_msdyn_predictivemodelscore)
- [organization_msdyn_predictivescore](#BKMK_organization_msdyn_predictivescore)
- [organization_msdyn_presence](#BKMK_organization_msdyn_presence)
- [organization_msdyn_provider](#BKMK_organization_msdyn_provider)
- [organization_msdyn_rawinsightentitylink](#BKMK_organization_msdyn_rawinsightentitylink)
- [organization_msdyn_readtrackingenabledinfo](#BKMK_organization_msdyn_readtrackingenabledinfo)
- [organization_msdyn_recomputetracker](#BKMK_organization_msdyn_recomputetracker)
- [organization_msdyn_recurringsalesaction](#BKMK_organization_msdyn_recurringsalesaction)
- [organization_msdyn_recurringsalesactionv2](#BKMK_organization_msdyn_recurringsalesactionv2)
- [organization_msdyn_relationshipanalyticsmetadata](#BKMK_organization_msdyn_relationshipanalyticsmetadata)
- [organization_msdyn_routingrulesetsetting](#BKMK_organization_msdyn_routingrulesetsetting)
- [organization_msdyn_sabackupdiagnostic](#BKMK_organization_msdyn_sabackupdiagnostic)
- [organization_msdyn_sabatchruninstance](#BKMK_organization_msdyn_sabatchruninstance)
- [organization_msdyn_salesaccelerationinsight](#BKMK_organization_msdyn_salesaccelerationinsight)
- [organization_msdyn_salesaccelerationsettings](#BKMK_organization_msdyn_salesaccelerationsettings)
- [organization_msdyn_salesassignmentsetting](#BKMK_organization_msdyn_salesassignmentsetting)
- [organization_msdyn_salescopilotorgsettings](#BKMK_organization_msdyn_salescopilotorgsettings)
- [organization_msdyn_salesroutingdiagnostic](#BKMK_organization_msdyn_salesroutingdiagnostic)
- [organization_msdyn_saruninstance](#BKMK_organization_msdyn_saruninstance)
- [organization_msdyn_scienvironmentsettings](#BKMK_organization_msdyn_scienvironmentsettings)
- [organization_msdyn_segmentationsetting](#BKMK_organization_msdyn_segmentationsetting)
- [organization_msdyn_segmentattribute](#BKMK_organization_msdyn_segmentattribute)
- [organization_msdyn_segmentcatalogue](#BKMK_organization_msdyn_segmentcatalogue)
- [organization_msdyn_sentimentanalysis](#BKMK_organization_msdyn_sentimentanalysis)
- [organization_msdyn_servicecopilotplugin](#BKMK_organization_msdyn_servicecopilotplugin)
- [organization_msdyn_servicecopilotpluginaction](#BKMK_organization_msdyn_servicecopilotpluginaction)
- [organization_msdyn_servicecopilotpluginrole](#BKMK_organization_msdyn_servicecopilotpluginrole)
- [organization_msdyn_shareasconfiguration](#BKMK_organization_msdyn_shareasconfiguration)
- [organization_msdyn_sikeyvalueconfig](#BKMK_organization_msdyn_sikeyvalueconfig)
- [organization_msdyn_similarentitiesfeatureimportance](#BKMK_organization_msdyn_similarentitiesfeatureimportance)
- [organization_msdyn_smartassistconfig](#BKMK_organization_msdyn_smartassistconfig)
- [organization_msdyn_soundfile](#BKMK_organization_msdyn_soundfile)
- [organization_msdyn_suggestioninteraction](#BKMK_organization_msdyn_suggestioninteraction)
- [organization_msdyn_suggestionrequestpayload](#BKMK_organization_msdyn_suggestionrequestpayload)
- [organization_msdyn_suggestionsmodelsummary](#BKMK_organization_msdyn_suggestionsmodelsummary)
- [organization_msdyn_suggestionssetting](#BKMK_organization_msdyn_suggestionssetting)
- [organization_msdyn_surveysetting](#BKMK_organization_msdyn_surveysetting)
- [organization_msdyn_teamsdialeradminsettings](#BKMK_organization_msdyn_teamsdialeradminsettings)
- [organization_msdyn_unifiedroutingsetuptracker](#BKMK_organization_msdyn_unifiedroutingsetuptracker)
- [organization_msdyn_upgraderun](#BKMK_organization_msdyn_upgraderun)
- [organization_msdyn_upgradestep](#BKMK_organization_msdyn_upgradestep)
- [organization_msdyn_upgradeversion](#BKMK_organization_msdyn_upgradeversion)
- [organization_msdyn_usagemetric](#BKMK_organization_msdyn_usagemetric)
- [organization_msdyn_usagereporting](#BKMK_organization_msdyn_usagereporting)
- [organization_msdyn_usersetting](#BKMK_organization_msdyn_usersetting)
- [organization_msdyn_wallsavedquery](#BKMK_organization_msdyn_wallsavedquery)
- [organization_msdyn_wkwcolleaguesforcompany](#BKMK_organization_msdyn_wkwcolleaguesforcompany)
- [organization_msdyn_wkwcolleaguesforcontact](#BKMK_organization_msdyn_wkwcolleaguesforcontact)
- [organization_msdynmkt_eventmetadata_sdkmessageprocessingstep](#BKMK_organization_msdynmkt_eventmetadata_sdkmessageprocessingstep)
- [organization_opportunitysalesprocess](#BKMK_organization_opportunitysalesprocess)
- [organization_phonetocaseprocess](#BKMK_organization_phonetocaseprocess)
- [organization_price_levels](#BKMK_organization_price_levels)
- [organization_ProductAssociation](#BKMK_organization_ProductAssociation)
- [organization_products](#BKMK_organization_products)
- [organization_ProductSubstitute](#BKMK_organization_ProductSubstitute)
- [organization_resource_groups](#BKMK_organization_resource_groups)
- [organization_resource_specs](#BKMK_organization_resource_specs)
- [organization_resources](#BKMK_organization_resources)
- [organization_sales_literature](#BKMK_organization_sales_literature)
- [organization_services](#BKMK_organization_services)
- [organization_sites](#BKMK_organization_sites)
- [organization_uof_schedules](#BKMK_organization_uof_schedules)

### <a name="BKMK_dynamicproperty_organization"></a> dynamicproperty_organization

Many-To-One Relationship: [dynamicproperty dynamicproperty_organization](dynamicproperty.md#BKMK_dynamicproperty_organization)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicproperty`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`dynamicproperty_organization`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_DynamicPropertyAssociation_organization"></a> DynamicPropertyAssociation_organization

Many-To-One Relationship: [dynamicpropertyassociation DynamicPropertyAssociation_organization](dynamicpropertyassociation.md#BKMK_DynamicPropertyAssociation_organization)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyassociation`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`DynamicPropertyAssociation_organization`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_DynamicPropertyOptionSetItem_organization"></a> DynamicPropertyOptionSetItem_organization

Many-To-One Relationship: [dynamicpropertyoptionsetitem DynamicPropertyOptionSetItem_organization](dynamicpropertyoptionsetitem.md#BKMK_DynamicPropertyOptionSetItem_organization)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyoptionsetitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`DynamicPropertyOptionSetItem_organization`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementchannel_organization"></a> entitlementchannel_organization

Many-To-One Relationship: [entitlementchannel entitlementchannel_organization](entitlementchannel.md#BKMK_entitlementchannel_organization)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementchannel`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`entitlementchannel_organization`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplate_organization"></a> entitlementtemplate_organization

Many-To-One Relationship: [entitlementtemplate entitlementtemplate_organization](entitlementtemplate.md#BKMK_entitlementtemplate_organization)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementtemplate`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplate_organization`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementtemplatechannel_organization"></a> entitlementtemplatechannel_organization

Many-To-One Relationship: [entitlementtemplatechannel entitlementtemplatechannel_organization](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_organization)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementtemplatechannel`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`entitlementtemplatechannel_organization`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_competitors"></a> organization_competitors

Many-To-One Relationship: [competitor organization_competitors](competitor.md#BKMK_organization_competitors)

|Property|Value|
|---|---|
|ReferencingEntity|`competitor`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_competitors`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_constraint_based_groups"></a> organization_constraint_based_groups

Many-To-One Relationship: [constraintbasedgroup organization_constraint_based_groups](constraintbasedgroup.md#BKMK_organization_constraint_based_groups)

|Property|Value|
|---|---|
|ReferencingEntity|`constraintbasedgroup`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_constraint_based_groups`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_contract_templates"></a> organization_contract_templates

Many-To-One Relationship: [contracttemplate organization_contract_templates](contracttemplate.md#BKMK_organization_contract_templates)

|Property|Value|
|---|---|
|ReferencingEntity|`contracttemplate`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_contract_templates`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_discount_types"></a> organization_discount_types

Many-To-One Relationship: [discounttype organization_discount_types](discounttype.md#BKMK_organization_discount_types)

|Property|Value|
|---|---|
|ReferencingEntity|`discounttype`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_discount_types`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_equipment"></a> organization_equipment

Many-To-One Relationship: [equipment organization_equipment](equipment.md#BKMK_organization_equipment)

|Property|Value|
|---|---|
|ReferencingEntity|`equipment`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_equipment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_leadtoopportunitysalesprocess"></a> organization_leadtoopportunitysalesprocess

Many-To-One Relationship: [leadtoopportunitysalesprocess organization_leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md#BKMK_organization_leadtoopportunitysalesprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`leadtoopportunitysalesprocess`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_leadtoopportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_marketingformdisplayattributes"></a> organization_marketingformdisplayattributes

Many-To-One Relationship: [marketingformdisplayattributes organization_marketingformdisplayattributes](marketingformdisplayattributes.md#BKMK_organization_marketingformdisplayattributes)

|Property|Value|
|---|---|
|ReferencingEntity|`marketingformdisplayattributes`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_marketingformdisplayattributes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_accountkpiitem"></a> organization_msdyn_accountkpiitem

Many-To-One Relationship: [msdyn_accountkpiitem organization_msdyn_accountkpiitem](msdyn_accountkpiitem.md#BKMK_organization_msdyn_accountkpiitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_accountkpiitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_accountkpiitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_activityanalysiscleanupstate"></a> organization_msdyn_activityanalysiscleanupstate

Many-To-One Relationship: [msdyn_activityanalysiscleanupstate organization_msdyn_activityanalysiscleanupstate](msdyn_activityanalysiscleanupstate.md#BKMK_organization_msdyn_activityanalysiscleanupstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_activityanalysiscleanupstate`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_activityanalysiscleanupstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_activityanalysisconfig"></a> organization_msdyn_activityanalysisconfig

Many-To-One Relationship: [msdyn_activityanalysisconfig organization_msdyn_activityanalysisconfig](msdyn_activityanalysisconfig.md#BKMK_organization_msdyn_activityanalysisconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_activityanalysisconfig`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_activityanalysisconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_adaptivecardconfiguration"></a> organization_msdyn_adaptivecardconfiguration

Many-To-One Relationship: [msdyn_adaptivecardconfiguration organization_msdyn_adaptivecardconfiguration](msdyn_adaptivecardconfiguration.md#BKMK_organization_msdyn_adaptivecardconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_adaptivecardconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_adaptivecardconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_agentcopilotsetting"></a> organization_msdyn_agentcopilotsetting

Many-To-One Relationship: [msdyn_agentcopilotsetting organization_msdyn_agentcopilotsetting](msdyn_agentcopilotsetting.md#BKMK_organization_msdyn_agentcopilotsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentcopilotsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_agentcopilotsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_agentresourceforecasting"></a> organization_msdyn_agentresourceforecasting

Many-To-One Relationship: [msdyn_agentresourceforecasting organization_msdyn_agentresourceforecasting](msdyn_agentresourceforecasting.md#BKMK_organization_msdyn_agentresourceforecasting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentresourceforecasting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_agentresourceforecasting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_appcopilotconfiguration"></a> organization_msdyn_appcopilotconfiguration

Many-To-One Relationship: [msdyn_appcopilotconfiguration organization_msdyn_appcopilotconfiguration](msdyn_appcopilotconfiguration.md#BKMK_organization_msdyn_appcopilotconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appcopilotconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_appcopilotconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_attributeinfluencestatistics"></a> organization_msdyn_attributeinfluencestatistics

Many-To-One Relationship: [msdyn_attributeinfluencestatistics organization_msdyn_attributeinfluencestatistics](msdyn_attributeinfluencestatistics.md#BKMK_organization_msdyn_attributeinfluencestatistics)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_attributeinfluencestatistics`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_attributeinfluencestatistics`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_cannedmessage"></a> organization_msdyn_cannedmessage

Many-To-One Relationship: [msdyn_cannedmessage organization_msdyn_cannedmessage](msdyn_cannedmessage.md#BKMK_organization_msdyn_cannedmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_cannedmessage`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_cannedmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_caseenrichment"></a> organization_msdyn_caseenrichment

Many-To-One Relationship: [msdyn_caseenrichment organization_msdyn_caseenrichment](msdyn_caseenrichment.md#BKMK_organization_msdyn_caseenrichment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_caseenrichment`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_caseenrichment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_casefollowupandclosureconfiguration"></a> organization_msdyn_casefollowupandclosureconfiguration

Many-To-One Relationship: [msdyn_casefollowupandclosureconfiguration organization_msdyn_casefollowupandclosureconfiguration](msdyn_casefollowupandclosureconfiguration.md#BKMK_organization_msdyn_casefollowupandclosureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casefollowupandclosureconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_casefollowupandclosureconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_casesuggestionrequestpayload"></a> organization_msdyn_casesuggestionrequestpayload

Many-To-One Relationship: [msdyn_casesuggestionrequestpayload organization_msdyn_casesuggestionrequestpayload](msdyn_casesuggestionrequestpayload.md#BKMK_organization_msdyn_casesuggestionrequestpayload)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casesuggestionrequestpayload`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_casesuggestionrequestpayload`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_casetopic"></a> organization_msdyn_casetopic

Many-To-One Relationship: [msdyn_casetopic organization_msdyn_casetopic](msdyn_casetopic.md#BKMK_organization_msdyn_casetopic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casetopic`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_casetopic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_casetopic_incident"></a> organization_msdyn_casetopic_incident

Many-To-One Relationship: [msdyn_casetopic_incident organization_msdyn_casetopic_incident](msdyn_casetopic_incident.md#BKMK_organization_msdyn_casetopic_incident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casetopic_incident`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_casetopic_incident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_casetopicsetting"></a> organization_msdyn_casetopicsetting

Many-To-One Relationship: [msdyn_casetopicsetting organization_msdyn_casetopicsetting](msdyn_casetopicsetting.md#BKMK_organization_msdyn_casetopicsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casetopicsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_casetopicsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_casetopicsummary"></a> organization_msdyn_casetopicsummary

Many-To-One Relationship: [msdyn_casetopicsummary organization_msdyn_casetopicsummary](msdyn_casetopicsummary.md#BKMK_organization_msdyn_casetopicsummary)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_casetopicsummary`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_casetopicsummary`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_channelcapability"></a> organization_msdyn_channelcapability

Many-To-One Relationship: [msdyn_channelcapability organization_msdyn_channelcapability](msdyn_channelcapability.md#BKMK_organization_msdyn_channelcapability)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelcapability`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_channelcapability`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_ciprovider"></a> organization_msdyn_ciprovider

Many-To-One Relationship: [msdyn_ciprovider organization_msdyn_ciprovider](msdyn_ciprovider.md#BKMK_organization_msdyn_ciprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ciprovider`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_ciprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_contactkpiitem"></a> organization_msdyn_contactkpiitem

Many-To-One Relationship: [msdyn_contactkpiitem organization_msdyn_contactkpiitem](msdyn_contactkpiitem.md#BKMK_organization_msdyn_contactkpiitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactkpiitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_contactkpiitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_conversationsummaryinteraction"></a> organization_msdyn_conversationsummaryinteraction

Many-To-One Relationship: [msdyn_conversationsummaryinteraction organization_msdyn_conversationsummaryinteraction](msdyn_conversationsummaryinteraction.md#BKMK_organization_msdyn_conversationsummaryinteraction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsummaryinteraction`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_conversationsummaryinteraction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_conversationsummarysetting"></a> organization_msdyn_conversationsummarysetting

Many-To-One Relationship: [msdyn_conversationsummarysetting organization_msdyn_conversationsummarysetting](msdyn_conversationsummarysetting.md#BKMK_organization_msdyn_conversationsummarysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsummarysetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_conversationsummarysetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_conversationtopic"></a> organization_msdyn_conversationtopic

Many-To-One Relationship: [msdyn_conversationtopic organization_msdyn_conversationtopic](msdyn_conversationtopic.md#BKMK_organization_msdyn_conversationtopic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtopic`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_conversationtopic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_conversationtopic_conversation"></a> organization_msdyn_conversationtopic_conversation

Many-To-One Relationship: [msdyn_conversationtopic_conversation organization_msdyn_conversationtopic_conversation](msdyn_conversationtopic_conversation.md#BKMK_organization_msdyn_conversationtopic_conversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtopic_conversation`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_conversationtopic_conversation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_conversationtopicsetting"></a> organization_msdyn_conversationtopicsetting

Many-To-One Relationship: [msdyn_conversationtopicsetting organization_msdyn_conversationtopicsetting](msdyn_conversationtopicsetting.md#BKMK_organization_msdyn_conversationtopicsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtopicsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_conversationtopicsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_conversationtopicsummary"></a> organization_msdyn_conversationtopicsummary

Many-To-One Relationship: [msdyn_conversationtopicsummary organization_msdyn_conversationtopicsummary](msdyn_conversationtopicsummary.md#BKMK_organization_msdyn_conversationtopicsummary)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtopicsummary`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_conversationtopicsummary`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_copilotinteraction"></a> organization_msdyn_copilotinteraction

Many-To-One Relationship: [msdyn_copilotinteraction organization_msdyn_copilotinteraction](msdyn_copilotinteraction.md#BKMK_organization_msdyn_copilotinteraction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotinteraction`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_copilotinteraction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_copilotsummarizationsetting"></a> organization_msdyn_copilotsummarizationsetting

Many-To-One Relationship: [msdyn_copilotsummarizationsetting organization_msdyn_copilotsummarizationsetting](msdyn_copilotsummarizationsetting.md#BKMK_organization_msdyn_copilotsummarizationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotsummarizationsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_copilotsummarizationsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_cskeyvalueconfig"></a> organization_msdyn_cskeyvalueconfig

Many-To-One Relationship: [msdyn_cskeyvalueconfig organization_msdyn_cskeyvalueconfig](msdyn_cskeyvalueconfig.md#BKMK_organization_msdyn_cskeyvalueconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_cskeyvalueconfig`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_cskeyvalueconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_customeremailcommunication"></a> organization_msdyn_customeremailcommunication

Many-To-One Relationship: [msdyn_customeremailcommunication organization_msdyn_customeremailcommunication](msdyn_customeremailcommunication.md#BKMK_organization_msdyn_customeremailcommunication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customeremailcommunication`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_customeremailcommunication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_customerfeedbacksurvey"></a> organization_msdyn_customerfeedbacksurvey

Many-To-One Relationship: [msdyn_customerfeedbacksurvey organization_msdyn_customerfeedbacksurvey](msdyn_customerfeedbacksurvey.md#BKMK_organization_msdyn_customerfeedbacksurvey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerfeedbacksurvey`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_customerfeedbacksurvey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_customerfeedbacksurveyinvite"></a> organization_msdyn_customerfeedbacksurveyinvite

Many-To-One Relationship: [msdyn_customerfeedbacksurveyinvite organization_msdyn_customerfeedbacksurveyinvite](msdyn_customerfeedbacksurveyinvite.md#BKMK_organization_msdyn_customerfeedbacksurveyinvite)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerfeedbacksurveyinvite`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_customerfeedbacksurveyinvite`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_customerfeedbacksurveyresponse"></a> organization_msdyn_customerfeedbacksurveyresponse

Many-To-One Relationship: [msdyn_customerfeedbacksurveyresponse organization_msdyn_customerfeedbacksurveyresponse](msdyn_customerfeedbacksurveyresponse.md#BKMK_organization_msdyn_customerfeedbacksurveyresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerfeedbacksurveyresponse`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_customerfeedbacksurveyresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dailyaccountkpiitem"></a> organization_msdyn_dailyaccountkpiitem

Many-To-One Relationship: [msdyn_dailyaccountkpiitem organization_msdyn_dailyaccountkpiitem](msdyn_dailyaccountkpiitem.md#BKMK_organization_msdyn_dailyaccountkpiitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailyaccountkpiitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dailyaccountkpiitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dailycontactkpiitem"></a> organization_msdyn_dailycontactkpiitem

Many-To-One Relationship: [msdyn_dailycontactkpiitem organization_msdyn_dailycontactkpiitem](msdyn_dailycontactkpiitem.md#BKMK_organization_msdyn_dailycontactkpiitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailycontactkpiitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dailycontactkpiitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dailyleadkpiitem"></a> organization_msdyn_dailyleadkpiitem

Many-To-One Relationship: [msdyn_dailyleadkpiitem organization_msdyn_dailyleadkpiitem](msdyn_dailyleadkpiitem.md#BKMK_organization_msdyn_dailyleadkpiitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailyleadkpiitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dailyleadkpiitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dailyopportunitykpiitem"></a> organization_msdyn_dailyopportunitykpiitem

Many-To-One Relationship: [msdyn_dailyopportunitykpiitem organization_msdyn_dailyopportunitykpiitem](msdyn_dailyopportunitykpiitem.md#BKMK_organization_msdyn_dailyopportunitykpiitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailyopportunitykpiitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dailyopportunitykpiitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_copilot"></a> organization_msdyn_dataanalyticsreport_copilot

Many-To-One Relationship: [msdyn_dataanalyticsreport_copilot organization_msdyn_dataanalyticsreport_copilot](msdyn_dataanalyticsreport_copilot.md#BKMK_organization_msdyn_dataanalyticsreport_copilot)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_copilot`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_copilot`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_csrmanager"></a> organization_msdyn_dataanalyticsreport_csrmanager

Many-To-One Relationship: [msdyn_dataanalyticsreport_csrmanager organization_msdyn_dataanalyticsreport_csrmanager](msdyn_dataanalyticsreport_csrmanager.md#BKMK_organization_msdyn_dataanalyticsreport_csrmanager)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_csrmanager`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_csrmanager`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_email"></a> organization_msdyn_dataanalyticsreport_email

Many-To-One Relationship: [msdyn_dataanalyticsreport_email organization_msdyn_dataanalyticsreport_email](msdyn_dataanalyticsreport_email.md#BKMK_organization_msdyn_dataanalyticsreport_email)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_email`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_email`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_forecast"></a> organization_msdyn_dataanalyticsreport_forecast

Many-To-One Relationship: [msdyn_dataanalyticsreport_forecast organization_msdyn_dataanalyticsreport_forecast](msdyn_dataanalyticsreport_forecast.md#BKMK_organization_msdyn_dataanalyticsreport_forecast)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_forecast`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_forecast`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_ksinsights"></a> organization_msdyn_dataanalyticsreport_ksinsights

Many-To-One Relationship: [msdyn_dataanalyticsreport_ksinsights organization_msdyn_dataanalyticsreport_ksinsights](msdyn_dataanalyticsreport_ksinsights.md#BKMK_organization_msdyn_dataanalyticsreport_ksinsights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_ksinsights`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_ksinsights`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_mc"></a> organization_msdyn_dataanalyticsreport_mc

Many-To-One Relationship: [msdyn_dataanalyticsreport_mc organization_msdyn_dataanalyticsreport_mc](msdyn_dataanalyticsreport_mc.md#BKMK_organization_msdyn_dataanalyticsreport_mc)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_mc`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_mc`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_oc"></a> organization_msdyn_dataanalyticsreport_oc

Many-To-One Relationship: [msdyn_dataanalyticsreport_oc organization_msdyn_dataanalyticsreport_oc](msdyn_dataanalyticsreport_oc.md#BKMK_organization_msdyn_dataanalyticsreport_oc)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_oc`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_oc`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_oc_rt"></a> organization_msdyn_dataanalyticsreport_oc_rt

Many-To-One Relationship: [msdyn_dataanalyticsreport_oc_rt organization_msdyn_dataanalyticsreport_oc_rt](msdyn_dataanalyticsreport_oc_rt.md#BKMK_organization_msdyn_dataanalyticsreport_oc_rt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_oc_rt`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_oc_rt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_sareporting"></a> organization_msdyn_dataanalyticsreport_sareporting

Many-To-One Relationship: [msdyn_dataanalyticsreport_sareporting organization_msdyn_dataanalyticsreport_sareporting](msdyn_dataanalyticsreport_sareporting.md#BKMK_organization_msdyn_dataanalyticsreport_sareporting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_sareporting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_sareporting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_sutreporting"></a> organization_msdyn_dataanalyticsreport_sutreporting

Many-To-One Relationship: [msdyn_dataanalyticsreport_sutreporting organization_msdyn_dataanalyticsreport_sutreporting](msdyn_dataanalyticsreport_sutreporting.md#BKMK_organization_msdyn_dataanalyticsreport_sutreporting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_sutreporting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_sutreporting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_dataanalyticsreport_ur_recordrouting_rt"></a> organization_msdyn_dataanalyticsreport_ur_recordrouting_rt

Many-To-One Relationship: [msdyn_dataanalyticsreport_ur_recordrouting_rt organization_msdyn_dataanalyticsreport_ur_recordrouting_rt](msdyn_dataanalyticsreport_ur_recordrouting_rt.md#BKMK_organization_msdyn_dataanalyticsreport_ur_recordrouting_rt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport_ur_recordrouting_rt`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_dataanalyticsreport_ur_recordrouting_rt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_databaseversion"></a> organization_msdyn_databaseversion

Many-To-One Relationship: [msdyn_databaseversion organization_msdyn_databaseversion](msdyn_databaseversion.md#BKMK_organization_msdyn_databaseversion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_databaseversion`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_databaseversion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_datahygienesettinginfo"></a> organization_msdyn_datahygienesettinginfo

Many-To-One Relationship: [msdyn_datahygienesettinginfo organization_msdyn_datahygienesettinginfo](msdyn_datahygienesettinginfo.md#BKMK_organization_msdyn_datahygienesettinginfo)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_datahygienesettinginfo`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_datahygienesettinginfo`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_datainsightsandanalyticsfeature"></a> organization_msdyn_datainsightsandanalyticsfeature

Many-To-One Relationship: [msdyn_datainsightsandanalyticsfeature organization_msdyn_datainsightsandanalyticsfeature](msdyn_datainsightsandanalyticsfeature.md#BKMK_organization_msdyn_datainsightsandanalyticsfeature)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_datainsightsandanalyticsfeature`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_datainsightsandanalyticsfeature`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_derivedinsightsrelatedentity"></a> organization_msdyn_derivedinsightsrelatedentity

Many-To-One Relationship: [msdyn_derivedinsightsrelatedentity organization_msdyn_derivedinsightsrelatedentity](msdyn_derivedinsightsrelatedentity.md#BKMK_organization_msdyn_derivedinsightsrelatedentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_derivedinsightsrelatedentity`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_derivedinsightsrelatedentity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_digitalsellingactivetask"></a> organization_msdyn_digitalsellingactivetask

Many-To-One Relationship: [msdyn_digitalsellingactivetask organization_msdyn_digitalsellingactivetask](msdyn_digitalsellingactivetask.md#BKMK_organization_msdyn_digitalsellingactivetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_digitalsellingactivetask`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_digitalsellingactivetask`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_digitalsellingcompletedtask"></a> organization_msdyn_digitalsellingcompletedtask

Many-To-One Relationship: [msdyn_digitalsellingcompletedtask organization_msdyn_digitalsellingcompletedtask](msdyn_digitalsellingcompletedtask.md#BKMK_organization_msdyn_digitalsellingcompletedtask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_digitalsellingcompletedtask`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_digitalsellingcompletedtask`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_distributedlock"></a> organization_msdyn_distributedlock

Many-To-One Relationship: [msdyn_distributedlock organization_msdyn_distributedlock](msdyn_distributedlock.md#BKMK_organization_msdyn_distributedlock)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_distributedlock`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_distributedlock`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_duplicatedetectionpluginrun"></a> organization_msdyn_duplicatedetectionpluginrun

Many-To-One Relationship: [msdyn_duplicatedetectionpluginrun organization_msdyn_duplicatedetectionpluginrun](msdyn_duplicatedetectionpluginrun.md#BKMK_organization_msdyn_duplicatedetectionpluginrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_duplicatedetectionpluginrun`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_duplicatedetectionpluginrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_entityderivedinsight"></a> organization_msdyn_entityderivedinsight

Many-To-One Relationship: [msdyn_entityderivedinsight organization_msdyn_entityderivedinsight](msdyn_entityderivedinsight.md#BKMK_organization_msdyn_entityderivedinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityderivedinsight`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_entityderivedinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_forecastingcache"></a> organization_msdyn_forecastingcache

Many-To-One Relationship: [msdyn_forecastingcache organization_msdyn_forecastingcache](msdyn_forecastingcache.md#BKMK_organization_msdyn_forecastingcache)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastingcache`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_forecastingcache`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_forecastpredictionstatus"></a> organization_msdyn_forecastpredictionstatus

Many-To-One Relationship: [msdyn_forecastpredictionstatus organization_msdyn_forecastpredictionstatus](msdyn_forecastpredictionstatus.md#BKMK_organization_msdyn_forecastpredictionstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastpredictionstatus`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_forecastpredictionstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_forecastsettingsandsummary"></a> organization_msdyn_forecastsettingsandsummary

Many-To-One Relationship: [msdyn_forecastsettingsandsummary organization_msdyn_forecastsettingsandsummary](msdyn_forecastsettingsandsummary.md#BKMK_organization_msdyn_forecastsettingsandsummary)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastsettingsandsummary`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_forecastsettingsandsummary`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_inboxcardconfiguration"></a> organization_msdyn_inboxcardconfiguration

Many-To-One Relationship: [msdyn_inboxcardconfiguration organization_msdyn_inboxcardconfiguration](msdyn_inboxcardconfiguration.md#BKMK_organization_msdyn_inboxcardconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inboxcardconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_inboxcardconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_inboxconfiguration"></a> organization_msdyn_inboxconfiguration

Many-To-One Relationship: [msdyn_inboxconfiguration organization_msdyn_inboxconfiguration](msdyn_inboxconfiguration.md#BKMK_organization_msdyn_inboxconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inboxconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_inboxconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_inboxentityconfig"></a> organization_msdyn_inboxentityconfig

Many-To-One Relationship: [msdyn_inboxentityconfig organization_msdyn_inboxentityconfig](msdyn_inboxentityconfig.md#BKMK_organization_msdyn_inboxentityconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inboxentityconfig`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_inboxentityconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_iottocaseprocess"></a> organization_msdyn_iottocaseprocess

Many-To-One Relationship: [msdyn_iottocaseprocess organization_msdyn_iottocaseprocess](msdyn_iottocaseprocess.md#BKMK_organization_msdyn_iottocaseprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iottocaseprocess`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_iottocaseprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_kbenrichment"></a> organization_msdyn_kbenrichment

Many-To-One Relationship: [msdyn_kbenrichment organization_msdyn_kbenrichment](msdyn_kbenrichment.md#BKMK_organization_msdyn_kbenrichment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_kbenrichment`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_kbenrichment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_kbkeywordsdescsuggestionsetting"></a> organization_msdyn_kbkeywordsdescsuggestionsetting

Many-To-One Relationship: [msdyn_kbkeywordsdescsuggestionsetting organization_msdyn_kbkeywordsdescsuggestionsetting](msdyn_kbkeywordsdescsuggestionsetting.md#BKMK_organization_msdyn_kbkeywordsdescsuggestionsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_kbkeywordsdescsuggestionsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_kbkeywordsdescsuggestionsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_leadhygienesetting"></a> organization_msdyn_leadhygienesetting

Many-To-One Relationship: [msdyn_leadhygienesetting organization_msdyn_leadhygienesetting](msdyn_leadhygienesetting.md#BKMK_organization_msdyn_leadhygienesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_leadhygienesetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_leadhygienesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_leadkpiitem"></a> organization_msdyn_leadkpiitem

Many-To-One Relationship: [msdyn_leadkpiitem organization_msdyn_leadkpiitem](msdyn_leadkpiitem.md#BKMK_organization_msdyn_leadkpiitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_leadkpiitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_leadkpiitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_linkedentityattributevalidity"></a> organization_msdyn_linkedentityattributevalidity

Many-To-One Relationship: [msdyn_linkedentityattributevalidity organization_msdyn_linkedentityattributevalidity](msdyn_linkedentityattributevalidity.md#BKMK_organization_msdyn_linkedentityattributevalidity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_linkedentityattributevalidity`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_linkedentityattributevalidity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_maskingrule"></a> organization_msdyn_maskingrule

Many-To-One Relationship: [msdyn_maskingrule organization_msdyn_maskingrule](msdyn_maskingrule.md#BKMK_organization_msdyn_maskingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_maskingrule`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_maskingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_mostcontacted"></a> organization_msdyn_mostcontacted

Many-To-One Relationship: [msdyn_mostcontacted organization_msdyn_mostcontacted](msdyn_mostcontacted.md#BKMK_organization_msdyn_mostcontacted)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontacted`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_mostcontacted`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_mostcontactedby"></a> organization_msdyn_mostcontactedby

Many-To-One Relationship: [msdyn_mostcontactedby organization_msdyn_mostcontactedby](msdyn_mostcontactedby.md#BKMK_organization_msdyn_mostcontactedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontactedby`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_mostcontactedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_nextaction"></a> organization_msdyn_nextaction

Many-To-One Relationship: [msdyn_nextaction organization_msdyn_nextaction](msdyn_nextaction.md#BKMK_organization_msdyn_nextaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nextaction`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_nextaction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_occhannelconfiguration"></a> organization_msdyn_occhannelconfiguration

Many-To-One Relationship: [msdyn_occhannelconfiguration organization_msdyn_occhannelconfiguration](msdyn_occhannelconfiguration.md#BKMK_organization_msdyn_occhannelconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_occhannelconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_occhannelstateconfiguration"></a> organization_msdyn_occhannelstateconfiguration

Many-To-One Relationship: [msdyn_occhannelstateconfiguration organization_msdyn_occhannelstateconfiguration](msdyn_occhannelstateconfiguration.md#BKMK_organization_msdyn_occhannelstateconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelstateconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_occhannelstateconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_oclocalizationdata"></a> organization_msdyn_oclocalizationdata

Many-To-One Relationship: [msdyn_oclocalizationdata organization_msdyn_oclocalizationdata](msdyn_oclocalizationdata.md#BKMK_organization_msdyn_oclocalizationdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclocalizationdata`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_oclocalizationdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_ocsystemmessage"></a> organization_msdyn_ocsystemmessage

Many-To-One Relationship: [msdyn_ocsystemmessage organization_msdyn_ocsystemmessage](msdyn_ocsystemmessage.md#BKMK_organization_msdyn_ocsystemmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsystemmessage`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_ocsystemmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_octag"></a> organization_msdyn_octag

Many-To-One Relationship: [msdyn_octag organization_msdyn_octag](msdyn_octag.md#BKMK_organization_msdyn_octag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_octag`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_octag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_odosfeaturemetadata"></a> organization_msdyn_odosfeaturemetadata

Many-To-One Relationship: [msdyn_odosfeaturemetadata organization_msdyn_odosfeaturemetadata](msdyn_odosfeaturemetadata.md#BKMK_organization_msdyn_odosfeaturemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_odosfeaturemetadata`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_odosfeaturemetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_odosmetadata"></a> organization_msdyn_odosmetadata

Many-To-One Relationship: [msdyn_odosmetadata organization_msdyn_odosmetadata](msdyn_odosmetadata.md#BKMK_organization_msdyn_odosmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_odosmetadata`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_odosmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_omnichannelconfiguration"></a> organization_msdyn_omnichannelconfiguration

Many-To-One Relationship: [msdyn_omnichannelconfiguration organization_msdyn_omnichannelconfiguration](msdyn_omnichannelconfiguration.md#BKMK_organization_msdyn_omnichannelconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_omnichannelconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_opportunitykpiitem"></a> organization_msdyn_opportunitykpiitem

Many-To-One Relationship: [msdyn_opportunitykpiitem organization_msdyn_opportunitykpiitem](msdyn_opportunitykpiitem.md#BKMK_organization_msdyn_opportunitykpiitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_opportunitykpiitem`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_opportunitykpiitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_paneconfiguration"></a> organization_msdyn_paneconfiguration

Many-To-One Relationship: [msdyn_paneconfiguration organization_msdyn_paneconfiguration](msdyn_paneconfiguration.md#BKMK_organization_msdyn_paneconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paneconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_paneconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_panetabconfiguration"></a> organization_msdyn_panetabconfiguration

Many-To-One Relationship: [msdyn_panetabconfiguration organization_msdyn_panetabconfiguration](msdyn_panetabconfiguration.md#BKMK_organization_msdyn_panetabconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_panetabconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_panetabconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_panetoolconfiguration"></a> organization_msdyn_panetoolconfiguration

Many-To-One Relationship: [msdyn_panetoolconfiguration organization_msdyn_panetoolconfiguration](msdyn_panetoolconfiguration.md#BKMK_organization_msdyn_panetoolconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_panetoolconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_panetoolconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_personasecurityrolemapping"></a> organization_msdyn_personasecurityrolemapping

Many-To-One Relationship: [msdyn_personasecurityrolemapping organization_msdyn_personasecurityrolemapping](msdyn_personasecurityrolemapping.md#BKMK_organization_msdyn_personasecurityrolemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_personasecurityrolemapping`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_personasecurityrolemapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_postconfig"></a> organization_msdyn_postconfig

Many-To-One Relationship: [msdyn_postconfig organization_msdyn_postconfig](msdyn_postconfig.md#BKMK_organization_msdyn_postconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postconfig`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_postconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_postruleconfig"></a> organization_msdyn_postruleconfig

Many-To-One Relationship: [msdyn_postruleconfig organization_msdyn_postruleconfig](msdyn_postruleconfig.md#BKMK_organization_msdyn_postruleconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postruleconfig`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_postruleconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_predictivemodelscore"></a> organization_msdyn_predictivemodelscore

Many-To-One Relationship: [msdyn_predictivemodelscore organization_msdyn_predictivemodelscore](msdyn_predictivemodelscore.md#BKMK_organization_msdyn_predictivemodelscore)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictivemodelscore`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_predictivemodelscore`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_predictivescore"></a> organization_msdyn_predictivescore

Many-To-One Relationship: [msdyn_predictivescore organization_msdyn_predictivescore](msdyn_predictivescore.md#BKMK_organization_msdyn_predictivescore)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictivescore`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_predictivescore`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_presence"></a> organization_msdyn_presence

Many-To-One Relationship: [msdyn_presence organization_msdyn_presence](msdyn_presence.md#BKMK_organization_msdyn_presence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_presence`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_presence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_provider"></a> organization_msdyn_provider

Many-To-One Relationship: [msdyn_provider organization_msdyn_provider](msdyn_provider.md#BKMK_organization_msdyn_provider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_provider`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_provider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_rawinsightentitylink"></a> organization_msdyn_rawinsightentitylink

Many-To-One Relationship: [msdyn_rawinsightentitylink organization_msdyn_rawinsightentitylink](msdyn_rawinsightentitylink.md#BKMK_organization_msdyn_rawinsightentitylink)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rawinsightentitylink`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_rawinsightentitylink`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_readtrackingenabledinfo"></a> organization_msdyn_readtrackingenabledinfo

Many-To-One Relationship: [msdyn_readtrackingenabledinfo organization_msdyn_readtrackingenabledinfo](msdyn_readtrackingenabledinfo.md#BKMK_organization_msdyn_readtrackingenabledinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtrackingenabledinfo`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_readtrackingenabledinfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_recomputetracker"></a> organization_msdyn_recomputetracker

Many-To-One Relationship: [msdyn_recomputetracker organization_msdyn_recomputetracker](msdyn_recomputetracker.md#BKMK_organization_msdyn_recomputetracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recomputetracker`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_recomputetracker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_recurringsalesaction"></a> organization_msdyn_recurringsalesaction

Many-To-One Relationship: [msdyn_recurringsalesaction organization_msdyn_recurringsalesaction](msdyn_recurringsalesaction.md#BKMK_organization_msdyn_recurringsalesaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recurringsalesaction`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_recurringsalesaction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_recurringsalesactionv2"></a> organization_msdyn_recurringsalesactionv2

Many-To-One Relationship: [msdyn_recurringsalesactionv2 organization_msdyn_recurringsalesactionv2](msdyn_recurringsalesactionv2.md#BKMK_organization_msdyn_recurringsalesactionv2)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recurringsalesactionv2`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_recurringsalesactionv2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_relationshipanalyticsmetadata"></a> organization_msdyn_relationshipanalyticsmetadata

Many-To-One Relationship: [msdyn_relationshipanalyticsmetadata organization_msdyn_relationshipanalyticsmetadata](msdyn_relationshipanalyticsmetadata.md#BKMK_organization_msdyn_relationshipanalyticsmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_relationshipanalyticsmetadata`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_relationshipanalyticsmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_routingrulesetsetting"></a> organization_msdyn_routingrulesetsetting

Many-To-One Relationship: [msdyn_routingrulesetsetting organization_msdyn_routingrulesetsetting](msdyn_routingrulesetsetting.md#BKMK_organization_msdyn_routingrulesetsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingrulesetsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_routingrulesetsetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_sabackupdiagnostic"></a> organization_msdyn_sabackupdiagnostic

Many-To-One Relationship: [msdyn_sabackupdiagnostic organization_msdyn_sabackupdiagnostic](msdyn_sabackupdiagnostic.md#BKMK_organization_msdyn_sabackupdiagnostic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sabackupdiagnostic`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_sabackupdiagnostic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_sabatchruninstance"></a> organization_msdyn_sabatchruninstance

Many-To-One Relationship: [msdyn_sabatchruninstance organization_msdyn_sabatchruninstance](msdyn_sabatchruninstance.md#BKMK_organization_msdyn_sabatchruninstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sabatchruninstance`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_sabatchruninstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_salesaccelerationinsight"></a> organization_msdyn_salesaccelerationinsight

Many-To-One Relationship: [msdyn_salesaccelerationinsight organization_msdyn_salesaccelerationinsight](msdyn_salesaccelerationinsight.md#BKMK_organization_msdyn_salesaccelerationinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesaccelerationinsight`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_salesaccelerationinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_salesaccelerationsettings"></a> organization_msdyn_salesaccelerationsettings

Many-To-One Relationship: [msdyn_salesaccelerationsettings organization_msdyn_salesaccelerationsettings](msdyn_salesaccelerationsettings.md#BKMK_organization_msdyn_salesaccelerationsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesaccelerationsettings`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_salesaccelerationsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_salesassignmentsetting"></a> organization_msdyn_salesassignmentsetting

Many-To-One Relationship: [msdyn_salesassignmentsetting organization_msdyn_salesassignmentsetting](msdyn_salesassignmentsetting.md#BKMK_organization_msdyn_salesassignmentsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesassignmentsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_salesassignmentsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_salescopilotorgsettings"></a> organization_msdyn_salescopilotorgsettings

Many-To-One Relationship: [msdyn_salescopilotorgsettings organization_msdyn_salescopilotorgsettings](msdyn_salescopilotorgsettings.md#BKMK_organization_msdyn_salescopilotorgsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotorgsettings`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_salescopilotorgsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_salesroutingdiagnostic"></a> organization_msdyn_salesroutingdiagnostic

Many-To-One Relationship: [msdyn_salesroutingdiagnostic organization_msdyn_salesroutingdiagnostic](msdyn_salesroutingdiagnostic.md#BKMK_organization_msdyn_salesroutingdiagnostic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingdiagnostic`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_salesroutingdiagnostic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_saruninstance"></a> organization_msdyn_saruninstance

Many-To-One Relationship: [msdyn_saruninstance organization_msdyn_saruninstance](msdyn_saruninstance.md#BKMK_organization_msdyn_saruninstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_saruninstance`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_saruninstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_scienvironmentsettings"></a> organization_msdyn_scienvironmentsettings

Many-To-One Relationship: [msdyn_scienvironmentsettings organization_msdyn_scienvironmentsettings](msdyn_scienvironmentsettings.md#BKMK_organization_msdyn_scienvironmentsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scienvironmentsettings`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_scienvironmentsettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_segmentationsetting"></a> organization_msdyn_segmentationsetting

Many-To-One Relationship: [msdyn_segmentationsetting organization_msdyn_segmentationsetting](msdyn_segmentationsetting.md#BKMK_organization_msdyn_segmentationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_segmentationsetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_segmentationsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_segmentattribute"></a> organization_msdyn_segmentattribute

Many-To-One Relationship: [msdyn_segmentattribute organization_msdyn_segmentattribute](msdyn_segmentattribute.md#BKMK_organization_msdyn_segmentattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_segmentattribute`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_segmentattribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_segmentcatalogue"></a> organization_msdyn_segmentcatalogue

Many-To-One Relationship: [msdyn_segmentcatalogue organization_msdyn_segmentcatalogue](msdyn_segmentcatalogue.md#BKMK_organization_msdyn_segmentcatalogue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_segmentcatalogue`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_segmentcatalogue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_sentimentanalysis"></a> organization_msdyn_sentimentanalysis

Many-To-One Relationship: [msdyn_sentimentanalysis organization_msdyn_sentimentanalysis](msdyn_sentimentanalysis.md#BKMK_organization_msdyn_sentimentanalysis)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sentimentanalysis`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_sentimentanalysis`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_servicecopilotplugin"></a> organization_msdyn_servicecopilotplugin

Many-To-One Relationship: [msdyn_servicecopilotplugin organization_msdyn_servicecopilotplugin](msdyn_servicecopilotplugin.md#BKMK_organization_msdyn_servicecopilotplugin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotplugin`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_servicecopilotplugin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_servicecopilotpluginaction"></a> organization_msdyn_servicecopilotpluginaction

Many-To-One Relationship: [msdyn_servicecopilotpluginaction organization_msdyn_servicecopilotpluginaction](msdyn_servicecopilotpluginaction.md#BKMK_organization_msdyn_servicecopilotpluginaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotpluginaction`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_servicecopilotpluginaction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_servicecopilotpluginrole"></a> organization_msdyn_servicecopilotpluginrole

Many-To-One Relationship: [msdyn_servicecopilotpluginrole organization_msdyn_servicecopilotpluginrole](msdyn_servicecopilotpluginrole.md#BKMK_organization_msdyn_servicecopilotpluginrole)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicecopilotpluginrole`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_servicecopilotpluginrole`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_shareasconfiguration"></a> organization_msdyn_shareasconfiguration

Many-To-One Relationship: [msdyn_shareasconfiguration organization_msdyn_shareasconfiguration](msdyn_shareasconfiguration.md#BKMK_organization_msdyn_shareasconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_shareasconfiguration`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_shareasconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_sikeyvalueconfig"></a> organization_msdyn_sikeyvalueconfig

Many-To-One Relationship: [msdyn_sikeyvalueconfig organization_msdyn_sikeyvalueconfig](msdyn_sikeyvalueconfig.md#BKMK_organization_msdyn_sikeyvalueconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sikeyvalueconfig`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_sikeyvalueconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_similarentitiesfeatureimportance"></a> organization_msdyn_similarentitiesfeatureimportance

Many-To-One Relationship: [msdyn_similarentitiesfeatureimportance organization_msdyn_similarentitiesfeatureimportance](msdyn_similarentitiesfeatureimportance.md#BKMK_organization_msdyn_similarentitiesfeatureimportance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_similarentitiesfeatureimportance`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_similarentitiesfeatureimportance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_smartassistconfig"></a> organization_msdyn_smartassistconfig

Many-To-One Relationship: [msdyn_smartassistconfig organization_msdyn_smartassistconfig](msdyn_smartassistconfig.md#BKMK_organization_msdyn_smartassistconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smartassistconfig`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_smartassistconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_soundfile"></a> organization_msdyn_soundfile

Many-To-One Relationship: [msdyn_soundfile organization_msdyn_soundfile](msdyn_soundfile.md#BKMK_organization_msdyn_soundfile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_soundfile`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_soundfile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_suggestioninteraction"></a> organization_msdyn_suggestioninteraction

Many-To-One Relationship: [msdyn_suggestioninteraction organization_msdyn_suggestioninteraction](msdyn_suggestioninteraction.md#BKMK_organization_msdyn_suggestioninteraction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestioninteraction`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_suggestioninteraction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_suggestionrequestpayload"></a> organization_msdyn_suggestionrequestpayload

Many-To-One Relationship: [msdyn_suggestionrequestpayload organization_msdyn_suggestionrequestpayload](msdyn_suggestionrequestpayload.md#BKMK_organization_msdyn_suggestionrequestpayload)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionrequestpayload`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_suggestionrequestpayload`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_suggestionsmodelsummary"></a> organization_msdyn_suggestionsmodelsummary

Many-To-One Relationship: [msdyn_suggestionsmodelsummary organization_msdyn_suggestionsmodelsummary](msdyn_suggestionsmodelsummary.md#BKMK_organization_msdyn_suggestionsmodelsummary)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionsmodelsummary`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_suggestionsmodelsummary`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_suggestionssetting"></a> organization_msdyn_suggestionssetting

Many-To-One Relationship: [msdyn_suggestionssetting organization_msdyn_suggestionssetting](msdyn_suggestionssetting.md#BKMK_organization_msdyn_suggestionssetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionssetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_suggestionssetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_surveysetting"></a> organization_msdyn_surveysetting

Many-To-One Relationship: [msdyn_surveysetting organization_msdyn_surveysetting](msdyn_surveysetting.md#BKMK_organization_msdyn_surveysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_surveysetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_surveysetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_teamsdialeradminsettings"></a> organization_msdyn_teamsdialeradminsettings

Many-To-One Relationship: [msdyn_teamsdialeradminsettings organization_msdyn_teamsdialeradminsettings](msdyn_teamsdialeradminsettings.md#BKMK_organization_msdyn_teamsdialeradminsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamsdialeradminsettings`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_teamsdialeradminsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_unifiedroutingsetuptracker"></a> organization_msdyn_unifiedroutingsetuptracker

Many-To-One Relationship: [msdyn_unifiedroutingsetuptracker organization_msdyn_unifiedroutingsetuptracker](msdyn_unifiedroutingsetuptracker.md#BKMK_organization_msdyn_unifiedroutingsetuptracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingsetuptracker`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_unifiedroutingsetuptracker`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_upgraderun"></a> organization_msdyn_upgraderun

Many-To-One Relationship: [msdyn_upgraderun organization_msdyn_upgraderun](msdyn_upgraderun.md#BKMK_organization_msdyn_upgraderun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_upgraderun`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_upgraderun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_upgradestep"></a> organization_msdyn_upgradestep

Many-To-One Relationship: [msdyn_upgradestep organization_msdyn_upgradestep](msdyn_upgradestep.md#BKMK_organization_msdyn_upgradestep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_upgradestep`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_upgradestep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_upgradeversion"></a> organization_msdyn_upgradeversion

Many-To-One Relationship: [msdyn_upgradeversion organization_msdyn_upgradeversion](msdyn_upgradeversion.md#BKMK_organization_msdyn_upgradeversion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_upgradeversion`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_upgradeversion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_usagemetric"></a> organization_msdyn_usagemetric

Many-To-One Relationship: [msdyn_usagemetric organization_msdyn_usagemetric](msdyn_usagemetric.md#BKMK_organization_msdyn_usagemetric)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_usagemetric`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_usagemetric`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_usagereporting"></a> organization_msdyn_usagereporting

Many-To-One Relationship: [msdyn_usagereporting organization_msdyn_usagereporting](msdyn_usagereporting.md#BKMK_organization_msdyn_usagereporting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_usagereporting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_usagereporting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_usersetting"></a> organization_msdyn_usersetting

Many-To-One Relationship: [msdyn_usersetting organization_msdyn_usersetting](msdyn_usersetting.md#BKMK_organization_msdyn_usersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_usersetting`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_usersetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_wallsavedquery"></a> organization_msdyn_wallsavedquery

Many-To-One Relationship: [msdyn_wallsavedquery organization_msdyn_wallsavedquery](msdyn_wallsavedquery.md#BKMK_organization_msdyn_wallsavedquery)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wallsavedquery`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_wallsavedquery`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_wkwcolleaguesforcompany"></a> organization_msdyn_wkwcolleaguesforcompany

Many-To-One Relationship: [msdyn_wkwcolleaguesforcompany organization_msdyn_wkwcolleaguesforcompany](msdyn_wkwcolleaguesforcompany.md#BKMK_organization_msdyn_wkwcolleaguesforcompany)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wkwcolleaguesforcompany`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_wkwcolleaguesforcompany`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdyn_wkwcolleaguesforcontact"></a> organization_msdyn_wkwcolleaguesforcontact

Many-To-One Relationship: [msdyn_wkwcolleaguesforcontact organization_msdyn_wkwcolleaguesforcontact](msdyn_wkwcolleaguesforcontact.md#BKMK_organization_msdyn_wkwcolleaguesforcontact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wkwcolleaguesforcontact`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdyn_wkwcolleaguesforcontact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_msdynmkt_eventmetadata_sdkmessageprocessingstep"></a> organization_msdynmkt_eventmetadata_sdkmessageprocessingstep

Many-To-One Relationship: [msdynmkt_eventmetadata_sdkmessageprocessingstep organization_msdynmkt_eventmetadata_sdkmessageprocessingstep](msdynmkt_eventmetadata_sdkmessageprocessingstep.md#BKMK_organization_msdynmkt_eventmetadata_sdkmessageprocessingstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventmetadata_sdkmessageprocessingstep`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_msdynmkt_eventmetadata_sdkmessageprocessingstep`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_opportunitysalesprocess"></a> organization_opportunitysalesprocess

Many-To-One Relationship: [opportunitysalesprocess organization_opportunitysalesprocess](opportunitysalesprocess.md#BKMK_organization_opportunitysalesprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunitysalesprocess`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_opportunitysalesprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_phonetocaseprocess"></a> organization_phonetocaseprocess

Many-To-One Relationship: [phonetocaseprocess organization_phonetocaseprocess](phonetocaseprocess.md#BKMK_organization_phonetocaseprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`phonetocaseprocess`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_phonetocaseprocess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_price_levels"></a> organization_price_levels

Many-To-One Relationship: [pricelevel organization_price_levels](pricelevel.md#BKMK_organization_price_levels)

|Property|Value|
|---|---|
|ReferencingEntity|`pricelevel`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_price_levels`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_ProductAssociation"></a> organization_ProductAssociation

Many-To-One Relationship: [productassociation organization_ProductAssociation](productassociation.md#BKMK_organization_ProductAssociation)

|Property|Value|
|---|---|
|ReferencingEntity|`productassociation`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_ProductAssociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_products"></a> organization_products

Many-To-One Relationship: [product organization_products](product.md#BKMK_organization_products)

|Property|Value|
|---|---|
|ReferencingEntity|`product`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_products`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_ProductSubstitute"></a> organization_ProductSubstitute

Many-To-One Relationship: [productsubstitute organization_ProductSubstitute](productsubstitute.md#BKMK_organization_ProductSubstitute)

|Property|Value|
|---|---|
|ReferencingEntity|`productsubstitute`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_ProductSubstitute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_resource_groups"></a> organization_resource_groups

Many-To-One Relationship: [resourcegroup organization_resource_groups](resourcegroup.md#BKMK_organization_resource_groups)

|Property|Value|
|---|---|
|ReferencingEntity|`resourcegroup`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_resource_groups`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_resource_specs"></a> organization_resource_specs

Many-To-One Relationship: [resourcespec organization_resource_specs](resourcespec.md#BKMK_organization_resource_specs)

|Property|Value|
|---|---|
|ReferencingEntity|`resourcespec`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_resource_specs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_resources"></a> organization_resources

Many-To-One Relationship: [resource organization_resources](resource.md#BKMK_organization_resources)

|Property|Value|
|---|---|
|ReferencingEntity|`resource`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_resources`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_sales_literature"></a> organization_sales_literature

Many-To-One Relationship: [salesliterature organization_sales_literature](salesliterature.md#BKMK_organization_sales_literature)

|Property|Value|
|---|---|
|ReferencingEntity|`salesliterature`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_sales_literature`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_services"></a> organization_services

Many-To-One Relationship: [service organization_services](service.md#BKMK_organization_services)

|Property|Value|
|---|---|
|ReferencingEntity|`service`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_services`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_sites"></a> organization_sites

Many-To-One Relationship: [site organization_sites](site.md#BKMK_organization_sites)

|Property|Value|
|---|---|
|ReferencingEntity|`site`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_sites`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_organization_uof_schedules"></a> organization_uof_schedules

Many-To-One Relationship: [uomschedule organization_uof_schedules](uomschedule.md#BKMK_organization_uof_schedules)

|Property|Value|
|---|---|
|ReferencingEntity|`uomschedule`|
|ReferencingAttribute|`organizationid`|
|ReferencedEntityNavigationPropertyName|`organization_uof_schedules`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.organization?displayProperty=fullName>
