---
title: "Playbook activity (msdyn_playbookactivity) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Playbook activity (msdyn_playbookactivity) table/entity with Microsoft Dynamics 365."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Playbook activity (msdyn_playbookactivity) table/entity reference

Stores the details of the activities to be created when a playbook is launched.

## Messages

The following table lists the messages for the Playbook activity (msdyn_playbookactivity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_playbookactivities(*msdyn_playbookactivityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_playbookactivities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_playbookactivities(*msdyn_playbookactivityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_playbookactivities(*msdyn_playbookactivityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_playbookactivities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_playbookactivities(*msdyn_playbookactivityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_playbookactivities(*msdyn_playbookactivityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_playbookactivities(*msdyn_playbookactivityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Playbook activity (msdyn_playbookactivity) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Playbook activity (msdyn_playbookactivity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Playbook activity** |
| **DisplayCollectionName** | **Playbook activities** |
| **SchemaName** | `msdyn_playbookactivity` |
| **CollectionSchemaName** | `msdyn_playbookactivities` |
| **EntitySetName** | `msdyn_playbookactivities`|
| **LogicalName** | `msdyn_playbookactivity` |
| **LogicalCollectionName** | `msdyn_playbookactivities` |
| **PrimaryIdAttribute** | `msdyn_playbookactivityid` |
| **PrimaryNameAttribute** |`msdyn_subject` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activityLogicalName](#BKMK_msdyn_activityLogicalName)
- [msdyn_activityType](#BKMK_msdyn_activityType)
- [msdyn_playbookactivity_json](#BKMK_msdyn_playbookactivity_json)
- [msdyn_playbookactivityId](#BKMK_msdyn_playbookactivityId)
- [msdyn_playbooktemplateid](#BKMK_msdyn_playbooktemplateid)
- [msdyn_subject](#BKMK_msdyn_subject)
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

### <a name="BKMK_msdyn_activityLogicalName"></a> msdyn_activityLogicalName

|Property|Value|
|---|---|
|Description|**The logical name of the entity.**|
|DisplayName|**Activity Logical name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activityLogicalName`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

### <a name="BKMK_msdyn_activityType"></a> msdyn_activityType

|Property|Value|
|---|---|
|Description|**Select the type of activity to be associated with the playbook.**|
|DisplayName|**Activity type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activityType`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_playbookactivity_optionset`|

#### msdyn_activityType Choices/Options

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
|75|**Privilege Checker Run**|
|76|**Privilege Checker Log**|
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
|9820|**Attribute Masking Rule**|
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
|10036|**Shared Workspace Pool**|
|10037|**Data Lake Folder**|
|10038|**Data Lake Folder Permission**|
|10039|**Data Lake Workspace**|
|10040|**Data Lake Workspace Permission**|
|10041|**Data Processing configuration**|
|10042|**Exported Excel**|
|10043|**RetainedData Excel**|
|10044|**Synapse Database**|
|10045|**Synapse Link External Table State**|
|10046|**Synapse Link Profile**|
|10047|**Synapse Link Profile Entity**|
|10048|**Synapse Link Profile Entity State**|
|10049|**Synapse Link Schedule**|
|10050|**Component Version**|
|10051|**Component Version Data Source**|
|10052|**Component Version (Internal)**|
|10053|**DataflowRefreshHistory**|
|10054|**EntityRefreshHistory**|
|10055|**Shared Link Setting**|
|10056|**DelegatedAuthorization**|
|10057|**CascadeGrantRevokeAccessRecordsTracker**|
|10058|**CascadeGrantRevokeAccessVersionTracker**|
|10059|**RevokeInheritedAccessRecordsTracker**|
|10060|**TdsMetadata**|
|10061|**Model-Driven App Element**|
|10062|**Model-Driven App Component Node's Edge**|
|10063|**Model-Driven App Component Node**|
|10064|**Model-Driven App Setting**|
|10065|**Model-Driven App User Setting**|
|10066|**Organization Setting**|
|10067|**Setting Definition**|
|10068|**CanvasApp Extended Metadata**|
|10069|**Service Plan Mapping**|
|10070|**Service Plan Custom Control**|
|10072|**ApplicationUser**|
|10075|**OData v4 Data Source**|
|10076|**Workflow Binary**|
|10077|**Credential**|
|10078|**Desktop Flow Module**|
|10079|**Flow Capacity Assignment**|
|10080|**Flow Event**|
|10081|**Flow Machine**|
|10082|**Flow Machine Group**|
|10083|**Flow Machine Image**|
|10084|**Flow Machine Image Version**|
|10085|**Flow Machine Network**|
|10086|**ProcessStageParameter**|
|10087|**Work Queue**|
|10088|**Work Queue Item**|
|10089|**Desktop Flow Binary**|
|10090|**Flow Run**|
|10091|**Connection Reference**|
|10092|**DVFileSearch**|
|10093|**DVFileSearchAttribute**|
|10094|**DVFileSearchEntity**|
|10095|**DVTableSearch**|
|10096|**DVTableSearchAttribute**|
|10097|**DVTableSearchEntity**|
|10098|**AIPlugin**|
|10099|**AIPluginExternalSchema**|
|10100|**AIPluginExternalSchemaProperty**|
|10101|**AIPluginInstance**|
|10102|**AIPluginOperation**|
|10103|**AIPluginOperationParameter**|
|10104|**AIPluginUserSetting**|
|10105|**Help Page**|
|10106|**Tour**|
|10107|**BotContent**|
|10108|**ConversationTranscript**|
|10109|**Chatbot**|
|10110|**Copilot component**|
|10118|**Comment**|
|10119|**PDF Setting**|
|10120|**Activity File Attachment**|
|10121|**Teams chat**|
|10122|**Service Configuration**|
|10123|**SLA KPI**|
|10124|**Integrated search provider**|
|10125|**Knowledge Management Setting**|
|10126|**Knowledge Federated Article**|
|10127|**Knowledge Federated Article Incident**|
|10128|**Search provider**|
|10129|**Knowledge Article Image**|
|10130|**Knowledge Configuration**|
|10131|**Knowledge Interaction Insight**|
|10132|**Knowledge Search Insight**|
|10133|**Favorite knowledge article**|
|10134|**Knowledge article language setting**|
|10135|**Knowledge Article Attachment**|
|10136|**Knowledge personalization**|
|10137|**Knowledge Article Template**|
|10138|**Knowledge search personal filter config**|
|10139|**Knowledge search filter**|
|10141|**SupportUserTable**|
|10142|**FxExpression**|
|10143|**PowerfxRule**|
|10144|**Ms Graph Resource To Subscription**|
|10145|**Virtual Entity  Metadata**|
|10146|**Background Operation**|
|10147|**MobileOfflineProfileExtension**|
|10148|**MobileOfflineProfileItemFilter**|
|10149|**TeamMobileOfflineProfileMembership**|
|10150|**UserMobileOfflineProfileMembership**|
|10151|**OrganizationDataSyncSubscription**|
|10152|**OrganizationDataSyncSubscriptionEntity**|
|10153|**OrganizationDataSyncSubscriptionFnoTable**|
|10154|**OrganizationDataSyncFnoState**|
|10155|**OrganizationDataSyncState**|
|10156|**ArchiveCleanupInfo**|
|10157|**ArchiveCleanupOperation**|
|10158|**BulkArchiveConfig**|
|10159|**BulkArchiveFailureDetail**|
|10160|**BulkArchiveOperation**|
|10161|**BulkArchiveOperationDetail**|
|10162|**EnableArchivalRequest**|
|10163|**MetadataForArchival**|
|10164|**ReconciliationEntityInfo**|
|10165|**ReconciliationEntityStepInfo**|
|10166|**ReconciliationInfo**|
|10167|**RetentionCleanupInfo**|
|10168|**RetentionCleanupOperation**|
|10169|**RetentionConfig**|
|10170|**RetentionFailureDetail**|
|10171|**RetentionOperation**|
|10172|**RetentionOperationDetail**|
|10173|**App Insights Metadata**|
|10174|**Dataflow Connection Reference**|
|10175|**Schedule**|
|10176|**Dataflow Template**|
|10177|**Dataflow DatalakeFolder**|
|10178|**Data Movement Service Request**|
|10179|**Data Movement Service Request Status**|
|10180|**DMS Sync Request**|
|10181|**DMS Sync Status**|
|10182|**Module Run Detail**|
|10183|**Workflow Action Status**|
|10184|**Notification**|
|10185|**User Rating**|
|10186|**Mobile App**|
|10187|**Insights Store Data Source**|
|10188|**Insights Store Virtual Entity**|
|10189|**RoleEditorLayout**|
|10190|**Deleted Record Reference**|
|10191|**Restore Deleted Records Configuration**|
|10192|**App Action**|
|10193|**App Action Migration**|
|10194|**App Action Rule**|
|10197|**Card**|
|10198|**Card State Item**|
|10201|**Entity link chat configuration**|
|10202|**Rich Text Attachment**|
|10203|**Custom Control Extended Setting**|
|10204|**Timeline Pin**|
|10205|**Virtual Connector Data Source**|
|10206|**Virtual Table Column Candidate**|
|10207|**AI Event**|
|10208|**AI Builder Feedback Loop**|
|10209|**AI Form Processing Document**|
|10210|**AI Object Detection Image**|
|10211|**AI Object Detection Label**|
|10212|**AI Object Detection Bounding Box**|
|10213|**AI Object Detection Image Mapping**|
|10215|**AI Builder Dataset**|
|10216|**AI Builder Dataset File**|
|10217|**AI Builder Dataset Record**|
|10218|**AI Builder Datasets Container**|
|10219|**AI Builder File**|
|10220|**AI Builder File Attached Data**|
|10221|**PM Analysis History**|
|10222|**PM Business Rule Automation Config**|
|10223|**PM Calendar**|
|10224|**PM Calendar Version**|
|10225|**PM Inferred Task**|
|10226|**PM Process Extended Metadata Version**|
|10227|**PM Process Template**|
|10228|**PM Process User Settings**|
|10229|**PM Process Version**|
|10230|**PM Recording**|
|10231|**PM Template**|
|10232|**PM View**|
|10233|**Analysis Component**|
|10234|**Analysis Job**|
|10235|**Analysis Override**|
|10236|**Analysis Result**|
|10237|**Analysis Result Detail**|
|10238|**Solution Health Rule**|
|10239|**Solution Health Rule Argument**|
|10240|**Solution Health Rule Set**|
|10241|**Power BI Dataset**|
|10242|**powerbidatasetapdx**|
|10243|**Power BI Mashup Parameter**|
|10244|**Power BI Report**|
|10245|**powerbireportapdx**|
|10246|**File Upload**|
|10247|**MainFewShot**|
|10248|**MakerFewShot**|
|10249|**SearchAttributeSettings**|
|10250|**SearchCustomAnalyzer**|
|10251|**SearchRelationshipSettings**|
|10252|**Search Telemetry**|
|10253|**CopilotExampleQuestion**|
|10254|**Site Component**|
|10255|**Site**|
|10256|**Site Language**|
|10257|**Power Pages Site Published**|
|10260|**External Identity**|
|10261|**Invitation**|
|10262|**Invite Redemption**|
|10263|**Portal Comment**|
|10264|**Setting**|
|10265|**Multistep Form Session**|
|10269|**Ad Placement**|
|10270|**Column Permission**|
|10271|**Column Permission Profile**|
|10272|**Content Snippet**|
|10273|**Basic Form**|
|10274|**Basic Form Metadata**|
|10275|**List**|
|10276|**Table Permission**|
|10277|**Page Template**|
|10278|**Poll Placement**|
|10279|**Power Pages Core Entity DS**|
|10280|**Publishing State**|
|10281|**Publishing State Transition Rule**|
|10282|**Redirect**|
|10283|**Shortcut**|
|10284|**Site Marker**|
|10285|**Site Setting**|
|10286|**Web File**|
|10287|**Multistep Form**|
|10288|**Multistep Form Metadata**|
|10289|**Form Step**|
|10290|**Web Link**|
|10291|**Web Link Set**|
|10292|**Web Page**|
|10293|**Web Page Access Control Rule**|
|10294|**Web Role**|
|10295|**Website**|
|10296|**Website Access**|
|10297|**Website Language**|
|10298|**Web Template**|
|10308|**Catalog Submission Files**|
|10309|**Package Submission Store**|
|10310|**List Operation**|
|10311|**Marketing Form Display Attributes**|
|10312|**Database Version**|
|10313|**Upgrade Run**|
|10314|**Upgrade Step**|
|10315|**Upgrade Version**|
|10316|**Activity monitor**|
|10317|**Originating Queue Mapping**|
|10318|**Unified Routing Setup Tracker**|
|10319|**Available Times**|
|10320|**Available Times Data Source**|
|10321|**resource group data source**|
|10322|**Virtual Resource Group Resource**|
|10323|**Migration tracker**|
|10324|**BgJobLedger**|
|10325|**Intent**|
|10326|**JobsState**|
|10327|**Asset Category Template Association**|
|10328|**Asset Template Association**|
|10329|**Customer Asset**|
|10332|**Customer Asset Attachment**|
|10333|**Customer Asset Category**|
|10334|**Functional Location**|
|10335|**Property Definition**|
|10336|**Property Asset Association**|
|10337|**Property Log**|
|10338|**Property Template Association**|
|10339|**Template For Properties**|
|10343|**IoT Alert**|
|10344|**IoT Device**|
|10345|**IoT Device Category**|
|10346|**IoT Device Command**|
|10347|**IoT Device Command Definition**|
|10348|**IoT Device Data History**|
|10349|**IoT Device Property**|
|10350|**IoT Device Registration History**|
|10351|**IoT Device Visualization Configuration**|
|10352|**IoT Field Mapping**|
|10353|**IoT Property Definition**|
|10354|**IoT Provider**|
|10355|**IoT Provider Instance**|
|10356|**IoT Settings**|
|10359|**IoT Alert to Case Process**|
|10361|**Playbook Callable Context**|
|10362|**Playbook activity**|
|10363|**Playbook activity attribute**|
|10364|**[DEPRECATED] Playbook category**|
|10365|**Playbook**|
|10366|**[DEPRECATED] Playbook template**|
|10368|**admin_settings_entity**|
|10369|**Collab Space Team Association**|
|10370|**CRM Connection**|
|10371|**Tagged Record**|
|10372|**Copilot for Sales customer list**|
|10373|**msdyn_vivaentitysetting**|
|10374|**msdyn_vivaorgextensioncred**|
|10375|**msdyn_vivaorgsetting**|
|10376|**msdyn_vivausersetting**|
|10377|**Sales Copilot Insight**|
|10378|**Org level settings for Sales Copilot apps**|
|10379|**App profile**|
|10380|**Application Extension**|
|10381|**Application Tab Template**|
|10382|**App profile role mapping**|
|10383|**Notification Field**|
|10384|**Notification Template**|
|10385|**Session Template**|
|10386|**Template Parameter**|
|10392|**Channel Integration Framework v1.0 Provider**|
|10393|**Notification Field (Deprecated)**|
|10394|**Notification Template (Deprecated)**|
|10395|**App Parameter Definition (Deprecated)**|
|10396|**Session Templates (Deprecated)**|
|10397|**Application Tab Template (Deprecated)**|
|10398|**Parameter (Deprecated)**|
|10399|**Template Tag (Deprecated)**|
|10400|**Application Type (Deprecated)**|
|10409|**Channel Integration Framework v2.0 Provider**|
|10411|**Conversation Data (Deprecated)**|
|10412|**KPI Event Data**|
|10413|**KPI Event Definition**|
|10414|**Session Data (Deprecated)**|
|10415|**Session Participant Data (Deprecated)**|
|10416|**Channel Definition**|
|10417|**Channel Definition Consent**|
|10418|**Channel Definition Locale**|
|10419|**Channel Instance**|
|10420|**Channel Instance Account**|
|10421|**Channel Message Attachment**|
|10422|**Channel Message Context Part**|
|10423|**Channel Message Part**|
|10424|**Consuming Application**|
|10425|**msdyn_DefExtendedChannelInstance**|
|10426|**msdyn_DefExtendedChannelInstanceAccount**|
|10427|**Productivity pane configuration**|
|10428|**Pane tab configuration**|
|10429|**Pane tool configuration**|
|10431|**Agent script**|
|10432|**Agent script step**|
|10434|**Action Input Parameter**|
|10435|**Action Output Parameter**|
|10436|**Macro Action Template**|
|10437|**Macro Solution Configuration**|
|10438|**Macro Connector**|
|10439|**Macro Run History**|
|10440|**Parameter definition**|
|10443|**Adaptive Card Configuration**|
|10444|**Smartassist configuration**|
|10446|**Read Tracker**|
|10447|**Read tracking enabled information**|
|10448|**Microsoft Teams Graph resource Entity**|
|10449|**msdyn_msteamssetting**|
|10450|**msdyn_msteamssettingsv2**|
|10451|**Microsoft Teams Collaboration entity**|
|10452|**Teams Dialer Admin settings**|
|10453|**Teams Contact Suggestion by AI**|
|10454|**Contact suggestion rule**|
|10455|**Contact suggestion ruleset**|
|10456|**Microsoft Teams chat association entity**|
|10457|**Microsoft Teams chat suggestion**|
|10458|**Microsoft Orgchart node entity**|
|10459|**Forecast Manual Adjustment History**|
|10460|**Distributed Lock**|
|10461|**Entity Delta Change**|
|10462|**File Upload Status Tracker**|
|10463|**Forecast**|
|10464|**Forecast Configuration**|
|10465|**Forecast definition**|
|10466|**Forecasting Cache**|
|10467|**Forecast Insights**|
|10468|**Forecast**|
|10469|**Forecast Prediction Data**|
|10470|**Forecast Prediction Status**|
|10471|**Forecast recurrence**|
|10472|**Recompute Tracker**|
|10473|**Forecast Recurrence**|
|10474|**ShareAs Configuration**|
|10475|**Customer email communication**|
|10476|**GDPRData**|
|10477|**ODOSFeatureMetadata**|
|10478|**ODOSMetadata**|
|10479|**Recurring Sales Action**|
|10480|**Recurring Sales Action V2**|
|10481|**msdyn_relationshipinsightsunifiedconfig**|
|10482|**siconfig**|
|10483|**SI Key Value Config**|
|10484|**Usage Metric**|
|10485|**Action Card Regarding**|
|10486|**Action Card Role Setting**|
|10487|**EntityRankingRule**|
|10488|**flowcardtype**|
|10489|**salesinsightssettings**|
|10490|**Action Card Usage**|
|10491|**Action Card Usage Aggregation**|
|10492|**Auto Capture Rule**|
|10493|**Auto Capture Settings**|
|10494|**UntrackedAppointment**|
|10495|**Suggested Activity**|
|10496|**Suggested Activity Data Source**|
|10497|**Suggested Contact**|
|10498|**Suggested Contacts Data Source**|
|10499|**Notes analysis Config**|
|10500|**icebreakersconfig**|
|10501|**dealmanageraccess**|
|10502|**Deal manager settings**|
|10503|**Account KPI Item**|
|10504|**Activity Analysis CleanUp State**|
|10505|**Relationship Analytics Config**|
|10506|**Contact KPI Item**|
|10507|**Daily Kpis for account**|
|10508|**Daily kpis for contact**|
|10509|**Daily kpis for lead**|
|10510|**Daily kpis for Opportunity**|
|10511|**Lead KPI Item**|
|10512|**Most Contacted**|
|10513|**Most Contacted By**|
|10514|**Opportunity KPI Item**|
|10515|**Relationship Analytics Metadata**|
|10516|**Similar entities feature importance**|
|10517|**wkwcolleaguesforcompany**|
|10518|**wkwcolleaguesforcontact**|
|10519|**wkwconfig**|
|10520|**Attribute Influence Statistics**|
|10521|**Prediction Computation Operation**|
|10522|**Prediction Model Status**|
|10523|**Prediction Scheduled Operation**|
|10524|**Predictive Model Score**|
|10525|**Predictive Score**|
|10526|**Predictive Scoring Sync Status**|
|10527|**Real Time Scoring**|
|10528|**Real Time Scoring Operation**|
|10529|**Submodel Definition**|
|10530|**Time spent in BPF**|
|10531|**Training Result**|
|10532|**OpportunityModelConfig**|
|10535|**LeadModelConfig**|
|10536|**ModelPreviewStatus**|
|10537|**Profile Album**|
|10538|**Post Configuration**|
|10539|**Post Rule Configuration**|
|10540|**Wall View**|
|10541|**Filter**|
|10542|**Customer Voice alert**|
|10543|**Customer Voice alert rule**|
|10544|**Customer Voice survey email template**|
|10545|**Customer Voice file response**|
|10546|**Customer Voice localized survey email template**|
|10547|**Customer Voice project**|
|10548|**Customer Voice survey question**|
|10549|**Customer Voice survey question response**|
|10550|**Customer Voice satisfaction metric**|
|10551|**Customer Voice survey**|
|10552|**Customer Voice survey invite**|
|10553|**Customer Voice survey reminder**|
|10554|**Customer Voice survey response**|
|10555|**Customer Voice unsubscribed recipient**|
|10556|**AddToCalendar style**|
|10557|**basestyle**|
|10558|**Button style**|
|10559|**Code style**|
|10560|**Column style**|
|10561|**Content Block**|
|10562|**Divider style**|
|10563|**General styles**|
|10564|**imagestyle**|
|10565|**Layout Style**|
|10566|**QR code style**|
|10567|**Text style**|
|10568|**Video style**|
|10569|**App state**|
|10570|**CSAdminConfig**|
|10571|**Custom API Ruleset Configuration**|
|10572|**Decision contract**|
|10573|**Decision rule set**|
|10574|**Rulesetentitymapping**|
|10575|**Routing diagnostic item**|
|10576|**Routing diagnostic**|
|10577|**Inbox card configuration**|
|10578|**Inbox Configuration**|
|10579|**Inbox Entity Configuration**|
|10580|**App Profile Copilot Configuration**|
|10581|**Agent Copilot Setting**|
|10582|**Copilot Summarization Setting**|
|10583|**Case Enrichment**|
|10584|**Case Suggestion**|
|10585|**Case Suggestion Request Payload**|
|10586|**Case Suggestions Data Souce**|
|10587|**Agent Preference For Copilot**|
|10588|**Copilot Interaction**|
|10589|**Copilot Interaction Data**|
|10590|**Copilot Transcript**|
|10591|**Copilot Transcript Data**|
|10592|**KB Enrichment**|
|10593|**Knowledge Article Suggestion**|
|10594|**Knowledge Article Suggestion Data Source**|
|10595|**Service Copilot Plugin**|
|10596|**Service Copilot Plugin Role**|
|10597|**Suggestion Interaction**|
|10598|**Suggestion request payload**|
|10599|**Suggestions Model Summary**|
|10600|**Suggestions Setting**|
|10601|**Swarm**|
|10602|**Swarm participant**|
|10603|**Swarm participant rule**|
|10604|**Swarm role**|
|10605|**Swarm skill**|
|10606|**Swarm template**|
|10607|**Entity Attachment**|
|10608|**Customer Service Key Value Configuration**|
|10609|**Master Entity Routing Configuration**|
|10610|**Routing Rule Set Setting**|
|10611|**Assignment Configuration**|
|10612|**Assignment Configuration Step**|
|10613|**Capacity Profile**|
|10614|**Overflow Action Config**|
|10615|**Preferred Agent**|
|10616|**Preferred Agent Customer Identity**|
|10617|**Preferred Agent Routed Entity**|
|10618|**Routing configuration**|
|10619|**Routing configuration step**|
|10620|**Bot Channel Registration**|
|10621|**Channel Configuration**|
|10622|**Channel State Configuration**|
|10623|**Provisioning State**|
|10624|**AdminAppState**|
|10625|**Agent Status history**|
|10626|**Power BI Configuration**|
|10627|**Authentication Settings**|
|10628|**Auth Settings Entry**|
|10629|**Quick reply**|
|10630|**Entity Routing Context**|
|10631|**Channel Capability**|
|10632|**Conversation Action**|
|10633|**Conversation Action Locale**|
|10634|**Conversation Message Block**|
|10635|**DeletedConversation**|
|10636|**Deprecated Workstream Entity Configuration**|
|10637|**Entity**|
|10638|**Ongoing conversation (Deprecated)**|
|10639|**Live work item event**|
|10640|**Work Stream**|
|10641|**Masking Rule**|
|10642|**Auto block rule**|
|10643|**Bot Channel Registration Secret**|
|10644|**Omnichannel channel api conversation privilege**|
|10645|**Omnichannel channel api message privilege**|
|10646|**Channel api method mapping**|
|10647|**External context**|
|10648|**Flagged spam**|
|10649|**Language**|
|10650|**Conversation**|
|10653|**Context item value**|
|10654|**Live Work Item Participant (Deprecated)**|
|10655|**Conversation Sentiment**|
|10656|**Context variable**|
|10657|**Localization**|
|10658|**OC Payment Profile**|
|10659|**Recording**|
|10660|**Omnichannel Request**|
|10661|**Rich message**|
|10662|**Rich message map**|
|10663|**Rule Item**|
|10664|**Sentiment daily topic**|
|10665|**Sentiment daily topic keyword**|
|10666|**Sentiment daily topic trending**|
|10667|**Session**|
|10668|**Session Participant Event**|
|10669|**Session Sentiment**|
|10670|**Message**|
|10671|**Tag**|
|10672|**Geo Location Provider**|
|10673|**Omnichannel Configuration**|
|10674|**Omnichannel Personalization**|
|10675|**Omnichannel Queue (Deprecated)**|
|10676|**Omnichannel Sync Config**|
|10677|**Operating Hour**|
|10678|**Personal quick reply**|
|10679|**Personal sound setting**|
|10680|**Persona Security Role Mapping**|
|10681|**Presence**|
|10682|**Provider**|
|10683|**RoutingRequest**|
|10684|**Search Configuration**|
|10685|**Sentiment analysis**|
|10686|**Session event**|
|10687|**Session participant**|
|10688|**Audio File**|
|10689|**Sound notification setting**|
|10690|**Transcript**|
|10691|**UR notification template**|
|10692|**UR Notification Template Mapping**|
|10693|**User settings**|
|10694|**Self service**|
|10701|**Agent capacity update history**|
|10702|**Bookable Resource Capacity Profile**|
|10703|**Work stream capacity profile**|
|10704|**Conversation Capacity profile**|
|10705|**Agent Capacity Profile Unit**|
|10706|**Agent Channel State**|
|10707|**Agent Status**|
|10708|**Conversation Characteristic**|
|10709|**Session Characteristic**|
|10710|**Skill Attachment Rule**|
|10711|**Attach Skill**|
|10712|**Model training details**|
|10713|**Training data import configuration**|
|10714|**Characteristic mapping**|
|10715|**Training record**|
|10716|**Skill finder model**|
|10717|**Effort estimate**|
|10718|**Effort estimation model**|
|10719|**Effort model training details**|
|10720|**ConversationInsight**|
|10721|**Active ICD Extension**|
|10722|**Entity-Workstream Map**|
|10723|**ICD Extension**|
|10724|**Conversation Action Item**|
|10725|**Conversation Aggregated Insights**|
|10726|**Comment**|
|10727|**Conversation Participant Insights**|
|10728|**Conversation Participant Sentiment**|
|10729|**Conversation Question**|
|10730|**Conversation Segment Sentiment**|
|10731|**Conversation Sentiment**|
|10732|**Conversation Signal**|
|10733|**Conversation Subject**|
|10734|**Conversation Summary Suggestion**|
|10735|**Conversation System Tag**|
|10736|**Conversation Tag**|
|10737|**Recording (Deprecated)**|
|10738|**SCI Conversation**|
|10739|**Custom Email Highlight**|
|10740|**Custom Highlight**|
|10741|**Custom Publisher**|
|10742|**EnvironmentSettings**|
|10743|**UserSettings**|
|10744|**CatalogEventStatusConfiguration**|
|10745|**Configuration**|
|10746|**Trigger**|
|10747|**Triggers To Sdk Message Processing Steps**|
|10748|**EventParameterMetadata**|
|10749|**TrackingContext**|
|10750|**Marketing feature configuration**|
|10751|**msdynmkt_experimentv2**|
|10752|**ACS channel instance**|
|10753|**ACS channel instance account**|
|10754|**Infobip channel instance**|
|10755|**Infobip channel instance account**|
|10756|**Link mobility channel instance**|
|10757|**Link mobility channel instance account**|
|10758|**MockSmsProvider channel instance**|
|10759|**MockSmsProvider channel instance account**|
|10760|**TeleSign channel instance**|
|10761|**TeleSign channel instance account**|
|10762|**Twilio channel instance**|
|10763|**Twilio channel instance account**|
|10764|**Vibes channel instance**|
|10765|**Vibes channel instance account**|
|10766|**Predefined Placeholder**|
|10767|**Metadata Entity Relationship**|
|10768|**Metadata Item**|
|10769|**Metadata Store State**|
|10770|**DigitalSellingActiveTask**|
|10771|**DigitalSellingCompletedTask**|
|10772|**Sales Tag**|
|10773|**Sequence**|
|10774|**Sequence Stat**|
|10775|**Sequence Target**|
|10776|**Sequence Target Step**|
|10777|**Sequence Template**|
|10779|**sabackupdiagnostic**|
|10780|**SABatchRunInstance**|
|10781|**salesroutingdiagnostic**|
|10782|**SARunInstance**|
|10783|**Segment**|
|10784|**segmentsetting**|
|10785|**Segment property**|
|10786|**SegmentsUtil**|
|10787|**Assignment Rule**|
|10788|**Seller attribute**|
|10789|**Seller attribute value**|
|10790|**Assignment Map**|
|10791|**Sales Assignment Setting**|
|10792|**Sales routing run**|
|10794|**Extended User Setting**|
|10795|**Sales acceleration insights**|
|10796|**Sales Acceleration settings**|
|10797|**Insight**|
|10798|**Work List Suggestion**|
|10799|**Work list suggestion source**|
|10800|**Work List View Configuration**|
|10801|**Work Queue Record**|
|10802|**Work Queue Record State**|
|10803|**Work list user setting**|
|10804|**WQDataSource**|
|10805|**Suggestion Assignment Rule**|
|10806|**Suggestion Principal Object Access**|
|10807|**Suggestion Seller Priority**|
|10808|**Data Hygiene Setting Info**|
|10809|**Duplicate Detection Plugin Run**|
|10810|**Duplicate Lead Mapping**|
|10811|**Lead Hygiene Setting**|
|10812|**Linked Entity Attribute Validity**|
|10813|**Sales provisioning request**|
|10814|**SalesOmnichannel Message**|
|10815|**Text message template**|
|10816|**Data Analytics Admin Settings (Deprecated)**|
|10817|**Data Analytics Report**|
|10818|**Insights**|
|10819|**Sales acceleration reports**|
|10821|**Bot Session**|
|10822|**conversationsuggestionrequestpayload**|
|10823|**Data Analytics User Customized Report**|
|10824|**Data Analytics Dataset**|
|10825|**Data Analytics Workspace**|
|10826|**Report Bookmark**|
|10827|**Agent Resource Forecasting**|
|10828|**[Deprecated] Dynamics Customer Service Analytics**|
|10829|**Case Topic**|
|10830|**Case Topic Setting**|
|10831|**Case Topic Summary**|
|10832|**Case topic Incident mapping**|
|10833|**Customer Service historical analytics**|
|10834|**Forecast**|
|10835|**Knowledge analytics**|
|10836|**Forecast Summary and Setting**|
|10837|**Keywords Description Suggestion Setting**|
|10908|**Autonomous case creation and enrichment rules**|
|11003|**Conversation Summary Interaction**|
|11004|**Conversation Summary Setting**|
|11005|**Conversation Topic**|
|11006|**Conversation Topic Setting**|
|11007|**Conversation Topic Summary**|
|11008|**Conversation topic Conversation mapping**|
|11009|**Omnichannel historical analytics**|
|11010|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|11011|**Omnichannel Realtime analytics**|
|11012|**SearchResultsCache**|
|11028|**Flow Credential Application**|
|11029|**Sales usage telemetry reports**|
|11030|**Sales usage reporting**|
|11031|**Sales Copilot User Setting**|
|11032|**Omnichannel agent assignment custom api privilege**|
|11033|**Planner Business Scenario**|
|11034|**Planner Sync Action**|
|11035|**CopilotGlossaryTerm**|
|11036|**CopilotSynonyms**|
|11056|**Property Location Association**|
|11057|**Flow Log**|
|11058|**Copilot component collection**|
|11064|**AICopilot**|
|11065|**AI Plugin Conversation Starter**|
|11066|**AI Plugin Conversation Starter Mapping**|
|11067|**AI Plugin Governance**|
|11068|**AI Plugin Governance Extended**|
|11069|**AIPluginOperationResponseTemplate**|
|11070|**AIPluginTitle**|
|11071|**SideloadedAIPlugin**|
|11078|**Location Template Association**|
|11082|**Power Pages Scan Report**|
|11083|**Power Pages Log**|
|11085|**PM Simulation**|
|11086|**Fabric AISkill**|
|11087|**Knowledge Asset Configuration**|
|11088|**Salesforce Structured Object**|
|11089|**Salesforce Structured QnA Config**|
|11100|**Functional Location Type Template Association**|
|11101|**Functional Location Type**|
|11102|**Warranty**|
|11106|**AIPluginAuth**|
|11110|**Lock Status**|
|11112|**ViewAsExampleQuestion**|
|11123|**Survey setting**|
|11125|**Copilot Analytics**|
|11126|**FederatedKnowledgeConfiguration**|
|11127|**FederatedKnowledgeEntityConfiguration**|
|11129|**Form Mapping**|
|11130|**Case follow up and closure configuration**|
|11131|**Next Action**|
|11132|**Automated action rule**|
|11133|**Automated action rules mapping**|
|11134|**Time Tracker**|
|11135|**Report Parameter**|
|18085|**Event Expander Breadcrumb**|

### <a name="BKMK_msdyn_playbookactivity_json"></a> msdyn_playbookactivity_json

|Property|Value|
|---|---|
|Description|**This field is for internal use only.**|
|DisplayName|**Playbook Activity JSON**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_playbookactivity_json`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_playbookactivityId"></a> msdyn_playbookactivityId

|Property|Value|
|---|---|
|Description|**Shows the ID of the playbook activity.**|
|DisplayName|**Playbook activities**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_playbookactivityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_playbooktemplateid"></a> msdyn_playbooktemplateid

|Property|Value|
|---|---|
|Description|**Shows the ID of the playbook template associated with the playbook activities.**|
|DisplayName|**Playbook template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_playbooktemplateid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|msdyn_playbooktemplate|

### <a name="BKMK_msdyn_subject"></a> msdyn_subject

|Property|Value|
|---|---|
|Description|**Type a short description about the objective or primary topic of the activity.**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subject`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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
|Description|**Status of the Playbook Activities**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_playbookactivity_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Draft**<br />DefaultStatus: 1<br />InvariantName: `Draft`|
|1|Label: **Published**<br />DefaultStatus: 2<br />InvariantName: `Published`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Playbook Activities**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_playbookactivity_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **Published**<br />State:1<br />TransitionData: None|

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
|DisplayName|**Created on**|
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

- [business_unit_msdyn_playbookactivity](#BKMK_business_unit_msdyn_playbookactivity)
- [lk_msdyn_playbookactivity_createdby](#BKMK_lk_msdyn_playbookactivity_createdby)
- [lk_msdyn_playbookactivity_createdonbehalfby](#BKMK_lk_msdyn_playbookactivity_createdonbehalfby)
- [lk_msdyn_playbookactivity_modifiedby](#BKMK_lk_msdyn_playbookactivity_modifiedby)
- [lk_msdyn_playbookactivity_modifiedonbehalfby](#BKMK_lk_msdyn_playbookactivity_modifiedonbehalfby)
- [owner_msdyn_playbookactivity](#BKMK_owner_msdyn_playbookactivity)
- [team_msdyn_playbookactivity](#BKMK_team_msdyn_playbookactivity)
- [user_msdyn_playbookactivity](#BKMK_user_msdyn_playbookactivity)

### <a name="BKMK_business_unit_msdyn_playbookactivity"></a> business_unit_msdyn_playbookactivity

One-To-Many Relationship: [businessunit business_unit_msdyn_playbookactivity](businessunit.md#BKMK_business_unit_msdyn_playbookactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_playbookactivity_createdby"></a> lk_msdyn_playbookactivity_createdby

One-To-Many Relationship: [systemuser lk_msdyn_playbookactivity_createdby](systemuser.md#BKMK_lk_msdyn_playbookactivity_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_playbookactivity_createdonbehalfby"></a> lk_msdyn_playbookactivity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_playbookactivity_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_playbookactivity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_playbookactivity_modifiedby"></a> lk_msdyn_playbookactivity_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_playbookactivity_modifiedby](systemuser.md#BKMK_lk_msdyn_playbookactivity_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_playbookactivity_modifiedonbehalfby"></a> lk_msdyn_playbookactivity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_playbookactivity_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_playbookactivity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_playbookactivity"></a> owner_msdyn_playbookactivity

One-To-Many Relationship: [owner owner_msdyn_playbookactivity](owner.md#BKMK_owner_msdyn_playbookactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_playbookactivity"></a> team_msdyn_playbookactivity

One-To-Many Relationship: [team team_msdyn_playbookactivity](team.md#BKMK_team_msdyn_playbookactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_playbookactivity"></a> user_msdyn_playbookactivity

One-To-Many Relationship: [systemuser user_msdyn_playbookactivity](systemuser.md#BKMK_user_msdyn_playbookactivity)

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

- [msdyn_playbookactivity_AsyncOperations](#BKMK_msdyn_playbookactivity_AsyncOperations)
- [msdyn_playbookactivity_BulkDeleteFailures](#BKMK_msdyn_playbookactivity_BulkDeleteFailures)
- [msdyn_playbookactivity_DuplicateBaseRecord](#BKMK_msdyn_playbookactivity_DuplicateBaseRecord)
- [msdyn_playbookactivity_DuplicateMatchingRecord](#BKMK_msdyn_playbookactivity_DuplicateMatchingRecord)
- [msdyn_playbookactivity_MailboxTrackingFolders](#BKMK_msdyn_playbookactivity_MailboxTrackingFolders)
- [msdyn_playbookactivity_msdyn_playbookactivityattribute](#BKMK_msdyn_playbookactivity_msdyn_playbookactivityattribute)
- [msdyn_playbookactivity_PrincipalObjectAttributeAccesses](#BKMK_msdyn_playbookactivity_PrincipalObjectAttributeAccesses)
- [msdyn_playbookactivity_ProcessSession](#BKMK_msdyn_playbookactivity_ProcessSession)
- [msdyn_playbookactivity_SharePointDocumentLocations](#BKMK_msdyn_playbookactivity_SharePointDocumentLocations)
- [msdyn_playbookactivity_SyncErrors](#BKMK_msdyn_playbookactivity_SyncErrors)

### <a name="BKMK_msdyn_playbookactivity_AsyncOperations"></a> msdyn_playbookactivity_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_playbookactivity_AsyncOperations](asyncoperation.md#BKMK_msdyn_playbookactivity_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_BulkDeleteFailures"></a> msdyn_playbookactivity_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_playbookactivity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_playbookactivity_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_DuplicateBaseRecord"></a> msdyn_playbookactivity_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_playbookactivity_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_playbookactivity_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_DuplicateMatchingRecord"></a> msdyn_playbookactivity_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_playbookactivity_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_playbookactivity_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_MailboxTrackingFolders"></a> msdyn_playbookactivity_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_playbookactivity_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_playbookactivity_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_msdyn_playbookactivityattribute"></a> msdyn_playbookactivity_msdyn_playbookactivityattribute

Many-To-One Relationship: [msdyn_playbookactivityattribute msdyn_playbookactivity_msdyn_playbookactivityattribute](msdyn_playbookactivityattribute.md#BKMK_msdyn_playbookactivity_msdyn_playbookactivityattribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_playbookactivityattribute`|
|ReferencingAttribute|`msdyn_playbookactivityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_msdyn_playbookactivityattribute`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_PrincipalObjectAttributeAccesses"></a> msdyn_playbookactivity_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_playbookactivity_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_playbookactivity_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_ProcessSession"></a> msdyn_playbookactivity_ProcessSession

Many-To-One Relationship: [processsession msdyn_playbookactivity_ProcessSession](processsession.md#BKMK_msdyn_playbookactivity_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_SharePointDocumentLocations"></a> msdyn_playbookactivity_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_playbookactivity_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_playbookactivity_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_playbookactivity_SyncErrors"></a> msdyn_playbookactivity_SyncErrors

Many-To-One Relationship: [syncerror msdyn_playbookactivity_SyncErrors](syncerror.md#BKMK_msdyn_playbookactivity_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_playbookactivity_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

