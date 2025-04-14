---
title: "Connection table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Connection table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Connection table/entity reference (Microsoft Dynamics 365)

Relationship between two entities.

> [!NOTE]
> The Microsoft Dynamics 365 Connection table extends the [Microsoft Dataverse Connection table](/power-apps/developer/data-platform/reference/entities/connection).



## Customized columns/attributes

Microsoft Dynamics 365 modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

- [Record1Id](#BKMK_Record1Id)
- [Record1ObjectTypeCode](#BKMK_Record1ObjectTypeCode)
- [Record2Id](#BKMK_Record2Id)
- [Record2ObjectTypeCode](#BKMK_Record2ObjectTypeCode)

### <a name="BKMK_Record1Id"></a> Record1Id

Changes from [Record1Id (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record1Id)

|Property|Value|
|---|---|
|Description|Unique identifier of the source record.|
|Targets|campaign, campaignactivity, competitor, constraintbasedgroup, contract, entitlement, entitlementchannel, entitlementtemplatechannel, equipment, incident, invoice, lead, list, msdyn_assignmentmap, msdyn_assignmentrule, msdyn_copilottranscript, msdyn_customerasset, msdyn_iotalert, msdyn_iotdevice, msdyn_iotdevicecategory, msdyn_iotdevicecommand, msdyn_iotdeviceregistrationhistory, msdyn_liveconversation, msdyn_ocliveworkitem, msdyn_ocsession, msdyn_postalbum, msdyn_salessuggestion, msdyn_sequence, msdyn_sequencetarget, msdyn_suggestionprincipalobjectaccess, msfp_alert, msfp_surveyinvite, msfp_surveyresponse, opportunity, pricelevel, product, quote, resourcegroup, salesorder, serviceappointment|


### <a name="BKMK_Record1ObjectTypeCode"></a> Record1ObjectTypeCode

Changes from [Record1ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record1ObjectTypeCode)

#### Record1ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|3|**Opportunity**|
|4|**Lead**|
|112|**Case**|
|123|**Competitor**|
|1010|**Contract**|
|1022|**Price List**|
|1024|**Product**|
|1084|**Quote**|
|1088|**Order**|
|1090|**Invoice**|
|4000|**Facility/Equipment**|
|4005|**Scheduling Group**|
|4007|**Resource Group**|
|4214|**Service Activity**|
|4300|**Marketing List**|
|4400|**Campaign**|
|4402|**Campaign Activity**|
|9700|**Entitlement**|
|9701|**Entitlement Channel**|
|9703|**Entitlement Template Channel**|
|10406|**Customer Asset**|
|10428|**IoT Alert**|
|10429|**IoT Device**|
|10430|**IoT Device Category**|
|10431|**IoT Device Command**|
|10435|**IoT Device Registration History**|
|10623|**Profile Album**|
|10628|**Customer Voice alert**|
|10638|**Customer Voice survey invite**|
|10640|**Customer Voice survey response**|
|10714|**Ongoing conversation (Deprecated)**|
|10726|**Conversation**|
|10743|**Session**|
|10853|**Sequence**|
|10855|**Sequence Target**|
|10867|**Assignment Rule**|
|10870|**Assignment Map**|
|10877|**Insight**|
|10886|**Suggestion Principal Object Access**|
|10931|**Copilot Transcript**|

### <a name="BKMK_Record2Id"></a> Record2Id

Changes from [Record2Id (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record2Id)

|Property|Value|
|---|---|
|Description|Unique identifier of the target record.|
|Targets|campaign, campaignactivity, competitor, constraintbasedgroup, contract, entitlement, entitlementchannel, entitlementtemplatechannel, equipment, incident, invoice, lead, list, msdyn_assignmentmap, msdyn_assignmentrule, msdyn_copilottranscript, msdyn_customerasset, msdyn_iotalert, msdyn_iotdevice, msdyn_iotdevicecategory, msdyn_iotdevicecommand, msdyn_iotdeviceregistrationhistory, msdyn_liveconversation, msdyn_ocliveworkitem, msdyn_ocsession, msdyn_postalbum, msdyn_salessuggestion, msdyn_sequence, msdyn_sequencetarget, msdyn_suggestionprincipalobjectaccess, msfp_alert, msfp_surveyinvite, msfp_surveyresponse, opportunity, pricelevel, product, quote, resourcegroup, salesorder, serviceappointment|


### <a name="BKMK_Record2ObjectTypeCode"></a> Record2ObjectTypeCode

Changes from [Record2ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/connection#BKMK_Record2ObjectTypeCode)

#### Record2ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|3|**Opportunity**|
|4|**Lead**|
|112|**Case**|
|123|**Competitor**|
|1010|**Contract**|
|1022|**Price List**|
|1024|**Product**|
|1084|**Quote**|
|1088|**Order**|
|1090|**Invoice**|
|4000|**Facility/Equipment**|
|4005|**Scheduling Group**|
|4007|**Resource Group**|
|4214|**Service Activity**|
|4300|**Marketing List**|
|4400|**Campaign**|
|4402|**Campaign Activity**|
|9700|**Entitlement**|
|9701|**Entitlement Channel**|
|9703|**Entitlement Template Channel**|
|10406|**Customer Asset**|
|10428|**IoT Alert**|
|10429|**IoT Device**|
|10430|**IoT Device Category**|
|10431|**IoT Device Command**|
|10435|**IoT Device Registration History**|
|10623|**Profile Album**|
|10628|**Customer Voice alert**|
|10638|**Customer Voice survey invite**|
|10640|**Customer Voice survey response**|
|10714|**Ongoing conversation (Deprecated)**|
|10726|**Conversation**|
|10743|**Session**|
|10853|**Sequence**|
|10855|**Sequence Target**|
|10867|**Assignment Rule**|
|10870|**Assignment Map**|
|10877|**Insight**|
|10886|**Suggestion Principal Object Access**|
|10931|**Copilot Transcript**|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [campaign_connections1](#BKMK_campaign_connections1)
- [campaign_connections2](#BKMK_campaign_connections2)
- [campaignactivity_connections1](#BKMK_campaignactivity_connections1)
- [campaignactivity_connections2](#BKMK_campaignactivity_connections2)
- [competitor_connections1](#BKMK_competitor_connections1)
- [competitor_connections2](#BKMK_competitor_connections2)
- [constraintbasedgroup_connections1](#BKMK_constraintbasedgroup_connections1)
- [constraintbasedgroup_connections2](#BKMK_constraintbasedgroup_connections2)
- [contract_connections1](#BKMK_contract_connections1)
- [contract_connections2](#BKMK_contract_connections2)
- [entitlement_connections1](#BKMK_entitlement_connections1)
- [entitlement_connections2](#BKMK_entitlement_connections2)
- [entitlementchannel_connections1](#BKMK_entitlementchannel_connections1)
- [entitlementchannel_connections2](#BKMK_entitlementchannel_connections2)
- [entitlementtemplatechannel_connections1](#BKMK_entitlementtemplatechannel_connections1)
- [entitlementtemplatechannel_connections2](#BKMK_entitlementtemplatechannel_connections2)
- [equipment_connections1](#BKMK_equipment_connections1)
- [equipment_connections2](#BKMK_equipment_connections2)
- [incident_connections1](#BKMK_incident_connections1)
- [incident_connections2](#BKMK_incident_connections2)
- [invoice_connections1](#BKMK_invoice_connections1)
- [invoice_connections2](#BKMK_invoice_connections2)
- [lead_connections1](#BKMK_lead_connections1)
- [lead_connections2](#BKMK_lead_connections2)
- [list_connections1](#BKMK_list_connections1)
- [list_connections2](#BKMK_list_connections2)
- [msdyn_assignmentmap_connections1](#BKMK_msdyn_assignmentmap_connections1)
- [msdyn_assignmentmap_connections2](#BKMK_msdyn_assignmentmap_connections2)
- [msdyn_assignmentrule_connections1](#BKMK_msdyn_assignmentrule_connections1)
- [msdyn_assignmentrule_connections2](#BKMK_msdyn_assignmentrule_connections2)
- [msdyn_copilottranscript_connections1](#BKMK_msdyn_copilottranscript_connections1)
- [msdyn_copilottranscript_connections2](#BKMK_msdyn_copilottranscript_connections2)
- [msdyn_customerasset_connections1](#BKMK_msdyn_customerasset_connections1)
- [msdyn_customerasset_connections2](#BKMK_msdyn_customerasset_connections2)
- [msdyn_iotalert_connections1](#BKMK_msdyn_iotalert_connections1)
- [msdyn_iotalert_connections2](#BKMK_msdyn_iotalert_connections2)
- [msdyn_iotdevice_connections1](#BKMK_msdyn_iotdevice_connections1)
- [msdyn_iotdevice_connections2](#BKMK_msdyn_iotdevice_connections2)
- [msdyn_iotdevicecategory_connections1](#BKMK_msdyn_iotdevicecategory_connections1)
- [msdyn_iotdevicecategory_connections2](#BKMK_msdyn_iotdevicecategory_connections2)
- [msdyn_iotdevicecommand_connections1](#BKMK_msdyn_iotdevicecommand_connections1)
- [msdyn_iotdevicecommand_connections2](#BKMK_msdyn_iotdevicecommand_connections2)
- [msdyn_iotdeviceregistrationhistory_connections1](#BKMK_msdyn_iotdeviceregistrationhistory_connections1)
- [msdyn_iotdeviceregistrationhistory_connections2](#BKMK_msdyn_iotdeviceregistrationhistory_connections2)
- [msdyn_ocliveworkitem_connections1](#BKMK_msdyn_ocliveworkitem_connections1)
- [msdyn_ocliveworkitem_connections2](#BKMK_msdyn_ocliveworkitem_connections2)
- [msdyn_ocsession_connections1](#BKMK_msdyn_ocsession_connections1)
- [msdyn_ocsession_connections2](#BKMK_msdyn_ocsession_connections2)
- [msdyn_postalbum_connections1](#BKMK_msdyn_postalbum_connections1)
- [msdyn_postalbum_connections2](#BKMK_msdyn_postalbum_connections2)
- [msdyn_salessuggestion_connections1](#BKMK_msdyn_salessuggestion_connections1)
- [msdyn_salessuggestion_connections2](#BKMK_msdyn_salessuggestion_connections2)
- [msdyn_sequence_connections1](#BKMK_msdyn_sequence_connections1)
- [msdyn_sequence_connections2](#BKMK_msdyn_sequence_connections2)
- [msdyn_sequencetarget_connections1](#BKMK_msdyn_sequencetarget_connections1)
- [msdyn_sequencetarget_connections2](#BKMK_msdyn_sequencetarget_connections2)
- [msdyn_suggestionprincipalobjectaccess_connections1](#BKMK_msdyn_suggestionprincipalobjectaccess_connections1)
- [msdyn_suggestionprincipalobjectaccess_connections2](#BKMK_msdyn_suggestionprincipalobjectaccess_connections2)
- [msfp_alert_connections1](#BKMK_msfp_alert_connections1)
- [msfp_alert_connections2](#BKMK_msfp_alert_connections2)
- [msfp_surveyinvite_connections1](#BKMK_msfp_surveyinvite_connections1)
- [msfp_surveyinvite_connections2](#BKMK_msfp_surveyinvite_connections2)
- [msfp_surveyresponse_connections1](#BKMK_msfp_surveyresponse_connections1)
- [msfp_surveyresponse_connections2](#BKMK_msfp_surveyresponse_connections2)
- [opportunity_connections1](#BKMK_opportunity_connections1)
- [opportunity_connections2](#BKMK_opportunity_connections2)
- [pricelevel_connections1](#BKMK_pricelevel_connections1)
- [pricelevel_connections2](#BKMK_pricelevel_connections2)
- [product_connections1](#BKMK_product_connections1)
- [product_connections2](#BKMK_product_connections2)
- [quote_connections1](#BKMK_quote_connections1)
- [quote_connections2](#BKMK_quote_connections2)
- [resourcegroup_connections1](#BKMK_resourcegroup_connections1)
- [resourcegroup_connections2](#BKMK_resourcegroup_connections2)
- [salesorder_connections1](#BKMK_salesorder_connections1)
- [salesorder_connections2](#BKMK_salesorder_connections2)
- [serviceappointment_connections1](#BKMK_serviceappointment_connections1)
- [serviceappointment_connections2](#BKMK_serviceappointment_connections2)

### <a name="BKMK_campaign_connections1"></a> campaign_connections1

One-To-Many Relationship: [campaign campaign_connections1](campaign.md#BKMK_campaign_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_campaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaign_connections2"></a> campaign_connections2

One-To-Many Relationship: [campaign campaign_connections2](campaign.md#BKMK_campaign_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`campaign`|
|ReferencedAttribute|`campaignid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_campaign`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_connections1"></a> campaignactivity_connections1

One-To-Many Relationship: [campaignactivity campaignactivity_connections1](campaignactivity.md#BKMK_campaignactivity_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_campaignactivity_connections2"></a> campaignactivity_connections2

One-To-Many Relationship: [campaignactivity campaignactivity_connections2](campaignactivity.md#BKMK_campaignactivity_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`campaignactivity`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_campaignactivity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_competitor_connections1"></a> competitor_connections1

One-To-Many Relationship: [competitor competitor_connections1](competitor.md#BKMK_competitor_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_competitor_connections2"></a> competitor_connections2

One-To-Many Relationship: [competitor competitor_connections2](competitor.md#BKMK_competitor_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`competitor`|
|ReferencedAttribute|`competitorid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_competitor`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_constraintbasedgroup_connections1"></a> constraintbasedgroup_connections1

One-To-Many Relationship: [constraintbasedgroup constraintbasedgroup_connections1](constraintbasedgroup.md#BKMK_constraintbasedgroup_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`constraintbasedgroup`|
|ReferencedAttribute|`constraintbasedgroupid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_constraintbasedgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_constraintbasedgroup_connections2"></a> constraintbasedgroup_connections2

One-To-Many Relationship: [constraintbasedgroup constraintbasedgroup_connections2](constraintbasedgroup.md#BKMK_constraintbasedgroup_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`constraintbasedgroup`|
|ReferencedAttribute|`constraintbasedgroupid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_constraintbasedgroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_connections1"></a> contract_connections1

One-To-Many Relationship: [contract contract_connections1](contract.md#BKMK_contract_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_contract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_contract_connections2"></a> contract_connections2

One-To-Many Relationship: [contract contract_connections2](contract.md#BKMK_contract_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`contract`|
|ReferencedAttribute|`contractid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_contract`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlement_connections1"></a> entitlement_connections1

One-To-Many Relationship: [entitlement entitlement_connections1](entitlement.md#BKMK_entitlement_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlement_connections2"></a> entitlement_connections2

One-To-Many Relationship: [entitlement entitlement_connections2](entitlement.md#BKMK_entitlement_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementchannel_connections1"></a> entitlementchannel_connections1

One-To-Many Relationship: [entitlementchannel entitlementchannel_connections1](entitlementchannel.md#BKMK_entitlementchannel_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementchannel`|
|ReferencedAttribute|`entitlementchannelid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_entitlementchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementchannel_connections2"></a> entitlementchannel_connections2

One-To-Many Relationship: [entitlementchannel entitlementchannel_connections2](entitlementchannel.md#BKMK_entitlementchannel_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementchannel`|
|ReferencedAttribute|`entitlementchannelid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_entitlementchannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementtemplatechannel_connections1"></a> entitlementtemplatechannel_connections1

One-To-Many Relationship: [entitlementtemplatechannel entitlementtemplatechannel_connections1](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplatechannel`|
|ReferencedAttribute|`entitlementtemplatechannelid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_entitlementtemplatechannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_entitlementtemplatechannel_connections2"></a> entitlementtemplatechannel_connections2

One-To-Many Relationship: [entitlementtemplatechannel entitlementtemplatechannel_connections2](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlementtemplatechannel`|
|ReferencedAttribute|`entitlementtemplatechannelid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_entitlementtemplatechannel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_equipment_connections1"></a> equipment_connections1

One-To-Many Relationship: [equipment equipment_connections1](equipment.md#BKMK_equipment_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_equipment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_equipment_connections2"></a> equipment_connections2

One-To-Many Relationship: [equipment equipment_connections2](equipment.md#BKMK_equipment_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_equipment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_connections1"></a> incident_connections1

One-To-Many Relationship: [incident incident_connections1](incident.md#BKMK_incident_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_incident_connections2"></a> incident_connections2

One-To-Many Relationship: [incident incident_connections2](incident.md#BKMK_incident_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_incident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_invoice_connections1"></a> invoice_connections1

One-To-Many Relationship: [invoice invoice_connections1](invoice.md#BKMK_invoice_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_invoice_connections2"></a> invoice_connections2

One-To-Many Relationship: [invoice invoice_connections2](invoice.md#BKMK_invoice_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`invoice`|
|ReferencedAttribute|`invoiceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_invoice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_connections1"></a> lead_connections1

One-To-Many Relationship: [lead lead_connections1](lead.md#BKMK_lead_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lead_connections2"></a> lead_connections2

One-To-Many Relationship: [lead lead_connections2](lead.md#BKMK_lead_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_list_connections1"></a> list_connections1

One-To-Many Relationship: [list list_connections1](list.md#BKMK_list_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`list`|
|ReferencedAttribute|`listid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_list`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_list_connections2"></a> list_connections2

One-To-Many Relationship: [list list_connections2](list.md#BKMK_list_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`list`|
|ReferencedAttribute|`listid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_list`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assignmentmap_connections1"></a> msdyn_assignmentmap_connections1

One-To-Many Relationship: [msdyn_assignmentmap msdyn_assignmentmap_connections1](msdyn_assignmentmap.md#BKMK_msdyn_assignmentmap_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentmap`|
|ReferencedAttribute|`msdyn_assignmentmapid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_assignmentmap`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assignmentmap_connections2"></a> msdyn_assignmentmap_connections2

One-To-Many Relationship: [msdyn_assignmentmap msdyn_assignmentmap_connections2](msdyn_assignmentmap.md#BKMK_msdyn_assignmentmap_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentmap`|
|ReferencedAttribute|`msdyn_assignmentmapid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_assignmentmap`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assignmentrule_connections1"></a> msdyn_assignmentrule_connections1

One-To-Many Relationship: [msdyn_assignmentrule msdyn_assignmentrule_connections1](msdyn_assignmentrule.md#BKMK_msdyn_assignmentrule_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentrule`|
|ReferencedAttribute|`msdyn_assignmentruleid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_assignmentrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_assignmentrule_connections2"></a> msdyn_assignmentrule_connections2

One-To-Many Relationship: [msdyn_assignmentrule msdyn_assignmentrule_connections2](msdyn_assignmentrule.md#BKMK_msdyn_assignmentrule_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentrule`|
|ReferencedAttribute|`msdyn_assignmentruleid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_assignmentrule`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscript_connections1"></a> msdyn_copilottranscript_connections1

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_connections1](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_copilottranscript_connections2"></a> msdyn_copilottranscript_connections2

One-To-Many Relationship: [msdyn_copilottranscript msdyn_copilottranscript_connections2](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_copilottranscript`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_copilottranscript`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerasset_connections1"></a> msdyn_customerasset_connections1

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_connections1](msdyn_customerasset.md#BKMK_msdyn_customerasset_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerasset_connections2"></a> msdyn_customerasset_connections2

One-To-Many Relationship: [msdyn_customerasset msdyn_customerasset_connections2](msdyn_customerasset.md#BKMK_msdyn_customerasset_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotalert_connections1"></a> msdyn_iotalert_connections1

One-To-Many Relationship: [msdyn_iotalert msdyn_iotalert_connections1](msdyn_iotalert.md#BKMK_msdyn_iotalert_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotalert_connections2"></a> msdyn_iotalert_connections2

One-To-Many Relationship: [msdyn_iotalert msdyn_iotalert_connections2](msdyn_iotalert.md#BKMK_msdyn_iotalert_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotalert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevice_connections1"></a> msdyn_iotdevice_connections1

One-To-Many Relationship: [msdyn_iotdevice msdyn_iotdevice_connections1](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotdevice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevice_connections2"></a> msdyn_iotdevice_connections2

One-To-Many Relationship: [msdyn_iotdevice msdyn_iotdevice_connections2](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevice`|
|ReferencedAttribute|`msdyn_iotdeviceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotdevice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicecategory_connections1"></a> msdyn_iotdevicecategory_connections1

One-To-Many Relationship: [msdyn_iotdevicecategory msdyn_iotdevicecategory_connections1](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecategory`|
|ReferencedAttribute|`msdyn_iotdevicecategoryid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotdevicecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicecategory_connections2"></a> msdyn_iotdevicecategory_connections2

One-To-Many Relationship: [msdyn_iotdevicecategory msdyn_iotdevicecategory_connections2](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecategory`|
|ReferencedAttribute|`msdyn_iotdevicecategoryid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotdevicecategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicecommand_connections1"></a> msdyn_iotdevicecommand_connections1

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_iotdevicecommand_connections1](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotdevicecommand`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdevicecommand_connections2"></a> msdyn_iotdevicecommand_connections2

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_iotdevicecommand_connections2](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotdevicecommand`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_connections1"></a> msdyn_iotdeviceregistrationhistory_connections1

One-To-Many Relationship: [msdyn_iotdeviceregistrationhistory msdyn_iotdeviceregistrationhistory_connections1](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencedAttribute|`msdyn_iotdeviceregistrationhistoryid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_iotdeviceregistrationhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_connections2"></a> msdyn_iotdeviceregistrationhistory_connections2

One-To-Many Relationship: [msdyn_iotdeviceregistrationhistory msdyn_iotdeviceregistrationhistory_connections2](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdeviceregistrationhistory`|
|ReferencedAttribute|`msdyn_iotdeviceregistrationhistoryid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_iotdeviceregistrationhistory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_connections1"></a> msdyn_ocliveworkitem_connections1

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_connections1](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocliveworkitem_connections2"></a> msdyn_ocliveworkitem_connections2

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_connections2](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_ocliveworkitem`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_connections1"></a> msdyn_ocsession_connections1

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_connections1](msdyn_ocsession.md#BKMK_msdyn_ocsession_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_connections2"></a> msdyn_ocsession_connections2

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_connections2](msdyn_ocsession.md#BKMK_msdyn_ocsession_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_ocsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalbum_connections1"></a> msdyn_postalbum_connections1

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_connections1](msdyn_postalbum.md#BKMK_msdyn_postalbum_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_postalbum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_postalbum_connections2"></a> msdyn_postalbum_connections2

One-To-Many Relationship: [msdyn_postalbum msdyn_postalbum_connections2](msdyn_postalbum.md#BKMK_msdyn_postalbum_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_postalbum`|
|ReferencedAttribute|`msdyn_postalbumid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_postalbum`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_connections1"></a> msdyn_salessuggestion_connections1

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_connections1](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_connections2"></a> msdyn_salessuggestion_connections2

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_connections2](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequence_connections1"></a> msdyn_sequence_connections1

One-To-Many Relationship: [msdyn_sequence msdyn_sequence_connections1](msdyn_sequence.md#BKMK_msdyn_sequence_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequence`|
|ReferencedAttribute|`msdyn_sequenceid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_sequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequence_connections2"></a> msdyn_sequence_connections2

One-To-Many Relationship: [msdyn_sequence msdyn_sequence_connections2](msdyn_sequence.md#BKMK_msdyn_sequence_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequence`|
|ReferencedAttribute|`msdyn_sequenceid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_sequence`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_connections1"></a> msdyn_sequencetarget_connections1

One-To-Many Relationship: [msdyn_sequencetarget msdyn_sequencetarget_connections1](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequencetarget`|
|ReferencedAttribute|`msdyn_sequencetargetid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_sequencetarget`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_sequencetarget_connections2"></a> msdyn_sequencetarget_connections2

One-To-Many Relationship: [msdyn_sequencetarget msdyn_sequencetarget_connections2](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_sequencetarget`|
|ReferencedAttribute|`msdyn_sequencetargetid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_sequencetarget`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_connections1"></a> msdyn_suggestionprincipalobjectaccess_connections1

One-To-Many Relationship: [msdyn_suggestionprincipalobjectaccess msdyn_suggestionprincipalobjectaccess_connections1](msdyn_suggestionprincipalobjectaccess.md#BKMK_msdyn_suggestionprincipalobjectaccess_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_suggestionprincipalobjectaccess`|
|ReferencedAttribute|`msdyn_suggestionprincipalobjectaccessid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msdyn_suggestionprincipalobjectaccess`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_suggestionprincipalobjectaccess_connections2"></a> msdyn_suggestionprincipalobjectaccess_connections2

One-To-Many Relationship: [msdyn_suggestionprincipalobjectaccess msdyn_suggestionprincipalobjectaccess_connections2](msdyn_suggestionprincipalobjectaccess.md#BKMK_msdyn_suggestionprincipalobjectaccess_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_suggestionprincipalobjectaccess`|
|ReferencedAttribute|`msdyn_suggestionprincipalobjectaccessid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msdyn_suggestionprincipalobjectaccess`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_connections1"></a> msfp_alert_connections1

One-To-Many Relationship: [msfp_alert msfp_alert_connections1](msfp_alert.md#BKMK_msfp_alert_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_alert_connections2"></a> msfp_alert_connections2

One-To-Many Relationship: [msfp_alert msfp_alert_connections2](msfp_alert.md#BKMK_msfp_alert_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_alert`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msfp_alert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_connections1"></a> msfp_surveyinvite_connections1

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_connections1](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyinvite_connections2"></a> msfp_surveyinvite_connections2

One-To-Many Relationship: [msfp_surveyinvite msfp_surveyinvite_connections2](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyinvite`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msfp_surveyinvite`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_connections1"></a> msfp_surveyresponse_connections1

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_connections1](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msfp_surveyresponse_connections2"></a> msfp_surveyresponse_connections2

One-To-Many Relationship: [msfp_surveyresponse msfp_surveyresponse_connections2](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`msfp_surveyresponse`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_msfp_surveyresponse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_connections1"></a> opportunity_connections1

One-To-Many Relationship: [opportunity opportunity_connections1](opportunity.md#BKMK_opportunity_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_opportunity_connections2"></a> opportunity_connections2

One-To-Many Relationship: [opportunity opportunity_connections2](opportunity.md#BKMK_opportunity_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_pricelevel_connections1"></a> pricelevel_connections1

One-To-Many Relationship: [pricelevel pricelevel_connections1](pricelevel.md#BKMK_pricelevel_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_pricelevel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_pricelevel_connections2"></a> pricelevel_connections2

One-To-Many Relationship: [pricelevel pricelevel_connections2](pricelevel.md#BKMK_pricelevel_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_pricelevel`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_connections1"></a> product_connections1

One-To-Many Relationship: [product product_connections1](product.md#BKMK_product_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_product_connections2"></a> product_connections2

One-To-Many Relationship: [product product_connections2](product.md#BKMK_product_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quote_connections1"></a> quote_connections1

One-To-Many Relationship: [quote quote_connections1](quote.md#BKMK_quote_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_quote_connections2"></a> quote_connections2

One-To-Many Relationship: [quote quote_connections2](quote.md#BKMK_quote_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_resourcegroup_connections1"></a> resourcegroup_connections1

One-To-Many Relationship: [resourcegroup resourcegroup_connections1](resourcegroup.md#BKMK_resourcegroup_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`resourcegroup`|
|ReferencedAttribute|`resourcegroupid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_resourcegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_resourcegroup_connections2"></a> resourcegroup_connections2

One-To-Many Relationship: [resourcegroup resourcegroup_connections2](resourcegroup.md#BKMK_resourcegroup_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`resourcegroup`|
|ReferencedAttribute|`resourcegroupid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_resourcegroup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_salesorder_connections1"></a> salesorder_connections1

One-To-Many Relationship: [salesorder salesorder_connections1](salesorder.md#BKMK_salesorder_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_salesorder_connections2"></a> salesorder_connections2

One-To-Many Relationship: [salesorder salesorder_connections2](salesorder.md#BKMK_salesorder_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`salesorder`|
|ReferencedAttribute|`salesorderid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_salesorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_serviceappointment_connections1"></a> serviceappointment_connections1

One-To-Many Relationship: [serviceappointment serviceappointment_connections1](serviceappointment.md#BKMK_serviceappointment_connections1)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record1id`|
|ReferencingEntityNavigationPropertyName|`record1id_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_serviceappointment_connections2"></a> serviceappointment_connections2

One-To-Many Relationship: [serviceappointment serviceappointment_connections2](serviceappointment.md#BKMK_serviceappointment_connections2)

|Property|Value|
|---|---|
|ReferencedEntity|`serviceappointment`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`record2id`|
|ReferencingEntityNavigationPropertyName|`record2id_serviceappointment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.connection?displayProperty=fullName>
