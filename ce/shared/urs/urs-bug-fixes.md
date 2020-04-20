## 3.12.5.13
- Resource location can be displayed on the Map view of the Schedule Board’s Daily view, using the custom entity using the Custom Geo Data settings in the Scheduling Parameters. 
- Fixed the issue with the action msdyn_SearchResourceAvailability was not taking the ConsiderTravelTime parameter into consideration, while providing the available timeslots.
- Fixed upgrade errors while generating the Booking Setup Metadata records and a few other upgrade improvements. 
- Fixed the issue where Filters were not saved on the Resource Utilization View. 
- **Booking created Successfully** notification on the Schedule Assistant is only shown when the booking is created successfully. 
- Fixed the incorrect booking time offset on DST dates for GMT + 1 timezone on the Booking and Resource Requirement forms. 
- Fixed null reference issues on the Requirement Group form. 
- Improved error handling on the Copy function of the Resource Requirement form. 
- Resource name handling is improved in the Search Resources lookup on the Days view of the Schedule Board. 
-  Resource and Grid alignment issues are fixed in the Hourly view of the Schedule Board. 
- Calendar performance improvements are made for the generation of Resource Requirements from the Project form. 
- Improved error handling on the Booking rules. 
-  Schedule board scrolling issues are fixed, when moving the Bookings of the Resources at the bottom of the list. 
- Fixed the issue with the Booking tooltip, when there are only two resources displayed on the Schedule Board, the tooltip is masking the Booking itself. 
- Fixed the issue of the visual duplication of the Bookings on the Days, Weeks, and Months views of the Schedule Board. 
- Improved error handling when creating bookings on the Schedule Board, by adding additional null checks. 
- Performance on the Schedule Board improved by just loading the Requirements that are not Location agnostic on the Map view. 
- Fixed the Filter panel crash when using the Fetch-based filter value and saved as default value. 
- Fixed the issue with the Schedule Assistant Filter layout when a filter is changed from multi combo field to non-multi combo filter. 
- When **Double book if needed** option is checked on the Schedule Assistant booking panel, even though the resource does not have enough availability for the requested hours, the resource can be double booked up to 24 hours in one day. 

## 3.12.9.76 - April 2020 Wave 1 Early Access 

- Fixed a performance issue when upgrading from Field Service version 7.x to version 8.x.  
- Fixed an issue with printing the Get Driving Directions action on the Schedule Board.  
- When Quick Scheduling is used to schedule on an entity that doesn’t have an associated Resource Requirement, results were always shown in UTC Timezone, which is now fixed and the results should always be shown in User Timezone if there is no Requirement calendar. 
- Tooltips are now supported on the Sort options of the Schedule Board.  
- A new warning message is now introduced on editing the Schedule Board Settings records, “Modifying these settings has the potential to break the corresponding Schedule Board tab in a way that cannot be automatically undone”. 
- Fixed the bug with displaying the Resource details in the List view of the Schedule Board.  
- A new warning message is now supported that the minimum duration needed to create a Bookable Resource Booking is 1 minute. 
- The field Status is now renamed to Requirement Status on the Requirement Status entity. 
- Fixed the bug where Schedule Board crashes, when a User record is deleted from the Azure Active Directory, which has an associated Bookable Resource on the Schedule Board tab.  
- A Select All check box is now supported on the Select Resources pop-up window on the Filter panel Sort Options.  
- Min Rating value now must be less than the Max Rating value on the Rating Model entity form.  
- When Quick scheduling is enabled on a Schedulable entity, the Retrieve Resources and Retrieve Constraints queries of the underlying BSM record are called instead of the default queries.  
- Quick Scheduling supports the Requirement Groups with one requirement that has Work location type as Facility 
- The All/Any option labels of the Requirement Group are now fixed in Danish language. 
- Auto Apply Territory Filter field in Scheduling Parameters Form is now deprecated and is hidden.  
- Start and End Date time fields on the Business Closures entity form and the grid view are displayed in the same time zones.  
- When a work hours template is applied on multiple Resources, a spinner is now added while the work hours are being applied.  
- The From and To Date fields on the Requirement Group form now reflect the Timezone from the User preferences.  
- Details tab on the Fulfillment Preferences entity form will now only be displayed once.  
- Added a warning on the Set Work hours template pop-up dialog, that “Applying this work template will overwrite the existing work hours, including time-off”.  
- When the Map panel on the Schedule Board is loaded, the map should be zoomed enough to show all the Map pins in the Requirement Map filter view definition.  
- XML syntax validation is now added on editing the Schedule Assistant filter layout.  

