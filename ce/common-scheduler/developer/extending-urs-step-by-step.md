---
title: Extending Universal Resource Scheduling - Find resources by language - a step-by-step guide | Microsoft Docs
description: Extending Universal Resource Scheduling - Find resources by language - a step-by-step guide
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

# Extending Universal Resource Scheduling: Find resources by language - a step-by-step guide

> This step by step guide is a companion to [Understanding and customizing resource matching in Universal Resource Scheduling](understanding-and-customizing-resource-matching-in-urs.md)

In this step-by-step guide, we'll extend Universal Resource Scheduling resources with a `Language` constraint. Consider an organization that wants to filter resources by the languages they speak. They also want to capture on the `Requirement` record the language required for the job. This constraint follows a similar pattern to the built-in `Territory` constraint. A new master entity `Language` will store the different languages a resource can speak. A `Resource` record can then be associated to many `Languages` through a many-to-many relationship entity. On the `Requirement` entity, we'll model this by creating two new lookup attributes: `Primary Language` and `Secondary Language`. When finding available resources for a requirement, only resources associated with either the `Primary Language` or the `Secondary Language` will be shown.

## Creating the new entities and relationships

In this section, we'll create the new schema for the master `Language` entity and update the `Resource` and `Requirement` entities with the corresponding relationships to the new `Language` entity.

### Create a new Publisher

1. In Dynamics 365, under Customizations, create a new Publisher
2. Fill out the New Publisher form with the below details:

    Field | Value
    --- | ---
    Display Name | Language
    Name | language
    Prefix | lang

3. Click Save and Close

### Create a new Solution

1. In Dynamics 365, under Customizations, create a new Solution
2. Fill out the New Solution form with the below details:

    Field | Value
    --- | ---
    Display Name | Language
    Name | Language
    Publisher | Language
    Version | 1.0.0.0

3. Click Save

### Create the Language entity

1. In the Language solution, create a new Entity
1. Fill out the New Entity form with the below details:

    Field | Value
    --- | ---
    Display Name | Language
    Plural Name | Languages
    Name | lang_language (The `lang_` prefix will be autofilled and read-only)

1. Click Save

### Create the many-to-many relationship from the Resource entity to the Language entity

1. In the Language entity, create a new Many-to-Many Relationship
1. Fill out the New Relationship form with the below details:

    Field | Value
    --- | ---
    **Current Entity** |
    Display Option | Use Plural Name
    **Other Entity** |
    Entity Name | Bookable Resource

1. Click Save and Close
1. Close the Language entity form

### Create the relationships from the Requirement entity to the Language entity

1. In the Language solution, add the existing Resource Requirement entity to the solution (If presented with a Missing Required Components dialog, select No, do not include required components.)
1. In the Resource Requirement entity, create a new Field
1. Fill out the New Field form with the below details:

    Field | Value
    --- | ---
    Display Name | Primary Language
    Data Type | Lookup
    Target Record Type | Language

1. Click Save and Close
1. In the Resource Requirement entity, create a new Field
1. Fill out the New Field form with the below details:

    Field | Value
    --- | ---
    Display Name | Secondary Language
    Data Type | Lookup
    Target Record Type | Language

1. Click Save and Close

#### Update the Requirement main form

1. In the Resource Requirement entity, add the existing Information form to the entity's subcomponents (If presented with a Missing Required Components dialog, select No, do not include required components.)
1. In the Information form, use the Field Explorer to add the two new attributes, Primary Language and Secondary Language to the form so users can enter this information as they create requirements
1. Click Save
1. Click Publish
1. You can close the form editor

### Summary

In the above steps, we created the new Language entity. We then added new relationships with the Resource and Requirement entities. Resources can be related to multiple languages, since we added a many to many relationship between Language and Resource. Requirements can be related to two Languages since we added two lookup attributes on Requirement entity pointing to the new Language entity.

#### Adding data

Use Advanced Find to add new records to the Language entity. You can then associate Resource records to the new Language records by opening a Resource record and navigating to the Language relationship in the navigation bar. For Requirement records, you can fill in the new Primary Language and Secondary Language fields on the Requirement form.

