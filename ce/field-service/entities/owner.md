---
title: "Owner table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Owner table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Owner table/entity reference

Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Owner table extends the [Microsoft Dataverse Owner table](/power-apps/developer/data-platform/reference/entities/owner).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_alertsubscription_owner_ownerid](#BKMK_adx_alertsubscription_owner_ownerid)
- [bulkoperation_owner_ownerid](#BKMK_bulkoperation_owner_ownerid)
- [campaignactivity_owner_ownerid](#BKMK_campaignactivity_owner_ownerid)
- [campaignresponse_owner_ownerid](#BKMK_campaignresponse_owner_ownerid)
- [incidentresolution_owner_ownerid](#BKMK_incidentresolution_owner_ownerid)
- [li_inmail_owner_ownerid](#BKMK_li_inmail_owner_ownerid)
- [li_message_owner_ownerid](#BKMK_li_message_owner_ownerid)
- [li_pointdrivepresentationviewed_owner_ownerid](#BKMK_li_pointdrivepresentationviewed_owner_ownerid)
- [msdyn_bookingalert_owner_ownerid](#BKMK_msdyn_bookingalert_owner_ownerid)
- [msdyn_copilottranscript_owner_ownerid](#BKMK_msdyn_copilottranscript_owner_ownerid)
- [msdyn_ocliveworkitem_owner_ownerid](#BKMK_msdyn_ocliveworkitem_owner_ownerid)
- [msdyn_ocoutboundmessage_owner_ownerid](#BKMK_msdyn_ocoutboundmessage_owner_ownerid)
- [msdyn_ocsession_owner_ownerid](#BKMK_msdyn_ocsession_owner_ownerid)
- [msdyn_ocvoicemail_owner_ownerid](#BKMK_msdyn_ocvoicemail_owner_ownerid)
- [msfp_alert_owner_ownerid](#BKMK_msfp_alert_owner_ownerid)
- [msfp_surveyinvite_owner_ownerid](#BKMK_msfp_surveyinvite_owner_ownerid)
- [msfp_surveyresponse_owner_ownerid](#BKMK_msfp_surveyresponse_owner_ownerid)
- [opportunityclose_owner_ownerid](#BKMK_opportunityclose_owner_ownerid)
- [orderclose_owner_ownerid](#BKMK_orderclose_owner_ownerid)
- [owner_activitymonitor](#BKMK_owner_activitymonitor)
- [owner_adminsettingsentity](#BKMK_owner_adminsettingsentity)
- [owner_adx_ad](#BKMK_owner_adx_ad)
- [owner_adx_adplacement](#BKMK_owner_adx_adplacement)
- [owner_adx_botconsumer](#BKMK_owner_adx_botconsumer)
- [owner_adx_casedeflection](#BKMK_owner_adx_casedeflection)
- [owner_adx_cloudflowconsumer](#BKMK_owner_adx_cloudflowconsumer)
- [owner_adx_communityforum](#BKMK_owner_adx_communityforum)
- [owner_adx_communityforumaccesspermission](#BKMK_owner_adx_communityforumaccesspermission)
- [owner_adx_communityforumalert](#BKMK_owner_adx_communityforumalert)
- [owner_adx_communityforumannouncement](#BKMK_owner_adx_communityforumannouncement)
- [owner_adx_communityforumpost](#BKMK_owner_adx_communityforumpost)
- [owner_adx_communityforumthread](#BKMK_owner_adx_communityforumthread)
- [owner_adx_contentaccesslevel](#BKMK_owner_adx_contentaccesslevel)
- [owner_adx_contentsnippet](#BKMK_owner_adx_contentsnippet)
- [owner_adx_forumthreadtype](#BKMK_owner_adx_forumthreadtype)
- [owner_adx_pagealert](#BKMK_owner_adx_pagealert)
- [owner_adx_pagenotification](#BKMK_owner_adx_pagenotification)
- [owner_adx_pagetag](#BKMK_owner_adx_pagetag)
- [owner_adx_pagetemplate](#BKMK_owner_adx_pagetemplate)
- [owner_adx_poll](#BKMK_owner_adx_poll)
- [owner_adx_polloption](#BKMK_owner_adx_polloption)
- [owner_adx_pollplacement](#BKMK_owner_adx_pollplacement)
- [owner_adx_pollsubmission](#BKMK_owner_adx_pollsubmission)
- [owner_adx_portallanguage](#BKMK_owner_adx_portallanguage)
- [owner_adx_publishingstate](#BKMK_owner_adx_publishingstate)
- [owner_adx_publishingstatetransitionrule](#BKMK_owner_adx_publishingstatetransitionrule)
- [owner_adx_redirect](#BKMK_owner_adx_redirect)
- [owner_adx_shortcut](#BKMK_owner_adx_shortcut)
- [owner_adx_sitemarker](#BKMK_owner_adx_sitemarker)
- [owner_adx_sitemigrationchunk](#BKMK_owner_adx_sitemigrationchunk)
- [owner_adx_sitemigrationrun](#BKMK_owner_adx_sitemigrationrun)
- [owner_adx_sitesetting](#BKMK_owner_adx_sitesetting)
- [owner_adx_tag](#BKMK_owner_adx_tag)
- [owner_adx_urlhistory](#BKMK_owner_adx_urlhistory)
- [owner_adx_webfile](#BKMK_owner_adx_webfile)
- [owner_adx_webfilelog](#BKMK_owner_adx_webfilelog)
- [owner_adx_webform](#BKMK_owner_adx_webform)
- [owner_adx_weblink](#BKMK_owner_adx_weblink)
- [owner_adx_weblinkset](#BKMK_owner_adx_weblinkset)
- [owner_adx_webnotificationurl](#BKMK_owner_adx_webnotificationurl)
- [owner_adx_webpage](#BKMK_owner_adx_webpage)
- [owner_adx_webpageaccesscontrolrule](#BKMK_owner_adx_webpageaccesscontrolrule)
- [owner_adx_webpagehistory](#BKMK_owner_adx_webpagehistory)
- [owner_adx_webpagelog](#BKMK_owner_adx_webpagelog)
- [owner_adx_webrole](#BKMK_owner_adx_webrole)
- [owner_adx_website](#BKMK_owner_adx_website)
- [owner_adx_websiteaccess](#BKMK_owner_adx_websiteaccess)
- [owner_adx_websitelanguage](#BKMK_owner_adx_websitelanguage)
- [owner_adx_websitemigrationtracker](#BKMK_owner_adx_websitemigrationtracker)
- [owner_bookableresource](#BKMK_owner_bookableresource)
- [owner_bookableresourcebooking](#BKMK_owner_bookableresourcebooking)
- [owner_bookableresourcebookingheader](#BKMK_owner_bookableresourcebookingheader)
- [owner_bookableresourcecategory](#BKMK_owner_bookableresourcecategory)
- [owner_bookableresourcecategoryassn](#BKMK_owner_bookableresourcecategoryassn)
- [owner_bookableresourcecharacteristic](#BKMK_owner_bookableresourcecharacteristic)
- [owner_bookableresourcegroup](#BKMK_owner_bookableresourcegroup)
- [owner_bookingstatus](#BKMK_owner_bookingstatus)
- [owner_campaigns](#BKMK_owner_campaigns)
- [owner_characteristic](#BKMK_owner_characteristic)
- [owner_contracts](#BKMK_owner_contracts)
- [Owner_dynamicproperyinstance](#BKMK_Owner_dynamicproperyinstance)
- [owner_entitlement](#BKMK_owner_entitlement)
- [owner_entitlemententityallocationtypemapping](#BKMK_owner_entitlemententityallocationtypemapping)
- [owner_federatedknowledgeconfiguration](#BKMK_owner_federatedknowledgeconfiguration)
- [owner_federatedknowledgeentityconfiguration](#BKMK_owner_federatedknowledgeentityconfiguration)
- [owner_incidents](#BKMK_owner_incidents)
- [owner_invoices](#BKMK_owner_invoices)
- [owner_leads](#BKMK_owner_leads)
- [owner_listoperation](#BKMK_owner_listoperation)
- [owner_lists](#BKMK_owner_lists)
- [owner_mscipriv_activitymappingmetadatabase](#BKMK_owner_mscipriv_activitymappingmetadatabase)
- [owner_mscipriv_additionalentityinfo](#BKMK_owner_mscipriv_additionalentityinfo)
- [owner_mscipriv_aibuildercallbacktesthook](#BKMK_owner_mscipriv_aibuildercallbacktesthook)
- [owner_mscipriv_aibuildermodelmetadata](#BKMK_owner_mscipriv_aibuildermodelmetadata)
- [owner_mscipriv_analysisinstanceconfig](#BKMK_owner_mscipriv_analysisinstanceconfig)
- [owner_mscipriv_analysismetadata](#BKMK_owner_mscipriv_analysismetadata)
- [owner_mscipriv_azuremlwebservice](#BKMK_owner_mscipriv_azuremlwebservice)
- [owner_mscipriv_businessunitconfiguration](#BKMK_owner_mscipriv_businessunitconfiguration)
- [owner_mscipriv_cdsamodelmetadata](#BKMK_owner_mscipriv_cdsamodelmetadata)
- [owner_mscipriv_clusterloadmetadata](#BKMK_owner_mscipriv_clusterloadmetadata)
- [owner_mscipriv_conflationcriteriastatistics](#BKMK_owner_mscipriv_conflationcriteriastatistics)
- [owner_mscipriv_conflationmetadata](#BKMK_owner_mscipriv_conflationmetadata)
- [owner_mscipriv_conflationrun](#BKMK_owner_mscipriv_conflationrun)
- [owner_mscipriv_conflationstatistics](#BKMK_owner_mscipriv_conflationstatistics)
- [owner_mscipriv_consentsettings](#BKMK_owner_mscipriv_consentsettings)
- [owner_mscipriv_dataflowmetadata](#BKMK_owner_mscipriv_dataflowmetadata)
- [owner_mscipriv_datapreparationmetadata](#BKMK_owner_mscipriv_datapreparationmetadata)
- [owner_mscipriv_dataqualityfeaturewisemetadata](#BKMK_owner_mscipriv_dataqualityfeaturewisemetadata)
- [owner_mscipriv_dataqualityoverview](#BKMK_owner_mscipriv_dataqualityoverview)
- [owner_mscipriv_dataqualityreport](#BKMK_owner_mscipriv_dataqualityreport)
- [owner_mscipriv_datasetcatalog](#BKMK_owner_mscipriv_datasetcatalog)
- [owner_mscipriv_datasourcemetadata](#BKMK_owner_mscipriv_datasourcemetadata)
- [owner_mscipriv_datatroubleshootingaccess](#BKMK_owner_mscipriv_datatroubleshootingaccess)
- [owner_mscipriv_dataverseentitydatacleanupjobinfo](#BKMK_owner_mscipriv_dataverseentitydatacleanupjobinfo)
- [owner_mscipriv_derivedentitymetadata](#BKMK_owner_mscipriv_derivedentitymetadata)
- [owner_mscipriv_diagnosticsetting](#BKMK_owner_mscipriv_diagnosticsetting)
- [owner_mscipriv_discoveredcdsamodel](#BKMK_owner_mscipriv_discoveredcdsamodel)
- [owner_mscipriv_discoveryoperation](#BKMK_owner_mscipriv_discoveryoperation)
- [owner_mscipriv_enrichmentmetadata](#BKMK_owner_mscipriv_enrichmentmetadata)
- [owner_mscipriv_enrichmentrun](#BKMK_owner_mscipriv_enrichmentrun)
- [owner_mscipriv_entityfiltermetadata](#BKMK_owner_mscipriv_entityfiltermetadata)
- [owner_mscipriv_exportconfig](#BKMK_owner_mscipriv_exportconfig)
- [owner_mscipriv_exportconfigreport](#BKMK_owner_mscipriv_exportconfigreport)
- [owner_mscipriv_exportedmoduleconfiguration](#BKMK_owner_mscipriv_exportedmoduleconfiguration)
- [owner_mscipriv_exportsettings](#BKMK_owner_mscipriv_exportsettings)
- [owner_mscipriv_featuretemplate](#BKMK_owner_mscipriv_featuretemplate)
- [owner_mscipriv_graphmetadata](#BKMK_owner_mscipriv_graphmetadata)
- [owner_mscipriv_hierarchymetadata](#BKMK_owner_mscipriv_hierarchymetadata)
- [owner_mscipriv_hostloadmetadata](#BKMK_owner_mscipriv_hostloadmetadata)
- [owner_mscipriv_importexportstatusmetadata](#BKMK_owner_mscipriv_importexportstatusmetadata)
- [owner_mscipriv_insightmetadata](#BKMK_owner_mscipriv_insightmetadata)
- [owner_mscipriv_insightsdataqualityreport](#BKMK_owner_mscipriv_insightsdataqualityreport)
- [owner_mscipriv_instancemetrics](#BKMK_owner_mscipriv_instancemetrics)
- [owner_mscipriv_instancepartnercatalog](#BKMK_owner_mscipriv_instancepartnercatalog)
- [owner_mscipriv_instancesearchconfiguration](#BKMK_owner_mscipriv_instancesearchconfiguration)
- [owner_mscipriv_instancesettings](#BKMK_owner_mscipriv_instancesettings)
- [owner_mscipriv_intelligenceworkflowmetadata](#BKMK_owner_mscipriv_intelligenceworkflowmetadata)
- [owner_mscipriv_intelligenceworkflowrunmetadata](#BKMK_owner_mscipriv_intelligenceworkflowrunmetadata)
- [owner_mscipriv_intelligenceworkspacemetadata](#BKMK_owner_mscipriv_intelligenceworkspacemetadata)
- [owner_mscipriv_keyvaultmetadata](#BKMK_owner_mscipriv_keyvaultmetadata)
- [owner_mscipriv_lightcdsamodelmetadata](#BKMK_owner_mscipriv_lightcdsamodelmetadata)
- [owner_mscipriv_logicappssubscribermetadata](#BKMK_owner_mscipriv_logicappssubscribermetadata)
- [owner_mscipriv_mappedsecretmetadata](#BKMK_owner_mscipriv_mappedsecretmetadata)
- [owner_mscipriv_measuremetadata](#BKMK_owner_mscipriv_measuremetadata)
- [owner_mscipriv_modelconfigmetadata](#BKMK_owner_mscipriv_modelconfigmetadata)
- [owner_mscipriv_moduleconfigurationreference](#BKMK_owner_mscipriv_moduleconfigurationreference)
- [owner_mscipriv_notificationcheckpoint](#BKMK_owner_mscipriv_notificationcheckpoint)
- [owner_mscipriv_packageimportmetadata](#BKMK_owner_mscipriv_packageimportmetadata)
- [owner_mscipriv_packagejobmetadata](#BKMK_owner_mscipriv_packagejobmetadata)
- [owner_mscipriv_packagemetadata](#BKMK_owner_mscipriv_packagemetadata)
- [owner_mscipriv_platforminstancemapping](#BKMK_owner_mscipriv_platforminstancemapping)
- [owner_mscipriv_powerplatformconnector](#BKMK_owner_mscipriv_powerplatformconnector)
- [owner_mscipriv_powerplatformrefreshsignalmetadata](#BKMK_owner_mscipriv_powerplatformrefreshsignalmetadata)
- [owner_mscipriv_preenrichmentmetadata](#BKMK_owner_mscipriv_preenrichmentmetadata)
- [owner_mscipriv_profilestorestateinfo](#BKMK_owner_mscipriv_profilestorestateinfo)
- [owner_mscipriv_realtimeaggregatedstats](#BKMK_owner_mscipriv_realtimeaggregatedstats)
- [owner_mscipriv_realtimem3configuration](#BKMK_owner_mscipriv_realtimem3configuration)
- [owner_mscipriv_realtimem3searchconfiguration](#BKMK_owner_mscipriv_realtimem3searchconfiguration)
- [owner_mscipriv_realtimepluginmetadata](#BKMK_owner_mscipriv_realtimepluginmetadata)
- [owner_mscipriv_realtimesystemtablemetadata](#BKMK_owner_mscipriv_realtimesystemtablemetadata)
- [owner_mscipriv_realtimetablemetadata](#BKMK_owner_mscipriv_realtimetablemetadata)
- [owner_mscipriv_refreshhistorymetadata](#BKMK_owner_mscipriv_refreshhistorymetadata)
- [owner_mscipriv_refreshschedulebase](#BKMK_owner_mscipriv_refreshschedulebase)
- [owner_mscipriv_refreshstatehistorymetadata](#BKMK_owner_mscipriv_refreshstatehistorymetadata)
- [owner_mscipriv_relationshipmetadata](#BKMK_owner_mscipriv_relationshipmetadata)
- [owner_mscipriv_reportmetadata](#BKMK_owner_mscipriv_reportmetadata)
- [owner_mscipriv_resetinstancehistory](#BKMK_owner_mscipriv_resetinstancehistory)
- [owner_mscipriv_resourcemetadata](#BKMK_owner_mscipriv_resourcemetadata)
- [owner_mscipriv_runtimerealtimem3metadata](#BKMK_owner_mscipriv_runtimerealtimem3metadata)
- [owner_mscipriv_segmentmetadata](#BKMK_owner_mscipriv_segmentmetadata)
- [owner_mscipriv_semanticentitymappingmetadata](#BKMK_owner_mscipriv_semanticentitymappingmetadata)
- [owner_mscipriv_sparkjobexecutionmetadata](#BKMK_owner_mscipriv_sparkjobexecutionmetadata)
- [owner_mscipriv_systemintegrationmigrationtrackinginfo](#BKMK_owner_mscipriv_systemintegrationmigrationtrackinginfo)
- [owner_mscipriv_templatedmeasuremetadata](#BKMK_owner_mscipriv_templatedmeasuremetadata)
- [owner_mscipriv_templatedsegmentmetadata](#BKMK_owner_mscipriv_templatedsegmentmetadata)
- [owner_mscipriv_transformmetadata](#BKMK_owner_mscipriv_transformmetadata)
- [owner_mscipriv_unifiedactivitymappinggroupmetadata](#BKMK_owner_mscipriv_unifiedactivitymappinggroupmetadata)
- [owner_msdyn_actioncardactionstat](#BKMK_owner_msdyn_actioncardactionstat)
- [owner_msdyn_actioncardregarding](#BKMK_owner_msdyn_actioncardregarding)
- [owner_msdyn_actioncardrolesetting](#BKMK_owner_msdyn_actioncardrolesetting)
- [owner_msdyn_actioncardstataggregation](#BKMK_owner_msdyn_actioncardstataggregation)
- [owner_msdyn_activeicdextension](#BKMK_owner_msdyn_activeicdextension)
- [owner_msdyn_actual](#BKMK_owner_msdyn_actual)
- [owner_msdyn_adminappstate](#BKMK_owner_msdyn_adminappstate)
- [owner_msdyn_agentcapacityprofileunit](#BKMK_owner_msdyn_agentcapacityprofileunit)
- [owner_msdyn_agentcapacityupdatehistory](#BKMK_owner_msdyn_agentcapacityupdatehistory)
- [owner_msdyn_agentchannelstate](#BKMK_owner_msdyn_agentchannelstate)
- [owner_msdyn_agentstatus](#BKMK_owner_msdyn_agentstatus)
- [owner_msdyn_agentstatushistory](#BKMK_owner_msdyn_agentstatushistory)
- [owner_msdyn_agreement](#BKMK_owner_msdyn_agreement)
- [owner_msdyn_agreementbookingdate](#BKMK_owner_msdyn_agreementbookingdate)
- [owner_msdyn_agreementbookingincident](#BKMK_owner_msdyn_agreementbookingincident)
- [owner_msdyn_agreementbookingproduct](#BKMK_owner_msdyn_agreementbookingproduct)
- [owner_msdyn_agreementbookingservice](#BKMK_owner_msdyn_agreementbookingservice)
- [owner_msdyn_agreementbookingservicetask](#BKMK_owner_msdyn_agreementbookingservicetask)
- [owner_msdyn_agreementbookingsetup](#BKMK_owner_msdyn_agreementbookingsetup)
- [owner_msdyn_agreementinvoicedate](#BKMK_owner_msdyn_agreementinvoicedate)
- [owner_msdyn_agreementinvoiceproduct](#BKMK_owner_msdyn_agreementinvoiceproduct)
- [owner_msdyn_agreementinvoicesetup](#BKMK_owner_msdyn_agreementinvoicesetup)
- [owner_msdyn_agreementsubstatus](#BKMK_owner_msdyn_agreementsubstatus)
- [owner_msdyn_aicontactsuggestion](#BKMK_owner_msdyn_aicontactsuggestion)
- [owner_msdyn_analytics](#BKMK_owner_msdyn_analytics)
- [owner_msdyn_analyticsadminsettings](#BKMK_owner_msdyn_analyticsadminsettings)
- [owner_msdyn_analyticsforcs](#BKMK_owner_msdyn_analyticsforcs)
- [owner_msdyn_appconfiguration](#BKMK_owner_msdyn_appconfiguration)
- [owner_msdyn_applicationextension](#BKMK_owner_msdyn_applicationextension)
- [owner_msdyn_applicationtabtemplate](#BKMK_owner_msdyn_applicationtabtemplate)
- [owner_msdyn_appprofilerolemapping](#BKMK_owner_msdyn_appprofilerolemapping)
- [owner_msdyn_appstate](#BKMK_owner_msdyn_appstate)
- [owner_msdyn_assetcategorytemplateassociation](#BKMK_owner_msdyn_assetcategorytemplateassociation)
- [owner_msdyn_assettemplateassociation](#BKMK_owner_msdyn_assettemplateassociation)
- [owner_msdyn_assignmentconfiguration](#BKMK_owner_msdyn_assignmentconfiguration)
- [owner_msdyn_assignmentconfigurationstep](#BKMK_owner_msdyn_assignmentconfigurationstep)
- [owner_msdyn_assignmentmap](#BKMK_owner_msdyn_assignmentmap)
- [owner_msdyn_assignmentrule](#BKMK_owner_msdyn_assignmentrule)
- [owner_msdyn_attribute](#BKMK_owner_msdyn_attribute)
- [owner_msdyn_attributevalue](#BKMK_owner_msdyn_attributevalue)
- [owner_msdyn_authenticationsettings](#BKMK_owner_msdyn_authenticationsettings)
- [owner_msdyn_authsettingsentry](#BKMK_owner_msdyn_authsettingsentry)
- [owner_msdyn_autocapturerule](#BKMK_owner_msdyn_autocapturerule)
- [owner_msdyn_autocapturesettings](#BKMK_owner_msdyn_autocapturesettings)
- [owner_msdyn_autonomouscasecreationrule](#BKMK_owner_msdyn_autonomouscasecreationrule)
- [owner_msdyn_bgjobledger](#BKMK_owner_msdyn_bgjobledger)
- [owner_msdyn_bookableresourceassociation](#BKMK_owner_msdyn_bookableresourceassociation)
- [owner_msdyn_bookableresourcebookingquicknote](#BKMK_owner_msdyn_bookableresourcebookingquicknote)
- [owner_msdyn_bookableresourcecapacityprofile](#BKMK_owner_msdyn_bookableresourcecapacityprofile)
- [owner_msdyn_bookingalertstatus](#BKMK_owner_msdyn_bookingalertstatus)
- [owner_msdyn_bookingchange](#BKMK_owner_msdyn_bookingchange)
- [owner_msdyn_bookingjournal](#BKMK_owner_msdyn_bookingjournal)
- [owner_msdyn_bookingrule](#BKMK_owner_msdyn_bookingrule)
- [owner_msdyn_bookingsetupmetadata](#BKMK_owner_msdyn_bookingsetupmetadata)
- [owner_msdyn_bookingtimestamp](#BKMK_owner_msdyn_bookingtimestamp)
- [owner_msdyn_botsession](#BKMK_owner_msdyn_botsession)
- [owner_msdyn_businessclosure](#BKMK_owner_msdyn_businessclosure)
- [owner_msdyn_callablecontext](#BKMK_owner_msdyn_callablecontext)
- [owner_msdyn_capacityprofile](#BKMK_owner_msdyn_capacityprofile)
- [owner_msdyn_cdsentityengagementctx](#BKMK_owner_msdyn_cdsentityengagementctx)
- [owner_msdyn_channel](#BKMK_owner_msdyn_channel)
- [owner_msdyn_channeldefinition](#BKMK_owner_msdyn_channeldefinition)
- [owner_msdyn_channeldefinitionconsent](#BKMK_owner_msdyn_channeldefinitionconsent)
- [owner_msdyn_channeldefinitionlocale](#BKMK_owner_msdyn_channeldefinitionlocale)
- [owner_msdyn_channelinstance](#BKMK_owner_msdyn_channelinstance)
- [owner_msdyn_channelinstanceaccount](#BKMK_owner_msdyn_channelinstanceaccount)
- [owner_msdyn_channelmessageattachment](#BKMK_owner_msdyn_channelmessageattachment)
- [owner_msdyn_channelmessagecontextpart](#BKMK_owner_msdyn_channelmessagecontextpart)
- [owner_msdyn_channelmessagepart](#BKMK_owner_msdyn_channelmessagepart)
- [owner_msdyn_channelprovider](#BKMK_owner_msdyn_channelprovider)
- [owner_msdyn_chatansweroption](#BKMK_owner_msdyn_chatansweroption)
- [owner_msdyn_chatquestionnaireresponse](#BKMK_owner_msdyn_chatquestionnaireresponse)
- [owner_msdyn_chatquestionnaireresponseitem](#BKMK_owner_msdyn_chatquestionnaireresponseitem)
- [owner_msdyn_chatwidgetlanguage](#BKMK_owner_msdyn_chatwidgetlanguage)
- [owner_msdyn_clientextension](#BKMK_owner_msdyn_clientextension)
- [owner_msdyn_configuration](#BKMK_owner_msdyn_configuration)
- [owner_msdyn_consoleapplicationnotificationfield](#BKMK_owner_msdyn_consoleapplicationnotificationfield)
- [owner_msdyn_consoleapplicationnotificationtemplate](#BKMK_owner_msdyn_consoleapplicationnotificationtemplate)
- [owner_msdyn_consoleapplicationsessiontemplate](#BKMK_owner_msdyn_consoleapplicationsessiontemplate)
- [owner_msdyn_consoleapplicationtemplate](#BKMK_owner_msdyn_consoleapplicationtemplate)
- [owner_msdyn_consoleapplicationtemplateparameter](#BKMK_owner_msdyn_consoleapplicationtemplateparameter)
- [owner_msdyn_consumingapplication](#BKMK_owner_msdyn_consumingapplication)
- [owner_msdyn_contactsuggestionrule](#BKMK_owner_msdyn_contactsuggestionrule)
- [owner_msdyn_contactsuggestionruleset](#BKMK_owner_msdyn_contactsuggestionruleset)
- [owner_msdyn_conversationaction](#BKMK_owner_msdyn_conversationaction)
- [owner_msdyn_conversationactionitem](#BKMK_owner_msdyn_conversationactionitem)
- [owner_msdyn_conversationactionlocale](#BKMK_owner_msdyn_conversationactionlocale)
- [owner_msdyn_conversationaggregatedinsights](#BKMK_owner_msdyn_conversationaggregatedinsights)
- [owner_msdyn_conversationcomment](#BKMK_owner_msdyn_conversationcomment)
- [owner_msdyn_conversationdata](#BKMK_owner_msdyn_conversationdata)
- [owner_msdyn_conversationinsight](#BKMK_owner_msdyn_conversationinsight)
- [owner_msdyn_conversationmessageblock](#BKMK_owner_msdyn_conversationmessageblock)
- [owner_msdyn_conversationparticipantinsights](#BKMK_owner_msdyn_conversationparticipantinsights)
- [owner_msdyn_conversationparticipantsentiment](#BKMK_owner_msdyn_conversationparticipantsentiment)
- [owner_msdyn_conversationquestion](#BKMK_owner_msdyn_conversationquestion)
- [owner_msdyn_conversationsegmentsentiment](#BKMK_owner_msdyn_conversationsegmentsentiment)
- [owner_msdyn_conversationsentiment](#BKMK_owner_msdyn_conversationsentiment)
- [owner_msdyn_conversationsignal](#BKMK_owner_msdyn_conversationsignal)
- [owner_msdyn_conversationsubject](#BKMK_owner_msdyn_conversationsubject)
- [owner_msdyn_conversationsummarysuggestion](#BKMK_owner_msdyn_conversationsummarysuggestion)
- [owner_msdyn_conversationsystemtag](#BKMK_owner_msdyn_conversationsystemtag)
- [owner_msdyn_conversationtag](#BKMK_owner_msdyn_conversationtag)
- [owner_msdyn_copilotagentpreference](#BKMK_owner_msdyn_copilotagentpreference)
- [owner_msdyn_copilotinteractiondata](#BKMK_owner_msdyn_copilotinteractiondata)
- [owner_msdyn_copilottranscriptdata](#BKMK_owner_msdyn_copilottranscriptdata)
- [owner_msdyn_crmconnection](#BKMK_owner_msdyn_crmconnection)
- [owner_msdyn_csadminconfig](#BKMK_owner_msdyn_csadminconfig)
- [owner_msdyn_customapirulesetconfiguration](#BKMK_owner_msdyn_customapirulesetconfiguration)
- [owner_msdyn_customengagementctx](#BKMK_owner_msdyn_customengagementctx)
- [owner_msdyn_customerasset](#BKMK_owner_msdyn_customerasset)
- [owner_msdyn_customerassetattachment](#BKMK_owner_msdyn_customerassetattachment)
- [owner_msdyn_customerassetcategory](#BKMK_owner_msdyn_customerassetcategory)
- [owner_msdyn_dataanalyticscustomizedreport](#BKMK_owner_msdyn_dataanalyticscustomizedreport)
- [owner_msdyn_dataanalyticsdataset](#BKMK_owner_msdyn_dataanalyticsdataset)
- [owner_msdyn_dataanalyticsreport](#BKMK_owner_msdyn_dataanalyticsreport)
- [owner_msdyn_dataanalyticsworkspace](#BKMK_owner_msdyn_dataanalyticsworkspace)
- [owner_msdyn_dealmanageraccess](#BKMK_owner_msdyn_dealmanageraccess)
- [owner_msdyn_dealmanagersettings](#BKMK_owner_msdyn_dealmanagersettings)
- [owner_msdyn_decisioncontract](#BKMK_owner_msdyn_decisioncontract)
- [owner_msdyn_decisionruleset](#BKMK_owner_msdyn_decisionruleset)
- [owner_msdyn_defextendedchannelinstance](#BKMK_owner_msdyn_defextendedchannelinstance)
- [owner_msdyn_defextendedchannelinstanceaccount](#BKMK_owner_msdyn_defextendedchannelinstanceaccount)
- [owner_msdyn_deletedconversation](#BKMK_owner_msdyn_deletedconversation)
- [owner_msdyn_diagnosticsdata](#BKMK_owner_msdyn_diagnosticsdata)
- [owner_msdyn_duplicateleadmapping](#BKMK_owner_msdyn_duplicateleadmapping)
- [owner_msdyn_effortpredictionresult](#BKMK_owner_msdyn_effortpredictionresult)
- [owner_msdyn_entitlementapplication](#BKMK_owner_msdyn_entitlementapplication)
- [owner_msdyn_entityattachment](#BKMK_owner_msdyn_entityattachment)
- [owner_msdyn_entityconfig](#BKMK_owner_msdyn_entityconfig)
- [owner_msdyn_entityconfiguration](#BKMK_owner_msdyn_entityconfiguration)
- [owner_msdyn_entityrankingrule](#BKMK_owner_msdyn_entityrankingrule)
- [owner_msdyn_entityroutingconfiguration](#BKMK_owner_msdyn_entityroutingconfiguration)
- [owner_msdyn_entityworkstreammap](#BKMK_owner_msdyn_entityworkstreammap)
- [owner_msdyn_extendedusersetting](#BKMK_owner_msdyn_extendedusersetting)
- [owner_msdyn_facebookengagementctx](#BKMK_owner_msdyn_facebookengagementctx)
- [owner_msdyn_fieldservicedemodatajob](#BKMK_owner_msdyn_fieldservicedemodatajob)
- [owner_msdyn_fieldservicesetting](#BKMK_owner_msdyn_fieldservicesetting)
- [owner_msdyn_fieldserviceslaconfiguration](#BKMK_owner_msdyn_fieldserviceslaconfiguration)
- [owner_msdyn_fieldservicesummaryconfiguration](#BKMK_owner_msdyn_fieldservicesummaryconfiguration)
- [owner_msdyn_flowcardtype](#BKMK_owner_msdyn_flowcardtype)
- [owner_msdyn_forecastconfiguration](#BKMK_owner_msdyn_forecastconfiguration)
- [owner_msdyn_forecastdefinition](#BKMK_owner_msdyn_forecastdefinition)
- [owner_msdyn_forecastinstance](#BKMK_owner_msdyn_forecastinstance)
- [owner_msdyn_forecastrecurrence](#BKMK_owner_msdyn_forecastrecurrence)
- [owner_msdyn_formmapping](#BKMK_owner_msdyn_formmapping)
- [owner_msdyn_functionallocation](#BKMK_owner_msdyn_functionallocation)
- [owner_msdyn_functionallocationtype](#BKMK_owner_msdyn_functionallocationtype)
- [owner_msdyn_gdprdata](#BKMK_owner_msdyn_gdprdata)
- [owner_msdyn_geofence](#BKMK_owner_msdyn_geofence)
- [owner_msdyn_geofenceevent](#BKMK_owner_msdyn_geofenceevent)
- [owner_msdyn_geofencingsettings](#BKMK_owner_msdyn_geofencingsettings)
- [owner_msdyn_guideauthorsession](#BKMK_owner_msdyn_guideauthorsession)
- [owner_msdyn_icdextension](#BKMK_owner_msdyn_icdextension)
- [owner_msdyn_icebreakersconfig](#BKMK_owner_msdyn_icebreakersconfig)
- [owner_msdyn_iermlmodel](#BKMK_owner_msdyn_iermlmodel)
- [owner_msdyn_iermltraining](#BKMK_owner_msdyn_iermltraining)
- [owner_msdyn_incidenttype](#BKMK_owner_msdyn_incidenttype)
- [owner_msdyn_incidenttype_requirementgroup](#BKMK_owner_msdyn_incidenttype_requirementgroup)
- [owner_msdyn_incidenttypecharacteristic](#BKMK_owner_msdyn_incidenttypecharacteristic)
- [owner_msdyn_incidenttypeproduct](#BKMK_owner_msdyn_incidenttypeproduct)
- [owner_msdyn_incidenttyperecommendationresult](#BKMK_owner_msdyn_incidenttyperecommendationresult)
- [owner_msdyn_incidenttyperecommendationrunhistory](#BKMK_owner_msdyn_incidenttyperecommendationrunhistory)
- [owner_msdyn_incidenttyperesolution](#BKMK_owner_msdyn_incidenttyperesolution)
- [owner_msdyn_incidenttypeservice](#BKMK_owner_msdyn_incidenttypeservice)
- [owner_msdyn_incidenttypeservicetask](#BKMK_owner_msdyn_incidenttypeservicetask)
- [owner_msdyn_incidenttypessetup](#BKMK_owner_msdyn_incidenttypessetup)
- [owner_msdyn_inspection](#BKMK_owner_msdyn_inspection)
- [owner_msdyn_inspectionattachment](#BKMK_owner_msdyn_inspectionattachment)
- [owner_msdyn_inspectiondefinition](#BKMK_owner_msdyn_inspectiondefinition)
- [owner_msdyn_inspectioninstance](#BKMK_owner_msdyn_inspectioninstance)
- [owner_msdyn_inspectionresponse](#BKMK_owner_msdyn_inspectionresponse)
- [owner_msdyn_insurance](#BKMK_owner_msdyn_insurance)
- [owner_msdyn_intent](#BKMK_owner_msdyn_intent)
- [owner_msdyn_inventoryadjustment](#BKMK_owner_msdyn_inventoryadjustment)
- [owner_msdyn_inventoryadjustmentproduct](#BKMK_owner_msdyn_inventoryadjustmentproduct)
- [owner_msdyn_inventoryjournal](#BKMK_owner_msdyn_inventoryjournal)
- [owner_msdyn_inventorytransfer](#BKMK_owner_msdyn_inventorytransfer)
- [owner_msdyn_iotalert](#BKMK_owner_msdyn_iotalert)
- [owner_msdyn_iotdevice](#BKMK_owner_msdyn_iotdevice)
- [owner_msdyn_iotdevicecategory](#BKMK_owner_msdyn_iotdevicecategory)
- [owner_msdyn_iotdevicecommand](#BKMK_owner_msdyn_iotdevicecommand)
- [owner_msdyn_iotdevicecommanddefinition](#BKMK_owner_msdyn_iotdevicecommanddefinition)
- [owner_msdyn_iotdevicedatahistory](#BKMK_owner_msdyn_iotdevicedatahistory)
- [owner_msdyn_iotdeviceproperty](#BKMK_owner_msdyn_iotdeviceproperty)
- [owner_msdyn_iotdeviceregistrationhistory](#BKMK_owner_msdyn_iotdeviceregistrationhistory)
- [owner_msdyn_iotdevicevisualizationconfiguration](#BKMK_owner_msdyn_iotdevicevisualizationconfiguration)
- [owner_msdyn_iotfieldmapping](#BKMK_owner_msdyn_iotfieldmapping)
- [owner_msdyn_iotpropertydefinition](#BKMK_owner_msdyn_iotpropertydefinition)
- [owner_msdyn_iotprovider](#BKMK_owner_msdyn_iotprovider)
- [owner_msdyn_iotproviderinstance](#BKMK_owner_msdyn_iotproviderinstance)
- [owner_msdyn_iotsettings](#BKMK_owner_msdyn_iotsettings)
- [owner_msdyn_jobsstate](#BKMK_owner_msdyn_jobsstate)
- [owner_msdyn_kpieventdata](#BKMK_owner_msdyn_kpieventdata)
- [owner_msdyn_kpieventdefinition](#BKMK_owner_msdyn_kpieventdefinition)
- [owner_msdyn_leadmodelconfig](#BKMK_owner_msdyn_leadmodelconfig)
- [owner_msdyn_lineengagementctx](#BKMK_owner_msdyn_lineengagementctx)
- [owner_msdyn_livechatconfig](#BKMK_owner_msdyn_livechatconfig)
- [owner_msdyn_livechatengagementctx](#BKMK_owner_msdyn_livechatengagementctx)
- [owner_msdyn_livechatwidgetlocation](#BKMK_owner_msdyn_livechatwidgetlocation)
- [owner_msdyn_liveconversation](#BKMK_owner_msdyn_liveconversation)
- [owner_msdyn_liveworkitemevent](#BKMK_owner_msdyn_liveworkitemevent)
- [owner_msdyn_liveworkstream](#BKMK_owner_msdyn_liveworkstream)
- [owner_msdyn_liveworkstreamcapacityprofile](#BKMK_owner_msdyn_liveworkstreamcapacityprofile)
- [owner_msdyn_locationtemplateassociation](#BKMK_owner_msdyn_locationtemplateassociation)
- [owner_msdyn_locationtypetemplateassociation](#BKMK_owner_msdyn_locationtypetemplateassociation)
- [owner_msdyn_lockstatus](#BKMK_owner_msdyn_lockstatus)
- [owner_msdyn_macrosession](#BKMK_owner_msdyn_macrosession)
- [owner_msdyn_masterentityroutingconfiguration](#BKMK_owner_msdyn_masterentityroutingconfiguration)
- [owner_msdyn_migrationtracker](#BKMK_owner_msdyn_migrationtracker)
- [owner_msdyn_mobilesource](#BKMK_owner_msdyn_mobilesource)
- [owner_msdyn_modelpreviewstatus](#BKMK_owner_msdyn_modelpreviewstatus)
- [owner_msdyn_mrappsession](#BKMK_owner_msdyn_mrappsession)
- [owner_msdyn_mrasjob](#BKMK_owner_msdyn_mrasjob)
- [owner_msdyn_mrfolder](#BKMK_owner_msdyn_mrfolder)
- [owner_msdyn_msteamssetting](#BKMK_owner_msdyn_msteamssetting)
- [owner_msdyn_notesanalysisconfig](#BKMK_owner_msdyn_notesanalysisconfig)
- [owner_msdyn_notificationfield](#BKMK_owner_msdyn_notificationfield)
- [owner_msdyn_notificationtemplate](#BKMK_owner_msdyn_notificationtemplate)
- [owner_msdyn_nottoexceed](#BKMK_owner_msdyn_nottoexceed)
- [owner_msdyn_objectanchor](#BKMK_owner_msdyn_objectanchor)
- [owner_msdyn_oc_geolocationprovider](#BKMK_owner_msdyn_oc_geolocationprovider)
- [owner_msdyn_ocagentassignedcustomapiprivilege](#BKMK_owner_msdyn_ocagentassignedcustomapiprivilege)
- [owner_msdyn_ocapplebusinessaccount](#BKMK_owner_msdyn_ocapplebusinessaccount)
- [owner_msdyn_ocapplemessagesforbusinessengagementctx](#BKMK_owner_msdyn_ocapplemessagesforbusinessengagementctx)
- [owner_msdyn_ocapplepay](#BKMK_owner_msdyn_ocapplepay)
- [owner_msdyn_ocautoblockrule](#BKMK_owner_msdyn_ocautoblockrule)
- [owner_msdyn_ocbotchannelregistration](#BKMK_owner_msdyn_ocbotchannelregistration)
- [owner_msdyn_ocbotchannelregistrationsecret](#BKMK_owner_msdyn_ocbotchannelregistrationsecret)
- [owner_msdyn_occarrier](#BKMK_owner_msdyn_occarrier)
- [owner_msdyn_occhannelapiconversationprivilege](#BKMK_owner_msdyn_occhannelapiconversationprivilege)
- [owner_msdyn_occhannelapimessageprivilege](#BKMK_owner_msdyn_occhannelapimessageprivilege)
- [owner_msdyn_occhannelapimethodmapping](#BKMK_owner_msdyn_occhannelapimethodmapping)
- [owner_msdyn_occommunicationprovidersetting](#BKMK_owner_msdyn_occommunicationprovidersetting)
- [owner_msdyn_occommunicationprovidersettingentry](#BKMK_owner_msdyn_occommunicationprovidersettingentry)
- [owner_msdyn_occustommessagingchannel](#BKMK_owner_msdyn_occustommessagingchannel)
- [owner_msdyn_ocexternalcontext](#BKMK_owner_msdyn_ocexternalcontext)
- [owner_msdyn_ocfbapplication](#BKMK_owner_msdyn_ocfbapplication)
- [owner_msdyn_ocfbpage](#BKMK_owner_msdyn_ocfbpage)
- [owner_msdyn_ocflaggedspam](#BKMK_owner_msdyn_ocflaggedspam)
- [owner_msdyn_ocgatekeeperengagementctx](#BKMK_owner_msdyn_ocgatekeeperengagementctx)
- [owner_msdyn_ocgooglebusinessmessagesagentaccount](#BKMK_owner_msdyn_ocgooglebusinessmessagesagentaccount)
- [owner_msdyn_ocgooglebusinessmessagesengagementctx](#BKMK_owner_msdyn_ocgooglebusinessmessagesengagementctx)
- [owner_msdyn_ocgooglebusinessmessagespartneraccount](#BKMK_owner_msdyn_ocgooglebusinessmessagespartneraccount)
- [owner_msdyn_oclanguage](#BKMK_owner_msdyn_oclanguage)
- [owner_msdyn_oclinechannelconfig](#BKMK_owner_msdyn_oclinechannelconfig)
- [owner_msdyn_ocliveworkitemcapacityprofile](#BKMK_owner_msdyn_ocliveworkitemcapacityprofile)
- [owner_msdyn_ocliveworkitemcharacteristic](#BKMK_owner_msdyn_ocliveworkitemcharacteristic)
- [owner_msdyn_ocliveworkitemcontextitem](#BKMK_owner_msdyn_ocliveworkitemcontextitem)
- [owner_msdyn_ocliveworkitemparticipant](#BKMK_owner_msdyn_ocliveworkitemparticipant)
- [owner_msdyn_ocliveworkitemsentiment](#BKMK_owner_msdyn_ocliveworkitemsentiment)
- [owner_msdyn_ocliveworkstreamcontextvariable](#BKMK_owner_msdyn_ocliveworkstreamcontextvariable)
- [owner_msdyn_ocoutboundconfiguration](#BKMK_owner_msdyn_ocoutboundconfiguration)
- [owner_msdyn_ocpaymentprofile](#BKMK_owner_msdyn_ocpaymentprofile)
- [owner_msdyn_ocphonecallengagementctx](#BKMK_owner_msdyn_ocphonecallengagementctx)
- [owner_msdyn_ocphonemusic](#BKMK_owner_msdyn_ocphonemusic)
- [owner_msdyn_ocphonenumber](#BKMK_owner_msdyn_ocphonenumber)
- [owner_msdyn_ocprovisioningstate](#BKMK_owner_msdyn_ocprovisioningstate)
- [owner_msdyn_ocrecording](#BKMK_owner_msdyn_ocrecording)
- [owner_msdyn_ocrequest](#BKMK_owner_msdyn_ocrequest)
- [owner_msdyn_ocrichobject](#BKMK_owner_msdyn_ocrichobject)
- [owner_msdyn_ocrichobjectmap](#BKMK_owner_msdyn_ocrichobjectmap)
- [owner_msdyn_ocruleitem](#BKMK_owner_msdyn_ocruleitem)
- [owner_msdyn_ocsentimentdailytopic](#BKMK_owner_msdyn_ocsentimentdailytopic)
- [owner_msdyn_ocsentimentdailytopickeyword](#BKMK_owner_msdyn_ocsentimentdailytopickeyword)
- [owner_msdyn_ocsentimentdailytopictrending](#BKMK_owner_msdyn_ocsentimentdailytopictrending)
- [owner_msdyn_ocsessioncharacteristic](#BKMK_owner_msdyn_ocsessioncharacteristic)
- [owner_msdyn_ocsessionparticipantevent](#BKMK_owner_msdyn_ocsessionparticipantevent)
- [owner_msdyn_ocsessionsentiment](#BKMK_owner_msdyn_ocsessionsentiment)
- [owner_msdyn_ocsimltraining](#BKMK_owner_msdyn_ocsimltraining)
- [owner_msdyn_ocsitdimportconfig](#BKMK_owner_msdyn_ocsitdimportconfig)
- [owner_msdyn_ocsitdskill](#BKMK_owner_msdyn_ocsitdskill)
- [owner_msdyn_ocsitrainingdata](#BKMK_owner_msdyn_ocsitrainingdata)
- [owner_msdyn_ocskillidentmlmodel](#BKMK_owner_msdyn_ocskillidentmlmodel)
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
- [owner_msdyn_omnichannelpersonalization](#BKMK_owner_msdyn_omnichannelpersonalization)
- [owner_msdyn_omnichannelqueue](#BKMK_owner_msdyn_omnichannelqueue)
- [owner_msdyn_omnichannelsyncconfig](#BKMK_owner_msdyn_omnichannelsyncconfig)
- [owner_msdyn_operatinghour](#BKMK_owner_msdyn_operatinghour)
- [owner_msdyn_opportunitymodelconfig](#BKMK_owner_msdyn_opportunitymodelconfig)
- [owner_msdyn_optimizationrequestbooking](#BKMK_owner_msdyn_optimizationrequestbooking)
- [owner_msdyn_optimizationrequestresource](#BKMK_owner_msdyn_optimizationrequestresource)
- [owner_msdyn_orderedobjective](#BKMK_owner_msdyn_orderedobjective)
- [owner_msdyn_orderinvoicingdate](#BKMK_owner_msdyn_orderinvoicingdate)
- [owner_msdyn_orderinvoicingproduct](#BKMK_owner_msdyn_orderinvoicingproduct)
- [owner_msdyn_orderinvoicingsetup](#BKMK_owner_msdyn_orderinvoicingsetup)
- [owner_msdyn_orderinvoicingsetupdate](#BKMK_owner_msdyn_orderinvoicingsetupdate)
- [owner_msdyn_orgchartnode](#BKMK_owner_msdyn_orgchartnode)
- [owner_msdyn_overflowactionconfig](#BKMK_owner_msdyn_overflowactionconfig)
- [owner_msdyn_payment](#BKMK_owner_msdyn_payment)
- [owner_msdyn_paymentdetail](#BKMK_owner_msdyn_paymentdetail)
- [owner_msdyn_paymentmethod](#BKMK_owner_msdyn_paymentmethod)
- [owner_msdyn_paymentterm](#BKMK_owner_msdyn_paymentterm)
- [owner_msdyn_personalmessage](#BKMK_owner_msdyn_personalmessage)
- [owner_msdyn_personalsoundsetting](#BKMK_owner_msdyn_personalsoundsetting)
- [owner_msdyn_playbookactivity](#BKMK_owner_msdyn_playbookactivity)
- [owner_msdyn_playbookactivityattribute](#BKMK_owner_msdyn_playbookactivityattribute)
- [owner_msdyn_playbookcategory](#BKMK_owner_msdyn_playbookcategory)
- [owner_msdyn_playbookinstance](#BKMK_owner_msdyn_playbookinstance)
- [owner_msdyn_playbooktemplate](#BKMK_owner_msdyn_playbooktemplate)
- [owner_msdyn_postalbum](#BKMK_owner_msdyn_postalbum)
- [owner_msdyn_postalcode](#BKMK_owner_msdyn_postalcode)
- [owner_msdyn_predictioncomputationoperation](#BKMK_owner_msdyn_predictioncomputationoperation)
- [owner_msdyn_predictionmodelstatus](#BKMK_owner_msdyn_predictionmodelstatus)
- [owner_msdyn_predictionscheduledoperation](#BKMK_owner_msdyn_predictionscheduledoperation)
- [owner_msdyn_predictivescoringsyncstatus](#BKMK_owner_msdyn_predictivescoringsyncstatus)
- [owner_msdyn_preferredagent](#BKMK_owner_msdyn_preferredagent)
- [owner_msdyn_preferredagentcustomeridentity](#BKMK_owner_msdyn_preferredagentcustomeridentity)
- [owner_msdyn_preferredagentroutedentity](#BKMK_owner_msdyn_preferredagentroutedentity)
- [owner_msdyn_priority](#BKMK_owner_msdyn_priority)
- [owner_msdyn_problematicasset](#BKMK_owner_msdyn_problematicasset)
- [owner_msdyn_problematicassetfeedback](#BKMK_owner_msdyn_problematicassetfeedback)
- [owner_msdyn_productivityactioninputparameter](#BKMK_owner_msdyn_productivityactioninputparameter)
- [owner_msdyn_productivityactionoutputparameter](#BKMK_owner_msdyn_productivityactionoutputparameter)
- [owner_msdyn_productivityagentscript](#BKMK_owner_msdyn_productivityagentscript)
- [owner_msdyn_productivityagentscriptstep](#BKMK_owner_msdyn_productivityagentscriptstep)
- [owner_msdyn_productivitymacroactiontemplate](#BKMK_owner_msdyn_productivitymacroactiontemplate)
- [owner_msdyn_productivitymacroconnector](#BKMK_owner_msdyn_productivitymacroconnector)
- [owner_msdyn_productivitymacrosolutionconfiguration](#BKMK_owner_msdyn_productivitymacrosolutionconfiguration)
- [owner_msdyn_productivityparameterdefinition](#BKMK_owner_msdyn_productivityparameterdefinition)
- [owner_msdyn_property](#BKMK_owner_msdyn_property)
- [owner_msdyn_propertyassetassociation](#BKMK_owner_msdyn_propertyassetassociation)
- [owner_msdyn_propertylocationassociation](#BKMK_owner_msdyn_propertylocationassociation)
- [owner_msdyn_propertylog](#BKMK_owner_msdyn_propertylog)
- [owner_msdyn_propertytemplateassociation](#BKMK_owner_msdyn_propertytemplateassociation)
- [owner_msdyn_purchaseorder](#BKMK_owner_msdyn_purchaseorder)
- [owner_msdyn_purchaseorderbill](#BKMK_owner_msdyn_purchaseorderbill)
- [owner_msdyn_purchaseorderproduct](#BKMK_owner_msdyn_purchaseorderproduct)
- [owner_msdyn_purchaseorderreceipt](#BKMK_owner_msdyn_purchaseorderreceipt)
- [owner_msdyn_purchaseorderreceiptproduct](#BKMK_owner_msdyn_purchaseorderreceiptproduct)
- [owner_msdyn_purchaseordersubstatus](#BKMK_owner_msdyn_purchaseordersubstatus)
- [owner_msdyn_questionsequence](#BKMK_owner_msdyn_questionsequence)
- [owner_msdyn_quotebookingincident](#BKMK_owner_msdyn_quotebookingincident)
- [owner_msdyn_quotebookingproduct](#BKMK_owner_msdyn_quotebookingproduct)
- [owner_msdyn_quotebookingservice](#BKMK_owner_msdyn_quotebookingservice)
- [owner_msdyn_quotebookingservicetask](#BKMK_owner_msdyn_quotebookingservicetask)
- [owner_msdyn_quotebookingsetup](#BKMK_owner_msdyn_quotebookingsetup)
- [owner_msdyn_quoteinvoicingproduct](#BKMK_owner_msdyn_quoteinvoicingproduct)
- [owner_msdyn_quoteinvoicingsetup](#BKMK_owner_msdyn_quoteinvoicingsetup)
- [owner_msdyn_readtracker](#BKMK_owner_msdyn_readtracker)
- [owner_msdyn_realtimescoring](#BKMK_owner_msdyn_realtimescoring)
- [owner_msdyn_realtimescoringoperation](#BKMK_owner_msdyn_realtimescoringoperation)
- [owner_msdyn_recording](#BKMK_owner_msdyn_recording)
- [owner_msdyn_relationshipinsightsunifiedconfig](#BKMK_owner_msdyn_relationshipinsightsunifiedconfig)
- [owner_msdyn_reportbookmark](#BKMK_owner_msdyn_reportbookmark)
- [owner_msdyn_requirementchange](#BKMK_owner_msdyn_requirementchange)
- [owner_msdyn_requirementcharacteristic](#BKMK_owner_msdyn_requirementcharacteristic)
- [owner_msdyn_requirementdependency](#BKMK_owner_msdyn_requirementdependency)
- [owner_msdyn_requirementgroup](#BKMK_owner_msdyn_requirementgroup)
- [owner_msdyn_requirementorganizationunit](#BKMK_owner_msdyn_requirementorganizationunit)
- [owner_msdyn_requirementrelationship](#BKMK_owner_msdyn_requirementrelationship)
- [owner_msdyn_requirementresourcecategory](#BKMK_owner_msdyn_requirementresourcecategory)
- [owner_msdyn_requirementresourcepreference](#BKMK_owner_msdyn_requirementresourcepreference)
- [owner_msdyn_requirementstatus](#BKMK_owner_msdyn_requirementstatus)
- [owner_msdyn_resolution](#BKMK_owner_msdyn_resolution)
- [owner_msdyn_resourcepaytype](#BKMK_owner_msdyn_resourcepaytype)
- [owner_msdyn_resourcerequirement](#BKMK_owner_msdyn_resourcerequirement)
- [owner_msdyn_resourcerequirementdetail](#BKMK_owner_msdyn_resourcerequirementdetail)
- [owner_msdyn_resourceterritory](#BKMK_owner_msdyn_resourceterritory)
- [owner_msdyn_rma](#BKMK_owner_msdyn_rma)
- [owner_msdyn_rmaproduct](#BKMK_owner_msdyn_rmaproduct)
- [owner_msdyn_rmareceipt](#BKMK_owner_msdyn_rmareceipt)
- [owner_msdyn_rmareceiptproduct](#BKMK_owner_msdyn_rmareceiptproduct)
- [owner_msdyn_rmasubstatus](#BKMK_owner_msdyn_rmasubstatus)
- [owner_msdyn_routingconfiguration](#BKMK_owner_msdyn_routingconfiguration)
- [owner_msdyn_routingconfigurationstep](#BKMK_owner_msdyn_routingconfigurationstep)
- [owner_msdyn_routingengineconfiguration](#BKMK_owner_msdyn_routingengineconfiguration)
- [owner_msdyn_routingjobconfiguration](#BKMK_owner_msdyn_routingjobconfiguration)
- [owner_msdyn_routingoptimizationrequest](#BKMK_owner_msdyn_routingoptimizationrequest)
- [owner_msdyn_routingprofileconfiguration](#BKMK_owner_msdyn_routingprofileconfiguration)
- [owner_msdyn_routingrequest](#BKMK_owner_msdyn_routingrequest)
- [owner_msdyn_rtv](#BKMK_owner_msdyn_rtv)
- [owner_msdyn_rtvproduct](#BKMK_owner_msdyn_rtvproduct)
- [owner_msdyn_rtvsubstatus](#BKMK_owner_msdyn_rtvsubstatus)
- [owner_msdyn_rulesetdependencymapping](#BKMK_owner_msdyn_rulesetdependencymapping)
- [owner_msdyn_salescopilotinsight](#BKMK_owner_msdyn_salescopilotinsight)
- [owner_msdyn_salesinsightssettings](#BKMK_owner_msdyn_salesinsightssettings)
- [owner_msdyn_salesocmessage](#BKMK_owner_msdyn_salesocmessage)
- [owner_msdyn_salesocsmstemplate](#BKMK_owner_msdyn_salesocsmstemplate)
- [owner_msdyn_salesroutingrun](#BKMK_owner_msdyn_salesroutingrun)
- [owner_msdyn_salessuggestion](#BKMK_owner_msdyn_salessuggestion)
- [owner_msdyn_salestag](#BKMK_owner_msdyn_salestag)
- [owner_msdyn_scenario](#BKMK_owner_msdyn_scenario)
- [owner_msdyn_scheduleboardsetting](#BKMK_owner_msdyn_scheduleboardsetting)
- [owner_msdyn_schedulingfeatureflag](#BKMK_owner_msdyn_schedulingfeatureflag)
- [owner_msdyn_sciconversation](#BKMK_owner_msdyn_sciconversation)
- [owner_msdyn_scicustomemailhighlight](#BKMK_owner_msdyn_scicustomemailhighlight)
- [owner_msdyn_scicustomhighlight](#BKMK_owner_msdyn_scicustomhighlight)
- [owner_msdyn_scicustompublisher](#BKMK_owner_msdyn_scicustompublisher)
- [owner_msdyn_sciusersettings](#BKMK_owner_msdyn_sciusersettings)
- [owner_msdyn_searchconfiguration](#BKMK_owner_msdyn_searchconfiguration)
- [owner_msdyn_segment](#BKMK_owner_msdyn_segment)
- [owner_msdyn_sequence](#BKMK_owner_msdyn_sequence)
- [owner_msdyn_sequencestat](#BKMK_owner_msdyn_sequencestat)
- [owner_msdyn_sequencetarget](#BKMK_owner_msdyn_sequencetarget)
- [owner_msdyn_sequencetargetstep](#BKMK_owner_msdyn_sequencetargetstep)
- [owner_msdyn_sequencetemplate](#BKMK_owner_msdyn_sequencetemplate)
- [owner_msdyn_serviceoneprovisioningrequest](#BKMK_owner_msdyn_serviceoneprovisioningrequest)
- [owner_msdyn_servicetasktype](#BKMK_owner_msdyn_servicetasktype)
- [owner_msdyn_sessiondata](#BKMK_owner_msdyn_sessiondata)
- [owner_msdyn_sessionevent](#BKMK_owner_msdyn_sessionevent)
- [owner_msdyn_sessionparticipant](#BKMK_owner_msdyn_sessionparticipant)
- [owner_msdyn_sessionparticipantdata](#BKMK_owner_msdyn_sessionparticipantdata)
- [owner_msdyn_sessiontemplate](#BKMK_owner_msdyn_sessiontemplate)
- [owner_msdyn_shipvia](#BKMK_owner_msdyn_shipvia)
- [owner_msdyn_siconfig](#BKMK_owner_msdyn_siconfig)
- [owner_msdyn_skillattachmentruleitem](#BKMK_owner_msdyn_skillattachmentruleitem)
- [owner_msdyn_skillattachmenttarget](#BKMK_owner_msdyn_skillattachmenttarget)
- [owner_msdyn_smsengagementctx](#BKMK_owner_msdyn_smsengagementctx)
- [owner_msdyn_smsnumber](#BKMK_owner_msdyn_smsnumber)
- [owner_msdyn_soundnotificationsetting](#BKMK_owner_msdyn_soundnotificationsetting)
- [owner_msdyn_submodeldefinition](#BKMK_owner_msdyn_submodeldefinition)
- [owner_msdyn_suggestionassignmentrule](#BKMK_owner_msdyn_suggestionassignmentrule)
- [owner_msdyn_suggestionprincipalobjectaccess](#BKMK_owner_msdyn_suggestionprincipalobjectaccess)
- [owner_msdyn_suggestionsellerpriority](#BKMK_owner_msdyn_suggestionsellerpriority)
- [owner_msdyn_surveyquestion](#BKMK_owner_msdyn_surveyquestion)
- [owner_msdyn_swarm](#BKMK_owner_msdyn_swarm)
- [owner_msdyn_swarmparticipant](#BKMK_owner_msdyn_swarmparticipant)
- [owner_msdyn_swarmparticipantrule](#BKMK_owner_msdyn_swarmparticipantrule)
- [owner_msdyn_swarmrole](#BKMK_owner_msdyn_swarmrole)
- [owner_msdyn_swarmskill](#BKMK_owner_msdyn_swarmskill)
- [owner_msdyn_swarmtemplate](#BKMK_owner_msdyn_swarmtemplate)
- [owner_msdyn_systemuserschedulersetting](#BKMK_owner_msdyn_systemuserschedulersetting)
- [owner_msdyn_taggedrecord](#BKMK_owner_msdyn_taggedrecord)
- [owner_msdyn_taxcode](#BKMK_owner_msdyn_taxcode)
- [owner_msdyn_taxcodedetail](#BKMK_owner_msdyn_taxcodedetail)
- [owner_msdyn_teamschannelengagementctx](#BKMK_owner_msdyn_teamschannelengagementctx)
- [owner_msdyn_teamsengagementctx](#BKMK_owner_msdyn_teamsengagementctx)
- [owner_msdyn_templateforproperties](#BKMK_owner_msdyn_templateforproperties)
- [owner_msdyn_templateparameter](#BKMK_owner_msdyn_templateparameter)
- [owner_msdyn_templatetags](#BKMK_owner_msdyn_templatetags)
- [owner_msdyn_timeentry](#BKMK_owner_msdyn_timeentry)
- [owner_msdyn_timeentrysetting](#BKMK_owner_msdyn_timeentrysetting)
- [owner_msdyn_timegroup](#BKMK_owner_msdyn_timegroup)
- [owner_msdyn_timegroupdetail](#BKMK_owner_msdyn_timegroupdetail)
- [owner_msdyn_timeoffrequest](#BKMK_owner_msdyn_timeoffrequest)
- [owner_msdyn_timespent](#BKMK_owner_msdyn_timespent)
- [owner_msdyn_trade](#BKMK_owner_msdyn_trade)
- [owner_msdyn_tradecoverage](#BKMK_owner_msdyn_tradecoverage)
- [owner_msdyn_trainingresult](#BKMK_owner_msdyn_trainingresult)
- [owner_msdyn_transactionorigin](#BKMK_owner_msdyn_transactionorigin)
- [owner_msdyn_transcript](#BKMK_owner_msdyn_transcript)
- [owner_msdyn_twitterengagementctx](#BKMK_owner_msdyn_twitterengagementctx)
- [owner_msdyn_unifiedroutingdiagnostic](#BKMK_owner_msdyn_unifiedroutingdiagnostic)
- [owner_msdyn_unifiedroutingrun](#BKMK_owner_msdyn_unifiedroutingrun)
- [owner_msdyn_untrackedappointment](#BKMK_owner_msdyn_untrackedappointment)
- [owner_msdyn_urnotificationtemplate](#BKMK_owner_msdyn_urnotificationtemplate)
- [owner_msdyn_urnotificationtemplatemapping](#BKMK_owner_msdyn_urnotificationtemplatemapping)
- [owner_msdyn_visitorjourney](#BKMK_owner_msdyn_visitorjourney)
- [owner_msdyn_vivacustomerlist](#BKMK_owner_msdyn_vivacustomerlist)
- [owner_msdyn_vivausersetting](#BKMK_owner_msdyn_vivausersetting)
- [owner_msdyn_voicechannelorganizationsetting](#BKMK_owner_msdyn_voicechannelorganizationsetting)
- [owner_msdyn_wallsavedqueryusersettings](#BKMK_owner_msdyn_wallsavedqueryusersettings)
- [owner_msdyn_warehouse](#BKMK_owner_msdyn_warehouse)
- [owner_msdyn_warranty](#BKMK_owner_msdyn_warranty)
- [owner_msdyn_wechatengagementctx](#BKMK_owner_msdyn_wechatengagementctx)
- [owner_msdyn_whatsappengagementctx](#BKMK_owner_msdyn_whatsappengagementctx)
- [owner_msdyn_wkwconfig](#BKMK_owner_msdyn_wkwconfig)
- [owner_msdyn_workhourtemplate](#BKMK_owner_msdyn_workhourtemplate)
- [owner_msdyn_workorder](#BKMK_owner_msdyn_workorder)
- [owner_msdyn_workordercharacteristic](#BKMK_owner_msdyn_workordercharacteristic)
- [owner_msdyn_workorderincident](#BKMK_owner_msdyn_workorderincident)
- [owner_msdyn_workordernte](#BKMK_owner_msdyn_workordernte)
- [owner_msdyn_workorderproduct](#BKMK_owner_msdyn_workorderproduct)
- [owner_msdyn_workorderresolution](#BKMK_owner_msdyn_workorderresolution)
- [owner_msdyn_workorderresourcerestriction](#BKMK_owner_msdyn_workorderresourcerestriction)
- [owner_msdyn_workorderservice](#BKMK_owner_msdyn_workorderservice)
- [owner_msdyn_workorderservicetask](#BKMK_owner_msdyn_workorderservicetask)
- [owner_msdyn_workordersubstatus](#BKMK_owner_msdyn_workordersubstatus)
- [owner_msdyn_workordertype](#BKMK_owner_msdyn_workordertype)
- [owner_msdyn_workqueuestate](#BKMK_owner_msdyn_workqueuestate)
- [owner_msdyn_workqueueusersetting](#BKMK_owner_msdyn_workqueueusersetting)
- [owner_msdynci_alternatekey](#BKMK_owner_msdynci_alternatekey)
- [owner_msdynci_contactprofile](#BKMK_owner_msdynci_contactprofile)
- [owner_msdynci_customermeasure](#BKMK_owner_msdynci_customermeasure)
- [owner_msdynci_customerprofile](#BKMK_owner_msdynci_customerprofile)
- [owner_msdynci_customerprofilesegment](#BKMK_owner_msdynci_customerprofilesegment)
- [owner_msdynci_enrichment](#BKMK_owner_msdynci_enrichment)
- [owner_msdynci_personalizationaction](#BKMK_owner_msdynci_personalizationaction)
- [owner_msdynci_personalizationcookie](#BKMK_owner_msdynci_personalizationcookie)
- [owner_msdynci_personalizationuser](#BKMK_owner_msdynci_personalizationuser)
- [owner_msdynci_personalizationview](#BKMK_owner_msdynci_personalizationview)
- [owner_msdynci_prediction](#BKMK_owner_msdynci_prediction)
- [owner_msdynci_segmentmembership](#BKMK_owner_msdynci_segmentmembership)
- [owner_msdynci_unifiedactivity](#BKMK_owner_msdynci_unifiedactivity)
- [owner_msdynci_unifiedcontact_alternatekey](#BKMK_owner_msdynci_unifiedcontact_alternatekey)
- [owner_msdynci_unifiedcontactprofile](#BKMK_owner_msdynci_unifiedcontactprofile)
- [owner_msdynci_unifiedcontactsegment](#BKMK_owner_msdynci_unifiedcontactsegment)
- [owner_msdyncrm_addtocalendarstyle](#BKMK_owner_msdyncrm_addtocalendarstyle)
- [owner_msdyncrm_appointmentactivity](#BKMK_owner_msdyncrm_appointmentactivity)
- [owner_msdyncrm_appointmentactivitymarketingtemplate](#BKMK_owner_msdyncrm_appointmentactivitymarketingtemplate)
- [owner_msdyncrm_basestyle](#BKMK_owner_msdyncrm_basestyle)
- [owner_msdyncrm_buttonstyle](#BKMK_owner_msdyncrm_buttonstyle)
- [owner_msdyncrm_cdnconfiguration](#BKMK_owner_msdyncrm_cdnconfiguration)
- [owner_msdyncrm_cdsaconnectorconfiguration](#BKMK_owner_msdyncrm_cdsaconnectorconfiguration)
- [owner_msdyncrm_codestyle](#BKMK_owner_msdyncrm_codestyle)
- [owner_msdyncrm_columnstyle](#BKMK_owner_msdyncrm_columnstyle)
- [owner_msdyncrm_contentblock](#BKMK_owner_msdyncrm_contentblock)
- [owner_msdyncrm_contentblockstyle](#BKMK_owner_msdyncrm_contentblockstyle)
- [owner_msdyncrm_contentsettings](#BKMK_owner_msdyncrm_contentsettings)
- [owner_msdyncrm_createleadactivity](#BKMK_owner_msdyncrm_createleadactivity)
- [owner_msdyncrm_customerinsightsinfo](#BKMK_owner_msdyncrm_customerinsightsinfo)
- [owner_msdyncrm_customerjourney](#BKMK_owner_msdyncrm_customerjourney)
- [owner_msdyncrm_customerjourneycustomchannelactivity](#BKMK_owner_msdyncrm_customerjourneycustomchannelactivity)
- [owner_msdyncrm_customerjourneyiteration](#BKMK_owner_msdyncrm_customerjourneyiteration)
- [owner_msdyncrm_customerjourneyruntimestate](#BKMK_owner_msdyncrm_customerjourneyruntimestate)
- [owner_msdyncrm_customerjourneytemplate](#BKMK_owner_msdyncrm_customerjourneytemplate)
- [owner_msdyncrm_customerjourneyworkflowlink](#BKMK_owner_msdyncrm_customerjourneyworkflowlink)
- [owner_msdyncrm_defaultmarketingsetting](#BKMK_owner_msdyncrm_defaultmarketingsetting)
- [owner_msdyncrm_deprecatedcustomtileactivity](#BKMK_owner_msdyncrm_deprecatedcustomtileactivity)
- [owner_msdyncrm_deprecatedeventactivity](#BKMK_owner_msdyncrm_deprecatedeventactivity)
- [owner_msdyncrm_deprecatedformsprosurveyactivity](#BKMK_owner_msdyncrm_deprecatedformsprosurveyactivity)
- [owner_msdyncrm_deprecatedpageactivity](#BKMK_owner_msdyncrm_deprecatedpageactivity)
- [owner_msdyncrm_designerfeatureavailability](#BKMK_owner_msdyncrm_designerfeatureavailability)
- [owner_msdyncrm_dividerstyle](#BKMK_owner_msdyncrm_dividerstyle)
- [owner_msdyncrm_emailkeypoint](#BKMK_owner_msdyncrm_emailkeypoint)
- [owner_msdyncrm_featureconfiguration](#BKMK_owner_msdyncrm_featureconfiguration)
- [owner_msdyncrm_file](#BKMK_owner_msdyncrm_file)
- [owner_msdyncrm_formpage](#BKMK_owner_msdyncrm_formpage)
- [owner_msdyncrm_formpagetemplate](#BKMK_owner_msdyncrm_formpagetemplate)
- [owner_msdyncrm_generalstyles](#BKMK_owner_msdyncrm_generalstyles)
- [owner_msdyncrm_geopin](#BKMK_owner_msdyncrm_geopin)
- [owner_msdyncrm_gpt3log](#BKMK_owner_msdyncrm_gpt3log)
- [owner_msdyncrm_gwennolfeatureconfiguration](#BKMK_owner_msdyncrm_gwennolfeatureconfiguration)
- [owner_msdyncrm_gwennolspamscoreactivity](#BKMK_owner_msdyncrm_gwennolspamscoreactivity)
- [owner_msdyncrm_gwennolspamscorerequest](#BKMK_owner_msdyncrm_gwennolspamscorerequest)
- [owner_msdyncrm_imagestyle](#BKMK_owner_msdyncrm_imagestyle)
- [owner_msdyncrm_keyword](#BKMK_owner_msdyncrm_keyword)
- [owner_msdyncrm_launchworkflowactivity](#BKMK_owner_msdyncrm_launchworkflowactivity)
- [owner_msdyncrm_layoutstyle](#BKMK_owner_msdyncrm_layoutstyle)
- [owner_msdyncrm_leadscore](#BKMK_owner_msdyncrm_leadscore)
- [owner_msdyncrm_leadscore_v2](#BKMK_owner_msdyncrm_leadscore_v2)
- [owner_msdyncrm_leadscoremodel](#BKMK_owner_msdyncrm_leadscoremodel)
- [owner_msdyncrm_linkedinaccount](#BKMK_owner_msdyncrm_linkedinaccount)
- [owner_msdyncrm_linkedinactivity](#BKMK_owner_msdyncrm_linkedinactivity)
- [owner_msdyncrm_linkedinaudience](#BKMK_owner_msdyncrm_linkedinaudience)
- [owner_msdyncrm_linkedincampaign](#BKMK_owner_msdyncrm_linkedincampaign)
- [owner_msdyncrm_linkedincampaignactivity](#BKMK_owner_msdyncrm_linkedincampaignactivity)
- [owner_msdyncrm_linkedinconfiguration](#BKMK_owner_msdyncrm_linkedinconfiguration)
- [owner_msdyncrm_linkedinfieldmapping](#BKMK_owner_msdyncrm_linkedinfieldmapping)
- [owner_msdyncrm_linkedinform](#BKMK_owner_msdyncrm_linkedinform)
- [owner_msdyncrm_linkedinformanswer](#BKMK_owner_msdyncrm_linkedinformanswer)
- [owner_msdyncrm_linkedinformquestion](#BKMK_owner_msdyncrm_linkedinformquestion)
- [owner_msdyncrm_linkedinformsubmission](#BKMK_owner_msdyncrm_linkedinformsubmission)
- [owner_msdyncrm_linkedinleadmatchingstrategy](#BKMK_owner_msdyncrm_linkedinleadmatchingstrategy)
- [owner_msdyncrm_linkedinuserprofile](#BKMK_owner_msdyncrm_linkedinuserprofile)
- [owner_msdyncrm_listform](#BKMK_owner_msdyncrm_listform)
- [owner_msdyncrm_liveentitydependency](#BKMK_owner_msdyncrm_liveentitydependency)
- [owner_msdyncrm_marketingdataimport](#BKMK_owner_msdyncrm_marketingdataimport)
- [owner_msdyncrm_marketingdynamiccontentmetadata](#BKMK_owner_msdyncrm_marketingdynamiccontentmetadata)
- [owner_msdyncrm_marketingemail](#BKMK_owner_msdyncrm_marketingemail)
- [owner_msdyncrm_marketingemailactivity](#BKMK_owner_msdyncrm_marketingemailactivity)
- [owner_msdyncrm_marketingemaildynamiccontentmetadata](#BKMK_owner_msdyncrm_marketingemaildynamiccontentmetadata)
- [owner_msdyncrm_marketingemailtemplate](#BKMK_owner_msdyncrm_marketingemailtemplate)
- [owner_msdyncrm_marketingemailtest](#BKMK_owner_msdyncrm_marketingemailtest)
- [owner_msdyncrm_marketingemailtestattribute](#BKMK_owner_msdyncrm_marketingemailtestattribute)
- [owner_msdyncrm_marketingemailtestsend](#BKMK_owner_msdyncrm_marketingemailtestsend)
- [owner_msdyncrm_marketingfieldsubmission](#BKMK_owner_msdyncrm_marketingfieldsubmission)
- [owner_msdyncrm_marketingform](#BKMK_owner_msdyncrm_marketingform)
- [owner_msdyncrm_marketingformactivity](#BKMK_owner_msdyncrm_marketingformactivity)
- [owner_msdyncrm_marketingformfield](#BKMK_owner_msdyncrm_marketingformfield)
- [owner_msdyncrm_marketingformsubmission](#BKMK_owner_msdyncrm_marketingformsubmission)
- [owner_msdyncrm_marketingformtemplate](#BKMK_owner_msdyncrm_marketingformtemplate)
- [owner_msdyncrm_marketingformwhitelistrule](#BKMK_owner_msdyncrm_marketingformwhitelistrule)
- [owner_msdyncrm_marketingpage](#BKMK_owner_msdyncrm_marketingpage)
- [owner_msdyncrm_marketingpagetemplate](#BKMK_owner_msdyncrm_marketingpagetemplate)
- [owner_msdyncrm_matchingstrategyattribute](#BKMK_owner_msdyncrm_matchingstrategyattribute)
- [owner_msdyncrm_migration](#BKMK_owner_msdyncrm_migration)
- [owner_msdyncrm_mktactivity](#BKMK_owner_msdyncrm_mktactivity)
- [owner_msdyncrm_networkpage](#BKMK_owner_msdyncrm_networkpage)
- [owner_msdyncrm_personalizedpage](#BKMK_owner_msdyncrm_personalizedpage)
- [owner_msdyncrm_personalizedpagefield](#BKMK_owner_msdyncrm_personalizedpagefield)
- [owner_msdyncrm_phonecallactivity](#BKMK_owner_msdyncrm_phonecallactivity)
- [owner_msdyncrm_phonecallactivitymarketingtemplate](#BKMK_owner_msdyncrm_phonecallactivitymarketingtemplate)
- [owner_msdyncrm_postingishts](#BKMK_owner_msdyncrm_postingishts)
- [owner_msdyncrm_qrcodestyle](#BKMK_owner_msdyncrm_qrcodestyle)
- [owner_msdyncrm_quicksendemail](#BKMK_owner_msdyncrm_quicksendemail)
- [owner_msdyncrm_reaction](#BKMK_owner_msdyncrm_reaction)
- [owner_msdyncrm_recordupdateactivity](#BKMK_owner_msdyncrm_recordupdateactivity)
- [owner_msdyncrm_redirecturl](#BKMK_owner_msdyncrm_redirecturl)
- [owner_msdyncrm_segment](#BKMK_owner_msdyncrm_segment)
- [owner_msdyncrm_segmentactivity](#BKMK_owner_msdyncrm_segmentactivity)
- [owner_msdyncrm_segmenttemplate](#BKMK_owner_msdyncrm_segmenttemplate)
- [owner_msdyncrm_socialpost](#BKMK_owner_msdyncrm_socialpost)
- [owner_msdyncrm_socialpostingconfiguration](#BKMK_owner_msdyncrm_socialpostingconfiguration)
- [owner_msdyncrm_socialpostingconsent](#BKMK_owner_msdyncrm_socialpostingconsent)
- [owner_msdyncrm_sourceactivity](#BKMK_owner_msdyncrm_sourceactivity)
- [owner_msdyncrm_splitteractivity](#BKMK_owner_msdyncrm_splitteractivity)
- [owner_msdyncrm_tag](#BKMK_owner_msdyncrm_tag)
- [owner_msdyncrm_taskactivity](#BKMK_owner_msdyncrm_taskactivity)
- [owner_msdyncrm_taskactivitymarketingtemplate](#BKMK_owner_msdyncrm_taskactivitymarketingtemplate)
- [owner_msdyncrm_textstyle](#BKMK_owner_msdyncrm_textstyle)
- [owner_msdyncrm_triggeractivity](#BKMK_owner_msdyncrm_triggeractivity)
- [owner_msdyncrm_uicconfig](#BKMK_owner_msdyncrm_uicconfig)
- [owner_msdyncrm_usergeoregion](#BKMK_owner_msdyncrm_usergeoregion)
- [owner_msdyncrm_usersetting](#BKMK_owner_msdyncrm_usersetting)
- [owner_msdyncrm_video](#BKMK_owner_msdyncrm_video)
- [owner_msdyncrm_videostyle](#BKMK_owner_msdyncrm_videostyle)
- [owner_msdyncrm_website](#BKMK_owner_msdyncrm_website)
- [owner_msdynmkt_aimodelversion](#BKMK_owner_msdynmkt_aimodelversion)
- [owner_msdynmkt_apsconfig](#BKMK_owner_msdynmkt_apsconfig)
- [owner_msdynmkt_brandprofile](#BKMK_owner_msdynmkt_brandprofile)
- [owner_msdynmkt_brandsender](#BKMK_owner_msdynmkt_brandsender)
- [owner_msdynmkt_brandtheme](#BKMK_owner_msdynmkt_brandtheme)
- [owner_msdynmkt_buttonstyle](#BKMK_owner_msdynmkt_buttonstyle)
- [owner_msdynmkt_byoacschannelinstance](#BKMK_owner_msdynmkt_byoacschannelinstance)
- [owner_msdynmkt_byoacschannelinstanceaccount](#BKMK_owner_msdynmkt_byoacschannelinstanceaccount)
- [owner_msdynmkt_captcha](#BKMK_owner_msdynmkt_captcha)
- [owner_msdynmkt_catalogeventstatusconfiguration](#BKMK_owner_msdynmkt_catalogeventstatusconfiguration)
- [owner_msdynmkt_compliancesettings3](#BKMK_owner_msdynmkt_compliancesettings3)
- [owner_msdynmkt_compliancesettings4](#BKMK_owner_msdynmkt_compliancesettings4)
- [owner_msdynmkt_configuration](#BKMK_owner_msdynmkt_configuration)
- [owner_msdynmkt_consentprovider](#BKMK_owner_msdynmkt_consentprovider)
- [owner_msdynmkt_consentproviderdefaultconfiguration](#BKMK_owner_msdynmkt_consentproviderdefaultconfiguration)
- [owner_msdynmkt_consentproviderdefaultpurpose](#BKMK_owner_msdynmkt_consentproviderdefaultpurpose)
- [owner_msdynmkt_consentsystemconfiguration](#BKMK_owner_msdynmkt_consentsystemconfiguration)
- [owner_msdynmkt_contactpointconsent](#BKMK_owner_msdynmkt_contactpointconsent)
- [owner_msdynmkt_contactpointconsent3](#BKMK_owner_msdynmkt_contactpointconsent3)
- [owner_msdynmkt_contactpointconsent4](#BKMK_owner_msdynmkt_contactpointconsent4)
- [owner_msdynmkt_conversioneventdefinition](#BKMK_owner_msdynmkt_conversioneventdefinition)
- [owner_msdynmkt_createdentitylink](#BKMK_owner_msdynmkt_createdentitylink)
- [owner_msdynmkt_customchannelmessage](#BKMK_owner_msdynmkt_customchannelmessage)
- [owner_msdynmkt_domain](#BKMK_owner_msdynmkt_domain)
- [owner_msdynmkt_email](#BKMK_owner_msdynmkt_email)
- [owner_msdynmkt_emailtemplate](#BKMK_owner_msdynmkt_emailtemplate)
- [owner_msdynmkt_entitygradedistribution](#BKMK_owner_msdynmkt_entitygradedistribution)
- [owner_msdynmkt_entityscoredistribution](#BKMK_owner_msdynmkt_entityscoredistribution)
- [owner_msdynmkt_entityscoringmodel](#BKMK_owner_msdynmkt_entityscoringmodel)
- [owner_msdynmkt_eventmetadata](#BKMK_owner_msdynmkt_eventmetadata)
- [owner_msdynmkt_eventparametermetadata](#BKMK_owner_msdynmkt_eventparametermetadata)
- [owner_msdynmkt_experiment](#BKMK_owner_msdynmkt_experiment)
- [owner_msdynmkt_experimentv2](#BKMK_owner_msdynmkt_experimentv2)
- [owner_msdynmkt_featureconfiguration](#BKMK_owner_msdynmkt_featureconfiguration)
- [owner_msdynmkt_fragment](#BKMK_owner_msdynmkt_fragment)
- [owner_msdynmkt_frequencycap](#BKMK_owner_msdynmkt_frequencycap)
- [owner_msdynmkt_gdprrequest](#BKMK_owner_msdynmkt_gdprrequest)
- [owner_msdynmkt_imagestyle](#BKMK_owner_msdynmkt_imagestyle)
- [owner_msdynmkt_infobipchannelinstance](#BKMK_owner_msdynmkt_infobipchannelinstance)
- [owner_msdynmkt_infobipchannelinstanceaccount](#BKMK_owner_msdynmkt_infobipchannelinstanceaccount)
- [owner_msdynmkt_journey](#BKMK_owner_msdynmkt_journey)
- [owner_msdynmkt_journeydependency](#BKMK_owner_msdynmkt_journeydependency)
- [owner_msdynmkt_journeyevent](#BKMK_owner_msdynmkt_journeyevent)
- [owner_msdynmkt_journeyoptimizationcount](#BKMK_owner_msdynmkt_journeyoptimizationcount)
- [owner_msdynmkt_journeyrunparameter](#BKMK_owner_msdynmkt_journeyrunparameter)
- [owner_msdynmkt_journeysetting](#BKMK_owner_msdynmkt_journeysetting)
- [owner_msdynmkt_journeytemplate](#BKMK_owner_msdynmkt_journeytemplate)
- [owner_msdynmkt_journeyworkflowmapping](#BKMK_owner_msdynmkt_journeyworkflowmapping)
- [owner_msdynmkt_keyword](#BKMK_owner_msdynmkt_keyword)
- [owner_msdynmkt_leadqualificationmodel](#BKMK_owner_msdynmkt_leadqualificationmodel)
- [owner_msdynmkt_linkmobilitychannelinstance](#BKMK_owner_msdynmkt_linkmobilitychannelinstance)
- [owner_msdynmkt_linkmobilitychannelinstanceaccount](#BKMK_owner_msdynmkt_linkmobilitychannelinstanceaccount)
- [owner_msdynmkt_marketingfieldsubmission](#BKMK_owner_msdynmkt_marketingfieldsubmission)
- [owner_msdynmkt_marketingform](#BKMK_owner_msdynmkt_marketingform)
- [owner_msdynmkt_marketingformfield](#BKMK_owner_msdynmkt_marketingformfield)
- [owner_msdynmkt_marketingformsubmission](#BKMK_owner_msdynmkt_marketingformsubmission)
- [owner_msdynmkt_marketingformtemplate](#BKMK_owner_msdynmkt_marketingformtemplate)
- [owner_msdynmkt_matchingstrategy](#BKMK_owner_msdynmkt_matchingstrategy)
- [owner_msdynmkt_matchingstrategyattribute](#BKMK_owner_msdynmkt_matchingstrategyattribute)
- [owner_msdynmkt_metadataentityrelationship](#BKMK_owner_msdynmkt_metadataentityrelationship)
- [owner_msdynmkt_metadataitem](#BKMK_owner_msdynmkt_metadataitem)
- [owner_msdynmkt_metadatastorestate](#BKMK_owner_msdynmkt_metadatastorestate)
- [owner_msdynmkt_mobileapp](#BKMK_owner_msdynmkt_mobileapp)
- [owner_msdynmkt_mobileappchannelinstance](#BKMK_owner_msdynmkt_mobileappchannelinstance)
- [owner_msdynmkt_mobiledevice](#BKMK_owner_msdynmkt_mobiledevice)
- [owner_msdynmkt_mocksmsproviderchannelinstance](#BKMK_owner_msdynmkt_mocksmsproviderchannelinstance)
- [owner_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_owner_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [owner_msdynmkt_predefinedplaceholder](#BKMK_owner_msdynmkt_predefinedplaceholder)
- [owner_msdynmkt_preferencecenter](#BKMK_owner_msdynmkt_preferencecenter)
- [owner_msdynmkt_purpose](#BKMK_owner_msdynmkt_purpose)
- [owner_msdynmkt_pushdeviceregistrationresult](#BKMK_owner_msdynmkt_pushdeviceregistrationresult)
- [owner_msdynmkt_pushmobiledevice](#BKMK_owner_msdynmkt_pushmobiledevice)
- [owner_msdynmkt_pushnotification](#BKMK_owner_msdynmkt_pushnotification)
- [owner_msdynmkt_qrcodestyle](#BKMK_owner_msdynmkt_qrcodestyle)
- [owner_msdynmkt_quiettimesetting](#BKMK_owner_msdynmkt_quiettimesetting)
- [owner_msdynmkt_recaptchaconfiguration](#BKMK_owner_msdynmkt_recaptchaconfiguration)
- [owner_msdynmkt_segment](#BKMK_owner_msdynmkt_segment)
- [owner_msdynmkt_segmentdefinition](#BKMK_owner_msdynmkt_segmentdefinition)
- [owner_msdynmkt_segmentexecution](#BKMK_owner_msdynmkt_segmentexecution)
- [owner_msdynmkt_segmentusage](#BKMK_owner_msdynmkt_segmentusage)
- [owner_msdynmkt_sms](#BKMK_owner_msdynmkt_sms)
- [owner_msdynmkt_submitbutton](#BKMK_owner_msdynmkt_submitbutton)
- [owner_msdynmkt_tag](#BKMK_owner_msdynmkt_tag)
- [owner_msdynmkt_teamsengagement](#BKMK_owner_msdynmkt_teamsengagement)
- [owner_msdynmkt_telesignchannelinstance](#BKMK_owner_msdynmkt_telesignchannelinstance)
- [owner_msdynmkt_telesignchannelinstanceaccount](#BKMK_owner_msdynmkt_telesignchannelinstanceaccount)
- [owner_msdynmkt_topic](#BKMK_owner_msdynmkt_topic)
- [owner_msdynmkt_twiliochannelinstance](#BKMK_owner_msdynmkt_twiliochannelinstance)
- [owner_msdynmkt_twiliochannelinstanceaccount](#BKMK_owner_msdynmkt_twiliochannelinstanceaccount)
- [owner_msdynmkt_utmtracking](#BKMK_owner_msdynmkt_utmtracking)
- [owner_msdynmkt_vibeschannelinstance](#BKMK_owner_msdynmkt_vibeschannelinstance)
- [owner_msdynmkt_vibeschannelinstanceaccount](#BKMK_owner_msdynmkt_vibeschannelinstanceaccount)
- [owner_msdynmkt_webinaremailjourney](#BKMK_owner_msdynmkt_webinaremailjourney)
- [owner_msevtmgt_attendeepass](#BKMK_owner_msevtmgt_attendeepass)
- [owner_msevtmgt_authenticationsettings](#BKMK_owner_msevtmgt_authenticationsettings)
- [owner_msevtmgt_bucket](#BKMK_owner_msevtmgt_bucket)
- [owner_msevtmgt_building](#BKMK_owner_msevtmgt_building)
- [owner_msevtmgt_checkin](#BKMK_owner_msevtmgt_checkin)
- [owner_msevtmgt_customregistrationfield](#BKMK_owner_msevtmgt_customregistrationfield)
- [owner_msevtmgt_entitycounter](#BKMK_owner_msevtmgt_entitycounter)
- [owner_msevtmgt_event](#BKMK_owner_msevtmgt_event)
- [owner_msevtmgt_eventadministration](#BKMK_owner_msevtmgt_eventadministration)
- [owner_msevtmgt_eventanalytics](#BKMK_owner_msevtmgt_eventanalytics)
- [owner_msevtmgt_eventcustomregistrationfield](#BKMK_owner_msevtmgt_eventcustomregistrationfield)
- [owner_msevtmgt_eventmanagementactivity](#BKMK_owner_msevtmgt_eventmanagementactivity)
- [owner_msevtmgt_eventmanagementconfiguration](#BKMK_owner_msevtmgt_eventmanagementconfiguration)
- [owner_msevtmgt_eventpurchase](#BKMK_owner_msevtmgt_eventpurchase)
- [owner_msevtmgt_eventpurchaseattendee](#BKMK_owner_msevtmgt_eventpurchaseattendee)
- [owner_msevtmgt_eventpurchasecontact](#BKMK_owner_msevtmgt_eventpurchasecontact)
- [owner_msevtmgt_eventpurchasepass](#BKMK_owner_msevtmgt_eventpurchasepass)
- [owner_msevtmgt_eventregistration](#BKMK_owner_msevtmgt_eventregistration)
- [owner_msevtmgt_eventregistrationticket](#BKMK_owner_msevtmgt_eventregistrationticket)
- [owner_msevtmgt_eventteammember](#BKMK_owner_msevtmgt_eventteammember)
- [owner_msevtmgt_eventteamsproperties](#BKMK_owner_msevtmgt_eventteamsproperties)
- [owner_msevtmgt_eventvendor](#BKMK_owner_msevtmgt_eventvendor)
- [owner_msevtmgt_file](#BKMK_owner_msevtmgt_file)
- [owner_msevtmgt_hotel](#BKMK_owner_msevtmgt_hotel)
- [owner_msevtmgt_hotelroomallocation](#BKMK_owner_msevtmgt_hotelroomallocation)
- [owner_msevtmgt_hotelroomreservation](#BKMK_owner_msevtmgt_hotelroomreservation)
- [owner_msevtmgt_layout](#BKMK_owner_msevtmgt_layout)
- [owner_msevtmgt_pass](#BKMK_owner_msevtmgt_pass)
- [owner_msevtmgt_registrationresponse](#BKMK_owner_msevtmgt_registrationresponse)
- [owner_msevtmgt_room](#BKMK_owner_msevtmgt_room)
- [owner_msevtmgt_roomreservation](#BKMK_owner_msevtmgt_roomreservation)
- [owner_msevtmgt_session](#BKMK_owner_msevtmgt_session)
- [owner_msevtmgt_sessionregistration](#BKMK_owner_msevtmgt_sessionregistration)
- [owner_msevtmgt_sessiontrack](#BKMK_owner_msevtmgt_sessiontrack)
- [owner_msevtmgt_speaker](#BKMK_owner_msevtmgt_speaker)
- [owner_msevtmgt_speakerengagement](#BKMK_owner_msevtmgt_speakerengagement)
- [owner_msevtmgt_sponsorablearticle](#BKMK_owner_msevtmgt_sponsorablearticle)
- [owner_msevtmgt_sponsorship](#BKMK_owner_msevtmgt_sponsorship)
- [owner_msevtmgt_venue](#BKMK_owner_msevtmgt_venue)
- [owner_msevtmgt_waitlistitem](#BKMK_owner_msevtmgt_waitlistitem)
- [owner_msevtmgt_websiteentityconfiguration](#BKMK_owner_msevtmgt_websiteentityconfiguration)
- [owner_msfp_alertrule](#BKMK_owner_msfp_alertrule)
- [owner_msfp_emailtemplate](#BKMK_owner_msfp_emailtemplate)
- [owner_msfp_fileresponse](#BKMK_owner_msfp_fileresponse)
- [owner_msfp_localizedemailtemplate](#BKMK_owner_msfp_localizedemailtemplate)
- [owner_msfp_project](#BKMK_owner_msfp_project)
- [owner_msfp_question](#BKMK_owner_msfp_question)
- [owner_msfp_questionresponse](#BKMK_owner_msfp_questionresponse)
- [owner_msfp_satisfactionmetric](#BKMK_owner_msfp_satisfactionmetric)
- [owner_msfp_survey](#BKMK_owner_msfp_survey)
- [owner_msfp_surveyreminder](#BKMK_owner_msfp_surveyreminder)
- [owner_msfp_unsubscribedrecipient](#BKMK_owner_msfp_unsubscribedrecipient)
- [owner_msmrw_3dasset](#BKMK_owner_msmrw_3dasset)
- [owner_msmrw_3dasset_localized](#BKMK_owner_msmrw_3dasset_localized)
- [owner_msmrw_assetcollection](#BKMK_owner_msmrw_assetcollection)
- [owner_msmrw_assetcollection_localized](#BKMK_owner_msmrw_assetcollection_localized)
- [owner_msmrw_audioasset](#BKMK_owner_msmrw_audioasset)
- [owner_msmrw_guide](#BKMK_owner_msmrw_guide)
- [owner_msmrw_guidecompletionstepobject](#BKMK_owner_msmrw_guidecompletionstepobject)
- [owner_msmrw_guidecompletionstepobjectplacement](#BKMK_owner_msmrw_guidecompletionstepobjectplacement)
- [owner_msmrw_guideevent](#BKMK_owner_msmrw_guideevent)
- [owner_msmrw_guidesession](#BKMK_owner_msmrw_guidesession)
- [owner_msmrw_guidesessionstepvisit](#BKMK_owner_msmrw_guidesessionstepvisit)
- [owner_msmrw_guidestep](#BKMK_owner_msmrw_guidestep)
- [owner_msmrw_guidestepobject](#BKMK_owner_msmrw_guidestepobject)
- [owner_msmrw_guidestepobjectplacement](#BKMK_owner_msmrw_guidestepobjectplacement)
- [owner_msmrw_guidetask](#BKMK_owner_msmrw_guidetask)
- [owner_msmrw_guideviewconfiguration](#BKMK_owner_msmrw_guideviewconfiguration)
- [owner_msmrw_imageasset](#BKMK_owner_msmrw_imageasset)
- [owner_msmrw_imageasset_localized](#BKMK_owner_msmrw_imageasset_localized)
- [owner_msmrw_packagedguide](#BKMK_owner_msmrw_packagedguide)
- [owner_msmrw_packagedguidesessionstepvisit](#BKMK_owner_msmrw_packagedguidesessionstepvisit)
- [owner_msmrw_packagedguidesoperatorsession](#BKMK_owner_msmrw_packagedguidesoperatorsession)
- [owner_msmrw_usersettings](#BKMK_owner_msmrw_usersettings)
- [owner_msmrw_videoasset](#BKMK_owner_msmrw_videoasset)
- [owner_msmrw_videoasset_localized](#BKMK_owner_msmrw_videoasset_localized)
- [owner_opportunitys](#BKMK_owner_opportunitys)
- [owner_quotes](#BKMK_owner_quotes)
- [owner_ratingmodel](#BKMK_owner_ratingmodel)
- [owner_ratingvalue](#BKMK_owner_ratingvalue)
- [owner_sales_linkedin_profileassociations](#BKMK_owner_sales_linkedin_profileassociations)
- [owner_sales_linkedin_users_signedin_status](#BKMK_owner_sales_linkedin_users_signedin_status)
- [owner_salesorders](#BKMK_owner_salesorders)
- [quoteclose_owner_ownerid](#BKMK_quoteclose_owner_ownerid)
- [serviceappointment_owner_ownerid](#BKMK_serviceappointment_owner_ownerid)

### <a name="BKMK_adx_alertsubscription_owner_ownerid"></a> adx_alertsubscription_owner_ownerid

Many-To-One Relationship: [adx_alertsubscription adx_alertsubscription_owner_ownerid](adx_alertsubscription.md#BKMK_adx_alertsubscription_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`adx_alertsubscription_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bulkoperation_owner_ownerid"></a> bulkoperation_owner_ownerid

Many-To-One Relationship: [bulkoperation bulkoperation_owner_ownerid](bulkoperation.md#BKMK_bulkoperation_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`bulkoperation_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_owner_ownerid"></a> campaignactivity_owner_ownerid

Many-To-One Relationship: [campaignactivity campaignactivity_owner_ownerid](campaignactivity.md#BKMK_campaignactivity_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignresponse_owner_ownerid"></a> campaignresponse_owner_ownerid

Many-To-One Relationship: [campaignresponse campaignresponse_owner_ownerid](campaignresponse.md#BKMK_campaignresponse_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incidentresolution_owner_ownerid"></a> incidentresolution_owner_ownerid

Many-To-One Relationship: [incidentresolution incidentresolution_owner_ownerid](incidentresolution.md#BKMK_incidentresolution_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`incidentresolution_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_inmail_owner_ownerid"></a> li_inmail_owner_ownerid

Many-To-One Relationship: [li_inmail li_inmail_owner_ownerid](li_inmail.md#BKMK_li_inmail_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`li_inmail_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_message_owner_ownerid"></a> li_message_owner_ownerid

Many-To-One Relationship: [li_message li_message_owner_ownerid](li_message.md#BKMK_li_message_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`li_message_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_owner_ownerid"></a> li_pointdrivepresentationviewed_owner_ownerid

Many-To-One Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_owner_ownerid](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_owner_ownerid"></a> msdyn_bookingalert_owner_ownerid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_owner_ownerid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilottranscript_owner_ownerid"></a> msdyn_copilottranscript_owner_ownerid

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_owner_ownerid](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_owner_ownerid"></a> msdyn_ocliveworkitem_owner_ownerid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_owner_ownerid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_owner_ownerid`|
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

### <a name="BKMK_msdyn_ocsession_owner_ownerid"></a> msdyn_ocsession_owner_ownerid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_owner_ownerid](msdyn_ocsession.md#BKMK_msdyn_ocsession_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_owner_ownerid`|
|IsCustomizable|`True`|
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

### <a name="BKMK_msfp_alert_owner_ownerid"></a> msfp_alert_owner_ownerid

Many-To-One Relationship: [msfp_alert msfp_alert_owner_ownerid](msfp_alert.md#BKMK_msfp_alert_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyinvite_owner_ownerid"></a> msfp_surveyinvite_owner_ownerid

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_owner_ownerid](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyresponse_owner_ownerid"></a> msfp_surveyresponse_owner_ownerid

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_owner_ownerid](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunityclose_owner_ownerid"></a> opportunityclose_owner_ownerid

Many-To-One Relationship: [opportunityclose opportunityclose_owner_ownerid](opportunityclose.md#BKMK_opportunityclose_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`opportunityclose_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_orderclose_owner_ownerid"></a> orderclose_owner_ownerid

Many-To-One Relationship: [orderclose orderclose_owner_ownerid](orderclose.md#BKMK_orderclose_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`orderclose_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_activitymonitor"></a> owner_activitymonitor

Many-To-One Relationship: [activitymonitor owner_activitymonitor](activitymonitor.md#BKMK_owner_activitymonitor)

|Property|Value|
|---|---|
|ReferencingEntity|`activitymonitor`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_activitymonitor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adminsettingsentity"></a> owner_adminsettingsentity

Many-To-One Relationship: [adminsettingsentity owner_adminsettingsentity](adminsettingsentity.md#BKMK_owner_adminsettingsentity)

|Property|Value|
|---|---|
|ReferencingEntity|`adminsettingsentity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adminsettingsentity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_ad"></a> owner_adx_ad

Many-To-One Relationship: [adx_ad owner_adx_ad](adx_ad.md#BKMK_owner_adx_ad)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_ad`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_ad`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_adplacement"></a> owner_adx_adplacement

Many-To-One Relationship: [adx_adplacement owner_adx_adplacement](adx_adplacement.md#BKMK_owner_adx_adplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_adplacement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_adplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_botconsumer"></a> owner_adx_botconsumer

Many-To-One Relationship: [adx_botconsumer owner_adx_botconsumer](adx_botconsumer.md#BKMK_owner_adx_botconsumer)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_botconsumer`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_botconsumer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_casedeflection"></a> owner_adx_casedeflection

Many-To-One Relationship: [adx_casedeflection owner_adx_casedeflection](adx_casedeflection.md#BKMK_owner_adx_casedeflection)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_casedeflection`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_casedeflection`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_cloudflowconsumer"></a> owner_adx_cloudflowconsumer

Many-To-One Relationship: [adx_cloudflowconsumer owner_adx_cloudflowconsumer](adx_cloudflowconsumer.md#BKMK_owner_adx_cloudflowconsumer)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_cloudflowconsumer`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_cloudflowconsumer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_communityforum"></a> owner_adx_communityforum

Many-To-One Relationship: [adx_communityforum owner_adx_communityforum](adx_communityforum.md#BKMK_owner_adx_communityforum)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforum`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_communityforum`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_communityforumaccesspermission"></a> owner_adx_communityforumaccesspermission

Many-To-One Relationship: [adx_communityforumaccesspermission owner_adx_communityforumaccesspermission](adx_communityforumaccesspermission.md#BKMK_owner_adx_communityforumaccesspermission)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumaccesspermission`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_communityforumaccesspermission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_communityforumalert"></a> owner_adx_communityforumalert

Many-To-One Relationship: [adx_communityforumalert owner_adx_communityforumalert](adx_communityforumalert.md#BKMK_owner_adx_communityforumalert)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumalert`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_communityforumalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_communityforumannouncement"></a> owner_adx_communityforumannouncement

Many-To-One Relationship: [adx_communityforumannouncement owner_adx_communityforumannouncement](adx_communityforumannouncement.md#BKMK_owner_adx_communityforumannouncement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumannouncement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_communityforumannouncement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_communityforumpost"></a> owner_adx_communityforumpost

Many-To-One Relationship: [adx_communityforumpost owner_adx_communityforumpost](adx_communityforumpost.md#BKMK_owner_adx_communityforumpost)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumpost`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_communityforumpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_communityforumthread"></a> owner_adx_communityforumthread

Many-To-One Relationship: [adx_communityforumthread owner_adx_communityforumthread](adx_communityforumthread.md#BKMK_owner_adx_communityforumthread)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumthread`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_communityforumthread`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_contentaccesslevel"></a> owner_adx_contentaccesslevel

Many-To-One Relationship: [adx_contentaccesslevel owner_adx_contentaccesslevel](adx_contentaccesslevel.md#BKMK_owner_adx_contentaccesslevel)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_contentaccesslevel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_contentaccesslevel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_contentsnippet"></a> owner_adx_contentsnippet

Many-To-One Relationship: [adx_contentsnippet owner_adx_contentsnippet](adx_contentsnippet.md#BKMK_owner_adx_contentsnippet)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_contentsnippet`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_contentsnippet`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_forumthreadtype"></a> owner_adx_forumthreadtype

Many-To-One Relationship: [adx_forumthreadtype owner_adx_forumthreadtype](adx_forumthreadtype.md#BKMK_owner_adx_forumthreadtype)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumthreadtype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_forumthreadtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_pagealert"></a> owner_adx_pagealert

Many-To-One Relationship: [adx_pagealert owner_adx_pagealert](adx_pagealert.md#BKMK_owner_adx_pagealert)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagealert`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_pagealert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_pagenotification"></a> owner_adx_pagenotification

Many-To-One Relationship: [adx_pagenotification owner_adx_pagenotification](adx_pagenotification.md#BKMK_owner_adx_pagenotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagenotification`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_pagenotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_pagetag"></a> owner_adx_pagetag

Many-To-One Relationship: [adx_pagetag owner_adx_pagetag](adx_pagetag.md#BKMK_owner_adx_pagetag)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagetag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_pagetag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_pagetemplate"></a> owner_adx_pagetemplate

Many-To-One Relationship: [adx_pagetemplate owner_adx_pagetemplate](adx_pagetemplate.md#BKMK_owner_adx_pagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagetemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_pagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_poll"></a> owner_adx_poll

Many-To-One Relationship: [adx_poll owner_adx_poll](adx_poll.md#BKMK_owner_adx_poll)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_poll`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_poll`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_polloption"></a> owner_adx_polloption

Many-To-One Relationship: [adx_polloption owner_adx_polloption](adx_polloption.md#BKMK_owner_adx_polloption)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_polloption`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_polloption`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_pollplacement"></a> owner_adx_pollplacement

Many-To-One Relationship: [adx_pollplacement owner_adx_pollplacement](adx_pollplacement.md#BKMK_owner_adx_pollplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pollplacement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_pollplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_pollsubmission"></a> owner_adx_pollsubmission

Many-To-One Relationship: [adx_pollsubmission owner_adx_pollsubmission](adx_pollsubmission.md#BKMK_owner_adx_pollsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pollsubmission`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_pollsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_portallanguage"></a> owner_adx_portallanguage

Many-To-One Relationship: [adx_portallanguage owner_adx_portallanguage](adx_portallanguage.md#BKMK_owner_adx_portallanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portallanguage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_portallanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_publishingstate"></a> owner_adx_publishingstate

Many-To-One Relationship: [adx_publishingstate owner_adx_publishingstate](adx_publishingstate.md#BKMK_owner_adx_publishingstate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_publishingstate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_publishingstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_publishingstatetransitionrule"></a> owner_adx_publishingstatetransitionrule

Many-To-One Relationship: [adx_publishingstatetransitionrule owner_adx_publishingstatetransitionrule](adx_publishingstatetransitionrule.md#BKMK_owner_adx_publishingstatetransitionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_publishingstatetransitionrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_publishingstatetransitionrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_redirect"></a> owner_adx_redirect

Many-To-One Relationship: [adx_redirect owner_adx_redirect](adx_redirect.md#BKMK_owner_adx_redirect)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_redirect`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_redirect`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_shortcut"></a> owner_adx_shortcut

Many-To-One Relationship: [adx_shortcut owner_adx_shortcut](adx_shortcut.md#BKMK_owner_adx_shortcut)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_shortcut`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_shortcut`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_sitemarker"></a> owner_adx_sitemarker

Many-To-One Relationship: [adx_sitemarker owner_adx_sitemarker](adx_sitemarker.md#BKMK_owner_adx_sitemarker)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitemarker`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_sitemarker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_sitemigrationchunk"></a> owner_adx_sitemigrationchunk

Many-To-One Relationship: [adx_sitemigrationchunk owner_adx_sitemigrationchunk](adx_sitemigrationchunk.md#BKMK_owner_adx_sitemigrationchunk)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitemigrationchunk`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_sitemigrationchunk`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_sitemigrationrun"></a> owner_adx_sitemigrationrun

Many-To-One Relationship: [adx_sitemigrationrun owner_adx_sitemigrationrun](adx_sitemigrationrun.md#BKMK_owner_adx_sitemigrationrun)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitemigrationrun`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_sitemigrationrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_sitesetting"></a> owner_adx_sitesetting

Many-To-One Relationship: [adx_sitesetting owner_adx_sitesetting](adx_sitesetting.md#BKMK_owner_adx_sitesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitesetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_sitesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_tag"></a> owner_adx_tag

Many-To-One Relationship: [adx_tag owner_adx_tag](adx_tag.md#BKMK_owner_adx_tag)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_tag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_tag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_urlhistory"></a> owner_adx_urlhistory

Many-To-One Relationship: [adx_urlhistory owner_adx_urlhistory](adx_urlhistory.md#BKMK_owner_adx_urlhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_urlhistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_urlhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webfile"></a> owner_adx_webfile

Many-To-One Relationship: [adx_webfile owner_adx_webfile](adx_webfile.md#BKMK_owner_adx_webfile)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webfile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webfilelog"></a> owner_adx_webfilelog

Many-To-One Relationship: [adx_webfilelog owner_adx_webfilelog](adx_webfilelog.md#BKMK_owner_adx_webfilelog)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfilelog`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webfilelog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webform"></a> owner_adx_webform

Many-To-One Relationship: [adx_webform owner_adx_webform](adx_webform.md#BKMK_owner_adx_webform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webform`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_weblink"></a> owner_adx_weblink

Many-To-One Relationship: [adx_weblink owner_adx_weblink](adx_weblink.md#BKMK_owner_adx_weblink)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_weblink`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_weblink`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_weblinkset"></a> owner_adx_weblinkset

Many-To-One Relationship: [adx_weblinkset owner_adx_weblinkset](adx_weblinkset.md#BKMK_owner_adx_weblinkset)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_weblinkset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_weblinkset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webnotificationurl"></a> owner_adx_webnotificationurl

Many-To-One Relationship: [adx_webnotificationurl owner_adx_webnotificationurl](adx_webnotificationurl.md#BKMK_owner_adx_webnotificationurl)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webnotificationurl`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webnotificationurl`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webpage"></a> owner_adx_webpage

Many-To-One Relationship: [adx_webpage owner_adx_webpage](adx_webpage.md#BKMK_owner_adx_webpage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webpageaccesscontrolrule"></a> owner_adx_webpageaccesscontrolrule

Many-To-One Relationship: [adx_webpageaccesscontrolrule owner_adx_webpageaccesscontrolrule](adx_webpageaccesscontrolrule.md#BKMK_owner_adx_webpageaccesscontrolrule)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpageaccesscontrolrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webpageaccesscontrolrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webpagehistory"></a> owner_adx_webpagehistory

Many-To-One Relationship: [adx_webpagehistory owner_adx_webpagehistory](adx_webpagehistory.md#BKMK_owner_adx_webpagehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpagehistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webpagehistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webpagelog"></a> owner_adx_webpagelog

Many-To-One Relationship: [adx_webpagelog owner_adx_webpagelog](adx_webpagelog.md#BKMK_owner_adx_webpagelog)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpagelog`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webpagelog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_webrole"></a> owner_adx_webrole

Many-To-One Relationship: [adx_webrole owner_adx_webrole](adx_webrole.md#BKMK_owner_adx_webrole)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webrole`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_webrole`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_website"></a> owner_adx_website

Many-To-One Relationship: [adx_website owner_adx_website](adx_website.md#BKMK_owner_adx_website)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_website`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_website`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_websiteaccess"></a> owner_adx_websiteaccess

Many-To-One Relationship: [adx_websiteaccess owner_adx_websiteaccess](adx_websiteaccess.md#BKMK_owner_adx_websiteaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websiteaccess`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_websiteaccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_websitelanguage"></a> owner_adx_websitelanguage

Many-To-One Relationship: [adx_websitelanguage owner_adx_websitelanguage](adx_websitelanguage.md#BKMK_owner_adx_websitelanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websitelanguage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_websitelanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_adx_websitemigrationtracker"></a> owner_adx_websitemigrationtracker

Many-To-One Relationship: [adx_websitemigrationtracker owner_adx_websitemigrationtracker](adx_websitemigrationtracker.md#BKMK_owner_adx_websitemigrationtracker)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websitemigrationtracker`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_adx_websitemigrationtracker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_bookableresource"></a> owner_bookableresource

Many-To-One Relationship: [bookableresource owner_bookableresource](bookableresource.md#BKMK_owner_bookableresource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_bookableresource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_bookableresourcebooking"></a> owner_bookableresourcebooking

Many-To-One Relationship: [bookableresourcebooking owner_bookableresourcebooking](bookableresourcebooking.md#BKMK_owner_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_bookableresourcebooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_bookableresourcebookingheader"></a> owner_bookableresourcebookingheader

Many-To-One Relationship: [bookableresourcebookingheader owner_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_owner_bookableresourcebookingheader)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebookingheader`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_bookableresourcebookingheader`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_bookableresourcecategory"></a> owner_bookableresourcecategory

Many-To-One Relationship: [bookableresourcecategory owner_bookableresourcecategory](bookableresourcecategory.md#BKMK_owner_bookableresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_bookableresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_bookableresourcecategoryassn"></a> owner_bookableresourcecategoryassn

Many-To-One Relationship: [bookableresourcecategoryassn owner_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_owner_bookableresourcecategoryassn)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategoryassn`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_bookableresourcecategoryassn`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_bookableresourcecharacteristic"></a> owner_bookableresourcecharacteristic

Many-To-One Relationship: [bookableresourcecharacteristic owner_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_owner_bookableresourcecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_bookableresourcecharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_bookableresourcegroup"></a> owner_bookableresourcegroup

Many-To-One Relationship: [bookableresourcegroup owner_bookableresourcegroup](bookableresourcegroup.md#BKMK_owner_bookableresourcegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcegroup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_bookableresourcegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_bookingstatus"></a> owner_bookingstatus

Many-To-One Relationship: [bookingstatus owner_bookingstatus](bookingstatus.md#BKMK_owner_bookingstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`bookingstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_bookingstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_campaigns"></a> owner_campaigns

Many-To-One Relationship: [campaign owner_campaigns](campaign.md#BKMK_owner_campaigns)

|Property|Value|
|---|---|
|ReferencingEntity|`campaign`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_campaigns`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_characteristic"></a> owner_characteristic

Many-To-One Relationship: [characteristic owner_characteristic](characteristic.md#BKMK_owner_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`characteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_characteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_contracts"></a> owner_contracts

Many-To-One Relationship: [contract owner_contracts](contract.md#BKMK_owner_contracts)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_contracts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Owner_dynamicproperyinstance"></a> Owner_dynamicproperyinstance

Many-To-One Relationship: [dynamicpropertyinstance Owner_dynamicproperyinstance](dynamicpropertyinstance.md#BKMK_Owner_dynamicproperyinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`Owner_dynamicproperyinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_entitlement"></a> owner_entitlement

Many-To-One Relationship: [entitlement owner_entitlement](entitlement.md#BKMK_owner_entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_entitlement`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_entitlemententityallocationtypemapping"></a> owner_entitlemententityallocationtypemapping

Many-To-One Relationship: [entitlemententityallocationtypemapping owner_entitlemententityallocationtypemapping](entitlemententityallocationtypemapping.md#BKMK_owner_entitlemententityallocationtypemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlemententityallocationtypemapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_entitlemententityallocationtypemapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_federatedknowledgeconfiguration"></a> owner_federatedknowledgeconfiguration

Many-To-One Relationship: [federatedknowledgeconfiguration owner_federatedknowledgeconfiguration](federatedknowledgeconfiguration.md#BKMK_owner_federatedknowledgeconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`federatedknowledgeconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_federatedknowledgeconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_federatedknowledgeentityconfiguration"></a> owner_federatedknowledgeentityconfiguration

Many-To-One Relationship: [federatedknowledgeentityconfiguration owner_federatedknowledgeentityconfiguration](federatedknowledgeentityconfiguration.md#BKMK_owner_federatedknowledgeentityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`federatedknowledgeentityconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_federatedknowledgeentityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_incidents"></a> owner_incidents

Many-To-One Relationship: [incident owner_incidents](incident.md#BKMK_owner_incidents)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_incidents`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_invoices"></a> owner_invoices

Many-To-One Relationship: [invoice owner_invoices](invoice.md#BKMK_owner_invoices)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_invoices`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_leads"></a> owner_leads

Many-To-One Relationship: [lead owner_leads](lead.md#BKMK_owner_leads)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_leads`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_listoperation"></a> owner_listoperation

Many-To-One Relationship: [listoperation owner_listoperation](listoperation.md#BKMK_owner_listoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`listoperation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_listoperation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_lists"></a> owner_lists

Many-To-One Relationship: [list owner_lists](list.md#BKMK_owner_lists)

|Property|Value|
|---|---|
|ReferencingEntity|`list`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_lists`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_activitymappingmetadatabase"></a> owner_mscipriv_activitymappingmetadatabase

Many-To-One Relationship: [mscipriv_activitymappingmetadatabase owner_mscipriv_activitymappingmetadatabase](mscipriv_activitymappingmetadatabase.md#BKMK_owner_mscipriv_activitymappingmetadatabase)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_activitymappingmetadatabase`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_activitymappingmetadatabase`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_additionalentityinfo"></a> owner_mscipriv_additionalentityinfo

Many-To-One Relationship: [mscipriv_additionalentityinfo owner_mscipriv_additionalentityinfo](mscipriv_additionalentityinfo.md#BKMK_owner_mscipriv_additionalentityinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_additionalentityinfo`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_additionalentityinfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_aibuildercallbacktesthook"></a> owner_mscipriv_aibuildercallbacktesthook

Many-To-One Relationship: [mscipriv_aibuildercallbacktesthook owner_mscipriv_aibuildercallbacktesthook](mscipriv_aibuildercallbacktesthook.md#BKMK_owner_mscipriv_aibuildercallbacktesthook)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_aibuildercallbacktesthook`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_aibuildercallbacktesthook`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_aibuildermodelmetadata"></a> owner_mscipriv_aibuildermodelmetadata

Many-To-One Relationship: [mscipriv_aibuildermodelmetadata owner_mscipriv_aibuildermodelmetadata](mscipriv_aibuildermodelmetadata.md#BKMK_owner_mscipriv_aibuildermodelmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_aibuildermodelmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_aibuildermodelmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_analysisinstanceconfig"></a> owner_mscipriv_analysisinstanceconfig

Many-To-One Relationship: [mscipriv_analysisinstanceconfig owner_mscipriv_analysisinstanceconfig](mscipriv_analysisinstanceconfig.md#BKMK_owner_mscipriv_analysisinstanceconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_analysisinstanceconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_analysisinstanceconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_analysismetadata"></a> owner_mscipriv_analysismetadata

Many-To-One Relationship: [mscipriv_analysismetadata owner_mscipriv_analysismetadata](mscipriv_analysismetadata.md#BKMK_owner_mscipriv_analysismetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_analysismetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_analysismetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_azuremlwebservice"></a> owner_mscipriv_azuremlwebservice

Many-To-One Relationship: [mscipriv_azuremlwebservice owner_mscipriv_azuremlwebservice](mscipriv_azuremlwebservice.md#BKMK_owner_mscipriv_azuremlwebservice)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_azuremlwebservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_azuremlwebservice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_businessunitconfiguration"></a> owner_mscipriv_businessunitconfiguration

Many-To-One Relationship: [mscipriv_businessunitconfiguration owner_mscipriv_businessunitconfiguration](mscipriv_businessunitconfiguration.md#BKMK_owner_mscipriv_businessunitconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_businessunitconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_businessunitconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_cdsamodelmetadata"></a> owner_mscipriv_cdsamodelmetadata

Many-To-One Relationship: [mscipriv_cdsamodelmetadata owner_mscipriv_cdsamodelmetadata](mscipriv_cdsamodelmetadata.md#BKMK_owner_mscipriv_cdsamodelmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_cdsamodelmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_cdsamodelmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_clusterloadmetadata"></a> owner_mscipriv_clusterloadmetadata

Many-To-One Relationship: [mscipriv_clusterloadmetadata owner_mscipriv_clusterloadmetadata](mscipriv_clusterloadmetadata.md#BKMK_owner_mscipriv_clusterloadmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_clusterloadmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_clusterloadmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_conflationcriteriastatistics"></a> owner_mscipriv_conflationcriteriastatistics

Many-To-One Relationship: [mscipriv_conflationcriteriastatistics owner_mscipriv_conflationcriteriastatistics](mscipriv_conflationcriteriastatistics.md#BKMK_owner_mscipriv_conflationcriteriastatistics)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_conflationcriteriastatistics`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_conflationcriteriastatistics`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_conflationmetadata"></a> owner_mscipriv_conflationmetadata

Many-To-One Relationship: [mscipriv_conflationmetadata owner_mscipriv_conflationmetadata](mscipriv_conflationmetadata.md#BKMK_owner_mscipriv_conflationmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_conflationmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_conflationmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_conflationrun"></a> owner_mscipriv_conflationrun

Many-To-One Relationship: [mscipriv_conflationrun owner_mscipriv_conflationrun](mscipriv_conflationrun.md#BKMK_owner_mscipriv_conflationrun)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_conflationrun`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_conflationrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_conflationstatistics"></a> owner_mscipriv_conflationstatistics

Many-To-One Relationship: [mscipriv_conflationstatistics owner_mscipriv_conflationstatistics](mscipriv_conflationstatistics.md#BKMK_owner_mscipriv_conflationstatistics)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_conflationstatistics`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_conflationstatistics`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_consentsettings"></a> owner_mscipriv_consentsettings

Many-To-One Relationship: [mscipriv_consentsettings owner_mscipriv_consentsettings](mscipriv_consentsettings.md#BKMK_owner_mscipriv_consentsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_consentsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_consentsettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_dataflowmetadata"></a> owner_mscipriv_dataflowmetadata

Many-To-One Relationship: [mscipriv_dataflowmetadata owner_mscipriv_dataflowmetadata](mscipriv_dataflowmetadata.md#BKMK_owner_mscipriv_dataflowmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataflowmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_dataflowmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_datapreparationmetadata"></a> owner_mscipriv_datapreparationmetadata

Many-To-One Relationship: [mscipriv_datapreparationmetadata owner_mscipriv_datapreparationmetadata](mscipriv_datapreparationmetadata.md#BKMK_owner_mscipriv_datapreparationmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_datapreparationmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_datapreparationmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_dataqualityfeaturewisemetadata"></a> owner_mscipriv_dataqualityfeaturewisemetadata

Many-To-One Relationship: [mscipriv_dataqualityfeaturewisemetadata owner_mscipriv_dataqualityfeaturewisemetadata](mscipriv_dataqualityfeaturewisemetadata.md#BKMK_owner_mscipriv_dataqualityfeaturewisemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataqualityfeaturewisemetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_dataqualityfeaturewisemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_dataqualityoverview"></a> owner_mscipriv_dataqualityoverview

Many-To-One Relationship: [mscipriv_dataqualityoverview owner_mscipriv_dataqualityoverview](mscipriv_dataqualityoverview.md#BKMK_owner_mscipriv_dataqualityoverview)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataqualityoverview`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_dataqualityoverview`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_dataqualityreport"></a> owner_mscipriv_dataqualityreport

Many-To-One Relationship: [mscipriv_dataqualityreport owner_mscipriv_dataqualityreport](mscipriv_dataqualityreport.md#BKMK_owner_mscipriv_dataqualityreport)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataqualityreport`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_dataqualityreport`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_datasetcatalog"></a> owner_mscipriv_datasetcatalog

Many-To-One Relationship: [mscipriv_datasetcatalog owner_mscipriv_datasetcatalog](mscipriv_datasetcatalog.md#BKMK_owner_mscipriv_datasetcatalog)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_datasetcatalog`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_datasetcatalog`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_datasourcemetadata"></a> owner_mscipriv_datasourcemetadata

Many-To-One Relationship: [mscipriv_datasourcemetadata owner_mscipriv_datasourcemetadata](mscipriv_datasourcemetadata.md#BKMK_owner_mscipriv_datasourcemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_datasourcemetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_datasourcemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_datatroubleshootingaccess"></a> owner_mscipriv_datatroubleshootingaccess

Many-To-One Relationship: [mscipriv_datatroubleshootingaccess owner_mscipriv_datatroubleshootingaccess](mscipriv_datatroubleshootingaccess.md#BKMK_owner_mscipriv_datatroubleshootingaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_datatroubleshootingaccess`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_datatroubleshootingaccess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_dataverseentitydatacleanupjobinfo"></a> owner_mscipriv_dataverseentitydatacleanupjobinfo

Many-To-One Relationship: [mscipriv_dataverseentitydatacleanupjobinfo owner_mscipriv_dataverseentitydatacleanupjobinfo](mscipriv_dataverseentitydatacleanupjobinfo.md#BKMK_owner_mscipriv_dataverseentitydatacleanupjobinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_dataverseentitydatacleanupjobinfo`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_dataverseentitydatacleanupjobinfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_derivedentitymetadata"></a> owner_mscipriv_derivedentitymetadata

Many-To-One Relationship: [mscipriv_derivedentitymetadata owner_mscipriv_derivedentitymetadata](mscipriv_derivedentitymetadata.md#BKMK_owner_mscipriv_derivedentitymetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_derivedentitymetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_derivedentitymetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_diagnosticsetting"></a> owner_mscipriv_diagnosticsetting

Many-To-One Relationship: [mscipriv_diagnosticsetting owner_mscipriv_diagnosticsetting](mscipriv_diagnosticsetting.md#BKMK_owner_mscipriv_diagnosticsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_diagnosticsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_diagnosticsetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_discoveredcdsamodel"></a> owner_mscipriv_discoveredcdsamodel

Many-To-One Relationship: [mscipriv_discoveredcdsamodel owner_mscipriv_discoveredcdsamodel](mscipriv_discoveredcdsamodel.md#BKMK_owner_mscipriv_discoveredcdsamodel)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_discoveredcdsamodel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_discoveredcdsamodel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_discoveryoperation"></a> owner_mscipriv_discoveryoperation

Many-To-One Relationship: [mscipriv_discoveryoperation owner_mscipriv_discoveryoperation](mscipriv_discoveryoperation.md#BKMK_owner_mscipriv_discoveryoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_discoveryoperation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_discoveryoperation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_enrichmentmetadata"></a> owner_mscipriv_enrichmentmetadata

Many-To-One Relationship: [mscipriv_enrichmentmetadata owner_mscipriv_enrichmentmetadata](mscipriv_enrichmentmetadata.md#BKMK_owner_mscipriv_enrichmentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_enrichmentmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_enrichmentmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_enrichmentrun"></a> owner_mscipriv_enrichmentrun

Many-To-One Relationship: [mscipriv_enrichmentrun owner_mscipriv_enrichmentrun](mscipriv_enrichmentrun.md#BKMK_owner_mscipriv_enrichmentrun)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_enrichmentrun`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_enrichmentrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_entityfiltermetadata"></a> owner_mscipriv_entityfiltermetadata

Many-To-One Relationship: [mscipriv_entityfiltermetadata owner_mscipriv_entityfiltermetadata](mscipriv_entityfiltermetadata.md#BKMK_owner_mscipriv_entityfiltermetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_entityfiltermetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_entityfiltermetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_exportconfig"></a> owner_mscipriv_exportconfig

Many-To-One Relationship: [mscipriv_exportconfig owner_mscipriv_exportconfig](mscipriv_exportconfig.md#BKMK_owner_mscipriv_exportconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_exportconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_exportconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_exportconfigreport"></a> owner_mscipriv_exportconfigreport

Many-To-One Relationship: [mscipriv_exportconfigreport owner_mscipriv_exportconfigreport](mscipriv_exportconfigreport.md#BKMK_owner_mscipriv_exportconfigreport)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_exportconfigreport`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_exportconfigreport`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_exportedmoduleconfiguration"></a> owner_mscipriv_exportedmoduleconfiguration

Many-To-One Relationship: [mscipriv_exportedmoduleconfiguration owner_mscipriv_exportedmoduleconfiguration](mscipriv_exportedmoduleconfiguration.md#BKMK_owner_mscipriv_exportedmoduleconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_exportedmoduleconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_exportedmoduleconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_exportsettings"></a> owner_mscipriv_exportsettings

Many-To-One Relationship: [mscipriv_exportsettings owner_mscipriv_exportsettings](mscipriv_exportsettings.md#BKMK_owner_mscipriv_exportsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_exportsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_exportsettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_featuretemplate"></a> owner_mscipriv_featuretemplate

Many-To-One Relationship: [mscipriv_featuretemplate owner_mscipriv_featuretemplate](mscipriv_featuretemplate.md#BKMK_owner_mscipriv_featuretemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_featuretemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_featuretemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_graphmetadata"></a> owner_mscipriv_graphmetadata

Many-To-One Relationship: [mscipriv_graphmetadata owner_mscipriv_graphmetadata](mscipriv_graphmetadata.md#BKMK_owner_mscipriv_graphmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_graphmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_graphmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_hierarchymetadata"></a> owner_mscipriv_hierarchymetadata

Many-To-One Relationship: [mscipriv_hierarchymetadata owner_mscipriv_hierarchymetadata](mscipriv_hierarchymetadata.md#BKMK_owner_mscipriv_hierarchymetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_hierarchymetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_hierarchymetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_hostloadmetadata"></a> owner_mscipriv_hostloadmetadata

Many-To-One Relationship: [mscipriv_hostloadmetadata owner_mscipriv_hostloadmetadata](mscipriv_hostloadmetadata.md#BKMK_owner_mscipriv_hostloadmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_hostloadmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_hostloadmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_importexportstatusmetadata"></a> owner_mscipriv_importexportstatusmetadata

Many-To-One Relationship: [mscipriv_importexportstatusmetadata owner_mscipriv_importexportstatusmetadata](mscipriv_importexportstatusmetadata.md#BKMK_owner_mscipriv_importexportstatusmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_importexportstatusmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_importexportstatusmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_insightmetadata"></a> owner_mscipriv_insightmetadata

Many-To-One Relationship: [mscipriv_insightmetadata owner_mscipriv_insightmetadata](mscipriv_insightmetadata.md#BKMK_owner_mscipriv_insightmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_insightmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_insightmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_insightsdataqualityreport"></a> owner_mscipriv_insightsdataqualityreport

Many-To-One Relationship: [mscipriv_insightsdataqualityreport owner_mscipriv_insightsdataqualityreport](mscipriv_insightsdataqualityreport.md#BKMK_owner_mscipriv_insightsdataqualityreport)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_insightsdataqualityreport`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_insightsdataqualityreport`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_instancemetrics"></a> owner_mscipriv_instancemetrics

Many-To-One Relationship: [mscipriv_instancemetrics owner_mscipriv_instancemetrics](mscipriv_instancemetrics.md#BKMK_owner_mscipriv_instancemetrics)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_instancemetrics`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_instancemetrics`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_instancepartnercatalog"></a> owner_mscipriv_instancepartnercatalog

Many-To-One Relationship: [mscipriv_instancepartnercatalog owner_mscipriv_instancepartnercatalog](mscipriv_instancepartnercatalog.md#BKMK_owner_mscipriv_instancepartnercatalog)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_instancepartnercatalog`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_instancepartnercatalog`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_instancesearchconfiguration"></a> owner_mscipriv_instancesearchconfiguration

Many-To-One Relationship: [mscipriv_instancesearchconfiguration owner_mscipriv_instancesearchconfiguration](mscipriv_instancesearchconfiguration.md#BKMK_owner_mscipriv_instancesearchconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_instancesearchconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_instancesearchconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_instancesettings"></a> owner_mscipriv_instancesettings

Many-To-One Relationship: [mscipriv_instancesettings owner_mscipriv_instancesettings](mscipriv_instancesettings.md#BKMK_owner_mscipriv_instancesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_instancesettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_instancesettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_intelligenceworkflowmetadata"></a> owner_mscipriv_intelligenceworkflowmetadata

Many-To-One Relationship: [mscipriv_intelligenceworkflowmetadata owner_mscipriv_intelligenceworkflowmetadata](mscipriv_intelligenceworkflowmetadata.md#BKMK_owner_mscipriv_intelligenceworkflowmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_intelligenceworkflowmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_intelligenceworkflowmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_intelligenceworkflowrunmetadata"></a> owner_mscipriv_intelligenceworkflowrunmetadata

Many-To-One Relationship: [mscipriv_intelligenceworkflowrunmetadata owner_mscipriv_intelligenceworkflowrunmetadata](mscipriv_intelligenceworkflowrunmetadata.md#BKMK_owner_mscipriv_intelligenceworkflowrunmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_intelligenceworkflowrunmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_intelligenceworkflowrunmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_intelligenceworkspacemetadata"></a> owner_mscipriv_intelligenceworkspacemetadata

Many-To-One Relationship: [mscipriv_intelligenceworkspacemetadata owner_mscipriv_intelligenceworkspacemetadata](mscipriv_intelligenceworkspacemetadata.md#BKMK_owner_mscipriv_intelligenceworkspacemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_intelligenceworkspacemetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_intelligenceworkspacemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_keyvaultmetadata"></a> owner_mscipriv_keyvaultmetadata

Many-To-One Relationship: [mscipriv_keyvaultmetadata owner_mscipriv_keyvaultmetadata](mscipriv_keyvaultmetadata.md#BKMK_owner_mscipriv_keyvaultmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_keyvaultmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_keyvaultmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_lightcdsamodelmetadata"></a> owner_mscipriv_lightcdsamodelmetadata

Many-To-One Relationship: [mscipriv_lightcdsamodelmetadata owner_mscipriv_lightcdsamodelmetadata](mscipriv_lightcdsamodelmetadata.md#BKMK_owner_mscipriv_lightcdsamodelmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_lightcdsamodelmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_lightcdsamodelmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_logicappssubscribermetadata"></a> owner_mscipriv_logicappssubscribermetadata

Many-To-One Relationship: [mscipriv_logicappssubscribermetadata owner_mscipriv_logicappssubscribermetadata](mscipriv_logicappssubscribermetadata.md#BKMK_owner_mscipriv_logicappssubscribermetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_logicappssubscribermetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_logicappssubscribermetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_mappedsecretmetadata"></a> owner_mscipriv_mappedsecretmetadata

Many-To-One Relationship: [mscipriv_mappedsecretmetadata owner_mscipriv_mappedsecretmetadata](mscipriv_mappedsecretmetadata.md#BKMK_owner_mscipriv_mappedsecretmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_mappedsecretmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_mappedsecretmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_measuremetadata"></a> owner_mscipriv_measuremetadata

Many-To-One Relationship: [mscipriv_measuremetadata owner_mscipriv_measuremetadata](mscipriv_measuremetadata.md#BKMK_owner_mscipriv_measuremetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_measuremetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_measuremetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_modelconfigmetadata"></a> owner_mscipriv_modelconfigmetadata

Many-To-One Relationship: [mscipriv_modelconfigmetadata owner_mscipriv_modelconfigmetadata](mscipriv_modelconfigmetadata.md#BKMK_owner_mscipriv_modelconfigmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_modelconfigmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_modelconfigmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_moduleconfigurationreference"></a> owner_mscipriv_moduleconfigurationreference

Many-To-One Relationship: [mscipriv_moduleconfigurationreference owner_mscipriv_moduleconfigurationreference](mscipriv_moduleconfigurationreference.md#BKMK_owner_mscipriv_moduleconfigurationreference)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_moduleconfigurationreference`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_moduleconfigurationreference`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_notificationcheckpoint"></a> owner_mscipriv_notificationcheckpoint

Many-To-One Relationship: [mscipriv_notificationcheckpoint owner_mscipriv_notificationcheckpoint](mscipriv_notificationcheckpoint.md#BKMK_owner_mscipriv_notificationcheckpoint)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_notificationcheckpoint`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_notificationcheckpoint`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_packageimportmetadata"></a> owner_mscipriv_packageimportmetadata

Many-To-One Relationship: [mscipriv_packageimportmetadata owner_mscipriv_packageimportmetadata](mscipriv_packageimportmetadata.md#BKMK_owner_mscipriv_packageimportmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_packageimportmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_packageimportmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_packagejobmetadata"></a> owner_mscipriv_packagejobmetadata

Many-To-One Relationship: [mscipriv_packagejobmetadata owner_mscipriv_packagejobmetadata](mscipriv_packagejobmetadata.md#BKMK_owner_mscipriv_packagejobmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_packagejobmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_packagejobmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_packagemetadata"></a> owner_mscipriv_packagemetadata

Many-To-One Relationship: [mscipriv_packagemetadata owner_mscipriv_packagemetadata](mscipriv_packagemetadata.md#BKMK_owner_mscipriv_packagemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_packagemetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_packagemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_platforminstancemapping"></a> owner_mscipriv_platforminstancemapping

Many-To-One Relationship: [mscipriv_platforminstancemapping owner_mscipriv_platforminstancemapping](mscipriv_platforminstancemapping.md#BKMK_owner_mscipriv_platforminstancemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_platforminstancemapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_platforminstancemapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_powerplatformconnector"></a> owner_mscipriv_powerplatformconnector

Many-To-One Relationship: [mscipriv_powerplatformconnector owner_mscipriv_powerplatformconnector](mscipriv_powerplatformconnector.md#BKMK_owner_mscipriv_powerplatformconnector)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_powerplatformconnector`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_powerplatformconnector`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_powerplatformrefreshsignalmetadata"></a> owner_mscipriv_powerplatformrefreshsignalmetadata

Many-To-One Relationship: [mscipriv_powerplatformrefreshsignalmetadata owner_mscipriv_powerplatformrefreshsignalmetadata](mscipriv_powerplatformrefreshsignalmetadata.md#BKMK_owner_mscipriv_powerplatformrefreshsignalmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_powerplatformrefreshsignalmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_powerplatformrefreshsignalmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_preenrichmentmetadata"></a> owner_mscipriv_preenrichmentmetadata

Many-To-One Relationship: [mscipriv_preenrichmentmetadata owner_mscipriv_preenrichmentmetadata](mscipriv_preenrichmentmetadata.md#BKMK_owner_mscipriv_preenrichmentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_preenrichmentmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_preenrichmentmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_profilestorestateinfo"></a> owner_mscipriv_profilestorestateinfo

Many-To-One Relationship: [mscipriv_profilestorestateinfo owner_mscipriv_profilestorestateinfo](mscipriv_profilestorestateinfo.md#BKMK_owner_mscipriv_profilestorestateinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_profilestorestateinfo`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_profilestorestateinfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_realtimeaggregatedstats"></a> owner_mscipriv_realtimeaggregatedstats

Many-To-One Relationship: [mscipriv_realtimeaggregatedstats owner_mscipriv_realtimeaggregatedstats](mscipriv_realtimeaggregatedstats.md#BKMK_owner_mscipriv_realtimeaggregatedstats)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimeaggregatedstats`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_realtimeaggregatedstats`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_realtimem3configuration"></a> owner_mscipriv_realtimem3configuration

Many-To-One Relationship: [mscipriv_realtimem3configuration owner_mscipriv_realtimem3configuration](mscipriv_realtimem3configuration.md#BKMK_owner_mscipriv_realtimem3configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimem3configuration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_realtimem3configuration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_realtimem3searchconfiguration"></a> owner_mscipriv_realtimem3searchconfiguration

Many-To-One Relationship: [mscipriv_realtimem3searchconfiguration owner_mscipriv_realtimem3searchconfiguration](mscipriv_realtimem3searchconfiguration.md#BKMK_owner_mscipriv_realtimem3searchconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimem3searchconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_realtimem3searchconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_realtimepluginmetadata"></a> owner_mscipriv_realtimepluginmetadata

Many-To-One Relationship: [mscipriv_realtimepluginmetadata owner_mscipriv_realtimepluginmetadata](mscipriv_realtimepluginmetadata.md#BKMK_owner_mscipriv_realtimepluginmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimepluginmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_realtimepluginmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_realtimesystemtablemetadata"></a> owner_mscipriv_realtimesystemtablemetadata

Many-To-One Relationship: [mscipriv_realtimesystemtablemetadata owner_mscipriv_realtimesystemtablemetadata](mscipriv_realtimesystemtablemetadata.md#BKMK_owner_mscipriv_realtimesystemtablemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimesystemtablemetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_realtimesystemtablemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_realtimetablemetadata"></a> owner_mscipriv_realtimetablemetadata

Many-To-One Relationship: [mscipriv_realtimetablemetadata owner_mscipriv_realtimetablemetadata](mscipriv_realtimetablemetadata.md#BKMK_owner_mscipriv_realtimetablemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_realtimetablemetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_realtimetablemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_refreshhistorymetadata"></a> owner_mscipriv_refreshhistorymetadata

Many-To-One Relationship: [mscipriv_refreshhistorymetadata owner_mscipriv_refreshhistorymetadata](mscipriv_refreshhistorymetadata.md#BKMK_owner_mscipriv_refreshhistorymetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_refreshhistorymetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_refreshhistorymetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_refreshschedulebase"></a> owner_mscipriv_refreshschedulebase

Many-To-One Relationship: [mscipriv_refreshschedulebase owner_mscipriv_refreshschedulebase](mscipriv_refreshschedulebase.md#BKMK_owner_mscipriv_refreshschedulebase)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_refreshschedulebase`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_refreshschedulebase`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_refreshstatehistorymetadata"></a> owner_mscipriv_refreshstatehistorymetadata

Many-To-One Relationship: [mscipriv_refreshstatehistorymetadata owner_mscipriv_refreshstatehistorymetadata](mscipriv_refreshstatehistorymetadata.md#BKMK_owner_mscipriv_refreshstatehistorymetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_refreshstatehistorymetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_refreshstatehistorymetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_relationshipmetadata"></a> owner_mscipriv_relationshipmetadata

Many-To-One Relationship: [mscipriv_relationshipmetadata owner_mscipriv_relationshipmetadata](mscipriv_relationshipmetadata.md#BKMK_owner_mscipriv_relationshipmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_relationshipmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_relationshipmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_reportmetadata"></a> owner_mscipriv_reportmetadata

Many-To-One Relationship: [mscipriv_reportmetadata owner_mscipriv_reportmetadata](mscipriv_reportmetadata.md#BKMK_owner_mscipriv_reportmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_reportmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_reportmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_resetinstancehistory"></a> owner_mscipriv_resetinstancehistory

Many-To-One Relationship: [mscipriv_resetinstancehistory owner_mscipriv_resetinstancehistory](mscipriv_resetinstancehistory.md#BKMK_owner_mscipriv_resetinstancehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_resetinstancehistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_resetinstancehistory`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_resourcemetadata"></a> owner_mscipriv_resourcemetadata

Many-To-One Relationship: [mscipriv_resourcemetadata owner_mscipriv_resourcemetadata](mscipriv_resourcemetadata.md#BKMK_owner_mscipriv_resourcemetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_resourcemetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_resourcemetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_runtimerealtimem3metadata"></a> owner_mscipriv_runtimerealtimem3metadata

Many-To-One Relationship: [mscipriv_runtimerealtimem3metadata owner_mscipriv_runtimerealtimem3metadata](mscipriv_runtimerealtimem3metadata.md#BKMK_owner_mscipriv_runtimerealtimem3metadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_runtimerealtimem3metadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_runtimerealtimem3metadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_segmentmetadata"></a> owner_mscipriv_segmentmetadata

Many-To-One Relationship: [mscipriv_segmentmetadata owner_mscipriv_segmentmetadata](mscipriv_segmentmetadata.md#BKMK_owner_mscipriv_segmentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_segmentmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_segmentmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_semanticentitymappingmetadata"></a> owner_mscipriv_semanticentitymappingmetadata

Many-To-One Relationship: [mscipriv_semanticentitymappingmetadata owner_mscipriv_semanticentitymappingmetadata](mscipriv_semanticentitymappingmetadata.md#BKMK_owner_mscipriv_semanticentitymappingmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_semanticentitymappingmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_semanticentitymappingmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_sparkjobexecutionmetadata"></a> owner_mscipriv_sparkjobexecutionmetadata

Many-To-One Relationship: [mscipriv_sparkjobexecutionmetadata owner_mscipriv_sparkjobexecutionmetadata](mscipriv_sparkjobexecutionmetadata.md#BKMK_owner_mscipriv_sparkjobexecutionmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_sparkjobexecutionmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_sparkjobexecutionmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_systemintegrationmigrationtrackinginfo"></a> owner_mscipriv_systemintegrationmigrationtrackinginfo

Many-To-One Relationship: [mscipriv_systemintegrationmigrationtrackinginfo owner_mscipriv_systemintegrationmigrationtrackinginfo](mscipriv_systemintegrationmigrationtrackinginfo.md#BKMK_owner_mscipriv_systemintegrationmigrationtrackinginfo)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_systemintegrationmigrationtrackinginfo`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_systemintegrationmigrationtrackinginfo`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_templatedmeasuremetadata"></a> owner_mscipriv_templatedmeasuremetadata

Many-To-One Relationship: [mscipriv_templatedmeasuremetadata owner_mscipriv_templatedmeasuremetadata](mscipriv_templatedmeasuremetadata.md#BKMK_owner_mscipriv_templatedmeasuremetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_templatedmeasuremetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_templatedmeasuremetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_templatedsegmentmetadata"></a> owner_mscipriv_templatedsegmentmetadata

Many-To-One Relationship: [mscipriv_templatedsegmentmetadata owner_mscipriv_templatedsegmentmetadata](mscipriv_templatedsegmentmetadata.md#BKMK_owner_mscipriv_templatedsegmentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_templatedsegmentmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_templatedsegmentmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_transformmetadata"></a> owner_mscipriv_transformmetadata

Many-To-One Relationship: [mscipriv_transformmetadata owner_mscipriv_transformmetadata](mscipriv_transformmetadata.md#BKMK_owner_mscipriv_transformmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_transformmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_transformmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_mscipriv_unifiedactivitymappinggroupmetadata"></a> owner_mscipriv_unifiedactivitymappinggroupmetadata

Many-To-One Relationship: [mscipriv_unifiedactivitymappinggroupmetadata owner_mscipriv_unifiedactivitymappinggroupmetadata](mscipriv_unifiedactivitymappinggroupmetadata.md#BKMK_owner_mscipriv_unifiedactivitymappinggroupmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`mscipriv_unifiedactivitymappinggroupmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_mscipriv_unifiedactivitymappinggroupmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_actioncardactionstat"></a> owner_msdyn_actioncardactionstat

Many-To-One Relationship: [msdyn_actioncardactionstat owner_msdyn_actioncardactionstat](msdyn_actioncardactionstat.md#BKMK_owner_msdyn_actioncardactionstat)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardactionstat`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_actioncardactionstat`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_actioncardregarding"></a> owner_msdyn_actioncardregarding

Many-To-One Relationship: [msdyn_actioncardregarding owner_msdyn_actioncardregarding](msdyn_actioncardregarding.md#BKMK_owner_msdyn_actioncardregarding)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardregarding`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_actioncardregarding`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_actioncardrolesetting"></a> owner_msdyn_actioncardrolesetting

Many-To-One Relationship: [msdyn_actioncardrolesetting owner_msdyn_actioncardrolesetting](msdyn_actioncardrolesetting.md#BKMK_owner_msdyn_actioncardrolesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardrolesetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_actioncardrolesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_actioncardstataggregation"></a> owner_msdyn_actioncardstataggregation

Many-To-One Relationship: [msdyn_actioncardstataggregation owner_msdyn_actioncardstataggregation](msdyn_actioncardstataggregation.md#BKMK_owner_msdyn_actioncardstataggregation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardstataggregation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_actioncardstataggregation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_activeicdextension"></a> owner_msdyn_activeicdextension

Many-To-One Relationship: [msdyn_activeicdextension owner_msdyn_activeicdextension](msdyn_activeicdextension.md#BKMK_owner_msdyn_activeicdextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_activeicdextension`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_activeicdextension`|
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

### <a name="BKMK_owner_msdyn_adminappstate"></a> owner_msdyn_adminappstate

Many-To-One Relationship: [msdyn_adminappstate owner_msdyn_adminappstate](msdyn_adminappstate.md#BKMK_owner_msdyn_adminappstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_adminappstate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_adminappstate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentcapacityprofileunit"></a> owner_msdyn_agentcapacityprofileunit

Many-To-One Relationship: [msdyn_agentcapacityprofileunit owner_msdyn_agentcapacityprofileunit](msdyn_agentcapacityprofileunit.md#BKMK_owner_msdyn_agentcapacityprofileunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentcapacityprofileunit`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentcapacityprofileunit`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentcapacityupdatehistory"></a> owner_msdyn_agentcapacityupdatehistory

Many-To-One Relationship: [msdyn_agentcapacityupdatehistory owner_msdyn_agentcapacityupdatehistory](msdyn_agentcapacityupdatehistory.md#BKMK_owner_msdyn_agentcapacityupdatehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentcapacityupdatehistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentcapacityupdatehistory`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentchannelstate"></a> owner_msdyn_agentchannelstate

Many-To-One Relationship: [msdyn_agentchannelstate owner_msdyn_agentchannelstate](msdyn_agentchannelstate.md#BKMK_owner_msdyn_agentchannelstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentchannelstate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentchannelstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentstatus"></a> owner_msdyn_agentstatus

Many-To-One Relationship: [msdyn_agentstatus owner_msdyn_agentstatus](msdyn_agentstatus.md#BKMK_owner_msdyn_agentstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentstatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentstatushistory"></a> owner_msdyn_agentstatushistory

Many-To-One Relationship: [msdyn_agentstatushistory owner_msdyn_agentstatushistory](msdyn_agentstatushistory.md#BKMK_owner_msdyn_agentstatushistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentstatushistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentstatushistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreement"></a> owner_msdyn_agreement

Many-To-One Relationship: [msdyn_agreement owner_msdyn_agreement](msdyn_agreement.md#BKMK_owner_msdyn_agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingdate"></a> owner_msdyn_agreementbookingdate

Many-To-One Relationship: [msdyn_agreementbookingdate owner_msdyn_agreementbookingdate](msdyn_agreementbookingdate.md#BKMK_owner_msdyn_agreementbookingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingincident"></a> owner_msdyn_agreementbookingincident

Many-To-One Relationship: [msdyn_agreementbookingincident owner_msdyn_agreementbookingincident](msdyn_agreementbookingincident.md#BKMK_owner_msdyn_agreementbookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingproduct"></a> owner_msdyn_agreementbookingproduct

Many-To-One Relationship: [msdyn_agreementbookingproduct owner_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_owner_msdyn_agreementbookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingservice"></a> owner_msdyn_agreementbookingservice

Many-To-One Relationship: [msdyn_agreementbookingservice owner_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_owner_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingservicetask"></a> owner_msdyn_agreementbookingservicetask

Many-To-One Relationship: [msdyn_agreementbookingservicetask owner_msdyn_agreementbookingservicetask](msdyn_agreementbookingservicetask.md#BKMK_owner_msdyn_agreementbookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementbookingsetup"></a> owner_msdyn_agreementbookingsetup

Many-To-One Relationship: [msdyn_agreementbookingsetup owner_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_owner_msdyn_agreementbookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingsetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementbookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementinvoicedate"></a> owner_msdyn_agreementinvoicedate

Many-To-One Relationship: [msdyn_agreementinvoicedate owner_msdyn_agreementinvoicedate](msdyn_agreementinvoicedate.md#BKMK_owner_msdyn_agreementinvoicedate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicedate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementinvoicedate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementinvoiceproduct"></a> owner_msdyn_agreementinvoiceproduct

Many-To-One Relationship: [msdyn_agreementinvoiceproduct owner_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_owner_msdyn_agreementinvoiceproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementinvoiceproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementinvoicesetup"></a> owner_msdyn_agreementinvoicesetup

Many-To-One Relationship: [msdyn_agreementinvoicesetup owner_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_owner_msdyn_agreementinvoicesetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicesetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementinvoicesetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agreementsubstatus"></a> owner_msdyn_agreementsubstatus

Many-To-One Relationship: [msdyn_agreementsubstatus owner_msdyn_agreementsubstatus](msdyn_agreementsubstatus.md#BKMK_owner_msdyn_agreementsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementsubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agreementsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_aicontactsuggestion"></a> owner_msdyn_aicontactsuggestion

Many-To-One Relationship: [msdyn_aicontactsuggestion owner_msdyn_aicontactsuggestion](msdyn_aicontactsuggestion.md#BKMK_owner_msdyn_aicontactsuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aicontactsuggestion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_aicontactsuggestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_analytics"></a> owner_msdyn_analytics

Many-To-One Relationship: [msdyn_analytics owner_msdyn_analytics](msdyn_analytics.md#BKMK_owner_msdyn_analytics)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_analytics`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_analytics`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_analyticsadminsettings"></a> owner_msdyn_analyticsadminsettings

Many-To-One Relationship: [msdyn_analyticsadminsettings owner_msdyn_analyticsadminsettings](msdyn_analyticsadminsettings.md#BKMK_owner_msdyn_analyticsadminsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_analyticsadminsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_analyticsadminsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_analyticsforcs"></a> owner_msdyn_analyticsforcs

Many-To-One Relationship: [msdyn_analyticsforcs owner_msdyn_analyticsforcs](msdyn_analyticsforcs.md#BKMK_owner_msdyn_analyticsforcs)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_analyticsforcs`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_analyticsforcs`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_appconfiguration"></a> owner_msdyn_appconfiguration

Many-To-One Relationship: [msdyn_appconfiguration owner_msdyn_appconfiguration](msdyn_appconfiguration.md#BKMK_owner_msdyn_appconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_appconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_applicationextension"></a> owner_msdyn_applicationextension

Many-To-One Relationship: [msdyn_applicationextension owner_msdyn_applicationextension](msdyn_applicationextension.md#BKMK_owner_msdyn_applicationextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_applicationextension`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_applicationextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_applicationtabtemplate"></a> owner_msdyn_applicationtabtemplate

Many-To-One Relationship: [msdyn_applicationtabtemplate owner_msdyn_applicationtabtemplate](msdyn_applicationtabtemplate.md#BKMK_owner_msdyn_applicationtabtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_applicationtabtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_applicationtabtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_appprofilerolemapping"></a> owner_msdyn_appprofilerolemapping

Many-To-One Relationship: [msdyn_appprofilerolemapping owner_msdyn_appprofilerolemapping](msdyn_appprofilerolemapping.md#BKMK_owner_msdyn_appprofilerolemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appprofilerolemapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_appprofilerolemapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_appstate"></a> owner_msdyn_appstate

Many-To-One Relationship: [msdyn_appstate owner_msdyn_appstate](msdyn_appstate.md#BKMK_owner_msdyn_appstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appstate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_appstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_assetcategorytemplateassociation"></a> owner_msdyn_assetcategorytemplateassociation

Many-To-One Relationship: [msdyn_assetcategorytemplateassociation owner_msdyn_assetcategorytemplateassociation](msdyn_assetcategorytemplateassociation.md#BKMK_owner_msdyn_assetcategorytemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assetcategorytemplateassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_assetcategorytemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_assettemplateassociation"></a> owner_msdyn_assettemplateassociation

Many-To-One Relationship: [msdyn_assettemplateassociation owner_msdyn_assettemplateassociation](msdyn_assettemplateassociation.md#BKMK_owner_msdyn_assettemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assettemplateassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_assettemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_assignmentconfiguration"></a> owner_msdyn_assignmentconfiguration

Many-To-One Relationship: [msdyn_assignmentconfiguration owner_msdyn_assignmentconfiguration](msdyn_assignmentconfiguration.md#BKMK_owner_msdyn_assignmentconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_assignmentconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_assignmentconfigurationstep"></a> owner_msdyn_assignmentconfigurationstep

Many-To-One Relationship: [msdyn_assignmentconfigurationstep owner_msdyn_assignmentconfigurationstep](msdyn_assignmentconfigurationstep.md#BKMK_owner_msdyn_assignmentconfigurationstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentconfigurationstep`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_assignmentconfigurationstep`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_assignmentmap"></a> owner_msdyn_assignmentmap

Many-To-One Relationship: [msdyn_assignmentmap owner_msdyn_assignmentmap](msdyn_assignmentmap.md#BKMK_owner_msdyn_assignmentmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentmap`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_assignmentmap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_assignmentrule"></a> owner_msdyn_assignmentrule

Many-To-One Relationship: [msdyn_assignmentrule owner_msdyn_assignmentrule](msdyn_assignmentrule.md#BKMK_owner_msdyn_assignmentrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_assignmentrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_attribute"></a> owner_msdyn_attribute

Many-To-One Relationship: [msdyn_attribute owner_msdyn_attribute](msdyn_attribute.md#BKMK_owner_msdyn_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_attribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_attribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_attributevalue"></a> owner_msdyn_attributevalue

Many-To-One Relationship: [msdyn_attributevalue owner_msdyn_attributevalue](msdyn_attributevalue.md#BKMK_owner_msdyn_attributevalue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_attributevalue`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_attributevalue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_authenticationsettings"></a> owner_msdyn_authenticationsettings

Many-To-One Relationship: [msdyn_authenticationsettings owner_msdyn_authenticationsettings](msdyn_authenticationsettings.md#BKMK_owner_msdyn_authenticationsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_authenticationsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_authenticationsettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_authsettingsentry"></a> owner_msdyn_authsettingsentry

Many-To-One Relationship: [msdyn_authsettingsentry owner_msdyn_authsettingsentry](msdyn_authsettingsentry.md#BKMK_owner_msdyn_authsettingsentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_authsettingsentry`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_authsettingsentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_autocapturerule"></a> owner_msdyn_autocapturerule

Many-To-One Relationship: [msdyn_autocapturerule owner_msdyn_autocapturerule](msdyn_autocapturerule.md#BKMK_owner_msdyn_autocapturerule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autocapturerule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_autocapturerule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_autocapturesettings"></a> owner_msdyn_autocapturesettings

Many-To-One Relationship: [msdyn_autocapturesettings owner_msdyn_autocapturesettings](msdyn_autocapturesettings.md#BKMK_owner_msdyn_autocapturesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autocapturesettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_autocapturesettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_autonomouscasecreationrule"></a> owner_msdyn_autonomouscasecreationrule

Many-To-One Relationship: [msdyn_autonomouscasecreationrule owner_msdyn_autonomouscasecreationrule](msdyn_autonomouscasecreationrule.md#BKMK_owner_msdyn_autonomouscasecreationrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autonomouscasecreationrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_autonomouscasecreationrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bgjobledger"></a> owner_msdyn_bgjobledger

Many-To-One Relationship: [msdyn_bgjobledger owner_msdyn_bgjobledger](msdyn_bgjobledger.md#BKMK_owner_msdyn_bgjobledger)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bgjobledger`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bgjobledger`|
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

### <a name="BKMK_owner_msdyn_bookableresourcebookingquicknote"></a> owner_msdyn_bookableresourcebookingquicknote

Many-To-One Relationship: [msdyn_bookableresourcebookingquicknote owner_msdyn_bookableresourcebookingquicknote](msdyn_bookableresourcebookingquicknote.md#BKMK_owner_msdyn_bookableresourcebookingquicknote)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcebookingquicknote`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookableresourcebookingquicknote`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_bookableresourcecapacityprofile"></a> owner_msdyn_bookableresourcecapacityprofile

Many-To-One Relationship: [msdyn_bookableresourcecapacityprofile owner_msdyn_bookableresourcecapacityprofile](msdyn_bookableresourcecapacityprofile.md#BKMK_owner_msdyn_bookableresourcecapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcecapacityprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookableresourcecapacityprofile`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_bookingjournal"></a> owner_msdyn_bookingjournal

Many-To-One Relationship: [msdyn_bookingjournal owner_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_owner_msdyn_bookingjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingjournal`|
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

### <a name="BKMK_owner_msdyn_bookingtimestamp"></a> owner_msdyn_bookingtimestamp

Many-To-One Relationship: [msdyn_bookingtimestamp owner_msdyn_bookingtimestamp](msdyn_bookingtimestamp.md#BKMK_owner_msdyn_bookingtimestamp)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingtimestamp`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookingtimestamp`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_botsession"></a> owner_msdyn_botsession

Many-To-One Relationship: [msdyn_botsession owner_msdyn_botsession](msdyn_botsession.md#BKMK_owner_msdyn_botsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_botsession`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_botsession`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_callablecontext"></a> owner_msdyn_callablecontext

Many-To-One Relationship: [msdyn_callablecontext owner_msdyn_callablecontext](msdyn_callablecontext.md#BKMK_owner_msdyn_callablecontext)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_callablecontext`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_callablecontext`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_capacityprofile"></a> owner_msdyn_capacityprofile

Many-To-One Relationship: [msdyn_capacityprofile owner_msdyn_capacityprofile](msdyn_capacityprofile.md#BKMK_owner_msdyn_capacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_capacityprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_capacityprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_cdsentityengagementctx"></a> owner_msdyn_cdsentityengagementctx

Many-To-One Relationship: [msdyn_cdsentityengagementctx owner_msdyn_cdsentityengagementctx](msdyn_cdsentityengagementctx.md#BKMK_owner_msdyn_cdsentityengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_cdsentityengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_cdsentityengagementctx`|
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

### <a name="BKMK_owner_msdyn_channeldefinition"></a> owner_msdyn_channeldefinition

Many-To-One Relationship: [msdyn_channeldefinition owner_msdyn_channeldefinition](msdyn_channeldefinition.md#BKMK_owner_msdyn_channeldefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channeldefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channeldefinitionconsent"></a> owner_msdyn_channeldefinitionconsent

Many-To-One Relationship: [msdyn_channeldefinitionconsent owner_msdyn_channeldefinitionconsent](msdyn_channeldefinitionconsent.md#BKMK_owner_msdyn_channeldefinitionconsent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinitionconsent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channeldefinitionconsent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channeldefinitionlocale"></a> owner_msdyn_channeldefinitionlocale

Many-To-One Relationship: [msdyn_channeldefinitionlocale owner_msdyn_channeldefinitionlocale](msdyn_channeldefinitionlocale.md#BKMK_owner_msdyn_channeldefinitionlocale)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinitionlocale`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channeldefinitionlocale`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channelinstance"></a> owner_msdyn_channelinstance

Many-To-One Relationship: [msdyn_channelinstance owner_msdyn_channelinstance](msdyn_channelinstance.md#BKMK_owner_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channelinstanceaccount"></a> owner_msdyn_channelinstanceaccount

Many-To-One Relationship: [msdyn_channelinstanceaccount owner_msdyn_channelinstanceaccount](msdyn_channelinstanceaccount.md#BKMK_owner_msdyn_channelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channelmessageattachment"></a> owner_msdyn_channelmessageattachment

Many-To-One Relationship: [msdyn_channelmessageattachment owner_msdyn_channelmessageattachment](msdyn_channelmessageattachment.md#BKMK_owner_msdyn_channelmessageattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessageattachment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channelmessageattachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channelmessagecontextpart"></a> owner_msdyn_channelmessagecontextpart

Many-To-One Relationship: [msdyn_channelmessagecontextpart owner_msdyn_channelmessagecontextpart](msdyn_channelmessagecontextpart.md#BKMK_owner_msdyn_channelmessagecontextpart)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessagecontextpart`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channelmessagecontextpart`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channelmessagepart"></a> owner_msdyn_channelmessagepart

Many-To-One Relationship: [msdyn_channelmessagepart owner_msdyn_channelmessagepart](msdyn_channelmessagepart.md#BKMK_owner_msdyn_channelmessagepart)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessagepart`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channelmessagepart`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_channelprovider"></a> owner_msdyn_channelprovider

Many-To-One Relationship: [msdyn_channelprovider owner_msdyn_channelprovider](msdyn_channelprovider.md#BKMK_owner_msdyn_channelprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelprovider`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_channelprovider`|
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

### <a name="BKMK_owner_msdyn_consoleapplicationnotificationfield"></a> owner_msdyn_consoleapplicationnotificationfield

Many-To-One Relationship: [msdyn_consoleapplicationnotificationfield owner_msdyn_consoleapplicationnotificationfield](msdyn_consoleapplicationnotificationfield.md#BKMK_owner_msdyn_consoleapplicationnotificationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationnotificationfield`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consoleapplicationnotificationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_consoleapplicationnotificationtemplate"></a> owner_msdyn_consoleapplicationnotificationtemplate

Many-To-One Relationship: [msdyn_consoleapplicationnotificationtemplate owner_msdyn_consoleapplicationnotificationtemplate](msdyn_consoleapplicationnotificationtemplate.md#BKMK_owner_msdyn_consoleapplicationnotificationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationnotificationtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consoleapplicationnotificationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_consoleapplicationsessiontemplate"></a> owner_msdyn_consoleapplicationsessiontemplate

Many-To-One Relationship: [msdyn_consoleapplicationsessiontemplate owner_msdyn_consoleapplicationsessiontemplate](msdyn_consoleapplicationsessiontemplate.md#BKMK_owner_msdyn_consoleapplicationsessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationsessiontemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consoleapplicationsessiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_consoleapplicationtemplate"></a> owner_msdyn_consoleapplicationtemplate

Many-To-One Relationship: [msdyn_consoleapplicationtemplate owner_msdyn_consoleapplicationtemplate](msdyn_consoleapplicationtemplate.md#BKMK_owner_msdyn_consoleapplicationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consoleapplicationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_consoleapplicationtemplateparameter"></a> owner_msdyn_consoleapplicationtemplateparameter

Many-To-One Relationship: [msdyn_consoleapplicationtemplateparameter owner_msdyn_consoleapplicationtemplateparameter](msdyn_consoleapplicationtemplateparameter.md#BKMK_owner_msdyn_consoleapplicationtemplateparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consoleapplicationtemplateparameter`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consoleapplicationtemplateparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_consumingapplication"></a> owner_msdyn_consumingapplication

Many-To-One Relationship: [msdyn_consumingapplication owner_msdyn_consumingapplication](msdyn_consumingapplication.md#BKMK_owner_msdyn_consumingapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consumingapplication`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_consumingapplication`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_contactsuggestionrule"></a> owner_msdyn_contactsuggestionrule

Many-To-One Relationship: [msdyn_contactsuggestionrule owner_msdyn_contactsuggestionrule](msdyn_contactsuggestionrule.md#BKMK_owner_msdyn_contactsuggestionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactsuggestionrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_contactsuggestionrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_contactsuggestionruleset"></a> owner_msdyn_contactsuggestionruleset

Many-To-One Relationship: [msdyn_contactsuggestionruleset owner_msdyn_contactsuggestionruleset](msdyn_contactsuggestionruleset.md#BKMK_owner_msdyn_contactsuggestionruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactsuggestionruleset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_contactsuggestionruleset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationaction"></a> owner_msdyn_conversationaction

Many-To-One Relationship: [msdyn_conversationaction owner_msdyn_conversationaction](msdyn_conversationaction.md#BKMK_owner_msdyn_conversationaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationaction`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationaction`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationactionitem"></a> owner_msdyn_conversationactionitem

Many-To-One Relationship: [msdyn_conversationactionitem owner_msdyn_conversationactionitem](msdyn_conversationactionitem.md#BKMK_owner_msdyn_conversationactionitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionitem`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationactionitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationactionlocale"></a> owner_msdyn_conversationactionlocale

Many-To-One Relationship: [msdyn_conversationactionlocale owner_msdyn_conversationactionlocale](msdyn_conversationactionlocale.md#BKMK_owner_msdyn_conversationactionlocale)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionlocale`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationactionlocale`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationaggregatedinsights"></a> owner_msdyn_conversationaggregatedinsights

Many-To-One Relationship: [msdyn_conversationaggregatedinsights owner_msdyn_conversationaggregatedinsights](msdyn_conversationaggregatedinsights.md#BKMK_owner_msdyn_conversationaggregatedinsights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationaggregatedinsights`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationaggregatedinsights`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationcomment"></a> owner_msdyn_conversationcomment

Many-To-One Relationship: [msdyn_conversationcomment owner_msdyn_conversationcomment](msdyn_conversationcomment.md#BKMK_owner_msdyn_conversationcomment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationcomment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationcomment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationdata"></a> owner_msdyn_conversationdata

Many-To-One Relationship: [msdyn_conversationdata owner_msdyn_conversationdata](msdyn_conversationdata.md#BKMK_owner_msdyn_conversationdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationdata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationinsight"></a> owner_msdyn_conversationinsight

Many-To-One Relationship: [msdyn_conversationinsight owner_msdyn_conversationinsight](msdyn_conversationinsight.md#BKMK_owner_msdyn_conversationinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationmessageblock"></a> owner_msdyn_conversationmessageblock

Many-To-One Relationship: [msdyn_conversationmessageblock owner_msdyn_conversationmessageblock](msdyn_conversationmessageblock.md#BKMK_owner_msdyn_conversationmessageblock)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationmessageblock`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationmessageblock`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationparticipantinsights"></a> owner_msdyn_conversationparticipantinsights

Many-To-One Relationship: [msdyn_conversationparticipantinsights owner_msdyn_conversationparticipantinsights](msdyn_conversationparticipantinsights.md#BKMK_owner_msdyn_conversationparticipantinsights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantinsights`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationparticipantinsights`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationparticipantsentiment"></a> owner_msdyn_conversationparticipantsentiment

Many-To-One Relationship: [msdyn_conversationparticipantsentiment owner_msdyn_conversationparticipantsentiment](msdyn_conversationparticipantsentiment.md#BKMK_owner_msdyn_conversationparticipantsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantsentiment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationparticipantsentiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationquestion"></a> owner_msdyn_conversationquestion

Many-To-One Relationship: [msdyn_conversationquestion owner_msdyn_conversationquestion](msdyn_conversationquestion.md#BKMK_owner_msdyn_conversationquestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationquestion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationquestion`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationsegmentsentiment"></a> owner_msdyn_conversationsegmentsentiment

Many-To-One Relationship: [msdyn_conversationsegmentsentiment owner_msdyn_conversationsegmentsentiment](msdyn_conversationsegmentsentiment.md#BKMK_owner_msdyn_conversationsegmentsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsegmentsentiment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationsegmentsentiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationsentiment"></a> owner_msdyn_conversationsentiment

Many-To-One Relationship: [msdyn_conversationsentiment owner_msdyn_conversationsentiment](msdyn_conversationsentiment.md#BKMK_owner_msdyn_conversationsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsentiment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationsentiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationsignal"></a> owner_msdyn_conversationsignal

Many-To-One Relationship: [msdyn_conversationsignal owner_msdyn_conversationsignal](msdyn_conversationsignal.md#BKMK_owner_msdyn_conversationsignal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsignal`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationsignal`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationsubject"></a> owner_msdyn_conversationsubject

Many-To-One Relationship: [msdyn_conversationsubject owner_msdyn_conversationsubject](msdyn_conversationsubject.md#BKMK_owner_msdyn_conversationsubject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsubject`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationsubject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationsummarysuggestion"></a> owner_msdyn_conversationsummarysuggestion

Many-To-One Relationship: [msdyn_conversationsummarysuggestion owner_msdyn_conversationsummarysuggestion](msdyn_conversationsummarysuggestion.md#BKMK_owner_msdyn_conversationsummarysuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsummarysuggestion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationsummarysuggestion`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationsystemtag"></a> owner_msdyn_conversationsystemtag

Many-To-One Relationship: [msdyn_conversationsystemtag owner_msdyn_conversationsystemtag](msdyn_conversationsystemtag.md#BKMK_owner_msdyn_conversationsystemtag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsystemtag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationsystemtag`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_conversationtag"></a> owner_msdyn_conversationtag

Many-To-One Relationship: [msdyn_conversationtag owner_msdyn_conversationtag](msdyn_conversationtag.md#BKMK_owner_msdyn_conversationtag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_conversationtag`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_copilotagentpreference"></a> owner_msdyn_copilotagentpreference

Many-To-One Relationship: [msdyn_copilotagentpreference owner_msdyn_copilotagentpreference](msdyn_copilotagentpreference.md#BKMK_owner_msdyn_copilotagentpreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotagentpreference`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_copilotagentpreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_copilotinteractiondata"></a> owner_msdyn_copilotinteractiondata

Many-To-One Relationship: [msdyn_copilotinteractiondata owner_msdyn_copilotinteractiondata](msdyn_copilotinteractiondata.md#BKMK_owner_msdyn_copilotinteractiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotinteractiondata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_copilotinteractiondata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_copilottranscriptdata"></a> owner_msdyn_copilottranscriptdata

Many-To-One Relationship: [msdyn_copilottranscriptdata owner_msdyn_copilottranscriptdata](msdyn_copilottranscriptdata.md#BKMK_owner_msdyn_copilottranscriptdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscriptdata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_copilottranscriptdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_crmconnection"></a> owner_msdyn_crmconnection

Many-To-One Relationship: [msdyn_crmconnection owner_msdyn_crmconnection](msdyn_crmconnection.md#BKMK_owner_msdyn_crmconnection)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_crmconnection`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_crmconnection`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_csadminconfig"></a> owner_msdyn_csadminconfig

Many-To-One Relationship: [msdyn_csadminconfig owner_msdyn_csadminconfig](msdyn_csadminconfig.md#BKMK_owner_msdyn_csadminconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_csadminconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_csadminconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_customapirulesetconfiguration"></a> owner_msdyn_customapirulesetconfiguration

Many-To-One Relationship: [msdyn_customapirulesetconfiguration owner_msdyn_customapirulesetconfiguration](msdyn_customapirulesetconfiguration.md#BKMK_owner_msdyn_customapirulesetconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customapirulesetconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_customapirulesetconfiguration`|
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

### <a name="BKMK_owner_msdyn_customerasset"></a> owner_msdyn_customerasset

Many-To-One Relationship: [msdyn_customerasset owner_msdyn_customerasset](msdyn_customerasset.md#BKMK_owner_msdyn_customerasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_customerasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_customerassetattachment"></a> owner_msdyn_customerassetattachment

Many-To-One Relationship: [msdyn_customerassetattachment owner_msdyn_customerassetattachment](msdyn_customerassetattachment.md#BKMK_owner_msdyn_customerassetattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerassetattachment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_customerassetattachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_customerassetcategory"></a> owner_msdyn_customerassetcategory

Many-To-One Relationship: [msdyn_customerassetcategory owner_msdyn_customerassetcategory](msdyn_customerassetcategory.md#BKMK_owner_msdyn_customerassetcategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerassetcategory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_customerassetcategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_dataanalyticscustomizedreport"></a> owner_msdyn_dataanalyticscustomizedreport

Many-To-One Relationship: [msdyn_dataanalyticscustomizedreport owner_msdyn_dataanalyticscustomizedreport](msdyn_dataanalyticscustomizedreport.md#BKMK_owner_msdyn_dataanalyticscustomizedreport)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticscustomizedreport`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_dataanalyticscustomizedreport`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_dataanalyticsdataset"></a> owner_msdyn_dataanalyticsdataset

Many-To-One Relationship: [msdyn_dataanalyticsdataset owner_msdyn_dataanalyticsdataset](msdyn_dataanalyticsdataset.md#BKMK_owner_msdyn_dataanalyticsdataset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsdataset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_dataanalyticsdataset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_dataanalyticsreport"></a> owner_msdyn_dataanalyticsreport

Many-To-One Relationship: [msdyn_dataanalyticsreport owner_msdyn_dataanalyticsreport](msdyn_dataanalyticsreport.md#BKMK_owner_msdyn_dataanalyticsreport)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_dataanalyticsreport`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_dataanalyticsworkspace"></a> owner_msdyn_dataanalyticsworkspace

Many-To-One Relationship: [msdyn_dataanalyticsworkspace owner_msdyn_dataanalyticsworkspace](msdyn_dataanalyticsworkspace.md#BKMK_owner_msdyn_dataanalyticsworkspace)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsworkspace`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_dataanalyticsworkspace`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_dealmanageraccess"></a> owner_msdyn_dealmanageraccess

Many-To-One Relationship: [msdyn_dealmanageraccess owner_msdyn_dealmanageraccess](msdyn_dealmanageraccess.md#BKMK_owner_msdyn_dealmanageraccess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dealmanageraccess`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_dealmanageraccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_dealmanagersettings"></a> owner_msdyn_dealmanagersettings

Many-To-One Relationship: [msdyn_dealmanagersettings owner_msdyn_dealmanagersettings](msdyn_dealmanagersettings.md#BKMK_owner_msdyn_dealmanagersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dealmanagersettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_dealmanagersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_decisioncontract"></a> owner_msdyn_decisioncontract

Many-To-One Relationship: [msdyn_decisioncontract owner_msdyn_decisioncontract](msdyn_decisioncontract.md#BKMK_owner_msdyn_decisioncontract)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_decisioncontract`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_decisioncontract`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_decisionruleset"></a> owner_msdyn_decisionruleset

Many-To-One Relationship: [msdyn_decisionruleset owner_msdyn_decisionruleset](msdyn_decisionruleset.md#BKMK_owner_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_decisionruleset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_decisionruleset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_defextendedchannelinstance"></a> owner_msdyn_defextendedchannelinstance

Many-To-One Relationship: [msdyn_defextendedchannelinstance owner_msdyn_defextendedchannelinstance](msdyn_defextendedchannelinstance.md#BKMK_owner_msdyn_defextendedchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_defextendedchannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_defextendedchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_defextendedchannelinstanceaccount"></a> owner_msdyn_defextendedchannelinstanceaccount

Many-To-One Relationship: [msdyn_defextendedchannelinstanceaccount owner_msdyn_defextendedchannelinstanceaccount](msdyn_defextendedchannelinstanceaccount.md#BKMK_owner_msdyn_defextendedchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_defextendedchannelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_defextendedchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_deletedconversation"></a> owner_msdyn_deletedconversation

Many-To-One Relationship: [msdyn_deletedconversation owner_msdyn_deletedconversation](msdyn_deletedconversation.md#BKMK_owner_msdyn_deletedconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_deletedconversation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_deletedconversation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_diagnosticsdata"></a> owner_msdyn_diagnosticsdata

Many-To-One Relationship: [msdyn_diagnosticsdata owner_msdyn_diagnosticsdata](msdyn_diagnosticsdata.md#BKMK_owner_msdyn_diagnosticsdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_diagnosticsdata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_diagnosticsdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_duplicateleadmapping"></a> owner_msdyn_duplicateleadmapping

Many-To-One Relationship: [msdyn_duplicateleadmapping owner_msdyn_duplicateleadmapping](msdyn_duplicateleadmapping.md#BKMK_owner_msdyn_duplicateleadmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_duplicateleadmapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_duplicateleadmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_effortpredictionresult"></a> owner_msdyn_effortpredictionresult

Many-To-One Relationship: [msdyn_effortpredictionresult owner_msdyn_effortpredictionresult](msdyn_effortpredictionresult.md#BKMK_owner_msdyn_effortpredictionresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_effortpredictionresult`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_effortpredictionresult`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entitlementapplication"></a> owner_msdyn_entitlementapplication

Many-To-One Relationship: [msdyn_entitlementapplication owner_msdyn_entitlementapplication](msdyn_entitlementapplication.md#BKMK_owner_msdyn_entitlementapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entitlementapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entityattachment"></a> owner_msdyn_entityattachment

Many-To-One Relationship: [msdyn_entityattachment owner_msdyn_entityattachment](msdyn_entityattachment.md#BKMK_owner_msdyn_entityattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityattachment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entityattachment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entityconfig"></a> owner_msdyn_entityconfig

Many-To-One Relationship: [msdyn_entityconfig owner_msdyn_entityconfig](msdyn_entityconfig.md#BKMK_owner_msdyn_entityconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entityconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entityconfiguration"></a> owner_msdyn_entityconfiguration

Many-To-One Relationship: [msdyn_entityconfiguration owner_msdyn_entityconfiguration](msdyn_entityconfiguration.md#BKMK_owner_msdyn_entityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entityrankingrule"></a> owner_msdyn_entityrankingrule

Many-To-One Relationship: [msdyn_entityrankingrule owner_msdyn_entityrankingrule](msdyn_entityrankingrule.md#BKMK_owner_msdyn_entityrankingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityrankingrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entityrankingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entityroutingconfiguration"></a> owner_msdyn_entityroutingconfiguration

Many-To-One Relationship: [msdyn_entityroutingconfiguration owner_msdyn_entityroutingconfiguration](msdyn_entityroutingconfiguration.md#BKMK_owner_msdyn_entityroutingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityroutingconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entityroutingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_entityworkstreammap"></a> owner_msdyn_entityworkstreammap

Many-To-One Relationship: [msdyn_entityworkstreammap owner_msdyn_entityworkstreammap](msdyn_entityworkstreammap.md#BKMK_owner_msdyn_entityworkstreammap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityworkstreammap`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entityworkstreammap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_extendedusersetting"></a> owner_msdyn_extendedusersetting

Many-To-One Relationship: [msdyn_extendedusersetting owner_msdyn_extendedusersetting](msdyn_extendedusersetting.md#BKMK_owner_msdyn_extendedusersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_extendedusersetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_extendedusersetting`|
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

### <a name="BKMK_owner_msdyn_fieldservicedemodatajob"></a> owner_msdyn_fieldservicedemodatajob

Many-To-One Relationship: [msdyn_fieldservicedemodatajob owner_msdyn_fieldservicedemodatajob](msdyn_fieldservicedemodatajob.md#BKMK_owner_msdyn_fieldservicedemodatajob)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicedemodatajob`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_fieldservicedemodatajob`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_fieldservicesetting"></a> owner_msdyn_fieldservicesetting

Many-To-One Relationship: [msdyn_fieldservicesetting owner_msdyn_fieldservicesetting](msdyn_fieldservicesetting.md#BKMK_owner_msdyn_fieldservicesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_fieldservicesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_fieldserviceslaconfiguration"></a> owner_msdyn_fieldserviceslaconfiguration

Many-To-One Relationship: [msdyn_fieldserviceslaconfiguration owner_msdyn_fieldserviceslaconfiguration](msdyn_fieldserviceslaconfiguration.md#BKMK_owner_msdyn_fieldserviceslaconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldserviceslaconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_fieldserviceslaconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_fieldservicesummaryconfiguration"></a> owner_msdyn_fieldservicesummaryconfiguration

Many-To-One Relationship: [msdyn_fieldservicesummaryconfiguration owner_msdyn_fieldservicesummaryconfiguration](msdyn_fieldservicesummaryconfiguration.md#BKMK_owner_msdyn_fieldservicesummaryconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicesummaryconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_fieldservicesummaryconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_flowcardtype"></a> owner_msdyn_flowcardtype

Many-To-One Relationship: [msdyn_flowcardtype owner_msdyn_flowcardtype](msdyn_flowcardtype.md#BKMK_owner_msdyn_flowcardtype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_flowcardtype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_flowcardtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_forecastconfiguration"></a> owner_msdyn_forecastconfiguration

Many-To-One Relationship: [msdyn_forecastconfiguration owner_msdyn_forecastconfiguration](msdyn_forecastconfiguration.md#BKMK_owner_msdyn_forecastconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_forecastconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_forecastdefinition"></a> owner_msdyn_forecastdefinition

Many-To-One Relationship: [msdyn_forecastdefinition owner_msdyn_forecastdefinition](msdyn_forecastdefinition.md#BKMK_owner_msdyn_forecastdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastdefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_forecastdefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_forecastinstance"></a> owner_msdyn_forecastinstance

Many-To-One Relationship: [msdyn_forecastinstance owner_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_owner_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_forecastinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_forecastrecurrence"></a> owner_msdyn_forecastrecurrence

Many-To-One Relationship: [msdyn_forecastrecurrence owner_msdyn_forecastrecurrence](msdyn_forecastrecurrence.md#BKMK_owner_msdyn_forecastrecurrence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastrecurrence`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_forecastrecurrence`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_formmapping"></a> owner_msdyn_formmapping

Many-To-One Relationship: [msdyn_formmapping owner_msdyn_formmapping](msdyn_formmapping.md#BKMK_owner_msdyn_formmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_formmapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_formmapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_functionallocation"></a> owner_msdyn_functionallocation

Many-To-One Relationship: [msdyn_functionallocation owner_msdyn_functionallocation](msdyn_functionallocation.md#BKMK_owner_msdyn_functionallocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_functionallocation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_functionallocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_functionallocationtype"></a> owner_msdyn_functionallocationtype

Many-To-One Relationship: [msdyn_functionallocationtype owner_msdyn_functionallocationtype](msdyn_functionallocationtype.md#BKMK_owner_msdyn_functionallocationtype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_functionallocationtype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_functionallocationtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_gdprdata"></a> owner_msdyn_gdprdata

Many-To-One Relationship: [msdyn_gdprdata owner_msdyn_gdprdata](msdyn_gdprdata.md#BKMK_owner_msdyn_gdprdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_gdprdata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_gdprdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_geofence"></a> owner_msdyn_geofence

Many-To-One Relationship: [msdyn_geofence owner_msdyn_geofence](msdyn_geofence.md#BKMK_owner_msdyn_geofence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofence`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_geofence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_geofenceevent"></a> owner_msdyn_geofenceevent

Many-To-One Relationship: [msdyn_geofenceevent owner_msdyn_geofenceevent](msdyn_geofenceevent.md#BKMK_owner_msdyn_geofenceevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofenceevent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_geofenceevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_geofencingsettings"></a> owner_msdyn_geofencingsettings

Many-To-One Relationship: [msdyn_geofencingsettings owner_msdyn_geofencingsettings](msdyn_geofencingsettings.md#BKMK_owner_msdyn_geofencingsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_geofencingsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_geofencingsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_guideauthorsession"></a> owner_msdyn_guideauthorsession

Many-To-One Relationship: [msdyn_guideauthorsession owner_msdyn_guideauthorsession](msdyn_guideauthorsession.md#BKMK_owner_msdyn_guideauthorsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_guideauthorsession`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_guideauthorsession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_icdextension"></a> owner_msdyn_icdextension

Many-To-One Relationship: [msdyn_icdextension owner_msdyn_icdextension](msdyn_icdextension.md#BKMK_owner_msdyn_icdextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_icdextension`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_icdextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_icebreakersconfig"></a> owner_msdyn_icebreakersconfig

Many-To-One Relationship: [msdyn_icebreakersconfig owner_msdyn_icebreakersconfig](msdyn_icebreakersconfig.md#BKMK_owner_msdyn_icebreakersconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_icebreakersconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_icebreakersconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iermlmodel"></a> owner_msdyn_iermlmodel

Many-To-One Relationship: [msdyn_iermlmodel owner_msdyn_iermlmodel](msdyn_iermlmodel.md#BKMK_owner_msdyn_iermlmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermlmodel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iermlmodel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iermltraining"></a> owner_msdyn_iermltraining

Many-To-One Relationship: [msdyn_iermltraining owner_msdyn_iermltraining](msdyn_iermltraining.md#BKMK_owner_msdyn_iermltraining)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermltraining`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iermltraining`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttype"></a> owner_msdyn_incidenttype

Many-To-One Relationship: [msdyn_incidenttype owner_msdyn_incidenttype](msdyn_incidenttype.md#BKMK_owner_msdyn_incidenttype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttype_requirementgroup"></a> owner_msdyn_incidenttype_requirementgroup

Many-To-One Relationship: [msdyn_incidenttype_requirementgroup owner_msdyn_incidenttype_requirementgroup](msdyn_incidenttype_requirementgroup.md#BKMK_owner_msdyn_incidenttype_requirementgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttype_requirementgroup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttype_requirementgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypecharacteristic"></a> owner_msdyn_incidenttypecharacteristic

Many-To-One Relationship: [msdyn_incidenttypecharacteristic owner_msdyn_incidenttypecharacteristic](msdyn_incidenttypecharacteristic.md#BKMK_owner_msdyn_incidenttypecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypecharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypecharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypeproduct"></a> owner_msdyn_incidenttypeproduct

Many-To-One Relationship: [msdyn_incidenttypeproduct owner_msdyn_incidenttypeproduct](msdyn_incidenttypeproduct.md#BKMK_owner_msdyn_incidenttypeproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypeproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttyperecommendationresult"></a> owner_msdyn_incidenttyperecommendationresult

Many-To-One Relationship: [msdyn_incidenttyperecommendationresult owner_msdyn_incidenttyperecommendationresult](msdyn_incidenttyperecommendationresult.md#BKMK_owner_msdyn_incidenttyperecommendationresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttyperecommendationresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttyperecommendationrunhistory"></a> owner_msdyn_incidenttyperecommendationrunhistory

Many-To-One Relationship: [msdyn_incidenttyperecommendationrunhistory owner_msdyn_incidenttyperecommendationrunhistory](msdyn_incidenttyperecommendationrunhistory.md#BKMK_owner_msdyn_incidenttyperecommendationrunhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperecommendationrunhistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttyperecommendationrunhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttyperesolution"></a> owner_msdyn_incidenttyperesolution

Many-To-One Relationship: [msdyn_incidenttyperesolution owner_msdyn_incidenttyperesolution](msdyn_incidenttyperesolution.md#BKMK_owner_msdyn_incidenttyperesolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttyperesolution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttyperesolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypeservice"></a> owner_msdyn_incidenttypeservice

Many-To-One Relationship: [msdyn_incidenttypeservice owner_msdyn_incidenttypeservice](msdyn_incidenttypeservice.md#BKMK_owner_msdyn_incidenttypeservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypeservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypeservicetask"></a> owner_msdyn_incidenttypeservicetask

Many-To-One Relationship: [msdyn_incidenttypeservicetask owner_msdyn_incidenttypeservicetask](msdyn_incidenttypeservicetask.md#BKMK_owner_msdyn_incidenttypeservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypeservicetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypeservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_incidenttypessetup"></a> owner_msdyn_incidenttypessetup

Many-To-One Relationship: [msdyn_incidenttypessetup owner_msdyn_incidenttypessetup](msdyn_incidenttypessetup.md#BKMK_owner_msdyn_incidenttypessetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_incidenttypessetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_incidenttypessetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspection"></a> owner_msdyn_inspection

Many-To-One Relationship: [msdyn_inspection owner_msdyn_inspection](msdyn_inspection.md#BKMK_owner_msdyn_inspection)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspection`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspection`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspectionattachment"></a> owner_msdyn_inspectionattachment

Many-To-One Relationship: [msdyn_inspectionattachment owner_msdyn_inspectionattachment](msdyn_inspectionattachment.md#BKMK_owner_msdyn_inspectionattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionattachment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspectionattachment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspectiondefinition"></a> owner_msdyn_inspectiondefinition

Many-To-One Relationship: [msdyn_inspectiondefinition owner_msdyn_inspectiondefinition](msdyn_inspectiondefinition.md#BKMK_owner_msdyn_inspectiondefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectiondefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspectiondefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspectioninstance"></a> owner_msdyn_inspectioninstance

Many-To-One Relationship: [msdyn_inspectioninstance owner_msdyn_inspectioninstance](msdyn_inspectioninstance.md#BKMK_owner_msdyn_inspectioninstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectioninstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspectioninstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inspectionresponse"></a> owner_msdyn_inspectionresponse

Many-To-One Relationship: [msdyn_inspectionresponse owner_msdyn_inspectionresponse](msdyn_inspectionresponse.md#BKMK_owner_msdyn_inspectionresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectionresponse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inspectionresponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_insurance"></a> owner_msdyn_insurance

Many-To-One Relationship: [msdyn_insurance owner_msdyn_insurance](msdyn_insurance.md#BKMK_owner_msdyn_insurance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_insurance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_insurance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intent"></a> owner_msdyn_intent

Many-To-One Relationship: [msdyn_intent owner_msdyn_intent](msdyn_intent.md#BKMK_owner_msdyn_intent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inventoryadjustment"></a> owner_msdyn_inventoryadjustment

Many-To-One Relationship: [msdyn_inventoryadjustment owner_msdyn_inventoryadjustment](msdyn_inventoryadjustment.md#BKMK_owner_msdyn_inventoryadjustment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inventoryadjustment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inventoryadjustmentproduct"></a> owner_msdyn_inventoryadjustmentproduct

Many-To-One Relationship: [msdyn_inventoryadjustmentproduct owner_msdyn_inventoryadjustmentproduct](msdyn_inventoryadjustmentproduct.md#BKMK_owner_msdyn_inventoryadjustmentproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryadjustmentproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inventoryadjustmentproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inventoryjournal"></a> owner_msdyn_inventoryjournal

Many-To-One Relationship: [msdyn_inventoryjournal owner_msdyn_inventoryjournal](msdyn_inventoryjournal.md#BKMK_owner_msdyn_inventoryjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inventoryjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_inventorytransfer"></a> owner_msdyn_inventorytransfer

Many-To-One Relationship: [msdyn_inventorytransfer owner_msdyn_inventorytransfer](msdyn_inventorytransfer.md#BKMK_owner_msdyn_inventorytransfer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventorytransfer`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_inventorytransfer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotalert"></a> owner_msdyn_iotalert

Many-To-One Relationship: [msdyn_iotalert owner_msdyn_iotalert](msdyn_iotalert.md#BKMK_owner_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotdevice"></a> owner_msdyn_iotdevice

Many-To-One Relationship: [msdyn_iotdevice owner_msdyn_iotdevice](msdyn_iotdevice.md#BKMK_owner_msdyn_iotdevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotdevice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotdevicecategory"></a> owner_msdyn_iotdevicecategory

Many-To-One Relationship: [msdyn_iotdevicecategory owner_msdyn_iotdevicecategory](msdyn_iotdevicecategory.md#BKMK_owner_msdyn_iotdevicecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecategory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotdevicecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotdevicecommand"></a> owner_msdyn_iotdevicecommand

Many-To-One Relationship: [msdyn_iotdevicecommand owner_msdyn_iotdevicecommand](msdyn_iotdevicecommand.md#BKMK_owner_msdyn_iotdevicecommand)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommand`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotdevicecommand`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotdevicecommanddefinition"></a> owner_msdyn_iotdevicecommanddefinition

Many-To-One Relationship: [msdyn_iotdevicecommanddefinition owner_msdyn_iotdevicecommanddefinition](msdyn_iotdevicecommanddefinition.md#BKMK_owner_msdyn_iotdevicecommanddefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommanddefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotdevicecommanddefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotdevicedatahistory"></a> owner_msdyn_iotdevicedatahistory

Many-To-One Relationship: [msdyn_iotdevicedatahistory owner_msdyn_iotdevicedatahistory](msdyn_iotdevicedatahistory.md#BKMK_owner_msdyn_iotdevicedatahistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicedatahistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotdevicedatahistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotdeviceproperty"></a> owner_msdyn_iotdeviceproperty

Many-To-One Relationship: [msdyn_iotdeviceproperty owner_msdyn_iotdeviceproperty](msdyn_iotdeviceproperty.md#BKMK_owner_msdyn_iotdeviceproperty)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdeviceproperty`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotdeviceproperty`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotdeviceregistrationhistory"></a> owner_msdyn_iotdeviceregistrationhistory

Many-To-One Relationship: [msdyn_iotdeviceregistrationhistory owner_msdyn_iotdeviceregistrationhistory](msdyn_iotdeviceregistrationhistory.md#BKMK_owner_msdyn_iotdeviceregistrationhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotdeviceregistrationhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotdevicevisualizationconfiguration"></a> owner_msdyn_iotdevicevisualizationconfiguration

Many-To-One Relationship: [msdyn_iotdevicevisualizationconfiguration owner_msdyn_iotdevicevisualizationconfiguration](msdyn_iotdevicevisualizationconfiguration.md#BKMK_owner_msdyn_iotdevicevisualizationconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicevisualizationconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotdevicevisualizationconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotfieldmapping"></a> owner_msdyn_iotfieldmapping

Many-To-One Relationship: [msdyn_iotfieldmapping owner_msdyn_iotfieldmapping](msdyn_iotfieldmapping.md#BKMK_owner_msdyn_iotfieldmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotfieldmapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotfieldmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotpropertydefinition"></a> owner_msdyn_iotpropertydefinition

Many-To-One Relationship: [msdyn_iotpropertydefinition owner_msdyn_iotpropertydefinition](msdyn_iotpropertydefinition.md#BKMK_owner_msdyn_iotpropertydefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotpropertydefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotpropertydefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotprovider"></a> owner_msdyn_iotprovider

Many-To-One Relationship: [msdyn_iotprovider owner_msdyn_iotprovider](msdyn_iotprovider.md#BKMK_owner_msdyn_iotprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotprovider`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotproviderinstance"></a> owner_msdyn_iotproviderinstance

Many-To-One Relationship: [msdyn_iotproviderinstance owner_msdyn_iotproviderinstance](msdyn_iotproviderinstance.md#BKMK_owner_msdyn_iotproviderinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotproviderinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotproviderinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_iotsettings"></a> owner_msdyn_iotsettings

Many-To-One Relationship: [msdyn_iotsettings owner_msdyn_iotsettings](msdyn_iotsettings.md#BKMK_owner_msdyn_iotsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_iotsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_jobsstate"></a> owner_msdyn_jobsstate

Many-To-One Relationship: [msdyn_jobsstate owner_msdyn_jobsstate](msdyn_jobsstate.md#BKMK_owner_msdyn_jobsstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_jobsstate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_jobsstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_kpieventdata"></a> owner_msdyn_kpieventdata

Many-To-One Relationship: [msdyn_kpieventdata owner_msdyn_kpieventdata](msdyn_kpieventdata.md#BKMK_owner_msdyn_kpieventdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_kpieventdata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_kpieventdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_kpieventdefinition"></a> owner_msdyn_kpieventdefinition

Many-To-One Relationship: [msdyn_kpieventdefinition owner_msdyn_kpieventdefinition](msdyn_kpieventdefinition.md#BKMK_owner_msdyn_kpieventdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_kpieventdefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_kpieventdefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_leadmodelconfig"></a> owner_msdyn_leadmodelconfig

Many-To-One Relationship: [msdyn_leadmodelconfig owner_msdyn_leadmodelconfig](msdyn_leadmodelconfig.md#BKMK_owner_msdyn_leadmodelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_leadmodelconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_leadmodelconfig`|
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

### <a name="BKMK_owner_msdyn_liveconversation"></a> owner_msdyn_liveconversation

Many-To-One Relationship: [msdyn_liveconversation owner_msdyn_liveconversation](msdyn_liveconversation.md#BKMK_owner_msdyn_liveconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveconversation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_liveconversation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_liveworkitemevent"></a> owner_msdyn_liveworkitemevent

Many-To-One Relationship: [msdyn_liveworkitemevent owner_msdyn_liveworkitemevent](msdyn_liveworkitemevent.md#BKMK_owner_msdyn_liveworkitemevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkitemevent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_liveworkitemevent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_liveworkstream"></a> owner_msdyn_liveworkstream

Many-To-One Relationship: [msdyn_liveworkstream owner_msdyn_liveworkstream](msdyn_liveworkstream.md#BKMK_owner_msdyn_liveworkstream)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstream`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_liveworkstream`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_liveworkstreamcapacityprofile"></a> owner_msdyn_liveworkstreamcapacityprofile

Many-To-One Relationship: [msdyn_liveworkstreamcapacityprofile owner_msdyn_liveworkstreamcapacityprofile](msdyn_liveworkstreamcapacityprofile.md#BKMK_owner_msdyn_liveworkstreamcapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstreamcapacityprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_liveworkstreamcapacityprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_locationtemplateassociation"></a> owner_msdyn_locationtemplateassociation

Many-To-One Relationship: [msdyn_locationtemplateassociation owner_msdyn_locationtemplateassociation](msdyn_locationtemplateassociation.md#BKMK_owner_msdyn_locationtemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_locationtemplateassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_locationtemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_locationtypetemplateassociation"></a> owner_msdyn_locationtypetemplateassociation

Many-To-One Relationship: [msdyn_locationtypetemplateassociation owner_msdyn_locationtypetemplateassociation](msdyn_locationtypetemplateassociation.md#BKMK_owner_msdyn_locationtypetemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_locationtypetemplateassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_locationtypetemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_lockstatus"></a> owner_msdyn_lockstatus

Many-To-One Relationship: [msdyn_lockstatus owner_msdyn_lockstatus](msdyn_lockstatus.md#BKMK_owner_msdyn_lockstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_lockstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_lockstatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_macrosession"></a> owner_msdyn_macrosession

Many-To-One Relationship: [msdyn_macrosession owner_msdyn_macrosession](msdyn_macrosession.md#BKMK_owner_msdyn_macrosession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_macrosession`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_macrosession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_masterentityroutingconfiguration"></a> owner_msdyn_masterentityroutingconfiguration

Many-To-One Relationship: [msdyn_masterentityroutingconfiguration owner_msdyn_masterentityroutingconfiguration](msdyn_masterentityroutingconfiguration.md#BKMK_owner_msdyn_masterentityroutingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_masterentityroutingconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_masterentityroutingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_migrationtracker"></a> owner_msdyn_migrationtracker

Many-To-One Relationship: [msdyn_migrationtracker owner_msdyn_migrationtracker](msdyn_migrationtracker.md#BKMK_owner_msdyn_migrationtracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_migrationtracker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_mobilesource"></a> owner_msdyn_mobilesource

Many-To-One Relationship: [msdyn_mobilesource owner_msdyn_mobilesource](msdyn_mobilesource.md#BKMK_owner_msdyn_mobilesource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mobilesource`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_mobilesource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_modelpreviewstatus"></a> owner_msdyn_modelpreviewstatus

Many-To-One Relationship: [msdyn_modelpreviewstatus owner_msdyn_modelpreviewstatus](msdyn_modelpreviewstatus.md#BKMK_owner_msdyn_modelpreviewstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_modelpreviewstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_modelpreviewstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_mrappsession"></a> owner_msdyn_mrappsession

Many-To-One Relationship: [msdyn_mrappsession owner_msdyn_mrappsession](msdyn_mrappsession.md#BKMK_owner_msdyn_mrappsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mrappsession`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_mrappsession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_mrasjob"></a> owner_msdyn_mrasjob

Many-To-One Relationship: [msdyn_mrasjob owner_msdyn_mrasjob](msdyn_mrasjob.md#BKMK_owner_msdyn_mrasjob)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mrasjob`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_mrasjob`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_mrfolder"></a> owner_msdyn_mrfolder

Many-To-One Relationship: [msdyn_mrfolder owner_msdyn_mrfolder](msdyn_mrfolder.md#BKMK_owner_msdyn_mrfolder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mrfolder`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_mrfolder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_msteamssetting"></a> owner_msdyn_msteamssetting

Many-To-One Relationship: [msdyn_msteamssetting owner_msdyn_msteamssetting](msdyn_msteamssetting.md#BKMK_owner_msdyn_msteamssetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_msteamssetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_msteamssetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_notesanalysisconfig"></a> owner_msdyn_notesanalysisconfig

Many-To-One Relationship: [msdyn_notesanalysisconfig owner_msdyn_notesanalysisconfig](msdyn_notesanalysisconfig.md#BKMK_owner_msdyn_notesanalysisconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notesanalysisconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_notesanalysisconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_notificationfield"></a> owner_msdyn_notificationfield

Many-To-One Relationship: [msdyn_notificationfield owner_msdyn_notificationfield](msdyn_notificationfield.md#BKMK_owner_msdyn_notificationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notificationfield`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_notificationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_notificationtemplate"></a> owner_msdyn_notificationtemplate

Many-To-One Relationship: [msdyn_notificationtemplate owner_msdyn_notificationtemplate](msdyn_notificationtemplate.md#BKMK_owner_msdyn_notificationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notificationtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_notificationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_nottoexceed"></a> owner_msdyn_nottoexceed

Many-To-One Relationship: [msdyn_nottoexceed owner_msdyn_nottoexceed](msdyn_nottoexceed.md#BKMK_owner_msdyn_nottoexceed)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_nottoexceed`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_objectanchor"></a> owner_msdyn_objectanchor

Many-To-One Relationship: [msdyn_objectanchor owner_msdyn_objectanchor](msdyn_objectanchor.md#BKMK_owner_msdyn_objectanchor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_objectanchor`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_objectanchor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_oc_geolocationprovider"></a> owner_msdyn_oc_geolocationprovider

Many-To-One Relationship: [msdyn_oc_geolocationprovider owner_msdyn_oc_geolocationprovider](msdyn_oc_geolocationprovider.md#BKMK_owner_msdyn_oc_geolocationprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oc_geolocationprovider`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_oc_geolocationprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocagentassignedcustomapiprivilege"></a> owner_msdyn_ocagentassignedcustomapiprivilege

Many-To-One Relationship: [msdyn_ocagentassignedcustomapiprivilege owner_msdyn_ocagentassignedcustomapiprivilege](msdyn_ocagentassignedcustomapiprivilege.md#BKMK_owner_msdyn_ocagentassignedcustomapiprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocagentassignedcustomapiprivilege`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocagentassignedcustomapiprivilege`|
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

### <a name="BKMK_owner_msdyn_ocautoblockrule"></a> owner_msdyn_ocautoblockrule

Many-To-One Relationship: [msdyn_ocautoblockrule owner_msdyn_ocautoblockrule](msdyn_ocautoblockrule.md#BKMK_owner_msdyn_ocautoblockrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautoblockrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocautoblockrule`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocbotchannelregistration"></a> owner_msdyn_ocbotchannelregistration

Many-To-One Relationship: [msdyn_ocbotchannelregistration owner_msdyn_ocbotchannelregistration](msdyn_ocbotchannelregistration.md#BKMK_owner_msdyn_ocbotchannelregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocbotchannelregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocbotchannelregistrationsecret"></a> owner_msdyn_ocbotchannelregistrationsecret

Many-To-One Relationship: [msdyn_ocbotchannelregistrationsecret owner_msdyn_ocbotchannelregistrationsecret](msdyn_ocbotchannelregistrationsecret.md#BKMK_owner_msdyn_ocbotchannelregistrationsecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistrationsecret`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocbotchannelregistrationsecret`|
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

### <a name="BKMK_owner_msdyn_occhannelapiconversationprivilege"></a> owner_msdyn_occhannelapiconversationprivilege

Many-To-One Relationship: [msdyn_occhannelapiconversationprivilege owner_msdyn_occhannelapiconversationprivilege](msdyn_occhannelapiconversationprivilege.md#BKMK_owner_msdyn_occhannelapiconversationprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapiconversationprivilege`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_occhannelapiconversationprivilege`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_occhannelapimessageprivilege"></a> owner_msdyn_occhannelapimessageprivilege

Many-To-One Relationship: [msdyn_occhannelapimessageprivilege owner_msdyn_occhannelapimessageprivilege](msdyn_occhannelapimessageprivilege.md#BKMK_owner_msdyn_occhannelapimessageprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapimessageprivilege`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_occhannelapimessageprivilege`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_occhannelapimethodmapping"></a> owner_msdyn_occhannelapimethodmapping

Many-To-One Relationship: [msdyn_occhannelapimethodmapping owner_msdyn_occhannelapimethodmapping](msdyn_occhannelapimethodmapping.md#BKMK_owner_msdyn_occhannelapimethodmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapimethodmapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_occhannelapimethodmapping`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_ocexternalcontext"></a> owner_msdyn_ocexternalcontext

Many-To-One Relationship: [msdyn_ocexternalcontext owner_msdyn_ocexternalcontext](msdyn_ocexternalcontext.md#BKMK_owner_msdyn_ocexternalcontext)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalcontext`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocexternalcontext`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_ocflaggedspam"></a> owner_msdyn_ocflaggedspam

Many-To-One Relationship: [msdyn_ocflaggedspam owner_msdyn_ocflaggedspam](msdyn_ocflaggedspam.md#BKMK_owner_msdyn_ocflaggedspam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocflaggedspam`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocflaggedspam`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_oclanguage"></a> owner_msdyn_oclanguage

Many-To-One Relationship: [msdyn_oclanguage owner_msdyn_oclanguage](msdyn_oclanguage.md#BKMK_owner_msdyn_oclanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclanguage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_oclanguage`|
|IsCustomizable|`True`|
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

### <a name="BKMK_owner_msdyn_ocliveworkitemcapacityprofile"></a> owner_msdyn_ocliveworkitemcapacityprofile

Many-To-One Relationship: [msdyn_ocliveworkitemcapacityprofile owner_msdyn_ocliveworkitemcapacityprofile](msdyn_ocliveworkitemcapacityprofile.md#BKMK_owner_msdyn_ocliveworkitemcapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcapacityprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocliveworkitemcapacityprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocliveworkitemcharacteristic"></a> owner_msdyn_ocliveworkitemcharacteristic

Many-To-One Relationship: [msdyn_ocliveworkitemcharacteristic owner_msdyn_ocliveworkitemcharacteristic](msdyn_ocliveworkitemcharacteristic.md#BKMK_owner_msdyn_ocliveworkitemcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocliveworkitemcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocliveworkitemcontextitem"></a> owner_msdyn_ocliveworkitemcontextitem

Many-To-One Relationship: [msdyn_ocliveworkitemcontextitem owner_msdyn_ocliveworkitemcontextitem](msdyn_ocliveworkitemcontextitem.md#BKMK_owner_msdyn_ocliveworkitemcontextitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcontextitem`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocliveworkitemcontextitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocliveworkitemparticipant"></a> owner_msdyn_ocliveworkitemparticipant

Many-To-One Relationship: [msdyn_ocliveworkitemparticipant owner_msdyn_ocliveworkitemparticipant](msdyn_ocliveworkitemparticipant.md#BKMK_owner_msdyn_ocliveworkitemparticipant)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemparticipant`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocliveworkitemparticipant`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocliveworkitemsentiment"></a> owner_msdyn_ocliveworkitemsentiment

Many-To-One Relationship: [msdyn_ocliveworkitemsentiment owner_msdyn_ocliveworkitemsentiment](msdyn_ocliveworkitemsentiment.md#BKMK_owner_msdyn_ocliveworkitemsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemsentiment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocliveworkitemsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocliveworkstreamcontextvariable"></a> owner_msdyn_ocliveworkstreamcontextvariable

Many-To-One Relationship: [msdyn_ocliveworkstreamcontextvariable owner_msdyn_ocliveworkstreamcontextvariable](msdyn_ocliveworkstreamcontextvariable.md#BKMK_owner_msdyn_ocliveworkstreamcontextvariable)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkstreamcontextvariable`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocliveworkstreamcontextvariable`|
|IsCustomizable|`True`|
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

### <a name="BKMK_owner_msdyn_ocpaymentprofile"></a> owner_msdyn_ocpaymentprofile

Many-To-One Relationship: [msdyn_ocpaymentprofile owner_msdyn_ocpaymentprofile](msdyn_ocpaymentprofile.md#BKMK_owner_msdyn_ocpaymentprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocpaymentprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocpaymentprofile`|
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

### <a name="BKMK_owner_msdyn_ocprovisioningstate"></a> owner_msdyn_ocprovisioningstate

Many-To-One Relationship: [msdyn_ocprovisioningstate owner_msdyn_ocprovisioningstate](msdyn_ocprovisioningstate.md#BKMK_owner_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocprovisioningstate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocprovisioningstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocrecording"></a> owner_msdyn_ocrecording

Many-To-One Relationship: [msdyn_ocrecording owner_msdyn_ocrecording](msdyn_ocrecording.md#BKMK_owner_msdyn_ocrecording)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocrecording`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocrequest"></a> owner_msdyn_ocrequest

Many-To-One Relationship: [msdyn_ocrequest owner_msdyn_ocrequest](msdyn_ocrequest.md#BKMK_owner_msdyn_ocrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocrichobject"></a> owner_msdyn_ocrichobject

Many-To-One Relationship: [msdyn_ocrichobject owner_msdyn_ocrichobject](msdyn_ocrichobject.md#BKMK_owner_msdyn_ocrichobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobject`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocrichobject`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocrichobjectmap"></a> owner_msdyn_ocrichobjectmap

Many-To-One Relationship: [msdyn_ocrichobjectmap owner_msdyn_ocrichobjectmap](msdyn_ocrichobjectmap.md#BKMK_owner_msdyn_ocrichobjectmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobjectmap`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocrichobjectmap`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocruleitem"></a> owner_msdyn_ocruleitem

Many-To-One Relationship: [msdyn_ocruleitem owner_msdyn_ocruleitem](msdyn_ocruleitem.md#BKMK_owner_msdyn_ocruleitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocruleitem`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocruleitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsentimentdailytopic"></a> owner_msdyn_ocsentimentdailytopic

Many-To-One Relationship: [msdyn_ocsentimentdailytopic owner_msdyn_ocsentimentdailytopic](msdyn_ocsentimentdailytopic.md#BKMK_owner_msdyn_ocsentimentdailytopic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsentimentdailytopic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsentimentdailytopickeyword"></a> owner_msdyn_ocsentimentdailytopickeyword

Many-To-One Relationship: [msdyn_ocsentimentdailytopickeyword owner_msdyn_ocsentimentdailytopickeyword](msdyn_ocsentimentdailytopickeyword.md#BKMK_owner_msdyn_ocsentimentdailytopickeyword)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopickeyword`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsentimentdailytopickeyword`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsentimentdailytopictrending"></a> owner_msdyn_ocsentimentdailytopictrending

Many-To-One Relationship: [msdyn_ocsentimentdailytopictrending owner_msdyn_ocsentimentdailytopictrending](msdyn_ocsentimentdailytopictrending.md#BKMK_owner_msdyn_ocsentimentdailytopictrending)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopictrending`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsentimentdailytopictrending`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsessioncharacteristic"></a> owner_msdyn_ocsessioncharacteristic

Many-To-One Relationship: [msdyn_ocsessioncharacteristic owner_msdyn_ocsessioncharacteristic](msdyn_ocsessioncharacteristic.md#BKMK_owner_msdyn_ocsessioncharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessioncharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsessioncharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsessionparticipantevent"></a> owner_msdyn_ocsessionparticipantevent

Many-To-One Relationship: [msdyn_ocsessionparticipantevent owner_msdyn_ocsessionparticipantevent](msdyn_ocsessionparticipantevent.md#BKMK_owner_msdyn_ocsessionparticipantevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionparticipantevent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsessionparticipantevent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsessionsentiment"></a> owner_msdyn_ocsessionsentiment

Many-To-One Relationship: [msdyn_ocsessionsentiment owner_msdyn_ocsessionsentiment](msdyn_ocsessionsentiment.md#BKMK_owner_msdyn_ocsessionsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionsentiment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsessionsentiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsimltraining"></a> owner_msdyn_ocsimltraining

Many-To-One Relationship: [msdyn_ocsimltraining owner_msdyn_ocsimltraining](msdyn_ocsimltraining.md#BKMK_owner_msdyn_ocsimltraining)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsimltraining`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsimltraining`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsitdimportconfig"></a> owner_msdyn_ocsitdimportconfig

Many-To-One Relationship: [msdyn_ocsitdimportconfig owner_msdyn_ocsitdimportconfig](msdyn_ocsitdimportconfig.md#BKMK_owner_msdyn_ocsitdimportconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitdimportconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsitdimportconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsitdskill"></a> owner_msdyn_ocsitdskill

Many-To-One Relationship: [msdyn_ocsitdskill owner_msdyn_ocsitdskill](msdyn_ocsitdskill.md#BKMK_owner_msdyn_ocsitdskill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitdskill`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsitdskill`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocsitrainingdata"></a> owner_msdyn_ocsitrainingdata

Many-To-One Relationship: [msdyn_ocsitrainingdata owner_msdyn_ocsitrainingdata](msdyn_ocsitrainingdata.md#BKMK_owner_msdyn_ocsitrainingdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitrainingdata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocsitrainingdata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocskillidentmlmodel"></a> owner_msdyn_ocskillidentmlmodel

Many-To-One Relationship: [msdyn_ocskillidentmlmodel owner_msdyn_ocskillidentmlmodel](msdyn_ocskillidentmlmodel.md#BKMK_owner_msdyn_ocskillidentmlmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocskillidentmlmodel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocskillidentmlmodel`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_omnichannelpersonalization"></a> owner_msdyn_omnichannelpersonalization

Many-To-One Relationship: [msdyn_omnichannelpersonalization owner_msdyn_omnichannelpersonalization](msdyn_omnichannelpersonalization.md#BKMK_owner_msdyn_omnichannelpersonalization)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelpersonalization`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_omnichannelpersonalization`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_omnichannelqueue"></a> owner_msdyn_omnichannelqueue

Many-To-One Relationship: [msdyn_omnichannelqueue owner_msdyn_omnichannelqueue](msdyn_omnichannelqueue.md#BKMK_owner_msdyn_omnichannelqueue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelqueue`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_omnichannelqueue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_omnichannelsyncconfig"></a> owner_msdyn_omnichannelsyncconfig

Many-To-One Relationship: [msdyn_omnichannelsyncconfig owner_msdyn_omnichannelsyncconfig](msdyn_omnichannelsyncconfig.md#BKMK_owner_msdyn_omnichannelsyncconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelsyncconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_omnichannelsyncconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_operatinghour"></a> owner_msdyn_operatinghour

Many-To-One Relationship: [msdyn_operatinghour owner_msdyn_operatinghour](msdyn_operatinghour.md#BKMK_owner_msdyn_operatinghour)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_operatinghour`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_operatinghour`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_opportunitymodelconfig"></a> owner_msdyn_opportunitymodelconfig

Many-To-One Relationship: [msdyn_opportunitymodelconfig owner_msdyn_opportunitymodelconfig](msdyn_opportunitymodelconfig.md#BKMK_owner_msdyn_opportunitymodelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_opportunitymodelconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_opportunitymodelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_optimizationrequestbooking"></a> owner_msdyn_optimizationrequestbooking

Many-To-One Relationship: [msdyn_optimizationrequestbooking owner_msdyn_optimizationrequestbooking](msdyn_optimizationrequestbooking.md#BKMK_owner_msdyn_optimizationrequestbooking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequestbooking`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_optimizationrequestbooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_optimizationrequestresource"></a> owner_msdyn_optimizationrequestresource

Many-To-One Relationship: [msdyn_optimizationrequestresource owner_msdyn_optimizationrequestresource](msdyn_optimizationrequestresource.md#BKMK_owner_msdyn_optimizationrequestresource)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequestresource`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_optimizationrequestresource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderedobjective"></a> owner_msdyn_orderedobjective

Many-To-One Relationship: [msdyn_orderedobjective owner_msdyn_orderedobjective](msdyn_orderedobjective.md#BKMK_owner_msdyn_orderedobjective)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderedobjective`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderedobjective`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderinvoicingdate"></a> owner_msdyn_orderinvoicingdate

Many-To-One Relationship: [msdyn_orderinvoicingdate owner_msdyn_orderinvoicingdate](msdyn_orderinvoicingdate.md#BKMK_owner_msdyn_orderinvoicingdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingdate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderinvoicingdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderinvoicingproduct"></a> owner_msdyn_orderinvoicingproduct

Many-To-One Relationship: [msdyn_orderinvoicingproduct owner_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_owner_msdyn_orderinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderinvoicingsetup"></a> owner_msdyn_orderinvoicingsetup

Many-To-One Relationship: [msdyn_orderinvoicingsetup owner_msdyn_orderinvoicingsetup](msdyn_orderinvoicingsetup.md#BKMK_owner_msdyn_orderinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orderinvoicingsetupdate"></a> owner_msdyn_orderinvoicingsetupdate

Many-To-One Relationship: [msdyn_orderinvoicingsetupdate owner_msdyn_orderinvoicingsetupdate](msdyn_orderinvoicingsetupdate.md#BKMK_owner_msdyn_orderinvoicingsetupdate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingsetupdate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orderinvoicingsetupdate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_orgchartnode"></a> owner_msdyn_orgchartnode

Many-To-One Relationship: [msdyn_orgchartnode owner_msdyn_orgchartnode](msdyn_orgchartnode.md#BKMK_owner_msdyn_orgchartnode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orgchartnode`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_orgchartnode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_overflowactionconfig"></a> owner_msdyn_overflowactionconfig

Many-To-One Relationship: [msdyn_overflowactionconfig owner_msdyn_overflowactionconfig](msdyn_overflowactionconfig.md#BKMK_owner_msdyn_overflowactionconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_overflowactionconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_overflowactionconfig`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_payment"></a> owner_msdyn_payment

Many-To-One Relationship: [msdyn_payment owner_msdyn_payment](msdyn_payment.md#BKMK_owner_msdyn_payment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_payment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_payment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_paymentdetail"></a> owner_msdyn_paymentdetail

Many-To-One Relationship: [msdyn_paymentdetail owner_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_owner_msdyn_paymentdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentdetail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_paymentdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_paymentmethod"></a> owner_msdyn_paymentmethod

Many-To-One Relationship: [msdyn_paymentmethod owner_msdyn_paymentmethod](msdyn_paymentmethod.md#BKMK_owner_msdyn_paymentmethod)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentmethod`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_paymentmethod`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_paymentterm"></a> owner_msdyn_paymentterm

Many-To-One Relationship: [msdyn_paymentterm owner_msdyn_paymentterm](msdyn_paymentterm.md#BKMK_owner_msdyn_paymentterm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentterm`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_paymentterm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_personalmessage"></a> owner_msdyn_personalmessage

Many-To-One Relationship: [msdyn_personalmessage owner_msdyn_personalmessage](msdyn_personalmessage.md#BKMK_owner_msdyn_personalmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_personalmessage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_personalmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_personalsoundsetting"></a> owner_msdyn_personalsoundsetting

Many-To-One Relationship: [msdyn_personalsoundsetting owner_msdyn_personalsoundsetting](msdyn_personalsoundsetting.md#BKMK_owner_msdyn_personalsoundsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_personalsoundsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_personalsoundsetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_playbookactivity"></a> owner_msdyn_playbookactivity

Many-To-One Relationship: [msdyn_playbookactivity owner_msdyn_playbookactivity](msdyn_playbookactivity.md#BKMK_owner_msdyn_playbookactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_playbookactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_playbookactivityattribute"></a> owner_msdyn_playbookactivityattribute

Many-To-One Relationship: [msdyn_playbookactivityattribute owner_msdyn_playbookactivityattribute](msdyn_playbookactivityattribute.md#BKMK_owner_msdyn_playbookactivityattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookactivityattribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_playbookactivityattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_playbookcategory"></a> owner_msdyn_playbookcategory

Many-To-One Relationship: [msdyn_playbookcategory owner_msdyn_playbookcategory](msdyn_playbookcategory.md#BKMK_owner_msdyn_playbookcategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookcategory`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_playbookcategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_playbookinstance"></a> owner_msdyn_playbookinstance

Many-To-One Relationship: [msdyn_playbookinstance owner_msdyn_playbookinstance](msdyn_playbookinstance.md#BKMK_owner_msdyn_playbookinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_playbookinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_playbooktemplate"></a> owner_msdyn_playbooktemplate

Many-To-One Relationship: [msdyn_playbooktemplate owner_msdyn_playbooktemplate](msdyn_playbooktemplate.md#BKMK_owner_msdyn_playbooktemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbooktemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_playbooktemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_postalbum"></a> owner_msdyn_postalbum

Many-To-One Relationship: [msdyn_postalbum owner_msdyn_postalbum](msdyn_postalbum.md#BKMK_owner_msdyn_postalbum)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalbum`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_postalbum`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_postalcode"></a> owner_msdyn_postalcode

Many-To-One Relationship: [msdyn_postalcode owner_msdyn_postalcode](msdyn_postalcode.md#BKMK_owner_msdyn_postalcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalcode`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_postalcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_predictioncomputationoperation"></a> owner_msdyn_predictioncomputationoperation

Many-To-One Relationship: [msdyn_predictioncomputationoperation owner_msdyn_predictioncomputationoperation](msdyn_predictioncomputationoperation.md#BKMK_owner_msdyn_predictioncomputationoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictioncomputationoperation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_predictioncomputationoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_predictionmodelstatus"></a> owner_msdyn_predictionmodelstatus

Many-To-One Relationship: [msdyn_predictionmodelstatus owner_msdyn_predictionmodelstatus](msdyn_predictionmodelstatus.md#BKMK_owner_msdyn_predictionmodelstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictionmodelstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_predictionmodelstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_predictionscheduledoperation"></a> owner_msdyn_predictionscheduledoperation

Many-To-One Relationship: [msdyn_predictionscheduledoperation owner_msdyn_predictionscheduledoperation](msdyn_predictionscheduledoperation.md#BKMK_owner_msdyn_predictionscheduledoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictionscheduledoperation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_predictionscheduledoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_predictivescoringsyncstatus"></a> owner_msdyn_predictivescoringsyncstatus

Many-To-One Relationship: [msdyn_predictivescoringsyncstatus owner_msdyn_predictivescoringsyncstatus](msdyn_predictivescoringsyncstatus.md#BKMK_owner_msdyn_predictivescoringsyncstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictivescoringsyncstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_predictivescoringsyncstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_preferredagent"></a> owner_msdyn_preferredagent

Many-To-One Relationship: [msdyn_preferredagent owner_msdyn_preferredagent](msdyn_preferredagent.md#BKMK_owner_msdyn_preferredagent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_preferredagent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_preferredagentcustomeridentity"></a> owner_msdyn_preferredagentcustomeridentity

Many-To-One Relationship: [msdyn_preferredagentcustomeridentity owner_msdyn_preferredagentcustomeridentity](msdyn_preferredagentcustomeridentity.md#BKMK_owner_msdyn_preferredagentcustomeridentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagentcustomeridentity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_preferredagentcustomeridentity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_preferredagentroutedentity"></a> owner_msdyn_preferredagentroutedentity

Many-To-One Relationship: [msdyn_preferredagentroutedentity owner_msdyn_preferredagentroutedentity](msdyn_preferredagentroutedentity.md#BKMK_owner_msdyn_preferredagentroutedentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagentroutedentity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_preferredagentroutedentity`|
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

### <a name="BKMK_owner_msdyn_problematicasset"></a> owner_msdyn_problematicasset

Many-To-One Relationship: [msdyn_problematicasset owner_msdyn_problematicasset](msdyn_problematicasset.md#BKMK_owner_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicasset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_problematicasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_problematicassetfeedback"></a> owner_msdyn_problematicassetfeedback

Many-To-One Relationship: [msdyn_problematicassetfeedback owner_msdyn_problematicassetfeedback](msdyn_problematicassetfeedback.md#BKMK_owner_msdyn_problematicassetfeedback)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicassetfeedback`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_problematicassetfeedback`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_productivityactioninputparameter"></a> owner_msdyn_productivityactioninputparameter

Many-To-One Relationship: [msdyn_productivityactioninputparameter owner_msdyn_productivityactioninputparameter](msdyn_productivityactioninputparameter.md#BKMK_owner_msdyn_productivityactioninputparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityactioninputparameter`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_productivityactioninputparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_productivityactionoutputparameter"></a> owner_msdyn_productivityactionoutputparameter

Many-To-One Relationship: [msdyn_productivityactionoutputparameter owner_msdyn_productivityactionoutputparameter](msdyn_productivityactionoutputparameter.md#BKMK_owner_msdyn_productivityactionoutputparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityactionoutputparameter`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_productivityactionoutputparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_productivityagentscript"></a> owner_msdyn_productivityagentscript

Many-To-One Relationship: [msdyn_productivityagentscript owner_msdyn_productivityagentscript](msdyn_productivityagentscript.md#BKMK_owner_msdyn_productivityagentscript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityagentscript`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_productivityagentscript`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_productivityagentscriptstep"></a> owner_msdyn_productivityagentscriptstep

Many-To-One Relationship: [msdyn_productivityagentscriptstep owner_msdyn_productivityagentscriptstep](msdyn_productivityagentscriptstep.md#BKMK_owner_msdyn_productivityagentscriptstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityagentscriptstep`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_productivityagentscriptstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_productivitymacroactiontemplate"></a> owner_msdyn_productivitymacroactiontemplate

Many-To-One Relationship: [msdyn_productivitymacroactiontemplate owner_msdyn_productivitymacroactiontemplate](msdyn_productivitymacroactiontemplate.md#BKMK_owner_msdyn_productivitymacroactiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacroactiontemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_productivitymacroactiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_productivitymacroconnector"></a> owner_msdyn_productivitymacroconnector

Many-To-One Relationship: [msdyn_productivitymacroconnector owner_msdyn_productivitymacroconnector](msdyn_productivitymacroconnector.md#BKMK_owner_msdyn_productivitymacroconnector)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacroconnector`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_productivitymacroconnector`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_productivitymacrosolutionconfiguration"></a> owner_msdyn_productivitymacrosolutionconfiguration

Many-To-One Relationship: [msdyn_productivitymacrosolutionconfiguration owner_msdyn_productivitymacrosolutionconfiguration](msdyn_productivitymacrosolutionconfiguration.md#BKMK_owner_msdyn_productivitymacrosolutionconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacrosolutionconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_productivitymacrosolutionconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_productivityparameterdefinition"></a> owner_msdyn_productivityparameterdefinition

Many-To-One Relationship: [msdyn_productivityparameterdefinition owner_msdyn_productivityparameterdefinition](msdyn_productivityparameterdefinition.md#BKMK_owner_msdyn_productivityparameterdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityparameterdefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_productivityparameterdefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_property"></a> owner_msdyn_property

Many-To-One Relationship: [msdyn_property owner_msdyn_property](msdyn_property.md#BKMK_owner_msdyn_property)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_property`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_property`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_propertyassetassociation"></a> owner_msdyn_propertyassetassociation

Many-To-One Relationship: [msdyn_propertyassetassociation owner_msdyn_propertyassetassociation](msdyn_propertyassetassociation.md#BKMK_owner_msdyn_propertyassetassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertyassetassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_propertyassetassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_propertylocationassociation"></a> owner_msdyn_propertylocationassociation

Many-To-One Relationship: [msdyn_propertylocationassociation owner_msdyn_propertylocationassociation](msdyn_propertylocationassociation.md#BKMK_owner_msdyn_propertylocationassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylocationassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_propertylocationassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_propertylog"></a> owner_msdyn_propertylog

Many-To-One Relationship: [msdyn_propertylog owner_msdyn_propertylog](msdyn_propertylog.md#BKMK_owner_msdyn_propertylog)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylog`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_propertylog`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_propertytemplateassociation"></a> owner_msdyn_propertytemplateassociation

Many-To-One Relationship: [msdyn_propertytemplateassociation owner_msdyn_propertytemplateassociation](msdyn_propertytemplateassociation.md#BKMK_owner_msdyn_propertytemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertytemplateassociation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_propertytemplateassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorder"></a> owner_msdyn_purchaseorder

Many-To-One Relationship: [msdyn_purchaseorder owner_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_owner_msdyn_purchaseorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorderbill"></a> owner_msdyn_purchaseorderbill

Many-To-One Relationship: [msdyn_purchaseorderbill owner_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_owner_msdyn_purchaseorderbill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderbill`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorderbill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorderproduct"></a> owner_msdyn_purchaseorderproduct

Many-To-One Relationship: [msdyn_purchaseorderproduct owner_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_owner_msdyn_purchaseorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorderreceipt"></a> owner_msdyn_purchaseorderreceipt

Many-To-One Relationship: [msdyn_purchaseorderreceipt owner_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_owner_msdyn_purchaseorderreceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceipt`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorderreceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseorderreceiptproduct"></a> owner_msdyn_purchaseorderreceiptproduct

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct owner_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_owner_msdyn_purchaseorderreceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseorderreceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_purchaseordersubstatus"></a> owner_msdyn_purchaseordersubstatus

Many-To-One Relationship: [msdyn_purchaseordersubstatus owner_msdyn_purchaseordersubstatus](msdyn_purchaseordersubstatus.md#BKMK_owner_msdyn_purchaseordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseordersubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_purchaseordersubstatus`|
|IsCustomizable|`True`|
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

### <a name="BKMK_owner_msdyn_quotebookingincident"></a> owner_msdyn_quotebookingincident

Many-To-One Relationship: [msdyn_quotebookingincident owner_msdyn_quotebookingincident](msdyn_quotebookingincident.md#BKMK_owner_msdyn_quotebookingincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingincident`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingproduct"></a> owner_msdyn_quotebookingproduct

Many-To-One Relationship: [msdyn_quotebookingproduct owner_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_owner_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingservice"></a> owner_msdyn_quotebookingservice

Many-To-One Relationship: [msdyn_quotebookingservice owner_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_owner_msdyn_quotebookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingservicetask"></a> owner_msdyn_quotebookingservicetask

Many-To-One Relationship: [msdyn_quotebookingservicetask owner_msdyn_quotebookingservicetask](msdyn_quotebookingservicetask.md#BKMK_owner_msdyn_quotebookingservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservicetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quotebookingsetup"></a> owner_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup owner_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_owner_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quotebookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quoteinvoicingproduct"></a> owner_msdyn_quoteinvoicingproduct

Many-To-One Relationship: [msdyn_quoteinvoicingproduct owner_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_owner_msdyn_quoteinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quoteinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_quoteinvoicingsetup"></a> owner_msdyn_quoteinvoicingsetup

Many-To-One Relationship: [msdyn_quoteinvoicingsetup owner_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_owner_msdyn_quoteinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingsetup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_quoteinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_readtracker"></a> owner_msdyn_readtracker

Many-To-One Relationship: [msdyn_readtracker owner_msdyn_readtracker](msdyn_readtracker.md#BKMK_owner_msdyn_readtracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtracker`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_readtracker`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_realtimescoring"></a> owner_msdyn_realtimescoring

Many-To-One Relationship: [msdyn_realtimescoring owner_msdyn_realtimescoring](msdyn_realtimescoring.md#BKMK_owner_msdyn_realtimescoring)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_realtimescoring`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_realtimescoring`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_realtimescoringoperation"></a> owner_msdyn_realtimescoringoperation

Many-To-One Relationship: [msdyn_realtimescoringoperation owner_msdyn_realtimescoringoperation](msdyn_realtimescoringoperation.md#BKMK_owner_msdyn_realtimescoringoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_realtimescoringoperation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_realtimescoringoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_recording"></a> owner_msdyn_recording

Many-To-One Relationship: [msdyn_recording owner_msdyn_recording](msdyn_recording.md#BKMK_owner_msdyn_recording)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recording`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_recording`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_relationshipinsightsunifiedconfig"></a> owner_msdyn_relationshipinsightsunifiedconfig

Many-To-One Relationship: [msdyn_relationshipinsightsunifiedconfig owner_msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md#BKMK_owner_msdyn_relationshipinsightsunifiedconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_relationshipinsightsunifiedconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_relationshipinsightsunifiedconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_reportbookmark"></a> owner_msdyn_reportbookmark

Many-To-One Relationship: [msdyn_reportbookmark owner_msdyn_reportbookmark](msdyn_reportbookmark.md#BKMK_owner_msdyn_reportbookmark)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_reportbookmark`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_reportbookmark`|
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

### <a name="BKMK_owner_msdyn_resolution"></a> owner_msdyn_resolution

Many-To-One Relationship: [msdyn_resolution owner_msdyn_resolution](msdyn_resolution.md#BKMK_owner_msdyn_resolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resolution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_resourcepaytype"></a> owner_msdyn_resourcepaytype

Many-To-One Relationship: [msdyn_resourcepaytype owner_msdyn_resourcepaytype](msdyn_resourcepaytype.md#BKMK_owner_msdyn_resourcepaytype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcepaytype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_resourcepaytype`|
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

### <a name="BKMK_owner_msdyn_rma"></a> owner_msdyn_rma

Many-To-One Relationship: [msdyn_rma owner_msdyn_rma](msdyn_rma.md#BKMK_owner_msdyn_rma)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rma`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rmaproduct"></a> owner_msdyn_rmaproduct

Many-To-One Relationship: [msdyn_rmaproduct owner_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_owner_msdyn_rmaproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rmaproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rmareceipt"></a> owner_msdyn_rmareceipt

Many-To-One Relationship: [msdyn_rmareceipt owner_msdyn_rmareceipt](msdyn_rmareceipt.md#BKMK_owner_msdyn_rmareceipt)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceipt`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rmareceipt`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rmareceiptproduct"></a> owner_msdyn_rmareceiptproduct

Many-To-One Relationship: [msdyn_rmareceiptproduct owner_msdyn_rmareceiptproduct](msdyn_rmareceiptproduct.md#BKMK_owner_msdyn_rmareceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmareceiptproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rmareceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rmasubstatus"></a> owner_msdyn_rmasubstatus

Many-To-One Relationship: [msdyn_rmasubstatus owner_msdyn_rmasubstatus](msdyn_rmasubstatus.md#BKMK_owner_msdyn_rmasubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmasubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rmasubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_routingconfiguration"></a> owner_msdyn_routingconfiguration

Many-To-One Relationship: [msdyn_routingconfiguration owner_msdyn_routingconfiguration](msdyn_routingconfiguration.md#BKMK_owner_msdyn_routingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_routingconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_routingconfigurationstep"></a> owner_msdyn_routingconfigurationstep

Many-To-One Relationship: [msdyn_routingconfigurationstep owner_msdyn_routingconfigurationstep](msdyn_routingconfigurationstep.md#BKMK_owner_msdyn_routingconfigurationstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingconfigurationstep`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_routingconfigurationstep`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_routingengineconfiguration"></a> owner_msdyn_routingengineconfiguration

Many-To-One Relationship: [msdyn_routingengineconfiguration owner_msdyn_routingengineconfiguration](msdyn_routingengineconfiguration.md#BKMK_owner_msdyn_routingengineconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingengineconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_routingengineconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_routingjobconfiguration"></a> owner_msdyn_routingjobconfiguration

Many-To-One Relationship: [msdyn_routingjobconfiguration owner_msdyn_routingjobconfiguration](msdyn_routingjobconfiguration.md#BKMK_owner_msdyn_routingjobconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingjobconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_routingjobconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_routingoptimizationrequest"></a> owner_msdyn_routingoptimizationrequest

Many-To-One Relationship: [msdyn_routingoptimizationrequest owner_msdyn_routingoptimizationrequest](msdyn_routingoptimizationrequest.md#BKMK_owner_msdyn_routingoptimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingoptimizationrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_routingoptimizationrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_routingprofileconfiguration"></a> owner_msdyn_routingprofileconfiguration

Many-To-One Relationship: [msdyn_routingprofileconfiguration owner_msdyn_routingprofileconfiguration](msdyn_routingprofileconfiguration.md#BKMK_owner_msdyn_routingprofileconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingprofileconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_routingprofileconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_routingrequest"></a> owner_msdyn_routingrequest

Many-To-One Relationship: [msdyn_routingrequest owner_msdyn_routingrequest](msdyn_routingrequest.md#BKMK_owner_msdyn_routingrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_routingrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rtv"></a> owner_msdyn_rtv

Many-To-One Relationship: [msdyn_rtv owner_msdyn_rtv](msdyn_rtv.md#BKMK_owner_msdyn_rtv)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rtv`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rtvproduct"></a> owner_msdyn_rtvproduct

Many-To-One Relationship: [msdyn_rtvproduct owner_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_owner_msdyn_rtvproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rtvproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rtvsubstatus"></a> owner_msdyn_rtvsubstatus

Many-To-One Relationship: [msdyn_rtvsubstatus owner_msdyn_rtvsubstatus](msdyn_rtvsubstatus.md#BKMK_owner_msdyn_rtvsubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvsubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rtvsubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_rulesetdependencymapping"></a> owner_msdyn_rulesetdependencymapping

Many-To-One Relationship: [msdyn_rulesetdependencymapping owner_msdyn_rulesetdependencymapping](msdyn_rulesetdependencymapping.md#BKMK_owner_msdyn_rulesetdependencymapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rulesetdependencymapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rulesetdependencymapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_salescopilotinsight"></a> owner_msdyn_salescopilotinsight

Many-To-One Relationship: [msdyn_salescopilotinsight owner_msdyn_salescopilotinsight](msdyn_salescopilotinsight.md#BKMK_owner_msdyn_salescopilotinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salescopilotinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_salesinsightssettings"></a> owner_msdyn_salesinsightssettings

Many-To-One Relationship: [msdyn_salesinsightssettings owner_msdyn_salesinsightssettings](msdyn_salesinsightssettings.md#BKMK_owner_msdyn_salesinsightssettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesinsightssettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salesinsightssettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_salesocmessage"></a> owner_msdyn_salesocmessage

Many-To-One Relationship: [msdyn_salesocmessage owner_msdyn_salesocmessage](msdyn_salesocmessage.md#BKMK_owner_msdyn_salesocmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesocmessage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salesocmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_salesocsmstemplate"></a> owner_msdyn_salesocsmstemplate

Many-To-One Relationship: [msdyn_salesocsmstemplate owner_msdyn_salesocsmstemplate](msdyn_salesocsmstemplate.md#BKMK_owner_msdyn_salesocsmstemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesocsmstemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salesocsmstemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_salesroutingrun"></a> owner_msdyn_salesroutingrun

Many-To-One Relationship: [msdyn_salesroutingrun owner_msdyn_salesroutingrun](msdyn_salesroutingrun.md#BKMK_owner_msdyn_salesroutingrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salesroutingrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_salessuggestion"></a> owner_msdyn_salessuggestion

Many-To-One Relationship: [msdyn_salessuggestion owner_msdyn_salessuggestion](msdyn_salessuggestion.md#BKMK_owner_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salessuggestion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salessuggestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_salestag"></a> owner_msdyn_salestag

Many-To-One Relationship: [msdyn_salestag owner_msdyn_salestag](msdyn_salestag.md#BKMK_owner_msdyn_salestag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salestag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salestag`|
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

### <a name="BKMK_owner_msdyn_sciconversation"></a> owner_msdyn_sciconversation

Many-To-One Relationship: [msdyn_sciconversation owner_msdyn_sciconversation](msdyn_sciconversation.md#BKMK_owner_msdyn_sciconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciconversation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sciconversation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_scicustomemailhighlight"></a> owner_msdyn_scicustomemailhighlight

Many-To-One Relationship: [msdyn_scicustomemailhighlight owner_msdyn_scicustomemailhighlight](msdyn_scicustomemailhighlight.md#BKMK_owner_msdyn_scicustomemailhighlight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustomemailhighlight`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_scicustomemailhighlight`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_scicustomhighlight"></a> owner_msdyn_scicustomhighlight

Many-To-One Relationship: [msdyn_scicustomhighlight owner_msdyn_scicustomhighlight](msdyn_scicustomhighlight.md#BKMK_owner_msdyn_scicustomhighlight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustomhighlight`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_scicustomhighlight`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_scicustompublisher"></a> owner_msdyn_scicustompublisher

Many-To-One Relationship: [msdyn_scicustompublisher owner_msdyn_scicustompublisher](msdyn_scicustompublisher.md#BKMK_owner_msdyn_scicustompublisher)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustompublisher`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_scicustompublisher`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sciusersettings"></a> owner_msdyn_sciusersettings

Many-To-One Relationship: [msdyn_sciusersettings owner_msdyn_sciusersettings](msdyn_sciusersettings.md#BKMK_owner_msdyn_sciusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciusersettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sciusersettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_searchconfiguration"></a> owner_msdyn_searchconfiguration

Many-To-One Relationship: [msdyn_searchconfiguration owner_msdyn_searchconfiguration](msdyn_searchconfiguration.md#BKMK_owner_msdyn_searchconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_searchconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_searchconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_segment"></a> owner_msdyn_segment

Many-To-One Relationship: [msdyn_segment owner_msdyn_segment](msdyn_segment.md#BKMK_owner_msdyn_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_segment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_segment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sequence"></a> owner_msdyn_sequence

Many-To-One Relationship: [msdyn_sequence owner_msdyn_sequence](msdyn_sequence.md#BKMK_owner_msdyn_sequence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequence`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sequence`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sequencestat"></a> owner_msdyn_sequencestat

Many-To-One Relationship: [msdyn_sequencestat owner_msdyn_sequencestat](msdyn_sequencestat.md#BKMK_owner_msdyn_sequencestat)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencestat`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sequencestat`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sequencetarget"></a> owner_msdyn_sequencetarget

Many-To-One Relationship: [msdyn_sequencetarget owner_msdyn_sequencetarget](msdyn_sequencetarget.md#BKMK_owner_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sequencetarget`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sequencetargetstep"></a> owner_msdyn_sequencetargetstep

Many-To-One Relationship: [msdyn_sequencetargetstep owner_msdyn_sequencetargetstep](msdyn_sequencetargetstep.md#BKMK_owner_msdyn_sequencetargetstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetargetstep`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sequencetargetstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sequencetemplate"></a> owner_msdyn_sequencetemplate

Many-To-One Relationship: [msdyn_sequencetemplate owner_msdyn_sequencetemplate](msdyn_sequencetemplate.md#BKMK_owner_msdyn_sequencetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sequencetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_serviceoneprovisioningrequest"></a> owner_msdyn_serviceoneprovisioningrequest

Many-To-One Relationship: [msdyn_serviceoneprovisioningrequest owner_msdyn_serviceoneprovisioningrequest](msdyn_serviceoneprovisioningrequest.md#BKMK_owner_msdyn_serviceoneprovisioningrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_serviceoneprovisioningrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_serviceoneprovisioningrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_servicetasktype"></a> owner_msdyn_servicetasktype

Many-To-One Relationship: [msdyn_servicetasktype owner_msdyn_servicetasktype](msdyn_servicetasktype.md#BKMK_owner_msdyn_servicetasktype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_servicetasktype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_servicetasktype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sessiondata"></a> owner_msdyn_sessiondata

Many-To-One Relationship: [msdyn_sessiondata owner_msdyn_sessiondata](msdyn_sessiondata.md#BKMK_owner_msdyn_sessiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiondata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sessiondata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sessionevent"></a> owner_msdyn_sessionevent

Many-To-One Relationship: [msdyn_sessionevent owner_msdyn_sessionevent](msdyn_sessionevent.md#BKMK_owner_msdyn_sessionevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionevent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sessionevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sessionparticipant"></a> owner_msdyn_sessionparticipant

Many-To-One Relationship: [msdyn_sessionparticipant owner_msdyn_sessionparticipant](msdyn_sessionparticipant.md#BKMK_owner_msdyn_sessionparticipant)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipant`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sessionparticipant`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sessionparticipantdata"></a> owner_msdyn_sessionparticipantdata

Many-To-One Relationship: [msdyn_sessionparticipantdata owner_msdyn_sessionparticipantdata](msdyn_sessionparticipantdata.md#BKMK_owner_msdyn_sessionparticipantdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipantdata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sessionparticipantdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_sessiontemplate"></a> owner_msdyn_sessiontemplate

Many-To-One Relationship: [msdyn_sessiontemplate owner_msdyn_sessiontemplate](msdyn_sessiontemplate.md#BKMK_owner_msdyn_sessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiontemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sessiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_shipvia"></a> owner_msdyn_shipvia

Many-To-One Relationship: [msdyn_shipvia owner_msdyn_shipvia](msdyn_shipvia.md#BKMK_owner_msdyn_shipvia)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_shipvia`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_shipvia`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_siconfig"></a> owner_msdyn_siconfig

Many-To-One Relationship: [msdyn_siconfig owner_msdyn_siconfig](msdyn_siconfig.md#BKMK_owner_msdyn_siconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_siconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_siconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_skillattachmentruleitem"></a> owner_msdyn_skillattachmentruleitem

Many-To-One Relationship: [msdyn_skillattachmentruleitem owner_msdyn_skillattachmentruleitem](msdyn_skillattachmentruleitem.md#BKMK_owner_msdyn_skillattachmentruleitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_skillattachmentruleitem`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_skillattachmentruleitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_skillattachmenttarget"></a> owner_msdyn_skillattachmenttarget

Many-To-One Relationship: [msdyn_skillattachmenttarget owner_msdyn_skillattachmenttarget](msdyn_skillattachmenttarget.md#BKMK_owner_msdyn_skillattachmenttarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_skillattachmenttarget`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_skillattachmenttarget`|
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

### <a name="BKMK_owner_msdyn_soundnotificationsetting"></a> owner_msdyn_soundnotificationsetting

Many-To-One Relationship: [msdyn_soundnotificationsetting owner_msdyn_soundnotificationsetting](msdyn_soundnotificationsetting.md#BKMK_owner_msdyn_soundnotificationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_soundnotificationsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_soundnotificationsetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_submodeldefinition"></a> owner_msdyn_submodeldefinition

Many-To-One Relationship: [msdyn_submodeldefinition owner_msdyn_submodeldefinition](msdyn_submodeldefinition.md#BKMK_owner_msdyn_submodeldefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_submodeldefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_submodeldefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_suggestionassignmentrule"></a> owner_msdyn_suggestionassignmentrule

Many-To-One Relationship: [msdyn_suggestionassignmentrule owner_msdyn_suggestionassignmentrule](msdyn_suggestionassignmentrule.md#BKMK_owner_msdyn_suggestionassignmentrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionassignmentrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_suggestionassignmentrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_suggestionprincipalobjectaccess"></a> owner_msdyn_suggestionprincipalobjectaccess

Many-To-One Relationship: [msdyn_suggestionprincipalobjectaccess owner_msdyn_suggestionprincipalobjectaccess](msdyn_suggestionprincipalobjectaccess.md#BKMK_owner_msdyn_suggestionprincipalobjectaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionprincipalobjectaccess`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_suggestionprincipalobjectaccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_suggestionsellerpriority"></a> owner_msdyn_suggestionsellerpriority

Many-To-One Relationship: [msdyn_suggestionsellerpriority owner_msdyn_suggestionsellerpriority](msdyn_suggestionsellerpriority.md#BKMK_owner_msdyn_suggestionsellerpriority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionsellerpriority`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_suggestionsellerpriority`|
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

### <a name="BKMK_owner_msdyn_swarm"></a> owner_msdyn_swarm

Many-To-One Relationship: [msdyn_swarm owner_msdyn_swarm](msdyn_swarm.md#BKMK_owner_msdyn_swarm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarm`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_swarm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_swarmparticipant"></a> owner_msdyn_swarmparticipant

Many-To-One Relationship: [msdyn_swarmparticipant owner_msdyn_swarmparticipant](msdyn_swarmparticipant.md#BKMK_owner_msdyn_swarmparticipant)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmparticipant`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_swarmparticipant`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_swarmparticipantrule"></a> owner_msdyn_swarmparticipantrule

Many-To-One Relationship: [msdyn_swarmparticipantrule owner_msdyn_swarmparticipantrule](msdyn_swarmparticipantrule.md#BKMK_owner_msdyn_swarmparticipantrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmparticipantrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_swarmparticipantrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_swarmrole"></a> owner_msdyn_swarmrole

Many-To-One Relationship: [msdyn_swarmrole owner_msdyn_swarmrole](msdyn_swarmrole.md#BKMK_owner_msdyn_swarmrole)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmrole`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_swarmrole`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_swarmskill"></a> owner_msdyn_swarmskill

Many-To-One Relationship: [msdyn_swarmskill owner_msdyn_swarmskill](msdyn_swarmskill.md#BKMK_owner_msdyn_swarmskill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmskill`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_swarmskill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_swarmtemplate"></a> owner_msdyn_swarmtemplate

Many-To-One Relationship: [msdyn_swarmtemplate owner_msdyn_swarmtemplate](msdyn_swarmtemplate.md#BKMK_owner_msdyn_swarmtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_swarmtemplate`|
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

### <a name="BKMK_owner_msdyn_taggedrecord"></a> owner_msdyn_taggedrecord

Many-To-One Relationship: [msdyn_taggedrecord owner_msdyn_taggedrecord](msdyn_taggedrecord.md#BKMK_owner_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taggedrecord`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_taggedrecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_taxcode"></a> owner_msdyn_taxcode

Many-To-One Relationship: [msdyn_taxcode owner_msdyn_taxcode](msdyn_taxcode.md#BKMK_owner_msdyn_taxcode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcode`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_taxcode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_taxcodedetail"></a> owner_msdyn_taxcodedetail

Many-To-One Relationship: [msdyn_taxcodedetail owner_msdyn_taxcodedetail](msdyn_taxcodedetail.md#BKMK_owner_msdyn_taxcodedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taxcodedetail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_taxcodedetail`|
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

### <a name="BKMK_owner_msdyn_teamsengagementctx"></a> owner_msdyn_teamsengagementctx

Many-To-One Relationship: [msdyn_teamsengagementctx owner_msdyn_teamsengagementctx](msdyn_teamsengagementctx.md#BKMK_owner_msdyn_teamsengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_teamsengagementctx`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_teamsengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_templateforproperties"></a> owner_msdyn_templateforproperties

Many-To-One Relationship: [msdyn_templateforproperties owner_msdyn_templateforproperties](msdyn_templateforproperties.md#BKMK_owner_msdyn_templateforproperties)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateforproperties`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_templateforproperties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_templateparameter"></a> owner_msdyn_templateparameter

Many-To-One Relationship: [msdyn_templateparameter owner_msdyn_templateparameter](msdyn_templateparameter.md#BKMK_owner_msdyn_templateparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateparameter`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_templateparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_templatetags"></a> owner_msdyn_templatetags

Many-To-One Relationship: [msdyn_templatetags owner_msdyn_templatetags](msdyn_templatetags.md#BKMK_owner_msdyn_templatetags)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templatetags`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_templatetags`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timeentry"></a> owner_msdyn_timeentry

Many-To-One Relationship: [msdyn_timeentry owner_msdyn_timeentry](msdyn_timeentry.md#BKMK_owner_msdyn_timeentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timeentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timeentrysetting"></a> owner_msdyn_timeentrysetting

Many-To-One Relationship: [msdyn_timeentrysetting owner_msdyn_timeentrysetting](msdyn_timeentrysetting.md#BKMK_owner_msdyn_timeentrysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentrysetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timeentrysetting`|
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

### <a name="BKMK_owner_msdyn_timeoffrequest"></a> owner_msdyn_timeoffrequest

Many-To-One Relationship: [msdyn_timeoffrequest owner_msdyn_timeoffrequest](msdyn_timeoffrequest.md#BKMK_owner_msdyn_timeoffrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeoffrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timeoffrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_timespent"></a> owner_msdyn_timespent

Many-To-One Relationship: [msdyn_timespent owner_msdyn_timespent](msdyn_timespent.md#BKMK_owner_msdyn_timespent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timespent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timespent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_trade"></a> owner_msdyn_trade

Many-To-One Relationship: [msdyn_trade owner_msdyn_trade](msdyn_trade.md#BKMK_owner_msdyn_trade)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_trade`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_trade`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_tradecoverage"></a> owner_msdyn_tradecoverage

Many-To-One Relationship: [msdyn_tradecoverage owner_msdyn_tradecoverage](msdyn_tradecoverage.md#BKMK_owner_msdyn_tradecoverage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_tradecoverage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_tradecoverage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_trainingresult"></a> owner_msdyn_trainingresult

Many-To-One Relationship: [msdyn_trainingresult owner_msdyn_trainingresult](msdyn_trainingresult.md#BKMK_owner_msdyn_trainingresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_trainingresult`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_trainingresult`|
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

### <a name="BKMK_owner_msdyn_transcript"></a> owner_msdyn_transcript

Many-To-One Relationship: [msdyn_transcript owner_msdyn_transcript](msdyn_transcript.md#BKMK_owner_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_transcript`|
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

### <a name="BKMK_owner_msdyn_unifiedroutingdiagnostic"></a> owner_msdyn_unifiedroutingdiagnostic

Many-To-One Relationship: [msdyn_unifiedroutingdiagnostic owner_msdyn_unifiedroutingdiagnostic](msdyn_unifiedroutingdiagnostic.md#BKMK_owner_msdyn_unifiedroutingdiagnostic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingdiagnostic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_unifiedroutingdiagnostic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_unifiedroutingrun"></a> owner_msdyn_unifiedroutingrun

Many-To-One Relationship: [msdyn_unifiedroutingrun owner_msdyn_unifiedroutingrun](msdyn_unifiedroutingrun.md#BKMK_owner_msdyn_unifiedroutingrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingrun`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_unifiedroutingrun`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_untrackedappointment"></a> owner_msdyn_untrackedappointment

Many-To-One Relationship: [msdyn_untrackedappointment owner_msdyn_untrackedappointment](msdyn_untrackedappointment.md#BKMK_owner_msdyn_untrackedappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_untrackedappointment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_untrackedappointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_urnotificationtemplate"></a> owner_msdyn_urnotificationtemplate

Many-To-One Relationship: [msdyn_urnotificationtemplate owner_msdyn_urnotificationtemplate](msdyn_urnotificationtemplate.md#BKMK_owner_msdyn_urnotificationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_urnotificationtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_urnotificationtemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_urnotificationtemplatemapping"></a> owner_msdyn_urnotificationtemplatemapping

Many-To-One Relationship: [msdyn_urnotificationtemplatemapping owner_msdyn_urnotificationtemplatemapping](msdyn_urnotificationtemplatemapping.md#BKMK_owner_msdyn_urnotificationtemplatemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_urnotificationtemplatemapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_urnotificationtemplatemapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_visitorjourney"></a> owner_msdyn_visitorjourney

Many-To-One Relationship: [msdyn_visitorjourney owner_msdyn_visitorjourney](msdyn_visitorjourney.md#BKMK_owner_msdyn_visitorjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_visitorjourney`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_visitorjourney`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_vivacustomerlist"></a> owner_msdyn_vivacustomerlist

Many-To-One Relationship: [msdyn_vivacustomerlist owner_msdyn_vivacustomerlist](msdyn_vivacustomerlist.md#BKMK_owner_msdyn_vivacustomerlist)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_vivacustomerlist`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_vivacustomerlist`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_vivausersetting"></a> owner_msdyn_vivausersetting

Many-To-One Relationship: [msdyn_vivausersetting owner_msdyn_vivausersetting](msdyn_vivausersetting.md#BKMK_owner_msdyn_vivausersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_vivausersetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_vivausersetting`|
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

### <a name="BKMK_owner_msdyn_wallsavedqueryusersettings"></a> owner_msdyn_wallsavedqueryusersettings

Many-To-One Relationship: [msdyn_wallsavedqueryusersettings owner_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_owner_msdyn_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wallsavedqueryusersettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_wallsavedqueryusersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_warehouse"></a> owner_msdyn_warehouse

Many-To-One Relationship: [msdyn_warehouse owner_msdyn_warehouse](msdyn_warehouse.md#BKMK_owner_msdyn_warehouse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warehouse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_warehouse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_warranty"></a> owner_msdyn_warranty

Many-To-One Relationship: [msdyn_warranty owner_msdyn_warranty](msdyn_warranty.md#BKMK_owner_msdyn_warranty)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warranty`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_warranty`|
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

### <a name="BKMK_owner_msdyn_wkwconfig"></a> owner_msdyn_wkwconfig

Many-To-One Relationship: [msdyn_wkwconfig owner_msdyn_wkwconfig](msdyn_wkwconfig.md#BKMK_owner_msdyn_wkwconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wkwconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_wkwconfig`|
|IsCustomizable|`True`|
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

### <a name="BKMK_owner_msdyn_workorder"></a> owner_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder owner_msdyn_workorder](msdyn_workorder.md#BKMK_owner_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workordercharacteristic"></a> owner_msdyn_workordercharacteristic

Many-To-One Relationship: [msdyn_workordercharacteristic owner_msdyn_workordercharacteristic](msdyn_workordercharacteristic.md#BKMK_owner_msdyn_workordercharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordercharacteristic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workordercharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderincident"></a> owner_msdyn_workorderincident

Many-To-One Relationship: [msdyn_workorderincident owner_msdyn_workorderincident](msdyn_workorderincident.md#BKMK_owner_msdyn_workorderincident)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderincident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workordernte"></a> owner_msdyn_workordernte

Many-To-One Relationship: [msdyn_workordernte owner_msdyn_workordernte](msdyn_workordernte.md#BKMK_owner_msdyn_workordernte)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordernte`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workordernte`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderproduct"></a> owner_msdyn_workorderproduct

Many-To-One Relationship: [msdyn_workorderproduct owner_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_owner_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderresolution"></a> owner_msdyn_workorderresolution

Many-To-One Relationship: [msdyn_workorderresolution owner_msdyn_workorderresolution](msdyn_workorderresolution.md#BKMK_owner_msdyn_workorderresolution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresolution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderresolution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderresourcerestriction"></a> owner_msdyn_workorderresourcerestriction

Many-To-One Relationship: [msdyn_workorderresourcerestriction owner_msdyn_workorderresourcerestriction](msdyn_workorderresourcerestriction.md#BKMK_owner_msdyn_workorderresourcerestriction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresourcerestriction`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderresourcerestriction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderservice"></a> owner_msdyn_workorderservice

Many-To-One Relationship: [msdyn_workorderservice owner_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_owner_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workorderservicetask"></a> owner_msdyn_workorderservicetask

Many-To-One Relationship: [msdyn_workorderservicetask owner_msdyn_workorderservicetask](msdyn_workorderservicetask.md#BKMK_owner_msdyn_workorderservicetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workorderservicetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workordersubstatus"></a> owner_msdyn_workordersubstatus

Many-To-One Relationship: [msdyn_workordersubstatus owner_msdyn_workordersubstatus](msdyn_workordersubstatus.md#BKMK_owner_msdyn_workordersubstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordersubstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workordersubstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workordertype"></a> owner_msdyn_workordertype

Many-To-One Relationship: [msdyn_workordertype owner_msdyn_workordertype](msdyn_workordertype.md#BKMK_owner_msdyn_workordertype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordertype`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workordertype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workqueuestate"></a> owner_msdyn_workqueuestate

Many-To-One Relationship: [msdyn_workqueuestate owner_msdyn_workqueuestate](msdyn_workqueuestate.md#BKMK_owner_msdyn_workqueuestate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workqueuestate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workqueuestate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_workqueueusersetting"></a> owner_msdyn_workqueueusersetting

Many-To-One Relationship: [msdyn_workqueueusersetting owner_msdyn_workqueueusersetting](msdyn_workqueueusersetting.md#BKMK_owner_msdyn_workqueueusersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workqueueusersetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_workqueueusersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_alternatekey"></a> owner_msdynci_alternatekey

Many-To-One Relationship: [msdynci_alternatekey owner_msdynci_alternatekey](msdynci_alternatekey.md#BKMK_owner_msdynci_alternatekey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_alternatekey`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_alternatekey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_contactprofile"></a> owner_msdynci_contactprofile

Many-To-One Relationship: [msdynci_contactprofile owner_msdynci_contactprofile](msdynci_contactprofile.md#BKMK_owner_msdynci_contactprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_contactprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_contactprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_customermeasure"></a> owner_msdynci_customermeasure

Many-To-One Relationship: [msdynci_customermeasure owner_msdynci_customermeasure](msdynci_customermeasure.md#BKMK_owner_msdynci_customermeasure)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_customermeasure`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_customermeasure`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_customerprofile"></a> owner_msdynci_customerprofile

Many-To-One Relationship: [msdynci_customerprofile owner_msdynci_customerprofile](msdynci_customerprofile.md#BKMK_owner_msdynci_customerprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_customerprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_customerprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_customerprofilesegment"></a> owner_msdynci_customerprofilesegment

Many-To-One Relationship: [msdynci_customerprofilesegment owner_msdynci_customerprofilesegment](msdynci_customerprofilesegment.md#BKMK_owner_msdynci_customerprofilesegment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_customerprofilesegment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_customerprofilesegment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_enrichment"></a> owner_msdynci_enrichment

Many-To-One Relationship: [msdynci_enrichment owner_msdynci_enrichment](msdynci_enrichment.md#BKMK_owner_msdynci_enrichment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_enrichment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_enrichment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_personalizationaction"></a> owner_msdynci_personalizationaction

Many-To-One Relationship: [msdynci_personalizationaction owner_msdynci_personalizationaction](msdynci_personalizationaction.md#BKMK_owner_msdynci_personalizationaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationaction`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_personalizationaction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_personalizationcookie"></a> owner_msdynci_personalizationcookie

Many-To-One Relationship: [msdynci_personalizationcookie owner_msdynci_personalizationcookie](msdynci_personalizationcookie.md#BKMK_owner_msdynci_personalizationcookie)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationcookie`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_personalizationcookie`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_personalizationuser"></a> owner_msdynci_personalizationuser

Many-To-One Relationship: [msdynci_personalizationuser owner_msdynci_personalizationuser](msdynci_personalizationuser.md#BKMK_owner_msdynci_personalizationuser)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationuser`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_personalizationuser`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_personalizationview"></a> owner_msdynci_personalizationview

Many-To-One Relationship: [msdynci_personalizationview owner_msdynci_personalizationview](msdynci_personalizationview.md#BKMK_owner_msdynci_personalizationview)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_personalizationview`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_personalizationview`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_prediction"></a> owner_msdynci_prediction

Many-To-One Relationship: [msdynci_prediction owner_msdynci_prediction](msdynci_prediction.md#BKMK_owner_msdynci_prediction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_prediction`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_prediction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_segmentmembership"></a> owner_msdynci_segmentmembership

Many-To-One Relationship: [msdynci_segmentmembership owner_msdynci_segmentmembership](msdynci_segmentmembership.md#BKMK_owner_msdynci_segmentmembership)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_segmentmembership`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_segmentmembership`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_unifiedactivity"></a> owner_msdynci_unifiedactivity

Many-To-One Relationship: [msdynci_unifiedactivity owner_msdynci_unifiedactivity](msdynci_unifiedactivity.md#BKMK_owner_msdynci_unifiedactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_unifiedactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_unifiedactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_unifiedcontact_alternatekey"></a> owner_msdynci_unifiedcontact_alternatekey

Many-To-One Relationship: [msdynci_unifiedcontact_alternatekey owner_msdynci_unifiedcontact_alternatekey](msdynci_unifiedcontact_alternatekey.md#BKMK_owner_msdynci_unifiedcontact_alternatekey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_unifiedcontact_alternatekey`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_unifiedcontact_alternatekey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_unifiedcontactprofile"></a> owner_msdynci_unifiedcontactprofile

Many-To-One Relationship: [msdynci_unifiedcontactprofile owner_msdynci_unifiedcontactprofile](msdynci_unifiedcontactprofile.md#BKMK_owner_msdynci_unifiedcontactprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_unifiedcontactprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_unifiedcontactprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynci_unifiedcontactsegment"></a> owner_msdynci_unifiedcontactsegment

Many-To-One Relationship: [msdynci_unifiedcontactsegment owner_msdynci_unifiedcontactsegment](msdynci_unifiedcontactsegment.md#BKMK_owner_msdynci_unifiedcontactsegment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynci_unifiedcontactsegment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynci_unifiedcontactsegment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_addtocalendarstyle"></a> owner_msdyncrm_addtocalendarstyle

Many-To-One Relationship: [msdyncrm_addtocalendarstyle owner_msdyncrm_addtocalendarstyle](msdyncrm_addtocalendarstyle.md#BKMK_owner_msdyncrm_addtocalendarstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_addtocalendarstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_addtocalendarstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_appointmentactivity"></a> owner_msdyncrm_appointmentactivity

Many-To-One Relationship: [msdyncrm_appointmentactivity owner_msdyncrm_appointmentactivity](msdyncrm_appointmentactivity.md#BKMK_owner_msdyncrm_appointmentactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_appointmentactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_appointmentactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_appointmentactivitymarketingtemplate"></a> owner_msdyncrm_appointmentactivitymarketingtemplate

Many-To-One Relationship: [msdyncrm_appointmentactivitymarketingtemplate owner_msdyncrm_appointmentactivitymarketingtemplate](msdyncrm_appointmentactivitymarketingtemplate.md#BKMK_owner_msdyncrm_appointmentactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_appointmentactivitymarketingtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_appointmentactivitymarketingtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_basestyle"></a> owner_msdyncrm_basestyle

Many-To-One Relationship: [msdyncrm_basestyle owner_msdyncrm_basestyle](msdyncrm_basestyle.md#BKMK_owner_msdyncrm_basestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_basestyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_basestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_buttonstyle"></a> owner_msdyncrm_buttonstyle

Many-To-One Relationship: [msdyncrm_buttonstyle owner_msdyncrm_buttonstyle](msdyncrm_buttonstyle.md#BKMK_owner_msdyncrm_buttonstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_buttonstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_buttonstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_cdnconfiguration"></a> owner_msdyncrm_cdnconfiguration

Many-To-One Relationship: [msdyncrm_cdnconfiguration owner_msdyncrm_cdnconfiguration](msdyncrm_cdnconfiguration.md#BKMK_owner_msdyncrm_cdnconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_cdnconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_cdnconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_cdsaconnectorconfiguration"></a> owner_msdyncrm_cdsaconnectorconfiguration

Many-To-One Relationship: [msdyncrm_cdsaconnectorconfiguration owner_msdyncrm_cdsaconnectorconfiguration](msdyncrm_cdsaconnectorconfiguration.md#BKMK_owner_msdyncrm_cdsaconnectorconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_cdsaconnectorconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_cdsaconnectorconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_codestyle"></a> owner_msdyncrm_codestyle

Many-To-One Relationship: [msdyncrm_codestyle owner_msdyncrm_codestyle](msdyncrm_codestyle.md#BKMK_owner_msdyncrm_codestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_codestyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_codestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_columnstyle"></a> owner_msdyncrm_columnstyle

Many-To-One Relationship: [msdyncrm_columnstyle owner_msdyncrm_columnstyle](msdyncrm_columnstyle.md#BKMK_owner_msdyncrm_columnstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_columnstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_columnstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_contentblock"></a> owner_msdyncrm_contentblock

Many-To-One Relationship: [msdyncrm_contentblock owner_msdyncrm_contentblock](msdyncrm_contentblock.md#BKMK_owner_msdyncrm_contentblock)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentblock`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_contentblock`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_contentblockstyle"></a> owner_msdyncrm_contentblockstyle

Many-To-One Relationship: [msdyncrm_contentblockstyle owner_msdyncrm_contentblockstyle](msdyncrm_contentblockstyle.md#BKMK_owner_msdyncrm_contentblockstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentblockstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_contentblockstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_contentsettings"></a> owner_msdyncrm_contentsettings

Many-To-One Relationship: [msdyncrm_contentsettings owner_msdyncrm_contentsettings](msdyncrm_contentsettings.md#BKMK_owner_msdyncrm_contentsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_contentsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_createleadactivity"></a> owner_msdyncrm_createleadactivity

Many-To-One Relationship: [msdyncrm_createleadactivity owner_msdyncrm_createleadactivity](msdyncrm_createleadactivity.md#BKMK_owner_msdyncrm_createleadactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_createleadactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_createleadactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_customerinsightsinfo"></a> owner_msdyncrm_customerinsightsinfo

Many-To-One Relationship: [msdyncrm_customerinsightsinfo owner_msdyncrm_customerinsightsinfo](msdyncrm_customerinsightsinfo.md#BKMK_owner_msdyncrm_customerinsightsinfo)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerinsightsinfo`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_customerinsightsinfo`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_customerjourney"></a> owner_msdyncrm_customerjourney

Many-To-One Relationship: [msdyncrm_customerjourney owner_msdyncrm_customerjourney](msdyncrm_customerjourney.md#BKMK_owner_msdyncrm_customerjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourney`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_customerjourney`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_customerjourneycustomchannelactivity"></a> owner_msdyncrm_customerjourneycustomchannelactivity

Many-To-One Relationship: [msdyncrm_customerjourneycustomchannelactivity owner_msdyncrm_customerjourneycustomchannelactivity](msdyncrm_customerjourneycustomchannelactivity.md#BKMK_owner_msdyncrm_customerjourneycustomchannelactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneycustomchannelactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_customerjourneycustomchannelactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_customerjourneyiteration"></a> owner_msdyncrm_customerjourneyiteration

Many-To-One Relationship: [msdyncrm_customerjourneyiteration owner_msdyncrm_customerjourneyiteration](msdyncrm_customerjourneyiteration.md#BKMK_owner_msdyncrm_customerjourneyiteration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneyiteration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_customerjourneyiteration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_customerjourneyruntimestate"></a> owner_msdyncrm_customerjourneyruntimestate

Many-To-One Relationship: [msdyncrm_customerjourneyruntimestate owner_msdyncrm_customerjourneyruntimestate](msdyncrm_customerjourneyruntimestate.md#BKMK_owner_msdyncrm_customerjourneyruntimestate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneyruntimestate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_customerjourneyruntimestate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_customerjourneytemplate"></a> owner_msdyncrm_customerjourneytemplate

Many-To-One Relationship: [msdyncrm_customerjourneytemplate owner_msdyncrm_customerjourneytemplate](msdyncrm_customerjourneytemplate.md#BKMK_owner_msdyncrm_customerjourneytemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneytemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_customerjourneytemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_customerjourneyworkflowlink"></a> owner_msdyncrm_customerjourneyworkflowlink

Many-To-One Relationship: [msdyncrm_customerjourneyworkflowlink owner_msdyncrm_customerjourneyworkflowlink](msdyncrm_customerjourneyworkflowlink.md#BKMK_owner_msdyncrm_customerjourneyworkflowlink)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneyworkflowlink`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_customerjourneyworkflowlink`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_defaultmarketingsetting"></a> owner_msdyncrm_defaultmarketingsetting

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting owner_msdyncrm_defaultmarketingsetting](msdyncrm_defaultmarketingsetting.md#BKMK_owner_msdyncrm_defaultmarketingsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_defaultmarketingsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_deprecatedcustomtileactivity"></a> owner_msdyncrm_deprecatedcustomtileactivity

Many-To-One Relationship: [msdyncrm_deprecatedcustomtileactivity owner_msdyncrm_deprecatedcustomtileactivity](msdyncrm_deprecatedcustomtileactivity.md#BKMK_owner_msdyncrm_deprecatedcustomtileactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedcustomtileactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_deprecatedcustomtileactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_deprecatedeventactivity"></a> owner_msdyncrm_deprecatedeventactivity

Many-To-One Relationship: [msdyncrm_deprecatedeventactivity owner_msdyncrm_deprecatedeventactivity](msdyncrm_deprecatedeventactivity.md#BKMK_owner_msdyncrm_deprecatedeventactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedeventactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_deprecatedeventactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_deprecatedformsprosurveyactivity"></a> owner_msdyncrm_deprecatedformsprosurveyactivity

Many-To-One Relationship: [msdyncrm_deprecatedformsprosurveyactivity owner_msdyncrm_deprecatedformsprosurveyactivity](msdyncrm_deprecatedformsprosurveyactivity.md#BKMK_owner_msdyncrm_deprecatedformsprosurveyactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedformsprosurveyactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_deprecatedformsprosurveyactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_deprecatedpageactivity"></a> owner_msdyncrm_deprecatedpageactivity

Many-To-One Relationship: [msdyncrm_deprecatedpageactivity owner_msdyncrm_deprecatedpageactivity](msdyncrm_deprecatedpageactivity.md#BKMK_owner_msdyncrm_deprecatedpageactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_deprecatedpageactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_deprecatedpageactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_designerfeatureavailability"></a> owner_msdyncrm_designerfeatureavailability

Many-To-One Relationship: [msdyncrm_designerfeatureavailability owner_msdyncrm_designerfeatureavailability](msdyncrm_designerfeatureavailability.md#BKMK_owner_msdyncrm_designerfeatureavailability)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_designerfeatureavailability`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_designerfeatureavailability`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_dividerstyle"></a> owner_msdyncrm_dividerstyle

Many-To-One Relationship: [msdyncrm_dividerstyle owner_msdyncrm_dividerstyle](msdyncrm_dividerstyle.md#BKMK_owner_msdyncrm_dividerstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_dividerstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_dividerstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_emailkeypoint"></a> owner_msdyncrm_emailkeypoint

Many-To-One Relationship: [msdyncrm_emailkeypoint owner_msdyncrm_emailkeypoint](msdyncrm_emailkeypoint.md#BKMK_owner_msdyncrm_emailkeypoint)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_emailkeypoint`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_emailkeypoint`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_featureconfiguration"></a> owner_msdyncrm_featureconfiguration

Many-To-One Relationship: [msdyncrm_featureconfiguration owner_msdyncrm_featureconfiguration](msdyncrm_featureconfiguration.md#BKMK_owner_msdyncrm_featureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_featureconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_featureconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_file"></a> owner_msdyncrm_file

Many-To-One Relationship: [msdyncrm_file owner_msdyncrm_file](msdyncrm_file.md#BKMK_owner_msdyncrm_file)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_file`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_file`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_formpage"></a> owner_msdyncrm_formpage

Many-To-One Relationship: [msdyncrm_formpage owner_msdyncrm_formpage](msdyncrm_formpage.md#BKMK_owner_msdyncrm_formpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_formpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_formpagetemplate"></a> owner_msdyncrm_formpagetemplate

Many-To-One Relationship: [msdyncrm_formpagetemplate owner_msdyncrm_formpagetemplate](msdyncrm_formpagetemplate.md#BKMK_owner_msdyncrm_formpagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_formpagetemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_formpagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_generalstyles"></a> owner_msdyncrm_generalstyles

Many-To-One Relationship: [msdyncrm_generalstyles owner_msdyncrm_generalstyles](msdyncrm_generalstyles.md#BKMK_owner_msdyncrm_generalstyles)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_generalstyles`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_generalstyles`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_geopin"></a> owner_msdyncrm_geopin

Many-To-One Relationship: [msdyncrm_geopin owner_msdyncrm_geopin](msdyncrm_geopin.md#BKMK_owner_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_geopin`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_geopin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_gpt3log"></a> owner_msdyncrm_gpt3log

Many-To-One Relationship: [msdyncrm_gpt3log owner_msdyncrm_gpt3log](msdyncrm_gpt3log.md#BKMK_owner_msdyncrm_gpt3log)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_gpt3log`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_gpt3log`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_gwennolfeatureconfiguration"></a> owner_msdyncrm_gwennolfeatureconfiguration

Many-To-One Relationship: [msdyncrm_gwennolfeatureconfiguration owner_msdyncrm_gwennolfeatureconfiguration](msdyncrm_gwennolfeatureconfiguration.md#BKMK_owner_msdyncrm_gwennolfeatureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_gwennolfeatureconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_gwennolfeatureconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_gwennolspamscoreactivity"></a> owner_msdyncrm_gwennolspamscoreactivity

Many-To-One Relationship: [msdyncrm_gwennolspamscoreactivity owner_msdyncrm_gwennolspamscoreactivity](msdyncrm_gwennolspamscoreactivity.md#BKMK_owner_msdyncrm_gwennolspamscoreactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_gwennolspamscoreactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_gwennolspamscoreactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_gwennolspamscorerequest"></a> owner_msdyncrm_gwennolspamscorerequest

Many-To-One Relationship: [msdyncrm_gwennolspamscorerequest owner_msdyncrm_gwennolspamscorerequest](msdyncrm_gwennolspamscorerequest.md#BKMK_owner_msdyncrm_gwennolspamscorerequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_gwennolspamscorerequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_gwennolspamscorerequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_imagestyle"></a> owner_msdyncrm_imagestyle

Many-To-One Relationship: [msdyncrm_imagestyle owner_msdyncrm_imagestyle](msdyncrm_imagestyle.md#BKMK_owner_msdyncrm_imagestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_imagestyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_imagestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_keyword"></a> owner_msdyncrm_keyword

Many-To-One Relationship: [msdyncrm_keyword owner_msdyncrm_keyword](msdyncrm_keyword.md#BKMK_owner_msdyncrm_keyword)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_keyword`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_keyword`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_launchworkflowactivity"></a> owner_msdyncrm_launchworkflowactivity

Many-To-One Relationship: [msdyncrm_launchworkflowactivity owner_msdyncrm_launchworkflowactivity](msdyncrm_launchworkflowactivity.md#BKMK_owner_msdyncrm_launchworkflowactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_launchworkflowactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_launchworkflowactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_layoutstyle"></a> owner_msdyncrm_layoutstyle

Many-To-One Relationship: [msdyncrm_layoutstyle owner_msdyncrm_layoutstyle](msdyncrm_layoutstyle.md#BKMK_owner_msdyncrm_layoutstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_layoutstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_layoutstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_leadscore"></a> owner_msdyncrm_leadscore

Many-To-One Relationship: [msdyncrm_leadscore owner_msdyncrm_leadscore](msdyncrm_leadscore.md#BKMK_owner_msdyncrm_leadscore)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadscore`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_leadscore`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_leadscore_v2"></a> owner_msdyncrm_leadscore_v2

Many-To-One Relationship: [msdyncrm_leadscore_v2 owner_msdyncrm_leadscore_v2](msdyncrm_leadscore_v2.md#BKMK_owner_msdyncrm_leadscore_v2)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadscore_v2`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_leadscore_v2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_leadscoremodel"></a> owner_msdyncrm_leadscoremodel

Many-To-One Relationship: [msdyncrm_leadscoremodel owner_msdyncrm_leadscoremodel](msdyncrm_leadscoremodel.md#BKMK_owner_msdyncrm_leadscoremodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_leadscoremodel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_leadscoremodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinaccount"></a> owner_msdyncrm_linkedinaccount

Many-To-One Relationship: [msdyncrm_linkedinaccount owner_msdyncrm_linkedinaccount](msdyncrm_linkedinaccount.md#BKMK_owner_msdyncrm_linkedinaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinactivity"></a> owner_msdyncrm_linkedinactivity

Many-To-One Relationship: [msdyncrm_linkedinactivity owner_msdyncrm_linkedinactivity](msdyncrm_linkedinactivity.md#BKMK_owner_msdyncrm_linkedinactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinaudience"></a> owner_msdyncrm_linkedinaudience

Many-To-One Relationship: [msdyncrm_linkedinaudience owner_msdyncrm_linkedinaudience](msdyncrm_linkedinaudience.md#BKMK_owner_msdyncrm_linkedinaudience)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinaudience`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinaudience`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedincampaign"></a> owner_msdyncrm_linkedincampaign

Many-To-One Relationship: [msdyncrm_linkedincampaign owner_msdyncrm_linkedincampaign](msdyncrm_linkedincampaign.md#BKMK_owner_msdyncrm_linkedincampaign)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedincampaign`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedincampaign`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedincampaignactivity"></a> owner_msdyncrm_linkedincampaignactivity

Many-To-One Relationship: [msdyncrm_linkedincampaignactivity owner_msdyncrm_linkedincampaignactivity](msdyncrm_linkedincampaignactivity.md#BKMK_owner_msdyncrm_linkedincampaignactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedincampaignactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedincampaignactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinconfiguration"></a> owner_msdyncrm_linkedinconfiguration

Many-To-One Relationship: [msdyncrm_linkedinconfiguration owner_msdyncrm_linkedinconfiguration](msdyncrm_linkedinconfiguration.md#BKMK_owner_msdyncrm_linkedinconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinfieldmapping"></a> owner_msdyncrm_linkedinfieldmapping

Many-To-One Relationship: [msdyncrm_linkedinfieldmapping owner_msdyncrm_linkedinfieldmapping](msdyncrm_linkedinfieldmapping.md#BKMK_owner_msdyncrm_linkedinfieldmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinfieldmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinform"></a> owner_msdyncrm_linkedinform

Many-To-One Relationship: [msdyncrm_linkedinform owner_msdyncrm_linkedinform](msdyncrm_linkedinform.md#BKMK_owner_msdyncrm_linkedinform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinform`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinformanswer"></a> owner_msdyncrm_linkedinformanswer

Many-To-One Relationship: [msdyncrm_linkedinformanswer owner_msdyncrm_linkedinformanswer](msdyncrm_linkedinformanswer.md#BKMK_owner_msdyncrm_linkedinformanswer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformanswer`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinformanswer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinformquestion"></a> owner_msdyncrm_linkedinformquestion

Many-To-One Relationship: [msdyncrm_linkedinformquestion owner_msdyncrm_linkedinformquestion](msdyncrm_linkedinformquestion.md#BKMK_owner_msdyncrm_linkedinformquestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformquestion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinformquestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinformsubmission"></a> owner_msdyncrm_linkedinformsubmission

Many-To-One Relationship: [msdyncrm_linkedinformsubmission owner_msdyncrm_linkedinformsubmission](msdyncrm_linkedinformsubmission.md#BKMK_owner_msdyncrm_linkedinformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformsubmission`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinformsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinleadmatchingstrategy"></a> owner_msdyncrm_linkedinleadmatchingstrategy

Many-To-One Relationship: [msdyncrm_linkedinleadmatchingstrategy owner_msdyncrm_linkedinleadmatchingstrategy](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_owner_msdyncrm_linkedinleadmatchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinleadmatchingstrategy`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_linkedinuserprofile"></a> owner_msdyncrm_linkedinuserprofile

Many-To-One Relationship: [msdyncrm_linkedinuserprofile owner_msdyncrm_linkedinuserprofile](msdyncrm_linkedinuserprofile.md#BKMK_owner_msdyncrm_linkedinuserprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinuserprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_linkedinuserprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_listform"></a> owner_msdyncrm_listform

Many-To-One Relationship: [msdyncrm_listform owner_msdyncrm_listform](msdyncrm_listform.md#BKMK_owner_msdyncrm_listform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_listform`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_listform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_liveentitydependency"></a> owner_msdyncrm_liveentitydependency

Many-To-One Relationship: [msdyncrm_liveentitydependency owner_msdyncrm_liveentitydependency](msdyncrm_liveentitydependency.md#BKMK_owner_msdyncrm_liveentitydependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_liveentitydependency`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_liveentitydependency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingdataimport"></a> owner_msdyncrm_marketingdataimport

Many-To-One Relationship: [msdyncrm_marketingdataimport owner_msdyncrm_marketingdataimport](msdyncrm_marketingdataimport.md#BKMK_owner_msdyncrm_marketingdataimport)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingdataimport`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingdataimport`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingdynamiccontentmetadata"></a> owner_msdyncrm_marketingdynamiccontentmetadata

Many-To-One Relationship: [msdyncrm_marketingdynamiccontentmetadata owner_msdyncrm_marketingdynamiccontentmetadata](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_owner_msdyncrm_marketingdynamiccontentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingdynamiccontentmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingemail"></a> owner_msdyncrm_marketingemail

Many-To-One Relationship: [msdyncrm_marketingemail owner_msdyncrm_marketingemail](msdyncrm_marketingemail.md#BKMK_owner_msdyncrm_marketingemail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingemail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingemailactivity"></a> owner_msdyncrm_marketingemailactivity

Many-To-One Relationship: [msdyncrm_marketingemailactivity owner_msdyncrm_marketingemailactivity](msdyncrm_marketingemailactivity.md#BKMK_owner_msdyncrm_marketingemailactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingemailactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingemaildynamiccontentmetadata"></a> owner_msdyncrm_marketingemaildynamiccontentmetadata

Many-To-One Relationship: [msdyncrm_marketingemaildynamiccontentmetadata owner_msdyncrm_marketingemaildynamiccontentmetadata](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_owner_msdyncrm_marketingemaildynamiccontentmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingemaildynamiccontentmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingemailtemplate"></a> owner_msdyncrm_marketingemailtemplate

Many-To-One Relationship: [msdyncrm_marketingemailtemplate owner_msdyncrm_marketingemailtemplate](msdyncrm_marketingemailtemplate.md#BKMK_owner_msdyncrm_marketingemailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingemailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingemailtest"></a> owner_msdyncrm_marketingemailtest

Many-To-One Relationship: [msdyncrm_marketingemailtest owner_msdyncrm_marketingemailtest](msdyncrm_marketingemailtest.md#BKMK_owner_msdyncrm_marketingemailtest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingemailtest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingemailtestattribute"></a> owner_msdyncrm_marketingemailtestattribute

Many-To-One Relationship: [msdyncrm_marketingemailtestattribute owner_msdyncrm_marketingemailtestattribute](msdyncrm_marketingemailtestattribute.md#BKMK_owner_msdyncrm_marketingemailtestattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtestattribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingemailtestattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingemailtestsend"></a> owner_msdyncrm_marketingemailtestsend

Many-To-One Relationship: [msdyncrm_marketingemailtestsend owner_msdyncrm_marketingemailtestsend](msdyncrm_marketingemailtestsend.md#BKMK_owner_msdyncrm_marketingemailtestsend)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtestsend`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingemailtestsend`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingfieldsubmission"></a> owner_msdyncrm_marketingfieldsubmission

Many-To-One Relationship: [msdyncrm_marketingfieldsubmission owner_msdyncrm_marketingfieldsubmission](msdyncrm_marketingfieldsubmission.md#BKMK_owner_msdyncrm_marketingfieldsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingfieldsubmission`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingfieldsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingform"></a> owner_msdyncrm_marketingform

Many-To-One Relationship: [msdyncrm_marketingform owner_msdyncrm_marketingform](msdyncrm_marketingform.md#BKMK_owner_msdyncrm_marketingform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingform`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingformactivity"></a> owner_msdyncrm_marketingformactivity

Many-To-One Relationship: [msdyncrm_marketingformactivity owner_msdyncrm_marketingformactivity](msdyncrm_marketingformactivity.md#BKMK_owner_msdyncrm_marketingformactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingformactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingformfield"></a> owner_msdyncrm_marketingformfield

Many-To-One Relationship: [msdyncrm_marketingformfield owner_msdyncrm_marketingformfield](msdyncrm_marketingformfield.md#BKMK_owner_msdyncrm_marketingformfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformfield`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingformfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingformsubmission"></a> owner_msdyncrm_marketingformsubmission

Many-To-One Relationship: [msdyncrm_marketingformsubmission owner_msdyncrm_marketingformsubmission](msdyncrm_marketingformsubmission.md#BKMK_owner_msdyncrm_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformsubmission`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingformsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingformtemplate"></a> owner_msdyncrm_marketingformtemplate

Many-To-One Relationship: [msdyncrm_marketingformtemplate owner_msdyncrm_marketingformtemplate](msdyncrm_marketingformtemplate.md#BKMK_owner_msdyncrm_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingformtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingformwhitelistrule"></a> owner_msdyncrm_marketingformwhitelistrule

Many-To-One Relationship: [msdyncrm_marketingformwhitelistrule owner_msdyncrm_marketingformwhitelistrule](msdyncrm_marketingformwhitelistrule.md#BKMK_owner_msdyncrm_marketingformwhitelistrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformwhitelistrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingformwhitelistrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingpage"></a> owner_msdyncrm_marketingpage

Many-To-One Relationship: [msdyncrm_marketingpage owner_msdyncrm_marketingpage](msdyncrm_marketingpage.md#BKMK_owner_msdyncrm_marketingpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingpage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_marketingpagetemplate"></a> owner_msdyncrm_marketingpagetemplate

Many-To-One Relationship: [msdyncrm_marketingpagetemplate owner_msdyncrm_marketingpagetemplate](msdyncrm_marketingpagetemplate.md#BKMK_owner_msdyncrm_marketingpagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingpagetemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_marketingpagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_matchingstrategyattribute"></a> owner_msdyncrm_matchingstrategyattribute

Many-To-One Relationship: [msdyncrm_matchingstrategyattribute owner_msdyncrm_matchingstrategyattribute](msdyncrm_matchingstrategyattribute.md#BKMK_owner_msdyncrm_matchingstrategyattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_matchingstrategyattribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_matchingstrategyattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_migration"></a> owner_msdyncrm_migration

Many-To-One Relationship: [msdyncrm_migration owner_msdyncrm_migration](msdyncrm_migration.md#BKMK_owner_msdyncrm_migration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_migration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_migration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_mktactivity"></a> owner_msdyncrm_mktactivity

Many-To-One Relationship: [msdyncrm_mktactivity owner_msdyncrm_mktactivity](msdyncrm_mktactivity.md#BKMK_owner_msdyncrm_mktactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_mktactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_mktactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_networkpage"></a> owner_msdyncrm_networkpage

Many-To-One Relationship: [msdyncrm_networkpage owner_msdyncrm_networkpage](msdyncrm_networkpage.md#BKMK_owner_msdyncrm_networkpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_networkpage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_networkpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_personalizedpage"></a> owner_msdyncrm_personalizedpage

Many-To-One Relationship: [msdyncrm_personalizedpage owner_msdyncrm_personalizedpage](msdyncrm_personalizedpage.md#BKMK_owner_msdyncrm_personalizedpage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_personalizedpage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_personalizedpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_personalizedpagefield"></a> owner_msdyncrm_personalizedpagefield

Many-To-One Relationship: [msdyncrm_personalizedpagefield owner_msdyncrm_personalizedpagefield](msdyncrm_personalizedpagefield.md#BKMK_owner_msdyncrm_personalizedpagefield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_personalizedpagefield`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_personalizedpagefield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_phonecallactivity"></a> owner_msdyncrm_phonecallactivity

Many-To-One Relationship: [msdyncrm_phonecallactivity owner_msdyncrm_phonecallactivity](msdyncrm_phonecallactivity.md#BKMK_owner_msdyncrm_phonecallactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_phonecallactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_phonecallactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_phonecallactivitymarketingtemplate"></a> owner_msdyncrm_phonecallactivitymarketingtemplate

Many-To-One Relationship: [msdyncrm_phonecallactivitymarketingtemplate owner_msdyncrm_phonecallactivitymarketingtemplate](msdyncrm_phonecallactivitymarketingtemplate.md#BKMK_owner_msdyncrm_phonecallactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_phonecallactivitymarketingtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_phonecallactivitymarketingtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_postingishts"></a> owner_msdyncrm_postingishts

Many-To-One Relationship: [msdyncrm_postingishts owner_msdyncrm_postingishts](msdyncrm_postingishts.md#BKMK_owner_msdyncrm_postingishts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_postingishts`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_postingishts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_qrcodestyle"></a> owner_msdyncrm_qrcodestyle

Many-To-One Relationship: [msdyncrm_qrcodestyle owner_msdyncrm_qrcodestyle](msdyncrm_qrcodestyle.md#BKMK_owner_msdyncrm_qrcodestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_qrcodestyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_qrcodestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_quicksendemail"></a> owner_msdyncrm_quicksendemail

Many-To-One Relationship: [msdyncrm_quicksendemail owner_msdyncrm_quicksendemail](msdyncrm_quicksendemail.md#BKMK_owner_msdyncrm_quicksendemail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_quicksendemail`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_quicksendemail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_reaction"></a> owner_msdyncrm_reaction

Many-To-One Relationship: [msdyncrm_reaction owner_msdyncrm_reaction](msdyncrm_reaction.md#BKMK_owner_msdyncrm_reaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_reaction`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_reaction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_recordupdateactivity"></a> owner_msdyncrm_recordupdateactivity

Many-To-One Relationship: [msdyncrm_recordupdateactivity owner_msdyncrm_recordupdateactivity](msdyncrm_recordupdateactivity.md#BKMK_owner_msdyncrm_recordupdateactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_recordupdateactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_recordupdateactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_redirecturl"></a> owner_msdyncrm_redirecturl

Many-To-One Relationship: [msdyncrm_redirecturl owner_msdyncrm_redirecturl](msdyncrm_redirecturl.md#BKMK_owner_msdyncrm_redirecturl)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_redirecturl`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_redirecturl`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_segment"></a> owner_msdyncrm_segment

Many-To-One Relationship: [msdyncrm_segment owner_msdyncrm_segment](msdyncrm_segment.md#BKMK_owner_msdyncrm_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_segment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_segment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_segmentactivity"></a> owner_msdyncrm_segmentactivity

Many-To-One Relationship: [msdyncrm_segmentactivity owner_msdyncrm_segmentactivity](msdyncrm_segmentactivity.md#BKMK_owner_msdyncrm_segmentactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_segmentactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_segmentactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_segmenttemplate"></a> owner_msdyncrm_segmenttemplate

Many-To-One Relationship: [msdyncrm_segmenttemplate owner_msdyncrm_segmenttemplate](msdyncrm_segmenttemplate.md#BKMK_owner_msdyncrm_segmenttemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_segmenttemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_segmenttemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_socialpost"></a> owner_msdyncrm_socialpost

Many-To-One Relationship: [msdyncrm_socialpost owner_msdyncrm_socialpost](msdyncrm_socialpost.md#BKMK_owner_msdyncrm_socialpost)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_socialpost`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_socialpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_socialpostingconfiguration"></a> owner_msdyncrm_socialpostingconfiguration

Many-To-One Relationship: [msdyncrm_socialpostingconfiguration owner_msdyncrm_socialpostingconfiguration](msdyncrm_socialpostingconfiguration.md#BKMK_owner_msdyncrm_socialpostingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_socialpostingconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_socialpostingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_socialpostingconsent"></a> owner_msdyncrm_socialpostingconsent

Many-To-One Relationship: [msdyncrm_socialpostingconsent owner_msdyncrm_socialpostingconsent](msdyncrm_socialpostingconsent.md#BKMK_owner_msdyncrm_socialpostingconsent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_socialpostingconsent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_socialpostingconsent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_sourceactivity"></a> owner_msdyncrm_sourceactivity

Many-To-One Relationship: [msdyncrm_sourceactivity owner_msdyncrm_sourceactivity](msdyncrm_sourceactivity.md#BKMK_owner_msdyncrm_sourceactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_sourceactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_sourceactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_splitteractivity"></a> owner_msdyncrm_splitteractivity

Many-To-One Relationship: [msdyncrm_splitteractivity owner_msdyncrm_splitteractivity](msdyncrm_splitteractivity.md#BKMK_owner_msdyncrm_splitteractivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_splitteractivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_splitteractivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_tag"></a> owner_msdyncrm_tag

Many-To-One Relationship: [msdyncrm_tag owner_msdyncrm_tag](msdyncrm_tag.md#BKMK_owner_msdyncrm_tag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_tag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_tag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_taskactivity"></a> owner_msdyncrm_taskactivity

Many-To-One Relationship: [msdyncrm_taskactivity owner_msdyncrm_taskactivity](msdyncrm_taskactivity.md#BKMK_owner_msdyncrm_taskactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_taskactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_taskactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_taskactivitymarketingtemplate"></a> owner_msdyncrm_taskactivitymarketingtemplate

Many-To-One Relationship: [msdyncrm_taskactivitymarketingtemplate owner_msdyncrm_taskactivitymarketingtemplate](msdyncrm_taskactivitymarketingtemplate.md#BKMK_owner_msdyncrm_taskactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_taskactivitymarketingtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_taskactivitymarketingtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_textstyle"></a> owner_msdyncrm_textstyle

Many-To-One Relationship: [msdyncrm_textstyle owner_msdyncrm_textstyle](msdyncrm_textstyle.md#BKMK_owner_msdyncrm_textstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_textstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_textstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_triggeractivity"></a> owner_msdyncrm_triggeractivity

Many-To-One Relationship: [msdyncrm_triggeractivity owner_msdyncrm_triggeractivity](msdyncrm_triggeractivity.md#BKMK_owner_msdyncrm_triggeractivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_triggeractivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_triggeractivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_uicconfig"></a> owner_msdyncrm_uicconfig

Many-To-One Relationship: [msdyncrm_uicconfig owner_msdyncrm_uicconfig](msdyncrm_uicconfig.md#BKMK_owner_msdyncrm_uicconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_uicconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_uicconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_usergeoregion"></a> owner_msdyncrm_usergeoregion

Many-To-One Relationship: [msdyncrm_usergeoregion owner_msdyncrm_usergeoregion](msdyncrm_usergeoregion.md#BKMK_owner_msdyncrm_usergeoregion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_usergeoregion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_usergeoregion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_usersetting"></a> owner_msdyncrm_usersetting

Many-To-One Relationship: [msdyncrm_usersetting owner_msdyncrm_usersetting](msdyncrm_usersetting.md#BKMK_owner_msdyncrm_usersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_usersetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_usersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_video"></a> owner_msdyncrm_video

Many-To-One Relationship: [msdyncrm_video owner_msdyncrm_video](msdyncrm_video.md#BKMK_owner_msdyncrm_video)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_video`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_video`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_videostyle"></a> owner_msdyncrm_videostyle

Many-To-One Relationship: [msdyncrm_videostyle owner_msdyncrm_videostyle](msdyncrm_videostyle.md#BKMK_owner_msdyncrm_videostyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_videostyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_videostyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyncrm_website"></a> owner_msdyncrm_website

Many-To-One Relationship: [msdyncrm_website owner_msdyncrm_website](msdyncrm_website.md#BKMK_owner_msdyncrm_website)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_website`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_website`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_aimodelversion"></a> owner_msdynmkt_aimodelversion

Many-To-One Relationship: [msdynmkt_aimodelversion owner_msdynmkt_aimodelversion](msdynmkt_aimodelversion.md#BKMK_owner_msdynmkt_aimodelversion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_aimodelversion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_aimodelversion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_apsconfig"></a> owner_msdynmkt_apsconfig

Many-To-One Relationship: [msdynmkt_apsconfig owner_msdynmkt_apsconfig](msdynmkt_apsconfig.md#BKMK_owner_msdynmkt_apsconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_apsconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_apsconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_brandprofile"></a> owner_msdynmkt_brandprofile

Many-To-One Relationship: [msdynmkt_brandprofile owner_msdynmkt_brandprofile](msdynmkt_brandprofile.md#BKMK_owner_msdynmkt_brandprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_brandprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_brandprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_brandsender"></a> owner_msdynmkt_brandsender

Many-To-One Relationship: [msdynmkt_brandsender owner_msdynmkt_brandsender](msdynmkt_brandsender.md#BKMK_owner_msdynmkt_brandsender)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_brandsender`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_brandsender`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_brandtheme"></a> owner_msdynmkt_brandtheme

Many-To-One Relationship: [msdynmkt_brandtheme owner_msdynmkt_brandtheme](msdynmkt_brandtheme.md#BKMK_owner_msdynmkt_brandtheme)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_brandtheme`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_brandtheme`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_buttonstyle"></a> owner_msdynmkt_buttonstyle

Many-To-One Relationship: [msdynmkt_buttonstyle owner_msdynmkt_buttonstyle](msdynmkt_buttonstyle.md#BKMK_owner_msdynmkt_buttonstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_buttonstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_buttonstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_byoacschannelinstance"></a> owner_msdynmkt_byoacschannelinstance

Many-To-One Relationship: [msdynmkt_byoacschannelinstance owner_msdynmkt_byoacschannelinstance](msdynmkt_byoacschannelinstance.md#BKMK_owner_msdynmkt_byoacschannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_byoacschannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_byoacschannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_byoacschannelinstanceaccount"></a> owner_msdynmkt_byoacschannelinstanceaccount

Many-To-One Relationship: [msdynmkt_byoacschannelinstanceaccount owner_msdynmkt_byoacschannelinstanceaccount](msdynmkt_byoacschannelinstanceaccount.md#BKMK_owner_msdynmkt_byoacschannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_byoacschannelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_byoacschannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_captcha"></a> owner_msdynmkt_captcha

Many-To-One Relationship: [msdynmkt_captcha owner_msdynmkt_captcha](msdynmkt_captcha.md#BKMK_owner_msdynmkt_captcha)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_captcha`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_captcha`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_catalogeventstatusconfiguration"></a> owner_msdynmkt_catalogeventstatusconfiguration

Many-To-One Relationship: [msdynmkt_catalogeventstatusconfiguration owner_msdynmkt_catalogeventstatusconfiguration](msdynmkt_catalogeventstatusconfiguration.md#BKMK_owner_msdynmkt_catalogeventstatusconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_catalogeventstatusconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_catalogeventstatusconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_compliancesettings3"></a> owner_msdynmkt_compliancesettings3

Many-To-One Relationship: [msdynmkt_compliancesettings3 owner_msdynmkt_compliancesettings3](msdynmkt_compliancesettings3.md#BKMK_owner_msdynmkt_compliancesettings3)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_compliancesettings3`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_compliancesettings3`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_compliancesettings4"></a> owner_msdynmkt_compliancesettings4

Many-To-One Relationship: [msdynmkt_compliancesettings4 owner_msdynmkt_compliancesettings4](msdynmkt_compliancesettings4.md#BKMK_owner_msdynmkt_compliancesettings4)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_compliancesettings4`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_compliancesettings4`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_configuration"></a> owner_msdynmkt_configuration

Many-To-One Relationship: [msdynmkt_configuration owner_msdynmkt_configuration](msdynmkt_configuration.md#BKMK_owner_msdynmkt_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_configuration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_configuration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_consentprovider"></a> owner_msdynmkt_consentprovider

Many-To-One Relationship: [msdynmkt_consentprovider owner_msdynmkt_consentprovider](msdynmkt_consentprovider.md#BKMK_owner_msdynmkt_consentprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_consentprovider`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_consentprovider`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_consentproviderdefaultconfiguration"></a> owner_msdynmkt_consentproviderdefaultconfiguration

Many-To-One Relationship: [msdynmkt_consentproviderdefaultconfiguration owner_msdynmkt_consentproviderdefaultconfiguration](msdynmkt_consentproviderdefaultconfiguration.md#BKMK_owner_msdynmkt_consentproviderdefaultconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_consentproviderdefaultconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_consentproviderdefaultconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_consentproviderdefaultpurpose"></a> owner_msdynmkt_consentproviderdefaultpurpose

Many-To-One Relationship: [msdynmkt_consentproviderdefaultpurpose owner_msdynmkt_consentproviderdefaultpurpose](msdynmkt_consentproviderdefaultpurpose.md#BKMK_owner_msdynmkt_consentproviderdefaultpurpose)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_consentproviderdefaultpurpose`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_consentproviderdefaultpurpose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_consentsystemconfiguration"></a> owner_msdynmkt_consentsystemconfiguration

Many-To-One Relationship: [msdynmkt_consentsystemconfiguration owner_msdynmkt_consentsystemconfiguration](msdynmkt_consentsystemconfiguration.md#BKMK_owner_msdynmkt_consentsystemconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_consentsystemconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_consentsystemconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_contactpointconsent"></a> owner_msdynmkt_contactpointconsent

Many-To-One Relationship: [msdynmkt_contactpointconsent owner_msdynmkt_contactpointconsent](msdynmkt_contactpointconsent.md#BKMK_owner_msdynmkt_contactpointconsent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_contactpointconsent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_contactpointconsent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_contactpointconsent3"></a> owner_msdynmkt_contactpointconsent3

Many-To-One Relationship: [msdynmkt_contactpointconsent3 owner_msdynmkt_contactpointconsent3](msdynmkt_contactpointconsent3.md#BKMK_owner_msdynmkt_contactpointconsent3)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_contactpointconsent3`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_contactpointconsent3`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_contactpointconsent4"></a> owner_msdynmkt_contactpointconsent4

Many-To-One Relationship: [msdynmkt_contactpointconsent4 owner_msdynmkt_contactpointconsent4](msdynmkt_contactpointconsent4.md#BKMK_owner_msdynmkt_contactpointconsent4)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_contactpointconsent4`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_contactpointconsent4`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_conversioneventdefinition"></a> owner_msdynmkt_conversioneventdefinition

Many-To-One Relationship: [msdynmkt_conversioneventdefinition owner_msdynmkt_conversioneventdefinition](msdynmkt_conversioneventdefinition.md#BKMK_owner_msdynmkt_conversioneventdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_conversioneventdefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_conversioneventdefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_createdentitylink"></a> owner_msdynmkt_createdentitylink

Many-To-One Relationship: [msdynmkt_createdentitylink owner_msdynmkt_createdentitylink](msdynmkt_createdentitylink.md#BKMK_owner_msdynmkt_createdentitylink)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_createdentitylink`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_createdentitylink`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_customchannelmessage"></a> owner_msdynmkt_customchannelmessage

Many-To-One Relationship: [msdynmkt_customchannelmessage owner_msdynmkt_customchannelmessage](msdynmkt_customchannelmessage.md#BKMK_owner_msdynmkt_customchannelmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_customchannelmessage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_customchannelmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_domain"></a> owner_msdynmkt_domain

Many-To-One Relationship: [msdynmkt_domain owner_msdynmkt_domain](msdynmkt_domain.md#BKMK_owner_msdynmkt_domain)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_domain`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_domain`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_email"></a> owner_msdynmkt_email

Many-To-One Relationship: [msdynmkt_email owner_msdynmkt_email](msdynmkt_email.md#BKMK_owner_msdynmkt_email)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_email`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_email`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_emailtemplate"></a> owner_msdynmkt_emailtemplate

Many-To-One Relationship: [msdynmkt_emailtemplate owner_msdynmkt_emailtemplate](msdynmkt_emailtemplate.md#BKMK_owner_msdynmkt_emailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_emailtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_emailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_entitygradedistribution"></a> owner_msdynmkt_entitygradedistribution

Many-To-One Relationship: [msdynmkt_entitygradedistribution owner_msdynmkt_entitygradedistribution](msdynmkt_entitygradedistribution.md#BKMK_owner_msdynmkt_entitygradedistribution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_entitygradedistribution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_entitygradedistribution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_entityscoredistribution"></a> owner_msdynmkt_entityscoredistribution

Many-To-One Relationship: [msdynmkt_entityscoredistribution owner_msdynmkt_entityscoredistribution](msdynmkt_entityscoredistribution.md#BKMK_owner_msdynmkt_entityscoredistribution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_entityscoredistribution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_entityscoredistribution`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_entityscoringmodel"></a> owner_msdynmkt_entityscoringmodel

Many-To-One Relationship: [msdynmkt_entityscoringmodel owner_msdynmkt_entityscoringmodel](msdynmkt_entityscoringmodel.md#BKMK_owner_msdynmkt_entityscoringmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_entityscoringmodel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_entityscoringmodel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_eventmetadata"></a> owner_msdynmkt_eventmetadata

Many-To-One Relationship: [msdynmkt_eventmetadata owner_msdynmkt_eventmetadata](msdynmkt_eventmetadata.md#BKMK_owner_msdynmkt_eventmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventmetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_eventmetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_eventparametermetadata"></a> owner_msdynmkt_eventparametermetadata

Many-To-One Relationship: [msdynmkt_eventparametermetadata owner_msdynmkt_eventparametermetadata](msdynmkt_eventparametermetadata.md#BKMK_owner_msdynmkt_eventparametermetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventparametermetadata`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_eventparametermetadata`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_experiment"></a> owner_msdynmkt_experiment

Many-To-One Relationship: [msdynmkt_experiment owner_msdynmkt_experiment](msdynmkt_experiment.md#BKMK_owner_msdynmkt_experiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_experiment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_experiment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_experimentv2"></a> owner_msdynmkt_experimentv2

Many-To-One Relationship: [msdynmkt_experimentv2 owner_msdynmkt_experimentv2](msdynmkt_experimentv2.md#BKMK_owner_msdynmkt_experimentv2)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_experimentv2`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_experimentv2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_featureconfiguration"></a> owner_msdynmkt_featureconfiguration

Many-To-One Relationship: [msdynmkt_featureconfiguration owner_msdynmkt_featureconfiguration](msdynmkt_featureconfiguration.md#BKMK_owner_msdynmkt_featureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_featureconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_featureconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_fragment"></a> owner_msdynmkt_fragment

Many-To-One Relationship: [msdynmkt_fragment owner_msdynmkt_fragment](msdynmkt_fragment.md#BKMK_owner_msdynmkt_fragment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_fragment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_fragment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_frequencycap"></a> owner_msdynmkt_frequencycap

Many-To-One Relationship: [msdynmkt_frequencycap owner_msdynmkt_frequencycap](msdynmkt_frequencycap.md#BKMK_owner_msdynmkt_frequencycap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_frequencycap`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_frequencycap`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_gdprrequest"></a> owner_msdynmkt_gdprrequest

Many-To-One Relationship: [msdynmkt_gdprrequest owner_msdynmkt_gdprrequest](msdynmkt_gdprrequest.md#BKMK_owner_msdynmkt_gdprrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_gdprrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_gdprrequest`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_imagestyle"></a> owner_msdynmkt_imagestyle

Many-To-One Relationship: [msdynmkt_imagestyle owner_msdynmkt_imagestyle](msdynmkt_imagestyle.md#BKMK_owner_msdynmkt_imagestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_imagestyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_imagestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_infobipchannelinstance"></a> owner_msdynmkt_infobipchannelinstance

Many-To-One Relationship: [msdynmkt_infobipchannelinstance owner_msdynmkt_infobipchannelinstance](msdynmkt_infobipchannelinstance.md#BKMK_owner_msdynmkt_infobipchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_infobipchannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_infobipchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_infobipchannelinstanceaccount"></a> owner_msdynmkt_infobipchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_infobipchannelinstanceaccount owner_msdynmkt_infobipchannelinstanceaccount](msdynmkt_infobipchannelinstanceaccount.md#BKMK_owner_msdynmkt_infobipchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_infobipchannelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_infobipchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_journey"></a> owner_msdynmkt_journey

Many-To-One Relationship: [msdynmkt_journey owner_msdynmkt_journey](msdynmkt_journey.md#BKMK_owner_msdynmkt_journey)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journey`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_journey`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_journeydependency"></a> owner_msdynmkt_journeydependency

Many-To-One Relationship: [msdynmkt_journeydependency owner_msdynmkt_journeydependency](msdynmkt_journeydependency.md#BKMK_owner_msdynmkt_journeydependency)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeydependency`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_journeydependency`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_journeyevent"></a> owner_msdynmkt_journeyevent

Many-To-One Relationship: [msdynmkt_journeyevent owner_msdynmkt_journeyevent](msdynmkt_journeyevent.md#BKMK_owner_msdynmkt_journeyevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyevent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_journeyevent`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_journeyoptimizationcount"></a> owner_msdynmkt_journeyoptimizationcount

Many-To-One Relationship: [msdynmkt_journeyoptimizationcount owner_msdynmkt_journeyoptimizationcount](msdynmkt_journeyoptimizationcount.md#BKMK_owner_msdynmkt_journeyoptimizationcount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyoptimizationcount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_journeyoptimizationcount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_journeyrunparameter"></a> owner_msdynmkt_journeyrunparameter

Many-To-One Relationship: [msdynmkt_journeyrunparameter owner_msdynmkt_journeyrunparameter](msdynmkt_journeyrunparameter.md#BKMK_owner_msdynmkt_journeyrunparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyrunparameter`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_journeyrunparameter`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_journeysetting"></a> owner_msdynmkt_journeysetting

Many-To-One Relationship: [msdynmkt_journeysetting owner_msdynmkt_journeysetting](msdynmkt_journeysetting.md#BKMK_owner_msdynmkt_journeysetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeysetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_journeysetting`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_journeytemplate"></a> owner_msdynmkt_journeytemplate

Many-To-One Relationship: [msdynmkt_journeytemplate owner_msdynmkt_journeytemplate](msdynmkt_journeytemplate.md#BKMK_owner_msdynmkt_journeytemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeytemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_journeytemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_journeyworkflowmapping"></a> owner_msdynmkt_journeyworkflowmapping

Many-To-One Relationship: [msdynmkt_journeyworkflowmapping owner_msdynmkt_journeyworkflowmapping](msdynmkt_journeyworkflowmapping.md#BKMK_owner_msdynmkt_journeyworkflowmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeyworkflowmapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_journeyworkflowmapping`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_keyword"></a> owner_msdynmkt_keyword

Many-To-One Relationship: [msdynmkt_keyword owner_msdynmkt_keyword](msdynmkt_keyword.md#BKMK_owner_msdynmkt_keyword)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_keyword`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_keyword`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_leadqualificationmodel"></a> owner_msdynmkt_leadqualificationmodel

Many-To-One Relationship: [msdynmkt_leadqualificationmodel owner_msdynmkt_leadqualificationmodel](msdynmkt_leadqualificationmodel.md#BKMK_owner_msdynmkt_leadqualificationmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_leadqualificationmodel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_leadqualificationmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_linkmobilitychannelinstance"></a> owner_msdynmkt_linkmobilitychannelinstance

Many-To-One Relationship: [msdynmkt_linkmobilitychannelinstance owner_msdynmkt_linkmobilitychannelinstance](msdynmkt_linkmobilitychannelinstance.md#BKMK_owner_msdynmkt_linkmobilitychannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_linkmobilitychannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_linkmobilitychannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_linkmobilitychannelinstanceaccount"></a> owner_msdynmkt_linkmobilitychannelinstanceaccount

Many-To-One Relationship: [msdynmkt_linkmobilitychannelinstanceaccount owner_msdynmkt_linkmobilitychannelinstanceaccount](msdynmkt_linkmobilitychannelinstanceaccount.md#BKMK_owner_msdynmkt_linkmobilitychannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_linkmobilitychannelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_linkmobilitychannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_marketingfieldsubmission"></a> owner_msdynmkt_marketingfieldsubmission

Many-To-One Relationship: [msdynmkt_marketingfieldsubmission owner_msdynmkt_marketingfieldsubmission](msdynmkt_marketingfieldsubmission.md#BKMK_owner_msdynmkt_marketingfieldsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingfieldsubmission`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_marketingfieldsubmission`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_marketingform"></a> owner_msdynmkt_marketingform

Many-To-One Relationship: [msdynmkt_marketingform owner_msdynmkt_marketingform](msdynmkt_marketingform.md#BKMK_owner_msdynmkt_marketingform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingform`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_marketingform`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_marketingformfield"></a> owner_msdynmkt_marketingformfield

Many-To-One Relationship: [msdynmkt_marketingformfield owner_msdynmkt_marketingformfield](msdynmkt_marketingformfield.md#BKMK_owner_msdynmkt_marketingformfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformfield`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_marketingformfield`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_marketingformsubmission"></a> owner_msdynmkt_marketingformsubmission

Many-To-One Relationship: [msdynmkt_marketingformsubmission owner_msdynmkt_marketingformsubmission](msdynmkt_marketingformsubmission.md#BKMK_owner_msdynmkt_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformsubmission`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_marketingformsubmission`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_marketingformtemplate"></a> owner_msdynmkt_marketingformtemplate

Many-To-One Relationship: [msdynmkt_marketingformtemplate owner_msdynmkt_marketingformtemplate](msdynmkt_marketingformtemplate.md#BKMK_owner_msdynmkt_marketingformtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_marketingformtemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_matchingstrategy"></a> owner_msdynmkt_matchingstrategy

Many-To-One Relationship: [msdynmkt_matchingstrategy owner_msdynmkt_matchingstrategy](msdynmkt_matchingstrategy.md#BKMK_owner_msdynmkt_matchingstrategy)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_matchingstrategy`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_matchingstrategy`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_matchingstrategyattribute"></a> owner_msdynmkt_matchingstrategyattribute

Many-To-One Relationship: [msdynmkt_matchingstrategyattribute owner_msdynmkt_matchingstrategyattribute](msdynmkt_matchingstrategyattribute.md#BKMK_owner_msdynmkt_matchingstrategyattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_matchingstrategyattribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_matchingstrategyattribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_metadataentityrelationship"></a> owner_msdynmkt_metadataentityrelationship

Many-To-One Relationship: [msdynmkt_metadataentityrelationship owner_msdynmkt_metadataentityrelationship](msdynmkt_metadataentityrelationship.md#BKMK_owner_msdynmkt_metadataentityrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadataentityrelationship`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_metadataentityrelationship`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_metadataitem"></a> owner_msdynmkt_metadataitem

Many-To-One Relationship: [msdynmkt_metadataitem owner_msdynmkt_metadataitem](msdynmkt_metadataitem.md#BKMK_owner_msdynmkt_metadataitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadataitem`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_metadataitem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_metadatastorestate"></a> owner_msdynmkt_metadatastorestate

Many-To-One Relationship: [msdynmkt_metadatastorestate owner_msdynmkt_metadatastorestate](msdynmkt_metadatastorestate.md#BKMK_owner_msdynmkt_metadatastorestate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadatastorestate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_metadatastorestate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_mobileapp"></a> owner_msdynmkt_mobileapp

Many-To-One Relationship: [msdynmkt_mobileapp owner_msdynmkt_mobileapp](msdynmkt_mobileapp.md#BKMK_owner_msdynmkt_mobileapp)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mobileapp`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_mobileapp`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_mobileappchannelinstance"></a> owner_msdynmkt_mobileappchannelinstance

Many-To-One Relationship: [msdynmkt_mobileappchannelinstance owner_msdynmkt_mobileappchannelinstance](msdynmkt_mobileappchannelinstance.md#BKMK_owner_msdynmkt_mobileappchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mobileappchannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_mobileappchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_mobiledevice"></a> owner_msdynmkt_mobiledevice

Many-To-One Relationship: [msdynmkt_mobiledevice owner_msdynmkt_mobiledevice](msdynmkt_mobiledevice.md#BKMK_owner_msdynmkt_mobiledevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mobiledevice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_mobiledevice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_mocksmsproviderchannelinstance"></a> owner_msdynmkt_mocksmsproviderchannelinstance

Many-To-One Relationship: [msdynmkt_mocksmsproviderchannelinstance owner_msdynmkt_mocksmsproviderchannelinstance](msdynmkt_mocksmsproviderchannelinstance.md#BKMK_owner_msdynmkt_mocksmsproviderchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mocksmsproviderchannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_mocksmsproviderchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> owner_msdynmkt_mocksmsproviderchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_mocksmsproviderchannelinstanceaccount owner_msdynmkt_mocksmsproviderchannelinstanceaccount](msdynmkt_mocksmsproviderchannelinstanceaccount.md#BKMK_owner_msdynmkt_mocksmsproviderchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mocksmsproviderchannelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_mocksmsproviderchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_predefinedplaceholder"></a> owner_msdynmkt_predefinedplaceholder

Many-To-One Relationship: [msdynmkt_predefinedplaceholder owner_msdynmkt_predefinedplaceholder](msdynmkt_predefinedplaceholder.md#BKMK_owner_msdynmkt_predefinedplaceholder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_predefinedplaceholder`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_predefinedplaceholder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_preferencecenter"></a> owner_msdynmkt_preferencecenter

Many-To-One Relationship: [msdynmkt_preferencecenter owner_msdynmkt_preferencecenter](msdynmkt_preferencecenter.md#BKMK_owner_msdynmkt_preferencecenter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_preferencecenter`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_preferencecenter`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_purpose"></a> owner_msdynmkt_purpose

Many-To-One Relationship: [msdynmkt_purpose owner_msdynmkt_purpose](msdynmkt_purpose.md#BKMK_owner_msdynmkt_purpose)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_purpose`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_purpose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_pushdeviceregistrationresult"></a> owner_msdynmkt_pushdeviceregistrationresult

Many-To-One Relationship: [msdynmkt_pushdeviceregistrationresult owner_msdynmkt_pushdeviceregistrationresult](msdynmkt_pushdeviceregistrationresult.md#BKMK_owner_msdynmkt_pushdeviceregistrationresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_pushdeviceregistrationresult`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_pushdeviceregistrationresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_pushmobiledevice"></a> owner_msdynmkt_pushmobiledevice

Many-To-One Relationship: [msdynmkt_pushmobiledevice owner_msdynmkt_pushmobiledevice](msdynmkt_pushmobiledevice.md#BKMK_owner_msdynmkt_pushmobiledevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_pushmobiledevice`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_pushmobiledevice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_pushnotification"></a> owner_msdynmkt_pushnotification

Many-To-One Relationship: [msdynmkt_pushnotification owner_msdynmkt_pushnotification](msdynmkt_pushnotification.md#BKMK_owner_msdynmkt_pushnotification)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_pushnotification`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_pushnotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_qrcodestyle"></a> owner_msdynmkt_qrcodestyle

Many-To-One Relationship: [msdynmkt_qrcodestyle owner_msdynmkt_qrcodestyle](msdynmkt_qrcodestyle.md#BKMK_owner_msdynmkt_qrcodestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_qrcodestyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_qrcodestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_quiettimesetting"></a> owner_msdynmkt_quiettimesetting

Many-To-One Relationship: [msdynmkt_quiettimesetting owner_msdynmkt_quiettimesetting](msdynmkt_quiettimesetting.md#BKMK_owner_msdynmkt_quiettimesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_quiettimesetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_quiettimesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_recaptchaconfiguration"></a> owner_msdynmkt_recaptchaconfiguration

Many-To-One Relationship: [msdynmkt_recaptchaconfiguration owner_msdynmkt_recaptchaconfiguration](msdynmkt_recaptchaconfiguration.md#BKMK_owner_msdynmkt_recaptchaconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_recaptchaconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_recaptchaconfiguration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_segment"></a> owner_msdynmkt_segment

Many-To-One Relationship: [msdynmkt_segment owner_msdynmkt_segment](msdynmkt_segment.md#BKMK_owner_msdynmkt_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_segment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_segmentdefinition"></a> owner_msdynmkt_segmentdefinition

Many-To-One Relationship: [msdynmkt_segmentdefinition owner_msdynmkt_segmentdefinition](msdynmkt_segmentdefinition.md#BKMK_owner_msdynmkt_segmentdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentdefinition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_segmentdefinition`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_segmentexecution"></a> owner_msdynmkt_segmentexecution

Many-To-One Relationship: [msdynmkt_segmentexecution owner_msdynmkt_segmentexecution](msdynmkt_segmentexecution.md#BKMK_owner_msdynmkt_segmentexecution)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentexecution`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_segmentexecution`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_segmentusage"></a> owner_msdynmkt_segmentusage

Many-To-One Relationship: [msdynmkt_segmentusage owner_msdynmkt_segmentusage](msdynmkt_segmentusage.md#BKMK_owner_msdynmkt_segmentusage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_segmentusage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_segmentusage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_sms"></a> owner_msdynmkt_sms

Many-To-One Relationship: [msdynmkt_sms owner_msdynmkt_sms](msdynmkt_sms.md#BKMK_owner_msdynmkt_sms)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_sms`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_sms`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_submitbutton"></a> owner_msdynmkt_submitbutton

Many-To-One Relationship: [msdynmkt_submitbutton owner_msdynmkt_submitbutton](msdynmkt_submitbutton.md#BKMK_owner_msdynmkt_submitbutton)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_submitbutton`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_submitbutton`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_tag"></a> owner_msdynmkt_tag

Many-To-One Relationship: [msdynmkt_tag owner_msdynmkt_tag](msdynmkt_tag.md#BKMK_owner_msdynmkt_tag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_tag`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_tag`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_teamsengagement"></a> owner_msdynmkt_teamsengagement

Many-To-One Relationship: [msdynmkt_teamsengagement owner_msdynmkt_teamsengagement](msdynmkt_teamsengagement.md#BKMK_owner_msdynmkt_teamsengagement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_teamsengagement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_teamsengagement`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_telesignchannelinstance"></a> owner_msdynmkt_telesignchannelinstance

Many-To-One Relationship: [msdynmkt_telesignchannelinstance owner_msdynmkt_telesignchannelinstance](msdynmkt_telesignchannelinstance.md#BKMK_owner_msdynmkt_telesignchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_telesignchannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_telesignchannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_telesignchannelinstanceaccount"></a> owner_msdynmkt_telesignchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_telesignchannelinstanceaccount owner_msdynmkt_telesignchannelinstanceaccount](msdynmkt_telesignchannelinstanceaccount.md#BKMK_owner_msdynmkt_telesignchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_telesignchannelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_telesignchannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_topic"></a> owner_msdynmkt_topic

Many-To-One Relationship: [msdynmkt_topic owner_msdynmkt_topic](msdynmkt_topic.md#BKMK_owner_msdynmkt_topic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_topic`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_topic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_twiliochannelinstance"></a> owner_msdynmkt_twiliochannelinstance

Many-To-One Relationship: [msdynmkt_twiliochannelinstance owner_msdynmkt_twiliochannelinstance](msdynmkt_twiliochannelinstance.md#BKMK_owner_msdynmkt_twiliochannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_twiliochannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_twiliochannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_twiliochannelinstanceaccount"></a> owner_msdynmkt_twiliochannelinstanceaccount

Many-To-One Relationship: [msdynmkt_twiliochannelinstanceaccount owner_msdynmkt_twiliochannelinstanceaccount](msdynmkt_twiliochannelinstanceaccount.md#BKMK_owner_msdynmkt_twiliochannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_twiliochannelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_twiliochannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_utmtracking"></a> owner_msdynmkt_utmtracking

Many-To-One Relationship: [msdynmkt_utmtracking owner_msdynmkt_utmtracking](msdynmkt_utmtracking.md#BKMK_owner_msdynmkt_utmtracking)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_utmtracking`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_utmtracking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_vibeschannelinstance"></a> owner_msdynmkt_vibeschannelinstance

Many-To-One Relationship: [msdynmkt_vibeschannelinstance owner_msdynmkt_vibeschannelinstance](msdynmkt_vibeschannelinstance.md#BKMK_owner_msdynmkt_vibeschannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_vibeschannelinstance`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_vibeschannelinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_vibeschannelinstanceaccount"></a> owner_msdynmkt_vibeschannelinstanceaccount

Many-To-One Relationship: [msdynmkt_vibeschannelinstanceaccount owner_msdynmkt_vibeschannelinstanceaccount](msdynmkt_vibeschannelinstanceaccount.md#BKMK_owner_msdynmkt_vibeschannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_vibeschannelinstanceaccount`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_vibeschannelinstanceaccount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdynmkt_webinaremailjourney"></a> owner_msdynmkt_webinaremailjourney

Many-To-One Relationship: [msdynmkt_webinaremailjourney owner_msdynmkt_webinaremailjourney](msdynmkt_webinaremailjourney.md#BKMK_owner_msdynmkt_webinaremailjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_webinaremailjourney`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_webinaremailjourney`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_attendeepass"></a> owner_msevtmgt_attendeepass

Many-To-One Relationship: [msevtmgt_attendeepass owner_msevtmgt_attendeepass](msevtmgt_attendeepass.md#BKMK_owner_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_attendeepass`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_attendeepass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_authenticationsettings"></a> owner_msevtmgt_authenticationsettings

Many-To-One Relationship: [msevtmgt_authenticationsettings owner_msevtmgt_authenticationsettings](msevtmgt_authenticationsettings.md#BKMK_owner_msevtmgt_authenticationsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_authenticationsettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_authenticationsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_bucket"></a> owner_msevtmgt_bucket

Many-To-One Relationship: [msevtmgt_bucket owner_msevtmgt_bucket](msevtmgt_bucket.md#BKMK_owner_msevtmgt_bucket)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_bucket`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_bucket`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_building"></a> owner_msevtmgt_building

Many-To-One Relationship: [msevtmgt_building owner_msevtmgt_building](msevtmgt_building.md#BKMK_owner_msevtmgt_building)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_building`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_building`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_checkin"></a> owner_msevtmgt_checkin

Many-To-One Relationship: [msevtmgt_checkin owner_msevtmgt_checkin](msevtmgt_checkin.md#BKMK_owner_msevtmgt_checkin)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_checkin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_customregistrationfield"></a> owner_msevtmgt_customregistrationfield

Many-To-One Relationship: [msevtmgt_customregistrationfield owner_msevtmgt_customregistrationfield](msevtmgt_customregistrationfield.md#BKMK_owner_msevtmgt_customregistrationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_customregistrationfield`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_customregistrationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_entitycounter"></a> owner_msevtmgt_entitycounter

Many-To-One Relationship: [msevtmgt_entitycounter owner_msevtmgt_entitycounter](msevtmgt_entitycounter.md#BKMK_owner_msevtmgt_entitycounter)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_entitycounter`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_entitycounter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_event"></a> owner_msevtmgt_event

Many-To-One Relationship: [msevtmgt_event owner_msevtmgt_event](msevtmgt_event.md#BKMK_owner_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventadministration"></a> owner_msevtmgt_eventadministration

Many-To-One Relationship: [msevtmgt_eventadministration owner_msevtmgt_eventadministration](msevtmgt_eventadministration.md#BKMK_owner_msevtmgt_eventadministration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventadministration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventadministration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventanalytics"></a> owner_msevtmgt_eventanalytics

Many-To-One Relationship: [msevtmgt_eventanalytics owner_msevtmgt_eventanalytics](msevtmgt_eventanalytics.md#BKMK_owner_msevtmgt_eventanalytics)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventanalytics`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventanalytics`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventcustomregistrationfield"></a> owner_msevtmgt_eventcustomregistrationfield

Many-To-One Relationship: [msevtmgt_eventcustomregistrationfield owner_msevtmgt_eventcustomregistrationfield](msevtmgt_eventcustomregistrationfield.md#BKMK_owner_msevtmgt_eventcustomregistrationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventcustomregistrationfield`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventcustomregistrationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventmanagementactivity"></a> owner_msevtmgt_eventmanagementactivity

Many-To-One Relationship: [msevtmgt_eventmanagementactivity owner_msevtmgt_eventmanagementactivity](msevtmgt_eventmanagementactivity.md#BKMK_owner_msevtmgt_eventmanagementactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventmanagementactivity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventmanagementactivity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventmanagementconfiguration"></a> owner_msevtmgt_eventmanagementconfiguration

Many-To-One Relationship: [msevtmgt_eventmanagementconfiguration owner_msevtmgt_eventmanagementconfiguration](msevtmgt_eventmanagementconfiguration.md#BKMK_owner_msevtmgt_eventmanagementconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventmanagementconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventmanagementconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventpurchase"></a> owner_msevtmgt_eventpurchase

Many-To-One Relationship: [msevtmgt_eventpurchase owner_msevtmgt_eventpurchase](msevtmgt_eventpurchase.md#BKMK_owner_msevtmgt_eventpurchase)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchase`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventpurchase`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventpurchaseattendee"></a> owner_msevtmgt_eventpurchaseattendee

Many-To-One Relationship: [msevtmgt_eventpurchaseattendee owner_msevtmgt_eventpurchaseattendee](msevtmgt_eventpurchaseattendee.md#BKMK_owner_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventpurchaseattendee`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventpurchasecontact"></a> owner_msevtmgt_eventpurchasecontact

Many-To-One Relationship: [msevtmgt_eventpurchasecontact owner_msevtmgt_eventpurchasecontact](msevtmgt_eventpurchasecontact.md#BKMK_owner_msevtmgt_eventpurchasecontact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchasecontact`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventpurchasecontact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventpurchasepass"></a> owner_msevtmgt_eventpurchasepass

Many-To-One Relationship: [msevtmgt_eventpurchasepass owner_msevtmgt_eventpurchasepass](msevtmgt_eventpurchasepass.md#BKMK_owner_msevtmgt_eventpurchasepass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchasepass`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventpurchasepass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventregistration"></a> owner_msevtmgt_eventregistration

Many-To-One Relationship: [msevtmgt_eventregistration owner_msevtmgt_eventregistration](msevtmgt_eventregistration.md#BKMK_owner_msevtmgt_eventregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventregistration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventregistrationticket"></a> owner_msevtmgt_eventregistrationticket

Many-To-One Relationship: [msevtmgt_eventregistrationticket owner_msevtmgt_eventregistrationticket](msevtmgt_eventregistrationticket.md#BKMK_owner_msevtmgt_eventregistrationticket)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventregistrationticket`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventregistrationticket`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventteammember"></a> owner_msevtmgt_eventteammember

Many-To-One Relationship: [msevtmgt_eventteammember owner_msevtmgt_eventteammember](msevtmgt_eventteammember.md#BKMK_owner_msevtmgt_eventteammember)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventteammember`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventteammember`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventteamsproperties"></a> owner_msevtmgt_eventteamsproperties

Many-To-One Relationship: [msevtmgt_eventteamsproperties owner_msevtmgt_eventteamsproperties](msevtmgt_eventteamsproperties.md#BKMK_owner_msevtmgt_eventteamsproperties)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventteamsproperties`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventteamsproperties`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_eventvendor"></a> owner_msevtmgt_eventvendor

Many-To-One Relationship: [msevtmgt_eventvendor owner_msevtmgt_eventvendor](msevtmgt_eventvendor.md#BKMK_owner_msevtmgt_eventvendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventvendor`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_eventvendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_file"></a> owner_msevtmgt_file

Many-To-One Relationship: [msevtmgt_file owner_msevtmgt_file](msevtmgt_file.md#BKMK_owner_msevtmgt_file)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_file`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_file`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_hotel"></a> owner_msevtmgt_hotel

Many-To-One Relationship: [msevtmgt_hotel owner_msevtmgt_hotel](msevtmgt_hotel.md#BKMK_owner_msevtmgt_hotel)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_hotel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_hotelroomallocation"></a> owner_msevtmgt_hotelroomallocation

Many-To-One Relationship: [msevtmgt_hotelroomallocation owner_msevtmgt_hotelroomallocation](msevtmgt_hotelroomallocation.md#BKMK_owner_msevtmgt_hotelroomallocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomallocation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_hotelroomallocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_hotelroomreservation"></a> owner_msevtmgt_hotelroomreservation

Many-To-One Relationship: [msevtmgt_hotelroomreservation owner_msevtmgt_hotelroomreservation](msevtmgt_hotelroomreservation.md#BKMK_owner_msevtmgt_hotelroomreservation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomreservation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_hotelroomreservation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_layout"></a> owner_msevtmgt_layout

Many-To-One Relationship: [msevtmgt_layout owner_msevtmgt_layout](msevtmgt_layout.md#BKMK_owner_msevtmgt_layout)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_layout`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_layout`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_pass"></a> owner_msevtmgt_pass

Many-To-One Relationship: [msevtmgt_pass owner_msevtmgt_pass](msevtmgt_pass.md#BKMK_owner_msevtmgt_pass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_pass`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_pass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_registrationresponse"></a> owner_msevtmgt_registrationresponse

Many-To-One Relationship: [msevtmgt_registrationresponse owner_msevtmgt_registrationresponse](msevtmgt_registrationresponse.md#BKMK_owner_msevtmgt_registrationresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_registrationresponse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_registrationresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_room"></a> owner_msevtmgt_room

Many-To-One Relationship: [msevtmgt_room owner_msevtmgt_room](msevtmgt_room.md#BKMK_owner_msevtmgt_room)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_room`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_room`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_roomreservation"></a> owner_msevtmgt_roomreservation

Many-To-One Relationship: [msevtmgt_roomreservation owner_msevtmgt_roomreservation](msevtmgt_roomreservation.md#BKMK_owner_msevtmgt_roomreservation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_roomreservation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_roomreservation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_session"></a> owner_msevtmgt_session

Many-To-One Relationship: [msevtmgt_session owner_msevtmgt_session](msevtmgt_session.md#BKMK_owner_msevtmgt_session)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_session`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_sessionregistration"></a> owner_msevtmgt_sessionregistration

Many-To-One Relationship: [msevtmgt_sessionregistration owner_msevtmgt_sessionregistration](msevtmgt_sessionregistration.md#BKMK_owner_msevtmgt_sessionregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessionregistration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_sessionregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_sessiontrack"></a> owner_msevtmgt_sessiontrack

Many-To-One Relationship: [msevtmgt_sessiontrack owner_msevtmgt_sessiontrack](msevtmgt_sessiontrack.md#BKMK_owner_msevtmgt_sessiontrack)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessiontrack`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_sessiontrack`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_speaker"></a> owner_msevtmgt_speaker

Many-To-One Relationship: [msevtmgt_speaker owner_msevtmgt_speaker](msevtmgt_speaker.md#BKMK_owner_msevtmgt_speaker)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speaker`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_speaker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_speakerengagement"></a> owner_msevtmgt_speakerengagement

Many-To-One Relationship: [msevtmgt_speakerengagement owner_msevtmgt_speakerengagement](msevtmgt_speakerengagement.md#BKMK_owner_msevtmgt_speakerengagement)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speakerengagement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_speakerengagement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_sponsorablearticle"></a> owner_msevtmgt_sponsorablearticle

Many-To-One Relationship: [msevtmgt_sponsorablearticle owner_msevtmgt_sponsorablearticle](msevtmgt_sponsorablearticle.md#BKMK_owner_msevtmgt_sponsorablearticle)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorablearticle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_sponsorablearticle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_sponsorship"></a> owner_msevtmgt_sponsorship

Many-To-One Relationship: [msevtmgt_sponsorship owner_msevtmgt_sponsorship](msevtmgt_sponsorship.md#BKMK_owner_msevtmgt_sponsorship)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorship`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_sponsorship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_venue"></a> owner_msevtmgt_venue

Many-To-One Relationship: [msevtmgt_venue owner_msevtmgt_venue](msevtmgt_venue.md#BKMK_owner_msevtmgt_venue)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_venue`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_venue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_waitlistitem"></a> owner_msevtmgt_waitlistitem

Many-To-One Relationship: [msevtmgt_waitlistitem owner_msevtmgt_waitlistitem](msevtmgt_waitlistitem.md#BKMK_owner_msevtmgt_waitlistitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_waitlistitem`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_waitlistitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msevtmgt_websiteentityconfiguration"></a> owner_msevtmgt_websiteentityconfiguration

Many-To-One Relationship: [msevtmgt_websiteentityconfiguration owner_msevtmgt_websiteentityconfiguration](msevtmgt_websiteentityconfiguration.md#BKMK_owner_msevtmgt_websiteentityconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_websiteentityconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msevtmgt_websiteentityconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_alertrule"></a> owner_msfp_alertrule

Many-To-One Relationship: [msfp_alertrule owner_msfp_alertrule](msfp_alertrule.md#BKMK_owner_msfp_alertrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alertrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_alertrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_emailtemplate"></a> owner_msfp_emailtemplate

Many-To-One Relationship: [msfp_emailtemplate owner_msfp_emailtemplate](msfp_emailtemplate.md#BKMK_owner_msfp_emailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_emailtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_emailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_fileresponse"></a> owner_msfp_fileresponse

Many-To-One Relationship: [msfp_fileresponse owner_msfp_fileresponse](msfp_fileresponse.md#BKMK_owner_msfp_fileresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_fileresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_localizedemailtemplate"></a> owner_msfp_localizedemailtemplate

Many-To-One Relationship: [msfp_localizedemailtemplate owner_msfp_localizedemailtemplate](msfp_localizedemailtemplate.md#BKMK_owner_msfp_localizedemailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_localizedemailtemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_localizedemailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_project"></a> owner_msfp_project

Many-To-One Relationship: [msfp_project owner_msfp_project](msfp_project.md#BKMK_owner_msfp_project)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_project`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_project`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_question"></a> owner_msfp_question

Many-To-One Relationship: [msfp_question owner_msfp_question](msfp_question.md#BKMK_owner_msfp_question)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_question`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_question`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_questionresponse"></a> owner_msfp_questionresponse

Many-To-One Relationship: [msfp_questionresponse owner_msfp_questionresponse](msfp_questionresponse.md#BKMK_owner_msfp_questionresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_questionresponse`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_questionresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_satisfactionmetric"></a> owner_msfp_satisfactionmetric

Many-To-One Relationship: [msfp_satisfactionmetric owner_msfp_satisfactionmetric](msfp_satisfactionmetric.md#BKMK_owner_msfp_satisfactionmetric)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_satisfactionmetric`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_satisfactionmetric`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_survey"></a> owner_msfp_survey

Many-To-One Relationship: [msfp_survey owner_msfp_survey](msfp_survey.md#BKMK_owner_msfp_survey)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_survey`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_survey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_surveyreminder"></a> owner_msfp_surveyreminder

Many-To-One Relationship: [msfp_surveyreminder owner_msfp_surveyreminder](msfp_surveyreminder.md#BKMK_owner_msfp_surveyreminder)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyreminder`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_surveyreminder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msfp_unsubscribedrecipient"></a> owner_msfp_unsubscribedrecipient

Many-To-One Relationship: [msfp_unsubscribedrecipient owner_msfp_unsubscribedrecipient](msfp_unsubscribedrecipient.md#BKMK_owner_msfp_unsubscribedrecipient)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_unsubscribedrecipient`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msfp_unsubscribedrecipient`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_3dasset"></a> owner_msmrw_3dasset

Many-To-One Relationship: [msmrw_3dasset owner_msmrw_3dasset](msmrw_3dasset.md#BKMK_owner_msmrw_3dasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_3dasset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_3dasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_3dasset_localized"></a> owner_msmrw_3dasset_localized

Many-To-One Relationship: [msmrw_3dasset_localized owner_msmrw_3dasset_localized](msmrw_3dasset_localized.md#BKMK_owner_msmrw_3dasset_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_3dasset_localized`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_3dasset_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_assetcollection"></a> owner_msmrw_assetcollection

Many-To-One Relationship: [msmrw_assetcollection owner_msmrw_assetcollection](msmrw_assetcollection.md#BKMK_owner_msmrw_assetcollection)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_assetcollection`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_assetcollection`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_assetcollection_localized"></a> owner_msmrw_assetcollection_localized

Many-To-One Relationship: [msmrw_assetcollection_localized owner_msmrw_assetcollection_localized](msmrw_assetcollection_localized.md#BKMK_owner_msmrw_assetcollection_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_assetcollection_localized`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_assetcollection_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_audioasset"></a> owner_msmrw_audioasset

Many-To-One Relationship: [msmrw_audioasset owner_msmrw_audioasset](msmrw_audioasset.md#BKMK_owner_msmrw_audioasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_audioasset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_audioasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guide"></a> owner_msmrw_guide

Many-To-One Relationship: [msmrw_guide owner_msmrw_guide](msmrw_guide.md#BKMK_owner_msmrw_guide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guide`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guide`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guidecompletionstepobject"></a> owner_msmrw_guidecompletionstepobject

Many-To-One Relationship: [msmrw_guidecompletionstepobject owner_msmrw_guidecompletionstepobject](msmrw_guidecompletionstepobject.md#BKMK_owner_msmrw_guidecompletionstepobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobject`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guidecompletionstepobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guidecompletionstepobjectplacement"></a> owner_msmrw_guidecompletionstepobjectplacement

Many-To-One Relationship: [msmrw_guidecompletionstepobjectplacement owner_msmrw_guidecompletionstepobjectplacement](msmrw_guidecompletionstepobjectplacement.md#BKMK_owner_msmrw_guidecompletionstepobjectplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidecompletionstepobjectplacement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guidecompletionstepobjectplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guideevent"></a> owner_msmrw_guideevent

Many-To-One Relationship: [msmrw_guideevent owner_msmrw_guideevent](msmrw_guideevent.md#BKMK_owner_msmrw_guideevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guideevent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guideevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guidesession"></a> owner_msmrw_guidesession

Many-To-One Relationship: [msmrw_guidesession owner_msmrw_guidesession](msmrw_guidesession.md#BKMK_owner_msmrw_guidesession)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidesession`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guidesession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guidesessionstepvisit"></a> owner_msmrw_guidesessionstepvisit

Many-To-One Relationship: [msmrw_guidesessionstepvisit owner_msmrw_guidesessionstepvisit](msmrw_guidesessionstepvisit.md#BKMK_owner_msmrw_guidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidesessionstepvisit`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guidesessionstepvisit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guidestep"></a> owner_msmrw_guidestep

Many-To-One Relationship: [msmrw_guidestep owner_msmrw_guidestep](msmrw_guidestep.md#BKMK_owner_msmrw_guidestep)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestep`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guidestep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guidestepobject"></a> owner_msmrw_guidestepobject

Many-To-One Relationship: [msmrw_guidestepobject owner_msmrw_guidestepobject](msmrw_guidestepobject.md#BKMK_owner_msmrw_guidestepobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobject`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guidestepobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guidestepobjectplacement"></a> owner_msmrw_guidestepobjectplacement

Many-To-One Relationship: [msmrw_guidestepobjectplacement owner_msmrw_guidestepobjectplacement](msmrw_guidestepobjectplacement.md#BKMK_owner_msmrw_guidestepobjectplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidestepobjectplacement`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guidestepobjectplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guidetask"></a> owner_msmrw_guidetask

Many-To-One Relationship: [msmrw_guidetask owner_msmrw_guidetask](msmrw_guidetask.md#BKMK_owner_msmrw_guidetask)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guidetask`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guidetask`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_guideviewconfiguration"></a> owner_msmrw_guideviewconfiguration

Many-To-One Relationship: [msmrw_guideviewconfiguration owner_msmrw_guideviewconfiguration](msmrw_guideviewconfiguration.md#BKMK_owner_msmrw_guideviewconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_guideviewconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_guideviewconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_imageasset"></a> owner_msmrw_imageasset

Many-To-One Relationship: [msmrw_imageasset owner_msmrw_imageasset](msmrw_imageasset.md#BKMK_owner_msmrw_imageasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_imageasset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_imageasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_imageasset_localized"></a> owner_msmrw_imageasset_localized

Many-To-One Relationship: [msmrw_imageasset_localized owner_msmrw_imageasset_localized](msmrw_imageasset_localized.md#BKMK_owner_msmrw_imageasset_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_imageasset_localized`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_imageasset_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_packagedguide"></a> owner_msmrw_packagedguide

Many-To-One Relationship: [msmrw_packagedguide owner_msmrw_packagedguide](msmrw_packagedguide.md#BKMK_owner_msmrw_packagedguide)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_packagedguide`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_packagedguide`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_packagedguidesessionstepvisit"></a> owner_msmrw_packagedguidesessionstepvisit

Many-To-One Relationship: [msmrw_packagedguidesessionstepvisit owner_msmrw_packagedguidesessionstepvisit](msmrw_packagedguidesessionstepvisit.md#BKMK_owner_msmrw_packagedguidesessionstepvisit)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_packagedguidesessionstepvisit`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_packagedguidesessionstepvisit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_packagedguidesoperatorsession"></a> owner_msmrw_packagedguidesoperatorsession

Many-To-One Relationship: [msmrw_packagedguidesoperatorsession owner_msmrw_packagedguidesoperatorsession](msmrw_packagedguidesoperatorsession.md#BKMK_owner_msmrw_packagedguidesoperatorsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_packagedguidesoperatorsession`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_packagedguidesoperatorsession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_usersettings"></a> owner_msmrw_usersettings

Many-To-One Relationship: [msmrw_usersettings owner_msmrw_usersettings](msmrw_usersettings.md#BKMK_owner_msmrw_usersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_usersettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_usersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_videoasset"></a> owner_msmrw_videoasset

Many-To-One Relationship: [msmrw_videoasset owner_msmrw_videoasset](msmrw_videoasset.md#BKMK_owner_msmrw_videoasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_videoasset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_videoasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msmrw_videoasset_localized"></a> owner_msmrw_videoasset_localized

Many-To-One Relationship: [msmrw_videoasset_localized owner_msmrw_videoasset_localized](msmrw_videoasset_localized.md#BKMK_owner_msmrw_videoasset_localized)

|Property|Value|
|---|---|
|ReferencingEntity|`msmrw_videoasset_localized`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msmrw_videoasset_localized`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_opportunitys"></a> owner_opportunitys

Many-To-One Relationship: [opportunity owner_opportunitys](opportunity.md#BKMK_owner_opportunitys)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_opportunitys`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_quotes"></a> owner_quotes

Many-To-One Relationship: [quote owner_quotes](quote.md#BKMK_owner_quotes)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_quotes`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_ratingmodel"></a> owner_ratingmodel

Many-To-One Relationship: [ratingmodel owner_ratingmodel](ratingmodel.md#BKMK_owner_ratingmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`ratingmodel`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_ratingmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_ratingvalue"></a> owner_ratingvalue

Many-To-One Relationship: [ratingvalue owner_ratingvalue](ratingvalue.md#BKMK_owner_ratingvalue)

|Property|Value|
|---|---|
|ReferencingEntity|`ratingvalue`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_ratingvalue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_sales_linkedin_profileassociations"></a> owner_sales_linkedin_profileassociations

Many-To-One Relationship: [sales_linkedin_profileassociations owner_sales_linkedin_profileassociations](sales_linkedin_profileassociations.md#BKMK_owner_sales_linkedin_profileassociations)

|Property|Value|
|---|---|
|ReferencingEntity|`sales_linkedin_profileassociations`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_sales_linkedin_profileassociations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_sales_linkedin_users_signedin_status"></a> owner_sales_linkedin_users_signedin_status

Many-To-One Relationship: [sales_linkedin_users_signedin_status owner_sales_linkedin_users_signedin_status](sales_linkedin_users_signedin_status.md#BKMK_owner_sales_linkedin_users_signedin_status)

|Property|Value|
|---|---|
|ReferencingEntity|`sales_linkedin_users_signedin_status`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_sales_linkedin_users_signedin_status`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_salesorders"></a> owner_salesorders

Many-To-One Relationship: [salesorder owner_salesorders](salesorder.md#BKMK_owner_salesorders)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_salesorders`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quoteclose_owner_ownerid"></a> quoteclose_owner_ownerid

Many-To-One Relationship: [quoteclose quoteclose_owner_ownerid](quoteclose.md#BKMK_quoteclose_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`quoteclose_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_serviceappointment_owner_ownerid"></a> serviceappointment_owner_ownerid

Many-To-One Relationship: [serviceappointment serviceappointment_owner_ownerid](serviceappointment.md#BKMK_serviceappointment_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`serviceappointment_owner_ownerid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

