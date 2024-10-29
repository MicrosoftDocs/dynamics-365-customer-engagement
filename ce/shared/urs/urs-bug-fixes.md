  
## Release schedule

When a new version of Universal Resource Scheduling releases, it becomes available in different geographic regions at different times. The table shows estimates for when the next release will become available in the region of your environment.

For information about other updates to Universal Resource Scheduling, visit the Field Service section of the [Dynamics 365 release plans](/dynamics365/release-plans/).
For information about older versions, see [Version history archive](../../field-service/version-history-archive.md#universal-resource-scheduling).

| Station | Region | Current version | Next version | Scheduled date |
| ------- | ------ | --------------  | -----------  | -------------  |
|**Station 1** |  *First Release*| [3.12.143.36](/dynamics365/field-service/field-service-version-history-resource-scheduling#31214336) | TBD | 11/01/2024 |
|**Station 2** |  *South America, Canada, India, France, South Africa, Germany, Switzerland, Norway, Korea* |     [3.12.143.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#31214346) | TBD | 11/08/2024 |
|**Station 3** | *United Arab Emirates, Japan, Asia Pacific, United Kingdom, Oceania, Singapore* | [3.12.142.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121421) | [3.12.143.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#31214346)  | 11/01/2024 |
| | *USG* |  [3.12.143.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#31214346) | TBD | 11/08/2024 |
|**Station 4** |*Europe* |   [3.12.142.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121421) | [3.12.143.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#31214346)  | 11/08/2024 |
|**Station 5** |  *North America*|   [3.12.142.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121421) | [3.12.143.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#31214346) | 11/15/2024 |
|**Station 6** | *Government Community Cloud, DoD, China*  |[3.12.142.5](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121425)|  [3.12.143.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#31214346) | 11/22/2024 |
|**Station 6** | *Dedicated Scale Groups* |[3.12.142.5](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121425)|  [3.12.143.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#31214346) | 11/29/2024 |
>[!NOTE]
>
> - Dates in all regions except Government Community Cloud (GCC), USG, and China are estimates of the next automatic update. Dates in GCC, USG, and China indicate version availability; at this time, there is no automatic update for the GCC, USG, and China regions.
> - For all other regions, while most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 3.12.143.46

**Resource Scheduling Controls:** 1.2.82.242904

**Dataverse:** 4.0.133.47

- Fixed bug that was redirecting some users to the wrong version of the schedule board.

## 3.12.143.36

**Resource Scheduling Controls:** 1.2.82.242904

**Dataverse:** 4.0.133.37

- Fixed a bug that was causing booking previews in schedule assistant to render on top of the settings panel and legend.
- We now show an error when users try to derive capacity from group members on resources that are not pools.
- Fixed a bug that was causing estimated arrival times to be set even when there were no changes.
- Fixed a bug that was sometimes causing the wrong requirement to be booked when using schedule assistant on work orders with multiple requirements.

## 3.12.142.5

**Resource Scheduling Controls:** 1.2.81.242685

**Dataverse:** 4.0.132.5

- Fixed bug that was misdirecting some users to the wrong version of the schedule board.
  
## 3.12.142.1

**Resource Scheduling Controls:** 1.2.81.242685

**Dataverse:** 4.0.132.1

- This release includes all updates from the 2024 release wave 2 early access updates.
- The relevant account for underlying bookings can now be seen on the schedule board aggregate booking by turning on a new feature. 
- Keywords in requirement search box on the schedule board are now cached when switching between tabs.
- Turning on focus mode no longer maximizes the browser.
- Fixed a bug that was causing the schedule Assistant to ignore fulfillment preferences on the initial load.
- Fixed a bug that was impacting time labels on Specify Pattern when changing time zones.
- Schedule Assistant is now using Bryntum in production environments.


## 3.12.140.11

**Resource Scheduling Controls:** 1.2.79.242513

**Dataverse:** 4.0.130.11

- Organizational Units are now displayed in alphabetical order in the schedule board filter panel.
- Improved handling of mismatched distance units in Schedule Assistant.
- Fixed a bug that was causing the Crew Allocation Tool to crash when Derive Capacity from group members was checked.
- Fixed a bug that was preventing some additional capacity rows to not expand on the Schedule Board.
  
## 3.12.139.62

**Resource Scheduling Controls:** 1.2.78.242404

**Dataverse:** 4.0.129.62

- Fixed a bug that was causing an error when deselecting resources in the booking panel.
- Fixed a bug that was causing Schedule Board zoom setting not to cache when set to 0.
- Sorting by rating value is now cached and included in saved default filters on Schedule Board tabs.

## 3.12.141.6 - 2024 Wave 2 Early Access update 2

**Resource Scheduling Controls:** 1.2.80.242331

**Dataverse:** 4.0.131.6

- No updates were made to Universal Resource Scheduling in this release.

## 3.12.138.39

**Resource Scheduling Controls:** 1.2.77.242277

**Dataverse:** 4.0.128.39

- Fixed a bug that was displaying an empty preview section on the scheduling parameter form.
- Fixed a bug that was impacting custom field mapping when bookings are created through the schedule assistant.
- Fixed a bug that was causing some input values to persist after selecting *Reset to Default* in the board settings. 
- Fixed a bug that was causing a *No results* message in the schedule assistant list view while results are still populating.
- Fixed a bug that was causing issues with validating *Time Promised* windows on the schedule board when the entity and browser time zones are different.
- Fixed a bug where the number of available hours in a day for resources were not being displayed in the Gantt view of the schedule assistant.
- Working day selections are now honored even when the date range begins on a non-working day and when switching between daily and hourly views.

## 3.12.137.22

**Resource Scheduling Controls:** 1.2.76.242082

**Dataverse:** 4.0.127.22

- Removed toggle for a feature that is not yet active.
- Various security enhancements.

## 3.12.141.2 - 2024 Wave 2 Early Access

**Resource Scheduling Controls:** 1.2.80.242082

**Dataverse:** 4.0.131.2

- Custom URLs that accessed the old schedule board are now redirected to the new schedule board preserving any relevant parameters.
  
## 3.12.137.15

**Resource Scheduling Controls:** 1.2.76.242082

**Dataverse:**  4.0.127.15

- Fixed a bug in the schedule assistant that disabled the **Book** and **Book and Exit** buttons in the create booking panel when working with resources with multiple units of capacity or set to allow overlapping bookings.
- When a resource is selected, map view on the schedule board now shows the resource's latest geolocation.
- Fixed a bug that was causing schedule assistant to ignore the **Allow Overlapping** selection.
- Fixed a bug that was causing notifications from schedule assistant to appear in the wrong location based on certain window configurations.
- Improved managed identity handling when using the msdyn_SearchResourceAvailabilityForRequirementGroup API.
- Improved requirement groups' handling of resources with multiple units of capacity.
- Fixed bug that was impacting the actual booked time slot when allow overlapping bookings is selected.


## 3.12.136.61

**Resource Scheduling Controls:** 1.2.75.241931

**Dataverse:**  4.0.126.59

- Removed toggle for a feature that is not yet active.
- Various security enhancements.
  
## 3.12.136.53

**Resource Scheduling Controls:** 1.2.75.241931

**Dataverse:**  4.0.126.51

- Fixed a bug that caused the schedule assistant to not consider additional resource capacity.
- Fixed a bug that wcaused multi-day bookings created with the schedule assistant to add an additional booking detail when booked outside the search range and an evenly distribute hours booking method. 
- Custom web resources no longer get covered when extending the map panel.
- Booking rules only run in the hourly view.
- Added a tooltip to see long values in fields.
- Improved schedule board rendering performance. 
- Improved translationa and localization.


## 3.12.135.25

**Resource Scheduling Controls:** 1.2.74.241731

**Dataverse:**  4.0.125.34

- Improved messaging when there are no schedule assistant results due to retrieval limits.
- Added "Today" label to the related icon on the schedule board.
- Users can now enter text continuously in the Crew Allocation tool's resource search bar.
- Fixed a bug where requirement groups were not being created by the system user.
- Fixed a bug that was opening the details panel when selecting a resource from the Create booking panel.
- The "Learn more" link when no results found on schedule assistant has been redirected to the appropriate documentation.
- Fixed a bug that was causing "Switch views" to not appear in the right click menu on the schedule board.
- Improved crew membership masking on the schedule board.
- Fixed a bug that was causing selected ties from schedule assistant to not be honored for requirement group bookings.
- Improved legend display on schedule board.

## 3.12.134.25

**Resource Scheduling Controls:** 1.2.73.241652

**Dataverse:** 4.0.124.25

- Fixed a problem that was causing some Schedule Board list view users to see resources erroneously marked as unavailable or available. 
- Business Closure Start Time and End Time fields have been retitled Start and End respectively.
- Resource filter panel now resets to page 1 when search for resources.
- Users are now notified when one of their booking rules is ignored because it is invalid, broken, or corrupted.
- New crew member bookings are now reflected on the SB without a manual refresh.
- Improvements to handling of capacity for requirement groups and facility resources.
- Fixed a problem where Schedule Asisstant was not returning results when one of the Time From/To Promised fields is empty. 
- Fixed a problem that was causing the Create Booking and Details panels to open in each other's place.
- Improved full-screen experience.
- Localization improvements.
- Various security enhancements.

## 3.12.132.9

**Resource Scheduling Controls:** 1.2.71.241432

**Dataverse:** 4.0.122.8

- Improved rendering for non-working hours on the schedule board.
- Fixed a bug that was causing some users to experience crashes when working hours did not start at 12 am.
- Users can now use 24-hour format to enter a time for the End Time field on the booking pane.
- Added a button to jump to today's date on the schedule board.
- Fixed a bug that was displaying incorrect travel times for some requirement group bookings.
- Various security enhancements.
- **Introduced a new tool to efficiently make single day membership changes for crews.**
- Fixed a bug that was causing the Schedule Assistant Booking Panel to malfunction when working with requirement groups.
- Fixed a bug that was causing list view in schedule board to not show availability in some circumstances.
-	Various security enhancements.



## 3.12.131.1

**Resource Scheduling Controls:** 1.2.70.241042

**Dataverse:** 4.0.121.1

- Horizontal scroll location is now maintained when switching views on the schedule board.
- List view on the schedule assistant now sorts all results instead of just the current page.
- Various tooltips have been improved.
- Fixed a bug that was cancelling all related bookings when a Project Operations user canceled a project requirement in an interday view. 
- Fixed a bug that was causing the requirement panel to crash when reordering tabs with active filters applied. 
- Fixed a bug that was mislabeling or and duplicating certain entities in the Related tab of a bookable resource form. 


## 3.12.130.10

**Resource Scheduling Controls:** 1.2.69.240991

**Dataverse:** 4.0.120.10

- Inactive organizational units are no longer displayed on the map
- Custom color setting for working/non-working hours are now used in aggregated views and the hourly view.
- Fixed a bug that prevented the selection of new some new tabs on the requirement pane. 
- Fixed a bug with syncing changes to a booking in the schedule assistant grid.
- Fixed a bug that was causing schedule board to crash when maximizing it from a very small window.
- Fixed a bug that was causing the details panel to not respect customized requirements detail view for resource type.


## 3.12.129.28

**Resource Scheduling Controls:** 1.2.68.240862

**Dataverse:** 4.0.119.28

- Fixed a bug that was preventing some users from rearranging schedule board tabs.
- Unchecked working days are no longer shown in the schedule board's list view.
- Various bug fixes to working days selection.
- Fixed a bug that was casing discrepancies between values on bookings made using the Create panel and how they were displayed in Map view.
- Requirement details are now shown properly in the Edit Booking panel. 
- Users can now change booking status in the Create Booking panel.

## 3.12.125.30

**Resource Scheduling Controls:** 1.2.64.240721

**Dataverse:** 4.0.115.30

- Fixed a bug that was disabling saved filters after a hard refresh for some users.
- Fixed a bug that was disabling the Delete button in a booking context menu in multiday views.
- Travel times of existing bookings are now updated when previous bookings are deleted.
- Booking statuses can now be updated while in multiday views in both List and Gantt modes.

## 3.12.127.12 - 2024 Wave 1 Early Access update 1

**Resource Scheduling Controls:** 1.2.66.240663

**Dataverse:** 4.0.117.12

- Users can now select which days of the week are visible on the schedule board.
- Added a vertical line to indicate current day while in aggregated views.
- Fixed bug where Move Bookings was not functioning properly in some time zones.
- Removed entry point to Schedule Board Settings from Booking Setup Metadata ribbon button.

## 3.12.124.11

**Resource Scheduling Controls:** 1.2.63.240662

**Dataverse:**  4.0.114.11

- Fixed a bug where edited search ranges were defaulting back to requirement start/end dates in Schedule Assistant.
- Improved Service Territory search box in the Select Resources panel.
- Requirement proposed and fulfilled durations now update automatically when bookings are made in Schedule Assistant.
- Fixed a bug that was impacting the Move Bookings feature for some users.
- Various security enhancements.
- Fixed a bug where double clicking on a booking was not opening the record while in the schedule board's hourly view.

**Resource Scheduling Controls:** 1.2.63.240662

## 3.12.123.34

**Resource Scheduling Controls:** 1.2.62.240661

**Dataverse:**  4.0.113.34

- Travel time calculates correctly for facility resources.
- All relevant fields now link to their respective entities in the requirements pane on the schedule board.
- The time zone setting in the schedule board settings is now reflected when moving a booking.
- Performance improvements when switching between schedule board tabs.
- Various security enhancements.
- Fixed a bug where double clicking on a booking was not opening the record while in the schedule board's hourly view.

**Resource Scheduling Controls:** 1.2.62.240661

## 3.12.126.1 - 2024 Wave 1 Early Access

**Resource Scheduling Controls:** 1.2.65.240241

**Dataverse:** 4.0.116.1

- Booking templates now feature updated colors and color picking tools.
- Fixed a bug that was impacting requirement grid column filters for some users.


## 3.12.122.50

**Resource Scheduling Controls:** 1.2.61.240223

**Dataverse:** 4.0.112.50

- Minor user experience bug fixes for requirement groups, map pins, and service territories.

## 3.12.121.18

**Resource Scheduling Controls:** 1.2.60.240112

**Dataverse:** 4.0.111.21

- Released new **Specify Pattern** version to break down long-duration or complex requirements.
- Bookings made in the Booking pane can now be set to any time granularity. 
- Fixed a bug where resources marked to not show on the schedule board were listed in the *Move to* dropdown.
- The number of child resources for pools and crews now show on the schedule board.
- Extra capacity of a resource now shows on the schedule board when available. 
- Booking rules now support HTML tags.
- The *Service territory* field on the *Select resource* filter now supports free text.

## 3.12.120.16

**Resource Scheduling Controls:** 1.2.59.233402

**Dataverse:** 4.0.110.19

- Introduced new version of the **Specify Pattern** control to break down multi-day requirements.
- Fixed a bug where users without delete permissions were shown a delete button on bookings.  
- Enabled free text in the service territory filter field.  
- Booking rules now support HTML tags on the new schedule board.
- When closing schedule assistant on the schedule board, users see their last open requirement tab.  
- The schedule board supports Internet Explorer mode of the Microsoft Edge browser. 
- Fixed a bug that caused an incorrect number of child resources to show on the schedule board for Crew and Pool resources.  
- The move option on the schedule board now respects the resource selection of the schedule board.
- Users can set specific times in the booking panel beyond the existing 15-minute granularity.

## 3.12.119.27

**Resource Scheduling Controls:** 1.2.58.232961

**Dataverse:** 4.0.109.27

- Performance improvements for API calls.
- Performance improvements when using the schedule assistant with lots of bookable resources.  
- Fixed a bug where bookings made with the schedule assistant are longer than resource's availability when search availability is manually set.  
- Fixed a bug that was causing an error message when opening the specify pattern control.
- Fixed bugs with apostrophes in requirement names and booking templates.
- PowerApps improvements with the specify pattern control.

## 3.12.118.19

**Resource Scheduling Controls:** 1.2.57.232831

**Dataverse:** 4.0.108.19

- In the map view on the schedule board, there are now visual indicators to show which record is selected. 
- Fixed a bug that was preventing some tooltips to not properly function while in list view. 
- Improved the schedule board resolution slider to honor the configured working time. 
- Fixed a bug that was displaying an error when booking certain full capacity requirements with a “Full Requirement” booking method. 
- Fixed bugs that were causing errors to be displayed when editing booking lengths in multi-day views.  

**Resource Scheduling Controls:** 1.2.57.232963

- Fixed a bug where apostrophes were shown as undefined when part of a book template name
- Fixed a bug where the Schedule Board requirements grid wasn't showing data. 

## 3.12.117.31

**Resource Scheduling Controls:** 1.2.56.232691

**Dataverse:** 4.0.107.30

- **Proportional booking visualization on aggregated schedule board views:** On daily, weekly, and monthly schedule board views, bookings are displayed as a proportion of their duration to the time block instead of filling the whole period.  
- When schedule assistant fails to create a booking, an error message now shows more information. 
- Fixed an issue that was causing the schedule board to load the wrong date when operating in specific time zones. 
- Fixed an issue that was causing selected resources to be displayed as undefined when using client extensions.  

**Resource Scheduling Controls:** 1.2.56.232963

- Fixed a bug where apostrophes were shown as undefined when part of a book template name
- Fixed a bug where the Schedule Board requirements grid wasn't showing data.  

## 3.12.112.5

**Resource Scheduling Controls:** 1.2.52.232511

**Dataverse:** 4.0.102.5

- **Capacity for resource search**: Resource search is now supported for organizations with more than 5,000 resources. 
- **Accessibility**: Implemented various accessibility improvements including increased support for screen readers, new visual labels, and more ARIA attributes. 
- Fixed an issue in the API where calling *msdyn_SearchResourceAvailability* consistently returned empty *AvailabilityIntervals* and *Characteristics*.
- Fixed an issue that led to the schedule assistant returning no available slots when a user entered information in the *Time from promised* field.  
- Fixed an issue where service territory filters were being reset when navigating through pages of a resource selection search.  

**Resource Scheduling Controls:** 1.2.52.232844
 - Various security enhancements  

## 3.12.116.5 - 2023 Wave 2 Early Access update2

**Resource Scheduling Controls:** 1.2.55.232482

**Dataverse:** 4.0.106.5

- **Retirement of the legacy schedule board:** The new schedule board is faster, more user-friendly, and accessible. It lays the foundation for new capabilities such as multiday scheduling and intelligent interactions.
- **Proportional bookings on multiday views:** Quickly determine a resource’s availability and utilization.
- **Multiple recurrences in work hours calendar:** Greater flexibility in resource scheduling, helping you meet business demands while adjusting to your workforce’s needs.
- Fixed an issue where rebooking and substituting on a requirement that got deleted was failing.
- Fixed an issue where the schedule board color wasn't being applied when saving the board setting with a new color.
- Fixed an issue where "Find Availability" in the new schedule board wasn't considering custom fields.

## 3.12.111.36

**Resource Scheduling Controls:** 1.2.51.232411

**Dataverse:** 4.0.101.36

- Fixed an issue where filtering resources by name didn't handle accented characters correctly.
- Fixed an issue where the “Time From/To Promised” fields weren't displayed during drag and drop operations on the schedule board if custom booking templates were enabled.
- Fixed an issue where the resource search bar on the schedule board was limited to the client-side records and couldn't search for all records when there were more than 5,000 resources.
- Fixed an issue where the schedule board didn't load completely after creating a new tab and switching back to the “Initial public view” tab. 
- Fixed an issue where the calendar icons on the “From” and “To” fields in the requirement group form didn't open the calendar picker. 
- Fixed several accessibility issues in the “Edit Booking Alerts Template” dialog, button labels, ARIA attributes, and screen reader compatibility.

## 3.12.110.18

**Resource Scheduling Controls:** 1.2.50.232152

**Dataverse:** 4.0.100.18

- Fixed a bug where the schedule board color wasn't applied when saving the board setting with a new color.
- Fixed a bug where the “Find Availability” feature in the new schedule board didn't consider custom fields.
- Improved accessibility for the “New Filter Layout” dialog, the “New Schedule Board Tab” button in portrait mode, and the “New Schedule Board” navigation panel.
- Fixed a bug where the schedule assistant requirement view wasn't picked up when the schedule assistant was launched from the book button.
- Fixed a bug where an incorrect “End Time” was populated on the booking custom entity when the “Default Booking Duration” had a Null value.
- Fixed a bug where an incorrect “End Time” was populated in the “Create Booking Panel” in Schedule Assistant when creating a booking for a requirement for the second time.
- Fixed a bug where the schedule board crashed when cold loading or creating a new tab in a small width window.
- Fixed a bug where the “Book & Exit” button reappeared after booking a requirement group, and it canceled the bookings.

## 3.12.114.1 - 2023 Wave 2 Early Access update1

**Resource Scheduling Controls:** 1.2.54.232001

**Dataverse:** 4.0.101.1

**Work hours calendar supports multiple recurrences**: Previously, you could only have one work hour recurrence per resource. With the added capability of multiple recurrences, you can now unlock greater flexibility in your resource scheduling to meet business demands further while adjusting to the needs of your workforce for employee retention and job satisfaction.