## Customizing the Schedule Board

To filter resources in the Schedule Board with the new Language constraint, we'll update the Retrieve Resources Query and the Filter Layout configuration records.

### Filter Layout Configuration

> [!TIP]
> For the below steps, it is helpful to use a text editor that supports XML syntax highlighting to make your changes, and then paste your changes back into the Universal Resource Scheduling editor.

The Filter Layout configuration is an XML layout definition to customize the layout of the Filter panel.

> [!NOTE]
> For this exercise, we'll remove all default filters shipped with Universal Resource Scheduling from the Filter panel and add Languages as the only available filter.

```xml
<control type="combo" source="entity" key="Languages" inactive-state="1" label-id="Languages" entity="lang_language" multi="true" />
```

The `control` element adds a new control to the Filter panel. Here is the description of each attribute:

Name | Description
--- | ---
`type` | The type of filter control. A `combo` control renders a dropdown with values to choose from
`source` | The source of the values for the dropdown control. An `entity` source shows entity records in the dropdown
`key` | The key to use to store the selected values in the constraints property bag
`inactive-state` | The inactive `statecode` for this entity. This is used to exclude inactive records from the dropdown
`label-id` | The localized label to use for this control
`entity` | This entity's records will be displayed in the dropdown
`multi` | Configures the dropdown to allow selecting a single record or multiple records

> Filter Layout:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<filter>
  <controls>
    <control type="combo" source="entity" key="Languages" inactive-state="1" label-id="Languages" entity="lang_language" multi="true" />
  </controls>
</filter>
```

#### Create a new Languages board

In order to keep these changes isolated, we will create a brand new separate Schedule Board and implement the changes, but you can always make these changes on the default Schedule Board so that other Schedule Boards can automatically inherit these changes.

1. In Dynamics 365, in the top navigation bar, go to Resource Scheduling > Schedule Board
2. In the top right, click the + sign to create a new board
3. Name the new board Language
4. At the bottom of the dialog, click Add. The new board will be created.

#### Update the Schedule Board Filter Layout

Next, we will create a new configuration record, which stores filter layouts and queries used by the Schedule Board, and then we will link the newly created Schedule Board to the new configuration record. There are multiple ways to do this, but here is the quickest:

1. In the top right, double-click the Language tab
1. Scroll down to General Settings > Other Settings
1. Locate the Filter Layout field, click the button to the right to open the editor
1. Update the Value field with the Filter Layout code above and click Save As. 
1. Enter "Language Filter Layout" in the Name field and click Save. This creates a new configuration record and links this Schedule Board to the record.
1. At the bottom of the dialog, click Apply

The board will reload and you will see the Filter panel in the left with the new layout; only the Languages filter will be available. Filtering will not work yet, as we need to update the Retrieve Resources Query to take advantage of the new filter.

<a name="retrieve-resources-query-configuration"></a>
### Retrieve Resources Query Configuration

> [!TIP]
> For the below steps, it is helpful to use a text editor that supports XML syntax highlighting to make your changes, and then paste your changes back into the Universal Resource Scheduling editor.

The Retrieve Resources Query configuration is a [UFX Query](universal-fetchxml.md#ufx-queries) used by the Resource Matching API. It takes as input the values entered in the Filter panel and dynamically constructs the correct FetchXML to find matching resources.

> Below are the new snippets added to the Retrieve Resources Query to match and order by the Resources' Languages.

#### Adding the joins from `bookableresource` to `lang_language`

```xml
<link-entity name="lang_lang_language_bookableresource" from="bookableresourceid" to="bookableresourceid" alias="lang_primary" link-type="outer" ufx:if="$input/Languages/bag[1]">
  <attribute name="lang_languageid" alias="lang_primary" groupby="true" />

  <filter>
    <condition attribute="lang_languageid" operator="eq">
      <ufx:value select="$input/Languages/bag[1]/@ufx-id" attribute="value" />
    </condition>          
  </filter>
