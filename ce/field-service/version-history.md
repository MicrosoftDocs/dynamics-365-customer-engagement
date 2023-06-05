---
title: "Dynamics 365 Field Service version history | MicrosoftDocs"
description: Version history for Dynamics 365 Field Service
ms.date: 03/14/2023
ms.topic: article
author: jshotts
ms.author: jasonshotts
---

# Dynamics 365 Field Service version history

## Release schedule

When a new version of Dynamics 365 Field Service releases, it becomes available in different geographic regions at different times. Use the table below to see when the next release will become available in the region of your environment.

For information about other updates to Field Service, visit the [Dynamics 365 release plans](/dynamics365/release-plans/).
For information about older versions, see [Version history archive](version-history-archive.md#field-service).

| Station | Region | Current version | Next version | Scheduled date |
| ------- | ------ | --------------  | -----------  | -------------  |
|**Station 1** |  *First Release*| [8.8.93.28](/dynamics365/field-service/version-history#889328)  | TBD | 06/16/2023 |
|**Station 2** |  *South America, Canada, India, France, South Africa, Germany, Switzerland, Norway, Korea*| [8.8.92.27](/dynamics365/field-service/version-history#889227)  | [8.8.93.28](/dynamics365/field-service/version-history#889328) | 06/02/2023 |
|**Station 3** | *United Arab Emirates, Japan, Asia Pacific, United Kingdom, Oceania* |[8.8.92.27](/dynamics365/field-service/version-history#889227)  | [8.8.93.28](/dynamics365/field-service/version-history#889328) | 06/09/2023 |
| | *USG* |  [8.8.92.27](/dynamics365/field-service/version-history#889227)  | [8.8.93.28](/dynamics365/field-service/version-history#889328) | 06/02/2023 |
|**Station 4** |*Europe* |[8.8.91.36](/dynamics365/field-service/version-history#889136)  | [8.8.92.27](/dynamics365/field-service/version-history#889227) | 06/02/2023 |
|**Station 5** |  *North America*|[8.8.91.36](/dynamics365/field-service/version-history#889136)  | [8.8.92.27](/dynamics365/field-service/version-history#889227) | 06/09/2023 |
|**Station 6** |*Government Community Cloud, DoD, China*  |[8.8.91.36](/dynamics365/field-service/version-history#889136)  | [8.8.92.27](/dynamics365/field-service/version-history#889227) | 06/09/2023 |
| | *Dedicated Scale Groups* |[8.8.89.38](/dynamics365/field-service/version-history#888938)  | [8.8.91.36](/dynamics365/field-service/version-history#889136) | 06/02/2023 |

>[!NOTE]
>
> - Dates in all regions except Government Community Cloud (GCC), USG, and China indicate the timing of the next automatic update. Dates in GCC, USG, and China indicate version availability; at this time, there is no automatic update for the GCC, USG, and China regions.
> - For all other regions, while most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 8.8.93.28
(Includes Universal Resource Scheduling version [3.12.106.7](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210525) and Resource Scheduling controls version 1.2.46.231371).

- Added graceful handling of addresses that are too long to be converted to latitude and longitude values.
- Fixed a bug preventing time entry approval when a resource has a null hourly rate and the work pay type has a non-zero hourly markup.
- Inspections: Fixed a bug where the incorrect UTC time offset was applied when writing Date Time inspection response data to Dataverse. Note this may have the side effect of surfacing in the UI the values that were previously incorrectly written.
- Dynamics 365 Field Service Mobile: Updated the Quick Notes control to have verbose save failures in instances when the control is misconfigured and/or duplicate copies of the control is added to a single form. 

## 8.8.92.27
(Includes Universal Resource Scheduling version [3.12.105.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210525) and Resource Scheduling controls version 1.2.45.231281).

-	Fixed a problem preventing IoT device visualization from initializing.
-	Command lookup on the IoT Command form now correctly appears as optional.
-	Fixed a problem with console errors when a user interacts with a work order that has a service or billing account that they do not have read permissions for.
- Fixed a bug in the inspections designer which prevented access to all attributes when an entity lookup contained more than 50 items. 
- Field Service (Dynamics 365) Mobile: Updated PowerApps Component Framework controls to adopt recent API changes related to nested linked entities.


## 8.8.91.36
(Includes Universal Resource Scheduling version [3.12.104.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210414) and Resource Scheduling controls version 1.2.44.231111).

- Improved performance of booking creation.
- Dynamics 365 Field Service Mobile: Updated solution package to ship standard forms for msdyn_bookableresourcebookingquicknote.

## 8.8.89.38
This release is a hotfix on Field Service version [8.8.89.34](/dynamics365/field-service/version-history#888934).

(Includes Universal Resource Scheduling version [3.12.103.21](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210321)).

- Fixed a bug that prevented saving records after an address change when Auto Geocode Address and Enable Address Suggestions are enabled in Field Service settings.

## 8.8.89.34
(Includes Universal Resource Scheduling version [3.12.103.12](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210312) and Resource Scheduling controls version 1.2.43.230971).

- Fixed a bug preventing work orders created from an asset to have their location set to the asset’s functional location.
- NVDA/Narrator now announces status message “Match found” when searching a keyword in the assets and location tab on accounts, assets, and locations.

## 8.8.88.62
This release is a hotfix on Field Service version [8.8.88.56](/dynamics365/field-service/version-history#888856).

(Includes Universal Resource Scheduling version [3.12.102.24](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210324)).

- Fixed a bug that prevented saving records after an address change when Auto Geocode Address and Enable Address Suggestions are enabled in Field Service settings.

## 8.8.88.56
This release is a hotfix on Field Service version [8.8.88.54](/dynamics365/field-service/version-history#888854).

- Fixed a bug preventing some EA customers using the NTE control from being able to upgrade to GA.
- Fixed a bug preventing the asset and functional location trees from loading when tens of thousands of assets exist in the system.

## 8.8.88.54 (2023 wave 1 release)
(Includes Universal Resource Scheduling version [3.12.102.17](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210217---2023-wave-1-release) and Resource Scheduling controls version 1.2.42.230871).

-	Use the [Not-to-exceed feature](/dynamics365/field-service/work-order-not-to-exceed) to ensure cost and price expectations on work orders are met every time.
-	[Organize your provided services based on trades](/dynamics365/field-service/trades#configure-trade-coverages), and set up trade coverages based on which services you provide to groups of customers.
- Use global search to quickly search for and navigate to bookings.
- New price and cost summaries have been added to work orders to track financials. Enable or disable cost tracking in field service settings. Cost information and cost amount cards on work order products and services are now controlled by the Calculate Cost toggle in Field Service settings. Organizations that disabled the Calculate Price toggle will have these sections appear on work order products and services unless they turn off the Calculate Cost toggle.
- Field Service (Dynamics 365) Mobile: [AsyncOnSave](/power-apps/developer/model-driven-apps/clientapi/reference/events/form-onsave#asynchronous-event-handler-support) is enabled for Field Service Mobile.
- Field Service (Dynamics 365) Mobile: Booking agenda has options for week & month view on iOS and Android tablets and the Windows application.
- Field Service (Dynamics 365) Mobile: Updated survey creator control to exclude survey meta data from telemetry.

## 8.8.87.35 (2023 Wave 1 early access, update1)

(Includes Universal Resource Scheduling version [3.12.101.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121013---2023-wave-1-early-access-update-1) and Resource Scheduling controls version 1.2.41.230631).

This release is an update to Field Service 2023 Wave 1 early access version [8.8.87.7](/dynamics365/field-service/version-history#88877).

- Use the [Not-to-exceed feature](/dynamics365/field-service/work-order-not-to-exceed) to ensure cost and price expectations on work orders are met every time.
- [Organize your provided services based on trades](/dynamics365/field-service/trades#configure-trade-coveragess), and set up trade coverages based on which services you provide to groups of customers.

- Use global search to quickly search for and navigate to bookings.
- New price and cost summaries have been added to work orders to track financials. Enable or disable cost tracking in settings.
- Field Service (Dynamics 365) Mobile: Replaced [deprecated Input Number](/power-platform/important-changes-coming#model-driven-app-controls-deprecation) control with standard text input field.

Note: There is a known issue where an incident type's trade is applied to work orders when trade is disabled. 

## 8.8.84.16

This release is a hotfix on Field Service version [8.8.84.13](/dynamics365/field-service/version-history#888413).

-  Field Service (Dynamics 365) Mobile: Updated survey creator control to exclude survey meta data from telemetry.

## 8.8.84.13
(Includes Universal Resource Scheduling version [3.12.98.7](/dynamics365/field-service/field-service-version-history-resource-scheduling#312987) and Resource Scheduling controls version 1.2.38.230543).

-  No updates were made to Dynamics 365 Field Service in this release.

## 8.8.83.23

This release is a hotfix on Field Service version [8.8.83.21](/dynamics365/field-service/version-history#888321).

-  Field Service (Dynamics 365) Mobile: Updated survey creator control to exclude survey meta data from telemetry.

## 8.8.83.21

This release is a hotfix on Field Service version [8.8.83.19](/dynamics365/field-service/version-history#888319).

(Includes Universal Resource Scheduling version [3.12.97.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129718) and Resource Scheduling controls version 1.2.37.230406).

-  No updates were made to Dynamics 365 Field Service in this release.

## 8.8.83.19
(Includes Universal Resource Scheduling version [3.12.97.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#312979) and Resource Scheduling controls version 1.2.37.230406).

- Fixed a bug that prevented opportunities to be converted to work orders when the account is indirectly linked through the opportunity contact.
- Fixed a bug preventing work order Completed On time from being set when the work order status changed to posted and at least one open booking is cancelled.
- Field Service (Dynamics 365): Android app now supports image multi-select when uploading to inspections.
- Field Service (Dynamics 365): Fixed a bug which was preventing export of inspection response to PDF when the inspection template included a question with date/time format.
- Field Service (Dynamics 365): Fixed a bug on the Windows application where in some locales the “get directions” link did not pass the supported lat/long format for local version of Bing Maps.
- Field Service (Dynamics 365): Fixed a bug to delay work order form save if Duration is updated without corresponding Duration to Bill field update.


## 8.8.87.7 (2023 Wave 1 early access)

(Includes Universal Resource Scheduling version [3.12.100.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121002---2023-wave-1-early-access) and Resource Scheduling controls version 1.2.40.230251).

The release is only applied when an environment is opted into Early Access and introduces the Field Service 2023 Wave 1 features.

- The asset and functional location tree view control will better support having assets with children located elsewhere. Assets at a different functional location than their parent asset will now show as both a child asset and as a child of the functional location with info icons calling out the nuances.

## 8.8.82.52
This release is a hotfix on Field Service version [8.8.82.35](/dynamics365/field-service/version-history#888235).

(Includes Universal Resource Scheduling version [3.12.96.38](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129638)).

 - No updates were made to Dynamics 365 Field Service in this release.



## 8.8.82.35
(Includes Universal Resource Scheduling version [3.12.96.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129625)) and Resource Scheduling controls version 1.2.36.230171).

- Greatly improved the performance of the asset and functional location tree control for large hierarchies.

## 8.8.81.89

This release is a hotfix on Field Service version [8.8.81.81](/dynamics365/field-service/version-history#888181).

- Fixed an issue where the functional location and asset tree control would sometimes display the wrong hierarchy.

## 8.8.81.81

(Includes Universal Resource Scheduling version [3.12.92.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129214)) and Resource Scheduling controls version 1.2.35.223541).

- Significant performance improvements of the asset and functional location tree control to support large hierarchies.
- Fixed a bug causing work orders to be left in a partially deleted state when deletion failed.
- Field Service (Dynamics 365) mobile: AsyncOnSave has been enabled for Work Order validations.
- Field Service (Dynamics 365) mobile: Fixed a bug where an unexpected error could occur in the mobile app if msdyn_incidedenttyperesolution table is removed from the mobile offline profile.
- Field Service (Dynamics 365) mobile: Fixed a bug in read-only inspections that a multi-line text box expands correctly.

## 8.8.80.48

(Includes Universal Resource Scheduling version [3.12.92.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129214)) and Resource Scheduling controls version 1.2.34.223411).

- Fixed a bug causing RTV substates to be lost after editing.
- Fixed a problem preventing inventory transfer search from filtering results.

## 8.8.79.32

This release is a hotfix on Field Service version [8.8.79.18](/dynamics365/field-service/version-history#887918).

- Field Service (Dynamics 365) mobile: Fixed keyboard visibility when interacting with entity lookup within an inspections question. 
 
## 8.8.79.18

(Includes Universal Resource Scheduling version [3.12.92.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129214) and Includes Resource Scheduling controls version 1.2.32.222981).

- Field Service (Dynamics 365) mobile: When exporting a PDF of inspections responses, images which were uploaded as part of the inspection will be sized to fit the page and maintain their original aspect ratio.
- Fixed a bug preventing the deletion of work order service tasks with the deletion of work orders
- Fixed a bug showing inactive functional locations on work order location lookups.

## 8.8.78.41

This release is a hotfix on Field Service version [8.8.78.23](/dynamics365/field-service/version-history#887823).

Field Service (Dynamics 365) mobile:  fixed a bug impacting Field Service **<8.8.78.23>** which intermittently resulted in an error when accessing the Booking Status control.

## 8.8.78.23

(Includes Universal Resource Scheduling version [3.12.92.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129214)).

- Fixed a bug that prevented showing the **View all** button during reflow of frontline worker setup.
- Fixed a bug that prevented accessing the **Play** button via keyboard on Getting Started.
- Sales Tax Code now shows quick create of taxable work orders.
- Field Service (Dynamics 365) mobile: Added support for advanced filtering of date/time on the calendar control.

## 8.8.77.41

(Includes Universal Resource Scheduling version [3.12.91.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#312912)).

   - Fixed a bug causing an error when loading an existing knowledge article from work order or product forms.
   - Field Service (Dynamics 365) mobile: When an Offline enabled mobile application has network access, it will now fetch data from the server if the record is not found in the mobile offline profile. If network access is not available to the device requesting a record not found in the offline profile, a more specific error message will be shown to the user informing them of the missing table.
   - Field Service (Dynamics 365) mobile: Improvements to device memory management while using the mobile application.
   - Field Service (Dynamics 365) mobile: Fixed a bug which was preventing the agenda view from being available on certain tablet models.
   - Field Service (Dynamics 365) mobile: Improved an error message that was shown when trying to mark a product as used from the service task sub-grid while the product is inactive.
   - Field Service (Dynamics 365) mobile: Fixed a bug which was preventing Inspections - File Type question from selecting multiple files.

   
## 8.8.76.55

This release is a hotfix on Field Service version [8.8.76.42](/dynamics365/field-service/version-history#887642).

(Includes Universal Resource Scheduling version [3.12.90.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#312902)).

(Includes Resource Scheduling controls version 1.2.30.222771).

No updates were made to Field Service (Dynamics 365) in this release.

## 8.8.76.42

(Includes Universal Resource Scheduling version [3.12.90.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#312902)).

-	Fixed a bug in which the duration field is not copied from a requirement group template associated with an incident type to the work order.
- Field Service (Dynamics 365) mobile: Tabs will persist on screen while scrolling down within a form, allowing a user to navigate to a new tab without scrolling to the top of the form. This feature is enabled by default for the Field Service Mobile app module and needs to be [enabled via App Settings for custom app modules](mobile-power-app-faq.yml#how-do-i-enable-wave-2-2022-enhancements-for-command-bar-and-form-tabs-for-my-field-service-mobile-application).
- Field Service (Dynamics 365) mobile: When exporting inspections response to PDF, questions marked as not visible will not be exported and visible in the PDF. 

## 8.8.75.142(2022 Wave 2 early access, update2)

This release is an update to Field Service 2022 Wave 2 early access version [8.8.75.59](/dynamics365/field-service/version-history#887559).

(Includes Universal Resource Scheduling version [3.12.88.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312883---2022-wave-2-early-access-update-2)).

## 8.8.74.34

(Includes Universal Resource Scheduling version [3.12.85.11](/dynamics365/field-service/field-service-version-history-resource-scheduling#3128511)).

- Fixed a bug preventing setting visibility of a question through two rules in Inspection logic.
- Fixed a bug preventing the create new button from appearing on Time Entry Screen when Offline Profile is enabled.
- Field Service (Dynamics 365) mobile: Improved device memory usage when accessing the Work Order Service Task Inspection control.
- Field Service (Dynamics 365) mobile: Fixed a bug so form validation won't run when the form is clean. This will reduce error “Validations have been restarted in the background because of inconsistent validation data.”

## 8.8.73.63

(Includes Universal Resource Scheduling version [3.12.84.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312843)).

- Fixed a bug that showed a null exception when the EstimatedDuration field wasn't on work order incident form.
- Fixed an accessibility issue with high contrast mode on Connected Field Service device readings that prevented the show/hide controls from being displayed.
- Fixed a bug preventing device IDs from being set on Connected Field Service devices during a form refresh.
- Fixed a bug that prevented setting Lat/Lon when a functional location’s address is partially updated.
- Fixed a bug on inventory adjustment product form that created errors when the inventory transfer field is removed through customization.
- Bing maps will now be enabled by default for non-EU regions, and resource scheduling will connect to maps by default.
- Field Service (Dynamics 365) mobile: Added an app setting to enable 2022 Wave 2 changes to the mobile command bar. Changes include removing commands (Delete & Process) when not applicable to the user role, moving some underused commands to the end of the command list, and moving the command bar to top of the screen on tablet devices.

## 8.8.75.59 (2022 Wave 2 early access, update1)

This release is an update to Field Service 2022 Wave 2 early access version [8.8.75.36](/dynamics365/field-service/version-history#887536).

(Includes Universal Resource Scheduling version [3.12.87.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312873---2022-wave-2-early-access-update-1)).

- Fixed a bug in reflowing the connected field service tree control that prevented the ‘more options’ button and ‘show assets’ checkbox from being visible.

## 8.8.72.55

This release is a hotfix on Field Service version [8.8.72.27](/dynamics365/field-service/version-history#887227).

- A bug in inspection flows prevented service tasks from being marked completed.

## 8.8.72.27

(Includes Universal Resource Scheduling version [3.12.83.6](/dynamics365/field-service/field-service-version-history-resource-scheduling#312836)).

- Fixed a bug that showed inactive location records in the asset & location tree view.
- Fixed a bug on work order form load that prompted users with insufficient permissions to read service account details.
- Fixed a bug that prevented units from being populated on a new inventory adjustment through the quick create form.
- Fixed a bug in the initialization of work order functional location entity references that caused dependent customizations to fail.

## 8.8.75.36 (2022 Wave 2 early access)

(Includes Universal Resource Scheduling version [3.12.86.7](/dynamics365/field-service/field-service-version-history-resource-scheduling#312867---2022-wave-2-early-access)).

The release is only applied when an environment is opted into Early Access and introduces the [Field Service 2022 Wave 2](/dynamics365-release-plan/2022wave2/service/dynamics365-field-service/planned-features) new and updated features as outlined in the release notes.

In addition, this release also includes the following changes:

- Fixed a bug where estimated duration wasn't set on work order services created from agreements.
- Fixed a bug where resource pay type wasn't reflected in actuals when Time Cost Actuals Source is set to 'Work Order Time Entry Approval'.
