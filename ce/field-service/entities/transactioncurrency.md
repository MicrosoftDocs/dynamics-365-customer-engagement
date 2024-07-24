---
title: "Currency (TransactionCurrency) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Currency (TransactionCurrency) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Currency (TransactionCurrency) table/entity reference

Currency in which a financial transaction is carried out.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Currency (TransactionCurrency) table extends the [Microsoft Dataverse Currency (TransactionCurrency) table](/power-apps/developer/data-platform/reference/entities/transactioncurrency).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_alertsubscription_transactioncurrency_transactioncurrencyid](#BKMK_adx_alertsubscription_transactioncurrency_transactioncurrencyid)
- [bulkoperation_transactioncurrency_transactioncurrencyid](#BKMK_bulkoperation_transactioncurrency_transactioncurrencyid)
- [DynamicPropertyAssociation_TransactionCurrency](#BKMK_DynamicPropertyAssociation_TransactionCurrency)
- [DynamicPropertyOptionSetItem_TransactionCurrency](#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency)
- [incidentresolution_transactioncurrency_transactioncurrencyid](#BKMK_incidentresolution_transactioncurrency_transactioncurrencyid)
- [li_inmail_transactioncurrency_transactioncurrencyid](#BKMK_li_inmail_transactioncurrency_transactioncurrencyid)
- [li_message_transactioncurrency_transactioncurrencyid](#BKMK_li_message_transactioncurrency_transactioncurrencyid)
- [li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid](#BKMK_li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid)
- [msdyn_bookingalert_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid)
- [msdyn_copilottranscript_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_copilottranscript_transactioncurrency_transactioncurrencyid)
- [msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid)
- [msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid)
- [msdyn_ocsession_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocsession_transactioncurrency_transactioncurrencyid)
- [msdyn_ocvoicemail_transactioncurrency_transactioncurrencyid](#BKMK_msdyn_ocvoicemail_transactioncurrency_transactioncurrencyid)
- [msdyn_transactioncurrency_invoicedetail_Currency](#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)
- [msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn)
- [msevtmgt_TransactionCurrencyId_msevtmgt_Event](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Event)
- [msevtmgt_TransactionCurrencyId_msevtmgt_Speaker](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Speaker)
- [msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle)
- [msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship)
- [msevtmgt_TransactionCurrencyId_msevtmgt_Venue](#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Venue)
- [msfp_alert_transactioncurrency_transactioncurrencyid](#BKMK_msfp_alert_transactioncurrency_transactioncurrencyid)
- [msfp_surveyinvite_transactioncurrency_transactioncurrencyid](#BKMK_msfp_surveyinvite_transactioncurrency_transactioncurrencyid)
- [msfp_surveyresponse_transactioncurrency_transactioncurrencyid](#BKMK_msfp_surveyresponse_transactioncurrency_transactioncurrencyid)
- [new_TransactionCurrency_msevtmgt_attendeepass](#BKMK_new_TransactionCurrency_msevtmgt_attendeepass)
- [orderclose_transactioncurrency_transactioncurrencyid](#BKMK_orderclose_transactioncurrency_transactioncurrencyid)
- [quoteclose_transactioncurrency_transactioncurrencyid](#BKMK_quoteclose_transactioncurrency_transactioncurrencyid)
- [TransactionCurrency_bookableresource](#BKMK_TransactionCurrency_bookableresource)
- [TransactionCurrency_bookableresourcebooking](#BKMK_TransactionCurrency_bookableresourcebooking)
- [TransactionCurrency_bookableresourcebookingheader](#BKMK_TransactionCurrency_bookableresourcebookingheader)
- [TransactionCurrency_bookableresourcecategory](#BKMK_TransactionCurrency_bookableresourcecategory)
- [TransactionCurrency_bookableresourcecategoryassn](#BKMK_TransactionCurrency_bookableresourcecategoryassn)
- [TransactionCurrency_bookableresourcecharacteristic](#BKMK_TransactionCurrency_bookableresourcecharacteristic)
- [TransactionCurrency_bookableresourcegroup](#BKMK_TransactionCurrency_bookableresourcegroup)
- [TransactionCurrency_bookingstatus](#BKMK_TransactionCurrency_bookingstatus)
- [transactioncurrency_campaign](#BKMK_transactioncurrency_campaign)
- [transactioncurrency_campaignactivity](#BKMK_transactioncurrency_campaignactivity)
- [TransactionCurrency_CampaignResponse](#BKMK_TransactionCurrency_CampaignResponse)
- [TransactionCurrency_characteristic](#BKMK_TransactionCurrency_characteristic)
- [transactioncurrency_competitor](#BKMK_transactioncurrency_competitor)
- [transactioncurrency_contract](#BKMK_transactioncurrency_contract)
- [transactioncurrency_contractdetail](#BKMK_transactioncurrency_contractdetail)
- [transactioncurrency_discount](#BKMK_transactioncurrency_discount)
- [transactioncurrency_discounttype](#BKMK_transactioncurrency_discounttype)
- [TransactionCurrency_Dynamicpropertyinsatance](#BKMK_TransactionCurrency_Dynamicpropertyinsatance)
- [TransactionCurrency_Entitlement](#BKMK_TransactionCurrency_Entitlement)
- [TransactionCurrency_entitlementchannel](#BKMK_TransactionCurrency_entitlementchannel)
- [TransactionCurrency_entitlementtemplate](#BKMK_TransactionCurrency_entitlementtemplate)
- [TransactionCurrency_entitlementtemplatechannel](#BKMK_TransactionCurrency_entitlementtemplatechannel)
- [TransactionCurrency_Equipment](#BKMK_TransactionCurrency_Equipment)
- [TransactionCurrency_Incident](#BKMK_TransactionCurrency_Incident)
- [transactioncurrency_invoice](#BKMK_transactioncurrency_invoice)
- [transactioncurrency_invoicedetail](#BKMK_transactioncurrency_invoicedetail)
- [transactioncurrency_knowledgearticleincident](#BKMK_transactioncurrency_knowledgearticleincident)
- [transactioncurrency_lead](#BKMK_transactioncurrency_lead)
- [TransactionCurrency_LeadAddress](#BKMK_TransactionCurrency_LeadAddress)
- [transactioncurrency_leadtoopportunitysalesprocess](#BKMK_transactioncurrency_leadtoopportunitysalesprocess)
- [transactioncurrency_list](#BKMK_transactioncurrency_list)
- [TransactionCurrency_msdyn_actual](#BKMK_TransactionCurrency_msdyn_actual)
- [TransactionCurrency_msdyn_agreementbookingproduct](#BKMK_TransactionCurrency_msdyn_agreementbookingproduct)
- [TransactionCurrency_msdyn_agreementbookingservice](#BKMK_TransactionCurrency_msdyn_agreementbookingservice)
- [TransactionCurrency_msdyn_agreementinvoiceproduct](#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct)
- [TransactionCurrency_msdyn_bookingjournal](#BKMK_TransactionCurrency_msdyn_bookingjournal)
- [TransactionCurrency_msdyn_fieldservicepricelistitem](#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem)
- [TransactionCurrency_msdyn_forecastinstance](#BKMK_TransactionCurrency_msdyn_forecastinstance)
- [TransactionCurrency_msdyn_nottoexceed](#BKMK_TransactionCurrency_msdyn_nottoexceed)
- [TransactionCurrency_msdyn_orderinvoicingproduct](#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct)
- [TransactionCurrency_msdyn_payment](#BKMK_TransactionCurrency_msdyn_payment)
- [TransactionCurrency_msdyn_paymentdetail](#BKMK_TransactionCurrency_msdyn_paymentdetail)
- [TransactionCurrency_msdyn_problematicasset](#BKMK_TransactionCurrency_msdyn_problematicasset)
- [TransactionCurrency_msdyn_purchaseorder](#BKMK_TransactionCurrency_msdyn_purchaseorder)
- [TransactionCurrency_msdyn_purchaseorderbill](#BKMK_TransactionCurrency_msdyn_purchaseorderbill)
- [TransactionCurrency_msdyn_purchaseorderproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderproduct)
- [TransactionCurrency_msdyn_purchaseorderreceiptproduct](#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct)
- [TransactionCurrency_msdyn_quotebookingproduct](#BKMK_TransactionCurrency_msdyn_quotebookingproduct)
- [TransactionCurrency_msdyn_quotebookingservice](#BKMK_TransactionCurrency_msdyn_quotebookingservice)
- [TransactionCurrency_msdyn_quotebookingsetup](#BKMK_TransactionCurrency_msdyn_quotebookingsetup)
- [TransactionCurrency_msdyn_quoteinvoicingproduct](#BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct)
- [TransactionCurrency_msdyn_quoteinvoicingsetup](#BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup)
- [TransactionCurrency_msdyn_rma](#BKMK_TransactionCurrency_msdyn_rma)
- [TransactionCurrency_msdyn_rmaproduct](#BKMK_TransactionCurrency_msdyn_rmaproduct)
- [TransactionCurrency_msdyn_rtv](#BKMK_TransactionCurrency_msdyn_rtv)
- [TransactionCurrency_msdyn_rtvproduct](#BKMK_TransactionCurrency_msdyn_rtvproduct)
- [TransactionCurrency_msdyn_salessuggestion](#BKMK_TransactionCurrency_msdyn_salessuggestion)
- [TransactionCurrency_msdyn_workorder](#BKMK_TransactionCurrency_msdyn_workorder)
- [TransactionCurrency_msdyn_workordernte](#BKMK_TransactionCurrency_msdyn_workordernte)
- [TransactionCurrency_msdyn_workorderproduct](#BKMK_TransactionCurrency_msdyn_workorderproduct)
- [TransactionCurrency_msdyn_workorderservice](#BKMK_TransactionCurrency_msdyn_workorderservice)
- [TransactionCurrency_msevtmgt_AttendeePass](#BKMK_TransactionCurrency_msevtmgt_AttendeePass)
- [TransactionCurrency_msevtmgt_Building](#BKMK_TransactionCurrency_msevtmgt_Building)
- [TransactionCurrency_msevtmgt_Event](#BKMK_TransactionCurrency_msevtmgt_Event)
- [TransactionCurrency_msevtmgt_HotelRoomAllocation](#BKMK_TransactionCurrency_msevtmgt_HotelRoomAllocation)
- [TransactionCurrency_msevtmgt_pass](#BKMK_TransactionCurrency_msevtmgt_pass)
- [TransactionCurrency_msevtmgt_Speaker](#BKMK_TransactionCurrency_msevtmgt_Speaker)
- [TransactionCurrency_msevtmgt_speakerengagement](#BKMK_TransactionCurrency_msevtmgt_speakerengagement)
- [TransactionCurrency_msevtmgt_SponsorableArticle](#BKMK_TransactionCurrency_msevtmgt_SponsorableArticle)
- [TransactionCurrency_msevtmgt_Sponsorship](#BKMK_TransactionCurrency_msevtmgt_Sponsorship)
- [TransactionCurrency_msevtmgt_Venue](#BKMK_TransactionCurrency_msevtmgt_Venue)
- [transactioncurrency_opportunity](#BKMK_transactioncurrency_opportunity)
- [transactioncurrency_opportunityclose](#BKMK_transactioncurrency_opportunityclose)
- [transactioncurrency_opportunityproduct](#BKMK_transactioncurrency_opportunityproduct)
- [transactioncurrency_opportunitysalesprocess](#BKMK_transactioncurrency_opportunitysalesprocess)
- [transactioncurrency_phonetocaseprocess](#BKMK_transactioncurrency_phonetocaseprocess)
- [transactioncurrency_pricelevel](#BKMK_transactioncurrency_pricelevel)
- [transactioncurrency_product](#BKMK_transactioncurrency_product)
- [transactioncurrency_ProductAssociation](#BKMK_transactioncurrency_ProductAssociation)
- [transactioncurrency_productpricelevel](#BKMK_transactioncurrency_productpricelevel)
- [transactioncurrency_ProductSubstitute](#BKMK_transactioncurrency_ProductSubstitute)
- [transactioncurrency_quote](#BKMK_transactioncurrency_quote)
- [transactioncurrency_quotedetail](#BKMK_transactioncurrency_quotedetail)
- [TransactionCurrency_ratingmodel](#BKMK_TransactionCurrency_ratingmodel)
- [TransactionCurrency_ratingvalue](#BKMK_TransactionCurrency_ratingvalue)
- [TransactionCurrency_SalesLiterature](#BKMK_TransactionCurrency_SalesLiterature)
- [transactioncurrency_salesorder](#BKMK_transactioncurrency_salesorder)
- [transactioncurrency_salesorderdetail](#BKMK_transactioncurrency_salesorderdetail)
- [TransactionCurrency_ServiceAppointment](#BKMK_TransactionCurrency_ServiceAppointment)

### <a name="BKMK_adx_alertsubscription_transactioncurrency_transactioncurrencyid"></a> adx_alertsubscription_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [adx_alertsubscription adx_alertsubscription_transactioncurrency_transactioncurrencyid](adx_alertsubscription.md#BKMK_adx_alertsubscription_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`adx_alertsubscription_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_bulkoperation_transactioncurrency_transactioncurrencyid"></a> bulkoperation_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [bulkoperation bulkoperation_transactioncurrency_transactioncurrencyid](bulkoperation.md#BKMK_bulkoperation_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`bulkoperation_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_DynamicPropertyAssociation_TransactionCurrency"></a> DynamicPropertyAssociation_TransactionCurrency

Many-To-One Relationship: [dynamicpropertyassociation DynamicPropertyAssociation_TransactionCurrency](dynamicpropertyassociation.md#BKMK_DynamicPropertyAssociation_TransactionCurrency)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyassociation`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`DynamicPropertyAssociation_TransactionCurrency`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_DynamicPropertyOptionSetItem_TransactionCurrency"></a> DynamicPropertyOptionSetItem_TransactionCurrency

Many-To-One Relationship: [dynamicpropertyoptionsetitem DynamicPropertyOptionSetItem_TransactionCurrency](dynamicpropertyoptionsetitem.md#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyoptionsetitem`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`DynamicPropertyOptionSetItem_TransactionCurrency`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incidentresolution_transactioncurrency_transactioncurrencyid"></a> incidentresolution_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [incidentresolution incidentresolution_transactioncurrency_transactioncurrencyid](incidentresolution.md#BKMK_incidentresolution_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`incidentresolution_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_inmail_transactioncurrency_transactioncurrencyid"></a> li_inmail_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [li_inmail li_inmail_transactioncurrency_transactioncurrencyid](li_inmail.md#BKMK_li_inmail_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`li_inmail_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_message_transactioncurrency_transactioncurrencyid"></a> li_message_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [li_message li_message_transactioncurrency_transactioncurrencyid](li_message.md#BKMK_li_message_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`li_message_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid"></a> li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [li_pointdrivepresentationviewed li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid](li_pointdrivepresentationviewed.md#BKMK_li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`li_pointdrivepresentationviewed_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid"></a> msdyn_bookingalert_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msdyn_bookingalert msdyn_bookingalert_transactioncurrency_transactioncurrencyid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_bookingalert_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilottranscript_transactioncurrency_transactioncurrencyid"></a> msdyn_copilottranscript_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_transactioncurrency_transactioncurrencyid](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid"></a> msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid"></a> msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid](msdyn_ocoutboundmessage.md#BKMK_msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocoutboundmessage_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocsession_transactioncurrency_transactioncurrencyid"></a> msdyn_ocsession_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_transactioncurrency_transactioncurrencyid](msdyn_ocsession.md#BKMK_msdyn_ocsession_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocvoicemail_transactioncurrency_transactioncurrencyid"></a> msdyn_ocvoicemail_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_ocvoicemail_transactioncurrency_transactioncurrencyid](msdyn_ocvoicemail.md#BKMK_msdyn_ocvoicemail_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocvoicemail_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_transactioncurrency_invoicedetail_Currency"></a> msdyn_transactioncurrency_invoicedetail_Currency

Many-To-One Relationship: [invoicedetail msdyn_transactioncurrency_invoicedetail_Currency](invoicedetail.md#BKMK_msdyn_transactioncurrency_invoicedetail_Currency)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`msdyn_currency`|
|ReferencedEntityNavigationPropertyName|`msdyn_transactioncurrency_invoicedetail_Currency`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn"></a> msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn

Many-To-One Relationship: [msevtmgt_checkin msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn](msevtmgt_checkin.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId_msevtmgt_CheckIn`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Event"></a> msevtmgt_TransactionCurrencyId_msevtmgt_Event

Many-To-One Relationship: [msevtmgt_event msevtmgt_TransactionCurrencyId_msevtmgt_Event](msevtmgt_event.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId_msevtmgt_Event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Speaker"></a> msevtmgt_TransactionCurrencyId_msevtmgt_Speaker

Many-To-One Relationship: [msevtmgt_speaker msevtmgt_TransactionCurrencyId_msevtmgt_Speaker](msevtmgt_speaker.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Speaker)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speaker`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId_msevtmgt_Speaker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle"></a> msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle

Many-To-One Relationship: [msevtmgt_sponsorablearticle msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle](msevtmgt_sponsorablearticle.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorablearticle`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId_msevtmgt_SponsorableArticle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship"></a> msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship

Many-To-One Relationship: [msevtmgt_sponsorship msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship](msevtmgt_sponsorship.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorship`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId_msevtmgt_Sponsorship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Venue"></a> msevtmgt_TransactionCurrencyId_msevtmgt_Venue

Many-To-One Relationship: [msevtmgt_venue msevtmgt_TransactionCurrencyId_msevtmgt_Venue](msevtmgt_venue.md#BKMK_msevtmgt_TransactionCurrencyId_msevtmgt_Venue)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_venue`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_TransactionCurrencyId_msevtmgt_Venue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_alert_transactioncurrency_transactioncurrencyid"></a> msfp_alert_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msfp_alert msfp_alert_transactioncurrency_transactioncurrencyid](msfp_alert.md#BKMK_msfp_alert_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyinvite_transactioncurrency_transactioncurrencyid"></a> msfp_surveyinvite_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_transactioncurrency_transactioncurrencyid](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msfp_surveyresponse_transactioncurrency_transactioncurrencyid"></a> msfp_surveyresponse_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_transactioncurrency_transactioncurrencyid](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_new_TransactionCurrency_msevtmgt_attendeepass"></a> new_TransactionCurrency_msevtmgt_attendeepass

Many-To-One Relationship: [msevtmgt_attendeepass new_TransactionCurrency_msevtmgt_attendeepass](msevtmgt_attendeepass.md#BKMK_new_TransactionCurrency_msevtmgt_attendeepass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_attendeepass`|
|ReferencingAttribute|`msevtmgt_transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_attendeepass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_orderclose_transactioncurrency_transactioncurrencyid"></a> orderclose_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [orderclose orderclose_transactioncurrency_transactioncurrencyid](orderclose.md#BKMK_orderclose_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`orderclose_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_quoteclose_transactioncurrency_transactioncurrencyid"></a> quoteclose_transactioncurrency_transactioncurrencyid

Many-To-One Relationship: [quoteclose quoteclose_transactioncurrency_transactioncurrencyid](quoteclose.md#BKMK_quoteclose_transactioncurrency_transactioncurrencyid)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`quoteclose_transactioncurrency_transactioncurrencyid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_bookableresource"></a> TransactionCurrency_bookableresource

Many-To-One Relationship: [bookableresource TransactionCurrency_bookableresource](bookableresource.md#BKMK_TransactionCurrency_bookableresource)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_bookableresource`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_bookableresourcebooking"></a> TransactionCurrency_bookableresourcebooking

Many-To-One Relationship: [bookableresourcebooking TransactionCurrency_bookableresourcebooking](bookableresourcebooking.md#BKMK_TransactionCurrency_bookableresourcebooking)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_bookableresourcebooking`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_bookableresourcebookingheader"></a> TransactionCurrency_bookableresourcebookingheader

Many-To-One Relationship: [bookableresourcebookingheader TransactionCurrency_bookableresourcebookingheader](bookableresourcebookingheader.md#BKMK_TransactionCurrency_bookableresourcebookingheader)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebookingheader`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_bookableresourcebookingheader`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_bookableresourcecategory"></a> TransactionCurrency_bookableresourcecategory

Many-To-One Relationship: [bookableresourcecategory TransactionCurrency_bookableresourcecategory](bookableresourcecategory.md#BKMK_TransactionCurrency_bookableresourcecategory)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategory`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_bookableresourcecategory`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_bookableresourcecategoryassn"></a> TransactionCurrency_bookableresourcecategoryassn

Many-To-One Relationship: [bookableresourcecategoryassn TransactionCurrency_bookableresourcecategoryassn](bookableresourcecategoryassn.md#BKMK_TransactionCurrency_bookableresourcecategoryassn)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecategoryassn`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_bookableresourcecategoryassn`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_bookableresourcecharacteristic"></a> TransactionCurrency_bookableresourcecharacteristic

Many-To-One Relationship: [bookableresourcecharacteristic TransactionCurrency_bookableresourcecharacteristic](bookableresourcecharacteristic.md#BKMK_TransactionCurrency_bookableresourcecharacteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcecharacteristic`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_bookableresourcecharacteristic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_bookableresourcegroup"></a> TransactionCurrency_bookableresourcegroup

Many-To-One Relationship: [bookableresourcegroup TransactionCurrency_bookableresourcegroup](bookableresourcegroup.md#BKMK_TransactionCurrency_bookableresourcegroup)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcegroup`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_bookableresourcegroup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_bookingstatus"></a> TransactionCurrency_bookingstatus

Many-To-One Relationship: [bookingstatus TransactionCurrency_bookingstatus](bookingstatus.md#BKMK_TransactionCurrency_bookingstatus)

|Property|Value|
|---|---|
|ReferencingEntity|`bookingstatus`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_bookingstatus`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_campaign"></a> transactioncurrency_campaign

Many-To-One Relationship: [campaign transactioncurrency_campaign](campaign.md#BKMK_transactioncurrency_campaign)

|Property|Value|
|---|---|
|ReferencingEntity|`campaign`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_campaign`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_campaignactivity"></a> transactioncurrency_campaignactivity

Many-To-One Relationship: [campaignactivity transactioncurrency_campaignactivity](campaignactivity.md#BKMK_transactioncurrency_campaignactivity)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignactivity`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_campaignactivity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_CampaignResponse"></a> TransactionCurrency_CampaignResponse

Many-To-One Relationship: [campaignresponse TransactionCurrency_CampaignResponse](campaignresponse.md#BKMK_TransactionCurrency_CampaignResponse)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_CampaignResponse`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_characteristic"></a> TransactionCurrency_characteristic

Many-To-One Relationship: [characteristic TransactionCurrency_characteristic](characteristic.md#BKMK_TransactionCurrency_characteristic)

|Property|Value|
|---|---|
|ReferencingEntity|`characteristic`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_characteristic`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_competitor"></a> transactioncurrency_competitor

Many-To-One Relationship: [competitor transactioncurrency_competitor](competitor.md#BKMK_transactioncurrency_competitor)

|Property|Value|
|---|---|
|ReferencingEntity|`competitor`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_competitor`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_contract"></a> transactioncurrency_contract

Many-To-One Relationship: [contract transactioncurrency_contract](contract.md#BKMK_transactioncurrency_contract)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_contract`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_contractdetail"></a> transactioncurrency_contractdetail

Many-To-One Relationship: [contractdetail transactioncurrency_contractdetail](contractdetail.md#BKMK_transactioncurrency_contractdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`contractdetail`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_contractdetail`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_discount"></a> transactioncurrency_discount

Many-To-One Relationship: [discount transactioncurrency_discount](discount.md#BKMK_transactioncurrency_discount)

|Property|Value|
|---|---|
|ReferencingEntity|`discount`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_discount`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_discounttype"></a> transactioncurrency_discounttype

Many-To-One Relationship: [discounttype transactioncurrency_discounttype](discounttype.md#BKMK_transactioncurrency_discounttype)

|Property|Value|
|---|---|
|ReferencingEntity|`discounttype`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_discounttype`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_Dynamicpropertyinsatance"></a> TransactionCurrency_Dynamicpropertyinsatance

Many-To-One Relationship: [dynamicpropertyinstance TransactionCurrency_Dynamicpropertyinsatance](dynamicpropertyinstance.md#BKMK_TransactionCurrency_Dynamicpropertyinsatance)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicpropertyinstance`|
|ReferencingAttribute|`dynamicpropertyinstanceid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_Dynamicpropertyinsatance`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_Entitlement"></a> TransactionCurrency_Entitlement

Many-To-One Relationship: [entitlement TransactionCurrency_Entitlement](entitlement.md#BKMK_TransactionCurrency_Entitlement)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_Entitlement`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_entitlementchannel"></a> TransactionCurrency_entitlementchannel

Many-To-One Relationship: [entitlementchannel TransactionCurrency_entitlementchannel](entitlementchannel.md#BKMK_TransactionCurrency_entitlementchannel)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementchannel`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_entitlementchannel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_entitlementtemplate"></a> TransactionCurrency_entitlementtemplate

Many-To-One Relationship: [entitlementtemplate TransactionCurrency_entitlementtemplate](entitlementtemplate.md#BKMK_TransactionCurrency_entitlementtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementtemplate`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_entitlementtemplate`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_entitlementtemplatechannel"></a> TransactionCurrency_entitlementtemplatechannel

Many-To-One Relationship: [entitlementtemplatechannel TransactionCurrency_entitlementtemplatechannel](entitlementtemplatechannel.md#BKMK_TransactionCurrency_entitlementtemplatechannel)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlementtemplatechannel`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_entitlementtemplatechannel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_Equipment"></a> TransactionCurrency_Equipment

Many-To-One Relationship: [equipment TransactionCurrency_Equipment](equipment.md#BKMK_TransactionCurrency_Equipment)

|Property|Value|
|---|---|
|ReferencingEntity|`equipment`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_Equipment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_Incident"></a> TransactionCurrency_Incident

Many-To-One Relationship: [incident TransactionCurrency_Incident](incident.md#BKMK_TransactionCurrency_Incident)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_Incident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_invoice"></a> transactioncurrency_invoice

Many-To-One Relationship: [invoice transactioncurrency_invoice](invoice.md#BKMK_transactioncurrency_invoice)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_invoice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_invoicedetail"></a> transactioncurrency_invoicedetail

Many-To-One Relationship: [invoicedetail transactioncurrency_invoicedetail](invoicedetail.md#BKMK_transactioncurrency_invoicedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_invoicedetail`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_knowledgearticleincident"></a> transactioncurrency_knowledgearticleincident

Many-To-One Relationship: [knowledgearticleincident transactioncurrency_knowledgearticleincident](knowledgearticleincident.md#BKMK_transactioncurrency_knowledgearticleincident)

|Property|Value|
|---|---|
|ReferencingEntity|`knowledgearticleincident`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_knowledgearticleincident`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_lead"></a> transactioncurrency_lead

Many-To-One Relationship: [lead transactioncurrency_lead](lead.md#BKMK_transactioncurrency_lead)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_lead`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_LeadAddress"></a> TransactionCurrency_LeadAddress

Many-To-One Relationship: [leadaddress TransactionCurrency_LeadAddress](leadaddress.md#BKMK_TransactionCurrency_LeadAddress)

|Property|Value|
|---|---|
|ReferencingEntity|`leadaddress`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_LeadAddress`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_leadtoopportunitysalesprocess"></a> transactioncurrency_leadtoopportunitysalesprocess

Many-To-One Relationship: [leadtoopportunitysalesprocess transactioncurrency_leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md#BKMK_transactioncurrency_leadtoopportunitysalesprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`leadtoopportunitysalesprocess`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_leadtoopportunitysalesprocess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_list"></a> transactioncurrency_list

Many-To-One Relationship: [list transactioncurrency_list](list.md#BKMK_transactioncurrency_list)

|Property|Value|
|---|---|
|ReferencingEntity|`list`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_list`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_actual"></a> TransactionCurrency_msdyn_actual

Many-To-One Relationship: [msdyn_actual TransactionCurrency_msdyn_actual](msdyn_actual.md#BKMK_TransactionCurrency_msdyn_actual)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_actual`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingproduct"></a> TransactionCurrency_msdyn_agreementbookingproduct

Many-To-One Relationship: [msdyn_agreementbookingproduct TransactionCurrency_msdyn_agreementbookingproduct](msdyn_agreementbookingproduct.md#BKMK_TransactionCurrency_msdyn_agreementbookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_agreementbookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingservice"></a> TransactionCurrency_msdyn_agreementbookingservice

Many-To-One Relationship: [msdyn_agreementbookingservice TransactionCurrency_msdyn_agreementbookingservice](msdyn_agreementbookingservice.md#BKMK_TransactionCurrency_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_agreementbookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct"></a> TransactionCurrency_msdyn_agreementinvoiceproduct

Many-To-One Relationship: [msdyn_agreementinvoiceproduct TransactionCurrency_msdyn_agreementinvoiceproduct](msdyn_agreementinvoiceproduct.md#BKMK_TransactionCurrency_msdyn_agreementinvoiceproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_agreementinvoiceproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_bookingjournal"></a> TransactionCurrency_msdyn_bookingjournal

Many-To-One Relationship: [msdyn_bookingjournal TransactionCurrency_msdyn_bookingjournal](msdyn_bookingjournal.md#BKMK_TransactionCurrency_msdyn_bookingjournal)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingjournal`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_bookingjournal`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem"></a> TransactionCurrency_msdyn_fieldservicepricelistitem

Many-To-One Relationship: [msdyn_fieldservicepricelistitem TransactionCurrency_msdyn_fieldservicepricelistitem](msdyn_fieldservicepricelistitem.md#BKMK_TransactionCurrency_msdyn_fieldservicepricelistitem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fieldservicepricelistitem`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_fieldservicepricelistitem`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_forecastinstance"></a> TransactionCurrency_msdyn_forecastinstance

Many-To-One Relationship: [msdyn_forecastinstance TransactionCurrency_msdyn_forecastinstance](msdyn_forecastinstance.md#BKMK_TransactionCurrency_msdyn_forecastinstance)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinstance`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_forecastinstance`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_nottoexceed"></a> TransactionCurrency_msdyn_nottoexceed

Many-To-One Relationship: [msdyn_nottoexceed TransactionCurrency_msdyn_nottoexceed](msdyn_nottoexceed.md#BKMK_TransactionCurrency_msdyn_nottoexceed)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_nottoexceed`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_nottoexceed`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_orderinvoicingproduct"></a> TransactionCurrency_msdyn_orderinvoicingproduct

Many-To-One Relationship: [msdyn_orderinvoicingproduct TransactionCurrency_msdyn_orderinvoicingproduct](msdyn_orderinvoicingproduct.md#BKMK_TransactionCurrency_msdyn_orderinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orderinvoicingproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_orderinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_payment"></a> TransactionCurrency_msdyn_payment

Many-To-One Relationship: [msdyn_payment TransactionCurrency_msdyn_payment](msdyn_payment.md#BKMK_TransactionCurrency_msdyn_payment)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_payment`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_payment`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_paymentdetail"></a> TransactionCurrency_msdyn_paymentdetail

Many-To-One Relationship: [msdyn_paymentdetail TransactionCurrency_msdyn_paymentdetail](msdyn_paymentdetail.md#BKMK_TransactionCurrency_msdyn_paymentdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_paymentdetail`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_paymentdetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_problematicasset"></a> TransactionCurrency_msdyn_problematicasset

Many-To-One Relationship: [msdyn_problematicasset TransactionCurrency_msdyn_problematicasset](msdyn_problematicasset.md#BKMK_TransactionCurrency_msdyn_problematicasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicasset`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_problematicasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorder"></a> TransactionCurrency_msdyn_purchaseorder

Many-To-One Relationship: [msdyn_purchaseorder TransactionCurrency_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_TransactionCurrency_msdyn_purchaseorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_purchaseorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderbill"></a> TransactionCurrency_msdyn_purchaseorderbill

Many-To-One Relationship: [msdyn_purchaseorderbill TransactionCurrency_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_TransactionCurrency_msdyn_purchaseorderbill)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderbill`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_purchaseorderbill`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderproduct"></a> TransactionCurrency_msdyn_purchaseorderproduct

Many-To-One Relationship: [msdyn_purchaseorderproduct TransactionCurrency_msdyn_purchaseorderproduct](msdyn_purchaseorderproduct.md#BKMK_TransactionCurrency_msdyn_purchaseorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_purchaseorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct"></a> TransactionCurrency_msdyn_purchaseorderreceiptproduct

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct TransactionCurrency_msdyn_purchaseorderreceiptproduct](msdyn_purchaseorderreceiptproduct.md#BKMK_TransactionCurrency_msdyn_purchaseorderreceiptproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_purchaseorderreceiptproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingproduct"></a> TransactionCurrency_msdyn_quotebookingproduct

Many-To-One Relationship: [msdyn_quotebookingproduct TransactionCurrency_msdyn_quotebookingproduct](msdyn_quotebookingproduct.md#BKMK_TransactionCurrency_msdyn_quotebookingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quotebookingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingservice"></a> TransactionCurrency_msdyn_quotebookingservice

Many-To-One Relationship: [msdyn_quotebookingservice TransactionCurrency_msdyn_quotebookingservice](msdyn_quotebookingservice.md#BKMK_TransactionCurrency_msdyn_quotebookingservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quotebookingservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingsetup"></a> TransactionCurrency_msdyn_quotebookingsetup

Many-To-One Relationship: [msdyn_quotebookingsetup TransactionCurrency_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_TransactionCurrency_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingsetup`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quotebookingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct"></a> TransactionCurrency_msdyn_quoteinvoicingproduct

Many-To-One Relationship: [msdyn_quoteinvoicingproduct TransactionCurrency_msdyn_quoteinvoicingproduct](msdyn_quoteinvoicingproduct.md#BKMK_TransactionCurrency_msdyn_quoteinvoicingproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quoteinvoicingproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup"></a> TransactionCurrency_msdyn_quoteinvoicingsetup

Many-To-One Relationship: [msdyn_quoteinvoicingsetup TransactionCurrency_msdyn_quoteinvoicingsetup](msdyn_quoteinvoicingsetup.md#BKMK_TransactionCurrency_msdyn_quoteinvoicingsetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quoteinvoicingsetup`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_quoteinvoicingsetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_rma"></a> TransactionCurrency_msdyn_rma

Many-To-One Relationship: [msdyn_rma TransactionCurrency_msdyn_rma](msdyn_rma.md#BKMK_TransactionCurrency_msdyn_rma)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_rma`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_rmaproduct"></a> TransactionCurrency_msdyn_rmaproduct

Many-To-One Relationship: [msdyn_rmaproduct TransactionCurrency_msdyn_rmaproduct](msdyn_rmaproduct.md#BKMK_TransactionCurrency_msdyn_rmaproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_rmaproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_rtv"></a> TransactionCurrency_msdyn_rtv

Many-To-One Relationship: [msdyn_rtv TransactionCurrency_msdyn_rtv](msdyn_rtv.md#BKMK_TransactionCurrency_msdyn_rtv)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_rtv`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_rtvproduct"></a> TransactionCurrency_msdyn_rtvproduct

Many-To-One Relationship: [msdyn_rtvproduct TransactionCurrency_msdyn_rtvproduct](msdyn_rtvproduct.md#BKMK_TransactionCurrency_msdyn_rtvproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_rtvproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_salessuggestion"></a> TransactionCurrency_msdyn_salessuggestion

Many-To-One Relationship: [msdyn_salessuggestion TransactionCurrency_msdyn_salessuggestion](msdyn_salessuggestion.md#BKMK_TransactionCurrency_msdyn_salessuggestion)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salessuggestion`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_salessuggestion`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_workorder"></a> TransactionCurrency_msdyn_workorder

Many-To-One Relationship: [msdyn_workorder TransactionCurrency_msdyn_workorder](msdyn_workorder.md#BKMK_TransactionCurrency_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_workordernte"></a> TransactionCurrency_msdyn_workordernte

Many-To-One Relationship: [msdyn_workordernte TransactionCurrency_msdyn_workordernte](msdyn_workordernte.md#BKMK_TransactionCurrency_msdyn_workordernte)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordernte`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_workordernte`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_workorderproduct"></a> TransactionCurrency_msdyn_workorderproduct

Many-To-One Relationship: [msdyn_workorderproduct TransactionCurrency_msdyn_workorderproduct](msdyn_workorderproduct.md#BKMK_TransactionCurrency_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_workorderproduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msdyn_workorderservice"></a> TransactionCurrency_msdyn_workorderservice

Many-To-One Relationship: [msdyn_workorderservice TransactionCurrency_msdyn_workorderservice](msdyn_workorderservice.md#BKMK_TransactionCurrency_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msdyn_workorderservice`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_AttendeePass"></a> TransactionCurrency_msevtmgt_AttendeePass

Many-To-One Relationship: [msevtmgt_attendeepass TransactionCurrency_msevtmgt_AttendeePass](msevtmgt_attendeepass.md#BKMK_TransactionCurrency_msevtmgt_AttendeePass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_attendeepass`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_AttendeePass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Building"></a> TransactionCurrency_msevtmgt_Building

Many-To-One Relationship: [msevtmgt_building TransactionCurrency_msevtmgt_Building](msevtmgt_building.md#BKMK_TransactionCurrency_msevtmgt_Building)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_building`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_Building`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Event"></a> TransactionCurrency_msevtmgt_Event

Many-To-One Relationship: [msevtmgt_event TransactionCurrency_msevtmgt_Event](msevtmgt_event.md#BKMK_TransactionCurrency_msevtmgt_Event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_Event`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_HotelRoomAllocation"></a> TransactionCurrency_msevtmgt_HotelRoomAllocation

Many-To-One Relationship: [msevtmgt_hotelroomallocation TransactionCurrency_msevtmgt_HotelRoomAllocation](msevtmgt_hotelroomallocation.md#BKMK_TransactionCurrency_msevtmgt_HotelRoomAllocation)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomallocation`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_HotelRoomAllocation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_pass"></a> TransactionCurrency_msevtmgt_pass

Many-To-One Relationship: [msevtmgt_pass TransactionCurrency_msevtmgt_pass](msevtmgt_pass.md#BKMK_TransactionCurrency_msevtmgt_pass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_pass`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_pass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Speaker"></a> TransactionCurrency_msevtmgt_Speaker

Many-To-One Relationship: [msevtmgt_speaker TransactionCurrency_msevtmgt_Speaker](msevtmgt_speaker.md#BKMK_TransactionCurrency_msevtmgt_Speaker)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speaker`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_Speaker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_speakerengagement"></a> TransactionCurrency_msevtmgt_speakerengagement

Many-To-One Relationship: [msevtmgt_speakerengagement TransactionCurrency_msevtmgt_speakerengagement](msevtmgt_speakerengagement.md#BKMK_TransactionCurrency_msevtmgt_speakerengagement)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speakerengagement`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_speakerengagement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_SponsorableArticle"></a> TransactionCurrency_msevtmgt_SponsorableArticle

Many-To-One Relationship: [msevtmgt_sponsorablearticle TransactionCurrency_msevtmgt_SponsorableArticle](msevtmgt_sponsorablearticle.md#BKMK_TransactionCurrency_msevtmgt_SponsorableArticle)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorablearticle`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_SponsorableArticle`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Sponsorship"></a> TransactionCurrency_msevtmgt_Sponsorship

Many-To-One Relationship: [msevtmgt_sponsorship TransactionCurrency_msevtmgt_Sponsorship](msevtmgt_sponsorship.md#BKMK_TransactionCurrency_msevtmgt_Sponsorship)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sponsorship`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_Sponsorship`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_msevtmgt_Venue"></a> TransactionCurrency_msevtmgt_Venue

Many-To-One Relationship: [msevtmgt_venue TransactionCurrency_msevtmgt_Venue](msevtmgt_venue.md#BKMK_TransactionCurrency_msevtmgt_Venue)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_venue`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_msevtmgt_Venue`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_opportunity"></a> transactioncurrency_opportunity

Many-To-One Relationship: [opportunity transactioncurrency_opportunity](opportunity.md#BKMK_transactioncurrency_opportunity)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_opportunity`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_opportunityclose"></a> transactioncurrency_opportunityclose

Many-To-One Relationship: [opportunityclose transactioncurrency_opportunityclose](opportunityclose.md#BKMK_transactioncurrency_opportunityclose)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_opportunityclose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_opportunityproduct"></a> transactioncurrency_opportunityproduct

Many-To-One Relationship: [opportunityproduct transactioncurrency_opportunityproduct](opportunityproduct.md#BKMK_transactioncurrency_opportunityproduct)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityproduct`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_opportunityproduct`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_opportunitysalesprocess"></a> transactioncurrency_opportunitysalesprocess

Many-To-One Relationship: [opportunitysalesprocess transactioncurrency_opportunitysalesprocess](opportunitysalesprocess.md#BKMK_transactioncurrency_opportunitysalesprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunitysalesprocess`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_opportunitysalesprocess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_phonetocaseprocess"></a> transactioncurrency_phonetocaseprocess

Many-To-One Relationship: [phonetocaseprocess transactioncurrency_phonetocaseprocess](phonetocaseprocess.md#BKMK_transactioncurrency_phonetocaseprocess)

|Property|Value|
|---|---|
|ReferencingEntity|`phonetocaseprocess`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_phonetocaseprocess`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_pricelevel"></a> transactioncurrency_pricelevel

Many-To-One Relationship: [pricelevel transactioncurrency_pricelevel](pricelevel.md#BKMK_transactioncurrency_pricelevel)

|Property|Value|
|---|---|
|ReferencingEntity|`pricelevel`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_pricelevel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_product"></a> transactioncurrency_product

Many-To-One Relationship: [product transactioncurrency_product](product.md#BKMK_transactioncurrency_product)

|Property|Value|
|---|---|
|ReferencingEntity|`product`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_product`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_ProductAssociation"></a> transactioncurrency_ProductAssociation

Many-To-One Relationship: [productassociation transactioncurrency_ProductAssociation](productassociation.md#BKMK_transactioncurrency_ProductAssociation)

|Property|Value|
|---|---|
|ReferencingEntity|`productassociation`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_ProductAssociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_productpricelevel"></a> transactioncurrency_productpricelevel

Many-To-One Relationship: [productpricelevel transactioncurrency_productpricelevel](productpricelevel.md#BKMK_transactioncurrency_productpricelevel)

|Property|Value|
|---|---|
|ReferencingEntity|`productpricelevel`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_productpricelevel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_ProductSubstitute"></a> transactioncurrency_ProductSubstitute

Many-To-One Relationship: [productsubstitute transactioncurrency_ProductSubstitute](productsubstitute.md#BKMK_transactioncurrency_ProductSubstitute)

|Property|Value|
|---|---|
|ReferencingEntity|`productsubstitute`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_ProductSubstitute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_quote"></a> transactioncurrency_quote

Many-To-One Relationship: [quote transactioncurrency_quote](quote.md#BKMK_transactioncurrency_quote)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_quote`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_quotedetail"></a> transactioncurrency_quotedetail

Many-To-One Relationship: [quotedetail transactioncurrency_quotedetail](quotedetail.md#BKMK_transactioncurrency_quotedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`quotedetail`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_quotedetail`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_ratingmodel"></a> TransactionCurrency_ratingmodel

Many-To-One Relationship: [ratingmodel TransactionCurrency_ratingmodel](ratingmodel.md#BKMK_TransactionCurrency_ratingmodel)

|Property|Value|
|---|---|
|ReferencingEntity|`ratingmodel`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_ratingmodel`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_ratingvalue"></a> TransactionCurrency_ratingvalue

Many-To-One Relationship: [ratingvalue TransactionCurrency_ratingvalue](ratingvalue.md#BKMK_TransactionCurrency_ratingvalue)

|Property|Value|
|---|---|
|ReferencingEntity|`ratingvalue`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_ratingvalue`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_SalesLiterature"></a> TransactionCurrency_SalesLiterature

Many-To-One Relationship: [salesliterature TransactionCurrency_SalesLiterature](salesliterature.md#BKMK_TransactionCurrency_SalesLiterature)

|Property|Value|
|---|---|
|ReferencingEntity|`salesliterature`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_SalesLiterature`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_salesorder"></a> transactioncurrency_salesorder

Many-To-One Relationship: [salesorder transactioncurrency_salesorder](salesorder.md#BKMK_transactioncurrency_salesorder)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_salesorder`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_transactioncurrency_salesorderdetail"></a> transactioncurrency_salesorderdetail

Many-To-One Relationship: [salesorderdetail transactioncurrency_salesorderdetail](salesorderdetail.md#BKMK_transactioncurrency_salesorderdetail)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorderdetail`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`transactioncurrency_salesorderdetail`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_TransactionCurrency_ServiceAppointment"></a> TransactionCurrency_ServiceAppointment

Many-To-One Relationship: [serviceappointment TransactionCurrency_ServiceAppointment](serviceappointment.md#BKMK_TransactionCurrency_ServiceAppointment)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencedEntityNavigationPropertyName|`TransactionCurrency_ServiceAppointment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.transactioncurrency?displayProperty=fullName>
