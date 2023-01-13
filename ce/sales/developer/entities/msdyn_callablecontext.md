---
title: "msdyn_callablecontext table/entity reference (Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the msdyn_callablecontext table/entity."
ms.date: 01/13/2023
ms.service: dynamics-365-sales
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "udaykirang"
ms.author: "udag"
manager: "shujoshi"
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---

# msdyn_callablecontext table/entity reference

> [!NOTE]
> Unsure about table vs. entity? See [Developers: Understand terminology in Microsoft Dataverse](/powerapps/developer/data-platform/understand-terminology).



**Added by**: Playbook Solution


## Messages

|Message|SDK Assembly|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|CreateMultiple|<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|
|UpdateMultiple|<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|

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
|953|Opportunity Sales Process|Base entity for process Opportunity Sales Process|
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
|1083|Opportunity Line|Association between an opportunity and a product.|
|1084|Quote|Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.|
|1085|Quote Line|Product line item in a quote. The details include such information as product ID, description, quantity, and cost.|
|1086|User Fiscal Calendar|Custom fiscal calendar used for tracking sales quotas.|
|1088|Order|Quote that has been accepted.|
|1089|Order Line|Line item in a sales order.|
|1090|Invoice|Order that has been billed.|
|1091|Invoice Line|Line item in an invoice containing detailed billing information for a product.|
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
|4720|Flow Session|Entity to store the information that is generated when a modern flow or UI flow runs.|
|4724|Process Stage|Stage associated with a process.|
|4725|Business Process Flow Instance|Active path associated with every Business Process Flow instance|
|4800|Web Wizard|Definition for a Web-based wizard.|
|4802|Wizard Page|Page in a Web-based wizard.|
|4803|Web Wizard Access Privilege|Privilege needed to access a Web-based wizard.|
|4810|Time Zone Definition|Time zone definition, including name and time zone code.|
|4811|Time Zone Rule|Definition for time conversion between local time and Coordinated Universal Time (UTC) for a particular time zone at a particular time period.|
|4812|Time Zone Localized Name|Localized name of the time zone.|
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
|9958|Feedback|Container for feedback and ratings for knowledge articles.|
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
|10010|StageSolutionUpload||
|10011|ExportSolutionUpload||
|10012|FeatureControlSetting|featurecontrolsetting|
|10013|Solution Component Summary||
|10014|Solution Component Count Summary||
|10015|Solution Component Data Source||
|10016|Solution Component Count Data Source||
|10017|AAD User|Virtual entity that represents AAD user|
|10018|Catalog|Entity for cataloging records to make it easier for your customers to find them on portals and through search.|
|10019|Catalog Assignment|Entity for assigning records to a specific catalog |
|10020|Internal Catalog Assignment||
|10021|Custom API|Entity that defines a custom API|
|10022|Custom API Request Parameter|Entity that defines a request parameter for a custom API|
|10023|Custom API Response Property|Entity that defines a response property for a custom API |
|10024|ProvisionLanguageForUser||
|10025|Shared Object|A record that is being shared in a real time collaboration session.|
|10026|Shared Workspace|References a container that stores real-time collaboration data.|
|10027|Data Lake Folder|A folder is a place to store data in Azure Data Lake.|
|10028|Data Lake Folder Permission||
|10029|Data Lake Workspace|A workspace is a place to store data in Azure Data Lake.|
|10030|Data Lake Workspace Permission||
|10031|Data Processing configuration||
|10032|Synapse Database|This entity represents an external Synapse database and its associated datalake folder link.|
|10033|Synapse Link External Table State|Synapse Link external table states|
|10034|Synapse Link Profile|Synapse Link Profile|
|10035|Synapse Link Profile Entity|Entities associated with the Synapse Link profile|
|10036|Synapse Link Profile Entity State|Runtime state of the Synapse Link entity|
|10037|Synapse Link Schedule|Synapse link schedules|
|10038|DataflowRefreshHistory||
|10039|EntityRefreshHistory||
|10040|Shared Link Setting|Shared Link Setting|
|10041|CascadeGrantRevokeAccessRecordsTracker||
|10042|CascadeGrantRevokeAccessVersionTracker||
|10043|RevokeInheritedAccessRecordsTracker||
|10044|Model-Driven App Element|Associates a model-driven app with its components.|
|10045|Model-Driven App Component Node's Edge|Contains Model-Driven App Component Node's Edge Information.|
|10046|Model-Driven App Component Node|Contains Model-Driven App Component Node Information|
|10047|Model-Driven App Setting|Holds the value for the associated App Setting Definition.|
|10048|Model-Driven App User Setting|Holds the value for the associated App User Setting Definition.|
|10049|Organization Setting|Holds the value for the associated Organization Setting Definition.|
|10050|Setting Definition|Contains Setting Definitions|
|10051|CanvasApp Extended Metadata|Holds extended metadata values for canvas apps that are not solution aware|
|10052|Service Plan Mapping|Service Plan Mapping|
|10054|ApplicationUser|Application User that has non-interactive access to the CDS system|
|10057|OData v4 Data Source|Data sources used by the OData v4 data provider to access data from an external web service.|
|10058|Workflow Binary||
|10059|Flow Machine||
|10060|Flow Machine Group||
|10061|Flow Machine Image||
|10062|Flow Machine Image Version||
|10063|Flow Machine Network||
|10064|ProcessStageParameter||
|10065|Desktop Flow Binary||
|10066|Connection Reference||
|10067|Connection Instance||
|10068|AI Builder Feedback Loop||
|10069|AI Form Processing Document||
|10070|AI Object Detection Image||
|10071|AI Object Detection Label||
|10072|AI Object Detection Bounding Box||
|10073|AI Object Detection Image Mapping||
|10075|AI Builder Dataset||
|10076|AI Builder Dataset File||
|10077|AI Builder Dataset Record||
|10078|AI Builder Datasets Container||
|10079|AI Builder File||
|10080|AI Builder File Attached Data||
|10081|Help Page||
|10082|Tour||
|10083|BotContent||
|10084|ConversationTranscript|Contains the transcripts of conversations between participants such as customers, Virtual Agents or Human agents.|
|10085|Chatbot|Represents a Power Virtual Agents Chatbot. https://powerva.microsoft.com/|
|10086|Chatbot subcomponent|Holds key authoring components of a Chatbot such a topics, entities, variables, etc.|
|10092|Comment|A collaborative comment on a maker artifact|
|10093|PDF Setting|PDF Settings to save enabled pdf entities|
|10094|Activity File Attachment|Attachment entity with data stored in file type attribute|
|10095|Teams chat|For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat|
|10096|Service Configuration||
|10097|SLA KPI||
|10098|Knowledge Management Setting|Setup knowledge management for your organization.|
|10099|Knowledge Federated Article||
|10100|Knowledge Federated Article Incident||
|10101|Integrated search provider|Ingest and search files, documents, or articles from data sources outside of your current Dynamics 365 organization with a unified ranking.|
|10102|Search provider||
|10103|Knowledge Article Image||
|10104|Knowledge Interaction Insight|Knowledge Interaction Insight|
|10105|Knowledge Search Insight|Knowledge Search Insight|
|10106|Knowledge article language setting|Allows you to select default language for knowledge authoring.|
|10107|Knowledge Article Attachment||
|10108|Knowledge personalization|Allows users to personalize their knowledge search filters and knowledge authoring language.|
|10109|Knowledge Article Template|Organizational Knowledge Article Template for Internal and external creation of Knowledge Articles.|
|10110|Knowledge search personal filter config|Allows you to configure and manage personal filter settings.|
|10111|Knowledge search filter|Allows you to configure and manage filter settings.|
|10113|Plugin Package||
|10114|PowerfxRule||
|10115|SupportUserTable||
|10116|Key Vault Reference|Contains data that refers to an Azure Key Vault containing credentials used to connect to secure web-hosted resources.|
|10117|Managed Identity|Contains data to represent an Azure Active Directory Application used to connect to secure web-hosted resources.|
|10118|Ms Graph Resource To Subscription|For internal use only. The mapping between Ms Graph Resources and Subscriptions.|
|10119|Virtual Entity  Metadata|Holds  metadata values for virtual entities|
|10120|MobileOfflineProfileItemFilter||
|10121|TeamMobileOfflineProfileMembership||
|10122|UserMobileOfflineProfileMembership||
|10123|OrganizationDataSyncSubscription||
|10124|OrganizationDataSyncSubscriptionEntity||
|10125|OrganizationDataSyncState|Information regarding data synchronization state|
|10126|App Insights Metadata|Metadata for App Insights Platform components|
|10127|Workflow Action Status|PA Workflows action processing status|
|10128|NonRelational Data Source||
|10129|Notification|Notification to be provided to a user.|
|10130|User Rating||
|10131|Insights Store Data Source||
|10132|Insights Store Virtual Entity|Insights Store Virtual Entity|
|10133|RoleEditorLayout||
|10134|App Action|Contains Modern Command Information|
|10135|App Action Migration||
|10136|App Action Rule||
|10139|Card|Card|
|10140|Entity link chat configuration||
|10141|Rich Text Attachment|Image or file attached to a rich text field|
|10142|Custom Control Extended Setting||
|10143|SearchRelationshipSettings||
|10144|Search Telemetry|Entity to log telemetry that used to improve search quality|
|10145|Virtual Connector Data Source||
|10146|Virtual Table Column Candidate||
|10147|PM Analysis History||
|10148|PM Calendar||
|10149|PM Calendar Version||
|10150|PM Inferred Task||
|10151|PM Process Extended Metadata Version||
|10152|PM Process User Settings||
|10153|PM Process Version||
|10154|PM Recording||
|10155|PM Template||
|10156|PM View||
|10157|Analysis Component||
|10158|Analysis Job||
|10159|Analysis Result||
|10160|Analysis Result Detail||
|10161|Solution Health Rule||
|10162|Solution Health Rule Argument||
|10163|Solution Health Rule Set|Represents a set that owns a number of solution health rules.|
|10164|Power BI Dataset||
|10165|Power BI Mashup Parameter||
|10166|Power BI Report||
|10167|List Operation|System operation used to perform lengthy and asynchronous list operations on large data sets, such as adding members to a list.|
|10168|Marketing Form Display Attributes|Setting to allow customized form for In-app Marketing Form|
|10169|Database Version|Stores the latest database version for a solution, for internal use only.|
|10170|Upgrade Run|Contains logging information about a run of a Package Deployer package that upgrades a solution|
|10171|Upgrade Step|One step during an upgrade, such as a single method or stored procedure.|
|10172|Upgrade Version|Information about upgrading from one release to the next release|
|10173|Activity monitor|Entity that tracks ARC runtime information.|
|10174|Unified Routing Setup Tracker|Unified Routing Setup Trackers|
|10175|Available Times||
|10176|Available Times Data Source||
|10177|resource group data source||
|10178|Virtual Resource Group Resource||
|10179|Migration tracker|Entity that tracks the migration process of legacy to modern SLA/ARC items|
|10180|Asset Category Template Association||
|10181|Asset Template Association||
|10182|Customer Asset|Specify Customer Asset.|
|10185|Customer Asset Attachment|Attachments for Customer Asset|
|10186|Customer Asset Category|The Category of Customer Asset.|
|10187|Functional Location||
|10188|Property Definition||
|10189|Property Asset Association||
|10190|Property Log||
|10191|Property Template Association||
|10192|Template For Properties||
|10196|IoT Alert||
|10197|IoT Device|Represents a connected device that can be registered with an IoT provider.|
|10198|IoT Device Category|Used to categorize IoT devices.|
|10199|IoT Device Command|Represents an outgoing message to a device connected to an IoT provider.|
|10200|IoT Device Command Definition|Metadata for commands that a device or a device category supports.|
|10201|IoT Device Data History|The name of the entity that holds the device data every time a device data pull occurs between Dynamics 365 and an IoT provider|
|10202|IoT Device Property|Link entity between IoT Device Category and IoT Property Definition. This is used to model properties and tags for devices.|
|10203|IoT Device Registration History|Tracks registration activities on an IoT device.|
|10204|IoT Device Visualization Configuration|IoT Device Visualization Configuration|
|10205|IoT Field Mapping||
|10206|IoT Property Definition|Defines a device property or a parameter that can be used for one or more command definitions.|
|10207|IoT Provider|The IoT Provider where a device is registered and through which all interactions with the device take place|
|10208|IoT Provider Instance|An instance of an IoT Provider.|
|10209|IoT Settings||
|10212|IoT Alert to Case Process|Base entity for process IoT to Case Process|
|10214|Playbook Callable Context||
|10215|Playbook activity|Stores the details of the activities to be created when a playbook is launched.|
|10216|Playbook activity attribute|Stores attribute names and values of the playbook activity.|
|10217|Playbook category|List of categories for which a playbook can be created.|
|10218|Playbook|Actual instance of a playbook template once it is launched.|
|10219|Playbook template|Playbook templates contains the definition of the Playbook that helps to standardize a set of best practices or next best actions.|
|10221|admin_settings_entity||
|10222|CRM Connection||
|10223|Tagged Record|Tagged Record - Viva Sales|
|10224|App profile||
|10225|Application Extension||
|10226|Application Tab Template||
|10227|Notification Field||
|10228|Notification Template||
|10229|Session Template||
|10230|Template Parameter||
|10236|Channel Integration Framework v2.0 Provider|Entity that holds the configuration data for a third-party voice channel provider based on Channel Integration Framework v2.0|
|10238|Conversation Data (Deprecated)|Primary entity for a conversation|
|10239|KPI Event Data|Primary entity for a kpi event|
|10240|KPI Event Definition|Primary entity for defining a KPI event|
|10241|Session Data (Deprecated)|Primary entity for session data|
|10242|Session Participant Data (Deprecated)||
|10243|Productivity pane configuration||
|10244|Pane tab configuration||
|10245|Pane tool configuration||
|10247|Agent script|Agent script v2|
|10248|Agent script step||
|10250|Action Input Parameter|Attributes of action input parameters|
|10251|Action Output Parameter|Attributes of action output parameters|
|10252|Macro Action Template|Attributes for macro action template|
|10253|Macro Solution Configuration|Macro solution related configurations|
|10254|Macro Connector|Attributes for macro connectors|
|10255|Macro Run History|Stores history of macro runs|
|10256|Parameter definition|Macro parameter definitions|
|10259|Adaptive Card Configuration|Adaptive Card Configuration|
|10260|Smartassist configuration|Stores Smartassist configurations|
|10262|Microsoft Teams Graph resource Entity|Entity which stores collaboration data of Dynamics 365 with Microsoft Teams|
|10263|msdyn_msteamssetting||
|10264|msdyn_msteamssettingsv2||
|10265|Microsoft Teams Collaboration entity|Entity which stores collaboration data of Dynamics 365 with Microsoft Teams|
|10266|Teams Dialer Admin settings||
|10267|Teams Contact Suggestion by AI||
|10268|Contact suggestion rule||
|10269|Contact suggestion ruleset||
|10270|Microsoft Teams chat association entity|For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat|
|10271|Microsoft Teams chat suggestion|For internal use only|
|10272|Forecast Manual Adjustment History|Forecast Manual Adjustment History|
|10273|Distributed Lock|Distributed Locks|
|10274|Entity Delta Change|Entity Delta Changes|
|10275|File Upload Status Tracker|File Upload Status Tracker|
|10276|Forecast|Forecast|
|10277|Forecast Configuration||
|10278|Forecast definition|Defines the parameters used for forecasting.|
|10279|Forecasting Cache|Forecasting Cache|
|10280|Forecast Insights|Forecast Insights|
|10281|Forecast|Stores sales predictions for your team or organization. For internal use.|
|10282|Forecast Prediction Data|Forecast Prediction Data|
|10283|Forecast Prediction Status|Forecast Prediction Status|
|10284|Forecast recurrence|Stores recalculation information for each recurrence of the forecast hierarchy. For internal use.|
|10285|Recompute Tracker||
|10286|Forecast Recurrence|Forecast Recurrence|
|10287|ShareAs Configuration|ShareAs Configuration|
|10288|Customer email communication||
|10289|GDPRData||
|10290|Recurring Sales Action||
|10291|msdyn_relationshipinsightsunifiedconfig||
|10292|siconfig||
|10293|SI Key Value Config||
|10294|Usage Metric||
|10295|Action Card Regarding||
|10296|Action Card Role Setting||
|10297|EntityRankingRule||
|10298|flowcardtype||
|10299|salesinsightssettings|Storing settings for studio feature|
|10300|Auto Capture Rule||
|10301|Auto Capture Settings||
|10302|UntrackedAppointment||
|10303|Suggested Activity||
|10304|Suggested Activity Data Source||
|10305|Suggested Contact||
|10306|Suggested contacts data source||
|10307|Notes analysis Config||
|10308|icebreakersconfig||
|10309|dealmanageraccess||
|10310|Deal manager settings|Deal manager settings|
|10311|Recording||
|10312|Attribute Influence Statistics||
|10313|Predictive Model Score||
|10314|Predictive Score||
|10315|Time spent in BPF||
|10316|OpportunityModelConfig||
|10317|LeadModelConfig||
|10318|ModelPreviewStatus||
|10319|Sales Tag||
|10320|Sequence||
|10321|Sequence Stat||
|10322|Sequence Target||
|10323|Sequence Target Step||
|10324|Sequence Template||
|10326|sabackupdiagnostic||
|10327|SABatchRunInstance||
|10328|salesroutingdiagnostic||
|10329|SARunInstance||
|10330|Segment||
|10331|segmentsetting||
|10332|segmentattribute||
|10333|SegmentsUtil||
|10334|Assignment Rule|Defines criteria based on which Entities are routed to Users or Sales Team|
|10335|Attribute|Sales Attribute|
|10336|Attribute Value|Attribute Value of sales person or sales team|
|10337|Assignment Map||
|10338|Sales Assignment Setting||
|10339|Sales routing run||
|10341|Extended User Setting||
|10342|Sales acceleration insights|Sales acceleration insights|
|10343|Sales Acceleration settings||
|10344|Suggestion||
|10345|Work List Suggestion||
|10346|Work list suggestion source||
|10347|Work List View Configuration|Entity to store work list view configurations on filter, icons, sort etc|
|10348|Work Queue Record|Entity created to store WorkQueue Data Model Records|
|10349|Work Queue Record State|Entity created to store WorkQueue Records state|
|10350|Work list user setting|Entity created to store work list user setting|
|10351|WQDataSource||
|10352|Data Hygiene Setting Info|Data Hygiene Setting Info|
|10353|Duplicate Detection Plugin Run|Duplicate Detection Plugin Run used to track successful and failure state of the Duplicate Detection Plugin|
|10354|Duplicate Lead Mapping|This enity is used to connect base lead to duplicate leads|
|10355|Lead Hygiene Setting|Lead Hygiene Setting|
|10356|Linked Entity Attribute Validity||
|10357|Profile Album|Contains user profile images that are stored as attachments and displayed in posts.|
|10358|Post Configuration|Enable or disable entities for Activity Feeds and Yammer collaboration.|
|10359|Post Rule Configuration|Enable or disable system post rules for an entity for Activity Feeds and Yammer.|
|10360|Wall View|Contains information regarding which views are available for users to display on their personal walls. Only an administrator can specify the views that users can choose from to display on their personal walls.|
|10361|Filter|Contains user personalization information regarding which of the administrator’s selected views to display on a user’s personal wall.|
|10362|Customer Voice alert||
|10363|Customer Voice alert rule||
|10364|Customer Voice survey email template|Template for an email message that contains the survey invitation link.|
|10365|Customer Voice file response|Response to a file upload question.|
|10366|Customer Voice localized survey email template|Stores localized data for email templates.|
|10367|Customer Voice project|Set of surveys to collect feedback.|
|10368|Customer Voice survey question|Question in a survey to collect feedback.|
|10369|Customer Voice survey question response|Response to a question in a survey.|
|10370|Customer Voice satisfaction metric|Satisfaction metric defined for a project.|
|10371|Customer Voice survey|Set of questions to collect feedback.|
|10372|Customer Voice survey invite|Activity that tracks a survey invitation sent to a person.|
|10373|Customer Voice survey reminder|Email reminders for surveys created in Customer Voice.|
|10374|Customer Voice survey response|Response to a survey.|
|10375|Customer Voice unsubscribed recipient|Email address of an unsubscribed respondent.|
|10376|AddToCalendar style||
|10377|basestyle||
|10378|Button style||
|10379|Code style||
|10380|Column style||
|10381|Content Block||
|10382|Divider style||
|10383|General styles||
|10384|imagestyle||
|10385|Layout Style||
|10386|QR code style||
|10387|Text style||
|10388|Video style||
|10389|CSAdminConfig||
|10390|Custom API Ruleset Configuration|Configuration table for setting up custom APIs for usage inside the Unified routing system|
|10391|Decision contract|Stores information about contract that will be required for ruleset definition|
|10392|Decision rule set|Contains list of rules to define demand and assignment behavior|
|10393|Rulesetentitymapping|For internal use only entity used to store an implicit mapping between a ruleset and polymorphic entity|
|10394|Routing diagnostic item|The entity used to store unified routing diagnostic data.|
|10395|Routing diagnostic||
|10396|Inbox Configuration||
|10397|Case Enrichment||
|10398|Case Suggestion||
|10399|Case Suggestion Request Payload||
|10400|Case Suggestions Data Souce||
|10401|KB Enrichment||
|10402|Knowledge Article Suggestion||
|10403|Knowledge Article Suggestion Data Source||
|10404|Suggestion Interaction||
|10405|Suggestion request payload||
|10406|Suggestions Model Summary|Suggestions Model Summary entity|
|10407|Suggestions Setting|Suggestions settings entity|
|10408|Data Analytics Admin Settings (Deprecated)|Data Analytics Admin Settings (Deprecated)|
|10409|Data Analytics User Customized Report|Data Analytics User Customized Report|
|10410|Data Analytics Dataset|Data Analytics Power BI Datasets|
|10411|Data Analytics Report|Data Analytics Reports|
|10412|Data Analytics Workspace|Data Analytics Power BI Workspaces|
|10413|Insights|Analytics and insights feature entity|
|10414|Report Bookmark||
|10415|Agent Resource Forecasting|Agent Resource Forecasting|
|10416|[Deprecated] Dynamics Customer Service Analytics|[Deprecated] Controls access to Analytics Reporting Sitemap in Dynamics Customer Service App|
|10417|Case Topic||
|10418|Case Topic Setting|Case Topic Setting Entity|
|10419|Case Topic Summary|Case Topic Summary Entity|
|10420|Case topic Incident mapping|Cases mapping with the case topics|
|10421|Customer Service historical analytics|Customer Service historical analytics|
|10422|Forecast (preview)|Case, Conversation Volume Forecast analytics|
|10423|Knowledge analytics|Knowledge analytics|
|10424|Forecast Summary and Setting||
|10425|Keywords Description Suggestion Setting|Keywords Description Suggestion settings entity|
|10426|Swarm|Tracks the list of swarms created by agents to resolve the customer issues|
|10427|Swarm participant|Stores the participants information of swarm|
|10428|Swarm participant rule|Rules to fetch participants based on their role|
|10429|Swarm role|Stores the different participant roles and associated role type defined|
|10430|Swarm skill|Stores the skills required for the swarm|
|10431|Swarm template|Entity which stores different templates for the swarm|
|10432|Master Entity Routing Configuration|Defines master routing details for the entity.|
|10433|Routing Rule Set Setting||
|10434|Assignment Configuration||
|10435|Assignment Configuration Step||
|10436|Capacity Profile|Capacity Profiles|
|10437|Overflow Action Config|Overflow action configurations.|
|10438|Preferred Agent|Preferred Agent Table, table used to store the mapping between the system user and contact/account|
|10439|Preferred Agent Customer Identity|Used for storing the table used to identify customer and the corresponding associated table|
|10440|Preferred Agent Routed Entity|Preferred Agent Routed table used to store information for routed table name and customer identifying column on the table|
|10441|Routing configuration|Defines routing details for the workstream|
|10442|Routing configuration step|Links the routing configuration with ruleset|
|10443|Bot Channel Registration|Bot channel registration used for channel integration|
|10444|Channel Configuration|Channel Configuration|
|10445|Channel State Configuration|Channel State Configuration|
|10446|Provisioning State|Provisioning state|
|10447|AdminAppState|State for each user in Admin App|
|10448|Agent Status history|Agent status history entity records any changes to agent’s presence or available capacity.|
|10449|Power BI Configuration|Stores the Power BI configurations for supervisor experience|
|10450|Authentication Settings|Stores the settings for user authentication|
|10451|Auth Settings Entry||
|10452|Quick reply|Stores the quick replies that agents can use in the conversation control while interacting with the customers|
|10453|Entity Routing Context|Entity Routing Contexts|
|10454|Channel Capability|The capability that a channel can enable, such as co-browse, screen sharing.|
|10455|Conversation Action|The action that can be performed in the conversation.|
|10456|Conversation Action Locale|Localization information associated with the Conversation action.|
|10457|Conversation Message Block|A Message Block would constitute a block of messages up till an agent responds (including the messages sent by the agent). A follow up message, after an agent responds, will create another message block, this block again ends with the messages from the agent|
|10458|Deprecated Workstream Entity Configuration|Stores entity routing configuration per workstream|
|10459|Entity|Entity Routing Configuration|
|10460|Ongoing conversation (Deprecated)|Tracks the interactions between the agents and customer|
|10461|Live work item event|This entity captures all events corresponding to a live work item.|
|10462|Work Stream|Stores information about the properties of work items that are generated by a unique channel endpoint|
|10463|Masking Rule|Masking Rules to apply to chat messages.|
|10464|Auto block rule||
|10465|Bot Channel Registration Secret||
|10466|Omnichannel channel api conversation privilege|Entity for creating privilege for custom apis. The privileges for this entity will be used to restrict custom api access.|
|10467|Omnichannel channel api message privilege|Entity for creating privilege for custom apis. The privileges for this entity will be used to restrict custom api access.|
|10468|Channel api method mapping|OC channel api method mapping entity.|
|10469|External context||
|10470|Flagged spam||
|10471|Language||
|10472|Conversation|Tracks the interaction between the agents and customer|
|10475|Context item value|Stores context item values for an engagement.|
|10476|Live Work Item Participant (Deprecated)||
|10477|Conversation Sentiment|Stores the machine learning generated customer sentiment of the communication  between the user and the customer|
|10478|Context variable|Stores the context variables for a work stream.|
|10479|Localization|Entity used for data localization on CRM.|
|10480|OC Payment Profile||
|10481|Recording|Records the audio/video session|
|10482|Omnichannel Request|Entity to store Requests across Omnichannel.|
|10483|Rich message|Rich messages for Omnichannel integration|
|10484|Rich message map|Rich messages map for Omnichannel integration|
|10485|Rule Item|Stores the condition and destination including Omnichannel queues or agents|
|10486|Sentiment daily topic|1. store properties regarding each topic cluster
2. used for dashboard visualization (like topic example) and calculation for topic mapping|
|10487|Sentiment daily topic keyword|1. Store the keyword and frequency for topic clusters
2. Used for word cloud in the dashboard|
|10488|Sentiment daily topic trending|1. Store the day to day topic mapping information
2. Used for dashboard visualization|
|10489|Session|Session for interacting with a customer|
|10490|Session Participant Event|Session participant events|
|10491|Session Sentiment|Stores the session level sentiment for customer interactions calculated using AI.|
|10492|Message|Stores the system messages sent to the message receiver for various events.|
|10493|Tag|Tags for quick categorization|
|10494|Geo Location Provider|Geo Location Providers|
|10495|Omnichannel Configuration|Configuration for Omnichannel|
|10496|Omnichannel Personalization|Stores personalization information of Omnichannel Agent/Supervisor dashboards|
|10497|Omnichannel Queue (Deprecated)|Stores omni-channel work items of a specific issue type or a specific team|
|10498|Omnichannel Sync Config|Config for entities to be synced to Omnichannel|
|10499|Operating Hour|Stores all the operating hours that are configured for an organization.|
|10500|Personal quick reply|Omnichannel agents's personal quick replies|
|10501|Personal sound setting|Entity to store personalized sound records for the users.|
|10502|Persona Security Role Mapping||
|10503|Presence|Stores presence status information|
|10504|Provider|A list of third-party providers that bring capabilities into the application. |
|10505|RoutingRequest|Routing request definition entity|
|10506|Search Configuration|Configuration entity for agent search screen|
|10507|Sentiment analysis|Sentiment analysis configuration|
|10508|Session event|Stores the session events for a session|
|10509|Session participant|Users in a session interacting with the customer|
|10510|Audio File|Entity to store all audio files for Omnichannel|
|10511|Sound notification setting|Entity to store the sound notification setting records for channels and other scenarios. |
|10512|Transcript|Stores the transcript of the communication  between the user and the customer|
|10513|UR notification template|The entity stores all the templates used for UR notification.|
|10514|UR Notification Template Mapping|This entity stores the mapping for notification template and workstream.|
|10515|User settings|Parent entity for Omnichannel personalizations|
|10516|Self service|Stores each customer action as a record. The actions tracked are before an interaction is initiated. Agents will see the actions for an interaction in the Self Service section of the Customer Summary page, when enabled.|
|10523|Agent capacity update history|Agent capacity update history entity records any changes to agent capacity against a capacity profile|
|10524|Bookable Resource Capacity Profile|Bookable Resource Capacity Profile|
|10525|Work stream capacity profile|Work stream capacity profile|
|10526|Conversation Capacity profile|Conversation Capacity profile|
|10527|Conversation Characteristic|Characteristic associated to Omnichannel conversation|
|10528|Session Characteristic|Characteristic associated to Omnichannel session|
|10529|Skill Attachment Rule||
|10530|Attach Skill||
|10531|Model training details|Indicates model's training details|
|10532|Training data import configuration|Indicates the training data import configuration|
|10533|Characteristic mapping|Indicates the mapping of skills from training data to characteristics|
|10534|Training record|Indicates individual training record to be used for model training|
|10535|Skill finder model|Indicates the OmniChannel Model for the corresponding AI model|
|10536|Effort estimate|Entity to persist effort model prediction results|
|10537|Effort estimation model|Indicates the OmniChannel Model for the corresponding AI model|
|10538|Effort model training details|Indicates model's training details|
|10539|ConversationInsight||
|10630|Booking Setup Metadata||
|10631|Actual||
|10632|Client Extension||
|10633|Requirement Characteristic|Requirement Characteristic|
|10634|Bookable Resource Association||
|10635|Configuration|This entity is used to store queries and templates.|
|10636|Booking Alert|Alerts that notify schedule board users of booking issues or information.|
|10637|Booking Alert Status|The status of a booking alert.|
|10638|Booking Change|An internal entity used to track changes that affect the schedule board.|
|10639|Booking Rule|Specify custom rules to be validated by the system before saving a booking record.|
|10640|Business Closure||
|10641|Organizational Unit|Division of the company or organization that has a specific cost price list associated to it.|
|10642|Priority|Priorities to be used on bookings. In addition, a color could be specified for each priority type and the color selected will be shown visually on the schedule board.|
|10643|Requirement Group|Service which has resource requirement offering periods|
|10644|Requirement Organization Unit|Requirement of Organization Unit|
|10645|Requirement Relationship|Relationship of requirements in the group|
|10646|Requirement Resource Category|Requirement Resource Category|
|10647|Requirement Resource Preference|Requirement Resource Preference|
|10648|Requirement Status|Requirement Status|
|10649|Resource Requirement|Entity used to track the high-level information about resource requirements.|
|10650|Resource Requirement Detail|Entity used to track the detailed information about resource requirements.|
|10651|Resource Territory|Allows to specify for which territory a resource could provide services for|
|10652|Schedule Board Setting|To store settings of SB by user & tabs|
|10653|Scheduling Parameter|Scheduling Parameters|
|10654|System User Scheduler Setting|Stores user-specific settings for the schedule board.|
|10655|Fulfillment Preference|Specify time groups consisting of multiple time windows to be used for scheduling, for example.|
|10656|Time Group Detail|Specify individual time windows under a time group.|
|10657|Transaction Origin|System entity used to record the source of a project cost or sales actual.|
|10658|Work template|Template where resource working hours can be saved and reused.|
|10659|Requirement Change||
|10660|Requirement Dependency||
|10661|Scheduling Feature Flag|Update records in this entity to enable a new feature.|
|10662|Time Entry|Entity used  for time entry.|
|10663|Time Source|Settings for Time Entry.|
|10664|Payment Term|Specify payment terms used for billing.|
|10665|Purchase Order|Record Purchase Orders pertaining to Work Orders or otherwise|
|10666|Purchase Order Product|Record products to be ordered on purchase order|
|10667|Purchase Order Receipt|Specify purchase order receipt.|
|10668|Purchase Order Receipt Product|Specify product for purchase order receipt.|
|10669|Ship Via|Specify the different shipping methods used.|
|10670|Tax Code|Store tax related information. Each tax code could contain multiple child tax codes, and in that case the tax rate will be determined by the total tax of all children.|
|10671|Tax Code Detail|In this entity you can link multiple tax codes together to form a group of tax codes to be charged for the customer to form the total tax.|
|10672|Warehouse|Warehouses where inventory products are stored and managed|
|10673|Document Header|The header for the document|
|10674|Document Section|The sections of the document|
|10675|Project|Delivery entity in an engagement.|
|10676|Project Bucket||
|10677|Project Parameter|List of settings that determine the behavior of the project-based service solution.|
|10678|Project Task|Tasks related to project.|
|10679|Project Task Dependency|Dependency data between tasks.|
|10680|Project Team Member|Entity used to model relationship between resources and project teams.|
|10681|Replay Log Header (Deprecated)|Replay log header for the document.|
|10682|Replay Log Section|The sections of the replay log.|
|10683|Resource Assignment|Entity used to keep track of resource assignment header information  on tasks.|
|10684|Resource Request|Entity that wraps the resource requirement to capture the type of resources, skills, and location required.|
|10685|Role competency requirement|Entity used  to associate skills in a role.|
|10689|Deleted Project|(Internal use only) It stores deleted project ids that are not synced up with PSS.|
|10690|Long Running Job Status (For internal use only)|The table tracking the Status of Long Running Jobs (For internal use only).|
|10691|OperationSet|Used to represent operationSets|
|10692|OperationSet Detail|Contains details of each operationSet request|
|10693|Change||
|10694|Project Checklist||
|10695|Project Import Staging|Store uploaded mpp files for Project Import functionality.|
|10696|Project Internal Configuration||
|10697|Issue||
|10698|Project Label|Labels related to project tasks|
|10699|Program||
|10700|Project Request||
|10701|Risk||
|10702|Project Sprint||
|10703|Status Report||
|10704|Project Task Attachment|Entity to store attachment link information for a task|
|10705|Project Task Conversation|Teams Conversations on tasks.|
|10706|Project Task To Label|relationship between project tasks and project labels|
|10707|Project Teams Channel Mapping|Mapping between Project and Teams channel. User can create the mapping by pinning a project into a channel.|
|10708|PSS Error Log|Represents PSS error logs|
|10709|Account Project Price List|Sales price list for this customer to capture special pricing agreements for products, roles and categories.|
|10710|Actuals Configuration|Configuration settings used by the business logic related to msdyn_actual entity.|
|10711|Project Service Approval|Container for approvals.|
|10712|Approval Set|Assist bulk approval processing|
|10713|Batch Job|Placeholder for workflows used for machine learning scenarios.|
|10714|Project Stages|Base entity for process Project Stages|
|10715|Invoice Process|Base entity for process Invoice Process|
|10716|Contact Price List|Specific sales price list for this customer to capture special pricing agreements for products, roles, and categories.|
|10717|Contract Line Detail Performance||
|10718|Project Contract Line Invoice Schedule|List of dates that shows when invoicing for this customer should be run. This list is used by the invoice creation job.|
|10719|Project Contract Line Milestone|List of billing milestones and invoice amounts for this project contract line.|
|10720|Contract Performance|Data related to contract and contractline performance|
|10721|Delegation (Deprecated in v4.0)|Delegation of time, expense entities among users|
|10722|Pricing Dimension||
|10723|Pricing Dimension Field Name|Provides ability to override the field name for pricing dimension if the entity doesn't follow the same naming convention for the pricing dimension field as the price entity.|
|10724|Estimate|Labor, cost, and revenue estimates for a project.|
|10725|Estimate Line|Estimates on a per day timescale.|
|10726|Expense|Main container that holds expense information.|
|10727|Expense Category|Main container that holds expense category information.|
|10728|Expense Receipt|Table that contains expense receipt information.|
|10729|Fact|Aggregated fact entity for actual transactions.|
|10730|Field Computation|Product properties whose values are to be considered as factors for quantity computation on a transaction line.|
|10731|Integration Job|Staging table for integration data|
|10732|Integration Job Detail|Staging table for integration data lines|
|10733|Invoice Frequency|Setup entity for invoice schedules.|
|10734|Invoice Frequency Detail|List of days expressed as dates or day of week for a specific invoice schedule template.|
|10735|Invoice Line Detail|Transactions that are associated to an invoice line.|
|10736|Journal|Unposted business transactions, for example, time and expense.|
|10737|Journal Line|Unposted business transaction line details.|
|10738|Material Usage Log|A log for materials used on projects.|
|10739|Result Cache|Cache for scored work items per resource that are returned from Azure Machine Learning.|
|10740|Opportunity Project Price List|Sales price list that will used by the opportunity to set default sales prices on all project-based components such as time and expense.|
|10741|Project Contract Line Resource Category|List of roles that will be considered as costs when computing the profit of a project contract line.|
|10742|Project Contract Line Detail|Sales estimate detail of an project contract line.|
|10743|Project Contract Line Transaction Category|List of transaction categories that will be considered as costs when computing the profit of a project contract line.|
|10744|Project Contract Line Transaction Classification|List of transaction classification heads, which are four broad cost categories of time, expense, material, and fee, that will be considered as costs when computing the profit of a project contract line.|
|10745|Project Contract Project Price List|Sales price list used on the contract to set default sales prices on all project-based components such as time and expense.|
|10746|Process Notes|Stores messages or notes relevant to an operation or process executed by an entity.|
|10747|Project Approval||
|10748|Project Contract Line Milestone Header|List of Billing milestone and invoice amounts for this project contract line|
|10749|Project Contract Line Customer|Customer associated with the Project Contract Line.|
|10750|Project Contract Line Task|Tasks of the Project that will be billed based on the setup of the Contract Line.|
|10751|Project Contract Retainer|Setup of retainers for a project contract.|
|10752|Project Contract Customer|Customer associated with the Project Contract.|
|10753|Project Parameter Price List|Set of default cost and sales price lists that the company uses when there are no specific pricing agreements for cost and sales.|
|10754|Project Price List||
|10755|Quote Line Customer|Customer associated with the Project Quote Line.|
|10756|Project Quote Line Task|Tasks of the Project that will be billed based on the setup of the Quote Line.|
|10757|Quote Customer|Customer associated with the Project Quote.|
|10758|Project Vendor Invoice|Vendor Invoices for project - based work|
|10759|Project Vendor Invoice Line|Vendor Invoices lines for project - based work|
|10760|Project Vendor Invoice Price List|Purchase price list associated with Vendor Invoice for project-based work.|
|10761|Quote Line Analytics Breakdown|Reporting entity that is used to show quoted sales and estimated cost amounts by various dimensions.|
|10762|Quote Line Invoice Schedule|List of dates on which invoicing for this customer should be run. This list is used by an invoice creation job.|
|10763|Quote Line Resource Category|List of roles that will be considered as costs when understanding the profit of a quote line.|
|10764|Quote Line Milestone|List of billing milestones and invoice amounts for this quote line.|
|10765|Quote Line Detail|Sales estimate detail of a quote line.|
|10766|Quote Line Transaction Category|List of transaction categories that will be considered as costs when computing the profit of a quote line.|
|10767|Quote Line Transaction Classification|List of transaction classification heads, the four broad cost classifications of time, expense, material, and fee, that will be considered as costs when computing the profit of a quote line.|
|10768|Quote Project Price List|Sales price list that will used by the quote to default sales prices on all project-based components such as time and expense.|
|10769|Role Price Markup|List of markups for prices by role on a price list.|
|10770|Role Price|List of prices by role on a price list.|
|10771|Role Price Override|Price Overrides for resource prices in the price list.|
|10772|Role Utilization|Gathers data about utilization per role to display in a chart|
|10773|Subcontract|Subcontracts for project-based work|
|10774|Subcontract Line|Lines associated with Subcontracts for project-based work.|
|10775|Subcontract Line Milestone|Billing Milestones for Subcontracted Lines.|
|10776|Subcontract Line Resource|Subcontractor resources for Subcontracted lines of project work.|
|10777|Subcontract Price List|Purchase price list associated with Subcontracts for project - based work|
|10778|Subcontract Stages|Base entity for process Subcontract Stages|
|10779|Time Off Calendar|Relationship table for time off calendar entries.|
|10780|Transaction Category|Business transaction categories to classify costs and revenue.|
|10781|Transaction Category Classification|Entity used to associate a category broadly as time, expense or material.|
|10782|Transaction Category Hierarchy Element|Hierarchical relationship of the transaction category with a root node.|
|10783|Transaction Category Price|List of prices by category on a price list.|
|10784|Transaction Connection|System entity used to establish connections between the cost, unbilled revenue, and billed revenue components of a transaction as they happen.|
|10785|Transaction Type|Broad classification, such as time or expense, and the context such cost, unbilled revenue, or billed revenue of a project actual.|
|10786|User Work History|Entity used to look up resources based on demonstrated skills.|
|10787|Vendor Invoice Business Process|Base entity for process Vendor Invoice Business Process|
|10792|Sales usage telemetry reports|Sales usage telemetry reports|
|10793|Sales usage reporting|Sales usage reporting|
|10794|Real Time Scoring|Stores meta data information for real time scoring.|
|10795|Viva Sales customer list||
|10796|msdyn_vivaentitysetting|Entity level settings for Viva Sales|
|10797|msdyn_vivaorgsetting|Org level settings for Viva apps|
|10798|msdyn_vivausersetting|User level settings for Viva Sales|
|10799|TdsMetadata||



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

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the msdyn_callablecontext table is the first table in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_callablecontext_msdyn_playbooktemplate"></a> msdyn_callablecontext_msdyn_playbooktemplate

IntersectEntityName: msdyn_callablecontext_msdyn_playbooktemplate<br />
#### Table 1

|Property|Value|
|--------|-----|
|IntersectAttribute|msdyn_callablecontextid|
|IsCustomizable|False|
|LogicalName|msdyn_callablecontext|
|NavigationPropertyName|msdyn_callablecontext_msdyn_playbooktemplate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |

#### Table 2

|Property|Value|
|--------|-----|
|LogicalName|msdyn_playbooktemplate|
|IntersectAttribute|msdyn_playbooktemplateid|
|NavigationPropertyName|msdyn_callablecontext_msdyn_playbooktemplate|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |


### See also

[About the table reference](../about-entity-reference.md)<br />
[Web API Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)<br />