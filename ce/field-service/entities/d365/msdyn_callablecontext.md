---
title: "Playbook Callable Context (msdyn_callablecontext) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Playbook Callable Context (msdyn_callablecontext) table/entity with Microsoft Dynamics 365."
ms.date: 08.01.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Playbook Callable Context (msdyn_callablecontext) table/entity reference



## Messages

The following table lists the messages for the Playbook Callable Context (msdyn_callablecontext) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_callablecontexts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_callablecontexts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Playbook Callable Context (msdyn_callablecontext) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Playbook Callable Context (msdyn_callablecontext) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Playbook Callable Context** |
| **DisplayCollectionName** | **Playbook Callable Contexts** |
| **SchemaName** | `msdyn_callablecontext` |
| **CollectionSchemaName** | `msdyn_callablecontexts` |
| **EntitySetName** | `msdyn_callablecontexts`|
| **LogicalName** | `msdyn_callablecontext` |
| **LogicalCollectionName** | `msdyn_callablecontexts` |
| **PrimaryIdAttribute** | `msdyn_callablecontextid` |
| **PrimaryNameAttribute** |`msdyn_EntityLogicalName` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_callablecontextId](#BKMK_msdyn_callablecontextId)
- [msdyn_EntityLogicalName](#BKMK_msdyn_EntityLogicalName)
- [msdyn_EntityOTC](#BKMK_msdyn_EntityOTC)
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

### <a name="BKMK_msdyn_callablecontextId"></a> msdyn_callablecontextId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Playbook calling record type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_callablecontextid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_EntityLogicalName"></a> msdyn_EntityLogicalName

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_EntityLogicalName`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_EntityOTC"></a> msdyn_EntityOTC

|Property|Value|
|---|---|
|Description|**Internal Use Only**|
|DisplayName|**Record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_EntityOTC`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_callablecontext_relatedentity`|

#### msdyn_EntityOTC Choices/Options

|Value|Label|
|---|---|
|1|**Account**|
|2|**Contact**|
|3|**Opportunity**|
|4|**Lead**|
|5|**Note**|
|6|**Business Unit Map**|
|7|**Owner**|
|8|**User**|
|9|**Team**|
|10|**Business Unit**|
|14|**System User Principal**|
|16|**AccountLeads**|
|17|**ContactInvoices**|
|18|**ContactQuotes**|
|19|**ContactOrders**|
|20|**Service Contract Contact**|
|21|**ProductSalesLiterature**|
|22|**ContactLeads**|
|24|**LeadCompetitors**|
|25|**OpportunityCompetitors**|
|26|**CompetitorSalesLiterature**|
|27|**LeadProduct**|
|29|**Subscription**|
|30|**Filter Template**|
|31|**Privilege Object Type Code**|
|32|**Sales Process Instance**|
|33|**Subscription Synchronization Information**|
|35|**Tracking information for deleted entities**|
|36|**Client update**|
|37|**Subscription Manually Tracked Object**|
|42|**SystemUser BusinessUnit Entity Map**|
|44|**Field Sharing**|
|45|**Subscription Statistic Offline**|
|46|**Subscription Statistic Outlook**|
|47|**Subscription Sync Entry Offline**|
|48|**Subscription Sync Entry Outlook**|
|50|**Position**|
|51|**System User Manager Map**|
|52|**User Search Facet**|
|54|**Global Search Configuration**|
|55|**FileAttachment**|
|60|**SystemUserAuthorizationChangeTracker**|
|61|**PrincipalEntityBusinessUnitMap**|
|72|**Record Filter**|
|73|**EntityRecordFilter**|
|74|**Secured Masking Rule**|
|78|**Virtual Entity Data Provider**|
|85|**Virtual Entity Data Source**|
|92|**Team template**|
|99|**Social Profile**|
|101|**Service Plan**|
|103|**Privileges Removal Setting**|
|112|**Case**|
|113|**Child Incident Count**|
|123|**Competitor**|
|126|**Indexed Article**|
|127|**Article**|
|129|**Subject**|
|132|**Announcement**|
|135|**Activity Party**|
|150|**User Settings**|
|300|**Canvas App**|
|301|**Callback Registration**|
|372|**Connector**|
|373|**Connection Instance**|
|380|**Environment Variable Definition**|
|381|**Environment Variable Value**|
|400|**AI Template**|
|401|**AI Model**|
|402|**AI Configuration**|
|418|**Dataflow**|
|430|**Entity Analytics Config**|
|431|**Image Attribute Configuration**|
|432|**Entity Image Configuration**|
|950|**New Process**|
|951|**Translation Process**|
|952|**Phone To Case Process**|
|953|**Opportunity Sales Process**|
|954|**Lead To Opportunity Sales Process**|
|955|**Expired Process**|
|1001|**Attachment**|
|1002|**Attachment**|
|1003|**Internal Address**|
|1004|**Competitor Address**|
|1006|**Competitor Product**|
|1007|**Image Descriptor**|
|1010|**Contract**|
|1011|**Contract Line**|
|1013|**Discount**|
|1016|**Article Template**|
|1017|**Lead Address**|
|1019|**Organization**|
|1021|**Organization UI**|
|1022|**Price List**|
|1023|**Privilege**|
|1024|**Product**|
|1025|**Product Association**|
|1026|**Price List Item**|
|1028|**Product Relationship**|
|1030|**System Form**|
|1031|**User Dashboard**|
|1036|**Security Role**|
|1037|**Role Template**|
|1038|**Sales Literature**|
|1039|**View**|
|1043|**String Map**|
|1048|**Property**|
|1049|**Property Option Set Item**|
|1055|**Unit**|
|1056|**Unit Group**|
|1070|**Sales Attachment**|
|1071|**Address**|
|1072|**Subscription Clients**|
|1075|**Status Map**|
|1080|**Discount List**|
|1082|**Article Comment**|
|1083|**Opportunity Product**|
|1084|**Quote**|
|1085|**Quote Product**|
|1086|**User Fiscal Calendar**|
|1088|**Order**|
|1089|**Order Product**|
|1090|**Invoice**|
|1091|**Invoice Product**|
|1094|**Authorization Server**|
|1095|**Partner Application**|
|1111|**System Chart**|
|1112|**User Chart**|
|1113|**Ribbon Tab To Command Mapping**|
|1115|**Ribbon Context Group**|
|1116|**Ribbon Command**|
|1117|**Ribbon Rule**|
|1120|**Application Ribbons**|
|1130|**Ribbon Difference**|
|1140|**Replication Backlog**|
|1141|**Characteristic**|
|1142|**Rating Value**|
|1144|**Rating Model**|
|1145|**Bookable Resource Booking**|
|1146|**Bookable Resource Booking Header**|
|1147|**Bookable Resource Category**|
|1148|**Bookable Resource Characteristic**|
|1149|**Bookable Resource Category Assn**|
|1150|**Bookable Resource**|
|1151|**Bookable Resource Group**|
|1152|**Booking Status**|
|1189|**Document Suggestions**|
|1190|**SuggestionCardTemplate**|
|1200|**Field Security Profile**|
|1201|**Field Permission**|
|1203|**Team Profiles**|
|1204|**Application**|
|1234|**Channel Property Group**|
|1235|**Property Association**|
|1236|**Channel Property**|
|1300|**SocialInsightsConfiguration**|
|1309|**Saved Organization Insights Configuration**|
|1333|**Property Instance**|
|1400|**Sync Attribute Mapping Profile**|
|1401|**Sync Attribute Mapping**|
|1403|**Team Sync-Attribute Mapping Profiles**|
|1404|**Principal Sync Attribute Map**|
|2000|**Annual Fiscal Calendar**|
|2001|**Semiannual Fiscal Calendar**|
|2002|**Quarterly Fiscal Calendar**|
|2003|**Monthly Fiscal Calendar**|
|2004|**Fixed Monthly Fiscal Calendar**|
|2010|**Email Template**|
|2011|**Contract Template**|
|2012|**Unresolved Address**|
|2013|**Territory**|
|2015|**Theme**|
|2016|**User Mapping**|
|2020|**Queue**|
|2023|**QueueItemCount**|
|2024|**QueueMemberCount**|
|2027|**License**|
|2029|**Queue Item**|
|2500|**User Entity UI Settings**|
|2501|**User Entity Instance Data**|
|3000|**Integration Status**|
|3005|**Channel Access Profile**|
|3008|**External Party**|
|3231|**Connection Role**|
|3233|**Connection Role Object Type Code**|
|3234|**Connection**|
|4000|**Facility/Equipment**|
|4001|**Service**|
|4002|**Resource**|
|4003|**Calendar**|
|4004|**Calendar Rule**|
|4005|**Scheduling Group**|
|4006|**Resource Specification**|
|4007|**Resource Group**|
|4009|**Site**|
|4010|**Resource Expansion**|
|4011|**Inter Process Lock**|
|4023|**Email Hash**|
|4101|**Display String Map**|
|4102|**Display String**|
|4110|**Notification**|
|4120|**Exchange Sync Id Mapping**|
|4200|**Activity**|
|4201|**Appointment**|
|4202|**Email**|
|4204|**Fax**|
|4206|**Case Resolution**|
|4207|**Letter**|
|4208|**Opportunity Close**|
|4209|**Order Close**|
|4210|**Phone Call**|
|4211|**Quote Close**|
|4212|**Task**|
|4214|**Service Activity**|
|4215|**Commitment**|
|4216|**Social Activity**|
|4220|**UntrackedEmail**|
|4230|**Saved View**|
|4231|**Metadata Difference**|
|4232|**Business Data Localized Label**|
|4250|**Recurrence Rule**|
|4251|**Recurring Appointment**|
|4299|**Email Search**|
|4300|**Marketing List**|
|4301|**Marketing List Member**|
|4400|**Campaign**|
|4401|**Campaign Response**|
|4402|**Campaign Activity**|
|4403|**Campaign Item**|
|4404|**Campaign Activity Item**|
|4405|**Bulk Operation Log**|
|4406|**Quick Campaign**|
|4410|**Data Import**|
|4411|**Data Map**|
|4412|**Import Source File**|
|4413|**Import Data**|
|4414|**Duplicate Detection Rule**|
|4415|**Duplicate Record**|
|4416|**Duplicate Rule Condition**|
|4417|**Column Mapping**|
|4418|**List Value Mapping**|
|4419|**Lookup Mapping**|
|4420|**Owner Mapping**|
|4421|**Bookable Resource Booking to Exchange Id Mapping**|
|4423|**Import Log**|
|4424|**Bulk Delete Operation**|
|4425|**Bulk Delete Failure**|
|4426|**Transformation Mapping**|
|4427|**Transformation Parameter Mapping**|
|4428|**Import Entity Mapping**|
|4450|**Data Performance Dashboard**|
|4490|**Office Document**|
|4500|**Relationship Role**|
|4501|**Relationship Role Map**|
|4502|**Customer Relationship**|
|4503|**Opportunity Relationship**|
|4545|**Entitlement Template Product**|
|4567|**Auditing**|
|4579|**Ribbon Client Metadata.**|
|4600|**Entity Map**|
|4601|**Attribute Map**|
|4602|**Plug-in Type**|
|4603|**Plug-in Type Statistic**|
|4605|**Plug-in Assembly**|
|4606|**Sdk Message**|
|4607|**Sdk Message Filter**|
|4608|**Sdk Message Processing Step**|
|4609|**Sdk Message Request**|
|4610|**Sdk Message Response**|
|4611|**Sdk Message Response Field**|
|4613|**Sdk Message Pair**|
|4614|**Sdk Message Request Field**|
|4615|**Sdk Message Processing Step Image**|
|4616|**Sdk Message Processing Step Secure Configuration**|
|4618|**Service Endpoint**|
|4619|**Plug-in Trace Log**|
|4700|**System Job**|
|4702|**Workflow Wait Subscription**|
|4703|**Process**|
|4704|**Process Dependency**|
|4705|**ISV Config**|
|4706|**Process Log**|
|4707|**Application File**|
|4708|**Organization Statistic**|
|4709|**Site Map**|
|4710|**Process Session**|
|4711|**Expander Event**|
|4712|**Process Trigger**|
|4720|**Flow Session**|
|4724|**Process Stage**|
|4725|**Business Process Flow Instance**|
|4800|**Web Wizard**|
|4802|**Wizard Page**|
|4803|**Web Wizard Access Privilege**|
|4810|**Time Zone Definition**|
|4811|**Time Zone Rule**|
|4812|**Time Zone Localized Name**|
|5000|**Recently Used**|
|5004|**NL2SQ Registration Information**|
|6363|**Entitlement Product**|
|7000|**System Application Metadata**|
|7001|**User Application Metadata**|
|7100|**Solution**|
|7101|**Publisher**|
|7102|**Publisher Address**|
|7103|**Solution Component**|
|7104|**Solution Component Definition**|
|7105|**Dependency**|
|7106|**Dependency Node**|
|7107|**Invalid Dependency**|
|7108|**Dependency Feature**|
|7200|**RuntimeDependency**|
|7272|**Entitlement Contact**|
|7755|**ElasticFileAttachment**|
|8000|**Post**|
|8001|**Post Role**|
|8002|**Post Regarding**|
|8003|**Follow**|
|8005|**Comment**|
|8006|**Like**|
|8040|**ACIViewMapper**|
|8050|**Trace**|
|8051|**Trace Association**|
|8052|**Trace Regarding**|
|8181|**Routing Rule Set**|
|8199|**Rule Item**|
|8700|**AppModule Metadata**|
|8701|**AppModule Metadata Dependency**|
|8702|**AppModule Metadata Async Operation**|
|8840|**Hierarchy Rule**|
|9006|**Model-driven App**|
|9007|**App Module Component**|
|9009|**App Module Roles**|
|9011|**App Config Master**|
|9012|**App Configuration**|
|9013|**App Configuration Instance**|
|9100|**Report**|
|9101|**Report Related Entity**|
|9102|**Report Related Category**|
|9103|**Report Visibility**|
|9104|**Report Link**|
|9105|**Currency**|
|9106|**Mail Merge Template**|
|9107|**Import Job**|
|9201|**LocalConfigStore**|
|9300|**Record Creation and Update Rule**|
|9301|**Record Creation and Update Rule Item**|
|9333|**Web Resource**|
|9400|**Channel Access Profile Rule**|
|9401|**Channel Access Profile Rule Item**|
|9502|**SharePoint Site**|
|9507|**Sharepoint Document**|
|9508|**Document Location**|
|9509|**SharePoint Data**|
|9510|**Rollup Properties**|
|9511|**Rollup Job**|
|9600|**Goal**|
|9602|**Rollup Query**|
|9603|**Goal Metric**|
|9604|**Rollup Field**|
|9605|**Email Server Profile**|
|9606|**Mailbox**|
|9607|**Mailbox Statistics**|
|9608|**Mailbox Auto Tracking Folder**|
|9609|**Mailbox Tracking Category**|
|9650|**Process Configuration**|
|9690|**Organization Insights Notification**|
|9699|**Organization Insights Metric**|
|9700|**Entitlement**|
|9701|**Entitlement Channel**|
|9702|**Entitlement Template**|
|9703|**Entitlement Template Channel**|
|9704|**Entitlement Entity Allocation Type Mapping**|
|9750|**SLA**|
|9751|**SLA Item**|
|9752|**SLA KPI Instance**|
|9753|**Custom Control**|
|9754|**Custom Control Resource**|
|9755|**Custom Control Default Config**|
|9800|**Entity**|
|9808|**Attribute**|
|9809|**OptionSet**|
|9810|**Entity Key**|
|9811|**Entity Relationship**|
|9812|**Managed Property**|
|9813|**Relationship Entity**|
|9814|**Relationship Attribute**|
|9815|**Entity Index**|
|9816|**Index Attribute**|
|9820|**Secured Masking Column**|
|9866|**Mobile Offline Profile**|
|9867|**Mobile Offline Profile Item**|
|9868|**Mobile Offline Profile Item Association**|
|9869|**Sync Error**|
|9870|**Offline Command Definition**|
|9875|**Language Provisioning State**|
|9880|**Ribbon Metadata To Process**|
|9890|**SolutionHistoryData**|
|9900|**Navigation Setting**|
|9910|**MultiEntitySearch**|
|9912|**Multi Select Option Value**|
|9919|**Hierarchy Security Configuration**|
|9930|**Knowledge Base Record**|
|9931|**Incident KnowledgeBaseRecord**|
|9932|**Time Stamp Date Mapping**|
|9936|**Azure Service Connection**|
|9940|**Document Template**|
|9941|**Personal Document Template**|
|9942|**Topic Model Configuration**|
|9943|**Topic Model Execution History**|
|9944|**Topic Model**|
|9945|**Text Analytics Entity Mapping**|
|9946|**Topic History**|
|9947|**Knowledge Search Model**|
|9948|**Text Analytics Topic**|
|9949|**Advanced Similarity Rule**|
|9950|**Office Graph Document**|
|9951|**Similarity Rule**|
|9953|**Knowledge Article**|
|9954|**Knowledge Article Incident**|
|9955|**Knowledge Article Views**|
|9957|**Language**|
|9958|**Feedback**|
|9959|**Category**|
|9960|**Knowledge Article Category**|
|9961|**DelveActionHub**|
|9962|**Action Card**|
|9968|**ActionCardUserState**|
|9973|**Action Card User Settings**|
|9983|**Action Card Type**|
|9986|**Interaction for Email**|
|9987|**External Party Item**|
|9996|**HolidayWrapper**|
|9997|**Email Signature**|
|10000|**Solution Component Attribute Configuration**|
|10001|**Solution Component Batch Configuration**|
|10002|**Solution Component Configuration**|
|10003|**Solution Component Relationship Configuration**|
|10004|**Solution History**|
|10005|**Solution History Data Source**|
|10006|**Component Layer**|
|10007|**Component Layer Data Source**|
|10008|**Package**|
|10009|**Package History**|
|10011|**StageSolutionUpload**|
|10012|**ExportSolutionUpload**|
|10013|**FeatureControlSetting**|
|10014|**Solution Component Summary**|
|10015|**Solution Component Count Summary**|
|10016|**Solution Component Data Source**|
|10017|**Solution Component Count Data Source**|
|10018|**Microsoft Entra ID**|
|10019|**Staged Entity**|
|10020|**Staged Entity Attribute**|
|10021|**Staged Metadata Async Operation**|
|10022|**Key Vault Reference**|
|10023|**Managed Identity**|
|10024|**Catalog**|
|10025|**Catalog Assignment**|
|10026|**Internal Catalog Assignment**|
|10027|**Custom API**|
|10028|**Custom API Request Parameter**|
|10029|**Custom API Response Property**|
|10030|**Plugin Package**|
|10031|**NonRelational Data Source**|
|10032|**ProvisionLanguageForUser**|
|10033|**Shared Object**|
|10034|**Shared Workspace**|
|10035|**Shared Workspace Access Token**|
|10036|**Shared Workspace Non-Relational**|
|10037|**Shared Workspace Pool**|
|10038|**Data Lake Folder**|
|10039|**Data Lake Folder Permission**|
|10040|**Data Lake Workspace**|
|10041|**Data Lake Workspace Permission**|
|10042|**Data Processing configuration**|
|10043|**Exported Excel**|
|10044|**RetainedData Excel**|
|10045|**Synapse Database**|
|10046|**Synapse Link External Table State**|
|10047|**Synapse Link Profile**|
|10048|**Synapse Link Profile Entity**|
|10049|**Synapse Link Profile Entity State**|
|10050|**Synapse Link Schedule**|
|10051|**Component Version**|
|10052|**Component Version Data Source**|
|10053|**Component Version (Internal)**|
|10054|**DataflowRefreshHistory**|
|10055|**EntityRefreshHistory**|
|10056|**Shared Link Setting**|
|10057|**DelegatedAuthorization**|
|10059|**CascadeGrantRevokeAccessRecordsTracker**|
|10060|**CascadeGrantRevokeAccessVersionTracker**|
|10061|**RevokeInheritedAccessRecordsTracker**|
|10062|**TdsMetadata**|
|10063|**Model-Driven App Element**|
|10064|**Model-Driven App Component Node's Edge**|
|10065|**Model-Driven App Component Node**|
|10066|**Model-Driven App Setting**|
|10067|**Model-Driven App User Setting**|
|10068|**Organization Setting**|
|10069|**Setting Definition**|
|10070|**CanvasApp Extended Metadata**|
|10071|**Service Plan Mapping**|
|10072|**Service Plan Custom Control**|
|10074|**ApplicationUser**|
|10077|**OData v4 Data Source**|
|10078|**Workflow Binary**|
|10079|**Credential**|
|10080|**Desktop Flow Module**|
|10081|**Flow Capacity Assignment**|
|10082|**Flow Credential Application**|
|10083|**Flow Event**|
|10084|**Flow Machine**|
|10085|**Flow Machine Group**|
|10086|**Flow Machine Image**|
|10087|**Flow Machine Image Version**|
|10088|**Flow Machine Network**|
|10089|**ProcessStageParameter**|
|10090|**Work Queue**|
|10091|**Work Queue Item**|
|10092|**Desktop Flow Binary**|
|10093|**Flow Log**|
|10094|**Flow Run**|
|10095|**Action Approval Model**|
|10096|**Approval**|
|10097|**Approval Request**|
|10098|**Approval Response**|
|10099|**Approval Step**|
|10100|**Await All Action Approval Model**|
|10101|**Await All Approval Model**|
|10102|**Basic Approval Model Data**|
|10103|**Flow Approval**|
|10112|**Connection Reference**|
|10113|**DVFileSearch**|
|10114|**DVFileSearchAttribute**|
|10115|**DVFileSearchEntity**|
|10116|**DVTableSearch**|
|10117|**DVTableSearchAttribute**|
|10118|**DVTableSearchEntity**|
|10119|**AICopilot**|
|10120|**AIPluginAuth**|
|10121|**AI Plugin Conversation Starter**|
|10122|**AI Plugin Conversation Starter Mapping**|
|10123|**AI Plugin Governance**|
|10124|**AI Plugin Governance Extended**|
|10125|**AIPluginOperationResponseTemplate**|
|10126|**AIPluginTitle**|
|10127|**SideloadedAIPlugin**|
|10128|**AIPlugin**|
|10129|**AIPluginExternalSchema**|
|10130|**AIPluginExternalSchemaProperty**|
|10131|**AIPluginInstance**|
|10132|**AIPluginOperation**|
|10133|**AIPluginOperationParameter**|
|10134|**AIPluginUserSetting**|
|10136|**AI Event**|
|10137|**AI Builder Feedback Loop**|
|10138|**AI Form Processing Document**|
|10139|**AI Object Detection Image**|
|10140|**AI Object Detection Label**|
|10141|**AI Object Detection Bounding Box**|
|10142|**AI Object Detection Image Mapping**|
|10144|**AI Builder Dataset**|
|10145|**AI Builder Dataset File**|
|10146|**AI Builder Dataset Record**|
|10147|**AI Builder Datasets Container**|
|10148|**AI Builder File**|
|10149|**AI Builder File Attached Data**|
|10150|**Help Page**|
|10151|**Tour**|
|10152|**BotContent**|
|10153|**ConversationTranscript**|
|10154|**Chatbot**|
|10155|**Chatbot subcomponent**|
|10156|**Chatbot component collection**|
|10167|**Comment**|
|10168|**Fabric AISkill**|
|10169|**App Insights Metadata**|
|10170|**Dataflow Connection Reference**|
|10171|**Schedule**|
|10172|**Dataflow Template**|
|10173|**Dataflow DatalakeFolder**|
|10174|**Data Movement Service Request**|
|10175|**Data Movement Service Request Status**|
|10176|**DMS Sync Request**|
|10177|**DMS Sync Status**|
|10178|**Knowledge Asset Configuration**|
|10179|**Module Run Detail**|
|10180|**Salesforce Structured Object**|
|10181|**Salesforce Structured QnA Config**|
|10182|**Workflow Action Status**|
|10183|**PDF Setting**|
|10184|**Activity File Attachment**|
|10185|**Teams chat**|
|10186|**Service Configuration**|
|10187|**SLA KPI**|
|10188|**Integrated search provider**|
|10189|**Knowledge Management Setting**|
|10190|**Knowledge Federated Article**|
|10191|**Knowledge Federated Article Incident**|
|10192|**Search provider**|
|10193|**Knowledge Article Image**|
|10194|**Knowledge Configuration**|
|10195|**Knowledge Interaction Insight**|
|10196|**Knowledge Search Insight**|
|10197|**Favorite knowledge article**|
|10198|**Knowledge article language setting**|
|10199|**Knowledge Article Attachment**|
|10200|**Knowledge personalization**|
|10201|**Knowledge Article Template**|
|10202|**Knowledge search personal filter config**|
|10203|**Knowledge search filter**|
|10205|**SupportUserTable**|
|10206|**FxExpression**|
|10207|**PowerfxRule**|
|10208|**Planner Business Scenario**|
|10209|**Planner Sync Action**|
|10210|**Ms Graph Resource To Subscription**|
|10211|**Virtual Entity  Metadata**|
|10212|**Background Operation**|
|10213|**MobileOfflineProfileExtension**|
|10214|**MobileOfflineProfileItemFilter**|
|10215|**TeamMobileOfflineProfileMembership**|
|10216|**UserMobileOfflineProfileMembership**|
|10217|**OrganizationDataSyncSubscription**|
|10218|**OrganizationDataSyncSubscriptionEntity**|
|10219|**OrganizationDataSyncSubscriptionFnoTable**|
|10220|**OrganizationDataSyncFnoState**|
|10221|**OrganizationDataSyncState**|
|10222|**ArchiveCleanupInfo**|
|10223|**ArchiveCleanupOperation**|
|10224|**BulkArchiveConfig**|
|10225|**BulkArchiveFailureDetail**|
|10226|**BulkArchiveOperation**|
|10227|**BulkArchiveOperationDetail**|
|10228|**EnableArchivalRequest**|
|10229|**MetadataForArchival**|
|10230|**ReconciliationEntityInfo**|
|10231|**ReconciliationEntityStepInfo**|
|10232|**ReconciliationInfo**|
|10233|**RetentionCleanupInfo**|
|10234|**RetentionCleanupOperation**|
|10235|**RetentionConfig**|
|10236|**RetentionFailureDetail**|
|10237|**RetentionOperation**|
|10238|**RetentionOperationDetail**|
|10239|**Notification**|
|10240|**User Rating**|
|10241|**Mobile App**|
|10242|**Insights Store Data Source**|
|10243|**Insights Store Virtual Entity**|
|10244|**RoleEditorLayout**|
|10245|**Deleted Record Reference**|
|10246|**Restore Deleted Records Configuration**|
|10247|**App Action**|
|10248|**App Action Migration**|
|10249|**App Action Rule**|
|10252|**Card**|
|10253|**Card State Item**|
|10256|**Entity link chat configuration**|
|10257|**Rich Text Attachment**|
|10258|**Custom Control Extended Setting**|
|10259|**Timeline Pin**|
|10260|**Virtual Connector Data Source**|
|10261|**Virtual Table Column Candidate**|
|10263|**PM Analysis History**|
|10264|**PM Business Rule Automation Config**|
|10265|**PM Calendar**|
|10266|**PM Calendar Version**|
|10267|**PM Inferred Task**|
|10268|**PM Process Extended Metadata Version**|
|10269|**PM Process Template**|
|10270|**PM Process User Settings**|
|10271|**PM Process Version**|
|10272|**PM Recording**|
|10273|**PM Simulation**|
|10274|**PM Template**|
|10275|**PM View**|
|10276|**Analysis Component**|
|10277|**Analysis Job**|
|10278|**Analysis Override**|
|10279|**Analysis Result**|
|10280|**Analysis Result Detail**|
|10281|**Solution Health Rule**|
|10282|**Solution Health Rule Argument**|
|10283|**Solution Health Rule Set**|
|10284|**Power BI Dataset**|
|10285|**powerbidatasetapdx**|
|10286|**Power BI Mashup Parameter**|
|10287|**Power BI Report**|
|10288|**powerbireportapdx**|
|10289|**File Upload**|
|10290|**MainFewShot**|
|10291|**MakerFewShot**|
|10292|**SearchAttributeSettings**|
|10293|**SearchCustomAnalyzer**|
|10294|**SearchRelationshipSettings**|
|10295|**SearchResultsCache**|
|10296|**Search Telemetry**|
|10297|**ViewAsExampleQuestion**|
|10298|**CopilotExampleQuestion**|
|10299|**CopilotGlossaryTerm**|
|10300|**CopilotSynonyms**|
|10301|**Site Component**|
|10302|**Site**|
|10303|**Site Language**|
|10304|**Power Pages Site Published**|
|10307|**External Identity**|
|10308|**Invitation**|
|10309|**Invite Redemption**|
|10310|**Portal Comment**|
|10311|**Setting**|
|10312|**Multistep Form Session**|
|10316|**Ad Placement**|
|10317|**Column Permission**|
|10318|**Column Permission Profile**|
|10319|**Content Snippet**|
|10320|**Basic Form**|
|10321|**Basic Form Metadata**|
|10322|**List**|
|10323|**Table Permission**|
|10324|**Page Template**|
|10325|**Poll Placement**|
|10326|**Power Pages Core Entity DS**|
|10327|**Publishing State**|
|10328|**Publishing State Transition Rule**|
|10329|**Redirect**|
|10330|**Shortcut**|
|10331|**Site Marker**|
|10332|**Site Setting**|
|10333|**Web File**|
|10334|**Multistep Form**|
|10335|**Multistep Form Metadata**|
|10336|**Form Step**|
|10337|**Web Link**|
|10338|**Web Link Set**|
|10339|**Web Page**|
|10340|**Web Page Access Control Rule**|
|10341|**Web Role**|
|10342|**Website**|
|10343|**Website Access**|
|10344|**Website Language**|
|10345|**Web Template**|
|10352|**Power Pages Scan Report**|
|10353|**Power Pages Log**|
|10358|**Catalog Submission Files**|
|10359|**Package Submission Store**|
|10360|**List Operation**|
|10361|**Marketing Form Display Attributes**|
|10362|**Database Version**|
|10363|**Upgrade Run**|
|10364|**Upgrade Step**|
|10365|**Upgrade Version**|
|10366|**Activity monitor**|
|10367|**Originating Queue Mapping**|
|10368|**Unified Routing Setup Tracker**|
|10369|**Available Times**|
|10370|**Available Times Data Source**|
|10371|**resource group data source**|
|10372|**Virtual Resource Group Resource**|
|10373|**Migration tracker**|
|10374|**BgJobLedger**|
|10375|**Intent**|
|10376|**JobsState**|
|10377|**Asset Category Template Association**|
|10378|**Asset Template Association**|
|10379|**Customer Asset**|
|10382|**Customer Asset Attachment**|
|10383|**Customer Asset Category**|
|10384|**Functional Location**|
|10385|**Functional Location Type**|
|10386|**Location Template Association**|
|10387|**Functional Location Type Template Association**|
|10388|**Property Definition**|
|10389|**Property Asset Association**|
|10390|**Property Location Association**|
|10391|**Property Log**|
|10392|**Property Template Association**|
|10393|**Template For Properties**|
|10394|**Warranty**|
|10401|**IoT Alert**|
|10402|**IoT Device**|
|10403|**IoT Device Category**|
|10404|**IoT Device Command**|
|10405|**IoT Device Command Definition**|
|10406|**IoT Device Data History**|
|10407|**IoT Device Property**|
|10408|**IoT Device Registration History**|
|10409|**IoT Device Visualization Configuration**|
|10410|**IoT Field Mapping**|
|10411|**IoT Property Definition**|
|10412|**IoT Provider**|
|10413|**IoT Provider Instance**|
|10414|**IoT Settings**|
|10417|**IoT Alert to Case Process**|
|10419|**Playbook Callable Context**|
|10420|**Playbook activity**|
|10421|**Playbook activity attribute**|
|10422|**[DEPRECATED] Playbook category**|
|10423|**Playbook**|
|10424|**[DEPRECATED] Playbook template**|
|10426|**admin_settings_entity**|
|10427|**Collab Space Team Association**|
|10428|**CRM Connection**|
|10429|**Tagged Record**|
|10430|**Copilot for Sales customer list**|
|10431|**msdyn_vivaentitysetting**|
|10432|**msdyn_vivaorgextensioncred**|
|10433|**msdyn_vivaorgsetting**|
|10434|**msdyn_vivausersetting**|
|10435|**Sales Copilot Insight**|
|10436|**Org level settings for Sales Copilot apps**|
|10437|**Sales Copilot User Setting**|
|10438|**App profile**|
|10439|**Application Extension**|
|10440|**Application Tab Template**|
|10441|**App profile role mapping**|
|10442|**Notification Field**|
|10443|**Notification Template**|
|10444|**Session Template**|
|10445|**Template Parameter**|
|10451|**Channel Integration Framework v1.0 Provider**|
|10452|**Notification Field (Deprecated)**|
|10453|**Notification Template (Deprecated)**|
|10454|**App Parameter Definition (Deprecated)**|
|10455|**Session Templates (Deprecated)**|
|10456|**Application Tab Template (Deprecated)**|
|10457|**Parameter (Deprecated)**|
|10458|**Template Tag (Deprecated)**|
|10459|**Application Type (Deprecated)**|
|10468|**Channel Integration Framework v2.0 Provider**|
|10470|**Conversation Data (Deprecated)**|
|10471|**KPI Event Data**|
|10472|**KPI Event Definition**|
|10473|**Session Data (Deprecated)**|
|10474|**Session Participant Data (Deprecated)**|
|10475|**Channel Definition**|
|10476|**Channel Definition Consent**|
|10477|**Channel Definition Locale**|
|10478|**Channel Instance**|
|10479|**Channel Instance Account**|
|10480|**Channel Message Attachment**|
|10481|**Channel Message Context Part**|
|10482|**Channel Message Part**|
|10483|**Consuming Application**|
|10484|**msdyn_DefExtendedChannelInstance**|
|10485|**msdyn_DefExtendedChannelInstanceAccount**|
|10486|**Productivity pane configuration**|
|10487|**Pane tab configuration**|
|10488|**Pane tool configuration**|
|10490|**Agent script**|
|10491|**Agent script step**|
|10493|**Action Input Parameter**|
|10494|**Action Output Parameter**|
|10495|**Macro Action Template**|
|10496|**Macro Solution Configuration**|
|10497|**Macro Connector**|
|10498|**Macro Run History**|
|10499|**Parameter definition**|
|10502|**Adaptive Card Configuration**|
|10503|**Smartassist configuration**|
|10505|**Read Tracker**|
|10506|**Read tracking enabled information**|
|10507|**Microsoft Teams Graph resource Entity**|
|10508|**msdyn_msteamssetting**|
|10509|**msdyn_msteamssettingsv2**|
|10510|**Microsoft Teams Collaboration entity**|
|10511|**Teams Dialer Admin settings**|
|10512|**Teams Contact Suggestion by AI**|
|10513|**Contact suggestion rule**|
|10514|**Contact suggestion ruleset**|
|10515|**Microsoft Teams chat association entity**|
|10516|**Microsoft Teams chat suggestion**|
|10517|**Microsoft Orgchart node entity**|
|10518|**Forecast Manual Adjustment History**|
|10519|**Distributed Lock**|
|10520|**Entity Delta Change**|
|10521|**File Upload Status Tracker**|
|10522|**Forecast**|
|10523|**Forecast Configuration**|
|10524|**Forecast definition**|
|10525|**Forecasting Cache**|
|10526|**Forecast Insights**|
|10527|**Forecast**|
|10528|**Forecast Prediction Data**|
|10529|**Forecast Prediction Status**|
|10530|**Forecast recurrence**|
|10531|**Recompute Tracker**|
|10532|**Forecast Recurrence**|
|10533|**ShareAs Configuration**|
|10534|**Customer email communication**|
|10535|**GDPRData**|
|10536|**ODOSFeatureMetadata**|
|10537|**ODOSMetadata**|
|10538|**Recurring Sales Action**|
|10539|**Recurring Sales Action V2**|
|10540|**msdyn_relationshipinsightsunifiedconfig**|
|10541|**siconfig**|
|10542|**SI Key Value Config**|
|10543|**Usage Metric**|
|10544|**Action Card Regarding**|
|10545|**Action Card Role Setting**|
|10546|**EntityRankingRule**|
|10547|**flowcardtype**|
|10548|**salesinsightssettings**|
|10549|**Action Card Usage**|
|10550|**Action Card Usage Aggregation**|
|10551|**Auto Capture Rule**|
|10552|**Auto Capture Settings**|
|10553|**UntrackedAppointment**|
|10554|**Suggested Activity**|
|10555|**Suggested Activity Data Source**|
|10556|**Suggested Contact**|
|10557|**Suggested Contacts Data Source**|
|10558|**Notes analysis Config**|
|10559|**icebreakersconfig**|
|10560|**dealmanageraccess**|
|10561|**Deal manager settings**|
|10562|**Account KPI Item**|
|10563|**Activity Analysis CleanUp State**|
|10564|**Relationship Analytics Config**|
|10565|**Contact KPI Item**|
|10566|**Daily Kpis for account**|
|10567|**Daily kpis for contact**|
|10568|**Daily kpis for lead**|
|10569|**Daily kpis for Opportunity**|
|10570|**Lead KPI Item**|
|10571|**Most Contacted**|
|10572|**Most Contacted By**|
|10573|**Opportunity KPI Item**|
|10574|**Relationship Analytics Metadata**|
|10575|**Similar entities feature importance**|
|10576|**wkwcolleaguesforcompany**|
|10577|**wkwcolleaguesforcontact**|
|10578|**wkwconfig**|
|10579|**Attribute Influence Statistics**|
|10580|**Prediction Computation Operation**|
|10581|**Prediction Model Status**|
|10582|**Prediction Scheduled Operation**|
|10583|**Predictive Model Score**|
|10584|**Predictive Score**|
|10585|**Predictive Scoring Sync Status**|
|10586|**Real Time Scoring**|
|10587|**Real Time Scoring Operation**|
|10588|**Submodel Definition**|
|10589|**Time spent in BPF**|
|10590|**Training Result**|
|10591|**OpportunityModelConfig**|
|10592|**LeadModelConfig**|
|10593|**ModelPreviewStatus**|
|10594|**Profile Album**|
|10595|**Post Configuration**|
|10596|**Post Rule Configuration**|
|10597|**Wall View**|
|10598|**Filter**|
|10599|**Customer Voice alert**|
|10600|**Customer Voice alert rule**|
|10601|**Customer Voice survey email template**|
|10602|**Customer Voice file response**|
|10603|**Customer Voice localized survey email template**|
|10604|**Customer Voice project**|
|10605|**Customer Voice survey question**|
|10606|**Customer Voice survey question response**|
|10607|**Customer Voice satisfaction metric**|
|10608|**Customer Voice survey**|
|10609|**Customer Voice survey invite**|
|10610|**Customer Voice survey reminder**|
|10611|**Customer Voice survey response**|
|10612|**Customer Voice unsubscribed recipient**|
|10613|**Customer Service Key Value Configuration**|
|10614|**AddToCalendar style**|
|10615|**basestyle**|
|10616|**Button style**|
|10617|**Code style**|
|10618|**Column style**|
|10619|**Content Block**|
|10620|**Divider style**|
|10621|**General styles**|
|10622|**imagestyle**|
|10623|**Layout Style**|
|10624|**QR code style**|
|10625|**Text style**|
|10626|**Video style**|
|10627|**App state**|
|10628|**CSAdminConfig**|
|10629|**Custom API Ruleset Configuration**|
|10630|**Decision contract**|
|10631|**Decision rule set**|
|10632|**Rulesetentitymapping**|
|10633|**Routing diagnostic item**|
|10634|**Routing diagnostic**|
|10635|**Inbox card configuration**|
|10636|**Inbox Configuration**|
|10637|**Inbox Entity Configuration**|
|10638|**App Profile Copilot Configuration**|
|10639|**Swarm**|
|10640|**Swarm participant**|
|10641|**Swarm participant rule**|
|10642|**Swarm role**|
|10643|**Swarm skill**|
|10644|**Swarm template**|
|10645|**Autonomous case creation and enrichment rules**|
|10646|**Entity Attachment**|
|10647|**Survey setting**|
|10648|**Master Entity Routing Configuration**|
|10649|**Routing Rule Set Setting**|
|10650|**Assignment Configuration**|
|10651|**Assignment Configuration Step**|
|10652|**Capacity Profile**|
|10653|**Overflow Action Config**|
|10654|**Preferred Agent**|
|10655|**Preferred Agent Customer Identity**|
|10656|**Preferred Agent Routed Entity**|
|10657|**Routing configuration**|
|10658|**Routing configuration step**|
|10659|**Bot Channel Registration**|
|10660|**Channel Configuration**|
|10661|**Channel State Configuration**|
|10662|**Provisioning State**|
|10663|**AdminAppState**|
|10664|**Agent Status history**|
|10665|**Power BI Configuration**|
|10666|**Authentication Settings**|
|10667|**Auth Settings Entry**|
|10668|**Quick reply**|
|10669|**Entity Routing Context**|
|10670|**Channel Capability**|
|10671|**Conversation Action**|
|10672|**Conversation Action Locale**|
|10673|**Conversation Message Block**|
|10674|**DeletedConversation**|
|10675|**Deprecated Workstream Entity Configuration**|
|10676|**Entity**|
|10677|**Ongoing conversation (Deprecated)**|
|10678|**Live work item event**|
|10679|**Work Stream**|
|10680|**Masking Rule**|
|10681|**Auto block rule**|
|10682|**Bot Channel Registration Secret**|
|10683|**Omnichannel channel api conversation privilege**|
|10684|**Omnichannel channel api message privilege**|
|10685|**Channel api method mapping**|
|10686|**External context**|
|10687|**Flagged spam**|
|10688|**Language**|
|10689|**Conversation**|
|10692|**Context item value**|
|10693|**Live Work Item Participant (Deprecated)**|
|10694|**Conversation Sentiment**|
|10695|**Context variable**|
|10696|**Localization**|
|10697|**OC Payment Profile**|
|10698|**Recording**|
|10699|**Omnichannel Request**|
|10700|**Rich message**|
|10701|**Rich message map**|
|10702|**Rule Item**|
|10703|**Sentiment daily topic**|
|10704|**Sentiment daily topic keyword**|
|10705|**Sentiment daily topic trending**|
|10706|**Session**|
|10707|**Session Participant Event**|
|10708|**Session Sentiment**|
|10709|**Message**|
|10710|**Tag**|
|10711|**Geo Location Provider**|
|10712|**Omnichannel Configuration**|
|10713|**Omnichannel Personalization**|
|10714|**Omnichannel Queue (Deprecated)**|
|10715|**Omnichannel Sync Config**|
|10716|**Operating Hour**|
|10717|**Personal quick reply**|
|10718|**Personal sound setting**|
|10719|**Persona Security Role Mapping**|
|10720|**Presence**|
|10721|**Provider**|
|10722|**RoutingRequest**|
|10723|**Search Configuration**|
|10724|**Sentiment analysis**|
|10725|**Session event**|
|10726|**Session participant**|
|10727|**Audio File**|
|10728|**Sound notification setting**|
|10729|**Transcript**|
|10730|**UR notification template**|
|10731|**UR Notification Template Mapping**|
|10732|**User settings**|
|10733|**Self service**|
|10740|**Agent capacity update history**|
|10741|**Bookable Resource Capacity Profile**|
|10742|**Work stream capacity profile**|
|10743|**Conversation Capacity profile**|
|10744|**Agent Capacity Profile Unit**|
|10745|**Agent Channel State**|
|10746|**Agent Status**|
|10747|**Conversation Characteristic**|
|10748|**Session Characteristic**|
|10749|**Skill Attachment Rule**|
|10750|**Attach Skill**|
|10751|**Model training details**|
|10752|**Training data import configuration**|
|10753|**Characteristic mapping**|
|10754|**Training record**|
|10755|**Skill finder model**|
|10756|**Effort estimate**|
|10757|**Effort estimation model**|
|10758|**Effort model training details**|
|10759|**ConversationInsight**|
|10760|**Active ICD Extension**|
|10761|**Entity-Workstream Map**|
|10762|**ICD Extension**|
|10763|**Lock Status**|
|10764|**Omnichannel agent assignment custom api privilege**|
|10765|**Conversation Action Item**|
|10766|**Conversation Aggregated Insights**|
|10767|**Comment**|
|10768|**Conversation Participant Insights**|
|10769|**Conversation Participant Sentiment**|
|10770|**Conversation Question**|
|10771|**Conversation Segment Sentiment**|
|10772|**Conversation Sentiment**|
|10773|**Conversation Signal**|
|10774|**Conversation Subject**|
|10775|**Conversation Summary Suggestion**|
|10776|**Conversation System Tag**|
|10777|**Conversation Tag**|
|10778|**Recording**|
|10779|**SCI Conversation**|
|10780|**Custom Email Highlight**|
|10781|**Custom Highlight**|
|10782|**Custom Publisher**|
|10783|**EnvironmentSettings**|
|10784|**UserSettings**|
|10785|**CatalogEventStatusConfiguration**|
|10786|**Configuration**|
|10787|**Trigger**|
|10788|**Triggers To Sdk Message Processing Steps**|
|10789|**EventParameterMetadata**|
|10790|**TrackingContext**|
|10791|**Marketing feature configuration**|
|10792|**msdynmkt_experimentv2**|
|10793|**ACS channel instance**|
|10794|**ACS channel instance account**|
|10795|**Infobip channel instance**|
|10796|**Infobip channel instance account**|
|10797|**Link mobility channel instance**|
|10798|**Link mobility channel instance account**|
|10799|**MockSmsProvider channel instance**|
|10800|**MockSmsProvider channel instance account**|
|10801|**TeleSign channel instance**|
|10802|**TeleSign channel instance account**|
|10803|**Twilio channel instance**|
|10804|**Twilio channel instance account**|
|10805|**Vibes channel instance**|
|10806|**Vibes channel instance account**|
|10807|**Predefined Placeholder**|
|10808|**Metadata Entity Relationship**|
|10809|**Metadata Item**|
|10810|**Metadata Store State**|
|10811|**DigitalSellingActiveTask**|
|10812|**DigitalSellingCompletedTask**|
|10813|**Sales Tag**|
|10814|**Sequence**|
|10815|**Sequence Stat**|
|10816|**Sequence Target**|
|10817|**Sequence Target Step**|
|10818|**Sequence Template**|
|10820|**sabackupdiagnostic**|
|10821|**SABatchRunInstance**|
|10822|**salesroutingdiagnostic**|
|10823|**SARunInstance**|
|10824|**Segment**|
|10825|**segmentsetting**|
|10826|**Segment property**|
|10827|**SegmentsUtil**|
|10828|**Assignment Rule**|
|10829|**Seller attribute**|
|10830|**Seller attribute value**|
|10831|**Assignment Map**|
|10832|**Sales Assignment Setting**|
|10833|**Sales routing run**|
|10835|**Extended User Setting**|
|10836|**Sales acceleration insights**|
|10837|**Sales Acceleration settings**|
|10838|**Insight**|
|10839|**Work List Suggestion**|
|10840|**Work list suggestion source**|
|10841|**Work List View Configuration**|
|10842|**Work Queue Record**|
|10843|**Work Queue Record State**|
|10844|**Work list user setting**|
|10845|**WQDataSource**|
|10846|**Suggestion Assignment Rule**|
|10847|**Suggestion Principal Object Access**|
|10848|**Suggestion Seller Priority**|
|10849|**Data Hygiene Setting Info**|
|10850|**Duplicate Detection Plugin Run**|
|10851|**Duplicate Lead Mapping**|
|10852|**Lead Hygiene Setting**|
|10853|**Linked Entity Attribute Validity**|
|10854|**Sales provisioning request**|
|10855|**SalesOmnichannel Message**|
|10856|**Text message template**|
|10857|**Data Analytics Admin Settings (Deprecated)**|
|10858|**Data Analytics Report**|
|10859|**Insights**|
|10860|**Sales acceleration reports**|
|10862|**Bot Session**|
|10863|**Agent Copilot Setting**|
|10864|**Copilot Summarization Setting**|
|10865|**Case Enrichment**|
|10866|**Case Suggestion**|
|10867|**Case Suggestion Request Payload**|
|10868|**Case Suggestions Data Souce**|
|10869|**Agent Preference For Copilot**|
|10870|**Copilot Interaction**|
|10871|**Copilot Interaction Data**|
|10872|**Copilot Transcript**|
|10873|**Copilot Transcript Data**|
|10874|**KB Enrichment**|
|10875|**Knowledge Article Suggestion**|
|10876|**Knowledge Article Suggestion Data Source**|
|10877|**Service Copilot Plugin**|
|10878|**Service Copilot Plugin Role**|
|10879|**Suggestion Interaction**|
|10880|**Suggestion request payload**|
|10881|**Suggestions Model Summary**|
|10882|**Suggestions Setting**|
|10883|**Data Analytics User Customized Report**|
|10884|**Data Analytics Dataset**|
|10885|**Data Analytics Workspace**|
|10886|**Report Bookmark**|
|10887|**Agent Resource Forecasting**|
|10888|**[Deprecated] Dynamics Customer Service Analytics**|
|10889|**Case Topic**|
|10890|**Case Topic Setting**|
|10891|**Case Topic Summary**|
|10892|**Case topic Incident mapping**|
|10893|**Customer Service historical analytics**|
|10894|**Forecast**|
|10895|**Knowledge analytics**|
|10896|**Forecast Summary and Setting**|
|10897|**Keywords Description Suggestion Setting**|
|10898|**Conversation Summary Interaction**|
|10899|**Conversation Summary Setting**|
|10900|**Conversation Topic**|
|10901|**Conversation Topic Setting**|
|10902|**Conversation Topic Summary**|
|10903|**Conversation topic Conversation mapping**|
|10904|**Omnichannel historical analytics**|
|10905|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|10906|**Omnichannel Realtime analytics**|
|18085|**Event Expander Breadcrumb**|

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
|Description|**Status of the Playbook Callable Context**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_callablecontext_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Playbook Callable Context**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_callablecontext_statuscode`|

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

- [business_unit_msdyn_callablecontext](#BKMK_business_unit_msdyn_callablecontext)
- [lk_msdyn_callablecontext_createdby](#BKMK_lk_msdyn_callablecontext_createdby)
- [lk_msdyn_callablecontext_createdonbehalfby](#BKMK_lk_msdyn_callablecontext_createdonbehalfby)
- [lk_msdyn_callablecontext_modifiedby](#BKMK_lk_msdyn_callablecontext_modifiedby)
- [lk_msdyn_callablecontext_modifiedonbehalfby](#BKMK_lk_msdyn_callablecontext_modifiedonbehalfby)
- [owner_msdyn_callablecontext](#BKMK_owner_msdyn_callablecontext)
- [team_msdyn_callablecontext](#BKMK_team_msdyn_callablecontext)
- [user_msdyn_callablecontext](#BKMK_user_msdyn_callablecontext)

### <a name="BKMK_business_unit_msdyn_callablecontext"></a> business_unit_msdyn_callablecontext

One-To-Many Relationship: [businessunit business_unit_msdyn_callablecontext](businessunit.md#BKMK_business_unit_msdyn_callablecontext)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_callablecontext_createdby"></a> lk_msdyn_callablecontext_createdby

One-To-Many Relationship: [systemuser lk_msdyn_callablecontext_createdby](systemuser.md#BKMK_lk_msdyn_callablecontext_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_callablecontext_createdonbehalfby"></a> lk_msdyn_callablecontext_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_callablecontext_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_callablecontext_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_callablecontext_modifiedby"></a> lk_msdyn_callablecontext_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_callablecontext_modifiedby](systemuser.md#BKMK_lk_msdyn_callablecontext_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_callablecontext_modifiedonbehalfby"></a> lk_msdyn_callablecontext_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_callablecontext_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_callablecontext_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_callablecontext"></a> owner_msdyn_callablecontext

One-To-Many Relationship: [owner owner_msdyn_callablecontext](owner.md#BKMK_owner_msdyn_callablecontext)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_callablecontext"></a> team_msdyn_callablecontext

One-To-Many Relationship: [team team_msdyn_callablecontext](team.md#BKMK_team_msdyn_callablecontext)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_callablecontext"></a> user_msdyn_callablecontext

One-To-Many Relationship: [systemuser user_msdyn_callablecontext](systemuser.md#BKMK_user_msdyn_callablecontext)

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

- [msdyn_callablecontext_AsyncOperations](#BKMK_msdyn_callablecontext_AsyncOperations)
- [msdyn_callablecontext_BulkDeleteFailures](#BKMK_msdyn_callablecontext_BulkDeleteFailures)
- [msdyn_callablecontext_DuplicateBaseRecord](#BKMK_msdyn_callablecontext_DuplicateBaseRecord)
- [msdyn_callablecontext_DuplicateMatchingRecord](#BKMK_msdyn_callablecontext_DuplicateMatchingRecord)
- [msdyn_callablecontext_MailboxTrackingFolders](#BKMK_msdyn_callablecontext_MailboxTrackingFolders)
- [msdyn_callablecontext_PrincipalObjectAttributeAccesses](#BKMK_msdyn_callablecontext_PrincipalObjectAttributeAccesses)
- [msdyn_callablecontext_ProcessSession](#BKMK_msdyn_callablecontext_ProcessSession)
- [msdyn_callablecontext_SyncErrors](#BKMK_msdyn_callablecontext_SyncErrors)

### <a name="BKMK_msdyn_callablecontext_AsyncOperations"></a> msdyn_callablecontext_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_callablecontext_AsyncOperations](asyncoperation.md#BKMK_msdyn_callablecontext_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_callablecontext_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_callablecontext_BulkDeleteFailures"></a> msdyn_callablecontext_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_callablecontext_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_callablecontext_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_callablecontext_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_callablecontext_DuplicateBaseRecord"></a> msdyn_callablecontext_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_callablecontext_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_callablecontext_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_callablecontext_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_callablecontext_DuplicateMatchingRecord"></a> msdyn_callablecontext_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_callablecontext_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_callablecontext_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_callablecontext_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_callablecontext_MailboxTrackingFolders"></a> msdyn_callablecontext_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_callablecontext_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_callablecontext_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_callablecontext_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_callablecontext_PrincipalObjectAttributeAccesses"></a> msdyn_callablecontext_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_callablecontext_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_callablecontext_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_callablecontext_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_callablecontext_ProcessSession"></a> msdyn_callablecontext_ProcessSession

Many-To-One Relationship: [processsession msdyn_callablecontext_ProcessSession](processsession.md#BKMK_msdyn_callablecontext_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_callablecontext_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_callablecontext_SyncErrors"></a> msdyn_callablecontext_SyncErrors

Many-To-One Relationship: [syncerror msdyn_callablecontext_SyncErrors](syncerror.md#BKMK_msdyn_callablecontext_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_callablecontext_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_callablecontext_msdyn_playbooktemplate"></a> msdyn_callablecontext_msdyn_playbooktemplate

See [msdyn_playbooktemplate msdyn_callablecontext_msdyn_playbooktemplate Many-To-Many Relationship](msdyn_playbooktemplate.md#BKMK_msdyn_callablecontext_msdyn_playbooktemplate)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_callablecontext_msdyn_playbooktemplate`|
|IsCustomizable|False|
|SchemaName|`msdyn_callablecontext_msdyn_playbooktemplate`|
|IntersectAttribute|`msdyn_callablecontextid`|
|NavigationPropertyName|`msdyn_callablecontext_msdyn_playbooktemplate`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

