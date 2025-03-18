---
title: "Owner table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Owner table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Owner table/entity reference (Microsoft Dynamics 365)

Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.

> [!NOTE]
> The Microsoft Dynamics 365 Owner table extends the [Microsoft Dataverse Owner table](/power-apps/developer/data-platform/reference/entities/owner).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [bulkoperation_owner_ownerid](#BKMK_bulkoperation_owner_ownerid)
- [campaignactivity_owner_ownerid](#BKMK_campaignactivity_owner_ownerid)
- [campaignresponse_owner_ownerid](#BKMK_campaignresponse_owner_ownerid)
- [incidentresolution_owner_ownerid](#BKMK_incidentresolution_owner_ownerid)
- [msdyn_copilottranscript_owner_ownerid](#BKMK_msdyn_copilottranscript_owner_ownerid)
- [msdyn_ocliveworkitem_owner_ownerid](#BKMK_msdyn_ocliveworkitem_owner_ownerid)
- [msdyn_ocsession_owner_ownerid](#BKMK_msdyn_ocsession_owner_ownerid)
- [msfp_alert_owner_ownerid](#BKMK_msfp_alert_owner_ownerid)
- [msfp_surveyinvite_owner_ownerid](#BKMK_msfp_surveyinvite_owner_ownerid)
- [msfp_surveyresponse_owner_ownerid](#BKMK_msfp_surveyresponse_owner_ownerid)
- [opportunityclose_owner_ownerid](#BKMK_opportunityclose_owner_ownerid)
- [orderclose_owner_ownerid](#BKMK_orderclose_owner_ownerid)
- [owner_activitymonitor](#BKMK_owner_activitymonitor)
- [owner_adminsettingsentity](#BKMK_owner_adminsettingsentity)
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
- [owner_incidents](#BKMK_owner_incidents)
- [owner_invoices](#BKMK_owner_invoices)
- [owner_leads](#BKMK_owner_leads)
- [owner_listoperation](#BKMK_owner_listoperation)
- [owner_lists](#BKMK_owner_lists)
- [owner_msdyn_actioncardactionstat](#BKMK_owner_msdyn_actioncardactionstat)
- [owner_msdyn_actioncardregarding](#BKMK_owner_msdyn_actioncardregarding)
- [owner_msdyn_actioncardrolesetting](#BKMK_owner_msdyn_actioncardrolesetting)
- [owner_msdyn_actioncardstataggregation](#BKMK_owner_msdyn_actioncardstataggregation)
- [owner_msdyn_activeicdextension](#BKMK_owner_msdyn_activeicdextension)
- [owner_msdyn_adminappstate](#BKMK_owner_msdyn_adminappstate)
- [owner_msdyn_agentcapacityprofileunit](#BKMK_owner_msdyn_agentcapacityprofileunit)
- [owner_msdyn_agentcapacityupdatehistory](#BKMK_owner_msdyn_agentcapacityupdatehistory)
- [owner_msdyn_agentchannelstate](#BKMK_owner_msdyn_agentchannelstate)
- [owner_msdyn_agentgroup](#BKMK_owner_msdyn_agentgroup)
- [owner_msdyn_agentgrouplanguage](#BKMK_owner_msdyn_agentgrouplanguage)
- [owner_msdyn_agentgroupmembership](#BKMK_owner_msdyn_agentgroupmembership)
- [owner_msdyn_agentgroupregion](#BKMK_owner_msdyn_agentgroupregion)
- [owner_msdyn_agentlanguage](#BKMK_owner_msdyn_agentlanguage)
- [owner_msdyn_agentregion](#BKMK_owner_msdyn_agentregion)
- [owner_msdyn_agentstatus](#BKMK_owner_msdyn_agentstatus)
- [owner_msdyn_agentstatushistory](#BKMK_owner_msdyn_agentstatushistory)
- [owner_msdyn_aicontactsuggestion](#BKMK_owner_msdyn_aicontactsuggestion)
- [owner_msdyn_analytics](#BKMK_owner_msdyn_analytics)
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
- [owner_msdyn_bookableresourcecapacityprofile](#BKMK_owner_msdyn_bookableresourcecapacityprofile)
- [owner_msdyn_botsession](#BKMK_owner_msdyn_botsession)
- [owner_msdyn_capacityprofile](#BKMK_owner_msdyn_capacityprofile)
- [owner_msdyn_cdsentityengagementctx](#BKMK_owner_msdyn_cdsentityengagementctx)
- [owner_msdyn_channeldefinition](#BKMK_owner_msdyn_channeldefinition)
- [owner_msdyn_channeldefinitionconsent](#BKMK_owner_msdyn_channeldefinitionconsent)
- [owner_msdyn_channeldefinitionlocale](#BKMK_owner_msdyn_channeldefinitionlocale)
- [owner_msdyn_channelinstance](#BKMK_owner_msdyn_channelinstance)
- [owner_msdyn_channelinstanceaccount](#BKMK_owner_msdyn_channelinstanceaccount)
- [owner_msdyn_channelmessageattachment](#BKMK_owner_msdyn_channelmessageattachment)
- [owner_msdyn_channelmessagecontextpart](#BKMK_owner_msdyn_channelmessagecontextpart)
- [owner_msdyn_channelmessagepart](#BKMK_owner_msdyn_channelmessagepart)
- [owner_msdyn_channelprovider](#BKMK_owner_msdyn_channelprovider)
- [owner_msdyn_consumingapplication](#BKMK_owner_msdyn_consumingapplication)
- [owner_msdyn_contactsuggestionrule](#BKMK_owner_msdyn_contactsuggestionrule)
- [owner_msdyn_contactsuggestionruleset](#BKMK_owner_msdyn_contactsuggestionruleset)
- [owner_msdyn_conversationaction](#BKMK_owner_msdyn_conversationaction)
- [owner_msdyn_conversationactionitem](#BKMK_owner_msdyn_conversationactionitem)
- [owner_msdyn_conversationactionlocale](#BKMK_owner_msdyn_conversationactionlocale)
- [owner_msdyn_conversationaggregatedinsights](#BKMK_owner_msdyn_conversationaggregatedinsights)
- [owner_msdyn_conversationcomment](#BKMK_owner_msdyn_conversationcomment)
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
- [owner_msdyn_copilotcaseformfillsetting](#BKMK_owner_msdyn_copilotcaseformfillsetting)
- [owner_msdyn_copilotinteractiondata](#BKMK_owner_msdyn_copilotinteractiondata)
- [owner_msdyn_copilottranscriptdata](#BKMK_owner_msdyn_copilottranscriptdata)
- [owner_msdyn_crmconnection](#BKMK_owner_msdyn_crmconnection)
- [owner_msdyn_csadminconfig](#BKMK_owner_msdyn_csadminconfig)
- [owner_msdyn_customapirulesetconfiguration](#BKMK_owner_msdyn_customapirulesetconfiguration)
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
- [owner_msdyn_deletedconversation](#BKMK_owner_msdyn_deletedconversation)
- [owner_msdyn_duplicateleadmapping](#BKMK_owner_msdyn_duplicateleadmapping)
- [owner_msdyn_effortpredictionresult](#BKMK_owner_msdyn_effortpredictionresult)
- [owner_msdyn_emailsentiment](#BKMK_owner_msdyn_emailsentiment)
- [owner_msdyn_entityattachment](#BKMK_owner_msdyn_entityattachment)
- [owner_msdyn_entityattributepredictionrule](#BKMK_owner_msdyn_entityattributepredictionrule)
- [owner_msdyn_entityrankingrule](#BKMK_owner_msdyn_entityrankingrule)
- [owner_msdyn_entityroutingconfiguration](#BKMK_owner_msdyn_entityroutingconfiguration)
- [owner_msdyn_entityworkstreammap](#BKMK_owner_msdyn_entityworkstreammap)
- [owner_msdyn_extendedusersetting](#BKMK_owner_msdyn_extendedusersetting)
- [owner_msdyn_externalcrm](#BKMK_owner_msdyn_externalcrm)
- [owner_msdyn_externalrecord](#BKMK_owner_msdyn_externalrecord)
- [owner_msdyn_flowcardtype](#BKMK_owner_msdyn_flowcardtype)
- [owner_msdyn_forecastconfiguration](#BKMK_owner_msdyn_forecastconfiguration)
- [owner_msdyn_forecastdefinition](#BKMK_owner_msdyn_forecastdefinition)
- [owner_msdyn_forecastinstance](#BKMK_owner_msdyn_forecastinstance)
- [owner_msdyn_forecastrecurrence](#BKMK_owner_msdyn_forecastrecurrence)
- [owner_msdyn_functionallocation](#BKMK_owner_msdyn_functionallocation)
- [owner_msdyn_functionallocationtype](#BKMK_owner_msdyn_functionallocationtype)
- [owner_msdyn_gdprdata](#BKMK_owner_msdyn_gdprdata)
- [owner_msdyn_icdextension](#BKMK_owner_msdyn_icdextension)
- [owner_msdyn_icebreakersconfig](#BKMK_owner_msdyn_icebreakersconfig)
- [owner_msdyn_iermlmodel](#BKMK_owner_msdyn_iermlmodel)
- [owner_msdyn_iermltraining](#BKMK_owner_msdyn_iermltraining)
- [owner_msdyn_intent](#BKMK_owner_msdyn_intent)
- [owner_msdyn_intentattribute](#BKMK_owner_msdyn_intentattribute)
- [owner_msdyn_intentattribute_entity](#BKMK_owner_msdyn_intentattribute_entity)
- [owner_msdyn_intentattributeset](#BKMK_owner_msdyn_intentattributeset)
- [owner_msdyn_intentconfig](#BKMK_owner_msdyn_intentconfig)
- [owner_msdyn_intententity](#BKMK_owner_msdyn_intententity)
- [owner_msdyn_intententity_backfillstatus](#BKMK_owner_msdyn_intententity_backfillstatus)
- [owner_msdyn_intentfamily](#BKMK_owner_msdyn_intentfamily)
- [owner_msdyn_intentfeature_configuration](#BKMK_owner_msdyn_intentfeature_configuration)
- [owner_msdyn_intentgroupcondition](#BKMK_owner_msdyn_intentgroupcondition)
- [owner_msdyn_intentsolutionmap](#BKMK_owner_msdyn_intentsolutionmap)
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
- [owner_msdyn_kpieventdata](#BKMK_owner_msdyn_kpieventdata)
- [owner_msdyn_kpieventdefinition](#BKMK_owner_msdyn_kpieventdefinition)
- [owner_msdyn_language](#BKMK_owner_msdyn_language)
- [owner_msdyn_leadmodelconfig](#BKMK_owner_msdyn_leadmodelconfig)
- [owner_msdyn_liveworkitemevent](#BKMK_owner_msdyn_liveworkitemevent)
- [owner_msdyn_liveworkstream](#BKMK_owner_msdyn_liveworkstream)
- [owner_msdyn_liveworkstreamcapacityprofile](#BKMK_owner_msdyn_liveworkstreamcapacityprofile)
- [owner_msdyn_locationtemplateassociation](#BKMK_owner_msdyn_locationtemplateassociation)
- [owner_msdyn_locationtypetemplateassociation](#BKMK_owner_msdyn_locationtypetemplateassociation)
- [owner_msdyn_lockstatus](#BKMK_owner_msdyn_lockstatus)
- [owner_msdyn_macrosession](#BKMK_owner_msdyn_macrosession)
- [owner_msdyn_masterentityroutingconfiguration](#BKMK_owner_msdyn_masterentityroutingconfiguration)
- [owner_msdyn_migrationtracker](#BKMK_owner_msdyn_migrationtracker)
- [owner_msdyn_modelpreviewstatus](#BKMK_owner_msdyn_modelpreviewstatus)
- [owner_msdyn_notesanalysisconfig](#BKMK_owner_msdyn_notesanalysisconfig)
- [owner_msdyn_notificationfield](#BKMK_owner_msdyn_notificationfield)
- [owner_msdyn_notificationtemplate](#BKMK_owner_msdyn_notificationtemplate)
- [owner_msdyn_oc_geolocationprovider](#BKMK_owner_msdyn_oc_geolocationprovider)
- [owner_msdyn_ocagentassignedcustomapiprivilege](#BKMK_owner_msdyn_ocagentassignedcustomapiprivilege)
- [owner_msdyn_ocautoblockrule](#BKMK_owner_msdyn_ocautoblockrule)
- [owner_msdyn_ocautomatedactionrule](#BKMK_owner_msdyn_ocautomatedactionrule)
- [owner_msdyn_ocautomatedactionrulesmapping](#BKMK_owner_msdyn_ocautomatedactionrulesmapping)
- [owner_msdyn_ocbotchannelregistration](#BKMK_owner_msdyn_ocbotchannelregistration)
- [owner_msdyn_ocbotchannelregistrationsecret](#BKMK_owner_msdyn_ocbotchannelregistrationsecret)
- [owner_msdyn_occhannelapiconversationprivilege](#BKMK_owner_msdyn_occhannelapiconversationprivilege)
- [owner_msdyn_occhannelapimessageprivilege](#BKMK_owner_msdyn_occhannelapimessageprivilege)
- [owner_msdyn_occhannelapimethodmapping](#BKMK_owner_msdyn_occhannelapimethodmapping)
- [owner_msdyn_ocexternalcontext](#BKMK_owner_msdyn_ocexternalcontext)
- [owner_msdyn_ocflaggedspam](#BKMK_owner_msdyn_ocflaggedspam)
- [owner_msdyn_oclanguage](#BKMK_owner_msdyn_oclanguage)
- [owner_msdyn_ocliveworkitemcapacityprofile](#BKMK_owner_msdyn_ocliveworkitemcapacityprofile)
- [owner_msdyn_ocliveworkitemcharacteristic](#BKMK_owner_msdyn_ocliveworkitemcharacteristic)
- [owner_msdyn_ocliveworkitemcontextitem](#BKMK_owner_msdyn_ocliveworkitemcontextitem)
- [owner_msdyn_ocliveworkitemsentiment](#BKMK_owner_msdyn_ocliveworkitemsentiment)
- [owner_msdyn_ocliveworkstreamcontextvariable](#BKMK_owner_msdyn_ocliveworkstreamcontextvariable)
- [owner_msdyn_ocpaymentprofile](#BKMK_owner_msdyn_ocpaymentprofile)
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
- [owner_msdyn_omnichannelpersonalization](#BKMK_owner_msdyn_omnichannelpersonalization)
- [owner_msdyn_omnichannelsyncconfig](#BKMK_owner_msdyn_omnichannelsyncconfig)
- [owner_msdyn_operatinghour](#BKMK_owner_msdyn_operatinghour)
- [owner_msdyn_opportunitymodelconfig](#BKMK_owner_msdyn_opportunitymodelconfig)
- [owner_msdyn_orgchartnode](#BKMK_owner_msdyn_orgchartnode)
- [owner_msdyn_overflowactionconfig](#BKMK_owner_msdyn_overflowactionconfig)
- [owner_msdyn_personalmessage](#BKMK_owner_msdyn_personalmessage)
- [owner_msdyn_personalsoundsetting](#BKMK_owner_msdyn_personalsoundsetting)
- [owner_msdyn_postalbum](#BKMK_owner_msdyn_postalbum)
- [owner_msdyn_predictioncomputationoperation](#BKMK_owner_msdyn_predictioncomputationoperation)
- [owner_msdyn_predictionmodelstatus](#BKMK_owner_msdyn_predictionmodelstatus)
- [owner_msdyn_predictionscheduledoperation](#BKMK_owner_msdyn_predictionscheduledoperation)
- [owner_msdyn_predictivescoringsyncstatus](#BKMK_owner_msdyn_predictivescoringsyncstatus)
- [owner_msdyn_preferredagent](#BKMK_owner_msdyn_preferredagent)
- [owner_msdyn_preferredagentcustomeridentity](#BKMK_owner_msdyn_preferredagentcustomeridentity)
- [owner_msdyn_preferredagentroutedentity](#BKMK_owner_msdyn_preferredagentroutedentity)
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
- [owner_msdyn_rawinsight](#BKMK_owner_msdyn_rawinsight)
- [owner_msdyn_readtracker](#BKMK_owner_msdyn_readtracker)
- [owner_msdyn_realtimescoring](#BKMK_owner_msdyn_realtimescoring)
- [owner_msdyn_realtimescoringoperation](#BKMK_owner_msdyn_realtimescoringoperation)
- [owner_msdyn_region](#BKMK_owner_msdyn_region)
- [owner_msdyn_reportbookmark](#BKMK_owner_msdyn_reportbookmark)
- [owner_msdyn_routingconfiguration](#BKMK_owner_msdyn_routingconfiguration)
- [owner_msdyn_routingconfigurationstep](#BKMK_owner_msdyn_routingconfigurationstep)
- [owner_msdyn_routingrequest](#BKMK_owner_msdyn_routingrequest)
- [owner_msdyn_salescopilotemailinsight](#BKMK_owner_msdyn_salescopilotemailinsight)
- [owner_msdyn_salescopilotinsight](#BKMK_owner_msdyn_salescopilotinsight)
- [owner_msdyn_salescopilotinsightcardstate](#BKMK_owner_msdyn_salescopilotinsightcardstate)
- [owner_msdyn_salesinsightssettings](#BKMK_owner_msdyn_salesinsightssettings)
- [owner_msdyn_salesocmessage](#BKMK_owner_msdyn_salesocmessage)
- [owner_msdyn_salesocsmstemplate](#BKMK_owner_msdyn_salesocsmstemplate)
- [owner_msdyn_salesroutingrun](#BKMK_owner_msdyn_salesroutingrun)
- [owner_msdyn_salessuggestion](#BKMK_owner_msdyn_salessuggestion)
- [owner_msdyn_salestag](#BKMK_owner_msdyn_salestag)
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
- [owner_msdyn_sessionevent](#BKMK_owner_msdyn_sessionevent)
- [owner_msdyn_sessionparticipant](#BKMK_owner_msdyn_sessionparticipant)
- [owner_msdyn_sessiontemplate](#BKMK_owner_msdyn_sessiontemplate)
- [owner_msdyn_siconfig](#BKMK_owner_msdyn_siconfig)
- [owner_msdyn_skillattachmentruleitem](#BKMK_owner_msdyn_skillattachmentruleitem)
- [owner_msdyn_skillattachmenttarget](#BKMK_owner_msdyn_skillattachmenttarget)
- [owner_msdyn_soundnotificationsetting](#BKMK_owner_msdyn_soundnotificationsetting)
- [owner_msdyn_submodeldefinition](#BKMK_owner_msdyn_submodeldefinition)
- [owner_msdyn_suggestionassignmentrule](#BKMK_owner_msdyn_suggestionassignmentrule)
- [owner_msdyn_suggestionprincipalobjectaccess](#BKMK_owner_msdyn_suggestionprincipalobjectaccess)
- [owner_msdyn_suggestionsellerpriority](#BKMK_owner_msdyn_suggestionsellerpriority)
- [owner_msdyn_swarm](#BKMK_owner_msdyn_swarm)
- [owner_msdyn_swarmparticipant](#BKMK_owner_msdyn_swarmparticipant)
- [owner_msdyn_swarmparticipantrule](#BKMK_owner_msdyn_swarmparticipantrule)
- [owner_msdyn_swarmrole](#BKMK_owner_msdyn_swarmrole)
- [owner_msdyn_swarmskill](#BKMK_owner_msdyn_swarmskill)
- [owner_msdyn_swarmtemplate](#BKMK_owner_msdyn_swarmtemplate)
- [owner_msdyn_taggedrecord](#BKMK_owner_msdyn_taggedrecord)
- [owner_msdyn_templateforproperties](#BKMK_owner_msdyn_templateforproperties)
- [owner_msdyn_templateparameter](#BKMK_owner_msdyn_templateparameter)
- [owner_msdyn_templateruleset](#BKMK_owner_msdyn_templateruleset)
- [owner_msdyn_timespent](#BKMK_owner_msdyn_timespent)
- [owner_msdyn_timetracker](#BKMK_owner_msdyn_timetracker)
- [owner_msdyn_trainingresult](#BKMK_owner_msdyn_trainingresult)
- [owner_msdyn_transcript](#BKMK_owner_msdyn_transcript)
- [owner_msdyn_unifiedroutingdiagnostic](#BKMK_owner_msdyn_unifiedroutingdiagnostic)
- [owner_msdyn_unifiedroutingrun](#BKMK_owner_msdyn_unifiedroutingrun)
- [owner_msdyn_untrackedappointment](#BKMK_owner_msdyn_untrackedappointment)
- [owner_msdyn_urnotificationtemplate](#BKMK_owner_msdyn_urnotificationtemplate)
- [owner_msdyn_urnotificationtemplatemapping](#BKMK_owner_msdyn_urnotificationtemplatemapping)
- [owner_msdyn_visitorjourney](#BKMK_owner_msdyn_visitorjourney)
- [owner_msdyn_vivacustomerlist](#BKMK_owner_msdyn_vivacustomerlist)
- [owner_msdyn_wallsavedqueryusersettings](#BKMK_owner_msdyn_wallsavedqueryusersettings)
- [owner_msdyn_warranty](#BKMK_owner_msdyn_warranty)
- [owner_msdyn_wkwconfig](#BKMK_owner_msdyn_wkwconfig)
- [owner_msdyn_workqueuestate](#BKMK_owner_msdyn_workqueuestate)
- [owner_msdyn_workqueueusersetting](#BKMK_owner_msdyn_workqueueusersetting)
- [owner_msdyncrm_addtocalendarstyle](#BKMK_owner_msdyncrm_addtocalendarstyle)
- [owner_msdyncrm_basestyle](#BKMK_owner_msdyncrm_basestyle)
- [owner_msdyncrm_buttonstyle](#BKMK_owner_msdyncrm_buttonstyle)
- [owner_msdyncrm_codestyle](#BKMK_owner_msdyncrm_codestyle)
- [owner_msdyncrm_columnstyle](#BKMK_owner_msdyncrm_columnstyle)
- [owner_msdyncrm_contentblockstyle](#BKMK_owner_msdyncrm_contentblockstyle)
- [owner_msdyncrm_dividerstyle](#BKMK_owner_msdyncrm_dividerstyle)
- [owner_msdyncrm_generalstyles](#BKMK_owner_msdyncrm_generalstyles)
- [owner_msdyncrm_imagestyle](#BKMK_owner_msdyncrm_imagestyle)
- [owner_msdyncrm_layoutstyle](#BKMK_owner_msdyncrm_layoutstyle)
- [owner_msdyncrm_qrcodestyle](#BKMK_owner_msdyncrm_qrcodestyle)
- [owner_msdyncrm_textstyle](#BKMK_owner_msdyncrm_textstyle)
- [owner_msdyncrm_videostyle](#BKMK_owner_msdyncrm_videostyle)
- [owner_msdynmkt_byoacschannelinstance](#BKMK_owner_msdynmkt_byoacschannelinstance)
- [owner_msdynmkt_byoacschannelinstanceaccount](#BKMK_owner_msdynmkt_byoacschannelinstanceaccount)
- [owner_msdynmkt_catalogeventstatusconfiguration](#BKMK_owner_msdynmkt_catalogeventstatusconfiguration)
- [owner_msdynmkt_configuration](#BKMK_owner_msdynmkt_configuration)
- [owner_msdynmkt_eventmetadata](#BKMK_owner_msdynmkt_eventmetadata)
- [owner_msdynmkt_eventparametermetadata](#BKMK_owner_msdynmkt_eventparametermetadata)
- [owner_msdynmkt_featureconfiguration](#BKMK_owner_msdynmkt_featureconfiguration)
- [owner_msdynmkt_infobipchannelinstance](#BKMK_owner_msdynmkt_infobipchannelinstance)
- [owner_msdynmkt_infobipchannelinstanceaccount](#BKMK_owner_msdynmkt_infobipchannelinstanceaccount)
- [owner_msdynmkt_linkmobilitychannelinstance](#BKMK_owner_msdynmkt_linkmobilitychannelinstance)
- [owner_msdynmkt_linkmobilitychannelinstanceaccount](#BKMK_owner_msdynmkt_linkmobilitychannelinstanceaccount)
- [owner_msdynmkt_metadataentityrelationship](#BKMK_owner_msdynmkt_metadataentityrelationship)
- [owner_msdynmkt_metadataitem](#BKMK_owner_msdynmkt_metadataitem)
- [owner_msdynmkt_metadatastorestate](#BKMK_owner_msdynmkt_metadatastorestate)
- [owner_msdynmkt_mocksmsproviderchannelinstance](#BKMK_owner_msdynmkt_mocksmsproviderchannelinstance)
- [owner_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_owner_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [owner_msdynmkt_predefinedplaceholder](#BKMK_owner_msdynmkt_predefinedplaceholder)
- [owner_msdynmkt_telesignchannelinstance](#BKMK_owner_msdynmkt_telesignchannelinstance)
- [owner_msdynmkt_telesignchannelinstanceaccount](#BKMK_owner_msdynmkt_telesignchannelinstanceaccount)
- [owner_msdynmkt_twiliochannelinstance](#BKMK_owner_msdynmkt_twiliochannelinstance)
- [owner_msdynmkt_twiliochannelinstanceaccount](#BKMK_owner_msdynmkt_twiliochannelinstanceaccount)
- [owner_msdynmkt_vibeschannelinstance](#BKMK_owner_msdynmkt_vibeschannelinstance)
- [owner_msdynmkt_vibeschannelinstanceaccount](#BKMK_owner_msdynmkt_vibeschannelinstanceaccount)
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
- [owner_opportunitys](#BKMK_owner_opportunitys)
- [owner_quotes](#BKMK_owner_quotes)
- [owner_ratingmodel](#BKMK_owner_ratingmodel)
- [owner_ratingvalue](#BKMK_owner_ratingvalue)
- [owner_salesorders](#BKMK_owner_salesorders)
- [quoteclose_owner_ownerid](#BKMK_quoteclose_owner_ownerid)
- [serviceappointment_owner_ownerid](#BKMK_serviceappointment_owner_ownerid)

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

### <a name="BKMK_msdyn_ocsession_owner_ownerid"></a> msdyn_ocsession_owner_ownerid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_owner_ownerid](msdyn_ocsession.md#BKMK_msdyn_ocsession_owner_ownerid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_owner_ownerid`|
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

### <a name="BKMK_owner_msdyn_agentgroup"></a> owner_msdyn_agentgroup

Many-To-One Relationship: [msdyn_agentgroup owner_msdyn_agentgroup](msdyn_agentgroup.md#BKMK_owner_msdyn_agentgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroup`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentgrouplanguage"></a> owner_msdyn_agentgrouplanguage

Many-To-One Relationship: [msdyn_agentgrouplanguage owner_msdyn_agentgrouplanguage](msdyn_agentgrouplanguage.md#BKMK_owner_msdyn_agentgrouplanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgrouplanguage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentgrouplanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentgroupmembership"></a> owner_msdyn_agentgroupmembership

Many-To-One Relationship: [msdyn_agentgroupmembership owner_msdyn_agentgroupmembership](msdyn_agentgroupmembership.md#BKMK_owner_msdyn_agentgroupmembership)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroupmembership`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentgroupmembership`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentgroupregion"></a> owner_msdyn_agentgroupregion

Many-To-One Relationship: [msdyn_agentgroupregion owner_msdyn_agentgroupregion](msdyn_agentgroupregion.md#BKMK_owner_msdyn_agentgroupregion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroupregion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentgroupregion`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentlanguage"></a> owner_msdyn_agentlanguage

Many-To-One Relationship: [msdyn_agentlanguage owner_msdyn_agentlanguage](msdyn_agentlanguage.md#BKMK_owner_msdyn_agentlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentlanguage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentlanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_agentregion"></a> owner_msdyn_agentregion

Many-To-One Relationship: [msdyn_agentregion owner_msdyn_agentregion](msdyn_agentregion.md#BKMK_owner_msdyn_agentregion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentregion`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_agentregion`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_bookableresourcecapacityprofile"></a> owner_msdyn_bookableresourcecapacityprofile

Many-To-One Relationship: [msdyn_bookableresourcecapacityprofile owner_msdyn_bookableresourcecapacityprofile](msdyn_bookableresourcecapacityprofile.md#BKMK_owner_msdyn_bookableresourcecapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcecapacityprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_bookableresourcecapacityprofile`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_copilotcaseformfillsetting"></a> owner_msdyn_copilotcaseformfillsetting

Many-To-One Relationship: [msdyn_copilotcaseformfillsetting owner_msdyn_copilotcaseformfillsetting](msdyn_copilotcaseformfillsetting.md#BKMK_owner_msdyn_copilotcaseformfillsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotcaseformfillsetting`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_copilotcaseformfillsetting`|
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

### <a name="BKMK_owner_msdyn_deletedconversation"></a> owner_msdyn_deletedconversation

Many-To-One Relationship: [msdyn_deletedconversation owner_msdyn_deletedconversation](msdyn_deletedconversation.md#BKMK_owner_msdyn_deletedconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_deletedconversation`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_deletedconversation`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_emailsentiment"></a> owner_msdyn_emailsentiment

Many-To-One Relationship: [msdyn_emailsentiment owner_msdyn_emailsentiment](msdyn_emailsentiment.md#BKMK_owner_msdyn_emailsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_emailsentiment`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_emailsentiment`|
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

### <a name="BKMK_owner_msdyn_entityattributepredictionrule"></a> owner_msdyn_entityattributepredictionrule

Many-To-One Relationship: [msdyn_entityattributepredictionrule owner_msdyn_entityattributepredictionrule](msdyn_entityattributepredictionrule.md#BKMK_owner_msdyn_entityattributepredictionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityattributepredictionrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_entityattributepredictionrule`|
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

### <a name="BKMK_owner_msdyn_externalcrm"></a> owner_msdyn_externalcrm

Many-To-One Relationship: [msdyn_externalcrm owner_msdyn_externalcrm](msdyn_externalcrm.md#BKMK_owner_msdyn_externalcrm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_externalcrm`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_externalcrm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_externalrecord"></a> owner_msdyn_externalrecord

Many-To-One Relationship: [msdyn_externalrecord owner_msdyn_externalrecord](msdyn_externalrecord.md#BKMK_owner_msdyn_externalrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_externalrecord`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_externalrecord`|
|IsCustomizable|`True`|
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

### <a name="BKMK_owner_msdyn_intent"></a> owner_msdyn_intent

Many-To-One Relationship: [msdyn_intent owner_msdyn_intent](msdyn_intent.md#BKMK_owner_msdyn_intent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intent`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intentattribute"></a> owner_msdyn_intentattribute

Many-To-One Relationship: [msdyn_intentattribute owner_msdyn_intentattribute](msdyn_intentattribute.md#BKMK_owner_msdyn_intentattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattribute`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intentattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intentattribute_entity"></a> owner_msdyn_intentattribute_entity

Many-To-One Relationship: [msdyn_intentattribute_entity owner_msdyn_intentattribute_entity](msdyn_intentattribute_entity.md#BKMK_owner_msdyn_intentattribute_entity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattribute_entity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intentattribute_entity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intentattributeset"></a> owner_msdyn_intentattributeset

Many-To-One Relationship: [msdyn_intentattributeset owner_msdyn_intentattributeset](msdyn_intentattributeset.md#BKMK_owner_msdyn_intentattributeset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattributeset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intentattributeset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intentconfig"></a> owner_msdyn_intentconfig

Many-To-One Relationship: [msdyn_intentconfig owner_msdyn_intentconfig](msdyn_intentconfig.md#BKMK_owner_msdyn_intentconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intentconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intententity"></a> owner_msdyn_intententity

Many-To-One Relationship: [msdyn_intententity owner_msdyn_intententity](msdyn_intententity.md#BKMK_owner_msdyn_intententity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intententity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intententity_backfillstatus"></a> owner_msdyn_intententity_backfillstatus

Many-To-One Relationship: [msdyn_intententity_backfillstatus owner_msdyn_intententity_backfillstatus](msdyn_intententity_backfillstatus.md#BKMK_owner_msdyn_intententity_backfillstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity_backfillstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intententity_backfillstatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intentfamily"></a> owner_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intentfamily owner_msdyn_intentfamily](msdyn_intentfamily.md#BKMK_owner_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentfamily`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intentfamily`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intentfeature_configuration"></a> owner_msdyn_intentfeature_configuration

Many-To-One Relationship: [msdyn_intentfeature_configuration owner_msdyn_intentfeature_configuration](msdyn_intentfeature_configuration.md#BKMK_owner_msdyn_intentfeature_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentfeature_configuration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intentfeature_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intentgroupcondition"></a> owner_msdyn_intentgroupcondition

Many-To-One Relationship: [msdyn_intentgroupcondition owner_msdyn_intentgroupcondition](msdyn_intentgroupcondition.md#BKMK_owner_msdyn_intentgroupcondition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentgroupcondition`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intentgroupcondition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_intentsolutionmap"></a> owner_msdyn_intentsolutionmap

Many-To-One Relationship: [msdyn_intentsolutionmap owner_msdyn_intentsolutionmap](msdyn_intentsolutionmap.md#BKMK_owner_msdyn_intentsolutionmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentsolutionmap`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_intentsolutionmap`|
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

### <a name="BKMK_owner_msdyn_language"></a> owner_msdyn_language

Many-To-One Relationship: [msdyn_language owner_msdyn_language](msdyn_language.md#BKMK_owner_msdyn_language)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_language`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_language`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_modelpreviewstatus"></a> owner_msdyn_modelpreviewstatus

Many-To-One Relationship: [msdyn_modelpreviewstatus owner_msdyn_modelpreviewstatus](msdyn_modelpreviewstatus.md#BKMK_owner_msdyn_modelpreviewstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_modelpreviewstatus`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_modelpreviewstatus`|
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

### <a name="BKMK_owner_msdyn_ocautoblockrule"></a> owner_msdyn_ocautoblockrule

Many-To-One Relationship: [msdyn_ocautoblockrule owner_msdyn_ocautoblockrule](msdyn_ocautoblockrule.md#BKMK_owner_msdyn_ocautoblockrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautoblockrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocautoblockrule`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocautomatedactionrule"></a> owner_msdyn_ocautomatedactionrule

Many-To-One Relationship: [msdyn_ocautomatedactionrule owner_msdyn_ocautomatedactionrule](msdyn_ocautomatedactionrule.md#BKMK_owner_msdyn_ocautomatedactionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautomatedactionrule`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocautomatedactionrule`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_ocautomatedactionrulesmapping"></a> owner_msdyn_ocautomatedactionrulesmapping

Many-To-One Relationship: [msdyn_ocautomatedactionrulesmapping owner_msdyn_ocautomatedactionrulesmapping](msdyn_ocautomatedactionrulesmapping.md#BKMK_owner_msdyn_ocautomatedactionrulesmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautomatedactionrulesmapping`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocautomatedactionrulesmapping`|
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

### <a name="BKMK_owner_msdyn_ocexternalcontext"></a> owner_msdyn_ocexternalcontext

Many-To-One Relationship: [msdyn_ocexternalcontext owner_msdyn_ocexternalcontext](msdyn_ocexternalcontext.md#BKMK_owner_msdyn_ocexternalcontext)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalcontext`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocexternalcontext`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_oclanguage"></a> owner_msdyn_oclanguage

Many-To-One Relationship: [msdyn_oclanguage owner_msdyn_oclanguage](msdyn_oclanguage.md#BKMK_owner_msdyn_oclanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclanguage`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_oclanguage`|
|IsCustomizable|`True`|
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

### <a name="BKMK_owner_msdyn_ocpaymentprofile"></a> owner_msdyn_ocpaymentprofile

Many-To-One Relationship: [msdyn_ocpaymentprofile owner_msdyn_ocpaymentprofile](msdyn_ocpaymentprofile.md#BKMK_owner_msdyn_ocpaymentprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocpaymentprofile`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_ocpaymentprofile`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_omnichannelpersonalization"></a> owner_msdyn_omnichannelpersonalization

Many-To-One Relationship: [msdyn_omnichannelpersonalization owner_msdyn_omnichannelpersonalization](msdyn_omnichannelpersonalization.md#BKMK_owner_msdyn_omnichannelpersonalization)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelpersonalization`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_omnichannelpersonalization`|
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

### <a name="BKMK_owner_msdyn_postalbum"></a> owner_msdyn_postalbum

Many-To-One Relationship: [msdyn_postalbum owner_msdyn_postalbum](msdyn_postalbum.md#BKMK_owner_msdyn_postalbum)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalbum`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_postalbum`|
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

### <a name="BKMK_owner_msdyn_rawinsight"></a> owner_msdyn_rawinsight

Many-To-One Relationship: [msdyn_rawinsight owner_msdyn_rawinsight](msdyn_rawinsight.md#BKMK_owner_msdyn_rawinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rawinsight`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_rawinsight`|
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

### <a name="BKMK_owner_msdyn_region"></a> owner_msdyn_region

Many-To-One Relationship: [msdyn_region owner_msdyn_region](msdyn_region.md#BKMK_owner_msdyn_region)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_region`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_region`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_routingrequest"></a> owner_msdyn_routingrequest

Many-To-One Relationship: [msdyn_routingrequest owner_msdyn_routingrequest](msdyn_routingrequest.md#BKMK_owner_msdyn_routingrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingrequest`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_routingrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_owner_msdyn_salescopilotemailinsight"></a> owner_msdyn_salescopilotemailinsight

Many-To-One Relationship: [msdyn_salescopilotemailinsight owner_msdyn_salescopilotemailinsight](msdyn_salescopilotemailinsight.md#BKMK_owner_msdyn_salescopilotemailinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotemailinsight`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salescopilotemailinsight`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_salescopilotinsightcardstate"></a> owner_msdyn_salescopilotinsightcardstate

Many-To-One Relationship: [msdyn_salescopilotinsightcardstate owner_msdyn_salescopilotinsightcardstate](msdyn_salescopilotinsightcardstate.md#BKMK_owner_msdyn_salescopilotinsightcardstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsightcardstate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_salescopilotinsightcardstate`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_sessiontemplate"></a> owner_msdyn_sessiontemplate

Many-To-One Relationship: [msdyn_sessiontemplate owner_msdyn_sessiontemplate](msdyn_sessiontemplate.md#BKMK_owner_msdyn_sessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiontemplate`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_sessiontemplate`|
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

### <a name="BKMK_owner_msdyn_taggedrecord"></a> owner_msdyn_taggedrecord

Many-To-One Relationship: [msdyn_taggedrecord owner_msdyn_taggedrecord](msdyn_taggedrecord.md#BKMK_owner_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taggedrecord`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_taggedrecord`|
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

### <a name="BKMK_owner_msdyn_templateruleset"></a> owner_msdyn_templateruleset

Many-To-One Relationship: [msdyn_templateruleset owner_msdyn_templateruleset](msdyn_templateruleset.md#BKMK_owner_msdyn_templateruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateruleset`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_templateruleset`|
|IsCustomizable|`False`|
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

### <a name="BKMK_owner_msdyn_timetracker"></a> owner_msdyn_timetracker

Many-To-One Relationship: [msdyn_timetracker owner_msdyn_timetracker](msdyn_timetracker.md#BKMK_owner_msdyn_timetracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timetracker`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_timetracker`|
|IsCustomizable|`True`|
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

### <a name="BKMK_owner_msdyn_transcript"></a> owner_msdyn_transcript

Many-To-One Relationship: [msdyn_transcript owner_msdyn_transcript](msdyn_transcript.md#BKMK_owner_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_transcript`|
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

### <a name="BKMK_owner_msdyn_wallsavedqueryusersettings"></a> owner_msdyn_wallsavedqueryusersettings

Many-To-One Relationship: [msdyn_wallsavedqueryusersettings owner_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_owner_msdyn_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wallsavedqueryusersettings`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_wallsavedqueryusersettings`|
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

### <a name="BKMK_owner_msdyn_wkwconfig"></a> owner_msdyn_wkwconfig

Many-To-One Relationship: [msdyn_wkwconfig owner_msdyn_wkwconfig](msdyn_wkwconfig.md#BKMK_owner_msdyn_wkwconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wkwconfig`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyn_wkwconfig`|
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

### <a name="BKMK_owner_msdyncrm_addtocalendarstyle"></a> owner_msdyncrm_addtocalendarstyle

Many-To-One Relationship: [msdyncrm_addtocalendarstyle owner_msdyncrm_addtocalendarstyle](msdyncrm_addtocalendarstyle.md#BKMK_owner_msdyncrm_addtocalendarstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_addtocalendarstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_addtocalendarstyle`|
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

### <a name="BKMK_owner_msdyncrm_contentblockstyle"></a> owner_msdyncrm_contentblockstyle

Many-To-One Relationship: [msdyncrm_contentblockstyle owner_msdyncrm_contentblockstyle](msdyncrm_contentblockstyle.md#BKMK_owner_msdyncrm_contentblockstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentblockstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_contentblockstyle`|
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

### <a name="BKMK_owner_msdyncrm_generalstyles"></a> owner_msdyncrm_generalstyles

Many-To-One Relationship: [msdyncrm_generalstyles owner_msdyncrm_generalstyles](msdyncrm_generalstyles.md#BKMK_owner_msdyncrm_generalstyles)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_generalstyles`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_generalstyles`|
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

### <a name="BKMK_owner_msdyncrm_layoutstyle"></a> owner_msdyncrm_layoutstyle

Many-To-One Relationship: [msdyncrm_layoutstyle owner_msdyncrm_layoutstyle](msdyncrm_layoutstyle.md#BKMK_owner_msdyncrm_layoutstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_layoutstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_layoutstyle`|
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

### <a name="BKMK_owner_msdyncrm_textstyle"></a> owner_msdyncrm_textstyle

Many-To-One Relationship: [msdyncrm_textstyle owner_msdyncrm_textstyle](msdyncrm_textstyle.md#BKMK_owner_msdyncrm_textstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_textstyle`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdyncrm_textstyle`|
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

### <a name="BKMK_owner_msdynmkt_catalogeventstatusconfiguration"></a> owner_msdynmkt_catalogeventstatusconfiguration

Many-To-One Relationship: [msdynmkt_catalogeventstatusconfiguration owner_msdynmkt_catalogeventstatusconfiguration](msdynmkt_catalogeventstatusconfiguration.md#BKMK_owner_msdynmkt_catalogeventstatusconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_catalogeventstatusconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_catalogeventstatusconfiguration`|
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

### <a name="BKMK_owner_msdynmkt_featureconfiguration"></a> owner_msdynmkt_featureconfiguration

Many-To-One Relationship: [msdynmkt_featureconfiguration owner_msdynmkt_featureconfiguration](msdynmkt_featureconfiguration.md#BKMK_owner_msdynmkt_featureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_featureconfiguration`|
|ReferencingAttribute|`ownerid`|
|ReferencedEntityNavigationPropertyName|`owner_msdynmkt_featureconfiguration`|
|IsCustomizable|`False`|
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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

