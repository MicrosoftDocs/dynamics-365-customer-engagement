---
title: "Bug fixes for Dynamics 365 Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/23/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Bug fixes

In this article, you'll find an ongoing list of bug fixes for Dynamics 365 Field Service, Universal Resource Scheduling (URS), Field Service Mobile, resource scheduling optimization, and Connected Field Service (CFS). For information about other updates to Field Service, visit the [Dynamics 365 Release Plans](https://docs.microsoft.com/dynamics365/release-plans/). 

## Dynamics 365 Field Service

### Version 8.8.11.19

- Fixed an issue where Agreement Booking Date generation fails when Agreement is owned by a team.
- Resolved an issue where Field Service client side logic fails when using contact form while in offline.
- Resolved PO Product form customization issues where
  - If an organization removed the 'Quantity Received' field from the Purchase Order Product, they would be unable to create a new Purchase Order Product record.
  - Work Order and Warehouse values do not auto-populate if the fields are removed from the form.
- When using Quick Create form for WO from an Account, fixed an issue where some of the fields that were expected to auto-populate were not being populated.
- If the map control is removed from the work order form, it cannot be added back. The control has been locked to the form so that it cannot be removed from the form.
- Issue where the primary incident type record of a deactivated WO could not be deactivated; added a validation check to only allow the Work Order Incident record to be deactivated when Work Order is deactivated.

### Version 8.8.14.328 (2020 Wave 1 Early Access)

