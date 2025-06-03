---
title: "OC Apple Pay Entity (msdyn_ocapplepay) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the OC Apple Pay Entity (msdyn_ocapplepay) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# OC Apple Pay Entity (msdyn_ocapplepay) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the OC Apple Pay Entity (msdyn_ocapplepay) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocapplepaies(*msdyn_ocapplepayid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocapplepaies<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocapplepaies(*msdyn_ocapplepayid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocapplepaies(*msdyn_ocapplepayid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocapplepaies<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocapplepaies(*msdyn_ocapplepayid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocapplepaies(*msdyn_ocapplepayid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocapplepaies(*msdyn_ocapplepayid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the OC Apple Pay Entity (msdyn_ocapplepay) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **OC Apple Pay Entity** |
| **DisplayCollectionName** | **ocapplepay** |
| **SchemaName** | `msdyn_ocapplepay` |
| **CollectionSchemaName** | `msdyn_ocapplepaies` |
| **EntitySetName** | `msdyn_ocapplepaies`|
| **LogicalName** | `msdyn_ocapplepay` |
| **LogicalCollectionName** | `msdyn_ocapplepaies` |
| **PrimaryIdAttribute** | `msdyn_ocapplepayid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_countrycode](#BKMK_msdyn_countrycode)
- [msdyn_fallbackurl](#BKMK_msdyn_fallbackurl)
- [msdyn_merchantcapabilities](#BKMK_msdyn_merchantcapabilities)
- [msdyn_merchantdisplayname](#BKMK_msdyn_merchantdisplayname)
- [msdyn_merchantid](#BKMK_msdyn_merchantid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocapplepayId](#BKMK_msdyn_ocapplepayId)
- [msdyn_ocbase64merchantcertstring](#BKMK_msdyn_ocbase64merchantcertstring)
- [msdyn_ocbase64merchantcertstringcontd](#BKMK_msdyn_ocbase64merchantcertstringcontd)
- [msdyn_ocmerchantcertfilename](#BKMK_msdyn_ocmerchantcertfilename)
- [msdyn_ocmerchantcertificatepassword](#BKMK_msdyn_ocmerchantcertificatepassword)
- [msdyn_ocmerchantdomainurl](#BKMK_msdyn_ocmerchantdomainurl)
- [msdyn_ordertrackingurl](#BKMK_msdyn_ordertrackingurl)
- [msdyn_paymentgatewayurl](#BKMK_msdyn_paymentgatewayurl)
- [msdyn_paymentmethodupdateurl](#BKMK_msdyn_paymentmethodupdateurl)
- [msdyn_shippingcontactupdateurl](#BKMK_msdyn_shippingcontactupdateurl)
- [msdyn_shippingmethodupdateurl](#BKMK_msdyn_shippingmethodupdateurl)
- [msdyn_supportednetworks](#BKMK_msdyn_supportednetworks)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_countrycode"></a> msdyn_countrycode

|Property|Value|
|---|---|
|Description|**Merchant Country Code**|
|DisplayName|**Country Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_countrycode`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_fallbackurl"></a> msdyn_fallbackurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fallback URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fallbackurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_merchantcapabilities"></a> msdyn_merchantcapabilities

|Property|Value|
|---|---|
|Description||
|DisplayName|**Merchant Capabilities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_merchantcapabilities`|
|RequiredLevel|ApplicationRequired|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocapplepay_msdyn_merchantcapabilities`|

#### msdyn_merchantcapabilities Choices/Options

|Value|Label|
|---|---|
|192350000|**Debit**|
|192350001|**Credit**|
|192350002|**3D Secure**|

### <a name="BKMK_msdyn_merchantdisplayname"></a> msdyn_merchantdisplayname

|Property|Value|
|---|---|
|Description|**Merchant display name or domain name**|
|DisplayName|**Merchant Display Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_merchantdisplayname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_merchantid"></a> msdyn_merchantid

|Property|Value|
|---|---|
|Description|**Apple Pay Merchant ID**|
|DisplayName|**Merchant ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_merchantid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocapplepayId"></a> msdyn_ocapplepayId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**OC Apple Pay Entity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocapplepayid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocbase64merchantcertstring"></a> msdyn_ocbase64merchantcertstring

