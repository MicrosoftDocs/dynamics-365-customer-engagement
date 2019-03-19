---
title: "Extend the schedule board with a custom resource attribute | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/19/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: LXHeinze
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Extend the schedule board with a custom resource attribute

It is possible to customize the schedule board based on your business needs. Common examples include **(1)** customizing the Resource Cells where the resources' names, pictures, and utilization are listed by default **(2)** customizing the fields in the filter pane where dispatchers decide the resources in a view and **(3)** customizing the sort options (also located in the filter pane) allowing dispatchers to sort the current resources on the the schedule board based on various criteria. This is most commonly achieved by editing the HTML and fetchXML in schedule board's tab settings.

Let's explore customizing the schedule board with the following scenario:

**Scenario:** Each bookable resource (field technician) has a cost based on many factors such as seniority and certification level. Dispatchers would like the general cost of each resource displayed on the schedule board along with the ability to filter and sort by cost. This is common for scenarios where an organization first wants to schedule internal employees and second external contracting parties, who are usually more expensive. Rather than use an exact resource cost, this scenario uses a score of 1 (lowest resource cost) to 10 (highest resource cost) and exposes the score: 

- In the resource cell, for viewing the cost with a graphical element.
- In the filter panel, to filter a by a maximum cost level for the desired resources.
- In the sort options, to sort from lowest to highest cost or vice versa.


## Step 1: Add the new attribute to the bookable resource entity

Go to **Customizations > Customize the System > Bookable Resource > Fields** and add a new field named **Resource Cost** with the schema name **tsp_resourcecost**. If your organization has a different schema prefix such as **new_** this can be used if the code snippets below are updated to reflect this.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


Use the data type **Option Set** and select the existing option set **Level of Importance**. This is simply to have a list of 1 to 10, where the underlying numeric values are also 1 to 10.
Add the newly created field to the form to be able to administrate your resources. **Publish the changes**.



## Step 2: Create a new schedule board (or modify an existing one)
Navigate to the schedule board that you want to add the new resource cost attribute to. In the example image below is a schedule board titled "DE#2". The image also shows the three areas on the schedule board we will customize with the new resource cost attribute. 

1. add resource cost indicator in the resource cells 
2. define a maximum cost score when filtering and searching for resources
3. allow sorting by cost score

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Step 3: Modify the Resource Cell Template

The resource cost indicator should be displayed in the resource cell **(1)**. Font Awesome can be used to display icons, such as €, $, £. The HTML first draws 10 gray icons as a background, then 10 yellow icons as foreground. Then the size of the foreground icons is limited to the value of the resource cost, i.e. a value of 1 is converted to 10%, which means only 10% of the 10 yellow Euro icons will be displayed. A value of 5 shows 50% of the 10 yellow Euro icons.

