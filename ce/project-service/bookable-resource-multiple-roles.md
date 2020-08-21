---
title: Setup for a bookable resource to be priced or costed for mulitple roles on the same project 
description: This topic provides an overview of pricing dimensions.
author: rumant
manager: kfend
ms.custom: 
  - dyn365-projectservice
ms.date: 9/1/2020
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365PS
  - ProjectOperations
---

# Pricing or costing a single bookable resource for multiple roles on a project 

Often, project- based companies will see the need for a single resource to perform mulitple roles on a project. Each of these roles could priced and costed differently in which case, the same resource's time on the project could get a different financial estimate depending on the bill rates and cost rate for each of the 2 roles. PSA application enables you to achieve this quite simply by allowing the setup of the values on the Team member record for the named resource and allowing different overrides on each of the tasks that the team member is assigned to.

Below is an example walkthrough that explains how this simple override of this value on that allows for a resource to play multiple roles with different cost and bill rates on the project.

## Create tasks
Create 2 project tasks: Task A and Task B for 40 hours each. Select Task A as a predecessor for Task B

## Setup Role and Organization Unit for a generic project team member

On Task A, you can create a Team Member. From the resources field on the Task row on Schedule page, click the dropdown and click on **Create** in the dropdown
This will open the Team Member Quick form.
On this form, the user can specify the attributes of the Generic Team Member who can perfotm this task.
Select the appropriate role and Organizational unit on this form and save and close the quick create form ie. Consulting Lead and Fabrikam US
A Generic Team Member is created and assigned to this task 

Repeat these steps for TAsk B and make sure that the Role and Organizational unit on the Generic Team Member created for Task B is different from Task A. This would Network Technician and Fabrikam US based on our example data that references PSA demo data 

## Setup Role and Organization Unit for a project task

After creation of Task A, select the task and using the **Edit task** button, open the task details  page.
Find the Role and Organizational Unit on the Task details page and setup the role and ORganizational unit field values that are required of a resource that would perform this task. If trying this scenarios using PSA demo data, you can pick Consulting Lead role and Fabrikam US as the values here.
Save and Close the task details page 

Now proceed to select Task B and using the **Edit task** button, open the task details  page.
Find the Role and Organizational Unit on the Task details page and setup the Role and Organizational unit field values that are required of a resource that would perform this task. Make sure that the role and Organizational Unit values on Task B are different from those Task A. If trying this scenarios using PSA demo data, you can pick Network Technician role and Fabrikam US as the values here.
Save and Close the task details page. 

## Behavior of Team Member and Estimates when the same Bookable Resource is staffed for both the generic team member-based requirements

Open the tab for Team Member and select the 2 generic Team Members and using the grid toolbar click on Generate Requirements.Resource Requirements will be generated. 
Proceed to select the Team Member row for Consulting Lead and click on "Book". The schedule board opens and book a resource on that requirement.
Proceed to select the Team member row for Network Technician and click on "Book". The schedule board opens and book the same as above resource on that requirement as well.

### Team Member grid Experience
Back on the Team Member grid, you will notice that the 2 generic Team member records and deleted and have been replaced one resource that was booked for both. There one role on the Team Member grid that shows one default role and organizational unit values.
Now expand the row of that Team Member record. Distinct assignments of the Team member record for both of those tasks are shown.    
### Estimates grid Experience
When you navigate to the Estimates grid, you will notice that both assignments for the same resource are priced differently.
The assignment for the resource on Task A is priced using the Role attribute value of Consulting Lead and the assignment for the same resource on Task B is priced using the Tole attribute value of Network Technician.





