---
title: URS Extensibility Release Notes | Microsoft Docs
description: URS Extensibility Release Notes
keywords: Universal Resource scheduling; Dynamics 365 for Field Service, Dynamics 365 for Project Service, Field Service, Project Service, Project Service Automation
author: yonalow
ms.author: yolow
manager: shellyha
ms.date: 06/14/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.technology: 
  - "field-service"
  - "project-service"
ms.assetid: a5df453e-9246-47f8-b979-a73371be838e
ms.custom:
  - dyn365-projectservice
  - dyn365-fieldservice
---

# URS Extensibility Release Notes

- [May 2018](#may-2018)
- [April 2018](#april-2018)
- [February 2018](#february-2018)
- [December 2017](#december-2017)
- [July 2017](#july-2017)

<a name="May 2018"></a>
## May 2018

### Resource Cell Template

#### Hide Resource Image

The default Resource Cell Template shipped in this update includes support for automatically hiding the resource image if the resource row in the Schedule Board is configured to a small height. If you have a custom Resource Cell Template, add the below template updates to your Resource Cell Template configuration record.

The first and last line are newly introduced to light up the functionality. The updated markup to hide the resource image:
```html
{{#if (or (eq (is-sa-grid-view) true) (eq (is-row-small) false)) }}
    {{#if imagepath}}
    <img class='resource-image' src='{{client-url}}{{imagepath}}' />
    {{else}}
    <div class='resource-image unknown-resource'></div>
    {{/if}}
{{/if}}
```

The first line is new. The updated markup to hide the second row of text in the template: 
```html
{{#if (and (eq (is-sa-grid-view) false) (eq (is-row-small) false)) }} 
    <div class='booked-duration'>{{BookedDuration}}<div class='fo-sch-clock'></div></div>
    <div class='booked-percentage'>{{BookedPercentage}}%</div>  
{{/if}}
```
> For more context, see this article - https://docs.microsoft.com/en-us/business-applications-release-notes/april18/dynamics365-field-service/removed-resource-image

<a name="april-2018"></a>
## April 2018

### Retrieve Constraints Query

#### Ignore Proposed Bookings

The default Retrieve Constraints Query shipped in this update includes a default value for the Ignore Proposed Bookings parameter used by the Schedule Assistant. To change the default value for this parameter, or if you have a custom Retrieve Constraints Query, update or add the below new property to the `Requirement` bag transformation part in your Retrieve Constraints Query configuration record.

The added `IgnoreProposedBookings` property:
```xml
<IgnoreProposedBookings ufx-type="bool">true</IgnoreProposedBookings> 
```
> Here is a link to an article with more context on ignore proposed functionality - https://docs.microsoft.com/en-us/business-applications-release-notes/april18/dynamics365-field-service/ignore-proposed-bookings

<a name="february-2018"></a>
## February 2018

### Schedule Assistant Filter Layout

#### Ignore Proposed Bookings

The default Schedule Assistant Filter Layout shipped in this update includes a new checkbox control to set the Ignore Proposed Bookings parameter used by the Schedule Assistant. If you have a custom Schedule Assistant Filter Layout, add the below new control to the last `fieldset` control section in your Schedule Assistant Filter Layout configuration record.

The new `IgnoreProposedBookings` control
```xml
<control type="boolean" key="Requirement/IgnoreProposedBookings" label-id="ScheduleAssistant.West.settingsform.IgnoreProposedBookings" />
```
> Here is a link to an article with more context on ignore proposed functionality - https://docs.microsoft.com/en-us/business-applications-release-notes/april18/dynamics365-field-service/ignore-proposed-bookings

<a name="december-2017"></a>
## December 2017

### Retrieve Resources Query

#### Schedule Board Visible Date Range

Included in this update, the Retrieve Resources Query gets as input the visible date range of the Schedule Board. This lets the query use the board's date range in its database queries. The default Retrieve Resources Query shipped in this update has not changed. However, you can now customize the query to depend on the board's visible date range.

The updated input parameters available in the XPath `$input` variable are `ScheduleBoard/StartDate` and `ScheduleBoard/EndDate`.

The below snippet (not shipped) shows how the new input parameters can be used to query the total number of bookings per resource in the date range visible on the board.
```xml
<!-- Booking join -->
<link-entity name="bookableresourcebooking" from="resource" to="bookableresourceid" link-type="outer">
    <attribute name="name" aggregate="countcolumn" alias="bookingcount" />

    <filter>
        <condition attribute="statecode" operator="eq" value="0" />
        <condition attribute="starttime" operator="le">
            <ufx:value select="$input/ScheduleBoard/EndDate" attribute="value" />
        </condition>
        <condition attribute="endtime" operator="ge">
            <ufx:value select="$input/ScheduleBoard/StartDate" attribute="value" />
        </condition>
    </filter>
</link-entity>
```

The below snippet (not shipped) shows how the Resource Cell Template can then be customized to show the total number of bookings.
```html
<div>Booking Count: {{bookingcount}}</div>
```
> When changing the dates on the Schedule Board, the Resource Query is not automatically executed again. Rather, you must click the search button to re-execute the search using the new Schedule Board visible dates.
> 
> For more context, here is a blog post on the subject - https://blogs.msdn.microsoft.com/crm/2017/12/15/new-use-schedule-board-date-ranges-in-custom-queries-in-universal-resource-scheduling/

### Schedule Assistant Filter Layout

#### Sort by Total Availability

The default Schedule Assistant Filter Layout shipped in this update includes a new order option to sort the result of the Schedule Assistant by a resource's total availability. If you have a custom Schedule Assistant Filter Layout, add the below new order option to the `order` control in your Schedule Assistant Filter Layout configuration record.

The new sort option
```xml
<order name="totalavailabletime" entity="bookableresource" attribute="totalavailabletime" label-id="ScheduleAssistant.Center.slotsgrid.TotalAvailableTime" />
```
> For more context on the scenario, here is a blog post - https://blogs.msdn.microsoft.com/crm/2017/12/15/sort-available-resources-by-total-available-time-in-universal-resource-scheduling/

<a name="july-2017"></a>
## July 2017

The July 2017 update for URS was the initial release for extensible queries, custom filter layouts, and resource cell template
