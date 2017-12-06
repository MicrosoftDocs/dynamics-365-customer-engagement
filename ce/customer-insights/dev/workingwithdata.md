---
title: Working with Data in Microsoft Dynamics 365 for Customer Insights (Dynamics 365 Customer Insights SDK) | MicrosoftDocs
description: 
keywords: Customer Insights; data model; ingestion; conflation; segmentation 
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/14/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: dad2bb65-a135-4bc3-8342-a2964c7bcc41
---

Working with Data in Customer Insights
======================================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Customer Insights is essentially a data collection, preparation, modeling, analysis, and presentation service. It provides a solution to the problem of how organizations can best use the increasing volume and types of "big data" they are either amassing or have access to.


## Customer Insights Domain Modeling

As explained in the [Overview](../getstart.md) topic, Customer Insights models any business domain using the following primary platform modeling types. These types typically contain a collection of custom properties that refine the type or provide additional context for its use. The supported fundamental data types for properties are **bool**, **byte**, **datetimeoffset**, **decimal**, **double**, **guid**, **int**, **long**, **short** and **string**.

* A [Profile](../ref/types/profile.md) represents a real-world entity or concept in the business domain, such as an organization, customer, asset, or an email message. Each such domain entity type is modeled as an instance of a corresponding profile type. Profiles describe their associated entities through a collection of properties. Each profile type contains a key, composed of a single property or a combination (_tuple_) of properties that enable the lookup of specific profile instances. 
* A [Relationship](../ref/types/relationship.md) represents an explicit connection between two different profile types. For example, a new customer might be assigned to a specific salesperson. A profile may have any number of associated relationships. Relationships always have a primary (forward) direction, although a relationship can always be navigated forward (from source to target) or backward (from target to source). A model may or may not contain a mirror relationship that explicitly denotes the reverse connection. For example, **SalespersonCustomer** and **CustomerSalesperson** relationships would mirror each other. <br> Note that Customer Insights can also discover implicit relationships, as described in the section _Relationship analysis_ below.
* An [Interaction](../ref/types/interaction.md) represents a business event, process or activity. Interactions are usually performed by or target a primary profiled entity, although they may also have secondary participants or targets. Interactions are commonly used to model transactions and interchanges across line-of-business (LOB) systems or communication channels. By default, interaction instances are immutable—once created they cannot be modified or deleted. Another interaction within the same business process, usually at a later time, is represented by a new interaction instance. In this way, time-series representations of processes are supported. (Interactions have an associated system property called **Timestamp** that typically indicates when the interaction was created or last updated in the Customer Insights service.) 
<br>
An _Activity_ is a special category of Interaction that represents an ongoing business process.  An activity is mutable and is often periodically enriched with data from multiple data sources (for example, from connectors or interactions using links). An Interaction is marked as an Activity by setting the **isActivity** property to true during creation. 

* A [Link](../ref/types/link.md) associates an Interaction to a Profile. Links are often represent a single action or activity, for example deposit being made into a bank branch. Links come in two varieties, reference and non-reference links. 
    * Reference links refer to the source of their data in another entity instance. As a result they "contain" the most recent value for that field.
    * A non-reference link contains a copy of the data from the entity/field to which it is associated with. Non-reference links perform the vital roll in _upset_ operations, where Profile or Interaction instances are populated from a data source (using an appropriate connector).
* A [RelationshipLink](../ref/types/relationshiplink.md) associates a Relationship with an Interaction. A relationship link represents one mechanism to either create or update a relationship instance from an interaction. 

<!--TODO: Graphic of these entities-relationships would be nice. -->

Other entities fortify this primary model, including: [Segments](../ref/types/segment.md) enable subgrouping, [KPIs](../ref/types/kpi.md) define metrics, and so on.