## 3.12.4.9

- Fixed an upgrade issue related to the Timezone conversion of the TimeGroupDetail record.  
- Fixed incorrect booking time offset on DST dates for Auckland Timezone.  
- Fixed the issue where some resources show unavailable on the Schedule Board, due to the number of calendar rules on all the Resources on the Schedule Board.  
- When there are characteristics on the filter panel are paged, the rating value of the selected characteristic is lost in the filter, which is now fixed.  
- Fixed the flickering issue on the second page of the Open Requirements tab of the Requirement panel.  
- Fixed the alignment of the available time on the Days view of the Schedule Assistant.  
- The Filters on the filter panel now support the Text fields as well.  

## 3.12.3.9

- The one hour offset issue for the bookings created on the schedule board is fixed in the Brazil daylight savings time.
- The caching issue with the schedule assistant’s default availability view setting is set to Board is now fixed.
- When a new booking is created on the days view of the schedule board, the board will be refreshed automatically.
- Resource requirement map pins are loaded, only when the map view is opened on the filter panel of the schedule board. 
- Fixed an upgrade issue due to bad data in the filter values. 

## 3.12.2.114

- When the schedule board map view is opened, the map automatically zooms out to show all the map pins. 
- The resource lookup is displayed on the schedule board in Arabic.
- On the schedule assistant results list view, work start time aligns with the estimated arrival time values on the create resource booking pane. 
- Added additional handling to avoid the corruption of the booking setup metadata and the schedule board settings records. 
- Bookings can be edited in the days view of the schedule board by right-clicking on the booking and selecting **Edit**.
- The select resources dialog opens and loads successfully on the filter view of the schedule board, even when there are more than 100 resources enabled to be displayed on the schedule board.  
- When Turkish language is enabled on the org, resource requirement records load under the **Unscheduled Workorders** tab of the requirement pane of the schedule board. 
- When double-clicking on the save button the new bookable resource booking form, would not create duplicate records. 
- Resources can be searched on the schedule board by their name in the search resources search box. 
- Map view on the schedule board only shows the pins for the requirements that are returned from the requirement view configured for requirement map filer view setting on the map settings of the schedule board tab settings. 
- When Hebrew language is enabled on the org, schedule board loads in the Chrome with browser zoom at 90%. 
- The requirement demand pie chart on the schedule assistant information at the bottom is accessible, via screen readers. 

## 3.12.1.158

- Workflows can be triggered when resource requirements are created with any allocation method.
- When upgrading URS from version 2.x to version 3.x, resource filters on the schedule board tabs are preserved. 

## 3.12.0.448

- Grid alignment issues while scrolling on the Schedule Board for Right to Left languages (like Hebrew, Arabic) are fixed. 
- When a new route is created for a Map pin selected on the Map panel, the route will stay on top of other routes, even after the auto refresh, which happens when a booking is created or modified.
- On the List View of the Schedule Board, any linked entity record can be opened by using Keyboard, by hitting on the Spacebar when focused on the linked entity. 
- The warning message notification on the Schedule Assistant is made user-friendly, when Maps are not enabled for a Resource Requirement when work location is Onsite. 
- The Selected values of the Filter ‘Pool Type’ are also saved along with other filters, when the current filters are saved as default filters.
- When a Crew type Resource is booked, only the working members of the Crew will be booked, Crew members, who are not working, will not get booked. 
- Custom Date fields added to the Filter panel as custom filters, will also respect the Timezone of the Schedule Board tab (under Scheduler settings)
- When Schedule Board Settings are opened from the Booking Setup Metadata record of the Schedulable entity, by clicking the Cancel button on the Schedule Board Settings, the form will be closed. 
- The scrolling issues on the vertical view of the Schedule Assistant are fixed. 
- On the list view type of Days, Weeks, and Months views of Schedule Board, the focus will stay on the Resource Search box until the typing is complete until focus is moved to a different area of the Schedule Board. 
- The quick scheduling experience will search for available resources in the date range provided in the Requirement group and displays available resources on the Book resources panel in the date range.
- On successful creation of Bookable Resource Booking record in the offline mode, no unintended warnings will be displayed on the form. 
- When looking for a Substitute Resource on a Booking using the ‘Find Substitution’ via Schedule Assistant, the Resource can be substituted on the suggested Timeslot by clicking on the ‘Substitute’ button, when hovered on the suggested Timeslot.
- When there are more than 30 suggested Resources on the Schedule Assistant, there will be paging of Resources and more suggested resources can be reached by scrolling to the next page.
- When a Map pin is selected for a Booking on the Schedule Board, after editing the selected Booking, (by Dragging and extending the booking), the Map pin stays selected.
- Schedule Board will support Booking Alerts are in large number (~200). 
- Only Active Booking Statuses will be displayed on the Booking Status dropdown field on the Booking panel of Schedule Board, when creating Bookings. 
- When searching for available resources for a Requirement Group, suggested resources will always be shown in List View only. 
- Resources on the Schedule Board tab can be selected via Select Resources under the Filter Options on the Internet Explorer Version 11.
- When calling the msdyn_SearchResourceAvailability action using a Requirement with a Fulfillment Preference for Timegroup as input, the output timeslot of the action will contain valid TimeGroupDetails
- Bookable Resource Bookings can be created on the Day light saving days (entering and exiting DST). 
### Enhancements
- Accessibility improvements are made on the Schedule Board and Schedule Assistant.

