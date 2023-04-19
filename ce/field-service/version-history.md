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

| Station | Region | Current version | Next version | Scheduled date |
| ------- | ------ | --------------  | -----------  | -------------  |
|**Station 1** |  *First Release*| [8.8.89.34](/dynamics365/field-service/version-history#888934)  | TBD | 04/28/2023 |
|**Station 2** |  *South America, Canada, India, France, South Africa, Germany, Switzerland, Norway, Korea*| [8.8.88.54](/dynamics365/field-service/version-history#888854)  |  [8.8.89.34](/dynamics365/field-service/version-history#888934)  | 04/21/2023 |
|**Station 3** | *United Arab Emirates, Japan, Asia Pacific, United Kingdom, Oceania* |[8.8.88.56](/dynamics365/field-service/version-history#888856)  |  [8.8.89.34](/dynamics365/field-service/version-history#888934)  | 04/28/2023 |
| | *USG* |[8.8.88.56](/dynamics365/field-service/version-history#888856)  |  [8.8.89.34](/dynamics365/field-service/version-history#888934)  | 04/21/2023 |
|**Station 4** |*Europe* |[8.8.88.56](/dynamics365/field-service/version-history#888856)  |  [8.8.89.34](/dynamics365/field-service/version-history#888934)  | 05/05/2023 |
|**Station 5** |  *North America*|[8.8.84.16](/dynamics365/field-service/version-history#888416)  | [8.8.88.56](/dynamics365/field-service/version-history#888856) | 04/21/2023 |
|**Station 6** |*Government Community Cloud, DoD, China*  | [8.8.84.16](/dynamics365/field-service/version-history#888416)  | [8.8.88.56](/dynamics365/field-service/version-history#888856) | 04/26/2023 |
| | *Dedicated Scale Groups* |    [8.8.84.16](/dynamics365/field-service/version-history#888416)  | [8.8.88.56](/dynamics365/field-service/version-history#888856) | 04/26/2023 |

>[!NOTE]
>
> - Dates in all regions except Government Community Cloud (GCC), USG, and China indicate the timing of the next automatic update. Dates in GCC, USG, and China indicate version availability; at this time, there is no automatic update for the GCC, USG, and China regions.
> - For all other regions, while most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 8.8.89.34
(Includes Universal Resource Scheduling version [3.12.103.12](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210312) and Resource Scheduling controls version 1.2.43.230971).

- Fixed a bug preventing work orders created from an asset to have their location set to the asset’s functional location.
- NVDA/Narrator now announces status message “Match found” when searching a keyword in the assets and location tab on accounts, assets, and locations.


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

## 8.8.71.55

 This release is a hotfix on Field Service version [8.8.71.41](/dynamics365/field-service/version-history#887141).

- A bug in inspection flows prevented service tasks from being marked completed.

## 8.8.71.41

(Includes Universal Resource Scheduling version [3.12.82.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3128214)).

## 8.8.70.57

This release is a hotfix on Field Service version [8.8.70.26](/dynamics365/field-service/version-history#887026).

- A bug in inspection flows prevented service tasks from being marked completed.

## 8.8.70.26

(Includes Universal Resource Scheduling version [3.12.81.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312813)).

- Fixed a bug preventing changes to currency exchange rates to be reflected in work order products.
- Fixed a bug where inactive asset and functional location records showed in the asset tree view.
- Fixed a bug that allowed service tasks with an inspection to get marked completed when missing responses to mandatory questions.
- Field Service (Dynamics 365) mobile: Added ability to set an Inspection response as read only when a Work Order Service Task is in an inactive state.

## 8.8.69.53

(Includes Universal Resource Scheduling version [3.12.80.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#312809)).

No updates were made to Field Service (Dynamics 365) in this release.

## 8.8.68.25

(Includes Universal Resource Scheduling version [3.12.79.16](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127916)).

- Field Service (Dynamics 365) mobile: Improved accessibility of Booking Status control with Talkback and VoiceOver enabled.
- Field Service (Dynamics 365) mobile: Inspections File Picker will open correctly on the Windows application.
- Field Service (Dynamics 365) mobile : While using the application in online mode, the Product View Control will validate inventory and prompt with an error if trying to use a Product, which doesn't have quantity available. Note this prompt may be a confirmation depending on status of [Use of product out of Stock](/dynamics365/field-service/create-product-or-service#configuration-considerations) setting.
- Add a condition to workflow (GenerateGeofenceWhenBookingIsCreated) to check that the Booking has a Work Order to avoid making unnecessary plugin calls.

## 8.8.67.16

(Includes Universal Resource Scheduling version [3.12.78.23](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127823)).

- Fixed a bug where screen readers were reading "Default value" text boxes as "Question edit" in inspections.

## 8.8.66.27

(Includes Universal Resource Scheduling version [3.12.77.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127718)).

- Fixed a bug that prevented the assets and locations tab from being hidden via customization.

## 8.8.65.10

(Includes Universal Resource Scheduling version [3.12.76.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312761)).

- Field Service (Dynamics 365) mobile offline: Fixed a bug where under some conditions, when multiple bookings are assigned to a work order, the resource wouldn't be able to complete service tasks.

## 8.8.64.13

(Includes Universal Resource Scheduling version [3.12.75.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#312752)).

- Fixed a bug that prevented bookings from being generated via agreement booking setups when the agreement is assigned to "SYSTEM" user.
- Fixed a bug that prevented the checkbox question from focusing properly in the designer when navigating via keyboard.
- Fixed a SurveyControl bug that prevented the inspection template form from being saved with no columns.
- Fixed a bug that prevented deserialization of inspection responses during translation.
- The "Check if forms have unhealthy customizations" rule now provides better warning messages, and will provide an in-app notification by default.

## 8.8.63.22

This release is a hotfix on Field Service version [8.8.63.20](/dynamics365/field-service/version-history#886320).

- Fixed a bug where opening the audit history on a work order would fail and show an error.

## 8.8.63.20

(Includes Universal Resource Scheduling version [3.12.74.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312741)).

- Field Service (Dynamics 365) mobile will now use native mobile device controls when inputting date and time.
- Field Service (Dynamics 365) mobile  will now display optimized mobile keyboards when interacting with fields of specific input type: numeric, decimal, telephone, email, and URL.
- Field Service (Dynamics 365) mobile timeline control will now support uploading files from the mobile device in addition to photos.
- Field Service (Dynamics 365) mobile will no longer show "Start Task Flow" within global commands by default.
- Field Service (Dynamics 365) mobile Windows app will now include map view within the booking calendar control.
- The **Customer** tab of the mobile bookable resource booking form will include a phone number field for the primary contact of the work order service account.
- The **Customer** tab of the mobile bookable resource booking form will support an optional third row of text for street address.

## 8.8.62.26

(Includes Universal Resource Scheduling version [3.12.73.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127325)).

- Field Service (Dynamics 365) mobile: Fixed a bug so booking calendar control will no longer jump to incorrect date when scrolling through bookings on iOS.
- Field Service (Dynamics 365) mobile: Enabled the agenda view on the booking calendar control for tablets and Windows devices.
- Field Service (Dynamics 365) mobile: Added customer phone number field to the out-of-the-box customer details tab on the bookable resource booking and work order forms.
- Updated privacy messages on landing page for Bing Maps.

## 8.8.61.21

This release is a hotfix on Field Service version [8.8.61.14](/dynamics365/field-service/version-history#886114).

- Field Service (Dynamics 365) mobile: Fixed a bug so booking calendar control will no longer jump to incorrect date when scrolling through bookings on iOS.

## 8.8.61.14

(Includes Universal Resource Scheduling version [3.12.72.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#312729)).

- Fixed a bug where a work order’s price list, set from a service account, is cleared when changing work order type.
- Fixed a bug where the price list lookup on agreement invoice product form was showing units instead of price lists.
- Fixed a bug where service durations were rounded up when converting opportunities to work orders.

## 8.8.60.21

This release is a hotfix on Field Service version [8.8.60.18](/dynamics365/field-service/version-history#886018).

(Includes Universal Resource Scheduling version [3.12.71.20](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127120)).

## 8.8.60.18

(Includes Universal Resource Scheduling version [3.12.71.16](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127116)).

- Field Service (Dynamics 365) mobile will correctly show times adjusted for daylight saving time on the booking calendar control.
- Field Service admins will see a notification within Dynamics 365 Field Service if their organization is using Field Service Mobile (Xamarin app). This notification will inform users of the upcoming [end-of-Life](/dynamics365/field-service/activate-fs-mobile-app-license) timeline for Field Service Mobile (Xamarin app).
- Field Service (Dynamics 365) mobile to prevent an intermittent error from displaying after selecting a push notification.

## 8.8.59.26

This release is a hotfix on Field Service version [8.8.59.22](/dynamics365/field-service/version-history#885922).

- Fixed a bug in Field Service (Dynamics 365) mobile to correctly adjust times shown in the booking calendar control for daylight saving time.

## 8.8.59.22

(Includes Universal Resource Scheduling version [3.12.70.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312703)).

- Field Service (Dynamics 365) mobile where quick notes component will now respect maximum character length as defined in `msdyn_text`.

## 8.8.58.9

(Includes Universal Resource Scheduling version [3.12.69.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312691)).

- Fixed bug: Estimated duration in the incident was incorrectly recalculated to zero even if it was originally set to one hour when work order service tasks with estimated       duration of zero are deleted.
- Fixed bug: In the Field Service (Dynamics 365) mobile app, introduced a fix to prevent the booking calendar control from jumping or jittering when scrolling through bookings. 

## 8.8.57.19

(Includes Universal Resource Scheduling version [3.12.68.8](/dynamics365/field-service/field-service-version-history-resource-scheduling#312688)).

- Fixed bug: **Date Window Start** and **Date Window End** fields aren't visible when field service settings are updated to show.
- Fixed bug: Customer can't set **Auto Generate Work Order** to *No* with the agreement business process flow.
- Fixed bug: Case field **Description** wasn't copied to work order instructions fields. 
- Fixed bug: Field Service (Dynamics 365) mobile--under some circumstances, navigating back from a booking to the booking calendar would display previous month instead of current month. 

## 8.8.56.23

(Includes Universal Resource Scheduling version [3.12.67.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312671) (Includes Resource Scheduling controls version 1.2.8.213282)).

- Field Service mobile: Input fields on the **Bookable Resource Booking – Service** form component will now be positioned below the field label, improving readability by allowing the field to fill the horizontal width of the form.

## 8.8.55.10

(Includes Universal Resource Scheduling version [3.12.67.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312671) (Includes Resource Scheduling controls version 1.2.7.213012))

- FS sample data is failing to install due to old version of Package Deployer.  Current work around is to request a trial from [Field Service | Microsoft Dynamics 365](https://dynamics.microsoft.com/en-us/field-service/overview/), which has sample data.
- Bug fix for Work Order estimate SubTotal and Estimate Total Amount not considering the Unit of the product.

## 8.8.54.21

(Includes Universal Resource Scheduling version [3.12.66.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312663)).

- Fixed issue where updating work order product failed for users with limited privileges to the parent work order record.
- Updated the Field Service dispatcher and resource security roles to have the read privileges of `BookingSetupMetadata` set to organization.
- Work order, customer asset, incident type, IoT alert and IoT device tables are now indexed for search by default.
- Removed string 'Work Order unassigned' from Field Service Mobile calendar when a booking is shown on the calendar without a linked work order.

## 8.8.53.36

This release is a hotfix on Field Service version [8.8.53.27](/dynamics365/field-service/version-history#885327).

## 8.8.53.27

(Includes Universal Resource Scheduling version [3.12.65.6](/dynamics365/field-service/field-service-version-history-resource-scheduling#312656)).

- Bug fix to address "Please wait" message not closing for **Convert to WO** on case form.
- Fixed a bug in Field Service (Dynamics 365) mobile to reset travel calculation variables after successful save.

## 8.8.52.127

This release is a hotfix on Field Service version [8.8.52.125](/dynamics365/field-service/version-history#8852125).

(Includes Universal Resource Scheduling version [3.12.64.78](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126478)).

## 8.8.52.125

This release is a hotfix on Field Service version [8.8.52.123](/dynamics365/field-service/version-history#8852123).

- Bug fix where instructions field clears on work order save.

## 8.8.52.123

This release is a hotfix on Field Service version [8.8.52.121](/dynamics365/field-service/version-history#8852121).

- Fixed bug causing issue loading preview of an inspection template in certain scenarios.

## 8.8.52.121 (2021 Wave 2 release)

(Includes Universal Resource Scheduling version [3.12.64.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126446)).

- Added a product deletion validation with dialog when the product is associated with purchase orders that must be deleted before the product can be deleted.
- Better save experience on booking dialog to address save being blocked by pending booking status validations.
- Fix bug where the **Export Selected Records** command wasn't available when multiple items were selected in the work order list view.
- Knowledge articles ("Linked Articles") subgrid has been moved below **Resolutions** subgrid on the bookable resource booking services tab in the Field Service (Dynamics 365) mobile app.

## 8.8.51.168 (2021 Wave 2 early access, update 2)

This release is an update to Field Service 2021 Wave 2 early access version [8.8.51.114](/dynamics365/field-service/version-history#8851114).

(Includes Universal Resource Scheduling version [3.12.62.63](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126263)).

- When there's only one price list per currency on the billing account, we apply that price list to new agreements, work orders, and return merchandise authorizations (RMA). 
- Added a tax code quick create form.
- Fixed issue where estimate duration field on work order incident form isn’t updated correctly when deleting or deactivating child service tasks.
- Added field **Field Service Product Type** to the product quick create form used in the Field Service (Dynamics 365) mobile app.

## 8.8.50.13

(Includes Universal Resource Scheduling version [3.12.52.4](/dynamics365/field-service/field-service-version-history-resource-scheduling#312524)).

- Fixed a bug in Field Service (Dynamics 365) mobile app where bookings weren't always showing in agenda or day view when accessing from work order.
- Fixed a bug where an error was shown while trying to add a "used" work order product in Field Service (Dynamics 365) mobile app while offline.
- Added new entries in Solution Hub to help flag configuration issues with Field (Dynamics 365) Service mobile app.
- Improved the Field Service Solution health rules related to agreements to exclude inactive records from evaluation.

## 8.8.49.21

(Includes Universal Resource Scheduling version [3.12.51.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312511)).

- Corrected an issue where inactive service tasks could still be created as work order service tasks when generating a work order from an agreement booking setup that had an incident type referencing the inactive service task type.
- Resolved a potential null reference error related to work order service tasks that don't have a value in the inspection lookup, which could block the creation of the work order service task.
- Fixed an issue with potentially inconsistent values in the **Total Amount** field of a work order service.
- Improved unclear error messaging on work orders.
- Resolved an issue where, if a work order product or work order service was reparented between work orders, the impacted work orders' **Estimated Subtotal Amount** wasn't accurately recalculated.

## 8.8.51.114 (2021 Wave 2 early access, update 1)

This release is an update to Field Service 2021 Wave 2 early access version [8.8.51.75](/dynamics365/field-service/version-history#885175).

(Includes Universal Resource Scheduling version [3.12.61.21](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126121---2021-wave-2-early-access-update-1)).

- Improved the logic that updates the **Instructions** field on the work order when the service account is updated.
- Field Service (Dynamics 365) mobile calendar will show a text informing when a booking is scheduled without work order assigned.

## 8.8.48.30

This release is a hotfix on Field Service version [8.8.48.23](/dynamics365/field-service/version-history#884823).

- Fixed script error on quick create opportunity form.

## 8.8.48.23

(Includes Universal Resource Scheduling version [3.12.50.27](/dynamics365/field-service/field-service-version-history-resource-scheduling#3125027)).

- Resolved a permissions inheritance issue that could impact users who have a role that worked when users belonged to a team with the same role.
- Fixed an issue related to decimal point number formatting with inspections when using a symbol other than the dot to indicate the decimal place.
- Field Service (Dynamics 365) mobile added the ability to configure custom fields on the mobile booking calendar control.

## 8.8.51.75 (2021 Wave 2 early access)

(Includes Universal Resource Scheduling version [3.12.49.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126043---2021-wave-2-early-access)).

The release is only applied when an environment is opted into Early Access and introduces the [Field Service 2021 Wave 2](/dynamics365-release-plan/2021wave2/service/dynamics365-field-service/planned-features) new and updated features as outlined in the release notes.

In addition, this release also includes the following changes:

- Multi-line text fields in the Field Service (Dynamics 365) mobile app forms will dynamically expand in height to show all content within the field.
- Metadata including image and description is added for Field Service (Dynamics 365) mobile controls.
- Work order in the Field Service (Dynamics 365) mobile app will default to use modern task-completion controls for WOS, WOP, and WOST.
- Minor text-casing changes within tabs of the Field Service (Dynamics 365) Product form.
- Improved views for Incident Type Product, Incident Type Service, and Incident Type Service Task.
- Improved views for Work Order Incident.
- Move Product Inventory to the top of the "Inventory" area within the Field Service app.
- Improved error handling on certain crew related booking scenarios.
- Added plugin validation to enforce that "Product" is required for a work order product.
- Added plugin validation to enforce that "Service" is required for a work order service.
- Corrected an issue where, when updating the currency on an existing work order, the Estimated Subtotal Amount currency wasn't accurately reflecting the update.
- Resolved an issue on order lines in custom apps which could cause the order field not to be populated as expected if the app contained certain customizations.
- Improved tab naming on the Booking Journal entity.
- When deleting or deactivating the last work order service task on a work order incident with duration, the duration of the work order incident updates, appropriately.
- Made keyboard and usability improvements to the Assets and Locations control.
- Resolved an issue where, when cycling a work order product from estimated to used and back multiple times could leave a previous value in unit amount which should have been nullified.

## 8.8.47.21

(Includes Universal Resource Scheduling version [3.12.49.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124918)).

- Resolved an issue where the user-provided Price list value on a work order could be cleared under certain form customization scenarios.
- Corrected a validation issue on work order incidents that was causing users to be blocked from being able to update the work order incident's duration even when there were no work order service tasks on the record that carried a duration.
- Improved error handling on work order service task creation to provide a more specific error under certain circumstances.

## 8.8.46.28

This release is a hotfix on Field Service version [8.8.46.26](#884626).

- Reverted an internal code change to avoid potential performance impact.

## 8.8.46.26

(Includes Universal Resource Scheduling version [3.12.49.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124918)).

- Update Field Service booking form logic to automatically update **Actual Arrival Time** on update of **Start Time** if the pre-change values of **Start Time** and **Actual Arrival Time** were the same.
- When creating a follow-up work order from Field Service (Dynamics 365) mobile, there will be a link created between the source and new work order.
- Field Service (Dynamics 365) mobile calendar control will now show date and time format based on personalized settings.
- Fixed an issue where booking status was showing "undefined" in mobile map control.
- Corrected an issue where, when a work order product was moved from one work order to another, the respective work orders' **Estimated Subtotal Amount** values weren't being recalculated.
- Resolved an issue with purchase order product records that kept the **Product** field active and editable even when the record's status was inactive.
- Fixed an issue with **Enhanced Background Processing** on agreements where an object reference error could occur when updating agreement invoice setup records if the workflow is deactivated.
- Added Field Service health improvements including rule enhancements and new rules.
- Applied performance improvements.

## 8.8.45.47

This release is a hotfix on Field Service version [8.8.45.47](#884547).

- Reverted an incorrect validation on work order incident which caused the **Estimated Duration** field for the work order incident to be read-only if the work order incident contained work order service task records, even if those work order service task records didn't have a defined estimated duration.

## 8.8.45.45

This release is a hotfix on Field Service version [8.8.45.35](#884535).

- Fixed an issue that could cause an error when the legacy address suggestion control was used on custom forms.
- Reverted a previous performance change which under certain circumstances could cause an error to occur.

## 8.8.45.35

(Includes Universal Resource Scheduling version [3.12.48.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124825)).

- Created an **Advanced Settings** flag for *bookingjournal.durationcalculationwithoutseconds.optin=true/false* which, when true, ensures that booking journal duration is calculated without seconds to resolve potential visual discrepancies due to the number of seconds between milestone events.
- Resolved a script error message related to opening the agreement's main form.
- Fixed an incorrect crew booking cascade behavior after an initial crew's bookings were canceled and subsequently rescheduled with a new set of bookings.
- Resolved an issue with share/unshare logic on work orders with multiple bookings to multiple user resources.
- Corrected a localization issue with time formatting in the Field Service mobile agenda and map controls.
- Reverted a previous performance change which under certain circumstances could cause an error to occur.
- Improved Field Service health rule "Process deinitions in draft status."
- Updated the validation for booking's **End Time** and **Actual Arrival Time** to allow them to have equal values.
- Updated booking logic to automatically update **Actual Arrival Time** if **Start Time** is updated and **Actual Arrival Time** isn't updated and where the pre-change **Start Time** is the same as pre-change **Actual Arrival Time**.
- Improved cascading logic for crew bookings to reduce the possibility of data discrepancies and related, downstream errors on shared booking fields, depending on the crew's defined strategy.
- Improved logic which populated the **Actual Arrival Time** to populate the value without seconds which weren't visible to the end user and which increased the potential for validation errors which would be potentially incorrect and unobvious to resolve.
- Fixed an issue where, if customers created agreement booking dates manually after the agreement booking setup create the initial set of agreement booking dates and retriggering the agreement booking setup to create agreement booking dates for an earlier, still-future time range, the agreement wouldn't generate booking dates for the new time range prior to the manually created agreement booking dates.
- Added **Generate Actuals** toggle to Field Service settings which will allow organizations to disable actuals generation in Field Service. Additionally, when disabled, the time entry cost actuals generation field in Field Service settings is hidden since this setting becomes irrelevant.
- Improved Field Service health with additional rules.
- Applied performance improvements.

## 8.8.44.56

This release is a hotfix on Field Service version [8.8.44.52](#884452).

- Reverted an incorrect validation on work order incident that caused the **Estimated Duration** field for the work order incident to be read-only if the work order incident contained work order service task records, even if those work order service task records didn't have a defined estimated duration.

## 8.8.44.52

This release is a hotfix on Field Service version [8.8.44.50](#884450).

- Fixed an issue that could cause an error when the legacy address suggestion control was used on custom forms.

## 8.8.44.50

(Includes Universal Resource Scheduling version [3.12.47.108](/dynamics365/field-service/field-service-version-history-resource-scheduling#31247108)).

This release is a hotfix on Field Service version [8.8.44.45](#884445).

- Reverted a previous performance change that under certain circumstances could cause an error to occur.

## 8.8.44.45

(Includes Universal Resource Scheduling version [3.12.47.98](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124798)).

This release is a hotfix on Field Service version [8.8.44.39](#884439).

- Fixed a permissions issue with the Field Service dispatcher role that could cause an error to be thrown when dragging an onsite requirement onto the schedule board when "Auto Update Booking Travel" is enabled.

## 8.8.44.39

(Includes Universal Resource Scheduling version [3.12.47.62](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124762)).

- Fixed an issue in the new mobile app faced with chart creation for bookable resource booking in customization settings.
- Fixed an issue with changing pricing fields.
- Fixed an issue where default view for customer asset lookup field on work order service task form couldn't be changed.
- Fixed an error in Field Service upgrade with the error saying that the element "tab" has incomplete content.
 -Fixed an issue with subgrids on work order form opening main form instead of quick create form.
- Removed an issue in agreement booking where the default system status was getting automatically updated to a different value.

## 8.8.43.101

This release is a hotfix on Field Service version [8.8.43.97](#884397).

- Reverted a previous performance change that under certain circumstances could cause an error to occur.

## 8.8.43.97

(Includes Universal Resource Scheduling version [3.12.46.64](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124664)).

This release is a hotfix on Field Service version [8.8.43.93](#884393).

- Sometimes, you might not want a booking start time to be set to current time when the booking status is set to "on site". A new setting has been added to Field Service advanced settings to address this. On adding `bookableresourcebooking.disablefsmtravelingcaluclations` set to `true` to the advanced settings, booking start time wouldn't be set to current time.

## 8.8.43.93

This release is a hotfix on Field Service version [8.8.43.77](#884377).

- Fixed a bug that removed the work hours tab from the resource form.

## 8.8.43.77

This release is a hotfix on Field Service version [8.8.43.51](#884351).

- Fixed some performance issues.

## 8.8.43.51

(Includes Universal Resource Scheduling version [3.12.46.21](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124621))

- Fixed an issue where work order product, work order service, or work order service task were getting created for inactive incident type product, service ask and service task     respectively through agreements.
-	Fixed an issue for invoices auto generated from work order that invoice date is sometimes updated to one day more or less than the actual date. A new advanced setting  `Workorder.InvoiceDate.InUserTimeZone=true` has been added, which can be set to fix the issue. 
- Corrected an issue in the case a custom real-time workflow is specified on work order after create to update any of the primary requirement fields. For example, priority where   the requirement failed to reflect the changes.
- Fixed an issue where time-off request gets created incorrectly when the record is created from the portal and also incorrectly reflects in the schedule board.

## 8.8.42.66

(Includes Universal Resource Scheduling version [3.12.45.28](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124528)).

Includes all content from Field Service version 8.8.42.64.

## 8.8.42.64

This release is a hotfix on Field Service version [8.8.42.55](#884255).

- Fixed some performance issues.
- Fixed a bug that removed the work hours tab from the resource form.

## 8.8.42.55

This release is a hotfix on Field Service version [8.8.42.31](#884231).

-	Fixed an issue in Field Service – Dynamics 365 mobile app where end time would be improperly set and cause unexpected time validation errors.

## 8.8.42.31

(Includes Universal Resource Scheduling version [3.12.45.7](/dynamics365/field-service/field-service-version-history-resource-scheduling#312457))

- Frontline workers can view bookings in a map view as well in the new mobile app.
- Fixed an accessibility issue with assets where the **More** button shown as triple dots was getting skipped from tabbing.
- Corrected an issue of `OnSave` event handlers being removed from case form on Field Service installation.  
- Corrected behavior to not throw an error when the field `address1_line1` isn't present in the form.

## 8.8.41.58

This release is a hotfix on Field Service version [8.8.41.53](#884153).

- Fixed an issue in Field Service – Dynamics 365 mobile app where end time would be improperly set and cause unexpected time validation errors.

## 8.8.41.53

This release is a hotfix on Field Service version [8.8.41.28](#884128).

- Added an advanced setting to disable product bundle validation. If user sets ```product.bundle.optout=true``` then user would be able to add new or modify existing product bundle with Field Service type set.

## 8.8.41.28

(Includes Universal Resource Scheduling version [3.12.44.127](/dynamics365/field-service/field-service-version-history-resource-scheduling#31244127))

- Fixed an issue in business process flow being available on a copied agreement.
- Corrected an issue with work order product where estimate total cost wasn't getting updated when quantity was changed.
- Fixed an issue in Field service settings **Inspections** tab where update of "Analytics enabled" and form save was failing.
- Updated to throw a form error if the user is trying to create a product bundle and they have set the **Field Service Product Type** value as product bundles can't be used with Field Service.
- Fixed an issue where notes failed to load in the Field Service (Dynamics 365) mobile app when opened in airplane mode.
- Fixed an issue where upon opening a work order, an error dialog is shown when "Disable Customer asset validation state" is set to *Yes* under Field Service settings.
- Fixed an issue to enable users to change line status of work order product from null to some nonnull value without any error.
- Made performance improvements with system actions invoked during time entry view load.
- Corrected an issue where quick book triggered from the new work order experience wasn't respecting work order's territory.
- Fixed the following issues with inspections:
    -	Selecting a date value from the date control automatically updated the date to one day before the selected date.
    -	In the exported PDF, the question description was hidden.
    -	Entity lookup value getting removed on change of focus.
    -	Enhanced support for Hebrew, Arabic, Japanese characters in the imported JSON.
    -	Fixed an issue with exported inspection JSON where options in checkbox, radio button, and dropdown questions were getting duplicated.
    -	Fixed a performance issue in generating the inspection response pdf.
    -	Fixed an issue with inspection load failure in offline with a lot of attachment questions.

## 8.8.40.141

This release is a hotfix on Field Service version [8.8.40.109](/dynamics365/field-service/version-history#8840109).

-	Fixed a Field Service upgrade issue when the relationship between knowledge article and customer asset/product already existed in the active layer.
-	Fixed a Field Service upgrade issue that was throwing error like ‘Property Inspection is required, but the declaration is missing’

## 8.8.40.109

(Includes Universal Resource Scheduling version [3.12.43.71](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124371))
This version introduces the Field Service 2021 Wave 1 new and updated features outlined as generally available. It also introduces all of the changes from the early access versions of this release. 

This version also introduces the following key capabilities:

- First-run experience to get started setting up Field Service. This new experience can be seen in the **Get Started** section in the sitemap.
- Ability to assign frontline workers with characteristics, territories, and other properties. View or edit the security roles, field security profiles, and mobile offline profiles that are automatically assigned to the frontline worker. Automatically send an email to frontline workers with the link to download the Dynamics 365 Field Service mobile app. Ability to view a list of all your frontline workers and edit their properties on the bookable resource form.
- Field Service's Bing maps capabilities are enabled by default. This update can also be seen in the **Get Started** section.
- Other than the work order form improvements released in early access, more enhancements have been made, including quick-create for work orders and making tax code optional.
- Question types textbox, radio buttons, checkboxes and dropdowns in inspection templates can now have default values also be set before publish.

Fixes include:

- Fixed an issue where work order service form couldn't be loaded properly from subgrid embedded in the custom quick view form of work order when **Work Order Subgrid Records Open as Popups** was enabled.
- Corrected an issue in entitlement application regarding slow performance in form library when there are a large number of accounts.
- Fixed an issue of duplicate agreement booking dates being generated for certain agreement and time zone criteria.

## 8.8.35.44

This release is a hotfix on Field Service version [8.8.35.27](#883527).

- Resolved an issue where, under certain circumstances, work orders with a primary incident type that also executes a synchronous workflow, could result in null fields on the work order and related primary resource requirement.
- Reverted the below change: "Updated behavior where estimated duration from agreement booking setup wasn't carried over to work order. Previously, duration from the resource requirement wasn't being used to calculate total estimated duration in the work order. This behavior has been updated; if no work order service task or incident is present, total estimated duration is obtained from the Requirement. If requirement duration is null, then we get value from booking setup metadata." 

## 8.8.39.142 (2021 Wave 1 early access update)

This release is a hotfix on Field Service version [8.8.39.135](/dynamics365/field-service/version-history#8839135).

- Fixed a Field Service upgrade issue when the relationship between knowledge article and customer asset or product already existed in the active layer.
- Fixed a Field Service upgrade issue that was throwing error: "Property Inspection is required, but the declaration is missing."

## 8.8.39.135 (2021 Wave 1 early access update)

(Includes Universal Resource Scheduling version [3.12.43.71](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124371))
This version introduces the Field Service 2021 Wave 1 new and updated features outlined as generally available. It also introduces all of the changes from the early access versions of this release. 

This version also introduces the following key capabilities:

- First-run experience to get started setting up Field Service. This new experience can be seen in the **Get Started** section in the sitemap.
- Ability to assign frontline workers with characteristics, territories, and other properties. View or edit the security roles, field security profiles, and mobile offline profiles that are automatically assigned to the frontline worker. Automatically send an email to frontline workers with the link to download the Dynamics 365 Field Service mobile app. Ability to view a list of all your frontline workers and edit their properties on the bookable resource form.
- Field Service's Bing maps capabilities are enabled by default. This update can also be seen in the **Get Started** section.
- Other than the work order form improvements released in early access, more enhancements have been made, including quick-create for work orders and making tax code optional.
- Question types textbox, radio buttons, checkboxes and dropdowns in inspection templates can now have default values also be set before publish.

Fixes include:

- Fixed an issue where work order service form couldn't be loaded properly from subgrid embedded in the custom quick view form of work order when **Work Order Subgrid Records Open as Popups** was enabled.
- Corrected an issue in entitlement application regarding slow performance in form library when there are a large number of accounts.
- Fixed an issue of duplicate agreement booking dates being generated for certain agreement and time zone criteria.

## 8.8.39.118 (2021 Wave 1 early access update)

(Includes Universal Resource Scheduling version 3.12.42.5)

The early access update release is only applied when an environment is opted into early access and applies below fixes and changes to the early access release:

- New note-taking experience in Field Service (Dynamics 365) mobile app allows users to quickly attach text, photo, video, and file notes to bookings.
- For inspections:
    -	New capability to enable an inspection to be added to an asset directly for ad hoc inspection scenarios.
    -	New ability to export inspection responses as PDF for a work order service task.
    -	Textbox question can now have a read only value along with a default one.
    -	New inspection setting added to disable automatic numbering of questions.
    -	In matrix (dynamic) control a new setting has been added to allow "Add New" button to be removed.

Additional updates:

-	Fixed an issue with work order service were discount percentage was getting cleared on the form when line status was changed from estimated to used.
-	Corrected an issue to throw an error if an agreement booking incident is created with a customer asset that isn't associated to the service account on the corresponding agreement.

## 8.8.35.27

(Includes Universal Resource Scheduling version [3.12.36.2](./field-service-version-history-resource-scheduling.md#312362))
 
- Fixed an issue where an error was being thrown when clicking on save and close button after creation of time entry record or clicking on save button and going back to time entry grid.
- Fixed an issue with agreement booking setup when the currency in product and services wasn't getting picked up from its associated service account but the base currency in some cases. 
- Fixed an issue in agreement setup wherein the billing account wasn't getting populated correctly for an agreement when the agreement was being created from an account.
- Corrected an issue where all the requirements weren't being canceled once the work order status was changed to closed - canceled.
- Inspections "Export to PDF" now includes support for Japanese text.
- Fixed an issue in work order service task creation with an inspection containing some special characters like '&' in the title.
- Corrected an issue with inspections containing date time type question where the question no longer remained editable after saving the work order service task and user needed to refresh the page.
- Fixed an issue for inspections in Arabic language where uploaded file in a file type question wasn't showing up after form refresh and reopen, and the delete and clear files buttons at the uploaded file were also not working.
- Corrected an issue where update quantity failed for purchase order receipt product.
- Fixed an issue of failure in receiving notifications on iPhone in the Power Apps mobile app after scheduling a work order and when geofence record status is changed.
- Added a new solution health rule to check if the recurrence setting for agreement booking setup is present and is valid.
- Fixed an issue where the help center page was showing up in English instead of Japanese.
- Updated behavior where estimated duration from agreement booking setup wasn't carried over to work order. Previously, duration from the resource requirement wasn't being used to calculate total estimated duration in the work order. This behavior has been updated; if no work order service task or incident is present, total estimated duration is obtained from the Requirement. If requirement duration is null, then we get value from booking setup metadata. 

## 8.8.39.37 (2021 Wave 1 early access)

(Includes Universal Resource Scheduling version 3.12.40.15)

The release is only applied when an environment is opted into Early Access and introduces the [Field Service 2021 Wave 1](/dynamics365-release-plan/2021wave1/service/dynamics365-field-service/planned-features) new and updated features as outlined below for availability in early access:

- Work order resolution information capture
- Improved Field Service usability with major enhancements for the  work order form, the account form, and changed a number of other customer-facing behaviors across a number of interaction points within the solution.
-Replaced address suggestion experience with the new address control.
- Embedded knowledge management.
- For inspections:
    -	Multilingual support for an inspection with a new tab 'Translation' in inspection designer.
    -	Added filter condition support in entity lookup to reduce the lookup results.
    -	Added compact layout option to show more questions in screen.
    -	Added dependent entity lookup to improve filtering of results using another question in same inspection.
    -	Export an inspection as json and import an inspection json in another environment which is useful for moving long inspections.
    -	Rename of 'Inspections' sitemap entry to 'Inspection Templates.'
    -	Added a new button to publish an inspection template and create a service task type in one go.
    -	Added a new setting to enable online only scenarios to attach files and images larger than the current 3 mb limit. For this a setting has been added to Field Service             Settings under the 'Advanced Settings' field as ```inspection.allowuploadlargefilesonline=false```. To enable files more than 3 mb in size to be added when online, false can be changed to true.

In addition, this release also includes the following changes:

- Tax code has been made optional so that user isn't forced to enter data that isn't capable of supporting the complexity of the tax scenarios.
- Recently a new flag for ```workorderincidentitem.statecodeupdate.optout``` had been introduced. The dependency on this flag has now been removed. The ```workorderincident``` items state code would be updated only when new state code is different from old state code.
- Fixed and issue with work order product that estimate discount % is cleared on the form when using a decimal.
- Corrected an error with work order product that discount % is cleared on the form when line status is changed from estimated to used.
- Fixed an issue of missing details tab in the sales hub order.
- Corrected a behavior in time entry form that on save end date gets auto populated even if both end date and duration fields are made optional and null.
- Updated view name 'Purchase Order Lookup View' to 'Purchase Order.'
- A change has been made with work order incident duration to be read only when it has child service tasks with estimated durations so it matches the total durations of its child service tasks.
- Fixed an error while saving product and service based lines to quote.
- Updated the error string to be more descriptive of the issue when trying to save a user, account, contact, or work order if geocode action is disabled. 
- Fixed an error of missing dialog to reparent pop-up in work order service task on adding non related customer asset when customer asset validation state and suggest reparenting customer asset are enabled.
- Optimized sync filters for entities like account, contact, and product to improve performance in model driven mobile app. 
- Improved error message when a knowledge article is opened in offline mode on mobile.
- Fixed an issue of missing "Assets and Locations" and "Properties" tabs in an asset form.

## 8.8.34.63

(Includes Universal Resource Scheduling version [3.12.35.6](./field-service-version-history-resource-scheduling.md#312356))

Includes all content from Field Service version 8.8.34.18

## 8.8.34.18

(Includes Universal Resource Scheduling version [3.12.35.5](./field-service-version-history-resource-scheduling.md#312355))

- Fixed an issue regarding register devices command showing up in an asset form even though the environment isn't configured to use IoT.
- Fixed an issue with device ID field getting cleared when the asset form is refreshed.
- Fixed an issue in response generation after clicking on "Send Command" for an IoT device.  
- Added date time support in inspections matrix control.
- Fixed an error opening Dynamics 365 Remote Assist if the support contact contains a user in Japanese.
- Fixed a console error when opening a customer asset quick create form from work order form due to absence of functional location.
- Corrected an issue in the population of *Time To Promised* and *Time From Promised* fields when the work order is created with an SLA.
- Fixed an issue with taxable while creating agreement from account record type.
- Fixed an issue in the creation of time entry from a bookable resource booking wherein a resource or work order wasn't getting populated.
- Fixed an issue in the Field Service model-driven app regarding icons for some entities not showing up in the sitemap.

## 8.8.33.99

(Includes Universal Resource Scheduling version [3.12.34.92](./field-service-version-history-resource-scheduling.md#3123492))

Includes all content from Field Service version 8.8.33.61

## 8.8.33.98

(Includes Universal Resource Scheduling version [3.12.34.60](./field-service-version-history-resource-scheduling.md#3123460))

Includes all content from Field Service version 8.8.33.61

## 8.8.33.61

(Includes Universal Resource Scheduling version [3.12.34.4](./field-service-version-history-resource-scheduling.md#312344))

- Allow technicians using the mobile app to quickly create follow up work orders.
- Optimize unwanted calls for IoT entities during form loads of work order and case.
- Corrected an issue with connected IoT device not showing up in connected device subgrid of the asset.
- Performance improvements in Connected Field Service and IoT asset.
- Removed deadlock errors on product inventory in the work order generation.
- Corrected an issue with resource requirement preferences to show up with requirements.
- Corrected batch size related error in work order sharing and unsharing.
- Fixed an issue in work order creation when rating value is null for a characteristic associated with agreement booking incident.
- Corrected privilege errors when trying to save work order and child records if there's no read privilege to Field Service settings.
- Improved the error handling when work order closure and the unit cost field of work order product isn't filled. 
- Fixed the behavior to set custom default view for customer asset lookup control on the agreement booking incident form.
- Corrected an issue of missing "New" button on time entry form in IE 11.
- Fixed an error when saving work order resulting from an issue in the deletion of requirement resource preferences.
- For the error that service tasks get reactivated even when tasks are completed and work order is completed, a new flag ```workorderincidentitem.statecodeupdate.optout=true``` can be added in the Field Service settings page in the "Advanced Settings" field, under the "Other" tab. The new flag can be added to any flags already present and delineated by a new line.
- Corrected an issue in geocode command button not being visible in offline sometimes.
- Excluded a sales related deprecated web resource.
- Corrected an issue with  service tasks not showing up on mobile while offline.
- Fixed an issue with add and edit options being hidden for assets and functional locations.
- Corrected an issue in billing account population when creating a work order from account.
- Improved the usability of the matrix control in inspections.

## 8.8.32.61

This release is a hotfix on Field Service version 8.8.32.59

-	Improved error handling when a work order is closed.
-	Fixed a performance issue in IOT caused by a recent change.

## 8.8.32.59

(Includes Universal Resource Scheduling version [3.12.33.8](./field-service-version-history-resource-scheduling.md#312338)) 

### Field Service

- For inspections:
    - Added the ability to capture photos for the file upload question type in Field Service Mobile.
    - Added barcode scan option to the textbox control. 
    - Added a new control called "Matrix (Dynamic)" to the toolbox. Use this control to add a grid of questions to which you can add more rows dynamically while performing the inspection.
    - Increased the maximum character limit for the description of a question to 1000 characters.
    - Improved the "Export as pdf" behavior to include the new grid control and the questions hidden behind branching logic in the PDF generated for an inspection.
    - Added a new field "Depends on" to entity look up to filter lookup options based on response to another entity lookup question.
- Corrected booking journal duration calculation to be more accurate.
- Resolved an issue: upon reassigning a booking from a crew type resource to user type resource, the **Crew** and **Crew Member** fields wouldn't clear.
- Improved the behavior of "Generate Agreement Booking Dates" workflow instances to cancel if the parent workflow deactivates.
- Updated the customer asset quick create form to make it customizable.
- Improved pricing calculation of a work order product to ensure accuracy regardless of the user’s privileges.
- Corrected an issue to enable more than 5000 work order products to associate to a work order.
- Resolved an issue in calculation of **Total Amount** in work order service when **Duration To Bill** is 0.
- Corrected an issue when loading the inspection designer for Italian orgs.
- Reverted a previous change for an issue: resource preferences wouldn't copy to the non-primary requirements introduced by an incident type requirement group.
- Corrected an issue: an error for "The given key wasn't present in the dictionary" error could pop up while saving a priority form.
- Resolved a false failure issue of Field Service Health rule that checked for web resources.

### Field Service mobile app

- Created new controls for the work order service task, work order product, and work order service subgrids on the booking and work order form in Field Service Mobile. These controls were designed to give mobile technicians a quick and easy way to mark items complete or used and to have at-a-glance visibility into what still remains.
- Improved mobile offline filter handling for the time-off request table.

## 8.8.31.60

(Includes Universal Resource Scheduling version [3.12.32.1](./field-service-version-history-resource-scheduling.md#312321)) 

- Improved error handling and messaging when the work order table is missing a booking setup metadata record. Previously, this scenario would throw a generic object reference error, which didn't help troubleshoot the issue.
- Enabled viewing related agreement booking incident records from a customer asset. Previously, this relationship wasn't visible from the customer asset.
- Improved conversion of an opportunity into a work order. The conversion from opportunity with opportunity products, now maintains the defined opportunity product’s **Sequence Number** as **Line Order** in the work order’s work order products.
- Corrected an issue with the agreement invoice setup’s invoice generation process, which could cause a generic error when the agreement invoice date tried to generate an invoice if the agreement invoice setup contained invoice products.
- Updated the solution to ensure that multi-resource work orders using requirement groups respect the resource preferences defined on the related service account for all requirements generated against the work order.
- Resolved an issue in a solution patch that inappropriately removed on-save handlers from the case table.
- Corrected an issue that caused any update of a work order product record to update the work order product’s **Exchange Rate**, even if there were no updated currency-related fields, after a change to related currency’s exchange rate value.
- Enhanced the logic on agreement booking date records that could cause unnecessary background processes to fire causing a momentary block from being able to update the related agreement booking setup. This logic improved to reduce the scenarios under which it would try to trigger this background process, removing scenarios where the agreement booking date’s **Booking Date** was update to a time further in the future. When this value pushes out further, the background process doesn't need to be triggered.
- Improved mobile offline filter handling for the warehouse table.
- Updated the Field Service Health rule name from “Waiting workflow instances owned by disabled user accounts” to “Waiting workflow instances owned by disabled users.”
- This release introduces the solution components for the improvements to the [Dynamics 365 Supply Chain Management integration](./supply-chain-field-service-integration.md#purchase-orders) as [outlined for availability in Wave 2, 2020](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/integration-dynamics-365-supply-chain-management). These integrations, the metadata, and their required logical changes are only introduced when [dual-write](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/dual-write-overview) is enabled on your environment.

## 8.8.30.113

This release is a hotfix on Field Service version [8.8.30.103](#8830103).

- Resolved an issue with agreement invoice setups introduced during early access that caused an error in the primary invoice date and invoice generation process, which could stop invoice generation from agreements.
- Corrected a JavaScript error when trying to create a work order through the quick create form.
- Resolved an issue with inspection name value being empty in the parsed inspection record tables.

## 8.8.30.103

(Includes Universal Resource Scheduling version 3.12.31.50)
This version introduces the [Field Service 2020 Wave 2](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/planned-features) new and updated features outlined as generally available. It also introduces all of the changes from the early access versions. In addition, it introduces the following updates:

- Resolved an issue that had the potential to cause timeouts based on resource location updates from Field Service Mobile.
- Improved update logic to a work order product's currency field to ensure that non-currency related changes didn't appear as also making an update to the currency field.
- Corrected an issue: under certain circumstances, the system could autogenerate duplicate agreement booking date records when updating **Auto Generate Work Order**.
- Corrected behavior where it was possible to have the value of **Date Window Start** reverted on save if a user followed a specific record update pattern and got a form validation.
- Resolved an issue: if a user provided a name to a work order incident record that was different than the automatically provided value, then deactivated and reactivated the record, the name would revert to the automatic value.
- Resolved an issue that impacted certain solution update scenarios based on conflicting settings to the CanCreateAttributes attribute in the unit, unit group, and price list item entities.
- Improved form logic to allow for manual time entry record saving when an org has both Field Service and Project Operations installed.
- Improved the save/save and close behaviors of a record from within a modal form dialog (MFD) to ensure that the contextual record would automatically refresh so a user can see the immediate impacts of their efforts. An example scenario: a user creates a new booking from a work order, the booking form will now open in an MFD by default. When the user saves and closes the booking form, the contextual work order will refresh. The work order's status will change from "unscheduled" to "scheduled" immediately.
- Enabled the "Customer Asset Quick Create" and "Asset Work Order Quick View Form" forms to be customizable; initially, they were released as non-customizable.
- Corrected a problem that could present when bulk editing work order records.

## 8.8.29.333 (2020 Wave 2 early access update)

(Includes Universal Resource Scheduling version 3.12.30.11)

The release is only applied when an environment is opted into early access and introduces the [Field Service 2020 Wave 2](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/planned-features) new and updated features.

In addition, this release includes the following changes:

- Resolved an issue with agreement invoice setups introduced during early access that caused an error in the primary invoice date and invoice generation process that could stop invoice generation from agreements.

## 8.8.26.24

(Includes Universal Resource Scheduling version [3.12.25.5](./field-service-version-history-resource-scheduling.md#312255)) 

- Corrected an issue: under certain circumstances, the **Discount %** in work order product form is automatically cleared on save.
- Resolved an issue with agreement booking dates: when the booking dates are manually altered, the work orders weren't getting auto generated as expected relative to the **Generate Work Order Days in Advance** value of the related agreement booking setup.
- Improved handling for the sharing and unsharing behavior of the booking resource booking when the target user is disabled.
- When exchange rate on a currency is changed, any subsequent changes to a work order service record would result in the exchange rate for that record being updated. It should only be recalculated if a currency-related field is updated.
- Improved handling of the account’s merge functionality when one of the target accounts has a related Agreement where taxable is "No."
- Improved handling of the account’s merge functionality when one of the target accounts has a related RMA where taxable is "No."
- When using tab to navigate away from the **Estimate Total Amount** field on a work order service record after making an update, the system was inappropriately throwing the error "Enter an amount between $0.00 and $1,000,000,000.00."
- Corrected a bug: when the work order service’s **Line Status** was changed from "Estimated" to "Used," the **Estimated Discount %** field wasn't getting copied to the **Discount %**.

## 8.8.29.226 (2020 Wave 2 early access update)

(Includes Universal Resource Scheduling version 3.12.30.11)

The release is only applied when an environment is opted into early access and introduces the [Field Service 2020 Wave 2](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/planned-features) new and updated features.

In addition, this release includes the following changes that have the potential to change the existing system behavior or interface:

- Added quick create forms for all new asset properties-related entities to the Field Service model-driven app.
- Corrected an issue with a missing space in the "Field Service Activities" tab header for the account entity for the Field Service Mobile model-driven app.
- Improved the customer asset form to ensure that the IoT related tabs are displayed after the other form tabs.
- Removed the property logs option from the related menu from the customer asset form.
- Updated the property log display values to respect user settings for date and time.
- Corrected travel calculation logic for the Field Service Mobile model-driven app to ensure that, when the booking is set to in progress, if there was no **Estimated Travel Duration** the system will update the **Actual Arrival Time** and won't immediately increase total duration.

## 8.8.29.165 (2020 Wave 2 early access)

(Includes Universal Resource Scheduling version 3.12.29.5)

The release is only applied when an environment is opted into early access and introduces the [Field Service 2020 Wave 2](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/planned-features) new and updated features as outlined for availability in early access:

- Embedded Power BI Dashboard for key Field Service metrics
- Improved work order metrics
- Asset hierarchy and functional location
- Usability improvements for key Field Service subgrid as dialogs
- Enhanced skills-based matching in Resource Scheduling Optimization
- Predictive technician travel time
- Travel outside of working hours
- Enhanced work hours calendar for requirements
- Connected Field Service on the Dynamics 365 Field Service mobile app
- Field Service inspections
- Technician time tracking on Dynamics 365 Field Service mobile app
- Usability improvements for the field technician booking form
- Calendar view for booking work orders

In addition, this release includes the following changes that have the potential to change the existing system behavior or interface:

- Improved logic around agreement booking dates, which have a button to manually “Generate Work Order.” Previously, this button was available when a work order had already been generated. In this release, we improved the logic associated with this button to ensure this button wasn't available if the work order had already been generated.
- Corrected the display position of the map control in the “Location” tab for the work orders in the Field Service Mobile app’s default work order form. Previously, the map control appeared between the latitude and longitude fields. It now appears above these fields.
- When an incident type is applied to a work order, it results in the automatic creation of a work order incident, which can automatically create work order products, work order services, and work order service tasks. These records are associated to the work order and work order incident. If the primary incident customer asset field referenced a customer asset, all resulting records would also be related to the same customer asset. The release improves the logic for customer asset association on these records when a work order incident’s customer asset is updated. Previously, if the customer asset on a work order incident was updated, it wouldn't update the related work order products, work order services, or work order service tasks. It will now update these records appropriately, assuming the customer asset value of the child records matched the pre-change value of the work order incident.
- Corrected a poor system behavior: when updating a work order service record’s line status from “Estimated” to “Used,” the estimated discount percent value wasn't autopopulated into the discount percent field. This value will now autopopulate per the estimated value when the line is set to “Used.”
- Improved the error message on a purchase order receipt product when a user tries to change the quantity or unit after a related purchase order bill has been created.
- Improved display handling of the agreement and invoice subgrids on the account forms where a user may not have permissions to these related records. Previously, these subgrids would display with an error about the user’s permissions; however, now, these subgrids won't show on the form in such cases of insufficient permissions.
- Resolved an issue with the Field Service resource role’s permissions. Previously, this role was missing the “Append To” privilege on customer asset, which caused issues when trying to create customer assets.
- Improved the subgrid name for work order products on the default work order form for the Field Service Mobile app.
- Fixed an issue where the value for customer asset wasn't being copied into work order products, work order services, and work order service tasks that were created from agreement booking products, agreement booking services, and agreement booking service tasks that weren't related to an agreement booking incident. This association will now flow down, as expected.
- Added the "Field Service - Resource" role to the new app module for Field Service Mobile.
- Corrected some consistency issues with the labeling for “Work Hours Templates.”
- Adding a notification on agreement booking setups and agreement invoice setups to highlight that related work orders, invoices, and dates won't generate when users create or updates the agreement subrecords when the parent agreement’s System Status isn't active.
- Improved work order validation of the latitude and longitude fields to ensure that, if either value is populated, both values are populated, and that the values are valid.
- Improved warning messages on the booking form. It isn't advised to use a work order’s booking through more than one booking lifecycle. It should only go through the lifecycle once (scheduled -> traveling -> in-progress -> complete). Some organizations that reuse a single booking through more than one lifecycle began receiving a form notification that, while allowed, such practices aren't advised. This warning previously mentioned time entry generation anytime it was displayed; it will now only mention time entry generation when the environment is configured to autogenerate time entries to avoid confusion.
- Enhanced logic for work order service task naming if the work order service task was created from a work order incident as a result of the incident type’s incident service task. In such cases, if the incident service task has a name, the work order service task’s name will come from the incident service task; previously, the work order service task’s name was always the name of the related service task type. If the incident service task’s name is blank, the work order service task’s name will default to the service task type’s name.
- Removed unnecessary code that enforced that the booking and journal type fields on a booking journal would be editable under certain circumstances. These fields will now behave the way the rest of the fields on the booking journal behave.
- On the case entity, when Field Service is installed, there's a ribbon button to “Convert to WO.” Previously, this button was in an undiscoverable location. This button has been moved to be more discoverable.
- Improved Field Service Mobile’s user experience for tablet users to ensure proper column width, improved quick create experience, and improved subgrid usability on the booking’s Service tab.
- Changed behavior on the agreement booking service tasks. Previously, when changing the value of the related task type, the description field would always be cleared. Now it will only be cleared if the new value for task type has an overriding value; otherwise, the value won't be cleared by default.
- Updated the name for the “My Open Resource Bookings (Field Service Information)” view to simply “Bookings” for optimal use and display in Field Service Mobile.
- Removed some fields from the default configuration of the booking entity’s default form for the Service tab to improve usability of Field Service Mobile.
- Replaced the address control used in the Field Service Mobile forms for the account and work order entities with a new control optimized for mobile use.
- Enhanced the automatic copy logic for related resource preference records onto work orders created for the same account. Previously, when these records were copies, resource preferences of type “Must Choose From” on the account weren't being copied to the work order. They'll now be copied, as well.
- Improved usability of the booking’s service tab in Field Service Mobile to show five records in the subgrids, by default, instead of just two, as was the previous behavior.
- Minor improvement to tax calculation on the work order record to ensure that rounding rules resulted in a consistent value between the work order’s tax calculation and the invoice’s tax calculation. Under certain circumstances, previously, these values could be inconsistent by at the second decimal due to rounding differences.
- Updated the taxable field in Field Service Mobile forms for work order, work order service, and work order product to use a new toggle control for simplified mobile usability.
- Improved all default views for work order product, work order service, and work order service task to swap the Product, Service, and Task Type fields respectively with the Name field to improve default view usability.
- Enhanced validation on the agreement entity when setting the price list to ensure that the currency set on the price list is the same currency set on the related billing account. Previously, this validation wasn't present, which led to the potential for downstream errors on work order generation since the work order expects currency consistency between these two fields. Now, this validation is present at the agreement, ensuring agreement creation and update will protect downstream operations of the work order.
- Removed incorrect defaulting logic on creation of work order service, work order product, or work order service task records that weren't related to a work order incident. Previously, these records would be associated to the primary incident’s customer asset; however, they'll now be left blank by default as they aren't necessarily related to the primary incident’s customer asset.

## 8.8.25.30

(Includes Universal Resource Scheduling version [3.12.24.5](./field-service-version-history-resource-scheduling.md#312245)) 

- Includes all content from Field Service version 8.8.25.29

## 8.8.25.29

(Includes Universal Resource Scheduling version [3.12.24.4](./field-service-version-history-resource-scheduling.md#312244)) 

- Corrected an issue on bookable resource booking forms where the **Estimated Arrival Time** field can appear as if it has been edited immediately after save (when it hasn’t been), making the form behave as if it had unsaved changes.
- Improved logic to allow for customizations to the work order form where the primary incident type is removed from the form to ensure that the out-of-the-box form logic has a null check for the **Primary Incident Type** field.
- Resolved an issue with missing localization strings on the IoT alert and IoT device entities, which could cause a script error.
- Fixed an issue on update of agreement booking incident, which produced an error if there was a related agreement booking service task with a null estimated duration.
- Resolved a problem with the agreement copy function that failed to copy agreements if there were deactivated agreement booking setup or agreement invoice setup records related to the agreement. The copy function will now successfully copy active records and ignore inactive records.
- Added a new Field Service health rule that will highlight agreement booking setup and agreement invoice setup records on which the latest workflow instance had failed which could keep expected work orders and invoices from being generated. Once detected, the rule also provides a button to resolve failed workflow instances.

## 8.8.24.54

(Includes Universal Resource Scheduling version [3.12.23.71](./field-service-version-history-resource-scheduling.md#3122371)) 

- Includes all content from Field Service version 8.8.24.17

## 8.8.24.17

(Includes Universal Resource Scheduling version 3.12.23.26)

- Corrected a null reference error based on work order product form customizations to better handle when certain fields are removed from the form.
- Resolved an issue with the incident type duration suggestions feature that produced an error when a user clicked “Recalculate Suggestions” for large query results.
- Fixed an issue with agreement update, which produced a "Nullable object must have a value" error on updating end date of an agreement whose end date is null.
- Removed the following BPFs from the Field Service Mobile app module: case to work order, lead to opportunity sales, opportunity sales, phone to case.
- Improved logic to allow for customizations on work order creation from an agreement if there are customizations in place to automatically create more resource requirement records.
- Improved Field Service’s missing form libraries rule in Solution Health Hub to improve the rule description.
- Enhanced logic to in the opportunity quick create form to respect scenarios when an environment sets the “Account” field as business required to ensure that Field Service form logic doesn't set the field as optional.

## 8.8.23.85

(Includes Universal Resource Scheduling version 3.12.22.9)

- Improved crew booking validations, which ensure that the booked crew has at least one defined crew member for the date on which the booking is being created.
- Improved descriptions in upgrade scripts to make the script more comprehensible by an administrator by documenting deprecated upgrade script steps to minimize confusion.
- Fixed an issue that left the status null when created a new geofence, which could cause geofence events to not be created.
- Repaired a Field Service upgrade issue caused by a script that, when appropriate, created requirement group records. If the requirement group's name was too long, the script and upgrade would fail.
- Fixed an issue on the contact entity's geo code functionality that caused a script error if "Auto Geo-Code" was set to "No" in Field Service settings.
- Corrected an incorrect agreement booking setup recurrence validation error for "Too many days in month." Under certain circumstances, this error was thrown inappropriately.
- Resolved an issue with duplicate section and tab IDs in Connected Field Service that caused issues when trying to uninstall the solution.
- Corrected a null reference issue in Connected Field Service when loading the device summary control on the IoT alert form.

## 8.8.22.58

- Includes release of [Field Service (Dynamics 365) mobile](mobile-power-app-overview.md), a new mobile app for technicians built on the Power Platform. As part of this release, administrators will see a new app called "Field Service Mobile" in the list of apps.
- The following [Field Service 2020 Wave 1](/dynamics365-release-plan/2020wave1/dynamics365-field-service/planned-features) features in GA and Preview planned are included in this release:
  - Incident type AI-based suggestions (preview)
  - IoT alerts AI-based suggestions (preview)
  - Use Power Automate flows (preview)
  - Combined asset capabilities across Dynamics 365 Supply Chain Management and Field Service
  - Integration with Dynamics 365 Supply Chain Management
  - Intune support for Field Service Mobile
  - Next generation schedule board experience (preview)
  - Enhanced work hours calendar for resources
  - Requirement dependency for efficient workflow
  - Resource scheduling dashboard
  - Integrated technician time tracking
  - Technician time-capture precision
- This release also includes all fixes included in the [8.8.14.328 EA package](#8814328-2020-wave-1-early-access).
- Corrected some scenarios where the geo code function was called when "Auto Geo Code Addresses" was set to no.
- Corrected scenario where msdyn_payment was null on payment details; this scenario was improperly throwing the following error "The payment amount can't be less than total amount applied to invoices."
- Fixed an issue where price list not changing based on changes to work order's billing account. For organizations experiencing this issue, a fix is available through the "Advanced Settings" field in the Field Service settings entity, to not introduce a potentially disruptive change at this time. Copy the following string into the hidden field:  

> *workorder.pricelist.usefrombillingaccount*

- Resolved an issue: the time-only control misinterpreted daylight savings time for certain timezones.
- Fixed an issue where form logic wasn't respecting environment configurations on the Lead entity. Customers can now set fields, like "Company," to be business required and the Field Service form logic will respect the setting.
- Corrected an issue on work order service: the "Total Amount" wasn't respecting the "Discount" when used in an editable grid.
- Removed the validation on bookable resource that required each bookable resource's name to be unique.
- Fixed an error on the quote booking product: under certain circumstances, the system would inaccurately throw the following error: "Enter an amount between $0.00 and $922,337,203,685,477.00."
- Fixed an issue on the work order quick create from account where the billing account didn't populate correctly.
- Improved customer asset lookup experience from work order incident to ensure the form respects when organizations define their own default lookup view.
- Resolved issue: in certain timezones, agreement booking setup's preferred start time wasn't appropriately setting on agreement booking dates' booking date and the  autocreated bookable resource booking based on the defined "Preferred Start Time."
- Fixed a scenario where, if an environment sets the default value of msdyn_linestatus to "Used," work order service creation would fail.
- Added a null reference check to correct an issue if work order service's "Duration to Bill" wasn't set.

## 8.8.12.2

- Fixed an issue where the "Generate Work Order" button from advanced find on agreement booking dates wasn't displaying and working properly.
- "Due Date" field value on invoices generated from agreement invoice date is one day early. For organizations experiencing this issue, a fix is available through the "Advanced Settings" field in the Field Service settings entity. Copy the following string into the hidden field:  

> *autogeneration.usetimezone.invoiceduedate=true*

- Resolved a bug on deactivated work order service records throwing an error when reactivated, "Object Reference Not Set to Instance of an Object."
- Corrected an unhandled error in geocoding that failed if the address contained an extra comma.
- For organizations that would prefer that work orders generated from cases open in the same window, this action can now be controlled through "Advanced Settings" field in the Field Service settings entity. Copy the following string into the hidden field if you would prefer work orders to open in the same tab in the same window:  

> *casetoworkorderwindowbehavior=0*

>[!Note]
> The "Advanced Settings" field on Field Service settings is not added to the entity form by default.  

## 8.8.11.19

**Available in all regions by April 2020**.

- Fixed an issue where agreement booking date generation fails when agreement is owned by a team.
- Resolved an issue where Field Service client-side logic fails when using contact form while in offline.
- Resolved purchase order product form customization issues where:
  - If an organization removed the "Quantity Received" field from the purchase order product, they would be unable to create a new purchase order product record.
  - Work order and warehouse values don't autopopulate if the fields are removed from the form.
- When using quick create form for a work order from an account, fixed an issue where some of the fields that were expected to autopopulate weren't being populated.
- If the map control is removed from the work order form, it can't be added back. The control has been locked to the form so that it can't be removed from the form.
- Issue where the primary incident type record of a deactivated work order couldn't be deactivated; added a validation check to only allow the work order incident record to be deactivated when work order is deactivated.

## 8.8.14.328 (2020 Wave 1 early access)

For more information about early access features, visit the [opt-in instructions](/power-platform/admin/opt-in-early-access-updates).

- Before a work order product or work order service is set to "Used," the total amount isn't calculated.
  - Previously, under some circumstances, a work order service line in estimated status could have a total amount value, despite not being set to used. This could result in challenges when looking at the work order's total amount and potential downstream invoice discrepancies.
  - This also required an improvement to the work order product and work order service views to ensure we show both the estimated total amount and the total amount so users could understand the value in context of the line's current status.
- On the agreement booking/invoice setup, booking and invoice generation time (respectively) could be incorrect if the user who owns the agreement is in a time zone +1 or higher from UTC.
  - Going forward, the system will consider the agreement booking/invoice setup owner's time zone when generating date records.
  - This will now mean that agreement booking date and agreement invoice dates will be generated correctly and consistently, relative to the owner's time zone.
  - Note: Be sure to validate that all existing agreement booking setups and agreement invoice setups owned by users +1 or greater than UTC are correctly configured to generate invoices and work orders per organizational expectations.
- On tax codes, when "Act As Tax Group" is "Yes," tax rate percentage and items taxable should be hidden.
  - When a tax code is configured to act as a tax group, the tax rate and items taxable should be hidden from the user as these values come from the applicable related tax code details for a tax group.
  - Further, on the tax code, when "Act as Tax Group" is "Yes," a form notification will now show on the form to highlight that tax code details are required for taxes to apply when you use the tax code.
- On the opportunity entity's main form, account shouldn't be mandatory if order type isn't "Service-Maintenance Based."
  - When creating an opportunity, the account field should only be mandatory if the order type is "Service-Maintenance Based."
- On the agreement booking/invoice setup, if a user's time zone was GMT +1 or higher, it autocalculated the default range of recurrence to one day before agreement start/end.
  - When defining an agreement booking/invoice setup as a user in a time zone +1 or higher from UTC, then the range of recurrence on the record's recurrence string was always one day before the start/end date of the related agreement's start/end date.
  - Will now calculate the default recurrence range appropriately based on the user creating the record's time zone.
- Deprecated quote booking setup's margin tab and calculation logic.
  - Formerly, on the quote booking setup form, there was a tab that attempted to calculate the margin of the proposed booking setup.
  - Under certain circumstances, this margin calculation could be incorrect.
  - Due to the limited usage of the feature and the complexity involved in supporting every permutation of possible configuration with corrected calculations, removed the tab and related calculation logic.
- Introduced better validation messaging if a user tries to increase the quantity on a quote line for service-based lines.
- Prevent agreement booking service task from saving when task type lookup field is null.
  - If an organization customized the agreement booking service task entity to make the task type optional, it resulted in downstream errors when trying to generate work order service tasks.
  - As such, registered a synchronous plugin that will prevent the creation of an agreement booking service task if task type is null.
- Fixed typo in error message when an incident type requirement group is related to an empty requirement group template.
- Prevent work order service from saving when the service lookup field is null.
  - If an organization customized the work order service entity to make the service optional, could result in downstream errors.
  - As such, registered a synchronous plugin that will prevent the creation of a work order service if service is null.
- Improved the warning notification message on the "Geo Code Address" button when you disable Bing Maps.

## 8.8.10.44

**Available in all regions**.

- Agreement booking service task's name is overwritten when the related task type changes.
- Can't complete booking that has travel time if the travel charge type on the related work order's account is null.

## 8.8.9.84

- Script error when you remove account field from the opportunity quick create form.
- On creation of account record based on postal code functionality, service territory repeats autopopulated, even after the customer removes the initial autopopulated value.
- Consistency issue in Field Service's Solution Health Hub rule naming when referring to SDK message processing steps.

## 8.8.8.135

- Work order plugin error for SLA KPI instance.

## 8.8.8.50

- Improve error messages when the user attempting an action is missing "Field Service Setting" read privilege.
- Form logic always turns incident type to not required based on work order type, regardless of field settings.
- Bookings aren't shared consistently to all resources on multi-booking work orders.
- Deleting and recreating a booking associated with a work order changes the shared users of booking.
- TypeError: Can't read property "getDefaultView" when requested by contact field removed from RMA form.
- Agreement invoice product currency set to base currency - the currency should set to agreement's price list currency.

## 8.8.7.47

- Removal of territory from work order doesn't remove from non-primary related requirements.
- Inappropriate command buttons shown for opportunity, quote, and order product and service-based lines sub grids.
- Field Service resource privilege exception on create and save of time-off request.

## 8.8.3.533

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/09/10/enhancements-and-bug-fixes-for-field-service-version-8-8-3-533/)

## 8.8.2.160

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/08/11/enhancements-and-bug-fixes-for-field-service-version-8-8-2-160/)

## 8.8.1.45

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/07/enhancements-and-bug-fixes-for-field-service-version-8-8-1-45/)

## 8.8.0.88

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/06/10/release-notes-for-field-service-version-8-8-0-88/)

## 8.7.0.105

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/06/release-notes-for-field-service-version-8-7-0-105/)

## 8.6.0.274

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/04/06/release-notes-for-field-service-version-8-6-0-274/)

## 8.5.0.345

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/03/07/release-notes-for-field-service-version-8-5-0-345/)  

## 8.4.0.338

[Read a blog post about this update.](https://blogs.msdn.microsoft.com/crm/2019/02/11/release-notes-for-field-service-version-8-4-0-338/)

## 8.3.0.255

[Read a blog post about this update.](https://blogs.msdn.microsoft.com/crm/2018/12/21/release-notes-for-field-service-version-8-update-release-3/)

## 8.2.0.286

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/11/08/release-notes-for-field-service-version-8-update-release-2/)

## Field Service on-premises

| Version | Status | Details |
| --- | --- | --- |
| 7.x | Latest available. Minimum platform version 9.0 for install. | [Link](/dynamics/s-e/) |
| 6.x | Not supported | |

## Important notes

### Field Service Online end-of-life for v7.x and earlier

[Version history notes for v7.x](https://cloudblogs.microsoft.com/dynamics365/it/product/field-service/field-service-7/)

Online versions of Field Service v7 and earlier are [end of life](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/17/announcing-end-of-life-for-field-service-online-legacy-versions-by-february-2020/) and no longer supported. Microsoft won't service support requests for these versions of Field Service until you upgrade to the latest version.

You can upgrade legacy versions of Field Service directly from the admin center.

This upgrade is significant and has many potentially disruptive changes including data model, mobile, and interface changes. Review the [Field Service playbook](https://aka.ms/fsuciupgrade) for more information. Prior to applying the upgrade to production, be sure to first test the upgrade on a non-critical, production-like environment.

All customers should upgrade all legacy versions of Field Service and Project Service Automation to the latest solution versions as soon as possible.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
