---
title: "Team table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Team table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Team table/entity reference

Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Team table extends the [Microsoft Dataverse Team table](/power-apps/developer/data-platform/reference/entities/team).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_msdynmkt_associatedevent"></a> msdynmkt_associatedevent

|Property|Value|
|---|---|
|Description|**If the team was created for the purpose of maintaining the list of (co-)organizers of an Event synchronized from Microsoft Teams, this field indicates which Event is associated with the team.**|
|DisplayName|**Associated event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_associatedevent`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_event|


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/team#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|opportunity|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdynmkt_msevtmgt_event_team_associatedevent](#BKMK_msdynmkt_msevtmgt_event_team_associatedevent)
- [opportunity_Teams](#BKMK_opportunity_Teams)

### <a name="BKMK_msdynmkt_msevtmgt_event_team_associatedevent"></a> msdynmkt_msevtmgt_event_team_associatedevent

One-To-Many Relationship: [msevtmgt_event msdynmkt_msevtmgt_event_team_associatedevent](msevtmgt_event.md#BKMK_msdynmkt_msevtmgt_event_team_associatedevent)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msdynmkt_associatedevent`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_associatedevent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_Teams"></a> opportunity_Teams

One-To-Many Relationship: [opportunity opportunity_Teams](opportunity.md#BKMK_opportunity_Teams)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_alertsubscription_team_owningteam](#BKMK_adx_alertsubscription_team_owningteam)
- [lead_owning_team](#BKMK_lead_owning_team)
- [li_inmail_team_owningteam](#BKMK_li_inmail_team_owningteam)
- [li_message_team_owningteam](#BKMK_li_message_team_owningteam)
- [li_pointdrivepresentationviewed_team_owningteam](#BKMK_li_pointdrivepresentationviewed_team_owningteam)
- [msdyn_bookingalert_team_owningteam](#BKMK_msdyn_bookingalert_team_owningteam)
- [msdyn_copilottranscript_team_owningteam](#BKMK_msdyn_copilottranscript_team_owningteam)
- [msdyn_ocliveworkitem_team_owningteam](#BKMK_msdyn_ocliveworkitem_team_owningteam)
- [msdyn_ocoutboundmessage_team_owningteam](#BKMK_msdyn_ocoutboundmessage_team_owningteam)
- [msdyn_ocsession_team_owningteam](#BKMK_msdyn_ocsession_team_owningteam)
- [msdyn_ocvoicemail_team_owningteam](#BKMK_msdyn_ocvoicemail_team_owningteam)
- [msdyn_team_msdyn_salesroutingrun_ownerassigned](#BKMK_msdyn_team_msdyn_salesroutingrun_ownerassigned)
- [msdyn_team_msdyn_salesroutingrun_previousowner](#BKMK_msdyn_team_msdyn_salesroutingrun_previousowner)
- [msdyncrm_team_msdyncrm_designerfeatureavailability_team](#BKMK_msdyncrm_team_msdyncrm_designerfeatureavailability_team)
- [msfp_alert_team_owningteam](#BKMK_msfp_alert_team_owningteam)
- [msfp_surveyinvite_team_owningteam](#BKMK_msfp_surveyinvite_team_owningteam)
- [msfp_surveyresponse_team_owningteam](#BKMK_msfp_surveyresponse_team_owningteam)
- [team_activitymonitor](#BKMK_team_activitymonitor)
- [team_adminsettingsentity](#BKMK_team_adminsettingsentity)
- [team_adx_ad](#BKMK_team_adx_ad)
- [team_adx_adplacement](#BKMK_team_adx_adplacement)
- [team_adx_botconsumer](#BKMK_team_adx_botconsumer)
- [team_adx_casedeflection](#BKMK_team_adx_casedeflection)
- [team_adx_cloudflowconsumer](#BKMK_team_adx_cloudflowconsumer)
- [team_adx_communityforum](#BKMK_team_adx_communityforum)
- [team_adx_communityforumaccesspermission](#BKMK_team_adx_communityforumaccesspermission)
- [team_adx_communityforumalert](#BKMK_team_adx_communityforumalert)
- [team_adx_communityforumannouncement](#BKMK_team_adx_communityforumannouncement)
- [team_adx_communityforumpost](#BKMK_team_adx_communityforumpost)
- [team_adx_communityforumthread](#BKMK_team_adx_communityforumthread)
- [team_adx_contentaccesslevel](#BKMK_team_adx_contentaccesslevel)
- [team_adx_contentsnippet](#BKMK_team_adx_contentsnippet)
- [team_adx_forumthreadtype](#BKMK_team_adx_forumthreadtype)
- [team_adx_pagealert](#BKMK_team_adx_pagealert)
- [team_adx_pagenotification](#BKMK_team_adx_pagenotification)
- [team_adx_pagetag](#BKMK_team_adx_pagetag)
- [team_adx_pagetemplate](#BKMK_team_adx_pagetemplate)
- [team_adx_poll](#BKMK_team_adx_poll)
- [team_adx_polloption](#BKMK_team_adx_polloption)
- [team_adx_pollplacement](#BKMK_team_adx_pollplacement)
- [team_adx_pollsubmission](#BKMK_team_adx_pollsubmission)
- [team_adx_portallanguage](#BKMK_team_adx_portallanguage)
- [team_adx_publishingstate](#BKMK_team_adx_publishingstate)
- [team_adx_publishingstatetransitionrule](#BKMK_team_adx_publishingstatetransitionrule)
- [team_adx_redirect](#BKMK_team_adx_redirect)
- [team_adx_shortcut](#BKMK_team_adx_shortcut)
- [team_adx_sitemarker](#BKMK_team_adx_sitemarker)
- [team_adx_sitemigrationchunk](#BKMK_team_adx_sitemigrationchunk)
- [team_adx_sitemigrationrun](#BKMK_team_adx_sitemigrationrun)
- [team_adx_sitesetting](#BKMK_team_adx_sitesetting)
- [team_adx_tag](#BKMK_team_adx_tag)
- [team_adx_urlhistory](#BKMK_team_adx_urlhistory)
- [team_adx_webfile](#BKMK_team_adx_webfile)
- [team_adx_webfilelog](#BKMK_team_adx_webfilelog)
- [team_adx_webform](#BKMK_team_adx_webform)
- [team_adx_weblink](#BKMK_team_adx_weblink)
- [team_adx_weblinkset](#BKMK_team_adx_weblinkset)
- [team_adx_webnotificationurl](#BKMK_team_adx_webnotificationurl)
- [team_adx_webpage](#BKMK_team_adx_webpage)
- [team_adx_webpageaccesscontrolrule](#BKMK_team_adx_webpageaccesscontrolrule)
- [team_adx_webpagehistory](#BKMK_team_adx_webpagehistory)
- [team_adx_webpagelog](#BKMK_team_adx_webpagelog)
- [team_adx_webrole](#BKMK_team_adx_webrole)
- [team_adx_website](#BKMK_team_adx_website)
- [team_adx_websiteaccess](#BKMK_team_adx_websiteaccess)
- [team_adx_websitelanguage](#BKMK_team_adx_websitelanguage)
- [team_adx_websitemigrationtracker](#BKMK_team_adx_websitemigrationtracker)
- [team_bookableresource](#BKMK_team_bookableresource)
- [team_bookableresourcebooking](#BKMK_team_bookableresourcebooking)
- [team_bookableresourcebookingheader](#BKMK_team_bookableresourcebookingheader)
- [team_bookableresourcecategory](#BKMK_team_bookableresourcecategory)
- [team_bookableresourcecategoryassn](#BKMK_team_bookableresourcecategoryassn)
- [team_bookableresourcecharacteristic](#BKMK_team_bookableresourcecharacteristic)
- [team_bookableresourcegroup](#BKMK_team_bookableresourcegroup)
- [team_bookingstatus](#BKMK_team_bookingstatus)
- [team_BulkOperation](#BKMK_team_BulkOperation)
- [team_bulkoperationlog](#BKMK_team_bulkoperationlog)
- [team_campaignactivity](#BKMK_team_campaignactivity)
- [team_campaignresponse](#BKMK_team_campaignresponse)
- [team_Campaigns](#BKMK_team_Campaigns)
- [team_characteristic](#BKMK_team_characteristic)
- [team_contractdetail](#BKMK_team_contractdetail)
- [team_DynamicPropertyInstance](#BKMK_team_DynamicPropertyInstance)
- [team_entitlement](#BKMK_team_entitlement)
- [team_entitlementchannel](#BKMK_team_entitlementchannel)
- [team_entitlemententityallocationtypemapping](#BKMK_team_entitlemententityallocationtypemapping)
- [team_federatedknowledgeconfiguration](#BKMK_team_federatedknowledgeconfiguration)
- [team_federatedknowledgeentityconfiguration](#BKMK_team_federatedknowledgeentityconfiguration)
- [team_incidentresolution](#BKMK_team_incidentresolution)
- [team_incidents](#BKMK_team_incidents)
- [team_invoicedetail](#BKMK_team_invoicedetail)
- [team_invoices](#BKMK_team_invoices)
- [team_knowledgearticleincident](#BKMK_team_knowledgearticleincident)
- [team_list](#BKMK_team_list)
- [team_listoperation](#BKMK_team_listoperation)
- [team_mscipriv_activitymappingmetadatabase](#BKMK_team_mscipriv_activitymappingmetadatabase)
- [team_mscipriv_additionalentityinfo](#BKMK_team_mscipriv_additionalentityinfo)
- [team_mscipriv_aibuildercallbacktesthook](#BKMK_team_mscipriv_aibuildercallbacktesthook)
- [team_mscipriv_aibuildermodelmetadata](#BKMK_team_mscipriv_aibuildermodelmetadata)
- [team_mscipriv_analysisinstanceconfig](#BKMK_team_mscipriv_analysisinstanceconfig)
- [team_mscipriv_analysismetadata](#BKMK_team_mscipriv_analysismetadata)
- [team_mscipriv_azuremlwebservice](#BKMK_team_mscipriv_azuremlwebservice)
- [team_mscipriv_businessunitconfiguration](#BKMK_team_mscipriv_businessunitconfiguration)
- [team_mscipriv_cdsamodelmetadata](#BKMK_team_mscipriv_cdsamodelmetadata)
- [team_mscipriv_clusterloadmetadata](#BKMK_team_mscipriv_clusterloadmetadata)
- [team_mscipriv_conflationcriteriastatistics](#BKMK_team_mscipriv_conflationcriteriastatistics)
- [team_mscipriv_conflationmetadata](#BKMK_team_mscipriv_conflationmetadata)
- [team_mscipriv_conflationrun](#BKMK_team_mscipriv_conflationrun)
- [team_mscipriv_conflationstatistics](#BKMK_team_mscipriv_conflationstatistics)
- [team_mscipriv_consentsettings](#BKMK_team_mscipriv_consentsettings)
- [team_mscipriv_dataflowmetadata](#BKMK_team_mscipriv_dataflowmetadata)
- [team_mscipriv_datapreparationmetadata](#BKMK_team_mscipriv_datapreparationmetadata)
- [team_mscipriv_dataqualityfeaturewisemetadata](#BKMK_team_mscipriv_dataqualityfeaturewisemetadata)
- [team_mscipriv_dataqualityoverview](#BKMK_team_mscipriv_dataqualityoverview)
- [team_mscipriv_dataqualityreport](#BKMK_team_mscipriv_dataqualityreport)
- [team_mscipriv_datasetcatalog](#BKMK_team_mscipriv_datasetcatalog)
- [team_mscipriv_datasourcemetadata](#BKMK_team_mscipriv_datasourcemetadata)
- [team_mscipriv_datatroubleshootingaccess](#BKMK_team_mscipriv_datatroubleshootingaccess)
- [team_mscipriv_dataverseentitydatacleanupjobinfo](#BKMK_team_mscipriv_dataverseentitydatacleanupjobinfo)
- [team_mscipriv_derivedentitymetadata](#BKMK_team_mscipriv_derivedentitymetadata)
- [team_mscipriv_diagnosticsetting](#BKMK_team_mscipriv_diagnosticsetting)
- [team_mscipriv_discoveredcdsamodel](#BKMK_team_mscipriv_discoveredcdsamodel)
- [team_mscipriv_discoveryoperation](#BKMK_team_mscipriv_discoveryoperation)
- [team_mscipriv_enrichmentmetadata](#BKMK_team_mscipriv_enrichmentmetadata)
- [team_mscipriv_enrichmentrun](#BKMK_team_mscipriv_enrichmentrun)
- [team_mscipriv_entityfiltermetadata](#BKMK_team_mscipriv_entityfiltermetadata)
- [team_mscipriv_exportconfig](#BKMK_team_mscipriv_exportconfig)
- [team_mscipriv_exportconfigreport](#BKMK_team_mscipriv_exportconfigreport)
- [team_mscipriv_exportedmoduleconfiguration](#BKMK_team_mscipriv_exportedmoduleconfiguration)
- [team_mscipriv_exportsettings](#BKMK_team_mscipriv_exportsettings)
- [team_mscipriv_featuretemplate](#BKMK_team_mscipriv_featuretemplate)
- [team_mscipriv_graphmetadata](#BKMK_team_mscipriv_graphmetadata)
- [team_mscipriv_hierarchymetadata](#BKMK_team_mscipriv_hierarchymetadata)
- [team_mscipriv_hostloadmetadata](#BKMK_team_mscipriv_hostloadmetadata)
- [team_mscipriv_importexportstatusmetadata](#BKMK_team_mscipriv_importexportstatusmetadata)
- [team_mscipriv_insightmetadata](#BKMK_team_mscipriv_insightmetadata)
- [team_mscipriv_insightsdataqualityreport](#BKMK_team_mscipriv_insightsdataqualityreport)
- [team_mscipriv_instancemetrics](#BKMK_team_mscipriv_instancemetrics)
- [team_mscipriv_instancepartnercatalog](#BKMK_team_mscipriv_instancepartnercatalog)
- [team_mscipriv_instancesearchconfiguration](#BKMK_team_mscipriv_instancesearchconfiguration)
- [team_mscipriv_instancesettings](#BKMK_team_mscipriv_instancesettings)
- [team_mscipriv_intelligenceworkflowmetadata](#BKMK_team_mscipriv_intelligenceworkflowmetadata)
- [team_mscipriv_intelligenceworkflowrunmetadata](#BKMK_team_mscipriv_intelligenceworkflowrunmetadata)
- [team_mscipriv_intelligenceworkspacemetadata](#BKMK_team_mscipriv_intelligenceworkspacemetadata)
- [team_mscipriv_keyvaultmetadata](#BKMK_team_mscipriv_keyvaultmetadata)
- [team_mscipriv_lightcdsamodelmetadata](#BKMK_team_mscipriv_lightcdsamodelmetadata)
- [team_mscipriv_logicappssubscribermetadata](#BKMK_team_mscipriv_logicappssubscribermetadata)
- [team_mscipriv_mappedsecretmetadata](#BKMK_team_mscipriv_mappedsecretmetadata)
- [team_mscipriv_measuremetadata](#BKMK_team_mscipriv_measuremetadata)
- [team_mscipriv_modelconfigmetadata](#BKMK_team_mscipriv_modelconfigmetadata)
- [team_mscipriv_moduleconfigurationreference](#BKMK_team_mscipriv_moduleconfigurationreference)
- [team_mscipriv_notificationcheckpoint](#BKMK_team_mscipriv_notificationcheckpoint)
- [team_mscipriv_packageimportmetadata](#BKMK_team_mscipriv_packageimportmetadata)
- [team_mscipriv_packagejobmetadata](#BKMK_team_mscipriv_packagejobmetadata)
- [team_mscipriv_packagemetadata](#BKMK_team_mscipriv_packagemetadata)
- [team_mscipriv_platforminstancemapping](#BKMK_team_mscipriv_platforminstancemapping)
- [team_mscipriv_powerplatformconnector](#BKMK_team_mscipriv_powerplatformconnector)
- [team_mscipriv_powerplatformrefreshsignalmetadata](#BKMK_team_mscipriv_powerplatformrefreshsignalmetadata)
- [team_mscipriv_preenrichmentmetadata](#BKMK_team_mscipriv_preenrichmentmetadata)
- [team_mscipriv_profilestorestateinfo](#BKMK_team_mscipriv_profilestorestateinfo)
- [team_mscipriv_realtimeaggregatedstats](#BKMK_team_mscipriv_realtimeaggregatedstats)
- [team_mscipriv_realtimem3configuration](#BKMK_team_mscipriv_realtimem3configuration)
- [team_mscipriv_realtimem3searchconfiguration](#BKMK_team_mscipriv_realtimem3searchconfiguration)
- [team_mscipriv_realtimepluginmetadata](#BKMK_team_mscipriv_realtimepluginmetadata)
- [team_mscipriv_realtimesystemtablemetadata](#BKMK_team_mscipriv_realtimesystemtablemetadata)
- [team_mscipriv_realtimetablemetadata](#BKMK_team_mscipriv_realtimetablemetadata)
- [team_mscipriv_refreshhistorymetadata](#BKMK_team_mscipriv_refreshhistorymetadata)
- [team_mscipriv_refreshschedulebase](#BKMK_team_mscipriv_refreshschedulebase)
- [team_mscipriv_refreshstatehistorymetadata](#BKMK_team_mscipriv_refreshstatehistorymetadata)
- [team_mscipriv_relationshipmetadata](#BKMK_team_mscipriv_relationshipmetadata)
- [team_mscipriv_reportmetadata](#BKMK_team_mscipriv_reportmetadata)
- [team_mscipriv_resetinstancehistory](#BKMK_team_mscipriv_resetinstancehistory)
- [team_mscipriv_resourcemetadata](#BKMK_team_mscipriv_resourcemetadata)
- [team_mscipriv_runtimerealtimem3metadata](#BKMK_team_mscipriv_runtimerealtimem3metadata)
- [team_mscipriv_segmentmetadata](#BKMK_team_mscipriv_segmentmetadata)
- [team_mscipriv_semanticentitymappingmetadata](#BKMK_team_mscipriv_semanticentitymappingmetadata)
- [team_mscipriv_sparkjobexecutionmetadata](#BKMK_team_mscipriv_sparkjobexecutionmetadata)
- [team_mscipriv_systemintegrationmigrationtrackinginfo](#BKMK_team_mscipriv_systemintegrationmigrationtrackinginfo)
- [team_mscipriv_templatedmeasuremetadata](#BKMK_team_mscipriv_templatedmeasuremetadata)
- [team_mscipriv_templatedsegmentmetadata](#BKMK_team_mscipriv_templatedsegmentmetadata)
- [team_mscipriv_transformmetadata](#BKMK_team_mscipriv_transformmetadata)
- [team_mscipriv_unifiedactivitymappinggroupmetadata](#BKMK_team_mscipriv_unifiedactivitymappinggroupmetadata)
- [team_msdyn_actioncardactionstat](#BKMK_team_msdyn_actioncardactionstat)
- [team_msdyn_actioncardregarding](#BKMK_team_msdyn_actioncardregarding)
- [team_msdyn_actioncardrolesetting](#BKMK_team_msdyn_actioncardrolesetting)
- [team_msdyn_actioncardstataggregation](#BKMK_team_msdyn_actioncardstataggregation)
- [team_msdyn_activeicdextension](#BKMK_team_msdyn_activeicdextension)
- [team_msdyn_actual](#BKMK_team_msdyn_actual)
- [team_msdyn_adminappstate](#BKMK_team_msdyn_adminappstate)
- [team_msdyn_agentcapacityprofileunit](#BKMK_team_msdyn_agentcapacityprofileunit)
- [team_msdyn_agentcapacityupdatehistory](#BKMK_team_msdyn_agentcapacityupdatehistory)
- [team_msdyn_agentchannelstate](#BKMK_team_msdyn_agentchannelstate)
- [team_msdyn_agentstatus](#BKMK_team_msdyn_agentstatus)
- [team_msdyn_agentstatushistory](#BKMK_team_msdyn_agentstatushistory)
- [team_msdyn_agreement](#BKMK_team_msdyn_agreement)
- [team_msdyn_agreementbookingdate](#BKMK_team_msdyn_agreementbookingdate)
- [team_msdyn_agreementbookingincident](#BKMK_team_msdyn_agreementbookingincident)
- [team_msdyn_agreementbookingproduct](#BKMK_team_msdyn_agreementbookingproduct)
- [team_msdyn_agreementbookingservice](#BKMK_team_msdyn_agreementbookingservice)
- [team_msdyn_agreementbookingservicetask](#BKMK_team_msdyn_agreementbookingservicetask)
- [team_msdyn_agreementbookingsetup](#BKMK_team_msdyn_agreementbookingsetup)
- [team_msdyn_agreementinvoicedate](#BKMK_team_msdyn_agreementinvoicedate)
- [team_msdyn_agreementinvoiceproduct](#BKMK_team_msdyn_agreementinvoiceproduct)
- [team_msdyn_agreementinvoicesetup](#BKMK_team_msdyn_agreementinvoicesetup)
- [team_msdyn_agreementsubstatus](#BKMK_team_msdyn_agreementsubstatus)
- [team_msdyn_aicontactsuggestion](#BKMK_team_msdyn_aicontactsuggestion)
- [team_msdyn_analytics](#BKMK_team_msdyn_analytics)
- [team_msdyn_analyticsadminsettings](#BKMK_team_msdyn_analyticsadminsettings)
- [team_msdyn_analyticsforcs](#BKMK_team_msdyn_analyticsforcs)
- [team_msdyn_appconfiguration](#BKMK_team_msdyn_appconfiguration)
- [team_msdyn_applicationextension](#BKMK_team_msdyn_applicationextension)
- [team_msdyn_applicationtabtemplate](#BKMK_team_msdyn_applicationtabtemplate)
- [team_msdyn_appprofilerolemapping](#BKMK_team_msdyn_appprofilerolemapping)
- [team_msdyn_appstate](#BKMK_team_msdyn_appstate)
- [team_msdyn_assetcategorytemplateassociation](#BKMK_team_msdyn_assetcategorytemplateassociation)
- [team_msdyn_assettemplateassociation](#BKMK_team_msdyn_assettemplateassociation)
- [team_msdyn_assignmentconfiguration](#BKMK_team_msdyn_assignmentconfiguration)
- [team_msdyn_assignmentconfigurationstep](#BKMK_team_msdyn_assignmentconfigurationstep)
- [team_msdyn_assignmentmap](#BKMK_team_msdyn_assignmentmap)
- [team_msdyn_assignmentrule](#BKMK_team_msdyn_assignmentrule)
- [team_msdyn_attribute](#BKMK_team_msdyn_attribute)
- [team_msdyn_attributevalue](#BKMK_team_msdyn_attributevalue)
- [team_msdyn_authenticationsettings](#BKMK_team_msdyn_authenticationsettings)
- [team_msdyn_authsettingsentry](#BKMK_team_msdyn_authsettingsentry)
- [team_msdyn_autocapturerule](#BKMK_team_msdyn_autocapturerule)
- [team_msdyn_autocapturesettings](#BKMK_team_msdyn_autocapturesettings)
- [team_msdyn_autonomouscasecreationrule](#BKMK_team_msdyn_autonomouscasecreationrule)
- [team_msdyn_bgjobledger](#BKMK_team_msdyn_bgjobledger)
- [team_msdyn_bookableresourceassociation](#BKMK_team_msdyn_bookableresourceassociation)
- [team_msdyn_bookableresourcebookingquicknote](#BKMK_team_msdyn_bookableresourcebookingquicknote)
- [team_msdyn_bookableresourcecapacityprofile](#BKMK_team_msdyn_bookableresourcecapacityprofile)
- [team_msdyn_bookingalertstatus](#BKMK_team_msdyn_bookingalertstatus)
- [team_msdyn_bookingchange](#BKMK_team_msdyn_bookingchange)
- [team_msdyn_bookingjournal](#BKMK_team_msdyn_bookingjournal)
- [team_msdyn_bookingrule](#BKMK_team_msdyn_bookingrule)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [team_msdyn_bookingtimestamp](#BKMK_team_msdyn_bookingtimestamp)
- [team_msdyn_botsession](#BKMK_team_msdyn_botsession)
- [team_msdyn_businessclosure](#BKMK_team_msdyn_businessclosure)
- [team_msdyn_callablecontext](#BKMK_team_msdyn_callablecontext)
- [team_msdyn_capacityprofile](#BKMK_team_msdyn_capacityprofile)
- [team_msdyn_cdsentityengagementctx](#BKMK_team_msdyn_cdsentityengagementctx)
- [team_msdyn_channel](#BKMK_team_msdyn_channel)
- [team_msdyn_channeldefinition](#BKMK_team_msdyn_channeldefinition)
- [team_msdyn_channeldefinitionconsent](#BKMK_team_msdyn_channeldefinitionconsent)
- [team_msdyn_channeldefinitionlocale](#BKMK_team_msdyn_channeldefinitionlocale)
- [team_msdyn_channelinstance](#BKMK_team_msdyn_channelinstance)
- [team_msdyn_channelinstanceaccount](#BKMK_team_msdyn_channelinstanceaccount)
- [team_msdyn_channelmessageattachment](#BKMK_team_msdyn_channelmessageattachment)
- [team_msdyn_channelmessagecontextpart](#BKMK_team_msdyn_channelmessagecontextpart)
- [team_msdyn_channelmessagepart](#BKMK_team_msdyn_channelmessagepart)
- [team_msdyn_channelprovider](#BKMK_team_msdyn_channelprovider)
- [team_msdyn_chatansweroption](#BKMK_team_msdyn_chatansweroption)
- [team_msdyn_chatquestionnaireresponse](#BKMK_team_msdyn_chatquestionnaireresponse)
- [team_msdyn_chatquestionnaireresponseitem](#BKMK_team_msdyn_chatquestionnaireresponseitem)
- [team_msdyn_chatwidgetlanguage](#BKMK_team_msdyn_chatwidgetlanguage)
- [team_msdyn_clientextension](#BKMK_team_msdyn_clientextension)
- [team_msdyn_configuration](#BKMK_team_msdyn_configuration)
- [team_msdyn_consoleapplicationnotificationfield](#BKMK_team_msdyn_consoleapplicationnotificationfield)
- [team_msdyn_consoleapplicationnotificationtemplate](#BKMK_team_msdyn_consoleapplicationnotificationtemplate)
- [team_msdyn_consoleapplicationsessiontemplate](#BKMK_team_msdyn_consoleapplicationsessiontemplate)
- [team_msdyn_consoleapplicationtemplate](#BKMK_team_msdyn_consoleapplicationtemplate)
- [team_msdyn_consoleapplicationtemplateparameter](#BKMK_team_msdyn_consoleapplicationtemplateparameter)
- [team_msdyn_consumingapplication](#BKMK_team_msdyn_consumingapplication)
- [team_msdyn_contactsuggestionrule](#BKMK_team_msdyn_contactsuggestionrule)
- [team_msdyn_contactsuggestionruleset](#BKMK_team_msdyn_contactsuggestionruleset)
- [team_msdyn_conversationaction](#BKMK_team_msdyn_conversationaction)
- [team_msdyn_conversationactionitem](#BKMK_team_msdyn_conversationactionitem)
- [team_msdyn_conversationactionlocale](#BKMK_team_msdyn_conversationactionlocale)
- [team_msdyn_conversationaggregatedinsights](#BKMK_team_msdyn_conversationaggregatedinsights)
- [team_msdyn_conversationcomment](#BKMK_team_msdyn_conversationcomment)
- [team_msdyn_conversationdata](#BKMK_team_msdyn_conversationdata)
- [team_msdyn_conversationinsight](#BKMK_team_msdyn_conversationinsight)
- [team_msdyn_conversationmessageblock](#BKMK_team_msdyn_conversationmessageblock)
- [team_msdyn_conversationparticipantinsights](#BKMK_team_msdyn_conversationparticipantinsights)
- [team_msdyn_conversationparticipantsentiment](#BKMK_team_msdyn_conversationparticipantsentiment)
- [team_msdyn_conversationquestion](#BKMK_team_msdyn_conversationquestion)
- [team_msdyn_conversationsegmentsentiment](#BKMK_team_msdyn_conversationsegmentsentiment)
- [team_msdyn_conversationsentiment](#BKMK_team_msdyn_conversationsentiment)
- [team_msdyn_conversationsignal](#BKMK_team_msdyn_conversationsignal)
- [team_msdyn_conversationsubject](#BKMK_team_msdyn_conversationsubject)
- [team_msdyn_conversationsummarysuggestion](#BKMK_team_msdyn_conversationsummarysuggestion)
- [team_msdyn_conversationsystemtag](#BKMK_team_msdyn_conversationsystemtag)
- [team_msdyn_conversationtag](#BKMK_team_msdyn_conversationtag)
- [team_msdyn_copilotagentpreference](#BKMK_team_msdyn_copilotagentpreference)
- [team_msdyn_copilotinteractiondata](#BKMK_team_msdyn_copilotinteractiondata)
- [team_msdyn_copilottranscriptdata](#BKMK_team_msdyn_copilottranscriptdata)
- [team_msdyn_crmconnection](#BKMK_team_msdyn_crmconnection)
- [team_msdyn_csadminconfig](#BKMK_team_msdyn_csadminconfig)
- [team_msdyn_customapirulesetconfiguration](#BKMK_team_msdyn_customapirulesetconfiguration)
- [team_msdyn_customengagementctx](#BKMK_team_msdyn_customengagementctx)
- [team_msdyn_customerasset](#BKMK_team_msdyn_customerasset)
- [team_msdyn_customerassetattachment](#BKMK_team_msdyn_customerassetattachment)
- [team_msdyn_customerassetcategory](#BKMK_team_msdyn_customerassetcategory)
- [team_msdyn_dataanalyticscustomizedreport](#BKMK_team_msdyn_dataanalyticscustomizedreport)
- [team_msdyn_dataanalyticsdataset](#BKMK_team_msdyn_dataanalyticsdataset)
- [team_msdyn_dataanalyticsreport](#BKMK_team_msdyn_dataanalyticsreport)
- [team_msdyn_dataanalyticsworkspace](#BKMK_team_msdyn_dataanalyticsworkspace)
- [team_msdyn_dealmanageraccess](#BKMK_team_msdyn_dealmanageraccess)
- [team_msdyn_dealmanagersettings](#BKMK_team_msdyn_dealmanagersettings)
- [team_msdyn_decisioncontract](#BKMK_team_msdyn_decisioncontract)
- [team_msdyn_decisionruleset](#BKMK_team_msdyn_decisionruleset)
- [team_msdyn_defextendedchannelinstance](#BKMK_team_msdyn_defextendedchannelinstance)
- [team_msdyn_defextendedchannelinstanceaccount](#BKMK_team_msdyn_defextendedchannelinstanceaccount)
- [team_msdyn_deletedconversation](#BKMK_team_msdyn_deletedconversation)
- [team_msdyn_diagnosticsdata](#BKMK_team_msdyn_diagnosticsdata)
- [team_msdyn_duplicateleadmapping](#BKMK_team_msdyn_duplicateleadmapping)
- [team_msdyn_effortpredictionresult](#BKMK_team_msdyn_effortpredictionresult)
- [team_msdyn_entitlementapplication](#BKMK_team_msdyn_entitlementapplication)
- [team_msdyn_entityattachment](#BKMK_team_msdyn_entityattachment)
- [team_msdyn_entityconfig](#BKMK_team_msdyn_entityconfig)
- [team_msdyn_entityconfiguration](#BKMK_team_msdyn_entityconfiguration)
- [team_msdyn_entityrankingrule](#BKMK_team_msdyn_entityrankingrule)
- [team_msdyn_entityroutingconfiguration](#BKMK_team_msdyn_entityroutingconfiguration)
- [team_msdyn_entityworkstreammap](#BKMK_team_msdyn_entityworkstreammap)
- [team_msdyn_extendedusersetting](#BKMK_team_msdyn_extendedusersetting)
- [team_msdyn_facebookengagementctx](#BKMK_team_msdyn_facebookengagementctx)
- [team_msdyn_fieldservicedemodatajob](#BKMK_team_msdyn_fieldservicedemodatajob)
- [team_msdyn_fieldservicesetting](#BKMK_team_msdyn_fieldservicesetting)
- [team_msdyn_fieldserviceslaconfiguration](#BKMK_team_msdyn_fieldserviceslaconfiguration)
- [team_msdyn_fieldservicesummaryconfiguration](#BKMK_team_msdyn_fieldservicesummaryconfiguration)
- [team_msdyn_flowcardtype](#BKMK_team_msdyn_flowcardtype)
- [team_msdyn_forecastconfiguration](#BKMK_team_msdyn_forecastconfiguration)
- [team_msdyn_forecastdefinition](#BKMK_team_msdyn_forecastdefinition)
- [team_msdyn_forecastinstance](#BKMK_team_msdyn_forecastinstance)
- [team_msdyn_forecastrecurrence](#BKMK_team_msdyn_forecastrecurrence)
- [team_msdyn_formmapping](#BKMK_team_msdyn_formmapping)
- [team_msdyn_functionallocation](#BKMK_team_msdyn_functionallocation)
- [team_msdyn_functionallocationtype](#BKMK_team_msdyn_functionallocationtype)
- [team_msdyn_gdprdata](#BKMK_team_msdyn_gdprdata)
- [team_msdyn_geofence](#BKMK_team_msdyn_geofence)
- [team_msdyn_geofenceevent](#BKMK_team_msdyn_geofenceevent)
- [team_msdyn_geofencingsettings](#BKMK_team_msdyn_geofencingsettings)
- [team_msdyn_guideauthorsession](#BKMK_team_msdyn_guideauthorsession)
- [team_msdyn_icdextension](#BKMK_team_msdyn_icdextension)
- [team_msdyn_icebreakersconfig](#BKMK_team_msdyn_icebreakersconfig)
- [team_msdyn_iermlmodel](#BKMK_team_msdyn_iermlmodel)
- [team_msdyn_iermltraining](#BKMK_team_msdyn_iermltraining)
- [team_msdyn_incidenttype](#BKMK_team_msdyn_incidenttype)
- [team_msdyn_incidenttype_requirementgroup](#BKMK_team_msdyn_incidenttype_requirementgroup)
- [team_msdyn_incidenttypecharacteristic](#BKMK_team_msdyn_incidenttypecharacteristic)
- [team_msdyn_incidenttypeproduct](#BKMK_team_msdyn_incidenttypeproduct)
- [team_msdyn_incidenttyperecommendationresult](#BKMK_team_msdyn_incidenttyperecommendationresult)
- [team_msdyn_incidenttyperecommendationrunhistory](#BKMK_team_msdyn_incidenttyperecommendationrunhistory)
- [team_msdyn_incidenttyperesolution](#BKMK_team_msdyn_incidenttyperesolution)
- [team_msdyn_incidenttypeservice](#BKMK_team_msdyn_incidenttypeservice)
- [team_msdyn_incidenttypeservicetask](#BKMK_team_msdyn_incidenttypeservicetask)
- [team_msdyn_incidenttypessetup](#BKMK_team_msdyn_incidenttypessetup)
- [team_msdyn_inspection](#BKMK_team_msdyn_inspection)
- [team_msdyn_inspectionattachment](#BKMK_team_msdyn_inspectionattachment)
- [team_msdyn_inspectiondefinition](#BKMK_team_msdyn_inspectiondefinition)
- [team_msdyn_inspectioninstance](#BKMK_team_msdyn_inspectioninstance)
- [team_msdyn_inspectionresponse](#BKMK_team_msdyn_inspectionresponse)
- [team_msdyn_insurance](#BKMK_team_msdyn_insurance)
- [team_msdyn_intent](#BKMK_team_msdyn_intent)
- [team_msdyn_inventoryadjustment](#BKMK_team_msdyn_inventoryadjustment)
- [team_msdyn_inventoryadjustmentproduct](#BKMK_team_msdyn_inventoryadjustmentproduct)
- [team_msdyn_inventoryjournal](#BKMK_team_msdyn_inventoryjournal)
- [team_msdyn_inventorytransfer](#BKMK_team_msdyn_inventorytransfer)
- [team_msdyn_iotalert](#BKMK_team_msdyn_iotalert)
- [team_msdyn_iotdevice](#BKMK_team_msdyn_iotdevice)
- [team_msdyn_iotdevicecategory](#BKMK_team_msdyn_iotdevicecategory)
- [team_msdyn_iotdevicecommand](#BKMK_team_msdyn_iotdevicecommand)
- [team_msdyn_iotdevicecommanddefinition](#BKMK_team_msdyn_iotdevicecommanddefinition)
- [team_msdyn_iotdevicedatahistory](#BKMK_team_msdyn_iotdevicedatahistory)
- [team_msdyn_iotdeviceproperty](#BKMK_team_msdyn_iotdeviceproperty)
- [team_msdyn_iotdeviceregistrationhistory](#BKMK_team_msdyn_iotdeviceregistrationhistory)
- [team_msdyn_iotdevicevisualizationconfiguration](#BKMK_team_msdyn_iotdevicevisualizationconfiguration)
- [team_msdyn_iotfieldmapping](#BKMK_team_msdyn_iotfieldmapping)
- [team_msdyn_iotpropertydefinition](#BKMK_team_msdyn_iotpropertydefinition)
- [team_msdyn_iotprovider](#BKMK_team_msdyn_iotprovider)
- [team_msdyn_iotproviderinstance](#BKMK_team_msdyn_iotproviderinstance)
- [team_msdyn_iotsettings](#BKMK_team_msdyn_iotsettings)
- [team_msdyn_jobsstate](#BKMK_team_msdyn_jobsstate)
- [team_msdyn_kpieventdata](#BKMK_team_msdyn_kpieventdata)
- [team_msdyn_kpieventdefinition](#BKMK_team_msdyn_kpieventdefinition)
- [team_msdyn_leadmodelconfig](#BKMK_team_msdyn_leadmodelconfig)
- [team_msdyn_lineengagementctx](#BKMK_team_msdyn_lineengagementctx)
- [team_msdyn_livechatconfig](#BKMK_team_msdyn_livechatconfig)
- [team_msdyn_livechatengagementctx](#BKMK_team_msdyn_livechatengagementctx)
- [team_msdyn_livechatwidgetlocation](#BKMK_team_msdyn_livechatwidgetlocation)
- [team_msdyn_liveconversation](#BKMK_team_msdyn_liveconversation)
- [team_msdyn_liveworkitemevent](#BKMK_team_msdyn_liveworkitemevent)
- [team_msdyn_liveworkstream](#BKMK_team_msdyn_liveworkstream)
- [team_msdyn_liveworkstreamcapacityprofile](#BKMK_team_msdyn_liveworkstreamcapacityprofile)
- [team_msdyn_locationtemplateassociation](#BKMK_team_msdyn_locationtemplateassociation)
- [team_msdyn_locationtypetemplateassociation](#BKMK_team_msdyn_locationtypetemplateassociation)
- [team_msdyn_lockstatus](#BKMK_team_msdyn_lockstatus)
- [team_msdyn_macrosession](#BKMK_team_msdyn_macrosession)
- [team_msdyn_masterentityroutingconfiguration](#BKMK_team_msdyn_masterentityroutingconfiguration)
- [team_msdyn_migrationtracker](#BKMK_team_msdyn_migrationtracker)
- [team_msdyn_mobilesource](#BKMK_team_msdyn_mobilesource)
- [team_msdyn_modelpreviewstatus](#BKMK_team_msdyn_modelpreviewstatus)
- [team_msdyn_mrappsession](#BKMK_team_msdyn_mrappsession)
- [team_msdyn_mrasjob](#BKMK_team_msdyn_mrasjob)
- [team_msdyn_mrfolder](#BKMK_team_msdyn_mrfolder)
- [team_msdyn_msteamssetting](#BKMK_team_msdyn_msteamssetting)
- [team_msdyn_notesanalysisconfig](#BKMK_team_msdyn_notesanalysisconfig)
- [team_msdyn_notificationfield](#BKMK_team_msdyn_notificationfield)
- [team_msdyn_notificationtemplate](#BKMK_team_msdyn_notificationtemplate)
- [team_msdyn_nottoexceed](#BKMK_team_msdyn_nottoexceed)
- [team_msdyn_objectanchor](#BKMK_team_msdyn_objectanchor)
- [team_msdyn_oc_geolocationprovider](#BKMK_team_msdyn_oc_geolocationprovider)
- [team_msdyn_ocagentassignedcustomapiprivilege](#BKMK_team_msdyn_ocagentassignedcustomapiprivilege)
- [team_msdyn_ocapplebusinessaccount](#BKMK_team_msdyn_ocapplebusinessaccount)
- [team_msdyn_ocapplemessagesforbusinessengagementctx](#BKMK_team_msdyn_ocapplemessagesforbusinessengagementctx)
- [team_msdyn_ocapplepay](#BKMK_team_msdyn_ocapplepay)
- [team_msdyn_ocautoblockrule](#BKMK_team_msdyn_ocautoblockrule)
- [team_msdyn_ocbotchannelregistration](#BKMK_team_msdyn_ocbotchannelregistration)
- [team_msdyn_ocbotchannelregistrationsecret](#BKMK_team_msdyn_ocbotchannelregistrationsecret)
- [team_msdyn_occarrier](#BKMK_team_msdyn_occarrier)
- [team_msdyn_occhannelapiconversationprivilege](#BKMK_team_msdyn_occhannelapiconversationprivilege)
- [team_msdyn_occhannelapimessageprivilege](#BKMK_team_msdyn_occhannelapimessageprivilege)
- [team_msdyn_occhannelapimethodmapping](#BKMK_team_msdyn_occhannelapimethodmapping)
- [team_msdyn_occommunicationprovidersetting](#BKMK_team_msdyn_occommunicationprovidersetting)
- [team_msdyn_occommunicationprovidersettingentry](#BKMK_team_msdyn_occommunicationprovidersettingentry)
- [team_msdyn_occustommessagingchannel](#BKMK_team_msdyn_occustommessagingchannel)
- [team_msdyn_ocexternalcontext](#BKMK_team_msdyn_ocexternalcontext)
- [team_msdyn_ocfbapplication](#BKMK_team_msdyn_ocfbapplication)
- [team_msdyn_ocfbpage](#BKMK_team_msdyn_ocfbpage)
- [team_msdyn_ocflaggedspam](#BKMK_team_msdyn_ocflaggedspam)
- [team_msdyn_ocgatekeeperengagementctx](#BKMK_team_msdyn_ocgatekeeperengagementctx)
- [team_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_team_msdyn_ocgooglebusinessmessagesagentaccount)
- [team_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_team_msdyn_ocgooglebusinessmessagesengagementctx)
- [team_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_team_msdyn_ocgooglebusinessmessagespartneraccount)
- [team_msdyn_oclanguage](#BKMK_team_msdyn_oclanguage)
- [team_msdyn_oclinechannelconfig](#BKMK_team_msdyn_oclinechannelconfig)
- [team_msdyn_ocliveworkitemcapacityprofile](#BKMK_team_msdyn_ocliveworkitemcapacityprofile)
- [team_msdyn_ocliveworkitemcharacteristic](#BKMK_team_msdyn_ocliveworkitemcharacteristic)
- [team_msdyn_ocliveworkitemcontextitem](#BKMK_team_msdyn_ocliveworkitemcontextitem)
- [team_msdyn_ocliveworkitemparticipant](#BKMK_team_msdyn_ocliveworkitemparticipant)
- [team_msdyn_ocliveworkitemsentiment](#BKMK_team_msdyn_ocliveworkitemsentiment)
- [team_msdyn_ocliveworkstreamcontextvariable](#BKMK_team_msdyn_ocliveworkstreamcontextvariable)
- [team_msdyn_ocoutboundconfiguration](#BKMK_team_msdyn_ocoutboundconfiguration)
- [team_msdyn_ocpaymentprofile](#BKMK_team_msdyn_ocpaymentprofile)
- [team_msdyn_ocphonecallengagementctx](#BKMK_team_msdyn_ocphonecallengagementctx)
- [team_msdyn_ocphonemusic](#BKMK_team_msdyn_ocphonemusic)
- [team_msdyn_ocphonenumber](#BKMK_team_msdyn_ocphonenumber)
- [team_msdyn_ocprovisioningstate](#BKMK_team_msdyn_ocprovisioningstate)
- [team_msdyn_ocrecording](#BKMK_team_msdyn_ocrecording)
- [team_msdyn_ocrequest](#BKMK_team_msdyn_ocrequest)
- [team_msdyn_ocrichobject](#BKMK_team_msdyn_ocrichobject)
- [team_msdyn_ocrichobjectmap](#BKMK_team_msdyn_ocrichobjectmap)
- [team_msdyn_ocruleitem](#BKMK_team_msdyn_ocruleitem)
- [team_msdyn_ocsentimentdailytopic](#BKMK_team_msdyn_ocsentimentdailytopic)
- [team_msdyn_ocsentimentdailytopickeyword](#BKMK_team_msdyn_ocsentimentdailytopickeyword)
- [team_msdyn_ocsentimentdailytopictrending](#BKMK_team_msdyn_ocsentimentdailytopictrending)
- [team_msdyn_ocsessioncharacteristic](#BKMK_team_msdyn_ocsessioncharacteristic)
- [team_msdyn_ocsessionparticipantevent](#BKMK_team_msdyn_ocsessionparticipantevent)
- [team_msdyn_ocsessionsentiment](#BKMK_team_msdyn_ocsessionsentiment)
- [team_msdyn_ocsimltraining](#BKMK_team_msdyn_ocsimltraining)
- [team_msdyn_ocsitdimportconfig](#BKMK_team_msdyn_ocsitdimportconfig)
- [team_msdyn_ocsitdskill](#BKMK_team_msdyn_ocsitdskill)
- [team_msdyn_ocsitrainingdata](#BKMK_team_msdyn_ocsitrainingdata)
- [team_msdyn_ocskillidentmlmodel](#BKMK_team_msdyn_ocskillidentmlmodel)
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
- [team_msdyn_omnichannelpersonalization](#BKMK_team_msdyn_omnichannelpersonalization)
- [team_msdyn_omnichannelqueue](#BKMK_team_msdyn_omnichannelqueue)
- [team_msdyn_omnichannelsyncconfig](#BKMK_team_msdyn_omnichannelsyncconfig)
- [team_msdyn_operatinghour](#BKMK_team_msdyn_operatinghour)
- [team_msdyn_opportunitymodelconfig](#BKMK_team_msdyn_opportunitymodelconfig)
- [team_msdyn_optimizationrequestbooking](#BKMK_team_msdyn_optimizationrequestbooking)
- [team_msdyn_optimizationrequestresource](#BKMK_team_msdyn_optimizationrequestresource)
- [team_msdyn_orderedobjective](#BKMK_team_msdyn_orderedobjective)
- [team_msdyn_orderinvoicingdate](#BKMK_team_msdyn_orderinvoicingdate)
- [team_msdyn_orderinvoicingproduct](#BKMK_team_msdyn_orderinvoicingproduct)
- [team_msdyn_orderinvoicingsetup](#BKMK_team_msdyn_orderinvoicingsetup)
- [team_msdyn_orderinvoicingsetupdate](#BKMK_team_msdyn_orderinvoicingsetupdate)
- [team_msdyn_orgchartnode](#BKMK_team_msdyn_orgchartnode)
- [team_msdyn_overflowactionconfig](#BKMK_team_msdyn_overflowactionconfig)
- [team_msdyn_payment](#BKMK_team_msdyn_payment)
- [team_msdyn_paymentdetail](#BKMK_team_msdyn_paymentdetail)
- [team_msdyn_paymentmethod](#BKMK_team_msdyn_paymentmethod)
- [team_msdyn_paymentterm](#BKMK_team_msdyn_paymentterm)
- [team_msdyn_personalmessage](#BKMK_team_msdyn_personalmessage)
- [team_msdyn_personalsoundsetting](#BKMK_team_msdyn_personalsoundsetting)
- [team_msdyn_playbookactivity](#BKMK_team_msdyn_playbookactivity)
- [team_msdyn_playbookactivityattribute](#BKMK_team_msdyn_playbookactivityattribute)
- [team_msdyn_playbookcategory](#BKMK_team_msdyn_playbookcategory)
- [team_msdyn_playbookinstance](#BKMK_team_msdyn_playbookinstance)
- [team_msdyn_playbooktemplate](#BKMK_team_msdyn_playbooktemplate)
- [team_msdyn_postalbum](#BKMK_team_msdyn_postalbum)
- [team_msdyn_postalcode](#BKMK_team_msdyn_postalcode)
- [team_msdyn_predictioncomputationoperation](#BKMK_team_msdyn_predictioncomputationoperation)
- [team_msdyn_predictionmodelstatus](#BKMK_team_msdyn_predictionmodelstatus)
- [team_msdyn_predictionscheduledoperation](#BKMK_team_msdyn_predictionscheduledoperation)
- [team_msdyn_predictivescoringsyncstatus](#BKMK_team_msdyn_predictivescoringsyncstatus)
- [team_msdyn_preferredagent](#BKMK_team_msdyn_preferredagent)
- [team_msdyn_preferredagentcustomeridentity](#BKMK_team_msdyn_preferredagentcustomeridentity)
- [team_msdyn_preferredagentroutedentity](#BKMK_team_msdyn_preferredagentroutedentity)
- [team_msdyn_priority](#BKMK_team_msdyn_priority)
- [team_msdyn_problematicasset](#BKMK_team_msdyn_problematicasset)
- [team_msdyn_problematicassetfeedback](#BKMK_team_msdyn_problematicassetfeedback)
- [team_msdyn_productivityactioninputparameter](#BKMK_team_msdyn_productivityactioninputparameter)
- [team_msdyn_productivityactionoutputparameter](#BKMK_team_msdyn_productivityactionoutputparameter)
- [team_msdyn_productivityagentscript](#BKMK_team_msdyn_productivityagentscript)
- [team_msdyn_productivityagentscriptstep](#BKMK_team_msdyn_productivityagentscriptstep)
- [team_msdyn_productivitymacroactiontemplate](#BKMK_team_msdyn_productivitymacroactiontemplate)
- [team_msdyn_productivitymacroconnector](#BKMK_team_msdyn_productivitymacroconnector)
- [team_msdyn_productivitymacrosolutionconfiguration](#BKMK_team_msdyn_productivitymacrosolutionconfiguration)
- [team_msdyn_productivityparameterdefinition](#BKMK_team_msdyn_productivityparameterdefinition)
- [team_msdyn_property](#BKMK_team_msdyn_property)
- [team_msdyn_propertyassetassociation](#BKMK_team_msdyn_propertyassetassociation)
- [team_msdyn_propertylocationassociation](#BKMK_team_msdyn_propertylocationassociation)
- [team_msdyn_propertylog](#BKMK_team_msdyn_propertylog)
- [team_msdyn_propertytemplateassociation](#BKMK_team_msdyn_propertytemplateassociation)
- [team_msdyn_purchaseorder](#BKMK_team_msdyn_purchaseorder)
- [team_msdyn_purchaseorderbill](#BKMK_team_msdyn_purchaseorderbill)
- [team_msdyn_purchaseorderproduct](#BKMK_team_msdyn_purchaseorderproduct)
- [team_msdyn_purchaseorderreceipt](#BKMK_team_msdyn_purchaseorderreceipt)
- [team_msdyn_purchaseorderreceiptproduct](#BKMK_team_msdyn_purchaseorderreceiptproduct)
- [team_msdyn_purchaseordersubstatus](#BKMK_team_msdyn_purchaseordersubstatus)
- [team_msdyn_questionsequence](#BKMK_team_msdyn_questionsequence)
- [team_msdyn_quotebookingincident](#BKMK_team_msdyn_quotebookingincident)
- [team_msdyn_quotebookingproduct](#BKMK_team_msdyn_quotebookingproduct)
- [team_msdyn_quotebookingservice](#BKMK_team_msdyn_quotebookingservice)
- [team_msdyn_quotebookingservicetask](#BKMK_team_msdyn_quotebookingservicetask)
- [team_msdyn_quotebookingsetup](#BKMK_team_msdyn_quotebookingsetup)
- [team_msdyn_quoteinvoicingproduct](#BKMK_team_msdyn_quoteinvoicingproduct)
- [team_msdyn_quoteinvoicingsetup](#BKMK_team_msdyn_quoteinvoicingsetup)
- [team_msdyn_readtracker](#BKMK_team_msdyn_readtracker)
- [team_msdyn_realtimescoring](#BKMK_team_msdyn_realtimescoring)
- [team_msdyn_realtimescoringoperation](#BKMK_team_msdyn_realtimescoringoperation)
- [team_msdyn_recording](#BKMK_team_msdyn_recording)
- [team_msdyn_relationshipinsightsunifiedconfig](#BKMK_team_msdyn_relationshipinsightsunifiedconfig)
- [team_msdyn_reportbookmark](#BKMK_team_msdyn_reportbookmark)
- [team_msdyn_requirementchange](#BKMK_team_msdyn_requirementchange)
- [team_msdyn_requirementcharacteristic](#BKMK_team_msdyn_requirementcharacteristic)
- [team_msdyn_requirementdependency](#BKMK_team_msdyn_requirementdependency)
- [team_msdyn_requirementgroup](#BKMK_team_msdyn_requirementgroup)
- [team_msdyn_requirementorganizationunit](#BKMK_team_msdyn_requirementorganizationunit)
- [team_msdyn_requirementrelationship](#BKMK_team_msdyn_requirementrelationship)
- [team_msdyn_requirementresourcecategory](#BKMK_team_msdyn_requirementresourcecategory)
- [team_msdyn_requirementresourcepreference](#BKMK_team_msdyn_requirementresourcepreference)
- [team_msdyn_requirementstatus](#BKMK_team_msdyn_requirementstatus)
- [team_msdyn_resolution](#BKMK_team_msdyn_resolution)
- [team_msdyn_resourcepaytype](#BKMK_team_msdyn_resourcepaytype)
- [team_msdyn_resourcerequirement](#BKMK_team_msdyn_resourcerequirement)
- [team_msdyn_resourcerequirementdetail](#BKMK_team_msdyn_resourcerequirementdetail)
- [team_msdyn_resourceterritory](#BKMK_team_msdyn_resourceterritory)
- [team_msdyn_rma](#BKMK_team_msdyn_rma)
- [team_msdyn_rmaproduct](#BKMK_team_msdyn_rmaproduct)
- [team_msdyn_rmareceipt](#BKMK_team_msdyn_rmareceipt)
- [team_msdyn_rmareceiptproduct](#BKMK_team_msdyn_rmareceiptproduct)
- [team_msdyn_rmasubstatus](#BKMK_team_msdyn_rmasubstatus)
- [team_msdyn_routingconfiguration](#BKMK_team_msdyn_routingconfiguration)
- [team_msdyn_routingconfigurationstep](#BKMK_team_msdyn_routingconfigurationstep)
- [team_msdyn_routingengineconfiguration](#BKMK_team_msdyn_routingengineconfiguration)
- [team_msdyn_routingjobconfiguration](#BKMK_team_msdyn_routingjobconfiguration)
- [team_msdyn_routingoptimizationrequest](#BKMK_team_msdyn_routingoptimizationrequest)
- [team_msdyn_routingprofileconfiguration](#BKMK_team_msdyn_routingprofileconfiguration)
- [team_msdyn_routingrequest](#BKMK_team_msdyn_routingrequest)
- [team_msdyn_rtv](#BKMK_team_msdyn_rtv)
- [team_msdyn_rtvproduct](#BKMK_team_msdyn_rtvproduct)
- [team_msdyn_rtvsubstatus](#BKMK_team_msdyn_rtvsubstatus)
- [team_msdyn_rulesetdependencymapping](#BKMK_team_msdyn_rulesetdependencymapping)
- [team_msdyn_salescopilotinsight](#BKMK_team_msdyn_salescopilotinsight)
- [team_msdyn_salesinsightssettings](#BKMK_team_msdyn_salesinsightssettings)
- [team_msdyn_salesocmessage](#BKMK_team_msdyn_salesocmessage)
- [team_msdyn_salesocsmstemplate](#BKMK_team_msdyn_salesocsmstemplate)
- [team_msdyn_salesroutingrun](#BKMK_team_msdyn_salesroutingrun)
- [team_msdyn_salessuggestion](#BKMK_team_msdyn_salessuggestion)
- [team_msdyn_salestag](#BKMK_team_msdyn_salestag)
- [team_msdyn_scenario](#BKMK_team_msdyn_scenario)
- [team_msdyn_scheduleboardsetting](#BKMK_team_msdyn_scheduleboardsetting)
- [team_msdyn_schedulingfeatureflag](#BKMK_team_msdyn_schedulingfeatureflag)
- [team_msdyn_sciconversation](#BKMK_team_msdyn_sciconversation)
- [team_msdyn_scicustomemailhighlight](#BKMK_team_msdyn_scicustomemailhighlight)
- [team_msdyn_scicustomhighlight](#BKMK_team_msdyn_scicustomhighlight)
- [team_msdyn_scicustompublisher](#BKMK_team_msdyn_scicustompublisher)
- [team_msdyn_sciusersettings](#BKMK_team_msdyn_sciusersettings)
- [team_msdyn_searchconfiguration](#BKMK_team_msdyn_searchconfiguration)
- [team_msdyn_segment](#BKMK_team_msdyn_segment)
- [team_msdyn_sequence](#BKMK_team_msdyn_sequence)
- [team_msdyn_sequencestat](#BKMK_team_msdyn_sequencestat)
- [team_msdyn_sequencetarget](#BKMK_team_msdyn_sequencetarget)
- [team_msdyn_sequencetargetstep](#BKMK_team_msdyn_sequencetargetstep)
- [team_msdyn_sequencetemplate](#BKMK_team_msdyn_sequencetemplate)
- [team_msdyn_serviceoneprovisioningrequest](#BKMK_team_msdyn_serviceoneprovisioningrequest)
- [team_msdyn_servicetasktype](#BKMK_team_msdyn_servicetasktype)
- [team_msdyn_sessiondata](#BKMK_team_msdyn_sessiondata)
- [team_msdyn_sessionevent](#BKMK_team_msdyn_sessionevent)
- [team_msdyn_sessionparticipant](#BKMK_team_msdyn_sessionparticipant)
- [team_msdyn_sessionparticipantdata](#BKMK_team_msdyn_sessionparticipantdata)
- [team_msdyn_sessiontemplate](#BKMK_team_msdyn_sessiontemplate)
- [team_msdyn_shipvia](#BKMK_team_msdyn_shipvia)
- [team_msdyn_siconfig](#BKMK_team_msdyn_siconfig)
- [team_msdyn_skillattachmentruleitem](#BKMK_team_msdyn_skillattachmentruleitem)
- [team_msdyn_skillattachmenttarget](#BKMK_team_msdyn_skillattachmenttarget)
- [team_msdyn_smsengagementctx](#BKMK_team_msdyn_smsengagementctx)
- [team_msdyn_smsnumber](#BKMK_team_msdyn_smsnumber)
- [team_msdyn_soundnotificationsetting](#BKMK_team_msdyn_soundnotificationsetting)
- [team_msdyn_submodeldefinition](#BKMK_team_msdyn_submodeldefinition)
- [team_msdyn_suggestionassignmentrule](#BKMK_team_msdyn_suggestionassignmentrule)
- [team_msdyn_suggestionprincipalobjectaccess](#BKMK_team_msdyn_suggestionprincipalobjectaccess)
- [team_msdyn_suggestionsellerpriority](#BKMK_team_msdyn_suggestionsellerpriority)
- [team_msdyn_surveyquestion](#BKMK_team_msdyn_surveyquestion)
- [team_msdyn_swarm](#BKMK_team_msdyn_swarm)
- [team_msdyn_swarmparticipant](#BKMK_team_msdyn_swarmparticipant)
- [team_msdyn_swarmparticipantrule](#BKMK_team_msdyn_swarmparticipantrule)
- [team_msdyn_swarmrole](#BKMK_team_msdyn_swarmrole)
- [team_msdyn_swarmskill](#BKMK_team_msdyn_swarmskill)
- [team_msdyn_swarmtemplate](#BKMK_team_msdyn_swarmtemplate)
- [team_msdyn_systemuserschedulersetting](#BKMK_team_msdyn_systemuserschedulersetting)
- [team_msdyn_taggedrecord](#BKMK_team_msdyn_taggedrecord)
- [team_msdyn_taxcode](#BKMK_team_msdyn_taxcode)
- [team_msdyn_taxcodedetail](#BKMK_team_msdyn_taxcodedetail)
- [team_msdyn_teamschannelengagementctx](#BKMK_team_msdyn_teamschannelengagementctx)
- [team_msdyn_teamsengagementctx](#BKMK_team_msdyn_teamsengagementctx)
- [team_msdyn_templateforproperties](#BKMK_team_msdyn_templateforproperties)
- [team_msdyn_templateparameter](#BKMK_team_msdyn_templateparameter)
- [team_msdyn_templatetags](#BKMK_team_msdyn_templatetags)
- [team_msdyn_timeentry](#BKMK_team_msdyn_timeentry)
- [team_msdyn_timeentrysetting](#BKMK_team_msdyn_timeentrysetting)
- [team_msdyn_timegroup](#BKMK_team_msdyn_timegroup)
- [team_msdyn_timegroupdetail](#BKMK_team_msdyn_timegroupdetail)
- [team_msdyn_timeoffrequest](#BKMK_team_msdyn_timeoffrequest)
- [team_msdyn_timespent](#BKMK_team_msdyn_timespent)
- [team_msdyn_trade](#BKMK_team_msdyn_trade)
- [team_msdyn_tradecoverage](#BKMK_team_msdyn_tradecoverage)
- [team_msdyn_trainingresult](#BKMK_team_msdyn_trainingresult)
- [team_msdyn_transactionorigin](#BKMK_team_msdyn_transactionorigin)
- [team_msdyn_transcript](#BKMK_team_msdyn_transcript)
- [team_msdyn_twitterengagementctx](#BKMK_team_msdyn_twitterengagementctx)
- [team_msdyn_unifiedroutingdiagnostic](#BKMK_team_msdyn_unifiedroutingdiagnostic)
- [team_msdyn_unifiedroutingrun](#BKMK_team_msdyn_unifiedroutingrun)
- [team_msdyn_untrackedappointment](#BKMK_team_msdyn_untrackedappointment)
- [team_msdyn_urnotificationtemplate](#BKMK_team_msdyn_urnotificationtemplate)
- [team_msdyn_urnotificationtemplatemapping](#BKMK_team_msdyn_urnotificationtemplatemapping)
- [team_msdyn_visitorjourney](#BKMK_team_msdyn_visitorjourney)
- [team_msdyn_vivacustomerlist](#BKMK_team_msdyn_vivacustomerlist)
- [team_msdyn_vivausersetting](#BKMK_team_msdyn_vivausersetting)
- [team_msdyn_voicechannelorganizationsetting](#BKMK_team_msdyn_voicechannelorganizationsetting)
- [team_msdyn_wallsavedqueryusersettings](#BKMK_team_msdyn_wallsavedqueryusersettings)
- [team_msdyn_warehouse](#BKMK_team_msdyn_warehouse)
- [team_msdyn_warranty](#BKMK_team_msdyn_warranty)
- [team_msdyn_wechatengagementctx](#BKMK_team_msdyn_wechatengagementctx)
- [team_msdyn_whatsappengagementctx](#BKMK_team_msdyn_whatsappengagementctx)
- [team_msdyn_wkwconfig](#BKMK_team_msdyn_wkwconfig)
- [team_msdyn_workhourtemplate](#BKMK_team_msdyn_workhourtemplate)
- [team_msdyn_workorder](#BKMK_team_msdyn_workorder)
- [team_msdyn_workordercharacteristic](#BKMK_team_msdyn_workordercharacteristic)
- [team_msdyn_workorderincident](#BKMK_team_msdyn_workorderincident)
- [team_msdyn_workordernte](#BKMK_team_msdyn_workordernte)
- [team_msdyn_workorderproduct](#BKMK_team_msdyn_workorderproduct)
- [team_msdyn_workorderresolution](#BKMK_team_msdyn_workorderresolution)
- [team_msdyn_workorderresourcerestriction](#BKMK_team_msdyn_workorderresourcerestriction)
- [team_msdyn_workorderservice](#BKMK_team_msdyn_workorderservice)
- [team_msdyn_workorderservicetask](#BKMK_team_msdyn_workorderservicetask)
- [team_msdyn_workordersubstatus](#BKMK_team_msdyn_workordersubstatus)
- [team_msdyn_workordertype](#BKMK_team_msdyn_workordertype)
- [team_msdyn_workqueuestate](#BKMK_team_msdyn_workqueuestate)
- [team_msdyn_workqueueusersetting](#BKMK_team_msdyn_workqueueusersetting)
- [team_msdynci_alternatekey](#BKMK_team_msdynci_alternatekey)
- [team_msdynci_contactprofile](#BKMK_team_msdynci_contactprofile)
- [team_msdynci_customermeasure](#BKMK_team_msdynci_customermeasure)
- [team_msdynci_customerprofile](#BKMK_team_msdynci_customerprofile)
- [team_msdynci_customerprofilesegment](#BKMK_team_msdynci_customerprofilesegment)
- [team_msdynci_enrichment](#BKMK_team_msdynci_enrichment)
- [team_msdynci_personalizationaction](#BKMK_team_msdynci_personalizationaction)
- [team_msdynci_personalizationcookie](#BKMK_team_msdynci_personalizationcookie)
- [team_msdynci_personalizationuser](#BKMK_team_msdynci_personalizationuser)
- [team_msdynci_personalizationview](#BKMK_team_msdynci_personalizationview)
- [team_msdynci_prediction](#BKMK_team_msdynci_prediction)
- [team_msdynci_segmentmembership](#BKMK_team_msdynci_segmentmembership)
- [team_msdynci_unifiedactivity](#BKMK_team_msdynci_unifiedactivity)
- [team_msdynci_unifiedcontact_alternatekey](#BKMK_team_msdynci_unifiedcontact_alternatekey)
- [team_msdynci_unifiedcontactprofile](#BKMK_team_msdynci_unifiedcontactprofile)
- [team_msdynci_unifiedcontactsegment](#BKMK_team_msdynci_unifiedcontactsegment)
- [team_msdyncrm_addtocalendarstyle](#BKMK_team_msdyncrm_addtocalendarstyle)
- [team_msdyncrm_appointmentactivity](#BKMK_team_msdyncrm_appointmentactivity)
- [team_msdyncrm_appointmentactivitymarketingtemplate](#BKMK_team_msdyncrm_appointmentactivitymarketingtemplate)
- [team_msdyncrm_basestyle](#BKMK_team_msdyncrm_basestyle)
- [team_msdyncrm_buttonstyle](#BKMK_team_msdyncrm_buttonstyle)
- [team_msdyncrm_cdnconfiguration](#BKMK_team_msdyncrm_cdnconfiguration)
- [team_msdyncrm_cdsaconnectorconfiguration](#BKMK_team_msdyncrm_cdsaconnectorconfiguration)
- [team_msdyncrm_codestyle](#BKMK_team_msdyncrm_codestyle)
- [team_msdyncrm_columnstyle](#BKMK_team_msdyncrm_columnstyle)
- [team_msdyncrm_contentblock](#BKMK_team_msdyncrm_contentblock)
- [team_msdyncrm_contentblockstyle](#BKMK_team_msdyncrm_contentblockstyle)
- [team_msdyncrm_contentsettings](#BKMK_team_msdyncrm_contentsettings)
- [team_msdyncrm_createleadactivity](#BKMK_team_msdyncrm_createleadactivity)
- [team_msdyncrm_customerinsightsinfo](#BKMK_team_msdyncrm_customerinsightsinfo)
- [team_msdyncrm_customerjourney](#BKMK_team_msdyncrm_customerjourney)
- [team_msdyncrm_customerjourneycustomchannelactivity](#BKMK_team_msdyncrm_customerjourneycustomchannelactivity)
- [team_msdyncrm_customerjourneyiteration](#BKMK_team_msdyncrm_customerjourneyiteration)
- [team_msdyncrm_customerjourneyruntimestate](#BKMK_team_msdyncrm_customerjourneyruntimestate)
- [team_msdyncrm_customerjourneytemplate](#BKMK_team_msdyncrm_customerjourneytemplate)
- [team_msdyncrm_customerjourneyworkflowlink](#BKMK_team_msdyncrm_customerjourneyworkflowlink)
- [team_msdyncrm_defaultmarketingsetting](#BKMK_team_msdyncrm_defaultmarketingsetting)
- [team_msdyncrm_deprecatedcustomtileactivity](#BKMK_team_msdyncrm_deprecatedcustomtileactivity)
- [team_msdyncrm_deprecatedeventactivity](#BKMK_team_msdyncrm_deprecatedeventactivity)
- [team_msdyncrm_deprecatedformsprosurveyactivity](#BKMK_team_msdyncrm_deprecatedformsprosurveyactivity)
- [team_msdyncrm_deprecatedpageactivity](#BKMK_team_msdyncrm_deprecatedpageactivity)
- [team_msdyncrm_designerfeatureavailability](#BKMK_team_msdyncrm_designerfeatureavailability)
- [team_msdyncrm_dividerstyle](#BKMK_team_msdyncrm_dividerstyle)
- [team_msdyncrm_emailkeypoint](#BKMK_team_msdyncrm_emailkeypoint)
- [team_msdyncrm_featureconfiguration](#BKMK_team_msdyncrm_featureconfiguration)
- [team_msdyncrm_file](#BKMK_team_msdyncrm_file)
- [team_msdyncrm_formpage](#BKMK_team_msdyncrm_formpage)
- [team_msdyncrm_formpagetemplate](#BKMK_team_msdyncrm_formpagetemplate)
- [team_msdyncrm_generalstyles](#BKMK_team_msdyncrm_generalstyles)
- [team_msdyncrm_geopin](#BKMK_team_msdyncrm_geopin)
- [team_msdyncrm_gpt3log](#BKMK_team_msdyncrm_gpt3log)
- [team_msdyncrm_gwennolfeatureconfiguration](#BKMK_team_msdyncrm_gwennolfeatureconfiguration)
- [team_msdyncrm_gwennolspamscoreactivity](#BKMK_team_msdyncrm_gwennolspamscoreactivity)
- [team_msdyncrm_gwennolspamscorerequest](#BKMK_team_msdyncrm_gwennolspamscorerequest)
- [team_msdyncrm_imagestyle](#BKMK_team_msdyncrm_imagestyle)
- [team_msdyncrm_keyword](#BKMK_team_msdyncrm_keyword)
- [team_msdyncrm_launchworkflowactivity](#BKMK_team_msdyncrm_launchworkflowactivity)
- [team_msdyncrm_layoutstyle](#BKMK_team_msdyncrm_layoutstyle)
- [team_msdyncrm_leadscore](#BKMK_team_msdyncrm_leadscore)
- [team_msdyncrm_leadscore_v2](#BKMK_team_msdyncrm_leadscore_v2)
- [team_msdyncrm_leadscoremodel](#BKMK_team_msdyncrm_leadscoremodel)
- [team_msdyncrm_linkedinaccount](#BKMK_team_msdyncrm_linkedinaccount)
- [team_msdyncrm_linkedinactivity](#BKMK_team_msdyncrm_linkedinactivity)
- [team_msdyncrm_linkedinaudience](#BKMK_team_msdyncrm_linkedinaudience)
- [team_msdyncrm_linkedincampaign](#BKMK_team_msdyncrm_linkedincampaign)
- [team_msdyncrm_linkedincampaignactivity](#BKMK_team_msdyncrm_linkedincampaignactivity)
- [team_msdyncrm_linkedinconfiguration](#BKMK_team_msdyncrm_linkedinconfiguration)
- [team_msdyncrm_linkedinfieldmapping](#BKMK_team_msdyncrm_linkedinfieldmapping)
- [team_msdyncrm_linkedinform](#BKMK_team_msdyncrm_linkedinform)
- [team_msdyncrm_linkedinformanswer](#BKMK_team_msdyncrm_linkedinformanswer)
- [team_msdyncrm_linkedinformquestion](#BKMK_team_msdyncrm_linkedinformquestion)
- [team_msdyncrm_linkedinformsubmission](#BKMK_team_msdyncrm_linkedinformsubmission)
- [team_msdyncrm_linkedinleadmatchingstrategy](#BKMK_team_msdyncrm_linkedinleadmatchingstrategy)
- [team_msdyncrm_linkedinuserprofile](#BKMK_team_msdyncrm_linkedinuserprofile)
- [team_msdyncrm_listform](#BKMK_team_msdyncrm_listform)
- [team_msdyncrm_liveentitydependency](#BKMK_team_msdyncrm_liveentitydependency)
- [team_msdyncrm_marketingdataimport](#BKMK_team_msdyncrm_marketingdataimport)
- [team_msdyncrm_marketingdynamiccontentmetadata](#BKMK_team_msdyncrm_marketingdynamiccontentmetadata)
- [team_msdyncrm_marketingemail](#BKMK_team_msdyncrm_marketingemail)
- [team_msdyncrm_marketingemailactivity](#BKMK_team_msdyncrm_marketingemailactivity)
- [team_msdyncrm_marketingemaildynamiccontentmetadata](#BKMK_team_msdyncrm_marketingemaildynamiccontentmetadata)
- [team_msdyncrm_marketingemailtemplate](#BKMK_team_msdyncrm_marketingemailtemplate)
- [team_msdyncrm_marketingemailtest](#BKMK_team_msdyncrm_marketingemailtest)
- [team_msdyncrm_marketingemailtestattribute](#BKMK_team_msdyncrm_marketingemailtestattribute)
- [team_msdyncrm_marketingemailtestsend](#BKMK_team_msdyncrm_marketingemailtestsend)
- [team_msdyncrm_marketingfieldsubmission](#BKMK_team_msdyncrm_marketingfieldsubmission)
- [team_msdyncrm_marketingform](#BKMK_team_msdyncrm_marketingform)
- [team_msdyncrm_marketingformactivity](#BKMK_team_msdyncrm_marketingformactivity)
- [team_msdyncrm_marketingformfield](#BKMK_team_msdyncrm_marketingformfield)
- [team_msdyncrm_marketingformsubmission](#BKMK_team_msdyncrm_marketingformsubmission)
- [team_msdyncrm_marketingformtemplate](#BKMK_team_msdyncrm_marketingformtemplate)
- [team_msdyncrm_marketingformwhitelistrule](#BKMK_team_msdyncrm_marketingformwhitelistrule)
- [team_msdyncrm_marketingpage](#BKMK_team_msdyncrm_marketingpage)
- [team_msdyncrm_marketingpagetemplate](#BKMK_team_msdyncrm_marketingpagetemplate)
- [team_msdyncrm_matchingstrategyattribute](#BKMK_team_msdyncrm_matchingstrategyattribute)
- [team_msdyncrm_migration](#BKMK_team_msdyncrm_migration)
- [team_msdyncrm_mktactivity](#BKMK_team_msdyncrm_mktactivity)
- [team_msdyncrm_networkpage](#BKMK_team_msdyncrm_networkpage)
- [team_msdyncrm_personalizedpage](#BKMK_team_msdyncrm_personalizedpage)
- [team_msdyncrm_personalizedpagefield](#BKMK_team_msdyncrm_personalizedpagefield)
- [team_msdyncrm_phonecallactivity](#BKMK_team_msdyncrm_phonecallactivity)
- [team_msdyncrm_phonecallactivitymarketingtemplate](#BKMK_team_msdyncrm_phonecallactivitymarketingtemplate)
- [team_msdyncrm_postingishts](#BKMK_team_msdyncrm_postingishts)
- [team_msdyncrm_qrcodestyle](#BKMK_team_msdyncrm_qrcodestyle)
- [team_msdyncrm_quicksendemail](#BKMK_team_msdyncrm_quicksendemail)
- [team_msdyncrm_reaction](#BKMK_team_msdyncrm_reaction)
- [team_msdyncrm_recordupdateactivity](#BKMK_team_msdyncrm_recordupdateactivity)
- [team_msdyncrm_redirecturl](#BKMK_team_msdyncrm_redirecturl)
- [team_msdyncrm_segment](#BKMK_team_msdyncrm_segment)
- [team_msdyncrm_segmentactivity](#BKMK_team_msdyncrm_segmentactivity)
- [team_msdyncrm_segmenttemplate](#BKMK_team_msdyncrm_segmenttemplate)
- [team_msdyncrm_socialpost](#BKMK_team_msdyncrm_socialpost)
- [team_msdyncrm_socialpostingconfiguration](#BKMK_team_msdyncrm_socialpostingconfiguration)
- [team_msdyncrm_socialpostingconsent](#BKMK_team_msdyncrm_socialpostingconsent)
- [team_msdyncrm_sourceactivity](#BKMK_team_msdyncrm_sourceactivity)
- [team_msdyncrm_splitteractivity](#BKMK_team_msdyncrm_splitteractivity)
- [team_msdyncrm_tag](#BKMK_team_msdyncrm_tag)
- [team_msdyncrm_taskactivity](#BKMK_team_msdyncrm_taskactivity)
- [team_msdyncrm_taskactivitymarketingtemplate](#BKMK_team_msdyncrm_taskactivitymarketingtemplate)
- [team_msdyncrm_textstyle](#BKMK_team_msdyncrm_textstyle)
- [team_msdyncrm_triggeractivity](#BKMK_team_msdyncrm_triggeractivity)
- [team_msdyncrm_uicconfig](#BKMK_team_msdyncrm_uicconfig)
- [team_msdyncrm_usergeoregion](#BKMK_team_msdyncrm_usergeoregion)
- [team_msdyncrm_usersetting](#BKMK_team_msdyncrm_usersetting)
- [team_msdyncrm_video](#BKMK_team_msdyncrm_video)
- [team_msdyncrm_videostyle](#BKMK_team_msdyncrm_videostyle)
- [team_msdyncrm_website](#BKMK_team_msdyncrm_website)
- [team_msdynmkt_aimodelversion](#BKMK_team_msdynmkt_aimodelversion)
- [team_msdynmkt_apsconfig](#BKMK_team_msdynmkt_apsconfig)
- [team_msdynmkt_brandprofile](#BKMK_team_msdynmkt_brandprofile)
- [team_msdynmkt_brandsender](#BKMK_team_msdynmkt_brandsender)
- [team_msdynmkt_brandtheme](#BKMK_team_msdynmkt_brandtheme)
- [team_msdynmkt_buttonstyle](#BKMK_team_msdynmkt_buttonstyle)
- [team_msdynmkt_byoacschannelinstance](#BKMK_team_msdynmkt_byoacschannelinstance)
- [team_msdynmkt_byoacschannelinstanceaccount](#BKMK_team_msdynmkt_byoacschannelinstanceaccount)
- [team_msdynmkt_captcha](#BKMK_team_msdynmkt_captcha)
- [team_msdynmkt_catalogeventstatusconfiguration](#BKMK_team_msdynmkt_catalogeventstatusconfiguration)
- [team_msdynmkt_compliancesettings3](#BKMK_team_msdynmkt_compliancesettings3)
- [team_msdynmkt_compliancesettings4](#BKMK_team_msdynmkt_compliancesettings4)
- [team_msdynmkt_configuration](#BKMK_team_msdynmkt_configuration)
- [team_msdynmkt_consentprovider](#BKMK_team_msdynmkt_consentprovider)
- [team_msdynmkt_consentproviderdefaultconfiguration](#BKMK_team_msdynmkt_consentproviderdefaultconfiguration)
- [team_msdynmkt_consentproviderdefaultpurpose](#BKMK_team_msdynmkt_consentproviderdefaultpurpose)
- [team_msdynmkt_consentsystemconfiguration](#BKMK_team_msdynmkt_consentsystemconfiguration)
- [team_msdynmkt_contactpointconsent](#BKMK_team_msdynmkt_contactpointconsent)
- [team_msdynmkt_contactpointconsent3](#BKMK_team_msdynmkt_contactpointconsent3)
- [team_msdynmkt_contactpointconsent4](#BKMK_team_msdynmkt_contactpointconsent4)
- [team_msdynmkt_conversioneventdefinition](#BKMK_team_msdynmkt_conversioneventdefinition)
- [team_msdynmkt_createdentitylink](#BKMK_team_msdynmkt_createdentitylink)
- [team_msdynmkt_customchannelmessage](#BKMK_team_msdynmkt_customchannelmessage)
- [team_msdynmkt_domain](#BKMK_team_msdynmkt_domain)
- [team_msdynmkt_email](#BKMK_team_msdynmkt_email)
- [team_msdynmkt_emailtemplate](#BKMK_team_msdynmkt_emailtemplate)
- [team_msdynmkt_entitygradedistribution](#BKMK_team_msdynmkt_entitygradedistribution)
- [team_msdynmkt_entityscoredistribution](#BKMK_team_msdynmkt_entityscoredistribution)
- [team_msdynmkt_entityscoringmodel](#BKMK_team_msdynmkt_entityscoringmodel)
- [team_msdynmkt_eventmetadata](#BKMK_team_msdynmkt_eventmetadata)
- [team_msdynmkt_eventparametermetadata](#BKMK_team_msdynmkt_eventparametermetadata)
- [team_msdynmkt_experiment](#BKMK_team_msdynmkt_experiment)
- [team_msdynmkt_experimentv2](#BKMK_team_msdynmkt_experimentv2)
- [team_msdynmkt_featureconfiguration](#BKMK_team_msdynmkt_featureconfiguration)
- [team_msdynmkt_fragment](#BKMK_team_msdynmkt_fragment)
- [team_msdynmkt_frequencycap](#BKMK_team_msdynmkt_frequencycap)
- [team_msdynmkt_gdprrequest](#BKMK_team_msdynmkt_gdprrequest)
- [team_msdynmkt_imagestyle](#BKMK_team_msdynmkt_imagestyle)
- [team_msdynmkt_infobipchannelinstance](#BKMK_team_msdynmkt_infobipchannelinstance)
- [team_msdynmkt_infobipchannelinstanceaccount](#BKMK_team_msdynmkt_infobipchannelinstanceaccount)
- [team_msdynmkt_journey](#BKMK_team_msdynmkt_journey)
- [team_msdynmkt_journeydependency](#BKMK_team_msdynmkt_journeydependency)
- [team_msdynmkt_journeyevent](#BKMK_team_msdynmkt_journeyevent)
- [team_msdynmkt_journeyoptimizationcount](#BKMK_team_msdynmkt_journeyoptimizationcount)
- [team_msdynmkt_journeyrunparameter](#BKMK_team_msdynmkt_journeyrunparameter)
- [team_msdynmkt_journeysetting](#BKMK_team_msdynmkt_journeysetting)
- [team_msdynmkt_journeytemplate](#BKMK_team_msdynmkt_journeytemplate)
- [team_msdynmkt_journeyworkflowmapping](#BKMK_team_msdynmkt_journeyworkflowmapping)
- [team_msdynmkt_keyword](#BKMK_team_msdynmkt_keyword)
- [team_msdynmkt_leadqualificationmodel](#BKMK_team_msdynmkt_leadqualificationmodel)
- [team_msdynmkt_linkmobilitychannelinstance](#BKMK_team_msdynmkt_linkmobilitychannelinstance)
- [team_msdynmkt_linkmobilitychannelinstanceaccount](#BKMK_team_msdynmkt_linkmobilitychannelinstanceaccount)
- [team_msdynmkt_marketingfieldsubmission](#BKMK_team_msdynmkt_marketingfieldsubmission)
- [team_msdynmkt_marketingform](#BKMK_team_msdynmkt_marketingform)
- [team_msdynmkt_marketingformfield](#BKMK_team_msdynmkt_marketingformfield)
- [team_msdynmkt_marketingformsubmission](#BKMK_team_msdynmkt_marketingformsubmission)
- [team_msdynmkt_marketingformtemplate](#BKMK_team_msdynmkt_marketingformtemplate)
- [team_msdynmkt_matchingstrategy](#BKMK_team_msdynmkt_matchingstrategy)
- [team_msdynmkt_matchingstrategyattribute](#BKMK_team_msdynmkt_matchingstrategyattribute)
- [team_msdynmkt_metadataentityrelationship](#BKMK_team_msdynmkt_metadataentityrelationship)
- [team_msdynmkt_metadataitem](#BKMK_team_msdynmkt_metadataitem)
- [team_msdynmkt_metadatastorestate](#BKMK_team_msdynmkt_metadatastorestate)
- [team_msdynmkt_mobileapp](#BKMK_team_msdynmkt_mobileapp)
- [team_msdynmkt_mobileappchannelinstance](#BKMK_team_msdynmkt_mobileappchannelinstance)
- [team_msdynmkt_mobiledevice](#BKMK_team_msdynmkt_mobiledevice)
- [team_msdynmkt_mocksmsproviderchannelinstance](#BKMK_team_msdynmkt_mocksmsproviderchannelinstance)
- [team_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_team_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [team_msdynmkt_predefinedplaceholder](#BKMK_team_msdynmkt_predefinedplaceholder)
- [team_msdynmkt_preferencecenter](#BKMK_team_msdynmkt_preferencecenter)
- [team_msdynmkt_purpose](#BKMK_team_msdynmkt_purpose)
- [team_msdynmkt_pushdeviceregistrationresult](#BKMK_team_msdynmkt_pushdeviceregistrationresult)
- [team_msdynmkt_pushmobiledevice](#BKMK_team_msdynmkt_pushmobiledevice)
- [team_msdynmkt_pushnotification](#BKMK_team_msdynmkt_pushnotification)
- [team_msdynmkt_qrcodestyle](#BKMK_team_msdynmkt_qrcodestyle)
- [team_msdynmkt_quiettimesetting](#BKMK_team_msdynmkt_quiettimesetting)
- [team_msdynmkt_recaptchaconfiguration](#BKMK_team_msdynmkt_recaptchaconfiguration)
- [team_msdynmkt_segment](#BKMK_team_msdynmkt_segment)
- [team_msdynmkt_segmentdefinition](#BKMK_team_msdynmkt_segmentdefinition)
- [team_msdynmkt_segmentexecution](#BKMK_team_msdynmkt_segmentexecution)
- [team_msdynmkt_segmentusage](#BKMK_team_msdynmkt_segmentusage)
- [team_msdynmkt_sms](#BKMK_team_msdynmkt_sms)
- [team_msdynmkt_submitbutton](#BKMK_team_msdynmkt_submitbutton)
- [team_msdynmkt_tag](#BKMK_team_msdynmkt_tag)
- [team_msdynmkt_teamsengagement](#BKMK_team_msdynmkt_teamsengagement)
- [team_msdynmkt_telesignchannelinstance](#BKMK_team_msdynmkt_telesignchannelinstance)
- [team_msdynmkt_telesignchannelinstanceaccount](#BKMK_team_msdynmkt_telesignchannelinstanceaccount)
- [team_msdynmkt_topic](#BKMK_team_msdynmkt_topic)
- [team_msdynmkt_twiliochannelinstance](#BKMK_team_msdynmkt_twiliochannelinstance)
- [team_msdynmkt_twiliochannelinstanceaccount](#BKMK_team_msdynmkt_twiliochannelinstanceaccount)
- [team_msdynmkt_utmtracking](#BKMK_team_msdynmkt_utmtracking)
- [team_msdynmkt_vibeschannelinstance](#BKMK_team_msdynmkt_vibeschannelinstance)
- [team_msdynmkt_vibeschannelinstanceaccount](#BKMK_team_msdynmkt_vibeschannelinstanceaccount)
- [team_msdynmkt_webinaremailjourney](#BKMK_team_msdynmkt_webinaremailjourney)
- [team_msevtmgt_attendeepass](#BKMK_team_msevtmgt_attendeepass)
- [team_msevtmgt_authenticationsettings](#BKMK_team_msevtmgt_authenticationsettings)
- [team_msevtmgt_bucket](#BKMK_team_msevtmgt_bucket)
- [team_msevtmgt_building](#BKMK_team_msevtmgt_building)
- [team_msevtmgt_checkin](#BKMK_team_msevtmgt_checkin)
- [team_msevtmgt_customregistrationfield](#BKMK_team_msevtmgt_customregistrationfield)
- [team_msevtmgt_entitycounter](#BKMK_team_msevtmgt_entitycounter)
- [team_msevtmgt_event](#BKMK_team_msevtmgt_event)
- [team_msevtmgt_eventadministration](#BKMK_team_msevtmgt_eventadministration)
- [team_msevtmgt_eventanalytics](#BKMK_team_msevtmgt_eventanalytics)
- [team_msevtmgt_eventcustomregistrationfield](#BKMK_team_msevtmgt_eventcustomregistrationfield)
- [team_msevtmgt_eventmanagementactivity](#BKMK_team_msevtmgt_eventmanagementactivity)
- [team_msevtmgt_eventmanagementconfiguration](#BKMK_team_msevtmgt_eventmanagementconfiguration)
- [team_msevtmgt_eventpurchase](#BKMK_team_msevtmgt_eventpurchase)
- [team_msevtmgt_eventpurchaseattendee](#BKMK_team_msevtmgt_eventpurchaseattendee)
- [team_msevtmgt_eventpurchasecontact](#BKMK_team_msevtmgt_eventpurchasecontact)
- [team_msevtmgt_eventpurchasepass](#BKMK_team_msevtmgt_eventpurchasepass)
- [team_msevtmgt_eventregistration](#BKMK_team_msevtmgt_eventregistration)
- [team_msevtmgt_eventregistrationticket](#BKMK_team_msevtmgt_eventregistrationticket)
- [team_msevtmgt_eventteammember](#BKMK_team_msevtmgt_eventteammember)
- [team_msevtmgt_eventteamsproperties](#BKMK_team_msevtmgt_eventteamsproperties)
- [team_msevtmgt_eventvendor](#BKMK_team_msevtmgt_eventvendor)
- [team_msevtmgt_file](#BKMK_team_msevtmgt_file)
- [team_msevtmgt_hotel](#BKMK_team_msevtmgt_hotel)
- [team_msevtmgt_hotelroomallocation](#BKMK_team_msevtmgt_hotelroomallocation)
- [team_msevtmgt_hotelroomreservation](#BKMK_team_msevtmgt_hotelroomreservation)
- [team_msevtmgt_layout](#BKMK_team_msevtmgt_layout)
- [team_msevtmgt_pass](#BKMK_team_msevtmgt_pass)
- [team_msevtmgt_registrationresponse](#BKMK_team_msevtmgt_registrationresponse)
- [team_msevtmgt_room](#BKMK_team_msevtmgt_room)
- [team_msevtmgt_roomreservation](#BKMK_team_msevtmgt_roomreservation)
- [team_msevtmgt_session](#BKMK_team_msevtmgt_session)
- [team_msevtmgt_sessionregistration](#BKMK_team_msevtmgt_sessionregistration)
- [team_msevtmgt_sessiontrack](#BKMK_team_msevtmgt_sessiontrack)
- [team_msevtmgt_speaker](#BKMK_team_msevtmgt_speaker)
- [team_msevtmgt_speakerengagement](#BKMK_team_msevtmgt_speakerengagement)
- [team_msevtmgt_sponsorablearticle](#BKMK_team_msevtmgt_sponsorablearticle)
- [team_msevtmgt_sponsorship](#BKMK_team_msevtmgt_sponsorship)
- [team_msevtmgt_venue](#BKMK_team_msevtmgt_venue)
- [team_msevtmgt_waitlistitem](#BKMK_team_msevtmgt_waitlistitem)
- [team_msevtmgt_websiteentityconfiguration](#BKMK_team_msevtmgt_websiteentityconfiguration)
- [team_msfp_alertrule](#BKMK_team_msfp_alertrule)
- [team_msfp_emailtemplate](#BKMK_team_msfp_emailtemplate)
- [team_msfp_fileresponse](#BKMK_team_msfp_fileresponse)
- [team_msfp_localizedemailtemplate](#BKMK_team_msfp_localizedemailtemplate)
- [team_msfp_project](#BKMK_team_msfp_project)
- [team_msfp_question](#BKMK_team_msfp_question)
- [team_msfp_questionresponse](#BKMK_team_msfp_questionresponse)
- [team_msfp_satisfactionmetric](#BKMK_team_msfp_satisfactionmetric)
- [team_msfp_survey](#BKMK_team_msfp_survey)
- [team_msfp_surveyreminder](#BKMK_team_msfp_surveyreminder)
- [team_msfp_unsubscribedrecipient](#BKMK_team_msfp_unsubscribedrecipient)
- [team_msmrw_3dasset](#BKMK_team_msmrw_3dasset)
- [team_msmrw_3dasset_localized](#BKMK_team_msmrw_3dasset_localized)
- [team_msmrw_assetcollection](#BKMK_team_msmrw_assetcollection)
- [team_msmrw_assetcollection_localized](#BKMK_team_msmrw_assetcollection_localized)
- [team_msmrw_audioasset](#BKMK_team_msmrw_audioasset)
- [team_msmrw_guide](#BKMK_team_msmrw_guide)
- [team_msmrw_guidecompletionstepobject](#BKMK_team_msmrw_guidecompletionstepobject)
- [team_msmrw_guidecompletionstepobjectplacement](#BKMK_team_msmrw_guidecompletionstepobjectplacement)
- [team_msmrw_guideevent](#BKMK_team_msmrw_guideevent)
- [team_msmrw_guidesession](#BKMK_team_msmrw_guidesession)
- [team_msmrw_guidesessionstepvisit](#BKMK_team_msmrw_guidesessionstepvisit)
- [team_msmrw_guidestep](#BKMK_team_msmrw_guidestep)
- [team_msmrw_guidestepobject](#BKMK_team_msmrw_guidestepobject)
- [team_msmrw_guidestepobjectplacement](#BKMK_team_msmrw_guidestepobjectplacement)
- [team_msmrw_guidetask](#BKMK_team_msmrw_guidetask)
- [team_msmrw_guideviewconfiguration](#BKMK_team_msmrw_guideviewconfiguration)
- [team_msmrw_imageasset](#BKMK_team_msmrw_imageasset)
- [team_msmrw_imageasset_localized](#BKMK_team_msmrw_imageasset_localized)
- [team_msmrw_packagedguide](#BKMK_team_msmrw_packagedguide)
- [team_msmrw_packagedguidesessionstepvisit](#BKMK_team_msmrw_packagedguidesessionstepvisit)
- [team_msmrw_packagedguidesoperatorsession](#BKMK_team_msmrw_packagedguidesoperatorsession)
- [team_msmrw_usersettings](#BKMK_team_msmrw_usersettings)
- [team_msmrw_videoasset](#BKMK_team_msmrw_videoasset)
- [team_msmrw_videoasset_localized](#BKMK_team_msmrw_videoasset_localized)
- [team_opportunities](#BKMK_team_opportunities)
- [team_opportunityclose](#BKMK_team_opportunityclose)
- [team_opportunityproduct](#BKMK_team_opportunityproduct)
- [team_orderclose](#BKMK_team_orderclose)
- [team_orders](#BKMK_team_orders)
- [team_quoteclose](#BKMK_team_quoteclose)
- [team_quotedetail](#BKMK_team_quotedetail)
- [team_quotes](#BKMK_team_quotes)
- [team_ratingmodel](#BKMK_team_ratingmodel)
- [team_ratingvalue](#BKMK_team_ratingvalue)
- [team_resource_groups](#BKMK_team_resource_groups)
- [team_resource_specs](#BKMK_team_resource_specs)
- [team_sales_linkedin_profileassociations](#BKMK_team_sales_linkedin_profileassociations)
- [team_sales_linkedin_users_signedin_status](#BKMK_team_sales_linkedin_users_signedin_status)
- [team_salesorderdetail](#BKMK_team_salesorderdetail)
- [team_service_appointments](#BKMK_team_service_appointments)
- [team_service_contracts](#BKMK_team_service_contracts)

### <a name="BKMK_adx_alertsubscription_team_owningteam"></a> adx_alertsubscription_team_owningteam

Many-To-One Relationship: [adx_alertsubscription adx_alertsubscription_team_owningteam](adx_alertsubscription.md#BKMK_adx_alertsubscription_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`adx_alertsubscription_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_owning_team"></a> lead_owning_team

Many-To-One Relationship: [lead lead_owning_team](lead.md#BKMK_lead_owning_team)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`lead_owning_team`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_inmail_team_owningteam"></a> li_inmail_team_owningteam

Many-To-One Relationship: [li_inmail li_inmail_team_owningteam](li_inmail.md#BKMK_li_inmail_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`li_inmail_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_message_team_owningteam"></a> li_message_team_owningteam

Many-To-One Relationship: [li_message li_message_team_owningteam](li_message.md#BKMK_li_message_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`li_message_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_team_owningteam"></a> li_pointdrivepresentationviewed_team_owningteam

Many-To-One Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_team_owningteam](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_team_owningteam"></a> msdyn_bookingalert_team_owningteam

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_team_owningteam](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilottranscript_team_owningteam"></a> msdyn_copilottranscript_team_owningteam

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_team_owningteam](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_team_owningteam"></a> msdyn_ocliveworkitem_team_owningteam

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_team_owningteam](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_team_owningteam`|
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

### <a name="BKMK_msdyn_ocsession_team_owningteam"></a> msdyn_ocsession_team_owningteam

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_team_owningteam](msdyn_ocsession.md#BKMK_msdyn_ocsession_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_team_owningteam`|
|IsCustomizable|`True`|
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

### <a name="BKMK_msdyn_team_msdyn_salesroutingrun_ownerassigned"></a> msdyn_team_msdyn_salesroutingrun_ownerassigned

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_team_msdyn_salesroutingrun_ownerassigned](msdyn_salesroutingrun.md#BKMK_msdyn_team_msdyn_salesroutingrun_ownerassigned)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_ownerassigned`|
|ReferencedEntityNavigationPropertyName|`msdyn_team_msdyn_salesroutingrun_ownerassigned`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_team_msdyn_salesroutingrun_previousowner"></a> msdyn_team_msdyn_salesroutingrun_previousowner

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_team_msdyn_salesroutingrun_previousowner](msdyn_salesroutingrun.md#BKMK_msdyn_team_msdyn_salesroutingrun_previousowner)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_previousowner`|
|ReferencedEntityNavigationPropertyName|`msdyn_team_msdyn_salesroutingrun_previousowner`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_team_msdyncrm_designerfeatureavailability_team"></a> msdyncrm_team_msdyncrm_designerfeatureavailability_team

Many-To-One Relationship: [msdyncrm_designerfeatureavailability msdyncrm_team_msdyncrm_designerfeatureavailability_team](msdyncrm_designerfeatureavailability.md#BKMK_msdyncrm_team_msdyncrm_designerfeatureavailability_team)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_designerfeatureavailability`|
|ReferencingAttribute|`msdyncrm_team`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_team_msdyncrm_designerfeatureavailability_team`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_alert_team_owningteam"></a> msfp_alert_team_owningteam

Many-To-One Relationship: [msfp_alert msfp_alert_team_owningteam](msfp_alert.md#BKMK_msfp_alert_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyinvite_team_owningteam"></a> msfp_surveyinvite_team_owningteam

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_team_owningteam](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyresponse_team_owningteam"></a> msfp_surveyresponse_team_owningteam

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_team_owningteam](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_team_owningteam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_activitymonitor"></a> team_activitymonitor

Many-To-One Relationship: [activitymonitor team_activitymonitor](activitymonitor.md#BKMK_team_activitymonitor)

|Property|Value|
|---|---|
|ReferencingEntity|`activitymonitor`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_activitymonitor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adminsettingsentity"></a> team_adminsettingsentity

Many-To-One Relationship: [adminsettingsentity team_adminsettingsentity](adminsettingsentity.md#BKMK_team_adminsettingsentity)

|Property|Value|
|---|---|
|ReferencingEntity|`adminsettingsentity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adminsettingsentity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_ad"></a> team_adx_ad

Many-To-One Relationship: [adx_ad team_adx_ad](adx_ad.md#BKMK_team_adx_ad)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_ad`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_ad`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_adplacement"></a> team_adx_adplacement

Many-To-One Relationship: [adx_adplacement team_adx_adplacement](adx_adplacement.md#BKMK_team_adx_adplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_adplacement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_adplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_botconsumer"></a> team_adx_botconsumer

Many-To-One Relationship: [adx_botconsumer team_adx_botconsumer](adx_botconsumer.md#BKMK_team_adx_botconsumer)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_botconsumer`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_botconsumer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_casedeflection"></a> team_adx_casedeflection

Many-To-One Relationship: [adx_casedeflection team_adx_casedeflection](adx_casedeflection.md#BKMK_team_adx_casedeflection)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_casedeflection`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_casedeflection`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_cloudflowconsumer"></a> team_adx_cloudflowconsumer

Many-To-One Relationship: [adx_cloudflowconsumer team_adx_cloudflowconsumer](adx_cloudflowconsumer.md#BKMK_team_adx_cloudflowconsumer)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_cloudflowconsumer`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_cloudflowconsumer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_communityforum"></a> team_adx_communityforum

Many-To-One Relationship: [adx_communityforum team_adx_communityforum](adx_communityforum.md#BKMK_team_adx_communityforum)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforum`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_communityforum`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_communityforumaccesspermission"></a> team_adx_communityforumaccesspermission

Many-To-One Relationship: [adx_communityforumaccesspermission team_adx_communityforumaccesspermission](adx_communityforumaccesspermission.md#BKMK_team_adx_communityforumaccesspermission)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumaccesspermission`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_communityforumaccesspermission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_communityforumalert"></a> team_adx_communityforumalert

Many-To-One Relationship: [adx_communityforumalert team_adx_communityforumalert](adx_communityforumalert.md#BKMK_team_adx_communityforumalert)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumalert`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_communityforumalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_communityforumannouncement"></a> team_adx_communityforumannouncement

Many-To-One Relationship: [adx_communityforumannouncement team_adx_communityforumannouncement](adx_communityforumannouncement.md#BKMK_team_adx_communityforumannouncement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumannouncement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_communityforumannouncement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_communityforumpost"></a> team_adx_communityforumpost

Many-To-One Relationship: [adx_communityforumpost team_adx_communityforumpost](adx_communityforumpost.md#BKMK_team_adx_communityforumpost)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumpost`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_communityforumpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_communityforumthread"></a> team_adx_communityforumthread

Many-To-One Relationship: [adx_communityforumthread team_adx_communityforumthread](adx_communityforumthread.md#BKMK_team_adx_communityforumthread)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumthread`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_communityforumthread`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_contentaccesslevel"></a> team_adx_contentaccesslevel

Many-To-One Relationship: [adx_contentaccesslevel team_adx_contentaccesslevel](adx_contentaccesslevel.md#BKMK_team_adx_contentaccesslevel)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_contentaccesslevel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_contentaccesslevel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_contentsnippet"></a> team_adx_contentsnippet

Many-To-One Relationship: [adx_contentsnippet team_adx_contentsnippet](adx_contentsnippet.md#BKMK_team_adx_contentsnippet)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_contentsnippet`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_contentsnippet`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_forumthreadtype"></a> team_adx_forumthreadtype

Many-To-One Relationship: [adx_forumthreadtype team_adx_forumthreadtype](adx_forumthreadtype.md#BKMK_team_adx_forumthreadtype)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumthreadtype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_forumthreadtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_pagealert"></a> team_adx_pagealert

Many-To-One Relationship: [adx_pagealert team_adx_pagealert](adx_pagealert.md#BKMK_team_adx_pagealert)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagealert`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_pagealert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_pagenotification"></a> team_adx_pagenotification

Many-To-One Relationship: [adx_pagenotification team_adx_pagenotification](adx_pagenotification.md#BKMK_team_adx_pagenotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagenotification`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_pagenotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_pagetag"></a> team_adx_pagetag

Many-To-One Relationship: [adx_pagetag team_adx_pagetag](adx_pagetag.md#BKMK_team_adx_pagetag)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagetag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_pagetag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_pagetemplate"></a> team_adx_pagetemplate

Many-To-One Relationship: [adx_pagetemplate team_adx_pagetemplate](adx_pagetemplate.md#BKMK_team_adx_pagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagetemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_pagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_poll"></a> team_adx_poll

Many-To-One Relationship: [adx_poll team_adx_poll](adx_poll.md#BKMK_team_adx_poll)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_poll`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_poll`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_polloption"></a> team_adx_polloption

Many-To-One Relationship: [adx_polloption team_adx_polloption](adx_polloption.md#BKMK_team_adx_polloption)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_polloption`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_polloption`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_pollplacement"></a> team_adx_pollplacement

Many-To-One Relationship: [adx_pollplacement team_adx_pollplacement](adx_pollplacement.md#BKMK_team_adx_pollplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pollplacement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_pollplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_pollsubmission"></a> team_adx_pollsubmission

Many-To-One Relationship: [adx_pollsubmission team_adx_pollsubmission](adx_pollsubmission.md#BKMK_team_adx_pollsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pollsubmission`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_pollsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_portallanguage"></a> team_adx_portallanguage

Many-To-One Relationship: [adx_portallanguage team_adx_portallanguage](adx_portallanguage.md#BKMK_team_adx_portallanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portallanguage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_portallanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_publishingstate"></a> team_adx_publishingstate

Many-To-One Relationship: [adx_publishingstate team_adx_publishingstate](adx_publishingstate.md#BKMK_team_adx_publishingstate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_publishingstate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_publishingstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_publishingstatetransitionrule"></a> team_adx_publishingstatetransitionrule

Many-To-One Relationship: [adx_publishingstatetransitionrule team_adx_publishingstatetransitionrule](adx_publishingstatetransitionrule.md#BKMK_team_adx_publishingstatetransitionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_publishingstatetransitionrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_publishingstatetransitionrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_redirect"></a> team_adx_redirect

Many-To-One Relationship: [adx_redirect team_adx_redirect](adx_redirect.md#BKMK_team_adx_redirect)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_redirect`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_redirect`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_shortcut"></a> team_adx_shortcut

Many-To-One Relationship: [adx_shortcut team_adx_shortcut](adx_shortcut.md#BKMK_team_adx_shortcut)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_shortcut`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_shortcut`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_sitemarker"></a> team_adx_sitemarker

Many-To-One Relationship: [adx_sitemarker team_adx_sitemarker](adx_sitemarker.md#BKMK_team_adx_sitemarker)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitemarker`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_sitemarker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_sitemigrationchunk"></a> team_adx_sitemigrationchunk

Many-To-One Relationship: [adx_sitemigrationchunk team_adx_sitemigrationchunk](adx_sitemigrationchunk.md#BKMK_team_adx_sitemigrationchunk)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitemigrationchunk`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_sitemigrationchunk`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_sitemigrationrun"></a> team_adx_sitemigrationrun

Many-To-One Relationship: [adx_sitemigrationrun team_adx_sitemigrationrun](adx_sitemigrationrun.md#BKMK_team_adx_sitemigrationrun)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitemigrationrun`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_sitemigrationrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_sitesetting"></a> team_adx_sitesetting

Many-To-One Relationship: [adx_sitesetting team_adx_sitesetting](adx_sitesetting.md#BKMK_team_adx_sitesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitesetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_sitesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_tag"></a> team_adx_tag

Many-To-One Relationship: [adx_tag team_adx_tag](adx_tag.md#BKMK_team_adx_tag)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_tag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_tag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_urlhistory"></a> team_adx_urlhistory

Many-To-One Relationship: [adx_urlhistory team_adx_urlhistory](adx_urlhistory.md#BKMK_team_adx_urlhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_urlhistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_urlhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webfile"></a> team_adx_webfile

Many-To-One Relationship: [adx_webfile team_adx_webfile](adx_webfile.md#BKMK_team_adx_webfile)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webfile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webfilelog"></a> team_adx_webfilelog

Many-To-One Relationship: [adx_webfilelog team_adx_webfilelog](adx_webfilelog.md#BKMK_team_adx_webfilelog)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfilelog`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webfilelog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webform"></a> team_adx_webform

Many-To-One Relationship: [adx_webform team_adx_webform](adx_webform.md#BKMK_team_adx_webform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webform`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_weblink"></a> team_adx_weblink

Many-To-One Relationship: [adx_weblink team_adx_weblink](adx_weblink.md#BKMK_team_adx_weblink)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_weblink`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_weblink`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_weblinkset"></a> team_adx_weblinkset

Many-To-One Relationship: [adx_weblinkset team_adx_weblinkset](adx_weblinkset.md#BKMK_team_adx_weblinkset)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_weblinkset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_weblinkset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webnotificationurl"></a> team_adx_webnotificationurl

Many-To-One Relationship: [adx_webnotificationurl team_adx_webnotificationurl](adx_webnotificationurl.md#BKMK_team_adx_webnotificationurl)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webnotificationurl`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webnotificationurl`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webpage"></a> team_adx_webpage

Many-To-One Relationship: [adx_webpage team_adx_webpage](adx_webpage.md#BKMK_team_adx_webpage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webpageaccesscontrolrule"></a> team_adx_webpageaccesscontrolrule

Many-To-One Relationship: [adx_webpageaccesscontrolrule team_adx_webpageaccesscontrolrule](adx_webpageaccesscontrolrule.md#BKMK_team_adx_webpageaccesscontrolrule)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpageaccesscontrolrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webpageaccesscontrolrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webpagehistory"></a> team_adx_webpagehistory

Many-To-One Relationship: [adx_webpagehistory team_adx_webpagehistory](adx_webpagehistory.md#BKMK_team_adx_webpagehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpagehistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webpagehistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webpagelog"></a> team_adx_webpagelog

Many-To-One Relationship: [adx_webpagelog team_adx_webpagelog](adx_webpagelog.md#BKMK_team_adx_webpagelog)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpagelog`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webpagelog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_webrole"></a> team_adx_webrole

Many-To-One Relationship: [adx_webrole team_adx_webrole](adx_webrole.md#BKMK_team_adx_webrole)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webrole`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_webrole`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_website"></a> team_adx_website

Many-To-One Relationship: [adx_website team_adx_website](adx_website.md#BKMK_team_adx_website)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_website`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_website`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_websiteaccess"></a> team_adx_websiteaccess

Many-To-One Relationship: [adx_websiteaccess team_adx_websiteaccess](adx_websiteaccess.md#BKMK_team_adx_websiteaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websiteaccess`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_websiteaccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_websitelanguage"></a> team_adx_websitelanguage

Many-To-One Relationship: [adx_websitelanguage team_adx_websitelanguage](adx_websitelanguage.md#BKMK_team_adx_websitelanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websitelanguage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_websitelanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_adx_websitemigrationtracker"></a> team_adx_websitemigrationtracker

Many-To-One Relationship: [adx_websitemigrationtracker team_adx_websitemigrationtracker](adx_websitemigrationtracker.md#BKMK_team_adx_websitemigrationtracker)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websitemigrationtracker`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_adx_websitemigrationtracker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bookableresource"></a> team_bookableresource

Many-To-One Relationship: [bookableresource team_bookableresource](bookableresource.md#BKMK_team_bookableresource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bookableresource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bookableresourcebooking"></a> team_bookableresourcebooking

Many-To-One Relationship: [bookableresourcebooking team_bookableresourcebooking](bookableresourcebooking.md#BKMK_team_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bookableresourcebooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bookableresourcebookingheader"></a> team_bookableresourcebookingheader

Many-To-One Relationship: [bookableresourcebookingheader team_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_team_bookableresourcebookingheader)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebookingheader`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bookableresourcebookingheader`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bookableresourcecategory"></a> team_bookableresourcecategory

Many-To-One Relationship: [bookableresourcecategory team_bookableresourcecategory](bookableresourcecategory.md#BKMK_team_bookableresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bookableresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bookableresourcecategoryassn"></a> team_bookableresourcecategoryassn

Many-To-One Relationship: [bookableresourcecategoryassn team_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_team_bookableresourcecategoryassn)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategoryassn`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bookableresourcecategoryassn`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bookableresourcecharacteristic"></a> team_bookableresourcecharacteristic

Many-To-One Relationship: [bookableresourcecharacteristic team_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_team_bookableresourcecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecharacteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bookableresourcecharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bookableresourcegroup"></a> team_bookableresourcegroup

Many-To-One Relationship: [bookableresourcegroup team_bookableresourcegroup](bookableresourcegroup.md#BKMK_team_bookableresourcegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcegroup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bookableresourcegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bookingstatus"></a> team_bookingstatus

Many-To-One Relationship: [bookingstatus team_bookingstatus](bookingstatus.md#BKMK_team_bookingstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`bookingstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bookingstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_BulkOperation"></a> team_BulkOperation

Many-To-One Relationship: [bulkoperation team_BulkOperation](bulkoperation.md#BKMK_team_BulkOperation)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_BulkOperation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_bulkoperationlog"></a> team_bulkoperationlog

Many-To-One Relationship: [bulkoperationlog team_bulkoperationlog](bulkoperationlog.md#BKMK_team_bulkoperationlog)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_bulkoperationlog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_campaignactivity"></a> team_campaignactivity

Many-To-One Relationship: [campaignactivity team_campaignactivity](campaignactivity.md#BKMK_team_campaignactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_campaignactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_campaignresponse"></a> team_campaignresponse

Many-To-One Relationship: [campaignresponse team_campaignresponse](campaignresponse.md#BKMK_team_campaignresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_campaignresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_Campaigns"></a> team_Campaigns

Many-To-One Relationship: [campaign team_Campaigns](campaign.md#BKMK_team_Campaigns)

|Property|Value|
|---|---|
|ReferencingEntity|`campaign`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_Campaigns`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_characteristic"></a> team_characteristic

Many-To-One Relationship: [characteristic team_characteristic](characteristic.md#BKMK_team_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`characteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_characteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_contractdetail"></a> team_contractdetail

Many-To-One Relationship: [contractdetail team_contractdetail](contractdetail.md#BKMK_team_contractdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`contractdetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_contractdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_DynamicPropertyInstance"></a> team_DynamicPropertyInstance

Many-To-One Relationship: [dynamicpropertyinstance team_DynamicPropertyInstance](dynamicpropertyinstance.md#BKMK_team_DynamicPropertyInstance)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_DynamicPropertyInstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_entitlement"></a> team_entitlement

Many-To-One Relationship: [entitlement team_entitlement](entitlement.md#BKMK_team_entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_entitlement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_entitlementchannel"></a> team_entitlementchannel

Many-To-One Relationship: [entitlementchannel team_entitlementchannel](entitlementchannel.md#BKMK_team_entitlementchannel)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementchannel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_entitlementchannel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_entitlemententityallocationtypemapping"></a> team_entitlemententityallocationtypemapping

Many-To-One Relationship: [entitlemententityallocationtypemapping team_entitlemententityallocationtypemapping](entitlemententityallocationtypemapping.md#BKMK_team_entitlemententityallocationtypemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlemententityallocationtypemapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_entitlemententityallocationtypemapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_federatedknowledgeconfiguration"></a> team_federatedknowledgeconfiguration

Many-To-One Relationship: [federatedknowledgeconfiguration team_federatedknowledgeconfiguration](federatedknowledgeconfiguration.md#BKMK_team_federatedknowledgeconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`federatedknowledgeconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_federatedknowledgeconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_federatedknowledgeentityconfiguration"></a> team_federatedknowledgeentityconfiguration

Many-To-One Relationship: [federatedknowledgeentityconfiguration team_federatedknowledgeentityconfiguration](federatedknowledgeentityconfiguration.md#BKMK_team_federatedknowledgeentityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`federatedknowledgeentityconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_federatedknowledgeentityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_incidentresolution"></a> team_incidentresolution

Many-To-One Relationship: [incidentresolution team_incidentresolution](incidentresolution.md#BKMK_team_incidentresolution)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_incidentresolution`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_incidents"></a> team_incidents

Many-To-One Relationship: [incident team_incidents](incident.md#BKMK_team_incidents)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_incidents`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_invoicedetail"></a> team_invoicedetail

Many-To-One Relationship: [invoicedetail team_invoicedetail](invoicedetail.md#BKMK_team_invoicedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_invoicedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_invoices"></a> team_invoices

Many-To-One Relationship: [invoice team_invoices](invoice.md#BKMK_team_invoices)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_invoices`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_knowledgearticleincident"></a> team_knowledgearticleincident

Many-To-One Relationship: [knowledgearticleincident team_knowledgearticleincident](knowledgearticleincident.md#BKMK_team_knowledgearticleincident)

|Property|Value|
|---|---|
|ReferencingEntity|`knowledgearticleincident`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_knowledgearticleincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_list"></a> team_list

Many-To-One Relationship: [list team_list](list.md#BKMK_team_list)

|Property|Value|
|---|---|
|ReferencingEntity|`list`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_list`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_listoperation"></a> team_listoperation

Many-To-One Relationship: [listoperation team_listoperation](listoperation.md#BKMK_team_listoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`listoperation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_listoperation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_activitymappingmetadatabase"></a> team_mscipriv_activitymappingmetadatabase

Many-To-One Relationship: [mscipriv_activitymappingmetadatabase team_mscipriv_activitymappingmetadatabase](mscipriv_activitymappingmetadatabase.md#BKMK_team_mscipriv_activitymappingmetadatabase)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_activitymappingmetadatabase`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_activitymappingmetadatabase`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_additionalentityinfo"></a> team_mscipriv_additionalentityinfo

Many-To-One Relationship: [mscipriv_additionalentityinfo team_mscipriv_additionalentityinfo](mscipriv_additionalentityinfo.md#BKMK_team_mscipriv_additionalentityinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_additionalentityinfo`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_additionalentityinfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_aibuildercallbacktesthook"></a> team_mscipriv_aibuildercallbacktesthook

Many-To-One Relationship: [mscipriv_aibuildercallbacktesthook team_mscipriv_aibuildercallbacktesthook](mscipriv_aibuildercallbacktesthook.md#BKMK_team_mscipriv_aibuildercallbacktesthook)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_aibuildercallbacktesthook`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_aibuildercallbacktesthook`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_aibuildermodelmetadata"></a> team_mscipriv_aibuildermodelmetadata

Many-To-One Relationship: [mscipriv_aibuildermodelmetadata team_mscipriv_aibuildermodelmetadata](mscipriv_aibuildermodelmetadata.md#BKMK_team_mscipriv_aibuildermodelmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_aibuildermodelmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_aibuildermodelmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_analysisinstanceconfig"></a> team_mscipriv_analysisinstanceconfig

Many-To-One Relationship: [mscipriv_analysisinstanceconfig team_mscipriv_analysisinstanceconfig](mscipriv_analysisinstanceconfig.md#BKMK_team_mscipriv_analysisinstanceconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_analysisinstanceconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_analysisinstanceconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_analysismetadata"></a> team_mscipriv_analysismetadata

Many-To-One Relationship: [mscipriv_analysismetadata team_mscipriv_analysismetadata](mscipriv_analysismetadata.md#BKMK_team_mscipriv_analysismetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_analysismetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_analysismetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_azuremlwebservice"></a> team_mscipriv_azuremlwebservice

Many-To-One Relationship: [mscipriv_azuremlwebservice team_mscipriv_azuremlwebservice](mscipriv_azuremlwebservice.md#BKMK_team_mscipriv_azuremlwebservice)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_azuremlwebservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_azuremlwebservice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_businessunitconfiguration"></a> team_mscipriv_businessunitconfiguration

Many-To-One Relationship: [mscipriv_businessunitconfiguration team_mscipriv_businessunitconfiguration](mscipriv_businessunitconfiguration.md#BKMK_team_mscipriv_businessunitconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_businessunitconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_businessunitconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_cdsamodelmetadata"></a> team_mscipriv_cdsamodelmetadata

Many-To-One Relationship: [mscipriv_cdsamodelmetadata team_mscipriv_cdsamodelmetadata](mscipriv_cdsamodelmetadata.md#BKMK_team_mscipriv_cdsamodelmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_cdsamodelmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_cdsamodelmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_clusterloadmetadata"></a> team_mscipriv_clusterloadmetadata

Many-To-One Relationship: [mscipriv_clusterloadmetadata team_mscipriv_clusterloadmetadata](mscipriv_clusterloadmetadata.md#BKMK_team_mscipriv_clusterloadmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_clusterloadmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_clusterloadmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_conflationcriteriastatistics"></a> team_mscipriv_conflationcriteriastatistics

Many-To-One Relationship: [mscipriv_conflationcriteriastatistics team_mscipriv_conflationcriteriastatistics](mscipriv_conflationcriteriastatistics.md#BKMK_team_mscipriv_conflationcriteriastatistics)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_conflationcriteriastatistics`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_conflationcriteriastatistics`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_conflationmetadata"></a> team_mscipriv_conflationmetadata

Many-To-One Relationship: [mscipriv_conflationmetadata team_mscipriv_conflationmetadata](mscipriv_conflationmetadata.md#BKMK_team_mscipriv_conflationmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_conflationmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_conflationmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_conflationrun"></a> team_mscipriv_conflationrun

Many-To-One Relationship: [mscipriv_conflationrun team_mscipriv_conflationrun](mscipriv_conflationrun.md#BKMK_team_mscipriv_conflationrun)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_conflationrun`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_conflationrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_conflationstatistics"></a> team_mscipriv_conflationstatistics

Many-To-One Relationship: [mscipriv_conflationstatistics team_mscipriv_conflationstatistics](mscipriv_conflationstatistics.md#BKMK_team_mscipriv_conflationstatistics)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_conflationstatistics`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_conflationstatistics`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_consentsettings"></a> team_mscipriv_consentsettings

Many-To-One Relationship: [mscipriv_consentsettings team_mscipriv_consentsettings](mscipriv_consentsettings.md#BKMK_team_mscipriv_consentsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_consentsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_consentsettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_dataflowmetadata"></a> team_mscipriv_dataflowmetadata

Many-To-One Relationship: [mscipriv_dataflowmetadata team_mscipriv_dataflowmetadata](mscipriv_dataflowmetadata.md#BKMK_team_mscipriv_dataflowmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataflowmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_dataflowmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_datapreparationmetadata"></a> team_mscipriv_datapreparationmetadata

Many-To-One Relationship: [mscipriv_datapreparationmetadata team_mscipriv_datapreparationmetadata](mscipriv_datapreparationmetadata.md#BKMK_team_mscipriv_datapreparationmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_datapreparationmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_datapreparationmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_dataqualityfeaturewisemetadata"></a> team_mscipriv_dataqualityfeaturewisemetadata

Many-To-One Relationship: [mscipriv_dataqualityfeaturewisemetadata team_mscipriv_dataqualityfeaturewisemetadata](mscipriv_dataqualityfeaturewisemetadata.md#BKMK_team_mscipriv_dataqualityfeaturewisemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataqualityfeaturewisemetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_dataqualityfeaturewisemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_dataqualityoverview"></a> team_mscipriv_dataqualityoverview

Many-To-One Relationship: [mscipriv_dataqualityoverview team_mscipriv_dataqualityoverview](mscipriv_dataqualityoverview.md#BKMK_team_mscipriv_dataqualityoverview)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataqualityoverview`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_dataqualityoverview`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_dataqualityreport"></a> team_mscipriv_dataqualityreport

Many-To-One Relationship: [mscipriv_dataqualityreport team_mscipriv_dataqualityreport](mscipriv_dataqualityreport.md#BKMK_team_mscipriv_dataqualityreport)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataqualityreport`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_dataqualityreport`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_datasetcatalog"></a> team_mscipriv_datasetcatalog

Many-To-One Relationship: [mscipriv_datasetcatalog team_mscipriv_datasetcatalog](mscipriv_datasetcatalog.md#BKMK_team_mscipriv_datasetcatalog)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_datasetcatalog`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_datasetcatalog`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_datasourcemetadata"></a> team_mscipriv_datasourcemetadata

Many-To-One Relationship: [mscipriv_datasourcemetadata team_mscipriv_datasourcemetadata](mscipriv_datasourcemetadata.md#BKMK_team_mscipriv_datasourcemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_datasourcemetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_datasourcemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_datatroubleshootingaccess"></a> team_mscipriv_datatroubleshootingaccess

Many-To-One Relationship: [mscipriv_datatroubleshootingaccess team_mscipriv_datatroubleshootingaccess](mscipriv_datatroubleshootingaccess.md#BKMK_team_mscipriv_datatroubleshootingaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_datatroubleshootingaccess`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_datatroubleshootingaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_dataverseentitydatacleanupjobinfo"></a> team_mscipriv_dataverseentitydatacleanupjobinfo

Many-To-One Relationship: [mscipriv_dataverseentitydatacleanupjobinfo team_mscipriv_dataverseentitydatacleanupjobinfo](mscipriv_dataverseentitydatacleanupjobinfo.md#BKMK_team_mscipriv_dataverseentitydatacleanupjobinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataverseentitydatacleanupjobinfo`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_dataverseentitydatacleanupjobinfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_derivedentitymetadata"></a> team_mscipriv_derivedentitymetadata

Many-To-One Relationship: [mscipriv_derivedentitymetadata team_mscipriv_derivedentitymetadata](mscipriv_derivedentitymetadata.md#BKMK_team_mscipriv_derivedentitymetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_derivedentitymetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_derivedentitymetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_diagnosticsetting"></a> team_mscipriv_diagnosticsetting

Many-To-One Relationship: [mscipriv_diagnosticsetting team_mscipriv_diagnosticsetting](mscipriv_diagnosticsetting.md#BKMK_team_mscipriv_diagnosticsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_diagnosticsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_diagnosticsetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_discoveredcdsamodel"></a> team_mscipriv_discoveredcdsamodel

Many-To-One Relationship: [mscipriv_discoveredcdsamodel team_mscipriv_discoveredcdsamodel](mscipriv_discoveredcdsamodel.md#BKMK_team_mscipriv_discoveredcdsamodel)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_discoveredcdsamodel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_discoveredcdsamodel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_discoveryoperation"></a> team_mscipriv_discoveryoperation

Many-To-One Relationship: [mscipriv_discoveryoperation team_mscipriv_discoveryoperation](mscipriv_discoveryoperation.md#BKMK_team_mscipriv_discoveryoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_discoveryoperation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_discoveryoperation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_enrichmentmetadata"></a> team_mscipriv_enrichmentmetadata

Many-To-One Relationship: [mscipriv_enrichmentmetadata team_mscipriv_enrichmentmetadata](mscipriv_enrichmentmetadata.md#BKMK_team_mscipriv_enrichmentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_enrichmentmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_enrichmentmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_enrichmentrun"></a> team_mscipriv_enrichmentrun

Many-To-One Relationship: [mscipriv_enrichmentrun team_mscipriv_enrichmentrun](mscipriv_enrichmentrun.md#BKMK_team_mscipriv_enrichmentrun)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_enrichmentrun`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_enrichmentrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_entityfiltermetadata"></a> team_mscipriv_entityfiltermetadata

Many-To-One Relationship: [mscipriv_entityfiltermetadata team_mscipriv_entityfiltermetadata](mscipriv_entityfiltermetadata.md#BKMK_team_mscipriv_entityfiltermetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_entityfiltermetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_entityfiltermetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_exportconfig"></a> team_mscipriv_exportconfig

Many-To-One Relationship: [mscipriv_exportconfig team_mscipriv_exportconfig](mscipriv_exportconfig.md#BKMK_team_mscipriv_exportconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_exportconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_exportconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_exportconfigreport"></a> team_mscipriv_exportconfigreport

Many-To-One Relationship: [mscipriv_exportconfigreport team_mscipriv_exportconfigreport](mscipriv_exportconfigreport.md#BKMK_team_mscipriv_exportconfigreport)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_exportconfigreport`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_exportconfigreport`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_exportedmoduleconfiguration"></a> team_mscipriv_exportedmoduleconfiguration

Many-To-One Relationship: [mscipriv_exportedmoduleconfiguration team_mscipriv_exportedmoduleconfiguration](mscipriv_exportedmoduleconfiguration.md#BKMK_team_mscipriv_exportedmoduleconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_exportedmoduleconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_exportedmoduleconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_exportsettings"></a> team_mscipriv_exportsettings

Many-To-One Relationship: [mscipriv_exportsettings team_mscipriv_exportsettings](mscipriv_exportsettings.md#BKMK_team_mscipriv_exportsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_exportsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_exportsettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_featuretemplate"></a> team_mscipriv_featuretemplate

Many-To-One Relationship: [mscipriv_featuretemplate team_mscipriv_featuretemplate](mscipriv_featuretemplate.md#BKMK_team_mscipriv_featuretemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_featuretemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_featuretemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_graphmetadata"></a> team_mscipriv_graphmetadata

Many-To-One Relationship: [mscipriv_graphmetadata team_mscipriv_graphmetadata](mscipriv_graphmetadata.md#BKMK_team_mscipriv_graphmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_graphmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_graphmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_hierarchymetadata"></a> team_mscipriv_hierarchymetadata

Many-To-One Relationship: [mscipriv_hierarchymetadata team_mscipriv_hierarchymetadata](mscipriv_hierarchymetadata.md#BKMK_team_mscipriv_hierarchymetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_hierarchymetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_hierarchymetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_hostloadmetadata"></a> team_mscipriv_hostloadmetadata

Many-To-One Relationship: [mscipriv_hostloadmetadata team_mscipriv_hostloadmetadata](mscipriv_hostloadmetadata.md#BKMK_team_mscipriv_hostloadmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_hostloadmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_hostloadmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_importexportstatusmetadata"></a> team_mscipriv_importexportstatusmetadata

Many-To-One Relationship: [mscipriv_importexportstatusmetadata team_mscipriv_importexportstatusmetadata](mscipriv_importexportstatusmetadata.md#BKMK_team_mscipriv_importexportstatusmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_importexportstatusmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_importexportstatusmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_insightmetadata"></a> team_mscipriv_insightmetadata

Many-To-One Relationship: [mscipriv_insightmetadata team_mscipriv_insightmetadata](mscipriv_insightmetadata.md#BKMK_team_mscipriv_insightmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_insightmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_insightmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_insightsdataqualityreport"></a> team_mscipriv_insightsdataqualityreport

Many-To-One Relationship: [mscipriv_insightsdataqualityreport team_mscipriv_insightsdataqualityreport](mscipriv_insightsdataqualityreport.md#BKMK_team_mscipriv_insightsdataqualityreport)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_insightsdataqualityreport`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_insightsdataqualityreport`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_instancemetrics"></a> team_mscipriv_instancemetrics

Many-To-One Relationship: [mscipriv_instancemetrics team_mscipriv_instancemetrics](mscipriv_instancemetrics.md#BKMK_team_mscipriv_instancemetrics)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_instancemetrics`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_instancemetrics`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_instancepartnercatalog"></a> team_mscipriv_instancepartnercatalog

Many-To-One Relationship: [mscipriv_instancepartnercatalog team_mscipriv_instancepartnercatalog](mscipriv_instancepartnercatalog.md#BKMK_team_mscipriv_instancepartnercatalog)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_instancepartnercatalog`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_instancepartnercatalog`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_instancesearchconfiguration"></a> team_mscipriv_instancesearchconfiguration

Many-To-One Relationship: [mscipriv_instancesearchconfiguration team_mscipriv_instancesearchconfiguration](mscipriv_instancesearchconfiguration.md#BKMK_team_mscipriv_instancesearchconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_instancesearchconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_instancesearchconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_instancesettings"></a> team_mscipriv_instancesettings

Many-To-One Relationship: [mscipriv_instancesettings team_mscipriv_instancesettings](mscipriv_instancesettings.md#BKMK_team_mscipriv_instancesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_instancesettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_instancesettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_intelligenceworkflowmetadata"></a> team_mscipriv_intelligenceworkflowmetadata

Many-To-One Relationship: [mscipriv_intelligenceworkflowmetadata team_mscipriv_intelligenceworkflowmetadata](mscipriv_intelligenceworkflowmetadata.md#BKMK_team_mscipriv_intelligenceworkflowmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_intelligenceworkflowmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_intelligenceworkflowmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_intelligenceworkflowrunmetadata"></a> team_mscipriv_intelligenceworkflowrunmetadata

Many-To-One Relationship: [mscipriv_intelligenceworkflowrunmetadata team_mscipriv_intelligenceworkflowrunmetadata](mscipriv_intelligenceworkflowrunmetadata.md#BKMK_team_mscipriv_intelligenceworkflowrunmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_intelligenceworkflowrunmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_intelligenceworkflowrunmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_intelligenceworkspacemetadata"></a> team_mscipriv_intelligenceworkspacemetadata

Many-To-One Relationship: [mscipriv_intelligenceworkspacemetadata team_mscipriv_intelligenceworkspacemetadata](mscipriv_intelligenceworkspacemetadata.md#BKMK_team_mscipriv_intelligenceworkspacemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_intelligenceworkspacemetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_intelligenceworkspacemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_keyvaultmetadata"></a> team_mscipriv_keyvaultmetadata

Many-To-One Relationship: [mscipriv_keyvaultmetadata team_mscipriv_keyvaultmetadata](mscipriv_keyvaultmetadata.md#BKMK_team_mscipriv_keyvaultmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_keyvaultmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_keyvaultmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_lightcdsamodelmetadata"></a> team_mscipriv_lightcdsamodelmetadata

Many-To-One Relationship: [mscipriv_lightcdsamodelmetadata team_mscipriv_lightcdsamodelmetadata](mscipriv_lightcdsamodelmetadata.md#BKMK_team_mscipriv_lightcdsamodelmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_lightcdsamodelmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_lightcdsamodelmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_logicappssubscribermetadata"></a> team_mscipriv_logicappssubscribermetadata

Many-To-One Relationship: [mscipriv_logicappssubscribermetadata team_mscipriv_logicappssubscribermetadata](mscipriv_logicappssubscribermetadata.md#BKMK_team_mscipriv_logicappssubscribermetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_logicappssubscribermetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_logicappssubscribermetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_mappedsecretmetadata"></a> team_mscipriv_mappedsecretmetadata

Many-To-One Relationship: [mscipriv_mappedsecretmetadata team_mscipriv_mappedsecretmetadata](mscipriv_mappedsecretmetadata.md#BKMK_team_mscipriv_mappedsecretmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_mappedsecretmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_mappedsecretmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_measuremetadata"></a> team_mscipriv_measuremetadata

Many-To-One Relationship: [mscipriv_measuremetadata team_mscipriv_measuremetadata](mscipriv_measuremetadata.md#BKMK_team_mscipriv_measuremetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_measuremetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_measuremetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_modelconfigmetadata"></a> team_mscipriv_modelconfigmetadata

Many-To-One Relationship: [mscipriv_modelconfigmetadata team_mscipriv_modelconfigmetadata](mscipriv_modelconfigmetadata.md#BKMK_team_mscipriv_modelconfigmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_modelconfigmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_modelconfigmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_moduleconfigurationreference"></a> team_mscipriv_moduleconfigurationreference

Many-To-One Relationship: [mscipriv_moduleconfigurationreference team_mscipriv_moduleconfigurationreference](mscipriv_moduleconfigurationreference.md#BKMK_team_mscipriv_moduleconfigurationreference)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_moduleconfigurationreference`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_moduleconfigurationreference`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_notificationcheckpoint"></a> team_mscipriv_notificationcheckpoint

Many-To-One Relationship: [mscipriv_notificationcheckpoint team_mscipriv_notificationcheckpoint](mscipriv_notificationcheckpoint.md#BKMK_team_mscipriv_notificationcheckpoint)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_notificationcheckpoint`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_notificationcheckpoint`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_packageimportmetadata"></a> team_mscipriv_packageimportmetadata

Many-To-One Relationship: [mscipriv_packageimportmetadata team_mscipriv_packageimportmetadata](mscipriv_packageimportmetadata.md#BKMK_team_mscipriv_packageimportmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_packageimportmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_packageimportmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_packagejobmetadata"></a> team_mscipriv_packagejobmetadata

Many-To-One Relationship: [mscipriv_packagejobmetadata team_mscipriv_packagejobmetadata](mscipriv_packagejobmetadata.md#BKMK_team_mscipriv_packagejobmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_packagejobmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_packagejobmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_packagemetadata"></a> team_mscipriv_packagemetadata

Many-To-One Relationship: [mscipriv_packagemetadata team_mscipriv_packagemetadata](mscipriv_packagemetadata.md#BKMK_team_mscipriv_packagemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_packagemetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_packagemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_platforminstancemapping"></a> team_mscipriv_platforminstancemapping

Many-To-One Relationship: [mscipriv_platforminstancemapping team_mscipriv_platforminstancemapping](mscipriv_platforminstancemapping.md#BKMK_team_mscipriv_platforminstancemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_platforminstancemapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_platforminstancemapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_powerplatformconnector"></a> team_mscipriv_powerplatformconnector

Many-To-One Relationship: [mscipriv_powerplatformconnector team_mscipriv_powerplatformconnector](mscipriv_powerplatformconnector.md#BKMK_team_mscipriv_powerplatformconnector)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_powerplatformconnector`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_powerplatformconnector`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_powerplatformrefreshsignalmetadata"></a> team_mscipriv_powerplatformrefreshsignalmetadata

Many-To-One Relationship: [mscipriv_powerplatformrefreshsignalmetadata team_mscipriv_powerplatformrefreshsignalmetadata](mscipriv_powerplatformrefreshsignalmetadata.md#BKMK_team_mscipriv_powerplatformrefreshsignalmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_powerplatformrefreshsignalmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_powerplatformrefreshsignalmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_preenrichmentmetadata"></a> team_mscipriv_preenrichmentmetadata

Many-To-One Relationship: [mscipriv_preenrichmentmetadata team_mscipriv_preenrichmentmetadata](mscipriv_preenrichmentmetadata.md#BKMK_team_mscipriv_preenrichmentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_preenrichmentmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_preenrichmentmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_profilestorestateinfo"></a> team_mscipriv_profilestorestateinfo

Many-To-One Relationship: [mscipriv_profilestorestateinfo team_mscipriv_profilestorestateinfo](mscipriv_profilestorestateinfo.md#BKMK_team_mscipriv_profilestorestateinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_profilestorestateinfo`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_profilestorestateinfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_realtimeaggregatedstats"></a> team_mscipriv_realtimeaggregatedstats

Many-To-One Relationship: [mscipriv_realtimeaggregatedstats team_mscipriv_realtimeaggregatedstats](mscipriv_realtimeaggregatedstats.md#BKMK_team_mscipriv_realtimeaggregatedstats)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimeaggregatedstats`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_realtimeaggregatedstats`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_realtimem3configuration"></a> team_mscipriv_realtimem3configuration

Many-To-One Relationship: [mscipriv_realtimem3configuration team_mscipriv_realtimem3configuration](mscipriv_realtimem3configuration.md#BKMK_team_mscipriv_realtimem3configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimem3configuration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_realtimem3configuration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_realtimem3searchconfiguration"></a> team_mscipriv_realtimem3searchconfiguration

Many-To-One Relationship: [mscipriv_realtimem3searchconfiguration team_mscipriv_realtimem3searchconfiguration](mscipriv_realtimem3searchconfiguration.md#BKMK_team_mscipriv_realtimem3searchconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimem3searchconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_realtimem3searchconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_realtimepluginmetadata"></a> team_mscipriv_realtimepluginmetadata

Many-To-One Relationship: [mscipriv_realtimepluginmetadata team_mscipriv_realtimepluginmetadata](mscipriv_realtimepluginmetadata.md#BKMK_team_mscipriv_realtimepluginmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimepluginmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_realtimepluginmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_realtimesystemtablemetadata"></a> team_mscipriv_realtimesystemtablemetadata

Many-To-One Relationship: [mscipriv_realtimesystemtablemetadata team_mscipriv_realtimesystemtablemetadata](mscipriv_realtimesystemtablemetadata.md#BKMK_team_mscipriv_realtimesystemtablemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimesystemtablemetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_realtimesystemtablemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_realtimetablemetadata"></a> team_mscipriv_realtimetablemetadata

Many-To-One Relationship: [mscipriv_realtimetablemetadata team_mscipriv_realtimetablemetadata](mscipriv_realtimetablemetadata.md#BKMK_team_mscipriv_realtimetablemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimetablemetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_realtimetablemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_refreshhistorymetadata"></a> team_mscipriv_refreshhistorymetadata

Many-To-One Relationship: [mscipriv_refreshhistorymetadata team_mscipriv_refreshhistorymetadata](mscipriv_refreshhistorymetadata.md#BKMK_team_mscipriv_refreshhistorymetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_refreshhistorymetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_refreshhistorymetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_refreshschedulebase"></a> team_mscipriv_refreshschedulebase

Many-To-One Relationship: [mscipriv_refreshschedulebase team_mscipriv_refreshschedulebase](mscipriv_refreshschedulebase.md#BKMK_team_mscipriv_refreshschedulebase)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_refreshschedulebase`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_refreshschedulebase`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_refreshstatehistorymetadata"></a> team_mscipriv_refreshstatehistorymetadata

Many-To-One Relationship: [mscipriv_refreshstatehistorymetadata team_mscipriv_refreshstatehistorymetadata](mscipriv_refreshstatehistorymetadata.md#BKMK_team_mscipriv_refreshstatehistorymetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_refreshstatehistorymetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_refreshstatehistorymetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_relationshipmetadata"></a> team_mscipriv_relationshipmetadata

Many-To-One Relationship: [mscipriv_relationshipmetadata team_mscipriv_relationshipmetadata](mscipriv_relationshipmetadata.md#BKMK_team_mscipriv_relationshipmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_relationshipmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_relationshipmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_reportmetadata"></a> team_mscipriv_reportmetadata

Many-To-One Relationship: [mscipriv_reportmetadata team_mscipriv_reportmetadata](mscipriv_reportmetadata.md#BKMK_team_mscipriv_reportmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_reportmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_reportmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_resetinstancehistory"></a> team_mscipriv_resetinstancehistory

Many-To-One Relationship: [mscipriv_resetinstancehistory team_mscipriv_resetinstancehistory](mscipriv_resetinstancehistory.md#BKMK_team_mscipriv_resetinstancehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_resetinstancehistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_resetinstancehistory`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_resourcemetadata"></a> team_mscipriv_resourcemetadata

Many-To-One Relationship: [mscipriv_resourcemetadata team_mscipriv_resourcemetadata](mscipriv_resourcemetadata.md#BKMK_team_mscipriv_resourcemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_resourcemetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_resourcemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_runtimerealtimem3metadata"></a> team_mscipriv_runtimerealtimem3metadata

Many-To-One Relationship: [mscipriv_runtimerealtimem3metadata team_mscipriv_runtimerealtimem3metadata](mscipriv_runtimerealtimem3metadata.md#BKMK_team_mscipriv_runtimerealtimem3metadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_runtimerealtimem3metadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_runtimerealtimem3metadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_segmentmetadata"></a> team_mscipriv_segmentmetadata

Many-To-One Relationship: [mscipriv_segmentmetadata team_mscipriv_segmentmetadata](mscipriv_segmentmetadata.md#BKMK_team_mscipriv_segmentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_segmentmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_segmentmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_semanticentitymappingmetadata"></a> team_mscipriv_semanticentitymappingmetadata

Many-To-One Relationship: [mscipriv_semanticentitymappingmetadata team_mscipriv_semanticentitymappingmetadata](mscipriv_semanticentitymappingmetadata.md#BKMK_team_mscipriv_semanticentitymappingmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_semanticentitymappingmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_semanticentitymappingmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_sparkjobexecutionmetadata"></a> team_mscipriv_sparkjobexecutionmetadata

Many-To-One Relationship: [mscipriv_sparkjobexecutionmetadata team_mscipriv_sparkjobexecutionmetadata](mscipriv_sparkjobexecutionmetadata.md#BKMK_team_mscipriv_sparkjobexecutionmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_sparkjobexecutionmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_sparkjobexecutionmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_systemintegrationmigrationtrackinginfo"></a> team_mscipriv_systemintegrationmigrationtrackinginfo

Many-To-One Relationship: [mscipriv_systemintegrationmigrationtrackinginfo team_mscipriv_systemintegrationmigrationtrackinginfo](mscipriv_systemintegrationmigrationtrackinginfo.md#BKMK_team_mscipriv_systemintegrationmigrationtrackinginfo)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_systemintegrationmigrationtrackinginfo`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_systemintegrationmigrationtrackinginfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_templatedmeasuremetadata"></a> team_mscipriv_templatedmeasuremetadata

Many-To-One Relationship: [mscipriv_templatedmeasuremetadata team_mscipriv_templatedmeasuremetadata](mscipriv_templatedmeasuremetadata.md#BKMK_team_mscipriv_templatedmeasuremetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_templatedmeasuremetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_templatedmeasuremetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_templatedsegmentmetadata"></a> team_mscipriv_templatedsegmentmetadata

Many-To-One Relationship: [mscipriv_templatedsegmentmetadata team_mscipriv_templatedsegmentmetadata](mscipriv_templatedsegmentmetadata.md#BKMK_team_mscipriv_templatedsegmentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_templatedsegmentmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_templatedsegmentmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_transformmetadata"></a> team_mscipriv_transformmetadata

Many-To-One Relationship: [mscipriv_transformmetadata team_mscipriv_transformmetadata](mscipriv_transformmetadata.md#BKMK_team_mscipriv_transformmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_transformmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_transformmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_mscipriv_unifiedactivitymappinggroupmetadata"></a> team_mscipriv_unifiedactivitymappinggroupmetadata

Many-To-One Relationship: [mscipriv_unifiedactivitymappinggroupmetadata team_mscipriv_unifiedactivitymappinggroupmetadata](mscipriv_unifiedactivitymappinggroupmetadata.md#BKMK_team_mscipriv_unifiedactivitymappinggroupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_unifiedactivitymappinggroupmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_mscipriv_unifiedactivitymappinggroupmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_actioncardactionstat"></a> team_msdyn_actioncardactionstat

Many-To-One Relationship: [msdyn_actioncardactionstat team_msdyn_actioncardactionstat](msdyn_actioncardactionstat.md#BKMK_team_msdyn_actioncardactionstat)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardactionstat`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_actioncardactionstat`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_actioncardregarding"></a> team_msdyn_actioncardregarding

Many-To-One Relationship: [msdyn_actioncardregarding team_msdyn_actioncardregarding](msdyn_actioncardregarding.md#BKMK_team_msdyn_actioncardregarding)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardregarding`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_actioncardregarding`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_actioncardrolesetting"></a> team_msdyn_actioncardrolesetting

Many-To-One Relationship: [msdyn_actioncardrolesetting team_msdyn_actioncardrolesetting](msdyn_actioncardrolesetting.md#BKMK_team_msdyn_actioncardrolesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardrolesetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_actioncardrolesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_actioncardstataggregation"></a> team_msdyn_actioncardstataggregation

Many-To-One Relationship: [msdyn_actioncardstataggregation team_msdyn_actioncardstataggregation](msdyn_actioncardstataggregation.md#BKMK_team_msdyn_actioncardstataggregation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardstataggregation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_actioncardstataggregation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_activeicdextension"></a> team_msdyn_activeicdextension

Many-To-One Relationship: [msdyn_activeicdextension team_msdyn_activeicdextension](msdyn_activeicdextension.md#BKMK_team_msdyn_activeicdextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_activeicdextension`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_activeicdextension`|
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

### <a name="BKMK_team_msdyn_adminappstate"></a> team_msdyn_adminappstate

Many-To-One Relationship: [msdyn_adminappstate team_msdyn_adminappstate](msdyn_adminappstate.md#BKMK_team_msdyn_adminappstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_adminappstate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_adminappstate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentcapacityprofileunit"></a> team_msdyn_agentcapacityprofileunit

Many-To-One Relationship: [msdyn_agentcapacityprofileunit team_msdyn_agentcapacityprofileunit](msdyn_agentcapacityprofileunit.md#BKMK_team_msdyn_agentcapacityprofileunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentcapacityprofileunit`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentcapacityprofileunit`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentcapacityupdatehistory"></a> team_msdyn_agentcapacityupdatehistory

Many-To-One Relationship: [msdyn_agentcapacityupdatehistory team_msdyn_agentcapacityupdatehistory](msdyn_agentcapacityupdatehistory.md#BKMK_team_msdyn_agentcapacityupdatehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentcapacityupdatehistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentcapacityupdatehistory`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentchannelstate"></a> team_msdyn_agentchannelstate

Many-To-One Relationship: [msdyn_agentchannelstate team_msdyn_agentchannelstate](msdyn_agentchannelstate.md#BKMK_team_msdyn_agentchannelstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentchannelstate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentchannelstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentstatus"></a> team_msdyn_agentstatus

Many-To-One Relationship: [msdyn_agentstatus team_msdyn_agentstatus](msdyn_agentstatus.md#BKMK_team_msdyn_agentstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentstatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentstatushistory"></a> team_msdyn_agentstatushistory

Many-To-One Relationship: [msdyn_agentstatushistory team_msdyn_agentstatushistory](msdyn_agentstatushistory.md#BKMK_team_msdyn_agentstatushistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentstatushistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentstatushistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreement"></a> team_msdyn_agreement

Many-To-One Relationship: [msdyn_agreement team_msdyn_agreement](msdyn_agreement.md#BKMK_team_msdyn_agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingdate"></a> team_msdyn_agreementbookingdate

Many-To-One Relationship: [msdyn_agreementbookingdate team_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_team_msdyn_agreementbookingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingincident"></a> team_msdyn_agreementbookingincident

Many-To-One Relationship: [msdyn_agreementbookingincident team_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_team_msdyn_agreementbookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingproduct"></a> team_msdyn_agreementbookingproduct

Many-To-One Relationship: [msdyn_agreementbookingproduct team_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_team_msdyn_agreementbookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingservice"></a> team_msdyn_agreementbookingservice

Many-To-One Relationship: [msdyn_agreementbookingservice team_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_team_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingservicetask"></a> team_msdyn_agreementbookingservicetask

Many-To-One Relationship: [msdyn_agreementbookingservicetask team_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_team_msdyn_agreementbookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementbookingsetup"></a> team_msdyn_agreementbookingsetup

Many-To-One Relationship: [msdyn_agreementbookingsetup team_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_team_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingsetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementbookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementinvoicedate"></a> team_msdyn_agreementinvoicedate

Many-To-One Relationship: [msdyn_agreementinvoicedate team_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_team_msdyn_agreementinvoicedate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicedate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementinvoicedate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementinvoiceproduct"></a> team_msdyn_agreementinvoiceproduct

Many-To-One Relationship: [msdyn_agreementinvoiceproduct team_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_team_msdyn_agreementinvoiceproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementinvoiceproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementinvoicesetup"></a> team_msdyn_agreementinvoicesetup

Many-To-One Relationship: [msdyn_agreementinvoicesetup team_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_team_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicesetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementinvoicesetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agreementsubstatus"></a> team_msdyn_agreementsubstatus

Many-To-One Relationship: [msdyn_agreementsubstatus team_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_team_msdyn_agreementsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementsubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agreementsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_aicontactsuggestion"></a> team_msdyn_aicontactsuggestion

Many-To-One Relationship: [msdyn_aicontactsuggestion team_msdyn_aicontactsuggestion](msdyn_aicontactsuggestion.md#BKMK_team_msdyn_aicontactsuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aicontactsuggestion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_aicontactsuggestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_analytics"></a> team_msdyn_analytics

Many-To-One Relationship: [msdyn_analytics team_msdyn_analytics](msdyn_analytics.md#BKMK_team_msdyn_analytics)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_analytics`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_analytics`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_analyticsadminsettings"></a> team_msdyn_analyticsadminsettings

Many-To-One Relationship: [msdyn_analyticsadminsettings team_msdyn_analyticsadminsettings](msdyn_analyticsadminsettings.md#BKMK_team_msdyn_analyticsadminsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_analyticsadminsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_analyticsadminsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_analyticsforcs"></a> team_msdyn_analyticsforcs

Many-To-One Relationship: [msdyn_analyticsforcs team_msdyn_analyticsforcs](msdyn_analyticsforcs.md#BKMK_team_msdyn_analyticsforcs)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_analyticsforcs`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_analyticsforcs`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_appconfiguration"></a> team_msdyn_appconfiguration

Many-To-One Relationship: [msdyn_appconfiguration team_msdyn_appconfiguration](msdyn_appconfiguration.md#BKMK_team_msdyn_appconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_appconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_applicationextension"></a> team_msdyn_applicationextension

Many-To-One Relationship: [msdyn_applicationextension team_msdyn_applicationextension](msdyn_applicationextension.md#BKMK_team_msdyn_applicationextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_applicationextension`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_applicationextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_applicationtabtemplate"></a> team_msdyn_applicationtabtemplate

Many-To-One Relationship: [msdyn_applicationtabtemplate team_msdyn_applicationtabtemplate](msdyn_applicationtabtemplate.md#BKMK_team_msdyn_applicationtabtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_applicationtabtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_applicationtabtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_appprofilerolemapping"></a> team_msdyn_appprofilerolemapping

Many-To-One Relationship: [msdyn_appprofilerolemapping team_msdyn_appprofilerolemapping](msdyn_appprofilerolemapping.md#BKMK_team_msdyn_appprofilerolemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appprofilerolemapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_appprofilerolemapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_appstate"></a> team_msdyn_appstate

Many-To-One Relationship: [msdyn_appstate team_msdyn_appstate](msdyn_appstate.md#BKMK_team_msdyn_appstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appstate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_appstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_assetcategorytemplateassociation"></a> team_msdyn_assetcategorytemplateassociation

Many-To-One Relationship: [msdyn_assetcategorytemplateassociation team_msdyn_assetcategorytemplateassociation](msdyn_assetcategorytemplateassociation.md#BKMK_team_msdyn_assetcategorytemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assetcategorytemplateassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_assetcategorytemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_assettemplateassociation"></a> team_msdyn_assettemplateassociation

Many-To-One Relationship: [msdyn_assettemplateassociation team_msdyn_assettemplateassociation](msdyn_assettemplateassociation.md#BKMK_team_msdyn_assettemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assettemplateassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_assettemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_assignmentconfiguration"></a> team_msdyn_assignmentconfiguration

Many-To-One Relationship: [msdyn_assignmentconfiguration team_msdyn_assignmentconfiguration](msdyn_assignmentconfiguration.md#BKMK_team_msdyn_assignmentconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_assignmentconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_assignmentconfigurationstep"></a> team_msdyn_assignmentconfigurationstep

Many-To-One Relationship: [msdyn_assignmentconfigurationstep team_msdyn_assignmentconfigurationstep](msdyn_assignmentconfigurationstep.md#BKMK_team_msdyn_assignmentconfigurationstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentconfigurationstep`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_assignmentconfigurationstep`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_assignmentmap"></a> team_msdyn_assignmentmap

Many-To-One Relationship: [msdyn_assignmentmap team_msdyn_assignmentmap](msdyn_assignmentmap.md#BKMK_team_msdyn_assignmentmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentmap`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_assignmentmap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_assignmentrule"></a> team_msdyn_assignmentrule

Many-To-One Relationship: [msdyn_assignmentrule team_msdyn_assignmentrule](msdyn_assignmentrule.md#BKMK_team_msdyn_assignmentrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_assignmentrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_attribute"></a> team_msdyn_attribute

Many-To-One Relationship: [msdyn_attribute team_msdyn_attribute](msdyn_attribute.md#BKMK_team_msdyn_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_attribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_attribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_attributevalue"></a> team_msdyn_attributevalue

Many-To-One Relationship: [msdyn_attributevalue team_msdyn_attributevalue](msdyn_attributevalue.md#BKMK_team_msdyn_attributevalue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_attributevalue`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_attributevalue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_authenticationsettings"></a> team_msdyn_authenticationsettings

Many-To-One Relationship: [msdyn_authenticationsettings team_msdyn_authenticationsettings](msdyn_authenticationsettings.md#BKMK_team_msdyn_authenticationsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_authenticationsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_authenticationsettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_authsettingsentry"></a> team_msdyn_authsettingsentry

Many-To-One Relationship: [msdyn_authsettingsentry team_msdyn_authsettingsentry](msdyn_authsettingsentry.md#BKMK_team_msdyn_authsettingsentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_authsettingsentry`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_authsettingsentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_autocapturerule"></a> team_msdyn_autocapturerule

Many-To-One Relationship: [msdyn_autocapturerule team_msdyn_autocapturerule](msdyn_autocapturerule.md#BKMK_team_msdyn_autocapturerule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autocapturerule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_autocapturerule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_autocapturesettings"></a> team_msdyn_autocapturesettings

Many-To-One Relationship: [msdyn_autocapturesettings team_msdyn_autocapturesettings](msdyn_autocapturesettings.md#BKMK_team_msdyn_autocapturesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autocapturesettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_autocapturesettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_autonomouscasecreationrule"></a> team_msdyn_autonomouscasecreationrule

Many-To-One Relationship: [msdyn_autonomouscasecreationrule team_msdyn_autonomouscasecreationrule](msdyn_autonomouscasecreationrule.md#BKMK_team_msdyn_autonomouscasecreationrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autonomouscasecreationrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_autonomouscasecreationrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bgjobledger"></a> team_msdyn_bgjobledger

Many-To-One Relationship: [msdyn_bgjobledger team_msdyn_bgjobledger](msdyn_bgjobledger.md#BKMK_team_msdyn_bgjobledger)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bgjobledger`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bgjobledger`|
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

### <a name="BKMK_team_msdyn_bookableresourcebookingquicknote"></a> team_msdyn_bookableresourcebookingquicknote

Many-To-One Relationship: [msdyn_bookableresourcebookingquicknote team_msdyn_bookableresourcebookingquicknote](msdyn_bookableresourcebookingquicknote.md#BKMK_team_msdyn_bookableresourcebookingquicknote)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookableresourcebookingquicknote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_bookableresourcecapacityprofile"></a> team_msdyn_bookableresourcecapacityprofile

Many-To-One Relationship: [msdyn_bookableresourcecapacityprofile team_msdyn_bookableresourcecapacityprofile](msdyn_bookableresourcecapacityprofile.md#BKMK_team_msdyn_bookableresourcecapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcecapacityprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookableresourcecapacityprofile`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_bookingjournal"></a> team_msdyn_bookingjournal

Many-To-One Relationship: [msdyn_bookingjournal team_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_team_msdyn_bookingjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingjournal`|
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

### <a name="BKMK_team_msdyn_bookingtimestamp"></a> team_msdyn_bookingtimestamp

Many-To-One Relationship: [msdyn_bookingtimestamp team_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_team_msdyn_bookingtimestamp)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingtimestamp`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookingtimestamp`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_botsession"></a> team_msdyn_botsession

Many-To-One Relationship: [msdyn_botsession team_msdyn_botsession](msdyn_botsession.md#BKMK_team_msdyn_botsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_botsession`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_botsession`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_callablecontext"></a> team_msdyn_callablecontext

Many-To-One Relationship: [msdyn_callablecontext team_msdyn_callablecontext](msdyn_callablecontext.md#BKMK_team_msdyn_callablecontext)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_callablecontext`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_callablecontext`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_capacityprofile"></a> team_msdyn_capacityprofile

Many-To-One Relationship: [msdyn_capacityprofile team_msdyn_capacityprofile](msdyn_capacityprofile.md#BKMK_team_msdyn_capacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_capacityprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_capacityprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_cdsentityengagementctx"></a> team_msdyn_cdsentityengagementctx

Many-To-One Relationship: [msdyn_cdsentityengagementctx team_msdyn_cdsentityengagementctx](msdyn_cdsentityengagementctx.md#BKMK_team_msdyn_cdsentityengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_cdsentityengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_cdsentityengagementctx`|
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

### <a name="BKMK_team_msdyn_channeldefinition"></a> team_msdyn_channeldefinition

Many-To-One Relationship: [msdyn_channeldefinition team_msdyn_channeldefinition](msdyn_channeldefinition.md#BKMK_team_msdyn_channeldefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channeldefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channeldefinitionconsent"></a> team_msdyn_channeldefinitionconsent

Many-To-One Relationship: [msdyn_channeldefinitionconsent team_msdyn_channeldefinitionconsent](msdyn_channeldefinitionconsent.md#BKMK_team_msdyn_channeldefinitionconsent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinitionconsent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channeldefinitionconsent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channeldefinitionlocale"></a> team_msdyn_channeldefinitionlocale

Many-To-One Relationship: [msdyn_channeldefinitionlocale team_msdyn_channeldefinitionlocale](msdyn_channeldefinitionlocale.md#BKMK_team_msdyn_channeldefinitionlocale)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinitionlocale`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channeldefinitionlocale`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channelinstance"></a> team_msdyn_channelinstance

Many-To-One Relationship: [msdyn_channelinstance team_msdyn_channelinstance](msdyn_channelinstance.md#BKMK_team_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channelinstanceaccount"></a> team_msdyn_channelinstanceaccount

Many-To-One Relationship: [msdyn_channelinstanceaccount team_msdyn_channelinstanceaccount](msdyn_channelinstanceaccount.md#BKMK_team_msdyn_channelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channelmessageattachment"></a> team_msdyn_channelmessageattachment

Many-To-One Relationship: [msdyn_channelmessageattachment team_msdyn_channelmessageattachment](msdyn_channelmessageattachment.md#BKMK_team_msdyn_channelmessageattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessageattachment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channelmessageattachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channelmessagecontextpart"></a> team_msdyn_channelmessagecontextpart

Many-To-One Relationship: [msdyn_channelmessagecontextpart team_msdyn_channelmessagecontextpart](msdyn_channelmessagecontextpart.md#BKMK_team_msdyn_channelmessagecontextpart)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessagecontextpart`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channelmessagecontextpart`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channelmessagepart"></a> team_msdyn_channelmessagepart

Many-To-One Relationship: [msdyn_channelmessagepart team_msdyn_channelmessagepart](msdyn_channelmessagepart.md#BKMK_team_msdyn_channelmessagepart)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessagepart`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channelmessagepart`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_channelprovider"></a> team_msdyn_channelprovider

Many-To-One Relationship: [msdyn_channelprovider team_msdyn_channelprovider](msdyn_channelprovider.md#BKMK_team_msdyn_channelprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelprovider`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_channelprovider`|
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

### <a name="BKMK_team_msdyn_consoleapplicationnotificationfield"></a> team_msdyn_consoleapplicationnotificationfield

Many-To-One Relationship: [msdyn_consoleapplicationnotificationfield team_msdyn_consoleapplicationnotificationfield](msdyn_consoleapplicationnotificationfield.md#BKMK_team_msdyn_consoleapplicationnotificationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationnotificationfield`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_consoleapplicationnotificationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_consoleapplicationnotificationtemplate"></a> team_msdyn_consoleapplicationnotificationtemplate

Many-To-One Relationship: [msdyn_consoleapplicationnotificationtemplate team_msdyn_consoleapplicationnotificationtemplate](msdyn_consoleapplicationnotificationtemplate.md#BKMK_team_msdyn_consoleapplicationnotificationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationnotificationtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_consoleapplicationnotificationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_consoleapplicationsessiontemplate"></a> team_msdyn_consoleapplicationsessiontemplate

Many-To-One Relationship: [msdyn_consoleapplicationsessiontemplate team_msdyn_consoleapplicationsessiontemplate](msdyn_consoleapplicationsessiontemplate.md#BKMK_team_msdyn_consoleapplicationsessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_consoleapplicationsessiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_consoleapplicationtemplate"></a> team_msdyn_consoleapplicationtemplate

Many-To-One Relationship: [msdyn_consoleapplicationtemplate team_msdyn_consoleapplicationtemplate](msdyn_consoleapplicationtemplate.md#BKMK_team_msdyn_consoleapplicationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_consoleapplicationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_consoleapplicationtemplateparameter"></a> team_msdyn_consoleapplicationtemplateparameter

Many-To-One Relationship: [msdyn_consoleapplicationtemplateparameter team_msdyn_consoleapplicationtemplateparameter](msdyn_consoleapplicationtemplateparameter.md#BKMK_team_msdyn_consoleapplicationtemplateparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationtemplateparameter`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_consoleapplicationtemplateparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_consumingapplication"></a> team_msdyn_consumingapplication

Many-To-One Relationship: [msdyn_consumingapplication team_msdyn_consumingapplication](msdyn_consumingapplication.md#BKMK_team_msdyn_consumingapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consumingapplication`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_consumingapplication`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_contactsuggestionrule"></a> team_msdyn_contactsuggestionrule

Many-To-One Relationship: [msdyn_contactsuggestionrule team_msdyn_contactsuggestionrule](msdyn_contactsuggestionrule.md#BKMK_team_msdyn_contactsuggestionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactsuggestionrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_contactsuggestionrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_contactsuggestionruleset"></a> team_msdyn_contactsuggestionruleset

Many-To-One Relationship: [msdyn_contactsuggestionruleset team_msdyn_contactsuggestionruleset](msdyn_contactsuggestionruleset.md#BKMK_team_msdyn_contactsuggestionruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactsuggestionruleset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_contactsuggestionruleset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationaction"></a> team_msdyn_conversationaction

Many-To-One Relationship: [msdyn_conversationaction team_msdyn_conversationaction](msdyn_conversationaction.md#BKMK_team_msdyn_conversationaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationaction`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationaction`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationactionitem"></a> team_msdyn_conversationactionitem

Many-To-One Relationship: [msdyn_conversationactionitem team_msdyn_conversationactionitem](msdyn_conversationactionitem.md#BKMK_team_msdyn_conversationactionitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionitem`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationactionitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationactionlocale"></a> team_msdyn_conversationactionlocale

Many-To-One Relationship: [msdyn_conversationactionlocale team_msdyn_conversationactionlocale](msdyn_conversationactionlocale.md#BKMK_team_msdyn_conversationactionlocale)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionlocale`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationactionlocale`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationaggregatedinsights"></a> team_msdyn_conversationaggregatedinsights

Many-To-One Relationship: [msdyn_conversationaggregatedinsights team_msdyn_conversationaggregatedinsights](msdyn_conversationaggregatedinsights.md#BKMK_team_msdyn_conversationaggregatedinsights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationaggregatedinsights`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationaggregatedinsights`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationcomment"></a> team_msdyn_conversationcomment

Many-To-One Relationship: [msdyn_conversationcomment team_msdyn_conversationcomment](msdyn_conversationcomment.md#BKMK_team_msdyn_conversationcomment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationcomment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationcomment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationdata"></a> team_msdyn_conversationdata

Many-To-One Relationship: [msdyn_conversationdata team_msdyn_conversationdata](msdyn_conversationdata.md#BKMK_team_msdyn_conversationdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationdata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationinsight"></a> team_msdyn_conversationinsight

Many-To-One Relationship: [msdyn_conversationinsight team_msdyn_conversationinsight](msdyn_conversationinsight.md#BKMK_team_msdyn_conversationinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationmessageblock"></a> team_msdyn_conversationmessageblock

Many-To-One Relationship: [msdyn_conversationmessageblock team_msdyn_conversationmessageblock](msdyn_conversationmessageblock.md#BKMK_team_msdyn_conversationmessageblock)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationmessageblock`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationmessageblock`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationparticipantinsights"></a> team_msdyn_conversationparticipantinsights

Many-To-One Relationship: [msdyn_conversationparticipantinsights team_msdyn_conversationparticipantinsights](msdyn_conversationparticipantinsights.md#BKMK_team_msdyn_conversationparticipantinsights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantinsights`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationparticipantinsights`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationparticipantsentiment"></a> team_msdyn_conversationparticipantsentiment

Many-To-One Relationship: [msdyn_conversationparticipantsentiment team_msdyn_conversationparticipantsentiment](msdyn_conversationparticipantsentiment.md#BKMK_team_msdyn_conversationparticipantsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantsentiment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationparticipantsentiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationquestion"></a> team_msdyn_conversationquestion

Many-To-One Relationship: [msdyn_conversationquestion team_msdyn_conversationquestion](msdyn_conversationquestion.md#BKMK_team_msdyn_conversationquestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationquestion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationquestion`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationsegmentsentiment"></a> team_msdyn_conversationsegmentsentiment

Many-To-One Relationship: [msdyn_conversationsegmentsentiment team_msdyn_conversationsegmentsentiment](msdyn_conversationsegmentsentiment.md#BKMK_team_msdyn_conversationsegmentsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsegmentsentiment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationsegmentsentiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationsentiment"></a> team_msdyn_conversationsentiment

Many-To-One Relationship: [msdyn_conversationsentiment team_msdyn_conversationsentiment](msdyn_conversationsentiment.md#BKMK_team_msdyn_conversationsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsentiment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationsentiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationsignal"></a> team_msdyn_conversationsignal

Many-To-One Relationship: [msdyn_conversationsignal team_msdyn_conversationsignal](msdyn_conversationsignal.md#BKMK_team_msdyn_conversationsignal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsignal`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationsignal`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationsubject"></a> team_msdyn_conversationsubject

Many-To-One Relationship: [msdyn_conversationsubject team_msdyn_conversationsubject](msdyn_conversationsubject.md#BKMK_team_msdyn_conversationsubject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsubject`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationsubject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationsummarysuggestion"></a> team_msdyn_conversationsummarysuggestion

Many-To-One Relationship: [msdyn_conversationsummarysuggestion team_msdyn_conversationsummarysuggestion](msdyn_conversationsummarysuggestion.md#BKMK_team_msdyn_conversationsummarysuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsummarysuggestion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationsummarysuggestion`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationsystemtag"></a> team_msdyn_conversationsystemtag

Many-To-One Relationship: [msdyn_conversationsystemtag team_msdyn_conversationsystemtag](msdyn_conversationsystemtag.md#BKMK_team_msdyn_conversationsystemtag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsystemtag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationsystemtag`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_conversationtag"></a> team_msdyn_conversationtag

Many-To-One Relationship: [msdyn_conversationtag team_msdyn_conversationtag](msdyn_conversationtag.md#BKMK_team_msdyn_conversationtag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_conversationtag`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_copilotagentpreference"></a> team_msdyn_copilotagentpreference

Many-To-One Relationship: [msdyn_copilotagentpreference team_msdyn_copilotagentpreference](msdyn_copilotagentpreference.md#BKMK_team_msdyn_copilotagentpreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotagentpreference`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_copilotagentpreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_copilotinteractiondata"></a> team_msdyn_copilotinteractiondata

Many-To-One Relationship: [msdyn_copilotinteractiondata team_msdyn_copilotinteractiondata](msdyn_copilotinteractiondata.md#BKMK_team_msdyn_copilotinteractiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotinteractiondata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_copilotinteractiondata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_copilottranscriptdata"></a> team_msdyn_copilottranscriptdata

Many-To-One Relationship: [msdyn_copilottranscriptdata team_msdyn_copilottranscriptdata](msdyn_copilottranscriptdata.md#BKMK_team_msdyn_copilottranscriptdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscriptdata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_copilottranscriptdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_crmconnection"></a> team_msdyn_crmconnection

Many-To-One Relationship: [msdyn_crmconnection team_msdyn_crmconnection](msdyn_crmconnection.md#BKMK_team_msdyn_crmconnection)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_crmconnection`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_crmconnection`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_csadminconfig"></a> team_msdyn_csadminconfig

Many-To-One Relationship: [msdyn_csadminconfig team_msdyn_csadminconfig](msdyn_csadminconfig.md#BKMK_team_msdyn_csadminconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_csadminconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_csadminconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_customapirulesetconfiguration"></a> team_msdyn_customapirulesetconfiguration

Many-To-One Relationship: [msdyn_customapirulesetconfiguration team_msdyn_customapirulesetconfiguration](msdyn_customapirulesetconfiguration.md#BKMK_team_msdyn_customapirulesetconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customapirulesetconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_customapirulesetconfiguration`|
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

### <a name="BKMK_team_msdyn_customerasset"></a> team_msdyn_customerasset

Many-To-One Relationship: [msdyn_customerasset team_msdyn_customerasset](msdyn_customerasset.md#BKMK_team_msdyn_customerasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_customerasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_customerassetattachment"></a> team_msdyn_customerassetattachment

Many-To-One Relationship: [msdyn_customerassetattachment team_msdyn_customerassetattachment](msdyn_customerassetattachment.md#BKMK_team_msdyn_customerassetattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerassetattachment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_customerassetattachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_customerassetcategory"></a> team_msdyn_customerassetcategory

Many-To-One Relationship: [msdyn_customerassetcategory team_msdyn_customerassetcategory](msdyn_customerassetcategory.md#BKMK_team_msdyn_customerassetcategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerassetcategory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_customerassetcategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_dataanalyticscustomizedreport"></a> team_msdyn_dataanalyticscustomizedreport

Many-To-One Relationship: [msdyn_dataanalyticscustomizedreport team_msdyn_dataanalyticscustomizedreport](msdyn_dataanalyticscustomizedreport.md#BKMK_team_msdyn_dataanalyticscustomizedreport)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticscustomizedreport`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_dataanalyticscustomizedreport`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_dataanalyticsdataset"></a> team_msdyn_dataanalyticsdataset

Many-To-One Relationship: [msdyn_dataanalyticsdataset team_msdyn_dataanalyticsdataset](msdyn_dataanalyticsdataset.md#BKMK_team_msdyn_dataanalyticsdataset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsdataset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_dataanalyticsdataset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_dataanalyticsreport"></a> team_msdyn_dataanalyticsreport

Many-To-One Relationship: [msdyn_dataanalyticsreport team_msdyn_dataanalyticsreport](msdyn_dataanalyticsreport.md#BKMK_team_msdyn_dataanalyticsreport)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_dataanalyticsreport`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_dataanalyticsworkspace"></a> team_msdyn_dataanalyticsworkspace

Many-To-One Relationship: [msdyn_dataanalyticsworkspace team_msdyn_dataanalyticsworkspace](msdyn_dataanalyticsworkspace.md#BKMK_team_msdyn_dataanalyticsworkspace)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsworkspace`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_dataanalyticsworkspace`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_dealmanageraccess"></a> team_msdyn_dealmanageraccess

Many-To-One Relationship: [msdyn_dealmanageraccess team_msdyn_dealmanageraccess](msdyn_dealmanageraccess.md#BKMK_team_msdyn_dealmanageraccess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dealmanageraccess`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_dealmanageraccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_dealmanagersettings"></a> team_msdyn_dealmanagersettings

Many-To-One Relationship: [msdyn_dealmanagersettings team_msdyn_dealmanagersettings](msdyn_dealmanagersettings.md#BKMK_team_msdyn_dealmanagersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dealmanagersettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_dealmanagersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_decisioncontract"></a> team_msdyn_decisioncontract

Many-To-One Relationship: [msdyn_decisioncontract team_msdyn_decisioncontract](msdyn_decisioncontract.md#BKMK_team_msdyn_decisioncontract)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_decisioncontract`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_decisioncontract`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_decisionruleset"></a> team_msdyn_decisionruleset

Many-To-One Relationship: [msdyn_decisionruleset team_msdyn_decisionruleset](msdyn_decisionruleset.md#BKMK_team_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_decisionruleset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_decisionruleset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_defextendedchannelinstance"></a> team_msdyn_defextendedchannelinstance

Many-To-One Relationship: [msdyn_defextendedchannelinstance team_msdyn_defextendedchannelinstance](msdyn_defextendedchannelinstance.md#BKMK_team_msdyn_defextendedchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_defextendedchannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_defextendedchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_defextendedchannelinstanceaccount"></a> team_msdyn_defextendedchannelinstanceaccount

Many-To-One Relationship: [msdyn_defextendedchannelinstanceaccount team_msdyn_defextendedchannelinstanceaccount](msdyn_defextendedchannelinstanceaccount.md#BKMK_team_msdyn_defextendedchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_defextendedchannelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_defextendedchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_deletedconversation"></a> team_msdyn_deletedconversation

Many-To-One Relationship: [msdyn_deletedconversation team_msdyn_deletedconversation](msdyn_deletedconversation.md#BKMK_team_msdyn_deletedconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_deletedconversation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_deletedconversation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_diagnosticsdata"></a> team_msdyn_diagnosticsdata

Many-To-One Relationship: [msdyn_diagnosticsdata team_msdyn_diagnosticsdata](msdyn_diagnosticsdata.md#BKMK_team_msdyn_diagnosticsdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_diagnosticsdata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_diagnosticsdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_duplicateleadmapping"></a> team_msdyn_duplicateleadmapping

Many-To-One Relationship: [msdyn_duplicateleadmapping team_msdyn_duplicateleadmapping](msdyn_duplicateleadmapping.md#BKMK_team_msdyn_duplicateleadmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_duplicateleadmapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_duplicateleadmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_effortpredictionresult"></a> team_msdyn_effortpredictionresult

Many-To-One Relationship: [msdyn_effortpredictionresult team_msdyn_effortpredictionresult](msdyn_effortpredictionresult.md#BKMK_team_msdyn_effortpredictionresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_effortpredictionresult`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_effortpredictionresult`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entitlementapplication"></a> team_msdyn_entitlementapplication

Many-To-One Relationship: [msdyn_entitlementapplication team_msdyn_entitlementapplication](msdyn_entitlementapplication.md#BKMK_team_msdyn_entitlementapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entitlementapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entityattachment"></a> team_msdyn_entityattachment

Many-To-One Relationship: [msdyn_entityattachment team_msdyn_entityattachment](msdyn_entityattachment.md#BKMK_team_msdyn_entityattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityattachment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entityattachment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entityconfig"></a> team_msdyn_entityconfig

Many-To-One Relationship: [msdyn_entityconfig team_msdyn_entityconfig](msdyn_entityconfig.md#BKMK_team_msdyn_entityconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entityconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entityconfiguration"></a> team_msdyn_entityconfiguration

Many-To-One Relationship: [msdyn_entityconfiguration team_msdyn_entityconfiguration](msdyn_entityconfiguration.md#BKMK_team_msdyn_entityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entityrankingrule"></a> team_msdyn_entityrankingrule

Many-To-One Relationship: [msdyn_entityrankingrule team_msdyn_entityrankingrule](msdyn_entityrankingrule.md#BKMK_team_msdyn_entityrankingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityrankingrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entityrankingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entityroutingconfiguration"></a> team_msdyn_entityroutingconfiguration

Many-To-One Relationship: [msdyn_entityroutingconfiguration team_msdyn_entityroutingconfiguration](msdyn_entityroutingconfiguration.md#BKMK_team_msdyn_entityroutingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityroutingconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entityroutingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_entityworkstreammap"></a> team_msdyn_entityworkstreammap

Many-To-One Relationship: [msdyn_entityworkstreammap team_msdyn_entityworkstreammap](msdyn_entityworkstreammap.md#BKMK_team_msdyn_entityworkstreammap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityworkstreammap`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entityworkstreammap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_extendedusersetting"></a> team_msdyn_extendedusersetting

Many-To-One Relationship: [msdyn_extendedusersetting team_msdyn_extendedusersetting](msdyn_extendedusersetting.md#BKMK_team_msdyn_extendedusersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_extendedusersetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_extendedusersetting`|
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

### <a name="BKMK_team_msdyn_fieldservicedemodatajob"></a> team_msdyn_fieldservicedemodatajob

Many-To-One Relationship: [msdyn_fieldservicedemodatajob team_msdyn_fieldservicedemodatajob](msdyn_fieldservicedemodatajob.md#BKMK_team_msdyn_fieldservicedemodatajob)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicedemodatajob`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_fieldservicedemodatajob`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_fieldservicesetting"></a> team_msdyn_fieldservicesetting

Many-To-One Relationship: [msdyn_fieldservicesetting team_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_team_msdyn_fieldservicesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_fieldservicesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_fieldserviceslaconfiguration"></a> team_msdyn_fieldserviceslaconfiguration

Many-To-One Relationship: [msdyn_fieldserviceslaconfiguration team_msdyn_fieldserviceslaconfiguration](msdyn_fieldserviceslaconfiguration.md#BKMK_team_msdyn_fieldserviceslaconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_fieldserviceslaconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_fieldservicesummaryconfiguration"></a> team_msdyn_fieldservicesummaryconfiguration

Many-To-One Relationship: [msdyn_fieldservicesummaryconfiguration team_msdyn_fieldservicesummaryconfiguration](msdyn_fieldservicesummaryconfiguration.md#BKMK_team_msdyn_fieldservicesummaryconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_fieldservicesummaryconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_flowcardtype"></a> team_msdyn_flowcardtype

Many-To-One Relationship: [msdyn_flowcardtype team_msdyn_flowcardtype](msdyn_flowcardtype.md#BKMK_team_msdyn_flowcardtype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_flowcardtype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_flowcardtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_forecastconfiguration"></a> team_msdyn_forecastconfiguration

Many-To-One Relationship: [msdyn_forecastconfiguration team_msdyn_forecastconfiguration](msdyn_forecastconfiguration.md#BKMK_team_msdyn_forecastconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_forecastconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_forecastdefinition"></a> team_msdyn_forecastdefinition

Many-To-One Relationship: [msdyn_forecastdefinition team_msdyn_forecastdefinition](msdyn_forecastdefinition.md#BKMK_team_msdyn_forecastdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastdefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_forecastdefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_forecastinstance"></a> team_msdyn_forecastinstance

Many-To-One Relationship: [msdyn_forecastinstance team_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_team_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_forecastinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_forecastrecurrence"></a> team_msdyn_forecastrecurrence

Many-To-One Relationship: [msdyn_forecastrecurrence team_msdyn_forecastrecurrence](msdyn_forecastrecurrence.md#BKMK_team_msdyn_forecastrecurrence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastrecurrence`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_forecastrecurrence`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_formmapping"></a> team_msdyn_formmapping

Many-To-One Relationship: [msdyn_formmapping team_msdyn_formmapping](msdyn_formmapping.md#BKMK_team_msdyn_formmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_formmapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_formmapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_functionallocation"></a> team_msdyn_functionallocation

Many-To-One Relationship: [msdyn_functionallocation team_msdyn_functionallocation](msdyn_functionallocation.md#BKMK_team_msdyn_functionallocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_functionallocation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_functionallocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_functionallocationtype"></a> team_msdyn_functionallocationtype

Many-To-One Relationship: [msdyn_functionallocationtype team_msdyn_functionallocationtype](msdyn_functionallocationtype.md#BKMK_team_msdyn_functionallocationtype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_functionallocationtype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_functionallocationtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_gdprdata"></a> team_msdyn_gdprdata

Many-To-One Relationship: [msdyn_gdprdata team_msdyn_gdprdata](msdyn_gdprdata.md#BKMK_team_msdyn_gdprdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_gdprdata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_gdprdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_geofence"></a> team_msdyn_geofence

Many-To-One Relationship: [msdyn_geofence team_msdyn_geofence](msdyn_geofence.md#BKMK_team_msdyn_geofence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofence`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_geofence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_geofenceevent"></a> team_msdyn_geofenceevent

Many-To-One Relationship: [msdyn_geofenceevent team_msdyn_geofenceevent](msdyn_geofenceevent.md#BKMK_team_msdyn_geofenceevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofenceevent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_geofenceevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_geofencingsettings"></a> team_msdyn_geofencingsettings

Many-To-One Relationship: [msdyn_geofencingsettings team_msdyn_geofencingsettings](msdyn_geofencingsettings.md#BKMK_team_msdyn_geofencingsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofencingsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_geofencingsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_guideauthorsession"></a> team_msdyn_guideauthorsession

Many-To-One Relationship: [msdyn_guideauthorsession team_msdyn_guideauthorsession](msdyn_guideauthorsession.md#BKMK_team_msdyn_guideauthorsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_guideauthorsession`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_guideauthorsession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_icdextension"></a> team_msdyn_icdextension

Many-To-One Relationship: [msdyn_icdextension team_msdyn_icdextension](msdyn_icdextension.md#BKMK_team_msdyn_icdextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_icdextension`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_icdextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_icebreakersconfig"></a> team_msdyn_icebreakersconfig

Many-To-One Relationship: [msdyn_icebreakersconfig team_msdyn_icebreakersconfig](msdyn_icebreakersconfig.md#BKMK_team_msdyn_icebreakersconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_icebreakersconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_icebreakersconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iermlmodel"></a> team_msdyn_iermlmodel

Many-To-One Relationship: [msdyn_iermlmodel team_msdyn_iermlmodel](msdyn_iermlmodel.md#BKMK_team_msdyn_iermlmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermlmodel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iermlmodel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iermltraining"></a> team_msdyn_iermltraining

Many-To-One Relationship: [msdyn_iermltraining team_msdyn_iermltraining](msdyn_iermltraining.md#BKMK_team_msdyn_iermltraining)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermltraining`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iermltraining`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttype"></a> team_msdyn_incidenttype

Many-To-One Relationship: [msdyn_incidenttype team_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_team_msdyn_incidenttype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttype_requirementgroup"></a> team_msdyn_incidenttype_requirementgroup

Many-To-One Relationship: [msdyn_incidenttype_requirementgroup team_msdyn_incidenttype_requirementgroup](msdyn_incidenttype_requirementgroup.md#BKMK_team_msdyn_incidenttype_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttype_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypecharacteristic"></a> team_msdyn_incidenttypecharacteristic

Many-To-One Relationship: [msdyn_incidenttypecharacteristic team_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_team_msdyn_incidenttypecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypecharacteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypecharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypeproduct"></a> team_msdyn_incidenttypeproduct

Many-To-One Relationship: [msdyn_incidenttypeproduct team_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_team_msdyn_incidenttypeproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypeproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttyperecommendationresult"></a> team_msdyn_incidenttyperecommendationresult

Many-To-One Relationship: [msdyn_incidenttyperecommendationresult team_msdyn_incidenttyperecommendationresult](msdyn_incidenttyperecommendationresult.md#BKMK_team_msdyn_incidenttyperecommendationresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttyperecommendationresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttyperecommendationrunhistory"></a> team_msdyn_incidenttyperecommendationrunhistory

Many-To-One Relationship: [msdyn_incidenttyperecommendationrunhistory team_msdyn_incidenttyperecommendationrunhistory](msdyn_incidenttyperecommendationrunhistory.md#BKMK_team_msdyn_incidenttyperecommendationrunhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttyperecommendationrunhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttyperesolution"></a> team_msdyn_incidenttyperesolution

Many-To-One Relationship: [msdyn_incidenttyperesolution team_msdyn_incidenttyperesolution](msdyn_incidenttyperesolution.md#BKMK_team_msdyn_incidenttyperesolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperesolution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttyperesolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypeservice"></a> team_msdyn_incidenttypeservice

Many-To-One Relationship: [msdyn_incidenttypeservice team_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_team_msdyn_incidenttypeservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypeservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypeservicetask"></a> team_msdyn_incidenttypeservicetask

Many-To-One Relationship: [msdyn_incidenttypeservicetask team_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_team_msdyn_incidenttypeservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservicetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypeservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_incidenttypessetup"></a> team_msdyn_incidenttypessetup

Many-To-One Relationship: [msdyn_incidenttypessetup team_msdyn_incidenttypessetup](msdyn_incidenttypessetup.md#BKMK_team_msdyn_incidenttypessetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypessetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_incidenttypessetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspection"></a> team_msdyn_inspection

Many-To-One Relationship: [msdyn_inspection team_msdyn_inspection](msdyn_inspection.md#BKMK_team_msdyn_inspection)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspection`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspection`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspectionattachment"></a> team_msdyn_inspectionattachment

Many-To-One Relationship: [msdyn_inspectionattachment team_msdyn_inspectionattachment](msdyn_inspectionattachment.md#BKMK_team_msdyn_inspectionattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionattachment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspectionattachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspectiondefinition"></a> team_msdyn_inspectiondefinition

Many-To-One Relationship: [msdyn_inspectiondefinition team_msdyn_inspectiondefinition](msdyn_inspectiondefinition.md#BKMK_team_msdyn_inspectiondefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectiondefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspectiondefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspectioninstance"></a> team_msdyn_inspectioninstance

Many-To-One Relationship: [msdyn_inspectioninstance team_msdyn_inspectioninstance](msdyn_inspectioninstance.md#BKMK_team_msdyn_inspectioninstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectioninstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspectioninstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inspectionresponse"></a> team_msdyn_inspectionresponse

Many-To-One Relationship: [msdyn_inspectionresponse team_msdyn_inspectionresponse](msdyn_inspectionresponse.md#BKMK_team_msdyn_inspectionresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionresponse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inspectionresponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_insurance"></a> team_msdyn_insurance

Many-To-One Relationship: [msdyn_insurance team_msdyn_insurance](msdyn_insurance.md#BKMK_team_msdyn_insurance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_insurance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_insurance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intent"></a> team_msdyn_intent

Many-To-One Relationship: [msdyn_intent team_msdyn_intent](msdyn_intent.md#BKMK_team_msdyn_intent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inventoryadjustment"></a> team_msdyn_inventoryadjustment

Many-To-One Relationship: [msdyn_inventoryadjustment team_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_team_msdyn_inventoryadjustment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inventoryadjustment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inventoryadjustmentproduct"></a> team_msdyn_inventoryadjustmentproduct

Many-To-One Relationship: [msdyn_inventoryadjustmentproduct team_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_team_msdyn_inventoryadjustmentproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inventoryadjustmentproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inventoryjournal"></a> team_msdyn_inventoryjournal

Many-To-One Relationship: [msdyn_inventoryjournal team_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_team_msdyn_inventoryjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inventoryjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_inventorytransfer"></a> team_msdyn_inventorytransfer

Many-To-One Relationship: [msdyn_inventorytransfer team_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_team_msdyn_inventorytransfer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventorytransfer`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_inventorytransfer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotalert"></a> team_msdyn_iotalert

Many-To-One Relationship: [msdyn_iotalert team_msdyn_iotalert](msdyn_iotalert.md#BKMK_team_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotdevice"></a> team_msdyn_iotdevice

Many-To-One Relationship: [msdyn_iotdevice team_msdyn_iotdevice](msdyn_iotdevice.md#BKMK_team_msdyn_iotdevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotdevice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotdevicecategory"></a> team_msdyn_iotdevicecategory

Many-To-One Relationship: [msdyn_iotdevicecategory team_msdyn_iotdevicecategory](msdyn_iotdevicecategory.md#BKMK_team_msdyn_iotdevicecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecategory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotdevicecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotdevicecommand"></a> team_msdyn_iotdevicecommand

Many-To-One Relationship: [msdyn_iotdevicecommand team_msdyn_iotdevicecommand](msdyn_iotdevicecommand.md#BKMK_team_msdyn_iotdevicecommand)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommand`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotdevicecommand`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotdevicecommanddefinition"></a> team_msdyn_iotdevicecommanddefinition

Many-To-One Relationship: [msdyn_iotdevicecommanddefinition team_msdyn_iotdevicecommanddefinition](msdyn_iotdevicecommanddefinition.md#BKMK_team_msdyn_iotdevicecommanddefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommanddefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotdevicecommanddefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotdevicedatahistory"></a> team_msdyn_iotdevicedatahistory

Many-To-One Relationship: [msdyn_iotdevicedatahistory team_msdyn_iotdevicedatahistory](msdyn_iotdevicedatahistory.md#BKMK_team_msdyn_iotdevicedatahistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicedatahistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotdevicedatahistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotdeviceproperty"></a> team_msdyn_iotdeviceproperty

Many-To-One Relationship: [msdyn_iotdeviceproperty team_msdyn_iotdeviceproperty](msdyn_iotdeviceproperty.md#BKMK_team_msdyn_iotdeviceproperty)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdeviceproperty`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotdeviceproperty`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotdeviceregistrationhistory"></a> team_msdyn_iotdeviceregistrationhistory

Many-To-One Relationship: [msdyn_iotdeviceregistrationhistory team_msdyn_iotdeviceregistrationhistory](msdyn_iotdeviceregistrationhistory.md#BKMK_team_msdyn_iotdeviceregistrationhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotdeviceregistrationhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotdevicevisualizationconfiguration"></a> team_msdyn_iotdevicevisualizationconfiguration

Many-To-One Relationship: [msdyn_iotdevicevisualizationconfiguration team_msdyn_iotdevicevisualizationconfiguration](msdyn_iotdevicevisualizationconfiguration.md#BKMK_team_msdyn_iotdevicevisualizationconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicevisualizationconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotdevicevisualizationconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotfieldmapping"></a> team_msdyn_iotfieldmapping

Many-To-One Relationship: [msdyn_iotfieldmapping team_msdyn_iotfieldmapping](msdyn_iotfieldmapping.md#BKMK_team_msdyn_iotfieldmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotfieldmapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotfieldmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotpropertydefinition"></a> team_msdyn_iotpropertydefinition

Many-To-One Relationship: [msdyn_iotpropertydefinition team_msdyn_iotpropertydefinition](msdyn_iotpropertydefinition.md#BKMK_team_msdyn_iotpropertydefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotpropertydefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotpropertydefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotprovider"></a> team_msdyn_iotprovider

Many-To-One Relationship: [msdyn_iotprovider team_msdyn_iotprovider](msdyn_iotprovider.md#BKMK_team_msdyn_iotprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotprovider`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotproviderinstance"></a> team_msdyn_iotproviderinstance

Many-To-One Relationship: [msdyn_iotproviderinstance team_msdyn_iotproviderinstance](msdyn_iotproviderinstance.md#BKMK_team_msdyn_iotproviderinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotproviderinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotproviderinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_iotsettings"></a> team_msdyn_iotsettings

Many-To-One Relationship: [msdyn_iotsettings team_msdyn_iotsettings](msdyn_iotsettings.md#BKMK_team_msdyn_iotsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_iotsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_jobsstate"></a> team_msdyn_jobsstate

Many-To-One Relationship: [msdyn_jobsstate team_msdyn_jobsstate](msdyn_jobsstate.md#BKMK_team_msdyn_jobsstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_jobsstate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_jobsstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_kpieventdata"></a> team_msdyn_kpieventdata

Many-To-One Relationship: [msdyn_kpieventdata team_msdyn_kpieventdata](msdyn_kpieventdata.md#BKMK_team_msdyn_kpieventdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_kpieventdata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_kpieventdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_kpieventdefinition"></a> team_msdyn_kpieventdefinition

Many-To-One Relationship: [msdyn_kpieventdefinition team_msdyn_kpieventdefinition](msdyn_kpieventdefinition.md#BKMK_team_msdyn_kpieventdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_kpieventdefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_kpieventdefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_leadmodelconfig"></a> team_msdyn_leadmodelconfig

Many-To-One Relationship: [msdyn_leadmodelconfig team_msdyn_leadmodelconfig](msdyn_leadmodelconfig.md#BKMK_team_msdyn_leadmodelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_leadmodelconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_leadmodelconfig`|
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

### <a name="BKMK_team_msdyn_liveconversation"></a> team_msdyn_liveconversation

Many-To-One Relationship: [msdyn_liveconversation team_msdyn_liveconversation](msdyn_liveconversation.md#BKMK_team_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveconversation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_liveconversation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_liveworkitemevent"></a> team_msdyn_liveworkitemevent

Many-To-One Relationship: [msdyn_liveworkitemevent team_msdyn_liveworkitemevent](msdyn_liveworkitemevent.md#BKMK_team_msdyn_liveworkitemevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkitemevent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_liveworkitemevent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_liveworkstream"></a> team_msdyn_liveworkstream

Many-To-One Relationship: [msdyn_liveworkstream team_msdyn_liveworkstream](msdyn_liveworkstream.md#BKMK_team_msdyn_liveworkstream)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstream`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_liveworkstream`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_liveworkstreamcapacityprofile"></a> team_msdyn_liveworkstreamcapacityprofile

Many-To-One Relationship: [msdyn_liveworkstreamcapacityprofile team_msdyn_liveworkstreamcapacityprofile](msdyn_liveworkstreamcapacityprofile.md#BKMK_team_msdyn_liveworkstreamcapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstreamcapacityprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_liveworkstreamcapacityprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_locationtemplateassociation"></a> team_msdyn_locationtemplateassociation

Many-To-One Relationship: [msdyn_locationtemplateassociation team_msdyn_locationtemplateassociation](msdyn_locationtemplateassociation.md#BKMK_team_msdyn_locationtemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_locationtemplateassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_locationtemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_locationtypetemplateassociation"></a> team_msdyn_locationtypetemplateassociation

Many-To-One Relationship: [msdyn_locationtypetemplateassociation team_msdyn_locationtypetemplateassociation](msdyn_locationtypetemplateassociation.md#BKMK_team_msdyn_locationtypetemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_locationtypetemplateassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_locationtypetemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_lockstatus"></a> team_msdyn_lockstatus

Many-To-One Relationship: [msdyn_lockstatus team_msdyn_lockstatus](msdyn_lockstatus.md#BKMK_team_msdyn_lockstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_lockstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_lockstatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_macrosession"></a> team_msdyn_macrosession

Many-To-One Relationship: [msdyn_macrosession team_msdyn_macrosession](msdyn_macrosession.md#BKMK_team_msdyn_macrosession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_macrosession`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_macrosession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_masterentityroutingconfiguration"></a> team_msdyn_masterentityroutingconfiguration

Many-To-One Relationship: [msdyn_masterentityroutingconfiguration team_msdyn_masterentityroutingconfiguration](msdyn_masterentityroutingconfiguration.md#BKMK_team_msdyn_masterentityroutingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_masterentityroutingconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_masterentityroutingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_migrationtracker"></a> team_msdyn_migrationtracker

Many-To-One Relationship: [msdyn_migrationtracker team_msdyn_migrationtracker](msdyn_migrationtracker.md#BKMK_team_msdyn_migrationtracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_migrationtracker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_mobilesource"></a> team_msdyn_mobilesource

Many-To-One Relationship: [msdyn_mobilesource team_msdyn_mobilesource](msdyn_mobilesource.md#BKMK_team_msdyn_mobilesource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mobilesource`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_mobilesource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_modelpreviewstatus"></a> team_msdyn_modelpreviewstatus

Many-To-One Relationship: [msdyn_modelpreviewstatus team_msdyn_modelpreviewstatus](msdyn_modelpreviewstatus.md#BKMK_team_msdyn_modelpreviewstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_modelpreviewstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_modelpreviewstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_mrappsession"></a> team_msdyn_mrappsession

Many-To-One Relationship: [msdyn_mrappsession team_msdyn_mrappsession](msdyn_mrappsession.md#BKMK_team_msdyn_mrappsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mrappsession`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_mrappsession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_mrasjob"></a> team_msdyn_mrasjob

Many-To-One Relationship: [msdyn_mrasjob team_msdyn_mrasjob](msdyn_mrasjob.md#BKMK_team_msdyn_mrasjob)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mrasjob`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_mrasjob`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_mrfolder"></a> team_msdyn_mrfolder

Many-To-One Relationship: [msdyn_mrfolder team_msdyn_mrfolder](msdyn_mrfolder.md#BKMK_team_msdyn_mrfolder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mrfolder`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_mrfolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_msteamssetting"></a> team_msdyn_msteamssetting

Many-To-One Relationship: [msdyn_msteamssetting team_msdyn_msteamssetting](msdyn_msteamssetting.md#BKMK_team_msdyn_msteamssetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_msteamssetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_msteamssetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_notesanalysisconfig"></a> team_msdyn_notesanalysisconfig

Many-To-One Relationship: [msdyn_notesanalysisconfig team_msdyn_notesanalysisconfig](msdyn_notesanalysisconfig.md#BKMK_team_msdyn_notesanalysisconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notesanalysisconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_notesanalysisconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_notificationfield"></a> team_msdyn_notificationfield

Many-To-One Relationship: [msdyn_notificationfield team_msdyn_notificationfield](msdyn_notificationfield.md#BKMK_team_msdyn_notificationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notificationfield`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_notificationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_notificationtemplate"></a> team_msdyn_notificationtemplate

Many-To-One Relationship: [msdyn_notificationtemplate team_msdyn_notificationtemplate](msdyn_notificationtemplate.md#BKMK_team_msdyn_notificationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notificationtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_notificationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_nottoexceed"></a> team_msdyn_nottoexceed

Many-To-One Relationship: [msdyn_nottoexceed team_msdyn_nottoexceed](msdyn_nottoexceed.md#BKMK_team_msdyn_nottoexceed)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_nottoexceed`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_objectanchor"></a> team_msdyn_objectanchor

Many-To-One Relationship: [msdyn_objectanchor team_msdyn_objectanchor](msdyn_objectanchor.md#BKMK_team_msdyn_objectanchor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_objectanchor`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_objectanchor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_oc_geolocationprovider"></a> team_msdyn_oc_geolocationprovider

Many-To-One Relationship: [msdyn_oc_geolocationprovider team_msdyn_oc_geolocationprovider](msdyn_oc_geolocationprovider.md#BKMK_team_msdyn_oc_geolocationprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oc_geolocationprovider`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_oc_geolocationprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocagentassignedcustomapiprivilege"></a> team_msdyn_ocagentassignedcustomapiprivilege

Many-To-One Relationship: [msdyn_ocagentassignedcustomapiprivilege team_msdyn_ocagentassignedcustomapiprivilege](msdyn_ocagentassignedcustomapiprivilege.md#BKMK_team_msdyn_ocagentassignedcustomapiprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocagentassignedcustomapiprivilege`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocagentassignedcustomapiprivilege`|
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

### <a name="BKMK_team_msdyn_ocautoblockrule"></a> team_msdyn_ocautoblockrule

Many-To-One Relationship: [msdyn_ocautoblockrule team_msdyn_ocautoblockrule](msdyn_ocautoblockrule.md#BKMK_team_msdyn_ocautoblockrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautoblockrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocautoblockrule`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocbotchannelregistration"></a> team_msdyn_ocbotchannelregistration

Many-To-One Relationship: [msdyn_ocbotchannelregistration team_msdyn_ocbotchannelregistration](msdyn_ocbotchannelregistration.md#BKMK_team_msdyn_ocbotchannelregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocbotchannelregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocbotchannelregistrationsecret"></a> team_msdyn_ocbotchannelregistrationsecret

Many-To-One Relationship: [msdyn_ocbotchannelregistrationsecret team_msdyn_ocbotchannelregistrationsecret](msdyn_ocbotchannelregistrationsecret.md#BKMK_team_msdyn_ocbotchannelregistrationsecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistrationsecret`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocbotchannelregistrationsecret`|
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

### <a name="BKMK_team_msdyn_occhannelapiconversationprivilege"></a> team_msdyn_occhannelapiconversationprivilege

Many-To-One Relationship: [msdyn_occhannelapiconversationprivilege team_msdyn_occhannelapiconversationprivilege](msdyn_occhannelapiconversationprivilege.md#BKMK_team_msdyn_occhannelapiconversationprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapiconversationprivilege`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_occhannelapiconversationprivilege`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_occhannelapimessageprivilege"></a> team_msdyn_occhannelapimessageprivilege

Many-To-One Relationship: [msdyn_occhannelapimessageprivilege team_msdyn_occhannelapimessageprivilege](msdyn_occhannelapimessageprivilege.md#BKMK_team_msdyn_occhannelapimessageprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapimessageprivilege`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_occhannelapimessageprivilege`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_occhannelapimethodmapping"></a> team_msdyn_occhannelapimethodmapping

Many-To-One Relationship: [msdyn_occhannelapimethodmapping team_msdyn_occhannelapimethodmapping](msdyn_occhannelapimethodmapping.md#BKMK_team_msdyn_occhannelapimethodmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapimethodmapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_occhannelapimethodmapping`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_ocexternalcontext"></a> team_msdyn_ocexternalcontext

Many-To-One Relationship: [msdyn_ocexternalcontext team_msdyn_ocexternalcontext](msdyn_ocexternalcontext.md#BKMK_team_msdyn_ocexternalcontext)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalcontext`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocexternalcontext`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_ocflaggedspam"></a> team_msdyn_ocflaggedspam

Many-To-One Relationship: [msdyn_ocflaggedspam team_msdyn_ocflaggedspam](msdyn_ocflaggedspam.md#BKMK_team_msdyn_ocflaggedspam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocflaggedspam`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocflaggedspam`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_oclanguage"></a> team_msdyn_oclanguage

Many-To-One Relationship: [msdyn_oclanguage team_msdyn_oclanguage](msdyn_oclanguage.md#BKMK_team_msdyn_oclanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclanguage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_oclanguage`|
|IsCustomizable|`True`|
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

### <a name="BKMK_team_msdyn_ocliveworkitemcapacityprofile"></a> team_msdyn_ocliveworkitemcapacityprofile

Many-To-One Relationship: [msdyn_ocliveworkitemcapacityprofile team_msdyn_ocliveworkitemcapacityprofile](msdyn_ocliveworkitemcapacityprofile.md#BKMK_team_msdyn_ocliveworkitemcapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcapacityprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocliveworkitemcapacityprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocliveworkitemcharacteristic"></a> team_msdyn_ocliveworkitemcharacteristic

Many-To-One Relationship: [msdyn_ocliveworkitemcharacteristic team_msdyn_ocliveworkitemcharacteristic](msdyn_ocliveworkitemcharacteristic.md#BKMK_team_msdyn_ocliveworkitemcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcharacteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocliveworkitemcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocliveworkitemcontextitem"></a> team_msdyn_ocliveworkitemcontextitem

Many-To-One Relationship: [msdyn_ocliveworkitemcontextitem team_msdyn_ocliveworkitemcontextitem](msdyn_ocliveworkitemcontextitem.md#BKMK_team_msdyn_ocliveworkitemcontextitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcontextitem`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocliveworkitemcontextitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocliveworkitemparticipant"></a> team_msdyn_ocliveworkitemparticipant

Many-To-One Relationship: [msdyn_ocliveworkitemparticipant team_msdyn_ocliveworkitemparticipant](msdyn_ocliveworkitemparticipant.md#BKMK_team_msdyn_ocliveworkitemparticipant)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemparticipant`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocliveworkitemparticipant`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocliveworkitemsentiment"></a> team_msdyn_ocliveworkitemsentiment

Many-To-One Relationship: [msdyn_ocliveworkitemsentiment team_msdyn_ocliveworkitemsentiment](msdyn_ocliveworkitemsentiment.md#BKMK_team_msdyn_ocliveworkitemsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemsentiment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocliveworkitemsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocliveworkstreamcontextvariable"></a> team_msdyn_ocliveworkstreamcontextvariable

Many-To-One Relationship: [msdyn_ocliveworkstreamcontextvariable team_msdyn_ocliveworkstreamcontextvariable](msdyn_ocliveworkstreamcontextvariable.md#BKMK_team_msdyn_ocliveworkstreamcontextvariable)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkstreamcontextvariable`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocliveworkstreamcontextvariable`|
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

### <a name="BKMK_team_msdyn_ocpaymentprofile"></a> team_msdyn_ocpaymentprofile

Many-To-One Relationship: [msdyn_ocpaymentprofile team_msdyn_ocpaymentprofile](msdyn_ocpaymentprofile.md#BKMK_team_msdyn_ocpaymentprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocpaymentprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocpaymentprofile`|
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

### <a name="BKMK_team_msdyn_ocprovisioningstate"></a> team_msdyn_ocprovisioningstate

Many-To-One Relationship: [msdyn_ocprovisioningstate team_msdyn_ocprovisioningstate](msdyn_ocprovisioningstate.md#BKMK_team_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocprovisioningstate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocprovisioningstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocrecording"></a> team_msdyn_ocrecording

Many-To-One Relationship: [msdyn_ocrecording team_msdyn_ocrecording](msdyn_ocrecording.md#BKMK_team_msdyn_ocrecording)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocrecording`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocrequest"></a> team_msdyn_ocrequest

Many-To-One Relationship: [msdyn_ocrequest team_msdyn_ocrequest](msdyn_ocrequest.md#BKMK_team_msdyn_ocrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocrichobject"></a> team_msdyn_ocrichobject

Many-To-One Relationship: [msdyn_ocrichobject team_msdyn_ocrichobject](msdyn_ocrichobject.md#BKMK_team_msdyn_ocrichobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobject`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocrichobject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocrichobjectmap"></a> team_msdyn_ocrichobjectmap

Many-To-One Relationship: [msdyn_ocrichobjectmap team_msdyn_ocrichobjectmap](msdyn_ocrichobjectmap.md#BKMK_team_msdyn_ocrichobjectmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobjectmap`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocrichobjectmap`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocruleitem"></a> team_msdyn_ocruleitem

Many-To-One Relationship: [msdyn_ocruleitem team_msdyn_ocruleitem](msdyn_ocruleitem.md#BKMK_team_msdyn_ocruleitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocruleitem`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocruleitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsentimentdailytopic"></a> team_msdyn_ocsentimentdailytopic

Many-To-One Relationship: [msdyn_ocsentimentdailytopic team_msdyn_ocsentimentdailytopic](msdyn_ocsentimentdailytopic.md#BKMK_team_msdyn_ocsentimentdailytopic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsentimentdailytopic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsentimentdailytopickeyword"></a> team_msdyn_ocsentimentdailytopickeyword

Many-To-One Relationship: [msdyn_ocsentimentdailytopickeyword team_msdyn_ocsentimentdailytopickeyword](msdyn_ocsentimentdailytopickeyword.md#BKMK_team_msdyn_ocsentimentdailytopickeyword)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopickeyword`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsentimentdailytopickeyword`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsentimentdailytopictrending"></a> team_msdyn_ocsentimentdailytopictrending

Many-To-One Relationship: [msdyn_ocsentimentdailytopictrending team_msdyn_ocsentimentdailytopictrending](msdyn_ocsentimentdailytopictrending.md#BKMK_team_msdyn_ocsentimentdailytopictrending)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopictrending`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsentimentdailytopictrending`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsessioncharacteristic"></a> team_msdyn_ocsessioncharacteristic

Many-To-One Relationship: [msdyn_ocsessioncharacteristic team_msdyn_ocsessioncharacteristic](msdyn_ocsessioncharacteristic.md#BKMK_team_msdyn_ocsessioncharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessioncharacteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsessioncharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsessionparticipantevent"></a> team_msdyn_ocsessionparticipantevent

Many-To-One Relationship: [msdyn_ocsessionparticipantevent team_msdyn_ocsessionparticipantevent](msdyn_ocsessionparticipantevent.md#BKMK_team_msdyn_ocsessionparticipantevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionparticipantevent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsessionparticipantevent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsessionsentiment"></a> team_msdyn_ocsessionsentiment

Many-To-One Relationship: [msdyn_ocsessionsentiment team_msdyn_ocsessionsentiment](msdyn_ocsessionsentiment.md#BKMK_team_msdyn_ocsessionsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionsentiment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsessionsentiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsimltraining"></a> team_msdyn_ocsimltraining

Many-To-One Relationship: [msdyn_ocsimltraining team_msdyn_ocsimltraining](msdyn_ocsimltraining.md#BKMK_team_msdyn_ocsimltraining)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsimltraining`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsimltraining`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsitdimportconfig"></a> team_msdyn_ocsitdimportconfig

Many-To-One Relationship: [msdyn_ocsitdimportconfig team_msdyn_ocsitdimportconfig](msdyn_ocsitdimportconfig.md#BKMK_team_msdyn_ocsitdimportconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitdimportconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsitdimportconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsitdskill"></a> team_msdyn_ocsitdskill

Many-To-One Relationship: [msdyn_ocsitdskill team_msdyn_ocsitdskill](msdyn_ocsitdskill.md#BKMK_team_msdyn_ocsitdskill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitdskill`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsitdskill`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocsitrainingdata"></a> team_msdyn_ocsitrainingdata

Many-To-One Relationship: [msdyn_ocsitrainingdata team_msdyn_ocsitrainingdata](msdyn_ocsitrainingdata.md#BKMK_team_msdyn_ocsitrainingdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitrainingdata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocsitrainingdata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocskillidentmlmodel"></a> team_msdyn_ocskillidentmlmodel

Many-To-One Relationship: [msdyn_ocskillidentmlmodel team_msdyn_ocskillidentmlmodel](msdyn_ocskillidentmlmodel.md#BKMK_team_msdyn_ocskillidentmlmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocskillidentmlmodel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocskillidentmlmodel`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_omnichannelpersonalization"></a> team_msdyn_omnichannelpersonalization

Many-To-One Relationship: [msdyn_omnichannelpersonalization team_msdyn_omnichannelpersonalization](msdyn_omnichannelpersonalization.md#BKMK_team_msdyn_omnichannelpersonalization)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelpersonalization`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_omnichannelpersonalization`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_omnichannelqueue"></a> team_msdyn_omnichannelqueue

Many-To-One Relationship: [msdyn_omnichannelqueue team_msdyn_omnichannelqueue](msdyn_omnichannelqueue.md#BKMK_team_msdyn_omnichannelqueue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelqueue`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_omnichannelqueue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_omnichannelsyncconfig"></a> team_msdyn_omnichannelsyncconfig

Many-To-One Relationship: [msdyn_omnichannelsyncconfig team_msdyn_omnichannelsyncconfig](msdyn_omnichannelsyncconfig.md#BKMK_team_msdyn_omnichannelsyncconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelsyncconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_omnichannelsyncconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_operatinghour"></a> team_msdyn_operatinghour

Many-To-One Relationship: [msdyn_operatinghour team_msdyn_operatinghour](msdyn_operatinghour.md#BKMK_team_msdyn_operatinghour)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_operatinghour`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_operatinghour`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_opportunitymodelconfig"></a> team_msdyn_opportunitymodelconfig

Many-To-One Relationship: [msdyn_opportunitymodelconfig team_msdyn_opportunitymodelconfig](msdyn_opportunitymodelconfig.md#BKMK_team_msdyn_opportunitymodelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_opportunitymodelconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_opportunitymodelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_optimizationrequestbooking"></a> team_msdyn_optimizationrequestbooking

Many-To-One Relationship: [msdyn_optimizationrequestbooking team_msdyn_optimizationrequestbooking](msdyn_optimizationrequestbooking.md#BKMK_team_msdyn_optimizationrequestbooking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequestbooking`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_optimizationrequestbooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_optimizationrequestresource"></a> team_msdyn_optimizationrequestresource

Many-To-One Relationship: [msdyn_optimizationrequestresource team_msdyn_optimizationrequestresource](msdyn_optimizationrequestresource.md#BKMK_team_msdyn_optimizationrequestresource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequestresource`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_optimizationrequestresource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderedobjective"></a> team_msdyn_orderedobjective

Many-To-One Relationship: [msdyn_orderedobjective team_msdyn_orderedobjective](msdyn_orderedobjective.md#BKMK_team_msdyn_orderedobjective)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderedobjective`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderedobjective`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderinvoicingdate"></a> team_msdyn_orderinvoicingdate

Many-To-One Relationship: [msdyn_orderinvoicingdate team_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_team_msdyn_orderinvoicingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingdate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderinvoicingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderinvoicingproduct"></a> team_msdyn_orderinvoicingproduct

Many-To-One Relationship: [msdyn_orderinvoicingproduct team_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_team_msdyn_orderinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderinvoicingsetup"></a> team_msdyn_orderinvoicingsetup

Many-To-One Relationship: [msdyn_orderinvoicingsetup team_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_team_msdyn_orderinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orderinvoicingsetupdate"></a> team_msdyn_orderinvoicingsetupdate

Many-To-One Relationship: [msdyn_orderinvoicingsetupdate team_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_team_msdyn_orderinvoicingsetupdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orderinvoicingsetupdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_orgchartnode"></a> team_msdyn_orgchartnode

Many-To-One Relationship: [msdyn_orgchartnode team_msdyn_orgchartnode](msdyn_orgchartnode.md#BKMK_team_msdyn_orgchartnode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orgchartnode`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_orgchartnode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_overflowactionconfig"></a> team_msdyn_overflowactionconfig

Many-To-One Relationship: [msdyn_overflowactionconfig team_msdyn_overflowactionconfig](msdyn_overflowactionconfig.md#BKMK_team_msdyn_overflowactionconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_overflowactionconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_overflowactionconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_payment"></a> team_msdyn_payment

Many-To-One Relationship: [msdyn_payment team_msdyn_payment](msdyn_payment.md#BKMK_team_msdyn_payment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_payment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_payment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_paymentdetail"></a> team_msdyn_paymentdetail

Many-To-One Relationship: [msdyn_paymentdetail team_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_team_msdyn_paymentdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentdetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_paymentdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_paymentmethod"></a> team_msdyn_paymentmethod

Many-To-One Relationship: [msdyn_paymentmethod team_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_team_msdyn_paymentmethod)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentmethod`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_paymentmethod`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_paymentterm"></a> team_msdyn_paymentterm

Many-To-One Relationship: [msdyn_paymentterm team_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_team_msdyn_paymentterm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentterm`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_paymentterm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_personalmessage"></a> team_msdyn_personalmessage

Many-To-One Relationship: [msdyn_personalmessage team_msdyn_personalmessage](msdyn_personalmessage.md#BKMK_team_msdyn_personalmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_personalmessage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_personalmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_personalsoundsetting"></a> team_msdyn_personalsoundsetting

Many-To-One Relationship: [msdyn_personalsoundsetting team_msdyn_personalsoundsetting](msdyn_personalsoundsetting.md#BKMK_team_msdyn_personalsoundsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_personalsoundsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_personalsoundsetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_playbookactivity"></a> team_msdyn_playbookactivity

Many-To-One Relationship: [msdyn_playbookactivity team_msdyn_playbookactivity](msdyn_playbookactivity.md#BKMK_team_msdyn_playbookactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_playbookactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_playbookactivityattribute"></a> team_msdyn_playbookactivityattribute

Many-To-One Relationship: [msdyn_playbookactivityattribute team_msdyn_playbookactivityattribute](msdyn_playbookactivityattribute.md#BKMK_team_msdyn_playbookactivityattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookactivityattribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_playbookactivityattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_playbookcategory"></a> team_msdyn_playbookcategory

Many-To-One Relationship: [msdyn_playbookcategory team_msdyn_playbookcategory](msdyn_playbookcategory.md#BKMK_team_msdyn_playbookcategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookcategory`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_playbookcategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_playbookinstance"></a> team_msdyn_playbookinstance

Many-To-One Relationship: [msdyn_playbookinstance team_msdyn_playbookinstance](msdyn_playbookinstance.md#BKMK_team_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_playbookinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_playbooktemplate"></a> team_msdyn_playbooktemplate

Many-To-One Relationship: [msdyn_playbooktemplate team_msdyn_playbooktemplate](msdyn_playbooktemplate.md#BKMK_team_msdyn_playbooktemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbooktemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_playbooktemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_postalbum"></a> team_msdyn_postalbum

Many-To-One Relationship: [msdyn_postalbum team_msdyn_postalbum](msdyn_postalbum.md#BKMK_team_msdyn_postalbum)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalbum`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_postalbum`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_postalcode"></a> team_msdyn_postalcode

Many-To-One Relationship: [msdyn_postalcode team_msdyn_postalcode](msdyn_postalcode.md#BKMK_team_msdyn_postalcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalcode`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_postalcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_predictioncomputationoperation"></a> team_msdyn_predictioncomputationoperation

Many-To-One Relationship: [msdyn_predictioncomputationoperation team_msdyn_predictioncomputationoperation](msdyn_predictioncomputationoperation.md#BKMK_team_msdyn_predictioncomputationoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictioncomputationoperation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_predictioncomputationoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_predictionmodelstatus"></a> team_msdyn_predictionmodelstatus

Many-To-One Relationship: [msdyn_predictionmodelstatus team_msdyn_predictionmodelstatus](msdyn_predictionmodelstatus.md#BKMK_team_msdyn_predictionmodelstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictionmodelstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_predictionmodelstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_predictionscheduledoperation"></a> team_msdyn_predictionscheduledoperation

Many-To-One Relationship: [msdyn_predictionscheduledoperation team_msdyn_predictionscheduledoperation](msdyn_predictionscheduledoperation.md#BKMK_team_msdyn_predictionscheduledoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictionscheduledoperation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_predictionscheduledoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_predictivescoringsyncstatus"></a> team_msdyn_predictivescoringsyncstatus

Many-To-One Relationship: [msdyn_predictivescoringsyncstatus team_msdyn_predictivescoringsyncstatus](msdyn_predictivescoringsyncstatus.md#BKMK_team_msdyn_predictivescoringsyncstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictivescoringsyncstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_predictivescoringsyncstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_preferredagent"></a> team_msdyn_preferredagent

Many-To-One Relationship: [msdyn_preferredagent team_msdyn_preferredagent](msdyn_preferredagent.md#BKMK_team_msdyn_preferredagent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_preferredagent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_preferredagentcustomeridentity"></a> team_msdyn_preferredagentcustomeridentity

Many-To-One Relationship: [msdyn_preferredagentcustomeridentity team_msdyn_preferredagentcustomeridentity](msdyn_preferredagentcustomeridentity.md#BKMK_team_msdyn_preferredagentcustomeridentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagentcustomeridentity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_preferredagentcustomeridentity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_preferredagentroutedentity"></a> team_msdyn_preferredagentroutedentity

Many-To-One Relationship: [msdyn_preferredagentroutedentity team_msdyn_preferredagentroutedentity](msdyn_preferredagentroutedentity.md#BKMK_team_msdyn_preferredagentroutedentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagentroutedentity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_preferredagentroutedentity`|
|IsCustomizable|`True`|
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

### <a name="BKMK_team_msdyn_problematicasset"></a> team_msdyn_problematicasset

Many-To-One Relationship: [msdyn_problematicasset team_msdyn_problematicasset](msdyn_problematicasset.md#BKMK_team_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicasset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_problematicasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_problematicassetfeedback"></a> team_msdyn_problematicassetfeedback

Many-To-One Relationship: [msdyn_problematicassetfeedback team_msdyn_problematicassetfeedback](msdyn_problematicassetfeedback.md#BKMK_team_msdyn_problematicassetfeedback)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicassetfeedback`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_problematicassetfeedback`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_productivityactioninputparameter"></a> team_msdyn_productivityactioninputparameter

Many-To-One Relationship: [msdyn_productivityactioninputparameter team_msdyn_productivityactioninputparameter](msdyn_productivityactioninputparameter.md#BKMK_team_msdyn_productivityactioninputparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityactioninputparameter`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_productivityactioninputparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_productivityactionoutputparameter"></a> team_msdyn_productivityactionoutputparameter

Many-To-One Relationship: [msdyn_productivityactionoutputparameter team_msdyn_productivityactionoutputparameter](msdyn_productivityactionoutputparameter.md#BKMK_team_msdyn_productivityactionoutputparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityactionoutputparameter`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_productivityactionoutputparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_productivityagentscript"></a> team_msdyn_productivityagentscript

Many-To-One Relationship: [msdyn_productivityagentscript team_msdyn_productivityagentscript](msdyn_productivityagentscript.md#BKMK_team_msdyn_productivityagentscript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityagentscript`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_productivityagentscript`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_productivityagentscriptstep"></a> team_msdyn_productivityagentscriptstep

Many-To-One Relationship: [msdyn_productivityagentscriptstep team_msdyn_productivityagentscriptstep](msdyn_productivityagentscriptstep.md#BKMK_team_msdyn_productivityagentscriptstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityagentscriptstep`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_productivityagentscriptstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_productivitymacroactiontemplate"></a> team_msdyn_productivitymacroactiontemplate

Many-To-One Relationship: [msdyn_productivitymacroactiontemplate team_msdyn_productivitymacroactiontemplate](msdyn_productivitymacroactiontemplate.md#BKMK_team_msdyn_productivitymacroactiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacroactiontemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_productivitymacroactiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_productivitymacroconnector"></a> team_msdyn_productivitymacroconnector

Many-To-One Relationship: [msdyn_productivitymacroconnector team_msdyn_productivitymacroconnector](msdyn_productivitymacroconnector.md#BKMK_team_msdyn_productivitymacroconnector)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacroconnector`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_productivitymacroconnector`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_productivitymacrosolutionconfiguration"></a> team_msdyn_productivitymacrosolutionconfiguration

Many-To-One Relationship: [msdyn_productivitymacrosolutionconfiguration team_msdyn_productivitymacrosolutionconfiguration](msdyn_productivitymacrosolutionconfiguration.md#BKMK_team_msdyn_productivitymacrosolutionconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacrosolutionconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_productivitymacrosolutionconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_productivityparameterdefinition"></a> team_msdyn_productivityparameterdefinition

Many-To-One Relationship: [msdyn_productivityparameterdefinition team_msdyn_productivityparameterdefinition](msdyn_productivityparameterdefinition.md#BKMK_team_msdyn_productivityparameterdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityparameterdefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_productivityparameterdefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_property"></a> team_msdyn_property

Many-To-One Relationship: [msdyn_property team_msdyn_property](msdyn_property.md#BKMK_team_msdyn_property)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_property`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_property`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_propertyassetassociation"></a> team_msdyn_propertyassetassociation

Many-To-One Relationship: [msdyn_propertyassetassociation team_msdyn_propertyassetassociation](msdyn_propertyassetassociation.md#BKMK_team_msdyn_propertyassetassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertyassetassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_propertyassetassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_propertylocationassociation"></a> team_msdyn_propertylocationassociation

Many-To-One Relationship: [msdyn_propertylocationassociation team_msdyn_propertylocationassociation](msdyn_propertylocationassociation.md#BKMK_team_msdyn_propertylocationassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylocationassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_propertylocationassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_propertylog"></a> team_msdyn_propertylog

Many-To-One Relationship: [msdyn_propertylog team_msdyn_propertylog](msdyn_propertylog.md#BKMK_team_msdyn_propertylog)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylog`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_propertylog`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_propertytemplateassociation"></a> team_msdyn_propertytemplateassociation

Many-To-One Relationship: [msdyn_propertytemplateassociation team_msdyn_propertytemplateassociation](msdyn_propertytemplateassociation.md#BKMK_team_msdyn_propertytemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertytemplateassociation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_propertytemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorder"></a> team_msdyn_purchaseorder

Many-To-One Relationship: [msdyn_purchaseorder team_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_team_msdyn_purchaseorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorderbill"></a> team_msdyn_purchaseorderbill

Many-To-One Relationship: [msdyn_purchaseorderbill team_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_team_msdyn_purchaseorderbill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderbill`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorderbill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorderproduct"></a> team_msdyn_purchaseorderproduct

Many-To-One Relationship: [msdyn_purchaseorderproduct team_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_team_msdyn_purchaseorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorderreceipt"></a> team_msdyn_purchaseorderreceipt

Many-To-One Relationship: [msdyn_purchaseorderreceipt team_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_team_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceipt`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorderreceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseorderreceiptproduct"></a> team_msdyn_purchaseorderreceiptproduct

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct team_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_team_msdyn_purchaseorderreceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseorderreceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_purchaseordersubstatus"></a> team_msdyn_purchaseordersubstatus

Many-To-One Relationship: [msdyn_purchaseordersubstatus team_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_team_msdyn_purchaseordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseordersubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_purchaseordersubstatus`|
|IsCustomizable|`True`|
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

### <a name="BKMK_team_msdyn_quotebookingincident"></a> team_msdyn_quotebookingincident

Many-To-One Relationship: [msdyn_quotebookingincident team_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_team_msdyn_quotebookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingincident`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingproduct"></a> team_msdyn_quotebookingproduct

Many-To-One Relationship: [msdyn_quotebookingproduct team_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_team_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingservice"></a> team_msdyn_quotebookingservice

Many-To-One Relationship: [msdyn_quotebookingservice team_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_team_msdyn_quotebookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingservicetask"></a> team_msdyn_quotebookingservicetask

Many-To-One Relationship: [msdyn_quotebookingservicetask team_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_team_msdyn_quotebookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservicetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quotebookingsetup"></a> team_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup team_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_team_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quotebookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quoteinvoicingproduct"></a> team_msdyn_quoteinvoicingproduct

Many-To-One Relationship: [msdyn_quoteinvoicingproduct team_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_team_msdyn_quoteinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quoteinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_quoteinvoicingsetup"></a> team_msdyn_quoteinvoicingsetup

Many-To-One Relationship: [msdyn_quoteinvoicingsetup team_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_team_msdyn_quoteinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingsetup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_quoteinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_readtracker"></a> team_msdyn_readtracker

Many-To-One Relationship: [msdyn_readtracker team_msdyn_readtracker](msdyn_readtracker.md#BKMK_team_msdyn_readtracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtracker`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_readtracker`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_realtimescoring"></a> team_msdyn_realtimescoring

Many-To-One Relationship: [msdyn_realtimescoring team_msdyn_realtimescoring](msdyn_realtimescoring.md#BKMK_team_msdyn_realtimescoring)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_realtimescoring`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_realtimescoring`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_realtimescoringoperation"></a> team_msdyn_realtimescoringoperation

Many-To-One Relationship: [msdyn_realtimescoringoperation team_msdyn_realtimescoringoperation](msdyn_realtimescoringoperation.md#BKMK_team_msdyn_realtimescoringoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_realtimescoringoperation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_realtimescoringoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_recording"></a> team_msdyn_recording

Many-To-One Relationship: [msdyn_recording team_msdyn_recording](msdyn_recording.md#BKMK_team_msdyn_recording)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recording`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_recording`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_relationshipinsightsunifiedconfig"></a> team_msdyn_relationshipinsightsunifiedconfig

Many-To-One Relationship: [msdyn_relationshipinsightsunifiedconfig team_msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md#BKMK_team_msdyn_relationshipinsightsunifiedconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_relationshipinsightsunifiedconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_relationshipinsightsunifiedconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_reportbookmark"></a> team_msdyn_reportbookmark

Many-To-One Relationship: [msdyn_reportbookmark team_msdyn_reportbookmark](msdyn_reportbookmark.md#BKMK_team_msdyn_reportbookmark)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_reportbookmark`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_reportbookmark`|
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

### <a name="BKMK_team_msdyn_resolution"></a> team_msdyn_resolution

Many-To-One Relationship: [msdyn_resolution team_msdyn_resolution](msdyn_resolution.md#BKMK_team_msdyn_resolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resolution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_resourcepaytype"></a> team_msdyn_resourcepaytype

Many-To-One Relationship: [msdyn_resourcepaytype team_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_team_msdyn_resourcepaytype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcepaytype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_resourcepaytype`|
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

### <a name="BKMK_team_msdyn_rma"></a> team_msdyn_rma

Many-To-One Relationship: [msdyn_rma team_msdyn_rma](msdyn_rma.md#BKMK_team_msdyn_rma)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rma`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rmaproduct"></a> team_msdyn_rmaproduct

Many-To-One Relationship: [msdyn_rmaproduct team_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_team_msdyn_rmaproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rmaproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rmareceipt"></a> team_msdyn_rmareceipt

Many-To-One Relationship: [msdyn_rmareceipt team_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_team_msdyn_rmareceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceipt`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rmareceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rmareceiptproduct"></a> team_msdyn_rmareceiptproduct

Many-To-One Relationship: [msdyn_rmareceiptproduct team_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_team_msdyn_rmareceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceiptproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rmareceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rmasubstatus"></a> team_msdyn_rmasubstatus

Many-To-One Relationship: [msdyn_rmasubstatus team_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_team_msdyn_rmasubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmasubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rmasubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_routingconfiguration"></a> team_msdyn_routingconfiguration

Many-To-One Relationship: [msdyn_routingconfiguration team_msdyn_routingconfiguration](msdyn_routingconfiguration.md#BKMK_team_msdyn_routingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_routingconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_routingconfigurationstep"></a> team_msdyn_routingconfigurationstep

Many-To-One Relationship: [msdyn_routingconfigurationstep team_msdyn_routingconfigurationstep](msdyn_routingconfigurationstep.md#BKMK_team_msdyn_routingconfigurationstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingconfigurationstep`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_routingconfigurationstep`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_routingengineconfiguration"></a> team_msdyn_routingengineconfiguration

Many-To-One Relationship: [msdyn_routingengineconfiguration team_msdyn_routingengineconfiguration](msdyn_routingengineconfiguration.md#BKMK_team_msdyn_routingengineconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingengineconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_routingengineconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_routingjobconfiguration"></a> team_msdyn_routingjobconfiguration

Many-To-One Relationship: [msdyn_routingjobconfiguration team_msdyn_routingjobconfiguration](msdyn_routingjobconfiguration.md#BKMK_team_msdyn_routingjobconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingjobconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_routingjobconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_routingoptimizationrequest"></a> team_msdyn_routingoptimizationrequest

Many-To-One Relationship: [msdyn_routingoptimizationrequest team_msdyn_routingoptimizationrequest](msdyn_routingoptimizationrequest.md#BKMK_team_msdyn_routingoptimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingoptimizationrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_routingoptimizationrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_routingprofileconfiguration"></a> team_msdyn_routingprofileconfiguration

Many-To-One Relationship: [msdyn_routingprofileconfiguration team_msdyn_routingprofileconfiguration](msdyn_routingprofileconfiguration.md#BKMK_team_msdyn_routingprofileconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingprofileconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_routingprofileconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_routingrequest"></a> team_msdyn_routingrequest

Many-To-One Relationship: [msdyn_routingrequest team_msdyn_routingrequest](msdyn_routingrequest.md#BKMK_team_msdyn_routingrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_routingrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rtv"></a> team_msdyn_rtv

Many-To-One Relationship: [msdyn_rtv team_msdyn_rtv](msdyn_rtv.md#BKMK_team_msdyn_rtv)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rtv`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rtvproduct"></a> team_msdyn_rtvproduct

Many-To-One Relationship: [msdyn_rtvproduct team_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_team_msdyn_rtvproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rtvproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rtvsubstatus"></a> team_msdyn_rtvsubstatus

Many-To-One Relationship: [msdyn_rtvsubstatus team_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_team_msdyn_rtvsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvsubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rtvsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_rulesetdependencymapping"></a> team_msdyn_rulesetdependencymapping

Many-To-One Relationship: [msdyn_rulesetdependencymapping team_msdyn_rulesetdependencymapping](msdyn_rulesetdependencymapping.md#BKMK_team_msdyn_rulesetdependencymapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rulesetdependencymapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rulesetdependencymapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_salescopilotinsight"></a> team_msdyn_salescopilotinsight

Many-To-One Relationship: [msdyn_salescopilotinsight team_msdyn_salescopilotinsight](msdyn_salescopilotinsight.md#BKMK_team_msdyn_salescopilotinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salescopilotinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_salesinsightssettings"></a> team_msdyn_salesinsightssettings

Many-To-One Relationship: [msdyn_salesinsightssettings team_msdyn_salesinsightssettings](msdyn_salesinsightssettings.md#BKMK_team_msdyn_salesinsightssettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesinsightssettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salesinsightssettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_salesocmessage"></a> team_msdyn_salesocmessage

Many-To-One Relationship: [msdyn_salesocmessage team_msdyn_salesocmessage](msdyn_salesocmessage.md#BKMK_team_msdyn_salesocmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesocmessage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salesocmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_salesocsmstemplate"></a> team_msdyn_salesocsmstemplate

Many-To-One Relationship: [msdyn_salesocsmstemplate team_msdyn_salesocsmstemplate](msdyn_salesocsmstemplate.md#BKMK_team_msdyn_salesocsmstemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesocsmstemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salesocsmstemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_salesroutingrun"></a> team_msdyn_salesroutingrun

Many-To-One Relationship: [msdyn_salesroutingrun team_msdyn_salesroutingrun](msdyn_salesroutingrun.md#BKMK_team_msdyn_salesroutingrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salesroutingrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_salessuggestion"></a> team_msdyn_salessuggestion

Many-To-One Relationship: [msdyn_salessuggestion team_msdyn_salessuggestion](msdyn_salessuggestion.md#BKMK_team_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salessuggestion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salessuggestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_salestag"></a> team_msdyn_salestag

Many-To-One Relationship: [msdyn_salestag team_msdyn_salestag](msdyn_salestag.md#BKMK_team_msdyn_salestag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salestag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salestag`|
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

### <a name="BKMK_team_msdyn_sciconversation"></a> team_msdyn_sciconversation

Many-To-One Relationship: [msdyn_sciconversation team_msdyn_sciconversation](msdyn_sciconversation.md#BKMK_team_msdyn_sciconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciconversation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sciconversation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_scicustomemailhighlight"></a> team_msdyn_scicustomemailhighlight

Many-To-One Relationship: [msdyn_scicustomemailhighlight team_msdyn_scicustomemailhighlight](msdyn_scicustomemailhighlight.md#BKMK_team_msdyn_scicustomemailhighlight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustomemailhighlight`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_scicustomemailhighlight`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_scicustomhighlight"></a> team_msdyn_scicustomhighlight

Many-To-One Relationship: [msdyn_scicustomhighlight team_msdyn_scicustomhighlight](msdyn_scicustomhighlight.md#BKMK_team_msdyn_scicustomhighlight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustomhighlight`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_scicustomhighlight`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_scicustompublisher"></a> team_msdyn_scicustompublisher

Many-To-One Relationship: [msdyn_scicustompublisher team_msdyn_scicustompublisher](msdyn_scicustompublisher.md#BKMK_team_msdyn_scicustompublisher)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustompublisher`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_scicustompublisher`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sciusersettings"></a> team_msdyn_sciusersettings

Many-To-One Relationship: [msdyn_sciusersettings team_msdyn_sciusersettings](msdyn_sciusersettings.md#BKMK_team_msdyn_sciusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciusersettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sciusersettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_searchconfiguration"></a> team_msdyn_searchconfiguration

Many-To-One Relationship: [msdyn_searchconfiguration team_msdyn_searchconfiguration](msdyn_searchconfiguration.md#BKMK_team_msdyn_searchconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_searchconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_searchconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_segment"></a> team_msdyn_segment

Many-To-One Relationship: [msdyn_segment team_msdyn_segment](msdyn_segment.md#BKMK_team_msdyn_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_segment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_segment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sequence"></a> team_msdyn_sequence

Many-To-One Relationship: [msdyn_sequence team_msdyn_sequence](msdyn_sequence.md#BKMK_team_msdyn_sequence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequence`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sequence`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sequencestat"></a> team_msdyn_sequencestat

Many-To-One Relationship: [msdyn_sequencestat team_msdyn_sequencestat](msdyn_sequencestat.md#BKMK_team_msdyn_sequencestat)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencestat`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sequencestat`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sequencetarget"></a> team_msdyn_sequencetarget

Many-To-One Relationship: [msdyn_sequencetarget team_msdyn_sequencetarget](msdyn_sequencetarget.md#BKMK_team_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sequencetarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sequencetargetstep"></a> team_msdyn_sequencetargetstep

Many-To-One Relationship: [msdyn_sequencetargetstep team_msdyn_sequencetargetstep](msdyn_sequencetargetstep.md#BKMK_team_msdyn_sequencetargetstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetargetstep`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sequencetargetstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sequencetemplate"></a> team_msdyn_sequencetemplate

Many-To-One Relationship: [msdyn_sequencetemplate team_msdyn_sequencetemplate](msdyn_sequencetemplate.md#BKMK_team_msdyn_sequencetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sequencetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_serviceoneprovisioningrequest"></a> team_msdyn_serviceoneprovisioningrequest

Many-To-One Relationship: [msdyn_serviceoneprovisioningrequest team_msdyn_serviceoneprovisioningrequest](msdyn_serviceoneprovisioningrequest.md#BKMK_team_msdyn_serviceoneprovisioningrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_serviceoneprovisioningrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_serviceoneprovisioningrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_servicetasktype"></a> team_msdyn_servicetasktype

Many-To-One Relationship: [msdyn_servicetasktype team_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_team_msdyn_servicetasktype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicetasktype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_servicetasktype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sessiondata"></a> team_msdyn_sessiondata

Many-To-One Relationship: [msdyn_sessiondata team_msdyn_sessiondata](msdyn_sessiondata.md#BKMK_team_msdyn_sessiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiondata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sessiondata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sessionevent"></a> team_msdyn_sessionevent

Many-To-One Relationship: [msdyn_sessionevent team_msdyn_sessionevent](msdyn_sessionevent.md#BKMK_team_msdyn_sessionevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionevent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sessionevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sessionparticipant"></a> team_msdyn_sessionparticipant

Many-To-One Relationship: [msdyn_sessionparticipant team_msdyn_sessionparticipant](msdyn_sessionparticipant.md#BKMK_team_msdyn_sessionparticipant)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipant`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sessionparticipant`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sessionparticipantdata"></a> team_msdyn_sessionparticipantdata

Many-To-One Relationship: [msdyn_sessionparticipantdata team_msdyn_sessionparticipantdata](msdyn_sessionparticipantdata.md#BKMK_team_msdyn_sessionparticipantdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipantdata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sessionparticipantdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_sessiontemplate"></a> team_msdyn_sessiontemplate

Many-To-One Relationship: [msdyn_sessiontemplate team_msdyn_sessiontemplate](msdyn_sessiontemplate.md#BKMK_team_msdyn_sessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiontemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sessiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_shipvia"></a> team_msdyn_shipvia

Many-To-One Relationship: [msdyn_shipvia team_msdyn_shipvia](msdyn_shipvia.md#BKMK_team_msdyn_shipvia)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_shipvia`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_shipvia`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_siconfig"></a> team_msdyn_siconfig

Many-To-One Relationship: [msdyn_siconfig team_msdyn_siconfig](msdyn_siconfig.md#BKMK_team_msdyn_siconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_siconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_siconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_skillattachmentruleitem"></a> team_msdyn_skillattachmentruleitem

Many-To-One Relationship: [msdyn_skillattachmentruleitem team_msdyn_skillattachmentruleitem](msdyn_skillattachmentruleitem.md#BKMK_team_msdyn_skillattachmentruleitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_skillattachmentruleitem`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_skillattachmentruleitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_skillattachmenttarget"></a> team_msdyn_skillattachmenttarget

Many-To-One Relationship: [msdyn_skillattachmenttarget team_msdyn_skillattachmenttarget](msdyn_skillattachmenttarget.md#BKMK_team_msdyn_skillattachmenttarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_skillattachmenttarget`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_skillattachmenttarget`|
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

### <a name="BKMK_team_msdyn_soundnotificationsetting"></a> team_msdyn_soundnotificationsetting

Many-To-One Relationship: [msdyn_soundnotificationsetting team_msdyn_soundnotificationsetting](msdyn_soundnotificationsetting.md#BKMK_team_msdyn_soundnotificationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_soundnotificationsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_soundnotificationsetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_submodeldefinition"></a> team_msdyn_submodeldefinition

Many-To-One Relationship: [msdyn_submodeldefinition team_msdyn_submodeldefinition](msdyn_submodeldefinition.md#BKMK_team_msdyn_submodeldefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_submodeldefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_submodeldefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_suggestionassignmentrule"></a> team_msdyn_suggestionassignmentrule

Many-To-One Relationship: [msdyn_suggestionassignmentrule team_msdyn_suggestionassignmentrule](msdyn_suggestionassignmentrule.md#BKMK_team_msdyn_suggestionassignmentrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionassignmentrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_suggestionassignmentrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_suggestionprincipalobjectaccess"></a> team_msdyn_suggestionprincipalobjectaccess

Many-To-One Relationship: [msdyn_suggestionprincipalobjectaccess team_msdyn_suggestionprincipalobjectaccess](msdyn_suggestionprincipalobjectaccess.md#BKMK_team_msdyn_suggestionprincipalobjectaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionprincipalobjectaccess`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_suggestionprincipalobjectaccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_suggestionsellerpriority"></a> team_msdyn_suggestionsellerpriority

Many-To-One Relationship: [msdyn_suggestionsellerpriority team_msdyn_suggestionsellerpriority](msdyn_suggestionsellerpriority.md#BKMK_team_msdyn_suggestionsellerpriority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionsellerpriority`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_suggestionsellerpriority`|
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

### <a name="BKMK_team_msdyn_swarm"></a> team_msdyn_swarm

Many-To-One Relationship: [msdyn_swarm team_msdyn_swarm](msdyn_swarm.md#BKMK_team_msdyn_swarm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarm`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_swarm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_swarmparticipant"></a> team_msdyn_swarmparticipant

Many-To-One Relationship: [msdyn_swarmparticipant team_msdyn_swarmparticipant](msdyn_swarmparticipant.md#BKMK_team_msdyn_swarmparticipant)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmparticipant`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_swarmparticipant`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_swarmparticipantrule"></a> team_msdyn_swarmparticipantrule

Many-To-One Relationship: [msdyn_swarmparticipantrule team_msdyn_swarmparticipantrule](msdyn_swarmparticipantrule.md#BKMK_team_msdyn_swarmparticipantrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmparticipantrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_swarmparticipantrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_swarmrole"></a> team_msdyn_swarmrole

Many-To-One Relationship: [msdyn_swarmrole team_msdyn_swarmrole](msdyn_swarmrole.md#BKMK_team_msdyn_swarmrole)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmrole`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_swarmrole`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_swarmskill"></a> team_msdyn_swarmskill

Many-To-One Relationship: [msdyn_swarmskill team_msdyn_swarmskill](msdyn_swarmskill.md#BKMK_team_msdyn_swarmskill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmskill`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_swarmskill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_swarmtemplate"></a> team_msdyn_swarmtemplate

Many-To-One Relationship: [msdyn_swarmtemplate team_msdyn_swarmtemplate](msdyn_swarmtemplate.md#BKMK_team_msdyn_swarmtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_swarmtemplate`|
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

### <a name="BKMK_team_msdyn_taggedrecord"></a> team_msdyn_taggedrecord

Many-To-One Relationship: [msdyn_taggedrecord team_msdyn_taggedrecord](msdyn_taggedrecord.md#BKMK_team_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taggedrecord`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_taggedrecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_taxcode"></a> team_msdyn_taxcode

Many-To-One Relationship: [msdyn_taxcode team_msdyn_taxcode](msdyn_taxcode.md#BKMK_team_msdyn_taxcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcode`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_taxcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_taxcodedetail"></a> team_msdyn_taxcodedetail

Many-To-One Relationship: [msdyn_taxcodedetail team_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_team_msdyn_taxcodedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcodedetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_taxcodedetail`|
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

### <a name="BKMK_team_msdyn_teamsengagementctx"></a> team_msdyn_teamsengagementctx

Many-To-One Relationship: [msdyn_teamsengagementctx team_msdyn_teamsengagementctx](msdyn_teamsengagementctx.md#BKMK_team_msdyn_teamsengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamsengagementctx`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_teamsengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_templateforproperties"></a> team_msdyn_templateforproperties

Many-To-One Relationship: [msdyn_templateforproperties team_msdyn_templateforproperties](msdyn_templateforproperties.md#BKMK_team_msdyn_templateforproperties)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateforproperties`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_templateforproperties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_templateparameter"></a> team_msdyn_templateparameter

Many-To-One Relationship: [msdyn_templateparameter team_msdyn_templateparameter](msdyn_templateparameter.md#BKMK_team_msdyn_templateparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateparameter`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_templateparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_templatetags"></a> team_msdyn_templatetags

Many-To-One Relationship: [msdyn_templatetags team_msdyn_templatetags](msdyn_templatetags.md#BKMK_team_msdyn_templatetags)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templatetags`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_templatetags`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timeentry"></a> team_msdyn_timeentry

Many-To-One Relationship: [msdyn_timeentry team_msdyn_timeentry](msdyn_timeentry.md#BKMK_team_msdyn_timeentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timeentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timeentrysetting"></a> team_msdyn_timeentrysetting

Many-To-One Relationship: [msdyn_timeentrysetting team_msdyn_timeentrysetting](msdyn_timeentrysetting.md#BKMK_team_msdyn_timeentrysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentrysetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timeentrysetting`|
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

### <a name="BKMK_team_msdyn_timeoffrequest"></a> team_msdyn_timeoffrequest

Many-To-One Relationship: [msdyn_timeoffrequest team_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_team_msdyn_timeoffrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeoffrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timeoffrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_timespent"></a> team_msdyn_timespent

Many-To-One Relationship: [msdyn_timespent team_msdyn_timespent](msdyn_timespent.md#BKMK_team_msdyn_timespent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timespent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timespent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_trade"></a> team_msdyn_trade

Many-To-One Relationship: [msdyn_trade team_msdyn_trade](msdyn_trade.md#BKMK_team_msdyn_trade)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_trade`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_trade`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_tradecoverage"></a> team_msdyn_tradecoverage

Many-To-One Relationship: [msdyn_tradecoverage team_msdyn_tradecoverage](msdyn_tradecoverage.md#BKMK_team_msdyn_tradecoverage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_tradecoverage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_tradecoverage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_trainingresult"></a> team_msdyn_trainingresult

Many-To-One Relationship: [msdyn_trainingresult team_msdyn_trainingresult](msdyn_trainingresult.md#BKMK_team_msdyn_trainingresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_trainingresult`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_trainingresult`|
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

### <a name="BKMK_team_msdyn_transcript"></a> team_msdyn_transcript

Many-To-One Relationship: [msdyn_transcript team_msdyn_transcript](msdyn_transcript.md#BKMK_team_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_transcript`|
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

### <a name="BKMK_team_msdyn_unifiedroutingdiagnostic"></a> team_msdyn_unifiedroutingdiagnostic

Many-To-One Relationship: [msdyn_unifiedroutingdiagnostic team_msdyn_unifiedroutingdiagnostic](msdyn_unifiedroutingdiagnostic.md#BKMK_team_msdyn_unifiedroutingdiagnostic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingdiagnostic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_unifiedroutingdiagnostic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_unifiedroutingrun"></a> team_msdyn_unifiedroutingrun

Many-To-One Relationship: [msdyn_unifiedroutingrun team_msdyn_unifiedroutingrun](msdyn_unifiedroutingrun.md#BKMK_team_msdyn_unifiedroutingrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingrun`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_unifiedroutingrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_untrackedappointment"></a> team_msdyn_untrackedappointment

Many-To-One Relationship: [msdyn_untrackedappointment team_msdyn_untrackedappointment](msdyn_untrackedappointment.md#BKMK_team_msdyn_untrackedappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_untrackedappointment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_untrackedappointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_urnotificationtemplate"></a> team_msdyn_urnotificationtemplate

Many-To-One Relationship: [msdyn_urnotificationtemplate team_msdyn_urnotificationtemplate](msdyn_urnotificationtemplate.md#BKMK_team_msdyn_urnotificationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_urnotificationtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_urnotificationtemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_urnotificationtemplatemapping"></a> team_msdyn_urnotificationtemplatemapping

Many-To-One Relationship: [msdyn_urnotificationtemplatemapping team_msdyn_urnotificationtemplatemapping](msdyn_urnotificationtemplatemapping.md#BKMK_team_msdyn_urnotificationtemplatemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_urnotificationtemplatemapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_urnotificationtemplatemapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_visitorjourney"></a> team_msdyn_visitorjourney

Many-To-One Relationship: [msdyn_visitorjourney team_msdyn_visitorjourney](msdyn_visitorjourney.md#BKMK_team_msdyn_visitorjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_visitorjourney`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_visitorjourney`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_vivacustomerlist"></a> team_msdyn_vivacustomerlist

Many-To-One Relationship: [msdyn_vivacustomerlist team_msdyn_vivacustomerlist](msdyn_vivacustomerlist.md#BKMK_team_msdyn_vivacustomerlist)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_vivacustomerlist`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_vivacustomerlist`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_vivausersetting"></a> team_msdyn_vivausersetting

Many-To-One Relationship: [msdyn_vivausersetting team_msdyn_vivausersetting](msdyn_vivausersetting.md#BKMK_team_msdyn_vivausersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_vivausersetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_vivausersetting`|
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

### <a name="BKMK_team_msdyn_wallsavedqueryusersettings"></a> team_msdyn_wallsavedqueryusersettings

Many-To-One Relationship: [msdyn_wallsavedqueryusersettings team_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_team_msdyn_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wallsavedqueryusersettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_wallsavedqueryusersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_warehouse"></a> team_msdyn_warehouse

Many-To-One Relationship: [msdyn_warehouse team_msdyn_warehouse](msdyn_warehouse.md#BKMK_team_msdyn_warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warehouse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_warranty"></a> team_msdyn_warranty

Many-To-One Relationship: [msdyn_warranty team_msdyn_warranty](msdyn_warranty.md#BKMK_team_msdyn_warranty)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warranty`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_warranty`|
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

### <a name="BKMK_team_msdyn_wkwconfig"></a> team_msdyn_wkwconfig

Many-To-One Relationship: [msdyn_wkwconfig team_msdyn_wkwconfig](msdyn_wkwconfig.md#BKMK_team_msdyn_wkwconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wkwconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_wkwconfig`|
|IsCustomizable|`True`|
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

### <a name="BKMK_team_msdyn_workorder"></a> team_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder team_msdyn_workorder](msdyn_workorder.md#BKMK_team_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workordercharacteristic"></a> team_msdyn_workordercharacteristic

Many-To-One Relationship: [msdyn_workordercharacteristic team_msdyn_workordercharacteristic](msdyn_workordercharacteristic.md#BKMK_team_msdyn_workordercharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordercharacteristic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workordercharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderincident"></a> team_msdyn_workorderincident

Many-To-One Relationship: [msdyn_workorderincident team_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_team_msdyn_workorderincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workordernte"></a> team_msdyn_workordernte

Many-To-One Relationship: [msdyn_workordernte team_msdyn_workordernte](msdyn_workordernte.md#BKMK_team_msdyn_workordernte)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordernte`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workordernte`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderproduct"></a> team_msdyn_workorderproduct

Many-To-One Relationship: [msdyn_workorderproduct team_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_team_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderresolution"></a> team_msdyn_workorderresolution

Many-To-One Relationship: [msdyn_workorderresolution team_msdyn_workorderresolution](msdyn_workorderresolution.md#BKMK_team_msdyn_workorderresolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresolution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderresolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderresourcerestriction"></a> team_msdyn_workorderresourcerestriction

Many-To-One Relationship: [msdyn_workorderresourcerestriction team_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_team_msdyn_workorderresourcerestriction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresourcerestriction`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderresourcerestriction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderservice"></a> team_msdyn_workorderservice

Many-To-One Relationship: [msdyn_workorderservice team_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_team_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workorderservicetask"></a> team_msdyn_workorderservicetask

Many-To-One Relationship: [msdyn_workorderservicetask team_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_team_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workorderservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workordersubstatus"></a> team_msdyn_workordersubstatus

Many-To-One Relationship: [msdyn_workordersubstatus team_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_team_msdyn_workordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordersubstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workordersubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workordertype"></a> team_msdyn_workordertype

Many-To-One Relationship: [msdyn_workordertype team_msdyn_workordertype](msdyn_workordertype.md#BKMK_team_msdyn_workordertype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordertype`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workordertype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workqueuestate"></a> team_msdyn_workqueuestate

Many-To-One Relationship: [msdyn_workqueuestate team_msdyn_workqueuestate](msdyn_workqueuestate.md#BKMK_team_msdyn_workqueuestate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workqueuestate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workqueuestate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_workqueueusersetting"></a> team_msdyn_workqueueusersetting

Many-To-One Relationship: [msdyn_workqueueusersetting team_msdyn_workqueueusersetting](msdyn_workqueueusersetting.md#BKMK_team_msdyn_workqueueusersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workqueueusersetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_workqueueusersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_alternatekey"></a> team_msdynci_alternatekey

Many-To-One Relationship: [msdynci_alternatekey team_msdynci_alternatekey](msdynci_alternatekey.md#BKMK_team_msdynci_alternatekey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_alternatekey`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_alternatekey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_contactprofile"></a> team_msdynci_contactprofile

Many-To-One Relationship: [msdynci_contactprofile team_msdynci_contactprofile](msdynci_contactprofile.md#BKMK_team_msdynci_contactprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_contactprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_contactprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_customermeasure"></a> team_msdynci_customermeasure

Many-To-One Relationship: [msdynci_customermeasure team_msdynci_customermeasure](msdynci_customermeasure.md#BKMK_team_msdynci_customermeasure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_customermeasure`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_customermeasure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_customerprofile"></a> team_msdynci_customerprofile

Many-To-One Relationship: [msdynci_customerprofile team_msdynci_customerprofile](msdynci_customerprofile.md#BKMK_team_msdynci_customerprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_customerprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_customerprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_customerprofilesegment"></a> team_msdynci_customerprofilesegment

Many-To-One Relationship: [msdynci_customerprofilesegment team_msdynci_customerprofilesegment](msdynci_customerprofilesegment.md#BKMK_team_msdynci_customerprofilesegment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_customerprofilesegment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_customerprofilesegment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_enrichment"></a> team_msdynci_enrichment

Many-To-One Relationship: [msdynci_enrichment team_msdynci_enrichment](msdynci_enrichment.md#BKMK_team_msdynci_enrichment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_enrichment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_enrichment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_personalizationaction"></a> team_msdynci_personalizationaction

Many-To-One Relationship: [msdynci_personalizationaction team_msdynci_personalizationaction](msdynci_personalizationaction.md#BKMK_team_msdynci_personalizationaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationaction`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_personalizationaction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_personalizationcookie"></a> team_msdynci_personalizationcookie

Many-To-One Relationship: [msdynci_personalizationcookie team_msdynci_personalizationcookie](msdynci_personalizationcookie.md#BKMK_team_msdynci_personalizationcookie)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationcookie`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_personalizationcookie`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_personalizationuser"></a> team_msdynci_personalizationuser

Many-To-One Relationship: [msdynci_personalizationuser team_msdynci_personalizationuser](msdynci_personalizationuser.md#BKMK_team_msdynci_personalizationuser)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationuser`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_personalizationuser`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_personalizationview"></a> team_msdynci_personalizationview

Many-To-One Relationship: [msdynci_personalizationview team_msdynci_personalizationview](msdynci_personalizationview.md#BKMK_team_msdynci_personalizationview)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationview`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_personalizationview`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_prediction"></a> team_msdynci_prediction

Many-To-One Relationship: [msdynci_prediction team_msdynci_prediction](msdynci_prediction.md#BKMK_team_msdynci_prediction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_prediction`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_prediction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_segmentmembership"></a> team_msdynci_segmentmembership

Many-To-One Relationship: [msdynci_segmentmembership team_msdynci_segmentmembership](msdynci_segmentmembership.md#BKMK_team_msdynci_segmentmembership)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_segmentmembership`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_segmentmembership`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_unifiedactivity"></a> team_msdynci_unifiedactivity

Many-To-One Relationship: [msdynci_unifiedactivity team_msdynci_unifiedactivity](msdynci_unifiedactivity.md#BKMK_team_msdynci_unifiedactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_unifiedactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_unifiedactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_unifiedcontact_alternatekey"></a> team_msdynci_unifiedcontact_alternatekey

Many-To-One Relationship: [msdynci_unifiedcontact_alternatekey team_msdynci_unifiedcontact_alternatekey](msdynci_unifiedcontact_alternatekey.md#BKMK_team_msdynci_unifiedcontact_alternatekey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_unifiedcontact_alternatekey`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_unifiedcontact_alternatekey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_unifiedcontactprofile"></a> team_msdynci_unifiedcontactprofile

Many-To-One Relationship: [msdynci_unifiedcontactprofile team_msdynci_unifiedcontactprofile](msdynci_unifiedcontactprofile.md#BKMK_team_msdynci_unifiedcontactprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_unifiedcontactprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_unifiedcontactprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynci_unifiedcontactsegment"></a> team_msdynci_unifiedcontactsegment

Many-To-One Relationship: [msdynci_unifiedcontactsegment team_msdynci_unifiedcontactsegment](msdynci_unifiedcontactsegment.md#BKMK_team_msdynci_unifiedcontactsegment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_unifiedcontactsegment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynci_unifiedcontactsegment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_addtocalendarstyle"></a> team_msdyncrm_addtocalendarstyle

Many-To-One Relationship: [msdyncrm_addtocalendarstyle team_msdyncrm_addtocalendarstyle](msdyncrm_addtocalendarstyle.md#BKMK_team_msdyncrm_addtocalendarstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_addtocalendarstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_addtocalendarstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_appointmentactivity"></a> team_msdyncrm_appointmentactivity

Many-To-One Relationship: [msdyncrm_appointmentactivity team_msdyncrm_appointmentactivity](msdyncrm_appointmentactivity.md#BKMK_team_msdyncrm_appointmentactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_appointmentactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_appointmentactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_appointmentactivitymarketingtemplate"></a> team_msdyncrm_appointmentactivitymarketingtemplate

Many-To-One Relationship: [msdyncrm_appointmentactivitymarketingtemplate team_msdyncrm_appointmentactivitymarketingtemplate](msdyncrm_appointmentactivitymarketingtemplate.md#BKMK_team_msdyncrm_appointmentactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_appointmentactivitymarketingtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_appointmentactivitymarketingtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_basestyle"></a> team_msdyncrm_basestyle

Many-To-One Relationship: [msdyncrm_basestyle team_msdyncrm_basestyle](msdyncrm_basestyle.md#BKMK_team_msdyncrm_basestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_basestyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_basestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_buttonstyle"></a> team_msdyncrm_buttonstyle

Many-To-One Relationship: [msdyncrm_buttonstyle team_msdyncrm_buttonstyle](msdyncrm_buttonstyle.md#BKMK_team_msdyncrm_buttonstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_buttonstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_buttonstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_cdnconfiguration"></a> team_msdyncrm_cdnconfiguration

Many-To-One Relationship: [msdyncrm_cdnconfiguration team_msdyncrm_cdnconfiguration](msdyncrm_cdnconfiguration.md#BKMK_team_msdyncrm_cdnconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_cdnconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_cdnconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_cdsaconnectorconfiguration"></a> team_msdyncrm_cdsaconnectorconfiguration

Many-To-One Relationship: [msdyncrm_cdsaconnectorconfiguration team_msdyncrm_cdsaconnectorconfiguration](msdyncrm_cdsaconnectorconfiguration.md#BKMK_team_msdyncrm_cdsaconnectorconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_cdsaconnectorconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_cdsaconnectorconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_codestyle"></a> team_msdyncrm_codestyle

Many-To-One Relationship: [msdyncrm_codestyle team_msdyncrm_codestyle](msdyncrm_codestyle.md#BKMK_team_msdyncrm_codestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_codestyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_codestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_columnstyle"></a> team_msdyncrm_columnstyle

Many-To-One Relationship: [msdyncrm_columnstyle team_msdyncrm_columnstyle](msdyncrm_columnstyle.md#BKMK_team_msdyncrm_columnstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_columnstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_columnstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_contentblock"></a> team_msdyncrm_contentblock

Many-To-One Relationship: [msdyncrm_contentblock team_msdyncrm_contentblock](msdyncrm_contentblock.md#BKMK_team_msdyncrm_contentblock)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentblock`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_contentblock`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_contentblockstyle"></a> team_msdyncrm_contentblockstyle

Many-To-One Relationship: [msdyncrm_contentblockstyle team_msdyncrm_contentblockstyle](msdyncrm_contentblockstyle.md#BKMK_team_msdyncrm_contentblockstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentblockstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_contentblockstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_contentsettings"></a> team_msdyncrm_contentsettings

Many-To-One Relationship: [msdyncrm_contentsettings team_msdyncrm_contentsettings](msdyncrm_contentsettings.md#BKMK_team_msdyncrm_contentsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_contentsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_createleadactivity"></a> team_msdyncrm_createleadactivity

Many-To-One Relationship: [msdyncrm_createleadactivity team_msdyncrm_createleadactivity](msdyncrm_createleadactivity.md#BKMK_team_msdyncrm_createleadactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_createleadactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_createleadactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_customerinsightsinfo"></a> team_msdyncrm_customerinsightsinfo

Many-To-One Relationship: [msdyncrm_customerinsightsinfo team_msdyncrm_customerinsightsinfo](msdyncrm_customerinsightsinfo.md#BKMK_team_msdyncrm_customerinsightsinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerinsightsinfo`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_customerinsightsinfo`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_customerjourney"></a> team_msdyncrm_customerjourney

Many-To-One Relationship: [msdyncrm_customerjourney team_msdyncrm_customerjourney](msdyncrm_customerjourney.md#BKMK_team_msdyncrm_customerjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourney`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_customerjourney`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_customerjourneycustomchannelactivity"></a> team_msdyncrm_customerjourneycustomchannelactivity

Many-To-One Relationship: [msdyncrm_customerjourneycustomchannelactivity team_msdyncrm_customerjourneycustomchannelactivity](msdyncrm_customerjourneycustomchannelactivity.md#BKMK_team_msdyncrm_customerjourneycustomchannelactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneycustomchannelactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_customerjourneycustomchannelactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_customerjourneyiteration"></a> team_msdyncrm_customerjourneyiteration

Many-To-One Relationship: [msdyncrm_customerjourneyiteration team_msdyncrm_customerjourneyiteration](msdyncrm_customerjourneyiteration.md#BKMK_team_msdyncrm_customerjourneyiteration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneyiteration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_customerjourneyiteration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_customerjourneyruntimestate"></a> team_msdyncrm_customerjourneyruntimestate

Many-To-One Relationship: [msdyncrm_customerjourneyruntimestate team_msdyncrm_customerjourneyruntimestate](msdyncrm_customerjourneyruntimestate.md#BKMK_team_msdyncrm_customerjourneyruntimestate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneyruntimestate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_customerjourneyruntimestate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_customerjourneytemplate"></a> team_msdyncrm_customerjourneytemplate

Many-To-One Relationship: [msdyncrm_customerjourneytemplate team_msdyncrm_customerjourneytemplate](msdyncrm_customerjourneytemplate.md#BKMK_team_msdyncrm_customerjourneytemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneytemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_customerjourneytemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_customerjourneyworkflowlink"></a> team_msdyncrm_customerjourneyworkflowlink

Many-To-One Relationship: [msdyncrm_customerjourneyworkflowlink team_msdyncrm_customerjourneyworkflowlink](msdyncrm_customerjourneyworkflowlink.md#BKMK_team_msdyncrm_customerjourneyworkflowlink)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneyworkflowlink`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_customerjourneyworkflowlink`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_defaultmarketingsetting"></a> team_msdyncrm_defaultmarketingsetting

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting team_msdyncrm_defaultmarketingsetting](msdyncrm_defaultmarketingsetting.md#BKMK_team_msdyncrm_defaultmarketingsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_defaultmarketingsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_deprecatedcustomtileactivity"></a> team_msdyncrm_deprecatedcustomtileactivity

Many-To-One Relationship: [msdyncrm_deprecatedcustomtileactivity team_msdyncrm_deprecatedcustomtileactivity](msdyncrm_deprecatedcustomtileactivity.md#BKMK_team_msdyncrm_deprecatedcustomtileactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedcustomtileactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_deprecatedcustomtileactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_deprecatedeventactivity"></a> team_msdyncrm_deprecatedeventactivity

Many-To-One Relationship: [msdyncrm_deprecatedeventactivity team_msdyncrm_deprecatedeventactivity](msdyncrm_deprecatedeventactivity.md#BKMK_team_msdyncrm_deprecatedeventactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedeventactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_deprecatedeventactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_deprecatedformsprosurveyactivity"></a> team_msdyncrm_deprecatedformsprosurveyactivity

Many-To-One Relationship: [msdyncrm_deprecatedformsprosurveyactivity team_msdyncrm_deprecatedformsprosurveyactivity](msdyncrm_deprecatedformsprosurveyactivity.md#BKMK_team_msdyncrm_deprecatedformsprosurveyactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedformsprosurveyactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_deprecatedformsprosurveyactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_deprecatedpageactivity"></a> team_msdyncrm_deprecatedpageactivity

Many-To-One Relationship: [msdyncrm_deprecatedpageactivity team_msdyncrm_deprecatedpageactivity](msdyncrm_deprecatedpageactivity.md#BKMK_team_msdyncrm_deprecatedpageactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedpageactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_deprecatedpageactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_designerfeatureavailability"></a> team_msdyncrm_designerfeatureavailability

Many-To-One Relationship: [msdyncrm_designerfeatureavailability team_msdyncrm_designerfeatureavailability](msdyncrm_designerfeatureavailability.md#BKMK_team_msdyncrm_designerfeatureavailability)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_designerfeatureavailability`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_designerfeatureavailability`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_dividerstyle"></a> team_msdyncrm_dividerstyle

Many-To-One Relationship: [msdyncrm_dividerstyle team_msdyncrm_dividerstyle](msdyncrm_dividerstyle.md#BKMK_team_msdyncrm_dividerstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_dividerstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_dividerstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_emailkeypoint"></a> team_msdyncrm_emailkeypoint

Many-To-One Relationship: [msdyncrm_emailkeypoint team_msdyncrm_emailkeypoint](msdyncrm_emailkeypoint.md#BKMK_team_msdyncrm_emailkeypoint)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_emailkeypoint`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_emailkeypoint`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_featureconfiguration"></a> team_msdyncrm_featureconfiguration

Many-To-One Relationship: [msdyncrm_featureconfiguration team_msdyncrm_featureconfiguration](msdyncrm_featureconfiguration.md#BKMK_team_msdyncrm_featureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_featureconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_featureconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_file"></a> team_msdyncrm_file

Many-To-One Relationship: [msdyncrm_file team_msdyncrm_file](msdyncrm_file.md#BKMK_team_msdyncrm_file)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_file`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_file`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_formpage"></a> team_msdyncrm_formpage

Many-To-One Relationship: [msdyncrm_formpage team_msdyncrm_formpage](msdyncrm_formpage.md#BKMK_team_msdyncrm_formpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_formpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_formpagetemplate"></a> team_msdyncrm_formpagetemplate

Many-To-One Relationship: [msdyncrm_formpagetemplate team_msdyncrm_formpagetemplate](msdyncrm_formpagetemplate.md#BKMK_team_msdyncrm_formpagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpagetemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_formpagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_generalstyles"></a> team_msdyncrm_generalstyles

Many-To-One Relationship: [msdyncrm_generalstyles team_msdyncrm_generalstyles](msdyncrm_generalstyles.md#BKMK_team_msdyncrm_generalstyles)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_generalstyles`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_generalstyles`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_geopin"></a> team_msdyncrm_geopin

Many-To-One Relationship: [msdyncrm_geopin team_msdyncrm_geopin](msdyncrm_geopin.md#BKMK_team_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_geopin`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_geopin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_gpt3log"></a> team_msdyncrm_gpt3log

Many-To-One Relationship: [msdyncrm_gpt3log team_msdyncrm_gpt3log](msdyncrm_gpt3log.md#BKMK_team_msdyncrm_gpt3log)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_gpt3log`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_gpt3log`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_gwennolfeatureconfiguration"></a> team_msdyncrm_gwennolfeatureconfiguration

Many-To-One Relationship: [msdyncrm_gwennolfeatureconfiguration team_msdyncrm_gwennolfeatureconfiguration](msdyncrm_gwennolfeatureconfiguration.md#BKMK_team_msdyncrm_gwennolfeatureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_gwennolfeatureconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_gwennolfeatureconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_gwennolspamscoreactivity"></a> team_msdyncrm_gwennolspamscoreactivity

Many-To-One Relationship: [msdyncrm_gwennolspamscoreactivity team_msdyncrm_gwennolspamscoreactivity](msdyncrm_gwennolspamscoreactivity.md#BKMK_team_msdyncrm_gwennolspamscoreactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_gwennolspamscoreactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_gwennolspamscoreactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_gwennolspamscorerequest"></a> team_msdyncrm_gwennolspamscorerequest

Many-To-One Relationship: [msdyncrm_gwennolspamscorerequest team_msdyncrm_gwennolspamscorerequest](msdyncrm_gwennolspamscorerequest.md#BKMK_team_msdyncrm_gwennolspamscorerequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_gwennolspamscorerequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_gwennolspamscorerequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_imagestyle"></a> team_msdyncrm_imagestyle

Many-To-One Relationship: [msdyncrm_imagestyle team_msdyncrm_imagestyle](msdyncrm_imagestyle.md#BKMK_team_msdyncrm_imagestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_imagestyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_imagestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_keyword"></a> team_msdyncrm_keyword

Many-To-One Relationship: [msdyncrm_keyword team_msdyncrm_keyword](msdyncrm_keyword.md#BKMK_team_msdyncrm_keyword)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_keyword`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_keyword`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_launchworkflowactivity"></a> team_msdyncrm_launchworkflowactivity

Many-To-One Relationship: [msdyncrm_launchworkflowactivity team_msdyncrm_launchworkflowactivity](msdyncrm_launchworkflowactivity.md#BKMK_team_msdyncrm_launchworkflowactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_launchworkflowactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_launchworkflowactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_layoutstyle"></a> team_msdyncrm_layoutstyle

Many-To-One Relationship: [msdyncrm_layoutstyle team_msdyncrm_layoutstyle](msdyncrm_layoutstyle.md#BKMK_team_msdyncrm_layoutstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_layoutstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_layoutstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_leadscore"></a> team_msdyncrm_leadscore

Many-To-One Relationship: [msdyncrm_leadscore team_msdyncrm_leadscore](msdyncrm_leadscore.md#BKMK_team_msdyncrm_leadscore)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadscore`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_leadscore`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_leadscore_v2"></a> team_msdyncrm_leadscore_v2

Many-To-One Relationship: [msdyncrm_leadscore_v2 team_msdyncrm_leadscore_v2](msdyncrm_leadscore_v2.md#BKMK_team_msdyncrm_leadscore_v2)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadscore_v2`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_leadscore_v2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_leadscoremodel"></a> team_msdyncrm_leadscoremodel

Many-To-One Relationship: [msdyncrm_leadscoremodel team_msdyncrm_leadscoremodel](msdyncrm_leadscoremodel.md#BKMK_team_msdyncrm_leadscoremodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadscoremodel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_leadscoremodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinaccount"></a> team_msdyncrm_linkedinaccount

Many-To-One Relationship: [msdyncrm_linkedinaccount team_msdyncrm_linkedinaccount](msdyncrm_linkedinaccount.md#BKMK_team_msdyncrm_linkedinaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinactivity"></a> team_msdyncrm_linkedinactivity

Many-To-One Relationship: [msdyncrm_linkedinactivity team_msdyncrm_linkedinactivity](msdyncrm_linkedinactivity.md#BKMK_team_msdyncrm_linkedinactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinaudience"></a> team_msdyncrm_linkedinaudience

Many-To-One Relationship: [msdyncrm_linkedinaudience team_msdyncrm_linkedinaudience](msdyncrm_linkedinaudience.md#BKMK_team_msdyncrm_linkedinaudience)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinaudience`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinaudience`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedincampaign"></a> team_msdyncrm_linkedincampaign

Many-To-One Relationship: [msdyncrm_linkedincampaign team_msdyncrm_linkedincampaign](msdyncrm_linkedincampaign.md#BKMK_team_msdyncrm_linkedincampaign)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedincampaign`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedincampaign`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedincampaignactivity"></a> team_msdyncrm_linkedincampaignactivity

Many-To-One Relationship: [msdyncrm_linkedincampaignactivity team_msdyncrm_linkedincampaignactivity](msdyncrm_linkedincampaignactivity.md#BKMK_team_msdyncrm_linkedincampaignactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedincampaignactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedincampaignactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinconfiguration"></a> team_msdyncrm_linkedinconfiguration

Many-To-One Relationship: [msdyncrm_linkedinconfiguration team_msdyncrm_linkedinconfiguration](msdyncrm_linkedinconfiguration.md#BKMK_team_msdyncrm_linkedinconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinfieldmapping"></a> team_msdyncrm_linkedinfieldmapping

Many-To-One Relationship: [msdyncrm_linkedinfieldmapping team_msdyncrm_linkedinfieldmapping](msdyncrm_linkedinfieldmapping.md#BKMK_team_msdyncrm_linkedinfieldmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinfieldmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinform"></a> team_msdyncrm_linkedinform

Many-To-One Relationship: [msdyncrm_linkedinform team_msdyncrm_linkedinform](msdyncrm_linkedinform.md#BKMK_team_msdyncrm_linkedinform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinform`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinformanswer"></a> team_msdyncrm_linkedinformanswer

Many-To-One Relationship: [msdyncrm_linkedinformanswer team_msdyncrm_linkedinformanswer](msdyncrm_linkedinformanswer.md#BKMK_team_msdyncrm_linkedinformanswer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformanswer`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinformanswer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinformquestion"></a> team_msdyncrm_linkedinformquestion

Many-To-One Relationship: [msdyncrm_linkedinformquestion team_msdyncrm_linkedinformquestion](msdyncrm_linkedinformquestion.md#BKMK_team_msdyncrm_linkedinformquestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformquestion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinformquestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinformsubmission"></a> team_msdyncrm_linkedinformsubmission

Many-To-One Relationship: [msdyncrm_linkedinformsubmission team_msdyncrm_linkedinformsubmission](msdyncrm_linkedinformsubmission.md#BKMK_team_msdyncrm_linkedinformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformsubmission`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinformsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinleadmatchingstrategy"></a> team_msdyncrm_linkedinleadmatchingstrategy

Many-To-One Relationship: [msdyncrm_linkedinleadmatchingstrategy team_msdyncrm_linkedinleadmatchingstrategy](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_team_msdyncrm_linkedinleadmatchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinleadmatchingstrategy`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_linkedinuserprofile"></a> team_msdyncrm_linkedinuserprofile

Many-To-One Relationship: [msdyncrm_linkedinuserprofile team_msdyncrm_linkedinuserprofile](msdyncrm_linkedinuserprofile.md#BKMK_team_msdyncrm_linkedinuserprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinuserprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_linkedinuserprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_listform"></a> team_msdyncrm_listform

Many-To-One Relationship: [msdyncrm_listform team_msdyncrm_listform](msdyncrm_listform.md#BKMK_team_msdyncrm_listform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_listform`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_listform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_liveentitydependency"></a> team_msdyncrm_liveentitydependency

Many-To-One Relationship: [msdyncrm_liveentitydependency team_msdyncrm_liveentitydependency](msdyncrm_liveentitydependency.md#BKMK_team_msdyncrm_liveentitydependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_liveentitydependency`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_liveentitydependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingdataimport"></a> team_msdyncrm_marketingdataimport

Many-To-One Relationship: [msdyncrm_marketingdataimport team_msdyncrm_marketingdataimport](msdyncrm_marketingdataimport.md#BKMK_team_msdyncrm_marketingdataimport)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingdataimport`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingdataimport`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingdynamiccontentmetadata"></a> team_msdyncrm_marketingdynamiccontentmetadata

Many-To-One Relationship: [msdyncrm_marketingdynamiccontentmetadata team_msdyncrm_marketingdynamiccontentmetadata](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_team_msdyncrm_marketingdynamiccontentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingdynamiccontentmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingemail"></a> team_msdyncrm_marketingemail

Many-To-One Relationship: [msdyncrm_marketingemail team_msdyncrm_marketingemail](msdyncrm_marketingemail.md#BKMK_team_msdyncrm_marketingemail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingemail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingemailactivity"></a> team_msdyncrm_marketingemailactivity

Many-To-One Relationship: [msdyncrm_marketingemailactivity team_msdyncrm_marketingemailactivity](msdyncrm_marketingemailactivity.md#BKMK_team_msdyncrm_marketingemailactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingemailactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingemaildynamiccontentmetadata"></a> team_msdyncrm_marketingemaildynamiccontentmetadata

Many-To-One Relationship: [msdyncrm_marketingemaildynamiccontentmetadata team_msdyncrm_marketingemaildynamiccontentmetadata](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_team_msdyncrm_marketingemaildynamiccontentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingemaildynamiccontentmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingemailtemplate"></a> team_msdyncrm_marketingemailtemplate

Many-To-One Relationship: [msdyncrm_marketingemailtemplate team_msdyncrm_marketingemailtemplate](msdyncrm_marketingemailtemplate.md#BKMK_team_msdyncrm_marketingemailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingemailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingemailtest"></a> team_msdyncrm_marketingemailtest

Many-To-One Relationship: [msdyncrm_marketingemailtest team_msdyncrm_marketingemailtest](msdyncrm_marketingemailtest.md#BKMK_team_msdyncrm_marketingemailtest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingemailtest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingemailtestattribute"></a> team_msdyncrm_marketingemailtestattribute

Many-To-One Relationship: [msdyncrm_marketingemailtestattribute team_msdyncrm_marketingemailtestattribute](msdyncrm_marketingemailtestattribute.md#BKMK_team_msdyncrm_marketingemailtestattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtestattribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingemailtestattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingemailtestsend"></a> team_msdyncrm_marketingemailtestsend

Many-To-One Relationship: [msdyncrm_marketingemailtestsend team_msdyncrm_marketingemailtestsend](msdyncrm_marketingemailtestsend.md#BKMK_team_msdyncrm_marketingemailtestsend)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtestsend`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingemailtestsend`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingfieldsubmission"></a> team_msdyncrm_marketingfieldsubmission

Many-To-One Relationship: [msdyncrm_marketingfieldsubmission team_msdyncrm_marketingfieldsubmission](msdyncrm_marketingfieldsubmission.md#BKMK_team_msdyncrm_marketingfieldsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingfieldsubmission`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingfieldsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingform"></a> team_msdyncrm_marketingform

Many-To-One Relationship: [msdyncrm_marketingform team_msdyncrm_marketingform](msdyncrm_marketingform.md#BKMK_team_msdyncrm_marketingform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingform`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingformactivity"></a> team_msdyncrm_marketingformactivity

Many-To-One Relationship: [msdyncrm_marketingformactivity team_msdyncrm_marketingformactivity](msdyncrm_marketingformactivity.md#BKMK_team_msdyncrm_marketingformactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingformactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingformfield"></a> team_msdyncrm_marketingformfield

Many-To-One Relationship: [msdyncrm_marketingformfield team_msdyncrm_marketingformfield](msdyncrm_marketingformfield.md#BKMK_team_msdyncrm_marketingformfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformfield`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingformfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingformsubmission"></a> team_msdyncrm_marketingformsubmission

Many-To-One Relationship: [msdyncrm_marketingformsubmission team_msdyncrm_marketingformsubmission](msdyncrm_marketingformsubmission.md#BKMK_team_msdyncrm_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformsubmission`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingformsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingformtemplate"></a> team_msdyncrm_marketingformtemplate

Many-To-One Relationship: [msdyncrm_marketingformtemplate team_msdyncrm_marketingformtemplate](msdyncrm_marketingformtemplate.md#BKMK_team_msdyncrm_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingformtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingformwhitelistrule"></a> team_msdyncrm_marketingformwhitelistrule

Many-To-One Relationship: [msdyncrm_marketingformwhitelistrule team_msdyncrm_marketingformwhitelistrule](msdyncrm_marketingformwhitelistrule.md#BKMK_team_msdyncrm_marketingformwhitelistrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformwhitelistrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingformwhitelistrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingpage"></a> team_msdyncrm_marketingpage

Many-To-One Relationship: [msdyncrm_marketingpage team_msdyncrm_marketingpage](msdyncrm_marketingpage.md#BKMK_team_msdyncrm_marketingpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingpage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_marketingpagetemplate"></a> team_msdyncrm_marketingpagetemplate

Many-To-One Relationship: [msdyncrm_marketingpagetemplate team_msdyncrm_marketingpagetemplate](msdyncrm_marketingpagetemplate.md#BKMK_team_msdyncrm_marketingpagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingpagetemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_marketingpagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_matchingstrategyattribute"></a> team_msdyncrm_matchingstrategyattribute

Many-To-One Relationship: [msdyncrm_matchingstrategyattribute team_msdyncrm_matchingstrategyattribute](msdyncrm_matchingstrategyattribute.md#BKMK_team_msdyncrm_matchingstrategyattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_matchingstrategyattribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_matchingstrategyattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_migration"></a> team_msdyncrm_migration

Many-To-One Relationship: [msdyncrm_migration team_msdyncrm_migration](msdyncrm_migration.md#BKMK_team_msdyncrm_migration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_migration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_migration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_mktactivity"></a> team_msdyncrm_mktactivity

Many-To-One Relationship: [msdyncrm_mktactivity team_msdyncrm_mktactivity](msdyncrm_mktactivity.md#BKMK_team_msdyncrm_mktactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_mktactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_mktactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_networkpage"></a> team_msdyncrm_networkpage

Many-To-One Relationship: [msdyncrm_networkpage team_msdyncrm_networkpage](msdyncrm_networkpage.md#BKMK_team_msdyncrm_networkpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_networkpage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_networkpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_personalizedpage"></a> team_msdyncrm_personalizedpage

Many-To-One Relationship: [msdyncrm_personalizedpage team_msdyncrm_personalizedpage](msdyncrm_personalizedpage.md#BKMK_team_msdyncrm_personalizedpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_personalizedpage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_personalizedpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_personalizedpagefield"></a> team_msdyncrm_personalizedpagefield

Many-To-One Relationship: [msdyncrm_personalizedpagefield team_msdyncrm_personalizedpagefield](msdyncrm_personalizedpagefield.md#BKMK_team_msdyncrm_personalizedpagefield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_personalizedpagefield`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_personalizedpagefield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_phonecallactivity"></a> team_msdyncrm_phonecallactivity

Many-To-One Relationship: [msdyncrm_phonecallactivity team_msdyncrm_phonecallactivity](msdyncrm_phonecallactivity.md#BKMK_team_msdyncrm_phonecallactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_phonecallactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_phonecallactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_phonecallactivitymarketingtemplate"></a> team_msdyncrm_phonecallactivitymarketingtemplate

Many-To-One Relationship: [msdyncrm_phonecallactivitymarketingtemplate team_msdyncrm_phonecallactivitymarketingtemplate](msdyncrm_phonecallactivitymarketingtemplate.md#BKMK_team_msdyncrm_phonecallactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_phonecallactivitymarketingtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_phonecallactivitymarketingtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_postingishts"></a> team_msdyncrm_postingishts

Many-To-One Relationship: [msdyncrm_postingishts team_msdyncrm_postingishts](msdyncrm_postingishts.md#BKMK_team_msdyncrm_postingishts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_postingishts`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_postingishts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_qrcodestyle"></a> team_msdyncrm_qrcodestyle

Many-To-One Relationship: [msdyncrm_qrcodestyle team_msdyncrm_qrcodestyle](msdyncrm_qrcodestyle.md#BKMK_team_msdyncrm_qrcodestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_qrcodestyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_qrcodestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_quicksendemail"></a> team_msdyncrm_quicksendemail

Many-To-One Relationship: [msdyncrm_quicksendemail team_msdyncrm_quicksendemail](msdyncrm_quicksendemail.md#BKMK_team_msdyncrm_quicksendemail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_quicksendemail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_quicksendemail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_reaction"></a> team_msdyncrm_reaction

Many-To-One Relationship: [msdyncrm_reaction team_msdyncrm_reaction](msdyncrm_reaction.md#BKMK_team_msdyncrm_reaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_reaction`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_reaction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_recordupdateactivity"></a> team_msdyncrm_recordupdateactivity

Many-To-One Relationship: [msdyncrm_recordupdateactivity team_msdyncrm_recordupdateactivity](msdyncrm_recordupdateactivity.md#BKMK_team_msdyncrm_recordupdateactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_recordupdateactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_recordupdateactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_redirecturl"></a> team_msdyncrm_redirecturl

Many-To-One Relationship: [msdyncrm_redirecturl team_msdyncrm_redirecturl](msdyncrm_redirecturl.md#BKMK_team_msdyncrm_redirecturl)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_redirecturl`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_redirecturl`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_segment"></a> team_msdyncrm_segment

Many-To-One Relationship: [msdyncrm_segment team_msdyncrm_segment](msdyncrm_segment.md#BKMK_team_msdyncrm_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_segment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_segment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_segmentactivity"></a> team_msdyncrm_segmentactivity

Many-To-One Relationship: [msdyncrm_segmentactivity team_msdyncrm_segmentactivity](msdyncrm_segmentactivity.md#BKMK_team_msdyncrm_segmentactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_segmentactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_segmentactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_segmenttemplate"></a> team_msdyncrm_segmenttemplate

Many-To-One Relationship: [msdyncrm_segmenttemplate team_msdyncrm_segmenttemplate](msdyncrm_segmenttemplate.md#BKMK_team_msdyncrm_segmenttemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_segmenttemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_segmenttemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_socialpost"></a> team_msdyncrm_socialpost

Many-To-One Relationship: [msdyncrm_socialpost team_msdyncrm_socialpost](msdyncrm_socialpost.md#BKMK_team_msdyncrm_socialpost)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_socialpost`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_socialpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_socialpostingconfiguration"></a> team_msdyncrm_socialpostingconfiguration

Many-To-One Relationship: [msdyncrm_socialpostingconfiguration team_msdyncrm_socialpostingconfiguration](msdyncrm_socialpostingconfiguration.md#BKMK_team_msdyncrm_socialpostingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_socialpostingconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_socialpostingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_socialpostingconsent"></a> team_msdyncrm_socialpostingconsent

Many-To-One Relationship: [msdyncrm_socialpostingconsent team_msdyncrm_socialpostingconsent](msdyncrm_socialpostingconsent.md#BKMK_team_msdyncrm_socialpostingconsent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_socialpostingconsent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_socialpostingconsent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_sourceactivity"></a> team_msdyncrm_sourceactivity

Many-To-One Relationship: [msdyncrm_sourceactivity team_msdyncrm_sourceactivity](msdyncrm_sourceactivity.md#BKMK_team_msdyncrm_sourceactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_sourceactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_sourceactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_splitteractivity"></a> team_msdyncrm_splitteractivity

Many-To-One Relationship: [msdyncrm_splitteractivity team_msdyncrm_splitteractivity](msdyncrm_splitteractivity.md#BKMK_team_msdyncrm_splitteractivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_splitteractivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_splitteractivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_tag"></a> team_msdyncrm_tag

Many-To-One Relationship: [msdyncrm_tag team_msdyncrm_tag](msdyncrm_tag.md#BKMK_team_msdyncrm_tag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_tag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_tag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_taskactivity"></a> team_msdyncrm_taskactivity

Many-To-One Relationship: [msdyncrm_taskactivity team_msdyncrm_taskactivity](msdyncrm_taskactivity.md#BKMK_team_msdyncrm_taskactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_taskactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_taskactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_taskactivitymarketingtemplate"></a> team_msdyncrm_taskactivitymarketingtemplate

Many-To-One Relationship: [msdyncrm_taskactivitymarketingtemplate team_msdyncrm_taskactivitymarketingtemplate](msdyncrm_taskactivitymarketingtemplate.md#BKMK_team_msdyncrm_taskactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_taskactivitymarketingtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_taskactivitymarketingtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_textstyle"></a> team_msdyncrm_textstyle

Many-To-One Relationship: [msdyncrm_textstyle team_msdyncrm_textstyle](msdyncrm_textstyle.md#BKMK_team_msdyncrm_textstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_textstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_textstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_triggeractivity"></a> team_msdyncrm_triggeractivity

Many-To-One Relationship: [msdyncrm_triggeractivity team_msdyncrm_triggeractivity](msdyncrm_triggeractivity.md#BKMK_team_msdyncrm_triggeractivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_triggeractivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_triggeractivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_uicconfig"></a> team_msdyncrm_uicconfig

Many-To-One Relationship: [msdyncrm_uicconfig team_msdyncrm_uicconfig](msdyncrm_uicconfig.md#BKMK_team_msdyncrm_uicconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_uicconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_uicconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_usergeoregion"></a> team_msdyncrm_usergeoregion

Many-To-One Relationship: [msdyncrm_usergeoregion team_msdyncrm_usergeoregion](msdyncrm_usergeoregion.md#BKMK_team_msdyncrm_usergeoregion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_usergeoregion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_usergeoregion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_usersetting"></a> team_msdyncrm_usersetting

Many-To-One Relationship: [msdyncrm_usersetting team_msdyncrm_usersetting](msdyncrm_usersetting.md#BKMK_team_msdyncrm_usersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_usersetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_usersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_video"></a> team_msdyncrm_video

Many-To-One Relationship: [msdyncrm_video team_msdyncrm_video](msdyncrm_video.md#BKMK_team_msdyncrm_video)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_video`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_video`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_videostyle"></a> team_msdyncrm_videostyle

Many-To-One Relationship: [msdyncrm_videostyle team_msdyncrm_videostyle](msdyncrm_videostyle.md#BKMK_team_msdyncrm_videostyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_videostyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_videostyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyncrm_website"></a> team_msdyncrm_website

Many-To-One Relationship: [msdyncrm_website team_msdyncrm_website](msdyncrm_website.md#BKMK_team_msdyncrm_website)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_website`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_website`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_aimodelversion"></a> team_msdynmkt_aimodelversion

Many-To-One Relationship: [msdynmkt_aimodelversion team_msdynmkt_aimodelversion](msdynmkt_aimodelversion.md#BKMK_team_msdynmkt_aimodelversion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_aimodelversion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_aimodelversion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_apsconfig"></a> team_msdynmkt_apsconfig

Many-To-One Relationship: [msdynmkt_apsconfig team_msdynmkt_apsconfig](msdynmkt_apsconfig.md#BKMK_team_msdynmkt_apsconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_apsconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_apsconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_brandprofile"></a> team_msdynmkt_brandprofile

Many-To-One Relationship: [msdynmkt_brandprofile team_msdynmkt_brandprofile](msdynmkt_brandprofile.md#BKMK_team_msdynmkt_brandprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_brandprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_brandprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_brandsender"></a> team_msdynmkt_brandsender

Many-To-One Relationship: [msdynmkt_brandsender team_msdynmkt_brandsender](msdynmkt_brandsender.md#BKMK_team_msdynmkt_brandsender)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_brandsender`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_brandsender`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_brandtheme"></a> team_msdynmkt_brandtheme

Many-To-One Relationship: [msdynmkt_brandtheme team_msdynmkt_brandtheme](msdynmkt_brandtheme.md#BKMK_team_msdynmkt_brandtheme)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_brandtheme`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_brandtheme`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_buttonstyle"></a> team_msdynmkt_buttonstyle

Many-To-One Relationship: [msdynmkt_buttonstyle team_msdynmkt_buttonstyle](msdynmkt_buttonstyle.md#BKMK_team_msdynmkt_buttonstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_buttonstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_buttonstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_byoacschannelinstance"></a> team_msdynmkt_byoacschannelinstance

Many-To-One Relationship: [msdynmkt_byoacschannelinstance team_msdynmkt_byoacschannelinstance](msdynmkt_byoacschannelinstance.md#BKMK_team_msdynmkt_byoacschannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_byoacschannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_byoacschannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_byoacschannelinstanceaccount"></a> team_msdynmkt_byoacschannelinstanceaccount

Many-To-One Relationship: [msdynmkt_byoacschannelinstanceaccount team_msdynmkt_byoacschannelinstanceaccount](msdynmkt_byoacschannelinstanceaccount.md#BKMK_team_msdynmkt_byoacschannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_byoacschannelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_byoacschannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_captcha"></a> team_msdynmkt_captcha

Many-To-One Relationship: [msdynmkt_captcha team_msdynmkt_captcha](msdynmkt_captcha.md#BKMK_team_msdynmkt_captcha)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_captcha`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_captcha`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_catalogeventstatusconfiguration"></a> team_msdynmkt_catalogeventstatusconfiguration

Many-To-One Relationship: [msdynmkt_catalogeventstatusconfiguration team_msdynmkt_catalogeventstatusconfiguration](msdynmkt_catalogeventstatusconfiguration.md#BKMK_team_msdynmkt_catalogeventstatusconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_catalogeventstatusconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_catalogeventstatusconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_compliancesettings3"></a> team_msdynmkt_compliancesettings3

Many-To-One Relationship: [msdynmkt_compliancesettings3 team_msdynmkt_compliancesettings3](msdynmkt_compliancesettings3.md#BKMK_team_msdynmkt_compliancesettings3)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_compliancesettings3`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_compliancesettings3`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_compliancesettings4"></a> team_msdynmkt_compliancesettings4

Many-To-One Relationship: [msdynmkt_compliancesettings4 team_msdynmkt_compliancesettings4](msdynmkt_compliancesettings4.md#BKMK_team_msdynmkt_compliancesettings4)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_compliancesettings4`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_compliancesettings4`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_configuration"></a> team_msdynmkt_configuration

Many-To-One Relationship: [msdynmkt_configuration team_msdynmkt_configuration](msdynmkt_configuration.md#BKMK_team_msdynmkt_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_configuration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_configuration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_consentprovider"></a> team_msdynmkt_consentprovider

Many-To-One Relationship: [msdynmkt_consentprovider team_msdynmkt_consentprovider](msdynmkt_consentprovider.md#BKMK_team_msdynmkt_consentprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_consentprovider`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_consentprovider`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_consentproviderdefaultconfiguration"></a> team_msdynmkt_consentproviderdefaultconfiguration

Many-To-One Relationship: [msdynmkt_consentproviderdefaultconfiguration team_msdynmkt_consentproviderdefaultconfiguration](msdynmkt_consentproviderdefaultconfiguration.md#BKMK_team_msdynmkt_consentproviderdefaultconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_consentproviderdefaultconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_consentproviderdefaultconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_consentproviderdefaultpurpose"></a> team_msdynmkt_consentproviderdefaultpurpose

Many-To-One Relationship: [msdynmkt_consentproviderdefaultpurpose team_msdynmkt_consentproviderdefaultpurpose](msdynmkt_consentproviderdefaultpurpose.md#BKMK_team_msdynmkt_consentproviderdefaultpurpose)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_consentproviderdefaultpurpose`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_consentproviderdefaultpurpose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_consentsystemconfiguration"></a> team_msdynmkt_consentsystemconfiguration

Many-To-One Relationship: [msdynmkt_consentsystemconfiguration team_msdynmkt_consentsystemconfiguration](msdynmkt_consentsystemconfiguration.md#BKMK_team_msdynmkt_consentsystemconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_consentsystemconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_consentsystemconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_contactpointconsent"></a> team_msdynmkt_contactpointconsent

Many-To-One Relationship: [msdynmkt_contactpointconsent team_msdynmkt_contactpointconsent](msdynmkt_contactpointconsent.md#BKMK_team_msdynmkt_contactpointconsent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_contactpointconsent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_contactpointconsent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_contactpointconsent3"></a> team_msdynmkt_contactpointconsent3

Many-To-One Relationship: [msdynmkt_contactpointconsent3 team_msdynmkt_contactpointconsent3](msdynmkt_contactpointconsent3.md#BKMK_team_msdynmkt_contactpointconsent3)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_contactpointconsent3`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_contactpointconsent3`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_contactpointconsent4"></a> team_msdynmkt_contactpointconsent4

Many-To-One Relationship: [msdynmkt_contactpointconsent4 team_msdynmkt_contactpointconsent4](msdynmkt_contactpointconsent4.md#BKMK_team_msdynmkt_contactpointconsent4)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_contactpointconsent4`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_contactpointconsent4`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_conversioneventdefinition"></a> team_msdynmkt_conversioneventdefinition

Many-To-One Relationship: [msdynmkt_conversioneventdefinition team_msdynmkt_conversioneventdefinition](msdynmkt_conversioneventdefinition.md#BKMK_team_msdynmkt_conversioneventdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_conversioneventdefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_conversioneventdefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_createdentitylink"></a> team_msdynmkt_createdentitylink

Many-To-One Relationship: [msdynmkt_createdentitylink team_msdynmkt_createdentitylink](msdynmkt_createdentitylink.md#BKMK_team_msdynmkt_createdentitylink)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_createdentitylink`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_createdentitylink`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_customchannelmessage"></a> team_msdynmkt_customchannelmessage

Many-To-One Relationship: [msdynmkt_customchannelmessage team_msdynmkt_customchannelmessage](msdynmkt_customchannelmessage.md#BKMK_team_msdynmkt_customchannelmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_customchannelmessage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_customchannelmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_domain"></a> team_msdynmkt_domain

Many-To-One Relationship: [msdynmkt_domain team_msdynmkt_domain](msdynmkt_domain.md#BKMK_team_msdynmkt_domain)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_domain`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_domain`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_email"></a> team_msdynmkt_email

Many-To-One Relationship: [msdynmkt_email team_msdynmkt_email](msdynmkt_email.md#BKMK_team_msdynmkt_email)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_email`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_email`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_emailtemplate"></a> team_msdynmkt_emailtemplate

Many-To-One Relationship: [msdynmkt_emailtemplate team_msdynmkt_emailtemplate](msdynmkt_emailtemplate.md#BKMK_team_msdynmkt_emailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_emailtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_emailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_entitygradedistribution"></a> team_msdynmkt_entitygradedistribution

Many-To-One Relationship: [msdynmkt_entitygradedistribution team_msdynmkt_entitygradedistribution](msdynmkt_entitygradedistribution.md#BKMK_team_msdynmkt_entitygradedistribution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_entitygradedistribution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_entitygradedistribution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_entityscoredistribution"></a> team_msdynmkt_entityscoredistribution

Many-To-One Relationship: [msdynmkt_entityscoredistribution team_msdynmkt_entityscoredistribution](msdynmkt_entityscoredistribution.md#BKMK_team_msdynmkt_entityscoredistribution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_entityscoredistribution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_entityscoredistribution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_entityscoringmodel"></a> team_msdynmkt_entityscoringmodel

Many-To-One Relationship: [msdynmkt_entityscoringmodel team_msdynmkt_entityscoringmodel](msdynmkt_entityscoringmodel.md#BKMK_team_msdynmkt_entityscoringmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_entityscoringmodel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_entityscoringmodel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_eventmetadata"></a> team_msdynmkt_eventmetadata

Many-To-One Relationship: [msdynmkt_eventmetadata team_msdynmkt_eventmetadata](msdynmkt_eventmetadata.md#BKMK_team_msdynmkt_eventmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventmetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_eventmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_eventparametermetadata"></a> team_msdynmkt_eventparametermetadata

Many-To-One Relationship: [msdynmkt_eventparametermetadata team_msdynmkt_eventparametermetadata](msdynmkt_eventparametermetadata.md#BKMK_team_msdynmkt_eventparametermetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventparametermetadata`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_eventparametermetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_experiment"></a> team_msdynmkt_experiment

Many-To-One Relationship: [msdynmkt_experiment team_msdynmkt_experiment](msdynmkt_experiment.md#BKMK_team_msdynmkt_experiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_experiment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_experiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_experimentv2"></a> team_msdynmkt_experimentv2

Many-To-One Relationship: [msdynmkt_experimentv2 team_msdynmkt_experimentv2](msdynmkt_experimentv2.md#BKMK_team_msdynmkt_experimentv2)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_experimentv2`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_experimentv2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_featureconfiguration"></a> team_msdynmkt_featureconfiguration

Many-To-One Relationship: [msdynmkt_featureconfiguration team_msdynmkt_featureconfiguration](msdynmkt_featureconfiguration.md#BKMK_team_msdynmkt_featureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_featureconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_featureconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_fragment"></a> team_msdynmkt_fragment

Many-To-One Relationship: [msdynmkt_fragment team_msdynmkt_fragment](msdynmkt_fragment.md#BKMK_team_msdynmkt_fragment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_fragment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_fragment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_frequencycap"></a> team_msdynmkt_frequencycap

Many-To-One Relationship: [msdynmkt_frequencycap team_msdynmkt_frequencycap](msdynmkt_frequencycap.md#BKMK_team_msdynmkt_frequencycap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_frequencycap`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_frequencycap`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_gdprrequest"></a> team_msdynmkt_gdprrequest

Many-To-One Relationship: [msdynmkt_gdprrequest team_msdynmkt_gdprrequest](msdynmkt_gdprrequest.md#BKMK_team_msdynmkt_gdprrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_gdprrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_gdprrequest`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_imagestyle"></a> team_msdynmkt_imagestyle

Many-To-One Relationship: [msdynmkt_imagestyle team_msdynmkt_imagestyle](msdynmkt_imagestyle.md#BKMK_team_msdynmkt_imagestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_imagestyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_imagestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_infobipchannelinstance"></a> team_msdynmkt_infobipchannelinstance

Many-To-One Relationship: [msdynmkt_infobipchannelinstance team_msdynmkt_infobipchannelinstance](msdynmkt_infobipchannelinstance.md#BKMK_team_msdynmkt_infobipchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_infobipchannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_infobipchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_infobipchannelinstanceaccount"></a> team_msdynmkt_infobipchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_infobipchannelinstanceaccount team_msdynmkt_infobipchannelinstanceaccount](msdynmkt_infobipchannelinstanceaccount.md#BKMK_team_msdynmkt_infobipchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_infobipchannelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_infobipchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_journey"></a> team_msdynmkt_journey

Many-To-One Relationship: [msdynmkt_journey team_msdynmkt_journey](msdynmkt_journey.md#BKMK_team_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journey`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_journey`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_journeydependency"></a> team_msdynmkt_journeydependency

Many-To-One Relationship: [msdynmkt_journeydependency team_msdynmkt_journeydependency](msdynmkt_journeydependency.md#BKMK_team_msdynmkt_journeydependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeydependency`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_journeydependency`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_journeyevent"></a> team_msdynmkt_journeyevent

Many-To-One Relationship: [msdynmkt_journeyevent team_msdynmkt_journeyevent](msdynmkt_journeyevent.md#BKMK_team_msdynmkt_journeyevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyevent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_journeyevent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_journeyoptimizationcount"></a> team_msdynmkt_journeyoptimizationcount

Many-To-One Relationship: [msdynmkt_journeyoptimizationcount team_msdynmkt_journeyoptimizationcount](msdynmkt_journeyoptimizationcount.md#BKMK_team_msdynmkt_journeyoptimizationcount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyoptimizationcount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_journeyoptimizationcount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_journeyrunparameter"></a> team_msdynmkt_journeyrunparameter

Many-To-One Relationship: [msdynmkt_journeyrunparameter team_msdynmkt_journeyrunparameter](msdynmkt_journeyrunparameter.md#BKMK_team_msdynmkt_journeyrunparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyrunparameter`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_journeyrunparameter`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_journeysetting"></a> team_msdynmkt_journeysetting

Many-To-One Relationship: [msdynmkt_journeysetting team_msdynmkt_journeysetting](msdynmkt_journeysetting.md#BKMK_team_msdynmkt_journeysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeysetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_journeysetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_journeytemplate"></a> team_msdynmkt_journeytemplate

Many-To-One Relationship: [msdynmkt_journeytemplate team_msdynmkt_journeytemplate](msdynmkt_journeytemplate.md#BKMK_team_msdynmkt_journeytemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeytemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_journeytemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_journeyworkflowmapping"></a> team_msdynmkt_journeyworkflowmapping

Many-To-One Relationship: [msdynmkt_journeyworkflowmapping team_msdynmkt_journeyworkflowmapping](msdynmkt_journeyworkflowmapping.md#BKMK_team_msdynmkt_journeyworkflowmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyworkflowmapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_journeyworkflowmapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_keyword"></a> team_msdynmkt_keyword

Many-To-One Relationship: [msdynmkt_keyword team_msdynmkt_keyword](msdynmkt_keyword.md#BKMK_team_msdynmkt_keyword)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_keyword`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_keyword`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_leadqualificationmodel"></a> team_msdynmkt_leadqualificationmodel

Many-To-One Relationship: [msdynmkt_leadqualificationmodel team_msdynmkt_leadqualificationmodel](msdynmkt_leadqualificationmodel.md#BKMK_team_msdynmkt_leadqualificationmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_leadqualificationmodel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_leadqualificationmodel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_linkmobilitychannelinstance"></a> team_msdynmkt_linkmobilitychannelinstance

Many-To-One Relationship: [msdynmkt_linkmobilitychannelinstance team_msdynmkt_linkmobilitychannelinstance](msdynmkt_linkmobilitychannelinstance.md#BKMK_team_msdynmkt_linkmobilitychannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_linkmobilitychannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_linkmobilitychannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_linkmobilitychannelinstanceaccount"></a> team_msdynmkt_linkmobilitychannelinstanceaccount

Many-To-One Relationship: [msdynmkt_linkmobilitychannelinstanceaccount team_msdynmkt_linkmobilitychannelinstanceaccount](msdynmkt_linkmobilitychannelinstanceaccount.md#BKMK_team_msdynmkt_linkmobilitychannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_linkmobilitychannelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_linkmobilitychannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_marketingfieldsubmission"></a> team_msdynmkt_marketingfieldsubmission

Many-To-One Relationship: [msdynmkt_marketingfieldsubmission team_msdynmkt_marketingfieldsubmission](msdynmkt_marketingfieldsubmission.md#BKMK_team_msdynmkt_marketingfieldsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingfieldsubmission`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_marketingfieldsubmission`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_marketingform"></a> team_msdynmkt_marketingform

Many-To-One Relationship: [msdynmkt_marketingform team_msdynmkt_marketingform](msdynmkt_marketingform.md#BKMK_team_msdynmkt_marketingform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingform`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_marketingform`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_marketingformfield"></a> team_msdynmkt_marketingformfield

Many-To-One Relationship: [msdynmkt_marketingformfield team_msdynmkt_marketingformfield](msdynmkt_marketingformfield.md#BKMK_team_msdynmkt_marketingformfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformfield`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_marketingformfield`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_marketingformsubmission"></a> team_msdynmkt_marketingformsubmission

Many-To-One Relationship: [msdynmkt_marketingformsubmission team_msdynmkt_marketingformsubmission](msdynmkt_marketingformsubmission.md#BKMK_team_msdynmkt_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformsubmission`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_marketingformsubmission`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_marketingformtemplate"></a> team_msdynmkt_marketingformtemplate

Many-To-One Relationship: [msdynmkt_marketingformtemplate team_msdynmkt_marketingformtemplate](msdynmkt_marketingformtemplate.md#BKMK_team_msdynmkt_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_marketingformtemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_matchingstrategy"></a> team_msdynmkt_matchingstrategy

Many-To-One Relationship: [msdynmkt_matchingstrategy team_msdynmkt_matchingstrategy](msdynmkt_matchingstrategy.md#BKMK_team_msdynmkt_matchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_matchingstrategy`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_matchingstrategy`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_matchingstrategyattribute"></a> team_msdynmkt_matchingstrategyattribute

Many-To-One Relationship: [msdynmkt_matchingstrategyattribute team_msdynmkt_matchingstrategyattribute](msdynmkt_matchingstrategyattribute.md#BKMK_team_msdynmkt_matchingstrategyattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_matchingstrategyattribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_matchingstrategyattribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_metadataentityrelationship"></a> team_msdynmkt_metadataentityrelationship

Many-To-One Relationship: [msdynmkt_metadataentityrelationship team_msdynmkt_metadataentityrelationship](msdynmkt_metadataentityrelationship.md#BKMK_team_msdynmkt_metadataentityrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadataentityrelationship`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_metadataentityrelationship`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_metadataitem"></a> team_msdynmkt_metadataitem

Many-To-One Relationship: [msdynmkt_metadataitem team_msdynmkt_metadataitem](msdynmkt_metadataitem.md#BKMK_team_msdynmkt_metadataitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadataitem`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_metadataitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_metadatastorestate"></a> team_msdynmkt_metadatastorestate

Many-To-One Relationship: [msdynmkt_metadatastorestate team_msdynmkt_metadatastorestate](msdynmkt_metadatastorestate.md#BKMK_team_msdynmkt_metadatastorestate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadatastorestate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_metadatastorestate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_mobileapp"></a> team_msdynmkt_mobileapp

Many-To-One Relationship: [msdynmkt_mobileapp team_msdynmkt_mobileapp](msdynmkt_mobileapp.md#BKMK_team_msdynmkt_mobileapp)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mobileapp`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_mobileapp`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_mobileappchannelinstance"></a> team_msdynmkt_mobileappchannelinstance

Many-To-One Relationship: [msdynmkt_mobileappchannelinstance team_msdynmkt_mobileappchannelinstance](msdynmkt_mobileappchannelinstance.md#BKMK_team_msdynmkt_mobileappchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mobileappchannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_mobileappchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_mobiledevice"></a> team_msdynmkt_mobiledevice

Many-To-One Relationship: [msdynmkt_mobiledevice team_msdynmkt_mobiledevice](msdynmkt_mobiledevice.md#BKMK_team_msdynmkt_mobiledevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mobiledevice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_mobiledevice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_mocksmsproviderchannelinstance"></a> team_msdynmkt_mocksmsproviderchannelinstance

Many-To-One Relationship: [msdynmkt_mocksmsproviderchannelinstance team_msdynmkt_mocksmsproviderchannelinstance](msdynmkt_mocksmsproviderchannelinstance.md#BKMK_team_msdynmkt_mocksmsproviderchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mocksmsproviderchannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_mocksmsproviderchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> team_msdynmkt_mocksmsproviderchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_mocksmsproviderchannelinstanceaccount team_msdynmkt_mocksmsproviderchannelinstanceaccount](msdynmkt_mocksmsproviderchannelinstanceaccount.md#BKMK_team_msdynmkt_mocksmsproviderchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mocksmsproviderchannelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_mocksmsproviderchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_predefinedplaceholder"></a> team_msdynmkt_predefinedplaceholder

Many-To-One Relationship: [msdynmkt_predefinedplaceholder team_msdynmkt_predefinedplaceholder](msdynmkt_predefinedplaceholder.md#BKMK_team_msdynmkt_predefinedplaceholder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_predefinedplaceholder`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_predefinedplaceholder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_preferencecenter"></a> team_msdynmkt_preferencecenter

Many-To-One Relationship: [msdynmkt_preferencecenter team_msdynmkt_preferencecenter](msdynmkt_preferencecenter.md#BKMK_team_msdynmkt_preferencecenter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_preferencecenter`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_preferencecenter`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_purpose"></a> team_msdynmkt_purpose

Many-To-One Relationship: [msdynmkt_purpose team_msdynmkt_purpose](msdynmkt_purpose.md#BKMK_team_msdynmkt_purpose)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_purpose`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_purpose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_pushdeviceregistrationresult"></a> team_msdynmkt_pushdeviceregistrationresult

Many-To-One Relationship: [msdynmkt_pushdeviceregistrationresult team_msdynmkt_pushdeviceregistrationresult](msdynmkt_pushdeviceregistrationresult.md#BKMK_team_msdynmkt_pushdeviceregistrationresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_pushdeviceregistrationresult`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_pushdeviceregistrationresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_pushmobiledevice"></a> team_msdynmkt_pushmobiledevice

Many-To-One Relationship: [msdynmkt_pushmobiledevice team_msdynmkt_pushmobiledevice](msdynmkt_pushmobiledevice.md#BKMK_team_msdynmkt_pushmobiledevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_pushmobiledevice`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_pushmobiledevice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_pushnotification"></a> team_msdynmkt_pushnotification

Many-To-One Relationship: [msdynmkt_pushnotification team_msdynmkt_pushnotification](msdynmkt_pushnotification.md#BKMK_team_msdynmkt_pushnotification)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_pushnotification`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_pushnotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_qrcodestyle"></a> team_msdynmkt_qrcodestyle

Many-To-One Relationship: [msdynmkt_qrcodestyle team_msdynmkt_qrcodestyle](msdynmkt_qrcodestyle.md#BKMK_team_msdynmkt_qrcodestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_qrcodestyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_qrcodestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_quiettimesetting"></a> team_msdynmkt_quiettimesetting

Many-To-One Relationship: [msdynmkt_quiettimesetting team_msdynmkt_quiettimesetting](msdynmkt_quiettimesetting.md#BKMK_team_msdynmkt_quiettimesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_quiettimesetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_quiettimesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_recaptchaconfiguration"></a> team_msdynmkt_recaptchaconfiguration

Many-To-One Relationship: [msdynmkt_recaptchaconfiguration team_msdynmkt_recaptchaconfiguration](msdynmkt_recaptchaconfiguration.md#BKMK_team_msdynmkt_recaptchaconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_recaptchaconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_recaptchaconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_segment"></a> team_msdynmkt_segment

Many-To-One Relationship: [msdynmkt_segment team_msdynmkt_segment](msdynmkt_segment.md#BKMK_team_msdynmkt_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_segment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_segmentdefinition"></a> team_msdynmkt_segmentdefinition

Many-To-One Relationship: [msdynmkt_segmentdefinition team_msdynmkt_segmentdefinition](msdynmkt_segmentdefinition.md#BKMK_team_msdynmkt_segmentdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentdefinition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_segmentdefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_segmentexecution"></a> team_msdynmkt_segmentexecution

Many-To-One Relationship: [msdynmkt_segmentexecution team_msdynmkt_segmentexecution](msdynmkt_segmentexecution.md#BKMK_team_msdynmkt_segmentexecution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentexecution`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_segmentexecution`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_segmentusage"></a> team_msdynmkt_segmentusage

Many-To-One Relationship: [msdynmkt_segmentusage team_msdynmkt_segmentusage](msdynmkt_segmentusage.md#BKMK_team_msdynmkt_segmentusage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentusage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_segmentusage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_sms"></a> team_msdynmkt_sms

Many-To-One Relationship: [msdynmkt_sms team_msdynmkt_sms](msdynmkt_sms.md#BKMK_team_msdynmkt_sms)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_sms`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_sms`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_submitbutton"></a> team_msdynmkt_submitbutton

Many-To-One Relationship: [msdynmkt_submitbutton team_msdynmkt_submitbutton](msdynmkt_submitbutton.md#BKMK_team_msdynmkt_submitbutton)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_submitbutton`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_submitbutton`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_tag"></a> team_msdynmkt_tag

Many-To-One Relationship: [msdynmkt_tag team_msdynmkt_tag](msdynmkt_tag.md#BKMK_team_msdynmkt_tag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_tag`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_tag`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_teamsengagement"></a> team_msdynmkt_teamsengagement

Many-To-One Relationship: [msdynmkt_teamsengagement team_msdynmkt_teamsengagement](msdynmkt_teamsengagement.md#BKMK_team_msdynmkt_teamsengagement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_teamsengagement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_teamsengagement`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_telesignchannelinstance"></a> team_msdynmkt_telesignchannelinstance

Many-To-One Relationship: [msdynmkt_telesignchannelinstance team_msdynmkt_telesignchannelinstance](msdynmkt_telesignchannelinstance.md#BKMK_team_msdynmkt_telesignchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_telesignchannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_telesignchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_telesignchannelinstanceaccount"></a> team_msdynmkt_telesignchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_telesignchannelinstanceaccount team_msdynmkt_telesignchannelinstanceaccount](msdynmkt_telesignchannelinstanceaccount.md#BKMK_team_msdynmkt_telesignchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_telesignchannelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_telesignchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_topic"></a> team_msdynmkt_topic

Many-To-One Relationship: [msdynmkt_topic team_msdynmkt_topic](msdynmkt_topic.md#BKMK_team_msdynmkt_topic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_topic`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_topic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_twiliochannelinstance"></a> team_msdynmkt_twiliochannelinstance

Many-To-One Relationship: [msdynmkt_twiliochannelinstance team_msdynmkt_twiliochannelinstance](msdynmkt_twiliochannelinstance.md#BKMK_team_msdynmkt_twiliochannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_twiliochannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_twiliochannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_twiliochannelinstanceaccount"></a> team_msdynmkt_twiliochannelinstanceaccount

Many-To-One Relationship: [msdynmkt_twiliochannelinstanceaccount team_msdynmkt_twiliochannelinstanceaccount](msdynmkt_twiliochannelinstanceaccount.md#BKMK_team_msdynmkt_twiliochannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_twiliochannelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_twiliochannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_utmtracking"></a> team_msdynmkt_utmtracking

Many-To-One Relationship: [msdynmkt_utmtracking team_msdynmkt_utmtracking](msdynmkt_utmtracking.md#BKMK_team_msdynmkt_utmtracking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_utmtracking`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_utmtracking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_vibeschannelinstance"></a> team_msdynmkt_vibeschannelinstance

Many-To-One Relationship: [msdynmkt_vibeschannelinstance team_msdynmkt_vibeschannelinstance](msdynmkt_vibeschannelinstance.md#BKMK_team_msdynmkt_vibeschannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_vibeschannelinstance`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_vibeschannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_vibeschannelinstanceaccount"></a> team_msdynmkt_vibeschannelinstanceaccount

Many-To-One Relationship: [msdynmkt_vibeschannelinstanceaccount team_msdynmkt_vibeschannelinstanceaccount](msdynmkt_vibeschannelinstanceaccount.md#BKMK_team_msdynmkt_vibeschannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_vibeschannelinstanceaccount`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_vibeschannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdynmkt_webinaremailjourney"></a> team_msdynmkt_webinaremailjourney

Many-To-One Relationship: [msdynmkt_webinaremailjourney team_msdynmkt_webinaremailjourney](msdynmkt_webinaremailjourney.md#BKMK_team_msdynmkt_webinaremailjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_webinaremailjourney`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_webinaremailjourney`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_attendeepass"></a> team_msevtmgt_attendeepass

Many-To-One Relationship: [msevtmgt_attendeepass team_msevtmgt_attendeepass](msevtmgt_attendeepass.md#BKMK_team_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_attendeepass`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_attendeepass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_authenticationsettings"></a> team_msevtmgt_authenticationsettings

Many-To-One Relationship: [msevtmgt_authenticationsettings team_msevtmgt_authenticationsettings](msevtmgt_authenticationsettings.md#BKMK_team_msevtmgt_authenticationsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_authenticationsettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_authenticationsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_bucket"></a> team_msevtmgt_bucket

Many-To-One Relationship: [msevtmgt_bucket team_msevtmgt_bucket](msevtmgt_bucket.md#BKMK_team_msevtmgt_bucket)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_bucket`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_bucket`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_building"></a> team_msevtmgt_building

Many-To-One Relationship: [msevtmgt_building team_msevtmgt_building](msevtmgt_building.md#BKMK_team_msevtmgt_building)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_building`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_building`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_checkin"></a> team_msevtmgt_checkin

Many-To-One Relationship: [msevtmgt_checkin team_msevtmgt_checkin](msevtmgt_checkin.md#BKMK_team_msevtmgt_checkin)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_checkin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_customregistrationfield"></a> team_msevtmgt_customregistrationfield

Many-To-One Relationship: [msevtmgt_customregistrationfield team_msevtmgt_customregistrationfield](msevtmgt_customregistrationfield.md#BKMK_team_msevtmgt_customregistrationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_customregistrationfield`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_customregistrationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_entitycounter"></a> team_msevtmgt_entitycounter

Many-To-One Relationship: [msevtmgt_entitycounter team_msevtmgt_entitycounter](msevtmgt_entitycounter.md#BKMK_team_msevtmgt_entitycounter)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_entitycounter`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_entitycounter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_event"></a> team_msevtmgt_event

Many-To-One Relationship: [msevtmgt_event team_msevtmgt_event](msevtmgt_event.md#BKMK_team_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventadministration"></a> team_msevtmgt_eventadministration

Many-To-One Relationship: [msevtmgt_eventadministration team_msevtmgt_eventadministration](msevtmgt_eventadministration.md#BKMK_team_msevtmgt_eventadministration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventadministration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventadministration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventanalytics"></a> team_msevtmgt_eventanalytics

Many-To-One Relationship: [msevtmgt_eventanalytics team_msevtmgt_eventanalytics](msevtmgt_eventanalytics.md#BKMK_team_msevtmgt_eventanalytics)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventanalytics`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventanalytics`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventcustomregistrationfield"></a> team_msevtmgt_eventcustomregistrationfield

Many-To-One Relationship: [msevtmgt_eventcustomregistrationfield team_msevtmgt_eventcustomregistrationfield](msevtmgt_eventcustomregistrationfield.md#BKMK_team_msevtmgt_eventcustomregistrationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventcustomregistrationfield`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventcustomregistrationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventmanagementactivity"></a> team_msevtmgt_eventmanagementactivity

Many-To-One Relationship: [msevtmgt_eventmanagementactivity team_msevtmgt_eventmanagementactivity](msevtmgt_eventmanagementactivity.md#BKMK_team_msevtmgt_eventmanagementactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventmanagementactivity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventmanagementactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventmanagementconfiguration"></a> team_msevtmgt_eventmanagementconfiguration

Many-To-One Relationship: [msevtmgt_eventmanagementconfiguration team_msevtmgt_eventmanagementconfiguration](msevtmgt_eventmanagementconfiguration.md#BKMK_team_msevtmgt_eventmanagementconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventmanagementconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventmanagementconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventpurchase"></a> team_msevtmgt_eventpurchase

Many-To-One Relationship: [msevtmgt_eventpurchase team_msevtmgt_eventpurchase](msevtmgt_eventpurchase.md#BKMK_team_msevtmgt_eventpurchase)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchase`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventpurchase`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventpurchaseattendee"></a> team_msevtmgt_eventpurchaseattendee

Many-To-One Relationship: [msevtmgt_eventpurchaseattendee team_msevtmgt_eventpurchaseattendee](msevtmgt_eventpurchaseattendee.md#BKMK_team_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventpurchaseattendee`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventpurchasecontact"></a> team_msevtmgt_eventpurchasecontact

Many-To-One Relationship: [msevtmgt_eventpurchasecontact team_msevtmgt_eventpurchasecontact](msevtmgt_eventpurchasecontact.md#BKMK_team_msevtmgt_eventpurchasecontact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchasecontact`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventpurchasecontact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventpurchasepass"></a> team_msevtmgt_eventpurchasepass

Many-To-One Relationship: [msevtmgt_eventpurchasepass team_msevtmgt_eventpurchasepass](msevtmgt_eventpurchasepass.md#BKMK_team_msevtmgt_eventpurchasepass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchasepass`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventpurchasepass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventregistration"></a> team_msevtmgt_eventregistration

Many-To-One Relationship: [msevtmgt_eventregistration team_msevtmgt_eventregistration](msevtmgt_eventregistration.md#BKMK_team_msevtmgt_eventregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventregistration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventregistrationticket"></a> team_msevtmgt_eventregistrationticket

Many-To-One Relationship: [msevtmgt_eventregistrationticket team_msevtmgt_eventregistrationticket](msevtmgt_eventregistrationticket.md#BKMK_team_msevtmgt_eventregistrationticket)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventregistrationticket`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventregistrationticket`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventteammember"></a> team_msevtmgt_eventteammember

Many-To-One Relationship: [msevtmgt_eventteammember team_msevtmgt_eventteammember](msevtmgt_eventteammember.md#BKMK_team_msevtmgt_eventteammember)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventteammember`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventteammember`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventteamsproperties"></a> team_msevtmgt_eventteamsproperties

Many-To-One Relationship: [msevtmgt_eventteamsproperties team_msevtmgt_eventteamsproperties](msevtmgt_eventteamsproperties.md#BKMK_team_msevtmgt_eventteamsproperties)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventteamsproperties`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventteamsproperties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_eventvendor"></a> team_msevtmgt_eventvendor

Many-To-One Relationship: [msevtmgt_eventvendor team_msevtmgt_eventvendor](msevtmgt_eventvendor.md#BKMK_team_msevtmgt_eventvendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventvendor`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_eventvendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_file"></a> team_msevtmgt_file

Many-To-One Relationship: [msevtmgt_file team_msevtmgt_file](msevtmgt_file.md#BKMK_team_msevtmgt_file)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_file`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_file`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_hotel"></a> team_msevtmgt_hotel

Many-To-One Relationship: [msevtmgt_hotel team_msevtmgt_hotel](msevtmgt_hotel.md#BKMK_team_msevtmgt_hotel)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_hotel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_hotelroomallocation"></a> team_msevtmgt_hotelroomallocation

Many-To-One Relationship: [msevtmgt_hotelroomallocation team_msevtmgt_hotelroomallocation](msevtmgt_hotelroomallocation.md#BKMK_team_msevtmgt_hotelroomallocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomallocation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_hotelroomallocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_hotelroomreservation"></a> team_msevtmgt_hotelroomreservation

Many-To-One Relationship: [msevtmgt_hotelroomreservation team_msevtmgt_hotelroomreservation](msevtmgt_hotelroomreservation.md#BKMK_team_msevtmgt_hotelroomreservation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomreservation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_hotelroomreservation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_layout"></a> team_msevtmgt_layout

Many-To-One Relationship: [msevtmgt_layout team_msevtmgt_layout](msevtmgt_layout.md#BKMK_team_msevtmgt_layout)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_layout`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_layout`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_pass"></a> team_msevtmgt_pass

Many-To-One Relationship: [msevtmgt_pass team_msevtmgt_pass](msevtmgt_pass.md#BKMK_team_msevtmgt_pass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_pass`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_pass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_registrationresponse"></a> team_msevtmgt_registrationresponse

Many-To-One Relationship: [msevtmgt_registrationresponse team_msevtmgt_registrationresponse](msevtmgt_registrationresponse.md#BKMK_team_msevtmgt_registrationresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_registrationresponse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_registrationresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_room"></a> team_msevtmgt_room

Many-To-One Relationship: [msevtmgt_room team_msevtmgt_room](msevtmgt_room.md#BKMK_team_msevtmgt_room)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_room`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_room`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_roomreservation"></a> team_msevtmgt_roomreservation

Many-To-One Relationship: [msevtmgt_roomreservation team_msevtmgt_roomreservation](msevtmgt_roomreservation.md#BKMK_team_msevtmgt_roomreservation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_roomreservation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_roomreservation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_session"></a> team_msevtmgt_session

Many-To-One Relationship: [msevtmgt_session team_msevtmgt_session](msevtmgt_session.md#BKMK_team_msevtmgt_session)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_session`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_sessionregistration"></a> team_msevtmgt_sessionregistration

Many-To-One Relationship: [msevtmgt_sessionregistration team_msevtmgt_sessionregistration](msevtmgt_sessionregistration.md#BKMK_team_msevtmgt_sessionregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessionregistration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_sessionregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_sessiontrack"></a> team_msevtmgt_sessiontrack

Many-To-One Relationship: [msevtmgt_sessiontrack team_msevtmgt_sessiontrack](msevtmgt_sessiontrack.md#BKMK_team_msevtmgt_sessiontrack)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessiontrack`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_sessiontrack`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_speaker"></a> team_msevtmgt_speaker

Many-To-One Relationship: [msevtmgt_speaker team_msevtmgt_speaker](msevtmgt_speaker.md#BKMK_team_msevtmgt_speaker)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speaker`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_speaker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_speakerengagement"></a> team_msevtmgt_speakerengagement

Many-To-One Relationship: [msevtmgt_speakerengagement team_msevtmgt_speakerengagement](msevtmgt_speakerengagement.md#BKMK_team_msevtmgt_speakerengagement)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speakerengagement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_speakerengagement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_sponsorablearticle"></a> team_msevtmgt_sponsorablearticle

Many-To-One Relationship: [msevtmgt_sponsorablearticle team_msevtmgt_sponsorablearticle](msevtmgt_sponsorablearticle.md#BKMK_team_msevtmgt_sponsorablearticle)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorablearticle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_sponsorablearticle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_sponsorship"></a> team_msevtmgt_sponsorship

Many-To-One Relationship: [msevtmgt_sponsorship team_msevtmgt_sponsorship](msevtmgt_sponsorship.md#BKMK_team_msevtmgt_sponsorship)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorship`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_sponsorship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_venue"></a> team_msevtmgt_venue

Many-To-One Relationship: [msevtmgt_venue team_msevtmgt_venue](msevtmgt_venue.md#BKMK_team_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_venue`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_venue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_waitlistitem"></a> team_msevtmgt_waitlistitem

Many-To-One Relationship: [msevtmgt_waitlistitem team_msevtmgt_waitlistitem](msevtmgt_waitlistitem.md#BKMK_team_msevtmgt_waitlistitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_waitlistitem`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_waitlistitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msevtmgt_websiteentityconfiguration"></a> team_msevtmgt_websiteentityconfiguration

Many-To-One Relationship: [msevtmgt_websiteentityconfiguration team_msevtmgt_websiteentityconfiguration](msevtmgt_websiteentityconfiguration.md#BKMK_team_msevtmgt_websiteentityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_websiteentityconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msevtmgt_websiteentityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_alertrule"></a> team_msfp_alertrule

Many-To-One Relationship: [msfp_alertrule team_msfp_alertrule](msfp_alertrule.md#BKMK_team_msfp_alertrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alertrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_alertrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_emailtemplate"></a> team_msfp_emailtemplate

Many-To-One Relationship: [msfp_emailtemplate team_msfp_emailtemplate](msfp_emailtemplate.md#BKMK_team_msfp_emailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_emailtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_emailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_fileresponse"></a> team_msfp_fileresponse

Many-To-One Relationship: [msfp_fileresponse team_msfp_fileresponse](msfp_fileresponse.md#BKMK_team_msfp_fileresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_fileresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_localizedemailtemplate"></a> team_msfp_localizedemailtemplate

Many-To-One Relationship: [msfp_localizedemailtemplate team_msfp_localizedemailtemplate](msfp_localizedemailtemplate.md#BKMK_team_msfp_localizedemailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_localizedemailtemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_localizedemailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_project"></a> team_msfp_project

Many-To-One Relationship: [msfp_project team_msfp_project](msfp_project.md#BKMK_team_msfp_project)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_project`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_project`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_question"></a> team_msfp_question

Many-To-One Relationship: [msfp_question team_msfp_question](msfp_question.md#BKMK_team_msfp_question)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_question`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_question`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_questionresponse"></a> team_msfp_questionresponse

Many-To-One Relationship: [msfp_questionresponse team_msfp_questionresponse](msfp_questionresponse.md#BKMK_team_msfp_questionresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_questionresponse`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_questionresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_satisfactionmetric"></a> team_msfp_satisfactionmetric

Many-To-One Relationship: [msfp_satisfactionmetric team_msfp_satisfactionmetric](msfp_satisfactionmetric.md#BKMK_team_msfp_satisfactionmetric)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_satisfactionmetric`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_satisfactionmetric`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_survey"></a> team_msfp_survey

Many-To-One Relationship: [msfp_survey team_msfp_survey](msfp_survey.md#BKMK_team_msfp_survey)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_survey`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_survey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_surveyreminder"></a> team_msfp_surveyreminder

Many-To-One Relationship: [msfp_surveyreminder team_msfp_surveyreminder](msfp_surveyreminder.md#BKMK_team_msfp_surveyreminder)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyreminder`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_surveyreminder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msfp_unsubscribedrecipient"></a> team_msfp_unsubscribedrecipient

Many-To-One Relationship: [msfp_unsubscribedrecipient team_msfp_unsubscribedrecipient](msfp_unsubscribedrecipient.md#BKMK_team_msfp_unsubscribedrecipient)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_unsubscribedrecipient`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msfp_unsubscribedrecipient`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_3dasset"></a> team_msmrw_3dasset

Many-To-One Relationship: [msmrw_3dasset team_msmrw_3dasset](msmrw_3dasset.md#BKMK_team_msmrw_3dasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_3dasset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_3dasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_3dasset_localized"></a> team_msmrw_3dasset_localized

Many-To-One Relationship: [msmrw_3dasset_localized team_msmrw_3dasset_localized](msmrw_3dasset_localized.md#BKMK_team_msmrw_3dasset_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_3dasset_localized`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_3dasset_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_assetcollection"></a> team_msmrw_assetcollection

Many-To-One Relationship: [msmrw_assetcollection team_msmrw_assetcollection](msmrw_assetcollection.md#BKMK_team_msmrw_assetcollection)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_assetcollection`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_assetcollection`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_assetcollection_localized"></a> team_msmrw_assetcollection_localized

Many-To-One Relationship: [msmrw_assetcollection_localized team_msmrw_assetcollection_localized](msmrw_assetcollection_localized.md#BKMK_team_msmrw_assetcollection_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_assetcollection_localized`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_assetcollection_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_audioasset"></a> team_msmrw_audioasset

Many-To-One Relationship: [msmrw_audioasset team_msmrw_audioasset](msmrw_audioasset.md#BKMK_team_msmrw_audioasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_audioasset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_audioasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guide"></a> team_msmrw_guide

Many-To-One Relationship: [msmrw_guide team_msmrw_guide](msmrw_guide.md#BKMK_team_msmrw_guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guide`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guide`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guidecompletionstepobject"></a> team_msmrw_guidecompletionstepobject

Many-To-One Relationship: [msmrw_guidecompletionstepobject team_msmrw_guidecompletionstepobject](msmrw_guidecompletionstepobject.md#BKMK_team_msmrw_guidecompletionstepobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobject`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guidecompletionstepobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guidecompletionstepobjectplacement"></a> team_msmrw_guidecompletionstepobjectplacement

Many-To-One Relationship: [msmrw_guidecompletionstepobjectplacement team_msmrw_guidecompletionstepobjectplacement](msmrw_guidecompletionstepobjectplacement.md#BKMK_team_msmrw_guidecompletionstepobjectplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobjectplacement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guidecompletionstepobjectplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guideevent"></a> team_msmrw_guideevent

Many-To-One Relationship: [msmrw_guideevent team_msmrw_guideevent](msmrw_guideevent.md#BKMK_team_msmrw_guideevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guideevent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guideevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guidesession"></a> team_msmrw_guidesession

Many-To-One Relationship: [msmrw_guidesession team_msmrw_guidesession](msmrw_guidesession.md#BKMK_team_msmrw_guidesession)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidesession`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guidesession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guidesessionstepvisit"></a> team_msmrw_guidesessionstepvisit

Many-To-One Relationship: [msmrw_guidesessionstepvisit team_msmrw_guidesessionstepvisit](msmrw_guidesessionstepvisit.md#BKMK_team_msmrw_guidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidesessionstepvisit`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guidesessionstepvisit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guidestep"></a> team_msmrw_guidestep

Many-To-One Relationship: [msmrw_guidestep team_msmrw_guidestep](msmrw_guidestep.md#BKMK_team_msmrw_guidestep)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestep`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guidestep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guidestepobject"></a> team_msmrw_guidestepobject

Many-To-One Relationship: [msmrw_guidestepobject team_msmrw_guidestepobject](msmrw_guidestepobject.md#BKMK_team_msmrw_guidestepobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobject`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guidestepobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guidestepobjectplacement"></a> team_msmrw_guidestepobjectplacement

Many-To-One Relationship: [msmrw_guidestepobjectplacement team_msmrw_guidestepobjectplacement](msmrw_guidestepobjectplacement.md#BKMK_team_msmrw_guidestepobjectplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobjectplacement`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guidestepobjectplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guidetask"></a> team_msmrw_guidetask

Many-To-One Relationship: [msmrw_guidetask team_msmrw_guidetask](msmrw_guidetask.md#BKMK_team_msmrw_guidetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidetask`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guidetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_guideviewconfiguration"></a> team_msmrw_guideviewconfiguration

Many-To-One Relationship: [msmrw_guideviewconfiguration team_msmrw_guideviewconfiguration](msmrw_guideviewconfiguration.md#BKMK_team_msmrw_guideviewconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guideviewconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_guideviewconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_imageasset"></a> team_msmrw_imageasset

Many-To-One Relationship: [msmrw_imageasset team_msmrw_imageasset](msmrw_imageasset.md#BKMK_team_msmrw_imageasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_imageasset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_imageasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_imageasset_localized"></a> team_msmrw_imageasset_localized

Many-To-One Relationship: [msmrw_imageasset_localized team_msmrw_imageasset_localized](msmrw_imageasset_localized.md#BKMK_team_msmrw_imageasset_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_imageasset_localized`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_imageasset_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_packagedguide"></a> team_msmrw_packagedguide

Many-To-One Relationship: [msmrw_packagedguide team_msmrw_packagedguide](msmrw_packagedguide.md#BKMK_team_msmrw_packagedguide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_packagedguide`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_packagedguide`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_packagedguidesessionstepvisit"></a> team_msmrw_packagedguidesessionstepvisit

Many-To-One Relationship: [msmrw_packagedguidesessionstepvisit team_msmrw_packagedguidesessionstepvisit](msmrw_packagedguidesessionstepvisit.md#BKMK_team_msmrw_packagedguidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_packagedguidesessionstepvisit`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_packagedguidesessionstepvisit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_packagedguidesoperatorsession"></a> team_msmrw_packagedguidesoperatorsession

Many-To-One Relationship: [msmrw_packagedguidesoperatorsession team_msmrw_packagedguidesoperatorsession](msmrw_packagedguidesoperatorsession.md#BKMK_team_msmrw_packagedguidesoperatorsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_packagedguidesoperatorsession`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_packagedguidesoperatorsession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_usersettings"></a> team_msmrw_usersettings

Many-To-One Relationship: [msmrw_usersettings team_msmrw_usersettings](msmrw_usersettings.md#BKMK_team_msmrw_usersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_usersettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_usersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_videoasset"></a> team_msmrw_videoasset

Many-To-One Relationship: [msmrw_videoasset team_msmrw_videoasset](msmrw_videoasset.md#BKMK_team_msmrw_videoasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_videoasset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_videoasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msmrw_videoasset_localized"></a> team_msmrw_videoasset_localized

Many-To-One Relationship: [msmrw_videoasset_localized team_msmrw_videoasset_localized](msmrw_videoasset_localized.md#BKMK_team_msmrw_videoasset_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_videoasset_localized`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msmrw_videoasset_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_opportunities"></a> team_opportunities

Many-To-One Relationship: [opportunity team_opportunities](opportunity.md#BKMK_team_opportunities)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_opportunities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_opportunityclose"></a> team_opportunityclose

Many-To-One Relationship: [opportunityclose team_opportunityclose](opportunityclose.md#BKMK_team_opportunityclose)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_opportunityclose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_opportunityproduct"></a> team_opportunityproduct

Many-To-One Relationship: [opportunityproduct team_opportunityproduct](opportunityproduct.md#BKMK_team_opportunityproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityproduct`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_opportunityproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_orderclose"></a> team_orderclose

Many-To-One Relationship: [orderclose team_orderclose](orderclose.md#BKMK_team_orderclose)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_orderclose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_orders"></a> team_orders

Many-To-One Relationship: [salesorder team_orders](salesorder.md#BKMK_team_orders)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_orders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_quoteclose"></a> team_quoteclose

Many-To-One Relationship: [quoteclose team_quoteclose](quoteclose.md#BKMK_team_quoteclose)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_quoteclose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_quotedetail"></a> team_quotedetail

Many-To-One Relationship: [quotedetail team_quotedetail](quotedetail.md#BKMK_team_quotedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`quotedetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_quotedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_quotes"></a> team_quotes

Many-To-One Relationship: [quote team_quotes](quote.md#BKMK_team_quotes)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_quotes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_ratingmodel"></a> team_ratingmodel

Many-To-One Relationship: [ratingmodel team_ratingmodel](ratingmodel.md#BKMK_team_ratingmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`ratingmodel`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_ratingmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_ratingvalue"></a> team_ratingvalue

Many-To-One Relationship: [ratingvalue team_ratingvalue](ratingvalue.md#BKMK_team_ratingvalue)

|Property|Value|
|---|---|
|ReferencingEntity|`ratingvalue`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_ratingvalue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_resource_groups"></a> team_resource_groups

Many-To-One Relationship: [resourcegroup team_resource_groups](resourcegroup.md#BKMK_team_resource_groups)

|Property|Value|
|---|---|
|ReferencingEntity|`resourcegroup`|
|ReferencingAttribute|`resourcegroupid`|
|ReferencedEntityNavigationPropertyName|`team_resource_groups`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_resource_specs"></a> team_resource_specs

Many-To-One Relationship: [resourcespec team_resource_specs](resourcespec.md#BKMK_team_resource_specs)

|Property|Value|
|---|---|
|ReferencingEntity|`resourcespec`|
|ReferencingAttribute|`groupobjectid`|
|ReferencedEntityNavigationPropertyName|`team_resource_specs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_sales_linkedin_profileassociations"></a> team_sales_linkedin_profileassociations

Many-To-One Relationship: [sales_linkedin_profileassociations team_sales_linkedin_profileassociations](sales_linkedin_profileassociations.md#BKMK_team_sales_linkedin_profileassociations)

|Property|Value|
|---|---|
|ReferencingEntity|`sales_linkedin_profileassociations`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_sales_linkedin_profileassociations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_sales_linkedin_users_signedin_status"></a> team_sales_linkedin_users_signedin_status

Many-To-One Relationship: [sales_linkedin_users_signedin_status team_sales_linkedin_users_signedin_status](sales_linkedin_users_signedin_status.md#BKMK_team_sales_linkedin_users_signedin_status)

|Property|Value|
|---|---|
|ReferencingEntity|`sales_linkedin_users_signedin_status`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_sales_linkedin_users_signedin_status`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_salesorderdetail"></a> team_salesorderdetail

Many-To-One Relationship: [salesorderdetail team_salesorderdetail](salesorderdetail.md#BKMK_team_salesorderdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorderdetail`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_salesorderdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_service_appointments"></a> team_service_appointments

Many-To-One Relationship: [serviceappointment team_service_appointments](serviceappointment.md#BKMK_team_service_appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_service_appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_service_contracts"></a> team_service_contracts

Many-To-One Relationship: [contract team_service_contracts](contract.md#BKMK_team_service_contracts)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_service_contracts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.team?displayProperty=fullName>