## 3.11.0.421

- Columns in the List View of the Schedule Board resize based on the size of the browser (Internet Explorer)
- A few accessibility issues on the schedule board and Quick Scheduling panel are fixed.
-  Days/Weeks/Months views on the Schedule Board support the Bookings for the Schedulable entities without Resource Requirements.
- When viewing the Bookings of Requirement Group in Split view, the Bookings in the Split view will be shown in the same timeline as of the Requirement Group bookings in the top half of the grid. 
- Work hours of a Resource with Capacity greater than 1 in a day, will reflect on the Schedule Board accordingly. 
- Resource Capacity booked percentage reflects the Resource’s bookings in the Days, Weeks, and Months views of the Schedule Assistant.
- The focus remains on the selected date when a Resource is selected from the Resource dropdown filter after selecting a date on the Calendar of the Quick Scheduling panel. 
- When a Resource Requirement with a Characteristic and Rating is booked, the Characteristic Filter will be populated with the Characteristic and Rating value from the Resource Requirement in the filter view of the Schedule Assistant. 
- The Search Start/Search End and Time From Promised/Time To Promised date time filters on the Filter view of the Schedule Assistant reflect the From Date/To Date and Time From Promised/Time To Promised from the Resource requirement records. 
- The membership of the members of a Crew type Resource on the Schedule Board is shown in the Timezone of the Schedule Board. 
- Only one Resource can be selected from the recommended Resources on the list view of the Schedule Assistant. 
-  When searching for available Resources for an Onsite Requirement Group, and a suggested timeslot is selected, the Estimated Arrival Time and Start fields in the Create Resource Booking panel are filled with the Start Time and Travel Start Time values from the list view. 
- When hovered on the Bookings on the Schedule Board, Booking card is displayed with a delay. 
- A booking can be created for a Work order in the Days, Weeks, or Months views of the Schedule Assistant. 
- Schedule Board loads Bookings of Resources, even with Resources who have no calendar or have multiple calendars. 
- Rebook for Bookings would work even with null values of the filters passed to the Schedule Assistant. 
- The Schedule Board and Schedule Assistant will load Booking and Resource Availability on the Internet Explorer ### Version 11.
### Enhancements
- Support for Preferred and Mandatory Resource in finding available Resources.
- Usability improvements to the Facility search scenarios via Quick Scheduling experience. 

## 3.10.0.239

- Only valid hex characters can be entered on the Status Color field on Booking Status form
- The overlapping bookings in the vertical view of the Schedule Board are separated by 1-px spacing. 
- Non-working hours color name is consistent across the Schedule Board tab settings and the Schedule Board Settings configuration record. 
- Long names will be wrapped inside the Booking tooltip. 
- Deletion of a Resource is not allowed if it has any group memberships active or inactive, parent, or child, has any associations active or inactive, resource 1 or resource 2. 
- When default sorting is added to the Schedule Assistant Retrieve Constraints UFX query in the default Schedule Board Settings, the Sort By filter of the Schedule Assistant is pre-filled with the field by which sorting is done and the Returned resources are sorted accordingly. 
- A few accessibility issues on the schedule board are fixed. 
- Schedule Board to load the Resources in Days, Weeks, and Months views with resources having a valid calendar and wouldn’t fatally fail if a Resource has an invalid calendar. 
- Combo control filter with multi=false, the selected value will show in the filter. 
- Active Resource Requirements view is sorted on Created On by descending order. 
- Derive Capacity from Group Members field on the Pool Resource form can be set to Yes or No as required. 
- Search Resources can be used to search Resources in the suggested Resources in the List view of the Schedule Assistant. 
- Custom Booking Template with fields from linked entities of Bookings is supported. 
- Resource Type filter on the Schedule Assistant will not remember the previously selected values, once unselected. 
- The Schedule Assistant loads as expected when clicked on Book button on a Work order form in Arabic. 
- When a Booking is created by Schedule Assistant, the Booking Method field on the Booking form is populated as Schedule Assistant. 

