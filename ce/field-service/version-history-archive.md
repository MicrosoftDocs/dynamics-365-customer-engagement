---
title: Version history archive
description: Archive of earlier release notes of the Dynamics 365 Field Service version history.
ms.date: 05/25/2023
ms.topic: conceptual
author: m-hartmann
ms.author: mhart
---

# Version history archive

This article contains release notes from earlier release waves for the following apps and solutions:

- [Dynamics 365 Field Service (web and mobile)](#dynamics-365-field-service)
- [Universal Resource Scheduling](#universal-resource-scheduling)
- [Resource Scheduling Optimization Add-in](#resource-scheduling-optimization-add-in)

## Dynamics 365 Field Service

For release notes and version history of the current release wave, see [Dynamics 365 Field Service version history](version-history.md).

### Earlier release waves

#### 8.8.71.55

 This release is a hotfix on Field Service version [8.8.71.41](/dynamics365/field-service/version-history#887141).

- A bug in inspection flows prevented service tasks from being marked completed.

#### 8.8.71.41

(Includes Universal Resource Scheduling version [3.12.82.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3128214)).

#### 8.8.70.57

This release is a hotfix on Field Service version [8.8.70.26](/dynamics365/field-service/version-history#887026).

- A bug in inspection flows prevented service tasks from being marked completed.

#### 8.8.70.26

(Includes Universal Resource Scheduling version [3.12.81.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312813)).

- Fixed a bug preventing changes to currency exchange rates to be reflected in work order products.
- Fixed a bug where inactive asset and functional location records showed in the asset tree view.
- Fixed a bug that allowed service tasks with an inspection to get marked completed when missing responses to mandatory questions.
- Field Service (Dynamics 365) mobile: Added ability to set an Inspection response as read only when a Work Order Service Task is in an inactive state.

#### 8.8.69.53

(Includes Universal Resource Scheduling version [3.12.80.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#312809)).

No updates were made to Field Service (Dynamics 365) in this release.

#### 8.8.68.25

(Includes Universal Resource Scheduling version [3.12.79.16](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127916)).

- Field Service (Dynamics 365) mobile: Improved accessibility of Booking Status control with Talkback and VoiceOver enabled.
- Field Service (Dynamics 365) mobile: Inspections File Picker will open correctly on the Windows application.
- Field Service (Dynamics 365) mobile : While using the application in online mode, the Product View Control will validate inventory and prompt with an error if trying to use a Product, which doesn't have quantity available. Note this prompt may be a confirmation depending on status of [Use of product out of Stock](/dynamics365/field-service/create-product-or-service#configuration-considerations) setting.
- Add a condition to workflow (GenerateGeofenceWhenBookingIsCreated) to check that the Booking has a Work Order to avoid making unnecessary plugin calls.

#### 8.8.67.16

(Includes Universal Resource Scheduling version [3.12.78.23](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127823)).

- Fixed a bug where screen readers were reading "Default value" text boxes as "Question edit" in inspections.

#### 8.8.66.27

(Includes Universal Resource Scheduling version [3.12.77.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127718)).

- Fixed a bug that prevented the assets and locations tab from being hidden via customization.

#### 8.8.65.10

(Includes Universal Resource Scheduling version [3.12.76.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312761)).

- Field Service (Dynamics 365) mobile offline: Fixed a bug where under some conditions, when multiple bookings are assigned to a work order, the resource wouldn't be able to complete service tasks.

#### 8.8.64.13

(Includes Universal Resource Scheduling version [3.12.75.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#312752)).

- Fixed a bug that prevented bookings from being generated via agreement booking setups when the agreement is assigned to "SYSTEM" user.
- Fixed a bug that prevented the checkbox question from focusing properly in the designer when navigating via keyboard.
- Fixed a SurveyControl bug that prevented the inspection template form from being saved with no columns.
- Fixed a bug that prevented deserialization of inspection responses during translation.
- The "Check if forms have unhealthy customizations" rule now provides better warning messages, and will provide an in-app notification by default.

#### 8.8.63.22

This release is a hotfix on Field Service version [8.8.63.20](/dynamics365/field-service/version-history#886320).

- Fixed a bug where opening the audit history on a work order would fail and show an error.

#### 8.8.63.20

(Includes Universal Resource Scheduling version [3.12.74.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312741)).

- Field Service (Dynamics 365) mobile will now use native mobile device controls when inputting date and time.
- Field Service (Dynamics 365) mobile  will now display optimized mobile keyboards when interacting with fields of specific input type: numeric, decimal, telephone, email, and URL.
- Field Service (Dynamics 365) mobile timeline control will now support uploading files from the mobile device in addition to photos.
- Field Service (Dynamics 365) mobile will no longer show "Start Task Flow" within global commands by default.
- Field Service (Dynamics 365) mobile Windows app will now include map view within the booking calendar control.
- The **Customer** tab of the mobile bookable resource booking form will include a phone number field for the primary contact of the work order service account.
- The **Customer** tab of the mobile bookable resource booking form will support an optional third row of text for street address.

#### 8.8.62.26

(Includes Universal Resource Scheduling version [3.12.73.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127325)).

- Field Service (Dynamics 365) mobile: Fixed a bug so booking calendar control will no longer jump to incorrect date when scrolling through bookings on iOS.
- Field Service (Dynamics 365) mobile: Enabled the agenda view on the booking calendar control for tablets and Windows devices.
- Field Service (Dynamics 365) mobile: Added customer phone number field to the out-of-the-box customer details tab on the bookable resource booking and work order forms.
- Updated privacy messages on landing page for Bing Maps.

#### 8.8.61.21

This release is a hotfix on Field Service version [8.8.61.14](/dynamics365/field-service/version-history#886114).

- Field Service (Dynamics 365) mobile: Fixed a bug so booking calendar control will no longer jump to incorrect date when scrolling through bookings on iOS.

#### 8.8.61.14

(Includes Universal Resource Scheduling version [3.12.72.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#312729)).

- Fixed a bug where a work order’s price list, set from a service account, is cleared when changing work order type.
- Fixed a bug where the price list lookup on agreement invoice product form was showing units instead of price lists.
- Fixed a bug where service durations were rounded up when converting opportunities to work orders.

#### 8.8.60.21

This release is a hotfix on Field Service version [8.8.60.18](/dynamics365/field-service/version-history#886018).

(Includes Universal Resource Scheduling version [3.12.71.20](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127120)).

#### 8.8.60.18

(Includes Universal Resource Scheduling version [3.12.71.16](/dynamics365/field-service/field-service-version-history-resource-scheduling#3127116)).

- Field Service (Dynamics 365) mobile will correctly show times adjusted for daylight saving time on the booking calendar control.
- Field Service admins will see a notification within Dynamics 365 Field Service if their organization is using Field Service Mobile (Xamarin app). This notification will inform users of the upcoming [end-of-Life](/dynamics365/field-service/activate-fs-mobile-app-license) timeline for Field Service Mobile (Xamarin app).
- Field Service (Dynamics 365) mobile to prevent an intermittent error from displaying after selecting a push notification.

#### 8.8.59.26

This release is a hotfix on Field Service version [8.8.59.22](/dynamics365/field-service/version-history#885922).

- Fixed a bug in Field Service (Dynamics 365) mobile to correctly adjust times shown in the booking calendar control for daylight saving time.

#### 8.8.59.22

(Includes Universal Resource Scheduling version [3.12.70.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312703)).

- Field Service (Dynamics 365) mobile where quick notes component will now respect maximum character length as defined in `msdyn_text`.

#### 8.8.58.9

(Includes Universal Resource Scheduling version [3.12.69.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312691)).

- Fixed bug: Estimated duration in the incident was incorrectly recalculated to zero even if it was originally set to one hour when work order service tasks with estimated       duration of zero are deleted.
- Fixed bug: In the Field Service (Dynamics 365) mobile app, introduced a fix to prevent the booking calendar control from jumping or jittering when scrolling through bookings. 

#### 8.8.57.19

(Includes Universal Resource Scheduling version [3.12.68.8](/dynamics365/field-service/field-service-version-history-resource-scheduling#312688)).

- Fixed bug: **Date Window Start** and **Date Window End** fields aren't visible when field service settings are updated to show.
- Fixed bug: Customer can't set **Auto Generate Work Order** to *No* with the agreement business process flow.
- Fixed bug: Case field **Description** wasn't copied to work order instructions fields. 
- Fixed bug: Field Service (Dynamics 365) mobile--under some circumstances, navigating back from a booking to the booking calendar would display previous month instead of current month. 

#### 8.8.56.23

(Includes Universal Resource Scheduling version [3.12.67.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312671) (Includes Resource Scheduling controls version 1.2.8.213282)).

- Field Service mobile: Input fields on the **Bookable Resource Booking – Service** form component will now be positioned below the field label, improving readability by allowing the field to fill the horizontal width of the form.

#### 8.8.55.10

(Includes Universal Resource Scheduling version [3.12.67.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312671) (Includes Resource Scheduling controls version 1.2.7.213012))

- FS sample data is failing to install due to old version of Package Deployer.  Current work around is to request a trial from [Field Service | Microsoft Dynamics 365](https://dynamics.microsoft.com/en-us/field-service/overview/), which has sample data.
- Bug fix for Work Order estimate SubTotal and Estimate Total Amount not considering the Unit of the product.

#### 8.8.54.21

(Includes Universal Resource Scheduling version [3.12.66.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312663)).

- Fixed issue where updating work order product failed for users with limited privileges to the parent work order record.
- Updated the Field Service dispatcher and resource security roles to have the read privileges of `BookingSetupMetadata` set to organization.
- Work order, customer asset, incident type, IoT alert and IoT device tables are now indexed for search by default.
- Removed string 'Work Order unassigned' from Field Service Mobile calendar when a booking is shown on the calendar without a linked work order.

#### 8.8.53.36

This release is a hotfix on Field Service version [8.8.53.27](/dynamics365/field-service/version-history#885327).

#### 8.8.53.27

(Includes Universal Resource Scheduling version [3.12.65.6](/dynamics365/field-service/field-service-version-history-resource-scheduling#312656)).

- Bug fix to address "Please wait" message not closing for **Convert to WO** on case form.
- Fixed a bug in Field Service (Dynamics 365) mobile to reset travel calculation variables after successful save.

#### 8.8.52.127

This release is a hotfix on Field Service version [8.8.52.125](/dynamics365/field-service/version-history#8852125).

(Includes Universal Resource Scheduling version [3.12.64.78](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126478)).

#### 8.8.52.125

This release is a hotfix on Field Service version [8.8.52.123](/dynamics365/field-service/version-history#8852123).

- Bug fix where instructions field clears on work order save.

#### 8.8.52.123

This release is a hotfix on Field Service version [8.8.52.121](/dynamics365/field-service/version-history#8852121).

- Fixed bug causing issue loading preview of an inspection template in certain scenarios.

#### 8.8.52.121 (2021 Wave 2 release)

(Includes Universal Resource Scheduling version [3.12.64.46](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126446)).

- Added a product deletion validation with dialog when the product is associated with purchase orders that must be deleted before the product can be deleted.
- Better save experience on booking dialog to address save being blocked by pending booking status validations.
- Fix bug where the **Export Selected Records** command wasn't available when multiple items were selected in the work order list view.
- Knowledge articles ("Linked Articles") subgrid has been moved below **Resolutions** subgrid on the bookable resource booking services tab in the Field Service (Dynamics 365) mobile app.

#### 8.8.51.168 (2021 Wave 2 early access, update 2)

This release is an update to Field Service 2021 Wave 2 early access version [8.8.51.114](/dynamics365/field-service/version-history#8851114).

(Includes Universal Resource Scheduling version [3.12.62.63](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126263)).

- When there's only one price list per currency on the billing account, we apply that price list to new agreements, work orders, and return merchandise authorizations (RMA). 
- Added a tax code quick create form.
- Fixed issue where estimate duration field on work order incident form isn’t updated correctly when deleting or deactivating child service tasks.
- Added field **Field Service Product Type** to the product quick create form used in the Field Service (Dynamics 365) mobile app.

#### 8.8.50.13

(Includes Universal Resource Scheduling version [3.12.52.4](/dynamics365/field-service/field-service-version-history-resource-scheduling#312524)).

- Fixed a bug in Field Service (Dynamics 365) mobile app where bookings weren't always showing in agenda or day view when accessing from work order.
- Fixed a bug where an error was shown while trying to add a "used" work order product in Field Service (Dynamics 365) mobile app while offline.
- Added new entries in Solution Hub to help flag configuration issues with Field (Dynamics 365) Service mobile app.
- Improved the Field Service Solution health rules related to agreements to exclude inactive records from evaluation.

#### 8.8.49.21

(Includes Universal Resource Scheduling version [3.12.51.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312511)).

- Corrected an issue where inactive service tasks could still be created as work order service tasks when generating a work order from an agreement booking setup that had an incident type referencing the inactive service task type.
- Resolved a potential null reference error related to work order service tasks that don't have a value in the inspection lookup, which could block the creation of the work order service task.
- Fixed an issue with potentially inconsistent values in the **Total Amount** field of a work order service.
- Improved unclear error messaging on work orders.
- Resolved an issue where, if a work order product or work order service was reparented between work orders, the impacted work orders' **Estimated Subtotal Amount** wasn't accurately recalculated.

#### 8.8.51.114 (2021 Wave 2 early access, update 1)

This release is an update to Field Service 2021 Wave 2 early access version [8.8.51.75](/dynamics365/field-service/version-history#885175).

(Includes Universal Resource Scheduling version [3.12.61.21](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126121---2021-wave-2-early-access-update-1)).

- Improved the logic that updates the **Instructions** field on the work order when the service account is updated.
- Field Service (Dynamics 365) mobile calendar will show a text informing when a booking is scheduled without work order assigned.

#### 8.8.48.30

This release is a hotfix on Field Service version [8.8.48.23](/dynamics365/field-service/version-history#884823).

- Fixed script error on quick create opportunity form.

#### 8.8.48.23

(Includes Universal Resource Scheduling version [3.12.50.27](/dynamics365/field-service/field-service-version-history-resource-scheduling#3125027)).

- Resolved a permissions inheritance issue that could impact users who have a role that worked when users belonged to a team with the same role.
- Fixed an issue related to decimal point number formatting with inspections when using a symbol other than the dot to indicate the decimal place.
- Field Service (Dynamics 365) mobile added the ability to configure custom fields on the mobile booking calendar control.

#### 8.8.51.75 (2021 Wave 2 early access)

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

#### 8.8.47.21

(Includes Universal Resource Scheduling version [3.12.49.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124918)).

- Resolved an issue where the user-provided Price list value on a work order could be cleared under certain form customization scenarios.
- Corrected a validation issue on work order incidents that was causing users to be blocked from being able to update the work order incident's duration even when there were no work order service tasks on the record that carried a duration.
- Improved error handling on work order service task creation to provide a more specific error under certain circumstances.

#### 8.8.46.28

This release is a hotfix on Field Service version [8.8.46.26](#884626).

- Reverted an internal code change to avoid potential performance impact.

#### 8.8.46.26

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

#### 8.8.45.47

This release is a hotfix on Field Service version [8.8.45.47](#884547).

- Reverted an incorrect validation on work order incident which caused the **Estimated Duration** field for the work order incident to be read-only if the work order incident contained work order service task records, even if those work order service task records didn't have a defined estimated duration.

#### 8.8.45.45

This release is a hotfix on Field Service version [8.8.45.35](#884535).

- Fixed an issue that could cause an error when the legacy address suggestion control was used on custom forms.
- Reverted a previous performance change which under certain circumstances could cause an error to occur.

#### 8.8.45.35

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

#### 8.8.44.56

This release is a hotfix on Field Service version [8.8.44.52](#884452).

- Reverted an incorrect validation on work order incident that caused the **Estimated Duration** field for the work order incident to be read-only if the work order incident contained work order service task records, even if those work order service task records didn't have a defined estimated duration.

#### 8.8.44.52

This release is a hotfix on Field Service version [8.8.44.50](#884450).

- Fixed an issue that could cause an error when the legacy address suggestion control was used on custom forms.

#### 8.8.44.50

(Includes Universal Resource Scheduling version [3.12.47.108](/dynamics365/field-service/field-service-version-history-resource-scheduling#31247108)).

This release is a hotfix on Field Service version [8.8.44.45](#884445).

- Reverted a previous performance change that under certain circumstances could cause an error to occur.

#### 8.8.44.45

(Includes Universal Resource Scheduling version [3.12.47.98](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124798)).

This release is a hotfix on Field Service version [8.8.44.39](#884439).

- Fixed a permissions issue with the Field Service dispatcher role that could cause an error to be thrown when dragging an onsite requirement onto the schedule board when "Auto Update Booking Travel" is enabled.

#### 8.8.44.39

(Includes Universal Resource Scheduling version [3.12.47.62](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124762)).

- Fixed an issue in the new mobile app faced with chart creation for bookable resource booking in customization settings.
- Fixed an issue with changing pricing fields.
- Fixed an issue where default view for customer asset lookup field on work order service task form couldn't be changed.
- Fixed an error in Field Service upgrade with the error saying that the element "tab" has incomplete content.
 -Fixed an issue with subgrids on work order form opening main form instead of quick create form.
- Removed an issue in agreement booking where the default system status was getting automatically updated to a different value.

#### 8.8.43.101

This release is a hotfix on Field Service version [8.8.43.97](#884397).

- Reverted a previous performance change that under certain circumstances could cause an error to occur.

#### 8.8.43.97

(Includes Universal Resource Scheduling version [3.12.46.64](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124664)).

This release is a hotfix on Field Service version [8.8.43.93](#884393).

- Sometimes, you might not want a booking start time to be set to current time when the booking status is set to "on site". A new setting has been added to Field Service advanced settings to address this. On adding `bookableresourcebooking.disablefsmtravelingcaluclations` set to `true` to the advanced settings, booking start time wouldn't be set to current time.

#### 8.8.43.93

This release is a hotfix on Field Service version [8.8.43.77](#884377).

- Fixed a bug that removed the work hours tab from the resource form.

#### 8.8.43.77

This release is a hotfix on Field Service version [8.8.43.51](#884351).

- Fixed some performance issues.

#### 8.8.43.51

(Includes Universal Resource Scheduling version [3.12.46.21](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124621))

- Fixed an issue where work order product, work order service, or work order service task were getting created for inactive incident type product, service ask and service task     respectively through agreements.
-	Fixed an issue for invoices auto generated from work order that invoice date is sometimes updated to one day more or less than the actual date. A new advanced setting  `Workorder.InvoiceDate.InUserTimeZone=true` has been added, which can be set to fix the issue. 
- Corrected an issue in the case a custom real-time workflow is specified on work order after create to update any of the primary requirement fields. For example, priority where   the requirement failed to reflect the changes.
- Fixed an issue where time-off request gets created incorrectly when the record is created from the portal and also incorrectly reflects in the schedule board.

#### 8.8.42.66

(Includes Universal Resource Scheduling version [3.12.45.28](/dynamics365/field-service/field-service-version-history-resource-scheduling#3124528)).

Includes all content from Field Service version 8.8.42.64.

#### 8.8.42.64

This release is a hotfix on Field Service version [8.8.42.55](#884255).

- Fixed some performance issues.
- Fixed a bug that removed the work hours tab from the resource form.

#### 8.8.42.55

This release is a hotfix on Field Service version [8.8.42.31](#884231).

-	Fixed an issue in Field Service – Dynamics 365 mobile app where end time would be improperly set and cause unexpected time validation errors.

#### 8.8.42.31

(Includes Universal Resource Scheduling version [3.12.45.7](/dynamics365/field-service/field-service-version-history-resource-scheduling#312457))

- Frontline workers can view bookings in a map view as well in the new mobile app.
- Fixed an accessibility issue with assets where the **More** button shown as triple dots was getting skipped from tabbing.
- Corrected an issue of `OnSave` event handlers being removed from case form on Field Service installation.  
- Corrected behavior to not throw an error when the field `address1_line1` isn't present in the form.

#### 8.8.41.58

This release is a hotfix on Field Service version [8.8.41.53](#884153).

- Fixed an issue in Field Service – Dynamics 365 mobile app where end time would be improperly set and cause unexpected time validation errors.

#### 8.8.41.53

This release is a hotfix on Field Service version [8.8.41.28](#884128).

- Added an advanced setting to disable product bundle validation. If user sets ```product.bundle.optout=true``` then user would be able to add new or modify existing product bundle with Field Service type set.

#### 8.8.41.28

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

#### 8.8.40.141

This release is a hotfix on Field Service version [8.8.40.109](/dynamics365/field-service/version-history#8840109).

-	Fixed a Field Service upgrade issue when the relationship between knowledge article and customer asset/product already existed in the active layer.
-	Fixed a Field Service upgrade issue that was throwing error like ‘Property Inspection is required, but the declaration is missing’

#### 8.8.40.109

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

#### 8.8.35.44

This release is a hotfix on Field Service version [8.8.35.27](#883527).

- Resolved an issue where, under certain circumstances, work orders with a primary incident type that also executes a synchronous workflow, could result in null fields on the work order and related primary resource requirement.
- Reverted the below change: "Updated behavior where estimated duration from agreement booking setup wasn't carried over to work order. Previously, duration from the resource requirement wasn't being used to calculate total estimated duration in the work order. This behavior has been updated; if no work order service task or incident is present, total estimated duration is obtained from the Requirement. If requirement duration is null, then we get value from booking setup metadata." 

#### 8.8.39.142 (2021 Wave 1 early access update)

This release is a hotfix on Field Service version [8.8.39.135](/dynamics365/field-service/version-history#8839135).

- Fixed a Field Service upgrade issue when the relationship between knowledge article and customer asset or product already existed in the active layer.
- Fixed a Field Service upgrade issue that was throwing error: "Property Inspection is required, but the declaration is missing."

#### 8.8.39.135 (2021 Wave 1 early access update)

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

#### 8.8.39.118 (2021 Wave 1 early access update)

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

#### 8.8.35.27

(Includes Universal Resource Scheduling version 3.12.36.2)
 
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

#### 8.8.39.37 (2021 Wave 1 early access)

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

#### 8.8.34.63

(Includes Universal Resource Scheduling version 3.12.35.6)

Includes all content from Field Service version 8.8.34.18

#### 8.8.34.18

(Includes Universal Resource Scheduling version 3.12.35.5)

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

#### 8.8.33.99

(Includes Universal Resource Scheduling version 3.12.34.92)

Includes all content from Field Service version 8.8.33.61

#### 8.8.33.98

(Includes Universal Resource Scheduling version 3.12.34.60)

Includes all content from Field Service version 8.8.33.61

#### 8.8.33.61

(Includes Universal Resource Scheduling version 3.12.34.4)

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

#### 8.8.32.61

This release is a hotfix on Field Service version 8.8.32.59

-	Improved error handling when a work order is closed.
-	Fixed a performance issue in IOT caused by a recent change.

#### 8.8.32.59

(Includes Universal Resource Scheduling version 3.12.33.8) 

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

#### 8.8.31.60

(Includes Universal Resource Scheduling version 3.12.32.1) 

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

#### 8.8.30.113

This release is a hotfix on Field Service version 8.8.30.103.

- Resolved an issue with agreement invoice setups introduced during early access that caused an error in the primary invoice date and invoice generation process, which could stop invoice generation from agreements.
- Corrected a JavaScript error when trying to create a work order through the quick create form.
- Resolved an issue with inspection name value being empty in the parsed inspection record tables.

#### 8.8.30.103

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

#### 8.8.29.333 (2020 Wave 2 early access update)

(Includes Universal Resource Scheduling version 3.12.30.11)

The release is only applied when an environment is opted into early access and introduces the [Field Service 2020 Wave 2](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/planned-features) new and updated features.

In addition, this release includes the following changes:

- Resolved an issue with agreement invoice setups introduced during early access that caused an error in the primary invoice date and invoice generation process that could stop invoice generation from agreements.

#### 8.8.26.24

(Includes Universal Resource Scheduling version 3.12.25.5) 

- Corrected an issue: under certain circumstances, the **Discount %** in work order product form is automatically cleared on save.
- Resolved an issue with agreement booking dates: when the booking dates are manually altered, the work orders weren't getting auto generated as expected relative to the **Generate Work Order Days in Advance** value of the related agreement booking setup.
- Improved handling for the sharing and unsharing behavior of the booking resource booking when the target user is disabled.
- When exchange rate on a currency is changed, any subsequent changes to a work order service record would result in the exchange rate for that record being updated. It should only be recalculated if a currency-related field is updated.
- Improved handling of the account’s merge functionality when one of the target accounts has a related Agreement where taxable is "No."
- Improved handling of the account’s merge functionality when one of the target accounts has a related RMA where taxable is "No."
- When using tab to navigate away from the **Estimate Total Amount** field on a work order service record after making an update, the system was inappropriately throwing the error "Enter an amount between $0.00 and $1,000,000,000.00."
- Corrected a bug: when the work order service’s **Line Status** was changed from "Estimated" to "Used," the **Estimated Discount %** field wasn't getting copied to the **Discount %**.

#### 8.8.29.226 (2020 Wave 2 early access update)

(Includes Universal Resource Scheduling version 3.12.30.11)

The release is only applied when an environment is opted into early access and introduces the [Field Service 2020 Wave 2](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/planned-features) new and updated features.

In addition, this release includes the following changes that have the potential to change the existing system behavior or interface:

- Added quick create forms for all new asset properties-related entities to the Field Service model-driven app.
- Corrected an issue with a missing space in the "Field Service Activities" tab header for the account entity for the Field Service Mobile model-driven app.
- Improved the customer asset form to ensure that the IoT related tabs are displayed after the other form tabs.
- Removed the property logs option from the related menu from the customer asset form.
- Updated the property log display values to respect user settings for date and time.
- Corrected travel calculation logic for the Field Service Mobile model-driven app to ensure that, when the booking is set to in progress, if there was no **Estimated Travel Duration** the system will update the **Actual Arrival Time** and won't immediately increase total duration.

#### 8.8.29.165 (2020 Wave 2 early access)

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

#### 8.8.25.30

(Includes Universal Resource Scheduling version 3.12.24.5) 

- Includes all content from Field Service version 8.8.25.29

#### 8.8.25.29

(Includes Universal Resource Scheduling version 3.12.24.4) 

- Corrected an issue on bookable resource booking forms where the **Estimated Arrival Time** field can appear as if it has been edited immediately after save (when it hasn’t been), making the form behave as if it had unsaved changes.
- Improved logic to allow for customizations to the work order form where the primary incident type is removed from the form to ensure that the out-of-the-box form logic has a null check for the **Primary Incident Type** field.
- Resolved an issue with missing localization strings on the IoT alert and IoT device entities, which could cause a script error.
- Fixed an issue on update of agreement booking incident, which produced an error if there was a related agreement booking service task with a null estimated duration.
- Resolved a problem with the agreement copy function that failed to copy agreements if there were deactivated agreement booking setup or agreement invoice setup records related to the agreement. The copy function will now successfully copy active records and ignore inactive records.
- Added a new Field Service health rule that will highlight agreement booking setup and agreement invoice setup records on which the latest workflow instance had failed which could keep expected work orders and invoices from being generated. Once detected, the rule also provides a button to resolve failed workflow instances.

#### 8.8.24.54

(Includes Universal Resource Scheduling version 3.12.23.71) 

- Includes all content from Field Service version 8.8.24.17

#### 8.8.24.17

(Includes Universal Resource Scheduling version 3.12.23.26)

- Corrected a null reference error based on work order product form customizations to better handle when certain fields are removed from the form.
- Resolved an issue with the incident type duration suggestions feature that produced an error when a user clicked “Recalculate Suggestions” for large query results.
- Fixed an issue with agreement update, which produced a "Nullable object must have a value" error on updating end date of an agreement whose end date is null.
- Removed the following BPFs from the Field Service Mobile app module: case to work order, lead to opportunity sales, opportunity sales, phone to case.
- Improved logic to allow for customizations on work order creation from an agreement if there are customizations in place to automatically create more resource requirement records.
- Improved Field Service’s missing form libraries rule in Solution Health Hub to improve the rule description.
- Enhanced logic to in the opportunity quick create form to respect scenarios when an environment sets the “Account” field as business required to ensure that Field Service form logic doesn't set the field as optional.

#### 8.8.23.85

(Includes Universal Resource Scheduling version 3.12.22.9)

- Improved crew booking validations, which ensure that the booked crew has at least one defined crew member for the date on which the booking is being created.
- Improved descriptions in upgrade scripts to make the script more comprehensible by an administrator by documenting deprecated upgrade script steps to minimize confusion.
- Fixed an issue that left the status null when created a new geofence, which could cause geofence events to not be created.
- Repaired a Field Service upgrade issue caused by a script that, when appropriate, created requirement group records. If the requirement group's name was too long, the script and upgrade would fail.
- Fixed an issue on the contact entity's geo code functionality that caused a script error if "Auto Geo-Code" was set to "No" in Field Service settings.
- Corrected an incorrect agreement booking setup recurrence validation error for "Too many days in month." Under certain circumstances, this error was thrown inappropriately.
- Resolved an issue with duplicate section and tab IDs in Connected Field Service that caused issues when trying to uninstall the solution.
- Corrected a null reference issue in Connected Field Service when loading the device summary control on the IoT alert form.

#### 8.8.22.58

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

#### 8.8.12.2

- Fixed an issue where the "Generate Work Order" button from advanced find on agreement booking dates wasn't displaying and working properly.
- "Due Date" field value on invoices generated from agreement invoice date is one day early. For organizations experiencing this issue, a fix is available through the "Advanced Settings" field in the Field Service settings entity. Copy the following string into the hidden field:  

> *autogeneration.usetimezone.invoiceduedate=true*

- Resolved a bug on deactivated work order service records throwing an error when reactivated, "Object Reference Not Set to Instance of an Object."
- Corrected an unhandled error in geocoding that failed if the address contained an extra comma.
- For organizations that would prefer that work orders generated from cases open in the same window, this action can now be controlled through "Advanced Settings" field in the Field Service settings entity. Copy the following string into the hidden field if you would prefer work orders to open in the same tab in the same window:  

> *casetoworkorderwindowbehavior=0*

>[!Note]
> The "Advanced Settings" field on Field Service settings is not added to the entity form by default.  

#### 8.8.11.19

**Available in all regions by April 2020**.

- Fixed an issue where agreement booking date generation fails when agreement is owned by a team.
- Resolved an issue where Field Service client-side logic fails when using contact form while in offline.
- Resolved purchase order product form customization issues where:
  - If an organization removed the "Quantity Received" field from the purchase order product, they would be unable to create a new purchase order product record.
  - Work order and warehouse values don't autopopulate if the fields are removed from the form.
- When using quick create form for a work order from an account, fixed an issue where some of the fields that were expected to autopopulate weren't being populated.
- If the map control is removed from the work order form, it can't be added back. The control has been locked to the form so that it can't be removed from the form.
- Issue where the primary incident type record of a deactivated work order couldn't be deactivated; added a validation check to only allow the work order incident record to be deactivated when work order is deactivated.

#### 8.8.14.328 (2020 Wave 1 early access)

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

#### 8.8.10.44

**Available in all regions**.

- Agreement booking service task's name is overwritten when the related task type changes.
- Can't complete booking that has travel time if the travel charge type on the related work order's account is null.

#### 8.8.9.84

- Script error when you remove account field from the opportunity quick create form.
- On creation of account record based on postal code functionality, service territory repeats autopopulated, even after the customer removes the initial autopopulated value.
- Consistency issue in Field Service's Solution Health Hub rule naming when referring to SDK message processing steps.

#### 8.8.8.135

- Work order plugin error for SLA KPI instance.

#### 8.8.8.50

- Improve error messages when the user attempting an action is missing "Field Service Setting" read privilege.
- Form logic always turns incident type to not required based on work order type, regardless of field settings.
- Bookings aren't shared consistently to all resources on multi-booking work orders.
- Deleting and recreating a booking associated with a work order changes the shared users of booking.
- TypeError: Can't read property "getDefaultView" when requested by contact field removed from RMA form.
- Agreement invoice product currency set to base currency - the currency should set to agreement's price list currency.

#### 8.8.7.47

- Removal of territory from work order doesn't remove from non-primary related requirements.
- Inappropriate command buttons shown for opportunity, quote, and order product and service-based lines sub grids.
- Field Service resource privilege exception on create and save of time-off request.

#### 8.8.3.533

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/09/10/enhancements-and-bug-fixes-for-field-service-version-8-8-3-533/)

#### 8.8.2.160

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/08/11/enhancements-and-bug-fixes-for-field-service-version-8-8-2-160/)

#### 8.8.1.45

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/07/enhancements-and-bug-fixes-for-field-service-version-8-8-1-45/)

#### 8.8.0.88

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/06/10/release-notes-for-field-service-version-8-8-0-88/)

#### 8.7.0.105

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/06/release-notes-for-field-service-version-8-7-0-105/)

#### 8.6.0.274

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/04/06/release-notes-for-field-service-version-8-6-0-274/)

#### 8.5.0.345

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/03/07/release-notes-for-field-service-version-8-5-0-345/)  

#### 8.4.0.338

[Read a blog post about this update.](https://blogs.msdn.microsoft.com/crm/2019/02/11/release-notes-for-field-service-version-8-4-0-338/)

#### 8.3.0.255

[Read a blog post about this update.](https://blogs.msdn.microsoft.com/crm/2018/12/21/release-notes-for-field-service-version-8-update-release-3/)

#### 8.2.0.286

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/11/08/release-notes-for-field-service-version-8-update-release-2/)

### Field Service on-premises

| Version | Status | Details |
| --- | --- | --- |
| 7.x | Latest available. Minimum platform version 9.0 for install. | [Link](/dynamics/s-e/) |
| 6.x | Not supported | |

### Field Service Online end-of-life for v7.x and earlier

[Version history notes for v7.x](https://cloudblogs.microsoft.com/dynamics365/it/product/field-service/field-service-7/)

Online versions of Field Service v7 and earlier are [end of life](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/17/announcing-end-of-life-for-field-service-online-legacy-versions-by-february-2020/) and no longer supported. Microsoft won't service support requests for these versions of Field Service until you upgrade to the latest version.

You can upgrade legacy versions of Field Service directly from the admin center.

This upgrade is significant and has many potentially disruptive changes including data model, mobile, and interface changes. Review the [Field Service playbook](https://aka.ms/fsuciupgrade) for more information. Prior to applying the upgrade to production, be sure to first test the upgrade on a non-critical, production-like environment.

All customers should upgrade all legacy versions of Field Service and Project Service Automation to the latest solution versions as soon as possible.

## Universal Resource Scheduling

### Earlier release waves

For release notes and version history of the current release wave, see [Universal Resource Scheduling version history](field-service-version-history-resource-scheduling.md).

#### 3.12.83.6

(Includes Resource Scheduling controls version 1.2.24.222144).

Bug fixes for new schedule board:
-	Booking a resource with flexible dates.
-	Details panel shows empty values for some columns. 
-	Custom date-time field value is showing -1 day on requirements panel.
-	Different behavior of the Schedule Assistance (Create Booking Panel) in the List and Gantt view.
-	When booking status is cancelled, booking should disappear automatically.
-	Incorrect view of booking with travel.
-	Work hour for resources doesn't respect time zone change.
-	Appointment tooltips aren't showing anything.
-	Rebook button not available for long bookings.
-	Refreshing after reassigning a booking throws an error.
-	Booking view doesn't display multiline field value.


#### 3.12.82.14

(Includes Resource Scheduling controls version 1.2.23.221941).

#### 3.12.81.3

(Includes Resource Scheduling controls version 1.2.22.221876).

-	Scheduling assistant shows generic error message instead of a message returned from the server.
-	Improved requirement group scheduling performance for large number of bookable resources.
-	The Organization Unit field doesn't display an asterisk on the form although it's set to business required.
-	In the New Schedule Board, the user is unable to clear a date in the Schedule Assistant Filter window.
-	Time From/To Promised date time isn't populated correctly from the form value.
-	In the new Schedule Board, the Booking Method doesn't get updated.
-	Dragging the booking to next dates on the new schedule board daily view "Extend to" date is shown one day earlier.
-	On the new schedule board, daily view unable to select multiple days using ctrl key. 
-	Requirements tab stuck on loading when date formats weren't yyyyMMdd.
-	Requirements details present on Schedule Assist aren't showing the field value.


#### 3.12.80.9

(Includes Resource Scheduling controls version 1.2.20.221614).

#### 3.12.79.16

(Includes Resource Scheduling controls version 11.2.20.221614).

- Fix filter label truncation to improve usability.
- Filter panel fix to stay open when switching schedule board views.
- Booking tooltip usability improvements to address issues where it wasn't consistently rendering.
- Bug fix for resource count when booking from a work order using scheduling assistant.
- On dragging the booking to next dates in Daily View "Extend to" date is shown one day earlier.
- Bug fix for pool scheduling showing incorrect results.
- Performance improvements for requirement group scheduling with a large number of bookable resources.
- Bug fix for the requirements grid tabs not visible after multiple drag and drops. 
- Bug fix for client telemetry logs for multiple client events.


#### 3.12.78.23

(Includes Resource Scheduling controls version 1.2.19.221374).

- `Msdyn_SearchResourceAvailability` API fix applying territories constraint.
- Updates to new schedule board: 
    - Schedule assistant update to show error message from server side plugin.
    - Schedule assistant use of custom filters.
    - Date picker localization of "Today."
    - Map view support for certain letters (for example: ŁĄŚĆŻĘŃÓŹ).
    - Schedule board loading when no default language is provider (for example: `UiLanguageId` missing in user settings). 

#### 3.12.77.18

(Includes Resource Scheduling controls version 1.2.18.221304).

- New schedule board updates to address issues with auto refresh, resource requirement data not populating, time calculation, time zone application, schedule assistance filters.
- `msdyn_SearchResourceAvailability` API update to support territory constraints.

#### 3.12.76.1

(Includes Resource Scheduling controls version 1.2.17.221165).

- New schedule board updates to address issues with requirements on map view, drag and drop errors setting duration, and schedule assistance application of booking rules.

#### 3.12.75.2

(Includes Resource Scheduling controls version 1.2.16.220914).

- New schedule board fix for preferred resources filter.
- New schedule board fix where the custom filter doesn't clear the existing value correctly.
- New schedule board fix to view all of the items in the drop down when filtering for territories. 
- New schedule board modified the logic to calculate remaining duration and fulfilled duration. 


#### 3.12.74.1

(Includes Resource Scheduling controls version 1.2.15.220774).

- Fixed bug: Resource utilization expands and collapse on the new schedule board.
- Fixed bug: `msdyn_SearchResourceAvailability` returned inaccurate time slot type. 
- Improved daylight saving time to avoid invalid date and time errors. 


#### 3.12.73.25

(Includes Resource Scheduling controls version 1.2.14.220634)

- Fixed bug: `msdyn_SearchResourceAvailability` API returns wrong results if the search range is in the next hour.
- Fixed bug: Travel time shouldn't be considered when returning available time slots for facility scheduling.
- Fixed bug: `msdyn_SearchResourceAvailability` API should respect existing bookings only return where resource has idle time, and when user checks **Ignore duration** on UI. API should also return slots with less than required duration. 
- Fixed bug: On the new schedule board, filter for bottom requirement section doesn’t work correctly for boolean fields. 

#### 3.12.72.9

(Includes Resource Scheduling controls version 1.2.13.220534)

- Fixed bug: On the new schedule board, search range is always two days instead of taking the time range set when using "Find availability."
- Fixed bug: Proper error message isn't shown when an unprivileged user is trying to delete a booking from new schedule board. 
- Fixed bug: Quick book is throwing "Can't read properties of undefined (reading 'from')" error message when: (1) requirement group without from date, and (2) custom entity without from/to mapping.
- Fixed bug: On the new schedule board, date fields on the booking panel use incorrect date format.
- Fixed bug: Booking on the new schedule board doesn't reflect booked hours correctly for project team member.
- Fixed bug: On the new schedule board, proper error message isn't shown when user is trying to delete a record that has some related booking alert records.  
- Fixed bug: “Date-time format for /Date is invalid or value is outside of supported range" when using retrieve resource query on the new schedule board.
- Fixed bug: Unable to change booking status on the new schedule board. 
- Fixed bug: KPI panel on the new schedule board isn't updated when booking suggestions.
- Fixed bug: Race condition when rendering availability slots in SA mode.

#### 3.12.71.20

(Includes Resource Scheduling controls version 1.2.12.220462)

- Fixed bug: travel time shouldn't be considered when returning available time slots for facility scheduling.

#### 3.12.71.16

(Includes Resource Scheduling controls version 1.2.12.220462)

- Fixed bug: Custom booking template for custom entity isn't being shown correctly. 
- Fixed bug: Facing error when selecting **Book** option from service activity through quick book.
- Fixed bug: Quick book throws "Can't read properties of undefined" error for two scenarios: 
  - Requirement group without from date.
  - Custom entity without from/to mapping.
- Fixed bug: On new schedule board, values in start time and end time columns aren't in sync with time zone displayed in board view settings when booking a requirement group.
- Fixed bug: New schedule board doesn't remove canceled work items from map.
- Fixed bug: On new schedule board, booking method for the newly created bookings should be set as "Schedule Board."
- Fixed bug: Spinner when searching resources isn't showing user-friendly label on new schedule board. 
- Fixed bug: On new schedule board, details panel always takes view ID from default `BookingSetupMetadata(BSM)`.
- Fixed bug: On new schedule board, API to create bookings would fail when using logical name instead of schema name.
- Fixed bug: Legacy schedule board sends a request to `GetAvailabilitySummaryFromDemand` with zero resources, causing performance issue.

#### 3.12.70.3

(Includes Resource Scheduling controls version 1.2.11.220252)

- Fixed bug: Default radius value always takes kilometer as calculation unit in the backend when checking resource availability through quick book.
- Fixed bug: Using find availability on new schedule board, values in start time and end time columns of search result page aren't consistent with time zone displayed in board   view settings when booking a requirement group.
- Fixed bug: On new schedule board, filter on service account doesn't list all the possible service account names.
- Fixed bug: On new schedule board, mapped custom fields aren't being populated when booking created.  
- Fixed bug: `FpsAction 210` filters out active bookings.
- Fixed bug: On new schedule board, booking tooltip shows different booking record.
- Fixed bug: On new schedule board, pending booking stays on the board if booking creation fails.
- Fixed bug: Creating a booking silently fails if associated requirement record doesn't have remaining duration attribute set.
- Fixed bug: Find availability doesn't show error message when booking requirement group if error occurs. 

#### 3.12.69.1

(Includes Resource Scheduling controls version 1.2.10.213612)

- Fixed bug: On the new schedule board, resource calendar doesn’t consider time-off hours if configured as time off. 
- Fixed bug: Geocode fails with the error message "ResourceID GeoCode_AddressBadRequest wasn't found" due to missing label in the localization file. 
- Fixed bug: New schedule board doesn't filter by date if the date format isn't US or ISO and region is non-US. 
- Fixed bug: New schedule board doesn't filter by custom fields on related entity for requirement view. 

#### 3.12.68.8

(Includes Resource Scheduling controls version 1.2.9.213482)

- Enabled **Time Group Detail Start** and **Time Group Detail End** column and sorting on list view when returning results with **Find Availability** functionality. 
- Fixed bug: Resource available hours aren't showing correctly on new schedule board when configured calendar with working hours and a time off. 
- Fixed bug: Changing status of booking updated the **Start Time** and **Estimated Arrival Time** incorrectly in some scenarios on new schedule board.
- Fixed bug: Can't create or update a resource preference to a crew type resource.
- Fixed bug: Time zone conversion issue when select time from time picker on **Search Start** and **Search End** fields when using **Find Availability** on new schedule board.
- Fixed bug: Progress indicator div blocking click events on the booking when define a new booking template. 
- Fixed issue: New schedule board doesn't filter by date if the date format isn't US or ISO and region is non-US.


#### 3.12.67.1

(Includes Resource Scheduling controls version 1.2.8.213282)

- Fixed bug: Changing status of booking updated the **Start Time** and **Estimated Arrival Time** incorrectly in some scenarios.
- Enabled fulfillment preference support for single requirement when user uses **Find Availability** to schedule requirement.

(Includes Resource Scheduling controls version 1.2.7.213012)

- Fixed bug: Travel time is included in booking duration when book facility requirement.
- Performance improvement on new schedule board when user uses **Find Availability** to book requirement. 


#### 3.12.66.3

(Includes Resource Scheduling controls version 1.2.6.212992)

- Allow users to schedule entities without an associated requirement record with scheduling assistant on the new schedule board. 
- Enabled sorting functionality for new schedule board list view when user uses **Find Availability** to book requirement on hourly view. Users can sort rows using each of the       columns.
- Improved the performance when user uses **Find Availability** to book requirement on new schedule board.
- Fixed bug: Travel time is included in booking duration when booking facility type of requirement on new schedule board. 
- Fixed bug: New schedule board sometimes crashes when scheduling a multiday requirement using **Book and Exit** button with **Find Availability** on the new schedule board. 

#### 3.12.65.6

(Includes Resource Scheduling controls version 1.2.5.212813)

- Enabled **Group By** capability on new schedule board list view. 
- On new schedule board, started showing dotted line when user drags-and-drops requirement to the board. 
- Fixed: when update contact record with integration job: Update (Pre-operation) for contact plugin throws Error: **System.ServiceModel.QuotaExceededException: 'The size necessary to buffer the XML content exceeded the buffer quota.'** 		
- Added retry mechanism and logged more information for troubleshooting when Geocode API fails with HTTP 403.

#### 3.12.64.78
This release is a hotfix on Universal Resource Scheduling version [3.12.64.46](/dynamics365/common-scheduler/bug-fixes#3126478)

- Added retry mechanism and logged more information for troubleshooting when Geocode API fails with HTTP 403

#### 3.12.64.46 - 2021 wave 2 early access general availability 

(Includes Resource Scheduling controls version 1.2.2.212724)

The following Universal Resource Scheduling 2021 Wave 2 features in general availability are included in this release.

- Resource work hours extensibility. 
- Improved user experience with new schedule board enhancements.

This release also includes all the fixes included in the [2021 wave 2 early access](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126043---2021-wave-2-early-access), [2021 wave 2 early access update 1](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126121---2021-wave-2-early-access-update-1) and [2021 wave 2 early access update 2](/dynamics365/field-service/field-service-version-history-resource-scheduling#3126249---2021-wave-2-early-access-update-2).

- Fixed a bug on the legacy schedule board with expanding a pool resource threw an exception. 
- This release contains an update to the new schedule board; now, new schedule assistant and find availability functionality can also be used with the multiday requirements that last for multiple days with associated requirement detail records. We also shipped many experience, performance, and stability improvements. For any schedulable entity to be supported on the new schedule assistant experience, the schedulable entity record needs to have an associated requirement. Support for schedulable entity records without an associated resource requirement record will be added in a future update. A few performance improvements will also be made available on the Schedule assistant and schedule board in future updates. 

#### 3.12.62.49 - 2021 wave 2 early access update 2

(Includes Resource Scheduling controls version 1.2.2.2126411)

The release is only applied when an environment is opted into the early access of 2021 wave 1 and introduces the [resource scheduling 2021 wave 2](/dynamics365-release-plan/2021wave2/service/dynamics365-field-service/planned-features#resource-scheduling) new and updated features. 

This release is an update to the 2021 wave 2 early access of Universal Resource Scheduling version 3.12.61.21. 

- There was an issue where Power Automate cloud flow was used to trigger on update of the work order field on the requirement to create a booking for the requirement, but it would create two bookings. This issue is now fixed. 
- When a user selects on the suggested time slot's resources on the quick book panel, the scroll position is reset, and the user has to again select on the available resources of the suggested time slot to see the available resources. This issue is now fixed. 
- This release contains an update to the new schedule board; now, new schedule assistant and find availability functionality can also be used with the multiday requirements that last for multiple days with associated requirement detail records. We also shipped many experience, performance, and stability improvements. For any schedulable entity to be supported on the new schedule assistant experience, the schedulable entity record needs to have an associated requirement. Support for schedulable entity records without an associated resource requirement record will be added in a future update. 

#### 3.12.52.4

(Includes Resource Scheduling controls version 1.1.7.211681)

- Fixed an issue where a new booking is created from the booking form directly with a **Booking rule** enabled, the `RequirementId` isn't passed via the bookings rule. 
- Made performance improvement on the schedule board by only querying for the active booking records, which are displayed on the schedule board. 
- When booking a multiday requirement, some would get stuck in a loop for a long time when using booking method as **Remaining Requirement** with **Double-book if needed** selected. This issue is now fixed. 
- When the user selects a suggested time slot on the quick book panel, the selection wasn't highlighted. This bug is now fixed. 
- Fixed **Object reference not set to an instance of an object** error during the upgrade of the environments from an older (v6, v7) version of Field service app to latest v8 versions. 

#### 3.12.51.1

(Includes Resource Scheduling controls version 1.1.7.211681)

- When using the API `msdyn_SearchResourceAvailabilityForRequirementGroup` throws an error **Nullable object must have a value.**, when eligible crew has more crew resources than the requirements in the requirement group. This null handling error is now fixed. 
- When a resource has a time off starting from 12 AM, for a few hours, the schedule board is showing that the resource isn't working for more than the time-off period. This issue happens for the timezones GMT + x hours. This issue is now fixed and schedule board should reflect the right time-off period. 
- When **Quick Book** is used on a requirement group with only start date and no end date, the quick book window loads forever and shows no results. This issue is now fixed. With this fix, the behavior of quick book when used on requirement groups is that: 
	- If there are start and end dates, then the availability is shown accordingly.
	- If there are no start and end dates, then the availability is shown for current date to next 60 days.
	- If only start date is populated, then the availability is shown for start date to next 60 days.
	- If only end date is populated, then the availability is shown for current date to end date.

#### 3.12.61.21 - 2021 wave 2 early access update 1

(Includes Resource Scheduling controls version 1.2.1.212252)

The release is only applied when an environment is opted into the early access of 2021 wave 1 and introduces the [resource scheduling 2021 wave 2](/dynamics365-release-plan/2021wave2/service/dynamics365-field-service/planned-features#resource-scheduling) new and updated features. 

This release is an update to the 2021 wave 2 early access of Universal Resource Scheduling version 3.12.60.43. 

- This release contains an update to the new schedule board; now, new schedule assistant and find availability functionality can also be used with the requirement groups. We also shipped many experience, performance, and stability improvements. 
- Fixed a bug: when a user enables the new schedule board toggle and refreshes the browser, the user preference wasn't remembered and they were shown the old schedule board. 
- Fixed a bug: some customers were unable to reimport new custom solutions once they opted into the 2021 wave 2 early access and installed the updates. 
- Fixed non-blocking errors when updates were made to a booking record, like **Sequence contains no matching element**, and **Nullable object must have a value**.
- Fixed issue: Users couldn't drag the resource routes on the schedule board map to a nearby unscheduled requirement to create a booking. In the new schedule board, the user was required to select a resource before letting them drag the route. 
- Fixed issue: When using the new schedule assistant on a work order to book a resource, the work order title wasn't shown in the header of the schedule assistant experience. 

#### 3.12.50.27

(Includes Resource Scheduling controls version 1.1.7.211681)

- Fixed a bug where columns (fields) of type customer wouldn't filter based on the text typed, but show all records, when filtered in column filters on the requirement panel of the schedule board.
- When using the preferred resource on the requirement and quick scheduling is used, incorrect resources are shown with the heart icon for preferred resource. This issue is now fixed. 
- Fixed a bug where an error is thrown when booking end time and actual arrival time are same. This no longer throws an error, as it's a valid scenario for resources. 
- When a resource has time off for a few hours in a day, in the schedule board list view, there are two duplicate line entries for the same time off duration. This issue is now fixed, and should show as only one line item in the list view. 
- Pushed an improvement to the upgrade experience: when an organization deleted an out-of-the box shipped booking status record, the upgrade failed. This issue is now fixed. 
- Fixed an issue where users couldn't create a booking alert that they don't have read and write privileges to the booing alert status record type, even when the user has the necessary privileges but the team they're assigned to doesn't have the privileges. This bug is now fixed. 

#### 3.12.60.43 - 2021 wave 2 early access

(Includes Resource Scheduling controls version 1.2.0.212086)

The release is only applied when an environment is opted into the early access of 2021 wave 1 and introduces the [resource scheduling 2021 wave 2](/dynamics365-release-plan/2021wave2/service/dynamics365-field-service/planned-features#resource-scheduling) new and updated features. 

This release also includes the following changes that have the potential to change the existing system behavior or interface. 

- Performance improvements are made when applying the work hours templates to the resource(s). 
- Fixed a bug where the column headers and the columns were misaligned in the list view of the schedule board.
- The tooltip of the **Default radius unit** field of the schedule assistant under Resource Scheduling's scheduling parameter is corrected to **Choose the unit to display the distance on the Schedule assistant experience". 
- When we have the **Derive Capacity From Group Members** set to **Yes** in the **Scheduling Tab** of parent pool resource, any updates to a bookable resource group membership will trigger the deletion of all existing inner calendars of the parent resource and recreate them based on the child resource calendar. This recreation of the inner calendars happens even when we try to add a new child to the pool resource. This takes a lot of time, especially when the time period between the from and to dates is long. The longer the time period between from and to dates, the longer it takes to edit the bookable resource group and can cause the offline or timeout error after a certain threshold. Performance improvements are made by making the deletion of the inner calendars asynchronous. 

#### 3.12.49.18

(Includes Resource Scheduling controls version 1.1.7.211681)

- Booking work orders to a resource on the schedule board fails with a null reference error if **Auto Update Booking Travel** feature isn't set to a value. This bug is now fixed.
- Fixed a bug on the schedule assistant to calculate the right travel distance of the resource. 

#### 3.12.48.25

(Includes Resource Scheduling controls version 1.1.7.211681)

- Booking work orders to a resource on the schedule board fails with a null reference error if **Auto Update Booking Travel** feature isn't set to a value. This bug is now fixed.
- Fixed a bug on the schedule assistant to calculate the right travel distance of the resource. 
- Fixed a bug where the schedule board doesn't load. 
- Fixed a bug where the time zone of the resource wasn't rendered on the details panel, when a resource is selected. 

#### 3.12.47.108

This release is a hotfix on Universal Resource Scheduling version [3.12.47.98](/dynamics365/common-scheduler/bug-fixes#3124798)

- Fixed a bug where the schedule board doesn't load. 

#### 3.12.47.98

This release is a hotfix on Universal Resource Scheduling version [3.12.47.98](/dynamics365/common-scheduler/bug-fixes#3124762)

- Booking work orders to a resource on the schedule board fails with a null reference error if **Auto Update Booking Travel** feature isn't set to a value. This bug is now fixed.

#### 3.12.47.62

(Includes Resource Scheduling controls version 1.1.6.211322)

- Fixed a bug where the schedule board doesn't load. 
- Fixed an issue where work hours tab is removed from bookable resource form. 
- When the setting **Auto Update Booking Travel** is disabled, some bookings **Modified On** columns are shown updated when a new booking is created during non working hours for a resource. This bug is now fixed.
- When the field **Estimated Arrival Time** is hidden from the **Information** form of the bookable resource booking entity, updating the **Start time** of a booking record throws an error. This bug is now fixed. 
- Fixed an issue: when two separate bookings in the schedule board were modified in quick succession, it could lead to an issue where duplicate calls were made for the same booking. This issue is now fixed. 

#### 3.12.46.64

This release is a hotfix on Universal Resource Scheduling version [3.12.46.21](/dynamics365/common-scheduler/bug-fixes#3124621)

- Fixed a bug where the schedule board doesn't load. 

#### 3.12.46.21

(Includes Resource Scheduling controls version 1.1.6.211322)

- **msdyn_searchresourceavailabilityforrequirementgroup** action sometimes failed with invalid organizational unit locations. This bug is now fixed and will filter the resources to the organizational unit passed even when invalid location is used for the organizational unit. 
- **msdyn_SearchResourceAvailability** and **msdyn_SearchResourceAvailabilityforRequirementgroup** actions are now compatible with the web API endpoints. You could use the API parameter **version** = 3, to use this capability.
- Fixed a bug where columns (fields) of type **Customer** would show both account records and contact records when filtered in column filters on the requirement panel of the schedule board. 
- Improvements were made to the load time of the schedule assistant in the vertical view. 

#### 3.12.45.7

(Includes Resource Scheduling controls version 1.1.5.211181)

- When booking a resource from the schedule assistant, on the days, weeks, and months views and using the **Double book if needed** option on the booking panel, clicking on book button would keep the spinner loading without completing the operation. This specifically happened when the resource has no working hour in the duration of the requirement detail. This bug is now fixed. 
- Fixed an accessibility bug on the grid used in the requirement groups. The contrast ratio of keyboard focus on column headers in grid with background is 1.2:1 which is less than required contrast ratio 3:1. This bug is now fixed. 
- Fixed an accessibility bug on the grid used in the requirement groups. At 400% zoom, content inside **Search** popup in **Preferred Resource** column isn't completely visible. With this fix, entire content that is visible at default view should be clearly visible at 400%. 
- Fixed a bug where a validation is done on the booking, that the **End time cannot be before or same as the estimated arrival time**, when the actual arrival time is already populated. With this fix, the validation would be that the **End time cannot be before or same as the actual arrival time**, as long as the actual arrival time is populated. 

#### 3.12.44.127

- When a booking alert is created in the context of the **SYSTEM** user, an error was thrown that the user doesn't have create privileges. This bug is now fixed. 
- Fixed a bug where a time tooltip is shown on the hourly view of the schedule board and doesn't close.
- When schedule assistant is used on onsite requirements with fulfillment preferences of intervals, the end time of the suggested time slot on the list view is shown incorrect. This bug is now fixed. 
- msdyn_searchresourceavailability API returned same GUIDs for all the suggested timeslots when fulfillment preferences are used. This bug is now fixed. 
- In days, weeks, and months views of the schedule board, when new bookings are created or existing bookings are edited, a new visual spinner is shown to represent the progress of the operation. 
- When custom fields of the booking record are displayed on the booking template of the new schedule board, only the schema name of the custom field are displayed instead of the display name of the custom field. This bug is now fixed. 
- Creation of a booking via dragging and dropping of the unscheduled work order on the new schedule board is now supported on the Firefox browser. 
- The available resource names are truncated on the quick book panel, this bug is now fixed. 
- When the requirement view used to display the unscheduled requirements on the schedule board has no sorting defined, an error was thrown. This bug is now fixed. 
- When creating multiday booking using **Evenly Distribute** booking method, user can't overbook resources with single booking if per-time-period duration is greater than resource's availability during that time. This bug is now fixed. 
- Priority, territory and status lookup fields can now be filtered on the requirement panel of the new schedule board. 
- When the requirement map pins are hidden from showing on the map panel of the schedule board, the requirements were still retrieved in the backend. This bug is now fixed to remove the unnecessary call and improve the load time of the schedule board. 
- Due to different timezones used, the resource availability did not respect the business closure of the resource working hours. This bug is now fixed. 
- Fixed a bug where if user updates appointment series by adding required attendees, new bookings weren't created, when (legacy) appointment scheduling feature is enabled. 
- When quick book is used on requirement groups with multiple requirements with the field **Select** = **Any** option, then multiple combinations of same set of resources were shown in the suggested resources. This bug is now fixed. 
- When trying to filter the schedule board to specific resources, it doesn't filter anything out as **Retrieve Resource Query** field on the schedule board tab was pointing to an incorrect value. This bug is now fixed. 

#### 3.12.43.68 - 2021 wave 1 general availability

The following Universal Resource Scheduling 2020 Wave 1 features in general availability are included in this release.

- Map view, weekly, and monthly views in the new schedule board. 
- Appointment data included in resource scheduling.
- Embedded optimizer enhancements within schedule board (preview).

This release also includes all the fixes included in the [2021 wave 1 early access](/dynamics365/common-scheduler/bug-fixes#3124015---2021-wave-1-early-access) and [2021 wave 1 early access update 1](/dynamics365/common-scheduler/bug-fixes#312424---2021-wave-1-early-access-update-1).

- When creating multiday booking using **Evenly Distribute** booking method, user can't overbook resource with single booking if duration is greater than resource's availability during that time. This bug is now fixed. 
- Fixed a bug where quick scheduling is used on a requirement group with work location set to *Facility*, no available resources are returned. 
- Start and end time on schedule assistant list view mismatches with estimated arrival time and end time on the create resource booking panel when using fulfillment preferences (intervals) are used on aa *Onsite* requirement. This bug is now fixed. 
- **Rebook button** on requirement group’s bookings is using the **Default Booking Committed Status** from default **None** booking setup metadata, rather than using the default booking committed status from the schedulable entity’s booking setup metadata record. 
- **Clear Sorting** option is now available on the column filters of the requirement panel of the new schedule board. 
- When using quick book, the back button on the view resources page disappears if a different date is selected. This bug is now fixed. 
- Business closures aren't honored for the resource availability due to the different timezone on the resource work hours and the **User Timezone** preference. This bug is now fixed. 
- When a skill uses a special character like **&** in the name, the skill name is displayed as HTML-encoded in the schedule board filter layout. This bug is now fixed. 
- When using the schedule board’s email driving directions is fixed to send emails to the recipients in the **To** field. 
- When a business closure is created for a day in the Canberra time zone (GMT+10) and saved, the start and end times of the business closure were raised by an hour. This bug is now fixed. 
- Fixed a bug on the new schedule board in Hebrew, where the dates are incorrectly aligned from left to right when next day of the time range is selected. 
- Fixed a bug where schedule board displays text in Chinese on the date columns of the hourly view, when system language is set to Japanese. 
- When using the quick book, and the available resources are accessed on an available time slot, the time displayed is different than the actual time slot. This bug is now fixed. 
- When using a field where time zone information is displayed on the details panel of the schedule board, the field was incorrectly displayed as the time zone code, but not the actual time zone. This bug is now fixed. 
- When a requirement group record is opened from the schedule board requirement panel by double-clicking the record, it threw an error of insufficient privileges. This bug is now fixed. 
- Made an improvement to the date selection on the booking panel of the schedule board. If the start date is selected after the end date, then the end date should also be updated to the start date. If end date is selected before the start date, then the start date should be updated to the selected end date. 
- Unable to complete appointments without system admin security role privileges when customer service scheduling is installed. This bug is now fixed. 
- On the schedule board, we made an improvement to show the booking tooltips, when using the schedule board on a slower network (fast 3G speeds). 
- When a resource requirement record is created, a calendar record is created. When a resource requirement is deleted, additional logic is added to check if the calendar is used by any of the Dynamics 365 out-of-the-box record types, and if the calendar isn't used, then the calendar record is also deleted. A similar behavior is also put in place for the work hours templates. This deletion of the calendars improves the performance of the schedule assistant.

#### 3.12.42.4 - 2021 wave 1 Early access update 1

The release is only applied when an environment is opted into the early access of 2021 wave 1 and introduces the [resource scheduling 2021 wave 1](/dynamics365-release-plan/2021wave1/service/dynamics365-field-service/planned-features#scheduling) new and updated features.

In addition, this release includes the following changes that have the potential to change the existing system behavior or interface.

- Fixed a bug where the tooltip of a button **Return** on the new schedule board's embedded optimizer, isn't localized. 
- Fixed a bug on the new schedule board, where certain bookings with travel time weren't shown on the board; only the travel time was shown instead. With this fix, the bookings with travel time are shown as expected on the new schedule board. 
- When details view on the old schedule board is used for resources and a resource view is used where resource timezone is included as a field on the view, the timezone was displayed incorrectly as just a number. This bug is now fixed. 
- When requirement priority name is set to null, the schedule board would throw an error while loading. This bug is now fixed to handle null values on the requirement priority record names. 

#### 3.12.40.15 - 2021 wave 1 Early access

The release is only applied when an environment is opted into the early access of 2021 wave 1 and introduces the [resource scheduling 2021 wave 1](/dynamics365-release-plan/2021wave1/service/dynamics365-field-service/planned-features#scheduling) new and updated features. 

In addition, this release includes the following changes that have the potential to change the existing system behavior or interface. 

- Fixed a bug on the new schedule board when a requirement is dragged and dropped into the daily view, the **Create Booking** pane shows incorrect start and end dates. 
- When hovered on disabled buttons on the new schedule board, tooltips weren't being shown. This bug is now fixed. 
- When the date format is set to English (United Kingdom), the date fields on the "Create resource booking" pane of schedule assistant weren't respecting the above date format selected. This bug is now fixed.

#### 3.12.36.2

- Fixed a bug where resources with certain work hours calendar types (type = -1) weren't returned by the schedule assistant.
- When the date format is set to English (United Kingdom), the date fields on the create resource booking pane of schedule assistant weren't respecting the above date format selected. This bug is now fixed.
- When a schedule board tab’s setting requirement map filter view is configured to a resource requirement entity view that has a view definition including link entity filtering doesn't contain data, the map view on the tab, doesn't load. This bug is now fixed. 
- Keyboard navigation and selection issues on the "Characteristics – Rating" filter on the filter view of the schedule board are fixed. 
- When creating bookings for crew type resources using the schedule assistant, the travel times were incorrectly calculated from the organization unit of the crew resources. This bug is fixed, and the travel time is calculated from the location of the crew member resources. 
- When appointment scheduling feature is enabled, non-admin users were unable to mark the appointment record as complete. This bug is now fixed. 
- When certain filter panel customizations were used in the old schedule board, and access the bottom filters of the panel, the filter panel jumps to the top. This jump experience issue is now fixed. 
- When multiple child requirements are defined under a requirement group, there were intermittent timeout issues thrown. We fixed this bug by increasing the timeout duration.
- When apply territory filter setting is selected on the schedule board scheduler settings, on slow networks, this setting wasn't applying the territory filter on the bottom requirement panel. This bug is now fixed to make the territory filtering on the requirement panel work even in slow or latent networks.

#### 3.12.35.6

This release is a hotfix on Universal Resource Scheduling version [3.12.35.5](/dynamics365/common-scheduler/bug-fixes#312355)

- We fixed a bug that impacted the performance of the schedule assistant. 

#### 3.12.35.5

- When creating Bookings for Facility type Resources using Quick Book, the travel time is incorrectly added to the total duration of the Booking. This behavior is now fixed, and with the fix, the travel time is excluded from the total duration of the booking for Facility type resources. 
- For geographical regions, where Bing maps has no coverage, (ex: China, South Korea, and Japan), the distance and travel time calculations to the booking locations are calculated to the approximated values via **As The Crow Flies** (ATCF) method. 
- Fixed a bug where, the displayed time range on the schedule Board (old) is less than a day, then Resources routes aren't displayed on the Map view. 
- Made some performance enhancements to improve schedule assistant response time. 

#### 3.12.34.92

This release is a hotfix on Universal Resource Scheduling version [3.12.34.60](/dynamics365/common-scheduler/bug-fixes#3123460)
- We fixed a bug that impacted the performance of the Schedule assistant. 

#### 3.12.34.60

This release is a hotfix on Universal Resource Scheduling version [3.12.34.4](/dynamics365/common-scheduler/bug-fixes#312344)
- Fixed a bug where resources with certain workhours calendar types (type = -1) weren't returned by the Schedule Assistant.

#### 3.12.34.4

- Fixed a bug where schedule assistant and schedule board ignore start and end time inputs when duration is more than 24 hours when scheduling an opportunity record. 
- Fixed a bug where the search button remains disabled when **Time To Promised** is initially greater than search end, even if parameters are adjusted.
- Fixed a bug where a validation error occurred for `bookableresourcebooking.msdyn_milestraveled`. The value -0.999999690624 of type `System.Double` is outside the valid range (0 to 1000000000). 
- Booking tooltip on multiday views now shows in the correct booking length on the current schedule board and the next-generation schedule board.
- Fixed a bug where the booking is created with an incorrect duration when a user tries to create a booking using the quick book option.

#### 3.12.33.8

- When quick book is enabled on a schedulable entity and the requirement record is generated post booking record creation, the from date, to date, and duration attributes on booking setup metadata record weren't correctly mapped to the from date, to date, and duration fields of the resource requirement generated. This bug is now fixed.
- When Universal Resource Scheduling is used as the scheduling engine for appointments, and a system user, who doesn't have an associated bookable resource record, creates an appointment throws an error. This bug is now fixed.
- Fixed a bug on the legacy schedule board, where selecting an empty time slot on the board, and on searching for lookup records, all resource requirement records in the system show up instead of those matching the selected requirement panel at the bottom.
- Fixed an issue where non-admin Field Service users can't update the Booking records due to insufficient privilege on entity ```msdyn_schedulingfeatureflag```. This bug is now fixed.
- When a booking is canceled on the schedule board and then the work order (or requirement) record is again dragged to the same resource after the canceled booking, the travel time is incorrectly calculated as zero from the previous canceled booking. This bug is now fixed and the travel time is correctly calculated from the previous resource location.
- Fixed an issue where, custom `DateTime` fields from requirement record’s associated entities like work order aren't respecting schedule board tab time zone in requirements panel. With this fix, all `DateTime` fields on the requirement panel will be shown in the time zone of the schedule board tab.
- When a work hours template with a time off is applied to another resource, the time-off description and title weren't getting copied. This bug is now fixed.
- When a multi-day booking is created without an associated resource requirement record, changing Booking status on the booking throws an error, this issue is now fixed.
- The schedule assistant calculates the distance and travel time for the Resources to the booking via the default map provider Bing, this is only enabled when the field “connect to maps” is set to yes. There was an issue where regardless of the value selected, schedule assistant always used the default map provider to calculate distance and travel time. This bug is now fixed.
- Fixed an issue where updates to the bookings of a crew type resource aren't made, when booking rules are used. This bug is now fixed. Updates to the crew bookings will be made, even when booking rules are used.
- Fixed scroll jumping issue on the filter pane of the legacy schedule board for certain custom filter panel layouts.
- Fixed an issue where there are multiple time-off hours are used on a single day for a resource, the working hours aren't correctly calculated, and so incorrect working hours are reflected on the schedule board.
- Incomplete resource available time slots were shown on the legacy schedule assistant grid view when the fulfillment preferences intervals were used on the resource requirement record. This issue is now fixed, and the complete resource available time slots are shown.
- When quick book is enabled and used, the resource available time slots would respect the "Book based on" setting on the default schedule board settings and will show the resource available time slots based on value chose for **Book based on** - **Estimated arrival time** or **Start Time**.

#### 3.12.32.1

 - Fixed a bug on the legacy schedule board, when find **Substitution functionality** is used with in the schedule assistant, the UI was frozen. With this bug fix, **Find Substitution*** functionality can be used with in the schedule assistant mode. 
 - Fixed a bug on the List view mode of the daily view of new schedule board, where changing a booking status doesn’t reflect in the view. Now with the fix, the changed status will also reflect in the list view. 
 - Fixed a bug on the new schedule board where, the resource names are truncated when using right-to-left languages like Arabic. 
 - Fixed a label on the schedule assistant panel to show as **Booking suggestions**. 
 - Additional stabilization improvements were made on the new schedule board to prevent crashes on the board the schedule assistant panel, which is a feature in preview. 

#### 3.12.31.50 - 2020 wave 2 general availability

The following Universal Resource Scheduling 2020 Wave 2 features in general availability are included in this release.

- Next generation schedule board experience
- Predictive work duration (Preview)
- Enhanced calendar for requirements
- Embedded optimizer within schedule board (Preview)

This release also includes all the fixes included in the [2020 wave 2 early access](/dynamics365/common-scheduler/bug-fixes#version-312295-2020-wave-2-early-access) and [2020 wave 2 early access update 1](/dynamics365/common-scheduler/bug-fixes#version-3123011-2020-wave-2-early-access-update-1).
- Fixed a bug on the map view of the schedule board, where scheduled requirements with remaining duration equals 0 are still being shown as unscheduled requirement pin, leading to double requirements. With this fix, once a requirement is scheduled and Remaining duration equals 0, the pin won't be displayed as a requirement pin. 
- The days on the daily view of the schedule board are shown in right-to-left orientation for the right-to-left languages like Hebrew, Arabic. 
- Fixed a bug where a new requirement record is created, the status of the requirement record created isn't respecting the **Default Requirement Active State** value of the associated booking setup metadata record of the requirement. This bug is now fixed, and the default status of the newly created Requirement record will be based on the default requirement active status of the associated booking setup metadata record.
- When creating a booking for requirement groups using the quick scheduling feature, fixed a bug where the resulting errors (if any) weren't surfaced to the end user. Now if there are any errors during the creation of the Bookings, error message is displayed on the quick book interface. 
- When fulfillment preferences (intervals) are used on requirements, the schedule assistant shows the time slots, and the first time slot will be shown after the **Intervals begin** time. 
- Fixed a bug in the msdyn_SearchResourceAvailabilityForRequirementGroup API, where the last available time slot of a time range aren't being returned. 
- Added new additional solution health rules to detect if the following records are missing: 
 - Default schedule board setting.
 - Schedule board setting for the resource utilization view of the schedule board. 
 - Unsupported modification of the OOB web resources.
- When a resource on the booking is substituted with another resource on the schedule board and then find availability is used, fixed a bug where an error was thrown. 
- The date field on the schedule assistant list view is now fixed to respect the date formatting preferences of the user. 
- Fixed a bug where a booking is created using **Find Availability** functionality, and the booking method field is displayed as **Schedule Board**. This is fixed to show the booking method as **Schedule Assistant**.
- Fixed a bug where looking for available resources on the requirement groups, and **Least Busy** option on the schedule assistant is used, Resources returned weren't in the right order. This is fixed and only the least busy resources are returned on the top. 
- When preferred resource of resource preferences is used on the resource requirement record, the preferred resources aren't returned on the top of the recommended resources using quick scheduling. This bug is fixed, and the preferred resources are returned on the top. 
- Fixed a bug on the schedule board maps view, where the date picker isn't displayed when number of days displayed on the board is greater than one. This is now fixed, and the map view will display the date picker to show the map data of a specific day. 
- On the new schedule board, fixed an issue, where a resource is marked as **Display on Schedule Board** as **No**, resource is still being shown on the schedule board.

#### 3.12.25.5

- On the daily view mode of the schedule assistant, when **Ignore Duration** advanced setting is selected, all eligible resources weren't returned regardless of their availability. This bug is now fixed in this update. 
- Fixed a bug where quick book is used on a requirement group, and resources work in a different time zone than the time zone of the calendar of the requirements in the group, only a part of the available time slots were returned. With the fix, all available time slots are returned in this scenario. 
- When searching for resources in the daily view of the schedule board: once the searched Resources are returned, bookings of the resources aren't returned on the center area, until the board is refreshed. This bug is now fixed in this update.
- When a default search radius unit of kilometers is used and no available resources are returned, the schedule assistant crashes. This bug is now fixed, and users can expand the filter panel, even when no resources were returned to change the filters on the filter pane. 
- When quick book is used on a work order with an associated requirement group, and a resource is booked, **Booking Status selected is invalid for Work Order** error is thrown. This issue is now fixed. 
- When looking for available resources on a service activity record and **Least Busy** sort is selected, no available resources were returned. This is now fixed on the schedule assistant. 
- Quick book honors the default resource search radius defined on the booking setup metadata record of the schedulable entity (for example, work order, case, resource requirement, and so on).
- When any changes are made to a booking (like moving the booking or reassigning the booking), the custom booking rules defined by the user would get triggered. But extending  existing booking wouldn't trigger the booking rule. This bug is now fixed. 
- When fulfillment preferences (intervals) are used with a requirement group, the start date of the schedule assistant filter pane is populated incorrectly, which is now fixed in the update. 
- Schedule board center-area grid is misaligned when browser zoom is changed to 80 percent or 110 percent on Microsoft Edge and Google Chrome browsers. With this fix, the misalignment of the grid is fixed. 
- Fixed a bug where a custom entity can't be enabled for scheduling, when the name of the entity has more than 100 characters. With this fix, any entity that has a name with more than 100 characters can also be enabled for scheduling. 

#### 3.12.30.11 - 2020 wave 2 early access update 1

The release is only applied when an environment is opted into early access and introduces the [resource scheduling 2020 wave 2](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/planned-features#scheduling) new and updated features.

In addition, this release includes the following changes that have the potential to change the existing system behavior or interface:

- When searching for resources in the daily view of the schedule board: Once the searched resources are returned, bookings of the resources aren't returned on the center area, until the board is refreshed. This bug is now fixed in this update.
- When different capacities are used for a resource before and after a break, (for example 11 AM to 12 PM, working with capacity is 1; 12 PM to 1 PM is a break, and 1 PM to 2 PM, working with capacity 2) then the break time is shown as working time on the schedule board. This bug is fixed in this update. 
- Fixed a bug where quick book is used on a requirement group, and resources work in a different time zone than the time zone of the calendar of the requirements in the group, only a part of the available time slots were returned. With the fix, all available time slots are returned in this scenario.
- Fixed a bug where the search time window of the resource requirement is greater than the time range displayed on the schedule board and schedule assistant, the resource booked hours capacity on the resource cell weren't displayed. The expand and collapse button next to the resource in daily, weekly, and monthly views were also not displayed.
- When you enable any entity for scheduling (for example, case, lead, account), enable quick book feature on the booking setup metadata record of this schedulable entity, and set **Disable Requirement Auto Creation for Bookings** to yes. The resource requirement records won't be generated post the creation of the booking record.

#### 3.12.29.5 - 2020 wave 2 early access

The release is only applied when an environment is opted into early access and introduces the [resource scheduling 2020 wave 2](/dynamics365-release-plan/2020wave2/service/dynamics365-field-service/planned-features#scheduling) new and updated features.

In addition, this release includes the following changes that have the potential to change the existing system behavior or interface:

- Fixed a bug where a booking rule is used and throws a custom notification on the schedule assistant’s **Create Resource Booking** pane, the **Booking created successfully** wasn't being displayed. Now with the fix, even when booking rules are defined, the booking creation success notification is displayed. 
- When a custom date format (for example, dd/mm/yyyy) is used, the booking tooltip's displayed start time and end time are displayed incorrectly. This bug is now fixed. 
- Use openWebResource API to open schedule assistant in the client-side tools like Unified Service Desk, so that no custom actions need to be called to open the schedule assistant. 
- For organizations using Japanese language, in the schedule board’s date picker control now shows the right string in Japanese for the months displayed. 
- For organizations using right-to-left languages like Arabic as their base language, the short weekday names are now displayed on the date picker of the schedule board. Also fixed tooltip positioning issue for different components of the schedule board. 
- Fixed navigation using keyboard tab key on the move bookings to a different Day dialog of the schedule board, to move the focus from the booking statuses picker to the ok button, after a booking status is selected. 
- When a requirement status record is used as a default requirement status in the booking setup metadata record of a schedulable entity, the deletion of the requirement status record won't be restricted. 
- On the schedule board, the fields on the booking tooltip with long strings were truncated. With this fix, the long strings are word wrapped into a new line. 
- When an open area is selected on the schedule board, a pane opens with a lookup for the resource requirement record. Fixed a bug where the default view on this lookup wasn't changeable. With this fix, the resource requirement view can be changed to any other active view of the resource requirement entity. 
- On the client extension entity form, the lookup field for the web resource is fixed to show all the WebResource lookup views for CSS, JavaScript, and RESX views. 
- Fixed a bug when requirement groups are used with the work orders; on the schedule assistant, the booking status drop-down on the **Create Resource Booking** pane shows not just the booking statuses of the work order, but also related to other entities. With this fix, the booking status drop-down now only shows the booking statuses of the work order. 
- When a resource requirement record and a bookable resource are selected on the schedule board, and the book button is selected, the **Create Resource Booking** pane opens up with the start and end dates populated based on the requirement selected. When the resource selection is changed, the selected start date and end date are being reset. This bug is now fixed. 
- Improved the tooltip description of the field **Actual Travel Duration** field on the scheduling tab of the bookable resource booking to **Shows the total travel duration. Calculated based on the difference between the Bookable Resource Booking's Start Time and Actual Arrival Time.**
- The edit button on the business closure ribbon is hidden, as this button had no action on the business closure records in the view. 
- Removed unnecessary debug console messages for the business closure entity views. 
- When a new business closure record is created, the duration field is calculated incorrectly by adding an additional day. This bug is now fixed, and the duration field is calculated based on the start time and end time selected. 
- When a requirement status record is created and saved, the requirement status lookup field is read-only, so that this value can't be changed once the record is saved.
- When a requirement has multiple booking records associated, and one of the booking’s resources isn't active, the deactivated resource is filtered, and the uncaught exception is handled. 
- Fixed a bug with the time slot selection on the create resource Booking pane. With this fix, when **Book Based on** setting is set to **Estimated Arrival**, and the user selects a suggested time in the schedule assistant, the time they select is populated as the estimated arrival time in the booking panel. When **Book based on** setting is set to **Start Time**, and the user selects a suggested time in the schedule assistant, the time they select is populated as the start time in the booing panel. 
- Added additional checks on the schedule board default settings to prevent schedule board crash with the **Object reference not set to an instance of an object** error. 
- Fixed a bug where the focus on the resource search control on the weekly view of the list view type of the schedule assistant is lost when typing the resource name.
- The custom date format is now supported on the quick book pane. 
- When a booking is created on the schedule board with duration of zero minutes, **Duration must be greater than 0 minutes** is displayed in English on non-English orgs. This bug is fixed, and the string is now localized.

#### 3.12.24.5

- Fixed a bug where the search time window of the resource requirement is greater than the time range displayed on the schedule board and schedule assistant, the resource booked hours capacity on the resource cell weren't displayed. The expand and collapse button next to the resource in daily, weekly, and monthly views were also not displayed.

#### 3.12.24.4

- When you enable any entity for scheduling (for example, case, lead, account), enable **Quick Book** feature on the **Booking Setup Metadata** record of this schedulable entity, and set **Disable Requirement Auto Creation for Bookings** to yes. The resource requirement records won't be generated post the creation of the booking record. 
- The bug where there are multiple pages of available resources suggested on the schedule assistant, only the resources in the first page set were shown and resources on higher pages weren't shown. This bug is fixed, and paging through to next pages, resources will be shown as expected.
- When there are multiple work hours are entered on the same day for a resource (for example, 8 AM to 3:30 PM and 2 PM to 5 PM), there was a bug where the resource work hours calendar was only showing work hours as 2 PM to 5 PM. With this fix, the calendar for the resource would show that the resource is working 8 AM to 5 PM. Also, the same should be reflected on the schedule board. 
- When a resource has working hours (for instance, 9 AM to 5 PM on a day) and has time off 12 PM to 1 PM, there's a bug where schedule board shows that the resource has no working hours on that day, though the time off is for only one hour. This bug is fixed, and with this fix, the resource should show as working from 9 AM to 12 PM and 1 PM to 5 PM on the schedule board. 
- When creating a resource requirement using a work hours template, performance improvements are made to reduce the time of creation for the resource requirement record. 
- When the resource work hours are entered by using non-recurrence patterns for a large number of days, and large number of resources (for instance, more than 2000 resources in the org), when looking for available resources, the schedule assistant takes almost 40 seconds to load resources. Performance improvements are pushed as part of this fix, where in this case, the schedule assistant loads faster (around five to ten seconds, largely based on the amount of data). 

#### 3.12.23.71

- The issue with the filtering on the lookup type fields on the schedule board's requirement panel is fixed. 
- When hovered on the bookings on the schedule board, the tooltip was shown instantly, which sometimes blocked the view or blocked using right-click on the bookings. This issue is now fixed by adding a hover delay. When hovered on the booking, tooltip is displayed with a delay.

#### 3.12.23.27

- The rendering issue for tooltips on bookings of the schedule board is now fixed, by making the tooltip scrollable when the height of the tooltip is larger than the browser size. The hyperlinks on the tooltip can also be selected to open them in a new browser window.
- The text **Hide default requirement panels** is now made visible on the schedule board tab settings under the **Requirement Panels** section, which was previously only partially visible.
- Fixed an issue where entering a comma on the filter control of the filter panel was clearing the input on the filter control. With the fix, the comma won't influence the autocomplete, which was causing issues for customers who have a comma in their filter options.
- If the work hours tab is renamed or removed from a custom bookable resource form, when you select the **Show work hours** button, an error is displayed: **The Work Hours tab has been renamed or removed from this form. Please update this form to include the Work Hours tab.** Update so that the work hours tab can be added back to the form.
- Fixed an issue on the **Create resource booking** panel on the schedule board. With the fix, the **Start Date** and **End Date** on the panel will always reflect the **From Date** and **To Date** of the requirement selected in the **Requirement Panel** at the bottom of the board.
- The map pins of the resource requirement records are loaded on the map view of the filter panel on the schedule board, based on the view that is defined on **Requirement Map Filter View** on schedule board settings. We fixed the issue where, if the view used here has no filters on the view definition, the map panel never completes loading. With this fix, the map panel would load, regardless of the filters on the view used.
- Fixed an issue where **Universal Resource Scheduling** is used as the scheduling engine; users who aren't system administrators were unable to complete the appointment records. With the fix, any user with privileges to complete the appointment record can mark the appointment as complete.

#### 3.12.22.9

- For organizations that have [schedule board preview enabled](https://aka.ms/scheduleboard), the schedule board preview can be accessed from **Field Service** application sitemap along with **Universal Resource Scheduling** application sitemap.
- Fixed an issue where booking tooltip blinks when the height of the tooltip is greater than the height of the visible center Gantt area, where bookings are displayed on the schedule board. With this fix, the tooltip wouldn't blink and the user would be able to select the hyperlinks on the tooltip to open the respective record in a new window.
- Fixed the issue where [intervals](/dynamics365/common-scheduler/fulfillment-preferences) functionality of fulfillment preferences wasn't working on the schedule assistant.
- Resolved the issue of duplicated time slots for the resources on the list view type of the days view of the schedule board.
- Multiple calls to retrieve data in the list view type of the days view are reduced to one call, in order to improve schedule board performance.
- Fixed the issue where available time slots of resources are displayed differently on schedule assistant and the quick scheduling pane for the schedulable entities that don't have an associated resource requirement record.
- The horizontal and vertical view types are now hidden from the requirement group's find availability or schedule assistant screen.
- Fixed the error **The start address and end address cannot be empty**, which is incorrectly thrown on the **Get Driving Directions** functionality on the schedule board, due to an uncaught exception.
- Advanced find on the business closures entity is now supported.
- When using the schedule assistant/find availability functionality, the available time slots should be shown in the same timezone of the requirement calendar; however, if a schedulable entity like case doesn't have a requirement record associated, then the results need to be shown in the timezone of the CRM user preference.
- The issue of resource name truncation in the days view of the schedule board is now fixed.
- Fixed the focus shifting issue on the schedule board, where focus is shifted to a previous booking in focus, when booking status of the bBooking assigned to a resource at the bottom of the resource list. With this fix, the focus would stay on the booking in context.
- Fixed a translation issue on requirement groups in Japanese, where the name of the requirement or subgroups changes from Japanese to English when the record is saved.
- Quick scheduling now supports and handles different date format styles like English (South Africa).  
- Fixed an issue with the **Allow Overlapping** functionality on the bookings. With this fix, when a booking is marked as **Allow Overlapping** set to yes, the schedule assistant (find availability) will show the above booking as an available time slot if the **Allow Overlapping** advanced setting on the filter view is selected.

#### 3.12.21.9

- The following Universal resource Scheduling 2020 Wave 1 features in GA and preview planned are included in this release:
  - Next generation schedule board experience (preview)
  - Enhanced work hours calendar for resources
  - requirement dependency for efficient workflow
  - resource scheduling dashboard
- This release also includes all fixes included in the [3.12.9.76 EA package](/dynamics365/field-service/field-service-version-history-resource-scheduling#312976---april-2020-wave-1-early-access).
- Fixed an issue where the booking method on booking panel wasn't selectable on the list view of the days view in schedule board.
- Fixed a caching issue on the **Get Driving Directions** pop-up functionality of the schedule board, where previously cached values were being used for calculating the route.
- Resolved the incorrect location displayed for the booking on the map view of the schedule board, due to the incorrect formatting issue in conversion of the latitude and longitude on the map in languages like German.
- Fixed the issue where bookings of some schedulable entities can't be moved to a different day in multiday views like days and weeks views on the schedule board.
- Fixed the issue when a requirement is dragged on to a crew resource on schedule board, a booking is only created for the crew resource and not the underlying active crew resources.
- Fixed an issue where a custom JavaScript is used in the schedule board client extensions to set the default filter values, but the prepopulated default values are only displayed when the respective filter control is selected.
- Fixed an issue where quick scheduling is used on a schedulable entity without associated resource requirement record, and search start and search end dates are passed as the same day; available time slots were displayed for three days rather than one passed in day. With the fix, the available will only be displayed for the date passed in.
- Fixed an issue where booking tooltips aren't displayed on hover, when network latency is high.  
- Fixed a null reference exception for booking status metadata checks during the upgrade to improve upgrade experience.

#### 3.12.5.13

- resource location can be displayed on the map view of the schedule board's daily view, using the custom entity using the custom geo data settings in the scheduling parameters.
- Fixed the issue with the action msdyn_SearchResourceAvailability wasn't taking the ConsiderTravelTime parameter into consideration when providing the available time slots.
- Fixed upgrade errors while generating the booking setup metadata records and a few other upgrade improvements.
- Fixed the issue where filters weren't saved on the resource utilization view.
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
- Performance on the schedule board improved by just loading the requirements that aren't location agnostic on the map view.
- Fixed the filter panel crash when using the fetch-based filter value and saved as default value.
- Fixed the issue with the schedule assistant filter layout when a filter is changed from multi combo field to non-multi combo filter.
- When **Double book if needed** option is checked on the schedule assistant booking panel, even though the resource doesn't have enough availability for the requested hours, the resource can be double booked up to 24 hours in one day.

#### 3.12.9.76 - April 2020 Wave 1 Early Access

- Fixed a performance issue when upgrading from Field Service version 7.x to version 8.x.  
- Fixed an issue with printing the get driving directions action on the schedule board.  
- When quick scheduling is used to schedule an entity that doesn't have an associated resource requirement, results were always shown in UTC timezone, which is now fixed. The results should always be shown in the user's timezone if there's no requirement calendar.
- Tooltips are now supported on the sort options of the schedule board.  
- A new warning message is now introduced on editing the schedule board settings records: "Modifying these settings has the potential to break the corresponding schedule board tab in a way that can't be automatically undone".
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

#### 3.12.4.9

- Fixed an upgrade issue related to the timezone conversion of the TimeGroupDetail record.  
- Fixed incorrect booking time offset on daylight savings time dates for Auckland timezone.  
- Fixed the issue where some resources show unavailable on the schedule board, due to the number of calendar rules on all the resources on the schedule board.  
- When there are characteristics on the filter panel that are paged, the rating value of the selected characteristic is lost in the filter, which is now fixed.  
- Fixed the flickering issue on the second page of the open requirements tab of the requirement panel.  
- Fixed the alignment of the available time on the days view of the schedule assistant.  
- The filters on the filter panel now support text fields.  

#### 3.12.3.9

- The one hour offset issue for the bookings created on the schedule board is fixed in the Brazil daylight savings time.
- The caching issue with the schedule assistant's default availability view setting is set to board is now fixed.
- When a new booking is created on the days view of the schedule board, the board will be refreshed automatically.
- resource requirement map pins are loaded, only when the map view is opened on the filter panel of the schedule board.
- Fixed an upgrade issue due to bad data in the filter values.

#### 3.12.2.114

- When the schedule board map view is opened, the map automatically zooms out to show all the map pins.
- The resource lookup is displayed on the schedule board in Arabic.
- On the schedule assistant results list view, work start time aligns with the estimated arrival time values on the create resource booking pane.
- Added additional handling to avoid the corruption of the booking setup metadata and the schedule board settings records.
- Bookings can be edited in the days view of the schedule board by right-clicking on the booking and selecting **Edit**.
- The select resources dialog opens and loads successfully on the filter view of the schedule board, even when there are more than 100 resources enabled to be displayed on the schedule board.  
- When Turkish language is enabled on the org, resource requirement records load under the **Unscheduled Work orders** tab of the requirement pane of the schedule board.
- When double-clicking on the save button the new bookable resource booking form, wouldn't create duplicate records.
- Resources can be searched on the schedule board by their name in the search resources search box.
- map view on the schedule board only shows the pins for the requirements that are returned from the requirement view configured for requirement map filer view setting on the map settings of the schedule board tab settings.
- When Hebrew language is enabled on the org, schedule board loads in the Chrome with browser zoom at 90%.
- The requirement demand pie chart on the schedule assistant information at the bottom is accessible, via screen readers.

#### 3.12.1.158

- Workflows can be triggered when resource requirements are created with any allocation method.
- When upgrading URS from version 2.x to version 3.x, resource filters on the schedule board tabs are preserved.

#### 3.12.0.448

- Grid alignment issues while scrolling on the schedule board for right-to-left languages (like Hebrew, Arabic) are fixed.
- When a new route is created for a map pin selected on the map panel, the route will stay on top of other routes, even after the auto refresh, which happens when a booking is created or modified.
- On the list view of the schedule board, any linked entity record can be opened by using keyboard, by hitting on the space bar when focused on the linked entity.
- The warning message notification on the schedule assistant is made user-friendly, when Maps aren't enabled for a resource requirement when work location is onsite.
- The selected values of the filter "pool type" are also saved along with other filters, when the current filters are saved as default filters.
- When a crew type resource is booked, only the working members of the crew will be booked, crew members, who aren't working, won't get booked.
- Custom date fields added to the filter panel as custom filters, will also respect the time zone of the schedule board tab (under Scheduler settings)
- When schedule board settings are opened from the booking setup metadata record of the Schedulable entity, by clicking the Cancel button on the schedule board settings, the form will be closed.
- The scrolling issues on the vertical view of the schedule assistant are fixed.
- On the list view type of days, weeks, and month views of schedule board, the focus will stay on the resource Search box until the typing is complete until focus is moved to a different area of the schedule board.
- The quick scheduling experience searches for available resources in the date range provided in the requirement group and displays available resources on the book resources panel in the date range.
- On successful creation of bookable resource booking record in the offline mode, no unintended warnings are displayed on the form.
- When looking for a substitute resource on a booking using the "Find Substitution" via schedule assistant, the resource can be substituted on the suggested time slot by clicking on the "Substitute" button, when hovered on the suggested time slot.
- When there are more than 30 suggested resources on the schedule assistant, there will be paging of resources and more suggested resources can be reached by scrolling to the next page.
- When a map pin is selected for a booking on the schedule board, after editing the selected booking, (by dragging and extending the booking), the map pin stays selected.
- Schedule board will support booking alerts are in large number (~200).
- Only active booking statuses are displayed on the booking status dropdown field on the booking panel of schedule board, when creating bookings.
- When searching for available resources for a requirement group, suggested resources will always be shown in list view only.
- Resources on the schedule board tab can be selected via Select resources under the filter Options on the Internet Explorer Version 11.
- When calling the msdyn_SearchResourceAvailability action using a requirement with a fulfillment preference for time group as input, the output time slot of the action will contain valid TimeGroupDetails.
- Bookable resource bookings can be created on the daylight saving days (entering and exiting daylight savings time).

##### Enhancements

- Accessibility improvements are made on the schedule board and schedule assistant.

#### 3.11.0.421

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

##### Enhancements

- Support for preferred and mandatory resource in finding available resources.
- Usability improvements to the facility search scenarios via quick scheduling experience.

#### 3.10.0.239

- Only valid hex characters can be entered on the status color field on booking status form.
- The overlapping bookings in the vertical view of the schedule board are separated by 1-px spacing.
- Non-working hours color name is consistent across the schedule board tab settings and the schedule board settings configuration record.
- Long names will be wrapped inside the booking tooltip.
- Deletion of a resource isn't allowed if it has any group memberships active or inactive, parent, or child, has any associations active or inactive, resource 1 or resource 2.
- When default sorting is added to the schedule assistant retrieve constraints UFX query in the default schedule board settings, the sort by filter of the schedule assistant is pre-filled with the field by which sorting is done and the returned resources are sorted accordingly.
- A few accessibility issues on the schedule board are fixed.
- Schedule board to load the resources in days, weeks, and month views with resources having a valid calendar and wouldn't fatally fail if a resource has an invalid calendar.
- Combo control filter with multiset to false, the selected value will show in the filter.
- Active resource requirements view is sorted on created on by descending order.
- Derive capacity from group members field on the pool resource form can be set to yes or no as required.
- Search resources can be used to search resources in the suggested resources in the list view of the schedule assistant.
- Custom booking template with fields from linked entities of bookings is supported.
- Resource type filter on the schedule assistant won't remember the previously selected values, once unselected.
- The schedule assistant loads as expected when clicked on book button on a work order form in Arabic.
- When a booking is created by schedule assistant, the booking method field on the booking form is populated as schedule assistant.

#### 3.9.0.42

- The filter isn't enabled for the owner column on the unscheduled work orders requirements view in the requirement grid of the schedule board.
- The refresh button on the requirement grid is disabled while the grid is refreshing the data.
- Alignment for resource icons and the zoom slider on the schedule board are fixed for Arabic language.
- When searching for resources in one view like horizontal, when switched to another view, like list view, the search is still retained along with the search text and results.
- The bookings can be moved to a different time or resource by dragging and dropping the booking on days, weeks, and month views of the schedule board.
- Quick scheduling would be using the "As The Crow Flies" approximations to calculate travel time if Bing maps integration isn't enabled.
- Improved error messaging on the schedule assistant when looking for available resources and on the schedule board when displaying the bookings.
- When auto update booking travel is enabled, and onsite bookings are created by the quick scheduling, the travel time to the subsequent bookings is updated based on the location of the previous booking.
- The schedule assistant search for available resources are successful with continuous multiple associations on a single day for a resource type facility.
- When an onsite requirement is selected in the requirement grid, the location pin is selected and focused in the map view. Once clicked on "Find Availability," the location pin on the map view stays selected entering and exiting the schedule assistant.
- Alignment of the fields on the fulfillment preferences form is fixed.
- Alignment of the sort arrows on the sort options control on the schedule board is fixed.
- Time out issues request to msdyn_RetrieveResourceAvailability is posted from a web app are fixed.

##### Enhancements

- FetchXML query is replaced by query expression for the action that fetches work order bookings to improve the performance.

#### 3.8.0.105

- The date selector on the schedule assistant list view is dimmed because it has no effect on the resources displayed when searching for availability of a requirement or a work order.
- When booking a schedulable entity record, only the booking status that is mapped to the booking status field logical name of the booking setup metadata record of the schedulable entity will be on the schedule assistant. For example, when scheduling a work order, only the option set values of the field msdyn_fieldservicestatus will be displayed in the booking status drop-down on the schedule assistant,
- When searching for availability of resources on a requirement, the number of matching resources returned in the search on the schedule assistant is limited to the value set on the field resource availability retrieval limit on the default metadata settings of the booking setup metadata record. The default value of resource availability retrieval limit is 100.
- Only one booking setup metadata for an entity can be created.
- For German locale, on the schedule assistant, remaining duration doesn't overlap with the pie chart visual next to it.
- Only Active resources can be added to a resource pool or resource crew's children.
- A few accessibility issues on the schedule board are fixed.
- The resource requirement form can be customized to remove optional fields like resource type from the form.
- Selected sort on the schedule board is determined by the Sort result by filter on filters.
- The booking alerts template field on the default schedule board settings shows the default HTML template value.
- **Book** and **Book & Exit** buttons on the schedule assistant are enabled only when at least one eligible resource is returned on the schedule assistant.
- Multiple characteristics can be selected on the filters on the schedule board.
- A booking can't be deleted when it has an associated booking alert.
- When booking a requirement in the weekly view or monthly view of the schedule assistant, if the availability search start date is today and isn't the first day of the week or month, the start date will correctly default to today, so that the book button is enabled.
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

##### Enhancements

- Performance improvements to schedule board refresh times when multiple crew type resources are present on the schedule board.
- Performance improvements to searching for resource availability for requirement Groups.
- Reduced unnecessary calls to retrieve the resource requirements name and booking setup metadata. Other duplicated calls are also reduced when searching for availability.
- Self-service scheduling API is now available to schedule the single resource requirement, with a corrected process name **Resource Scheduling – Search Resource Availability** and unique name msdyn_searchresourceavailability.
- From and to date fields on the resource requirement entity are restricted to have only the User Local behavior to avoid Time Zone functionality loss on the schedule assistant and loss of the time zone data on resource requirements.
- Added a suggestion to service health diagnostics to show the suggestion/fix with manual steps when resource booking sync job is disabled but the feature synchronizes resource bookings with outlook is enabled.
- When using URS on Unified Service Desk, the schedule board can be loaded without having to pass the full Unified Interface context.
- Quick scheduling now supports scheduling of onsite requirements.

#### 3.7.0.70

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

##### Enhancements

- Made improvements to uptake new endpoint Bing distance matrix APIs.
- Self-service scheduling API is now available to schedule the single resource requirement.
- The work location for new requirements added to a requirement group is now inherited from the work location of the existing requirements in the requirement group, and is kept in sync.
- The calendars of the requirements of a requirement group are kept in sync and share the same calendar. Changing a calendar or time zone for one requirement updates it for all the requirements of the requirement group.
- When booking a requirement group, the schedule assistant is launched in the time zone of the requirement group's requirements because they all share the same requirement.
- Performance improvements to searching for resource availability, viewing bookings on the schedule board, creating bookings for crews, creating bookings in the hourly views of the schedule board, and when using other URS plug-ins.

#### 3.6.0.18

- On the schedule assistant, the radius unit behavior reflects kilometers or miles as per the preferred unit of distance when "Search for" field is changed.  
- The zoom level on the "Map View" on the "Filter Panel" will be preserved after entering or exiting the Schedule assistant search. 
- Only activated members of a crew get booked when a crew is booked.
- On the schedule board setting for schedule assistant, the unavailable resources field can be changed from "Unavailable resources don't appear" to "Unavailable resources appear dimmed" to show the unavailable resources on the schedule assistant.
- Alignment of scheduler settings controls.  
- On a schedule assistant search for available resources on a location agnostic resource requirement, the "Time From Promised" and "Time to Promised" time window precedes over the "Search Start" and "Search End" time window, and the recommendations will be presented to make sure the technician can start work in the "Time From Promised" and "Time To Promised" window.
- Onsite multi-resource requirements will be presented with travel time in the schedule assistant recommendations.
- The filter panel's characteristic field on the schedule assistant is populated with the characteristic from the resource requirement or work order.
- Multiple issues preventing upgrade.
- Resource utilization of a resource on non-working day, along with the color code of the non-working day.
- Dragging the technician travel route to a requirement pin to schedule the booking in the maps view on the filter panel of schedule board.
- The schedule board setting "Order Number" default maximum value is increased to 1000 from 100.
- Duration field value text in Hebrew on schedule assistant.

##### Enhancements

- When inserting a booking between two bookings or reassigning a booking to another resource, the travel time of all associated bookings will be recalculated and updated on hourly schedule board and schedule assistant. This feature can be enabled by "Auto Update booking travel" field under **Resource Scheduling** > **Settings** > **Administration** > **Scheduling Parameters**.
- When the **Book** button is used on the resource requirement and the timezone on the pop-out schedule board is updated, the date time fields on the bottom requirement info panel will reflect the changed timezone.
- All the date and times in the filter panel and requirements panel on the schedule board are updated when the time zone is changed in the scheduler settings on the schedule board.
- Various performance improvements when searching for resource availability.

#### 3.5.0.107

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

##### Enhancements

- Improvements are made to the date time controls by leveraging the Office fabric UI control on the resource requirement, fulfillment preferences, and time group detail forms.
- Scheduling Health Diagnostics provides capabilities to detect and suggest self-healing options with regard to:
  - Unsupported customizations on internal use only web resources.
  - Actions and workflows that are in draft state.
  - Essential SDK message processing rules that are in disabled state.
  - Missing metadata records such as booking setup metadata records, default UFX query values.
- Improvements are made to the icons on the booking right-click menu.
- If **Connect to Maps** is disabled, the travel times will be calculated based on the "Crow fly" approximations.
- Performance improvements for the retrieve resource availability action calls on the multi-resource requirements with fulfillment preferences (intervals).

#### 3.4.0.141

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
- Resources that are location agnostic, yet are associated to a facility, will return in facility searches for the time they're associated to the facility.
- Issue selecting pool type on schedule board filter panel while using Firefox browser.
- Selecting cells in daily, weekly, and monthly boards while in schedule assistant now passes information to the booking panel properly.
- Schedule boards that have characteristics with rating values saved no longer prompt user to enter a rating value.
- Issue on certain devices where current timeline bar on schedule board wasn't showing correct time.
- Work location on booking is now set properly when using drag and drop on schedule board.
- Misaligned labels for languages that read right to left.
- Issue loading schedule board in Internet Explorer 11.
- Issue creating schedule alerts from certain places.

##### Enhancements

- Various performance improvements when creating bookings.
- Dragging to extend a booking on multi-day schedule boards opens booking panel instead of booking dialog.

#### 3.2.0.405

- If a booking has the work location field set to location agnostic, the booking will be treated as location agnostic even if there's a latitude and longitude value on the booking.
- Issue with schedule board list view refreshing when changing between hourly and daily.
- When searching for a resource in the resource search bar on the schedule board list view, if no resources can be found, the board properly removes all resources.
- Issue dragging a requirement from the map to the schedule board while using Firefox browser.
- Changing "derive capacity" field on a pool resource from no to yes now triggers the calendar to be calculated based on the child resources of the pool.
- Issues when changing between horizontal and vertical schedule board while in split view.
- Issue loading schedule board with many explicitly saved resources.
- Resource's location is now properly taken from the facility it's associated to.
- When using a language that reads from right to left, the resource name is now properly rendered on the schedule board.
- When launching the schedule assistant from a schedulable entity, the user now lands back on the same form after clicking book and exit.
- Schedule board no longer shows resource with a capacity greater than 1 as available all day.
- When booking a requirement group using the schedule assistant, the booking status dropdown now properly filters to the booking statuses for that schedulable entity.
- Issues loading requirement group control in the Microsoft Edge browser.
- When using the schedule assistant to schedule a requirement group for a facility, there's no longer a travel time conflict between the facility and the resources.
- Double booking option in schedule assistant on daily, weekly, and monthly boards now properly books the resource even if the resource has no remaining capacity.
- Appointment schedule board settings are now generated properly.
- Issues in certain scenarios where schedule board had issues loading in Internet Explorer.
- "Supplied DateTime represents an invalid time" error.
- Error message when scheduling a single requirement to a crew resource.

##### Enhancements

- Resources associated to facilities will no longer return in onsite schedule assistant searches. This prevents customers from accidentally scheduling a resource that should be stationed at a facility from going to a customer location.
- Resources that aren't associated or related to a facility will no longer return in facility searches. Currently, when a resource is set up to work at a facility through an association or as a child resource of a pool, URS doesn't account for travel to the facility.
- When using the schedule assistant to schedule a requirement group, if the requirement's work location is set to facility, and there are no options selected under the "part of same" attribute, the search executes as if part of same "resource Tree" is selected.
- Saving a filter on the schedule board now shows a green confirmation check mark instead of a yellow warning symbol.
- Warning message will now be displayed when trying to change the latitude or longitude field on a booking.
- Added validation to check that if a resource is associated to a facility, then it shouldn't be allowed to be a child resource of a pool associated to a facility or facility pool for the same time frame.

#### 3.1.0.166

- If a booking has the work location field set to location agnostic, the booking is treated as location agnostic even if there's a latitude and longitude value on the booking.
- Issue with schedule board list view refreshing when changing between hourly and daily.
- When searching for a resource in the resource search bar on the schedule board list view, if no resources can be found, the board properly removes all resources.
- Issue dragging a requirement from the map to the schedule board while using Firefox browser.
- Changing "derive capacity" field on a pool resource from no to yes now triggers the calendar to be calculated based on the child resources of the pool.
- Issues when changing between horizontal and vertical schedule board while in split view.
- Issue loading schedule board with many explicitly saved resources.
- resources location is now properly taken from the facility it's associated to.
- When using a language that reads from right to left, the resource name is now properly rendered on the schedule board.
- When launching the schedule assistant from a schedulable entity, the user now lands back on the same form after clicking book and exit.
- Schedule board no longer shows resource with a capacity greater than 1 as available all day.
- When booking a requirement group using the schedule assistant, the booking status dropdown now properly filters to the booking statuses for that schedulable entity.
- Issues loading requirement group control in the Microsoft Edge browser
- When using the schedule assistant to schedule a requirement group for a facility, there's no longer a conflict of travel time between the facility and the resources.
- Double booking option in schedule assistant on daily, weekly, and monthly boards now properly books the resource even if the resource doesn't have any remaining capacity.
- Appointment schedule board settings are now generated properly.
- Issues in certain scenarios where schedule board had issues loading in Internet Explorer.
- "Supplied DateTime represents an invalid time" error.
- Error message when scheduling a single requirement to a crew resource.

##### Enhancements

- Resources associated to facilities will no longer return in onsite schedule assistant searches. This prevents customers from accidentally scheduling a resource that should be stationed at a facility from going to a customer location.
- Resources that aren't associated or related to a facility will no longer return in facility searches. Currently, when a resource is set up to work at a facility through an association or as a child resource of a pool, URS doesn't account for travel to the facility. Therefore, only resources set to work at a facility returns in facility searches.
- When using the schedule assistant to schedule a requirement group, if the requirement's work location is set to facility, and there are no options selected under "part of same" attribute, the search executes as if part of same "Resource Tree" is selected.
- Saving a filter on the schedule board now shows a green confirmation check mark instead of a yellow warning symbol.
- Warning message will now be displayed to a user if they try to change the latitude or longitude field on a booking.
- Added validation to check if a resource is associated to a facility then it shouldn't be allowed to be a child resource of a pool that is associated to a facility or facility pool for the same time frame.

#### 2.4.11.59

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/14/enhancements-and-bug-fixes-in-universal-resource-scheduling-urs-version-2-4-11-59/).

#### 2.4.10.56

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/release-notes-for-universal-resource-scheduling-version-2-4-10-56/).

#### 2.1

[Read a blog post about the bug fixes](https://cloudblogs.microsoft.com/dynamics365/it/2017/05/19/universal-resource-scheduling-solution-for-dynamics-365-update-6-1/).

## Resource Scheduling Optimization Add-in

### Earlier release waves

For release notes and version history of the current release wave, see [Resource Scheduling Optimization version history](field-service-version-history-resource-scheduling-optimization.md).

#### 3.3.5.199

- Resource Scheduling Optimization no longer fails with constraint violations; it will continue while skipping over the identified resource(s) that have violations. For more information, go to [Booking lock options](booking-lock-options.md).
- Bug fix: Addressed issue where ResetRSO fails with timeout exception on UR28.

#### 3.3.3.12

- Bug fix: Addressed the problem of Resource Scheduling Optimization jobs getting stuck in the 'Optimizing' state, which happened due to long running write operations from Dynamics 365 into Resource Scheduling Optimization.
- Bug fix: Adjusted the degree of parallelism that Resource Scheduling Optimization was using, to write results back to Dynamics 365. This was done to prevent throttling, which could cause optimization request failures.

#### 3.3.2.4

- Bug fix: Addressed issue where the predicative travel info icon wasn't able to be selected and hovering caused formatting issues.
- Bug fix: Addressed issue where single resource optimization requests with no schedulable requirements are canceled with message: "This request was canceled as none of the selected resource requirements or bookings were valid."

#### 3.3.1.38

- Bug fix: Addressed issue that caused Resource Scheduling Optimization to delete bookings that were locked to resource and time, if the booking was the length of an entire shift. 
- Bug fix: Addressed issue that prevented Resource Scheduling Optimization from deleting bookings that needed to be deleted, if they weren't associated with a resource requirement record.

#### 3.3.0.115

- Improved predictive travel time user experience. Allows users to distinguish bookings that used predictive travel (and thus have more accurate travel time that includes historical traffic) from those that didn't.
- Fixed bug in which 401 error was thrown in creation of account and contact records after Field Service autoupdate. Error message: "The remote server returned an error: (401) Unauthorized."
- Bug fix: Addressed issue in which “Something went wrong. Try reloading the page. If you still see this message, contact your administrator to file a support request" when trying to display booking tool tip view on the new schedule board. This would occur when hovering over any booking.

#### 3.2.3.3

-	Bug fix: Addressed issue where a hard and virtually locked booking that was out of scope would show up as a create operation in the optimization request booking tab. Optimization request bookings are created for virtually locked bookings if Resource Scheduling Optimization has something to change. If there's nothing to change, the record shouldn't be created. 

>[!NOTE]
> Virtually locked bookings are bookings created outside of the optimization scope.

-	Bug fix: reset would cause error: “Value can't be null.” When a reset does happen, the confusing error is no longer provided. Instead, it errors by either defaulting the effort level or raising a ```RSODataNotFound``` exception.  
-	Bug fix: reset all in Resource Scheduling Optimization **Schedules** tab wasn't properly deleting data within database.  
-	Bug fix: Addressed error issue "System.OutOfMemoryException: Array dimensions exceeded supported range.” This scenario would occur when a trying to optimize a large number of resource requirements (~50k). 
-	Fixed “Keyset doesn't exist” errors. This error was a transient issue that would fail the authentication from Azure to CRM.
-	Bug fix: within ineligibility graph in which an entire resource was incorrectly removed if other shifts associated with the resource were still eligible to be scheduled. 
-	Bug fix: optimization would run for more than one day without completing. This scenario would occur when 5000 resource requirements and 500 resources were scheduled to be optimized over 21 days. 
-	Bug fix: the settings panel within Resource Scheduling Optimization app displayed "properties" instead of "priorities."
-	Bug fix: optimization goal wasn't saving when the travel time calculation was updated.

#### 3.2.2.18

- Bug fix: optimization request fails with the message: “an item with the same key has already been added.” The scenario occurred when there was more than one booking with the same resource requirement. 
- Bug fix: version 3.0.190941 wouldn't upgrade to version 3.2.1.96 due to plugin name issues.  
- Bug fix: schedule assist would fail with the message: “The remote name couldn't be resolved: 'website20200924t163642zzvulvehb5hdn4.azurewebsites.net'”. The scenario occurred when schedule assist was unable to correctly provide options for the resource name, travel time, and arrival time for a suggested booking.  
- Bug fix: running reset all or reset selected on a schedule associated with heavy effort optimizations would time out.  
- Bug fix: in operation requests booking details tab where the operation reason was showing “---” for all records.

#### 3.2.1.71

- Resource scheduling optimization intelligence used to help dispatcher schedule multiple requirements in the schedule board. [Read about this update.](/dynamics365/field-service/preview-schedule-board)
- Increased end-to-end overall optimization performance by 3-5%.  

#### 3.2.1.6

- Bug fix: scenario installing the Resource Scheduling Optimization analytics solution would remove the Resource Scheduling Optimization app module icon. 
- Allow resources to travel outside of working hours [Read about this update.](/dynamics365/field-service/rso-travel-outside-working-hours)
- Improved predictive travel time accuracy [Read about this update.](/dynamics365/field-service/rso-predictive-travel) 

#### 3.1.5.24

- Bug fix: scenario where the MoveUp button was hidden on the Resource Scheduling Optimization goal objective. 
- Made performance enhancements for single resource optimization scenarios.  

#### 3.1.4.1

- Bug fix: scenario where the Resource Scheduling Optimization package was imported regardless of minimum Universal Resource Scheduling version required, resulting in an import failure. The fix ensures that the user can't import the Resource Scheduling Optimization package if the minimum Universal Resource Scheduling version isn't met.  
- Bug fix: scenario where single resource optimization deleted valid bookings. This scenario occurred when the user attempted to trigger single resource optimization for a resource. The single resource optimization would then delete most of the valid and eligible bookings.  

#### 3.1.3.17

- Bug fix: where 'Created On' field in optimization panel of Resource Scheduling Optimization schedule board doesn't respect date format of user setting. 
- Bug fix: issue where optimization request status wasn't set correctly when Resource Scheduling Optimization is run as a simulation. 

#### 3.0.19316.2

- ConsiderTravelTime parameter for SA API msdyn_SearchResourceAvailability isn't working as expected. Use the following steps to understand the impact of this bug fix:
  - Create a resource requirement with four hours duration, and location set to **Onsite**. 
  - Create a resource A with four hours available hour on their calendar; make sure there are a few minutes travel time between the location between resource and requirement.
  - Use msdyn_SearchResourceAvailability with the ConsiderTravelTime parameter set to false, and to find availability for this requirement. Before this, no potential bookable slot was returned; now there's potential bookable slot returned from resource A since resource A has enough available hours.
- Resource scheduling optimization booking details: **Operation Details** field doesn't show message anymore if user is missing the Field Service - Administrator security role.
- Booking status form showing false scheduling method the first time Resource Scheduling Optimization is opened after initial setup.
- Bug fix: Fixed upgrade issue from Resource Scheduling Optimization v3.0.18341.1 to latest in-market version.

#### 3.0.19263.1

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/10/03/whats-new-in-dynamics-365-resource-scheduling-optimization-version-3-0-19263-1/)

#### 3.0.19109.3

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/whats-new-for-dynamics365-resource-scheduling-optimization-v3-0-update-release/)

#### 2.8

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/10/16/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-8-release/)

#### 2.7

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/08/16/whats-new-in-the-dynamics-365-resource-scheduling-optimization-version-2-7-release/)

#### 2.6

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/05/09/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-6-release/)

[!INCLUDE[footer-include](../includes/footer-banner.md)]