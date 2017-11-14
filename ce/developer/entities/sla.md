---
title: "SLA Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the SLA entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SLA Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Contains information about the tracked service-level KPIs for cases that belong to different customers.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/slas(*slaid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/slas<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/slas(*slaid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/slas(*slaid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/slas<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/slas(*slaid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/slas(*slaid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: SLA<br />
**DisplayCollectionName**: SLAs<br />
**SchemaName**: SLA<br />
**CollectionSchemaName**: SLAs<br />
**LogicalName**: sla<br />
**LogicalCollectionName**: slas<br />
**EntitySetName**: slas<br />
**PrimaryIdAttribute**: slaid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AllowPauseResume](#BKMK_AllowPauseResume)
- [ApplicableFrom](#BKMK_ApplicableFrom)
- [ApplicableFromPickList](#BKMK_ApplicableFromPickList)
- [BusinessHoursId](#BKMK_BusinessHoursId)
- [ChangedAttributeList](#BKMK_ChangedAttributeList)
- [Description](#BKMK_Description)
- [IsDefault](#BKMK_IsDefault)
- [Name](#BKMK_Name)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [PrimaryEntityOTC](#BKMK_PrimaryEntityOTC)
- [SLAId](#BKMK_SLAId)
- [SLAType](#BKMK_SLAType)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [WorkflowId](#BKMK_WorkflowId)
- [WorkflowIdName](#BKMK_WorkflowIdName)


### <a name="BKMK_AllowPauseResume"></a> AllowPauseResume

**Description**: Select whether this SLA will allow pausing and resuming during the time calculation.<br />
**DisplayName**: Allow Pause and Resume<br />
**LogicalName**: allowpauseresume<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Allow
- **FalseOption Value**: 0 **Label**: Do Not Allow

**DefaultValue**: False


### <a name="BKMK_ApplicableFrom"></a> ApplicableFrom

**Description**: Select the field that specifies the date and time from which the SLA items will be calculated for the case record. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created. <br />
**DisplayName**: Applicable From<br />
**LogicalName**: applicablefrom<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ApplicableFromPickList"></a> ApplicableFromPickList

**Description**: Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created.<br />
**DisplayName**: Applicable From<br />
**LogicalName**: applicablefrompicklist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: No
- **Value**: 2 **Label**: Yes



### <a name="BKMK_BusinessHoursId"></a> BusinessHoursId

**Description**: Choose the business hours for calculating SLA item timelines.<br />
**DisplayName**: Business Hours<br />
**LogicalName**: businesshoursid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: calendar


### <a name="BKMK_ChangedAttributeList"></a> ChangedAttributeList

**Description**: Type additional information to describe the SLA<br />
**DisplayName**: ChangedAttributeList<br />
**LogicalName**: changedattributelist<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1000


### <a name="BKMK_Description"></a> Description

**Description**: Type additional information to describe the SLA<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_IsDefault"></a> IsDefault

**Description**: Tells whether this SLA is the default one.<br />
**DisplayName**: Is Default<br />
**LogicalName**: isdefault<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_Name"></a> Name

**Description**: Type a descriptive name of the service level agreement (SLA).<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_PrimaryEntityOTC"></a> PrimaryEntityOTC

**Description**: Shows the primary entity that the SLA has been created for.<br />
**DisplayName**: Primary Entity<br />
**LogicalName**: primaryentityotc<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_SLAId"></a> SLAId

**Description**: Unique identifier of the SLA.<br />
**DisplayName**: SLA<br />
**LogicalName**: slaid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SLAType"></a> SLAType

**Description**: Select the type of service level agreement (SLA).<br />
**DisplayName**: SLA Type<br />
**LogicalName**: slatype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Standard
- **Value**: 1 **Label**: Enhanced



### <a name="BKMK_StateCode"></a> StateCode

**Description**: Shows whether the Service Level Agreement (SLA) is active or inactive.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Draft **DefaultStatus**: 1 **InvariantName**: Draft
- **Value**: 1 **Label**: Active **DefaultStatus**: 2 **InvariantName**: Active



### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Select the status of the service level agreement (SLA).<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Draft **State**: 0
- **Value**: 2 **Label**: Active **State**: 1



### <a name="BKMK_WorkflowId"></a> WorkflowId

**Description**: Workflow associated with the SLA.<br />
**DisplayName**: Workflow ID<br />
**LogicalName**: workflowid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: workflow


### <a name="BKMK_WorkflowIdName"></a> WorkflowIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: workflowidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BusinessHoursIdName](#BKMK_BusinessHoursIdName)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [SLAIdUnique](#BKMK_SLAIdUnique)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BusinessHoursIdName"></a> BusinessHoursIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: businesshoursidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ComponentState"></a> ComponentState

**Description**: For internal use only.<br />
**DisplayName**: Component State<br />
**LogicalName**: componentstate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Published
- **Value**: 1 **Label**: Unpublished
- **Value**: 2 **Label**: Deleted
- **Value**: 3 **Label**: Deleted Unpublished



### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Description**: Exchange rate between the currency associated with the SLA record and the base currency.<br />
**DisplayName**: Exchange Rate<br />
**LogicalName**: exchangerate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Decimal<br />
**MaxValue**: 100000000000<br />
**MinValue**: 0.0000000001<br />
**Precision**: 10


### <a name="BKMK_IsManaged"></a> IsManaged

**Description**: For internal use only.<br />
**DisplayName**: Is Managed<br />
**LogicalName**: ismanaged<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Managed
- **FalseOption Value**: 0 **Label**: Unmanaged

**DefaultValue**: False


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

**Description**: Choose the entity type that the SLA is defined.<br />
**DisplayName**: Object Type Code<br />
**LogicalName**: objecttypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Account
- **Value**: 2 **Label**: Contact
- **Value**: 3 **Label**: Opportunity
- **Value**: 4 **Label**: Lead
- **Value**: 5 **Label**: Note
- **Value**: 6 **Label**: Business Unit Map
- **Value**: 7 **Label**: Owner
- **Value**: 8 **Label**: User
- **Value**: 9 **Label**: Team
- **Value**: 10 **Label**: Business Unit
- **Value**: 14 **Label**: System User Principal
- **Value**: 16 **Label**: AccountLeads
- **Value**: 17 **Label**: ContactInvoices
- **Value**: 18 **Label**: ContactQuotes
- **Value**: 19 **Label**: ContactOrders
- **Value**: 20 **Label**: Service Contract Contact
- **Value**: 21 **Label**: ProductSalesLiterature
- **Value**: 22 **Label**: ContactLeads
- **Value**: 24 **Label**: LeadCompetitors
- **Value**: 25 **Label**: OpportunityCompetitors
- **Value**: 26 **Label**: CompetitorSalesLiterature
- **Value**: 27 **Label**: LeadProduct
- **Value**: 29 **Label**: Subscription
- **Value**: 30 **Label**: Filter Template
- **Value**: 31 **Label**: Privilege Object Type Code
- **Value**: 32 **Label**: Sales Process Instance
- **Value**: 33 **Label**: Subscription Synchronization Information
- **Value**: 35 **Label**: Tracking information for deleted entities
- **Value**: 36 **Label**: Client update
- **Value**: 37 **Label**: Subscription Manually Tracked Object
- **Value**: 42 **Label**: SystemUser BusinessUnit Entity Map
- **Value**: 44 **Label**: Field Sharing
- **Value**: 45 **Label**: Subscription Statistic Offline
- **Value**: 46 **Label**: Subscription Statistic Outlook
- **Value**: 47 **Label**: Subscription Sync Entry Offline
- **Value**: 48 **Label**: Subscription Sync Entry Outlook
- **Value**: 50 **Label**: Position
- **Value**: 51 **Label**: System User Manager Map
- **Value**: 52 **Label**: User Search Facet
- **Value**: 54 **Label**: Global Search Configuration
- **Value**: 78 **Label**: Virtual Entity Data Provider
- **Value**: 85 **Label**: Virtual Entity Data Source
- **Value**: 92 **Label**: Team template
- **Value**: 99 **Label**: Social Profile
- **Value**: 112 **Label**: Case
- **Value**: 113 **Label**: Child Incident Count
- **Value**: 123 **Label**: Competitor
- **Value**: 126 **Label**: Indexed Article
- **Value**: 127 **Label**: Article
- **Value**: 129 **Label**: Subject
- **Value**: 132 **Label**: Announcement
- **Value**: 135 **Label**: Activity Party
- **Value**: 150 **Label**: User Settings
- **Value**: 950 **Label**: New Process
- **Value**: 951 **Label**: Translation Process
- **Value**: 952 **Label**: Phone To Case Process
- **Value**: 953 **Label**: Opportunity Sales Process
- **Value**: 954 **Label**: Lead To Opportunity Sales Process
- **Value**: 955 **Label**: Expired Process
- **Value**: 1001 **Label**: Attachment
- **Value**: 1002 **Label**: Attachment
- **Value**: 1003 **Label**: Internal Address
- **Value**: 1004 **Label**: Competitor Address
- **Value**: 1006 **Label**: Competitor Product
- **Value**: 1007 **Label**: Image Descriptor
- **Value**: 1010 **Label**: Contract
- **Value**: 1011 **Label**: Contract Line
- **Value**: 1013 **Label**: Discount
- **Value**: 1016 **Label**: Article Template
- **Value**: 1017 **Label**: Lead Address
- **Value**: 1019 **Label**: Organization
- **Value**: 1021 **Label**: Organization UI
- **Value**: 1022 **Label**: Price List
- **Value**: 1023 **Label**: Privilege
- **Value**: 1024 **Label**: Product
- **Value**: 1025 **Label**: Product Association
- **Value**: 1026 **Label**: Price List Item
- **Value**: 1028 **Label**: Product Relationship
- **Value**: 1030 **Label**: System Form
- **Value**: 1031 **Label**: User Dashboard
- **Value**: 1036 **Label**: Security Role
- **Value**: 1037 **Label**: Role Template
- **Value**: 1038 **Label**: Sales Literature
- **Value**: 1039 **Label**: View
- **Value**: 1043 **Label**: String Map
- **Value**: 1048 **Label**: Property
- **Value**: 1049 **Label**: Property Option Set Item
- **Value**: 1055 **Label**: Unit
- **Value**: 1056 **Label**: Unit Group
- **Value**: 1070 **Label**: Sales Attachment
- **Value**: 1071 **Label**: Address
- **Value**: 1072 **Label**: Subscription Clients
- **Value**: 1075 **Label**: Status Map
- **Value**: 1080 **Label**: Discount List
- **Value**: 1082 **Label**: Article Comment
- **Value**: 1083 **Label**: Opportunity Line
- **Value**: 1084 **Label**: Quote
- **Value**: 1085 **Label**: Quote Line
- **Value**: 1086 **Label**: User Fiscal Calendar
- **Value**: 1088 **Label**: Order
- **Value**: 1089 **Label**: Order Line
- **Value**: 1090 **Label**: Invoice
- **Value**: 1091 **Label**: Invoice Line
- **Value**: 1094 **Label**: Authorization Server
- **Value**: 1095 **Label**: Partner Application
- **Value**: 1111 **Label**: System Chart
- **Value**: 1112 **Label**: User Chart
- **Value**: 1113 **Label**: Ribbon Tab To Command Mapping
- **Value**: 1115 **Label**: Ribbon Context Group
- **Value**: 1116 **Label**: Ribbon Command
- **Value**: 1117 **Label**: Ribbon Rule
- **Value**: 1120 **Label**: Application Ribbons
- **Value**: 1130 **Label**: Ribbon Difference
- **Value**: 1140 **Label**: Replication Backlog
- **Value**: 1141 **Label**: Characteristic
- **Value**: 1142 **Label**: Rating Value
- **Value**: 1144 **Label**: Rating Model
- **Value**: 1145 **Label**: Bookable Resource Booking
- **Value**: 1146 **Label**: Bookable Resource Booking Header
- **Value**: 1147 **Label**: Bookable Resource Category
- **Value**: 1148 **Label**: Bookable Resource Characteristic
- **Value**: 1149 **Label**: Bookable Resource Category Assn
- **Value**: 1150 **Label**: Bookable Resource
- **Value**: 1151 **Label**: Bookable Resource Group
- **Value**: 1152 **Label**: Booking Status
- **Value**: 1189 **Label**: Document Suggestions
- **Value**: 1190 **Label**: SuggestionCardTemplate
- **Value**: 1200 **Label**: Field Security Profile
- **Value**: 1201 **Label**: Field Permission
- **Value**: 1203 **Label**: Team Profiles
- **Value**: 1234 **Label**: Channel Property Group
- **Value**: 1235 **Label**: Property Association
- **Value**: 1236 **Label**: Channel Property
- **Value**: 1300 **Label**: SocialInsightsConfiguration
- **Value**: 1309 **Label**: Saved Organization Insights Configuration
- **Value**: 1333 **Label**: Property Instance
- **Value**: 1400 **Label**: Sync Attribute Mapping Profile
- **Value**: 1401 **Label**: Sync Attribute Mapping
- **Value**: 1403 **Label**: Team Sync-Attribute Mapping Profiles
- **Value**: 1404 **Label**: Principal Sync Attribute Map
- **Value**: 2000 **Label**: Annual Fiscal Calendar
- **Value**: 2001 **Label**: Semiannual Fiscal Calendar
- **Value**: 2002 **Label**: Quarterly Fiscal Calendar
- **Value**: 2003 **Label**: Monthly Fiscal Calendar
- **Value**: 2004 **Label**: Fixed Monthly Fiscal Calendar
- **Value**: 2010 **Label**: Email Template
- **Value**: 2011 **Label**: Contract Template
- **Value**: 2012 **Label**: Unresolved Address
- **Value**: 2013 **Label**: Territory
- **Value**: 2015 **Label**: Theme
- **Value**: 2016 **Label**: User Mapping
- **Value**: 2020 **Label**: Queue
- **Value**: 2023 **Label**: QueueItemCount
- **Value**: 2024 **Label**: QueueMemberCount
- **Value**: 2027 **Label**: License
- **Value**: 2029 **Label**: Queue Item
- **Value**: 2500 **Label**: User Entity UI Settings
- **Value**: 2501 **Label**: User Entity Instance Data
- **Value**: 3000 **Label**: Integration Status
- **Value**: 3005 **Label**: Channel Access Profile
- **Value**: 3008 **Label**: External Party
- **Value**: 3231 **Label**: Connection Role
- **Value**: 3233 **Label**: Connection Role Object Type Code
- **Value**: 3234 **Label**: Connection
- **Value**: 4000 **Label**: Facility/Equipment
- **Value**: 4001 **Label**: Service
- **Value**: 4002 **Label**: Resource
- **Value**: 4003 **Label**: Calendar
- **Value**: 4004 **Label**: Calendar Rule
- **Value**: 4005 **Label**: Scheduling Group
- **Value**: 4006 **Label**: Resource Specification
- **Value**: 4007 **Label**: Resource Group
- **Value**: 4009 **Label**: Site
- **Value**: 4010 **Label**: Resource Expansion
- **Value**: 4011 **Label**: Inter Process Lock
- **Value**: 4023 **Label**: Email Hash
- **Value**: 4101 **Label**: Display String Map
- **Value**: 4102 **Label**: Display String
- **Value**: 4110 **Label**: Notification
- **Value**: 4120 **Label**: Exchange Sync Id Mapping
- **Value**: 4200 **Label**: Activity
- **Value**: 4201 **Label**: Appointment
- **Value**: 4202 **Label**: Email
- **Value**: 4204 **Label**: Fax
- **Value**: 4206 **Label**: Case Resolution
- **Value**: 4207 **Label**: Letter
- **Value**: 4208 **Label**: Opportunity Close
- **Value**: 4209 **Label**: Order Close
- **Value**: 4210 **Label**: Phone Call
- **Value**: 4211 **Label**: Quote Close
- **Value**: 4212 **Label**: Task
- **Value**: 4214 **Label**: Service Activity
- **Value**: 4215 **Label**: Commitment
- **Value**: 4216 **Label**: Social Activity
- **Value**: 4220 **Label**: UntrackedEmail
- **Value**: 4230 **Label**: Saved View
- **Value**: 4231 **Label**: Metadata Difference
- **Value**: 4232 **Label**: Business Data Localized Label
- **Value**: 4250 **Label**: Recurrence Rule
- **Value**: 4251 **Label**: Recurring Appointment
- **Value**: 4299 **Label**: Email Search
- **Value**: 4300 **Label**: Marketing List
- **Value**: 4301 **Label**: Marketing List Member
- **Value**: 4400 **Label**: Campaign
- **Value**: 4401 **Label**: Campaign Response
- **Value**: 4402 **Label**: Campaign Activity
- **Value**: 4403 **Label**: Campaign Item
- **Value**: 4404 **Label**: Campaign Activity Item
- **Value**: 4405 **Label**: Bulk Operation Log
- **Value**: 4406 **Label**: Quick Campaign
- **Value**: 4410 **Label**: Data Import
- **Value**: 4411 **Label**: Data Map
- **Value**: 4412 **Label**: Import Source File
- **Value**: 4413 **Label**: Import Data
- **Value**: 4414 **Label**: Duplicate Detection Rule
- **Value**: 4415 **Label**: Duplicate Record
- **Value**: 4416 **Label**: Duplicate Rule Condition
- **Value**: 4417 **Label**: Column Mapping
- **Value**: 4418 **Label**: List Value Mapping
- **Value**: 4419 **Label**: Lookup Mapping
- **Value**: 4420 **Label**: Owner Mapping
- **Value**: 4421 **Label**: BookableResourceBooking to Exchange Id Mapping
- **Value**: 4423 **Label**: Import Log
- **Value**: 4424 **Label**: Bulk Delete Operation
- **Value**: 4425 **Label**: Bulk Delete Failure
- **Value**: 4426 **Label**: Transformation Mapping
- **Value**: 4427 **Label**: Transformation Parameter Mapping
- **Value**: 4428 **Label**: Import Entity Mapping
- **Value**: 4450 **Label**: Data Performance Dashboard
- **Value**: 4490 **Label**: Office Document
- **Value**: 4500 **Label**: Relationship Role
- **Value**: 4501 **Label**: Relationship Role Map
- **Value**: 4502 **Label**: Customer Relationship
- **Value**: 4503 **Label**: Opportunity Relationship
- **Value**: 4545 **Label**: Entitlement Template Product
- **Value**: 4567 **Label**: Auditing
- **Value**: 4579 **Label**: Ribbon Client Metadata.
- **Value**: 4600 **Label**: Entity Map
- **Value**: 4601 **Label**: Attribute Map
- **Value**: 4602 **Label**: Plug-in Type
- **Value**: 4603 **Label**: Plug-in Type Statistic
- **Value**: 4605 **Label**: Plug-in Assembly
- **Value**: 4606 **Label**: Sdk Message
- **Value**: 4607 **Label**: Sdk Message Filter
- **Value**: 4608 **Label**: Sdk Message Processing Step
- **Value**: 4609 **Label**: Sdk Message Request
- **Value**: 4610 **Label**: Sdk Message Response
- **Value**: 4611 **Label**: Sdk Message Response Field
- **Value**: 4613 **Label**: Sdk Message Pair
- **Value**: 4614 **Label**: Sdk Message Request Field
- **Value**: 4615 **Label**: Sdk Message Processing Step Image
- **Value**: 4616 **Label**: Sdk Message Processing Step Secure Configuration
- **Value**: 4618 **Label**: Service Endpoint
- **Value**: 4619 **Label**: Plug-in Trace Log
- **Value**: 4700 **Label**: System Job
- **Value**: 4702 **Label**: Workflow Wait Subscription
- **Value**: 4703 **Label**: Process
- **Value**: 4704 **Label**: Process Dependency
- **Value**: 4705 **Label**: ISV Config
- **Value**: 4706 **Label**: Process Log
- **Value**: 4707 **Label**: Application File
- **Value**: 4708 **Label**: Organization Statistic
- **Value**: 4709 **Label**: Site Map
- **Value**: 4710 **Label**: Process Session
- **Value**: 4711 **Label**: Expander Event
- **Value**: 4712 **Label**: Process Trigger
- **Value**: 4724 **Label**: Process Stage
- **Value**: 4725 **Label**: Business Process Flow Instance
- **Value**: 4800 **Label**: Web Wizard
- **Value**: 4802 **Label**: Wizard Page
- **Value**: 4803 **Label**: Web Wizard Access Privilege
- **Value**: 4810 **Label**: Time Zone Definition
- **Value**: 4811 **Label**: Time Zone Rule
- **Value**: 4812 **Label**: Time Zone Localized Name
- **Value**: 6363 **Label**: Entitlement Product
- **Value**: 7000 **Label**: System Application Metadata
- **Value**: 7001 **Label**: User Application Metadata
- **Value**: 7100 **Label**: Solution
- **Value**: 7101 **Label**: Publisher
- **Value**: 7102 **Label**: Publisher Address
- **Value**: 7103 **Label**: Solution Component
- **Value**: 7105 **Label**: Dependency
- **Value**: 7106 **Label**: Dependency Node
- **Value**: 7107 **Label**: Invalid Dependency
- **Value**: 7108 **Label**: Dependency Feature
- **Value**: 7200 **Label**: RuntimeDependency
- **Value**: 7272 **Label**: Entitlement Contact
- **Value**: 8000 **Label**: Post
- **Value**: 8001 **Label**: Post Role
- **Value**: 8002 **Label**: Post Regarding
- **Value**: 8003 **Label**: Follow
- **Value**: 8005 **Label**: Comment
- **Value**: 8006 **Label**: Like
- **Value**: 8040 **Label**: ACIViewMapper
- **Value**: 8050 **Label**: Trace
- **Value**: 8051 **Label**: Trace Association
- **Value**: 8052 **Label**: Trace Regarding
- **Value**: 8181 **Label**: Routing Rule Set
- **Value**: 8199 **Label**: Rule Item
- **Value**: 8700 **Label**: AppModule Metadata
- **Value**: 8701 **Label**: AppModule Metadata Dependency
- **Value**: 8702 **Label**: AppModule Metadata Async Operation
- **Value**: 8840 **Label**: Hierarchy Rule
- **Value**: 9006 **Label**: App
- **Value**: 9007 **Label**: App Module Component
- **Value**: 9009 **Label**: App Module Roles
- **Value**: 9011 **Label**: App Config Master
- **Value**: 9012 **Label**: App Configuration
- **Value**: 9013 **Label**: App Configuration Instance
- **Value**: 9100 **Label**: Report
- **Value**: 9101 **Label**: Report Related Entity
- **Value**: 9102 **Label**: Report Related Category
- **Value**: 9103 **Label**: Report Visibility
- **Value**: 9104 **Label**: Report Link
- **Value**: 9105 **Label**: Currency
- **Value**: 9106 **Label**: Mail Merge Template
- **Value**: 9107 **Label**: Import Job
- **Value**: 9201 **Label**: LocalConfigStore
- **Value**: 9300 **Label**: Record Creation and Update Rule
- **Value**: 9301 **Label**: Record Creation and Update Rule Item
- **Value**: 9333 **Label**: Web Resource
- **Value**: 9400 **Label**: Channel Access Profile Rule
- **Value**: 9401 **Label**: Channel Access Profile Rule Item
- **Value**: 9502 **Label**: SharePoint Site
- **Value**: 9507 **Label**: Sharepoint Document
- **Value**: 9508 **Label**: Document Location
- **Value**: 9509 **Label**: SharePoint Data
- **Value**: 9510 **Label**: Rollup Properties
- **Value**: 9511 **Label**: Rollup Job
- **Value**: 9600 **Label**: Goal
- **Value**: 9602 **Label**: Rollup Query
- **Value**: 9603 **Label**: Goal Metric
- **Value**: 9604 **Label**: Rollup Field
- **Value**: 9605 **Label**: Email Server Profile
- **Value**: 9606 **Label**: Mailbox
- **Value**: 9607 **Label**: Mailbox Statistics
- **Value**: 9608 **Label**: Mailbox Auto Tracking Folder
- **Value**: 9650 **Label**: Process Configuration
- **Value**: 9690 **Label**: Organization Insights Notification
- **Value**: 9699 **Label**: Organization Insights Metric
- **Value**: 9700 **Label**: Entitlement
- **Value**: 9701 **Label**: Entitlement Channel
- **Value**: 9702 **Label**: Entitlement Template
- **Value**: 9703 **Label**: Entitlement Template Channel
- **Value**: 9750 **Label**: SLA
- **Value**: 9751 **Label**: SLA Item
- **Value**: 9752 **Label**: SLA KPI Instance
- **Value**: 9753 **Label**: Custom Control
- **Value**: 9754 **Label**: Custom Control Resource
- **Value**: 9755 **Label**: Custom Control Default Config
- **Value**: 9866 **Label**: Mobile Offline Profile
- **Value**: 9867 **Label**: Mobile Offline Profile Item
- **Value**: 9868 **Label**: Mobile Offline Profile Item Association
- **Value**: 9869 **Label**: Sync Error
- **Value**: 9870 **Label**: Offline Command Definition
- **Value**: 9900 **Label**: Navigation Setting
- **Value**: 9910 **Label**: MultiEntitySearch
- **Value**: 9912 **Label**: Multi Select Option Value
- **Value**: 9919 **Label**: Hierarchy Security Configuration
- **Value**: 9930 **Label**: Knowledge Base Record
- **Value**: 9931 **Label**: Incident KnowledgeBaseRecord
- **Value**: 9932 **Label**: Time Stamp Date Mapping
- **Value**: 9936 **Label**: Azure Service Connection
- **Value**: 9940 **Label**: Document Template
- **Value**: 9941 **Label**: Personal Document Template
- **Value**: 9942 **Label**: Topic Model Configuration
- **Value**: 9943 **Label**: Topic Model Execution History
- **Value**: 9944 **Label**: Topic Model
- **Value**: 9945 **Label**: Text Analytics Entity Mapping
- **Value**: 9946 **Label**: Topic History
- **Value**: 9947 **Label**: Knowledge Search Model
- **Value**: 9948 **Label**: Text Analytics Topic
- **Value**: 9949 **Label**: Advanced Similarity Rule
- **Value**: 9950 **Label**: Office Graph Document
- **Value**: 9951 **Label**: Similarity Rule
- **Value**: 9953 **Label**: Knowledge Article
- **Value**: 9954 **Label**: Knowledge Article Incident
- **Value**: 9955 **Label**: Knowledge Article Views
- **Value**: 9957 **Label**: Language
- **Value**: 9958 **Label**: Feedback
- **Value**: 9959 **Label**: Category
- **Value**: 9960 **Label**: Knowledge Article Category
- **Value**: 9961 **Label**: DelveActionHub
- **Value**: 9962 **Label**: Action Card
- **Value**: 9968 **Label**: ActionCardUserState
- **Value**: 9973 **Label**: Action Card User Settings
- **Value**: 9983 **Label**: Action Card Type
- **Value**: 9986 **Label**: Interaction for Email
- **Value**: 9987 **Label**: External Party Item
- **Value**: 9997 **Label**: Email Signature
- **Value**: 10000 **Label**: OData v4 Data Source
- **Value**: 10001 **Label**: Profile Album
- **Value**: 10002 **Label**: Post Configuration
- **Value**: 10003 **Label**: Post Rule Configuration
- **Value**: 10004 **Label**: Wall View
- **Value**: 10005 **Label**: Filter
- **Value**: 10006 **Label**: Actual
- **Value**: 10007 **Label**: Booking Alert
- **Value**: 10008 **Label**: Booking Alert Status
- **Value**: 10009 **Label**: Booking Change
- **Value**: 10010 **Label**: Booking Rule
- **Value**: 10011 **Label**: Booking Setup Metadata
- **Value**: 10012 **Label**: Client Extension
- **Value**: 10013 **Label**: Configuration
- **Value**: 10014 **Label**: Organizational Unit
- **Value**: 10015 **Label**: Priority
- **Value**: 10016 **Label**: Requirement Characteristic
- **Value**: 10017 **Label**: Requirement Organization Unit
- **Value**: 10018 **Label**: Requirement Resource Category
- **Value**: 10019 **Label**: Requirement Resource Preference
- **Value**: 10020 **Label**: Requirement Status
- **Value**: 10021 **Label**: Resource Requirement
- **Value**: 10022 **Label**: Resource Requirement Detail
- **Value**: 10023 **Label**: Resource Territory
- **Value**: 10024 **Label**: Schedule Board Setting
- **Value**: 10025 **Label**: Scheduling Parameter
- **Value**: 10026 **Label**: System User Scheduler Setting
- **Value**: 10027 **Label**: Time Group
- **Value**: 10028 **Label**: Time Group Detail
- **Value**: 10029 **Label**: Transaction Origin
- **Value**: 10030 **Label**: Work template
- **Value**: 10031 **Label**: Account Project Price List
- **Value**: 10032 **Label**: Approval
- **Value**: 10033 **Label**: Batch Job
- **Value**: 10034 **Label**: Project Stages
- **Value**: 10035 **Label**: Invoice Process
- **Value**: 10036 **Label**: Competency Requirement (Deprecated)
- **Value**: 10037 **Label**: Contact Price List
- **Value**: 10038 **Label**: Project Contract Line Invoice Schedule
- **Value**: 10039 **Label**: Project Contract Line Milestone
- **Value**: 10040 **Label**: Actual Data Export (Deprecated)
- **Value**: 10041 **Label**: Delegation
- **Value**: 10042 **Label**: Estimate
- **Value**: 10043 **Label**: Estimate Line
- **Value**: 10044 **Label**: Expense
- **Value**: 10045 **Label**: Expense Category
- **Value**: 10046 **Label**: Expense Receipt
- **Value**: 10047 **Label**: Fact
- **Value**: 10048 **Label**: Field Computation
- **Value**: 10049 **Label**: Find Work Event
- **Value**: 10050 **Label**: Integration Job
- **Value**: 10051 **Label**: Integration Job Detail
- **Value**: 10052 **Label**: Invoice Frequency
- **Value**: 10053 **Label**: Invoice Frequency Detail
- **Value**: 10054 **Label**: Invoice Line Detail
- **Value**: 10055 **Label**: Journal
- **Value**: 10056 **Label**: Journal Line
- **Value**: 10057 **Label**: Result Cache
- **Value**: 10058 **Label**: Opportunity Line Resource Category
- **Value**: 10059 **Label**: Opportunity Line Detail
- **Value**: 10060 **Label**: Opportunity Line Transaction Category
- **Value**: 10061 **Label**: Opportunity Line Transaction Classification
- **Value**: 10062 **Label**: Opportunity Project Price List
- **Value**: 10063 **Label**: Project Contract Line Resource Category
- **Value**: 10064 **Label**: Project Contract Line Detail
- **Value**: 10065 **Label**: Project Contract Line Transaction Category
- **Value**: 10066 **Label**: Project Contract Line Transaction Classification
- **Value**: 10067 **Label**: Project Contract Project Price List
- **Value**: 10068 **Label**: Process Notes
- **Value**: 10069 **Label**: Project
- **Value**: 10070 **Label**: Project Approval
- **Value**: 10071 **Label**: Project Parameter
- **Value**: 10072 **Label**: Project Parameter Price List
- **Value**: 10073 **Label**: Project Price List
- **Value**: 10074 **Label**: Project Task
- **Value**: 10075 **Label**: Project Task Dependency
- **Value**: 10076 **Label**: Project Task Status User
- **Value**: 10077 **Label**: Project Team Member
- **Value**: 10078 **Label**: Project Team Member Sign-Up
- **Value**: 10079 **Label**: Project Transaction Category
- **Value**: 10080 **Label**: Quote Line Analytics Breakdown
- **Value**: 10081 **Label**: Quote Line Invoice Schedule
- **Value**: 10082 **Label**: Quote Line Resource Category
- **Value**: 10083 **Label**: Quote Line Milestone
- **Value**: 10084 **Label**: Quote Line Detail
- **Value**: 10085 **Label**: Quote Line Transaction Category
- **Value**: 10086 **Label**: Quote Line Transaction Classification
- **Value**: 10087 **Label**: Quote Project Price List
- **Value**: 10088 **Label**: Resource Assignment
- **Value**: 10089 **Label**: Resource Assignment Detail
- **Value**: 10090 **Label**: Role Price
- **Value**: 10091 **Label**: Resource Request
- **Value**: 10092 **Label**: Role competency requirement
- **Value**: 10093 **Label**: Role Utilization
- **Value**: 10094 **Label**: Time Entry
- **Value**: 10095 **Label**: Time Off Calendar
- **Value**: 10096 **Label**: Transaction Category
- **Value**: 10097 **Label**: Transaction Category Classification
- **Value**: 10098 **Label**: Transaction Category Hierarchy Element
- **Value**: 10099 **Label**: Transaction Category Price
- **Value**: 10100 **Label**: Transaction Connection
- **Value**: 10101 **Label**: Transaction Type
- **Value**: 10102 **Label**: User Work History
- **Value**: 10107 **Label**: Agreement
- **Value**: 10108 **Label**: Agreement Booking Date
- **Value**: 10109 **Label**: Agreement Booking Incident
- **Value**: 10110 **Label**: Agreement Booking Product
- **Value**: 10111 **Label**: Agreement Booking Service
- **Value**: 10112 **Label**: Agreement Booking Service Task
- **Value**: 10113 **Label**: Agreement Booking Setup
- **Value**: 10114 **Label**: Agreement Invoice Date
- **Value**: 10115 **Label**: Agreement Invoice Product
- **Value**: 10116 **Label**: Agreement Invoice Setup
- **Value**: 10117 **Label**: Agreement Sub-Status
- **Value**: 10118 **Label**: Booking Journal
- **Value**: 10119 **Label**: Booking Timestamp
- **Value**: 10120 **Label**: Purchase Order Business Process
- **Value**: 10121 **Label**: Case to Work Order Business Process
- **Value**: 10122 **Label**: Agreement Business Process
- **Value**: 10123 **Label**: Work Order Business Process
- **Value**: 10124 **Label**: Customer Asset
- **Value**: 10125 **Label**: Field Service Price List Item
- **Value**: 10126 **Label**: Field Service Setting
- **Value**: 10127 **Label**: Field Service System Job
- **Value**: 10128 **Label**: Incident Type
- **Value**: 10129 **Label**: Incident Type Characteristic
- **Value**: 10130 **Label**: Incident Type Product
- **Value**: 10131 **Label**: Incident Type Service
- **Value**: 10132 **Label**: Incident Type Service Task
- **Value**: 10133 **Label**: Inventory Adjustment
- **Value**: 10134 **Label**: Inventory Adjustment Product
- **Value**: 10135 **Label**: Inventory Journal
- **Value**: 10136 **Label**: Inventory Transfer
- **Value**: 10137 **Label**: Order Invoicing Date
- **Value**: 10138 **Label**: Order Invoicing Product
- **Value**: 10139 **Label**: Order Invoicing Setup
- **Value**: 10140 **Label**: Order Invoicing Setup Date
- **Value**: 10141 **Label**: Payment
- **Value**: 10142 **Label**: Payment Detail
- **Value**: 10143 **Label**: Payment Method
- **Value**: 10144 **Label**: Payment Term
- **Value**: 10145 **Label**: Postal Code
- **Value**: 10146 **Label**: Product Inventory
- **Value**: 10147 **Label**: Purchase Order
- **Value**: 10148 **Label**: Purchase Order Bill
- **Value**: 10149 **Label**: Purchase Order Product
- **Value**: 10150 **Label**: Purchase Order Receipt
- **Value**: 10151 **Label**: Purchase Order Receipt Product
- **Value**: 10152 **Label**: Purchase Order Sub Status
- **Value**: 10153 **Label**: Quote Booking Incident
- **Value**: 10154 **Label**: Quote Booking Product
- **Value**: 10155 **Label**: Quote Booking Service
- **Value**: 10156 **Label**: Quote Booking Service Task
- **Value**: 10157 **Label**: Quote Booking Setup
- **Value**: 10158 **Label**: Quote Invoicing Product
- **Value**: 10159 **Label**: Quote Invoicing Setup
- **Value**: 10160 **Label**: Resource Pay Type
- **Value**: 10161 **Label**: RMA
- **Value**: 10162 **Label**: RMA Product
- **Value**: 10163 **Label**: RMA Receipt
- **Value**: 10164 **Label**: RMA Receipt Product
- **Value**: 10165 **Label**: RMA Sub-Status
- **Value**: 10166 **Label**: RTV
- **Value**: 10167 **Label**: RTV Product
- **Value**: 10168 **Label**: RTV Sub-Status
- **Value**: 10169 **Label**: Service Task Type
- **Value**: 10170 **Label**: Ship Via
- **Value**: 10171 **Label**: Tax Code
- **Value**: 10172 **Label**: Tax Code Detail
- **Value**: 10173 **Label**: Time Off Request
- **Value**: 10174 **Label**: Unique Number
- **Value**: 10175 **Label**: Warehouse
- **Value**: 10176 **Label**: Work Order
- **Value**: 10177 **Label**: Work Order Characteristic (Deprecated)
- **Value**: 10178 **Label**: Work Order Details Generation Queue (Deprecated)
- **Value**: 10179 **Label**: Work Order Incident
- **Value**: 10180 **Label**: Work Order Product
- **Value**: 10181 **Label**: Resource Restriction (Deprecated)
- **Value**: 10182 **Label**: Work Order Service
- **Value**: 10183 **Label**: Work Order Service Task
- **Value**: 10184 **Label**: Work Order Sub-Status
- **Value**: 10185 **Label**: Work Order Type
- **Value**: 10190 **Label**: IoT Alert
- **Value**: 10191 **Label**: IoT Device
- **Value**: 10192 **Label**: IoT Device Category
- **Value**: 10193 **Label**: IoT Device Command
- **Value**: 10194 **Label**: IoT Device Registration History
- **Value**: 10195 **Label**: CFS - IoT Alert Process Flow



### <a name="BKMK_OverwriteTime"></a> OverwriteTime

**Description**: For internal use only.<br />
**DisplayName**: Record Overwrite Time<br />
**LogicalName**: overwritetime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_SLAIdUnique"></a> SLAIdUnique

**Description**: For internal use only.<br />
**DisplayName**: Unique Id<br />
**LogicalName**: slaidunique<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SolutionId"></a> SolutionId

**Description**: Unique identifier of the associated solution.<br />
**DisplayName**: Solution<br />
**LogicalName**: solutionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

**Description**: For internal use only.<br />
**DisplayName**: Solution<br />
**LogicalName**: supportingsolutionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Description**: Unique identifier of the currency associated with the SLA record.<br />
**DisplayName**: Currency<br />
**LogicalName**: transactioncurrencyid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: transactioncurrency


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: transactioncurrencyidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the SLA.<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [manualsla_lead](#BKMK_manualsla_lead)
- [sla_lead](#BKMK_sla_lead)
- [bulkoperation_sla_slaid](#BKMK_bulkoperation_sla_slaid)
- [bulkoperation_sla_slainvokedid](#BKMK_bulkoperation_sla_slainvokedid)
- [campaignactivity_sla_slaid](#BKMK_campaignactivity_sla_slaid)
- [campaignactivity_sla_slainvokedid](#BKMK_campaignactivity_sla_slainvokedid)
- [campaignresponse_sla_slaid](#BKMK_campaignresponse_sla_slaid)
- [campaignresponse_sla_slainvokedid](#BKMK_campaignresponse_sla_slainvokedid)
- [sla_entitlement](#BKMK_sla_entitlement)
- [manualsla_cases](#BKMK_manualsla_cases)
- [sla_cases](#BKMK_sla_cases)
- [incidentresolution_sla_slaid](#BKMK_incidentresolution_sla_slaid)
- [incidentresolution_sla_slainvokedid](#BKMK_incidentresolution_sla_slainvokedid)
- [manualsla_serviceappointment](#BKMK_manualsla_serviceappointment)
- [sla_serviceappointment](#BKMK_sla_serviceappointment)
- [sla_entitlementtemplate](#BKMK_sla_entitlementtemplate)
- [manualsla_invoice](#BKMK_manualsla_invoice)
- [sla_invoice](#BKMK_sla_invoice)
- [manualsla_opportunity](#BKMK_manualsla_opportunity)
- [sla_opportunity](#BKMK_sla_opportunity)
- [opportunityclose_sla_slaid](#BKMK_opportunityclose_sla_slaid)
- [opportunityclose_sla_slainvokedid](#BKMK_opportunityclose_sla_slainvokedid)
- [orderclose_sla_slaid](#BKMK_orderclose_sla_slaid)
- [orderclose_sla_slainvokedid](#BKMK_orderclose_sla_slainvokedid)
- [manualsla_quote](#BKMK_manualsla_quote)
- [sla_quote](#BKMK_sla_quote)
- [quoteclose_sla_slaid](#BKMK_quoteclose_sla_slaid)
- [quoteclose_sla_slainvokedid](#BKMK_quoteclose_sla_slainvokedid)
- [manualsla_salesorder](#BKMK_manualsla_salesorder)
- [sla_salesorder](#BKMK_sla_salesorder)
- [msdyn_bookingalert_sla_slaid](#BKMK_msdyn_bookingalert_sla_slaid)
- [msdyn_bookingalert_sla_slainvokedid](#BKMK_msdyn_bookingalert_sla_slainvokedid)
- [msdyn_approval_sla_slaid](#BKMK_msdyn_approval_sla_slaid)
- [msdyn_approval_sla_slainvokedid](#BKMK_msdyn_approval_sla_slainvokedid)
- [sla_socialactivity](#BKMK_sla_socialactivity)
- [manualsla_contact](#BKMK_manualsla_contact)
- [slabase_BulkDeleteFailures](#BKMK_slabase_BulkDeleteFailures)
- [manualsla_fax](#BKMK_manualsla_fax)
- [manualsla_activitypointer](#BKMK_manualsla_activitypointer)
- [slabase_AsyncOperations](#BKMK_slabase_AsyncOperations)
- [sla_Annotation](#BKMK_sla_Annotation)
- [sla_task](#BKMK_sla_task)
- [sla_activitypointer](#BKMK_sla_activitypointer)
- [manualsla_task](#BKMK_manualsla_task)
- [manualsla_account](#BKMK_manualsla_account)
- [sla_letter](#BKMK_sla_letter)
- [manualsla_phonecall](#BKMK_manualsla_phonecall)
- [sla_email](#BKMK_sla_email)
- [sla_appointment](#BKMK_sla_appointment)
- [sla_slaitem_slaId](#BKMK_sla_slaitem_slaId)
- [sla_account](#BKMK_sla_account)
- [SLA_SyncErrors](#BKMK_SLA_SyncErrors)
- [manualsla_letter](#BKMK_manualsla_letter)
- [manualsla_appointment](#BKMK_manualsla_appointment)
- [manualsla_socialactivity](#BKMK_manualsla_socialactivity)
- [slabase_userentityinstancedatas](#BKMK_slabase_userentityinstancedatas)
- [sla_fax](#BKMK_sla_fax)
- [sla_contact](#BKMK_sla_contact)
- [slabase_ProcessSessions](#BKMK_slabase_ProcessSessions)
- [sla_phonecall](#BKMK_sla_phonecall)
- [manualsla_email](#BKMK_manualsla_email)


### <a name="BKMK_manualsla_lead"></a> manualsla_lead

Same as lead entity [manualsla_lead](lead.md#BKMK_manualsla_lead) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_lead<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_lead"></a> sla_lead

Same as lead entity [sla_lead](lead.md#BKMK_sla_lead) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_lead<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bulkoperation_sla_slaid"></a> bulkoperation_sla_slaid

Same as bulkoperation entity [bulkoperation_sla_slaid](bulkoperation.md#BKMK_bulkoperation_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_bulkoperation_sla_slainvokedid"></a> bulkoperation_sla_slainvokedid

Same as bulkoperation entity [bulkoperation_sla_slainvokedid](bulkoperation.md#BKMK_bulkoperation_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: bulkoperation<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bulkoperation_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignactivity_sla_slaid"></a> campaignactivity_sla_slaid

Same as campaignactivity entity [campaignactivity_sla_slaid](campaignactivity.md#BKMK_campaignactivity_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignactivity_sla_slainvokedid"></a> campaignactivity_sla_slainvokedid

Same as campaignactivity entity [campaignactivity_sla_slainvokedid](campaignactivity.md#BKMK_campaignactivity_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignactivity_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignresponse_sla_slaid"></a> campaignresponse_sla_slaid

Same as campaignresponse entity [campaignresponse_sla_slaid](campaignresponse.md#BKMK_campaignresponse_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignresponse_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_campaignresponse_sla_slainvokedid"></a> campaignresponse_sla_slainvokedid

Same as campaignresponse entity [campaignresponse_sla_slainvokedid](campaignresponse.md#BKMK_campaignresponse_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: campaignresponse_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_entitlement"></a> sla_entitlement

Same as entitlement entity [sla_entitlement](entitlement.md#BKMK_sla_entitlement) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_entitlement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_cases"></a> manualsla_cases

Same as incident entity [manualsla_cases](incident.md#BKMK_manualsla_cases) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_cases<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_cases"></a> sla_cases

Same as incident entity [sla_cases](incident.md#BKMK_sla_cases) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_cases<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incidentresolution_sla_slaid"></a> incidentresolution_sla_slaid

Same as incidentresolution entity [incidentresolution_sla_slaid](incidentresolution.md#BKMK_incidentresolution_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incidentresolution_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_incidentresolution_sla_slainvokedid"></a> incidentresolution_sla_slainvokedid

Same as incidentresolution entity [incidentresolution_sla_slainvokedid](incidentresolution.md#BKMK_incidentresolution_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: incidentresolution<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: incidentresolution_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_serviceappointment"></a> manualsla_serviceappointment

Same as serviceappointment entity [manualsla_serviceappointment](serviceappointment.md#BKMK_manualsla_serviceappointment) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_serviceappointment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_serviceappointment"></a> sla_serviceappointment

Same as serviceappointment entity [sla_serviceappointment](serviceappointment.md#BKMK_sla_serviceappointment) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_serviceappointment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_entitlementtemplate"></a> sla_entitlementtemplate

Same as entitlementtemplate entity [sla_entitlementtemplate](entitlementtemplate.md#BKMK_sla_entitlementtemplate) Many-To-One relationship.

**ReferencingEntity**: entitlementtemplate<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_entitlementtemplate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_invoice"></a> manualsla_invoice

Same as invoice entity [manualsla_invoice](invoice.md#BKMK_manualsla_invoice) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_invoice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_invoice"></a> sla_invoice

Same as invoice entity [sla_invoice](invoice.md#BKMK_sla_invoice) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_invoice<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_opportunity"></a> manualsla_opportunity

Same as opportunity entity [manualsla_opportunity](opportunity.md#BKMK_manualsla_opportunity) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_opportunity<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_opportunity"></a> sla_opportunity

Same as opportunity entity [sla_opportunity](opportunity.md#BKMK_sla_opportunity) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_opportunity<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_opportunityclose_sla_slaid"></a> opportunityclose_sla_slaid

Same as opportunityclose entity [opportunityclose_sla_slaid](opportunityclose.md#BKMK_opportunityclose_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunityclose_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_opportunityclose_sla_slainvokedid"></a> opportunityclose_sla_slainvokedid

Same as opportunityclose entity [opportunityclose_sla_slainvokedid](opportunityclose.md#BKMK_opportunityclose_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: opportunityclose<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: opportunityclose_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_orderclose_sla_slaid"></a> orderclose_sla_slaid

Same as orderclose entity [orderclose_sla_slaid](orderclose.md#BKMK_orderclose_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: orderclose_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_orderclose_sla_slainvokedid"></a> orderclose_sla_slainvokedid

Same as orderclose entity [orderclose_sla_slainvokedid](orderclose.md#BKMK_orderclose_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: orderclose<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: orderclose_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_quote"></a> manualsla_quote

Same as quote entity [manualsla_quote](quote.md#BKMK_manualsla_quote) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_quote<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_quote"></a> sla_quote

Same as quote entity [sla_quote](quote.md#BKMK_sla_quote) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_quote<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_quoteclose_sla_slaid"></a> quoteclose_sla_slaid

Same as quoteclose entity [quoteclose_sla_slaid](quoteclose.md#BKMK_quoteclose_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: quoteclose_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_quoteclose_sla_slainvokedid"></a> quoteclose_sla_slainvokedid

Same as quoteclose entity [quoteclose_sla_slainvokedid](quoteclose.md#BKMK_quoteclose_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: quoteclose<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: quoteclose_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_salesorder"></a> manualsla_salesorder

Same as salesorder entity [manualsla_salesorder](salesorder.md#BKMK_manualsla_salesorder) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_salesorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_salesorder"></a> sla_salesorder

Same as salesorder entity [sla_salesorder](salesorder.md#BKMK_sla_salesorder) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_salesorder<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingalert_sla_slaid"></a> msdyn_bookingalert_sla_slaid

Same as msdyn_bookingalert entity [msdyn_bookingalert_sla_slaid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingalert_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_bookingalert_sla_slainvokedid"></a> msdyn_bookingalert_sla_slainvokedid

Same as msdyn_bookingalert entity [msdyn_bookingalert_sla_slainvokedid](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bookingalert_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_approval_sla_slaid"></a> msdyn_approval_sla_slaid

Same as msdyn_approval entity [msdyn_approval_sla_slaid](msdyn_approval.md#BKMK_msdyn_approval_sla_slaid) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_sla_slaid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_approval_sla_slainvokedid"></a> msdyn_approval_sla_slainvokedid

Same as msdyn_approval entity [msdyn_approval_sla_slainvokedid](msdyn_approval.md#BKMK_msdyn_approval_sla_slainvokedid) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_approval_sla_slainvokedid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_socialactivity"></a> sla_socialactivity

Same as socialactivity entity [sla_socialactivity](socialactivity.md#BKMK_sla_socialactivity) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_socialactivity<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_contact"></a> manualsla_contact

Same as contact entity [manualsla_contact](contact.md#BKMK_manualsla_contact) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_contact<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_slabase_BulkDeleteFailures"></a> slabase_BulkDeleteFailures

Same as bulkdeletefailure entity [slabase_BulkDeleteFailures](bulkdeletefailure.md#BKMK_slabase_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: slabase_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_fax"></a> manualsla_fax

Same as fax entity [manualsla_fax](fax.md#BKMK_manualsla_fax) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_fax<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_activitypointer"></a> manualsla_activitypointer

Same as activitypointer entity [manualsla_activitypointer](activitypointer.md#BKMK_manualsla_activitypointer) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_activitypointer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_slabase_AsyncOperations"></a> slabase_AsyncOperations

Same as asyncoperation entity [slabase_AsyncOperations](asyncoperation.md#BKMK_slabase_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: slabase_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_Annotation"></a> sla_Annotation

Same as annotation entity [sla_Annotation](annotation.md#BKMK_sla_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_Annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_sla_task"></a> sla_task

Same as task entity [sla_task](task.md#BKMK_sla_task) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_task<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_activitypointer"></a> sla_activitypointer

Same as activitypointer entity [sla_activitypointer](activitypointer.md#BKMK_sla_activitypointer) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_activitypointer<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_task"></a> manualsla_task

Same as task entity [manualsla_task](task.md#BKMK_manualsla_task) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_task<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_account"></a> manualsla_account

Same as account entity [manualsla_account](account.md#BKMK_manualsla_account) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_letter"></a> sla_letter

Same as letter entity [sla_letter](letter.md#BKMK_sla_letter) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_letter<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_phonecall"></a> manualsla_phonecall

Same as phonecall entity [manualsla_phonecall](phonecall.md#BKMK_manualsla_phonecall) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_phonecall<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_email"></a> sla_email

Same as email entity [sla_email](email.md#BKMK_sla_email) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_email<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_appointment"></a> sla_appointment

Same as appointment entity [sla_appointment](appointment.md#BKMK_sla_appointment) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_appointment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_slaitem_slaId"></a> sla_slaitem_slaId

Same as slaitem entity [sla_slaitem_slaId](slaitem.md#BKMK_sla_slaitem_slaId) Many-To-One relationship.

**ReferencingEntity**: slaitem<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_slaitem_slaId<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_account"></a> sla_account

Same as account entity [sla_account](account.md#BKMK_sla_account) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_account<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_SLA_SyncErrors"></a> SLA_SyncErrors

Same as syncerror entity [SLA_SyncErrors](syncerror.md#BKMK_SLA_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: SLA_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_manualsla_letter"></a> manualsla_letter

Same as letter entity [manualsla_letter](letter.md#BKMK_manualsla_letter) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_letter<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_appointment"></a> manualsla_appointment

Same as appointment entity [manualsla_appointment](appointment.md#BKMK_manualsla_appointment) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_appointment<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_socialactivity"></a> manualsla_socialactivity

Same as socialactivity entity [manualsla_socialactivity](socialactivity.md#BKMK_manualsla_socialactivity) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_socialactivity<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10001

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_slabase_userentityinstancedatas"></a> slabase_userentityinstancedatas

Same as userentityinstancedata entity [slabase_userentityinstancedatas](userentityinstancedata.md#BKMK_slabase_userentityinstancedatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: slabase_userentityinstancedatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_fax"></a> sla_fax

Same as fax entity [sla_fax](fax.md#BKMK_sla_fax) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_fax<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_contact"></a> sla_contact

Same as contact entity [sla_contact](contact.md#BKMK_sla_contact) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_contact<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_slabase_ProcessSessions"></a> slabase_ProcessSessions

Same as processsession entity [slabase_ProcessSessions](processsession.md#BKMK_slabase_ProcessSessions) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: slabase_ProcessSessions<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 110

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_sla_phonecall"></a> sla_phonecall

Same as phonecall entity [sla_phonecall](phonecall.md#BKMK_sla_phonecall) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: slainvokedid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: sla_phonecall<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_manualsla_email"></a> manualsla_email

Same as email entity [manualsla_email](email.md#BKMK_manualsla_email) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: slaid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: manualsla_email<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [slabase_workflowid](#BKMK_slabase_workflowid)
- [lk_slabase_modifiedonbehalfby](#BKMK_lk_slabase_modifiedonbehalfby)
- [lk_slabase_createdonbehalfby](#BKMK_lk_slabase_createdonbehalfby)
- [lk_slabase_createdby](#BKMK_lk_slabase_createdby)
- [team_slaBase](#BKMK_team_slaBase)
- [TransactionCurrency_SLA](#BKMK_TransactionCurrency_SLA)
- [lk_slabase_modifiedby](#BKMK_lk_slabase_modifiedby)
- [user_slabase](#BKMK_user_slabase)
- [business_unit_slabase](#BKMK_business_unit_slabase)
- [slabase_businesshoursid](#BKMK_slabase_businesshoursid)


### <a name="BKMK_slabase_workflowid"></a> slabase_workflowid

See workflow Entity [slabase_workflowid](workflow.md#BKMK_slabase_workflowid) One-To-Many relationship.

### <a name="BKMK_lk_slabase_modifiedonbehalfby"></a> lk_slabase_modifiedonbehalfby

See systemuser Entity [lk_slabase_modifiedonbehalfby](systemuser.md#BKMK_lk_slabase_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_slabase_createdonbehalfby"></a> lk_slabase_createdonbehalfby

See systemuser Entity [lk_slabase_createdonbehalfby](systemuser.md#BKMK_lk_slabase_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_slabase_createdby"></a> lk_slabase_createdby

See systemuser Entity [lk_slabase_createdby](systemuser.md#BKMK_lk_slabase_createdby) One-To-Many relationship.

### <a name="BKMK_team_slaBase"></a> team_slaBase

See team Entity [team_slaBase](team.md#BKMK_team_slaBase) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_SLA"></a> TransactionCurrency_SLA

See transactioncurrency Entity [TransactionCurrency_SLA](transactioncurrency.md#BKMK_TransactionCurrency_SLA) One-To-Many relationship.

### <a name="BKMK_lk_slabase_modifiedby"></a> lk_slabase_modifiedby

See systemuser Entity [lk_slabase_modifiedby](systemuser.md#BKMK_lk_slabase_modifiedby) One-To-Many relationship.

### <a name="BKMK_user_slabase"></a> user_slabase

See systemuser Entity [user_slabase](systemuser.md#BKMK_user_slabase) One-To-Many relationship.

### <a name="BKMK_business_unit_slabase"></a> business_unit_slabase

See businessunit Entity [business_unit_slabase](businessunit.md#BKMK_business_unit_slabase) One-To-Many relationship.

### <a name="BKMK_slabase_businesshoursid"></a> slabase_businesshoursid

See calendar Entity [slabase_businesshoursid](calendar.md#BKMK_slabase_businesshoursid) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.sla?text=sla EntityType" />