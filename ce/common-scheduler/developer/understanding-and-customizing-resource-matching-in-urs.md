---
title: Understanding and customizing resource matching in Universal Resource Scheduling | Microsoft Docs
description: Understanding and customizing resource matching in Universal Resource Scheduling
author: FieldServiceDave
ms.author: daclar
ms.date: 06/14/2018
ms.reviewer: krbjoran
ms.service: crm-online
ms.topic: article
ms.custom: 
  - dyn365-projectservice
  - dyn365-fieldservice
search.app: 
  - D365CE
  - D365PS
  - D365FS
---

# Understanding and customizing resource matching in Universal Resource Scheduling

Universal Resource Scheduling, the scheduling engine underlying Dynamics 365 Field Service and Project Service Automation, ships with extensive resource matching capabilities to book the right resources for a job. While the Universal Resource Scheduling solution ships with Field and Project service, Universal Resource Scheduling can also be used to schedule any workstream in Dynamics 365. In this article, we'll take a look at how the built-in resource constraints are implemented and how to customize Universal Resource Scheduling with custom resource constraints.

## Resources, Requirements, and Constraints

### Resources

Core to Universal Resource Scheduling is the Resource (`bookableresource`) entity. When Booking (`bookableresourcebooking`) records are created, they are associated with a Resource record. To ensure the correct resource is selected, Universal Resource Scheduling ships with many built-in filters and constraints to categorize resources by. Examples are: Resource Type, indicating if the resource is a User, Contact, Account, Equipment, etc., Characteristic, to filter resources by skills they are proficient in, Territory, to assign resources to specific regions, Organizational Unit to model an organization hierarchy, and many more.

A Resource record and its associated constraints are modeled through attributes or relationships to other entities. For example, Name and Resource Type are attributes on the Resource entity.  Resource Characteristics and Resource Territories are child relationships since a resource can be associated with more than one of them. These entities are child relationships to both the Resource AND the Characteristic/Territory entity. Organizational Unit is a lookup attribute on the Resource entity to the Organizational Unit entity.

### Requirements

Another important entity in Universal Resource Scheduling is the Resource Requirement (`msdyn_resourcerequirement`) entity. The Requirement entity records a requirement for work to be done. It captures parameters about the demanded work, such as the From and To date fields, restricting the time period in which the work can be done; the Duration field for how long the job is expected to take; the  Work Location indicating the location of the required work. The Requirement entity also captures resource constraints to restrict which resources can fulfill and be booked for this requirement. Like the Resource entity, resource constraints are expressed as attributes on the Requirement entity or as relationships to other entities. Territory is a lookup attribute from the Requirement entity to the Territory entity indicating the territory the work is to be done in and, therefore, we must find a resource from the same territory. Requirement Characteristic is a child relationship relating the Requirement to the Characteristic entity expressing the skills required to complete the job and, therefore, the requirement can be matched to only resources with matching skills.

### Constraints shipped in Universal Resource Scheduling

Following is the list of constraints that ship with Universal Resource Scheduling:

- Characteristics - Can be used to model skills a resource has. It also supports optional ratings values to rate how proficient a resource is at each skill
- Categories - Resources can be associated to categories
- Territories - To assign resources to territorial regions
- Organizational Units - To model an organization hierarchy
- Resource Type - Defines the type of the resource
- Teams - The teams a resource is a member of
- Business Units - Which business unit the resource is part of

### Filtering in the Schedule Board

The Schedule Board shows a list of resources and the bookings assigned to them. The Filter panel in the Schedule Board lets you filter the list of resources by their constraints - for example, selecting a resource type of User in the Resource Type dropdown will filter the resource list to those which are of type User. Similarly, you can filter resources by matching characteristics or territories.

Using the Filter panel to filter resources is one method of finding matching resources. This method is used when you want to manually show a list of resources matching a specific set of constraints.

### Finding available resources with the Schedule Assistant

In the bottom of the Schedule Board, you'll find a list of Requirement records. You can select one of them and choose to find availability. This action opens the Schedule Assistant. The Schedule Assistant uses the constraints captured on the selected Requirement record to find matching resources that are available to be booked. Only resources matching the constraints on the Requirement and which are available in the requested time period specified on the Requirement are shown on the board.

A similar experience is available through a "Book" ribbon button available on the Requirement entity and other schedulable entities in Dynamics 365 list views or forms. When "Book" is clicked, the Schedule Assistant is opened showing resources matching the constraints of the selected Requirement record.

Unlike the previously mentioned Schedule Board mode, where you use the Filter panel to manually filters resources, in Schedule Assistant mode, the Filter panel automatically fills in the resource constraints from the Requirement record and only matching resources are shown.

## How constraints matching works

### Constraints entities

Some constraints are specified as attributes directly on the Resource entity while others are defined through relationships. Relationships are needed when a constraint is referencing a second, master entity.

Let's consider a Resource record and its associated Territory and Characteristic constraints.

