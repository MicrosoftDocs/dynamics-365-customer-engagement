---
title: "SdkMessagePair Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SdkMessagePair entity."
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
# SdkMessagePair Entity Reference

For internal use only.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/sdkmessagepairs(*sdkmessagepairid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/sdkmessagepairs<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|SdkMessagePairs|
|DisplayCollectionName|Sdk Message Pairs|
|DisplayName|Sdk Message Pair|
|EntitySetName|sdkmessagepairs|
|IsBPFEntity|False|
|LogicalCollectionName|sdkmessagepairs|
|LogicalName|sdkmessagepair|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|sdkmessagepairid|
|PrimaryNameAttribute||
|SchemaName|SdkMessagePair|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [DeprecatedVersion](#BKMK_DeprecatedVersion)
- [Endpoint](#BKMK_Endpoint)
- [IntroducedVersion](#BKMK_IntroducedVersion)
- [Namespace](#BKMK_Namespace)
- [SdkMessageBindingInformation](#BKMK_SdkMessageBindingInformation)
- [SdkMessagePairId](#BKMK_SdkMessagePairId)


### <a name="BKMK_DeprecatedVersion"></a> DeprecatedVersion

|Property|Value|
|--------|-----|
|Description|Version in which the component is deprecated.|
|DisplayName|Deprecated Version|
|FormatName|VersionNumber|
|IsLocalizable|False|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|deprecatedversion|
|MaxLength|48|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Endpoint"></a> Endpoint

|Property|Value|
|--------|-----|
|Description|Endpoint that the message pair is associated with.|
|DisplayName|Endpoint|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|endpoint|
|MaxLength|128|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_IntroducedVersion"></a> IntroducedVersion

|Property|Value|
|--------|-----|
|Description|Version in which the component is introduced.|
|DisplayName|Introduced Version|
|FormatName|VersionNumber|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|introducedversion|
|MaxLength|48|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Namespace"></a> Namespace

|Property|Value|
|--------|-----|
|Description|Namespace that the message pair is associated with.|
|DisplayName|Namespace|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|namespace|
|MaxLength|256|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_SdkMessageBindingInformation"></a> SdkMessageBindingInformation

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|sdkmessagebindinginformation|
|MaxLength|128|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SdkMessagePairId"></a> SdkMessagePairId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the SDK message pair entity.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|sdkmessagepairid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomizationLevel](#BKMK_CustomizationLevel)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OverwriteTime](#BKMK_OverwriteTime)
- [SdkMessageId](#BKMK_SdkMessageId)
- [SdkMessagePairIdUnique](#BKMK_SdkMessagePairIdUnique)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Component State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|componentstate|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ComponentState Options

|Value|Label|
|-----|-----|
|0|Published|
|1|Unpublished|
|2|Deleted|
|3|Deleted Unpublished|



### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the SDK message pair.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the SDK message pair was created.|
|DisplayName||
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the sdkmessagepair.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CustomizationLevel"></a> CustomizationLevel

|Property|Value|
|--------|-----|
|Description|Customization level of the SDK message filter.|
|DisplayName||
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customizationlevel|
|MaxValue|255|
|MinValue|-255|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|--------|-----|
|Description|Information that specifies whether this component is managed.|
|DisplayName|State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismanaged|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsManaged Options

|Value|Label|
|-----|-----|
|1|Managed|
|0|Unmanaged|

**DefaultValue**: False



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the SDK message pair.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the SDK message pair was last modified.|
|DisplayName||
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the sdkmessagepair.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization with which the SDK message pair is associated.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|For internal use only.|
|DisplayName|Record Overwrite Time|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|overwritetime|
|RequiredLevel|SystemRequired|
|Type|DateTime|


### <a name="BKMK_SdkMessageId"></a> SdkMessageId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the message with which the SDK message pair is associated.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sdkmessageid|
|RequiredLevel|None|
|Targets|sdkmessage|
|Type|Lookup|


### <a name="BKMK_SdkMessagePairIdUnique"></a> SdkMessagePairIdUnique

|Property|Value|
|--------|-----|
|Description|Unique identifier of the SDK message pair.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sdkmessagepairidunique|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated solution.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|solutionid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Solution|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|supportingsolutionid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [messagepair_sdkmessagerequest](#BKMK_messagepair_sdkmessagerequest)
- [userentityinstancedata_sdkmessagepair](#BKMK_userentityinstancedata_sdkmessagepair)


### <a name="BKMK_messagepair_sdkmessagerequest"></a> messagepair_sdkmessagerequest

Same as sdkmessagerequest entity [messagepair_sdkmessagerequest](sdkmessagerequest.md#BKMK_messagepair_sdkmessagerequest) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessagerequest|
|ReferencingAttribute|sdkmessagepairid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|messagepair_sdkmessagerequest|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_userentityinstancedata_sdkmessagepair"></a> userentityinstancedata_sdkmessagepair

Same as userentityinstancedata entity [userentityinstancedata_sdkmessagepair](userentityinstancedata.md#BKMK_userentityinstancedata_sdkmessagepair) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_sdkmessagepair|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [createdby_sdkmessagepair](#BKMK_createdby_sdkmessagepair)
- [lk_sdkmessagepair_createdonbehalfby](#BKMK_lk_sdkmessagepair_createdonbehalfby)
- [organization_sdkmessagepair](#BKMK_organization_sdkmessagepair)
- [message_sdkmessagepair](#BKMK_message_sdkmessagepair)
- [modifiedby_sdkmessagepair](#BKMK_modifiedby_sdkmessagepair)
- [lk_sdkmessagepair_modifiedonbehalfby](#BKMK_lk_sdkmessagepair_modifiedonbehalfby)


### <a name="BKMK_createdby_sdkmessagepair"></a> createdby_sdkmessagepair

See systemuser Entity [createdby_sdkmessagepair](systemuser.md#BKMK_createdby_sdkmessagepair) One-To-Many relationship.

### <a name="BKMK_lk_sdkmessagepair_createdonbehalfby"></a> lk_sdkmessagepair_createdonbehalfby

See systemuser Entity [lk_sdkmessagepair_createdonbehalfby](systemuser.md#BKMK_lk_sdkmessagepair_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_sdkmessagepair"></a> organization_sdkmessagepair

See organization Entity [organization_sdkmessagepair](organization.md#BKMK_organization_sdkmessagepair) One-To-Many relationship.

### <a name="BKMK_message_sdkmessagepair"></a> message_sdkmessagepair

See sdkmessage Entity [message_sdkmessagepair](sdkmessage.md#BKMK_message_sdkmessagepair) One-To-Many relationship.

### <a name="BKMK_modifiedby_sdkmessagepair"></a> modifiedby_sdkmessagepair

See systemuser Entity [modifiedby_sdkmessagepair](systemuser.md#BKMK_modifiedby_sdkmessagepair) One-To-Many relationship.

### <a name="BKMK_lk_sdkmessagepair_modifiedonbehalfby"></a> lk_sdkmessagepair_modifiedonbehalfby

See systemuser Entity [lk_sdkmessagepair_modifiedonbehalfby](systemuser.md#BKMK_lk_sdkmessagepair_modifiedonbehalfby) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.sdkmessagepair?text=sdkmessagepair EntityType" />