## 3.9.0.42

- The filter is not enabled for the Owner column on the Unscheduled Work orders Requirements view in the Requirement grid of the Schedule Board. 
- The refresh button on the Requirement Grid is disabled while the grid is refreshing the data. 
- Alignment for Resource icons and the Zoom slider on the Schedule Board are fixed for Arabic language.
- When searching for Resources in one view like horizontal, when switched to another view, like List view, the search is still retained along with the search text and results. 
- The Bookings can be moved to a different time or Resource by dragging and dropping the Booking on Days, Weeks, and Months views of the Schedule Board. 
- Quick Scheduling would be using the As The Crow Flies approximations to calculate travel time if Bing maps integration is not enabled. 
- Improved error messaging on the Schedule Assistant when looking for available resources and on the Schedule Board when displaying the Bookings. 
- When Auto Update Booking Travel  is enabled, and onsite Bookings are created by the Quick scheduling, the travel time to the subsequent bookings is updated based on the location of the previous booking. 
- The Schedule Assistant search for available resources will be successful with continuous multiple associations on a single day for a Resource type facility. 
- When an onsite Requirement is selected in the Requirement grid, the location pin is selected and focused in the Map view. Once clicked on ‘Find Availability’, the Location pin on the Map view will stay selected entering and exiting the Schedule Assistant. 
- Alignment of the fields on the Fulfillment Preferences form is fixed. 
- Alignment of the Sort arrows on the Sort Options control on the Schedule Board is fixed. 
- Time out issues request to msdyn_RetrieveResourceAvailability  is posted from a web app are fixed. 
### Enhancements
- FetchXML query is replaced by Query expression for the action that fetches Work order Bookings to improve the performance. 

## 3.8.0.105

