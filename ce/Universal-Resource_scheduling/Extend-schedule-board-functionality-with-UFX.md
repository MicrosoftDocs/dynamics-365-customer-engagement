---
title: Extend Schedule Board Functionality with Universal FetchXML | Microsoft Docs
description: Find number of bookings scheduled during particular date ranges
keywords: Universal Resource scheduling; Dynamics 365 for Field Service, Dynamics 365 for Project Service, Field Service, Project Service, Project Service Automation
author: nabuthuk
ms.author: nabuthuk
manager: shellyha
ms.date: 05/14/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 81362115-e91a-4c13-92ac-391765c55deb
---
## Extend Schedule Board Functionality with UFX

Applies to: Dynamics 365 for Field Service, Dynamics 365 for Project Service, Universal resource Scheduling, Dynamics 365 9.0.x
### Overview

This topic provides you with sample code to implement common schedule board extensibility use cases, and to  customize the schedule board for field service organizations and other scenarios using **Universal FetchXML (UFX)**.

If you’re brand new to building queries in Dynamics 365, first check out the article Build a query with FetchXML for background. Universal FetchXML takes the capabilities of FetchXML and adds to them to enable schedule board extensibility.

UFX is an advanced query language that allows you to query data using dynamic FetchXML, and then shape and prepare the resulting data for consumption by the Universal Resource Scheduling (URS) solution. 

This query language enables you to create custom queries to customize and extend the schedule board and schedule assistant filters to meet the unique business needs of the organization. 

To help you get a head start on building your own queries with UFX, we’ve given you access to the out-of-the-box queries for filtering resources or searching for availability on the schedule board, and allow you to modify the front-end filter control that resource managers and schedulers use to interact with the schedule board. 

For example, Let's say we want to find out the total count of bookings scheduled during the date ranges. 

### Find total bookings scheduled during a date range

Use UFX to build a query that allows a user to use the date range displayed on the schedule board to return matching bookings within that date range.

There are two values available for the input bag of the retrieve resource query: schedule board visible start and schedule board visible end date. The keys for these two values are  `$input/ScheduleBoard/StartDate and $input/ScheduleBoard/EndDate`.

The values are bound to the current schedule board’s visible data range and can be used in the UFX query condition to select data based on the visible dates.
Follow the steps below to add the UFX block to the default Retrieve Resource Query.

-	Navigate to **Universal Resource Scheduling > Schedule Board**.
-	Click the **+** icon next to initial public view and click on **Open Default Settings**.

![Result Showing on thre resource card](../Universal-Resource_scheduling/media/Result-showing-on-the-resource-card.png "Result showing on the Resource card")
                        
-	Scroll down to **Retrieve Resource query** and click on **gear** icon.
-	Add the sample code block shown below.
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
</condition>s
</filter>
</link-entity>
```
- Click on **Save as**, name the query and click **Save**


