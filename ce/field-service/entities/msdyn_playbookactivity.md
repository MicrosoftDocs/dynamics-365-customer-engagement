---
title: "Playbook activity (msdyn_playbookactivity) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Playbook activity (msdyn_playbookactivity) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
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
|1083|**Opportunity Line**|
|1084|**Quote**|
|1085|**Quote Line**|
|1086|**User Fiscal Calendar**|
|1088|**Order**|
|1089|**Order Line**|
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
|9955|**KnowledgeArticle Views**|
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
|10095|**Connection Reference**|
|10096|**DVFileSearch**|
|10097|**DVFileSearchAttribute**|
|10098|**DVFileSearchEntity**|
|10099|**DVTableSearch**|
|10100|**DVTableSearchAttribute**|
|10101|**DVTableSearchEntity**|
|10102|**AICopilot**|
|10103|**AI Plugin Conversation Starter**|
|10104|**AI Plugin Conversation Starter Mapping**|
|10105|**AI Plugin Governance**|
|10106|**AI Plugin Governance Extended**|
|10107|**AIPluginOperationResponseTemplate**|
|10108|**AIPluginTitle**|
|10109|**SideloadedAIPlugin**|
|10110|**AIPlugin**|
|10111|**AIPluginExternalSchema**|
|10112|**AIPluginExternalSchemaProperty**|
|10113|**AIPluginInstance**|
|10114|**AIPluginOperation**|
|10115|**AIPluginOperationParameter**|
|10116|**AIPluginUserSetting**|
|10118|**AI Event**|
|10119|**AI Builder Feedback Loop**|
|10120|**AI Form Processing Document**|
|10121|**AI Object Detection Image**|
|10122|**AI Object Detection Label**|
|10123|**AI Object Detection Bounding Box**|
|10124|**AI Object Detection Image Mapping**|
|10126|**AI Builder Dataset**|
|10127|**AI Builder Dataset File**|
|10128|**AI Builder Dataset Record**|
|10129|**AI Builder Datasets Container**|
|10130|**AI Builder File**|
|10131|**AI Builder File Attached Data**|
|10132|**Help Page**|
|10133|**Tour**|
|10134|**BotContent**|
|10135|**ConversationTranscript**|
|10136|**Chatbot**|
|10137|**Chatbot subcomponent**|
|10138|**Chatbot component collection**|
|10148|**Comment**|
|10149|**Fabric AISkill**|
|10150|**App Insights Metadata**|
|10151|**Dataflow Connection Reference**|
|10152|**Schedule**|
|10153|**Dataflow Template**|
|10154|**Dataflow DatalakeFolder**|
|10155|**Data Movement Service Request**|
|10156|**Data Movement Service Request Status**|
|10157|**DMS Sync Request**|
|10158|**DMS Sync Status**|
|10159|**Knowledge Asset Configuration**|
|10160|**Module Run Detail**|
|10161|**Salesforce Structured Object**|
|10162|**Salesforce Structured QnA Config**|
|10163|**Workflow Action Status**|
|10164|**PDF Setting**|
|10165|**Activity File Attachment**|
|10166|**Teams chat**|
|10167|**Service Configuration**|
|10168|**SLA KPI**|
|10169|**Integrated search provider**|
|10170|**Knowledge Management Setting**|
|10171|**Knowledge Federated Article**|
|10172|**Knowledge Federated Article Incident**|
|10173|**Search provider**|
|10174|**Knowledge Article Image**|
|10175|**Knowledge Configuration**|
|10176|**Knowledge Interaction Insight**|
|10177|**Knowledge Search Insight**|
|10178|**Favorite knowledge article**|
|10179|**Knowledge article language setting**|
|10180|**Knowledge Article Attachment**|
|10181|**Knowledge personalization**|
|10182|**Knowledge Article Template**|
|10183|**Knowledge search personal filter config**|
|10184|**Knowledge search filter**|
|10186|**SupportUserTable**|
|10187|**FxExpression**|
|10188|**PowerfxRule**|
|10189|**Planner Business Scenario**|
|10190|**Planner Sync Action**|
|10191|**Ms Graph Resource To Subscription**|
|10192|**Virtual Entity  Metadata**|
|10193|**Background Operation**|
|10194|**MobileOfflineProfileExtension**|
|10195|**MobileOfflineProfileItemFilter**|
|10196|**TeamMobileOfflineProfileMembership**|
|10197|**UserMobileOfflineProfileMembership**|
|10198|**OrganizationDataSyncSubscription**|
|10199|**OrganizationDataSyncSubscriptionEntity**|
|10200|**OrganizationDataSyncSubscriptionFnoTable**|
|10201|**OrganizationDataSyncFnoState**|
|10202|**OrganizationDataSyncState**|
|10203|**ArchiveCleanupInfo**|
|10204|**ArchiveCleanupOperation**|
|10205|**BulkArchiveConfig**|
|10206|**BulkArchiveFailureDetail**|
|10207|**BulkArchiveOperation**|
|10208|**BulkArchiveOperationDetail**|
|10209|**EnableArchivalRequest**|
|10210|**MetadataForArchival**|
|10211|**ReconciliationEntityInfo**|
|10212|**ReconciliationEntityStepInfo**|
|10213|**ReconciliationInfo**|
|10214|**RetentionCleanupInfo**|
|10215|**RetentionCleanupOperation**|
|10216|**RetentionConfig**|
|10217|**RetentionFailureDetail**|
|10218|**RetentionOperation**|
|10219|**RetentionOperationDetail**|
|10220|**Notification**|
|10221|**User Rating**|
|10222|**Mobile App**|
|10223|**Insights Store Data Source**|
|10224|**Insights Store Virtual Entity**|
|10225|**RoleEditorLayout**|
|10226|**Deleted Record Reference**|
|10227|**Restore Deleted Records Configuration**|
|10228|**App Action**|
|10229|**App Action Migration**|
|10230|**App Action Rule**|
|10233|**Card**|
|10234|**Card State Item**|
|10237|**Entity link chat configuration**|
|10238|**Rich Text Attachment**|
|10239|**Custom Control Extended Setting**|
|10240|**Timeline Pin**|
|10241|**Virtual Connector Data Source**|
|10242|**Virtual Table Column Candidate**|
|10243|**PM Analysis History**|
|10244|**PM Business Rule Automation Config**|
|10245|**PM Calendar**|
|10246|**PM Calendar Version**|
|10247|**PM Inferred Task**|
|10248|**PM Process Extended Metadata Version**|
|10249|**PM Process Template**|
|10250|**PM Process User Settings**|
|10251|**PM Process Version**|
|10252|**PM Recording**|
|10253|**PM Template**|
|10254|**PM View**|
|10255|**Analysis Component**|
|10256|**Analysis Job**|
|10257|**Analysis Override**|
|10258|**Analysis Result**|
|10259|**Analysis Result Detail**|
|10260|**Solution Health Rule**|
|10261|**Solution Health Rule Argument**|
|10262|**Solution Health Rule Set**|
|10263|**Power BI Dataset**|
|10264|**powerbidatasetapdx**|
|10265|**Power BI Mashup Parameter**|
|10266|**Power BI Report**|
|10267|**powerbireportapdx**|
|10268|**File Upload**|
|10269|**MainFewShot**|
|10270|**MakerFewShot**|
|10271|**SearchAttributeSettings**|
|10272|**SearchCustomAnalyzer**|
|10273|**SearchRelationshipSettings**|
|10274|**SearchResultsCache**|
|10275|**Search Telemetry**|
|10276|**CopilotExampleQuestion**|
|10277|**CopilotGlossaryTerm**|
|10278|**CopilotSynonyms**|
|10279|**Site Component**|
|10280|**Site**|
|10281|**Site Language**|
|10282|**Power Pages Site Published**|
|10285|**External Identity**|
|10286|**Invitation**|
|10287|**Invite Redemption**|
|10288|**Portal Comment**|
|10289|**Setting**|
|10290|**Multistep Form Session**|
|10294|**Ad Placement**|
|10295|**Column Permission**|
|10296|**Column Permission Profile**|
|10297|**Content Snippet**|
|10298|**Basic Form**|
|10299|**Basic Form Metadata**|
|10300|**List**|
|10301|**Table Permission**|
|10302|**Page Template**|
|10303|**Poll Placement**|
|10304|**Power Pages Core Entity DS**|
|10305|**Publishing State**|
|10306|**Publishing State Transition Rule**|
|10307|**Redirect**|
|10308|**Shortcut**|
|10309|**Site Marker**|
|10310|**Site Setting**|
|10311|**Web File**|
|10312|**Multistep Form**|
|10313|**Multistep Form Metadata**|
|10314|**Form Step**|
|10315|**Web Link**|
|10316|**Web Link Set**|
|10317|**Web Page**|
|10318|**Web Page Access Control Rule**|
|10319|**Web Role**|
|10320|**Website**|
|10321|**Website Access**|
|10322|**Website Language**|
|10323|**Web Template**|
|10330|**Power Pages Scan Report**|
|10331|**Power Pages Log**|
|10335|**Catalog Submission Files**|
|10336|**Package Submission Store**|
|10337|**List Operation**|
|10338|**Marketing Form Display Attributes**|
|10339|**Database Version**|
|10340|**Upgrade Run**|
|10341|**Upgrade Step**|
|10342|**Upgrade Version**|
|10343|**Activity monitor**|
|10344|**Originating Queue Mapping**|
|10345|**Unified Routing Setup Tracker**|
|10346|**Available Times**|
|10347|**Available Times Data Source**|
|10348|**resource group data source**|
|10349|**Virtual Resource Group Resource**|
|10350|**Migration tracker**|
|10351|**BgJobLedger**|
|10352|**Intent**|
|10353|**JobsState**|
|10354|**Asset Category Template Association**|
|10355|**Asset Template Association**|
|10356|**Customer Asset**|
|10359|**Customer Asset Attachment**|
|10360|**Customer Asset Category**|
|10361|**Functional Location**|
|10362|**Property Definition**|
|10363|**Property Asset Association**|
|10364|**Property Log**|
|10365|**Property Template Association**|
|10366|**Template For Properties**|
|10370|**IoT Alert**|
|10371|**IoT Device**|
|10372|**IoT Device Category**|
|10373|**IoT Device Command**|
|10374|**IoT Device Command Definition**|
|10375|**IoT Device Data History**|
|10376|**IoT Device Property**|
|10377|**IoT Device Registration History**|
|10378|**IoT Device Visualization Configuration**|
|10379|**IoT Field Mapping**|
|10380|**IoT Property Definition**|
|10381|**IoT Provider**|
|10382|**IoT Provider Instance**|
|10383|**IoT Settings**|
|10386|**IoT Alert to Case Process**|
|10388|**Playbook Callable Context**|
|10389|**Playbook activity**|
|10390|**Playbook activity attribute**|
|10391|**[DEPRECATED] Playbook category**|
|10392|**Playbook**|
|10393|**[DEPRECATED] Playbook template**|
|10395|**admin_settings_entity**|
|10396|**Collab Space Team Association**|
|10397|**CRM Connection**|
|10398|**Tagged Record**|
|10399|**Copilot for Sales customer list**|
|10400|**msdyn_vivaentitysetting**|
|10401|**msdyn_vivaorgextensioncred**|
|10402|**msdyn_vivaorgsetting**|
|10403|**msdyn_vivausersetting**|
|10404|**Sales Copilot Insight**|
|10405|**Org level settings for Sales Copilot apps**|
|10406|**Sales Copilot User Setting**|
|10407|**App profile**|
|10408|**Application Extension**|
|10409|**Application Tab Template**|
|10410|**App profile role mapping**|
|10411|**Notification Field**|
|10412|**Notification Template**|
|10413|**Session Template**|
|10414|**Template Parameter**|
|10420|**Channel Integration Framework v1.0 Provider**|
|10421|**Notification Field (Deprecated)**|
|10422|**Notification Template (Deprecated)**|
|10423|**App Parameter Definition (Deprecated)**|
|10424|**Session Templates (Deprecated)**|
|10425|**Application Tab Template (Deprecated)**|
|10426|**Parameter (Deprecated)**|
|10427|**Template Tag (Deprecated)**|
|10428|**Application Type (Deprecated)**|
|10437|**Channel Integration Framework v2.0 Provider**|
|10439|**Conversation Data (Deprecated)**|
|10440|**KPI Event Data**|
|10441|**KPI Event Definition**|
|10442|**Session Data (Deprecated)**|
|10443|**Session Participant Data (Deprecated)**|
|10444|**Channel Definition**|
|10445|**Channel Definition Consent**|
|10446|**Channel Definition Locale**|
|10447|**Channel Instance**|
|10448|**Channel Instance Account**|
|10449|**Channel Message Attachment**|
|10450|**Channel Message Context Part**|
|10451|**Channel Message Part**|
|10452|**Consuming Application**|
|10453|**msdyn_DefExtendedChannelInstance**|
|10454|**msdyn_DefExtendedChannelInstanceAccount**|
|10455|**Productivity pane configuration**|
|10456|**Pane tab configuration**|
|10457|**Pane tool configuration**|
|10459|**Agent script**|
|10460|**Agent script step**|
|10462|**Action Input Parameter**|
|10463|**Action Output Parameter**|
|10464|**Macro Action Template**|
|10465|**Macro Solution Configuration**|
|10466|**Macro Connector**|
|10467|**Macro Run History**|
|10468|**Parameter definition**|
|10471|**Adaptive Card Configuration**|
|10472|**Smartassist configuration**|
|10474|**Read Tracker**|
|10475|**Read tracking enabled information**|
|10476|**Microsoft Teams Graph resource Entity**|
|10477|**msdyn_msteamssetting**|
|10478|**msdyn_msteamssettingsv2**|
|10479|**Microsoft Teams Collaboration entity**|
|10480|**Teams Dialer Admin settings**|
|10481|**Teams Contact Suggestion by AI**|
|10482|**Contact suggestion rule**|
|10483|**Contact suggestion ruleset**|
|10484|**Microsoft Teams chat association entity**|
|10485|**Microsoft Teams chat suggestion**|
|10486|**Microsoft Orgchart node entity**|
|10487|**Forecast Manual Adjustment History**|
|10488|**Distributed Lock**|
|10489|**Entity Delta Change**|
|10490|**File Upload Status Tracker**|
|10491|**Forecast**|
|10492|**Forecast Configuration**|
|10493|**Forecast definition**|
|10494|**Forecasting Cache**|
|10495|**Forecast Insights**|
|10496|**Forecast**|
|10497|**Forecast Prediction Data**|
|10498|**Forecast Prediction Status**|
|10499|**Forecast recurrence**|
|10500|**Recompute Tracker**|
|10501|**Forecast Recurrence**|
|10502|**ShareAs Configuration**|
|10503|**Customer email communication**|
|10504|**GDPRData**|
|10505|**ODOSFeatureMetadata**|
|10506|**ODOSMetadata**|
|10507|**Recurring Sales Action**|
|10508|**Recurring Sales Action V2**|
|10509|**msdyn_relationshipinsightsunifiedconfig**|
|10510|**siconfig**|
|10511|**SI Key Value Config**|
|10512|**Usage Metric**|
|10513|**Action Card Regarding**|
|10514|**Action Card Role Setting**|
|10515|**EntityRankingRule**|
|10516|**flowcardtype**|
|10517|**salesinsightssettings**|
|10518|**Action Card Usage**|
|10519|**Action Card Usage Aggregation**|
|10520|**Auto Capture Rule**|
|10521|**Auto Capture Settings**|
|10522|**UntrackedAppointment**|
|10523|**Suggested Activity**|
|10524|**Suggested Activity Data Source**|
|10525|**Suggested Contact**|
|10526|**Suggested Contacts Data Source**|
|10527|**Notes analysis Config**|
|10528|**icebreakersconfig**|
|10529|**dealmanageraccess**|
|10530|**Deal manager settings**|
|10531|**Account KPI Item**|
|10532|**Activity Analysis CleanUp State**|
|10533|**Relationship Analytics Config**|
|10534|**Contact KPI Item**|
|10535|**Daily Kpis for account**|
|10536|**Daily kpis for contact**|
|10537|**Daily kpis for lead**|
|10538|**Daily kpis for Opportunity**|
|10539|**Lead KPI Item**|
|10540|**Most Contacted**|
|10541|**Most Contacted By**|
|10542|**Opportunity KPI Item**|
|10543|**Relationship Analytics Metadata**|
|10544|**Similar entities feature importance**|
|10545|**wkwcolleaguesforcompany**|
|10546|**wkwcolleaguesforcontact**|
|10547|**wkwconfig**|
|10548|**Attribute Influence Statistics**|
|10549|**Prediction Computation Operation**|
|10550|**Prediction Model Status**|
|10551|**Prediction Scheduled Operation**|
|10552|**Predictive Model Score**|
|10553|**Predictive Score**|
|10554|**Predictive Scoring Sync Status**|
|10555|**Real Time Scoring**|
|10556|**Real Time Scoring Operation**|
|10557|**Submodel Definition**|
|10558|**Time spent in BPF**|
|10559|**Training Result**|
|10560|**OpportunityModelConfig**|
|10561|**LeadModelConfig**|
|10562|**ModelPreviewStatus**|
|10563|**Profile Album**|
|10564|**Post Configuration**|
|10565|**Post Rule Configuration**|
|10566|**Wall View**|
|10567|**Filter**|
|10568|**Customer Voice alert**|
|10569|**Customer Voice alert rule**|
|10570|**Customer Voice survey email template**|
|10571|**Customer Voice file response**|
|10572|**Customer Voice localized survey email template**|
|10573|**Customer Voice project**|
|10574|**Customer Voice survey question**|
|10575|**Customer Voice survey question response**|
|10576|**Customer Voice satisfaction metric**|
|10577|**Customer Voice survey**|
|10578|**Customer Voice survey invite**|
|10579|**Customer Voice survey reminder**|
|10580|**Customer Voice survey response**|
|10581|**Customer Voice unsubscribed recipient**|
|10582|**AddToCalendar style**|
|10583|**basestyle**|
|10584|**Button style**|
|10585|**Code style**|
|10586|**Column style**|
|10587|**Content Block**|
|10588|**Divider style**|
|10589|**General styles**|
|10590|**imagestyle**|
|10591|**Layout Style**|
|10592|**QR code style**|
|10593|**Text style**|
|10594|**Video style**|
|10595|**App state**|
|10596|**CSAdminConfig**|
|10597|**Custom API Ruleset Configuration**|
|10598|**Decision contract**|
|10599|**Decision rule set**|
|10600|**Rulesetentitymapping**|
|10601|**Routing diagnostic item**|
|10602|**Routing diagnostic**|
|10603|**Inbox card configuration**|
|10604|**Inbox Configuration**|
|10605|**Inbox Entity Configuration**|
|10606|**App Profile Copilot Configuration**|
|10607|**Agent Copilot Setting**|
|10608|**Copilot Summarization Setting**|
|10609|**Case Enrichment**|
|10610|**Case Suggestion**|
|10611|**Case Suggestion Request Payload**|
|10612|**Case Suggestions Data Souce**|
|10613|**Agent Preference For Copilot**|
|10614|**Copilot Interaction**|
|10615|**Copilot Interaction Data**|
|10616|**Copilot Transcript**|
|10617|**Copilot Transcript Data**|
|10618|**KB Enrichment**|
|10619|**Knowledge Article Suggestion**|
|10620|**Knowledge Article Suggestion Data Source**|
|10621|**Service Copilot Plugin**|
|10622|**Service Copilot Plugin Role**|
|10623|**Suggestion Interaction**|
|10624|**Suggestion request payload**|
|10625|**Suggestions Model Summary**|
|10626|**Suggestions Setting**|
|10627|**Swarm**|
|10628|**Swarm participant**|
|10629|**Swarm participant rule**|
|10630|**Swarm role**|
|10631|**Swarm skill**|
|10632|**Swarm template**|
|10633|**Entity Attachment**|
|10634|**Customer Service Key Value Configuration**|
|10635|**Master Entity Routing Configuration**|
|10636|**Routing Rule Set Setting**|
|10637|**Assignment Configuration**|
|10638|**Assignment Configuration Step**|
|10639|**Capacity Profile**|
|10640|**Overflow Action Config**|
|10641|**Preferred Agent**|
|10642|**Preferred Agent Customer Identity**|
|10643|**Preferred Agent Routed Entity**|
|10644|**Routing configuration**|
|10645|**Routing configuration step**|
|10646|**Custom messaging account**|
|10647|**Channel Configuration**|
|10648|**Channel State Configuration**|
|10649|**Provisioning State**|
|10650|**AdminAppState**|
|10651|**Agent Status history**|
|10652|**Power BI Configuration**|
|10653|**Authentication Settings**|
|10654|**Auth Settings Entry**|
|10655|**Quick reply**|
|10656|**Entity Routing Context**|
|10657|**Channel Capability**|
|10658|**Conversation Action**|
|10659|**Conversation Action Locale**|
|10660|**Conversation Message Block**|
|10661|**DeletedConversation**|
|10662|**Deprecated Workstream Entity Configuration**|
|10663|**Entity**|
|10664|**Ongoing conversation (Deprecated)**|
|10665|**Live work item event**|
|10666|**Work Stream**|
|10667|**Masking Rule**|
|10668|**Auto block rule**|
|10669|**Bot Channel Registration Secret**|
|10670|**Omnichannel channel api conversation privilege**|
|10671|**Omnichannel channel api message privilege**|
|10672|**Channel api method mapping**|
|10673|**External context**|
|10674|**Flagged spam**|
|10675|**Language**|
|10676|**Conversation**|
|10679|**Context item value**|
|10680|**Live Work Item Participant (Deprecated)**|
|10681|**Conversation Sentiment**|
|10682|**Context variable**|
|10683|**Localization**|
|10684|**OC Payment Profile**|
|10685|**Recording**|
|10686|**Omnichannel Request**|
|10687|**Rich message**|
|10688|**Rich object map**|
|10689|**Rule Item**|
|10690|**Sentiment daily topic**|
|10691|**Sentiment daily topic keyword**|
|10692|**Sentiment daily topic trending**|
|10693|**Session**|
|10694|**Session Participant Event**|
|10695|**Session Sentiment**|
|10696|**Message**|
|10697|**Tag**|
|10698|**Geo Location Provider**|
|10699|**Omnichannel Configuration**|
|10700|**Omnichannel Personalization**|
|10701|**Omnichannel Queue (Deprecated)**|
|10702|**Omnichannel Sync Config**|
|10703|**Operating Hour**|
|10704|**Personal quick reply**|
|10705|**Personal sound setting**|
|10706|**Persona Security Role Mapping**|
|10707|**Presence**|
|10708|**Provider**|
|10709|**RoutingRequest**|
|10710|**Search Configuration**|
|10711|**Sentiment analysis**|
|10712|**Session event**|
|10713|**Session participant**|
|10714|**Audio File**|
|10715|**Sound notification setting**|
|10716|**Transcript**|
|10717|**UR notification template**|
|10718|**UR Notification Template Mapping**|
|10719|**User settings**|
|10720|**Self service**|
|10727|**Agent capacity update history**|
|10728|**Bookable Resource Capacity Profile**|
|10729|**Work stream capacity profile**|
|10730|**Conversation Capacity profile**|
|10731|**Agent Capacity Profile Unit**|
|10732|**Agent Channel State**|
|10733|**Agent Status**|
|10734|**Conversation Characteristic**|
|10735|**Session Characteristic**|
|10736|**Skill Attachment Rule**|
|10737|**Attach Skill**|
|10738|**Model training details**|
|10739|**Training data import configuration**|
|10740|**Characteristic mapping**|
|10741|**Training record**|
|10742|**Skill finder model**|
|10743|**Effort estimate**|
|10744|**Effort estimation model**|
|10745|**Effort model training details**|
|10746|**ConversationInsight**|
|10747|**Active ICD Extension**|
|10748|**Entity-Workstream Map**|
|10749|**ICD Extension**|
|10750|**Omnichannel agent assignment custom api privilege**|
|10751|**Conversation Action Item**|
|10752|**Conversation Aggregated Insights**|
|10753|**Comment**|
|10754|**Conversation Participant Insights**|
|10755|**Conversation Participant Sentiment**|
|10756|**Conversation Question**|
|10757|**Conversation Segment Sentiment**|
|10758|**Conversation Sentiment**|
|10759|**Conversation Signal**|
|10760|**Conversation Subject**|
|10761|**Conversation Summary Suggestion**|
|10762|**Conversation System Tag**|
|10763|**Conversation Tag**|
|10764|**Recording**|
|10765|**SCI Conversation**|
|10766|**Custom Email Highlight**|
|10767|**Custom Highlight**|
|10768|**Custom Publisher**|
|10769|**EnvironmentSettings**|
|10770|**UserSettings**|
|10771|**CatalogEventStatusConfiguration**|
|10772|**Configuration**|
|10773|**Trigger**|
|10774|**Triggers To Sdk Message Processing Steps**|
|10775|**EventParameterMetadata**|
|10776|**TrackingContext**|
|10777|**Marketing feature configuration**|
|10778|**msdynmkt_experimentv2**|
|10779|**ACS channel instance**|
|10780|**ACS channel instance account**|
|10781|**Infobip channel instance**|
|10782|**Infobip channel instance account**|
|10783|**Link mobility channel instance**|
|10784|**Link mobility channel instance account**|
|10785|**MockSmsProvider channel instance**|
|10786|**MockSmsProvider channel instance account**|
|10787|**TeleSign channel instance**|
|10788|**TeleSign channel instance account**|
|10789|**Twilio channel instance**|
|10790|**Twilio channel instance account**|
|10791|**Vibes channel instance**|
|10792|**Vibes channel instance account**|
|10793|**Predefined Placeholder**|
|10794|**Metadata Entity Relationship**|
|10795|**Metadata Item**|
|10796|**Metadata Store State**|
|10797|**DigitalSellingActiveTask**|
|10798|**DigitalSellingCompletedTask**|
|10799|**Sales Tag**|
|10800|**Sequence**|
|10801|**Sequence Stat**|
|10802|**Sequence Target**|
|10803|**Sequence Target Step**|
|10804|**Sequence Template**|
|10806|**sabackupdiagnostic**|
|10807|**SABatchRunInstance**|
|10808|**salesroutingdiagnostic**|
|10809|**SARunInstance**|
|10810|**Segment**|
|10811|**segmentsetting**|
|10812|**Segment property**|
|10813|**SegmentsUtil**|
|10814|**Assignment Rule**|
|10815|**Seller attribute**|
|10816|**Seller attribute value**|
|10817|**Assignment Map**|
|10818|**Sales Assignment Setting**|
|10819|**Sales routing run**|
|10821|**Extended User Setting**|
|10822|**Sales acceleration insights**|
|10823|**Sales Acceleration settings**|
|10824|**Insight**|
|10825|**Work List Suggestion**|
|10826|**Work list suggestion source**|
|10827|**Work List View Configuration**|
|10828|**Work Queue Record**|
|10829|**Work Queue Record State**|
|10830|**Work list user setting**|
|10831|**WQDataSource**|
|10832|**Suggestion Assignment Rule**|
|10833|**Suggestion Principal Object Access**|
|10834|**Suggestion Seller Priority**|
|10835|**Data Hygiene Setting Info**|
|10836|**Duplicate Detection Plugin Run**|
|10837|**Duplicate Lead Mapping**|
|10838|**Lead Hygiene Setting**|
|10839|**Linked Entity Attribute Validity**|
|10840|**Sales provisioning request**|
|10841|**SalesOmnichannel Message**|
|10842|**Text message template**|
|10843|**Data Analytics Admin Settings (Deprecated)**|
|10844|**Data Analytics Report**|
|10845|**Insights**|
|10846|**Sales acceleration reports**|
|10848|**Bot Session**|
|10849|**conversationsuggestionrequestpayload**|
|10850|**Data Analytics User Customized Report**|
|10851|**Data Analytics Dataset**|
|10852|**Data Analytics Workspace**|
|10853|**Report Bookmark**|
|10854|**Agent Resource Forecasting**|
|10855|**[Deprecated] Dynamics Customer Service Analytics**|
|10856|**Case Topic**|
|10857|**Case Topic Setting**|
|10858|**Case Topic Summary**|
|10859|**Case topic Incident mapping**|
|10860|**Customer Service historical analytics**|
|10861|**Forecast (preview)**|
|10862|**Knowledge analytics**|
|10863|**Forecast Summary and Setting**|
|10864|**Keywords Description Suggestion Setting**|
|10865|**Conversation Summary Interaction**|
|10866|**Conversation Summary Setting**|
|10867|**Conversation Topic**|
|10868|**Conversation Topic Setting**|
|10869|**Conversation Topic Summary**|
|10870|**Conversation topic Conversation mapping**|
|10871|**Omnichannel historical analytics**|
|10872|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|10873|**Omnichannel Realtime analytics**|
|10963|**Bookable Resource Association**|
|10964|**Actual**|
|10965|**Requirement Characteristic**|
|10966|**Requirement Organization Unit**|
|10967|**Client Extension**|
|10968|**Requirement Group**|
|10969|**Configuration**|
|10970|**Booking Setup Metadata**|
|10971|**Three-Dimensional Model**|
|10972|**Booking Alert**|
|10973|**Booking Alert Status**|
|10974|**Booking Change**|
|10975|**Booking Rule**|
|10976|**Business Closure**|
|10977|**Organizational Unit**|
|10978|**Priority**|
|10979|**Requirement Relationship**|
|10980|**Requirement Resource Category**|
|10981|**Requirement Resource Preference**|
|10982|**Requirement Status**|
|10983|**Resource Requirement**|
|10984|**Resource Requirement Detail**|
|10985|**Resource Territory**|
|10986|**Schedule Board Setting**|
|10987|**Scheduling Parameter**|
|10988|**System User Scheduler Setting**|
|10989|**Fulfillment Preference**|
|10990|**Time Group Detail**|
|10991|**Transaction Origin**|
|10992|**Work Template**|
|10993|**Requirement Change**|
|10994|**Requirement Dependency**|
|10995|**Scheduling Feature Flag**|
|10996|**Inspection Template**|
|10997|**Inspection Attachment**|
|10998|**Inspection Template Version**|
|10999|**Inspection**|
|11000|**Inspection Response**|
|11001|**Time Entry**|
|11002|**Time Source**|
|11003|**Functional Location Type**|
|11004|**Location Template Association**|
|11005|**Functional Location Type Template Association**|
|11006|**Property Location Association**|
|11007|**Warranty**|
|11011|**Payment Term**|
|11012|**Purchase Order**|
|11013|**Purchase Order Product**|
|11014|**Purchase Order Receipt**|
|11015|**Purchase Order Receipt Product**|
|11016|**Ship Via**|
|11017|**Tax Code**|
|11018|**Tax Code Detail**|
|11019|**Warehouse**|
|11020|**Agreement**|
|11021|**Agreement Booking Date**|
|11022|**Agreement Booking Incident**|
|11023|**Agreement Booking Product**|
|11024|**Agreement Booking Service**|
|11025|**Agreement Booking Service Task**|
|11026|**Agreement Booking Setup**|
|11027|**Agreement Invoice Date**|
|11028|**Agreement Invoice Product**|
|11029|**Agreement Invoice Setup**|
|11030|**Agreement Substatus**|
|11031|**Booking Journal**|
|11032|**Booking Timestamp**|
|11033|**Purchase Order Business Process**|
|11034|**Case to Work Order Business Process**|
|11035|**Agreement Business Process**|
|11036|**Work Order Business Process**|
|11037|**Entitlement Application**|
|11038|**Field Service Price List Item**|
|11039|**Field Service Setting**|
|11040|**Field Service SLA Configuration**|
|11041|**Field Service System Job**|
|11042|**Incident Type**|
|11043|**Incident Type Characteristic**|
|11044|**Incident Type Product**|
|11045|**Incident Type Service**|
|11046|**Incident Type Service Task**|
|11047|**Incident Types Setup**|
|11048|**Incident Type Requirement Group**|
|11049|**Inventory Adjustment**|
|11050|**Inventory Adjustment Product**|
|11051|**Inventory Journal**|
|11052|**Inventory Transfer**|
|11053|**Order Invoicing Date**|
|11054|**Order Invoicing Product**|
|11055|**Order Invoicing Setup**|
|11056|**Order Invoicing Setup Date**|
|11057|**Payment**|
|11058|**Payment Detail**|
|11059|**Payment Method**|
|11060|**Postal Code**|
|11061|**Product Inventory**|
|11062|**Purchase Order Bill**|
|11063|**Purchase Order SubStatus**|
|11064|**Quote Booking Incident**|
|11065|**Quote Booking Product**|
|11066|**Quote Booking Service**|
|11067|**Quote Booking Service Task**|
|11068|**Quote Booking Setup**|
|11069|**Quote Invoicing Product**|
|11070|**Quote Invoicing Setup**|
|11071|**Resource Pay Type**|
|11072|**RMA**|
|11073|**RMA Product**|
|11074|**RMA Receipt**|
|11075|**RMA Receipt Product**|
|11076|**RMA SubStatus**|
|11077|**RTV**|
|11078|**RTV Product**|
|11079|**RTV Substatus**|
|11080|**Service Task Type**|
|11081|**Time Off Request**|
|11082|**Unique Number**|
|11083|**Work Order**|
|11084|**Work Order Characteristic (Deprecated)**|
|11085|**Work Order Details Generation Queue (Deprecated)**|
|11086|**Work Order Incident**|
|11087|**Work Order Product**|
|11088|**Resource Restriction (Deprecated)**|
|11089|**Work Order Service**|
|11090|**Work Order Service Task**|
|11091|**Work Order Substatus**|
|11092|**Work Order Type**|
|11094|**Bookable Resource Booking Quick Note**|
|11095|**Field Service Frontline Worker Configuration**|
|11098|**Incident Type Suggestion Result**|
|11099|**Incident Type Suggestion Run History**|
|11100|**Incident Type Resolution**|
|11101|**Insurance**|
|11102|**Not-to-exceed**|
|11103|**Asset Suggestion**|
|11104|**Problematic Asset Feedback**|
|11105|**Resolution**|
|11106|**Trade**|
|11107|**Trade Coverage**|
|11110|**Work order not-to-exceed**|
|11111|**Work Order Resolution**|
|11112|**CFS - IoT Alert Process Flow**|
|11113|**Geolocation Settings**|
|11114|**Geolocation Tracking**|
|11115|**Entity Configuration**|
|11116|**Geofence**|
|11117|**Geofence Event**|
|11118|**Geofencing Settings**|
|11119|**Asset Suggestions Setting**|
|11120|**Field service historical analytics**|
|11121|**Resource duration (preview)**|
|11122|**Predictive duration (preview)**|
|11123|**Predictive Work Hour Duration Setting**|
|11124|**Field Service Summary Configuration**|
|11125|**MobileSource**|
|11126|**Content Snippet**|
|11127|**Page Template**|
|11128|**Site Marker**|
|11129|**Site Setting**|
|11130|**Web File**|
|11131|**Web Link**|
|11132|**Web Link Set**|
|11133|**Web Notification URL**|
|11134|**Web Page**|
|11135|**Web Role**|
|11136|**Website**|
|11139|**Ad**|
|11140|**Ad Placement**|
|11141|**Alert Subscription**|
|11142|**Column Permission**|
|11143|**Column Permission Profile**|
|11144|**Table Permission**|
|11145|**Page Alert**|
|11146|**Page Notification**|
|11147|**Page Tag**|
|11148|**Poll**|
|11149|**Poll Option**|
|11150|**Poll Placement**|
|11151|**Poll Submission**|
|11152|**Portal Language**|
|11153|**Publishing State**|
|11154|**Publishing State Transition Rule**|
|11155|**Redirect**|
|11156|**Shortcut**|
|11157|**Tag**|
|11158|**URL History**|
|11159|**Web File Log**|
|11160|**Web Page Access Control Rule**|
|11161|**Web Page History**|
|11162|**Web Page Log**|
|11163|**Website Access**|
|11164|**Website Binding**|
|11165|**Website Language**|
|11166|**Web Template**|
|11180|**Change Password for Portals Contact**|
|11181|**Basic Form**|
|11182|**Basic Form Metadata**|
|11183|**List**|
|11184|**Multistep Form**|
|11185|**Multistep Form Metadata**|
|11186|**Form Step**|
|11187|**Bot Consumer**|
|11188|**Cloud Flow Consumer**|
|11190|**Web Notification Entity**|
|11191|**Site Migration Chunk**|
|11192|**Site Migration Run**|
|11193|**Website Migration Tracker**|
|11194|**Bing Map Lookup**|
|11196|**Forum**|
|11197|**Forum Access Permission**|
|11198|**Forum Alert**|
|11199|**Forum Announcement**|
|11200|**Forum Post**|
|11201|**Forum Thread**|
|11202|**Forum Notification**|
|11203|**Forum Thread Type**|
|11208|**Case Deflection**|
|11209|**Content Access Level**|
|11216|**3D Object**|
|11217|**Localized 3D Object**|
|11218|**3D Object Collection**|
|11219|**Localized 3D Object Collection**|
|11220|**Audio**|
|11221|**Guide**|
|11222|**Guide Completion Step Object**|
|11223|**Guide Completion Step Object Placement**|
|11224|**Guide Event**|
|11225|**Guide Operator Session**|
|11226|**Guide Session Step Visit**|
|11227|**Guide Step**|
|11228|**Guide Step Object**|
|11229|**Guide Step Object Placement**|
|11230|**Guide Task**|
|11231|**Guide View Configuration**|
|11232|**Image**|
|11233|**Localized Image**|
|11234|**Packaged Guide**|
|11235|**Packaged Guide Session Step Visit**|
|11236|**Packaged Guides Operator Session**|
|11237|**User Settings**|
|11238|**Video**|
|11239|**Localized Video**|
|11240|**MRAS Job**|
|11241|**Folder**|
|11242|**Guide Author Session**|
|11243|**MR App Session**|
|11244|**Object Anchor**|
|11245|**Diagnostics Data**|
|11246|**Optimization Request Booking**|
|11247|**Optimization Request Resource**|
|11248|**Scheduling Optimization Objective**|
|11249|**Scheduling Optimization Goal**|
|11250|**Scheduling Optimization Scope**|
|11251|**Scheduling Optimization Request**|
|11252|**Optimization Schedule**|
|11253|**Resource scheduling historical analytics**|
|11254|**channel**|
|11255|**Scenario**|
|11256|**Survey Answer Option**|
|11257|**Survey Response**|
|11258|**Survey Response Value**|
|11259|**Chat Widget Language(deprecated)**|
|11260|**Chat Widget**|
|11261|**Live Chat Context**|
|11262|**Chat Widget Location**|
|11263|**Localized Survey Question (Deprecated)**|
|11264|**Survey Question Sequence**|
|11265|**Survey Question**|
|11266|**Communication Provider Setting**|
|11267|**Communication Provider Setting Entry**|
|11268|**Phone Number**|
|11269|**Carrier**|
|11270|**SMS Number settings**|
|11271|**SMS Engagement Context**|
|11272|**SMS Number**|
|11273|**SMS Setting Secret**|
|11274|**Facebook Engagement Context**|
|11275|**Facebook Application**|
|11276|**Facebook Page**|
|11277|**Custom Messaging Engagement Context**|
|11278|**LINE Engagement Context**|
|11279|**Custom messaging channel**|
|11280|**LINE account**|
|11281|**Twitter account**|
|11282|**Twitter handle**|
|11283|**WeChat account**|
|11284|**WhatsApp account**|
|11285|**WhatsApp number**|
|11286|**Twitter Engagement Context**|
|11287|**WeChat Engagement Context**|
|11288|**WhatsApp Engagement Context**|
|11289|**Apple messages for business account**|
|11290|**Apple messages for business engagement context**|
|11291|**OC Apple Pay Entity**|
|11292|**Google's Business Messages agent account**|
|11293|**Google's Business Messages partner account**|
|11294|**Google's Business Messages engagement context**|
|11295|**Twitter Handle Provisioning Status**|
|11296|**OC Twitter Handle Secret**|
|11297|**Microsoft Teams account**|
|11298|**(Deprecated)Teams Engagement Context**|
|11299|**Teams Engagement Context**|
|11300|**Outbound Configuration**|
|11301|**Outbound message**|
|11302|**Gatekeeper Engagement Context**|
|11303|**Phone Call Engagement Context**|
|11304|**Phone Music**|
|11305|**Voice**|
|11306|**Voice Channel Language Setting**|
|11307|**Voice Channel Setting**|
|11308|**Voicemail**|
|11309|**Voice channel organization setting**|
|11310|**Voice workstream V2 migration status**|
|11311|**Sales Premium Demo**|
|11312|**Digital assets configuration**|
|11313|**File**|
|11314|**Keyword**|
|11315|**Video**|
|11318|**Content block**|
|11319|**Designer feature protection**|
|11320|**Tag**|
|11322|**Attendee Pass**|
|11323|**Authentication Settings**|
|11324|**EventMainBusinessProcessFlow**|
|11325|**(Deprecated) Bucket**|
|11326|**Building**|
|11327|**Check-in**|
|11328|**Custom Registration Field**|
|11329|**Entity Counter**|
|11330|**Event**|
|11331|**Event administration**|
|11332|**Event Analytics**|
|11333|**Event Custom Registration Field**|
|11334|**Event Management Activity**|
|11335|**Event Management Configuration**|
|11336|**Event Purchase**|
|11337|**Event Purchase Attendee**|
|11338|**Event Purchase Contact**|
|11339|**Event Purchase Pass**|
|11340|**Event Registration**|
|11341|**Event Registration Ticket**|
|11342|**Event Team Member**|
|11343|**Event Vendor**|
|11344|**(Deprecated) File**|
|11345|**Hotel**|
|11346|**Hotel Room Allocation**|
|11347|**Hotel Room Reservation**|
|11348|**Layout**|
|11349|**Pass**|
|11350|**Registration Response**|
|11351|**Room**|
|11352|**Room Reservation**|
|11353|**Session**|
|11354|**Session Registration**|
|11355|**Session Track**|
|11356|**Speaker**|
|11357|**Speaker Engagement**|
|11358|**Sponsorable Article**|
|11359|**Sponsorship**|
|11360|**Venue**|
|11361|**Waitlist Item**|
|11362|**Web application**|
|11363|**Webinar configuration**|
|11364|**Webinar Consent**|
|11365|**Webinar provider**|
|11366|**Webinar Type**|
|11367|**Website table configuration**|
|11377|**Appointment activity marketing template**|
|11378|**CDN configuration**|
|11379|**Analytics configuration**|
|11380|**Content settings**|
|11381|**Customer insights information**|
|11382|**Customer journey**|
|11383|**Custom channel activity**|
|11384|**Customer journey iteration**|
|11385|**Customer journey runtime state**|
|11386|**Customer journey template**|
|11387|**Customer journey workflow link**|
|11388|**Default settings**|
|11389|**Form page**|
|11390|**Form page template**|
|11391|**Geo pin**|
|11392|**List Form**|
|11393|**Live Entity Dependency**|
|11394|**Marketing configuration**|
|11395|**Marketing Data Import**|
|11396|**Dynamic-content metadata**|
|11397|**Marketing email**|
|11398|**Marketing email dynamic-content metadata**|
|11399|**Marketing email template**|
|11400|**Marketing Email Test**|
|11401|**Marketing Email Test Attribute**|
|11402|**Marketing email test send**|
|11403|**Marketing field submission**|
|11404|**Marketing form**|
|11405|**Marketing form field**|
|11406|**Marketing form submission**|
|11407|**Marketing form template**|
|11408|**Form whitelist rule**|
|11409|**Marketing page**|
|11410|**Landing page**|
|11411|**Marketing page template**|
|11412|**Form matching**|
|11413|**Form matching attributes**|
|11414|**Marketing activity**|
|11415|**Phone-call activity marketing template**|
|11416|**Portal settings**|
|11417|**Redirect URL**|
|11418|**Segment**|
|11419|**Segment Template**|
|11420|**Domain**|
|11421|**Task activity marketing template**|
|11422|**UIC config**|
|11423|**User geo region**|
|11424|**User Setting**|
|11425|**Marketing website**|
|11433|**Lead score (Deprecated)**|
|11434|**Lead Scoring Model**|
|11435|**Lead score**|
|11436|**Scoring configuration**|
|11437|**Lead to opportunity**|
|11438|**Lead Entity Field**|
|11439|**LinkedIn Account**|
|11440|**LinkedIn Activity**|
|11441|**LinkedIn Campaign**|
|11442|**LinkedIn Lead Gen Integration Configuration**|
|11443|**Field mapping**|
|11444|**LinkedIn Lead Gen Form**|
|11445|**LinkedIn Form Submission Answer**|
|11446|**LinkedIn Form Question**|
|11447|**LinkedIn Lead Gen Form Submission**|
|11448|**LinkedIn matching**|
|11449|**LinkedIn User Profile**|
|11452|**Appointment activity**|
|11453|**Create Lead Activity**|
|11454|**Delay (date and time) Activity**|
|11455|**Delay (duration) Activity**|
|11456|**Launch Workflow Activity**|
|11457|**LinkedIn Campaign Activity**|
|11458|**Marketing Email Activity**|
|11459|**Marketing form activity**|
|11460|**Phone call activity**|
|11461|**Record Update Activity**|
|11462|**Segment Activity**|
|11463|**Source Activity**|
|11464|**Splitter Activity**|
|11465|**Task activity**|
|11466|**Trigger activity**|
|11467|**Deprecated custom tile activity**|
|11468|**(Deprecated) Event activity**|
|11469|**(Deprecated) Customer Voice survey activity**|
|11470|**(Deprecated) Page activity**|
|11473|**Quota info entity**|
|11474|**Marketing feature configuration**|
|11475|**Data protection**|
|11476|**GDPR consent change record**|
|11477|**LinkedIn Matched Audience**|
|11478|**Network page**|
|11479|**Post ingishts**|
|11480|**Reaction**|
|11481|**Social post**|
|11482|**Social media account**|
|11483|**Social Posting Consent**|
|11484|**Spam Score Activity**|
|11485|**Spam Score Request**|
|11486|**Gwennol feature configuration**|
|11487|**Quick Send Email**|
|11488|**Email key point**|
|11489|**GPT-3 Log**|
|11490|**Personalized page**|
|11491|**Personalized page field**|
|11492|**Migration**|
|11493|**Segment**|
|11494|**Segment usage**|
|11495|**Segment Definition**|
|11496|**Segment Execution**|
|11497|**Quiet Time Setting**|
|11498|**Channel Map**|
|11499|**Journey Instance**|
|11500|**Workflow Resume Map**|
|11501|**Workflow Trigger Map**|
|11502|**Consent Provider**|
|11503|**Consent provider Localization**|
|11504|**(Deprecated) Compliance**|
|11505|**(Deprecated) Compliance**|
|11506|**Compliance profile**|
|11507|**Consent**|
|11508|**CXP Consent Center Configuration**|
|11509|**Consent Provider Default Configuration**|
|11510|**Default purpose**|
|11511|**Consent System Configuration**|
|11512|**(Deprecated) Contact Point Consent**|
|11513|**(Deprecated) Contact Point Consent**|
|11514|**(Deprecated) Contact Point Consent**|
|11515|**Contact Point Consent**|
|11516|**Contact Point Settings**|
|11517|**CXP Customer Data Mapping**|
|11518|**Customer Data Selection**|
|11519|**Preference Center**|
|11520|**Preference center link**|
|11521|**Purpose**|
|11522|**Topic**|
|11524|**Custom Goal Category**|
|11525|**Experiment**|
|11526|**Journey**|
|11527|**Journey dependency**|
|11528|**Journey Event**|
|11529|**JourneyOptimizationCount**|
|11530|**Journey Run Parameter**|
|11531|**Journey Run Session**|
|11532|**Journey settings**|
|11533|**Journey Template**|
|11534|**JourneyWorkflowMapping**|
|11535|**Optimization Customer Count**|
|11536|**Optimization Decision**|
|11537|**Segment**|
|11538|**Virtual Segment Data Source**|
|11539|**msdynmkt_aimodelversion**|
|11540|**msdynmkt_apsconfig**|
|11541|**msdynmkt_conversioneventdefinition**|
|11542|**Custom channel message**|
|11543|**Keyword**|
|11544|**Text message**|
|11545|**Text message sender**|
|11546|**SMS Phone Number Data Source**|
|11547|**SmsSubmission**|
|11548|**CMS AddOn**|
|11549|**Commerce Data Source**|
|11550|**Asset**|
|11551|**File**|
|11552|**Image**|
|11553|**Rich fragment**|
|11554|**Text fragment**|
|11555|**Video**|
|11556|**UTM tracking**|
|11557|**Image context**|
|11558|**QR code style**|
|11559|**Button style**|
|11560|**imagestyle**|
|11561|**Email**|
|11562|**Email template**|
|11563|**Mobile app channel instance**|
|11564|**Push device registration result**|
|11565|**Push mobile device**|
|11566|**App Registration Data Source**|
|11567|**Mobile app configuration**|
|11568|**Mobile app configuration**|
|11569|**Mobile device**|
|11570|**Push notification**|
|11571|**Domain**|
|11572|**Virtual Domain**|
|11573|**Virtual Domain Data Source**|
|11574|**Content block**|
|11575|**Tag**|
|11579|**Teams Engagement**|
|11580|**Webinar Email Journey**|
|11581|**Brand profile**|
|11582|**Sender**|
|11583|**Brand theme**|
|11584|**Frequency Cap Settings**|
|11585|**Captcha**|
|11586|**Created Entity Link**|
|11587|**Field Submission**|
|11588|**Form**|
|11589|**Form field**|
|11590|**Form Submission**|
|11591|**Form Template**|
|11592|**Matching Strategy**|
|11593|**Matching Strategy Attribute**|
|11594|**Submit Button**|
|11595|**Event teams properties**|
|11596|**User token cache**|
|11597|**GdprRequest**|
|11598|**Entity Grade Distribution**|
|11599|**Entity Scoring Model**|
|11600|**Lead Qualification Model**|
|11601|**Entity Score Distribution**|
|11602|**DataAnalyticsReport_MKT**|
|11603|**inMail**|
|11604|**Message**|
|11605|**Smart Links Content Viewed**|
|11606|**LinkedIn Sales Navigator Configuration**|
|11607|**Profile Associations**|
|11608|**sales_linkedin_users_signedin_status**|
|11609|**sales_lisn_users_signedin_status**|
|11610|**ActivityMappingMetadataBase**|
|11611|**AdditionalEntityInfo**|
|11612|**AiBuilderCallbackTestHook**|
|11613|**AiBuilderModelMetadata**|
|11614|**AnalysisInstanceConfig**|
|11615|**AnalysisMetadata**|
|11616|**AzureMLWebService**|
|11617|**BusinessUnitConfiguration**|
|11618|**CdsaModelMetadata**|
|11619|**ClusterLoadMetadata**|
|11620|**ConflationCriteriaStatistics**|
|11621|**ConflationMetadata**|
|11622|**ConflationRun**|
|11623|**ConflationStatistics**|
|11624|**ConsentSettings**|
|11625|**DataflowMetadata**|
|11626|**DataPreparationMetadata**|
|11627|**DataQualityFeatureWiseMetadata**|
|11628|**DataQualityOverview**|
|11629|**DataQualityReport**|
|11630|**DatasetCatalog**|
|11631|**DataSourceMetadata**|
|11632|**DataTroubleshootingAccess**|
|11633|**DataverseEntityDataCleanupJobInfo**|
|11634|**DerivedEntityMetadata**|
|11635|**DiagnosticSetting**|
|11636|**DiscoveredCdsaModel**|
|11637|**DiscoveryOperation**|
|11638|**EnrichmentMetadata**|
|11639|**EnrichmentRun**|
|11640|**ExportConfig**|
|11641|**ExportConfigReport**|
|11642|**ExportedModuleConfiguration**|
|11643|**ExportSettings**|
|11644|**FeatureTemplate**|
|11645|**GraphMetadata**|
|11646|**HierarchyMetadata**|
|11647|**HostLoadMetadata**|
|11648|**ImportExportStatusMetadata**|
|11649|**InsightMetadata**|
|11650|**InsightsDataQualityReport**|
|11651|**InstanceMetrics**|
|11652|**InstancePartnerCatalog**|
|11653|**InstanceSearchConfiguration**|
|11654|**InstanceSettings**|
|11655|**IntelligenceWorkflowMetadata**|
|11656|**IntelligenceWorkflowRunMetadata**|
|11657|**IntelligenceWorkspaceMetadata**|
|11658|**KeyVaultMetadata**|
|11659|**LightCdsaModelMetadata**|
|11660|**LogicAppsSubscriberMetadata**|
|11661|**MappedSecretMetadata**|
|11662|**MeasureMetadata**|
|11663|**ModelConfigMetadata**|
|11664|**ModuleConfigurationReference**|
|11665|**NotificationCheckpoint**|
|11666|**PackageImportMetadata**|
|11667|**PackageJobMetadata**|
|11668|**PackageMetadata**|
|11669|**PlatformInstanceMapping**|
|11670|**PowerPlatformConnector**|
|11671|**PowerPlatformRefreshSignalMetadata**|
|11672|**PreEnrichmentMetadata**|
|11673|**ProfileStoreStateInfo**|
|11674|**RealTimeAggregatedStats**|
|11675|**RealtimeM3Configuration**|
|11676|**RealtimeM3SearchConfiguration**|
|11677|**RealTimePluginMetadata**|
|11678|**RealtimeSystemTableMetadata**|
|11679|**RealTimeTableMetadata**|
|11680|**RefreshHistoryMetadata**|
|11681|**RefreshScheduleBase**|
|11682|**RefreshStateHistoryMetadata**|
|11683|**RelationshipMetadata**|
|11684|**ReportMetadata**|
|11685|**ResetInstanceHistory**|
|11686|**ResourceMetadata**|
|11687|**RuntimeRealtimeM3Metadata**|
|11688|**SegmentMetadata**|
|11689|**SemanticEntityMappingMetadata**|
|11690|**SparkJobExecutionMetadata**|
|11691|**SystemIntegrationMigrationTrackingInfo**|
|11692|**TemplatedMeasureMetadata**|
|11693|**TemplatedSegmentMetadata**|
|11694|**TransformMetadata**|
|11695|**UnifiedActivityMappingGroupMetadata**|
|11696|**AttributeDataProfile**|
|11697|**CIWorkflowJob**|
|11698|**CIWorkflowNode**|
|11699|**CIWorkflowTask**|
|11700|**EntityDataProfile**|
|11701|**IncrementalPartitionInfo**|
|11702|**IncrementalWatermarkInfo**|
|11703|**MeasureScalarOutput**|
|11704|**SemanticMapping**|
|11705|**AlternateKey**|
|11706|**CustomerMeasure**|
|11707|**CustomerProfile**|
|11708|**CustomerProfileSegment**|
|11709|**Enrichment**|
|11710|**Prediction**|
|11711|**UnifiedActivity**|
|11712|**UnifiedContactAlternateKey**|
|11713|**UnifiedContactSegment**|
|11714|**ContactProfile**|
|11715|**SegmentMembership**|
|11716|**UnifiedContact**|
|11717|**PersonalizationAction**|
|11718|**PersonalizationCookie**|
|11719|**PersonalizationUser**|
|11720|**PersonalizationView**|
|11722|**BlCfg**|
|11723|**Field Service Demo Data Job**|
|11724|**Sales usage telemetry reports**|
|11725|**Sales usage reporting**|
|11726|**PM Simulation**|
|11763|**Connected Field Services MDL Data Source**|
|11764|**unified_iotalert (Deprecated)**|
|11790|**ReCaptcha Configuration**|
|11795|**EntityFilterMetadata**|
|11796|**ai_bookableresourcebookingpwhd**|
|11797|**ai_bookableresourcebookingsuggestion**|
|11798|**ai_resourceefficiency**|
|11799|**ai_resourceefficiencysuggestion**|
|11800|**ai_resourcerequirementpwhd**|
|11801|**ai_resourcerequirementsuggestion**|
|11802|**ai_templatepwhd**|
|11803|**AIPluginAuth**|
|11808|**Lock Status**|
|11817|**ViewAsExampleQuestion**|
|11834|**Survey setting**|
|11847|**Copilot Analytics**|
|11848|**FederatedKnowledgeConfiguration**|
|11849|**FederatedKnowledgeEntityConfiguration**|
|11851|**Autonomous case creation and enrichment rules**|
|11857|**Form Mapping**|
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
- [msdyn_playbooktemplate_msdyn_playbookactivity](#BKMK_msdyn_playbooktemplate_msdyn_playbookactivity)
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

### <a name="BKMK_msdyn_playbooktemplate_msdyn_playbookactivity"></a> msdyn_playbooktemplate_msdyn_playbookactivity

One-To-Many Relationship: [msdyn_playbooktemplate msdyn_playbooktemplate_msdyn_playbookactivity](msdyn_playbooktemplate.md#BKMK_msdyn_playbooktemplate_msdyn_playbookactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_playbooktemplate`|
|ReferencedAttribute|`msdyn_playbooktemplateid`|
|ReferencingAttribute|`msdyn_playbooktemplateid`|
|ReferencingEntityNavigationPropertyName|`msdyn_playbooktemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

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

