---
title: "msdyn_callablecontext table/entity reference"
description: "Includes schema information and supported messages for the msdyn_callablecontext table/entity."
ms.date: 02/27/2024
ms.service: "dynamics-365-sales"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "lavanyakr01"
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.audienceType: 
  - developer
---

# msdyn_callablecontext table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).



**Added by**: Playbook Solution


## Messages

|Message|Web API Operation|SDK class or method|
|-|-|-|
|Assign|PATCH /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|BulkRetain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Create|POST /msdyn_callablecontexts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|DELETE /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|PurgeRetainedContent|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Retain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|Retrieve|GET /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET /msdyn_callablecontexts<br />See [Query Data](/powerapps/developer/data-platform/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|RollbackRetain|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||
|SetState|PATCH /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH /msdyn_callablecontexts(*msdyn_callablecontextid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
|ValidateRetentionConfig|This message is to be executed only by Dataverse to trigger registered plug-ins and flows.||

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_callablecontexts|
|DisplayCollectionName|Playbook Callable Contexts|
|DisplayName|Playbook Callable Context|
|EntitySetName|msdyn_callablecontexts|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_callablecontexts|
|LogicalName|msdyn_callablecontext|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_callablecontextid|
|PrimaryNameAttribute|msdyn_EntityLogicalName|
|SchemaName|msdyn_callablecontext|

<a name="writable-attributes"></a>

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
|--------|-----|
|Description|Sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_callablecontextId"></a> msdyn_callablecontextId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Playbook calling record type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_callablecontextid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_EntityLogicalName"></a> msdyn_EntityLogicalName

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_EntityLogicalName|
|MaxLength|128|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_EntityOTC"></a> msdyn_EntityOTC

|Property|Value|
|--------|-----|
|Description|Internal Use Only|
|DisplayName|Record type|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_EntityOTC|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### msdyn_EntityOTC Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Account|Business that represents a customer or potential customer. The company that is billed in business transactions.|
|2|Contact|Person with whom a business unit has a relationship, such as customer, supplier, and colleague.|
|3|Opportunity|Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.|
|4|Lead|Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.|
|5|Note|Note that is attached to one or more objects, including other notes.|
|6|Business Unit Map|Stores mapping attributes for business units.|
|7|Owner|Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.|
|8|User|Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.|
|9|Team|Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.|
|10|Business Unit|Business, division, or department in the Microsoft Dynamics 365 database.|
|14|System User Principal|For internal use only.|
|16|AccountLeads|description.|
|17|ContactInvoices||
|18|ContactQuotes||
|19|ContactOrders||
|20|Service Contract Contact|Item in a Service contract.|
|21|ProductSalesLiterature||
|22|ContactLeads||
|24|LeadCompetitors||
|25|OpportunityCompetitors||
|26|CompetitorSalesLiterature||
|27|LeadProduct||
|29|Subscription|For internal use only.|
|30|Filter Template|Template for a filter.|
|31|Privilege Object Type Code|For internal use only.|
|32|Sales Process Instance|Instance of a sales process.|
|33|Subscription Synchronization Information|For internal use only.|
|35|Tracking information for deleted entities|For internal use only.|
|36|Client update|Microsoft Dynamics 365 client for Outlook offline database update.|
|37|Subscription Manually Tracked Object|For internal use only.|
|42|SystemUser BusinessUnit Entity Map|Stores mapping attributes for business units.|
|44|Field Sharing|Defines CRM security principals (users and teams) access rights to secured field for an entity instance.|
|45|Subscription Statistic Offline|Subscription Statistic Offline|
|46|Subscription Statistic Outlook|Subscription Statistic Outlook|
|47|Subscription Sync Entry Offline|Used for offline sync, internal use only.|
|48|Subscription Sync Entry Outlook|Used for outlook sync, internal use only.|
|50|Position|Position of a user in the hierarchy|
|51|System User Manager Map|For internal use only.|
|52|User Search Facet||
|54|Global Search Configuration||
|55|FileAttachment|File Attachment|
|60|SystemUserAuthorizationChangeTracker|Internal authorization table to track user authorization changes|
|61|PrincipalEntityBusinessUnitMap|Internal authorization table to track user authorization changes|
|72|Record Filter|Record Access Filter|
|73|EntityRecordFilter|RecordFilter Object Type Codes|
|74|Secured Masking Rule|Secured Masking Rules to apply to fields.|
|78|Virtual Entity Data Provider|Developers can register plug-ins on a data provider to enable data access for virtual entities in the system.|
|85|Virtual Entity Data Source|Internal entity that stores data source information for all installed providers.|
|92|Team template|Team template for an entity enabled for automatically created access teams.|
|99|Social Profile|This entity is used to store social profile information of its associated account and contacts on different social channels.|
|101|Service Plan|Service Plan|
|103|Privileges Removal Setting|Privileges Removal Setting|
|112|Case|Service request case associated with a contract.|
|113|Child Incident Count|For internal use only.|
|123|Competitor|Business competing for the sale represented by a lead or opportunity.|
|126|Indexed Article|Article indexed for search purposes.|
|127|Article|Structured content that is part of the knowledge base.|
|129|Subject|Information regarding subjects available in the system.|
|132|Announcement|Announcement associated with an organization.|
|135|Activity Party|Person or group associated with an activity. An activity can have multiple activity parties.|
|150|User Settings|User's preferred settings.|
|300|Canvas App|An application built through a canvas-based editing experience.|
|301|Callback Registration|Callback Registration that stores configuration.|
|372|Connector|Connector Entity to support Solutioning Integration|
|373|Connection Instance||
|380|Environment Variable Definition|Contains information about the settable variable: its type, default value, and etc.|
|381|Environment Variable Value|Holds the value for the associated EnvironmentVariableDefinition entity.|
|400|AI Template||
|401|AI Model||
|402|AI Configuration||
|418|Dataflow||
|430|Entity Analytics Config|This entity contains information about which entities are enabled for Azure Data Lake Services integration|
|431|Image Attribute Configuration|Store configuration for each image attribute|
|432|Entity Image Configuration|Store image configuration for each entity|
|950|New Process|New Process Business Process Flow|
|951|Translation Process|Translation Process Business Process Flow|
|952|Phone To Case Process|Phone To Case Process Business Process Flow|
|953|Opportunity Sales Process|Opportunity Sales Process Business Process Flow|
|954|Lead To Opportunity Sales Process|Lead To Opportunity Sales Process Business Process Flow|
|955|Expired Process|Expired Process Business Process Flow|
|1001|Attachment|MIME attachment for an activity.|
|1002|Attachment|Attachment for an email activity.|
|1003|Internal Address|Storage of addresses for a user, business unit, or site.|
|1004|Competitor Address|Additional addresses for a competitor. The first two addresses are stored in the competitor object.|
|1006|Competitor Product|Association between a competitor and a product offered by the competitor.|
|1007|Image Descriptor|For internal use only.|
|1010|Contract|Agreement to provide customer service during a specified amount of time or number of cases.|
|1011|Contract Line|Line item in a contract that specifies the type of service a customer is entitled to.|
|1013|Discount|Price reduction made from the list price of a product or service based on the quantity purchased.|
|1016|Article Template|Template for a knowledge base article that contains the standard attributes of an article.|
|1017|Lead Address|Address information for a lead.|
|1019|Organization|Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.|
|1021|Organization UI|Entity customizations including form layout and icons. Includes current and past versions.|
|1022|Price List|Entity that defines pricing levels.|
|1023|Privilege|Permission to perform an action in Microsoft CRM. The platform checks for the privilege and rejects the attempt if the user does not hold the privilege.|
|1024|Product|Information about products and their pricing information.|
|1025|Product Association|Instance of a product added to a bundle or kit.|
|1026|Price List Item|Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.|
|1028|Product Relationship|Information about the selling relationship between two products, including the relationship type, such as up-sell, cross-sell, substitute, or accessory.|
|1030|System Form|Organization-owned entity customizations including form layout and dashboards.|
|1031|User Dashboard|User-owned dashboards.|
|1036|Security Role|Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.|
|1037|Role Template|Template for a role. Defines initial attributes that will be used when creating a new role.|
|1038|Sales Literature|Storage of sales literature, which may contain one or more documents.|
|1039|View|Saved query against the database.|
|1043|String Map|Mapping between strings.|
|1048|Property|Information about a product property.|
|1049|Property Option Set Item|Item with a name and value in a property option set type.|
|1055|Unit|Unit of measure.|
|1056|Unit Group|Grouping of units.|
|1070|Sales Attachment|Item in the sales literature collection.|
|1071|Address|Address and shipping information. Used to store additional addresses for an account or contact.|
|1072|Subscription Clients|For internal use only.|
|1075|Status Map|Mapping between statuses.|
|1080|Discount List|Type of discount specified as either a percentage or an amount.|
|1082|Article Comment|Comment on a knowledge base article.|
|1083|Opportunity Product|Association between an opportunity and a product.|
|1084|Quote|Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.|
|1085|Quote Product|Product line item in a quote. The details include such information as product ID, description, quantity, and cost.|
|1086|User Fiscal Calendar|Custom fiscal calendar used for tracking sales quotas.|
|1088|Order|Quote that has been accepted.|
|1089|Order Product|Line item in a sales order.|
|1090|Invoice|Order that has been billed.|
|1091|Invoice Product|Line item in an invoice containing detailed billing information for a product.|
|1094|Authorization Server|Authorization servers that trust this organization|
|1095|Partner Application|Partner applications registered for this organization|
|1111|System Chart|System chart attached to an entity.|
|1112|User Chart|Chart attached to an entity.|
|1113|Ribbon Tab To Command Mapping|A mapping between Tab Ids, and the Commands within those tabs.|
|1115|Ribbon Context Group|Groupings of contextual tabs.|
|1116|Ribbon Command|Ribbon Commands - the command definition, rules, etc.|
|1117|Ribbon Rule|Ribbon rule definitions, used to enable and disable, show and hide ribbon elements.|
|1120|Application Ribbons|Ribbon customizations for the application ribbon and entity ribbon templates.|
|1130|Ribbon Difference|All layout customizations to be applied to the ribbons, which contain only the differences from the base ribbon.|
|1140|Replication Backlog|Entity to hold replication backlog tasks. For internal use only.|
|1141|Characteristic|Skills, education and certifications of resources.|
|1142|Rating Value|A unique value associated with a rating model that allows providing a user friendly rating value.|
|1144|Rating Model|Represents a model to evaluate skills or other related entities.|
|1145|Bookable Resource Booking|Represents the line details of a resource booking.|
|1146|Bookable Resource Booking Header|Reservation entity representing the summary of the associated resource bookings.|
|1147|Bookable Resource Category|Categorize resources that have capacity into categories such as roles.|
|1148|Bookable Resource Characteristic|Associates resources with their characteristics and specifies the proficiency level of a resource for that characteristic.|
|1149|Bookable Resource Category Assn|Association entity to model the categorization of resources.|
|1150|Bookable Resource|Resource that has capacity which can be allocated to work.|
|1151|Bookable Resource Group|Associates resources with resource groups that they are a member of.|
|1152|Booking Status|Allows creation of multiple sub statuses mapped to a booking status option.|
|1189|Document Suggestions|Document Suggestions|
|1190|SuggestionCardTemplate|Templates for Suggestion Card in Grid|
|1200|Field Security Profile|Profile which defines access level for secured attributes|
|1201|Field Permission|Group of privileges used to categorize users to provide appropriate access to secured columns.|
|1203|Team Profiles|Team Profiles|
|1234|Channel Property Group|Group or collection of channel properties provided by the external channel for a Microsoft Dynamics 365 activity.|
|1235|Property Association|Association of a property definition with another entity in the system.|
|1236|Channel Property|Instance of a channel property containing its name and corresponding data type.|
|1300|SocialInsightsConfiguration|Configuration for the social insights.|
|1309|Saved Organization Insights Configuration|Saved configuration for the organization insights|
|1333|Property Instance|Instance of a property with its value.|
|1400|Sync Attribute Mapping Profile|Profile which defines sync attribute mapping|
|1401|Sync Attribute Mapping|Group of Sync-Attribute Mappings used to provide Attribute mappings during sync for a particular user|
|1403|Team Sync-Attribute Mapping Profiles|Team Sync-Attribute Mapping Profiles|
|1404|Principal Sync Attribute Map|Maps security principals (users and teams) to sync attribute mappings.|
|2000|Annual Fiscal Calendar|Year long fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|
|2001|Semiannual Fiscal Calendar|Calendar representing the semi-annual span of time during which the financial activities of an organization are calculated.|
|2002|Quarterly Fiscal Calendar|Quarterly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|
|2003|Monthly Fiscal Calendar|Monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|
|2004|Fixed Monthly Fiscal Calendar|Fixed monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|
|2010|Email Template|Template for an email message that contains the standard attributes of an email message.|
|2011|Contract Template|Template for a contract containing the standard attributes of a contract.|
|2012|Unresolved Address|For internal use only.|
|2013|Territory|Territory represents sales regions.|
|2015|Theme|Information that's used to set custom visual theme options for client applications.|
|2016|User Mapping|User Mapping|
|2020|Queue|A list of records that require action, such as accounts, activities, and cases.|
|2023|QueueItemCount|For internal use only.|
|2024|QueueMemberCount|For internal use only.|
|2027|License|Stores information about a Microsoft CRM license.|
|2029|Queue Item|A specific item in a queue, such as a case record or an activity record.|
|2500|User Entity UI Settings|Stores user settings for entity views.|
|2501|User Entity Instance Data|Per User item instance data|
|3000|Integration Status|Contains integration status information.|
|3005|Channel Access Profile|Information about permissions needed to access Dynamics 365 through external channels.For internal use only|
|3008|External Party|Information about external parties that need to access Dynamics 365 from external channels.For internal use only|
|3231|Connection Role|Role describing a relationship between a two records.|
|3233|Connection Role Object Type Code|Specifies the entity type that can play specific role in a connection.|
|3234|Connection|Relationship between two entities.|
|4000|Facility/Equipment|Resource that can be scheduled.|
|4001|Service|Activity that represents work done to satisfy a customer's need.|
|4002|Resource|User or facility/equipment that can be scheduled for a service.|
|4003|Calendar|Calendar used by the scheduling system to define when an appointment or activity is to occur.|
|4004|Calendar Rule|Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.|
|4005|Scheduling Group|Resource group or team whose members can be scheduled for a service.|
|4006|Resource Specification|Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.|
|4007|Resource Group|Group or collection of people, equipment, and/or facilities that can be scheduled.|
|4009|Site|Location or branch office where an organization does business. An organization can have multiple sites.|
|4010|Resource Expansion|Resource Expansions.|
|4011|Inter Process Lock|Inter Process Locks.|
|4023|Email Hash|Email activity hashes used for correlation purposes.|
|4101|Display String Map|Maps customized display strings to entities.|
|4102|Display String|Customized messages for an entity that has been renamed.|
|4110|Notification|For internal use only.|
|4120|Exchange Sync Id Mapping|The mapping used to keep track of the IDs for items synced between CRM and Exchange.|
|4200|Activity|Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.|
|4201|Appointment|Commitment representing a time interval with start/end times and duration.|
|4202|Email|Activity that is delivered using email protocols.|
|4204|Fax|Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.|
|4206|Case Resolution|Special type of activity that includes description of the resolution, billing status, and the duration of the case.|
|4207|Letter|Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.|
|4208|Opportunity Close|Activity that is created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.|
|4209|Order Close|Activity generated automatically when an order is closed.|
|4210|Phone Call|Activity to track a telephone call.|
|4211|Quote Close|Activity generated when a quote is closed.|
|4212|Task|Generic activity representing work needed to be done.|
|4214|Service Activity|Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.|
|4215|Commitment|For internal use only.|
|4216|Social Activity|For internal use only.|
|4220|UntrackedEmail|Activity that is delivered using UntrackedEmail protocols.|
|4230|Saved View|Saved database query that is owned by a user.|
|4231|Metadata Difference|Metadata Difference|
|4232|Business Data Localized Label|Business Data Localized Label|
|4250|Recurrence Rule|Recurrence Rule represents the pattern of incidence of recurring entities.|
|4251|Recurring Appointment|The Master appointment of a recurring appointment series.|
|4299|Email Search|Email Address Search Table.|
|4300|Marketing List|Group of existing or potential customers created for a marketing campaign or other sales purposes.|
|4301|Marketing List Member|Item in a marketing list.|
|4400|Campaign|Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.|
|4401|Campaign Response|Response from an existing or a potential new customer for a campaign.|
|4402|Campaign Activity|Task performed, or to be performed, by a user for planning or running a campaign.|
|4403|Campaign Item|Work item in a campaign, a list or sales literature.|
|4404|Campaign Activity Item|Work item of a campaign activity, such as a list or sales literature.|
|4405|Bulk Operation Log|Log used to track bulk operation execution, successes, and failures.|
|4406|Quick Campaign|System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.|
|4410|Data Import|Status and ownership information for an import job.|
|4411|Data Map|Data map used in import.|
|4412|Import Source File|File name of file used for import.|
|4413|Import Data|Unprocessed data from imported files.|
|4414|Duplicate Detection Rule|Rule used to identify potential duplicates.|
|4415|Duplicate Record|Potential duplicate record.|
|4416|Duplicate Rule Condition|Condition of a duplicate detection rule.|
|4417|Column Mapping|Mapping for columns in a data map.|
|4418|List Value Mapping|In a data map, maps list values from the source file to Microsoft Dynamics 365.|
|4419|Lookup Mapping|In a data map, maps a lookup attribute in a source file to Microsoft Dynamics 365.|
|4420|Owner Mapping|In a data map, maps ownership data from the source file to Microsoft Dynamics 365.|
|4421|Bookable Resource Booking to Exchange Id Mapping|The mapping used to keep track of the IDs for items synced between Dynamics 365 Bookable Resource Booking and Exchange.|
|4423|Import Log|Failure reason and other detailed information for a record that failed to import.|
|4424|Bulk Delete Operation|User-submitted bulk deletion job.|
|4425|Bulk Delete Failure|Record that was not deleted during a bulk deletion job.|
|4426|Transformation Mapping|In a data map, maps the transformation of source attributes to Microsoft Dynamics 365 attributes.|
|4427|Transformation Parameter Mapping|In a data map, defines parameters for a transformation.|
|4428|Import Entity Mapping|Mapping for entities in a data map.|
|4450|Data Performance Dashboard|Data Performance Dashboard.|
|4490|Office Document|Used to store Office Documents in database in binary format.|
|4500|Relationship Role|Relationship between an account or contact and an opportunity.|
|4501|Relationship Role Map|Mapping of the primary associated objects between which the relationship role is valid.|
|4502|Customer Relationship|Relationship between a customer and a partner in which either can be an account or contact.|
|4503|Opportunity Relationship|Relationship between an account or contact and an opportunity.|
|4545|Entitlement Template Product||
|4567|Auditing|Track changes to records for analysis, record keeping, and compliance.|
|4579|Ribbon Client Metadata.|A ribbon client metadata.|
|4600|Entity Map|Represents a mapping between two related entities so that data from one record can be copied into the form of a new related record.|
|4601|Attribute Map|Represents a mapping between attributes where the attribute values should be copied from a record into the form of a new related record.|
|4602|Plug-in Type|Type that inherits from the IPlugin interface and is contained within a plug-in assembly.|
|4603|Plug-in Type Statistic|Plug-in type statistic.|
|4605|Plug-in Assembly|Assembly that contains one or more plug-in types.|
|4606|Sdk Message|Message that is supported by the SDK.|
|4607|Sdk Message Filter|Filter that defines which SDK messages are valid for each type of entity.|
|4608|Sdk Message Processing Step|Stage in the execution pipeline that a plug-in is to execute.|
|4609|Sdk Message Request|For internal use only.|
|4610|Sdk Message Response|For internal use only.|
|4611|Sdk Message Response Field|For internal use only.|
|4613|Sdk Message Pair|For internal use only.|
|4614|Sdk Message Request Field|For internal use only.|
|4615|Sdk Message Processing Step Image|Copy of an entity's attributes before or after the core system operation.|
|4616|Sdk Message Processing Step Secure Configuration|Non-public custom configuration that is passed to a plug-in's constructor.|
|4618|Service Endpoint|Service endpoint that can be contacted.|
|4619|Plug-in Trace Log|Trace and exception information generated by plug-ins and custom workflow activities.|
|4700|System Job|Process whose execution can proceed independently or in the background.|
|4702|Workflow Wait Subscription|For internal use only.|
|4703|Process|Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.|
|4704|Process Dependency|Dependencies for a process.|
|4705|ISV Config|An XML document used to configure client extension controls.|
|4706|Process Log|Log used to track process execution.|
|4707|Application File|Files used by the application|
|4708|Organization Statistic|Statistics measuring the organization's usage of the Microsoft Dynamics 365 system over the past 24 hours.|
|4709|Site Map|XML data used to control the application navigation pane.|
|4710|Process Session|Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.|
|4711|Expander Event|For internal use only. An event that will be expanded into jobs whose executions can proceed in the background.|
|4712|Process Trigger|Trigger that invoke a rule.|
|4720|Flow Session|Entity to store the information that is generated when a Power Automate Desktop flow runs.|
|4724|Process Stage|Stage associated with a process.|
|4725|Business Process Flow Instance|Active path associated with every Business Process Flow instance|
|4800|Web Wizard|Definition for a Web-based wizard.|
|4802|Wizard Page|Page in a Web-based wizard.|
|4803|Web Wizard Access Privilege|Privilege needed to access a Web-based wizard.|
|4810|Time Zone Definition|Time zone definition, including name and time zone code.|
|4811|Time Zone Rule|Definition for time conversion between local time and Coordinated Universal Time (UTC) for a particular time zone at a particular time period.|
|4812|Time Zone Localized Name|Localized name of the time zone.|
|5000|Recently Used|Most recently used data table.|
|5004|NL2SQ Registration Information|Org registration status, AllowedEntity list, and registration error message.|
|6363|Entitlement Product||
|7000|System Application Metadata|For internal use only.|
|7001|User Application Metadata|For internal use only.|
|7100|Solution|A solution which contains CRM customizations.|
|7101|Publisher|A publisher of a CRM solution.|
|7102|Publisher Address|Address and shipping information. Used to store additional addresses for a publisher.|
|7103|Solution Component|A component of a CRM solution.|
|7104|Solution Component Definition|Contains all the information required to process a solution aware entity|
|7105|Dependency|A component dependency in CRM.|
|7106|Dependency Node|The representation of a component dependency node in CRM.|
|7107|Invalid Dependency|An invalid dependency in the CRM system.|
|7108|Dependency Feature|A dependency feature.|
|7200|RuntimeDependency|Form Level dependencies in CRM.|
|7272|Entitlement Contact||
|7755|ElasticFileAttachment|Elastic File Attachment|
|8000|Post|An activity feed post.|
|8001|Post Role|Represents the objects with which an activity feed post is associated. For internal use only.|
|8002|Post Regarding|Represents which object an activity feed post is regarding. For internal use only.|
|8003|Follow|Represents a user following the activity feed of an object.|
|8005|Comment|A comment on an activity feed post.|
|8006|Like|A like on an activity feed post.|
|8040|ACIViewMapper|Customized messages for an entity that has been renamed.|
|8050|Trace|A trace log.|
|8051|Trace Association|Represents the objects with which a trace record is associated. For internal use only.|
|8052|Trace Regarding|Represents which object a trace record is regarding. For internal use only.|
|8181|Routing Rule Set|Define Routing Rule to route cases to right people at the right time|
|8199|Rule Item|Please provide the description for entity|
|8700|AppModule Metadata|For internal use only.|
|8701|AppModule Metadata Dependency|For internal use only.|
|8702|AppModule Metadata Async Operation|For internal use only.|
|8840|Hierarchy Rule|Organization-owned entity customizations including mapping Quick view form with Relationship Id|
|9006|Model-driven App|A role-based, modular business app that provides task-based functionality for a particular area of work.|
|9007|App Module Component|A component available in a business app such as entity, dashboard, form, view, chart, and business process.|
|9009|App Module Roles|Security roles that have access to a business app.|
|9011|App Config Master|Contains the master list of all properties that can be customized for apps in Dynamics 365. For internal use only.|
|9012|App Configuration|Contains a mapping between an app configuration instance and an app, which defines the properties that can be customized for the app. Optionally, also contains navigation setting for an app. For internal use only.|
|9013|App Configuration Instance|Contains a property or a list of properties from the app configuration master list that can be customized for any app in Dynamics 365. For internal use only.|
|9100|Report|Data summary in an easy-to-read layout.|
|9101|Report Related Entity|Entities related to a report. A report can be related to multiple entities.|
|9102|Report Related Category|Categories related to a report. A report can be related to multiple categories.|
|9103|Report Visibility|Area in which to show a report. A report can be shown in multiple areas.|
|9104|Report Link|Links and dependencies between reports. A report may drill through to another report, or it may have another report as a sub-report.|
|9105|Currency|Currency in which a financial transaction is carried out.|
|9106|Mail Merge Template|Template for a mail merge document that contains the standard attributes of that document.|
|9107|Import Job|For internal use only.|
|9201|LocalConfigStore||
|9300|Record Creation and Update Rule|Defines the settings for automatic record creation.|
|9301|Record Creation and Update Rule Item|Defines the individual conditions required for creating records automatically.|
|9333|Web Resource|Data equivalent to files used in Web development. Web resources provide client-side components that are used to provide custom user interface elements.|
|9400|Channel Access Profile Rule|Defines the rules for automatically associating channel access profiles to external party records.For internal use only|
|9401|Channel Access Profile Rule Item|Defines the rule items of a profile rule set for the automated profile association.For internal use only|
|9502|SharePoint Site|SharePoint site from where documents can be managed in Microsoft Dynamics 365.|
|9507|Sharepoint Document|Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.|
|9508|Document Location|Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.|
|9509|SharePoint Data|SharePoint's Data Corresponding to a user , Record , Location and Page|
|9510|Rollup Properties|Stores properties related to rollup fields.|
|9511|Rollup Job|Stores rollup jobs.|
|9600|Goal|Target objective for a user or a team for a specified time period.|
|9602|Rollup Query|Query that is used to filter the results of the goal rollup.|
|9603|Goal Metric|Type of measurement for a goal, such as money amount or count.|
|9604|Rollup Field|Field to be rolled up to calculate the actual and in-progress values against the goal.|
|9605|Email Server Profile|Holds the Email Server Profiles of an organization|
|9606|Mailbox||
|9607|Mailbox Statistics|Stores data regarding Mailbox processing cycles|
|9608|Mailbox Auto Tracking Folder|Stores data about what folders for a mailbox are auto tracked|
|9609|Mailbox Tracking Category|Stores data about what categories for a mailbox are tracked|
|9650|Process Configuration|For internal use only.|
|9690|Organization Insights Notification|Stores data regarding organization insights notification|
|9699|Organization Insights Metric|Stores data regarding organization insights metric|
|9700|Entitlement|Defines the amount and type of support a customer should receive.|
|9701|Entitlement Channel|Defines the amount and type of support for a channel.|
|9702|Entitlement Template|Contains predefined customer support terms that can be used to created entitlements for customers.|
|9703|Entitlement Template Channel|Contains predefined support terms for a channel to create entitlements for customers.|
|9704|Entitlement Entity Allocation Type Mapping|Mapping to define which Allocation Types are available for Entity Type to be used on Entitlement|
|9750|SLA|Contains information about the tracked service-level KPIs for cases that belong to different customers.|
|9751|SLA Item|Contains information about a tracked support KPI for a specific customer.|
|9752|SLA KPI Instance|Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case|
|9753|Custom Control|For internal use only.|
|9754|Custom Control Resource|Custom Control Resource Id|
|9755|Custom Control Default Config|For internal use only.|
|9800|Entity||
|9808|Attribute||
|9809|OptionSet||
|9810|Entity Key||
|9811|Entity Relationship||
|9812|Managed Property||
|9813|Relationship Entity||
|9814|Relationship Attribute|Stores relationship attributes mapping for Multi-predicate relationship|
|9815|Entity Index|Metadata describing index of an entity|
|9816|Index Attribute|Stores index attributes|
|9820|Attribute Masking Rule|Defines masking rule of attribute|
|9866|Mobile Offline Profile|Information to administer and manage the data available to mobile devices in offline mode.|
|9867|Mobile Offline Profile Item|Information on entity availability to mobile devices in offline mode for a mobile offline profile item.|
|9868|Mobile Offline Profile Item Association|Information on relationships to be used to follow related entity's records for mobile offline profile item.|
|9869|Sync Error|Failure reason and other detailed information for a record that failed to sync.|
|9870|Offline Command Definition|For internal use only.|
|9875|Language Provisioning State|Container for language provisioning checkpoint states|
|9880|Ribbon Metadata To Process|Container for Ribbon Metadata To Process|
|9890|SolutionHistoryData|solution history data|
|9900|Navigation Setting|Navigation Setting: A setting page or group of pages available for configuration within an app. A record representing a group of pages is regarded as the parent navigation setting of one or more other records. For internal use only.|
|9910|MultiEntitySearch|Multi Entity Search.|
|9912|Multi Select Option Value|Multi Select Option Value|
|9919|Hierarchy Security Configuration||
|9930|Knowledge Base Record|Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.|
|9931|Incident KnowledgeBaseRecord||
|9932|Time Stamp Date Mapping|For internal use only.`|
|9936|Azure Service Connection|Stores connection information for an Azure service|
|9940|Document Template|Used to store Document Templates in database in binary format.|
|9941|Personal Document Template|Used to store Personal Document Templates in database in binary format.|
|9942|Topic Model Configuration|Configuration settings for identification of topics using text analytics.|
|9943|Topic Model Execution History|Entity for Topic Model Execution History|
|9944|Topic Model|The model for automatic identification of topics using text analytics.|
|9945|Text Analytics Entity Mapping||
|9946|Topic History|Entity for Topic History|
|9947|Knowledge Search Model|Configuration for automatic suggestion of knowledge articles using text analytics and search|
|9948|Text Analytics Topic|Text Analytics Topics|
|9949|Advanced Similarity Rule|A text match rule identifies similar records using keywords and key phrases determined with text analytics|
|9950|Office Graph Document|Office Graph Documents Description|
|9951|Similarity Rule||
|9953|Knowledge Article|Organizational knowledge for internal and external use.|
|9954|Knowledge Article Incident|Association between an knowledge article and incident.|
|9955|Knowledge Article Views|No of times an article is viewed per day|
|9957|Language|Language|
|9958|Feedback|Feedback and rating.|
|9959|Category|Entity for categorizing records to make it easier for your customers to find them on portals and through search.|
|9960|Knowledge Article Category|Category for a Knowledge Article.|
|9961|DelveActionHub|Delve Action Hubs Description|
|9962|Action Card|Action card entity to show action cards.|
|9968|ActionCardUserState||
|9973|Action Card User Settings|Stores user settings for action cards|
|9983|Action Card Type|To provide master data for the card types list. For internal use only|
|9986|Interaction for Email||
|9987|External Party Item|Information about external party items that need to access Dynamics 365 from external channels.For internal use only|
|9996|HolidayWrapper||
|9997|Email Signature|Signature for email message|
|10000|Solution Component Attribute Configuration||
|10001|Solution Component Batch Configuration||
|10002|Solution Component Configuration||
|10003|Solution Component Relationship Configuration||
|10004|Solution History||
|10005|Solution History Data Source||
|10006|Component Layer||
|10007|Component Layer Data Source||
|10008|Package||
|10009|Package History||
|10011|StageSolutionUpload||
|10012|ExportSolutionUpload||
|10013|FeatureControlSetting|featurecontrolsetting|
|10014|Solution Component Summary||
|10015|Solution Component Count Summary||
|10016|Solution Component Data Source||
|10017|Solution Component Count Data Source||
|10018|Microsoft Entra ID|Virtual entity that represents Microsoft Entra ID|
|10019|Staged Entity|Stores staged entity metadata to be processed before fully created.|
|10020|Staged Entity Attribute|Stores staged entity attribute metadata to be processed in async.|
|10021|Staged Metadata Async Operation|Stores staged entity metadata to be processed before fully created.|
|10022|Key Vault Reference|Contains data that refers to an Azure Key Vault containing credentials used to connect to secure web-hosted resources.|
|10023|Managed Identity|Contains data to represent an Azure Active Directory Application used to connect to secure web-hosted resources.|
|10024|Catalog|Entity for cataloging records to make it easier for your customers to find them on portals and through search.|
|10025|Catalog Assignment|Entity for assigning records to a specific catalog |
|10026|Internal Catalog Assignment||
|10027|Custom API|Entity that defines a custom API|
|10028|Custom API Request Parameter|Entity that defines a request parameter for a custom API|
|10029|Custom API Response Property|Entity that defines a response property for a custom API |
|10030|Plugin Package||
|10031|NonRelational Data Source||
|10032|ProvisionLanguageForUser||
|10033|Shared Object|A record that is being shared in a real time collaboration session.|
|10034|Shared Workspace|References a container that stores real-time collaboration data.|
|10035|Shared Workspace Access Token|Contains information about the shared workspace access tokens.|
|10036|Shared Workspace Pool|Contains metadata about a container used to store real-time collaboration data. Once claimed, a sharedworkspace record would be created with copied metadata.|
|10037|Data Lake Folder|A folder is a place to store data in Azure Data Lake.|
|10038|Data Lake Folder Permission||
|10039|Data Lake Workspace|A workspace is a place to store data in Azure Data Lake.|
|10040|Data Lake Workspace Permission||
|10041|Data Processing configuration||
|10042|Exported Excel|A Place holder entity to save excel file for each exportretaineddata custom api requests.|
|10043|RetainedData Excel|A Place holder entity to save excel file for each exportretaineddata custom api requests.|
|10044|Synapse Database|This entity represents an external Synapse database and its associated datalake folder link.|
|10045|Synapse Link External Table State|Synapse Link external table states|
|10046|Synapse Link Profile|Synapse Link Profile|
|10047|Synapse Link Profile Entity|Entities associated with the Synapse Link profile|
|10048|Synapse Link Profile Entity State|Runtime state of the Synapse Link entity|
|10049|Synapse Link Schedule|Synapse link schedules|
|10050|Component Version||
|10051|Component Version Data Source||
|10052|Component Version (Internal)||
|10053|DataflowRefreshHistory||
|10054|EntityRefreshHistory||
|10055|Shared Link Setting|Shared Link Setting|
|10056|DelegatedAuthorization|Context for delegated authorization.|
|10057|CascadeGrantRevokeAccessRecordsTracker||
|10058|CascadeGrantRevokeAccessVersionTracker||
|10059|RevokeInheritedAccessRecordsTracker||
|10060|TdsMetadata||
|10061|Model-Driven App Element|Associates a model-driven app with its components.|
|10062|Model-Driven App Component Node's Edge|Contains Model-Driven App Component Node's Edge Information.|
|10063|Model-Driven App Component Node|Contains Model-Driven App Component Node Information|
|10064|Model-Driven App Setting|Holds the value for the associated App Setting Definition.|
|10065|Model-Driven App User Setting|Holds the value for the associated App User Setting Definition.|
|10066|Organization Setting|Holds the value for the associated Organization Setting Definition.|
|10067|Setting Definition|Contains Setting Definitions|
|10068|CanvasApp Extended Metadata|Holds extended metadata values for canvas apps that are not solution aware|
|10069|Service Plan Mapping|Service Plan Mapping|
|10070|Service Plan Custom Control|Service Plan Custom Controls|
|10072|ApplicationUser|Application User that has non-interactive access to the CDS system|
|10075|OData v4 Data Source|Data sources used by the OData v4 data provider to access data from an external web service.|
|10076|Workflow Binary||
|10077|Credential||
|10078|Desktop Flow Module||
|10079|Flow Capacity Assignment|Capacity assignment for usage in Power Automate|
|10080|Flow Event|Entity to store the events that happen during usage of Power Automate.|
|10081|Flow Machine||
|10082|Flow Machine Group||
|10083|Flow Machine Image||
|10084|Flow Machine Image Version||
|10085|Flow Machine Network||
|10086|ProcessStageParameter||
|10087|Work Queue||
|10088|Work Queue Item||
|10089|Desktop Flow Binary||
|10090|Flow Run||
|10091|Connection Reference||
|10092|DVFileSearch|DVFileSearches Component|
|10093|DVFileSearchAttribute||
|10094|DVFileSearchEntity|DVFileSearchEntities component.|
|10095|DVTableSearch|DVTableSearches component|
|10096|DVTableSearchAttribute|DVTableSearchAttribute component|
|10097|DVTableSearchEntity|DVTableSearchEntities component|
|10098|AIPlugin|AIPlugins component|
|10099|AIPluginExternalSchema|AIPluginExternalSchemas component|
|10100|AIPluginExternalSchemaProperty|AIPluginExternalSchemaProperties component|
|10101|AIPluginInstance|AI Plugin Instances Component|
|10102|AIPluginOperation|AIPluginOperations component|
|10103|AIPluginOperationParameter|Parameter overrides for AI Operation|
|10104|AIPluginUserSetting||
|10105|Help Page||
|10106|Tour||
|10107|BotContent||
|10108|ConversationTranscript|Contains the transcripts of conversations between participants such as customers, Virtual Agents or Human agents.|
|10109|Chatbot|Represents a Power Virtual Agents Chatbot. https://powerva.microsoft.com/|
|10110|Chatbot subcomponent|Holds key authoring components of a Chatbot such a topics, entities, variables, etc.|
|10118|Comment|A collaborative comment on a maker artifact|
|10119|App Insights Metadata|Metadata for App Insights Platform components|
|10120|Dataflow Connection Reference|Intersecting table between Dataflow and Connection Reference|
|10121|Schedule|Generic refresh schedule|
|10122|Dataflow Template|An entity to store information about dataflow templates|
|10123|Dataflow DatalakeFolder||
|10124|Data Movement Service Request|Table for Data Movement Service Requests|
|10125|Data Movement Service Request Status|Table for Data Movement Service Request Status|
|10126|DMS Sync Request|An entity to save DMS sync requests.|
|10127|DMS Sync Status|An entity to save DMS sync statuses.|
|10128|Module Run Detail|Result of execution of a MEF model|
|10129|Workflow Action Status|PA Workflows action processing status|
|10130|PDF Setting|PDF Settings to save enabled pdf entities|
|10131|Activity File Attachment|Attachment entity with data stored in file type attribute|
|10132|Teams chat|For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat|
|10133|Service Configuration||
|10134|SLA KPI||
|10135|Integrated search provider|Ingest and search files, documents, or articles from data sources outside of your current Dynamics 365 organization with a unified ranking.|
|10136|Knowledge Management Setting|Setup knowledge management for your organization.|
|10137|Knowledge Federated Article||
|10138|Knowledge Federated Article Incident||
|10139|Search provider||
|10140|Knowledge Article Image||
|10141|Knowledge Configuration|Represents the possible settings used in Knowledge management|
|10142|Knowledge Interaction Insight|Knowledge Interaction Insight|
|10143|Knowledge Search Insight|Knowledge Search Insight|
|10144|Favorite knowledge article|Entity for favorite knowledge articles|
|10145|Knowledge article language setting|Allows you to select default language for knowledge authoring.|
|10146|Knowledge Article Attachment||
|10147|Knowledge personalization|Allows users to personalize their knowledge search filters and knowledge authoring language.|
|10148|Knowledge Article Template|Organizational Knowledge Article Template for Internal and external creation of Knowledge Articles.|
|10149|Knowledge search personal filter config|Allows you to configure and manage personal filter settings.|
|10150|Knowledge search filter|Allows you to configure and manage filter settings.|
|10152|SupportUserTable||
|10153|FxExpression||
|10154|PowerfxRule||
|10155|Ms Graph Resource To Subscription|For internal use only. The mapping between Ms Graph Resources and Subscriptions.|
|10156|Virtual Entity  Metadata|Holds  metadata values for virtual entities|
|10157|Background Operation||
|10158|MobileOfflineProfileExtension||
|10159|MobileOfflineProfileItemFilter||
|10160|TeamMobileOfflineProfileMembership||
|10161|UserMobileOfflineProfileMembership||
|10162|OrganizationDataSyncSubscription||
|10163|OrganizationDataSyncSubscriptionEntity||
|10164|OrganizationDataSyncSubscriptionFnoTable||
|10165|OrganizationDataSyncFnoState|Information regarding data synchronization state|
|10166|OrganizationDataSyncState|Information regarding data synchronization state|
|10167|ArchiveCleanupInfo|This is Deprecated Entity.|
|10168|ArchiveCleanupOperation|This is Deprecated Entity.|
|10169|BulkArchiveConfig|This is Deprecated Entity.|
|10170|BulkArchiveFailureDetail|This is Deprecated Entity.|
|10171|BulkArchiveOperation|This is Deprecated Entity.|
|10172|BulkArchiveOperationDetail|This is Deprecated Entity.|
|10173|EnableArchivalRequest|For internal use only.|
|10174|MetadataForArchival|Holds  metadata values of tables for retention|
|10175|ReconciliationEntityInfo|Table level details of the data lake reconciliation process. For internal use only.|
|10176|ReconciliationEntityStepInfo|Step level details of the data lake reconciliation process. For internal use only.|
|10177|ReconciliationInfo|Information about data lake reconciliation operation. For internal use only.|
|10178|RetentionCleanupInfo|Holds watermark information about retention cleanup operations. For internal use only.|
|10179|RetentionCleanupOperation|Holds data of cleanup operations such as reconcile and purge.  For internal use only.|
|10180|RetentionConfig|Holds retention policies for a table.|
|10181|RetentionFailureDetail|Retention failure details.|
|10182|RetentionOperation|Retention policy execution details.|
|10183|RetentionOperationDetail|Table level details of retention execution.|
|10184|Notification|Notification to be provided to a user.|
|10185|User Rating||
|10186|Mobile App|Mobile App|
|10187|Insights Store Data Source||
|10188|Insights Store Virtual Entity|Insights Store Virtual Entity|
|10189|RoleEditorLayout||
|10190|Deleted Item Reference|Deleted Item References|
|10191|Recycle Bin Configuration|Holds recyclebin configuration for entities|
|10192|App Action|Contains Modern Command Information|
|10193|App Action Migration||
|10194|App Action Rule||
|10197|Card|Card|
|10198|Card State Item||
|10201|Entity link chat configuration||
|10202|Rich Text Attachment|Image or file attached to a rich text field|
|10203|Custom Control Extended Setting||
|10204|Timeline Pin|Timeline Pin Record|
|10205|Virtual Connector Data Source||
|10206|Virtual Table Column Candidate||
|10207|AI Event||
|10208|AI Builder Feedback Loop||
|10209|AI Form Processing Document||
|10210|AI Object Detection Image||
|10211|AI Object Detection Label||
|10212|AI Object Detection Bounding Box||
|10213|AI Object Detection Image Mapping||
|10215|AI Builder Dataset||
|10216|AI Builder Dataset File||
|10217|AI Builder Dataset Record||
|10218|AI Builder Datasets Container||
|10219|AI Builder File||
|10220|AI Builder File Attached Data||
|10221|PM Analysis History||
|10222|PM Business Rule Automation Config||
|10223|PM Calendar||
|10224|PM Calendar Version||
|10225|PM Inferred Task||
|10226|PM Process Extended Metadata Version||
|10227|PM Process Template||
|10228|PM Process User Settings||
|10229|PM Process Version||
|10230|PM Recording||
|10231|PM Template||
|10232|PM View||
|10233|Analysis Component||
|10234|Analysis Job||
|10235|Analysis Override||
|10236|Analysis Result||
|10237|Analysis Result Detail||
|10238|Solution Health Rule||
|10239|Solution Health Rule Argument||
|10240|Solution Health Rule Set|Represents a set that owns a number of solution health rules.|
|10241|Power BI Dataset||
|10242|powerbidatasetapdx|PowerBI Dataset appendix entity - for unmanaged technical attributes|
|10243|Power BI Mashup Parameter||
|10244|Power BI Report||
|10245|powerbireportapdx|PowerBI Report appendix entity for unmanaged technical attributes|
|10246|File Upload||
|10247|MainFewShot|This fewshot entity will only be updated during solution installation.|
|10248|MakerFewShot|This fewshot is updated by maker for testing the queries and by the NL2SQ with the results|
|10249|SearchAttributeSettings||
|10250|SearchCustomAnalyzer||
|10251|SearchRelationshipSettings||
|10252|Search Telemetry|Entity to log telemetry that used to improve search quality|
|10253|CopilotExampleQuestion|CopilotExampleQuestions Component|
|10254|Site Component||
|10255|Site||
|10256|Site Language||
|10257|Power Pages Site Published||
|10260|External Identity||
|10261|Invitation|Send invitations to existing contacts or email addresses and assign them to web roles upon redemption.|
|10262|Invite Redemption|Holds information about the redemption of an invite.|
|10263|Portal Comment|An activity which is used to share information between the user and the customer on the portal.|
|10264|Setting||
|10265|Multistep Form Session|Serves as a mechanism to log the occurrence of an incomplete multistep form entry for a given user so they can return and complete it later.|
|10269|Ad Placement||
|10270|Column Permission||
|10271|Column Permission Profile||
|10272|Content Snippet|Content snippets are inserted in page templates so that any label, text string or image in the template can be content-managed.|
|10273|Basic Form|Defines the form to render for a given entity type.|
|10274|Basic Form Metadata|Defines the additional behavior modification logic to augment or override the functionality of form components that is not possible with Dynamics 365 entity and form metadata.|
|10275|List||
|10276|Table Permission||
|10277|Page Template|URL of the .aspx page used to create new webpages.|
|10278|Poll Placement||
|10279|Power Pages Core Entity DS||
|10280|Publishing State||
|10281|Publishing State Transition Rule||
|10282|Redirect||
|10283|Shortcut||
|10284|Site Marker|Used by web page templates to locate a specific page of content.|
|10285|Site Setting|Site specific settings or variables refferenced by the web site code files.|
|10286|Web File|Storage of files used in the web Portals.|
|10287|Multistep Form|Defines the necessary properties and relationships to the other key entities in order to control the initialization of the form within a web portal.|
|10288|Multistep Form Metadata|Defines the additional behavior modification logic to augment or override the functionality of form fields that is not possible with Dynamics 365 entity and form metadata.|
|10289|Form Step|Defines the flow logic of the form's user experience such as steps and conditional branching.|
|10290|Web Link|A textual or imaged based link to an interal or external URL.|
|10291|Web Link Set|A grouping of web links.|
|10292|Web Page|Web Page|
|10293|Web Page Access Control Rule||
|10294|Web Role|Sets the user's role for the Portal.|
|10295|Website|Web Portal|
|10296|Website Access||
|10297|Website Language|Languages supported and publishing status for the portal|
|10298|Web Template||
|10308|Catalog Submission Files|Files associated with the package that will be used as part of the submission to the catalog system.|
|10309|Package Submission Store|Manages submissions to the Catalog and provisioning|
|10310|List Operation|System operation used to perform lengthy and asynchronous list operations on large data sets, such as adding members to a list.|
|10311|Marketing Form Display Attributes|Setting to allow customized form for In-app Marketing Form|
|10312|Database Version|Stores the latest database version for a solution, for internal use only.|
|10313|Upgrade Run|Contains logging information about a run of a Package Deployer package that upgrades a solution|
|10314|Upgrade Step|One step during an upgrade, such as a single method or stored procedure.|
|10315|Upgrade Version|Information about upgrading from one release to the next release|
|10316|Activity monitor|Entity that tracks ARC runtime information.|
|10317|Originating Queue Mapping|This entity maps entities created by ARC to the queue that was being procesed at that time|
|10318|Unified Routing Setup Tracker|Unified Routing Setup Trackers|
|10319|Available Times||
|10320|Available Times Data Source||
|10321|resource group data source||
|10322|Virtual Resource Group Resource||
|10323|Migration tracker|Entity that tracks the migration process of legacy to modern SLA/ARC items|
|10324|BgJobLedger||
|10325|Intent||
|10326|JobsState|Entity to store jobstate|
|10327|Asset Category Template Association||
|10328|Asset Template Association||
|10329|Customer Asset|Specify Customer Asset.|
|10332|Customer Asset Attachment|Attachments for Customer Asset|
|10333|Customer Asset Category|The Category of Customer Asset.|
|10334|Functional Location||
|10335|Property Definition||
|10336|Property Asset Association||
|10337|Property Log||
|10338|Property Template Association||
|10339|Template For Properties||
|10343|IoT Alert||
|10344|IoT Device|Represents a connected device that can be registered with an IoT provider.|
|10345|IoT Device Category|Used to categorize IoT devices.|
|10346|IoT Device Command|Represents an outgoing message to a device connected to an IoT provider.|
|10347|IoT Device Command Definition|Metadata for commands that a device or a device category supports.|
|10348|IoT Device Data History|The name of the entity that holds the device data every time a device data pull occurs between Dynamics 365 and an IoT provider|
|10349|IoT Device Property|Link entity between IoT Device Category and IoT Property Definition. This is used to model properties and tags for devices.|
|10350|IoT Device Registration History|Tracks registration activities on an IoT device.|
|10351|IoT Device Visualization Configuration|IoT Device Visualization Configuration|
|10352|IoT Field Mapping||
|10353|IoT Property Definition|Defines a device property or a parameter that can be used for one or more command definitions.|
|10354|IoT Provider|The IoT Provider where a device is registered and through which all interactions with the device take place|
|10355|IoT Provider Instance|An instance of an IoT Provider.|
|10356|IoT Settings||
|10359|IoT Alert to Case Process|Base entity for process IoT to Case Process|
|10361|Playbook Callable Context||
|10362|Playbook activity|Stores the details of the activities to be created when a playbook is launched.|
|10363|Playbook activity attribute|Stores attribute names and values of the playbook activity.|
|10364|[DEPRECATED] Playbook category|List of categories for which a playbook can be created.|
|10365|Playbook|Actual instance of a playbook template once it is launched.|
|10366|[DEPRECATED] Playbook template|Playbook templates contains the definition of the Playbook that helps to standardize a set of best practices or next best actions.|
|10368|admin_settings_entity||
|10369|Collab Space Team Association|Collab Space Team Association|
|10370|CRM Connection||
|10371|Tagged Record|Tagged Record - Copilot for Sales|
|10372|Copilot for Sales customer list||
|10373|msdyn_vivaentitysetting|Entity level settings for Copilot for Sales|
|10374|msdyn_vivaorgextensioncred|Org level extension credential for Viva apps|
|10375|msdyn_vivaorgsetting|Org level settings for Copilot for Sales app|
|10376|msdyn_vivausersetting|User level settings for Copilot for Sales|
|10377|Sales Copilot Insight||
|10378|Org level settings for Sales Copilot apps|Org level settings for Sales Copilot apps|
|10379|App profile||
|10380|Application Extension||
|10381|Application Tab Template||
|10382|App profile role mapping||
|10383|Notification Field||
|10384|Notification Template||
|10385|Session Template||
|10386|Template Parameter||
|10392|Channel Integration Framework v1.0 Provider|Entity that holds the configuration data for a channel provider based on Channel Integration Framework v1.0|
|10393|Notification Field (Deprecated)|Defines a field (key, templateValue) that needs to be populated in the notification body.|
|10394|Notification Template (Deprecated)|Template for a notification|
|10395|App Parameter Definition (Deprecated)||
|10396|Session Templates (Deprecated)||
|10397|Application Tab Template (Deprecated)|An application tab template with various template parameters defined.|
|10398|Parameter (Deprecated)|Template parameter values for a given application template|
|10399|Template Tag (Deprecated)|Tags associated with templates. Templates are discovered via tags|
|10400|Application Type (Deprecated)|Define a UCI pagetype. For each pagetype, define the parameters that need to be a part of the template for this application type|
|10409|Channel Integration Framework v2.0 Provider|Entity that holds the configuration data for a third-party voice channel provider based on Channel Integration Framework v2.0|
|10411|Conversation Data (Deprecated)|Primary entity for a conversation|
|10412|KPI Event Data|Primary entity for a kpi event|
|10413|KPI Event Definition|Primary entity for defining a KPI event|
|10414|Session Data (Deprecated)|Primary entity for session data|
|10415|Session Participant Data (Deprecated)||
|10416|Channel Definition|Stores details about a channel definition.|
|10417|Channel Definition Consent||
|10418|Channel Definition Locale||
|10419|Channel Instance||
|10420|Channel Instance Account||
|10421|Channel Message Attachment||
|10422|Channel Message Context Part|Context about channel message|
|10423|Channel Message Part||
|10424|Consuming Application|Consuming Application that use Unified Channel|
|10425|msdyn_DefExtendedChannelInstance||
|10426|msdyn_DefExtendedChannelInstanceAccount||
|10427|Productivity pane configuration||
|10428|Pane tab configuration||
|10429|Pane tool configuration||
|10431|Agent script|Agent script v2|
|10432|Agent script step||
|10434|Action Input Parameter|Attributes of action input parameters|
|10435|Action Output Parameter|Attributes of action output parameters|
|10436|Macro Action Template|Attributes for macro action template|
|10437|Macro Solution Configuration|Macro solution related configurations|
|10438|Macro Connector|Attributes for macro connectors|
|10439|Macro Run History|Stores history of macro runs|
|10440|Parameter definition|Macro parameter definitions|
|10443|Adaptive Card Configuration|Adaptive Card Configuration|
|10444|Smartassist configuration|Stores Smartassist configurations|
|10446|Read Tracker|Keeps track of the records read by an user in the system|
|10447|Read tracking enabled information||
|10448|Microsoft Teams Graph resource Entity|Entity which stores collaboration data of Dynamics 365 with Microsoft Teams|
|10449|msdyn_msteamssetting||
|10450|msdyn_msteamssettingsv2||
|10451|Microsoft Teams Collaboration entity|Entity which stores collaboration data of Dynamics 365 with Microsoft Teams|
|10452|Teams Dialer Admin settings||
|10453|Teams Contact Suggestion by AI||
|10454|Contact suggestion rule||
|10455|Contact suggestion ruleset||
|10456|Microsoft Teams chat association entity|For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat|
|10457|Microsoft Teams chat suggestion|For internal use only|
|10458|Microsoft Orgchart node entity|For internal use only. Entity which stores association data of account with contacts present in the orgchart hierarchy of the account|
|10459|Forecast Manual Adjustment History|Forecast Manual Adjustment History|
|10460|Distributed Lock|Distributed Locks|
|10461|Entity Delta Change|Entity Delta Changes|
|10462|File Upload Status Tracker|File Upload Status Tracker|
|10463|Forecast|Forecast|
|10464|Forecast Configuration||
|10465|Forecast definition|Defines the parameters used for forecasting.|
|10466|Forecasting Cache|Forecasting Cache|
|10467|Forecast Insights|Forecast Insights|
|10468|Forecast|Stores sales predictions for your team or organization. For internal use.|
|10469|Forecast Prediction Data|Forecast Prediction Data|
|10470|Forecast Prediction Status|Forecast Prediction Status|
|10471|Forecast recurrence|Stores recalculation information for each recurrence of the forecast hierarchy. For internal use.|
|10472|Recompute Tracker||
|10473|Forecast Recurrence|Forecast Recurrence|
|10474|ShareAs Configuration|ShareAs Configuration|
|10475|Customer email communication||
|10476|GDPRData||
|10477|ODOSFeatureMetadata||
|10478|ODOSMetadata||
|10479|Recurring Sales Action||
|10480|Recurring Sales Action V2||
|10481|msdyn_relationshipinsightsunifiedconfig||
|10482|siconfig||
|10483|SI Key Value Config||
|10484|Usage Metric||
|10485|Action Card Regarding||
|10486|Action Card Role Setting||
|10487|EntityRankingRule||
|10488|flowcardtype||
|10489|salesinsightssettings|Storing settings for studio feature|
|10490|Action Card Usage||
|10491|Action Card Usage Aggregation||
|10492|Auto Capture Rule|Auto Capture Rules|
|10493|Auto Capture Settings|Auto Capture Settings|
|10494|UntrackedAppointment|UntrackedAppointments|
|10495|Suggested Activity|Activity suggestions|
|10496|Suggested Activity Data Source|Suggested Activity Data Sources|
|10497|Suggested Contact|Contact suggestions|
|10498|Suggested Contacts Data Source|Suggested contacts data sources|
|10499|Notes analysis Config||
|10500|icebreakersconfig||
|10501|dealmanageraccess||
|10502|Deal manager settings|Deal manager settings|
|10503|Account KPI Item||
|10504|Activity Analysis CleanUp State||
|10505|Relationship Analytics Config||
|10506|Contact KPI Item||
|10507|Daily Kpis for account||
|10508|Daily kpis for contact||
|10509|Daily kpis for lead||
|10510|Daily kpis for Opportunity||
|10511|Lead KPI Item||
|10512|Most Contacted|Most Contacted|
|10513|Most Contacted By|Most Contacted By|
|10514|Opportunity KPI Item||
|10515|Relationship Analytics Metadata||
|10516|Similar entities feature importance||
|10517|wkwcolleaguesforcompany||
|10518|wkwcolleaguesforcontact|Entity for storing contact introducer|
|10519|wkwconfig||
|10520|Attribute Influence Statistics||
|10521|Prediction Computation Operation||
|10522|Prediction Model Status|Stores metadata about predictive models|
|10523|Prediction Scheduled Operation|Contains meta-data about the scheduled operations.|
|10524|Predictive Model Score||
|10525|Predictive Score||
|10526|Predictive Scoring Sync Status|Internal entity used to store sync status for predictive scoring core entities.|
|10527|Real Time Scoring|Stores meta data information for real time scoring.|
|10528|Real Time Scoring Operation|Stores metadata for real time scoring job.|
|10529|Submodel Definition|Stores metadata about submodels|
|10530|Time spent in BPF||
|10531|Training Result|Stores Training results for the model|
|10532|OpportunityModelConfig||
|10533|LeadModelConfig||
|10534|ModelPreviewStatus||
|10535|Profile Album|Contains user profile images that are stored as attachments and displayed in posts.|
|10536|Post Configuration|Enable or disable entities for Activity Feeds and Yammer collaboration.|
|10537|Post Rule Configuration|Enable or disable system post rules for an entity for Activity Feeds and Yammer.|
|10538|Wall View|Contains information regarding which views are available for users to display on their personal walls. Only an administrator can specify the views that users can choose from to display on their personal walls.|
|10539|Filter|Contains user personalization information regarding which of the administrator’s selected views to display on a user’s personal wall.|
|10540|Customer Voice alert||
|10541|Customer Voice alert rule||
|10542|Customer Voice survey email template|Template for an email message that contains the survey invitation link.|
|10543|Customer Voice file response|Response to a file upload question.|
|10544|Customer Voice localized survey email template|Stores localized data for email templates.|
|10545|Customer Voice project|Set of surveys to collect feedback.|
|10546|Customer Voice survey question|Question in a survey to collect feedback.|
|10547|Customer Voice survey question response|Response to a question in a survey.|
|10548|Customer Voice satisfaction metric|Satisfaction metric defined for a project.|
|10549|Customer Voice survey|Set of questions to collect feedback.|
|10550|Customer Voice survey invite|Activity that tracks a survey invitation sent to a person.|
|10551|Customer Voice survey reminder|Email reminders for surveys created in Customer Voice.|
|10552|Customer Voice survey response|Response to a survey.|
|10553|Customer Voice unsubscribed recipient|Email address of an unsubscribed respondent.|
|10554|AddToCalendar style||
|10555|basestyle||
|10556|Button style||
|10557|Code style||
|10558|Column style||
|10559|Content Block||
|10560|Divider style||
|10561|General styles||
|10562|imagestyle||
|10563|Layout Style||
|10564|QR code style||
|10565|Text style||
|10566|Video style||
|10567|App state||
|10568|CSAdminConfig||
|10569|Custom API Ruleset Configuration|Configuration table for setting up custom APIs for usage inside the Unified routing system|
|10570|Decision contract|Stores information about contract that will be required for ruleset definition|
|10571|Decision rule set|Contains list of rules to define demand and assignment behavior|
|10572|Rulesetentitymapping|For internal use only entity used to store an implicit mapping between a ruleset and polymorphic entity|
|10573|Routing diagnostic item|The entity used to store unified routing diagnostic data.|
|10574|Routing diagnostic||
|10575|Inbox Configuration||
|10576|Agent Copilot Setting||
|10577|App Profile Copilot Configuration||
|10578|Copilot Summarization Setting||
|10579|Case Enrichment||
|10580|Case Suggestion||
|10581|Case Suggestion Request Payload||
|10582|Case Suggestions Data Souce||
|10583|Agent Preference For Copilot||
|10584|Copilot Interaction||
|10585|Copilot Interaction Data||
|10586|Copilot Transcript||
|10587|Copilot Transcript Data||
|10588|KB Enrichment||
|10589|Knowledge Article Suggestion||
|10590|Knowledge Article Suggestion Data Source||
|10591|Suggestion Interaction||
|10592|Suggestion request payload||
|10593|Suggestions Model Summary|Suggestions Model Summary entity|
|10594|Suggestions Setting|Suggestions settings entity|
|10595|Swarm|Tracks the list of swarms created by agents to resolve the customer issues|
|10596|Swarm participant|Stores the participants information of swarm|
|10597|Swarm participant rule|Rules to fetch participants based on their role|
|10598|Swarm role|Stores the different participant roles and associated role type defined|
|10599|Swarm skill|Stores the skills required for the swarm|
|10600|Swarm template|Entity which stores different templates for the swarm|
|10601|Entity Attachment||
|10602|Customer Service Key Value Configuration||
|10603|Master Entity Routing Configuration|Defines master routing details for the entity.|
|10604|Routing Rule Set Setting||
|10605|Assignment Configuration||
|10606|Assignment Configuration Step||
|10607|Capacity Profile|Capacity Profiles|
|10608|Overflow Action Config|Overflow action configurations.|
|10609|Preferred Agent|Preferred Agent Table, table used to store the mapping between the system user and contact/account|
|10610|Preferred Agent Customer Identity|Used for storing the table used to identify customer and the corresponding associated table|
|10611|Preferred Agent Routed Entity|Preferred Agent Routed table used to store information for routed table name and customer identifying column on the table|
|10612|Routing configuration|Defines routing details for the workstream|
|10613|Routing configuration step|Links the routing configuration with ruleset|
|10614|Bot Channel Registration|Bot channel registration used for channel integration|
|10615|Channel Configuration|Channel Configuration|
|10616|Channel State Configuration|Channel State Configuration|
|10617|Provisioning State|Provisioning state|
|10618|AdminAppState|State for each user in Admin App|
|10619|Agent Status history|Agent status history entity records any changes to agent’s presence or available capacity.|
|10620|Power BI Configuration|Stores the Power BI configurations for supervisor experience|
|10621|Authentication Settings|Stores the settings for user authentication|
|10622|Auth Settings Entry||
|10623|Quick reply|Stores the quick replies that agents can use in the conversation control while interacting with the customers|
|10624|Entity Routing Context|Entity Routing Contexts|
|10625|Channel Capability|The capability that a channel can enable, such as co-browse, screen sharing.|
|10626|Conversation Action|The action that can be performed in the conversation.|
|10627|Conversation Action Locale|Localization information associated with the Conversation action.|
|10628|Conversation Message Block|A Message Block would constitute a block of messages up till an agent responds (including the messages sent by the agent). A follow up message, after an agent responds, will create another message block, this block again ends with the messages from the agent|
|10629|DeletedConversation|Holds id of deleted conversation|
|10630|Deprecated Workstream Entity Configuration|Stores entity routing configuration per workstream|
|10631|Entity|Entity Routing Configuration|
|10632|Ongoing conversation (Deprecated)|Tracks the interactions between the agents and customer|
|10633|Live work item event|This entity captures all events corresponding to a live work item.|
|10634|Work Stream|Stores information about the properties of work items that are generated by a unique channel endpoint|
|10635|Masking Rule|Masking Rules to apply to chat messages.|
|10636|Auto block rule||
|10637|Bot Channel Registration Secret||
|10638|Omnichannel channel api conversation privilege|Entity for creating privilege for custom apis. The privileges for this entity will be used to restrict custom api access.|
|10639|Omnichannel channel api message privilege|Entity for creating privilege for custom apis. The privileges for this entity will be used to restrict custom api access.|
|10640|Channel api method mapping|OC channel api method mapping entity.|
|10641|External context||
|10642|Flagged spam||
|10643|Language||
|10644|Conversation|Tracks the interaction between the agents and customer|
|10647|Context item value|Stores context item values for an engagement.|
|10648|Live Work Item Participant (Deprecated)||
|10649|Conversation Sentiment|Stores the machine learning generated customer sentiment of the communication  between the user and the customer|
|10650|Context variable|Stores the context variables for a work stream.|
|10651|Localization|Entity used for data localization on CRM org.|
|10652|OC Payment Profile||
|10653|Recording|Records the audio/video session|
|10654|Omnichannel Request|Entity to store Requests across Omnichannel.|
|10655|Rich message|Rich messages for Omnichannel integration|
|10656|Rich message map|Rich messages map for Omnichannel integration|
|10657|Rule Item|Stores the condition and destination including Omnichannel queues or agents|
|10658|Sentiment daily topic|1. store properties regarding each topic cluster
2. used for dashboard visualization (like topic example) and calculation for topic mapping|
|10659|Sentiment daily topic keyword|1. Store the keyword and frequency for topic clusters
2. Used for word cloud in the dashboard|
|10660|Sentiment daily topic trending|1. Store the day to day topic mapping information
2. Used for dashboard visualization|
|10661|Session|Session for interacting with a customer|
|10662|Session Participant Event|Session participant events|
|10663|Session Sentiment|Stores the session level sentiment for customer interactions calculated using AI.|
|10664|Message|Stores the system messages sent to the message receiver for various events.|
|10665|Tag|Tags for quick categorization|
|10666|Geo Location Provider|Geo Location Providers|
|10667|Omnichannel Configuration|Configuration for Omnichannel|
|10668|Omnichannel Personalization|Stores personalization information of Omnichannel Agent/Supervisor dashboards|
|10669|Omnichannel Queue (Deprecated)|Stores omni-channel work items of a specific issue type or a specific team|
|10670|Omnichannel Sync Config|Config for entities to be synced to Omnichannel|
|10671|Operating Hour|Stores all the operating hours that are configured for an organization.|
|10672|Personal quick reply|Omnichannel agents's personal quick replies|
|10673|Personal sound setting|Entity to store personalized sound records for the users.|
|10674|Persona Security Role Mapping||
|10675|Presence|Stores presence status information|
|10676|Provider|A list of third-party providers that bring capabilities into the application. |
|10677|RoutingRequest|Routing request definition entity|
|10678|Search Configuration|Configuration entity for agent search screen|
|10679|Sentiment analysis|Sentiment analysis configuration|
|10680|Session event|Stores the session events for a session|
|10681|Session participant|Users in a session interacting with the customer|
|10682|Audio File|Entity to store all audio files for Omnichannel|
|10683|Sound notification setting|Entity to store the sound notification setting records for channels and other scenarios. |
|10684|Transcript|Stores the transcript of the communication  between the user and the customer|
|10685|UR notification template|The entity stores all the templates used for UR notification.|
|10686|UR Notification Template Mapping|This entity stores the mapping for notification template and workstream.|
|10687|User settings|Parent entity for Omnichannel personalizations|
|10688|Self service|Stores each customer action as a record. The actions tracked are before an interaction is initiated. Agents will see the actions for an interaction in the Self Service section of the Customer Summary page, when enabled.|
|10695|Agent capacity update history|Agent capacity update history entity records any changes to agent capacity against a capacity profile|
|10696|Bookable Resource Capacity Profile|Bookable Resource Capacity Profile|
|10697|Work stream capacity profile|Work stream capacity profile|
|10698|Conversation Capacity profile|Conversation Capacity profile|
|10699|Agent Capacity Profile Unit|Agent Capacity Profile Units holds agent’s available capacity for each capacity profile associated.|
|10700|Agent Channel State||
|10701|Agent Status|Agent Status holds agent’s status or presence details.|
|10702|Conversation Characteristic|Characteristic associated to Omnichannel conversation|
|10703|Session Characteristic|Characteristic associated to Omnichannel session|
|10704|Skill Attachment Rule||
|10705|Attach Skill||
|10706|Model training details|Indicates model's training details|
|10707|Training data import configuration|Indicates the training data import configuration|
|10708|Characteristic mapping|Indicates the mapping of skills from training data to characteristics|
|10709|Training record|Indicates individual training record to be used for model training|
|10710|Skill finder model|Indicates the OmniChannel Model for the corresponding AI model|
|10711|Effort estimate|Entity to persist effort model prediction results|
|10712|Effort estimation model|Indicates the OmniChannel Model for the corresponding AI model|
|10713|Effort model training details|Indicates model's training details|
|10714|ConversationInsight||
|10715|Active ICD Extension|This notes the currently active description and examples for given entity (queue/agent etc.) as selected by the C1 administrator.|
|10716|Entity-Workstream Map|This notes the entity (queue, agent etc.) mapped to the workstreams.|
|10717|ICD Extension|Contains ICD related fields that will be generated and kept.|
|10718|Conversation Action Item||
|10719|Conversation Aggregated Insights||
|10720|Comment|A comment on a specific section in a transcript|
|10721|Conversation Participant Insights||
|10722|Conversation Participant Sentiment||
|10723|Conversation Question||
|10724|Conversation Segment Sentiment||
|10725|Conversation Sentiment||
|10726|Conversation Signal||
|10727|Conversation Subject||
|10728|Conversation Summary Suggestion||
|10729|Conversation System Tag||
|10730|Conversation Tag||
|10731|Recording||
|10732|SCI Conversation||
|10733|Custom Email Highlight||
|10734|Custom Highlight|Highlight of relevant conversation section|
|10735|Custom Publisher|The publisher of the conversation highlight|
|10736|EnvironmentSettings|SCI environment level settings|
|10737|UserSettings|SCI user level settings|
|10738|DigitalSellingActiveTask||
|10739|DigitalSellingCompletedTask||
|10740|Sales Tag||
|10741|Sequence||
|10742|Sequence Stat||
|10743|Sequence Target||
|10744|Sequence Target Step||
|10745|Sequence Template||
|10747|sabackupdiagnostic||
|10748|SABatchRunInstance||
|10749|salesroutingdiagnostic||
|10750|SARunInstance||
|10751|Segment||
|10752|segmentsetting||
|10753|Segment property||
|10754|SegmentsUtil||
|10755|Assignment Rule|Defines criteria based on which Entities are routed to Users or Sales Team|
|10756|Seller attribute|Sales Attribute|
|10757|Seller attribute value|Attribute Value of sales person or sales team|
|10758|Assignment Map||
|10759|Sales Assignment Setting||
|10760|Sales routing run||
|10762|Extended User Setting||
|10763|Sales acceleration insights|Sales acceleration insights|
|10764|Sales Acceleration settings||
|10765|Insight||
|10766|Work List Suggestion||
|10767|Work list suggestion source||
|10768|Work List View Configuration|Entity to store work list view configurations on filter, icons, sort etc|
|10769|Work Queue Record|Entity created to store WorkQueue Data Model Records|
|10770|Work Queue Record State|Entity created to store WorkQueue Records state|
|10771|Work list user setting|Entity created to store work list user setting|
|10772|WQDataSource||
|10773|Suggestion Assignment Rule||
|10774|Suggestion Principal Object Access||
|10775|Suggestion Seller Priority||
|10776|Data Hygiene Setting Info|Data Hygiene Setting Info|
|10777|Duplicate Detection Plugin Run|Duplicate Detection Plugin Run used to track successful and failure state of the Duplicate Detection Plugin|
|10778|Duplicate Lead Mapping|This enity is used to connect base lead to duplicate leads|
|10779|Lead Hygiene Setting|Lead Hygiene Setting|
|10780|Linked Entity Attribute Validity||
|10782|Bot Session|Bot specific sessions |
|10783|conversationsuggestionrequestpayload|Conversation Suggestion Request Payload|
|10784|Data Analytics Admin Settings (Deprecated)|Data Analytics Admin Settings (Deprecated)|
|10785|Data Analytics User Customized Report|Data Analytics User Customized Report|
|10786|Data Analytics Dataset|Data Analytics Power BI Datasets|
|10787|Data Analytics Report|Data Analytics Reports|
|10788|Data Analytics Workspace|Data Analytics Power BI Workspaces|
|10789|Insights|Analytics and insights feature entity|
|10790|Report Bookmark||
|10791|Agent Resource Forecasting|Agent Resource Forecasting|
|10792|[Deprecated] Dynamics Customer Service Analytics|[Deprecated] Controls access to Analytics Reporting Sitemap in Dynamics Customer Service App|
|10793|Case Topic||
|10794|Case Topic Setting|Case Topic Setting Entity|
|10795|Case Topic Summary|Case Topic Summary Entity|
|10796|Case topic Incident mapping|Cases mapping with the case topics|
|10797|Customer Service historical analytics|Customer Service historical analytics|
|10798|Forecast (preview)|Case, Conversation Volume Forecast analytics|
|10799|Knowledge analytics|Knowledge analytics|
|10800|Forecast Summary and Setting||
|10801|Keywords Description Suggestion Setting|Keywords Description Suggestion settings entity|
|18085|Event Expander Breadcrumb|Table to store breadcrumb records of Event Expander pipeline.|



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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Playbook Callable Context|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Choices/Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Playbook Callable Context|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
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
- [OwningBusinessUnitName](#BKMK_OwningBusinessUnitName)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnitName"></a> OwningBusinessUnitName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunitname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|



## Related information

[Dataverse table/entity reference](../about-entity-reference.md)  
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)