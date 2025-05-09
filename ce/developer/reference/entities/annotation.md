---
title: "Note (Annotation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Note (Annotation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Note (Annotation) table/entity reference (Microsoft Dynamics 365)

Note that is attached to one or more objects, including other notes.

> [!NOTE]
> The Microsoft Dynamics 365 Note (Annotation) table extends the [Microsoft Dataverse Note (Annotation) table](/power-apps/developer/data-platform/reference/entities/annotation).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

### <a name="BKMK_isAutonomouslyCreated"></a> isAutonomouslyCreated

|Property|Value|
|---|---|
|Description|**Determines whether annotation record was autonomously created on conversation wrap up for the linked case record.**|
|DisplayName|**Is autonomously created**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isautonomouslycreated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`annotation_isautonomouslycreated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|


## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectId"></a> ObjectId

Changes from [ObjectId (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/annotation#BKMK_ObjectId)

|Property|Value|
|---|---|
|Targets|bookableresource, bookableresourcebooking, bookableresourcebookingheader, bookableresourcecategoryassn, bookableresourcecharacteristic, bookableresourcegroup, bulkoperation, campaign, campaignactivity, campaignresponse, commitment, competitor, contract, contractdetail, entitlement, entitlementchannel, entitlementtemplate, equipment, incident, incidentresolution, invoice, lead, list, msdyn_copilottranscript, msdyn_customerasset, msdyn_forecastconfiguration, msdyn_forecastpredictionstatus, msdyn_functionallocation, msdyn_iotalert, msdyn_iotdevice, msdyn_iotdevicecategory, msdyn_iotdevicecommand, msdyn_iotdeviceregistrationhistory, msdyn_liveconversation, msdyn_ocflaggedspam, msdyn_ocliveworkitem, msdyn_ocsession, msdyn_overflowactionconfig, msdyn_personalsoundsetting, msdyn_playbookinstance, msdyn_playbooktemplate, msdyn_postalbum, msdyn_salessuggestion, msdyn_soundfile, msdyn_soundnotificationsetting, msdyn_swarm, msdyn_taggedrecord, msdyn_transcript, msfp_alert, msfp_question, msfp_surveyinvite, msfp_surveyresponse, opportunity, opportunityclose, orderclose, product, quote, quoteclose, resourcespec, salesorder, service, serviceappointment|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [bookableresource_Annotations](#BKMK_bookableresource_Annotations)
- [bookableresourcebooking_Annotations](#BKMK_bookableresourcebooking_Annotations)
- [bookableresourcebookingheader_Annotations](#BKMK_bookableresourcebookingheader_Annotations)
- [bookableresourcecategoryassn_Annotations](#BKMK_bookableresourcecategoryassn_Annotations)
- [bookableresourcecharacteristic_Annotations](#BKMK_bookableresourcecharacteristic_Annotations)
- [bookableresourcegroup_Annotations](#BKMK_bookableresourcegroup_Annotations)
- [bulkoperation_Annotations](#BKMK_bulkoperation_Annotations)
- [Campaign_Annotation](#BKMK_Campaign_Annotation)
- [CampaignActivity_Annotation](#BKMK_CampaignActivity_Annotation)
- [CampaignResponse_Annotation](#BKMK_CampaignResponse_Annotation)
- [Competitor_Annotation](#BKMK_Competitor_Annotation)
- [Contract_Annotation](#BKMK_Contract_Annotation)
- [ContractDetail_Annotation](#BKMK_ContractDetail_Annotation)
- [entitlement_Annotations](#BKMK_entitlement_Annotations)
- [entitlementchannel_Annotations](#BKMK_entitlementchannel_Annotations)
- [entitlementtemplate_Annotations](#BKMK_entitlementtemplate_Annotations)
- [Equipment_Annotation](#BKMK_Equipment_Annotation)
- [Incident_Annotation](#BKMK_Incident_Annotation)
- [IncidentResolution_Annotation](#BKMK_IncidentResolution_Annotation)
- [Invoice_Annotation](#BKMK_Invoice_Annotation)
- [Lead_Annotation](#BKMK_Lead_Annotation)
- [List_Annotation](#BKMK_List_Annotation)
- [msdyn_copilottranscript_Annotations](#BKMK_msdyn_copilottranscript_Annotations)
- [msdyn_customerasset_Annotations](#BKMK_msdyn_customerasset_Annotations)
- [msdyn_forecastconfiguration_Annotations](#BKMK_msdyn_forecastconfiguration_Annotations)
- [msdyn_forecastpredictionstatus_Annotations](#BKMK_msdyn_forecastpredictionstatus_Annotations)
- [msdyn_functionallocation_Annotations](#BKMK_msdyn_functionallocation_Annotations)
- [msdyn_iotalert_Annotations](#BKMK_msdyn_iotalert_Annotations)
- [msdyn_iotdevice_Annotations](#BKMK_msdyn_iotdevice_Annotations)
- [msdyn_iotdevicecategory_Annotations](#BKMK_msdyn_iotdevicecategory_Annotations)
- [msdyn_iotdevicecommand_Annotations](#BKMK_msdyn_iotdevicecommand_Annotations)
- [msdyn_iotdeviceregistrationhistory_Annotations](#BKMK_msdyn_iotdeviceregistrationhistory_Annotations)
- [msdyn_ocflaggedspam_Annotations](#BKMK_msdyn_ocflaggedspam_Annotations)
- [msdyn_ocliveworkitem_Annotations](#BKMK_msdyn_ocliveworkitem_Annotations)
- [msdyn_ocsession_Annotations](#BKMK_msdyn_ocsession_Annotations)
- [msdyn_overflowactionconfig_Annotations](#BKMK_msdyn_overflowactionconfig_Annotations)
- [msdyn_personalsoundsetting_Annotations](#BKMK_msdyn_personalsoundsetting_Annotations)
- [msdyn_postalbum_Annotations](#BKMK_msdyn_postalbum_Annotations)
- [msdyn_salessuggestion_Annotations](#BKMK_msdyn_salessuggestion_Annotations)
- [msdyn_soundfile_Annotations](#BKMK_msdyn_soundfile_Annotations)
- [msdyn_soundnotificationsetting_Annotations](#BKMK_msdyn_soundnotificationsetting_Annotations)
- [msdyn_swarm_Annotations](#BKMK_msdyn_swarm_Annotations)
- [msdyn_taggedrecord_Annotations](#BKMK_msdyn_taggedrecord_Annotations)
- [msdyn_transcript_Annotations](#BKMK_msdyn_transcript_Annotations)
- [msfp_alert_Annotations](#BKMK_msfp_alert_Annotations)
- [msfp_question_Annotations](#BKMK_msfp_question_Annotations)
- [msfp_surveyinvite_Annotations](#BKMK_msfp_surveyinvite_Annotations)
- [msfp_surveyresponse_Annotations](#BKMK_msfp_surveyresponse_Annotations)
- [Opportunity_Annotation](#BKMK_Opportunity_Annotation)
- [OpportunityClose_Annotation](#BKMK_OpportunityClose_Annotation)
- [OrderClose_Annotation](#BKMK_OrderClose_Annotation)
- [Product_Annotation](#BKMK_Product_Annotation)
- [Quote_Annotation](#BKMK_Quote_Annotation)
- [QuoteClose_Annotation](#BKMK_QuoteClose_Annotation)
- [ResourceSpec_Annotation](#BKMK_ResourceSpec_Annotation)
- [SalesOrder_Annotation](#BKMK_SalesOrder_Annotation)
- [Service_Annotation](#BKMK_Service_Annotation)
- [ServiceAppointment_Annotation](#BKMK_ServiceAppointment_Annotation)

### <a name="BKMK_bookableresource_Annotations"></a> bookableresource_Annotations

One-To-Many Relationship: [bookableresource bookableresource_Annotations](bookableresource.md#BKMK_bookableresource_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebooking_Annotations"></a> bookableresourcebooking_Annotations

One-To-Many Relationship: [bookableresourcebooking bookableresourcebooking_Annotations](bookableresourcebooking.md#BKMK_bookableresourcebooking_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcebooking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcebookingheader_Annotations"></a> bookableresourcebookingheader_Annotations

One-To-Many Relationship: [bookableresourcebookingheader bookableresourcebookingheader_Annotations](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebookingheader`|
|ReferencedAttribute|`bookableresourcebookingheaderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcebookingheader`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcecategoryassn_Annotations"></a> bookableresourcecategoryassn_Annotations

