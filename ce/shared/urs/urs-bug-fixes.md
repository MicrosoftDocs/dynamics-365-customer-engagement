### Version 3.12.9.76 - April 2020 Wave 1 Early Access 

- Fixed a performance issue when upgrading from Field Service version 7.x to version 8.x.  
- Fixed an issue with printing the Get Driving Directions action on the Schedule Board.  
- When Quick Scheduling is used to schedule on an entity which doesn’t have an associated Resource Requirement, results were always shown in UTC Timezone, which is now fixed and the results should always be shown in User Timezone if there is no Requirement calendar. 
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

### Version 3.12.3.9

- The one hour offset issue for the bookings created on the schedule board is fixed in the Brazil daylight savings time.
- The caching issue with the schedule assistant’s default availability view setting is set to Board is now fixed.
- When a new booking is created on the days view of the schedule board, the board will be refreshed automatically.
- Resource requirement map pins are loaded, only when the map view is opened on the filter panel of the schedule board. 
- Fixed an upgrade issue due to bad data in the filter values. 

### Version 3.12.2.114

- When the schedule board map view is opened, the map automatically zooms out to show all the map pins. 
- The resource look up is displayed on the schedule board in Arabic.
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

### Version 3.12.1.158

- Workflows can be triggered when resource requirements are created with any allocation method.
- When upgrading URS from version 2.x to version 3.x, resource filters on the schedule board tabs are preserved. 

### Previous versions of Resource Scheduling

To see older bug fixes, see the following links to blog posts:

- [3.7.0.70](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/14/enhancements-and-bug-fixes-in-universal-resource-scheduling-urs-version-3-7-0-70/)
- [3.6.0.18](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/release-notes-for-universal-resource-scheduling-version-3-6-0-18/)
- [2.4.11.59](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/14/enhancements-and-bug-fixes-in-universal-resource-scheduling-urs-version-2-4-11-59/)
- [2.4.10.56](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/release-notes-for-universal-resource-scheduling-version-2-4-10-56/)
- [2.1](https://cloudblogs.microsoft.com/dynamics365/it/2017/05/19/universal-resource-scheduling-solution-for-dynamics-365-update-6-1/)
