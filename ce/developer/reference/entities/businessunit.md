---
title: "Business Unit (BusinessUnit) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Business Unit (BusinessUnit) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Business Unit (BusinessUnit) table/entity reference (Microsoft Dynamics 365)

Business, division, or department in the Microsoft Dynamics 365 database.

> [!NOTE]
> The Microsoft Dynamics 365 Business Unit (BusinessUnit) table extends the [Microsoft Dataverse Business Unit (BusinessUnit) table](/power-apps/developer/data-platform/reference/entities/businessunit).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [business_unit_activitymonitor](#BKMK_business_unit_activitymonitor)
- [business_unit_adminsettingsentity](#BKMK_business_unit_adminsettingsentity)
- [business_unit_bookableresource](#BKMK_business_unit_bookableresource)
- [business_unit_bookableresourcebooking](#BKMK_business_unit_bookableresourcebooking)
- [business_unit_bookableresourcebookingheader](#BKMK_business_unit_bookableresourcebookingheader)
- [business_unit_bookableresourcecategory](#BKMK_business_unit_bookableresourcecategory)
- [business_unit_bookableresourcecategoryassn](#BKMK_business_unit_bookableresourcecategoryassn)
- [business_unit_bookableresourcecharacteristic](#BKMK_business_unit_bookableresourcecharacteristic)
- [business_unit_bookableresourcegroup](#BKMK_business_unit_bookableresourcegroup)
- [business_unit_bookingstatus](#BKMK_business_unit_bookingstatus)
- [business_unit_BulkOperation_activities](#BKMK_business_unit_BulkOperation_activities)
- [business_unit_campaignactivity_activities](#BKMK_business_unit_campaignactivity_activities)
- [business_unit_campaignresponse_activities](#BKMK_business_unit_campaignresponse_activities)
- [business_unit_characteristic](#BKMK_business_unit_characteristic)
- [business_unit_constraint_based_groups](#BKMK_business_unit_constraint_based_groups)
- [business_unit_dynamicproperyinstance](#BKMK_business_unit_dynamicproperyinstance)
- [business_unit_entitlement](#BKMK_business_unit_entitlement)
- [business_unit_entitlemententityallocationtypemapping](#BKMK_business_unit_entitlemententityallocationtypemapping)
- [business_unit_equipment](#BKMK_business_unit_equipment)
- [business_unit_incident_resolution_activities](#BKMK_business_unit_incident_resolution_activities)
- [business_unit_incidents](#BKMK_business_unit_incidents)
- [business_unit_invoices](#BKMK_business_unit_invoices)
- [business_unit_leads](#BKMK_business_unit_leads)
- [business_unit_list](#BKMK_business_unit_list)
- [business_unit_listoperation](#BKMK_business_unit_listoperation)
- [business_unit_msdyn_actioncardactionstat](#BKMK_business_unit_msdyn_actioncardactionstat)
- [business_unit_msdyn_actioncardregarding](#BKMK_business_unit_msdyn_actioncardregarding)
- [business_unit_msdyn_actioncardrolesetting](#BKMK_business_unit_msdyn_actioncardrolesetting)
- [business_unit_msdyn_actioncardstataggregation](#BKMK_business_unit_msdyn_actioncardstataggregation)
- [business_unit_msdyn_activeicdextension](#BKMK_business_unit_msdyn_activeicdextension)
- [business_unit_msdyn_adminappstate](#BKMK_business_unit_msdyn_adminappstate)
- [business_unit_msdyn_agentcapacityprofileunit](#BKMK_business_unit_msdyn_agentcapacityprofileunit)
- [business_unit_msdyn_agentcapacityupdatehistory](#BKMK_business_unit_msdyn_agentcapacityupdatehistory)
- [business_unit_msdyn_agentchannelstate](#BKMK_business_unit_msdyn_agentchannelstate)
- [business_unit_msdyn_agentgroup](#BKMK_business_unit_msdyn_agentgroup)
- [business_unit_msdyn_agentgrouplanguage](#BKMK_business_unit_msdyn_agentgrouplanguage)
- [business_unit_msdyn_agentgroupmembership](#BKMK_business_unit_msdyn_agentgroupmembership)
- [business_unit_msdyn_agentgroupregion](#BKMK_business_unit_msdyn_agentgroupregion)
- [business_unit_msdyn_agentlanguage](#BKMK_business_unit_msdyn_agentlanguage)
- [business_unit_msdyn_agentregion](#BKMK_business_unit_msdyn_agentregion)
- [business_unit_msdyn_agentstatus](#BKMK_business_unit_msdyn_agentstatus)
- [business_unit_msdyn_agentstatushistory](#BKMK_business_unit_msdyn_agentstatushistory)
- [business_unit_msdyn_aicontactsuggestion](#BKMK_business_unit_msdyn_aicontactsuggestion)
- [business_unit_msdyn_analytics](#BKMK_business_unit_msdyn_analytics)
- [business_unit_msdyn_appconfiguration](#BKMK_business_unit_msdyn_appconfiguration)
- [business_unit_msdyn_applicationextension](#BKMK_business_unit_msdyn_applicationextension)
- [business_unit_msdyn_applicationtabtemplate](#BKMK_business_unit_msdyn_applicationtabtemplate)
- [business_unit_msdyn_appprofilerolemapping](#BKMK_business_unit_msdyn_appprofilerolemapping)
- [business_unit_msdyn_appstate](#BKMK_business_unit_msdyn_appstate)
- [business_unit_msdyn_assetcategorytemplateassociation](#BKMK_business_unit_msdyn_assetcategorytemplateassociation)
- [business_unit_msdyn_assettemplateassociation](#BKMK_business_unit_msdyn_assettemplateassociation)
- [business_unit_msdyn_assignmentconfiguration](#BKMK_business_unit_msdyn_assignmentconfiguration)
- [business_unit_msdyn_assignmentconfigurationstep](#BKMK_business_unit_msdyn_assignmentconfigurationstep)
- [business_unit_msdyn_assignmentmap](#BKMK_business_unit_msdyn_assignmentmap)
- [business_unit_msdyn_assignmentrule](#BKMK_business_unit_msdyn_assignmentrule)
- [business_unit_msdyn_attribute](#BKMK_business_unit_msdyn_attribute)
- [business_unit_msdyn_attributevalue](#BKMK_business_unit_msdyn_attributevalue)
- [business_unit_msdyn_authenticationsettings](#BKMK_business_unit_msdyn_authenticationsettings)
- [business_unit_msdyn_authsettingsentry](#BKMK_business_unit_msdyn_authsettingsentry)
- [business_unit_msdyn_autocapturerule](#BKMK_business_unit_msdyn_autocapturerule)
- [business_unit_msdyn_autocapturesettings](#BKMK_business_unit_msdyn_autocapturesettings)
- [business_unit_msdyn_autonomouscasecreationrule](#BKMK_business_unit_msdyn_autonomouscasecreationrule)
- [business_unit_msdyn_bookableresourcecapacityprofile](#BKMK_business_unit_msdyn_bookableresourcecapacityprofile)
- [business_unit_msdyn_botsession](#BKMK_business_unit_msdyn_botsession)
- [business_unit_msdyn_capacityprofile](#BKMK_business_unit_msdyn_capacityprofile)
- [business_unit_msdyn_cdsentityengagementctx](#BKMK_business_unit_msdyn_cdsentityengagementctx)
- [business_unit_msdyn_channeldefinition](#BKMK_business_unit_msdyn_channeldefinition)
- [business_unit_msdyn_channeldefinitionconsent](#BKMK_business_unit_msdyn_channeldefinitionconsent)
- [business_unit_msdyn_channeldefinitionlocale](#BKMK_business_unit_msdyn_channeldefinitionlocale)
- [business_unit_msdyn_channelinstance](#BKMK_business_unit_msdyn_channelinstance)
- [business_unit_msdyn_channelinstanceaccount](#BKMK_business_unit_msdyn_channelinstanceaccount)
- [business_unit_msdyn_channelmessageattachment](#BKMK_business_unit_msdyn_channelmessageattachment)
- [business_unit_msdyn_channelmessagecontextpart](#BKMK_business_unit_msdyn_channelmessagecontextpart)
- [business_unit_msdyn_channelmessagepart](#BKMK_business_unit_msdyn_channelmessagepart)
- [business_unit_msdyn_channelprovider](#BKMK_business_unit_msdyn_channelprovider)
- [business_unit_msdyn_consumingapplication](#BKMK_business_unit_msdyn_consumingapplication)
- [business_unit_msdyn_contactsuggestionrule](#BKMK_business_unit_msdyn_contactsuggestionrule)
- [business_unit_msdyn_contactsuggestionruleset](#BKMK_business_unit_msdyn_contactsuggestionruleset)
- [business_unit_msdyn_conversationaction](#BKMK_business_unit_msdyn_conversationaction)
- [business_unit_msdyn_conversationactionitem](#BKMK_business_unit_msdyn_conversationactionitem)
- [business_unit_msdyn_conversationactionlocale](#BKMK_business_unit_msdyn_conversationactionlocale)
- [business_unit_msdyn_conversationaggregatedinsights](#BKMK_business_unit_msdyn_conversationaggregatedinsights)
- [business_unit_msdyn_conversationcomment](#BKMK_business_unit_msdyn_conversationcomment)
- [business_unit_msdyn_conversationinsight](#BKMK_business_unit_msdyn_conversationinsight)
- [business_unit_msdyn_conversationmessageblock](#BKMK_business_unit_msdyn_conversationmessageblock)
- [business_unit_msdyn_conversationparticipantinsights](#BKMK_business_unit_msdyn_conversationparticipantinsights)
- [business_unit_msdyn_conversationparticipantsentiment](#BKMK_business_unit_msdyn_conversationparticipantsentiment)
- [business_unit_msdyn_conversationquestion](#BKMK_business_unit_msdyn_conversationquestion)
- [business_unit_msdyn_conversationsegmentsentiment](#BKMK_business_unit_msdyn_conversationsegmentsentiment)
- [business_unit_msdyn_conversationsentiment](#BKMK_business_unit_msdyn_conversationsentiment)
- [business_unit_msdyn_conversationsignal](#BKMK_business_unit_msdyn_conversationsignal)
- [business_unit_msdyn_conversationsubject](#BKMK_business_unit_msdyn_conversationsubject)
- [business_unit_msdyn_conversationsummarysuggestion](#BKMK_business_unit_msdyn_conversationsummarysuggestion)
- [business_unit_msdyn_conversationsystemtag](#BKMK_business_unit_msdyn_conversationsystemtag)
- [business_unit_msdyn_conversationtag](#BKMK_business_unit_msdyn_conversationtag)
- [business_unit_msdyn_copilotagentpreference](#BKMK_business_unit_msdyn_copilotagentpreference)
- [business_unit_msdyn_copilotcaseformfillsetting](#BKMK_business_unit_msdyn_copilotcaseformfillsetting)
- [business_unit_msdyn_copilotinteractiondata](#BKMK_business_unit_msdyn_copilotinteractiondata)
- [business_unit_msdyn_copilottranscriptdata](#BKMK_business_unit_msdyn_copilottranscriptdata)
- [business_unit_msdyn_crmconnection](#BKMK_business_unit_msdyn_crmconnection)
- [business_unit_msdyn_csadminconfig](#BKMK_business_unit_msdyn_csadminconfig)
- [business_unit_msdyn_customapirulesetconfiguration](#BKMK_business_unit_msdyn_customapirulesetconfiguration)
- [business_unit_msdyn_customerasset](#BKMK_business_unit_msdyn_customerasset)
- [business_unit_msdyn_customerassetattachment](#BKMK_business_unit_msdyn_customerassetattachment)
- [business_unit_msdyn_customerassetcategory](#BKMK_business_unit_msdyn_customerassetcategory)
- [business_unit_msdyn_dataanalyticscustomizedreport](#BKMK_business_unit_msdyn_dataanalyticscustomizedreport)
- [business_unit_msdyn_dataanalyticsdataset](#BKMK_business_unit_msdyn_dataanalyticsdataset)
- [business_unit_msdyn_dataanalyticsreport](#BKMK_business_unit_msdyn_dataanalyticsreport)
- [business_unit_msdyn_dataanalyticsworkspace](#BKMK_business_unit_msdyn_dataanalyticsworkspace)
- [business_unit_msdyn_dealmanageraccess](#BKMK_business_unit_msdyn_dealmanageraccess)
- [business_unit_msdyn_dealmanagersettings](#BKMK_business_unit_msdyn_dealmanagersettings)
- [business_unit_msdyn_decisioncontract](#BKMK_business_unit_msdyn_decisioncontract)
- [business_unit_msdyn_decisionruleset](#BKMK_business_unit_msdyn_decisionruleset)
- [business_unit_msdyn_deletedconversation](#BKMK_business_unit_msdyn_deletedconversation)
- [business_unit_msdyn_duplicateleadmapping](#BKMK_business_unit_msdyn_duplicateleadmapping)
- [business_unit_msdyn_effortpredictionresult](#BKMK_business_unit_msdyn_effortpredictionresult)
- [business_unit_msdyn_emailsentiment](#BKMK_business_unit_msdyn_emailsentiment)
- [business_unit_msdyn_entityattachment](#BKMK_business_unit_msdyn_entityattachment)
- [business_unit_msdyn_entityattributepredictionrule](#BKMK_business_unit_msdyn_entityattributepredictionrule)
- [business_unit_msdyn_entityrankingrule](#BKMK_business_unit_msdyn_entityrankingrule)
- [business_unit_msdyn_entityroutingconfiguration](#BKMK_business_unit_msdyn_entityroutingconfiguration)
- [business_unit_msdyn_entityworkstreammap](#BKMK_business_unit_msdyn_entityworkstreammap)
- [business_unit_msdyn_extendedusersetting](#BKMK_business_unit_msdyn_extendedusersetting)
- [business_unit_msdyn_externalcrm](#BKMK_business_unit_msdyn_externalcrm)
- [business_unit_msdyn_externalrecord](#BKMK_business_unit_msdyn_externalrecord)
- [business_unit_msdyn_flowcardtype](#BKMK_business_unit_msdyn_flowcardtype)
- [business_unit_msdyn_forecastconfiguration](#BKMK_business_unit_msdyn_forecastconfiguration)
- [business_unit_msdyn_forecastdefinition](#BKMK_business_unit_msdyn_forecastdefinition)
- [business_unit_msdyn_forecastinstance](#BKMK_business_unit_msdyn_forecastinstance)
- [business_unit_msdyn_forecastrecurrence](#BKMK_business_unit_msdyn_forecastrecurrence)
- [business_unit_msdyn_functionallocation](#BKMK_business_unit_msdyn_functionallocation)
- [business_unit_msdyn_functionallocationtype](#BKMK_business_unit_msdyn_functionallocationtype)
- [business_unit_msdyn_gdprdata](#BKMK_business_unit_msdyn_gdprdata)
- [business_unit_msdyn_icdextension](#BKMK_business_unit_msdyn_icdextension)
- [business_unit_msdyn_icebreakersconfig](#BKMK_business_unit_msdyn_icebreakersconfig)
- [business_unit_msdyn_iermlmodel](#BKMK_business_unit_msdyn_iermlmodel)
- [business_unit_msdyn_iermltraining](#BKMK_business_unit_msdyn_iermltraining)
- [business_unit_msdyn_intent](#BKMK_business_unit_msdyn_intent)
- [business_unit_msdyn_intentattribute](#BKMK_business_unit_msdyn_intentattribute)
- [business_unit_msdyn_intentattribute_entity](#BKMK_business_unit_msdyn_intentattribute_entity)
- [business_unit_msdyn_intentattributeset](#BKMK_business_unit_msdyn_intentattributeset)
- [business_unit_msdyn_intentconfig](#BKMK_business_unit_msdyn_intentconfig)
- [business_unit_msdyn_intententity](#BKMK_business_unit_msdyn_intententity)
- [business_unit_msdyn_intententity_backfillstatus](#BKMK_business_unit_msdyn_intententity_backfillstatus)
- [business_unit_msdyn_intentfamily](#BKMK_business_unit_msdyn_intentfamily)
- [business_unit_msdyn_intentfeature_configuration](#BKMK_business_unit_msdyn_intentfeature_configuration)
- [business_unit_msdyn_intentgroupcondition](#BKMK_business_unit_msdyn_intentgroupcondition)
- [business_unit_msdyn_intentsolutionmap](#BKMK_business_unit_msdyn_intentsolutionmap)
- [business_unit_msdyn_iotalert](#BKMK_business_unit_msdyn_iotalert)
- [business_unit_msdyn_iotdevice](#BKMK_business_unit_msdyn_iotdevice)
- [business_unit_msdyn_iotdevicecategory](#BKMK_business_unit_msdyn_iotdevicecategory)
- [business_unit_msdyn_iotdevicecommand](#BKMK_business_unit_msdyn_iotdevicecommand)
- [business_unit_msdyn_iotdevicecommanddefinition](#BKMK_business_unit_msdyn_iotdevicecommanddefinition)
- [business_unit_msdyn_iotdevicedatahistory](#BKMK_business_unit_msdyn_iotdevicedatahistory)
- [business_unit_msdyn_iotdeviceproperty](#BKMK_business_unit_msdyn_iotdeviceproperty)
- [business_unit_msdyn_iotdeviceregistrationhistory](#BKMK_business_unit_msdyn_iotdeviceregistrationhistory)
- [business_unit_msdyn_iotdevicevisualizationconfiguration](#BKMK_business_unit_msdyn_iotdevicevisualizationconfiguration)
- [business_unit_msdyn_iotfieldmapping](#BKMK_business_unit_msdyn_iotfieldmapping)
- [business_unit_msdyn_iotpropertydefinition](#BKMK_business_unit_msdyn_iotpropertydefinition)
- [business_unit_msdyn_iotprovider](#BKMK_business_unit_msdyn_iotprovider)
- [business_unit_msdyn_iotproviderinstance](#BKMK_business_unit_msdyn_iotproviderinstance)
- [business_unit_msdyn_iotsettings](#BKMK_business_unit_msdyn_iotsettings)
- [business_unit_msdyn_kpieventdata](#BKMK_business_unit_msdyn_kpieventdata)
- [business_unit_msdyn_kpieventdefinition](#BKMK_business_unit_msdyn_kpieventdefinition)
- [business_unit_msdyn_language](#BKMK_business_unit_msdyn_language)
- [business_unit_msdyn_leadmodelconfig](#BKMK_business_unit_msdyn_leadmodelconfig)
- [business_unit_msdyn_liveworkitemevent](#BKMK_business_unit_msdyn_liveworkitemevent)
- [business_unit_msdyn_liveworkstream](#BKMK_business_unit_msdyn_liveworkstream)
- [business_unit_msdyn_liveworkstreamcapacityprofile](#BKMK_business_unit_msdyn_liveworkstreamcapacityprofile)
- [business_unit_msdyn_locationtemplateassociation](#BKMK_business_unit_msdyn_locationtemplateassociation)
- [business_unit_msdyn_locationtypetemplateassociation](#BKMK_business_unit_msdyn_locationtypetemplateassociation)
- [business_unit_msdyn_lockstatus](#BKMK_business_unit_msdyn_lockstatus)
- [business_unit_msdyn_macrosession](#BKMK_business_unit_msdyn_macrosession)
- [business_unit_msdyn_masterentityroutingconfiguration](#BKMK_business_unit_msdyn_masterentityroutingconfiguration)
- [business_unit_msdyn_migrationtracker](#BKMK_business_unit_msdyn_migrationtracker)
- [business_unit_msdyn_modelpreviewstatus](#BKMK_business_unit_msdyn_modelpreviewstatus)
- [business_unit_msdyn_notesanalysisconfig](#BKMK_business_unit_msdyn_notesanalysisconfig)
- [business_unit_msdyn_notificationfield](#BKMK_business_unit_msdyn_notificationfield)
- [business_unit_msdyn_notificationtemplate](#BKMK_business_unit_msdyn_notificationtemplate)
- [business_unit_msdyn_oc_geolocationprovider](#BKMK_business_unit_msdyn_oc_geolocationprovider)
- [business_unit_msdyn_ocagentassignedcustomapiprivilege](#BKMK_business_unit_msdyn_ocagentassignedcustomapiprivilege)
- [business_unit_msdyn_ocautoblockrule](#BKMK_business_unit_msdyn_ocautoblockrule)
- [business_unit_msdyn_ocautomatedactionrule](#BKMK_business_unit_msdyn_ocautomatedactionrule)
- [business_unit_msdyn_ocautomatedactionrulesmapping](#BKMK_business_unit_msdyn_ocautomatedactionrulesmapping)
- [business_unit_msdyn_ocbotchannelregistration](#BKMK_business_unit_msdyn_ocbotchannelregistration)
- [business_unit_msdyn_ocbotchannelregistrationsecret](#BKMK_business_unit_msdyn_ocbotchannelregistrationsecret)
- [business_unit_msdyn_occhannelapiconversationprivilege](#BKMK_business_unit_msdyn_occhannelapiconversationprivilege)
- [business_unit_msdyn_occhannelapimessageprivilege](#BKMK_business_unit_msdyn_occhannelapimessageprivilege)
- [business_unit_msdyn_occhannelapimethodmapping](#BKMK_business_unit_msdyn_occhannelapimethodmapping)
- [business_unit_msdyn_ocexternalcontext](#BKMK_business_unit_msdyn_ocexternalcontext)
- [business_unit_msdyn_ocflaggedspam](#BKMK_business_unit_msdyn_ocflaggedspam)
- [business_unit_msdyn_oclanguage](#BKMK_business_unit_msdyn_oclanguage)
- [business_unit_msdyn_ocliveworkitemcapacityprofile](#BKMK_business_unit_msdyn_ocliveworkitemcapacityprofile)
- [business_unit_msdyn_ocliveworkitemcharacteristic](#BKMK_business_unit_msdyn_ocliveworkitemcharacteristic)
- [business_unit_msdyn_ocliveworkitemcontextitem](#BKMK_business_unit_msdyn_ocliveworkitemcontextitem)
- [business_unit_msdyn_ocliveworkitemsentiment](#BKMK_business_unit_msdyn_ocliveworkitemsentiment)
- [business_unit_msdyn_ocliveworkstreamcontextvariable](#BKMK_business_unit_msdyn_ocliveworkstreamcontextvariable)
- [business_unit_msdyn_ocpaymentprofile](#BKMK_business_unit_msdyn_ocpaymentprofile)
- [business_unit_msdyn_ocprovisioningstate](#BKMK_business_unit_msdyn_ocprovisioningstate)
- [business_unit_msdyn_ocrecording](#BKMK_business_unit_msdyn_ocrecording)
- [business_unit_msdyn_ocrequest](#BKMK_business_unit_msdyn_ocrequest)
- [business_unit_msdyn_ocrichobject](#BKMK_business_unit_msdyn_ocrichobject)
- [business_unit_msdyn_ocrichobjectmap](#BKMK_business_unit_msdyn_ocrichobjectmap)
- [business_unit_msdyn_ocruleitem](#BKMK_business_unit_msdyn_ocruleitem)
- [business_unit_msdyn_ocsentimentdailytopic](#BKMK_business_unit_msdyn_ocsentimentdailytopic)
- [business_unit_msdyn_ocsentimentdailytopickeyword](#BKMK_business_unit_msdyn_ocsentimentdailytopickeyword)
- [business_unit_msdyn_ocsentimentdailytopictrending](#BKMK_business_unit_msdyn_ocsentimentdailytopictrending)
- [business_unit_msdyn_ocsessioncharacteristic](#BKMK_business_unit_msdyn_ocsessioncharacteristic)
- [business_unit_msdyn_ocsessionparticipantevent](#BKMK_business_unit_msdyn_ocsessionparticipantevent)
- [business_unit_msdyn_ocsessionsentiment](#BKMK_business_unit_msdyn_ocsessionsentiment)
- [business_unit_msdyn_ocsimltraining](#BKMK_business_unit_msdyn_ocsimltraining)
- [business_unit_msdyn_ocsitdimportconfig](#BKMK_business_unit_msdyn_ocsitdimportconfig)
- [business_unit_msdyn_ocsitdskill](#BKMK_business_unit_msdyn_ocsitdskill)
- [business_unit_msdyn_ocsitrainingdata](#BKMK_business_unit_msdyn_ocsitrainingdata)
- [business_unit_msdyn_ocskillidentmlmodel](#BKMK_business_unit_msdyn_ocskillidentmlmodel)
- [business_unit_msdyn_omnichannelpersonalization](#BKMK_business_unit_msdyn_omnichannelpersonalization)
- [business_unit_msdyn_omnichannelsyncconfig](#BKMK_business_unit_msdyn_omnichannelsyncconfig)
- [business_unit_msdyn_operatinghour](#BKMK_business_unit_msdyn_operatinghour)
- [business_unit_msdyn_opportunitymodelconfig](#BKMK_business_unit_msdyn_opportunitymodelconfig)
- [business_unit_msdyn_orgchartnode](#BKMK_business_unit_msdyn_orgchartnode)
- [business_unit_msdyn_overflowactionconfig](#BKMK_business_unit_msdyn_overflowactionconfig)
- [business_unit_msdyn_personalmessage](#BKMK_business_unit_msdyn_personalmessage)
- [business_unit_msdyn_personalsoundsetting](#BKMK_business_unit_msdyn_personalsoundsetting)
- [business_unit_msdyn_postalbum](#BKMK_business_unit_msdyn_postalbum)
- [business_unit_msdyn_predictioncomputationoperation](#BKMK_business_unit_msdyn_predictioncomputationoperation)
- [business_unit_msdyn_predictionmodelstatus](#BKMK_business_unit_msdyn_predictionmodelstatus)
- [business_unit_msdyn_predictionscheduledoperation](#BKMK_business_unit_msdyn_predictionscheduledoperation)
- [business_unit_msdyn_predictivescoringsyncstatus](#BKMK_business_unit_msdyn_predictivescoringsyncstatus)
- [business_unit_msdyn_preferredagent](#BKMK_business_unit_msdyn_preferredagent)
- [business_unit_msdyn_preferredagentcustomeridentity](#BKMK_business_unit_msdyn_preferredagentcustomeridentity)
- [business_unit_msdyn_preferredagentroutedentity](#BKMK_business_unit_msdyn_preferredagentroutedentity)
- [business_unit_msdyn_productivityactioninputparameter](#BKMK_business_unit_msdyn_productivityactioninputparameter)
- [business_unit_msdyn_productivityactionoutputparameter](#BKMK_business_unit_msdyn_productivityactionoutputparameter)
- [business_unit_msdyn_productivityagentscript](#BKMK_business_unit_msdyn_productivityagentscript)
- [business_unit_msdyn_productivityagentscriptstep](#BKMK_business_unit_msdyn_productivityagentscriptstep)
- [business_unit_msdyn_productivitymacroactiontemplate](#BKMK_business_unit_msdyn_productivitymacroactiontemplate)
- [business_unit_msdyn_productivitymacroconnector](#BKMK_business_unit_msdyn_productivitymacroconnector)
- [business_unit_msdyn_productivitymacrosolutionconfiguration](#BKMK_business_unit_msdyn_productivitymacrosolutionconfiguration)
- [business_unit_msdyn_productivityparameterdefinition](#BKMK_business_unit_msdyn_productivityparameterdefinition)
- [business_unit_msdyn_property](#BKMK_business_unit_msdyn_property)
- [business_unit_msdyn_propertyassetassociation](#BKMK_business_unit_msdyn_propertyassetassociation)
- [business_unit_msdyn_propertylocationassociation](#BKMK_business_unit_msdyn_propertylocationassociation)
- [business_unit_msdyn_propertylog](#BKMK_business_unit_msdyn_propertylog)
- [business_unit_msdyn_propertytemplateassociation](#BKMK_business_unit_msdyn_propertytemplateassociation)
- [business_unit_msdyn_rawinsight](#BKMK_business_unit_msdyn_rawinsight)
- [business_unit_msdyn_readtracker](#BKMK_business_unit_msdyn_readtracker)
- [business_unit_msdyn_realtimescoring](#BKMK_business_unit_msdyn_realtimescoring)
- [business_unit_msdyn_realtimescoringoperation](#BKMK_business_unit_msdyn_realtimescoringoperation)
- [business_unit_msdyn_region](#BKMK_business_unit_msdyn_region)
- [business_unit_msdyn_reportbookmark](#BKMK_business_unit_msdyn_reportbookmark)
- [business_unit_msdyn_routingconfiguration](#BKMK_business_unit_msdyn_routingconfiguration)
- [business_unit_msdyn_routingconfigurationstep](#BKMK_business_unit_msdyn_routingconfigurationstep)
- [business_unit_msdyn_routingrequest](#BKMK_business_unit_msdyn_routingrequest)
- [business_unit_msdyn_salescopilotemailinsight](#BKMK_business_unit_msdyn_salescopilotemailinsight)
- [business_unit_msdyn_salescopilotinsight](#BKMK_business_unit_msdyn_salescopilotinsight)
- [business_unit_msdyn_salescopilotinsightcardstate](#BKMK_business_unit_msdyn_salescopilotinsightcardstate)
- [business_unit_msdyn_salesinsightssettings](#BKMK_business_unit_msdyn_salesinsightssettings)
- [business_unit_msdyn_salesocmessage](#BKMK_business_unit_msdyn_salesocmessage)
- [business_unit_msdyn_salesocsmstemplate](#BKMK_business_unit_msdyn_salesocsmstemplate)
- [business_unit_msdyn_salesroutingrun](#BKMK_business_unit_msdyn_salesroutingrun)
- [business_unit_msdyn_salessuggestion](#BKMK_business_unit_msdyn_salessuggestion)
- [business_unit_msdyn_salestag](#BKMK_business_unit_msdyn_salestag)
- [business_unit_msdyn_sciconversation](#BKMK_business_unit_msdyn_sciconversation)
- [business_unit_msdyn_scicustomemailhighlight](#BKMK_business_unit_msdyn_scicustomemailhighlight)
- [business_unit_msdyn_scicustomhighlight](#BKMK_business_unit_msdyn_scicustomhighlight)
- [business_unit_msdyn_scicustompublisher](#BKMK_business_unit_msdyn_scicustompublisher)
- [business_unit_msdyn_sciusersettings](#BKMK_business_unit_msdyn_sciusersettings)
- [business_unit_msdyn_searchconfiguration](#BKMK_business_unit_msdyn_searchconfiguration)
- [business_unit_msdyn_segment](#BKMK_business_unit_msdyn_segment)
- [business_unit_msdyn_sequence](#BKMK_business_unit_msdyn_sequence)
- [business_unit_msdyn_sequencestat](#BKMK_business_unit_msdyn_sequencestat)
- [business_unit_msdyn_sequencetarget](#BKMK_business_unit_msdyn_sequencetarget)
- [business_unit_msdyn_sequencetargetstep](#BKMK_business_unit_msdyn_sequencetargetstep)
- [business_unit_msdyn_sequencetemplate](#BKMK_business_unit_msdyn_sequencetemplate)
- [business_unit_msdyn_serviceoneprovisioningrequest](#BKMK_business_unit_msdyn_serviceoneprovisioningrequest)
- [business_unit_msdyn_sessionevent](#BKMK_business_unit_msdyn_sessionevent)
- [business_unit_msdyn_sessionparticipant](#BKMK_business_unit_msdyn_sessionparticipant)
- [business_unit_msdyn_sessiontemplate](#BKMK_business_unit_msdyn_sessiontemplate)
- [business_unit_msdyn_siconfig](#BKMK_business_unit_msdyn_siconfig)
- [business_unit_msdyn_skillattachmentruleitem](#BKMK_business_unit_msdyn_skillattachmentruleitem)
- [business_unit_msdyn_skillattachmenttarget](#BKMK_business_unit_msdyn_skillattachmenttarget)
- [business_unit_msdyn_soundnotificationsetting](#BKMK_business_unit_msdyn_soundnotificationsetting)
- [business_unit_msdyn_submodeldefinition](#BKMK_business_unit_msdyn_submodeldefinition)
- [business_unit_msdyn_suggestionassignmentrule](#BKMK_business_unit_msdyn_suggestionassignmentrule)
- [business_unit_msdyn_suggestionprincipalobjectaccess](#BKMK_business_unit_msdyn_suggestionprincipalobjectaccess)
- [business_unit_msdyn_suggestionsellerpriority](#BKMK_business_unit_msdyn_suggestionsellerpriority)
- [business_unit_msdyn_swarm](#BKMK_business_unit_msdyn_swarm)
- [business_unit_msdyn_swarmparticipant](#BKMK_business_unit_msdyn_swarmparticipant)
- [business_unit_msdyn_swarmparticipantrule](#BKMK_business_unit_msdyn_swarmparticipantrule)
- [business_unit_msdyn_swarmrole](#BKMK_business_unit_msdyn_swarmrole)
- [business_unit_msdyn_swarmskill](#BKMK_business_unit_msdyn_swarmskill)
- [business_unit_msdyn_swarmtemplate](#BKMK_business_unit_msdyn_swarmtemplate)
- [business_unit_msdyn_taggedrecord](#BKMK_business_unit_msdyn_taggedrecord)
- [business_unit_msdyn_templateforproperties](#BKMK_business_unit_msdyn_templateforproperties)
- [business_unit_msdyn_templateparameter](#BKMK_business_unit_msdyn_templateparameter)
- [business_unit_msdyn_templateruleset](#BKMK_business_unit_msdyn_templateruleset)
- [business_unit_msdyn_timespent](#BKMK_business_unit_msdyn_timespent)
- [business_unit_msdyn_timetracker](#BKMK_business_unit_msdyn_timetracker)
- [business_unit_msdyn_trainingresult](#BKMK_business_unit_msdyn_trainingresult)
- [business_unit_msdyn_transcript](#BKMK_business_unit_msdyn_transcript)
- [business_unit_msdyn_unifiedroutingdiagnostic](#BKMK_business_unit_msdyn_unifiedroutingdiagnostic)
- [business_unit_msdyn_unifiedroutingrun](#BKMK_business_unit_msdyn_unifiedroutingrun)
- [business_unit_msdyn_untrackedappointment](#BKMK_business_unit_msdyn_untrackedappointment)
- [business_unit_msdyn_urnotificationtemplate](#BKMK_business_unit_msdyn_urnotificationtemplate)
- [business_unit_msdyn_urnotificationtemplatemapping](#BKMK_business_unit_msdyn_urnotificationtemplatemapping)
- [business_unit_msdyn_visitorjourney](#BKMK_business_unit_msdyn_visitorjourney)
- [business_unit_msdyn_vivacustomerlist](#BKMK_business_unit_msdyn_vivacustomerlist)
- [business_unit_msdyn_wallsavedqueryusersettings](#BKMK_business_unit_msdyn_wallsavedqueryusersettings)
- [business_unit_msdyn_warranty](#BKMK_business_unit_msdyn_warranty)
- [business_unit_msdyn_wkwconfig](#BKMK_business_unit_msdyn_wkwconfig)
- [business_unit_msdyn_workqueuestate](#BKMK_business_unit_msdyn_workqueuestate)
- [business_unit_msdyn_workqueueusersetting](#BKMK_business_unit_msdyn_workqueueusersetting)
- [business_unit_msdyncrm_addtocalendarstyle](#BKMK_business_unit_msdyncrm_addtocalendarstyle)
- [business_unit_msdyncrm_basestyle](#BKMK_business_unit_msdyncrm_basestyle)
- [business_unit_msdyncrm_buttonstyle](#BKMK_business_unit_msdyncrm_buttonstyle)
- [business_unit_msdyncrm_codestyle](#BKMK_business_unit_msdyncrm_codestyle)
- [business_unit_msdyncrm_columnstyle](#BKMK_business_unit_msdyncrm_columnstyle)
- [business_unit_msdyncrm_contentblockstyle](#BKMK_business_unit_msdyncrm_contentblockstyle)
- [business_unit_msdyncrm_dividerstyle](#BKMK_business_unit_msdyncrm_dividerstyle)
- [business_unit_msdyncrm_generalstyles](#BKMK_business_unit_msdyncrm_generalstyles)
- [business_unit_msdyncrm_imagestyle](#BKMK_business_unit_msdyncrm_imagestyle)
- [business_unit_msdyncrm_layoutstyle](#BKMK_business_unit_msdyncrm_layoutstyle)
- [business_unit_msdyncrm_qrcodestyle](#BKMK_business_unit_msdyncrm_qrcodestyle)
- [business_unit_msdyncrm_textstyle](#BKMK_business_unit_msdyncrm_textstyle)
- [business_unit_msdyncrm_videostyle](#BKMK_business_unit_msdyncrm_videostyle)
- [business_unit_msdynmkt_byoacschannelinstance](#BKMK_business_unit_msdynmkt_byoacschannelinstance)
- [business_unit_msdynmkt_byoacschannelinstanceaccount](#BKMK_business_unit_msdynmkt_byoacschannelinstanceaccount)
- [business_unit_msdynmkt_catalogeventstatusconfiguration](#BKMK_business_unit_msdynmkt_catalogeventstatusconfiguration)
- [business_unit_msdynmkt_configuration](#BKMK_business_unit_msdynmkt_configuration)
- [business_unit_msdynmkt_eventmetadata](#BKMK_business_unit_msdynmkt_eventmetadata)
- [business_unit_msdynmkt_eventparametermetadata](#BKMK_business_unit_msdynmkt_eventparametermetadata)
- [business_unit_msdynmkt_featureconfiguration](#BKMK_business_unit_msdynmkt_featureconfiguration)
- [business_unit_msdynmkt_infobipchannelinstance](#BKMK_business_unit_msdynmkt_infobipchannelinstance)
- [business_unit_msdynmkt_infobipchannelinstanceaccount](#BKMK_business_unit_msdynmkt_infobipchannelinstanceaccount)
- [business_unit_msdynmkt_linkmobilitychannelinstance](#BKMK_business_unit_msdynmkt_linkmobilitychannelinstance)
- [business_unit_msdynmkt_linkmobilitychannelinstanceaccount](#BKMK_business_unit_msdynmkt_linkmobilitychannelinstanceaccount)
- [business_unit_msdynmkt_metadataentityrelationship](#BKMK_business_unit_msdynmkt_metadataentityrelationship)
- [business_unit_msdynmkt_metadataitem](#BKMK_business_unit_msdynmkt_metadataitem)
- [business_unit_msdynmkt_metadatastorestate](#BKMK_business_unit_msdynmkt_metadatastorestate)
- [business_unit_msdynmkt_mocksmsproviderchannelinstance](#BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstance)
- [business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [business_unit_msdynmkt_predefinedplaceholder](#BKMK_business_unit_msdynmkt_predefinedplaceholder)
- [business_unit_msdynmkt_telesignchannelinstance](#BKMK_business_unit_msdynmkt_telesignchannelinstance)
- [business_unit_msdynmkt_telesignchannelinstanceaccount](#BKMK_business_unit_msdynmkt_telesignchannelinstanceaccount)
- [business_unit_msdynmkt_twiliochannelinstance](#BKMK_business_unit_msdynmkt_twiliochannelinstance)
- [business_unit_msdynmkt_twiliochannelinstanceaccount](#BKMK_business_unit_msdynmkt_twiliochannelinstanceaccount)
- [business_unit_msdynmkt_vibeschannelinstance](#BKMK_business_unit_msdynmkt_vibeschannelinstance)
- [business_unit_msdynmkt_vibeschannelinstanceaccount](#BKMK_business_unit_msdynmkt_vibeschannelinstanceaccount)
- [business_unit_msfp_alertrule](#BKMK_business_unit_msfp_alertrule)
- [business_unit_msfp_emailtemplate](#BKMK_business_unit_msfp_emailtemplate)
- [business_unit_msfp_fileresponse](#BKMK_business_unit_msfp_fileresponse)
- [business_unit_msfp_localizedemailtemplate](#BKMK_business_unit_msfp_localizedemailtemplate)
- [business_unit_msfp_project](#BKMK_business_unit_msfp_project)
- [business_unit_msfp_question](#BKMK_business_unit_msfp_question)
- [business_unit_msfp_questionresponse](#BKMK_business_unit_msfp_questionresponse)
- [business_unit_msfp_satisfactionmetric](#BKMK_business_unit_msfp_satisfactionmetric)
- [business_unit_msfp_survey](#BKMK_business_unit_msfp_survey)
- [business_unit_msfp_surveyreminder](#BKMK_business_unit_msfp_surveyreminder)
- [business_unit_msfp_unsubscribedrecipient](#BKMK_business_unit_msfp_unsubscribedrecipient)
- [business_unit_opportunities](#BKMK_business_unit_opportunities)
- [business_unit_opportunity_close_activities](#BKMK_business_unit_opportunity_close_activities)
- [business_unit_order_close_activities](#BKMK_business_unit_order_close_activities)
- [business_unit_orders](#BKMK_business_unit_orders)
- [business_unit_quote_close_activities](#BKMK_business_unit_quote_close_activities)
- [business_unit_quotes](#BKMK_business_unit_quotes)
- [business_unit_ratingmodel](#BKMK_business_unit_ratingmodel)
- [business_unit_ratingvalue](#BKMK_business_unit_ratingvalue)
- [business_unit_resource_groups](#BKMK_business_unit_resource_groups)
- [business_unit_resource_specs](#BKMK_business_unit_resource_specs)
- [business_unit_resources](#BKMK_business_unit_resources)
- [business_unit_service_appointments](#BKMK_business_unit_service_appointments)
- [business_unit_service_contracts](#BKMK_business_unit_service_contracts)
- [BusinessUnit_Campaigns](#BKMK_BusinessUnit_Campaigns)
- [msdyn_copilottranscript_businessunit_owningbusinessunit](#BKMK_msdyn_copilottranscript_businessunit_owningbusinessunit)
- [msdyn_ocliveworkitem_businessunit_owningbusinessunit](#BKMK_msdyn_ocliveworkitem_businessunit_owningbusinessunit)
- [msdyn_ocsession_businessunit_owningbusinessunit](#BKMK_msdyn_ocsession_businessunit_owningbusinessunit)
- [msfp_alert_businessunit_owningbusinessunit](#BKMK_msfp_alert_businessunit_owningbusinessunit)
- [msfp_surveyinvite_businessunit_owningbusinessunit](#BKMK_msfp_surveyinvite_businessunit_owningbusinessunit)
- [msfp_surveyresponse_businessunit_owningbusinessunit](#BKMK_msfp_surveyresponse_businessunit_owningbusinessunit)

### <a name="BKMK_business_unit_activitymonitor"></a> business_unit_activitymonitor

Many-To-One Relationship: [activitymonitor business_unit_activitymonitor](activitymonitor.md#BKMK_business_unit_activitymonitor)

|Property|Value|
|---|---|
|ReferencingEntity|`activitymonitor`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_activitymonitor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_adminsettingsentity"></a> business_unit_adminsettingsentity

Many-To-One Relationship: [adminsettingsentity business_unit_adminsettingsentity](adminsettingsentity.md#BKMK_business_unit_adminsettingsentity)

|Property|Value|
|---|---|
|ReferencingEntity|`adminsettingsentity`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_adminsettingsentity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_bookableresource"></a> business_unit_bookableresource

Many-To-One Relationship: [bookableresource business_unit_bookableresource](bookableresource.md#BKMK_business_unit_bookableresource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_bookableresource`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_bookableresourcebooking"></a> business_unit_bookableresourcebooking

Many-To-One Relationship: [bookableresourcebooking business_unit_bookableresourcebooking](bookableresourcebooking.md#BKMK_business_unit_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_bookableresourcebooking`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_bookableresourcebookingheader"></a> business_unit_bookableresourcebookingheader

Many-To-One Relationship: [bookableresourcebookingheader business_unit_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_business_unit_bookableresourcebookingheader)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebookingheader`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_bookableresourcebookingheader`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_bookableresourcecategory"></a> business_unit_bookableresourcecategory

Many-To-One Relationship: [bookableresourcecategory business_unit_bookableresourcecategory](bookableresourcecategory.md#BKMK_business_unit_bookableresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_bookableresourcecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_bookableresourcecategoryassn"></a> business_unit_bookableresourcecategoryassn

Many-To-One Relationship: [bookableresourcecategoryassn business_unit_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_business_unit_bookableresourcecategoryassn)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategoryassn`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_bookableresourcecategoryassn`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_bookableresourcecharacteristic"></a> business_unit_bookableresourcecharacteristic

Many-To-One Relationship: [bookableresourcecharacteristic business_unit_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_business_unit_bookableresourcecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecharacteristic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_bookableresourcecharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_bookableresourcegroup"></a> business_unit_bookableresourcegroup

Many-To-One Relationship: [bookableresourcegroup business_unit_bookableresourcegroup](bookableresourcegroup.md#BKMK_business_unit_bookableresourcegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcegroup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_bookableresourcegroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_bookingstatus"></a> business_unit_bookingstatus

Many-To-One Relationship: [bookingstatus business_unit_bookingstatus](bookingstatus.md#BKMK_business_unit_bookingstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`bookingstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_bookingstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_BulkOperation_activities"></a> business_unit_BulkOperation_activities

Many-To-One Relationship: [bulkoperation business_unit_BulkOperation_activities](bulkoperation.md#BKMK_business_unit_BulkOperation_activities)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_BulkOperation_activities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_campaignactivity_activities"></a> business_unit_campaignactivity_activities

Many-To-One Relationship: [campaignactivity business_unit_campaignactivity_activities](campaignactivity.md#BKMK_business_unit_campaignactivity_activities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_campaignactivity_activities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_campaignresponse_activities"></a> business_unit_campaignresponse_activities

Many-To-One Relationship: [campaignresponse business_unit_campaignresponse_activities](campaignresponse.md#BKMK_business_unit_campaignresponse_activities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_campaignresponse_activities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_characteristic"></a> business_unit_characteristic

Many-To-One Relationship: [characteristic business_unit_characteristic](characteristic.md#BKMK_business_unit_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`characteristic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_characteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_constraint_based_groups"></a> business_unit_constraint_based_groups

Many-To-One Relationship: [constraintbasedgroup business_unit_constraint_based_groups](constraintbasedgroup.md#BKMK_business_unit_constraint_based_groups)

|Property|Value|
|---|---|
|ReferencingEntity|`constraintbasedgroup`|
|ReferencingAttribute|`businessunitid`|
|ReferencedEntityNavigationPropertyName|`business_unit_constraint_based_groups`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_dynamicproperyinstance"></a> business_unit_dynamicproperyinstance

Many-To-One Relationship: [dynamicpropertyinstance business_unit_dynamicproperyinstance](dynamicpropertyinstance.md#BKMK_business_unit_dynamicproperyinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_dynamicproperyinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_entitlement"></a> business_unit_entitlement

Many-To-One Relationship: [entitlement business_unit_entitlement](entitlement.md#BKMK_business_unit_entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_entitlement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_entitlemententityallocationtypemapping"></a> business_unit_entitlemententityallocationtypemapping

Many-To-One Relationship: [entitlemententityallocationtypemapping business_unit_entitlemententityallocationtypemapping](entitlemententityallocationtypemapping.md#BKMK_business_unit_entitlemententityallocationtypemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlemententityallocationtypemapping`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_entitlemententityallocationtypemapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_equipment"></a> business_unit_equipment

Many-To-One Relationship: [equipment business_unit_equipment](equipment.md#BKMK_business_unit_equipment)

|Property|Value|
|---|---|
|ReferencingEntity|`equipment`|
|ReferencingAttribute|`businessunitid`|
|ReferencedEntityNavigationPropertyName|`business_unit_equipment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_incident_resolution_activities"></a> business_unit_incident_resolution_activities

Many-To-One Relationship: [incidentresolution business_unit_incident_resolution_activities](incidentresolution.md#BKMK_business_unit_incident_resolution_activities)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_incident_resolution_activities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_incidents"></a> business_unit_incidents

Many-To-One Relationship: [incident business_unit_incidents](incident.md#BKMK_business_unit_incidents)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_incidents`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_invoices"></a> business_unit_invoices

Many-To-One Relationship: [invoice business_unit_invoices](invoice.md#BKMK_business_unit_invoices)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_invoices`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_leads"></a> business_unit_leads

Many-To-One Relationship: [lead business_unit_leads](lead.md#BKMK_business_unit_leads)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_leads`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_list"></a> business_unit_list

Many-To-One Relationship: [list business_unit_list](list.md#BKMK_business_unit_list)

|Property|Value|
|---|---|
|ReferencingEntity|`list`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_list`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_listoperation"></a> business_unit_listoperation

Many-To-One Relationship: [listoperation business_unit_listoperation](listoperation.md#BKMK_business_unit_listoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`listoperation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_listoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_actioncardactionstat"></a> business_unit_msdyn_actioncardactionstat

Many-To-One Relationship: [msdyn_actioncardactionstat business_unit_msdyn_actioncardactionstat](msdyn_actioncardactionstat.md#BKMK_business_unit_msdyn_actioncardactionstat)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardactionstat`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_actioncardactionstat`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_actioncardregarding"></a> business_unit_msdyn_actioncardregarding

Many-To-One Relationship: [msdyn_actioncardregarding business_unit_msdyn_actioncardregarding](msdyn_actioncardregarding.md#BKMK_business_unit_msdyn_actioncardregarding)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardregarding`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_actioncardregarding`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_actioncardrolesetting"></a> business_unit_msdyn_actioncardrolesetting

Many-To-One Relationship: [msdyn_actioncardrolesetting business_unit_msdyn_actioncardrolesetting](msdyn_actioncardrolesetting.md#BKMK_business_unit_msdyn_actioncardrolesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardrolesetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_actioncardrolesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_actioncardstataggregation"></a> business_unit_msdyn_actioncardstataggregation

Many-To-One Relationship: [msdyn_actioncardstataggregation business_unit_msdyn_actioncardstataggregation](msdyn_actioncardstataggregation.md#BKMK_business_unit_msdyn_actioncardstataggregation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actioncardstataggregation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_actioncardstataggregation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_activeicdextension"></a> business_unit_msdyn_activeicdextension

Many-To-One Relationship: [msdyn_activeicdextension business_unit_msdyn_activeicdextension](msdyn_activeicdextension.md#BKMK_business_unit_msdyn_activeicdextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_activeicdextension`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_activeicdextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_adminappstate"></a> business_unit_msdyn_adminappstate

Many-To-One Relationship: [msdyn_adminappstate business_unit_msdyn_adminappstate](msdyn_adminappstate.md#BKMK_business_unit_msdyn_adminappstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_adminappstate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_adminappstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentcapacityprofileunit"></a> business_unit_msdyn_agentcapacityprofileunit

Many-To-One Relationship: [msdyn_agentcapacityprofileunit business_unit_msdyn_agentcapacityprofileunit](msdyn_agentcapacityprofileunit.md#BKMK_business_unit_msdyn_agentcapacityprofileunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentcapacityprofileunit`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentcapacityprofileunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentcapacityupdatehistory"></a> business_unit_msdyn_agentcapacityupdatehistory

Many-To-One Relationship: [msdyn_agentcapacityupdatehistory business_unit_msdyn_agentcapacityupdatehistory](msdyn_agentcapacityupdatehistory.md#BKMK_business_unit_msdyn_agentcapacityupdatehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentcapacityupdatehistory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentcapacityupdatehistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentchannelstate"></a> business_unit_msdyn_agentchannelstate

Many-To-One Relationship: [msdyn_agentchannelstate business_unit_msdyn_agentchannelstate](msdyn_agentchannelstate.md#BKMK_business_unit_msdyn_agentchannelstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentchannelstate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentchannelstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentgroup"></a> business_unit_msdyn_agentgroup

Many-To-One Relationship: [msdyn_agentgroup business_unit_msdyn_agentgroup](msdyn_agentgroup.md#BKMK_business_unit_msdyn_agentgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroup`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentgrouplanguage"></a> business_unit_msdyn_agentgrouplanguage

Many-To-One Relationship: [msdyn_agentgrouplanguage business_unit_msdyn_agentgrouplanguage](msdyn_agentgrouplanguage.md#BKMK_business_unit_msdyn_agentgrouplanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgrouplanguage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentgrouplanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentgroupmembership"></a> business_unit_msdyn_agentgroupmembership

Many-To-One Relationship: [msdyn_agentgroupmembership business_unit_msdyn_agentgroupmembership](msdyn_agentgroupmembership.md#BKMK_business_unit_msdyn_agentgroupmembership)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroupmembership`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentgroupmembership`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentgroupregion"></a> business_unit_msdyn_agentgroupregion

Many-To-One Relationship: [msdyn_agentgroupregion business_unit_msdyn_agentgroupregion](msdyn_agentgroupregion.md#BKMK_business_unit_msdyn_agentgroupregion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroupregion`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentgroupregion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentlanguage"></a> business_unit_msdyn_agentlanguage

Many-To-One Relationship: [msdyn_agentlanguage business_unit_msdyn_agentlanguage](msdyn_agentlanguage.md#BKMK_business_unit_msdyn_agentlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentlanguage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentlanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentregion"></a> business_unit_msdyn_agentregion

Many-To-One Relationship: [msdyn_agentregion business_unit_msdyn_agentregion](msdyn_agentregion.md#BKMK_business_unit_msdyn_agentregion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentregion`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentregion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentstatus"></a> business_unit_msdyn_agentstatus

Many-To-One Relationship: [msdyn_agentstatus business_unit_msdyn_agentstatus](msdyn_agentstatus.md#BKMK_business_unit_msdyn_agentstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_agentstatushistory"></a> business_unit_msdyn_agentstatushistory

Many-To-One Relationship: [msdyn_agentstatushistory business_unit_msdyn_agentstatushistory](msdyn_agentstatushistory.md#BKMK_business_unit_msdyn_agentstatushistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentstatushistory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_agentstatushistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_aicontactsuggestion"></a> business_unit_msdyn_aicontactsuggestion

Many-To-One Relationship: [msdyn_aicontactsuggestion business_unit_msdyn_aicontactsuggestion](msdyn_aicontactsuggestion.md#BKMK_business_unit_msdyn_aicontactsuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aicontactsuggestion`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_aicontactsuggestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_analytics"></a> business_unit_msdyn_analytics

Many-To-One Relationship: [msdyn_analytics business_unit_msdyn_analytics](msdyn_analytics.md#BKMK_business_unit_msdyn_analytics)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_analytics`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_analytics`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_appconfiguration"></a> business_unit_msdyn_appconfiguration

Many-To-One Relationship: [msdyn_appconfiguration business_unit_msdyn_appconfiguration](msdyn_appconfiguration.md#BKMK_business_unit_msdyn_appconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_appconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_applicationextension"></a> business_unit_msdyn_applicationextension

Many-To-One Relationship: [msdyn_applicationextension business_unit_msdyn_applicationextension](msdyn_applicationextension.md#BKMK_business_unit_msdyn_applicationextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_applicationextension`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_applicationextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_applicationtabtemplate"></a> business_unit_msdyn_applicationtabtemplate

Many-To-One Relationship: [msdyn_applicationtabtemplate business_unit_msdyn_applicationtabtemplate](msdyn_applicationtabtemplate.md#BKMK_business_unit_msdyn_applicationtabtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_applicationtabtemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_applicationtabtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_appprofilerolemapping"></a> business_unit_msdyn_appprofilerolemapping

Many-To-One Relationship: [msdyn_appprofilerolemapping business_unit_msdyn_appprofilerolemapping](msdyn_appprofilerolemapping.md#BKMK_business_unit_msdyn_appprofilerolemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appprofilerolemapping`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_appprofilerolemapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_appstate"></a> business_unit_msdyn_appstate

Many-To-One Relationship: [msdyn_appstate business_unit_msdyn_appstate](msdyn_appstate.md#BKMK_business_unit_msdyn_appstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_appstate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_appstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_assetcategorytemplateassociation"></a> business_unit_msdyn_assetcategorytemplateassociation

Many-To-One Relationship: [msdyn_assetcategorytemplateassociation business_unit_msdyn_assetcategorytemplateassociation](msdyn_assetcategorytemplateassociation.md#BKMK_business_unit_msdyn_assetcategorytemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assetcategorytemplateassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_assetcategorytemplateassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_assettemplateassociation"></a> business_unit_msdyn_assettemplateassociation

Many-To-One Relationship: [msdyn_assettemplateassociation business_unit_msdyn_assettemplateassociation](msdyn_assettemplateassociation.md#BKMK_business_unit_msdyn_assettemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assettemplateassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_assettemplateassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_assignmentconfiguration"></a> business_unit_msdyn_assignmentconfiguration

Many-To-One Relationship: [msdyn_assignmentconfiguration business_unit_msdyn_assignmentconfiguration](msdyn_assignmentconfiguration.md#BKMK_business_unit_msdyn_assignmentconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_assignmentconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_assignmentconfigurationstep"></a> business_unit_msdyn_assignmentconfigurationstep

Many-To-One Relationship: [msdyn_assignmentconfigurationstep business_unit_msdyn_assignmentconfigurationstep](msdyn_assignmentconfigurationstep.md#BKMK_business_unit_msdyn_assignmentconfigurationstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentconfigurationstep`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_assignmentconfigurationstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_assignmentmap"></a> business_unit_msdyn_assignmentmap

Many-To-One Relationship: [msdyn_assignmentmap business_unit_msdyn_assignmentmap](msdyn_assignmentmap.md#BKMK_business_unit_msdyn_assignmentmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentmap`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_assignmentmap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_assignmentrule"></a> business_unit_msdyn_assignmentrule

Many-To-One Relationship: [msdyn_assignmentrule business_unit_msdyn_assignmentrule](msdyn_assignmentrule.md#BKMK_business_unit_msdyn_assignmentrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assignmentrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_assignmentrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_attribute"></a> business_unit_msdyn_attribute

Many-To-One Relationship: [msdyn_attribute business_unit_msdyn_attribute](msdyn_attribute.md#BKMK_business_unit_msdyn_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_attribute`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_attribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_attributevalue"></a> business_unit_msdyn_attributevalue

Many-To-One Relationship: [msdyn_attributevalue business_unit_msdyn_attributevalue](msdyn_attributevalue.md#BKMK_business_unit_msdyn_attributevalue)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_attributevalue`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_attributevalue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_authenticationsettings"></a> business_unit_msdyn_authenticationsettings

Many-To-One Relationship: [msdyn_authenticationsettings business_unit_msdyn_authenticationsettings](msdyn_authenticationsettings.md#BKMK_business_unit_msdyn_authenticationsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_authenticationsettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_authenticationsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_authsettingsentry"></a> business_unit_msdyn_authsettingsentry

Many-To-One Relationship: [msdyn_authsettingsentry business_unit_msdyn_authsettingsentry](msdyn_authsettingsentry.md#BKMK_business_unit_msdyn_authsettingsentry)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_authsettingsentry`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_authsettingsentry`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_autocapturerule"></a> business_unit_msdyn_autocapturerule

Many-To-One Relationship: [msdyn_autocapturerule business_unit_msdyn_autocapturerule](msdyn_autocapturerule.md#BKMK_business_unit_msdyn_autocapturerule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autocapturerule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_autocapturerule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_autocapturesettings"></a> business_unit_msdyn_autocapturesettings

Many-To-One Relationship: [msdyn_autocapturesettings business_unit_msdyn_autocapturesettings](msdyn_autocapturesettings.md#BKMK_business_unit_msdyn_autocapturesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autocapturesettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_autocapturesettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_autonomouscasecreationrule"></a> business_unit_msdyn_autonomouscasecreationrule

Many-To-One Relationship: [msdyn_autonomouscasecreationrule business_unit_msdyn_autonomouscasecreationrule](msdyn_autonomouscasecreationrule.md#BKMK_business_unit_msdyn_autonomouscasecreationrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_autonomouscasecreationrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_autonomouscasecreationrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_bookableresourcecapacityprofile"></a> business_unit_msdyn_bookableresourcecapacityprofile

Many-To-One Relationship: [msdyn_bookableresourcecapacityprofile business_unit_msdyn_bookableresourcecapacityprofile](msdyn_bookableresourcecapacityprofile.md#BKMK_business_unit_msdyn_bookableresourcecapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcecapacityprofile`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_bookableresourcecapacityprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_botsession"></a> business_unit_msdyn_botsession

Many-To-One Relationship: [msdyn_botsession business_unit_msdyn_botsession](msdyn_botsession.md#BKMK_business_unit_msdyn_botsession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_botsession`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_botsession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_capacityprofile"></a> business_unit_msdyn_capacityprofile

Many-To-One Relationship: [msdyn_capacityprofile business_unit_msdyn_capacityprofile](msdyn_capacityprofile.md#BKMK_business_unit_msdyn_capacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_capacityprofile`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_capacityprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_cdsentityengagementctx"></a> business_unit_msdyn_cdsentityengagementctx

Many-To-One Relationship: [msdyn_cdsentityengagementctx business_unit_msdyn_cdsentityengagementctx](msdyn_cdsentityengagementctx.md#BKMK_business_unit_msdyn_cdsentityengagementctx)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_cdsentityengagementctx`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_cdsentityengagementctx`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channeldefinition"></a> business_unit_msdyn_channeldefinition

Many-To-One Relationship: [msdyn_channeldefinition business_unit_msdyn_channeldefinition](msdyn_channeldefinition.md#BKMK_business_unit_msdyn_channeldefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channeldefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channeldefinitionconsent"></a> business_unit_msdyn_channeldefinitionconsent

Many-To-One Relationship: [msdyn_channeldefinitionconsent business_unit_msdyn_channeldefinitionconsent](msdyn_channeldefinitionconsent.md#BKMK_business_unit_msdyn_channeldefinitionconsent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinitionconsent`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channeldefinitionconsent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channeldefinitionlocale"></a> business_unit_msdyn_channeldefinitionlocale

Many-To-One Relationship: [msdyn_channeldefinitionlocale business_unit_msdyn_channeldefinitionlocale](msdyn_channeldefinitionlocale.md#BKMK_business_unit_msdyn_channeldefinitionlocale)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channeldefinitionlocale`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channeldefinitionlocale`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channelinstance"></a> business_unit_msdyn_channelinstance

Many-To-One Relationship: [msdyn_channelinstance business_unit_msdyn_channelinstance](msdyn_channelinstance.md#BKMK_business_unit_msdyn_channelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channelinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channelinstanceaccount"></a> business_unit_msdyn_channelinstanceaccount

Many-To-One Relationship: [msdyn_channelinstanceaccount business_unit_msdyn_channelinstanceaccount](msdyn_channelinstanceaccount.md#BKMK_business_unit_msdyn_channelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelinstanceaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channelinstanceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channelmessageattachment"></a> business_unit_msdyn_channelmessageattachment

Many-To-One Relationship: [msdyn_channelmessageattachment business_unit_msdyn_channelmessageattachment](msdyn_channelmessageattachment.md#BKMK_business_unit_msdyn_channelmessageattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessageattachment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channelmessageattachment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channelmessagecontextpart"></a> business_unit_msdyn_channelmessagecontextpart

Many-To-One Relationship: [msdyn_channelmessagecontextpart business_unit_msdyn_channelmessagecontextpart](msdyn_channelmessagecontextpart.md#BKMK_business_unit_msdyn_channelmessagecontextpart)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessagecontextpart`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channelmessagecontextpart`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channelmessagepart"></a> business_unit_msdyn_channelmessagepart

Many-To-One Relationship: [msdyn_channelmessagepart business_unit_msdyn_channelmessagepart](msdyn_channelmessagepart.md#BKMK_business_unit_msdyn_channelmessagepart)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelmessagepart`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channelmessagepart`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_channelprovider"></a> business_unit_msdyn_channelprovider

Many-To-One Relationship: [msdyn_channelprovider business_unit_msdyn_channelprovider](msdyn_channelprovider.md#BKMK_business_unit_msdyn_channelprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_channelprovider`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_channelprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_consumingapplication"></a> business_unit_msdyn_consumingapplication

Many-To-One Relationship: [msdyn_consumingapplication business_unit_msdyn_consumingapplication](msdyn_consumingapplication.md#BKMK_business_unit_msdyn_consumingapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_consumingapplication`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_consumingapplication`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_contactsuggestionrule"></a> business_unit_msdyn_contactsuggestionrule

Many-To-One Relationship: [msdyn_contactsuggestionrule business_unit_msdyn_contactsuggestionrule](msdyn_contactsuggestionrule.md#BKMK_business_unit_msdyn_contactsuggestionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactsuggestionrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_contactsuggestionrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_contactsuggestionruleset"></a> business_unit_msdyn_contactsuggestionruleset

Many-To-One Relationship: [msdyn_contactsuggestionruleset business_unit_msdyn_contactsuggestionruleset](msdyn_contactsuggestionruleset.md#BKMK_business_unit_msdyn_contactsuggestionruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactsuggestionruleset`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_contactsuggestionruleset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationaction"></a> business_unit_msdyn_conversationaction

Many-To-One Relationship: [msdyn_conversationaction business_unit_msdyn_conversationaction](msdyn_conversationaction.md#BKMK_business_unit_msdyn_conversationaction)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationaction`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationaction`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationactionitem"></a> business_unit_msdyn_conversationactionitem

Many-To-One Relationship: [msdyn_conversationactionitem business_unit_msdyn_conversationactionitem](msdyn_conversationactionitem.md#BKMK_business_unit_msdyn_conversationactionitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionitem`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationactionitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationactionlocale"></a> business_unit_msdyn_conversationactionlocale

Many-To-One Relationship: [msdyn_conversationactionlocale business_unit_msdyn_conversationactionlocale](msdyn_conversationactionlocale.md#BKMK_business_unit_msdyn_conversationactionlocale)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationactionlocale`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationactionlocale`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationaggregatedinsights"></a> business_unit_msdyn_conversationaggregatedinsights

Many-To-One Relationship: [msdyn_conversationaggregatedinsights business_unit_msdyn_conversationaggregatedinsights](msdyn_conversationaggregatedinsights.md#BKMK_business_unit_msdyn_conversationaggregatedinsights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationaggregatedinsights`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationaggregatedinsights`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationcomment"></a> business_unit_msdyn_conversationcomment

Many-To-One Relationship: [msdyn_conversationcomment business_unit_msdyn_conversationcomment](msdyn_conversationcomment.md#BKMK_business_unit_msdyn_conversationcomment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationcomment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationcomment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationinsight"></a> business_unit_msdyn_conversationinsight

Many-To-One Relationship: [msdyn_conversationinsight business_unit_msdyn_conversationinsight](msdyn_conversationinsight.md#BKMK_business_unit_msdyn_conversationinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationinsight`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationmessageblock"></a> business_unit_msdyn_conversationmessageblock

Many-To-One Relationship: [msdyn_conversationmessageblock business_unit_msdyn_conversationmessageblock](msdyn_conversationmessageblock.md#BKMK_business_unit_msdyn_conversationmessageblock)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationmessageblock`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationmessageblock`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationparticipantinsights"></a> business_unit_msdyn_conversationparticipantinsights

Many-To-One Relationship: [msdyn_conversationparticipantinsights business_unit_msdyn_conversationparticipantinsights](msdyn_conversationparticipantinsights.md#BKMK_business_unit_msdyn_conversationparticipantinsights)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantinsights`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationparticipantinsights`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationparticipantsentiment"></a> business_unit_msdyn_conversationparticipantsentiment

Many-To-One Relationship: [msdyn_conversationparticipantsentiment business_unit_msdyn_conversationparticipantsentiment](msdyn_conversationparticipantsentiment.md#BKMK_business_unit_msdyn_conversationparticipantsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantsentiment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationparticipantsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationquestion"></a> business_unit_msdyn_conversationquestion

Many-To-One Relationship: [msdyn_conversationquestion business_unit_msdyn_conversationquestion](msdyn_conversationquestion.md#BKMK_business_unit_msdyn_conversationquestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationquestion`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationquestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationsegmentsentiment"></a> business_unit_msdyn_conversationsegmentsentiment

Many-To-One Relationship: [msdyn_conversationsegmentsentiment business_unit_msdyn_conversationsegmentsentiment](msdyn_conversationsegmentsentiment.md#BKMK_business_unit_msdyn_conversationsegmentsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsegmentsentiment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationsegmentsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationsentiment"></a> business_unit_msdyn_conversationsentiment

Many-To-One Relationship: [msdyn_conversationsentiment business_unit_msdyn_conversationsentiment](msdyn_conversationsentiment.md#BKMK_business_unit_msdyn_conversationsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsentiment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationsignal"></a> business_unit_msdyn_conversationsignal

Many-To-One Relationship: [msdyn_conversationsignal business_unit_msdyn_conversationsignal](msdyn_conversationsignal.md#BKMK_business_unit_msdyn_conversationsignal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsignal`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationsignal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationsubject"></a> business_unit_msdyn_conversationsubject

Many-To-One Relationship: [msdyn_conversationsubject business_unit_msdyn_conversationsubject](msdyn_conversationsubject.md#BKMK_business_unit_msdyn_conversationsubject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsubject`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationsubject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationsummarysuggestion"></a> business_unit_msdyn_conversationsummarysuggestion

Many-To-One Relationship: [msdyn_conversationsummarysuggestion business_unit_msdyn_conversationsummarysuggestion](msdyn_conversationsummarysuggestion.md#BKMK_business_unit_msdyn_conversationsummarysuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsummarysuggestion`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationsummarysuggestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationsystemtag"></a> business_unit_msdyn_conversationsystemtag

Many-To-One Relationship: [msdyn_conversationsystemtag business_unit_msdyn_conversationsystemtag](msdyn_conversationsystemtag.md#BKMK_business_unit_msdyn_conversationsystemtag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationsystemtag`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationsystemtag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_conversationtag"></a> business_unit_msdyn_conversationtag

Many-To-One Relationship: [msdyn_conversationtag business_unit_msdyn_conversationtag](msdyn_conversationtag.md#BKMK_business_unit_msdyn_conversationtag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationtag`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_conversationtag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_copilotagentpreference"></a> business_unit_msdyn_copilotagentpreference

Many-To-One Relationship: [msdyn_copilotagentpreference business_unit_msdyn_copilotagentpreference](msdyn_copilotagentpreference.md#BKMK_business_unit_msdyn_copilotagentpreference)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotagentpreference`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_copilotagentpreference`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_copilotcaseformfillsetting"></a> business_unit_msdyn_copilotcaseformfillsetting

Many-To-One Relationship: [msdyn_copilotcaseformfillsetting business_unit_msdyn_copilotcaseformfillsetting](msdyn_copilotcaseformfillsetting.md#BKMK_business_unit_msdyn_copilotcaseformfillsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotcaseformfillsetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_copilotcaseformfillsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_copilotinteractiondata"></a> business_unit_msdyn_copilotinteractiondata

Many-To-One Relationship: [msdyn_copilotinteractiondata business_unit_msdyn_copilotinteractiondata](msdyn_copilotinteractiondata.md#BKMK_business_unit_msdyn_copilotinteractiondata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotinteractiondata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_copilotinteractiondata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_copilottranscriptdata"></a> business_unit_msdyn_copilottranscriptdata

Many-To-One Relationship: [msdyn_copilottranscriptdata business_unit_msdyn_copilottranscriptdata](msdyn_copilottranscriptdata.md#BKMK_business_unit_msdyn_copilottranscriptdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscriptdata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_copilottranscriptdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_crmconnection"></a> business_unit_msdyn_crmconnection

Many-To-One Relationship: [msdyn_crmconnection business_unit_msdyn_crmconnection](msdyn_crmconnection.md#BKMK_business_unit_msdyn_crmconnection)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_crmconnection`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_crmconnection`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_csadminconfig"></a> business_unit_msdyn_csadminconfig

Many-To-One Relationship: [msdyn_csadminconfig business_unit_msdyn_csadminconfig](msdyn_csadminconfig.md#BKMK_business_unit_msdyn_csadminconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_csadminconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_csadminconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_customapirulesetconfiguration"></a> business_unit_msdyn_customapirulesetconfiguration

Many-To-One Relationship: [msdyn_customapirulesetconfiguration business_unit_msdyn_customapirulesetconfiguration](msdyn_customapirulesetconfiguration.md#BKMK_business_unit_msdyn_customapirulesetconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customapirulesetconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_customapirulesetconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_customerasset"></a> business_unit_msdyn_customerasset

Many-To-One Relationship: [msdyn_customerasset business_unit_msdyn_customerasset](msdyn_customerasset.md#BKMK_business_unit_msdyn_customerasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_customerasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_customerassetattachment"></a> business_unit_msdyn_customerassetattachment

Many-To-One Relationship: [msdyn_customerassetattachment business_unit_msdyn_customerassetattachment](msdyn_customerassetattachment.md#BKMK_business_unit_msdyn_customerassetattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerassetattachment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_customerassetattachment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_customerassetcategory"></a> business_unit_msdyn_customerassetcategory

Many-To-One Relationship: [msdyn_customerassetcategory business_unit_msdyn_customerassetcategory](msdyn_customerassetcategory.md#BKMK_business_unit_msdyn_customerassetcategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerassetcategory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_customerassetcategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_dataanalyticscustomizedreport"></a> business_unit_msdyn_dataanalyticscustomizedreport

Many-To-One Relationship: [msdyn_dataanalyticscustomizedreport business_unit_msdyn_dataanalyticscustomizedreport](msdyn_dataanalyticscustomizedreport.md#BKMK_business_unit_msdyn_dataanalyticscustomizedreport)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticscustomizedreport`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_dataanalyticscustomizedreport`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_dataanalyticsdataset"></a> business_unit_msdyn_dataanalyticsdataset

Many-To-One Relationship: [msdyn_dataanalyticsdataset business_unit_msdyn_dataanalyticsdataset](msdyn_dataanalyticsdataset.md#BKMK_business_unit_msdyn_dataanalyticsdataset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsdataset`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_dataanalyticsdataset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_dataanalyticsreport"></a> business_unit_msdyn_dataanalyticsreport

Many-To-One Relationship: [msdyn_dataanalyticsreport business_unit_msdyn_dataanalyticsreport](msdyn_dataanalyticsreport.md#BKMK_business_unit_msdyn_dataanalyticsreport)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsreport`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_dataanalyticsreport`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_dataanalyticsworkspace"></a> business_unit_msdyn_dataanalyticsworkspace

Many-To-One Relationship: [msdyn_dataanalyticsworkspace business_unit_msdyn_dataanalyticsworkspace](msdyn_dataanalyticsworkspace.md#BKMK_business_unit_msdyn_dataanalyticsworkspace)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dataanalyticsworkspace`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_dataanalyticsworkspace`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_dealmanageraccess"></a> business_unit_msdyn_dealmanageraccess

Many-To-One Relationship: [msdyn_dealmanageraccess business_unit_msdyn_dealmanageraccess](msdyn_dealmanageraccess.md#BKMK_business_unit_msdyn_dealmanageraccess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dealmanageraccess`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_dealmanageraccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_dealmanagersettings"></a> business_unit_msdyn_dealmanagersettings

Many-To-One Relationship: [msdyn_dealmanagersettings business_unit_msdyn_dealmanagersettings](msdyn_dealmanagersettings.md#BKMK_business_unit_msdyn_dealmanagersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dealmanagersettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_dealmanagersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_decisioncontract"></a> business_unit_msdyn_decisioncontract

Many-To-One Relationship: [msdyn_decisioncontract business_unit_msdyn_decisioncontract](msdyn_decisioncontract.md#BKMK_business_unit_msdyn_decisioncontract)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_decisioncontract`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_decisioncontract`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_decisionruleset"></a> business_unit_msdyn_decisionruleset

Many-To-One Relationship: [msdyn_decisionruleset business_unit_msdyn_decisionruleset](msdyn_decisionruleset.md#BKMK_business_unit_msdyn_decisionruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_decisionruleset`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_decisionruleset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_deletedconversation"></a> business_unit_msdyn_deletedconversation

Many-To-One Relationship: [msdyn_deletedconversation business_unit_msdyn_deletedconversation](msdyn_deletedconversation.md#BKMK_business_unit_msdyn_deletedconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_deletedconversation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_deletedconversation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_duplicateleadmapping"></a> business_unit_msdyn_duplicateleadmapping

Many-To-One Relationship: [msdyn_duplicateleadmapping business_unit_msdyn_duplicateleadmapping](msdyn_duplicateleadmapping.md#BKMK_business_unit_msdyn_duplicateleadmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_duplicateleadmapping`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_duplicateleadmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_effortpredictionresult"></a> business_unit_msdyn_effortpredictionresult

Many-To-One Relationship: [msdyn_effortpredictionresult business_unit_msdyn_effortpredictionresult](msdyn_effortpredictionresult.md#BKMK_business_unit_msdyn_effortpredictionresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_effortpredictionresult`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_effortpredictionresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_emailsentiment"></a> business_unit_msdyn_emailsentiment

Many-To-One Relationship: [msdyn_emailsentiment business_unit_msdyn_emailsentiment](msdyn_emailsentiment.md#BKMK_business_unit_msdyn_emailsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_emailsentiment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_emailsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_entityattachment"></a> business_unit_msdyn_entityattachment

Many-To-One Relationship: [msdyn_entityattachment business_unit_msdyn_entityattachment](msdyn_entityattachment.md#BKMK_business_unit_msdyn_entityattachment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityattachment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_entityattachment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_entityattributepredictionrule"></a> business_unit_msdyn_entityattributepredictionrule

Many-To-One Relationship: [msdyn_entityattributepredictionrule business_unit_msdyn_entityattributepredictionrule](msdyn_entityattributepredictionrule.md#BKMK_business_unit_msdyn_entityattributepredictionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityattributepredictionrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_entityattributepredictionrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_entityrankingrule"></a> business_unit_msdyn_entityrankingrule

Many-To-One Relationship: [msdyn_entityrankingrule business_unit_msdyn_entityrankingrule](msdyn_entityrankingrule.md#BKMK_business_unit_msdyn_entityrankingrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityrankingrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_entityrankingrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_entityroutingconfiguration"></a> business_unit_msdyn_entityroutingconfiguration

Many-To-One Relationship: [msdyn_entityroutingconfiguration business_unit_msdyn_entityroutingconfiguration](msdyn_entityroutingconfiguration.md#BKMK_business_unit_msdyn_entityroutingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityroutingconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_entityroutingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_entityworkstreammap"></a> business_unit_msdyn_entityworkstreammap

Many-To-One Relationship: [msdyn_entityworkstreammap business_unit_msdyn_entityworkstreammap](msdyn_entityworkstreammap.md#BKMK_business_unit_msdyn_entityworkstreammap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityworkstreammap`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_entityworkstreammap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_extendedusersetting"></a> business_unit_msdyn_extendedusersetting

Many-To-One Relationship: [msdyn_extendedusersetting business_unit_msdyn_extendedusersetting](msdyn_extendedusersetting.md#BKMK_business_unit_msdyn_extendedusersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_extendedusersetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_extendedusersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_externalcrm"></a> business_unit_msdyn_externalcrm

Many-To-One Relationship: [msdyn_externalcrm business_unit_msdyn_externalcrm](msdyn_externalcrm.md#BKMK_business_unit_msdyn_externalcrm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_externalcrm`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_externalcrm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_externalrecord"></a> business_unit_msdyn_externalrecord

Many-To-One Relationship: [msdyn_externalrecord business_unit_msdyn_externalrecord](msdyn_externalrecord.md#BKMK_business_unit_msdyn_externalrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_externalrecord`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_externalrecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_flowcardtype"></a> business_unit_msdyn_flowcardtype

Many-To-One Relationship: [msdyn_flowcardtype business_unit_msdyn_flowcardtype](msdyn_flowcardtype.md#BKMK_business_unit_msdyn_flowcardtype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_flowcardtype`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_flowcardtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_forecastconfiguration"></a> business_unit_msdyn_forecastconfiguration

Many-To-One Relationship: [msdyn_forecastconfiguration business_unit_msdyn_forecastconfiguration](msdyn_forecastconfiguration.md#BKMK_business_unit_msdyn_forecastconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_forecastconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_forecastdefinition"></a> business_unit_msdyn_forecastdefinition

Many-To-One Relationship: [msdyn_forecastdefinition business_unit_msdyn_forecastdefinition](msdyn_forecastdefinition.md#BKMK_business_unit_msdyn_forecastdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastdefinition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_forecastdefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_forecastinstance"></a> business_unit_msdyn_forecastinstance

Many-To-One Relationship: [msdyn_forecastinstance business_unit_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_business_unit_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_forecastinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_forecastrecurrence"></a> business_unit_msdyn_forecastrecurrence

Many-To-One Relationship: [msdyn_forecastrecurrence business_unit_msdyn_forecastrecurrence](msdyn_forecastrecurrence.md#BKMK_business_unit_msdyn_forecastrecurrence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastrecurrence`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_forecastrecurrence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_functionallocation"></a> business_unit_msdyn_functionallocation

Many-To-One Relationship: [msdyn_functionallocation business_unit_msdyn_functionallocation](msdyn_functionallocation.md#BKMK_business_unit_msdyn_functionallocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_functionallocation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_functionallocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_functionallocationtype"></a> business_unit_msdyn_functionallocationtype

Many-To-One Relationship: [msdyn_functionallocationtype business_unit_msdyn_functionallocationtype](msdyn_functionallocationtype.md#BKMK_business_unit_msdyn_functionallocationtype)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_functionallocationtype`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_functionallocationtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_gdprdata"></a> business_unit_msdyn_gdprdata

Many-To-One Relationship: [msdyn_gdprdata business_unit_msdyn_gdprdata](msdyn_gdprdata.md#BKMK_business_unit_msdyn_gdprdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_gdprdata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_gdprdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_icdextension"></a> business_unit_msdyn_icdextension

Many-To-One Relationship: [msdyn_icdextension business_unit_msdyn_icdextension](msdyn_icdextension.md#BKMK_business_unit_msdyn_icdextension)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_icdextension`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_icdextension`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_icebreakersconfig"></a> business_unit_msdyn_icebreakersconfig

Many-To-One Relationship: [msdyn_icebreakersconfig business_unit_msdyn_icebreakersconfig](msdyn_icebreakersconfig.md#BKMK_business_unit_msdyn_icebreakersconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_icebreakersconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_icebreakersconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iermlmodel"></a> business_unit_msdyn_iermlmodel

Many-To-One Relationship: [msdyn_iermlmodel business_unit_msdyn_iermlmodel](msdyn_iermlmodel.md#BKMK_business_unit_msdyn_iermlmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermlmodel`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iermlmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iermltraining"></a> business_unit_msdyn_iermltraining

Many-To-One Relationship: [msdyn_iermltraining business_unit_msdyn_iermltraining](msdyn_iermltraining.md#BKMK_business_unit_msdyn_iermltraining)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iermltraining`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iermltraining`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intent"></a> business_unit_msdyn_intent

Many-To-One Relationship: [msdyn_intent business_unit_msdyn_intent](msdyn_intent.md#BKMK_business_unit_msdyn_intent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intent`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intentattribute"></a> business_unit_msdyn_intentattribute

Many-To-One Relationship: [msdyn_intentattribute business_unit_msdyn_intentattribute](msdyn_intentattribute.md#BKMK_business_unit_msdyn_intentattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattribute`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intentattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intentattribute_entity"></a> business_unit_msdyn_intentattribute_entity

Many-To-One Relationship: [msdyn_intentattribute_entity business_unit_msdyn_intentattribute_entity](msdyn_intentattribute_entity.md#BKMK_business_unit_msdyn_intentattribute_entity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattribute_entity`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intentattribute_entity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intentattributeset"></a> business_unit_msdyn_intentattributeset

Many-To-One Relationship: [msdyn_intentattributeset business_unit_msdyn_intentattributeset](msdyn_intentattributeset.md#BKMK_business_unit_msdyn_intentattributeset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattributeset`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intentattributeset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intentconfig"></a> business_unit_msdyn_intentconfig

Many-To-One Relationship: [msdyn_intentconfig business_unit_msdyn_intentconfig](msdyn_intentconfig.md#BKMK_business_unit_msdyn_intentconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intentconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intententity"></a> business_unit_msdyn_intententity

Many-To-One Relationship: [msdyn_intententity business_unit_msdyn_intententity](msdyn_intententity.md#BKMK_business_unit_msdyn_intententity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intententity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intententity_backfillstatus"></a> business_unit_msdyn_intententity_backfillstatus

Many-To-One Relationship: [msdyn_intententity_backfillstatus business_unit_msdyn_intententity_backfillstatus](msdyn_intententity_backfillstatus.md#BKMK_business_unit_msdyn_intententity_backfillstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity_backfillstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intententity_backfillstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intentfamily"></a> business_unit_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intentfamily business_unit_msdyn_intentfamily](msdyn_intentfamily.md#BKMK_business_unit_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentfamily`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intentfamily`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intentfeature_configuration"></a> business_unit_msdyn_intentfeature_configuration

Many-To-One Relationship: [msdyn_intentfeature_configuration business_unit_msdyn_intentfeature_configuration](msdyn_intentfeature_configuration.md#BKMK_business_unit_msdyn_intentfeature_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentfeature_configuration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intentfeature_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intentgroupcondition"></a> business_unit_msdyn_intentgroupcondition

Many-To-One Relationship: [msdyn_intentgroupcondition business_unit_msdyn_intentgroupcondition](msdyn_intentgroupcondition.md#BKMK_business_unit_msdyn_intentgroupcondition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentgroupcondition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intentgroupcondition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_intentsolutionmap"></a> business_unit_msdyn_intentsolutionmap

Many-To-One Relationship: [msdyn_intentsolutionmap business_unit_msdyn_intentsolutionmap](msdyn_intentsolutionmap.md#BKMK_business_unit_msdyn_intentsolutionmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentsolutionmap`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_intentsolutionmap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotalert"></a> business_unit_msdyn_iotalert

Many-To-One Relationship: [msdyn_iotalert business_unit_msdyn_iotalert](msdyn_iotalert.md#BKMK_business_unit_msdyn_iotalert)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotdevice"></a> business_unit_msdyn_iotdevice

Many-To-One Relationship: [msdyn_iotdevice business_unit_msdyn_iotdevice](msdyn_iotdevice.md#BKMK_business_unit_msdyn_iotdevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevice`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotdevice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotdevicecategory"></a> business_unit_msdyn_iotdevicecategory

Many-To-One Relationship: [msdyn_iotdevicecategory business_unit_msdyn_iotdevicecategory](msdyn_iotdevicecategory.md#BKMK_business_unit_msdyn_iotdevicecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecategory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotdevicecategory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotdevicecommand"></a> business_unit_msdyn_iotdevicecommand

Many-To-One Relationship: [msdyn_iotdevicecommand business_unit_msdyn_iotdevicecommand](msdyn_iotdevicecommand.md#BKMK_business_unit_msdyn_iotdevicecommand)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommand`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotdevicecommand`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotdevicecommanddefinition"></a> business_unit_msdyn_iotdevicecommanddefinition

Many-To-One Relationship: [msdyn_iotdevicecommanddefinition business_unit_msdyn_iotdevicecommanddefinition](msdyn_iotdevicecommanddefinition.md#BKMK_business_unit_msdyn_iotdevicecommanddefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommanddefinition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotdevicecommanddefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotdevicedatahistory"></a> business_unit_msdyn_iotdevicedatahistory

Many-To-One Relationship: [msdyn_iotdevicedatahistory business_unit_msdyn_iotdevicedatahistory](msdyn_iotdevicedatahistory.md#BKMK_business_unit_msdyn_iotdevicedatahistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicedatahistory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotdevicedatahistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotdeviceproperty"></a> business_unit_msdyn_iotdeviceproperty

Many-To-One Relationship: [msdyn_iotdeviceproperty business_unit_msdyn_iotdeviceproperty](msdyn_iotdeviceproperty.md#BKMK_business_unit_msdyn_iotdeviceproperty)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdeviceproperty`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotdeviceproperty`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotdeviceregistrationhistory"></a> business_unit_msdyn_iotdeviceregistrationhistory

Many-To-One Relationship: [msdyn_iotdeviceregistrationhistory business_unit_msdyn_iotdeviceregistrationhistory](msdyn_iotdeviceregistrationhistory.md#BKMK_business_unit_msdyn_iotdeviceregistrationhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotdeviceregistrationhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotdevicevisualizationconfiguration"></a> business_unit_msdyn_iotdevicevisualizationconfiguration

Many-To-One Relationship: [msdyn_iotdevicevisualizationconfiguration business_unit_msdyn_iotdevicevisualizationconfiguration](msdyn_iotdevicevisualizationconfiguration.md#BKMK_business_unit_msdyn_iotdevicevisualizationconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicevisualizationconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotdevicevisualizationconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotfieldmapping"></a> business_unit_msdyn_iotfieldmapping

Many-To-One Relationship: [msdyn_iotfieldmapping business_unit_msdyn_iotfieldmapping](msdyn_iotfieldmapping.md#BKMK_business_unit_msdyn_iotfieldmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotfieldmapping`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotfieldmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotpropertydefinition"></a> business_unit_msdyn_iotpropertydefinition

Many-To-One Relationship: [msdyn_iotpropertydefinition business_unit_msdyn_iotpropertydefinition](msdyn_iotpropertydefinition.md#BKMK_business_unit_msdyn_iotpropertydefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotpropertydefinition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotpropertydefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotprovider"></a> business_unit_msdyn_iotprovider

Many-To-One Relationship: [msdyn_iotprovider business_unit_msdyn_iotprovider](msdyn_iotprovider.md#BKMK_business_unit_msdyn_iotprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotprovider`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotproviderinstance"></a> business_unit_msdyn_iotproviderinstance

Many-To-One Relationship: [msdyn_iotproviderinstance business_unit_msdyn_iotproviderinstance](msdyn_iotproviderinstance.md#BKMK_business_unit_msdyn_iotproviderinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotproviderinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotproviderinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_iotsettings"></a> business_unit_msdyn_iotsettings

Many-To-One Relationship: [msdyn_iotsettings business_unit_msdyn_iotsettings](msdyn_iotsettings.md#BKMK_business_unit_msdyn_iotsettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotsettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_iotsettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_kpieventdata"></a> business_unit_msdyn_kpieventdata

Many-To-One Relationship: [msdyn_kpieventdata business_unit_msdyn_kpieventdata](msdyn_kpieventdata.md#BKMK_business_unit_msdyn_kpieventdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_kpieventdata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_kpieventdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_kpieventdefinition"></a> business_unit_msdyn_kpieventdefinition

Many-To-One Relationship: [msdyn_kpieventdefinition business_unit_msdyn_kpieventdefinition](msdyn_kpieventdefinition.md#BKMK_business_unit_msdyn_kpieventdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_kpieventdefinition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_kpieventdefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_language"></a> business_unit_msdyn_language

Many-To-One Relationship: [msdyn_language business_unit_msdyn_language](msdyn_language.md#BKMK_business_unit_msdyn_language)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_language`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_language`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_leadmodelconfig"></a> business_unit_msdyn_leadmodelconfig

Many-To-One Relationship: [msdyn_leadmodelconfig business_unit_msdyn_leadmodelconfig](msdyn_leadmodelconfig.md#BKMK_business_unit_msdyn_leadmodelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_leadmodelconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_leadmodelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_liveworkitemevent"></a> business_unit_msdyn_liveworkitemevent

Many-To-One Relationship: [msdyn_liveworkitemevent business_unit_msdyn_liveworkitemevent](msdyn_liveworkitemevent.md#BKMK_business_unit_msdyn_liveworkitemevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkitemevent`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_liveworkitemevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_liveworkstream"></a> business_unit_msdyn_liveworkstream

Many-To-One Relationship: [msdyn_liveworkstream business_unit_msdyn_liveworkstream](msdyn_liveworkstream.md#BKMK_business_unit_msdyn_liveworkstream)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstream`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_liveworkstream`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_liveworkstreamcapacityprofile"></a> business_unit_msdyn_liveworkstreamcapacityprofile

Many-To-One Relationship: [msdyn_liveworkstreamcapacityprofile business_unit_msdyn_liveworkstreamcapacityprofile](msdyn_liveworkstreamcapacityprofile.md#BKMK_business_unit_msdyn_liveworkstreamcapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveworkstreamcapacityprofile`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_liveworkstreamcapacityprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_locationtemplateassociation"></a> business_unit_msdyn_locationtemplateassociation

Many-To-One Relationship: [msdyn_locationtemplateassociation business_unit_msdyn_locationtemplateassociation](msdyn_locationtemplateassociation.md#BKMK_business_unit_msdyn_locationtemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_locationtemplateassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_locationtemplateassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_locationtypetemplateassociation"></a> business_unit_msdyn_locationtypetemplateassociation

Many-To-One Relationship: [msdyn_locationtypetemplateassociation business_unit_msdyn_locationtypetemplateassociation](msdyn_locationtypetemplateassociation.md#BKMK_business_unit_msdyn_locationtypetemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_locationtypetemplateassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_locationtypetemplateassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_lockstatus"></a> business_unit_msdyn_lockstatus

Many-To-One Relationship: [msdyn_lockstatus business_unit_msdyn_lockstatus](msdyn_lockstatus.md#BKMK_business_unit_msdyn_lockstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_lockstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_lockstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_macrosession"></a> business_unit_msdyn_macrosession

Many-To-One Relationship: [msdyn_macrosession business_unit_msdyn_macrosession](msdyn_macrosession.md#BKMK_business_unit_msdyn_macrosession)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_macrosession`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_macrosession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_masterentityroutingconfiguration"></a> business_unit_msdyn_masterentityroutingconfiguration

Many-To-One Relationship: [msdyn_masterentityroutingconfiguration business_unit_msdyn_masterentityroutingconfiguration](msdyn_masterentityroutingconfiguration.md#BKMK_business_unit_msdyn_masterentityroutingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_masterentityroutingconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_masterentityroutingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_migrationtracker"></a> business_unit_msdyn_migrationtracker

Many-To-One Relationship: [msdyn_migrationtracker business_unit_msdyn_migrationtracker](msdyn_migrationtracker.md#BKMK_business_unit_msdyn_migrationtracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_migrationtracker`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_migrationtracker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_modelpreviewstatus"></a> business_unit_msdyn_modelpreviewstatus

Many-To-One Relationship: [msdyn_modelpreviewstatus business_unit_msdyn_modelpreviewstatus](msdyn_modelpreviewstatus.md#BKMK_business_unit_msdyn_modelpreviewstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_modelpreviewstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_modelpreviewstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_notesanalysisconfig"></a> business_unit_msdyn_notesanalysisconfig

Many-To-One Relationship: [msdyn_notesanalysisconfig business_unit_msdyn_notesanalysisconfig](msdyn_notesanalysisconfig.md#BKMK_business_unit_msdyn_notesanalysisconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notesanalysisconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_notesanalysisconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_notificationfield"></a> business_unit_msdyn_notificationfield

Many-To-One Relationship: [msdyn_notificationfield business_unit_msdyn_notificationfield](msdyn_notificationfield.md#BKMK_business_unit_msdyn_notificationfield)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notificationfield`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_notificationfield`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_notificationtemplate"></a> business_unit_msdyn_notificationtemplate

Many-To-One Relationship: [msdyn_notificationtemplate business_unit_msdyn_notificationtemplate](msdyn_notificationtemplate.md#BKMK_business_unit_msdyn_notificationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_notificationtemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_notificationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_oc_geolocationprovider"></a> business_unit_msdyn_oc_geolocationprovider

Many-To-One Relationship: [msdyn_oc_geolocationprovider business_unit_msdyn_oc_geolocationprovider](msdyn_oc_geolocationprovider.md#BKMK_business_unit_msdyn_oc_geolocationprovider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oc_geolocationprovider`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_oc_geolocationprovider`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocagentassignedcustomapiprivilege"></a> business_unit_msdyn_ocagentassignedcustomapiprivilege

Many-To-One Relationship: [msdyn_ocagentassignedcustomapiprivilege business_unit_msdyn_ocagentassignedcustomapiprivilege](msdyn_ocagentassignedcustomapiprivilege.md#BKMK_business_unit_msdyn_ocagentassignedcustomapiprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocagentassignedcustomapiprivilege`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocagentassignedcustomapiprivilege`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocautoblockrule"></a> business_unit_msdyn_ocautoblockrule

Many-To-One Relationship: [msdyn_ocautoblockrule business_unit_msdyn_ocautoblockrule](msdyn_ocautoblockrule.md#BKMK_business_unit_msdyn_ocautoblockrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautoblockrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocautoblockrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocautomatedactionrule"></a> business_unit_msdyn_ocautomatedactionrule

Many-To-One Relationship: [msdyn_ocautomatedactionrule business_unit_msdyn_ocautomatedactionrule](msdyn_ocautomatedactionrule.md#BKMK_business_unit_msdyn_ocautomatedactionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautomatedactionrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocautomatedactionrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocautomatedactionrulesmapping"></a> business_unit_msdyn_ocautomatedactionrulesmapping

Many-To-One Relationship: [msdyn_ocautomatedactionrulesmapping business_unit_msdyn_ocautomatedactionrulesmapping](msdyn_ocautomatedactionrulesmapping.md#BKMK_business_unit_msdyn_ocautomatedactionrulesmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautomatedactionrulesmapping`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocautomatedactionrulesmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocbotchannelregistration"></a> business_unit_msdyn_ocbotchannelregistration

Many-To-One Relationship: [msdyn_ocbotchannelregistration business_unit_msdyn_ocbotchannelregistration](msdyn_ocbotchannelregistration.md#BKMK_business_unit_msdyn_ocbotchannelregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocbotchannelregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocbotchannelregistrationsecret"></a> business_unit_msdyn_ocbotchannelregistrationsecret

Many-To-One Relationship: [msdyn_ocbotchannelregistrationsecret business_unit_msdyn_ocbotchannelregistrationsecret](msdyn_ocbotchannelregistrationsecret.md#BKMK_business_unit_msdyn_ocbotchannelregistrationsecret)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocbotchannelregistrationsecret`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocbotchannelregistrationsecret`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_occhannelapiconversationprivilege"></a> business_unit_msdyn_occhannelapiconversationprivilege

Many-To-One Relationship: [msdyn_occhannelapiconversationprivilege business_unit_msdyn_occhannelapiconversationprivilege](msdyn_occhannelapiconversationprivilege.md#BKMK_business_unit_msdyn_occhannelapiconversationprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapiconversationprivilege`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_occhannelapiconversationprivilege`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_occhannelapimessageprivilege"></a> business_unit_msdyn_occhannelapimessageprivilege

Many-To-One Relationship: [msdyn_occhannelapimessageprivilege business_unit_msdyn_occhannelapimessageprivilege](msdyn_occhannelapimessageprivilege.md#BKMK_business_unit_msdyn_occhannelapimessageprivilege)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapimessageprivilege`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_occhannelapimessageprivilege`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_occhannelapimethodmapping"></a> business_unit_msdyn_occhannelapimethodmapping

Many-To-One Relationship: [msdyn_occhannelapimethodmapping business_unit_msdyn_occhannelapimethodmapping](msdyn_occhannelapimethodmapping.md#BKMK_business_unit_msdyn_occhannelapimethodmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_occhannelapimethodmapping`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_occhannelapimethodmapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocexternalcontext"></a> business_unit_msdyn_ocexternalcontext

Many-To-One Relationship: [msdyn_ocexternalcontext business_unit_msdyn_ocexternalcontext](msdyn_ocexternalcontext.md#BKMK_business_unit_msdyn_ocexternalcontext)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalcontext`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocexternalcontext`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocflaggedspam"></a> business_unit_msdyn_ocflaggedspam

Many-To-One Relationship: [msdyn_ocflaggedspam business_unit_msdyn_ocflaggedspam](msdyn_ocflaggedspam.md#BKMK_business_unit_msdyn_ocflaggedspam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocflaggedspam`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocflaggedspam`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_oclanguage"></a> business_unit_msdyn_oclanguage

Many-To-One Relationship: [msdyn_oclanguage business_unit_msdyn_oclanguage](msdyn_oclanguage.md#BKMK_business_unit_msdyn_oclanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclanguage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_oclanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocliveworkitemcapacityprofile"></a> business_unit_msdyn_ocliveworkitemcapacityprofile

Many-To-One Relationship: [msdyn_ocliveworkitemcapacityprofile business_unit_msdyn_ocliveworkitemcapacityprofile](msdyn_ocliveworkitemcapacityprofile.md#BKMK_business_unit_msdyn_ocliveworkitemcapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcapacityprofile`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocliveworkitemcapacityprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocliveworkitemcharacteristic"></a> business_unit_msdyn_ocliveworkitemcharacteristic

Many-To-One Relationship: [msdyn_ocliveworkitemcharacteristic business_unit_msdyn_ocliveworkitemcharacteristic](msdyn_ocliveworkitemcharacteristic.md#BKMK_business_unit_msdyn_ocliveworkitemcharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcharacteristic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocliveworkitemcharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocliveworkitemcontextitem"></a> business_unit_msdyn_ocliveworkitemcontextitem

Many-To-One Relationship: [msdyn_ocliveworkitemcontextitem business_unit_msdyn_ocliveworkitemcontextitem](msdyn_ocliveworkitemcontextitem.md#BKMK_business_unit_msdyn_ocliveworkitemcontextitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemcontextitem`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocliveworkitemcontextitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocliveworkitemsentiment"></a> business_unit_msdyn_ocliveworkitemsentiment

Many-To-One Relationship: [msdyn_ocliveworkitemsentiment business_unit_msdyn_ocliveworkitemsentiment](msdyn_ocliveworkitemsentiment.md#BKMK_business_unit_msdyn_ocliveworkitemsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitemsentiment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocliveworkitemsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocliveworkstreamcontextvariable"></a> business_unit_msdyn_ocliveworkstreamcontextvariable

Many-To-One Relationship: [msdyn_ocliveworkstreamcontextvariable business_unit_msdyn_ocliveworkstreamcontextvariable](msdyn_ocliveworkstreamcontextvariable.md#BKMK_business_unit_msdyn_ocliveworkstreamcontextvariable)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkstreamcontextvariable`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocliveworkstreamcontextvariable`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocpaymentprofile"></a> business_unit_msdyn_ocpaymentprofile

Many-To-One Relationship: [msdyn_ocpaymentprofile business_unit_msdyn_ocpaymentprofile](msdyn_ocpaymentprofile.md#BKMK_business_unit_msdyn_ocpaymentprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocpaymentprofile`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocpaymentprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocprovisioningstate"></a> business_unit_msdyn_ocprovisioningstate

Many-To-One Relationship: [msdyn_ocprovisioningstate business_unit_msdyn_ocprovisioningstate](msdyn_ocprovisioningstate.md#BKMK_business_unit_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocprovisioningstate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocprovisioningstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocrecording"></a> business_unit_msdyn_ocrecording

Many-To-One Relationship: [msdyn_ocrecording business_unit_msdyn_ocrecording](msdyn_ocrecording.md#BKMK_business_unit_msdyn_ocrecording)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrecording`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocrecording`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocrequest"></a> business_unit_msdyn_ocrequest

Many-To-One Relationship: [msdyn_ocrequest business_unit_msdyn_ocrequest](msdyn_ocrequest.md#BKMK_business_unit_msdyn_ocrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrequest`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocrichobject"></a> business_unit_msdyn_ocrichobject

Many-To-One Relationship: [msdyn_ocrichobject business_unit_msdyn_ocrichobject](msdyn_ocrichobject.md#BKMK_business_unit_msdyn_ocrichobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobject`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocrichobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocrichobjectmap"></a> business_unit_msdyn_ocrichobjectmap

Many-To-One Relationship: [msdyn_ocrichobjectmap business_unit_msdyn_ocrichobjectmap](msdyn_ocrichobjectmap.md#BKMK_business_unit_msdyn_ocrichobjectmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobjectmap`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocrichobjectmap`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocruleitem"></a> business_unit_msdyn_ocruleitem

Many-To-One Relationship: [msdyn_ocruleitem business_unit_msdyn_ocruleitem](msdyn_ocruleitem.md#BKMK_business_unit_msdyn_ocruleitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocruleitem`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocruleitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsentimentdailytopic"></a> business_unit_msdyn_ocsentimentdailytopic

Many-To-One Relationship: [msdyn_ocsentimentdailytopic business_unit_msdyn_ocsentimentdailytopic](msdyn_ocsentimentdailytopic.md#BKMK_business_unit_msdyn_ocsentimentdailytopic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsentimentdailytopic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsentimentdailytopickeyword"></a> business_unit_msdyn_ocsentimentdailytopickeyword

Many-To-One Relationship: [msdyn_ocsentimentdailytopickeyword business_unit_msdyn_ocsentimentdailytopickeyword](msdyn_ocsentimentdailytopickeyword.md#BKMK_business_unit_msdyn_ocsentimentdailytopickeyword)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopickeyword`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsentimentdailytopickeyword`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsentimentdailytopictrending"></a> business_unit_msdyn_ocsentimentdailytopictrending

Many-To-One Relationship: [msdyn_ocsentimentdailytopictrending business_unit_msdyn_ocsentimentdailytopictrending](msdyn_ocsentimentdailytopictrending.md#BKMK_business_unit_msdyn_ocsentimentdailytopictrending)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsentimentdailytopictrending`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsentimentdailytopictrending`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsessioncharacteristic"></a> business_unit_msdyn_ocsessioncharacteristic

Many-To-One Relationship: [msdyn_ocsessioncharacteristic business_unit_msdyn_ocsessioncharacteristic](msdyn_ocsessioncharacteristic.md#BKMK_business_unit_msdyn_ocsessioncharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessioncharacteristic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsessioncharacteristic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsessionparticipantevent"></a> business_unit_msdyn_ocsessionparticipantevent

Many-To-One Relationship: [msdyn_ocsessionparticipantevent business_unit_msdyn_ocsessionparticipantevent](msdyn_ocsessionparticipantevent.md#BKMK_business_unit_msdyn_ocsessionparticipantevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionparticipantevent`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsessionparticipantevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsessionsentiment"></a> business_unit_msdyn_ocsessionsentiment

Many-To-One Relationship: [msdyn_ocsessionsentiment business_unit_msdyn_ocsessionsentiment](msdyn_ocsessionsentiment.md#BKMK_business_unit_msdyn_ocsessionsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionsentiment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsessionsentiment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsimltraining"></a> business_unit_msdyn_ocsimltraining

Many-To-One Relationship: [msdyn_ocsimltraining business_unit_msdyn_ocsimltraining](msdyn_ocsimltraining.md#BKMK_business_unit_msdyn_ocsimltraining)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsimltraining`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsimltraining`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsitdimportconfig"></a> business_unit_msdyn_ocsitdimportconfig

Many-To-One Relationship: [msdyn_ocsitdimportconfig business_unit_msdyn_ocsitdimportconfig](msdyn_ocsitdimportconfig.md#BKMK_business_unit_msdyn_ocsitdimportconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitdimportconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsitdimportconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsitdskill"></a> business_unit_msdyn_ocsitdskill

Many-To-One Relationship: [msdyn_ocsitdskill business_unit_msdyn_ocsitdskill](msdyn_ocsitdskill.md#BKMK_business_unit_msdyn_ocsitdskill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitdskill`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsitdskill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocsitrainingdata"></a> business_unit_msdyn_ocsitrainingdata

Many-To-One Relationship: [msdyn_ocsitrainingdata business_unit_msdyn_ocsitrainingdata](msdyn_ocsitrainingdata.md#BKMK_business_unit_msdyn_ocsitrainingdata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsitrainingdata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocsitrainingdata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_ocskillidentmlmodel"></a> business_unit_msdyn_ocskillidentmlmodel

Many-To-One Relationship: [msdyn_ocskillidentmlmodel business_unit_msdyn_ocskillidentmlmodel](msdyn_ocskillidentmlmodel.md#BKMK_business_unit_msdyn_ocskillidentmlmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocskillidentmlmodel`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_ocskillidentmlmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_omnichannelpersonalization"></a> business_unit_msdyn_omnichannelpersonalization

Many-To-One Relationship: [msdyn_omnichannelpersonalization business_unit_msdyn_omnichannelpersonalization](msdyn_omnichannelpersonalization.md#BKMK_business_unit_msdyn_omnichannelpersonalization)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelpersonalization`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_omnichannelpersonalization`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_omnichannelsyncconfig"></a> business_unit_msdyn_omnichannelsyncconfig

Many-To-One Relationship: [msdyn_omnichannelsyncconfig business_unit_msdyn_omnichannelsyncconfig](msdyn_omnichannelsyncconfig.md#BKMK_business_unit_msdyn_omnichannelsyncconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelsyncconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_omnichannelsyncconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_operatinghour"></a> business_unit_msdyn_operatinghour

Many-To-One Relationship: [msdyn_operatinghour business_unit_msdyn_operatinghour](msdyn_operatinghour.md#BKMK_business_unit_msdyn_operatinghour)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_operatinghour`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_operatinghour`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_opportunitymodelconfig"></a> business_unit_msdyn_opportunitymodelconfig

Many-To-One Relationship: [msdyn_opportunitymodelconfig business_unit_msdyn_opportunitymodelconfig](msdyn_opportunitymodelconfig.md#BKMK_business_unit_msdyn_opportunitymodelconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_opportunitymodelconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_opportunitymodelconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_orgchartnode"></a> business_unit_msdyn_orgchartnode

Many-To-One Relationship: [msdyn_orgchartnode business_unit_msdyn_orgchartnode](msdyn_orgchartnode.md#BKMK_business_unit_msdyn_orgchartnode)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orgchartnode`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_orgchartnode`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_overflowactionconfig"></a> business_unit_msdyn_overflowactionconfig

Many-To-One Relationship: [msdyn_overflowactionconfig business_unit_msdyn_overflowactionconfig](msdyn_overflowactionconfig.md#BKMK_business_unit_msdyn_overflowactionconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_overflowactionconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_overflowactionconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_personalmessage"></a> business_unit_msdyn_personalmessage

Many-To-One Relationship: [msdyn_personalmessage business_unit_msdyn_personalmessage](msdyn_personalmessage.md#BKMK_business_unit_msdyn_personalmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_personalmessage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_personalmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_personalsoundsetting"></a> business_unit_msdyn_personalsoundsetting

Many-To-One Relationship: [msdyn_personalsoundsetting business_unit_msdyn_personalsoundsetting](msdyn_personalsoundsetting.md#BKMK_business_unit_msdyn_personalsoundsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_personalsoundsetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_personalsoundsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_postalbum"></a> business_unit_msdyn_postalbum

Many-To-One Relationship: [msdyn_postalbum business_unit_msdyn_postalbum](msdyn_postalbum.md#BKMK_business_unit_msdyn_postalbum)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalbum`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_postalbum`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_predictioncomputationoperation"></a> business_unit_msdyn_predictioncomputationoperation

Many-To-One Relationship: [msdyn_predictioncomputationoperation business_unit_msdyn_predictioncomputationoperation](msdyn_predictioncomputationoperation.md#BKMK_business_unit_msdyn_predictioncomputationoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictioncomputationoperation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_predictioncomputationoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_predictionmodelstatus"></a> business_unit_msdyn_predictionmodelstatus

Many-To-One Relationship: [msdyn_predictionmodelstatus business_unit_msdyn_predictionmodelstatus](msdyn_predictionmodelstatus.md#BKMK_business_unit_msdyn_predictionmodelstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictionmodelstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_predictionmodelstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_predictionscheduledoperation"></a> business_unit_msdyn_predictionscheduledoperation

Many-To-One Relationship: [msdyn_predictionscheduledoperation business_unit_msdyn_predictionscheduledoperation](msdyn_predictionscheduledoperation.md#BKMK_business_unit_msdyn_predictionscheduledoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictionscheduledoperation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_predictionscheduledoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_predictivescoringsyncstatus"></a> business_unit_msdyn_predictivescoringsyncstatus

Many-To-One Relationship: [msdyn_predictivescoringsyncstatus business_unit_msdyn_predictivescoringsyncstatus](msdyn_predictivescoringsyncstatus.md#BKMK_business_unit_msdyn_predictivescoringsyncstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_predictivescoringsyncstatus`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_predictivescoringsyncstatus`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_preferredagent"></a> business_unit_msdyn_preferredagent

Many-To-One Relationship: [msdyn_preferredagent business_unit_msdyn_preferredagent](msdyn_preferredagent.md#BKMK_business_unit_msdyn_preferredagent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagent`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_preferredagent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_preferredagentcustomeridentity"></a> business_unit_msdyn_preferredagentcustomeridentity

Many-To-One Relationship: [msdyn_preferredagentcustomeridentity business_unit_msdyn_preferredagentcustomeridentity](msdyn_preferredagentcustomeridentity.md#BKMK_business_unit_msdyn_preferredagentcustomeridentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagentcustomeridentity`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_preferredagentcustomeridentity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_preferredagentroutedentity"></a> business_unit_msdyn_preferredagentroutedentity

Many-To-One Relationship: [msdyn_preferredagentroutedentity business_unit_msdyn_preferredagentroutedentity](msdyn_preferredagentroutedentity.md#BKMK_business_unit_msdyn_preferredagentroutedentity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagentroutedentity`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_preferredagentroutedentity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_productivityactioninputparameter"></a> business_unit_msdyn_productivityactioninputparameter

Many-To-One Relationship: [msdyn_productivityactioninputparameter business_unit_msdyn_productivityactioninputparameter](msdyn_productivityactioninputparameter.md#BKMK_business_unit_msdyn_productivityactioninputparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityactioninputparameter`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_productivityactioninputparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_productivityactionoutputparameter"></a> business_unit_msdyn_productivityactionoutputparameter

Many-To-One Relationship: [msdyn_productivityactionoutputparameter business_unit_msdyn_productivityactionoutputparameter](msdyn_productivityactionoutputparameter.md#BKMK_business_unit_msdyn_productivityactionoutputparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityactionoutputparameter`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_productivityactionoutputparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_productivityagentscript"></a> business_unit_msdyn_productivityagentscript

Many-To-One Relationship: [msdyn_productivityagentscript business_unit_msdyn_productivityagentscript](msdyn_productivityagentscript.md#BKMK_business_unit_msdyn_productivityagentscript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityagentscript`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_productivityagentscript`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_productivityagentscriptstep"></a> business_unit_msdyn_productivityagentscriptstep

Many-To-One Relationship: [msdyn_productivityagentscriptstep business_unit_msdyn_productivityagentscriptstep](msdyn_productivityagentscriptstep.md#BKMK_business_unit_msdyn_productivityagentscriptstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityagentscriptstep`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_productivityagentscriptstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_productivitymacroactiontemplate"></a> business_unit_msdyn_productivitymacroactiontemplate

Many-To-One Relationship: [msdyn_productivitymacroactiontemplate business_unit_msdyn_productivitymacroactiontemplate](msdyn_productivitymacroactiontemplate.md#BKMK_business_unit_msdyn_productivitymacroactiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacroactiontemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_productivitymacroactiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_productivitymacroconnector"></a> business_unit_msdyn_productivitymacroconnector

Many-To-One Relationship: [msdyn_productivitymacroconnector business_unit_msdyn_productivitymacroconnector](msdyn_productivitymacroconnector.md#BKMK_business_unit_msdyn_productivitymacroconnector)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacroconnector`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_productivitymacroconnector`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_productivitymacrosolutionconfiguration"></a> business_unit_msdyn_productivitymacrosolutionconfiguration

Many-To-One Relationship: [msdyn_productivitymacrosolutionconfiguration business_unit_msdyn_productivitymacrosolutionconfiguration](msdyn_productivitymacrosolutionconfiguration.md#BKMK_business_unit_msdyn_productivitymacrosolutionconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivitymacrosolutionconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_productivitymacrosolutionconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_productivityparameterdefinition"></a> business_unit_msdyn_productivityparameterdefinition

Many-To-One Relationship: [msdyn_productivityparameterdefinition business_unit_msdyn_productivityparameterdefinition](msdyn_productivityparameterdefinition.md#BKMK_business_unit_msdyn_productivityparameterdefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_productivityparameterdefinition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_productivityparameterdefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_property"></a> business_unit_msdyn_property

Many-To-One Relationship: [msdyn_property business_unit_msdyn_property](msdyn_property.md#BKMK_business_unit_msdyn_property)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_property`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_property`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_propertyassetassociation"></a> business_unit_msdyn_propertyassetassociation

Many-To-One Relationship: [msdyn_propertyassetassociation business_unit_msdyn_propertyassetassociation](msdyn_propertyassetassociation.md#BKMK_business_unit_msdyn_propertyassetassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertyassetassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_propertyassetassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_propertylocationassociation"></a> business_unit_msdyn_propertylocationassociation

Many-To-One Relationship: [msdyn_propertylocationassociation business_unit_msdyn_propertylocationassociation](msdyn_propertylocationassociation.md#BKMK_business_unit_msdyn_propertylocationassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylocationassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_propertylocationassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_propertylog"></a> business_unit_msdyn_propertylog

Many-To-One Relationship: [msdyn_propertylog business_unit_msdyn_propertylog](msdyn_propertylog.md#BKMK_business_unit_msdyn_propertylog)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylog`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_propertylog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_propertytemplateassociation"></a> business_unit_msdyn_propertytemplateassociation

Many-To-One Relationship: [msdyn_propertytemplateassociation business_unit_msdyn_propertytemplateassociation](msdyn_propertytemplateassociation.md#BKMK_business_unit_msdyn_propertytemplateassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertytemplateassociation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_propertytemplateassociation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_rawinsight"></a> business_unit_msdyn_rawinsight

Many-To-One Relationship: [msdyn_rawinsight business_unit_msdyn_rawinsight](msdyn_rawinsight.md#BKMK_business_unit_msdyn_rawinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rawinsight`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_rawinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_readtracker"></a> business_unit_msdyn_readtracker

Many-To-One Relationship: [msdyn_readtracker business_unit_msdyn_readtracker](msdyn_readtracker.md#BKMK_business_unit_msdyn_readtracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_readtracker`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_readtracker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_realtimescoring"></a> business_unit_msdyn_realtimescoring

Many-To-One Relationship: [msdyn_realtimescoring business_unit_msdyn_realtimescoring](msdyn_realtimescoring.md#BKMK_business_unit_msdyn_realtimescoring)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_realtimescoring`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_realtimescoring`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_realtimescoringoperation"></a> business_unit_msdyn_realtimescoringoperation

Many-To-One Relationship: [msdyn_realtimescoringoperation business_unit_msdyn_realtimescoringoperation](msdyn_realtimescoringoperation.md#BKMK_business_unit_msdyn_realtimescoringoperation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_realtimescoringoperation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_realtimescoringoperation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_region"></a> business_unit_msdyn_region

Many-To-One Relationship: [msdyn_region business_unit_msdyn_region](msdyn_region.md#BKMK_business_unit_msdyn_region)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_region`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_region`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_reportbookmark"></a> business_unit_msdyn_reportbookmark

Many-To-One Relationship: [msdyn_reportbookmark business_unit_msdyn_reportbookmark](msdyn_reportbookmark.md#BKMK_business_unit_msdyn_reportbookmark)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_reportbookmark`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_reportbookmark`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_routingconfiguration"></a> business_unit_msdyn_routingconfiguration

Many-To-One Relationship: [msdyn_routingconfiguration business_unit_msdyn_routingconfiguration](msdyn_routingconfiguration.md#BKMK_business_unit_msdyn_routingconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_routingconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_routingconfigurationstep"></a> business_unit_msdyn_routingconfigurationstep

Many-To-One Relationship: [msdyn_routingconfigurationstep business_unit_msdyn_routingconfigurationstep](msdyn_routingconfigurationstep.md#BKMK_business_unit_msdyn_routingconfigurationstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingconfigurationstep`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_routingconfigurationstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_routingrequest"></a> business_unit_msdyn_routingrequest

Many-To-One Relationship: [msdyn_routingrequest business_unit_msdyn_routingrequest](msdyn_routingrequest.md#BKMK_business_unit_msdyn_routingrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingrequest`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_routingrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salescopilotemailinsight"></a> business_unit_msdyn_salescopilotemailinsight

Many-To-One Relationship: [msdyn_salescopilotemailinsight business_unit_msdyn_salescopilotemailinsight](msdyn_salescopilotemailinsight.md#BKMK_business_unit_msdyn_salescopilotemailinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotemailinsight`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salescopilotemailinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salescopilotinsight"></a> business_unit_msdyn_salescopilotinsight

Many-To-One Relationship: [msdyn_salescopilotinsight business_unit_msdyn_salescopilotinsight](msdyn_salescopilotinsight.md#BKMK_business_unit_msdyn_salescopilotinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salescopilotinsight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salescopilotinsightcardstate"></a> business_unit_msdyn_salescopilotinsightcardstate

Many-To-One Relationship: [msdyn_salescopilotinsightcardstate business_unit_msdyn_salescopilotinsightcardstate](msdyn_salescopilotinsightcardstate.md#BKMK_business_unit_msdyn_salescopilotinsightcardstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsightcardstate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salescopilotinsightcardstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salesinsightssettings"></a> business_unit_msdyn_salesinsightssettings

Many-To-One Relationship: [msdyn_salesinsightssettings business_unit_msdyn_salesinsightssettings](msdyn_salesinsightssettings.md#BKMK_business_unit_msdyn_salesinsightssettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesinsightssettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salesinsightssettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salesocmessage"></a> business_unit_msdyn_salesocmessage

Many-To-One Relationship: [msdyn_salesocmessage business_unit_msdyn_salesocmessage](msdyn_salesocmessage.md#BKMK_business_unit_msdyn_salesocmessage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesocmessage`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salesocmessage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salesocsmstemplate"></a> business_unit_msdyn_salesocsmstemplate

Many-To-One Relationship: [msdyn_salesocsmstemplate business_unit_msdyn_salesocsmstemplate](msdyn_salesocsmstemplate.md#BKMK_business_unit_msdyn_salesocsmstemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesocsmstemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salesocsmstemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salesroutingrun"></a> business_unit_msdyn_salesroutingrun

Many-To-One Relationship: [msdyn_salesroutingrun business_unit_msdyn_salesroutingrun](msdyn_salesroutingrun.md#BKMK_business_unit_msdyn_salesroutingrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salesroutingrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salessuggestion"></a> business_unit_msdyn_salessuggestion

Many-To-One Relationship: [msdyn_salessuggestion business_unit_msdyn_salessuggestion](msdyn_salessuggestion.md#BKMK_business_unit_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salessuggestion`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salessuggestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_salestag"></a> business_unit_msdyn_salestag

Many-To-One Relationship: [msdyn_salestag business_unit_msdyn_salestag](msdyn_salestag.md#BKMK_business_unit_msdyn_salestag)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salestag`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_salestag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sciconversation"></a> business_unit_msdyn_sciconversation

Many-To-One Relationship: [msdyn_sciconversation business_unit_msdyn_sciconversation](msdyn_sciconversation.md#BKMK_business_unit_msdyn_sciconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciconversation`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sciconversation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_scicustomemailhighlight"></a> business_unit_msdyn_scicustomemailhighlight

Many-To-One Relationship: [msdyn_scicustomemailhighlight business_unit_msdyn_scicustomemailhighlight](msdyn_scicustomemailhighlight.md#BKMK_business_unit_msdyn_scicustomemailhighlight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustomemailhighlight`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_scicustomemailhighlight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_scicustomhighlight"></a> business_unit_msdyn_scicustomhighlight

Many-To-One Relationship: [msdyn_scicustomhighlight business_unit_msdyn_scicustomhighlight](msdyn_scicustomhighlight.md#BKMK_business_unit_msdyn_scicustomhighlight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustomhighlight`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_scicustomhighlight`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_scicustompublisher"></a> business_unit_msdyn_scicustompublisher

Many-To-One Relationship: [msdyn_scicustompublisher business_unit_msdyn_scicustompublisher](msdyn_scicustompublisher.md#BKMK_business_unit_msdyn_scicustompublisher)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_scicustompublisher`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_scicustompublisher`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sciusersettings"></a> business_unit_msdyn_sciusersettings

Many-To-One Relationship: [msdyn_sciusersettings business_unit_msdyn_sciusersettings](msdyn_sciusersettings.md#BKMK_business_unit_msdyn_sciusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sciusersettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sciusersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_searchconfiguration"></a> business_unit_msdyn_searchconfiguration

Many-To-One Relationship: [msdyn_searchconfiguration business_unit_msdyn_searchconfiguration](msdyn_searchconfiguration.md#BKMK_business_unit_msdyn_searchconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_searchconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_searchconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_segment"></a> business_unit_msdyn_segment

Many-To-One Relationship: [msdyn_segment business_unit_msdyn_segment](msdyn_segment.md#BKMK_business_unit_msdyn_segment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_segment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_segment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sequence"></a> business_unit_msdyn_sequence

Many-To-One Relationship: [msdyn_sequence business_unit_msdyn_sequence](msdyn_sequence.md#BKMK_business_unit_msdyn_sequence)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequence`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sequence`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sequencestat"></a> business_unit_msdyn_sequencestat

Many-To-One Relationship: [msdyn_sequencestat business_unit_msdyn_sequencestat](msdyn_sequencestat.md#BKMK_business_unit_msdyn_sequencestat)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencestat`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sequencestat`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sequencetarget"></a> business_unit_msdyn_sequencetarget

Many-To-One Relationship: [msdyn_sequencetarget business_unit_msdyn_sequencetarget](msdyn_sequencetarget.md#BKMK_business_unit_msdyn_sequencetarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sequencetarget`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sequencetargetstep"></a> business_unit_msdyn_sequencetargetstep

Many-To-One Relationship: [msdyn_sequencetargetstep business_unit_msdyn_sequencetargetstep](msdyn_sequencetargetstep.md#BKMK_business_unit_msdyn_sequencetargetstep)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetargetstep`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sequencetargetstep`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sequencetemplate"></a> business_unit_msdyn_sequencetemplate

Many-To-One Relationship: [msdyn_sequencetemplate business_unit_msdyn_sequencetemplate](msdyn_sequencetemplate.md#BKMK_business_unit_msdyn_sequencetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sequencetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_serviceoneprovisioningrequest"></a> business_unit_msdyn_serviceoneprovisioningrequest

Many-To-One Relationship: [msdyn_serviceoneprovisioningrequest business_unit_msdyn_serviceoneprovisioningrequest](msdyn_serviceoneprovisioningrequest.md#BKMK_business_unit_msdyn_serviceoneprovisioningrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_serviceoneprovisioningrequest`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_serviceoneprovisioningrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sessionevent"></a> business_unit_msdyn_sessionevent

Many-To-One Relationship: [msdyn_sessionevent business_unit_msdyn_sessionevent](msdyn_sessionevent.md#BKMK_business_unit_msdyn_sessionevent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionevent`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sessionevent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sessionparticipant"></a> business_unit_msdyn_sessionparticipant

Many-To-One Relationship: [msdyn_sessionparticipant business_unit_msdyn_sessionparticipant](msdyn_sessionparticipant.md#BKMK_business_unit_msdyn_sessionparticipant)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessionparticipant`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sessionparticipant`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_sessiontemplate"></a> business_unit_msdyn_sessiontemplate

Many-To-One Relationship: [msdyn_sessiontemplate business_unit_msdyn_sessiontemplate](msdyn_sessiontemplate.md#BKMK_business_unit_msdyn_sessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiontemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_sessiontemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_siconfig"></a> business_unit_msdyn_siconfig

Many-To-One Relationship: [msdyn_siconfig business_unit_msdyn_siconfig](msdyn_siconfig.md#BKMK_business_unit_msdyn_siconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_siconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_siconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_skillattachmentruleitem"></a> business_unit_msdyn_skillattachmentruleitem

Many-To-One Relationship: [msdyn_skillattachmentruleitem business_unit_msdyn_skillattachmentruleitem](msdyn_skillattachmentruleitem.md#BKMK_business_unit_msdyn_skillattachmentruleitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_skillattachmentruleitem`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_skillattachmentruleitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_skillattachmenttarget"></a> business_unit_msdyn_skillattachmenttarget

Many-To-One Relationship: [msdyn_skillattachmenttarget business_unit_msdyn_skillattachmenttarget](msdyn_skillattachmenttarget.md#BKMK_business_unit_msdyn_skillattachmenttarget)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_skillattachmenttarget`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_skillattachmenttarget`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_soundnotificationsetting"></a> business_unit_msdyn_soundnotificationsetting

Many-To-One Relationship: [msdyn_soundnotificationsetting business_unit_msdyn_soundnotificationsetting](msdyn_soundnotificationsetting.md#BKMK_business_unit_msdyn_soundnotificationsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_soundnotificationsetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_soundnotificationsetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_submodeldefinition"></a> business_unit_msdyn_submodeldefinition

Many-To-One Relationship: [msdyn_submodeldefinition business_unit_msdyn_submodeldefinition](msdyn_submodeldefinition.md#BKMK_business_unit_msdyn_submodeldefinition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_submodeldefinition`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_submodeldefinition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_suggestionassignmentrule"></a> business_unit_msdyn_suggestionassignmentrule

Many-To-One Relationship: [msdyn_suggestionassignmentrule business_unit_msdyn_suggestionassignmentrule](msdyn_suggestionassignmentrule.md#BKMK_business_unit_msdyn_suggestionassignmentrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionassignmentrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_suggestionassignmentrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_suggestionprincipalobjectaccess"></a> business_unit_msdyn_suggestionprincipalobjectaccess

Many-To-One Relationship: [msdyn_suggestionprincipalobjectaccess business_unit_msdyn_suggestionprincipalobjectaccess](msdyn_suggestionprincipalobjectaccess.md#BKMK_business_unit_msdyn_suggestionprincipalobjectaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionprincipalobjectaccess`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_suggestionprincipalobjectaccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_suggestionsellerpriority"></a> business_unit_msdyn_suggestionsellerpriority

Many-To-One Relationship: [msdyn_suggestionsellerpriority business_unit_msdyn_suggestionsellerpriority](msdyn_suggestionsellerpriority.md#BKMK_business_unit_msdyn_suggestionsellerpriority)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionsellerpriority`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_suggestionsellerpriority`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_swarm"></a> business_unit_msdyn_swarm

Many-To-One Relationship: [msdyn_swarm business_unit_msdyn_swarm](msdyn_swarm.md#BKMK_business_unit_msdyn_swarm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarm`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_swarm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_swarmparticipant"></a> business_unit_msdyn_swarmparticipant

Many-To-One Relationship: [msdyn_swarmparticipant business_unit_msdyn_swarmparticipant](msdyn_swarmparticipant.md#BKMK_business_unit_msdyn_swarmparticipant)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmparticipant`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_swarmparticipant`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_swarmparticipantrule"></a> business_unit_msdyn_swarmparticipantrule

Many-To-One Relationship: [msdyn_swarmparticipantrule business_unit_msdyn_swarmparticipantrule](msdyn_swarmparticipantrule.md#BKMK_business_unit_msdyn_swarmparticipantrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmparticipantrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_swarmparticipantrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_swarmrole"></a> business_unit_msdyn_swarmrole

Many-To-One Relationship: [msdyn_swarmrole business_unit_msdyn_swarmrole](msdyn_swarmrole.md#BKMK_business_unit_msdyn_swarmrole)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmrole`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_swarmrole`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_swarmskill"></a> business_unit_msdyn_swarmskill

Many-To-One Relationship: [msdyn_swarmskill business_unit_msdyn_swarmskill](msdyn_swarmskill.md#BKMK_business_unit_msdyn_swarmskill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmskill`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_swarmskill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_swarmtemplate"></a> business_unit_msdyn_swarmtemplate

Many-To-One Relationship: [msdyn_swarmtemplate business_unit_msdyn_swarmtemplate](msdyn_swarmtemplate.md#BKMK_business_unit_msdyn_swarmtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarmtemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_swarmtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_taggedrecord"></a> business_unit_msdyn_taggedrecord

Many-To-One Relationship: [msdyn_taggedrecord business_unit_msdyn_taggedrecord](msdyn_taggedrecord.md#BKMK_business_unit_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taggedrecord`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_taggedrecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_templateforproperties"></a> business_unit_msdyn_templateforproperties

Many-To-One Relationship: [msdyn_templateforproperties business_unit_msdyn_templateforproperties](msdyn_templateforproperties.md#BKMK_business_unit_msdyn_templateforproperties)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateforproperties`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_templateforproperties`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_templateparameter"></a> business_unit_msdyn_templateparameter

Many-To-One Relationship: [msdyn_templateparameter business_unit_msdyn_templateparameter](msdyn_templateparameter.md#BKMK_business_unit_msdyn_templateparameter)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateparameter`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_templateparameter`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_templateruleset"></a> business_unit_msdyn_templateruleset

Many-To-One Relationship: [msdyn_templateruleset business_unit_msdyn_templateruleset](msdyn_templateruleset.md#BKMK_business_unit_msdyn_templateruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateruleset`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_templateruleset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timespent"></a> business_unit_msdyn_timespent

Many-To-One Relationship: [msdyn_timespent business_unit_msdyn_timespent](msdyn_timespent.md#BKMK_business_unit_msdyn_timespent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timespent`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timespent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_timetracker"></a> business_unit_msdyn_timetracker

Many-To-One Relationship: [msdyn_timetracker business_unit_msdyn_timetracker](msdyn_timetracker.md#BKMK_business_unit_msdyn_timetracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timetracker`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_timetracker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_trainingresult"></a> business_unit_msdyn_trainingresult

Many-To-One Relationship: [msdyn_trainingresult business_unit_msdyn_trainingresult](msdyn_trainingresult.md#BKMK_business_unit_msdyn_trainingresult)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_trainingresult`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_trainingresult`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_transcript"></a> business_unit_msdyn_transcript

Many-To-One Relationship: [msdyn_transcript business_unit_msdyn_transcript](msdyn_transcript.md#BKMK_business_unit_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_transcript`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_unifiedroutingdiagnostic"></a> business_unit_msdyn_unifiedroutingdiagnostic

Many-To-One Relationship: [msdyn_unifiedroutingdiagnostic business_unit_msdyn_unifiedroutingdiagnostic](msdyn_unifiedroutingdiagnostic.md#BKMK_business_unit_msdyn_unifiedroutingdiagnostic)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingdiagnostic`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_unifiedroutingdiagnostic`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_unifiedroutingrun"></a> business_unit_msdyn_unifiedroutingrun

Many-To-One Relationship: [msdyn_unifiedroutingrun business_unit_msdyn_unifiedroutingrun](msdyn_unifiedroutingrun.md#BKMK_business_unit_msdyn_unifiedroutingrun)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_unifiedroutingrun`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_unifiedroutingrun`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_untrackedappointment"></a> business_unit_msdyn_untrackedappointment

Many-To-One Relationship: [msdyn_untrackedappointment business_unit_msdyn_untrackedappointment](msdyn_untrackedappointment.md#BKMK_business_unit_msdyn_untrackedappointment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_untrackedappointment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_untrackedappointment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_urnotificationtemplate"></a> business_unit_msdyn_urnotificationtemplate

Many-To-One Relationship: [msdyn_urnotificationtemplate business_unit_msdyn_urnotificationtemplate](msdyn_urnotificationtemplate.md#BKMK_business_unit_msdyn_urnotificationtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_urnotificationtemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_urnotificationtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_urnotificationtemplatemapping"></a> business_unit_msdyn_urnotificationtemplatemapping

Many-To-One Relationship: [msdyn_urnotificationtemplatemapping business_unit_msdyn_urnotificationtemplatemapping](msdyn_urnotificationtemplatemapping.md#BKMK_business_unit_msdyn_urnotificationtemplatemapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_urnotificationtemplatemapping`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_urnotificationtemplatemapping`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_visitorjourney"></a> business_unit_msdyn_visitorjourney

Many-To-One Relationship: [msdyn_visitorjourney business_unit_msdyn_visitorjourney](msdyn_visitorjourney.md#BKMK_business_unit_msdyn_visitorjourney)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_visitorjourney`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_visitorjourney`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_vivacustomerlist"></a> business_unit_msdyn_vivacustomerlist

Many-To-One Relationship: [msdyn_vivacustomerlist business_unit_msdyn_vivacustomerlist](msdyn_vivacustomerlist.md#BKMK_business_unit_msdyn_vivacustomerlist)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_vivacustomerlist`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_vivacustomerlist`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_wallsavedqueryusersettings"></a> business_unit_msdyn_wallsavedqueryusersettings

Many-To-One Relationship: [msdyn_wallsavedqueryusersettings business_unit_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_business_unit_msdyn_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wallsavedqueryusersettings`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_wallsavedqueryusersettings`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_warranty"></a> business_unit_msdyn_warranty

Many-To-One Relationship: [msdyn_warranty business_unit_msdyn_warranty](msdyn_warranty.md#BKMK_business_unit_msdyn_warranty)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warranty`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_warranty`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_wkwconfig"></a> business_unit_msdyn_wkwconfig

Many-To-One Relationship: [msdyn_wkwconfig business_unit_msdyn_wkwconfig](msdyn_wkwconfig.md#BKMK_business_unit_msdyn_wkwconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wkwconfig`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_wkwconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workqueuestate"></a> business_unit_msdyn_workqueuestate

Many-To-One Relationship: [msdyn_workqueuestate business_unit_msdyn_workqueuestate](msdyn_workqueuestate.md#BKMK_business_unit_msdyn_workqueuestate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workqueuestate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workqueuestate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyn_workqueueusersetting"></a> business_unit_msdyn_workqueueusersetting

Many-To-One Relationship: [msdyn_workqueueusersetting business_unit_msdyn_workqueueusersetting](msdyn_workqueueusersetting.md#BKMK_business_unit_msdyn_workqueueusersetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workqueueusersetting`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyn_workqueueusersetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_addtocalendarstyle"></a> business_unit_msdyncrm_addtocalendarstyle

Many-To-One Relationship: [msdyncrm_addtocalendarstyle business_unit_msdyncrm_addtocalendarstyle](msdyncrm_addtocalendarstyle.md#BKMK_business_unit_msdyncrm_addtocalendarstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_addtocalendarstyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_addtocalendarstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_basestyle"></a> business_unit_msdyncrm_basestyle

Many-To-One Relationship: [msdyncrm_basestyle business_unit_msdyncrm_basestyle](msdyncrm_basestyle.md#BKMK_business_unit_msdyncrm_basestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_basestyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_basestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_buttonstyle"></a> business_unit_msdyncrm_buttonstyle

Many-To-One Relationship: [msdyncrm_buttonstyle business_unit_msdyncrm_buttonstyle](msdyncrm_buttonstyle.md#BKMK_business_unit_msdyncrm_buttonstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_buttonstyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_buttonstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_codestyle"></a> business_unit_msdyncrm_codestyle

Many-To-One Relationship: [msdyncrm_codestyle business_unit_msdyncrm_codestyle](msdyncrm_codestyle.md#BKMK_business_unit_msdyncrm_codestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_codestyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_codestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_columnstyle"></a> business_unit_msdyncrm_columnstyle

Many-To-One Relationship: [msdyncrm_columnstyle business_unit_msdyncrm_columnstyle](msdyncrm_columnstyle.md#BKMK_business_unit_msdyncrm_columnstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_columnstyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_columnstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_contentblockstyle"></a> business_unit_msdyncrm_contentblockstyle

Many-To-One Relationship: [msdyncrm_contentblockstyle business_unit_msdyncrm_contentblockstyle](msdyncrm_contentblockstyle.md#BKMK_business_unit_msdyncrm_contentblockstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentblockstyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_contentblockstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_dividerstyle"></a> business_unit_msdyncrm_dividerstyle

Many-To-One Relationship: [msdyncrm_dividerstyle business_unit_msdyncrm_dividerstyle](msdyncrm_dividerstyle.md#BKMK_business_unit_msdyncrm_dividerstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_dividerstyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_dividerstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_generalstyles"></a> business_unit_msdyncrm_generalstyles

Many-To-One Relationship: [msdyncrm_generalstyles business_unit_msdyncrm_generalstyles](msdyncrm_generalstyles.md#BKMK_business_unit_msdyncrm_generalstyles)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_generalstyles`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_generalstyles`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_imagestyle"></a> business_unit_msdyncrm_imagestyle

Many-To-One Relationship: [msdyncrm_imagestyle business_unit_msdyncrm_imagestyle](msdyncrm_imagestyle.md#BKMK_business_unit_msdyncrm_imagestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_imagestyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_imagestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_layoutstyle"></a> business_unit_msdyncrm_layoutstyle

Many-To-One Relationship: [msdyncrm_layoutstyle business_unit_msdyncrm_layoutstyle](msdyncrm_layoutstyle.md#BKMK_business_unit_msdyncrm_layoutstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_layoutstyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_layoutstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_qrcodestyle"></a> business_unit_msdyncrm_qrcodestyle

Many-To-One Relationship: [msdyncrm_qrcodestyle business_unit_msdyncrm_qrcodestyle](msdyncrm_qrcodestyle.md#BKMK_business_unit_msdyncrm_qrcodestyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_qrcodestyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_qrcodestyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_textstyle"></a> business_unit_msdyncrm_textstyle

Many-To-One Relationship: [msdyncrm_textstyle business_unit_msdyncrm_textstyle](msdyncrm_textstyle.md#BKMK_business_unit_msdyncrm_textstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_textstyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_textstyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdyncrm_videostyle"></a> business_unit_msdyncrm_videostyle

Many-To-One Relationship: [msdyncrm_videostyle business_unit_msdyncrm_videostyle](msdyncrm_videostyle.md#BKMK_business_unit_msdyncrm_videostyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_videostyle`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdyncrm_videostyle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_byoacschannelinstance"></a> business_unit_msdynmkt_byoacschannelinstance

Many-To-One Relationship: [msdynmkt_byoacschannelinstance business_unit_msdynmkt_byoacschannelinstance](msdynmkt_byoacschannelinstance.md#BKMK_business_unit_msdynmkt_byoacschannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_byoacschannelinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_byoacschannelinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_byoacschannelinstanceaccount"></a> business_unit_msdynmkt_byoacschannelinstanceaccount

Many-To-One Relationship: [msdynmkt_byoacschannelinstanceaccount business_unit_msdynmkt_byoacschannelinstanceaccount](msdynmkt_byoacschannelinstanceaccount.md#BKMK_business_unit_msdynmkt_byoacschannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_byoacschannelinstanceaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_byoacschannelinstanceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_catalogeventstatusconfiguration"></a> business_unit_msdynmkt_catalogeventstatusconfiguration

Many-To-One Relationship: [msdynmkt_catalogeventstatusconfiguration business_unit_msdynmkt_catalogeventstatusconfiguration](msdynmkt_catalogeventstatusconfiguration.md#BKMK_business_unit_msdynmkt_catalogeventstatusconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_catalogeventstatusconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_catalogeventstatusconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_configuration"></a> business_unit_msdynmkt_configuration

Many-To-One Relationship: [msdynmkt_configuration business_unit_msdynmkt_configuration](msdynmkt_configuration.md#BKMK_business_unit_msdynmkt_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_configuration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_eventmetadata"></a> business_unit_msdynmkt_eventmetadata

Many-To-One Relationship: [msdynmkt_eventmetadata business_unit_msdynmkt_eventmetadata](msdynmkt_eventmetadata.md#BKMK_business_unit_msdynmkt_eventmetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventmetadata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_eventmetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_eventparametermetadata"></a> business_unit_msdynmkt_eventparametermetadata

Many-To-One Relationship: [msdynmkt_eventparametermetadata business_unit_msdynmkt_eventparametermetadata](msdynmkt_eventparametermetadata.md#BKMK_business_unit_msdynmkt_eventparametermetadata)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_eventparametermetadata`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_eventparametermetadata`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_featureconfiguration"></a> business_unit_msdynmkt_featureconfiguration

Many-To-One Relationship: [msdynmkt_featureconfiguration business_unit_msdynmkt_featureconfiguration](msdynmkt_featureconfiguration.md#BKMK_business_unit_msdynmkt_featureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_featureconfiguration`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_featureconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_infobipchannelinstance"></a> business_unit_msdynmkt_infobipchannelinstance

Many-To-One Relationship: [msdynmkt_infobipchannelinstance business_unit_msdynmkt_infobipchannelinstance](msdynmkt_infobipchannelinstance.md#BKMK_business_unit_msdynmkt_infobipchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_infobipchannelinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_infobipchannelinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_infobipchannelinstanceaccount"></a> business_unit_msdynmkt_infobipchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_infobipchannelinstanceaccount business_unit_msdynmkt_infobipchannelinstanceaccount](msdynmkt_infobipchannelinstanceaccount.md#BKMK_business_unit_msdynmkt_infobipchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_infobipchannelinstanceaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_infobipchannelinstanceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_linkmobilitychannelinstance"></a> business_unit_msdynmkt_linkmobilitychannelinstance

Many-To-One Relationship: [msdynmkt_linkmobilitychannelinstance business_unit_msdynmkt_linkmobilitychannelinstance](msdynmkt_linkmobilitychannelinstance.md#BKMK_business_unit_msdynmkt_linkmobilitychannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_linkmobilitychannelinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_linkmobilitychannelinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_linkmobilitychannelinstanceaccount"></a> business_unit_msdynmkt_linkmobilitychannelinstanceaccount

Many-To-One Relationship: [msdynmkt_linkmobilitychannelinstanceaccount business_unit_msdynmkt_linkmobilitychannelinstanceaccount](msdynmkt_linkmobilitychannelinstanceaccount.md#BKMK_business_unit_msdynmkt_linkmobilitychannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_linkmobilitychannelinstanceaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_linkmobilitychannelinstanceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_metadataentityrelationship"></a> business_unit_msdynmkt_metadataentityrelationship

Many-To-One Relationship: [msdynmkt_metadataentityrelationship business_unit_msdynmkt_metadataentityrelationship](msdynmkt_metadataentityrelationship.md#BKMK_business_unit_msdynmkt_metadataentityrelationship)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadataentityrelationship`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_metadataentityrelationship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_metadataitem"></a> business_unit_msdynmkt_metadataitem

Many-To-One Relationship: [msdynmkt_metadataitem business_unit_msdynmkt_metadataitem](msdynmkt_metadataitem.md#BKMK_business_unit_msdynmkt_metadataitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadataitem`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_metadataitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_metadatastorestate"></a> business_unit_msdynmkt_metadatastorestate

Many-To-One Relationship: [msdynmkt_metadatastorestate business_unit_msdynmkt_metadatastorestate](msdynmkt_metadatastorestate.md#BKMK_business_unit_msdynmkt_metadatastorestate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_metadatastorestate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_metadatastorestate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstance"></a> business_unit_msdynmkt_mocksmsproviderchannelinstance

Many-To-One Relationship: [msdynmkt_mocksmsproviderchannelinstance business_unit_msdynmkt_mocksmsproviderchannelinstance](msdynmkt_mocksmsproviderchannelinstance.md#BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mocksmsproviderchannelinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_mocksmsproviderchannelinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount"></a> business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_mocksmsproviderchannelinstanceaccount business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount](msdynmkt_mocksmsproviderchannelinstanceaccount.md#BKMK_business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mocksmsproviderchannelinstanceaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_mocksmsproviderchannelinstanceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_predefinedplaceholder"></a> business_unit_msdynmkt_predefinedplaceholder

Many-To-One Relationship: [msdynmkt_predefinedplaceholder business_unit_msdynmkt_predefinedplaceholder](msdynmkt_predefinedplaceholder.md#BKMK_business_unit_msdynmkt_predefinedplaceholder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_predefinedplaceholder`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_predefinedplaceholder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_telesignchannelinstance"></a> business_unit_msdynmkt_telesignchannelinstance

Many-To-One Relationship: [msdynmkt_telesignchannelinstance business_unit_msdynmkt_telesignchannelinstance](msdynmkt_telesignchannelinstance.md#BKMK_business_unit_msdynmkt_telesignchannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_telesignchannelinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_telesignchannelinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_telesignchannelinstanceaccount"></a> business_unit_msdynmkt_telesignchannelinstanceaccount

Many-To-One Relationship: [msdynmkt_telesignchannelinstanceaccount business_unit_msdynmkt_telesignchannelinstanceaccount](msdynmkt_telesignchannelinstanceaccount.md#BKMK_business_unit_msdynmkt_telesignchannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_telesignchannelinstanceaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_telesignchannelinstanceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_twiliochannelinstance"></a> business_unit_msdynmkt_twiliochannelinstance

Many-To-One Relationship: [msdynmkt_twiliochannelinstance business_unit_msdynmkt_twiliochannelinstance](msdynmkt_twiliochannelinstance.md#BKMK_business_unit_msdynmkt_twiliochannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_twiliochannelinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_twiliochannelinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_twiliochannelinstanceaccount"></a> business_unit_msdynmkt_twiliochannelinstanceaccount

Many-To-One Relationship: [msdynmkt_twiliochannelinstanceaccount business_unit_msdynmkt_twiliochannelinstanceaccount](msdynmkt_twiliochannelinstanceaccount.md#BKMK_business_unit_msdynmkt_twiliochannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_twiliochannelinstanceaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_twiliochannelinstanceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_vibeschannelinstance"></a> business_unit_msdynmkt_vibeschannelinstance

Many-To-One Relationship: [msdynmkt_vibeschannelinstance business_unit_msdynmkt_vibeschannelinstance](msdynmkt_vibeschannelinstance.md#BKMK_business_unit_msdynmkt_vibeschannelinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_vibeschannelinstance`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_vibeschannelinstance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msdynmkt_vibeschannelinstanceaccount"></a> business_unit_msdynmkt_vibeschannelinstanceaccount

Many-To-One Relationship: [msdynmkt_vibeschannelinstanceaccount business_unit_msdynmkt_vibeschannelinstanceaccount](msdynmkt_vibeschannelinstanceaccount.md#BKMK_business_unit_msdynmkt_vibeschannelinstanceaccount)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_vibeschannelinstanceaccount`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msdynmkt_vibeschannelinstanceaccount`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_alertrule"></a> business_unit_msfp_alertrule

Many-To-One Relationship: [msfp_alertrule business_unit_msfp_alertrule](msfp_alertrule.md#BKMK_business_unit_msfp_alertrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alertrule`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_alertrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_emailtemplate"></a> business_unit_msfp_emailtemplate

Many-To-One Relationship: [msfp_emailtemplate business_unit_msfp_emailtemplate](msfp_emailtemplate.md#BKMK_business_unit_msfp_emailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_emailtemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_emailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_fileresponse"></a> business_unit_msfp_fileresponse

Many-To-One Relationship: [msfp_fileresponse business_unit_msfp_fileresponse](msfp_fileresponse.md#BKMK_business_unit_msfp_fileresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_fileresponse`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_fileresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_localizedemailtemplate"></a> business_unit_msfp_localizedemailtemplate

Many-To-One Relationship: [msfp_localizedemailtemplate business_unit_msfp_localizedemailtemplate](msfp_localizedemailtemplate.md#BKMK_business_unit_msfp_localizedemailtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_localizedemailtemplate`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_localizedemailtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_project"></a> business_unit_msfp_project

Many-To-One Relationship: [msfp_project business_unit_msfp_project](msfp_project.md#BKMK_business_unit_msfp_project)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_project`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_project`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_question"></a> business_unit_msfp_question

Many-To-One Relationship: [msfp_question business_unit_msfp_question](msfp_question.md#BKMK_business_unit_msfp_question)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_question`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_question`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_questionresponse"></a> business_unit_msfp_questionresponse

Many-To-One Relationship: [msfp_questionresponse business_unit_msfp_questionresponse](msfp_questionresponse.md#BKMK_business_unit_msfp_questionresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_questionresponse`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_questionresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_satisfactionmetric"></a> business_unit_msfp_satisfactionmetric

Many-To-One Relationship: [msfp_satisfactionmetric business_unit_msfp_satisfactionmetric](msfp_satisfactionmetric.md#BKMK_business_unit_msfp_satisfactionmetric)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_satisfactionmetric`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_satisfactionmetric`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_survey"></a> business_unit_msfp_survey

Many-To-One Relationship: [msfp_survey business_unit_msfp_survey](msfp_survey.md#BKMK_business_unit_msfp_survey)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_survey`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_survey`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_surveyreminder"></a> business_unit_msfp_surveyreminder

Many-To-One Relationship: [msfp_surveyreminder business_unit_msfp_surveyreminder](msfp_surveyreminder.md#BKMK_business_unit_msfp_surveyreminder)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyreminder`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_surveyreminder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_msfp_unsubscribedrecipient"></a> business_unit_msfp_unsubscribedrecipient

Many-To-One Relationship: [msfp_unsubscribedrecipient business_unit_msfp_unsubscribedrecipient](msfp_unsubscribedrecipient.md#BKMK_business_unit_msfp_unsubscribedrecipient)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_unsubscribedrecipient`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_msfp_unsubscribedrecipient`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_opportunities"></a> business_unit_opportunities

Many-To-One Relationship: [opportunity business_unit_opportunities](opportunity.md#BKMK_business_unit_opportunities)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_opportunities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_opportunity_close_activities"></a> business_unit_opportunity_close_activities

Many-To-One Relationship: [opportunityclose business_unit_opportunity_close_activities](opportunityclose.md#BKMK_business_unit_opportunity_close_activities)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_opportunity_close_activities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_order_close_activities"></a> business_unit_order_close_activities

Many-To-One Relationship: [orderclose business_unit_order_close_activities](orderclose.md#BKMK_business_unit_order_close_activities)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_order_close_activities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_orders"></a> business_unit_orders

Many-To-One Relationship: [salesorder business_unit_orders](salesorder.md#BKMK_business_unit_orders)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_orders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_quote_close_activities"></a> business_unit_quote_close_activities

Many-To-One Relationship: [quoteclose business_unit_quote_close_activities](quoteclose.md#BKMK_business_unit_quote_close_activities)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_quote_close_activities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_quotes"></a> business_unit_quotes

Many-To-One Relationship: [quote business_unit_quotes](quote.md#BKMK_business_unit_quotes)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_quotes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_ratingmodel"></a> business_unit_ratingmodel

Many-To-One Relationship: [ratingmodel business_unit_ratingmodel](ratingmodel.md#BKMK_business_unit_ratingmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`ratingmodel`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_ratingmodel`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_ratingvalue"></a> business_unit_ratingvalue

Many-To-One Relationship: [ratingvalue business_unit_ratingvalue](ratingvalue.md#BKMK_business_unit_ratingvalue)

|Property|Value|
|---|---|
|ReferencingEntity|`ratingvalue`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_ratingvalue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_resource_groups"></a> business_unit_resource_groups

Many-To-One Relationship: [resourcegroup business_unit_resource_groups](resourcegroup.md#BKMK_business_unit_resource_groups)

|Property|Value|
|---|---|
|ReferencingEntity|`resourcegroup`|
|ReferencingAttribute|`businessunitid`|
|ReferencedEntityNavigationPropertyName|`business_unit_resource_groups`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_resource_specs"></a> business_unit_resource_specs

Many-To-One Relationship: [resourcespec business_unit_resource_specs](resourcespec.md#BKMK_business_unit_resource_specs)

|Property|Value|
|---|---|
|ReferencingEntity|`resourcespec`|
|ReferencingAttribute|`businessunitid`|
|ReferencedEntityNavigationPropertyName|`business_unit_resource_specs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_resources"></a> business_unit_resources

Many-To-One Relationship: [resource business_unit_resources](resource.md#BKMK_business_unit_resources)

|Property|Value|
|---|---|
|ReferencingEntity|`resource`|
|ReferencingAttribute|`businessunitid`|
|ReferencedEntityNavigationPropertyName|`business_unit_resources`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_service_appointments"></a> business_unit_service_appointments

Many-To-One Relationship: [serviceappointment business_unit_service_appointments](serviceappointment.md#BKMK_business_unit_service_appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_service_appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_business_unit_service_contracts"></a> business_unit_service_contracts

Many-To-One Relationship: [contract business_unit_service_contracts](contract.md#BKMK_business_unit_service_contracts)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`business_unit_service_contracts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_BusinessUnit_Campaigns"></a> BusinessUnit_Campaigns

Many-To-One Relationship: [campaign BusinessUnit_Campaigns](campaign.md#BKMK_BusinessUnit_Campaigns)

|Property|Value|
|---|---|
|ReferencingEntity|`campaign`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`BusinessUnit_Campaigns`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilottranscript_businessunit_owningbusinessunit"></a> msdyn_copilottranscript_businessunit_owningbusinessunit

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_businessunit_owningbusinessunit](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_businessunit_owningbusinessunit"></a> msdyn_ocliveworkitem_businessunit_owningbusinessunit

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_businessunit_owningbusinessunit](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_businessunit_owningbusinessunit"></a> msdyn_ocsession_businessunit_owningbusinessunit

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_businessunit_owningbusinessunit](msdyn_ocsession.md#BKMK_msdyn_ocsession_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_alert_businessunit_owningbusinessunit"></a> msfp_alert_businessunit_owningbusinessunit

Many-To-One Relationship: [msfp_alert msfp_alert_businessunit_owningbusinessunit](msfp_alert.md#BKMK_msfp_alert_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyinvite_businessunit_owningbusinessunit"></a> msfp_surveyinvite_businessunit_owningbusinessunit

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_businessunit_owningbusinessunit](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyresponse_businessunit_owningbusinessunit"></a> msfp_surveyresponse_businessunit_owningbusinessunit

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_businessunit_owningbusinessunit](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_businessunit_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_businessunit_owningbusinessunit`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.businessunit?displayProperty=fullName>
