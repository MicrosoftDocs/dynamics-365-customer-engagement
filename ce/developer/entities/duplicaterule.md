---
title: "DuplicateRule Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the DuplicateRule entity."
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
# DuplicateRule Entity Reference

Rule used to identify potential duplicates.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/duplicaterules(*duplicateruleid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|CompoundUpdateDuplicateDetectionRule|<xref href="Microsoft.Dynamics.CRM.CompoundUpdateDuplicateDetectionRule?text=CompoundUpdateDuplicateDetectionRule Action" />|<xref:Microsoft.Crm.Sdk.Messages.CompoundUpdateDuplicateDetectionRuleRequest>|
|Create|POST [*org URI*]/api/data/v9.0/duplicaterules<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/duplicaterules(*duplicateruleid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|PublishDuplicateRule|<xref href="Microsoft.Dynamics.CRM.PublishDuplicateRule?text=PublishDuplicateRule Action" />|<xref:Microsoft.Crm.Sdk.Messages.PublishDuplicateRuleRequest>|
|PublishXml|<xref href="Microsoft.Dynamics.CRM.PublishXml?text=PublishXml Action" />|<xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/duplicaterules(*duplicateruleid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/duplicaterules<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|UnpublishDuplicateRule|<xref href="Microsoft.Dynamics.CRM.UnpublishDuplicateRule?text=UnpublishDuplicateRule Action" />|<xref:Microsoft.Crm.Sdk.Messages.UnpublishDuplicateRuleRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/duplicaterules(*duplicateruleid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Duplicate Detection Rule<br />
**DisplayCollectionName**: Duplicate Detection Rules<br />
**SchemaName**: DuplicateRule<br />
**CollectionSchemaName**: DuplicateRules<br />
**LogicalName**: duplicaterule<br />
**LogicalCollectionName**: duplicaterules<br />
**EntitySetName**: duplicaterules<br />
**PrimaryIdAttribute**: duplicateruleid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseEntityName](#BKMK_BaseEntityName)
- [Description](#BKMK_Description)
- [DuplicateRuleId](#BKMK_DuplicateRuleId)
- [ExcludeInactiveRecords](#BKMK_ExcludeInactiveRecords)
- [IsCaseSensitive](#BKMK_IsCaseSensitive)
- [MatchingEntityName](#BKMK_MatchingEntityName)
- [Name](#BKMK_Name)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BaseEntityName"></a> BaseEntityName

**Description**: Record type of the record being evaluated for potential duplicates.<br />
**DisplayName**: Base Record Type<br />
**LogicalName**: baseentityname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_Description"></a> Description

**Description**: Description of the duplicate detection rule.<br />
**DisplayName**: Description<br />
**LogicalName**: description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_DuplicateRuleId"></a> DuplicateRuleId

**Description**: Unique identifier of the duplicate detection rule.<br />
**DisplayName**: Duplicate Detection Rule<br />
**LogicalName**: duplicateruleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ExcludeInactiveRecords"></a> ExcludeInactiveRecords

**Description**: Determines whether to flag inactive records as duplicates<br />
**DisplayName**: Exclude Inactive Records<br />
**LogicalName**: excludeinactiverecords<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: True
- **FalseOption Value**: 0 **Label**: False

**DefaultValue**: False


### <a name="BKMK_IsCaseSensitive"></a> IsCaseSensitive

**Description**: Indicates if the operator is case-sensitive.<br />
**DisplayName**: Case Sensitive<br />
**LogicalName**: iscasesensitive<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: True
- **FalseOption Value**: 0 **Label**: False

**DefaultValue**: False


### <a name="BKMK_MatchingEntityName"></a> MatchingEntityName

**Description**: Record type of the records being evaluated as potential duplicates.<br />
**DisplayName**: Matching Record Type<br />
**LogicalName**: matchingentityname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_Name"></a> Name

**Description**: Name of the duplicate detection rule.<br />
**DisplayName**: Rule Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the duplicate detection rule.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_StatusCode"></a> StatusCode

**Description**: Reason for the status of the duplicate detection rule.<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Status<br />
**Options**:

- **Value**: 0 **Label**: Unpublished **State**: 0
- **Value**: 1 **Label**: Publishing **State**: 0
- **Value**: 2 **Label**: Published **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: <br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: <br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BaseEntityMatchCodeTable](#BKMK_BaseEntityMatchCodeTable)
- [BaseEntityTypeCode](#BKMK_BaseEntityTypeCode)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [MatchingEntityMatchCodeTable](#BKMK_MatchingEntityMatchCodeTable)
- [MatchingEntityTypeCode](#BKMK_MatchingEntityTypeCode)
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
- [StateCode](#BKMK_StateCode)


### <a name="BKMK_BaseEntityMatchCodeTable"></a> BaseEntityMatchCodeTable

**Description**: Database table that stores match codes for the record type being evaluated for potential duplicates.<br />
**DisplayName**: Base Record Type Match Code Table<br />
**LogicalName**: baseentitymatchcodetable<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_BaseEntityTypeCode"></a> BaseEntityTypeCode

**Description**: Record type of the record being evaluated for potential duplicates.<br />
**DisplayName**: Base Record Type<br />
**LogicalName**: baseentitytypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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



### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the duplicate detection rule.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: False<br />
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

**Description**: Date and time when the duplicate detection rule was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the duplicaterule.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: False<br />
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


### <a name="BKMK_MatchingEntityMatchCodeTable"></a> MatchingEntityMatchCodeTable

**Description**: Database table that stores match codes for potential duplicate records.<br />
**DisplayName**: Matching Record Type Match Code Table<br />
**LogicalName**: matchingentitymatchcodetable<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_MatchingEntityTypeCode"></a> MatchingEntityTypeCode

**Description**: Record type of the records being evaluated as potential duplicates.<br />
**DisplayName**: Matching Record Type<br />
**LogicalName**: matchingentitytypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the duplicate detection rule.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: False<br />
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

**Description**: Date and time when the duplicate detection rule was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the duplicaterule.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: False<br />
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


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns duplicate detection rule.<br />
**DisplayName**: <br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the duplicate detection rule.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the duplicate detection rule.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_StateCode"></a> StateCode

**Description**: Status of the duplicate detection rule.<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Inactive **DefaultStatus**: 0 **InvariantName**: Inactive
- **Value**: 1 **Label**: Active **DefaultStatus**: 2 **InvariantName**: Active


<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [userentityinstancedata_duplicaterule](#BKMK_userentityinstancedata_duplicaterule)
- [DuplicateRule_Annotation](#BKMK_DuplicateRule_Annotation)
- [DuplicateRule_SyncErrors](#BKMK_DuplicateRule_SyncErrors)
- [DuplicateRule_DuplicateRuleConditions](#BKMK_DuplicateRule_DuplicateRuleConditions)
- [DuplicateRule_DuplicateBaseRecord](#BKMK_DuplicateRule_DuplicateBaseRecord)


### <a name="BKMK_userentityinstancedata_duplicaterule"></a> userentityinstancedata_duplicaterule

Same as userentityinstancedata entity [userentityinstancedata_duplicaterule](userentityinstancedata.md#BKMK_userentityinstancedata_duplicaterule) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_duplicaterule<br />
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


### <a name="BKMK_DuplicateRule_Annotation"></a> DuplicateRule_Annotation

Same as annotation entity [DuplicateRule_Annotation](annotation.md#BKMK_DuplicateRule_Annotation) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: DuplicateRule_Annotation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_DuplicateRule_SyncErrors"></a> DuplicateRule_SyncErrors

Same as syncerror entity [DuplicateRule_SyncErrors](syncerror.md#BKMK_DuplicateRule_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: DuplicateRule_SyncErrors<br />
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


### <a name="BKMK_DuplicateRule_DuplicateRuleConditions"></a> DuplicateRule_DuplicateRuleConditions

Same as duplicaterulecondition entity [DuplicateRule_DuplicateRuleConditions](duplicaterulecondition.md#BKMK_DuplicateRule_DuplicateRuleConditions) Many-To-One relationship.

**ReferencingEntity**: duplicaterulecondition<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: DuplicateRule_DuplicateRuleConditions<br />
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


### <a name="BKMK_DuplicateRule_DuplicateBaseRecord"></a> DuplicateRule_DuplicateBaseRecord

Same as duplicaterecord entity [DuplicateRule_DuplicateBaseRecord](duplicaterecord.md#BKMK_DuplicateRule_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicateruleid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: DuplicateRule_DuplicateBaseRecord<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_duplicaterulebase_createdby](#BKMK_lk_duplicaterulebase_createdby)
- [lk_duplicaterule_createdonbehalfby](#BKMK_lk_duplicaterule_createdonbehalfby)
- [SystemUser_DuplicateRules](#BKMK_SystemUser_DuplicateRules)
- [team_DuplicateRules](#BKMK_team_DuplicateRules)
- [lk_duplicaterule_modifiedonbehalfby](#BKMK_lk_duplicaterule_modifiedonbehalfby)
- [lk_duplicaterulebase_modifiedby](#BKMK_lk_duplicaterulebase_modifiedby)
- [BusinessUnit_DuplicateRules](#BKMK_BusinessUnit_DuplicateRules)


### <a name="BKMK_lk_duplicaterulebase_createdby"></a> lk_duplicaterulebase_createdby

See systemuser Entity [lk_duplicaterulebase_createdby](systemuser.md#BKMK_lk_duplicaterulebase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_duplicaterule_createdonbehalfby"></a> lk_duplicaterule_createdonbehalfby

See systemuser Entity [lk_duplicaterule_createdonbehalfby](systemuser.md#BKMK_lk_duplicaterule_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_SystemUser_DuplicateRules"></a> SystemUser_DuplicateRules

See systemuser Entity [SystemUser_DuplicateRules](systemuser.md#BKMK_SystemUser_DuplicateRules) One-To-Many relationship.

### <a name="BKMK_team_DuplicateRules"></a> team_DuplicateRules

See team Entity [team_DuplicateRules](team.md#BKMK_team_DuplicateRules) One-To-Many relationship.

### <a name="BKMK_lk_duplicaterule_modifiedonbehalfby"></a> lk_duplicaterule_modifiedonbehalfby

See systemuser Entity [lk_duplicaterule_modifiedonbehalfby](systemuser.md#BKMK_lk_duplicaterule_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_duplicaterulebase_modifiedby"></a> lk_duplicaterulebase_modifiedby

See systemuser Entity [lk_duplicaterulebase_modifiedby](systemuser.md#BKMK_lk_duplicaterulebase_modifiedby) One-To-Many relationship.

### <a name="BKMK_BusinessUnit_DuplicateRules"></a> BusinessUnit_DuplicateRules

See businessunit Entity [BusinessUnit_DuplicateRules](businessunit.md#BKMK_BusinessUnit_DuplicateRules) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.duplicaterule?text=duplicaterule EntityType" />