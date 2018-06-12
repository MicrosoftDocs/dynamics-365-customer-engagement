# Extending URS: Find Resources by Language - A Step by Step Guide

> This step by step guide is a companion to [Understanding and Customizing Resource Matching in Universal Resource Scheduling (URS)](understanding-and-customizing-resource-matching-in-urs.md)

In this step-by-step guide, we'll extend URS resources with a `Language` constraint. Consider an organization that wants to filter resources by the languages they speak. They also want to capture on the `Requirement` record the language required for the job. This constraint follows a similar pattern to the built-in `Territory` constraint. A new master entity `Language` will store the different languages a resource can speak. A `Resource` record can then be associated to many `Languages` through a many-to-many relationship entity. On the `Requirement` entity, we'll model this by creating two new lookup attributes: `Primary Language` and `Secondary Language`. When finding available resources for a requirement, only resources associated with either the `Primary Language` or the `Secondary Language` will be shown.

## Creating the New Entities and Relationships

In this section we'll create the new schema for the master `Language` entity and update the `Resource` and `Requirement` entities with the corresponding relationships to the new `Language` entity.

### Create a New Publisher

1. In Dynamics 365, under Customizations, create a new Publisher
1. Fill out the New Publisher form with the below details:

    Field | Value
    --- | ---
    Display Name | Language
    Name | language
    Prefix | lang

1. Click Save and Close

### Create a New Solution

1. In Dynamics 365, under Customizations, create a new Solution
1. Fill out the New Solution form with the below details:

    Field | Value
    --- | ---
    Display Name | Language
    Name | Language
    Publisher | Language
    Version | 1.0.0.0

1. Click Save

### Create the Language Entity

1. In the Language solution, create a new Entity
1. Fill out the New Entity form with the below details:

    Field | Value
    --- | ---
    Display Name | Language
    Plural Name | Languages
    Name | lang_language (The `lang_` prefix will be auto-filled and read-only)

1. Click Save

### Create the Many-to-Many Relationship from the Resource Entity to the Language Entity

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

### Create the Relationships from the Requirement Entity to the Language Entity

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

#### Update the Requirement Main Form

1. In the Resource Requirement entity, add the existing Information form to the entity's subcomponents (If presented with a Missing Required Components dialog, select No, do not include required components.)
1. In the Information form, use the Field Explorer to add the two new attributes, Primary Language and Secondary Language to the form so users can enter this information as they create requirements
1. Click Save
1. Click Publish
1. You can close the form editor

### Summary

In the above steps, we created the new Language entity. We then added new relationships with the Resource and Requirement entities. Resources can be related to multiple languages, since we added a many to many relationship between Language and Resource. Requirements can be related to two Languages since we added two lookup attributes on Requirement entity pointing to the new Language entity.

#### Adding Data

Use Advanced Find to add new records to the Language entity. You can then associate Resource records to the new Language records by opening a Resource record and navigating to the Language relationship in the navigation bar. For Requirement records, you can fill in the new Primary Language and Secondary Language fields on the Requirement form.

## Customizing the Schedule Board

To filter resources in the Schedule Board with the new Language constraint, we'll update the Retrieve Resources Query and the Filter Layout configuration records.

### Filter Layout Configuration

> For the below steps, it is helpful to use a text editor that supports XML syntax highlighting

The Filter Layout configuration is an XML layout definition to customize the layout of the Filter panel.

> For this exercise, we'll remove all default filters shipped with URS from the Filter panel and add Languages as the only available filter.

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

The complete Filter Layout

```xml
<?xml version="1.0" encoding="utf-8" ?>
<filter>
  <controls>
    <control type="combo" source="entity" key="Languages" inactive-state="1" label-id="Languages" entity="lang_language" multi="true" />
  </controls>
</filter>
```

#### Create a new Languages Board

In order to keep these changes isolated, we will create a brand new separate Schedule Board and implement the changes, but you can always make these changes on the default Schedule Board so that other Schedule Boards can automatically inherit these changes.

1. In Dynamics 365, in the top navigation bar, go to Resource Scheduling > Schedule Board
1. In the top right, click the + sign to create a new board
1. Name the new board Language
1. At the bottom of the dialog, click Add. The new board will be created.

#### Update the Schedule Board Filter Layout

Next, we will create a new configuration record which stores filter layouts and queries used by the Schedule Board, and then we will link the newly created Schedule Board to the new configuration record. There are multiple ways to do this, but here is the quickest:

