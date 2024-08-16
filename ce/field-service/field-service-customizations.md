---
title: Customize Field Service for your unique business needs
description: Learn how to customize Dynamics 365 Field Service for your business needs.
ms.custom:
- dyn365-fieldservice
ms.date: 06/25/2024
ms.topic: overview
author: lmasieri
ms.author: lmasieri
---

# Customize Field Service for your unique business needs

Administrators can configure Dynamics 365 Field Service to accommodate their unique business needs.

The following table provides links to documentation that you can use to perform common configuration tasks.

| Area | Documentation |
| --- | --- |
| Forms | [Create, edit, or configure forms using the form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms) |
| Work orders | [Create a work order](/dynamics365/field-service/create-work-order) |
| Scheduling | [Enable an entity for scheduling](/dynamics365/field-service/schedule-new-entity) |
| Scheduling | [Extend Universal Resource Scheduling with custom resource constraints](/dynamics365/common-scheduler/developer/understanding-and-customizing-resource-matching-in-urs) |
| Scheduling | [Search Resource Availability with Universal Resource Scheduling API](https://www.microsoft.com/dynamics-365/blog/it-professional/2019/05/21/retrieve-resource-availability-with-universal-resource-scheduling-api/) and [How to use the Search Resource Availability API – Universal Resource Scheduling](https://www.microsoft.com/dynamics-365/blog/it-professional/2019/07/15/how-to-use-resource-schedulings-search-resource-availability-api/) |
| Scheduling | [Edit work hour calendars by using APIs](/dynamics365/field-service/field-service-work-hours-calendar-api) |
| Scheduling | [Extend Universal Resource Scheduling actions to use your preferred geospatial data provider](/dynamics365/common-scheduler/developer/use-preferred-geospatial-data-provider) |
| Schedule board | [Set up booking rules](/dynamics365/field-service/set-up-booking-rules) |
| Mobile app | [Edit the navigation and views on the mobile app](/dynamics365/field-service/mobile-power-app-configure) |
| Mobile app | [Add a custom app module to the Field Service mobile app](/dynamics365/field-service/mobile-powerapp-copy-app-module) |
| Mobile app | [Create workflows and scripts for the mobile app](/dynamics365/field-service/mobile-power-app-workflows) |
| Mobile app | [Use Power Apps to configure the Field Service mobile app](/dynamics365/field-service/mobile-power-utilize-platform) |

## Undocumented custom controls

Field Service introduces controls that are intended to be used only as-is on the forms that use them by default.

Don't use the following controls in customization scenarios:

- MultiselectLookupControl
- msdyn_postponegenerationuntil: Internal use only. Manipulating values in this field or taking dependencies on it isn't supported and can lead to unexpected system behavior. This field is found in the following entities:

    - Agreement Booking Setup (msdyn_agreementbookingsetup)
    - Agreement Booking Date (msdyn_agreementbookingdate)
    - Agreement Invoice Setup (msdyn_agreementinvoicesetup)
    - Agreement Invoice Date (msdyn_agreementinvoicedate)
    - Order Invoicing Setup (msdyn_orderinvoicingsetup)
    - Order Invoicing Setup Date (msdyn_orderinvoicingsetupdate)
    - Order Invoicing Date (msdyn_orderinvoicingdate)
    - Incident Types Setup (msdyn_incidenttypessetup)
    - Quote Booking Setup (msdyn_quotebookingsetup)
