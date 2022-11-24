---
title: Set defaults for work orders, bookings, the schedule board, and agreements
description: Learn how to set defaults for work orders, bookings, the schedule board, and agreements in Dynamics 365 Field Service.
ms.date: 09/23/2022
ms.topic: article
author: jshotts
ms.author: jasonshotts
ms.reviewer: mhart
search.app: 
  - D365CE
  - D365FS
---

# Set defaults for work orders, bookings, the schedule board, and agreements

System administrators define settings for work orders, bookings, agreements, and more on the **Field Service Settings** page.

1. In Field Service, change to the **Settings** area.
  
1. In the **General** section, select **Field Service Settings**.

   :::image type="content" source="media/settings-field-service-settings.png" alt-text="Screenshot of the Field Service Settings page in the Settings area.":::

1. Select the settings you want to change and fill in the information, as required.  Refer to the following table for a description of the settings.

1. Select **Save** to apply your changes.
  
## Work Order / Booking settings

This settings tab lets you define several default values and basic settings related to work orders and bookings.
  
|   Option     |   Description  |
| ------------- | -------------- |
|**General section**||
|  Work Order Prefix  |  Select a prefix for all your work orders. The system adds the prefix before the work order number to distinguish work orders from other types of service requests. |
|  Default work order completed status  | Choose whether the default booking status for a completed work order is **Completed** or **Posted**. For more information, go to [Set up booking statuses](set-up-booking-statuses.md).   |
|  Default Warehouse   |    Select the default warehouse that work order products will be taken from unless specified otherwise. For more information, go to [Create a warehouse](create-warehouse.md).   |
| Suggest Reparenting Customer Assets | Warn users when a customer asset gets added to a work order that doesn't relate to the work order's service account. If it's set to *Yes*, the system offers to map the customer asset to the work order's service account. When set to *No*, the warning and suggestion won't show. |
| Timestamp Frequency | Choose when the system updates the timestamp for a booking. |
| Calculate Price | Work orders contain pricing-related fields and functions. By default, this field is set to *Yes*, which enables pricing-related fields and logic. Changing the setting to *No* removes all pricing-related fields and disables the pricing logic. So work orders won't generate invoices after completion.|
| Show Simplified Work Order Commands | This setting influences the command bar on work order records and lists. By default, this field is set to *Yes*, which shows only the most relevant commands for work orders. The following commands will be hidden from the form: deactivate, check access, process, add to queue, queue item details, assign, share, email a link, flow, Word templates. The following commands will be hidden from the list view when no records are selected: email a link, flow, import from Excel. The following commands will be hidden from the list view when a record is selected: activate, deactivate, email a link, add to queue, flow, Word templates, Excel templates. When set to *No*, all commands are shown. |
|  Work Order Starting Number |  Provide number from which the system starts the count of work orders. |
|  Work Order Invoice Creation  |   Choose if the system should automatically generate a billing invoice for work orders when the status changes to *Closed - Posted*. |
|  Travel Charge Item      | Select the product that the system uses for travel charges for a work order. The pricing will be determined by the standard pricing rules. For more information, go to [Create a product or service](create-product-or-service.md). |
| Disable Customer Asset Validation | Control work order creation if customer assets on the work order don't belong to the same service account. When set to *Yes*, users can't create a work order if the customer assets don't relate to the service account. When set to *No*, the system requires customer assets related to the service account on a work order. |
| Calculate Tax | [Tax codes](set-up-tax-codes.md) calculate and add taxes to products and services. When set to *No*, the tax code field and calculations from all related forms are disabled. |
| Generate Actuals | When set to *Yes*, the system creates records with actuals over the course of a work order's lifecycle. If set to *No*, the system disables the creation of work order-related actuals. |
| **Resource pay type section** |  |
| Work Pay Type   |  Choose the [resource pay type](set-up-resource-pay-types.md) for work performed during regular work hours.   |
| Business Closure Pay Type  |  Choose the pay type for days marked as *Business Closures*. For more information, go to [Set when your business is closed](../customer-service/set-when-business-closed-csh.md). |
|  Travel Pay Type |    Choose the pay type for time that a resource is traveling to a service location.  |
|  Overtime Pay Type |   Choose the pay type for time outside of the scheduled work hours.  |
|  Break Pay Type  |  Choose the pay type for time that the resource is taking a break while performing service work.  |
|  **Crew management section**    |                                                                                    |
|  Default Crew Strategy  |   Select the crew strategy applied as a default to all [resource crews defined in the system](resource-crews.md). You can override the crew strategy for each resource crew independently.|
|  **Mobile section**  |    |
| Enable Booking Map for Field Service Mobile | Turn on an external service to enable the booking map in the Field Service Mobile application. Review the terms of use and confirm to enable the booking map. |