- The date selector on the schedule assistant list view is dimmed because it has no effect on the resources displayed when searching for availability of a requirement or a work order.
- When booking a schedulable entity record, only the Booking Status that is mapped to the Booking Status Field Logical Name of the Booking Setup Metadata record of the schedulable entity will be on the schedule assistant. For example, when scheduling a work order, only the optionset values of the field msdyn_fieldservicestatus will be displayed in the Booking Status drop-down on the schedule assistant,
- When searching for availability of resources on a requirement, the number of matching Resources returned in the search on the schedule assistant is limited to the value set on the field Resource Availability Retrieval Limit on the Default Metadata Settings of the Booking Setup Metadata record. The default value of Resource Availability Retrieval Limit is 100.
- Only one Booking Setup Metadata for an Entity can be created.
- For German locale, on the schedule assistant, Remaining Duration does not overlap with the pie chart visual next to it.
- Only Active Resources can be added to a Resource Pool or Resource Crew’s children.
- A few accessibility issues on the schedule board are fixed.
- The Resource Requirement form can be customized to remove optional fields like Resource Type from the form.
- Selected Sort on the schedule board is determined by the Sort result by filter on Filters.
- The Booking Alerts Template field on the default Schedule Board Settings shows the default HTML template value.
- Book and Book & Exit buttons on the schedule assistant are enabled only when at least one eligible resource is returned on the schedule assistant.
- Multiple characteristics can be selected on the filters on the schedule board.
- A Booking cannot be deleted when it has an associated Booking Alert.
- When booking a requirement in the weekly view or monthly view of the schedule assistant, if the availability search Start date is today and is not the first day of the week or month, the Start date will correctly default to today, so that the Book button is enabled.
- The Work Location filter on the schedule assistant will show all three possible values: Onsite, Facility, and Location Agnostic.
- The filters on the schedule board will show the right values in the drop-down even when the user manually types in the filter.
- When Auto Update Booking Travel is enabled in the scheduling parameters, Travel Time of the adjacent bookings is updated when a booking is created in the List view of the schedule assistant.
- Correct search results are displayed on the Quick Scheduling panel for all Time Zone values set on the Resource Requirement form.
- A multiresource work order, that is, a work order associated with a Requirement group, can be booked via Quick Scheduling.
- Requirement Group bookings can be viewed in split view.
- The Timeline header on the schedule board will be shown even after exiting the schedule assistant by selecting Exit Search.
- The rating values on the Rating Model form are ordered by rating values, not the names.
- The Resource card can be opened by right-clicking the Resource, even when the Resource has characteristics with no rating values.
- When booking a Requirement Group via the schedule assistant, selecting a timeslot on the list view opens up the Create Resource Booking Panel on all browsers.
- When booking a Requirement Group or the requirements under that Requirement Group, the same results are displayed on the schedule assistant.
- Facility requirements can be booked via Quick Scheduling with the correct duration of the booking.
- You can book work orders on the Days view of the schedule assistant.
- Multiple issues preventing upgrade.
### Enhancements
- Performance improvements to schedule board refresh times when multiple Crew type resources are present on the schedule board.
- Performance improvements to searching for resource availability for Requirement Groups.
- Reduced unnecessary calls to retrieve the Resource Requirements name and booking setup metadata. Other duplicated calls are also reduced when searching for availability.
- Self-service scheduling API is now available to schedule the single resource requirement, with a corrected process name Resource Scheduling – Search Resource Availability and unique name msdyn_searchresourceavailability.
- From and To date fields on the Resource Requirement entity are restricted to have only the User Local behavior to avoid Time Zone functionality loss on the schedule assistant and loss of the Time Zone data on resource requirements.
- Added a suggestion to Service Health Diagnostics to show the suggestion/fix with manual steps when Resource Booking Sync job is disabled but the feature Synchronize resource bookings with Outlook is enabled.
- When using URS on Unified Service Desk, the schedule board can be loaded without having to pass the full Unified Interface context.
- Quick Scheduling now supports scheduling of onsite requirements.

## 3.7.0.70

- Requirement group control loads in the service form on the customer service scheduling app.
- When a schedulable entity without a resource requirement is booked via the schedule assistant (pop-out schedule board) days, weeks, or months views, the booking status is populated to the default status.
- The resource routes are optimized by listing using the schedule board driving directions in the sort order of a booking’s start time.
- Optimized rebooking in the schedule board by fixing a client-side console error.
- Map view icon is no longer displayed in the schedule assistant view.
- Changes on the default schedule board Settings form are saved when accessed from booking setup metadata record.
- Drag and drop the bookings from one resource to another or from one time to another of the same resource in days, weeks, or months views.
- Resource names with apostrophes, like O’Brien, can be searched on the schedule board resources.
- Booking a resource requirement for the facility resource type now populates the Resource filter field as a facility in the schedule assistant (pop-out schedule board).
- Book Based On setting for the schedule board shows how the time slot suggestions are displayed in the Hourly view of the schedule assistant, and more details on how to use Book Based On are included.
- Duration filter on the schedule assistant for Hebrew is fixed when the value of the duration is 1.
- Travel start time on the schedule assistant list view shows as travel time subtracted from the work start time.
- Drag and drop multiple open requirements to an expanded resource in days, weeks, or months view to create multiple bookings.
- Rendering of the resources on the schedule board is improved.
- View resource cards in the schedule assistant for requirement groups availability.
- Schedule assistant minimizes the number of resources necessary to fulfill a requirement group when the Sort result by field is set to Fewest Resources first.
- Multiple issues preventing upgrade.
- Drag resource route on the map to a requirement pin to create a booking for the resource.
- The Select Resources filter can be used to select the resources to be displayed on the schedule board.
- Only active members of the crew with valid crew membership will be booked when a crew is booked.
- Driving directions and the map view on the schedule board have the same traffic icon.
- The position of the hover Book button on the suggested time slots is adjusted when the preceding booking is extended beyond the suggested time slot. 
- When a requirement is selected and the Requirements panel is refreshed, the requirement selection persists.
### Enhancements
- Made improvements to uptake new endpoint Bing distance matrix APIs.
- Self-service scheduling API is now available to schedule the single resource requirement.
- The work location for new requirements added to a requirement group is now inherited from the work location of the existing requirements in the requirement group, and is kept in sync.
- The calendars of the requirements of a requirement group are kept in sync and share the same calendar. Changing a calendar or time zone for one requirement updates it for all the requirements of the requirement group.
- When booking a requirement group, the schedule assistant is launched in the time zone of the requirement group’s requirements because they all share the same requirement.
- Performance improvements to searching for resource availability, viewing bookings on the schedule board, creating bookings for crews, creating bookings in the hourly views of the schedule board, and when using other URS plug-ins.

