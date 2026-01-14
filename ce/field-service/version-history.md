---
title: Dynamics 365 Field Service version history
description: Release schedule and version history for Dynamics 365 Field Service.
ms.date: 01/08/2026
ms.topic: overview
author: jshotts
ms.author: jasonshotts
---

# Dynamics 365 Field Service version history

## Release schedule

When a new version of Dynamics 365 Field Service releases, it becomes available in different geographic regions at different times. Use the table below to see when the next release will become available in the region of your environment.

For information about other updates to Field Service, visit the [Dynamics 365 and Microsoft Power Platform release plans](https://releaseplans.microsoft.com/?app=Field+Service).
For information about older versions, see [Version history archive](version-history-archive.md#field-service).

| Station | Region | Current version | Next version | Scheduled date |
| ------- | ------ | --------------  | -----------  | -------------  |
|**Station 1** |  *First Release*| [8.8.141.552](/dynamics365/field-service/version-history#88141552)  | TBD | 1/16/2026 |
|**Station 2** |  *South America, Canada, India, France, South Africa, Germany, Switzerland, Norway, Korea*| [8.8.141.552](/dynamics365/field-service/version-history#88141552) |  TBD | 1/23/2026 |
|**Station 3** | *United Arab Emirates, Japan, Asia Pacific, United Kingdom* | [8.8.141.552](/dynamics365/field-service/version-history#88141552) |  TBD  | 1/30/2026 |
| | *USG* | [8.8.141.552](/dynamics365/field-service/version-history#88141552) |  TBD |1/21/2026 |
|**Station 4** |*Europe* | [8.8.140.441](/dynamics365/field-service/version-history#88140441) |  [8.8.141.552](/dynamics365/field-service/version-history#88141552) |  1/16/2026 |
|**Station 5** | *North America, Oceania*|  [8.8.140.441](/dynamics365/field-service/version-history#88140441)  | [8.8.141.552](/dynamics365/field-service/version-history#88141552)  |  1/23/2026 |
|**Station 6** |*Government Community Cloud, DoD, China* | [8.8.140.441](/dynamics365/field-service/version-history#88140441)  | [8.8.141.552](/dynamics365/field-service/version-history#88141552)  | 1/21/2026 |
| | *Dedicated Scale Groups* | [8.8.140.441](/dynamics365/field-service/version-history#88140441) | [8.8.141.552](/dynamics365/field-service/version-history#88141552) | 1/30/2026 |
>[!NOTE]
>
> - Dates in all regions except Government Community Cloud (GCC), USG, and China indicate the timing of the next automatic update. Dates in GCC, USG, and China indicate version availability; at this time, there is no automatic update for the GCC, USG, and China regions.
> - For all other regions, while most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 8.8.141.552
This release is a hotfix on Field Service version [8.8.141.549](/dynamics365/field-service/version-history#88141549)
(Includes Universal Resource Scheduling version [3.12.157.285](/dynamics365/field-service/field-service-version-history-resource-scheduling#312157285) and Resource Scheduling controls version 1.2.96.253531)

- No updates were made to Dynamics 365 Field Service in this release.

## 8.8.141.549
This release is a hotfix on Field Service version [8.8.141.467](/dynamics365/field-service/version-history#88141467)
(Includes Universal Resource Scheduling version [3.12.157.285](/dynamics365/field-service/field-service-version-history-resource-scheduling#312157285) and Resource Scheduling controls version 1.2.96.253261)

- **Fixes & Improvements**
    - Inventory & Journals
        - Fixed an issue where the background process that creates Work Order Product journals could fail with an “object reference not set” error. This helps prevent missing journals that can lead to incorrect or inconsistent inventory values.

## 8.8.141.467
(Includes Universal Resource Scheduling version [3.12.157.285](/dynamics365/field-service/field-service-version-history-resource-scheduling#312157285) and Resource Scheduling controls version 1.2.96.253261)

- **Fixes & Improvements**
    - Duplicate booking timestamp handling (default behavior updated)
        - Field Service now defaults duplicate booking timestamp handling to Ignore Duplicates, helping prevent accidental duplicate timestamp records while still allowing users to save their changes.
    - Inventory & Purchasing
        - Purchase Order system status now updates correctly when purchase order products and related receipt products are deleted, ensuring the Purchase Order status reflects what has actually been received.
    - Localization
        - Improved localization coverage so certain Field Service error messages are shown in the user’s language instead of appearing in English.
    - Date and time experience
        - Fixed issues where the New Work Order grid date filter didn’t respect user personalization settings (such as date/time format), and where the date picker UI didn’t reflect the user’s selected Dataverse language.
    - Inspections
        - Inspection responses exported to PDF now correctly preserve the “+” character in text fields.
        - Improved support for customers who need change tracking enabled for the Inspection Instance table.
    - Sales orders
        - Fixed an issue where the Sales Order line grid could incorrectly show lines from other sales orders due to Field Service form customizations.
 
## 8.8.140.441
This release is a hotfix on Field Service version [8.8.140.438](/dynamics365/field-service/version-history#88140438)
(Includes Universal Resource Scheduling version [3.12.156.520](/dynamics365/field-service/field-service-version-history-resource-scheduling#312156520) and Resource Scheduling controls version 1.2.95.252872)

- **Fixes & Improvements**
    - Inventory & Journals
        - Fixed an issue where the background process that creates Work Order Product journals could fail with an “object reference not set” error in some environments. This helps prevent missing journals that can lead to incorrect or inconsistent inventory values.

## 8.8.140.438
This release is a hotfix on Field Service version [8.8.140.325](/dynamics365/field-service/version-history#88140325)
(Includes Universal Resource Scheduling version [3.12.156.520](/dynamics365/field-service/field-service-version-history-resource-scheduling#312156520) and Resource Scheduling controls version 1.2.95.252872)

- **Fixes & Improvements**
    - Work Order Products
        - Fixed an issue where some users couldn’t create a Work Order Product after upgrading to 10.3, due to a missing prvReadSolution privilege error. Work Order Product creation now works without requiring customers to manually add extra security privileges.

## 8.8.140.325
(Includes Universal Resource Scheduling version [3.12.156.513](/dynamics365/field-service/field-service-version-history-resource-scheduling#312156513) and Resource Scheduling controls version 1.2.95.252872)

- **Fixes & Improvements**
    - Inventory Clearer “duplicate inventory record” error message
        - Improved the validation error shown when more than one active inventory record exists for the same warehouse, product, and unit, so users can better understand what record type is causing the issue.
    - More reliable deletion of Work Order Products with missing values
        - Fixed an issue where deleting an inventory Work Order Product could fail with a “Value cannot be null” error when required fields were missing.
    - Performance Reduced unnecessary plugin execution for resource requirements
        - Optimized the FS stage 10 create/update plugin for Resource Requirements so it runs only when the Work Order field changes, reducing unnecessary processing.

## 8.8.139.398
(Includes Universal Resource Scheduling version [3.12.155.15](/dynamics365/field-service/field-service-version-history-resource-scheduling#31215515) and Resource Scheduling controls version 1.2.94.252722)

- **Major Changes**
    - **General Availability**: Exchange Integration for Field Service. Field Service now syncs bookings with Microsoft Outlook and Teams frontline workers and dispatchers can manage schedules using familiar calendars and open work order details from Microsoft 365.
        - Business Value: Meetings, appointments, and bookings are now all visible in a single place. Reduces context switching and improves collaboration across the field and back office.
        - Feature Highlights:
            - Bookings appear as Outlook and Teams calendar appointments with key job details and deep links back to Field Service.
            - Updates to bookings sync automatically from Field Service to Outlook.
            - Admin setup uses server-side synchronization with Exchange Online.

    - **Deprecation of legacy CCA-based Frontline Reports**: Legacy CCA-based report pages and settings are deprecated and hidden from navigation; documentation now guides customers to the modern reporting experience.
        - Business Value: Reduces confusion and maintenance for legacy pages and aligns customers on the current, supported analytics solution.
        - Feature Highlights:
            - Removes sitemap access to deprecated CCA report/settings pages
            - Disables related feature flags and updates documentation for the new solution

- **Fixes & Improvements**
    - Copilot on Work Order form
        - Fixed an error that prevented Copilot from generating a summary on the New Work Order form. Generating summaries now works reliably after enabling the feature in Field Service Settings.
    - Work Order conversion from Opportunity
        - Addressed an issue where the Sales Tax Code value did not carry over when converting an Opportunity to a Work Order. The correct tax configuration is now reflected on the resulting Work Order.
    - Get Started page cleanup
        - Removed the “Analyze your operations” card from the Get Started page, aligning the UI with the deprecation of Field Service Analytics reports.
    - Localization and language support
        - Fixed label fallback for organizations with a non-English base language after installing English, ensuring UI labels display in the user’s selected language.
        - Inspections: Confirmation dialogs for “Publish” and “Publish and generate a new Service task type” now respect the user’s language when the org base language is non-English with English provisioned.

## 8.8.137.30
This release is a hotfix on Field Service version [8.8.137.22](/dynamics365/field-service/version-history#8813722)

(Includes Universal Resource Scheduling version [3.12.153.127](/dynamics365/field-service/field-service-version-history-resource-scheduling#312153127-hotfix1) and Resource Scheduling controls version 1.2.92.252162)
- Security enhancements in the Inspections solution. 

## 8.8.137.22
This release is a hotfix on Field Service version [8.8.137.20](/dynamics365/field-service/version-history#8813720)

(Includes Universal Resource Scheduling version [3.12.153.127](/dynamics365/field-service/field-service-version-history-resource-scheduling#312153127-hotfix1) and Resource Scheduling controls version 1.2.92.252162)
- No updates were made to Dynamics 365 Field Service in this release.

## 8.8.137.20
(Includes Universal Resource Scheduling version [3.12.153.124](/dynamics365/field-service/field-service-version-history-resource-scheduling#312153124) and Resource Scheduling controls version 1.2.92.252162)

-Corrected a Chinese character display issue in file names when uploaded in the Notes tab on Bookable Resource Booking.

## 8.8.136.190
(Includes Universal Resource Scheduling version [3.12.152.16](/dynamics365/field-service/field-service-version-history-resource-scheduling#31215216) and Resource Scheduling controls version 1.2.91.251882)

- **Accessibility Enhancements**
    - Improved keyboard navigation in Field Service Mobile. We’ve fixed an issue where keyboard users couldn’t move past the Service tab using the Tab key. Focus now properly moves to the Service Task section, making navigation smoother and more accessible.
    - Corrected screen reader behavior for "Status" field. In the New Work Order form, the Status field now announces the correct label and role for screen readers. This ensures clarity and consistency for users who rely on assistive technologies.
- **Maps & Location**
    - Fixed platform issue preventing map display. Resolved a platform control issue that caused maps to not display under the Location tab in Work Orders, even when address and configuration settings were correct. Maps now appear as expected to support location-based workflows.
- **Copilot Feedback Experience**
    - Cleaned up feedback form display. Fixed a bug where a "0.json" link would incorrectly appear after selecting “Yes” in the Copilot feedback form. The form now displays only relevant content, providing a cleaner and more intuitive experience.

## 8.8.135.323
This release is a hotfix on Field Service version [8.8.135.315](/dynamics365/field-service/version-history#88135315)

(Includes Universal Resource Scheduling version [3.12.151.675](/dynamics365/field-service/field-service-version-history-resource-scheduling#312151675-hotfix2) and Resource Scheduling controls version 1.2.90.251761)
- No updates were made to Dynamics 365 Field Service in this release.
  
## 8.8.135.315
This release is a hotfix on Field Service version [8.8.135.227](/dynamics365/field-service/version-history#88135227)

(Includes Universal Resource Scheduling version [3.12.151.675](/dynamics365/field-service/field-service-version-history-resource-scheduling#312151675-hotfix1) and Resource Scheduling controls version 1.2.90.251391)
- No updates were made to Dynamics 365 Field Service in this release.
  
## 8.8.135.227
(Includes Universal Resource Scheduling version [3.12.151.455](/dynamics365/field-service/field-service-version-history-resource-scheduling#312151455) and Resource Scheduling controls version 1.2.90.251391)

- **Purchase Order Receipt**
    - Fixed an issue where deleting a Purchase Order Receipt Product could incorrectly reduce the quantity or billed amount twice.
- **Booking Card on Work Order**
    - Fixed a bug where the Post button required two clicks when the Work Order was set to Completed.
    - Addressed a UI issue where the date/time control had a transparent background. 
- **Work Order Form**
    - Resolved intermittent behavior requiring two clicks to post a Work Order using the new form.
    - Fixed an exception error when saving a Work Order Product with an empty Total Amount after posting.
- **Agreement-Generated Work Orders**
    - Fixed inconsistent updates to the Primary Incident Estimated Duration field on Work Orders auto-generated from Agreement Booking Setups (ABS). Previously, the duration updated multiple times before finalizing, causing downstream issues for F&O integrations.
- **Customer Asset Form**
    - Added check to prevent errors that could occur when the functional location tab is missing
- **Service Tasks Grid**
    - Pagination now displays properly on the Service Tasks grid.
- **Work Order Product/Service Grid**
    - Fixed an issue where only one item was deleted when bulk deleting multiple records from the Products/Services grid.

## 8.8.134.558
This release is a hotfix on Field Service version [8.8.134.552](/dynamics365/field-service/version-history#88134552)

(Includes Universal Resource Scheduling version [3.12.150.423](/dynamics365/field-service/field-service-version-history-resource-scheduling#312150423-hotfix2) and Resource Scheduling controls version 1.2.89.251331)
- No updates were made to Dynamics 365 Field Service in this release.

## 8.8.134.552
This release is a hotfix on Field Service version [8.8.134.351](/dynamics365/field-service/version-history#88134351)

(Includes Universal Resource Scheduling version [3.12.150.423](/dynamics365/field-service/field-service-version-history-resource-scheduling#312150423-hotfix1) and Resource Scheduling controls version 1.2.89.251132)
- No updates were made to Dynamics 365 Field Service in this release.

## 8.8.134.351
(Includes Universal Resource Scheduling version [3.12.150.416](/dynamics365/field-service/field-service-version-history-resource-scheduling#312150416) and Resource Scheduling controls version 1.2.89.250863)

- **Work order summary generally available**
    - Now generally available, work order summaries cite references, generate faster, and let users copy the output to the clipboard.
- **Inspection builder (Preview)**
    - Upload PDFs of existing inspection forms to generate questions in the inspection designer. 
- **Bookings sync with Outlook and Teams (Preview)**
    - This one-way sync, from Dynamics 365 Field Service to Microsoft Exchange, makes bookings automatically appear on Exchange calendars by using server-side synchronization.
    - [Learn more and sign up to try the new feature](https://forms.office.com/r/gLUtW0fZEr).
- Updating the service account on a work order will now keeps the functional location's address as the service address for the work order.
- Play buttons no longer appear for unplayable videos under the "get up and running" section in started page.
- Removed redundant calls to Field Service Survey plugin from work orders.
- Fixed an issue where bookings imported via configuration migration tool lost their relationship to work order.
- Various security enhancements.
- Field Service mobile app:
    - Updated Remote Assist command bar click action to open Remove Assist within Teams instead of the deprecated Remote Assist mobile application.
    - Fixed a bug that caused exported inspections PDFs to have larger file sizes when containing embedded images.
    - Several accessibility enhancements for the mobile interface.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
