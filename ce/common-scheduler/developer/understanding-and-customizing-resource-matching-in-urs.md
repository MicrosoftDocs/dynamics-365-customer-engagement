---
title: Customize resource matching in Universal Resource Scheduling
description: Learn how the built-in resource constraints are implemented in Universal Resource Scheduling, and how to extend the system with custom resource constraints.
author: mkelleher-msft
ms.author: mkelleher
ms.date: 07/28/2025
ms.reviewer: puneet-singh1
ms.subservice: common-scheduler
ms.topic: how-to
---

# Customize resource matching in Universal Resource Scheduling

Universal Resource Scheduling lets you match resources to book the right ones for a job. It also schedules any workstream in Dynamics 365. This article explains how built-in resource constraints work and how to customize Universal Resource Scheduling with custom constraints.

## Resources, Requirements, and Constraints

### Resources

Core to Universal Resource Scheduling is the Resource (`bookableresource`) entity. When Booking (`bookableresourcebooking`) records are created, they're associated with a resource record. Universal Resource Scheduling includes many built-in filters and constraints to help you select the correct resource. For example:

- **Resource Type** to indicate if the resource is a User, Contact, Account, or Equipment
- **Characteristic** to filter resources by skills they're proficient in
- **Territory** to assign resources to specific regions
- **Organizational** Unit to model an organization hierarchy

A resource record and its associated constraints are modeled through attributes or relationships to other entities. For example, name and resource type are attributes on the *Resource* entity. Resource Characteristics and Resource Territories are child relationships since a resource can be associated with more than one of them. These entities are child relationships to both the *Resource* AND the *Characteristic/Territory* entity. Organizational unit is a lookup attribute on the *Resource* entity to the *Organizational Unit* entity.

### Requirements

Another important entity in Universal Resource Scheduling is the Resource Requirement (`msdyn_resourcerequirement`) entity. The *Requirement* entity records a requirement for work to be done. It captures parameters about the demanded work. For example:

- The **From** and **To** date fields restrict the time period when the work can be done.
- The **Duration** field indicates how long the job is expected to take.
- The **Work Location** field indicates the location of the required work.

The *Requirement* entity captures resource constraints to limit which resources can fulfill and book this requirement. Like the *Resource* entity, resource constraints are expressed as attributes on the *Requirement* entity or as relationships to other entities. Territory is a lookup attribute from the *Requirement* entity to the *Territory* entity indicating the territory the work is to be done in and, therefore, we must find a resource from the same territory. Requirement characteristic is a child relationship relating the requirement to the *Characteristic* entity expressing the skills required to complete the job. Therefore, the requirement can be matched to only resources with matching skills.

### Constraints shipped in Universal Resource Scheduling

Universal Resource Scheduling includes the following constraints:

- **Characteristics**: Represent the skills a resource has, with optional ratings values to indicate the characteristic level of a resource
- **Categories**: Define groupings to associate with resources
- **Territories**: Specify the geographic regions of a resource
- **Organizational Units**: Reflect the organization hierarchy
- **Resource Type**: Identifies the classification of a resource
- **Teams**: Identify the teams a resource belongs to
- **Business Units**: Show which business unit the resource is part of

### Schedule Board filters

The Schedule Board lists resources and their assigned bookings. Use the Filter panel to filter resources by their constraints. For example, select a **User** resource type to filter the resource list to users. Similarly, you can filter resources by matching characteristics or territories.

Use the Filter panel to manually show resources that match specific constraints.

### Find available resources with the Schedule Assistant

The bottom of the Schedule Board shows a list of requirement records. You can select one of them and choose to find availability. This action opens the Schedule Assistant. The Schedule Assistant uses constraints from the selected requirement to find available matching resources. Only resources matching the constraints on the requirement and which are available in the requested time period specified on the requirement are shown on the board.

A similar experience is available by selecting **Book** on the *Requirement* entity and other schedulable entities in Dynamics 365 list views or forms. The Schedule Assistant opens showing resources matching the constraints of the selected requirement record.

Unlike the Schedule Board where you use the Filter panel to manually filters resources, the Schedule Assistant automatically populates the Filter panel with the resource constraints from the requirement record. Therefore, only matching resources are shown.

## How constraints matching works

### Constraints entities

Some constraints are specified as attributes directly on the *Resource* entity while others are defined through relationships. Relationships are needed when a constraint is referencing a second, master entity.