</link-entity>

<link-entity name="lang_lang_language_bookableresource" from="bookableresourceid" to="bookableresourceid" alias="lang_secondary" link-type="outer" ufx:if="$input/Languages/bag[2]">
  <attribute name="lang_languageid" alias="lang_secondary" groupby="true" />

  <filter>
    <condition attribute="lang_languageid" operator="eq">
      <ufx:value select="$input/Languages/bag[2]/@ufx-id" attribute="value" />
    </condition>          
  </filter>
</link-entity>

<link-entity name="lang_lang_language_bookableresource" from="bookableresourceid" to="bookableresourceid" alias="lang_others" link-type="outer" ufx:if="$input/Languages/bag[position() > 2]">

  <filter>
    <condition attribute="lang_languageid" operator="in">
      <ufx:apply select="$input/Languages/bag[position() > 2]">
        <value>
          <ufx:value select="@ufx-id" />
        </value>
      </ufx:apply>
    </condition>            
  </filter>
</link-entity>        

<filter type="or">
  <condition entityname="lang_primary" attribute="lang_languageid" operator="not-null" ufx:if="$input/Languages/bag[1]" />
  <condition entityname="lang_secondary" attribute="lang_languageid" operator="not-null" ufx:if="$input/Languages/bag[2]" />
  <condition entityname="lang_others" attribute="lang_languageid" operator="not-null" ufx:if="$input/Languages/bag[position() > 2]" />          
</filter>
```

> The values selected in the Filter panel is passed as input to the query and is available in the XPath `$input` variable

The Retrieve Resources Query uses FetchXML to query the `Resource (bookableresource)` entity. We are using the FetchXML `link-entity` element to only return resources associated with the Language records selected in the Filter panel. To support showing the matched languages and ordering by primary or secondary language, described later in the section [Resource Cell Template](#resource-cell-template-configuration), we are using multiple `link-entity` joins. 

Here is the description of each **`element`** and `attribute`:

Name | Description
--- | ---
**`link-entity`** | Create a join to the many-to-many relationship between the Resource and Language entities
`ufx:if` | Only emit this FetchXML element (`link-entity`) if the XPath expression in this attribute returns a value
**`attribute`** | Return the primary or secondary language matched
**`filter`** and **`condition`** | Filter the many-to-many relationship records to only the ones that match the specified Language IDs
**`ufx:value`** and `select` | Outputs the result of the XPath expression in the `select` attribute
**`ufx:apply`** and `select` | Emit the child FetchXML elements for each result returned from the XPath expression in the `select` attribute
**`value`** | Contains the ID of a Language record

#### Determining a Resource's sort order

After we retrieve the matching resources, based on each resource's assigned languages, we assign a new `lang_order` property to determine its sort order.

```xml
<bag>
  <lang_order ufx:select="iif(lang_primary and lang_secondary, 1, iif(lang_primary, 2, iif(lang_secondary, 3, 4)))" />