## 3.6.0.18

- On the schedule assistant, the radius unit behavior reflects kilometers or miles as per the preferred unit of distance when “Search for” field is changed.  
- The zoom level on the “Map View” on the “Filter Panel” will be preserved after entering or exiting the Schedule assistant search. 
- Only activated members of a crew get booked when a crew is booked. 
- On the schedule board setting for schedule assistant, the unavailable resources field can be changed from “Unavailable resources do not appear” to “Unavailable resources appear dimmed“ to show the unavailable resources on the schedule assistant. 
- Alignment of scheduler settings controls.  
- On a schedule assistant search for available resources on a location agnostic resource requirement, the “Time From Promised” and “Time to Promised” time window precedes over the “Search Start” and “Search End” time window, and the recommendations will be presented to make sure the technician can start work in the “Time From Promised” and “Time To Promised” window. 
- Onsite multi-resource requirements will be presented with travel time in the schedule assistant recommendations. 
- The filter panel’s characteristic field on the schedule assistant is populated with the characteristic from the resource requirement or work order. 
- Multiple issues preventing upgrade. 
- Resource utilization of a resource on non-working day, along with the color code of the non-working day. 
- Dragging the technician travel route to a requirement pin to schedule the booking in the maps view on the filter panel of schedule board. 
- The schedule board setting “Order Number” default maximum value is increased to 1000 from 100. 
- Duration field value text in Hebrew on schedule assistant.
### Enhancements
- When inserting a booking between two bookings or reassigning a booking to another resource, the travel time of all associated bookings will be recalculated and updated on hourly schedule board and schedule assistant. This feature can be enabled by “Auto Update Booking Travel” field under Resource Scheduling > Settings > Administration > Scheduling Parameters. 
- When the “Book” button is used on the resource requirement and the timezone on the pop-out schedule board is updated, the date time fields on the bottom requirement info panel will reflect the changed timezone. 
- All the date and times in the filter panel and requirements panel on the schedule board are updated when the time zone is changed in the scheduler settings on the schedule board. 
- Various performance improvements when searching for resource availability. 

## 3.5.0.107

- Booking Status on the Create Resource Booking panel is always defaulted to either Front Load or the last used value on the Schedule Board. 
- On the Schedule Assistant, a new booking can be created in custom time, by clicking and dragging in the Demand Panel, which opens the Create Resource Booking panel for confirmation of Booking details.
- A Resource Requirement record can be created by quick create forms on the Schedule Board, even there are no Resources on the Schedule Board tab are working. 
- When the Start and End locations of the Bookable Resource are set to Organizational Unit Address, the Organizational Unit field becomes mandatory field. 
- The Row Height and Column Width slider tooltip value is now localized.
- The location of the Tooltip, when dragging and dropping an existing Booking on the board is corrected in the Hebrew language orgs.
- Slider controls on the Scheduler Settings of the Schedule Board are aligned in the orgs with Right to Left Languages.
- Error handling improvements on the Schedule Board. 
- Resource Requirement Details associated view of Resource Requirements includes additional details like Duration, From and To fields. 
- The Skills subgrid in the Resource Requirement form will only show relevant data and hide the redundant data like the Resource Requirement name field. 
- On the Schedule Board, Bookings can be created with the Start/End Dates in the past.
- Contains solution upgrade Improvements
- Select Resources dialog opens for selection of Resources to be shown under the Schedule Board tab
- The Working Time of the Schedule Board tab can be configured by using the Start Time and End Time slider controls under the Scheduler Settings of the Schedule Board tab. 
- Duplicate Booking creation on the Schedule Board, due to network race conditions is now fixed. 
- The Availability cells in the Days view of the Schedule Board are appropriately aligned on the Daylight-Saving days at 12:00 AM. 
- The duration of the Bookings on the Multi-day views of the Schedule Board can be decreased by dragging the right end of the booking to left or left end of the booking to right. 
- The pre-filled Characteristic-Rating value in the Filter view, can be selected to view it the filter view. 
- Booking Rules dialog respects the Cancel button and wouldn’t create a Booking. 
- When looking for available resources using a Resource Requirement for Resource type Facility, in the List View of the Schedule Assistant, Organizational Unit column shows the appropriate string values. 
- When clicked on Maintain Bookings for a Team member, opens up the Schedule Board with the Project Bookings for the Selected team member. 
- Book button is displayed on the Resource Requirement form for the Users only with appropriate read/write privileges to the entity.
- Resource Requirement for Facility type pool can be searched for Available Resources using the Schedule Assistant or Find Availability.
### Enhancements
- Improvements are made to the Date Time controls by leveraging the Office fabric UI control on the Resource Requirement, Fulfillment Preferences, and Time Group Detail forms. 
- Scheduling Health Diagnostics provides capabilities to detect and suggest self-healing options with regards to the 
 - Unsupported Customizations on internal use only web resources
 - Actions and Workflows that are in draft state
 - Essential SDK message processing rules that are in disabled state
 - Missing metadata records such as Booking Setup Metadata records, default UFX query values. 
