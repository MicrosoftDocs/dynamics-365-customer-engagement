---
title: "Publishing State Transition Rule (mspp_publishingstatetransitionrule) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Publishing State Transition Rule (mspp_publishingstatetransitionrule) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Publishing State Transition Rule (mspp_publishingstatetransitionrule) table/entity reference (Microsoft Dynamics 365)



> [!NOTE]
> The Microsoft Dynamics 365 Publishing State Transition Rule (mspp_publishingstatetransitionrule) table extends the [Microsoft Dataverse Publishing State Transition Rule (mspp_publishingstatetransitionrule) table](/power-apps/developer/data-platform/reference/entities/mspp_publishingstatetransitionrule).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [mspp_publishingstatetransitionrule_BulkOperations](#BKMK_mspp_publishingstatetransitionrule_BulkOperations)
- [mspp_publishingstatetransitionrule_CampaignActivities](#BKMK_mspp_publishingstatetransitionrule_CampaignActivities)
- [mspp_publishingstatetransitionrule_CampaignResponses](#BKMK_mspp_publishingstatetransitionrule_CampaignResponses)
- [mspp_publishingstatetransitionrule_IncidentResolutions](#BKMK_mspp_publishingstatetransitionrule_IncidentResolutions)
- [mspp_publishingstatetransitionrule_msdyn_copilottranscripts](#BKMK_mspp_publishingstatetransitionrule_msdyn_copilottranscripts)
- [mspp_publishingstatetransitionrule_msdyn_ocliveworkitems](#BKMK_mspp_publishingstatetransitionrule_msdyn_ocliveworkitems)
- [mspp_publishingstatetransitionrule_msdyn_ocsessions](#BKMK_mspp_publishingstatetransitionrule_msdyn_ocsessions)
- [mspp_publishingstatetransitionrule_msfp_alerts](#BKMK_mspp_publishingstatetransitionrule_msfp_alerts)
- [mspp_publishingstatetransitionrule_msfp_surveyinvites](#BKMK_mspp_publishingstatetransitionrule_msfp_surveyinvites)
- [mspp_publishingstatetransitionrule_msfp_surveyresponses](#BKMK_mspp_publishingstatetransitionrule_msfp_surveyresponses)
- [mspp_publishingstatetransitionrule_OpportunityCloses](#BKMK_mspp_publishingstatetransitionrule_OpportunityCloses)
- [mspp_publishingstatetransitionrule_OrderCloses](#BKMK_mspp_publishingstatetransitionrule_OrderCloses)
- [mspp_publishingstatetransitionrule_QuoteCloses](#BKMK_mspp_publishingstatetransitionrule_QuoteCloses)
- [mspp_publishingstatetransitionrule_ServiceAppointments](#BKMK_mspp_publishingstatetransitionrule_ServiceAppointments)

### <a name="BKMK_mspp_publishingstatetransitionrule_BulkOperations"></a> mspp_publishingstatetransitionrule_BulkOperations

Many-To-One Relationship: [bulkoperation mspp_publishingstatetransitionrule_BulkOperations](bulkoperation.md#BKMK_mspp_publishingstatetransitionrule_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_CampaignActivities"></a> mspp_publishingstatetransitionrule_CampaignActivities

Many-To-One Relationship: [campaignactivity mspp_publishingstatetransitionrule_CampaignActivities](campaignactivity.md#BKMK_mspp_publishingstatetransitionrule_CampaignActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_CampaignActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_CampaignResponses"></a> mspp_publishingstatetransitionrule_CampaignResponses

Many-To-One Relationship: [campaignresponse mspp_publishingstatetransitionrule_CampaignResponses](campaignresponse.md#BKMK_mspp_publishingstatetransitionrule_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_IncidentResolutions"></a> mspp_publishingstatetransitionrule_IncidentResolutions

Many-To-One Relationship: [incidentresolution mspp_publishingstatetransitionrule_IncidentResolutions](incidentresolution.md#BKMK_mspp_publishingstatetransitionrule_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msdyn_copilottranscripts"></a> mspp_publishingstatetransitionrule_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript mspp_publishingstatetransitionrule_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_mspp_publishingstatetransitionrule_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msdyn_ocliveworkitems"></a> mspp_publishingstatetransitionrule_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem mspp_publishingstatetransitionrule_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_mspp_publishingstatetransitionrule_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msdyn_ocsessions"></a> mspp_publishingstatetransitionrule_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession mspp_publishingstatetransitionrule_msdyn_ocsessions](msdyn_ocsession.md#BKMK_mspp_publishingstatetransitionrule_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msfp_alerts"></a> mspp_publishingstatetransitionrule_msfp_alerts

Many-To-One Relationship: [msfp_alert mspp_publishingstatetransitionrule_msfp_alerts](msfp_alert.md#BKMK_mspp_publishingstatetransitionrule_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msfp_surveyinvites"></a> mspp_publishingstatetransitionrule_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite mspp_publishingstatetransitionrule_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_mspp_publishingstatetransitionrule_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_msfp_surveyresponses"></a> mspp_publishingstatetransitionrule_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse mspp_publishingstatetransitionrule_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_mspp_publishingstatetransitionrule_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_OpportunityCloses"></a> mspp_publishingstatetransitionrule_OpportunityCloses

Many-To-One Relationship: [opportunityclose mspp_publishingstatetransitionrule_OpportunityCloses](opportunityclose.md#BKMK_mspp_publishingstatetransitionrule_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_OrderCloses"></a> mspp_publishingstatetransitionrule_OrderCloses

Many-To-One Relationship: [orderclose mspp_publishingstatetransitionrule_OrderCloses](orderclose.md#BKMK_mspp_publishingstatetransitionrule_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_QuoteCloses"></a> mspp_publishingstatetransitionrule_QuoteCloses

Many-To-One Relationship: [quoteclose mspp_publishingstatetransitionrule_QuoteCloses](quoteclose.md#BKMK_mspp_publishingstatetransitionrule_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_mspp_publishingstatetransitionrule_ServiceAppointments"></a> mspp_publishingstatetransitionrule_ServiceAppointments

Many-To-One Relationship: [serviceappointment mspp_publishingstatetransitionrule_ServiceAppointments](serviceappointment.md#BKMK_mspp_publishingstatetransitionrule_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`mspp_publishingstatetransitionrule_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mspp_publishingstatetransitionrule?displayProperty=fullName>