Let's consider a resource record and its associated territory and characteristic constraints.

First, the master records. We have territories stored in the *Territory* entity:

- New York
- New Jersey
- Seattle

We also have characteristics in the *Characteristic* entity:

- Project Manager
- Designer
- Financial Analyst

- Contoso US
- Contoso EU

We have the *Resource* entity:

|Resource | Resource Type | Organizational Unit |
|--- |--- |--- |
|Jorge Galt | User | Contoso US |
|Abraham McCormick | Contact | Contoso EU |

While a single resource record works to capture single-valued constraints, like the resource type and organizational unit. If we want to associate a resource to multiple territory or characteristic records, we must use a third entity, a many-to-many (N:N) relationship, to store these associations.

We use the Resource *Territory* entity to associate multiple territories for a resource.

Resource Territory Records:

|Resource | Territory |
|--- |--- |
|Jorge Galt | New York |
|Jorge Galt | New Jersey |
|Abraham McCormick | Seattle |

The Resource *Characteristic* entity to store multiple characteristics for a resource.

Resource Characteristic records:

|Resource | Characteristic |
|--- | --- |
|Jorge Galt | Designer |
|Abraham McCormick | Project Manager |
|Abraham McCormick | Financial Analyst |

Similar to resource, a requirement record captures single-valued constraints and child records store multi-valued constraints.

The *Requirement* entity:

|Requirement | Duration | Territory |
|--- | --- | --- |
|Job 1 | 1 hr | New York |
|Job 2 | 1 hr | Seattle |

The *Requirement Characteristic* entity:

Requirement Characteristic records:

|Requirement | Characteristic |
|--- | --- |
|Job 1 | Designer |
|Job 2 | Project Manager |
|Job 2 | Financial Analyst |

Sometimes, a requirement has a constraint as a lookup attribute, while the resource stores matching attributes in the N:N table. For example, for requirement, the territory constraint is a lookup attribute to the *Territory* entity. A requirement captures a demand for work and the territory where the work is. A resource record, however, can be associated to many territory records.

### Constraints property bags

When the user selects values in the Filter panel and selects **Search**, the values are sent to the Resource Matching API. For multi-valued constraints, the Filter panel shows the data from the master entities *Territory* and *Characteristic* and includes the selected values in the constraints property bag.

Here's a sample property bag with constraints sent to the Resource Matching API:

|Name | Value|
|--- |--- |
|`ResourceType` | User |
|`Territories` | New York<br>New Jersey|

The constraints tell the Resource Matching API to find resources of type *User* that are associated with the New York or New Jersey territories.

When in the Schedule Assistant, the constraints are first retrieved from a requirement record through the Retrieve Requirement Constraints API. The retrieved constraints are then prefilled in the Filter panel and sent to the Resource Matching API.

The Retrieve Requirement Constraints API queries the requirement record and all related child constraints (for example, requirement characteristic). It responds with a constraints property bag expressing all the resource constraints captured on the selected Requirement.

Here's a sample response from the Retrieve Requirement Constraints API:

|Name | Value |
|--- | --- |
|`Requirement` | Job 2 |
|`Duration` | 1 hr |
|`Territories` | Seattle |
|`Characteristics` | Project Manager<br>Financial Analyst |

The Resource Matching API receives as input the constraints property bag and queries for matching resources. The matching resources are then shown in the Schedule Board or Schedule Assistant.

### Entities used for resource matching summary

- Sample master entities
    - Territory - Referenced as a constraint
    - Characteristic - Referenced as a constraint
    - Resource - Assigned to Bookings
    - Resource Territory - Associates Resources to Territories
    - Resource Characteristic - Associates Resources to Characteristics
- Sample transactional entities
    - Requirement - Captures a demand for work and references Territory
    - Requirement Characteristic - Associates Requirements to Characteristics

### Resource matching flows summary

- Manual filtering. Filter Panel > Resource Matching API

    1. A user manually adds constraints in the Filter panel
    1. The constraints are sent to the Resource Matching API
    1. The filtered list of resources is shown

- Requirement filtering. Retrieve Requirement Constraints API > Filter Panel > Resource Matching API

    1. A user finds availability for a Requirement record (from within the Schedule Board or from the Book button in the ribbon).
    1. The constraints are retrieved through the Retrieve Requirement Constraints API and shown in the Filter panel.
    1. The constraints are sent to the Resource Matching API
    1. The filtered list of resources is shown

## Extend Universal Resource Scheduling with custom constraints