First, the master records. We have territories stored in the Territory entity:

Territory |
--- |
New York |
New Jersey |
Seattle |

We also have characteristics in the Characteristic entity:

Characteristic |
--- |
Project Manager |
Designer |
Financial Analyst |

Organizational Unit entity:

Organizational Unit |
--- |
Contoso US |
Contoso EU |

Finally, we have the Resource entity:

Resource | Resource Type | Organizational Unit
--- | --- | ---
Jorge Galt | User | Contoso US
Abraham McCormick | Contact | Contoso EU

While a single Resource record works to capture single-valued constraints, like the Resource Type  and  Organizational Unit above. If we want to associate a Resource to multiple Territory or Characteristic records, we must use a third entity, a many-to-many (N:N) relationship, to store these associations.

We use the Resource Territory entity to associate multiple territories for a resource.

Resource Territory Records:

Resource | Territory
--- | ---
Jorge Galt | New York
Jorge Galt | New Jersey
Abraham McCormick | Seattle

and the Resource Characteristic entity to store multiple characteristics for a resource.

Resource Characteristic Records:

Resource | Characteristic
--- | ---
Jorge Galt | Designer
Abraham McCormick | Project Manager
Abraham McCormick | Financial Analyst

Similar to Resource, a Requirement record captures single-valued constraints and child records store multi-valued constraints.

Here is the Requirement entity:

Requirement | Duration | Territory
--- | --- | ---
Job 1 | 1 hr | New York
Job 2 | 1 hr | Seattle

The Requirement Characteristic entity:

Requirement Characteristic Records:

Requirement | Characteristic
--- | ---
Job 1 | Designer
Job 2 | Project Manager
Job 2 | Financial Analyst

Sometimes, the requirement may have a constraint modeled as a lookup attribute, while the resource may store the matching attributes on the N:N table. For example, for Requirement, the Territory constraint is a lookup attribute to the Territory entity. A Requirement captures a demand for work and the territory the work will be done in. A Resource record, however, can be associated to many Territory records.

### Constraints property bags

When the user selects values in the Filter panel and selects the Search button, the values are sent to the Resource Matching API. For multi-valued constraints, the Filter panel shows the data from the master entities Territory and Characteristic and includes the selected values in the constraints property bag.

Here is a sample property bag with constraints sent to the Resource Matching API:

Name | Value
--- | ---
`ResourceType` | User
`Territories` | New York<br>New Jersey

This tells the **Resource Matching API** to find resources of type User that are associated with the New York or New Jersey territories.

When in the Schedule Assistant, the constraints are first retrieved from a Requirement record through the **Retrieve Requirement Constraints API**. The retrieved constraints are then pre-filled in the Filter panel and sent to the Resource Matching API.

The Retrieve Requirement Constraints API queries the Requirement record and all related child constraints (for example, Requirement Characteristic). It responds with a constraints property bag expressing all the resource constraints captured on the selected Requirement.

Here's a sample response from the Retrieve Requirement Constraints API:

Name | Value
--- | ---
`Requirement` | Job 2
`Duration` | 1 hr
`Territories` | Seattle
`Characteristics` | Project Manager<br>Financial Analyst

The Resource Matching API receives as input the constraints property bag and queries for matching resources. The matching resources are then shown in the Schedule Board or Schedule Assistant.

### Summarizing the entities used for resource matching

- Sample master entities
    - Territory - Referenced as a constraint
    - Characteristic - Referenced as a constraint
    - Resource - Assigned to Bookings
    - Resource Territory - Associates Resources to Territories
    - Resource Characteristic - Associates Resources to Characteristics
- Sample transactional entities
    - Requirement - Captures a demand for work and references Territory
    - Requirement Characteristic - Associates Requirements to Characteristics

### Summarizing the resource matching flows

- Manual filtering. Filter Panel > Resource Matching API

    1. A user manually adds constraints in the Filter panel
    2. The constraints are sent to the Resource Matching API
    3. The filtered list of resources is shown

- Requirement filtering. Retrieve Requirement Constraints API > Filter Panel > Resource Matching API

    1. A user finds availability for a Requirement record (from within the Schedule Board or from the Book button in the ribbon).
    1. The constraints are retrieved through the Retrieve Requirement Constraints API and shown in the Filter panel.
    1. The constraints are sent to the Resource Matching API
    1. The filtered list of resources is shown

## Extending Universal Resource Scheduling with custom constraints

Universal Resource Scheduling can be extended with custom resource constraints. Extending constraints work the same way as the ones build into Universal Resource Scheduling, they are modeled as attributes and relationships in Dynamics 365.

> A step by step guide with code samples needed for each step is described in [Extending Universal Resource Scheduling: Find resources by language - a step by step guide](extending-urs-step-by-step.md)

### Custom constraints