## RMA settings

Return merchandise authorization (RMA) is the return process for customers who have requested to return or exchange merchandise. For more information, go to [Process a return](process-return.md).
  
|  Option  | Description |
|-----------|-------------|
| RMA Prefix| Select a prefix for RMAs. The system adds the prefix before the RMA number.|
| RMA Starting Number | Provide number from which the system starts the count of RMAs.  |
  
## RTV settings

Return to vendor (RTV) is the return process for customers who have received unwanted or damaged goods. For more information, go to [Process a return](process-return.md).
  
|  Option  | Description   |
|-----------|---------------|
| RTV Prefix| Select a prefix for RTVs. The system adds the prefix before the RTV number.|
| RTV starting number |  Provide number from which the system starts the count of RTVs.  |
  
## Agreement settings

Field Service agreements allow organizations to automatically generate work orders and invoices. For more information, go to [Set up agreements](set-up-customer-agreements.md).
  
|  Option   |    Description    |
|------------|-------------------|
| Agreement Prefix| Select a prefix for agreements. The system adds the prefix before the agreement number.|
| Auto Generate Work Order for Agreement Booking  |  Select whether the system should automatically generate work orders based on agreements. If set to *No*, users have to create the work orders manually. |
| Generate Booking Dates X Months in Advance    | Agreement booking dates help organizations plan for maintenance. If an agreement spans a long time period, you may not want to generate all booking dates at once. Agreements generate booking dates based on the agreement booking setup recurrence schedule. With auto-generate enabled, the system creates a work order booking on these dates. This setting determines how many months in advance the system generates the work order booking. |
|   Generate Invoice Dates X Months in Advance   | Agreements generate invoice dates based on the agreement invoice setup recurrence schedule. With auto-generate enabled, the system creates an invoice record on these dates. This setting determines how many months in advance the system generates the invoice dates.   |
|  Pre/Post Booking Flexibility Date Field Population  | When configuring an agreement, you can define pre- and post-booking flexibility fields. These fields set the time frame in which each work order should get booked. This setting defines whether work orders generated from agreements will populate this time frame in the *Date Window Start/End* or the *Time From/To Promised* fields. |
|  Agreement Starting Number   | Provide number from which the system starts the count of agreements.   |
| Generate Agreement Work Order X Days in Advance |  Number of days in before the booking date when the system generates the work order record.  |
|  Generate Agreement Invoices X Days in Advance  |  Number of days in before the invoice date when the system generates the invoice record. |
|  Record Generation Timing  | Defines the default time to generate work orders and invoices based on agreements. The setting helps to ensure that work orders aren't created in the middle of a work day while dispatchers are scheduling and managing other jobs. You can override this value for each agreement. *Start/End Times* values for bookings and *Time To/From Promised* values for work orders generated by agreements use the time zone of the related agreement owner. |
  
## Purchase settings

You can use purchase orders (POs) to add inventory to a warehouse, or to purchase products to sell to a customer in a work order. For more information, go to [Create a purchase order](create-purchase-order.md).
  
|  Option  |  Description  |
|-----------|---------------|
| Purchase Order Prefix| Select a prefix for purchase orders. The system adds the prefix before the purchase order number. |
| Purchase Order Approval Required |  Choose if a purchase order needs approval before changing the status to *Submitted*. |
| Purchase Order Starting Number  |  Provide number from which the system starts the count of POs.  |
| Use of Products Out of Stock   | Choose how the system reacts when a user adds a product to a work order that's currently not in stock. *Confirm* asks the user to decide whether to continue or not.  *Restrict* won't allow using that product. |
  
## Inventory settings

Inventory tracks the availability of products in a warehouse. For more information, go to [Overview of inventory, purchasing, and returns](inventory-purchasing-returns-overview.md).
  
