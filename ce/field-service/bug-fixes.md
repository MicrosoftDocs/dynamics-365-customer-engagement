---
title: "Bug fixes for Dynamics 365 Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/13/2020
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

In this article, you'll find an ongoing list of bug fixes for Dynamics 365 Field Service, Universal Resource Scheduling (URS), Field Service Mobile, Resource Scheduling Optimization (RSO), and Connected Field Service (CFS). For information about other updates to Field Service, visit the [Dynamics 365 Release Plans](https://docs.microsoft.com/dynamics365/release-plans/). 

## Dynamics 365 Field Service

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
  
  
## Field Service Mobile

### Version 12.1

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


### Version 11.3

- Fixed saving of offline Booking Signatures
- Fixed update address button error message
- Fixed unresponsive iOS buttons
- Fixed date picker on Android
- Fixed issue on iOS where user was not prompted to grant “Always” location permission to app
- PushRegistrationIntentService start fixed for Android 8+

## Universal Resource Scheduling (URS) 

[!INCLUDE[urs-bug-fixes.md](../shared/urs/urs-bug-fixes.md)]
  

## Resource Scheduling Optimization (RSO)

### Version 3.0.19316.2

- ConsiderTravelTime parameter for SA API msdyn_SearchResourceAvailability is not working as expected
   - Create a resource requirement with 4 hours duration, and location = Onsite 
   - Create a resource A with 4 hours available hour on his calendar, make sure there is few mins travel time between the location between resource and requirement
   - Use msdyn_SearchResourceAvailability with ConsiderTravelTime parameter set to false, and to find availability for this requirement 
Before: no potential bookable slot returned, now there is potential bookable slot return from resource A since resource A has enough available hours 
- RSO Booking Details -> Operation Details field doesn't show message anymore if RSO application user missing FS-admin security role
- Booking status form showing false Scheduling Method when first time open after setup fresh RSO environment
- Fixed upgrade issue from RSO v3.0.18341.1 to latest in-market version


