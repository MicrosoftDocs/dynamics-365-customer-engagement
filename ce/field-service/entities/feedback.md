---
title: "Feedback table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Feedback table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Feedback table/entity reference

Feedback and rating.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Feedback table extends the [Microsoft Dataverse Feedback table](/power-apps/developer/data-platform/reference/entities/feedback).



## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [msdyn_ContextObjectId](#BKMK_msdyn_ContextObjectId)
- [RegardingObjectId](#BKMK_RegardingObjectId)

### <a name="BKMK_msdyn_ContextObjectId"></a> msdyn_ContextObjectId

Changes from [msdyn_ContextObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback#BKMK_msdyn_ContextObjectId)

|Property|Value|
|---|---|
|Targets|incident|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

Changes from [RegardingObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/feedback#BKMK_RegardingObjectId)

|Property|Value|
|---|---|
|Targets|adx_casedeflection|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_casedeflection_Feedback](#BKMK_adx_casedeflection_Feedback)
- [adx_webpage_Feedback](#BKMK_adx_webpage_Feedback)
- [msdyn_copilottranscript_Feedback](#BKMK_msdyn_copilottranscript_Feedback)
- [msdyn_incident_feedback_context](#BKMK_msdyn_incident_feedback_context)
- [msdyn_liveconversation_Feedback](#BKMK_msdyn_liveconversation_Feedback)
- [msdyn_ocliveworkitem_Feedback](#BKMK_msdyn_ocliveworkitem_Feedback)
- [msdyn_ocoutboundmessage_Feedback](#BKMK_msdyn_ocoutboundmessage_Feedback)
- [msdyn_ocsession_Feedback](#BKMK_msdyn_ocsession_Feedback)
- [msdyn_ocvoicemail_Feedback](#BKMK_msdyn_ocvoicemail_Feedback)
- [msdyncrm_appointmentactivitymarketingtemplate_Feedback](#BKMK_msdyncrm_appointmentactivitymarketingtemplate_Feedback)
- [msdyncrm_contentsettings_Feedback](#BKMK_msdyncrm_contentsettings_Feedback)
- [msdyncrm_customerjourney_Feedback](#BKMK_msdyncrm_customerjourney_Feedback)
- [msdyncrm_leadscoremodel_Feedback](#BKMK_msdyncrm_leadscoremodel_Feedback)
- [msdyncrm_linkedinaccount_Feedback](#BKMK_msdyncrm_linkedinaccount_Feedback)
- [msdyncrm_linkedinactivity_Feedback](#BKMK_msdyncrm_linkedinactivity_Feedback)
- [msdyncrm_linkedinfieldmapping_Feedback](#BKMK_msdyncrm_linkedinfieldmapping_Feedback)
- [msdyncrm_linkedinform_Feedback](#BKMK_msdyncrm_linkedinform_Feedback)
- [msdyncrm_linkedinformanswer_Feedback](#BKMK_msdyncrm_linkedinformanswer_Feedback)
- [msdyncrm_linkedinformquestion_Feedback](#BKMK_msdyncrm_linkedinformquestion_Feedback)
- [msdyncrm_linkedinformsubmission_Feedback](#BKMK_msdyncrm_linkedinformsubmission_Feedback)
- [msdyncrm_linkedinleadmatchingstrategy_Feedback](#BKMK_msdyncrm_linkedinleadmatchingstrategy_Feedback)
- [msdyncrm_linkedinuserprofile_Feedback](#BKMK_msdyncrm_linkedinuserprofile_Feedback)
- [msdyncrm_marketingdynamiccontentmetadata_Feedback](#BKMK_msdyncrm_marketingdynamiccontentmetadata_Feedback)
- [msdyncrm_marketingemaildynamiccontentmetadata_Feedback](#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Feedback)
- [msdyncrm_marketingemailtestsend_Feedback](#BKMK_msdyncrm_marketingemailtestsend_Feedback)
- [msdyncrm_mktactivity_Feedback](#BKMK_msdyncrm_mktactivity_Feedback)
- [msdyncrm_phonecallactivitymarketingtemplate_Feedback](#BKMK_msdyncrm_phonecallactivitymarketingtemplate_Feedback)
- [msdyncrm_taskactivitymarketingtemplate_Feedback](#BKMK_msdyncrm_taskactivitymarketingtemplate_Feedback)
- [msfp_alert_Feedback](#BKMK_msfp_alert_Feedback)
- [msfp_surveyinvite_Feedback](#BKMK_msfp_surveyinvite_Feedback)
- [msfp_surveyresponse_Feedback](#BKMK_msfp_surveyresponse_Feedback)

### <a name="BKMK_adx_casedeflection_Feedback"></a> adx_casedeflection_Feedback

One-To-Many Relationship: [adx_casedeflection adx_casedeflection_Feedback](adx_casedeflection.md#BKMK_adx_casedeflection_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_casedeflection`|
|ReferencedAttribute|`adx_casedeflectionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_casedeflection`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webpage_Feedback"></a> adx_webpage_Feedback

One-To-Many Relationship: [adx_webpage adx_webpage_Feedback](adx_webpage.md#BKMK_adx_webpage_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webpage`|
|ReferencedAttribute|`adx_webpageid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_adx_webpage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscript_Feedback"></a> msdyn_copilottranscript_Feedback

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_Feedback](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incident_feedback_context"></a> msdyn_incident_feedback_context

One-To-Many Relationship: [incident msdyn_incident_feedback_context](incident.md#BKMK_msdyn_incident_feedback_context)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_contextobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ContextObjectId_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_liveconversation_Feedback"></a> msdyn_liveconversation_Feedback

One-To-Many Relationship: [msdyn_liveconversation msdyn_liveconversation_Feedback](msdyn_liveconversation.md#BKMK_msdyn_liveconversation_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveconversation`|
|ReferencedAttribute|`msdyn_liveconversationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_liveconversation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_Feedback"></a> msdyn_ocliveworkitem_Feedback

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_Feedback](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocoutboundmessage_Feedback"></a> msdyn_ocoutboundmessage_Feedback

One-To-Many Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_Feedback](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocoutboundmessage`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocoutboundmessage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_Feedback"></a> msdyn_ocsession_Feedback

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_Feedback](msdyn_ocsession.md#BKMK_msdyn_ocsession_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocvoicemail_Feedback"></a> msdyn_ocvoicemail_Feedback

One-To-Many Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_Feedback](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicemail`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyn_ocvoicemail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_appointmentactivitymarketingtemplate_Feedback"></a> msdyncrm_appointmentactivitymarketingtemplate_Feedback

One-To-Many Relationship: [msdyncrm_appointmentactivitymarketingtemplate msdyncrm_appointmentactivitymarketingtemplate_Feedback](msdyncrm_appointmentactivitymarketingtemplate.md#BKMK_msdyncrm_appointmentactivitymarketingtemplate_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_appointmentactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_appointmentactivitymarketingtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contentsettings_Feedback"></a> msdyncrm_contentsettings_Feedback

One-To-Many Relationship: [msdyncrm_contentsettings msdyncrm_contentsettings_Feedback](msdyncrm_contentsettings.md#BKMK_msdyncrm_contentsettings_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_contentsettings`|
|ReferencedAttribute|`msdyncrm_contentsettingsid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_contentsettings`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_customerjourney_Feedback"></a> msdyncrm_customerjourney_Feedback

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_Feedback](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_customerjourney`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_leadscoremodel_Feedback"></a> msdyncrm_leadscoremodel_Feedback

One-To-Many Relationship: [msdyncrm_leadscoremodel msdyncrm_leadscoremodel_Feedback](msdyncrm_leadscoremodel.md#BKMK_msdyncrm_leadscoremodel_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_leadscoremodel`|
|ReferencedAttribute|`msdyncrm_leadscoremodelid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_leadscoremodel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinaccount_Feedback"></a> msdyncrm_linkedinaccount_Feedback

One-To-Many Relationship: [msdyncrm_linkedinaccount msdyncrm_linkedinaccount_Feedback](msdyncrm_linkedinaccount.md#BKMK_msdyncrm_linkedinaccount_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinaccount`|
|ReferencedAttribute|`msdyncrm_linkedinaccountid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinactivity_Feedback"></a> msdyncrm_linkedinactivity_Feedback

One-To-Many Relationship: [msdyncrm_linkedinactivity msdyncrm_linkedinactivity_Feedback](msdyncrm_linkedinactivity.md#BKMK_msdyncrm_linkedinactivity_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinactivity`|
|ReferencedAttribute|`msdyncrm_linkedinactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinfieldmapping_Feedback"></a> msdyncrm_linkedinfieldmapping_Feedback

One-To-Many Relationship: [msdyncrm_linkedinfieldmapping msdyncrm_linkedinfieldmapping_Feedback](msdyncrm_linkedinfieldmapping.md#BKMK_msdyncrm_linkedinfieldmapping_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinfieldmapping`|
|ReferencedAttribute|`msdyncrm_linkedinfieldmappingid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinfieldmapping`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinform_Feedback"></a> msdyncrm_linkedinform_Feedback

One-To-Many Relationship: [msdyncrm_linkedinform msdyncrm_linkedinform_Feedback](msdyncrm_linkedinform.md#BKMK_msdyncrm_linkedinform_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinform`|
|ReferencedAttribute|`msdyncrm_linkedinformid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinform`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformanswer_Feedback"></a> msdyncrm_linkedinformanswer_Feedback

One-To-Many Relationship: [msdyncrm_linkedinformanswer msdyncrm_linkedinformanswer_Feedback](msdyncrm_linkedinformanswer.md#BKMK_msdyncrm_linkedinformanswer_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformanswer`|
|ReferencedAttribute|`msdyncrm_linkedinformanswerid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformanswer`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformquestion_Feedback"></a> msdyncrm_linkedinformquestion_Feedback

One-To-Many Relationship: [msdyncrm_linkedinformquestion msdyncrm_linkedinformquestion_Feedback](msdyncrm_linkedinformquestion.md#BKMK_msdyncrm_linkedinformquestion_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformquestion`|
|ReferencedAttribute|`msdyncrm_linkedinformquestionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformquestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinformsubmission_Feedback"></a> msdyncrm_linkedinformsubmission_Feedback

One-To-Many Relationship: [msdyncrm_linkedinformsubmission msdyncrm_linkedinformsubmission_Feedback](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_linkedinformsubmission_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinformsubmission`|
|ReferencedAttribute|`msdyncrm_linkedinformsubmissionid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinformsubmission`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinleadmatchingstrategy_Feedback"></a> msdyncrm_linkedinleadmatchingstrategy_Feedback

One-To-Many Relationship: [msdyncrm_linkedinleadmatchingstrategy msdyncrm_linkedinleadmatchingstrategy_Feedback](msdyncrm_linkedinleadmatchingstrategy.md#BKMK_msdyncrm_linkedinleadmatchingstrategy_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinleadmatchingstrategy`|
|ReferencedAttribute|`msdyncrm_linkedinleadmatchingstrategyid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinleadmatchingstrategy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_linkedinuserprofile_Feedback"></a> msdyncrm_linkedinuserprofile_Feedback

One-To-Many Relationship: [msdyncrm_linkedinuserprofile msdyncrm_linkedinuserprofile_Feedback](msdyncrm_linkedinuserprofile.md#BKMK_msdyncrm_linkedinuserprofile_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_linkedinuserprofile`|
|ReferencedAttribute|`msdyncrm_linkedinuserprofileid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_linkedinuserprofile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingdynamiccontentmetadata_Feedback"></a> msdyncrm_marketingdynamiccontentmetadata_Feedback

One-To-Many Relationship: [msdyncrm_marketingdynamiccontentmetadata msdyncrm_marketingdynamiccontentmetadata_Feedback](msdyncrm_marketingdynamiccontentmetadata.md#BKMK_msdyncrm_marketingdynamiccontentmetadata_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingdynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingdynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingdynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Feedback"></a> msdyncrm_marketingemaildynamiccontentmetadata_Feedback

One-To-Many Relationship: [msdyncrm_marketingemaildynamiccontentmetadata msdyncrm_marketingemaildynamiccontentmetadata_Feedback](msdyncrm_marketingemaildynamiccontentmetadata.md#BKMK_msdyncrm_marketingemaildynamiccontentmetadata_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemaildynamiccontentmetadata`|
|ReferencedAttribute|`msdyncrm_marketingemaildynamiccontentmetadataid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemailtestsend_Feedback"></a> msdyncrm_marketingemailtestsend_Feedback

One-To-Many Relationship: [msdyncrm_marketingemailtestsend msdyncrm_marketingemailtestsend_Feedback](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_marketingemailtestsend_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtestsend`|
|ReferencedAttribute|`msdyncrm_marketingemailtestsendid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_marketingemailtestsend`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_mktactivity_Feedback"></a> msdyncrm_mktactivity_Feedback

One-To-Many Relationship: [msdyncrm_mktactivity msdyncrm_mktactivity_Feedback](msdyncrm_mktactivity.md#BKMK_msdyncrm_mktactivity_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_mktactivity`|
|ReferencedAttribute|`msdyncrm_mktactivityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_mktactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_phonecallactivitymarketingtemplate_Feedback"></a> msdyncrm_phonecallactivitymarketingtemplate_Feedback

One-To-Many Relationship: [msdyncrm_phonecallactivitymarketingtemplate msdyncrm_phonecallactivitymarketingtemplate_Feedback](msdyncrm_phonecallactivitymarketingtemplate.md#BKMK_msdyncrm_phonecallactivitymarketingtemplate_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_phonecallactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_phonecallactivitymarketingtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_Feedback"></a> msdyncrm_taskactivitymarketingtemplate_Feedback

One-To-Many Relationship: [msdyncrm_taskactivitymarketingtemplate msdyncrm_taskactivitymarketingtemplate_Feedback](msdyncrm_taskactivitymarketingtemplate.md#BKMK_msdyncrm_taskactivitymarketingtemplate_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_taskactivitymarketingtemplate`|
|ReferencedAttribute|`msdyncrm_taskactivitymarketingtemplateid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msdyncrm_taskactivitymarketingtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_Feedback"></a> msfp_alert_Feedback

One-To-Many Relationship: [msfp_alert msfp_alert_Feedback](msfp_alert.md#BKMK_msfp_alert_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_Feedback"></a> msfp_surveyinvite_Feedback

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_Feedback](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_Feedback"></a> msfp_surveyresponse_Feedback

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_Feedback](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_Feedback)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.feedback?displayProperty=fullName>