One-To-Many Relationship: [bookableresourcecategoryassn bookableresourcecategoryassn_Annotations](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcecategoryassn`|
|ReferencedAttribute|`bookableresourcecategoryassnid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcecategoryassn`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcecharacteristic_Annotations"></a> bookableresourcecharacteristic_Annotations

One-To-Many Relationship: [bookableresourcecharacteristic bookableresourcecharacteristic_Annotations](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcecharacteristic`|
|ReferencedAttribute|`bookableresourcecharacteristicid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcecharacteristic`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bookableresourcegroup_Annotations"></a> bookableresourcegroup_Annotations

One-To-Many Relationship: [bookableresourcegroup bookableresourcegroup_Annotations](bookableresourcegroup.md#BKMK_bookableresourcegroup_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcegroup`|
|ReferencedAttribute|`bookableresourcegroupid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bookableresourcegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_bulkoperation_Annotations"></a> bulkoperation_Annotations

One-To-Many Relationship: [bulkoperation bulkoperation_Annotations](bulkoperation.md#BKMK_bulkoperation_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`bulkoperation`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_bulkoperation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Campaign_Annotation"></a> Campaign_Annotation

One-To-Many Relationship: [campaign Campaign_Annotation](campaign.md#BKMK_Campaign_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_campaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignActivity_Annotation"></a> CampaignActivity_Annotation

One-To-Many Relationship: [campaignactivity CampaignActivity_Annotation](campaignactivity.md#BKMK_CampaignActivity_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_CampaignResponse_Annotation"></a> CampaignResponse_Annotation

One-To-Many Relationship: [campaignresponse CampaignResponse_Annotation](campaignresponse.md#BKMK_CampaignResponse_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_campaignresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Competitor_Annotation"></a> Competitor_Annotation

One-To-Many Relationship: [competitor Competitor_Annotation](competitor.md#BKMK_Competitor_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Contract_Annotation"></a> Contract_Annotation

One-To-Many Relationship: [contract Contract_Annotation](contract.md#BKMK_Contract_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_contract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_ContractDetail_Annotation"></a> ContractDetail_Annotation

One-To-Many Relationship: [contractdetail ContractDetail_Annotation](contractdetail.md#BKMK_ContractDetail_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`contractdetail`|
|ReferencedAttribute|`contractdetailid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_contractdetail`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlement_Annotations"></a> entitlement_Annotations

One-To-Many Relationship: [entitlement entitlement_Annotations](entitlement.md#BKMK_entitlement_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementchannel_Annotations"></a> entitlementchannel_Annotations

One-To-Many Relationship: [entitlementchannel entitlementchannel_Annotations](entitlementchannel.md#BKMK_entitlementchannel_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementchannel`|
|ReferencedAttribute|`entitlementchannelid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_entitlementchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_entitlementtemplate_Annotations"></a> entitlementtemplate_Annotations

One-To-Many Relationship: [entitlementtemplate entitlementtemplate_Annotations](entitlementtemplate.md#BKMK_entitlementtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplate`|
|ReferencedAttribute|`entitlementtemplateid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_entitlementtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Equipment_Annotation"></a> Equipment_Annotation

One-To-Many Relationship: [equipment Equipment_Annotation](equipment.md#BKMK_Equipment_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_equipment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Incident_Annotation"></a> Incident_Annotation

One-To-Many Relationship: [incident Incident_Annotation](incident.md#BKMK_Incident_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_IncidentResolution_Annotation"></a> IncidentResolution_Annotation

One-To-Many Relationship: [incidentresolution IncidentResolution_Annotation](incidentresolution.md#BKMK_IncidentResolution_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`incidentresolution`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_incidentresolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Invoice_Annotation"></a> Invoice_Annotation

One-To-Many Relationship: [invoice Invoice_Annotation](invoice.md#BKMK_Invoice_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Lead_Annotation"></a> Lead_Annotation

One-To-Many Relationship: [lead Lead_Annotation](lead.md#BKMK_Lead_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_List_Annotation"></a> List_Annotation

One-To-Many Relationship: [list List_Annotation](list.md#BKMK_List_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`list`|
|ReferencedAttribute|`listid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_list`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_copilottranscript_Annotations"></a> msdyn_copilottranscript_Annotations

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_Annotations](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_customerasset_Annotations"></a> msdyn_customerasset_Annotations

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_Annotations](msdyn_customerasset.md#BKMK_msdyn_customerasset_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_forecastconfiguration_Annotations"></a> msdyn_forecastconfiguration_Annotations

One-To-Many Relationship: [msdyn_forecastconfiguration msdyn_forecastconfiguration_Annotations](msdyn_forecastconfiguration.md#BKMK_msdyn_forecastconfiguration_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastconfiguration`|
|ReferencedAttribute|`msdyn_forecastconfigurationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_forecastconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_forecastpredictionstatus_Annotations"></a> msdyn_forecastpredictionstatus_Annotations

One-To-Many Relationship: [msdyn_forecastpredictionstatus msdyn_forecastpredictionstatus_Annotations](msdyn_forecastpredictionstatus.md#BKMK_msdyn_forecastpredictionstatus_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_forecastpredictionstatus`|
|ReferencedAttribute|`msdyn_forecastpredictionstatusid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_forecastpredictionstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_functionallocation_Annotations"></a> msdyn_functionallocation_Annotations

One-To-Many Relationship: [msdyn_functionallocation msdyn_functionallocation_Annotations](msdyn_functionallocation.md#BKMK_msdyn_functionallocation_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_functionallocation`|
|ReferencedAttribute|`msdyn_functionallocationid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_functionallocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotalert_Annotations"></a> msdyn_iotalert_Annotations

One-To-Many Relationship: [msdyn_iotalert msdyn_iotalert_Annotations](msdyn_iotalert.md#BKMK_msdyn_iotalert_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotdevice_Annotations"></a> msdyn_iotdevice_Annotations

One-To-Many Relationship: [msdyn_iotdevice msdyn_iotdevice_Annotations](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotdevice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotdevicecategory_Annotations"></a> msdyn_iotdevicecategory_Annotations

One-To-Many Relationship: [msdyn_iotdevicecategory msdyn_iotdevicecategory_Annotations](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecategory`|
|ReferencedAttribute|`msdyn_iotdevicecategoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotdevicecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotdevicecommand_Annotations"></a> msdyn_iotdevicecommand_Annotations

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_iotdevicecommand_Annotations](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotdevicecommand`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_Annotations"></a> msdyn_iotdeviceregistrationhistory_Annotations

One-To-Many Relationship: [msdyn_iotdeviceregistrationhistory msdyn_iotdeviceregistrationhistory_Annotations](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencedAttribute|`msdyn_iotdeviceregistrationhistoryid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_iotdeviceregistrationhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocflaggedspam_Annotations"></a> msdyn_ocflaggedspam_Annotations

One-To-Many Relationship: [msdyn_ocflaggedspam msdyn_ocflaggedspam_Annotations](msdyn_ocflaggedspam.md#BKMK_msdyn_ocflaggedspam_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocflaggedspam`|
|ReferencedAttribute|`msdyn_ocflaggedspamid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocflaggedspam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocliveworkitem_Annotations"></a> msdyn_ocliveworkitem_Annotations

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_Annotations](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_ocsession_Annotations"></a> msdyn_ocsession_Annotations

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_Annotations](msdyn_ocsession.md#BKMK_msdyn_ocsession_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_overflowactionconfig_Annotations"></a> msdyn_overflowactionconfig_Annotations

One-To-Many Relationship: [msdyn_overflowactionconfig msdyn_overflowactionconfig_Annotations](msdyn_overflowactionconfig.md#BKMK_msdyn_overflowactionconfig_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_overflowactionconfig`|
|ReferencedAttribute|`msdyn_overflowactionconfigid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_overflowactionconfig`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_personalsoundsetting_Annotations"></a> msdyn_personalsoundsetting_Annotations

One-To-Many Relationship: [msdyn_personalsoundsetting msdyn_personalsoundsetting_Annotations](msdyn_personalsoundsetting.md#BKMK_msdyn_personalsoundsetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_personalsoundsetting`|
|ReferencedAttribute|`msdyn_personalsoundsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_personalsoundsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_postalbum_Annotations"></a> msdyn_postalbum_Annotations

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_Annotations](msdyn_postalbum.md#BKMK_msdyn_postalbum_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_postalbum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_salessuggestion_Annotations"></a> msdyn_salessuggestion_Annotations

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_Annotations](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_soundfile_Annotations"></a> msdyn_soundfile_Annotations

One-To-Many Relationship: [msdyn_soundfile msdyn_soundfile_Annotations](msdyn_soundfile.md#BKMK_msdyn_soundfile_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_soundfile`|
|ReferencedAttribute|`msdyn_soundfileid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_soundfile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_soundnotificationsetting_Annotations"></a> msdyn_soundnotificationsetting_Annotations

One-To-Many Relationship: [msdyn_soundnotificationsetting msdyn_soundnotificationsetting_Annotations](msdyn_soundnotificationsetting.md#BKMK_msdyn_soundnotificationsetting_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_soundnotificationsetting`|
|ReferencedAttribute|`msdyn_soundnotificationsettingid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_soundnotificationsetting`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_swarm_Annotations"></a> msdyn_swarm_Annotations

One-To-Many Relationship: [msdyn_swarm msdyn_swarm_Annotations](msdyn_swarm.md#BKMK_msdyn_swarm_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_swarm`|
|ReferencedAttribute|`msdyn_swarmid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_swarm`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_taggedrecord_Annotations"></a> msdyn_taggedrecord_Annotations

One-To-Many Relationship: [msdyn_taggedrecord msdyn_taggedrecord_Annotations](msdyn_taggedrecord.md#BKMK_msdyn_taggedrecord_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taggedrecord`|
|ReferencedAttribute|`msdyn_taggedrecordid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_taggedrecord`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_transcript_Annotations"></a> msdyn_transcript_Annotations

One-To-Many Relationship: [msdyn_transcript msdyn_transcript_Annotations](msdyn_transcript.md#BKMK_msdyn_transcript_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_transcript`|
|ReferencedAttribute|`msdyn_transcriptid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msdyn_transcript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msfp_alert_Annotations"></a> msfp_alert_Annotations

One-To-Many Relationship: [msfp_alert msfp_alert_Annotations](msfp_alert.md#BKMK_msfp_alert_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msfp_question_Annotations"></a> msfp_question_Annotations

One-To-Many Relationship: [msfp_question msfp_question_Annotations](msfp_question.md#BKMK_msfp_question_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_question`|
|ReferencedAttribute|`msfp_questionid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_question`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msfp_surveyinvite_Annotations"></a> msfp_surveyinvite_Annotations

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_Annotations](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msfp_surveyresponse_Annotations"></a> msfp_surveyresponse_Annotations

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_Annotations](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_Annotations)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Opportunity_Annotation"></a> Opportunity_Annotation

One-To-Many Relationship: [opportunity Opportunity_Annotation](opportunity.md#BKMK_Opportunity_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_OpportunityClose_Annotation"></a> OpportunityClose_Annotation

One-To-Many Relationship: [opportunityclose OpportunityClose_Annotation](opportunityclose.md#BKMK_OpportunityClose_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunityclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_opportunityclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_OrderClose_Annotation"></a> OrderClose_Annotation

One-To-Many Relationship: [orderclose OrderClose_Annotation](orderclose.md#BKMK_OrderClose_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`orderclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_orderclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Product_Annotation"></a> Product_Annotation

One-To-Many Relationship: [product Product_Annotation](product.md#BKMK_Product_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Quote_Annotation"></a> Quote_Annotation

One-To-Many Relationship: [quote Quote_Annotation](quote.md#BKMK_Quote_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_QuoteClose_Annotation"></a> QuoteClose_Annotation

One-To-Many Relationship: [quoteclose QuoteClose_Annotation](quoteclose.md#BKMK_QuoteClose_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`quoteclose`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_quoteclose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_ResourceSpec_Annotation"></a> ResourceSpec_Annotation

One-To-Many Relationship: [resourcespec ResourceSpec_Annotation](resourcespec.md#BKMK_ResourceSpec_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`resourcespec`|
|ReferencedAttribute|`resourcespecid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_resourcespec`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_SalesOrder_Annotation"></a> SalesOrder_Annotation

One-To-Many Relationship: [salesorder SalesOrder_Annotation](salesorder.md#BKMK_SalesOrder_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_Service_Annotation"></a> Service_Annotation

One-To-Many Relationship: [service Service_Annotation](service.md#BKMK_Service_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_service`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_ServiceAppointment_Annotation"></a> ServiceAppointment_Annotation

One-To-Many Relationship: [serviceappointment ServiceAppointment_Annotation](serviceappointment.md#BKMK_ServiceAppointment_Annotation)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`objectid`|
|ReferencingEntityNavigationPropertyName|`objectid_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.annotation?displayProperty=fullName>
