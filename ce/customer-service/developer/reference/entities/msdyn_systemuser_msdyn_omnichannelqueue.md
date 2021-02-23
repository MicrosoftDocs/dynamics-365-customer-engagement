---
title: "msdyn_systemuser_msdyn_omnichannelqueue Entity Reference | MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_systemuser_msdyn_omnichannelqueue entity."
author: "v-sailab"
ms.author: "v-sailab"
manager: "shujoshi"
ms.date: 03/23/2020
ms.topic: "reference"
ms.service: "dynamics-365-customerservice"
---
# msdyn_systemuser_msdyn_omnichannelqueue Entity Reference

[!INCLUDE[cc-data-platform-banner](../../../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]


> [!IMPORTANT]
> This entity has been deprecated. It will still be visible in the [$metadata](/powerapps/developer/common-data-service/web-api-types-operations#csdl-metadata-document) document of your environment but using it to access Microsoft Dataverse data is not supported.

**Added by**: Omnichannel – Base Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.1/msdyn_systemuser_msdyn_omnichannelqueueset<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName||
|DisplayCollectionName||
|DisplayName||
|EntitySetName|msdyn_systemuser_msdyn_omnichannelqueueset|
|IsBPFEntity|False|
|LogicalCollectionName||
|LogicalName|msdyn_systemuser_msdyn_omnichannelqueue|
|OwnershipType|None|
|PrimaryIdAttribute|msdyn_systemuser_msdyn_omnichannelqueueid|
|PrimaryNameAttribute||
|SchemaName|msdyn_systemuser_msdyn_omnichannelqueue|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [msdyn_omnichannelqueueid](#BKMK_msdyn_omnichannelqueueid)
- [msdyn_systemuser_msdyn_omnichannelqueueId](#BKMK_msdyn_systemuser_msdyn_omnichannelqueueId)
- [systemuserid](#BKMK_systemuserid)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_msdyn_omnichannelqueueid"></a> msdyn_omnichannelqueueid

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_omnichannelqueueid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_systemuser_msdyn_omnichannelqueueId"></a> msdyn_systemuser_msdyn_omnichannelqueueId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_systemuser_msdyn_omnichannelqueueid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_systemuserid"></a> systemuserid

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|systemuserid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|



### See also

[Introduction to Omnichannel for Customer Service](../../../introduction-omnichannel.md)<br />
[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]