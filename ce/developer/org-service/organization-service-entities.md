---
title: "Organization service entities (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This topic lists the entities available in default deployments of Dynamics 365 Customer Engagement."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 236ceb66-5dde-48bb-bffb-5733fd8548fe
caps.latest.revision: 97
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Organization service entities

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The following table lists the entities available in default deployments of [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. It may be easier for you to see this using the metadata browser. [!INCLUDE[metadata_browser](../../includes/metadata-browser.md)]  
  
 The table below shows the default display name, whether the entity can be customized, the ownership type, and whether the entity is available offline. For the most part, customizable entities appear in the customization UI in the web application, while the others do not. The display name of a customizable entity may be changed through system customization.  
  
 The schema name is also the class name used for early-bound programming, however, not all entities support an early-bound class. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create Early Bound Entity Classes with the Code Generation Tool (CrmSvcUtil.exe)](create-early-bound-entity-classes-code-generation-tool.md).  
  
 For a list of intersect entities (used for creating queries), see [Retrieve Records for Many-To-Many Relationships using Intersect Entities](retrieve-records-many-to-many-relationships-intersect-entities.md).  
  
<a name="bkmk_External"></a>   
## Entities for developer use  
 The following entities are visible in the system and can be used by developers.  
  
|Entity type code|Entity logical name|Early bound class name (schema name)|Display name|Is customizable|Ownership type|Description|Is available offline|  
|----------------------|-------------------------|--------------------------------------------|------------------|---------------------|--------------------|-----------------|--------------------------|  
|1|account|Account|Account|True|User owned|Business that represents a customer or potential customer. The company that is billed in business transactions.|True|  
|1001|activitymimeattachment|ActivityMimeAttachment|E-Mail Attachment|True|None|Multipurpose Internet Mail Extensions (MIME) attachment for an email activity.|True|  
|135|activityparty|ActivityParty|Activity Party|False|None|Person or group associated with an activity. An activity can have multiple activity parties.|True|  
|4200|activitypointer|ActivityPointer|Activity|True|User owned|Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.|True|  
|5|annotation|Annotation|Note|True|User owned|Annotation (note) that is attached to one or more objects, including other annotations (notes).|True|  
|2000|annualfiscalcalendar|AnnualFiscalCalendar|Annual Fiscal Calendar|False|None|Year long fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|False|  
|4201|appointment|Appointment|Appointment|True|User owned|Commitment representing a time interval with start/end times and duration.|True|  
|4700|asyncoperation|AsyncOperation|System Job|False|User owned|Process whose execution can proceed independently or in the background.|False|  
|4601|attributemap|AttributeMap|Attribute Map|False|Organization owned|Represents a mapping between attributes where the attribute values should be copied from a record into the form of a new, related record.|True|  
|4567|audit|Audit|Auditing|False|None|Track changes to records for analysis, record keeping, and compliance.|False|  
|9936|azureserviceconnection|AzureServiceConnection|Azure Service Connection|False|Organization owned|Stores connection information for an Azure service|False|  
|4425|bulkdeletefailure|BulkDeleteFailure|Bulk Delete Failure|False|None|Record that was not deleted during a bulk deletion job.|False|  
|4424|bulkdeleteoperation|BulkDeleteOperation|Bulk Delete Operation|False|None|User-submitted bulk deletion job.|False|  
|4406|bulkoperation|BulkOperation|Quick Campaign|True|User owned|System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.|True|  
|4405|bulkoperationlog|BulkOperationLog|Bulk Operation Log|False|None|Log used to track bulk operation execution successes and failures.|False|  
|10|businessunit|BusinessUnit|Business Unit|True|Business owned|Business, division, or department in the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] database.|True|  
|132|businessunitnewsarticle|BusinessUnitNewsArticle|Announcement|False|Organization owned|Announcement associated with an organization.|True|  
|4003|calendar|Calendar|Calendar|False|Business owned|Calendar used by the scheduling system to define when an appointment or activity is to occur.|True|  
|4004|calendarrule|CalendarRule|Calendar Rule|False|None|Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.|True|  
|4400|campaign|Campaign|Campaign|True|User owned|Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.|True|  
|4402|campaignactivity|CampaignActivity|Campaign Activity|True|User owned|Task performed, or to be performed, by a user for planning or running a campaign.|True|  
|4401|campaignresponse|CampaignResponse|Campaign Response|True|User owned|Response from an existing or a potential new customer for a campaign.|True|  
|9404|channelaccessprofileentityaccesslevel|ChannelAccessProfileEntityAccessLevel||False|None|Group of privileges used to categorize users to provide appropriate access to entities.|False|  
|4417|columnmapping|ColumnMapping|Column Mapping|False|None|Mapping for columns in a data map.|False|  
|123|competitor|Competitor|Competitor|True|Organization owned|Business competing for the sale represented by a lead or opportunity.|True|  
|3234|connection|Connection|Connection|True|User owned|Relationship between two entities.|True|  
|3231|connectionrole|ConnectionRole|Connection Role|True|Organization owned|Role describing a relationship between two records.|True|  
|3233|connectionroleobjecttypecode|ConnectionRoleObjectTypeCode|Connection Role Object Type Code|False|None|Specifies the entity type that can play a specific role in a connection.|True|  
|4007|constraintbasedgroup|ResourceGroup|Resource Group|False|Business owned|Group or collection of people, equipment, and/or facilities that can be scheduled.|True|  
|2|contact|Contact|Contact|True|User owned|Person with whom a business unit has a relationship, such as customer, supplier, or colleague.|True|  
|1010|contract|Contract|Contract|True|User owned|Agreement to provide customer service during a specified amount of time or number of cases.|True|  
|1011|contractdetail|ContractDetail|Contract Line|True|None|Line item in a contract that specifies the type of service a customer is entitled to.|True|  
|2011|contracttemplate|ContractTemplate|Contract Template|True|Organization owned|Template for a contract containing the standard attributes of a contract.|True|  
|9753|customcontrol|CustomControl|Custom Control|False|Organization owned|For internal use only.|True|  
|9755|customcontroldefaultconfig|CustomControlDefaultConfig|Custom Control Default Config|False|Organization owned|For internal use only.|True|  
|9754|customcontrolresource|CustomControlResource|Custom Control Resource|False|Organization owned|Custom Control Resource Id.|True|  
|1071|customeraddress|CustomerAddress|Address|True|None|Address and shipping information. Used to store additional addresses for an account or contact.|True|  
|4503|customeropportunityrole|CustomerOpportunityRole|Opportunity Relationship|True|User owned|[!INCLUDE[deprecated](../../includes/deprecated.md)] Relationship between an account or contact and an opportunity.|True|  
|4502|customerrelationship|CustomerRelationship|Customer Relationship|False|User owned|[!INCLUDE[deprecated](../../includes/deprecated.md)] Relationship between a customer and a partner in which either can be an account or contact.|True|  
|7105|dependency|Dependency|Dependency|False|None|A component dependency.|False|  
|1013|discount|Discount|Discount|True|None|Price reduction made from the list price of a product or service based on the quantity purchased.|True|  
|1080|discounttype|DiscountType|Discount List|True|Organization owned|Type of discount specified as either a percentage or an amount.|True|  
|4102|displaystring|DisplayString|Display String|False|Organization owned|Customized messages for an entity that has been renamed.|True|  
|4101|displaystringmap|DisplayString|Display String Map|False|None|Customized messages for an entity that has been renamed.|False|  
|9940|documenttemplate|DocumentTemplate|Document Template|False|Organization owned|Used to store Document Templates in database in binary format.|True|  
|4415|duplicaterecord|DuplicateRecord|Duplicate Record|False|None|Potential duplicate record.|False|  
|4414|duplicaterule|DuplicateRule|Duplicate Detection Rule|True|User owned|Rule used to identify potential duplicates.|False|  
|4416|duplicaterulecondition|DuplicateRuleCondition|Duplicate Rule Condition|True|None|Condition of a duplicate detection rule.|False|  
|1333|dynamicpropertyinstance|DynamicPropertyInstance|Property Instance|False|User owned|Stores the instance of a product property along with its values|True|  
|4202|email|Email|E-mail|True|User owned|Activity that is delivered by using email protocols.|True|  
|9605|emailserverprofile|EmailServerProfile|Email Server Profile|True|User owned|Holds the Email Server Profiles of an organization.|False|  
|9700|entitlement|Entitlement|Entitlement|True|User owned|Defines the amount and type of support a customer should receive.|False|  
|9701|entitlementchannel|EntitlementChannel|Entitlement Channel|False|None|Defines the amount and type of support for a channel.|True|  
|9702|entitlementtemplate|EntitlementTemplate|Entitlement Template|True|Organization owned|Contains predefined customer support terms that can be used to created entitlements for customers.|False|  
|9703|entitlementtemplatechannel|EntitlementTemplateChannel|Entitlement Template Channel|False|None|Contains predefined support terms for a channel to create entitlements for customers.|True|  
|4600|entitymap|EntityMap|Entity Map|False|Organization owned|Represents a mapping between two related entities so that data from one record can be copied into the form of a new, related record.|True|  
|4000|equipment|Equipment|Facility/Equipment|True|Business owned|Resource that can be scheduled.|True|  
|4120|exchangesyncidmapping|ExchangeSyncIdMapping|Exchange Sync Id Mapping|False|User owned|The mapping used to keep track of the IDs for items synced between Dynamics 365 and Exchange.|False|  
|4204|fax|Fax|Fax|True|User owned|Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.|True|  
|1201|fieldpermission|FieldPermission|Field Permission|False|None|Group of privileges used to categorize users to provide appropriate access to secured columns.|False|  
|1200|fieldsecurityprofile|FieldSecurityProfile|Field Security Profile|False|Organization owned|Profile that defines the access level for secured attributes.|False|  
|2004|fixedmonthlyfiscalcalendar|FixedMonthlyFiscalCalendar|Fixed Monthly Fiscal Calendar|False|None|Fixed monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|False|  
|9600|goal|Goal|Goal|True|User owned|Target objective for a user or a team for a specified time period.|True|  
|9602|goalrollupquery|GoalRollupQuery|Rollup Query|True|User owned|Query that is used to filter the results of the goal rollup.|True|  
|4410|import|Import|Data Import|False|User owned|Status and ownership information for an import job.|False|  
|4428|importentitymapping|ImportEntityMapping|Import Entity Mapping|False|None|Mapping for entities in a data map.|False|  
|4412|importfile|ImportFile|Import Source File|False|User owned|File name of file used for import.|False|  
|9107|importjob|ImportJob|Import Job|False|Organization owned|Contains status and the progress information for an import operation that imports entity customizations or translations.|False|  
|4423|importlog|ImportLog|Import Log|False|User owned|Failure reason and other detailed information for a record that failed to import.|False|  
|4411|importmap|ImportMap|Data Map|True|User owned|Data map used in an import.|False|  
|112|incident|Incident|Case|True|User owned|Service request case associated with a contract.|True|  
|4206|incidentresolution|IncidentResolution|Case Resolution|True|User owned|Special type of activity that includes a description of the resolution, billing status, and the duration of the case.|True|  
|7107|invaliddependency|InvalidDependency|Invalid Dependency|False|None|An invalid dependency in the system.|False|  
|1090|invoice|Invoice|Invoice|True|User owned|Order that has been billed.|True|  
|1091|invoicedetail|InvoiceDetail|Invoice Product|True|None|Line item in an invoice containing detailed billing information for a product.|True|  
|4705|isvconfig|IsvConfig|ISV Config|False|Organization owned|XML document used to configure client extension controls.|True|  
|127|kbarticle|KbArticle|Article|True|Organization owned|Structured content that is part of the knowledge base.|True|  
|1082|kbarticlecomment|KbArticleComment|Article Comment|False|None|Comment on a knowledge base article.|True|  
|1016|kbarticletemplate|KbArticleTemplate|Article Template|False|Organization owned|Template for a knowledge base article that contains the standard attributes of an article.|True|  
|9953|knowledgearticle|KnowledgeArticle|Knowledge Article|True|User owned|Organizational knowledge for internal and external use.|True|  
|9954|knowledgearticleincident|KnowledgeArticleIncident|KnowledgeArticle Incident|True|None|Association between an knowledge article and incident.|True|  
|9955|knowledgearticleviews|KnowledgeArticleViews|KnowledgeArticle Views|True|None|No of times an article is viewed per day.|True|  
|9947|knowledgesearchmodel|KnowledgeSearchModel|Knowledge Search Model|False|Organization owned|Configuration for automatic suggestion of knowledge articles using text analytics and search.|False|  
|9930|knowledgebaserecord|KnowledgeBaseRecord|Knowledge Base Record|True|Organization owned|Metadata of knowledge base (KB) articles associated with [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] entities.|False|  
|9957|languagelocale|LanguageLocale|Language|False|Organization owned|Language.|True|  
|4|lead|Lead|Lead|True|User owned|Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.|True|  
|1017|leadaddress|LeadAddress|Lead Address|True|None|Address information for a lead.|True|  
|4207|letter|Letter|Letter|True|User owned|Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.|True|  
|2027|license|License|License|False|None|Stores information about a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] license.|False|  
|4300|list|List|Marketing List|True|User owned|Group of existing or potential customers created for a marketing campaign or other sales purposes.|True|  
|4419|lookupmapping|LookUpMapping|Lookup Mapping|False|None|In a data map, maps a lookup attribute in a source file to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|False|  
|9606|mailbox|Mailbox|Mailbox|True|User owned|Tasks, Contacts, and Appointments delivery method of the mailbox.|False|  
|9608|MailboxTrackingFolder|MailboxTrackingFolder|Mailbox Auto Tracking Folder|False|User owned|Stores data about folders for a mailbox that are auto tracked.|False|  
|9106|mailmergetemplate|MailMergeTemplate|Mail Merge Template|True|User owned|Template for a mail merge document that contains the standard attributes of that document.|True|  
|9603|metric|Metric|Goal Metric|True|Organization owned|Type of measurement for a goal, such as money amount or count.|True|  
|9866|mobileofflineprofile|MobileOfflineProfile|Mobile Offline Profile|False|Organization owned|Information to administer and manage the data available to mobile devices in offline mode.|False|  
|9867|mobileofflineprofileitem|MobileOfflineProfileItem|Mobile Offline Profile Item|False|Organization owned|Information on entity availability to mobile devices in offline mode for a mobile offline profile item.|False|  
|9868|mobileofflineprofileitemassociation|MobileOfflineProfileItemAssociation|Mobile Offline Profile Item Association|False|Organization owned|Information on relationships to be used to follow related entity's records for mobile offline profile item.|False|  
|2003|monthlyfiscalcalendar|MonthlyFiscalCalendar|Monthly Fiscal Calendar|False|None|Monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|False|  
|10000|msdyn_postalbum|msdyn_PostAlbum|Profile Album|False|User owned|Contains user profile images used for identifying posts, stored as attachments.|False|  
|10001|msdyn_postconfig|msdyn_PostConfig|Post Configuration|False|Organization owned|Contains information about the activity feed configuration of an entity.|False|  
|10002|msdyn_postruleconfig|msdyn_PostRuleConfig|Post Rule Configuration|False|Organization owned|Contains information about the configuration of an activity feed rule for an entity.|False|  
|4490|officedocument|OfficeDocument|Office Document|False|None|Stores [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] documents in binary format.|False|  
|9950|officegraphdocument|OfficeGraphDocument|Office Graph Document|False|Organization owned|Office Graph Documents Description.|True|  
|3|opportunity|Opportunity|Opportunity|True|User owned|Potential revenue-generating event or sale to an account that must be tracked through a sales process to completion.|True|  
|4208|opportunityclose|OpportunityClose|Opportunity Close|True|User owned|Activity that is created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.|True|  
|1083|opportunityproduct|OpportunityProduct|Opportunity Product|True|None|Association between an opportunity and a product.|True|  
|4209|orderclose|OrderClose|Order Close|True|User owned|Activity generated automatically when an order is closed.|True|  
|1019|organization|Organization|Organization|True|Organization owned|Top level of the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] business hierarchy. The organization can be a specific business, holding company, or corporation.|True|  
|4420|ownermapping|OwnerMapping|Owner Mapping|False|None|In a data map, maps ownership data from the source file to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|False|  
|9941|personaldocumenttemplate|PersonalDocumentTemplate|Personal Document Template|False|User owned|Used to store Personal Document Templates in database in binary format.|True|  
|4210|phonecall|PhoneCall|Phone Call|True|User owned|Activity to track a telephone call.|True|  
|4418|picklistmapping|PickListMapping|List Value Mapping|False|None|In a data map, maps list values from the source file to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|False|  
|4605|pluginassembly|PluginAssembly|Plug-in Assembly|False|Organization owned|Assembly that contains one or more plug-in types.|True|  
|4619|PluginTraceLog|PluginTraceLog|Plug-in Trace Log|False|Organization owned|Trace and exception information generated by plug-ins and custom workflow activities.|False|  
|4602|plugintype|PluginType|Plug-in Type|False|Organization owned|Type that inherits from the **IPlugin** interface and is contained within a plug-in assembly.|True|  
|4603|plugintypestatistic|PluginTypeStatistic|Plug-in Type Statistic|False|Organization owned|Plug-in type statistic.|False|  
|50|position|Position|Position|True|Organization owned|Contains the position of a user in the hierarchy.|False|  
|8000|post|Post|Posts|False|Organization owned|Activity feed post.|False|  
|8005|postcomment|PostComment|Comments|False|Organization owned|Comment on an activity feed post.|False|  
|8003|postfollow|PostFollow|Follows|False|Organization owned|User following the activity feed of an object.|False|  
|1022|pricelevel|PriceLevel|Price List|True|Organization owned|Entity that defines pricing levels.|True|  
|44|principalobjectattributeaccess|PrincipalObjectAttributeAccess|Field Sharing|False|Organization owned|Defines [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] security principals (users and teams) access rights to secured field for a record.|True|  
|1404|principalsyncattributemap|PrincipalSyncAttributeMap|Principal Sync Attribute Map|False|Organization owned|Maps security principals (users and teams) to synchronization attribute mappings.|True|  
|1023|privilege|Privilege|Privilege|False|None|Permission to perform an action in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] checks for the privilege and rejects the attempt if the user does not hold the privilege.|True|  
|4710|processsession|ProcessSession|Process Session|True|User owned|Information that is generated when a dialog is run. Every time that you run a dialog, a process session is created.|False|  
|4712|processtrigger|ProcessTrigger|Process Trigger|True|None|The condition that triggers a rule.|True|  
|1024|product|Product|Product|True|Organization owned|Information about products and their pricing information.|True|  
|1025|productassociation|ProductAssociation|Product Association||Organization owned|Instance of a product added to a bundle or kit.||  
|1026|productpricelevel|ProductPriceLevel|Price List Item|True|None|Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.|True|  
|1028|productsubstitute|ProductSubstitute|Product Relationship|True|Organization owned|Information about the selling relationship between two products, including the relationship type, such as up-sell, cross-sell, substitute or accessory.|True|  
|7101|publisher|Publisher|Publisher|True|Organization owned|A publisher of a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] solution.|True|  
|7102|publisheraddress|PublisherAddress|Publisher Address|False|None|Address and shipping information. Used to store additional addresses for a publisher.|True|  
|2002|quarterlyfiscalcalendar|QuarterlyFiscalCalendar|Quarterly Fiscal Calendar|False|None|Quarterly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.|False|  
|2020|queue|Queue|Queue|True|User owned|A list of records requiring action, such as accounts, cases, and activities.|True|  
|2029|queueitem|QueueItem|Queue Item|True|None|A specific item in a queue, such as a case record or an activity record.|True|  
|1084|quote|Quote|Quote|True|User owned|Formal offer for products and/or services, proposed at specific prices and related payment terms that is sent to a prospective customer.|True|  
|4211|quoteclose|QuoteClose|Quote Close|True|User owned|Activity generated when a quote is closed.|True|  
|1085|quotedetail|QuoteDetail|Quote Product|True|None|Product line item in a quote. The details include such information as product ID, description, quantity, and cost.|True|  
|9938|recommendationcache|RecommendationCache|Recommendation Cache|False|None|Temporary storage for results from the Azure Recommendation service.|False|  
|9933|recommendationmodel|RecommendationModel|Product Recommendation Model|False|Organization owned|The product recommendation model built using the Azure Recommendations service to provide cross.|False|  
|9934|recommendationmodelmapping|RecommendationModelMapping|Model Entity Mapping|False|Organization owned|Entity mapping for the product recommendation model..|False|  
|9935|recommendationmodelversion|RecommendationModelVersion|Recommendation Model Version|False|Organization owned|The product recommendation model version that's built using the Azure recommendation service.|False|  
|9937|recommendationmodelversionhistory|RecommendationModelVersionHistory|Recommendation Model Version Execution History|False|Organization owned||False|  
|4250|recurrencerule|RecurrenceRule|Recurrence Rule|False|User owned|Represents the pattern of incidence of recurring entities.||  
|4251|recurringappointmentmaster|RecurringAppointmentMaster|Recurring Appointment|True|User owned|The master appointment of a recurring appointment series.|True|  
|4500|relationshiprole|RelationshipRole|Relationship Role|False|Organization owned|[!INCLUDE[deprecated](../../includes/deprecated.md)] Relationship between an account or contact and an opportunity.|True|  
|4501|relationshiprolemap|RelationshipRoleMap|Relationship Role Map|False|None|[!INCLUDE[deprecated](../../includes/deprecated.md)] Mapping of the primary associated objects between which the relationship role is valid.|True|  
|9100|report|Report|Report|True|User owned|Data summary in an easy-to-read layout.|True|  
|9102|reportcategory|ReportCategory|Report Related Category|True|None|Categories related to a report. A report can be related to multiple categories.|True|  
|9101|reportentity|ReportEntity|Report Related Entity|False|None|Entities related to a report. A report can be related to multiple entities.|True|  
|9104|reportlink|ReportLink|Report Link|False|None|Links and dependencies between reports. A report may drill through to another report, or it may have another report as a sub-report.|True|  
|9103|reportvisibility|ReportVisibility|Report Visibility|False|None|Area in which to show a report. A report can be shown in multiple areas.|True|  
|4002|resource|Resource|Resource|True|Business owned|User or facility/equipment that can be scheduled for a service.|True|  
|4005|resourcegroup|ResourceGroup|Scheduling Group|True|Business owned|Resource group or team whose members can be scheduled for a service.|True|  
|4006|resourcespec|ResourceSpec|Resource Specification|False|Business owned|Selection rule that lets the scheduling engine select a number of resources from a pool of resources. The rules can be associated with a service.|True|  
|1120|ribboncustomization|RibbonCustomization|Application Ribbons|False|Organization owned|Ribbon customizations for the application ribbon and entity ribbon templates.|True|  
|1036|role|Role|Security Role|True|Business owned|Grouping of security privileges. Users are assigned roles that authorize their access to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|True|  
|9604|rollupfield|RollupField|Rollup Field|True|None|Field to be rolled up to calculate the actual and in-progress values against the goal.|True|  
|1038|salesliterature|SalesLiterature|Sales Literature|True|Organization owned|Storage of sales literature, which may contain one or more documents.|True|  
|1070|salesliteratureitem|SalesLiteratureItem|Sales Attachment|False|None|Item in the sales literature collection.|True|  
|1088|salesorder|SalesOrder|Order|True|User owned|Quote that has been accepted.|True|  
|1089|salesorderdetail|SalesOrderDetail|Order Product|True|None|Line item in a sales order.|True|  
|1039|savedquery|SavedQuery|View|True|Organization owned|Saved query against the database.|True|  
|1111|savedqueryvisualization|SavedQueryVisualization|System Chart|True|Organization owned|Entity to store a visualization attached with a view.|True|  
|4606|sdkmessage|SdkMessage|Sdk Message|False|Organization owned|Message that is supported by the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)].|True|  
|4607|sdkmessagefilter|SdkMessageFilter|Sdk Message Filter|False|Organization owned|Filter that defines which [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)] messages are valid for each type of entity.|True|  
|4608|sdkmessageprocessingstep|SdkMessageProcessingStep|Sdk Message Processing Step|False|Organization owned|Stage in the execution pipeline that a plug-in is to execute.|True|  
|4615|sdkmessageprocessingstepimage|SdkMessageProcessingStepImage|Sdk Message Processing Step Image|False|Organization owned|A copy of an entity's attributes before or after the core system operation.|True|  
|4616|sdkmessageprocessingstepsecureconfig|SdkMessageProcessingStepSecureConfig|Sdk Message Processing Step Secure Configuration|False|Organization owned|Non-public custom configuration that is passed to a plug-in's constructor.|False|  
|2001|semiannualfiscalcalendar|SemiAnnualFiscalCalendar|Semi-annual Fiscal Calendar|False|None|Calendar representing the semi-annual span of time during which the financial activities of an organization are calculated.|False|  
|4001|service|Service|Service|True|Organization owned|Activity that represents work done to satisfy a customer's need.|True|  
|4214|serviceappointment|ServiceAppointment|Service Activity|True|User owned|Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.|True|  
|4618|serviceendpoint|ServiceEndpoint|Service Endpoint|False|Organization owned|Service endpoint that can be contacted.|False|  
|9508|sharepointdocumentlocation|SharePointDocumentLocation|Document Location|True|User owned|Document libraries or folders on a [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] from where documents can be managed in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|False|  
|9502|sharepointsite|SharePointSite|SharePoint Site|True|User owned|[!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] site from where documents can be managed in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|False|  
|9951|similarityrule|SimilarityRule|Similarity Rule|False|Organization owned||False|  
|4009|site|Site|Site|True|Organization owned|Location or branch office where an organization does business. An organization can have multiple sites.|True|  
|4709|sitemap|SiteMap|Site Map|False|Organization owned|XML data used to control the application navigation pane.|True|  
|9752|slakpiinstance|SLAKPIInstance|SLA KPI Instance|True|User or team owned|Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case.|True|  
216|socialactivity|SocialActivity|Social Activity|True|User owned|Activity that is delivered using social protocols.|False|  
|99|socialprofile|SocialProfile|Social Profile|True|User owned|This entity is used to store social profile information of its associated account and contacts on different social channels.|False|  
|7100|solution|Solution|Solution|True|Organization owned|A solution that contains customizations.|True|  
|7103|solutioncomponent|SolutionComponent|Solution Component|False|None|A component of a solution.|True|  
|129|subject|Subject|Subject|True|Organization owned|Information regarding subjects available in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|True|  
|45|subscriptionstatisticsoffline|SubscriptionStatisticsOffline|Subscription Statistic Offline|False|None|Subscription Statistic Offline.|False|  
|46|subscriptionstatisticsoutlook|SubscriptionStatisticsOutlook|Subscription Statistic Outlook|False|None|Subscription Statistic Outlook.|False|  
|47|subscriptionsyncentryoffline|SubscriptionSyncEntryOffline|Subscription Sync Entry Offline|False|None|Used for offline sync, internal use only.|False|  
|48|subscriptionsyncentryoutlook|SubscriptionSyncEntryOutlook|Subscription Sync Entry Outlook|False|None|Used for outlook sync, internal use only.|False|  
|1401|syncattributemapping|SyncAttributeMapping|Sync Attribute Mapping|False|None|Synchronization attribute mappings used to provide attribute mappings during synchronization for a particular user or team.|False|  
|1400|syncattributemappingprofile|SyncAttributeMappingProfile|Sync Attribute Mapping Profile|False|Organization owned|Stores profile information used to map synchronization attribute mapping data to users or teams.|False|  
|9869|syncerror|SyncError|Sync Error|False|User owned|Failure reason and other detailed information for a record that failed to sync.|False|  
|1030|systemform|SystemForm|System Form|False|Organization owned|Organization-owned entity customizations, including form layout and dashboards.|True|  
|8|systemuser|SystemUser|User|True|Business owned|Person with access to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] and who can own records.|True|  
|4212|task|Task|Task|True|User owned|Generic activity representing work needed to be done.|True|  
|9|team|Team|Team|True|Business owned|Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different business units.|True|  
|1403|teamsyncattributemappingprofiles|TeamSyncAttributeMappingProfiles|Team Sync-Attribute Mapping Profiles|False|None|Mapping between the synchronization attribute mapping and teams.|False|  
|92|teamtemplate|TeamTemplate|Team Template|True|None|Team template for an entity enabled for automatically created access teams.|False|  
|2010|template|Template|E-mail Template|True|User owned|Template for an email message that contains the standard attributes of an email message.|True|  
|2013|territory|Territory|Territory|True|Organization owned|Represents sales regions.|True|  
|9945|textanalyticsentitymapping|TextAnalyticsEntityMapping|Text Analytics Entity Mapping|False|Organization owned||False|  
|2015|theme|Theme|Theme|False|Organization owned|Contains information to set custom visual theme options for client applications.|True|  
|4810|timezonedefinition|TimeZoneDefinition|Time Zone Definition|False|None|Definition of a time zone, including name and time zone code.|True|  
|4812|timezonelocalizedname|TimeZoneLocalizedName|Time Zone Localized Name|False|None|Localized name of the time zone.|True|  
|4811|timezonerule|TimeZoneRule|Time Zone Rule|False|None|Definition for time conversion between local time and Coordinated Universal Time (UTC) for a particular time zone at a particular time period.|True|  
|9948|topic|Topic|Text Analytics Topic|False|None|Text Analytics Topics.|False|  
|9946|topichistory|TopicHistory|Topic History|False|None|Entity for Topic History.|False|  
|9944|topicmodel|TopicModel|Topic Model|False|Organization owned|The model for automatic identification of topics using text analytics.|False|  
|9942|topicmodelconfiguration|TopicModelConfiguration|Topic Model Configuration|False|Organization owned|Configuration settings for identification of topics using text analytics.|False|  
|9943|topicmodelexecutionhistory|TopicModelExecutionHistory|Topic Model Execution History|False|Organization owned|Entity for Topic Model Execution History.|False|  
|9105|transactioncurrency|TransactionCurrency|Currency|True|Organization owned|Currency in which a financial transaction is carried out.|True|  
|4426|transformationmapping|TransformationMapping|Transformation Mapping|False|None|In a data map, maps the transformation of source attributes to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] attributes.|False|  
|4427|transformationparametermapping|TransformationParameterMapping|Transformation Parameter Mapping|False|None|In a data map, defines parameters for a transformation.|False|  
|1055|uom|UoM|Unit|True|None|Unit of measure.|True|  
|1056|uomschedule|UoMSchedule|Unit Group|True|Organization owned|Grouping of units.|True|  
|2501|userentityinstancedata|UserEntityInstanceData|UserEntityInstanceData|False|User owned|Per user item instance data.|True|  
|2500|userentityuisettings|UserEntityUISettings|User Entity UI Settings|False|User owned|Stores user settings for entity views.|True|  
|1031|userform|UserForm|User Dashboard|False|User owned|Information about user-owned dashboards.|True|  
|2016|UserMapping|UserMapping|User Mapping|False|Organization owned|Used to specify custom claim mappings in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] to use a value other than the default value used by [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] to authenticate and authorize [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] users in [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]nt.|False|  
|4230|userquery|UserQuery|Saved View|True|User owned|Saved database query that is owned by a user.|True|  
|1112|userqueryvisualization|UserQueryVisualization|User Chart|True|User owned|Visualization attached to a saved view.|True|  
|150|usersettings|UserSettings|User Settings|False|Business owned|User's preferred settings.|True|  
|9333|webresource|WebResource|Web Resource|False|Organization owned|Data equivalent to files used in Web development. Web resources provide client-side components that are used to provide custom user interface elements.|True|  
|4703|workflow|Workflow|Process|True|User owned|Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.|False|  
|4704|workflowdependency|WorkflowDependency|Workflow Dependency|False|None|[!INCLUDE[deprecated](../../includes/deprecated.md)] Dependencies for a workflow.|False|  
|4706|workflowlog|WorkflowLog|Process Log|False|User owned|Log used to track process execution.|False|  
  
