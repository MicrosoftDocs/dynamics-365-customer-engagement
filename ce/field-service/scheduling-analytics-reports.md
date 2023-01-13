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



### Disabling custom actions 

**msdyn_AnalyticsSaveDataInConfigStore custom action**

Do not disable this custom action because insights and analytics features in Dynamics 365 will not function properly; the **msdyn_AnalyticsSaveDataInConfigStore custom action** is for internal use only. Contact Microsoft support if you have any questions.

#### Parameters

| Name | Type | Required | Description |
|----------|----------|----------|---------|
| Key | String  |Yes | For internal use only. |
| Value | String | Yes | For internal use only. |
| ConfigName | String | No | For internal use only. |
