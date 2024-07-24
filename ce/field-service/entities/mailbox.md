---
title: "Mailbox table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Mailbox table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Mailbox table/entity reference



> [!NOTE]
> The Microsoft Dynamics 365 Field Service Mailbox table extends the [Microsoft Dataverse Mailbox table](/power-apps/developer/data-platform/reference/entities/mailbox).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [LastTagCompletedOn](#BKMK_LastTagCompletedOn)
- [LastTagProcessedMaxItems](#BKMK_LastTagProcessedMaxItems)

### <a name="BKMK_LastTagCompletedOn"></a> LastTagCompletedOn

|Property|Value|
|---|---|
|Description|**Identifies the timestamp when tagging last completed. For internal use only.**|
|DisplayName|**Last Tag Completed On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`lasttagcompletedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_LastTagProcessedMaxItems"></a> LastTagProcessedMaxItems

|Property|Value|
|---|---|
|Description|**Indicates if the last tagging cycle processed the maximum number of items. For internal use only.**|
|DisplayName|**Last Tag Processed Max Items**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`lasttagprocessedmaxitems`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`mailbox_lasttagprocessedmaxitems`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_alertsubscription_mailbox_sendermailboxid](#BKMK_adx_alertsubscription_mailbox_sendermailboxid)
- [bulkoperation_mailbox_sendermailboxid](#BKMK_bulkoperation_mailbox_sendermailboxid)
- [campaignactivity_mailbox_sendermailboxid](#BKMK_campaignactivity_mailbox_sendermailboxid)
- [campaignresponse_mailbox_sendermailboxid](#BKMK_campaignresponse_mailbox_sendermailboxid)
- [incidentresolution_mailbox_sendermailboxid](#BKMK_incidentresolution_mailbox_sendermailboxid)
- [li_inmail_mailbox_sendermailboxid](#BKMK_li_inmail_mailbox_sendermailboxid)
- [li_message_mailbox_sendermailboxid](#BKMK_li_message_mailbox_sendermailboxid)
- [li_pointdrivepresentationviewed_mailbox_sendermailboxid](#BKMK_li_pointdrivepresentationviewed_mailbox_sendermailboxid)
- [msdyn_bookingalert_mailbox_sendermailboxid](#BKMK_msdyn_bookingalert_mailbox_sendermailboxid)
- [msdyn_copilottranscript_mailbox_sendermailboxid](#BKMK_msdyn_copilottranscript_mailbox_sendermailboxid)
- [msdyn_ocliveworkitem_mailbox_sendermailboxid](#BKMK_msdyn_ocliveworkitem_mailbox_sendermailboxid)
- [msdyn_ocoutboundmessage_mailbox_sendermailboxid](#BKMK_msdyn_ocoutboundmessage_mailbox_sendermailboxid)
- [msdyn_ocsession_mailbox_sendermailboxid](#BKMK_msdyn_ocsession_mailbox_sendermailboxid)
- [msdyn_ocvoicemail_mailbox_sendermailboxid](#BKMK_msdyn_ocvoicemail_mailbox_sendermailboxid)
- [msfp_alert_mailbox_sendermailboxid](#BKMK_msfp_alert_mailbox_sendermailboxid)
- [msfp_surveyinvite_mailbox_sendermailboxid](#BKMK_msfp_surveyinvite_mailbox_sendermailboxid)
- [msfp_surveyresponse_mailbox_sendermailboxid](#BKMK_msfp_surveyresponse_mailbox_sendermailboxid)
- [opportunityclose_mailbox_sendermailboxid](#BKMK_opportunityclose_mailbox_sendermailboxid)
- [orderclose_mailbox_sendermailboxid](#BKMK_orderclose_mailbox_sendermailboxid)
- [quoteclose_mailbox_sendermailboxid](#BKMK_quoteclose_mailbox_sendermailboxid)
- [serviceappointment_mailbox_sendermailboxid](#BKMK_serviceappointment_mailbox_sendermailboxid)

### <a name="BKMK_adx_alertsubscription_mailbox_sendermailboxid"></a> adx_alertsubscription_mailbox_sendermailboxid

Many-To-One Relationship: [adx_alertsubscription adx_alertsubscription_mailbox_sendermailboxid](adx_alertsubscription.md#BKMK_adx_alertsubscription_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`adx_alertsubscription_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bulkoperation_mailbox_sendermailboxid"></a> bulkoperation_mailbox_sendermailboxid

Many-To-One Relationship: [bulkoperation bulkoperation_mailbox_sendermailboxid](bulkoperation.md#BKMK_bulkoperation_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`bulkoperation_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignactivity_mailbox_sendermailboxid"></a> campaignactivity_mailbox_sendermailboxid

Many-To-One Relationship: [campaignactivity campaignactivity_mailbox_sendermailboxid](campaignactivity.md#BKMK_campaignactivity_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`campaignactivity_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_campaignresponse_mailbox_sendermailboxid"></a> campaignresponse_mailbox_sendermailboxid

Many-To-One Relationship: [campaignresponse campaignresponse_mailbox_sendermailboxid](campaignresponse.md#BKMK_campaignresponse_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`campaignresponse_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incidentresolution_mailbox_sendermailboxid"></a> incidentresolution_mailbox_sendermailboxid

Many-To-One Relationship: [incidentresolution incidentresolution_mailbox_sendermailboxid](incidentresolution.md#BKMK_incidentresolution_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`incidentresolution_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_inmail_mailbox_sendermailboxid"></a> li_inmail_mailbox_sendermailboxid

Many-To-One Relationship: [li_inmail li_inmail_mailbox_sendermailboxid](li_inmail.md#BKMK_li_inmail_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`li_inmail_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_message_mailbox_sendermailboxid"></a> li_message_mailbox_sendermailboxid

Many-To-One Relationship: [li_message li_message_mailbox_sendermailboxid](li_message.md#BKMK_li_message_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`li_message_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_mailbox_sendermailboxid"></a> li_pointdrivepresentationviewed_mailbox_sendermailboxid

Many-To-One Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_mailbox_sendermailboxid](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_mailbox_sendermailboxid"></a> msdyn_bookingalert_mailbox_sendermailboxid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_mailbox_sendermailboxid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilottranscript_mailbox_sendermailboxid"></a> msdyn_copilottranscript_mailbox_sendermailboxid

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_mailbox_sendermailboxid](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_mailbox_sendermailboxid"></a> msdyn_ocliveworkitem_mailbox_sendermailboxid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_mailbox_sendermailboxid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_mailbox_sendermailboxid"></a> msdyn_ocoutboundmessage_mailbox_sendermailboxid

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_mailbox_sendermailboxid](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_mailbox_sendermailboxid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_mailbox_sendermailboxid"></a> msdyn_ocsession_mailbox_sendermailboxid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_mailbox_sendermailboxid](msdyn_ocsession.md#BKMK_msdyn_ocsession_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicemail_mailbox_sendermailboxid"></a> msdyn_ocvoicemail_mailbox_sendermailboxid

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_mailbox_sendermailboxid](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicemail_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_alert_mailbox_sendermailboxid"></a> msfp_alert_mailbox_sendermailboxid

Many-To-One Relationship: [msfp_alert msfp_alert_mailbox_sendermailboxid](msfp_alert.md#BKMK_msfp_alert_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyinvite_mailbox_sendermailboxid"></a> msfp_surveyinvite_mailbox_sendermailboxid

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_mailbox_sendermailboxid](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyresponse_mailbox_sendermailboxid"></a> msfp_surveyresponse_mailbox_sendermailboxid

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_mailbox_sendermailboxid](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunityclose_mailbox_sendermailboxid"></a> opportunityclose_mailbox_sendermailboxid

Many-To-One Relationship: [opportunityclose opportunityclose_mailbox_sendermailboxid](opportunityclose.md#BKMK_opportunityclose_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`opportunityclose_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_orderclose_mailbox_sendermailboxid"></a> orderclose_mailbox_sendermailboxid

Many-To-One Relationship: [orderclose orderclose_mailbox_sendermailboxid](orderclose.md#BKMK_orderclose_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`orderclose_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quoteclose_mailbox_sendermailboxid"></a> quoteclose_mailbox_sendermailboxid

Many-To-One Relationship: [quoteclose quoteclose_mailbox_sendermailboxid](quoteclose.md#BKMK_quoteclose_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`quoteclose_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_serviceappointment_mailbox_sendermailboxid"></a> serviceappointment_mailbox_sendermailboxid

Many-To-One Relationship: [serviceappointment serviceappointment_mailbox_sendermailboxid](serviceappointment.md#BKMK_serviceappointment_mailbox_sendermailboxid)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`sendermailboxid`|
|ReferencedEntityNavigationPropertyName|`serviceappointment_mailbox_sendermailboxid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.mailbox?displayProperty=fullName>