- Improvements are made to the Icons on the Booking Right click menu
- If Connect to Maps is disabled, the Travel times will be calculated based on the Crow fly approximations. 
- Performance improvements for the Retrieve Resource Availability action calls on the multi - Resource Requirements with fulfillment preferences (intervals)

## 3.4.0.141

- Custom date and time fields now display properly on schedule board panels.
- Issues opening and saving schedule board resource picker under options in filter control
- Paging issues when using schedule board resource picker under options in the filter panel
- When “Time From Promised” on the requirement is in the past and you search for availability, the value is now moved to the current time and the search button is enabled.
- Changing the schedule board working time no longer immediately closes the settings dropdown
- Book button now appears on views and forms when using USD
- Resources associated to a facility with a parent Organization Unit that is different from the associated facility correctly use facility organizational unit when it comes to Schedule Assistant facility search.
- Miles/Kilometers default properly from scheduling parameters entity
- Generic Resource type is removed from resource picker under the select resources dialog
- Auto focus on characteristic rating value in filter control when entering Schedule Assistant on certain devices.
- Overbooked requirements no longer show a negative duration in booking panel when in Schedule Assistant
- Facility searched properly group results by Organizational Unit regardless of the value in the “part of same” field on the requirement group control.
- Resources that are location agnostic, yet are associated to a facility, will return in facility searches for the time they are associated to the facility.
- Issue selecting pool type on schedule board filter panel while using Firefox browser.
- Selecting cells in daily, weekly, and monthly boards while in schedule assistant now pass information to the booking panel properly.
- Schedule boards that have characteristics with rating values saved no longer prompt user to enter a rating value.
- Issue on certain devices where current timeline bar on schedule board wasn’t showing correct time.
- Work location on booking is now set properly when using drag and drop on schedule board.
- Misaligned labels for languages that read right to left
- Issue loading schedule board in Internet Explorer 11
- Issue creating schedule alerts from certain places
### Enhancements
- Various performance improvements when creating bookings
- Dragging to extend a booking on multi-day schedule boards opens booking panel instead of booking dialog

## 3.2.0.405