</bag>
```
Here is the description of each **`element`** and `attribute`:

Name | Description
--- | ---
**`lang_order`** | Create a new property in each Resource returned from the FetchXML query named `lang_order`
`ufx:select`| Assign the result of the XPath expression in this attribute to the `lang_order` property. The `lang_primary` and `lang_secondary` properties, retrieved earlier in the query, is used together with the XPath [`iif`](universal-fetchxml.md#iif) function to determine the resource matching order.

#### Ordering the results

```xml
<Resources ufx:select="order(Resources, 'lang_order')" />
```

UFX Queries are processed in sequential order. After the resources are retrieved through FetchXML, the results are assigned to the `Resources` property. We are sorting the results based on the `lang_order` property added earlier and reassigning the sorted results to the `Resources` property.

Here is the description of each **`element`** and `attribute`:

Name | Description
--- | ---
**`Resources`** | Reassign the `Resources` property
`ufx:select` | Assign the result of the XPath expression in this attribute to the `Resources` property. The XPath [`order`](universal-fetchxml.md#order) function is used to order the `Resources` list on its `lang_order` property.

> [!NOTE]
> The default Retrieve Resources Query shipped with Universal Resource Scheduling is a large query that supports all the resource constraints included with Universal Resource Scheduling. For this exercise, we'll use only a subset of the default query and add Languages as the only filter.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<bag xmlns:ufx="https://schemas.microsoft.com/dynamics/2017/universalfetchxml">
  <Resources ufx:source="fetch">
    <fetch mapping="logical" aggregate="true">
      <entity name="bookableresource">
        <attribute name="bookableresourceid" alias="bookableresourceid" groupby="true"/>
        <attribute name="name" alias="name" groupby="true"/>
        <attribute name="calendarid" alias="calendarid" groupby="true"/>
        <attribute name="resourcetype" alias="resourcetype" groupby="true"/>
        <attribute name="msdyn_startlocation" alias="startlocation" groupby="true"/>

        <!-- Language join -->
        <link-entity name="lang_lang_language_bookableresource" from="bookableresourceid" to="bookableresourceid" alias="lang_primary" link-type="outer" ufx:if="$input/Languages/bag[1]">
          <attribute name="lang_languageid" alias="lang_primary" groupby="true" />
          
          <filter>
            <condition attribute="lang_languageid" operator="eq">
              <ufx:value select="$input/Languages/bag[1]/@ufx-id" attribute="value" />
            </condition>          
          </filter>
        </link-entity>

        <link-entity name="lang_lang_language_bookableresource" from="bookableresourceid" to="bookableresourceid" alias="lang_secondary" link-type="outer" ufx:if="$input/Languages/bag[2]">
          <attribute name="lang_languageid" alias="lang_secondary" groupby="true" />
          
          <filter>
            <condition attribute="lang_languageid" operator="eq">
              <ufx:value select="$input/Languages/bag[2]/@ufx-id" attribute="value" />
            </condition>          
          </filter>
        </link-entity>
        
        <link-entity name="lang_lang_language_bookableresource" from="bookableresourceid" to="bookableresourceid" alias="lang_others" link-type="outer" ufx:if="$input/Languages/bag[position() > 2]">
          
          <filter>
            <condition attribute="lang_languageid" operator="in">
              <ufx:apply select="$input/Languages/bag[position() > 2]">
                <value>
                  <ufx:value select="@ufx-id" />
                </value>
              </ufx:apply>
            </condition>            
          </filter>
        </link-entity>        
        
        <filter type="or">
          <condition entityname="lang_primary" attribute="lang_languageid" operator="not-null" ufx:if="$input/Languages/bag[1]" />
          <condition entityname="lang_secondary" attribute="lang_languageid" operator="not-null" ufx:if="$input/Languages/bag[2]" />
          <condition entityname="lang_others" attribute="lang_languageid" operator="not-null" ufx:if="$input/Languages/bag[position() > 2]" />          
        </filter>
        
        <link-entity name="systemuser" from="systemuserid" to="userid" link-type="outer">
          <attribute name="systemuserid" alias="systemuserid" groupby="true" />
          <attribute name="entityimage_url" alias="userimagepath" groupby="true"/>
        </link-entity>

        <link-entity name="contact" from="contactid" to="contactid" link-type="outer">
          <attribute name="contactid" alias="contactid" groupby="true"/>
          <attribute name="entityimage_url" alias="contactimagepath" groupby="true"/>
        </link-entity>
        
        <link-entity name="account" from="accountid" to="accountid" link-type="outer">
          <attribute name="accountid" alias="accountid" groupby="true"/>
          <attribute name="entityimage_url" alias="accountimagepath" groupby="true"/>
        </link-entity>
      </entity>
    </fetch>

    <bag>
      <imagepath ufx:select="accountimagepath | contactimagepath | userimagepath" />

      <accountimagepath ufx:select="$null" />
      <contactimagepath ufx:select="$null" />
      <userimagepath ufx:select="$null" />
      
      <lang_order ufx:select="iif(lang_primary and lang_secondary, 1, iif(lang_primary, 2, iif(lang_secondary, 3, 4)))" />
    </bag>
  </Resources>

  <Resources ufx:select="order(Resources, 'lang_order')" />
</bag>
```

