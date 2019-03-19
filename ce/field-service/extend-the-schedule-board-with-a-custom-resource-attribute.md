---
title: "Extend the schedule board with a custom resource attribute | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2019
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

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


Purpose
In the July 2017 update for Field Service and Project Service Automation (more in this blog entry: https://blogs.msdn.microsoft.com/crm/2017/10/16/blog-post-july-2017-update-for-field-service-and-project-service-automation-universal-resource-scheduling-part-1 ) we introduced the ability to extend the schedule board. This document provides a practical example: We add an attribute “resource cost” to the bookable resource entity. Since your regions, industries and currencies may be completely different, we’re not using an absolute value, instead a score from 1 (cheapest) to 10 (most expensive).
We then expose the attribute in three different places:
•	On the resource card (just for viewing the cost, using a graphical element)
•	In the search panel, so that you can provide a maximum cost level for the desired resources
•	In the sort box, to allow you to sort from cheap to expensive or the other way round.
This example can also be used in situations where you first want to schedule internal people and then external parties, because they are usually more expensive.
2.	Add the new field
Go to Customization, select the Bookable Resource entity, then Fields and add a new field Resource Cost with the schema name tsp_resourcecost.
 
Use the data type Option Set and select the existing option set Level of Importance. This is simply to have a list of 1 to 10, where the underlying numeric values are also 1 to 10.
Add the newly created field to the form to be able to administrate your resources. Publish the changes.
3.	Create a new schedule board (or modify an existing one)
Navigate to the schedule board that you want to change. I have created a new one called DE#2. Here is what we are trying to achieve:

  
Modify the Resource Cell Template
As a first step, the resource cost indicator should be displayed in the resource cell (1). Font Awesome can be used to display icons, such as €, $ (or £ if you’re on the Brexit island). The HTML first draws 10 gray icons as background, then 10 yellow icons as foreground. Then the size of the foreground icons is limited to the value of resourcecost, i.e. a value of 1 is converted to 10%, which means only 10% of the 10 yellow Euros will be displayed. A value of 5 shows 50% of the 10 yellow Euros. You get the idea…













Double-click the tab of your schedule board (DE#2 in the above case). Scroll down to Resource Cell Template. You cannot (and should not) modify the standard templates. Use the button and Save As to create a custom template. Paste the following HTML. If you modify an existing template, only insert the section marked in yellow. Replace fa-euro if you need a different symbol.
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

Modify the Filter Layout
The goal is to define a maximum cost factor when searching for candidates (2) and also allow sorting by cost factor (3). Scroll to Filter Layout. Use the button and Save As to create a custom template. Paste the following HTML. If you modify an existing template, only insert the section marked in yellow. 
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

Modify the query
The last step is to modify the actual query and include the new filter (the “le” operator only leaves resources with a cost factor less or equal to the one selected in the filter panel). Scroll to Retrieve Resources Query. Use the button and Save As to create a custom template. The existing code if pretty lengthy, thus I only provide the additional sections. 
Place this after <entity name="bookableresource">:
		<attribute name="tsp_resourcecost" alias="resourcecost" groupby="true"/>

Place this after the </filter> tag of the <!-- Territory filter -->
		<filter type="or" ufx:if="$input/ResourceCost">
			<condition attribute="tsp_resourcecost" operator="le">
				<ufx:value select="$input/ResourceCost" attribute="value" />
			</condition>
		</filter>

4.	Test your new schedule board
In the screenshot below I have defined a maximum cost factor of 5 and ascending sort order based on cost.
 
Enjoy!