|Property|Value|
|---|---|
|Description|**The Apple Pay Merchant Certificate (Base 64 string)**|
|DisplayName|**The Apple Pay Merchant Certificate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocbase64merchantcertstring`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_ocbase64merchantcertstringcontd"></a> msdyn_ocbase64merchantcertstringcontd

|Property|Value|
|---|---|
|Description|**The Apple Pay Merchant Certificate (Base 64 string)**|
|DisplayName|**The Apple Pay Merchant Certificate - Continued**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocbase64merchantcertstringcontd`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_ocmerchantcertfilename"></a> msdyn_ocmerchantcertfilename

|Property|Value|
|---|---|
|Description|**Merchant Certificate File Name**|
|DisplayName|**Merchant Certificate File Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocmerchantcertfilename`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocmerchantcertificatepassword"></a> msdyn_ocmerchantcertificatepassword

|Property|Value|
|---|---|
|Description|**The password for the Apple Pay Merchant certificate**|
|DisplayName|**Merchant Certificate Password**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocmerchantcertificatepassword`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ocmerchantdomainurl"></a> msdyn_ocmerchantdomainurl

|Property|Value|
|---|---|
|Description|**Merchant Domain URL**|
|DisplayName|**Merchant Domain URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocmerchantdomainurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_ordertrackingurl"></a> msdyn_ordertrackingurl

|Property|Value|
|---|---|
|Description|**Order Tracking URL**|
|DisplayName|**Order Tracking URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ordertrackingurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_paymentgatewayurl"></a> msdyn_paymentgatewayurl

|Property|Value|
|---|---|
|Description|**The URL of the payment service provider**|
|DisplayName|**Payment Gateway URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_paymentgatewayurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_paymentmethodupdateurl"></a> msdyn_paymentmethodupdateurl

|Property|Value|
|---|---|
|Description|**The URL that Apple calls into when payment method is updated**|
|DisplayName|**Payment Method Update URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_paymentmethodupdateurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_shippingcontactupdateurl"></a> msdyn_shippingcontactupdateurl

|Property|Value|
|---|---|
|Description|**The URL that Apple will call into when there is a shipping contact update**|
|DisplayName|**Shipping Contact Update URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shippingcontactupdateurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_shippingmethodupdateurl"></a> msdyn_shippingmethodupdateurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Shipping Method Update URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_shippingmethodupdateurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdyn_supportednetworks"></a> msdyn_supportednetworks

|Property|Value|
|---|---|
|Description||
|DisplayName|**Supported Networks**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_supportednetworks`|
|RequiredLevel|ApplicationRequired|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocapplepay_msdyn_supportednetworks`|

#### msdyn_supportednetworks Choices/Options

