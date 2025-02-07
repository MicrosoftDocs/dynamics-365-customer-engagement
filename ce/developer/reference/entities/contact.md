---
title: "Contact table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Contact table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Contact table/entity reference (Microsoft Dynamics 365)

Person with whom a business unit has a relationship, such as customer, supplier, and colleague.

> [!NOTE]
> The Microsoft Dynamics 365 Contact table extends the [Microsoft Dataverse Contact table](/power-apps/developer/data-platform/reference/entities/contact).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BusinessCard](#BKMK_BusinessCard)
- [BusinessCardAttributes](#BKMK_BusinessCardAttributes)
- [DefaultPriceLevelId](#BKMK_DefaultPriceLevelId)
- [msdyn_contactkpiid](#BKMK_msdyn_contactkpiid)
- [msdyn_decisioninfluencetag](#BKMK_msdyn_decisioninfluencetag)
- [msdyn_gdproptout](#BKMK_msdyn_gdproptout)
- [msdyn_isassistantinorgchart](#BKMK_msdyn_isassistantinorgchart)
- [msdyn_orgchangestatus](#BKMK_msdyn_orgchangestatus)
- [msdyn_PrimaryTimeZone](#BKMK_msdyn_PrimaryTimeZone)
- [OriginatingLeadId](#BKMK_OriginatingLeadId)
- [PreferredEquipmentId](#BKMK_PreferredEquipmentId)
- [PreferredServiceId](#BKMK_PreferredServiceId)
- [TeamsFollowed](#BKMK_TeamsFollowed)

### <a name="BKMK_BusinessCard"></a> BusinessCard

|Property|Value|
|---|---|
|Description|**Stores Image of the Business Card**|
|DisplayName|**Business Card**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`businesscard`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_BusinessCardAttributes"></a> BusinessCardAttributes

|Property|Value|
|---|---|
|Description|**Stores Business Card Control Properties.**|
|DisplayName|**BusinessCardAttributes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`businesscardattributes`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_DefaultPriceLevelId"></a> DefaultPriceLevelId

|Property|Value|
|---|---|
|Description|**Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultpricelevelid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_contactkpiid"></a> msdyn_contactkpiid

|Property|Value|
|---|---|
|Description|**Maps to contact KPI records**|
|DisplayName|**KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contactkpiid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_contactkpiitem|

### <a name="BKMK_msdyn_decisioninfluencetag"></a> msdyn_decisioninfluencetag

|Property|Value|
|---|---|
|Description|**Indicate buying influence using labels**|
|DisplayName|**Decision influence labels**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_decisioninfluencetag`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`contact_msdyn_decisioninfluencetag`|

#### msdyn_decisioninfluencetag Choices/Options

|Value|Label|
|---|---|
|0|**Decision maker**|
|1|**Influencer**|
|2|**Blocker**|
|3|**Unknown**|

### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

|Property|Value|
|---|---|
|Description|**Describes whether contact is opted out or not**|
|DisplayName|**GDPR Optout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gdproptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_contact_msdyn_gdproptout`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_isassistantinorgchart"></a> msdyn_isassistantinorgchart

|Property|Value|
|---|---|
|Description|**Describes if the contact is an assistant in org chart**|
|DisplayName|**Is Assistant**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isassistantinorgchart`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`contact_msdyn_isassistantinorgchart`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_orgchangestatus"></a> msdyn_orgchangestatus

|Property|Value|
|---|---|
|Description|**Whether or not the contact belongs to the associated account**|
|DisplayName|**Not at Company Flag**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_orgchangestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`contact_msdyn_orgchangestatus`|

#### msdyn_orgchangestatus Choices/Options

|Value|Label|
|---|---|
|0|**No Feedback**|
|1|**Not at Company**|
|2|**Ignore**|

### <a name="BKMK_msdyn_PrimaryTimeZone"></a> msdyn_PrimaryTimeZone

|Property|Value|
|---|---|
|Description|**Indicates the primary time zone that the contact works on.**|
|DisplayName|**Primary Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primarytimezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_OriginatingLeadId"></a> OriginatingLeadId

|Property|Value|
|---|---|
|Description|**Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.**|
|DisplayName|**Originating Lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`originatingleadid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_PreferredEquipmentId"></a> PreferredEquipmentId

|Property|Value|
|---|---|
|Description|**Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.**|
|DisplayName|**Preferred Facility/Equipment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`preferredequipmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|equipment|

### <a name="BKMK_PreferredServiceId"></a> PreferredServiceId

|Property|Value|
|---|---|
|Description|**Choose the contact's preferred service to make sure services are scheduled correctly for the customer.**|
|DisplayName|**Preferred Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`preferredserviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|

### <a name="BKMK_TeamsFollowed"></a> TeamsFollowed

|Property|Value|
|---|---|
|Description|**Number of users or conversations followed the record**|
|DisplayName|**TeamsFollowed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`teamsfollowed`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [contact_originating_lead](#BKMK_contact_originating_lead)
- [equipment_contacts](#BKMK_equipment_contacts)
- [msdyn_msdyn_contactkpiitem_contact_contactkpiid](#BKMK_msdyn_msdyn_contactkpiitem_contact_contactkpiid)
- [price_level_contacts](#BKMK_price_level_contacts)
- [service_contacts](#BKMK_service_contacts)

### <a name="BKMK_contact_originating_lead"></a> contact_originating_lead

One-To-Many Relationship: [lead contact_originating_lead](lead.md#BKMK_contact_originating_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`originatingleadid`|
|ReferencingEntityNavigationPropertyName|`originatingleadid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_equipment_contacts"></a> equipment_contacts

One-To-Many Relationship: [equipment equipment_contacts](equipment.md#BKMK_equipment_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`preferredequipmentid`|
|ReferencingEntityNavigationPropertyName|`preferredequipmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_contactkpiitem_contact_contactkpiid"></a> msdyn_msdyn_contactkpiitem_contact_contactkpiid

One-To-Many Relationship: [msdyn_contactkpiitem msdyn_msdyn_contactkpiitem_contact_contactkpiid](msdyn_contactkpiitem.md#BKMK_msdyn_msdyn_contactkpiitem_contact_contactkpiid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_contactkpiitem`|
|ReferencedAttribute|`msdyn_contactkpiitemid`|
|ReferencingAttribute|`msdyn_contactkpiid`|
|ReferencingEntityNavigationPropertyName|`msdyn_contactkpiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_price_level_contacts"></a> price_level_contacts

One-To-Many Relationship: [pricelevel price_level_contacts](pricelevel.md#BKMK_price_level_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`defaultpricelevelid`|
|ReferencingEntityNavigationPropertyName|`defaultpricelevelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_service_contacts"></a> service_contacts

One-To-Many Relationship: [service service_contacts](service.md#BKMK_service_contacts)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`preferredserviceid`|
|ReferencingEntityNavigationPropertyName|`preferredserviceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [contact_as_primary_contact](#BKMK_contact_as_primary_contact)
- [contact_as_responsible_contact](#BKMK_contact_as_responsible_contact)
- [contact_bookableresource_ContactId](#BKMK_contact_bookableresource_ContactId)
- [contact_BulkOperations](#BKMK_contact_BulkOperations)
- [contact_CampaignResponses](#BKMK_contact_CampaignResponses)
- [contact_entitlement_ContactId](#BKMK_contact_entitlement_ContactId)
- [contact_entitlement_Customer](#BKMK_contact_entitlement_Customer)
- [contact_msdyn_copilottranscripts](#BKMK_contact_msdyn_copilottranscripts)
- [contact_msdyn_ocliveworkitems](#BKMK_contact_msdyn_ocliveworkitems)
- [contact_msdyn_ocsessions](#BKMK_contact_msdyn_ocsessions)
- [contact_msdyn_orgchartnode_msdyn_noderecord](#BKMK_contact_msdyn_orgchartnode_msdyn_noderecord)
- [contact_msfp_alerts](#BKMK_contact_msfp_alerts)
- [contact_msfp_surveyinvites](#BKMK_contact_msfp_surveyinvites)
- [contact_msfp_surveyresponses](#BKMK_contact_msfp_surveyresponses)
- [contact_Posts](#BKMK_contact_Posts)
- [Contact_ServiceAppointments](#BKMK_Contact_ServiceAppointments)
- [contract_billingcustomer_contacts](#BKMK_contract_billingcustomer_contacts)
- [contract_customer_contacts](#BKMK_contract_customer_contacts)
- [contractlineitem_customer_contacts](#BKMK_contractlineitem_customer_contacts)
- [CreatedContact_BulkOperationLogs](#BKMK_CreatedContact_BulkOperationLogs)
- [incident_customer_contacts](#BKMK_incident_customer_contacts)
- [invoice_customer_contacts](#BKMK_invoice_customer_contacts)
- [lead_customer_contacts](#BKMK_lead_customer_contacts)
- [lead_parent_contact](#BKMK_lead_parent_contact)
- [msdyn_contact_dailycontactkpiitem_entityid](#BKMK_msdyn_contact_dailycontactkpiitem_entityid)
- [msdyn_contact_msdyn_contactkpiitem_contactid](#BKMK_msdyn_contact_msdyn_contactkpiitem_contactid)
- [msdyn_contact_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_contact_msdyn_mostcontacted_regardingObjectId)
- [msdyn_contact_msdyn_mostcontactedby_regardingObjectId](#BKMK_msdyn_contact_msdyn_mostcontactedby_regardingObjectId)
- [msdyn_contact_msdyn_ocliveworkitem_Customer](#BKMK_msdyn_contact_msdyn_ocliveworkitem_Customer)
- [msdyn_contact_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_contact_msdyn_salesroutingrun_targetobject)
- [msdyn_contact_msdyn_salessuggestion](#BKMK_msdyn_contact_msdyn_salessuggestion)
- [msdyn_linkeditemvalidity_polymorphic_contactid](#BKMK_msdyn_linkeditemvalidity_polymorphic_contactid)
- [msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User](#BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User)
- [msdyn_msdyn_preferredagent_contact_msdyn_recordId](#BKMK_msdyn_msdyn_preferredagent_contact_msdyn_recordId)
- [msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid)
- [msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid](#BKMK_msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid)
- [msdyn_sabackupdiagnostic_contact_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_contact_msdyn_target)
- [msdyn_salesroutingdiagnostic_contact_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_contact_msdyn_target)
- [msdyn_sequencetarget_contact_msdyn_target](#BKMK_msdyn_sequencetarget_contact_msdyn_target)
- [opportunity_customer_contacts](#BKMK_opportunity_customer_contacts)
- [opportunity_parent_contact](#BKMK_opportunity_parent_contact)
- [order_customer_contacts](#BKMK_order_customer_contacts)
- [quote_customer_contacts](#BKMK_quote_customer_contacts)
- [SourceContact_BulkOperationLogs](#BKMK_SourceContact_BulkOperationLogs)

### <a name="BKMK_contact_as_primary_contact"></a> contact_as_primary_contact

Many-To-One Relationship: [incident contact_as_primary_contact](incident.md#BKMK_contact_as_primary_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`primarycontactid`|
|ReferencedEntityNavigationPropertyName|`contact_as_primary_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contact_as_responsible_contact"></a> contact_as_responsible_contact

Many-To-One Relationship: [incident contact_as_responsible_contact](incident.md#BKMK_contact_as_responsible_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`responsiblecontactid`|
|ReferencedEntityNavigationPropertyName|`contact_as_responsible_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contact_bookableresource_ContactId"></a> contact_bookableresource_ContactId

Many-To-One Relationship: [bookableresource contact_bookableresource_ContactId](bookableresource.md#BKMK_contact_bookableresource_ContactId)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`contactid`|
|ReferencedEntityNavigationPropertyName|`contact_bookableresource_ContactId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contact_BulkOperations"></a> contact_BulkOperations

Many-To-One Relationship: [bulkoperation contact_BulkOperations](bulkoperation.md#BKMK_contact_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_CampaignResponses"></a> contact_CampaignResponses

Many-To-One Relationship: [campaignresponse contact_CampaignResponses](campaignresponse.md#BKMK_contact_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_entitlement_ContactId"></a> contact_entitlement_ContactId

Many-To-One Relationship: [entitlement contact_entitlement_ContactId](entitlement.md#BKMK_contact_entitlement_ContactId)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`contactid`|
|ReferencedEntityNavigationPropertyName|`contact_entitlement_ContactId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contact_entitlement_Customer"></a> contact_entitlement_Customer

Many-To-One Relationship: [entitlement contact_entitlement_Customer](entitlement.md#BKMK_contact_entitlement_Customer)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`contact_entitlement_Customer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 20<br />QueryApi: null<br />ViewId: `e800e964-32d6-4024-bcea-2df605b0e762`|

### <a name="BKMK_contact_msdyn_copilottranscripts"></a> contact_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript contact_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_contact_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_msdyn_ocliveworkitems"></a> contact_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem contact_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_contact_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_msdyn_ocsessions"></a> contact_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession contact_msdyn_ocsessions](msdyn_ocsession.md#BKMK_contact_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_msdyn_orgchartnode_msdyn_noderecord"></a> contact_msdyn_orgchartnode_msdyn_noderecord

Many-To-One Relationship: [msdyn_orgchartnode contact_msdyn_orgchartnode_msdyn_noderecord](msdyn_orgchartnode.md#BKMK_contact_msdyn_orgchartnode_msdyn_noderecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orgchartnode`|
|ReferencingAttribute|`msdyn_noderecord`|
|ReferencedEntityNavigationPropertyName|`new_contact_msdyn_orgchartnodeupdated_msdyn_noderecordupdated`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: Unique indentifier for the contact entity record<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contact_msfp_alerts"></a> contact_msfp_alerts

Many-To-One Relationship: [msfp_alert contact_msfp_alerts](msfp_alert.md#BKMK_contact_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_msfp_surveyinvites"></a> contact_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite contact_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_contact_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_msfp_surveyresponses"></a> contact_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse contact_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_contact_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_Posts"></a> contact_Posts

Many-To-One Relationship: [post contact_Posts](post.md#BKMK_contact_Posts)

|Property|Value|
|---|---|
|ReferencingEntity|`post`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_Posts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Contact_ServiceAppointments"></a> Contact_ServiceAppointments

Many-To-One Relationship: [serviceappointment Contact_ServiceAppointments](serviceappointment.md#BKMK_Contact_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Contact_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contract_billingcustomer_contacts"></a> contract_billingcustomer_contacts

Many-To-One Relationship: [contract contract_billingcustomer_contacts](contract.md#BKMK_contract_billingcustomer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`billingcustomerid`|
|ReferencedEntityNavigationPropertyName|`contract_billingcustomer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_customer_contacts"></a> contract_customer_contacts

Many-To-One Relationship: [contract contract_customer_contacts](contract.md#BKMK_contract_customer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`contract_customer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Service`<br />Label: <br />MenuId: null<br />Order: 20<br />QueryApi: `CRMContract.RollupRelatedByObject`<br />ViewId: `59ef9ab3-4784-4332-96ca-b4ca2d797929`|

### <a name="BKMK_contractlineitem_customer_contacts"></a> contractlineitem_customer_contacts

Many-To-One Relationship: [contractdetail contractlineitem_customer_contacts](contractdetail.md#BKMK_contractlineitem_customer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`contractdetail`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`contractlineitem_customer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CreatedContact_BulkOperationLogs"></a> CreatedContact_BulkOperationLogs

Many-To-One Relationship: [bulkoperationlog CreatedContact_BulkOperationLogs](bulkoperationlog.md#BKMK_CreatedContact_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`createdobjectid`|
|ReferencedEntityNavigationPropertyName|`CreatedContact_BulkOperationLogs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_customer_contacts"></a> incident_customer_contacts

Many-To-One Relationship: [incident incident_customer_contacts](incident.md#BKMK_incident_customer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`incident_customer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Service`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMIncident.RollupRelatedByObject`<br />ViewId: `00000000-0000-0000-00aa-000010003501`|

### <a name="BKMK_invoice_customer_contacts"></a> invoice_customer_contacts

Many-To-One Relationship: [invoice invoice_customer_contacts](invoice.md#BKMK_invoice_customer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`invoice_customer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 40<br />QueryApi: `CRMInvoice.RollupRelatedByObject`<br />ViewId: `a84eb3ff-6dc5-4f57-bbf0-7b664c11fb62`|

### <a name="BKMK_lead_customer_contacts"></a> lead_customer_contacts

Many-To-One Relationship: [lead lead_customer_contacts](lead.md#BKMK_lead_customer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`lead_customer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_parent_contact"></a> lead_parent_contact

Many-To-One Relationship: [lead lead_parent_contact](lead.md#BKMK_lead_parent_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`parentcontactid`|
|ReferencedEntityNavigationPropertyName|`lead_parent_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `f7ba26ee-3f8e-4cf2-8e02-0b4bbcd16da8`|

### <a name="BKMK_msdyn_contact_dailycontactkpiitem_entityid"></a> msdyn_contact_dailycontactkpiitem_entityid

Many-To-One Relationship: [msdyn_dailycontactkpiitem msdyn_contact_dailycontactkpiitem_entityid](msdyn_dailycontactkpiitem.md#BKMK_msdyn_contact_dailycontactkpiitem_entityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailycontactkpiitem`|
|ReferencingAttribute|`msdyn_entityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_dailycontactkpiitem_entityid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_contactkpiitem_contactid"></a> msdyn_contact_msdyn_contactkpiitem_contactid

Many-To-One Relationship: [msdyn_contactkpiitem msdyn_contact_msdyn_contactkpiitem_contactid](msdyn_contactkpiitem.md#BKMK_msdyn_contact_msdyn_contactkpiitem_contactid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactkpiitem`|
|ReferencingAttribute|`msdyn_contactid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_contactkpiitem_contactid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_mostcontacted_regardingObjectId"></a> msdyn_contact_msdyn_mostcontacted_regardingObjectId

Many-To-One Relationship: [msdyn_mostcontacted msdyn_contact_msdyn_mostcontacted_regardingObjectId](msdyn_mostcontacted.md#BKMK_msdyn_contact_msdyn_mostcontacted_regardingObjectId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontacted`|
|ReferencingAttribute|`msdyn_contact_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_mostcontacted_regardingObjectId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_mostcontactedby_regardingObjectId"></a> msdyn_contact_msdyn_mostcontactedby_regardingObjectId

Many-To-One Relationship: [msdyn_mostcontactedby msdyn_contact_msdyn_mostcontactedby_regardingObjectId](msdyn_mostcontactedby.md#BKMK_msdyn_contact_msdyn_mostcontactedby_regardingObjectId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontactedby`|
|ReferencingAttribute|`msdyn_contact_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_mostcontactedby_regardingObjectId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_ocliveworkitem_Customer"></a> msdyn_contact_msdyn_ocliveworkitem_Customer

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_contact_msdyn_ocliveworkitem_Customer](msdyn_ocliveworkitem.md#BKMK_msdyn_contact_msdyn_ocliveworkitem_Customer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_customer`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_ocliveworkitem_Customer`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_salesroutingrun_targetobject"></a> msdyn_contact_msdyn_salesroutingrun_targetobject

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_contact_msdyn_salesroutingrun_targetobject](msdyn_salesroutingrun.md#BKMK_msdyn_contact_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_salesroutingrun_targetobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_salessuggestion"></a> msdyn_contact_msdyn_salessuggestion

Many-To-One Relationship: [msdyn_salessuggestion msdyn_contact_msdyn_salessuggestion](msdyn_salessuggestion.md#BKMK_msdyn_contact_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salessuggestion`|
|ReferencingAttribute|`msdyn_sequencecontact`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_salessuggestion`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_linkeditemvalidity_polymorphic_contactid"></a> msdyn_linkeditemvalidity_polymorphic_contactid

Many-To-One Relationship: [msdyn_linkedentityattributevalidity msdyn_linkeditemvalidity_polymorphic_contactid](msdyn_linkedentityattributevalidity.md#BKMK_msdyn_linkeditemvalidity_polymorphic_contactid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_linkedentityattributevalidity`|
|ReferencingAttribute|`msdyn_linkeditemlookup`|
|ReferencedEntityNavigationPropertyName|`msdyn_linkeditemvalidity_polymorphic_contactid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User"></a> msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User

Many-To-One Relationship: [msdyn_conversationparticipantinsights msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User](msdyn_conversationparticipantinsights.md#BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantinsights`|
|ReferencingAttribute|`msdyn_user`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationparticipantinsights_contact_msdyn_user`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_preferredagent_contact_msdyn_recordId"></a> msdyn_msdyn_preferredagent_contact_msdyn_recordId

Many-To-One Relationship: [msdyn_preferredagent msdyn_msdyn_preferredagent_contact_msdyn_recordId](msdyn_preferredagent.md#BKMK_msdyn_msdyn_preferredagent_contact_msdyn_recordId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagent`|
|ReferencingAttribute|`msdyn_recordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_preferredagent_contact_msdyn_recordId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid"></a> msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid

Many-To-One Relationship: [msdyn_salescopilotinsight msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid](msdyn_salescopilotinsight.md#BKMK_msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid"></a> msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid

Many-To-One Relationship: [msdyn_taggedrecord msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid](msdyn_taggedrecord.md#BKMK_msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_taggedrecord`|
|ReferencingAttribute|`msdyn_dynamicsrecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_contact_msdyn_target"></a> msdyn_sabackupdiagnostic_contact_msdyn_target

Many-To-One Relationship: [msdyn_sabackupdiagnostic msdyn_sabackupdiagnostic_contact_msdyn_target](msdyn_sabackupdiagnostic.md#BKMK_msdyn_sabackupdiagnostic_contact_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sabackupdiagnostic`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_contact_msdyn_target`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_contact_msdyn_target"></a> msdyn_salesroutingdiagnostic_contact_msdyn_target

Many-To-One Relationship: [msdyn_salesroutingdiagnostic msdyn_salesroutingdiagnostic_contact_msdyn_target](msdyn_salesroutingdiagnostic.md#BKMK_msdyn_salesroutingdiagnostic_contact_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingdiagnostic`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_contact_msdyn_target`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_contact_msdyn_target"></a> msdyn_sequencetarget_contact_msdyn_target

Many-To-One Relationship: [msdyn_sequencetarget msdyn_sequencetarget_contact_msdyn_target](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_contact_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_contact_msdyn_target`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_customer_contacts"></a> opportunity_customer_contacts

Many-To-One Relationship: [opportunity opportunity_customer_contacts](opportunity.md#BKMK_opportunity_customer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`opportunity_customer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMOpportunity.RollupRelatedByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001203`|

### <a name="BKMK_opportunity_parent_contact"></a> opportunity_parent_contact

Many-To-One Relationship: [opportunity opportunity_parent_contact](opportunity.md#BKMK_opportunity_parent_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`parentcontactid`|
|ReferencedEntityNavigationPropertyName|`opportunity_parent_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-00aa-000010001203`|

### <a name="BKMK_order_customer_contacts"></a> order_customer_contacts

Many-To-One Relationship: [salesorder order_customer_contacts](salesorder.md#BKMK_order_customer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`order_customer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 30<br />QueryApi: `CRMSalesOrder.RollupRelatedByObject`<br />ViewId: `71f7da6e-2772-4097-89d1-3670ff8348bb`|

### <a name="BKMK_quote_customer_contacts"></a> quote_customer_contacts

Many-To-One Relationship: [quote quote_customer_contacts](quote.md#BKMK_quote_customer_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`quote_customer_contacts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 20<br />QueryApi: `CRMQuote.RollupRelatedByObject`<br />ViewId: `642095db-91dd-4813-bb31-665a3a2bae61`|

### <a name="BKMK_SourceContact_BulkOperationLogs"></a> SourceContact_BulkOperationLogs

Many-To-One Relationship: [bulkoperationlog SourceContact_BulkOperationLogs](bulkoperationlog.md#BKMK_SourceContact_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SourceContact_BulkOperationLogs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [BulkOperation_Contacts](#BKMK_BulkOperation_Contacts)
- [CampaignActivity_Contacts](#BKMK_CampaignActivity_Contacts)
- [contactinvoices_association](#BKMK_contactinvoices_association)
- [contactleads_association](#BKMK_contactleads_association)
- [contactorders_association](#BKMK_contactorders_association)
- [contactquotes_association](#BKMK_contactquotes_association)
- [entitlementcontacts_association](#BKMK_entitlementcontacts_association)
- [listcontact_association](#BKMK_listcontact_association)
- [servicecontractcontacts_association](#BKMK_servicecontractcontacts_association)

### <a name="BKMK_BulkOperation_Contacts"></a> BulkOperation_Contacts

See [bulkoperation BulkOperation_Contacts Many-To-Many Relationship](bulkoperation.md#BKMK_BulkOperation_Contacts)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`BulkOperation_Contacts`|
|IntersectAttribute|`regardingobjectid`|
|NavigationPropertyName|`BulkOperation_Logs_Contacts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 12<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Contacts"></a> CampaignActivity_Contacts

See [campaignactivity CampaignActivity_Contacts Many-To-Many Relationship](campaignactivity.md#BKMK_CampaignActivity_Contacts)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Contacts`|
|IntersectAttribute|`regardingobjectid`|
|NavigationPropertyName|`CampaignActivity_Logs_Contacts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 12<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contactinvoices_association"></a> contactinvoices_association

See [invoice contactinvoices_association Many-To-Many Relationship](invoice.md#BKMK_contactinvoices_association)

|Property|Value|
|---|---|
|IntersectEntityName|`contactinvoices`|
|IsCustomizable|False|
|SchemaName|`contactinvoices_association`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`contactinvoices_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMInvoice.RetrieveContacts`<br />ViewId: `00000000-0000-0000-00aa-000010001210`|

### <a name="BKMK_contactleads_association"></a> contactleads_association

See [lead contactleads_association Many-To-Many Relationship](lead.md#BKMK_contactleads_association)

|Property|Value|
|---|---|
|IntersectEntityName|`contactleads`|
|IsCustomizable|False|
|SchemaName|`contactleads_association`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`contactleads_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contactorders_association"></a> contactorders_association

See [salesorder contactorders_association Many-To-Many Relationship](salesorder.md#BKMK_contactorders_association)

|Property|Value|
|---|---|
|IntersectEntityName|`contactorders`|
|IsCustomizable|False|
|SchemaName|`contactorders_association`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`contactorders_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contactquotes_association"></a> contactquotes_association

See [quote contactquotes_association Many-To-Many Relationship](quote.md#BKMK_contactquotes_association)

|Property|Value|
|---|---|
|IntersectEntityName|`contactquotes`|
|IsCustomizable|False|
|SchemaName|`contactquotes_association`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`contactquotes_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_entitlementcontacts_association"></a> entitlementcontacts_association

See [entitlement entitlementcontacts_association Many-To-Many Relationship](entitlement.md#BKMK_entitlementcontacts_association)

|Property|Value|
|---|---|
|IntersectEntityName|`entitlementcontacts`|
|IsCustomizable|False|
|SchemaName|`entitlementcontacts_association`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`entitlementcontacts_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_listcontact_association"></a> listcontact_association

See [list listcontact_association Many-To-Many Relationship](list.md#BKMK_listcontact_association)

|Property|Value|
|---|---|
|IntersectEntityName|`listmember`|
|IsCustomizable|False|
|SchemaName|`listcontact_association`|
|IntersectAttribute|`entityid`|
|NavigationPropertyName|`listcontact_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `List.RetrieveListsForMember`<br />ViewId: `bdd93547-53f6-4609-b591-9f48ce86295f`|

### <a name="BKMK_servicecontractcontacts_association"></a> servicecontractcontacts_association

See [contract servicecontractcontacts_association Many-To-Many Relationship](contract.md#BKMK_servicecontractcontacts_association)

|Property|Value|
|---|---|
|IntersectEntityName|`servicecontractcontacts`|
|IsCustomizable|False|
|SchemaName|`servicecontractcontacts_association`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`servicecontractcontacts_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.contact?displayProperty=fullName>