- If a booking has the work location field set to location agnostic, the booking will be treated as location agnostic even if there is a latitude and longitude value on the booking.
- Issue with schedule board list view refreshing when changing between hourly and daily.
- When searching for a resource in the resource search bar on the schedule board list view, if no resources can be found, the board properly removes all resources.
- Issue dragging a requirement from the map to the schedule board while using Firefox browser.
- Changing “derive capacity” field on a pool resource from no to yes now triggers the calendar to be calculated based on the child resources of the pool.
- Issues when changing between horizontal and vertical schedule board while in split view.
- Issue loading schedule board with many explicitly saved resources.
- Resource’s location is now properly taken from the facility it is associated to.
- When using a language that reads from right to left, the resource name is now properly rendered on the schedule board.
- When launching the schedule assistant from a schedulable entity, the user now lands back on the same form after clicking book and exit.
- Schedule board no longer shows resource with a capacity greater than 1 as available all day.
- When booking a requirement group using the schedule assistant, the booking status dropdown now properly filters to the booking statuses for that schedulable entity. To learn more about using different statuses for different schedulable entities, here is a previous blog post. 
- Issues loading requirement group control in Edge browser.
- When using the schedule assistant to schedule a requirement group for a facility, there is no longer a travel time conflict between the facility and the resources.
- Double booking option in schedule assistant on daily, weekly, and monthly boards now properly books the resource even if the resource has no remaining capacity.
- Appointment schedule board settings are now generated properly.
- Issues in certain scenarios where schedule board had issues loading in Internet Explorer.
- “Supplied DateTime represents an invalid time” error. 
- Error message when scheduling a single requirement to a crew resource.
### Enhancements
- Resources associated to facilities will no longer return in onsite schedule assistant searches. This prevents customers from accidentally scheduling a resource that should be stationed at a facility from going to a customer location.
- Resources that are not associated or related to a facility will no longer return in facility searches. Currently, when a resource is set up to work at a facility through an association or as a child resource of a pool, URS does not account for travel to the facility. 
- When using the schedule assistant to schedule a requirement group, if the requirement‘s work location is set to facility, and there are no options selected under the “part of same” attribute, the search will execute as if part of same “Resource Tree” is selected.
- Saving a filter on the schedule board now shows a green confirmation checkmark instead of a yellow warning symbol.
- Warning message will now be displayed when trying to change the latitude or longitude field on a booking.
- Added validation to check that if a resource is associated to a facility, then it should not be allowed to be a child resource of a pool associated to a facility or facility pool for the same timeframe.

## 3.1.0.166

- If a booking has the work location field set to location agnostic, the booking will be treated as location agnostic even if there is a latitude and longitude value on the booking.
- Issue with schedule board list view refreshing when changing between hourly and daily.
- When searching for a resource in the resource search bar on the schedule board list view, if no resources can be found, the board properly removes all resources.
- Issue dragging a requirement from the map to the schedule board while using Firefox browser.
- Changing “derive capacity” field on a pool resource from no to yes now triggers the calendar to be calculated based on the child resources of the pool.
- Issues when changing between horizontal and vertical schedule board while in split view.
- Issue loading schedule board with many explicitly saved resources.
- Resources location is now properly taken from the facility it is associated to.
- When using a language that reads from right to left, the resource name is now properly rendered on the schedule board.
- When launching the schedule assistant from a schedulable entity, the user now lands back on the same form after clicking book and exit.
- Schedule Board no longer shows resource with a capacity greater than 1 as available all day.
- When booking a requirement group using the schedule assistant, the booking status dropdown now properly filters to the booking statuses for that schedulable entity. To learn more about using different statuses for different schedulable entities, here is a previous blog post. 
- Issues loading requirement group control in edge browser
- When using the schedule assistant to schedule a requirement group for a facility, there is no longer a conflict of travel time between the facility and the resources
- Double booking option in schedule assistant on daily, weekly, and monthly boards now properly books the resource even if the resource does not have any remaining capacity.
- Appointment schedule board settings are now generated properly.
- Issues in certain scenarios where schedule board had issues loading in Internet Explorer.
- “Supplied DateTime represents an invalid time” error 
- Error message when schedule a single requirement to a crew resource
### Enhancements
- Resources associated to facilities will no longer return in onsite schedule assistant searches. This prevents customers from accidentally scheduling a resource that should be stationed at a facility from going to a customer location.
- Resources that are not associated or related to a facility will no longer return in facility searches. Currently, when a resource is setup to work at a facility through an association or as a child resource of a pool, URS does not account for travel to the facility. Therefore, only resources set to work at a facility will return in facility searches.
- When using the schedule assistant to schedule a requirement group, if the requirement(s) work location is set to facility, and there are no options selected under “part of same” attribute, the search will execute as if part of same “Resource Tree” is selected.
- Saving a filter on the Schedule Board now shows a green confirmation checkmark instead of a yellow warning symbol.
- Warning message will now be displayed to a user if they try to change the latitude or longitude field on a booking.
- Added validation to check if a resource is associated to a Facility then it should not be allowed to be a child resource of a pool that is associated to a Facility or Facility pool for the same timeframe.


## 2.4.11.59

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/14/enhancements-and-bug-fixes-in-universal-resource-scheduling-urs-version-2-4-11-59/).

## 2.4.10.56

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/release-notes-for-universal-resource-scheduling-version-2-4-10-56/).

## 2.1

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2017/05/19/universal-resource-scheduling-solution-for-dynamics-365-update-6-1/).