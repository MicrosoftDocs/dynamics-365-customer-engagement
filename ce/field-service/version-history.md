---
title: "Field Service Version History | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
ms.date: 05/14/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology:
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to:
  - "Dynamics 365 (online)"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365FS
---

# Field Service version history

## Latest version availability

| Solution  | Latest version | Download links  |
|-------|----|------|
| Field Service     |  8.8.+  | [Upgrade](./upgrade-field-service.md) or [create a new trial](https://trials.dynamics.com)   |
| Field Service Mobile                 | 12.1.+          | [Windows](https://aka.ms/fsmobile-windows),   [iOS](https://aka.ms/fsmobile-ios), and   [Android](https://aka.ms/fsmobile-android) |
| Mobile Configuration Tool (Woodford) | 12.1.+          | [Direct download link (English only)](https://aka.ms/fsmobile-configurator)                                                       |
| Mobile Project Template              | 1.0.4549       | [Direct download link (English only)](https://aka.ms/fsmobile-project)      |

Release For information about other updates to Field Service, visit the [Dynamics 365 Release Plans](https://docs.microsoft.com/dynamics365/release-plans/). 

|  | Region | Current Version | Next Version |  Scheduled Date
| :---   | :---   | :---   | :---   |:---   |         
|<strong>Station 2</strong> | |  |  | |
| | <i>South America</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)|  TBD | 05/29/20
| | <i>Canada</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)| TBD | 05/29/20 
| | <i>India</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)| TBD | 05/29/20
| | <i>France</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)|  TBD | 05/29/20
| | <i>United Arab Emirates</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)|  TBD | 05/29/20
| | <i>South Africa</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)|  TBD | 05/29/20
| | <i>Germany</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)| TBD | 05/29/20
|<strong>Station 3</strong> | |  |  | |
| | <i>Japan</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)|TBD | 06/05/2020 
| | <i>Asia Pacific</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)|TBD | 06/05/2020 
| | <i>Great Britain</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)|TBD | 06/05/2020 
| | <i>Oceana</i> |[8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257)|TBD | 06/05/2020
|<strong>Station 4</strong> | |  |  | |
| | <i>Europe</i> |[8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| [8.8.22.57](https://docs.microsoft.com/dynamics365/field-service/version-history#882257) | 05/15/2020
|<strong>Station 5</strong> | |  |  | |
| | <i>North America</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)| [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122) | 05/15/2020
|<strong>Station 6</strong> | |  |  | |
| | <i>Goverment Community Cloud</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)|  [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| 05/22/2020
| | <i>China</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)| [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| 05/22/2020

## 8.8.22.57 

- The following [Field Service 2020 Wave 1](https://docs.microsoft.com/dynamics365-release-plan/2020wave1/dynamics365-field-service/planned-features) features in GA and Preview planned are included in this release:
  - Incident type AI-based suggestions (preview)
  - IoT alerts AI-based suggestions (preview)
  - Leverage Power Automate flows (preview)
  - Combined asset capabilities across Dynamics 365 Supply Chain Management and Field Service
  - Integration with Dynamics 365 Supply Chain Management
  - Intune support for Field Service Mobile
  - Next generation schedule board experience (preview)
  - Enhanced work hours calendar for resources
  - Requirement dependency for efficient workflow
  - Resource scheduling dashboard
  - Integrated technician time tracking
  - Technician time-capture precision
- This release also includes all fixes included in the [8.8.14.328 EA package](https://docs.microsoft.com/dynamics365/field-service/version-history#8814328-2020-wave-1-early-access).
- Corrected some scenarios where the geo code function was being called when "Auto Geo Code Addresses" was set to no.
- Corrected scenario where msdyn_payment was null on payment details which was improperly throwing the following error "The payment amount can't be less than total amount applied to invoices."
- Fixed an issue where price list not changing based on changes to work order's billing account. For organizations experiencing this issue, a fix is made available through the "Advanced Settings" field in the Field Service Settings entity, in an effort to not introduce a potentially disruptive change at this time. Copy the following string into the hidden field:  

>  *workorder.pricelist.usefrombillingaccount*

- Resolved an issue where the time-only control misinterpreted daylight savings time for certain timezones.
- Fixed an issue where form logic was not respecting environment configurations on the Lead entity. Customers can now set fields, like "Company," to be business required and the Field Service form logic will respect the setting.
- Corrected an issue on Work Order Service where the "Total Amount" was not respecting the "Discount" when used in an editable grid.
- Removed the validation on Bookable Resource which required each Bookable Resource's name to be unique.
- Fixed an error on the Quote Booking Product where, under certain circumstances, the system would inaccurately throw the following error, "Enter an amount between $0.00 and $922,337,203,685,477.00."
- Fixed an issue on Work Order quick create from Account where the Billing Account did not populate, correctly.
- Improved Customer Asset lookup experience from Work Order Incident to ensure the form respects when organizations define their own default lookup view.
- Resolved an issue where, in certain timezones, Agreement Booking Setup's Preferred Start Time was not appropriately setting on Agreement Booking Dates' Booking Date and the subsequently auto-created Bookable Resource Booking based on the defined "Preferred Start Time."
- Fixed a scenario where, if an environment sets the default value of msdyn_linestatus to "Used," Work Order Service creation would fail.
- Added a null reference check to correct an issue if Work Order Service's "Duration to Bill" was not set.

## 8.8.12.2 

- Fixed an issue where the "Generate Work Order" button from Advanced Find on Agreement Booking Dates was not displaying and working properly. 
- "Due Date" field value on Invoices generated from Agreement Invoice Date is one day early. For organizations experiencing this issue, a fix is made available through the "Advanced Settings" field in the Field Service Settings entity. Copy the following string into the hidden field:  

>  *autogeneration.usetimezone.invoiceduedate=true*

- Resolved a bug on Work Order Service records that have been deactivated throwing an error when being reactivated, "Object Reference Not Set to Instance of an Object." 
- Corrected an unhandled error in geocoding that failed if the address contained an extra comma. 
- For organizations that would prefer that Work Orders generated from Cases open in the same window, this can now be controlled through “Advanced Settings” field in the Field Service Settings entity. Copy the following string into the hidden field if you would prefer Work Orders to open in the same tab in the same window:  

> *casetoworkorderwindowbehavior=0*

>[!Note]
> The “Advanced Settings” field on Field Service Settings is not added to the entity form by default.  

## 8.8.11.19

**Available in all regions by April 2020**

- Fixed an issue where Agreement Booking Date generation fails when Agreement is owned by a team.
- Resolved an issue where Field Service client side logic fails when using contact form while in offline.
- Resolved PO Product form customization issues where
  - If an organization removed the 'Quantity Received' field from the Purchase Order Product, they would be unable to create a new Purchase Order Product record.
  - Work Order and Warehouse values do not auto-populate if the fields are removed from the form.
- When using Quick Create form for WO from an Account, fixed an issue where some of the fields that were expected to auto-populate were not being populated.
- If the map control is removed from the work order form, it cannot be added back. The control has been locked to the form so that it cannot be removed from the form.
- Issue where the primary incident type record of a deactivated WO could not be deactivated; added a validation check to only allow the Work Order Incident record to be deactivated when Work Order is deactivated.

## 8.8.14.328 (2020 Wave 1 Early Access)

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

## 8.8.10.44

**Available in all regions**

- Agreement Booking Service Task's Name is overwritten when the related task type changes.
- Cannot complete booking that has travel time if the Travel Charge Type on the related Work Order's Account is null.

## 8.8.9.84

- Script error when Account field is removed from the Opportunity Quick Create form.
- On create of Account record based on Postal Code functionality, Service Territory is repeated auto-populated, even after the customer removes the initial auto-populated value.
- Consistency issue in Field Service's Solution Health Hub rule naming when referring to SDK Message Processing Steps.

## 8.8.8.135

- Work Order plugin error for SLA KPI Instance.

## 8.8.8.50

- Improve error messages when the user attempting an action is missing "Field Service Setting" read privilege.
- Form logic always turns Incident Type to not required based on Work Order Type, regardless of field settings.
- Bookings are not shared consistently to all resources on multi-booking Work Orders.
- Deleting and recreating a Booking associated with a Work Order changes the shared users of Booking.
- TypeError: Cannot read property 'getDefaultView' when Requested by Contact field removed from RMA form.
- Agreement Invoice Product Currency Set to Base Currency - should be set to Agreement's Pricelist Currency.
- See this blog post for more information.

## 8.8.7.47

-	Removal of Territory from Work Order is not removed from non-primary related requirements.
-	Inappropriate command buttons shown for Opportunity, Quote, and Order Product and Service-based Lines Sub Grids.
-	Field Service Resource privilege exception on create and save of Time Off Request.

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


## 8.8.2.160

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/08/11/enhancements-and-bug-fixes-for-field-service-version-8-8-2-160/)


## Field Service On-Premise

| Version | Status | Details |
| --- | --- | --- |
| 7.x | Latest available | [Link](https://mbs.microsoft.com/customersource/Global/365Enterprise/downloads/product-releases/365fieldservice7) |
| 6.x | Not supported | |

## Important notes

### Field Service Online End-of-Life for v7.x and earlier

[Version history notes for v7.x](https://cloudblogs.microsoft.com/dynamics365/it/product/field-service/field-service-7/)

Online versions of Field Service v7 and earlier are [end of life](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/17/announcing-end-of-life-for-field-service-online-legacy-versions-by-february-2020/) and no longer supported. Any support requests you submit for these versions of FS, will not be serviced by Microsoft until you upgrade to the latest version.
 
Please upgrade legacy versions of Field Service directly from the admin center. 

This is a significant upgrade which has a number of potentially disruptive changes including data model, mobile, and interface changes. Please review the [Field Service playbook](https://aka.ms/fsuciupgrade) for more information. Prior to applying the upgrade to production, please first test the upgrade on a non-critical, production-like environment.
 
All customers are strongly advised to upgrade all legacy versions of FS and PSA to the latest solution versions, immediately.


### See also

- [New and upcoming features](new-upcoming.md)
- [Self-enabling install of the Unified Interface versions of Field and Project Service](https://cloudblogs.microsoft.com/dynamics365/it/2019/08/01/how-to-enable-unified-interface-apps-of-field-service-and-project-service-automation/)
