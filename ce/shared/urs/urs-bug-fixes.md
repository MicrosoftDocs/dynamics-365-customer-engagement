
## Release schedule

When a new version of Universal Resource Scheduling releases, it becomes available in different geographic regions at different times. The table shows estimates for when the next release will become available in the region of your environment.

For information about other updates to Universal Resource Scheduling, visit the Field Service section of the [Dynamics 365 release plans](/dynamics365/release-plans/).
For information about older versions, see [Version history archive](../../field-service/version-history-archive.md#universal-resource-scheduling).

| Station | Region | Current version | Next version | Scheduled date |
| ------- | ------ | --------------  | -----------  | -------------  |
|**Station 1** |  *First Release*| [3.12.134.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31213425) | TBD | 06/28/2024 |
|**Station 2** |  *South America, Canada, India, France, South Africa, Germany, Switzerland, Norway, Korea* | [3.12.132.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121329) | [3.12.134.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31213425) | 06/21/2024 |
|**Station 3** | *United Arab Emirates, Japan, Asia Pacific, United Kingdom, Oceania* |[3.12.132.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121329) | [3.12.134.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31213425) | 06/28/2024 |
| | *USG* |   [3.12.132.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121329) | [3.12.134.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31213425) | 06/21/2024 |
|**Station 4** |*Europe* |  [3.12.132.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121329) | [3.12.134.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31213425) | 06/21/2024 |
|**Station 5** |  *North America*|[3.12.132.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121329) | [3.12.134.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31213425) | 06/28/2024 |
|**Station 6** | *Government Community Cloud, DoD, China*  |[3.12.132.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121329) | [3.12.134.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31213425) | 06/28/2024 |
| | *Dedicated Scale Groups* | [3.12.131.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121311)  | [3.12.132.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121329)| 06/21/2024 |

>[!NOTE]
>
> - Dates in all regions except Government Community Cloud (GCC), USG, and China are estimates of the next automatic update. Dates in GCC, USG, and China indicate version availability; at this time, there is no automatic update for the GCC, USG, and China regions.
> - For all other regions, while most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

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

