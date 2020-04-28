---
title: "Field Service Mobile version history | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/20/2020
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

# Field Service Mobile version history

This article chronicles important updates related to Field Service Mobile and associated mobile project templates.

## 12.1.212

### Updates
- PDF report generation: A tech can now choose PDF document type as one of the report formats.
- Brokered authentication: A tech can leverage Company Portal or Authenticator application on a device to authenticate.
- Added support for oAuth Authentication in Sovereign/DoD clouds.
- Docusign Integration: Bring your DocuSign account and leverage DocuSign integration for digital signatures.

### Bug fixes
- App crashes when wrong url is entered on sign in screen.
- App crashes when sending logs if networkLog.txt does not exit.  
- App crashes when connecting to an org without Woodford.
- App crashes when click on 'password manager' from sign in screen.   
- App crashing on certain older Android devices (G5, LG K7). 
- MobileReport - Formatting issue on Word/HTML.
- MobileReport - contents of Word document is removed if user saves Work Order without closing active doc.
- Unit Amount and Unit Cost are not calculated when the offline Work Order Product created and sync backed to server.
- Conditionally displaying a URL is not showing hyperlink icon.


## 12.1.203

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


## 11.3.107

- Fixed saving of offline Booking Signatures
- Fixed update address button error message
- Fixed unresponsive iOS buttons
- Fixed date picker on Android
- Fixed issue on iOS where user was not prompted to grant “Always” location permission to app
- PushRegistrationIntentService start fixed for Android 8+

## Mobile project template version history

Mobile projects hold configurations and customizations of the Field Service Mobile app such as view and form layout, mobile workflows called form rules, and offline HTML/JavaScript. These mobile projects are imported through the Field Service Mobile Configuration Tool (Woodford). The Field Service engineering team periodically releases new mobile project templates and the latest one can always be downloaded at [https://aka.ms/fsmobile-project](https://aka.ms/fsmobile-project).

To learn more about mobile projects, see our topic on [installing the Field Service Mobile Configuration Tool](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/install-field-service#install-the-field-service-mobile-configuration-tool).

## 1.0.3514

| Download link | Release date | Relates to Field Service Mobile version | Publish to Woodford Version | Minimum Field Service Version |
| --- | --- | --- | --- | --- |
| [1.0.3514](https://aka.ms/fsmobile-project)  |  January 2020  |  12.1+ | 12.1+ | 8.8.6.300 | 

## 1.0.3482

| Download link | Release date | Relates to Field Service Mobile version | Publish to Woodford Version | Minimum Field Service Version |
| --- | --- | --- | --- | --- |
| [1.0.3482](https://aka.ms/fsmobile-project-3482)  |   November 2019  |  11.3+ | 11.3+ | 8.8.6.300 | 

## 1.0.2735

| Download link | Release date | Relates to Field Service Mobile version | Publish to Woodford Version | Minimum Field Service Version |
| --- | --- | --- | --- | --- |
| [1.0.2735](https://aka.ms/fsmobile-project-2735)  |  August 2019  |  11.3 | 11.3 | | 

## 1.0.1322

| Download link | Release date | Relates to Field Service Mobile version | Publish to Woodford Version | Minimum Field Service Version |
| --- | --- | --- | --- | --- |
| [1.0.1322](https://aka.ms/fsmobile-project-1322)  |   December 2018  |  11.2 | 11.2 | | 

## Mobile project for Field Service v6.1

| Download link | Release date | Relates to Field Service Mobile version | Publish to Woodford Version | Minimum Field Service Version |
| --- | --- | --- | --- | --- |
| [Field Service v6.1 v1.0.0.0](https://go.microsoft.com/fwlink/p/?linkid=836310)  |  December 2018  |  **Field Service Mobile (2017)** 9.0+ | 9.1 | | 

## Mobile project for Field Service v6.0

| Download link | Release date | Relates to Field Service Mobile version | Publish to Woodford Version | Minimum Field Service Version |
| --- | --- | --- | --- | --- |
| [ Field Service v6.0 v1.0.0.0](https://go.microsoft.com/fwlink/p/?LinkId=808250)  |  December 2018  |  **Field Service Mobile (2016)** 8.0 | 8.0 | | 


## Important notes

**Field Service Mobile** applies to Field Service 7.5.5+ and 8.2+

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service mobile app download example](media/mobile-field-service-mobile-windows-app-store.png)

**Field Service Mobile (2017)** applies to Field Service 6.1.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service mobile 2017 app download example](media/mobile-field-service-mobile-2017-windows-app-store.png)
