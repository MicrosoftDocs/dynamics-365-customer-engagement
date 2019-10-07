---
title: Schedule a project with a work breakdown structure 
description: How to schedule a project with a work breakdown structure in Project Service
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
# Schedule a project with a work breakdown structure (Project Service)

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

A project schedule communicates what work needs to be performed, which resources will perform the work, and the timeframe in which that work needs to be completed. The project schedule reflects all the work associated with delivering the project on time. One of the first steps in the initiation phase of the project is to come up with a project schedule. To establish a project schedule, you need to create a work breakdown structure.  
  
 Create a project structure with a work breakdown structure, which helps you:  
  
- Break down work into manageable tasks  
  
- Estimate the time required to complete a task  
  
- Set task dependencies and task duration  
  
- Determine the roles required to complete each task  
  
  The project schedule in the work breakdown structure has a familiar look and feel, complete with an interactive Gantt chart.  
  
## Create a work breakdown structure for a project  
 Create a work breakdown structure to represent the sequence of tasks in a project. The work breakdown structure includes tasks, requirements for each task, and revenue and cost information. In your work breakdown structure, you can add:  
  
-   The sequence of tasks in a hierarchy  
  
-   Other tasks, if any, that must be completed before a task can be started  
  
-   The starting date, ending date, and duration of a task  
  
-   The number of hours required for a task  
  
-   Any required worker skills and education  
  
-   The workers who are assigned to a task  
  
-   Estimated revenue and costs  
  
## Task types  
You’ll use the following types of tasks when creating your work breakdown structure:  

| | | 
|---------------------------------------|-----------------------------------------------------------------| 
| **Project root node** | The top-level summary task for the project. All other project tasks are created under it. The name of the root task is the project name. The effort, dates, and duration of the root node are based on the values on the hierarchy below it. You can’t edit root node properties or delete the root node. | 
| **Summary or container tasks** | A summary task is a task that has sub-tasks under it. A summary task doesn’t have any work effort or cost of its own. Its work effort and cost are a rollup of its sub-tasks. You can change the name of a summary task, but you can’t change the effort, dates, or duration, because those are automatically calculated. Deleting a summary task deletes the task and all of its sub-tasks.|  
| **Leaf node tasks** | A leaf node task represents the most detailed work on the project. It has an estimated effort, a planned number of resources, planned start and end dates, and a duration.|

  
## Task hierarchy  
 You have the following options when creating a task hierarchy:  
  
- **Add task**.   You can add a task at a position you choose in the task hierarchy. If you don’t select a position, your new task appears at the end.  
  
- **Indent task**.   Indent a task to make it a child of the task directly above it.  
  
- **Outdent task**.   Outdent a task to make it so it’s no longer a sub-task of its original parent task.  
  
- **Move up and Move down**.   Move tasks up and down in the hierarchy of its parent task. Moving a task up or down has no effect on its effort, cost, dates, or duration.  
  
## Task attributes  
 A task’s name describes the work that needs to be completed. You use various task attributes to describe the schedule and staffing requirements for the task.  
  
### Schedule attributes

 - Assign values to **Effort hours**, **Number of resources**, **Start date**, **End date**, and **Duration** to determine the schedule for the task. 
 - **Effort** is an estimate of the hours it takes to complete the task.
 - **Number of resources** is an estimate that the project manager puts in the task to help come up with the best possible schedule. 
 - **Duration** (in days) indicates the number of work days it will take to complete the task.  
  
### Staffing attributes

 - **Role**, **Resource organizational unit**, **Number of resources**, and **Resources** describe the staffing requirements for the task. 
 - **Role** describes the type of resource needed to perform the task. 
 - **Resource organizational unit** indicates the organizational unit from which resources should be staffed for that task; this also impacts the cost and sales estimate of the task, since this is accounted for when determining the unit sales price for the resource. 
 - **Resources** holds a generic resource or a named resource when one is found.  
  
## Task dependencies  
 You can create predecessor relationships between one or more tasks in the work breakdown structure. You can set one or more values for the predecessor field on tasks to indicate the tasks that it will be dependent on. When you assign a predecessor value to a task, the task can only start when all the predecessor tasks have completed. Setting this dependency on a task will result in the recalculation of the planned start date of the task as the latest end of all of its predecessors. Predecessor-related impacts on a schedule are not limited by the task mode defined on the task.  
  
## Task mode  
 Task mode is one of the important factors that determine scheduling leaf node tasks. There are two task modes for every task: auto scheduling mode and manual scheduling mode.  
  
-   **Auto scheduling**.   When you set the task mode to Automatically Scheduled, the task scheduling engine uses the scheduling rules on the following task attributes to determine the schedule for the task:  
  
    -   Predecessors  
  
    -   Effort  
  
    -   Number of resources  
  
    -   Start and end dates  
  
-   **Scheduling rules**.   The start date of a leaf node task that does not have predecessors defaults to the project’s scheduling start date. The duration of a leaf node task is always calculated as the number of working days between its start and end dates. When a task is automatically scheduled, the scheduling engine follows the rules below:  
  
    -   Start and end dates of a task must always be working days according to the project’s scheduling calendar  
  
    -   The start date of a task that has predecessors defaults to the latest end date of its predecessors  
  
    -   Effort = Number of people * Duration * hours in a standard work day of the project calendar  
  
-   **Manual scheduling**.   In some cases, you might want to deviate from these rules. In these cases, you can set the task mode for the task to be manually scheduled. This stops the scheduling engine from calculating the values for other scheduling attributes. Setting predecessors on tasks always impacts the dependent task’s start date.  
  
## Create a work breakdown structure  
  
1.  Go to **Project Service > Projects**.  
  
2.  Click the project you want to work on.  
  
3.  In the bar across the top of the screen, select the down arrow next to the project name, and then click Work breakdown structure.  
  
4.  To add a task, click **Add Task**. Fill in the fields for the task, and then click **Save**.  
  
5.  Continue adding tasks until your work breakdown structure is complete. While creating your work breakdown structure, you can do the following to organize your tasks:  
  
    -   Select a task and click **Indent** to move it under another task or click Outdent to move it out a level.  
  
    -   Select a task and click **Move Up** or **Move Down** to move it up or down in the list.  
  
    -   Click **Hide Gantt** to hide the Gantt chart, and click **Show Gantt** to display it again.  
  
    -   Select a different period of time for the Gantt chart in **Time Scale**.  
  
6.  To add the roles you specified in your work breakdown structure to your project’s team members, click **Generate Project Team**.  
  
7.  Click **Save** at the bottom right corner of the screen when you’re done making changes.  
  
### See Also  
 [Project manager guide](../project-service/project-manager-guide.md)