1. In the top right, double click the Language tab
1. Scroll down to General Settings > Other Settings
1. Locate the Filter Layout field, click the button to the right to open the editor
1. Update the Value field with the Filter Layout code above and click Save As. 
1. Enter "Language Filter Layout" in the Name field and click Save. This creates a new configuration record.
1. Select the newly created configuration record from the dropdown menu in the Filter Layout field to link this Schedule Board to the new Filter Layout.
1. At the bottom of the dialog, click Apply

The board will reload and you will see the Filter panel in the left with the new layout; only the Languages filter will be available. Filtering will not work yet, as we need to update the Retrieve Resources Query to take advantage of the new filter.

### Retrieve Resources Query Configuration

> For the below steps, it is helpful to use a text editor that supports XML syntax highlighting

The Retrieve Resources Query configuration is a [UFX Query](./Universal-FetchXML.md) used by the Resource Matching API. It takes as input the values entered in the Filter panel and dynamically constructs the correct FetchXML to find matching resources.

> The default Retrieve Resources Query shipped with URS is a large query that supports all the resource constraints included with URS. For this exercise, we'll use only a subset of the default query and add Languages as the only filter.

```xml
<link-entity name="lang_lang_language_bookableresource" from="bookableresourceid" to="bookableresourceid" ufx:if="$input/Languages/bag">
  <filter type="and">
    <condition operator="in" attribute="lang_languageid">
      <ufx:apply select="$input/Languages/bag">
        <value>
          <ufx:value select="@ufx-id" />
        </value>
      </ufx:apply>
    </condition>
  </filter>
</link-entity>
```

> The values selected in the Filter panel is passed as input to the query and is available in the XPath `$input` variable

The Retrieve Resources Query uses FetchXML to query the `Resource (bookableresource)` entity. We are adding a FetchXML `link-entity` element to only return resources associated with the Language records selected in the Filter panel. Here is the description of each element and attribute:

Name | Description
--- | ---
**`link-entity`** | Create a join to the many-to-many relationship between the Resource and Language entities
`ufx:if` | Only emit this FetchXML element (`link-entity`) if the XPath expression in this attribute returns a value
**`filter`** and **`condition`** | Filter the many-to-many relationship records with an `in` condition to only the ones that match the specified Language IDs
**`ufx:apply`** and `select` | Emit the child FetchXML elements for each result returned from the XPath expression in the `select` attribute
**`value`** | Contains the ID of a Language record
**`ufx:value`** and `select` | Outputs the result of the XPath expression in the `select` attribute

The complete Retrieve Resources Query

```xml
<?xml version="1.0" encoding="utf-8" ?>
<bag xmlns:ufx="http://schemas.microsoft.com/dynamics/2017/universalfetchxml">
  <Resources ufx:source="fetch">
    <fetch mapping="logical" aggregate="true">
      <entity name="bookableresource">
        <attribute name="bookableresourceid" alias="bookableresourceid" groupby="true"/>
        <attribute name="name" alias="name" groupby="true"/>
        <attribute name="calendarid" alias="calendarid" groupby="true"/>
        <attribute name="resourcetype" alias="resourcetype" groupby="true"/>
        <attribute name="msdyn_startlocation" alias="startlocation" groupby="true"/>

        <!-- Language join -->
        <link-entity name="lang_lang_language_bookableresource" from="bookableresourceid" to="bookableresourceid" ufx:if="$input/Languages/bag">
          <filter type="and">
            <condition operator="in" attribute="lang_languageid">
              <ufx:apply select="$input/Languages/bag">
                <value>
                  <ufx:value select="@ufx-id" />
                </value>
              </ufx:apply>
            </condition>
          </filter>
        </link-entity>
        
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
    </bag>
  </Resources>
</bag>
```

#### Update the Schedule Board Retrieve Resources Query

1. In the top right, double click the Language tab
1. Scroll down to General Settings > Other Settings
1. Locate the Retrieve Resources Query field, click the button to the right to open the editor
1. Update the Value field with the Retrieve Resources Query code above and click Save As
1. Enter "Language Resources Query" in the Name field and click Save
1. At the bottom of the dialog, click Apply

The board will reload with the updated configuration. Filtering will now work. If you created Language records and associated them with Resource records, you will now be able to filter resources by their associated languages.

### Summary

In the above steps we modified the Filter panel to show a filter control for the Language entity. We also modified the Retrieve Resources Query to match resources associated with the selected Language records. When a user selects values in the filter control and clicks Search, the values are passed into the query and the FetchXML query returns only matching resources.

## Customizing the Schedule Assistant

