---
title: "Resource scheduling and optimization analytics dashboard in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn about resource scheduling and optimization analytics dashboard in Dynamics 365 Field Service
ms.date: 03/20/2020
ms.reviewer: mhart

ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FeifeiQiu
ms.author: feiqiu
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Resource scheduling and optimization analytics dashboard

## Prerequisites

- To get the resource and utilization report: 

  1. Install or upgrade Field Service
  2. The Resource and utilization report will appear in the Field Service app for users with **System Administrator** or **Field Service-Administrator** security roles. 

- To get both resource scheduling optimization reports:

  1. Install or upgrade Field Service
  2. Install or upgrade the **Resource Scheduling Optimization** add-in
  3. Both the resource scheduling optimization admin and the optimization summary reports will appear in the resource scheduling optimization app for users with **System Administrator** or **Field Service-Administrator** security roles. 




#

## Configuration considerations

- Other than editing filters and the ability to drill down, the reports are not configurable or customizable. 


## Additional notes

- The reports explored in this article are all built on Microsoft Power BI.
- **Travel Calculation**: All travel calculation is based on the miles. 
- **SLA**: Data is refreshed every 24 hours. Reports will continue to be available during the refresh. If the reports are not refreshed within 24 hours, you can contact Microsoft Support. Note that currently, we do not support the custom refresh schedule.
- **Data Refresh for Inactive environments**: If an organization has no active usage of the reports for continuous two weeks, the data refresh will be paused. When the user opens the reports, the data will get refreshed in the next refresh cycle.
- Data is retained for 24 months. 
- We do not support environment minimal copy operations that are available for a Sandbox environment. If you perform any of these operations, you may encounter unexpected results. 
- Storage file size automatically increases with the analytics feature. If this increase causes issues or concerns, contact Microsoft Support.

**Data Availability for Entities**: We are consuming the following list of entities to generate these reports. If there is no data for any of the below entities, then the report may show blank. If you have customized these entities or not using the out of box entities, then the reports will show blank too. 

  Field Service entities:  
  - Bookableresource 
  - bookableresourcebooking 
  - msdyn_resourcerequirement 
  - Territory 
  - Calendarrule 
  - Bookableresourcegroup 
  - Bookingstatus 
  - msdyn_bookingtimestamp 
  - Organization 

  Resource Scheduling Optimization entities: 
  - Resource 
  - Bookableresource 
  - Territory 
  - Bookableresourcebooking 
  - msdyn_optimizationrequestbooking 
  - msdyn_resourcerequirement 
  - msdyn_priority 
  - msdyn_routingoptimizationrequest 
  - msdyn_routingprofileconfiguration 
  - Calendar 
  - Calendarrule 
  - bookableresourcegroup 
  - Bookingstatus 
      - Organization

### Error messages

| Error Message | Action |   
| --- | --- |
| Oops! No reports were found in CRM. You may not have access to these reports. Contact your system administrator. | Contact your organization's system administrator to access the reports | 
| Oops! Internal service error, please contact your system administrator with Error Code: {numeric value}. | Contact Microsoft Support and create a support ticket |
|Oops! There was a problem rendering the report. | Refresh the report. If it still doesn’t work, contact Microsoft Support and create a support ticket |
|Oops! There was a problem rendering the report, please try again. | Refresh the report. If it still doesn’t work, contact Microsoft Support and create a support ticket |

### Supported regions for reports

| Region | Name | 
| --- | --- |
| North America| NAM |
| South America | SAM |
| Canada | CAN |
| Europe | EUR |
| Asia Pacific Japan |APJ |
| Australia | OCE |
| Japan| JPN |
| India | IND |
| Great Britain |GBR |

### Disabling custom actions 

**msdyn_AnalyticsSaveDataInConfigStore custom action**

Do not disable this custom action because insights and analytics features in Dynamics 365 will not function properly; the **msdyn_AnalyticsSaveDataInConfigStore custom action** is for internal use only. Contact Microsoft support if you have any questions.

#### Parameters

| Name | Type | Required | Description |
|----------|----------|----------|---------|
| Key | String  |Yes | For internal use only. |
| Value | String | Yes | For internal use only. |
| ConfigName | String | No | For internal use only. |


[!INCLUDE[footer-include](../includes/footer-banner.md)]