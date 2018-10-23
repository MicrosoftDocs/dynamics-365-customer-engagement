---
title: Set up resource categories for Service Scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to create and set up resource categories for service scheduling in Dynamics 365 for Customer Service
keywords: Resource categories; Service Scheduling; Dynamics 365; Customer Service; Universal Resource Scheduling (URS)
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: 6054e91b-05ce-49d3-b9ad-6b50d5146cfa
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create and manage resource categories 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

With bookable resource categories, you can group your bookable resources by type. For example, you can create categories like technician, supervisor, subcontractor, vehicle, or equipment.

## Create a new resource category

Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

1. In the Customer Service Hub sitemap, go to **Service Scheduling**.
2. From the list of entity records, select **Scheduling > Resource Category**.
   - The **Active Resource Categories** view is displayed. You can switch between various system views using the drop-down menu.
   - Select any existing resource category to see additional options in the command bar

3. On the command bar, select **New** to create a new bookable resource category. 
4. In the **General** section:
 
   - Enter a **Name** and a **Description** for the resource category

5. Select **Save**. A new resource category is created and is activated by default. 

6. In the **Related** section, you can view and manage various resource category associations.

   ![resource categories](media/resource-categories.png)

Similarly, you can create a new requirement resource category for requirements. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a requirement resource category](#create-a-requirement-resource-category).

## Add resources to a resource category

To assign resources to a resource category:

1. In the **Related** section, go to **Resource Category Associations**.

2. Select **Add New Bookable Resource Category Association**. A resource category is populated. 

3. Add a resource to this resource category by selecting a resource in the **Resource** box. You can either lookup for an existing resource or create a new one.

## Create a requirement resource category

1. In the **Related** section, go to **Requirement Resource Category**.

2. Select **Add New Requirement Resource Category** and fill the required fields. A requirement resource category is created.


### See also 
[Service Scheduling overview](basics-service-service-scheduling.md)