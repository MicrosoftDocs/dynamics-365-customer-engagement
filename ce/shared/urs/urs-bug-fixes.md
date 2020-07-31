## 3.12.24.4

- When you enable any entity for scheduling (for example, case, lead, account), enable **Quick Book** feature on the **Booking Setup Metadata** record of this schedulable entity, and set **Disable Requirement Auto Creation for Bookings** to yes. The resource requirement records will not be generated post the creation of the booking record. 
- The bug where there are multiple pages of available resources suggested on the schedule assistant, only the resources in the first page set were shown and resources on higher pages were not shown. This bug is fixed, and paging through to next pages, resources will be shown as expected.
- When there are multiple workhours are entered on the same day for a resource (for example, 8 AM to 3:30 PM and 2 PM to 5 PM), there was a bug where the resource workhours calendar was only showing workhours as 2 PM to 5 PM. With this fix, the calendar for the resource would show that the resource is working 8 AM to 5 PM. Also, the same should be reflected on the schedule board. 
- When a resource has working hours (for instance, 9 AM to 5 PM on a day) and has a time off 12 PM to 1 PM, there is a bug where schedule board shows that the resource has no working hours on that day, though the time off is for only one hour. This bug is fixed, and with this fix, the resource should show as working from 9 AM to 12 PM and 1 PM to 5 PM on the schedule board. 
- When creating a resource requirement using a work hours template, performance improvements are made to reduce the time of creation for the resource requirement record. 
- When the resource workhours are entered by using non-recurrence patterns for a large number of days, and large number of resources (for instance, more than 2000 resources in the org), when looking for available resources, the schedule assistant takes almost 40 seconds to load resources. Performance improvements are pushed as part of this fix, where in this case, the schedule assistant loads much faster (around five to ten seconds, largely based on the amount of data). 

## 3.12.23.71

- The issue with the filtering on the lookup type fields on the schedule board's requirement panel is fixed. 
- When hovered on the bookings on the schedule board, the tooltip was shown instantly, which sometimes blocked the view or blocked using right-click on the bookings. This issue is now fixed by adding a hover delay. When hovered on the booking, tooltip will be displayed with a delay.

## 3.12.23.26

- The rendering issue for tooltips on bookings of the schedule board is now fixed, by making the tooltip scrollable when the height of the tooltip is larger than the browser size. The hyperlinks on the tooltip can also be selected to open them in a new browser window.
- The text **Hide default requirement panels** is now made visible on the schedule board tab settings under the **Requirement Panels** section, which was previously only partially visible.
- Fixed an issue where entering a comma on the filter control of the filter panel was clearing the input on the filter control. With the fix, the comma will not influence the autocomplete, which was causing issues for customers who have a comma in their filter options.
- If the work hours tab is renamed or removed from a custom bookable resource form, when you select the **Show work hours** button, an error will be displayed: **The Work Hours tab has been renamed or removed from this form. Please update this form to include the Work Hours tab.** Update so that the work hours tab can be added back to the form.
- Fixed an issue on the **Create resource booking** panel on the schedule board. With the fix, the **Start Date** and **End Date** on the panel will always reflect the **From Date** and **To Date** of the requirement selected in the **Requirement Panel** at the bottom of the board.
- The map pins of the resource requirement records are loaded on the map view of the filter panel on the schedule board, based on the view that is defined on **Requirement Map Filter View** on schedule board settings. We fixed the issue where, if the view used here has no filters on the view definition, the map panel never completes loading. With this fix, the map panel would load, regardless of the filters on the view used.
- Fixed an issue where **Universal Resource Scheduling** is used as the scheduling engine; users who are not system administrators were unable to complete the appointment records. With the fix, any user with privileges to complete the appointment record can mark the appointment as complete.

## 3.12.22.9