We need to customize the Schedule Assistant Filter Layout and Retrieve Constraints Query configurations to use the new Language constraints in the Schedule Assistant.

Unlike the Schedule Board customizations, where each board can be individually customized, the Schedule Assistant customizations affects all boards where the Schedule Assistant is used. The Schedule Assistant customizations can be specific to a schedulable type or for all types. In this example we will customize the Schedule Assistant for all types.

### Schedule Assistant Filter Layout Configuration

> For the below steps, it is helpful to use a text editor that supports XML syntax highlighting

The Schedule Assistant Filter Layout configuration, like the Schedule Board Filter Layout, defines the layout of the controls in the Filter panel. Since the Schedule Assistant uses more filters than the Schedule Board, like Start Time, End Time, Duration, etc., a different layout is used.

> For this exercise, we'll reuse only a subset of the default filters shipped in URS from the Schedule Assistant Filter Layout configuration and add the Languages dropdown as the only available filter.

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

1. In the top right, double click the Language tab
1. In the top right, click Open Default Settings
1. Scroll to the Schedule Types section and select None in the left list
1. Locate the Schedule Assistant Filter Layout field, click the button to the right to open the editor
1. Update the Value field with the Schedule Assistant Filter Layout code above and click Save As
1. Enter "Language Schedule Assistant Filter Layout" in the Name field and click Save
1. At the bottom of the dialog, click Apply

The board will reload. We need to change the Retrieve Constraints Query before we can use the Schedule Assistant with our new Language constraints.

### Retrieve Constraints Query Configuration

> For the below steps, it is helpful to use a text editor that supports XML syntax highlighting

The Retrieve Constraints Query configuration is a [UFX Query](Universal-FetchXML.md) used by the Retrieve Requirement Constraints API. It takes as input the ID of a Requirement record (selected in the UI) and returns the Requirement record and all its child records.

> The default Retrieve Constraints Query shipped with URS is a large query that supports all the requirement constraints included with URS. For this exercise, we'll use only a subset of the default query and add Languages as the only filter.

```xml
<Languages ufx:select="lookup-to-list(Requirement/lang_primarylanguage, Requirement/lang_secondarylanguage)" />
```

UFX Queries are processed in sequential order. The Retrieve Constraints Query uses FetchXML to query the `Requirement (msdyn_resourcerequirement)` entity and assigns the result, a Requirement record, to the  `Requirement` property. We are adding to the constraints property bag a new property `Languages` that combine both attributes, the Primary Language and Secondary Language, into a single list of entities (EntityCollection). This is required since we are showing the Languages control in the Filter panel as a list of records. An alternative would be to create two separate controls in the Filter panel for the two attributes.

Here is the description of each attribute:

Name | Description
--- | ---
**`Languages`** | Create a new property in the result constraints property bag named `Languages`
`ufx:select` | Assign the result of the XPath expression in this attribute to the `Languages` property. The `lang_primarylanguage` and `lang_secondarylanguage` properties, retrieved earlier in the query and available in the `Requirement` property, is passed to the `lookup-to-list` XPath function which converts multiple `lookup` properties to a single `list (EntityCollection)`

The complete Retrieve Constraints Query

```xml
<?xml version="1.0" encoding="utf-8" ?>
<bag xmlns:ufx="http://schemas.microsoft.com/dynamics/2017/universalfetchxml">
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

1. In the top right, double click the Language tab
1. In the top right, click Open Default Settings
1. Scroll to the Schedule Types section and select None in the left list
1. Locate the Schedule Assistant Retrieve Constraints Query field, click the button to the right to open the editor
1. Update the Value field with the Retrieve Resources Query code above and click Save As
1. Enter "Language Constraints Query" in the Name field and click Save
1. Locate the Schedule Assistant Retrieve Resources Query field and select the Languages Resources Query we created earlier for the Schedule Board Customizations
1. At the bottom of the dialog, click Apply

The board will reload with the updated configuration. Schedule Assistant filtering will now work. If you created Language records and associated them with Requirement records, you will now be able to select a Requirement record in the bottom of the Schedule Board, click Find Availability to open the Schedule Assistant, and see only resources matching the languages saved on the requirement are shown.

### Summary

In the above steps we modified the Filter panel in the Schedule Assistant to show a filter control for the Language entity. We also modified the Retrieve Constraints Query to query the new Language attributes and shape them into a list. When a user selects to find availability for a Requirement record, the Filter panel will show the captured Language constraints. The values from the Filter panel are passed into the Retrieve Resources query and the FetchXML query returns only matching resources.