|Value|Label|
|---|---|
|192350000|**American Express**|
|192350001|**Visa**|
|192350002|**Discover**|
|192350003|**MasterCard**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the OC Apple Pay Entity**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocapplepay_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the OC Apple Pay Entity**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocapplepay_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyn_ocapplepay](#BKMK_business_unit_msdyn_ocapplepay)
- [lk_msdyn_ocapplepay_createdby](#BKMK_lk_msdyn_ocapplepay_createdby)
- [lk_msdyn_ocapplepay_createdonbehalfby](#BKMK_lk_msdyn_ocapplepay_createdonbehalfby)
- [lk_msdyn_ocapplepay_modifiedby](#BKMK_lk_msdyn_ocapplepay_modifiedby)
- [lk_msdyn_ocapplepay_modifiedonbehalfby](#BKMK_lk_msdyn_ocapplepay_modifiedonbehalfby)
- [owner_msdyn_ocapplepay](#BKMK_owner_msdyn_ocapplepay)
- [team_msdyn_ocapplepay](#BKMK_team_msdyn_ocapplepay)
- [user_msdyn_ocapplepay](#BKMK_user_msdyn_ocapplepay)

### <a name="BKMK_business_unit_msdyn_ocapplepay"></a> business_unit_msdyn_ocapplepay

One-To-Many Relationship: [businessunit business_unit_msdyn_ocapplepay](businessunit.md#BKMK_business_unit_msdyn_ocapplepay)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocapplepay_createdby"></a> lk_msdyn_ocapplepay_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocapplepay_createdby](systemuser.md#BKMK_lk_msdyn_ocapplepay_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocapplepay_createdonbehalfby"></a> lk_msdyn_ocapplepay_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocapplepay_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocapplepay_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocapplepay_modifiedby"></a> lk_msdyn_ocapplepay_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocapplepay_modifiedby](systemuser.md#BKMK_lk_msdyn_ocapplepay_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocapplepay_modifiedonbehalfby"></a> lk_msdyn_ocapplepay_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocapplepay_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocapplepay_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocapplepay"></a> owner_msdyn_ocapplepay

One-To-Many Relationship: [owner owner_msdyn_ocapplepay](owner.md#BKMK_owner_msdyn_ocapplepay)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocapplepay"></a> team_msdyn_ocapplepay

One-To-Many Relationship: [team team_msdyn_ocapplepay](team.md#BKMK_team_msdyn_ocapplepay)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocapplepay"></a> user_msdyn_ocapplepay

One-To-Many Relationship: [systemuser user_msdyn_ocapplepay](systemuser.md#BKMK_user_msdyn_ocapplepay)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid](#BKMK_msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid)
- [msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid](#BKMK_msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid)
- [msdyn_ocapplepay_AsyncOperations](#BKMK_msdyn_ocapplepay_AsyncOperations)
- [msdyn_ocapplepay_BulkDeleteFailures](#BKMK_msdyn_ocapplepay_BulkDeleteFailures)
- [msdyn_ocapplepay_DuplicateBaseRecord](#BKMK_msdyn_ocapplepay_DuplicateBaseRecord)
- [msdyn_ocapplepay_DuplicateMatchingRecord](#BKMK_msdyn_ocapplepay_DuplicateMatchingRecord)
- [msdyn_ocapplepay_MailboxTrackingFolders](#BKMK_msdyn_ocapplepay_MailboxTrackingFolders)
- [msdyn_ocapplepay_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocapplepay_PrincipalObjectAttributeAccesses)
- [msdyn_ocapplepay_ProcessSession](#BKMK_msdyn_ocapplepay_ProcessSession)
- [msdyn_ocapplepay_SyncErrors](#BKMK_msdyn_ocapplepay_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid"></a> msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid

Many-To-One Relationship: [msdyn_ocpaymentprofile msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid](msdyn_ocpaymentprofile.md#BKMK_msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocpaymentprofile`|
|ReferencingAttribute|`msdyn_ocapplepayid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocapplepay_msdyn_ocpaymentprofile_ocapplepayid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid"></a> msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid

Many-To-One Relationship: [msdyn_ocrichobjectmap msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid](msdyn_ocrichobjectmap.md#BKMK_msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocrichobjectmap`|
|ReferencingAttribute|`msdyn_ocapplepayid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocapplepay_msdyn_ocrichobjectmap_ocapplepayid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: ApplePay to RichMap relation<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocapplepay_AsyncOperations"></a> msdyn_ocapplepay_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocapplepay_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocapplepay_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocapplepay_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocapplepay_BulkDeleteFailures"></a> msdyn_ocapplepay_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocapplepay_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocapplepay_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocapplepay_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocapplepay_DuplicateBaseRecord"></a> msdyn_ocapplepay_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocapplepay_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocapplepay_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocapplepay_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocapplepay_DuplicateMatchingRecord"></a> msdyn_ocapplepay_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocapplepay_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocapplepay_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocapplepay_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocapplepay_MailboxTrackingFolders"></a> msdyn_ocapplepay_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocapplepay_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocapplepay_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocapplepay_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocapplepay_PrincipalObjectAttributeAccesses"></a> msdyn_ocapplepay_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocapplepay_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocapplepay_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocapplepay_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocapplepay_ProcessSession"></a> msdyn_ocapplepay_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocapplepay_ProcessSession](processsession.md#BKMK_msdyn_ocapplepay_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocapplepay_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocapplepay_SyncErrors"></a> msdyn_ocapplepay_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocapplepay_SyncErrors](syncerror.md#BKMK_msdyn_ocapplepay_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocapplepay_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