Double-click the tab of your schedule board (DE#2 in the above case). Scroll down to Resource Cell Template. You cannot (and should not) modify the standard templates. Use the button and Save As to create a custom template. 

> [!Note]
> If you want to set these changes as the default for all schedule boards, after double clicking a schedule board tab, select **Open Default Settings** in the top right and make the code changes to Resource Cell Template, Filter Layout, and Retrieve Resources Query.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-tab-settings-edit-resource-cell.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

 

Below is the new code snippet to copy and paste into the resource cell template, and the image below that shows the delta in yellow that can be used to modify an existing template. Replace fa-euro if you need a symbol different from the euro.

    <div class='resource-card-wrapper {{iif ResourceCellSelected "resource-cell-selected" ""}} {{iif ResourceUnavailable "resource-unavailable" ""}} {{iif IsMatchingAvailability "availability-match" ""}}'>
    {{#if imagepath}}
    <img class='resource-image' src='{{client-url}}{{imagepath}}' />
    {{else}}
    <div class='resource-image unknown-resource'></div>
    {{/if}}
    <div class='resource-info'>
        <div class='resource-name primary-text ellipsis' title='{{name}}'>{{name}}</div>

		<div class='secondary-text ellipsis'> 
			<div class="back-stars" style="color: #EEEEEE; position: relative; display: inline-block;">
				<i class="fa fa-euro" aria-hidden="true"></i>
				<i class="fa fa-euro" aria-hidden="true"></i>
				<i class="fa fa-euro" aria-hidden="true"></i>
				<i class="fa fa-euro" aria-hidden="true"></i>
				<i class="fa fa-euro" aria-hidden="true"></i>
				
				<div class="resourcecost" style="width: {{resourcecost}}0%; color: #FFBC0B; position: absolute; top: 0; left:0; display: inline-block; overflow: hidden;">
					<i class="fa fa-euro" aria-hidden="true"></i>
					<i class="fa fa-euro" aria-hidden="true"></i>
					<i class="fa fa-euro" aria-hidden="true"></i>
					<i class="fa fa-euro" aria-hidden="true"></i>
					<i class="fa fa-euro" aria-hidden="true"></i>
				</div>
			</div>
		</div>

        <div class='secondary-text ellipsis'>
            {{#if (eq (is-sa-grid-view) false) }}
            <div class='booked-duration'>{{BookedDuration}}<div class='fo-sch-clock'></div></div>
            <div class='booked-percentage'>{{BookedPercentage}}%</div>
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

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-tab-settings-resource-cell-template-yellow.png)

## Step 4: Modify the Filter Layout

Next, the goal is to define a maximum cost score when filtering and searching for resources **(2)** and also allow sorting by cost score **(3)**. 

To accomplish this, from the same schedule board tab setting where you edited the Resource Cell Template, scroll to **Filter Layout**. Use the gear button and Save As to create a custom template. 

Below is the new code snippet to copy and paste into the Filter Layout, and the image below that shows the delta in yellow that can be used to modify an existing template.



<?xml version="1.0" encoding="utf-8" ?>
<filter>
  <controls>
    <control type="characteristic" key="Characteristics" label-id="ScheduleAssistant.West.Skills" />

	<control type="combo" source="optionset" key="ResourceCost" label-id="Resource Cost Limit" entity="bookableresource" attribute="tsp_resourcecost" multi="false">
    </control>
				
    <control type="combo" source="entity" key="Roles" inactive-state="1" label-id="ScheduleAssistant.West.Roles" entity="bookableresourcecategory" multi="true" />
    <control type="combo" source="entity" key="Territories" unspecified-key="UnspecifiedTerritory" label-id="ScheduleAssistant.West.Territories" entity="territory" multi="true" />
    <control type="combo" source="entity" key="OrganizationalUnits" label-id="SB_FilterPanel_OrganizationalUnitsFilter_Title" inactive-state="1" entity="msdyn_organizationalunit" multi="true" />
    <control type="combo" source="optionset" key="ResourceTypes" label-id="SB_FilterPanel_ResourceTypesFilter_Title" entity="bookableresource" attribute="resourcetype" multi="true">
      <data>
        <value id="2" />
        <value id="3" />
        <value id="4" />
        <value id="5" />
      </data>
    </control>
    <control type="combo" source="entity" key="Teams" label-id="SB_FilterPanel_TeamsFilter_Title" entity="team" multi="true" />
    <control type="combo" source="entity" key="BusinessUnits" label-id="SB_FilterPanel_BusinessUnitsFilter_Title" entity="businessunit" multi="true" />
    <control type="order" key="Orders" label-id="FilterControl_OrderLabel">
      <order name="name" entity="bookableresource" attribute="name" />
      <order name="resourcecost" entity="bookableresource" attribute="tsp_resourcecost" />
      <order name="proficiencyscore" entity="bookableresourcecharacteristic" attribute="ratingvalue" />
    </control>
  </controls>
</filter>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-tab-settings-filter-layout-yellow.png)

## Step 5: Modify the query

The last step is to modify the actual query and include the new filter (the “le” operator only leaves resources with a cost score less or equal to the one selected in the filter panel). Scroll to **Retrieve Resources Query**. 

Use the button and Save As to create a custom template. The existing code if lengthy, so below are only the code snippets to paste within an existing resource query.

After 
            
        <entity name="bookableresource">:

paste the following

        <attribute name="tsp_resourcecost" alias="resourcecost" groupby="true"/>

See this image for reference:

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-tab-settings-resource-query-snippet1.png)

After the ending

            </filter> tag of the <!-- Territory filter -->

Paste the following

		<filter type="or" ufx:if="$input/ResourceCost">
			<condition attribute="tsp_resourcecost" operator="le">
				<ufx:value select="$input/ResourceCost" attribute="value" />
			</condition>
		</filter>

See this image for reference:

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-tab-settings-resource-query-snippet2.png)


## Step 6: Test your new schedule board
In the screenshot below I have defined a maximum cost factor of 5 and ascending sort order based on cost.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

### See also

[July 2017 update for Field Service and Project Service Automation blog post](https://blogs.msdn.microsoft.com/crm/2017/10/16/blog-post-july-2017-update-for-field-service-and-project-service-automation-universal-resource-scheduling-part-1)

