---
title: "CustomerRelationship Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the CustomerRelationship entity."
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
# CustomerRelationship Entity Reference

Relationship between a customer and a partner in which either can be an account or contact.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/customerrelationships(*customerrelationshipid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/customerrelationships<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/customerrelationships(*customerrelationshipid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/customerrelationships(*customerrelationshipid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/customerrelationships<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/customerrelationships(*customerrelationshipid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|CustomerRelationships|
|DisplayCollectionName|Customer Relationships|
|DisplayName|Customer Relationship|
|EntitySetName|customerrelationships|
|IsBPFEntity|False|
|LogicalCollectionName|customerrelationships|
|LogicalName|customerrelationship|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|customerrelationshipid|
|PrimaryNameAttribute|customerroleidname|
|SchemaName|CustomerRelationship|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ConverseRelationshipId](#BKMK_ConverseRelationshipId)
- [CustomerId](#BKMK_CustomerId)
- [CustomerIdType](#BKMK_CustomerIdType)
- [CustomerRelationshipId](#BKMK_CustomerRelationshipId)
- [CustomerRoleDescription](#BKMK_CustomerRoleDescription)
- [CustomerRoleId](#BKMK_CustomerRoleId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [PartnerId](#BKMK_PartnerId)
- [PartnerIdType](#BKMK_PartnerIdType)
- [PartnerRoleDescription](#BKMK_PartnerRoleDescription)
- [PartnerRoleId](#BKMK_PartnerRoleId)


### <a name="BKMK_ConverseRelationshipId"></a> ConverseRelationshipId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the converse relationship of the customer relationship.|
|DisplayName|Converse Relationship|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|converserelationshipid|
|RequiredLevel|None|
|Targets|customerrelationship|
|Type|Lookup|


### <a name="BKMK_CustomerId"></a> CustomerId

|Property|Value|
|--------|-----|
|Description|Select the primary account or contact involved in the customer relationship.|
|DisplayName|Party 1|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerid|
|RequiredLevel|SystemRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_CustomerIdType"></a> CustomerIdType

|Property|Value|
|--------|-----|
|Description|Type of the primary customer in the relationship, such as account or contact.|
|DisplayName|Party 1 Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_CustomerRelationshipId"></a> CustomerRelationshipId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the customer relationship.|
|DisplayName|Customer Relationship|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|customerrelationshipid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_CustomerRoleDescription"></a> CustomerRoleDescription

|Property|Value|
|--------|-----|
|Description|Type additional information about the primary party's role in the customer relationship, such as the length or quality of the relationship.|
|DisplayName|Description 1|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerroledescription|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_CustomerRoleId"></a> CustomerRoleId

|Property|Value|
|--------|-----|
|Description|Choose the primary party's role or nature of the relationship the customer has with the second party. The field is read-only until both parties have been selected. Administrators can configure role values under Business Management in the Settings area.|
|DisplayName|Role 1|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|customerroleid|
|RequiredLevel|None|
|Targets|relationshiprole|
|Type|Lookup|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Unique identifier of the data import or data migration that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description|Type of the owner of the customer relationship, such as user, team, or business unit.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PartnerId"></a> PartnerId

|Property|Value|
|--------|-----|
|Description|Select the secondary account or contact involved in the customer relationship.|
|DisplayName|Party 2|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|partnerid|
|RequiredLevel|SystemRequired|
|Targets|account,contact|
|Type|Customer|


### <a name="BKMK_PartnerIdType"></a> PartnerIdType

|Property|Value|
|--------|-----|
|Description|Type of the secondary customer in the relationship, such as account or contact.|
|DisplayName|Party 2 Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|partneridtype|
|RequiredLevel|ApplicationRequired|
|Type|EntityName|


### <a name="BKMK_PartnerRoleDescription"></a> PartnerRoleDescription

|Property|Value|
|--------|-----|
|Description|Type additional information about the secondary party's role in the customer relationship, such as the length or quality of the relationship.|
|DisplayName|Description 2|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|partnerroledescription|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_PartnerRoleId"></a> PartnerRoleId

|Property|Value|
|--------|-----|
|Description|Choose the secondary party's role or nature of the relationship the customer has with the primary party. The field is read-only until both parties have been selected. Administrators can configure role values under Business Management in the Settings area.|
|DisplayName|Role 2|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|partnerroleid|
|RequiredLevel|None|
|Targets|relationshiprole|
|Type|Lookup|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CustomerIdName](#BKMK_CustomerIdName)
- [CustomerIdYomiName](#BKMK_CustomerIdYomiName)
- [CustomerRoleIdName](#BKMK_CustomerRoleIdName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PartnerIdName](#BKMK_PartnerIdName)
- [PartnerIdYomiName](#BKMK_PartnerIdYomiName)
- [PartnerRoleIdName](#BKMK_PartnerRoleIdName)
- [UniqueDscId](#BKMK_UniqueDscId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description|Name of the user who created the customer relationship.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description|YomiName of the user who created the customer relationship.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the customer relationship was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
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


### <a name="BKMK_CustomerIdName"></a> CustomerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CustomerIdYomiName"></a> CustomerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customeridyominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CustomerRoleIdName"></a> CustomerRoleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|customerroleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description|Name of the user who last modified the customer relationship.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description|YomiName of the user who last modified the customer relationship.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
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


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|--------|-----|
|Description|Name of the owner of the customer relationship.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the customer relationship.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|--------|-----|
|Description|Unique identifier of the team who owns the customer relationship.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns the customer relationship.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_PartnerIdName"></a> PartnerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|partneridname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PartnerIdYomiName"></a> PartnerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|partneridyominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PartnerRoleIdName"></a> PartnerRoleIdName

|Property|Value|
|--------|-----|
|Description|Name of the relationship role of the secondary customer.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|partnerroleidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_UniqueDscId"></a> UniqueDscId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|UniqueDscId|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|uniquedscid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [CustomerRelationship_AsyncOperations](#BKMK_CustomerRelationship_AsyncOperations)
- [CustomerRelationship_BulkDeleteFailures](#BKMK_CustomerRelationship_BulkDeleteFailures)
- [userentityinstancedata_customerrelationship](#BKMK_userentityinstancedata_customerrelationship)
- [CustomerRelationship_ProcessSessions](#BKMK_CustomerRelationship_ProcessSessions)
- [customer_relationship_converse_relationship](#BKMK_customer_relationship_converse_relationship)


### <a name="BKMK_CustomerRelationship_AsyncOperations"></a> CustomerRelationship_AsyncOperations

Same as asyncoperation entity [CustomerRelationship_AsyncOperations](asyncoperation.md#BKMK_CustomerRelationship_AsyncOperations) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|CustomerRelationship_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_CustomerRelationship_BulkDeleteFailures"></a> CustomerRelationship_BulkDeleteFailures

Same as bulkdeletefailure entity [CustomerRelationship_BulkDeleteFailures](bulkdeletefailure.md#BKMK_CustomerRelationship_BulkDeleteFailures) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|CustomerRelationship_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_userentityinstancedata_customerrelationship"></a> userentityinstancedata_customerrelationship

Same as userentityinstancedata entity [userentityinstancedata_customerrelationship](userentityinstancedata.md#BKMK_userentityinstancedata_customerrelationship) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_customerrelationship|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_CustomerRelationship_ProcessSessions"></a> CustomerRelationship_ProcessSessions

Same as processsession entity [CustomerRelationship_ProcessSessions](processsession.md#BKMK_CustomerRelationship_ProcessSessions) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|CustomerRelationship_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_customer_relationship_converse_relationship"></a> customer_relationship_converse_relationship

Same as customerrelationship entity [customer_relationship_converse_relationship](customerrelationship.md#BKMK_customer_relationship_converse_relationship) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|customerrelationship|
|ReferencingAttribute|converserelationshipid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|customer_relationship_converse_relationship|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [team_customer_relationship](#BKMK_team_customer_relationship)
- [contact_customer_relationship_partner](#BKMK_contact_customer_relationship_partner)
- [business_unit_customer_relationship](#BKMK_business_unit_customer_relationship)
- [modifiedonbehalfby_customer_relationship](#BKMK_modifiedonbehalfby_customer_relationship)
- [createdby_customer_relationship](#BKMK_createdby_customer_relationship)
- [relationship_role_customer_role](#BKMK_relationship_role_customer_role)
- [account_customer_relationship_customer](#BKMK_account_customer_relationship_customer)
- [customer_relationship_converse_relationship](#BKMK_customer_relationship_converse_relationship)
- [account_customer_relationship_partner](#BKMK_account_customer_relationship_partner)
- [relationship_role_partner_role](#BKMK_relationship_role_partner_role)
- [createdonbehalfby_customer_relationship](#BKMK_createdonbehalfby_customer_relationship)
- [modifiedby_customer_relationship](#BKMK_modifiedby_customer_relationship)
- [user_customer_relationship](#BKMK_user_customer_relationship)
- [contact_customer_relationship_customer](#BKMK_contact_customer_relationship_customer)


### <a name="BKMK_team_customer_relationship"></a> team_customer_relationship

See team Entity [team_customer_relationship](team.md#BKMK_team_customer_relationship) One-To-Many relationship.

### <a name="BKMK_contact_customer_relationship_partner"></a> contact_customer_relationship_partner

See contact Entity [contact_customer_relationship_partner](contact.md#BKMK_contact_customer_relationship_partner) One-To-Many relationship.

### <a name="BKMK_business_unit_customer_relationship"></a> business_unit_customer_relationship

See businessunit Entity [business_unit_customer_relationship](businessunit.md#BKMK_business_unit_customer_relationship) One-To-Many relationship.

### <a name="BKMK_modifiedonbehalfby_customer_relationship"></a> modifiedonbehalfby_customer_relationship

See systemuser Entity [modifiedonbehalfby_customer_relationship](systemuser.md#BKMK_modifiedonbehalfby_customer_relationship) One-To-Many relationship.

### <a name="BKMK_createdby_customer_relationship"></a> createdby_customer_relationship

See systemuser Entity [createdby_customer_relationship](systemuser.md#BKMK_createdby_customer_relationship) One-To-Many relationship.

### <a name="BKMK_relationship_role_customer_role"></a> relationship_role_customer_role

See relationshiprole Entity [relationship_role_customer_role](relationshiprole.md#BKMK_relationship_role_customer_role) One-To-Many relationship.

### <a name="BKMK_account_customer_relationship_customer"></a> account_customer_relationship_customer

See account Entity [account_customer_relationship_customer](account.md#BKMK_account_customer_relationship_customer) One-To-Many relationship.

### <a name="BKMK_customer_relationship_converse_relationship"></a> customer_relationship_converse_relationship

See customerrelationship Entity [customer_relationship_converse_relationship](customerrelationship.md#BKMK_customer_relationship_converse_relationship) One-To-Many relationship.

### <a name="BKMK_account_customer_relationship_partner"></a> account_customer_relationship_partner

See account Entity [account_customer_relationship_partner](account.md#BKMK_account_customer_relationship_partner) One-To-Many relationship.

### <a name="BKMK_relationship_role_partner_role"></a> relationship_role_partner_role

See relationshiprole Entity [relationship_role_partner_role](relationshiprole.md#BKMK_relationship_role_partner_role) One-To-Many relationship.

### <a name="BKMK_createdonbehalfby_customer_relationship"></a> createdonbehalfby_customer_relationship

See systemuser Entity [createdonbehalfby_customer_relationship](systemuser.md#BKMK_createdonbehalfby_customer_relationship) One-To-Many relationship.

### <a name="BKMK_modifiedby_customer_relationship"></a> modifiedby_customer_relationship

See systemuser Entity [modifiedby_customer_relationship](systemuser.md#BKMK_modifiedby_customer_relationship) One-To-Many relationship.

### <a name="BKMK_user_customer_relationship"></a> user_customer_relationship

See systemuser Entity [user_customer_relationship](systemuser.md#BKMK_user_customer_relationship) One-To-Many relationship.

### <a name="BKMK_contact_customer_relationship_customer"></a> contact_customer_relationship_customer

See contact Entity [contact_customer_relationship_customer](contact.md#BKMK_contact_customer_relationship_customer) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.customerrelationship?text=customerrelationship EntityType" />