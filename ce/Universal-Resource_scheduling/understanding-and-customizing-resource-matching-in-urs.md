# Understanding and Customizing Resource Matching in Universal Resource Scheduling (URS)

Univeral Resource Scheduling (URS), the scheduling engine underlying Field Service and Project service, ships with extensive resource matching capabilities to book the right resources for a job. In this article we'll take a look at how the built-in resource constraints are implemented and how to customize URS with custom resource constraints.

## Resources, Requirements and Constraints

### Resources

Core to Universal Resource Scheduling (URS) is the `Resource` (`bookableresource`) entity. When `Booking` (`bookableresourcebooking`) records are created, they are associated with a Resource record. To ensure the correct resource is selected, URS ships with many built-in filters and constraints to categorize resources by. Examples are: `Resource Type`, indicating if the resource is a `User`, `Contact`, `Account`, `Equipmant`, etc., `Characteristic`, to filter resources by skills they are proficient in, `Territory`, to assign resources to specific regions, `Organizational Unit` to model an organization heirarchy, and many more. 

A Resource record and its associated constraints are modeled through attributes or relationships to other entities. For example, `Name` and `Resource Type` are attributes on the Resource entity, whereas `Resource Charecteristics` and `Resource Territories`, since a resource can be associated with more than one of them, are child relationships to the Charecteristic and Territory entity. `Organizational Unit` is a lookup attribute to the Organizational Unit entity.

### Requirements

Another important entity in URS is the `Resource Requirement` (`msdyn_resourcerequirement`) entity. The Requirement entity records a requirement for work to be done. It captures parameters about the demanded work, like the `From` and `To` date fields restricting the time period in which the work can be done, the `Duration` field for how long the job is expected to take, and `Work Location` indicating the location of the required work. The Requirement entity also captures resource constraints to restrict which resources can fulfill and be booked for this requirement. Like the Resource entity, resource constraints are expressed as attributes on the Requirement entity or as relationships to other entities. `Territory` is a lookup attribute from the Requirement entity to the Territory entity indicating the territory the work is to be done in and, therefore, to find a resource from the same territory. `Requirement Characteristic` is a child relationship to the Characteristic entity expressing the skills required to complete the job and, therefore, to only find resources with matching skills.

### Constraints Shipped in URS

Following is the list of constraints that ship with URS:

- `Characteristics` - Can be used to model skills a resource has. It also supports optional ratings values to rate how proficient a resource is at each skill
- `Categories` - Resources can be associated to categories
- `Terrigories` - To assign resources to territorial regions
- `Organizational Units` - To model an organization heirarchy
- `Resource Type` - Defines the type of the resource
- `Teams` - The teams a resource is a member of
- `Business Units` - Which business unit the resource is part of

### Filtering in the Schedule Board

The Schedule Board shows a list of resources and the bookings assigned to them. The Filter panel in the Schedule Board lets you filter the list of resources by their constraints - e.g. selecting a resource type of `User` in the `Resource Type` downdown will filter the resource list to those which are of type `User`. Similarly, you can filter resources by matching characteristics or territories.

Using the Filter panel to filter resources is one method of finding matching resources. This method is used when you want to manually show a list of resources matching a specific set of constraints.

### Finding Available Resources with the Schedule Assistant

In the bottom of the Schedule Board you'll find a list of Requirement records. You can select one of them and chose to find availability. This aciton opens the Schedule Assistant. The Schedule Assistant uses the constraints captured on the selected Requirement record to find matching resources that are available to be booked. Only resources matching the constraints on the Requirement and which are available in the requested time period specified on the Requirement are shown on the board.

A similar experience is available through a "Book" ribbon button available on the Requirement entity and other scheduleble entities in Dynamics 365 list views. When "Book" is clicked, the Schedule Assistant is opened showing resources matching the constraints of the selected Requirement record.

Unlike the previously mentioned Schedule Board mode, where you use the Filter panel to manually filters resources, in Schedule Assistant mode, the Filter panel automatically fills in the resource constraints from the Requirement record and only matching resources are shown.

## How Constraints Matching Works

### Constraints Entities

Some constraints are specified as attributes directly on the Resource entity while others are defined through relationships. Relationships are needed when a constraint is referencing a 2nd, master entity.

Let's consider a Resource record and its associated Territory and Charecteristic constraints.