We'll use "language" as an example scenario. An organization wants to filter resources by the language they speak. They also want to capture on the Requirement record the language required for a job. This constraint follows a similar pattern to the built-in Territory constraint. A new master entity Language stores the different languages a resource can speak. A Resource record can be associated to many Languages through a many-to-many relationship entity. On the Requirement entity, we'll create two new lookup attributes: `Required Language` and `Secondary Language`. When finding available resources for a requirement, only resources associated with either the `Required Language` or the `Secondary Language` will be shown.

Since extensible constraints work fully with the relational model of Dynamics 365, any structure used to express constraints can be used in Universal Resource Scheduling. Here's a more powerful example of custom constraints. Let's assume an organization picks up products from a location and delivers them to a customer's location. The Resource entity is extended with a `Maximum Weight` attribute describing the maximum weight it can carry, in case of a vehicle resource. The Requirement entity is related to the Dynamics 365 Product entity with a many-to-many relationship; each Product gets a new `Weight` attribute, too. When a Requirement record is created to capture required work, it is related to all the products required to complete the job. When a user finds availability for a Requirement, the total weight of all related Product records is retrieved and only resources that can carry this weight, defined in the `Maximum Weight` attribute, are returned.

Here, we'll describe the custom language constraint. First, we have our new Language entity:

Language |
--- |
English |
Spanish |

and our new Resource Language many-to-many child entity:

Resource | Language
--- | ---
Jorge Galt | English
Abraham McCormick | English
Abraham McCormick | Spanish

Here is the Requirement entity with our two new attributes, Required Language and Secondary Language representing the languages the resource needs to speak to be matched with this requirement:

Requirement | Duration | Territory | Required Language | Secondary Language
--- | --- | --- | --- | ---
Job 1 | 1 hr | New York | English | ---
Job 2 | 1 hr | Seattle | Spanish | English

### Extensibility points

Based on the [resource matching flows](#summarizing-the-resource-matching-flows) described above, these are the extensibility points we need to modify for our custom constraints to work:

1. Retrieve Requirement Constraints API

    The API needs to read our new Required Language and Secondary Language attributes so when a user finds availability for a Requirement our new constraints are retrieved.

2. Filter panel

    A user should be able to select from a list of Language records in the Filter panel to filter for matching resources. When finding availability for a Requirement, the Filter panel should show the Required Language and Secondary Language from the Requirement record pre-selected in the list of Languages.

3. Resource Matching API

    The API will get as input the new Language constraints; it needs to return only resources speaking the selected languages.

### Extensible queries

Internally, the Retrieve Requirement Constraints API (#1 above) and the Resource Matching API (#3 above) use FetchXML to query data from Dynamics 365. The Retrieve Requirement Constraints API issues multiple queries to retrieve the Requirement record and its child constraints (for example, Requirement Characteristic etc.) The Resource Matching API, based on the resource constraints passed to it as input, will dynamically construct the correct FetchXML query so only Resource records matching the specified FetchXML criteria are returned from Dynamics 365.

In the July 2017 update for Universal Resource Scheduling, to support extensible resource matching, [Universal FetchXML (UFX)](universal-fetchxml.md) was introduced. Two important features UFX adds to FetchXML are: 1) Multiple result sets, a single UFX Query can return results from multiple entities, and 2) Dynamic FetchXML, a UFX Query can dynamically construct FetchXML based on input data.

With UFX, a single query can be constructed to query for a Requirement record and all its child records. The Retrieve Requirement Constraints API executes a customizable UFX Query to retrieve a Requirement and its child constraints. The query can be customized to retrieve custom constraint records as well.

The constraints property bag returned from the Retrieve Requirement Constraints API is passed as input to the Resource Matching API. The API executes a customizable UFX query. With UFX, the query uses the input constraints to dynamically construct the correct FetchXML to find matching resources. This UFX query, too, can be modified to construct the proper FetchXML to only return resources matching the custom constraints.

### Extensible Filter Layout and Resource Template

In the July 2017 update for Universal Resource Scheduling, the Filter panel (#2 above) was updated to support customization through an XML layout definition. The new layout supports dropdown controls to show a list of records from master entities and the typical `number`, `datetime`, and `checkbox` controls. The layout can be modified to allow users to select records from custom constraint entities. The custom constraints, like the ones shipped with Universal Resource Scheduling, are then passed as input to the Resource Matching API.

Another client-side extensibility point made available in the July 2017 update is the resource cell. The resource cell is rendered through a customizable Handlebars.js template. The results from the Resource Matching API are made available to the template. Therefore, by customizing the query executed by the Resource Matching API, custom data can be rendered in the resource cell.

> [!div class="nextstepaction"]
> A step by step guide with code samples needed for each step is described in [Extending Universal Resource Scheduling: Find resources by language - a step by step guide](extending-urs-step-by-step.md)

## Additional notes
- The filter layout is currently not configurable when a schedulable entity uses an associated requirement group instead of a resource requirement. 

### See also

[Universal Fetch XML](universal-fetchxml.md)

[Universal Resource Scheduling extensibility release notes](extensibility-release-notes.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]