Universal Resource Scheduling can be extended with custom resource constraints. Extending constraints work the same way as the ones build into Universal Resource Scheduling, they are modeled as attributes and relationships in Dynamics 365.

> A step by step guide with code samples needed for each step is described in [Extending Universal Resource Scheduling: Find resources by language - a step by step guide](extending-urs-step-by-step.md)

### Custom constraints

We'll use "language" as an example scenario. An organization wants to filter resources by the language they speak. They also want to capture on the Requirement record the language required for a job. This constraint follows a similar pattern to the built-in Territory constraint. A new master entity Language stores the different languages a resource can speak. A Resource record can be associated to many Languages through a many-to-many relationship entity. On the Requirement entity, we'll create two new lookup attributes: `Required Language` and `Secondary Language`. When finding available resources for a requirement, only resources associated with either the `Required Language` or the `Secondary Language` will be shown.

Here, we'll describe the custom language constraint. First, we have our new Language entity:

|Language |
|--- |
|English |
|Spanish |

The Resource Language many-to-many child entity:

|Resource | Language|
|--- | ---|
|Jorge Galt | English|
|Abraham McCormick | English|
|Abraham McCormick | Spanish|

Here is the Requirement entity with our two new attributes, Required Language and Secondary Language representing the languages the resource needs to speak to be matched with this requirement:

|Requirement | Duration | Territory | Required Language | Secondary Language|
|--- | --- | --- | --- | ---|
|Job 1 | 1 hr | New York | English | ---|
|Job 2 | 1 hr | Seattle | Spanish | English|

### Extensibility points

Based on the [resource matching flows](#resource-matching-flows-summary), we need to modify these extensibility points for our custom constraints to work:

1. Retrieve Requirement Constraints API

   The API reads the new required language and secondary language attributes to retrieve constraints when a user finds availability for a requirement.

2. Filter panel

    A user can select from a list of language records in the Filter panel to filter for matching resources. When finding availability for a requirement, the Filter panel shows the required language and secondary language from the requirement record preselected in the list of languages.

3. Resource Matching API

    The API receives the new language constraints as input and returns only resources speaking the selected languages.

### Extensible queries

Internally, the Retrieve Requirement Constraints API and the Resource Matching API use FetchXML to query data from Dynamics 365. The Retrieve Requirement Constraints API issues multiple queries to retrieve the requirement record and its child constraints such as Requirement Characteristic. The Resource Matching API, based on the resource constraints passed to it as input, dynamically constructs the correct FetchXML query so only resource records matching the specified FetchXML criteria are returned from Dynamics 365.

[Universal FetchXML (UFX)](universal-fetchxml.md) supports extensible resource matching. Two important features UFX adds to FetchXML are:

- Multiple result sets, a single UFX Query can return results from multiple entities
- Dynamic FetchXML, a UFX Query can dynamically construct FetchXML based on input data

With UFX, a single query can be constructed to query for a requirement record and all its child records. The Retrieve Requirement Constraints API executes a customizable UFX Query to retrieve a requirement and its child constraints. The query can be customized to retrieve custom constraint records as well.

The constraints property bag returned from the Retrieve Requirement Constraints API is passed as input to the Resource Matching API. The API executes a customizable UFX query. With UFX, the query uses the input constraints to dynamically construct the correct FetchXML to find matching resources. This UFX query, too, can be modified to construct the proper FetchXML to only return resources matching the custom constraints.

### Extensible Filter Layout and Resource Template

The Filter panel supports customization through an XML layout definition. The new layout supports dropdown controls to show a list of records from master entities and the typical `number`, `datetime`, and `checkbox` controls. The layout can be modified to allow users to select records from custom constraint entities. The custom constraints, like the ones shipped with Universal Resource Scheduling, are then passed as input to the Resource Matching API. The filter layout is currently not configurable when a schedulable entity uses an associated requirement group instead of a resource requirement.

Another client-side extensibility point is the resource cell. The resource cell is rendered through a customizable Handlebars.js template. The results from the Resource Matching API are made available to the template. Therefore, by customizing the query executed by the Resource Matching API, custom data can be rendered in the resource cell.

> [!div class="nextstepaction"]
> A step by step guide with code samples needed for each step is described in [Extending Universal Resource Scheduling: Find resources by language - a step by step guide](extending-urs-step-by-step.md)

### Additional resources

[Universal Fetch XML](universal-fetchxml.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
