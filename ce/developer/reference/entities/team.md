---
title: "Team table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Team table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Team table/entity reference (Microsoft Dynamics 365)

Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.

> [!NOTE]
> The Microsoft Dynamics 365 Team table extends the [Microsoft Dataverse Team table](/power-apps/developer/data-platform/reference/entities/team).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/team#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|opportunity|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

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

- [lead_owning_team](#BKMK_lead_owning_team)
- [msdyn_copilottranscript_team_owningteam](#BKMK_msdyn_copilottranscript_team_owningteam)
- [msdyn_ocliveworkitem_team_owningteam](#BKMK_msdyn_ocliveworkitem_team_owningteam)
- [msdyn_ocsession_team_owningteam](#BKMK_msdyn_ocsession_team_owningteam)
- [msdyn_team_msdyn_salesroutingrun_ownerassigned](#BKMK_msdyn_team_msdyn_salesroutingrun_ownerassigned)
- [msdyn_team_msdyn_salesroutingrun_previousowner](#BKMK_msdyn_team_msdyn_salesroutingrun_previousowner)
- [msfp_alert_team_owningteam](#BKMK_msfp_alert_team_owningteam)
- [msfp_surveyinvite_team_owningteam](#BKMK_msfp_surveyinvite_team_owningteam)
- [msfp_surveyresponse_team_owningteam](#BKMK_msfp_surveyresponse_team_owningteam)
- [team_activitymonitor](#BKMK_team_activitymonitor)
- [team_adminsettingsentity](#BKMK_team_adminsettingsentity)
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
- [team_incidentresolution](#BKMK_team_incidentresolution)
- [team_incidents](#BKMK_team_incidents)
- [team_invoicedetail](#BKMK_team_invoicedetail)
- [team_invoices](#BKMK_team_invoices)
- [team_knowledgearticleincident](#BKMK_team_knowledgearticleincident)
- [team_list](#BKMK_team_list)
- [team_listoperation](#BKMK_team_listoperation)
- [team_msdyn_actioncardactionstat](#BKMK_team_msdyn_actioncardactionstat)
- [team_msdyn_actioncardregarding](#BKMK_team_msdyn_actioncardregarding)
- [team_msdyn_actioncardrolesetting](#BKMK_team_msdyn_actioncardrolesetting)
- [team_msdyn_actioncardstataggregation](#BKMK_team_msdyn_actioncardstataggregation)
- [team_msdyn_activeicdextension](#BKMK_team_msdyn_activeicdextension)
- [team_msdyn_adminappstate](#BKMK_team_msdyn_adminappstate)
- [team_msdyn_agentcapacityprofileunit](#BKMK_team_msdyn_agentcapacityprofileunit)
- [team_msdyn_agentcapacityupdatehistory](#BKMK_team_msdyn_agentcapacityupdatehistory)
- [team_msdyn_agentchannelstate](#BKMK_team_msdyn_agentchannelstate)
- [team_msdyn_agentgroup](#BKMK_team_msdyn_agentgroup)
- [team_msdyn_agentgrouplanguage](#BKMK_team_msdyn_agentgrouplanguage)
- [team_msdyn_agentgroupmembership](#BKMK_team_msdyn_agentgroupmembership)
- [team_msdyn_agentgroupregion](#BKMK_team_msdyn_agentgroupregion)
- [team_msdyn_agentlanguage](#BKMK_team_msdyn_agentlanguage)
- [team_msdyn_agentregion](#BKMK_team_msdyn_agentregion)
- [team_msdyn_agentstatus](#BKMK_team_msdyn_agentstatus)
- [team_msdyn_agentstatushistory](#BKMK_team_msdyn_agentstatushistory)
- [team_msdyn_aicontactsuggestion](#BKMK_team_msdyn_aicontactsuggestion)
- [team_msdyn_analytics](#BKMK_team_msdyn_analytics)
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
- [team_msdyn_bookableresourcecapacityprofile](#BKMK_team_msdyn_bookableresourcecapacityprofile)
- [team_msdyn_botsession](#BKMK_team_msdyn_botsession)
- [team_msdyn_capacityprofile](#BKMK_team_msdyn_capacityprofile)
- [team_msdyn_cdsentityengagementctx](#BKMK_team_msdyn_cdsentityengagementctx)
- [team_msdyn_channeldefinition](#BKMK_team_msdyn_channeldefinition)
- [team_msdyn_channeldefinitionconsent](#BKMK_team_msdyn_channeldefinitionconsent)
- [team_msdyn_channeldefinitionlocale](#BKMK_team_msdyn_channeldefinitionlocale)
- [team_msdyn_channelinstance](#BKMK_team_msdyn_channelinstance)
- [team_msdyn_channelinstanceaccount](#BKMK_team_msdyn_channelinstanceaccount)
- [team_msdyn_channelmessageattachment](#BKMK_team_msdyn_channelmessageattachment)
- [team_msdyn_channelmessagecontextpart](#BKMK_team_msdyn_channelmessagecontextpart)
- [team_msdyn_channelmessagepart](#BKMK_team_msdyn_channelmessagepart)
- [team_msdyn_channelprovider](#BKMK_team_msdyn_channelprovider)
- [team_msdyn_consumingapplication](#BKMK_team_msdyn_consumingapplication)
- [team_msdyn_contactsuggestionrule](#BKMK_team_msdyn_contactsuggestionrule)
- [team_msdyn_contactsuggestionruleset](#BKMK_team_msdyn_contactsuggestionruleset)
- [team_msdyn_conversationaction](#BKMK_team_msdyn_conversationaction)
- [team_msdyn_conversationactionitem](#BKMK_team_msdyn_conversationactionitem)
- [team_msdyn_conversationactionlocale](#BKMK_team_msdyn_conversationactionlocale)
- [team_msdyn_conversationaggregatedinsights](#BKMK_team_msdyn_conversationaggregatedinsights)
- [team_msdyn_conversationcomment](#BKMK_team_msdyn_conversationcomment)
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
- [team_msdyn_copilotcaseformfillsetting](#BKMK_team_msdyn_copilotcaseformfillsetting)
- [team_msdyn_copilotinteractiondata](#BKMK_team_msdyn_copilotinteractiondata)
- [team_msdyn_copilottranscriptdata](#BKMK_team_msdyn_copilottranscriptdata)
- [team_msdyn_crmconnection](#BKMK_team_msdyn_crmconnection)
- [team_msdyn_csadminconfig](#BKMK_team_msdyn_csadminconfig)
- [team_msdyn_customapirulesetconfiguration](#BKMK_team_msdyn_customapirulesetconfiguration)
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
- [team_msdyn_deletedconversation](#BKMK_team_msdyn_deletedconversation)
- [team_msdyn_duplicateleadmapping](#BKMK_team_msdyn_duplicateleadmapping)
- [team_msdyn_effortpredictionresult](#BKMK_team_msdyn_effortpredictionresult)
- [team_msdyn_emailsentiment](#BKMK_team_msdyn_emailsentiment)
- [team_msdyn_entityattachment](#BKMK_team_msdyn_entityattachment)
- [team_msdyn_entityattributepredictionrule](#BKMK_team_msdyn_entityattributepredictionrule)
- [team_msdyn_entityrankingrule](#BKMK_team_msdyn_entityrankingrule)
- [team_msdyn_entityroutingconfiguration](#BKMK_team_msdyn_entityroutingconfiguration)
- [team_msdyn_entityworkstreammap](#BKMK_team_msdyn_entityworkstreammap)
- [team_msdyn_extendedusersetting](#BKMK_team_msdyn_extendedusersetting)
- [team_msdyn_externalcrm](#BKMK_team_msdyn_externalcrm)
- [team_msdyn_externalrecord](#BKMK_team_msdyn_externalrecord)
- [team_msdyn_flowcardtype](#BKMK_team_msdyn_flowcardtype)
- [team_msdyn_forecastconfiguration](#BKMK_team_msdyn_forecastconfiguration)
- [team_msdyn_forecastdefinition](#BKMK_team_msdyn_forecastdefinition)
- [team_msdyn_forecastinstance](#BKMK_team_msdyn_forecastinstance)
- [team_msdyn_forecastrecurrence](#BKMK_team_msdyn_forecastrecurrence)
- [team_msdyn_functionallocation](#BKMK_team_msdyn_functionallocation)
- [team_msdyn_functionallocationtype](#BKMK_team_msdyn_functionallocationtype)
- [team_msdyn_gdprdata](#BKMK_team_msdyn_gdprdata)
- [team_msdyn_icdextension](#BKMK_team_msdyn_icdextension)
- [team_msdyn_icebreakersconfig](#BKMK_team_msdyn_icebreakersconfig)
- [team_msdyn_iermlmodel](#BKMK_team_msdyn_iermlmodel)
- [team_msdyn_iermltraining](#BKMK_team_msdyn_iermltraining)
- [team_msdyn_intent](#BKMK_team_msdyn_intent)
- [team_msdyn_intentattribute](#BKMK_team_msdyn_intentattribute)
- [team_msdyn_intentattribute_entity](#BKMK_team_msdyn_intentattribute_entity)
- [team_msdyn_intentattributeset](#BKMK_team_msdyn_intentattributeset)
- [team_msdyn_intentconfig](#BKMK_team_msdyn_intentconfig)
- [team_msdyn_intententity](#BKMK_team_msdyn_intententity)
- [team_msdyn_intententity_backfillstatus](#BKMK_team_msdyn_intententity_backfillstatus)
- [team_msdyn_intentfamily](#BKMK_team_msdyn_intentfamily)
- [team_msdyn_intentfeature_configuration](#BKMK_team_msdyn_intentfeature_configuration)
- [team_msdyn_intentgroupcondition](#BKMK_team_msdyn_intentgroupcondition)
- [team_msdyn_intentsolutionmap](#BKMK_team_msdyn_intentsolutionmap)
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
- [team_msdyn_kpieventdata](#BKMK_team_msdyn_kpieventdata)
- [team_msdyn_kpieventdefinition](#BKMK_team_msdyn_kpieventdefinition)
- [team_msdyn_language](#BKMK_team_msdyn_language)
- [team_msdyn_leadmodelconfig](#BKMK_team_msdyn_leadmodelconfig)
- [team_msdyn_liveworkitemevent](#BKMK_team_msdyn_liveworkitemevent)
- [team_msdyn_liveworkstream](#BKMK_team_msdyn_liveworkstream)
- [team_msdyn_liveworkstreamcapacityprofile](#BKMK_team_msdyn_liveworkstreamcapacityprofile)
- [team_msdyn_locationtemplateassociation](#BKMK_team_msdyn_locationtemplateassociation)
- [team_msdyn_locationtypetemplateassociation](#BKMK_team_msdyn_locationtypetemplateassociation)
- [team_msdyn_lockstatus](#BKMK_team_msdyn_lockstatus)
- [team_msdyn_macrosession](#BKMK_team_msdyn_macrosession)
- [team_msdyn_masterentityroutingconfiguration](#BKMK_team_msdyn_masterentityroutingconfiguration)
- [team_msdyn_migrationtracker](#BKMK_team_msdyn_migrationtracker)
- [team_msdyn_modelpreviewstatus](#BKMK_team_msdyn_modelpreviewstatus)
- [team_msdyn_notesanalysisconfig](#BKMK_team_msdyn_notesanalysisconfig)
- [team_msdyn_notificationfield](#BKMK_team_msdyn_notificationfield)
- [team_msdyn_notificationtemplate](#BKMK_team_msdyn_notificationtemplate)
- [team_msdyn_oc_geolocationprovider](#BKMK_team_msdyn_oc_geolocationprovider)
- [team_msdyn_ocagentassignedcustomapiprivilege](#BKMK_team_msdyn_ocagentassignedcustomapiprivilege)
- [team_msdyn_ocautoblockrule](#BKMK_team_msdyn_ocautoblockrule)
- [team_msdyn_ocautomatedactionrule](#BKMK_team_msdyn_ocautomatedactionrule)
- [team_msdyn_ocautomatedactionrulesmapping](#BKMK_team_msdyn_ocautomatedactionrulesmapping)
- [team_msdyn_ocbotchannelregistration](#BKMK_team_msdyn_ocbotchannelregistration)
- [team_msdyn_ocbotchannelregistrationsecret](#BKMK_team_msdyn_ocbotchannelregistrationsecret)
- [team_msdyn_occhannelapiconversationprivilege](#BKMK_team_msdyn_occhannelapiconversationprivilege)
- [team_msdyn_occhannelapimessageprivilege](#BKMK_team_msdyn_occhannelapimessageprivilege)
- [team_msdyn_occhannelapimethodmapping](#BKMK_team_msdyn_occhannelapimethodmapping)
- [team_msdyn_ocexternalcontext](#BKMK_team_msdyn_ocexternalcontext)
- [team_msdyn_ocflaggedspam](#BKMK_team_msdyn_ocflaggedspam)
- [team_msdyn_oclanguage](#BKMK_team_msdyn_oclanguage)
- [team_msdyn_ocliveworkitemcapacityprofile](#BKMK_team_msdyn_ocliveworkitemcapacityprofile)
- [team_msdyn_ocliveworkitemcharacteristic](#BKMK_team_msdyn_ocliveworkitemcharacteristic)
- [team_msdyn_ocliveworkitemcontextitem](#BKMK_team_msdyn_ocliveworkitemcontextitem)
- [team_msdyn_ocliveworkitemsentiment](#BKMK_team_msdyn_ocliveworkitemsentiment)
- [team_msdyn_ocliveworkstreamcontextvariable](#BKMK_team_msdyn_ocliveworkstreamcontextvariable)
- [team_msdyn_ocpaymentprofile](#BKMK_team_msdyn_ocpaymentprofile)
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
- [team_msdyn_omnichannelpersonalization](#BKMK_team_msdyn_omnichannelpersonalization)
- [team_msdyn_omnichannelsyncconfig](#BKMK_team_msdyn_omnichannelsyncconfig)
- [team_msdyn_operatinghour](#BKMK_team_msdyn_operatinghour)
- [team_msdyn_opportunitymodelconfig](#BKMK_team_msdyn_opportunitymodelconfig)
- [team_msdyn_orgchartnode](#BKMK_team_msdyn_orgchartnode)
- [team_msdyn_overflowactionconfig](#BKMK_team_msdyn_overflowactionconfig)
- [team_msdyn_personalmessage](#BKMK_team_msdyn_personalmessage)
- [team_msdyn_personalsoundsetting](#BKMK_team_msdyn_personalsoundsetting)
- [team_msdyn_postalbum](#BKMK_team_msdyn_postalbum)
- [team_msdyn_predictioncomputationoperation](#BKMK_team_msdyn_predictioncomputationoperation)
- [team_msdyn_predictionmodelstatus](#BKMK_team_msdyn_predictionmodelstatus)
- [team_msdyn_predictionscheduledoperation](#BKMK_team_msdyn_predictionscheduledoperation)
- [team_msdyn_predictivescoringsyncstatus](#BKMK_team_msdyn_predictivescoringsyncstatus)
- [team_msdyn_preferredagent](#BKMK_team_msdyn_preferredagent)
- [team_msdyn_preferredagentcustomeridentity](#BKMK_team_msdyn_preferredagentcustomeridentity)
- [team_msdyn_preferredagentroutedentity](#BKMK_team_msdyn_preferredagentroutedentity)
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
- [team_msdyn_rawinsight](#BKMK_team_msdyn_rawinsight)
- [team_msdyn_readtracker](#BKMK_team_msdyn_readtracker)
- [team_msdyn_realtimescoring](#BKMK_team_msdyn_realtimescoring)
- [team_msdyn_realtimescoringoperation](#BKMK_team_msdyn_realtimescoringoperation)
- [team_msdyn_region](#BKMK_team_msdyn_region)
- [team_msdyn_reportbookmark](#BKMK_team_msdyn_reportbookmark)
- [team_msdyn_routingconfiguration](#BKMK_team_msdyn_routingconfiguration)
- [team_msdyn_routingconfigurationstep](#BKMK_team_msdyn_routingconfigurationstep)
- [team_msdyn_routingrequest](#BKMK_team_msdyn_routingrequest)
- [team_msdyn_salescopilotemailinsight](#BKMK_team_msdyn_salescopilotemailinsight)
- [team_msdyn_salescopilotinsight](#BKMK_team_msdyn_salescopilotinsight)
- [team_msdyn_salescopilotinsightcardstate](#BKMK_team_msdyn_salescopilotinsightcardstate)
- [team_msdyn_salesinsightssettings](#BKMK_team_msdyn_salesinsightssettings)
- [team_msdyn_salesocmessage](#BKMK_team_msdyn_salesocmessage)
- [team_msdyn_salesocsmstemplate](#BKMK_team_msdyn_salesocsmstemplate)
- [team_msdyn_salesroutingrun](#BKMK_team_msdyn_salesroutingrun)
- [team_msdyn_salessuggestion](#BKMK_team_msdyn_salessuggestion)
- [team_msdyn_salestag](#BKMK_team_msdyn_salestag)
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
- [team_msdyn_sessionevent](#BKMK_team_msdyn_sessionevent)
- [team_msdyn_sessionparticipant](#BKMK_team_msdyn_sessionparticipant)
- [team_msdyn_sessiontemplate](#BKMK_team_msdyn_sessiontemplate)
- [team_msdyn_siconfig](#BKMK_team_msdyn_siconfig)
- [team_msdyn_skillattachmentruleitem](#BKMK_team_msdyn_skillattachmentruleitem)
- [team_msdyn_skillattachmenttarget](#BKMK_team_msdyn_skillattachmenttarget)
- [team_msdyn_soundnotificationsetting](#BKMK_team_msdyn_soundnotificationsetting)
- [team_msdyn_submodeldefinition](#BKMK_team_msdyn_submodeldefinition)
- [team_msdyn_suggestionassignmentrule](#BKMK_team_msdyn_suggestionassignmentrule)
- [team_msdyn_suggestionprincipalobjectaccess](#BKMK_team_msdyn_suggestionprincipalobjectaccess)
- [team_msdyn_suggestionsellerpriority](#BKMK_team_msdyn_suggestionsellerpriority)
- [team_msdyn_swarm](#BKMK_team_msdyn_swarm)
- [team_msdyn_swarmparticipant](#BKMK_team_msdyn_swarmparticipant)
- [team_msdyn_swarmparticipantrule](#BKMK_team_msdyn_swarmparticipantrule)
- [team_msdyn_swarmrole](#BKMK_team_msdyn_swarmrole)
- [team_msdyn_swarmskill](#BKMK_team_msdyn_swarmskill)
- [team_msdyn_swarmtemplate](#BKMK_team_msdyn_swarmtemplate)
- [team_msdyn_taggedrecord](#BKMK_team_msdyn_taggedrecord)
- [team_msdyn_templateforproperties](#BKMK_team_msdyn_templateforproperties)
- [team_msdyn_templateparameter](#BKMK_team_msdyn_templateparameter)
- [team_msdyn_templateruleset](#BKMK_team_msdyn_templateruleset)
- [team_msdyn_timespent](#BKMK_team_msdyn_timespent)
- [team_msdyn_timetracker](#BKMK_team_msdyn_timetracker)
- [team_msdyn_trainingresult](#BKMK_team_msdyn_trainingresult)
- [team_msdyn_transcript](#BKMK_team_msdyn_transcript)
- [team_msdyn_unifiedroutingdiagnostic](#BKMK_team_msdyn_unifiedroutingdiagnostic)
- [team_msdyn_unifiedroutingrun](#BKMK_team_msdyn_unifiedroutingrun)
- [team_msdyn_untrackedappointment](#BKMK_team_msdyn_untrackedappointment)
- [team_msdyn_urnotificationtemplate](#BKMK_team_msdyn_urnotificationtemplate)
- [team_msdyn_urnotificationtemplatemapping](#BKMK_team_msdyn_urnotificationtemplatemapping)
- [team_msdyn_visitorjourney](#BKMK_team_msdyn_visitorjourney)
- [team_msdyn_vivacustomerlist](#BKMK_team_msdyn_vivacustomerlist)
- [team_msdyn_wallsavedqueryusersettings](#BKMK_team_msdyn_wallsavedqueryusersettings)
- [team_msdyn_warranty](#BKMK_team_msdyn_warranty)
- [team_msdyn_wkwconfig](#BKMK_team_msdyn_wkwconfig)
- [team_msdyn_workqueuestate](#BKMK_team_msdyn_workqueuestate)
- [team_msdyn_workqueueusersetting](#BKMK_team_msdyn_workqueueusersetting)
- [team_msdyncrm_addtocalendarstyle](#BKMK_team_msdyncrm_addtocalendarstyle)
- [team_msdyncrm_basestyle](#BKMK_team_msdyncrm_basestyle)
- [team_msdyncrm_buttonstyle](#BKMK_team_msdyncrm_buttonstyle)
- [team_msdyncrm_codestyle](#BKMK_team_msdyncrm_codestyle)
- [team_msdyncrm_columnstyle](#BKMK_team_msdyncrm_columnstyle)
- [team_msdyncrm_contentblockstyle](#BKMK_team_msdyncrm_contentblockstyle)
- [team_msdyncrm_dividerstyle](#BKMK_team_msdyncrm_dividerstyle)
- [team_msdyncrm_generalstyles](#BKMK_team_msdyncrm_generalstyles)
- [team_msdyncrm_imagestyle](#BKMK_team_msdyncrm_imagestyle)
- [team_msdyncrm_layoutstyle](#BKMK_team_msdyncrm_layoutstyle)
- [team_msdyncrm_qrcodestyle](#BKMK_team_msdyncrm_qrcodestyle)
- [team_msdyncrm_textstyle](#BKMK_team_msdyncrm_textstyle)
- [team_msdyncrm_videostyle](#BKMK_team_msdyncrm_videostyle)
- [team_msdynmkt_byoacschannelinstance](#BKMK_team_msdynmkt_byoacschannelinstance)
- [team_msdynmkt_byoacschannelinstanceaccount](#BKMK_team_msdynmkt_byoacschannelinstanceaccount)
- [team_msdynmkt_catalogeventstatusconfiguration](#BKMK_team_msdynmkt_catalogeventstatusconfiguration)
- [team_msdynmkt_configuration](#BKMK_team_msdynmkt_configuration)
- [team_msdynmkt_eventmetadata](#BKMK_team_msdynmkt_eventmetadata)
- [team_msdynmkt_eventparametermetadata](#BKMK_team_msdynmkt_eventparametermetadata)
- [team_msdynmkt_featureconfiguration](#BKMK_team_msdynmkt_featureconfiguration)
- [team_msdynmkt_infobipchannelinstance](#BKMK_team_msdynmkt_infobipchannelinstance)
- [team_msdynmkt_infobipchannelinstanceaccount](#BKMK_team_msdynmkt_infobipchannelinstanceaccount)
- [team_msdynmkt_linkmobilitychannelinstance](#BKMK_team_msdynmkt_linkmobilitychannelinstance)
- [team_msdynmkt_linkmobilitychannelinstanceaccount](#BKMK_team_msdynmkt_linkmobilitychannelinstanceaccount)
- [team_msdynmkt_metadataentityrelationship](#BKMK_team_msdynmkt_metadataentityrelationship)
- [team_msdynmkt_metadataitem](#BKMK_team_msdynmkt_metadataitem)
- [team_msdynmkt_metadatastorestate](#BKMK_team_msdynmkt_metadatastorestate)
- [team_msdynmkt_mocksmsproviderchannelinstance](#BKMK_team_msdynmkt_mocksmsproviderchannelinstance)
- [team_msdynmkt_mocksmsproviderchannelinstanceaccount](#BKMK_team_msdynmkt_mocksmsproviderchannelinstanceaccount)
- [team_msdynmkt_predefinedplaceholder](#BKMK_team_msdynmkt_predefinedplaceholder)
- [team_msdynmkt_telesignchannelinstance](#BKMK_team_msdynmkt_telesignchannelinstance)
- [team_msdynmkt_telesignchannelinstanceaccount](#BKMK_team_msdynmkt_telesignchannelinstanceaccount)
- [team_msdynmkt_twiliochannelinstance](#BKMK_team_msdynmkt_twiliochannelinstance)
- [team_msdynmkt_twiliochannelinstanceaccount](#BKMK_team_msdynmkt_twiliochannelinstanceaccount)
- [team_msdynmkt_vibeschannelinstance](#BKMK_team_msdynmkt_vibeschannelinstance)
- [team_msdynmkt_vibeschannelinstanceaccount](#BKMK_team_msdynmkt_vibeschannelinstanceaccount)
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
- [team_salesorderdetail](#BKMK_team_salesorderdetail)
- [team_service_appointments](#BKMK_team_service_appointments)
- [team_service_contracts](#BKMK_team_service_contracts)

### <a name="BKMK_lead_owning_team"></a> lead_owning_team

Many-To-One Relationship: [lead lead_owning_team](lead.md#BKMK_lead_owning_team)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`lead_owning_team`|
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

### <a name="BKMK_msdyn_ocsession_team_owningteam"></a> msdyn_ocsession_team_owningteam

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_team_owningteam](msdyn_ocsession.md#BKMK_msdyn_ocsession_team_owningteam)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_team_owningteam`|
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

### <a name="BKMK_team_msdyn_agentgroup"></a> team_msdyn_agentgroup

Many-To-One Relationship: [msdyn_agentgroup team_msdyn_agentgroup](msdyn_agentgroup.md#BKMK_team_msdyn_agentgroup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroup`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentgroup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentgrouplanguage"></a> team_msdyn_agentgrouplanguage

Many-To-One Relationship: [msdyn_agentgrouplanguage team_msdyn_agentgrouplanguage](msdyn_agentgrouplanguage.md#BKMK_team_msdyn_agentgrouplanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgrouplanguage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentgrouplanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentgroupmembership"></a> team_msdyn_agentgroupmembership

Many-To-One Relationship: [msdyn_agentgroupmembership team_msdyn_agentgroupmembership](msdyn_agentgroupmembership.md#BKMK_team_msdyn_agentgroupmembership)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroupmembership`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentgroupmembership`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentgroupregion"></a> team_msdyn_agentgroupregion

Many-To-One Relationship: [msdyn_agentgroupregion team_msdyn_agentgroupregion](msdyn_agentgroupregion.md#BKMK_team_msdyn_agentgroupregion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentgroupregion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentgroupregion`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentlanguage"></a> team_msdyn_agentlanguage

Many-To-One Relationship: [msdyn_agentlanguage team_msdyn_agentlanguage](msdyn_agentlanguage.md#BKMK_team_msdyn_agentlanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentlanguage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentlanguage`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_agentregion"></a> team_msdyn_agentregion

Many-To-One Relationship: [msdyn_agentregion team_msdyn_agentregion](msdyn_agentregion.md#BKMK_team_msdyn_agentregion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agentregion`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_agentregion`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_bookableresourcecapacityprofile"></a> team_msdyn_bookableresourcecapacityprofile

Many-To-One Relationship: [msdyn_bookableresourcecapacityprofile team_msdyn_bookableresourcecapacityprofile](msdyn_bookableresourcecapacityprofile.md#BKMK_team_msdyn_bookableresourcecapacityprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookableresourcecapacityprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_bookableresourcecapacityprofile`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_copilotcaseformfillsetting"></a> team_msdyn_copilotcaseformfillsetting

Many-To-One Relationship: [msdyn_copilotcaseformfillsetting team_msdyn_copilotcaseformfillsetting](msdyn_copilotcaseformfillsetting.md#BKMK_team_msdyn_copilotcaseformfillsetting)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilotcaseformfillsetting`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_copilotcaseformfillsetting`|
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

### <a name="BKMK_team_msdyn_deletedconversation"></a> team_msdyn_deletedconversation

Many-To-One Relationship: [msdyn_deletedconversation team_msdyn_deletedconversation](msdyn_deletedconversation.md#BKMK_team_msdyn_deletedconversation)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_deletedconversation`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_deletedconversation`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_emailsentiment"></a> team_msdyn_emailsentiment

Many-To-One Relationship: [msdyn_emailsentiment team_msdyn_emailsentiment](msdyn_emailsentiment.md#BKMK_team_msdyn_emailsentiment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_emailsentiment`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_emailsentiment`|
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

### <a name="BKMK_team_msdyn_entityattributepredictionrule"></a> team_msdyn_entityattributepredictionrule

Many-To-One Relationship: [msdyn_entityattributepredictionrule team_msdyn_entityattributepredictionrule](msdyn_entityattributepredictionrule.md#BKMK_team_msdyn_entityattributepredictionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entityattributepredictionrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_entityattributepredictionrule`|
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

### <a name="BKMK_team_msdyn_externalcrm"></a> team_msdyn_externalcrm

Many-To-One Relationship: [msdyn_externalcrm team_msdyn_externalcrm](msdyn_externalcrm.md#BKMK_team_msdyn_externalcrm)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_externalcrm`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_externalcrm`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_externalrecord"></a> team_msdyn_externalrecord

Many-To-One Relationship: [msdyn_externalrecord team_msdyn_externalrecord](msdyn_externalrecord.md#BKMK_team_msdyn_externalrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_externalrecord`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_externalrecord`|
|IsCustomizable|`True`|
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

### <a name="BKMK_team_msdyn_intent"></a> team_msdyn_intent

Many-To-One Relationship: [msdyn_intent team_msdyn_intent](msdyn_intent.md#BKMK_team_msdyn_intent)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intent`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intentattribute"></a> team_msdyn_intentattribute

Many-To-One Relationship: [msdyn_intentattribute team_msdyn_intentattribute](msdyn_intentattribute.md#BKMK_team_msdyn_intentattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattribute`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intentattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intentattribute_entity"></a> team_msdyn_intentattribute_entity

Many-To-One Relationship: [msdyn_intentattribute_entity team_msdyn_intentattribute_entity](msdyn_intentattribute_entity.md#BKMK_team_msdyn_intentattribute_entity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattribute_entity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intentattribute_entity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intentattributeset"></a> team_msdyn_intentattributeset

Many-To-One Relationship: [msdyn_intentattributeset team_msdyn_intentattributeset](msdyn_intentattributeset.md#BKMK_team_msdyn_intentattributeset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentattributeset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intentattributeset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intentconfig"></a> team_msdyn_intentconfig

Many-To-One Relationship: [msdyn_intentconfig team_msdyn_intentconfig](msdyn_intentconfig.md#BKMK_team_msdyn_intentconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intentconfig`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intententity"></a> team_msdyn_intententity

Many-To-One Relationship: [msdyn_intententity team_msdyn_intententity](msdyn_intententity.md#BKMK_team_msdyn_intententity)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intententity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intententity_backfillstatus"></a> team_msdyn_intententity_backfillstatus

Many-To-One Relationship: [msdyn_intententity_backfillstatus team_msdyn_intententity_backfillstatus](msdyn_intententity_backfillstatus.md#BKMK_team_msdyn_intententity_backfillstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intententity_backfillstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intententity_backfillstatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intentfamily"></a> team_msdyn_intentfamily

Many-To-One Relationship: [msdyn_intentfamily team_msdyn_intentfamily](msdyn_intentfamily.md#BKMK_team_msdyn_intentfamily)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentfamily`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intentfamily`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intentfeature_configuration"></a> team_msdyn_intentfeature_configuration

Many-To-One Relationship: [msdyn_intentfeature_configuration team_msdyn_intentfeature_configuration](msdyn_intentfeature_configuration.md#BKMK_team_msdyn_intentfeature_configuration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentfeature_configuration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intentfeature_configuration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intentgroupcondition"></a> team_msdyn_intentgroupcondition

Many-To-One Relationship: [msdyn_intentgroupcondition team_msdyn_intentgroupcondition](msdyn_intentgroupcondition.md#BKMK_team_msdyn_intentgroupcondition)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentgroupcondition`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intentgroupcondition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_intentsolutionmap"></a> team_msdyn_intentsolutionmap

Many-To-One Relationship: [msdyn_intentsolutionmap team_msdyn_intentsolutionmap](msdyn_intentsolutionmap.md#BKMK_team_msdyn_intentsolutionmap)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_intentsolutionmap`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_intentsolutionmap`|
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

### <a name="BKMK_team_msdyn_language"></a> team_msdyn_language

Many-To-One Relationship: [msdyn_language team_msdyn_language](msdyn_language.md#BKMK_team_msdyn_language)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_language`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_language`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_modelpreviewstatus"></a> team_msdyn_modelpreviewstatus

Many-To-One Relationship: [msdyn_modelpreviewstatus team_msdyn_modelpreviewstatus](msdyn_modelpreviewstatus.md#BKMK_team_msdyn_modelpreviewstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_modelpreviewstatus`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_modelpreviewstatus`|
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

### <a name="BKMK_team_msdyn_ocautoblockrule"></a> team_msdyn_ocautoblockrule

Many-To-One Relationship: [msdyn_ocautoblockrule team_msdyn_ocautoblockrule](msdyn_ocautoblockrule.md#BKMK_team_msdyn_ocautoblockrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautoblockrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocautoblockrule`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocautomatedactionrule"></a> team_msdyn_ocautomatedactionrule

Many-To-One Relationship: [msdyn_ocautomatedactionrule team_msdyn_ocautomatedactionrule](msdyn_ocautomatedactionrule.md#BKMK_team_msdyn_ocautomatedactionrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautomatedactionrule`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocautomatedactionrule`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_ocautomatedactionrulesmapping"></a> team_msdyn_ocautomatedactionrulesmapping

Many-To-One Relationship: [msdyn_ocautomatedactionrulesmapping team_msdyn_ocautomatedactionrulesmapping](msdyn_ocautomatedactionrulesmapping.md#BKMK_team_msdyn_ocautomatedactionrulesmapping)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocautomatedactionrulesmapping`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocautomatedactionrulesmapping`|
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

### <a name="BKMK_team_msdyn_ocexternalcontext"></a> team_msdyn_ocexternalcontext

Many-To-One Relationship: [msdyn_ocexternalcontext team_msdyn_ocexternalcontext](msdyn_ocexternalcontext.md#BKMK_team_msdyn_ocexternalcontext)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocexternalcontext`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocexternalcontext`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_oclanguage"></a> team_msdyn_oclanguage

Many-To-One Relationship: [msdyn_oclanguage team_msdyn_oclanguage](msdyn_oclanguage.md#BKMK_team_msdyn_oclanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_oclanguage`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_oclanguage`|
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

### <a name="BKMK_team_msdyn_ocpaymentprofile"></a> team_msdyn_ocpaymentprofile

Many-To-One Relationship: [msdyn_ocpaymentprofile team_msdyn_ocpaymentprofile](msdyn_ocpaymentprofile.md#BKMK_team_msdyn_ocpaymentprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocpaymentprofile`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_ocpaymentprofile`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_omnichannelpersonalization"></a> team_msdyn_omnichannelpersonalization

Many-To-One Relationship: [msdyn_omnichannelpersonalization team_msdyn_omnichannelpersonalization](msdyn_omnichannelpersonalization.md#BKMK_team_msdyn_omnichannelpersonalization)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_omnichannelpersonalization`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_omnichannelpersonalization`|
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

### <a name="BKMK_team_msdyn_postalbum"></a> team_msdyn_postalbum

Many-To-One Relationship: [msdyn_postalbum team_msdyn_postalbum](msdyn_postalbum.md#BKMK_team_msdyn_postalbum)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_postalbum`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_postalbum`|
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

### <a name="BKMK_team_msdyn_rawinsight"></a> team_msdyn_rawinsight

Many-To-One Relationship: [msdyn_rawinsight team_msdyn_rawinsight](msdyn_rawinsight.md#BKMK_team_msdyn_rawinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rawinsight`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_rawinsight`|
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

### <a name="BKMK_team_msdyn_region"></a> team_msdyn_region

Many-To-One Relationship: [msdyn_region team_msdyn_region](msdyn_region.md#BKMK_team_msdyn_region)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_region`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_region`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_routingrequest"></a> team_msdyn_routingrequest

Many-To-One Relationship: [msdyn_routingrequest team_msdyn_routingrequest](msdyn_routingrequest.md#BKMK_team_msdyn_routingrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingrequest`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_routingrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_team_msdyn_salescopilotemailinsight"></a> team_msdyn_salescopilotemailinsight

Many-To-One Relationship: [msdyn_salescopilotemailinsight team_msdyn_salescopilotemailinsight](msdyn_salescopilotemailinsight.md#BKMK_team_msdyn_salescopilotemailinsight)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotemailinsight`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salescopilotemailinsight`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_salescopilotinsightcardstate"></a> team_msdyn_salescopilotinsightcardstate

Many-To-One Relationship: [msdyn_salescopilotinsightcardstate team_msdyn_salescopilotinsightcardstate](msdyn_salescopilotinsightcardstate.md#BKMK_team_msdyn_salescopilotinsightcardstate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsightcardstate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_salescopilotinsightcardstate`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_sessiontemplate"></a> team_msdyn_sessiontemplate

Many-To-One Relationship: [msdyn_sessiontemplate team_msdyn_sessiontemplate](msdyn_sessiontemplate.md#BKMK_team_msdyn_sessiontemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sessiontemplate`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_sessiontemplate`|
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

### <a name="BKMK_team_msdyn_taggedrecord"></a> team_msdyn_taggedrecord

Many-To-One Relationship: [msdyn_taggedrecord team_msdyn_taggedrecord](msdyn_taggedrecord.md#BKMK_team_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taggedrecord`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_taggedrecord`|
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

### <a name="BKMK_team_msdyn_templateruleset"></a> team_msdyn_templateruleset

Many-To-One Relationship: [msdyn_templateruleset team_msdyn_templateruleset](msdyn_templateruleset.md#BKMK_team_msdyn_templateruleset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_templateruleset`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_templateruleset`|
|IsCustomizable|`False`|
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

### <a name="BKMK_team_msdyn_timetracker"></a> team_msdyn_timetracker

Many-To-One Relationship: [msdyn_timetracker team_msdyn_timetracker](msdyn_timetracker.md#BKMK_team_msdyn_timetracker)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timetracker`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_timetracker`|
|IsCustomizable|`True`|
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

### <a name="BKMK_team_msdyn_transcript"></a> team_msdyn_transcript

Many-To-One Relationship: [msdyn_transcript team_msdyn_transcript](msdyn_transcript.md#BKMK_team_msdyn_transcript)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_transcript`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_transcript`|
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

### <a name="BKMK_team_msdyn_wallsavedqueryusersettings"></a> team_msdyn_wallsavedqueryusersettings

Many-To-One Relationship: [msdyn_wallsavedqueryusersettings team_msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_team_msdyn_wallsavedqueryusersettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wallsavedqueryusersettings`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_wallsavedqueryusersettings`|
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

### <a name="BKMK_team_msdyn_wkwconfig"></a> team_msdyn_wkwconfig

Many-To-One Relationship: [msdyn_wkwconfig team_msdyn_wkwconfig](msdyn_wkwconfig.md#BKMK_team_msdyn_wkwconfig)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_wkwconfig`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyn_wkwconfig`|
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

### <a name="BKMK_team_msdyncrm_addtocalendarstyle"></a> team_msdyncrm_addtocalendarstyle

Many-To-One Relationship: [msdyncrm_addtocalendarstyle team_msdyncrm_addtocalendarstyle](msdyncrm_addtocalendarstyle.md#BKMK_team_msdyncrm_addtocalendarstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_addtocalendarstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_addtocalendarstyle`|
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

### <a name="BKMK_team_msdyncrm_contentblockstyle"></a> team_msdyncrm_contentblockstyle

Many-To-One Relationship: [msdyncrm_contentblockstyle team_msdyncrm_contentblockstyle](msdyncrm_contentblockstyle.md#BKMK_team_msdyncrm_contentblockstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_contentblockstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_contentblockstyle`|
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

### <a name="BKMK_team_msdyncrm_generalstyles"></a> team_msdyncrm_generalstyles

Many-To-One Relationship: [msdyncrm_generalstyles team_msdyncrm_generalstyles](msdyncrm_generalstyles.md#BKMK_team_msdyncrm_generalstyles)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_generalstyles`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_generalstyles`|
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

### <a name="BKMK_team_msdyncrm_layoutstyle"></a> team_msdyncrm_layoutstyle

Many-To-One Relationship: [msdyncrm_layoutstyle team_msdyncrm_layoutstyle](msdyncrm_layoutstyle.md#BKMK_team_msdyncrm_layoutstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_layoutstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_layoutstyle`|
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

### <a name="BKMK_team_msdyncrm_textstyle"></a> team_msdyncrm_textstyle

Many-To-One Relationship: [msdyncrm_textstyle team_msdyncrm_textstyle](msdyncrm_textstyle.md#BKMK_team_msdyncrm_textstyle)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_textstyle`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdyncrm_textstyle`|
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

### <a name="BKMK_team_msdynmkt_catalogeventstatusconfiguration"></a> team_msdynmkt_catalogeventstatusconfiguration

Many-To-One Relationship: [msdynmkt_catalogeventstatusconfiguration team_msdynmkt_catalogeventstatusconfiguration](msdynmkt_catalogeventstatusconfiguration.md#BKMK_team_msdynmkt_catalogeventstatusconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_catalogeventstatusconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_catalogeventstatusconfiguration`|
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

### <a name="BKMK_team_msdynmkt_featureconfiguration"></a> team_msdynmkt_featureconfiguration

Many-To-One Relationship: [msdynmkt_featureconfiguration team_msdynmkt_featureconfiguration](msdynmkt_featureconfiguration.md#BKMK_team_msdynmkt_featureconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_featureconfiguration`|
|ReferencingAttribute|`owningteam`|
|ReferencedEntityNavigationPropertyName|`team_msdynmkt_featureconfiguration`|
|IsCustomizable|`False`|
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

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.team?displayProperty=fullName>