For more information about early access features, visit the [opt-in instructions](https://docs.microsoft.com/power-platform/admin/opt-in-early-access-updates).

- Before a Work Order Product or Work Order Service is set to Used, the Total Amount is not calculated.
  - Previously, under some circumstances, a Work Order Service line in Estimated status could have a Total Amount value despite not being set to used. This could result in challenges when looking at the Work Order’s total amount and potential downstream invoice discrepancies.
  - This also required an improvement to the Work Order Product and Work Order Service views to ensure we show both the Estimated Total Amount and the Total Amount so users could understand the value in context of the line’s current status.
- On the Agreement Booking/Invoice Setup, booking and invoice generation time (respectively) could be incorrect if the user who own's the agreement is in a time zone +1 or higher from UTC.
  - Going forward, the system will consider the Agreement Booking/Invoice Setup owner’s time zone when generating date records.
  - This will now mean that Agreement Booking Date and Agreement Invoice Dates will be generated correctly and consistently, relative to the owner’s time zone.
  - Note: Be sure to validate that all existing Agreement Booking Setups and Agreement Invoice Setups owned by users +1 or greater than UTC are correctly configured to generate Invoices and Work Orders per organizational expectations.
- On Tax Codes, when 'Act As Tax Group' is set to Yes, Tax Rate % and Items Taxable should be hidden.
  - When a Tax Code is configured to act as a tax group, the tax rate and items taxable should be hidden from the user as these values come from the applicable related Tax Code Details for a tax group.
  - Further, on the Tax Code, when the “Act as Tax Group” flag is set to Yes, a form notification will now show on the form to highlight that Tax Code Details must be created for taxes to be applied when the Tax Code is used.
- On the Opportunity entity’s main Form, Account shouldn't be mandatory if Order Type is not Service-Maintenance Based.
  - When creating an Opportunity, the Account field should only be mandatory if the Order Type is “Service-Maintenance Based.”
- On the Agreement Booking/Invoice Setup, if a user’s time zone was set to a GMT +1 or higher, the default range of recurrence was auto-calculated to one day before Agreement Start/End.
  - When defining an Agreement Booking/Invoice Setup as a user in a time zone +1 or higher from UTC, then the range of recurrence on the record’s recurrence string was always calculated one day before the start/end date of the related Agreement’s start/end date.
  - This will now calculate the default recurrence range appropriately based on the user creating the record’s time zone.
- Deprecated Quote Booking Setup’s Margin tab and calculation logic
  - Formerly, on the Quote Booking Setup form, there was a tab that attempted to calculate the margin of the proposed booking setup.
  - Under certain circumstances, this margin calculation could be incorrect.
  - Due to the limited usage of the feature and the complexity involved in supporting every permutation of possible configuration with corrected calculations, the tab and related calculation logic was removed.
- Introduced better validation messaging if a user tries to increase the quantity on a Quote Line for Service-Based lines.
- Prevent Agreement Booking Service Task from being saved when Task Type lookup field is null.
  - If an organization customized the Agreement Booking Service Task entity to make the Task Type optional, this would result in downstream errors when trying to generate Work Order Service Tasks.
  - As such, a synchronous plugin was registered that will prevent the creation of an Agreement Booking Service Task if Task Type is null.
- Fixed typo in error message when Incident Type Requirement Groups is related to an empty Requirement Group Template.
- Prevent Work Order Service from being saved when the Service lookup field is null.
  - If an organization customized the Work Order Service entity to make the Service optional, this could result in downstream errors.
  - As such, a synchronous plugin was registered that will prevent the creation of a Work Order Service if Service is null.
- Improved the warning notification message on the "Geo Code Address” button when Bing maps is disabled.

### Version 8.8.10.44

- Agreement Booking Service Task's Name is overwritten when the related task type changes.
- Cannot complete booking that has travel time if the Travel Charge Type on the related Work Order's Account is null.

### Version 8.8.9.84

- Script error when Account field is removed from the Opportunity Quick Create form.
- On create of Account record based on Postal Code functionality, Service Territory is repeatedly auto-populated, even after the customer removes the initial auto-populated value.
- Consistency issue in Field Service's Solution Health Hub rule naming when referring to SDK Message Processing Steps.

### Version 8.8.8.135

- Work Order plugin error for SLA KPI Instance.

### Version 8.8.8.50

- Improve error messages when the user attempting an action is missing "Field Service Setting" read privilege.
- Form logic always turns Incident Type to not required based on Work Order Type, regardless of field settings.
- Bookings are not shared consistently to all resources on multi-booking Work Orders.
- Deleting and recreating a Booking associated with a Work Order changes the shared users of Booking.
- TypeError: Cannot read property 'getDefaultView' when Requested by Contact field removed from RMA form.
- Agreement Invoice Product Currency Set to Base Currency - should be set to Agreement's Pricelist Currency.

### Version 8.8.7.47

-	Removal of Territory from Work Order is not removed from non-primary related requirements.
-	Inappropriate command buttons shown for Opportunity, Quote, and Order Product and Service-based Lines Sub Grids.
-	Field Service Resource privilege exception on create and save of Time Off Request.

### Previous versions of Field Service

To see older bug fixes, see the following links to blog posts:  

| **Version 8**                                                                                                                               | **Version 7**                                                                                                                                                 | **Version 6**                                                                                                                                               |
|-----------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------|
| [8.8.3.533](https://cloudblogs.microsoft.com/dynamics365/it/2019/09/10/enhancements-and-bug-fixes-for-field-service-version-8-8-3-533/) | Not supported. | Not supported. |
| [8.8.2.160](https://cloudblogs.microsoft.com/dynamics365/it/2019/08/11/enhancements-and-bug-fixes-for-field-service-version-8-8-2-160/) | ||
| [8.8.1.45](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/07/enhancements-and-bug-fixes-for-field-service-version-8-8-1-45/)   |||
| [8.8.0.88](https://cloudblogs.microsoft.com/dynamics365/it/2019/06/10/release-notes-for-field-service-version-8-8-0-88/)                | ||
| [8.7.0.105](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/06/release-notes-for-field-service-version-8-7-0-105/)              | ||
| [8.6.0.274](https://cloudblogs.microsoft.com/dynamics365/it/2019/04/06/release-notes-for-field-service-version-8-6-0-274/)              |||
| [8.5.0.345](https://cloudblogs.microsoft.com/dynamics365/it/2019/03/07/release-notes-for-field-service-version-8-5-0-345/)              |||
| [8.4.0.338](https://cloudblogs.microsoft.com/dynamics365/it/2019/02/11/release-notes-for-field-service-version-8-4-0-338/)              |||
| [8.3.0.255](https://cloudblogs.microsoft.com/dynamics365/it/2018/12/21/release-notes-for-field-service-version-8-update-release-3/)     |||
| [8.2.0.286](https://cloudblogs.microsoft.com/dynamics365/it/2018/11/08/release-notes-for-field-service-version-8-update-release-2/)     |||

 
## Field Service Mobile

### Version 12.1.212

#### Updates
- PDF report generation: A tech can now choose PDF document type as one of the report formats.
- Brokered authentication: A tech can leverage Company Portal or Authenticator application on a device to authenticate.
- Added support for oAuth Authentication in Sovereign/DoD clouds.
- Docusign Integration: Bring your DocuSign account and leverage DocuSign integration for digital signatures.

#### Bug fixes
- App crashes when wrong url is entered on sign in screen.
- App crashes when sending logs if networkLog.txt does not exit.  
- App crashes when connecting to an org without Woodford.
- App crashes when click on 'password manager' from sign in screen.   
- App crashing on certain older Android devices (G5, LG K7). 
- MobileReport - Formatting issue on Word/HTML.
- MobileReport - contents of Word document is removed if user saves Work Order without closing active doc.
- Unit Amount and Unit Cost are not calculated when the offline Work Order Product created and sync backed to server.
- Conditionally displaying a URL is not showing hyperlink icon.

### Version 12.1.203

- Win10: Use standard fileIO methods (except open & delete) 
- When copying DynamicEntity, copy the partylist not just the pointer 
- SharePoint upload: A misleading sync error removed 
- Sync does not download NN entities (incl. listmember entity) 
- Set entity multiselect picklist property value using JsonSerializers 
- Always reload EntityHub command 
- Improve the username discovery for OAuth2 
- Chat: Don't crash when chat is closed during loading posts 
- EmailForm: Espace attachment name. Attachment name with ' (single quote) was not visible 
- iOS, Android: Chosen multiple photos (note list) now respect max image size 
- DownloadEntityImages(): Preventing duplicated IDs 
- iOS: Permission descriptions were added to Info.plist (due to Inspections review rejection) 
- Open content file in read mode. iOS doesn't allow to open it as writable 
- Scheduler: An "undefined" string was shown in Task/TimeOff tooltip, when Task/TimeOff name was not set 
- UpdateAddress ignores non-string fields 
- DownloadMarketingListMembers check lists in batches (100) 
- Sync MarketingMembers has incorrect logic 
- Scheduler: Error object was not converted to string message properly 
- Scheduler: FallbackView was not used also when task, source or resource entity did not have 
- Don't inspect dirty flag on disposed form controller (AppStore crashes) 
- Android: Delay LocationTracking service creation on startup 
- Desktop: Bring all types of DetailItems into view. Previously only Text items were handled 
- Google, Exchange contacts: fullname filter is compatible 
- iOS: MessageBox-related fixes 
- SearchForm force the cached entities, we already know the entities to search 
- Desktop: Do not scrollIntoView multiline text DetailItem on click 
- Google, Exchange contacts: fullname filter is compatible 
- Clicking on PowerBI Sign in button doesn't open authentication dialog 
- iOS'Navigate To' command in Account form doesn't fill in the destination automatically after redirecting to the map app 
- 'Direct to current location' button on the map of work order doesn't work in iOS 
- "Unlock with your fingerprint" window doesn't appear in Android 
- Android - unable to use 'navigate to' on account and WO 
- NavigateTo on iOS opens Google Maps even though Apple Maps is selected 
- Scan Barcode in the hamburger menu doesn't work 
- FSM Android splash screen hangss. 
- OAuth with Proxy - If Proxy is bad, the app doesn't show any indication and it remains on the Sign In page. 
- Saving IoT Device Command - Getting Error "Server Error: PluginBase" 
- Allow sign in to OnPrem url 
- OAuth on Android - authentication attempt with valid server entered shows error pop-up "One or more errors occurred". 
- Validate mobile app with no Woodford project. 
- "e" letter is displaying in separate line for "Mark Complete" button on Service Tasks sub-grid of Work Order form 
- Booking record should be deleted from the app if it is removed from the Schedule Board 
- Server error appearss when users with FS Dispatcher privileges try to create Customer Asset in online mode


### Version 11.3.107

- Fixed saving of offline Booking Signatures
- Fixed update address button error message
- Fixed unresponsive iOS buttons
- Fixed date picker on Android
- Fixed issue on iOS where user was not prompted to grant “Always” location permission to app
- PushRegistrationIntentService start fixed for Android 8+


## Resource Scheduling (RS) 

[!INCLUDE[urs-bug-fixes.md](../shared/urs/urs-bug-fixes.md)]
  

## Resource scheduling optimization

### Version 3.0.19316.2

- ConsiderTravelTime parameter for SA API msdyn_SearchResourceAvailability is not working as expected
   - Create a resource requirement with 4 hours duration, and location = Onsite 
   - Create a resource A with 4 hours available hour on his calendar, make sure there is few mins travel time between the location between resource and requirement
   - Use msdyn_SearchResourceAvailability with ConsiderTravelTime parameter set to false, and to find availability for this requirement 
Before: no potential bookable slot returned, now there is potential bookable slot return from resource A since resource A has enough available hours 
- RSO Booking Details -> Operation Details field doesn't show message anymore if RSO application user missing FS-admin security role
- Booking status form showing false Scheduling Method when first time open after setup fresh RSO environment
- Fixed upgrade issue from RSO v3.0.18341.1 to latest in-market version

### Previous versions of Resource Scheduling Optimization

To see older bug fixes, see the following links to blog posts: 

- [3.0.19263.1](https://cloudblogs.microsoft.com/dynamics365/it/2019/10/03/whats-new-in-dynamics-365-resource-scheduling-optimization-version-3-0-19263-1/)
- [3.0.19109.3](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/whats-new-for-dynamics365-resource-scheduling-optimization-v3-0-update-release/)
- [2.8](https://cloudblogs.microsoft.com/dynamics365/it/2018/10/16/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-8-release/)
- [2.7](https://cloudblogs.microsoft.com/dynamics365/it/2018/08/16/whats-new-in-the-dynamics-365-resource-scheduling-optimization-version-2-7-release/)
- [2.6](https://cloudblogs.microsoft.com/dynamics365/it/2018/05/09/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-6-release/)

