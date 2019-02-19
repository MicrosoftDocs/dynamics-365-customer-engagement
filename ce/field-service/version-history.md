---
title: "Field Service Version History | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 2/14/2019
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

## Latest versions

| Solution                             | Latest version | Download links                                                                                                                     |
|--------------------------------------|----------------|------------------------------------------------------------------------------------------------------------------------------------|
| Field Service                        | 8.4+           | [https://trials.microsoft.com](https://trials.microsoft.com).   See additional notes at the end of this document.                  |
| Field Service Mobile                 | 11.2+          | [Windows](https://aka.ms/fsmobile-windows),   [iOS](https://aka.ms/fsmobile-ios), and   [Android](https://aka.ms/fsmobile-android) |
| Mobile Configuration Tool (Woodford) | 11.3+          | [https://aka.ms/fsmobile-configurator](https://aka.ms/fsmobile-configurator)                                                       |
| Mobile Project Template              | 1.0.1322       | [https://aka.ms/fsmobile-project](https://aka.ms/fsmobile-project)                                                                 |

## Field Service version history

| Version Number  |  Release date  |  Notes | More details |
|---|---|---|---|---|
| 8.4.0.338  |  February 2019 |  Latest release for general availability (GA) | [Release Notes for 8.4.0.338](https://blogs.msdn.microsoft.com/crm/2019/02/11/release-notes-for-field-service-version-8-4-0-338/) |
| 8.3  |  December 2018 | SLA functionality for Work Orders, Connected Field Service   | [Release Notes for 8.3.0.255](https://blogs.msdn.microsoft.com/crm/2018/12/21/release-notes-for-field-service-version-8-update-release-3/) |
| 8.0  |  July 2018 |  Multi-resource scheduling (requirement groups) |
|  7.5.6.97 |  September 2017 |  |    [Release Notes for 7.5.6.97](https://blogs.msdn.microsoft.com/crm/2019/02/04/release-notes-for-field-service-version-7-5-6-97/) |
|  7.0 |  September 2017 |  Schedule board extensibility for custom resource matching |  
| 6.1  |  November 2016 | Release of Universal Resource Scheduling (URS) creating a framework to schedule any entitiy  |   
| 6.0  | June 2016  | Release of Field Service on shared data model. Added booking entities as core entities. f1_ schema prefix became msdyn_   |  
| 5.1  | May 2016  |  FieldOneSky Preferred Vendor Solution (PVS). f1_ schema prefix | 



## Mobile project file library

Mobile projects hold configurations and customizations of the Field Service Mobile app such as view and form layout, mobile workflows called form rules, and offline HTML/JavaScript. These mobile projects are imported in the Field Service Mobile Configuration Tool (Woodford). The Field Service engineering team periodically releases new mobile project templates to reflect new product updates and improve usability and performance. 

To utilize the mobile project, see the the topic on [installing the Field Service Mobile Configuration Tool](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/install-field-service#install-the-field-service-mobile-configuration-tool).

| Mobile project template version  | Mobile project template name | Release date | Relates to Field Service Mobile |  Publish to Woodford Version | Notes | More details |
|---|---|---|---|---|---|---|
| [1.0.1322](https://aka.ms/fsmobile-project)  |  FSDyn365_1.0.1322.woodford |   | 11.2 | 11.2 | |

## Additional notes

 - New Dynamics 365 trials created through [https://trials.microsoft.com](https://trials.microsoft.com) will install the latest generally available Field Service solution. 
 - You can upgrade your solution in **Admin Center** > **Dynamics 365**, as seen in the following screenshot. 
> [!div class="mx-imgBorder"]
> ![Screenshot of the admin center upgrade path for Field Service](./media/admin-upgrade-to-latest-admin-center.png)

 - If a new version of Field Service is available as a private preview, you can  [opt-in to upgrade Project and Field Service - Unified Interface](https://experience.dynamics.com/insider/campaign/?id=75505220-c2e6-e811-a96d-000d3a1bef07) and an upgrade will become available in the admin center.

- Installing Field Service Mobile from the Windows Store can allow for automatic upgrades of new versions.

### See also

- [New and upcoming features](new-upcoming.md)