### Model Ontology and Implementation
Customer Insights implements an extensible entity framework based upon the [Schema.org](http://schema.org/) ontology. Customer Insights implements its business models as custom [graph databases](https://en.wikipedia.org/wiki/Graph_database). Each Customer Insights tenant has its own instance of a graph database with its own customized ontology. The following table lists the equivalent entity types between these two platforms as well as the graph implementation type for that entity.  Customer Insights uses the [Graph Extensions in Microsoft SQL Server 2017](https://docs.microsoft.com/en-us/sql/relational-databases/graphs/sql-graph-overview) to store instances of these entity-relationships. 

|**Customer Insights Entity**|**Schema.org Entity**|**Implementation**| 
| --------------- | ---------- | ------------- | 
| [Profile](../ref/types/profile.md) | [Thing](http://schema.org/Thing) | node |
| [Relationship](../ref/types/relationship.md) | <!-- TODO:??? --> | edge |
| [Interaction](../ref/types/interaction.md) | [Action](http://schema.org/Action) | edge (but sometimes node) |
| [Link](../ref/types/link.md) (reference)| <!-- TODO:??? --> | edge |
| [RelationshipLink](../ref/types/relationshiplink.md) | <!-- TODO:??? --> | edge |
| | | |

<!-- TODO: Need remaining schema.org analogs.  Need explanation why Interaction can be both node and edge. -->

If you are using or plan to incorporate a Schema.org schema into your solution's data model, Customer Insights provides support through the **SchemaItemTypeLink** and **SchemaItemPropLink** properties found in the various entity types, such as Profile, Interaction, and Field.


### Custom Type Structure and Implementation

Developers may find it beneficial to understand how the primary custom types are constructed in Customer Insights.

Each of the [Profile](../ref/types/profile.md) types defined on the hub become an [open entity type](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part3-csdl/odata-v4.0-errata03-os-part3-csdl-complete.html#_The_edm:OpenType_Attribute) on the 
OData API for the hub, and each has an entity set of its own (defined by the *ApiEntitySetName* parameter when the Profile type is defined. Each of the Profile entity types have a key field called *ProfileId* (edm string type) that acts as the key for the Profile entity set feed. The ProfileId is generated based on the *IdPropertyNames* specified in the Profile type model when the Profile type is created. Basically it is a concatenation of the values of the Id properties (using '_' as the separator) in lexical order. Each of the Profile entity types also has a navigation link to Interactions associated with the Profile. 

[Interactions](../ref/types/interaction.md) are exposed by the *Interactions* entity set, and are backed by an open entity Type 'Interaction'. Interaction entity type has three declared fields: *InteractionId* (edm string), *InteractionType* (edm string), and *Timestamp* (edm datetimeoffset). InteractionId is generated in similar way as ProfileId described above, using the *IdPropertyNames* for the modeled Interaction type. If the IdPropertyNames are not specified for an Interaction type, then the system generates the InteractionId. *InteractionType* is the name of the modeled Interaction type. Timestamp is system generated if the *TimeStampPropertyName* is not used when modeling the Interaction type.

<!-- TODO: How about other primary types? -->

### Key Performance Indicators (KPIs)
A [KPI](../ref/types/kpi.md) is a quantifiable measure of progress or success against a business objective. As such they represent a form of simple data analysis. Customer Insights supports the definition of KPIs based upon properties of the Profile or Interaction types. Depending upon the connector and data source used, KPIs may be imported from the data source.  More likely, KPIs are defined either through the user interface (see [Data Modeling](../deploy/datamodeling.md)) or through the KPI Management ([ARM](../ref/arm/kpimngnt.md) or [Hub](../ref/hub/kpimngnt.md)) APIs.

A KPI can be used to modify a property of a Profile. Such a KPI is called an _enriching KPI_. Enriching KPIs for a specific profile type can be obtained through the Get Enriching KPIs operation, available in both the [ARM](../ref/arm/profilegetenrichingkpis.md) or [Hub](../ref/hub/profilegetenrichingkpis.md) APIs.

## Data Sources and Ingestion

Data sources are used to populate or _enrich_ type instances within a Customer Insights solution. There are three primary sources of data:

* External data sources via connectors
* Internally generated data via [Link](../ref/types/link.md) definitions or enriching KPIs
* Direct data injection using the [Hub Data APIs](../ref/hubdataapiref.md) (external and/or internally generated data)

For more information about adding data sources though the user interface, see [Add a Data Source](../deploy/adddatasource.md). 

The typical application will see the majority of its data imported from external sources—including other Dynamics 365 applications—in a process called _data ingestion_. Customer Insights can work with a wide variety of data with the following characteristics:

* Structured, semi-structured, or unstructured data
* Fixed or dynamic schema
* One-time static, periodic or streaming (dynamic) content 

Customer Insights automatically updates dynamic content on a periodic basis. By default, the refresh rate is set to 15 minutes. Data ingestion involves several general steps:

1. Reading the external data
2. Mapping the data onto the appropriate (new or existing) Customer Insights data model
3. Creating the corresponding instances of Customer Insights entities 

Customer Insights provides a set of standard _inbound connectors_ to enable ingestion from popular data sources, including the Dynamics 365 Customer Engagement Connector and the Azure Storage (blob) Connector. Additional third party connectors will be offered in the [AppSource](https://appsource.microsoft.com/) marketplace. For more information about programmatic access, see the [Connector](../ref/types/connector.md) entity type.  For more information about the user experience (UX) around selecting data sources, see  [Add a data source](../deploy/adddatasource.md).

### Standard Connectors

The following table compares the standard connectors with respect to some common connector characteristics. In the table, "source" refers to the data source, whereas "target" refers to the associated Customer Insights data model (or instances thereof).

|**Connector Characteristic**|**Customer Engagement Connector**|**Azure Storage Connector**| 
| --------------- | ---------- | ------------- | 
|Compatible data sources|Dynamics 365 Customer Engagement solution|Azure blob |
|Data modeling and mapping|Connector understands and automatically maps source types to target types, creating target entity types where required.|Requires interactive user input to map source and target types.|
|Data preparation|Connector automatically prepares and transforms source data|User can chose from a limited set of data formatting transformations|
|Data sync policy and frequency|Automatically performs full sync initially and re-syncs whenever source data changes|Users specify sync policy and frequency|
|Data metadata changes|Automatically updates target data model|Users must manage changes manually|
| | | |

<!-- TODO: Add other connectors when release finalized. -->

## Profile Predictive Matching 
Data that is ingested from multiple data sources often contains information about the same entity. Unfortunately, without a shared unique identifier, it is non-trivial to match the same entity instance across data sources. _Predictive matching_, sometimes called  _conflation_, enables this matching, based upon contextual information.  This feature also optionally enables merging these separate references based upon specified criteria. By combining information in this way, data is enriched. (Conflation is also useful in duplicate record detection and removal.) Note that conflation is generally a non-trivial process because different sources rarely use a shared unique entity identifier, and data quality often varies between sources.

Customer Insights offers optional conflation processing that initially supports:

* Profile-to-profile matching, where the profiles represent individuals or organizations. Matching typically focusses on common properties such as name, title, address, email address, phone number, organization name, and web domain.
* Profile-to-interaction matching, useful where the original source for the interaction data does not contain separate, well-defined profile information.

Predictive matching works across common name spellings, nicknames, partial data (e.g. partial phone numbers or addresses), and organization membership. This process is controlled by an associated _conflation policy_, which also contains a _match threshold_ that indicates the minimum strength required for acceptance of a match.

For more information about the conflation UX, see [Predictive matching](../deploy/createconflationpolicy.md). For more information about the programming interface, see [Predictive Matching Policy APIs](../ref/hub/predmatchpolmngnt.md).

<!-- TODO: Spec mentions profile-to-interaction conflation, but is this supported in Potassium? Is Bing Predicts, LinkedIn or other going to be a natively supported common data source for matching? -->

## Relationship Analysis 
In addition to relationships explicitly specified by the data model, Customer Insights can discover "hidden relationships" in data sets.  These come in two varieties: 

* Indirect relationships occur when entities are involved in the same interaction, share the same resource or characteristic, or have a order-removed relationship.  Examples include items frequently purchased together suggestions, people who share the same home phone number, and friend-of-friend networking. 
* Inferred relationships are only be deduced through contextual or statistical analysis. For example, political affiliation might be inferred based upon characteristics such as home zip code, occupation, club memberships, and so on.

For more information, see the _Suggest Relationships for Interaction Type_ [ARM](../ref/arm/interactionsugrellinks.md) or [Hub](../ref/hub/interactionsugrellinks.md) operations.


## Data Segmentation
Even with advanced analysis and metrics, it is often difficult to perceive trends within a large entity set. Customer Insights supports the process of [segmentation](https://en.wikipedia.org/wiki/Market_segmentation), subdividing the set into multiple subsets based upon specified criteria. Although segmentation is commonly used for marketing investigations of and campaigns with current or potential customers, it is a powerful general-purpose tool for understanding subgroups in a larger population. Designing appropriate segments is critical to such efforts, as segments can depend on a wide range of profile properties, interactions, and relationships with other entities. 

Segments can either have _static_ membership, _dynamic_ membership based upon a query expression, or some _compounding_ of the two. [Segments](../ref/types/segment.md) are native types in Customer Insights, and the full range of CRUD operations is supported, as described in the topic [Segmentation Management APIs (Hub)](../ref/hub/segmngnt.md).  Segmentation is also supported extensively through the _Segment Exploration_ and _Segment Builder_ user experiences; for more information, see [Segment your insights](../deploy/createasegment.md). 


## Predictive Scoring
While predictive matching assists in intelligently conflating ingested records, predictive scoring applies machine learning (ML) to analyze modeled data against a business objective specified by the user. The result of this analysis is a relative weighting for each profile instance against the objective. Then the user can apply thresholds and relative gradings against these results. Once configured, prediction scoring is automatically applied against relevant incoming data. The following table outlines the general process followed when using predictive scoring. 

|**Processing Step**|**Responsible Party**|**Description/Notes**| 
| ----------------- | ------------------- | ------------- | 
|Specification of business objective (outcome)|User/Programmer|Outcome data must already exist in the model or be readily calculated.|
|Sample data analysis|Prediction engine|Applies machine learning techniques to the Customer Insights solution model: <br> 1. Analyzes and prepares model data <br> 2. Selects best positive and negative features (descriptive model) <br> 3. Creates predictive model (best-fit learning algorithm) <br> 4. Validates and iteratively improves model |
|Score relevant profiles|Prediction engine|Applies predictive model with identified factors to score associated profiles|
|Grading of profiles|User/Programmer|Application of thresholds to "bucketize" profiles by expected outcomes|
|Prediction insights|User|Examination of predictive results leads to better business management (resource allocation and process optimization)|
| | | |

Much of complexity of using traditional machine learning techniques—such as feature selection, learning algorithm selection and training-testing cycles—occur automatically and are thus mostly hidden from the user. 

<!--
The July 2017 Refresh of Customer Insights only supports lead scoring through its user interface. For more information about the predictive scoring UX, see [Predictive Scoring](../deploy/leadscoring.md). For more information about [Prediction](../ref/types/prediction.md) APIs, see Predictive Scoring APIs ([ARM](../ref/arm/predscoringmngnt.md) or [Hub](../ref/hub/predscoringmngnt.md)).
-->