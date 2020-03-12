---
title: Track a project’s status
description: How to track a project’s status in Project Service
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 8/03/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Track a project’s status (Project Service)

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

Use the [!INCLUDE[pn_dyn_365_project_service_auto](../includes/pn-dyn-365-project-service-auto.md)] to track the progress of a client’s project.  

As the engagement progresses, the project stages update to reflect the stage of the engagement:  


|              |                                                                                                                                                                                                                                                                                                  |
|--------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   **New**    | When you create a project, the stage is set to **New**. If you created the project from a template, at this stage the project may have a schedule, estimates, and team data. Otherwise, it will be the outline of the project and you need to manually enter the rest of the project components. |
|  **Quote**   |      When you associate a project to a quote or create it from a quote, the project stage is set to **Quote**, and the estimated start and end datesare updated as well. When the project is in the quote stage, details on the quote display on the **Sales** tab on the **Project** page.      |
|   **Plan**   |                                     When you win a quote associated with a project, and when the engagement progresses to the contract stage, the project stage updates to **Plan**. Contract details display on the **Sales** tab on the **Project** page.                                      |
| **Complete** |                    When the project work is complete, you can flip the stage to **Complete**. When the project stage is set to complete, it’s understood that the work is 100% complete but the project is kept open for any pending time or expense entries to be recorded.                     |
|  **Close**   |           When all transactions have been recorded on the project and you don't expect any more to be logged, you can manually set the stage to **Close**. When the project is set to **Close**, you can’t log any more transactions on the project and the project will be read only.           |

## To track a project’s status  

1.  Go to **Project Service > Projects**.  

2.  Click the project you want to work on.  

3.  In the bar across the top of the screen, select the down arrow next to the project name, and then click **Project Tracking**.  

4.  Select **Effort Tracking** or **Cost Tracking** in the drop-down list above the task list.  

5.  Double-click any task to edit it. You can also move or resize the bars in the Gantt chart to change the time and progress for a task.  

### See Also  
 [Project Manager Guide](../project-service/project-manager-guide.md)
