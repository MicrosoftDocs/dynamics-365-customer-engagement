---
title: "Contact table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Contact table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Contact table/entity reference

Person with whom a business unit has a relationship, such as customer, supplier, and colleague.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Contact table extends the [Microsoft Dataverse Contact table](/power-apps/developer/data-platform/reference/entities/contact).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_preferredlanguageid](#BKMK_adx_preferredlanguageid)
- [BusinessCard](#BKMK_BusinessCard)
- [BusinessCardAttributes](#BKMK_BusinessCardAttributes)
- [DefaultPriceLevelId](#BKMK_DefaultPriceLevelId)
- [msdyn_contactkpiid](#BKMK_msdyn_contactkpiid)
- [msdyn_decisioninfluencetag](#BKMK_msdyn_decisioninfluencetag)
- [msdyn_gdproptout](#BKMK_msdyn_gdproptout)
- [msdyn_isassistantinorgchart](#BKMK_msdyn_isassistantinorgchart)
- [msdyn_orgchangestatus](#BKMK_msdyn_orgchangestatus)
- [msdyn_PrimaryTimeZone](#BKMK_msdyn_PrimaryTimeZone)
- [msdyn_segmentid](#BKMK_msdyn_segmentid)
- [msdyncrm_ContactId](#BKMK_msdyncrm_ContactId)
- [msdyncrm_customerjourneyid](#BKMK_msdyncrm_customerjourneyid)
- [msdyncrm_emailid](#BKMK_msdyncrm_emailid)
- [msdyncrm_insights_placeholder](#BKMK_msdyncrm_insights_placeholder)
- [msdyncrm_marketingformid](#BKMK_msdyncrm_marketingformid)
- [msdyncrm_marketingformsubmissiondateprecise](#BKMK_msdyncrm_marketingformsubmissiondateprecise)
- [msdyncrm_marketingpageid](#BKMK_msdyncrm_marketingpageid)
- [msdyncrm_rememberMe](#BKMK_msdyncrm_rememberMe)
- [msdyncrm_SegmentMemberId](#BKMK_msdyncrm_SegmentMemberId)
- [msdynmkt_customerjourneyid](#BKMK_msdynmkt_customerjourneyid)
- [msdynmkt_emailid](#BKMK_msdynmkt_emailid)
- [msdynmkt_marketingformid](#BKMK_msdynmkt_marketingformid)
- [msevtmgt_aadobjectid](#BKMK_msevtmgt_aadobjectid)
- [msevtmgt_ContactId](#BKMK_msevtmgt_ContactId)
- [msevtmgt_originatingeventid](#BKMK_msevtmgt_originatingeventid)
- [msgdpr_consentchangesourceformId](#BKMK_msgdpr_consentchangesourceformId)
- [msgdpr_donottrack](#BKMK_msgdpr_donottrack)
- [msgdpr_gdprconsent](#BKMK_msgdpr_gdprconsent)
- [msgdpr_gdprischild](#BKMK_msgdpr_gdprischild)
- [msgdpr_GDPRParentId](#BKMK_msgdpr_GDPRParentId)
- [OriginatingLeadId](#BKMK_OriginatingLeadId)
- [PreferredEquipmentId](#BKMK_PreferredEquipmentId)
- [PreferredServiceId](#BKMK_PreferredServiceId)
- [TeamsFollowed](#BKMK_TeamsFollowed)

### <a name="BKMK_adx_preferredlanguageid"></a> adx_preferredlanguageid

|Property|Value|
|---|---|
|Description|**User’s preferred portal language**|
|DisplayName|**Preferred Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_preferredlanguageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_portallanguage|

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

### <a name="BKMK_msdyn_segmentid"></a> msdyn_segmentid

|Property|Value|
|---|---|
|Description|**Unique identifier for Segment associated with contact.**|
|DisplayName|**Segment Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_segment|

### <a name="BKMK_msdyncrm_ContactId"></a> msdyncrm_ContactId

|Property|Value|
|---|---|
|Description|**Unique identifier for Quick Send Email associated with Contact.**|
|DisplayName|**SendNow Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_quicksendemail|

### <a name="BKMK_msdyncrm_customerjourneyid"></a> msdyncrm_customerjourneyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source customer journey (outbound marketing)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_customerjourney|

### <a name="BKMK_msdyncrm_emailid"></a> msdyncrm_emailid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source email (outbound marketing)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingemail|

### <a name="BKMK_msdyncrm_insights_placeholder"></a> msdyncrm_insights_placeholder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_insights_placeholder`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_marketingformid"></a> msdyncrm_marketingformid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source form (outbound marketing)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingform|

### <a name="BKMK_msdyncrm_marketingformsubmissiondateprecise"></a> msdyncrm_marketingformsubmissiondateprecise

|Property|Value|
|---|---|
|Description||
|DisplayName|**timestamp of form submission (outbound marketing)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformsubmissiondateprecise`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_marketingpageid"></a> msdyncrm_marketingpageid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source landing page (outbound marketing)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingpageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingpage|

### <a name="BKMK_msdyncrm_rememberMe"></a> msdyncrm_rememberMe

|Property|Value|
|---|---|
|Description||
|DisplayName|**Remember me**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_rememberme`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_contact_msdyncrm_rememberme`|
|DefaultValue|False|
|True Label|Allow|
|False Label|Do not allow|

### <a name="BKMK_msdyncrm_SegmentMemberId"></a> msdyncrm_SegmentMemberId

|Property|Value|
|---|---|
|Description|**Unique identifier for Segment associated with Contact.**|
|DisplayName|**SegmentMember**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_segmentmemberid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_segment|

### <a name="BKMK_msdynmkt_customerjourneyid"></a> msdynmkt_customerjourneyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source customer journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_customerjourneyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_journey|

### <a name="BKMK_msdynmkt_emailid"></a> msdynmkt_emailid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_email|

### <a name="BKMK_msdynmkt_marketingformid"></a> msdynmkt_marketingformid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingformid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_marketingform|

### <a name="BKMK_msevtmgt_aadobjectid"></a> msevtmgt_aadobjectid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Microsoft Entra Object ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_aadobjectid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_ContactId"></a> msevtmgt_ContactId

|Property|Value|
|---|---|
|Description|**Unique identifier for the check-in associated with the contact**|
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_checkin|

### <a name="BKMK_msevtmgt_originatingeventid"></a> msevtmgt_originatingeventid

|Property|Value|
|---|---|
|Description|**For contacts created by registering for an event in Microsoft Dynamics 365, this identifies the relevant event. This is used to relate the contact to the data on the originating event.**|
|DisplayName|**Originating event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_originatingeventid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msgdpr_consentchangesourceformId"></a> msgdpr_consentchangesourceformId

|Property|Value|
|---|---|
|Description||
|DisplayName|**consent change source form Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_consentchangesourceformid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingform|

### <a name="BKMK_msgdpr_donottrack"></a> msgdpr_donottrack

|Property|Value|
|---|---|
|Description|**Select whether contact allows tracking interaction data. If Do Not Allow is selected, Microsoft Dynamics 365 will not save interaction data for the contact.**|
|DisplayName|**Do not track**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_donottrack`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msgdpr_contact_msgdpr_donottrack`|
|DefaultValue|False|
|True Label|Do Not Allow|
|False Label|Allow|

### <a name="BKMK_msgdpr_gdprconsent"></a> msgdpr_gdprconsent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent given**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_gdprconsent`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|587030001|
|GlobalChoiceName|`msgdpr_gdpr_consent_option_set`|

#### msgdpr_gdprconsent Choices/Options

|Value|Label|
|---|---|
|587030001|**(1) Consent**|
|587030002|**(2) Transactional**|
|587030003|**(3) Subscriptions**|
|587030004|**(4) Marketing**|
|587030005|**(5) Profiling**|

### <a name="BKMK_msgdpr_gdprischild"></a> msgdpr_gdprischild

|Property|Value|
|---|---|
|Description||
|DisplayName|**GDPR is child**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_gdprischild`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msgdpr_contact_msgdpr_gdprischild`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msgdpr_GDPRParentId"></a> msgdpr_GDPRParentId

|Property|Value|
|---|---|
|Description|**Unique identifier for the contact associated with the contact**|
|DisplayName|**Parent or custodian**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msgdpr_gdprparentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

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


## Customized columns/attributes

Microsoft Dynamics 365 Field Service modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_BirthDate"></a> BirthDate

Changes from [BirthDate (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/contact#BKMK_BirthDate)

|Property|Value|
|---|---|
|RequiredLevel|Recommended|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [adx_portallanguage_contact](#BKMK_adx_portallanguage_contact)
- [contact_originating_lead](#BKMK_contact_originating_lead)
- [equipment_contacts](#BKMK_equipment_contacts)
- [msdyn_msdyn_contactkpiitem_contact_contactkpiid](#BKMK_msdyn_msdyn_contactkpiitem_contact_contactkpiid)
- [msdyn_msdyn_segment_contact](#BKMK_msdyn_msdyn_segment_contact)
- [msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid](#BKMK_msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid)
- [msdyncrm_msdyncrm_marketingemail_contact_emailid](#BKMK_msdyncrm_msdyncrm_marketingemail_contact_emailid)
- [msdyncrm_msdyncrm_marketingform_contact_marketingformid](#BKMK_msdyncrm_msdyncrm_marketingform_contact_marketingformid)
- [msdyncrm_msdyncrm_marketingpage_contact_marketingpageid](#BKMK_msdyncrm_msdyncrm_marketingpage_contact_marketingpageid)
- [msdyncrm_msdyncrm_segment_contact](#BKMK_msdyncrm_msdyncrm_segment_contact)
- [msdyncrm_quicksendemail_contact](#BKMK_msdyncrm_quicksendemail_contact)
- [msdynmkt_msdynmkt_email_contact_emailid](#BKMK_msdynmkt_msdynmkt_email_contact_emailid)
- [msdynmkt_msdynmkt_journey_contact_customerjourneyid](#BKMK_msdynmkt_msdynmkt_journey_contact_customerjourneyid)
- [msdynmkt_msdynmkt_marketingform_contact_marketingformid](#BKMK_msdynmkt_msdynmkt_marketingform_contact_marketingformid)
- [msevtmgt_checkin_contact](#BKMK_msevtmgt_checkin_contact)
- [msevtmgt_msevtmgt_event_contact_originatingeventid](#BKMK_msevtmgt_msevtmgt_event_contact_originatingeventid)
- [msgdpr_contact_msgdpr_gdprparent](#BKMK_msgdpr_contact_msgdpr_gdprparent-many-to-one)
- [msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId](#BKMK_msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId)
- [price_level_contacts](#BKMK_price_level_contacts)
- [service_contacts](#BKMK_service_contacts)

### <a name="BKMK_adx_portallanguage_contact"></a> adx_portallanguage_contact

One-To-Many Relationship: [adx_portallanguage adx_portallanguage_contact](adx_portallanguage.md#BKMK_adx_portallanguage_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_portallanguage`|
|ReferencedAttribute|`adx_portallanguageid`|
|ReferencingAttribute|`adx_preferredlanguageid`|
|ReferencingEntityNavigationPropertyName|`adx_preferredlanguageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

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

### <a name="BKMK_msdyn_msdyn_segment_contact"></a> msdyn_msdyn_segment_contact

One-To-Many Relationship: [msdyn_segment msdyn_msdyn_segment_contact](msdyn_segment.md#BKMK_msdyn_msdyn_segment_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_segment`|
|ReferencedAttribute|`msdyn_segmentid`|
|ReferencingAttribute|`msdyn_segmentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_segmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid"></a> msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid](msdyncrm_customerjourney.md#BKMK_msdyncrm_msdyncrm_customerjourney_contact_customerjourneyid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`msdyncrm_customerjourneyid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_customerjourneyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemail_contact_emailid"></a> msdyncrm_msdyncrm_marketingemail_contact_emailid

One-To-Many Relationship: [msdyncrm_marketingemail msdyncrm_msdyncrm_marketingemail_contact_emailid](msdyncrm_marketingemail.md#BKMK_msdyncrm_msdyncrm_marketingemail_contact_emailid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemail`|
|ReferencedAttribute|`msdyncrm_marketingemailid`|
|ReferencingAttribute|`msdyncrm_emailid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_emailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingform_contact_marketingformid"></a> msdyncrm_msdyncrm_marketingform_contact_marketingformid

One-To-Many Relationship: [msdyncrm_marketingform msdyncrm_msdyncrm_marketingform_contact_marketingformid](msdyncrm_marketingform.md#BKMK_msdyncrm_msdyncrm_marketingform_contact_marketingformid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingform`|
|ReferencedAttribute|`msdyncrm_marketingformid`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingformid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingpage_contact_marketingpageid"></a> msdyncrm_msdyncrm_marketingpage_contact_marketingpageid

One-To-Many Relationship: [msdyncrm_marketingpage msdyncrm_msdyncrm_marketingpage_contact_marketingpageid](msdyncrm_marketingpage.md#BKMK_msdyncrm_msdyncrm_marketingpage_contact_marketingpageid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpage`|
|ReferencedAttribute|`msdyncrm_marketingpageid`|
|ReferencingAttribute|`msdyncrm_marketingpageid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_segment_contact"></a> msdyncrm_msdyncrm_segment_contact

One-To-Many Relationship: [msdyncrm_segment msdyncrm_msdyncrm_segment_contact](msdyncrm_segment.md#BKMK_msdyncrm_msdyncrm_segment_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_segment`|
|ReferencedAttribute|`msdyncrm_segmentid`|
|ReferencingAttribute|`msdyncrm_segmentmemberid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_SegmentMemberId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_quicksendemail_contact"></a> msdyncrm_quicksendemail_contact

One-To-Many Relationship: [msdyncrm_quicksendemail msdyncrm_quicksendemail_contact](msdyncrm_quicksendemail.md#BKMK_msdyncrm_quicksendemail_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_quicksendemail`|
|ReferencedAttribute|`msdyncrm_quicksendemailid`|
|ReferencingAttribute|`msdyncrm_contactid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_ContactId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_email_contact_emailid"></a> msdynmkt_msdynmkt_email_contact_emailid

One-To-Many Relationship: [msdynmkt_email msdynmkt_msdynmkt_email_contact_emailid](msdynmkt_email.md#BKMK_msdynmkt_msdynmkt_email_contact_emailid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_email`|
|ReferencedAttribute|`msdynmkt_emailid`|
|ReferencingAttribute|`msdynmkt_emailid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_emailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_journey_contact_customerjourneyid"></a> msdynmkt_msdynmkt_journey_contact_customerjourneyid

One-To-Many Relationship: [msdynmkt_journey msdynmkt_msdynmkt_journey_contact_customerjourneyid](msdynmkt_journey.md#BKMK_msdynmkt_msdynmkt_journey_contact_customerjourneyid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_journey`|
|ReferencedAttribute|`msdynmkt_journeyid`|
|ReferencingAttribute|`msdynmkt_customerjourneyid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_customerjourneyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_marketingform_contact_marketingformid"></a> msdynmkt_msdynmkt_marketingform_contact_marketingformid

One-To-Many Relationship: [msdynmkt_marketingform msdynmkt_msdynmkt_marketingform_contact_marketingformid](msdynmkt_marketingform.md#BKMK_msdynmkt_msdynmkt_marketingform_contact_marketingformid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_marketingform`|
|ReferencedAttribute|`msdynmkt_marketingformid`|
|ReferencingAttribute|`msdynmkt_marketingformid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_marketingformid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_checkin_contact"></a> msevtmgt_checkin_contact

One-To-Many Relationship: [msevtmgt_checkin msevtmgt_checkin_contact](msevtmgt_checkin.md#BKMK_msevtmgt_checkin_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_checkin`|
|ReferencedAttribute|`msevtmgt_checkinid`|
|ReferencingAttribute|`msevtmgt_contactid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_ContactId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_msevtmgt_event_contact_originatingeventid"></a> msevtmgt_msevtmgt_event_contact_originatingeventid

One-To-Many Relationship: [msevtmgt_event msevtmgt_msevtmgt_event_contact_originatingeventid](msevtmgt_event.md#BKMK_msevtmgt_msevtmgt_event_contact_originatingeventid)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_originatingeventid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_originatingeventid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msgdpr_contact_msgdpr_gdprparent-many-to-one"></a> msgdpr_contact_msgdpr_gdprparent

One-To-Many Relationship: [contact msgdpr_contact_msgdpr_gdprparent](#BKMK_msgdpr_contact_msgdpr_gdprparent-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msgdpr_gdprparentid`|
|ReferencingEntityNavigationPropertyName|`msgdpr_GDPRParentId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId"></a> msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId

One-To-Many Relationship: [msdyncrm_marketingform msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId](msdyncrm_marketingform.md#BKMK_msgdpr_msdyncrm_marketingform_contact_consentchangesourceformId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingform`|
|ReferencedAttribute|`msdyncrm_marketingformid`|
|ReferencingAttribute|`msgdpr_consentchangesourceformid`|
|ReferencingEntityNavigationPropertyName|`msgdpr_consentchangesourceformId`|
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

- [adx_changedcontact_webpagehistory](#BKMK_adx_changedcontact_webpagehistory)
- [adx_contact_adx_casedeflection_Contact](#BKMK_adx_contact_adx_casedeflection_Contact)
- [adx_contact_communityforumalert](#BKMK_adx_contact_communityforumalert)
- [adx_contact_communityforumannouncement](#BKMK_adx_contact_communityforumannouncement)
- [adx_contact_communityforumpost](#BKMK_adx_contact_communityforumpost)
- [adx_contact_forumnotification](#BKMK_adx_contact_forumnotification)
- [adx_contact_pagenotification](#BKMK_adx_contact_pagenotification)
- [adx_contact_pollsubmission](#BKMK_adx_contact_pollsubmission)
- [adx_contact_webfilelog](#BKMK_adx_contact_webfilelog)
- [adx_contact_webpage](#BKMK_adx_contact_webpage)
- [adx_contact_webpagelog](#BKMK_adx_contact_webpagelog)
- [adx_subscribercontact_pagealert](#BKMK_adx_subscribercontact_pagealert)
- [bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8](#BKMK_bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8)
- [contact_adx_alertsubscriptions](#BKMK_contact_adx_alertsubscriptions)
- [contact_as_primary_contact](#BKMK_contact_as_primary_contact)
- [contact_as_responsible_contact](#BKMK_contact_as_responsible_contact)
- [contact_bookableresource_ContactId](#BKMK_contact_bookableresource_ContactId)
- [contact_BulkOperations](#BKMK_contact_BulkOperations)
- [contact_CampaignResponses](#BKMK_contact_CampaignResponses)
- [contact_entitlement_ContactId](#BKMK_contact_entitlement_ContactId)
- [contact_entitlement_Customer](#BKMK_contact_entitlement_Customer)
- [contact_li_inmails](#BKMK_contact_li_inmails)
- [contact_li_messages](#BKMK_contact_li_messages)
- [contact_li_pointdrivepresentationvieweds](#BKMK_contact_li_pointdrivepresentationvieweds)
- [contact_msdyn_bookingalerts](#BKMK_contact_msdyn_bookingalerts)
- [contact_msdyn_copilottranscripts](#BKMK_contact_msdyn_copilottranscripts)
- [contact_msdyn_ocliveworkitems](#BKMK_contact_msdyn_ocliveworkitems)
- [contact_msdyn_ocoutboundmessages](#BKMK_contact_msdyn_ocoutboundmessages)
- [contact_msdyn_ocsessions](#BKMK_contact_msdyn_ocsessions)
- [contact_msdyn_ocvoicemails](#BKMK_contact_msdyn_ocvoicemails)
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
- [msa_contact_incident](#BKMK_msa_contact_incident)
- [msa_contact_opportunity](#BKMK_msa_contact_opportunity)
- [msdyn_contact_dailycontactkpiitem_entityid](#BKMK_msdyn_contact_dailycontactkpiitem_entityid)
- [msdyn_contact_msdyn_actual_ContactCustomer](#BKMK_msdyn_contact_msdyn_actual_ContactCustomer)
- [msdyn_contact_msdyn_actual_ContactVendor](#BKMK_msdyn_contact_msdyn_actual_ContactVendor)
- [msdyn_contact_msdyn_contactkpiitem_contactid](#BKMK_msdyn_contact_msdyn_contactkpiitem_contactid)
- [msdyn_contact_msdyn_liveconversation_Customer](#BKMK_msdyn_contact_msdyn_liveconversation_Customer)
- [msdyn_contact_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_contact_msdyn_mostcontacted_regardingObjectId)
- [msdyn_contact_msdyn_mostcontactedby_regardingObjectId](#BKMK_msdyn_contact_msdyn_mostcontactedby_regardingObjectId)
- [msdyn_contact_msdyn_ocliveworkitem_Customer](#BKMK_msdyn_contact_msdyn_ocliveworkitem_Customer)
- [msdyn_contact_msdyn_ocvoicemail_Customer](#BKMK_msdyn_contact_msdyn_ocvoicemail_Customer)
- [msdyn_contact_msdyn_rma_RequestedByContact](#BKMK_msdyn_contact_msdyn_rma_RequestedByContact)
- [msdyn_contact_msdyn_rtv_VendorContact](#BKMK_msdyn_contact_msdyn_rtv_VendorContact)
- [msdyn_contact_msdyn_salespremiumdemo_contact](#BKMK_msdyn_contact_msdyn_salespremiumdemo_contact)
- [msdyn_contact_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_contact_msdyn_salesroutingrun_targetobject)
- [msdyn_contact_msdyn_salessuggestion](#BKMK_msdyn_contact_msdyn_salessuggestion)
- [msdyn_contact_msdyn_workorder_ReportedByContact](#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact)
- [msdyn_linkeditemvalidity_polymorphic_contactid](#BKMK_msdyn_linkeditemvalidity_polymorphic_contactid)
- [msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User](#BKMK_msdyn_msdyn_conversationparticipantinsights_contact_msdyn_User)
- [msdyn_msdyn_preferredagent_contact_msdyn_recordId](#BKMK_msdyn_msdyn_preferredagent_contact_msdyn_recordId)
- [msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_contact_msdyn_targetentityid)
- [msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid](#BKMK_msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid)
- [msdyn_playbookinstance_contact](#BKMK_msdyn_playbookinstance_contact)
- [msdyn_sabackupdiagnostic_contact_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_contact_msdyn_target)
- [msdyn_salesroutingdiagnostic_contact_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_contact_msdyn_target)
- [msdyn_sequencetarget_contact_msdyn_target](#BKMK_msdyn_sequencetarget_contact_msdyn_target)
- [msdyncrm_contact_marketingformsubmission_matched](#BKMK_msdyncrm_contact_marketingformsubmission_matched)
- [msdyncrm_contact_marketingformsubmission_original](#BKMK_msdyncrm_contact_marketingformsubmission_original)
- [msdyncrm_contact_msdyncrm_customerjourneycustomchannelactivity_Contact](#BKMK_msdyncrm_contact_msdyncrm_customerjourneycustomchannelactivity_Contact)
- [msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact](#BKMK_msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact)
- [msdyncrm_contact_msdyncrm_geopin](#BKMK_msdyncrm_contact_msdyncrm_geopin)
- [msdyncrm_contact_msdyncrm_linkedinformsubmission_contact](#BKMK_msdyncrm_contact_msdyncrm_linkedinformsubmission_contact)
- [msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid](#BKMK_msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid)
- [msevtmgt_contact_eventregistration_registeredby](#BKMK_msevtmgt_contact_eventregistration_registeredby)
- [msevtmgt_contact_msevtmgt_attendeepass_contact](#BKMK_msevtmgt_contact_msevtmgt_attendeepass_contact)
- [msevtmgt_contact_msevtmgt_building_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_building_PrimaryContact)
- [msevtmgt_contact_msevtmgt_checkin_Contact](#BKMK_msevtmgt_contact_msevtmgt_checkin_Contact)
- [msevtmgt_contact_msevtmgt_eventpurchase](#BKMK_msevtmgt_contact_msevtmgt_eventpurchase)
- [msevtmgt_contact_msevtmgt_eventpurchaseattendee](#BKMK_msevtmgt_contact_msevtmgt_eventpurchaseattendee)
- [msevtmgt_contact_msevtmgt_eventregistration_Contact](#BKMK_msevtmgt_contact_msevtmgt_eventregistration_Contact)
- [msevtmgt_contact_msevtmgt_eventteammember_Contact](#BKMK_msevtmgt_contact_msevtmgt_eventteammember_Contact)
- [msevtmgt_contact_msevtmgt_hotel_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_hotel_PrimaryContact)
- [msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact)
- [msevtmgt_contact_msevtmgt_room_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_room_PrimaryContact)
- [msevtmgt_contact_msevtmgt_sessionregistration_contactid](#BKMK_msevtmgt_contact_msevtmgt_sessionregistration_contactid)
- [msevtmgt_contact_msevtmgt_speaker_Contact](#BKMK_msevtmgt_contact_msevtmgt_speaker_Contact)
- [msevtmgt_contact_msevtmgt_venue_PrimaryContact](#BKMK_msevtmgt_contact_msevtmgt_venue_PrimaryContact)
- [msevtmgt_contact_waitlistitem](#BKMK_msevtmgt_contact_waitlistitem)
- [msevtmgt_contact_waitlistitem_addedby](#BKMK_msevtmgt_contact_waitlistitem_addedby)
- [msgdpr_contact_msgdpr_gdprconsentchangerecord](#BKMK_msgdpr_contact_msgdpr_gdprconsentchangerecord)
- [msgdpr_contact_msgdpr_gdprparent](#BKMK_msgdpr_contact_msgdpr_gdprparent-one-to-many)
- [opportunity_customer_contacts](#BKMK_opportunity_customer_contacts)
- [opportunity_parent_contact](#BKMK_opportunity_parent_contact)
- [order_customer_contacts](#BKMK_order_customer_contacts)
- [quote_customer_contacts](#BKMK_quote_customer_contacts)
- [SourceContact_BulkOperationLogs](#BKMK_SourceContact_BulkOperationLogs)

### <a name="BKMK_adx_changedcontact_webpagehistory"></a> adx_changedcontact_webpagehistory

Many-To-One Relationship: [adx_webpagehistory adx_changedcontact_webpagehistory](adx_webpagehistory.md#BKMK_adx_changedcontact_webpagehistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpagehistory`|
|ReferencingAttribute|`adx_changedbyid`|
|ReferencedEntityNavigationPropertyName|`adx_changedcontact_webpagehistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102900<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_adx_casedeflection_Contact"></a> adx_contact_adx_casedeflection_Contact

Many-To-One Relationship: [adx_casedeflection adx_contact_adx_casedeflection_Contact](adx_casedeflection.md#BKMK_adx_contact_adx_casedeflection_Contact)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_casedeflection`|
|ReferencingAttribute|`adx_contact`|
|ReferencedEntityNavigationPropertyName|`adx_contact_adx_casedeflection_Contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_communityforumalert"></a> adx_contact_communityforumalert

Many-To-One Relationship: [adx_communityforumalert adx_contact_communityforumalert](adx_communityforumalert.md#BKMK_adx_contact_communityforumalert)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumalert`|
|ReferencingAttribute|`adx_subscriberid`|
|ReferencedEntityNavigationPropertyName|`adx_contact_communityforumalert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_communityforumannouncement"></a> adx_contact_communityforumannouncement

Many-To-One Relationship: [adx_communityforumannouncement adx_contact_communityforumannouncement](adx_communityforumannouncement.md#BKMK_adx_contact_communityforumannouncement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumannouncement`|
|ReferencingAttribute|`adx_authorid`|
|ReferencedEntityNavigationPropertyName|`adx_contact_communityforumannouncement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_communityforumpost"></a> adx_contact_communityforumpost

Many-To-One Relationship: [adx_communityforumpost adx_contact_communityforumpost](adx_communityforumpost.md#BKMK_adx_contact_communityforumpost)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforumpost`|
|ReferencingAttribute|`adx_authorid`|
|ReferencedEntityNavigationPropertyName|`adx_contact_communityforumpost`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_forumnotification"></a> adx_contact_forumnotification

Many-To-One Relationship: [adx_forumnotification adx_contact_forumnotification](adx_forumnotification.md#BKMK_adx_contact_forumnotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumnotification`|
|ReferencingAttribute|`adx_recipient`|
|ReferencedEntityNavigationPropertyName|`adx_contact_forumnotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_pagenotification"></a> adx_contact_pagenotification

Many-To-One Relationship: [adx_pagenotification adx_contact_pagenotification](adx_pagenotification.md#BKMK_adx_contact_pagenotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagenotification`|
|ReferencingAttribute|`adx_recipient`|
|ReferencedEntityNavigationPropertyName|`adx_contact_pagenotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_pollsubmission"></a> adx_contact_pollsubmission

Many-To-One Relationship: [adx_pollsubmission adx_contact_pollsubmission](adx_pollsubmission.md#BKMK_adx_contact_pollsubmission)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pollsubmission`|
|ReferencingAttribute|`adx_contactid`|
|ReferencedEntityNavigationPropertyName|`adx_contact_pollsubmission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102500<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_webfilelog"></a> adx_contact_webfilelog

Many-To-One Relationship: [adx_webfilelog adx_contact_webfilelog](adx_webfilelog.md#BKMK_adx_contact_webfilelog)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfilelog`|
|ReferencingAttribute|`adx_contactid`|
|ReferencedEntityNavigationPropertyName|`adx_contact_webfilelog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102800<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_webpage"></a> adx_contact_webpage

Many-To-One Relationship: [adx_webpage adx_contact_webpage](adx_webpage.md#BKMK_adx_contact_webpage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_authorid`|
|ReferencedEntityNavigationPropertyName|`adx_contact_webpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: Authored Pages<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contact_webpagelog"></a> adx_contact_webpagelog

Many-To-One Relationship: [adx_webpagelog adx_contact_webpagelog](adx_webpagelog.md#BKMK_adx_contact_webpagelog)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpagelog`|
|ReferencingAttribute|`adx_contactid`|
|ReferencedEntityNavigationPropertyName|`adx_contact_webpagelog`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_subscribercontact_pagealert"></a> adx_subscribercontact_pagealert

Many-To-One Relationship: [adx_pagealert adx_subscribercontact_pagealert](adx_pagealert.md#BKMK_adx_subscribercontact_pagealert)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagealert`|
|ReferencingAttribute|`adx_subscriberid`|
|ReferencedEntityNavigationPropertyName|`adx_subscribercontact_pagealert`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102300<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8"></a> bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8

Many-To-One Relationship: [adx_bpf_c2857b638fa7473d8e2f112c232cebd8 bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8](adx_bpf_c2857b638fa7473d8e2f112c232cebd8.md#BKMK_bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_bpf_c2857b638fa7473d8e2f112c232cebd8`|
|ReferencingAttribute|`bpf_contactid`|
|ReferencedEntityNavigationPropertyName|`bpf_contact_adx_bpf_c2857b638fa7473d8e2f112c232cebd8`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: contact<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contact_adx_alertsubscriptions"></a> contact_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription contact_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_contact_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

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

### <a name="BKMK_contact_li_inmails"></a> contact_li_inmails

Many-To-One Relationship: [li_inmail contact_li_inmails](li_inmail.md#BKMK_contact_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_li_messages"></a> contact_li_messages

Many-To-One Relationship: [li_message contact_li_messages](li_message.md#BKMK_contact_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_li_pointdrivepresentationvieweds"></a> contact_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed contact_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_contact_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contact_msdyn_bookingalerts"></a> contact_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert contact_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_contact_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

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

### <a name="BKMK_contact_msdyn_ocoutboundmessages"></a> contact_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage contact_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_contact_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
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

### <a name="BKMK_contact_msdyn_ocvoicemails"></a> contact_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail contact_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_contact_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`contact_msdyn_ocvoicemails`|
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

### <a name="BKMK_msa_contact_incident"></a> msa_contact_incident

Many-To-One Relationship: [incident msa_contact_incident](incident.md#BKMK_msa_contact_incident)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`msa_partnercontactid`|
|ReferencedEntityNavigationPropertyName|`msa_contact_incident`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Service`<br />Label: Partner Cases<br />MenuId: null<br />Order: 100100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msa_contact_opportunity"></a> msa_contact_opportunity

Many-To-One Relationship: [opportunity msa_contact_opportunity](opportunity.md#BKMK_msa_contact_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`msa_partneroppid`|
|ReferencedEntityNavigationPropertyName|`msa_contact_opportunity`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Sales`<br />Label: Partner Opportunities<br />MenuId: null<br />Order: 100100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_dailycontactkpiitem_entityid"></a> msdyn_contact_dailycontactkpiitem_entityid

Many-To-One Relationship: [msdyn_dailycontactkpiitem msdyn_contact_dailycontactkpiitem_entityid](msdyn_dailycontactkpiitem.md#BKMK_msdyn_contact_dailycontactkpiitem_entityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailycontactkpiitem`|
|ReferencingAttribute|`msdyn_entityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_dailycontactkpiitem_entityid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_actual_ContactCustomer"></a> msdyn_contact_msdyn_actual_ContactCustomer

Many-To-One Relationship: [msdyn_actual msdyn_contact_msdyn_actual_ContactCustomer](msdyn_actual.md#BKMK_msdyn_contact_msdyn_actual_ContactCustomer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_contactcustomer`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_actual_ContactCustomer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_actual_ContactVendor"></a> msdyn_contact_msdyn_actual_ContactVendor

Many-To-One Relationship: [msdyn_actual msdyn_contact_msdyn_actual_ContactVendor](msdyn_actual.md#BKMK_msdyn_contact_msdyn_actual_ContactVendor)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_contactvendor`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_actual_ContactVendor`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_contactkpiitem_contactid"></a> msdyn_contact_msdyn_contactkpiitem_contactid

Many-To-One Relationship: [msdyn_contactkpiitem msdyn_contact_msdyn_contactkpiitem_contactid](msdyn_contactkpiitem.md#BKMK_msdyn_contact_msdyn_contactkpiitem_contactid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_contactkpiitem`|
|ReferencingAttribute|`msdyn_contactid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_contactkpiitem_contactid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_liveconversation_Customer"></a> msdyn_contact_msdyn_liveconversation_Customer

Many-To-One Relationship: [msdyn_liveconversation msdyn_contact_msdyn_liveconversation_Customer](msdyn_liveconversation.md#BKMK_msdyn_contact_msdyn_liveconversation_Customer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_liveconversation`|
|ReferencingAttribute|`msdyn_customer`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_liveconversation_Customer`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

### <a name="BKMK_msdyn_contact_msdyn_ocvoicemail_Customer"></a> msdyn_contact_msdyn_ocvoicemail_Customer

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_contact_msdyn_ocvoicemail_Customer](msdyn_ocvoicemail.md#BKMK_msdyn_contact_msdyn_ocvoicemail_Customer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`msdyn_customer`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_ocvoicemail_Customer`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_rma_RequestedByContact"></a> msdyn_contact_msdyn_rma_RequestedByContact

Many-To-One Relationship: [msdyn_rma msdyn_contact_msdyn_rma_RequestedByContact](msdyn_rma.md#BKMK_msdyn_contact_msdyn_rma_RequestedByContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`msdyn_requestedbycontact`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_rma_RequestedByContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Billing Account<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_rtv_VendorContact"></a> msdyn_contact_msdyn_rtv_VendorContact

Many-To-One Relationship: [msdyn_rtv msdyn_contact_msdyn_rtv_VendorContact](msdyn_rtv.md#BKMK_msdyn_contact_msdyn_rtv_VendorContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`msdyn_vendorcontact`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_rtv_VendorContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Vendor Contact<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contact_msdyn_salespremiumdemo_contact"></a> msdyn_contact_msdyn_salespremiumdemo_contact

Many-To-One Relationship: [msdyn_salespremiumdemo msdyn_contact_msdyn_salespremiumdemo_contact](msdyn_salespremiumdemo.md#BKMK_msdyn_contact_msdyn_salespremiumdemo_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salespremiumdemo`|
|ReferencingAttribute|`msdyn_contact`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_salespremiumdemo_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

### <a name="BKMK_msdyn_contact_msdyn_workorder_ReportedByContact"></a> msdyn_contact_msdyn_workorder_ReportedByContact

Many-To-One Relationship: [msdyn_workorder msdyn_contact_msdyn_workorder_ReportedByContact](msdyn_workorder.md#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_reportedbycontact`|
|ReferencedEntityNavigationPropertyName|`msdyn_contact_msdyn_workorder_ReportedByContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

### <a name="BKMK_msdyn_playbookinstance_contact"></a> msdyn_playbookinstance_contact

Many-To-One Relationship: [msdyn_playbookinstance msdyn_playbookinstance_contact](msdyn_playbookinstance.md#BKMK_msdyn_playbookinstance_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookinstance`|
|ReferencingAttribute|`regarding`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookinstance_contact`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

### <a name="BKMK_msdyncrm_contact_marketingformsubmission_matched"></a> msdyncrm_contact_marketingformsubmission_matched

Many-To-One Relationship: [msdyncrm_marketingformsubmission msdyncrm_contact_marketingformsubmission_matched](msdyncrm_marketingformsubmission.md#BKMK_msdyncrm_contact_marketingformsubmission_matched)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformsubmission`|
|ReferencingAttribute|`msdyncrm_matchedcontactid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contact_marketingformsubmission_matched`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contact_marketingformsubmission_original"></a> msdyncrm_contact_marketingformsubmission_original

Many-To-One Relationship: [msdyncrm_marketingformsubmission msdyncrm_contact_marketingformsubmission_original](msdyncrm_marketingformsubmission.md#BKMK_msdyncrm_contact_marketingformsubmission_original)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingformsubmission`|
|ReferencingAttribute|`msdyncrm_originalcontactid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contact_marketingformsubmission_original`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_customerjourneycustomchannelactivity_Contact"></a> msdyncrm_contact_msdyncrm_customerjourneycustomchannelactivity_Contact

Many-To-One Relationship: [msdyncrm_customerjourneycustomchannelactivity msdyncrm_contact_msdyncrm_customerjourneycustomchannelactivity_Contact](msdyncrm_customerjourneycustomchannelactivity.md#BKMK_msdyncrm_contact_msdyncrm_customerjourneycustomchannelactivity_Contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_customerjourneycustomchannelactivity`|
|ReferencingAttribute|`msdyncrm_contact`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contact_msdyncrm_customerjourneycustomchannelactivity_Contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact"></a> msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact](msdyncrm_defaultmarketingsetting.md#BKMK_msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`msdyncrm_defaulttestcontact`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contact_msdyncrm_defaultmarketingsetting_DefaultTestContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_geopin"></a> msdyncrm_contact_msdyncrm_geopin

Many-To-One Relationship: [msdyncrm_geopin msdyncrm_contact_msdyncrm_geopin](msdyncrm_geopin.md#BKMK_msdyncrm_contact_msdyncrm_geopin)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_geopin`|
|ReferencingAttribute|`msdyncrm_contactgeopinsid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contact_msdyncrm_geopin`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_linkedinformsubmission_contact"></a> msdyncrm_contact_msdyncrm_linkedinformsubmission_contact

Many-To-One Relationship: [msdyncrm_linkedinformsubmission msdyncrm_contact_msdyncrm_linkedinformsubmission_contact](msdyncrm_linkedinformsubmission.md#BKMK_msdyncrm_contact_msdyncrm_linkedinformsubmission_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_linkedinformsubmission`|
|ReferencingAttribute|`msdyncrm_contact`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contact_msdyncrm_linkedinformsubmission_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid"></a> msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid

Many-To-One Relationship: [msdyncrm_marketingemailtestsend msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid](msdyncrm_marketingemailtestsend.md#BKMK_msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingemailtestsend`|
|ReferencingAttribute|`msdyncrm_testcontactid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_contact_msdyncrm_marketingemailtestsend_testcontactid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_eventregistration_registeredby"></a> msevtmgt_contact_eventregistration_registeredby

Many-To-One Relationship: [msevtmgt_eventregistration msevtmgt_contact_eventregistration_registeredby](msevtmgt_eventregistration.md#BKMK_msevtmgt_contact_eventregistration_registeredby)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventregistration`|
|ReferencingAttribute|`msevtmgt_registeredby`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_eventregistration_registeredby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_attendeepass_contact"></a> msevtmgt_contact_msevtmgt_attendeepass_contact

Many-To-One Relationship: [msevtmgt_attendeepass msevtmgt_contact_msevtmgt_attendeepass_contact](msevtmgt_attendeepass.md#BKMK_msevtmgt_contact_msevtmgt_attendeepass_contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_attendeepass`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_attendeepass_contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_building_PrimaryContact"></a> msevtmgt_contact_msevtmgt_building_PrimaryContact

Many-To-One Relationship: [msevtmgt_building msevtmgt_contact_msevtmgt_building_PrimaryContact](msevtmgt_building.md#BKMK_msevtmgt_contact_msevtmgt_building_PrimaryContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_building`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_building_PrimaryContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_checkin_Contact"></a> msevtmgt_contact_msevtmgt_checkin_Contact

Many-To-One Relationship: [msevtmgt_checkin msevtmgt_contact_msevtmgt_checkin_Contact](msevtmgt_checkin.md#BKMK_msevtmgt_contact_msevtmgt_checkin_Contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_checkin_Contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_eventpurchase"></a> msevtmgt_contact_msevtmgt_eventpurchase

Many-To-One Relationship: [msevtmgt_eventpurchase msevtmgt_contact_msevtmgt_eventpurchase](msevtmgt_eventpurchase.md#BKMK_msevtmgt_contact_msevtmgt_eventpurchase)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchase`|
|ReferencingAttribute|`msevtmgt_purchasingcontactid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_eventpurchase`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_eventpurchaseattendee"></a> msevtmgt_contact_msevtmgt_eventpurchaseattendee

Many-To-One Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_contact_msevtmgt_eventpurchaseattendee](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_contact_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencingAttribute|`msevtmgt_attendeecontactid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_eventpurchaseattendee`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_eventregistration_Contact"></a> msevtmgt_contact_msevtmgt_eventregistration_Contact

Many-To-One Relationship: [msevtmgt_eventregistration msevtmgt_contact_msevtmgt_eventregistration_Contact](msevtmgt_eventregistration.md#BKMK_msevtmgt_contact_msevtmgt_eventregistration_Contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventregistration`|
|ReferencingAttribute|`msevtmgt_contactid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_eventregistration_Contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_eventteammember_Contact"></a> msevtmgt_contact_msevtmgt_eventteammember_Contact

Many-To-One Relationship: [msevtmgt_eventteammember msevtmgt_contact_msevtmgt_eventteammember_Contact](msevtmgt_eventteammember.md#BKMK_msevtmgt_contact_msevtmgt_eventteammember_Contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventteammember`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_eventteammember_Contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_hotel_PrimaryContact"></a> msevtmgt_contact_msevtmgt_hotel_PrimaryContact

Many-To-One Relationship: [msevtmgt_hotel msevtmgt_contact_msevtmgt_hotel_PrimaryContact](msevtmgt_hotel.md#BKMK_msevtmgt_contact_msevtmgt_hotel_PrimaryContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotel`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_hotel_PrimaryContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact"></a> msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact

Many-To-One Relationship: [msevtmgt_hotelroomallocation msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact](msevtmgt_hotelroomallocation.md#BKMK_msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomallocation`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_hotelroomallocation_PrimaryContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_room_PrimaryContact"></a> msevtmgt_contact_msevtmgt_room_PrimaryContact

Many-To-One Relationship: [msevtmgt_room msevtmgt_contact_msevtmgt_room_PrimaryContact](msevtmgt_room.md#BKMK_msevtmgt_contact_msevtmgt_room_PrimaryContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_room`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_room_PrimaryContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_sessionregistration_contactid"></a> msevtmgt_contact_msevtmgt_sessionregistration_contactid

Many-To-One Relationship: [msevtmgt_sessionregistration msevtmgt_contact_msevtmgt_sessionregistration_contactid](msevtmgt_sessionregistration.md#BKMK_msevtmgt_contact_msevtmgt_sessionregistration_contactid)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessionregistration`|
|ReferencingAttribute|`msevtmgt_contactid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_sessionregistration_contactid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_speaker_Contact"></a> msevtmgt_contact_msevtmgt_speaker_Contact

Many-To-One Relationship: [msevtmgt_speaker msevtmgt_contact_msevtmgt_speaker_Contact](msevtmgt_speaker.md#BKMK_msevtmgt_contact_msevtmgt_speaker_Contact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speaker`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_speaker_Contact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_venue_PrimaryContact"></a> msevtmgt_contact_msevtmgt_venue_PrimaryContact

Many-To-One Relationship: [msevtmgt_venue msevtmgt_contact_msevtmgt_venue_PrimaryContact](msevtmgt_venue.md#BKMK_msevtmgt_contact_msevtmgt_venue_PrimaryContact)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_venue`|
|ReferencingAttribute|`msevtmgt_primarycontact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_msevtmgt_venue_PrimaryContact`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_waitlistitem"></a> msevtmgt_contact_waitlistitem

Many-To-One Relationship: [msevtmgt_waitlistitem msevtmgt_contact_waitlistitem](msevtmgt_waitlistitem.md#BKMK_msevtmgt_contact_waitlistitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_waitlistitem`|
|ReferencingAttribute|`msevtmgt_contact`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_waitlistitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_contact_waitlistitem_addedby"></a> msevtmgt_contact_waitlistitem_addedby

Many-To-One Relationship: [msevtmgt_waitlistitem msevtmgt_contact_waitlistitem_addedby](msevtmgt_waitlistitem.md#BKMK_msevtmgt_contact_waitlistitem_addedby)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_waitlistitem`|
|ReferencingAttribute|`msevtmgt_addedby`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_contact_waitlistitem_addedby`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_contact_msgdpr_gdprconsentchangerecord"></a> msgdpr_contact_msgdpr_gdprconsentchangerecord

Many-To-One Relationship: [msgdpr_gdprconsentchangerecord msgdpr_contact_msgdpr_gdprconsentchangerecord](msgdpr_gdprconsentchangerecord.md#BKMK_msgdpr_contact_msgdpr_gdprconsentchangerecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msgdpr_gdprconsentchangerecord`|
|ReferencingAttribute|`msgdpr_contactid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_contact_msgdpr_gdprconsentchangerecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msgdpr_contact_msgdpr_gdprparent-one-to-many"></a> msgdpr_contact_msgdpr_gdprparent

Many-To-One Relationship: [contact msgdpr_contact_msgdpr_gdprparent](#BKMK_msgdpr_contact_msgdpr_gdprparent-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msgdpr_gdprparentid`|
|ReferencedEntityNavigationPropertyName|`msgdpr_contact_msgdpr_gdprparent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Marketing`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

- [adx_communityforumthread_contact](#BKMK_adx_communityforumthread_contact)
- [adx_ContactContentAccessLevel](#BKMK_adx_ContactContentAccessLevel)
- [adx_contactproduct](#BKMK_adx_contactproduct)
- [adx_forum_activityalert](#BKMK_adx_forum_activityalert)
- [adx_webrole_contact](#BKMK_adx_webrole_contact)
- [BulkOperation_Contacts](#BKMK_BulkOperation_Contacts)
- [CampaignActivity_Contacts](#BKMK_CampaignActivity_Contacts)
- [contactinvoices_association](#BKMK_contactinvoices_association)
- [contactleads_association](#BKMK_contactleads_association)
- [contactorders_association](#BKMK_contactorders_association)
- [contactquotes_association](#BKMK_contactquotes_association)
- [entitlementcontacts_association](#BKMK_entitlementcontacts_association)
- [listcontact_association](#BKMK_listcontact_association)
- [servicecontractcontacts_association](#BKMK_servicecontractcontacts_association)

### <a name="BKMK_adx_communityforumthread_contact"></a> adx_communityforumthread_contact

See [adx_communityforumthread adx_communityforumthread_contact Many-To-Many Relationship](adx_communityforumthread.md#BKMK_adx_communityforumthread_contact)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_communityforumthread_contact`|
|IsCustomizable|True|
|SchemaName|`adx_communityforumthread_contact`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`adx_communityforumthread_contact`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Subscribers<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_ContactContentAccessLevel"></a> adx_ContactContentAccessLevel

See [adx_contentaccesslevel adx_ContactContentAccessLevel Many-To-Many Relationship](adx_contentaccesslevel.md#BKMK_adx_ContactContentAccessLevel)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_contactcontentaccesslevel`|
|IsCustomizable|True|
|SchemaName|`adx_ContactContentAccessLevel`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`adx_ContactContentAccessLevel`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_contactproduct"></a> adx_contactproduct

See [product adx_contactproduct Many-To-Many Relationship](product.md#BKMK_adx_contactproduct)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_contactproduct`|
|IsCustomizable|True|
|SchemaName|`adx_contactproduct`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`adx_contactproduct`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_forum_activityalert"></a> adx_forum_activityalert

See [adx_communityforum adx_forum_activityalert Many-To-Many Relationship](adx_communityforum.md#BKMK_adx_forum_activityalert)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_forum_activityalert`|
|IsCustomizable|True|
|SchemaName|`adx_forum_activityalert`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`adx_forum_activityalert`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Activity Alert Recipients<br />MenuId: null<br />Order: 100100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webrole_contact"></a> adx_webrole_contact

See [adx_webrole adx_webrole_contact Many-To-Many Relationship](adx_webrole.md#BKMK_adx_webrole_contact)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_webrole_contact`|
|IsCustomizable|True|
|SchemaName|`adx_webrole_contact`|
|IntersectAttribute|`contactid`|
|NavigationPropertyName|`adx_webrole_contact`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100300<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

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

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.contact?displayProperty=fullName>