First, the master records. We have territories stored in the Territory entity:

Territory |
--- |
New York |
New Jersey |
Seattle |

we also have characteristics in the Characteristic entity:

Characteristic |
--- |
Project Manager |
Designer |
Financial Analyst |

and our Organizational Unit entity:

Organizational Unit |
--- |
Contoso US |
Contoso EU |

Finally, we have the Resource entity:

Resource | Resource Type | Organizational Unit
--- | --- | ---
Jorge Galt | User | Contoso US
Abraham McCormick | Contact | Contoso EU

While a single Resource record works to capture single-valued constraints, like the `Resource Type` and `Organizational Unit` above. If we want to associate a Resource to multiple Territory or Characteristic records, we must used a 3rd entity, a many-to-many (N:N) relationship, to store these associations.

We use the Resource Territory entity to associate multiple territories for a resource:

Resource | Territory
--- | ---
Jorge Galt | New York
Jorge Galt | New Jersey
Abraham McCormick | Seattle

and the Resource Characteristic entity to store multiple characteristics for a resource:

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

Requirement | Characteristic
---| ---
Job 1 | Designer
Job 2 | Project Manager
Job 2 | Financial Analyst

In the case of Requirement, the Territory constraint is a lookup attribute to the Territory entity. A Requirement captures a demand for work and the territory the work will be done in. A Resource record, however, can be associated to many Territory records.

### Constraints Property Bags

When the user selects values in the Filter panel and clicks the Search button, the values are sent to the Resource Matching API. For multi-valued constraints, the Filter panel shows the data from the master entities Territory and Charecteristic and includes the selected values in the constraints property bag.

Here is a sample property bag with constraints sent to the Resource Matching API:

Name | Value
--- | ---
`ResourceType` | User
`Territories` | New York<br />New Jersey

This tells the Resource Matching API to find resources of type `User` that are associated with the `New York` or `New Jersey` territories.

When in the Schedule Assistant, the constraints are first retrieved from a Requirement record through the Retrieve Requirement Constraints API. The retrieved constraints are then pre-filled in the Filter panel and sent to the Resource Matching API.

The Retrieve Requirement Constraints API queries the Requirement record and all related child constraints (e.g. Requirement Characteristic). It responds with a constraints property bag expressing all the resource constraints captured on the selected Requirement.

Here's a sample response from the Retrieve Requirement Constraints API:

Name | Value
--- | ---
`Requirement` | Job 2
`Duration` | 1 hr
`Territories` | Seattle
`Charecteristics` | Project Manager<br />Financial Analyst

The Resource Matching API receives as input the constraints property bag and queries for matching resources. The matching resources are then shown in the Schedule Board or Schedule Assistant.

### Summary of the Entities Used for Resource Matching

- Master Entities
    - `Territory` - Referenced as a constraint
    - `Charecteristic` - Referenced as a constraint
    - `Resource` - Assigned to Bookings
    - `Resource Territory` - Associates Resources to Territories
    - `Resource Charecteristic` - Assocites Resources to Charecteristics
- Transactional Entities
    - `Requirement` - Captures a demand for work and references Territory
    - `Requirement Charecteristic` - Associates Requirements to Characteristics

### Summary of the Resource Matching Flows

- Manual Filtering. Filter Panel > Resource Matching API
    1. A user manually adds constraints in the Filter panel
    2. The constraints are sent to the Resource Matching API
    3. The filtered list of resources is shown
- Requirement Filtering. Retrieve Requirement Constraints API > Filter Panel > Resource Matching API
    1. A user finds availability for a Requirement record (from within the Schedule Board or from the Book button in the ribbon).
    2. The constraints are retrieved through the Retrieve Requirement Constraints API and shown in the Filter panel.
    3. The constraints are sent to the Resource Matching API
    4. The filtered list of resources is shown

## Extending URS with Custom Constraints

URS can be extended with custom resource constraints. Extending constraints work the same way as the ones build into URS, they are modeled as attributes and relationships in Dynamics 365.

> A step by step guide with code samples needed for each step is described in [Extending URS to Find Resources by Required Language: A Step by Step Guide](extending-urs-step-by-step.md)

### Custom Constraints

