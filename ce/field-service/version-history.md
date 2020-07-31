---
title: "Field Service version history | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
ms.date: 07/06/2020
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
| Mobile Project Template              | 1.0.4847       | [Direct download link (English only)](https://aka.ms/fsmobile-project)      |

For information about other updates to Field Service, visit the [Dynamics 365 release plans](https://docs.microsoft.com/dynamics365/release-plans/). 

|  | Region | Current version | Next version |  Scheduled date
| :---   | :---   | :---   | :---   |:---   |         
|<strong>Station 2</strong> | |  |  | |
| | <i>South America</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 07/31/2020
| | <i>Canada</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 07/31/2020
| | <i>India</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 07/31/2020
| | <i>France</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 07/31/2020
| | <i>United Arab Emirates</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 07/31/2020
| | <i>South Africa</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 07/31/2020
| | <i>Germany</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 07/31/2020
|<strong>Station 3</strong> | |  |  | |
| | <i>Japan</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 08/07/2020
| | <i>Asia Pacific</i>  |  [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 08/07/2020
| | <i>Great Britain</i>  |  [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 08/07/2020
| | <i>Oceana</i>  |  [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 08/07/2020
|<strong>Station 4</strong> | |  |  | |
| | <i>Europe</i> | [8.8.24.17](https://docs.microsoft.com/dynamics365/field-service/version-history#882417) | [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 08/14/2020
|<strong>Station 5</strong> | |  |  | |
| | <i>North America</i> |[8.8.24.54](https://docs.microsoft.com/dynamics365/field-service/version-history#882454)| [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 08/21/2020
|<strong>Station 6</strong> | |  |  | |
| | <i>Government Community Cloud</i> |[8.8.24.54](https://docs.microsoft.com/dynamics365/field-service/version-history#882454)| [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 08/21/2020
| | <i>China</i> |[8.8.24.54](https://docs.microsoft.com/dynamics365/field-service/version-history#882454)| [8.8.25.29](https://docs.microsoft.com/dynamics365/field-service/version-history#882529) | 08/21/2020

>[!Note]
> - Dates in all regions except Government Community Cloud (GCC) and China indicate the timing of the next automatic update. Dates in GCC and China indicate version availability; at this time, there is no automatic update for these regions.
> - For all other regions, while most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 8.8.25.29
(Includes Universal Resource Scheduling version [3.12.24.4](https://docs.microsoft.com/dynamics365/field-service/field-service-version-history-resource-scheduling#312244)) 
- Corrected an issue on bookable resource booking forms where the **Estimated Arrival Time** field can appear as if it has been edited immediately after save (when it hasn’t been), making the form behave as if it had unsaved changes.
- Improved logic to allow for customizations to the work order form where the primary incident type is removed from the form to ensure that the out-of-the-box form logic has a null check for the **Primary Incident Type** field.
- Resolved an issue with missing localization strings on the IoT alert and IoT device entities which could cause a script error.
- Fixed an issue on update of agreement booking incident, which produced an error if there was a related agreement booking service task with a null estimated duration.
- Resolved a problem with the agreement copy function which failed to copy agreements if there were deactivated agreement booking setup or agreement invoice setup records related to the agreement. The copy function will now successfully copy active records and ignore inactive records.
- Added a new Field Service health rule which will highlight agreement booking setup and agreement invoice setup records on which the latest workflow instance had failed which could keep expected work orders and invoices from being generated. Once detected, the rule also provides a button to resolve failed workflow instances.

## 8.8.24.54
(Includes Universal Resource Scheduling version [3.12.23.71](https://docs.microsoft.com/dynamics365/field-service/field-service-version-history-resource-scheduling#3122371)) 
- Includes all content from Field Service version 8.8.24.17

## 8.8.24.17

(Includes Universal Resource Scheduling version [3.12.23.26](https://docs.microsoft.com/dynamics365/field-service/field-service-version-history-resource-scheduling#3122326))

- Corrected a null reference error based on work order product form customizations to better handle when certain fields are removed from the form.
- Resolved an issue with the incident type duration suggestions feature that produced an error when a user clicked “Recalculate Suggestions” for large query results.
- Fixed an issue with agreement update which produced a "Nullable object must have a value" error on updating end date of an agreement whose end date is null.
- Removed the following BPFs from the Field Service Mobile app module: case to work order, lead to opportunity sales, opportunity sales, phone to case.
- Improved logic to allow for customizations on work order creation from an agreement if there are customizations in place to automatically create additional resource requirement records.
- Improved Field Service’s missing form libraries rule in Solution Health Hub to improve the rule description.
- Enhanced logic to in the opportunity quick create form to respect scenarios when an environment sets the “Account” field as business required to ensure that Field Service form logic does not set the field as optional.

## 8.8.23.85

(Includes Universal Resource Scheduling version [3.12.22.9](https://docs.microsoft.com/dynamics365/field-service/field-service-version-history-resource-scheduling?branch=master#312228))

- Improved crew booking validations, which ensure that the booked crew has at least one defined crew member for the date on which the booking is being created.
- Improved descriptions in upgrade scripts to make the script more comprehensible by an administrator by documenting deprecated upgrade script steps to minimize confusion.
- Fixed an issue that left the status null when created a new geofence, which could cause geofence events to not be created.
- Repaired a Field Service upgrade issue caused by a script that, when appropriate, created requirement group records. If the requirement group's name was too long, the script and upgrade would fail.
- Fixed an issue on the contact entity's geo code functionality that caused a script error if "Auto Geo-Code" was set to "No" in Field Service settings.
- Corrected an incorrect agreement booking setup recurrence validation error for "Too many days in month." Under certain circumstances, this error was thrown inappropriately.
- Resolved an issue with duplicate section and tab IDs in Connected Field Service that caused issues when trying to uninstall the solution.
- Corrected a null reference issue in Connected Field Service when loading the device summary control on the IoT alert form.

## 8.8.22.58

- Includes release of [Dynamics 365 Field Service (Power App)](mobile-2020-power-platform.md), a new mobile app for technicians built on the Power Platform. As part of this release, administrators will see a new app called "Field Service Mobile" in the list of apps.
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
- Corrected scenario where msdyn_payment was null on payment details, which was improperly throwing the following error "The payment amount can't be less than total amount applied to invoices."
- Fixed an issue where price list not changing based on changes to work order's billing account. For organizations experiencing this issue, a fix is made available through the "Advanced Settings" field in the Field Service settings entity, in an effort to not introduce a potentially disruptive change at this time. Copy the following string into the hidden field:  

> *workorder.pricelist.usefrombillingaccount*

- Resolved an issue where the time-only control misinterpreted daylight savings time for certain timezones.
- Fixed an issue where form logic was not respecting environment configurations on the Lead entity. Customers can now set fields, like "Company," to be business required and the Field Service form logic will respect the setting.
- Corrected an issue on work order service where the "Total Amount" was not respecting the "Discount" when used in an editable grid.
- Removed the validation on bookable resource that required each bookable resource's name to be unique.
- Fixed an error on the quote booking product where, under certain circumstances, the system would inaccurately throw the following error: "Enter an amount between $0.00 and $922,337,203,685,477.00."
- Fixed an issue on the work order quick create from account where the billing account did not populate correctly.
- Improved customer asset look-up experience from work order incident to ensure the form respects when organizations define their own default lookup view.
- Resolved an issue where, in certain timezones, agreement booking setup's preferred start time was not appropriately setting on agreement booking dates' booking date and the subsequently autocreated bookable resource booking based on the defined "Preferred Start Time."
- Fixed a scenario where, if an environment sets the default value of msdyn_linestatus to "Used," work order service creation would fail.
- Added a null reference check to correct an issue if work order service's "Duration to Bill" was not set.

## 8.8.12.2

- Fixed an issue where the "Generate Work Order" button from advanced find on agreement booking dates was not displaying and working properly.
- "Due Date" field value on invoices generated from agreement invoice date is one day early. For organizations experiencing this issue, a fix is made available through the "Advanced Settings" field in the Field Service settings entity. Copy the following string into the hidden field:  

> *autogeneration.usetimezone.invoiceduedate=true*

- Resolved a bug on work order service records that have been deactivated throwing an error when being reactivated, "Object Reference Not Set to Instance of an Object."
- Corrected an unhandled error in geocoding that failed if the address contained an extra comma.
- For organizations that would prefer that work orders generated from cases open in the same window, this can now be controlled through "Advanced Settings" field in the Field Service settings entity. Copy the following string into the hidden field if you would prefer work orders to open in the same tab in the same window:  

> *casetoworkorderwindowbehavior=0*

>[!Note]
> The "Advanced Settings" field on Field Service settings is not added to the entity form by default.  

## 8.8.11.19

**Available in all regions by April 2020**.

- Fixed an issue where agreement booking date generation fails when agreement is owned by a team.
- Resolved an issue where Field Service client-side logic fails when using contact form while in offline.
- Resolved purchase order product form customization issues where:
  - If an organization removed the "Quantity Received" field from the purchase order product, they would be unable to create a new purchase order product record.
  - Work order and warehouse values do not autopopulate if the fields are removed from the form.
- When using quick create form for a work order from an account, fixed an issue where some of the fields that were expected to autopopulate were not being populated.
- If the map control is removed from the work order form, it cannot be added back. The control has been locked to the form so that it cannot be removed from the form.
- Issue where the primary incident type record of a deactivated work order could not be deactivated; added a validation check to only allow the work order incident record to be deactivated when work order is deactivated.

## 8.8.14.328 (2020 Wave 1 early access)

For more information about early access features, visit the [opt-in instructions](https://docs.microsoft.com/power-platform/admin/opt-in-early-access-updates).

- Before a work order product or work order service is set to "Used," the total amount is not calculated.
  - Previously, under some circumstances, a work order service line in estimated status could have a total amount value, despite not being set to used. This could result in challenges when looking at the work order's total amount and potential downstream invoice discrepancies.
  - This also required an improvement to the work order product and work order service views to ensure we show both the estimated total amount and the total amount so users could understand the value in context of the line's current status.
- On the agreement booking/invoice setup, booking and invoice generation time (respectively) could be incorrect if the user who owns the agreement is in a time zone +1 or higher from UTC.
  - Going forward, the system will consider the agreement booking/invoice setup owner's time zone when generating date records.
  - This will now mean that agreement booking date and agreement invoice dates will be generated correctly and consistently, relative to the owner's time zone.
  - Note: Be sure to validate that all existing agreement booking setups and agreement invoice setups owned by users +1 or greater than UTC are correctly configured to generate invoices and work orders per organizational expectations.
- On tax codes, when "Act As Tax Group" is set to "Yes," tax rate percentage and items taxable should be hidden.
  - When a tax code is configured to act as a tax group, the tax rate and items taxable should be hidden from the user as these values come from the applicable related tax code details for a tax group.
  - Further, on the tax code, when "Act as Tax Group" is set to "Yes," a form notification will now show on the form to highlight that tax code details must be created for taxes to be applied when the tax code is used.
- On the opportunity entity's main form, account shouldn't be mandatory if order type is not "Service-Maintenance Based."
  - When creating an opportunity, the account field should only be mandatory if the order type is "Service-Maintenance Based."
- On the agreement booking/invoice setup, if a user's time zone was set to a GMT +1 or higher, the default range of recurrence was autocalculated to one day before agreement start/end.
  - When defining an agreement booking/invoice setup as a user in a time zone +1 or higher from UTC, then the range of recurrence on the record's recurrence string was always calculated one day before the start/end date of the related agreement's start/end date.
  - This will now calculate the default recurrence range appropriately based on the user creating the record's time zone.
- Deprecated quote booking setup's margin tab and calculation logic.
  - Formerly, on the quote booking setup form, there was a tab that attempted to calculate the margin of the proposed booking setup.
  - Under certain circumstances, this margin calculation could be incorrect.
  - Due to the limited usage of the feature and the complexity involved in supporting every permutation of possible configuration with corrected calculations, the tab and related calculation logic was removed.
- Introduced better validation messaging if a user tries to increase the quantity on a quote line for service-based lines.
- Prevent agreement booking service task from being saved when task type lookup field is null.
  - If an organization customized the agreement booking service task entity to make the task type optional, this would result in downstream errors when trying to generate work order service tasks.
  - As such, a synchronous plugin was registered that will prevent the creation of an agreement booking service task if task type is null.
- Fixed typo in error message when incident type requirement groups is related to an empty requirement group template.
- Prevent work order service from being saved when the service lookup field is null.
  - If an organization customized the work order service entity to make the service optional, this could result in downstream errors.
  - As such, a synchronous plugin was registered that will prevent the creation of a work order service if service is null.
- Improved the warning notification message on the "Geo Code Address" button when Bing maps is disabled.

## 8.8.10.44

**Available in all regions**.

- Agreement booking service task's name is overwritten when the related task type changes.
- Cannot complete booking that has travel time if the travel charge type on the related work order's account is null.

## 8.8.9.84

- Script error when account field is removed from the opportunity quick create form.
- On creation of account record based on postal code functionality, service territory is repeated autopopulated, even after the customer removes the initial autopopulated value.
- Consistency issue in Field Service's Solution Health Hub rule naming when referring to SDK message processing steps.

## 8.8.8.135

- Work order plugin error for SLA KPI instance.

## 8.8.8.50

- Improve error messages when the user attempting an action is missing "Field Service Setting" read privilege.
- Form logic always turns incident type to not required based on work order type, regardless of field settings.
- Bookings are not shared consistently to all resources on multi-booking work orders.
- Deleting and recreating a booking associated with a work order changes the shared users of booking.
- TypeError: Cannot read property "getDefaultView" when requested by contact field removed from RMA form.
- Agreement invoice product currency set to base currency - should be set to agreement's price list currency.

## 8.8.7.47

- Removal of territory from work order is not removed from non-primary related requirements.
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

## Field Service On-Premise

| Version | Status | Details |
| --- | --- | --- |
| 7.x | Latest available | [Link](https://mbs.microsoft.com/customersource/Global/365Enterprise/downloads/product-releases/365fieldservice7) |
| 6.x | Not supported | |

## Important notes

### Field Service Online end-of-life for v7.x and earlier

[Version history notes for v7.x](https://cloudblogs.microsoft.com/dynamics365/it/product/field-service/field-service-7/)

Online versions of Field Service v7 and earlier are [end of life](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/17/announcing-end-of-life-for-field-service-online-legacy-versions-by-february-2020/) and no longer supported. Any support requests you submit for these versions of Field Service will not be serviced by Microsoft until you upgrade to the latest version.

You can upgrade legacy versions of Field Service directly from the admin center.

This is a significant upgrade that has a number of potentially disruptive changes including data model, mobile, and interface changes. Review the [Field Service playbook](https://aka.ms/fsuciupgrade) for more information. Prior to applying the upgrade to production, be sure to first test the upgrade on a non-critical, production-like environment.

All customers are advised to upgrade all legacy versions of Field Service and Project Service Automation to the latest solution versions as soon as possible.

### See also

- [New and upcoming features](new-upcoming.md)
- [Self-enabling install of the Unified Interface versions of Field and Project Service](https://cloudblogs.microsoft.com/dynamics365/it/2019/08/01/how-to-enable-unified-interface-apps-of-field-service-and-project-service-automation/)