<a name="Internal"></a>   
## Internal entities  
 The following entities are visible in the system but have no supported developer scenarios.  
  
|Entity type code|Entity logical name|Display name|Ownership type|  
|----------------------|-------------------------|------------------|--------------------|  
|4707|applicationfile|Application File|Organization owned|  
|1002|attachment|Attachment|None|  
|1094|authorizationserver|Authorization Server|Organization owned|  
|4232|businessdatalocalizedlabel|Business Data Localized Label|None|  
|4725|businessprocessflowinstance|Business Process Flow Instance|None|  
|6|businessunitmap|Business Unit Map|None|  
|3005|ChannelAccessProfile|Channel Access Profile|User owned|  
|9404|channelaccessprofileentityaccesslevel|Channel Access Profile Entity Access Level|None|  
|3005|channelaccessprofile|Channel Access Profile|User owned|  
|9401|channelaccessprofileruleitem|Channel Access Profile Rule Item|None|  
|9400|channelaccessprofilerule|Channel Access Profile Rule|User owned|  
|1236|channelproperty|Channel Property|Organization owned|  
|1234|channelpropertygroup|Channel Property Group|Organization owned|  
|113|childincidentcount|Child Incident Count|None|  
|36|clientupdate|Client update|None|  
|4215|commitment|Commitment|None|  
|1004|competitoraddress|Competitor Address|None|  
|9650|complexcontrol|Process Configuration|Organization owned|  
|9300|convertrule|Case Creation Rule|User owned|  
|9301|convertruleitem|Case Creation Rule Item|None|  
|7108|dependencyfeature|Dependency Feature|None|  
|7106|dependencynode|Dependency Node|None|  
|126|documentindex|Indexed Article|None|  
|1048|dynamicproperty|Property|Organization owned|  
|1235|dynamicpropertyassociation|Property Association|Organization owned|  
|1049|dynamicpropertyoptionsetitem|Property Option Set Item|Organization owned|  
|4023|emailhash|E-Mail Hash|None|  
|4299|emailsearch|E-Mail Search|None|  
|3008|externalparty|External Party|User owned|  
|9987|externalpartyitem|External Party Item|None|  
|30|filtertemplate|Filter Template|None|  
|8840|hierarchyrule|||  
|9919|hierarchysecurityconfiguration|||  
|1007|imagedescriptor|Image Descriptor|None|  
|4413|importdata|Import Data|User owned|  
|3000|integrationstatus|Integration Status|Organization owned|  
|1003|internaladdress|Internal Address|None|  
|4011|interprocesslock|Inter Process Lock|None|  
|9607|mailboxstatistics|Mailbox Statistics|Organization owned|  
|4231|metadatadifference|Metadata Difference|None|  
||msdyn_wallsavedquery|Wall View|Organization owned|  
||msdyn_wallsavedqueryusersettings|Filter|User owned|  
|9910|multientitysearch|Multi Entity Search|None|  
|9911|multientitysearchentities|Multi Entity Search Entities|None|  
|4110|notification|Notification|None|  
|4708|organizationstatistic|Organization Statistic|None|  
|1021|organizationui|Organization UI|Organization owned|  
|7|owner|Owner|None|  
|1095|partnerapplication|Partner Application|Organization owned|  
||postlike|Like|Organization owned|  
||postregarding|Post Regarding|None|  
||postrole|Post Role|Organization owned|  
|43|principalattributeaccessmap||None|  
|11|principalobjectaccess||None|  
|90|principalobjectaccessreadsnapshot||None|  
|31|privilegeobjecttypecodes|Privilege Object Type Code|None|  
|4724|processstage|Process Stage|None|  
|2023|queueitemcount|QueueItemCount|None|  
|2024|queuemembercount|QueueMemberCount|None|  
|91|recordcountsnapshot||None|  
|1140|replicationbacklog|Replication Backlog|None|  
|4010|resourcegroupexpansion|Resource Expansion|None|  
|1116|ribboncommand|Ribbon Command|Organization owned|  
|1115|ribboncontextgroup|Ribbon Context Group|Organization owned|  
|1130|ribbondiff|Ribbon Difference|Organization owned|  
|1117|ribbonrule|Ribbon Rule|Organization owned|  
|1113|ribbontabtocommandmap|Ribbon Tab To Command Mapping|Organization owned|  
|1037|roletemplate|Role Template|None|  
|9511|rollupjob|Rollup Job|None|  
|9510|rollupproperties|Rollup Properties|None|  
|8181|routingrule|Routing Rule Set|User owned|  
|8199|routingruleitem|Rule Item|None|  
|32|salesprocessinstance|Sales Process Instance|Business owned|  
|4613|sdkmessagepair|Sdk Message Pair|Organization owned|  
|4609|sdkmessagerequest|Sdk Message Request|Organization owned|  
|4614|sdkmessagerequestfield|Sdk Message Request Field|Organization owned|  
|4610|sdkmessageresponse|Sdk Message Response|Organization owned|  
|4611|sdkmessageresponsefield|Sdk Message Response Field|Organization owned|  
|9509|sharepointdata|SharePoint Data|Organization owned|  
|9507|sharepointdocument|SharePoint Document|User owned|  
|9750|sla|SLA|User owned|  
|9751|slaitem|SLA Item|None|  
|9752|slakpiinstance|SLA KPI Instance|User owned|  
|1300|socialinsightsconfiguration|SocialInsightsConfiguration|None|  
|9613|sqlencryptionaudit|SQL Encryption Audit|None|  
|1075|statusmap|Status Map|Organization owned|  
|1043|stringmap|String Map|Organization owned|  
|29|subscription|Subscription|None|  
|1072|subscriptionclients|Subscription Clients|None|  
|33|subscriptionsyncinfo|Subscription Synchronization Information|None|  
|35|subscriptiontrackingdeletedobject|Tracking information for deleted entities|None|  
|7000|systemapplicationmetadata|System Application Metadata|None|  
|42|systemuserbusinessunitentitymap|SystemUser BusinessUnit Entity Map|None|  
|51|systemusermanagermap|System User Manager Map|None|  
|14|systemuserprincipals|System User Principal|None|  
|9932|timestampdatemapping|Time Stamp Date Mapping|None|  
|8051|traceassociation|Trace Association|None|  
|8050|tracelog|TraceLog|Organization owned|  
|8052|traceregarding|Trace Regarding|None|  
|2012|unresolvedaddress|Unresolved Address|None|  
|7001|userapplicationmetadata|User Application Metadata|User owned|  
|1086|userfiscalcalendar|User Fiscal Calendar|None|  
|4800|webwizard|Web Wizard|Organization owned|  
|4803|wizardaccessprivilege|Web Wizard Access Privilege|Organization owned|  
|4802|wizardpage|Wizard Page|Organization owned|  
|4702|workflowwaitsubscription|Workflow Wait Subscription|None|  
  
### See also  
 [Read and Write Data and Metadata using the IOrganizationService Web Service](use-organization-service-read-write-data-metadata.md)   
 [Sample: Execute multiple requests](sample-execute-multiple-requests.md)   
 [Model your business data](../model-business-data.md)   
 [Entity ownership](../introduction-entities.md#entity-ownership)
