---
title: "OrgInsightsNotification Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the OrgInsightsNotification entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OrgInsightsNotification Entity Reference

Stores data regarding organization insights notification


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/orginsightsnotifications(*orginsightsnotificationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/orginsightsnotifications<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|OrgInsightsNotifications|
|DisplayCollectionName|Organization Insights Notification|
|DisplayName|Organization Insights Notification|
|EntitySetName|orginsightsnotifications|
|IsBPFEntity|False|
|LogicalCollectionName|orginsightsnotifications|
|LogicalName|orginsightsnotification|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|orginsightsnotificationid|
|PrimaryNameAttribute||
|SchemaName|OrgInsightsNotification|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [InternalName](#BKMK_InternalName)
- [Name](#BKMK_Name)
- [OrgInsightsNotificationId](#BKMK_OrgInsightsNotificationId)


### <a name="BKMK_InternalName"></a> InternalName

|Property|Value|
|--------|-----|
|Description|Name of the notification which is used for retrieving the data|
|DisplayName|Name of the notification that is used for retrieving the data|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|internalname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Legend Name used while displaying the notification|
|DisplayName|Legend Name used wile displaying the notification|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrgInsightsNotificationId"></a> OrgInsightsNotificationId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|orginsightsnotificationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedOn](#BKMK_CreatedOn)
- [JsonData](#BKMK_JsonData)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the organization insights notification was created|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_JsonData"></a> JsonData

|Property|Value|
|--------|-----|
|Description|Notification Data in Json format|
|DisplayName|Notification Data in Json format|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|jsondata|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the record|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_organization_orginsightsnotification"></a> organization_orginsightsnotification

See organization Entity [organization_orginsightsnotification](organization.md#BKMK_organization_orginsightsnotification) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.orginsightsnotification?text=orginsightsnotification EntityType" />