- For organizations that have [schedule board preview enabled](https://aka.ms/scheduleboard), the schedule board preview can be accessed from **Field Service** application sitemap along with **Universal Resource Scheduling** application sitemap.
- Fixed an issue where booking tooltip blinks when the height of the tooltip is greater than the height of the visible center Gantt area, where bookings are displayed on the schedule board. With this fix, the tooltip would not blink and the user would be able to click on the hyperlinks on the tooltip to open the respective record in a new window.
- Fixed the issue where [intervals](https://docs.microsoft.com/dynamics365/common-scheduler/fulfillment-preferences#interval-setup) functionality of fulfillment preferences was not working on the schedule assistant.
- Resolved the issue of duplicated time slots for the resources on the list view type of the days view of the schedule board.
- Multiple calls to retrieve data in the list view type of the days view are reduced to one call, in order to improve schedule board performance.
- Fixed the issue where available time slots of resources are displayed differently on schedule assistant and the quick scheduling pane for the schedulable entities that do not have an associated resource requirement record.
- The horizontal and vertical view types are now hidden from the requirement group's find availability or schedule assistant screen.
- Fixed the error **The start address and end address cannot be empty**, which is incorrectly thrown on the **Get Driving Directions** functionality on the schedule board, due to an uncaught exception.
- Advanced find on the business closures entity is now supported.
- When using the schedule assistant/find availability functionality, the available time slots should be shown in the same timezone of the requirement calendar; however, if a schedulable entity like case doesn't have a requirement record associated, then the results need to be shown in the timezone of the CRM user preference.
- The issue of resource name truncation in the days view of the schedule board is now fixed.
- Fixed the focus shifting issue on the schedule board, where focus is shifted to a previous booking in focus, when booking status of the bBooking assigned to a resource at the bottom of the resource list. With this fix, the focus would stay on the booking in context.
- Fixed a translation issue on requirement groups in Japanese, where the name of the requirement or subgroups changes from Japanese to English when the record is saved.
- Quick scheduling now supports and handles different date format styles like English (South Africa).  
- Fixed an issue with the **Allow Overlapping** functionality on the bookings. With this fix, when a booking is marked as **Allow Overlapping** set to yes, the schedule assistant (find availability) will show the above booking as an available time slot if the **Allow Overlapping** advanced setting on the filter view is selected.

## 3.12.21.9

- The following Universal resource Scheduling 2020 Wave 1 features in GA and preview planned are included in this release:
  - Next generation schedule board experience (preview)
  - Enhanced work hours calendar for resources
  - requirement dependency for efficient workflow
  - resource scheduling dashboard
- This release also includes all fixes included in the [3.12.9.76 EA package](https://docs.microsoft.com/dynamics365/field-service/field-service-version-history-resource-scheduling#312976---april-2020-wave-1-early-access).
- Fixed an issue where the booking method on booking panel was not selectable on the list view of the days view in schedule board.
- Fixed a caching issue on the **Get Driving Directions** pop-up functionality of the schedule board, where previously cached values were being used for calculating the route.
- Resolved the incorrect location displayed for the booking on the map view of the schedule board, due to the incorrect formatting issue in conversion of the latitude and longitude on the map in languages like German.
- Fixed the issue where bookings of some schedulable entities cannot be moved to a different day in multiday views like days and weeks views on the schedule board.
- Fixed the issue when a requirement is dragged on to a crew resource on schedule board, a booking is only created for the crew resource and not the underlying active crew resources.
- Fixed an issue where a custom JavaScript is used in the schedule board client extensions to set the default filter values, but the prepopulated default values are only displayed when the respective filter control is selected.
- Fixed an issue where quick scheduling is used on a schedulable entity without associated resource requirement record, and search start and search end dates are passed as the same day; available time slots were displayed for three days rather than one passed in day. With the fix, the available will only be displayed for the date passed in.
- Fixed an issue where booking tooltips are not displayed on hover, when network latency is high.  
- Fixed a null reference exception for booking status metadata checks during the upgrade to improve upgrade experience.

## 3.12.5.13

- resource location can be displayed on the map view of the schedule board's daily view, using the custom entity using the custom geo data settings in the scheduling parameters.
- Fixed the issue with the action msdyn_SearchResourceAvailability was not taking the ConsiderTravelTime parameter into consideration when providing the available time slots.
- Fixed upgrade errors while generating the booking setup metadata records and a few other upgrade improvements.
- Fixed the issue where filters were not saved on the resource utilization view.
- **Booking created Successfully** notification on the schedule assistant is only shown when the booking is created successfully.
- Fixed the incorrect booking time offset on daylight savings time dates for GMT + 1 timezone on the booking and resource requirement forms.
- Fixed null reference issues on the requirement group form.
- Improved error handling on the copy function of the resource requirement form.
- Resource name handling is improved in the search resources lookup on the days view of the schedule board.
- Resource and grid alignment issues are fixed in the hourly view of the schedule board.
- Calendar performance improvements are made for the generation of resource requirements from the project form.
- Improved error handling on the booking rules.
- Schedule board scrolling issues are fixed, when moving the bookings of the resources at the bottom of the list.
- Fixed the issue with the booking tooltip: when there are only two resources displayed on the schedule board, the tooltip masks the booking itself.
- Fixed the issue of the visual duplication of the bookings on the days, weeks, and months views of the schedule board.
- Improved error handling when creating bookings on the schedule board, by adding additional null checks.
- Performance on the schedule board improved by just loading the requirements that are not location agnostic on the map view.
- Fixed the filter panel crash when using the fetch-based filter value and saved as default value.
- Fixed the issue with the schedule assistant filter layout when a filter is changed from multi combo field to non-multi combo filter.
- When **Double book if needed** option is checked on the schedule assistant booking panel, even though the resource does not have enough availability for the requested hours, the resource can be double booked up to 24 hours in one day.

## 3.12.9.76 - April 2020 Wave 1 Early Access

- Fixed a performance issue when upgrading from Field Service version 7.x to version 8.x.  
- Fixed an issue with printing the get driving directions action on the schedule board.  
- When quick scheduling is used to schedule an entity that doesn't have an associated resource requirement, results were always shown in UTC timezone, which is now fixed. The results should always be shown in the user's timezone if there is no requirement calendar.
- Tooltips are now supported on the sort options of the schedule board.  
- A new warning message is now introduced on editing the schedule board settings records: "Modifying these settings has the potential to break the corresponding schedule board tab in a way that cannot be automatically undone".
- Fixed the bug with displaying the resource details in the list view of the schedule board.  
- A new warning message is now supported that the minimum duration needed to create a bookable resource booking is 1 minute.
- The field **Status** is now renamed to **requirement Status** on the requirement status entity.
- Fixed the bug where schedule board crashes when a user record is deleted from the Azure Active Directory, which has an associated bookable resource on the schedule board tab.  
- A select all check box is now supported on the select resources pop-up window on the filter panel sort options.  
- Min rating value now must be less than the max rating value on the rating model entity form.  
- When quick scheduling is enabled on a schedulable entity, the retrieve resources and retrieve constraints queries of the underlying BSM record are called instead of the default queries.  
- Quick scheduling supports the requirement groups with one requirement that has work location type as facility.
- The all/any option labels of the requirement group are now fixed in Danish language.
- Auto apply territory filter field in scheduling parameters form is now deprecated and hidden.  
- Start and end date time fields on the business closures entity form and the grid view are displayed in the same time zones.  
- When a work hours template is applied on multiple resources, a spinner is now added while the work hours are being applied.  
- The from and to date fields on the requirement group form now reflect the timezone from the user's preferences.  
- Details tab on the fulfillment preferences entity form will now only be displayed once.  
- Added a warning on the set work hours template pop-up dialog, that "Applying this work template will overwrite the existing work hours, including time-off".  
- When the map panel on the schedule board is loaded, the map should be zoomed enough to show all the map pins in the requirement map filter view definition.  
- XML syntax validation is now added on editing the schedule assistant filter layout.  

## 3.12.4.9

- Fixed an upgrade issue related to the timezone conversion of the TimeGroupDetail record.  
- Fixed incorrect booking time offset on daylight savings time dates for Auckland timezone.  
- Fixed the issue where some resources show unavailable on the schedule board, due to the number of calendar rules on all the resources on the schedule board.  
- When there are characteristics on the filter panel that are paged, the rating value of the selected characteristic is lost in the filter, which is now fixed.  
- Fixed the flickering issue on the second page of the open requirements tab of the requirement panel.  
- Fixed the alignment of the available time on the days view of the schedule assistant.  
- The filters on the filter panel now support text fields.  

## 3.12.3.9

- The one hour offset issue for the bookings created on the schedule board is fixed in the Brazil daylight savings time.
- The caching issue with the schedule assistant's default availability view setting is set to board is now fixed.
- When a new booking is created on the days view of the schedule board, the board will be refreshed automatically.
- resource requirement map pins are loaded, only when the map view is opened on the filter panel of the schedule board.
- Fixed an upgrade issue due to bad data in the filter values.

## 3.12.2.114

- When the schedule board map view is opened, the map automatically zooms out to show all the map pins.
- The resource lookup is displayed on the schedule board in Arabic.
- On the schedule assistant results list view, work start time aligns with the estimated arrival time values on the create resource booking pane.
- Added additional handling to avoid the corruption of the booking setup metadata and the schedule board settings records.
- Bookings can be edited in the days view of the schedule board by right-clicking on the booking and selecting **Edit**.
- The select resources dialog opens and loads successfully on the filter view of the schedule board, even when there are more than 100 resources enabled to be displayed on the schedule board.  
- When Turkish language is enabled on the org, resource requirement records load under the **Unscheduled Work orders** tab of the requirement pane of the schedule board.
- When double-clicking on the save button the new bookable resource booking form, would not create duplicate records.
- Resources can be searched on the schedule board by their name in the search resources search box.
- map view on the schedule board only shows the pins for the requirements that are returned from the requirement view configured for requirement map filer view setting on the map settings of the schedule board tab settings.
- When Hebrew language is enabled on the org, schedule board loads in the Chrome with browser zoom at 90%.
- The requirement demand pie chart on the schedule assistant information at the bottom is accessible, via screen readers.

## 3.12.1.158

- Workflows can be triggered when resource requirements are created with any allocation method.
- When upgrading URS from version 2.x to version 3.x, resource filters on the schedule board tabs are preserved.

## 3.12.0.448

- Grid alignment issues while scrolling on the schedule board for right-to-left languages (like Hebrew, Arabic) are fixed.
- When a new route is created for a map pin selected on the map panel, the route will stay on top of other routes, even after the auto refresh, which happens when a booking is created or modified.
- On the list view of the schedule board, any linked entity record can be opened by using keyboard, by hitting on the space bar when focused on the linked entity.
- The warning message notification on the schedule assistant is made user-friendly, when Maps are not enabled for a resource requirement when work location is onsite.
- The selected values of the filter "pool type" are also saved along with other filters, when the current filters are saved as default filters.
- When a crew type resource is booked, only the working members of the crew will be booked, crew members, who are not working, will not get booked.
- Custom date fields added to the filter panel as custom filters, will also respect the time zone of the schedule board tab (under Scheduler settings)
- When schedule board settings are opened from the booking setup metadata record of the Schedulable entity, by clicking the Cancel button on the schedule board settings, the form will be closed.
- The scrolling issues on the vertical view of the schedule assistant are fixed.
- On the list view type of days, weeks, and month views of schedule board, the focus will stay on the resource Search box until the typing is complete until focus is moved to a different area of the schedule board.
- The quick scheduling experience will search for available resources in the date range provided in the requirement group and displays available resources on the book resources panel in the date range.
- On successful creation of bookable resource booking record in the offline mode, no unintended warnings will be displayed on the form.
- When looking for a substitute resource on a booking using the "Find Substitution" via schedule assistant, the resource can be substituted on the suggested time slot by clicking on the "Substitute" button, when hovered on the suggested time slot.
- When there are more than 30 suggested resources on the schedule assistant, there will be paging of resources and more suggested resources can be reached by scrolling to the next page.
- When a map pin is selected for a booking on the schedule board, after editing the selected booking, (by dragging and extending the booking), the map pin stays selected.
- Schedule board will support booking alerts are in large number (~200).
- Only active booking statuses will be displayed on the booking status dropdown field on the booking panel of schedule board, when creating bookings.
- When searching for available resources for a requirement group, suggested resources will always be shown in list view only.
- Resources on the schedule board tab can be selected via Select resources under the filter Options on the Internet Explorer Version 11.
- When calling the msdyn_SearchResourceAvailability action using a requirement with a fulfillment preference for time group as input, the output time slot of the action will contain valid TimeGroupDetails.
- Bookable resource bookings can be created on the daylight saving days (entering and exiting daylight savings time).

### Enhancements

- Accessibility improvements are made on the schedule board and schedule assistant.

## 3.11.0.421

- Columns in the list view of the schedule board resize based on the size of the browser (Internet Explorer)
- A few accessibility issues on the schedule board and quick scheduling panel are fixed.
- Days/weeks/month views on the schedule board support the bookings for the schedulable entities without resource requirements.
- When viewing the bookings of requirement group in Split view, the bookings in the Split view will be shown in the same timeline as of the requirement group bookings in the top half of the grid.
- work hours of a resource with capacity greater than 1 in a day, will reflect on the schedule board accordingly.
- Resource capacity booked percentage reflects the resource's bookings in the days, weeks, and month views of the schedule assistant.
- The focus remains on the selected date when a resource is selected from the resource dropdown filter after selecting a date on the calendar of the quick scheduling panel.
- When a resource requirement with a characteristic and rating is booked, the characteristic filter will be populated with the characteristic and rating value from the resource requirement in the filter view of the schedule assistant.
- The search start/search end and time from promised/time to promised date time filters on the filter view of the schedule assistant reflect the from date/to date and time from promised/time to promised from the resource requirement records.
- The membership of the members of a crew type resource on the schedule board is shown in the timezone of the schedule board.
- Only one resource can be selected from the recommended resources on the list view of the schedule assistant.
- When searching for available resources for an onsite requirement group, and a suggested time slot is selected, the estimated arrival time and start fields in the create resource booking panel are filled with the start time and travel start time values from the list view.
- When hovered on the bookings on the schedule board, booking card is displayed with a delay.
- A booking can be created for a work order in the days, weeks, or month views of the schedule assistant.
- Schedule board loads bookings of resources, even with resources who have no calendar or have multiple calendars.
- Rebook for bookings would work even with null values of the filters passed to the schedule assistant.
- The schedule board and schedule assistant will load booking and resource availability on the Internet Explorer Version 11.

### Enhancements

- Support for preferred and mandatory resource in finding available resources.
- Usability improvements to the facility search scenarios via quick scheduling experience.

## 3.10.0.239

- Only valid hex characters can be entered on the status color field on booking status form.
- The overlapping bookings in the vertical view of the schedule board are separated by 1 px spacing.
- Non-working hours color name is consistent across the schedule board tab settings and the schedule board settings configuration record.
- Long names will be wrapped inside the booking tooltip.
- Deletion of a resource is not allowed if it has any group memberships active or inactive, parent, or child, has any associations active or inactive, resource 1 or resource 2.
- When default sorting is added to the schedule assistant retrieve constraints UFX query in the default schedule board settings, the sort by filter of the schedule assistant is pre-filled with the field by which sorting is done and the returned resources are sorted accordingly.
- A few accessibility issues on the schedule board are fixed.
- Schedule board to load the resources in days, weeks, and month views with resources having a valid calendar and wouldn't fatally fail if a resource has an invalid calendar.
- Combo control filter with multiset to false, the selected value will show in the filter.
- Active resource requirements view is sorted on created on by descending order.
- Derive capacity from group members field on the pool resource form can be set to yes or no as required.
- Search resources can be used to search resources in the suggested resources in the list view of the schedule assistant.
- Custom booking template with fields from linked entities of bookings is supported.
- Resource type filter on the schedule assistant will not remember the previously selected values, once unselected.
- The schedule assistant loads as expected when clicked on book button on a work order form in Arabic.
- When a booking is created by schedule assistant, the booking method field on the booking form is populated as schedule assistant.

## 3.9.0.42

- The filter is not enabled for the owner column on the unscheduled work orders requirements view in the requirement grid of the schedule board.
- The refresh button on the requirement grid is disabled while the grid is refreshing the data.
- Alignment for resource icons and the zoom slider on the schedule board are fixed for Arabic language.
- When searching for resources in one view like horizontal, when switched to another view, like list view, the search is still retained along with the search text and results.
- The bookings can be moved to a different time or resource by dragging and dropping the booking on days, weeks, and month views of the schedule board.
- Quick scheduling would be using the "As The Crow Flies" approximations to calculate travel time if Bing maps integration is not enabled.
- Improved error messaging on the schedule assistant when looking for available resources and on the schedule board when displaying the bookings.
- When auto update booking travel is enabled, and onsite bookings are created by the quick scheduling, the travel time to the subsequent bookings is updated based on the location of the previous booking.
- The schedule assistant search for available resources will be successful with continuous multiple associations on a single day for a resource type facility.
- When an onsite requirement is selected in the requirement grid, the location pin is selected and focused in the map view. Once clicked on "Find Availability," the location pin on the map view will stay selected entering and exiting the schedule assistant.
- Alignment of the fields on the fulfillment preferences form is fixed.
- Alignment of the sort arrows on the sort options control on the schedule board is fixed.
- Time out issues request to msdyn_RetrieveResourceAvailability is posted from a web app are fixed.

### Enhancements

- FetchXML query is replaced by query expression for the action that fetches work order bookings to improve the performance.

## 3.8.0.105

- The date selector on the schedule assistant list view is dimmed because it has no effect on the resources displayed when searching for availability of a requirement or a work order.
- When booking a schedulable entity record, only the booking status that is mapped to the booking status field logical name of the booking setup metadata record of the schedulable entity will be on the schedule assistant. For example, when scheduling a work order, only the option set values of the field msdyn_fieldservicestatus will be displayed in the booking status drop-down on the schedule assistant,
- When searching for availability of resources on a requirement, the number of matching resources returned in the search on the schedule assistant is limited to the value set on the field resource availability retrieval limit on the default metadata settings of the booking setup metadata record. The default value of resource availability retrieval limit is 100.
- Only one booking setup metadata for an entity can be created.
- For German locale, on the schedule assistant, remaining duration does not overlap with the pie chart visual next to it.
- Only Active resources can be added to a resource pool or resource crew's children.
- A few accessibility issues on the schedule board are fixed.
- The resource requirement form can be customized to remove optional fields like resource type from the form.
- Selected sort on the schedule board is determined by the Sort result by filter on filters.
- The booking alerts template field on the default schedule board settings shows the default HTML template value.
- **Book** and **Book & Exit** buttons on the schedule assistant are enabled only when at least one eligible resource is returned on the schedule assistant.
- Multiple characteristics can be selected on the filters on the schedule board.
- A booking cannot be deleted when it has an associated booking alert.
- When booking a requirement in the weekly view or monthly view of the schedule assistant, if the availability search start date is today and is not the first day of the week or month, the start date will correctly default to today, so that the book button is enabled.
- The work location filter on the schedule assistant will show all three possible values: onsite, facility, and location agnostic.
- The filters on the schedule board will show the right values in the drop-down even when the user manually types in the filter.
- When Auto Update booking travel is enabled in the scheduling parameters, travel time of the adjacent bookings is updated when a booking is created in the list view of the schedule assistant.
- Correct search results are displayed on the quick scheduling panel for all timezone values set on the resource requirement form.
- A multi resource work order, that is, a work order associated with a requirement group, can be booked via quick scheduling.
- Requirement group bookings can be viewed in split view.
- The Timeline header on the schedule board will be shown even after exiting the schedule assistant by selecting exit search.
- The rating values on the rating model form are ordered by rating values, not the names.
- The resource card can be opened by right-clicking the resource, even when the resource has characteristics with no rating values.
- When booking a requirement group via the schedule assistant, selecting a time slot on the list view opens up the Create resource booking Panel on all browsers.
- When booking a requirement group or the requirements under that requirement group, the same results are displayed on the schedule assistant.
- Facility requirements can be booked via quick scheduling with the correct duration of the booking.
- You can book work orders on the days view of the schedule assistant.
- Multiple issues preventing upgrade.

### Enhancements

- Performance improvements to schedule board refresh times when multiple crew type resources are present on the schedule board.
- Performance improvements to searching for resource availability for requirement Groups.
- Reduced unnecessary calls to retrieve the resource requirements name and booking setup metadata. Other duplicated calls are also reduced when searching for availability.
- Self-service scheduling API is now available to schedule the single resource requirement, with a corrected process name **Resource Scheduling – Search Resource Availability** and unique name msdyn_searchresourceavailability.
- From and to date fields on the resource requirement entity are restricted to have only the User Local behavior to avoid Time Zone functionality loss on the schedule assistant and loss of the time zone data on resource requirements.
- Added a suggestion to service health diagnostics to show the suggestion/fix with manual steps when resource booking sync job is disabled but the feature synchronize resource bookings with outlook is enabled.
- When using URS on Unified Service Desk, the schedule board can be loaded without having to pass the full Unified Interface context.
- Quick scheduling now supports scheduling of onsite requirements.

## 3.7.0.70

- Requirement group control loads in the service form on the customer service scheduling app.
- When a schedulable entity without a resource requirement is booked via the schedule assistant (pop-out schedule board) days, weeks, or months views, the booking status is populated to the default status.
- The resource routes are optimized by listing using the schedule board driving directions in the sort order of a booking's start time.
- Optimized rebooking in the schedule board by fixing a client-side console error.
- Map view icon is no longer displayed in the schedule assistant view.
- Changes on the default schedule board settings form are saved when accessed from booking setup metadata record.
- Drag and drop the bookings from one resource to another or from one time to another of the same resource in days, weeks, or months views.
- Resource names with apostrophes, like O'Brien, can be searched on the schedule board resources.
- Booking a resource requirement for the facility resource type now populates the resource filter field as a facility in the schedule assistant (pop-out schedule board).
- Book based on setting for the schedule board shows how the time slot suggestions are displayed in the Hourly view of the schedule assistant, and more details on how to use book based on are included.
- Duration filter on the schedule assistant for Hebrew is fixed when the value of the duration is 1.
- Travel start time on the schedule assistant list view shows as travel time subtracted from the work start time.
- Drag and drop multiple open requirements to an expanded resource in days, weeks, or months view to create multiple bookings.
- Rendering of the resources on the schedule board is improved.
- View resource cards in the schedule assistant for requirement groups availability.
- Schedule assistant minimizes the number of resources necessary to fulfill a requirement group when the Sort result by field is set to Fewest resources first.
- Multiple issues preventing upgrade.
- Drag resource route on the map to a requirement pin to create a booking for the resource.
- The Select resources filter can be used to select the resources to be displayed on the schedule board.
- Only active members of the crew with valid crew membership will be booked when a crew is booked.
- Driving directions and the map view on the schedule board have the same traffic icon.
- The position of the hover book button on the suggested time slots is adjusted when the preceding booking is extended beyond the suggested time slot.
- When a requirement is selected and the requirements panel is refreshed, the requirement selection persists.

### Enhancements

- Made improvements to uptake new endpoint Bing distance matrix APIs.
- Self-service scheduling API is now available to schedule the single resource requirement.
- The work location for new requirements added to a requirement group is now inherited from the work location of the existing requirements in the requirement group, and is kept in sync.
- The calendars of the requirements of a requirement group are kept in sync and share the same calendar. Changing a calendar or time zone for one requirement updates it for all the requirements of the requirement group.
- When booking a requirement group, the schedule assistant is launched in the time zone of the requirement group's requirements because they all share the same requirement.
- Performance improvements to searching for resource availability, viewing bookings on the schedule board, creating bookings for crews, creating bookings in the hourly views of the schedule board, and when using other URS plug-ins.

## 3.6.0.18

- On the schedule assistant, the radius unit behavior reflects kilometers or miles as per the preferred unit of distance when "Search for" field is changed.  
- The zoom level on the "Map View" on the "Filter Panel" will be preserved after entering or exiting the Schedule assistant search. 
- Only activated members of a crew get booked when a crew is booked.
- On the schedule board setting for schedule assistant, the unavailable resources field can be changed from "Unavailable resources do not appear" to "Unavailable resources appear dimmed" to show the unavailable resources on the schedule assistant.
- Alignment of scheduler settings controls.  
- On a schedule assistant search for available resources on a location agnostic resource requirement, the "Time From Promised" and "Time to Promised" time window precedes over the "Search Start" and "Search End" time window, and the recommendations will be presented to make sure the technician can start work in the "Time From Promised" and "Time To Promised" window.
- Onsite multi-resource requirements will be presented with travel time in the schedule assistant recommendations.
- The filter panel's characteristic field on the schedule assistant is populated with the characteristic from the resource requirement or work order.
- Multiple issues preventing upgrade.
- Resource utilization of a resource on non-working day, along with the color code of the non-working day.
- Dragging the technician travel route to a requirement pin to schedule the booking in the maps view on the filter panel of schedule board.
- The schedule board setting "Order Number" default maximum value is increased to 1000 from 100.
- Duration field value text in Hebrew on schedule assistant.

### Enhancements

- When inserting a booking between two bookings or reassigning a booking to another resource, the travel time of all associated bookings will be recalculated and updated on hourly schedule board and schedule assistant. This feature can be enabled by "Auto Update booking travel" field under **Resource Scheduling** > **Settings** > **Administration** > **Scheduling Parameters**.
- When the **Book** button is used on the resource requirement and the timezone on the pop-out schedule board is updated, the date time fields on the bottom requirement info panel will reflect the changed timezone.
- All the date and times in the filter panel and requirements panel on the schedule board are updated when the time zone is changed in the scheduler settings on the schedule board.
- Various performance improvements when searching for resource availability.

## 3.5.0.107

- Booking status on the create resource booking panel is always defaulted to either front load or the last used value on the schedule board.
- On the schedule assistant, a new booking can be created in custom time, by clicking and dragging in the demand panel, which opens the create resource booking panel for confirmation of booking details.
- A resource requirement record can be created by quick create forms on the schedule board, even there are no resources on the schedule board tab are working.
- When the start and end locations of the bookable resource are set to organizational unit address, the organizational unit field becomes mandatory field.
- The row height and column width slider tooltip value is now localized.
- The location of the tooltip, when dragging and dropping an existing booking on the board is corrected in the Hebrew language orgs.
- Slider controls on the scheduler settings of the schedule board are aligned in the orgs with right-to-left languages.
- Error handling improvements on the schedule board.
- Resource requirement details associated view of resource requirements includes additional details like duration, from and to fields.
- The skills subgrid in the resource requirement form will only show relevant data and hide the redundant data like the resource requirement name field.
- On the schedule board, bookings can be created with the start/end dates in the past.
- Contains solution upgrade improvements.
- Select resources dialog opens for selection of resources to be shown under the schedule board tab
- The working time of the schedule board tab can be configured by using the start time and end time slider controls under the scheduler settings of the schedule board tab.
- Duplicate booking creation on the schedule board, due to network race conditions is now fixed.
- The availability cells in the days view of the schedule board are appropriately aligned on the daylight savings days at 12:00 AM.
- The duration of the bookings on the multi-day views of the schedule board can be decreased by dragging the right end of the booking to left or left end of the booking to right.
- The pre-filled characteristic-Rating value in the filter view, can be selected to view it the filter view.
- Booking rules dialog respects the cancel button and wouldn't create a booking.
- When looking for available resources using a resource requirement for resource type facility, in the list view of the schedule assistant, organizational unit column shows the appropriate string values.
- When clicked on maintain bookings for a team member, opens up the schedule board with the project bookings for the selected team member.
- Book button is displayed on the resource requirement form for the users only with appropriate read/write privileges to the entity.
- Resource requirement for facility type pool can be searched for available resources using the schedule assistant or find availability.

### Enhancements

- Improvements are made to the date time controls by leveraging the Office fabric UI control on the resource requirement, fulfillment preferences, and time group detail forms.
- Scheduling Health Diagnostics provides capabilities to detect and suggest self-healing options with regards to:
  - Unsupported customizations on internal use only web resources.
  - Actions and workflows that are in draft state.
  - Essential SDK message processing rules that are in disabled state.
  - Missing metadata records such as booking setup metadata records, default UFX query values.
- Improvements are made to the icons on the booking right-click menu.
- If **Connect to Maps** is disabled, the travel times will be calculated based on the "Crow fly" approximations.
- Performance improvements for the retrieve resource availability action calls on the multi-resource requirements with fulfillment preferences (intervals).

## 3.4.0.141

- Custom date and time fields now display properly on schedule board panels.
- Issues opening and saving schedule board resource picker under options in filter control.
- Paging issues when using schedule board resource picker under options in the filter panel.
- When "Time From Promised" on the requirement is in the past and you search for availability, the value is now moved to the current time and the search button is enabled.
- Changing the schedule board working time no longer immediately closes the settings dropdown.
- Book button now appears on views and forms when using USD.
- Resources associated to a facility with a parent Organization Unit that is different from the associated facility correctly use facility organizational unit when it comes to schedule assistant facility search.
- Miles/kilometers default properly from scheduling parameters entity.
- Generic resource type is removed from resource picker under the select resources dialog.
- Auto focus on characteristic rating value in filter control when entering schedule assistant on certain devices.
- Overbooked requirements no longer show a negative duration in booking panel when in schedule assistant
- Facility searched properly group results by organizational unit, regardless of the value in the "part of same" field on the requirement group control.
- Resources that are location agnostic, yet are associated to a facility, will return in facility searches for the time they are associated to the facility.
- Issue selecting pool type on schedule board filter panel while using Firefox browser.
- Selecting cells in daily, weekly, and monthly boards while in schedule assistant now pass information to the booking panel properly.
- Schedule boards that have characteristics with rating values saved no longer prompt user to enter a rating value.
- Issue on certain devices where current timeline bar on schedule board wasn't showing correct time.
- Work location on booking is now set properly when using drag and drop on schedule board.
- Misaligned labels for languages that read right to left.
- Issue loading schedule board in Internet Explorer 11.
- Issue creating schedule alerts from certain places.

### Enhancements

- Various performance improvements when creating bookings.
- Dragging to extend a booking on multi-day schedule boards opens booking panel instead of booking dialog.

## 3.2.0.405

- If a booking has the work location field set to location agnostic, the booking will be treated as location agnostic even if there is a latitude and longitude value on the booking.
- Issue with schedule board list view refreshing when changing between hourly and daily.
- When searching for a resource in the resource search bar on the schedule board list view, if no resources can be found, the board properly removes all resources.
- Issue dragging a requirement from the map to the schedule board while using Firefox browser.
- Changing "derive capacity" field on a pool resource from no to yes now triggers the calendar to be calculated based on the child resources of the pool.
- Issues when changing between horizontal and vertical schedule board while in split view.
- Issue loading schedule board with many explicitly saved resources.
- Resource's location is now properly taken from the facility it is associated to.
- When using a language that reads from right to left, the resource name is now properly rendered on the schedule board.
- When launching the schedule assistant from a schedulable entity, the user now lands back on the same form after clicking book and exit.
- Schedule board no longer shows resource with a capacity greater than 1 as available all day.
- When booking a requirement group using the schedule assistant, the booking status dropdown now properly filters to the booking statuses for that schedulable entity.
- Issues loading requirement group control in the Microsoft Edge browser.
- When using the schedule assistant to schedule a requirement group for a facility, there is no longer a travel time conflict between the facility and the resources.
- Double booking option in schedule assistant on daily, weekly, and monthly boards now properly books the resource even if the resource has no remaining capacity.
- Appointment schedule board settings are now generated properly.
- Issues in certain scenarios where schedule board had issues loading in Internet Explorer.
- "Supplied DateTime represents an invalid time" error.
- Error message when scheduling a single requirement to a crew resource.

### Enhancements

- Resources associated to facilities will no longer return in onsite schedule assistant searches. This prevents customers from accidentally scheduling a resource that should be stationed at a facility from going to a customer location.
- Resources that are not associated or related to a facility will no longer return in facility searches. Currently, when a resource is set up to work at a facility through an association or as a child resource of a pool, URS does not account for travel to the facility.
- When using the schedule assistant to schedule a requirement group, if the requirement's work location is set to facility, and there are no options selected under the "part of same" attribute, the search will execute as if part of same "resource Tree" is selected.
- Saving a filter on the schedule board now shows a green confirmation check mark instead of a yellow warning symbol.
- Warning message will now be displayed when trying to change the latitude or longitude field on a booking.
- Added validation to check that if a resource is associated to a facility, then it should not be allowed to be a child resource of a pool associated to a facility or facility pool for the same time frame.

## 3.1.0.166

- If a booking has the work location field set to location agnostic, the booking will be treated as location agnostic even if there is a latitude and longitude value on the booking.
- Issue with schedule board list view refreshing when changing between hourly and daily.
- When searching for a resource in the resource search bar on the schedule board list view, if no resources can be found, the board properly removes all resources.
- Issue dragging a requirement from the map to the schedule board while using Firefox browser.
- Changing "derive capacity" field on a pool resource from no to yes now triggers the calendar to be calculated based on the child resources of the pool.
- Issues when changing between horizontal and vertical schedule board while in split view.
- Issue loading schedule board with many explicitly saved resources.
- resources location is now properly taken from the facility it is associated to.
- When using a language that reads from right to left, the resource name is now properly rendered on the schedule board.
- When launching the schedule assistant from a schedulable entity, the user now lands back on the same form after clicking book and exit.
- Schedule board no longer shows resource with a capacity greater than 1 as available all day.
- When booking a requirement group using the schedule assistant, the booking status dropdown now properly filters to the booking statuses for that schedulable entity.
- Issues loading requirement group control in the Microsoft Edge browser
- When using the schedule assistant to schedule a requirement group for a facility, there is no longer a conflict of travel time between the facility and the resources.
- Double booking option in schedule assistant on daily, weekly, and monthly boards now properly books the resource even if the resource does not have any remaining capacity.
- Appointment schedule board settings are now generated properly.
- Issues in certain scenarios where schedule board had issues loading in Internet Explorer.
- "Supplied DateTime represents an invalid time" error.
- Error message when schedule a single requirement to a crew resource.

### Enhancements

- Resources associated to facilities will no longer return in onsite schedule assistant searches. This prevents customers from accidentally scheduling a resource that should be stationed at a facility from going to a customer location.
- Resources that are not associated or related to a facility will no longer return in facility searches. Currently, when a resource is set up to work at a facility through an association or as a child resource of a pool, URS does not account for travel to the facility. Therefore, only resources set to work at a facility will return in facility searches.
- When using the schedule assistant to schedule a requirement group, if the requirement's work location is set to facility, and there are no options selected under "part of same" attribute, the search will execute as if part of same "Resource Tree" is selected.
- Saving a filter on the schedule board now shows a green confirmation check mark instead of a yellow warning symbol.
- Warning message will now be displayed to a user if they try to change the latitude or longitude field on a booking.
- Added validation to check if a resource is associated to a facility then it should not be allowed to be a child resource of a pool that is associated to a facility or facility pool for the same time frame.

## 2.4.11.59

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/14/enhancements-and-bug-fixes-in-universal-resource-scheduling-urs-version-2-4-11-59/).

## 2.4.10.56

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/release-notes-for-universal-resource-scheduling-version-2-4-10-56/).

## 2.1

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2017/05/19/universal-resource-scheduling-solution-for-dynamics-365-update-6-1/).
