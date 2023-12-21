---
title: Mobile offline capabilities (contains video)
description: Learn about the mobile offline profile for the Dynamics 365 Field Service mobile app including guidance and limitations for its use.
ms.date: 12/18/2023
ms.topic: overview
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
---

# Mobile offline capabilities

Often frontline workers need to work in areas without internet access like remote areas or underground. The Dynamics 365 Field Service mobile app offers offline capabilities through a mobile offline profile. When an admin [configures an offline profile](mobile-power-app-system-offline-setup.md), frontline workers can continue using the Field Service mobile app when there's no internet connection. With offline capabilities, important data syncs to the device for viewing when there's no internet connection. Changes on the device are stored locally and then they sync with the server when an active internet connection becomes available.

The offline profile manages offline record types, relationships, and user assignments. For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4J8no]

Field Service mobile follows the same architecture and security as the Power Apps mobile app. For more information, see: [Overview of Power Platform security](/power-platform/admin/security/overview#the-application-and-data-on-the-device).

## Implementation guidance for the offline profile

**Use the default offline profile**. Although you can create your own mobile offline profile, we highly recommend using the default offline profile included with Field Service. The **Field Service Mobile - Offline Profile** provides an ideal starting point for offline configuration, with defaults for out-of-the-box record types and sync intervals. Use this profile and build upon it by including your custom record types. By working within the provided profile, default tables can still receive updates over time. With offline data, in-app performance such as displaying forms increase. Limiting the amount of data in the offline profile increases sync performance.

Using the default offline profile allows your offline profile to receive updates to unchanged table sync filters. You can copy the default profile and make changes to the copy, but the system considers the copy unmanaged. The copy won't receive any updates. If you make changes to the default offline profile and want to see the latest offline profile, create a new trial of Field Service to view it.

**Avoid removing default record types from the offline profile**. We purposefully added default record types  to ensure the right data is available to the frontline worker. Focus on adding the record types you need to the offline profile rather than removing ones you don't need.

**Avoid using "All records" as an offline filter**. The offline profile is the gate that controls the amount of data downloaded to the frontline workers’ devices. Technically, there's no limit to the number of records the offline profile supports. However, to keep sync times fast and efficient, avoid including "All records" as an entity filter and avoid wide date ranges. For example, rather than downloading all customer asset records, download only the records related to scheduled work orders. It reduces the number of customer asset records without impacting work at hand. For optimal performance we recommend that you follow the [offline profile guidelines](/power-apps/mobile/mobile-offline-guidelines).

**Use offline JavaScript**. Organizations often need to run workflows on mobile devices to execute business processes. However, Power Automate flows only run when the device has network connection or on the next sync. Use offline JavaScript to run workflows on the device quickly and without internet access. For more information, go to [Workflows and scripts for the Field Service mobile app](mobile-power-app-workflows.md).

For more best practices, go to [Power Apps Mobile Offline Guidelines](/power-apps/mobile/mobile-offline-guidelines)

## Limitations of the offline profile

- Offline sync filters: Creating a record on the device while in offline mode, and that record doesn't meet filter conditions, then the record doesn't get resynchronized from the service until it meets the conditions.
- Offline sync filters: After setting up commands or capabilities to work with internet connectivity but not in offline mode, review them to confirm they're calling correct APIs: `Xrm.WebApi.online`.
- Offline Tables: Tables that support offline are part of the default *Field Service Mobile - Offline Profile*. Some field service tables such as Purchase Order, Agreements, RTV, and RMA don't support offline profiles. Adding these tables and running the application while offline may result in errors in the mobile application.
- Inventory Validation doesn't run without network.
- When configuring the Mobile Offline Profile, there can be a maximum of 15 linked Tables. This 15-link limit includes downstream Tables. For example, if Table A has relationship with Table B, C, D and Table B has a relationship with Table F, G, H. Table A will have six relationships: B, C, D, F, G, and H. 
- [Details on other platform supported capabilities and limitations for offline](../mobile-app/mobile-offline-capabilities.md)
- Access to SharePoint documents isn't supported in offline mode.
- Due to some current [limitations](/power-apps/mobile/offline-capabilities#limitations) of offline WebResources, we recommend using the [Power Apps component framework (PCF)](/powerapps/developer/component-framework/overview) to implement custom capabilities that work in the mobile app and in the browser.

### What happens when I reconfigure the offline-enabled application?

Reconfiguring the mobile application clears the offline database on the device. The application starts a new full offline sync and then transition back into offline mode. Between starting the reconfigure process and completing the offline sync, the application works as in online mode.

### Why does the offline enabled application show a message "Network or Service Unavailable"

The message "Network or Service Unavailable" shows when the application detects the network isn't suitable for online activity. While this message shows, the client won't sync new data, and some network-dependent areas of the application won't work. For example, maps or Dataverse search depends on device connectivity.

The application will check for connectivity whenever you navigate. The following events determine network detection, which may result in the error message:

- Application boots into offline mode prior to detecting network availability.
- Application network check fails with no response or a response that takes too long.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