We'll use spoken language as an example. An organization wants to filter resources by the language they speak. They also want to capture on the Requirement record the language required for a job. This constraint follows a similar pattern to the built-in Territory constraint. A new master entity Language stores the different languages a resource can speak. A Resource record can be associated to many Languages through a many-to-many relationship entity. On the Requirement entity, we'll create two new lookup attributes: `Required Language` and `Secondary Language`. When finding available resources for a requirement, only resources associated with either the `Required Language` or the `Secondary Language` will be shown.

Since extensible constraints work fully with the relational model of Dynamics 365, any structure used to express constraints can be used in URS. Here's a more powerful example of custom constraints. The Resource entity is extended with a `Maximum Weight` attribute decribing the maximum weight it can carry, in case of a vehicle resource. The Requirement entity is related to the Dynamics 365 Product entity with a many-to-many relationship; each Product gets a new `Weight` attribute, too. When a Requirement record is created to capture required work, it is related to all the products required to complete the job. When a user finds availabillity for a Requirement, the total weight of all related Product records is retrieved and only resources that can carry this weight, defined in the `Maximum Weight` attribute, are returned.

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

and, finally, the Requirement entity with our two new attributes, `Required Language` and `Secondary Language`:

Requirement | Duration | Territory | Required Language | Secondary Language
--- | --- | --- | --- | ---
Job 1 | 1 hr | New York | English | ---
Job 2 | 1 hr | Seattle | Spanish | English

### Extensibility Points

Based on the [resource matching flows](#summarizing-the-resource-matching-flows) described above, these are the extensibility points we need to modify for our custom constraints to work:

1. Retrieve Requirement Constraints API
    
    The API needs to read our new `Required Language` and `Secondary Language` attributes so when a user finds availability for a Requirement our new constraints are retrieved.

2. Filter panel

    A user should be able to select from a list of Language records in the Filter panel to filter for matching resources. When finding availability for a Requirement, the Filter panel should show the `Required Language` and `Secondary Language` from the Requirement record pre-selected in the list of Languages.

3. Resource Matching API

    The API will get as input the new Language constraints; it needs to return only resources speaking the selected languages.

### Extensible Queries

Internally, the Retrieve Requirement Constraints API (#1 above) and the Resource Matching API (#3 above) use FetchXML to query data from Dynamics 365. The Retrieve Requirement Constraints API issues multiple queries to retrieve the Requirement record and its child constraints (e.g. Requirement Characteristic etc.) The Resource Matching API, based on the resource constraints passed to it as input, will dynamically construct the correct FetchXML query so only Resourcre records matching the specified FetchXML criteria are returned from Dynamics 365.

In the July 2017 update for URS, to support extensible resource matching, [Universal FetchXML (UFX)](Universal-FetchXML.md) was introduced. Two important features UFX adds to FetchXML are: 1) Multiple result sets, a single UFX Query can return results from multiple entities, and 2) Dynamic FetchXML, a UFX Query can dynamically construct FetchXML based on input data.

With UFX, a single query can be constructed to query for a Requirement record and all its child records. The Retrieve Requirement Constraints API executes a customizable UFX Query to retrieve a Requirement and its child constraints. The query can be customized to retrieve custom constraint records as well.

The constraints property bag returned from the Retrieve Requirement Constraints API is passed as input to the Resource Matching API. The API executes a customizable UFX query. With UFX, the query uses the input constraints to dynamically construct the correct FetchXML to find matching resources. This UFX query, too, can be modified to construct the proper FetchXML to only return resources matching the custom constraints.

### Extensible Filter Layout and Resource Template

In the July 2017 update for URS, the Filter panel (#2 above) was updated to support customization through an XML layout definition. The new layout supports dropdown controls to show a list of records from master entities and the typical `number`, `datetime` and `checkbox` controls. The layout can be modified to allow users to select records from custom constraint entities. The custom constraints, like the ones shipped with URS, are then passed as input to the Resource Matching API.

Another client side extensibility point made available in the July 2017 upodate is the resource cell. The resource cell is rendered through a customizable Handlebars.js template. The results from the Resource Matching API is made available to the template. Therefore, by customizing the query executed by the Resource Matching API, custom data can be rendered in the resource cell.

> A step by step guide with code samples needed for each step is described in [Extending URS to Find Resources by Required Language: A Step by Step Guide](extending-urs-step-by-step.md)