| Option | Description |  
|-------------|-----------------|  
| Inventory Transfer Prefix   |  Select a prefix for inventory transfers. The system adds the prefix before the inventory transfer number. |  
| Inventory Transfer Starting Number | Provide number from which the system starts the count of inventory transfers. |  
| Inventory Adjustment Prefix |Select a prefix for inventory adjustments. The system adds the prefix before the inventory adjustment number. |
| Inventory Adjustment Starting Number |Provide number from which the system starts the count of inventory adjustments.|  
  
## Intelligence settings

Predictive work duration lets dispatchers predict the duration bookings. For more information, go to [Predictive work duration and resource proficiency suggestions](analytics-predictive-work-duration.md).
Incident type suggestions help administrators manage work order templates. For more information, go to [Use AI to get Incident Type suggestions](configure-incident-types.md#use-ai-to-get-incident-type-suggestions).

|  Option  |  Description   |  
|-------------|-----------------|  
| Enable Suggested Duration |  When enabled, this setting looks at historical booking data and suggests an average duration at the incident type level.|
| Historical Data Filter | This setting is used for both the suggested duration and incident type suggestions. It defines the data scope for analysis when looking at historical data to provide suggestions.|
| Enable Incident Type Suggestion | When enabled, this setting enables the analysis of historical work order data to suggest ways to improve an organization's usage of incident type. Once enabled, you specify which results the model returns and review the suggestions from the intelligent analysis. From the subgrid, a user can dislike or apply the suggestions from the model. |

## Field Service SLA Configuration settings

Use this tab to manage Service level agreements (SLAs) for work order. For more information, go to [Service level agreements (SLAs) for work orders](sla-work-orders.md).

## Time Entry settings

Time entries help track the time that technicians spend on various stages of a work order. For more information, go to [Time entries](field-service-time-entry.md).

|  Option  |  Description  |  
|-------------|--------------|  
| Time Entry Generation Strategy | Enable the system to automatically generate time entries based on booking timestamps. If the setting is empty or set to *Manual*, the system expects manual time entries. Regardless of the setting, you can always create time entries manually.|
|Time Cost Actuals Source| Choose if cost actuals generate based on booking journals or time entries when the time entry is marked as approved. If this setting is empty, the system generates time and cost focused actuals from booking journals. Actuals are generated when a work order is set to *Closed - Posted*.  |

## Remote Assist settings

Change Field Service settings for Dynamics 365 Remote Assist. For more information, go to [Collaborate in mixed reality](remote-assist-hololens.md).

|  Option  |  Description  |  
|-------------|-----------------|  
| Disable Booking Status Changes  |   Specify if users can change a booking status in Dynamics 365 Remote Assist on HoloLens. |

## Inspection settings

Inspections are forms that technicians use to answer a list of questions as part of a work order. For more information, go to [Add inspections to work orders](inspections.md).

|   Option  |      Description     |
|------------|----------------------|
| Analytics enabled  |   Turn the analytics for inspections on or off. For enabled analytics, you can specify the frequency and the start time of the analysis. |
  
## Other settings
  
|   Option  |      Description     |
|------------|----------------------|
|  Entity Number Length  |   Enter the number of digits for entity numbers. For example, if you enter 5, the first work order number would be 00001.  |
| Auto Allocate Estimated Products | When products are added to a work order before the work begins, the status of the work order product record defaults to *Estimated*. This setting determines whether the work order product record is set to *Allocated* when the line status is still *Estimated*, as opposed to *Used*. |
|  Auto Geo Code Addresses |  Specify whether the system should automatically add the appropriate latitude and longitude values based on the account's address. For more information, go to [Turn on auto geocoding](turn-on-auto-geocoding.md).   |
| Use Enhanced Background Processing (**Preview**) | Field Service includes various workflows that run in the background. Enable this setting to use Power Automate flows instead of some default Field Service workflows. Power Automate lets you connect and run workflows in Dynamics 365 apps and between third-party applications. You can automate actions such as delete records, schedule jobs, or approval flows. For Field Service specifically, using Power Automate in place of background processes related to agreements improves performance for long-waiting agreements and fixes complications if an agreement owner no longer has access to Dynamics 365. |
| Enable Address Suggestions   | Enable this setting to get suggestions when entering the addresses in various forms.  |
| Product cost order   | Choose the order for product cost.   |
| Work Order Subgrid Records Open as Popups | Specify if work order subgrid records open as a popup on work order form. Subentities of the work order entity: work order product, work order service, work order service task, work order incident, bookable resource booking, and time entry.   |

[!INCLUDE[footer-include](../includes/footer-banner.md)]