#### Update the Schedule Board Retrieve Resources Query

1. In the top right, double-click the Language tab
1. Scroll down to General Settings > Other Settings
1. Locate the Retrieve Resources Query field, click the button to the right to open the editor
1. Update the Value field with the Retrieve Resources Query code above and click Save As
1. Enter "Language Resources Query" in the Name field and click Save. This creates a new configuration record and links this Schedule Board to the record.
1. At the bottom of the dialog, click Apply

The board will reload with the updated configuration. Filtering will now work. If you created Language records and associated them with Resource records, you will now be able to filter resources by their associated languages.

### Summary

In the above steps, we modified the Filter panel to show a filter control for the Language entity. We also modified the Retrieve Resources Query to match resources associated with the selected Language records. When a user selects values in the filter control and clicks Search, the values are passed into the query and the FetchXML query returns only matching resources.

## Customizing the Schedule Assistant

We need to customize the Schedule Assistant Filter Layout and Retrieve Constraints Query configurations to use the new Language constraints in the Schedule Assistant.

Unlike the Schedule Board customizations, where each board can be individually customized, the Schedule Assistant customizations affects all boards where the Schedule Assistant is used. The Schedule Assistant customizations can be specific to a schedulable type or for all types. In this example, we will customize the Schedule Assistant for all types.

### Schedule Assistant Filter Layout Configuration

> [!TIP]
> For the below steps, it is helpful to use a text editor that supports XML syntax highlighting to make your changes, and then paste your changes back into the Universal Resource Scheduling editor.

The Schedule Assistant Filter Layout configuration, like the Schedule Board Filter Layout, defines the layout of the controls in the Filter panel. Since the Schedule Assistant uses more filters than the Schedule Board, like Start Time, End Time, Duration, etc., a different layout is used.

> [!NOTE]
> For this exercise, we'll reuse only a subset of the default filters shipped in Universal Resource Scheduling from the Schedule Assistant Filter Layout configuration and add the Languages dropdown as the only available filter.

