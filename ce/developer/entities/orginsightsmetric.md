---
title: "OrgInsightsMetric Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the OrgInsightsMetric entity."
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
# OrgInsightsMetric Entity Reference

Stores data regarding organization insights metric


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/orginsightsmetrics(*orginsightsmetricid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/orginsightsmetrics<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|OrgInsightsMetrics|
|DisplayCollectionName|Organization Insights Metric|
|DisplayName|Organization Insights Metric|
|EntitySetName|orginsightsmetrics|
|IsBPFEntity|False|
|LogicalCollectionName|orginsightsmetrics|
|LogicalName|orginsightsmetric|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|orginsightsmetricid|
|PrimaryNameAttribute||
|SchemaName|OrgInsightsMetric|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [InternalName](#BKMK_InternalName)
- [MetricType](#BKMK_MetricType)
- [Name](#BKMK_Name)
- [OrgInsightsMetricId](#BKMK_OrgInsightsMetricId)


### <a name="BKMK_InternalName"></a> InternalName

|Property|Value|
|--------|-----|
|Description|Name of the metric which is used for retrieving the data|
|DisplayName|Name of the metric that is used for retrieving the data|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|internalname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MetricType"></a> MetricType

|Property|Value|
|--------|-----|
|Description|Type of the metric|
|DisplayName|Metric Type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|metrictype|
|RequiredLevel|None|
|Type|Picklist|

#### MetricType Options

|Value|Label|
|-----|-----|
|1|Time Series|
|2|Category|



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Legend Name used while displaying the metric|
|DisplayName|Legend Name used wile displaying the metric|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrgInsightsMetricId"></a> OrgInsightsMetricId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|orginsightsmetricid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedOn](#BKMK_CreatedOn)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the organization insights metric was created|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


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


### <a name="BKMK_organization_orginsightsmetric"></a> organization_orginsightsmetric

See organization Entity [organization_orginsightsmetric](organization.md#BKMK_organization_orginsightsmetric) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.orginsightsmetric?text=orginsightsmetric EntityType" />