The filter we are adding to the layout is the same as above in [Filter Layout Configuration](#filter-layout-configuration). The other controls are needed to modify the Schedule Assistant search parameters.

The complete Schedule Assistant Filter Layout

```xml
<?xml version="1.0" encoding="utf-8" ?>
<filter>
  <controls>
    <control type="twocolumn">
      <control type="combo" source="optionset" key="Requirement/msdyn_worklocation" label-id="ScheduleAssistant.West.settingsform.WorkLocation" entity="msdyn_resourcerequirement" attribute="msdyn_worklocation">
        <bind property="disabled" to="Requirement/InitialWorkLocation" operator="eq" value="690970002" />
        <data>
          <value id="690970000" />
          <value id="690970001" />
          <value id="690970002" />
        </data>
      </control>
      <control type="duration" key="Requirement/msdyn_remainingduration" label-id="ScheduleAssistant.West.settingsform.AvailableDuration" />
    </control>
    <control type="distance" key="Requirement/Radius" label-id="ScheduleAssistant.West.settingsform.Radius" min="1">
      <bind property="disabled" to="Requirement/msdyn_worklocation" operator="eq" value="690970002" />
    </control>
    <control type="datetime" key="Requirement/msdyn_fromdate" label-id="ScheduleAssistant.West.settingsform.StartDay">
      <bind property="disabled" to="Requirement/RealTimeMode" operator="eq" value="true" />
      <bind property="max" to="Requirement/msdyn_todate" operator="eq" />
    </control>
    <control type="datetime" key="Requirement/msdyn_todate" label-id="ScheduleAssistant.West.settingsform.EndDay">
      <bind property="min" to="Requirement/msdyn_fromdate" operator="eq" />
    </control>
    <control type="combo" source="entity" key="Languages" inactive-state="1" label-id="Languages" entity="lang_language" multi="true" />
  </controls>
</filter>
```

#### Update the Schedule Assistant Filter Layout

1. In the top right, double-click the Language tab
1. In the top right, click Open Default Settings
1. Scroll to the Schedule Types section and select None in the left list
1. Locate the Schedule Assistant Filter Layout field, click the button to the right to open the editor
1. Update the Value field with the Schedule Assistant Filter Layout code above and click Save As
1. Enter "Language Schedule Assistant Filter Layout" in the Name field and click Save. This creates a new configuration record and links this Schedule Board to the record.
1. At the bottom of the dialog, click Apply

The board will reload. Next, we need to change the Retrieve Constraints Query before we can use the Schedule Assistant with our new Language constraints, so that the Languages set on the Requirement are part of the Schedule Assistant search.

### Retrieve Constraints Query Configuration

> [!TIP]
> For the below steps, it is helpful to use a text editor that supports XML syntax highlighting to make your changes, and then paste your changes back into the Universal Resource Scheduling editor.

The Retrieve Constraints Query configuration is a [UFX Query](universal-fetchxml.md#ufx-queries) used by the Retrieve Requirement Constraints API. It takes as input the ID of a Requirement record (selected in the UI) and returns the Requirement record and all its child records.

> [!NOTE]
> The default Retrieve Constraints Query shipped with Universal Resource Scheduling is a large query that supports all the requirement constraints included with Universal Resource Scheduling. For this exercise, we'll use only a subset of the default query and add Languages as the only filter.

```xml
<Languages ufx:select="lookup-to-list(Requirement/lang_primarylanguage, Requirement/lang_secondarylanguage)" />
```

UFX Queries are processed in sequential order. The Retrieve Constraints Query uses FetchXML to query the `Requirement (msdyn_resourcerequirement)` entity and assigns the result, a Requirement record, to the  `Requirement` property. We are adding to the constraints property bag a new property `Languages` that combines both attributes, the Primary Language and Secondary Language, into a single list of entities (EntityCollection). This is required since we are showing the Languages control in the Filter panel as a list of records. An alternative would be to create two separate controls in the Filter panel for the two attributes.

Here is the description of each **`element`** and `attribute`:

Name | Description
--- | ---
**`Languages`** | Create a new property in the result constraints property bag named `Languages`
`ufx:select` | Assign the result of the XPath expression in this attribute to the `Languages` property. The `lang_primarylanguage` and `lang_secondarylanguage` properties, retrieved earlier in the query and available in the `Requirement` property, is passed to the `lookup-to-list` XPath function, which converts multiple `lookup` properties to a single `list (EntityCollection)`

Retrieve Constraints Query:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<bag xmlns:ufx="https://schemas.microsoft.com/dynamics/2017/universalfetchxml">
  <Requirement ufx:source="fetch" ufx:select="bag[1]">
    <fetch top="1">
      <entity name="msdyn_resourcerequirement">
        <all-attributes />
        
        <filter>
          <condition attribute="statecode" operator="eq" value="0" />
          <condition attribute="msdyn_resourcerequirementid" operator="eq">
            <ufx:value select="$input/@ufx-id" attribute="value" />
          </condition>
        </filter>
      </entity>
    </fetch>

    <bag>
      <InitialWorkLocation ufx:select="msdyn_worklocation" />
    </bag>
  </Requirement>
  
  <Languages ufx:select="lookup-to-list(Requirement/lang_primarylanguage, Requirement/lang_secondarylanguage)" />
</bag>
```

#### Update the Retrieve Constraints Query

1. In the top right, double-click the Language tab
1. In the top right, click Open Default Settings
1. Scroll to the Schedule Types section and select None in the left list
1. Locate the Schedule Assistant Retrieve Constraints Query field, click the button to the right to open the editor
1. Update the Value field with the Retrieve Resources Query code above and click Save As
1. Enter "Language Constraints Query" in the Name field and click Save. This creates a new configuration record and links this Schedule Board to the record.
1. Locate the Schedule Assistant Retrieve Resources Query field and select the Languages Resources Query we created earlier for the Schedule Board Customizations
1. At the bottom of the dialog, click Apply

The board will reload with the updated configuration. Schedule Assistant filtering will now work. If you created Language records and associated them with Requirement records, you will now be able to select a Requirement record in the bottom of the Schedule Board, click Find Availability to launch the Schedule Assistant, and see only resources matching the languages saved on the requirement.

<a name="resource-cell-template-configuration"></a>
### Resource Cell Template Configuration

> [!TIP]
> For the below steps, it is helpful to use a text editor that supports HTML syntax highlighting to make your changes, and then paste your changes back into the Universal Resource Scheduling editor.

The Resource Cell Template configuration is a [Handlebars](https://handlebarsjs.com/) template used to render content in the resource cell. The output from the Retrieve Resources Query is available to the template.

We are modifying the default resource template to show a green ✔✱ indicator if the resource matched the primary and secondary languages, a green ✔ indicator if the resource only matched the primary language, and a yellow ✔ indicator if the resource matched only the secondary language.

```html
{{#if lang_primary}}
<span style='color:green;'>&#10004;{{#if lang_secondary}} &#10033;{{/if}}</span>
{{else if lang_secondary}}
<span style='color:#ffe700;'>&#10004;</span>
{{/if}} 
```

The `lang_primary` and `lang_secondary` properties are returned from our custom [Retrieve Resources Query](#retrieve-resources-query-configuration) we setup above. Consult the [Handlebars](https://handlebarsjs.com/) website for documentation on the templating syntax.

Resource Cell Template:

```html
<div class='resource-card-wrapper {{iif ResourceCellSelected "resource-cell-selected" ""}} {{iif ResourceUnavailable "resource-unavailable" ""}} {{iif IsMatchingAvailability "availability-match" ""}}'>
  {{#if imagepath}}
  <img class='resource-image' src='{{client-url}}{{imagepath}}' />
  {{else}}
  <div class='resource-image unknown-resource'></div>
  {{/if}}
  <div class='resource-info'>
    <div class='resource-name primary-text ellipsis' title='{{name}}'>{{name}}</div>
    <div class='secondary-text ellipsis'>
      {{#if (eq (is-sa-grid-view) false) }}
      <div class='booked-duration'>{{BookedDuration}}</div>
      <div class='booked-percentage'>
        {{BookedPercentage}}%
        
        {{#if lang_primary}}
        <span style='color:green;'>&#10004;{{#if lang_secondary}} &#10033;{{/if}}</span>
        {{else if lang_secondary}}
        <span style='color:#ffe700;'>&#10004;</span>
        {{/if}}            
      </div>
      {{/if}}
    </div>
    {{#if (eq (is-sa-grid-view) false) }}
    <div class='matching-indicator'></div>
    {{/if}}
  </div>
  {{#if (eq (is-sa-grid-view) false) }}
  {{> resource-map-pin-template this }}
  {{/if}}
</div>
```

#### Update the Resource Cell Template

1. In the top right, double-click the Language tab
1. In the top right, click Open Default Settings
1. Scroll to the Schedule Types section and select None in the left list
1. Locate the Schedule Assistant Resource Cell Template field, click the button to the right to open the editor
1. Update the Value field with the Resource Cell Template code above and click Save As
1. Enter "Language Resource Cell Template" in the Name field and click Save. This creates a new configuration record and links this Schedule Board to the record.
1. At the bottom of the dialog, click Apply

The board will reload with the updated configuration. The resource cell will now indicate how a resource matched the language constraint in the Filter panel.

### Summary

In the above steps, we modified the Filter panel in the Schedule Assistant to show a filter control for the Language entity. We also modified the Retrieve Constraints Query to query the new Language attributes related to the Requirement entity, and shape them into a list. When a user selects to find availability for a Requirement record, the Filter panel will show the captured Language constraints. The values from the Filter panel are passed into the Retrieve Resources query and the FetchXML query returns only matching resources.

### See also

[Universal Fetch XML](universal-fetchxml.md)

[Universal Resource Scheduling extensibility release notes](extensibility-release-notes.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]